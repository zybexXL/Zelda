using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zelda
{
    [DesignerCategory("code")]
    public class WikiView2 : UserControl
    {
        //private IContainer components = null;
        public WebView2 webWiki { get; private set; } = new WebView2();
        public bool Initialized { get; private set; }

        public event EventHandler OnInitializationCompleted;

        CancellationTokenSource cancelSource;
        HttpClient httpClient = new HttpClient();
        string wikiPreloaded;

        private void InitializeComponent()
        {
            SuspendLayout();
            //((ISupportInitialize)(webWiki)).BeginInit(); 

            webWiki.AllowExternalDrop = false;
            webWiki.DefaultBackgroundColor = Color.White;
            webWiki.Dock = DockStyle.Fill;
            webWiki.Margin = new Padding(2);
            webWiki.Name = "webWiki";
            webWiki.ZoomFactor = 1D;

            //((ISupportInitialize)(webWiki)).EndInit();
            Controls.Add(webWiki);
            ResumeLayout(true);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            webWiki.Dispose();
            base.Dispose(disposing);
        }

        public WikiView2()
        {
            InitializeComponent();
            Load += WikiView2_Load;
        }

        private void WikiView2_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            webWiki.CoreWebView2InitializationCompleted += WebWiki_CoreWebView2InitializationCompleted;
            var env = CoreWebView2Environment.CreateAsync(null, Constants.WebView2Data).Result;
            webWiki.EnsureCoreWebView2Async(env);
        }

        private void WebWiki_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            Initialized = e.IsSuccess;
            if (Initialized)
            {
                webWiki.CoreWebView2.Profile.PreferredColorScheme = CoreWebView2PreferredColorScheme.Light;
                webWiki.CoreWebView2.AddWebResourceRequestedFilter("*", CoreWebView2WebResourceContext.Document);
                webWiki.CoreWebView2.WebResourceRequested += CoreWebView2_WebResourceRequested;
                webWiki.CoreWebView2.ContextMenuRequested += CoreWebView2_ContextMenuRequested;
            }
            OnInitializationCompleted?.Invoke(this, e);
        }

        public void LoadWiki(ELFunction func)
        {
            LoadWiki(func.ToString(), func);
        }

        public void LoadWiki(string name, ELFunction func)
        {
            if (!Initialized)
                return;

            string style= @"<body style=""background-color:#F6F6F6;"">";
            if (name == null)
                webWiki.NavigateToString($"{style}no function highlighted");
            else if (string.IsNullOrEmpty(func?.wikiUrl))
                webWiki.NavigateToString($"{style}<b>{name}():</b> Wiki not available for this function");
            else
            {
                cancelSource?.Cancel();
                cancelSource = new CancellationTokenSource();
                Task.Run(() => PreloadWiki(func?.wikiUrl, cancelSource.Token));
            }
        }

        private void PreloadWiki(string url, CancellationToken cancel)
        {
            var resp = httpClient.GetAsync(url).Result;
            if (resp.IsSuccessStatusCode && !cancel.IsCancellationRequested)
            {
                wikiPreloaded = resp.Content.ReadAsStringAsync().Result;     // preload HTML
                if (!cancel.IsCancellationRequested)
                    BeginInvoke((MethodInvoker)delegate { webWiki.Source = new Uri(url); });
            }
        }

        private void CoreWebView2_ContextMenuRequested(object sender, CoreWebView2ContextMenuRequestedEventArgs e)
        {
            for (int i = 0; i < e.MenuItems.Count; i++)
            {
                if (e.MenuItems[i].Name.ToLower().Contains("inspect"))
                {
                    e.MenuItems.RemoveAt(i);
                    break;
                }
            }
        }

        private void CoreWebView2_WebResourceRequested(object sender, CoreWebView2WebResourceRequestedEventArgs e)
        {
            if (!e.Request.Uri.StartsWith("https://wiki.jriver.com/index.php/"))
                return;

            if (!Initialized)
                return;

            try
            {
                string html = wikiPreloaded; // resp.Content.ReadAsStringAsync().Result;

                html = Regex.Replace(html, "<script>.*?</script>", "");
                html = Regex.Replace(html, "<a class=\"mw-jump-link\".+?</a>", "");

                var doc = new HtmlAgilityPack.HtmlDocument();
                doc.LoadHtml(html);

                string[] delNodes = { "mw-navigation", "mw-page-base", "mw-head-base", "contentSub", "contentSub2", "siteSub", "siteNotice", "jump-to-nav", "footer", "catlinks" };
                foreach (var n in delNodes)
                {
                    var nn = doc.DocumentNode.Descendants().Where(d => d.Id == n).FirstOrDefault();
                    nn?.Remove();
                }
                var node = doc.DocumentNode.Descendants().Where(d => d.HasClass("mw-indicators")).FirstOrDefault();
                node?.Remove();

                var content = doc.DocumentNode.Descendants().Where(d => d.Id == "content").FirstOrDefault();
                content?.SetAttributeValue("class", "");
                content?.SetAttributeValue("style", "margin: 0 0 0 0; border:0; padding: 10px;");
                //content?.SetAttributeValue("zelda", "1");

                //string html = "<html><body>this works!</body></html>";
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(doc.DocumentNode.OuterHtml));

                CoreWebView2WebResourceResponse response = webWiki.CoreWebView2.Environment.CreateWebResourceResponse(ms, 200, "OK", "Content-Type: text/html; charset=utf-8");
                e.Response = response;
            }
            catch { }
        }
    }
}
