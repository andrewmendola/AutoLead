using AutoLead.Email;
using AutoLead.Name;
using AutoLead.Phone;
using System.Collections.Generic;

namespace AutoLead.Contact
{
	public class AdfContact
	{
		#region Properties

		public ContactAddress Address { get; set; }

		public AdfEmail Email { get; set; }

		public List<AdfName> Names { get; set; }

		public List<AdfPhone> PhoneNumbers { get; set; }

		// TODO: possibly not part of spec, unclear
		public bool? PrimaryContact { get; set; }

		#endregion
	}
}
