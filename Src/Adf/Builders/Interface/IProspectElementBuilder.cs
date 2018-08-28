using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IProspectElementBuilder
	{
		#region Methods

		XElement BuildProspectElement(Prospect adfProspect);

		#endregion
	}

	#endregion
}
