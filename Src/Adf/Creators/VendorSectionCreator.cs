using AutoLead.Contact;
using AutoLead.Creators.Interface;
using AutoLead.Vendor;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class VendorSectionCreator : BaseSectionCreator, IVendorSectionCreator
	{
		#region Constructors

		public VendorSectionCreator(IIdXElementBuilder idXElementBuilder, IContactXElementBuilder contactXElementBuilder)
		{
			IdXElementBuilder = idXElementBuilder;
			ContactXElementBuilder = contactXElementBuilder;
		}

		#endregion

		#region Properties

		private IContactXElementBuilder ContactXElementBuilder { get; set; }

		private IIdXElementBuilder IdXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement CreateVendorSection(AdfVendor vendor)
		{
			var vendorElement = new XElement("vendor");

			var idElements = GetIdElements(vendor.Ids, IdXElementBuilder);
			if (idElements.Any())
			{
				vendorElement.Add(idElements);
			}

			if (string.IsNullOrEmpty(vendor.VendorName))
			{
				throw new AdfException("Vendor name is required for vendor.");
			}

			vendorElement.Add(new XElement("vendorname", vendor.VendorName));

			if (!string.IsNullOrEmpty(vendor.Url))
			{
				vendorElement.Add(new XElement("url", vendor.Url));
			}

			if (vendor.Contact != null)
			{
				vendorElement.Add(ContactXElementBuilder.BuildContactElement(vendor.Contact));
			}

			return vendorElement;
		}

		#endregion
	}
}
