using System;
using LlmAct.Utils;
using static LlmAct.Utils.Files;
using static LlmAct.Utils.Logger;

namespace LlmAct.Core
{
    internal static class Inspector
    {
        public static void Run(Options o)
        {
            if (o.InspectIt.TrimOrNull() is not { } modelPath)
            {
                LogError($"No model given!");
                return;
            }
            foreach (var file in GetFiles(modelPath))
            {
                var reader = new GGUFSharp.GGUFReader();
                var gguf = reader.Read(file);
                LogInfo($"Input = {gguf.FilePath}");
                LogInfo($"GGUF version = {gguf.Version}");
                var meta = gguf.MetaItems.ToDict();
                meta.Remove("tokenizer.chat_template");
                Console.WriteLine(meta.ToJson());
            }
        }
    }
}