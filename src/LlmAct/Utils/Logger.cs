using System;

namespace LlmAct.Utils
{
    public static class Logger
    {
        public static void LogError(string text)
        {
            Console.Error.WriteLine(text);
        }
    }
}