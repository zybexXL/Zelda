using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zelda
{
    public class JRField
    {
        public string name;
        public string displayName;
        public string value;

        public JRField(string name, string displayName = null, string value = null)
        {
            this.name = name;
            this.displayName = displayName;
            this.value = value;
        }
    }
}
