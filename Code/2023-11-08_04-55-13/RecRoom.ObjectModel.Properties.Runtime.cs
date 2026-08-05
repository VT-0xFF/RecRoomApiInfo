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
public abstract class JLOGELHDDNG : PPDBCLKCGDD, GBBBMNOIKNN, MJKCPOHAALI<Entity>, NKHIPPPEKLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public abstract Type OIIFFAPKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public abstract HAAIIOGFDHE LIMFOBLBEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public abstract OBMOEIEEAFP HKHDLEBPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x770C70", Offset = "0x76FA70", VA = "0x180770C70")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CAOCDCFPGCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x863AD0", Offset = "0x8628D0", VA = "0x180863AD0", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x863AB0", Offset = "0x8628B0", VA = "0x180863AB0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DPNIPJLKBIC<Entity> FJKLGIFGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4880", Offset = "0x5EE3680", VA = "0x185EE4880", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4930", Offset = "0x5EE3730", VA = "0x185EE4930", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool ELLDGLBOGGN(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void HFNEOIKDHBA(Entity OEEKGABNFEP, BBGHDLICAGJ PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool CCOBHHAAMMF(Entity OEEKGABNFEP, PJHPAJAPHOI IBLOAPAOIFJ);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void PCDDBKBHIIM(CEKJKJACHBP NFOOEIFNJOL, [Optional] object GMIADHJEACD);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool KLIGLKFNLOP(Entity LLIDMGAMJNA, Entity JPKEGLEDKEC);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void CAKCEPELMIL(EntityManager FOMHILNOHEE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x253CE10", Offset = "0x253BC10", VA = "0x18253CE10")]
	protected void DHJDIIOBNCH<T>(Entity OEEKGABNFEP, [In] T NCOLHKPFHLG, [In] T IBLOAPAOIFJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	protected JLOGELHDDNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[DefaultMember("Item")]
public class KCPHCELJCHH<T> : JLOGELHDDNG, OLDPMDCNGPK<T>, PEPIOFAEGBI<Entity, T>, MJKCPOHAALI<Entity>, NKHIPPPEKLG, IDisposable, GBBBMNOIKNN, OBMOEIEEAFP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public delegate bool HKJJBNBNBCB(Entity OEEKGABNFEP, [In] T IBLOAPAOIFJ);

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate void CMLEHKANCHM(Entity OEEKGABNFEP, [In] T NCOLHKPFHLG, [In] T IBLOAPAOIFJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HAAIIOGFDHE GLLNGEOKFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo HOJHNGOFHLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int LOEGAOKGNFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int PLIILJHILHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int ICPPKLAMHFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HKJJBNBNBCB KBPCIEJNPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CMLEHKANCHM KOAHEFKHGOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CMLEHKANCHM KGMNMPPMBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World FKPOHGDAOOH;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public override Type OIIFFAPKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3A29C20", Offset = "0x3A28A20", VA = "0x183A29C20", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public override HAAIIOGFDHE LIMFOBLBEFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x772C10", Offset = "0x771A10", VA = "0x180772C10", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public override OBMOEIEEAFP HKHDLEBPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8146C0", Offset = "0x8134C0", VA = "0x1808146C0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private FieldInfo GNOLIPMINOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x772C00", Offset = "0x771A00", VA = "0x180772C00", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private int KIFFHOBBHIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x78D2E0", Offset = "0x78C0E0", VA = "0x18078D2E0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private int BNMPNCBBILE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x77F110", Offset = "0x77DF10", VA = "0x18077F110", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private EntityManager NEGBPICGGKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x3A284B0", Offset = "0x3A272B0", VA = "0x183A284B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A460", Offset = "0x3A29260", VA = "0x183A2A460")]
	public KCPHCELJCHH(string NDLLBBKGIJD, HAAIIOGFDHE GLLNGEOKFID, FieldInfo HOJHNGOFHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x3A249A0", Offset = "0x3A237A0", VA = "0x183A249A0", Slot = "28")]
	public override void CAKCEPELMIL(EntityManager FOMHILNOHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x3A29430", Offset = "0x3A28230", VA = "0x183A29430")]
	public KCPHCELJCHH<T> KKIBCGLFKPG(HKJJBNBNBCB KBPCIEJNPKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x3A29C00", Offset = "0x3A28A00", VA = "0x183A29C00")]
	public KCPHCELJCHH<T> NIDHKOIBMGO(CMLEHKANCHM KOAHEFKHGOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A29BE0", Offset = "0x3A289E0", VA = "0x183A29BE0")]
	public KCPHCELJCHH<T> MKHJHIINHLE(CMLEHKANCHM KGMNMPPMBJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x3A29150", Offset = "0x3A27F50", VA = "0x183A29150", Slot = "29")]
	public T HFNEOIKDHBA(Entity OEEKGABNFEP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x3A25AF0", Offset = "0x3A248F0", VA = "0x183A25AF0")]
	public bool CCOBHHAAMMF(Entity OEEKGABNFEP, [In] T IBLOAPAOIFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x3A293F0", Offset = "0x3A281F0", VA = "0x183A293F0")]
	public bool KJEONDOGCNG(Entity OEEKGABNFEP, [In] T IBLOAPAOIFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x3A28400", Offset = "0x3A27200", VA = "0x183A28400", Slot = "22")]
	public override bool ELLDGLBOGGN(Entity OEEKGABNFEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x3A28E50", Offset = "0x3A27C50", VA = "0x183A28E50", Slot = "23")]
	public override void HFNEOIKDHBA(Entity OEEKGABNFEP, BBGHDLICAGJ PHPDIJICBJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x3A26710", Offset = "0x3A25510", VA = "0x183A26710", Slot = "24")]
	public override bool CCOBHHAAMMF(Entity OEEKGABNFEP, PJHPAJAPHOI IBLOAPAOIFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A100", Offset = "0x3A28F00", VA = "0x183A2A100", Slot = "25")]
	public override void PCDDBKBHIIM(CEKJKJACHBP NFOOEIFNJOL, [Optional] object GMIADHJEACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x3A29AE0", Offset = "0x3A288E0", VA = "0x183A29AE0", Slot = "26")]
	public override bool KLIGLKFNLOP(Entity LLIDMGAMJNA, Entity JPKEGLEDKEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x76F200", Offset = "0x76E000", VA = "0x18076F200", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x3A2A130", Offset = "0x3A28F30", VA = "0x183A2A130")]
	private bool PMFKIKELGCM(T NCOLHKPFHLG, T IBLOAPAOIFJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GBBBMNOIKNN : MJKCPOHAALI<Entity>, NKHIPPPEKLG, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OLDPMDCNGPK<T> : PEPIOFAEGBI<Entity, T>, MJKCPOHAALI<Entity>, NKHIPPPEKLG, IDisposable, GBBBMNOIKNN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
internal interface PPDBCLKCGDD : GBBBMNOIKNN, MJKCPOHAALI<Entity>, NKHIPPPEKLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int CAOCDCFPGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class CMPBLEDOHBA
{
	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x232DE00", Offset = "0x232CC00", VA = "0x18232DE00")]
	public static T KIOKCEMFMIA<T>(this OLDPMDCNGPK<T> NEBGFGPEMHL, Entity OEEKGABNFEP, [Optional] T JDDKNLMJJIF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x232DD00", Offset = "0x232CB00", VA = "0x18232DD00")]
	public static T JCFBGOJJKGI<T>(this MJKCPOHAALI<Entity> NEBGFGPEMHL, Entity OEEKGABNFEP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x232E040", Offset = "0x232CE40", VA = "0x18232E040")]
	public static bool OKHJGDGOHOJ<T>(this MJKCPOHAALI<Entity> NEBGFGPEMHL, Entity OEEKGABNFEP, [In] T IBLOAPAOIFJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public delegate void DPNIPJLKBIC<TKey>(TKey KANAGAAAGHJ, [In] PJHPAJAPHOI NCOLHKPFHLG, [In] PJHPAJAPHOI IBLOAPAOIFJ);
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class HEMDKIOMAKE
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x250C480", Offset = "0x250B280", VA = "0x18250C480")]
	public static void NBFCHEKFDKC<TKey, T>(this DPNIPJLKBIC<TKey> IDLFFNFHIPN, TKey KANAGAAAGHJ, T NCOLHKPFHLG, T IBLOAPAOIFJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public interface CEKJKJACHBP
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFAFPIHLDNL<TKey, T>(PEPIOFAEGBI<TKey, T> NEBGFGPEMHL, [Optional] object GMIADHJEACD) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public interface FJMKDPCCDMB
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface OBMOEIEEAFP
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo DDAIHBHGBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int DBDMPPMEDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int BMGCJGPBFOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface NKHIPPPEKLG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string NKCKPGIEOEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type OIIFFAPKJEG
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	OBMOEIEEAFP HKHDLEBPIOO
	{
		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HAAIIOGFDHE LIMFOBLBEFN
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CAOCDCFPGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PCDDBKBHIIM(CEKJKJACHBP NFOOEIFNJOL, [Optional] object GMIADHJEACD);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface MJKCPOHAALI<TKey> : NKHIPPPEKLG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event DPNIPJLKBIC<TKey> FJKLGIFGFGB;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ELLDGLBOGGN(TKey GAMCILOFBAF);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFNEOIKDHBA(TKey GAMCILOFBAF, BBGHDLICAGJ PHPDIJICBJO);

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool CCOBHHAAMMF(TKey GAMCILOFBAF, PJHPAJAPHOI IBLOAPAOIFJ);

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KLIGLKFNLOP(TKey LLIDMGAMJNA, TKey JPKEGLEDKEC);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
[DefaultMember("Item")]
public interface PEPIOFAEGBI<TKey, T> : MJKCPOHAALI<TKey>, NKHIPPPEKLG, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T HFNEOIKDHBA(TKey GAMCILOFBAF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class FFDHOBNPBKH
{
	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x24C4B00", Offset = "0x24C3900", VA = "0x1824C4B00")]
	public static bool PGALEGIIEOF<TKey, T>(this MJKCPOHAALI<TKey> NEBGFGPEMHL, TKey GAMCILOFBAF, [Out] T PHPDIJICBJO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x24C4430", Offset = "0x24C3230", VA = "0x1824C4430")]
	public static T HFNEOIKDHBA<T, TKey>(this MJKCPOHAALI<TKey> NEBGFGPEMHL, TKey GAMCILOFBAF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x24C3580", Offset = "0x24C2380", VA = "0x1824C3580")]
	public static bool CCOBHHAAMMF<TKey, T>(this MJKCPOHAALI<TKey> NEBGFGPEMHL, TKey GAMCILOFBAF, T IBLOAPAOIFJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface OHOOOKLLDMN : IEnumerable<GBBBMNOIKNN>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public interface HAAIIOGFDHE
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NCJFOCOOJFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int KBJFBIPGOCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type AFIIDLIHAKA
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	GBBBMNOIKNN[] HOCNMENCMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) JLCKPLCKIPC(Entity OEEKGABNFEP);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BNIBKCAPEGC(Entity OEEKGABNFEP, (uint order, uint change) PPBKIGHJOID);
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public class GDPMOPFMMLL : OHOOOKLLDMN, IEnumerable<GBBBMNOIKNN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<GBBBMNOIKNN> GLGBJALEBEO;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BMGCAELLGLF
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5EE4280", Offset = "0x5EE3080", VA = "0x185EE4280", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public GBBBMNOIKNN LNGAKLGPPKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5EE47E0", Offset = "0x5EE35E0", VA = "0x185EE47E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4840", Offset = "0x5EE3640", VA = "0x185EE4840")]
	public GDPMOPFMMLL(IEnumerable<HAAIIOGFDHE> FLLPJONFMHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5EE4340", Offset = "0x5EE3140", VA = "0x185EE4340")]
	private List<GBBBMNOIKNN> KEMALKJEPKB(IEnumerable<HAAIIOGFDHE> FLLPJONFMHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5EE42C0", Offset = "0x5EE30C0", VA = "0x185EE42C0", Slot = "4")]
	public IEnumerator<GBBBMNOIKNN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5EE42C0", Offset = "0x5EE30C0", VA = "0x185EE42C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct CAPPPJFDLDK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type FHCEJOHEMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string NDLLBBKGIJD;

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	public CAPPPJFDLDK(Type FHCEJOHEMJH, string NDLLBBKGIJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct GGPDIJBEDJF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type FHCEJOHEMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string NDLLBBKGIJD;

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x801630", Offset = "0x800430", VA = "0x180801630")]
	public GGPDIJBEDJF(Type FHCEJOHEMJH, string NDLLBBKGIJD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x35C6E30", Offset = "0x35C5C30", VA = "0x1835C6E30")]
	public static CAPPPJFDLDK BKJKGGIPDNI(GGPDIJBEDJF<T> HICAGFPLJOE)
	{
		return default(CAPPPJFDLDK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KDPDGCFFHKH
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
public class DBFEEPAPMKO
{
	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
	public DBFEEPAPMKO()
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
