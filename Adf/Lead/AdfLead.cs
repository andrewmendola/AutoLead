using System.Collections.Generic;
using AdfLibrary.Vehicle;

namespace AdfLibrary.Lead
{
	// TODO: Encapsulate all specific lead data for a single lead.
	public class AdfLead
	{
		#region Constructors and Destructors

		public AdfLead(
			Customer customer,
			Prospect prospect,
			Provider provider,
			IReadOnlyCollection<AdfVehicle> vehicles,
			Vendor vendor)
		{
			Customer = customer;
			Prospect = prospect;
			Provider = provider;
			Vehicles = vehicles;
			Vendor = vendor;
		}

		#endregion

		#region Public Properties

		public Customer Customer { get; }

		public Prospect Prospect { get; }

		public Provider Provider { get; }

		public IReadOnlyCollection<AdfVehicle> Vehicles { get; }

		public Vendor Vendor { get; }

		#endregion
	}
}
