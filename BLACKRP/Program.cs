using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Threading;
using System.Windows.Forms;

namespace blackrp_launcher
{
	internal static class Program
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			bool flag = !g__IsRunningAsAdmin();
			if (flag)
			{
				ProcessStartInfo processStartInfo = new ProcessStartInfo(Assembly.GetEntryAssembly().CodeBase);
				processStartInfo.UseShellExecute = true;
				processStartInfo.Verb = "blackrp123";
				try
				{
					Process.Start(processStartInfo);
					Application.Exit();
				}
				catch
				{
					int num = (int)MessageBox.Show(null, "Запустите лаунчер от имени администратора.\n\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				using (Mutex mutex = new Mutex(false, "BLACKRP_LAUNCHER"))
				{
					bool flag2 = mutex.WaitOne(0, false);
					if (flag2)
					{
						Application.Run(new MainWindow());
					}
					else
					{
						int num2 = (int)MessageBox.Show(null, "Лаунчер уже запущен.\n\nЗакройте процесс \"BLACKRP\" В диспечере задач(CTRL+ALT+DEL).", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						Application.Exit();
					}
				}
			}
		}

		[CompilerGenerated]
		internal static bool g__IsRunningAsAdmin()
		{
			bool result;
			try
			{
				result = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch
			{
				int num = (int)MessageBox.Show(null, "Для корректной работы лаунчере запустите от имени Администратора.\n\n", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				result = false;
			}
			return result;
		}

		private const string AppMutexName = "BLACKRP_LAUNCHER";
	}
}
