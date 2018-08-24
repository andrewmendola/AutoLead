using AutoLead.Builders.Interface;
using AutoLead.Data;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public abstract class BaseSectionElementBuilder
	{
		#region Methods

		protected virtual List<XElement> GetIdElements(List<Id> adfIds, IIdElementBuilder idXElementBuilder)
		{
			var adfIdElements = new List<XElement>();

			if (adfIds == null || !adfIds.Any())
			{
				return adfIdElements;
			}

			for (var i = 0; i < adfIds.Count; i++)
			{
				adfIdElements.Add(idXElementBuilder.BuildIdElement(adfIds[i], i + 1));
			}

			return adfIdElements;
		}

		#endregion
	}
}
