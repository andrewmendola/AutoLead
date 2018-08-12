using System.Xml.Linq;
using AdfLibrary.Lead;

namespace AdfLibrary.Creators.Interface
{
	public interface ICustomerSectionCreator
	{
		#region Public Methods

		XElement CreateCustomerSection(Customer customer);

		#endregion
	}
}
