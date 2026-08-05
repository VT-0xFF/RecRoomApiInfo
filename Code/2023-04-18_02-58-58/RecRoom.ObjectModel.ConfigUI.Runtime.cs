using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.ObjectModel.ConfigUI;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
internal abstract class OFPCECFLKJE : global::BPJDKPMDFFF<Enum>, HBHNPLLENCI, NHKMMIDKGON, BLCKCIENGCI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool KLKEBKPPNHH(Type NIFOGEBEDNG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66DE500", Offset = "0x66DD700", VA = "0x1866DE500")]
	protected OFPCECFLKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class BPJDKPMDFFF<T> : NHKMMIDKGON, BLCKCIENGCI where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void ENBOKNANKFA(Func<T> GCCELDFKNJO, Action<T> LCPAKHJBEOA, string KNOPFGAGMCN, KFBCGBKCDNN IDBLFHOOMPH, Func<bool> EPDJDCDHLMP);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void DPLCKHFGLKE(Func<int> GCCELDFKNJO, Action<int> LCPAKHJBEOA, string KNOPFGAGMCN, KFBCGBKCDNN IDBLFHOOMPH, Func<bool> EPDJDCDHLMP);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class OGLEMIAFMLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public GNFJJEDLPLM targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KFBCGBKCDNN property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public OGLEMIAFMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x202D070", Offset = "0x202C270", VA = "0x18202D070")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x202D150", Offset = "0x202C350", VA = "0x18202D150")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class LJDELNPNNOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::BPJDKPMDFFF<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public AECOLMNECLH ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public LJDELNPNNOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x21A6F50", Offset = "0x21A6150", VA = "0x1821A6F50")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, KFBCGBKCDNN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class JHBHFIENHFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public JHBHFIENHFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2339150", Offset = "0x2338350", VA = "0x182339150")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x23393D0", Offset = "0x23385D0", VA = "0x1823393D0")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5870", Offset = "0x1EC4A70", VA = "0x181EC5870")]
	protected BPJDKPMDFFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1EC53D0", Offset = "0x1EC45D0", VA = "0x181EC53D0", Slot = "5")]
	public virtual void LABONIGBNGC(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH, AECOLMNECLH MDKDFFMBEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1EC50F0", Offset = "0x1EC42F0", VA = "0x181EC50F0", Slot = "6")]
	protected virtual ENBOKNANKFA GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1EC4F50", Offset = "0x1EC4150", VA = "0x181EC4F50", Slot = "7")]
	protected virtual DPLCKHFGLKE AFCMGLLJCIC(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1EC5070", Offset = "0x1EC4270", VA = "0x181EC5070")]
	private static Enum DANNMPLLLGN(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1EC51F0", Offset = "0x1EC43F0", VA = "0x181EC51F0")]
	private static void KMBNBGEEGKP(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH, Enum IPMIIEAGJKC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class BLKMNJDJMCK : LKDBJOCLPIA, BLCKCIENGCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private KFBCGBKCDNN[] IEAFENFKONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private KFBCGBKCDNN[] CLKOHINOKNC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public KFBCGBKCDNN[] PIMGFFLPCNM
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6FAB10", Offset = "0x6F9D10", VA = "0x1806FAB10", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public KFBCGBKCDNN[] IPLPGCJOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract JECBEPMPMHJ[] FCFNHAMIKGD
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract JECBEPMPMHJ[] ONLJPPEEDPF
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x66DE540", Offset = "0x66DD740", VA = "0x1866DE540", Slot = "6")]
	public void LLLPMINBGLL(BPDDKPBGCMN AEBNJEGLADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void LABONIGBNGC(GNFJJEDLPLM AAGLHJMICLO, AECOLMNECLH MDKDFFMBEEO);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x217BFE0", Offset = "0x217B1E0", VA = "0x18217BFE0")]
	protected static T MDBOFHNBCBK<T>(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x217C030", Offset = "0x217B230", VA = "0x18217C030")]
	protected static void MPIICMDKGJB<T>(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH, T IPMIIEAGJKC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	protected BLKMNJDJMCK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class AAEJHHJNGED<T> : NHKMMIDKGON, BLCKCIENGCI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void PIEIMEINHLK(Func<T> GCCELDFKNJO, Action<T> LCPAKHJBEOA, string KNOPFGAGMCN, KFBCGBKCDNN IDBLFHOOMPH, Func<bool> EPDJDCDHLMP);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GANFNAHMNMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public GNFJJEDLPLM targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public KFBCGBKCDNN property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x896ED0", Offset = "0x8960D0", VA = "0x180896ED0")]
		public GANFNAHMNMM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x2FDBF20", Offset = "0x2FDB120", VA = "0x182FDBF20")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x2FDC120", Offset = "0x2FDB320", VA = "0x182FDC120")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1BA5F80", Offset = "0x1BA5180", VA = "0x181BA5F80")]
	protected AAEJHHJNGED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1BA4F70", Offset = "0x1BA4170", VA = "0x181BA4F70", Slot = "4")]
	public void LABONIGBNGC(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH, AECOLMNECLH MDKDFFMBEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x1BA5410", Offset = "0x1BA4610", VA = "0x181BA5410")]
	private static T MDBOFHNBCBK(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1BA5A50", Offset = "0x1BA4C50", VA = "0x181BA5A50")]
	private static void MPIICMDKGJB(GNFJJEDLPLM AAGLHJMICLO, KFBCGBKCDNN IDBLFHOOMPH, T IPMIIEAGJKC)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ConfigUI)]
	[PNCLNBNALEO(typeof(CCCCKLOECOD), new string[] { })]
	internal class ConfigUIService : CCCCKLOECOD, CMLEAAEGAAL, BDLDACMOPAJ, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[GAJFPHPAPMA]
		private BPDDKPBGCMN AEBNJEGLADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[GAJFPHPAPMA]
		private MELJJCPNELB OIDGAMAOHHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[GAJFPHPAPMA]
		private AECOLMNECLH BALDFEPCCNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GAJFEPPGBDK ONIBEDDFLFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private GNFJJEDLPLM AAGLHJMICLO;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x66DFA40", Offset = "0x66DEC40", VA = "0x1866DFA40", Slot = "5")]
		public void PACELKAFLHO(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x66DEE30", Offset = "0x66DE030", VA = "0x1866DEE30", Slot = "6")]
		public void AGFEPBOGOON(BLBDINABANB LBBJCIBEDFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x66DF160", Offset = "0x66DE360", VA = "0x1866DF160", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x66DF250", Offset = "0x66DE450", VA = "0x1866DF250", Slot = "4")]
		public void FAAHOPKCKKD(GNFJJEDLPLM MDMHLFBPAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x66DFAD0", Offset = "0x66DECD0", VA = "0x1866DFAD0")]
		private void PMOFBGONBOG(GNFJJEDLPLM MDMHLFBPAPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x66DF130", Offset = "0x66DE330", VA = "0x1866DF130")]
		private void BFFPKLMBDDM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x66DF7C0", Offset = "0x66DE9C0", VA = "0x1866DF7C0")]
		private void LABONIGBNGC(FFOEOFJNFFN JJGPMDPEKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BFBLINDMMBI(0)]
internal class BKNDIAOPNAM : OFPCECFLKJE
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x66DE450", Offset = "0x66DD650", VA = "0x1866DE450", Slot = "9")]
	public override bool KLKEBKPPNHH(Type NIFOGEBEDNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x66DE360", Offset = "0x66DD560", VA = "0x1866DE360", Slot = "6")]
	protected override ENBOKNANKFA GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x66DE500", Offset = "0x66DD700", VA = "0x1866DE500")]
	public BKNDIAOPNAM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[BFBLINDMMBI(0)]
internal class COIPHKAHOBD : OFPCECFLKJE
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x66DED80", Offset = "0x66DDF80", VA = "0x1866DED80", Slot = "9")]
	public override bool KLKEBKPPNHH(Type NIFOGEBEDNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x66DEC90", Offset = "0x66DDE90", VA = "0x1866DEC90", Slot = "6")]
	protected override ENBOKNANKFA GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x66DE500", Offset = "0x66DD700", VA = "0x1866DE500")]
	public COIPHKAHOBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[FIHJOIBNOID(typeof(KGHPJHLCKAG), 1)]
internal class HHDDOPBDJHB : global::BPJDKPMDFFF<KGHPJHLCKAG>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x66E2990", Offset = "0x66E1B90", VA = "0x1866E2990", Slot = "7")]
	protected override DPLCKHFGLKE AFCMGLLJCIC(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x66E2A80", Offset = "0x66E1C80", VA = "0x1866E2A80")]
	public HHDDOPBDJHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class KHABHEPHIHI
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x66E3050", Offset = "0x66E2250", VA = "0x1866E3050")]
	public static bool PKACPGAIPOI(this KFBCGBKCDNN IDBLFHOOMPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[LEMBCEKGCEK(2)]
internal class EFCLFFCJGEK : BLKMNJDJMCK
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class LMECBBOBIKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public GNFJJEDLPLM targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public EFCLFFCJGEK <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public LMECBBOBIKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x66E3DF0", Offset = "0x66E2FF0", VA = "0x1866E3DF0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x66E3F20", Offset = "0x66E3120", VA = "0x1866E3F20")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x96D880", Offset = "0x96CA80", VA = "0x18096D880")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override JECBEPMPMHJ[] ONLJPPEEDPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x66E0930", Offset = "0x66DFB30", VA = "0x1866E0930", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override JECBEPMPMHJ[] FCFNHAMIKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x66E0DD0", Offset = "0x66DFFD0", VA = "0x1866E0DD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x66E0A10", Offset = "0x66DFC10", VA = "0x1866E0A10", Slot = "10")]
	public override void LABONIGBNGC(GNFJJEDLPLM AAGLHJMICLO, AECOLMNECLH MDKDFFMBEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public EFCLFFCJGEK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[FIHJOIBNOID(typeof(bool))]
internal class GHIGPNHEGBD : global::AAEJHHJNGED<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x66E2430", Offset = "0x66E1630", VA = "0x1866E2430", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x66E2520", Offset = "0x66E1720", VA = "0x1866E2520")]
	public GHIGPNHEGBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[FIHJOIBNOID(typeof(FixedString32))]
internal class OPPEDMGBEKA : global::AAEJHHJNGED<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class NPFPPOIBLOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public AECOLMNECLH ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NPFPPOIBLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x66E4010", Offset = "0x66E3210", VA = "0x1866E4010")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, KFBCGBKCDNN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class BKBELEGLHHK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public BKBELEGLHHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x66DE270", Offset = "0x66DD470", VA = "0x1866DE270")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x66DE2E0", Offset = "0x66DD4E0", VA = "0x1866DE2E0")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x66E4380", Offset = "0x66E3580", VA = "0x1866E4380", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x66E4440", Offset = "0x66E3640", VA = "0x1866E4440")]
	public OPPEDMGBEKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[FIHJOIBNOID(typeof(FixedString64))]
internal class JPKDEGNBGEJ : global::AAEJHHJNGED<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class DJHDIIMFMOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AECOLMNECLH ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DJHDIIMFMOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x66DFC60", Offset = "0x66DEE60", VA = "0x1866DFC60")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, KFBCGBKCDNN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class IMCGPAAJLBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public IMCGPAAJLBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x66E2AC0", Offset = "0x66E1CC0", VA = "0x1866E2AC0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x66E2B50", Offset = "0x66E1D50", VA = "0x1866E2B50")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x66E2D20", Offset = "0x66E1F20", VA = "0x1866E2D20", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x66E2DE0", Offset = "0x66E1FE0", VA = "0x1866E2DE0")]
	public JPKDEGNBGEJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[FIHJOIBNOID(typeof(float))]
internal class JJBHDHPGAMC : global::AAEJHHJNGED<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x66E2BF0", Offset = "0x66E1DF0", VA = "0x1866E2BF0", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x66E2CE0", Offset = "0x66E1EE0", VA = "0x1866E2CE0")]
	public JJBHDHPGAMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[FIHJOIBNOID(typeof(int))]
internal class KFKCFDIGKLF : global::AAEJHHJNGED<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x66E2F20", Offset = "0x66E2120", VA = "0x1866E2F20", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x66E3010", Offset = "0x66E2210", VA = "0x1866E3010")]
	public KFKCFDIGKLF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[FIHJOIBNOID(typeof(uint))]
internal class KIPMFJGJAGH : global::AAEJHHJNGED<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class NPKOLMCMHHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public AECOLMNECLH ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public NPKOLMCMHHE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x66E41A0", Offset = "0x66E33A0", VA = "0x1866E41A0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, KFBCGBKCDNN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class DEDLKCPFMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public DEDLKCPFMKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x66DFBB0", Offset = "0x66DEDB0", VA = "0x1866DFBB0")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x66DFC00", Offset = "0x66DEE00", VA = "0x1866DFC00")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x66E3CF0", Offset = "0x66E2EF0", VA = "0x1866E3CF0", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x66E3DB0", Offset = "0x66E2FB0", VA = "0x1866E3DB0")]
	public KIPMFJGJAGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[FIHJOIBNOID(typeof(Vector3))]
internal class KEMDLOBLBGA : global::AAEJHHJNGED<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class GIOIHJEGBKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public AECOLMNECLH ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public GIOIHJEGBKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x66E2560", Offset = "0x66E1760", VA = "0x1866E2560")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, KFBCGBKCDNN property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class AMHKBCOHFCE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
		public AMHKBCOHFCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x66DE050", Offset = "0x66DD250", VA = "0x1866DE050")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x66DE0B0", Offset = "0x66DD2B0", VA = "0x1866DE0B0")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x66DE0C0", Offset = "0x66DD2C0", VA = "0x1866DE0C0")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x66DE120", Offset = "0x66DD320", VA = "0x1866DE120")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x66DE130", Offset = "0x66DD330", VA = "0x1866DE130")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x66DE190", Offset = "0x66DD390", VA = "0x1866DE190")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x66E2E20", Offset = "0x66E2020", VA = "0x1866E2E20", Slot = "5")]
	protected override PIEIMEINHLK GAONDILPNNN(AECOLMNECLH MDKDFFMBEEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x66E2EE0", Offset = "0x66E20E0", VA = "0x1866E2EE0")]
	public KEMDLOBLBGA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct FFOEOFJNFFN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int PMDGFELCIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int CHECNPCHMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int LAGADKBKLAD;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class HAMNECNFPIG
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x66E28B0", Offset = "0x66E1AB0", VA = "0x1866E28B0")]
	public static void LPDNEJMDKMA(Type ADKFHIFHDHC, Type GPLHBBFDLGO)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct FBDKPFDHJFG
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x66E0EB0", Offset = "0x66E00B0", VA = "0x1866E0EB0")]
	public static NativeList<int> GHBLICJIOMP(GNFJJEDLPLM AAGLHJMICLO, MELJJCPNELB OIDGAMAOHHL)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x66E1090", Offset = "0x66E0290", VA = "0x1866E1090")]
	private static bool HCGGNMLFLEL(KFBCGBKCDNN IDBLFHOOMPH, GNFJJEDLPLM AAGLHJMICLO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class EFCKCBHHKCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly MELJJCPNELB OIDGAMAOHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly BPDDKPBGCMN AEBNJEGLADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly AECOLMNECLH MDKDFFMBEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<FFOEOFJNFFN> EDNGKHJOPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<PBKJFIBPHPK> KFDOMPFMONO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<PBKJFIBPHPK, List<FFOEOFJNFFN>> LMIPJIJPEOC;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x66E0810", Offset = "0x66DFA10", VA = "0x1866E0810")]
	public EFCKCBHHKCA(MELJJCPNELB OIDGAMAOHHL, BPDDKPBGCMN AEBNJEGLADB, AECOLMNECLH MDKDFFMBEEO, Action<FFOEOFJNFFN> EDNGKHJOPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x66DFE50", Offset = "0x66DF050", VA = "0x1866DFE50")]
	public void DFOFJKDDKDD(NativeList<FFOEOFJNFFN> DDEKNNINBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x66E06F0", Offset = "0x66DF8F0", VA = "0x1866E06F0")]
	private void POKLFNOLJGI(PBKJFIBPHPK CIFHMNKCLNG, FFOEOFJNFFN JJGPMDPEKPA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x66DFDF0", Offset = "0x66DEFF0", VA = "0x1866DFDF0")]
	public void CDDMJLBPLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x66E0270", Offset = "0x66DF470", VA = "0x1866E0270")]
	private void DNOIJEPKHAH(PBKJFIBPHPK CIFHMNKCLNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x66E01D0", Offset = "0x66DF3D0", VA = "0x1866E01D0")]
	private void DILJCJMPNAI(PBKJFIBPHPK CIFHMNKCLNG)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CGDKNMKPKIP(OOBCCNCEGNI.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class KHNDDBGMMLF : IEnumerable<KFBCGBKCDNN>, IEnumerable, IEnumerator<KFBCGBKCDNN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private KFBCGBKCDNN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private int <>l__initialThreadId;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public PropertiesByType <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			private Type type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public Type <>3__type;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private NativeMultiHashMap<long, int>.Enumerator <>7__wrap1;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			private KFBCGBKCDNN System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "6")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000086")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x873910", Offset = "0x872B10", VA = "0x180873910")]
			[DebuggerHidden]
			public KHNDDBGMMLF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x66E3C20", Offset = "0x66E2E20", VA = "0x1866E3C20", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x66E38E0", Offset = "0x66E2AE0", VA = "0x1866E38E0", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x66E3CA0", Offset = "0x66E2EA0", VA = "0x1866E3CA0")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x66E3BE0", Offset = "0x66E2DE0", VA = "0x1866E3BE0", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x66E3B30", Offset = "0x66E2D30", VA = "0x1866E3B30", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<KFBCGBKCDNN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x66E3B30", Offset = "0x66E2D30", VA = "0x1866E3B30", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly HDHIMOFHFJL AHADDDAMGKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly BPDDKPBGCMN AEBNJEGLADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> MPBPOBDKPPG;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x66E4660", Offset = "0x66E3860", VA = "0x1866E4660")]
		public PropertiesByType(BPDDKPBGCMN AEBNJEGLADB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x66E44C0", Offset = "0x66E36C0", VA = "0x1866E44C0")]
		[IteratorStateMachine(typeof(KHNDDBGMMLF))]
		public IEnumerable<KFBCGBKCDNN> KFMCFGALICD(Type NIFOGEBEDNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x66E4480", Offset = "0x66E3680", VA = "0x1866E4480", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x66E4550", Offset = "0x66E3750", VA = "0x1866E4550")]
		private long NIGIKNPDLKG(KFBCGBKCDNN IDBLFHOOMPH)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x66E45D0", Offset = "0x66E37D0", VA = "0x1866E45D0")]
		private long NIGIKNPDLKG(Type NIFOGEBEDNG)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct CAKPNBCEGJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray ANGPHKLDAJJ;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x66DEC50", Offset = "0x66DDE50", VA = "0x1866DEC50")]
	public CAKPNBCEGJK(int BFFJHKFEFPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x66DE960", Offset = "0x66DDB60", VA = "0x1866DE960")]
	public static CAKPNBCEGJK GDKEJKLMLJB(int FAPOEIDOLFP, NativeArray<int> BBBOEOJJCHM)
	{
		return default(CAKPNBCEGJK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x66DEC30", Offset = "0x66DDE30", VA = "0x1866DEC30")]
	public bool NJBMNLOLIEJ(int GMEHLIHLGEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x66DEC40", Offset = "0x66DDE40", VA = "0x1866DEC40")]
	public void PLCAKFAMFIL(int GMEHLIHLGEH, bool IPMIIEAGJKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x66DEB70", Offset = "0x66DDD70", VA = "0x1866DEB70")]
	public bool KKKDICCFPHB(KFBCGBKCDNN[] BBBOEOJJCHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x66DEAB0", Offset = "0x66DDCB0", VA = "0x1866DEAB0")]
	public bool JBCLLHLOMGA(KFBCGBKCDNN[] BBBOEOJJCHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x66DE950", Offset = "0x66DDB50", VA = "0x1866DE950", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class GAJFEPPGBDK
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly HDHIMOFHFJL AHADDDAMGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly MELJJCPNELB OIDGAMAOHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly BPDDKPBGCMN AEBNJEGLADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<BLCKCIENGCI> MCGPJIAEDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType MPBPOBDKPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> FECEAJHBGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> FCFAAOKGBLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool KBDIBPJIHNN;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<BLCKCIENGCI> BFCNDFCDCHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F6390", Offset = "0x6F5590", VA = "0x1806F6390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x66E22E0", Offset = "0x66E14E0", VA = "0x1866E22E0")]
	public GAJFEPPGBDK(MELJJCPNELB OIDGAMAOHHL, BPDDKPBGCMN AEBNJEGLADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x66E1270", Offset = "0x66E0470", VA = "0x1866E1270")]
	public void AFELIDKEEFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x66E1C00", Offset = "0x66E0E00", VA = "0x1866E1C00")]
	public void HDLCDAHPMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x66E1340", Offset = "0x66E0540", VA = "0x1866E1340")]
	public NativeList<FFOEOFJNFFN> BMLIBAOEKPA(NativeArray<int> BBBOEOJJCHM)
	{
		return default(NativeList<FFOEOFJNFFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x66E20F0", Offset = "0x66E12F0", VA = "0x1866E20F0")]
	private bool MLBONACHKNK(BLCKCIENGCI ODLEOLDOGEK, CAKPNBCEGJK JDOHMLKDLNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x149C520", Offset = "0x149B720", VA = "0x18149C520")]
	private void NIKPPHJIEJI<TInterface, TAttribute>(Action<TInterface, TAttribute> AEKOPFPIHNN) where TInterface : BLCKCIENGCI where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x66E20C0", Offset = "0x66E12C0", VA = "0x1866E20C0")]
	private void LFMLPCIIGFF(Type NIFOGEBEDNG, Type AIKFEIJLANB, Type KGLCKGJJIAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x149C4C0", Offset = "0x149B6C0", VA = "0x18149C4C0")]
	private TInterface NEBBHJBOLDL<TInterface>(Type NIFOGEBEDNG)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x66E21C0", Offset = "0x66E13C0", VA = "0x1866E21C0")]
	private void PHHJPLAIDHH(BLCKCIENGCI ODLEOLDOGEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66E1D70", Offset = "0x66E0F70", VA = "0x1866E1D70")]
	private int IALCAFEADMB(BLCKCIENGCI OCOKLGBMDOL, int LAGADKBKLAD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66E1E10", Offset = "0x66E1010", VA = "0x1866E1E10")]
	private void JEHMLFJMMJN(NHKMMIDKGON ODLEOLDOGEK, FIHJOIBNOID MPEFFCINAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x66E17A0", Offset = "0x66E09A0", VA = "0x1866E17A0")]
	private void COHHADPMPNB(HBHNPLLENCI ODLEOLDOGEK, BFBLINDMMBI MPEFFCINAGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x66E1A60", Offset = "0x66E0C60", VA = "0x1866E1A60")]
	private void FGKNJPHJIKK(LKDBJOCLPIA ODLEOLDOGEK, LEMBCEKGCEK MPEFFCINAGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct KHGNHNBDMAM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BPDDKPBGCMN AEBNJEGLADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<BLCKCIENGCI> MCGPJIAEDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<FFOEOFJNFFN> JGCGBOHNHGF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<FFOEOFJNFFN> IPNCMDLHFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x7DA2E0", Offset = "0x7D94E0", VA = "0x1807DA2E0")]
		get
		{
			return default(NativeList<FFOEOFJNFFN>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x66E3860", Offset = "0x66E2A60", VA = "0x1866E3860")]
	public KHGNHNBDMAM(BPDDKPBGCMN AEBNJEGLADB, List<BLCKCIENGCI> MCGPJIAEDJC, NativeArray<FFOEOFJNFFN> DDEKNNINBJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66E3190", Offset = "0x66E2390", VA = "0x1866E3190", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x66E31D0", Offset = "0x66E23D0", VA = "0x1866E31D0")]
	private NativeList<FFOEOFJNFFN> ECINHCELPKI(NativeArray<FFOEOFJNFFN> AOLADOEOHAL)
	{
		return default(NativeList<FFOEOFJNFFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x66E35D0", Offset = "0x66E27D0", VA = "0x1866E35D0")]
	private bool IKPLFAEEECP(BLCKCIENGCI ODLEOLDOGEK, CAKPNBCEGJK FNPHOADGKJJ, int CHECNPCHMLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x66E36A0", Offset = "0x66E28A0", VA = "0x1866E36A0")]
	private void NNODABCLMHL(BLCKCIENGCI ODLEOLDOGEK, CAKPNBCEGJK ANGPHKLDAJJ, int CHECNPCHMLA)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct LPMHAINIJOM : IComparer<FFOEOFJNFFN>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x66E4000", Offset = "0x66E3200", VA = "0x1866E4000", Slot = "4")]
	public int Compare(FFOEOFJNFFN NNMPJECKECI, FFOEOFJNFFN EFNJCAIBDLA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x66E3FB0", Offset = "0x66E31B0", VA = "0x1866E3FB0")]
	public static void BFGJAOCGAGD(NativeList<FFOEOFJNFFN> DDEKNNINBJM)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : HDLOHLLNPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x703EA0", Offset = "0x7030A0", VA = "0x180703EA0")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x66E4960", Offset = "0x66E3B60", VA = "0x1866E4960", Slot = "6")]
		public sealed override void FHPMCAKDNGP(DAOLJFMJMGL ONAFALABHKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x66E4A60", Offset = "0x66E3C60", VA = "0x1866E4A60", Slot = "4")]
		public sealed override void GAJKJBJLBCF()
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
