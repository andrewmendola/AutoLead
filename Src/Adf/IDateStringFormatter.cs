using System;

namespace AutoLead
{
	#region Interfaces

	public interface IDateStringFormatter
	{
		#region Methods

		string GetFormattedDate(DateTime requestDateTime);

		#endregion
	}

	#endregion
}
