using System.Xml.Linq;

namespace AutoLead.Contact
{
	#region Interfaces

	public interface IContactXElementBuilder
	{
		#region Methods

		XElement BuildContactElement(AdfContact contact);

		#endregion
	}

	#endregion
}
