using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Memory;
//using OGGY_BYPASS.Properties;
using OGGY_BYPASS;

namespace OGGY_BYPASS
{
	// Token: 0x02000008 RID: 8
	public class GAME_STARTER : UserControl
	{
		// Token: 0x06000056 RID: 86 RVA: 0x00007210 File Offset: 0x00005410
		public GAME_STARTER()
		{
			this.InitializeComponent();
			GAME_STARTER.instance = this;
		}

		// Token: 0x06000057 RID: 87
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern IntPtr CreateToolhelp32Snapshot(uint flags, uint processid);

		// Token: 0x06000058 RID: 88
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int Process32First(IntPtr handle, ref GAME_STARTER.ProcessEntry32 pe);

		// Token: 0x06000059 RID: 89
		[DllImport("KERNEL32.DLL", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
		public static extern int Process32Next(IntPtr handle, ref GAME_STARTER.ProcessEntry32 pe);

		// Token: 0x0600005A RID: 90 RVA: 0x00007260 File Offset: 0x00005460
		[DebuggerStepThrough]
		//private Task PutTaskDelay(int Time)
		//{
		//	GAME_STARTER.<PutTaskDelay>d__9 <PutTaskDelay>d__ = new GAME_STARTER.<PutTaskDelay>d__9();
		//	<PutTaskDelay>d__.<>t__builder = AsyncTaskMethodBuilder.Create();
		//	<PutTaskDelay>d__.<>4__this = this;
		//	<PutTaskDelay>d__.Time = Time;
		//	<PutTaskDelay>d__.<>1__state = -1;
		//	<PutTaskDelay>d__.<>t__builder.Start<GAME_STARTER.<PutTaskDelay>d__9>(ref <PutTaskDelay>d__);
		//	return <PutTaskDelay>d__.<>t__builder.Task;
		//}

		// Token: 0x0600005B RID: 91
		[DllImport("kernel32.dll")]
		private static extern IntPtr OpenThread(GAME_STARTER.ThreadAccess dwDesiredAccess, bool bInheritHandle, uint dwThreadId);

		// Token: 0x0600005C RID: 92
		[DllImport("kernel32.dll")]
		private static extern uint SuspendThread(IntPtr hThread);

		// Token: 0x0600005D RID: 93
		[DllImport("kernel32.dll")]
		private static extern int ResumeThread(IntPtr hThread);

		// Token: 0x0600005E RID: 94 RVA: 0x000072AC File Offset: 0x000054AC
		private void GAME_STARTER_Load(object sender, EventArgs e)
		{
			this.GAME_STARTER_PANEL.BackColor = Color.FromArgb(100, 0, 0, 0);
			this.Start_Emu_Indicator.Visible = false;
			this.Start_Emu_GreenTick.Visible = false;
			this.Start_Emu_RedCross.Visible = false;
			this.EXIT_Emu_GreenTick.Visible = false;
			this.EXIT_Emu_RedCross.Visible = false;
			this.EXIT_Emu_Indicator.Visible = false;
			this.Bypass_Emu_RedCross.Visible = false;
			this.Bypass_Emu_GreenTick.Visible = false;
			this.Bypass_Emu_Indiactor.Visible = false;
			this.Game_Starting_Menu.Checked = true;
			this.Game_Starting_Menu.BackColor = Color.FromArgb(100, 0, 0, 0);
			this.Memory_Page_Switch.Checked = false;
			this.Memory_Page_Switch.BackColor = Color.FromArgb(0, 0, 0, 0);
			this.GAME_MEMORY_MAIN_PANEL.Visible = false;
			string pathDriver = "C:\\OGGY_BYPASS_MEM_DRIVER.sys";
			this.CommandLine("net stop OGGY_BYPASS_MEM_DRIVER");
			this.CommandLine("sc delete OGGY_BYPASS_MEM_DRIVER");
			//File.WriteAllBytes(pathDriver, Resources.Driver);
			this.CommandLine("sc create OGGY_BYPASS_MEM_DRIVER binPath=" + pathDriver + " start=demand type=filesys");
			this.CommandLine("net start OGGY_BYPASS_MEM_DRIVER");
			this.CommandLine("sc start OGGY_BYPASS_MEM_DRIVER");
		}

		// Token: 0x0600005F RID: 95 RVA: 0x000073F0 File Offset: 0x000055F0
		[DebuggerStepThrough]
		//private void Start_Emualtor_MainBtn_Click(object sender, EventArgs e)
		//{
		//	GAME_STARTER.<Start_Emualtor_MainBtn_Click>d__30 <Start_Emualtor_MainBtn_Click>d__ = new GAME_STARTER.<Start_Emualtor_MainBtn_Click>d__30();
		//	<Start_Emualtor_MainBtn_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<Start_Emualtor_MainBtn_Click>d__.<>4__this = this;
		//	<Start_Emualtor_MainBtn_Click>d__.sender = sender;
		//	<Start_Emualtor_MainBtn_Click>d__.e = e;
		//	<Start_Emualtor_MainBtn_Click >d__.<>1__state = -1;
		//	<Start_Emualtor_MainBtn_Click>d__.<>t__builder.Start<GAME_STARTER.<Start_Emualtor_MainBtn_Click>d__30>(ref <Start_Emualtor_MainBtn_Click>d__);
		//}

		// Token: 0x06000060 RID: 96 RVA: 0x00007438 File Offset: 0x00005638
		//[DebuggerStepThrough]
		//private void Patching_Only_Emulator()
		//{
		//	GAME_STARTER.<Patching_Only_Emulator>d__31 <Patching_Only_Emulator>d__ = new GAME_STARTER.<Patching_Only_Emulator>d__31();
		//	<Patching_Only_Emulator>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<Patching_Only_Emulator>d__.<>4__this = this;
		//	<Patching_Only_Emulator>d__.<>1__state = -1;
		//	<Patching_Only_Emulator>d__.<>t__builder.Start<GAME_STARTER.<Patching_Only_Emulator>d__31>(ref <Patching_Only_Emulator>d__);
		//}

		// Token: 0x06000061 RID: 97 RVA: 0x00007474 File Offset: 0x00005674
		private int Pid_Of_Emualtor()
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0u;
			IntPtr intPtr2 = GAME_STARTER.CreateToolhelp32Snapshot(2u, 0u);
			bool flag = (int)intPtr2 > 0;
			if (flag)
			{
				GAME_STARTER.ProcessEntry32 processEntry = default(GAME_STARTER.ProcessEntry32);
				processEntry.dwSize = (uint)Marshal.SizeOf<GAME_STARTER.ProcessEntry32>(processEntry);
				for (int num2 = GAME_STARTER.Process32First(intPtr2, ref processEntry); num2 == 1; num2 = GAME_STARTER.Process32Next(intPtr2, ref processEntry))
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
					Marshal.StructureToPtr<GAME_STARTER.ProcessEntry32>(processEntry, intPtr3, true);
					GAME_STARTER.ProcessEntry32 processEntry2 = (GAME_STARTER.ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(GAME_STARTER.ProcessEntry32));
					Marshal.FreeHGlobal(intPtr3);
					bool flag2 = processEntry2.szExeFile.Contains("AndroidEmulatorEn.exe") && processEntry2.cntThreads > num;
					if (flag2)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
					bool flag3 = processEntry2.szExeFile.Contains("AndroidEmulatorEx.exe") && processEntry2.cntThreads > num;
					if (flag3)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
				}
			}
			return (int)intPtr;
		}

		// Token: 0x06000062 RID: 98 RVA: 0x000075A4 File Offset: 0x000057A4
		private void Now_Patching(int Emu_pid)
		{
			this.MemLib.OpenProcess(Emu_pid);
			this.MemLib.WriteMemory("0x" + 4700009.ToString("X"), "bytes", "C2 08 00", "", null, true);
		}

		// Token: 0x06000063 RID: 99 RVA: 0x000075F8 File Offset: 0x000057F8
		private void Start_Emu_Indicator_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000075FB File Offset: 0x000057FB
		private void Start_Emu_GreenTick_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x000075FE File Offset: 0x000057FE
		private void Start_Emu_RedCross_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00007604 File Offset: 0x00005804
		public void CommandLine(string arg)
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				FileName = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86) + "\\cmd.exe",
				Arguments = "/c" + arg
			};
			process.Start();
			process.WaitForExit();
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00007680 File Offset: 0x00005880
		private void Bypass_Emulator_MainBtn_Click(object sender, EventArgs e)
		{
			this.Bypass_Emu_RedCross.Visible = false;
			this.Bypass_Emu_GreenTick.Visible = false;
			this.Bypass_Emu_Indiactor.Visible = true;
			bool flag = EMULATOR_SELECTOR.instance.gunaTswitch_1.Checked || EMULATOR_SELECTOR.instance.gunaTswitch_2.Checked || EMULATOR_SELECTOR.instance.gunaTswitch_3.Checked;
			if (flag)
			{
				//this.StartGame(GAME_SELECTOR.instance.version_check_btn.Text);
			}
			else
			{
				MessageBox.Show("Select The Emulator Type First!!!!", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.Bypass_Emu_Indiactor.Visible = false;
				this.Bypass_Emu_GreenTick.Visible = false;
				this.Bypass_Emu_RedCross.Visible = true;
			}
			this.Bypass_Emu_RedCross.Visible = false;
			this.Bypass_Emu_Indiactor.Visible = false;
			this.Bypass_Emu_GreenTick.Visible = true;
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000776C File Offset: 0x0000596C
		[DebuggerStepThrough]
		//private void StartGame(string version_agrument)
		//{
		//	GAME_STARTER.<StartGame>d__40 <StartGame>d__ = new GAME_STARTER.<StartGame>d__40();
		//	<StartGame>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<StartGame>d__.<>4__this = this;
		//	<StartGame>d__.version_agrument = version_agrument;
		//	<StartGame>d__.<>1__state = -1;
		//	<StartGame>d__.<>t__builder.Start<GAME_STARTER.<StartGame>d__40>(ref <StartGame>d__);
		//}

		// Token: 0x06000069 RID: 105 RVA: 0x000077AC File Offset: 0x000059AC
		private void BYPASS_FUCNTION_CONNECTOR(string ver_arg)
		{
			if (!(ver_arg == "BGMI"))
			{
				if (!(ver_arg == "GLOBAL"))
				{
					if (!(ver_arg == "KOREA"))
					{
						if (ver_arg == "VEITNAM")
						{
							int inGamePID = this.GetPid();
							//this.MAIN_BYPASS("VEITNAM", inGamePID);
						}
					}
					else
					{
						int inGamePID = this.GetPid();
						//this.MAIN_BYPASS("KOREA", inGamePID);
					}
				}
				else
				{
					int inGamePID = this.GetPid();
					//this.MAIN_BYPASS("GLOBAL", inGamePID);
				}
			}
			else
			{
				int inGamePID = this.GetPid();
				//this.MAIN_BYPASS("BGMI", inGamePID);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00007850 File Offset: 0x00005A50
		private int GetPid()
		{
			IntPtr intPtr = IntPtr.Zero;
			uint num = 0u;
			IntPtr intPtr2 = GAME_STARTER.CreateToolhelp32Snapshot(2u, 0u);
			bool flag = (int)intPtr2 > 0;
			if (flag)
			{
				GAME_STARTER.ProcessEntry32 processEntry = default(GAME_STARTER.ProcessEntry32);
				processEntry.dwSize = (uint)Marshal.SizeOf<GAME_STARTER.ProcessEntry32>(processEntry);
				for (int num2 = GAME_STARTER.Process32First(intPtr2, ref processEntry); num2 == 1; num2 = GAME_STARTER.Process32Next(intPtr2, ref processEntry))
				{
					IntPtr intPtr3 = Marshal.AllocHGlobal((int)processEntry.dwSize);
					Marshal.StructureToPtr<GAME_STARTER.ProcessEntry32>(processEntry, intPtr3, true);
					GAME_STARTER.ProcessEntry32 processEntry2 = (GAME_STARTER.ProcessEntry32)Marshal.PtrToStructure(intPtr3, typeof(GAME_STARTER.ProcessEntry32));
					Marshal.FreeHGlobal(intPtr3);
					bool flag2 = processEntry2.szExeFile.Contains("aow_exe") && processEntry2.cntThreads > num;
					if (flag2)
					{
						num = processEntry2.cntThreads;
						intPtr = (IntPtr)((long)((ulong)processEntry2.th32ProcessID));
					}
				}
			}
			return (int)intPtr;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00007944 File Offset: 0x00005B44
		[DebuggerStepThrough]
		//private void MAIN_BYPASS(string ver_agr, int pid)
		//{
		//	GAME_STARTER.<MAIN_BYPASS>d__43 <MAIN_BYPASS>d__ = new GAME_STARTER.<MAIN_BYPASS>d__43();
		//	<MAIN_BYPASS>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<MAIN_BYPASS>d__.<>4__this = this;
		//	<MAIN_BYPASS>d__.ver_agr = ver_agr;
		//	<MAIN_BYPASS>d__.pid = pid;
		//	<MAIN_BYPASS>d__.<>1__state = -1;
		//	<MAIN_BYPASS>d__.<>t__builder.Start<GAME_STARTER.<MAIN_BYPASS>d__43>(ref <MAIN_BYPASS>d__);
		//}

		// Token: 0x0600006C RID: 108 RVA: 0x0000798C File Offset: 0x00005B8C
		//[DebuggerStepThrough]
		//public void GetUE4_Header(string UnrealEngine4_header)
		//{
		//	GAME_STARTER.<GetUE4_Header>d__44 <GetUE4_Header>d__ = new GAME_STARTER.<GetUE4_Header>d__44();
		//	<GetUE4_Header>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<GetUE4_Header>d__.<>4__this = this;
		//	<GetUE4_Header>d__.UnrealEngine4_header = UnrealEngine4_header;
		//	<GetUE4_Header>d__.<>1__state = -1;
		//	<GetUE4_Header>d__.<>t__builder.Start<GAME_STARTER.<GetUE4_Header>d__44>(ref <GetUE4_Header>d__);
		//}

		// Token: 0x0600006D RID: 109 RVA: 0x000079CC File Offset: 0x00005BCC
		private void Bypass_Emu_Indiactor_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000079CF File Offset: 0x00005BCF
		private void Bypass_Emu_GreenTick_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x0600006F RID: 111 RVA: 0x000079D2 File Offset: 0x00005BD2
		private void Bypass_Emu_RedCross_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000079D8 File Offset: 0x00005BD8
		private void Safe_Exit_MainBtn_Click(object sender, EventArgs e)
		{
			this.Start_Emu_Indicator.Visible = false;
			this.Start_Emu_GreenTick.Visible = false;
			this.Start_Emu_RedCross.Visible = false;
			this.Bypass_Emu_RedCross.Visible = false;
			this.Bypass_Emu_GreenTick.Visible = false;
			this.Bypass_Emu_Indiactor.Visible = false;
			this.EXIT_Emu_GreenTick.Visible = false;
			this.EXIT_Emu_RedCross.Visible = false;
			this.EXIT_Emu_Indicator.Visible = true;
			GAME_STARTER.AllisWell = false;
			this.CommandLine("net stop OGGY_BYPASS_MEM_DRIVER");
			this.CommandLine("sc delete OGGY_BYPASS_MEM_DRIVER");
			try
			{
				foreach (Process proc in Process.GetProcessesByName("AppMarket"))
				{
					proc.Kill();
					proc.Kill();
				}
				foreach (Process proc2 in Process.GetProcessesByName("AppMarket.exe"))
				{
					proc2.Kill();
					proc2.Kill();
				}
				foreach (Process proc3 in Process.GetProcessesByName("AndroidEmulatorEx.exe"))
				{
					proc3.Kill();
					proc3.Kill();
				}
				foreach (Process proc4 in Process.GetProcessesByName("AndroidEmulatorEx"))
				{
					proc4.Kill();
					proc4.Kill();
				}
			}
			catch
			{
				this.EXIT_Emu_RedCross.Visible = false;
				this.EXIT_Emu_Indicator.Visible = false;
				this.EXIT_Emu_GreenTick.Visible = true;
				return;
			}
			this.EXIT_Emu_RedCross.Visible = false;
			this.EXIT_Emu_Indicator.Visible = false;
			this.EXIT_Emu_GreenTick.Visible = true;
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00007BB8 File Offset: 0x00005DB8
		private void EXIT_Emu_Indicator_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007BBB File Offset: 0x00005DBB
		private void EXIT_Emu_GreenTick_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00007BBE File Offset: 0x00005DBE
		private void EXIT_Emu_RedCross_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00007BC1 File Offset: 0x00005DC1
		private void GAME_STARTER_PANEL_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007BC4 File Offset: 0x00005DC4
		//[DebuggerStepThrough]
		//private void Game_Starting_Menu_Click(object sender, EventArgs e)
		//{
		//	GAME_STARTER.<Game_Starting_Menu_Click>d__53 <Game_Starting_Menu_Click>d__ = new GAME_STARTER.<Game_Starting_Menu_Click>d__53();
		//	<Game_Starting_Menu_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<Game_Starting_Menu_Click>d__.<>4__this = this;
		//	<Game_Starting_Menu_Click>d__.sender = sender;
		//	<Game_Starting_Menu_Click>d__.e = e;
		//	<Game_Starting_Menu_Click>d__.<>1__state = -1;
		//	<Game_Starting_Menu_Click>d__.<>t__builder.Start<GAME_STARTER.<Game_Starting_Menu_Click>d__53>(ref <Game_Starting_Menu_Click>d__);
		//}

		// Token: 0x06000076 RID: 118 RVA: 0x00007C0C File Offset: 0x00005E0C
		//[DebuggerStepThrough]
		//private void Memory_Page_Switch_Click(object sender, EventArgs e)
		//{
		//	GAME_STARTER.<Memory_Page_Switch_Click>d__54 <Memory_Page_Switch_Click>d__ = new GAME_STARTER.<Memory_Page_Switch_Click>d__54();
		//	<Memory_Page_Switch_Click>d__.<>t__builder = AsyncVoidMethodBuilder.Create();
		//	<Memory_Page_Switch_Click>d__.<>4__this = this;
		//	<Memory_Page_Switch_Click>d__.sender = sender;
		//	<Memory_Page_Switch_Click>d__.e = e;
		//	<Memory_Page_Switch_Click>d__.<>1__state = -1;
		//	<Memory_Page_Switch_Click>d__.<>t__builder.Start<GAME_STARTER.<Memory_Page_Switch_Click>d__54>(ref <Memory_Page_Switch_Click>d__);
		//}

		// Token: 0x06000077 RID: 119 RVA: 0x00007C54 File Offset: 0x00005E54
		public void IPAD_VIEW(string range)
		{
			this.MemLib.WriteMemory("0x" + (this.UE4_Header + 92134372L).ToString("X"), "bytes", "00 00 85 43", "", null, true);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00007CA4 File Offset: 0x00005EA4
		public void ULTRA_HD_90FPS()
		{
			this.MemLib.WriteMemory("0x" + (this.UE4_Header + 49113560L).ToString("X"), "bytes", "05 00 A0 E3 1E FF 2F E1", "", null, true);
			this.MemLib.WriteMemory("0x" + (this.UE4_Header + 49113964L).ToString("X"), "bytes", "5A 00 A0 E3 1E FF 2F E1", "", null, true);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007D34 File Offset: 0x00005F34
		public void BLACK_BODY()
		{
			MessageBox.Show("Not Available Yet", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x00007D4C File Offset: 0x00005F4C
		public void NO_HEADSHOT()
		{
			this.MemLib.WriteMemory("0x" + (this.UE4_Header + 41316460L).ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", null, true);
			this.MemLib.WriteMemory("0x" + (this.UE4_Header + 41329064L).ToString("X"), "bytes", "00 00 A0 E3 1E FF 2F E1", "", null, true);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00007DDC File Offset: 0x00005FDC
		public void BLACK_SKY()
		{
			MessageBox.Show("Not Available Yet", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00007DF4 File Offset: 0x00005FF4
		public void AIM_BOT()
		{
			this.MemLib.WriteMemory("0x" + (this.UE4_Header + 68658604L).ToString("X"), "bytes", "00 00 00 00", "", null, true);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x00007E43 File Offset: 0x00006043
		public void ANTI_STREAM()
		{
			MessageBox.Show("Not Available Yet", "OGGY_BYPASS", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00007E5C File Offset: 0x0000605C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00007E94 File Offset: 0x00006094
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(GAME_STARTER));
			this.GAME_STARTER_PANEL = new Guna2Panel();
			this.GAME_MEMORY_MAIN_PANEL = new GAME_MEMORY_MAIN();
			this.Memory_Page_Switch = new Guna2Button();
			this.guna2Panel2 = new Guna2Panel();
			this.Game_Starting_Menu = new Guna2Button();
			this.Emu_Patch_WaitingText = new Label();
			this.pid = new Label();
			this.pidConstStr = new Label();
			this.Start_Emu_GreenTick = new Guna2CirclePictureBox();
			this.EXIT_Emu_Indicator = new Guna2ProgressIndicator();
			this.EXIT_Emu_GreenTick = new Guna2CirclePictureBox();
			this.EXIT_Emu_RedCross = new Guna2CirclePictureBox();
			this.Bypass_Emu_Indiactor = new Guna2ProgressIndicator();
			this.Bypass_Emu_GreenTick = new Guna2CirclePictureBox();
			this.Bypass_Emu_RedCross = new Guna2CirclePictureBox();
			this.Start_Emu_Indicator = new Guna2ProgressIndicator();
			this.Start_Emu_RedCross = new Guna2CirclePictureBox();
			this.Safe_Exit_MainBtn = new Guna2GradientButton();
			this.Start_Emualtor_MainBtn = new Guna2GradientButton();
			this.Bypass_Emulator_MainBtn = new Guna2GradientButton();
			this.GAME_STARTER_PANEL.SuspendLayout();
			((ISupportInitialize)this.Start_Emu_GreenTick).BeginInit();
			((ISupportInitialize)this.EXIT_Emu_GreenTick).BeginInit();
			((ISupportInitialize)this.EXIT_Emu_RedCross).BeginInit();
			((ISupportInitialize)this.Bypass_Emu_GreenTick).BeginInit();
			((ISupportInitialize)this.Bypass_Emu_RedCross).BeginInit();
			((ISupportInitialize)this.Start_Emu_RedCross).BeginInit();
			base.SuspendLayout();
			this.GAME_STARTER_PANEL.Controls.Add(this.GAME_MEMORY_MAIN_PANEL);
			this.GAME_STARTER_PANEL.Controls.Add(this.Memory_Page_Switch);
			this.GAME_STARTER_PANEL.Controls.Add(this.guna2Panel2);
			this.GAME_STARTER_PANEL.Controls.Add(this.Game_Starting_Menu);
			this.GAME_STARTER_PANEL.Controls.Add(this.Emu_Patch_WaitingText);
			this.GAME_STARTER_PANEL.Controls.Add(this.pid);
			this.GAME_STARTER_PANEL.Controls.Add(this.pidConstStr);
			this.GAME_STARTER_PANEL.Controls.Add(this.Start_Emu_GreenTick);
			this.GAME_STARTER_PANEL.Controls.Add(this.EXIT_Emu_Indicator);
			this.GAME_STARTER_PANEL.Controls.Add(this.EXIT_Emu_GreenTick);
			this.GAME_STARTER_PANEL.Controls.Add(this.EXIT_Emu_RedCross);
			this.GAME_STARTER_PANEL.Controls.Add(this.Bypass_Emu_Indiactor);
			this.GAME_STARTER_PANEL.Controls.Add(this.Bypass_Emu_GreenTick);
			this.GAME_STARTER_PANEL.Controls.Add(this.Bypass_Emu_RedCross);
			this.GAME_STARTER_PANEL.Controls.Add(this.Start_Emu_Indicator);
			this.GAME_STARTER_PANEL.Controls.Add(this.Start_Emu_RedCross);
			this.GAME_STARTER_PANEL.Controls.Add(this.Safe_Exit_MainBtn);
			this.GAME_STARTER_PANEL.Controls.Add(this.Start_Emualtor_MainBtn);
			this.GAME_STARTER_PANEL.Controls.Add(this.Bypass_Emulator_MainBtn);
			this.GAME_STARTER_PANEL.Dock = DockStyle.Fill;
			this.GAME_STARTER_PANEL.Location = new Point(0, 0);
			this.GAME_STARTER_PANEL.Margin = new Padding(4);
			this.GAME_STARTER_PANEL.Name = "GAME_STARTER_PANEL";
			this.GAME_STARTER_PANEL.Size = new Size(447, 542);
			this.GAME_STARTER_PANEL.TabIndex = 0;
			this.GAME_STARTER_PANEL.Paint += this.GAME_STARTER_PANEL_Paint;
			this.GAME_MEMORY_MAIN_PANEL.BackColor = Color.Transparent;
			this.GAME_MEMORY_MAIN_PANEL.Location = new Point(3, 59);
			this.GAME_MEMORY_MAIN_PANEL.MaximumSize = new Size(447, 315);
			this.GAME_MEMORY_MAIN_PANEL.MinimumSize = new Size(447, 315);
			this.GAME_MEMORY_MAIN_PANEL.Name = "GAME_MEMORY_MAIN_PANEL";
			this.GAME_MEMORY_MAIN_PANEL.Size = new Size(447, 315);
			this.GAME_MEMORY_MAIN_PANEL.TabIndex = 59;
			this.GAME_MEMORY_MAIN_PANEL.Visible = false;
			this.Memory_Page_Switch.BackColor = Color.Transparent;
			this.Memory_Page_Switch.BorderColor = Color.Transparent;
			this.Memory_Page_Switch.BorderRadius = 5;
			this.Memory_Page_Switch.CheckedState.BorderColor = Color.Lime;
			this.Memory_Page_Switch.CheckedState.FillColor = Color.Transparent;
			this.Memory_Page_Switch.CheckedState.ForeColor = Color.Cyan;
			this.Memory_Page_Switch.DisabledState.BorderColor = Color.DarkGray;
			this.Memory_Page_Switch.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Memory_Page_Switch.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Memory_Page_Switch.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Memory_Page_Switch.FillColor = Color.Transparent;
			this.Memory_Page_Switch.Font = new Font("Cooper Black", 13.8f);
			this.Memory_Page_Switch.ForeColor = Color.FromArgb(255, 128, 0);
			this.Memory_Page_Switch.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
			this.Memory_Page_Switch.IndicateFocus = true;
			this.Memory_Page_Switch.Location = new Point(168, 6);
			this.Memory_Page_Switch.Name = "Memory_Page_Switch";
			this.Memory_Page_Switch.PressedColor = Color.Transparent;
			this.Memory_Page_Switch.PressedDepth = 90;
			this.Memory_Page_Switch.Size = new Size(163, 46);
			this.Memory_Page_Switch.TabIndex = 58;
			this.Memory_Page_Switch.Text = "MEMORY";
			//this.Memory_Page_Switch.Click += this.Memory_Page_Switch_Click;
			this.guna2Panel2.BackColor = Color.Red;
			this.guna2Panel2.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.guna2Panel2.Location = new Point(25, 52);
			this.guna2Panel2.Margin = new Padding(4);
			this.guna2Panel2.Name = "guna2Panel2";
			this.guna2Panel2.Size = new Size(397, 3);
			this.guna2Panel2.TabIndex = 57;
			this.Game_Starting_Menu.BackColor = Color.Transparent;
			this.Game_Starting_Menu.BorderColor = Color.Transparent;
			this.Game_Starting_Menu.BorderRadius = 5;
			this.Game_Starting_Menu.CheckedState.BorderColor = Color.Lime;
			this.Game_Starting_Menu.CheckedState.FillColor = Color.Transparent;
			this.Game_Starting_Menu.CheckedState.ForeColor = Color.Cyan;
			this.Game_Starting_Menu.DisabledState.BorderColor = Color.DarkGray;
			this.Game_Starting_Menu.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Game_Starting_Menu.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Game_Starting_Menu.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Game_Starting_Menu.FillColor = Color.Transparent;
			this.Game_Starting_Menu.Font = new Font("Cooper Black", 13.8f);
			this.Game_Starting_Menu.ForeColor = Color.FromArgb(255, 128, 0);
			this.Game_Starting_Menu.HoverState.BorderColor = Color.FromArgb(255, 128, 0);
			this.Game_Starting_Menu.IndicateFocus = true;
			this.Game_Starting_Menu.Location = new Point(25, 7);
			this.Game_Starting_Menu.Name = "Game_Starting_Menu";
			this.Game_Starting_Menu.PressedColor = Color.Transparent;
			this.Game_Starting_Menu.PressedDepth = 90;
			this.Game_Starting_Menu.Size = new Size(137, 46);
			this.Game_Starting_Menu.TabIndex = 56;
			this.Game_Starting_Menu.Text = "GAME";
			//this.Game_Starting_Menu.Click += this.Game_Starting_Menu_Click;
			this.Emu_Patch_WaitingText.AutoSize = true;
			this.Emu_Patch_WaitingText.Font = new Font("Sitka Text", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Emu_Patch_WaitingText.ForeColor = Color.SpringGreen;
			this.Emu_Patch_WaitingText.Location = new Point(20, 181);
			this.Emu_Patch_WaitingText.Margin = new Padding(4, 0, 4, 0);
			this.Emu_Patch_WaitingText.Name = "Emu_Patch_WaitingText";
			this.Emu_Patch_WaitingText.Size = new Size(142, 29);
			this.Emu_Patch_WaitingText.TabIndex = 55;
			this.Emu_Patch_WaitingText.Text = "Searching.....";
			this.Emu_Patch_WaitingText.Visible = false;
			this.pid.AutoSize = true;
			this.pid.Font = new Font("Sitka Text", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.pid.ForeColor = Color.SpringGreen;
			this.pid.Location = new Point(113, 330);
			this.pid.Margin = new Padding(4, 0, 4, 0);
			this.pid.Name = "pid";
			this.pid.Size = new Size(142, 29);
			this.pid.TabIndex = 54;
			this.pid.Text = "Searching.....";
			this.pid.Visible = false;
			this.pidConstStr.AutoSize = true;
			this.pidConstStr.Font = new Font("Sitka Text", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.pidConstStr.ForeColor = Color.SpringGreen;
			this.pidConstStr.Location = new Point(24, 329);
			this.pidConstStr.Margin = new Padding(4, 0, 4, 0);
			this.pidConstStr.Name = "pidConstStr";
			this.pidConstStr.Size = new Size(89, 29);
			this.pidConstStr.TabIndex = 53;
			this.pidConstStr.Text = "PID ~> ";
			this.pidConstStr.Visible = false;
			this.Start_Emu_GreenTick.BackColor = Color.Transparent;
			this.Start_Emu_GreenTick.Image = (Image)resources.GetObject("Start_Emu_GreenTick.Image");
			this.Start_Emu_GreenTick.ImageRotate = 0f;
			this.Start_Emu_GreenTick.Location = new Point(331, 90);
			this.Start_Emu_GreenTick.Margin = new Padding(4);
			this.Start_Emu_GreenTick.Name = "Start_Emu_GreenTick";
			this.Start_Emu_GreenTick.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Start_Emu_GreenTick.Size = new Size(95, 89);
			this.Start_Emu_GreenTick.SizeMode = PictureBoxSizeMode.Zoom;
			this.Start_Emu_GreenTick.TabIndex = 52;
			this.Start_Emu_GreenTick.TabStop = false;
			this.Start_Emu_GreenTick.UseTransparentBackground = true;
			this.Start_Emu_GreenTick.Visible = false;
			this.Start_Emu_GreenTick.Click += this.Start_Emu_GreenTick_Click;
			this.EXIT_Emu_Indicator.AutoStart = true;
			this.EXIT_Emu_Indicator.BackColor = Color.Transparent;
			this.EXIT_Emu_Indicator.Location = new Point(331, 393);
			this.EXIT_Emu_Indicator.Margin = new Padding(4);
			this.EXIT_Emu_Indicator.Name = "EXIT_Emu_Indicator";
			this.EXIT_Emu_Indicator.Size = new Size(95, 89);
			this.EXIT_Emu_Indicator.TabIndex = 51;
			this.EXIT_Emu_Indicator.UseTransparentBackground = true;
			this.EXIT_Emu_Indicator.Visible = false;
			this.EXIT_Emu_Indicator.Click += this.EXIT_Emu_Indicator_Click;
			this.EXIT_Emu_GreenTick.BackColor = Color.Transparent;
			this.EXIT_Emu_GreenTick.Image = (Image)resources.GetObject("EXIT_Emu_GreenTick.Image");
			this.EXIT_Emu_GreenTick.ImageRotate = 0f;
			this.EXIT_Emu_GreenTick.Location = new Point(331, 393);
			this.EXIT_Emu_GreenTick.Margin = new Padding(4);
			this.EXIT_Emu_GreenTick.Name = "EXIT_Emu_GreenTick";
			this.EXIT_Emu_GreenTick.ShadowDecoration.Mode = ShadowMode.Circle;
			this.EXIT_Emu_GreenTick.Size = new Size(95, 89);
			this.EXIT_Emu_GreenTick.SizeMode = PictureBoxSizeMode.Zoom;
			this.EXIT_Emu_GreenTick.TabIndex = 50;
			this.EXIT_Emu_GreenTick.TabStop = false;
			this.EXIT_Emu_GreenTick.UseTransparentBackground = true;
			this.EXIT_Emu_GreenTick.Visible = false;
			this.EXIT_Emu_GreenTick.Click += this.EXIT_Emu_GreenTick_Click;
			this.EXIT_Emu_RedCross.BackColor = Color.Transparent;
			this.EXIT_Emu_RedCross.Image = (Image)resources.GetObject("EXIT_Emu_RedCross.Image");
			this.EXIT_Emu_RedCross.ImageRotate = 0f;
			this.EXIT_Emu_RedCross.Location = new Point(331, 393);
			this.EXIT_Emu_RedCross.Margin = new Padding(4);
			this.EXIT_Emu_RedCross.Name = "EXIT_Emu_RedCross";
			this.EXIT_Emu_RedCross.ShadowDecoration.Mode = ShadowMode.Circle;
			this.EXIT_Emu_RedCross.Size = new Size(95, 89);
			this.EXIT_Emu_RedCross.SizeMode = PictureBoxSizeMode.Zoom;
			this.EXIT_Emu_RedCross.TabIndex = 49;
			this.EXIT_Emu_RedCross.TabStop = false;
			this.EXIT_Emu_RedCross.UseTransparentBackground = true;
			this.EXIT_Emu_RedCross.Visible = false;
			this.EXIT_Emu_RedCross.Click += this.EXIT_Emu_RedCross_Click;
			this.Bypass_Emu_Indiactor.AutoStart = true;
			this.Bypass_Emu_Indiactor.BackColor = Color.Transparent;
			this.Bypass_Emu_Indiactor.Location = new Point(331, 238);
			this.Bypass_Emu_Indiactor.Margin = new Padding(4);
			this.Bypass_Emu_Indiactor.Name = "Bypass_Emu_Indiactor";
			this.Bypass_Emu_Indiactor.Size = new Size(95, 89);
			this.Bypass_Emu_Indiactor.TabIndex = 48;
			this.Bypass_Emu_Indiactor.UseTransparentBackground = true;
			this.Bypass_Emu_Indiactor.Visible = false;
			this.Bypass_Emu_Indiactor.Click += this.Bypass_Emu_Indiactor_Click;
			this.Bypass_Emu_GreenTick.BackColor = Color.Transparent;
			this.Bypass_Emu_GreenTick.Image = (Image)resources.GetObject("Bypass_Emu_GreenTick.Image");
			this.Bypass_Emu_GreenTick.ImageRotate = 0f;
			this.Bypass_Emu_GreenTick.Location = new Point(331, 238);
			this.Bypass_Emu_GreenTick.Margin = new Padding(4);
			this.Bypass_Emu_GreenTick.Name = "Bypass_Emu_GreenTick";
			this.Bypass_Emu_GreenTick.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Bypass_Emu_GreenTick.Size = new Size(95, 89);
			this.Bypass_Emu_GreenTick.SizeMode = PictureBoxSizeMode.Zoom;
			this.Bypass_Emu_GreenTick.TabIndex = 47;
			this.Bypass_Emu_GreenTick.TabStop = false;
			this.Bypass_Emu_GreenTick.UseTransparentBackground = true;
			this.Bypass_Emu_GreenTick.Visible = false;
			this.Bypass_Emu_GreenTick.Click += this.Bypass_Emu_GreenTick_Click;
			this.Bypass_Emu_RedCross.BackColor = Color.Transparent;
			this.Bypass_Emu_RedCross.Image = (Image)resources.GetObject("Bypass_Emu_RedCross.Image");
			this.Bypass_Emu_RedCross.ImageRotate = 0f;
			this.Bypass_Emu_RedCross.Location = new Point(331, 238);
			this.Bypass_Emu_RedCross.Margin = new Padding(4);
			this.Bypass_Emu_RedCross.Name = "Bypass_Emu_RedCross";
			this.Bypass_Emu_RedCross.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Bypass_Emu_RedCross.Size = new Size(95, 89);
			this.Bypass_Emu_RedCross.SizeMode = PictureBoxSizeMode.Zoom;
			this.Bypass_Emu_RedCross.TabIndex = 46;
			this.Bypass_Emu_RedCross.TabStop = false;
			this.Bypass_Emu_RedCross.UseTransparentBackground = true;
			this.Bypass_Emu_RedCross.Visible = false;
			this.Bypass_Emu_RedCross.Click += this.Bypass_Emu_RedCross_Click;
			this.Start_Emu_Indicator.AutoStart = true;
			this.Start_Emu_Indicator.BackColor = Color.Transparent;
			this.Start_Emu_Indicator.Location = new Point(331, 90);
			this.Start_Emu_Indicator.Margin = new Padding(4);
			this.Start_Emu_Indicator.Name = "Start_Emu_Indicator";
			this.Start_Emu_Indicator.Size = new Size(95, 89);
			this.Start_Emu_Indicator.TabIndex = 45;
			this.Start_Emu_Indicator.UseTransparentBackground = true;
			this.Start_Emu_Indicator.Visible = false;
			this.Start_Emu_Indicator.Click += this.Start_Emu_Indicator_Click;
			this.Start_Emu_RedCross.BackColor = Color.Transparent;
			this.Start_Emu_RedCross.Image = (Image)resources.GetObject("Start_Emu_RedCross.Image");
			this.Start_Emu_RedCross.ImageRotate = 0f;
			this.Start_Emu_RedCross.Location = new Point(331, 90);
			this.Start_Emu_RedCross.Margin = new Padding(4);
			this.Start_Emu_RedCross.Name = "Start_Emu_RedCross";
			this.Start_Emu_RedCross.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Start_Emu_RedCross.Size = new Size(95, 89);
			this.Start_Emu_RedCross.SizeMode = PictureBoxSizeMode.Zoom;
			this.Start_Emu_RedCross.TabIndex = 43;
			this.Start_Emu_RedCross.TabStop = false;
			this.Start_Emu_RedCross.UseTransparentBackground = true;
			this.Start_Emu_RedCross.Visible = false;
			this.Start_Emu_RedCross.Click += this.Start_Emu_RedCross_Click;
			this.Safe_Exit_MainBtn.BackColor = Color.Transparent;
			this.Safe_Exit_MainBtn.BorderColor = Color.Lime;
			this.Safe_Exit_MainBtn.BorderRadius = 20;
			this.Safe_Exit_MainBtn.BorderThickness = 2;
			this.Safe_Exit_MainBtn.DisabledState.BorderColor = Color.DarkGray;
			this.Safe_Exit_MainBtn.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Safe_Exit_MainBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Safe_Exit_MainBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			this.Safe_Exit_MainBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Safe_Exit_MainBtn.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
			this.Safe_Exit_MainBtn.ForeColor = Color.White;
			this.Safe_Exit_MainBtn.GradientMode = LinearGradientMode.ForwardDiagonal;
			this.Safe_Exit_MainBtn.HoverState.BorderColor = Color.Cyan;
			this.Safe_Exit_MainBtn.Location = new Point(20, 393);
			this.Safe_Exit_MainBtn.Margin = new Padding(27, 25, 27, 25);
			this.Safe_Exit_MainBtn.Name = "Safe_Exit_MainBtn";
			this.Safe_Exit_MainBtn.Padding = new Padding(7, 6, 7, 6);
			this.Safe_Exit_MainBtn.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Safe_Exit_MainBtn.Size = new Size(300, 89);
			this.Safe_Exit_MainBtn.TabIndex = 42;
			this.Safe_Exit_MainBtn.Text = "SAFE EXIT";
			this.Safe_Exit_MainBtn.UseTransparentBackground = true;
			this.Safe_Exit_MainBtn.Click += this.Safe_Exit_MainBtn_Click;
			this.Start_Emualtor_MainBtn.BackColor = Color.Transparent;
			this.Start_Emualtor_MainBtn.BorderColor = Color.Lime;
			this.Start_Emualtor_MainBtn.BorderRadius = 20;
			this.Start_Emualtor_MainBtn.BorderThickness = 2;
			this.Start_Emualtor_MainBtn.DisabledState.BorderColor = Color.DarkGray;
			this.Start_Emualtor_MainBtn.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Start_Emualtor_MainBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Start_Emualtor_MainBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			this.Start_Emualtor_MainBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Start_Emualtor_MainBtn.Font = new Font("Times New Roman", 15.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.Start_Emualtor_MainBtn.ForeColor = Color.White;
			this.Start_Emualtor_MainBtn.GradientMode = LinearGradientMode.ForwardDiagonal;
			this.Start_Emualtor_MainBtn.HoverState.BorderColor = Color.Cyan;
			this.Start_Emualtor_MainBtn.Location = new Point(20, 90);
			this.Start_Emualtor_MainBtn.Margin = new Padding(27, 25, 27, 25);
			this.Start_Emualtor_MainBtn.Name = "Start_Emualtor_MainBtn";
			this.Start_Emualtor_MainBtn.Padding = new Padding(7, 6, 7, 6);
			this.Start_Emualtor_MainBtn.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Start_Emualtor_MainBtn.Size = new Size(300, 89);
			this.Start_Emualtor_MainBtn.TabIndex = 41;
			this.Start_Emualtor_MainBtn.Text = "START EMUALTOR";
			this.Start_Emualtor_MainBtn.UseTransparentBackground = true;
			//this.Start_Emualtor_MainBtn.Click += this.Start_Emualtor_MainBtn_Click;
			this.Bypass_Emulator_MainBtn.BackColor = Color.Transparent;
			this.Bypass_Emulator_MainBtn.BorderColor = Color.Lime;
			this.Bypass_Emulator_MainBtn.BorderRadius = 20;
			this.Bypass_Emulator_MainBtn.BorderThickness = 2;
			this.Bypass_Emulator_MainBtn.DisabledState.BorderColor = Color.DarkGray;
			this.Bypass_Emulator_MainBtn.DisabledState.CustomBorderColor = Color.DarkGray;
			this.Bypass_Emulator_MainBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
			this.Bypass_Emulator_MainBtn.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
			this.Bypass_Emulator_MainBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
			this.Bypass_Emulator_MainBtn.Font = new Font("Segoe UI", 18f, FontStyle.Bold);
			this.Bypass_Emulator_MainBtn.ForeColor = Color.White;
			this.Bypass_Emulator_MainBtn.GradientMode = LinearGradientMode.ForwardDiagonal;
			this.Bypass_Emulator_MainBtn.HoverState.BorderColor = Color.Cyan;
			this.Bypass_Emulator_MainBtn.Location = new Point(20, 238);
			this.Bypass_Emulator_MainBtn.Margin = new Padding(27, 25, 27, 25);
			this.Bypass_Emulator_MainBtn.Name = "Bypass_Emulator_MainBtn";
			this.Bypass_Emulator_MainBtn.Padding = new Padding(7, 6, 7, 6);
			this.Bypass_Emulator_MainBtn.ShadowDecoration.Mode = ShadowMode.Circle;
			this.Bypass_Emulator_MainBtn.Size = new Size(300, 89);
			this.Bypass_Emulator_MainBtn.TabIndex = 40;
			this.Bypass_Emulator_MainBtn.Text = "BYPASS";
			this.Bypass_Emulator_MainBtn.UseTransparentBackground = true;
			this.Bypass_Emulator_MainBtn.Click += this.Bypass_Emulator_MainBtn_Click;
			base.AutoScaleDimensions = new SizeF(8f, 16f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.GAME_STARTER_PANEL);
			base.Margin = new Padding(4);
			base.Name = "GAME_STARTER";
			base.Size = new Size(447, 542);
			base.Load += this.GAME_STARTER_Load;
			this.GAME_STARTER_PANEL.ResumeLayout(false);
			this.GAME_STARTER_PANEL.PerformLayout();
			((ISupportInitialize)this.Start_Emu_GreenTick).EndInit();
			((ISupportInitialize)this.EXIT_Emu_GreenTick).EndInit();
			((ISupportInitialize)this.EXIT_Emu_RedCross).EndInit();
			((ISupportInitialize)this.Bypass_Emu_GreenTick).EndInit();
			((ISupportInitialize)this.Bypass_Emu_RedCross).EndInit();
			((ISupportInitialize)this.Start_Emu_RedCross).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000046 RID: 70
		public static GAME_STARTER instance;

		// Token: 0x04000047 RID: 71
		public static bool check = true;

		// Token: 0x04000048 RID: 72
		public string EMULATOR_PATH;

		// Token: 0x04000049 RID: 73
		public int check_pid = 9999;

		// Token: 0x0400004A RID: 74
		public long UE4_Header;

		// Token: 0x0400004B RID: 75
		private string sr;

		// Token: 0x0400004C RID: 76
		public long enumerable = 0L;

		// Token: 0x0400004D RID: 77
		private int x;

		// Token: 0x0400004E RID: 78
		public Mem MemLib = new Mem();

		// Token: 0x0400004F RID: 79
		private static string string_0;

		// Token: 0x04000050 RID: 80
		private static string string_1;

		// Token: 0x04000051 RID: 81
		private static string string_2;

		// Token: 0x04000052 RID: 82
		private static string string_3;

		// Token: 0x04000053 RID: 83
		private static string string_4;

		// Token: 0x04000054 RID: 84
		private static string string_5;

		// Token: 0x04000055 RID: 85
		private static string string_6;

		// Token: 0x04000056 RID: 86
		private IContainer icontainer_0;

		// Token: 0x04000057 RID: 87
		private int timer = 0;

		// Token: 0x04000058 RID: 88
		public static bool AllisWell = false;

		// Token: 0x04000059 RID: 89
		private IContainer components = null;

		// Token: 0x0400005A RID: 90
		private Guna2Panel GAME_STARTER_PANEL;

		// Token: 0x0400005B RID: 91
		private Guna2ProgressIndicator EXIT_Emu_Indicator;

		// Token: 0x0400005C RID: 92
		private Guna2CirclePictureBox EXIT_Emu_GreenTick;

		// Token: 0x0400005D RID: 93
		private Guna2CirclePictureBox EXIT_Emu_RedCross;

		// Token: 0x0400005E RID: 94
		private Guna2ProgressIndicator Bypass_Emu_Indiactor;

		// Token: 0x0400005F RID: 95
		private Guna2CirclePictureBox Bypass_Emu_GreenTick;

		// Token: 0x04000060 RID: 96
		private Guna2CirclePictureBox Bypass_Emu_RedCross;

		// Token: 0x04000061 RID: 97
		private Guna2ProgressIndicator Start_Emu_Indicator;

		// Token: 0x04000062 RID: 98
		private Guna2CirclePictureBox Start_Emu_RedCross;

		// Token: 0x04000063 RID: 99
		private Guna2GradientButton Safe_Exit_MainBtn;

		// Token: 0x04000064 RID: 100
		private Guna2GradientButton Start_Emualtor_MainBtn;

		// Token: 0x04000065 RID: 101
		private Guna2GradientButton Bypass_Emulator_MainBtn;

		// Token: 0x04000066 RID: 102
		private Guna2CirclePictureBox Start_Emu_GreenTick;

		// Token: 0x04000067 RID: 103
		private Label pid;

		// Token: 0x04000068 RID: 104
		private Label pidConstStr;

		// Token: 0x04000069 RID: 105
		private Label Emu_Patch_WaitingText;

		// Token: 0x0400006A RID: 106
		private Guna2Button Game_Starting_Menu;

		// Token: 0x0400006B RID: 107
		private Guna2Panel guna2Panel2;

		// Token: 0x0400006C RID: 108
		private Guna2Button Memory_Page_Switch;

		// Token: 0x0400006D RID: 109
		private GAME_MEMORY_MAIN GAME_MEMORY_MAIN_PANEL;
        private bool t__builder;

        // Token: 0x02000018 RID: 24
        public struct ProcessEntry32
		{
			// Token: 0x040000E3 RID: 227
			public uint dwSize;

			// Token: 0x040000E4 RID: 228
			public uint cntUsage;

			// Token: 0x040000E5 RID: 229
			public uint th32ProcessID;

			// Token: 0x040000E6 RID: 230
			public IntPtr th32DefaultHeapID;

			// Token: 0x040000E7 RID: 231
			public uint th32ModuleID;

			// Token: 0x040000E8 RID: 232
			public uint cntThreads;

			// Token: 0x040000E9 RID: 233
			public uint th32ParentProcessID;

			// Token: 0x040000EA RID: 234
			public int pcPriClassBase;

			// Token: 0x040000EB RID: 235
			public uint dwFlags;

			// Token: 0x040000EC RID: 236
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		// Token: 0x02000019 RID: 25
		public struct ProcessEntry64
		{
			// Token: 0x040000ED RID: 237
			public uint dwSize;

			// Token: 0x040000EE RID: 238
			public uint cntUsage;

			// Token: 0x040000EF RID: 239
			public uint th64ProcessID;

			// Token: 0x040000F0 RID: 240
			public IntPtr th32DefaultHeapID;

			// Token: 0x040000F1 RID: 241
			public uint th64ModuleID;

			// Token: 0x040000F2 RID: 242
			public uint cntThreads;

			// Token: 0x040000F3 RID: 243
			public uint th64ParentProcessID;

			// Token: 0x040000F4 RID: 244
			public int pcPriClassBase;

			// Token: 0x040000F5 RID: 245
			public uint dwFlags;

			// Token: 0x040000F6 RID: 246
			[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
			public string szExeFile;
		}

		// Token: 0x0200001A RID: 26
		[Flags]
		public enum ThreadAccess
		{
			// Token: 0x040000F8 RID: 248
			TERMINATE = 1,
			// Token: 0x040000F9 RID: 249
			SUSPEND_RESUME = 2,
			// Token: 0x040000FA RID: 250
			GET_CONTEXT = 8,
			// Token: 0x040000FB RID: 251
			SET_CONTEXT = 16,
			// Token: 0x040000FC RID: 252
			SET_INFORMATION = 32,
			// Token: 0x040000FD RID: 253
			QUERY_INFORMATION = 64,
			// Token: 0x040000FE RID: 254
			SET_THREAD_TOKEN = 128,
			// Token: 0x040000FF RID: 255
			IMPERSONATE = 256,
			// Token: 0x04000100 RID: 256
			DIRECT_IMPERSONATION = 512
		}
	}
}
