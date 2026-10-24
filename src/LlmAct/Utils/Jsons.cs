using System.Text.Encodings.Web;
using System.Text.Json;

namespace LlmAct.Utils
{
    public static class Jsons
    {
        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj, GetConfig());
        }

        private static JsonSerializerOptions GetConfig()
        {
            return new JsonSerializerOptions
            {
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                WriteIndented = true
            };
        }
    }
}