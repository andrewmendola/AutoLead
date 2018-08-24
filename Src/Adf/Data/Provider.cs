using System.Collections.Generic;

namespace AutoLead.Data
{
	public class Provider
	{
		#region Properties

		public Contact Contact { get; set; }

		public Email Email { get; set; }

		public List<Id> Ids { get; set; }

		public List<Name> Names { get; set; }

		public Phone Phone { get; set; }

		public string Service { get; set; }

		public string Url { get; set; }

		#endregion
	}
}
