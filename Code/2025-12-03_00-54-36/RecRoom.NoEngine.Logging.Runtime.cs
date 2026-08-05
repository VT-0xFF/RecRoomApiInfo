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
		[Cpp2IlInjected.Address(RVA = "0x8329740", Offset = "0x8328340", VA = "0x188329740", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xC6CF70", Offset = "0xC6BB70", VA = "0x180C6CF70")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PCVVLEDOEWS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x832AF20", Offset = "0x8329B20", VA = "0x18832AF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool TTFJHPSUHEC
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x832AFE0", Offset = "0x8329BE0", VA = "0x18832AFE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string JVRXXTWNEEQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x832B930", Offset = "0x832A530", VA = "0x18832B930")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool HYLNHOWUFPN
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x5296410", Offset = "0x5295010", VA = "0x185296410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel SAZSLNHJZXY
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x832B8C0", Offset = "0x832A4C0", VA = "0x18832B8C0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x832C3E0", Offset = "0x832AFE0", VA = "0x18832C3E0")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x12A8BC0", Offset = "0x12A77C0", VA = "0x1812A8BC0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x832C440", Offset = "0x832B040", VA = "0x18832C440")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x37A7680", Offset = "0x37A6280", VA = "0x1837A7680")]
		public void WTQXZATACKH<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x832BFE0", Offset = "0x832ABE0", VA = "0x18832BFE0")]
		public void WTQXZATACKH(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x832C100", Offset = "0x832AD00", VA = "0x18832C100")]
		public void WTQXZATACKH(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x832AAA0", Offset = "0x83296A0", VA = "0x18832AAA0")]
		public void DNJHDJNFXZK(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x37A5270", Offset = "0x37A3E70", VA = "0x1837A5270")]
		public void JXCZAZBXOGF<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x832B350", Offset = "0x8329F50", VA = "0x18832B350")]
		public void JXCZAZBXOGF(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x832B250", Offset = "0x8329E50", VA = "0x18832B250")]
		public void JXCZAZBXOGF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x37A2FD0", Offset = "0x37A1BD0", VA = "0x1837A2FD0")]
		public void FLDKZDQJMCO<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x832ACD0", Offset = "0x83298D0", VA = "0x18832ACD0")]
		public void FLDKZDQJMCO(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x832ABC0", Offset = "0x83297C0", VA = "0x18832ABC0")]
		public void FLDKZDQJMCO(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x37A8920", Offset = "0x37A7520", VA = "0x1837A8920")]
		public void XKWSIQEAOSL<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x832C2E0", Offset = "0x832AEE0", VA = "0x18832C2E0")]
		public void XKWSIQEAOSL(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x832C200", Offset = "0x832AE00", VA = "0x18832C200")]
		public void XKWSIQEAOSL(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x37A5A70", Offset = "0x37A4670", VA = "0x1837A5A70")]
		public void LACGMOBITPS<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x832B4E0", Offset = "0x832A0E0", VA = "0x18832B4E0")]
		public void LACGMOBITPS(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x832B5E0", Offset = "0x832A1E0", VA = "0x18832B5E0")]
		public void LACGMOBITPS(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x37A6260", Offset = "0x37A4E60", VA = "0x1837A6260")]
		public void LIIGYBYOTSV<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x832B6D0", Offset = "0x832A2D0", VA = "0x18832B6D0")]
		public void LIIGYBYOTSV(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x832B7D0", Offset = "0x832A3D0", VA = "0x18832B7D0")]
		public void LIIGYBYOTSV(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x832AF70", Offset = "0x8329B70", VA = "0x18832AF70")]
		public void HRGEHKCNRCC(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x832B470", Offset = "0x832A070", VA = "0x18832B470")]
		public void KBLWFWONHDN(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x37A4C50", Offset = "0x37A3850", VA = "0x1837A4C50")]
		public LogRangeScope JLIXWLTVLJO<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LogRangeScope VDPPSJNXLWL<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x832B030", Offset = "0x8329C30", VA = "0x18832B030")]
		public LogRangeScope JLIXWLTVLJO(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x832B150", Offset = "0x8329D50", VA = "0x18832B150")]
		public LogRangeScope JLIXWLTVLJO(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xDECA20", Offset = "0xDEB620", VA = "0x180DECA20")]
		public LogRangeScope VDPPSJNXLWL(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x832BCE0", Offset = "0x832A8E0", VA = "0x18832BCE0")]
		public void UZIMCWKUHKA(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x832BDC0", Offset = "0x832A9C0", VA = "0x18832BDC0")]
		public void UZIMCWKUHKA(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x37A6970", Offset = "0x37A5570", VA = "0x1837A6970")]
		public void UZIMCWKUHKA<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
		public void KLMPRELYEFJ([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x832AE00", Offset = "0x8329A00", VA = "0x18832AE00")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x832B980", Offset = "0x832A580", VA = "0x18832B980")]
		private static void PYHKZIEKTSR(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log FUNBQQXQNUV;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log QACDOFQEOMM;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log VLJGMMZJOGC;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log WEMVPSDEIQD;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log TBBLLJEYAPJ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log AWXJMUKXBTD;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log PZEMAYSFUGE;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log CKXWCIVKVED;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log OKWSERQHPMW;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log IFJSOIFDLCR;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log PZTFMEQYYLF;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log UYHEQVKJGXV;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log YARYUYTEOIN;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log TQRRGAZVQLU;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log HNBVEXCAYCE;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log DZKQUASHIGC;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log TNEKXWYEEQK;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log XZHBYRSHEAF;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log KXNPDQVWIOO;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log TGHCMPCPVES;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log TGKCEBTPSKM;
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
					public static readonly Log YIXXFNMRNWW;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log VVVOTRWKSEA;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log ZSQLMBSIDKW;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log XRVZBTGFTOF;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log SBWKAYDNEEV;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log BJOUIHIDITV;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log DEYUGMJYCAB;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log AHYMCUUDOKH;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log ZSQLMBSIDKW;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log SBWKAYDNEEV;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log BJOUIHIDITV;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log NMRQRWFTYSE;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log CJRXAHQNJSP;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log IDVNVBKIWYJ;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log KWVULBCVGDX;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log FXJCWALLYRI;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log YIXXFNMRNWW;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log PVXHCZHUXFY;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log PWCOAGBSGRH;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log PVMTILUAEJG;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log PVSAFSNXNUP;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log PWSISAJKIZI;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log PWXPPHDHSKR;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log PWHUXMVPQCQ;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log PWNBUTPMZNZ;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log PXNKHBKZUSS;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log PXSREIEXEEB;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log YIXXFNMRNWW;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log PVXHCZHUXFY;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log PWCOAGBSGRH;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log PVMTILUAEJG;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log PVSAFSNXNUP;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log PWSISAJKIZI;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log PWXPPHDHSKR;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log PWHUXMVPQCQ;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log PWNBUTPMZNZ;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log PXNKHBKZUSS;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log PXSREIEXEEB;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log YIXXFNMRNWW;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log VCTGQKYJMQO;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log OWAINWKTMLI;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log NWEOROECKWW;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log CBAJCWBXZZQ;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log NXZUZIMVKDL;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log ZHWWXNVYEEL;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log VKQVXDRKQIY;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log SKHFFEPWFGB;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log PBRGQDZJJEU;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log CRIXHWYXIMI;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log AVUAGAYFZTE;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log NIWOAJWGGGC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log CTDBXYMEQAD;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log JTQZSHZWANO;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log YVRRFMINBIC;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log PPJUYLDPZDI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log QRMTTRSMGQC;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log FRAAOEUEFQZ;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log EXCRBMSHZMA;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log HEZGGVLZQMW;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log BICVJKMWPLN;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log YXKNSFJLXTX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log QGMDGIVDSTS;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log TNUDSXTESNB;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log FSFLBGKHBTF;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log VTWXSBYGTSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log PFJQBHCPIGI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log QWXJCSJJHTS;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log XBNACGFEZWG;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log HEZGGVLZQMW;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log MBTVVQOQXWA;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log TGKCEBTPSKM;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log FTADWQBLPOQ;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log JTSNLYJUQEB;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log PBRGQDZJJEU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log XLTOYCFLRSU;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log AZJPYVYLFRP;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log BFTUCYMTEFM;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log WFWOEHYIJUZ;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log HEZGGVLZQMW;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log GSTLFUQONTU;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log AXMBKWNNWOE;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log BUAMENEEYQD;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log AGODGMWOPLJ;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log VKJBNGWEWZD;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log AWOCEDEHLPR;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log PNCQTOTUNOV;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log PYRSQJIPFBH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log RESXSJQUENS;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log HEZGGVLZQMW;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log ZXOBQEVXHIM;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log DDNAAERVTCZ;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log JWPGBGLQAEI;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log TMEGTJZEEET;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log AAKOTDRAFRY;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log IDUPTZUBJDI;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log PKUBYGLMTQI;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log DYXEOSDHHVR;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log KNQXZZROTNW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public static readonly Log ZSTMFUQUTDB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				private static readonly Log ILAMAUQBTHE;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log TZLXTODTBGC;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log KWEEWVYLJHK;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log UMQVHAUTAGE;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log AJKVIAADUJX;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log PRAKGWYQTOU;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log HOCFJUFACYR;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log IFWTDZRVHIR;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log JPYFTKIOVXT;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log IFJSOIFDLCR;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log NMRQRWFTYSE;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log XUQXENXDHTQ;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log KODCALRTJFL;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log TEDROYGXZDB;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log OKBGWWRWXZC;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log LMICPKAILIF;
			}

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log YIXXFNMRNWW;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log DYHNURRTOGY;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log WFRLSLPAPBC;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log AQBEZSEJJEW;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log LKWXUYYUAEK;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B4")]
					private static readonly Log ILAMAUQBTHE;

					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					public static readonly Log DPOYKUPLGXX;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log LTFIOKNDHHI;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log BRLULYZEZHL;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log DHQAYMFWBWT;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log UJFFQLTKFDH;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log AQBEZSEJJEW;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log LISQNLLRDUV;
				}

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log UNZHJXSLLSB;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log CKPJZWXPSJW;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log JCKHCBTEAFD;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log VFHETQRTDNQ;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log WFRLSLPAPBC;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log KFNFKVVXJXU;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log DAFAFOGPHON;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log ZBUJYFXHJNO;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log MDHFOEHGWJV;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log ADWLDRXXYWG;
			}

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log DXJJVEMZTIE;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log NAPMMFKAFGT;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log HCTFBZXCKYI;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log MJMQYXJPEKK;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log BAPWUBLSGAO;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log UKWSRFGHJAJ;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log AOQKHLBQNIB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log KSEUUMWGCKH;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log JBUWPVCEUQW;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log KKBEGGFQSCW;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log HIKPAOQSGRW;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log XOCLNDMNOPP;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log GUHZOBXOTST;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log AUAQNEDUGVM;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log NVYFTVWTBEO;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log KKMTMCWXDFR;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log BRWCWQMKWKZ;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log QPVTBLJPYTE;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log FODTQZTMUQP;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log PCALWIEELRP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log JLQFDGUFOJH;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log XIVXRBKQIYX;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class EWLFCNPSLWE
			{
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log MQQIUEYIVKV;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log HAEXZQLGJDL;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log NVHTINQKWEM;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public static readonly Log YIXXFNMRNWW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			public static readonly Log SCXLOUPQRMO;

			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly Log VEPOEDZBYRP;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log IEIDFJMSBYG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log UNMEEMNLRDS;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log VIIUWDTRCMO;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log LMICPKAILIF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log QFWYTRNCXNI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log RQIPHPTBGMQ;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log IWYSISOKCOV;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log VITNKETVZBE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log KODNQUHYBQN;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log JQMGPEFRUMC;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log EFPAVTZJFAI;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log TNKKQUGAVHK;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log VCUXHWCJDWO;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log MZAVASEQNBP;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log FILTNEXHTSA;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log KXNQBEIUTJU;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log HEZGGVLZQMW;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log SXKZZXRTABB;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log KDKTQYKQZVJ;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log WTLWWBFXPEP;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log PQKQPVQALJX;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log CDEKBSNNUWF;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log TKQGBECMILZ;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log YPYDEYDUTPM;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log NEYTXHJTPKO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log WEMVPSDEIQD;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log LNDTDZYMGPW;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log AJADBZDFQHP;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log UKEXEYTDICM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log VCMOBQTEHEF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log SKOIPQAKDOH;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log KVNHRZDXMUM;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log EUZGUKJDQON;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log FFNOVZAADYM;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log KNXYIYPUAIE;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log JVXWNJQSGUE;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log JOSWXBMIUXK;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log QJJJSPQIXFM;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log ADUFMASSHJM;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log XDFRNDZPSIP;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log MIBYTPNLDUU;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log FLEDMYKKRMR;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log ATNYTMCWHUG;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log SQTYKEJFUOP;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log SWKNAKMPCJD;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log IDVNVBKIWYJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				public static readonly Log YIXXFNMRNWW;

				[Cpp2IlInjected.Token(Token = "0x4000115")]
				public static readonly Log UMWMIYDGNRG;

				[Cpp2IlInjected.Token(Token = "0x4000116")]
				public static readonly Log CXDBDAQXEAL;
			}

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log AQZKPAPJGFC;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log AENLTGFBRQM;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log RGTZYLELEKX;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log SFPJULBDAYU;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log IHFKRYMSJDS;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log OMXOFORKMTO;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log GAYRXUPMEWU;

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			public static readonly Log YYNBMYEKNOS;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log HSDKLHXBBCY;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private static readonly Log ILAMAUQBTHE;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log OWRYQLXKHCS;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log YIXXFNMRNWW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log OTHONVBSOZO;

			[Cpp2IlInjected.Token(Token = "0x400011C")]
			public static readonly Log GPFZXDVYHWI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			public static readonly Log YIXXFNMRNWW;

			[Cpp2IlInjected.Token(Token = "0x400011E")]
			public static readonly Log RDYZTQUNQBY;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class LPXNOOPWSBD
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class UQMWQOIUYSH : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly (int index, bool enabled)[] CFBSZANMUTC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private List<(int index, bool enabled)> JNHSIVSFENY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private bool RLIUJIPOYPC;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x8333FC0", Offset = "0x8332BC0", VA = "0x188333FC0")]
			internal UQMWQOIUYSH((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8333F40", Offset = "0x8332B40", VA = "0x188333F40")]
			public IDisposable GBZNEHAAGFP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x8333E90", Offset = "0x8332A90", VA = "0x188333E90", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class CNYWQGUTYQM
	{
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		private static readonly Log ILAMAUQBTHE;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Log PLBBDIDEJEI;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log AAQLOMCSCST;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log JPWDBDLKLCG;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log SLCFYSGNAHC;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log UUDPGXOZTZG;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log NQKEXWWOOOH;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log KVNHRZDXMUM;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log RIGBOFZVFFC;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log KEMIAXTJXWU;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log DCNWPTKXVMS;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log FLSUYOEDPMD;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log HXAGBRTQTLI;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log WYFCLMCBAIP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log JVEOCFGFUCO;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log CWCOODWJSLA;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log WCIWJRUODNL;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log KNXYIYPUAIE;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log QTYKYBKXKSM;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log PSRGKVNUDOR;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log VZYRTFJVZFC;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log IFJSOIFDLCR;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log JCPGAOKFZRT;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log PEHQIPHQZCA;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log WTNOWPRVTWZ;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log LISOFNMLTYB;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log ILWLIXFOVOZ;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log GOPQCOTZGZX;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log QSCCRTDTLNA;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log HWEYMNDJGTF;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log FNWWMUHQTHS;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log ZSRVNJUEJKT;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log LDTUXCOFPVE;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log VQVBLZROXMT;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log VTFMODVWFXY;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log XRVZBTGFTOF;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log ZBFVHJDTXOV;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log ONKNORQBLFL;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log UJFBNJAKDPZ;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log AMQEIQRWDDO;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log ZDYIJKDDRJY;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log JIDNACPVXGQ;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log EBLXWAKYBJJ;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log JFWUIZWRDEO;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log OHEHTTIXOVZ;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log XQZJTYGQCAT;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log ATSSAYCHIIM;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log RZFFMNRXPRF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log YVHRYHPMARH
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8324770", Offset = "0x8323370", VA = "0x188324770")]
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
	internal class LZLTNPEGWZV
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			private LZLTNPEGWZV parent;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xBB8EF0", Offset = "0xBB7AF0", VA = "0x180BB8EF0")]
			public Scope(LZLTNPEGWZV parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly Stopwatch EDULZZJCZYC;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0xDE5490", Offset = "0xDE4090", VA = "0x180DE5490")]
		public Scope YOFKJGDYHMP()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x83291F0", Offset = "0x8327DF0", VA = "0x1883291F0")]
		public LZLTNPEGWZV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface HZOTUTVKMNU
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WTQXZATACKH(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void JXCZAZBXOGF(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void XKWSIQEAOSL(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x83296A0", Offset = "0x83282A0", VA = "0x1883296A0")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x8329630", Offset = "0x8328230", VA = "0x188329630", Slot = "4")]
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
		public abstract void OGBNJYRINGK();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class CPUMSHMLPAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private static List<LogRegistrationIndex> DWUYHOIJAHG;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static bool CDCGATQZZIT;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly object THOCUGMTBYS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> JTSLWINZEWA
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x8326140", Offset = "0x8324D40", VA = "0x188326140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8325D80", Offset = "0x8324980", VA = "0x188325D80")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8326180", Offset = "0x8324D80", VA = "0x188326180")]
		private static void NAXANGYVEOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8325F00", Offset = "0x8324B00", VA = "0x188325F00")]
		private static void JWTOIGQJIJX(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class PWKKOBWAYJW
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
			public void PDHGPPOJCLW(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370")]
			public ParanoiaLevel RYLALOHKDEU(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xA96150", Offset = "0xA94D50", VA = "0x180A96150")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static Action UKUEKOGHFUR;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly object VOCFBADSJOF;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly Dictionary<(int parentIndex, string token), int> SFWINRXEAXB;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly List<string> YDVRHLMPJED;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly List<int> GPTPCDVJAFM;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static readonly List<ulong> TLWJKFCFCZE;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static readonly List<ulong> BPQVAALHZGX;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static readonly List<ulong> XIDBMIVEZOS;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly StringBuilder ONGZMAGKAHU;

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private static readonly LZLTNPEGWZV MIHMEFXFBWU;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static Debug PEMILQMIYPQ;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static int ZZENLBZGUWS;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static HZOTUTVKMNU MWIDAKSTXDV
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x832F380", Offset = "0x832DF80", VA = "0x18832F380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x832E3E0", Offset = "0x832CFE0", VA = "0x18832E3E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool HERNILQDUNC
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x832F840", Offset = "0x832E440", VA = "0x18832F840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool LZISHQZVONY
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x832FA90", Offset = "0x832E690", VA = "0x18832FA90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool EZNFFVPRACN
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x832F6B0", Offset = "0x832E2B0", VA = "0x18832F6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x832FDD0", Offset = "0x832E9D0", VA = "0x18832FDD0")]
		static PWKKOBWAYJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x832E1D0", Offset = "0x832CDD0", VA = "0x18832E1D0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x832EBC0", Offset = "0x832D7C0", VA = "0x18832EBC0")]
		public static int OGBNJYRINGK(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x832ED60", Offset = "0x832D960", VA = "0x18832ED60")]
		public static int OGBNJYRINGK(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x832FA40", Offset = "0x832E640", VA = "0x18832FA40")]
		public static Log WKFJPJPPBVG(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x832FAE0", Offset = "0x832E6E0", VA = "0x18832FAE0")]
		public static void YHHEYYAWGDP(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x832E450", Offset = "0x832D050", VA = "0x18832E450")]
		public static void LBRUWTZDCJQ(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x832D860", Offset = "0x832C460", VA = "0x18832D860")]
		public static bool DFQPCPZYEEY(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x832F1F0", Offset = "0x832DDF0", VA = "0x18832F1F0")]
		public static int OTIPYRZGAST(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x832D8E0", Offset = "0x832C4E0", VA = "0x18832D8E0")]
		public static string DYURDYFXZDQ(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x832F890", Offset = "0x832E490", VA = "0x18832F890")]
		public static (string[], int[]) VBYBOJQNUPP()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x832CDE0", Offset = "0x832B9E0", VA = "0x18832CDE0")]
		private static int AKHUTXMBPYD(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x832E0B0", Offset = "0x832CCB0", VA = "0x18832E0B0")]
		private static int HXTGXJVKHWB(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x832DB50", Offset = "0x832C750", VA = "0x18832DB50")]
		private static int EARBYFULDHF(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x832D460", Offset = "0x832C060", VA = "0x18832D460")]
		private static int CQPHERWFNPO(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x832D530", Offset = "0x832C130", VA = "0x18832D530")]
		private static int CQPHERWFNPO(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x832E9D0", Offset = "0x832D5D0", VA = "0x18832E9D0")]
		private static void NVZXWKKBNAX(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x832FCA0", Offset = "0x832E8A0", VA = "0x18832FCA0")]
		public static bool YMMMRLEKLBN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x832E660", Offset = "0x832D260", VA = "0x18832E660")]
		public static bool NFVGQPKLBMG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x832CF00", Offset = "0x832BB00", VA = "0x18832CF00")]
		public static void AXONYCHSVIC(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x832EE30", Offset = "0x832DA30", VA = "0x18832EE30")]
		public static void OIPQXRJDKSZ(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x832E160", Offset = "0x832CD60", VA = "0x18832E160")]
		private static void IJBSNDHQYHQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x832F3D0", Offset = "0x832DFD0", VA = "0x18832F3D0")]
		private static void QACOAOCVWPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x832E720", Offset = "0x832D320", VA = "0x18832E720")]
		private static bool NSSEHMJYECW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x832D700", Offset = "0x832C300", VA = "0x18832D700")]
		private static bool CVVUEQACHZP(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x832EB40", Offset = "0x832D740", VA = "0x18832EB40")]
		private static bool OECEDCPAPBD(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x832F780", Offset = "0x832E380", VA = "0x18832F780")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x832FD60", Offset = "0x832E960", VA = "0x18832FD60")]
		private static void YTSTMMGSWLJ(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x832E860", Offset = "0x832D460", VA = "0x18832E860")]
		public static LPXNOOPWSBD.UQMWQOIUYSH NVHLKVRAXGR((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x832F340", Offset = "0x832DF40", VA = "0x18832F340")]
		public static void PDHGPPOJCLW(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x832F740", Offset = "0x832E340", VA = "0x18832F740")]
		public static ParanoiaLevel RYLALOHKDEU(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x400016F")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
