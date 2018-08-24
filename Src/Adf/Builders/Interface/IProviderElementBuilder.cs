using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IProviderElementBuilder
	{
		#region Methods

		XElement BuildProviderElement(Provider customer);

		#endregion
	}

	#endregion
}
