using AutoLead.Creators.Interface;
using AutoLead.Lead;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class VendorSectionCreator : BaseSectionCreator, IVendorSectionCreator
	{
		#region Methods

		public XElement CreateVendorSection(AdfVendor customer)
		{
			var prospectNode = new XElement("vendor");
			return prospectNode;
		}

		#endregion
	}
}
