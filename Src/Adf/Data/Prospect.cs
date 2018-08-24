using AutoLead.Data.Enum;
using System;
using System.Collections.Generic;

namespace AutoLead.Data
{
	public class Prospect
	{
		#region Properties

		public List<Id> Ids { get; set; }

		public DateTime? RequestDate { get; set; }

		public ProspectStatus Status { get; set; }

		#endregion
	}
}
