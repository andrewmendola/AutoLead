using AutoLead.Data.Enum;

namespace AutoLead.Data
{
	public class FinanceAmount
	{
		#region Properties

		public string Amount { get; set; }

		public string Currency { get; set; }

		public FinanceAmountLimit Limit { get; set; }

		public FinanceAmountType Type { get; set; }

		#endregion
	}
}
