// Note: We do not use this format, Because of .NET Framework 4.8.1
//namespace Application;

namespace Application
{
	public class DateParser : object
	{
		public DateParser() : base()
		{
		}

		public int GetYearFromDateTime(string dateTimeAsString)
		{
			var dateTime =
				System.DateTime.Parse(s: dateTimeAsString);

			var year =
				dateTime.Year;

			return year;
		}

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
	}
}
