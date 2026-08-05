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
public sealed class DHDDIGFMHPD<TContainer, TField> : OBLNCFOMNCJ<TField> where TContainer : struct, IBufferElementData where TField : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE180", Offset = "0x3CAC780", VA = "0x183CAE180")]
	public DHDDIGFMHPD(string GJEDHMJMNJA, PDOIJPIDICD CAAMCMKANHA, FieldInfo KGIANKJNOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58C9E00", Offset = "0x58C8400", VA = "0x1858C9E00", Slot = "25")]
	public override bool ECADPABFBJL(Entity PIKIMHFFNIJ, FIEGLLHKFJI PIMFKGJDDND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class ADGNBLDMCMP<T> : OBLNCFOMNCJ<T> where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3CAE180", Offset = "0x3CAC780", VA = "0x183CAE180")]
	public ADGNBLDMCMP(string GJEDHMJMNJA, PDOIJPIDICD CAAMCMKANHA, FieldInfo KGIANKJNOCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[DefaultMember("Item")]
public abstract class OBLNCFOMNCJ<T> : KJNOLNMGKED, GAEJEJKJDNL<T>, JDBPBADKJGK<Entity, T>, BILJGDPFLDH<Entity>, MHOGBINFLBI, IDisposable, EKPIOBJJCMP, ONONAGDMNBJ where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public delegate bool EKOEHINONMA(Entity PIKIMHFFNIJ, [In] T PIMFKGJDDND);

	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public delegate void BIINAMDDKAI(Entity PIKIMHFFNIJ, [In] T HGHJDDJHCHJ, [In] T PIMFKGJDDND);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly PDOIJPIDICD CAAMCMKANHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly FieldInfo KGIANKJNOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	protected readonly int ECLABNAHOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	protected readonly int GCMGLJCEDLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly int LPKLLJKOBNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private EKOEHINONMA ONMIILIKHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private BIINAMDDKAI EDGCBNFJKAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private BIINAMDDKAI NKDHPOIOFBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private World DBIMBFMCJCE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public override Type LADEKBPIHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46BD290", Offset = "0x46BB890", VA = "0x1846BD290", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public override PDOIJPIDICD IHGAMKIMGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x868210", Offset = "0x866810", VA = "0x180868210", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public override ONONAGDMNBJ KNJIMDIBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8DA780", Offset = "0x8D8D80", VA = "0x1808DA780", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	private FieldInfo GFEJGOBAKON
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x868260", Offset = "0x866860", VA = "0x180868260", Slot = "32")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	private int IAPICFAEGNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x884A10", Offset = "0x883010", VA = "0x180884A10", Slot = "33")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	private int ICOPJBFMKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8764A0", Offset = "0x874AA0", VA = "0x1808764A0", Slot = "34")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	protected EntityManager PJGELPMLNAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x46BB260", Offset = "0x46B9860", VA = "0x1846BB260")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46BE900", Offset = "0x46BCF00", VA = "0x1846BE900")]
	internal OBLNCFOMNCJ(string GJEDHMJMNJA, PDOIJPIDICD CAAMCMKANHA, FieldInfo KGIANKJNOCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46BDD00", Offset = "0x46BC300", VA = "0x1846BDD00", Slot = "29")]
	public override void PNLKNBIHCGI(EntityManager NKGJNOFNMMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46B5D80", Offset = "0x46B4380", VA = "0x1846B5D80")]
	public OBLNCFOMNCJ<T> AHEAEMABGBF(EKOEHINONMA ONMIILIKHDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46B5DA0", Offset = "0x46B43A0", VA = "0x1846B5DA0")]
	public OBLNCFOMNCJ<T> DHOJEANGDJD(BIINAMDDKAI EDGCBNFJKAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46BD270", Offset = "0x46BB870", VA = "0x1846BD270")]
	public OBLNCFOMNCJ<T> NPINEPNEENO(BIINAMDDKAI NKDHPOIOFBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x46BC4A0", Offset = "0x46BAAA0", VA = "0x1846BC4A0", Slot = "31")]
	public T FOHHCFMHKPE(Entity PIKIMHFFNIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x46B9E00", Offset = "0x46B8400", VA = "0x1846B9E00")]
	public bool ECADPABFBJL(Entity PIKIMHFFNIJ, [In] T PIMFKGJDDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x46BD8F0", Offset = "0x46BBEF0", VA = "0x1846BD8F0")]
	public bool OGOBIGLKCOG(Entity PIKIMHFFNIJ, [In] T PIMFKGJDDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x46BB100", Offset = "0x46B9700", VA = "0x1846BB100", Slot = "23")]
	public override bool ELDMDCADOCM(Entity PIKIMHFFNIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x46BB310", Offset = "0x46B9910", VA = "0x1846BB310", Slot = "24")]
	public override void FOHHCFMHKPE(Entity PIKIMHFFNIJ, KDNOALABLGK DMNGPNKHPKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x46B8CC0", Offset = "0x46B72C0", VA = "0x1846B8CC0", Slot = "25")]
	public override bool ECADPABFBJL(Entity PIKIMHFFNIJ, FIEGLLHKFJI PIMFKGJDDND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x46BD240", Offset = "0x46BB840", VA = "0x1846BD240", Slot = "26")]
	public override void NNKGEJAMKAF(LCMFLDPIMCP HDIKBGHEBIH, [Optional] object CAMDIODFJJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x46B5330", Offset = "0x46B3930", VA = "0x1846B5330", Slot = "27")]
	public override bool AGJCCCHJIOG(Entity KEDMKHAFLGK, Entity MBEDFGIGBHI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790", Slot = "28")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x46BCA70", Offset = "0x46BB070", VA = "0x1846BCA70", Slot = "30")]
	public override string HHNOOLIPIBG([In] FIEGLLHKFJI GBFODJCCDLC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x46BD1D0", Offset = "0x46BB7D0", VA = "0x1846BD1D0")]
	private bool JBEDIOCGHIG(T HGHJDDJHCHJ, T PIMFKGJDDND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public abstract class KJNOLNMGKED : BMHDFKBMBBC, EKPIOBJJCMP, BILJGDPFLDH<Entity>, MHOGBINFLBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract Type LADEKBPIHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public abstract PDOIJPIDICD IHGAMKIMGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public abstract ONONAGDMNBJ KNJIMDIBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8681F0", Offset = "0x8667F0", VA = "0x1808681F0", Slot = "13")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x868270", Offset = "0x866870", VA = "0x180868270")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CCHNAOJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8F0D30", Offset = "0x8EF330", VA = "0x1808F0D30", Slot = "17")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8F0910", Offset = "0x8EEF10", VA = "0x1808F0910", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event GDDOGBHMMBA<Entity> FFABADIADKM
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F250", Offset = "0x6A0D850", VA = "0x186A0F250", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F300", Offset = "0x6A0D900", VA = "0x186A0F300", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract bool ELDMDCADOCM(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract void FOHHCFMHKPE(Entity PIKIMHFFNIJ, KDNOALABLGK DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract bool ECADPABFBJL(Entity PIKIMHFFNIJ, FIEGLLHKFJI PIMFKGJDDND);

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract void NNKGEJAMKAF(LCMFLDPIMCP HDIKBGHEBIH, [Optional] object CAMDIODFJJE);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract bool AGJCCCHJIOG(Entity KEDMKHAFLGK, Entity MBEDFGIGBHI);

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "29")]
	public abstract void PNLKNBIHCGI(EntityManager NKGJNOFNMMD);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2C38650", Offset = "0x2C36C50", VA = "0x182C38650")]
	protected void GFKKONMBANM<T>(Entity PIKIMHFFNIJ, [In] T HGHJDDJHCHJ, [In] T PIMFKGJDDND) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "30")]
	public abstract string HHNOOLIPIBG([In] FIEGLLHKFJI GBFODJCCDLC);

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	protected KJNOLNMGKED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface EKPIOBJJCMP : BILJGDPFLDH<Entity>, MHOGBINFLBI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface GAEJEJKJDNL<T> : JDBPBADKJGK<Entity, T>, BILJGDPFLDH<Entity>, MHOGBINFLBI, IDisposable, EKPIOBJJCMP where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
internal interface BMHDFKBMBBC : EKPIOBJJCMP, BILJGDPFLDH<Entity>, MHOGBINFLBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	new int CCHNAOJGLFG
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
public static class PMNLBPMIEIB
{
	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x2D46390", Offset = "0x2D44990", VA = "0x182D46390")]
	public static T IMMBFKHFHGI<T>(this GAEJEJKJDNL<T> FDKAIMCLOIA, Entity PIKIMHFFNIJ, [Optional] T DNKAMNBGFFH) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x2D331E0", Offset = "0x2D317E0", VA = "0x182D331E0")]
	public static T AACDCMAOBJC<T>(this BILJGDPFLDH<Entity> FDKAIMCLOIA, Entity PIKIMHFFNIJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x2D33390", Offset = "0x2D31990", VA = "0x182D33390")]
	public static bool IFICIMIEIPO<T>(this BILJGDPFLDH<Entity> FDKAIMCLOIA, Entity PIKIMHFFNIJ, [In] T PIMFKGJDDND) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x2D33320", Offset = "0x2D31920", VA = "0x182D33320")]
	public static bool IFICIMIEIPO<T>(this BILJGDPFLDH<Entity> FDKAIMCLOIA, Entity PIKIMHFFNIJ, NativeArray<T> PIMFKGJDDND) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void GDDOGBHMMBA<TKey>(TKey NJKKPOFFNNJ, [In] FIEGLLHKFJI HGHJDDJHCHJ, [In] FIEGLLHKFJI PIMFKGJDDND);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class EIFDJDLFGFJ
{
	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x2A36890", Offset = "0x2A34E90", VA = "0x182A36890")]
	public static void DKJHOBNJMII<TKey, T>(this GDDOGBHMMBA<TKey> EKBDOOPOGEF, TKey NJKKPOFFNNJ, T HGHJDDJHCHJ, T PIMFKGJDDND) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface LCMFLDPIMCP
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPAGIAFCGIC<TKey, T>(JDBPBADKJGK<TKey, T> FDKAIMCLOIA, [Optional] object CAMDIODFJJE) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface AGPFNEMGHMC
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface ONONAGDMNBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	FieldInfo IDIECFJCKLD
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	int MLKNMOMOHBP
	{
		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	int FPMEMCFLMNI
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface MHOGBINFLBI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	string OABCLOFHIGC
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	Type LADEKBPIHJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	ONONAGDMNBJ KNJIMDIBIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	PDOIJPIDICD IHGAMKIMGHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	int CCHNAOJGLFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NNKGEJAMKAF(LCMFLDPIMCP HDIKBGHEBIH, [Optional] object CAMDIODFJJE);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface BILJGDPFLDH<TKey> : MHOGBINFLBI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event GDDOGBHMMBA<TKey> FFABADIADKM;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ELDMDCADOCM(TKey IBBDLGCDELM);

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FOHHCFMHKPE(TKey IBBDLGCDELM, KDNOALABLGK DMNGPNKHPKF);

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ECADPABFBJL(TKey IBBDLGCDELM, FIEGLLHKFJI PIMFKGJDDND);

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool AGJCCCHJIOG(TKey KEDMKHAFLGK, TKey MBEDFGIGBHI);

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	string HHNOOLIPIBG([In] FIEGLLHKFJI DMNGPNKHPKF);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface JDBPBADKJGK<TKey, T> : BILJGDPFLDH<TKey>, MHOGBINFLBI, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T FOHHCFMHKPE(TKey IBBDLGCDELM);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class KBKOIPNGIDK
{
	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x2C33F10", Offset = "0x2C32510", VA = "0x182C33F10")]
	public static bool EGCGJKFAAFH<TKey, T>(this BILJGDPFLDH<TKey> FDKAIMCLOIA, TKey IBBDLGCDELM, [Out] T DMNGPNKHPKF) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x2C340E0", Offset = "0x2C326E0", VA = "0x182C340E0")]
	public static T FOHHCFMHKPE<T, TKey>(this BILJGDPFLDH<TKey> FDKAIMCLOIA, TKey IBBDLGCDELM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x2C336B0", Offset = "0x2C31CB0", VA = "0x182C336B0")]
	public static bool ECADPABFBJL<TKey, T>(this BILJGDPFLDH<TKey> FDKAIMCLOIA, TKey IBBDLGCDELM, T PIMFKGJDDND) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x2C337E0", Offset = "0x2C31DE0", VA = "0x182C337E0")]
	public static bool ECADPABFBJL<TKey, T>(this BILJGDPFLDH<TKey> FDKAIMCLOIA, TKey IBBDLGCDELM, NativeArray<T> PIMFKGJDDND) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[DefaultMember("Item")]
public interface KNCGIJNGIFC : IEnumerable<EKPIOBJJCMP>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public interface PDOIJPIDICD
{
	[Cpp2IlInjected.Token(Token = "0x17000016")]
	int CGJLIEPHGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	int FOEIEBIJELI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	Type HJNCIOECCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	EKPIOBJJCMP[] CLFJEMPDELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	bool GHECAHEJOBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	(uint, uint) LDAOJPNPAHH(Entity PIKIMHFFNIJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MFIEONCDENM(Entity PIKIMHFFNIJ, (uint order, uint change) CICFELNCFMD);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public class LDIHLMEIEHP : KNCGIJNGIFC, IEnumerable<EKPIOBJJCMP>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	private readonly List<EKPIOBJJCMP> KKLHNEBDLMI;

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ABEHPFBIDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F3B0", Offset = "0x6A0D9B0", VA = "0x186A0F3B0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EKPIOBJJCMP CNBHKAKEMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F910", Offset = "0x6A0DF10", VA = "0x186A0F910", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F970", Offset = "0x6A0DF70", VA = "0x186A0F970")]
	public LDIHLMEIEHP(IEnumerable<PDOIJPIDICD> GJPPIEOCEFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F3F0", Offset = "0x6A0D9F0", VA = "0x186A0F3F0")]
	private List<EKPIOBJJCMP> CIFBEAMKNDA(IEnumerable<PDOIJPIDICD> GJPPIEOCEFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F890", Offset = "0x6A0DE90", VA = "0x186A0F890", Slot = "4")]
	public IEnumerator<EKPIOBJJCMP> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F890", Offset = "0x6A0DE90", VA = "0x186A0F890", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public struct OBIBKJANHBG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly Type DEMPIAJMNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public readonly string GJEDHMJMNJA;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	public OBIBKJANHBG(Type DEMPIAJMNPG, string GJEDHMJMNJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public struct DJBDLMKHNKL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly Type DEMPIAJMNPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string GJEDHMJMNJA;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xAED250", Offset = "0xAEB850", VA = "0x180AED250")]
	public DJBDLMKHNKL(Type DEMPIAJMNPG, string GJEDHMJMNJA)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x58CDE20", Offset = "0x58CC420", VA = "0x1858CDE20")]
	public static OBIBKJANHBG LHEEBLLNOEI(DJBDLMKHNKL<T> AELLJGLCMFB)
	{
		return default(OBIBKJANHBG);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum KDOMMBAIAGI
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
public class DGOGLIDKJLN
{
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
	public DGOGLIDKJLN()
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
