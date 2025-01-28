using System;
using System.Collections.Generic;

namespace Zelda
{
    public enum ELArgType { text, list, field, expression, selector, number, boolean }

    public class ELWiki
    {
        public int version;
        public DateTime date;
        public List<ELFunction> functions;
    }

    public class ELFunction
    {
        public string function { get; set; }
        public string blurb { get; set; }
        public ELCategory category { get; set; }
        public string prototype;
        public string description;
        public string examples;
        public string wikiUrl;
        public List<ELFunctionArg> args;
        public Version minVersion;

        public string filter { get { return $"{function}|{blurb}|{category}"; } }

        public ELFunction(ELCategory cat, ELFunctions function, string blurb, string url = null, string proto = null)
            :this(cat, function.ToString(), blurb, url, proto)
        {
        }

        public ELFunction(ELCategory cat, string name, string blurb, string url = null, string proto = null)
        {
            this.function = name;
            this.blurb = blurb;
            category = cat;
            wikiUrl = url;
            prototype = proto;
        }
    }

    public class ELFunctionArg
    {
        public string name;
        public string blurb;
        public ELArgType type;
        public string description;
        public bool isOptional;
        public string defaultValue;
        public bool repeats;
    }
}
