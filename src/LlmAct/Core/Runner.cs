using System;
using LlmAct.Utils;
using static LlmAct.Utils.Logger;

namespace LlmAct.Core
{
    internal static class Runner
    {
        public static void Run(Options o)
        {
            if (o.RunModel.TrimOrNull() is not { } model)
            {
                LogError($"No model given!");
                return;
            }
            var reader = new GGUFSharp.GGUFReader();
            var gguf = reader.Read(model);
            LogInfo($"Input = {gguf.FilePath}");
            LogInfo($"GGUF version = {gguf.Version}");
            
            
            
            
            
            
            
            
            Console.WriteLine(gguf.MetaItems);
            Console.WriteLine(gguf.TensorInfos);



            ;







        }
    }
}