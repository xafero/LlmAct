using LlmAct.Utils;

namespace LlmAct.Core
{
    public static class Bases
    {
        public static Config Config { get; } = Jsons.ReadFile<Config>("Conf/config.json")!;
    }
}