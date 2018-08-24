using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IContactElementBuilder
	{
		#region Methods

		XElement BuildContactElement(Contact contact);

		#endregion
	}

	#endregion
}
