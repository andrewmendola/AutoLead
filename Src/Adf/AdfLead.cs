using AutoLead.Customer;
using AutoLead.Prospect;
using AutoLead.Provider;
using AutoLead.Vehicle;
using AutoLead.Vendor;
using System.Collections.Generic;

namespace AutoLead
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
