using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;

namespace LlmAct.Utils
{
    public static class Jsons
    {
        private static JsonSerializerOptions GetConfig()
        {
            return new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
        }

        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj, GetConfig());
        }

        public static T? FromJson<T>(this string txt)
        {
            return JsonSerializer.Deserialize<T>(txt, GetConfig());
        }

        public static T? ReadFile<T>(string file)
        {
            return File.ReadAllText(file, Encoding.UTF8).FromJson<T>();
        }
    }
}