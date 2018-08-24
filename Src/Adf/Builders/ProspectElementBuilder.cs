using AutoLead.Builders.Interface;
using AutoLead.Data;
using System;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Builders
{
	public class ProspectElementBuilder : BaseSectionElementBuilder, IProspectElementBuilder
	{
		#region Constructors

		public ProspectElementBuilder(IDateStringFormatter requestDateStringFormatter, IIdElementBuilder idXElementBuilder)
		{
			RequestDateStringFormatter = requestDateStringFormatter;
			IdXElementBuilder = idXElementBuilder;
		}

		#endregion

		#region Properties

		private IIdElementBuilder IdXElementBuilder { get; }

		private IDateStringFormatter RequestDateStringFormatter { get; }

		#endregion

		#region Methods

		public XElement BuildProspectElement(
			Prospect prospect,
			AdfDocumentBuilderSettings adfDocumentBuilderSettings)
		{
			var prospectElement = new XElement("prospect", new XAttribute("status", prospect.Status.ToString().ToLower()));

			var idElements = GetIdElements(prospect.Ids, IdXElementBuilder);
			if (idElements.Any())
			{
				prospectElement.Add(idElements);
			}

			prospectElement.Add(GetProspectRequestDateNode(prospect.RequestDate ?? DateTime.Now.ToUniversalTime()));

			return prospectElement;
		}

		private XElement GetProspectRequestDateNode(DateTime requestDate)
		{
			var prospectRequestDateNode = new XElement(
				"requestdate",
				RequestDateStringFormatter.GetFormattedDate(requestDate));

			return prospectRequestDateNode;
		}

		#endregion
	}
}
