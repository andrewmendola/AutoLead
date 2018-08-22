using AutoLead.Contact.Enum;
using System.Collections.Generic;

namespace AutoLead.Contact
{
	public class ContactAddress
	{
		#region Properties

		public string Apartment { get; set; }

		public string City { get; set; }

		// TODO: 2 character code
		public string Country { get; set; }

		public string PostalCode { get; set; }

		// TODO: 2 character code
		public string RegionCode { get; set; }

		// TODO: max of "5 lines"
		public List<string> StreetLines { get; set; }

		public ContactAddressType Type { get; set; }

		#endregion
	}
}
