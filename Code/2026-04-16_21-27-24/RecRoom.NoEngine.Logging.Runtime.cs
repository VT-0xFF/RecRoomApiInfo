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
		[Cpp2IlInjected.Address(RVA = "0x99A77E0", Offset = "0x99A65E0", VA = "0x1899A77E0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
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
			[Cpp2IlInjected.Address(RVA = "0xF430D0", Offset = "0xF41ED0", VA = "0x180F430D0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool JPBZDZEMXLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x99A9870", Offset = "0x99A8670", VA = "0x1899A9870")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool JZWTNCHQYWE
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99A91D0", Offset = "0x99A7FD0", VA = "0x1899A91D0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string AALLBBZXAZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x99A9D50", Offset = "0x99A8B50", VA = "0x1899A9D50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool FFOFFAGVGVT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x68E05E0", Offset = "0x68DF3E0", VA = "0x1868E05E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel NXURRFSSKPS
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x99A9CE0", Offset = "0x99A8AE0", VA = "0x1899A9CE0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99AA500", Offset = "0x99A9300", VA = "0x1899AA500")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15B28E0", Offset = "0x15B16E0", VA = "0x1815B28E0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99AA560", Offset = "0x99A9360", VA = "0x1899AA560")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6F10", Offset = "0x3BF5D10", VA = "0x183BF6F10")]
		public void MXVFDTBJCKB<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99A9650", Offset = "0x99A8450", VA = "0x1899A9650")]
		public void MXVFDTBJCKB(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99A9770", Offset = "0x99A8570", VA = "0x1899A9770")]
		public void MXVFDTBJCKB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9440", Offset = "0x3BF8240", VA = "0x183BF9440")]
		public void RDBKHLXUZUK<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99A98C0", Offset = "0x99A86C0", VA = "0x1899A98C0")]
		public void RDBKHLXUZUK(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BF18E0", Offset = "0x3BF06E0", VA = "0x183BF18E0")]
		public void CAQAIZFSWPR<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99A8DB0", Offset = "0x99A7BB0", VA = "0x1899A8DB0")]
		public void CAQAIZFSWPR(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99A8ED0", Offset = "0x99A7CD0", VA = "0x1899A8ED0")]
		public void CAQAIZFSWPR(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BF6070", Offset = "0x3BF4E70", VA = "0x183BF6070")]
		public void LOXQZVBUDUY<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99A9330", Offset = "0x99A8130", VA = "0x1899A9330")]
		public void LOXQZVBUDUY(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99A9220", Offset = "0x99A8020", VA = "0x1899A9220")]
		public void LOXQZVBUDUY(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA4D0", Offset = "0x3BF92D0", VA = "0x183BFA4D0")]
		public void WNWDMFNTXOB<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99AA400", Offset = "0x99A9200", VA = "0x1899AA400")]
		public void WNWDMFNTXOB(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99AA320", Offset = "0x99A9120", VA = "0x1899AA320")]
		public void WNWDMFNTXOB(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BF64C0", Offset = "0x3BF52C0", VA = "0x183BF64C0")]
		public void MDBNHUCIYSW<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99A9550", Offset = "0x99A8350", VA = "0x1899A9550")]
		public void MDBNHUCIYSW(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99A9460", Offset = "0x99A8260", VA = "0x1899A9460")]
		public void MDBNHUCIYSW(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF1220", Offset = "0x3BF0020", VA = "0x183BF1220")]
		public void AVDNRXILWKD<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99A8CB0", Offset = "0x99A7AB0", VA = "0x1899A8CB0")]
		public void AVDNRXILWKD(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99A8BC0", Offset = "0x99A79C0", VA = "0x1899A8BC0")]
		public void AVDNRXILWKD(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99A9040", Offset = "0x99A7E40", VA = "0x1899A9040")]
		public void EQLWFBUMFJK(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99A8FD0", Offset = "0x99A7DD0", VA = "0x1899A8FD0")]
		public void EIZAHKEHEBH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BFA1D0", Offset = "0x3BF8FD0", VA = "0x183BFA1D0")]
		public LogRangeScope TISHOAWWBLA<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10F62D0", Offset = "0x10F50D0", VA = "0x1810F62D0")]
		public LogRangeScope EYSDXJXSJNP<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99A9EA0", Offset = "0x99A8CA0", VA = "0x1899A9EA0")]
		public LogRangeScope TISHOAWWBLA(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99A9DA0", Offset = "0x99A8BA0", VA = "0x1899A9DA0")]
		public LogRangeScope TISHOAWWBLA(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10F62D0", Offset = "0x10F50D0", VA = "0x1810F62D0")]
		public LogRangeScope EYSDXJXSJNP(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99A9C00", Offset = "0x99A8A00", VA = "0x1899A9C00")]
		public void SIEYGSMAFAC(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99A99E0", Offset = "0x99A87E0", VA = "0x1899A99E0")]
		public void SIEYGSMAFAC(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BF9A30", Offset = "0x3BF8830", VA = "0x183BF9A30")]
		public void SIEYGSMAFAC<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
		public void DYJZWIESXFH([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99A90B0", Offset = "0x99A7EB0", VA = "0x1899A90B0")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99A9FC0", Offset = "0x99A8DC0", VA = "0x1899A9FC0")]
		private static void VJOYECCWKQH(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log EOPRKOBRQFZ;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log BUVWYQKYZCW;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log YZSFZRIKEQI;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log YPXLAGXJNMJ;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log PXUWVBIVPWJ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log PMAHMDUXGTN;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log AJQWCKCTCVI;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log UXWTVQCAHGN;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log OUCAJKPSFWY;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log EVWWFKQWMEL;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log FKWTKDYPWND;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log LQCQANUNEQN;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log LPMLHODWUHN;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log YAIGNYHBXFS;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log AIMOXFWYTTU;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log CUSEVGNKBWA;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log NBPFHPYKGCE;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log QBNCNMFSOUX;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log MBNMINITZJS;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log NGTLAKJGGOE;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log MDJOGYGLROG;
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
					public static readonly Log MYCHMBYYZUE;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log ADPFKEBYGLY;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log TIONSBHFPTW;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log LMFIXBRONLV;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log ENVHUZMZRZJ;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log ANPIILVVZLT;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log MMWNTOBZZHV;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log CVGNOUNBXSB;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log TIONSBHFPTW;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log ENVHUZMZRZJ;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log ANPIILVVZLT;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log RTUGQVFYTIG;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log MDPJOTKMOZT;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log DPOCHGJAZUP;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log WQOTHGNYIWP;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log EEXRBPMPONG;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log MYCHMBYYZUE;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log IXOXEUHZXTO;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log IXUECBBXHEX;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log IXZKZHVUQQG;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log IYERWOPSABP;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log IYJYTVJPJMY;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log IYPFRCDMSYH;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log IYUMOIXKCJQ;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log IYZTLPRHLUZ;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log IZFAIWLEVGI;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log IZKHGDFCERR;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log MYCHMBYYZUE;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log IXOXEUHZXTO;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log IXUECBBXHEX;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log IXZKZHVUQQG;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log IYERWOPSABP;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log IYJYTVJPJMY;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log IYPFRCDMSYH;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log IYUMOIXKCJQ;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log IYZTLPRHLUZ;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log IZFAIWLEVGI;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log IZKHGDFCERR;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log MYCHMBYYZUE;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log LVJTPEKCWCQ;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log SUSUWEOAUNG;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log CCNEJKNLNSU;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log TNYHCBICBOE;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log OTKLJCGMJIP;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log MAVNGZPTWQB;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log FWXLOPJQVWC;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log APBVASXBUPF;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log GFVROPMBPKS;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log XCDEONDKKNA;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log CURVMLUMHTW;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log BOWKOPCYTLS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log ATDERDSJOHH;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log OQYEGGIRMEK;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log IBAKEKGHFUA;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log AJVHXXBXBMM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log QVICJMUAONC;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log SCTBDVFCUAP;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log HZIBIQUWQNQ;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log PXWICFQJHRG;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log HWKKGDXCXMV;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log WKQILIXNGHN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log IRMFOGUTEQW;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log FBVDFPHKVVH;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log HXCLTKEMTTD;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log HCKMVNORNJG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log PARUYQCKVYW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log KIIFFZCJAYW;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log UINIYLYBHOM;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log PXWICFQJHRG;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log IXJTZRXOGKG;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log MDJOGYGLROG;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log PWZPVVAZRNU;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log OMKVXPXVPZR;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log GFVROPMBPKS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log ZQIBAMFEWYK;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log PXGLRRPIYYH;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log MJPBWZWYLYQ;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log WQIYAJCGUTZ;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log PXWICFQJHRG;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log UKFSXATOYVW;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log IRQFVJRRRBA;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log QARQQHUIMUJ;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log BFFPMYSNINL;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log ZKQXKRPHHAD;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log FEDPYNGMEKR;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log KZYYKJXRPOH;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log ZDNXYUGQZDZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log ZAIJXUXKYHI;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log PXWICFQJHRG;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log ISDMMTKZSPM;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log JDSIJCCODAP;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log KOCYRXBUOEG;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log IMNZHIQCRFP;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log ABIIRLZUTWY;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log EHYGKZFWULO;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log PQHXTWALYRA;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log SKSUKFZNKBP;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log CJAPBHSJRDX;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log ULQLYCRPVSG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log AKIVRHTLSRP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log HVGOLUCVCZW;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log UMODCLXYVGY;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log PWZFQYQWOJY;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log THYGTANLOAS;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log WCXTOXRTWYX;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log DJEMSCTKPUG;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log LWPGVLOYBIP;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log WQUAOAUFSGP;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log GPQNSKJNLNR;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log EVWWFKQWMEL;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log RTUGQVFYTIG;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log KQIUNMDIHPS;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log OUIDBMKEHPJ;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log YXDZNKGUVHX;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log HERUJKSIDRU;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log SMMLCDPMXAP;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log MYCHMBYYZUE;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log JHZTXMSCRNY;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log MUJRBXYITYO;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log VJAJIYGWGXS;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log DFKJALSGSVO;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log HVGOLUCVCZW;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log KYGTHRWLMQX;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log VGFTZEZHLNW;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log VFKNADAVPTV;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log DQVRIFSIQNX;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log PZNHWBGPOBB;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log VJAJIYGWGXS;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log ZYVCJNWWNBB;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log UWQRXXCDAPB;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log CFGGTBYJRBE;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log KZRMGODWFWL;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log XJROJNLFIAY;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log MUJRBXYITYO;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log MLNNJNMBELG;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log XQAYOLBYAZJ;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log CWWLKCONMCS;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log AQNMISKLFSJ;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log AJUDRJKMWQU;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log EKLCAXHEVZQ;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log QIBLVUYDAAR;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log OLWACMHNGZA;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log TIZFTBKOJVO;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log PQTQBPYIOBG;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log RNLZWBXIYDN;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log DAUWSFHNTIT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log XGRQRERSDIN;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log JEDDTLQJACY;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log LDZFQXYOZYI;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log VBXNZFYUMRY;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log LMKGHKKIHKH;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log OUGLSBCORKB;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log XSYHPBLSJQA;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log LHVJSGSWJKI;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log PWHLSXSXCEF;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log EBKFGJKSGXB;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log KSHTIYMXTRO;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log LWTKLYHCQGV;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log LHONGWHTPXV;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log QWHLHKXYMHZ;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log BYOPEZSIKNX;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class GQKHHWCTSTU
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log YTRCOOXUSHJ;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log NKTGRMQZAUT;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log VNEGGLSCVHE;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log RPLYVRIEGRE;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log MYCHMBYYZUE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log OPDRHSKMYOD;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log ITBHNLICYDZ;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log LUBBUOZKHUS;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log DNSWSXOSRPC;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log VRRUMHSQAKD;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log PAMHJCDRCNC;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log KCSLFXLTFAP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log TEEVPXNUGLA;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log RVLNZJWQDQY;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log SMMLCDPMXAP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log XUABLYJSBGI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log QDYCUCHMYRM;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log YIWCTHBWOVB;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log ZTNDNQXWFHG;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log OKXSYZHHZJJ;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log RBRPCZXAKXC;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log FKUVCVKOYCG;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log CHQSJOHMNWO;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log TQVXNKWBCXW;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log QULOPPIUJOH;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log SYMGTDIHEWW;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log YUEHSXUDEHS;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log PXWICFQJHRG;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log UCVRAWMTSXX;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log AVXCLTYFZXD;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log ONTKTMNXZQF;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log RTMDHXNZZFB;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log MEGDFZMIVFV;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log NXDOBRTVSZL;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log ZXOKRCNKNVC;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log MDVXIQAIMGQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log YPXLAGXJNMJ;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log OVFEFRTJLVU;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log ELAAIKBBVFV;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log GTLBTARWRTM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log JUANZUCBTQT;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log QZMDMHVNLZT;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log CFIFXHZFFTA;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log HSBFXBGHQPJ;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log CWFNKOJXRFE;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log SUSTEFHYIBU;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log JKONJXWMKYW;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log DLECOKJDRDU;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log SUNOIVVGMDW;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log UBYMGMZCJVK;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log IUFHDCZXSPT;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log JDOEEFDRDDM;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log QZQAUOBBMCL;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log GNXPNZZUTLK;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log ABRIPTUZEUR;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log VSATAPHIYMX;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log DPOCHGJAZUP;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log MYCHMBYYZUE;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log KUBSDTODCVM;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log QCBMVHWMASV;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log LKCUTMBGUIS;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log ZENMHWBHUUG;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log LXRABYATCKJ;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log AMMUFAOWKSG;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log IPTNJPWVYSS;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log KMTZZXCFCDM;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log UTZMDJPMUOO;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log XGUOWOFMJLW;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log JBOJCAGWOHI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log HVGOLUCVCZW;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log WSCFJONNVPC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log MYCHMBYYZUE;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log MJIRWKQIJWO;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log BTPZCJXTPSK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log MYCHMBYYZUE;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log UMAKVIPKVHW;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log JHLELBLLTJN;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HMUPYERXDAX
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class OXYAPBHTCYV : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] NOVJLHHQNEO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> NNFKZGQZRKQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool WIVCMCYIOTI;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x99AAE80", Offset = "0x99A9C80", VA = "0x1899AAE80")]
			internal OXYAPBHTCYV((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x99AAE00", Offset = "0x99A9C00", VA = "0x1899AAE00")]
			public IDisposable PJGVTZFRIOD()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x99AAD50", Offset = "0x99A9B50", VA = "0x1899AAD50", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class FQLVYCYVSOC
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log HVGOLUCVCZW;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log GARNKJAINUG;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log AEHTLZQLHND;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log ORWNTCIFBGY;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log MWETVIFBDMG;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log JJZKPYJLIOS;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log FNIUJDRUDBT;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log CFIFXHZFFTA;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log UPQZVLGPMXU;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log PMYKBHQDRJM;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log WFBJBSWYGWA;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log OSTCWJNQJRD;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log QBJFSLHHGBK;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log MONGYBCUBYB;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log QLFIIJKQIHW;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log NGQCGDGEIXC;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log ZDBWTNMYPBB;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log SUSTEFHYIBU;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log ICCPMQBYIDU;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log PRWLGWUKRQX;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log JJMPHXVPQZQ;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log EVWWFKQWMEL;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log VSAGHUVGJAH;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log WMZWNZHGHQO;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log SUPZMQPDAPZ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log CNFISJNFUZN;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log CUZTUAPZPYH;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log GKEGWLIKJBR;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log GILLUJLYBDK;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log MMNTAETPERD;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log LUXDXBIACOK;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log CIIVXWDCKJD;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log JOOOARIWQRK;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log SPQYWXUWXFD;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log YHCJRMKBASA;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log LMFIXBRONLV;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log KCVMRLUAJLF;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log YTZKSLLBBUP;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log ZSBROAZAWER;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log URLXCZMQQLU;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log HGBNLXXUFZC;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log GVJKLLEZNQK;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log BBFLDBSLTQJ;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log RXXCJCESOMQ;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log RRVEIPXRWZX;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log SECNBDSUQJD;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log XWOMSCBZEDM;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log SHENYTDEVKN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log GSSKIXSNZNF
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x99A5420", Offset = "0x99A4220", VA = "0x1899A5420")]
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
	internal class WLVMTYALBCV
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private WLVMTYALBCV parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xEBF7D0", Offset = "0xEBE5D0", VA = "0x180EBF7D0")]
			public Scope(WLVMTYALBCV parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch ZYIZCGUKWIM;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x10C67F0", Offset = "0x10C55F0", VA = "0x1810C67F0")]
		public Scope RORYRAGXTPH()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99B2FE0", Offset = "0x99B1DE0", VA = "0x1899B2FE0")]
		public WLVMTYALBCV()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface TRUUUEWWSEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void MXVFDTBJCKB(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void CAQAIZFSWPR(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void WNWDMFNTXOB(object a, [Optional] object b);
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
		[Cpp2IlInjected.Address(RVA = "0x99A7740", Offset = "0x99A6540", VA = "0x1899A7740")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99A76D0", Offset = "0x99A64D0", VA = "0x1899A76D0", Slot = "4")]
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
		public abstract void CBYRPQCEVDS();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xCECC30", Offset = "0xCEBA30", VA = "0x180CECC30")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class SYCAPUJKIAD
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> IUVNNVIAREK;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool NSTODTFPEQZ;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object VMPESYSZZMM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> VHWAFBZSPMC
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x99ADCE0", Offset = "0x99ACAE0", VA = "0x1899ADCE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99ADF60", Offset = "0x99ACD60", VA = "0x1899ADF60")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99AE0E0", Offset = "0x99ACEE0", VA = "0x1899AE0E0")]
		private static void ZTWPEWLYEIQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99ADD20", Offset = "0x99ACB20", VA = "0x1899ADD20")]
		private static void GOHDLIDNOSX(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class TVLFEHLHDIK
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
			public void LFDWTXBMRUW(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD30C70", Offset = "0xD2FA70", VA = "0x180D30C70")]
			public ParanoiaLevel XTBGQHVBRUK(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCE6150", Offset = "0xCE4F50", VA = "0x180CE6150")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action PVIQOTRYGPZ;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object EMTRUBPKDFV;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> EEDYKORVWEZ;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> ROBCDRZUPLX;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> JPSYSXBUULW;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> GJMADYZWQRK;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> DPBRDJENPBX;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> OBQSWFPYJVS;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder DQXDXVRMVMY;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly WLVMTYALBCV VTJZGLHFILQ;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug GHDXXAAIMGI;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int FRPSTMITNVG;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static TRUUUEWWSEE KFPDQSSEPJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x99AF590", Offset = "0x99AE390", VA = "0x1899AF590")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x99B0CD0", Offset = "0x99AFAD0", VA = "0x1899B0CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool SNXBKIJPOUK
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x99AECB0", Offset = "0x99ADAB0", VA = "0x1899AECB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool HQRDYNKYKBK
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x99AF270", Offset = "0x99AE070", VA = "0x1899AF270")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool YXBJGBHSHQL
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x99AFF40", Offset = "0x99AED40", VA = "0x1899AFF40")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99B0DC0", Offset = "0x99AFBC0", VA = "0x1899B0DC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99B15E0", Offset = "0x99B03E0", VA = "0x1899B15E0")]
		static TVLFEHLHDIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99AF2C0", Offset = "0x99AE0C0", VA = "0x1899AF2C0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99AE720", Offset = "0x99AD520", VA = "0x1899AE720")]
		public static int CBYRPQCEVDS(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99AE8C0", Offset = "0x99AD6C0", VA = "0x1899AE8C0")]
		public static int CBYRPQCEVDS(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99B0270", Offset = "0x99AF070", VA = "0x1899B0270")]
		public static Log PDPXSMPKQPY(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99B0AA0", Offset = "0x99AF8A0", VA = "0x1899B0AA0")]
		public static void UJKTXGTPIPR(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99AED00", Offset = "0x99ADB00", VA = "0x1899AED00")]
		public static void EGNTZWRVGUY(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99AF080", Offset = "0x99ADE80", VA = "0x1899AF080")]
		public static bool FPPNYWTMZJY(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99AEAB0", Offset = "0x99AD8B0", VA = "0x1899AEAB0")]
		public static int CMWHMHOTJZD(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99AE4B0", Offset = "0x99AD2B0", VA = "0x1899AE4B0")]
		public static string BEWSBPUTNCM(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99B12D0", Offset = "0x99B00D0", VA = "0x1899B12D0")]
		public static (string[], int[]) YVFFLXFACSD()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99AE990", Offset = "0x99AD790", VA = "0x1899AE990")]
		private static int CHPJPBQKQQN(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99AEC00", Offset = "0x99ADA00", VA = "0x1899AEC00")]
		private static int DKISQHTMTXR(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x99AF620", Offset = "0x99AE420", VA = "0x1899AF620")]
		private static int LFWKKWNAAMJ(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x99B01A0", Offset = "0x99AEFA0", VA = "0x1899B01A0")]
		private static int OMCVSKQFACG(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x99AFFD0", Offset = "0x99AEDD0", VA = "0x1899AFFD0")]
		private static int OMCVSKQFACG(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x99AF100", Offset = "0x99ADF00", VA = "0x1899AF100")]
		private static void GWQBPLTFXBX(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x99B0E50", Offset = "0x99AFC50", VA = "0x1899B0E50")]
		public static bool XUSMNVPKYUN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x99AF4D0", Offset = "0x99AE2D0", VA = "0x1899AF4D0")]
		public static bool KJXYBJUOHXC(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x99AFB80", Offset = "0x99AE980", VA = "0x1899AFB80")]
		private static void MGWOMOOLYVG(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x99B05F0", Offset = "0x99AF3F0", VA = "0x1899B05F0")]
		public static void TDRWOVBGOGA(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99B0F10", Offset = "0x99AFD10", VA = "0x1899B0F10")]
		public static void YSMHRNHGTUL(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x99B0C60", Offset = "0x99AFA60", VA = "0x1899B0C60")]
		private static void UTBXICXISXG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99B02C0", Offset = "0x99AF0C0", VA = "0x1899B02C0")]
		private static void PJGHJXCVWOJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99AE370", Offset = "0x99AD170", VA = "0x1899AE370")]
		private static bool ASEBRLOZBPW(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x99B1480", Offset = "0x99B0280", VA = "0x1899B1480")]
		private static bool ZODBSXEEQNN(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99B0D40", Offset = "0x99AFB40", VA = "0x1899B0D40")]
		private static bool WREUKVHAOCT(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99B0530", Offset = "0x99AF330", VA = "0x1899B0530")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99AFED0", Offset = "0x99AECD0", VA = "0x1899AFED0")]
		private static void MWOVWZRJCDT(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x99AEF10", Offset = "0x99ADD10", VA = "0x1899AEF10")]
		public static HMUPYERXDAX.OXYAPBHTCYV EOEJTGPBAQT((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99AF5E0", Offset = "0x99AE3E0", VA = "0x1899AF5E0")]
		public static void LFDWTXBMRUW(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99B0E10", Offset = "0x99AFC10", VA = "0x1899B0E10")]
		public static ParanoiaLevel XTBGQHVBRUK(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xD0FDB0", Offset = "0xD0EBB0", VA = "0x180D0FDB0")]
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
