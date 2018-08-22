using AutoLead.Contact;
using AutoLead.Creators;
using AutoLead.Creators.Interface;
using AutoLead.Email;
using AutoLead.Name;
using AutoLead.Phone;
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
			DateStringFormatter = new DateStringFormatter();
			EmailXElementBuilder = new EmailXElementBuilder();
			IdXElementBuilder = new IdXElementBuilder();
			NameXElementBuilder = new NameXElementBuilder();
			PhoneXElementBuilder = new PhoneXElementBuilder();
			ContactXElementBuilder = new ContactXElementBuilder(NameXElementBuilder, EmailXElementBuilder, PhoneXElementBuilder);
		}

		#endregion

		#region Properties

		protected override IReadOnlyCollection<AdfLead> AdfLeads { get; }

		protected override ICustomerSectionCreator CustomerSectionCreator => new CustomerSectionCreator(DateStringFormatter, IdXElementBuilder, ContactXElementBuilder);

		protected override IProspectCreator ProspectCreator => new ProspectCreator(DateStringFormatter, IdXElementBuilder);

		protected override IProviderSectionCreator ProviderSectionCreator => 
			new ProviderSectionCreator(IdXElementBuilder, NameXElementBuilder, ContactXElementBuilder, EmailXElementBuilder, PhoneXElementBuilder);

		protected override IVehicleSectionCreator VehicleSectionCreator => new VehicleSectionCreator(new PriceXElementBuilder(), IdXElementBuilder);

		protected override IVendorSectionCreator VendorSectionCreator => new VendorSectionCreator(IdXElementBuilder, ContactXElementBuilder);

		protected override IRootDocumentCreator XmlDocumentCreator => new RootDocumentCreator();

		private IContactXElementBuilder ContactXElementBuilder { get; }

		private IDateStringFormatter DateStringFormatter { get; }

		private IEmailXElementBuilder EmailXElementBuilder { get; }

		private IPhoneXElementBuilder PhoneXElementBuilder { get; }

		private IIdXElementBuilder IdXElementBuilder { get; }

		private INameXElementBuilder NameXElementBuilder { get; }

		#endregion
	}
}
