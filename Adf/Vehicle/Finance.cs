using AdfLibrary.Vehicle.Enum;

namespace AdfLibrary.Vehicle
{
	public class Finance
	{
		#region Public Properties

		public FinanceAmount Amount { get; set; }

		public FinanceBalance Balance { get; set; }

		public FinanceMethod? Method { get; set; }

		#endregion
	}
}
