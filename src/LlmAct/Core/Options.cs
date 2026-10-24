using CommandLine;

// ReSharper disable ClassNeverInstantiated.Global

namespace LlmAct.Core
{
	public class Options
	{
		[Option('r', "run", HelpText = "Run one model.")]
		public string? RunModel { get; set; }
	}
}