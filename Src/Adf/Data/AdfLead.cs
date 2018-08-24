using AutoLead.Data;
using System.Collections.Generic;

namespace AutoLead
{
	public class AdfLead
	{
		#region Properties

		public Customer Customer { get; set; }

		public Prospect Prospect { get; set; }

		public Provider Provider { get; set; }

		public ICollection<Vehicle> Vehicles { get; set; }

		public Vendor Vendor { get; set; }

		#endregion
	}
}
