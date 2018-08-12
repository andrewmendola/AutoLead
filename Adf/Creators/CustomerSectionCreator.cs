using System.Xml.Linq;
using AdfLibrary.Creators.Interface;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators
{
	public class CustomerSectionCreator : ICustomerSectionCreator
	{
		#region Public Methods

		public XElement CreateCustomerSection(Customer customer)
		{
			var customerNode = new XElement("Customer");
			return customerNode;
		}

		#endregion
	}
}
