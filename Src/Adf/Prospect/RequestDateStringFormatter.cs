using System;

namespace AutoLead.Prospect
{
	public class RequestDateStringFormatter : IRequestDateStringFormatter
	{
		#region Methods

		// ISO 8061:1988(E)
		public string GetRequestDate(DateTime requestDateTime)
		{
			return requestDateTime.ToString("yyyy-MM-ddThh:mm:sszzz");
		}

		#endregion
	}
}
