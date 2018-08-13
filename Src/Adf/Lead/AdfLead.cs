using AutoLead.Prospect;
using AutoLead.Vehicle;
using System.Collections.Generic;

namespace AutoLead.Lead
{
	public class AdfLead
	{
		#region Properties

		public AdfCustomer Customer { get; set; }

		public AdfProspect Prospect { get; set; }

		public AdfProvider Provider { get; set; }

		public ICollection<AdfVehicle> Vehicles { get; set; }

		public AdfVendor Vendor { get; set; }

		#endregion
	}
}
