using System;
using System.Collections.Generic;

namespace AutoLead.Prospect
{
	public class AdfProspect
	{
		#region Properties

		public List<AdfId> Ids { get; set; }

		public DateTime? RequestDate { get; set; }

		public AdfProspectStatus Status { get; set; }

		#endregion
	}
}
