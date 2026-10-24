namespace LlmAct.Utils
{
    public static class Strings
    {
        public static string? TrimOrNull(this string? text)
        {
            return string.IsNullOrWhiteSpace(text) ? null : text.Trim();
        }
    }
}