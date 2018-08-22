using System.Xml.Linq;

namespace AutoLead.Email
{
	public class EmailXElementBuilder : IEmailXElementBuilder
	{
		#region Methods

		public XElement BuildEmailElement(AdfEmail email)
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
