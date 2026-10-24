using System;

namespace LlmAct.Utils
{
    public static class Logger
    {
        public static void LogError(string text)
        {
            Console.Error.WriteLine(text);
        }

        public static void LogInfo(string text)
        {
            Console.WriteLine(text);
        }
    }
}