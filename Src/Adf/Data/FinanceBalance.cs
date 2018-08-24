using AutoLead.Data.Enum;

namespace AutoLead.Data
{
	public class FinanceBalance
	{
		#region Properties

		public string Amount { get; set; }

		public string Currency { get; set; }

		public FinanceBalanceType Type { get; set; }

		#endregion
	}
}
