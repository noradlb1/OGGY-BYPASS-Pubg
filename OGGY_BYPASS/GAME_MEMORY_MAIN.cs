using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace OGGY_BYPASS
{
	// Token: 0x02000006 RID: 6
	public class GAME_MEMORY_MAIN : UserControl
	{
		// Token: 0x06000033 RID: 51 RVA: 0x00004987 File Offset: 0x00002B87
		public GAME_MEMORY_MAIN()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000499F File Offset: 0x00002B9F
		private void GAME_MEMORY_MAIN_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000049A4 File Offset: 0x00002BA4
		private void IPAD_ToggleSwitch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.IPAD_ToggleSwitch.Checked;
			if (@checked)
			{
				string hexString = "Track Bar Not Working yet";
				GAME_STARTER.instance.IPAD_VIEW(hexString);
				this.ACTIVATED_IPAD.Visible = true;
			}
			else
			{
				this.IPAD_ToggleSwitch.Checked = true;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000049F3 File Offset: 0x00002BF3
		private void IPAD_VIEW_SLIDER_Scroll(object sender, ScrollEventArgs e)
		{
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000049F8 File Offset: 0x00002BF8
		private void ULTRA_90fps_T_SWITCH_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.ULTRA_90fps_T_SWITCH.Checked;
			if (@checked)
			{
				GAME_STARTER.instance.ULTRA_HD_90FPS();
			}
			else
			{
				this.ULTRA_90fps_T_SWITCH.Checked = true;
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004A34 File Offset: 0x00002C34
		private void BLACK_BODY_ToggleSwitch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.BLACK_BODY_ToggleSwitch.Checked;
			if (@checked)
			{
				GAME_STARTER.instance.BLACK_BODY();
			}
			else
			{
				this.BLACK_BODY_ToggleSwitch.Checked = true;
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00004A70 File Offset: 0x00002C70
		private void NO_HEADSHOT_T_SWITCH_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.NO_HEADSHOT_T_SWITCH.Checked;
			if (@checked)
			{
				GAME_STARTER.instance.NO_HEADSHOT();
			}
			else
			{
				this.NO_HEADSHOT_T_SWITCH.Checked = true;
			}
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00004AAC File Offset: 0x00002CAC
		private void BLACK_SKY_ToggleSwitch_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.BLACK_SKY_ToggleSwitch.Checked;
			if (@checked)
			{
				GAME_STARTER.instance.BLACK_SKY();
			}
			else
			{
				this.BLACK_SKY_ToggleSwitch.Checked = true;
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004AE8 File Offset: 0x00002CE8
		private void AIM_BOT_T_SWITCH_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.AIM_BOT_T_SWITCH.Checked;
			if (@checked)
			{
				GAME_STARTER.instance.AIM_BOT();
			}
			else
			{
				this.AIM_BOT_T_SWITCH.Checked = true;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00004B24 File Offset: 0x00002D24
		private void ANTI_STREAM_T_SWITCH_CheckedChanged(object sender, EventArgs e)
		{
			bool @checked = this.ANTI_STREAM_T_SWITCH.Checked;
			if (@checked)
			{
				GAME_STARTER.instance.ANTI_STREAM();
			}
			else
			{
				this.ANTI_STREAM_T_SWITCH.Checked = true;
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004B5F File Offset: 0x00002D5F
		private void IPAD_Title_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00004B62 File Offset: 0x00002D62
		private void Memory_panel_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004B65 File Offset: 0x00002D65
		private void guna2Panel2_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00004B68 File Offset: 0x00002D68
		private void BLACK_BODY_TITLE_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00004B6B File Offset: 0x00002D6B
		private void guna2Panel4_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00004B6E File Offset: 0x00002D6E
		private void guna2Panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00004B71 File Offset: 0x00002D71
		private void label2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004B74 File Offset: 0x00002D74
		private void label4_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00004B77 File Offset: 0x00002D77
		private void BLACK_SKY_TILE_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00004B7A File Offset: 0x00002D7A
		private void label1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00004B7D File Offset: 0x00002D7D
		private void label3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004B80 File Offset: 0x00002D80
		private void guna2Panel3_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004B83 File Offset: 0x00002D83
		private void ACTIVATED_IPAD_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004B88 File Offset: 0x00002D88
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00004BC0 File Offset: 0x00002DC0
		private void InitializeComponent()
		{
            this.Memory_panel = new Guna.UI2.WinForms.Guna2Panel();
            this.ACTIVATED_IPAD = new System.Windows.Forms.Label();
            this.ANTI_STREAM_T_SWITCH = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.AIM_BOT_T_SWITCH = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.NO_HEADSHOT_T_SWITCH = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.ULTRA_90fps_T_SWITCH = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.IPAD_Title = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.BLACK_SKY_TILE = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BLACK_BODY_TITLE = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.BLACK_SKY_ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.BLACK_BODY_ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.IPAD_ToggleSwitch = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.IPAD_VIEW_SLIDER = new Guna.UI2.WinForms.Guna2TrackBar();
            this.Memory_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Memory_panel
            // 
            this.Memory_panel.Controls.Add(this.ACTIVATED_IPAD);
            this.Memory_panel.Controls.Add(this.ANTI_STREAM_T_SWITCH);
            this.Memory_panel.Controls.Add(this.AIM_BOT_T_SWITCH);
            this.Memory_panel.Controls.Add(this.NO_HEADSHOT_T_SWITCH);
            this.Memory_panel.Controls.Add(this.ULTRA_90fps_T_SWITCH);
            this.Memory_panel.Controls.Add(this.label3);
            this.Memory_panel.Controls.Add(this.label4);
            this.Memory_panel.Controls.Add(this.guna2Panel5);
            this.Memory_panel.Controls.Add(this.label1);
            this.Memory_panel.Controls.Add(this.label2);
            this.Memory_panel.Controls.Add(this.guna2Panel4);
            this.Memory_panel.Controls.Add(this.IPAD_Title);
            this.Memory_panel.Controls.Add(this.guna2Panel3);
            this.Memory_panel.Controls.Add(this.BLACK_SKY_TILE);
            this.Memory_panel.Controls.Add(this.guna2Panel1);
            this.Memory_panel.Controls.Add(this.BLACK_BODY_TITLE);
            this.Memory_panel.Controls.Add(this.guna2Panel2);
            this.Memory_panel.Controls.Add(this.BLACK_SKY_ToggleSwitch);
            this.Memory_panel.Controls.Add(this.BLACK_BODY_ToggleSwitch);
            this.Memory_panel.Controls.Add(this.IPAD_ToggleSwitch);
            this.Memory_panel.Controls.Add(this.IPAD_VIEW_SLIDER);
            this.Memory_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Memory_panel.Location = new System.Drawing.Point(0, 0);
            this.Memory_panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Memory_panel.Name = "Memory_panel";
            this.Memory_panel.Size = new System.Drawing.Size(335, 256);
            this.Memory_panel.TabIndex = 0;
            // 
            // ACTIVATED_IPAD
            // 
            this.ACTIVATED_IPAD.AutoSize = true;
            this.ACTIVATED_IPAD.BackColor = System.Drawing.Color.Transparent;
            this.ACTIVATED_IPAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACTIVATED_IPAD.ForeColor = System.Drawing.Color.SpringGreen;
            this.ACTIVATED_IPAD.Location = new System.Drawing.Point(88, 44);
            this.ACTIVATED_IPAD.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.ACTIVATED_IPAD.Name = "ACTIVATED_IPAD";
            this.ACTIVATED_IPAD.Size = new System.Drawing.Size(176, 17);
            this.ACTIVATED_IPAD.TabIndex = 76;
            this.ACTIVATED_IPAD.Text = "IPAD VIEW ACTIVATED";
            this.ACTIVATED_IPAD.Visible = false;
            // 
            // ANTI_STREAM_T_SWITCH
            // 
            this.ANTI_STREAM_T_SWITCH.BackColor = System.Drawing.Color.Transparent;
            this.ANTI_STREAM_T_SWITCH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ANTI_STREAM_T_SWITCH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ANTI_STREAM_T_SWITCH.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ANTI_STREAM_T_SWITCH.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ANTI_STREAM_T_SWITCH.Location = new System.Drawing.Point(245, 176);
            this.ANTI_STREAM_T_SWITCH.Name = "ANTI_STREAM_T_SWITCH";
            this.ANTI_STREAM_T_SWITCH.Size = new System.Drawing.Size(35, 20);
            this.ANTI_STREAM_T_SWITCH.TabIndex = 74;
            this.ANTI_STREAM_T_SWITCH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ANTI_STREAM_T_SWITCH.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ANTI_STREAM_T_SWITCH.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ANTI_STREAM_T_SWITCH.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // AIM_BOT_T_SWITCH
            // 
            this.AIM_BOT_T_SWITCH.BackColor = System.Drawing.Color.Transparent;
            this.AIM_BOT_T_SWITCH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AIM_BOT_T_SWITCH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AIM_BOT_T_SWITCH.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AIM_BOT_T_SWITCH.CheckedState.InnerColor = System.Drawing.Color.White;
            this.AIM_BOT_T_SWITCH.Location = new System.Drawing.Point(144, 176);
            this.AIM_BOT_T_SWITCH.Name = "AIM_BOT_T_SWITCH";
            this.AIM_BOT_T_SWITCH.Size = new System.Drawing.Size(35, 20);
            this.AIM_BOT_T_SWITCH.TabIndex = 73;
            this.AIM_BOT_T_SWITCH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AIM_BOT_T_SWITCH.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.AIM_BOT_T_SWITCH.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.AIM_BOT_T_SWITCH.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // NO_HEADSHOT_T_SWITCH
            // 
            this.NO_HEADSHOT_T_SWITCH.BackColor = System.Drawing.Color.Transparent;
            this.NO_HEADSHOT_T_SWITCH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NO_HEADSHOT_T_SWITCH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NO_HEADSHOT_T_SWITCH.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.NO_HEADSHOT_T_SWITCH.CheckedState.InnerColor = System.Drawing.Color.White;
            this.NO_HEADSHOT_T_SWITCH.Location = new System.Drawing.Point(245, 108);
            this.NO_HEADSHOT_T_SWITCH.Name = "NO_HEADSHOT_T_SWITCH";
            this.NO_HEADSHOT_T_SWITCH.Size = new System.Drawing.Size(35, 20);
            this.NO_HEADSHOT_T_SWITCH.TabIndex = 72;
            this.NO_HEADSHOT_T_SWITCH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NO_HEADSHOT_T_SWITCH.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.NO_HEADSHOT_T_SWITCH.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.NO_HEADSHOT_T_SWITCH.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // ULTRA_90fps_T_SWITCH
            // 
            this.ULTRA_90fps_T_SWITCH.BackColor = System.Drawing.Color.Transparent;
            this.ULTRA_90fps_T_SWITCH.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ULTRA_90fps_T_SWITCH.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ULTRA_90fps_T_SWITCH.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ULTRA_90fps_T_SWITCH.CheckedState.InnerColor = System.Drawing.Color.White;
            this.ULTRA_90fps_T_SWITCH.Location = new System.Drawing.Point(43, 108);
            this.ULTRA_90fps_T_SWITCH.Name = "ULTRA_90fps_T_SWITCH";
            this.ULTRA_90fps_T_SWITCH.Size = new System.Drawing.Size(35, 20);
            this.ULTRA_90fps_T_SWITCH.TabIndex = 71;
            this.ULTRA_90fps_T_SWITCH.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ULTRA_90fps_T_SWITCH.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.ULTRA_90fps_T_SWITCH.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.ULTRA_90fps_T_SWITCH.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Cyan;
            this.label3.Location = new System.Drawing.Point(224, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "ANTI-STREAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Cyan;
            this.label4.Location = new System.Drawing.Point(222, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "NO HEADSHOT";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.BackColor = System.Drawing.Color.Red;
            this.guna2Panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel5.Location = new System.Drawing.Point(214, 80);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.Size = new System.Drawing.Size(2, 160);
            this.guna2Panel5.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(131, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 64;
            this.label1.Text = "AIM BOT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Cyan;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 17);
            this.label2.TabIndex = 65;
            this.label2.Text = "ULTRA 90fps";
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Red;
            this.guna2Panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel4.Location = new System.Drawing.Point(112, 80);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Size = new System.Drawing.Size(2, 160);
            this.guna2Panel4.TabIndex = 61;
            // 
            // IPAD_Title
            // 
            this.IPAD_Title.AutoSize = true;
            this.IPAD_Title.BackColor = System.Drawing.Color.Transparent;
            this.IPAD_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IPAD_Title.ForeColor = System.Drawing.Color.Cyan;
            this.IPAD_Title.Location = new System.Drawing.Point(22, 15);
            this.IPAD_Title.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.IPAD_Title.Name = "IPAD_Title";
            this.IPAD_Title.Size = new System.Drawing.Size(86, 17);
            this.IPAD_Title.TabIndex = 61;
            this.IPAD_Title.Text = "IPAD VIEW";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Red;
            this.guna2Panel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel3.Location = new System.Drawing.Point(15, 167);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(298, 2);
            this.guna2Panel3.TabIndex = 60;
            // 
            // BLACK_SKY_TILE
            // 
            this.BLACK_SKY_TILE.AutoSize = true;
            this.BLACK_SKY_TILE.BackColor = System.Drawing.Color.Transparent;
            this.BLACK_SKY_TILE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLACK_SKY_TILE.ForeColor = System.Drawing.Color.Cyan;
            this.BLACK_SKY_TILE.Location = new System.Drawing.Point(22, 148);
            this.BLACK_SKY_TILE.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BLACK_SKY_TILE.Name = "BLACK_SKY_TILE";
            this.BLACK_SKY_TILE.Size = new System.Drawing.Size(92, 17);
            this.BLACK_SKY_TILE.TabIndex = 59;
            this.BLACK_SKY_TILE.Text = "BLACK SKY";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Red;
            this.guna2Panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel1.Location = new System.Drawing.Point(15, 99);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(298, 2);
            this.guna2Panel1.TabIndex = 60;
            // 
            // BLACK_BODY_TITLE
            // 
            this.BLACK_BODY_TITLE.AutoSize = true;
            this.BLACK_BODY_TITLE.BackColor = System.Drawing.Color.Transparent;
            this.BLACK_BODY_TITLE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLACK_BODY_TITLE.ForeColor = System.Drawing.Color.Cyan;
            this.BLACK_BODY_TITLE.Location = new System.Drawing.Point(122, 80);
            this.BLACK_BODY_TITLE.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.BLACK_BODY_TITLE.Name = "BLACK_BODY_TITLE";
            this.BLACK_BODY_TITLE.Size = new System.Drawing.Size(105, 17);
            this.BLACK_BODY_TITLE.TabIndex = 59;
            this.BLACK_BODY_TITLE.Text = "BLACK BODY";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Red;
            this.guna2Panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Panel2.Location = new System.Drawing.Point(15, 33);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(148, 2);
            this.guna2Panel2.TabIndex = 58;
            // 
            // BLACK_SKY_ToggleSwitch
            // 
            this.BLACK_SKY_ToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.BLACK_SKY_ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BLACK_SKY_ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BLACK_SKY_ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.BLACK_SKY_ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BLACK_SKY_ToggleSwitch.Location = new System.Drawing.Point(43, 176);
            this.BLACK_SKY_ToggleSwitch.Name = "BLACK_SKY_ToggleSwitch";
            this.BLACK_SKY_ToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.BLACK_SKY_ToggleSwitch.TabIndex = 34;
            this.BLACK_SKY_ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BLACK_SKY_ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BLACK_SKY_ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.BLACK_SKY_ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // BLACK_BODY_ToggleSwitch
            // 
            this.BLACK_BODY_ToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.BLACK_BODY_ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BLACK_BODY_ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.BLACK_BODY_ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.BLACK_BODY_ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.BLACK_BODY_ToggleSwitch.Location = new System.Drawing.Point(144, 108);
            this.BLACK_BODY_ToggleSwitch.Name = "BLACK_BODY_ToggleSwitch";
            this.BLACK_BODY_ToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.BLACK_BODY_ToggleSwitch.TabIndex = 33;
            this.BLACK_BODY_ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BLACK_BODY_ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.BLACK_BODY_ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.BLACK_BODY_ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // IPAD_ToggleSwitch
            // 
            this.IPAD_ToggleSwitch.BackColor = System.Drawing.Color.Transparent;
            this.IPAD_ToggleSwitch.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPAD_ToggleSwitch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IPAD_ToggleSwitch.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.IPAD_ToggleSwitch.CheckedState.InnerColor = System.Drawing.Color.White;
            this.IPAD_ToggleSwitch.Location = new System.Drawing.Point(25, 42);
            this.IPAD_ToggleSwitch.Name = "IPAD_ToggleSwitch";
            this.IPAD_ToggleSwitch.Size = new System.Drawing.Size(35, 20);
            this.IPAD_ToggleSwitch.TabIndex = 32;
            this.IPAD_ToggleSwitch.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IPAD_ToggleSwitch.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.IPAD_ToggleSwitch.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.IPAD_ToggleSwitch.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // IPAD_VIEW_SLIDER
            // 
            this.IPAD_VIEW_SLIDER.DisplayFocus = true;
            this.IPAD_VIEW_SLIDER.HoverState.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.IPAD_VIEW_SLIDER.IndicateFocus = true;
            this.IPAD_VIEW_SLIDER.Location = new System.Drawing.Point(79, 44);
            this.IPAD_VIEW_SLIDER.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IPAD_VIEW_SLIDER.Maximum = 169;
            this.IPAD_VIEW_SLIDER.Minimum = 167;
            this.IPAD_VIEW_SLIDER.MouseWheelBarPartitions = 1;
            this.IPAD_VIEW_SLIDER.Name = "IPAD_VIEW_SLIDER";
            this.IPAD_VIEW_SLIDER.Size = new System.Drawing.Size(225, 19);
            this.IPAD_VIEW_SLIDER.TabIndex = 1;
            this.IPAD_VIEW_SLIDER.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(113)))), ((int)(((byte)(255)))));
            this.IPAD_VIEW_SLIDER.Value = 167;
            this.IPAD_VIEW_SLIDER.Visible = false;
            // 
            // GAME_MEMORY_MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.Memory_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(335, 256);
            this.MinimumSize = new System.Drawing.Size(335, 256);
            this.Name = "GAME_MEMORY_MAIN";
            this.Size = new System.Drawing.Size(335, 256);
            this.Memory_panel.ResumeLayout(false);
            this.Memory_panel.PerformLayout();
            this.ResumeLayout(false);

		}

		// Token: 0x04000020 RID: 32
		private IContainer components = null;

		// Token: 0x04000021 RID: 33
		private Guna2Panel Memory_panel;

		// Token: 0x04000022 RID: 34
		private Guna2TrackBar IPAD_VIEW_SLIDER;

		// Token: 0x04000023 RID: 35
		private Guna2ToggleSwitch BLACK_SKY_ToggleSwitch;

		// Token: 0x04000024 RID: 36
		private Guna2ToggleSwitch BLACK_BODY_ToggleSwitch;

		// Token: 0x04000025 RID: 37
		private Guna2Panel guna2Panel3;

		// Token: 0x04000026 RID: 38
		private Label BLACK_SKY_TILE;

		// Token: 0x04000027 RID: 39
		private Guna2Panel guna2Panel1;

		// Token: 0x04000028 RID: 40
		private Guna2Panel guna2Panel2;

		// Token: 0x04000029 RID: 41
		private Guna2ToggleSwitch IPAD_ToggleSwitch;

		// Token: 0x0400002A RID: 42
		private Label IPAD_Title;

		// Token: 0x0400002B RID: 43
		private Label label3;

		// Token: 0x0400002C RID: 44
		private Label label4;

		// Token: 0x0400002D RID: 45
		private Guna2Panel guna2Panel5;

		// Token: 0x0400002E RID: 46
		private Label label1;

		// Token: 0x0400002F RID: 47
		private Label label2;

		// Token: 0x04000030 RID: 48
		private Guna2Panel guna2Panel4;

		// Token: 0x04000031 RID: 49
		private Guna2ToggleSwitch ULTRA_90fps_T_SWITCH;

		// Token: 0x04000032 RID: 50
		private Guna2ToggleSwitch NO_HEADSHOT_T_SWITCH;

		// Token: 0x04000033 RID: 51
		private Guna2ToggleSwitch AIM_BOT_T_SWITCH;

		// Token: 0x04000034 RID: 52
		private Guna2ToggleSwitch ANTI_STREAM_T_SWITCH;

		// Token: 0x04000035 RID: 53
		private Label BLACK_BODY_TITLE;

		// Token: 0x04000036 RID: 54
		private Label ACTIVATED_IPAD;

    }
}
