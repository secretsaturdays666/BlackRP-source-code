namespace blackrp_launcher
{
	// Token: 0x02000008 RID: 8
	public partial class MainWindow : global::System.Windows.Forms.Form
	{
		// Token: 0x06000076 RID: 118 RVA: 0x00005148 File Offset: 0x00003348
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00005180 File Offset: 0x00003380
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::blackrp_launcher.MainWindow));
			this.ButtonCloseApp = new global::System.Windows.Forms.PictureBox();
			this.ButtonMinimizeApp = new global::System.Windows.Forms.PictureBox();
			this.ButtonOpenSettings = new global::System.Windows.Forms.PictureBox();
			this.ButtonOpenCabinet = new global::System.Windows.Forms.PictureBox();
			this.ButtonOpenDonate = new global::System.Windows.Forms.PictureBox();
			this.ButtonOpenForum = new global::System.Windows.Forms.PictureBox();
			this.ButtonOpenSite = new global::System.Windows.Forms.PictureBox();
			this.LabelNews = new global::System.Windows.Forms.Label();
			this.News1 = new global::System.Windows.Forms.PictureBox();
			this.News2 = new global::System.Windows.Forms.PictureBox();
			this.News3 = new global::System.Windows.Forms.PictureBox();
			this.LabelServers = new global::System.Windows.Forms.Label();
			this.LabelOnline = new global::System.Windows.Forms.Label();
			this.LabelTotalOnline = new global::System.Windows.Forms.Label();
			this.OrangeDot = new global::System.Windows.Forms.PictureBox();
			this.ButtonServer1 = new global::System.Windows.Forms.PictureBox();
			this.ButtonServer2 = new global::System.Windows.Forms.PictureBox();
			this.ButtonServer3 = new global::System.Windows.Forms.PictureBox();
			this.LockServer1 = new global::System.Windows.Forms.PictureBox();
			this.LockServer2 = new global::System.Windows.Forms.PictureBox();
			this.LockServer3 = new global::System.Windows.Forms.PictureBox();
			this.OrangeDotServer1 = new global::System.Windows.Forms.PictureBox();
			this.LabelServer1Online = new global::System.Windows.Forms.Label();
			this.LabelServer2Online = new global::System.Windows.Forms.Label();
			this.OrangeDotServer2 = new global::System.Windows.Forms.PictureBox();
			this.LabelServer3Online = new global::System.Windows.Forms.Label();
			this.OrangeDotServer3 = new global::System.Windows.Forms.PictureBox();
			this.LabelStatus = new global::System.Windows.Forms.Label();
			this.LabelPercent = new global::System.Windows.Forms.Label();
			this.LabelSpeed = new global::System.Windows.Forms.Label();
			this.LabelAddtStatus = new global::System.Windows.Forms.Label();
			this.ButtonDownload = new global::System.Windows.Forms.PictureBox();
			this.LabelGUID = new global::System.Windows.Forms.Label();
			this.LoadingBar = new global::System.Windows.Forms.PictureBox();
			this.UnPackingTimer = new global::System.Windows.Forms.Timer(this.components);
			this.ButtonDiscord = new global::System.Windows.Forms.PictureBox();
			this.ButtonInstagram = new global::System.Windows.Forms.PictureBox();
			this.ButtonYoutube = new global::System.Windows.Forms.PictureBox();
			this.ButtonTelegram = new global::System.Windows.Forms.PictureBox();
			this.ButtonTiktok = new global::System.Windows.Forms.PictureBox();
			this.TimerLoadWindow = new global::System.Windows.Forms.Timer(this.components);
			this.LabelVersion = new global::System.Windows.Forms.Label();
			this.notifyIcon = new global::System.Windows.Forms.NotifyIcon(this.components);
			this.ButtonPlay = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonCloseApp).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonMinimizeApp).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenSettings).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenCabinet).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenDonate).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenForum).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenSite).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.News1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.News2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.News3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDot).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonServer1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonServer2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonServer3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.LockServer1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.LockServer2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.LockServer3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDotServer1).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDotServer2).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDotServer3).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonDownload).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.LoadingBar).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonDiscord).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonInstagram).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonYoutube).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonTelegram).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonTiktok).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonPlay).BeginInit();
			base.SuspendLayout();
			this.ButtonCloseApp.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonCloseApp.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_close_app;
			this.ButtonCloseApp.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonCloseApp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonCloseApp.Location = new global::System.Drawing.Point(956, 12);
			this.ButtonCloseApp.Name = "ButtonCloseApp";
			this.ButtonCloseApp.Size = new global::System.Drawing.Size(15, 15);
			this.ButtonCloseApp.TabIndex = 0;
			this.ButtonCloseApp.TabStop = false;
			this.ButtonCloseApp.Click += new global::System.EventHandler(this.ButtonCloseApp_Click);
			this.ButtonMinimizeApp.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonMinimizeApp.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_minimize_app;
			this.ButtonMinimizeApp.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonMinimizeApp.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonMinimizeApp.Location = new global::System.Drawing.Point(935, 12);
			this.ButtonMinimizeApp.Name = "ButtonMinimizeApp";
			this.ButtonMinimizeApp.Size = new global::System.Drawing.Size(15, 15);
			this.ButtonMinimizeApp.TabIndex = 1;
			this.ButtonMinimizeApp.TabStop = false;
			this.ButtonMinimizeApp.Click += new global::System.EventHandler(this.ButtonMinimizeApp_Click);
			this.ButtonOpenSettings.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonOpenSettings.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_open_settings;
			this.ButtonOpenSettings.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonOpenSettings.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonOpenSettings.Location = new global::System.Drawing.Point(914, 12);
			this.ButtonOpenSettings.Name = "ButtonOpenSettings";
			this.ButtonOpenSettings.Size = new global::System.Drawing.Size(15, 15);
			this.ButtonOpenSettings.TabIndex = 2;
			this.ButtonOpenSettings.TabStop = false;
			this.ButtonOpenSettings.Click += new global::System.EventHandler(this.ButtonOpenSettings_Click);
			this.ButtonOpenCabinet.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonOpenCabinet.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_open_cabinet;
			this.ButtonOpenCabinet.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonOpenCabinet.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonOpenCabinet.Location = new global::System.Drawing.Point(739, 39);
			this.ButtonOpenCabinet.Name = "ButtonOpenCabinet";
			this.ButtonOpenCabinet.Size = new global::System.Drawing.Size(232, 50);
			this.ButtonOpenCabinet.TabIndex = 3;
			this.ButtonOpenCabinet.TabStop = false;
			this.ButtonOpenCabinet.Click += new global::System.EventHandler(this.ButtonOpenCabinet_Click);
			this.ButtonOpenCabinet.MouseEnter += new global::System.EventHandler(this.ButtonOpenCabinet_MouseEnter);
			this.ButtonOpenCabinet.MouseLeave += new global::System.EventHandler(this.ButtonOpenCabinet_MouseLeave);
			this.ButtonOpenDonate.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonOpenDonate.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_open_donate;
			this.ButtonOpenDonate.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonOpenDonate.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonOpenDonate.Location = new global::System.Drawing.Point(593, 39);
			this.ButtonOpenDonate.Name = "ButtonOpenDonate";
			this.ButtonOpenDonate.Size = new global::System.Drawing.Size(131, 50);
			this.ButtonOpenDonate.TabIndex = 4;
			this.ButtonOpenDonate.TabStop = false;
			this.ButtonOpenDonate.Click += new global::System.EventHandler(this.ButtonOpenDonate_Click);
			this.ButtonOpenDonate.MouseEnter += new global::System.EventHandler(this.ButtonOpenDonate_MouseEnter);
			this.ButtonOpenDonate.MouseLeave += new global::System.EventHandler(this.ButtonOpenDonate_MouseLeave);
			this.ButtonOpenForum.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonOpenForum.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_open_forum;
			this.ButtonOpenForum.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonOpenForum.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonOpenForum.Location = new global::System.Drawing.Point(437, 39);
			this.ButtonOpenForum.Name = "ButtonOpenForum";
			this.ButtonOpenForum.Size = new global::System.Drawing.Size(137, 50);
			this.ButtonOpenForum.TabIndex = 5;
			this.ButtonOpenForum.TabStop = false;
			this.ButtonOpenForum.Click += new global::System.EventHandler(this.ButtonOpenForum_Click);
			this.ButtonOpenForum.MouseEnter += new global::System.EventHandler(this.ButtonOpenForum_MouseEnter);
			this.ButtonOpenForum.MouseLeave += new global::System.EventHandler(this.ButtonOpenForum_MouseLeave);
			this.ButtonOpenSite.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonOpenSite.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_open_site;
			this.ButtonOpenSite.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonOpenSite.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonOpenSite.Location = new global::System.Drawing.Point(297, 39);
			this.ButtonOpenSite.Name = "ButtonOpenSite";
			this.ButtonOpenSite.Size = new global::System.Drawing.Size(120, 50);
			this.ButtonOpenSite.TabIndex = 6;
			this.ButtonOpenSite.TabStop = false;
			this.ButtonOpenSite.Click += new global::System.EventHandler(this.ButtonOpenSite_Click);
			this.ButtonOpenSite.MouseEnter += new global::System.EventHandler(this.ButtonOpenSite_MouseEnter);
			this.ButtonOpenSite.MouseLeave += new global::System.EventHandler(this.ButtonOpenSite_MouseLeave);
			this.LabelNews.AutoSize = true;
			this.LabelNews.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelNews.Font = new global::System.Drawing.Font("Montserrat", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LabelNews.ForeColor = global::System.Drawing.Color.White;
			this.LabelNews.Location = new global::System.Drawing.Point(292, 114);
			this.LabelNews.Name = "LabelNews";
			this.LabelNews.Size = new global::System.Drawing.Size(214, 27);
			this.LabelNews.TabIndex = 7;
			this.LabelNews.Text = "НОВОСТИ ПРОЕКТА";
			this.News1.BackColor = global::System.Drawing.Color.Transparent;
			this.News1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.News1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.News1.Location = new global::System.Drawing.Point(297, 148);
			this.News1.Name = "News1";
			this.News1.Size = new global::System.Drawing.Size(420, 305);
			this.News1.TabIndex = 8;
			this.News1.TabStop = false;
			this.News1.Click += new global::System.EventHandler(this.News1_Click);
			this.News1.MouseEnter += new global::System.EventHandler(this.News1_MouseEnter);
			this.News1.MouseLeave += new global::System.EventHandler(this.News1_MouseLeave);
			this.News2.BackColor = global::System.Drawing.Color.Transparent;
			this.News2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.News2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.News2.Location = new global::System.Drawing.Point(728, 148);
			this.News2.Name = "News2";
			this.News2.Size = new global::System.Drawing.Size(243, 148);
			this.News2.TabIndex = 9;
			this.News2.TabStop = false;
			this.News2.Click += new global::System.EventHandler(this.News2_Click);
			this.News2.MouseEnter += new global::System.EventHandler(this.News2_MouseEnter);
			this.News2.MouseLeave += new global::System.EventHandler(this.News2_MouseLeave);
			this.News3.BackColor = global::System.Drawing.Color.Transparent;
			this.News3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.News3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.News3.Location = new global::System.Drawing.Point(728, 305);
			this.News3.Name = "News3";
			this.News3.Size = new global::System.Drawing.Size(243, 148);
			this.News3.TabIndex = 10;
			this.News3.TabStop = false;
			this.News3.Click += new global::System.EventHandler(this.News3_Click);
			this.News3.MouseEnter += new global::System.EventHandler(this.News3_MouseEnter);
			this.News3.MouseLeave += new global::System.EventHandler(this.News3_MouseLeave);
			this.LabelServers.AutoSize = true;
			this.LabelServers.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelServers.Font = new global::System.Drawing.Font("Montserrat", 15f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LabelServers.ForeColor = global::System.Drawing.Color.White;
			this.LabelServers.Location = new global::System.Drawing.Point(292, 486);
			this.LabelServers.Name = "LabelServers";
			this.LabelServers.Size = new global::System.Drawing.Size(189, 27);
			this.LabelServers.TabIndex = 11;
			this.LabelServers.Text = "Игровые сервера";
			this.LabelOnline.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelOnline.Font = new global::System.Drawing.Font("Montserrat", 12f);
			this.LabelOnline.ForeColor = global::System.Drawing.Color.White;
			this.LabelOnline.Location = new global::System.Drawing.Point(752, 488);
			this.LabelOnline.Name = "LabelOnline";
			this.LabelOnline.Size = new global::System.Drawing.Size(181, 25);
			this.LabelOnline.TabIndex = 13;
			this.LabelOnline.Text = "общий онлайн";
			this.LabelTotalOnline.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelTotalOnline.Font = new global::System.Drawing.Font("Montserrat", 12f);
			this.LabelTotalOnline.ForeColor = global::System.Drawing.Color.White;
			this.LabelTotalOnline.Location = new global::System.Drawing.Point(921, 488);
			this.LabelTotalOnline.Name = "LabelTotalOnline";
			this.LabelTotalOnline.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.LabelTotalOnline.Size = new global::System.Drawing.Size(54, 25);
			this.LabelTotalOnline.TabIndex = 14;
			this.LabelTotalOnline.Text = "1400";
			this.LabelTotalOnline.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.OrangeDot.BackColor = global::System.Drawing.Color.Transparent;
			this.OrangeDot.BackgroundImage = global::blackrp_launcher.Properties.Resources.orange_dot;
			this.OrangeDot.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.OrangeDot.Location = new global::System.Drawing.Point(910, 490);
			this.OrangeDot.Name = "OrangeDot";
			this.OrangeDot.Size = new global::System.Drawing.Size(20, 20);
			this.OrangeDot.TabIndex = 15;
			this.OrangeDot.TabStop = false;
			this.ButtonServer1.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonServer1.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_server_1st;
			this.ButtonServer1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonServer1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonServer1.Location = new global::System.Drawing.Point(297, 516);
			this.ButtonServer1.Name = "ButtonServer1";
			this.ButtonServer1.Size = new global::System.Drawing.Size(217, 65);
			this.ButtonServer1.TabIndex = 16;
			this.ButtonServer1.TabStop = false;
			this.ButtonServer1.Click += new global::System.EventHandler(this.ButtonServer1_Click);
			this.ButtonServer1.MouseEnter += new global::System.EventHandler(this.ButtonServer1_MouseEnter);
			this.ButtonServer1.MouseLeave += new global::System.EventHandler(this.ButtonServer1_MouseLeave);
			this.ButtonServer2.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonServer2.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_server_2nd;
			this.ButtonServer2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonServer2.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonServer2.Location = new global::System.Drawing.Point(526, 516);
			this.ButtonServer2.Name = "ButtonServer2";
			this.ButtonServer2.Size = new global::System.Drawing.Size(217, 65);
			this.ButtonServer2.TabIndex = 17;
			this.ButtonServer2.TabStop = false;
			this.ButtonServer2.Click += new global::System.EventHandler(this.ButtonServer2_Click);
			this.ButtonServer2.MouseEnter += new global::System.EventHandler(this.ButtonServer2_MouseEnter);
			this.ButtonServer2.MouseLeave += new global::System.EventHandler(this.ButtonServer2_MouseLeave);
			this.ButtonServer3.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonServer3.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_server_test;
			this.ButtonServer3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonServer3.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonServer3.Location = new global::System.Drawing.Point(756, 516);
			this.ButtonServer3.Name = "ButtonServer3";
			this.ButtonServer3.Size = new global::System.Drawing.Size(217, 65);
			this.ButtonServer3.TabIndex = 18;
			this.ButtonServer3.TabStop = false;
			this.ButtonServer3.Click += new global::System.EventHandler(this.ButtonServer3_Click);
			this.ButtonServer3.MouseEnter += new global::System.EventHandler(this.ButtonServer3_MouseEnter);
			this.ButtonServer3.MouseLeave += new global::System.EventHandler(this.ButtonServer3_MouseLeave);
			this.LockServer1.BackColor = global::System.Drawing.Color.Transparent;
			this.LockServer1.BackgroundImage = global::blackrp_launcher.Properties.Resources.server_lock;
			this.LockServer1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.LockServer1.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.LockServer1.Location = new global::System.Drawing.Point(297, 516);
			this.LockServer1.Name = "LockServer1";
			this.LockServer1.Size = new global::System.Drawing.Size(217, 65);
			this.LockServer1.TabIndex = 19;
			this.LockServer1.TabStop = false;
			this.LockServer1.Visible = false;
			this.LockServer2.BackColor = global::System.Drawing.Color.Transparent;
			this.LockServer2.BackgroundImage = global::blackrp_launcher.Properties.Resources.server_lock;
			this.LockServer2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.LockServer2.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.LockServer2.Location = new global::System.Drawing.Point(526, 516);
			this.LockServer2.Name = "LockServer2";
			this.LockServer2.Size = new global::System.Drawing.Size(217, 65);
			this.LockServer2.TabIndex = 20;
			this.LockServer2.TabStop = false;
			this.LockServer2.Visible = false;
			this.LockServer3.BackColor = global::System.Drawing.Color.Transparent;
			this.LockServer3.BackgroundImage = global::blackrp_launcher.Properties.Resources.server_lock;
			this.LockServer3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.LockServer3.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.LockServer3.Location = new global::System.Drawing.Point(756, 516);
			this.LockServer3.Name = "LockServer3";
			this.LockServer3.Size = new global::System.Drawing.Size(217, 65);
			this.LockServer3.TabIndex = 21;
			this.LockServer3.TabStop = false;
			this.LockServer3.Visible = false;
			this.OrangeDotServer1.BackColor = global::System.Drawing.Color.Transparent;
			this.OrangeDotServer1.BackgroundImage = global::blackrp_launcher.Properties.Resources.orange_dot;
			this.OrangeDotServer1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.OrangeDotServer1.Location = new global::System.Drawing.Point(487, 537);
			this.OrangeDotServer1.Name = "OrangeDotServer1";
			this.OrangeDotServer1.Size = new global::System.Drawing.Size(20, 20);
			this.OrangeDotServer1.TabIndex = 22;
			this.OrangeDotServer1.TabStop = false;
			this.OrangeDotServer1.Click += new global::System.EventHandler(this.ButtonServer1_Click);
			this.OrangeDotServer1.MouseEnter += new global::System.EventHandler(this.ButtonServer1_MouseEnter);
			this.OrangeDotServer1.MouseLeave += new global::System.EventHandler(this.ButtonServer1_MouseLeave);
			this.LabelServer1Online.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelServer1Online.Font = new global::System.Drawing.Font("Montserrat Medium", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LabelServer1Online.ForeColor = global::System.Drawing.Color.White;
			this.LabelServer1Online.Location = new global::System.Drawing.Point(413, 537);
			this.LabelServer1Online.Margin = new global::System.Windows.Forms.Padding(0);
			this.LabelServer1Online.Name = "LabelServer1Online";
			this.LabelServer1Online.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.LabelServer1Online.Size = new global::System.Drawing.Size(75, 20);
			this.LabelServer1Online.TabIndex = 23;
			this.LabelServer1Online.Text = "700/700";
			this.LabelServer1Online.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.LabelServer1Online.Click += new global::System.EventHandler(this.ButtonServer1_Click);
			this.LabelServer1Online.MouseEnter += new global::System.EventHandler(this.ButtonServer1_MouseEnter);
			this.LabelServer1Online.MouseLeave += new global::System.EventHandler(this.ButtonServer1_MouseLeave);
			this.LabelServer2Online.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelServer2Online.Font = new global::System.Drawing.Font("Montserrat Medium", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LabelServer2Online.ForeColor = global::System.Drawing.Color.White;
			this.LabelServer2Online.Location = new global::System.Drawing.Point(641, 537);
			this.LabelServer2Online.Margin = new global::System.Windows.Forms.Padding(0);
			this.LabelServer2Online.Name = "LabelServer2Online";
			this.LabelServer2Online.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.LabelServer2Online.Size = new global::System.Drawing.Size(75, 20);
			this.LabelServer2Online.TabIndex = 25;
			this.LabelServer2Online.Text = "700/700";
			this.LabelServer2Online.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.LabelServer2Online.Click += new global::System.EventHandler(this.ButtonServer2_Click);
			this.LabelServer2Online.MouseEnter += new global::System.EventHandler(this.ButtonServer2_MouseEnter);
			this.LabelServer2Online.MouseLeave += new global::System.EventHandler(this.ButtonServer2_MouseLeave);
			this.OrangeDotServer2.BackColor = global::System.Drawing.Color.Transparent;
			this.OrangeDotServer2.BackgroundImage = global::blackrp_launcher.Properties.Resources.orange_dot;
			this.OrangeDotServer2.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.OrangeDotServer2.Location = new global::System.Drawing.Point(715, 537);
			this.OrangeDotServer2.Name = "OrangeDotServer2";
			this.OrangeDotServer2.Size = new global::System.Drawing.Size(20, 20);
			this.OrangeDotServer2.TabIndex = 24;
			this.OrangeDotServer2.TabStop = false;
			this.OrangeDotServer2.Click += new global::System.EventHandler(this.ButtonServer2_Click);
			this.OrangeDotServer2.MouseEnter += new global::System.EventHandler(this.ButtonServer2_MouseEnter);
			this.OrangeDotServer2.MouseLeave += new global::System.EventHandler(this.ButtonServer2_MouseLeave);
			this.LabelServer3Online.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelServer3Online.Font = new global::System.Drawing.Font("Montserrat Medium", 9.749999f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LabelServer3Online.ForeColor = global::System.Drawing.Color.White;
			this.LabelServer3Online.Location = new global::System.Drawing.Point(872, 537);
			this.LabelServer3Online.Margin = new global::System.Windows.Forms.Padding(0);
			this.LabelServer3Online.Name = "LabelServer3Online";
			this.LabelServer3Online.RightToLeft = global::System.Windows.Forms.RightToLeft.No;
			this.LabelServer3Online.Size = new global::System.Drawing.Size(75, 20);
			this.LabelServer3Online.TabIndex = 27;
			this.LabelServer3Online.Text = "0/20";
			this.LabelServer3Online.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.LabelServer3Online.Click += new global::System.EventHandler(this.ButtonServer3_Click);
			this.LabelServer3Online.MouseEnter += new global::System.EventHandler(this.ButtonServer3_MouseEnter);
			this.LabelServer3Online.MouseLeave += new global::System.EventHandler(this.ButtonServer3_MouseLeave);
			this.OrangeDotServer3.BackColor = global::System.Drawing.Color.Transparent;
			this.OrangeDotServer3.BackgroundImage = global::blackrp_launcher.Properties.Resources.orange_dot;
			this.OrangeDotServer3.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.OrangeDotServer3.Location = new global::System.Drawing.Point(946, 537);
			this.OrangeDotServer3.Name = "OrangeDotServer3";
			this.OrangeDotServer3.Size = new global::System.Drawing.Size(20, 20);
			this.OrangeDotServer3.TabIndex = 26;
			this.OrangeDotServer3.TabStop = false;
			this.OrangeDotServer3.Click += new global::System.EventHandler(this.ButtonServer3_Click);
			this.OrangeDotServer3.MouseEnter += new global::System.EventHandler(this.ButtonServer3_MouseEnter);
			this.OrangeDotServer3.MouseLeave += new global::System.EventHandler(this.ButtonServer3_MouseLeave);
			this.LabelStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelStatus.Font = new global::System.Drawing.Font("Montserrat", 11f);
			this.LabelStatus.ForeColor = global::System.Drawing.Color.White;
			this.LabelStatus.Location = new global::System.Drawing.Point(308, 600);
			this.LabelStatus.Name = "LabelStatus";
			this.LabelStatus.Size = new global::System.Drawing.Size(215, 25);
			this.LabelStatus.TabIndex = 28;
			this.LabelStatus.Text = "СОСИ!";
			this.LabelPercent.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelPercent.Font = new global::System.Drawing.Font("Montserrat SemiBold", 11f, global::System.Drawing.FontStyle.Bold);
			this.LabelPercent.ForeColor = global::System.Drawing.Color.White;
			this.LabelPercent.Location = new global::System.Drawing.Point(698, 600);
			this.LabelPercent.Margin = new global::System.Windows.Forms.Padding(0);
			this.LabelPercent.Name = "LabelPercent";
			this.LabelPercent.Size = new global::System.Drawing.Size(55, 25);
			this.LabelPercent.TabIndex = 29;
			this.LabelPercent.Text = "100%";
			this.LabelPercent.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.LabelSpeed.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelSpeed.Font = new global::System.Drawing.Font("Montserrat Light", 9f);
			this.LabelSpeed.ForeColor = global::System.Drawing.Color.DimGray;
			this.LabelSpeed.Location = new global::System.Drawing.Point(640, 650);
			this.LabelSpeed.Margin = new global::System.Windows.Forms.Padding(0);
			this.LabelSpeed.Name = "LabelSpeed";
			this.LabelSpeed.Size = new global::System.Drawing.Size(108, 25);
			this.LabelSpeed.TabIndex = 30;
			this.LabelSpeed.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.LabelSpeed.Visible = false;
			this.LabelAddtStatus.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelAddtStatus.Font = new global::System.Drawing.Font("Montserrat Light", 9f);
			this.LabelAddtStatus.ForeColor = global::System.Drawing.Color.DimGray;
			this.LabelAddtStatus.Location = new global::System.Drawing.Point(309, 650);
			this.LabelAddtStatus.Margin = new global::System.Windows.Forms.Padding(0);
			this.LabelAddtStatus.Name = "LabelAddtStatus";
			this.LabelAddtStatus.Size = new global::System.Drawing.Size(377, 25);
			this.LabelAddtStatus.TabIndex = 31;
			this.LabelAddtStatus.Visible = false;
			this.ButtonDownload.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonDownload.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_play;
			this.ButtonDownload.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonDownload.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonDownload.Location = new global::System.Drawing.Point(775, 590);
			this.ButtonDownload.Name = "ButtonDownload";
			this.ButtonDownload.Size = new global::System.Drawing.Size(198, 80);
			this.ButtonDownload.TabIndex = 32;
			this.ButtonDownload.TabStop = false;
			this.ButtonDownload.Click += new global::System.EventHandler(this.ButtonDownload_Click);
			this.ButtonDownload.MouseEnter += new global::System.EventHandler(this.ButtonDownload_MouseEnter);
			this.ButtonDownload.MouseLeave += new global::System.EventHandler(this.ButtonDownload_MouseLeave);
			this.LabelGUID.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelGUID.ForeColor = global::System.Drawing.Color.FromArgb(96, 96, 96);
			this.LabelGUID.Location = new global::System.Drawing.Point(487, 676);
			this.LabelGUID.Name = "LabelGUID";
			this.LabelGUID.Size = new global::System.Drawing.Size(488, 13);
			this.LabelGUID.TabIndex = 33;
			this.LabelGUID.Text = "ХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХХ";
			this.LabelGUID.TextAlign = global::System.Drawing.ContentAlignment.TopRight;
			this.LoadingBar.BackColor = global::System.Drawing.Color.Transparent;
			this.LoadingBar.BackgroundImage = global::blackrp_launcher.Properties.Resources.loading_bar;
			this.LoadingBar.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.LoadingBar.Location = new global::System.Drawing.Point(309, 639);
			this.LoadingBar.Name = "LoadingBar";
			this.LoadingBar.Size = new global::System.Drawing.Size(0, 8);
			this.LoadingBar.TabIndex = 34;
			this.LoadingBar.TabStop = false;
			this.UnPackingTimer.Interval = 800;
			this.UnPackingTimer.Tick += new global::System.EventHandler(this.UnPackingTimer_Tick);
			this.ButtonDiscord.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonDiscord.BackgroundImage = global::blackrp_launcher.Properties.Resources.icon_discord;
			this.ButtonDiscord.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonDiscord.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonDiscord.Location = new global::System.Drawing.Point(32, 468);
			this.ButtonDiscord.Name = "ButtonDiscord";
			this.ButtonDiscord.Size = new global::System.Drawing.Size(35, 35);
			this.ButtonDiscord.TabIndex = 35;
			this.ButtonDiscord.TabStop = false;
			this.ButtonDiscord.Click += new global::System.EventHandler(this.ButtonDiscord_Click);
			this.ButtonDiscord.MouseEnter += new global::System.EventHandler(this.ButtonDiscord_MouseEnter);
			this.ButtonDiscord.MouseLeave += new global::System.EventHandler(this.ButtonDiscord_MouseLeave);
			this.ButtonInstagram.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonInstagram.BackgroundImage = global::blackrp_launcher.Properties.Resources.icon_instagram;
			this.ButtonInstagram.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonInstagram.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonInstagram.Location = new global::System.Drawing.Point(32, 509);
			this.ButtonInstagram.Name = "ButtonInstagram";
			this.ButtonInstagram.Size = new global::System.Drawing.Size(35, 35);
			this.ButtonInstagram.TabIndex = 36;
			this.ButtonInstagram.TabStop = false;
			this.ButtonInstagram.Click += new global::System.EventHandler(this.ButtonInstagram_Click);
			this.ButtonInstagram.MouseEnter += new global::System.EventHandler(this.ButtonInstagram_MouseEnter);
			this.ButtonInstagram.MouseLeave += new global::System.EventHandler(this.ButtonInstagram_MouseLeave);
			this.ButtonYoutube.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonYoutube.BackgroundImage = global::blackrp_launcher.Properties.Resources.icon_youtube;
			this.ButtonYoutube.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonYoutube.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonYoutube.Location = new global::System.Drawing.Point(32, 550);
			this.ButtonYoutube.Name = "ButtonYoutube";
			this.ButtonYoutube.Size = new global::System.Drawing.Size(35, 35);
			this.ButtonYoutube.TabIndex = 37;
			this.ButtonYoutube.TabStop = false;
			this.ButtonYoutube.Click += new global::System.EventHandler(this.ButtonYoutube_Click);
			this.ButtonYoutube.MouseEnter += new global::System.EventHandler(this.ButtonYoutube_MouseEnter);
			this.ButtonYoutube.MouseLeave += new global::System.EventHandler(this.ButtonYoutube_MouseLeave);
			this.ButtonTelegram.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonTelegram.BackgroundImage = global::blackrp_launcher.Properties.Resources.icon_telegram;
			this.ButtonTelegram.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonTelegram.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonTelegram.Location = new global::System.Drawing.Point(32, 591);
			this.ButtonTelegram.Name = "ButtonTelegram";
			this.ButtonTelegram.Size = new global::System.Drawing.Size(35, 35);
			this.ButtonTelegram.TabIndex = 38;
			this.ButtonTelegram.TabStop = false;
			this.ButtonTelegram.Click += new global::System.EventHandler(this.ButtonTelegram_Click);
			this.ButtonTelegram.MouseEnter += new global::System.EventHandler(this.ButtonTelegram_MouseEnter);
			this.ButtonTelegram.MouseLeave += new global::System.EventHandler(this.ButtonTelegram_MouseLeave);
			this.ButtonTiktok.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonTiktok.BackgroundImage = global::blackrp_launcher.Properties.Resources.icon_tiktok;
			this.ButtonTiktok.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonTiktok.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonTiktok.Location = new global::System.Drawing.Point(32, 632);
			this.ButtonTiktok.Name = "ButtonTiktok";
			this.ButtonTiktok.Size = new global::System.Drawing.Size(35, 35);
			this.ButtonTiktok.TabIndex = 39;
			this.ButtonTiktok.TabStop = false;
			this.ButtonTiktok.Click += new global::System.EventHandler(this.ButtonTiktok_Click);
			this.ButtonTiktok.MouseEnter += new global::System.EventHandler(this.ButtonTiktok_MouseEnter);
			this.ButtonTiktok.MouseLeave += new global::System.EventHandler(this.ButtonTiktok_MouseLeave);
			this.TimerLoadWindow.Interval = 1;
			this.TimerLoadWindow.Tick += new global::System.EventHandler(this.TimerLoadWindow_Tick);
			this.LabelVersion.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelVersion.ForeColor = global::System.Drawing.Color.FromArgb(96, 96, 96);
			this.LabelVersion.Location = new global::System.Drawing.Point(294, 676);
			this.LabelVersion.Name = "LabelVersion";
			this.LabelVersion.Size = new global::System.Drawing.Size(204, 13);
			this.LabelVersion.TabIndex = 40;
			this.LabelVersion.Text = "0.0.0";
			this.notifyIcon.BalloonTipIcon = global::System.Windows.Forms.ToolTipIcon.Info;
			this.notifyIcon.Icon = this.notifyIcon.Icon;
			this.notifyIcon.Text = "BLACK-RP";
			this.notifyIcon.Visible = true;
			this.ButtonPlay.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonPlay.BackgroundImage = global::blackrp_launcher.Properties.Resources.button_play;
			this.ButtonPlay.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonPlay.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonPlay.Location = new global::System.Drawing.Point(775, 590);
			this.ButtonPlay.Name = "ButtonPlay";
			this.ButtonPlay.Size = new global::System.Drawing.Size(198, 80);
			this.ButtonPlay.TabIndex = 41;
			this.ButtonPlay.TabStop = false;
			this.ButtonPlay.Click += new global::System.EventHandler(this.ButtonPlay_Click);
			this.ButtonPlay.MouseEnter += new global::System.EventHandler(this.ButtonPlay_MouseEnter);
			this.ButtonPlay.MouseLeave += new global::System.EventHandler(this.ButtonPlay_MouseLeave);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Black;
			this.BackgroundImage = global::blackrp_launcher.Properties.Resources.main_window_background;
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(1000, 700);
			base.ControlBox = false;
			base.Controls.Add(this.ButtonPlay);
			base.Controls.Add(this.LabelVersion);
			base.Controls.Add(this.ButtonTiktok);
			base.Controls.Add(this.ButtonTelegram);
			base.Controls.Add(this.LoadingBar);
			base.Controls.Add(this.LabelGUID);
			base.Controls.Add(this.ButtonDownload);
			base.Controls.Add(this.LabelAddtStatus);
			base.Controls.Add(this.LabelSpeed);
			base.Controls.Add(this.LabelPercent);
			base.Controls.Add(this.LabelStatus);
			base.Controls.Add(this.LabelServer3Online);
			base.Controls.Add(this.OrangeDotServer3);
			base.Controls.Add(this.LabelServer2Online);
			base.Controls.Add(this.OrangeDotServer2);
			base.Controls.Add(this.LabelServer1Online);
			base.Controls.Add(this.OrangeDotServer1);
			base.Controls.Add(this.LockServer3);
			base.Controls.Add(this.LockServer2);
			base.Controls.Add(this.LockServer1);
			base.Controls.Add(this.ButtonServer3);
			base.Controls.Add(this.ButtonServer2);
			base.Controls.Add(this.ButtonServer1);
			base.Controls.Add(this.OrangeDot);
			base.Controls.Add(this.LabelTotalOnline);
			base.Controls.Add(this.LabelOnline);
			base.Controls.Add(this.LabelServers);
			base.Controls.Add(this.News3);
			base.Controls.Add(this.News2);
			base.Controls.Add(this.News1);
			base.Controls.Add(this.LabelNews);
			base.Controls.Add(this.ButtonOpenSite);
			base.Controls.Add(this.ButtonOpenForum);
			base.Controls.Add(this.ButtonOpenDonate);
			base.Controls.Add(this.ButtonOpenCabinet);
			base.Controls.Add(this.ButtonOpenSettings);
			base.Controls.Add(this.ButtonMinimizeApp);
			base.Controls.Add(this.ButtonCloseApp);
			this.DoubleBuffered = true;
			this.Font = new global::System.Drawing.Font("Montserrat", 8.249999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "MainWindow";
			base.Opacity = 0.0;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "BLACK RP";
			base.TransparencyKey = global::System.Drawing.Color.Navy;
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.MainWindow_MouseDown);
			((global::System.ComponentModel.ISupportInitialize)this.ButtonCloseApp).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonMinimizeApp).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenSettings).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenCabinet).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenDonate).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenForum).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonOpenSite).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.News1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.News2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.News3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDot).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonServer1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonServer2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonServer3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.LockServer1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.LockServer2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.LockServer3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDotServer1).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDotServer2).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.OrangeDotServer3).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonDownload).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.LoadingBar).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonDiscord).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonInstagram).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonYoutube).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonTelegram).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonTiktok).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonPlay).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000036 RID: 54
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.PictureBox ButtonCloseApp;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.PictureBox ButtonMinimizeApp;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.PictureBox ButtonOpenSettings;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.PictureBox ButtonOpenCabinet;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.PictureBox ButtonOpenDonate;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.PictureBox ButtonOpenForum;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.PictureBox ButtonOpenSite;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.Label LabelNews;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.PictureBox News1;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.PictureBox News2;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.PictureBox News3;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label LabelServers;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Label LabelOnline;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label LabelTotalOnline;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.PictureBox OrangeDot;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.PictureBox ButtonServer1;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.PictureBox ButtonServer2;

		// Token: 0x04000048 RID: 72
		private global::System.Windows.Forms.PictureBox ButtonServer3;

		// Token: 0x04000049 RID: 73
		private global::System.Windows.Forms.PictureBox LockServer1;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.PictureBox LockServer2;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.PictureBox LockServer3;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.PictureBox OrangeDotServer1;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Label LabelServer1Online;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Label LabelServer2Online;

		// Token: 0x0400004F RID: 79
		private global::System.Windows.Forms.PictureBox OrangeDotServer2;

		// Token: 0x04000050 RID: 80
		private global::System.Windows.Forms.Label LabelServer3Online;

		// Token: 0x04000051 RID: 81
		private global::System.Windows.Forms.PictureBox OrangeDotServer3;

		// Token: 0x04000052 RID: 82
		private global::System.Windows.Forms.Label LabelStatus;

		// Token: 0x04000053 RID: 83
		private global::System.Windows.Forms.Label LabelPercent;

		// Token: 0x04000054 RID: 84
		private global::System.Windows.Forms.Label LabelSpeed;

		// Token: 0x04000055 RID: 85
		private global::System.Windows.Forms.Label LabelAddtStatus;

		// Token: 0x04000056 RID: 86
		private global::System.Windows.Forms.PictureBox ButtonDownload;

		// Token: 0x04000057 RID: 87
		private global::System.Windows.Forms.Label LabelGUID;

		// Token: 0x04000058 RID: 88
		private global::System.Windows.Forms.PictureBox LoadingBar;

		// Token: 0x04000059 RID: 89
		private global::System.Windows.Forms.Timer UnPackingTimer;

		// Token: 0x0400005A RID: 90
		private global::System.Windows.Forms.PictureBox ButtonDiscord;

		// Token: 0x0400005B RID: 91
		private global::System.Windows.Forms.PictureBox ButtonInstagram;

		// Token: 0x0400005C RID: 92
		private global::System.Windows.Forms.PictureBox ButtonYoutube;

		// Token: 0x0400005D RID: 93
		private global::System.Windows.Forms.PictureBox ButtonTelegram;

		// Token: 0x0400005E RID: 94
		private global::System.Windows.Forms.PictureBox ButtonTiktok;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Timer TimerLoadWindow;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Label LabelVersion;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.NotifyIcon notifyIcon;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.PictureBox ButtonPlay;
	}
}
