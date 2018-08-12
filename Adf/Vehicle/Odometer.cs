using AdfLibrary.Vehicle.Enum;

namespace AdfLibrary.Vehicle
{
	public class Odometer
	{
		#region Public Properties

		public VehicleOdometerStatus? Status { get; set; }

		public VehicleOdometerUnits? Unit { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
