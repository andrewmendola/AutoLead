using System;

namespace AutoLead
{
	public class DateStringFormatter : IDateStringFormatter
	{
		#region Methods

		// ISO 8061:1988(E)
		public string GetFormattedDate(DateTime dateTime)
		{
			return dateTime.ToString("yyyy-MM-ddThh:mm:sszzz");
		}

		#endregion
	}
}
