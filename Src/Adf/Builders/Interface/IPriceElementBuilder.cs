using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IPriceElementBuilder
	{
		#region Methods

		XElement BuildPriceElement(Price vehiclePrice);

		#endregion
	}

	#endregion
}
