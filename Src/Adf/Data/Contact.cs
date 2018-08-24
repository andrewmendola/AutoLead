using System.Collections.Generic;

namespace AutoLead.Data
{
	public class Contact
	{
		#region Properties

		public ContactAddress Address { get; set; }

		public Email Email { get; set; }

		public List<Name> Names { get; set; }

		public List<Phone> PhoneNumbers { get; set; }

		// TODO: possibly not part of spec, unclear
		public bool? PrimaryContact { get; set; }

		#endregion
	}
}
