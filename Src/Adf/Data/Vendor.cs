using System.Collections.Generic;

namespace AutoLead.Data
{
	public class Vendor
	{
		#region Properties

		public Contact Contact { get; set; }

		public List<Id> Ids { get; set; }

		public string Url { get; set; }

		public string VendorName { get; set; }

		#endregion
	}
}
