using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodSample
{
    public static class Extension
    {
        public static string RemoveSpace(this string str)
        {
            return str.Replace(" ", string.Empty);
        }
    }
}
