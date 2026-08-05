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
internal abstract class LGCMPGJJEHG : global::AOODIBAEAOK<Enum>, EODBFMNGIJL, DEBMLKFOMCC, EIMLIMFOGIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "9")]
	public abstract bool GHIFFOMDAIO(Type MAIOHDHBGKE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6572A50", Offset = "0x6571850", VA = "0x186572A50")]
	protected LGCMPGJJEHG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
internal abstract class AOODIBAEAOK<T> : DEBMLKFOMCC, EIMLIMFOGIL where T : Enum
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	protected delegate void LHHGHNONGBE(Func<T> ONFFKKCDBBF, Action<T> INAHGNNJAEA, string EOPECGOILOC, HFFBKOKLMCH PEJFAKHLGCN, Func<bool> HPMNDMHLIEI);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	protected delegate void PLFPFMPKCHC(Func<int> ONFFKKCDBBF, Action<int> INAHGNNJAEA, string EOPECGOILOC, HFFBKOKLMCH PEJFAKHLGCN, Func<bool> HPMNDMHLIEI);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	[CompilerGenerated]
	private sealed class KPFCGIJCMAA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public OMPPKAOKMDG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HFFBKOKLMCH property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public KPFCGIJCMAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9B30", Offset = "0x2EF8930", VA = "0x182EF9B30")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x2EF9BD0", Offset = "0x2EF89D0", VA = "0x182EF9BD0")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private sealed class BKLBOCNAHLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public global::AOODIBAEAOK<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public GAJCEMJEPAF ui;

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public BKLBOCNAHLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x2984960", Offset = "0x2983760", VA = "0x182984960")]
		internal void <GetHandler>b__0(Func<T> get, Action<T> set, string name, HFFBKOKLMCH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[CompilerGenerated]
	private sealed class MBLALHAHAPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public Func<T> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public Action<T> set;

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public MBLALHAHAPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x35E2F80", Offset = "0x35E1D80", VA = "0x1835E2F80")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x35E3170", Offset = "0x35E1F70", VA = "0x1835E3170")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3B7E2B0", Offset = "0x3B7D0B0", VA = "0x183B7E2B0")]
	protected AOODIBAEAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DE80", Offset = "0x3B7CC80", VA = "0x183B7DE80", Slot = "5")]
	public virtual void FJFOBHJMMDF(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN, GAJCEMJEPAF MMOPPGDICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DA30", Offset = "0x3B7C830", VA = "0x183B7DA30", Slot = "6")]
	protected virtual LHHGHNONGBE BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D990", Offset = "0x3B7C790", VA = "0x183B7D990", Slot = "7")]
	protected virtual PLFPFMPKCHC AAABILEBAJP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x3B7DB30", Offset = "0x3B7C930", VA = "0x183B7DB30")]
	private static Enum CADODKPLGJM(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B7E0D0", Offset = "0x3B7CED0", VA = "0x183B7E0D0")]
	private static void HNDOMIAJBLD(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN, Enum NLHFEJHKLAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
internal abstract class CNEKGEHNMLG : PFAGLPHLJKA, EIMLIMFOGIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private HFFBKOKLMCH[] LDPBAFBOLBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HFFBKOKLMCH[] JOFBCMIIAJF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HFFBKOKLMCH[] FJOIOMJAOJN
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public HFFBKOKLMCH[] AIGLBFHJBHP
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	protected abstract DHKEKNILOEA[] ANMKJCNPDCA
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	protected abstract DHKEKNILOEA[] INEMDNJGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6570D50", Offset = "0x656FB50", VA = "0x186570D50", Slot = "6")]
	public void KKLPLLLGLNM(HIAEEIHDIIB IKCMBGMJLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	public abstract void FJFOBHJMMDF(OMPPKAOKMDG MDFBEMBBHPF, GAJCEMJEPAF MMOPPGDICED);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x268F1B0", Offset = "0x268DFB0", VA = "0x18268F1B0")]
	protected static T MJAIPCOBBAC<T>(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x268F0E0", Offset = "0x268DEE0", VA = "0x18268F0E0")]
	protected static void JJJMDFHHDPK<T>(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN, T NLHFEJHKLAH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	protected CNEKGEHNMLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal abstract class BHHLJDIEFPJ<T> : DEBMLKFOMCC, EIMLIMFOGIL where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	protected delegate void BPEPNFEHMOL(Func<T> ONFFKKCDBBF, Action<T> INAHGNNJAEA, string EOPECGOILOC, HFFBKOKLMCH PEJFAKHLGCN, Func<bool> HPMNDMHLIEI);

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class FCFLEFHEKKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public OMPPKAOKMDG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public HFFBKOKLMCH property;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x18DAC40", Offset = "0x18D9A40", VA = "0x1818DAC40")]
		public FCFLEFHEKKB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x37B53C0", Offset = "0x37B41C0", VA = "0x1837B53C0")]
		internal T <CreateUI>b__0()
		{
			return (T)null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x37B5680", Offset = "0x37B4480", VA = "0x1837B5680")]
		internal void <CreateUI>b__1(T value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x2982560", Offset = "0x2981360", VA = "0x182982560")]
	protected BHHLJDIEFPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2980D30", Offset = "0x297FB30", VA = "0x182980D30", Slot = "4")]
	public void FJFOBHJMMDF(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN, GAJCEMJEPAF MMOPPGDICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED);

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x29821C0", Offset = "0x2980FC0", VA = "0x1829821C0")]
	private static T MJAIPCOBBAC(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x29820B0", Offset = "0x2980EB0", VA = "0x1829820B0")]
	private static void JJJMDFHHDPK(OMPPKAOKMDG MDFBEMBBHPF, HFFBKOKLMCH PEJFAKHLGCN, T NLHFEJHKLAH)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[IDOCBBAEIFB(JHEANMHFGAO.ConfigUI)]
	[IHOFDNBJLIN(typeof(JCDBDBICHEO), new string[] { })]
	internal class ConfigUIService : JCDBDBICHEO, OMEPFIBEFCP, GLCKJEOBJPN, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		[CEFONNIACOK]
		private HIAEEIHDIIB IKCMBGMJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		[CEFONNIACOK]
		private LGAEEHKGJMJ KECPGEGHHNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		[CEFONNIACOK]
		private GAJCEMJEPAF LCFDGLCCAEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private GKPAPKJIJJE OHIDBEBGMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private OMPPKAOKMDG MDFBEMBBHPF;

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6571E00", Offset = "0x6570C00", VA = "0x186571E00", Slot = "5")]
		public void PIFNIFBDCBM(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6571A70", Offset = "0x6570870", VA = "0x186571A70", Slot = "6")]
		public void KGGCGLDLAMK(AACHPGDKAKL PIMEDEKHCHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x65716D0", Offset = "0x65704D0", VA = "0x1865716D0", Slot = "7")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6571160", Offset = "0x656FF60", VA = "0x186571160", Slot = "4")]
		public void BLMKHIBLIFH(OMPPKAOKMDG PEJGAPBIOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6571D70", Offset = "0x6570B70", VA = "0x186571D70")]
		private void NNBEOMDNEFP(OMPPKAOKMDG PEJGAPBIOBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6571A40", Offset = "0x6570840", VA = "0x186571A40")]
		private void GBLPALMAMOD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x65717C0", Offset = "0x65705C0", VA = "0x1865717C0")]
		private void FJFOBHJMMDF(NCEOKIIPABK CKCFNCLIONI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public ConfigUIService()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HMPJCFEHHPA(0)]
internal class FBIBNDPMDGL : LGCMPGJJEHG
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x65729A0", Offset = "0x65717A0", VA = "0x1865729A0", Slot = "9")]
	public override bool GHIFFOMDAIO(Type MAIOHDHBGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x65728B0", Offset = "0x65716B0", VA = "0x1865728B0", Slot = "6")]
	protected override LHHGHNONGBE BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6572A50", Offset = "0x6571850", VA = "0x186572A50")]
	public FBIBNDPMDGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[HMPJCFEHHPA(0)]
internal class IJKDDCJLIJM : LGCMPGJJEHG
{
	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6575190", Offset = "0x6573F90", VA = "0x186575190", Slot = "9")]
	public override bool GHIFFOMDAIO(Type MAIOHDHBGKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x65750A0", Offset = "0x6573EA0", VA = "0x1865750A0", Slot = "6")]
	protected override LHHGHNONGBE BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6572A50", Offset = "0x6571850", VA = "0x186572A50")]
	public IJKDDCJLIJM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[ILKPDAMNOFI(typeof(FHILLDEEAPH), 1)]
internal class FBKAODMOFKC : global::AOODIBAEAOK<FHILLDEEAPH>
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6572A90", Offset = "0x6571890", VA = "0x186572A90", Slot = "7")]
	protected override PLFPFMPKCHC AAABILEBAJP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6572B80", Offset = "0x6571980", VA = "0x186572B80")]
	public FBKAODMOFKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class NGFBCFDHAHG
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6576950", Offset = "0x6575750", VA = "0x186576950")]
	public static bool LILFGPJDCKF(this HFFBKOKLMCH PEJFAKHLGCN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[DLIONNMFAOO(2)]
internal class GGFIKOJLALB : CNEKGEHNMLG
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	[CompilerGenerated]
	private sealed class FJMDFIGBHBC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public OMPPKAOKMDG targets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public GGFIKOJLALB <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public bool isEnabled;

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public FJMDFIGBHBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6572CF0", Offset = "0x6571AF0", VA = "0x186572CF0")]
		internal (int, int) <CreateUI>b__0()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x6572E20", Offset = "0x6571C20", VA = "0x186572E20")]
		internal void <CreateUI>b__1((int color, int material) value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x894FC0", Offset = "0x893DC0", VA = "0x180894FC0")]
		internal bool <CreateUI>b__2()
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	protected override DHKEKNILOEA[] INEMDNJGJOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x6572FE0", Offset = "0x6571DE0", VA = "0x186572FE0", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	protected override DHKEKNILOEA[] ANMKJCNPDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x65730C0", Offset = "0x6571EC0", VA = "0x1865730C0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x65731A0", Offset = "0x6571FA0", VA = "0x1865731A0", Slot = "10")]
	public override void FJFOBHJMMDF(OMPPKAOKMDG MDFBEMBBHPF, GAJCEMJEPAF MMOPPGDICED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public GGFIKOJLALB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[ILKPDAMNOFI(typeof(bool))]
internal class FIHPNEAOKJD : global::BHHLJDIEFPJ<bool>
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6572BC0", Offset = "0x65719C0", VA = "0x186572BC0", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6572CB0", Offset = "0x6571AB0", VA = "0x186572CB0")]
	public FIHPNEAOKJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[ILKPDAMNOFI(typeof(FixedString32))]
internal class AOIICBDAJMI : global::BHHLJDIEFPJ<FixedString32>
{
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	[CompilerGenerated]
	private sealed class KDMFCEAKNBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public GAJCEMJEPAF ui;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KDMFCEAKNBA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6575B90", Offset = "0x6574990", VA = "0x186575B90")]
		internal void <GetHandler>b__0(Func<FixedString32> get, Action<FixedString32> set, string name, HFFBKOKLMCH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	[CompilerGenerated]
	private sealed class LDLGPBPPGOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public Func<FixedString32> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public Action<FixedString32> set;

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public LDLGPBPPGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x6575D20", Offset = "0x6574B20", VA = "0x186575D20")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6575D90", Offset = "0x6574B90", VA = "0x186575D90")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6570A70", Offset = "0x656F870", VA = "0x186570A70", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6570B30", Offset = "0x656F930", VA = "0x186570B30")]
	public AOIICBDAJMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[ILKPDAMNOFI(typeof(FixedString64))]
internal class CGJNHDOOOEI : global::BHHLJDIEFPJ<FixedString64>
{
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private sealed class KDKAFEEBOGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public GAJCEMJEPAF ui;

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public KDKAFEEBOGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6575A00", Offset = "0x6574800", VA = "0x186575A00")]
		internal void <GetHandler>b__0(Func<FixedString64> get, Action<FixedString64> set, string name, HFFBKOKLMCH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	[CompilerGenerated]
	private sealed class GCMJGOLINMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public Func<FixedString64> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public Action<FixedString64> set;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public GCMJGOLINMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6572EB0", Offset = "0x6571CB0", VA = "0x186572EB0")]
		internal string <GetHandler>b__1()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6572F40", Offset = "0x6571D40", VA = "0x186572F40")]
		internal void <GetHandler>b__2(string value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6570C50", Offset = "0x656FA50", VA = "0x186570C50", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6570D10", Offset = "0x656FB10", VA = "0x186570D10")]
	public CGJNHDOOOEI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[ILKPDAMNOFI(typeof(float))]
internal class HJOIMGIBIKL : global::BHHLJDIEFPJ<float>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6574720", Offset = "0x6573520", VA = "0x186574720", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6574810", Offset = "0x6573610", VA = "0x186574810")]
	public HJOIMGIBIKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[ILKPDAMNOFI(typeof(int))]
internal class PFFPAEANGBI : global::BHHLJDIEFPJ<int>
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6576A90", Offset = "0x6575890", VA = "0x186576A90", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6576B80", Offset = "0x6575980", VA = "0x186576B80")]
	public PFFPAEANGBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
[ILKPDAMNOFI(typeof(uint))]
internal class IFKLPIKCFGF : global::BHHLJDIEFPJ<uint>
{
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	[CompilerGenerated]
	private sealed class PFKGLGLNOOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GAJCEMJEPAF ui;

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public PFKGLGLNOOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6576BC0", Offset = "0x65759C0", VA = "0x186576BC0")]
		internal void <GetHandler>b__0(Func<uint> get, Action<uint> set, string name, HFFBKOKLMCH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	[CompilerGenerated]
	private sealed class IOFEAIPGGGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public Func<uint> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public Action<uint> set;

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public IOFEAIPGGGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6575240", Offset = "0x6574040", VA = "0x186575240")]
		internal int <GetHandler>b__1()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6575290", Offset = "0x6574090", VA = "0x186575290")]
		internal void <GetHandler>b__2(int value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6574B90", Offset = "0x6573990", VA = "0x186574B90", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6574C50", Offset = "0x6573A50", VA = "0x186574C50")]
	public IFKLPIKCFGF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[ILKPDAMNOFI(typeof(Vector3))]
internal class AGADAIAPAML : global::BHHLJDIEFPJ<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class JHPIGGEAHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public GAJCEMJEPAF ui;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public JHPIGGEAHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x65756B0", Offset = "0x65744B0", VA = "0x1865756B0")]
		internal void <GetHandler>b__0(Func<Vector3> get, Action<Vector3> set, string name, HFFBKOKLMCH property, Func<bool> isEnabled)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class DPIGEGDHLEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public Func<Vector3> get;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public Action<Vector3> set;

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
		public DPIGEGDHLEL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x6571EE0", Offset = "0x6570CE0", VA = "0x186571EE0")]
		internal float <GetHandler>b__1()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6571F40", Offset = "0x6570D40", VA = "0x186571F40")]
		internal void <GetHandler>b__2(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x6571F50", Offset = "0x6570D50", VA = "0x186571F50")]
		internal float <GetHandler>b__3()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x6571FB0", Offset = "0x6570DB0", VA = "0x186571FB0")]
		internal void <GetHandler>b__4(float value)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x6571FC0", Offset = "0x6570DC0", VA = "0x186571FC0")]
		internal float <GetHandler>b__5()
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6572020", Offset = "0x6570E20", VA = "0x186572020")]
		internal void <GetHandler>b__6(float value)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6570970", Offset = "0x656F770", VA = "0x186570970", Slot = "5")]
	protected override BPEPNFEHMOL BNKANIPOHMP(GAJCEMJEPAF MMOPPGDICED)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6570A30", Offset = "0x656F830", VA = "0x186570A30")]
	public AGADAIAPAML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal struct NCEOKIIPABK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public int PBOEMKINGNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public int HCJDCAGFBCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int PEOIJCAMOPO;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal static class CAHEKOCJJEK
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6570B70", Offset = "0x656F970", VA = "0x186570B70")]
	public static void MJDJHAINGJD(Type FJEIGMMGOCD, Type EKIHJFFAEMN)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal struct JHJJBHNKBCP
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x65752F0", Offset = "0x65740F0", VA = "0x1865752F0")]
	public static NativeList<int> CJNAAIMOHJL(OMPPKAOKMDG MDFBEMBBHPF, LGAEEHKGJMJ KECPGEGHHNF)
	{
		return default(NativeList<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x65754D0", Offset = "0x65742D0", VA = "0x1865754D0")]
	private static bool PLPPNLNKJLD(HFFBKOKLMCH PEJFAKHLGCN, OMPPKAOKMDG MDFBEMBBHPF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
internal class LJFLKKAPDAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private readonly LGAEEHKGJMJ KECPGEGHHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HIAEEIHDIIB IKCMBGMJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly GAJCEMJEPAF MMOPPGDICED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly Action<NCEOKIIPABK> FIENMJCGMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HashSet<HDDDDGJLPGP> NOFJEADDMME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly Dictionary<HDDDDGJLPGP, List<NCEOKIIPABK>> DOIJJPHPGFD;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6576830", Offset = "0x6575630", VA = "0x186576830")]
	public LJFLKKAPDAG(LGAEEHKGJMJ KECPGEGHHNF, HIAEEIHDIIB IKCMBGMJLFD, GAJCEMJEPAF MMOPPGDICED, Action<NCEOKIIPABK> FIENMJCGMJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6575EB0", Offset = "0x6574CB0", VA = "0x186575EB0")]
	public void BJEEDOBCLLL(NativeList<NCEOKIIPABK> JNBPGANCHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6576710", Offset = "0x6575510", VA = "0x186576710")]
	private void PGBEKLHAAGB(HDDDDGJLPGP BNOLJGPLJNB, NCEOKIIPABK CKCFNCLIONI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x65766B0", Offset = "0x65754B0", VA = "0x1865766B0")]
	public void OHMMHEGJIIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6576230", Offset = "0x6575030", VA = "0x186576230")]
	private void DOHJILFIKHP(HDDDDGJLPGP BNOLJGPLJNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6575E10", Offset = "0x6574C10", VA = "0x186575E10")]
	private void AEOBAHLPPLN(HDDDDGJLPGP BNOLJGPLJNB)
	{
	}
}
namespace RecRoom.ObjectModel.ConfigUI
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[IDOCBBAEIFB(JHEANMHFGAO.ConfigUI)]
	internal class PropertiesByType : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		[CompilerGenerated]
		private sealed class IIHCCHGKDGD : IEnumerable<HFFBKOKLMCH>, IEnumerable, IEnumerator<HFFBKOKLMCH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private HFFBKOKLMCH <>2__current;

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
			private HFFBKOKLMCH System.Collections.Generic.IEnumerator<RecRoom.ObjectModel.IObjectProperty>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000084")]
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "6")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "9")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0x793410", Offset = "0x792210", VA = "0x180793410")]
			[DebuggerHidden]
			public IIHCCHGKDGD(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0x6574FD0", Offset = "0x6573DD0", VA = "0x186574FD0", Slot = "7")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x6574C90", Offset = "0x6573A90", VA = "0x186574C90", Slot = "8")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x6575050", Offset = "0x6573E50", VA = "0x186575050")]
			private void <>m__Finally1()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x6574F90", Offset = "0x6573D90", VA = "0x186574F90", Slot = "10")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0x6574EE0", Offset = "0x6573CE0", VA = "0x186574EE0", Slot = "4")]
			[DebuggerHidden]
			private IEnumerator<HFFBKOKLMCH> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.IObjectProperty>.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x6574EE0", Offset = "0x6573CE0", VA = "0x186574EE0", Slot = "5")]
			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private static readonly JFPIEAPAMJM MCHCOEKKPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private readonly HIAEEIHDIIB IKCMBGMJLFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private NativeMultiHashMap<long, int> PKBCFOIFFCL;

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6576F80", Offset = "0x6575D80", VA = "0x186576F80")]
		public PropertiesByType(HIAEEIHDIIB IKCMBGMJLFD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6576DE0", Offset = "0x6575BE0", VA = "0x186576DE0")]
		[IteratorStateMachine(typeof(IIHCCHGKDGD))]
		public IEnumerable<HFFBKOKLMCH> LPOEPMBCFAC(Type MAIOHDHBGKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x6576DA0", Offset = "0x6575BA0", VA = "0x186576DA0", Slot = "4")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6576EB0", Offset = "0x6575CB0", VA = "0x186576EB0")]
		private long MADODNHCNKH(HFFBKOKLMCH PEJFAKHLGCN)
		{
			return default(long);
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6576E70", Offset = "0x6575C70", VA = "0x186576E70")]
		private long MADODNHCNKH(Type MAIOHDHBGKE)
		{
			return default(long);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
internal struct HMCAGPJPBGK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private NativeBitArray KJBCJMDADHA;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6574B50", Offset = "0x6573950", VA = "0x186574B50")]
	public HMCAGPJPBGK(int PHHDFCFDFMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6574860", Offset = "0x6573660", VA = "0x186574860")]
	public static HMCAGPJPBGK GBOHIJLLKND(int FPMMBKCOHLA, NativeArray<int> KELFDPANAFC)
	{
		return default(HMCAGPJPBGK);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x65749B0", Offset = "0x65737B0", VA = "0x1865749B0")]
	public bool GKBGONHPONF(int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6574B40", Offset = "0x6573940", VA = "0x186574B40")]
	public void NIPKJFNBLBF(int CPOAAGLEIPE, bool NLHFEJHKLAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6574A80", Offset = "0x6573880", VA = "0x186574A80")]
	public bool JEEABPDBMCN(HFFBKOKLMCH[] KELFDPANAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x65749C0", Offset = "0x65737C0", VA = "0x1865749C0")]
	public bool IABNEOGPPJP(HFFBKOKLMCH[] KELFDPANAFC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6574850", Offset = "0x6573650", VA = "0x186574850", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
internal class GKPAPKJIJJE
{
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static readonly JFPIEAPAMJM MCHCOEKKPGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly LGAEEHKGJMJ KECPGEGHHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly HIAEEIHDIIB IKCMBGMJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly List<EIMLIMFOGIL> ADOADBDAAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private readonly PropertiesByType PKBCFOIFFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private NativeMultiHashMap<int, int> FCGPJPPIFHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private NativeList<int> AJNECAGIDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private bool LKLAHNKMKAI;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public List<EIMLIMFOGIL> KBNOEHGKAAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x65745D0", Offset = "0x65733D0", VA = "0x1865745D0")]
	public GKPAPKJIJJE(LGAEEHKGJMJ KECPGEGHHNF, HIAEEIHDIIB IKCMBGMJLFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6574480", Offset = "0x6573280", VA = "0x186574480")]
	public void HNJHICBJAJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6573560", Offset = "0x6572360", VA = "0x186573560")]
	public void BNELBEGBDND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6573AB0", Offset = "0x65728B0", VA = "0x186573AB0")]
	public NativeList<NCEOKIIPABK> EJMABBFGEBG(NativeArray<int> KELFDPANAFC)
	{
		return default(NativeList<NCEOKIIPABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6573840", Offset = "0x6572640", VA = "0x186573840")]
	private bool DDFGBFBABDM(EIMLIMFOGIL EJKCLMFHFMG, HMCAGPJPBGK LEIFHLHMFMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x228EF90", Offset = "0x228DD90", VA = "0x18228EF90")]
	private void JFPHLNNANJO<TInterface, TAttribute>(Action<TInterface, TAttribute> CGLPJIONAAJ) where TInterface : EIMLIMFOGIL where TAttribute : Attribute
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6574550", Offset = "0x6573350", VA = "0x186574550")]
	private void LICMOOAOFDE(Type MAIOHDHBGKE, Type HMICOJLGLDB, Type GFHOALODJIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x228EF30", Offset = "0x228DD30", VA = "0x18228EF30")]
	private TInterface DFCBOCNBDNK<TInterface>(Type MAIOHDHBGKE)
	{
		return (TInterface)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x65736D0", Offset = "0x65724D0", VA = "0x1865736D0")]
	private void CBNAOIKOADF(EIMLIMFOGIL EJKCLMFHFMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x65737A0", Offset = "0x65725A0", VA = "0x1865737A0")]
	private int DDEODJAFNED(EIMLIMFOGIL FDGPMNJHKBG, int PEOIJCAMOPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6573F10", Offset = "0x6572D10", VA = "0x186573F10")]
	private void ELMHDBGLAOM(DEBMLKFOMCC EJKCLMFHFMG, ILKPDAMNOFI JEBIFFGKIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x65741C0", Offset = "0x6572FC0", VA = "0x1865741C0")]
	private void EMJHHCHFJED(EODBFMNGIJL EJKCLMFHFMG, HMPJCFEHHPA JEBIFFGKIKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6573910", Offset = "0x6572710", VA = "0x186573910")]
	private void EFLGHHOLPEM(PFAGLPHLJKA EJKCLMFHFMG, DLIONNMFAOO JEBIFFGKIKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal struct EGMBAAEIBCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly HIAEEIHDIIB IKCMBGMJLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly List<EIMLIMFOGIL> ADOADBDAAMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private NativeList<NCEOKIIPABK> JEDIOMMFINO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NativeList<NCEOKIIPABK> JGBELIGFMOG
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x73BC90", Offset = "0x73AA90", VA = "0x18073BC90")]
		get
		{
			return default(NativeList<NCEOKIIPABK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x65727D0", Offset = "0x65715D0", VA = "0x1865727D0")]
	public EGMBAAEIBCJ(HIAEEIHDIIB IKCMBGMJLFD, List<EIMLIMFOGIL> ADOADBDAAMN, NativeArray<NCEOKIIPABK> JNBPGANCHBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6572500", Offset = "0x6571300", VA = "0x186572500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6572100", Offset = "0x6570F00", VA = "0x186572100")]
	private NativeList<NCEOKIIPABK> DBFAAHBBADC(NativeArray<NCEOKIIPABK> KAMLGMPAFNE)
	{
		return default(NativeList<NCEOKIIPABK>);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6572540", Offset = "0x6571340", VA = "0x186572540")]
	private bool JJKBJCPPOBE(EIMLIMFOGIL EJKCLMFHFMG, HMCAGPJPBGK EMBIDBBECJD, int HCJDCAGFBCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6572610", Offset = "0x6571410", VA = "0x186572610")]
	private void OGGKLBHIMAP(EIMLIMFOGIL EJKCLMFHFMG, HMCAGPJPBGK KJBCJMDADHA, int HCJDCAGFBCE)
	{
	}
}
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x200002C")]
internal struct EKOGJAKNABJ : IComparer<NCEOKIIPABK>
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6572850", Offset = "0x6571650", VA = "0x186572850", Slot = "4")]
	public int Compare(NCEOKIIPABK FEIPFLDEPBD, NCEOKIIPABK MIECAKFJHNF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6572860", Offset = "0x6571660", VA = "0x186572860")]
	public static void KOHGINEFLIA(NativeList<NCEOKIIPABK> JNBPGANCHBG)
	{
	}
}
namespace RRAssemblyIndex.RecRoom.ObjectModel.ConfigUI.Runtime
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	[Preserve]
	internal class _RRAssemblyIndex : GIHBEMJPMJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x718780", Offset = "0x717580", VA = "0x180718780")]
		[Preserve]
		public _RRAssemblyIndex()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6577280", Offset = "0x6576080", VA = "0x186577280", Slot = "6")]
		public sealed override void HAGKABNBGAM(BFAIPCIBIIK JDLJMIHPPKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6577380", Offset = "0x6576180", VA = "0x186577380", Slot = "4")]
		public sealed override void HLFKGNEPEFG()
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
