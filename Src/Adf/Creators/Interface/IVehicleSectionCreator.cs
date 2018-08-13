using AutoLead.Vehicle;
using System.Xml.Linq;

namespace AutoLead.Creators.Interface
{
	#region Interfaces

	public interface IVehicleSectionCreator
	{
		#region Methods

		XElement CreateVehicleSection(AdfVehicle vehicle, int sequence);

		#endregion
	}

	#endregion
}
