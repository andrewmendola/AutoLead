using System.Xml.Linq;

namespace AutoLead.Creators.Interface
{
	#region Interfaces

	public interface IRootDocumentCreator
	{
		#region Methods

		XDocument CreateRootDocument(AdfDocumentBuilderSettings adfDocumentBuilderSettings);

		#endregion
	}

	#endregion
}
