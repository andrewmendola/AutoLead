using AutoLead.Creators.Interface;
using AutoLead.Lead;
using System.Xml.Linq;

namespace AutoLead.Creators
{
	public class CustomerSectionCreator : BaseSectionCreator, ICustomerSectionCreator
	{
		#region Constructors

		public CustomerSectionCreator(IIdXElementBuilder idXElementBuilder)
		{
		}

		#endregion

		#region Properties

		private IIdXElementBuilder IdXElementBuilder { get; set; }

		#endregion

		#region Methods

		public XElement CreateCustomerSection(AdfCustomer customer)
		{
			var customerNode = new XElement("customer");
			return customerNode;
		}

		#endregion
	}
}
