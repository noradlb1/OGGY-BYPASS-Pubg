using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace OGGY_BYPASS
{
	// Token: 0x0200000A RID: 10
	public partial class Main_Page : Form
	{
		// Token: 0x0600009B RID: 155
		[DllImport("dwmapi.dll")]
		public static extern int DwmExtendFrameIntoClientArea(IntPtr hWnd, ref Main_Page.MARGINS pMarInset);

		// Token: 0x0600009C RID: 156
		[DllImport("dwmapi.dll")]
		public static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, ref int attrValue, int attrSize);

		// Token: 0x0600009D RID: 157
		[DllImport("dwmapi.dll")]
		public static extern int DwmIsCompositionEnabled(ref int pfEnabled);

		// Token: 0x0600009E RID: 158
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600009F RID: 159 RVA: 0x0000B014 File Offset: 0x00009214
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

		// Token: 0x060000A0 RID: 160 RVA: 0x0000B05C File Offset: 0x0000925C
		private bool CheckAeroEnabled()
		{
			bool flag = Environment.OSVersion.Version.Major >= 6;
			bool result;
			if (flag)
			{
				int enabled = 0;
				Main_Page.DwmIsCompositionEnabled(ref enabled);
				result = (enabled == 1);
			}
			else
			{
				result = false;
			}
			return result;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000B0A0 File Offset: 0x000092A0
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
					Main_Page.DwmSetWindowAttribute(base.Handle, 2, ref v, 4);
					Main_Page.MARGINS margins = new Main_Page.MARGINS
					{
						bottomHeight = 1,
						leftWidth = 0,
						rightWidth = 0,
						topHeight = 0
					};
					Main_Page.DwmExtendFrameIntoClientArea(base.Handle, ref margins);
				}
			}
			base.WndProc(ref m);
			bool flag = m.Msg == 132 && (int)m.Result == 1;
			if (flag)
			{
				m.Result = (IntPtr)2;
			}
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000B158 File Offset: 0x00009358
		private void PanelMove_MouseDown(object sender, MouseEventArgs e)
		{
			this.Drag = true;
			this.MouseX = Cursor.Position.X - base.Left;
			this.MouseY = Cursor.Position.Y - base.Top;
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000B1A4 File Offset: 0x000093A4
		private void PanelMove_MouseMove(object sender, MouseEventArgs e)
		{
			bool drag = this.Drag;
			if (drag)
			{
				base.Top = Cursor.Position.Y - this.MouseY;
				base.Left = Cursor.Position.X - this.MouseX;
			}
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000B1F4 File Offset: 0x000093F4
		private void PanelMove_MouseUp(object sender, MouseEventArgs e)
		{
			this.Drag = false;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000B200 File Offset: 0x00009400
		public Main_Page()
		{
			this.InitializeComponent();
			Main_Page.instance = this;
			this.uc1 = this.gamE_SELECTOR1;
			this.uc2 = this.EMULATOR_SELECTOR_PANEL;
			this.uc3 = this.GAME_STARTER_PANEL;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000B24D File Offset: 0x0000944D
		private void Main_Page_Load(object sender, EventArgs e)
		{
			this.MainPage_Header.BackColor = Color.FromArgb(100, 0, 0, 0);
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000B266 File Offset: 0x00009466
		private void HOME_BUTTON_Click(object sender, EventArgs e)
		{
			this.gamE_SELECTOR1.Visible = true;
			this.EMULATOR_SELECTOR_PANEL.Visible = false;
			this.GAME_STARTER_PANEL.Visible = false;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000B290 File Offset: 0x00009490
		private void EMUALTOR_BUTTON_Click(object sender, EventArgs e)
		{
			this.gamE_SELECTOR1.Visible = false;
			this.EMULATOR_SELECTOR_PANEL.Visible = true;
			this.GAME_STARTER_PANEL.Visible = false;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000B2BA File Offset: 0x000094BA
		private void GAME_BUTTON_Click(object sender, EventArgs e)
		{
			this.gamE_SELECTOR1.Visible = false;
			this.EMULATOR_SELECTOR_PANEL.Visible = false;
			this.GAME_STARTER_PANEL.Visible = true;
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000B2E4 File Offset: 0x000094E4
		private void emulatoR_SELECTOR1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000B2E7 File Offset: 0x000094E7
		private void GAME_STARTER_PANEL_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000B2EA File Offset: 0x000094EA
		private void emulatoR_SELECTOR1_Load_1(object sender, EventArgs e)
		{
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000B2ED File Offset: 0x000094ED
		private void CLOSE_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000B2F6 File Offset: 0x000094F6
		private void MINIMIZE_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000B301 File Offset: 0x00009501
		private void Youtube_Link_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/channel/UCeM4iECFAsWwMzsnlm89Q0g");
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000B30F File Offset: 0x0000950F
		private void Discord_link_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/4VQP2F62t2");
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000B31D File Offset: 0x0000951D
		private void Twitter_link_Click(object sender, EventArgs e)
		{
			Process.Start("https://t.me/+LNrYG89RqG5mNDJl");
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000B32B File Offset: 0x0000952B
		private void MainPage_Header_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000B32E File Offset: 0x0000952E
		private void gamE_SELECTOR1_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0400008A RID: 138
		private bool Drag;

		// Token: 0x0400008B RID: 139
		private int MouseX;

		// Token: 0x0400008C RID: 140
		private int MouseY;

		// Token: 0x0400008D RID: 141
		private const int WM_NCHITTEST = 132;

		// Token: 0x0400008E RID: 142
		private const int HTCLIENT = 1;

		// Token: 0x0400008F RID: 143
		private const int HTCAPTION = 2;

		// Token: 0x04000090 RID: 144
		private bool m_aeroEnabled;

		// Token: 0x04000091 RID: 145
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000092 RID: 146
		private const int WM_NCPAINT = 133;

		// Token: 0x04000093 RID: 147
		private const int WM_ACTIVATEAPP = 28;

		// Token: 0x04000094 RID: 148
		public static Main_Page instance;

		// Token: 0x04000095 RID: 149
		public TextBox tb1;

		// Token: 0x04000096 RID: 150
		public Button bt1;

		// Token: 0x04000097 RID: 151
		public Guna2Panel pl1;

		// Token: 0x04000098 RID: 152
		public UserControl uc1;

		// Token: 0x04000099 RID: 153
		public UserControl uc2;

		// Token: 0x0400009A RID: 154
		public UserControl uc3;

		// Token: 0x02000024 RID: 36
		public struct MARGINS
		{
			// Token: 0x04000164 RID: 356
			public int leftWidth;

			// Token: 0x04000165 RID: 357
			public int rightWidth;

			// Token: 0x04000166 RID: 358
			public int topHeight;

			// Token: 0x04000167 RID: 359
			public int bottomHeight;
		}
	}
}
