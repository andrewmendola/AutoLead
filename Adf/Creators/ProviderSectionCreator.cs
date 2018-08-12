using System.Xml.Linq;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators
{
	public class ProviderSectionCreator : IProviderSectionCreator
	{
		#region Public Methods

		public XElement CreateProviderSection(Provider customer)
		{
			var prospectNode = new XElement("Provider");
			return prospectNode;
		}

		#endregion
	}
}
