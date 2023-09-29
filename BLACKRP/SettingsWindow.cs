using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using blackrp_launcher.Properties;

namespace blackrp_launcher
{
	public partial class SettingsWindow : Form
	{
		private void ButtonSupport_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonSupport.BackgroundImage = Resources.settings_button_support_hover;
		}

		private void ButtonSupport_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonSupport.BackgroundImage = Resources.settings_button_support;
		}

		private void ButtonReinstall_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonReinstall.BackgroundImage = Resources.settings_button_reinstall_hover;
		}

		private void ButtonReinstall_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonReinstall.BackgroundImage = Resources.settings_button_reinstall;
		}

		private void SettingsWindow_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message message = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref message);
		}

		public SettingsWindow(MainWindow Form)
		{
			this.InitializeComponent();
			this.MainForm = Form;
		}

		private void ButtonClose_Click(object sender, EventArgs e)
		{
			this.vectorChangeOpacity = false;
			this.TimerLoadWindow.Start();
		}

		private void TimerLoadWindow_Tick(object sender, EventArgs e)
		{
			this.TimerLoadWindow.Stop();
			double num = (!this.vectorChangeOpacity) ? 0.99 : 0.0;
			for (;;)
			{
				bool flag = this.vectorChangeOpacity;
				if (flag)
				{
					num += 0.12;
				}
				else
				{
					num -= 0.12;
				}
				base.Opacity = num;
				Thread.Sleep(5);
				bool flag2 = num >= 0.99 && this.vectorChangeOpacity;
				if (flag2)
				{
					break;
				}
				if (num <= 0.01 && !this.vectorChangeOpacity)
				{
					goto Block_6;
				}
			}
			base.Opacity = 0.99;
			return;
			Block_6:
			base.Opacity = 0.0;
			base.Close();
		}

		private void SettingsWindow_Load(object sender, EventArgs e)
		{
			this.vectorChangeOpacity = true;
			this.TimerLoadWindow.Start();
		}

		private void LabelSuccess_Click(object sender, EventArgs e)
		{
		
		}

		private void LinkOffert_Click(object sender, EventArgs e)
		{

		}

		private void LinkPolicy_Click(object sender, EventArgs e)
		{

		}

		private void ButtonSupport_Click(object sender, EventArgs e)
		{
		
		}

		private void ButtonLogin_Click(object sender, EventArgs e)
		{

		}

		private void ButtonReinstall_Click(object sender, EventArgs e)
		{
			bool flag = !this.MainForm._INIT_DOWNLOAD && !this.MainForm._INIT_UNPACKER;
			if (flag)
			{
				bool flag2 = Directory.Exists(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._LOCATION_GAME);
				if (flag2)
				{
					try
					{
						Directory.GetFiles(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._LOCATION_GAME, "*", SearchOption.AllDirectories).ToList<string>().ForEach(delegate(string file)
						{
							FileInfo fileInfo = new FileInfo(file);
							bool flag4 = !fileInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
							if (!flag4)
							{
								fileInfo.Attributes = FileAttributes.Normal;
							}
						});
						new DirectoryInfo(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._LOCATION_GAME).Attributes = FileAttributes.Normal;
						Directory.Delete(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._LOCATION_GAME, true);
						Directory.CreateDirectory(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._LOCATION_GAME);
					}
					catch (Exception ex)
					{
						int num = (int)MessageBox.Show(this, "Возникла ошибка при попытке очистить папку с игрой, пожалуйста, проверьте была ли игра точно закрыта и попробуйте еще раз.\n\nЕсли эта ошибка не исчезает - обратитесь в администрацию.\n\n[INFO]:\n" + ex.Message, "ОШИБКА!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				bool flag3 = File.Exists(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._FILE_GAME_ARCHIVE);
				if (flag3)
				{
					try
					{
						File.Delete(this.MainForm._CLIENT_PATH_LAUNCHER + this.MainForm._FILE_GAME_ARCHIVE);
					}
					catch
					{
						int num2 = (int)MessageBox.Show(this, "Возникла ошибка при попытке очистить папку с игрой, пожалуйста, проверьте была ли игра точно закрыта и попробуйте еще раз.\n\nЕсли эта ошибка не исчезает - обратитесь в администрацию.", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					}
				}
				this.MainForm.CheckGame("0");
				this.MainForm.ButtonDownload_Click(null, null);
				base.Close();
				base.Dispose();
			}
			else
			{
				int num3 = (int)MessageBox.Show(this, "Вы уже закачиваете игру, невозможно переустановить во время загрузки игры.\n\n\r\nЕсли эта ошибка не исчезнет - закройте и снова откройте лаунчер.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		private bool vectorChangeOpacity = true;

		private MainWindow MainForm;
	}
}
