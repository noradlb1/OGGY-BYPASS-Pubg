using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
//using KeyAuth;

namespace OGGY_BYPASS
{
	// Token: 0x02000009 RID: 9
	public partial class Login_Page : Form
	{
		// Token: 0x06000084 RID: 132
		[DllImport("dwmapi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Login_Page.MARGINS pMarInset);

		// Token: 0x06000085 RID: 133
		[DllImport("dwmapi.dll")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		// Token: 0x06000086 RID: 134
		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		// Token: 0x06000087 RID: 135
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000088 RID: 136 RVA: 0x00009854 File Offset: 0x00007A54
		protected override CreateParams CreateParams
		{
			get
			{
				this.m_aeroEnabled = this.CheckAeroEnabled();
				CreateParams cp = base.CreateParams;
				bool flag = !this.m_aeroEnabled;
				if (flag)
				{
					cp.ClassStyle |= 131072;
				}
				return cp;
			}
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000989C File Offset: 0x00007A9C
		private bool CheckAeroEnabled()
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			bool result;
			if (flag)
			{
				int enabled = 0;
				Login_Page.DwmIsCompositionEnabled(ref enabled);
				result = (enabled == 1);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x0600008A RID: 138 RVA: 0x000098E0 File Offset: 0x00007AE0
		protected override void WndProc(ref Message m)
		{
			int msg = m.Msg;
			int num = msg;
			if (num == 133)
			{
				bool aeroEnabled = this.m_aeroEnabled;
				if (aeroEnabled)
				{
					int v = 2;
					Login_Page.DwmSetWindowAttribute(base.Handle, 2, ref v, 4);
					Login_Page.MARGINS margins = new Login_Page.MARGINS
					{
						bottomHeight = 1,
						leftWidth = 0,
						rightWidth = 0,
						topHeight = 0
					};
					Login_Page.DwmExtendFrameIntoClientArea(base.Handle, ref margins);
				}
			}
			base.WndProc(ref m);
			bool flag = m.Msg == 132 && (int)m.Result == 1;
			if (flag)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00009998 File Offset: 0x00007B98
		private void PanelMove_MouseDown(object sender, MouseEventArgs e)
		{
			this.Drag = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x0600008C RID: 140 RVA: 0x000099E4 File Offset: 0x00007BE4
		private void PanelMove_MouseMove(object sender, MouseEventArgs e)
		{
			bool drag = this.Drag;
			if (drag)
			{
				base.Top = Cursor.Position.Y - this.MouseY;
				base.Left = Cursor.Position.X - this.MouseX;
			}
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00009A34 File Offset: 0x00007C34
		private void PanelMove_MouseUp(object sender, MouseEventArgs e)
		{
			this.Drag = false;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00009A3E File Offset: 0x00007C3E
		public Login_Page()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00009A56 File Offset: 0x00007C56
		private void Login_Page_Load(object sender, EventArgs e)
		{
			//Login_Page.KeyAuthApp.init();
			//this.LoginPage_Header.BackColor = Color.FromArgb(100, 0, 0, 0);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00009A7A File Offset: 0x00007C7A
		private void AuthKey_Input_TextChanged_1(object sender, EventArgs e)
		{
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00009A80 File Offset: 0x00007C80
		private void LOGIN_BTN_Click(object sender, EventArgs e)
		{
			//Login_Page.KeyAuthApp.license(this.AuthKey_Input.Text);
			//bool success = Login_Page.KeyAuthApp.response.success;
			//if (success)
			//{
			//	Main_Page main_Page = new Main_Page();
			//	main_Page.Show();
			//	base.Hide();
			//	MessageBox.Show("Free Version Activated!! \n For Anti-Ban msg me on Discord ");
			//}
			//else
			//{
			//	MessageBox.Show(Login_Page.KeyAuthApp.response.message + "\n OR \n FREE KEY IS CAHANGED \n LATEST FREE KEY AVAILABLE ON MY DISCORD SERVER", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			//}
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00009B03 File Offset: 0x00007D03
		private void GET_KEY_BTN_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/4VQP2F62t2");
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00009B11 File Offset: 0x00007D11
		private void CLOSE_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00009B1A File Offset: 0x00007D1A
		private void MINIMIZE_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00009B25 File Offset: 0x00007D25
		private void Youtube_Link_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCeM4iECFAsWwMzsnlm89Q0g");
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00009B33 File Offset: 0x00007D33
		private void Discord_link_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/kSzwY2uFZH");
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00009B41 File Offset: 0x00007D41
		private void Twitter_link_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/+LNrYG89RqG5mNDJl");
		}

		// Token: 0x0400006E RID: 110
		private bool Drag;

		// Token: 0x0400006F RID: 111
		private int MouseX;

		// Token: 0x04000070 RID: 112
		private int MouseY;

		// Token: 0x04000071 RID: 113
		private const int WM_NCHITTEST = 132;

		// Token: 0x04000072 RID: 114
		private const int HTCLIENT = 1;

		// Token: 0x04000073 RID: 115
		private const int HTCAPTION = 2;

		// Token: 0x04000074 RID: 116
		private bool m_aeroEnabled;

		// Token: 0x04000075 RID: 117
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000076 RID: 118
		private const int WM_NCPAINT = 133;

		// Token: 0x04000077 RID: 119
		private const int WM_ACTIVATEAPP = 28;

		// Token: 0x04000078 RID: 120
		//public static api KeyAuthApp = new api("OGGY_BYPASS", "CzMTQRkWNd", "e6bf7cafb99c5429ac4f995f3a6be5dcc130f0358801e6271b83f34021c4d120", "1.0");

		// Token: 0x02000023 RID: 35
		public struct MARGINS
		{
			// Token: 0x04000160 RID: 352
			public int leftWidth;

			// Token: 0x04000161 RID: 353
			public int rightWidth;

			// Token: 0x04000162 RID: 354
			public int topHeight;

			// Token: 0x04000163 RID: 355
			public int bottomHeight;
		}
	}
}
