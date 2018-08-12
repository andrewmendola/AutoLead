using System.Xml.Linq;

namespace AdfLibrary
{
	public class IdXElementBuilder : IIdXElementBuilder
	{
		#region Public Methods

		public XElement BuildIdElement(string id, int sequence, string source)
		{
			var idElement = new XElement("id", id);
			idElement.Add(new XAttribute("sequence", sequence));
			idElement.Add(new XAttribute("source", source));

			return idElement;
		}

		#endregion
	}
}
