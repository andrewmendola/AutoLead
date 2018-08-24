using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	public class IdElementBuilder : IIdElementBuilder
	{
		#region Methods

		public XElement BuildIdElement(Id adfId, int sequence)
		{
			if (string.IsNullOrEmpty(adfId.LeadId))
			{
				throw new AdfException("The ID for an ADF element cannot be null or empty.");
			}

			if (string.IsNullOrEmpty(adfId.Source))
			{
				throw new AdfException("Source attribute is required for an ID element.");
			}

			if (sequence <= 0)
			{
				throw new AdfException("An ID element sequence must be a positive number.");
			}

			var idElement = new XElement("id", adfId.LeadId);
			idElement.Add(new XAttribute("sequence", sequence));
			idElement.Add(new XAttribute("source", adfId.Source));

			return idElement;
		}

		#endregion
	}
}
