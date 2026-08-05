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
public interface CJOCGGMBPLE : IEnumerable<PLBLNCEJEDA>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PLBLNCEJEDA : GCIMBJDHENP<Entity>, AELOMMACAOB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface MIBJKCEELLF<T> : FLNCDPNCALM<Entity, T>, GCIMBJDHENP<Entity>, AELOMMACAOB, IDisposable, PLBLNCEJEDA where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface LIKNEJOGLMP : PLBLNCEJEDA, GCIMBJDHENP<Entity>, AELOMMACAOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int GBCPOFPGEJB
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
public static class HNGMKOICCPH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x217BDC0", Offset = "0x217AFC0", VA = "0x18217BDC0")]
	public static T IFCFEFCFLPA<T>(this MIBJKCEELLF<T> BGOCDAGKFNE, Entity BLNICJMKCEF, [Optional] T HMGHIIACOGF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1B33770", Offset = "0x1B32970", VA = "0x181B33770")]
	public static T HOMBDFEEBBF<T>(this GCIMBJDHENP<Entity> BGOCDAGKFNE, Entity BLNICJMKCEF) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x217BB80", Offset = "0x217AD80", VA = "0x18217BB80")]
	public static bool HJFEACFKPKA<T>(this GCIMBJDHENP<Entity> BGOCDAGKFNE, Entity BLNICJMKCEF, in T FDDLNHNDPFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JHNBELMGFMH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int LLEALEGEMMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int OAFNEENIMDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type AJNFKCOHCED
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	PLBLNCEJEDA[] LHBAIFFNKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) HFLLCEAHCAL(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool COAGMNJHOFB(Entity BLNICJMKCEF, (uint order, uint change) KBIJDJHCEBH);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class GEGEKIALMBJ : LIKNEJOGLMP, PLBLNCEJEDA, GCIMBJDHENP<Entity>, AELOMMACAOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract JHNBELMGFMH JLMOKFABNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract OHEODOENDEE CNIKDLGMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x909DA0", Offset = "0x908FA0", VA = "0x180909DA0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int GBCPOFPGEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x8B2840", Offset = "0x8B1A40", VA = "0x1808B2840", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9298F0", Offset = "0x928AF0", VA = "0x1809298F0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event FPMEHGMLMEM<Entity> JJKMLFDPEAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6F77640", Offset = "0x6F76840", VA = "0x186F77640", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6F775A0", Offset = "0x6F767A0", VA = "0x186F775A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool CCLPLAGPKBK(Entity BLNICJMKCEF);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void MCKGCJAFOEM(Entity BLNICJMKCEF, PMJFNECPFPH NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool BNDJKAKDCIM(Entity BLNICJMKCEF, LKEBNILDCHH FDDLNHNDPFM);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void EIPBKFMEANK(ANJJHLMIOKD NGBDCJPCMID, [Optional] object JDFBABENAGD);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool DLOFCDEOECF(Entity GLDKECDCJGE, Entity LBIBKCFHCIL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void KCEHONPEIFO(EntityManager NMHMIPEFENM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1E27780", Offset = "0x1E26980", VA = "0x181E27780")]
	protected void ONGMAKKEFIK<T>(Entity BLNICJMKCEF, in T EJOKGCNJEPM, in T FDDLNHNDPFM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	protected GEGEKIALMBJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class LGOHODJFODN<T> : GEGEKIALMBJ, MIBJKCEELLF<T>, FLNCDPNCALM<Entity, T>, GCIMBJDHENP<Entity>, AELOMMACAOB, IDisposable, PLBLNCEJEDA, OHEODOENDEE where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool JCKPGKIMMGF(Entity BLNICJMKCEF, in T FDDLNHNDPFM);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void CODNAPMJBDM(Entity BLNICJMKCEF, in T EJOKGCNJEPM, in T FDDLNHNDPFM);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly JHNBELMGFMH GDGDHFAMEMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo HCAENIKBHOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int CNBPDHPGPFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int MLHOBKJDKGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int JPJMMBFGIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private JCKPGKIMMGF MAAHLEODGAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private CODNAPMJBDM INOPAECIAGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private CODNAPMJBDM FNELJKGAOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World OOHHGMIKJFD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2C53700", Offset = "0x2C52900", VA = "0x182C53700", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override JHNBELMGFMH JLMOKFABNPB
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8B1CC0", Offset = "0x8B0EC0", VA = "0x1808B1CC0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override OHEODOENDEE CNIKDLGMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xA1FE90", Offset = "0xA1F090", VA = "0x180A1FE90", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo LGNLFPADMHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x890860", Offset = "0x88FA60", VA = "0x180890860", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int MALNILKLIMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xBB06D0", Offset = "0xBAF8D0", VA = "0x180BB06D0", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int JECODMLFPNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9162B0", Offset = "0x9154B0", VA = "0x1809162B0", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager JENBOMFEDGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2C520B0", Offset = "0x2C512B0", VA = "0x182C520B0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2C53F70", Offset = "0x2C53170", VA = "0x182C53F70")]
	public LGOHODJFODN(string JPKENOAMLIN, JHNBELMGFMH GDGDHFAMEMB, FieldInfo HCAENIKBHOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2C53960", Offset = "0x2C52B60", VA = "0x182C53960", Slot = "28")]
	public override void KCEHONPEIFO(EntityManager NMHMIPEFENM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2C532F0", Offset = "0x2C524F0", VA = "0x182C532F0")]
	public LGOHODJFODN<T> CFDAKNBLCMD(JCKPGKIMMGF MAAHLEODGAF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2C53940", Offset = "0x2C52B40", VA = "0x182C53940")]
	public LGOHODJFODN<T> HKFDGLNBOKK(CODNAPMJBDM INOPAECIAGL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2C52090", Offset = "0x2C51290", VA = "0x182C52090")]
	public LGOHODJFODN<T> ANLLLOAGBJG(CODNAPMJBDM FNELJKGAOGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5513CF0", Offset = "0x5512EF0", VA = "0x185513CF0", Slot = "29")]
	public T MCKGCJAFOEM(Entity BLNICJMKCEF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x55109D0", Offset = "0x550FBD0", VA = "0x1855109D0")]
	public bool BNDJKAKDCIM(Entity BLNICJMKCEF, in T FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2C53670", Offset = "0x2C52870", VA = "0x182C53670")]
	public bool ELGBJDLCLLI(Entity BLNICJMKCEF, in T FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2C53290", Offset = "0x2C52490", VA = "0x182C53290", Slot = "22")]
	public override bool CCLPLAGPKBK(Entity BLNICJMKCEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2C53A70", Offset = "0x2C52C70", VA = "0x182C53A70", Slot = "23")]
	public override void MCKGCJAFOEM(Entity BLNICJMKCEF, PMJFNECPFPH NABCGCEIEGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2C52410", Offset = "0x2C51610", VA = "0x182C52410", Slot = "24")]
	public override bool BNDJKAKDCIM(Entity BLNICJMKCEF, LKEBNILDCHH FDDLNHNDPFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C53640", Offset = "0x2C52840", VA = "0x182C53640", Slot = "25")]
	public override void EIPBKFMEANK(ANJJHLMIOKD NGBDCJPCMID, [Optional] object JDFBABENAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2C53310", Offset = "0x2C52510", VA = "0x182C53310", Slot = "26")]
	public override bool DLOFCDEOECF(Entity GLDKECDCJGE, Entity LBIBKCFHCIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x88B410", Offset = "0x88A610", VA = "0x18088B410", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2C536B0", Offset = "0x2C528B0", VA = "0x182C536B0")]
	private bool GJNFKNOLOFN(ref T EJOKGCNJEPM, ref T FDDLNHNDPFM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void FPMEHGMLMEM<TKey>(TKey PPNJOAJJOFF, in LKEBNILDCHH EJOKGCNJEPM, in LKEBNILDCHH FDDLNHNDPFM);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class PFJAPDDLKNB
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x23459C0", Offset = "0x2344BC0", VA = "0x1823459C0")]
	public static void LDFPBHJMNFE<TKey, T>(this FPMEHGMLMEM<TKey> ILPONDPFHDP, TKey PPNJOAJJOFF, T EJOKGCNJEPM, T FDDLNHNDPFM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface ANJJHLMIOKD
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NDCMNMAJOBE<TKey, T>(FLNCDPNCALM<TKey, T> BGOCDAGKFNE, [Optional] object JDFBABENAGD) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface ENMADBFDFBF
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface OHEODOENDEE
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo BLIHGNDKHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int HPFFKDDEMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int EGAKMGBHOLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface AELOMMACAOB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string GCLEOCLMMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type GLGPHBABLMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	OHEODOENDEE CNIKDLGMEBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	JHNBELMGFMH JLMOKFABNPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int GBCPOFPGEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void EIPBKFMEANK(ANJJHLMIOKD NGBDCJPCMID, [Optional] object JDFBABENAGD);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GCIMBJDHENP<TKey> : AELOMMACAOB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event FPMEHGMLMEM<TKey> JJKMLFDPEAM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CCLPLAGPKBK(TKey JCEGKCPOPDM);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCKGCJAFOEM(TKey JCEGKCPOPDM, PMJFNECPFPH NABCGCEIEGG);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool BNDJKAKDCIM(TKey JCEGKCPOPDM, LKEBNILDCHH FDDLNHNDPFM);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DLOFCDEOECF(TKey GLDKECDCJGE, TKey LBIBKCFHCIL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface FLNCDPNCALM<TKey, T> : GCIMBJDHENP<TKey>, AELOMMACAOB, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T MCKGCJAFOEM(TKey JCEGKCPOPDM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class DCCMCEILIMP
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1CC70E0", Offset = "0x1CC62E0", VA = "0x181CC70E0")]
	public static bool FCPLDEOENIG<TKey, T>(this GCIMBJDHENP<TKey> BGOCDAGKFNE, TKey JCEGKCPOPDM, out T NABCGCEIEGG) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1CC7280", Offset = "0x1CC6480", VA = "0x181CC7280")]
	public static T MCKGCJAFOEM<T, TKey>(this GCIMBJDHENP<TKey> BGOCDAGKFNE, TKey JCEGKCPOPDM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1CC67D0", Offset = "0x1CC59D0", VA = "0x181CC67D0")]
	public static bool BNDJKAKDCIM<TKey, T>(this GCIMBJDHENP<TKey> BGOCDAGKFNE, TKey JCEGKCPOPDM, T FDDLNHNDPFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct FAODENBHDMK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type INJKFIICBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string JPKENOAMLIN;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
	public FAODENBHDMK(Type INJKFIICBLK, string JPKENOAMLIN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct CPFKEJJKDHF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type INJKFIICBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string JPKENOAMLIN;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x949BA0", Offset = "0x948DA0", VA = "0x180949BA0")]
	public CPFKEJJKDHF(Type INJKFIICBLK, string JPKENOAMLIN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2CA61B0", Offset = "0x2CA53B0", VA = "0x182CA61B0")]
	public static FAODENBHDMK PECINANIGFJ(CPFKEJJKDHF<T> ENMMGDOAMCO)
	{
		return default(FAODENBHDMK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PJCFHEHJAEF
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
public class IOPCPGDBHOD : CJOCGGMBPLE, IEnumerable<PLBLNCEJEDA>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<PLBLNCEJEDA> PEMHLBOJGBI;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int JKNHGEMPCNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6F77C50", Offset = "0x6F76E50", VA = "0x186F77C50", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PLBLNCEJEDA JOJAFGMMIDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6F77C90", Offset = "0x6F76E90", VA = "0x186F77C90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F77CF0", Offset = "0x6F76EF0", VA = "0x186F77CF0")]
	public IOPCPGDBHOD(IEnumerable<JHNBELMGFMH> JIKOBGNBAPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F77760", Offset = "0x6F76960", VA = "0x186F77760")]
	private List<PLBLNCEJEDA> LGBAMJBLFDE(IEnumerable<JHNBELMGFMH> JIKOBGNBAPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F776E0", Offset = "0x6F768E0", VA = "0x186F776E0", Slot = "4")]
	public IEnumerator<PLBLNCEJEDA> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F776E0", Offset = "0x6F768E0", VA = "0x186F776E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class MDBJHPDEIOP
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
	public MDBJHPDEIOP()
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
