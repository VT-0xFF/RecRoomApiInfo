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
public interface GPEBFEIAAAG : IEnumerable<HOCJLCNHINC>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HOCJLCNHINC : FMCBBGDPEBD<Entity>, KPLINJJFGJD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface JGEGAEAAJPO<T> : EHNJFEOCJHK<Entity, T>, FMCBBGDPEBD<Entity>, KPLINJJFGJD, IDisposable, HOCJLCNHINC where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface IBKEINFIKOJ : HOCJLCNHINC, FMCBBGDPEBD<Entity>, KPLINJJFGJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int FGJLEEGIAHM
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
public static class OMNLPGDIKLK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3370B50", Offset = "0x336FB50", VA = "0x183370B50")]
	public static T EDPGOMNLFPH<T>(this JGEGAEAAJPO<T> LDJJMGJLECK, Entity NNCCHIHKALO, [Optional] T PNJDHPAJOAO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xD02A60", Offset = "0xD01A60", VA = "0x180D02A60")]
	public static T ACFOFJDLAHB<T>(this FMCBBGDPEBD<Entity> LDJJMGJLECK, Entity NNCCHIHKALO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2525340", Offset = "0x2524340", VA = "0x182525340")]
	public static bool NJLHKOGPPIM<T>(this FMCBBGDPEBD<Entity> LDJJMGJLECK, Entity NNCCHIHKALO, in T LEBBAONJLBL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFBAFHPMHJD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int KICPOBNCMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int ANJJFJFKAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type AJDGFDBDNPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	HOCJLCNHINC[] KGEEPIBBLLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) LEGAONDFFFG(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HOELMEBEKPJ(Entity NNCCHIHKALO, (uint order, uint change) ELKCHAMAHHH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class EGPMFDLINAI : IBKEINFIKOJ, HOCJLCNHINC, FMCBBGDPEBD<Entity>, KPLINJJFGJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type HCKGHBENCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract PFBAFHPMHJD CAHPIFBDELN
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract NICPCGBGMFP CGIIDOJFEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9132E0", Offset = "0x9122E0", VA = "0x1809132E0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FGJLEEGIAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xBB0410", Offset = "0xBAF410", VA = "0x180BB0410", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xBF6220", Offset = "0xBF5220", VA = "0x180BF6220", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LCEKJLKFHEI<Entity> LBGJMGKKDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7303390", Offset = "0x7302390", VA = "0x187303390", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7303430", Offset = "0x7302430", VA = "0x187303430", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool EKIJMHGPMDN(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool MEEIGDDJBLL(Entity NNCCHIHKALO, in object LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void FLFDNJDANPO(Entity NNCCHIHKALO, in AEOEDAMJAAA CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool DGLJBNFHKAF(Entity NNCCHIHKALO, in LEMHKMBLBBH LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool PBBJPKOCALN(Entity LOHIKDGDMPP, in LEMHKMBLBBH LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void NLBHLFICGMO(EOMOHHBPCMJ MOGJCLABJKF, [Optional] object AEOEKGNDHFM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool ENIJEBFJHBA(Entity OOMAONFBFID, Entity NCAAFEBNDOO);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void LLEBBJIFEDK(EntityManager PFNOJANOPHC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1FFCCB0", Offset = "0x1FFBCB0", VA = "0x181FFCCB0")]
	protected void HANICOLHIMI<T>(Entity NNCCHIHKALO, in T DHCGIIGPCGA, in T LEBBAONJLBL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string DAGJHDGPLCG(in LEMHKMBLBBH OGCIKDCCAME);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	protected EGPMFDLINAI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class EMKOIFLBOGI<T> : EGPMFDLINAI, JGEGAEAAJPO<T>, EHNJFEOCJHK<Entity, T>, FMCBBGDPEBD<Entity>, KPLINJJFGJD, IDisposable, HOCJLCNHINC, NICPCGBGMFP where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool MKMHOHBJBLD(Entity NNCCHIHKALO, in T LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void IIMNELCIMBO(Entity NNCCHIHKALO, in T DHCGIIGPCGA, in T LEBBAONJLBL);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly PFBAFHPMHJD CPJMENEJDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo BLGOGPOCLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int EELINDLPCIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int FCCAKNLHEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int BKMCHKCIDOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private MKMHOHBJBLD JMNKPAGAGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private IIMNELCIMBO FMACOPGJJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private IIMNELCIMBO ELKGGPILLLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World FJHHKGBBABB;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type HCKGHBENCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x58405C0", Offset = "0x583F5C0", VA = "0x1858405C0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override PFBAFHPMHJD CAHPIFBDELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9132D0", Offset = "0x9122D0", VA = "0x1809132D0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override NICPCGBGMFP CGIIDOJFEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA44390", Offset = "0xA43390", VA = "0x180A44390", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo JGLIPEKNMAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9132C0", Offset = "0x9122C0", VA = "0x1809132C0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int MONJHEJBIIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xC35000", Offset = "0xC34000", VA = "0x180C35000", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int HIGEEHKOJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x871180", Offset = "0x870180", VA = "0x180871180", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager KLDHCJDHBCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x583FDF0", Offset = "0x583EDF0", VA = "0x18583FDF0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5849470", Offset = "0x5848470", VA = "0x185849470")]
	public EMKOIFLBOGI(string OALFIBFPPAC, PFBAFHPMHJD CPJMENEJDJH, FieldInfo BLGOGPOCLNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5847DE0", Offset = "0x5846DE0", VA = "0x185847DE0", Slot = "33")]
	public override void LLEBBJIFEDK(EntityManager PFNOJANOPHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4370A70", Offset = "0x436FA70", VA = "0x184370A70")]
	public EMKOIFLBOGI<T> KMLJOGJGJCL(MKMHOHBJBLD JMNKPAGAGGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x43709C0", Offset = "0x436F9C0", VA = "0x1843709C0")]
	public EMKOIFLBOGI<T> KLMPKMGDJMB(IIMNELCIMBO FMACOPGJJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x43707F0", Offset = "0x436F7F0", VA = "0x1843707F0")]
	public EMKOIFLBOGI<T> IKPINNFCIFM(IIMNELCIMBO ELKGGPILLLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5847210", Offset = "0x5846210", VA = "0x185847210", Slot = "35")]
	public T FLFDNJDANPO(Entity NNCCHIHKALO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x58459F0", Offset = "0x58449F0", VA = "0x1858459F0")]
	public bool DGLJBNFHKAF(Entity NNCCHIHKALO, in T LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5848610", Offset = "0x5847610", VA = "0x185848610")]
	public bool PBBJPKOCALN(Entity NNCCHIHKALO, in T LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x58469B0", Offset = "0x58459B0", VA = "0x1858469B0", Slot = "25")]
	public override bool EKIJMHGPMDN(Entity NNCCHIHKALO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5848150", Offset = "0x5847150", VA = "0x185848150", Slot = "26")]
	public override bool MEEIGDDJBLL(Entity NNCCHIHKALO, in object LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5847B10", Offset = "0x5846B10", VA = "0x185847B10", Slot = "27")]
	public override void FLFDNJDANPO(Entity NNCCHIHKALO, in AEOEDAMJAAA CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5841520", Offset = "0x5840520", VA = "0x185841520", Slot = "28")]
	public override bool DGLJBNFHKAF(Entity NNCCHIHKALO, in LEMHKMBLBBH LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5848770", Offset = "0x5847770", VA = "0x185848770", Slot = "29")]
	public override bool PBBJPKOCALN(Entity NNCCHIHKALO, in LEMHKMBLBBH LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x58485E0", Offset = "0x58475E0", VA = "0x1858485E0", Slot = "30")]
	public override void NLBHLFICGMO(EOMOHHBPCMJ MOGJCLABJKF, [Optional] object AEOEKGNDHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5846FD0", Offset = "0x5845FD0", VA = "0x185846FD0", Slot = "31")]
	public override bool ENIJEBFJHBA(Entity OOMAONFBFID, Entity NCAAFEBNDOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x85F420", Offset = "0x85E420", VA = "0x18085F420", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5840EB0", Offset = "0x583FEB0", VA = "0x185840EB0", Slot = "34")]
	public override string DAGJHDGPLCG(in LEMHKMBLBBH OGCIKDCCAME)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5847E10", Offset = "0x5846E10", VA = "0x185847E10")]
	private bool LPGOAMJEJHA(ref T DHCGIIGPCGA, ref T LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5847DB0", Offset = "0x5846DB0", VA = "0x185847DB0", Slot = "36")]
	private bool LFDHNJOOPNE(Entity LOHIKDGDMPP, in T LEBBAONJLBL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x583FE10", Offset = "0x583EE10", VA = "0x18583FE10", Slot = "37")]
	private bool CHKBKAOKAPK(Entity LOHIKDGDMPP, in T LEBBAONJLBL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LCEKJLKFHEI<TKey>(TKey EOHGDDIECBJ, in LEMHKMBLBBH DHCGIIGPCGA, in LEMHKMBLBBH LEBBAONJLBL);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MMCILKCDOEN
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x16E8D40", Offset = "0x16E7D40", VA = "0x1816E8D40")]
	public static void KAEAMPPMANC<TKey, T>(this LCEKJLKFHEI<TKey> BFNKDBHNAAE, TKey EOHGDDIECBJ, T DHCGIIGPCGA, T LEBBAONJLBL) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface EOMOHHBPCMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGHGKCBNEDL<TKey, T>(EHNJFEOCJHK<TKey, T> LDJJMGJLECK, [Optional] object AEOEKGNDHFM) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface EEBLIOGHPAB
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGHGKCBNEDL(KPLINJJFGJD LDJJMGJLECK, in LEMHKMBLBBH CKDFGEALFAK, [Optional] object AEOEKGNDHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface NICPCGBGMFP
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo OJMKPFIJBCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int COLPJJEEHPP
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int FALJKMDLBBK
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KPLINJJFGJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type HCKGHBENCAH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	NICPCGBGMFP CGIIDOJFEAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	PFBAFHPMHJD CAHPIFBDELN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int FGJLEEGIAHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NLBHLFICGMO(EOMOHHBPCMJ MOGJCLABJKF, [Optional] object AEOEKGNDHFM);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface FMCBBGDPEBD<TKey> : KPLINJJFGJD, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LCEKJLKFHEI<TKey> LBGJMGKKDBJ;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EKIJMHGPMDN(TKey LOHIKDGDMPP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool MEEIGDDJBLL(TKey LOHIKDGDMPP, in object LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FLFDNJDANPO(TKey LOHIKDGDMPP, in AEOEDAMJAAA CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DGLJBNFHKAF(TKey LOHIKDGDMPP, in LEMHKMBLBBH LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PBBJPKOCALN(TKey LOHIKDGDMPP, in LEMHKMBLBBH LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool ENIJEBFJHBA(TKey OOMAONFBFID, TKey NCAAFEBNDOO);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string DAGJHDGPLCG(in LEMHKMBLBBH CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface EHNJFEOCJHK<TKey, T> : FMCBBGDPEBD<TKey>, KPLINJJFGJD, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T FLFDNJDANPO(TKey LOHIKDGDMPP);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DGLJBNFHKAF(TKey LOHIKDGDMPP, in T LEBBAONJLBL);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PBBJPKOCALN(TKey LOHIKDGDMPP, in T LEBBAONJLBL);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KNANGBCELEL
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A840", Offset = "0x2B59840", VA = "0x182B5A840")]
	public static bool OLPFKLCKDPK<TKey, T>(this FMCBBGDPEBD<TKey> LDJJMGJLECK, TKey LOHIKDGDMPP, out T CKDFGEALFAK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x2B59CE0", Offset = "0x2B58CE0", VA = "0x182B59CE0")]
	public static T FLFDNJDANPO<T, TKey>(this FMCBBGDPEBD<TKey> LDJJMGJLECK, TKey LOHIKDGDMPP) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x2B59480", Offset = "0x2B58480", VA = "0x182B59480")]
	public static bool DGLJBNFHKAF<TKey, T>(this FMCBBGDPEBD<TKey> LDJJMGJLECK, TKey LOHIKDGDMPP, T LEBBAONJLBL) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x2B5A9D0", Offset = "0x2B599D0", VA = "0x182B5A9D0")]
	public static bool PBBJPKOCALN<TKey, T>(this FMCBBGDPEBD<TKey> LDJJMGJLECK, TKey LOHIKDGDMPP, T LEBBAONJLBL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NOJOLKBLHAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type HDBNLLHLDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string OALFIBFPPAC;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
	public NOJOLKBLHAF(Type HDBNLLHLDDM, string OALFIBFPPAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct MOHEIECGODL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type HDBNLLHLDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string OALFIBFPPAC;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xA891D0", Offset = "0xA881D0", VA = "0x180A891D0")]
	public MOHEIECGODL(Type HDBNLLHLDDM, string OALFIBFPPAC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x2730130", Offset = "0x272F130", VA = "0x182730130")]
	public static NOJOLKBLHAF JPKDPGCIHAB(MOHEIECGODL<T> EPBHOJMLBCF)
	{
		return default(NOJOLKBLHAF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HLHJJDCFGND
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
public class CCPAMDLMFDA : GPEBFEIAAAG, IEnumerable<HOCJLCNHINC>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<HOCJLCNHINC> BJGJBCEJKLM;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7302D40", Offset = "0x7301D40", VA = "0x187302D40", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HOCJLCNHINC CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7302E00", Offset = "0x7301E00", VA = "0x187302E00", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7303350", Offset = "0x7302350", VA = "0x187303350")]
	public CCPAMDLMFDA(IEnumerable<PFBAFHPMHJD> IIADKNLDAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7302E60", Offset = "0x7301E60", VA = "0x187302E60")]
	private List<HOCJLCNHINC> PLLEIHCGJFN(IEnumerable<PFBAFHPMHJD> IIADKNLDAJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7302D80", Offset = "0x7301D80", VA = "0x187302D80", Slot = "4")]
	public IEnumerator<HOCJLCNHINC> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7302D80", Offset = "0x7301D80", VA = "0x187302D80", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
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
