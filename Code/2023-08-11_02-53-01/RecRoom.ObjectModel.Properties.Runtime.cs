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
[DefaultMember("Item")]
public interface KLIFGLMPDFG : IEnumerable<BLECIIOHDPI>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BLECIIOHDPI : KCHKLIOOFLC<Entity>, MNKCCJJMJKH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CMIDKKJCOBP<T> : ALJIFOIANLF<Entity, T>, KCHKLIOOFLC<Entity>, MNKCCJJMJKH, IDisposable, BLECIIOHDPI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface JGNGMPAEBBF : BLECIIOHDPI, KCHKLIOOFLC<Entity>, MNKCCJJMJKH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int EDHJHHDEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DLBNEEJFPPK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3085220", Offset = "0x3083A20", VA = "0x183085220")]
	public static T IDJPJOBGJOA<T>(this CMIDKKJCOBP<T> OPCEAOKDBMJ, Entity AJDEFAPHMKF, [Optional] T GFJIAKNDNMH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x9A4170", Offset = "0x9A2970", VA = "0x1809A4170")]
	public static T CANLNBNDEBD<T>(this KCHKLIOOFLC<Entity> OPCEAOKDBMJ, Entity AJDEFAPHMKF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x30850A0", Offset = "0x30838A0", VA = "0x1830850A0")]
	public static bool DCLIJHBOMFC<T>(this KCHKLIOOFLC<Entity> OPCEAOKDBMJ, Entity AJDEFAPHMKF, in T PCKLDBCFAAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface BMPCFGMBEIA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int IMNALKMAGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int LGOOLBAFLFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type FCMLDNAMHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	BLECIIOHDPI[] EFMMGHNDFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) HOJAFNDLCOI(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BDINEGGJLMH(Entity AJDEFAPHMKF, (uint order, uint change) MNJCDKNLLPF);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class ADOKEKGPDOO : JGNGMPAEBBF, BLECIIOHDPI, KCHKLIOOFLC<Entity>, MNKCCJJMJKH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract BMPCFGMBEIA JFGADNLFGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract CICLHDCPBNI LFLBPEILMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x8E7480", Offset = "0x8E5C80", VA = "0x1808E7480")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int EDHJHHDEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x95DB20", Offset = "0x95C320", VA = "0x18095DB20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event EEJPKNFMFLB<Entity> NHPDJIPDPHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F25330", Offset = "0x6F23B30", VA = "0x186F25330", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F25290", Offset = "0x6F23A90", VA = "0x186F25290", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool PINCLHPNEDE(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void LPKBLHIFLLL(Entity AJDEFAPHMKF, KOAODCFHIDH MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool OLFLGMGEIBD(Entity AJDEFAPHMKF, DMEBMKFMGNA PCKLDBCFAAB);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void DMJAGMBBENO(NADHHNFNDJH INDEBDDLMDO, [Optional] object HNBDDLBIIOF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool BBGJPJPLCPO(Entity KLLNOLIEMOA, Entity EMGBKAPJLEO);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void BDCEDMLOOPD(EntityManager EADLBIHJKBG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1DEFB00", Offset = "0x1DEE300", VA = "0x181DEFB00")]
	protected void NNBLDKJGJGO<T>(Entity AJDEFAPHMKF, in T MDBHGCNGNDL, in T PCKLDBCFAAB) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	protected ADOKEKGPDOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class NIJBLPDKGGM<T> : ADOKEKGPDOO, CMIDKKJCOBP<T>, ALJIFOIANLF<Entity, T>, KCHKLIOOFLC<Entity>, MNKCCJJMJKH, IDisposable, BLECIIOHDPI, CICLHDCPBNI where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool HPAJCAAKGOP(Entity AJDEFAPHMKF, in T PCKLDBCFAAB);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void NEGCJFPMBPM(Entity AJDEFAPHMKF, in T MDBHGCNGNDL, in T PCKLDBCFAAB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly BMPCFGMBEIA IGMMIIIPDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo KALBAGAAFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int KFGBCCEFCMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int CNJDAMBDKMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int JIAHBEIKEJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private HPAJCAAKGOP NCKJJHENMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NEGCJFPMBPM LKKGCOPBBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private NEGCJFPMBPM HHKENMMMNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World EJLFIBCCMHH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x4C32F50", Offset = "0x4C31750", VA = "0x184C32F50", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override BMPCFGMBEIA JFGADNLFGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8A5F80", Offset = "0x8A4780", VA = "0x1808A5F80", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override CICLHDCPBNI LFLBPEILMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x907390", Offset = "0x905B90", VA = "0x180907390", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo PKPHIJFLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x7F3350", Offset = "0x7F1B50", VA = "0x1807F3350", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int IKBFABBACHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x1136780", Offset = "0x1134F80", VA = "0x181136780", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int HDMCKCDMKOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x7ED780", Offset = "0x7EBF80", VA = "0x1807ED780", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x330DBE0", Offset = "0x330C3E0", VA = "0x18330DBE0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4C34AB0", Offset = "0x4C332B0", VA = "0x184C34AB0")]
	public NIJBLPDKGGM(string MDOAADHDBMA, BMPCFGMBEIA IGMMIIIPDOH, FieldInfo KALBAGAAFNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x330DAD0", Offset = "0x330C2D0", VA = "0x18330DAD0", Slot = "28")]
	public override void BDCEDMLOOPD(EntityManager EADLBIHJKBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x330D900", Offset = "0x330C100", VA = "0x18330D900")]
	public NIJBLPDKGGM<T> AHPBKCMGJFL(HPAJCAAKGOP NCKJJHENMCM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x330DE50", Offset = "0x330C650", VA = "0x18330DE50")]
	public NIJBLPDKGGM<T> MIBHIIMJFNK(NEGCJFPMBPM LKKGCOPBBCA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x330DB80", Offset = "0x330C380", VA = "0x18330DB80")]
	public NIJBLPDKGGM<T> DNGEPNOIBCN(NEGCJFPMBPM HHKENMMMNHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4C2DAA0", Offset = "0x4C2C2A0", VA = "0x184C2DAA0", Slot = "29")]
	public T LPKBLHIFLLL(Entity AJDEFAPHMKF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4C321A0", Offset = "0x4C309A0", VA = "0x184C321A0")]
	public bool OLFLGMGEIBD(Entity AJDEFAPHMKF, in T PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x330DBA0", Offset = "0x330C3A0", VA = "0x18330DBA0")]
	public bool FHHMDCNBIDO(Entity AJDEFAPHMKF, in T PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x330E8B0", Offset = "0x330D0B0", VA = "0x18330E8B0", Slot = "22")]
	public override bool PINCLHPNEDE(Entity AJDEFAPHMKF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D8E0", Offset = "0x4C2C0E0", VA = "0x184C2D8E0", Slot = "23")]
	public override void LPKBLHIFLLL(Entity AJDEFAPHMKF, KOAODCFHIDH MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4C2F190", Offset = "0x4C2D990", VA = "0x184C2F190", Slot = "24")]
	public override bool OLFLGMGEIBD(Entity AJDEFAPHMKF, DMEBMKFMGNA PCKLDBCFAAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x330DB50", Offset = "0x330C350", VA = "0x18330DB50", Slot = "25")]
	public override void DMJAGMBBENO(NADHHNFNDJH INDEBDDLMDO, [Optional] object HNBDDLBIIOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4C2D3B0", Offset = "0x4C2BBB0", VA = "0x184C2D3B0", Slot = "26")]
	public override bool BBGJPJPLCPO(Entity KLLNOLIEMOA, Entity EMGBKAPJLEO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EE850", Offset = "0x7ED050", VA = "0x1807EE850", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x330DB00", Offset = "0x330C300", VA = "0x18330DB00")]
	private bool BKPHGPMHFIK(ref T MDBHGCNGNDL, ref T PCKLDBCFAAB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void EEJPKNFMFLB<TKey>(TKey CEPDEAHBHLF, in DMEBMKFMGNA MDBHGCNGNDL, in DMEBMKFMGNA PCKLDBCFAAB);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class HCBAJFFMKNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1CAD960", Offset = "0x1CAC160", VA = "0x181CAD960")]
	public static void MADELAMLLLM<TKey, T>(this EEJPKNFMFLB<TKey> FKHENLGIMDG, TKey CEPDEAHBHLF, T MDBHGCNGNDL, T PCKLDBCFAAB) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface NADHHNFNDJH
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBBEFAPNECG<TKey, T>(ALJIFOIANLF<TKey, T> OPCEAOKDBMJ, [Optional] object HNBDDLBIIOF) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface HGGHMIFHDDN
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CICLHDCPBNI
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo DMIDNDEBHGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int DDDGGALLAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int EFKFFCAGHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MNKCCJJMJKH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type ILFDEIBDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CICLHDCPBNI LFLBPEILMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	BMPCFGMBEIA JFGADNLFGPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int EDHJHHDEOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DMJAGMBBENO(NADHHNFNDJH INDEBDDLMDO, [Optional] object HNBDDLBIIOF);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KCHKLIOOFLC<TKey> : MNKCCJJMJKH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event EEJPKNFMFLB<TKey> NHPDJIPDPHC;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PINCLHPNEDE(TKey EECINICJCLK);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LPKBLHIFLLL(TKey EECINICJCLK, KOAODCFHIDH MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool OLFLGMGEIBD(TKey EECINICJCLK, DMEBMKFMGNA PCKLDBCFAAB);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BBGJPJPLCPO(TKey KLLNOLIEMOA, TKey EMGBKAPJLEO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface ALJIFOIANLF<TKey, T> : KCHKLIOOFLC<TKey>, MNKCCJJMJKH, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T LPKBLHIFLLL(TKey EECINICJCLK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class EBDILCAHIOD
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB5D0", Offset = "0x2AF9DD0", VA = "0x182AFB5D0")]
	public static bool NOPGAJGAFLG<TKey, T>(this KCHKLIOOFLC<TKey> OPCEAOKDBMJ, TKey EECINICJCLK, out T MENBIMCLIOI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x2AFA9B0", Offset = "0x2AF91B0", VA = "0x182AFA9B0")]
	public static T LPKBLHIFLLL<T, TKey>(this KCHKLIOOFLC<TKey> OPCEAOKDBMJ, TKey EECINICJCLK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x2AFB770", Offset = "0x2AF9F70", VA = "0x182AFB770")]
	public static bool OLFLGMGEIBD<TKey, T>(this KCHKLIOOFLC<TKey> OPCEAOKDBMJ, TKey EECINICJCLK, T PCKLDBCFAAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FKFIIEPBNGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type DOHMIIFHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string MDOAADHDBMA;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
	public FKFIIEPBNGA(Type DOHMIIFHLOD, string MDOAADHDBMA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct KNCFGIDDJIE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type DOHMIIFHLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string MDOAADHDBMA;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xB84550", Offset = "0xB82D50", VA = "0x180B84550")]
	public KNCFGIDDJIE(Type DOHMIIFHLOD, string MDOAADHDBMA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x22824D0", Offset = "0x2280CD0", VA = "0x1822824D0")]
	public static FKFIIEPBNGA IEOLFBMCLMC(KNCFGIDDJIE<T> GDMDACGBKDC)
	{
		return default(FKFIIEPBNGA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum ANFBNEGBPNM
{
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Invalid = -1,
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	CreateObject = -2,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	DestroyObject = -3,
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	BeginTransaction = -4,
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	EndTransaction = -5,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	External = -6
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
[DefaultMember("Item")]
public class AINFFBPBMAB : KLIFGLMPDFG, IEnumerable<BLECIIOHDPI>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<BLECIIOHDPI> HJJOLCMEOKD;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F25920", Offset = "0x6F24120", VA = "0x186F25920", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BLECIIOHDPI ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F253D0", Offset = "0x6F23BD0", VA = "0x186F253D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F259E0", Offset = "0x6F241E0", VA = "0x186F259E0")]
	public AINFFBPBMAB(IEnumerable<BMPCFGMBEIA> KOGCMHHBDOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F25430", Offset = "0x6F23C30", VA = "0x186F25430")]
	private List<BLECIIOHDPI> GHCDMDNLFNN(IEnumerable<BMPCFGMBEIA> KOGCMHHBDOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F25960", Offset = "0x6F24160", VA = "0x186F25960", Slot = "4")]
	public IEnumerator<BLECIIOHDPI> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F25960", Offset = "0x6F24160", VA = "0x186F25960", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class PGBKCKFKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PGBKCKFKJGL()
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
