using AutoLead.Data;
using System.Xml.Linq;

namespace AutoLead.Builders.Interface
{
	#region Interfaces

	public interface IVehicleElementBuilder
	{
		#region Methods

		XElement BuildVehicleElement(Vehicle vehicle, int sequence);

		#endregion
	}

	#endregion
}
