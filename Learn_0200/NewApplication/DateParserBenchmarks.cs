// **************************************************
// In Application.csproj
// <TargetFramework>net7.0</TargetFramework>
// <TargetFrameworks>net7.0;net4.8.1</TargetFrameworks>
// **************************************************
namespace Application
{
	[BenchmarkDotNet.Attributes.SimpleJob
		(runtimeMoniker: BenchmarkDotNet.Jobs.RuntimeMoniker.Net70)]
	[BenchmarkDotNet.Attributes.SimpleJob
		(runtimeMoniker: BenchmarkDotNet.Jobs.RuntimeMoniker.Net481)]

	//[BenchmarkDotNet.Attributes.SimpleJob
	//	(runtimeMoniker: BenchmarkDotNet.Jobs.RuntimeMoniker.Net70)]
	//[BenchmarkDotNet.Attributes.SimpleJob
	//	(runtimeMoniker: BenchmarkDotNet.Jobs.RuntimeMoniker.Net481, baseline: true)]

	[BenchmarkDotNet.Attributes.RankColumn]
	[BenchmarkDotNet.Attributes.MemoryDiagnoser]
	[BenchmarkDotNet.Attributes.Orderer
		(summaryOrderPolicy: BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
	public class DateParserBenchmarks : object
	{
		private const string DateTimeArgument = "2023-11-12T20:12:13Z";
		private static readonly DateParser dateParser = new DateParser();

		public DateParserBenchmarks() : base()
		{
		}

		[BenchmarkDotNet.Attributes.Benchmark(Baseline = true)]
		public void GetYearFromDateTime()
		{
			dateParser.GetYearFromDateTime
				(dateTimeAsString: DateTimeArgument);
		}

		[BenchmarkDotNet.Attributes.Benchmark]
		public void GetYearFromSubstring()
		{
			dateParser.GetYearFromSubstring(dateTimeAsString: DateTimeArgument);
		}
	}
}
// **************************************************
