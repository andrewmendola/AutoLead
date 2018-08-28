using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class VendorElementBuilder : BaseElementBuilder, IVendorElementBuilder
	{
		#region Constructors

		public VendorElementBuilder(IIdElementBuilder idXElementBuilder, IContactElementBuilder contactXElementBuilder)
		{
			IdXElementBuilder = idXElementBuilder;
			ContactXElementBuilder = contactXElementBuilder;
		}

		#endregion

		#region Properties

		private IContactElementBuilder ContactXElementBuilder { get; set; }

		private IIdElementBuilder IdXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement BuildVendorElement(Vendor vendor)
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
