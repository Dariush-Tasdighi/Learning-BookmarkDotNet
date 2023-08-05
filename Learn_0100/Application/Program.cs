namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	/// <summary>
	/// Main Step (7) - In Release Mode! Not in Debug Mode!
	/// </summary>
	private static void Main()
	{
		//BenchmarkDotNet.Running.BenchmarkRunner.Run<DateParserBenchmarks>();

		//BenchmarkDotNet.Running.BenchmarkRunner
		//	.Run(type: typeof(DateParserBenchmarks));

		BenchmarkDotNet.Running.BenchmarkRunner.Run
			(assembly: typeof(DateParserBenchmarks).Assembly);
	}
}
