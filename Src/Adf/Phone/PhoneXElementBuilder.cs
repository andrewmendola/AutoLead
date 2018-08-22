using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Phone
{
	public class PhoneXElementBuilder : IPhoneXElementBuilder
	{
		#region Methods

		public XElement BuildPhoneElement(AdfPhone phoneNumber)
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

		public List<XElement> BuildPhoneElements(List<AdfPhone> phoneNumbers)
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
