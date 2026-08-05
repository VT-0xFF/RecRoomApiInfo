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
		[Cpp2IlInjected.Address(RVA = "0x8685C30", Offset = "0x8684A30", VA = "0x188685C30", Slot = "4")]
		public override void DELFABVRANX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD2C740", Offset = "0xD2B540", VA = "0x180D2C740")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool NHROOSQRHBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8687620", Offset = "0x8686420", VA = "0x188687620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool SVXTPGKCCEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8688300", Offset = "0x8687100", VA = "0x188688300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string XZROKQVDAAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8688900", Offset = "0x8687700", VA = "0x188688900")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool CDREJRHTSIC
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x54925A0", Offset = "0x54913A0", VA = "0x1854925A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel BRRWUSTDQQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8688890", Offset = "0x8687690", VA = "0x188688890")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8688950", Offset = "0x8687750", VA = "0x188688950")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x138ED40", Offset = "0x138DB40", VA = "0x18138ED40")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86889B0", Offset = "0x86877B0", VA = "0x1886889B0")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x386E310", Offset = "0x386D110", VA = "0x18386E310")]
		public void DEQMGTAMQSO<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x8687180", Offset = "0x8685F80", VA = "0x188687180")]
		public void DEQMGTAMQSO(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8687080", Offset = "0x8685E80", VA = "0x188687080")]
		public void DEQMGTAMQSO(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3873F20", Offset = "0x3872D20", VA = "0x183873F20")]
		public void KIVEKDFSKMV<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8687BF0", Offset = "0x86869F0", VA = "0x188687BF0")]
		public void KIVEKDFSKMV(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x38744C0", Offset = "0x38732C0", VA = "0x1838744C0")]
		public void LJYOYKNFNTM<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8687E10", Offset = "0x8686C10", VA = "0x188687E10")]
		public void LJYOYKNFNTM(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8687D10", Offset = "0x8686B10", VA = "0x188687D10")]
		public void LJYOYKNFNTM(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3876170", Offset = "0x3874F70", VA = "0x183876170")]
		public void UBMGEPAGXTH<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8688350", Offset = "0x8687150", VA = "0x188688350")]
		public void UBMGEPAGXTH(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8688480", Offset = "0x8687280", VA = "0x188688480")]
		public void UBMGEPAGXTH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3874C80", Offset = "0x3873A80", VA = "0x183874C80")]
		public void NEDIYFSXFBW<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8688010", Offset = "0x8686E10", VA = "0x188688010")]
		public void NEDIYFSXFBW(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8687F30", Offset = "0x8686D30", VA = "0x188687F30")]
		public void NEDIYFSXFBW(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x386FDE0", Offset = "0x386EBE0", VA = "0x18386FDE0")]
		public void FISHFXBOLWD<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8687310", Offset = "0x8686110", VA = "0x188687310")]
		public void FISHFXBOLWD(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8687410", Offset = "0x8686210", VA = "0x188687410")]
		public void FISHFXBOLWD(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3875B90", Offset = "0x3874990", VA = "0x183875B90")]
		public void PSQUKQUIMEU<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8688200", Offset = "0x8687000", VA = "0x188688200")]
		public void PSQUKQUIMEU(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8688110", Offset = "0x8686F10", VA = "0x188688110")]
		public void PSQUKQUIMEU(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86872A0", Offset = "0x86860A0", VA = "0x1886872A0")]
		public void DLQIHGJFGOL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8687010", Offset = "0x8685E10", VA = "0x188687010")]
		public void AYLTJPBEDEE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x38725F0", Offset = "0x38713F0", VA = "0x1838725F0")]
		public LogRangeScope ITTHYNKYILJ<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LogRangeScope HAFEZJNAPAG<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8687670", Offset = "0x8686470", VA = "0x188687670")]
		public LogRangeScope ITTHYNKYILJ(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8687790", Offset = "0x8686590", VA = "0x188687790")]
		public LogRangeScope ITTHYNKYILJ(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xED2F00", Offset = "0xED1D00", VA = "0x180ED2F00")]
		public LogRangeScope HAFEZJNAPAG(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8688590", Offset = "0x8687390", VA = "0x188688590")]
		public void VYSOUHJOJAP(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8688670", Offset = "0x8687470", VA = "0x188688670")]
		public void VYSOUHJOJAP(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3876A60", Offset = "0x3875860", VA = "0x183876A60")]
		public void VYSOUHJOJAP<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
		public void OIFOCSDPCLK([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8687500", Offset = "0x8686300", VA = "0x188687500")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8687890", Offset = "0x8686690", VA = "0x188687890")]
		private static void JFSMONTHFYQ(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log BSFULMVUYOK;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log TKEMEQYBITH;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log DCJZFKDBAYZ;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log QZJDKWAZWUK;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log FFDULGKWPQE;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log ZRUOBQSLHDO;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log DKGEDUVHOKH;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log NGMVGINUCEU;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log VCIMULOHTQF;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log IEDCXJMNNPC;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log CDHDUPCLNGC;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log RRAKRAFHVZY;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log HIERCTRTZVS;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log NPFVMAMDOCZ;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log PNMHYCODXQP;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log RPVYAIBYALN;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log NCFTDRXMJAF;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log KFDITRFAJNI;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log SPFPYGBBYYN;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log ZPPFVXWPKPN;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log WMCNTAQJIJH;
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
					public static readonly Log VTHJOFZPQQD;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log NRMEYTFUNIP;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log NKPWJATYHBD;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log NSUBCZBTLBC;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log OCQTZKVNZMC;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log ZJGWIZZSDAU;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log ZOQQNAVNOLI;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log PLKHUOLYSUS;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log NKPWJATYHBD;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log OCQTZKVNZMC;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log ZJGWIZZSDAU;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log IIUWFMSJYBJ;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log XBKGVVFVKZA;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log BLNIAHMIUXM;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log LHZWLPFDBZC;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log XQIIPTKCQMN;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log VTHJOFZPQQD;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log OETERHFDPQX;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log OENXUALGGFO;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log OFDSLUSYINP;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log OEYLONZAZCG;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log OFOGGIGTBKH;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log OFIZJBMVRYY;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log OFYUAVUNUGZ;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log OFTNDPAQKVQ;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log ODDBNFBYSED;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log OCXUPYIBISU;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log VTHJOFZPQQD;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log OETERHFDPQX;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log OENXUALGGFO;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log OFDSLUSYINP;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log OEYLONZAZCG;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log OFOGGIGTBKH;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log OFIZJBMVRYY;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log OFYUAVUNUGZ;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log OFTNDPAQKVQ;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log ODDBNFBYSED;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log OCXUPYIBISU;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log VTHJOFZPQQD;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log UWRABAXSZOT;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log DWISNPBKSHX;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log OHKIWFRYMLP;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log DAVPYRPGFCB;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log QDMRIXITKWW;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log EOVONRBMTQA;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log MTMWMALGKAF;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log SNIPPAPVBRE;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log PYZEQQLBWKZ;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log SICEOJBKQZN;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log ZYRMOBYOLVJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log IYMUNHFOYWF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log TBQPPTXPEOW;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log XONBWWZEQJZ;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log MXMKSDJKZFR;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log TLMMMBWIWWT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log VLELUWKAULZ;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log MRRFNJJCGMQ;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log BXCZZILBBRN;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log DSNLBJDGZUR;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log SRPNCNXEZBU;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log YPFDPHPDUSA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log APAQKOZQHQZ;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log NBHIGURJFFO;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log NAWUXMVYEOA;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log EBREHKIQFCL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log EBDNGJXYGXD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log MASTTMEKRHZ;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log DDLULXFVMVB;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log DSNLBJDGZUR;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log DKOZVRUAZMF;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log WMCNTAQJIJH;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log YDNYKFWAXXX;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log VTWCEGSZUYQ;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log PYZEQQLBWKZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log HLXTIAVCSEJ;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log EZQEARZJSWI;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log LQBJXDNLFDP;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log VUWPCAIUBZS;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log DSNLBJDGZUR;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log PSXTQMWHOFT;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log NPJEJNQQWBJ;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log TYRJWGAXCCO;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log TBXIZAOJVAI;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log JQDPKQUVUZO;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log RKMXBQEUNWS;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log QUVITKMEMZA;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log JLQUJPVPIBS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log QDGULHJYQIJ;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log DSNLBJDGZUR;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log NACTQWAYAEJ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log UPBFVLUWMQK;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log CLESWWPSHTB;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log VOIWOGBUCAW;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log KWDTJCVZMIZ;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log TOOPSHIMLQZ;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log VYUDGLEAAUB;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log TYWFVRSXMIS;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log ZJHKWFCJMCO;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log PXCVVOQRMGH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log LVIQYAJAEOC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log BKSVYMISVCT;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log GKQGXLRBUBR;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log NRJJJUBLLNT;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log EKQVYUMIGQX;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log BOBHLEXMKAW;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log GOQRZVOSZEL;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log RQMARHTHLQK;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log GRGIRTZOIQM;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log RCSIRSGQUZQ;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log IEDCXJMNNPC;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log IIUWFMSJYBJ;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log QWEKTZSVBHD;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log WGHGCDFKQPQ;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log JNMQCQBFHQM;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log ZHKGFAWCQJT;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log SZXIWKMKUME;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log VTHJOFZPQQD;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log RKNAVRSOYVT;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log IXBDDPOGBOF;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log RXGFVRGONIH;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log JQZEUSBMEEN;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log BKSVYMISVCT;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log QHQYNFBFSGQ;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log ZWTRIZOVEVD;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log NDYPEJRJWSC;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log QNWNYZHUMUC;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log SSCHNUUEKZS;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log RXGFVRGONIH;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log KHXWJBQUGZS;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log HQJCFSEUYUS;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log JPZRDATPBUN;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log BCLCXRNMYAU;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log RGHGMKOIBSL;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log IXBDDPOGBOF;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log CNQNKMDTRCV;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log YGWIQKUPPQQ;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log MRSGYVNGCSV;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log BTZPTTRBAGO;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log XAYUULCKYNL;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log IAHROGABVSD;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log WJGRPVPQLCQ;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log PKNAPAAUZQN;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log VAMVOXHGCSL;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log RQBPQQNVMBR;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log BTUCYGYTPMU;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log XTYYWSACINK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log QZJBPIJTIUA;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log AEBQCZKORYZ;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log YRXJZDIUMLN;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log SVMWGPENEIX;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log LOWWNVJOBDI;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log WBJZQSWXPWA;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log DXVHOPJCVWN;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log MMAEIHPWXLR;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log AFLDHIKIOVE;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log PTSNTWFXZQM;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log LGJMCOORIYV;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log QOJDGGMVOLC;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log CXFNWINHCBI;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log RMKYXUEIAKS;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log HBVHBJFRRUO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class TKMGOLPFMQJ
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log XLNDBVDDUOA;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log KMCDZIUOBGM;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log WIWWGGLNWZP;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log PGFZYEYIDKB;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log VTHJOFZPQQD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log QPRVCLOWSAE;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log WITPDDHMMMO;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log WMXTQEEAZQN;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log TXAFDSEMRVH;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log YZEIPIBOAOO;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log AUROFDHBUUF;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log GJXPICZNJPW;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log SFFMDALTXWL;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log WEDKXVGTPLZ;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log SZXIWKMKUME;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log FJPSRSLBZLL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log JZXFWCPGIDB;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log CANYZMAWNSS;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log IRVVSNUTQLX;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log FDMNMWRENBM;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log UNSTPNWOAGN;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log ZOYFXQSUBPR;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log NQZNSFOSMJH;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log LERWXJTOFHF;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log LNBVTYKROEY;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log ZAGMFMCFSHH;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log QQZWOLMOWGV;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log DSNLBJDGZUR;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log VDSIXRCJLJU;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log WPPGGKBROKG;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log GSOFAROKZCQ;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log MBGYIYNLCJC;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log OKDUPWGUJVC;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log UOXBPWMOIJC;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log TQERHDNWSWP;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log MGJIRZYHMLF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log QZJDKWAZWUK;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log NVGZPQECTLX;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log ULOVLFPZRZY;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log OJJDTTULQQF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log JWCOUXLZBSQ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log JCBSKEATYGI;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log ULTIMEUBENJ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log NSTTIXBHAIS;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log XZUETRZAOKH;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log MIKGXQKDIUP;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log BJXDZDAYEYP;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log MGXYKKGVQBR;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log ZLNLFKHDPNB;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log KWNAWYMQBXT;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log ULLVZBVSEDM;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log BTKJHGETLUX;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log NEZGANJCTOW;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log WKVDHSWHFIV;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log LSAMTKTWSKS;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log BAXOKGBRRKQ;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log BLNIAHMIUXM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log VTHJOFZPQQD;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log ESVLCURHRFD;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log SIDTVNINHAI;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log UGDKRVOYCKZ;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log JEWEOOKDRAZ;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log OKPLRUDETMA;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log KKPZKBIVUCF;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log NPPEMXEMVFT;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log TZEWSYZGBXD;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log DVGLXPPPAPB;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log SSZJEQMTIVV;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log TSMMGFHDNLF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log BKSVYMISVCT;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log XCPOATVQEUB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log VTHJOFZPQQD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log BQQGPSYCHVX;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log VPTERHEJMDD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log VTHJOFZPQQD;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log IELSZZIBJZV;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log CQYOCRFINRI;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class CHVYJDZTJNQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class DMYIIQYCTBQ : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] ZWUYARHVILV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> DHJHWKTNJSZ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool ERVXMEJWDYJ;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8682FF0", Offset = "0x8681DF0", VA = "0x188682FF0")]
			internal DMYIIQYCTBQ((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8682F70", Offset = "0x8681D70", VA = "0x188682F70")]
			public IDisposable EYUHGOUPVYO()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8682EC0", Offset = "0x8681CC0", VA = "0x188682EC0", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class RECMBSSPDUP
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log BKSVYMISVCT;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log SJCIUNOHFYR;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log YAQTFSUCRAU;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log BYQDARTNSXB;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log LEAJQJXZKXZ;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log FGSKVGTOHXT;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log YJSVBPMVLWQ;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log ULTIMEUBENJ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log KDIMALAGXBB;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log DKLCMZSFUXD;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log IKMNBQEDRML;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log UNIJTGNTIJE;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log HBTDFXITEEF;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log MXKJJZINFIO;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log GTJJOLHZKLD;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log ZOSXJLDUHPH;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log XDXRQEVCZPY;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log MIKGXQKDIUP;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log DWSRZDUAHKF;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log RDKNTMBJGNO;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log GQJXTBQFBOL;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log IEDCXJMNNPC;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log RMBUEUODMSY;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log CEYCTSQHZPP;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log SHFFJWDIRRU;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log RANFNOUSTGM;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log DFLMKHLEDLK;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log VWFFNMQOWXG;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log PPLVCMOGTLR;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log ZGWLIIIAUDI;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log OFTIGAMRKAZ;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log XEDVKCSDUCC;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log GGQNDXNEWIZ;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log RNVTWJVWYJU;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log AEWKQFAIXXH;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log NSUBCZBTLBC;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log XKGZNOMFXMQ;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log LOAGMHZHXUI;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log VUJRFAHLMIQ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log IAWVBOMKWHN;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log JPXJFZODTLV;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log FHXELPLGDBH;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log IAAVLVBANAG;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log LJXOHMKHFFT;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log PGHDOAVJARS;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log QZNLQPOHSOQ;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log CRVETAWEWDJ;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log FGTXSRIRVEA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log HMQWWEBAXPK
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8689F70", Offset = "0x8688D70", VA = "0x188689F70")]
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
	internal class VTTJJQKWUFS
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private VTTJJQKWUFS parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xC9F870", Offset = "0xC9E670", VA = "0x180C9F870")]
			public Scope(VTTJJQKWUFS parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch HQRIGZOMCTF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xE9EE40", Offset = "0xE9DC40", VA = "0x180E9EE40")]
		public Scope UOVPEWCFDME()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8692360", Offset = "0x8691160", VA = "0x188692360")]
		public VTTJJQKWUFS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface USDSCURYKWX
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void DEQMGTAMQSO(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LJYOYKNFNTM(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void NEDIYFSXFBW(object a, [Optional] object b);
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
		[Cpp2IlInjected.Address(RVA = "0x8685B90", Offset = "0x8684990", VA = "0x188685B90")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8685B20", Offset = "0x8684920", VA = "0x188685B20", Slot = "4")]
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
		public abstract void DELFABVRANX();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xACC5C0", Offset = "0xACB3C0", VA = "0x180ACC5C0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class HPDOEOOJXWK
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> JJVDTDNGOPX;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool HRWRXRLDKCC;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object HGZMXHXZMXX;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> JUKGHIDUBLD
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x8685300", Offset = "0x8684100", VA = "0x188685300")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8685180", Offset = "0x8683F80", VA = "0x188685180")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8685340", Offset = "0x8684140", VA = "0x188685340")]
		private static void QMQXRMPEIHV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8684F30", Offset = "0x8683D30", VA = "0x188684F30")]
		private static void DULHZLFGSHO(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class TYDJZYMXROJ
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			public void VCRWLYJXLFB(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB12960", Offset = "0xB11760", VA = "0x180B12960")]
			public ParanoiaLevel CNXVAWYGETV(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAC7AA0", Offset = "0xAC68A0", VA = "0x180AC7AA0")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action BIGHUXLXUTG;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object ZIRTCWCROAU;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> REBAQJFUQES;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> SDRXBZOSJCS;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> SFQYFTQXSPV;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> ZXNFVRCBBAX;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> FDKPVEFABDK;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> RUXJKDVVULZ;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder JRNKQLICAEB;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly VTTJJQKWUFS XZFIJSWTJVL;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug SMPBWXHNWWT;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int CZASNEGIVKZ;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static USDSCURYKWX HIXIVZEKAZC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8690910", Offset = "0x868F710", VA = "0x188690910")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x868DD80", Offset = "0x868CB80", VA = "0x18868DD80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool JPYOJOEVSKJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x868E8F0", Offset = "0x868D6F0", VA = "0x18868E8F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool XSOHIWQHQTL
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x868FDE0", Offset = "0x868EBE0", VA = "0x18868FDE0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool TSXCFAIHSZQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x868FE30", Offset = "0x868EC30", VA = "0x18868FE30")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x868EA00", Offset = "0x868D800", VA = "0x18868EA00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8690960", Offset = "0x868F760", VA = "0x188690960")]
		static TYDJZYMXROJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x868EFC0", Offset = "0x868DDC0", VA = "0x18868EFC0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x868DDF0", Offset = "0x868CBF0", VA = "0x18868DDF0")]
		public static int DELFABVRANX(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x868DF90", Offset = "0x868CD90", VA = "0x18868DF90")]
		public static int DELFABVRANX(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x868F410", Offset = "0x868E210", VA = "0x18868F410")]
		public static Log LRBGKMPHKRZ(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x868D6E0", Offset = "0x868C4E0", VA = "0x18868D6E0")]
		public static void BNOZDPRHRDO(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x868F5D0", Offset = "0x868E3D0", VA = "0x18868F5D0")]
		public static void OFUXVBERXFP(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x8690400", Offset = "0x868F200", VA = "0x188690400")]
		public static bool URUANIPBVSJ(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x868D8A0", Offset = "0x868C6A0", VA = "0x18868D8A0")]
		public static int BSDVDPXQPCY(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x868F860", Offset = "0x868E660", VA = "0x18868F860")]
		public static string PYNCMARWEEL(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x868FAD0", Offset = "0x868E8D0", VA = "0x18868FAD0")]
		public static (string[], int[]) QACXOWXONOU()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x868F280", Offset = "0x868E080", VA = "0x18868F280")]
		private static int KXQCTPUAKCI(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x868F1D0", Offset = "0x868DFD0", VA = "0x18868F1D0")]
		private static int KKRKWUPWZEO(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x868EA50", Offset = "0x868D850", VA = "0x18868EA50")]
		private static int IWKSAGGTSNE(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x868E650", Offset = "0x868D450", VA = "0x18868E650")]
		private static int EMZFXAJVYDT(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x868E720", Offset = "0x868D520", VA = "0x18868E720")]
		private static int EMZFXAJVYDT(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86907A0", Offset = "0x868F5A0", VA = "0x1886907A0")]
		private static void ZKMKAVODFEM(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x8690280", Offset = "0x868F080", VA = "0x188690280")]
		public static bool SKDAHUXFJFG(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x868E940", Offset = "0x868D740", VA = "0x18868E940")]
		public static bool FAALSPRXTFF(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x868D9F0", Offset = "0x868C7F0", VA = "0x18868D9F0")]
		private static void CBELYUFEXZZ(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x868E060", Offset = "0x868CE60", VA = "0x18868E060")]
		public static void DHUBREKOAGN(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x868FEC0", Offset = "0x868ECC0", VA = "0x18868FEC0")]
		public static void RVYNCXUVNWS(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x8690730", Offset = "0x868F530", VA = "0x188690730")]
		private static void XJQXALXANUD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86904C0", Offset = "0x868F2C0", VA = "0x1886904C0")]
		private static void XHHGLCKUCZI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x868E510", Offset = "0x868D310", VA = "0x18868E510")]
		private static bool EDQQSXXWJKH(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x868FC80", Offset = "0x868EA80", VA = "0x18868FC80")]
		private static bool QCMZRPBIXXI(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x868F7E0", Offset = "0x868E5E0", VA = "0x18868F7E0")]
		private static bool OOPGQHJGCYY(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x8690340", Offset = "0x868F140", VA = "0x188690340")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x868F3A0", Offset = "0x868E1A0", VA = "0x18868F3A0")]
		private static void LIOWOJDFLWE(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x868F460", Offset = "0x868E260", VA = "0x18868F460")]
		public static CHVYJDZTJNQ.DMYIIQYCTBQ NIAXZRLGJHE((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8690480", Offset = "0x868F280", VA = "0x188690480")]
		public static void VCRWLYJXLFB(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x868DD40", Offset = "0x868CB40", VA = "0x18868DD40")]
		public static ParanoiaLevel CNXVAWYGETV(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xAF1770", Offset = "0xAF0570", VA = "0x180AF1770")]
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
