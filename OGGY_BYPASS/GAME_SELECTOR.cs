using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;

namespace OGGY_BYPASS
{
	// Token: 0x02000007 RID: 7
	public class GAME_SELECTOR : UserControl
	{
		// Token: 0x0600004C RID: 76 RVA: 0x00006499 File Offset: 0x00004699
		public GAME_SELECTOR()
		{
			this.InitializeComponent();
			GAME_SELECTOR.instance = this;
			this.version_check_btn = this.Version_SelectedBtn;
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000064C3 File Offset: 0x000046C3
		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600004E RID: 78 RVA: 0x000064C6 File Offset: 0x000046C6
		private void GAME_SELECTOR_Load(object sender, EventArgs e)
		{
			this.guna2Panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
			this.Version_SelectedBtn.Visible = false;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x000064EC File Offset: 0x000046EC
		private void Version_SelectedBtn_Click(object sender, EventArgs e)
		{
			bool flag = this.BGMI_CheckBox.Checked || this.GLOBAL_CheckBox.Checked || this.KOREA_CheckBox.Checked || this.VEIATNAM_CheckBox.Checked;
			if (flag)
			{
				Main_Page.instance.uc1.Visible = false;
				Main_Page.instance.uc2.Visible = true;
				Main_Page.instance.uc3.Visible = false;
			}
			else
			{
				MessageBox.Show("Select Game First!!!!", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00006580 File Offset: 0x00004780
		private void BGMI_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Version_SelectedBtn.Visible = true;
			bool @checked = this.BGMI_CheckBox.Checked;
			if (@checked)
			{
				this.GLOBAL_CheckBox.Checked = false;
				this.KOREA_CheckBox.Checked = false;
				this.VEIATNAM_CheckBox.Checked = false;
			}
			this.Version_SelectedBtn.Text = "BGMI";
		}

		// Token: 0x06000051 RID: 81 RVA: 0x000065E4 File Offset: 0x000047E4
		private void GLOBAL_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Version_SelectedBtn.Visible = true;
			bool @checked = this.GLOBAL_CheckBox.Checked;
			if (@checked)
			{
				this.BGMI_CheckBox.Checked = false;
				this.KOREA_CheckBox.Checked = false;
				this.VEIATNAM_CheckBox.Checked = false;
			}
			this.Version_SelectedBtn.Text = "GLOBAL";
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00006648 File Offset: 0x00004848
		private void KOREA_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Version_SelectedBtn.Visible = true;
			bool @checked = this.KOREA_CheckBox.Checked;
			if (@checked)
			{
				this.GLOBAL_CheckBox.Checked = false;
				this.BGMI_CheckBox.Checked = false;
				this.VEIATNAM_CheckBox.Checked = false;
			}
			this.Version_SelectedBtn.Text = "KOREA";
		}

		// Token: 0x06000053 RID: 83 RVA: 0x000066AC File Offset: 0x000048AC
		private void VEIATNAM_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			this.Version_SelectedBtn.Visible = true;
			bool @checked = this.VEIATNAM_CheckBox.Checked;
			if (@checked)
			{
				this.GLOBAL_CheckBox.Checked = false;
				this.KOREA_CheckBox.Checked = false;
				this.BGMI_CheckBox.Checked = false;
			}
			this.Version_SelectedBtn.Text = "VEITNAM";
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00006710 File Offset: 0x00004910
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00006748 File Offset: 0x00004948
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(GAME_SELECTOR));
			this.guna2Panel1 = new Guna2Panel();
			this.Version_SelectedBtn = new Guna2GradientButton();
			this.GvTitle = new Label();
			this.VEIATNAM_CheckBox = new Guna2ImageCheckBox();
			this.KOREA_CheckBox = new Guna2ImageCheckBox();
			this.GLOBAL_CheckBox = new Guna2ImageCheckBox();
			this.BGMI_CheckBox = new Guna2ImageCheckBox();
			this.guna2Elipse1 = new Guna2Elipse(this.components);
			this.guna2Elipse2 = new Guna2Elipse(this.components);
			this.guna2Elipse3 = new Guna2Elipse(this.components);
			this.guna2Elipse4 = new Guna2Elipse(this.components);
			this.guna2Elipse5 = new Guna2Elipse(this.components);
			this.guna2Panel1.SuspendLayout();
			base.SuspendLayout();
			this.guna2Panel1.Controls.Add(this.Version_SelectedBtn);
			this.guna2Panel1.Controls.Add(this.GvTitle);
			this.guna2Panel1.Controls.Add(this.VEIATNAM_CheckBox);
			this.guna2Panel1.Controls.Add(this.KOREA_CheckBox);
			this.guna2Panel1.Controls.Add(this.GLOBAL_CheckBox);
			this.guna2Panel1.Controls.Add(this.BGMI_CheckBox);
			this.guna2Panel1.Dock = DockStyle.Fill;
			this.guna2Panel1.Location = new Point(0, 0);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new Size(335, 440);
			this.guna2Panel1.TabIndex = 0;
			this.guna2Panel1.Paint += this.guna2Panel1_Paint;
			this.Version_SelectedBtn.BackColor = Color.Transparent;
			this.Version_SelectedBtn.BorderColor = Color.Yellow;
			this.Version_SelectedBtn.BorderRadius = 20;
			this.Version_SelectedBtn.BorderThickness = 2;
			this.Version_SelectedBtn.DisabledState.BorderColor = Color.DarkGray;
			this.Version_SelectedBtn.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Version_SelectedBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Version_SelectedBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			this.Version_SelectedBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Version_SelectedBtn.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
			this.Version_SelectedBtn.ForeColor = Color.White;
			this.Version_SelectedBtn.GradientMode = LinearGradientMode.ForwardDiagonal;
			this.Version_SelectedBtn.HoverState.BorderColor = Color.Cyan;
			this.Version_SelectedBtn.Location = new Point(49, 356);
			this.Version_SelectedBtn.Margin = new Padding(20);
			this.Version_SelectedBtn.Name = "Version_SelectedBtn";
			this.Version_SelectedBtn.Padding = new Padding(5);
			this.Version_SelectedBtn.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Version_SelectedBtn.Size = new Size(225, 72);
			this.Version_SelectedBtn.TabIndex = 49;
			this.Version_SelectedBtn.Text = "BGMI";
			this.Version_SelectedBtn.UseTransparentBackground = true;
			this.Version_SelectedBtn.Click += this.Version_SelectedBtn_Click;
			this.GvTitle.AutoSize = true;
			this.GvTitle.BackColor = Color.Transparent;
			this.GvTitle.Font = new Font("Times New Roman", 18f, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.GvTitle.ForeColor = Color.Cyan;
			this.GvTitle.Location = new Point(49, 4);
			this.GvTitle.Margin = new Padding(3, 1, 3, 1);
			this.GvTitle.Name = "GvTitle";
			this.GvTitle.Padding = new Padding(10);
			this.GvTitle.Size = new Size(239, 46);
			this.GvTitle.TabIndex = 48;
			this.GvTitle.Text = "SELECT VERSION";
			this.VEIATNAM_CheckBox.BackColor = Color.Aquamarine;
			this.VEIATNAM_CheckBox.CheckedState.Image = (Image)resources.GetObject("resource.Image");
			this.VEIATNAM_CheckBox.CheckedState.ImageSize = new Size(120, 120);
			this.VEIATNAM_CheckBox.Cursor = Cursors.Hand;
			this.VEIATNAM_CheckBox.HoverState.ImageSize = new Size(135, 135);
			this.VEIATNAM_CheckBox.Image = (Image)resources.GetObject("VEIATNAM_CheckBox.Image");
			this.VEIATNAM_CheckBox.ImageOffset = new Point(0, 0);
			this.VEIATNAM_CheckBox.ImageRotate = 0f;
			this.VEIATNAM_CheckBox.ImageSize = new Size(125, 125);
			this.VEIATNAM_CheckBox.Location = new Point(180, 208);
			this.VEIATNAM_CheckBox.Name = "VEIATNAM_CheckBox";
			this.VEIATNAM_CheckBox.PressedState.ImageSize = new Size(115, 115);
			this.VEIATNAM_CheckBox.Size = new Size(125, 125);
			this.VEIATNAM_CheckBox.TabIndex = 47;
			this.VEIATNAM_CheckBox.CheckedChanged += this.VEIATNAM_CheckBox_CheckedChanged;
			this.KOREA_CheckBox.BackColor = Color.Aquamarine;
			this.KOREA_CheckBox.CheckedState.Image = (Image)resources.GetObject("resource.Image1");
			this.KOREA_CheckBox.CheckedState.ImageSize = new Size(120, 120);
			this.KOREA_CheckBox.Cursor = Cursors.Hand;
			this.KOREA_CheckBox.HoverState.ImageSize = new Size(135, 135);
			this.KOREA_CheckBox.Image = (Image)resources.GetObject("KOREA_CheckBox.Image");
			this.KOREA_CheckBox.ImageOffset = new Point(0, 0);
			this.KOREA_CheckBox.ImageRotate = 0f;
			this.KOREA_CheckBox.ImageSize = new Size(125, 125);
			this.KOREA_CheckBox.Location = new Point(30, 208);
			this.KOREA_CheckBox.Name = "KOREA_CheckBox";
			this.KOREA_CheckBox.PressedState.ImageSize = new Size(115, 115);
			this.KOREA_CheckBox.Size = new Size(125, 125);
			this.KOREA_CheckBox.TabIndex = 46;
			this.KOREA_CheckBox.CheckedChanged += this.KOREA_CheckBox_CheckedChanged;
			this.GLOBAL_CheckBox.BackColor = Color.Aquamarine;
			this.GLOBAL_CheckBox.CheckedState.Image = (Image)resources.GetObject("resource.Image2");
			this.GLOBAL_CheckBox.CheckedState.ImageSize = new Size(120, 120);
			this.GLOBAL_CheckBox.Cursor = Cursors.Hand;
			this.GLOBAL_CheckBox.HoverState.ImageSize = new Size(135, 135);
			this.GLOBAL_CheckBox.Image = (Image)resources.GetObject("GLOBAL_CheckBox.Image");
			this.GLOBAL_CheckBox.ImageOffset = new Point(0, 0);
			this.GLOBAL_CheckBox.ImageRotate = 0f;
			this.GLOBAL_CheckBox.ImageSize = new Size(125, 125);
			this.GLOBAL_CheckBox.Location = new Point(180, 62);
			this.GLOBAL_CheckBox.Name = "GLOBAL_CheckBox";
			this.GLOBAL_CheckBox.PressedState.ImageSize = new Size(115, 115);
			this.GLOBAL_CheckBox.Size = new Size(125, 125);
			this.GLOBAL_CheckBox.TabIndex = 45;
			this.GLOBAL_CheckBox.CheckedChanged += this.GLOBAL_CheckBox_CheckedChanged;
			this.BGMI_CheckBox.BackColor = Color.Aquamarine;
			this.BGMI_CheckBox.CheckedState.Image = (Image)resources.GetObject("resource.Image3");
			this.BGMI_CheckBox.CheckedState.ImageSize = new Size(120, 120);
			this.BGMI_CheckBox.Cursor = Cursors.Hand;
			this.BGMI_CheckBox.HoverState.ImageSize = new Size(135, 135);
			this.BGMI_CheckBox.Image = (Image)resources.GetObject("BGMI_CheckBox.Image");
			this.BGMI_CheckBox.ImageOffset = new Point(0, 0);
			this.BGMI_CheckBox.ImageRotate = 0f;
			this.BGMI_CheckBox.ImageSize = new Size(125, 125);
			this.BGMI_CheckBox.Location = new Point(30, 62);
			this.BGMI_CheckBox.Name = "BGMI_CheckBox";
			this.BGMI_CheckBox.PressedState.ImageSize = new Size(115, 115);
			this.BGMI_CheckBox.Size = new Size(125, 125);
			this.BGMI_CheckBox.TabIndex = 44;
			this.BGMI_CheckBox.CheckedChanged += this.BGMI_CheckBox_CheckedChanged;
			this.guna2Elipse1.BorderRadius = 20;
			this.guna2Elipse1.TargetControl = this.GvTitle;
			this.guna2Elipse2.TargetControl = this.BGMI_CheckBox;
			this.guna2Elipse3.TargetControl = this.GLOBAL_CheckBox;
			this.guna2Elipse4.TargetControl = this.KOREA_CheckBox;
			this.guna2Elipse5.TargetControl = this.VEIATNAM_CheckBox;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.guna2Panel1);
			base.Name = "GAME_SELECTOR";
			base.Size = new Size(335, 440);
			base.Load += this.GAME_SELECTOR_Load;
			this.guna2Panel1.ResumeLayout(false);
			this.guna2Panel1.PerformLayout();
			base.ResumeLayout(false);
		}

		// Token: 0x04000037 RID: 55
		public static GAME_SELECTOR instance;

		// Token: 0x04000038 RID: 56
		public Guna2GradientButton version_check_btn;

		// Token: 0x04000039 RID: 57
		private IContainer components = null;

		// Token: 0x0400003A RID: 58
		private Guna2Panel guna2Panel1;

		// Token: 0x0400003B RID: 59
		private Guna2GradientButton Version_SelectedBtn;

		// Token: 0x0400003C RID: 60
		private Label GvTitle;

		// Token: 0x0400003D RID: 61
		private Guna2ImageCheckBox VEIATNAM_CheckBox;

		// Token: 0x0400003E RID: 62
		private Guna2ImageCheckBox KOREA_CheckBox;

		// Token: 0x0400003F RID: 63
		private Guna2ImageCheckBox GLOBAL_CheckBox;

		// Token: 0x04000040 RID: 64
		private Guna2ImageCheckBox BGMI_CheckBox;

		// Token: 0x04000041 RID: 65
		private Guna2Elipse guna2Elipse1;

		// Token: 0x04000042 RID: 66
		private Guna2Elipse guna2Elipse2;

		// Token: 0x04000043 RID: 67
		private Guna2Elipse guna2Elipse3;

		// Token: 0x04000044 RID: 68
		private Guna2Elipse guna2Elipse4;

		// Token: 0x04000045 RID: 69
		private Guna2Elipse guna2Elipse5;
	}
}
