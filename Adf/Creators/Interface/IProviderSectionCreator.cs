using System.Xml.Linq;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators.Interface
{
	public interface IProviderSectionCreator
	{
		#region Public Methods

		XElement CreateProviderSection(Provider customer);

		#endregion
	}
}
