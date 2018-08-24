using AutoLead.Builders.Interface;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Data
{
	public class PhoneElementBuilder : IPhoneElementBuilder
	{
		#region Methods

		public XElement BuildPhoneElement(Phone phoneNumber)
		{
			var phoneElement = new XElement("phone",
					phoneNumber.Value,
					new XAttribute("type", phoneNumber.Type.ToString().ToLower()),
					new XAttribute("time", phoneNumber.Time.ToString().ToLower()));

			if (phoneNumber.PreferredContact.HasValue)
			{
				phoneElement.Add(new XAttribute("preferredcontact", phoneNumber.PreferredContact.Value ? "1" : "0"));
			}

			return phoneElement;
		}

		public List<XElement> BuildPhoneElements(List<Phone> phoneNumbers)
		{
			var phoneElements = new List<XElement>();

			foreach (var phoneNumber in phoneNumbers)
			{
				if (string.IsNullOrEmpty(phoneNumber.Value))
				{
					continue;
				}

				phoneElements.Add(BuildPhoneElement(phoneNumber));
			}

			return phoneElements;
		}

		#endregion
	}
}
