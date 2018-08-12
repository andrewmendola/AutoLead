using System.Xml.Linq;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators
{
	public class VendorSectionCreator : IVendorSectionCreator
	{
		#region Public Methods

		public XElement CreateVendorSection(Vendor customer)
		{
			var prospectNode = new XElement("Vendor");
			return prospectNode;
		}

		#endregion
	}
}
