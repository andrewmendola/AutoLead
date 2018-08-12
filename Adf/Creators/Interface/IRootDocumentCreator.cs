using System.Xml.Linq;

namespace AdfLibrary.Creators.Interface
{
	public interface IRootDocumentCreator
	{
		#region Public Methods

		XDocument CreateRootDocument(AdfDocumentBuilderSettings adfDocumentBuilderSettings);

		#endregion
	}
}
