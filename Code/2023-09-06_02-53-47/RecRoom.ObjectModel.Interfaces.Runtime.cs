using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Google.Protobuf;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface GNONIHFGJDG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task OLPFBHPNGJJ();

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OPLEHKIKGLH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface EMLPEGCKBCF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEGDNOKIPAB(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, Allocator HINEEPDGLPG, out NativeArray<Entity> NCEOACJJMCN);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct CNCNDJOAIPP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray POKDAMLGAFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<EEKJFDFIEGN, int> HIBPPKGHFHC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x57D8E80", Offset = "0x57D7480", VA = "0x1857D8E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xB911A0", Offset = "0xB8F7A0", VA = "0x180B911A0")]
	public CNCNDJOAIPP(NativeBitArray POKDAMLGAFJ, NativeParallelHashMap<EEKJFDFIEGN, int> HIBPPKGHFHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x57D8EA0", Offset = "0x57D74A0", VA = "0x1857D8EA0")]
	public bool HDPEOPFIDBA(EEKJFDFIEGN HGGMFNJGHIP, BENLOGNDJHK JCPKNOEICEG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface JBOGDOHNMAC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid PNLNEDJDIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task JLNJFELMAII(Guid MMCAAGOKCAD, Guid DCFIPPFIDDL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task LNKIGGNCEEM(ENMPPPDAMHN CPCGIKBHAHC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MPGNENNLLLA(ENMPPPDAMHN BIKOOLOFJJA, ENMPPPDAMHN HDBBNLFBJKG, out Vector3 OKNCDCLPPNJ, out Quaternion ANIGKMMOJOB);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEPKODICHCF(HNCGOEFKEPC JDLNGAJKBEB, Vector3 OKNCDCLPPNJ, Quaternion ANIGKMMOJOB);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface GCPINDOJNBO : ELEHKEJLDOI<ENMPPPDAMHN>, DPMGHPGKEOP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface GBHPCKEHPBF<T> : CGAFBLACJDG<ENMPPPDAMHN, T>, ELEHKEJLDOI<ENMPPPDAMHN>, DPMGHPGKEOP, IDisposable, GCPINDOJNBO where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BGDOGGALKHM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x19F6FC0", Offset = "0x19F55C0", VA = "0x1819F6FC0")]
	public static T MBNHJLNEIKL<T>(this ELEHKEJLDOI<ENMPPPDAMHN> JCPKNOEICEG, ENMPPPDAMHN HMLJKOHAJKN) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19F6F90", Offset = "0x19F5590", VA = "0x1819F6F90")]
	public static bool FGMAFKALEHD<T>(this ELEHKEJLDOI<ENMPPPDAMHN> JCPKNOEICEG, ENMPPPDAMHN HMLJKOHAJKN, in T KIFJIAOCCHE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface APFNGMLMBFH
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<MEEEHHLENLE> GODGJIKJLHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<ENMPPPDAMHN, ENMPPPDAMHN> JALKHICLAML;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<ENMPPPDAMHN, ENMPPPDAMHN> OMLJAFHPFKE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<ENMPPPDAMHN, ENMPPPDAMHN, ENMPPPDAMHN> FJPLHHELKCC;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<ENMPPPDAMHN> IAPIMCOJMGO;

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color NBJCJNGHDFO(ENMPPPDAMHN HMLJKOHAJKN, int OGHLIAOOOPG);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 IFJOHHLPIIC(ENMPPPDAMHN HMLJKOHAJKN, int OGHLIAOOOPG);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HCIIEFAKLFE(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN GNJOACJHOLJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	ENMPPPDAMHN PNFNAPBHDCP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<ENMPPPDAMHN> FDACOJKALHO(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	ENMPPPDAMHN KFPLAMJDOEC(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void NGCDIJDKJAH(ENMPPPDAMHN HMLJKOHAJKN, Vector3 PGFKMDCFOBF, Quaternion KPNEHIKPEEE);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ABFFEHIFAED(ENMPPPDAMHN HMLJKOHAJKN, float LONBLMKEDEF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool AEACPHECJKA(ENMPPPDAMHN HMLJKOHAJKN, out RigidTransform NHFMBKHAIMN);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool KIIDBKLGBDA(ENMPPPDAMHN HMLJKOHAJKN, out float AGGABCDPKLN);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 LAIJAGNGHNN(HLHJGCIDGNC MKCLCDAOEBD);

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion MFDIJCMEGFK(HLHJGCIDGNC MKCLCDAOEBD);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class CPBILPMCBDB
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface KGBMKPKFLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BKDEGJNJMON(Action ILLCNPCAHGD, bool IPICFJHNEKC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HEMBJEBDHJH(string ECMAPGHKHFB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface ANBDFDAFPGK
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FEGDNOKIPAB(in NativeArray<Entity> NCEOACJJMCN, in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, in NativeArray<JNJODLALMOB> CACKIHOHHNP);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface OBPAHFKOKAC
{
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MNFAMGHJOLE(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOOMILABPFA(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMNDJOBKOJM(ENMPPPDAMHN GIAMACBDIFH, int MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[DefaultMember("Item")]
public interface MKPEFGNMDIP : IEnumerable<EPFAAOCCGEJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray LLAMNGFIEHA
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> IHCHDMOGKEP
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	EPFAAOCCGEJ ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	EPFAAOCCGEJ ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EPFAAOCCGEJ EGCDMNKOBNB(CNGBAJDBKGM EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BENLOGNDJHK INBAPLHOGPD(CNGBAJDBKGM EFINPLKEDMK);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class IIAJBJIDINA
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface FFIEDGLJPJJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int OBMHHAMCFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int BAPCHLBGCPG(GameObject FLCGKEKAMCK);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool JEFNJAGJMBI(out Vector3 POOFJFBIOJJ);

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task JDOJOAEDJKN();

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task FOGFEPAAOAK();

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task ENHLJCPFJOB();

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHPCOJLGEHK();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct NBENPJJHFKN : IEquatable<NBENPJJHFKN>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly NBENPJJHFKN KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x57E0690", Offset = "0x57DEC90", VA = "0x1857E0690", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(NBENPJJHFKN FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct OJFPFFCIDAA : IEquatable<OJFPFFCIDAA>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly OJFPFFCIDAA KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x57E1D10", Offset = "0x57E0310", VA = "0x1857E1D10", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(OJFPFFCIDAA FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface FNLKBDOKFGP
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	CNCNDJOAIPP OLEBNJGPACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HDPEOPFIDBA(EEKJFDFIEGN HGGMFNJGHIP, BENLOGNDJHK JCPKNOEICEG);

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IACGPIOJBGK(EEKJFDFIEGN HGGMFNJGHIP, Span<BENLOGNDJHK> EGDOOPNCMJB, bool COPKPKNCEGL);

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JIDDGOBCGGJ(NativeArray<EEKJFDFIEGN> LDNMHAEAEME);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IJCDIMHMINI
{
	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x57DE4F0", Offset = "0x57DCAF0", VA = "0x1857DE4F0")]
	public static void IACGPIOJBGK(this FNLKBDOKFGP PGINAOKHABJ, EEKJFDFIEGN HGGMFNJGHIP, BENLOGNDJHK JCPKNOEICEG, bool COPKPKNCEGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct NILFLMGAFIC : EOACBFHBFAO, IEquatable<NILFLMGAFIC>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly NILFLMGAFIC KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GameObject FLCGKEKAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x57E0770", Offset = "0x57DED70", VA = "0x1857E0770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public EEKJFDFIEGN BAEHICLEACE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x57E0A30", Offset = "0x57DF030", VA = "0x1857E0A30")]
		get
		{
			return default(EEKJFDFIEGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DLBKPAILIEM ACIABBOHHMM
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x57E0950", Offset = "0x57DEF50", VA = "0x1857E0950")]
		get
		{
			return default(DLBKPAILIEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public BLIAAMDKPNO OADGFPKHNDF
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x57E0DD0", Offset = "0x57DF3D0", VA = "0x1857E0DD0")]
		get
		{
			return default(BLIAAMDKPNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool JKJFKJDLNHH
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x57E12B0", Offset = "0x57DF8B0", VA = "0x1857E12B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AOCDKBHHELC
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x57E0B10", Offset = "0x57DF110", VA = "0x1857E0B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BEHAGHLLDDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x57E0C70", Offset = "0x57DF270", VA = "0x1857E0C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool AIBCICMOGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x57E10F0", Offset = "0x57DF6F0", VA = "0x1857E10F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool MMCFKNJEDOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x57E12D0", Offset = "0x57DF8D0", VA = "0x1857E12D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool HCFNGCEOJPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x57E1070", Offset = "0x57DF670", VA = "0x1857E1070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool AOGKBBFINIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x57E0C50", Offset = "0x57DF250", VA = "0x1857E0C50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool DLNDENGJHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x57E1380", Offset = "0x57DF980", VA = "0x1857E1380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool DBKEGLIIJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x57E0F50", Offset = "0x57DF550", VA = "0x1857E0F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public GGOENMNPAJN LKKJNALFBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(GGOENMNPAJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FPGHODGFNJC ENPKDECBCNA
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(FPGHODGFNJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public DMNFAHCIFGP ANKIIHHGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(DMNFAHCIFGP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public KCCEPDPDBJD JPENMFFALKO
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(KCCEPDPDBJD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BNGBDALBBDH ICDANIPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BNGBDALBBDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ODNNBFFBCFD ANODGPHAAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ODNNBFFBCFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public HNCGOEFKEPC OPBJBGDHJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(HNCGOEFKEPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool IDOBKJNCGOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x57E11A0", Offset = "0x57DF7A0", VA = "0x1857E11A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool EPNODNIJBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x57E0D80", Offset = "0x57DF380", VA = "0x1857E0D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool FKCAFOLGLEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7EB370", Offset = "0x7E9970", VA = "0x1807EB370", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430", Slot = "5")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public BDEOFCIIHMD GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BDEOFCIIHMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public BPHAEEKICAL FBPKJDCDANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BPHAEEKICAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public static NILFLMGAFIC LBBGOAOJJNO(ENMPPPDAMHN GIAMACBDIFH)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x57E12F0", Offset = "0x57DF8F0", VA = "0x1857E12F0")]
	public AMCLHOADFGH ODBGIILEBJC()
	{
		return default(AMCLHOADFGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x57E0B30", Offset = "0x57DF130", VA = "0x1857E0B30")]
	public GFLBKNEKJLG CFGENNMDJFP()
	{
		return default(GFLBKNEKJLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x57E1090", Offset = "0x57DF690", VA = "0x1857E1090")]
	public MDDKOOMFIGL ICBFBAKDFPC()
	{
		return default(MDDKOOMFIGL);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x57E1110", Offset = "0x57DF710", VA = "0x1857E1110")]
	public HLHJGCIDGNC JLNEOHKBPOJ()
	{
		return default(HLHJGCIDGNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x57E0C90", Offset = "0x57DF290", VA = "0x1857E0C90")]
	public void DDIJEPCNDPH([Optional] object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x57E0B90", Offset = "0x57DF190", VA = "0x1857E0B90")]
	public bool CKFCPFNJLCG(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x57E13D0", Offset = "0x57DF9D0", VA = "0x1857E13D0")]
	public bool PHKIGIFCEFF(object DCEGGIJLHGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x57E1490", Offset = "0x57DFA90", VA = "0x1857E1490", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public NILFLMGAFIC(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(NILFLMGAFIC MOLEJFDINLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public static ENMPPPDAMHN LBBGOAOJJNO(NILFLMGAFIC MOLEJFDINLH)
	{
		return default(ENMPPPDAMHN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x57E0890", Offset = "0x57DEE90", VA = "0x1857E0890")]
	public static bool BDIEMMGDBNG(NILFLMGAFIC GNJGFBLEGKK, NILFLMGAFIC HEPECHBEGLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x57E0F70", Offset = "0x57DF570", VA = "0x1857E0F70")]
	public static bool HGHCMFFFPIK(NILFLMGAFIC GNJGFBLEGKK, NILFLMGAFIC HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x57E0EB0", Offset = "0x57DF4B0", VA = "0x1857E0EB0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "6")]
	public bool Equals(NILFLMGAFIC FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void NJFNDPOIPIK(HPCDDCJODHI GOIFCFOGGNG);
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct CPOIMPMNBDB : IList<ENMPPPDAMHN>, ICollection<ENMPPPDAMHN>, IEnumerable<ENMPPPDAMHN>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct ABMBBLIMHJE : IEnumerator<ENMPPPDAMHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly JBBANOPACMB OKJDHECIFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator GCEOFBACMDB;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public ENMPPPDAMHN PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x600008E")]
			[Cpp2IlInjected.Address(RVA = "0x57D21E0", Offset = "0x57D07E0", VA = "0x1857D21E0", Slot = "4")]
			get
			{
				return default(ENMPPPDAMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x57D2130", Offset = "0x57D0730", VA = "0x1857D2130", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x1D42A60", Offset = "0x1D41060", VA = "0x181D42A60")]
		public ABMBBLIMHJE(JBBANOPACMB OKJDHECIFKP, NativeArray<LocalId>.Enumerator GCEOFBACMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x57D2070", Offset = "0x57D0670", VA = "0x1857D2070", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x57D20B0", Offset = "0x57D06B0", VA = "0x1857D20B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x57D20F0", Offset = "0x57D06F0", VA = "0x1857D20F0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> LNIELCFLEJE;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public ENMPPPDAMHN ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x57D98A0", Offset = "0x57D7EA0", VA = "0x1857D98A0", Slot = "4")]
		get
		{
			return default(ENMPPPDAMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x57D9920", Offset = "0x57D7F20", VA = "0x1857D9920", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x57D9000", Offset = "0x57D7600", VA = "0x1857D9000", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x57D9000", Offset = "0x57D7600", VA = "0x1857D9000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool MIKIMACELCH
	{
		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x7F4850", Offset = "0x7F2E50", VA = "0x1807F4850", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x57D9810", Offset = "0x57D7E10", VA = "0x1857D9810")]
	public CPOIMPMNBDB(JBBANOPACMB OKJDHECIFKP, int BFDDLCIBNMB, Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57D94D0", Offset = "0x57D7AD0", VA = "0x1857D94D0")]
	public KIHFNANBKDD MGLLPPOOBBM()
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x57D9040", Offset = "0x57D7640", VA = "0x1857D9040", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x57D9080", Offset = "0x57D7680", VA = "0x1857D9080", Slot = "13")]
	public bool Contains(ENMPPPDAMHN MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x57D90E0", Offset = "0x57D76E0", VA = "0x1857D90E0", Slot = "14")]
	public void CopyTo(ENMPPPDAMHN[] IACDCADJJAN, int AJIOAJHCAKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x57D8FA0", Offset = "0x57D75A0", VA = "0x1857D8FA0", Slot = "11")]
	public void Add(ENMPPPDAMHN MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x57D9450", Offset = "0x57D7A50", VA = "0x1857D9450", Slot = "7")]
	public void Insert(int OLGOBCPPPBB, ENMPPPDAMHN MDCAOIKFJBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x57D95A0", Offset = "0x57D7BA0", VA = "0x1857D95A0", Slot = "15")]
	public bool Remove(ENMPPPDAMHN MDCAOIKFJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x57D93F0", Offset = "0x57D79F0", VA = "0x1857D93F0", Slot = "6")]
	public int IndexOf(ENMPPPDAMHN MDCAOIKFJBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x57D9550", Offset = "0x57D7B50", VA = "0x1857D9550", Slot = "8")]
	public void RemoveAt(int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57D9320", Offset = "0x57D7920", VA = "0x1857D9320", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x57D9360", Offset = "0x57D7960", VA = "0x1857D9360")]
	public ABMBBLIMHJE FGHGHABHEPH()
	{
		return default(ABMBBLIMHJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x57D9630", Offset = "0x57D7C30", VA = "0x1857D9630", Slot = "16")]
	private IEnumerator<ENMPPPDAMHN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x57D9720", Offset = "0x57D7D20", VA = "0x1857D9720", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface IFJOCADHACG
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool NOOJJKLFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface DHAENDLPHJA
{
	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	DNDLMEKGEFK OFLPDONHOMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	KKPOOHOLFOI LAJFHFFMFJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEFGOPMIFOH(Transform DMECJMCKFAG);

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MKIKHNEBPDL(Transform DMECJMCKFAG, LBNANCMGMEH AGMHMLGCCID);

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBALIHONKPN(Transform DMECJMCKFAG, FFJIFBOEBED FNMLENPPFFG);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface GHPFOIJGFBB
{
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEGDNOKIPAB(in float3 AAPGOMMDCAJ, in float3 MAMJCPDDLBH, float JOJFLKALKOE, out JNJODLALMOB AAIJPFEJJAO, out ENMPPPDAMHN JCPFBEJJJPM);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct CJNJIJCNICA : IEquatable<CJNJIJCNICA>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly CJNJIJCNICA KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private HEONMBBDPJM PIBMOGJMBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x57D89C0", Offset = "0x57D6FC0", VA = "0x1857D89C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public GFLBKNEKJLG KOMOOOAPCOC
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(GFLBKNEKJLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LCDOAODHHAO BBOADOEEIHF
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x57D8640", Offset = "0x57D6C40", VA = "0x1857D8640")]
		get
		{
			return default(LCDOAODHHAO);
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x57D7EC0", Offset = "0x57D64C0", VA = "0x1857D7EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public IEnumerable<EIBPHEFAAAK> JHDOCKCOBPO
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x57D7FD0", Offset = "0x57D65D0", VA = "0x1857D7FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public EIBPHEFAAAK ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x57D8750", Offset = "0x57D6D50", VA = "0x1857D8750")]
		get
		{
			return default(EIBPHEFAAAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x57D83E0", Offset = "0x57D69E0", VA = "0x1857D83E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public BDEOFCIIHMD GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BDEOFCIIHMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x57D8870", Offset = "0x57D6E70", VA = "0x1857D8870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x57D8A50", Offset = "0x57D7050", VA = "0x1857D8A50")]
	public EIBPHEFAAAK KJPKKGJAHHG(float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] Vector3? CHAPNJAEPMG)
	{
		return default(EIBPHEFAAAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x57D81B0", Offset = "0x57D67B0", VA = "0x1857D81B0")]
	public EIBPHEFAAAK EOEKDCMIPPI(int OLGOBCPPPBB, float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] Vector3? CHAPNJAEPMG)
	{
		return default(EIBPHEFAAAK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x57D88D0", Offset = "0x57D6ED0", VA = "0x1857D88D0")]
	public void HFOGEGPFAHB(int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x57D8560", Offset = "0x57D6B60", VA = "0x1857D8560")]
	public void FBJOPIHCMHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public CJNJIJCNICA(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(CJNJIJCNICA MOLEJFDINLH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x57D7E00", Offset = "0x57D6400", VA = "0x1857D7E00")]
	public static bool BDIEMMGDBNG(CJNJIJCNICA GNJGFBLEGKK, CJNJIJCNICA HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x57D84C0", Offset = "0x57D6AC0", VA = "0x1857D84C0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(CJNJIJCNICA FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface PPKCEEEDIDM
{
	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	Type MGFIHJNKIIG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface MGCDDMFMGJA
{
	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool AAHFEBKDDMN(ENMPPPDAMHN HMLJKOHAJKN, out Collider HCHCJABNKJO);

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject HPPKJCCGKMI(ENMPPPDAMHN MGLIKPMKEFE, GameObject LMLNLGDAFGM, Vector3 IPKLBGKEJKA, Quaternion EOGEEAFFCFC);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JKFMGDBJMBP(GameObject HCHCJABNKJO);

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider IKBLOAHDMFN<TCollider>(GameObject OLCMLKKFBEP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KCEJLACONPF(Collider HCHCJABNKJO);

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject JOMPJOOIBMD<TCollider>(string ECMAPGHKHFB) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface AAOPIAOGDMN : ELEHKEJLDOI<EEKJFDFIEGN>, DPMGHPGKEOP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JDBPLBJBOMG<T> : CGAFBLACJDG<EEKJFDFIEGN, T>, ELEHKEJLDOI<EEKJFDFIEGN>, DPMGHPGKEOP, IDisposable, AAOPIAOGDMN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GEJFMJPGFND
{
	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1A13A00", Offset = "0x1A12000", VA = "0x181A13A00")]
	public static bool BBDOIOJLDPI<T>(this ELEHKEJLDOI<EEKJFDFIEGN> JCPKNOEICEG, EEKJFDFIEGN HGGMFNJGHIP, out T MOLEJFDINLH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x1A13A10", Offset = "0x1A12010", VA = "0x181A13A10")]
	public static bool FGMAFKALEHD<T>(this ELEHKEJLDOI<EEKJFDFIEGN> JCPKNOEICEG, EEKJFDFIEGN HGGMFNJGHIP, in T KIFJIAOCCHE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface GOMJAHLAFPG
{
	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JCEGPNMABBP();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct HNCGOEFKEPC : IEquatable<HNCGOEFKEPC>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly HNCGOEFKEPC KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	private OCAAAEBGOCB DNAIABEEPBM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x57DE230", Offset = "0x57DC830", VA = "0x1857DE230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool IMHJKLCKNFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x57DDA70", Offset = "0x57DC070", VA = "0x1857DDA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public Guid AOLFPPELGFC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x57DE130", Offset = "0x57DC730", VA = "0x1857DE130")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public bool COEEJLLJBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x57DE2C0", Offset = "0x57DC8C0", VA = "0x1857DE2C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Guid IBMJAOCIOEE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x57DD970", Offset = "0x57DBF70", VA = "0x1857DD970")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x57DDDF0", Offset = "0x57DC3F0", VA = "0x1857DDDF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x57DDCF0", Offset = "0x57DC2F0", VA = "0x1857DDCF0")]
	public bool FGMCBHHMPLH(out Guid DJLOBGOMBEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x57DDB50", Offset = "0x57DC150", VA = "0x1857DDB50")]
	public void EEGEHIONIOF(Guid PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x57DDE50", Offset = "0x57DC450", VA = "0x1857DDE50")]
	public bool HKLCIMHPABK(out Guid NEDBLEJEGBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x57DDF50", Offset = "0x57DC550", VA = "0x1857DDF50")]
	public void HNKIGPOGDOM(Guid PMMAPONKBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x57DE050", Offset = "0x57DC650", VA = "0x1857DE050")]
	public void KGNBNLGADEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public HNCGOEFKEPC(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(HNCGOEFKEPC MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x57DDC50", Offset = "0x57DC250", VA = "0x1857DDC50", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(HNCGOEFKEPC FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct FPGHODGFNJC : IEquatable<FPGHODGFNJC>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly FPGHODGFNJC KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x57DC330", Offset = "0x57DA930", VA = "0x1857DC330")]
	public void AFFJDJOCMDN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x57DC410", Offset = "0x57DAA10", VA = "0x1857DC410")]
	public void ENNCOPBPMIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public FPGHODGFNJC(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x57DC4F0", Offset = "0x57DAAF0", VA = "0x1857DC4F0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(FPGHODGFNJC FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FCLHKJAHMCN : EOACBFHBFAO
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	CBGIFDDBMPC JGKJEDKNFHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	bool HNHJKJJOBEG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	GameObject FLCGKEKAMCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<FCLHKJAHMCN> FIFJLAIOLNI;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(MOFMKHOGCPA DDODGIBMPPP, ENMPPPDAMHN MIGKAMMIMKO);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool ICKNPJNMEJH);

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class KMODNOHHBKD
{
	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x57DFC70", Offset = "0x57DE270", VA = "0x1857DFC70")]
	public static bool IDOBKJNCGOE(this FCLHKJAHMCN CBIMOLNMMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x57DFB80", Offset = "0x57DE180", VA = "0x1857DFB80")]
	public static bool GDLDJIEGCDD(this FCLHKJAHMCN CBIMOLNMMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x57DFCC0", Offset = "0x57DE2C0", VA = "0x1857DFCC0")]
	public static bool NPHNCALIPCJ(this FCLHKJAHMCN CBIMOLNMMAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x57DFBD0", Offset = "0x57DE1D0", VA = "0x1857DFBD0")]
	public static bool HJJCFGPENBE(this FCLHKJAHMCN CBIMOLNMMAP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface MCHBLFAONEL
{
	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CFHNKHADPNO(GameObject FLCGKEKAMCK);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct EPGDKBELAGA : IEquatable<EPGDKBELAGA>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly EPGDKBELAGA KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x57DBA40", Offset = "0x57DA040", VA = "0x1857DBA40", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(EPGDKBELAGA FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface BPFOPFGDLFP
{
	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AHFKEHNENKC(NativeListAsync<Entity> KDLCPOFNJJJ);

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HMFMIAPNFGA(MOPLMCMCOIP NDCEMCGOMIA);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IBKCNNIJCHD(NativeListAsync<Entity> DNBNJHFCCJF, bool HHGCMHKNDIH);

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GGPHJNLENHN();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface OHIFFKHKBLN
{
	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KOEGIEBEPFH(ENMPPPDAMHN HMLJKOHAJKN, CIACNBAJNFM MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface GDPCNPLLJEI
{
	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHGPEIDMJCG();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LHNHKGEGIPA();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ECOENIEIAPP();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FLGNBPKPHID();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IIJLMLEFHKC();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PGFLNLPFLIK();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OCCCPIBAAPG();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HILAIJLKACG();

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IDBHAABNBOO();

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CLMNAHDIDKG();

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HOAMAEIIDDE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct PHGPCEHAGAA : IEquatable<PHGPCEHAGAA>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal const int CDOPBDKANGA = 1;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal const int AHIGOBIMLHP = 4;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal const int IJMDJIBBEFK = 8;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal const int FLBACAGLDML = 24;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal const uint KIMHICBBPGL = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal const uint CGPABJFAGCG = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly uint FCDGNCOICKN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static uint[] ELGFKJEBGOH;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static JBBANOPACMB[] CBMJEICKDDL;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static uint LMLFPMDNJKJ;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public JBBANOPACMB KMEOEFHJJKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x57E2DB0", Offset = "0x57E13B0", VA = "0x1857E2DB0")]
	static PHGPCEHAGAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
	internal PHGPCEHAGAA(uint MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA010", Offset = "0x3BD8610", VA = "0x183BDA010", Slot = "4")]
	public bool Equals(PHGPCEHAGAA FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x57E2550", Offset = "0x57E0B50", VA = "0x1857E2550", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x57E2CB0", Offset = "0x57E12B0", VA = "0x1857E2CB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x57E25F0", Offset = "0x57E0BF0", VA = "0x1857E25F0")]
	private JBBANOPACMB FIFLJJOBDPH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x57E27B0", Offset = "0x57E0DB0", VA = "0x1857E27B0")]
	private static uint GDKCFJKPHMK(uint FCDGNCOICKN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x57E27C0", Offset = "0x57E0DC0", VA = "0x1857E27C0")]
	private static (uint, uint) KBJEKKGELPB(uint FCDGNCOICKN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x57E25E0", Offset = "0x57E0BE0", VA = "0x1857E25E0")]
	private static uint FDPJLOJOEOF(uint MPNDOHBKHJO, uint OLGOBCPPPBB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x57E2820", Offset = "0x57E0E20", VA = "0x1857E2820")]
	internal static PHGPCEHAGAA MBACIJOLGCB(JBBANOPACMB GEDHMEAEIPA)
	{
		return default(PHGPCEHAGAA);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x57E23A0", Offset = "0x57E09A0", VA = "0x1857E23A0")]
	internal static void BDNBMIGFIII(PHGPCEHAGAA FCDGNCOICKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x57E2A20", Offset = "0x57E1020", VA = "0x1857E2A20")]
	private static void NLAAMBMIJPJ(int LEFNHMBHKEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface HCJLJOEKAAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	int JFKOKAMDKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> JMBLCPDABCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENMPPPDAMHN IBMOACNLPCB(ENMPPPDAMHN LNIELCFLEJE);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface DHJABKEDGIM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct KCCEPDPDBJD : IEquatable<KCCEPDPDBJD>
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly KCCEPDPDBJD KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	private LHFNKEIMGOC LHBCLBLKBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x57DE950", Offset = "0x57DCF50", VA = "0x1857DE950")]
		get
		{
			return default(LHFNKEIMGOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool HJNOEECLMGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x57DEEA0", Offset = "0x57DD4A0", VA = "0x1857DEEA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool BDHOJGHLMJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x57DE940", Offset = "0x57DCF40", VA = "0x1857DE940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool OKEIMABBCOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x57DF1D0", Offset = "0x57DD7D0", VA = "0x1857DF1D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool BFIPKOICIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x57DE890", Offset = "0x57DCE90", VA = "0x1857DE890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool KAEKPEHMGJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x57DEFD0", Offset = "0x57DD5D0", VA = "0x1857DEFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool OGDMLJEDHAD
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x57DE9D0", Offset = "0x57DCFD0", VA = "0x1857DE9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool CCENDLMMDAM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x57DF1C0", Offset = "0x57DD7C0", VA = "0x1857DF1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool ILDHKGMHKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x57DF210", Offset = "0x57DD810", VA = "0x1857DF210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool APPAMNNKCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x57DF200", Offset = "0x57DD800", VA = "0x1857DF200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool FCNOKEDELND
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x57DE9C0", Offset = "0x57DCFC0", VA = "0x1857DE9C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool LGLCFLKNOKA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x57DE920", Offset = "0x57DCF20", VA = "0x1857DE920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool LKHAOHHNDDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x57DF1E0", Offset = "0x57DD7E0", VA = "0x1857DF1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool AENIGNLMNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x57DE930", Offset = "0x57DCF30", VA = "0x1857DE930")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool CFGOGIMCFIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x57DF1F0", Offset = "0x57DD7F0", VA = "0x1857DF1F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool FOEHLBAKNMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x57DEFC0", Offset = "0x57DD5C0", VA = "0x1857DEFC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x57DF050", Offset = "0x57DD650", VA = "0x1857DF050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool KJFGELBIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x57DEB10", Offset = "0x57DD110", VA = "0x1857DEB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public IMFMNLGPJGN CNODEONMKKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x57DEFE0", Offset = "0x57DD5E0", VA = "0x1857DEFE0")]
		get
		{
			return default(IMFMNLGPJGN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool GNFMFBPPKKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x57DE8A0", Offset = "0x57DCEA0", VA = "0x1857DE8A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public Vector3 KJCIIMMAAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x57DECD0", Offset = "0x57DD2D0", VA = "0x1857DECD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public Vector3 GAJPNLLKKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x57DEF00", Offset = "0x57DD500", VA = "0x1857DEF00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool HIKOEMAPECN
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x57DE9E0", Offset = "0x57DCFE0", VA = "0x1857DE9E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x57DEDB0", Offset = "0x57DD3B0", VA = "0x1857DEDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x57DF140", Offset = "0x57DD740", VA = "0x1857DF140")]
	public bool MFHGNOAOJEF(JNPNKFKPBJG PDLGJEIPEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x57DF060", Offset = "0x57DD660", VA = "0x1857DF060")]
	public bool MAPHPPBBGPC(FPKNHKANDMB PDLGJEIPEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x57DEE10", Offset = "0x57DD410", VA = "0x1857DEE10")]
	public void GOPNLACNADG(FPKNHKANDMB PDLGJEIPEDC, bool GKJOEINIIAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public KCCEPDPDBJD(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x57DEC30", Offset = "0x57DD230", VA = "0x1857DEC30", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(KCCEPDPDBJD FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum ODHLOBENJON
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class LDCJBDDMAAP
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x994050", Offset = "0x992650", VA = "0x180994050")]
	public static bool PCNLNEBAEIB(this ODHLOBENJON ILFDGGGKIBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x993EE0", Offset = "0x9924E0", VA = "0x180993EE0")]
	public static bool BJKMNKAECAB(this ODHLOBENJON ILFDGGGKIBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x41E1B80", Offset = "0x41E0180", VA = "0x1841E1B80")]
	public static bool KEBHNFMOODG(this ODHLOBENJON ILFDGGGKIBE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface MOFMKHOGCPA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	World FKLPOCBLLPM
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	World DFLOMKCOJKF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	EntityManager AKIAGLBKAEL
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase AMDBIEEGCPG(Type KLGGKKGCLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class LDMMLHMMJKL
{
	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x57DFDD0", Offset = "0x57DE3D0", VA = "0x1857DFDD0")]
	public static ComponentSystemBase LBLFMKEEKCG(this World DDODGIBMPPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0xF43670", Offset = "0xF41C70", VA = "0x180F43670")]
	public static T AMDBIEEGCPG<T>(this MOFMKHOGCPA AINGPNAHLGJ) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct AMICGDPKLIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HPCDDCJODHI JAIGDBINGHO;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KIHFNANBKDD BPFFFONHENF
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x1D43460", Offset = "0x1D41A60", VA = "0x181D43460")]
		get
		{
			return default(KIHFNANBKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x57D3520", Offset = "0x57D1B20", VA = "0x1857D3520")]
	public AMICGDPKLIC(HPCDDCJODHI JAIGDBINGHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x57D3450", Offset = "0x57D1A50", VA = "0x1857D3450")]
	public KIHFNANBKDD NFPAFCEBFJH()
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x57D31F0", Offset = "0x57D17F0", VA = "0x1857D31F0")]
	public KIHFNANBKDD FJAMJKIIFFM()
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x57D32C0", Offset = "0x57D18C0", VA = "0x1857D32C0")]
	public (KIHFNANBKDD, KIHFNANBKDD, KIHFNANBKDD) MBNHJLNEIKL()
	{
		return default((KIHFNANBKDD, KIHFNANBKDD, KIHFNANBKDD));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct BPHAEEKICAL : IEquatable<BPHAEEKICAL>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly BPHAEEKICAL KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private DEMCMMGHLIH AGKIODBLNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x57D7500", Offset = "0x57D5B00", VA = "0x1857D7500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public ENMPPPDAMHN OAAGPJEEBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x57D76A0", Offset = "0x57D5CA0", VA = "0x1857D76A0")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public NILFLMGAFIC ALENDOCOGOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x57D7590", Offset = "0x57D5B90", VA = "0x1857D7590")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public NILFLMGAFIC HDEBMDKMAOL
	{
		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x57D72D0", Offset = "0x57D58D0", VA = "0x1857D72D0")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x57D7270", Offset = "0x57D5870", VA = "0x1857D7270")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x57D73E0", Offset = "0x57D59E0", VA = "0x1857D73E0")]
	public bool JAMGDJKMPGM(NILFLMGAFIC HDBBNLFBJKG, bool HNOGDNKLDPO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x57D7160", Offset = "0x57D5760", VA = "0x1857D7160")]
	public bool GGFOGAAPHID(NILFLMGAFIC IOKDMANFCEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public BPHAEEKICAL(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x57D70C0", Offset = "0x57D56C0", VA = "0x1857D70C0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(BPHAEEKICAL FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface FGGEKFFPMLE
{
	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOEHNOEGNBA(string DPAJDIEBNKM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct BGEIMNEBEIP : IEquatable<BGEIMNEBEIP>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly BGEIMNEBEIP KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private JNLJPMMFDGG OJHKNHDKAKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x57D61A0", Offset = "0x57D47A0", VA = "0x1857D61A0")]
		get
		{
			return default(JNLJPMMFDGG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public MGJBCBDODFM FOFMOJEAJMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x57D62B0", Offset = "0x57D48B0", VA = "0x1857D62B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public BGEIMNEBEIP(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x57D6210", Offset = "0x57D4810", VA = "0x1857D6210", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(BGEIMNEBEIP FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface KGPKDCJJLAE
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	string BEMKOFAFNKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] HFPEOLFBANJ(IEnumerable<OPAIBEOPLMG> OGIMNFBMPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EEKJFDFIEGN DGOANLHKCDN(Guid DHCANNMLPCN);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KKPFFAMLKKC(GameObject FLCGKEKAMCK, out EEKJFDFIEGN HGGMFNJGHIP);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool MILJEOPKKGH(GameObject FLCGKEKAMCK, out int EJHHLMJKNMO, out BLIAAMDKPNO POJMFCODLHG);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FCLHKJAHMCN IBCFIEOBCJO(OPAIBEOPLMG FEBOEFLLEJB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FCLHKJAHMCN IBCFIEOBCJO(string ICNEJAGANPG, EEKJFDFIEGN HGGMFNJGHIP, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, Vector3 CHAPNJAEPMG);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NDAPGPHJNGL(GameObject IMKNAOEBBFN, bool OLELHLONAJO);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CAEBKHCHKLH(GameObject FLCGKEKAMCK, bool DKDNKPGKMNK, bool EAKOMNNBNBH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CJPLEMDKPDB
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x57D8CB0", Offset = "0x57D72B0", VA = "0x1857D8CB0")]
	public static FCLHKJAHMCN IBCFIEOBCJO(this KGPKDCJJLAE FOAHDAGNGDC, EEKJFDFIEGN HGGMFNJGHIP, Vector3 POOFJFBIOJJ, Quaternion MEHKCJCIOOL, Vector3 CHAPNJAEPMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface NHKIMKLFCEB
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	FFJIFBOEBED FIJHCACEJNI
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface AKLHOJFEEEF
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World FFIKLLCPMEH();

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World FALMOHOOEPF();

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World IKOMPELDNJF();

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World FADMPHNMKJL();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface LIACCBFBACG
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	FOGGGIMKHHH OLEPBAAECFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	KGPKDCJJLAE JJHCCKOJALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	IKMNPNDODOB AHBEEDIDIOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	MIJOAPHHMJE GCKMOHEBCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	MCHBLFAONEL EDFFDDENOGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	FGGEKFFPMLE EGGOONFNDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	FFIEDGLJPJJ GOMEAPDLLAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	IFJOCADHACG IBMMOIONNIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	GNONIHFGJDG OJNMJPHPDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface COBIPENOGBA
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct OMLPFNCGEAG : EPBCOPJMPPK, IEquatable<OMLPFNCGEAG>
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int FIFIFGFPIHM
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int CHHMHDKPLJD
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x1D43610", Offset = "0x1D41C10", VA = "0x181D43610", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x2A83C00", Offset = "0x2A82200", VA = "0x182A83C00", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x57E1E80", Offset = "0x57E0480", VA = "0x1857E1E80", Slot = "8")]
	public bool Equals(OMLPFNCGEAG FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x57E1ED0", Offset = "0x57E04D0", VA = "0x1857E1ED0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface EMNFNBCOPIC
{
	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBACIJOLGCB(CNGBAJDBKGM JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA);

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDNBMIGFIII(CNGBAJDBKGM JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct FNDBMHENIMP : HLLDBJJMAKE, IEquatable<FNDBMHENIMP>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public BLIAAMDKPNO POJMFCODLHG;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x57DC1E0", Offset = "0x57DA7E0", VA = "0x1857DC1E0", Slot = "5")]
	public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x57DC1B0", Offset = "0x57DA7B0", VA = "0x1857DC1B0", Slot = "4")]
	public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x57DC210", Offset = "0x57DA810", VA = "0x1857DC210", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA010", Offset = "0x3BD8610", VA = "0x183BDA010", Slot = "6")]
	public bool Equals(FNDBMHENIMP FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x57DC120", Offset = "0x57DA720", VA = "0x1857DC120", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface BJDDOFPNFNG
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool NOOJJKLFPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action PFEALLMEGFO;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AOJHDNCDBFH();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void AHOCCNCOJEO();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPMDNCBPCGA(bool LHEAMNILFLF);

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCDPDOGHPFL(ByteString NFNCBDOMNAL);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task JDOJOAEDJKN();

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task FOGFEPAAOAK();

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task ENHLJCPFJOB();

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBACKNBGODH();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface JAJEJKEGFGN
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	BMPAEHPFBCF MBMGKBCFEPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	List<GCPINDOJNBO> BPFADEADMOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OILCKJDFMPE(GCPINDOJNBO JCPKNOEICEG, out BMPAEHPFBCF KEJDPMGJDKJ);

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MBACIJOLGCB(GCPINDOJNBO JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA);

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BDNBMIGFIII(GCPINDOJNBO JCPKNOEICEG, NJFNDPOIPIK LELMIPHHCLA);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface HIBBFMKOKAC
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	LCNGNIAJKJH AMPIPDPLDOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct HLHJGCIDGNC : IEquatable<HLHJGCIDGNC>
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly HLHJGCIDGNC KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private APFNGMLMBFH KGADEKOOIKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x57DD600", Offset = "0x57DBC00", VA = "0x1857DD600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public float3 JHCELNFMIKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x57DD820", Offset = "0x57DBE20", VA = "0x1857DD820")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public quaternion OIPBKABCGLE
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x57DD460", Offset = "0x57DBA60", VA = "0x1857DD460")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NILFLMGAFIC DANEGLPCLOE
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x57DD6F0", Offset = "0x57DBCF0", VA = "0x1857DD6F0")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x57DD690", Offset = "0x57DBC90", VA = "0x1857DD690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public HLHJGCIDGNC(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public static ENMPPPDAMHN LBBGOAOJJNO(HLHJGCIDGNC MOLEJFDINLH)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x57DD560", Offset = "0x57DBB60", VA = "0x1857DD560", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(HLHJGCIDGNC FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface IFGBMAJAPAC
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action HBACKNBGODH;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action MBAENNOCCKJ;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action MEAPKHPPMLF;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface BMPAEHPFBCF
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string LDGOGEKFNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	BMPAEHPFBCF EMOIDKCIIFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	IEnumerable<BMPAEHPFBCF> MOAFIMFFFFA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DefaultMember("Item")]
public struct KIHFNANBKDD : IReadOnlyList<ENMPPPDAMHN>, IEnumerable<ENMPPPDAMHN>, IEnumerable, IReadOnlyCollection<ENMPPPDAMHN>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct PKMMBBLPNLA : IEnumerator<ENMPPPDAMHN>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly JBBANOPACMB OKJDHECIFKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeArray<LocalId>.Enumerator GCEOFBACMDB;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public ENMPPPDAMHN PLBILPKBCNO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0x57E2F30", Offset = "0x57E1530", VA = "0x1857E2F30", Slot = "4")]
			get
			{
				return default(ENMPPPDAMHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x57E2E80", Offset = "0x57E1480", VA = "0x1857E2E80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x1D42A60", Offset = "0x1D41060", VA = "0x181D42A60")]
		public PKMMBBLPNLA(JBBANOPACMB OKJDHECIFKP, NativeArray<LocalId>.Enumerator GCEOFBACMDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x57E2DC0", Offset = "0x57E13C0", VA = "0x1857E2DC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x57E2E00", Offset = "0x57E1400", VA = "0x1857E2E00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x57E2E40", Offset = "0x57E1440", VA = "0x1857E2E40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly JBBANOPACMB OKJDHECIFKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeArray<LocalId> LNIELCFLEJE;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public ENMPPPDAMHN ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x57DFA80", Offset = "0x57DE080", VA = "0x1857DFA80", Slot = "4")]
		get
		{
			return default(ENMPPPDAMHN);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x57DF560", Offset = "0x57DDB60", VA = "0x1857DF560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int AGEEIAAMAGH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x7EA000", Offset = "0x7E8600", VA = "0x1807EA000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int ALHMBJNHGMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x7EA1A0", Offset = "0x7E87A0", VA = "0x1807EA1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool ALFPHPKCOIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0x57DF610", Offset = "0x57DDC10", VA = "0x1857DF610")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public NativeArray<LocalId> IFILEOLJKHO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1D435C0", Offset = "0x1D41BC0", VA = "0x181D435C0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	internal NativeArray<Entity> OHCFFCCPKKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001BD")]
		[Cpp2IlInjected.Address(RVA = "0x57DF470", Offset = "0x57DDA70", VA = "0x1857DF470")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x57DF830", Offset = "0x57DDE30", VA = "0x1857DF830")]
	public KIHFNANBKDD(int LEFNHMBHKEC, JBBANOPACMB OKJDHECIFKP, Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x1D42410", Offset = "0x1D40A10", VA = "0x181D42410")]
	public KIHFNANBKDD(JBBANOPACMB OKJDHECIFKP, NativeArray<LocalId> LNIELCFLEJE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x57DF970", Offset = "0x57DDF70", VA = "0x1857DF970")]
	internal KIHFNANBKDD(JBBANOPACMB OKJDHECIFKP, NativeArray<Entity> NCEOACJJMCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x57DF9E0", Offset = "0x57DDFE0", VA = "0x1857DF9E0")]
	public KIHFNANBKDD(JBBANOPACMB OKJDHECIFKP, int BFDDLCIBNMB, Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x57DF8C0", Offset = "0x57DDEC0", VA = "0x1857DF8C0")]
	public KIHFNANBKDD(KIHFNANBKDD DBPOHGMMKAA, Allocator HINEEPDGLPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x57DF570", Offset = "0x57DDB70", VA = "0x1857DF570")]
	public KIHFNANBKDD MOAONFLIEIF(Allocator HINEEPDGLPG = Allocator.Temp)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x57DF430", Offset = "0x57DDA30", VA = "0x1857DF430", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x57DF4D0", Offset = "0x57DDAD0", VA = "0x1857DF4D0")]
	public PKMMBBLPNLA FGHGHABHEPH()
	{
		return default(PKMMBBLPNLA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x57DF650", Offset = "0x57DDC50", VA = "0x1857DF650", Slot = "6")]
	private IEnumerator<ENMPPPDAMHN> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x57DF740", Offset = "0x57DDD40", VA = "0x1857DF740", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct EEKJFDFIEGN : IComparable<EEKJFDFIEGN>, IEquatable<EEKJFDFIEGN>, HLLDBJJMAKE
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const uint KKCAILHJBAJ = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const uint KNCFDDIHOOP = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly EEKJFDFIEGN CJBAGCINGJC;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int FLBACAGLDML = 24;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private const uint KIMHICBBPGL = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private const int DIFICPLLGEK = 8;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const uint FMONIIJNMCF = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly uint DOOPBMHHDLE;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public uint EKBEMPFBLAF
	{
		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xE6D580", Offset = "0xE6BB80", VA = "0x180E6D580")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public uint INKIKMDHKDA
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x57DAA70", Offset = "0x57D9070", VA = "0x1857DAA70")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public uint IOEEBDIMNMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x9530D0", Offset = "0x9516D0", VA = "0x1809530D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool JJDFFNAFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0x52D78F0", Offset = "0x52D5EF0", VA = "0x1852D78F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x19EE800", Offset = "0x19ECE00", VA = "0x1819EE800")]
	public static EEKJFDFIEGN CPINHLNDEKH(uint DOOPBMHHDLE)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x57DAB50", Offset = "0x57D9150", VA = "0x1857DAB50")]
	public EEKJFDFIEGN(int OHACKIIBLPM, int GIPEPIBEJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x57DAB50", Offset = "0x57D9150", VA = "0x1857DAB50")]
	public EEKJFDFIEGN(uint OHACKIIBLPM, int GIPEPIBEJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x57DAB50", Offset = "0x57D9150", VA = "0x1857DAB50")]
	public EEKJFDFIEGN(uint OHACKIIBLPM, uint GIPEPIBEJOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
	private EEKJFDFIEGN(uint DOOPBMHHDLE)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x52D7980", Offset = "0x52D5F80", VA = "0x1852D7980")]
	public static bool BDIEMMGDBNG(EEKJFDFIEGN GNJGFBLEGKK, EEKJFDFIEGN HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x57DA880", Offset = "0x57D8E80", VA = "0x1857DA880", Slot = "5")]
	public bool Equals(EEKJFDFIEGN MJBJADACIFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x57DA8E0", Offset = "0x57D8EE0", VA = "0x1857DA8E0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x2634C60", Offset = "0x2633260", VA = "0x182634C60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x57DAA80", Offset = "0x57D9080", VA = "0x1857DAA80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x57DA9B0", Offset = "0x57D8FB0", VA = "0x1857DA9B0", Slot = "6")]
	public void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x57DAA10", Offset = "0x57D9010", VA = "0x1857DAA10", Slot = "7")]
	public void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x57DA870", Offset = "0x57D8E70", VA = "0x1857DA870", Slot = "4")]
	public int CompareTo(EEKJFDFIEGN FKJGPCABBJN)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface KKJOECNGBND
{
	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANAHIJBHGGK(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AEMJAJFBJEJ(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 ECIGICCJJFE(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BDAGEKPJKOA(Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion JOKMHACHIMP(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHGHBHCJHAO(Entity MPAGCMNFGMI, out float3 POOFJFBIOJJ, out quaternion MEHKCJCIOOL);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHGHBHCJHAO(Entity MPAGCMNFGMI, out RigidTransform HODCICPOGLO);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DKNFMLLPKMA(Entity MPAGCMNFGMI, out RigidTransform HODCICPOGLO);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 LPOOPMBABGF(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LNEBKPMEOIB(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KLEIDPCLBMA(Entity MPAGCMNFGMI, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float FGGMJPNJDEC(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GANOCGGJLOD(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 GFEPOBPFOMH(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PHDDEJKAPNO(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 ECBAFEIAPBC(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DCGBGKJKHLA(Entity MPAGCMNFGMI, in quaternion MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion JEEIFJCJBAI(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 ONEALIHAOMC(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void DOHKANKFLDI(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FBEJDKOBJAB(Entity MPAGCMNFGMI, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float EEBLBDOBPKP(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LBPPCPGFOCB(Entity MPAGCMNFGMI, in float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 KOBDNGABLMF(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LJIIGANLFDN(Entity MPAGCMNFGMI, out float4x4 CNKALCHPDKE);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void BMFCDBMEJMK(Entity MPAGCMNFGMI, in float4x4 CNKALCHPDKE);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DANGMACAEMN(Entity MPAGCMNFGMI, out float4x4 CNKALCHPDKE);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool AMJHHOCDEFA(Entity MPAGCMNFGMI, out Transform DMECJMCKFAG);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void JNKIHMPDDHF(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FFPMMBHCKDC(Entity MPAGCMNFGMI, Entity ELDCHLKBIGE, Entity EPBIFMJLJFE);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class JHDFMHFEKJI
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct FBGEKGCCCOL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IEnumerable<OPAIBEOPLMG> OGIMNFBMPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IReadOnlyList<GameObject> HCBLHIFKENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IReadOnlyList<int> JNLHGFKOMMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IReadOnlyList<(EEKJFDFIEGN, EEKJFDFIEGN)> DLCMOOLCOLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int MMFNPNCBFEG;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool JJDFFNAFLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x57DBFB0", Offset = "0x57DA5B0", VA = "0x1857DBFB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int ANBFJPAPOOE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x90DC40", Offset = "0x90C240", VA = "0x18090DC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IEnumerable<GameObject> KDGILDLMGBD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xACAB80", Offset = "0xAC9180", VA = "0x180ACAB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IEnumerable<(EEKJFDFIEGN src, EEKJFDFIEGN dst)> GPJABKNFBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x57DC010", Offset = "0x57DA610", VA = "0x1857DC010")]
	public FBGEKGCCCOL(IEnumerable<OPAIBEOPLMG> OGIMNFBMPBJ, IReadOnlyList<GameObject> HCBLHIFKENJ, IReadOnlyList<int> JNLHGFKOMMM, IReadOnlyList<(EEKJFDFIEGN src, EEKJFDFIEGN dst)> DLCMOOLCOLK, int MMFNPNCBFEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x57DBC00", Offset = "0x57DA200", VA = "0x1857DBC00")]
	public (GameObject, int)[] LLGPILJIONM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct AMCLHOADFGH : IEquatable<AMCLHOADFGH>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly AMCLHOADFGH KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private DEMCMMGHLIH AGKIODBLNFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x57D2DB0", Offset = "0x57D13B0", VA = "0x1857D2DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public KIHFNANBKDD MGNKNDDIMLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x57D25F0", Offset = "0x57D0BF0", VA = "0x1857D25F0")]
		get
		{
			return default(KIHFNANBKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IEnumerable<NILFLMGAFIC> NJANFDAOLBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x57D2C40", Offset = "0x57D1240", VA = "0x1857D2C40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IEnumerable<NILFLMGAFIC> DGHCBLMLKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x57D2320", Offset = "0x57D0920", VA = "0x1857D2320")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int HEFLCDCEBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x57D29B0", Offset = "0x57D0FB0", VA = "0x1857D29B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int DHADMHDBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x57D3110", Offset = "0x57D1710", VA = "0x1857D3110")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string OMBLKOFJABM
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x57D28E0", Offset = "0x57D0EE0", VA = "0x1857D28E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public CNDOOEKNEFJ PBGJOKKAFMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x57D30A0", Offset = "0x57D16A0", VA = "0x1857D30A0")]
		get
		{
			return default(CNDOOEKNEFJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x57D2BB0", Offset = "0x57D11B0", VA = "0x1857D2BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public COMHGNEIAFA EIGKBNJKLHK
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x57D2AB0", Offset = "0x57D10B0", VA = "0x1857D2AB0")]
		get
		{
			return default(COMHGNEIAFA);
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x57D2470", Offset = "0x57D0A70", VA = "0x1857D2470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool DJCECAJDNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x57D2E50", Offset = "0x57D1450", VA = "0x1857D2E50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool NCNBJDOBGCP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x57D2A90", Offset = "0x57D1090", VA = "0x1857D2A90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool FMFOINPBCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x57D2500", Offset = "0x57D0B00", VA = "0x1857D2500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool HPPMGALCDON
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x57D3160", Offset = "0x57D1760", VA = "0x1857D3160")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool JJBAOBHLAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x57D2E70", Offset = "0x57D1470", VA = "0x1857D2E70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x57D2780", Offset = "0x57D0D80", VA = "0x1857D2780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool KHLCNBLCGLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x57D2E40", Offset = "0x57D1440", VA = "0x1857D2E40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x57D2460", Offset = "0x57D0A60", VA = "0x1857D2460")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public BDEOFCIIHMD GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BDEOFCIIHMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public BPHAEEKICAL FBPKJDCDANM
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BPHAEEKICAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x57D2700", Offset = "0x57D0D00", VA = "0x1857D2700")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public static NILFLMGAFIC LBBGOAOJJNO(AMCLHOADFGH IBEPDAFMEAD)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x57D2790", Offset = "0x57D0D90", VA = "0x1857D2790")]
	public bool HCNNMNFNPED()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x57D2250", Offset = "0x57D0850", VA = "0x1857D2250")]
	public bool ACHLNHNIJAM(JFOLKPKEHBJ PDLGJEIPEDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x57D2B20", Offset = "0x57D1120", VA = "0x1857D2B20")]
	public void KAPMEPOCLDJ(JFOLKPKEHBJ PDLGJEIPEDC, bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x57D2E80", Offset = "0x57D1480", VA = "0x1857D2E80")]
	public KIHFNANBKDD NCJBPLIHLFC(Allocator HINEEPDGLPG)
	{
		return default(KIHFNANBKDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x57D27B0", Offset = "0x57D0DB0", VA = "0x1857D27B0")]
	public void JCFKLJNCEJA(AMCLHOADFGH FKJGPCABBJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public AMCLHOADFGH(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(AMCLHOADFGH MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x57D2550", Offset = "0x57D0B50", VA = "0x1857D2550", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(AMCLHOADFGH FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface AJMKMBOMDNO
{
	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBDCFODMHDN(KIHFNANBKDD LNIELCFLEJE);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IFJOHHLPIIC(GameObject FLCGKEKAMCK, int ECAFKILJBKF);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct NINOOKAFLLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly ANNGDPPBHOI FIDLKHDDPII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly ANNGDPPBHOI HOLOHKLLGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly uint OOHILBIGJOC;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x57E15F0", Offset = "0x57DFBF0", VA = "0x1857E15F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct FPEPFOIDECD
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly NINOOKAFLLD ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(RVA = "0x57DC080", Offset = "0x57DA680", VA = "0x1857DC080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct FHGINHIMMKA
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly IAMDAJKPFJC BILPDCGHAAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly NINOOKAFLLD ILLCNPCAHGD;

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(RVA = "0x57DC080", Offset = "0x57DA680", VA = "0x1857DC080", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct AAPAHLKPBJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly uint OOHILBIGJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly bool GLCHKBKIDOC;

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x57D1FD0", Offset = "0x57D05D0", VA = "0x1857D1FD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface MIJOAPHHMJE
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool IPHLEJPPMFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool JOJIPMNMJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool MGBIMCPGPNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool PJBBOLEDAHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MKKGBPNKABP(object GFHGIIOIPBN);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LNAOGKJFKNF(object LIGIEJOGFAH);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void LCFKKKNMLDG(object LIGIEJOGFAH);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int CHCBKFEPNOH(GameObject LFMEKIMOADD);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MDFNNDCOLKN(NativeArray<int> IJOEDPAAIJH);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface CMJAGJHDBFI
{
	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHBFPEMPLNK(ENMPPPDAMHN HMLJKOHAJKN, NBAPNPGIPAA MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NBAPNPGIPAA KNCAAIPCOIK(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CNLHCEJCBPI(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FNKCMBBPENL(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DCMOHGLHEDJ(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ENMPPPDAMHN HBJBEJLBDDL(ENMPPPDAMHN HMLJKOHAJKN, int OLGOBCPPPBB);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KJOKNOBFEPI(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void COOCJKCKJJP(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI, ENMPPPDAMHN MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ABJGPDHGOHD(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JCPJPFOAFMG(ENMPPPDAMHN HMLJKOHAJKN, out ENMPPPDAMHN MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DEHNBPELOHH(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool GGCGAPIHACE(ENMPPPDAMHN HMLJKOHAJKN, out float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LCJNHEPBGAG(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool OOLKOKCHMKO(ENMPPPDAMHN HMLJKOHAJKN, out float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void ECOKPIOLIJF(ENMPPPDAMHN HMLJKOHAJKN, (Quaternion rot, Vector3 moments) FDPFMJCBPHA);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IPODNLMJNFJ(ENMPPPDAMHN HMLJKOHAJKN, out quaternion ANIGKMMOJOB, out float3 LOPAPNDCGMO);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ACHDPLKDGOD(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CBLCEMOKJGB(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 AJJDOJBIGKO(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 NNGGMNKPBLP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void ENBDOGDIGKA(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void EEHBOFMJCHM(ENMPPPDAMHN HMLJKOHAJKN, float3 MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float POBGEEKFMOC(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float CDMCMCOOIHE(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void HAHBLFJGLIA(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MGHPAGNHIMC(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode ACLFKBMKICI(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void CEGOHJFMOHF(ENMPPPDAMHN HMLJKOHAJKN, CollisionDetectionMode MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LMDIKFABHDL PNEMEODCGPJ(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void BKOCFMGLCLF(ENMPPPDAMHN HMLJKOHAJKN, LMDIKFABHDL MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool EJAFOGFEHOJ(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void GDCOKEDOAIH(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "32")]
	ENMPPPDAMHN BGKMIAGKHHM(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void KKGODJCIMGG(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "34")]
	ENMPPPDAMHN OPPJHONDIOF(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void JAMGDJKMPGM(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "36")]
	LMAKLIPDGJL BEIEGLKLGCP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void NDHGGPDHONL(ENMPPPDAMHN HMLJKOHAJKN, LMAKLIPDGJL ELKAPNBKJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool PIEELPKHJOE(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void PPGJHJEMMBG(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool OLGBEFDDJDD(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void NAKCCLMAIKO(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool CMFLIJDNPHL(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void NDNFBAMAINA(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints EKOEAHFMEPH(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void PPBNMCNHPHM(ENMPPPDAMHN HMLJKOHAJKN, RigidbodyConstraints MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float MPAOIKNBAPB(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void OLANIHBDKLF(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float KFPNNEPFIHP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void DDFEPAIPIOD(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool EIBHEFJMGOL(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void PPDMNLPGLKF(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool LNADLDGEJOK(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void NBIMMLIJNIC(ENMPPPDAMHN HMLJKOHAJKN, bool MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void MCIBNBBNLID(ENMPPPDAMHN HMLJKOHAJKN, int MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object PJNFHDEDOAO(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PCCPMJONGLB(ENMPPPDAMHN HMLJKOHAJKN, object MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object KPHAKFLDGAO(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void BPNMEOEFFOG(ENMPPPDAMHN HMLJKOHAJKN, object MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float EEBIDACFFFP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void EGIKGPEOFBN(ENMPPPDAMHN HMLJKOHAJKN, float MOLEJFDINLH);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void BHHGLOEPIAH(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void DCGILPKHPCC(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool KADKMFOJIFG(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void EIAHIFLJPPC(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void PMGHANFGMCL(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool DHCNMNDPCEK(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool EOCICADGOJE(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody NNFDPHKEOAH(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void FFJCJJPBLNC(ENMPPPDAMHN HMLJKOHAJKN, Rigidbody FMPHIOBBCLL);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void IBONCPCMLEF(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void IOAGCIAEOEF(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool HOGIEJCBEKL(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void BOJLENGDLGN(ENMPPPDAMHN HMLJKOHAJKN, float3 KEMGHPMICGF);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KJPBBCOOEBA(ENMPPPDAMHN HMLJKOHAJKN, float3 FKNMMHBCHIK);

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool EGBDOOIMGCO(ENMPPPDAMHN HMLJKOHAJKN, out float3 KEMGHPMICGF);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool PHFCOHFGAFA(ENMPPPDAMHN HMLJKOHAJKN, out float3 FKNMMHBCHIK);

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool MHOHHABFNAG(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void DLJKBDBNBIK(ENMPPPDAMHN HMLJKOHAJKN, object DCEGGIJLHGI, bool IBEINHPEJJJ);

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void DHFHOCLGGHD(ENMPPPDAMHN HMLJKOHAJKN, bool NGEHFLNPGDF);

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void PCNHFMLJPDE(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool HDMGNGBHBMN(ENMPPPDAMHN HMLJKOHAJKN);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface HNNPHIGJKMK
{
	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHAEGCGNNHA(Entity HBPLGEAHCKJ);

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GFKBKFPPLCA(Entity HBPLGEAHCKJ);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct GGOENMNPAJN : IEquatable<GGOENMNPAJN>
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly GGOENMNPAJN KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string MMBOIOPABOH
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x57DD150", Offset = "0x57DB750", VA = "0x1857DD150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public string NAONPFIAPCP
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x57DD0B0", Offset = "0x57DB6B0", VA = "0x1857DD0B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000295")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public GGOENMNPAJN(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x57DD010", Offset = "0x57DB610", VA = "0x1857DD010", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(GGOENMNPAJN FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface FOGGGIMKHHH
{
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FNJOAAPCNMP();

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EOJODPMJGNL(bool KMJMLKFLHBL);

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BNEHOAOOCKF(GameObject FLCGKEKAMCK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct EPKHHGEMBKJ : IEquatable<EPKHHGEMBKJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly EPKHHGEMBKJ KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x57DBB20", Offset = "0x57DA120", VA = "0x1857DBB20", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(EPKHHGEMBKJ FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct BNGBDALBBDH : IEquatable<BNGBDALBBDH>
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly BNGBDALBBDH KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private LJIKPIOGIDO HNIAOPAAIBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x57D6870", Offset = "0x57D4E70", VA = "0x1857D6870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool AMPIGGEALCC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x57D6570", Offset = "0x57D4B70", VA = "0x1857D6570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool KKEICILILBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0x57D6B40", Offset = "0x57D5140", VA = "0x1857D6B40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool LNPKFFHKOGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0x57D6540", Offset = "0x57D4B40", VA = "0x1857D6540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool PAKEPPELFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0x57D66F0", Offset = "0x57D4CF0", VA = "0x1857D66F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool PMOCJDIIABD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x57D6900", Offset = "0x57D4F00", VA = "0x1857D6900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool EHODKNINIOI
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x57D6E90", Offset = "0x57D5490", VA = "0x1857D6E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0x57D6810", Offset = "0x57D4E10", VA = "0x1857D6810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x57D6CE0", Offset = "0x57D52E0", VA = "0x1857D6CE0")]
	public bool OEEBMFMINMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0x57D6D20", Offset = "0x57D5320", VA = "0x1857D6D20")]
	public NILFLMGAFIC PDLFFIICDPF(NILFLMGAFIC LIGIEJOGFAH)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x57D6370", Offset = "0x57D4970", VA = "0x1857D6370")]
	public ENMPPPDAMHN BBKHFPOCHEA()
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public BNGBDALBBDH(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(BNGBDALBBDH MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x57D6650", Offset = "0x57D4C50", VA = "0x1857D6650", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(BNGBDALBBDH FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface KDGOMGPPJAN
{
	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BLIAAMDKPNO BFDOECHDKMM(GameObject LFMEKIMOADD);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJHMBCJGMJO(GameObject FLCGKEKAMCK, FPKNHKANDMB LPDFDBFPKLG, IMFMNLGPJGN OGLMELHBELK);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct BENLOGNDJHK : IComparable<BENLOGNDJHK>, IEquatable<BENLOGNDJHK>
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly BENLOGNDJHK CJBAGCINGJC;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly BENLOGNDJHK EGMBMOKGKKD;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly BENLOGNDJHK BBJLGNOLEDA;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly BENLOGNDJHK ACKGHLCJEJE;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly BENLOGNDJHK PNGOKJFKMKM;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly BENLOGNDJHK MDDDFKIHMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int FIFIFGFPIHM;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool BCALKDDNDEL
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x57D5F00", Offset = "0x57D4500", VA = "0x1857D5F00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int LFMHIOLIKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0x57D6010", Offset = "0x57D4610", VA = "0x1857D6010")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x953140", Offset = "0x951740", VA = "0x180953140")]
	public BENLOGNDJHK(int OLGOBCPPPBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(RVA = "0x57D5FA0", Offset = "0x57D45A0", VA = "0x1857D5FA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(RVA = "0x57D5F10", Offset = "0x57D4510", VA = "0x1857D5F10", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x3BDA010", Offset = "0x3BD8610", VA = "0x183BDA010", Slot = "5")]
	public bool Equals(BENLOGNDJHK FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(RVA = "0x57D5EF0", Offset = "0x57D44F0", VA = "0x1857D5EF0", Slot = "4")]
	public int CompareTo(BENLOGNDJHK FKJGPCABBJN)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x19EE800", Offset = "0x19ECE00", VA = "0x1819EE800")]
	public static BENLOGNDJHK LBBGOAOJJNO(int OLGOBCPPPBB)
	{
		return default(BENLOGNDJHK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x19EE800", Offset = "0x19ECE00", VA = "0x1819EE800")]
	public static int LBBGOAOJJNO(BENLOGNDJHK FPNKFNICEDM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x57D6020", Offset = "0x57D4620", VA = "0x1857D6020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[DefaultMember("Item")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface HMNOEMALJPC : IEnumerable<AAOPIAOGDMN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	AAOPIAOGDMN ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AAOPIAOGDMN EGCDMNKOBNB(CNGBAJDBKGM EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BENLOGNDJHK INBAPLHOGPD(CNGBAJDBKGM EFINPLKEDMK);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FNJNIBNDHEH
{
	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(RVA = "0x1C66B00", Offset = "0x1C65100", VA = "0x181C66B00")]
	public static BENLOGNDJHK INBAPLHOGPD<T>(this HMNOEMALJPC EGDOOPNCMJB, GOHNKJBJJHB<T> ECMAPGHKHFB) where T : struct
	{
		return default(BENLOGNDJHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface OCAAAEBGOCB
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool COEEJLLJBGI(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMHJKLCKNFO(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FGMCBHHMPLH(ENMPPPDAMHN HMLJKOHAJKN, out Guid DJLOBGOMBEL);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid JIACGLMFONM(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EEGEHIONIOF(ENMPPPDAMHN HMLJKOHAJKN, Guid DJLOBGOMBEL);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HKLCIMHPABK(ENMPPPDAMHN HMLJKOHAJKN, out Guid NEDBLEJEGBK);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid HIIPJLDEBKH(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNKIGPOGDOM(ENMPPPDAMHN HMLJKOHAJKN, Guid NEDBLEJEGBK);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGNBNLGADEK(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EBFKLAHKADD(ENMPPPDAMHN BIKOOLOFJJA, ENMPPPDAMHN HDBBNLFBJKG);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface CDONNANOMBA
{
	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FAFNIIMAHPO(ENMPPPDAMHN GIAMACBDIFH, bool MOLEJFDINLH);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct LILNNJOPOJO : IEquatable<LILNNJOPOJO>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LILNNJOPOJO KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public GFLBKNEKJLG KOMOOOAPCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(GFLBKNEKJLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private FPBCONIHDPK FCOGACMJCEA
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0x57DFF00", Offset = "0x57DE500", VA = "0x1857DFF00")]
		get
		{
			return default(FPBCONIHDPK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public IFEBDPAFELD BMKEFMKKOAP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0x57DFF70", Offset = "0x57DE570", VA = "0x1857DFF70")]
		get
		{
			return default(IFEBDPAFELD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public LILNNJOPOJO(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(LILNNJOPOJO MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x57DFE60", Offset = "0x57DE460", VA = "0x1857DFE60", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(LILNNJOPOJO FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface HGMEOKAAKKA
{
	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHIELGLPOFA(ENMPPPDAMHN HMLJKOHAJKN, CNDOOEKNEFJ NLCFPEDLIMJ, bool EDFLKCKFCDC, JFOLKPKEHBJ GLNHJAOBGOB);

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NNLHFKNPDKH(ENMPPPDAMHN HMLJKOHAJKN, CNDOOEKNEFJ NLCFPEDLIMJ, bool EDFLKCKFCDC, bool OHHGJDIEOHD, bool AHFLDEJODDD);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IHCBJKJDAMN KAGBMAMJDIJ(ENMPPPDAMHN AIMNENJKCBP, List<ENMPPPDAMHN> BAJEHGFBOCD);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IPLJKLPPIKG(GameObject GDAPGPJGFLA, GameObject AENOLBIOECB);

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MFBFIBLFKAG(GameObject AENOLBIOECB);

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T IKBLOAHDMFN<T>(GameObject OLCMLKKFBEP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KCEJLACONPF(Collider HCHCJABNKJO);

	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject NHGGBHCIOPD<T>(string ECMAPGHKHFB) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface FOKGJFJPKEK
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	IReadOnlyCollection<IMNNLGNGPKK> GIEKDLKKKMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BHGFLFPGFCO(int MPGHGDABPMN, out IMNNLGNGPKK AACPPJHALGJ);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMNNLGNGPKK KFJHOLCOHJM(Type KLGGKKGCLHM);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class GBAJFODGFNL
{
	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x1A11ED0", Offset = "0x1A104D0", VA = "0x181A11ED0")]
	public static T ODGAKJDNNCF<T>(this FOKGJFJPKEK LGKOPPBPBHD, Entity MPAGCMNFGMI) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x1A112F0", Offset = "0x1A0F8F0", VA = "0x181A112F0")]
	public static IMNNLGNGPKK KFJHOLCOHJM<T>(this FOKGJFJPKEK LGKOPPBPBHD) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface IKMNPNDODOB
{
	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HODDPHJKAIK(bool LHEAMNILFLF);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface EOACBFHBFAO
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool DONKHGNKKGP
	{
		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface KIMCOPEIFEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	bool KILEJPECOBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool DNPAFPKHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	KOMGFJFAEGJ AJNFLPECFNF
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CBENEIMMAGE OILCMLAGOGI(bool NPAEINNJCHM = false);

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CBENEIMMAGE OADODCHKOBB(IEnumerable<ENMPPPDAMHN> LNIELCFLEJE, in ABJGEIBOMMO GOALPJDNEKG);

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GGFHOFNANBO DKFOBHGHNEB(ByteString MNEINKFLAAE);

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	CINHJBLABIP BOGGHPCCNBA(ByteString NFNCBDOMNAL, ENMPPPDAMHN HDBBNLFBJKG, in ABJGEIBOMMO KIGHPCHNDDE, HKACBKPJJFC FKCOMMJANEB, bool NNJNPPDBNDJ = true);

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JJBLIOOKDIN();

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CAAFBHBLFHN(bool OAJAEIBGHAC);

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FBGEKGCCCOL BGLNABMJEEI(IEnumerable<OPAIBEOPLMG> OGIMNFBMPBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class MKEPFEKIPJE
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface GBHAJEIKFBB : GFDBIECGPKC, HMKFBCDDIDP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	PLONEGJPBHK FDCDBHOPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	LIACCBFBACG MILBJGFKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	BJDDOFPNFNG LJLIENEMEPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface HMKFBCDDIDP
{
	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool JLMOFFAFBKO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface MGPDFABDGMJ
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool AKGMPEPKIPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool GLIMKGACNLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface DMAKAEPJKDA
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	Guid PNLNEDJDIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JENHHKAKEDH(Guid DJLOBGOMBEL, Guid NEDBLEJEGBK, string ECMAPGHKHFB);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct ANNGDPPBHOI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	internal int EBMCNIDEEKK;

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x57D3550", Offset = "0x57D1B50", VA = "0x1857D3550", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class LANFKNHOPMM
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private struct KPMFFJNMGMG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Guid NAMBIBPENHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public KLOBPENDBNL EFHEPPDDDCG;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct KLOBPENDBNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int MOLEJFDINLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int LFFGFJNPAFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int OHLPHLGMFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int PEBPFDEDKND;

		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x57DFAC0", Offset = "0x57DE0C0", VA = "0x1857DFAC0")]
		public bool IKHFMIGFOND(out EEKJFDFIEGN HGGMFNJGHIP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(RVA = "0x57DFB60", Offset = "0x57DE160", VA = "0x1857DFB60")]
		public KLOBPENDBNL(EEKJFDFIEGN HGGMFNJGHIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x57DFD10", Offset = "0x57DE310", VA = "0x1857DFD10")]
	public static Guid GIEEBJMCCJA(this EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x57DFDB0", Offset = "0x57DE3B0", VA = "0x1857DFDB0")]
	public static bool LHMEBMPHFDJ(this Guid NAMBIBPENHK, out EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(DGEHMBHPJAI))]
public readonly struct ENMPPPDAMHN : IComparable<ENMPPPDAMHN>, IEquatable<ENMPPPDAMHN>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly ENMPPPDAMHN CJBAGCINGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly PHGPCEHAGAA FCDGNCOICKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LocalId HMLJKOHAJKN;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public LocalId BMOFCOBKKNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(RVA = "0x16902A0", Offset = "0x168E8A0", VA = "0x1816902A0")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool AFPHGIBLJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(RVA = "0x57DB6A0", Offset = "0x57D9CA0", VA = "0x1857DB6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool ANMNMNMBDDG
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x57DB4D0", Offset = "0x57D9AD0", VA = "0x1857DB4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool GEPLAPMBLCC
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x57DB450", Offset = "0x57D9A50", VA = "0x1857DB450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x57DB950", Offset = "0x57D9F50", VA = "0x1857DB950")]
	public ENMPPPDAMHN(JBBANOPACMB FMJNIBHDIHB, LocalId HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
	public NILFLMGAFIC BOINDONCKBB()
	{
		return default(NILFLMGAFIC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x16902A0", Offset = "0x168E8A0", VA = "0x1816902A0")]
	public static LocalId LBBGOAOJJNO(ENMPPPDAMHN DBLKNFACMOL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x57DB840", Offset = "0x57D9E40", VA = "0x1857DB840")]
	public static Entity LBBGOAOJJNO(ENMPPPDAMHN DBLKNFACMOL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x57DB3F0", Offset = "0x57D99F0", VA = "0x1857DB3F0")]
	public static bool BDIEMMGDBNG(ENMPPPDAMHN GNJGFBLEGKK, ENMPPPDAMHN HEPECHBEGLE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x57DB780", Offset = "0x57D9D80", VA = "0x1857DB780")]
	public static bool HGHCMFFFPIK(ENMPPPDAMHN GNJGFBLEGKK, ENMPPPDAMHN HEPECHBEGLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x57DB850", Offset = "0x57D9E50", VA = "0x1857DB850", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x57DB5D0", Offset = "0x57D9BD0", VA = "0x1857DB5D0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x57DB470", Offset = "0x57D9A70", VA = "0x1857DB470", Slot = "4")]
	public int CompareTo(ENMPPPDAMHN FKJGPCABBJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x57DB4F0", Offset = "0x57D9AF0", VA = "0x1857DB4F0", Slot = "5")]
	public bool Equals(ENMPPPDAMHN FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class CHGBPKFHPBH
{
	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x57D77F0", Offset = "0x57D5DF0", VA = "0x1857D77F0")]
	public static EEKJFDFIEGN CFEAEMLGJDL(this ENMPPPDAMHN NKFOPKJGBEM)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x1919E20", Offset = "0x1918420", VA = "0x181919E20")]
	public static T JIFDAIIHPLK<T>(this ENMPPPDAMHN NKFOPKJGBEM) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class DGEHMBHPJAI
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface LJAFLCDDJAH
{
	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool HJJCFGPENBE
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFEMDGPFPIH(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NGPLMKEHGEP(ENMPPPDAMHN HMLJKOHAJKN, bool EDFLKCKFCDC, bool OHHGJDIEOHD, bool BPBGEHLMKAL);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct HPCDDCJODHI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly KIHFNANBKDD BFIMLFNBNGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NativeArray<byte> LKPPDEOAPDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NativeArray<byte> ENDLICBNMBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly BENLOGNDJHK FPNKFNICEDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int BGLJMJDCPFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Type NDNCCNDGIOD;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public KIHFNANBKDD BPFFFONHENF
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(RVA = "0x1D43460", Offset = "0x1D41A60", VA = "0x181D43460")]
		get
		{
			return default(KIHFNANBKDD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x57DE480", Offset = "0x57DCA80", VA = "0x1857DE480")]
	public HPCDDCJODHI(KIHFNANBKDD BFIMLFNBNGO, NativeArray<byte> LKPPDEOAPDB, NativeArray<byte> ENDLICBNMBH, BENLOGNDJHK FPNKFNICEDM, int BGLJMJDCPFK, Type NDNCCNDGIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x11CFFE0", Offset = "0x11CE5E0", VA = "0x1811CFFE0")]
	public NativeArray<T> NFPAFCEBFJH<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x11CFE80", Offset = "0x11CE480", VA = "0x1811CFE80")]
	public NativeArray<T> FJAMJKIIFFM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x11CFEC0", Offset = "0x11CE4C0", VA = "0x1811CFEC0")]
	public (KIHFNANBKDD, NativeArray<T>, NativeArray<T>) MBNHJLNEIKL<T>() where T : struct
	{
		return default((KIHFNANBKDD, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x57DE3E0", Offset = "0x57DC9E0", VA = "0x1857DE3E0")]
	public AMICGDPKLIC NNIMHOFGEBM()
	{
		return default(AMICGDPKLIC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct ODNNBFFBCFD : IEquatable<ODNNBFFBCFD>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly ODNNBFFBCFD KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x57E1B20", Offset = "0x57E0120", VA = "0x1857E1B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x57E1B80", Offset = "0x57E0180", VA = "0x1857E1B80")]
	public void MNFAMGHJOLE(bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x57E1920", Offset = "0x57DFF20", VA = "0x1857E1920")]
	public void BOOMILABPFA(bool MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x22EC5E0", Offset = "0x22EABE0", VA = "0x1822EC5E0")]
	public T BPLOIEJHGAF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public ODNNBFFBCFD(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000329")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x57E1A80", Offset = "0x57E0080", VA = "0x1857E1A80", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(ODNNBFFBCFD FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct HEHGOKCBDMB : IEquatable<HEHGOKCBDMB>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly HEHGOKCBDMB KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000331")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000332")]
	[Cpp2IlInjected.Address(RVA = "0x57DD380", Offset = "0x57DB980", VA = "0x1857DD380", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000333")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(HEHGOKCBDMB FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000334")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface MDHPMKEGPDB
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	ODHLOBENJON DCECOBGOMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	ODHLOBENJON LDBNMNNFHMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	ODHLOBENJON MOAONFLIEIF
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	ODHLOBENJON JFDAFJDPIBM
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	ODHLOBENJON MHKDGLOEBDL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	ODHLOBENJON ANKIIHHGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	ODHLOBENJON KGALHCNIIPB
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	ODHLOBENJON JGLELHPJOJG
	{
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct JNJODLALMOB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float BMHFDLDHBLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 NGHPIMAKGOH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct GFLBKNEKJLG : IEquatable<GFLBKNEKJLG>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly GFLBKNEKJLG KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	private KFKPPMKJFMM LIBLEKFKHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x57DCC10", Offset = "0x57DB210", VA = "0x1857DCC10")]
		get
		{
			return default(KFKPPMKJFMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	public NAFAEHLOGPB MHJCDKMCENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x57DCD00", Offset = "0x57DB300", VA = "0x1857DCD00")]
		get
		{
			return default(NAFAEHLOGPB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public LOLPJMNPBOA OCJBDPAKOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x57DC950", Offset = "0x57DAF50", VA = "0x1857DC950")]
		get
		{
			return default(LOLPJMNPBOA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public CJMFKAHBBMN BDAPOHCPJAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x57DC6D0", Offset = "0x57DACD0", VA = "0x1857DC6D0")]
		get
		{
			return default(CJMFKAHBBMN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public OPMNBOAEHGB CJMBAJDHDPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x57DC860", Offset = "0x57DAE60", VA = "0x1857DC860")]
		get
		{
			return default(OPMNBOAEHGB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public DFHKOKGFHIE CEEHBGNNGJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x57DCE60", Offset = "0x57DB460", VA = "0x1857DCE60")]
		get
		{
			return default(DFHKOKGFHIE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x57DCC80", Offset = "0x57DB280", VA = "0x1857DCC80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public BMMIDHIMKGI BKDCNLEINMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x57DC9C0", Offset = "0x57DAFC0", VA = "0x1857DC9C0")]
		get
		{
			return default(BMMIDHIMKGI);
		}
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x57DC740", Offset = "0x57DAD40", VA = "0x1857DC740")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public float JPKFFGIALKD
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x57DC5D0", Offset = "0x57DABD0", VA = "0x1857DC5D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x57DCAB0", Offset = "0x57DB0B0", VA = "0x1857DCAB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public Vector3 NFPFHJEFLJP
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x57DC640", Offset = "0x57DAC40", VA = "0x1857DC640")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(RVA = "0x57DCD70", Offset = "0x57DB370", VA = "0x1857DCD70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public float FDFGGHGHDJC
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(RVA = "0x57DCB30", Offset = "0x57DB130", VA = "0x1857DCB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public JCEKDMMOENF.LKFJKAAIEAJ PMOEIOIHOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(RVA = "0x57DC8E0", Offset = "0x57DAEE0", VA = "0x1857DC8E0")]
		get
		{
			return default(JCEKDMMOENF.LKFJKAAIEAJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(RVA = "0x57DCA30", Offset = "0x57DB030", VA = "0x1857DCA30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public BDEOFCIIHMD GLAMIBJJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(BDEOFCIIHMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(RVA = "0x57DCBB0", Offset = "0x57DB1B0", VA = "0x1857DCBB0")]
	public LILNNJOPOJO JEOAGHHAJEL()
	{
		return default(LILNNJOPOJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x57DCE00", Offset = "0x57DB400", VA = "0x1857DCE00")]
	public CJNJIJCNICA NKFPBAIPJDN()
	{
		return default(CJNJIJCNICA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public GFLBKNEKJLG(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(RVA = "0x57D2C30", Offset = "0x57D1230", VA = "0x1857D2C30")]
	public static bool LBBGOAOJJNO(GFLBKNEKJLG MOLEJFDINLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(RVA = "0x57DC7C0", Offset = "0x57DADC0", VA = "0x1857DC7C0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(GFLBKNEKJLG FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface KGPIAKEFEHB
{
	[Cpp2IlInjected.Token(Token = "0x17000109")]
	LIFCBCFOLBC FDCDBHOPKIM
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	LIACCBFBACG MILBJGFKLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	MOFMKHOGCPA LBFLAKEIFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	DEMCMMGHLIH FBPKJDCDANM
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	KKJOECNGBND MIBOLEGADCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	KIMCOPEIFEL DNOEHJKKOFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	EMNFNBCOPIC CNOCKCOFJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	HEONMBBDPJM PIBMOGJMBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	GHPFOIJGFBB LGJOADANKKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	LJIKPIOGIDO ICDANIPJMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	MGCDDMFMGJA ANKIIHHGNHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	CDONNANOMBA DLKIFLPIMLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	OBPAHFKOKAC JCEGIKLPKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	OCAAAEBGOCB AEIHDONIHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	APFNGMLMBFH KIDJHBNKDDL
	{
		[Cpp2IlInjected.Token(Token = "0x600036A")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	CMJAGJHDBFI HHDLOPLGBLB
	{
		[Cpp2IlInjected.Token(Token = "0x600036B")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	MDHPMKEGPDB PMDIGCLFBAE
	{
		[Cpp2IlInjected.Token(Token = "0x600036C")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	FOKGJFJPKEK CFAONPPIDOO
	{
		[Cpp2IlInjected.Token(Token = "0x600036D")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface MIOGGIJDIDO
{
	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	object AIDMLCOKMAF
	{
		[Cpp2IlInjected.Token(Token = "0x600036E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HBDCFODMHDN(KIHFNANBKDD LNIELCFLEJE);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface DEMCMMGHLIH
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AMICGDPKLIC> LNFJLNBDNID;

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ENMPPPDAMHN BGKMIAGKHHM(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKOJGPNJJPO(ref List<ENMPPPDAMHN> BCPEGPJDFMI);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ENMPPPDAMHN OPPJHONDIOF(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool JAMGDJKMPGM(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN HDBBNLFBJKG, bool HNOGDNKLDPO);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool HABHLECNBOO(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN HDBBNLFBJKG);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int DCMOHGLHEDJ(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KIHFNANBKDD AENDFFGDBIH(ENMPPPDAMHN GIAMACBDIFH);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AAPAIFFLBIH(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN JNMPHJHBJHE);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool GGFOGAAPHID(ENMPPPDAMHN HMLJKOHAJKN, ENMPPPDAMHN IOKDMANFCEJ);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "11")]
	ENMPPPDAMHN IBFCCLELLKC(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JFELDPLAPKL(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE, out ENMPPPDAMHN EKPEPIHNAIJ);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class MCEGJPAGNNG
{
	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x57E0110", Offset = "0x57DE710", VA = "0x1857E0110")]
	public static List<ENMPPPDAMHN> KKOJGPNJJPO(this DEMCMMGHLIH PFGMPLPGGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x57E0020", Offset = "0x57DE620", VA = "0x1857E0020")]
	public static bool KKAMBADGMPB(this DEMCMMGHLIH PFGMPLPGGOJ, ENMPPPDAMHN HMLJKOHAJKN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum CBGIFDDBMPC
{
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface HEONMBBDPJM
{
	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ENMPPPDAMHN> CCHBHGGPMAE(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ENMPPPDAMHN LBFGAKDHAMO(ENMPPPDAMHN HMLJKOHAJKN, int OLGOBCPPPBB);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int KAKBFJAKKOM(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LCDOAODHHAO HCIFBNEECAP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDEIJNOKCAM(ENMPPPDAMHN HMLJKOHAJKN, LCDOAODHHAO FKGPFMNALNI);

	[Cpp2IlInjected.Token(Token = "0x6000384")]
	[Cpp2IlInjected.Address(Slot = "5")]
	ENMPPPDAMHN HODCDGFMEME(ENMPPPDAMHN HMLJKOHAJKN, [Optional] float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] float3? CHAPNJAEPMG);

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(Slot = "6")]
	ENMPPPDAMHN LHGGACMOCDK(ENMPPPDAMHN HMLJKOHAJKN, int OLGOBCPPPBB, [Optional] float3? POOFJFBIOJJ, [Optional] quaternion? MEHKCJCIOOL, [Optional] float3? CHAPNJAEPMG);

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LJFNKENDNMA(ENMPPPDAMHN HMLJKOHAJKN, int OLGOBCPPPBB);

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IPAMOOHHOPB(ENMPPPDAMHN HMLJKOHAJKN);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface CFANJNBMIIA
{
	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPAHJPJDHJO(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OLJHHDOLJHL(ENMPPPDAMHN HMLJKOHAJKN, Transform DMECJMCKFAG);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface MEEEHHLENLE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	LocalId GGMLFLAOIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	LocalId DAGNAPCANAA
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BCEMHMELKPC(float3 OKNCDCLPPNJ);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GGJAAPIPJLI(float3 OKNCDCLPPNJ);

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void NFHJIOHOCNM(out float3 FIDLKHDDPII, out float3 HOLOHKLLGJH);

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BLMEGEAOGHC(float3 FIDLKHDDPII, float3 HOLOHKLLGJH);

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOIGPEHNCGB(Color FIDLKHDDPII, Color HOLOHKLLGJH);

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MEEEHHLENLE Instantiate(Transform DMECJMCKFAG);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface NIJKJLPIHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GMAKAKECEDK(Transform DMECJMCKFAG, MEEEHHLENLE MFDIABGFPCO);

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MEEEHHLENLE GODGJIKJLHI();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct MDDKOOMFIGL : IEquatable<MDDKOOMFIGL>
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly MDDKOOMFIGL KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private DBJCDDIHNNI OBOAMBCABAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x57E0200", Offset = "0x57DE800", VA = "0x1857E0200")]
		get
		{
			return default(DBJCDDIHNNI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public CPNJNHMENFJ FLGMFFNLLHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x57E0270", Offset = "0x57DE870", VA = "0x1857E0270")]
		get
		{
			return default(CPNJNHMENFJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x57E0380", Offset = "0x57DE980", VA = "0x1857E0380")]
	public BGEIMNEBEIP IEBBMHPCCMB()
	{
		return default(BGEIMNEBEIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public MDDKOOMFIGL(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x57E02E0", Offset = "0x57DE8E0", VA = "0x1857E02E0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(MDDKOOMFIGL FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct JODKFMBHNDC : IEquatable<JODKFMBHNDC>
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly JODKFMBHNDC KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x57DE7B0", Offset = "0x57DCDB0", VA = "0x1857DE7B0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(JODKFMBHNDC FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct DMNFAHCIFGP : IEquatable<DMNFAHCIFGP>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly DMNFAHCIFGP KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public DMNFAHCIFGP(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A6")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x57DA650", Offset = "0x57D8C50", VA = "0x1857DA650", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A8")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(DMNFAHCIFGP FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x57DA6F0", Offset = "0x57D8CF0", VA = "0x1857DA6F0")]
	public bool JEHILLDLMOF(out Collider HCHCJABNKJO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct EIBPHEFAAAK : IEquatable<EIBPHEFAAAK>
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly EIBPHEFAAAK KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public ENMPPPDAMHN ILMEFPJAMNB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(ENMPPPDAMHN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public CJNJIJCNICA CJADFCLKDLE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x57DAF20", Offset = "0x57D9520", VA = "0x1857DAF20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public float3 BMIKEFPDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x57DB080", Offset = "0x57D9680", VA = "0x1857DB080")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x57DB320", Offset = "0x57D9920", VA = "0x1857DB320")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public quaternion BFLAMDMHHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x57DAFF0", Offset = "0x57D95F0", VA = "0x1857DAFF0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x57DB220", Offset = "0x57D9820", VA = "0x1857DB220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public float3 MMJPBEILHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x57DAC70", Offset = "0x57D9270", VA = "0x1857DAC70")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x57DB110", Offset = "0x57D9710", VA = "0x1857DB110")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public LBNLJFLJFKA GGKJMCPPLHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x57DB1A0", Offset = "0x57D97A0", VA = "0x1857DB1A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	private MPBBJIADOKK CDKDBNOFKDC
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x57DAE40", Offset = "0x57D9440", VA = "0x1857DAE40")]
		get
		{
			return default(MPBBJIADOKK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private AGJHBCDOMJH CONBONBHNOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x57DB2B0", Offset = "0x57D98B0", VA = "0x1857DB2B0")]
		get
		{
			return default(AGJHBCDOMJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private LKCHFFDAHAM BCEAGCNDAEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x57DAB60", Offset = "0x57D9160", VA = "0x1857DAB60")]
		get
		{
			return default(LKCHFFDAHAM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private CDEONMOKOOF HLBFFFGPCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x57DAD00", Offset = "0x57D9300", VA = "0x1857DAD00")]
		get
		{
			return default(CDEONMOKOOF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private AMLDCEFKPMA ELAHPLEOEPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x57DAEB0", Offset = "0x57D94B0", VA = "0x1857DAEB0")]
		get
		{
			return default(AMLDCEFKPMA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public EIBPHEFAAAK(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x57DABD0", Offset = "0x57D91D0", VA = "0x1857DABD0", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(EIBPHEFAAAK FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x57DAD70", Offset = "0x57D9370", VA = "0x1857DAD70")]
	public void HDMHBJCGFCD(CJNJIJCNICA MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct BDEOFCIIHMD : IEquatable<BDEOFCIIHMD>
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly BDEOFCIIHMD KKACGAHHFMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly ENMPPPDAMHN GIAMACBDIFH;

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	public NILFLMGAFIC LKMDIOHLICO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x1D43430", Offset = "0x1D41A30", VA = "0x181D43430")]
		get
		{
			return default(NILFLMGAFIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	private JBBANOPACMB KOKMAEINHGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x57D24F0", Offset = "0x57D0AF0", VA = "0x1857D24F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private KKJOECNGBND PPONFEDHABB
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x57D5850", Offset = "0x57D3E50", VA = "0x1857D5850")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	public bool DBLNKINANEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x57D4870", Offset = "0x57D2E70", VA = "0x1857D4870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public Vector3 BMIKEFPDJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x57D58D0", Offset = "0x57D3ED0", VA = "0x1857D58D0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x57D5DC0", Offset = "0x57D43C0", VA = "0x1857D5DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Quaternion BFLAMDMHHOD
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x57D56A0", Offset = "0x57D3CA0", VA = "0x1857D56A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x57D5AD0", Offset = "0x57D40D0", VA = "0x1857D5AD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Vector3 EFHCKDIEAFB
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x57D3A10", Offset = "0x57D2010", VA = "0x1857D3A10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x57D3ED0", Offset = "0x57D24D0", VA = "0x1857D3ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Quaternion LKLHMLNBDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x57D51B0", Offset = "0x57D37B0", VA = "0x1857D51B0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x57D4EC0", Offset = "0x57D34C0", VA = "0x1857D4EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public float CCLJFKBBBPK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x57D55F0", Offset = "0x57D3BF0", VA = "0x1857D55F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x57D3950", Offset = "0x57D1F50", VA = "0x1857D3950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public float LENGADJAFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003D7")]
		[Cpp2IlInjected.Address(RVA = "0x57D42A0", Offset = "0x57D28A0", VA = "0x1857D42A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public Vector3 MMJPBEILHFA
	{
		[Cpp2IlInjected.Token(Token = "0x60003D8")]
		[Cpp2IlInjected.Address(RVA = "0x57D44B0", Offset = "0x57D2AB0", VA = "0x1857D44B0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D9")]
		[Cpp2IlInjected.Address(RVA = "0x57D59E0", Offset = "0x57D3FE0", VA = "0x1857D59E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 PNOPCHEHKJD
	{
		[Cpp2IlInjected.Token(Token = "0x60003DA")]
		[Cpp2IlInjected.Address(RVA = "0x57D5500", Offset = "0x57D3B00", VA = "0x1857D5500")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 EIBEMMNJBIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003DB")]
		[Cpp2IlInjected.Address(RVA = "0x57D5300", Offset = "0x57D3900", VA = "0x1857D5300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Matrix4x4 FCBFLEGDOBN
	{
		[Cpp2IlInjected.Token(Token = "0x60003DC")]
		[Cpp2IlInjected.Address(RVA = "0x57D3790", Offset = "0x57D1D90", VA = "0x1857D3790")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x226E990", Offset = "0x226CF90", VA = "0x18226E990")]
	public BDEOFCIIHMD(ENMPPPDAMHN HMLJKOHAJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x57D2760", Offset = "0x57D0D60", VA = "0x1857D2760", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x57D4350", Offset = "0x57D2950", VA = "0x1857D4350", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x57D2520", Offset = "0x57D0B20", VA = "0x1857D2520", Slot = "4")]
	public bool Equals(BDEOFCIIHMD FKJGPCABBJN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x57D3180", Offset = "0x57D1780", VA = "0x1857D3180", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x57D57F0", Offset = "0x57D3DF0", VA = "0x1857D57F0")]
	public NJEHFHIEPFH MMENDJCMOCG()
	{
		return default(NJEHFHIEPFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x57D3810", Offset = "0x57D1E10", VA = "0x1857D3810")]
	public void BKPOKKKLPMH(out Matrix4x4 CNKALCHPDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x57D4A10", Offset = "0x57D3010", VA = "0x1857D4A10")]
	public void JHGHBHCJHAO(out Vector3 AOOKGCNIFMO, out Quaternion CIIMMCBKCML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x57D3C10", Offset = "0x57D2210", VA = "0x1857D3C10")]
	public void DKNFMLLPKMA(out RigidTransform ELMHJHHOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x57D4C60", Offset = "0x57D3260", VA = "0x1857D4C60")]
	public ABJGEIBOMMO JLJONACDPDK()
	{
		return default(ABJGEIBOMMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x57D4B90", Offset = "0x57D3190", VA = "0x1857D4B90")]
	public void JLJONACDPDK(out ABJGEIBOMMO BHECBPBIBGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x57D4180", Offset = "0x57D2780", VA = "0x1857D4180")]
	public ABJGEIBOMMO EFHAFOFMAFK()
	{
		return default(ABJGEIBOMMO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x57D41D0", Offset = "0x57D27D0", VA = "0x1857D41D0")]
	public void EFHAFOFMAFK(out ABJGEIBOMMO ELMHJHHOMOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x57D3FC0", Offset = "0x57D25C0", VA = "0x1857D3FC0")]
	public Vector3 ECIGICCJJFE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x57D35B0", Offset = "0x57D1BB0", VA = "0x1857D35B0")]
	public void AEMJAJFBJEJ(in Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x57D3DC0", Offset = "0x57D23C0", VA = "0x1857D3DC0")]
	public Vector3 ECBAFEIAPBC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x57D5CD0", Offset = "0x57D42D0", VA = "0x1857D5CD0")]
	public void PHDDEJKAPNO(in Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x57D4CB0", Offset = "0x57D32B0", VA = "0x1857D4CB0")]
	public Quaternion JOKMHACHIMP()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x57D36A0", Offset = "0x57D1CA0", VA = "0x1857D36A0")]
	public void BDAGEKPJKOA(in Quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x57D48C0", Offset = "0x57D2EC0", VA = "0x1857D48C0")]
	public Quaternion JEEIFJCJBAI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x57D3B20", Offset = "0x57D2120", VA = "0x1857D3B20")]
	public void DCGBGKJKHLA(in Quaternion MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x57D45C0", Offset = "0x57D2BC0", VA = "0x1857D45C0")]
	public float FGGMJPNJDEC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x57D4E00", Offset = "0x57D3400", VA = "0x1857D4E00")]
	public void KLEIDPCLBMA(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x57D40D0", Offset = "0x57D26D0", VA = "0x1857D40D0")]
	public float EEBLBDOBPKP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x57D43F0", Offset = "0x57D29F0", VA = "0x1857D43F0")]
	public void FBEJDKOBJAB(float MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x57D5410", Offset = "0x57D3A10", VA = "0x1857D5410")]
	public void LNEBKPMEOIB(in Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x57D5BC0", Offset = "0x57D41C0", VA = "0x1857D5BC0")]
	public Vector3 ONEALIHAOMC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(RVA = "0x57D3CD0", Offset = "0x57D22D0", VA = "0x1857D3CD0")]
	public void DOHKANKFLDI(in Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(RVA = "0x57D4760", Offset = "0x57D2D60", VA = "0x1857D4760")]
	public Vector3 GFEPOBPFOMH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(RVA = "0x57D4670", Offset = "0x57D2C70", VA = "0x1857D4670")]
	public void GANOCGGJLOD(in Vector3 MOLEJFDINLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(RVA = "0x57D4FB0", Offset = "0x57D35B0", VA = "0x1857D4FB0")]
	public Vector3 KOBDNGABLMF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(RVA = "0x57D50C0", Offset = "0x57D36C0", VA = "0x1857D50C0")]
	public void LBPPCPGFOCB(in Vector3 MOLEJFDINLH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface JBBANOPACMB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	KGPIAKEFEHB BPIOEGFNGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60003FC")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	PHGPCEHAGAA CCFABJCJIKB
	{
		[Cpp2IlInjected.Token(Token = "0x60003FD")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<KIHFNANBKDD, NativeArray<BLIAAMDKPNO>> EIBMMCALJMC;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<KIHFNANBKDD> JOCBHBNJMIE;

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	DLBKPAILIEM LGLNCHECMNH(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	BLIAAMDKPNO EBNGCMIBIEG(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MBACIJOLGCB(EEKJFDFIEGN HGGMFNJGHIP, FCLHKJAHMCN CBIMOLNMMAP);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "9")]
	NILFLMGAFIC DDIJEPCNDPH(ENMPPPDAMHN HMLJKOHAJKN, [Optional] object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool AHHLAGNLFJP(ENMPPPDAMHN HMLJKOHAJKN, out FCLHKJAHMCN CBIMOLNMMAP);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AMJHHOCDEFA(ENMPPPDAMHN HMLJKOHAJKN, out Transform DMECJMCKFAG);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool IDOBKJNCGOE(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void DDFNBOCHOND(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool CKFCPFNJLCG(LocalId HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PHKIGIFCEFF(LocalId HMLJKOHAJKN, object DCEGGIJLHGI);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "16")]
	ENMPPPDAMHN FBGOFHNIPBN(EEKJFDFIEGN HGGMFNJGHIP);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool ELLJKDEAPPH(EEKJFDFIEGN HGGMFNJGHIP, out ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	EEKJFDFIEGN CFEAEMLGJDL(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	KIHFNANBKDD FBGOFHNIPBN(NativeArray<EEKJFDFIEGN> HGGMFNJGHIP, Allocator HINEEPDGLPG);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	KIHFNANBKDD LJAELKGMCMD(NativeArray<EEKJFDFIEGN> HGGMFNJGHIP, NativeArray<FNDBMHENIMP> HNMKHJBPNJK, Allocator HINEEPDGLPG);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	NILFLMGAFIC EGMBMOKGKKD(BLIAAMDKPNO POJMFCODLHG, bool JFCBHFIDNFJ);

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	NILFLMGAFIC EGMBMOKGKKD(BLIAAMDKPNO POJMFCODLHG);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	NILFLMGAFIC GEOAAGIPFLI(BLIAAMDKPNO POJMFCODLHG);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "24")]
	NILFLMGAFIC LMGLKFKGBGA(BLIAAMDKPNO POJMFCODLHG);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "25")]
	NILFLMGAFIC LJAELKGMCMD(EEKJFDFIEGN HGGMFNJGHIP, BLIAAMDKPNO POJMFCODLHG);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AMCLHOADFGH CEGCFDKFBOF();

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "27")]
	CJNJIJCNICA DKAGGLAKDJP();

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "28")]
	LILNNJOPOJO IIJCEINICFO(IFEBDPAFELD LKFNFBDOAHH);

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ENNCOPBPMIP(KIHFNANBKDD LNIELCFLEJE);

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void AFFJDJOCMDN(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void AEEAPLHBKLI(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void ENNCOPBPMIP(ENMPPPDAMHN HMLJKOHAJKN);

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(Slot = "33")]
	KIHFNANBKDD BKAFCMHHBBL(KIHFNANBKDD BEDADBBGMAL, Allocator HINEEPDGLPG);

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool AFPHGIBLJIN(ENMPPPDAMHN HMLJKOHAJKN);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class DGKLEELGNCK
{
	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x57D9BD0", Offset = "0x57D81D0", VA = "0x1857D9BD0")]
	public static void DDFNBOCHOND(this JBBANOPACMB OKJDHECIFKP, FCLHKJAHMCN CBIMOLNMMAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x57D9D00", Offset = "0x57D8300", VA = "0x1857D9D00")]
	public static NILFLMGAFIC HGFDBJCIECH(this JBBANOPACMB OKJDHECIFKP, LocalId HMLJKOHAJKN)
	{
		return default(NILFLMGAFIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x57D9CD0", Offset = "0x57D82D0", VA = "0x1857D9CD0")]
	public static ENMPPPDAMHN FBGOFHNIPBN(this JBBANOPACMB OKJDHECIFKP, LocalId HMLJKOHAJKN)
	{
		return default(ENMPPPDAMHN);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x57D9AE0", Offset = "0x57D80E0", VA = "0x1857D9AE0")]
	public static EEKJFDFIEGN CFEAEMLGJDL(this JBBANOPACMB OKJDHECIFKP, LocalId HMLJKOHAJKN)
	{
		return default(EEKJFDFIEGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x57D9980", Offset = "0x57D7F80", VA = "0x1857D9980")]
	public static bool AFPHGIBLJIN(this JBBANOPACMB OKJDHECIFKP, EEKJFDFIEGN HGGMFNJGHIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(RVA = "0x243DD90", Offset = "0x243C390", VA = "0x18243DD90")]
	public static T JIFDAIIHPLK<T>(this JBBANOPACMB OKJDHECIFKP, LocalId HMLJKOHAJKN) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(RVA = "0x57D9E80", Offset = "0x57D8480", VA = "0x1857D9E80")]
	public static AMCLHOADFGH NBAFEIPKJMF(this JBBANOPACMB OKJDHECIFKP, RigidTransform BHECBPBIBGG, [Optional] object DCEGGIJLHGI)
	{
		return default(AMCLHOADFGH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(RVA = "0x57D9D40", Offset = "0x57D8340", VA = "0x1857D9D40")]
	public static LILNNJOPOJO MLOCGPGBCDO(this JBBANOPACMB OKJDHECIFKP, IFEBDPAFELD HFDNEBBJDJC, RigidTransform BHECBPBIBGG, [Optional] object DCEGGIJLHGI)
	{
		return default(LILNNJOPOJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(RVA = "0x57DA310", Offset = "0x57D8910", VA = "0x1857DA310")]
	public static CJNJIJCNICA OALFIIGPCEI(this JBBANOPACMB OKJDHECIFKP, RigidTransform BHECBPBIBGG, [Optional] object DCEGGIJLHGI)
	{
		return default(CJNJIJCNICA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x57D9FC0", Offset = "0x57D85C0", VA = "0x1857D9FC0")]
	private static void NGLGKBMKOCF(NILFLMGAFIC JFBOEHOHHAL, RigidTransform BHECBPBIBGG, [Optional] object DCEGGIJLHGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x57DA450", Offset = "0x57D8A50", VA = "0x1857DA450")]
	internal static BGEIMNEBEIP PMPAMKHKKMH(this JBBANOPACMB OKJDHECIFKP, MGJBCBDODFM DHABLNNJHLM, [Optional] object DCEGGIJLHGI)
	{
		return default(BGEIMNEBEIP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface NDKPGBMKGJL
{
	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JPCDOCMANPG(GameObject FLCGKEKAMCK);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CHPDPJMOKPI(GameObject FLCGKEKAMCK);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object PNIAFFOHCPO(ENMPPPDAMHN HMLJKOHAJKN, GameObject FLCGKEKAMCK, Action<ENMPPPDAMHN, int> AJNAMFOHMMI);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDHCNDBKOJK(GameObject FLCGKEKAMCK, object DJCFFCHMDOH);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
internal static class KEGIHPIDBJA
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x57DF330", Offset = "0x57DD930", VA = "0x1857DF330")]
	public static KGPIAKEFEHB BPIOEGFNGKL(this ENMPPPDAMHN MJBJADACIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x57DF390", Offset = "0x57DD990", VA = "0x1857DF390")]
	public static MOFMKHOGCPA LBFLAKEIFAG(this ENMPPPDAMHN MJBJADACIFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x57DF260", Offset = "0x57DD860", VA = "0x1857DF260")]
	public static EntityManager AKIAGLBKAEL(this ENMPPPDAMHN MJBJADACIFB)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0xF36E00", Offset = "0xF35400", VA = "0x180F36E00")]
	public static T NHHIBJFEODA<T>(this ENMPPPDAMHN MJBJADACIFB) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(RVA = "0xF36D80", Offset = "0xF35380", VA = "0x180F36D80")]
	public static bool MJLGBEGKJBO<T>(this ENMPPPDAMHN MJBJADACIFB) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
internal interface KPIICLIMLAK
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<AMICGDPKLIC> LNFJLNBDNID;
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[KGDFJMDJLCH(AGPDIMMFKMP.LoadInstance)]
public interface LJIKPIOGIDO
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	bool BIOLNBKCPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000433")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000141")]
	ENMPPPDAMHN CCEMFKCELEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000434")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000435")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	NILFLMGAFIC CFNMMJKEMHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000436")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000437")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event MEAOHDLFGLM FABNKKNBIDK;

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(Slot = "7")]
	ENMPPPDAMHN IBFCCLELLKC(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE);

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool JFELDPLAPKL(ENMPPPDAMHN LIGIEJOGFAH, ENMPPPDAMHN LFGKHOBDGNE, out ENMPPPDAMHN EKPEPIHNAIJ);

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DODBKCPPLIM();

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GPOBEAKBFCP();

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool AMPIGGEALCC(ENMPPPDAMHN LIGIEJOGFAH);
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
public delegate void MEAOHDLFGLM(NILFLMGAFIC KCELGCAIFAC, NILFLMGAFIC PBAPJJKENFB);
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class CJLOLHOJFDH
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x57D78F0", Offset = "0x57D5EF0", VA = "0x1857D78F0")]
	public static bool OKOIBBCHEJG(this LJIKPIOGIDO GIPCEGJMFEM, ENMPPPDAMHN LIGIEJOGFAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x57D7D00", Offset = "0x57D6300", VA = "0x1857D7D00")]
	public static bool PAKEPPELFAD(this LJIKPIOGIDO GIPCEGJMFEM, ENMPPPDAMHN LIGIEJOGFAH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
[DefaultMember("Item")]
public interface MLDDOPEDHJJ : IEnumerable<GCPINDOJNBO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000143")]
	int AEJJJIDCFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000144")]
	GCPINDOJNBO ENKOABNAAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GCPINDOJNBO EGCDMNKOBNB(CNGBAJDBKGM EFINPLKEDMK);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BENLOGNDJHK INBAPLHOGPD(CNGBAJDBKGM EFINPLKEDMK);
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public static class FKGFAFLAENC
{
	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(RVA = "0x1C65AF0", Offset = "0x1C640F0", VA = "0x181C65AF0")]
	public static GBHPCKEHPBF<T> EGCDMNKOBNB<T>(this MLDDOPEDHJJ EGDOOPNCMJB, CNGBAJDBKGM ECMAPGHKHFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x1C65C10", Offset = "0x1C64210", VA = "0x181C65C10")]
	public static GBHPCKEHPBF<T> EGCDMNKOBNB<T>(this MLDDOPEDHJJ EGDOOPNCMJB, GOHNKJBJJHB<T> ECMAPGHKHFB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x1C65D60", Offset = "0x1C64360", VA = "0x181C65D60")]
	public static BENLOGNDJHK INBAPLHOGPD<T>(this MLDDOPEDHJJ EGDOOPNCMJB, GOHNKJBJJHB<T> ECMAPGHKHFB) where T : struct
	{
		return default(BENLOGNDJHK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface NAKDAPLIPPO : EMLPEGCKBCF
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	OMLPFNCGEAG EEMILIIDFAP(Entity MPAGCMNFGMI);

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILLOLDNCJCI(NativeArray<OMLPFNCGEAG> ELGFKJEBGOH, NativeArray<JOBAKIHHCFN> IKBGILGFONL);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JJPHNPMMNOB(OMLPFNCGEAG FCDGNCOICKN);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PJLLCBFGNBF(OMLPFNCGEAG FCDGNCOICKN, out Collider HCHCJABNKJO);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct JOBAKIHHCFN : ISystemStateComponentData, IComponentData, IEquatable<JOBAKIHHCFN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float3 EJJFJIGGILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float3 GGEFKIILAKB;

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x57DE720", Offset = "0x57DCD20", VA = "0x1857DE720", Slot = "4")]
	public bool Equals(JOBAKIHHCFN FKJGPCABBJN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct OPAIBEOPLMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Guid NAMBIBPENHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public string ICNEJAGANPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 POOFJFBIOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Quaternion MEHKCJCIOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3 CHAPNJAEPMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int CLKAGMKKFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Dictionary<string, object> FKGPFMNALNI;

	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x57E20B0", Offset = "0x57E06B0", VA = "0x1857E20B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x57E1F20", Offset = "0x57E0520", VA = "0x1857E1F20")]
	private static string KPBHBEAFJGN(Dictionary<string, object> GOGEJEOAIDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum IEENJOCNCOI
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum PMHKIJNLDHD
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public static class GCJGEJAIAFA
{
	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x43A5B50", Offset = "0x43A4150", VA = "0x1843A5B50")]
	public static bool ONDEOMAMIHE(this PMHKIJNLDHD KLGGKKGCLHM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public interface GGFHOFNANBO : KOMGFJFAEGJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum JAPFELDAJFH
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	NotifyEnabledState = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	NotifyInstantiated = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	DisposeProtobuf = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	NotifyCompleted = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesMaster = 0xFF,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	WorldPhasesClient = 0xF7,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	AdditivePhases = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum LGMJIIMDKIM
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SetEnabledInRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	PostInstantiate = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	LoadCompleted = 0xC0,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	All = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface CINHJBLABIP : KOMGFJFAEGJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000145")]
	HKACBKPJJFC ENBLGLBONNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void IHAIHLFLKNG();

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BAKJOFHIMJK();
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface HKACBKPJJFC
{
	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JCDBBBKKFPF(Guid POIAHNIMHKJ, out Guid GGCKOLILJHC);
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface CBENEIMMAGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	HCJLJOEKAAD JMDIAKJHCHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString AEMGEGAIHLP();
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface KOMGFJFAEGJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	IEnumerable<OPAIBEOPLMG> HPFHIJJMHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600045B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000148")]
	FBGEKGCCCOL LACFGCFKPAA
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	LocalId BKKGIPGEKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600045D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	HCJLJOEKAAD HBOMINEIGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	Task KKANOEEBMCK
	{
		[Cpp2IlInjected.Token(Token = "0x600045F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DMAOLGACNOI(JAPFELDAJFH JHBJAKHPFJI);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface CJMDCNKCPPO
{
	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GDKCFJKPHMK(int MPGHGDABPMN);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface IBFLLPBIJGL
{
	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	IEnumerable<ICJILNNOMND> NACLIPNCEDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000462")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool COEBIMJMEEK(int MPGHGDABPMN, out ICJILNNOMND AACPPJHALGJ);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface ICPMKLFEEFO
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	List<(FIFLCEFEDEL nameHash, IMMBALAGBFO stableTypeHash, Type type)> FGDOCPHEONL
	{
		[Cpp2IlInjected.Token(Token = "0x6000464")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[KGDFJMDJLCH(AGPDIMMFKMP.Application)]
public interface BJPLNLDMPDD
{
	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "0")]
	FIFLCEFEDEL CBCDBDGKDMI(int MPGHGDABPMN);

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JDHPHGKFOBE(FIFLCEFEDEL OJKNCEMGHDD);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface LBGAFCFPELD
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void COLODAOAIFG(EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK FPNKFNICEDM, ReadOnlySpan<byte> LAMLBOAEFIH, ReadOnlySpan<byte> LCPMGAFAGOE);

	[Cpp2IlInjected.Token(Token = "0x6000468")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FABMINKMEIG(EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK FPNKFNICEDM);

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MHFJOCHGDDJ(EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK FPNKFNICEDM, ReadOnlySpan<byte> LCPMGAFAGOE);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PNCBNFNHNKO(EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK FPNKFNICEDM, Span<byte> LAMLBOAEFIH, Span<byte> LCPMGAFAGOE);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public static class GKFCMFODJDC
{
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x2B406D0", Offset = "0x2B3ECD0", VA = "0x182B406D0")]
	public static bool PNCBNFNHNKO<T>(this LBGAFCFPELD JHHKJBKBPMN, EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK FPNKFNICEDM, out T LAMLBOAEFIH, out T LCPMGAFAGOE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x2B405B0", Offset = "0x2B3EBB0", VA = "0x182B405B0")]
	public static bool MHFJOCHGDDJ<T>(this LBGAFCFPELD JHHKJBKBPMN, EEKJFDFIEGN OOIPPLLNGHO, BENLOGNDJHK FPNKFNICEDM, T LCPMGAFAGOE) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public enum OFFCKDHJCOG
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface BMBAAOGODDL : APKICOJHDCH<BMBAAOGODDL>
{
	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BBDOIOJLDPI(BENLOGNDJHK MJBJADACIFB, out LBNIDADIEHM AACPPJHALGJ);
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
public static class HJNJOPMDALE
{
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface DKKKGDEMMBH
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	uint DLHHKECKODH
	{
		[Cpp2IlInjected.Token(Token = "0x600046E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
public struct NPIDHFKGFCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public MODKFNDEKMI PAKFOBAPADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public ReadOnlyMemory<byte> GFHGIIOIPBN;
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface EMPFOOIHLNI
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LHCKIAAHGJM(MODKFNDEKMI PAKFOBAPADB, ReadOnlySpan<byte> GFHGIIOIPBN);
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate bool OLAJAOBOEEF(LBGAFCFPELD LLFJDOLINHG, in NGKHEJGAHGD MOLEJFDINLH);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public delegate bool LDEOGMHCOMG<T>(LBGAFCFPELD LLFJDOLINHG, in T MOLEJFDINLH);
[Cpp2IlInjected.Token(Token = "0x20000B0")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface ECGBJBIHLPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MBACIJOLGCB(BENLOGNDJHK FPNKFNICEDM, Type JIKFCOCEENM, OLAJAOBOEEF EGAHPGKBOPF);

	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MBHAHKJEGMG(BENLOGNDJHK FPNKFNICEDM, out OLAJAOBOEEF EGAHPGKBOPF);
}
[Cpp2IlInjected.Token(Token = "0x20000B1")]
public static class GGKGBOKCJBE
{
	[Cpp2IlInjected.Token(Token = "0x20000B2")]
	[CompilerGenerated]
	private sealed class NDBGCPDGHLC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public LDEOGMHCOMG<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600047C")]
		[Cpp2IlInjected.Address(RVA = "0x8FCE30", Offset = "0x8FB430", VA = "0x1808FCE30")]
		public NDBGCPDGHLC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600047D")]
		[Cpp2IlInjected.Address(RVA = "0x277EE10", Offset = "0x277D410", VA = "0x18277EE10")]
		internal bool NEOBNJDBNNN(LBGAFCFPELD pendingList, in NGKHEJGAHGD value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x2B32F40", Offset = "0x2B31540", VA = "0x182B32F40")]
	public static void MBACIJOLGCB<T>(this ECGBJBIHLPJ GEDHMEAEIPA, BENLOGNDJHK FPNKFNICEDM, LDEOGMHCOMG<T> EGAHPGKBOPF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x57DCF10", Offset = "0x57DB510", VA = "0x1857DCF10")]
	public static bool POMDGOIIIGF(this ECGBJBIHLPJ GEDHMEAEIPA, LBGAFCFPELD LLFJDOLINHG, BENLOGNDJHK FPNKFNICEDM, in NGKHEJGAHGD MOLEJFDINLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
public struct MODKFNDEKMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public uint OHACKIIBLPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int DDEFJFDDKAN;

	[Cpp2IlInjected.Token(Token = "0x600047E")]
	[Cpp2IlInjected.Address(RVA = "0xA54600", Offset = "0xA52C00", VA = "0x180A54600")]
	public MODKFNDEKMI(uint OHACKIIBLPM, int DDEFJFDDKAN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(RVA = "0x57E0510", Offset = "0x57DEB10", VA = "0x1857E0510")]
	public static bool BDIEMMGDBNG(in MODKFNDEKMI MBOGNALMNPH, in MODKFNDEKMI NDCLMFPKHPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(RVA = "0x57E0530", Offset = "0x57DEB30", VA = "0x1857E0530", Slot = "0")]
	public override bool Equals(object NKFOPKJGBEM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(RVA = "0x57E05C0", Offset = "0x57DEBC0", VA = "0x1857E05C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x57E05F0", Offset = "0x57DEBF0", VA = "0x1857E05F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface BEGFKAEHLFO
{
	[Cpp2IlInjected.Token(Token = "0x6000483")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MODKFNDEKMI NJEHPEEEGDG(ReadOnlySpan<byte> GFHGIIOIPBN);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public interface LBNIDADIEHM
{
	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	Type APKDCCGFPPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000484")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000485")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LKBINHHANLF(ref FDAMBOMMBJG DOHACEMIKEI, Span<byte> LIGIEJOGFAH);

	[Cpp2IlInjected.Token(Token = "0x6000486")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HLDMGFBCHDH(ref CLDGGBNDBPF OCIIOHGMEPE, ReadOnlySpan<byte> PAKFOBAPADB);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public static class NNMIHHKOBNI
{
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[KGDFJMDJLCH(AGPDIMMFKMP.OMRoom)]
public interface PKBDPKKLKNE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000487")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MKKGBPNKABP(MODKFNDEKMI BOMEFJIOGGM, ReadOnlySpan<byte> GFHGIIOIPBN);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class JCIBJNJLFPG
{
	[Cpp2IlInjected.Token(Token = "0x6000488")]
	[Cpp2IlInjected.Address(RVA = "0x7ED610", Offset = "0x7EBC10", VA = "0x1807ED610")]
	public JCIBJNJLFPG()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000B9")]
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
