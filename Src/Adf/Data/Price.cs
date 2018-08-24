using AutoLead.Data.Enum;

namespace AutoLead.Data
{
	public class Price
	{
		#region Properties

		public string Currency { get; set; }

		public PriceDelta? PriceDelta { get; set; }

		public PriceRelativeTo? PriceRelativeTo { get; set; }

		public PriceType PriceType { get; set; }

		public string Source { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
