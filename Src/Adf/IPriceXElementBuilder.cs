using AutoLead.Vehicle;
using System.Xml.Linq;

namespace AutoLead
{
	#region Interfaces

	public interface IPriceXElementBuilder
	{
		#region Methods

		XElement BuildPriceElement(Price vehiclePrice);

		#endregion
	}

	#endregion
}
