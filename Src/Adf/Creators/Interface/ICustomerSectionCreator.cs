using AutoLead.Customer;
using System.Xml.Linq;

namespace AutoLead.Creators.Interface
{
	#region Interfaces

	public interface ICustomerSectionCreator
	{
		#region Methods

		XElement CreateCustomerSection(AdfCustomer customer);

		#endregion
	}

	#endregion
}
