using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Entities;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IOPADKNKOHG<TContainer, TField> : MDOIJDNBNCP<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B390", Offset = "0x3F4A390", VA = "0x183F4B390")]
	public IOPADKNKOHG(string CKEJJGPNKGO, OEMGHDACGNP HMLGIEBFMDJ, FieldInfo MOHEPMFPJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3F4AFC0", Offset = "0x3F49FC0", VA = "0x183F4AFC0", Slot = "26")]
	public override bool HACKMLKKHNE(Entity BOENFECPGGB, ADBKJBNECHF ECCBDOCBJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B2A0", Offset = "0x3F4A2A0", VA = "0x183F4B2A0", Slot = "32")]
	public override LNKAFBNJGBB PBIAAEGKBDI(EntityManager MLNFFPIMIMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class NCJIFHIPPJE<T> : MDOIJDNBNCP<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3F4B390", Offset = "0x3F4A390", VA = "0x183F4B390")]
	public NCJIFHIPPJE(string CKEJJGPNKGO, OEMGHDACGNP HMLGIEBFMDJ, FieldInfo MOHEPMFPJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x45D2420", Offset = "0x45D1420", VA = "0x1845D2420", Slot = "32")]
	public override LNKAFBNJGBB PBIAAEGKBDI(EntityManager MLNFFPIMIMD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class MDOIJDNBNCP<T> : PAJLOAPFOAG, KOGFBOJIDHK<T>, ENAKDCHIELK<Entity, T>, DMAJFPJENEJ<Entity>, GCALMPIEPIK, IDisposable, LNKAFBNJGBB, KBABPHKMCMM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool CKOANNNPPPD(Entity BOENFECPGGB, [In] T ECCBDOCBJDI);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void FKKOGKKMCAA(Entity BOENFECPGGB, [In] T PDEHPEFJKIF, [In] T ECCBDOCBJDI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly OEMGHDACGNP HMLGIEBFMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	protected readonly FieldInfo MOHEPMFPJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly int NMKJGMDJHGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly int BEMLKOBANDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int GHACOABIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private CKOANNNPPPD LKHKPGMICNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private FKKOGKKMCAA ADLAOGDIALD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private FKKOGKKMCAA MCDDKLLGFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World EJDHINIBNLN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type PNINAMLCHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x44D5B30", Offset = "0x44D4B30", VA = "0x1844D5B30", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override OEMGHDACGNP JOHJCLFEIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override KBABPHKMCMM AEFHBLDOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x97DF10", Offset = "0x97CF10", VA = "0x18097DF10", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo KDEPDGCPGGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int FJEHELLGFIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86FE90", Offset = "0x86EE90", VA = "0x18086FE90", Slot = "35")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int LPNBNKHFIMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x861470", Offset = "0x860470", VA = "0x180861470", Slot = "36")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager IAIHKKDCAON
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x44DB300", Offset = "0x44DA300", VA = "0x1844DB300")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x44DBD70", Offset = "0x44DAD70", VA = "0x1844DBD70")]
	internal MDOIJDNBNCP(string CKEJJGPNKGO, OEMGHDACGNP HMLGIEBFMDJ, FieldInfo MOHEPMFPJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x44D9860", Offset = "0x44D8860", VA = "0x1844D9860", Slot = "30")]
	public override void LFNNOPDGNGK(EntityManager OOHOEBAONBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x44D5970", Offset = "0x44D4970", VA = "0x1844D5970")]
	public MDOIJDNBNCP<T> FCPNLBNNBDO(CKOANNNPPPD LKHKPGMICNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x44D9600", Offset = "0x44D8600", VA = "0x1844D9600")]
	public MDOIJDNBNCP<T> JAFNDCFIDLH(FKKOGKKMCAA ADLAOGDIALD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x44D5990", Offset = "0x44D4990", VA = "0x1844D5990")]
	public MDOIJDNBNCP<T> FMIFMEKHEPL(FKKOGKKMCAA MCDDKLLGFAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x44DA0B0", Offset = "0x44D90B0", VA = "0x1844DA0B0", Slot = "33")]
	public T MKHPGHPCCLG(Entity BOENFECPGGB)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x44D6780", Offset = "0x44D5780", VA = "0x1844D6780")]
	public bool HACKMLKKHNE(Entity BOENFECPGGB, [In] T ECCBDOCBJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x44D9AA0", Offset = "0x44D8AA0", VA = "0x1844D9AA0")]
	public bool LLHIEPENCBP(Entity BOENFECPGGB, [In] T ECCBDOCBJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x44D9080", Offset = "0x44D8080", VA = "0x1844D9080", Slot = "24")]
	public override bool HDJFKMFFGDE(Entity BOENFECPGGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x44D9AF0", Offset = "0x44D8AF0", VA = "0x1844D9AF0", Slot = "25")]
	public override void MKHPGHPCCLG(Entity BOENFECPGGB, CCGKOGPBOEK JJCEIJMGOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x44D6B30", Offset = "0x44D5B30", VA = "0x1844D6B30", Slot = "26")]
	public override bool HACKMLKKHNE(Entity BOENFECPGGB, ADBKJBNECHF ECCBDOCBJDI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x3D22160", Offset = "0x3D21160", VA = "0x183D22160", Slot = "27")]
	public override void BDHKKFCAPAF(CBDPFLDJNHM IHIKDGBOEPI, [Optional] object PDLLDMABKGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x44DAC10", Offset = "0x44D9C10", VA = "0x1844DAC10", Slot = "28")]
	public override bool PANBNAPFBFN(Entity FLACBNGODHF, Entity ABGFGEMBNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950", Slot = "29")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x44D5500", Offset = "0x44D4500", VA = "0x1844D5500", Slot = "31")]
	public override string BCFBGMECKOG([In] ADBKJBNECHF PCMDDFJGLEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x44D5910", Offset = "0x44D4910", VA = "0x1844D5910")]
	private bool CPAAPCGEPLG(T PDEHPEFJKIF, T ECCBDOCBJDI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class PAJLOAPFOAG : IIBGCIBMPOC, LNKAFBNJGBB, DMAJFPJENEJ<Entity>, GCALMPIEPIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type PNINAMLCHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract OEMGHDACGNP JOHJCLFEIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract KBABPHKMCMM AEFHBLDOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "14")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x851880", Offset = "0x850880", VA = "0x180851880")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LLMLEFAHKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFE0", Offset = "0x9AAFE0", VA = "0x1809ABFE0", Slot = "18")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9ABFA0", Offset = "0x9AAFA0", VA = "0x1809ABFA0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event PHLDDPHEKEM<Entity> PMNJLBLDBLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x69842F0", Offset = "0x69832F0", VA = "0x1869842F0", Slot = "7")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69843A0", Offset = "0x69833A0", VA = "0x1869843A0", Slot = "8")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool HDJFKMFFGDE(Entity BOENFECPGGB);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void MKHPGHPCCLG(Entity BOENFECPGGB, CCGKOGPBOEK JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool HACKMLKKHNE(Entity BOENFECPGGB, ADBKJBNECHF ECCBDOCBJDI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void BDHKKFCAPAF(CBDPFLDJNHM IHIKDGBOEPI, [Optional] object PDLLDMABKGP);

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract bool PANBNAPFBFN(Entity FLACBNGODHF, Entity ABGFGEMBNMN);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract void LFNNOPDGNGK(EntityManager OOHOEBAONBK);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x2D69D60", Offset = "0x2D68D60", VA = "0x182D69D60")]
	protected void NGPEKMFGBMB<T>(Entity BOENFECPGGB, [In] T PDEHPEFJKIF, [In] T ECCBDOCBJDI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "31")]
	public abstract string BCFBGMECKOG([In] ADBKJBNECHF PCMDDFJGLEO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "32")]
	public abstract LNKAFBNJGBB PBIAAEGKBDI(EntityManager MLNFFPIMIMD);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	protected PAJLOAPFOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface LNKAFBNJGBB : DMAJFPJENEJ<Entity>, GCALMPIEPIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "0")]
	LNKAFBNJGBB PBIAAEGKBDI(EntityManager MLNFFPIMIMD);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KOGFBOJIDHK<T> : ENAKDCHIELK<Entity, T>, DMAJFPJENEJ<Entity>, GCALMPIEPIK, IDisposable, LNKAFBNJGBB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface IIBGCIBMPOC : LNKAFBNJGBB, DMAJFPJENEJ<Entity>, GCALMPIEPIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int LLMLEFAHKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class GDEPEBLPIHN
{
	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x2BB77E0", Offset = "0x2BB67E0", VA = "0x182BB77E0")]
	public static T IEECJHLOHFI<T>(this KOGFBOJIDHK<T> HNKKKCPLLDH, Entity BOENFECPGGB, [Optional] T KCDEJIJHLPJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x2BB79F0", Offset = "0x2BB69F0", VA = "0x182BB79F0")]
	public static T JFBGKIODNAI<T>(this DMAJFPJENEJ<Entity> HNKKKCPLLDH, Entity BOENFECPGGB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7C10", Offset = "0x2BB6C10", VA = "0x182BB7C10")]
	public static bool LMLMPGDBJPL<T>(this DMAJFPJENEJ<Entity> HNKKKCPLLDH, Entity BOENFECPGGB, [In] T ECCBDOCBJDI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x2BB7AF0", Offset = "0x2BB6AF0", VA = "0x182BB7AF0")]
	public static bool LMLMPGDBJPL<T>(this DMAJFPJENEJ<Entity> HNKKKCPLLDH, Entity BOENFECPGGB, NativeArray<T> ECCBDOCBJDI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void PHLDDPHEKEM<TKey>(TKey NOPFNIKINJA, [In] ADBKJBNECHF PDEHPEFJKIF, [In] ADBKJBNECHF ECCBDOCBJDI);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class MHKACFBMCDD
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x2CA4F70", Offset = "0x2CA3F70", VA = "0x182CA4F70")]
	public static void GHKHNOGELCE<TKey, T>(this PHLDDPHEKEM<TKey> ANPILJCEKDH, TKey NOPFNIKINJA, T PDEHPEFJKIF, T ECCBDOCBJDI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface CBDPFLDJNHM
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DEMJMOJAMCO<TKey, T>(ENAKDCHIELK<TKey, T> HNKKKCPLLDH, [Optional] object PDLLDMABKGP) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface PAOOLCNELJI
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface KBABPHKMCMM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo GHHEGBFJDMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IEOGBNCKHJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int ODOBBFBPIEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface GCALMPIEPIK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string NPDJPDJBDCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type PNINAMLCHFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	KBABPHKMCMM AEFHBLDOFCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	OEMGHDACGNP JOHJCLFEIEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int LLMLEFAHKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BDHKKFCAPAF(CBDPFLDJNHM IHIKDGBOEPI, [Optional] object PDLLDMABKGP);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface DMAJFPJENEJ<TKey> : GCALMPIEPIK, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event PHLDDPHEKEM<TKey> PMNJLBLDBLM;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HDJFKMFFGDE(TKey GMFCIHEFPPO);

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKHPGHPCCLG(TKey GMFCIHEFPPO, CCGKOGPBOEK JJCEIJMGOAB);

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool HACKMLKKHNE(TKey GMFCIHEFPPO, ADBKJBNECHF ECCBDOCBJDI);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PANBNAPFBFN(TKey FLACBNGODHF, TKey ABGFGEMBNMN);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string BCFBGMECKOG([In] ADBKJBNECHF JJCEIJMGOAB);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface ENAKDCHIELK<TKey, T> : DMAJFPJENEJ<TKey>, GCALMPIEPIK, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T MKHPGHPCCLG(TKey GMFCIHEFPPO);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class BJMDMKNLFPP
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x292C680", Offset = "0x292B680", VA = "0x18292C680")]
	public static bool KBNDOKPPALD<TKey, T>(this DMAJFPJENEJ<TKey> HNKKKCPLLDH, TKey GMFCIHEFPPO, [Out] T JJCEIJMGOAB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x292C850", Offset = "0x292B850", VA = "0x18292C850")]
	public static T MKHPGHPCCLG<T, TKey>(this DMAJFPJENEJ<TKey> HNKKKCPLLDH, TKey GMFCIHEFPPO) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x292BE30", Offset = "0x292AE30", VA = "0x18292BE30")]
	public static bool HACKMLKKHNE<TKey, T>(this DMAJFPJENEJ<TKey> HNKKKCPLLDH, TKey GMFCIHEFPPO, T ECCBDOCBJDI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x292BF60", Offset = "0x292AF60", VA = "0x18292BF60")]
	public static bool HACKMLKKHNE<TKey, T>(this DMAJFPJENEJ<TKey> HNKKKCPLLDH, TKey GMFCIHEFPPO, NativeArray<T> ECCBDOCBJDI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface FAGJBDMLBAC : IEnumerable<LNKAFBNJGBB>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface OEMGHDACGNP
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int IEALIGGFHEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int BOMKLHPJDEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type FGPBIKDEEEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	LNKAFBNJGBB[] ELDHPFKIBMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool ILNBEENNOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) NFMPNLDJPPB(Entity BOENFECPGGB);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class PMFMOOPDMLJ : FAGJBDMLBAC, IEnumerable<LNKAFBNJGBB>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<LNKAFBNJGBB> ICBFOLIMOGO;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int DHMBIHOHONP
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x69849D0", Offset = "0x69839D0", VA = "0x1869849D0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public LNKAFBNJGBB OMCGAJCFHLP
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6984450", Offset = "0x6983450", VA = "0x186984450", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6984A10", Offset = "0x6983A10", VA = "0x186984A10")]
	public PMFMOOPDMLJ(IEnumerable<OEMGHDACGNP> EAPMANGCMEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69844B0", Offset = "0x69834B0", VA = "0x1869844B0")]
	private List<LNKAFBNJGBB> FKGBDPKPLJP(IEnumerable<OEMGHDACGNP> EAPMANGCMEL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6984950", Offset = "0x6983950", VA = "0x186984950", Slot = "4")]
	public IEnumerator<LNKAFBNJGBB> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6984950", Offset = "0x6983950", VA = "0x186984950", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct NEIMDFCACOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type HBCHBKJGLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string CKEJJGPNKGO;

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	public NEIMDFCACOK(Type HBCHBKJGLFA, string CKEJJGPNKGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct NAOOJFEJGBJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type HBCHBKJGLFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string CKEJJGPNKGO;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0xB852B0", Offset = "0xB842B0", VA = "0x180B852B0")]
	public NAOOJFEJGBJ(Type HBCHBKJGLFA, string CKEJJGPNKGO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x45D0960", Offset = "0x45CF960", VA = "0x1845D0960")]
	public static NEIMDFCACOK MGAEGIHGHKD(NAOOJFEJGBJ<T> MBADFNLOLBF)
	{
		return default(NEIMDFCACOK);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum IEOOBIAOKDF
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
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class HCDGHKBPKAH
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public HCDGHKBPKAH()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
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
