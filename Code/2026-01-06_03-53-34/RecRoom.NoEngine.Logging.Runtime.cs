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
		[Cpp2IlInjected.Address(RVA = "0x849FFA0", Offset = "0x849E9A0", VA = "0x18849FFA0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCB4390", Offset = "0xCB2D90", VA = "0x180CB4390")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PEKBTTYPGTU
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x84A12B0", Offset = "0x849FCB0", VA = "0x1884A12B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool UINMQJTEFRM
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x84A23E0", Offset = "0x84A0DE0", VA = "0x1884A23E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string MVXIJBZHFMA
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x84A2430", Offset = "0x84A0E30", VA = "0x1884A2430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool TUHKJRTAHJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x53BF390", Offset = "0x53BDD90", VA = "0x1853BF390")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel VTQIPGVINZY
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x84A24F0", Offset = "0x84A0EF0", VA = "0x1884A24F0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x84A2BA0", Offset = "0x84A15A0", VA = "0x1884A2BA0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1302AE0", Offset = "0x13014E0", VA = "0x181302AE0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84A2C00", Offset = "0x84A1600", VA = "0x1884A2C00")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x377F960", Offset = "0x377E360", VA = "0x18377F960")]
		public void HJQXYLHCLXF<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x84A1E90", Offset = "0x84A0890", VA = "0x1884A1E90")]
		public void HJQXYLHCLXF(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x84A1FA0", Offset = "0x84A09A0", VA = "0x1884A1FA0")]
		public void HJQXYLHCLXF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84A22C0", Offset = "0x84A0CC0", VA = "0x1884A22C0")]
		public void MAGTEGFBYJC(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3782820", Offset = "0x3781220", VA = "0x183782820")]
		public void LUYMHGWLPCN<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84A21A0", Offset = "0x84A0BA0", VA = "0x1884A21A0")]
		public void LUYMHGWLPCN(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84A20A0", Offset = "0x84A0AA0", VA = "0x1884A20A0")]
		public void LUYMHGWLPCN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3785BD0", Offset = "0x37845D0", VA = "0x183785BD0")]
		public void ZZCPEVJYWZE<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x84A2960", Offset = "0x84A1360", VA = "0x1884A2960")]
		public void ZZCPEVJYWZE(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x84A2A90", Offset = "0x84A1490", VA = "0x1884A2A90")]
		public void ZZCPEVJYWZE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x377C210", Offset = "0x377AC10", VA = "0x18377C210")]
		public void ERFPTZZVAJZ<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84A1370", Offset = "0x849FD70", VA = "0x1884A1370")]
		public void ERFPTZZVAJZ(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x84A1460", Offset = "0x849FE60", VA = "0x1884A1460")]
		public void ERFPTZZVAJZ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3785640", Offset = "0x3784040", VA = "0x183785640")]
		public void XTTQBEZBING<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x84A2860", Offset = "0x84A1260", VA = "0x1884A2860")]
		public void XTTQBEZBING(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x84A2780", Offset = "0x84A1180", VA = "0x1884A2780")]
		public void XTTQBEZBING(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x377E280", Offset = "0x377CC80", VA = "0x18377E280")]
		public void FVTHUAYRHXH<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x84A1830", Offset = "0x84A0230", VA = "0x1884A1830")]
		public void FVTHUAYRHXH(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x84A1930", Offset = "0x84A0330", VA = "0x1884A1930")]
		public void FVTHUAYRHXH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84A1300", Offset = "0x849FD00", VA = "0x1884A1300")]
		public void EBJSTQEDUDQ(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84A2480", Offset = "0x84A0E80", VA = "0x1884A2480")]
		public void VZSMSUCRRST(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37851B0", Offset = "0x3783BB0", VA = "0x1837851B0")]
		public LogRangeScope WRLFEEFAXGA<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE332F0", Offset = "0xE31CF0", VA = "0x180E332F0")]
		public LogRangeScope ZOLGRNXGEHJ<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84A2660", Offset = "0x84A1060", VA = "0x1884A2660")]
		public LogRangeScope WRLFEEFAXGA(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84A2560", Offset = "0x84A0F60", VA = "0x1884A2560")]
		public LogRangeScope WRLFEEFAXGA(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE332F0", Offset = "0xE31CF0", VA = "0x180E332F0")]
		public LogRangeScope ZOLGRNXGEHJ(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84A1540", Offset = "0x849FF40", VA = "0x1884A1540")]
		public void FJGGACHBQQU(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84A1620", Offset = "0x84A0020", VA = "0x1884A1620")]
		public void FJGGACHBQQU(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x377D810", Offset = "0x377C210", VA = "0x18377D810")]
		public void FJGGACHBQQU<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
		public void BQARNAHQIVF([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x84A1A10", Offset = "0x84A0410", VA = "0x1884A1A10")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84A1B30", Offset = "0x84A0530", VA = "0x1884A1B30")]
		private static void GNJHKHDYHFP(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log BBHPSVVZEWJ;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log FVIBOPYUCCM;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log VZEEHXGPXPA;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log WYZKZUDTUAH;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log DQYIQAERBXZ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log WZVXBVUGPUF;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log LSZAWXPBRLC;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log ZHCZIYMZPOT;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log BXAWCRJHCWS;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log BBJOCOEZUZT;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log UGWUUBJKYEP;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log XOZDPWDLRHV;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log QOIOBGYWDLP;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log FEOWJENGJLM;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log OLTSWDABMUM;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log FZPEROCFJAO;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log XYVTXBKBDJY;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log PHEBBSQRWEZ;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log GOHCNZKEXKW;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log MPYSBJFHTUO;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log OYXNFPCKIQU;
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
					public static readonly Log ZKHZHUKWIOO;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log JCDZSCQCUKA;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log AKEIMJMPWNY;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log FPNDOERVAQZ;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log KUVHCKERVRT;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log YNHMGNTGALB;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log JTBVCRWPXRP;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log QTTEMHVWQLZ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log AKEIMJMPWNY;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log KUVHCKERVRT;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log YNHMGNTGALB;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log JLTWEZFFZVO;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log DICYXRGPYWP;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log MZHLCLYBKMV;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log HSTYVALKKIZ;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log VMCQDIPXSJE;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log ZKHZHUKWIOO;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log CTQGNJEQQEC;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log CTVNKPYNZPL;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log CTFSSVQVXHK;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log CTKZQCKTGST;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log CSVEYIDBEKS;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log CTALVOWYNWB;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log CSKRDUPGLOA;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log CSPYBBJDUZJ;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log CSADJHBLSRI;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log CSFKGNVJCCR;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log ZKHZHUKWIOO;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log CTQGNJEQQEC;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log CTVNKPYNZPL;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log CTFSSVQVXHK;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log CTKZQCKTGST;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log CSVEYIDBEKS;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log CTALVOWYNWB;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log CSKRDUPGLOA;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log CSPYBBJDUZJ;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log CSADJHBLSRI;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log CSFKGNVJCCR;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log ZKHZHUKWIOO;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log RWAUCBCYLIG;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log SUHNMGVORIW;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log UVRWPDNFBBI;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log YAXGRXSPUKW;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log HPTUQLUYRTL;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log WTEAGEJEJLF;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log NBQSFUOETFW;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log VJWAWGXPDGN;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log KUIYHEPGATG;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log DUOHVEEXAIE;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log OVCTJDSJLLQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log KWLOADDFGWW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log BBBOOMLTLGX;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log YVODIQUJRLK;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log RWQKRNYMJTQ;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log AMAKGKIQGAG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log KPAJMKGEOVM;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log MZAGESPNZXP;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log WZJMCVSAFLO;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log KXKSETDOFRU;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log EYPCDOVGQPN;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log SQMSQBRHPLD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log NOSOVKOURAA;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log DNOPJOCQTRZ;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log MJAQCMIHFVF;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log ZVFGSLSUGTA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log ZXYWFHOYMKE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log RBGVHLMAICU;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log PNAFNMVLYYS;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log KXKSETDOFRU;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log VLEUZCJRAKY;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log OYXNFPCKIQU;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log ERLYYFOCKNC;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log RQEGVAZBFEZ;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log KUIYHEPGATG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log XASQIMJILDO;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log ESHZFSJKBSJ;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log HWGPFNRUTTQ;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log FEHJPTIMQMB;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log KXKSETDOFRU;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log EJOLMWQBRYG;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log QUZIIKMTKOI;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log ISZGZIQOKRN;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log TBJUKGEHROP;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log RDSMREBUGVP;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log NSGZRVKIVPN;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log MAVDMHHVTPX;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log LFXTSMXGVQF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log QVIELUSTJFS;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log KXKSETDOFRU;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log VJHYOMBOVMA;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log JBDOMWCJHUZ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log HIXAQWGZWJK;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log ABXWALFFZKP;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log GHPUKDJFNEO;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log VXUDHFPDWHQ;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log AHRDCGWEMQY;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log LOCEOMORBWL;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log YDFDJHAKKBO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly Log BNJDFTUBJLV;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				private static readonly Log JUZKUUELVXI;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log PHORUPOSJZY;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log HTSEEQDKEYQ;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log TCLCXOFRIIU;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log RUSNBXEHKLP;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log FFUSAMCHXTW;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log FBEMXSCTRFX;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log GXIOPPFFNOJ;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log MLAKKPYHWHT;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log BBJOCOEZUZT;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log JLTWEZFFZVO;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log NYRUXASBBKW;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log VOMONYCKEZL;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log XQVYPEOBNLV;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log FEAWRYYBLUI;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log SHCQFFNGGWR;
			}

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log ZKHZHUKWIOO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log ZBNFDCSARKY;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log ZNTHSHUTPNW;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log HYADYLYDQOK;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log JZXSMCTQIOC;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B4")]
					private static readonly Log JUZKUUELVXI;

					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					public static readonly Log DIXASLYBKTD;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log NQZYOMUSXNI;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log SVFHTZEAPKZ;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log DVIWTMTDGJF;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log BMHVABSSRON;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log HYADYLYDQOK;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log GMCZGVOTFBP;
				}

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log XMIGPVAGIDH;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log PKZASMGMTYQ;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log NODOSVIUCRP;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log SWBAVQENWBI;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log ZNTHSHUTPNW;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log CJUQPOKCWXU;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log RMJUKABNUKN;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log ZPPXVWTCHFK;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log QBMVEBBLTRV;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log CCRVBJXWSGC;
			}

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log GKUUAAUMXPK;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log QLUJJDKYLBJ;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log HEXKISGMNQI;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log WSADMVQPHRU;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log PXOUJJGTGZI;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log PWLYZLAVLCJ;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log HMHXHTLWVSZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log GGROTDXLYPJ;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log FLABEYWUPKC;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log YNDZPYQNRIC;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log LPDXECOPLUI;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log LHSBNLYNMEJ;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log EBOICSGXTOP;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log UEGPQZCHSOO;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log RLNTWOEHRUS;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log YQLVAQJCZRV;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log MMCFWIOGBUV;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log AEBXJOPUDZI;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log AXOFRQBREGX;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log RYBHCXPAMUR;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log MOEDPKRGCKZ;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log HJMXBUHPTVV;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class MOVNVQNVOUI
			{
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log AXNAWMWNPWB;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log CTKUJMKKKAZ;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log JPOPGRRWGGM;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly Log ZKHZHUKWIOO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly Log WONWBOJXALA;

			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly Log XARQBVSHDBX;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log WWBJVHIHRVI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log ANMLEFHAEQA;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log PEPMCYOPIBQ;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log SHCQFFNGGWR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log BBQECGPUGQK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log ULTMSCONQLW;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log NGOTJRVNPXT;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log CWXCBSTDBOO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log ITTUSDXQFIR;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log YIMXWQBLZGO;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log YRYOKUUKCUI;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log OOGULCAJUEY;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log LUNAXUPAWBI;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log LDPNJZYZCDT;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log GFIEFJCXNII;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log KYZUBFCMQOC;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log KXKSETDOFRU;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log NQFDKWORFXF;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log WDPVZOEIFNV;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log UMVSTXANNYT;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log FXSNATZZIAZ;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log STQZOFRFAMN;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log VFPTWXAPZPR;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log VWZAYAPNGPM;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log ERXXYWZWUTE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log WYZKZUDTUAH;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log ZRNCBWZASQA;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log MOKVIISSHRT;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log LFAWAXGOIRC;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log DHCCOCQIKWR;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log NETMNANJJPJ;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log MTVEXCKWAHK;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log VCHJFXIYMCJ;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log IZTQNESUFQA;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log BBDKANUZVGQ;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log FWXETQBKTFK;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log XBFECFFFDAY;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log NUIVZBXVAGS;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log ANHBYRFHALA;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log NDAHBDXAAZJ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log DDVWUIRZWBS;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log MDSVIGCLSEB;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log YMEYSMHGJLE;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log TEIWRUMEUBF;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log EITCJKQAZAF;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log MZHLCLYBKMV;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public static readonly Log ZKHZHUKWIOO;

				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public static readonly Log GUALPAVVUMY;

				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public static readonly Log FFURQKHBFVZ;
			}

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log VQUEEIBFMRG;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log GOHTXLMATSU;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log RVPRFLCZCAP;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log QGXBELOAHZS;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log NPTVEZZASZG;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log KTAPEGDQRVS;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log LEAFHGXPCQU;

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly Log HTBYMLRDSVU;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log ECPQCCLNMLO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private static readonly Log JUZKUUELVXI;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log PBLGTADMHCG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log ZKHZHUKWIOO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log ZUSBCECPFCE;

			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public static readonly Log KYIPZPXNGPG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly Log ZKHZHUKWIOO;

			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly Log FOUVHWHVSBE;

			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly Log PRUASWBHSBT;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class AJJZNPDCUSF
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class UGJPDZAOUDB : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly (int index, bool enabled)[] RITMMFHYCSQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private List<(int index, bool enabled)> UOZTRSFWRRA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private bool FAZKFJRULIY;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x84AA630", Offset = "0x84A9030", VA = "0x1884AA630")]
			internal UGJPDZAOUDB((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84AA5B0", Offset = "0x84A8FB0", VA = "0x1884AA5B0")]
			public IDisposable YGRKPHFRYXX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x84AA500", Offset = "0x84A8F00", VA = "0x1884AA500", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HOITTHKGQOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private static readonly Log JUZKUUELVXI;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log KZVOCWQWMFG;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log DPGVAAUETOD;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log CBRJFFZTKIS;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log UQHJXCYFAVC;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log UFMPXUWMAOE;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log CQFEDFCERDN;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log MTVEXCKWAHK;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log ASZXUJQZJZO;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log TENOLREEPNC;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log YPSRVFCUKIC;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log BXHRDKYFIAD;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log LBLZKGUSQGS;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log WNTUOAMFNYX;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log SKOFLATYXAK;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log GQCNOQVQCLM;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log INSVLZUOBVP;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log BBDKANUZVGQ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log AHZUQVSZHMY;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log NXCOAPERTPT;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log EUPEROBWGOY;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log BBJOCOEZUZT;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log LEEAPORCJIR;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log KJJGOFGMFVG;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log EXKQLCIAXQB;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log AFKEDAVVOGV;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log FTBIHJZHBNP;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log WPKRBFMTJIZ;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log PPBQPJQBSPE;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log MBTYPFWWKJF;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log OCTIHRWBALC;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log LIIYJISBXJJ;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log BUYYJGCVLCW;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log AFJDBNXJOTV;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log NYVHPDBCZXU;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log FPNDOERVAQZ;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log MOBXYSVPAYR;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log ZKXSOXYOVNX;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log KSBNRDJPFFB;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log FDRQDUVLOUE;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log AUJLMGQQNAG;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log EWQNIEROFLK;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log MFCTNRGUGGH;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log OYKQOKXRBCW;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log VDIQEYGMVJB;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log CPYSLADJDMT;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log FUQWPEQLMAA;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log QJDAVDCDMTB;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log IPGHBIITLIB
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x849E490", Offset = "0x849CE90", VA = "0x18849E490")]
			get
			{
				return default(Log);
			}
		}
	}
}
namespace RecRoom.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	internal class OHAYZAMXNIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private OHAYZAMXNIP parent;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xC00D90", Offset = "0xBFF790", VA = "0x180C00D90")]
			public Scope(OHAYZAMXNIP parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private readonly Stopwatch CTBRCSQGXUG;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xE11BF0", Offset = "0xE105F0", VA = "0x180E11BF0")]
		public Scope NFMSDVLLTNJ()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x84A6900", Offset = "0x84A5300", VA = "0x1884A6900")]
		public OHAYZAMXNIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface RNCGKMAFESG
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void HJQXYLHCLXF(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LUYMHGWLPCN(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ERFPTZZVAJZ(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x849FF00", Offset = "0x849E900", VA = "0x18849FF00")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x849FE90", Offset = "0x849E890", VA = "0x18849FE90", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[Preserve]
	public abstract class LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JIBLBJTHOBM();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class YEVPIIZXKZP
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static List<LogRegistrationIndex> TFROHVNCZLO;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static bool EEXWHCBPFMX;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly object PBFEGGCBGDM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> KQGGERXYISM
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x84AAB90", Offset = "0x84A9590", VA = "0x1884AAB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x84AAA20", Offset = "0x84A9420", VA = "0x1884AAA20")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x84AA810", Offset = "0x84A9210", VA = "0x1884AA810")]
		private static void ENCPTOOXKZE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x84AABD0", Offset = "0x84A95D0", VA = "0x1884AABD0")]
		private static void TPQURWJHFTL(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class OAPNKYPPKNS
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
			public void WRRJZBMLWFW(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160")]
			public ParanoiaLevel PXTAQKKMBUY(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAB6970", Offset = "0xAB5370", VA = "0x180AB6970")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static Action JVBKRTKHQOF;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly object QGLZOPZUAYB;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly Dictionary<(int parentIndex, string token), int> FEIQZCKFDPB;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly List<string> SSIKQJWVXFV;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly List<int> EUYLDGTJPZM;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly List<ulong> ZJTZKAKJXGS;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly List<ulong> VXQQQNQRVBF;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly List<ulong> EJFFTHBJFKG;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly StringBuilder SPWBWHLUJBY;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly OHAYZAMXNIP JDNGKJGUBIU;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static Debug DSOKVMYYHCK;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static int HCFKSRSVPXY;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static RNCGKMAFESG LZJDFIZHUDF
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x84A47F0", Offset = "0x84A31F0", VA = "0x1884A47F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x84A64B0", Offset = "0x84A4EB0", VA = "0x1884A64B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool CELMZQHYTOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x84A53D0", Offset = "0x84A3DD0", VA = "0x1884A53D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LEXDIPBSKSS
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x84A5380", Offset = "0x84A3D80", VA = "0x1884A5380")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool OGACBEZNTPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84A3E60", Offset = "0x84A2860", VA = "0x1884A3E60")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x84A6520", Offset = "0x84A4F20", VA = "0x1884A6520")]
		static OAPNKYPPKNS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x84A4D80", Offset = "0x84A3780", VA = "0x1884A4D80")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x84A5060", Offset = "0x84A3A60", VA = "0x1884A5060")]
		public static int JIBLBJTHOBM(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x84A4F90", Offset = "0x84A3990", VA = "0x1884A4F90")]
		public static int JIBLBJTHOBM(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x84A4480", Offset = "0x84A2E80", VA = "0x1884A4480")]
		public static Log DYIEIHWBICE(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84A5880", Offset = "0x84A4280", VA = "0x1884A5880")]
		public static void VNVYDCPRFGB(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x84A3B00", Offset = "0x84A2500", VA = "0x1884A3B00")]
		public static void AJFYKSQSXPU(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x84A5420", Offset = "0x84A3E20", VA = "0x1884A5420")]
		public static bool PMYOLZYWJNO(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x84A5A40", Offset = "0x84A4440", VA = "0x1884A5A40")]
		public static int VSBPLEGVXFF(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84A54E0", Offset = "0x84A3EE0", VA = "0x1884A54E0")]
		public static string SZVQWIUFOWC(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x84A5B90", Offset = "0x84A4590", VA = "0x1884A5B90")]
		public static (string[], int[]) VTRBCXZTBCB()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x84A4360", Offset = "0x84A2D60", VA = "0x1884A4360")]
		private static int DBDYSBGZTDZ(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x84A5D70", Offset = "0x84A4770", VA = "0x1884A5D70")]
		private static int WVAMPKUHAPP(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x84A35B0", Offset = "0x84A1FB0", VA = "0x1884A35B0")]
		private static int AFIIWYJDSML(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84A3F50", Offset = "0x84A2950", VA = "0x1884A3F50")]
		private static int CWJUBFHLIFS(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x84A4020", Offset = "0x84A2A20", VA = "0x1884A4020")]
		private static int CWJUBFHLIFS(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84A41F0", Offset = "0x84A2BF0", VA = "0x1884A41F0")]
		private static void CYJCQYLJZRJ(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x84A52C0", Offset = "0x84A3CC0", VA = "0x1884A52C0")]
		public static bool MIBEKSHUUBF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x84A5200", Offset = "0x84A3C00", VA = "0x1884A5200")]
		public static bool KLWOGZJFRMK(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x84A4840", Offset = "0x84A3240", VA = "0x1884A4840")]
		public static void HYPRPVOKMZQ(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x84A60F0", Offset = "0x84A4AF0", VA = "0x1884A60F0")]
		public static void ZESQFYPIPBL(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x84A3EF0", Offset = "0x84A28F0", VA = "0x1884A3EF0")]
		private static void CFHGXFBNHBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x84A5E20", Offset = "0x84A4820", VA = "0x1884A5E20")]
		private static void XLECQEMZITV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x84A4540", Offset = "0x84A2F40", VA = "0x1884A4540")]
		private static bool FCFMUCQIOPA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84A3D10", Offset = "0x84A2710", VA = "0x1884A3D10")]
		private static bool ALGEXNHISFX(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x84A5800", Offset = "0x84A4200", VA = "0x1884A5800")]
		private static bool VJKBHEMINXT(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84A5740", Offset = "0x84A4140", VA = "0x1884A5740")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84A44D0", Offset = "0x84A2ED0", VA = "0x1884A44D0")]
		private static void EMEFBSKOBFN(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x84A4680", Offset = "0x84A3080", VA = "0x1884A4680")]
		public static AJJZNPDCUSF.UGJPDZAOUDB GKFXKLPRHJP((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84A5D30", Offset = "0x84A4730", VA = "0x1884A5D30")]
		public static void WRRJZBMLWFW(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x84A54A0", Offset = "0x84A3EA0", VA = "0x1884A54A0")]
		public static ParanoiaLevel PXTAQKKMBUY(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		MassivelyParanoid
	}
}
namespace RecRoom.Logging.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
