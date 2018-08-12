namespace AdfLibrary.Vehicle
{
	public class Option
	{
		#region Public Properties

		public string ManufacturerCode { get; set; }

		public string OptionName { get; set; }

		public Price Price { get; set; }

		public string Stock { get; set; }

		public int? Weighting { get; set; }

		#endregion
	}
}
