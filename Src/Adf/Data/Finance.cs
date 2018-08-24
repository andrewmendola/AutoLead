using System.Collections.Generic;

namespace AutoLead.Data
{
	public class Finance
	{
		#region Properties

		public List<FinanceAmount> Amounts { get; set; }

		public FinanceBalance Balance { get; set; }

		public string Method { get; set; }

		#endregion
	}
}
