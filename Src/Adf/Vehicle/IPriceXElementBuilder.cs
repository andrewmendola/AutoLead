namespace AutoLead.Vehicle
{
	using System.Xml.Linq;

	#region Interfaces

	public interface IPriceXElementBuilder
	{
		#region Methods

		XElement BuildPriceElement(Price vehiclePrice);

		#endregion
	}

	#endregion
}
