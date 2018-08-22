using AutoLead.Vendor;
using System.Xml.Linq;

namespace AutoLead.Creators.Interface
{
	#region Interfaces

	public interface IVendorSectionCreator
	{
		#region Methods

		XElement CreateVendorSection(AdfVendor customer);

		#endregion
	}

	#endregion
}
