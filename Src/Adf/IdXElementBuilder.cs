using System.Xml.Linq;

namespace AutoLead
{
	public class IdXElementBuilder : IIdXElementBuilder
	{
		#region Methods

		public XElement BuildIdElement(AdfId adfId, int sequence)
		{
			if (string.IsNullOrEmpty(adfId.Id))
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

			var idElement = new XElement("id", adfId.Id);
			idElement.Add(new XAttribute("sequence", sequence));
			idElement.Add(new XAttribute("source", adfId.Source));

			return idElement;
		}

		#endregion
	}
}
