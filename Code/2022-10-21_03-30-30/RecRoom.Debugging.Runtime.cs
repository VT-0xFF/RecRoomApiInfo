using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using Cpp2IlInjected;
using Mono.Math;
using Newtonsoft.Json;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal sealed class AKNLINBDIBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly Action JFAPEMANOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private CAINOHGEENI AFLBPDAOLOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private KEKAEOGEOIN NNECDKHELEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private CAINOHGEENI OBMGOBEJBNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private bool EDGGBIFPGIB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public CAINOHGEENI DCPAOJADKPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x2C84A70", Offset = "0x2C83870", VA = "0x182C84A70")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public CAINOHGEENI DMBIGKDADED
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x51D50F0", Offset = "0x51D3EF0", VA = "0x1851D50F0")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CAINOHGEENI LBGNKJFBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x32EE8F0", Offset = "0x32ED6F0", VA = "0x1832EE8F0")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DFBNHFGDKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84A9A0", Offset = "0x8497A0", VA = "0x18084A9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x51D51B0", Offset = "0x51D3FB0", VA = "0x1851D51B0")]
	public AKNLINBDIBN(Action OOABDOIIHEO, in CAINOHGEENI EAGMBCNAPKL, in CAINOHGEENI MGDPGAOLOLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x51D4F20", Offset = "0x51D3D20", VA = "0x1851D4F20")]
	public void ADEAGLHKJOJ(in CAINOHGEENI IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x51D4F40", Offset = "0x51D3D40", VA = "0x1851D4F40")]
	public void BIDADJANOHN(in CAINOHGEENI? GDFDIGMMCHM, in CAINOHGEENI? BCEJPCNJJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x51D4F30", Offset = "0x51D3D30", VA = "0x1851D4F30")]
	public void BGPCPLOHBDP(bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x51D5110", Offset = "0x51D3F10", VA = "0x1851D5110")]
	private void PNBJIDIKIBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CLAOGHOLJIM
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate object DCCKEPIHBPH();

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate object HHEHOIBADLM<T>(T KMLLOCJHKPB);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate object AIFKJPHEKHL<T>(in T KMLLOCJHKPB);

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private interface HIKLLHNLPNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000005")]
		CAINOHGEENI DFBEHHMBOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(Slot = "1")]
		void PNAJNCEFIKC(object GOJKMEMCPDE);

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(Slot = "2")]
		void PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA);
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	private readonly struct ENGDEIOPIKB : HIKLLHNLPNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public CAINOHGEENI DFBEHHMBOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x51DBFB0", Offset = "0x51DADB0", VA = "0x1851DBFB0", Slot = "4")]
			get
			{
				return default(CAINOHGEENI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x51DC010", Offset = "0x51DAE10", VA = "0x1851DC010", Slot = "5")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x51DC070", Offset = "0x51DAE70", VA = "0x1851DC070", Slot = "6")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private readonly struct PLHPMCGLKDO : HIKLLHNLPNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public CAINOHGEENI DFBEHHMBOCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x51E8110", Offset = "0x51E6F10", VA = "0x1851E8110", Slot = "4")]
			get
			{
				return default(CAINOHGEENI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x51E81E0", Offset = "0x51E6FE0", VA = "0x1851E81E0", Slot = "5")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x51E8170", Offset = "0x51E6F70", VA = "0x1851E8170", Slot = "6")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA)
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	private readonly struct BJMDNHLBBPE : HIKLLHNLPNC
	{
		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public CAINOHGEENI DFBEHHMBOCM
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x51D5680", Offset = "0x51D4480", VA = "0x1851D5680", Slot = "4")]
			get
			{
				return default(CAINOHGEENI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x51D5750", Offset = "0x51D4550", VA = "0x1851D5750", Slot = "5")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x51D56E0", Offset = "0x51D44E0", VA = "0x1851D56E0", Slot = "6")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	private static class EAEDBMLDEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x23C9A50", Offset = "0x23C8850", VA = "0x1823C9A50")]
		public static void PNAJNCEFIKC<T>(in T CFFPEBFKEAC, object GOJKMEMCPDE, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x23C9BB0", Offset = "0x23C89B0", VA = "0x1823C9BB0")]
		public static void PNAJNCEFIKC<T>(in T CFFPEBFKEAC, object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x23C9AF0", Offset = "0x23C88F0", VA = "0x1823C9AF0")]
		public static void PNAJNCEFIKC<T>(in T CFFPEBFKEAC, DCCKEPIHBPH GOJKMEMCPDE, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x23C9980", Offset = "0x23C8780", VA = "0x1823C9980")]
		public static void PNAJNCEFIKC<T>(in T CFFPEBFKEAC, DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x23C97E0", Offset = "0x23C85E0", VA = "0x1823C97E0")]
		public static void PNAJNCEFIKC<T, U>(in T CFFPEBFKEAC, HHEHOIBADLM<U> GOJKMEMCPDE, in U KMLLOCJHKPB, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x23C9620", Offset = "0x23C8420", VA = "0x1823C9620")]
		public static void PNAJNCEFIKC<T, U>(in T CFFPEBFKEAC, HHEHOIBADLM<U> GOJKMEMCPDE, in U KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x23C98B0", Offset = "0x23C86B0", VA = "0x1823C98B0")]
		public static void PNAJNCEFIKC<T, U>(in T CFFPEBFKEAC, AIFKJPHEKHL<U> GOJKMEMCPDE, in U KMLLOCJHKPB, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x23C9700", Offset = "0x23C8500", VA = "0x1823C9700")]
		public static void PNAJNCEFIKC<T, U>(in T CFFPEBFKEAC, AIFKJPHEKHL<U> GOJKMEMCPDE, in U KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, in CAINOHGEENI IDKBHBKJHPJ) where T : HIKLLHNLPNC
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	private interface KMPBCEMLADA<TConditionArg>
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void IIOELKEIHEG();

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "1")]
		bool CIHIHHGKICI(in TConditionArg KMLLOCJHKPB);

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(Slot = "2")]
		bool AANHKIFALNP(in TConditionArg KMLLOCJHKPB, bool ABDLDNIHKMK);
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	private readonly struct JAIECDOOGCJ : KMPBCEMLADA<((string, int), object)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private readonly Dictionary<(string File, int Line), object> BHJLGLIJACN;

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
		private JAIECDOOGCJ(Dictionary<(string File, int Line), object> NLPNDHNHACL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x51DFDB0", Offset = "0x51DEBB0", VA = "0x1851DFDB0")]
		public static JAIECDOOGCJ MIHDEIPKAKJ()
		{
			return default(JAIECDOOGCJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x51DFD60", Offset = "0x51DEB60", VA = "0x1851DFD60", Slot = "4")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x51DFC80", Offset = "0x51DEA80", VA = "0x1851DFC80")]
		public bool CIHIHHGKICI(in ((string File, int Line) Location, object Value) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DA0", Offset = "0x2CD5BA0", VA = "0x182CD6DA0")]
		public bool AANHKIFALNP(in ((string File, int Line) Location, object Value) KIHDPCDCOMG, bool ABDLDNIHKMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x51DFE20", Offset = "0x51DEC20", VA = "0x1851DFE20", Slot = "5")]
		private bool OBFLFJDIJJC(in ((string File, int Line) Location, object Value) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DA0", Offset = "0x2CD5BA0", VA = "0x182CD6DA0", Slot = "6")]
		private bool PACKGPGOPMF(in ((string File, int Line) Location, object Value) KMLLOCJHKPB, bool ABDLDNIHKMK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private readonly struct ILAMKHPDEMO : KMPBCEMLADA<(string, int)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly HashSet<(string File, int Line)> JBGEDCMDPHB;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
		private ILAMKHPDEMO(HashSet<(string File, int Line)> MKJLNGJPJKB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x51DF840", Offset = "0x51DE640", VA = "0x1851DF840")]
		public static ILAMKHPDEMO MIHDEIPKAKJ()
		{
			return default(ILAMKHPDEMO);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x51DF7F0", Offset = "0x51DE5F0", VA = "0x1851DF7F0", Slot = "4")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x51DF750", Offset = "0x51DE550", VA = "0x1851DF750")]
		public bool CIHIHHGKICI(in (string File, int Line) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DA0", Offset = "0x2CD5BA0", VA = "0x182CD6DA0")]
		public bool AANHKIFALNP(in (string File, int Line) KIHDPCDCOMG, bool ABDLDNIHKMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x51DF8B0", Offset = "0x51DE6B0", VA = "0x1851DF8B0", Slot = "5")]
		private bool NEOHBDJHOLP(in (string File, int Line) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DA0", Offset = "0x2CD5BA0", VA = "0x182CD6DA0", Slot = "6")]
		private bool KLNBJONPDHA(in (string File, int Line) KMLLOCJHKPB, bool ABDLDNIHKMK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private readonly struct PBNKFHKNHNL : KMPBCEMLADA<((string, int), long)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Dictionary<(string File, int Line), long> OKEJOPDOOKA;

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x51E7C90", Offset = "0x51E6A90", VA = "0x1851E7C90", Slot = "4")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
		private PBNKFHKNHNL(Dictionary<(string File, int Line), long> ECCILFCCPCA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x51E7CF0", Offset = "0x51E6AF0", VA = "0x1851E7CF0")]
		public static PBNKFHKNHNL MIHDEIPKAKJ()
		{
			return default(PBNKFHKNHNL);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x51E7B00", Offset = "0x51E6900", VA = "0x1851E7B00")]
		public bool CIHIHHGKICI(in ((string File, int Line) Location, long ThrottleMs) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DA0", Offset = "0x2CD5BA0", VA = "0x182CD6DA0")]
		public bool AANHKIFALNP(in ((string File, int Line) Location, long ThrottleMs) KMLLOCJHKPB, bool ABDLDNIHKMK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x51E7CE0", Offset = "0x51E6AE0", VA = "0x1851E7CE0", Slot = "5")]
		private bool MDFIHKBADEL(in ((string File, int Line) Location, long ThrottleMs) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x2CD6DA0", Offset = "0x2CD5BA0", VA = "0x182CD6DA0", Slot = "6")]
		private bool ENNODEDPOJA(in ((string File, int Line) Location, long ThrottleMs) KMLLOCJHKPB, bool ABDLDNIHKMK)
		{
			return default(bool);
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	private readonly struct MBAKIFOMGGO : KMPBCEMLADA<bool>
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x51E4AB0", Offset = "0x51E38B0", VA = "0x1851E4AB0")]
		public bool CIHIHHGKICI(in bool KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x51E4AA0", Offset = "0x51E38A0", VA = "0x1851E4AA0")]
		public bool AANHKIFALNP(in bool KMLLOCJHKPB, bool KIHDPCDCOMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x51E4AB0", Offset = "0x51E38B0", VA = "0x1851E4AB0", Slot = "5")]
		private bool FBGEGDNDODI(in bool KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x51E4AA0", Offset = "0x51E38A0", VA = "0x1851E4AA0", Slot = "6")]
		private bool EHKODGJIICO(in bool KMLLOCJHKPB, bool ABDLDNIHKMK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private readonly struct HEOJEMPEEJI : KMPBCEMLADA<((string, int), bool)>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private readonly MBAKIFOMGGO IDEHMBCOHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private readonly ILAMKHPDEMO KELHCFOGHOE;

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE660", Offset = "0x2CBD460", VA = "0x182CBE660")]
		private HEOJEMPEEJI(in ILAMKHPDEMO CMDKLBLBFIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x51DD600", Offset = "0x51DC400", VA = "0x1851DD600")]
		public static HEOJEMPEEJI MIHDEIPKAKJ()
		{
			return default(HEOJEMPEEJI);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x51DD5B0", Offset = "0x51DC3B0", VA = "0x1851DD5B0", Slot = "4")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x51DD590", Offset = "0x51DC390", VA = "0x1851DD590")]
		public bool CIHIHHGKICI(in ((string File, int Line) Location, bool Condition) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x1EC7A60", Offset = "0x1EC6860", VA = "0x181EC7A60")]
		public bool AANHKIFALNP(in ((string File, int Line) Location, bool Condition) KMLLOCJHKPB, bool KIHDPCDCOMG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x51DD590", Offset = "0x51DC390", VA = "0x1851DD590", Slot = "5")]
		private bool EDPECDIJNAP(in ((string File, int Line) Location, bool Condition) KMLLOCJHKPB)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x1EC7A60", Offset = "0x1EC6860", VA = "0x181EC7A60", Slot = "6")]
		private bool OIIHBEBGPLE(in ((string File, int Line) Location, bool Condition) KMLLOCJHKPB, bool ABDLDNIHKMK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	private readonly struct IDDOBCOPIAL<TDeps> where TDeps : HIKLLHNLPNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private readonly TDeps NKIPKAGLJMM;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x166C110", Offset = "0x166AF10", VA = "0x18166C110")]
		private bool OBAJINAIPHL(in CAINOHGEENI? IDKBHBKJHPJ, out CAINOHGEENI GAGKGBFAEGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x166C9A0", Offset = "0x166B7A0", VA = "0x18166C9A0")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x166BE60", Offset = "0x166AC60", VA = "0x18166BE60")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x166D2B0", Offset = "0x166C0B0", VA = "0x18166D2B0")]
		public void PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x166BD20", Offset = "0x166AB20", VA = "0x18166BD20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x166CEC0", Offset = "0x166BCC0", VA = "0x18166CEC0")]
		public void PNAJNCEFIKC(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x166BBC0", Offset = "0x166A9C0", VA = "0x18166BBC0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x166C330", Offset = "0x166B130", VA = "0x18166C330")]
		public void PNAJNCEFIKC(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x166BC20", Offset = "0x166AA20", VA = "0x18166BC20")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x26A4030", Offset = "0x26A2E30", VA = "0x1826A4030")]
		public void PNAJNCEFIKC<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x26A3E10", Offset = "0x26A2C10", VA = "0x1826A3E10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x26A3ED0", Offset = "0x26A2CD0", VA = "0x1826A3ED0")]
		public void PNAJNCEFIKC<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x26A3DF0", Offset = "0x26A2BF0", VA = "0x1826A3DF0")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x26A4030", Offset = "0x26A2E30", VA = "0x1826A4030")]
		public void PNAJNCEFIKC<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x26A3E10", Offset = "0x26A2C10", VA = "0x1826A3E10")]
		[Conditional("UNITY_EDITOR")]
		[Conditional("LOGGING_ENABLED")]
		public void JFDBCBPNEOB<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x26A3ED0", Offset = "0x26A2CD0", VA = "0x1826A3ED0")]
		public void PNAJNCEFIKC<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x26A3DF0", Offset = "0x26A2BF0", VA = "0x1826A3DF0")]
		[Conditional("LOGGING_ENABLED")]
		[Conditional("UNITY_EDITOR")]
		public void JFDBCBPNEOB<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	private readonly struct NJKMBFNMFBM<TDeps, TConditionDeps, TConditionArg> where TDeps : HIKLLHNLPNC where TConditionDeps : KMPBCEMLADA<TConditionArg>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private readonly TDeps NKIPKAGLJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		private readonly TConditionDeps AAOHNLGODEE;

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE640", Offset = "0x2CBD440", VA = "0x182CBE640")]
		public NJKMBFNMFBM(in TConditionDeps IIGGHOGGOIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC790", Offset = "0x2CBB590", VA = "0x182CBC790")]
		public void IIOELKEIHEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC260", Offset = "0x2CBB060", VA = "0x182CBC260")]
		private bool CMILKGFPNPH(in CAINOHGEENI? IDKBHBKJHPJ, in TConditionArg MKAAADGKGLJ, out CAINOHGEENI GAGKGBFAEGK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CBCB10", Offset = "0x2CBB910", VA = "0x182CBCB10")]
		public bool PNAJNCEFIKC(object GOJKMEMCPDE, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC8D0", Offset = "0x2CBB6D0", VA = "0x182CBC8D0")]
		public bool JFDBCBPNEOB(object GOJKMEMCPDE, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x2CBDB50", Offset = "0x2CBC950", VA = "0x182CBDB50")]
		public bool PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x26AE440", Offset = "0x26AD240", VA = "0x1826AE440")]
		public bool JFDBCBPNEOB(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x2CBE4A0", Offset = "0x2CBD2A0", VA = "0x182CBE4A0")]
		public bool PNAJNCEFIKC(DCCKEPIHBPH GOJKMEMCPDE, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC8D0", Offset = "0x2CBB6D0", VA = "0x182CBC8D0")]
		public bool JFDBCBPNEOB(DCCKEPIHBPH GOJKMEMCPDE, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x2CBC980", Offset = "0x2CBB780", VA = "0x182CBC980")]
		public bool PNAJNCEFIKC(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x26AE440", Offset = "0x26AD240", VA = "0x1826AE440")]
		public bool JFDBCBPNEOB(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x26AE950", Offset = "0x26AD750", VA = "0x1826AE950")]
		public bool PNAJNCEFIKC<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x26AE440", Offset = "0x26AD240", VA = "0x1826AE440")]
		public bool JFDBCBPNEOB<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x26AE710", Offset = "0x26AD510", VA = "0x1826AE710")]
		public bool PNAJNCEFIKC<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x26AE4C0", Offset = "0x26AD2C0", VA = "0x1826AE4C0")]
		public bool JFDBCBPNEOB<TMessageArg>(HHEHOIBADLM<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x26AE950", Offset = "0x26AD750", VA = "0x1826AE950")]
		public bool PNAJNCEFIKC<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x26AE440", Offset = "0x26AD240", VA = "0x1826AE440")]
		public bool JFDBCBPNEOB<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x26AE710", Offset = "0x26AD510", VA = "0x1826AE710")]
		public bool PNAJNCEFIKC<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x26AE4C0", Offset = "0x26AD2C0", VA = "0x1826AE4C0")]
		public bool JFDBCBPNEOB<TMessageArg>(AIFKJPHEKHL<TMessageArg> GOJKMEMCPDE, in TMessageArg KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, in TConditionArg MKAAADGKGLJ, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct NKCFCIMANPC : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		private readonly object GOJKMEMCPDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		private readonly CAINOHGEENI? KEMAOBJDDDI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		private bool CIHIHHGKICI
		{
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x51E7670", Offset = "0x51E6470", VA = "0x1851E7670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x51E77E0", Offset = "0x51E65E0", VA = "0x1851E77E0")]
		public NKCFCIMANPC(object GOJKMEMCPDE, in CAINOHGEENI? KEMAOBJDDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x51E7730", Offset = "0x51E6530", VA = "0x1851E7730", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct GKGCMCBHFOM : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
		public GKGCMCBHFOM(object GOJKMEMCPDE, in CAINOHGEENI? KEMAOBJDDDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public enum HMMDABOAOPP
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		Method = 1,
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		Params = 2,
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		Link = 4,
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		MiniLink = 8,
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		All = 7,
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		Default = 7
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class FEJFGFHGJIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public DCCKEPIHBPH message;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public FEJFGFHGJIL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x51DC0E0", Offset = "0x51DAEE0", VA = "0x1851DC0E0")]
		internal object <LogExceptionErrorString>b__0(Exception e)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly IDDOBCOPIAL<ENGDEIOPIKB> LLBFNHMMIAD;

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly NJKMBFNMFBM<ENGDEIOPIKB, JAIECDOOGCJ, ((string File, int Line) Location, object Value)> PMHGCMGPNBC;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly IDDOBCOPIAL<BJMDNHLBBPE> PMDAFDEAHDC;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly NJKMBFNMFBM<BJMDNHLBBPE, ILAMKHPDEMO, (string File, int Line)> PKEGNEBIOJJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	internal const string PADBJELLHHO = "START: ";

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	internal const string BMGOKONHGJH = "END: ";

	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static readonly NJKMBFNMFBM<ENGDEIOPIKB, PBNKFHKNHNL, ((string File, int Line) Location, long ThrottleMs)> DMNNGFNEMJO;

	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private static readonly IDDOBCOPIAL<PLHPMCGLKDO> GLNPAELCPNO;

	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private static readonly NJKMBFNMFBM<BJMDNHLBBPE, MBAKIFOMGGO, bool> NPPKIJDHJGG;

	[Cpp2IlInjected.Token(Token = "0x400000F")]
	private static readonly NJKMBFNMFBM<BJMDNHLBBPE, HEOJEMPEEJI, ((string File, int Line) Location, bool Condition)> ACKMNFFHMKO;

	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private static readonly Regex GCHDPLHGNFH;

	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private static readonly Regex NJEDBBEJFNP;

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x51DA2D0", Offset = "0x51D90D0", VA = "0x1851DA2D0")]
	public static void PNAJNCEFIKC(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x51DA250", Offset = "0x51D9050", VA = "0x1851DA250")]
	public static void PNAJNCEFIKC(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F330", Offset = "0x1F7E130", VA = "0x181F7F330")]
	public static void PNAJNCEFIKC<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F5C0", Offset = "0x1F7E3C0", VA = "0x181F7F5C0")]
	public static void PNAJNCEFIKC<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x51DA350", Offset = "0x51D9150", VA = "0x1851DA350")]
	public static void PNAJNCEFIKC(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x51DA3F0", Offset = "0x51D91F0", VA = "0x1851DA3F0")]
	public static void PNAJNCEFIKC(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F980", Offset = "0x1F7E780", VA = "0x181F7F980")]
	public static void PNAJNCEFIKC<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1F7F280", Offset = "0x1F7E080", VA = "0x181F7F280")]
	public static void PNAJNCEFIKC<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JFDBCBPNEOB<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E740", Offset = "0x1F7D540", VA = "0x181F7E740")]
	public static void KBJONHKFLAA<T>(object GOJKMEMCPDE, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E880", Offset = "0x1F7D680", VA = "0x181F7E880")]
	public static void KBJONHKFLAA<T>(DCCKEPIHBPH GOJKMEMCPDE, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E4C0", Offset = "0x1F7D2C0", VA = "0x181F7E4C0")]
	public static void KBJONHKFLAA<U, T>(HHEHOIBADLM<U> GOJKMEMCPDE, in U KMLLOCJHKPB, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E600", Offset = "0x1F7D400", VA = "0x181F7E600")]
	public static void KBJONHKFLAA<U, T>(AIFKJPHEKHL<U> GOJKMEMCPDE, in U KMLLOCJHKPB, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DE60", Offset = "0x1F7CC60", VA = "0x181F7DE60")]
	public static void BHDAGNEJINH<T>(object GOJKMEMCPDE, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DD20", Offset = "0x1F7CB20", VA = "0x181F7DD20")]
	public static void BHDAGNEJINH<T>(DCCKEPIHBPH GOJKMEMCPDE, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DBE0", Offset = "0x1F7C9E0", VA = "0x181F7DBE0")]
	public static void BHDAGNEJINH<U, T>(HHEHOIBADLM<U> GOJKMEMCPDE, in U KMLLOCJHKPB, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DAA0", Offset = "0x1F7C8A0", VA = "0x181F7DAA0")]
	public static void BHDAGNEJINH<U, T>(AIFKJPHEKHL<U> GOJKMEMCPDE, in U KMLLOCJHKPB, in T CCPIHKCBGHF, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x51D7900", Offset = "0x51D6700", VA = "0x1851D7900")]
	public static void BIAEOJAMGMN(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x51D77D0", Offset = "0x51D65D0", VA = "0x1851D77D0")]
	public static void BIAEOJAMGMN(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1F7DFA0", Offset = "0x1F7CDA0", VA = "0x181F7DFA0")]
	public static void BIAEOJAMGMN<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E040", Offset = "0x1F7CE40", VA = "0x181F7E040")]
	public static void BIAEOJAMGMN<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x51D7860", Offset = "0x51D6660", VA = "0x1851D7860")]
	public static void BIAEOJAMGMN(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x51D7990", Offset = "0x51D6790", VA = "0x1851D7990")]
	public static void BIAEOJAMGMN(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E0E0", Offset = "0x1F7CEE0", VA = "0x181F7E0E0")]
	public static void BIAEOJAMGMN<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E190", Offset = "0x1F7CF90", VA = "0x181F7E190")]
	public static void BIAEOJAMGMN<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LCIAGECPLHB<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x51D9E60", Offset = "0x51D8C60", VA = "0x1851D9E60")]
	public static void PJNLBMABADJ(Exception KLJBPOILBNM, [Optional] DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x51D9D20", Offset = "0x51D8B20", VA = "0x1851D9D20")]
	public static void PJNLBMABADJ(Exception KLJBPOILBNM, [Optional] DCCKEPIHBPH GOJKMEMCPDE, [Optional] UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x51D7FC0", Offset = "0x51D6DC0", VA = "0x1851D7FC0")]
	private static void GOIFFLNNPLK(Exception KLJBPOILBNM, StringBuilder NHDKHCEFNFI, int MOLGFCBNAJA = 0, int IMAEPENEFAA = 5)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x51D7C30", Offset = "0x51D6A30", VA = "0x1851D7C30")]
	public static void FFLBKMPAJHO(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x51D8810", Offset = "0x51D7610", VA = "0x1851D8810")]
	public static void JILADFPNCFP(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x51D85A0", Offset = "0x51D73A0", VA = "0x1851D85A0")]
	public static NKCFCIMANPC JDMAFJDBIBL(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(NKCFCIMANPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x51D86D0", Offset = "0x51D74D0", VA = "0x1851D86D0")]
	public static NKCFCIMANPC JDMAFJDBIBL(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(NKCFCIMANPC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E380", Offset = "0x1F7D180", VA = "0x181F7E380")]
	public static NKCFCIMANPC JDMAFJDBIBL<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(NKCFCIMANPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E240", Offset = "0x1F7D040", VA = "0x181F7E240")]
	public static NKCFCIMANPC JDMAFJDBIBL<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(NKCFCIMANPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x51D9830", Offset = "0x51D8630", VA = "0x1851D9830")]
	public static GKGCMCBHFOM MGINDNMGIEH(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(GKGCMCBHFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x51D9750", Offset = "0x51D8550", VA = "0x1851D9750")]
	public static GKGCMCBHFOM MGINDNMGIEH(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(GKGCMCBHFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7ED80", Offset = "0x1F7DB80", VA = "0x181F7ED80")]
	public static GKGCMCBHFOM MGINDNMGIEH<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(GKGCMCBHFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EC60", Offset = "0x1F7DA60", VA = "0x181F7EC60")]
	public static GKGCMCBHFOM MGINDNMGIEH<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(GKGCMCBHFOM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x51DA490", Offset = "0x51D9290", VA = "0x1851DA490")]
	public static void PNGAIPGEIDE(object GOJKMEMCPDE, long OHHPIJJJJHB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x51DA5D0", Offset = "0x51D93D0", VA = "0x1851DA5D0")]
	public static void PNGAIPGEIDE(DCCKEPIHBPH GOJKMEMCPDE, long OHHPIJJJJHB, [Optional] CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FD50", Offset = "0x1F7EB50", VA = "0x181F7FD50")]
	public static void PNGAIPGEIDE<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, long OHHPIJJJJHB, [Optional] CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x1F7FE90", Offset = "0x1F7EC90", VA = "0x181F7FE90")]
	public static void PNGAIPGEIDE<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, long OHHPIJJJJHB, [Optional] CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x51D7550", Offset = "0x51D6350", VA = "0x1851D7550")]
	public static void APCIHLPKOHE(object GOJKMEMCPDE, long OHHPIJJJJHB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x51D7690", Offset = "0x51D6490", VA = "0x1851D7690")]
	public static void APCIHLPKOHE(DCCKEPIHBPH GOJKMEMCPDE, long OHHPIJJJJHB, [Optional] CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D820", Offset = "0x1F7C620", VA = "0x181F7D820")]
	public static void APCIHLPKOHE<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, long OHHPIJJJJHB, [Optional] CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x1F7D960", Offset = "0x1F7C760", VA = "0x181F7D960")]
	public static void APCIHLPKOHE<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, long OHHPIJJJJHB, [Optional] CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x51D9620", Offset = "0x51D8420", VA = "0x1851D9620")]
	public static void LPHGJHOGKAA(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x51D94F0", Offset = "0x51D82F0", VA = "0x1851D94F0")]
	public static void LPHGJHOGKAA(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EA70", Offset = "0x1F7D870", VA = "0x181F7EA70")]
	public static void LPHGJHOGKAA<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EB10", Offset = "0x1F7D910", VA = "0x181F7EB10")]
	public static void LPHGJHOGKAA<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x51D9580", Offset = "0x51D8380", VA = "0x1851D9580")]
	public static void LPHGJHOGKAA(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x51D96B0", Offset = "0x51D84B0", VA = "0x1851D96B0")]
	public static void LPHGJHOGKAA(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x1F7E9C0", Offset = "0x1F7D7C0", VA = "0x181F7E9C0")]
	public static void LPHGJHOGKAA<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EBB0", Offset = "0x1F7D9B0", VA = "0x181F7EBB0")]
	public static void LPHGJHOGKAA<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD(object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD(DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD(object GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD(DCCKEPIHBPH GOJKMEMCPDE, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD<T>(HHEHOIBADLM<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void MBNNIDDPDHD<T>(AIFKJPHEKHL<T> GOJKMEMCPDE, in T KMLLOCJHKPB, UnityEngine.Object NAHJDDBGMOA, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x51D7B00", Offset = "0x51D6900", VA = "0x1851D7B00")]
	[Obsolete]
	public static KNNFEEOAAMH EGKFDIADIBB()
	{
		return default(KNNFEEOAAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x51D7F90", Offset = "0x51D6D90", VA = "0x1851D7F90")]
	[Obsolete]
	public static KNNFEEOAAMH GJLHJCJFJDH(in CAINOHGEENI IGJPNMBCJPK)
	{
		return default(KNNFEEOAAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x51D7AD0", Offset = "0x51D68D0", VA = "0x1851D7AD0")]
	public static KNNFEEOAAMH EBCPJADFOKE(in CAINOHGEENI IGJPNMBCJPK)
	{
		return default(KNNFEEOAAMH);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x51D7BB0", Offset = "0x51D69B0", VA = "0x1851D7BB0")]
	[Obsolete]
	public static PFECBFLOIAJ FAPLAGHINOO()
	{
		return default(PFECBFLOIAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x51D9320", Offset = "0x51D8120", VA = "0x1851D9320")]
	public static global::PMIHJAJMFBM<bool> LEDHNFAOAMN(bool IGJPNMBCJPK)
	{
		return default(global::PMIHJAJMFBM<bool>);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x51DA850", Offset = "0x51D9650", VA = "0x1851DA850")]
	[Obsolete]
	public static PFECBFLOIAJ POICHGGLOBB(in CAINOHGEENI IGJPNMBCJPK)
	{
		return default(PFECBFLOIAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x51D7B80", Offset = "0x51D6980", VA = "0x1851D7B80")]
	public static PFECBFLOIAJ EJIPOOAHPPA(in CAINOHGEENI IGJPNMBCJPK)
	{
		return default(PFECBFLOIAJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51D98E0", Offset = "0x51D86E0", VA = "0x1851D98E0")]
	[Obsolete]
	public static JDKDBFGGDKG MMONNHNHJFN()
	{
		return default(JDKDBFGGDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x51D99B0", Offset = "0x51D87B0", VA = "0x1851D99B0")]
	[Obsolete]
	public static JDKDBFGGDKG NOFKGGOPHCH(in CAINOHGEENI? IGJPNMBCJPK, [Optional] int? KIDBILABKCA)
	{
		return default(JDKDBFGGDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x51D7A30", Offset = "0x51D6830", VA = "0x1851D7A30")]
	public static JDKDBFGGDKG DGBHIIBBHDC(in CAINOHGEENI IGJPNMBCJPK, [Optional] int? KIDBILABKCA)
	{
		return default(JDKDBFGGDKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51DA710", Offset = "0x51D9510", VA = "0x1851DA710")]
	public static bool PNLFCMKNIKG(bool MKAAADGKGLJ, object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x51DA7B0", Offset = "0x51D95B0", VA = "0x1851DA7B0")]
	public static bool PNLFCMKNIKG(bool MKAAADGKGLJ, DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1F80080", Offset = "0x1F7EE80", VA = "0x181F80080")]
	public static bool PNLFCMKNIKG<TMessageArgs>(bool MKAAADGKGLJ, HHEHOIBADLM<TMessageArgs> GOJKMEMCPDE, in TMessageArgs KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x1F80130", Offset = "0x1F7EF30", VA = "0x181F80130")]
	public static bool PNLFCMKNIKG<TMessageArgs>(bool MKAAADGKGLJ, AIFKJPHEKHL<TMessageArgs> GOJKMEMCPDE, in TMessageArgs KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x51D9C80", Offset = "0x51D8A80", VA = "0x1851D9C80")]
	public static bool OOFAJLBMGCB(bool MKAAADGKGLJ, object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x51D9BE0", Offset = "0x51D89E0", VA = "0x1851D9BE0")]
	public static bool OOFAJLBMGCB(bool MKAAADGKGLJ, DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EEA0", Offset = "0x1F7DCA0", VA = "0x181F7EEA0")]
	public static bool OOFAJLBMGCB<TMessageArgs>(bool MKAAADGKGLJ, HHEHOIBADLM<TMessageArgs> GOJKMEMCPDE, in TMessageArgs KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x1F7EF50", Offset = "0x1F7DD50", VA = "0x181F7EF50")]
	public static bool OOFAJLBMGCB<TMessageArgs>(bool MKAAADGKGLJ, AIFKJPHEKHL<TMessageArgs> GOJKMEMCPDE, in TMessageArgs KMLLOCJHKPB, [Optional] in CAINOHGEENI? IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x51DA110", Offset = "0x51D8F10", VA = "0x1851DA110")]
	public static bool PMKPFJNCJID(bool MKAAADGKGLJ, object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x51D9FD0", Offset = "0x51D8DD0", VA = "0x1851D9FD0")]
	public static bool PMKPFJNCJID(bool MKAAADGKGLJ, DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x51D7E50", Offset = "0x51D6C50", VA = "0x1851D7E50")]
	public static bool FGPPJKHKGDN(bool MKAAADGKGLJ, object GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x51D7D10", Offset = "0x51D6B10", VA = "0x1851D7D10")]
	public static bool FGPPJKHKGDN(bool MKAAADGKGLJ, DCCKEPIHBPH GOJKMEMCPDE, [Optional] in CAINOHGEENI? IDKBHBKJHPJ, [CallerFilePath] string FAEGOFALDDI = "", [CallerLineNumber] int MPAIPIECGOI = 0)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x51D83F0", Offset = "0x51D71F0", VA = "0x1851D83F0")]
	public static bool HKOODFIGPOA(in CAINOHGEENI IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x51D99E0", Offset = "0x51D87E0", VA = "0x1851D99E0")]
	private static bool OBAJINAIPHL(in CAINOHGEENI? IDKBHBKJHPJ, in CAINOHGEENI IAIHAFMDHBP, out CAINOHGEENI GAGKGBFAEGK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x51D8990", Offset = "0x51D7790", VA = "0x1851D8990")]
	private static object KCPKNEMHAIG(object GOJKMEMCPDE, in CAINOHGEENI IDKBHBKJHPJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x51D84B0", Offset = "0x51D72B0", VA = "0x1851D84B0")]
	public static void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x51D8390", Offset = "0x51D7190", VA = "0x1851D8390")]
	public static void HEEDEAIKGOP(Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x51D8AF0", Offset = "0x51D78F0", VA = "0x1851D8AF0")]
	public static string KEPICFFIEOA(string AJPJIDCOHMD, HMMDABOAOPP IDKBHBKJHPJ = HMMDABOAOPP.All)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E71E0", Offset = "0x6E5FE0", VA = "0x1806E71E0")]
	public static string JNOBMFBEIMH(string BLPKMOHCJBB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x51D88F0", Offset = "0x51D76F0", VA = "0x1851D88F0")]
	public static string JNOBMFBEIMH(string BLPKMOHCJBB, [Optional] int? EIDAJENCIEO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LDPEAOACIME
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	internal static readonly AKNLINBDIBN NPBLFLIFMJD;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	internal static readonly AKNLINBDIBN FGFNEGNMBPA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	internal static readonly AKNLINBDIBN IOGFGKAKAEF;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private static CAINOHGEENI LOHIELEJHJP;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private static readonly ICKLJMMBPPF GJPCFLBACFO;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	internal static bool KPNDPNALMJE;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	internal static bool NMHIFBINAKE;

	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static int PGBFLEMABMN;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static JJMCJACAMHO NEMOCPGCLNC;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static ANFMJPHICPN CPAKONANJJE;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool CHHNBKADPCA;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public static JsonConverter[] NJLKDBMFLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x51E23B0", Offset = "0x51E11B0", VA = "0x1851E23B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x51E2270", Offset = "0x51E1070", VA = "0x1851E2270")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static CAINOHGEENI EHIDCKAEHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x51E22E0", Offset = "0x51E10E0", VA = "0x1851E22E0")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static CAINOHGEENI EELEGJPMMKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x51E27C0", Offset = "0x51E15C0", VA = "0x1851E27C0")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	internal static CAINOHGEENI HDFIJBHHDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x51E24D0", Offset = "0x51E12D0", VA = "0x1851E24D0")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static CAINOHGEENI.EFIKJKOCBHF OHKHCCJKBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x51E38B0", Offset = "0x51E26B0", VA = "0x1851E38B0")]
		[CompilerGenerated]
		get
		{
			return default(CAINOHGEENI.EFIKJKOCBHF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x51E37D0", Offset = "0x51E25D0", VA = "0x1851E37D0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public static DGDEBGLGOAP HOFBJCFHDBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x51E2E50", Offset = "0x51E1C50", VA = "0x1851E2E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x51E31D0", Offset = "0x51E1FD0", VA = "0x1851E31D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public static bool MDJBGFAOLFM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x51E2350", Offset = "0x51E1150", VA = "0x1851E2350")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x51E3BC0", Offset = "0x51E29C0", VA = "0x1851E3BC0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public static bool BCBAKFMIACD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x51E32B0", Offset = "0x51E20B0", VA = "0x1851E32B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public static bool JLPBGBGNLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x51E3C20", Offset = "0x51E2A20", VA = "0x1851E3C20")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x51E2830", Offset = "0x51E1630", VA = "0x1851E2830")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public static int BBNFEALIDEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x51E2760", Offset = "0x51E1560", VA = "0x1851E2760")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x51E2690", Offset = "0x51E1490", VA = "0x1851E2690")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	internal static double FNINFNNEIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x51E2DF0", Offset = "0x51E1BF0", VA = "0x1851E2DF0")]
		[CompilerGenerated]
		get
		{
			return default(double);
		}
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x51E26F0", Offset = "0x51E14F0", VA = "0x1851E26F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public static double ALKLJLKEADC
	{
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x51E2530", Offset = "0x51E1330", VA = "0x1851E2530")]
		get
		{
			return default(double);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public static DFIFEAMHHFH EMBCDOIHFJG
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x51E2410", Offset = "0x51E1210", VA = "0x1851E2410")]
		[CompilerGenerated]
		get
		{
			return default(DFIFEAMHHFH);
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x51E34E0", Offset = "0x51E22E0", VA = "0x1851E34E0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public static bool HBOANABDKHA
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x51E2470", Offset = "0x51E1270", VA = "0x1851E2470")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x51E2210", Offset = "0x51E1010", VA = "0x1851E2210")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x51E2610", Offset = "0x51E1410", VA = "0x1851E2610")]
	public static void DJFAKLGPPCN(in CAINOHGEENI IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x51E39F0", Offset = "0x51E27F0", VA = "0x1851E39F0")]
	public static void NKAMKFADIDP(bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x51E3B70", Offset = "0x51E2970", VA = "0x1851E3B70")]
	private static void OAIMFADMGHL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x51E3350", Offset = "0x51E2150", VA = "0x1851E3350")]
	public static void JPKMHFLHGAA(in CAINOHGEENI IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x51E3830", Offset = "0x51E2630", VA = "0x1851E3830")]
	public static void MJBLPENMNNE(bool IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x51E2F50", Offset = "0x51E1D50", VA = "0x1851E2F50")]
	private static void GLMOFBFCJIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x51E3540", Offset = "0x51E2340", VA = "0x1851E3540")]
	private static void LNOFFGDKGEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x51E2EB0", Offset = "0x51E1CB0", VA = "0x1851E2EB0")]
	[Conditional("UNITY_EDITOR")]
	public static void GGLHGBKHCGB(CAINOHGEENI.EFIKJKOCBHF FJDLENJCEEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x51E3760", Offset = "0x51E2560", VA = "0x1851E3760")]
	public static void MECCBMFCMFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51E28A0", Offset = "0x51E16A0", VA = "0x1851E28A0")]
	private static void FHDCIBBDKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x51E3910", Offset = "0x51E2710", VA = "0x1851E3910")]
	internal static int NFGEHDACBHM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x51E3240", Offset = "0x51E2040", VA = "0x1851E3240")]
	public static void JGCECJKDAKA(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x51E2FA0", Offset = "0x51E1DA0", VA = "0x1851E2FA0")]
	public static void HBBPBNAALCD(int? LJLKNNLDMOM, int? EPOAMOEJPAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x51E2AA0", Offset = "0x51E18A0", VA = "0x1851E2AA0")]
	public static void FMNNKHBONAP(ANFMJPHICPN LEOCGNJBNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x51E3450", Offset = "0x51E2250", VA = "0x1851E3450")]
	internal static void KICEBGKAKKP(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x51E33D0", Offset = "0x51E21D0", VA = "0x1851E33D0")]
	public static void KFBMJFPFHDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x51E3970", Offset = "0x51E2770", VA = "0x1851E3970")]
	public static string NJJILHGNKCI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x51E3A70", Offset = "0x51E2870", VA = "0x1851E3A70")]
	public static byte[] NNJGDHMMILP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
internal sealed class OAEGCOKHBGG : DGDEBGLGOAP
{
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	private sealed class BGHIBBPDIEJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public BGHIBBPDIEJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AFPLMHOHDIB.KAFGNHEEOGM GBMIKJPFBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x657010", Offset = "0x655E10", VA = "0x180657010", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
	public void LLFDBGDMPGK(float DAAHFAHDCGP, int KFFOAODFIOJ, int AKJPDJKMNHK, int KCJCBFMAMLE, string NMFDDLNPOLH, string CFNIOHDEMGB, int ONGFLJACDAB, int MOEFKAMIJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x51E78A0", Offset = "0x51E66A0", VA = "0x1851E78A0", Slot = "5")]
	public IDisposable MBDNEBKCMLK(float KJLGCDLLEOE, Action<float> JEGEKBCLIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x51E78F0", Offset = "0x51E66F0", VA = "0x1851E78F0")]
	public OAEGCOKHBGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class DDIKCDOLAPK
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public static readonly MMAMKOAAADE.OOFHDJMCFOG BDGFMHKIBHN;

	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public static readonly MMAMKOAAADE.OOFHDJMCFOG MOJBOOPMPGD;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public static readonly MMAMKOAAADE.OOFHDJMCFOG DPFHMKJIBFC;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public static readonly MMAMKOAAADE.LGHLPNAPDOB GGBBOOEOKFN;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly MMAMKOAAADE.ODFLCNNHIEK CKIFGEPEMKG;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public static readonly MMAMKOAAADE.IENDLNGAIOC JKFJBKDKDBD;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly LBPNCGGKOMJ CAHJEJFLBEA;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public static readonly GFABDEDMGCD FPJJHBAEKPD;

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x51DAD00", Offset = "0x51D9B00", VA = "0x1851DAD00")]
	public static void EPAOPGECDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x51DB160", Offset = "0x51D9F60", VA = "0x1851DB160")]
	public static void PNAJNCEFIKC(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x51DAF20", Offset = "0x51D9D20", VA = "0x1851DAF20")]
	public static void LPHGJHOGKAA(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x51DACA0", Offset = "0x51D9AA0", VA = "0x1851DACA0")]
	public static void BIAEOJAMGMN(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x51DAEC0", Offset = "0x51D9CC0", VA = "0x1851DAEC0")]
	public static void HEEDEAIKGOP(Exception KLJBPOILBNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void LNBMDOJAMGL(string BEMAPDNKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830")]
	public static void JHABPKKIPBF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x51DAF80", Offset = "0x51D9D80", VA = "0x1851DAF80")]
	public static string MJEDMENINNA(object CCPIHKCBGHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x51DB030", Offset = "0x51D9E30", VA = "0x1851DB030")]
	public static long MJJPOLAKDEI()
	{
		return default(long);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public interface DGDEBGLGOAP
{
	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AFPLMHOHDIB.KAFGNHEEOGM GBMIKJPFBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLFDBGDMPGK(float DAAHFAHDCGP, int KFFOAODFIOJ, int AKJPDJKMNHK, int KCJCBFMAMLE, string NMFDDLNPOLH, string CFNIOHDEMGB, int ONGFLJACDAB, int MOEFKAMIJKP);

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IDisposable MBDNEBKCMLK(float KJLGCDLLEOE, Action<float> JEGEKBCLIDO);
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public sealed class JJMCJACAMHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private readonly Dictionary<int, int> KEDDPLAGGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private int OELLHGEGFDB;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int OBFGLEBPMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x688A00", Offset = "0x687800", VA = "0x180688A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x51E1080", Offset = "0x51DFE80", VA = "0x1851E1080")]
	public JJMCJACAMHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x51E0FF0", Offset = "0x51DFDF0", VA = "0x1851E0FF0")]
	public JJMCJACAMHO(int HBENDLEGGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x51E0F10", Offset = "0x51DFD10", VA = "0x1851E0F10")]
	public void JOEJBFPKOLJ(int HBENDLEGGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51E0E00", Offset = "0x51DFC00", VA = "0x1851E0E00")]
	public void HHAFJHIMMLC(int HBENDLEGGGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x51E0CA0", Offset = "0x51DFAA0", VA = "0x1851E0CA0")]
	private int BCHIDKFAFPB()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NDPBBIFEKPF
{
	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public static JsonConverter IECKMFCALBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x51E7290", Offset = "0x51E6090", VA = "0x1851E7290")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static JsonConverter JAONMOOIDCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x51E7350", Offset = "0x51E6150", VA = "0x1851E7350")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public static JsonConverter BMIOOHNKCCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x51E73B0", Offset = "0x51E61B0", VA = "0x1851E73B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public static JsonConverter HAFOELKOFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x51E72F0", Offset = "0x51E60F0", VA = "0x1851E72F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GHECNHNKAKB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	private struct JDDBOLIGAKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public WeakReference NAFOJMDADBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int CJINCCPPDEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int LNDKGDCMJBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public string CKOMIBKPPBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct BBAOMELPIMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int MIHAHHDJCME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int IGMFMEAPLNF;

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool BPMHBEBFNMK
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x51D5670", Offset = "0x51D4470", VA = "0x1851D5670")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public string ABFIOECIPIA
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x51D5490", Offset = "0x51D4290", VA = "0x1851D5490")]
			get
			{
				return null;
			}
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal const int ICHHEEJCCNH = 1000000;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	internal const int MNAKALLENDJ = 200;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	private static readonly List<JDDBOLIGAKE> CCPHJCCANLA;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	private static readonly List<JDDBOLIGAKE> JJPIKJBFPMB;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	private static readonly List<JDDBOLIGAKE> CJJNFKIFKLO;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private static readonly List<JDDBOLIGAKE> HHIFPHANKDN;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private static readonly List<JDDBOLIGAKE> GDCKIGLGDKI;

	[Cpp2IlInjected.Token(Token = "0x4000052")]
	private static string PAIJDGDGKNK;

	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private static bool CEOGCMCBEHJ;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x51DCB00", Offset = "0x51DB900", VA = "0x1851DCB00")]
	public static void EJCGBCFCFCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x51DCBE0", Offset = "0x51DB9E0", VA = "0x1851DCBE0")]
	[Conditional("LEAKDETECTOR_ENABLED")]
	public static void HEFJCCLOLGO(object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x51DCF10", Offset = "0x51DBD10", VA = "0x1851DCF10")]
	public static void NBNLDLDBOAC([Optional] string BEMAPDNKPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x51DC520", Offset = "0x51DB320", VA = "0x1851DC520")]
	public static BBAOMELPIMA CIHIEHNLHCO()
	{
		return default(BBAOMELPIMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x51DCE80", Offset = "0x51DBC80", VA = "0x1851DCE80")]
	private static bool IKDGPDPCNPA(this object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x51DD140", Offset = "0x51DBF40", VA = "0x1851DD140")]
	private static void NLEMPGPMKDA(List<JDDBOLIGAKE> NHDBGJJFMKA, List<JDDBOLIGAKE> JKEMBMMMMLG, string NFAIMPDODFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x51DC7A0", Offset = "0x51DB5A0", VA = "0x1851DC7A0")]
	private static string DNOLHOHDBPC(JDDBOLIGAKE GDCPKDNOEGM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CAINOHGEENI : IEquatable<CAINOHGEENI>
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum EFIKJKOCBHF
	{
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FormatUnityEngineDebugLogCalls = 2,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		ShowPstTimeNow = 4,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		ShowFrame = 8,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		ShowTimeSinceStartup = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		ShowLogType = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		ShowLogFlags = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		All = -1
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	internal readonly DDIPNAHAPGP IDKBHBKJHPJ;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly CAINOHGEENI PNHMHDPFJKE;

	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly CAINOHGEENI GODJDHGNMJJ;

	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly CAINOHGEENI IAOCEPDLGOD;

	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public static readonly CAINOHGEENI PADILNDKKJP;

	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public static readonly CAINOHGEENI OCIGIOMOMIC;

	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public static readonly CAINOHGEENI CGBJOCCHCMK;

	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly CAINOHGEENI EAGELEFLMHC;

	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public static readonly CAINOHGEENI GAILMGFDDBD;

	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public static readonly CAINOHGEENI BAGGIDFJGBA;

	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public static readonly CAINOHGEENI OHJLDKPLGCJ;

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly CAINOHGEENI JMDLCAODOCE;

	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly CAINOHGEENI NOGFHGNIIJI;

	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly CAINOHGEENI HODIGNDEBCP;

	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public static readonly CAINOHGEENI ACAOOGAHKEL;

	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly CAINOHGEENI OMDOLFNOENJ;

	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public static readonly CAINOHGEENI NKHNPMCOFJO;

	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly CAINOHGEENI IAANHKEADAA;

	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public static readonly CAINOHGEENI KGCLEKIFMPE;

	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly CAINOHGEENI HLFIIIGKOFG;

	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public static readonly CAINOHGEENI OICAKGMILPB;

	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly CAINOHGEENI LAJMFEJMNIM;

	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public static readonly CAINOHGEENI CLANILLAAEJ;

	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly CAINOHGEENI HKKMNBHMHOO;

	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public static readonly CAINOHGEENI EHCJJMLELNF;

	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly CAINOHGEENI AGAIMCGHNAH;

	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public static readonly CAINOHGEENI AJADMBNLIDE;

	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly CAINOHGEENI LHIIJGHBPOM;

	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public static readonly CAINOHGEENI GKKAALELEGL;

	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly CAINOHGEENI KDIGHKFKEIK;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public static readonly CAINOHGEENI HJFAGCCLNLL;

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly CAINOHGEENI GHCOMFPKPDC;

	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public static readonly CAINOHGEENI JLBKBOPFAHG;

	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly CAINOHGEENI GMPDPCAJCLM;

	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public static readonly CAINOHGEENI LPCPPCPMILA;

	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly CAINOHGEENI JCGCGNPDDLC;

	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public static readonly CAINOHGEENI BECJGHCKHIC;

	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly CAINOHGEENI CKNBFJDNACF;

	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public static readonly CAINOHGEENI FCBDKGMEDHF;

	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly CAINOHGEENI KDJHGCHNMAO;

	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public static readonly CAINOHGEENI EGECOAGIIOJ;

	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly CAINOHGEENI DIMFIIEBKPB;

	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public static readonly CAINOHGEENI FCOELCEKFCA;

	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly CAINOHGEENI HJFCMJCJOCC;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public static readonly CAINOHGEENI NIELLHPGJNA;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public static readonly CAINOHGEENI FFHLNFCGFOA;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public static readonly CAINOHGEENI KKFKFLPEMDJ;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public static readonly CAINOHGEENI KDCKDOHIAIO;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public static readonly CAINOHGEENI ODDFLPNBJGM;

	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly CAINOHGEENI FAMGMCAOJKM;

	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public static readonly CAINOHGEENI IMLPLNILBHO;

	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly CAINOHGEENI DPOLGLECBFB;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly CAINOHGEENI FGDJNABNEJB;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly CAINOHGEENI HKALBFKHOJE;

	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public static readonly CAINOHGEENI KOIBLJNLPCI;

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static readonly CAINOHGEENI NMDADEMIFOH;

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public static readonly CAINOHGEENI OPBCCNPLJFP;

	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public static readonly CAINOHGEENI FOBBLKPOGAD;

	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public static readonly CAINOHGEENI FGKNDIECKPL;

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	internal static readonly CAINOHGEENI NJKGPGIFKGO;

	[Cpp2IlInjected.Token(Token = "0x4000096")]
	internal static readonly CAINOHGEENI DBJPMGMBDLI;

	[Cpp2IlInjected.Token(Token = "0x4000097")]
	[Obsolete]
	public static readonly CAINOHGEENI FKJEFENCDIG;

	[Cpp2IlInjected.Token(Token = "0x4000098")]
	internal static readonly CAINOHGEENI AKCENELHIKK;

	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[Obsolete]
	public static readonly CAINOHGEENI KABGODKNPEI;

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static readonly CAINOHGEENI LFNJGANJKNB;

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x51D7400", Offset = "0x51D6200", VA = "0x1851D7400")]
	internal CAINOHGEENI(HNHNGJAANBB IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x683990", Offset = "0x682790", VA = "0x180683990")]
	internal CAINOHGEENI(DDIPNAHAPGP IDKBHBKJHPJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x51D6240", Offset = "0x51D5040", VA = "0x1851D6240")]
	public static CAINOHGEENI PAAEKNCKHBI(HNHNGJAANBB IDKBHBKJHPJ)
	{
		return default(CAINOHGEENI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x51D59F0", Offset = "0x51D47F0", VA = "0x1851D59F0")]
	public static CAINOHGEENI ENKMMIFKDPC(in CAINOHGEENI CFFPEBFKEAC, in CAINOHGEENI HNOJKNGFFBE)
	{
		return default(CAINOHGEENI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x51D57B0", Offset = "0x51D45B0", VA = "0x1851D57B0")]
	public static CAINOHGEENI ALBIBIICKPG(in CAINOHGEENI CFFPEBFKEAC, in CAINOHGEENI HNOJKNGFFBE)
	{
		return default(CAINOHGEENI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x51D60D0", Offset = "0x51D4ED0", VA = "0x1851D60D0")]
	public static CAINOHGEENI LEFAGGIMMNL(in CAINOHGEENI CFFPEBFKEAC, in CAINOHGEENI HNOJKNGFFBE)
	{
		return default(CAINOHGEENI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x51D5DF0", Offset = "0x51D4BF0", VA = "0x1851D5DF0")]
	public static CAINOHGEENI FKLABLIENBJ(in CAINOHGEENI CFFPEBFKEAC)
	{
		return default(CAINOHGEENI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x51D5980", Offset = "0x51D4780", VA = "0x1851D5980")]
	public static bool CJJJLAGEFIA(in CAINOHGEENI AIAIDPGGDMM, in CAINOHGEENI PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x51D5F90", Offset = "0x51D4D90", VA = "0x1851D5F90")]
	public static bool HNHKEOFMCPG(in CAINOHGEENI AIAIDPGGDMM, in CAINOHGEENI PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x51D5A70", Offset = "0x51D4870", VA = "0x1851D5A70", Slot = "4")]
	public bool Equals(CAINOHGEENI PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x51D5AE0", Offset = "0x51D48E0", VA = "0x1851D5AE0", Slot = "0")]
	public override bool Equals(object PHPKEGMGOPM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x51D5E60", Offset = "0x51D4C60", VA = "0x1851D5E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x51D5E80", Offset = "0x51D4C80", VA = "0x1851D5E80")]
	public bool HKOODFIGPOA(in CAINOHGEENI IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x51D6270", Offset = "0x51D5070", VA = "0x1851D6270", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x51D6200", Offset = "0x51D5000", VA = "0x1851D6200")]
	public KHHMNKABDPF OJEKOCHCCIE()
	{
		return default(KHHMNKABDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x51D6040", Offset = "0x51D4E40", VA = "0x1851D6040")]
	internal static string KCPKNEMHAIG(string GOJKMEMCPDE, LogType JOEDFCJACJF, CAINOHGEENI KEMAOBJDDDI, EFIKJKOCBHF JOHKKGJGBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x51D5920", Offset = "0x51D4720", VA = "0x1851D5920")]
	public static CAINOHGEENI CGCLCMEAHFG(string PBGNMGOJBIP)
	{
		return default(CAINOHGEENI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x51D6150", Offset = "0x51D4F50", VA = "0x1851D6150")]
	public string LGGFKIGAFJB(string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x51D5BC0", Offset = "0x51D49C0", VA = "0x1851D5BC0")]
	public (CAINOHGEENI, string) FHAOPMHOPCJ(LogType? JOEDFCJACJF, string IGJPNMBCJPK, EFIKJKOCBHF JOHKKGJGBLG)
	{
		return default((CAINOHGEENI, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x51D5830", Offset = "0x51D4630", VA = "0x1851D5830")]
	private static DDIPNAHAPGP ANJHDLDNACK(HNHNGJAANBB IDKBHBKJHPJ)
	{
		return default(DDIPNAHAPGP);
	}
}
[StructLayout((LayoutKind)2)]
[Cpp2IlInjected.Token(Token = "0x2000027")]
[DebuggerTypeProxy(typeof(IMEJAOLPCBO))]
internal struct DDIPNAHAPGP
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public static readonly DDIPNAHAPGP OPBCCNPLJFP;

	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private const int IGLALIKGLKK = 32;

	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	internal const int IEHBOKBAEPA = 2;

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	internal const int PNNGHBPDKFI = 8;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	internal unsafe fixed uint KNMOLKHLHCL[2];

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	internal unsafe fixed byte HFAIGCGNPJJ[8];

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private uint NOGPPLNGKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private uint MDDDBGCKACE;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x51DBD20", Offset = "0x51DAB20", VA = "0x1851DBD20")]
	public DDIPNAHAPGP(HNHNGJAANBB IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x51DBD50", Offset = "0x51DAB50", VA = "0x1851DBD50")]
	public DDIPNAHAPGP(ReadOnlySpan<char> BEMMNDNCCGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x51DB4C0", Offset = "0x51DA2C0", VA = "0x1851DB4C0")]
	public CMHPLOEMKEA BALJJOIEHDJ()
	{
		return default(CMHPLOEMKEA);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x51DBC50", Offset = "0x51DAA50", VA = "0x1851DBC50")]
	public KHHMNKABDPF OJEKOCHCCIE()
	{
		return default(KHHMNKABDPF);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x51DBCC0", Offset = "0x51DAAC0", VA = "0x1851DBCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x51DB8F0", Offset = "0x51DA6F0", VA = "0x1851DB8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x51DBA60", Offset = "0x51DA860", VA = "0x1851DBA60")]
	public bool HKOODFIGPOA(in DDIPNAHAPGP IDKBHBKJHPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x51DBC90", Offset = "0x51DAA90", VA = "0x1851DBC90")]
	public void PIGMJENILDA(HNHNGJAANBB LOAFEMFAKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x27F0870", Offset = "0x27EF670", VA = "0x1827F0870")]
	public int EBBNNBOCHAF(int NLGONJHJAPI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x51DBBD0", Offset = "0x51DA9D0", VA = "0x1851DBBD0")]
	public void IHADLKKEOMB(int NLGONJHJAPI, int IGJPNMBCJPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x51DB820", Offset = "0x51DA620", VA = "0x1851DB820", Slot = "0")]
	public override bool Equals(object CCPIHKCBGHF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x51DBB60", Offset = "0x51DA960", VA = "0x1851DBB60")]
	public static bool HNHKEOFMCPG(in DDIPNAHAPGP AIAIDPGGDMM, in DDIPNAHAPGP PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x51DB4E0", Offset = "0x51DA2E0", VA = "0x1851DB4E0")]
	public static bool CJJJLAGEFIA(DDIPNAHAPGP AIAIDPGGDMM, DDIPNAHAPGP PHPKEGMGOPM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x51DB7F0", Offset = "0x51DA5F0", VA = "0x1851DB7F0")]
	public static DDIPNAHAPGP ENKMMIFKDPC(DDIPNAHAPGP AIAIDPGGDMM, DDIPNAHAPGP PHPKEGMGOPM)
	{
		return default(DDIPNAHAPGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x51DB490", Offset = "0x51DA290", VA = "0x1851DB490")]
	public static DDIPNAHAPGP ALBIBIICKPG(DDIPNAHAPGP AIAIDPGGDMM, DDIPNAHAPGP PHPKEGMGOPM)
	{
		return default(DDIPNAHAPGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x51DBC20", Offset = "0x51DAA20", VA = "0x1851DBC20")]
	public static DDIPNAHAPGP LEFAGGIMMNL(DDIPNAHAPGP AIAIDPGGDMM, DDIPNAHAPGP PHPKEGMGOPM)
	{
		return default(DDIPNAHAPGP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x51DB8D0", Offset = "0x51DA6D0", VA = "0x1851DB8D0")]
	public static DDIPNAHAPGP FKLABLIENBJ(DDIPNAHAPGP CFFPEBFKEAC)
	{
		return default(DDIPNAHAPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x51DB7B0", Offset = "0x51DA5B0", VA = "0x1851DB7B0")]
	private int DBNHCCEHPFD(int NLGONJHJAPI, int IGJPNMBCJPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x51DBB30", Offset = "0x51DA930", VA = "0x1851DBB30")]
	private int HLMHFBCENHL(int NLGONJHJAPI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class IMEJAOLPCBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DDIPNAHAPGP FNOLDKEDIPP;

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public string[] LKLHAMANGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x51DFAA0", Offset = "0x51DE8A0", VA = "0x1851DFAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int[] ENLOJBFKIDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x51DFA90", Offset = "0x51DE890", VA = "0x1851DFA90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public byte[] PMLIAJPEKPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x51DF8C0", Offset = "0x51DE6C0", VA = "0x1851DF8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public uint[] AJFLJMAPNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x51DFBF0", Offset = "0x51DE9F0", VA = "0x1851DFBF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0xDDD300", Offset = "0xDDC100", VA = "0x180DDD300")]
	public IMEJAOLPCBO(DDIPNAHAPGP FNOLDKEDIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x51DF950", Offset = "0x51DE750", VA = "0x1851DF950")]
	private int[] BAAEDDONANG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x51DFAA0", Offset = "0x51DE8A0", VA = "0x1851DFAA0")]
	private string[] FKMINELABPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x51DF8C0", Offset = "0x51DE6C0", VA = "0x1851DF8C0")]
	private byte[] FMAJACAKGLG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x51DFBF0", Offset = "0x51DE9F0", VA = "0x1851DFBF0")]
	private uint[] OHCDPFCHLOI()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct CMHPLOEMKEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private readonly DDIPNAHAPGP FNOLDKEDIPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private byte PJNANMEIBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private int NFIDCGJFJON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private int AIPHGHFENPJ;

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public int MFINOJMLAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x657020", Offset = "0x655E20", VA = "0x180657020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x51DAC80", Offset = "0x51D9A80", VA = "0x1851DAC80")]
	public CMHPLOEMKEA(in DDIPNAHAPGP FNOLDKEDIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x51DABE0", Offset = "0x51D99E0", VA = "0x1851DABE0")]
	public bool HMKKNIINHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x51DAC50", Offset = "0x51D9A50", VA = "0x1851DAC50")]
	private bool PFNNJFBIJLG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x51DAB90", Offset = "0x51D9990", VA = "0x1851DAB90")]
	private bool FFEOFONMFBN()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
internal static class JFHLFMBFFNM
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private const string KFLLHDCGNLA = "None";

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private const string NCEEFLNPNKN = "All";

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly StringBuilder NHDKHCEFNFI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static readonly string[] JFJBJIMFOCP;

	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private static readonly Dictionary<string, int> DCMHHKEEHEO;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x51E0340", Offset = "0x51DF140", VA = "0x1851E0340")]
	public static DDIPNAHAPGP CGCLCMEAHFG(string PJBOCGIPPNP)
	{
		return default(DDIPNAHAPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x51E05F0", Offset = "0x51DF3F0", VA = "0x1851E05F0")]
	internal static string DJJBAGBAKMA(in DDIPNAHAPGP OLOFBGICPAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x51E01C0", Offset = "0x51DEFC0", VA = "0x1851E01C0")]
	private static Dictionary<string, int> AICIGICNBJD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
internal static class MEDLHMCHBNI
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private static readonly StringBuilder NHDKHCEFNFI;

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private const string CENAHKNLCCB = "|>";

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private const int LBONMHCKJJP = 4;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int BLKLIADOPLB;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly CAINOHGEENI IPLGJGHDBFP;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly CAINOHGEENI HCPCKDMJMON;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x51E5620", Offset = "0x51E4420", VA = "0x1851E5620")]
	public static string KGNOKOCICNP(in CAINOHGEENI IGJPNMBCJPK, string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x51E4AC0", Offset = "0x51E38C0", VA = "0x1851E4AC0")]
	public static string AILMFIELPJF(in CAINOHGEENI IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x51E5CA0", Offset = "0x51E4AA0", VA = "0x1851E5CA0")]
	public static CAINOHGEENI OLPJPIFMPEM(string IGJPNMBCJPK)
	{
		return default(CAINOHGEENI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x51E4C10", Offset = "0x51E3A10", VA = "0x1851E4C10")]
	public static string BJLBAGJDEPM(in CAINOHGEENI IGJPNMBCJPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x51E5690", Offset = "0x51E4490", VA = "0x1851E5690")]
	public static CAINOHGEENI LGAKNFCDAME(string LDCAGOFCJBE)
	{
		return default(CAINOHGEENI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x51E5280", Offset = "0x51E4080", VA = "0x1851E5280")]
	public static (CAINOHGEENI, string) JDJKJGPFKBK(in CAINOHGEENI KEMAOBJDDDI, LogType? JOEDFCJACJF, string IGJPNMBCJPK, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG)
	{
		return default((CAINOHGEENI, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x51E4DF0", Offset = "0x51E3BF0", VA = "0x1851E4DF0")]
	private static bool ECJBHBCHFNO(string IGJPNMBCJPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x51E4E90", Offset = "0x51E3C90", VA = "0x1851E4E90")]
	private static (CAINOHGEENI, string) ELJAPPDNKGJ(in CAINOHGEENI GPJBKHALKDG, LogType JOEDFCJACJF, string IGJPNMBCJPK, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG)
	{
		return default((CAINOHGEENI, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x51E4CD0", Offset = "0x51E3AD0", VA = "0x1851E4CD0")]
	private static DDIPNAHAPGP BMCICPEHOML(ReadOnlySpan<char> ALBEHKGJMMI)
	{
		return default(DDIPNAHAPGP);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x51E4D10", Offset = "0x51E3B10", VA = "0x1851E4D10")]
	private static CAINOHGEENI BPKIDCIKPJI(LogType JOEDFCJACJF)
	{
		return default(CAINOHGEENI);
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x51E59C0", Offset = "0x51E47C0", VA = "0x1851E59C0")]
	private static (CAINOHGEENI, string) OEBLGKKKJBA(in CAINOHGEENI GPJBKHALKDG, LogType JOEDFCJACJF, string IGJPNMBCJPK, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG)
	{
		return default((CAINOHGEENI, string));
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x51E5460", Offset = "0x51E4260", VA = "0x1851E5460")]
	private static string KGNOKOCICNP(in DDIPNAHAPGP IGJPNMBCJPK, string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x51E5940", Offset = "0x51E4740", VA = "0x1851E5940")]
	private static void MHBPMAGKFCN(in DDIPNAHAPGP IGJPNMBCJPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
internal static class NBJCOECALGL
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly TimeZoneInfo ECIAPAGLFOF;

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x51E6930", Offset = "0x51E5730", VA = "0x1851E6930")]
	public static string KCPKNEMHAIG(string GOJKMEMCPDE, LogType JOEDFCJACJF, in CAINOHGEENI KEMAOBJDDDI, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x51E6140", Offset = "0x51E4F40", VA = "0x1851E6140")]
	private static bool FKMEAGMNJPD(in CAINOHGEENI KEMAOBJDDDI, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x51E7080", Offset = "0x51E5E80", VA = "0x1851E7080")]
	private static void LHIEKJBBKGF(StringBuilder NHDKHCEFNFI, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x51E5FD0", Offset = "0x51E4DD0", VA = "0x1851E5FD0")]
	private static void ELPMCCIGABG(CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG, StringBuilder NHDKHCEFNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x51E62F0", Offset = "0x51E50F0", VA = "0x1851E62F0")]
	private static void HDGKNKLBMNF(CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG, StringBuilder NHDKHCEFNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x51E6F70", Offset = "0x51E5D70", VA = "0x1851E6F70")]
	private static void KIOEDJDMMEI(LogType JOEDFCJACJF, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG, StringBuilder NHDKHCEFNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x51E6210", Offset = "0x51E5010", VA = "0x1851E6210")]
	private static void GMKMJLJJKAG(CAINOHGEENI KEMAOBJDDDI, CAINOHGEENI.EFIKJKOCBHF JOHKKGJGBLG, StringBuilder NHDKHCEFNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x51E6110", Offset = "0x51E4F10", VA = "0x1851E6110")]
	private static void FGIJLIECGFK(string GOJKMEMCPDE, StringBuilder NHDKHCEFNFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x51E64E0", Offset = "0x51E52E0", VA = "0x1851E64E0")]
	private static TimeZoneInfo KBFLCPPBCFD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x35E4290", Offset = "0x35E3090", VA = "0x1835E4290")]
	private static bool IGGDJEIDFFJ(CAINOHGEENI.EFIKJKOCBHF AIAIDPGGDMM, CAINOHGEENI.EFIKJKOCBHF PHPKEGMGOPM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct KHHMNKABDPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private CMHPLOEMKEA KGOGDOONAOI;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string MFINOJMLAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x51E17A0", Offset = "0x51E05A0", VA = "0x1851E17A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x51E1820", Offset = "0x51E0620", VA = "0x1851E1820")]
	internal KHHMNKABDPF(in DDIPNAHAPGP FNOLDKEDIPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x51E1790", Offset = "0x51E0590", VA = "0x1851E1790")]
	public bool HMKKNIINHFB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x1D372B0", Offset = "0x1D360B0", VA = "0x181D372B0")]
	public KHHMNKABDPF BALJJOIEHDJ()
	{
		return default(KHHMNKABDPF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct JEKBBDHGFBJ
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Obsolete]
	public ref struct KPFHAEINIEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private ReadOnlySpan<char> EBJPDCHFDFO;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public string MFINOJMLAJL
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x660AF0", Offset = "0x65F8F0", VA = "0x180660AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x51E20D0", Offset = "0x51E0ED0", VA = "0x1851E20D0")]
		public KPFHAEINIEJ(string GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x51E1D30", Offset = "0x51E0B30", VA = "0x1851E1D30")]
		public bool HMKKNIINHFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x51E1E40", Offset = "0x51E0C40", VA = "0x1851E1E40")]
		private ReadOnlySpan<char> JHHEEJKMGKG(ReadOnlySpan<char> ALBEHKGJMMI)
		{
			return default(ReadOnlySpan<char>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x51E1F60", Offset = "0x51E0D60", VA = "0x1851E1F60")]
		private ReadOnlySpan<char> LLCLFEFLGEF(ReadOnlySpan<char> ALBEHKGJMMI, out ReadOnlySpan<char> EBJPDCHFDFO)
		{
			return default(ReadOnlySpan<char>);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly string GOJKMEMCPDE;

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x74C1F0", Offset = "0x74AFF0", VA = "0x18074C1F0")]
	public JEKBBDHGFBJ(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x51E0190", Offset = "0x51DEF90", VA = "0x1851E0190")]
	public KPFHAEINIEJ BALJJOIEHDJ()
	{
		return default(KPFHAEINIEJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public sealed class KEKAEOGEOIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<CAINOHGEENI, int> KGHDNKKOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private CAINOHGEENI FKEHIMDIGNA;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public CAINOHGEENI OOOJABMLDCD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x2C84A70", Offset = "0x2C83870", VA = "0x182C84A70")]
		get
		{
			return default(CAINOHGEENI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x51E15F0", Offset = "0x51E03F0", VA = "0x1851E15F0")]
	public KEKAEOGEOIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x51E16B0", Offset = "0x51E04B0", VA = "0x1851E16B0")]
	public KEKAEOGEOIN(in CAINOHGEENI IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x51E1510", Offset = "0x51E0310", VA = "0x1851E1510")]
	public void NLPNNADOIMN(in CAINOHGEENI IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x51E1400", Offset = "0x51E0200", VA = "0x1851E1400")]
	public void EIBCALAAPOL(in CAINOHGEENI IDKBHBKJHPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x51E1200", Offset = "0x51E0000", VA = "0x1851E1200")]
	private CAINOHGEENI BOLKLHOCCGC()
	{
		return default(CAINOHGEENI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public readonly struct KNNFEEOAAMH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly global::DENBCNFHDLB<NOAPHGCLLPE> IFNENMIJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly global::DENBCNFHDLB<NOAPHGCLLPE>.CCNAEFMHDME DOIFILMFCEH;

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x51E1C00", Offset = "0x51E0A00", VA = "0x1851E1C00")]
	internal KNNFEEOAAMH(in CAINOHGEENI KEMAOBJDDDI, bool EFJKFNKFDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x51E1980", Offset = "0x51E0780", VA = "0x1851E1980", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
internal sealed class DENBCNFHDLB<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate T KOLCCMKHFLC();

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate void HLNEFJOOJNE(in T JANIFNADDOP);

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate void IHBCHDGJPLL(in T? MLCBLIMBCKK, in T? NHKNDBFPFHG);

	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public readonly struct CCNAEFMHDME : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private readonly global::DENBCNFHDLB<T> FGGLEALGCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		private readonly bool PEDDCKOKOLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		private readonly CAINOHGEENI? PEMOIKIDPOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		private readonly T? PMNDJOCKCAK;

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x33263B0", Offset = "0x33251B0", VA = "0x1833263B0")]
		public CCNAEFMHDME(global::DENBCNFHDLB<T> IKPEGPHMIII, in CAINOHGEENI? IDKBHBKJHPJ, T? JANIFNADDOP, bool EFJKFNKFDIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x3325F50", Offset = "0x3324D50", VA = "0x183325F50", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly AKNLINBDIBN KGHDNKKOFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly KOLCCMKHFLC HAOCKCIJKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private readonly HLNEFJOOJNE AIDKCOBMNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private readonly IHBCHDGJPLL LGIMHABICFI;

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x24C0AC0", Offset = "0x24BF8C0", VA = "0x1824C0AC0")]
	public DENBCNFHDLB(AKNLINBDIBN IDKBHBKJHPJ, KOLCCMKHFLC ICAIENENEIE, HLNEFJOOJNE HEGCMNAHDHD, IHBCHDGJPLL HJCDJBJFNLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x25BAA30", Offset = "0x25B9830", VA = "0x1825BAA30")]
	public CCNAEFMHDME PACKJEBLCCO(in CAINOHGEENI? IDKBHBKJHPJ, in T? JANIFNADDOP, bool EFJKFNKFDIO)
	{
		return default(CCNAEFMHDME);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface ANFMJPHICPN
{
	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJGIJIFMICL(string GOJKMEMCPDE);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEGKOIJBHKM(int MNKEEJPGFOP);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IIOELKEIHEG();

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	string GDPHLEIHAJL();

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	byte[] HPIIBNGHDFJ();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class LOGKHEHPCCH : ANFMJPHICPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private readonly object NAOKKMIMDEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private readonly Queue<string> NCHABKOJEPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private int JIHHLPGHJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int JGHCIBJCMDF;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int PANMOHPAPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x661740", Offset = "0x660540", VA = "0x180661740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x51E44C0", Offset = "0x51E32C0", VA = "0x1851E44C0", Slot = "4")]
	public void FJGIJIFMICL(string GOJKMEMCPDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x51E4430", Offset = "0x51E3230", VA = "0x1851E4430", Slot = "5")]
	public void EEGKOIJBHKM(int MNKEEJPGFOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x51E4650", Offset = "0x51E3450", VA = "0x1851E4650")]
	private void FPLDKDENOCD(int FKFKKHLOEBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x51E4950", Offset = "0x51E3750", VA = "0x1851E4950", Slot = "6")]
	public void IIOELKEIHEG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x51E46F0", Offset = "0x51E34F0", VA = "0x1851E46F0", Slot = "7")]
	public string GDPHLEIHAJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x51E4900", Offset = "0x51E3700", VA = "0x1851E4900", Slot = "8")]
	public byte[] HPIIBNGHDFJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x51E49F0", Offset = "0x51E37F0", VA = "0x1851E49F0")]
	public LOGKHEHPCCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct JDKDBFGGDKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly global::DENBCNFHDLB<int> IFNENMIJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private readonly global::DENBCNFHDLB<int>.CCNAEFMHDME DOIFILMFCEH;

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x51E00B0", Offset = "0x51DEEB0", VA = "0x1851E00B0")]
	internal JDKDBFGGDKG(in CAINOHGEENI? FKFNFNGPJEJ, int? MNKEEJPGFOP, bool EFJKFNKFDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x51DFE30", Offset = "0x51DEC30", VA = "0x1851DFE30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
[Flags]
public enum DFIFEAMHHFH
{
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Error = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Assert = 2,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Warning = 4,
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	Log = 8,
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Exception = 0x10
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class JKDDPNMCBKH
{
	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x51E1100", Offset = "0x51DFF00", VA = "0x1851E1100")]
	public static bool LFDGCAIIPAE(this DFIFEAMHHFH IDKBHBKJHPJ, LogType JOEDFCJACJF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public static class AFPLMHOHDIB
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[BPIIFNIBKIJ]
	public interface KAFGNHEEOGM
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void LIJMLAGGKHC(CAINOHGEENI DJFKGNOCABH);
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public sealed class LNJPHNAMGGO : KAFGNHEEOGM
	{
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		public static readonly LNJPHNAMGGO JNHMLOILMCH;

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		private LNJPHNAMGGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "4")]
		public void LIJMLAGGKHC(CAINOHGEENI DJFKGNOCABH)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class GFKBBLECLAE
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[BPIIFNIBKIJ]
	public interface JLICFJCCPPA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		void AGMLEMEHLDN(GNHFEGBMDPN FLGNLOCNGHM, string AGOOMMEFGEK);

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		IDisposable DELFMPDIADD(GNHFEGBMDPN FLGNLOCNGHM, string PHGLMIFHPCF);
	}

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private static JLICFJCCPPA NKIPKAGLJMM;

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x51DC200", Offset = "0x51DB000", VA = "0x1851DC200")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void BLILFONDOGM(JLICFJCCPPA HADJLLLCKOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x51DC340", Offset = "0x51DB140", VA = "0x1851DC340")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void EOMINMMDCDF(string AGOOMMEFGEK, GNHFEGBMDPN FLGNLOCNGHM = GNHFEGBMDPN.General)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x51DC420", Offset = "0x51DB220", VA = "0x1851DC420")]
	[Conditional("ENABLE_PLATFORM_NATIVE_PROFILER")]
	public static void FEEFGGKJIGL(string PHGLMIFHPCF, ref IDisposable MFOEOHDBMFF, GNHFEGBMDPN FLGNLOCNGHM = GNHFEGBMDPN.General)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public enum GNHFEGBMDPN
{
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	General,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	Frame,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	RecNet,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	BestHTTP,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	JSON,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	BootSequence,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Async,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Fade,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	PhotonRegion,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	PhotonRoomJoin,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TitleScreen
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
internal sealed class ICKLJMMBPPF : ILogHandler
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private readonly struct KJAHGBKBHAP : IEquatable<KJAHGBKBHAP>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public readonly LogType CGPOHLKCBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public readonly UnityEngine.Object MIHDCEBNJBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public readonly string KEEMBLJCPAE;

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x35E7130", Offset = "0x35E5F30", VA = "0x1835E7130")]
		public KJAHGBKBHAP(LogType JOEDFCJACJF, UnityEngine.Object NAHJDDBGMOA, string GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x51E1860", Offset = "0x51E0660", VA = "0x1851E1860", Slot = "4")]
		public bool Equals(KJAHGBKBHAP CCPIHKCBGHF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private readonly struct OMNILPENGIO : IEquatable<OMNILPENGIO>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public readonly Exception LIPBKIPKHJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public readonly UnityEngine.Object MIHDCEBNJBA;

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x6CE460", Offset = "0x6CD260", VA = "0x1806CE460")]
		public OMNILPENGIO(Exception AAGNMLCAPCC, UnityEngine.Object NAHJDDBGMOA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x51E79F0", Offset = "0x51E67F0", VA = "0x1851E79F0", Slot = "4")]
		public bool Equals(OMNILPENGIO CCPIHKCBGHF)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class EGKILMFMEII : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x51DBF30", Offset = "0x51DAD30", VA = "0x1851DBF30")]
		public EGKILMFMEII(string GOJKMEMCPDE, Exception CNFPBKCKKEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class OFJAFEKFFKN : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x51E7970", Offset = "0x51E6770", VA = "0x1851E7970")]
		public OFJAFEKFFKN(string GOJKMEMCPDE, Exception CNFPBKCKKEC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class AFCGKJJFPCM : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x51D4E30", Offset = "0x51D3C30", VA = "0x1851D4E30")]
		public AFCGKJJFPCM(string GOJKMEMCPDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x51D4EA0", Offset = "0x51D3CA0", VA = "0x1851D4EA0")]
		public AFCGKJJFPCM(string GOJKMEMCPDE, Exception CNFPBKCKKEC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private readonly object NAOKKMIMDEJ;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private const float IHPECABPLJP = 6f;

	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private const int KKOOEHKHGLP = 180;

	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private const int ECEBDJHGEJN = 10;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly ILogHandler CFEJAAANAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private IDisposable FDDMIIPHEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private int JLDACKAFFAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private int PHPBAACNBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private KJAHGBKBHAP? NMFDDLNPOLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private int IAGKCJDBGEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private OMNILPENGIO? CFNIOHDEMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private int ALKHPOGNMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private bool JBAGPIKPAGC;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool KCEMFBBKHFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x7B1E90", Offset = "0x7B0C90", VA = "0x1807B1E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EC0", Offset = "0x7B0CC0", VA = "0x1807B1EC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x51DF6C0", Offset = "0x51DE4C0", VA = "0x1851DF6C0")]
	public ICKLJMMBPPF(ILogHandler CFEJAAANAHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x51DD850", Offset = "0x51DC650", VA = "0x1851DD850")]
	public void ENDJPLBKPHO(bool KLOLPHHHMCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x51DDFC0", Offset = "0x51DCDC0", VA = "0x1851DDFC0")]
	private void GDNPGMNHJAK(float KIHDPCDCOMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x51DE520", Offset = "0x51DD320", VA = "0x1851DE520", Slot = "5")]
	public void LogException(Exception AAGNMLCAPCC, UnityEngine.Object NAHJDDBGMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x51DE2D0", Offset = "0x51DD0D0", VA = "0x1851DE2D0")]
	private void IBDGNKKBICO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x51DEAC0", Offset = "0x51DD8C0", VA = "0x1851DEAC0", Slot = "4")]
	public void LogFormat(LogType JOEDFCJACJF, UnityEngine.Object NAHJDDBGMOA, string DDGOGNPOMJE, params object[] KMLLOCJHKPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x51DF200", Offset = "0x51DE000", VA = "0x1851DF200")]
	private void MFKGDCAHOGE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x51DDBD0", Offset = "0x51DC9D0", VA = "0x1851DDBD0")]
	public static Exception FHEFHIPIGCP(Exception AAGNMLCAPCC, string GOJKMEMCPDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x51DD720", Offset = "0x51DC520", VA = "0x1851DD720")]
	private static string DHNEDGKEGNO(Exception AAGNMLCAPCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x51DD630", Offset = "0x51DC430", VA = "0x1851DD630")]
	private static bool BFNPACKNFKK(Exception AAGNMLCAPCC, StringBuilder NHDKHCEFNFI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct PMIHJAJMFBM<T> : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private readonly Action<T> MLBCCNCBNHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private readonly T BEIKMLIBFDO;

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x3507510", Offset = "0x3506310", VA = "0x183507510")]
	public PMIHJAJMFBM(Action<T> MLBCCNCBNHG, T BEIKMLIBFDO, T HFFCNNKMKHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x35073B0", Offset = "0x35061B0", VA = "0x1835073B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct PFECBFLOIAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly global::DENBCNFHDLB<NOAPHGCLLPE> IFNENMIJBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly global::DENBCNFHDLB<NOAPHGCLLPE>.CCNAEFMHDME DOIFILMFCEH;

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x51E7FE0", Offset = "0x51E6DE0", VA = "0x1851E7FE0")]
	internal PFECBFLOIAJ(in CAINOHGEENI KEMAOBJDDDI, bool EFJKFNKFDIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x51E7D60", Offset = "0x51E6B60", VA = "0x1851E7D60", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Debugging
{
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public sealed class ThreadSafeTimeUpdater : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x51E8240", Offset = "0x51E7040", VA = "0x1851E8240")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x51E83B0", Offset = "0x51E71B0", VA = "0x1851E83B0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
		public ThreadSafeTimeUpdater()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
[Flags]
public enum HNHNGJAANBB
{
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	Default = 0,
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	Unity = 1,
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	Error = 2,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Warning = 3,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Debug = 4,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	PUNNetworkManager = 5,
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	PhotonRpcs = 6,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	PhotonCustomProperties = 7,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	PhotonOwnership = 8,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	PhotonNetworkInstantiate = 9,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	PhotonCreateAndDestroy = 0xA,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	PhotonNetwork = 0xB,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	SynchronizedFields = 0xC,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	UJect = 0xD,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	RoomLoad = 0xE,
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	RecNet = 0xF,
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	ObjectModel = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	CircuitsV2DebugLogNode = 0x11,
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	CircuitsV2Reduce = 0x12,
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	CircuitsV2RecRoomIntegration = 0x13,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	CircuitsV2Lifecycle = 0x14,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	CircuitsV2Visualization = 0x15,
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	CircuitsV2Heat = 0x16,
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	CircuitsV2Memory = 0x17,
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	CircuitsV2CloudData = 0x18,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	CircuitsV2Environments = 0x19,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	CircuitsV2EventBus = 0x1A,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	CircuitsV2Graph = 0x1B,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	CircuitsV2Root = 0x1C,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	CircuitsV2State = 0x1D,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	RoomReset = 0x1E,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	UgcWatchdog = 0x1F,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	AvatarLod = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	HashCheck = 0x21,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	ConvexHullGeneration = 0x22,
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	SpawnableToolInstantiate = 0x23,
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	BufferedEventHelper = 0x24,
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	BufferedEventHelperSendRecv = 0x25,
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	PhotonClient = 0x26,
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	RoomManager = 0x27,
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	QuestManager = 0x28,
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	RoomOperation = 0x29,
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	BigDataTrackedObject = 0x2A,
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	LoadingScreen = 0x2B,
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	PersistenceView = 0x2C,
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	MakerPen = 0x2D,
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	Autosave = 0x2E,
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	Connectables = 0x2F,
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	Tags = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	Patching = 0x31,
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	LogGameObjectAddComponentPatch = 0x32,
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	LogTransformSetPositionPatch = 0x33,
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	LogTransformSetRotationPatch = 0x34,
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	LogTransformSetLocalPositionPatch = 0x35,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	LogTransformSetLocalRotationPatch = 0x36,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	LogTransformSetLocalScalePatch = 0x37,
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	LogTransformSetParentPatch = 0x38,
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	LogGameObjectDestroyPatch = 0x39,
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	LogTaskCancelPatch = 0x3A,
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	LogCancellationTokenSourceDisposePatch = 0x3B,
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	ImageCompression = 0x3C,
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	COUNT = 0x3D,
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	All = -2
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000052")]
public class ABAJDIGBNMI
{
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private static byte[] GCDEGNDFAID;

	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private static int BBIOPAKABFB;

	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private static int ACMEFJOAGOE;

	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private static BigInteger MCNKOBABGEE;

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
	public ABAJDIGBNMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x51D4800", Offset = "0x51D3600", VA = "0x1851D4800")]
	private static string DPCKFJIDOBP(byte[] BMMLDIMMAAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x51D4910", Offset = "0x51D3710", VA = "0x1851D4910")]
	public static string FBACHCLJNPO(byte[] HFAIGCGNPJJ, bool KDMKCCLJMIF)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x400014B")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x65A810", Offset = "0x659610", VA = "0x18065A810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
