using AutoLead.Creators;
using AutoLead.Creators.Interface;
using AutoLead.Lead;
using AutoLead.Prospect;
using System.Collections.Generic;

namespace AutoLead
{
	public class AdfBuilder : BaseAdfDocumentBuilder
	{
		#region Constructors

		public AdfBuilder(List<AdfLead> adfLeads)
		{
			AdfLeads = adfLeads;
		}

		#endregion

		#region Properties

		protected override IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected override ICustomerSectionCreator CustomerSectionCreator => new CustomerSectionCreator();

		protected override IProspectCreator ProspectCreator => new ProspectCreator(new RequestDateStringFormatter(), new IdXElementBuilder());

		protected override IProviderSectionCreator ProviderSectionCreator => new ProviderSectionCreator();

		protected override IVehicleSectionCreator VehicleSectionCreator => new VehicleSectionCreator(new PriceXElementBuilder(), new IdXElementBuilder());

		protected override IVendorSectionCreator VendorSectionCreator => new VendorSectionCreator();

		protected override IRootDocumentCreator XmlDocumentCreator => new RootDocumentCreator();

		#endregion
	}
}
