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
		[Cpp2IlInjected.Address(RVA = "0x8591BF0", Offset = "0x8590DF0", VA = "0x188591BF0", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6C10", Offset = "0xCF5E10", VA = "0x180CF6C10")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool HIIFWJVHLPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x85933E0", Offset = "0x85925E0", VA = "0x1885933E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool YBEPOFMXIDT
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x8594820", Offset = "0x8593A20", VA = "0x188594820")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ATEBIWOYUZR
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x8593B50", Offset = "0x8592D50", VA = "0x188593B50")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool RCTUDDFBUHY
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x53EA700", Offset = "0x53E9900", VA = "0x1853EA700")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel YOWDXKSOKAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8593A70", Offset = "0x8592C70", VA = "0x188593A70")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x8594870", Offset = "0x8593A70", VA = "0x188594870")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1354390", Offset = "0x1353590", VA = "0x181354390")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85948D0", Offset = "0x8593AD0", VA = "0x1885948D0")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3832CB0", Offset = "0x3831EB0", VA = "0x183832CB0")]
		public void BYUXGGTCTTU<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x85932D0", Offset = "0x85924D0", VA = "0x1885932D0")]
		public void BYUXGGTCTTU(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x85931D0", Offset = "0x85923D0", VA = "0x1885931D0")]
		public void BYUXGGTCTTU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3836990", Offset = "0x3835B90", VA = "0x183836990")]
		public void GNGZQFJIKQB<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8593550", Offset = "0x8592750", VA = "0x188593550")]
		public void GNGZQFJIKQB(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x38389B0", Offset = "0x3837BB0", VA = "0x1838389B0")]
		public void LVZPEKAUWQK<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8593950", Offset = "0x8592B50", VA = "0x188593950")]
		public void LVZPEKAUWQK(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8593850", Offset = "0x8592A50", VA = "0x188593850")]
		public void LVZPEKAUWQK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x383ADD0", Offset = "0x3839FD0", VA = "0x18383ADD0")]
		public void UOVVAGCTIOR<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x85946F0", Offset = "0x85938F0", VA = "0x1885946F0")]
		public void UOVVAGCTIOR(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x85945E0", Offset = "0x85937E0", VA = "0x1885945E0")]
		public void UOVVAGCTIOR(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3839E00", Offset = "0x3839000", VA = "0x183839E00")]
		public void SIWEPCCUJZK<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8593E90", Offset = "0x8593090", VA = "0x188593E90")]
		public void SIWEPCCUJZK(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8593F80", Offset = "0x8593180", VA = "0x188593F80")]
		public void SIWEPCCUJZK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x38381D0", Offset = "0x38373D0", VA = "0x1838381D0")]
		public void LLRWJNENPYL<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x8593750", Offset = "0x8592950", VA = "0x188593750")]
		public void LLRWJNENPYL(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x8593670", Offset = "0x8592870", VA = "0x188593670")]
		public void LLRWJNENPYL(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3832200", Offset = "0x3831400", VA = "0x183832200")]
		public void BAJEAXZGSEA<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x8592FF0", Offset = "0x85921F0", VA = "0x188592FF0")]
		public void BAJEAXZGSEA(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85930F0", Offset = "0x85922F0", VA = "0x1885930F0")]
		public void BAJEAXZGSEA(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8592F80", Offset = "0x8592180", VA = "0x188592F80")]
		public void ALDKWSDMOSH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8593AE0", Offset = "0x8592CE0", VA = "0x188593AE0")]
		public void PHNZFMBNIHG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x383AA40", Offset = "0x3839C40", VA = "0x18383AA40")]
		public LogRangeScope TAUTPJFEKWH<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LogRangeScope FWIQWKOKTEK<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8594160", Offset = "0x8593360", VA = "0x188594160")]
		public LogRangeScope TAUTPJFEKWH(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8594060", Offset = "0x8593260", VA = "0x188594060")]
		public LogRangeScope TAUTPJFEKWH(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0xE95860", Offset = "0xE94A60", VA = "0x180E95860")]
		public LogRangeScope FWIQWKOKTEK(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8593DB0", Offset = "0x8592FB0", VA = "0x188593DB0")]
		public void SBGCSJLMPIL(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8593BA0", Offset = "0x8592DA0", VA = "0x188593BA0")]
		public void SBGCSJLMPIL(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x38394D0", Offset = "0x38386D0", VA = "0x1838394D0")]
		public void SBGCSJLMPIL<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
		public void QTIPQPAPWSI([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x8593430", Offset = "0x8592630", VA = "0x188593430")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x8594280", Offset = "0x8593480", VA = "0x188594280")]
		private static void UITHIJPLBDG(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log NZJGXKXGHMG;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log DCNBOWMWSJP;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log TVJJEHGUPCF;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log DBSEAHLMNAS;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log KHVUALCSJMI;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log FCMAETBAPGM;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log JMERPFRIWBV;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log LSBLHHZPLPW;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log GORTSUERIXP;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log OUVPVOUYDCY;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log QSOCQADQWFM;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log VUVGOXGSEPM;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log RFJSMPIBHSE;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log SJCWBGMCCVP;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log DQKTKMGHEWL;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log BQXEYAEHTKP;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log LSQOYISNKTP;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log XXSZWFAFMQC;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log CFSYMTJQJIV;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log JAEBUIPQPUL;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log EOUYSLITTAR;
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
					public static readonly Log HYBEIMQIHSP;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log LRYRWIAFIYH;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log AAKYVHZURIB;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log NDGSDOSFWTW;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log CMEKNPLLBYG;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log WHIUMTHGCJK;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log JCHWPGRIOFI;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log OEDLTMSCOIO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log AAKYVHZURIB;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log CMEKNPLLBYG;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log WHIUMTHGCJK;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log AGTTVIBABBB;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log BMTCIKJYSYO;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log DFAYYLNCJDE;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log YKOOCXWKNHC;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log MEQMLIXIZUV;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log HYBEIMQIHSP;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log IIGGNNGSIXB;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log IIAZQGMUZLS;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log IIQUIAUNBTT;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log IILNKUAPSIK;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log IHLEYMFCXDR;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log IHFYBFLFNSI;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log IHVSSZSXQAJ;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log IHQLVSZAGPA;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log IGQDJLDNLKH;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log IGKWMEJQBYY;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log HYBEIMQIHSP;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log IIGGNNGSIXB;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log IIAZQGMUZLS;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log IIQUIAUNBTT;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log IILNKUAPSIK;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log IHLEYMFCXDR;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log IHFYBFLFNSI;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log IHVSSZSXQAJ;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log IHQLVSZAGPA;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log IGQDJLDNLKH;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log IGKWMEJQBYY;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log HYBEIMQIHSP;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log OHWFSUFVUEH;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log HARXTKASAQJ;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log YCIMBLMJLKB;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log GIUFREOBSYN;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log FZBDSRPMFUC;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log VDZVVSIULLO;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log HYWSTOJDLGB;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log RLPUQQSDHUC;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log ZDXGSYOEULD;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log SATZPVXJOBJ;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log DXQIYPTVXUH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log XMZZGQHUHYZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log UWSRVTYQADY;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log RSUSOVPZDDN;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log NFTQOKJYOGP;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log KPFOQKSXTRN;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log IXBZHOBUPJF;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log NNAFHGFJPAI;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log GVDSQCBIZRJ;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log LJFVYFOWVJT;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log YIVHLAIWLTM;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log KKBLDGPYBWA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log DTWGNVVQVPH;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log FLNAIOGSWFO;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log XKQDPJCGAIY;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log FCSJCBKPEQP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log SQSNNJYOMND;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log YEPJFAAKUUH;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log SHKUZZMLJWP;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log LJFVYFOWVJT;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log NCXPFXIWJCN;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log EOUYSLITTAR;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log KYBSFVZFHYZ;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log SWYQYJZUNSM;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log ZDXGSYOEULD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log RYXXWCANRDL;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log ZGTTTGKPNKY;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log LCXXTXZEKXH;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log DKZUFJPFIRK;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log LJFVYFOWVJT;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log LDSFHITRADD;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log NEAVCWTUXZR;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log IBHSDVSAICC;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log QITKQGUZGCM;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log MVMDFQMOJNG;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log HSDGPWHVIAO;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log HEFWYBBRGIO;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log CFIHYRUAKLC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log GUBZHHCUCKB;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log LJFVYFOWVJT;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log GRLVSBQPHUJ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log OILUYPEDSOK;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log ZFYIXSENMEH;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log NGXUSRSVFIO;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log OCMGEYJAPFX;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log RBNMSCJAOSV;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log CRDETGTWZLD;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log XFWJWJMXJKO;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log BZWVDJNYHYS;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log VCIETBJUDKP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log ZVVGVLDMCWG;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log VNNVUWYRWRF;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log BCOFYAQEFLF;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log HBYJFBSDDGF;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log FCTEXXGLDEP;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log EZNMUTZKSWW;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log UAGCUNQQHEH;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log REJZMWCJWQC;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log UFNNSWRNDOQ;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log GTMKWHOAGCS;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log OUVPVOUYDCY;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log AGTTVIBABBB;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log FALHWATCOAZ;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log TSQKIXHUQUC;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log YEFNNEOPVAQ;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log WRUAXHSBXJD;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log LCFOSLGYKQA;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log HYBEIMQIHSP;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log YXJZKJPEPHH;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log LUHTKNZDTZT;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log BREYJYYOULJ;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log GJSULXBHGIJ;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log VNNVUWYRWRF;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log TKQGSPMZYTS;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log UQLHFHHCVRL;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log MKPUQYPTEGO;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log MXKOLEOBRUK;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log ZDNETMRETWI;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log BREYJYYOULJ;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log UBNAUSYNHNK;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log ZZFLDYGBTMS;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log VSNYSQHJYOR;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log BDJAHTQSBKQ;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log SORAOKUFRYL;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log LUHTKNZDTZT;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log KDXFWZUDPKR;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log TMYNCCLPRKY;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log ALPNIKRQHSV;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log CAMXCOPHEBE;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log WZDQMCMPMQZ;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log DZNOJNTLQRN;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log YLSRWRKNWGY;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log KTORHDNOWRD;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log OECAZTHMDMX;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log JVYMYUMXIBV;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log XUTZLGAPMBS;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log PIAICZHFHKY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log QNJRMPLASTG;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log ZETXDPTAMGV;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log PZRQXVZYTBZ;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log DXLEHJKABOT;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log ZKATAKOTGLY;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log OWHIJYHVEGQ;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log LMQCZRBYWUZ;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log PAJYXGHLQMH;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log LTFTBFLPGAS;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log SIHLOCNWVFW;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log QFFJMWCSXDP;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log CYMRKAXTUYM;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log EBYPJKMQARU;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log JQXKVXSZRRM;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log RGWZZFEOAZU;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class MUODLWCRAIF
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log PRGNUVNBMPS;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log HUOJLJZWPWA;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log GEVATESXCNT;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log VSDSYUTEPRH;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log HYBEIMQIHSP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log CCAUMPXASNG;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log TBZGHRWXDKC;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log GOCDZRIZFQB;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log ZENDVPRFCPL;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log IARFZTYTAWS;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log NOUXYIUMBHP;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log ACAWAAQXYVS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log ZSDREFVUKWT;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log FLHOBQYCSKT;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log LCFOSLGYKQA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log HTXABBVSTZD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log OBPMXGPAYVZ;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log ZPFPBROAVWG;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log CSMJJALZUYJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log IZBZWYHNTQS;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log ACLWZWXUEPP;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log TNLSSOKYLTN;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log CWQXRIWFSZT;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log BHITRGIXVXB;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log BBDYNOYNUSA;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log TJJYHHISLXP;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log RNTIJYYXNAJ;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log LJFVYFOWVJT;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log WGHYZPOWQJE;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log FGIBXRXNZOW;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log SMFWSRLNUDO;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log HNJDJQYDEUY;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log WUWRYCQZANK;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log EXCVKRVRBGY;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log YIPKPQKZWXJ;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log LNHDEGZQGKD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log DBSEAHLMNAS;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log SNABYHRZUDH;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log XNXCZXDSSVY;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log TGTLZGJHHXP;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log JTLNSHFWRTS;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log BYDTXQKWBZC;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log CDTZKMIHCOT;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log NFRRPXZLFIC;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log YLWDEQRMZAT;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log OVYVWZGXTEP;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log RBLZXCNTSMD;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log YOWLXKLXIGD;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log XRGCRCHXYOX;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log GGOGUSOVSIJ;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log YOPLLVMYMSS;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log HJUWHWNEZDF;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log JABUUDZHZFU;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log XLHBTMYHZPT;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log FTKOAJFKYGW;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log SKHNIIEXTHK;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log DFAYYLNCJDE;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log HYBEIMQIHSP;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log EBRZNOUXXTL;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log UNQUVJUHLDW;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log PCAUAFRVVQF;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log HFQASYLUUPD;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log OEEENHEUDRS;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log VEHVWDKPICZ;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log ZYCSZVYNQVL;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log VSFMLTYPOLD;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log NZSKCCNBVJF;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log FTSMUUJLLKT;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log DGAMSNSLPXZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log VNNVUWYRWRF;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log LIHFLIUJYBD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log HYBEIMQIHSP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log GBLGWWJEGQZ;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log DUPITYDQHRH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log HYBEIMQIHSP;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log MWEVIQVYKRF;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log HEYQTSCQUGO;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class FRHTBIGJUPM
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class MDVDCJMBZXA : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] PLKNAPCBXRB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> GVZIIPCMQYN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool RUWCCCOLRIN;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x8594AC0", Offset = "0x8593CC0", VA = "0x188594AC0")]
			internal MDVDCJMBZXA((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x8594A40", Offset = "0x8593C40", VA = "0x188594A40")]
			public IDisposable KCYZSYLTJTE()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x8594990", Offset = "0x8593B90", VA = "0x188594990", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class TTDECAHOSGT
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log VNNVUWYRWRF;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log KJMUHMZBNLP;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log BYVUFWFOPYQ;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log MEEKJUZXMCP;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log XYYIHQOMMEL;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log HYJBWYOQGMZ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log EFPMHIPSKLW;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log CDTZKMIHCOT;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log OYRPIKRYDFF;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log KHVKZNFIIFD;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log UKTVMASMBYH;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log CVXRUHYYYES;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log ENYFIGNQEXT;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log TUPCHRLEDYC;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log INMQUKWITZP;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log KMRWOPBYFSN;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log ZKZBSZQUUXA;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log OVYVWZGXTEP;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log MMZZPVPAYZH;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log WBMNXYWAUMU;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log IBWWBVYHVPV;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log OUVPVOUYDCY;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log IJCABARLIIA;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log NNZNHUAAUPX;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log VDURUWYFXHE;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log SMXYVOXVXSQ;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log FBLVKMBGOEQ;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log CMJEJWKTUTK;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log VNRZQKSLXWX;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log WQFEMQUUEIS;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log QUWUJRSJHYR;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log JXZBAELPYWO;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log RRRLUGDXXIJ;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log ILEQOAAQELU;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log QZOOGKRMXNP;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log NDGSDOSFWTW;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log GJWSGYHSNTG;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log IKNKLLWUZFC;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log DZIGRUWJTTC;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log ZUIGXREYPAL;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log AYOVLCDHVYP;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log RIEVAGQOFUV;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log AGXMRKBFNHE;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log TYPEEYJDVPD;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log ARDMPKOVWAA;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log AFIZBGWOYQY;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log OQXQWNTNGZR;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log FGUQFJWPMYY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log HKIAZWGJZJC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x8598080", Offset = "0x8597280", VA = "0x188598080")]
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
	internal class QKVZOLYNBYE
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private QKVZOLYNBYE parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xC504D0", Offset = "0xC4F6D0", VA = "0x180C504D0")]
			public Scope(QKVZOLYNBYE parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch TYPNMXZJDDF;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xE70900", Offset = "0xE6FB00", VA = "0x180E70900")]
		public Scope MXRAMTZQGDO()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x8596250", Offset = "0x8595450", VA = "0x188596250")]
		public QKVZOLYNBYE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface OLFPBZEDIKT
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void BYUXGGTCTTU(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void LVZPEKAUWQK(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void SIWEPCCUJZK(object a, [Optional] object b);
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
		[Cpp2IlInjected.Address(RVA = "0x8591B50", Offset = "0x8590D50", VA = "0x188591B50")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x8591AE0", Offset = "0x8590CE0", VA = "0x188591AE0", Slot = "4")]
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
		public abstract void JUFURAKXVZP();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class VUBYCIMWGDQ
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> HXMPQKLJOXD;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool PRXZEUNYRCC;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object FLSCTHHAKHL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> XASOXDEWHCJ
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x859ADE0", Offset = "0x8599FE0", VA = "0x18859ADE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x859AC70", Offset = "0x8599E70", VA = "0x18859AC70")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x859AE20", Offset = "0x859A020", VA = "0x18859AE20")]
		private static void TSDYXOCZZDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x859AA30", Offset = "0x8599C30", VA = "0x18859AA30")]
		private static void BSREXJLFCIQ(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class GLWHQRDYJTL
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
			public void LWZAMEQWJDR(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0")]
			public ParanoiaLevel KPHSHISKBZJ(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xAB6180", Offset = "0xAB5380", VA = "0x180AB6180")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action EKPCLVWTNKY;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object IEJVKWBCLDO;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> XUPBPYNLIGC;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> DQGXOLBWAYW;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> HBWBSXQXMIP;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> CQELXEHONHV;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> RLCXPLBILLW;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> FVDYYAXQDQP;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder VVKQUFDDOCJ;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly QKVZOLYNBYE ZLBRSGJHIHP;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug EMWKHHVWHIP;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int HXHKHNIMVJP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static OLFPBZEDIKT URRJTBSVKII
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x858E290", Offset = "0x858D490", VA = "0x18858E290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x858E170", Offset = "0x858D370", VA = "0x18858E170")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool MZCYRMGMVZL
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x858F890", Offset = "0x858EA90", VA = "0x18858F890")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool QFAUYCGBPVX
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x8590360", Offset = "0x858F560", VA = "0x188590360")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool CPGZMEEOLHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x858E330", Offset = "0x858D530", VA = "0x18858E330")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x858E2E0", Offset = "0x858D4E0", VA = "0x18858E2E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x8590E60", Offset = "0x8590060", VA = "0x188590E60")]
		static GLWHQRDYJTL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x858E5E0", Offset = "0x858D7E0", VA = "0x18858E5E0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x858E7F0", Offset = "0x858D9F0", VA = "0x18858E7F0")]
		public static int JUFURAKXVZP(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x858E990", Offset = "0x858DB90", VA = "0x18858E990")]
		public static int JUFURAKXVZP(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x8590E10", Offset = "0x8590010", VA = "0x188590E10")]
		public static Log ZRYTTWBWOWT(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x858EE80", Offset = "0x858E080", VA = "0x18858EE80")]
		public static void OPQOIIEHAPG(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x85903B0", Offset = "0x858F5B0", VA = "0x1885903B0")]
		public static void UEVPWPUBFNL(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x858E560", Offset = "0x858D760", VA = "0x18858E560")]
		public static bool HQGGVOGTXHL(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x8590820", Offset = "0x858FA20", VA = "0x188590820")]
		public static int VGRGHGOGOIM(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x85905C0", Offset = "0x858F7C0", VA = "0x1885905C0")]
		public static string UYDJBQWRLSH(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x858E3C0", Offset = "0x858D5C0", VA = "0x18858E3C0")]
		public static (string[], int[]) HLMDTJYCKEQ()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x858EBA0", Offset = "0x858DDA0", VA = "0x18858EBA0")]
		private static int MSWNVJAHDBC(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x858E1E0", Offset = "0x858D3E0", VA = "0x18858E1E0")]
		private static int FICXADCDOKC(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x858F0A0", Offset = "0x858E2A0", VA = "0x18858F0A0")]
		private static int OUWDHQSELMO(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x858DC60", Offset = "0x858CE60", VA = "0x18858DC60")]
		private static int AWTBTQDXYAF(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x858DD30", Offset = "0x858CF30", VA = "0x18858DD30")]
		private static int AWTBTQDXYAF(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x858F8E0", Offset = "0x858EAE0", VA = "0x18858F8E0")]
		private static void QOAKFVOEXFW(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x858EAA0", Offset = "0x858DCA0", VA = "0x18858EAA0")]
		public static bool KSELHOUBDQU(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x858F7D0", Offset = "0x858E9D0", VA = "0x18858F7D0")]
		public static bool PYZUKHOHQWD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x858FF60", Offset = "0x858F160", VA = "0x18858FF60")]
		private static void SPOWCTIDPCT(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8590970", Offset = "0x858FB70", VA = "0x188590970")]
		public static void WOPQXPGVMKJ(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x858FA50", Offset = "0x858EC50", VA = "0x18858FA50")]
		public static void RGYZZJEEKMG(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x858F040", Offset = "0x858E240", VA = "0x18858F040")]
		private static void OUEYEITZTVV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x858DF00", Offset = "0x858D100", VA = "0x18858DF00")]
		private static void CJTPOOLDTTU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x858ECC0", Offset = "0x858DEC0", VA = "0x18858ECC0")]
		private static bool MXTKCKMTJOT(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x858FE10", Offset = "0x858F010", VA = "0x18858FE10")]
		private static bool RMLNGWHHQTY(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x858EE00", Offset = "0x858E000", VA = "0x18858EE00")]
		private static bool NLUXJIZXQWI(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x85902A0", Offset = "0x858F4A0", VA = "0x1885902A0")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x858F5F0", Offset = "0x858E7F0", VA = "0x18858F5F0")]
		private static void PSSOQGOWTVS(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x858F660", Offset = "0x858E860", VA = "0x18858F660")]
		public static FRHTBIGJUPM.MDVDCJMBZXA PUNILEDVAAS((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x858EB60", Offset = "0x858DD60", VA = "0x18858EB60")]
		public static void LWZAMEQWJDR(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x858EA60", Offset = "0x858DC60", VA = "0x18858EA60")]
		public static ParanoiaLevel KPHSHISKBZJ(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
