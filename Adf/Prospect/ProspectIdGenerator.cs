using AdfLibrary.Lead;

namespace AdfLibrary.Prospect
{
	public class ProspectIdGenerator : IProspectIdGenerator
	{
		#region Public Methods

		public string GenerateProspectId(Lead.Prospect adfProspect, int sequence)
		{
			return adfProspect.LeadId;
		}

		#endregion
	}
}
