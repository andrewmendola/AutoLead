using System.Xml.Linq;
using AdfLibrary.Creators.Interface;

namespace AdfLibrary.Creators
{
	public class RootDocumentCreator : IRootDocumentCreator
	{
		#region Public Methods

		public XDocument CreateRootDocument(AdfDocumentBuilderSettings adfDocumentBuilderSettings)
		{
			var adfDocument = new XDocument();

			if (adfDocumentBuilderSettings.IncludeXmlDeclaration)
			{
				adfDocument.Declaration = new XDeclaration("1.0", string.Empty, string.Empty);
			}

			if (adfDocumentBuilderSettings.IncludeAdfDeclaration)
			{
				adfDocument.Add(new XProcessingInstruction("adf", "version=\"1.0\""));
			}

			return adfDocument;
		}

		#endregion
	}
}
