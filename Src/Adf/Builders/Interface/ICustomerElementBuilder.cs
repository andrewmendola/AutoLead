using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface ICustomerElementBuilder
	{
		#region Methods

		XElement BuildCustomerElement(Customer customer);

		#endregion
	}

	#endregion
}
