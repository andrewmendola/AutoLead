using AutoLead.Vehicle.Enum;

namespace AutoLead.Vehicle
{
	public class Price
	{
		#region Properties

		public Currency Currency { get; set; }

		public PriceDelta? PriceDelta { get; set; }

		public PriceRelativeTo? PriceRelativeTo { get; set; }

		public PriceType PriceType { get; set; }

		public string Source { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
