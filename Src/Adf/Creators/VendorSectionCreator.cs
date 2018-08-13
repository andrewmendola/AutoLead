using AutoLead.Creators.Interface;
using AutoLead.Lead;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class VendorSectionCreator : BaseSectionCreator, IVendorSectionCreator
	{
		#region Constructors

		public VendorSectionCreator(IIdXElementBuilder idXElementBuilder)
		{
			IdXElementBuilder = idXElementBuilder;
		}

		#endregion

		#region Properties

		private IIdXElementBuilder IdXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement CreateVendorSection(AdfVendor customer)
		{
			var prospectNode = new XElement("vendor");
			return prospectNode;
		}

		#endregion
	}
}
