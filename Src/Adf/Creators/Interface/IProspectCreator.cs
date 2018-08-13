using AutoLead.Prospect;
using System.Xml.Linq;

namespace AutoLead.Creators.Interface
{
	#region Interfaces

	public interface IProspectCreator
	{
		#region Methods

		XElement CreateProspect(AdfProspect adfProspect, AdfDocumentBuilderSettings adfDocumentBuilderSettings);

		#endregion
	}

	#endregion
}
