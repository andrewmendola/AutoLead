using System.Xml.Linq;

namespace AutoLead.Vehicle
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
