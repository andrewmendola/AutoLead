using System.Xml.Linq;

namespace AutoLead.Email
{
	#region Interfaces

	public interface IEmailXElementBuilder
	{
		#region Methods

		XElement BuildEmailElement(AdfEmail email);

		#endregion
	}

	#endregion
}
