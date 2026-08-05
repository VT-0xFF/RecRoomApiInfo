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
public sealed class NCGEGALJOPM<TContainer, TField> : NHMIGJKDCDN<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x418A8E0", Offset = "0x4188EE0", VA = "0x18418A8E0")]
	public NCGEGALJOPM(string LCLKDNPLMED, HFIGDOGGFPM BMDINFODMJG, FieldInfo LLLDIILICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x453BEA0", Offset = "0x453A4A0", VA = "0x18453BEA0", Slot = "25")]
	public override bool LHLEJLJODIO(Entity JOAHHHNEJGM, BBEAFPNMONC KPJPGFGPJMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class CDPOPIMDDJH<T> : NHMIGJKDCDN<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x418A8E0", Offset = "0x4188EE0", VA = "0x18418A8E0")]
	public CDPOPIMDDJH(string LCLKDNPLMED, HFIGDOGGFPM BMDINFODMJG, FieldInfo LLLDIILICAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class NHMIGJKDCDN<T> : FDCIIJJPHHI, KLCOMAAAKGJ<T>, JHCLKHPPOFH<Entity, T>, AKEPMCFDLOM<Entity>, KIBDNPLNELB, IDisposable, AFPNNMHOJOP, DELANDFOCNM where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool FDFNMANAHLC(Entity JOAHHHNEJGM, [In] T KPJPGFGPJMK);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void GEEBKIICANI(Entity JOAHHHNEJGM, [In] T PFFGIJKHLGP, [In] T KPJPGFGPJMK);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly HFIGDOGGFPM BMDINFODMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo LLLDIILICAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int OPLDNLPEEPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int ANNLKNNLIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int ENCFHCJIMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private FDFNMANAHLC MJGAPMEBHCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private GEEBKIICANI GPJGANGLHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private GEEBKIICANI DAJLIMMHBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World NONINMLLOEG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type MDBCEFGBENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x455C4D0", Offset = "0x455AAD0", VA = "0x18455C4D0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override HFIGDOGGFPM BDGDOILKODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override DELANDFOCNM NJMGHBIDLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x92F360", Offset = "0x92D960", VA = "0x18092F360", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo OJAIGJGNHDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int BKOJBOMCNFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x880980", Offset = "0x87EF80", VA = "0x180880980", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int BHHPKBJIPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8723F0", Offset = "0x8709F0", VA = "0x1808723F0", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager GBKAKLNHENB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x45626C0", Offset = "0x4560CC0", VA = "0x1845626C0")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x45635E0", Offset = "0x4561BE0", VA = "0x1845635E0")]
	internal NHMIGJKDCDN(string LCLKDNPLMED, HFIGDOGGFPM BMDINFODMJG, FieldInfo LLLDIILICAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x455B5B0", Offset = "0x4559BB0", VA = "0x18455B5B0", Slot = "29")]
	public override void BGGINNGCCML(EntityManager EHDLNANHIAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x455CA90", Offset = "0x455B090", VA = "0x18455CA90")]
	public NHMIGJKDCDN<T> HEAKFNBKMHH(FDFNMANAHLC MJGAPMEBHCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x455D520", Offset = "0x455BB20", VA = "0x18455D520")]
	public NHMIGJKDCDN<T> LFIBOBMMAGO(GEEBKIICANI GPJGANGLHBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x455D500", Offset = "0x455BB00", VA = "0x18455D500")]
	public NHMIGJKDCDN<T> INDGKAHBHCC(GEEBKIICANI DAJLIMMHBIA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x455A9E0", Offset = "0x4558FE0", VA = "0x18455A9E0", Slot = "31")]
	public T BDJJCDMMBKL(Entity JOAHHHNEJGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x455FCB0", Offset = "0x455E2B0", VA = "0x18455FCB0")]
	public bool LHLEJLJODIO(Entity JOAHHHNEJGM, [In] T KPJPGFGPJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x455CA40", Offset = "0x455B040", VA = "0x18455CA40")]
	public bool FPGCMFAOINK(Entity JOAHHHNEJGM, [In] T KPJPGFGPJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x455BA10", Offset = "0x455A010", VA = "0x18455BA10", Slot = "23")]
	public override bool EKGDBOHPAIM(Entity JOAHHHNEJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x4559E50", Offset = "0x4558450", VA = "0x184559E50", Slot = "24")]
	public override void BDJJCDMMBKL(Entity JOAHHHNEJGM, COADBPFMFML CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x455E1C0", Offset = "0x455C7C0", VA = "0x18455E1C0", Slot = "25")]
	public override bool LHLEJLJODIO(Entity JOAHHHNEJGM, BBEAFPNMONC KPJPGFGPJMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x455CA10", Offset = "0x455B010", VA = "0x18455CA10", Slot = "26")]
	public override void FMGFJIIGOKL(KILMHPGNCGJ AIECDDCJNNL, [Optional] object FFHIJMOJNAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x455D3D0", Offset = "0x455B9D0", VA = "0x18455D3D0", Slot = "27")]
	public override bool IELCMBBNHEG(Entity FIEEIAHPDIF, Entity LPPNOBMEEDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x45624F0", Offset = "0x4560AF0", VA = "0x1845624F0", Slot = "30")]
	public override string MMCPJIPKLNO([In] BBEAFPNMONC ANGCAOLPDHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x455B790", Offset = "0x4559D90", VA = "0x18455B790")]
	private bool EHCCFIAHGOE(T PFFGIJKHLGP, T KPJPGFGPJMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class FDCIIJJPHHI : GDGPJAJOFHB, AFPNNMHOJOP, AKEPMCFDLOM<Entity>, KIBDNPLNELB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type MDBCEFGBENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract HFIGDOGGFPM BDGDOILKODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract DELANDFOCNM NJMGHBIDLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int NEFBBEPGOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8D8B10", Offset = "0x8D7110", VA = "0x1808D8B10", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8D90D0", Offset = "0x8D76D0", VA = "0x1808D90D0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event ODGGDNLAFLA<Entity> IKJMGBBJELI
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6948950", Offset = "0x6946F50", VA = "0x186948950", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x69488A0", Offset = "0x6946EA0", VA = "0x1869488A0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool EKGDBOHPAIM(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void BDJJCDMMBKL(Entity JOAHHHNEJGM, COADBPFMFML CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool LHLEJLJODIO(Entity JOAHHHNEJGM, BBEAFPNMONC KPJPGFGPJMK);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void FMGFJIIGOKL(KILMHPGNCGJ AIECDDCJNNL, [Optional] object FFHIJMOJNAI);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool IELCMBBNHEG(Entity FIEEIAHPDIF, Entity LPPNOBMEEDD);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void BGGINNGCCML(EntityManager EHDLNANHIAB);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2AED390", Offset = "0x2AEB990", VA = "0x182AED390")]
	protected void CEPDMIFLEIM<T>(Entity JOAHHHNEJGM, [In] T PFFGIJKHLGP, [In] T KPJPGFGPJMK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string MMCPJIPKLNO([In] BBEAFPNMONC ANGCAOLPDHD);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected FDCIIJJPHHI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface AFPNNMHOJOP : AKEPMCFDLOM<Entity>, KIBDNPLNELB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface KLCOMAAAKGJ<T> : JHCLKHPPOFH<Entity, T>, AKEPMCFDLOM<Entity>, KIBDNPLNELB, IDisposable, AFPNNMHOJOP where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface GDGPJAJOFHB : AFPNNMHOJOP, AKEPMCFDLOM<Entity>, KIBDNPLNELB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int NEFBBEPGOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class LDNMIIDDAEN
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1E40", Offset = "0x2BE0440", VA = "0x182BE1E40")]
	public static T LDHPDKNBLHM<T>(this KLCOMAAAKGJ<T> PDOOMGNBLHC, Entity JOAHHHNEJGM, [Optional] T AJMLHGDNPEK) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1D30", Offset = "0x2BE0330", VA = "0x182BE1D30")]
	public static T CMHCDGKNPKK<T>(this AKEPMCFDLOM<Entity> PDOOMGNBLHC, Entity JOAHHHNEJGM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1BA0", Offset = "0x2BE01A0", VA = "0x182BE1BA0")]
	public static bool AKJKJJBMIND<T>(this AKEPMCFDLOM<Entity> PDOOMGNBLHC, Entity JOAHHHNEJGM, [In] T KPJPGFGPJMK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1AB0", Offset = "0x2BE00B0", VA = "0x182BE1AB0")]
	public static bool AKJKJJBMIND<T>(this AKEPMCFDLOM<Entity> PDOOMGNBLHC, Entity JOAHHHNEJGM, NativeArray<T> KPJPGFGPJMK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void ODGGDNLAFLA<TKey>(TKey HBFCGFKGCAF, [In] BBEAFPNMONC PFFGIJKHLGP, [In] BBEAFPNMONC KPJPGFGPJMK);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class DOIPHLCGKMC
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x29792F0", Offset = "0x29778F0", VA = "0x1829792F0")]
	public static void NGOOLELHLHP<TKey, T>(this ODGGDNLAFLA<TKey> FHKGLGIJDMO, TKey HBFCGFKGCAF, T PFFGIJKHLGP, T KPJPGFGPJMK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KILMHPGNCGJ
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void APKOFNNACEJ<TKey, T>(JHCLKHPPOFH<TKey, T> PDOOMGNBLHC, [Optional] object FFHIJMOJNAI) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface BLMMBMALOLL
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface DELANDFOCNM
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo PBDCGFBGILE
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int IFJJLDMODPI
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int PMILGDKKIIM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface KIBDNPLNELB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string CDMBLCLEAGO
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type MDBCEFGBENA
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	DELANDFOCNM NJMGHBIDLBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	HFIGDOGGFPM BDGDOILKODH
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int NEFBBEPGOOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FMGFJIIGOKL(KILMHPGNCGJ AIECDDCJNNL, [Optional] object FFHIJMOJNAI);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface AKEPMCFDLOM<TKey> : KIBDNPLNELB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event ODGGDNLAFLA<TKey> IKJMGBBJELI;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EKGDBOHPAIM(TKey BHEIPBKEDLG);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDJJCDMMBKL(TKey BHEIPBKEDLG, COADBPFMFML CBAEIEAPLIH);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool LHLEJLJODIO(TKey BHEIPBKEDLG, BBEAFPNMONC KPJPGFGPJMK);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IELCMBBNHEG(TKey FIEEIAHPDIF, TKey LPPNOBMEEDD);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string MMCPJIPKLNO([In] BBEAFPNMONC CBAEIEAPLIH);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface JHCLKHPPOFH<TKey, T> : AKEPMCFDLOM<TKey>, KIBDNPLNELB, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T BDJJCDMMBKL(TKey BHEIPBKEDLG);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LDOMPAGDAMJ
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2AB0", Offset = "0x2BE10B0", VA = "0x182BE2AB0")]
	public static bool KCOKGBINLEI<TKey, T>(this AKEPMCFDLOM<TKey> PDOOMGNBLHC, TKey BHEIPBKEDLG, [Out] T CBAEIEAPLIH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2BE1FC0", Offset = "0x2BE05C0", VA = "0x182BE1FC0")]
	public static T BDJJCDMMBKL<T, TKey>(this AKEPMCFDLOM<TKey> PDOOMGNBLHC, TKey BHEIPBKEDLG) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2C80", Offset = "0x2BE1280", VA = "0x182BE2C80")]
	public static bool LHLEJLJODIO<TKey, T>(this AKEPMCFDLOM<TKey> PDOOMGNBLHC, TKey BHEIPBKEDLG, T KPJPGFGPJMK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2BE2EE0", Offset = "0x2BE14E0", VA = "0x182BE2EE0")]
	public static bool LHLEJLJODIO<TKey, T>(this AKEPMCFDLOM<TKey> PDOOMGNBLHC, TKey BHEIPBKEDLG, NativeArray<T> KPJPGFGPJMK) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface HLJPOPCIEFC : IEnumerable<AFPNNMHOJOP>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface HFIGDOGGFPM
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int NPGHFNEBGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int AKBOJOBJCMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type LHCEMHBCCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	AFPNNMHOJOP[] EINIMGGADFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool AFBEBJGCBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) KJMPJHMNHMC(Entity JOAHHHNEJGM);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool OAMJIHHCPMI(Entity JOAHHHNEJGM, (uint order, uint change) HNNOPDLCPBM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class DNBOHHLFNFC : HLJPOPCIEFC, IEnumerable<AFPNNMHOJOP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<AFPNNMHOJOP> EGABGCEEIBN;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6948820", Offset = "0x6946E20", VA = "0x186948820", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public AFPNNMHOJOP PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x69482A0", Offset = "0x69468A0", VA = "0x1869482A0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6948860", Offset = "0x6946E60", VA = "0x186948860")]
	public DNBOHHLFNFC(IEnumerable<HFIGDOGGFPM> GPNPODHFECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6948380", Offset = "0x6946980", VA = "0x186948380")]
	private List<AFPNNMHOJOP> ONDMIFOJLAB(IEnumerable<HFIGDOGGFPM> GPNPODHFECE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6948300", Offset = "0x6946900", VA = "0x186948300", Slot = "4")]
	public IEnumerator<AFPNNMHOJOP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6948300", Offset = "0x6946900", VA = "0x186948300", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct BCNGOELDNOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type MELFDBGCIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string LCLKDNPLMED;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
	public BCNGOELDNOO(Type MELFDBGCIGI, string LCLKDNPLMED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct FLJCJPKCPFE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type MELFDBGCIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string LCLKDNPLMED;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAB3FA0", Offset = "0xAB25A0", VA = "0x180AB3FA0")]
	public FLJCJPKCPFE(Type MELFDBGCIGI, string LCLKDNPLMED)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3C53C10", Offset = "0x3C52210", VA = "0x183C53C10")]
	public static BCNGOELDNOO DOKLILKCHEM(FLJCJPKCPFE<T> FPNKOEEAPPG)
	{
		return default(BCNGOELDNOO);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum OJOPCPLKMDG
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
public class ECFAFCMGIDH
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public ECFAFCMGIDH()
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
