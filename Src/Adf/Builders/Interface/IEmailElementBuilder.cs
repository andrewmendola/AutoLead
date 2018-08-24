using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IEmailElementBuilder
	{
		#region Methods

		XElement BuildEmailElement(Email email);

		#endregion
	}

	#endregion
}
