using AutoLead.Builders.Interface;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Data
{
	public class NameElementBuilder : INameElementBuilder
	{
		#region Methods

		public List<XElement> BuildNameElements(List<Name> names)
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
