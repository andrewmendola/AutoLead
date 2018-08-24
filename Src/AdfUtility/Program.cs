using System;
using System.Windows.Forms;

namespace AdfUtility
{
	public static class Program
	{
		#region Methods

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new AdfForm());
		}

		#endregion
	}
}
