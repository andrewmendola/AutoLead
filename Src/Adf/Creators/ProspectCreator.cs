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

		public ProspectCreator(IRequestDateStringFormatter requestDateStringFormatter, IIdXElementBuilder idXElementBuilder)
		{
			RequestDateStringFormatter = requestDateStringFormatter;
			IdXElementBuilder = idXElementBuilder;
		}

		#endregion

		#region Properties

		private IIdXElementBuilder IdXElementBuilder { get; }

		private IRequestDateStringFormatter RequestDateStringFormatter { get; }

		#endregion

		#region Methods

		public XElement CreateProspect(
			AdfProspect adfProspect,
			AdfDocumentBuilderSettings adfDocumentBuilderSettings)
		{
			var prospectNode = new XElement("prospect", new XAttribute("status", adfProspect.Status.ToString().ToLower()));

			var idElements = GetIdElements(adfProspect.Ids, IdXElementBuilder);
			if (idElements.Any())
			{
				prospectNode.Add(idElements);
			}

			prospectNode.Add(GetProspectRequestDateNode(adfProspect.RequestDate ?? DateTime.Now.ToUniversalTime()));

			return prospectNode;
		}

		private XElement GetProspectRequestDateNode(DateTime requestDate)
		{
			var prospectRequestDateNode = new XElement(
				"requestdate",
				RequestDateStringFormatter.GetRequestDate(requestDate));

			return prospectRequestDateNode;
		}

		#endregion
	}
}
