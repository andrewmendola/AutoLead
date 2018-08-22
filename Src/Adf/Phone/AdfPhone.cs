using AutoLead.Phone.Enum;

namespace AutoLead.Phone
{
	public class AdfPhone
	{
		#region Properties

		public bool? PreferredContact { get; set; }

		public PhoneTime Time { get; set; }

		public PhoneType Type { get; set; }

		public string Value { get; set; }

		#endregion
	}
}
