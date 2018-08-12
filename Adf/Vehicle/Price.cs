using AdfLibrary.Vehicle.Enum;

namespace AdfLibrary.Vehicle
{
	public class Price
	{
		#region Public Properties

		public Currency Currency { get; set; }

		public PriceDelta? PriceDelta { get; set; }

		public PriceRelativeTo? PriceRelativeTo { get; set; }

		public PriceType PriceType { get; set; }

		public string Source { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
