using AutoLead.Builders.Interface;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class RootDocumentBuilder : IRootDocumentBuilder
	{
		#region Methods

		public XDocument BuildRootDocument(AdfDocumentBuilderSettings adfDocumentBuilderSettings)
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
