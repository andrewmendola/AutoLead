using AutoLead.Contact;
using System.Collections.Generic;

namespace AutoLead.Customer
{
	public class AdfCustomer
	{
		#region Properties

		public string Comments { get; set; }

		public AdfContact Contact { get; set; }

		public List<AdfId> Ids { get; set; }

		public Timeframe Timeframe { get; set; }

		#endregion
	}
}
