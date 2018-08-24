using AutoLead.Data;
using System.Collections.Generic;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface INameElementBuilder
	{
		#region Methods

		List<XElement> BuildNameElements(List<Name> names);

		#endregion
	}

	#endregion
}
