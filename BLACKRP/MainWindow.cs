using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using blackrp_launcher.Properties;
using Microsoft.Win32;
using Newtonsoft.Json.Linq;
using WebSocketSharp;

namespace blackrp_launcher
{
	public partial class MainWindow : Form
	{
		private void ButtonOpenCabinet_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonOpenCabinet_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonOpenDonate_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonOpenDonate_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonOpenForum_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonOpenForum_MouseLeave(object sender, EventArgs e)
		{
		}

		private void ButtonOpenSite_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonOpenSite_MouseLeave(object sender, EventArgs e)
		{
		}

		private void News1_MouseEnter(object sender, EventArgs e)
		{
			this.News1.BackgroundImage = this._NEWS1_HOVER;
		}

		private void News1_MouseLeave(object sender, EventArgs e)
		{
			this.News1.BackgroundImage = this._NEWS1_MAIN;
		}

		private void News2_MouseEnter(object sender, EventArgs e)
		{
			this.News2.BackgroundImage = this._NEWS2_HOVER;
		}

		private void News2_MouseLeave(object sender, EventArgs e)
		{
			this.News2.BackgroundImage = this._NEWS2_MAIN;
		}

		private void News3_MouseEnter(object sender, EventArgs e)
		{
			this.News3.BackgroundImage = this._NEWS3_HOVER;
		}

		private void News3_MouseLeave(object sender, EventArgs e)
		{
			this.News3.BackgroundImage = this._NEWS3_MAIN;
		}

		private void ButtonDownload_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonDownload.BackgroundImage = Resources.button_download_hover;
		}

		private void ButtonDownload_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonDownload.BackgroundImage = this._BUTTON_DOWNLOAD;
		}

		private void ButtonPlay_MouseEnter(object sender, EventArgs e)
		{
		}

		private void ButtonPlay_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonPlay.BackgroundImage = this._BUTTON_PLAY;
		}

		private void ButtonDiscord_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonDiscord.BackgroundImage = Resources.icon_discord_hover;
		}

		private void ButtonDiscord_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonDiscord.BackgroundImage = Resources.icon_discord;
		}

		private void ButtonInstagram_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonInstagram.BackgroundImage = Resources.icon_instagram_hover;
		}

		private void ButtonInstagram_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonInstagram.BackgroundImage = Resources.icon_instagram;
		}

		private void ButtonYoutube_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonYoutube.BackgroundImage = Resources.icon_youtube_hover;
		}

		private void ButtonYoutube_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonYoutube.BackgroundImage = Resources.icon_youtube;
		}

		private void ButtonTelegram_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonTelegram.BackgroundImage = Resources.icon_telegram_hover;
		}

		private void ButtonTelegram_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonTelegram.BackgroundImage = Resources.icon_telegram;
		}

		private void ButtonTiktok_MouseEnter(object sender, EventArgs e)
		{
			this.ButtonTiktok.BackgroundImage = Resources.icon_tiktok_hover;
		}

		private void ButtonTiktok_MouseLeave(object sender, EventArgs e)
		{
			this.ButtonTiktok.BackgroundImage = Resources.icon_tiktok;
		}

		private void ButtonServer1_MouseEnter(object sender, EventArgs e)
		{
			bool flag = this._CLIENT_SELECTED_SERVER != 1;
			if (flag)
			{
				this.ButtonServer1.BackgroundImage = Resources.button_server_1st_hover;
			}
		}

		private void ButtonServer1_MouseLeave(object sender, EventArgs e)
		{
			bool flag = this._CLIENT_SELECTED_SERVER == 1;
			if (flag)
			{
				this.ButtonServer1.BackgroundImage = Resources.button_server_1st_active;
			}
			else
			{
				this.ButtonServer1.BackgroundImage = Resources.button_server_1st;
			}
		}

		private void ButtonServer2_MouseEnter(object sender, EventArgs e)
		{
			bool flag = this._CLIENT_SELECTED_SERVER != 2;
			if (flag)
			{
				this.ButtonServer2.BackgroundImage = Resources.button_server_2nd_hover;
			}
		}

		private void ButtonServer2_MouseLeave(object sender, EventArgs e)
		{
			bool flag = this._CLIENT_SELECTED_SERVER == 2;
			if (flag)
			{
				this.ButtonServer2.BackgroundImage = Resources.button_server_2nd_active;
			}
			else
			{
				this.ButtonServer2.BackgroundImage = Resources.button_server_2nd;
			}
		}

		private void ButtonServer3_MouseEnter(object sender, EventArgs e)
		{
			bool flag = this._CLIENT_SELECTED_SERVER != 3;
			if (flag)
			{
				this.ButtonServer3.BackgroundImage = Resources.button_server_test_hover;
			}
		}

		private void ButtonServer3_MouseLeave(object sender, EventArgs e)
		{
			bool flag = this._CLIENT_SELECTED_SERVER == 3;
			if (flag)
			{
				this.ButtonServer3.BackgroundImage = Resources.button_server_test_active;
			}
			else
			{
				this.ButtonServer3.BackgroundImage = Resources.button_server_test;
			}
		}

		private void MainWindow_MouseDown(object sender, MouseEventArgs e)
		{
			base.Capture = false;
			Message message = Message.Create(base.Handle, 161, new IntPtr(2), IntPtr.Zero);
			this.WndProc(ref message);
		}

		private void ButtonCloseApp_Click(object sender, EventArgs e)
		{
			this._WINDOW_VECTOR_OPACITY = false;
			this.TimerLoadWindow.Start();
		}

		private void ButtonMinimizeApp_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		private void ButtonOpenSettings_Click(object sender, EventArgs e)
		{
			new SettingsWindow(this).ShowDialog();
		}

		private void ButtonOpenCabinet_Click(object sender, EventArgs e)
		{
		
		}

		private void ButtonOpenDonate_Click(object sender, EventArgs e)
		{
		
		}

		private void ButtonOpenForum_Click(object sender, EventArgs e)
		{

		}

		private void ButtonOpenSite_Click(object sender, EventArgs e)
		{

		}

		private void News1_Click(object sender, EventArgs e)
		{
			Process.Start(this._LAUNCHER_NEWS1_LINK);
		}

		private void News2_Click(object sender, EventArgs e)
		{
			Process.Start(this._LAUNCHER_NEWS2_LINK);
		}

		private void News3_Click(object sender, EventArgs e)
		{
			Process.Start(this._LAUNCHER_NEWS3_LINK);
		}

		private void ButtonDiscord_Click(object sender, EventArgs e)
		{
			Process.Start("");
		}

		private void ButtonInstagram_Click(object sender, EventArgs e)
		{
			Process.Start("");
		}

		private void ButtonYoutube_Click(object sender, EventArgs e)
		{
			Process.Start("");
		}

		private void ButtonTelegram_Click(object sender, EventArgs e)
		{
			Process.Start("https://vk.com/blackrpmta");
		}

		private void ButtonTiktok_Click(object sender, EventArgs e)
		{
			Process.Start("https://discord.gg/N67PnVRS");
		}

		private void SetProgressLoadingBar(int progress)
		{
			int width = (int)Math.Round(438.0 * (Convert.ToDouble(progress) / 100.0));
			this.LoadingBar.Width = width;
			this.LabelPercent.Text = progress.ToString() + "%";
		}

		private void SelectSeverInWindow(int numberServer = 0)
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\BRP\\1.6\\connect", true);
			string text = "1";
			bool flag = numberServer == 0;
			if (flag)
			{
				try
				{
					bool flag2 = File.Exists(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT);
					if (flag2)
					{
						using (StreamReader streamReader = new StreamReader(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT))
						{
							text = streamReader.ReadLine();
						}
						bool flag3 = !(text != "1") || !(text != "2") || !(text != "3");
						if (flag3)
						{
							goto IL_113;
						}
						text = "1";
						using (StreamWriter streamWriter = File.CreateText(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT))
						{
							streamWriter.Write(text);
							goto IL_113;
						}
					}
					using (StreamWriter streamWriter2 = File.CreateText(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT))
					{
						streamWriter2.Write(text);
					}
					IL_113:;
				}
				catch
				{
					text = "1";
				}
			}
			this._CLIENT_SELECTED_SERVER = int.Parse(text);
			int client_SELECTED_SERVER = this._CLIENT_SELECTED_SERVER;
			bool flag4 = client_SELECTED_SERVER == 2;
			if (flag4)
			{
				this._CLIENT_SELECTED_SERVER_ADDR = "";
				bool flag5 = registryKey != null;
				if (flag5)
				{
					registryKey.SetValue("ip", "37.230.162.235", RegistryValueKind.String);
				}
				this.ButtonServer2.BackgroundImage = Resources.button_server_2nd_active;
			}
			else
			{
				bool flag6 = client_SELECTED_SERVER != 3;
				if (flag6)
				{
					this._CLIENT_SELECTED_SERVER_ADDR = "46.174.55.71";
					bool flag7 = registryKey != null;
					if (flag7)
					{
						registryKey.SetValue("ip", "46.174.55.71", RegistryValueKind.String);
					}
					this.ButtonServer1.BackgroundImage = Resources.button_server_1st_active;
				}
				else
				{
					this._CLIENT_SELECTED_SERVER_ADDR = "37.230.162.235";
					bool flag8 = registryKey != null;
					if (flag8)
					{
						registryKey.SetValue("ip", "37.230.162.235", RegistryValueKind.String);
					}
					this.ButtonServer3.BackgroundImage = Resources.button_server_test_active;
				}
			}
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000310C File Offset: 0x0000130C
		private void MakeOtherDesignTrash()
		{
			this.LabelVersion.Text = this._LAUNCHER_VERSION;
			this._BUTTON_DOWNLOAD = Resources.button_download;
			this._BUTTON_PLAY = Resources.button_play;
			this.LabelGUID.Text = this._CLIENT_ID;
			Point point = base.PointToScreen(this.OrangeDotServer1.Location);
			point = this.ButtonServer1.PointToClient(point);
			this.OrangeDotServer1.Parent = this.ButtonServer1;
			this.OrangeDotServer1.Location = point;
			Point point2 = base.PointToScreen(this.LabelServer1Online.Location);
			point2 = this.ButtonServer1.PointToClient(point2);
			this.LabelServer1Online.Parent = this.ButtonServer1;
			this.LabelServer1Online.Location = point2;
			Point point3 = base.PointToScreen(this.OrangeDotServer2.Location);
			point3 = this.ButtonServer2.PointToClient(point3);
			this.OrangeDotServer2.Parent = this.ButtonServer2;
			this.OrangeDotServer2.Location = point3;
			Point point4 = base.PointToScreen(this.LabelServer2Online.Location);
			point4 = this.ButtonServer2.PointToClient(point4);
			this.LabelServer2Online.Parent = this.ButtonServer2;
			this.LabelServer2Online.Location = point4;
			Point point5 = base.PointToScreen(this.OrangeDotServer3.Location);
			point5 = this.ButtonServer3.PointToClient(point5);
			this.OrangeDotServer3.Parent = this.ButtonServer3;
			this.OrangeDotServer3.Location = point5;
			Point point6 = base.PointToScreen(this.LabelServer3Online.Location);
			point6 = this.ButtonServer3.PointToClient(point6);
			this.LabelServer3Online.Parent = this.ButtonServer3;
			this.LabelServer3Online.Location = point6;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000032D0 File Offset: 0x000014D0
		public MainWindow()
		{
			this._CLIENT_PATH_LAUNCHER = Path.GetDirectoryName(Assembly.GetExecutingAssembly().GetName().CodeBase).Substring(6);
			this._CLIENT_ID = MainWindow.GetClientID();
			this._CLIENT_OS = MainWindow.GetClientFriendlyOSName();
			string text = "ws://194.93.2.220:59152";
			bool flag = text.Contains("ws://");
			if (flag)
			{
				this._LAUNCHER_WS_ADDRESS = text;
			}
			text = string.Empty;
			MainWindow._WEB_SOCKET = new WebSocket(this._LAUNCHER_WS_ADDRESS, Array.Empty<string>());
			bool flag2 = !Directory.Exists(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME);
			if (flag2)
			{
				Directory.CreateDirectory(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME);
			}
			bool flag3 = !Directory.Exists(this._CLIENT_PATH_LAUNCHER + this._LOCATION_DOWNLOAD);
			if (flag3)
			{
				Directory.CreateDirectory(this._CLIENT_PATH_LAUNCHER + this._LOCATION_DOWNLOAD);
			}
			bool flag4 = !Directory.Exists(this._CLIENT_PATH_LAUNCHER + this._LOCATION_NEWS);
			if (flag4)
			{
				Directory.CreateDirectory(this._CLIENT_PATH_LAUNCHER + this._LOCATION_NEWS);
			}
			this.InitializeComponent();
			this.MakeOtherDesignTrash();
			this.SelectSeverInWindow(0);
			base.Enabled = false;
			this._WEB_SOCKET_CONNECTED = false;
			this.WebSocketClient(MainWindow._WEB_SOCKET, this);
		}

		private void WebSocketClient(WebSocket WS, MainWindow MainForm)
		{
			try
			{
				WS.EnableRedirection = true;
				WS.WaitTime = TimeSpan.FromSeconds(5.0);
				int DisconnectCount = 0;
				bool haveError = false;
				WS.OnMessage += delegate(object sender, MessageEventArgs msg)
				{
					this._WEB_SOCKET_CONNECTED = true;
					DisconnectCount = 0;
					JObject message = JObject.Parse(msg.Data);
					StringBuilder stringBuilder = new StringBuilder();
					bool flag = message["response"] != null && message["response"].ToString() == "error";
					if (flag)
					{
						haveError = true;
						Task.Run(delegate()
						{
							Control mainForm2 = MainForm;
							MethodInvoker method9;
							bool flag55 = (method9 = this.btn_4) == null;
							if (flag55)
							{
								method9 = (this.btn_4 = delegate()
								{
									MessageBox.Show(MainForm, "Возникла ошибка при попытке установить связь с нашим сервером.\n\nПроверьте свое интернет подключение и попробуйте позже еще раз!\nЕсли эта ошибка не исчезает - обратитесь в администрацию проекта.\n\n[INFO]: action: " + message["action"].ToString() + " / response: error", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
								});
							}
							mainForm2.Invoke(method9);
							Environment.Exit(0);
						});
					}
					bool flag2 = message["action"] != null;
					if (flag2)
					{
						string text = message["action"].ToString();
						uint num = MainWindow.PrivateImplementationDetails.ComputeStringHash(text);
						bool flag3 = num <= 2312897930U;
						if (flag3)
						{
							bool flag4 = num <= 1776974088U;
							if (flag4)
							{
								bool flag5 = num != 375255177U;
								if (flag5)
								{
									bool flag6 = num != 1424938192U;
									if (flag6)
									{
										bool flag7 = num != 1776974088U;
										if (!flag7)
										{
											bool flag8 = !(text == "newMessage");
											if (!flag8)
											{
												Task.Run(delegate()
												{
													Control mainForm2 = MainForm;
													MethodInvoker method9;
													bool flag55 = (method9 = this.btn_20) == null;
													if (flag55)
													{
														method9 = (this.btn_20 = delegate()
														{
															this.notifyIcon.ShowBalloonTip(10, "", message["text"].ToString(), ToolTipIcon.Info);
															MessageBox.Show(MainForm, message["text"].ToString(), message["caption"].ToString(), MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
														});
													}
													mainForm2.Invoke(method9);
												});
											}
										}
									}
									else
									{
										bool flag9 = !(text == "connected");
										if (!flag9)
										{
											object message7 = new
											{
												action = "started",
												CPU_ID = this._CLIENT_ID,
												OS_VER = this._CLIENT_OS
											};
											this.WebSocketSendMessage(message7);
										}
									}
								}
								else
								{
									bool flag10 = !(text == "ping");
									if (!flag10)
									{
										string status = "opened";
										Process[] processesByName = Process.GetProcessesByName("MultiTheftAuto");
										bool init_DOWNLOAD = this._INIT_DOWNLOAD;
										object message2;
										if (init_DOWNLOAD)
										{
											status = "downloading";
											message2 = new
											{
												action = "pong",
												status = status,
												speed = this.LabelSpeed.Text.Replace(" MB/s", ""),
												percent = this.LabelPercent.Text.Replace("%", "")
											};
										}
										else
										{
											bool init_UNPACKER = this._INIT_UNPACKER;
											if (init_UNPACKER)
											{
												status = "unpacking";
												message2 = new
												{
													action = "pong",
													status = status
												};
											}
											else
											{
												bool flag11 = processesByName.Length != 0;
												if (flag11)
												{
													status = "in_game";
													message2 = new
													{
														action = "pong",
														status = status
													};
													Control labelStatus = this.LabelStatus;
													MethodInvoker method;
													bool flag12 = (method = this.btn_18) == null;
													if (flag12)
													{
														method = (this.btn_18 = delegate()
														{
															bool flag55 = this.LabelStatus.Text != "Игра успешно запущена!";
															if (flag55)
															{
																this.LabelStatus.Text = "Игра успешно запущена!";
															}
														});
													}
													labelStatus.Invoke(method);
												}
												else
												{
													Control labelStatus2 = this.LabelStatus;
													MethodInvoker method2;
													bool flag13 = (method2 = this.btn_19) == null;
													if (flag13)
													{
														method2 = (this.btn_19 = delegate()
														{
															bool flag55 = this.LabelStatus.Text == "Игра успешно запущена!" || this.LabelStatus.Text == "Запускаю игру...";
															if (flag55)
															{
																this.LabelStatus.Text = "Готовы к игре!";
															}
															this.ButtonPlay.Enabled = true;
															this._BUTTON_PLAY = Resources.button_play;
															this.ButtonPlay.BackgroundImage = this._BUTTON_PLAY;
														});
													}
													labelStatus2.Invoke(method2);
													message2 = new
													{
														action = "pong",
														status = status
													};
												}
											}
										}
										this.WebSocketSendMessage(message2);
									}
								}
							}
							else
							{
								bool flag14 = num != 1789560463U;
								if (flag14)
								{
									bool flag15 = num != 2153339806U;
									if (flag15)
									{
										bool flag16 = num != 2312897930U;
										if (!flag16)
										{
											bool flag17 = !(text == "getAlternativeLink");
											if (!flag17)
											{
												this.ButtonDownload.Invoke(new MethodInvoker(delegate()
												{
													this._INIT_DOWNLOAD_ALTERNATIVE = true;
													this._GAME_URL_DOWNLOAD = message["link"].ToString();
													this.callFromButtonDownload = true;
													this.ButtonDownload_Click(null, null);
												}));
											}
										}
									}
									else
									{
										bool flag18 = !(text == "started");
										if (!flag18)
										{
											object message3 = new
											{
												action = "getVersionLauncher"
											};
											this.WebSocketSendMessage(message3);
										}
									}
								}
								else
								{
									bool flag19 = !(text == "updateOnline");
									if (!flag19)
									{
										this.LabelServer1Online.Invoke(new MethodInvoker(delegate()
										{
											this.LabelServer1Online.Text = message["server_1"].ToString();
										}));
										this.LabelServer2Online.Invoke(new MethodInvoker(delegate()
										{
											this.LabelServer2Online.Text = message["server_2"].ToString();
										}));
										this.LabelTotalOnline.Invoke(new MethodInvoker(delegate()
										{
											this.LabelTotalOnline.Text = message["total"].ToString();
										}));
									}
								}
							}
						}
						else
						{
							bool flag20 = num <= 2539499917U;
							if (flag20)
							{
								bool flag21 = num != 2358027845U;
								if (flag21)
								{
									bool flag22 = num != 2479419601U;
									if (flag22)
									{
										bool flag23 = num != 2539499917U;
										if (flag23)
										{
											return;
										}
										bool flag24 = !(text == "getServers");
										if (flag24)
										{
											return;
										}
										bool flag25 = this.callFromButtonPlay;
										if (flag25)
										{
											this._CLIENT_SELECTED_SERVER_ADDR = message["address"].ToString();
											this._CLIENT_SERVER_CLOSED_MSG = message["closed_message"].ToString();
											Control buttonPlay = this.ButtonPlay;
											MethodInvoker method3;
											bool flag26 = (method3 = this.btn_8) == null;
											if (flag26)
											{
												method3 = (this.btn_8 = delegate()
												{
													this.ButtonPlay_Click(null, null);
												});
											}
											buttonPlay.Invoke(method3);
											return;
										}
										return;
									}
									else
									{
										bool flag27 = !(text == "closeGame");
										if (flag27)
										{
											return;
										}
										try
										{
											Process[] processesByName2 = Process.GetProcessesByName("proxy_sa");
											bool flag28 = processesByName2.Length != 0;
											if (flag28)
											{
												processesByName2.AsParallel<Process>().ForAll(delegate(Process proc)
												{
													proc.Kill();
												});
											}
											return;
										}
										catch (Exception ex)
										{
											this.SendErrorReport("socket_close_game", ex.Message);
											return;
										}
									}
								}
								bool flag29 = !(text == "getVersionLauncher");
								if (!flag29)
								{
									bool flag30 = this._LAUNCHER_VERSION != message["version"].ToString();
									if (flag30)
									{
										Task.Run(delegate()
										{
											Control mainForm2 = MainForm;
											MethodInvoker method9;
											bool flag55 = (method9 = this.btn_14) == null;
											if (flag55)
											{
												method9 = (this.btn_14 = delegate()
												{
													MessageBox.Show(MainForm, string.Concat(new string[]
													{
														"Доступна обновленная версия лаунчера.\n\nВаша версия: [",
														this._LAUNCHER_VERSION,
														"]\nАктуальная версия: [",
														message["version"].ToString(),
														"]\n\nДля загрузки, вас  перенаправит на страницу загрузки.\n\nЕсли страница для загрузки не открылась после закрытия этого сообщения - вы всегда можете скачать лаунчер с официального сайта:\n"
													}), "Оновлення!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
													Process.Start(message["url"].ToString());
													Environment.Exit(0);
												});
											}
											mainForm2.Invoke(method9);
										});
									}
									else
									{
										this.notifyIcon.ShowBalloonTip(3, "", "Лаунчер успешно запущен!", ToolTipIcon.Info);
										object message4 = new
										{
											action = "getVersionGame"
										};
										this.WebSocketSendMessage(message4);
									}
								}
							}
							else
							{
								bool flag31 = num != 2999936787U;
								if (flag31)
								{
									bool flag32 = num != 3119389036U;
									if (flag32)
									{
										bool flag33 = num != 3903804187U;
										if (!flag33)
										{
											bool flag34 = !(text == "closeLauncher");
											if (!flag34)
											{
												Environment.Exit(0);
											}
										}
									}
									else
									{
										bool flag35 = !(text == "getNews");
										if (!flag35)
										{
											string a = message["news_id"].ToString();
											bool flag36 = !(a == "1");
											if (flag36)
											{
												bool flag37 = !(a == "2");
												if (flag37)
												{
													bool flag38 = a == "3";
													if (flag38)
													{
														this._LAUNCHER_NEWS3_LINK = message["link"].ToString();
													}
												}
												else
												{
													this._LAUNCHER_NEWS2_LINK = message["link"].ToString();
												}
											}
											else
											{
												this._LAUNCHER_NEWS1_LINK = message["link"].ToString();
											}
											bool flag39 = File.Exists(string.Concat(new string[]
											{
												this._CLIENT_PATH_LAUNCHER,
												this._LOCATION_NEWS,
												"\\",
												message["news_id"].ToString(),
												"_main.png"
											})) && File.Exists(string.Concat(new string[]
											{
												this._CLIENT_PATH_LAUNCHER,
												this._LOCATION_NEWS,
												"\\",
												message["news_id"].ToString(),
												"_hover.png"
											}));
											if (flag39)
											{
												string a2 = "1";
												string a3 = "1";
												using (MD5 md = MD5.Create())
												{
													try
													{
														using (FileStream fileStream = File.OpenRead(string.Concat(new string[]
														{
															this._CLIENT_PATH_LAUNCHER,
															this._LOCATION_NEWS,
															"\\",
															message["news_id"].ToString(),
															"_main.png"
														})))
														{
															a2 = BitConverter.ToString(md.ComputeHash(fileStream)).Replace("-", "").ToLowerInvariant();
														}
														using (FileStream fileStream2 = File.OpenRead(string.Concat(new string[]
														{
															this._CLIENT_PATH_LAUNCHER,
															this._LOCATION_NEWS,
															"\\",
															message["news_id"].ToString(),
															"_hover.png"
														})))
														{
															a3 = BitConverter.ToString(md.ComputeHash(fileStream2)).Replace("-", "").ToLowerInvariant();
														}
														bool flag40 = a2 != message["md5_main"].ToString() || a3 != message["md5_hover"].ToString();
														if (flag40)
														{
															this.DownloadNews(message["news_id"].ToString(), message["image_main"].ToString(), message["image_hover"].ToString(), message["link"].ToString());
														}
														else
														{
															a = message["news_id"].ToString();
															bool flag41 = !(a == "1");
															if (flag41)
															{
																bool flag42 = !(a == "2");
																if (flag42)
																{
																	bool flag43 = a == "3";
																	if (flag43)
																	{
																		this._NEWS3_MAIN = Image.FromFile(string.Concat(new string[]
																		{
																			this._CLIENT_PATH_LAUNCHER,
																			this._LOCATION_NEWS,
																			"\\",
																			message["news_id"].ToString(),
																			"_main.png"
																		}));
																		this._NEWS3_HOVER = Image.FromFile(string.Concat(new string[]
																		{
																			this._CLIENT_PATH_LAUNCHER,
																			this._LOCATION_NEWS,
																			"\\",
																			message["news_id"].ToString(),
																			"_hover.png"
																		}));
																		Control news = this.News3;
																		MethodInvoker method4;
																		bool flag44 = (method4 = this.btn_17) == null;
																		if (flag44)
																		{
																			method4 = (this.btn_17 = delegate()
																			{
																				this.News3.BackgroundImage = this._NEWS3_MAIN;
																			});
																		}
																		news.Invoke(method4);
																	}
																}
																else
																{
																	this._NEWS2_MAIN = Image.FromFile(string.Concat(new string[]
																	{
																		this._CLIENT_PATH_LAUNCHER,
																		this._LOCATION_NEWS,
																		"\\",
																		message["news_id"].ToString(),
																		"_main.png"
																	}));
																	this._NEWS2_HOVER = Image.FromFile(string.Concat(new string[]
																	{
																		this._CLIENT_PATH_LAUNCHER,
																		this._LOCATION_NEWS,
																		"\\",
																		message["news_id"].ToString(),
																		"_hover.png"
																	}));
																	Control news2 = this.News2;
																	MethodInvoker method5;
																	bool flag45 = (method5 = this.btn_16) == null;
																	if (flag45)
																	{
																		method5 = (this.btn_16 = delegate()
																		{
																			this.News2.BackgroundImage = this._NEWS2_MAIN;
																		});
																	}
																	news2.Invoke(method5);
																}
															}
															else
															{
																this._NEWS1_MAIN = Image.FromFile(string.Concat(new string[]
																{
																	this._CLIENT_PATH_LAUNCHER,
																	this._LOCATION_NEWS,
																	"\\",
																	message["news_id"].ToString(),
																	"_main.png"
																}));
																this._NEWS1_HOVER = Image.FromFile(string.Concat(new string[]
																{
																	this._CLIENT_PATH_LAUNCHER,
																	this._LOCATION_NEWS,
																	"\\",
																	message["news_id"].ToString(),
																	"_hover.png"
																}));
																Control news3 = this.News1;
																MethodInvoker method6;
																bool flag46 = (method6 = this.btn_15) == null;
																if (flag46)
																{
																	method6 = (this.btn_15 = delegate()
																	{
																		this.News1.BackgroundImage = this._NEWS1_MAIN;
																	});
																}
																news3.Invoke(method6);
															}
														}
														goto IL_1050;
													}
													catch (Exception ex2)
													{
														this.SendErrorReport("socket_update_news", ex2.Message);
														goto IL_1050;
													}
												}
											}
											this.DownloadNews(message["news_id"].ToString(), message["image_main"].ToString(), message["image_hover"].ToString(), message["link"].ToString());
											IL_1050:
											bool flag47 = message["news_id"].ToString() == "3";
											if (flag47)
											{
												Control mainForm = MainForm;
												MethodInvoker method7;
												bool flag48 = (method7 = this.btn_6) == null;
												if (flag48)
												{
													method7 = (this.btn_6 = delegate()
													{
														this._WINDOW_VECTOR_OPACITY = true;
														this.TimerLoadWindow.Start();
													});
												}
												mainForm.Invoke(method7);
											}
										}
									}
								}
								else
								{
									bool flag49 = !(text == "getVersionGame");
									if (!flag49)
									{
										this._GAME_VERSION_TEXT = message["version"].ToString();
										this._GAME_URL_DOWNLOAD = message["url"].ToString();
										bool init_DOWNLOAD2 = this._INIT_DOWNLOAD;
										if (!init_DOWNLOAD2)
										{
											bool flag50 = !this.callFromButtonPlay && !this.callFromButtonDownload;
											if (flag50)
											{
												object message5 = new
												{
													action = "getNews"
												};
												this.WebSocketSendMessage(message5);
											}
											bool flag51 = this.CheckGame(this._GAME_VERSION_TEXT);
											if (flag51)
											{
												bool flag52 = this.callFromButtonPlay;
												if (flag52)
												{
													object message6 = new
													{
														action = "getServers",
														SERVER_ID = this._CLIENT_SELECTED_SERVER
													};
													this.WebSocketSendMessage(message6);
												}
											}
											else
											{
												bool flag53 = this.callFromButtonDownload;
												if (flag53)
												{
													Control buttonDownload = this.ButtonDownload;
													MethodInvoker method8;
													bool flag54 = (method8 = this.btn_7) == null;
													if (flag54)
													{
														method8 = (this.btn_7 = delegate()
														{
															this.ButtonDownload_Click(null, null);
														});
													}
													buttonDownload.Invoke(method8);
												}
											}
										}
									}
								}
							}
						}
					}
				};
				Action btn_22;
				WS.OnClose += delegate(object sender, CloseEventArgs e)
				{
					this._WEB_SOCKET_CONNECTED = false;
					int disconnectCount = DisconnectCount;
					DisconnectCount = disconnectCount + 1;
					bool flag = DisconnectCount >= 5;
					if (flag)
					{
						Task.Run(btn_22 = delegate()
						{
							this.notifyIcon.ShowBalloonTip(12, "", "Потеряна связь с нашим сервером!\n\nОткройте лаунчер чтобы снова подключиться.", ToolTipIcon.Warning);
							Control mainForm = MainForm;
							MethodInvoker method;
							bool flag3 = (method = this.btn_23) == null;
							if (flag3)
							{
								method = (this.btn_23 = delegate()
								{
									bool flag4 = MessageBox.Show(MainForm, "Возникла ошибка при попытке установить связь с нашим сервером.\n\nПроверьте свое интернет подключение и попробуйте еще раз!\n\nПопробуйте снова подключиться?", "Ошибка!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Hand) == DialogResult.Retry;
									if (flag4)
									{
										DisconnectCount = 0;
										WS.ConnectAsync();
									}
									else
									{
										Environment.Exit(0);
									}
								});
							}
							mainForm.Invoke(method);
						});
					}
					else
					{
						bool flag2 = !haveError;
						if (flag2)
						{
							WS.ConnectAsync();
						}
					}
				};
				WS.OnOpen += delegate(object sender, EventArgs e)
				{
					Control mainForm = MainForm;
					MethodInvoker method;
					bool flag = (method = this.btn_24) == null;
					if (flag)
					{
						method = (this.btn_24 = delegate()
						{
							MainForm.Enabled = true;
						});
					}
					mainForm.Invoke(method);
				};
				WS.ConnectAsync();
			}
			catch
			{
			}
		}

		private void WebSocketSendMessage(object message)
		{
			Task.Run(delegate()
			{
				try
				{
					JavaScriptSerializer javaScriptSerializer = new JavaScriptSerializer();
					bool flag = !this._WEB_SOCKET_CONNECTED;
					if (flag)
					{
						do
						{
							Thread.Sleep(100);
						}
						while (!this._WEB_SOCKET_CONNECTED);
						MainWindow._WEB_SOCKET.Send(javaScriptSerializer.Serialize(message));
					}
					else
					{
						MainWindow._WEB_SOCKET.Send(javaScriptSerializer.Serialize(message));
					}
				}
				catch
				{
				}
			});
		}

		private void SendErrorReport(string _step, string _message)
		{
			bool flag = _message.Length < 6;
			if (flag)
			{
				_message = "none";
			}
			object message = new
			{
				action = "saveReport",
				step = _step,
				text = _message
			};
			this.WebSocketSendMessage(message);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00003680 File Offset: 0x00001880
		private bool GameExists()
		{
			bool result = false;
			bool flag = File.Exists(this._CLIENT_PATH_LAUNCHER + "\\game\\models\\gta3.img") && File.Exists(this._CLIENT_PATH_LAUNCHER + "\\game\\Multi Theft Auto.exe") && File.Exists(this._CLIENT_PATH_LAUNCHER + "\\game\\mta\\core.dll");
			if (flag)
			{
				result = true;
			}
			return result;
		}

		private bool CheckGameVersion(string originalVersion)
		{
			bool flag = File.Exists(this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_VERSION);
			bool result;
			if (flag)
			{
				string a = "0";
				using (StreamReader streamReader = new StreamReader(this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_VERSION))
				{
					a = streamReader.ReadToEnd();
				}
				result = (a == originalVersion);
			}
			else
			{
				result = false;
			}
			return result;
		}

		public bool CheckGame(string originalVersion = "0")
		{
			bool result = false;
			this.LabelStatus.Invoke(new MethodInvoker(delegate()
			{
				bool flag = this.GameExists();
				if (flag)
				{
					bool flag2 = this.CheckGameVersion(originalVersion);
					if (flag2)
					{
						this.LabelStatus.Text = "Готовы к игре!";
						this.LabelAddtStatus.Text = "Желаем приятного времяпровождения на BLACKRP.";
						this.LabelAddtStatus.Visible = true;
						this.LabelSpeed.Visible = false;
						this.SetProgressLoadingBar(100);
						this.ButtonDownload.Visible = false;
						this.ButtonPlay.Visible = true;
						result = true;
					}
					else
					{
						MessageBox.Show(this, "Доступна новая версия игры! Требуется загрузка обновления", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					}
				}
				bool flag3 = !result;
				if (flag3)
				{
					this.LabelStatus.Text = "Ждем загрузки...";
					this.LabelSpeed.Visible = true;
					this.LabelAddtStatus.Visible = true;
					this.SetProgressLoadingBar(0);
					this.ButtonDownload.Visible = true;
					this.ButtonPlay.Visible = false;
				}
			}));
			return result;
		}

		private void DownloadNews(string id, string image_main, string image_hover, string link)
		{
			try
			{
				bool flag = File.Exists(string.Concat(new string[]
				{
					this._CLIENT_PATH_LAUNCHER,
					this._LOCATION_NEWS,
					"\\",
					id,
					"_main.png"
				}));
				if (flag)
				{
					File.Delete(string.Concat(new string[]
					{
						this._CLIENT_PATH_LAUNCHER,
						this._LOCATION_NEWS,
						"\\",
						id,
						"_main.png"
					}));
				}
				bool flag2 = File.Exists(string.Concat(new string[]
				{
					this._CLIENT_PATH_LAUNCHER,
					this._LOCATION_NEWS,
					"\\",
					id,
					"_hover.png"
				}));
				if (flag2)
				{
					File.Delete(string.Concat(new string[]
					{
						this._CLIENT_PATH_LAUNCHER,
						this._LOCATION_NEWS,
						"\\",
						id,
						"_hover.png"
					}));
				}
				this._WEB_CLIENT.DownloadFile(image_main, string.Concat(new string[]
				{
					this._CLIENT_PATH_LAUNCHER,
					this._LOCATION_NEWS,
					"\\",
					id,
					"_main.png"
				}));
				this._WEB_CLIENT.DownloadFile(image_hover, string.Concat(new string[]
				{
					this._CLIENT_PATH_LAUNCHER,
					this._LOCATION_NEWS,
					"\\",
					id,
					"_hover.png"
				}));
				bool flag3 = !(id == "1");
				if (flag3)
				{
					bool flag4 = !(id == "2");
					if (flag4)
					{
						bool flag5 = id == "3";
						if (flag5)
						{
							this._NEWS3_MAIN = Image.FromFile(string.Concat(new string[]
							{
								this._CLIENT_PATH_LAUNCHER,
								this._LOCATION_NEWS,
								"\\",
								id,
								"_main.png"
							}));
							this._NEWS3_HOVER = Image.FromFile(string.Concat(new string[]
							{
								this._CLIENT_PATH_LAUNCHER,
								this._LOCATION_NEWS,
								"\\",
								id,
								"_hover.png"
							}));
							this._LAUNCHER_NEWS3_LINK = link;
							this.News3.Invoke(new MethodInvoker(delegate()
							{
								this.News3.BackgroundImage = this._NEWS3_MAIN;
							}));
						}
					}
					else
					{
						this._NEWS2_MAIN = Image.FromFile(string.Concat(new string[]
						{
							this._CLIENT_PATH_LAUNCHER,
							this._LOCATION_NEWS,
							"\\",
							id,
							"_main.png"
						}));
						this._NEWS2_HOVER = Image.FromFile(string.Concat(new string[]
						{
							this._CLIENT_PATH_LAUNCHER,
							this._LOCATION_NEWS,
							"\\",
							id,
							"_hover.png"
						}));
						this._LAUNCHER_NEWS2_LINK = link;
						this.News2.Invoke(new MethodInvoker(delegate()
						{
							this.News2.BackgroundImage = this._NEWS2_MAIN;
						}));
					}
				}
				else
				{
					this._NEWS1_MAIN = Image.FromFile(string.Concat(new string[]
					{
						this._CLIENT_PATH_LAUNCHER,
						this._LOCATION_NEWS,
						"\\",
						id,
						"_main.png"
					}));
					this._NEWS1_HOVER = Image.FromFile(string.Concat(new string[]
					{
						this._CLIENT_PATH_LAUNCHER,
						this._LOCATION_NEWS,
						"\\",
						id,
						"_hover.png"
					}));
					this._LAUNCHER_NEWS1_LINK = link;
					this.News1.Invoke(new MethodInvoker(delegate()
					{
						this.News1.BackgroundImage = this._NEWS1_MAIN;
					}));
				}
			}
			catch (Exception)
			{
			}
		}

		private static string GetClientID()
		{
			string str = "none";
			string str2 = "none";
			string str3 = "none";
			try
			{
				using (ManagementObjectCollection.ManagementObjectEnumerator enumerator = new ManagementClass("win32_processor").GetInstances().GetEnumerator())
				{
					bool flag = enumerator.MoveNext();
					if (flag)
					{
						str = enumerator.Current.Properties["processorID"].Value.ToString();
					}
				}
			}
			catch
			{
			}
			try
			{
				ManagementObject managementObject = new ManagementObject("win32_logicaldisk.deviceid=\"c:\"");
				managementObject.Get();
				str2 = managementObject["VolumeSerialNumber"].ToString();
			}
			catch
			{
			}
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard").Get())
				{
					str3 = ((ManagementObject)managementBaseObject)["SerialNumber"].ToString();
				}
			}
			catch
			{
			}
			return MainWindow.GetStringSha256Hash(str + str2 + str3);
		}

		internal static string GetStringSha256Hash(string text)
		{
			bool flag = string.IsNullOrEmpty(text);
			string result;
			if (flag)
			{
				result = string.Empty;
			}
			else
			{
				string text2;
				try
				{
					using (SHA256Managed sha256Managed = new SHA256Managed())
					{
						byte[] bytes = Encoding.UTF8.GetBytes(text);
						text2 = BitConverter.ToString(sha256Managed.ComputeHash(bytes)).Replace("-", string.Empty);
					}
				}
				catch
				{
					text2 = string.Empty;
				}
				result = text2;
			}
			return result;
		}

		public static string GetClientFriendlyOSName()
		{
			string result = "none";
			try
			{
				foreach (ManagementBaseObject managementBaseObject in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get())
				{
					result = ((ManagementObject)managementBaseObject)["Caption"].ToString();
				}
			}
			catch
			{
			}
			return result;
		}

		private string ReadFromURL(string url)
		{
			string result;
			try
			{
				result = this._WEB_CLIENT.DownloadString(url);
			}
			catch
			{
				result = "error";
			}
			return result;
		}

		private void StartDownload(string url)
		{
			this.LabelSpeed.Text = "Начинаем загрузку игры...";
			bool flag = false;
			bool flag2 = File.Exists(this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_ARCHIVE);
			if (flag2)
			{
				try
				{
					File.Delete(this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_ARCHIVE);
				}
				catch
				{
					flag = true;
					this._INIT_DOWNLOAD = false;
					MessageBox.Show(this, "Мы не можем удалить предыдущие файлы игры для того чтобы выполнить новую загрузку.\n\nВ случае если ошибка не исчезает-переустановите лаунчер через официальный сайт.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			bool flag3 = flag;
			if (!flag3)
			{
				try
				{
					bool flag4 = (double)(new DriveInfo(Path.GetPathRoot(this._CLIENT_PATH_LAUNCHER)).AvailableFreeSpace / 1024L / 1024L / 1024L) < 20.0;
					if (flag4)
					{
						MessageBox.Show(this, "Недостаточно места на диске с лаунчером (необходимо ~20гб), пожалуйста, освободите место и попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.SendErrorReport("downloading", "Недостаточно места у клиента, показываем сообщение с просьбой освободить место");
						this._INIT_DOWNLOAD = false;
						return;
					}
				}
				catch
				{
				}
				Uri address = new Uri(url);
				try
				{
					this.ButtonDownload.Enabled = false;
					this._BUTTON_DOWNLOAD = Resources.button_download_active;
					this.LabelSpeed.Visible = true;
					try
					{
						bool isRunning = this._STOP_WATCH.IsRunning;
						if (isRunning)
						{
							this._STOP_WATCH.Stop();
							this._STOP_WATCH.Reset();
						}
						this._WEB_CLIENT.CancelAsync();
						this._WEB_CLIENT.Dispose();
					}
					catch
					{
					}
					this._WEB_CLIENT.DownloadProgressChanged += this.DownloadProgressChanged;
					this._WEB_CLIENT.DownloadFileCompleted += this.DownloadFileCompleted;
					this._WEB_CLIENT.DownloadFileAsync(address, this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_ARCHIVE);
					this._STOP_WATCH.Start();
					bool flag5 = !this._INIT_DOWNLOAD_ALTERNATIVE;
					if (flag5)
					{
						this.notifyIcon.ShowBalloonTip(12, "", "Начинаем загрузку игры, мы сообщим по окончанию...", ToolTipIcon.Info);
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(this, "\r\nВозникла ошибка при попытке загрузить файл с нашего сервера. Пожалуйста, попробуйте еще раз.\n\nЕсли эта ошибка не исчезает - обратитесь в администрацию.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					this.CheckGame("0");
					this.SendErrorReport("download_pre_start", ex.Message);
				}
			}
		}

		private void DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			bool flag = !this._INIT_DOWNLOAD;
			if (!flag)
			{
				bool flag2 = e.Error == null;
				if (flag2)
				{
					this._INIT_DOWNLOAD_ALTERNATIVE = false;
					try
					{
						bool isRunning = this._STOP_WATCH.IsRunning;
						if (isRunning)
						{
							this._STOP_WATCH.Stop();
							this._STOP_WATCH.Reset();
						}
					}
					catch
					{
					}
					this.StartUnpacking();
					this.notifyIcon.ShowBalloonTip(10, "", "Загрузка завершена, начинаем распаковку...", ToolTipIcon.Info);
				}
				else
				{
					this._INIT_DOWNLOAD = false;
					bool flag3 = e.Error.ToString().Contains("enough space") || e.Error.ToString().Contains("Недостаточно места") || this._INIT_DOWNLOAD_ALTERNATIVE;
					if (flag3)
					{
						bool flag4 = e.Error.ToString().Contains("enough space") || e.Error.ToString().Contains("Недостаточно места");
						if (flag4)
						{
							MessageBox.Show(this, "Возникла ошибка при попытке загрузить файл с нашего сервера.\n\nНедостаточно места на диске с лаунчером (необходимо ~20гб), пожалуйста, освободите место и попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.SendErrorReport("downloading", "Недостаточно места у клиента, показываем сообщение с просьбой освободить место");
						}
						else
						{
							MessageBox.Show(this, "Возникла ошибка при попытке загрузить файл с нашего сервера. Будь ласка, спробуйте ще раз.\n\nЕсли эта Ошибка не исчезает - обратитесь в администрацию.\n\n[INFO]:\n" + e.Error.ToString(), "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
							this.SendErrorReport("downloading", e.Error.ToString());
						}
						this.CheckGame("0");
						this._INIT_DOWNLOAD_ALTERNATIVE = false;
					}
					else
					{
						object message = new
						{
							action = "getAlternativeLink"
						};
						this.WebSocketSendMessage(message);
						this.SendErrorReport("downloading_go_to_reserve", "Ошибка загрузки из основного хранилища, перебрасываем клиента на резервное!");
					}
				}
			}
		}

		private void DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			try
			{
				bool flag = this.LabelStatus.Text != "Продолжается загрузка игры...";
				if (flag)
				{
					this.LabelStatus.Text = "Продолжается загрузка игры...";
				}
				bool flag2 = this.LabelSpeed.Text != (Convert.ToDouble(e.BytesReceived) / 1024.0 / 1024.0 / this._STOP_WATCH.Elapsed.TotalSeconds).ToString("0.00") + " MB/s";
				if (flag2)
				{
					this.LabelSpeed.Text = (Convert.ToDouble(e.BytesReceived) / 1024.0 / 1024.0 / this._STOP_WATCH.Elapsed.TotalSeconds).ToString("0.00") + " MB/s";
				}
				bool flag3 = this.LabelPercent.Text != e.ProgressPercentage.ToString() + "%";
				if (flag3)
				{
					this.SetProgressLoadingBar(e.ProgressPercentage);
				}
				bool flag4 = this.LabelAddtStatus.Text != (Convert.ToDouble(e.BytesReceived) / 1024.0 / 1024.0 / 1024.0).ToString("0.00") + " GB / " + (Convert.ToDouble(e.TotalBytesToReceive) / 1024.0 / 1024.0 / 1024.0).ToString("0.00") + " GB";
				if (flag4)
				{
					this.LabelAddtStatus.Text = (Convert.ToDouble(e.BytesReceived) / 1024.0 / 1024.0 / 1024.0).ToString("0.00") + " / " + (Convert.ToDouble(e.TotalBytesToReceive) / 1024.0 / 1024.0 / 1024.0).ToString("0.00") + " GB";
				}
			}
			catch
			{
			}
		}

		private void StartUnpacking()
		{
			try
			{
				this._WEB_CLIENT.Dispose();
			}
			catch
			{
			}
			this.SetProgressLoadingBar(100);
			this.LabelStatus.Text = "Начинаем распаковку игры...";
			this.LabelSpeed.Visible = false;
			this.LabelAddtStatus.Text = "Распаковка игры может занять до 30 минут.";
			try
			{
				bool flag = Directory.Exists(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME);
				if (flag)
				{
					Directory.GetFiles(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME, "*", SearchOption.AllDirectories).ToList<string>().ForEach(delegate(string file)
					{
						FileInfo fileInfo = new FileInfo(file);
						bool flag3 = fileInfo.Attributes.HasFlag(FileAttributes.ReadOnly);
						if (flag3)
						{
							fileInfo.Attributes = FileAttributes.Normal;
						}
					});
					new DirectoryInfo(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME).Attributes = FileAttributes.Normal;
					Directory.Delete(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME, true);
					Directory.CreateDirectory(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME);
				}
			}
			catch
			{
				MessageBox.Show(this, "Возникла Ошибка при попытке распаковки архива с игрой! Попробуйте сделать следующее:\n\n1. Закройте лаунчер.\n2. Удалить папку \"game\" которая находится в папке лаунчера.\n3. Откройте лаунчер снова и установите игру.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			bool flag2 = File.Exists(this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_ARCHIVE);
			if (flag2)
			{
				try
				{
					Task.Run(delegate()
					{
						this.unpack();
					});
					this._WEB_CLIENT.Dispose();
					this.UnPackingTimer.Start();
					return;
				}
				catch (Exception ex)
				{
					this.SendErrorReport("start_unpacking", ex.Message);
					MessageBox.Show(this, "Возникла Ошибка при попытке распаковки архива с игрой! Переустановите лаунчер и попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
					Environment.Exit(0);
					return;
				}
			}
			this.SendErrorReport("start_unpacking", "Не найден архив с игрой для распаковки");
			MessageBox.Show(this, "Возникла Ошибка при попытке распаковки архива с игрой! Переустановите лаунчер и попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			Environment.Exit(0);
		}

		private void unpack()
		{
			try
			{
				this._INIT_UNPACKER = true;
				Process process = Process.Start(new ProcessStartInfo
				{
					UseShellExecute = true,
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = this._CLIENT_PATH_LAUNCHER + "\\7z\\7za.exe",
					Arguments = string.Format("x \"{0}\" -y -o\"{1}\"", this._CLIENT_PATH_LAUNCHER + this._FILE_GAME_ARCHIVE, this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME)
				});
				process.WaitForExit();
				process.Close();
			}
			catch (Exception ex)
			{
				this.SendErrorReport("unpack", ex.Message);
				MessageBox.Show(null, "Возникла Ошибка при распаковке игрового архива, пожалуйста, переустановите лаунчер.\n\nЕсли Ошибка не исчезает - обратитесь в администрацию.\n\n[INFO]:" + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				Environment.Exit(0);
			}
			this._INIT_UNPACKER = false;
		}

		private static bool IsAdministrator()
		{
			bool result = false;
			try
			{
				result = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			}
			catch
			{
				result = false;
			}
			return result;
		}

		private void ButtonServer1_Click(object sender, EventArgs e)
		{
			this._CLIENT_SELECTED_SERVER = 1;
			this._CLIENT_SELECTED_SERVER_ADDR = "37.230.162.235";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\BRP\\1.6\\connect", true);
			bool flag = registryKey != null;
			if (flag)
			{
				registryKey.SetValue("ip", "37.230.162.235", RegistryValueKind.String);
				registryKey.Close();
			}
			this.ButtonServer1.BackgroundImage = Resources.button_server_1st_active;
			this.ButtonServer2.BackgroundImage = Resources.button_server_2nd;
			this.ButtonServer3.BackgroundImage = Resources.button_server_test;
			try
			{
				using (StreamWriter streamWriter = File.CreateText(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT))
				{
					streamWriter.Write(this._CLIENT_SELECTED_SERVER.ToString());
				}
			}
			catch
			{
			}
		}

		private void ButtonServer2_Click(object sender, EventArgs e)
		{
			this._CLIENT_SELECTED_SERVER = 2;
			this._CLIENT_SELECTED_SERVER_ADDR = "d1.black-rp.ru";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\BRP\\1.6\\connect", true);
			bool flag = registryKey != null;
			if (flag)
			{
				registryKey.SetValue("ip", "d1.black-rp.ru", RegistryValueKind.String);
				registryKey.Close();
			}
			this.ButtonServer1.BackgroundImage = Resources.button_server_1st;
			this.ButtonServer2.BackgroundImage = Resources.button_server_2nd_active;
			this.ButtonServer3.BackgroundImage = Resources.button_server_test;
			try
			{
				using (StreamWriter streamWriter = File.CreateText(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT))
				{
					streamWriter.Write(this._CLIENT_SELECTED_SERVER.ToString());
				}
			}
			catch
			{
			}
		}

		private void ButtonServer3_Click(object sender, EventArgs e)
		{
			this._CLIENT_SELECTED_SERVER = 3;
			this._CLIENT_SELECTED_SERVER_ADDR = "s2.black-rp.ru";
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\WOW6432Node\\BRP\\1.6\\connect", true);
			bool flag = registryKey != null;
			if (flag)
			{
				registryKey.SetValue("ip", "s2.black-rp.ru", RegistryValueKind.String);
				registryKey.Close();
			}
			this.ButtonServer1.BackgroundImage = Resources.button_server_1st;
			this.ButtonServer2.BackgroundImage = Resources.button_server_2nd;
			this.ButtonServer3.BackgroundImage = Resources.button_server_test_active;
			try
			{
				using (StreamWriter streamWriter = File.CreateText(this._CLIENT_PATH_LAUNCHER + this._FILE_SERVER_SELECT))
				{
					streamWriter.Write(this._CLIENT_SELECTED_SERVER.ToString());
				}
			}
			catch
			{
			}
		}

		private void UnPackingTimer_Tick(object sender, EventArgs e)
		{
			switch (this.UnPackingLabelStatus)
			{
			case 0:
				this.LabelStatus.Text = "Продолжается распаковка.";
				this.UnPackingLabelStatus = 1;
				break;
			case 1:
				this.LabelStatus.Text = "Продолжается распаковка..";
				this.UnPackingLabelStatus = 2;
				break;
			case 2:
				this.LabelStatus.Text = "Продолжается распаковка...";
				this.UnPackingLabelStatus = 3;
				break;
			case 3:
				this.LabelStatus.Text = "Продолжается распаковка...";
				this.UnPackingLabelStatus = 0;
				break;
			}
			bool flag = !this._INIT_UNPACKER;
			if (flag)
			{
				this.UnPackingTimer.Stop();
				this.LabelAddtStatus.Visible = false;
				this.ButtonDownload.Enabled = true;
				this._BUTTON_DOWNLOAD = Resources.button_download;
				this.CheckGame(this._GAME_VERSION_TEXT);
				this._INIT_DOWNLOAD = false;
				this.notifyIcon.ShowBalloonTip(12, "", "Распаковка завершена, готовы к запуску игры!", ToolTipIcon.Info);
			}
		}

		private void ButtonPlay_Click(object sender, EventArgs e)
		{
			bool flag = !this.CheckGame(this._GAME_VERSION_TEXT);
			if (flag)
			{
				MessageBox.Show(this, "Доступно обновление, требуется обновить файлы игры", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			}
			else
			{
				this.LabelStatus.Invoke(new MethodInvoker(delegate()
				{
					this.LabelStatus.Text = "Запуск...";
				}));
				this.ButtonPlay.Invoke(new MethodInvoker(delegate()
				{
					this.ButtonPlay.Enabled = false;
					this._BUTTON_PLAY = Resources.button_play_active;
					this.ButtonPlay.BackgroundImage = this._BUTTON_PLAY;
				}));
				bool flag2 = this._CLIENT_SERVER_CLOSED_MSG.Length > 5;
				if (flag2)
				{
					MessageBox.Show(this, this._CLIENT_SERVER_CLOSED_MSG, "Информация", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					this._CLIENT_SERVER_CLOSED_MSG = "";
				}
				else
				{
					try
					{
						using (StreamWriter streamWriter = File.CreateText(this._CLIENT_PATH_LAUNCHER + "\\MTAInstall.bat"))
						{
							bool flag3 = MainWindow.IsAdministrator();
							if (flag3)
							{
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\Software\\WOW6432Node\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\Software\\WOW6432Node\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\Software\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\Software\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
								streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\BRP\\1.6\\connect\" /v \"ip\" /f /t REG_SZ /d \"" + this._CLIENT_SELECTED_SERVER_ADDR + "\"");
							}
							streamWriter.WriteLine("REG ADD \"HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\BRP\\1.6\\connect\" /v \"ip\" /f /t REG_SZ /d \"" + this._CLIENT_SELECTED_SERVER_ADDR + "\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\WOW6432Node\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\WOW6432Node\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\WOW6432Node\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\WOW6432Node\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\BRP\\Common\" /v \"GTA:SA Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\"");
							streamWriter.WriteLine("REG ADD \"HKEY_CURRENT_USER\\Software\\BRP\\Common\" /v \"File Cache Path\" /f /t REG_SZ /d \"" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\mods\\deathmatch\"");
							streamWriter.Close();
						}
						Process process = Process.Start(new ProcessStartInfo
						{
							UseShellExecute = true,
							WindowStyle = ProcessWindowStyle.Hidden,
							FileName = this._CLIENT_PATH_LAUNCHER + "\\MTAInstall.bat"
						});
						process.WaitForExit(4000);
						process.Close();
					}
					catch (Exception ex)
					{
						MessageBox.Show(this, "Нам не удалось выполнить первоначальные настройки MTA.\n\nЕсли при запуске, игра пригласит выбрать путь, укажите путь к папке \"game\" которая находится в папке с лаунчером:\n\n" + this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.SendErrorReport("set_mta_path", ex.Message);
					}
					try
					{
						Process.Start(this._CLIENT_PATH_LAUNCHER + this._LOCATION_GAME + "\\Multi Theft Auto.exe", "-c " + this._CLIENT_SELECTED_SERVER_ADDR);
					}
					catch (Exception ex2)
					{
						MessageBox.Show(this, "Возникла Ошибка при попытке запустить игру, пожалуйста, переустановите игру (через кнопку настроек справа-сверху лаунчера) и попробуйте еще раз.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
						this.SendErrorReport("start_game", ex2.Message);
					}
				}
			}
			this.callFromButtonPlay = false;
		}

		public void ButtonDownload_Click(object sender, EventArgs e)
		{
			bool init_DOWNLOAD = this._INIT_DOWNLOAD;
			if (!init_DOWNLOAD)
			{
				bool flag = !this.callFromButtonDownload;
				if (flag)
				{
					this.callFromButtonDownload = true;
					object message = new
					{
						action = "getVersionGame"
					};
					this.WebSocketSendMessage(message);
				}
				else
				{
					bool flag2 = this._GAME_URL_DOWNLOAD.Length > 2;
					if (flag2)
					{
						this._INIT_DOWNLOAD = true;
						this.StartDownload(this._GAME_URL_DOWNLOAD);
					}
					this.callFromButtonDownload = false;
				}
			}
		}

		private void TimerLoadWindow_Tick(object sender, EventArgs e)
		{
			this.TimerLoadWindow.Stop();
			bool window_VECTOR_OPACITY = this._WINDOW_VECTOR_OPACITY;
			double num;
			if (window_VECTOR_OPACITY)
			{
				num = 0.0;
			}
			else
			{
				num = 0.99;
			}
			for (;;)
			{
				bool window_VECTOR_OPACITY2 = this._WINDOW_VECTOR_OPACITY;
				if (window_VECTOR_OPACITY2)
				{
					num += 0.04;
				}
				else
				{
					num -= 0.06;
				}
				base.Opacity = num;
				Thread.Sleep(5);
				bool flag = num >= 0.99 && this._WINDOW_VECTOR_OPACITY;
				if (flag)
				{
					break;
				}
				if (num <= 0.01 && !this._WINDOW_VECTOR_OPACITY)
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

		private string _LAUNCHER_VERSION = "1.8.9 - 11/05/2023";

		private string _LAUNCHER_WS_ADDRESS = "";

		private string _LAUNCHER_NEWS1_LINK = "http://launcher.black-rp.online/";

		private string _LAUNCHER_NEWS2_LINK = "http://launcher.black-rp.online/";

		private string _LAUNCHER_NEWS3_LINK = "http://launcher.black-rp.online/";

		private string _FILE_GAME_VERSION = "\\game\\version.txt";

		private string _FILE_SERVER_SELECT = "\\server.txt";

		public string _FILE_GAME_ARCHIVE = "\\downloaded\\game.7z";

		public string _LOCATION_GAME = "\\game";

		private string _LOCATION_DOWNLOAD = "\\downloaded";

		private string _LOCATION_NEWS = "\\downloaded\\news";

		private string _GAME_VERSION_TEXT = "0";

		private string _GAME_URL_DOWNLOAD = "";

		public string _CLIENT_PATH_LAUNCHER = string.Empty;

		private string _CLIENT_ID = string.Empty;

		private string _CLIENT_OS = string.Empty;

		private string _CLIENT_SELECTED_SERVER_ADDR = string.Empty;

		private string _CLIENT_SERVER_CLOSED_MSG = string.Empty;

		private int _CLIENT_SELECTED_SERVER = 1;

		private bool _WINDOW_VECTOR_OPACITY = true;

		private bool _WEB_SOCKET_CONNECTED;

		public bool _INIT_DOWNLOAD;

		private bool _INIT_DOWNLOAD_ALTERNATIVE;

		public bool _INIT_UNPACKER;

		private Image _NEWS1_MAIN;

		private Image _NEWS1_HOVER;

		private Image _NEWS2_MAIN;

		private Image _NEWS2_HOVER;

		private Image _NEWS3_MAIN;

		private Image _NEWS3_HOVER;

		private Image _BUTTON_DOWNLOAD;

		private Image _BUTTON_PLAY;

		private WebClient _WEB_CLIENT = new WebClient();

		private Stopwatch _STOP_WATCH = new Stopwatch();

		private static WebSocket _WEB_SOCKET;

		private int UnPackingLabelStatus;

		private bool callFromButtonPlay;

		private bool callFromButtonDownload;

		private MethodInvoker btn_4;

		private MethodInvoker btn_6;

		private MethodInvoker btn_7;

		private MethodInvoker btn_8;

		private MethodInvoker btn_14;

		private MethodInvoker btn_15;

		private MethodInvoker btn_16;

		private MethodInvoker btn_17;

		private MethodInvoker btn_18;

		private MethodInvoker btn_19;

		private MethodInvoker btn_20;

		private MethodInvoker btn_23;

		private MethodInvoker btn_24;

		internal sealed class PrivateImplementationDetails
		{
			internal static uint ComputeStringHash(string s)
			{
				uint num = 0U;
				bool flag = s != null;
				if (flag)
				{
					num = 2166136261U;
					for (int i = 0; i < s.Length; i++)
					{
						num = ((uint)s[i] ^ num) * 16777619U;
					}
				}
				return num;
			}
		}
	}
}
