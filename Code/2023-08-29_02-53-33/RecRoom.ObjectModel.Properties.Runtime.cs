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
public interface NKCEGLFKHJA : IEnumerable<OMADGHGGHJN>, IEnumerable
{
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OMADGHGGHJN : KFFHHBDDKDC<Entity>, COKGGJJNNDI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface OFGHMODICKB<T> : MHOBFBAOGME<Entity, T>, KFFHHBDDKDC<Entity>, COKGGJJNNDI, IDisposable, OMADGHGGHJN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal interface HAPKIHNNMGB : OMADGHGGHJN, KFFHHBDDKDC<Entity>, COKGGJJNNDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	new int FFKGOHONJLM
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
public static class INDLKCPKPNK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xBC7350", Offset = "0xBC6750", VA = "0x180BC7350")]
	public static T MBLNHLDPNHC<T>(this OFGHMODICKB<T> HNNIGEFAIIM, Entity FKNFFDFGNMN, [Optional] T OLNFJPNAOBM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xBC7240", Offset = "0xBC6640", VA = "0x180BC7240")]
	public static T BMFFBKGOGNK<T>(this KFFHHBDDKDC<Entity> HNNIGEFAIIM, Entity FKNFFDFGNMN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xBC74B0", Offset = "0xBC68B0", VA = "0x180BC74B0")]
	public static bool MGFALPCKMEG<T>(this KFFHHBDDKDC<Entity> HNNIGEFAIIM, Entity FKNFFDFGNMN, in T NDKKBDCFLEC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface OPHEKAOFDCM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	int NAADCFCOCEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	int HDMOGHBEKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	Type CKOMOAEOHDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	OMADGHGGHJN[] DGLNIIDFHFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	(uint, uint) NDGBPOMPPGO(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BEBJJPJJHPD(Entity FKNFFDFGNMN, (uint order, uint change) HEGEMCIFGEI);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public abstract class OKCMINBFHJA : HAPKIHNNMGB, OMADGHGGHJN, KFFHHBDDKDC<Entity>, COKGGJJNNDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public abstract Type JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public abstract OPHEKAOFDCM BDLMLIAIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public abstract CBKEFCCBIHK CGPBOEFMOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public string GHALHBJBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "12")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7F3110", Offset = "0x7F2510", VA = "0x1807F3110")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int FFKGOHONJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0xA71600", Offset = "0xA70A00", VA = "0x180A71600", Slot = "16")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC0E800", Offset = "0xC0DC00", VA = "0x180C0E800", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event CDOKGDJBJCM<Entity> FMPPFIKKFCM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA5720", Offset = "0x6FA4B20", VA = "0x186FA5720", Slot = "6")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA57C0", Offset = "0x6FA4BC0", VA = "0x186FA57C0", Slot = "7")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "22")]
	public abstract bool HABKCECLKEN(Entity FKNFFDFGNMN);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "23")]
	public abstract void IKHPLCCBENN(Entity FKNFFDFGNMN, PHJBMACKBCD KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "24")]
	public abstract bool DADPJLGDIHI(Entity FKNFFDFGNMN, NBOENLAPDFO NDKKBDCFLEC);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "25")]
	public abstract void KOJIBCNMEML(KFBFMDMFJDA MFMFLMKKKDK, [Optional] object JNNDIHFHMHC);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "26")]
	public abstract bool DGCDPJOAHEA(Entity OPMNDBPHMGG, Entity CDNLFOGBLLG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "27")]
	public abstract void Dispose();

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "28")]
	public abstract void BEFDPLAELIH(EntityManager GLPCEPPDPLB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x12C9A40", Offset = "0x12C8E40", VA = "0x1812C9A40")]
	protected void HLCGGJCBBMJ<T>(Entity FKNFFDFGNMN, in T PHNODIMLADH, in T NDKKBDCFLEC) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	protected OKCMINBFHJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[DefaultMember("Item")]
public class MDGCCNJAIOM<T> : OKCMINBFHJA, OFGHMODICKB<T>, MHOBFBAOGME<Entity, T>, KFFHHBDDKDC<Entity>, COKGGJJNNDI, IDisposable, OMADGHGGHJN, CBKEFCCBIHK where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public delegate bool EBMEHMPEJLM(Entity FKNFFDFGNMN, in T NDKKBDCFLEC);

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public delegate void IGAPLGLOAHP(Entity FKNFFDFGNMN, in T PHNODIMLADH, in T NDKKBDCFLEC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OPHEKAOFDCM IOEMOEOMBGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly FieldInfo LILDEEPOOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly int EPAJCDGEEKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private readonly int IFONHBAKCAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly int JECAINLJFKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private EBMEHMPEJLM IEJNLAFNPEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private IGAPLGLOAHP FBNPDNPCMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private IGAPLGLOAHP PNKBDJOBKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private World BDLCNPMEDLI;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public override Type JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x2DDB6E0", Offset = "0x2DDAAE0", VA = "0x182DDB6E0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public override OPHEKAOFDCM BDLMLIAIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x7F2BB0", Offset = "0x7F1FB0", VA = "0x1807F2BB0", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public override CBKEFCCBIHK CGPBOEFMOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9BB570", Offset = "0x9BA970", VA = "0x1809BB570", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private FieldInfo PGEJEHPAMKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350", Slot = "30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private int JDKHFOOOPHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xE5B630", Offset = "0xE5AA30", VA = "0x180E5B630", Slot = "31")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private int HCIOONKHBKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x97D390", Offset = "0x97C790", VA = "0x18097D390", Slot = "32")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EntityManager FCLKPLIBOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x2DDBF40", Offset = "0x2DDB340", VA = "0x182DDBF40")]
		get
		{
			return default(EntityManager);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBF60", Offset = "0x2DDB360", VA = "0x182DDBF60")]
	public MDGCCNJAIOM(string DKPHPKDPBCM, OPHEKAOFDCM IOEMOEOMBGI, FieldInfo LILDEEPOOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB5E0", Offset = "0x2DDA9E0", VA = "0x182DDB5E0", Slot = "28")]
	public override void BEFDPLAELIH(EntityManager GLPCEPPDPLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBDB0", Offset = "0x2DDB1B0", VA = "0x182DDBDB0")]
	public MDGCCNJAIOM<T> FAMLMNNEJMC(EBMEHMPEJLM IEJNLAFNPEP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBD90", Offset = "0x2DDB190", VA = "0x182DDBD90")]
	public MDGCCNJAIOM<T> DKBFPGJEPHA(IGAPLGLOAHP FBNPDNPCMEN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB660", Offset = "0x2DDAA60", VA = "0x182DDB660")]
	public MDGCCNJAIOM<T> CHMCFFJKAKA(IGAPLGLOAHP PNKBDJOBKGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x53B85C0", Offset = "0x53B79C0", VA = "0x1853B85C0", Slot = "29")]
	public T IKHPLCCBENN(Entity FKNFFDFGNMN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBA40", Offset = "0x2DDAE40", VA = "0x182DDBA40")]
	public bool DADPJLGDIHI(Entity FKNFFDFGNMN, in T NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB5A0", Offset = "0x2DDA9A0", VA = "0x182DDB5A0")]
	public bool ABHLIIHALEM(Entity FKNFFDFGNMN, in T NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBDD0", Offset = "0x2DDB1D0", VA = "0x182DDBDD0", Slot = "22")]
	public override bool HABKCECLKEN(Entity FKNFFDFGNMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBE30", Offset = "0x2DDB230", VA = "0x182DDBE30", Slot = "23")]
	public override void IKHPLCCBENN(Entity FKNFFDFGNMN, PHJBMACKBCD KKIAKNLLHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB9D0", Offset = "0x2DDADD0", VA = "0x182DDB9D0", Slot = "24")]
	public override bool DADPJLGDIHI(Entity FKNFFDFGNMN, NBOENLAPDFO NDKKBDCFLEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBF10", Offset = "0x2DDB310", VA = "0x182DDBF10", Slot = "25")]
	public override void KOJIBCNMEML(KFBFMDMFJDA MFMFLMKKKDK, [Optional] object JNNDIHFHMHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x2DDBCD0", Offset = "0x2DDB0D0", VA = "0x182DDBCD0", Slot = "26")]
	public override bool DGCDPJOAHEA(Entity OPMNDBPHMGG, Entity CDNLFOGBLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "27")]
	public override void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x2DDB610", Offset = "0x2DDAA10", VA = "0x182DDB610")]
	private bool BLOEHGLCONB(ref T PHNODIMLADH, ref T NDKKBDCFLEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public delegate void CDOKGDJBJCM<TKey>(TKey ICNDEPGFBMI, in NBOENLAPDFO PHNODIMLADH, in NBOENLAPDFO NDKKBDCFLEC);
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class BAKAHEOCDKG
{
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x1434150", Offset = "0x1433550", VA = "0x181434150")]
	public static void GDOLIKHHLHI<TKey, T>(this CDOKGDJBJCM<TKey> PBINDDPPGGK, TKey ICNDEPGFBMI, T PHNODIMLADH, T NDKKBDCFLEC) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public interface KFBFMDMFJDA
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNAMDFAOIPA<TKey, T>(MHOBFBAOGME<TKey, T> HNNIGEFAIIM, [Optional] object JNNDIHFHMHC) where T : struct;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public interface DDIJEFLLJNB
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public interface CBKEFCCBIHK
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	FieldInfo BEEHOAGPFOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	int JLBPIHHCKJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	int FMHNBEKGHPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public interface COKGGJJNNDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000015")]
	string GHALHBJBCAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	Type JJGFPAEGNBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	CBKEFCCBIHK CGPBOEFMOBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	OPHEKAOFDCM BDLMLIAIJEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	int FFKGOHONJLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KOJIBCNMEML(KFBFMDMFJDA MFMFLMKKKDK, [Optional] object JNNDIHFHMHC);
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public interface KFFHHBDDKDC<TKey> : COKGGJJNNDI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event CDOKGDJBJCM<TKey> FMPPFIKKFCM;

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool HABKCECLKEN(TKey KOFPKIJDAMC);

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IKHPLCCBENN(TKey KOFPKIJDAMC, PHJBMACKBCD KKIAKNLLHIO);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DADPJLGDIHI(TKey KOFPKIJDAMC, NBOENLAPDFO NDKKBDCFLEC);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DGCDPJOAHEA(TKey OPMNDBPHMGG, TKey CDNLFOGBLLG);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[DefaultMember("Item")]
public interface MHOBFBAOGME<TKey, T> : KFFHHBDDKDC<TKey>, COKGGJJNNDI, IDisposable where T : struct
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(Slot = "0")]
	T IKHPLCCBENN(TKey KOFPKIJDAMC);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class FLKBENOLJJA
{
	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x1966C90", Offset = "0x1966090", VA = "0x181966C90")]
	public static bool NALDPHOGDDM<TKey, T>(this KFFHHBDDKDC<TKey> HNNIGEFAIIM, TKey KOFPKIJDAMC, out T KKIAKNLLHIO) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x1966060", Offset = "0x1965460", VA = "0x181966060")]
	public static T IKHPLCCBENN<T, TKey>(this KFFHHBDDKDC<TKey> HNNIGEFAIIM, TKey KOFPKIJDAMC) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x1965750", Offset = "0x1964B50", VA = "0x181965750")]
	public static bool DADPJLGDIHI<TKey, T>(this KFFHHBDDKDC<TKey> HNNIGEFAIIM, TKey KOFPKIJDAMC, T NDKKBDCFLEC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct NNHEPJDBKBI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public readonly Type NJHGLCPHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public readonly string DKPHPKDPBCM;

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0xD82A00", Offset = "0xD81E00", VA = "0x180D82A00")]
	public NNHEPJDBKBI(Type NJHGLCPHLGF, string DKPHPKDPBCM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct AFHAKKMHKHI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public readonly Type NJHGLCPHLGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly string DKPHPKDPBCM;

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0xD82A00", Offset = "0xD81E00", VA = "0x180D82A00")]
	public AFHAKKMHKHI(Type NJHGLCPHLGF, string DKPHPKDPBCM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x2A2BBE0", Offset = "0x2A2AFE0", VA = "0x182A2BBE0")]
	public static NNHEPJDBKBI PCDMEOKPMGD(AFHAKKMHKHI<T> CHLMEBOBPLJ)
	{
		return default(NNHEPJDBKBI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum IMANFILHHLA
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
public class NNDFCMOOFMO : NKCEGLFKHJA, IEnumerable<OMADGHGGHJN>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly List<OMADGHGGHJN> DJBHEPFIJAL;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int NPBPHODFKMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x6FA56A0", Offset = "0x6FA4AA0", VA = "0x186FA56A0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OMADGHGGHJN OFCFHOOOGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6FA50D0", Offset = "0x6FA44D0", VA = "0x186FA50D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6FA56E0", Offset = "0x6FA4AE0", VA = "0x186FA56E0")]
	public NNDFCMOOFMO(IEnumerable<OPHEKAOFDCM> JEABOAEDEFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5130", Offset = "0x6FA4530", VA = "0x186FA5130")]
	private List<OMADGHGGHJN> BNHDNNNPJHF(IEnumerable<OPHEKAOFDCM> JEABOAEDEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5620", Offset = "0x6FA4A20", VA = "0x186FA5620", Slot = "4")]
	public IEnumerator<OMADGHGGHJN> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6FA5620", Offset = "0x6FA4A20", VA = "0x186FA5620", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CBCPDCNEBEL
{
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
	public CBCPDCNEBEL()
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
