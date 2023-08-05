// Note: We do not use this format, Because of .NET Framework 4.8.1
//namespace Application;

namespace Application
{
	internal static class Program : object
	{
		static Program()
		{
		}

		private static void Main()
		{
			BenchmarkDotNet.Running.BenchmarkRunner.Run
				(assembly: typeof(DateParserBenchmarks).Assembly);
		}
	}
}
