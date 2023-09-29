namespace blackrp_launcher
{
	public partial class SettingsWindow : global::System.Windows.Forms.Form
	{
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::blackrp_launcher.SettingsWindow));
			this.ButtonClose = new global::System.Windows.Forms.PictureBox();
			this.LabelTitle = new global::System.Windows.Forms.Label();
			this.ButtonSupport = new global::System.Windows.Forms.PictureBox();
			this.ButtonReinstall = new global::System.Windows.Forms.PictureBox();
			this.LinkOffert = new global::System.Windows.Forms.Label();
			this.LinkTerms = new global::System.Windows.Forms.Label();
			this.LinkPolicy = new global::System.Windows.Forms.Label();
			this.LabelTitleLogin = new global::System.Windows.Forms.Label();
			this.ButtonLogin = new global::System.Windows.Forms.PictureBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.TimerLoadWindow = new global::System.Windows.Forms.Timer(this.components);
			((global::System.ComponentModel.ISupportInitialize)this.ButtonClose).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonSupport).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonReinstall).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonLogin).BeginInit();
			base.SuspendLayout();
			this.ButtonClose.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonClose.BackgroundImage = global::blackrp_launcher.Properties.Resources.settings_button_close;
			this.ButtonClose.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonClose.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonClose.Location = new global::System.Drawing.Point(466, 10);
			this.ButtonClose.Name = "ButtonClose";
			this.ButtonClose.Size = new global::System.Drawing.Size(25, 25);
			this.ButtonClose.TabIndex = 0;
			this.ButtonClose.TabStop = false;
			this.ButtonClose.Click += new global::System.EventHandler(this.ButtonClose_Click);
			this.LabelTitle.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelTitle.Font = new global::System.Drawing.Font("Montserrat SemiBold", 12f, global::System.Drawing.FontStyle.Bold);
			this.LabelTitle.ForeColor = global::System.Drawing.Color.White;
			this.LabelTitle.Location = new global::System.Drawing.Point(35, 9);
			this.LabelTitle.Name = "LabelTitle";
			this.LabelTitle.Size = new global::System.Drawing.Size(161, 22);
			this.LabelTitle.TabIndex = 1;
			this.LabelTitle.Text = "Настройки";
			this.ButtonSupport.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonSupport.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("ButtonSupport.BackgroundImage");
			this.ButtonSupport.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonSupport.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonSupport.Location = new global::System.Drawing.Point(10, 52);
			this.ButtonSupport.Name = "ButtonSupport";
			this.ButtonSupport.Size = new global::System.Drawing.Size(480, 50);
			this.ButtonSupport.TabIndex = 2;
			this.ButtonSupport.TabStop = false;
			this.ButtonSupport.Click += new global::System.EventHandler(this.ButtonSupport_Click);
			this.ButtonSupport.MouseEnter += new global::System.EventHandler(this.ButtonSupport_MouseEnter);
			this.ButtonSupport.MouseLeave += new global::System.EventHandler(this.ButtonSupport_MouseLeave);
			this.ButtonReinstall.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonReinstall.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("ButtonReinstall.BackgroundImage");
			this.ButtonReinstall.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonReinstall.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.ButtonReinstall.Location = new global::System.Drawing.Point(10, 108);
			this.ButtonReinstall.Name = "ButtonReinstall";
			this.ButtonReinstall.Size = new global::System.Drawing.Size(480, 50);
			this.ButtonReinstall.TabIndex = 3;
			this.ButtonReinstall.TabStop = false;
			this.ButtonReinstall.Click += new global::System.EventHandler(this.ButtonReinstall_Click);
			this.ButtonReinstall.MouseEnter += new global::System.EventHandler(this.ButtonReinstall_MouseEnter);
			this.ButtonReinstall.MouseLeave += new global::System.EventHandler(this.ButtonReinstall_MouseLeave);
			this.LinkOffert.BackColor = global::System.Drawing.Color.Transparent;
			this.LinkOffert.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.LinkOffert.Font = new global::System.Drawing.Font("Montserrat", 9.749999f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LinkOffert.ForeColor = global::System.Drawing.Color.DarkGray;
			this.LinkOffert.Location = new global::System.Drawing.Point(149, 168);
			this.LinkOffert.Name = "LinkOffert";
			this.LinkOffert.Size = new global::System.Drawing.Size(114, 18);
			this.LinkOffert.TabIndex = 4;
			this.LinkOffert.Text = "Оферта";
			this.LinkOffert.Click += new global::System.EventHandler(this.LinkOffert_Click);
			this.LinkTerms.BackColor = global::System.Drawing.Color.Transparent;
			this.LinkTerms.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.LinkTerms.Font = new global::System.Drawing.Font("Montserrat", 9.749999f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LinkTerms.ForeColor = global::System.Drawing.Color.DarkGray;
			this.LinkTerms.Location = new global::System.Drawing.Point(7, 168);
			this.LinkTerms.Name = "LinkTerms";
			this.LinkTerms.Size = new global::System.Drawing.Size(136, 18);
			this.LinkTerms.TabIndex = 5;
			this.LinkTerms.Text = "Соглашение";
			this.LinkTerms.Click += new global::System.EventHandler(this.LabelSuccess_Click);
			this.LinkPolicy.BackColor = global::System.Drawing.Color.Transparent;
			this.LinkPolicy.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.LinkPolicy.Font = new global::System.Drawing.Font("Montserrat", 9.749999f, global::System.Drawing.FontStyle.Underline, global::System.Drawing.GraphicsUnit.Point, 204);
			this.LinkPolicy.ForeColor = global::System.Drawing.Color.DarkGray;
			this.LinkPolicy.Location = new global::System.Drawing.Point(269, 168);
			this.LinkPolicy.Name = "LinkPolicy";
			this.LinkPolicy.Size = new global::System.Drawing.Size(224, 18);
			this.LinkPolicy.TabIndex = 6;
			this.LinkPolicy.Text = "Политика";
			this.LinkPolicy.Click += new global::System.EventHandler(this.LinkPolicy_Click);
			this.LabelTitleLogin.AutoSize = true;
			this.LabelTitleLogin.BackColor = global::System.Drawing.Color.Transparent;
			this.LabelTitleLogin.Font = new global::System.Drawing.Font("Montserrat SemiBold", 10f, global::System.Drawing.FontStyle.Bold);
			this.LabelTitleLogin.ForeColor = global::System.Drawing.Color.White;
			this.LabelTitleLogin.Location = new global::System.Drawing.Point(6, 201);
			this.LabelTitleLogin.Name = "LabelTitleLogin";
			this.LabelTitleLogin.Size = new global::System.Drawing.Size(288, 20);
			this.LabelTitleLogin.TabIndex = 7;
			this.LabelTitleLogin.Text = "ЛИЧНЫЙ КАБИНЕТ";
			this.ButtonLogin.BackColor = global::System.Drawing.Color.Transparent;
			this.ButtonLogin.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("ButtonLogin.BackgroundImage");
			this.ButtonLogin.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.ButtonLogin.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.ButtonLogin.Enabled = false;
			this.ButtonLogin.Location = new global::System.Drawing.Point(10, 349);
			this.ButtonLogin.Name = "ButtonLogin";
			this.ButtonLogin.Size = new global::System.Drawing.Size(480, 50);
			this.ButtonLogin.TabIndex = 8;
			this.ButtonLogin.TabStop = false;
			this.label5.BackColor = global::System.Drawing.Color.Transparent;
			this.label5.Font = new global::System.Drawing.Font("Montserrat SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 204);
			this.label5.ForeColor = global::System.Drawing.Color.DimGray;
			this.label5.Location = new global::System.Drawing.Point(22, 301);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(70, 21);
			this.label5.TabIndex = 10;
			this.label5.Text = "Пароль";
			this.TimerLoadWindow.Interval = 50;
			this.TimerLoadWindow.Tick += new global::System.EventHandler(this.TimerLoadWindow_Tick);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = global::System.Drawing.Color.Navy;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			base.ClientSize = new global::System.Drawing.Size(500, 193);
			base.ControlBox = false;
			base.Controls.Add(this.label5);
			base.Controls.Add(this.ButtonLogin);
			base.Controls.Add(this.LabelTitleLogin);
			base.Controls.Add(this.LinkPolicy);
			base.Controls.Add(this.LinkTerms);
			base.Controls.Add(this.LinkOffert);
			base.Controls.Add(this.ButtonReinstall);
			base.Controls.Add(this.ButtonSupport);
			base.Controls.Add(this.LabelTitle);
			base.Controls.Add(this.ButtonClose);
			this.DoubleBuffered = true;
			this.Font = new global::System.Drawing.Font("Montserrat", 8.249999f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 204);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4, 3, 4, 3);
			base.Name = "SettingsWindow";
			base.Opacity = 0.0;
			base.ShowInTaskbar = false;
			base.SizeGripStyle = global::System.Windows.Forms.SizeGripStyle.Hide;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Настройки";
			base.TransparencyKey = global::System.Drawing.Color.Navy;
			base.Load += new global::System.EventHandler(this.SettingsWindow_Load);
			base.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.SettingsWindow_MouseDown);
			((global::System.ComponentModel.ISupportInitialize)this.ButtonClose).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonSupport).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonReinstall).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.ButtonLogin).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		private global::System.ComponentModel.IContainer components;

		private global::System.Windows.Forms.PictureBox ButtonClose;

		private global::System.Windows.Forms.Label LabelTitle;

		private global::System.Windows.Forms.PictureBox ButtonSupport;

		private global::System.Windows.Forms.PictureBox ButtonReinstall;

		private global::System.Windows.Forms.Label LinkOffert;

		private global::System.Windows.Forms.Label LinkTerms;

		private global::System.Windows.Forms.Label LinkPolicy;

		private global::System.Windows.Forms.Label LabelTitleLogin;

		private global::System.Windows.Forms.PictureBox ButtonLogin;

		private global::System.Windows.Forms.Label label5;

		private global::System.Windows.Forms.Timer TimerLoadWindow;
	}
}
