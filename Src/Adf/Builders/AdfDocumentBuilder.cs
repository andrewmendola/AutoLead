using AutoLead.Builders;
using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Collections.Generic;

namespace AutoLead
{
	public class AdfDocumentBuilder : BaseAdfDocumentBuilder
	{
		#region Constructors

		public AdfDocumentBuilder(List<AdfLead> adfLeads)
		{
			AdfLeads = adfLeads;
			DateStringFormatter = new DateStringFormatter();
			EmailXElementBuilder = new EmailElementBuilder();
			IdXElementBuilder = new IdElementBuilder();
			NameXElementBuilder = new NameElementBuilder();
			PhoneXElementBuilder = new PhoneElementBuilder();
			ContactXElementBuilder = new ContactElementBuilder(NameXElementBuilder, EmailXElementBuilder, PhoneXElementBuilder);
		}

		#endregion

		#region Properties

		protected override IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected override ICustomerElementBuilder CustomerSectionCreator => new CustomerSectionElementBuilder(DateStringFormatter, IdXElementBuilder, ContactXElementBuilder);

		protected override IProspectElementBuilder ProspectCreator => new ProspectElementBuilder(DateStringFormatter, IdXElementBuilder);

		protected override IProviderElementBuilder ProviderSectionCreator =>
			new ProviderSectionElementBuilder(IdXElementBuilder, NameXElementBuilder, ContactXElementBuilder, EmailXElementBuilder, PhoneXElementBuilder);

		protected override IVehicleElementBuilder VehicleSectionCreator => new VehicleSectionElementBuilder(new PriceElementBuilder(), IdXElementBuilder);

		protected override IVendorElementBuilder VendorSectionCreator => new VendorSectionElementBuilder(IdXElementBuilder, ContactXElementBuilder);

		protected override IRootDocumentBuilder XmlDocumentCreator => new RootDocumentBuilder();

		private IContactElementBuilder ContactXElementBuilder { get; }

		private IDateStringFormatter DateStringFormatter { get; }

		private IEmailElementBuilder EmailXElementBuilder { get; }

		private IIdElementBuilder IdXElementBuilder { get; }

		private INameElementBuilder NameXElementBuilder { get; }

		private IPhoneElementBuilder PhoneXElementBuilder { get; }

		#endregion
	}
}
