using System.Collections.Generic;
using System.IO;

namespace LlmAct.Utils
{
    public static class Files
    {
        public static IEnumerable<string> GetFiles(string path)
        {
            var ext = Path.GetExtension(path).TrimOrNull();
            return ext == null ? Directory.EnumerateFiles(path, "*.*") : [path];
        }
    }
}