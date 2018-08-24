using AutoLead.Data.Enum;

namespace AutoLead.Data
{
	public class Phone
	{
		#region Properties

		public bool? PreferredContact { get; set; }

		public PhoneTime Time { get; set; }

		public PhoneType Type { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
