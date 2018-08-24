using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class ProviderSectionElementBuilder : BaseSectionElementBuilder, IProviderElementBuilder
	{
		#region Constructors

		public ProviderSectionElementBuilder(
			IIdElementBuilder idXElementBuilder,
			INameElementBuilder nameXElementBuilder,
			IContactElementBuilder contactXElementBuilder,
			IEmailElementBuilder emailXElementBuilder,
			IPhoneElementBuilder phoneXElementBuilder)
		{
			ContactXElementBuilder = contactXElementBuilder;
			EmailXElementBuilder = emailXElementBuilder;
			IdXElementBuilder = idXElementBuilder;
			NameXElementBuilder = nameXElementBuilder;
			PhoneXElementBuilder = phoneXElementBuilder;
		}

		#endregion

		#region Properties

		private IContactElementBuilder ContactXElementBuilder { get; set; }

		private IEmailElementBuilder EmailXElementBuilder { get; }

		private IIdElementBuilder IdXElementBuilder { get; }

		private INameElementBuilder NameXElementBuilder { get; }

		private IPhoneElementBuilder PhoneXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement BuildProviderElement(Provider provider)
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
