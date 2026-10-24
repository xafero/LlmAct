using System;
using LlmAct.Utils;

namespace LlmAct.Core
{
    internal static class Runner
    {
        public static void Run(Options o)
        {
            if (o.RunModel.TrimOrNull() is not { } model)
            {
                Logger.LogError($"No model given!");
                return;
            }
            var reader = new GGUFSharp.GGUFReader();
            var gguf = reader.Read(model);
            Console.WriteLine(gguf);
        }
    }
}