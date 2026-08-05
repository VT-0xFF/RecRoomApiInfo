using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2IlInjected;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.NoEngine.Logging;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_NoEngine_Logging_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x9B341C0", Offset = "0x9B32BC0", VA = "0x189B341C0", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public readonly struct Log
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public static readonly Log Invalid;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public int Index
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0xF8BD10", Offset = "0xF8A710", VA = "0x180F8BD10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PTLSDVPWRDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9B35F00", Offset = "0x9B34900", VA = "0x189B35F00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool EARLASKJCJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9B36140", Offset = "0x9B34B40", VA = "0x189B36140")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string YIQIZCZRVIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x9B365D0", Offset = "0x9B34FD0", VA = "0x189B365D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FGCJYTKVFEA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6913E90", Offset = "0x6912890", VA = "0x186913E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel MVUJCIOCPMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9B35E90", Offset = "0x9B34890", VA = "0x189B35E90")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9B36EE0", Offset = "0x9B358E0", VA = "0x189B36EE0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15EA980", Offset = "0x15E9380", VA = "0x1815EA980")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B36F40", Offset = "0x9B35940", VA = "0x189B36F40")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C2B320", Offset = "0x3C29D20", VA = "0x183C2B320")]
		public void ISNCDANPQPK<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9B35C70", Offset = "0x9B34670", VA = "0x189B35C70")]
		public void ISNCDANPQPK(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9B35D90", Offset = "0x9B34790", VA = "0x189B35D90")]
		public void ISNCDANPQPK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C306F0", Offset = "0x3C2F0F0", VA = "0x183C306F0")]
		public void ZTMDGYCALYD<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9B36DC0", Offset = "0x9B357C0", VA = "0x189B36DC0")]
		public void ZTMDGYCALYD(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C2EA50", Offset = "0x3C2D450", VA = "0x183C2EA50")]
		public void PBOZSOOQQSE<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9B363B0", Offset = "0x9B34DB0", VA = "0x189B363B0")]
		public void PBOZSOOQQSE(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9B364D0", Offset = "0x9B34ED0", VA = "0x189B364D0")]
		public void PBOZSOOQQSE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C26850", Offset = "0x3C25250", VA = "0x183C26850")]
		public void CZOHQYZUKAH<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9B356B0", Offset = "0x9B340B0", VA = "0x189B356B0")]
		public void CZOHQYZUKAH(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9B355A0", Offset = "0x9B33FA0", VA = "0x189B355A0")]
		public void CZOHQYZUKAH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C2F3B0", Offset = "0x3C2DDB0", VA = "0x183C2F3B0")]
		public void UXPWTIRECES<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9B36690", Offset = "0x9B35090", VA = "0x189B36690")]
		public void UXPWTIRECES(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9B36790", Offset = "0x9B35190", VA = "0x189B36790")]
		public void UXPWTIRECES(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C2DF60", Offset = "0x3C2C960", VA = "0x183C2DF60")]
		public void MKSVXLZCLJP<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9B35F50", Offset = "0x9B34950", VA = "0x189B35F50")]
		public void MKSVXLZCLJP(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9B36050", Offset = "0x9B34A50", VA = "0x189B36050")]
		public void MKSVXLZCLJP(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C302C0", Offset = "0x3C2ECC0", VA = "0x183C302C0")]
		public void XXUIULOCZLY<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9B36960", Offset = "0x9B35360", VA = "0x189B36960")]
		public void XXUIULOCZLY(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B36870", Offset = "0x9B35270", VA = "0x189B36870")]
		public void XXUIULOCZLY(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B36620", Offset = "0x9B35020", VA = "0x189B36620")]
		public void RQQCILMSQKV(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B35900", Offset = "0x9B34300", VA = "0x189B35900")]
		public void GGWTQJPOMZE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C2E440", Offset = "0x3C2CE40", VA = "0x183C2E440")]
		public LogRangeScope OZGFYEWMVFT<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LogRangeScope WCGSVBHSERO<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B36290", Offset = "0x9B34C90", VA = "0x189B36290")]
		public LogRangeScope OZGFYEWMVFT(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B36190", Offset = "0x9B34B90", VA = "0x189B36190")]
		public LogRangeScope OZGFYEWMVFT(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1125AF0", Offset = "0x11244F0", VA = "0x181125AF0")]
		public LogRangeScope WCGSVBHSERO(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9B35B90", Offset = "0x9B34590", VA = "0x189B35B90")]
		public void HPMFTMJSIBL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B35970", Offset = "0x9B34370", VA = "0x189B35970")]
		public void HPMFTMJSIBL(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C29840", Offset = "0x3C28240", VA = "0x183C29840")]
		public void HPMFTMJSIBL<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		public void SQJGKAVCBNA([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B357E0", Offset = "0x9B341E0", VA = "0x189B357E0")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9B36A60", Offset = "0x9B35460", VA = "0x189B36A60")]
		private static void YHMHOEPLRTM(Exception a, StringBuilder b, int c = 0, int d = 5)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class Logs
	{
		[Cpp2IlInjected.Token(Token = "0x2000005")]
		public static class Teams
		{
			[Cpp2IlInjected.Token(Token = "0x4000003")]
			public static readonly Log LOGNVFGBWJS;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log TYADPSQAVLZ;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log GVVANYTEDDV;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log CORSISHLTOY;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log IONDNHXDBLE;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log HKQQSNVNLKC;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log QDZLVEUKIXD;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log ETODUPWMXLM;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log WEZVZOQODMH;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log TKRDIMJTJTY;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log VCNBAYQHRRC;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log ZXSHWATGGDW;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log RNNATAFUKMC;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log POGNNQLPJSX;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log ZOBZYEWFXMB;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log UQTJHSIPBSJ;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log NXXUIVUKATN;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log JAUXZAAPQQM;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log GZQNTHHRBKP;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log LIELVQMRXXH;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log FEUUIAUSSSX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public static class AI
		{
			[Cpp2IlInjected.Token(Token = "0x2000007")]
			public static class MakerAI
			{
				[Cpp2IlInjected.Token(Token = "0x2000008")]
				public static class Command
				{
					[Cpp2IlInjected.Token(Token = "0x4000021")]
					public static readonly Log KUOHMDAOENP;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log GHJOVPJRIAV;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log KDMJGWVDBFB;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log IGLINQVWMTQ;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log SZJGQSSPUJS;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log CFGPIWWKEWS;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log RPQZVERHRDG;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log DSLPHUROLGM;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log KDMJGWVDBFB;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log SZJGQSSPUJS;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log CFGPIWWKEWS;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log UUHLVRIGEIZ;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log PHZGNPFOSNS;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log LXOXFKIBSKU;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log ERQOABESJVU;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log UZQYDUQOUIH;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log KUOHMDAOENP;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log GHSMHFPLQXD;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log GHNFJYVOHLU;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log GHHYMSBQYAL;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log GHCRPLHTOPC;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log GINNWGRBCQN;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log GIIGYZXDTFE;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log GIDABTDGJTV;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log GHXTEMJJAIM;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log GGCJDDMGTKJ;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log GFXCFWSJJZA;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log KUOHMDAOENP;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log GHSMHFPLQXD;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log GHNFJYVOHLU;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log GHHYMSBQYAL;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log GHCRPLHTOPC;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log GINNWGRBCQN;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log GIIGYZXDTFE;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log GIDABTDGJTV;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log GHXTEMJJAIM;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log GGCJDDMGTKJ;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log GFXCFWSJJZA;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log KUOHMDAOENP;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log AEFAUFYGCGB;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log BOLJCRRITKD;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log NEFYCIQSCYL;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log BWNTMODLSVR;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log AVYFRODHCOM;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log XNMERPKQYNM;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log WDWORZWOUQL;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log KFHSYWIXARG;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log AEMAGMWCKHF;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log JYNWTXDDWYV;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log QTNIIVIKDHL;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log IHVNIYLFDVV;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log JPNZATROBMU;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log AOFNSZIEICN;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log PLJZGRAJEKF;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log TWUBSTZZICF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log DETVLPQZESR;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log BCWLYBBINCG;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log UBWIADSSKEN;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log STWIIHPYAQH;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log EVODOQCRPFK;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log QINWPUYOQGO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log ZVDEDAYUBZR;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log WLMJEXJPIZQ;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log EAJRZTCLKAG;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log YDYIXFDSKSN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log RXFIBMYBLAH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log GZDVKFRYLJT;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log UXHFBSFAAKB;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log STWIIHPYAQH;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log HZWKEICZQRF;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log FEUUIAUSSSX;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log LTOFSEDLHUT;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log LJXFMFIAXJU;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log AEMAGMWCKHF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log DAQWUNRLDHB;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log YMOUIVJSSYC;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log NIRNJMEPGYD;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log EDUMPEJNVMK;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log STWIIHPYAQH;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log GIOACRGTARZ;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log BQBMVPLIRDD;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log VDEVCIDXEOY;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log BCKNJLAWQKW;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log VORCXYPKFWW;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log HDGSICDYUWU;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log EFZCAOGMCIQ;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log EDVIBXQJGWC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log DYIIBAEXBIT;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log STWIIHPYAQH;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log SIKARWTRWHZ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log WXZPSGEBLMM;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log TPUTTRVLXNX;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log XJGLDTCYVYA;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log TTMHDJXDETJ;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log XTVSZKBDCJJ;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log SKJNPVYHFGL;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log XEPPGHRUFTG;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log PSCTTDNLSPS;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log ZOQRGYHRQBP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log MSOZJWBAEHC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log UWQWHKDYJXX;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log BOJDTUKKBXL;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log SANVDNCZFLZ;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log PKYBMIPQNSV;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log NVFOAOORFYM;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log OUJJPJRXBGJ;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log HYRZBVVNFFO;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log LSKJSUTPZAK;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log UXLCTFNACIQ;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log TKRDIMJTJTY;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log UUHLVRIGEIZ;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log XZQQPCIZKIT;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log LVNNLDHLSLW;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log DVPPDBTFFRU;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log VYRACMXOXPR;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log YEVYTZRFNRE;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log KUOHMDAOENP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log XXUEFCZHLVN;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log GRCNDIQEGOH;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log UJWWJMJCTRX;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log FODWECIZYNN;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log UWQWHKDYJXX;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log JPKQGXHRFPQ;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log JVRNCNDDFEP;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log WAOAIVEEGXW;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log RTXLHCLGOFS;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log QPLMUNZMNSK;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log UJWWJMJCTRX;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log YTQZQCNBNEK;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log MUJEHANMJKE;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log TALACXAIDPN;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log VXVMLQTXSEG;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log VQRSUFMKSEJ;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log GRCNDIQEGOH;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log EUPLYTCSGXJ;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log EWFKYNFZVBI;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log ZBTOAGRGHOH;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log RBGDNPLDCPS;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log KCESVOBVVBF;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log JEWFDFJBZYZ;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log RKDRGNIETYO;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log SPQRWJOWVSP;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log SOMDCOXLYRH;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log WQQNRRQGFXH;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log JVHWFYFRXUO;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log DHCYLQVXELU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log YDIAQKXFKPM;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log AMCAOVPRDGX;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log FAUMTXDRFUV;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log KZIJFXGKGDP;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log FSWIXQURVBS;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log LXCESEBZSSW;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log HNLONCUPEUP;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log VQBTYXEHESR;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log WNXAMHPCATS;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log PRAKADDBQUW;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log DTLIPANZJIP;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log GZXWXOIHHKW;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log FDLZCKPFZOA;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log CNKFOGEEABO;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log DLJIREFDDKY;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class HSTORPWMEFR
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log NTANHERSCJI;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log UNCEXZQOHGG;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log IUNLCOSBKXJ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log JJNLMCXOWWX;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log KUOHMDAOENP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log VQKHAMGIMXI;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log WBCUOUQAXIE;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log DROWMXHFPVN;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log IKSXITXTUWP;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log QSRVYWBZCWY;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log IJLHUKIDICX;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log RTLJQDLTHFQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log YFUGDCIQLYF;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log NXFZETLAXMB;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log YEVYTZRFNRE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log NWLWXLLSSTN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log VIVUVOJPBWR;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log FJRLWXCDCVG;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log CBUGITZIOGT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log AVTEEUQUKIM;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log TBYAWTESAPF;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log AQDUDCGLGGR;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log ATCEUSWWUMP;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log KYCFWYZGQER;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log EEUAQVMJUVE;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log ZFSBLKWGGDF;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log ZZXINHCERLB;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log STWIIHPYAQH;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log EWVLIIMGSWM;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log ALPPMAFCXEI;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log FBAMPXDOCXE;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log RMBUDNTHGYS;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log UBYIQGQJHGG;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log MGMQZTGXNQK;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log FESKZCZYZEF;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log UZFLDYCLZQJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log CORSISHLTOY;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log HOAZFUOXIOH;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log ROAHBZBWXOQ;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log DPLHVSACGHZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log YFXYAVRHJAG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log XWQDMWZNUJA;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log GUDYYUTZVQJ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log QDRNQUWSYJC;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log GHQAOZVVJHP;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log XLPBSKZJIFD;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log SHMICILBLDT;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log ZGKPOPTQNDD;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log MXSWCYTSIJT;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log CMPZHBZLLFJ;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log NJJZFVYSHJK;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log WJBYPXYYEYV;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log DWBDCJKNXYI;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log NASZCLFIBAT;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log TWXWWRHBLIM;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log CWURTSNLMGC;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log LXOXFKIBSKU;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log KUOHMDAOENP;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log SLLKVFIANZZ;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log UGHKMSCXBYK;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log JIZLUQGXDBJ;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log NXDZXXHJMBV;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log FSILCOCJLIO;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log YZAPFMWYKBZ;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log VINMHJNOZPN;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log IXSLPPEKGSD;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log OEEJWJEWOLH;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log IPNXIIQSMLT;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log UWWTFWAIYSF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log UWQWHKDYJXX;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log VFFEAKIMOHR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log KUOHMDAOENP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log ZNCBCWOMVYD;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log QHYIGNPXUHB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log KUOHMDAOENP;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log BXFSQDSVZCF;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log ATGEYFTISTW;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FFICKJELKNO
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class LOWLMGPDYSY : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] WIHQWENPSIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> TCMNAQMSAWH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool QOKLOGYHABN;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9B33B20", Offset = "0x9B32520", VA = "0x189B33B20")]
			internal LOWLMGPDYSY((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9B33AA0", Offset = "0x9B324A0", VA = "0x189B33AA0")]
			public IDisposable EAFBNOOZUIU()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9B339F0", Offset = "0x9B323F0", VA = "0x189B339F0", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class YWIDHSFSAON
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log UWQWHKDYJXX;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log ZQWLDRDZSVN;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log TTBORWDGQZM;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log XYWCEDNCTTD;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log UNPKPPMWHTD;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log PAPRTUTKYHN;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log DIEQLYTASNQ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log GUDYYUTZVQJ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log LLYMKGDIHXD;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log HBCUFRCEHNF;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log DZSMYTTCAMB;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log YIOYBTBIUXW;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log AKEKSPRGEPV;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log MCZJWRCQDMY;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log IOOBHHEMFOP;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log GNVMHGGBOZF;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log KKMHCRUSUZK;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log XLPBSKZJIFD;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log SJXKHZNMHDJ;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log CAEZYYOUOAO;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log VQHACPHGCBH;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log TKRDIMJTJTY;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log WWOCSQMRAMC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log HEBIBRRFMTR;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log MKXMIGMDMBK;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log EMGIZRANGCG;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log HBXIVXISNVM;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log IXLAKQMLFSW;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log SIOCCPTLZJH;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log PZEWGLBOFPK;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log DKJYERJMXRB;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log XJGWZAYLBXS;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log TVQYQTPGQRN;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log HCNAXXIGCSI;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log NDMBBHTUNOH;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log IGLINQVWMTQ;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log UPWQAGKBQVA;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log IVWKGGTSEUS;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log EPVFEGVCEDE;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log VHRDVFKPXMN;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log NOVCJLQPART;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log CLJQHIKIEHZ;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log ATJLLXLCEVC;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log POUDVJYBKED;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log GCFDQIUCRIK;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log MCYTGOFFFOC;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log GVMHRJVBDGJ;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log GEGUEHISOBY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log ADPHMIHLKRY
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x9B3C070", Offset = "0x9B3AA70", VA = "0x189B3C070")]
			get
			{
				return default(Log);
			}
		}
	}
}
namespace RecRoom.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	internal class GBRNYIOLPTE
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private GBRNYIOLPTE parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
			public Scope(GBRNYIOLPTE parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch ZJYACGJELHT;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x111A6A0", Offset = "0x11190A0", VA = "0x18111A6A0")]
		public Scope SZTNBWMDZDQ()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9B2FBE0", Offset = "0x9B2E5E0", VA = "0x189B2FBE0")]
		public GBRNYIOLPTE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface BBSLLUEXNQJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void ISNCDANPQPK(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PBOZSOOQQSE(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void UXPWTIRECES(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9B34120", Offset = "0x9B32B20", VA = "0x189B34120")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9B340B0", Offset = "0x9B32AB0", VA = "0x189B340B0", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[Preserve]
	public abstract class LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void WSFSWRIEDET();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class UGYGQKNMUSY
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> YJTIZPUIXNF;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool LHBSXXKSFJG;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object OBCSKZMVGCH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> NMZIGINVPSL
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x9B3BD10", Offset = "0x9B3A710", VA = "0x189B3BD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9B3BB90", Offset = "0x9B3A590", VA = "0x189B3BB90")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9B3BD50", Offset = "0x9B3A750", VA = "0x189B3BD50")]
		private static void WHPODFFJQSR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9B3B950", Offset = "0x9B3A350", VA = "0x189B3B950")]
		private static void CAZPPWDGRHQ(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class IPNEGYVDAPF
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			public void VCDUNERVMWN(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320")]
			public ParanoiaLevel YZFQXJFMBJX(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action DUGNYYFVJXI;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object MCTNGYKNDPU;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> GWEWYQPTXHW;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> ACVBNWKMWUI;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> RWORISPZBSN;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> CUWVPQUNXZX;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> PKAUGBPVYOK;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> UEYPVUBEHGR;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder TWXEXOHXFBJ;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly GBRNYIOLPTE WQPRTSQVXSX;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug ITZJHIZAPHX;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int PVPYLRLTTCT;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static BBSLLUEXNQJ SFITTCRTNXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9B33330", Offset = "0x9B31D30", VA = "0x189B33330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x9B32060", Offset = "0x9B30A60", VA = "0x189B32060")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool MDQJBEPSPTV
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x9B32A70", Offset = "0x9B31470", VA = "0x189B32A70")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool QYELXOUMTBZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x9B32A20", Offset = "0x9B31420", VA = "0x189B32A20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool AUAQDITOXTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9B33380", Offset = "0x9B31D80", VA = "0x189B33380")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x9B33490", Offset = "0x9B31E90", VA = "0x189B33490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9B33590", Offset = "0x9B31F90", VA = "0x189B33590")]
		static IPNEGYVDAPF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B31780", Offset = "0x9B30180", VA = "0x189B31780")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9B33190", Offset = "0x9B31B90", VA = "0x189B33190")]
		public static int WSFSWRIEDET(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9B330C0", Offset = "0x9B31AC0", VA = "0x189B330C0")]
		public static int WSFSWRIEDET(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9B306E0", Offset = "0x9B2F0E0", VA = "0x189B306E0")]
		public static Log AYXHVHWMWNX(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9B32C30", Offset = "0x9B31630", VA = "0x189B32C30")]
		public static void TSGZJAYRYWK(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9B31990", Offset = "0x9B30390", VA = "0x189B31990")]
		public static void JGTWERDHOPZ(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9B32DF0", Offset = "0x9B317F0", VA = "0x189B32DF0")]
		public static bool UZRMSSIRAPN(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x9B32F70", Offset = "0x9B31970", VA = "0x189B32F70")]
		public static int WDDFJOFCHRA(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x9B30300", Offset = "0x9B2ED00", VA = "0x189B30300")]
		public static string ABTNKUXUBFT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x9B32210", Offset = "0x9B30C10", VA = "0x189B32210")]
		public static (string[], int[]) QCWYMLTSCDU()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9B308A0", Offset = "0x9B2F2A0", VA = "0x189B308A0")]
		private static int CXBEYNGFMIW(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x9B32AC0", Offset = "0x9B314C0", VA = "0x189B32AC0")]
		private static int SLKFRIOKCUQ(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9B30BE0", Offset = "0x9B2F5E0", VA = "0x189B30BE0")]
		private static int ELRBSAOYXNO(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9B323C0", Offset = "0x9B30DC0", VA = "0x189B323C0")]
		private static int QFMOAKQVDTV(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x9B32490", Offset = "0x9B30E90", VA = "0x189B32490")]
		private static int QFMOAKQVDTV(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x9B30570", Offset = "0x9B2EF70", VA = "0x189B30570")]
		private static void ACAOIPCZCTI(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x9B309C0", Offset = "0x9B2F3C0", VA = "0x189B309C0")]
		public static bool CXDLGHDOWCW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x9B32E70", Offset = "0x9B31870", VA = "0x189B32E70")]
		public static bool VBEAELAJQON(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9B31150", Offset = "0x9B2FB50", VA = "0x189B31150")]
		private static void EWZIJCHVYOZ(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x9B31BA0", Offset = "0x9B305A0", VA = "0x189B31BA0")]
		public static void LZZTDBRIPZN(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x9B32660", Offset = "0x9B31060", VA = "0x189B32660")]
		public static void QLENKGYWGEA(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9B33520", Offset = "0x9B31F20", VA = "0x189B33520")]
		private static void ZOBJGFUWTAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x9B31510", Offset = "0x9B2FF10", VA = "0x189B31510")]
		private static void ITGANQOONBW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x9B320D0", Offset = "0x9B30AD0", VA = "0x189B320D0")]
		private static bool MFYDAZBVBNT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x9B30A80", Offset = "0x9B2F480", VA = "0x189B30A80")]
		private static bool CYZRNSXDEJW(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x9B33410", Offset = "0x9B31E10", VA = "0x189B33410")]
		private static bool YRFMSBELFGK(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9B32B70", Offset = "0x9B31570", VA = "0x189B32B70")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x9B314A0", Offset = "0x9B2FEA0", VA = "0x189B314A0")]
		private static void HHOPLYSMXKS(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x9B30730", Offset = "0x9B2F130", VA = "0x189B30730")]
		public static FFICKJELKNO.LOWLMGPDYSY CFMUMRICKBC((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x9B32F30", Offset = "0x9B31930", VA = "0x189B32F30")]
		public static void VCDUNERVMWN(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x9B334E0", Offset = "0x9B31EE0", VA = "0x189B334E0")]
		public static ParanoiaLevel YZFQXJFMBJX(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		MassivelyParanoid
	}
}
namespace RecRoom.Logging.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public PreserveAttribute()
		{
		}
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
