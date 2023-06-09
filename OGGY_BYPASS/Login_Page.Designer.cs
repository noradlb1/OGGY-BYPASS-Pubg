namespace OGGY_BYPASS
{
	// Token: 0x02000009 RID: 9
	public partial class Login_Page : global::System.Windows.Forms.Form
	{
		// Token: 0x06000098 RID: 152 RVA: 0x00009B50 File Offset: 0x00007D50
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00009B88 File Offset: 0x00007D88
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager resources = new global::System.ComponentModel.ComponentResourceManager(typeof(global::OGGY_BYPASS.Login_Page));
			this.CLOSE = new global::Guna.UI2.WinForms.Guna2CircleButton();
			this.MINIMIZE = new global::Guna.UI2.WinForms.Guna2CircleButton();
			this.LoginPage_Header = new global::Guna.UI2.WinForms.Guna2Panel();
			this.Twitter_link = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.Discord_link = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.Youtube_Link = new global::Guna.UI2.WinForms.Guna2ImageButton();
			this.guna2CirclePictureBox1 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.GeTitle = new global::System.Windows.Forms.Label();
			this.guna2Panel1 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.guna2CirclePictureBox2 = new global::Guna.UI2.WinForms.Guna2CirclePictureBox();
			this.AuthKey_Input = new global::Guna.UI2.WinForms.Guna2TextBox();
			this.guna2Panel2 = new global::Guna.UI2.WinForms.Guna2Panel();
			this.GET_KEY_BTN = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.LOGIN_BTN = new global::Guna.UI2.WinForms.Guna2GradientButton();
			this.guna2Elipse1 = new global::Guna.UI2.WinForms.Guna2Elipse(this.components);
			this.guna2BorderlessForm1 = new global::Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
			this.LoginPage_Header.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox2).BeginInit();
			base.SuspendLayout();
			this.CLOSE.BackColor = global::System.Drawing.Color.Transparent;
			this.CLOSE.BorderColor = global::System.Drawing.Color.Red;
			this.CLOSE.BorderThickness = 3;
			this.CLOSE.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.CLOSE.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.CLOSE.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.CLOSE.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.CLOSE.FillColor = global::System.Drawing.Color.Transparent;
			this.CLOSE.Font = new global::System.Drawing.Font("Lucida Console", 15f, global::System.Drawing.FontStyle.Bold);
			this.CLOSE.ForeColor = global::System.Drawing.Color.Red;
			this.CLOSE.HoverState.BorderColor = global::System.Drawing.Color.Transparent;
			this.CLOSE.HoverState.FillColor = global::System.Drawing.Color.Red;
			this.CLOSE.HoverState.ForeColor = global::System.Drawing.Color.Black;
			this.CLOSE.ImageSize = new global::System.Drawing.Size(50, 50);
			this.CLOSE.Location = new global::System.Drawing.Point(64, 7);
			this.CLOSE.Name = "CLOSE";
			this.CLOSE.PressedColor = global::System.Drawing.Color.FromArgb(192, 0, 0);
			this.CLOSE.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.CLOSE.Size = new global::System.Drawing.Size(20, 20);
			this.CLOSE.TabIndex = 32;
			this.CLOSE.Text = "X";
			this.CLOSE.UseTransparentBackground = true;
			this.CLOSE.Click += new global::System.EventHandler(this.CLOSE_Click);
			this.MINIMIZE.BackColor = global::System.Drawing.Color.Transparent;
			this.MINIMIZE.BorderColor = global::System.Drawing.Color.Lime;
			this.MINIMIZE.BorderThickness = 3;
			this.MINIMIZE.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.MINIMIZE.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.MINIMIZE.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.MINIMIZE.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.MINIMIZE.FillColor = global::System.Drawing.Color.Transparent;
			this.MINIMIZE.Font = new global::System.Drawing.Font("Lucida Console", 15f, global::System.Drawing.FontStyle.Bold);
			this.MINIMIZE.ForeColor = global::System.Drawing.Color.Red;
			this.MINIMIZE.HoverState.BorderColor = global::System.Drawing.Color.Lime;
			this.MINIMIZE.HoverState.FillColor = global::System.Drawing.Color.Lime;
			this.MINIMIZE.HoverState.ForeColor = global::System.Drawing.Color.Black;
			this.MINIMIZE.ImageSize = new global::System.Drawing.Size(50, 50);
			this.MINIMIZE.Location = new global::System.Drawing.Point(20, 7);
			this.MINIMIZE.Name = "MINIMIZE";
			this.MINIMIZE.PressedColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.MINIMIZE.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.MINIMIZE.Size = new global::System.Drawing.Size(20, 20);
			this.MINIMIZE.TabIndex = 31;
			this.MINIMIZE.Text = "-";
			this.MINIMIZE.UseTransparentBackground = true;
			this.MINIMIZE.Click += new global::System.EventHandler(this.MINIMIZE_Click);
			this.LoginPage_Header.BackColor = global::System.Drawing.Color.Transparent;
			this.LoginPage_Header.Controls.Add(this.CLOSE);
			this.LoginPage_Header.Controls.Add(this.MINIMIZE);
			this.LoginPage_Header.Location = new global::System.Drawing.Point(271, 7);
			this.LoginPage_Header.Name = "LoginPage_Header";
			this.LoginPage_Header.Size = new global::System.Drawing.Size(107, 35);
			this.LoginPage_Header.TabIndex = 32;
			this.Twitter_link.BackColor = global::System.Drawing.Color.Transparent;
			this.Twitter_link.CheckedState.ImageSize = new global::System.Drawing.Size(64, 64);
			this.Twitter_link.HoverState.ImageSize = new global::System.Drawing.Size(50, 50);
			this.Twitter_link.Image = (global::System.Drawing.Image)resources.GetObject("Twitter_link.Image");
			this.Twitter_link.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.Twitter_link.ImageRotate = 0f;
			this.Twitter_link.ImageSize = new global::System.Drawing.Size(48, 48);
			this.Twitter_link.Location = new global::System.Drawing.Point(259, 461);
			this.Twitter_link.Name = "Twitter_link";
			this.Twitter_link.PressedState.ImageSize = new global::System.Drawing.Size(49, 49);
			this.Twitter_link.Size = new global::System.Drawing.Size(57, 57);
			this.Twitter_link.TabIndex = 37;
			this.Twitter_link.UseTransparentBackground = true;
			this.Twitter_link.Click += new global::System.EventHandler(this.Twitter_link_Click);
			this.Discord_link.BackColor = global::System.Drawing.Color.Transparent;
			this.Discord_link.CheckedState.ImageSize = new global::System.Drawing.Size(64, 64);
			this.Discord_link.HoverState.ImageSize = new global::System.Drawing.Size(56, 56);
			this.Discord_link.Image = (global::System.Drawing.Image)resources.GetObject("Discord_link.Image");
			this.Discord_link.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.Discord_link.ImageRotate = 0f;
			this.Discord_link.ImageSize = new global::System.Drawing.Size(54, 54);
			this.Discord_link.Location = new global::System.Drawing.Point(173, 461);
			this.Discord_link.Name = "Discord_link";
			this.Discord_link.PressedState.ImageSize = new global::System.Drawing.Size(55, 55);
			this.Discord_link.Size = new global::System.Drawing.Size(57, 57);
			this.Discord_link.TabIndex = 36;
			this.Discord_link.UseTransparentBackground = true;
			this.Discord_link.Click += new global::System.EventHandler(this.Discord_link_Click);
			this.Youtube_Link.BackColor = global::System.Drawing.Color.Transparent;
			this.Youtube_Link.CheckedState.ImageSize = new global::System.Drawing.Size(64, 64);
			this.Youtube_Link.HoverState.ImageSize = new global::System.Drawing.Size(66, 66);
			this.Youtube_Link.Image = (global::System.Drawing.Image)resources.GetObject("Youtube_Link.Image");
			this.Youtube_Link.ImageOffset = new global::System.Drawing.Point(0, 0);
			this.Youtube_Link.ImageRotate = 0f;
			this.Youtube_Link.Location = new global::System.Drawing.Point(86, 463);
			this.Youtube_Link.Name = "Youtube_Link";
			this.Youtube_Link.PressedState.ImageSize = new global::System.Drawing.Size(65, 65);
			this.Youtube_Link.Size = new global::System.Drawing.Size(57, 57);
			this.Youtube_Link.TabIndex = 35;
			this.Youtube_Link.UseTransparentBackground = true;
			this.Youtube_Link.Click += new global::System.EventHandler(this.Youtube_Link_Click);
			this.guna2CirclePictureBox1.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox1.Image = (global::System.Drawing.Image)resources.GetObject("guna2CirclePictureBox1.Image");
			this.guna2CirclePictureBox1.ImageRotate = 0f;
			this.guna2CirclePictureBox1.Location = new global::System.Drawing.Point(110, 53);
			this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
			this.guna2CirclePictureBox1.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox1.Size = new global::System.Drawing.Size(169, 169);
			this.guna2CirclePictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.guna2CirclePictureBox1.TabIndex = 38;
			this.guna2CirclePictureBox1.TabStop = false;
			this.guna2CirclePictureBox1.UseTransparentBackground = true;
			this.GeTitle.AutoSize = true;
			this.GeTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.GeTitle.Font = new global::System.Drawing.Font("Sitka Text", 20.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.GeTitle.ForeColor = global::System.Drawing.Color.Indigo;
			this.GeTitle.Location = new global::System.Drawing.Point(12, 236);
			this.GeTitle.Margin = new global::System.Windows.Forms.Padding(3, 1, 3, 1);
			this.GeTitle.Name = "GeTitle";
			this.GeTitle.Padding = new global::System.Windows.Forms.Padding(10);
			this.GeTitle.Size = new global::System.Drawing.Size(351, 59);
			this.GeTitle.TabIndex = 40;
			this.GeTitle.Text = "AUTHENTICATION KEY";
			this.guna2Panel1.BackColor = global::System.Drawing.Color.Red;
			this.guna2Panel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Panel1.Location = new global::System.Drawing.Point(19, 360);
			this.guna2Panel1.Name = "guna2Panel1";
			this.guna2Panel1.Size = new global::System.Drawing.Size(349, 2);
			this.guna2Panel1.TabIndex = 41;
			this.guna2CirclePictureBox2.BackColor = global::System.Drawing.Color.Transparent;
			this.guna2CirclePictureBox2.Image = (global::System.Drawing.Image)resources.GetObject("guna2CirclePictureBox2.Image");
			this.guna2CirclePictureBox2.ImageRotate = 0f;
			this.guna2CirclePictureBox2.Location = new global::System.Drawing.Point(19, 313);
			this.guna2CirclePictureBox2.Name = "guna2CirclePictureBox2";
			this.guna2CirclePictureBox2.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.guna2CirclePictureBox2.Size = new global::System.Drawing.Size(40, 40);
			this.guna2CirclePictureBox2.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.guna2CirclePictureBox2.TabIndex = 42;
			this.guna2CirclePictureBox2.TabStop = false;
			this.guna2CirclePictureBox2.UseTransparentBackground = true;
			this.AuthKey_Input.AutoRoundedCorners = true;
			this.AuthKey_Input.BackColor = global::System.Drawing.Color.Transparent;
			this.AuthKey_Input.BorderColor = global::System.Drawing.Color.Orange;
			this.AuthKey_Input.BorderRadius = 19;
			this.AuthKey_Input.BorderThickness = 2;
			this.AuthKey_Input.Cursor = global::System.Windows.Forms.Cursors.IBeam;
			this.AuthKey_Input.DefaultText = "";
			this.AuthKey_Input.DisabledState.BorderColor = global::System.Drawing.Color.FromArgb(208, 208, 208);
			this.AuthKey_Input.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(226, 226, 226);
			this.AuthKey_Input.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.AuthKey_Input.DisabledState.PlaceholderForeColor = global::System.Drawing.Color.FromArgb(138, 138, 138);
			this.AuthKey_Input.FillColor = global::System.Drawing.Color.CornflowerBlue;
			this.AuthKey_Input.FocusedState.BorderColor = global::System.Drawing.Color.Lime;
			this.AuthKey_Input.Font = new global::System.Drawing.Font("Arial", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.AuthKey_Input.ForeColor = global::System.Drawing.Color.Black;
			this.AuthKey_Input.HoverState.BorderColor = global::System.Drawing.Color.Lime;
			this.AuthKey_Input.Location = new global::System.Drawing.Point(65, 313);
			this.AuthKey_Input.Name = "AuthKey_Input";
			this.AuthKey_Input.PasswordChar = '\0';
			this.AuthKey_Input.PlaceholderText = "";
			this.AuthKey_Input.SelectedText = "";
			this.AuthKey_Input.Size = new global::System.Drawing.Size(302, 40);
			this.AuthKey_Input.TabIndex = 43;
			this.AuthKey_Input.TextChanged += new global::System.EventHandler(this.AuthKey_Input_TextChanged_1);
			this.guna2Panel2.BackColor = global::System.Drawing.Color.Red;
			this.guna2Panel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.guna2Panel2.Location = new global::System.Drawing.Point(19, 294);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new global::System.Drawing.Size(349, 2);
			this.guna2Panel2.TabIndex = 44;
			this.GET_KEY_BTN.BackColor = global::System.Drawing.Color.Transparent;
			this.GET_KEY_BTN.BorderColor = global::System.Drawing.Color.Lime;
			this.GET_KEY_BTN.BorderRadius = 20;
			this.GET_KEY_BTN.BorderThickness = 2;
			this.GET_KEY_BTN.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.GET_KEY_BTN.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.GET_KEY_BTN.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.GET_KEY_BTN.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.GET_KEY_BTN.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.GET_KEY_BTN.FillColor = global::System.Drawing.Color.Cyan;
			this.GET_KEY_BTN.FillColor2 = global::System.Drawing.Color.FromArgb(192, 0, 192);
			this.GET_KEY_BTN.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold);
			this.GET_KEY_BTN.ForeColor = global::System.Drawing.Color.White;
			this.GET_KEY_BTN.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.GET_KEY_BTN.HoverState.BorderColor = global::System.Drawing.Color.Cyan;
			this.GET_KEY_BTN.Location = new global::System.Drawing.Point(212, 376);
			this.GET_KEY_BTN.Margin = new global::System.Windows.Forms.Padding(20);
			this.GET_KEY_BTN.Name = "GET_KEY_BTN";
			this.GET_KEY_BTN.Padding = new global::System.Windows.Forms.Padding(5);
			this.GET_KEY_BTN.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.GET_KEY_BTN.Size = new global::System.Drawing.Size(148, 62);
			this.GET_KEY_BTN.TabIndex = 45;
			this.GET_KEY_BTN.Text = "GET KEY";
			this.GET_KEY_BTN.UseTransparentBackground = true;
			this.GET_KEY_BTN.Click += new global::System.EventHandler(this.GET_KEY_BTN_Click);
			this.LOGIN_BTN.BackColor = global::System.Drawing.Color.Transparent;
			this.LOGIN_BTN.BorderColor = global::System.Drawing.Color.Lime;
			this.LOGIN_BTN.BorderRadius = 20;
			this.LOGIN_BTN.BorderThickness = 2;
			this.LOGIN_BTN.DisabledState.BorderColor = global::System.Drawing.Color.DarkGray;
			this.LOGIN_BTN.DisabledState.CustomBorderColor = global::System.Drawing.Color.DarkGray;
			this.LOGIN_BTN.DisabledState.FillColor = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.LOGIN_BTN.DisabledState.FillColor2 = global::System.Drawing.Color.FromArgb(169, 169, 169);
			this.LOGIN_BTN.DisabledState.ForeColor = global::System.Drawing.Color.FromArgb(141, 141, 141);
			this.LOGIN_BTN.FillColor = global::System.Drawing.Color.Transparent;
			this.LOGIN_BTN.FillColor2 = global::System.Drawing.Color.Transparent;
			this.LOGIN_BTN.Font = new global::System.Drawing.Font("Segoe UI", 18f, global::System.Drawing.FontStyle.Bold);
			this.LOGIN_BTN.ForeColor = global::System.Drawing.Color.White;
			this.LOGIN_BTN.GradientMode = global::System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
			this.LOGIN_BTN.HoverState.BorderColor = global::System.Drawing.Color.Cyan;
			this.LOGIN_BTN.HoverState.FillColor = global::System.Drawing.Color.Transparent;
			this.LOGIN_BTN.HoverState.FillColor2 = global::System.Drawing.Color.Cyan;
			this.LOGIN_BTN.Location = new global::System.Drawing.Point(47, 376);
			this.LOGIN_BTN.Margin = new global::System.Windows.Forms.Padding(20);
			this.LOGIN_BTN.Name = "LOGIN_BTN";
			this.LOGIN_BTN.Padding = new global::System.Windows.Forms.Padding(5);
			this.LOGIN_BTN.ShadowDecoration.Mode = global::Guna.UI2.WinForms.Enums.ShadowMode.Circle;
			this.LOGIN_BTN.Size = new global::System.Drawing.Size(148, 62);
			this.LOGIN_BTN.TabIndex = 46;
			this.LOGIN_BTN.Text = "LOGIN";
			this.LOGIN_BTN.UseTransparentBackground = true;
			this.LOGIN_BTN.Click += new global::System.EventHandler(this.LOGIN_BTN_Click);
			this.guna2Elipse1.TargetControl = this.LoginPage_Header;
			this.guna2BorderlessForm1.ContainerControl = this;
			this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6;
			this.guna2BorderlessForm1.ShadowColor = global::System.Drawing.Color.Red;
			this.guna2BorderlessForm1.TransparentWhileDrag = true;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Zoom;
			base.ClientSize = new global::System.Drawing.Size(389, 550);
			base.Controls.Add(this.LOGIN_BTN);
			base.Controls.Add(this.GET_KEY_BTN);
			base.Controls.Add(this.guna2Panel2);
			base.Controls.Add(this.AuthKey_Input);
			base.Controls.Add(this.guna2CirclePictureBox2);
			base.Controls.Add(this.guna2Panel1);
			base.Controls.Add(this.GeTitle);
			base.Controls.Add(this.guna2CirclePictureBox1);
			base.Controls.Add(this.Twitter_link);
			base.Controls.Add(this.Discord_link);
			base.Controls.Add(this.Youtube_Link);
			base.Controls.Add(this.LoginPage_Header);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)resources.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Login_Page";
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login_Page";
			base.Load += new global::System.EventHandler(this.Login_Page_Load);
			this.LoginPage_Header.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.guna2CirclePictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000079 RID: 121
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400007A RID: 122
		private global::Guna.UI2.WinForms.Guna2CircleButton CLOSE;

		// Token: 0x0400007B RID: 123
		private global::Guna.UI2.WinForms.Guna2CircleButton MINIMIZE;

		// Token: 0x0400007C RID: 124
		private global::Guna.UI2.WinForms.Guna2Panel LoginPage_Header;

		// Token: 0x0400007D RID: 125
		private global::Guna.UI2.WinForms.Guna2ImageButton Twitter_link;

		// Token: 0x0400007E RID: 126
		private global::Guna.UI2.WinForms.Guna2ImageButton Discord_link;

		// Token: 0x0400007F RID: 127
		private global::Guna.UI2.WinForms.Guna2ImageButton Youtube_Link;

		// Token: 0x04000080 RID: 128
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;

		// Token: 0x04000081 RID: 129
		private global::System.Windows.Forms.Label GeTitle;

		// Token: 0x04000082 RID: 130
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel1;

		// Token: 0x04000083 RID: 131
		private global::Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox2;

		// Token: 0x04000084 RID: 132
		private global::Guna.UI2.WinForms.Guna2TextBox AuthKey_Input;

		// Token: 0x04000085 RID: 133
		private global::Guna.UI2.WinForms.Guna2Panel guna2Panel2;

		// Token: 0x04000086 RID: 134
		private global::Guna.UI2.WinForms.Guna2GradientButton GET_KEY_BTN;

		// Token: 0x04000087 RID: 135
		private global::Guna.UI2.WinForms.Guna2GradientButton LOGIN_BTN;

		// Token: 0x04000088 RID: 136
		private global::Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;

		// Token: 0x04000089 RID: 137
		private global::Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
	}
}
