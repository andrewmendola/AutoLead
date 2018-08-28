using AutoLead.Builders.Interface;

namespace AutoLead
{
	public class AdfDocumentBuilderSettings
	{
		#region Properties

		public IContactElementBuilder ContactElementBuilder { get; set; }

		public ICustomerElementBuilder CustomerElementBuilder { get; set; }

		public IDateStringFormatter DateStringFormatter { get; set; }

		public IEmailElementBuilder EmailElementBuilder { get; set; }

		public IIdElementBuilder IdElementBuilder { get; set; }

		public bool IncludeAdfDeclaration { get; set; } = true;

		public bool IncludeXmlDeclaration { get; set; } = true;

		public IPriceElementBuilder PriceElementBuilder { get; set; }

		public INameElementBuilder NameElementBuilder { get; set; }

		public IPhoneElementBuilder PhoneElementBuilder { get; set; }

		public IProspectElementBuilder ProspectElementBuilder { get; set; }

		public IProviderElementBuilder ProviderElementBuilder { get; set; }

		public IRootDocumentBuilder RootDocumentBuilder { get; set; }

		public IVehicleElementBuilder VehicleElementBuilder { get; set; }

		public IVendorElementBuilder VendorElementBuilder { get; set; }

		#endregion
	}
}
