using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class BFEMNBEAKMC : LMHLLDFOKIL, KCEOLLMAHMG, NBIDLCIMEPL<Entity>, KAIMHEKEPCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public abstract Type LNPLBOHLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract CHENFBANGOH FENPDADLBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract PNDABCJFODF FKCMKCCEMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IHKCGNCLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9592D0", Offset = "0x9580D0", VA = "0x1809592D0", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9592C0", Offset = "0x9580C0", VA = "0x1809592C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event OPOBFABMEIP<Entity> NCFJKJBNEJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x621CD60", Offset = "0x621BB60", VA = "0x18621CD60", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x621CCB0", Offset = "0x621BAB0", VA = "0x18621CCB0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool NKPMKKDPBBC(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void DJGCEJBDGHO(Entity IBOBFMDOLFK, LDKPKFGPEFK DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool KNPAMBFMNAD(Entity IBOBFMDOLFK, MLNIKOGIMEN BHCBINIFLAJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void DCPEANAKOIB(CJMOIKEKLBA HBJPCBKDHFF, [Optional] object EJDIFPAIGMC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool KKGLAFBLIAH(Entity ANFNAKKPDIL, Entity EKLFCLOPJMB);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void HBPIHILNAPB(EntityManager BCAONBAACAD);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x26A7380", Offset = "0x26A6180", VA = "0x1826A7380")]
	protected void NEDGIFBPJBB<T>(Entity IBOBFMDOLFK, [In] T DKDBMCAAOMK, [In] T BHCBINIFLAJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string MNMOLENCOGN([In] MLNIKOGIMEN KDMLAONJODJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected BFEMNBEAKMC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public sealed class JGFAHCEHMCM<T> : BFEMNBEAKMC, MKFCJPCCCGI<T>, DPIBGEHDBEF<Entity, T>, NBIDLCIMEPL<Entity>, KAIMHEKEPCE, IDisposable, KCEOLLMAHMG, PNDABCJFODF where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate bool NFOJHHDKIGH(Entity IBOBFMDOLFK, [In] T BHCBINIFLAJ);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void KPBALOIBMEP(Entity IBOBFMDOLFK, [In] T DKDBMCAAOMK, [In] T BHCBINIFLAJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly CHENFBANGOH IMGBGPELIHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo CNBIEPDILJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int OIOKOFFMIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int PJPGJICIKPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int CGDBKIJPKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private NFOJHHDKIGH EMIFBOGIAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private KPBALOIBMEP PDBHOIHMOPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private KPBALOIBMEP ELGKIHFHELB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World BNCKCALLBDJ;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Type LNPLBOHLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3C222C0", Offset = "0x3C210C0", VA = "0x183C222C0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override CHENFBANGOH FENPDADLBDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override PNDABCJFODF FKCMKCCEMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FieldInfo PFNLCNIMHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int NMEBDNGNEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7CD780", Offset = "0x7CC580", VA = "0x1807CD780", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int FBOEBCBKDAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7BF240", Offset = "0x7BE040", VA = "0x1807BF240", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private EntityManager FBNPOHPPCMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x3C21140", Offset = "0x3C1FF40", VA = "0x183C21140")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3C28280", Offset = "0x3C27080", VA = "0x183C28280")]
	public JGFAHCEHMCM(string PHEKPMAPPHM, CHENFBANGOH IMGBGPELIHK, FieldInfo CNBIEPDILJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3C22C80", Offset = "0x3C21A80", VA = "0x183C22C80", Slot = "29")]
	public override void HBPIHILNAPB(EntityManager BCAONBAACAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3C22EE0", Offset = "0x3C21CE0", VA = "0x183C22EE0")]
	public JGFAHCEHMCM<T> KDPPHOOHJIH(NFOJHHDKIGH EMIFBOGIAAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3C21190", Offset = "0x3C1FF90", VA = "0x183C21190")]
	public JGFAHCEHMCM<T> DEOLECJLMPH(KPBALOIBMEP PDBHOIHMOPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3C22EC0", Offset = "0x3C21CC0", VA = "0x183C22EC0")]
	public JGFAHCEHMCM<T> HMIEAPDODEO(KPBALOIBMEP ELGKIHFHELB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3C220C0", Offset = "0x3C20EC0", VA = "0x183C220C0", Slot = "31")]
	public T DJGCEJBDGHO(Entity IBOBFMDOLFK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3C25530", Offset = "0x3C24330", VA = "0x183C25530")]
	public bool KNPAMBFMNAD(Entity IBOBFMDOLFK, [In] T BHCBINIFLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3C26DA0", Offset = "0x3C25BA0", VA = "0x183C26DA0")]
	public bool MGOAMNDKGNF(Entity IBOBFMDOLFK, [In] T BHCBINIFLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3C27830", Offset = "0x3C26630", VA = "0x183C27830", Slot = "23")]
	public override bool NKPMKKDPBBC(Entity IBOBFMDOLFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3C212F0", Offset = "0x3C200F0", VA = "0x183C212F0", Slot = "24")]
	public override void DJGCEJBDGHO(Entity IBOBFMDOLFK, LDKPKFGPEFK DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3C258F0", Offset = "0x3C246F0", VA = "0x183C258F0", Slot = "25")]
	public override bool KNPAMBFMNAD(Entity IBOBFMDOLFK, MLNIKOGIMEN BHCBINIFLAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3C21160", Offset = "0x3C1FF60", VA = "0x183C21160", Slot = "26")]
	public override void DCPEANAKOIB(CJMOIKEKLBA HBJPCBKDHFF, [Optional] object EJDIFPAIGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x3C22F00", Offset = "0x3C21D00", VA = "0x183C22F00", Slot = "27")]
	public override bool KKGLAFBLIAH(Entity ANFNAKKPDIL, Entity EKLFCLOPJMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3C27470", Offset = "0x3C26270", VA = "0x183C27470", Slot = "30")]
	public override string MNMOLENCOGN([In] MLNIKOGIMEN KDMLAONJODJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x3C22860", Offset = "0x3C21660", VA = "0x183C22860")]
	private bool GPOBLKCLAFD(T DKDBMCAAOMK, T BHCBINIFLAJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface KCEOLLMAHMG : NBIDLCIMEPL<Entity>, KAIMHEKEPCE, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface MKFCJPCCCGI<T> : DPIBGEHDBEF<Entity, T>, NBIDLCIMEPL<Entity>, KAIMHEKEPCE, IDisposable, KCEOLLMAHMG where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface LMHLLDFOKIL : KCEOLLMAHMG, NBIDLCIMEPL<Entity>, KAIMHEKEPCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int IHKCGNCLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class HHGLONAKDBB
{
	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x28E80A0", Offset = "0x28E6EA0", VA = "0x1828E80A0")]
	public static T CEFHKHLPLOF<T>(this MKFCJPCCCGI<T> CINANBNCBIJ, Entity IBOBFMDOLFK, [Optional] T OPPINNBBHIO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x28E8250", Offset = "0x28E7050", VA = "0x1828E8250")]
	public static T HCBNBLGHOHO<T>(this NBIDLCIMEPL<Entity> CINANBNCBIJ, Entity IBOBFMDOLFK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x28E7F40", Offset = "0x28E6D40", VA = "0x1828E7F40")]
	public static bool AFKLOOAJFMI<T>(this NBIDLCIMEPL<Entity> CINANBNCBIJ, Entity IBOBFMDOLFK, [In] T BHCBINIFLAJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void OPOBFABMEIP<TKey>(TKey EIFMADKIHON, [In] MLNIKOGIMEN DKDBMCAAOMK, [In] MLNIKOGIMEN BHCBINIFLAJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HJALLAHPFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x28E8B70", Offset = "0x28E7970", VA = "0x1828E8B70")]
	public static void HEPNPPEJLJB<TKey, T>(this OPOBFABMEIP<TKey> MDGGHFOMEDJ, TKey EIFMADKIHON, T DKDBMCAAOMK, T BHCBINIFLAJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CJMOIKEKLBA
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AMAMAAOENID<TKey, T>(DPIBGEHDBEF<TKey, T> CINANBNCBIJ, [Optional] object EJDIFPAIGMC) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface KLGOOMDGBAH
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface PNDABCJFODF
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo BHLDGBHNKOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int AKOMBCBOHAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int EDOPLBKMBBH
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface KAIMHEKEPCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string HFBLFDGJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type LNPLBOHLOBB
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	PNDABCJFODF FKCMKCCEMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	CHENFBANGOH FENPDADLBDO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int IHKCGNCLBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DCPEANAKOIB(CJMOIKEKLBA HBJPCBKDHFF, [Optional] object EJDIFPAIGMC);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NBIDLCIMEPL<TKey> : KAIMHEKEPCE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event OPOBFABMEIP<TKey> NCFJKJBNEJH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NKPMKKDPBBC(TKey OBPLDLNDJLE);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DJGCEJBDGHO(TKey OBPLDLNDJLE, LDKPKFGPEFK DIBNBLEEFNN);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool KNPAMBFMNAD(TKey OBPLDLNDJLE, MLNIKOGIMEN BHCBINIFLAJ);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KKGLAFBLIAH(TKey ANFNAKKPDIL, TKey EKLFCLOPJMB);

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string MNMOLENCOGN([In] MLNIKOGIMEN DIBNBLEEFNN);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public interface DPIBGEHDBEF<TKey, T> : NBIDLCIMEPL<TKey>, KAIMHEKEPCE, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T DJGCEJBDGHO(TKey OBPLDLNDJLE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class HLJJNOCGJDN
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x28EAC50", Offset = "0x28E9A50", VA = "0x1828EAC50")]
	public static bool HIBEGIGNEIP<TKey, T>(this NBIDLCIMEPL<TKey> CINANBNCBIJ, TKey OBPLDLNDJLE, [Out] T DIBNBLEEFNN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x28EA580", Offset = "0x28E9380", VA = "0x1828EA580")]
	public static T DJGCEJBDGHO<T, TKey>(this NBIDLCIMEPL<TKey> CINANBNCBIJ, TKey OBPLDLNDJLE) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x28EAE00", Offset = "0x28E9C00", VA = "0x1828EAE00")]
	public static bool KNPAMBFMNAD<TKey, T>(this NBIDLCIMEPL<TKey> CINANBNCBIJ, TKey OBPLDLNDJLE, T BHCBINIFLAJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface FJOBEKPCIHJ : IEnumerable<KCEOLLMAHMG>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface CHENFBANGOH
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int LJGLDMEJDHG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int GFACBJFGBJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type KCCHIIFALLK
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	KCEOLLMAHMG[] GEIIIHNKIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) KJGAINBHMJG(Entity IBOBFMDOLFK);

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KKNDHIJHCAF(Entity IBOBFMDOLFK, (uint order, uint change) MIJEJKOAIDK);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class GCDKMFBMGAG : FJOBEKPCIHJ, IEnumerable<KCEOLLMAHMG>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<KCEOLLMAHMG> HIJHPJJKLKI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x621D370", Offset = "0x621C170", VA = "0x18621D370", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public KCEOLLMAHMG OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x621D310", Offset = "0x621C110", VA = "0x18621D310", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x621D3B0", Offset = "0x621C1B0", VA = "0x18621D3B0")]
	public GCDKMFBMGAG(IEnumerable<CHENFBANGOH> BOLFMHOLGHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x621CE90", Offset = "0x621BC90", VA = "0x18621CE90")]
	private List<KCEOLLMAHMG> KKGALGPCDEO(IEnumerable<CHENFBANGOH> BOLFMHOLGHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x621CE10", Offset = "0x621BC10", VA = "0x18621CE10", Slot = "4")]
	public IEnumerator<KCEOLLMAHMG> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x621CE10", Offset = "0x621BC10", VA = "0x18621CE10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct OEOPJAPPBLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type GIFILHMLAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string PHEKPMAPPHM;

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
	public OEOPJAPPBLH(Type GIFILHMLAOO, string PHEKPMAPPHM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct INGFHJHDPPO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type GIFILHMLAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string PHEKPMAPPHM;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x93C520", Offset = "0x93B320", VA = "0x18093C520")]
	public INGFHJHDPPO(Type GIFILHMLAOO, string PHEKPMAPPHM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x3A97940", Offset = "0x3A96740", VA = "0x183A97940")]
	public static OEOPJAPPBLH OOOLBNFONKL(INGFHJHDPPO<T> LOOCKFEEHLM)
	{
		return default(OEOPJAPPBLH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum JEINOPIDLBB
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	External = -6
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class LDJNHENMGAB
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public LDJNHENMGAB()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class __BB_OBFUSCATOR_VERSION_3_10_0
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
