using System;

namespace AdfLibrary.Prospect
{
	public interface IRequestDateStringFormatter
	{
		#region Public Methods

		string GetRequestDate(DateTime requestDateTime);

		#endregion
	}
}
