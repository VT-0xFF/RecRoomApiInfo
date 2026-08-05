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
		[Cpp2IlInjected.Address(RVA = "0x845A5A0", Offset = "0x8458DA0", VA = "0x18845A5A0", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
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
			[Cpp2IlInjected.Address(RVA = "0xCC9230", Offset = "0xCC7A30", VA = "0x180CC9230")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool AWHUYCLNCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x845BFC0", Offset = "0x845A7C0", VA = "0x18845BFC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool LHWTWCWTXWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x845C7C0", Offset = "0x845AFC0", VA = "0x18845C7C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string QCXJTZYZGPW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x845BF70", Offset = "0x845A770", VA = "0x18845BF70")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool WOZOQQPPCVJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x534EF20", Offset = "0x534D720", VA = "0x18534EF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel LDEICILFGHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x845D170", Offset = "0x845B970", VA = "0x18845D170")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x845D1E0", Offset = "0x845B9E0", VA = "0x18845D1E0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1320020", Offset = "0x131E820", VA = "0x181320020")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x845D240", Offset = "0x845BA40", VA = "0x18845D240")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37CBCC0", Offset = "0x37CA4C0", VA = "0x1837CBCC0")]
		public void IGDGTMIVBYD<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x845C5B0", Offset = "0x845ADB0", VA = "0x18845C5B0")]
		public void IGDGTMIVBYD(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x845C6C0", Offset = "0x845AEC0", VA = "0x18845C6C0")]
		public void IGDGTMIVBYD(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x845C490", Offset = "0x845AC90", VA = "0x18845C490")]
		public void HROYWUVUFXS(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37C9CA0", Offset = "0x37C84A0", VA = "0x1837C9CA0")]
		public void CQOEZLARUMN<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x845BB10", Offset = "0x845A310", VA = "0x18845BB10")]
		public void CQOEZLARUMN(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x845BC30", Offset = "0x845A430", VA = "0x18845BC30")]
		public void CQOEZLARUMN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37D3170", Offset = "0x37D1970", VA = "0x1837D3170")]
		public void YDQJWVHZELI<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x845CF30", Offset = "0x845B730", VA = "0x18845CF30")]
		public void YDQJWVHZELI(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x845D060", Offset = "0x845B860", VA = "0x18845D060")]
		public void YDQJWVHZELI(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37CA2F0", Offset = "0x37C8AF0", VA = "0x1837CA2F0")]
		public void EGYFPFCPENJ<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x845BDA0", Offset = "0x845A5A0", VA = "0x18845BDA0")]
		public void EGYFPFCPENJ(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x845BE90", Offset = "0x845A690", VA = "0x18845BE90")]
		public void EGYFPFCPENJ(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37CE8C0", Offset = "0x37CD0C0", VA = "0x1837CE8C0")]
		public void QXQPVLWNWQI<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x845C880", Offset = "0x845B080", VA = "0x18845C880")]
		public void QXQPVLWNWQI(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x845C980", Offset = "0x845B180", VA = "0x18845C980")]
		public void QXQPVLWNWQI(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37CFEA0", Offset = "0x37CE6A0", VA = "0x1837CFEA0")]
		public void TLLJSTPJIPL<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x845CB40", Offset = "0x845B340", VA = "0x18845CB40")]
		public void TLLJSTPJIPL(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x845CA60", Offset = "0x845B260", VA = "0x18845CA60")]
		public void TLLJSTPJIPL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x845C810", Offset = "0x845B010", VA = "0x18845C810")]
		public void QIKYPXHUQVM(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x845BD30", Offset = "0x845A530", VA = "0x18845BD30")]
		public void DPDSREZPHZN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37C96A0", Offset = "0x37C7EA0", VA = "0x1837C96A0")]
		public LogRangeScope CAUYOETMDQU<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LogRangeScope UBTDAHTMJBZ<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x845B9F0", Offset = "0x845A1F0", VA = "0x18845B9F0")]
		public LogRangeScope CAUYOETMDQU(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x845B8F0", Offset = "0x845A0F0", VA = "0x18845B8F0")]
		public LogRangeScope CAUYOETMDQU(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE661C0", Offset = "0xE649C0", VA = "0x180E661C0")]
		public LogRangeScope UBTDAHTMJBZ(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x845CC40", Offset = "0x845B440", VA = "0x18845CC40")]
		public void TSVJXCVRKYU(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x845CD20", Offset = "0x845B520", VA = "0x18845CD20")]
		public void TSVJXCVRKYU(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37D05B0", Offset = "0x37CEDB0", VA = "0x1837D05B0")]
		public void TSVJXCVRKYU<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
		public void WAUFXFJKKMP([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x845C010", Offset = "0x845A810", VA = "0x18845C010")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x845C130", Offset = "0x845A930", VA = "0x18845C130")]
		private static void GQRZYOCMYYF(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log XWHMBGUFKSR;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log QZSMNAUPDFK;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log VJXBANGBHTA;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log BYHMTYHHGFF;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log AROSVOGBSTV;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log KXWTNUEHYKV;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log IFFSVQLQQEM;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log ETJTTQZLIZZ;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log AFKFIOEOCHY;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log OVJPGVZBQNT;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log LJAOBMTCKFF;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log LDDJPBVAHRJ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log FYQNQRXIHRL;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log KBVFHETJRKW;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log MMLOVJRJWLG;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log SVGRXLNJPCK;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log GUWLRFAFGYO;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log BWXQBJWYUZP;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log MMYRHDDOXWW;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log VFCTVNLCQTU;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log AGQCWQMVFMY;
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
					public static readonly Log ORLNTNJJFUO;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log NTQFNXHCGDG;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log WOEWCVDXNOK;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log AEQLQSNYAIJ;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log HOHKSTTZDPX;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log SANOZBIAIDZ;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log XPVKJYFXCLH;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log UZISBKSPPUT;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log WOEWCVDXNOK;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log HOHKSTTZDPX;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log SANOZBIAIDZ;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log GVFLMUKSKUE;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log KWTFHRSFBOT;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log PSZFMVUDWLX;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log NQSYZOAEPNL;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log PPJNLCMVSDI;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log ORLNTNJJFUO;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log VKMJFFIIGYK;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log VKRQCMCFQJT;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log VKBVKRUNOBS;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log VKHCHYOKXNB;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log VJRHQEGSVFA;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log VJWONLAQEQJ;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log VJGTVQSYCII;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log VJMASXMVLTR;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log VMCMJHLNELE;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log VMHTGOFKNWN;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log ORLNTNJJFUO;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log VKMJFFIIGYK;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log VKRQCMCFQJT;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log VKBVKRUNOBS;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log VKHCHYOKXNB;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log VJRHQEGSVFA;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log VJWONLAQEQJ;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log VJGTVQSYCII;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log VJMASXMVLTR;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log VMCMJHLNELE;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log VMHTGOFKNWN;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log ORLNTNJJFUO;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log SGTKXHQHJCK;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log SPSIWYGOVMW;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log YEQQYYPSLXU;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log ZNAXCOTRPCC;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log MINRLVHJUTP;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log WKSBLATXPQL;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log HMJQAXOXSPG;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log FADCIXHKEXP;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log BDVXRZHENGM;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log WNPLJWWBKKA;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log GZXFRVYKNHQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log NSHSHXTQEDM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log ENFQMABSHOX;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log OPCBGZTWNII;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log PCLDTQXEDSK;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log CNVAZGXEEZM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log DGDYYDMERGO;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log HATAEPROBEN;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log SAZQVYVPERW;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log KQMOFRDRBWC;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log EXWMYNCRZVN;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log OVJJUSRMVUB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log XBQOIKDCOBK;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log EPVXSNZHUIP;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log SBMKWXVYOQD;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log JPJUPUPUOPQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log XPBLCZAUOMA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log YGBFZMVDNAU;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log VCBUNADLPTQ;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log KQMOFRDRBWC;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log GPREHZNSCHO;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log AGQCWQMVFMY;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log GOVJSYIQADW;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log DDTUJSWRSIV;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log BDVXRZHENGM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log YVNFVZXTGNO;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log YFOKWRWNGMR;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log WKXAQVECFKK;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log AHSMCEYZQXD;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log KQMOFRDRBWC;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log NEURUMECPJE;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log QGDCITPSIZC;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log WBJQGXKXYEX;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log WIRXNHLJQEP;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log DQESKPEAVWB;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log QYNTGWHHTJR;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log EXGZWHXCNIF;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log TCYMELIFXOR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log CNKHGFRAIJO;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log KQMOFRDRBWC;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log IDTCDQGGZUY;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log BIFXGGYANQZ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log XIPVUSUGDAQ;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log VDKPJHRCOWT;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log HGRCMIIPRGC;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log UZXPJYERREK;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log MDQKICPWYKM;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log VMQNSCCAYFB;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log YZPPTRBPDRN;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log DRQVZKJEFAE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log MJAUOINSBGH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log YTOCOUMTLEW;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log JFCPPQVJLKG;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log DZFZWVOQNXO;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log CQWOJKKBFXC;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log RYITWYTDDVP;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log AHQIQKQHRDW;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log HGOBNBHEZFH;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log FISZQESHKUR;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log FRTWUANBOFP;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log OVJPGVZBQNT;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log GVFLMUKSKUE;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log TFPLHMOEPHM;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log TQCQCFLVQEN;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log PUSUXZYIEUP;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log AHDAIYXMICI;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log CVBFRWSSOSB;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log ORLNTNJJFUO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log OOKDJFFPJMU;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log RINXXDFEDSU;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log TFSTPNIONKO;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log SINJBXNSWBU;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log YTOCOUMTLEW;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log XTLNKLCQDOR;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log JVKBSNHZBDE;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log XSIBFJVAUOV;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log MFOVQUTIFOH;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log VARNWUMFSCB;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log TFSTPNIONKO;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log STPEEEIKIDP;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log VTTVAXMVWIN;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log YFQKEHWTEJS;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log UQWJWFNNJEF;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log HWHOUDVITZE;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log RINXXDFEDSU;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log LAWUUULTGRA;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log WCKNHMVOQGV;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log XXGWBEXRHHG;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log UOITFGJOQNZ;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log ENOUIPVKZVY;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log OKBILCSRRAI;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log RTCQLALAMIX;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log SPGVSEBXZVG;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log WUGQMXPVLSS;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log TJFXKKLPUOW;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log PRKLFCXEMER;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log INOKNNUQJCR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log OJIEDYOUWTJ;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log XZFINCLHYDU;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log DMXSKPXUBAS;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log QHYBKCFTZUI;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log AHPNQXCJWMJ;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log PSLEZHEKQFV;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log YJOGTMPMDTI;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log KLASVJKQKPA;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log QFRZUTFWZJN;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log NKOHPDXRDMN;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log LFSWRRCJEUW;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log VHRKYAIKABJ;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log NFYBELZHWIB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log OMZXUHSYEMF;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log KQGZECXWRXZ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class OWYGWNQYLJC
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log ZOEGHEBNVWR;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log DATJFPCBNSZ;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log JRLXOIVNNBC;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log ORLNTNJJFUO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000025")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				public static readonly Log YVRXJHATRYB;

				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log EJFVDMGEEMF;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log UJHXYJISYOY;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly Log EXFCRRCODBY;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log APWKGPHHOYN;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log TPMLZDIXLEC;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log CXMQOUZHTFP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log RZANBFTKVOI;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log TLYQBBJVUZY;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log CVBFRWSSOSB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log YOCRFRCMAMC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log EJNOEEYLUBS;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log UJREHRCAIIV;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log TWRUYIATCPY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log PQIEHZTEVMR;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log WCQBYMFOBOO;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log RXWXPMIEZPW;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log WIRGXAFIAGE;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log YJNEFCODSNA;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log WECIWCYRASN;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log WQUYMJBHVOE;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log CSFVADKSOLA;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log KQMOFRDRBWC;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log BOGDFOUSGKD;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log BSRENOZCYNB;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log QZBCVXZZYUH;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log NFOTOOKTKAZ;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log GEVOFGTPNFX;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log VIYYTXAAQPF;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log GQVDPUPHQIC;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log RBKYQHWISAS;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log BYHMTYHHGFF;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log OCMMSNODXWA;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log PRSQLTDCGFH;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log TPTXLFVZFYY;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log WIYEVFCUHXL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log SMFURANZQIL;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log KMNJOZZXVGQ;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log MQCYEXMVFFH;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log XIMFVTSIDIQ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log XGWUMKGNLBS;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log QVIXRRQTVLG;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log BGLUTOISIOI;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log YEKBFIRSSKC;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log GHGLYMHIMAO;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log QGYMZBTELCL;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log TJUJBNCKEKA;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log IBTEIORAEQB;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log CEUSHNLKFQK;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log BUZAHKBEJNR;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log PXINYDBKUBX;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log PSZFMVUDWLX;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002E")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				public static readonly Log ORLNTNJJFUO;

				[Cpp2IlInjected.Token(Token = "0x400011B")]
				public static readonly Log WQXQTKYECXS;

				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log JIULWOPEBBB;
			}

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			private static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log KNYMPPQOXYE;

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly Log CTPXWKIEBNW;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log XTXNGDMISKL;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log FQXEIBIQMTC;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log UQJKMFGWOMA;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log YSIGFNPELOI;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log VSQUWCWOWDW;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log NAOFITHRQMO;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log HEGLPUYKBYY;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private static readonly Log YTOCOUMTLEW;

			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly Log MJHVPOFFOHY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			public static readonly Log ORLNTNJJFUO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log RDKJDJCWJHS;

			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log QPYOGYISVZW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log ORLNTNJJFUO;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log UTFRVMJFTEK;

			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log GRBQKMFPJXT;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public static class SAWAKTIRZGJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public class VYNQNKPZPBZ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly (int index, bool enabled)[] OAXRGMSHXUI;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private List<(int index, bool enabled)> SRFKUOPBYIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private bool LVINXIGBXKU;

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x84637A0", Offset = "0x8461FA0", VA = "0x1884637A0")]
			internal VYNQNKPZPBZ((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8463720", Offset = "0x8461F20", VA = "0x188463720")]
			public IDisposable GSBTTGXXYEN()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8463670", Offset = "0x8461E70", VA = "0x188463670", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public static class PCRSHKUSIPK
	{
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		private static readonly Log YTOCOUMTLEW;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log FOGJFMGKTYE;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log JCSVXZVAPFF;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log OFQMOJAMURQ;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log TLSTIQCIJYQ;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log SQDOOJEQCDC;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log EAOUWCTHBJB;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log KMNJOZZXVGQ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log LNQOZGSWDSM;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log KIESCDWFNBS;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log IGGDJRYSNBE;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log NFBHRFNICJB;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log BFCLWNWRFLM;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log SJVHIREFWQL;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log UCHWVZMMDWG;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log EGHFNVVBFGC;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log RSHJMEMZGRT;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log XGWUMKGNLBS;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log NGPHOUWCWDW;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log LEIKWEGNMIN;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log GFFLHEYCIRK;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log OVJPGVZBQNT;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log WOPIMWLBHON;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log OBQVAZCRPDS;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log CRDDVOKTPIB;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log UUMIZGJLEBX;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log LFXRDIITDKN;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log ORLICPWZUTX;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log TCWUNPAUIYS;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log EIZZCOHITTF;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log IJPQDUETANW;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log PUNNBNMENSH;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log BPFPKSSSREK;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log AOKEUKQXJXZ;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log EKDGBETSVUK;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log AEQLQSNYAIJ;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log ARFJKLXXBPP;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log NOXULUJKRDT;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log HZKAZYXWZSP;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log UUIXUWWRGAE;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log HXCTZEZIFBU;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log YXFDSLYLNHC;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log CQEINGERJIX;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log XQCNKEEJNNA;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log FLZUYCDQHBR;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log DFDTBLKRUZV;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log VGPTQODMUGU;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log BIOXPRVWBUD;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log YOBIPRWHYWZ
		{
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x845DD90", Offset = "0x845C590", VA = "0x18845DD90")]
			get
			{
				return default(Log);
			}
		}
	}
}
namespace RecRoom.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	internal class PYDUOHUQEQT
	{
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015A")]
			private PYDUOHUQEQT parent;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xC21680", Offset = "0xC1FE80", VA = "0x180C21680")]
			public Scope(PYDUOHUQEQT parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private readonly Stopwatch GJNTJFNIDFE;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0xE48120", Offset = "0xE46920", VA = "0x180E48120")]
		public Scope FQHWFOSXKNF()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x845F280", Offset = "0x845DA80", VA = "0x18845F280")]
		public PYDUOHUQEQT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public interface QVDMCUKGJXA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IGDGTMIVBYD(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CQOEZLARUMN(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void EGYFPFCPENJ(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x845A500", Offset = "0x8458D00", VA = "0x18845A500")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x845A490", Offset = "0x8458C90", VA = "0x18845A490", Slot = "4")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[Preserve]
	public abstract class LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(Slot = "4")]
		public abstract void JPLRKQDWIBU();

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	internal static class SPXLXNZJCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static List<LogRegistrationIndex> MCKIEDSMAFG;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static bool KUUIPZAHTAP;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly object XZTLAPNCNOS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> ZFUKKGNXURW
		{
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x8461B30", Offset = "0x8460330", VA = "0x188461B30")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x8461B70", Offset = "0x8460370", VA = "0x188461B70")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8461F20", Offset = "0x8460720", VA = "0x188461F20")]
		private static void XMYCBKMMIDY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x8461CE0", Offset = "0x84604E0", VA = "0x188461CE0")]
		private static void RHWQPJQSWWZ(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public static class BABPIMOKISY
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003D")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000096")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
			public void DGGKHBNMXWI(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10")]
			public ParanoiaLevel VJYHQMIXWKY(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAAEAD0", Offset = "0xAAD2D0", VA = "0x180AAEAD0")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public static Action VIROSZPZYYJ;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object LASOJANGEEB;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly Dictionary<(int parentIndex, string token), int> IBROJVYHPRV;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly List<string> GZVTPFGCFMH;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly List<int> NOVEYGTPPEW;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<ulong> GGZXEGKVCTM;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<ulong> HEGWSGGPNFF;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> WLRZEZVVIQW;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly StringBuilder GFIQYDJVMHA;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly PYDUOHUQEQT DBHULOOYJOA;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static Debug VVSUWCHCBZU;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static int SZGKNUCVLXA;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static QVDMCUKGJXA PKJXWGLGWGP
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8454870", Offset = "0x8453070", VA = "0x188454870")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8455930", Offset = "0x8454130", VA = "0x188455930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool GWQDPSTTYXK
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8456790", Offset = "0x8454F90", VA = "0x188456790")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool CULQZTYVZPE
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x84567E0", Offset = "0x8454FE0", VA = "0x1884567E0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool OEYVEBUHAUF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x8454CF0", Offset = "0x84534F0", VA = "0x188454CF0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8455DC0", Offset = "0x84545C0", VA = "0x188455DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x8457250", Offset = "0x8455A50", VA = "0x188457250")]
		static BABPIMOKISY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x8454D80", Offset = "0x8453580", VA = "0x188454D80")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8455050", Offset = "0x8453850", VA = "0x188455050")]
		public static int JPLRKQDWIBU(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x84551F0", Offset = "0x84539F0", VA = "0x1884551F0")]
		public static int JPLRKQDWIBU(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x8455E10", Offset = "0x8454610", VA = "0x188455E10")]
		public static Log RMKZRLMVTAU(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x8455C00", Offset = "0x8454400", VA = "0x188455C00")]
		public static void PSHQPUGTFLH(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8456D00", Offset = "0x8455500", VA = "0x188456D00")]
		public static void XWSDYQWYWXQ(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x84547B0", Offset = "0x8452FB0", VA = "0x1884547B0")]
		public static bool DEUIXDTTIOY(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x8454BA0", Offset = "0x84533A0", VA = "0x188454BA0")]
		public static int HGEHHXQKHKT(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8456530", Offset = "0x8454D30", VA = "0x188456530")]
		public static string UBFVCGLJMGS(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8456870", Offset = "0x8455070", VA = "0x188456870")]
		public static (string[], int[]) VKQOHWRIBIV()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x8455AE0", Offset = "0x84542E0", VA = "0x188455AE0")]
		private static int PPFISHIVENZ(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x84548C0", Offset = "0x84530C0", VA = "0x1884548C0")]
		private static int DZGGNGOYJUZ(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x8455E60", Offset = "0x8454660", VA = "0x188455E60")]
		private static int RRPWHLYEBEP(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x84546E0", Offset = "0x8452EE0", VA = "0x1884546E0")]
		private static int DANZPJHHSLW(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x8454510", Offset = "0x8452D10", VA = "0x188454510")]
		private static int DANZPJHHSLW(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x8454970", Offset = "0x8453170", VA = "0x188454970")]
		private static void FLKMSXRFKQH(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8454AE0", Offset = "0x84532E0", VA = "0x188454AE0")]
		public static bool HDSNIUTVHWX(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x8454F90", Offset = "0x8453790", VA = "0x188454F90")]
		public static bool JIYLKCCZDGW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8456F10", Offset = "0x8455710", VA = "0x188456F10")]
		private static void YUCMJOIACCW(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x8454060", Offset = "0x8452860", VA = "0x188454060")]
		public static void BXYIVJJPQGO(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x8455580", Offset = "0x8453D80", VA = "0x188455580")]
		public static void LTEOWZCIMMB(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x84564D0", Offset = "0x8454CD0", VA = "0x1884564D0")]
		private static void TAKZUUMXLPY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x8456A90", Offset = "0x8455290", VA = "0x188456A90")]
		private static void XARQNDZITTJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x84559A0", Offset = "0x84541A0", VA = "0x1884559A0")]
		private static bool OBYIPBXVYRU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x84552C0", Offset = "0x8453AC0", VA = "0x1884552C0")]
		private static bool JTALKUVDYGF(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8456A10", Offset = "0x8455210", VA = "0x188456A10")]
		private static bool WBXIBNLXMIN(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x84563A0", Offset = "0x8454BA0", VA = "0x1884563A0")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x8456460", Offset = "0x8454C60", VA = "0x188456460")]
		private static void TAKHABONNGD(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8455410", Offset = "0x8453C10", VA = "0x188455410")]
		public static SAWAKTIRZGJ.VYNQNKPZPBZ JVAZBYCXWLX((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8454830", Offset = "0x8453030", VA = "0x188454830")]
		public static void DGGKHBNMXWI(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x8456830", Offset = "0x8455030", VA = "0x188456830")]
		public static ParanoiaLevel VJYHQMIXWKY(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		MassivelyParanoid
	}
}
namespace RecRoom.Logging.Attributes
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	[Obfuscation(Exclude = true)]
	public class PreserveAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
