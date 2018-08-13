using AutoLead.Creators.Interface;
using AutoLead.Lead;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class ProviderSectionCreator : BaseSectionCreator, IProviderSectionCreator
	{
		#region Constructors

		public ProviderSectionCreator(IIdXElementBuilder idXElementBuilder)
		{
			IdXElementBuilder = idXElementBuilder;
		}

		#endregion

		#region Properties

		private IIdXElementBuilder IdXElementBuilder { get; }

		#endregion

		#region Methods

		public XElement CreateProviderSection(AdfProvider customer)
		{
			var prospectNode = new XElement("provider");
			return prospectNode;
		}

		#endregion
	}
}
