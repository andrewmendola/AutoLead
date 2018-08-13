using AutoLead.Vehicle.Enum;

namespace AutoLead.Vehicle
{
	public class Odometer
	{
		#region Properties

		public VehicleOdometerStatus? Status { get; set; }

		public VehicleOdometerUnits? Unit { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
