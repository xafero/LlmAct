using CommandLine;
using System;
using LlmAct.Core;
using LlmAct.Utils;

namespace LlmAct
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var parser = Parser.Default;
            parser.ParseArguments<Options>(args).WithParsed(o =>
            {
                if (o.RunModel != null)
                {
                    Runner.Run(o);
                    return;
                }
            });
        }
    }
}