using System.Xml.Linq;

namespace AdfLibrary
{
	public interface IIdXElementBuilder
	{
		#region Public Methods

		XElement BuildIdElement(string id, int sequence, string source);

		#endregion
	}
}
