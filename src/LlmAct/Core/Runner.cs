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
            
            // TODO !
        }
    }
}