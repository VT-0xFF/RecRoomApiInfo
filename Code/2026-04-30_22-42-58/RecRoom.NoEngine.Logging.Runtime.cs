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
		[Cpp2IlInjected.Address(RVA = "0x99046B0", Offset = "0x9903AB0", VA = "0x1899046B0", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xF6C9A0", Offset = "0xF6BDA0", VA = "0x180F6C9A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool PGVLFNMUCGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9906C40", Offset = "0x9906040", VA = "0x189906C40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DDIDTMRCAYD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9906BF0", Offset = "0x9905FF0", VA = "0x189906BF0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CEZWGVWVPKV
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x99072E0", Offset = "0x99066E0", VA = "0x1899072E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool EBAROFIKFFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x698F950", Offset = "0x698ED50", VA = "0x18698F950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel LWTVGEFGOIJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9905FF0", Offset = "0x99053F0", VA = "0x189905FF0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9907330", Offset = "0x9906730", VA = "0x189907330")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15C4A60", Offset = "0x15C3E60", VA = "0x1815C4A60")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9907390", Offset = "0x9906790", VA = "0x189907390")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3BF33D0", Offset = "0x3BF27D0", VA = "0x183BF33D0")]
		public void VOOCJPOLHSY<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9906C90", Offset = "0x9906090", VA = "0x189906C90")]
		public void VOOCJPOLHSY(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9906DA0", Offset = "0x99061A0", VA = "0x189906DA0")]
		public void VOOCJPOLHSY(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3BF2660", Offset = "0x3BF1A60", VA = "0x183BF2660")]
		public void QNIJTXVCGTR<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9906900", Offset = "0x9905D00", VA = "0x189906900")]
		public void QNIJTXVCGTR(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5A90", Offset = "0x3BF4E90", VA = "0x183BF5A90")]
		public void ZBDLTDBERZS<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99070C0", Offset = "0x99064C0", VA = "0x1899070C0")]
		public void ZBDLTDBERZS(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99071E0", Offset = "0x99065E0", VA = "0x1899071E0")]
		public void ZBDLTDBERZS(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3BEBCD0", Offset = "0x3BEB0D0", VA = "0x183BEBCD0")]
		public void AORZLKXFNRB<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9905B50", Offset = "0x9904F50", VA = "0x189905B50")]
		public void AORZLKXFNRB(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9905A40", Offset = "0x9904E40", VA = "0x189905A40")]
		public void AORZLKXFNRB(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3BF28E0", Offset = "0x3BF1CE0", VA = "0x183BF28E0")]
		public void TUAEUFLAQYK<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x9906B00", Offset = "0x9905F00", VA = "0x189906B00")]
		public void TUAEUFLAQYK(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9906A20", Offset = "0x9905E20", VA = "0x189906A20")]
		public void TUAEUFLAQYK(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3BEC120", Offset = "0x3BEB520", VA = "0x183BEC120")]
		public void BVHVVZAWQJT<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x9905C80", Offset = "0x9905080", VA = "0x189905C80")]
		public void BVHVVZAWQJT(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x9905D80", Offset = "0x9905180", VA = "0x189905D80")]
		public void BVHVVZAWQJT(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3BF12C0", Offset = "0x3BF06C0", VA = "0x183BF12C0")]
		public void NWUFWMXZHTA<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x9906800", Offset = "0x9905C00", VA = "0x189906800")]
		public void NWUFWMXZHTA(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9906720", Offset = "0x9905B20", VA = "0x189906720")]
		public void NWUFWMXZHTA(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9905E60", Offset = "0x9905260", VA = "0x189905E60")]
		public void DUIPZBZWBSZ(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99066B0", Offset = "0x9905AB0", VA = "0x1899066B0")]
		public void NDWOYGLUGDA(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3BF5490", Offset = "0x3BF4890", VA = "0x183BF5490")]
		public LogRangeScope XCBJXVSCADD<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LogRangeScope TVFENCUZWWE<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9906FA0", Offset = "0x99063A0", VA = "0x189906FA0")]
		public LogRangeScope XCBJXVSCADD(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9906EA0", Offset = "0x99062A0", VA = "0x189906EA0")]
		public LogRangeScope XCBJXVSCADD(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10FC530", Offset = "0x10FB930", VA = "0x1810FC530")]
		public LogRangeScope TVFENCUZWWE(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9906060", Offset = "0x9905460", VA = "0x189906060")]
		public void IPJBWKZBOWB(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9906140", Offset = "0x9905540", VA = "0x189906140")]
		public void IPJBWKZBOWB(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3BED020", Offset = "0x3BEC420", VA = "0x183BED020")]
		public void IPJBWKZBOWB<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
		public void ODAIZNTJAFE([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9905ED0", Offset = "0x99052D0", VA = "0x189905ED0")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9906350", Offset = "0x9905750", VA = "0x189906350")]
		private static void KJZTNFBFPYK(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log QKFRIHKQVIQ;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log VSSSOZWCEGH;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log CHUJMSPTCSD;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log NJZSATNLRYU;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log YVVJIHKGLFY;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log WSVZHHGCJOS;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log QKEEWFGVSMZ;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log UZREOSESZPE;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log HFJDNJXBQBB;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log SXQXONPSEXE;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log EKEHALNSTKQ;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log NOJSHIVXMCY;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log HHIJHDUYZAG;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log QFYFYARBCPJ;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log UBAVUUSADMR;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log AMHUIKJJGRX;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log FWVORDFDFHR;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log WSBWNITCARC;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log RXUNUNFXBRR;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log MGBFETPAQFX;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log HZWHGRCCLJV;
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
					public static readonly Log BUKDVQXMLGR;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log MVWQAYEYSGB;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log OSGEQJQOXBR;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log VBNTNOORCAG;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log QWUYUBCZTVW;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log WIVAQPXBRSW;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log VDSVLTZVGNG;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log IEBVBCBRJSM;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log OSGEQJQOXBR;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log QWUYUBCZTVW;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log WIVAQPXBRSW;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log HZOZSEXQTAV;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log FZOZJFRSXVG;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log TTHEOXDVBMM;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log ILDXNMCXBAG;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log VIPOSDQCBET;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log BUKDVQXMLGR;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log KEYXSXLKFSR;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log KETQVQRMWHI;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log KEOJYJXPMVZ;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log KEJDBDDSDKQ;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log KFTZHYMZRMB;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log KFOSKRTCIAS;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log KFJLNKZEYPJ;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log KFEEQEFHPEA;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log KGPAWZOPDFL;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log KGJTZSURTUC;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log BUKDVQXMLGR;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log KEYXSXLKFSR;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log KETQVQRMWHI;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log KEOJYJXPMVZ;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log KEJDBDDSDKQ;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log KFTZHYMZRMB;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log KFOSKRTCIAS;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log KFJLNKZEYPJ;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log KFEEQEFHPEA;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log KGPAWZOPDFL;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log KGJTZSURTUC;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log BUKDVQXMLGR;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log QMSTLZZZNZH;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log ALROZTCYPDR;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log YZAWNGDZCET;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log OELZRCJAGGX;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log FWJASONIWXC;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log WUAGOHAXSFE;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log ADUNTYNEDXR;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log RTWQCVGOVHG;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log MEULAKGEUQL;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log SCTOBCZLJPL;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log ATYHEDRTPEJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log NGSBBNKFOWH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log YWRFTXKQSLS;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log ZRPIOLWWJSB;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log SPVAFUBCZSR;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log DWGXWNWLUAR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log WTHUAPAOQHP;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log AICYEPAWKGS;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log BWWLEUBBVON;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log WXJJPBCOZPF;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log AEGOLHSBRGA;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log TJMIEHLXYZA;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log VMQSUHJDKJN;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log RZYPDBAFULU;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log AUZZDKMMMZU;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log GNVSJIXCFBD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log LGRBTPVIANB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log OKPDAXKAVUV;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log YOQRXXQPZYR;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log WXJJPBCOZPF;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log JEKBJFJUBIL;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log HZWHGRCCLJV;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log RCBMCXSJYXJ;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log FKAGXCKCGVI;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log MEULAKGEUQL;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log OJRVFAZMEDV;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log NAEMMEYEIGW;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log CQGWBAHEJFV;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log HYTYBCPXZZQ;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log WXJJPBCOZPF;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log EHKEZEHPAHV;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log UVCXCDVNVBH;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log PJTYDTSKDLK;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log JAJLYGEMCWO;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log RQEIKSVYLNA;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log DUGKDEGQFZK;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log GKVXMQRVFSA;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log YOLXGSYRQWS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log AHEESTVBFVZ;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log WXJJPBCOZPF;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log LVUHKVLXUPZ;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log ALODGAEGUBW;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log XJWFWKPLNHD;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log GWWLNSWHICA;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log VTKOABTSVGH;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log GWEHCTNRFSL;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log UFYVHOGHFEX;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log XLMGWOEQGSU;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log ZZSYBADUQWU;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log AFYDEDUGRKB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log NPPWVIXLUOM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log RSHPAJUCFWJ;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log SMIZOIXUFPT;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log WFILSFSANDJ;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log ZWJDXOYAHZP;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log BKKIDJURNQE;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log FBYDRZVQAMB;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log CMLLCGQOOVK;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log HKPZFIXUTFA;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log TEMXADPTBYU;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log SXQXONPSEXE;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log HZOZSEXQTAV;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log EMOFCZBWIIL;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log XXACUWNPPVG;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log XJMGIEKJBLY;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log YYJLDUDBMSP;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log VKQEMTSUDKC;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log BUKDVQXMLGR;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log ZBPBOLUYNSD;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log GMFPPVLPIHF;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log WROSJVVHLEZ;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log WZPQUHIPZRJ;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log RSHPAJUCFWJ;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log BVMXCTCHXLI;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log TCBLUPTGVYH;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log AYQMCYKGBEA;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log ZBAXHFOXMBC;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log UKMSHOWCJZM;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log WROSJVVHLEZ;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log MMNVLXPKWDA;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log HGKBEBVMQPO;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log PFPRWZYZZSH;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log IVWVJJEUNFQ;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log JQPITFLKRIN;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log GMFPPVLPIHF;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log GLTGZLIKSCT;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log MNPVYJNAAGK;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log TOUUEPVKMNF;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log LNOTVFBLHTO;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log UVAJCAKKEDF;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log ORPDFZSELEJ;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log OFEAJVFMULU;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log UYKCYLBLEKT;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log XIBGTCDVBGJ;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log MATAWVCRYYR;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log JANLXQIDYCW;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log WTNOJSFBHRU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log IOZAENWRBRU;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log IPVPMRJUNMT;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log TVOCYZTTIPT;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log SIMWJVTSATP;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log YTEKBIZYTWY;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log SOYMECGFUSW;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log IUPFYBUDDHN;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log BEOZFZFCZGV;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log KHLLOQQAUNW;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log RQNIRCFZCRE;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log KYCISXZOIDF;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log UZJPCJWWUZM;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log EUXRCNDYKJO;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log XEJYXGVLVQE;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log HTFIBYEWCBW;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class KITOPJZHWRR
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log GUVZRPDFAMS;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log JGXIWTTFAUW;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log CYKVFANEZBZ;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log ULBXQZJUEPN;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log BUKDVQXMLGR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log BXALEOPASRE;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log DTVRAMYZIDS;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log PIPMGNIGTLB;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log QUFITABHKUD;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log ALMCWHYPILW;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log VRKIWARSTHZ;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log VBEKZMPLULI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log NILJOKVKITL;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log MSUXKRPWDWV;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log VKQEMTSUDKC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log FMEWXSUJJGT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log HTYJQAHHZOJ;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log WSTPQIFMUIQ;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log UNNMOPAPBHN;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log FENODAWFWHG;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log XOEPEXGNUCH;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log WEXYZZTRPVP;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log KRPZXRWDIZN;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log NLLAWEEQAVP;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log BHUVSFHVFJQ;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log SFFUGCIPTBV;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log RBCHJSCFMNB;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log WXJJPBCOZPF;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log LFHNOYIZMVO;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log KZHCQVRNQBC;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log GBETARCNRFM;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log HPXUQXGQHHI;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log CXLNBAIUDSO;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log NKJLJCNBKCK;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log UUQUXVNSVIF;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log QGTRVPFEGIV;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log NJZSATNLRYU;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log XBPHJBUHXEX;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log PPBPPGQKHDW;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log ODUMBPHJOXJ;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log JXNWZANMOJY;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log NJSJXXVNDWK;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log MVYFYUDAUCJ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log IJASRWVNXQQ;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log BLZKMWIDPOJ;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log DNBRATDRGAV;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log ZLHFWOQTTHT;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log DRRULUWQKMN;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log SBYKEBUPNNX;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log XNCJUGEENFB;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log FEAKBNCSJSA;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log PJRADMFWNFX;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log WARJEEODAWQ;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log ZLVMKHDFGJV;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log OTKYZZYYZWY;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log RBTZXBGJJRY;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log TTHEOXDVBMM;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log BUKDVQXMLGR;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log HYWRTSJRFLV;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log QHEQDXUIMSK;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log YZRMIHWGQIP;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log UKNHHWVDJDF;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log UDBULGQLKZQ;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log CVNOFMYHZLZ;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log VLZWKUNPILZ;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log ZFDKTCEWNFR;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log NBEIRSIJBQZ;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log LHGYZLKZEEZ;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log JRWFSLJACHD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log RSHPAJUCFWJ;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log QQCYYJWFDBZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log BUKDVQXMLGR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log PNRMKIQFNWX;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log HIHMGCOVWST;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log BUKDVQXMLGR;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log PKYDSVAFQAF;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log RHXSOXXLVSU;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HRVCPSHXFRC
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class KAAEAQSWIRS : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] GRGLIWMFYPL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> DRJWDPKXICP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool KINCPHEALZR;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x9903E30", Offset = "0x9903230", VA = "0x189903E30")]
			internal KAAEAQSWIRS((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x9903DB0", Offset = "0x99031B0", VA = "0x189903DB0")]
			public IDisposable TJGVYLHKEDG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x9903D00", Offset = "0x9903100", VA = "0x189903D00", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class AUCWXHTVYQJ
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log RSHPAJUCFWJ;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log OKYHGBQOTPF;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log YTFMQEKFSZE;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log MPAKRANHIXX;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log RLXFYKSYKTP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log QSFJUGLNWBR;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log ZNHAOEFIVEW;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log MVYFYUDAUCJ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log HCMUWJRUCCB;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log OTNGNJGFKCX;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log NJTUYZKPNIV;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log MMPTMANADQY;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log MNTIFGRIHCD;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log TYZDFPSJYSY;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log VGUQLLSMDXV;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log EPCOIZOFROP;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log IKWRZQICJMA;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log DNBRATDRGAV;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log HVWQDOVVOSH;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log QGUIUSCRADI;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log TTRJFQPSBKJ;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log SXQXONPSEXE;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log RCZQPKIVOSG;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log AEVYNJFSCXB;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log RSWWZKQAYTW;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log LZVJWKMIKEC;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log WTHMXXPZZHY;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log MBYPYXDRNOG;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log VKNXSVQVUJT;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log HPDFCNMKWTG;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log GAFXEWSMZHV;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log CYOPAUACXHK;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log COWWBJLQVVZ;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log DHGRJJJJGVK;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log HRDTNZAYLOH;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log VBNTNOORCAG;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log YXXGHXXYXRM;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log JKWYGGRMMQS;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log DNYXWVNESTU;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log SHULRVTYTNT;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log RNJWANRBFCN;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log IOVEUMTDRQL;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log ZQWICQDNOFK;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log IFTPCAPRUWP;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log PMGETMJRWSS;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log ZPQMPFPCFHI;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log NLHUFLHSVHX;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log PUKVDCSKLDY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log QWKTIKZPQAC
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x98FBB30", Offset = "0x98FAF30", VA = "0x1898FBB30")]
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
	internal class MCNTZEQVQHQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private MCNTZEQVQHQ parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xED9440", Offset = "0xED8840", VA = "0x180ED9440")]
			public Scope(MCNTZEQVQHQ parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch EFOJWVHRAGJ;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x10E36E0", Offset = "0x10E2AE0", VA = "0x1810E36E0")]
		public Scope BBJERXZKODM()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9907450", Offset = "0x9906850", VA = "0x189907450")]
		public MCNTZEQVQHQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface BRJXWIDECGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void VOOCJPOLHSY(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void ZBDLTDBERZS(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void TUAEUFLAQYK(object a, [Optional] object b);
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
		[Cpp2IlInjected.Address(RVA = "0x9904610", Offset = "0x9903A10", VA = "0x189904610")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99045A0", Offset = "0x99039A0", VA = "0x1899045A0", Slot = "4")]
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
		public abstract void GZVUEGYMGMP();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class HTIHLXOJCGY
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> MVSLMZUJDPB;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool IMNVEEZSMTO;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object JGRTEVQRLGT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> INOEKSBIJFF
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x99036F0", Offset = "0x9902AF0", VA = "0x1899036F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9903580", Offset = "0x9902980", VA = "0x189903580")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x9903970", Offset = "0x9902D70", VA = "0x189903970")]
		private static void YRCBYSWMHMR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x9903730", Offset = "0x9902B30", VA = "0x189903730")]
		private static void UURATOYBKDE(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class CXRQETDSQED
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			public void BKDAZASLGPT(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0")]
			public ParanoiaLevel ODNYUHTXJJX(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCF4190", Offset = "0xCF3590", VA = "0x180CF4190")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action GNKDKMVLYVI;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object URJJGGOEDGO;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> YMOPGHUFPVC;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> HIFBPJTFTDO;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> KYABLVHEEFD;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> ITSVJRSCESZ;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> WRUDMLEXRVY;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> PLNMRYQYSKV;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder GLMRXGODOXB;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly MCNTZEQVQHQ HQPBFQOMVGX;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug QYHHZIOVWLT;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int XTGTKAMHZBN;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static BRJXWIDECGJ KHLKFNYWTNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9900A30", Offset = "0x98FFE30", VA = "0x189900A30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x98FFC10", Offset = "0x98FF010", VA = "0x1898FFC10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool LAFFQERUZZJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x98FE220", Offset = "0x98FD620", VA = "0x1898FE220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool QOUAWTKPKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x98FDFD0", Offset = "0x98FD3D0", VA = "0x1898FDFD0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool QXNWHTPALYY
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x98FFEE0", Offset = "0x98FF2E0", VA = "0x1898FFEE0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x98FEE20", Offset = "0x98FE220", VA = "0x1898FEE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9901030", Offset = "0x9900430", VA = "0x189901030")]
		static CXRQETDSQED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x98FEE70", Offset = "0x98FE270", VA = "0x1898FEE70")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x98FE9A0", Offset = "0x98FDDA0", VA = "0x1898FE9A0")]
		public static int GZVUEGYMGMP(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x98FEB40", Offset = "0x98FDF40", VA = "0x1898FEB40")]
		public static int GZVUEGYMGMP(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9900CA0", Offset = "0x99000A0", VA = "0x189900CA0")]
		public static Log YSUOHJHYAIZ(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9900A80", Offset = "0x98FFE80", VA = "0x189900A80")]
		public static void WACJFSJDTAS(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x98FEC10", Offset = "0x98FE010", VA = "0x1898FEC10")]
		public static void HEEYGPPZTNR(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99002D0", Offset = "0x98FF6D0", VA = "0x1899002D0")]
		public static bool UBLMRRYDZFF(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x98FFA80", Offset = "0x98FEE80", VA = "0x1898FFA80")]
		public static int NNMNMOFQALQ(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x98FFC80", Offset = "0x98FF080", VA = "0x1898FFC80")]
		public static string PCDLKONKLNT(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x98FF8E0", Offset = "0x98FECE0", VA = "0x1898FF8E0")]
		public static (string[], int[]) KVYBOTDBCQS()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x9900890", Offset = "0x98FFC90", VA = "0x189900890")]
		private static int UOMWEFCKSPY(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x98FE3E0", Offset = "0x98FD7E0", VA = "0x1898FE3E0")]
		private static int FVFVOTOYSOE(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x9900350", Offset = "0x98FF750", VA = "0x189900350")]
		private static int UDRYMDHWFRG(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x9900140", Offset = "0x98FF540", VA = "0x189900140")]
		private static int PXQJCVYBPBR(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x98FFF70", Offset = "0x98FF370", VA = "0x1898FFF70")]
		private static int PXQJCVYBPBR(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x98FE270", Offset = "0x98FD670", VA = "0x1898FE270")]
		private static void FQDYMRVGRKW(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x98FE160", Offset = "0x98FD560", VA = "0x1898FE160")]
		public static bool EILVLPUWUBA(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x98FF820", Offset = "0x98FEC20", VA = "0x1898FF820")]
		public static bool KTAHZZAZKPD(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x9900CF0", Offset = "0x99000F0", VA = "0x189900CF0")]
		private static void ZWUPRVEKDBP(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x98FF080", Offset = "0x98FE480", VA = "0x1898FF080")]
		public static void KBGAAGYSBEP(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x98FE490", Offset = "0x98FD890", VA = "0x1898FE490")]
		public static void FVHZUBSQWQA(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x9900C40", Offset = "0x9900040", VA = "0x189900C40")]
		private static void WHXRIZKNMWF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x98FF540", Offset = "0x98FE940", VA = "0x1898FF540")]
		private static void KKWBFTDFIUM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x98FE020", Offset = "0x98FD420", VA = "0x1898FE020")]
		private static bool DYKXBRKPOUB(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x98FE850", Offset = "0x98FDC50", VA = "0x1898FE850")]
		private static bool GJLYYTPBQCU(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99009B0", Offset = "0x98FFDB0", VA = "0x1899009B0")]
		private static bool VNWYXTWJHOK(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x9900210", Offset = "0x98FF610", VA = "0x189900210")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x98FF7B0", Offset = "0x98FEBB0", VA = "0x1898FF7B0")]
		private static void KOONUDNCAZQ(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x98FDE20", Offset = "0x98FD220", VA = "0x1898FDE20")]
		public static HRVCPSHXFRC.KAAEAQSWIRS BKBQCBRYJPC((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x98FDF90", Offset = "0x98FD390", VA = "0x1898FDF90")]
		public static void BKDAZASLGPT(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x98FFBD0", Offset = "0x98FEFD0", VA = "0x1898FFBD0")]
		public static ParanoiaLevel ODNYUHTXJJX(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
