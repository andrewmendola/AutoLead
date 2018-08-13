using Adf.Vehicle.Enum;
using AutoLead.Vehicle.Enum;

namespace AutoLead.Vehicle
{
	public class FinanceBalance
	{
		#region Properties

		public string Amount { get; set; }

		public Currency Currency { get; set; }

		public FinanceBalanceType Type { get; set; }

		#endregion
	}
}
