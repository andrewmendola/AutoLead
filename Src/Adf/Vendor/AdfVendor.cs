using AutoLead.Contact;
using System.Collections.Generic;

namespace AutoLead.Vendor
{
	public class AdfVendor
	{
		#region Properties

		public AdfContact Contact { get; set; }

		public List<AdfId> Ids { get; set; }

		public string Url { get; set; }

		public string VendorName { get; set; }

		#endregion
	}
}
