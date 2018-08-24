using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class ContactElementBuilder : IContactElementBuilder
	{
		#region Constructors

		public ContactElementBuilder(
			INameElementBuilder nameXElementBuilder,
			IEmailElementBuilder emailXElementBuilder,
			IPhoneElementBuilder phoneXElementBuilder)
		{
			EmailXElementBuilder = emailXElementBuilder;
			NameXElementBuilder = nameXElementBuilder;
			PhoneXElementBuilder = phoneXElementBuilder;
		}

		#endregion

		#region Properties

		private IEmailElementBuilder EmailXElementBuilder { get; }

		private INameElementBuilder NameXElementBuilder { get; }

		private IPhoneElementBuilder PhoneXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement BuildContactElement(Contact contact)
		{
			var hasEmail = contact.Email != null && !string.IsNullOrEmpty(contact.Email.Value);
			var hasPhone = contact.PhoneNumbers != null && contact.PhoneNumbers.Any(p => !string.IsNullOrEmpty(p.Value));

			if (contact.Names == null || !contact.Names.Any() || contact.Names.All(n => string.IsNullOrEmpty(n.Value)))
			{
				throw new AdfException("A name is required for contact.");
			}

			if (!hasEmail && !hasPhone)
			{
				throw new AdfException("An email or phone number is required for contact.");
			}

			var contactElement = new XElement("contact");

			if (contact.PrimaryContact.HasValue)
			{
				contactElement.Add(new XAttribute("primarycontact", contact.PrimaryContact.Value ? "1" : "0"));
			}

			contactElement.Add(NameXElementBuilder.BuildNameElements(contact.Names));

			if (hasEmail)
			{
				contactElement.Add(EmailXElementBuilder.BuildEmailElement(contact.Email));
			}

			if (hasPhone)
			{
				contactElement.Add(PhoneXElementBuilder.BuildPhoneElements(contact.PhoneNumbers));
			}

			if (contact.Address != null)
			{
				contactElement.Add(GetAddressElement(contact.Address));
			}

			return contactElement;
		}

		private XElement GetAddressElement(ContactAddress address)
		{
			var addressElement = new XElement("address", new XAttribute("type", address.Type.ToString().ToLower()));

			if (address.StreetLines != null && address.StreetLines.Any())
			{
				if (address.StreetLines.Count > 5)
				{
					throw new AdfException("A contact address must not have more than 5 street lines.");
				}

				var lineNumber = 1;
				foreach (var line in address.StreetLines)
				{
					addressElement.Add(new XElement("street", line, new XAttribute("line", lineNumber)));
					lineNumber++;
				}
			}

			if (!string.IsNullOrEmpty(address.Apartment))
			{
				addressElement.Add(new XElement("apartment", address.Apartment));
			}

			if (!string.IsNullOrEmpty(address.City))
			{
				addressElement.Add(new XElement("city", address.City));
			}

			if (!string.IsNullOrEmpty(address.RegionCode))
			{
				addressElement.Add(new XElement("regioncode", address.RegionCode));
			}

			if (!string.IsNullOrEmpty(address.PostalCode))
			{
				addressElement.Add(new XElement("postalcode", address.PostalCode));
			}

			if (!string.IsNullOrEmpty(address.Country))
			{
				addressElement.Add(new XElement("country", address.Country));
			}

			return addressElement;
		}

		#endregion
	}
}
