using AdfLibrary.Lead;

namespace AdfLibrary.Prospect
{
	public interface IProspectIdGenerator
	{
		#region Public Methods

		string GenerateProspectId(Lead.Prospect adfProspect, int sequence);

		#endregion
	}
}
