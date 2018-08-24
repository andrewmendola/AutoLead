using AutoLead.Data;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IPhoneElementBuilder
	{
		#region Methods

		XElement BuildPhoneElement(Phone phoneNumber);

		List<XElement> BuildPhoneElements(List<Phone> phoneNumbers);

		#endregion
	}

	#endregion
}
