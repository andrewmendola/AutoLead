using AutoLead.Creators.Interface;
using AutoLead.Lead;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class ProviderSectionCreator : BaseSectionCreator, IProviderSectionCreator
	{
		#region Methods

		public XElement CreateProviderSection(AdfProvider customer)
		{
			var prospectNode = new XElement("provider");
			return prospectNode;
		}

		#endregion
	}
}
