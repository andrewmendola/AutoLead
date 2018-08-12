using System;
using System.Xml.Linq;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Lead;
using AdfLibrary.Prospect;

namespace AdfLibrary.Creators
{
	public class ProspectCreator : IProspectCreator
	{
		#region Constructors and Destructors

		public ProspectCreator(
			IProspectIdGenerator prospectIdGenerator,
			IRequestDateStringFormatter requestDateStringFormatter,
			IIdXElementBuilder idXElementBuilder)
		{
			ProspectIdGenerator = prospectIdGenerator;
			RequestDateStringFormatter = requestDateStringFormatter;
			IdXElementBuilder = idXElementBuilder;
		}

		#endregion

		#region Properties

		private IIdXElementBuilder IdXElementBuilder { get; }

		private IProspectIdGenerator ProspectIdGenerator { get; }

		private IRequestDateStringFormatter RequestDateStringFormatter { get; }

		#endregion

		#region Public Methods

		public XElement CreateProspect(
			Lead.Prospect adfProspect,
			int sequence,
			AdfDocumentBuilderSettings adfDocumentBuilderSettings)
		{
			var prospectIdNode = GetProspectIdNode(adfProspect, sequence);
			var prospectRequestDateNode =
				GetProspectRequestDateNode(adfProspect.RequestDate ?? DateTime.Now.ToUniversalTime());

			var prospectNode = new XElement(
				"Prospect",
				prospectIdNode,
				prospectRequestDateNode);

			if (adfDocumentBuilderSettings.IncludeProspectStatusAttribute)
			{
				prospectNode.Add(new XAttribute("status", adfProspect.Status.ToString()));
			}

			return prospectNode;
		}

		#endregion

		#region Methods

		private XElement GetProspectIdNode(Lead.Prospect adfProspect, int sequence)
		{
			return IdXElementBuilder.BuildIdElement(
				ProspectIdGenerator.GenerateProspectId(adfProspect, sequence),
				sequence,
				adfProspect.LeadSource);
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
