using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Name
{
	public class NameXElementBuilder : INameXElementBuilder
	{
		#region Methods

		public List<XElement> BuildNameElements(List<AdfName> names)
		{
			var nameElements = new List<XElement>();

			foreach (var name in names)
			{
				if (string.IsNullOrEmpty(name.Value))
				{
					throw new AdfException("A value for name is required.");
				}

				nameElements.Add(new XElement("name",
					name.Value,
					new XAttribute("part", name.NamePart.ToString().ToLower()),
					new XAttribute("type", name.Type.ToString().ToLower())));
			}

			return nameElements;
		}

		#endregion
	}
}
