using AutoLead.Builders.Interface;
using System.Xml.Linq;

namespace AutoLead.Data
{
	public class EmailElementBuilder : IEmailElementBuilder
	{
		#region Methods

		public XElement BuildEmailElement(Email email)
		{
			var emailElement = new XElement("email", email.Value);

			if (email.PreferredContact.HasValue)
			{
				emailElement.Add(new XAttribute("preferredcontact", email.PreferredContact.Value ? "1" : "0"));
			}

			return emailElement;
		}

		#endregion
	}
}
