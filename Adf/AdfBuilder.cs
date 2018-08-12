using System.Collections.Generic;
using AdfLibrary.Creators;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Lead;
using AdfLibrary.Prospect;

namespace AdfLibrary
{
	public class AdfBuilder : BaseAdfDocumentBuilder
	{
		#region Constructors and Destructors

		public AdfBuilder(List<AdfLead> adfLeads)
		{
			AdfLeads = adfLeads;
		}

		#endregion

		#region Properties

		protected override IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected override IRootDocumentCreator XmlDocumentCreator => new RootDocumentCreator();

		protected override IVehicleSectionCreator VehicleSectionCreator =>
			new VehicleSectionCreator(new PriceXElementBuilder());

		protected override ICustomerSectionCreator CustomerSectionCreator => new CustomerSectionCreator();

		protected override IProviderSectionCreator ProviderSectionCreator => new ProviderSectionCreator();

		protected override IVendorSectionCreator VendorSectionCreator => new VendorSectionCreator();

		protected override IProspectCreator ProspectCreator => new ProspectCreator(
			new ProspectIdGenerator(),
			new RequestDateStringFormatter(),
			new IdXElementBuilder());

		#endregion
	}
}
