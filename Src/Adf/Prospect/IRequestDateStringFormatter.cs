using System;

namespace AutoLead.Prospect
{
	#region Interfaces

	public interface IRequestDateStringFormatter
	{
		#region Methods

		string GetRequestDate(DateTime requestDateTime);

		#endregion
	}

	#endregion
}
