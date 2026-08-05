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
public interface FAONFGCBPNO : IEnumerable<CPBOEHNKFNO>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CPBOEHNKFNO : GKPDPGNIGKB<Entity>, DCMKKBFMJKI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NACGDLPFDKA<T> : PBPDJLMHCMH<Entity, T>, GKPDPGNIGKB<Entity>, DCMKKBFMJKI, IDisposable, CPBOEHNKFNO where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface FGGMGFLJJJE : CPBOEHNKFNO, GKPDPGNIGKB<Entity>, DCMKKBFMJKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int NCJNHKMPGAM
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
public static class GFMGGELIFLL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x346C5D0", Offset = "0x346B3D0", VA = "0x18346C5D0")]
	public static T JMJIKDOFAHD<T>(this NACGDLPFDKA<T> ICNBGPBCJEH, Entity FPIIEOBJDDB, [Optional] T DGNBLLFJDJH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x346C510", Offset = "0x346B310", VA = "0x18346C510")]
	public static T HHABJGGFENE<T>(this GKPDPGNIGKB<Entity> ICNBGPBCJEH, Entity FPIIEOBJDDB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x346C740", Offset = "0x346B540", VA = "0x18346C740")]
	public static bool LOFJCELKDGG<T>(this GKPDPGNIGKB<Entity> ICNBGPBCJEH, Entity FPIIEOBJDDB, in T ALOICDECJNJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface IMNMHFEADJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int ADHNEBJMDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int BNJDCGLBDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type NNPHANCNIFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	CPBOEHNKFNO[] GJOMGOHIKPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) DEOCCKOBBDH(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AFMEIJJMDJI(Entity FPIIEOBJDDB, (uint order, uint change) OAFCEFJIFII);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class BDKFCFJPHMO : FGGMGFLJJJE, CPBOEHNKFNO, GKPDPGNIGKB<Entity>, DCMKKBFMJKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract IMNMHFEADJO EFJMLCAOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract KHNHHEFGFCA CIMGIEBMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "24")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string KGBBPCBIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x83B710", Offset = "0x83A510", VA = "0x18083B710", Slot = "15")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F63B0", Offset = "0x7F51B0", VA = "0x1807F63B0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NCJNHKMPGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x838BF0", Offset = "0x8379F0", VA = "0x180838BF0", Slot = "19")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x7F63A0", Offset = "0x7F51A0", VA = "0x1807F63A0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event LAOMKEABFOI<Entity> INPOJHGJJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7000CD0", Offset = "0x6FFFAD0", VA = "0x187000CD0", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x7000D70", Offset = "0x6FFFB70", VA = "0x187000D70", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool MIGIONPGLDD(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool HFNDMEOOEJI(Entity FPIIEOBJDDB, in object ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void KOLGIMOOKDG(Entity FPIIEOBJDDB, in MKDNGEDKNED KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool MDELLMLPPIN(Entity FPIIEOBJDDB, in BIABKMPNANG ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract bool KHHNEIIGAMI(Entity LGKPJAJAOLI, in BIABKMPNANG ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void JOCNNHJBIBK(CJKIJIPCANL BCPIKEBGGDH, [Optional] object CNBGAPJABKP);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract bool JJKBJMIFDEF(Entity FCAKJLDDKGP, Entity PEJGDDHHDBH);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "33")]
	public abstract void HFKECJNCAPE(EntityManager HCPDBMFJKPJ);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x314D610", Offset = "0x314C410", VA = "0x18314D610")]
	protected void HBBDFCKHNKM<T>(Entity FPIIEOBJDDB, in T IDKFOCMLDHM, in T ALOICDECJNJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "34")]
	public abstract string HOIMKNNBNAG(in BIABKMPNANG NBCMLHOMALH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	protected BDKFCFJPHMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class HPAGFMDLMJC<T> : BDKFCFJPHMO, NACGDLPFDKA<T>, PBPDJLMHCMH<Entity, T>, GKPDPGNIGKB<Entity>, DCMKKBFMJKI, IDisposable, CPBOEHNKFNO, KHNHHEFGFCA where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool FMLMOGOCFMM(Entity FPIIEOBJDDB, in T ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void MNDHKPGBPDO(Entity FPIIEOBJDDB, in T IDKFOCMLDHM, in T ALOICDECJNJ);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IMNMHFEADJO GHIJFOFIFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo MGBOAGEJKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int LMGCLJPIIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int FHMAJLHBFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int IBDNNEMEJLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private FMLMOGOCFMM HPMCKGNAANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private MNDHKPGBPDO NPMGEJNLDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private MNDHKPGBPDO CGHDEEJBBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World JNDJAEGBBCD;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x5A58670", Offset = "0x5A57470", VA = "0x185A58670", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override IMNMHFEADJO EFJMLCAOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81B570", Offset = "0x81A370", VA = "0x18081B570", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override KHNHHEFGFCA CIMGIEBMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0xA1BE90", Offset = "0xA1AC90", VA = "0x180A1BE90", Slot = "24")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo NACNPHBCKPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x81BCC0", Offset = "0x81AAC0", VA = "0x18081BCC0", Slot = "38")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int FPMKIBLCGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xE23610", Offset = "0xE22410", VA = "0x180E23610", Slot = "39")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int PGCDMDOPAFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x958780", Offset = "0x957580", VA = "0x180958780", Slot = "40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager FOKKLIPOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x4EA7970", Offset = "0x4EA6770", VA = "0x184EA7970")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5A5F5F0", Offset = "0x5A5E3F0", VA = "0x185A5F5F0")]
	public HPAGFMDLMJC(string PPPOJKMOIGD, IMNMHFEADJO GHIJFOFIFDG, FieldInfo MGBOAGEJKIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5D30", Offset = "0x4EA4B30", VA = "0x184EA5D30", Slot = "33")]
	public override void HFKECJNCAPE(EntityManager HCPDBMFJKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B880", Offset = "0x4D5A680", VA = "0x184D5B880")]
	public HPAGFMDLMJC<T> HNOLCBAHNCD(FMLMOGOCFMM HPMCKGNAANE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B8C0", Offset = "0x4D5A6C0", VA = "0x184D5B8C0")]
	public HPAGFMDLMJC<T> DLDFCBGBOPE(MNDHKPGBPDO NPMGEJNLDDB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D5B860", Offset = "0x4D5A660", VA = "0x184D5B860")]
	public HPAGFMDLMJC<T> EIHBCDCHMKD(MNDHKPGBPDO CGHDEEJBBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A890", Offset = "0x5A59690", VA = "0x185A5A890", Slot = "35")]
	public T KOLGIMOOKDG(Entity FPIIEOBJDDB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5A5DA90", Offset = "0x5A5C890", VA = "0x185A5DA90")]
	public bool MDELLMLPPIN(Entity FPIIEOBJDDB, in T ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4EA64B0", Offset = "0x4EA52B0", VA = "0x184EA64B0")]
	public bool KHHNEIIGAMI(Entity FPIIEOBJDDB, in T ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7910", Offset = "0x4EA6710", VA = "0x184EA7910", Slot = "25")]
	public override bool MIGIONPGLDD(Entity FPIIEOBJDDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5A59070", Offset = "0x5A57E70", VA = "0x185A59070", Slot = "26")]
	public override bool HFNDMEOOEJI(Entity FPIIEOBJDDB, in object ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5A5AA40", Offset = "0x5A59840", VA = "0x185A5AA40", Slot = "27")]
	public override void KOLGIMOOKDG(Entity FPIIEOBJDDB, in MKDNGEDKNED KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5A5E7A0", Offset = "0x5A5D5A0", VA = "0x185A5E7A0", Slot = "28")]
	public override bool MDELLMLPPIN(Entity FPIIEOBJDDB, in BIABKMPNANG ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A430", Offset = "0x5A59230", VA = "0x185A5A430", Slot = "29")]
	public override bool KHHNEIIGAMI(Entity FPIIEOBJDDB, in BIABKMPNANG ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x4EA6480", Offset = "0x4EA5280", VA = "0x184EA6480", Slot = "30")]
	public override void JOCNNHJBIBK(CJKIJIPCANL BCPIKEBGGDH, [Optional] object CNBGAPJABKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A59F20", Offset = "0x5A58D20", VA = "0x185A59F20", Slot = "31")]
	public override bool JJKBJMIFDEF(Entity FCAKJLDDKGP, Entity PEJGDDHHDBH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x8389D0", Offset = "0x8377D0", VA = "0x1808389D0", Slot = "32")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5A59810", Offset = "0x5A58610", VA = "0x185A59810", Slot = "34")]
	public override string HOIMKNNBNAG(in BIABKMPNANG NBCMLHOMALH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4EA7990", Offset = "0x4EA6790", VA = "0x184EA7990")]
	private bool OCABIOPIOAG(ref T IDKFOCMLDHM, ref T ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x4EA5D00", Offset = "0x4EA4B00", VA = "0x184EA5D00", Slot = "36")]
	private bool DMOPNKPHOCK(Entity LGKPJAJAOLI, in T ALOICDECJNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4EA69F0", Offset = "0x4EA57F0", VA = "0x184EA69F0", Slot = "37")]
	private bool LPLLLHFDBEH(Entity LGKPJAJAOLI, in T ALOICDECJNJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void LAOMKEABFOI<TKey>(TKey GNOEFMFMEOO, in BIABKMPNANG IDKFOCMLDHM, in BIABKMPNANG ALOICDECJNJ);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class OADPIOOOMIE
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5220800", Offset = "0x521F600", VA = "0x185220800")]
	public static void KEFABPFMPEM<TKey, T>(this LAOMKEABFOI<TKey> GLKBAIGAHCE, TKey GNOEFMFMEOO, T IDKFOCMLDHM, T ALOICDECJNJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CJKIJIPCANL
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJDGKBGOIGP<TKey, T>(PBPDJLMHCMH<TKey, T> ICNBGPBCJEH, [Optional] object CNBGAPJABKP) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BPBGPJKHEEF
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJDGKBGOIGP(DCMKKBFMJKI ICNBGPBCJEH, in BIABKMPNANG KKLNCEHOHED, [Optional] object CNBGAPJABKP);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KHNHHEFGFCA
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo MBOOOGBGCCH
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int BGAJCPLBEFB
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int MEOPDGLHJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface DCMKKBFMJKI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string KGBBPCBIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type MKAJEKLIICM
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	KHNHHEFGFCA CIMGIEBMBGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	IMNMHFEADJO EFJMLCAOFEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int NCJNHKMPGAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JOCNNHJBIBK(CJKIJIPCANL BCPIKEBGGDH, [Optional] object CNBGAPJABKP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface GKPDPGNIGKB<TKey> : DCMKKBFMJKI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event LAOMKEABFOI<TKey> INPOJHGJJIE;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MIGIONPGLDD(TKey LGKPJAJAOLI);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HFNDMEOOEJI(TKey LGKPJAJAOLI, in object ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KOLGIMOOKDG(TKey LGKPJAJAOLI, in MKDNGEDKNED KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool MDELLMLPPIN(TKey LGKPJAJAOLI, in BIABKMPNANG ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool KHHNEIIGAMI(TKey LGKPJAJAOLI, in BIABKMPNANG ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JJKBJMIFDEF(TKey FCAKJLDDKGP, TKey PEJGDDHHDBH);

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	string HOIMKNNBNAG(in BIABKMPNANG KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface PBPDJLMHCMH<TKey, T> : GKPDPGNIGKB<TKey>, DCMKKBFMJKI, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T KOLGIMOOKDG(TKey LGKPJAJAOLI);

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MDELLMLPPIN(TKey LGKPJAJAOLI, in T ALOICDECJNJ);

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHHNEIIGAMI(TKey LGKPJAJAOLI, in T ALOICDECJNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class GDLCEDJPFKN
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x3468970", Offset = "0x3467770", VA = "0x183468970")]
	public static bool BBJAFPAMNLG<TKey, T>(this GKPDPGNIGKB<TKey> ICNBGPBCJEH, TKey LGKPJAJAOLI, out T KKLNCEHOHED) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x34691A0", Offset = "0x3467FA0", VA = "0x1834691A0")]
	public static T KOLGIMOOKDG<T, TKey>(this GKPDPGNIGKB<TKey> ICNBGPBCJEH, TKey LGKPJAJAOLI) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x3469D60", Offset = "0x3468B60", VA = "0x183469D60")]
	public static bool MDELLMLPPIN<TKey, T>(this GKPDPGNIGKB<TKey> ICNBGPBCJEH, TKey LGKPJAJAOLI, T ALOICDECJNJ) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3468B10", Offset = "0x3467910", VA = "0x183468B10")]
	public static bool KHHNEIIGAMI<TKey, T>(this GKPDPGNIGKB<TKey> ICNBGPBCJEH, TKey LGKPJAJAOLI, T ALOICDECJNJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct KDKGBCPHDHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type LKLFHGBOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string PPPOJKMOIGD;

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	public KDKGBCPHDHM(Type LKLFHGBOOLP, string PPPOJKMOIGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct NIBEAOLLINL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type LKLFHGBOOLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string PPPOJKMOIGD;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xAFE080", Offset = "0xAFCE80", VA = "0x180AFE080")]
	public NIBEAOLLINL(Type LKLFHGBOOLP, string PPPOJKMOIGD)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3EC0640", Offset = "0x3EBF440", VA = "0x183EC0640")]
	public static KDKGBCPHDHM DIDFEIMNLJO(NIBEAOLLINL<T> MDAOFGMJFGD)
	{
		return default(KDKGBCPHDHM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum BPDEJNJKKFJ
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
public class KALMDJGKNJO : FAONFGCBPNO, IEnumerable<CPBOEHNKFNO>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<CPBOEHNKFNO> AENFAJFKJJL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x7000E90", Offset = "0x6FFFC90", VA = "0x187000E90", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public CPBOEHNKFNO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7000ED0", Offset = "0x6FFFCD0", VA = "0x187000ED0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7001420", Offset = "0x7000220", VA = "0x187001420")]
	public KALMDJGKNJO(IEnumerable<IMNMHFEADJO> DLMNECPJPHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x7000F30", Offset = "0x6FFFD30", VA = "0x187000F30")]
	private List<CPBOEHNKFNO> OBJFNKCDDHK(IEnumerable<IMNMHFEADJO> DLMNECPJPHI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x7000E10", Offset = "0x6FFFC10", VA = "0x187000E10", Slot = "4")]
	public IEnumerator<CPBOEHNKFNO> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7000E10", Offset = "0x6FFFC10", VA = "0x187000E10", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
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
