using System.Xml.Linq;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators.Interface
{
	public interface IProspectCreator
	{
		#region Public Methods

		XElement CreateProspect(
			Lead.Prospect adfProspect,
			int sequenceId,
			AdfDocumentBuilderSettings adfDocumentBuilderSettings);

		#endregion
	}
}
