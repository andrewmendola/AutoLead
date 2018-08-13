using AutoLead.Lead;
using System.Xml.Linq;

namespace AutoLead.Creators.Interface
{
	#region Interfaces

	public interface IProviderSectionCreator
	{
		#region Methods

		XElement CreateProviderSection(AdfProvider customer);

		#endregion
	}

	#endregion
}
