// **************************************************
namespace Application;

/// <summary>
/// Main Step (3)
/// </summary>
public class DateParserBenchmarks : object
{
	/// <summary>
	/// Main Step (4)
	/// </summary>
	private static readonly DateParser dateParser = new();

	/// <summary>
	/// Main Step (5)
	/// </summary>
	private const string DateTimeArgument = "2023-11-12T20:12:13Z";

	public DateParserBenchmarks() : base()
	{
	}

	/// <summary>
	/// Main Step (6)
	/// </summary>
	[BenchmarkDotNet.Attributes.Benchmark]
	public void GetYearFromDateTime()
	{
		dateParser.GetYearFromDateTime
			(dateTimeAsString: DateTimeArgument);
	}
}
// **************************************************

// **************************************************
//namespace Application;

///// <summary>
///// Step (8)
///// </summary>
//[BenchmarkDotNet.Attributes.RankColumn]
//[BenchmarkDotNet.Attributes.MemoryDiagnoser]
//[BenchmarkDotNet.Attributes.Orderer
//	(summaryOrderPolicy: BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
////[BenchmarkDotNet.Attributes.Orderer
////	(summaryOrderPolicy: BenchmarkDotNet.Order.SummaryOrderPolicy.SlowestToFastest)]
//public class DateParserBenchmarks : object
//{
//	private static readonly DateParser dateParser = new();
//	private const string DateTimeArgument = "2023-11-12T20:12:13Z";

//	public DateParserBenchmarks() : base()
//	{
//	}

//	[BenchmarkDotNet.Attributes.Benchmark]
//	public void GetYearFromDateTime()
//	{
//		dateParser.GetYearFromDateTime
//			(dateTimeAsString: DateTimeArgument);
//	}
//}
// **************************************************

// **************************************************
//namespace Application;

///// <summary>
///// Step (10)
///// </summary>
//[BenchmarkDotNet.Attributes.RankColumn]
//[BenchmarkDotNet.Attributes.MemoryDiagnoser]
//[BenchmarkDotNet.Attributes.Orderer
//	(summaryOrderPolicy: BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
//public class DateParserBenchmarks : object
//{
//	private static readonly DateParser dateParser = new();
//	private const string DateTimeArgument = "2023-11-12T20:12:13Z";

//	public DateParserBenchmarks() : base()
//	{
//	}

//	/// <summary>
//	/// Step (11) -> Add new Column: Ratio
//	/// </summary>
//	//[BenchmarkDotNet.Attributes.Benchmark]
//	[BenchmarkDotNet.Attributes.Benchmark(Baseline = true)]
//	public void GetYearFromDateTime()
//	{
//		dateParser.GetYearFromDateTime
//			(dateTimeAsString: DateTimeArgument);
//	}

//	/// <summary>
//	/// Step (12)
//	/// </summary>
//	[BenchmarkDotNet.Attributes.Benchmark]
//	public void GetYearFromSplit()
//	{
//		dateParser.GetYearFromSplit
//			(dateTimeAsString: DateTimeArgument);
//	}
//}
// **************************************************

// **************************************************
//namespace Application;

///// <summary>
///// Step (14)
///// </summary>
//[BenchmarkDotNet.Attributes.RankColumn]
//[BenchmarkDotNet.Attributes.MemoryDiagnoser]
//[BenchmarkDotNet.Attributes.Orderer
//	(summaryOrderPolicy: BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
//public class DateParserBenchmarks : object
//{
//	private static readonly DateParser dateParser = new();
//	private const string DateTimeArgument = "2023-11-12T20:12:13Z";

//	public DateParserBenchmarks() : base()
//	{
//	}

//	[BenchmarkDotNet.Attributes.Benchmark(Baseline = true)]
//	public void GetYearFromDateTime()
//	{
//		dateParser.GetYearFromDateTime
//			(dateTimeAsString: DateTimeArgument);
//	}

//	[BenchmarkDotNet.Attributes.Benchmark]
//	public void GetYearFromSplit()
//	{
//		dateParser.GetYearFromSplit
//			(dateTimeAsString: DateTimeArgument);
//	}

//	/// <summary>
//	/// Step (15,1)
//	/// </summary>
//	[BenchmarkDotNet.Attributes.Benchmark]
//	public void GetYearFromSubstring()
//	{
//		dateParser.GetYearFromSubstring
//			(dateTimeAsString: DateTimeArgument);
//	}

//	/// <summary>
//	/// Step (15,2)
//	/// </summary>
//	[BenchmarkDotNet.Attributes.Benchmark]
//	public void GetYearFromSpan()
//	{
//		dateParser.GetYearFromSpan
//			(dateTimeAsSpan: DateTimeArgument);
//	}

//	/// <summary>
//	/// Step (15,3)
//	/// </summary>
//	[BenchmarkDotNet.Attributes.Benchmark]
//	public void GetYearFromSpanWithManualConversion()
//	{
//		dateParser.GetYearFromSpanWithManualConversion(dateTimeAsSpan: DateTimeArgument);
//	}
//}
// **************************************************

// **************************************************
/// <summary>
/// Step (16)
/// </summary>
// **************************************************
// Go to:
//			?\Learning Benchmark\Learn_0100\
//				Application\bin\Release\net7.0\BenchmarkDotNet.Artifacts\results
//
// 1. Application.DateParserBenchmarks-report.csv
// 2. Application.DateParserBenchmarks-report.html
// 3. Application.DateParserBenchmarks-report-github.md
// **************************************************
