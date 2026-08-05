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
		[Cpp2IlInjected.Address(RVA = "0x86FCD70", Offset = "0x86FBB70", VA = "0x1886FCD70", Slot = "4")]
		public override void PUOFOOQAOVA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
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
			[Cpp2IlInjected.Address(RVA = "0xDB2230", Offset = "0xDB1030", VA = "0x180DB2230")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public bool RRFYEYNDHRQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x86FF5C0", Offset = "0x86FE3C0", VA = "0x1886FF5C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KTKLQVYTEAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x86FE1A0", Offset = "0x86FCFA0", VA = "0x1886FE1A0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string ORFYTREAQJW
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x86FE260", Offset = "0x86FD060", VA = "0x1886FE260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool QMJEJQMQHET
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x55ABF20", Offset = "0x55AAD20", VA = "0x1855ABF20")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public ParanoiaLevel QUPNZQBKJUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x86FE1F0", Offset = "0x86FCFF0", VA = "0x1886FE1F0")]
			get
			{
				return default(ParanoiaLevel);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public Log this[string name]
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x86FF970", Offset = "0x86FE770", VA = "0x1886FF970")]
			get
			{
				return default(Log);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x15B1800", Offset = "0x15B0600", VA = "0x1815B1800")]
		public Log(int index)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86FF9D0", Offset = "0x86FE7D0", VA = "0x1886FF9D0")]
		public static implicit operator Log(string path)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x3A11080", Offset = "0x3A0FE80", VA = "0x183A11080")]
		public void WMMLITSAFOT<a>(Func<a, object> a, [In] a args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x86FECA0", Offset = "0x86FDAA0", VA = "0x1886FECA0")]
		public void WMMLITSAFOT(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x86FEDB0", Offset = "0x86FDBB0", VA = "0x1886FEDB0")]
		public void WMMLITSAFOT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x86FEEB0", Offset = "0x86FDCB0", VA = "0x1886FEEB0")]
		public void WTZQCKRBQCM(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x3A0C8B0", Offset = "0x3A0B6B0", VA = "0x183A0C8B0")]
		public void OBZUBLLKSWN<p>(Func<p, object> a, [In] p args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x86FE490", Offset = "0x86FD290", VA = "0x1886FE490")]
		public void OBZUBLLKSWN(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x86FE390", Offset = "0x86FD190", VA = "0x1886FE390")]
		public void OBZUBLLKSWN(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3A123B0", Offset = "0x3A111B0", VA = "0x183A123B0")]
		public void YGSQKJNRLVE<s>(bool a, Func<s, object> b, [In] s args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x86FF1B0", Offset = "0x86FDFB0", VA = "0x1886FF1B0")]
		public void YGSQKJNRLVE(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x86FF2E0", Offset = "0x86FE0E0", VA = "0x1886FF2E0")]
		public void YGSQKJNRLVE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x3A12660", Offset = "0x3A11460", VA = "0x183A12660")]
		public void ZAKOHFVMPUT<be>(Func<be, object> a, [In] be args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x86FF3F0", Offset = "0x86FE1F0", VA = "0x1886FF3F0")]
		public void ZAKOHFVMPUT(Func<object> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x86FF4E0", Offset = "0x86FE2E0", VA = "0x1886FF4E0")]
		public void ZAKOHFVMPUT(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D0A0", Offset = "0x3A0BEA0", VA = "0x183A0D0A0")]
		public void PQQPLPANHBG<bh>(bool a, Func<bh, object> b, [In] bh args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x86FE5B0", Offset = "0x86FD3B0", VA = "0x1886FE5B0")]
		public void PQQPLPANHBG(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x86FE6B0", Offset = "0x86FD4B0", VA = "0x1886FE6B0")]
		public void PQQPLPANHBG(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x3A120B0", Offset = "0x3A10EB0", VA = "0x183A120B0")]
		public void WUPUXWOOCRD<bk>(bool a, Func<bk, object> b, [In] bk args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x86FF0B0", Offset = "0x86FDEB0", VA = "0x1886FF0B0")]
		public void WUPUXWOOCRD(bool a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x86FEFD0", Offset = "0x86FDDD0", VA = "0x1886FEFD0")]
		public void WUPUXWOOCRD(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86FE320", Offset = "0x86FD120", VA = "0x1886FE320")]
		public void OAVQRRYPPRE(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86FE2B0", Offset = "0x86FD0B0", VA = "0x1886FE2B0")]
		public void MTQKFJNAPWH(bool a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x3A0D5F0", Offset = "0x3A0C3F0", VA = "0x183A0D5F0")]
		public LogRangeScope RAUCHTZTBRG<cd>(Func<cd, object> a, [In] cd args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		public LogRangeScope NTOAIEQXLMP<ce>(Func<ce, object> a, [In] ce args)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86FE890", Offset = "0x86FD690", VA = "0x1886FE890")]
		public LogRangeScope RAUCHTZTBRG(Func<object> a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86FE790", Offset = "0x86FD590", VA = "0x1886FE790")]
		public LogRangeScope RAUCHTZTBRG(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x10F9FD0", Offset = "0x10F8DD0", VA = "0x1810F9FD0")]
		public LogRangeScope NTOAIEQXLMP(string a)
		{
			return default(LogRangeScope);
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86FE9B0", Offset = "0x86FD7B0", VA = "0x1886FE9B0")]
		public void RBWLYDDYEDC(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86FEA90", Offset = "0x86FD890", VA = "0x1886FEA90")]
		public void RBWLYDDYEDC(Exception a, Func<object> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x3A0DC40", Offset = "0x3A0CA40", VA = "0x183A0DC40")]
		public void RBWLYDDYEDC<cf>(Exception a, Func<cf, object> b, [In] cf args)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
		public void YWQCQBBVYGH([Optional][CallerMemberName] string name)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x86FE080", Offset = "0x86FCE80", VA = "0x1886FE080")]
		private string Format(object obj)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86FF610", Offset = "0x86FE410", VA = "0x1886FF610")]
		private static void ZWQVFJAXXXH(Exception a, StringBuilder b, int c = 0, int d = 5)
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
			public static readonly Log OMXVZSGOAIR;

			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public static readonly Log WLCENGKWHGE;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public static readonly Log CGJWXQTSAHI;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public static readonly Log QZGFUVXGAQD;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public static readonly Log YTUDXKSFVRJ;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public static readonly Log EQZJMXRTJYB;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public static readonly Log NXRZBQOVWYY;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public static readonly Log EKFFHTYZJLF;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public static readonly Log YPREXGTPOEK;

			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public static readonly Log MYLVKUNYCMZ;

			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public static readonly Log PVLBMWOMROD;

			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public static readonly Log JPAFDWOTRXJ;

			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public static readonly Log WNELLKZXVXD;

			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public static readonly Log JJYGRZITZWC;

			[Cpp2IlInjected.Token(Token = "0x4000011")]
			public static readonly Log FOLNNGSJLCA;

			[Cpp2IlInjected.Token(Token = "0x4000012")]
			public static readonly Log IXVPVZXGGOC;

			[Cpp2IlInjected.Token(Token = "0x4000013")]
			public static readonly Log CDIEOXPWWDE;

			[Cpp2IlInjected.Token(Token = "0x4000014")]
			public static readonly Log RFSXUMBVCCJ;

			[Cpp2IlInjected.Token(Token = "0x4000015")]
			public static readonly Log FVPVLONWGKO;

			[Cpp2IlInjected.Token(Token = "0x4000016")]
			public static readonly Log ZHVBJIGVKQG;

			[Cpp2IlInjected.Token(Token = "0x4000017")]
			public static readonly Log IMUHOAGHKLS;
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
					public static readonly Log ETDGEIJREEO;

					[Cpp2IlInjected.Token(Token = "0x4000022")]
					public static readonly Log MFMAJNRNLJC;
				}

				[Cpp2IlInjected.Token(Token = "0x400001A")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x400001B")]
				public static readonly Log JYRMVRQZFZQ;

				[Cpp2IlInjected.Token(Token = "0x400001C")]
				public static readonly Log BFBURDFRFXT;

				[Cpp2IlInjected.Token(Token = "0x400001D")]
				public static readonly Log DLRBGUBUBDT;

				[Cpp2IlInjected.Token(Token = "0x400001E")]
				public static readonly Log RJSLNMBCKXN;

				[Cpp2IlInjected.Token(Token = "0x400001F")]
				public static readonly Log ESXQMUGEKNP;

				[Cpp2IlInjected.Token(Token = "0x4000020")]
				public static readonly Log JAJXCXRTXFF;
			}

			[Cpp2IlInjected.Token(Token = "0x2000009")]
			public static class RoomieAI
			{
				[Cpp2IlInjected.Token(Token = "0x4000023")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x4000024")]
				public static readonly Log JYRMVRQZFZQ;

				[Cpp2IlInjected.Token(Token = "0x4000025")]
				public static readonly Log DLRBGUBUBDT;

				[Cpp2IlInjected.Token(Token = "0x4000026")]
				public static readonly Log RJSLNMBCKXN;

				[Cpp2IlInjected.Token(Token = "0x4000027")]
				public static readonly Log QXOCOYFRJUM;

				[Cpp2IlInjected.Token(Token = "0x4000028")]
				public static readonly Log TQTXURJLXZR;

				[Cpp2IlInjected.Token(Token = "0x4000029")]
				public static readonly Log HZIOVYNWBBD;
			}

			[Cpp2IlInjected.Token(Token = "0x200000A")]
			public static class OpenAI
			{
				[Cpp2IlInjected.Token(Token = "0x400002A")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x400002B")]
				public static readonly Log QVDBUTIPGTX;

				[Cpp2IlInjected.Token(Token = "0x400002C")]
				public static readonly Log KGIKWKIAPRE;
			}

			[Cpp2IlInjected.Token(Token = "0x200000B")]
			public static class GameAI
			{
				[Cpp2IlInjected.Token(Token = "0x200000C")]
				public static class RealtimeSession
				{
					[Cpp2IlInjected.Token(Token = "0x4000034")]
					private static readonly Log ETDGEIJREEO;

					[Cpp2IlInjected.Token(Token = "0x4000035")]
					public static readonly Log VOVEMGZBBPU;

					[Cpp2IlInjected.Token(Token = "0x4000036")]
					public static readonly Log VPALJNSYLBD;

					[Cpp2IlInjected.Token(Token = "0x4000037")]
					public static readonly Log VOKQRTLGITC;

					[Cpp2IlInjected.Token(Token = "0x4000038")]
					public static readonly Log VOPXPAFDSEL;

					[Cpp2IlInjected.Token(Token = "0x4000039")]
					public static readonly Log VPQGBIAQNJE;

					[Cpp2IlInjected.Token(Token = "0x400003A")]
					public static readonly Log VPVMYOUNWUN;

					[Cpp2IlInjected.Token(Token = "0x400003B")]
					public static readonly Log VPFSGUMVUMM;

					[Cpp2IlInjected.Token(Token = "0x400003C")]
					public static readonly Log VPKZEBGTDXV;

					[Cpp2IlInjected.Token(Token = "0x400003D")]
					public static readonly Log VQLHQJCFZCO;

					[Cpp2IlInjected.Token(Token = "0x400003E")]
					public static readonly Log VQQONPWDINX;
				}

				[Cpp2IlInjected.Token(Token = "0x200000D")]
				public static class RealtimeSessionDeltaEvents
				{
					[Cpp2IlInjected.Token(Token = "0x400003F")]
					private static readonly Log ETDGEIJREEO;

					[Cpp2IlInjected.Token(Token = "0x4000040")]
					public static readonly Log VOVEMGZBBPU;

					[Cpp2IlInjected.Token(Token = "0x4000041")]
					public static readonly Log VPALJNSYLBD;

					[Cpp2IlInjected.Token(Token = "0x4000042")]
					public static readonly Log VOKQRTLGITC;

					[Cpp2IlInjected.Token(Token = "0x4000043")]
					public static readonly Log VOPXPAFDSEL;

					[Cpp2IlInjected.Token(Token = "0x4000044")]
					public static readonly Log VPQGBIAQNJE;

					[Cpp2IlInjected.Token(Token = "0x4000045")]
					public static readonly Log VPVMYOUNWUN;

					[Cpp2IlInjected.Token(Token = "0x4000046")]
					public static readonly Log VPFSGUMVUMM;

					[Cpp2IlInjected.Token(Token = "0x4000047")]
					public static readonly Log VPKZEBGTDXV;

					[Cpp2IlInjected.Token(Token = "0x4000048")]
					public static readonly Log VQLHQJCFZCO;

					[Cpp2IlInjected.Token(Token = "0x4000049")]
					public static readonly Log VQQONPWDINX;
				}

				[Cpp2IlInjected.Token(Token = "0x200000E")]
				public static class Controller
				{
					[Cpp2IlInjected.Token(Token = "0x400004A")]
					private static readonly Log ETDGEIJREEO;

					[Cpp2IlInjected.Token(Token = "0x400004B")]
					public static readonly Log RBZFZZPQCIO;

					[Cpp2IlInjected.Token(Token = "0x400004C")]
					public static readonly Log ZOISXTRMLGG;

					[Cpp2IlInjected.Token(Token = "0x400004D")]
					public static readonly Log UBWGKGQXLXA;

					[Cpp2IlInjected.Token(Token = "0x400004E")]
					public static readonly Log GFZRPJUHPWG;
				}

				[Cpp2IlInjected.Token(Token = "0x400002D")]
				private static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x400002E")]
				public static readonly Log VSSCZUMCNND;

				[Cpp2IlInjected.Token(Token = "0x400002F")]
				public static readonly Log DOZARAVCPBN;

				[Cpp2IlInjected.Token(Token = "0x4000030")]
				public static readonly Log SORMLDXCYYI;

				[Cpp2IlInjected.Token(Token = "0x4000031")]
				public static readonly Log YJMKHOPXQHD;

				[Cpp2IlInjected.Token(Token = "0x4000032")]
				public static readonly Log CMVFJZXXDKQ;

				[Cpp2IlInjected.Token(Token = "0x4000033")]
				public static readonly Log CHNOOZOJXBK;
			}

			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			public static readonly Log XTQGDGFIQUW;
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class Art
		{
			[Cpp2IlInjected.Token(Token = "0x400004F")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000050")]
			public static readonly Log JSAYADPMKPY;
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class Audio
		{
			[Cpp2IlInjected.Token(Token = "0x4000051")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000052")]
			public static readonly Log ITMILKPCBAP;

			[Cpp2IlInjected.Token(Token = "0x4000053")]
			public static readonly Log ZNHXZTARECE;

			[Cpp2IlInjected.Token(Token = "0x4000054")]
			public static readonly Log XWAZIVSEMHI;

			[Cpp2IlInjected.Token(Token = "0x4000055")]
			public static readonly Log WGBGZAAHUFI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class Avatar
		{
			[Cpp2IlInjected.Token(Token = "0x4000056")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000057")]
			public static readonly Log PADSHPSJDOK;

			[Cpp2IlInjected.Token(Token = "0x4000058")]
			public static readonly Log QDTVEGWHTSF;

			[Cpp2IlInjected.Token(Token = "0x4000059")]
			public static readonly Log BNEAAOKZVQI;

			[Cpp2IlInjected.Token(Token = "0x400005A")]
			public static readonly Log TBUIYZUOALI;

			[Cpp2IlInjected.Token(Token = "0x400005B")]
			public static readonly Log OJIQJGSSRUL;

			[Cpp2IlInjected.Token(Token = "0x400005C")]
			public static readonly Log GHPAWVCVNTP;
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class Data
		{
			[Cpp2IlInjected.Token(Token = "0x400005D")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x400005E")]
			public static readonly Log FKAOICUKBVK;

			[Cpp2IlInjected.Token(Token = "0x400005F")]
			public static readonly Log IWKNTDESEDN;

			[Cpp2IlInjected.Token(Token = "0x4000060")]
			public static readonly Log GBKDVYHUEHJ;

			[Cpp2IlInjected.Token(Token = "0x4000061")]
			public static readonly Log ZRSNMJPDVFM;
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class DI
		{
			[Cpp2IlInjected.Token(Token = "0x4000062")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000063")]
			public static readonly Log DCDOJDJQQUU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class Economy
		{
			[Cpp2IlInjected.Token(Token = "0x4000064")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000065")]
			public static readonly Log KSDEDKIRTDC;

			[Cpp2IlInjected.Token(Token = "0x4000066")]
			public static readonly Log IXGVEHUJFVI;

			[Cpp2IlInjected.Token(Token = "0x4000067")]
			public static readonly Log TBUIYZUOALI;

			[Cpp2IlInjected.Token(Token = "0x4000068")]
			public static readonly Log CVLQRDVOCXK;

			[Cpp2IlInjected.Token(Token = "0x4000069")]
			public static readonly Log IMUHOAGHKLS;

			[Cpp2IlInjected.Token(Token = "0x400006A")]
			public static readonly Log WLUOHAOPBFS;

			[Cpp2IlInjected.Token(Token = "0x400006B")]
			public static readonly Log TPANTVFSALL;

			[Cpp2IlInjected.Token(Token = "0x400006C")]
			public static readonly Log CMVFJZXXDKQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class Engagement
		{
			[Cpp2IlInjected.Token(Token = "0x2000016")]
			public static class Discovery
			{
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x400007B")]
				public static readonly Log ZSSXNFMOHAY;
			}

			[Cpp2IlInjected.Token(Token = "0x400006D")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x400006E")]
			public static readonly Log WYTUJCUUGEF;

			[Cpp2IlInjected.Token(Token = "0x400006F")]
			public static readonly Log RKJYSIXZETQ;

			[Cpp2IlInjected.Token(Token = "0x4000070")]
			public static readonly Log UIBHWISBTOV;

			[Cpp2IlInjected.Token(Token = "0x4000071")]
			public static readonly Log TBUIYZUOALI;

			[Cpp2IlInjected.Token(Token = "0x4000072")]
			public static readonly Log UYKBPJNQZGG;

			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public static readonly Log JQCSMQMBQPC;

			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public static readonly Log JJRYPOMBSML;

			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public static readonly Log URTKTACTYGP;

			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public static readonly Log GZMWSRHTKTX;

			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public static readonly Log ZKPNKXBIBUP;

			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public static readonly Log ICURILJBDQR;

			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public static readonly Log CTVHQMXTBDD;
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class Experience
		{
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x400007D")]
			public static readonly Log YXMJWFBVTIQ;

			[Cpp2IlInjected.Token(Token = "0x400007E")]
			public static readonly Log TBUIYZUOALI;

			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public static readonly Log JUVPAADEGKE;

			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public static readonly Log QGSRHKFXCQR;

			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public static readonly Log ADJPGRSZFSA;

			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public static readonly Log KRYCVUKNNGT;

			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public static readonly Log DHJZKSFNPPM;

			[Cpp2IlInjected.Token(Token = "0x4000084")]
			public static readonly Log RPOTXAZMJOS;

			[Cpp2IlInjected.Token(Token = "0x4000085")]
			public static readonly Log WVVQFTNRDAQ;
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class Localization
		{
			[Cpp2IlInjected.Token(Token = "0x4000086")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000087")]
			public static readonly Log WONMZTSDYGX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class Logic
		{
			[Cpp2IlInjected.Token(Token = "0x200001A")]
			public static class CV1
			{
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				private static readonly Log OVFUZPNBJOW;
			}

			[Cpp2IlInjected.Token(Token = "0x200001B")]
			public static class CV2
			{
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x400008B")]
				public static readonly Log TGAFGFKOJVE;

				[Cpp2IlInjected.Token(Token = "0x400008C")]
				public static readonly Log YETCLBJIEHW;

				[Cpp2IlInjected.Token(Token = "0x400008D")]
				public static readonly Log QMDCWMEPJBS;

				[Cpp2IlInjected.Token(Token = "0x400008E")]
				public static readonly Log IZTMXHOMBIF;

				[Cpp2IlInjected.Token(Token = "0x400008F")]
				public static readonly Log GCTSRXRISRK;

				[Cpp2IlInjected.Token(Token = "0x4000090")]
				public static readonly Log VANFLYFKCJX;

				[Cpp2IlInjected.Token(Token = "0x4000091")]
				public static readonly Log QJLMNCACFJX;

				[Cpp2IlInjected.Token(Token = "0x4000092")]
				public static readonly Log WYBBJXREGWZ;

				[Cpp2IlInjected.Token(Token = "0x4000093")]
				public static readonly Log MYLVKUNYCMZ;

				[Cpp2IlInjected.Token(Token = "0x4000094")]
				public static readonly Log QXOCOYFRJUM;

				[Cpp2IlInjected.Token(Token = "0x4000095")]
				public static readonly Log WRIECIMFAGO;

				[Cpp2IlInjected.Token(Token = "0x4000096")]
				public static readonly Log DMYPNYVRMZX;

				[Cpp2IlInjected.Token(Token = "0x4000097")]
				public static readonly Log NKNEDPIWGGX;

				[Cpp2IlInjected.Token(Token = "0x4000098")]
				public static readonly Log EPWSAQFNDSA;

				[Cpp2IlInjected.Token(Token = "0x4000099")]
				public static readonly Log UWKLVPTQHDX;
			}

			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public static readonly Log ETDGEIJREEO;
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class Network
		{
			[Cpp2IlInjected.Token(Token = "0x200001D")]
			public static class RRNetworkLayer
			{
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				public static readonly Log ARNTBLSAZWE;

				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				public static readonly Log PZGJVHHKPYM;

				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				public static readonly Log RJSZVFLGOGG;

				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				public static readonly Log ZHEODOHUZUG;
			}

			[Cpp2IlInjected.Token(Token = "0x200001E")]
			public static class Photon
			{
				[Cpp2IlInjected.Token(Token = "0x200001F")]
				public static class Events
				{
					[Cpp2IlInjected.Token(Token = "0x40000B1")]
					private static readonly Log OVFUZPNBJOW;

					[Cpp2IlInjected.Token(Token = "0x40000B2")]
					public static readonly Log QDPMBZNBZZX;

					[Cpp2IlInjected.Token(Token = "0x40000B3")]
					public static readonly Log LGSPPJQXLWS;

					[Cpp2IlInjected.Token(Token = "0x40000B4")]
					public static readonly Log XGXZKBDNIQN;

					[Cpp2IlInjected.Token(Token = "0x40000B5")]
					public static readonly Log GDVYNAFZLLB;

					[Cpp2IlInjected.Token(Token = "0x40000B6")]
					public static readonly Log GRVCDNBQNWZ;

					[Cpp2IlInjected.Token(Token = "0x40000B7")]
					public static readonly Log RJSZVFLGOGG;

					[Cpp2IlInjected.Token(Token = "0x40000B8")]
					public static readonly Log KOWFGJTIGPD;
				}

				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				public static readonly Log ZSFLUNPCDWB;

				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				public static readonly Log TRRKHUNSDJK;

				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				public static readonly Log JWRKYRNXEVL;

				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				public static readonly Log KPNKKDJNREC;

				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				public static readonly Log PZGJVHHKPYM;

				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				public static readonly Log TTTDMXCNLDE;

				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				public static readonly Log QBGLWVOEKVT;

				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				public static readonly Log GMTICXPNAFC;

				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				public static readonly Log PRIQEPPFCWL;

				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				public static readonly Log MEZWDUQKXGS;
			}

			[Cpp2IlInjected.Token(Token = "0x400009A")]
			public static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x400009B")]
			public static readonly Log HDRBXOTCAUQ;

			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public static readonly Log EJLYUZXQTUP;

			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public static readonly Log HLKNVGQBZSQ;

			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public static readonly Log IOPTIHGNURE;

			[Cpp2IlInjected.Token(Token = "0x400009F")]
			public static readonly Log CFOLTGBAAMO;

			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public static readonly Log QIWWAQWNOCB;
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class Patching
		{
			[Cpp2IlInjected.Token(Token = "0x2000021")]
			public static class LogTransform
			{
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				public static readonly Log KKKVHKPRMMT;

				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				public static readonly Log ULSBQWMZZJA;

				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				public static readonly Log VOANOVKWBBE;

				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				public static readonly Log ZTQWDHXDIJW;

				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				public static readonly Log IXDKNEMDXJH;

				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				public static readonly Log QTZPMZSPJQH;

				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				public static readonly Log PAYTIITJVYK;

				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				public static readonly Log FRDDDMXJUZQ;

				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				public static readonly Log YYQINYKDDBJ;

				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				public static readonly Log OLTBVKQPWGJ;

				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				public static readonly Log IWDMKHULPLY;

				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				public static readonly Log ZVJAQSAJDXV;

				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				public static readonly Log VWCJGMUSTXT;
			}

			[Cpp2IlInjected.Token(Token = "0x2000022")]
			public static class LogLifecycle
			{
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				public static readonly Log XEYJFEQVMUB;

				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				public static readonly Log HGSCGDDYMNF;
			}

			[Cpp2IlInjected.Token(Token = "0x2000023")]
			public static class SODGEKZFVFO
			{
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				public static readonly Log FLGGBKUZDUB;

				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				public static readonly Log KEGCHKTFAFT;

				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				public static readonly Log LNYPIWYDGKY;
			}

			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public static readonly Log ETDGEIJREEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class Platform
		{
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public static readonly Log BERIAKTQINI;

			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public static readonly Log CNOTEIJDCDT;

			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public static readonly Log EIJCZSHCCLU;
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class Profiling
		{
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x40000D4")]
			public static readonly Log VIFPOVMYQHG;

			[Cpp2IlInjected.Token(Token = "0x40000D5")]
			public static readonly Log YTQANNFHBSW;

			[Cpp2IlInjected.Token(Token = "0x40000D6")]
			public static readonly Log UWKLVPTQHDX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class RecNet
		{
			[Cpp2IlInjected.Token(Token = "0x40000D7")]
			public static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x40000D8")]
			public static readonly Log MIIVYTDRMHI;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class Rendering
		{
			[Cpp2IlInjected.Token(Token = "0x40000D9")]
			public static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x40000DA")]
			public static readonly Log IAMZVTZNXVS;

			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			public static readonly Log DECLGBSTTTX;
		}

		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public static class RoomLoad
		{
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			public static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			public static readonly Log JUJLBCLLTOR;

			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			public static readonly Log ZQULXROMNSK;

			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			public static readonly Log DBIWXVQFJMA;

			[Cpp2IlInjected.Token(Token = "0x40000E0")]
			public static readonly Log VEURRDRAUAE;

			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public static readonly Log WSVDIVYXQDI;

			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public static readonly Log QZTJDCRWYWR;

			[Cpp2IlInjected.Token(Token = "0x40000E3")]
			public static readonly Log PIUTLRNWCOE;

			[Cpp2IlInjected.Token(Token = "0x40000E4")]
			public static readonly Log UPRUEKGCUCG;

			[Cpp2IlInjected.Token(Token = "0x40000E5")]
			public static readonly Log TBUIYZUOALI;

			[Cpp2IlInjected.Token(Token = "0x40000E6")]
			public static readonly Log XTUGDGAWQIT;

			[Cpp2IlInjected.Token(Token = "0x40000E7")]
			public static readonly Log XBWIUWVJWGT;

			[Cpp2IlInjected.Token(Token = "0x40000E8")]
			public static readonly Log TRUWOYVZIUL;

			[Cpp2IlInjected.Token(Token = "0x40000E9")]
			public static readonly Log UWRZUKYOCRL;

			[Cpp2IlInjected.Token(Token = "0x40000EA")]
			public static readonly Log PQAJKQWWILL;

			[Cpp2IlInjected.Token(Token = "0x40000EB")]
			public static readonly Log DGMMCFRANCP;

			[Cpp2IlInjected.Token(Token = "0x40000EC")]
			public static readonly Log JJMAMKJGDJI;

			[Cpp2IlInjected.Token(Token = "0x40000ED")]
			public static readonly Log ARPMKONMAKS;
		}

		[Cpp2IlInjected.Token(Token = "0x2000029")]
		public static class RRUI
		{
			[Cpp2IlInjected.Token(Token = "0x40000EE")]
			public static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x40000EF")]
			public static readonly Log QZGFUVXGAQD;

			[Cpp2IlInjected.Token(Token = "0x40000F0")]
			public static readonly Log KWDPRGZRNKU;

			[Cpp2IlInjected.Token(Token = "0x40000F1")]
			public static readonly Log RPIUBLAHXXD;

			[Cpp2IlInjected.Token(Token = "0x40000F2")]
			public static readonly Log XIFWJCJJUFO;
		}

		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public static class Hile
		{
			[Cpp2IlInjected.Token(Token = "0x40000F3")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x40000F4")]
			public static readonly Log YSPMWKJNNNL;
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public static class UGC
		{
			[Cpp2IlInjected.Token(Token = "0x40000F5")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x40000F6")]
			public static readonly Log NSBKXATQZVJ;

			[Cpp2IlInjected.Token(Token = "0x40000F7")]
			public static readonly Log CGRPUKXEDOU;

			[Cpp2IlInjected.Token(Token = "0x40000F8")]
			public static readonly Log OHAAXYYYKHT;

			[Cpp2IlInjected.Token(Token = "0x40000F9")]
			public static readonly Log QHSAAOSIWOU;

			[Cpp2IlInjected.Token(Token = "0x40000FA")]
			public static readonly Log CERZCZPQSSI;

			[Cpp2IlInjected.Token(Token = "0x40000FB")]
			public static readonly Log HEOTIEHAPMA;

			[Cpp2IlInjected.Token(Token = "0x40000FC")]
			public static readonly Log CYHVWRTETTW;

			[Cpp2IlInjected.Token(Token = "0x40000FD")]
			public static readonly Log ZSIZUQTFPVE;

			[Cpp2IlInjected.Token(Token = "0x40000FE")]
			public static readonly Log SDCBLCFFBFU;

			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public static readonly Log IFPAADLQBED;

			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public static readonly Log GMCPMQALWQQ;

			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public static readonly Log FFVCLFUEHFP;

			[Cpp2IlInjected.Token(Token = "0x4000102")]
			public static readonly Log CIKKEQRQTQO;

			[Cpp2IlInjected.Token(Token = "0x4000103")]
			public static readonly Log HVDIKCAHDXZ;

			[Cpp2IlInjected.Token(Token = "0x4000104")]
			public static readonly Log EQOSCJJFSUV;

			[Cpp2IlInjected.Token(Token = "0x4000105")]
			public static readonly Log HZIOVYNWBBD;
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class Tools
		{
			[Cpp2IlInjected.Token(Token = "0x200002D")]
			public static class FastMeshTools
			{
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				public static readonly Log ETDGEIJREEO;

				[Cpp2IlInjected.Token(Token = "0x4000111")]
				public static readonly Log YGIXAIGJFIY;

				[Cpp2IlInjected.Token(Token = "0x4000112")]
				public static readonly Log GDQRDLXWYZZ;
			}

			[Cpp2IlInjected.Token(Token = "0x4000106")]
			private static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x4000107")]
			public static readonly Log TYJLADLMGUU;

			[Cpp2IlInjected.Token(Token = "0x4000108")]
			public static readonly Log UKNQZXNOXZS;

			[Cpp2IlInjected.Token(Token = "0x4000109")]
			public static readonly Log RIXHWPBZWOX;

			[Cpp2IlInjected.Token(Token = "0x400010A")]
			public static readonly Log JRMAEGAYFKE;

			[Cpp2IlInjected.Token(Token = "0x400010B")]
			public static readonly Log AZKEVSEKAIE;

			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public static readonly Log CCIUQFXCGHO;

			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public static readonly Log YBDOYAAKQVO;

			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public static readonly Log NDNUIKOHGZY;

			[Cpp2IlInjected.Token(Token = "0x400010F")]
			public static readonly Log EZMMNGYAWJW;
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class TrustAndSafety
		{
			[Cpp2IlInjected.Token(Token = "0x4000113")]
			private static readonly Log OVFUZPNBJOW;

			[Cpp2IlInjected.Token(Token = "0x4000114")]
			public static readonly Log DDADYBHNHZU;
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class Utilities
		{
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			public static readonly Log ETDGEIJREEO;
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class EnvironmentGen
		{
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			public static readonly Log ETDGEIJREEO;

			[Cpp2IlInjected.Token(Token = "0x4000117")]
			public static readonly Log GSGYMGEXICU;

			[Cpp2IlInjected.Token(Token = "0x4000118")]
			public static readonly Log CHDLECWRDZC;
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class LiveOps
		{
			[Cpp2IlInjected.Token(Token = "0x4000119")]
			public static readonly Log ETDGEIJREEO;
		}
	}
}
namespace RecRoom.NoEngine.Logging
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public static class NPKZRMFZZKV
	{
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public class UYLANEJGGPN : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400011A")]
			private readonly (int index, bool enabled)[] EDVERJSGXGY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private List<(int index, bool enabled)> JFQDBVTEMKO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private bool MAHTDAXDNME;

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x87045E0", Offset = "0x87033E0", VA = "0x1887045E0")]
			internal UYLANEJGGPN((Log log, bool stateToSet)[] configuration)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x8704560", Offset = "0x8703360", VA = "0x188704560")]
			public IDisposable TRNSOAXNGRP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x87044B0", Offset = "0x87032B0", VA = "0x1887044B0", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public static class HMDNNUCDCIE
	{
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private static readonly Log OVFUZPNBJOW;

		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public static readonly Log IXOYYPEGNBW;

		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public static readonly Log CILPGTWAGDJ;

		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly Log TKJHYVGMXNI;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly Log EILPQETNFTW;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly Log IDKTKBMBHTC;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Log NXGOVMLPPRN;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public static readonly Log CGRPUKXEDOU;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly Log KGCPPFRAUYQ;

		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public static readonly Log IMJUHCSYGEU;

		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public static readonly Log WQVTBZLSZMK;

		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public static readonly Log XJXCSKVOGGL;

		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public static readonly Log ZEUAMDDCFSK;

		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public static readonly Log JXVYSLBQGRV;

		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public static readonly Log XGKFWZLUPNM;

		[Cpp2IlInjected.Token(Token = "0x400012C")]
		public static readonly Log HBOHCSGXMHA;

		[Cpp2IlInjected.Token(Token = "0x400012D")]
		public static readonly Log KYDDXVLTULT;

		[Cpp2IlInjected.Token(Token = "0x400012E")]
		public static readonly Log CERZCZPQSSI;

		[Cpp2IlInjected.Token(Token = "0x400012F")]
		public static readonly Log YKSLIQTDSOU;

		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public static readonly Log GASRQVDLAZX;

		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public static readonly Log GKHBNDCRBWI;

		[Cpp2IlInjected.Token(Token = "0x4000132")]
		public static readonly Log MYLVKUNYCMZ;

		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public static readonly Log SZFVQGUXEJX;

		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public static readonly Log LRGHSQPJTLW;

		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public static readonly Log XSFZEBXHMFP;

		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public static readonly Log QMAFFUGLXDD;

		[Cpp2IlInjected.Token(Token = "0x4000137")]
		public static readonly Log AIZYFENMHEV;

		[Cpp2IlInjected.Token(Token = "0x4000138")]
		public static readonly Log QFKOQDWCIEJ;

		[Cpp2IlInjected.Token(Token = "0x4000139")]
		public static readonly Log PJTRODEPLQS;

		[Cpp2IlInjected.Token(Token = "0x400013A")]
		public static readonly Log VCQHRXDWARZ;

		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public static readonly Log PDCFDEBOIEM;

		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public static readonly Log OOZLNWOQEDN;

		[Cpp2IlInjected.Token(Token = "0x400013D")]
		public static readonly Log KSUJHREZDYW;

		[Cpp2IlInjected.Token(Token = "0x400013E")]
		public static readonly Log JJFNAAIGIRN;

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		public static readonly Log UAUXEJDGJBU;

		[Cpp2IlInjected.Token(Token = "0x4000140")]
		public static readonly Log BFBURDFRFXT;

		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Log JXJHKWLTJWN;

		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public static readonly Log HOUUCOKEBXX;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Log ZVXDBYQEPHZ;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Log EWTYFFENXGY;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Log BZNBTZFTQHA;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly Log TBSDZRMVFJK;

		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public static readonly Log BLHLGSTYBBZ;

		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public static readonly Log PKYSPAPKQZQ;

		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public static readonly Log FCCLETRGMKH;

		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public static readonly Log QFFUYQXAZQX;

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public static readonly Log GYGOKEGSBFO;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Log RELCODHHSCP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public static Log UYKDBPFBJXP
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x86FB340", Offset = "0x86FA140", VA = "0x1886FB340")]
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
	internal class YYJGXIMPMLR
	{
		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public struct Scope : IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			private YYJGXIMPMLR parent;

			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0xECEFD0", Offset = "0xECDDD0", VA = "0x180ECEFD0")]
			public Scope(YYJGXIMPMLR parent)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0", Slot = "4")]
			public void Dispose()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		private readonly Stopwatch UMJYIUXDTOG;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x14CA840", Offset = "0x14C9640", VA = "0x1814CA840")]
		public Scope LBBLTQWBCVR()
		{
			return default(Scope);
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x87047C0", Offset = "0x87035C0", VA = "0x1887047C0")]
		public YYJGXIMPMLR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public interface CTEAUNRVZEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void WMMLITSAFOT(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void OBZUBLLKSWN(object a, [Optional] object b);

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void ZAKOHFVMPUT(object a, [Optional] object b);
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct LogRangeScope : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		private readonly Log log;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		private readonly object message;

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x86FCCD0", Offset = "0x86FBAD0", VA = "0x1886FCCD0")]
		public LogRangeScope(Log log, object message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x86FCC60", Offset = "0x86FBA60", VA = "0x1886FCC60", Slot = "4")]
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
		public abstract void PUOFOOQAOVA();

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0xAC4840", Offset = "0xAC3640", VA = "0x180AC4840")]
		protected LogRegistrationIndex()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	internal static class PIMDEPRWSYN
	{
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		private static List<LogRegistrationIndex> NTMZQVUWOLO;

		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private static bool GNADAOGCUOT;

		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private static readonly object NUUJXKMYQFM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public static List<LogRegistrationIndex> ZUWNHCPNHDS
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x87002A0", Offset = "0x86FF0A0", VA = "0x1887002A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x87002E0", Offset = "0x86FF0E0", VA = "0x1887002E0")]
		public static List<LogRegistrationIndex> Initialize()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8700450", Offset = "0x86FF250", VA = "0x188700450")]
		private static void UTDIEWIRHPQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8700660", Offset = "0x86FF460", VA = "0x188700660")]
		private static void VWCKBTABMOV(Assembly a)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public static class EYTKOKWQNME
	{
		[StructLayout((LayoutKind)0, Size = 1)]
		[Cpp2IlInjected.Token(Token = "0x200003C")]
		private struct Debug
		{
			[Cpp2IlInjected.Token(Token = "0x6000092")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
			public static Debug Create()
			{
				return default(Debug);
			}

			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
			public void JPSOIPGXBKU(int a, ParanoiaLevel b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000094")]
			[Cpp2IlInjected.Address(RVA = "0xB07AA0", Offset = "0xB068A0", VA = "0x180B07AA0")]
			public ParanoiaLevel DUTZCOJTYMY(int a)
			{
				return default(ParanoiaLevel);
			}

			[Cpp2IlInjected.Token(Token = "0x6000095")]
			[Cpp2IlInjected.Address(RVA = "0xABE8D0", Offset = "0xABD6D0", VA = "0x180ABE8D0")]
			public void Add()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000154")]
		public static Action EAMAFNHRRNH;

		[Cpp2IlInjected.Token(Token = "0x4000155")]
		private static readonly object QDNMMYEVZNH;

		[Cpp2IlInjected.Token(Token = "0x4000156")]
		private static readonly Dictionary<(int parentIndex, string token), int> LHXJKDWLUEH;

		[Cpp2IlInjected.Token(Token = "0x4000157")]
		private static readonly List<string> CRGECWQGZZZ;

		[Cpp2IlInjected.Token(Token = "0x4000158")]
		private static readonly List<int> OSQBMJWGWQO;

		[Cpp2IlInjected.Token(Token = "0x4000159")]
		private static readonly List<ulong> PQQKUEZDOEG;

		[Cpp2IlInjected.Token(Token = "0x400015A")]
		private static readonly List<ulong> FKHEQKKXXOP;

		[Cpp2IlInjected.Token(Token = "0x400015B")]
		private static readonly List<ulong> SFWCPSESDDY;

		[Cpp2IlInjected.Token(Token = "0x400015C")]
		private static readonly StringBuilder NWYGGIISPEW;

		[Cpp2IlInjected.Token(Token = "0x400015D")]
		private static readonly YYJGXIMPMLR SHJHFDTVCGA;

		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private static Debug BXOBFLJXQMG;

		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private static int KKBRRMARPFI;

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public static CTEAUNRVZEC YWDKRTOZIIP
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x86F90A0", Offset = "0x86F7EA0", VA = "0x1886F90A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x86F9470", Offset = "0x86F8270", VA = "0x1886F9470")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public static bool CLTCREYEASY
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x86F6E50", Offset = "0x86F5C50", VA = "0x1886F6E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public static bool TWYTDGOFBWC
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x86F6FC0", Offset = "0x86F5DC0", VA = "0x1886F6FC0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public static bool PFFXDDMUJFD
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x86F8310", Offset = "0x86F7110", VA = "0x1886F8310")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x86F9780", Offset = "0x86F8580", VA = "0x1886F9780")]
		static EYTKOKWQNME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x86F7010", Offset = "0x86F5E10", VA = "0x1886F7010")]
		public static void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x86F8470", Offset = "0x86F7270", VA = "0x1886F8470")]
		public static int PUOFOOQAOVA(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x86F83A0", Offset = "0x86F71A0", VA = "0x1886F83A0")]
		public static int PUOFOOQAOVA(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x86F8F10", Offset = "0x86F7D10", VA = "0x1886F8F10")]
		public static Log UYCPXVCHFQY(string a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x86F7F90", Offset = "0x86F6D90", VA = "0x1886F7F90")]
		public static void MYZLFUWDPSN(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x86F6A30", Offset = "0x86F5830", VA = "0x1886F6A30")]
		public static void BOXLPDUSKQC(Log a, List<Log> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x86F8F60", Offset = "0x86F7D60", VA = "0x1886F8F60")]
		public static bool VBQIFQZDXVK(Log a, Log b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x86F8150", Offset = "0x86F6F50", VA = "0x1886F8150")]
		public static int NAITXPETIJV(int a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x86F77B0", Offset = "0x86F65B0", VA = "0x1886F77B0")]
		public static string KHFYVAQVERI(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x86F8D70", Offset = "0x86F7B70", VA = "0x1886F8D70")]
		public static (string[], int[]) TPUOEKDSYYN()
		{
			return default((string[], int[]));
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x86F6EA0", Offset = "0x86F5CA0", VA = "0x1886F6EA0")]
		private static int GNECCRRHLID(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x86F90F0", Offset = "0x86F7EF0", VA = "0x1886F90F0")]
		private static int WSMETEUFHWJ(int a, string b, int c)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x86F7220", Offset = "0x86F6020", VA = "0x1886F7220")]
		private static int JAEYIMMWCUP(int a, string b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x86F94E0", Offset = "0x86F82E0", VA = "0x1886F94E0")]
		private static int YYIQWKVZFZK(string a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x86F95B0", Offset = "0x86F83B0", VA = "0x1886F95B0")]
		private static int YYIQWKVZFZK(string a, int b)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x86F68C0", Offset = "0x86F56C0", VA = "0x1886F68C0")]
		private static void BDWCDDBPKEL(int a, StringBuilder b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x86F8FE0", Offset = "0x86F7DE0", VA = "0x1886F8FE0")]
		public static bool VGWNINJQISP(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x86F6800", Offset = "0x86F5600", VA = "0x1886F6800")]
		public static bool AUXLCTUDFOS(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x86F8610", Offset = "0x86F7410", VA = "0x1886F8610")]
		public static void SWMKMGGZZCW(IEnumerable<(int index, bool enabled)> values, bool a = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x86F7A10", Offset = "0x86F6810", VA = "0x1886F7A10")]
		public static void KJRIDVYMYQN(IEnumerable<(int index, bool enabled)> values, List<(int index, bool enabled)> currentState)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x86F6DB0", Offset = "0x86F5BB0", VA = "0x1886F6DB0")]
		private static void DQDQHTJFVVY()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x86F91A0", Offset = "0x86F7FA0", VA = "0x1886F91A0")]
		private static void XAGUVHFWJFR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x86F7DD0", Offset = "0x86F6BD0", VA = "0x1886F7DD0")]
		private static bool KJWJPYJGSZI(int a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x86F8C20", Offset = "0x86F7A20", VA = "0x1886F8C20")]
		private static bool TNNDJHNZDKN(int a, bool b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x86F7F10", Offset = "0x86F6D10", VA = "0x1886F7F10")]
		private static bool LMWTKUAHZDP(List<ulong> a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x86F8B60", Offset = "0x86F7960", VA = "0x1886F8B60")]
		private static void Set(List<ulong> bitList, int bitIndex, bool enabled)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x86F82A0", Offset = "0x86F70A0", VA = "0x1886F82A0")]
		private static void NGQOMHDLZWX(List<ulong> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x86F6C40", Offset = "0x86F5A40", VA = "0x1886F6C40")]
		public static NPKZRMFZZKV.UYLANEJGGPN BQUGAOHVUYR((Log log, bool stateToSet)[] logGroupsAndValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x86F7770", Offset = "0x86F6570", VA = "0x1886F7770")]
		public static void JPSOIPGXBKU(int a, ParanoiaLevel b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x86F6E10", Offset = "0x86F5C10", VA = "0x1886F6E10")]
		public static ParanoiaLevel DUTZCOJTYMY(int a)
		{
			return default(ParanoiaLevel);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public enum ParanoiaLevel : byte
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		FastDebug,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		Debug,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		Paranoid,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		SuperParanoid,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
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
		[Cpp2IlInjected.Address(RVA = "0xAE81C0", Offset = "0xAE6FC0", VA = "0x180AE81C0")]
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
