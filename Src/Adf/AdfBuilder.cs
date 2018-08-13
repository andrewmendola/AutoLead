using AutoLead.Creators;
using AutoLead.Creators.Interface;
using AutoLead.Lead;
using AutoLead.Prospect;
using AutoLead.Vehicle;
using System.Collections.Generic;

namespace AutoLead
{
	public class AdfBuilder : BaseAdfDocumentBuilder
	{
		#region Constructors

		public AdfBuilder(List<AdfLead> adfLeads)
		{
			AdfLeads = adfLeads;
			IdXElementBuilder = new IdXElementBuilder();
		}

		#endregion

		private IIdXElementBuilder IdXElementBuilder { get; }

		#region Properties

		protected override IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected override ICustomerSectionCreator CustomerSectionCreator => new CustomerSectionCreator(IdXElementBuilder);

		protected override IProspectCreator ProspectCreator => new ProspectCreator(new RequestDateStringFormatter(), IdXElementBuilder);

		protected override IProviderSectionCreator ProviderSectionCreator => new ProviderSectionCreator(IdXElementBuilder);

		protected override IVehicleSectionCreator VehicleSectionCreator => new VehicleSectionCreator(new PriceXElementBuilder(), IdXElementBuilder);

		protected override IVendorSectionCreator VendorSectionCreator => new VendorSectionCreator(IdXElementBuilder);

		protected override IRootDocumentCreator XmlDocumentCreator => new RootDocumentCreator();

		#endregion
	}
}
