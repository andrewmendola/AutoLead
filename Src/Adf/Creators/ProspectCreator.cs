using AutoLead.Creators.Interface;
using AutoLead.Prospect;
using System;
using System.Linq;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class ProspectCreator : BaseSectionCreator, IProspectCreator
	{
		#region Constructors

		public ProspectCreator(IDateStringFormatter requestDateStringFormatter, IIdXElementBuilder idXElementBuilder)
		{
			RequestDateStringFormatter = requestDateStringFormatter;
			IdXElementBuilder = idXElementBuilder;
		}

		#endregion

		#region Properties

		private IIdXElementBuilder IdXElementBuilder { get; }

		private IDateStringFormatter RequestDateStringFormatter { get; }

		#endregion

		#region Methods

		public XElement CreateProspect(
			AdfProspect prospect,
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
