using System.Xml.Linq;

namespace AutoLead
{
	#region Interfaces

	public interface IIdXElementBuilder
	{
		#region Methods

		XElement BuildIdElement(AdfId adfId, int sequence);

		#endregion
	}

	#endregion
}
