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
		[Cpp2IlInjected.Address(RVA = "0x99C3120", Offset = "0x99C1D20", VA = "0x1899C3120", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xF515A0", Offset = "0xF501A0", VA = "0x180F515A0")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool MQBWUEUTKBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x99C5960", Offset = "0x99C4560", VA = "0x1899C5960")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool QOZFTTWLLLD
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x99C5410", Offset = "0x99C4010", VA = "0x1899C5410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string HGXJPZZGYPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x99C5460", Offset = "0x99C4060", VA = "0x1899C5460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool BXDMPUECVXA
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x68C8DC0", Offset = "0x68C79C0", VA = "0x1868C8DC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel HDTDAIIHWMH
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x99C5DD0", Offset = "0x99C49D0", VA = "0x1899C5DD0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99C5E40", Offset = "0x99C4A40", VA = "0x1899C5E40")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15BC4D0", Offset = "0x15BB0D0", VA = "0x1815BC4D0")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99C5EA0", Offset = "0x99C4AA0", VA = "0x1899C5EA0")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3C15CD0", Offset = "0x3C148D0", VA = "0x183C15CD0")]
		public void EIITCSSNILU<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x99C4E80", Offset = "0x99C3A80", VA = "0x1899C4E80")]
		public void EIITCSSNILU(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x99C4FA0", Offset = "0x99C3BA0", VA = "0x1899C4FA0")]
		public void EIITCSSNILU(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x3C197A0", Offset = "0x3C183A0", VA = "0x183C197A0")]
		public void XHMZDWQHNZH<d>(bool a, Func<d, object> b, [In] d args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99C5CB0", Offset = "0x99C48B0", VA = "0x1899C5CB0")]
		public void XHMZDWQHNZH(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x3C18160", Offset = "0x3C16D60", VA = "0x183C18160")]
		public void NVJNDWKHFAC<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99C54B0", Offset = "0x99C40B0", VA = "0x1899C54B0")]
		public void NVJNDWKHFAC(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99C55D0", Offset = "0x99C41D0", VA = "0x1899C55D0")]
		public void NVJNDWKHFAC(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C0FBF0", Offset = "0x3C0E7F0", VA = "0x183C0FBF0")]
		public void DSWVXBBMQXT<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x99C4A50", Offset = "0x99C3650", VA = "0x1899C4A50")]
		public void DSWVXBBMQXT(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x99C4B80", Offset = "0x99C3780", VA = "0x1899C4B80")]
		public void DSWVXBBMQXT(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3C17210", Offset = "0x3C15E10", VA = "0x183C17210")]
		public void GODHZEQXDWE<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x99C5230", Offset = "0x99C3E30", VA = "0x1899C5230")]
		public void GODHZEQXDWE(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x99C5330", Offset = "0x99C3F30", VA = "0x1899C5330")]
		public void GODHZEQXDWE(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3C0F4E0", Offset = "0x3C0E0E0", VA = "0x183C0F4E0")]
		public void DDCGKZSOFZV<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x99C4500", Offset = "0x99C3100", VA = "0x1899C4500")]
		public void DDCGKZSOFZV(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x99C4600", Offset = "0x99C3200", VA = "0x1899C4600")]
		public void DDCGKZSOFZV(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x3C10110", Offset = "0x3C0ED10", VA = "0x183C10110")]
		public void EBHYHLSXVRO<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x99C4C90", Offset = "0x99C3890", VA = "0x1899C4C90")]
		public void EBHYHLSXVRO(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99C4D90", Offset = "0x99C3990", VA = "0x1899C4D90")]
		public void EBHYHLSXVRO(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99C50A0", Offset = "0x99C3CA0", VA = "0x1899C50A0")]
		public void FAKCWXTSJUT(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99C56D0", Offset = "0x99C42D0", VA = "0x1899C56D0")]
		public void RWEFGCBSQJG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x3C18920", Offset = "0x3C17520", VA = "0x183C18920")]
		public LogRangeScope TXVKMSRMXIT<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LogRangeScope LKAURQWGICG<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99C5840", Offset = "0x99C4440", VA = "0x1899C5840")]
		public LogRangeScope TXVKMSRMXIT(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99C5740", Offset = "0x99C4340", VA = "0x1899C5740")]
		public LogRangeScope TXVKMSRMXIT(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x10FE4F0", Offset = "0x10FD0F0", VA = "0x1810FE4F0")]
		public LogRangeScope LKAURQWGICG(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x99C59B0", Offset = "0x99C45B0", VA = "0x1899C59B0")]
		public void WJTCZYAYMPV(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99C5A90", Offset = "0x99C4690", VA = "0x1899C5A90")]
		public void WJTCZYAYMPV(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C18F80", Offset = "0x3C17B80", VA = "0x183C18F80")]
		public void WJTCZYAYMPV<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
		public void JGMHSQOAOKU([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99C5110", Offset = "0x99C3D10", VA = "0x1899C5110")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x99C46F0", Offset = "0x99C32F0", VA = "0x1899C46F0")]
		private static void DERVHXSSRBG(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log HRTJYQIOJHE;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log LZZEFCNREEV;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log ONZOWMNYLOR;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log FIPQOGDXVXI;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log HBLTVDNEEXS;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log ALUPXOBIVSQ;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log HFNVXTSCOPF;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log ADOZGDVXZYA;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log UNBJMXAVRFD;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log QEMFXQMHBOE;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log GDBXMOKJNWK;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log TUOTCCVDUSK;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log ZHSJZZGTKGM;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log FLFBXMFDSPP;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log AWZQGSOZVAP;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log HZGOQDGUBEH;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log MEAUOGPNNAV;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log LODPPTUIYKS;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log MWVHRFEDWHH;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log MBAQHMBHLZN;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log FTDSESZKGEB;
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
					public static readonly Log EGULIDLZFLZ;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log GTOOQHBWHZF;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log TNKUQUMWEHL;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log NZKDOTCPVYM;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log WJHXRQIVUXA;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log OOGYHCMDOHC;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log CWPYVWGYNKW;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log HXMAQJQBUBY;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log TNKUQUMWEHL;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log WJHXRQIVUXA;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log OOGYHCMDOHC;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log ZCRDHPYWLIX;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log GPIMNMHGBHY;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log BDWDAAUQMHU;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log COYETQJLNMM;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log GGWWDBXGQHH;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log EGULIDLZFLZ;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log IZMFUGEBRFV;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log IZGYWZKEHUM;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log IZWTOTRWKCN;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log IZRMRMXZARE;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log JAHHJHFRCZF;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log JACAMALTTNW;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log JARVDUTLVVX;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log JAMOGNZOMKO;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log JBCIYIHGOSP;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log JAXCBBNJFHG;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log EGULIDLZFLZ;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log IZMFUGEBRFV;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log IZGYWZKEHUM;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log IZWTOTRWKCN;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log IZRMRMXZARE;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log JAHHJHFRCZF;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log JACAMALTTNW;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log JARVDUTLVVX;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log JAMOGNZOMKO;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log JBCIYIHGOSP;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log JAXCBBNJFHG;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log EGULIDLZFLZ;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log UBWNPJBTCNZ;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log FQJBNXTQXPL;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log TTAZONQXWQV;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log DGGZEUJOSBP;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log ICGYGJJUPLQ;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log QMRQCMNJLAQ;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log FBRCGYKLNLL;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log EZMFYZFSYBY;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log IBTUNEZKTCF;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log IIVFZTGBALZ;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log DYRYUCPWVCH;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log OUTLAGFISDT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log ZCXEQYBMTTI;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log VJAIYEDSXZF;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log WXGBWLBMCPR;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log LRZDFQONCPJ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log RUMTDHTXIYX;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log HKUBQTXRZJS;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log EWSOCANEVYX;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log WWNRCTDPFVX;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log EVGKKLFZWFY;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log HDJLDELIFDC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log WLIWQFIKBVH;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log GTJPLRLQNYA;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log NMAJAYLSSRC;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log IKLSIPRVHKT;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log OFLCRHBJHXP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log KTKHYIKABTZ;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log EHBSSGDNCBJ;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log WWNRCTDPFVX;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log NBTOXMRXDLH;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log FTDSESZKGEB;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log HPWFWLDHZLX;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log JXQVTUZNBYU;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log IBTUNEZKTCF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log ZMRXRFKABWB;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log NSDGXEWADRG;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log XRJRDCIKGQJ;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log WGDFFQKTIBW;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log WWNRCTDPFVX;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log ULTSYXUTBLD;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log MUSBUSIQXIH;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log DKDISGXJLXA;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log ZRAEPKJPZOE;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log ZYRCXIXDJXG;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log XBRABTEINQW;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log QAVZRPAPNIG;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log UKPLTDOUANK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log DTJEWCEHDSJ;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log WWNRCTDPFVX;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log HBAHLKKFGER;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log CWTBSCNIMKO;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log BIAJPYMZSNB;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log OOJGJTHAFFA;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log GFZZKJNQVQF;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log GJUSFPDFDYJ;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log QEWPLXCLFAF;

			[Cpp2IlInjected.Token(Token = "0x4000086")]
			public static readonly Log XLZFCBYOERI;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log AMQLKGUOYJI;

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log GDSQHJLRBST;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public static readonly Log AWDZJYGAOIO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				private static readonly Log JBBHQSRXUHV;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log VWODOTNCKGH;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log ZTURYGTQWVX;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log OVRZSPBGQKD;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log KIMVHBOZMBU;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log GROZIUUFUDJ;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log DHBSZZJMPYK;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log RGPDCTESNNO;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log MZRGRIGDIDM;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log QEMFXQMHBOE;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log ZCRDHPYWLIX;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log AIIIRDEACOJ;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log MSRCUBIIEOS;

				[Cpp2IlInjected.Token(Token = "0x400009A")]
				public static readonly Log OFIFJQDFJXG;

				[Cpp2IlInjected.Token(Token = "0x400009B")]
				public static readonly Log TVKKHUAZLCN;

				[Cpp2IlInjected.Token(Token = "0x400009C")]
				public static readonly Log BBXDDZJNGBK;
			}

			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public static readonly Log EGULIDLZFLZ;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log DQTYAFMBBWV;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log CWYEATMZUPP;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log ARTCSILUAKP;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log HXAWXFUSTGF;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					private static readonly Log JBBHQSRXUHV;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log KQBITKPJCZK;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log AKRIERIEQAF;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log TKGRGMJILUK;

					[Cpp2IlInjected.Token(Token = "0x40000B9")]
					public static readonly Log GJOUDELVIBA;

					[Cpp2IlInjected.Token(Token = "0x40000BA")]
					public static readonly Log SXTYMXGDWEE;

					[Cpp2IlInjected.Token(Token = "0x40000BB")]
					public static readonly Log ARTCSILUAKP;

					[Cpp2IlInjected.Token(Token = "0x40000BC")]
					public static readonly Log XOAMGMOTGHG;
				}

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log UWVNOPMZHRU;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log MIYBYNBDMGF;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log SYGVJJSQFSU;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log BMXPIFGUJBN;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log CWYEATMZUPP;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log EPSQUSZPDLL;

				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				public static readonly Log OPVJQVBKSTG;

				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				public static readonly Log AEJPSRVXYTD;

				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				public static readonly Log JZIHDXXQVRM;

				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				public static readonly Log AZFGOVJSKPX;
			}

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log AJLLVFFZVZF;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log AXRQKWHIPPG;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log AFVVMVMIPEF;

			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public static readonly Log PBNSBLRYWTZ;

			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public static readonly Log SWPOZFPYPYP;

			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public static readonly Log QNLJGIBNCRO;

			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public static readonly Log HVKUELUVIMU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log TMNTTFRGXPG;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log CQAIDCGHMOR;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log RYHDJRUVXJV;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log YKLJCAWQLMD;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log VDHDGAAUBAO;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log RJIJUQDDAAQ;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log HPAGHEYYHYJ;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log VDVIWJYJPZV;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log RBYOQCJGEYG;

				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log SZTBPJYZBAE;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log XBXZOFRPTSN;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log GWCUXBMUZDG;

				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log NPMVDQFVIUK;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log GYAMEXJIDZY;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log FTJHOEQIACG;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class SEWUYAXAXGB
			{
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				public static readonly Log IPVFXGSMDZG;

				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				public static readonly Log VSQUYIUKNFO;

				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				public static readonly Log SOCZDFSYFUV;
			}

			[Cpp2IlInjected.Token(Token = "0x2000024")]
			public static class Renderer
			{
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				public static readonly Log FZVLZDUWYCF;
			}

			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public static readonly Log EGULIDLZFLZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x2000026")]
			public static class Preferences
			{
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				public static readonly Log OCYYZRCNCQE;

				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				public static readonly Log DOHFOCBNDBQ;

				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				public static readonly Log LIPJGVOPQAB;
			}

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log IPZWIAGODVX;

			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log ZKLSXYVUBAO;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log YJJFQCRKIKZ;

			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log TONGVMNKETS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log ZVFABEDREXV;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log NXBBAUNBVIX;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log BBXDDZJNGBK;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log VSAQVWXDBUZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log ACGDXVGMGLR;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log BUSKZEVBVHQ;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log EYYISITPMHX;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log PUBEZYKTPWC;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log UTAWSJUAMUJ;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log KPPLQUDEKYL;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log HDJSOXJOQNX;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log QQRSOQJOWOT;

			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log RCTYJVVKSPK;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log QCTNKUTWRBX;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log YTBWBPXJHUV;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log WWNRCTDPFVX;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log NCZFZVXKEPU;

			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			public static readonly Log ISFOTMMEWCG;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log VUHZGHFFAGM;

			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			public static readonly Log RMAFISYQLHC;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log IZWUGEDFWMY;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log RXDNNTZTPIA;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log LWSZTGTKCYT;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log NOSZOVVDGLF;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log FIPQOGDXVXI;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log MQDSNPZXIYR;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log EGMOMSARDJI;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log CPKJHHWBCKR;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log PGNRZNICGNO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log KFLAZCOMABK;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log NCFPKEHXQZZ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log PKFIKSUROZY;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log BCLINSTZBUH;

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			public static readonly Log RBERUVHSGZF;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log UNNUBRFARDF;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log EPYQPHKJJZF;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log GTOOAUHDGNN;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log QYOPFSVHNHD;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log DWREQLXMLWK;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log SHVHPBPWDYP;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log JQIJOVPDZCG;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log SDFUTQFUOMJ;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log RRDLAOSDCRM;

			[Cpp2IlInjected.Token(Token = "0x4000110")]
			public static readonly Log ZDZJXLLLMFO;

			[Cpp2IlInjected.Token(Token = "0x4000111")]
			public static readonly Log BDWDAAUQMHU;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002F")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				public static readonly Log EGULIDLZFLZ;

				[Cpp2IlInjected.Token(Token = "0x400011D")]
				public static readonly Log QZTVXABULEF;

				[Cpp2IlInjected.Token(Token = "0x400011E")]
				public static readonly Log TXDUIOGFOZK;
			}

			[Cpp2IlInjected.Token(Token = "0x4000112")]
			private static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x4000113")]
			public static readonly Log NOUCDGTBLCF;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log ODJBESMZHYZ;

			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log IXCOHQQWPRG;

			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log KBGMGGYTOSV;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log DRAAWNYSHEN;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log SPFWNJBYVWF;

			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log IBHDKEFMSTR;

			[Cpp2IlInjected.Token(Token = "0x400011A")]
			public static readonly Log FGGFVDAZQEX;

			[Cpp2IlInjected.Token(Token = "0x400011B")]
			public static readonly Log VSTRVOXPRHF;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private static readonly Log JBBHQSRXUHV;

			[Cpp2IlInjected.Token(Token = "0x4000120")]
			public static readonly Log HGAMORLESVH;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			public static readonly Log EGULIDLZFLZ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x4000123")]
			public static readonly Log IKFKUTWMCIF;

			[Cpp2IlInjected.Token(Token = "0x4000124")]
			public static readonly Log YEWPRXSBGQR;
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			public static readonly Log EGULIDLZFLZ;

			[Cpp2IlInjected.Token(Token = "0x4000126")]
			public static readonly Log ETACHATBLUX;

			[Cpp2IlInjected.Token(Token = "0x4000127")]
			public static readonly Log XLTWHRRPURM;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class WHDWBEISYNU
	{
		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public class LKRQSHZACKC : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private readonly (int index, bool enabled)[] VFJONXVXFKT;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000129")]
			private List<(int index, bool enabled)> XJCBTFGFHGB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400012A")]
			private bool BJMBNGSDTSF;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x99C2A80", Offset = "0x99C1680", VA = "0x1899C2A80")]
			internal LKRQSHZACKC((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x99C2A00", Offset = "0x99C1600", VA = "0x1899C2A00")]
			public IDisposable ZKJDPREQDJM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x99C2950", Offset = "0x99C1550", VA = "0x1899C2950", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public static class QXSACMYJTSL
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		private static readonly Log JBBHQSRXUHV;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log BBVYPLXOXHD;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log YPIEBPSMRDO;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log MNWJDAJPGSL;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log JVZDCTWKAUP;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log ZELZJDJVUGJ;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log TUTCNJSQYVW;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log NCFPKEHXQZZ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log WXLAYTRRCNN;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log LZOTXNWIGUJ;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log PFAJKELISZF;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log YXREUIKFKEW;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log CPZTXHJFAHP;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log OWTYIJWBOWG;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log ETQMSVDBQNP;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log QPTCAZMYGNX;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log AZXBMGOUQNY;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log RBERUVHSGZF;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log TLZXLGROPRH;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log ZJSTYQORCUA;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log HTMZKUUOCXN;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log QEMFXQMHBOE;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log SBTMNHZREVS;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log OSWPBUVYBYV;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log ODHEGVZHCYK;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log NRQKIBFOWNC;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log ONIIAVAYJCU;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log REDHFEBIMWA;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log ZSFIXKYGQFB;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log GADVXPYJHSW;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log WDNILCBEMDT;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log UKYFYPHAFNA;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log HYWWWKRTAFP;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log DYVLYFRNJTM;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Log VLXDKECXCEJ;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Log NZKDOTCPVYM;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly Log KOPZCPMGRRW;

		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public static readonly Log LCFWUQWVSSI;

		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public static readonly Log FKQIBKCAROQ;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public static readonly Log DEGDJGSYYML;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public static readonly Log IYJYRTYEDBJ;

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static readonly Log WRWNPNOGNWV;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		public static readonly Log LWFTKVRKLCC;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		public static readonly Log HYSRMJNTBCJ;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		public static readonly Log IRNOHXQKFKU;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		public static readonly Log TVZGYTVCQXO;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public static readonly Log LAAIZVMRTYT;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public static readonly Log SFLOFCECTRG;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log SGRSRWHFIWA
		{
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x99C7460", Offset = "0x99C6060", VA = "0x1899C7460")]
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
	internal class ESWXUIDLTCE
	{
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400015C")]
			private ESWXUIDLTCE parent;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0xEC80B0", Offset = "0xEC6CB0", VA = "0x180EC80B0")]
			public Scope(ESWXUIDLTCE parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private readonly Stopwatch AULIOHMJHTR;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x10CD690", Offset = "0x10CC290", VA = "0x1810CD690")]
		public Scope JJSXRNTQRWI()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x99BD690", Offset = "0x99BC290", VA = "0x1899BD690")]
		public ESWXUIDLTCE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public interface TWXUSQEJIPV
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void EIITCSSNILU(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void NVJNDWKHFAC(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void GODHZEQXDWE(object a, [Optional] object b);
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
		[Cpp2IlInjected.Address(RVA = "0x99C3080", Offset = "0x99C1C80", VA = "0x1899C3080")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x99C3010", Offset = "0x99C1C10", VA = "0x1899C3010", Slot = "4")]
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
		public abstract void SIFQFAPRLAF();

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	internal static class AKRJCPKQIIC
	{
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static List<LogRegistrationIndex> KRZTVONMCWZ;

		[Cpp2IlInjected.Token(Token = "0x4000160")]
		private static bool OSHBXGJJKGS;

		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private static readonly object QBIYQIATYFT;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> KRMFVPSOCEN
		{
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x99BBEA0", Offset = "0x99BAAA0", VA = "0x1899BBEA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x99BBAE0", Offset = "0x99BA6E0", VA = "0x1899BBAE0")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x99BB8D0", Offset = "0x99BA4D0", VA = "0x1899BB8D0")]
		private static void EDCDZDJEMID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x99BBC60", Offset = "0x99BA860", VA = "0x1899BBC60")]
		private static void KSGDUTVNAJS(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public static class JDPESYWRFUV
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003E")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000097")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000098")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			public void LPPEIGCWOHB(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40")]
			public ParanoiaLevel BPRBXVTBVNN(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x600009A")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEEB30", VA = "0x180CEFF30")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public static Action AWRUUXEIWDO;

		[Cpp2IlInjected.Token(Token = "0x4000163")]
		private static readonly object JWTQHVUCLKM;

		[Cpp2IlInjected.Token(Token = "0x4000164")]
		private static readonly Dictionary<(int parentIndex, string token), int> XSCNQFRBSIC;

		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private static readonly List<string> LZSHAFHKHSS;

		[Cpp2IlInjected.Token(Token = "0x4000166")]
		private static readonly List<int> UWIZOLXIJGD;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private static readonly List<ulong> VDAJQQNMFHB;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private static readonly List<ulong> PUCVXMDMEWI;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		private static readonly List<ulong> EYGDNDUKORV;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		private static readonly StringBuilder SAPQCRLZTOB;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		private static readonly ESWXUIDLTCE IPAFJWBYNGR;

		[Cpp2IlInjected.Token(Token = "0x400016C")]
		private static Debug MNRMLMKGZNB;

		[Cpp2IlInjected.Token(Token = "0x400016D")]
		private static int VCRMXGEGCVP;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static TWXUSQEJIPV MPVCMIXWMGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x99BF630", Offset = "0x99BE230", VA = "0x1899BF630")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x99C0DD0", Offset = "0x99BF9D0", VA = "0x1899C0DD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool YTQCBPTLOIF
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x99BF680", Offset = "0x99BE280", VA = "0x1899BF680")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool YTLJBWVZXYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x99BF2C0", Offset = "0x99BDEC0", VA = "0x1899BF2C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool UVHXIIUSANQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x99C2460", Offset = "0x99C1060", VA = "0x1899C2460")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x99BF890", Offset = "0x99BE490", VA = "0x1899BF890")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x99C24F0", Offset = "0x99C10F0", VA = "0x1899C24F0")]
		static JDPESYWRFUV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x99BFAF0", Offset = "0x99BE6F0", VA = "0x1899BFAF0")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x99C0E40", Offset = "0x99BFA40", VA = "0x1899C0E40")]
		public static int SIFQFAPRLAF(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x99C0FE0", Offset = "0x99BFBE0", VA = "0x1899C0FE0")]
		public static int SIFQFAPRLAF(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x99C0820", Offset = "0x99BF420", VA = "0x1899C0820")]
		public static Log PXXJOAVVPYH(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x99BF6D0", Offset = "0x99BE2D0", VA = "0x1899BF6D0")]
		public static void HIYUDAFUCMA(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99BF8E0", Offset = "0x99BE4E0", VA = "0x1899BF8E0")]
		public static void INJFNUTAUFL(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x99C1D00", Offset = "0x99C0900", VA = "0x1899C1D00")]
		public static bool VVKCICVJOYB(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x99C21F0", Offset = "0x99C0DF0", VA = "0x1899C21F0")]
		public static int XOTGXWPEYNO(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x99C1170", Offset = "0x99BFD70", VA = "0x1899C1170")]
		public static string TEJFSFZFWRR(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x99BF310", Offset = "0x99BDF10", VA = "0x1899BF310")]
		public static (string[], int[]) EBRYMMPAOMM()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x99C2340", Offset = "0x99C0F40", VA = "0x1899C2340")]
		private static int ZEGWPMQXANC(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x99BFE70", Offset = "0x99BEA70", VA = "0x1899BFE70")]
		private static int LNNTQLKOIWG(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x99C0870", Offset = "0x99BF470", VA = "0x1899C0870")]
		private static int REULSWUIWDY(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x99C1A60", Offset = "0x99C0660", VA = "0x1899C1A60")]
		private static int VNAZZOCOYUJ(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x99C1B30", Offset = "0x99C0730", VA = "0x1899C1B30")]
		private static int VNAZZOCOYUJ(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x99BF4C0", Offset = "0x99BE0C0", VA = "0x1899BF4C0")]
		private static void EDEJCHQQDRC(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x99C2130", Offset = "0x99C0D30", VA = "0x1899C2130")]
		public static bool XFAHWUOIBMQ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x99C1FF0", Offset = "0x99C0BF0", VA = "0x1899C1FF0")]
		public static bool WYFIYPURXNN(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x99C0460", Offset = "0x99BF060", VA = "0x1899C0460")]
		private static void ODTFJRZKHSX(int a, bool b, bool c = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x99C1450", Offset = "0x99C0050", VA = "0x1899C1450")]
		public static void TMAPLLTILWZ(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x99C00A0", Offset = "0x99BECA0", VA = "0x1899C00A0")]
		public static void MXYTNONVSYS(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x99C07B0", Offset = "0x99BF3B0", VA = "0x1899C07B0")]
		private static void OLIWZQWAPPV()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x99C1D80", Offset = "0x99C0980", VA = "0x1899C1D80")]
		private static void WKKEWUUHXRU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x99BFF60", Offset = "0x99BEB60", VA = "0x1899BFF60")]
		private static bool LXJUFUFLAXZ(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x99C1900", Offset = "0x99C0500", VA = "0x1899C1900")]
		private static bool VDGHFUUZYES(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x99C20B0", Offset = "0x99C0CB0", VA = "0x1899C20B0")]
		private static bool WZHEHJKZUEI(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x99C10B0", Offset = "0x99BFCB0", VA = "0x1899C10B0")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x99C13E0", Offset = "0x99BFFE0", VA = "0x1899C13E0")]
		private static void THHZRBLJOBS(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x99BFD00", Offset = "0x99BE900", VA = "0x1899BFD00")]
		public static WHDWBEISYNU.LKRQSHZACKC LGRXVTGZAMW((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x99BFF20", Offset = "0x99BEB20", VA = "0x1899BFF20")]
		public static void LPPEIGCWOHB(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x99BF280", Offset = "0x99BDE80", VA = "0x1899BF280")]
		public static ParanoiaLevel BPRBXVTBVNN(int a)
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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
