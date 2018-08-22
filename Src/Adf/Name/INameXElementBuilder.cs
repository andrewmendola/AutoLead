using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Name
{
	#region Interfaces

	public interface INameXElementBuilder
	{
		#region Methods

		List<XElement> BuildNameElements(List<AdfName> names);

		#endregion
	}

	#endregion
}
