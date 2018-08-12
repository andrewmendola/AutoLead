using System;
using AdfLibrary.Prospect;

namespace AdfLibrary.Lead
{
	public class Prospect
	{
		#region Public Properties

		public string LeadId { get; set; }

		public string LeadSource { get; set; }

		public string LeadType { get; set; }

		public DateTime? RequestDate { get; set; }

		public AdfProspectStatus Status { get; set; }

		#endregion
	}
}
