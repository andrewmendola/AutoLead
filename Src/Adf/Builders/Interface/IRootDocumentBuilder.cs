using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IRootDocumentBuilder
	{
		#region Methods

		XDocument BuildRootDocument(bool includeXmlDeclaration, bool includeAdfDeclaration);

		#endregion
	}

	#endregion
}
