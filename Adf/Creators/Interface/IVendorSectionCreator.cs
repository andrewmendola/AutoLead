using System.Xml.Linq;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators.Interface
{
	public interface IVendorSectionCreator
	{
		#region Public Methods

		XElement CreateVendorSection(Vendor customer);

		#endregion
	}
}
