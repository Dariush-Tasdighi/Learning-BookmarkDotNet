namespace Application;

internal static class Program : object
{
	static Program()
	{
	}

	private static void Main()
	{
		BenchmarkDotNet.Running.BenchmarkRunner.Run
			(assembly: typeof(Program).Assembly);
	}
}
