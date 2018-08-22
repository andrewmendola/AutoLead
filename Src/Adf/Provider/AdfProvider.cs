using AutoLead.Contact;
using AutoLead.Email;
using AutoLead.Name;
using AutoLead.Phone;
using System.Collections.Generic;

namespace AutoLead.Provider
{
	public class AdfProvider
	{
		#region Properties

		public AdfContact Contact { get; set; }

		public AdfEmail Email { get; set; }

		public List<AdfId> Ids { get; set; }

		public List<AdfName> Names { get; set; }

		public AdfPhone Phone { get; set; }

		public string Service { get; set; }

		public string Url { get; set; }

		#endregion
	}
}
