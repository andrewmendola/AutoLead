using AutoLead.Contact;
using AutoLead.Creators.Interface;
using AutoLead.Email;
using AutoLead.Name;
using AutoLead.Phone;
using AutoLead.Provider;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class ProviderSectionCreator : BaseSectionCreator, IProviderSectionCreator
	{
		#region Constructors

		public ProviderSectionCreator(
			IIdXElementBuilder idXElementBuilder,
			INameXElementBuilder nameXElementBuilder,
			IContactXElementBuilder contactXElementBuilder,
			IEmailXElementBuilder emailXElementBuilder,
			IPhoneXElementBuilder phoneXElementBuilder)
		{
			ContactXElementBuilder = contactXElementBuilder;
			EmailXElementBuilder = emailXElementBuilder;
			IdXElementBuilder = idXElementBuilder;
			NameXElementBuilder = nameXElementBuilder;
			PhoneXElementBuilder = phoneXElementBuilder;
		}

		#endregion

		#region Properties

		private IContactXElementBuilder ContactXElementBuilder { get; set; }

		private IEmailXElementBuilder EmailXElementBuilder { get; }

		private IIdXElementBuilder IdXElementBuilder { get; }

		private INameXElementBuilder NameXElementBuilder { get; }

		private IPhoneXElementBuilder PhoneXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement CreateProviderSection(AdfProvider provider)
		{
			if (provider.Names == null || !provider.Names.Any())
			{
				throw new AdfException("A name is required for the provider.");
			}

			var providerElement = new XElement("provider");

			var idElements = GetIdElements(provider.Ids, IdXElementBuilder);
			if (idElements.Any())
			{
				providerElement.Add(idElements);
			}

			providerElement.Add(NameXElementBuilder.BuildNameElements(provider.Names));

			if (!string.IsNullOrEmpty(provider.Service))
			{
				providerElement.Add(new XElement("service", provider.Service));
			}

			if (!string.IsNullOrEmpty(provider.Url))
			{
				providerElement.Add(new XElement("url", provider.Url));
			}

			if (provider.Email != null)
			{
				providerElement.Add(EmailXElementBuilder.BuildEmailElement(provider.Email));
			}

			if (provider.Phone != null)
			{
				providerElement.Add(PhoneXElementBuilder.BuildPhoneElement(provider.Phone));
			}

			if (provider.Contact != null)
			{
				providerElement.Add(ContactXElementBuilder.BuildContactElement(provider.Contact));
			}

			return providerElement;
		}

		#endregion
	}
}
