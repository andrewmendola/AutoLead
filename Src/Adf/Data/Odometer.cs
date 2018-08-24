using AutoLead.Data.Enum;

namespace AutoLead.Data
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
