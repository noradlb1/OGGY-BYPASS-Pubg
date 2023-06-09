using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace OGGY_BYPASS
{
	// Token: 0x02000005 RID: 5
	public class EMULATOR_SELECTOR : UserControl
	{
		// Token: 0x06000029 RID: 41 RVA: 0x00003910 File Offset: 0x00001B10
		public EMULATOR_SELECTOR()
		{
			this.InitializeComponent();
			EMULATOR_SELECTOR.instance = this;
			this.gunaTswitch_1 = this.EX_ToggleSwitch;
			this.gunaTswitch_2 = this.EN_T_Switch;
			this.gunaTswitch_3 = this.CUSTOM_ToggleSwitch;
			this.EMULATOR_PATH = this.EMULATOR_PATH;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000396C File Offset: 0x00001B6C
		private void EMULATOR_SELECTOR_Load(object sender, EventArgs e)
		{
			this.EMULATOR_SELECTOR_PANEL.BackColor = Color.FromArgb(100, 0, 0, 0);
			bool flag = !this.CUSTOM_ToggleSwitch.Checked;
			if (flag)
			{
				this.CUSTOM_PATH_INPUT.Visible = false;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x000039B4 File Offset: 0x00001BB4
		private void EX_ToggleSwitch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.EX_ToggleSwitch.Checked;
			if (@checked)
			{
				this.EN_T_Switch.Checked = false;
				this.CUSTOM_ToggleSwitch.Checked = false;
				this.CUSTOM_PATH_INPUT.Visible = false;
			}
			this.EMULATOR_PATH = "C:\\Program Files\\TxGameAssistant\\ui\\AndroidEmulatorEx.exe";
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00003A08 File Offset: 0x00001C08
		private void EN_T_Switch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.EN_T_Switch.Checked;
			if (@checked)
			{
				this.EX_ToggleSwitch.Checked = false;
				this.CUSTOM_ToggleSwitch.Checked = false;
				this.CUSTOM_PATH_INPUT.Visible = false;
			}
			this.EMULATOR_PATH = "C:\\Program Files\\TxGameAssistant\\ui\\AndroidEmulatorEn.exe";
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003A5C File Offset: 0x00001C5C
		private void CUSTOM_ToggleSwitch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.CUSTOM_ToggleSwitch.Checked;
			if (@checked)
			{
				this.EN_T_Switch.Checked = false;
				this.EX_ToggleSwitch.Checked = false;
				this.CUSTOM_PATH_INPUT.Visible = true;
			}
			bool flag = !this.CUSTOM_ToggleSwitch.Checked;
			if (flag)
			{
				this.CUSTOM_PATH_INPUT.Visible = false;
			}
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003AC1 File Offset: 0x00001CC1
		private void CUSTOM_PATH_INPUT_TextChanged(object sender, EventArgs e)
		{
			this.EMULATOR_PATH = this.CUSTOM_PATH_INPUT.Text;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003AD8 File Offset: 0x00001CD8
		private void Emulator_MainBtn_Click(object sender, EventArgs e)
		{
			bool flag = EMULATOR_SELECTOR.instance.gunaTswitch_1.Checked || EMULATOR_SELECTOR.instance.gunaTswitch_2.Checked || EMULATOR_SELECTOR.instance.gunaTswitch_3.Checked;
			if (flag)
			{
				Main_Page.instance.uc1.Visible = false;
				Main_Page.instance.uc2.Visible = false;
				Main_Page.instance.uc3.Visible = true;
			}
			else
			{
				MessageBox.Show("Select The Emulator Type First!!!!", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00003B6A File Offset: 0x00001D6A
		private void EMULATOR_SELECTOR_PANEL_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00003B70 File Offset: 0x00001D70
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00003BA8 File Offset: 0x00001DA8
		private void InitializeComponent()
		{
			this.EMULATOR_SELECTOR_PANEL = new Guna2Panel();
			this.EN_T_Switch = new Guna2ToggleSwitch();
			this.CUSTOM_PATH_INPUT = new Guna2TextBox();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.CUSTOM_ToggleSwitch = new Guna2ToggleSwitch();
			this.Emulator_MainBtn = new Guna2GradientButton();
			this.EX_ToggleSwitch = new Guna2ToggleSwitch();
			this.GeTitle = new Label();
			this.EMULATOR_SELECTOR_PANEL.SuspendLayout();
			base.SuspendLayout();
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.EN_T_Switch);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.CUSTOM_PATH_INPUT);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.label3);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.label2);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.label1);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.CUSTOM_ToggleSwitch);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.Emulator_MainBtn);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.EX_ToggleSwitch);
			this.EMULATOR_SELECTOR_PANEL.Controls.Add(this.GeTitle);
			this.EMULATOR_SELECTOR_PANEL.Dock = DockStyle.Fill;
			this.EMULATOR_SELECTOR_PANEL.Location = new Point(0, 0);
			this.EMULATOR_SELECTOR_PANEL.Margin = new Padding(4, 4, 4, 4);
			this.EMULATOR_SELECTOR_PANEL.Name = "EMULATOR_SELECTOR_PANEL";
			this.EMULATOR_SELECTOR_PANEL.Size = new Size(447, 542);
			this.EMULATOR_SELECTOR_PANEL.TabIndex = 0;
			this.EMULATOR_SELECTOR_PANEL.Paint += this.EMULATOR_SELECTOR_PANEL_Paint;
			this.EN_T_Switch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.EN_T_Switch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.EN_T_Switch.CheckedState.InnerBorderColor = Color.White;
			this.EN_T_Switch.CheckedState.InnerColor = Color.White;
			this.EN_T_Switch.Location = new Point(87, 182);
			this.EN_T_Switch.Margin = new Padding(4, 4, 4, 4);
			this.EN_T_Switch.Name = "EN_T_Switch";
			this.EN_T_Switch.Size = new Size(47, 25);
			this.EN_T_Switch.TabIndex = 39;
			this.EN_T_Switch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.EN_T_Switch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.EN_T_Switch.UncheckedState.InnerBorderColor = Color.White;
			this.EN_T_Switch.UncheckedState.InnerColor = Color.White;
			this.EN_T_Switch.UseTransparentBackground = true;
			this.EN_T_Switch.CheckedChanged += this.EN_T_Switch_CheckedChanged;
			this.CUSTOM_PATH_INPUT.Cursor = Cursors.IBeam;
			this.CUSTOM_PATH_INPUT.DefaultText = "";
			this.CUSTOM_PATH_INPUT.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
			this.CUSTOM_PATH_INPUT.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
			this.CUSTOM_PATH_INPUT.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
			this.CUSTOM_PATH_INPUT.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
			this.CUSTOM_PATH_INPUT.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.CUSTOM_PATH_INPUT.Font = new Font("Segoe UI", 9f);
			this.CUSTOM_PATH_INPUT.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
			this.CUSTOM_PATH_INPUT.Location = new Point(88, 303);
			this.CUSTOM_PATH_INPUT.Margin = new Padding(4, 5, 4, 5);
			this.CUSTOM_PATH_INPUT.Name = "CUSTOM_PATH_INPUT";
			this.CUSTOM_PATH_INPUT.PasswordChar = '\0';
			this.CUSTOM_PATH_INPUT.PlaceholderText = "";
			this.CUSTOM_PATH_INPUT.SelectedText = "";
			this.CUSTOM_PATH_INPUT.Size = new Size(341, 47);
			this.CUSTOM_PATH_INPUT.TabIndex = 38;
			this.CUSTOM_PATH_INPUT.Visible = false;
			this.CUSTOM_PATH_INPUT.TextChanged += this.CUSTOM_PATH_INPUT_TextChanged;
			this.label3.AutoSize = true;
			this.label3.BackColor = Color.Transparent;
			this.label3.Font = new Font("Times New Roman", 18f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.OrangeRed;
			this.label3.Location = new Point(143, 241);
			this.label3.Margin = new Padding(4, 1, 4, 1);
			this.label3.Name = "label3";
			this.label3.Padding = new Padding(13, 12, 13, 12);
			this.label3.Size = new Size(172, 59);
			this.label3.TabIndex = 37;
			this.label3.Text = "CUSTOM";
			this.label2.AutoSize = true;
			this.label2.BackColor = Color.Transparent;
			this.label2.Font = new Font("Times New Roman", 18f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.OrangeRed;
			this.label2.Location = new Point(143, 165);
			this.label2.Margin = new Padding(4, 1, 4, 1);
			this.label2.Name = "label2";
			this.label2.Padding = new Padding(13, 12, 13, 12);
			this.label2.Size = new Size(83, 59);
			this.label2.TabIndex = 36;
			this.label2.Text = "EN";
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Times New Roman", 18f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.OrangeRed;
			this.label1.Location = new Point(143, 82);
			this.label1.Margin = new Padding(4, 1, 4, 1);
			this.label1.Name = "label1";
			this.label1.Padding = new Padding(13, 12, 13, 12);
			this.label1.Size = new Size(82, 59);
			this.label1.TabIndex = 35;
			this.label1.Text = "EX";
			this.CUSTOM_ToggleSwitch.BackColor = Color.Transparent;
			this.CUSTOM_ToggleSwitch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.CUSTOM_ToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.CUSTOM_ToggleSwitch.CheckedState.InnerBorderColor = Color.White;
			this.CUSTOM_ToggleSwitch.CheckedState.InnerColor = Color.White;
			this.CUSTOM_ToggleSwitch.Location = new Point(88, 257);
			this.CUSTOM_ToggleSwitch.Margin = new Padding(4, 4, 4, 4);
			this.CUSTOM_ToggleSwitch.Name = "CUSTOM_ToggleSwitch";
			this.CUSTOM_ToggleSwitch.Size = new Size(47, 25);
			this.CUSTOM_ToggleSwitch.TabIndex = 34;
			this.CUSTOM_ToggleSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.CUSTOM_ToggleSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.CUSTOM_ToggleSwitch.UncheckedState.InnerBorderColor = Color.White;
			this.CUSTOM_ToggleSwitch.UncheckedState.InnerColor = Color.White;
			this.CUSTOM_ToggleSwitch.CheckedChanged += this.CUSTOM_ToggleSwitch_CheckedChanged;
			this.Emulator_MainBtn.BackColor = Color.Transparent;
			this.Emulator_MainBtn.BorderColor = Color.Lime;
			this.Emulator_MainBtn.BorderRadius = 20;
			this.Emulator_MainBtn.BorderThickness = 2;
			this.Emulator_MainBtn.DisabledState.BorderColor = Color.DarkGray;
			this.Emulator_MainBtn.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Emulator_MainBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Emulator_MainBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			this.Emulator_MainBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Emulator_MainBtn.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
			this.Emulator_MainBtn.ForeColor = Color.White;
			this.Emulator_MainBtn.GradientMode = LinearGradientMode.ForwardDiagonal;
			this.Emulator_MainBtn.HoverState.BorderColor = Color.Cyan;
			this.Emulator_MainBtn.Location = new Point(73, 438);
			this.Emulator_MainBtn.Margin = new Padding(27, 25, 27, 25);
			this.Emulator_MainBtn.Name = "Emulator_MainBtn";
			this.Emulator_MainBtn.Padding = new Padding(7, 6, 7, 6);
			this.Emulator_MainBtn.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Emulator_MainBtn.Size = new Size(300, 89);
			this.Emulator_MainBtn.TabIndex = 32;
			this.Emulator_MainBtn.Text = "GO!!";
			this.Emulator_MainBtn.UseTransparentBackground = true;
			this.Emulator_MainBtn.Click += this.Emulator_MainBtn_Click;
			this.EX_ToggleSwitch.BackColor = Color.Transparent;
			this.EX_ToggleSwitch.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
			this.EX_ToggleSwitch.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
			this.EX_ToggleSwitch.CheckedState.InnerBorderColor = Color.White;
			this.EX_ToggleSwitch.CheckedState.InnerColor = Color.White;
			this.EX_ToggleSwitch.Location = new Point(88, 102);
			this.EX_ToggleSwitch.Margin = new Padding(4, 4, 4, 4);
			this.EX_ToggleSwitch.Name = "EX_ToggleSwitch";
			this.EX_ToggleSwitch.Size = new Size(47, 25);
			this.EX_ToggleSwitch.TabIndex = 31;
			this.EX_ToggleSwitch.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
			this.EX_ToggleSwitch.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
			this.EX_ToggleSwitch.UncheckedState.InnerBorderColor = Color.White;
			this.EX_ToggleSwitch.UncheckedState.InnerColor = Color.White;
			this.EX_ToggleSwitch.CheckedChanged += this.EX_ToggleSwitch_CheckedChanged;
			this.GeTitle.AutoSize = true;
			this.GeTitle.BackColor = Color.Transparent;
			this.GeTitle.Font = new Font("Times New Roman", 18f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.GeTitle.ForeColor = Color.Cyan;
			this.GeTitle.Location = new Point(44, 4);
			this.GeTitle.Margin = new Padding(4, 1, 4, 1);
			this.GeTitle.Name = "GeTitle";
			this.GeTitle.Padding = new Padding(13, 12, 13, 12);
			this.GeTitle.Size = new Size(339, 59);
			this.GeTitle.TabIndex = 30;
			this.GeTitle.Text = "SELECT EMUALTOR";
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.EMULATOR_SELECTOR_PANEL);
			base.Margin = new Padding(4, 4, 4, 4);
			base.Name = "EMULATOR_SELECTOR";
			base.Size = new Size(447, 542);
			base.Load += this.EMULATOR_SELECTOR_Load;
			this.EMULATOR_SELECTOR_PANEL.ResumeLayout(false);
			this.EMULATOR_SELECTOR_PANEL.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x0400000F RID: 15
		public static EMULATOR_SELECTOR instance;

		// Token: 0x04000010 RID: 16
		public Guna2ToggleSwitch gunaTswitch_1;

		// Token: 0x04000011 RID: 17
		public Guna2ToggleSwitch gunaTswitch_2;

		// Token: 0x04000012 RID: 18
		public Guna2ToggleSwitch gunaTswitch_3;

		// Token: 0x04000013 RID: 19
		public string EMULATOR_PATH;

		// Token: 0x04000014 RID: 20
		public string Static_Emu_Path;

		// Token: 0x04000015 RID: 21
		private IContainer components = null;

		// Token: 0x04000016 RID: 22
		private Guna2Panel EMULATOR_SELECTOR_PANEL;

		// Token: 0x04000017 RID: 23
		private Label label3;

		// Token: 0x04000018 RID: 24
		private Label label2;

		// Token: 0x04000019 RID: 25
		private Label label1;

		// Token: 0x0400001A RID: 26
		private Guna2ToggleSwitch CUSTOM_ToggleSwitch;

		// Token: 0x0400001B RID: 27
		private Guna2GradientButton Emulator_MainBtn;

		// Token: 0x0400001C RID: 28
		private Guna2ToggleSwitch EX_ToggleSwitch;

		// Token: 0x0400001D RID: 29
		private Label GeTitle;

		// Token: 0x0400001E RID: 30
		private Guna2TextBox CUSTOM_PATH_INPUT;

		// Token: 0x0400001F RID: 31
		private Guna2ToggleSwitch EN_T_Switch;
	}
}
