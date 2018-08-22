using AutoLead.Vehicle.Enum;

namespace AutoLead.Vehicle
{
	public class FinanceAmount
	{
		#region Properties

		public string Amount { get; set; }

		public Currency Currency { get; set; }

		public FinanceAmountLimit Limit { get; set; }

		public FinanceAmountType Type { get; set; }

		#endregion
	}
}
