using System;
using System.Windows.Forms;

namespace OGGY_BYPASS
{
	// Token: 0x0200000B RID: 11
	internal static class Program
	{
		// Token: 0x060000B6 RID: 182 RVA: 0x0000C73C File Offset: 0x0000A93C
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Login_Page());
		}
	}
}
