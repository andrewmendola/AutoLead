using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IIdElementBuilder
	{
		#region Methods

		XElement BuildIdElement(Id adfId, int sequence);

		#endregion
	}

	#endregion
}
