using System;

namespace Application;

/// <summary>
/// Main Step (1)
/// </summary>
public class DateParser : object
{
	public DateParser() : base()
	{
	}

	/// <summary>
	/// Main Step (2)
	/// </summary>
	public int GetYearFromDateTime(string dateTimeAsString)
	{
		var dateTime =
			System.DateTime.Parse(s: dateTimeAsString);

		var year =
			dateTime.Year;

		return year;
	}

	/// <summary>
	/// Step (9)
	/// </summary>
	public int GetYearFromSplit(string dateTimeAsString)
	{
		// "2023-11-12T20:12:13Z" -> Split -> Array: { "2023" "11" "12T20:12:13Z" }

		var splitOnHyphyn =
			dateTimeAsString.Split(separator: '-');

		var year =
			int.Parse(s: splitOnHyphyn[0]);

		return year;
	}

	/// <summary>
	/// Step (13,1)
	/// </summary>
	public int GetYearFromSubstring(string dateTimeAsString)
	{
		var indexOfHyphen =
			dateTimeAsString.IndexOf(value: '-');

		var yearString = dateTimeAsString
			.Substring(startIndex: 0, length: indexOfHyphen);

		var year =
			int.Parse(s: yearString);

		return year;
	}

	/// <summary>
	/// Step (13,2)
	/// </summary>
	public int GetYearFromSpan(System.ReadOnlySpan<char> dateTimeAsSpan)
	{
		// IndexOf -> using System;
		var indexOfHyphen =
			dateTimeAsSpan.IndexOf(value: '-');

		var yearAsSpan = dateTimeAsSpan
			.Slice(start: 0, length: indexOfHyphen);

		var year =
			int.Parse(s: yearAsSpan);

		return year;
	}

	/// <summary>
	/// Step (13,3)
	/// </summary>
	public int GetYearFromSpanWithManualConversion(System.ReadOnlySpan<char> dateTimeAsSpan)
	{
		// IndexOf -> using System;
		var indexOfHyphen =
			dateTimeAsSpan.IndexOf(value: '-');

		var yearAsSpan = dateTimeAsSpan
			.Slice(start: 0, length: indexOfHyphen);

		//var year =
		//	int.Parse(s: yearString);

		var result = 0;
		for (int index = 0; index < yearAsSpan.Length; index++)
		{
			result = result * 10 + (yearAsSpan[index] - '0');
		}

		return result;
	}
}
