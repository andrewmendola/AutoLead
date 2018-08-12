using System.Xml.Linq;
using AdfLibrary.Vehicle;

namespace AdfLibrary
{
	public interface IPriceXElementBuilder
	{
		#region Public Methods

		XElement BuildPriceElement(Price vehiclePrice);

		#endregion
	}
}
