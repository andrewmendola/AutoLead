using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IAdfDocumentBuilder
	{
		#region Methods

		XDocument BuildAdfDocument(List<AdfLead> adfLeads, AdfDocumentBuilderSettings adfDocumentBuilderSettings = null);

		#endregion
	}

	#endregion
}
