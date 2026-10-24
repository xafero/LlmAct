using System.Collections.Generic;
using GGUFSharp;

namespace LlmAct.Utils
{
    public static class Colls
    {
        public static Dictionary<string, string> ToDict(this IEnumerable<GGUFMetaItem> items)
        {
            var dict = new Dictionary<string, string>();
            foreach (var item in items)
            {
                var txt = item.ToString().Split(':', 2);
                var key = txt[0];
                var val = txt[1];
                dict[key] = val;
            }
            return dict;
        }
    }
}