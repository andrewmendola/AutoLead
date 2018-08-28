using AutoLead.Builders.Interface;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class RootDocumentBuilder : IRootDocumentBuilder
	{
		#region Methods

		public XDocument BuildRootDocument(bool includeXmlDeclaration = true, bool includeAdfDeclaration = true)
		{
			var adfDocument = new XDocument();

			if (includeXmlDeclaration)
			{
				adfDocument.Declaration = new XDeclaration("1.0", string.Empty, string.Empty);
			}

			if (includeAdfDeclaration)
			{
				adfDocument.Add(new XProcessingInstruction("adf", "version=\"1.0\""));
			}

			return adfDocument;
		}

		#endregion
	}
}
