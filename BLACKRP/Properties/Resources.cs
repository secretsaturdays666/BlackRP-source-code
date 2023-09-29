using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace blackrp_launcher.Properties
{
	// Token: 0x02000013 RID: 19
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	public class Resources
	{
		// Token: 0x060000B9 RID: 185 RVA: 0x0000265A File Offset: 0x0000085A
		internal Resources()
		{
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000A370 File Offset: 0x00008570
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Resources.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("blackrp_launcher.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000BB RID: 187 RVA: 0x0000A3B8 File Offset: 0x000085B8
		// (set) Token: 0x060000BC RID: 188 RVA: 0x00002664 File Offset: 0x00000864
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000BD RID: 189 RVA: 0x0000A3D0 File Offset: 0x000085D0
		public static Bitmap button_close_app
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_close_app", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000A400 File Offset: 0x00008600
		public static Bitmap button_download
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_download", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000BF RID: 191 RVA: 0x0000A430 File Offset: 0x00008630
		public static Bitmap button_download_active
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_download_active", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x0000A460 File Offset: 0x00008660
		public static Bitmap button_download_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_download_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000C1 RID: 193 RVA: 0x0000A490 File Offset: 0x00008690
		public static Bitmap button_minimize_app
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_minimize_app", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x0000A4C0 File Offset: 0x000086C0
		public static Bitmap button_open_cabinet
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_cabinet", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000C3 RID: 195 RVA: 0x0000A4F0 File Offset: 0x000086F0
		public static Bitmap button_open_cabinet_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_cabinet_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x0000A520 File Offset: 0x00008720
		public static Bitmap button_open_donate
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_donate", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000C5 RID: 197 RVA: 0x0000A550 File Offset: 0x00008750
		public static Bitmap button_open_donate_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_donate_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060000C6 RID: 198 RVA: 0x0000A580 File Offset: 0x00008780
		public static Bitmap button_open_forum
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_forum", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060000C7 RID: 199 RVA: 0x0000A5B0 File Offset: 0x000087B0
		public static Bitmap button_open_forum_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_forum_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060000C8 RID: 200 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public static Bitmap button_open_settings
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_settings", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060000C9 RID: 201 RVA: 0x0000A610 File Offset: 0x00008810
		public static Bitmap button_open_site
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_site", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060000CA RID: 202 RVA: 0x0000A640 File Offset: 0x00008840
		public static Bitmap button_open_site_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_open_site_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060000CB RID: 203 RVA: 0x0000A670 File Offset: 0x00008870
		public static Bitmap button_play
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_play", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000A6A0 File Offset: 0x000088A0
		public static Bitmap button_play_active
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_play_active", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x060000CD RID: 205 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public static Bitmap button_play_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_play_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060000CE RID: 206 RVA: 0x0000A700 File Offset: 0x00008900
		public static Bitmap button_server_1st
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_1st", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060000CF RID: 207 RVA: 0x0000A730 File Offset: 0x00008930
		public static Bitmap button_server_1st_active
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_1st_active", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000D0 RID: 208 RVA: 0x0000A760 File Offset: 0x00008960
		public static Bitmap button_server_1st_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_1st_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000D1 RID: 209 RVA: 0x0000A790 File Offset: 0x00008990
		public static Bitmap button_server_2nd
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_2nd", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000D2 RID: 210 RVA: 0x0000A7C0 File Offset: 0x000089C0
		public static Bitmap button_server_2nd_active
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_2nd_active", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000D3 RID: 211 RVA: 0x0000A7F0 File Offset: 0x000089F0
		public static Bitmap button_server_2nd_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_2nd_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x0000A820 File Offset: 0x00008A20
		public static Bitmap button_server_test
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_test", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x0000A850 File Offset: 0x00008A50
		public static Bitmap button_server_test_active
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_test_active", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x0000A880 File Offset: 0x00008A80
		public static Bitmap button_server_test_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("button_server_test_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x0000A8B0 File Offset: 0x00008AB0
		public static Bitmap icon_discord
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_discord", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000D8 RID: 216 RVA: 0x0000A8E0 File Offset: 0x00008AE0
		public static Bitmap icon_discord_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_discord_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000D9 RID: 217 RVA: 0x0000A910 File Offset: 0x00008B10
		public static Bitmap icon_instagram
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_instagram", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000DA RID: 218 RVA: 0x0000A940 File Offset: 0x00008B40
		public static Bitmap icon_instagram_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_instagram_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000DB RID: 219 RVA: 0x0000A970 File Offset: 0x00008B70
		public static Bitmap icon_telegram
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_telegram", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000DC RID: 220 RVA: 0x0000A9A0 File Offset: 0x00008BA0
		public static Bitmap icon_telegram_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_telegram_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000DD RID: 221 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		public static Bitmap icon_tiktok
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_tiktok", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000DE RID: 222 RVA: 0x0000AA00 File Offset: 0x00008C00
		public static Bitmap icon_tiktok_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_tiktok_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000DF RID: 223 RVA: 0x0000AA30 File Offset: 0x00008C30
		public static Bitmap icon_youtube
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_youtube", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000E0 RID: 224 RVA: 0x0000AA60 File Offset: 0x00008C60
		public static Bitmap icon_youtube_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("icon_youtube_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000AA90 File Offset: 0x00008C90
		public static Bitmap loading_bar
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("loading_bar", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x0000AAC0 File Offset: 0x00008CC0
		public static Bitmap main_window_background
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("main_window_background", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000AAF0 File Offset: 0x00008CF0
		public static Bitmap news_1st
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("news_1st", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000E4 RID: 228 RVA: 0x0000AB20 File Offset: 0x00008D20
		public static Bitmap news_1st_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("news_1st_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000AB50 File Offset: 0x00008D50
		public static Bitmap news_2nd
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("news_2nd", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000E6 RID: 230 RVA: 0x0000AB80 File Offset: 0x00008D80
		public static Bitmap news_2nd_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("news_2nd_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000ABB0 File Offset: 0x00008DB0
		public static Bitmap news_3rd
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("news_3rd", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000E8 RID: 232 RVA: 0x0000ABE0 File Offset: 0x00008DE0
		public static Bitmap news_3rd_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("news_3rd_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000AC10 File Offset: 0x00008E10
		public static Bitmap orange_dot
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("orange_dot", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060000EA RID: 234 RVA: 0x0000AC40 File Offset: 0x00008E40
		public static Bitmap server_lock
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("server_lock", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000AC70 File Offset: 0x00008E70
		public static Bitmap settings_button_close
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_button_close", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060000EC RID: 236 RVA: 0x0000ACA0 File Offset: 0x00008EA0
		public static Bitmap settings_button_login
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_button_login", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000ACD0 File Offset: 0x00008ED0
		public static Bitmap settings_button_reinstall
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_button_reinstall", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000EE RID: 238 RVA: 0x0000AD00 File Offset: 0x00008F00
		public static Bitmap settings_button_reinstall_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_button_reinstall_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000AD30 File Offset: 0x00008F30
		public static Bitmap settings_button_support
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_button_support", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060000F0 RID: 240 RVA: 0x0000AD60 File Offset: 0x00008F60
		public static Bitmap settings_button_support_hover
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("settings_button_support_hover", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000AD90 File Offset: 0x00008F90
		public static Bitmap window_settings_background
		{
			get
			{
				object @object = Resources.ResourceManager.GetObject("window_settings_background", Resources.resourceCulture);
				return (Bitmap)@object;
			}
		}

		// Token: 0x04000092 RID: 146
		private static ResourceManager resourceMan;

		// Token: 0x04000093 RID: 147
		private static CultureInfo resourceCulture;
	}
}
