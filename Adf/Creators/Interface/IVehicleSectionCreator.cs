using System.Xml.Linq;
using AdfLibrary.Lead;
using AdfLibrary.Vehicle;

namespace AdfLibrary.Creators.Interface
{
	public interface IVehicleSectionCreator
	{
		#region Public Methods

		XElement CreateVehicleSection(AdfVehicle vehicle, int sequence);

		#endregion
	}
}
