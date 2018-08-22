using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Phone
{
	#region Interfaces

	public interface IPhoneXElementBuilder
	{
		#region Methods

		List<XElement> BuildPhoneElements(List<AdfPhone> phoneNumbers);

		XElement BuildPhoneElement(AdfPhone phoneNumber);

		#endregion
	}

	#endregion
}
