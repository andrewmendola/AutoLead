using System.Collections.Generic;

namespace AutoLead.Data
{
	public class Customer
	{
		#region Properties

		public string Comments { get; set; }

		public Contact Contact { get; set; }

		public List<Id> Ids { get; set; }

		public Timeframe Timeframe { get; set; }

		#endregion
	}
}
