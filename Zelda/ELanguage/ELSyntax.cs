using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Zelda
{
    public enum ELTokenType { Default = 0, Function = 1, Math, Field, Variable, Number, HTML, Symbol, Escaped, Literal, Comment }

    public class ELToken
    {
        public ELTokenType type;
        public ELFunctions function = ELFunctions.Unknown;
        public int pos;
        public int len;
        public string text;
        public int functionLen;                     // total function length including args
        public List<int> separators = new List<int>();     // index of commas and parenthesis

        public ELToken(ELTokenType t, string txt, int i)
        {
            type = t;
            pos = i;
            len = functionLen = txt.Length;
            text = txt;
            if (t == ELTokenType.Function)
            {
                Enum.TryParse(txt, true, out function);
                if (function > ELFunctions.Math)
                    type = ELTokenType.Math;
            }
        }

        public override string ToString()
        {
            return $"{type}: {pos}-{pos+len}, {text}, totalLen={functionLen}";
        }
    }

    public class ELSyntax
    {
        List<string> functions = new List<string>();
        Regex reFunctions;
        Regex reTypeCast;
        Regex reFields;
        Regex reHTML;
        Regex reLiteral;
        Regex reEscaped;
        Regex reNumbers;
        Regex reComment;
        bool initialized;

        public List<ELToken> Tokens = new List<ELToken>();
        public List<ELToken> Functions = new List<ELToken>();

        public ELSyntax()
        {

        }

        public ELSyntax(List<string> fields, List<string> extraFuncs)
        {
            initialized = true;
            
            functions.AddRange(Enum.GetNames(typeof(ELFunctions)));
            if (extraFuncs != null)
                functions.AddRange(extraFuncs);
            functions.Remove("Unknown");

            // known functions names
            reFunctions = new Regex($"({string.Join("|", functions)})\\(", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            reTypeCast = new Regex($@"&datatype=\[(list|string|number|integer|path|month)\]", RegexOptions.IgnoreCase | RegexOptions.Compiled);

            // fields: [Name] and [Name,args]
            if (fields != null)
            {
                string fieldList = Regex.Escape(string.Join("\uE000", fields)).Replace("\uE000", "|");
                reFields = new Regex($@"\[({fieldList})(\s*,[^\]]*)?\]", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            }
            else reFields = null;

            // HTML tags: <tagName args> and <//tagName>
            reHTML = new Regex($@"\<(?://)?(?:font|img|b|u|i)\b.*?\>", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

            // literal blocks: /* literal text /*
            reLiteral = new Regex(@"/\*.*?/\*", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

            // escaped: chars escaped with fwd-slash, or anything between /# and #/
            reEscaped = new Regex(@"(/#.*?#/)|(?:^|[^#/])((?:/[^#])+)", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);

            // comment: special fields named '/' -> "[//, this is a comment]"
            reComment = new Regex(@"\[//+,.*?\]|^##.*$", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);

            // numbers - attention needed with function "log10()" !! 
            reNumbers = new Regex(@"(?<![\w])(-?\d+(?:\.\d+)?|#[a-f\d]+)(?:\b)", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
        }

        public List<ELToken> getTokens(string expression, bool doComments=true)
        {
            List<ELToken> tokens = new List<ELToken>();
            MatchCollection hits = null;
            if (!initialized) return tokens;

            // fields;
            if (reFields != null)
            {
                hits = reFields.Matches(expression);
                foreach (Match m in hits)
                    tokens.Add(new ELToken(ELTokenType.Field, m.Value, m.Index));
            }

            // functions - populate Functions() list
            hits = reFunctions.Matches(expression);
            List<ELToken> funcs = new List<ELToken>();
            foreach (Match m in hits)
                funcs.Add(new ELToken(ELTokenType.Function, m.Groups[1].Value, m.Groups[1].Index));

            tokens.AddRange(funcs);
            Functions = funcs;

            // symbols - function parenthesis and commas
            // scan functions for total length and argument split
            string expr = expression + " ";  // prevent overflow
            foreach (var f in funcs)
            {
                // mark function parenthesis and commas
                scanFunction(f, expr);
                for (int i = 0; i < f.separators.Count; i++)
                    tokens.Add(new ELToken(ELTokenType.Symbol, expression.Substring(f.separators[i], 1), f.separators[i]));

                // find user variables created with save() function
                if (f.text.ToLower() == "save" && f.separators.Count>=3)
                {
                    string saveVar = expression.Substring(f.separators[1] + 1, f.separators[2] - f.separators[1] - 1);
                    int offset = saveVar.IndexOf(saveVar.Trim());
                    saveVar = saveVar.Trim();
                    if (!string.IsNullOrEmpty(saveVar) && Regex.IsMatch(saveVar, @"[\w\d_]+"))
                        tokens.Add(new ELToken(ELTokenType.Variable, saveVar, f.separators[1] + 1 + offset));
                }
            }

            // user saved variables
            List<string> userVars = tokens.Where(t=>t.type == ELTokenType.Variable).Select(t=>t.text).ToList();
            Regex reVars = new Regex($@"\[(N|L\d|R\d|{string.Join("|", userVars)})(\s*,[^\]]*)?\]", RegexOptions.IgnoreCase | RegexOptions.Compiled);
            hits = reVars.Matches(expression);
            foreach (Match m in hits)
                tokens.Add(new ELToken(ELTokenType.Variable, m.Value, m.Index));

            // type casts - paint as function but don't include in function list
            hits = reTypeCast.Matches(expression);
            foreach (Match m in hits)
                tokens.Add(new ELToken(ELTokenType.Function, m.Value, m.Index));

            // escaped
            hits = reEscaped.Matches(expression);
            foreach (Match m in hits)
                if (!string.IsNullOrEmpty(m.Groups[1].Value))
                    tokens.Add(new ELToken(ELTokenType.Escaped, m.Groups[1].Value, m.Groups[1].Index));
                else
                    tokens.Add(new ELToken(ELTokenType.Escaped, m.Groups[3].Value, m.Groups[3].Index));

            // HTML
            hits = reHTML.Matches(expression);
            foreach (Match m in hits)
                tokens.Add(new ELToken(ELTokenType.HTML, m.Value, m.Index));

            // Numbers
            hits = reNumbers.Matches(expression);
            foreach (Match m in hits)
                tokens.Add(new ELToken(ELTokenType.Number, m.Groups[1].Value, m.Groups[1].Index));

            // literals (escaped)
            hits = reLiteral.Matches(expression);
            foreach (Match m in hits)
                tokens.Add(new ELToken(ELTokenType.Literal, m.Value, m.Index));

            // comments
            if (doComments)
            {
                hits = reComment.Matches(expression);
                foreach (Match m in hits)
                    tokens.Add(new ELToken(ELTokenType.Comment, m.Value, m.Index));
            }

            Tokens = tokens;
            return tokens;
        }

        void scanFunction(ELToken token, string expression)
        {
            int level = 0;
            bool skip = false;
            bool skip2 = false;
            bool skip3 = false;
            try
            {
                for (int i = token.pos; i < expression.Length - 1; i++)
                {
                    // block escape content
                    if (skip)
                    {
                        if (expression[i] == '#' && expression[i + 1] == '/')
                        {
                            skip = false;
                            i++;
                        }
                        continue;
                    }
                    if (skip2)
                    {
                        if (expression[i] == ']') skip2 = false;
                        continue;
                    }
                    // block escape start
                    if (expression[i] == '/' && expression[i + 1] == '#')
                    {
                        skip = true;
                        i++;
                        continue;
                    }
                    // block escape start
                    if (expression[i] == '/' && expression[i + 1] == '*')
                    {
                        skip3 = !skip3;
                        i++;
                        continue;
                    }
                    // literal char
                    else if (expression[i] == '[') skip2 = true;
                    else if (expression[i] == '/') i++;
                    else if (expression[i] == '(' && level++ == 0)
                        token.separators.Add(i);
                    else if (expression[i] == ')' && --level == 0)
                    {
                        token.separators.Add(i);
                        token.functionLen = i - token.pos + 1;
                        return;
                    }
                    else if (expression[i] == ',' && level == 1)
                        token.separators.Add(i);

                }
                token.functionLen = expression.Length - token.pos - 1;
            }
            catch (Exception ex) {
                Logger.Log(ex); }
        }
    }
}
