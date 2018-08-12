using System.Collections.Generic;
using AdfLibrary.Vehicle.Enum;

namespace AdfLibrary.Vehicle
{
	public class AdfVehicle
	{
		#region Public Properties

		public string BodyStyle { get; set; }

		public List<ColorCombination> ColorCombinations { get; set; }

		public string Comments { get; set; }

		public VehicleCondition? Condition { get; set; }

		public string Doors { get; set; }

		public Finance Finance { get; set; }

		public ImageTag ImageTag { get; set; }

		public VehicleInterest? Interest { get; set; }

		public string Make { get; set; }

		public string Model { get; set; }

		public Odometer Odometer { get; set; }

		public List<Option> Options { get; set; }

		public Price Price { get; set; }

		public string PriceComments { get; set; }

		public VehicleStatus? Status { get; set; }

		public string StockNumber { get; set; }

		public string Transmission { get; set; }

		public string Trim { get; set; }

		public string Vin { get; set; }

		public string Year { get; set; }

		#endregion
	}
}
