using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IVendorElementBuilder
	{
		#region Methods

		XElement BuildVendorElement(Vendor customer);

		#endregion
	}

	#endregion
}
