namespace AdfLibrary
{
	public class AdfDocumentBuilderSettings
	{
		#region Public Properties

		public bool IncludeAdfDeclaration { get; set; } = true;

		public bool IncludeXmlDeclaration { get; set; } = true;

		public bool IncludeProspectStatusAttribute { get; set; } = true;

		#endregion
	}
}
