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
using RecRoom.Components;
using RecRoom.ObjectModel;
using Unity.Collections;
using Unity.Entities;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface PNDAGNLAKFB
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IAAEONHBIOI(in float3 DNACOLDEFIO, in float3 EPJPJGLJENE, float NCEKMHDDCCP, Allocator NAFCEIMFOBK, out NativeArray<Entity> JEBIOEILLHO);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface CNKPHFGOANA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Guid HFJGHCBIAJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KAGDBOFPJIN(Guid LPBLLFMGEOH, Guid BNMMODNKPMJ);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BHLCIOMGONI(IMDEFFNCIAA HEJENJMJCMI);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface FKGHEBGADOE : global::HLBOCHKIFEM<IMDEFFNCIAA>, LCNLFHMFGHB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OGDHIPMPCDN<T> : global::BPHMCLOOBEH<IMDEFFNCIAA, T>, global::HLBOCHKIFEM<IMDEFFNCIAA>, LCNLFHMFGHB, IDisposable, FKGHEBGADOE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OEGDKIGIDOL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x327CDC0", Offset = "0x327C1C0", VA = "0x18327CDC0")]
	public static T LLPKLFBKNII<T>(this global::HLBOCHKIFEM<IMDEFFNCIAA> MMNEFCOHNGA, IMDEFFNCIAA IEFFONDNDLL) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x327CD90", Offset = "0x327C190", VA = "0x18327CD90")]
	public static bool BCHEBCENJDG<T>(this global::HLBOCHKIFEM<IMDEFFNCIAA> MMNEFCOHNGA, IMDEFFNCIAA IEFFONDNDLL, in T IGHGGFJEGCJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface KAEPMDHNIJA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<EDLMNAHJFMA> MAOHGNMMKKA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<IMDEFFNCIAA, IMDEFFNCIAA> JHKAOMPHLIK;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<IMDEFFNCIAA, IMDEFFNCIAA> BLLKHPCMHND;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<IMDEFFNCIAA, IMDEFFNCIAA, IMDEFFNCIAA> MBEEFALNEPI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<IMDEFFNCIAA> APJHIDNJIBE;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color LPIGKLELLMG(IMDEFFNCIAA IEFFONDNDLL, int BOAJOIHKLAC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 AKPDCDBBDDD(IMDEFFNCIAA IEFFONDNDLL, int BOAJOIHKLAC);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NCPCIGDLAFE(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA DEHLNLEIKLF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	IMDEFFNCIAA FOFLBLLHJBB(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<IMDEFFNCIAA> JKCKMJAKKDI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	IMDEFFNCIAA LDHCCIKIIMA(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void ODBPKONPPEL(IMDEFFNCIAA IEFFONDNDLL, Vector3 BHFGAAEFEDM, Quaternion NHPEPNKJKHH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NKMMBMENLKG(IMDEFFNCIAA IEFFONDNDLL, float EGIJLHPLPIF);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool IEMLOGBABCA(IMDEFFNCIAA IEFFONDNDLL, out RigidTransform EKJGJNAIHDD);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool OEBALGMLDOO(IMDEFFNCIAA IEFFONDNDLL, out float AJFKNMMEMLJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 FKMLNOHIBEA(DAICGNOLHEL JIILEJCCOGG);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion CENAPGJANGK(DAICGNOLHEL JIILEJCCOGG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KJJICMJIDDG
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface AEAPJJBDJIP
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAAEONHBIOI(in NativeArray<Entity> JEBIOEILLHO, in float3 DNACOLDEFIO, in float3 EPJPJGLJENE, in NativeArray<FNMOJKCEPNM> JAPPAEFNEDK);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface IAJAHFHHDCD
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOAEFKKEGEF(IMDEFFNCIAA DPIBKMGPGEE, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICLMBMOHHNG(IMDEFFNCIAA DPIBKMGPGEE, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMGGCANCOBP(IMDEFFNCIAA DPIBKMGPGEE, int EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
[DefaultMember("Item")]
public interface AMIIDNLIHMO : IEnumerable<BHEOFHMFIKM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NativeBitArray EMNPDMOOIIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeArray<int> KOBHNIBFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	BHEOFHMFIKM KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BHEOFHMFIKM KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BHEOFHMFIKM ACEIDCHGHEK(GPHNDJBMNHN CDJGAGCIMIF);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CDCHAKEJFEI HLDEFGJINDN(GPHNDJBMNHN CDJGAGCIMIF);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class LKDFEFKFDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public static global::DGDDKHEFDLH<T> ACEIDCHGHEK<T>(this AMIIDNLIHMO PGJHKOKFEAD, GPHNDJBMNHN LMAOKJPAKEM) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct GKGBNBECAKC : IEquatable<GKGBNBECAKC>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GKGBNBECAKC GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public GKGBNBECAKC(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E65BD0", Offset = "0x5E64FD0", VA = "0x185E65BD0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(GKGBNBECAKC CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct AGFGBDPFGFB : IEquatable<AGFGBDPFGFB>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly AGFGBDPFGFB GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CE80", Offset = "0x5E5C280", VA = "0x185E5CE80", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(AGFGBDPFGFB CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface ADEJBOOFMFO
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	OPJGBNIJFAB BCFBJHJCJMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LGADODIMHHI(EGAFANECNIE JOJAINIHPBN, CDCHAKEJFEI MMNEFCOHNGA);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JAKHHHEHLLF(EGAFANECNIE JOJAINIHPBN, Span<CDCHAKEJFEI> PGJHKOKFEAD, bool NHOOKFNNBJH);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HIHOJIJNKHB(NativeArray<EGAFANECNIE> CDDGAAGPGLA);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct OPJGBNIJFAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NativeBitArray KMHMBMBLGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NativeHashMap<EGAFANECNIE, int> GNBFECALPPJ;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool BHHODJDPJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6DDE0", Offset = "0x5E6D1E0", VA = "0x185E6DDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x83CCA0", Offset = "0x83C0A0", VA = "0x18083CCA0")]
	public OPJGBNIJFAB(NativeBitArray KMHMBMBLGNA, NativeHashMap<EGAFANECNIE, int> GNBFECALPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DE00", Offset = "0x5E6D200", VA = "0x185E6DE00")]
	public bool LGADODIMHHI(EGAFANECNIE JOJAINIHPBN, CDCHAKEJFEI MMNEFCOHNGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class GCMHEPPPCNF
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct MLKCCEGIBBL : JIBMGDNEHGM, IEquatable<MLKCCEGIBBL>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly MLKCCEGIBBL GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject NJMBJKHNCBN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BA70", Offset = "0x5E6AE70", VA = "0x185E6BA70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public EGAFANECNIE OADDMMAKFNE
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BB70", Offset = "0x5E6AF70", VA = "0x185E6BB70")]
		get
		{
			return default(EGAFANECNIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ObjectType GFKDBMPHMPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C010", Offset = "0x5E6B410", VA = "0x185E6C010")]
		get
		{
			return default(ObjectType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ObjectPrefabType LCBEKPPJKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C1D0", Offset = "0x5E6B5D0", VA = "0x185E6C1D0")]
		get
		{
			return default(ObjectPrefabType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LOPMICCFAGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BC40", Offset = "0x5E6B040", VA = "0x185E6BC40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool PJNCDNKDBCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BE60", Offset = "0x5E6B260", VA = "0x185E6BE60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool AMCEMCLHBOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BE80", Offset = "0x5E6B280", VA = "0x185E6BE80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool EGAMHIICCPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C190", Offset = "0x5E6B590", VA = "0x185E6C190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool CPNONHAJNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C5A0", Offset = "0x5E6B9A0", VA = "0x185E6C5A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DOOLIAICDLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C1B0", Offset = "0x5E6B5B0", VA = "0x185E6C1B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool DJBAJAEJFFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BFC0", Offset = "0x5E6B3C0", VA = "0x185E6BFC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool JNFFKGMOPDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C580", Offset = "0x5E6B980", VA = "0x185E6C580")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public DFCAMNBDDHF NPCMAFKMMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(DFCAMNBDDHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PKKKDPOMDID OLDKDMMFADN
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(PKKKDPOMDID);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public HEBLJAAECEP OHKKCIMNHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(HEBLJAAECEP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public OIALLDGOKDH BGMJHEFGGNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(OIALLDGOKDH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public EBPMNNHKLBO NFJCACLBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(EBPMNNHKLBO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public JBNFHPJKMCE NLKLJIBOMLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(JBNFHPJKMCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LBAKMDPCEPN GFOOKDGCHGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(LBAKMDPCEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool DPOLEJEBKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5E6C2A0", Offset = "0x5E6B6A0", VA = "0x185E6C2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool KNGNNBKPLEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5E6BA20", Offset = "0x5E6AE20", VA = "0x185E6BA20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool AONOKEICDLI
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930", Slot = "5")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FALPHDCACCD LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(FALPHDCACCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public CDFEABOOLLO ENBFKHIFKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(CDFEABOOLLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
	public static MLKCCEGIBBL ILINJACDGKH(IMDEFFNCIAA DPIBKMGPGEE)
	{
		return default(MLKCCEGIBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BCD0", Offset = "0x5E6B0D0", VA = "0x185E6BCD0")]
	public FIDOKBMDCIB EIIDDFBLAKJ()
	{
		return default(FIDOKBMDCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BC60", Offset = "0x5E6B060", VA = "0x185E6BC60")]
	public JOKAONOMLCB ECHACPIDIEI()
	{
		return default(JOKAONOMLCB);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BEA0", Offset = "0x5E6B2A0", VA = "0x185E6BEA0")]
	public GKGBNBECAKC FMCBAJIKDBF()
	{
		return default(GKGBNBECAKC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B8D0", Offset = "0x5E6ACD0", VA = "0x185E6B8D0")]
	public IDKEPNNBCPI AMJONELDHCK()
	{
		return default(IDKEPNNBCPI);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C4F0", Offset = "0x5E6B8F0", VA = "0x185E6C4F0")]
	public DAICGNOLHEL MIDGECFKPLD()
	{
		return default(DAICGNOLHEL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C370", Offset = "0x5E6B770", VA = "0x185E6C370")]
	public void LLNJIBPCBHK([Optional] object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C0E0", Offset = "0x5E6B4E0", VA = "0x185E6C0E0")]
	public bool HKDFNCGFAEI(object IJNLJGNNJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BF10", Offset = "0x5E6B310", VA = "0x185E6BF10")]
	public bool FMHPNKKCIBG(object IJNLJGNNJFA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C5C0", Offset = "0x5E6B9C0", VA = "0x185E6C5C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public MLKCCEGIBBL(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E60880", Offset = "0x5E5FC80", VA = "0x185E60880")]
	public static bool ILINJACDGKH(MLKCCEGIBBL EOEKGHMNIDN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
	public static IMDEFFNCIAA ILINJACDGKH(MLKCCEGIBBL EOEKGHMNIDN)
	{
		return default(IMDEFFNCIAA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C450", Offset = "0x5E6B850", VA = "0x185E6C450")]
	public static bool MHCPIEGNOBB(MLKCCEGIBBL ELMEJGEELII, MLKCCEGIBBL EOKEPOJIFJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B940", Offset = "0x5E6AD40", VA = "0x185E6B940")]
	public static bool BDKIFGPLPMB(MLKCCEGIBBL ELMEJGEELII, MLKCCEGIBBL EOKEPOJIFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5E6BD60", Offset = "0x5E6B160", VA = "0x185E6BD60", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "6")]
	public bool Equals(MLKCCEGIBBL CCJMBGJFGLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void CDINJNIEIFH(IMDEFFNCIAA IEFFONDNDLL, CDCHAKEJFEI GAEHKOIHPJO, GGCEFKOAKOD CBANDKAJFBB, GGCEFKOAKOD MJGOBCMBBIL);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct CBKPJLDDHGP : IList<IMDEFFNCIAA>, ICollection<IMDEFFNCIAA>, IEnumerable<IMDEFFNCIAA>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct POJEJMJMNPJ : IEnumerator<IMDEFFNCIAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly KCNJCALDJDJ BJFNPHMFGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator CJENBGBEBMN;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public IMDEFFNCIAA HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E6E0", Offset = "0x5E6DAE0", VA = "0x185E6E6E0", Slot = "4")]
			get
			{
				return default(IMDEFFNCIAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E6E600", Offset = "0x5E6DA00", VA = "0x185E6E600", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2824180", Offset = "0x2823580", VA = "0x182824180")]
		public POJEJMJMNPJ(KCNJCALDJDJ BJFNPHMFGCG, NativeArray<LocalId>.Enumerator CJENBGBEBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E540", Offset = "0x5E6D940", VA = "0x185E6E540", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E580", Offset = "0x5E6D980", VA = "0x185E6E580", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E6E5C0", Offset = "0x5E6D9C0", VA = "0x185E6E5C0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly KCNJCALDJDJ BJFNPHMFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> JFCLEPECFNA;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public IMDEFFNCIAA KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E0F0", Offset = "0x5E5D4F0", VA = "0x185E5E0F0", Slot = "4")]
		get
		{
			return default(IMDEFFNCIAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E170", Offset = "0x5E5D570", VA = "0x185E5E170", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DB70", Offset = "0x5E5CF70", VA = "0x185E5DB70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int EAGEACLGNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E5DB70", Offset = "0x5E5CF70", VA = "0x185E5DB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool MNGNEMEDFBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7FB3B0", Offset = "0x7FA7B0", VA = "0x1807FB3B0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E060", Offset = "0x5E5D460", VA = "0x185E5E060")]
	public CBKPJLDDHGP(KCNJCALDJDJ BJFNPHMFGCG, int JNPIFHIHMEO, Allocator NAFCEIMFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DC90", Offset = "0x5E5D090", VA = "0x185E5DC90")]
	public AKEJCMHMCDK KFOHDHLCPGD()
	{
		return default(AKEJCMHMCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D8C0", Offset = "0x5E5CCC0", VA = "0x185E5D8C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D900", Offset = "0x5E5CD00", VA = "0x185E5D900", Slot = "13")]
	public bool Contains(IMDEFFNCIAA NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D960", Offset = "0x5E5CD60", VA = "0x185E5D960", Slot = "14")]
	public void CopyTo(IMDEFFNCIAA[] BIBDBFOMNHM, int JMKONIJDHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D860", Offset = "0x5E5CC60", VA = "0x185E5D860", Slot = "11")]
	public void Add(IMDEFFNCIAA NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DC10", Offset = "0x5E5D010", VA = "0x185E5DC10", Slot = "7")]
	public void Insert(int CJOLACIBAJH, IMDEFFNCIAA NFFDNBMMLPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DDF0", Offset = "0x5E5D1F0", VA = "0x185E5DDF0", Slot = "15")]
	public bool Remove(IMDEFFNCIAA NFFDNBMMLPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DBB0", Offset = "0x5E5CFB0", VA = "0x185E5DBB0", Slot = "6")]
	public int IndexOf(IMDEFFNCIAA NFFDNBMMLPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DDA0", Offset = "0x5E5D1A0", VA = "0x185E5DDA0", Slot = "8")]
	public void RemoveAt(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DB30", Offset = "0x5E5CF30", VA = "0x185E5DB30", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DD10", Offset = "0x5E5D110", VA = "0x185E5DD10")]
	public POJEJMJMNPJ KLBJEDHKGHJ()
	{
		return default(POJEJMJMNPJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DE80", Offset = "0x5E5D280", VA = "0x185E5DE80", Slot = "16")]
	private IEnumerator<IMDEFFNCIAA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E5DF70", Offset = "0x5E5D370", VA = "0x185E5DF70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface BLHEHILJEDH
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool IAAEONHBIOI(in float3 DNACOLDEFIO, in float3 EPJPJGLJENE, float NCEKMHDDCCP, out FNMOJKCEPNM JBIMIGALMMN, out IMDEFFNCIAA PHKOKKKOGKG);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct GNGFCOEBOLO : IEquatable<GNGFCOEBOLO>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly GNGFCOEBOLO GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private MGHGCOLAIMC LPLJGGENDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E66110", Offset = "0x5E65510", VA = "0x185E66110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public JOKAONOMLCB LFDILJDLKED
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(JOKAONOMLCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public MCGAOALDPDP GKLLNPMNKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E66280", Offset = "0x5E65680", VA = "0x185E66280")]
		get
		{
			return default(MCGAOALDPDP);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E66010", Offset = "0x5E65410", VA = "0x185E66010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<LKFMCPIAAHE> DBGECFFIADA
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E665A0", Offset = "0x5E659A0", VA = "0x185E665A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public LKFMCPIAAHE KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E65D10", Offset = "0x5E65110", VA = "0x185E65D10")]
		get
		{
			return default(LKFMCPIAAHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E66AA0", Offset = "0x5E65EA0", VA = "0x185E66AA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FALPHDCACCD LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(FALPHDCACCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E66780", Offset = "0x5E65B80", VA = "0x185E66780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E66380", Offset = "0x5E65780", VA = "0x185E66380")]
	public LKFMCPIAAHE JOEBNIIAIJF(float3? FLBOBIODIJO, [Optional] quaternion? FKJONOBDEOA, [Optional] Vector3? LECHMDFLPHK)
	{
		return default(LKFMCPIAAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E66870", Offset = "0x5E65C70", VA = "0x185E66870")]
	public LKFMCPIAAHE MLKBPMBFAHE(int CJOLACIBAJH, float3? FLBOBIODIJO, [Optional] quaternion? FKJONOBDEOA, [Optional] Vector3? LECHMDFLPHK)
	{
		return default(LKFMCPIAAHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5E66190", Offset = "0x5E65590", VA = "0x185E66190")]
	public void GFKHMCIOCHP(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E65E30", Offset = "0x5E65230", VA = "0x185E65E30")]
	public void DDMMLHIFNLF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public GNGFCOEBOLO(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E60880", Offset = "0x5E5FC80", VA = "0x185E60880")]
	public static bool ILINJACDGKH(GNGFCOEBOLO EOEKGHMNIDN)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E667D0", Offset = "0x5E65BD0", VA = "0x185E667D0")]
	public static bool MHCPIEGNOBB(GNGFCOEBOLO ELMEJGEELII, GNGFCOEBOLO EOKEPOJIFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E65F10", Offset = "0x5E65310", VA = "0x185E65F10", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(GNGFCOEBOLO CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface EPPKDMGALCH
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEIIILJFFNM(IMDEFFNCIAA IEFFONDNDLL, out Collider COMGKHGIKLH);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject NPPMKDANGKD(IMDEFFNCIAA HIDFDPFMKGH, GameObject BLJDINJOMCN, Vector3 NADLKJKLONK, Quaternion OGPILFJIIKI);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHPPPIILHMK(GameObject COMGKHGIKLH);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider GCBBGBLOAJE<TCollider>(GameObject LAKPNPIGFKL) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJKLLIEIMIG(Collider COMGKHGIKLH);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject ELGOKNNAEJG<TCollider>(string LMAOKJPAKEM) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface IKNIHGGOHHI : global::HLBOCHKIFEM<EGAFANECNIE>, LCNLFHMFGHB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NNBPJAGAMEP<T> : global::BPHMCLOOBEH<EGAFANECNIE, T>, global::HLBOCHKIFEM<EGAFANECNIE>, LCNLFHMFGHB, IDisposable, IKNIHGGOHHI where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class POCMBIMKKKF
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x24DF9D0", Offset = "0x24DEDD0", VA = "0x1824DF9D0")]
	public static bool EPJAPKGCCDE<T>(this global::HLBOCHKIFEM<EGAFANECNIE> MMNEFCOHNGA, EGAFANECNIE JOJAINIHPBN, out T EOEKGHMNIDN) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x24DF9C0", Offset = "0x24DEDC0", VA = "0x1824DF9C0")]
	public static bool BCHEBCENJDG<T>(this global::HLBOCHKIFEM<EGAFANECNIE> MMNEFCOHNGA, EGAFANECNIE JOJAINIHPBN, in T IGHGGFJEGCJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct LBAKMDPCEPN : IEquatable<LBAKMDPCEPN>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly LBAKMDPCEPN GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private CACOFJOFNOF EMJFDENEHKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A6B0", Offset = "0x5E69AB0", VA = "0x185E6A6B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool CAHPBPNLIED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A200", Offset = "0x5E69600", VA = "0x185E6A200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid BIIGCAMPPFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A3E0", Offset = "0x5E697E0", VA = "0x185E6A3E0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool LIDACBKLHBC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A950", Offset = "0x5E69D50", VA = "0x185E6A950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid DHOAFNEEAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AB20", Offset = "0x5E69F20", VA = "0x185E6AB20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6A900", Offset = "0x5E69D00", VA = "0x185E6A900")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A4D0", Offset = "0x5E698D0", VA = "0x185E6A4D0")]
	public bool IJGNJFECGDC(out Guid KCFOMBLHMHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A5C0", Offset = "0x5E699C0", VA = "0x185E6A5C0")]
	public void JHOEBBJEFKO(Guid NLNMFNDNKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A730", Offset = "0x5E69B30", VA = "0x185E6A730")]
	public bool KJDOGJMICFC(out Guid APJCGFNBKKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AA30", Offset = "0x5E69E30", VA = "0x185E6AA30")]
	public void OMLOECHMPOI(Guid NLNMFNDNKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A820", Offset = "0x5E69C20", VA = "0x185E6A820")]
	public void KPAGHMDLAOK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public LBAKMDPCEPN(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A2E0", Offset = "0x5E696E0", VA = "0x185E6A2E0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(LBAKMDPCEPN CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct PKKKDPOMDID : IEquatable<PKKKDPOMDID>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly PKKKDPOMDID GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E070", Offset = "0x5E6D470", VA = "0x185E6E070")]
	public void BEBNHAAGHMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E240", Offset = "0x5E6D640", VA = "0x185E6E240")]
	public void IPBBPFINOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public PKKKDPOMDID(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E140", Offset = "0x5E6D540", VA = "0x185E6E140", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(PKKKDPOMDID CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface HNAAHBOEIIB : JIBMGDNEHGM
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	NGKKPEFBBLJ OMJPHAMIADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool IBONEHPEBMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GameObject NJMBJKHNCBN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<HNAAHBOEIIB> DJBLPBMEFEF;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(EODEEDFMDKF MKIMPHJOKAN, IMDEFFNCIAA CDADFGJGIEG);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool JDICMMNLKDG);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class OFAKBJDAPGP
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CAB0", Offset = "0x5E6BEB0", VA = "0x185E6CAB0")]
	public static bool DPOLEJEBKLG(this HNAAHBOEIIB IOFJBEELAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB00", Offset = "0x5E6BF00", VA = "0x185E6CB00")]
	public static bool GIKACIGEEOP(this HNAAHBOEIIB IOFJBEELAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CA60", Offset = "0x5E6BE60", VA = "0x185E6CA60")]
	public static bool CFJILJGDGFM(this HNAAHBOEIIB IOFJBEELAIO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CB50", Offset = "0x5E6BF50", VA = "0x185E6CB50")]
	public static bool LBFDKGPBIJO(this HNAAHBOEIIB IOFJBEELAIO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct JCLBPOFJNJF : IEquatable<JCLBPOFJNJF>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly JCLBPOFJNJF GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E69070", Offset = "0x5E68470", VA = "0x185E69070", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(JCLBPOFJNJF CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface JGKBLHOAEFC
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIKAMGOGBAH(NativeListAsync<Entity> FFAJIMPLIJL);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JEHILIOPICI(JKMEIIKIOBH INDDMOIACJL);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FENECIOOOMI(NativeListAsync<Entity> NODLNJHKCAO, bool GHBHHICHLDP);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HNMGFKJLFDD();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface OCJCEMNJPPK
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PKLICCAJHAH(IMDEFFNCIAA IEFFONDNDLL, FKDDJKLFJDM EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface AGLEAAAHLFF
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AABMIDHMDLM();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKGACCGLBPM();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LPLEONFCGGP();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OIAHBEEDGFD();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFGAMMMHJOL();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OBDIKGBCJGD();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void EODAGCLMPHE();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AOADKCGLGNK();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPFILIBLINO();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void COKCDKIEPJD();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DENLINEOLJD();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface DOFBAANOHKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int MBJLLAIBIGB
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> AMONBFABHIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IMDEFFNCIAA JGMKBPBLCAC(IMDEFFNCIAA JFCLEPECFNA);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int JGMKBPBLCAC(int BGJODNEIMJH);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface DOLOGHIPOAM : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct OIALLDGOKDH : IEquatable<OIALLDGOKDH>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly OIALLDGOKDH GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private IMHPMCEODDG EHMIFGGCCFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D130", Offset = "0x5E6C530", VA = "0x185E6D130")]
		get
		{
			return default(IMHPMCEODDG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool GAALHMHKOHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D3D0", Offset = "0x5E6C7D0", VA = "0x185E6D3D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool ALOHGFCKNJE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D2F0", Offset = "0x5E6C6F0", VA = "0x185E6D2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool AFLPIPHEKNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D280", Offset = "0x5E6C680", VA = "0x185E6D280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool MNEMHHCCDDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D360", Offset = "0x5E6C760", VA = "0x185E6D360")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EAIEBBADLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CD50", Offset = "0x5E6C150", VA = "0x185E6CD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool NFONPHEIHFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CCE0", Offset = "0x5E6C0E0", VA = "0x185E6CCE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool FOLHEMFNIMK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D800", Offset = "0x5E6CC00", VA = "0x185E6D800")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool CGMFMMHKGNP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D210", Offset = "0x5E6C610", VA = "0x185E6D210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool GJFLLBHIJFB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D6B0", Offset = "0x5E6CAB0", VA = "0x185E6D6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool CPEPAJOBENL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CC60", Offset = "0x5E6C060", VA = "0x185E6CC60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool OCFBHEFFOJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D440", Offset = "0x5E6C840", VA = "0x185E6D440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool EFPPOGCHMBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CBF0", Offset = "0x5E6BFF0", VA = "0x185E6CBF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool CFJMEEGGLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D640", Offset = "0x5E6CA40", VA = "0x185E6D640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool IFEBAMIJAHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D7F0", Offset = "0x5E6CBF0", VA = "0x185E6D7F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool DFHHGLPOJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D500", Offset = "0x5E6C900", VA = "0x185E6D500")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CCD0", Offset = "0x5E6C0D0", VA = "0x185E6CCD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool GKLNLPFCMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D5D0", Offset = "0x5E6C9D0", VA = "0x185E6D5D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 KHMAKOKGBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CDC0", Offset = "0x5E6C1C0", VA = "0x185E6CDC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 MOAGEIOKODN
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D510", Offset = "0x5E6C910", VA = "0x185E6D510")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool LOICEDBPJNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5E6CF90", Offset = "0x5E6C390", VA = "0x185E6CF90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5E6D4B0", Offset = "0x5E6C8B0", VA = "0x185E6D4B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D190", Offset = "0x5E6C590", VA = "0x185E6D190")]
	public bool JJKJJPMDIBJ(MEJEKEKNPEC GOKAGNCECMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D720", Offset = "0x5E6CB20", VA = "0x185E6D720")]
	public bool OKNHLJKEKGH(ObjectPolicyUserConfigurableFlags GOKAGNCECMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D0B0", Offset = "0x5E6C4B0", VA = "0x185E6D0B0")]
	public void HOFEGIEOHEP(ObjectPolicyUserConfigurableFlags GOKAGNCECMF, bool NPOJGAHFNKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public OIALLDGOKDH(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CE90", Offset = "0x5E6C290", VA = "0x185E6CE90", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(OIALLDGOKDH CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface EODEEDFMDKF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	KAHNJLHAPKM GGAMEKGGKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	MOPOAILGOFG IHOEDBBHPPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EntityManager CPFDJDFIGMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool LBFDKGPBIJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase PHPCFOFJBNK(Type ONBHBHIHHNE);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class CDBBMFBAHOI
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E1D0", Offset = "0x5E5D5D0", VA = "0x185E5E1D0")]
	public static World HBADIOEJPHA(this EODEEDFMDKF ONDCLJKBPOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x25870A0", Offset = "0x25864A0", VA = "0x1825870A0")]
	public static T PHPCFOFJBNK<T>(this EODEEDFMDKF ONDCLJKBPOJ) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct CDFEABOOLLO : IEquatable<CDFEABOOLLO>
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly CDFEABOOLLO GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private IAHGCMLPFIJ DHHJOLJLNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EA30", Offset = "0x5E5DE30", VA = "0x185E5EA30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public IMDEFFNCIAA AJPDGAPFGNH
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E940", Offset = "0x5E5DD40", VA = "0x185E5E940")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public MLKCCEGIBBL GCKCFOBIHPK
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E540", Offset = "0x5E5D940", VA = "0x185E5E540")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MLKCCEGIBBL GILDPEKDHCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E840", Offset = "0x5E5DC40", VA = "0x185E5E840")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5E5EAB0", Offset = "0x5E5DEB0", VA = "0x185E5EAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5EB00", Offset = "0x5E5DF00", VA = "0x185E5EB00")]
	public bool PPONGLALHNF(MLKCCEGIBBL MOHMMJFCOKF, bool NJBBGNGBLAC = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E650", Offset = "0x5E5DA50", VA = "0x185E5E650")]
	public bool EMDDIIBDLLE(MLKCCEGIBBL DBLKGKBGOJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public CDFEABOOLLO(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E740", Offset = "0x5E5DB40", VA = "0x185E5E740", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(CDFEABOOLLO CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct CEFOIIOEBKM : IEquatable<CEFOIIOEBKM>
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CEFOIIOEBKM GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private CLAIAHNAJKH GDOMGFHABHO
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F390", Offset = "0x5E5E790", VA = "0x185E5F390")]
		get
		{
			return default(CLAIAHNAJKH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public KPIPIEGADJN FKOLLPPPCAK
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F3F0", Offset = "0x5E5E7F0", VA = "0x185E5F3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public CEFOIIOEBKM(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F290", Offset = "0x5E5E690", VA = "0x185E5F290", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(CEFOIIOEBKM CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface BLJHFMKLDNO
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	IFPAFNCCJJC EIPEJNOHDMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface KBCPAINDIMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool LOLKKEHCCKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool GAIMNJMEONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int MJEHPPCOFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool ACFMPDOLAAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	OIINNOCPDBE JJMIBLNHAKB
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	IJKGIOKEPGE FHFJNGLNABB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool HHLGNEMFOKD
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool FKNOPBMIOAK
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string JEMEFIEGMLG
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OMLNKEGAJLA(GameObject NJMBJKHNCBN);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject[] JHEPALJAMDF(IEnumerable<JPJMKEMBNIL> FNCLHKFMFGG);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EGAFANECNIE NHMDBMPNBPK(Guid AGODCLDOFNK);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "12")]
	HNAAHBOEIIB BAPGCEJHADE(JPJMKEMBNIL OLCOAAKJEBF);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HNAAHBOEIIB BAPGCEJHADE(string EGCMLONOLPA, EGAFANECNIE JOJAINIHPBN, Vector3 FLBOBIODIJO, Quaternion FKJONOBDEOA, Vector3 LECHMDFLPHK);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void PGKEEENIEBC(bool BAFIBBBAHIK);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void MFBCEAPCPHB();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool FIMEJMHGDNK(GameObject NJMBJKHNCBN, out EGAFANECNIE JOJAINIHPBN);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool DCLJANNDCGC(GameObject NJMBJKHNCBN, out int GFOPPAANMHB, out ObjectPrefabType MKAEEINGAAI);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void OCALEBOKAJF(GameObject NJMBJKHNCBN, bool NHAHJJPGACG, bool GFCGEBIALLO);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void KKHOBNCJPPP(GameObject NJMBJKHNCBN);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task FAANOIPEMGA();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task KDHAMJHFALG();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DJHIENJMHCM(object ICMDHGDOHEC);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BKOGDDPAGMJ(object ICMDHGDOHEC);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PJEEADOEAED(object PCDLJHELPEC);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DJJFBGIAHNB(Transform MPLKBAJKIFD);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void DKOIOHNBCKH(Transform MPLKBAJKIFD, FHGCEPLIEKH IHGEEBGIHLH);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void HJGOABAELOA(Transform MPLKBAJKIFD, IFPAFNCCJJC BFKNABEILKA);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void NFHKLEHKDDD(GameObject NJMBJKHNCBN, ObjectPolicyUserConfigurableFlags BBJCDJGKMAH);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Vector3 AKPDCDBBDDD(GameObject NJMBJKHNCBN, int OGLPMADNAAO);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool MKFGIHACAOC(out Vector3 FLBOBIODIJO);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void FOCBEHCDOPN();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void OIMHGEIKELN(GameObject JNEEPMAKONJ, bool BIECHBLBGNL);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ObjectPrefabType DOBMBPENKHJ(GameObject NPKKHNDMELE);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int LILMHOKBKOP(GameObject NJMBJKHNCBN);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "35")]
	object HGFIKNKIDPK(IMDEFFNCIAA IEFFONDNDLL, GameObject NJMBJKHNCBN, Action<IMDEFFNCIAA, int> JGHGBFJPJFD);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void CNJDLCBFBEG(GameObject NJMBJKHNCBN, object NKJJOFLIMEJ);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JIEKICFKCAB(GameObject NJMBJKHNCBN);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PGFEABLNKNB(AKEJCMHMCDK JFCLEPECFNA);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void GODEIMHBCBC(GameObject NJMBJKHNCBN);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JDLDLEOLGOD(string HGJOENLBDNH);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	int MOBDDHEBKBB(GameObject NPKKHNDMELE);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void CPJJJENLNPK(NativeArray<int> BJCOGECALAL);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void PNICGFOIGHK(Action ENOAFIICPMH, bool NONJIGPIBJK);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool PJFJJLLHGBA(string LMAOKJPAKEM);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class NEBGAMKLAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C840", Offset = "0x5E6BC40", VA = "0x185E6C840")]
	public static HNAAHBOEIIB BAPGCEJHADE(this KBCPAINDIMN HHBCKKPLCGJ, EGAFANECNIE JOJAINIHPBN, Vector3 FLBOBIODIJO, Quaternion FKJONOBDEOA, Vector3 LECHMDFLPHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface PALEKMMEDGH
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct MMDJEOKLOHM : global::IOBMJIDOGJO<MMDJEOKLOHM>, BEDBGJPABOB, IEquatable<MMDJEOKLOHM>
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int BEOOPJIPEDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int COABGJJGOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xB820F0", Offset = "0xB814F0", VA = "0x180B820F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x1115560", Offset = "0x1114960", VA = "0x181115560", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C710", Offset = "0x5E6BB10", VA = "0x185E6C710", Slot = "8")]
	public bool Equals(MMDJEOKLOHM CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5E6C760", Offset = "0x5E6BB60", VA = "0x185E6C760", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct KHADDDPLFEJ : LIFDKPCHNND, IEquatable<KHADDDPLFEJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ObjectPrefabType MKAEEINGAAI;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A000", Offset = "0x5E69400", VA = "0x185E6A000", Slot = "5")]
	public void INEKOHCFCOE(ref LLDKDABBJGA KHMLBMENKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E69F40", Offset = "0x5E69340", VA = "0x185E69F40", Slot = "4")]
	public void AKAHDAOKFEM(ref ABEOAGNMLCL NJDPCCBFDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A030", Offset = "0x5E69430", VA = "0x185E6A030", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xB446B0", Offset = "0xB43AB0", VA = "0x180B446B0", Slot = "6")]
	public bool Equals(KHADDDPLFEJ CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E69F70", Offset = "0x5E69370", VA = "0x185E69F70", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface IIEPBPILAFH
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action BNEDGJJPPIL;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JBKHFBCIKCL();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIPMKBLBFHD();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface JIMDJIJECBG
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	BGHGHILBACL GBDLNPAGGIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	List<FKGHEBGADOE> OFPBBDBEGHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KHMELCJJDLK(FKGHEBGADOE MMNEFCOHNGA, out BGHGHILBACL ACHKMLIMANN);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJCLACJNMFM(FKGHEBGADOE MMNEFCOHNGA, CDINJNIEIFH GLDJLMGCFGO);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JIHGEKLNBJO(FKGHEBGADOE MMNEFCOHNGA, CDINJNIEIFH GLDJLMGCFGO);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface PHBEABIKADI
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	IGOHMKKOJHO MDBLMGGEJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct DAICGNOLHEL : IEquatable<DAICGNOLHEL>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly DAICGNOLHEL GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private KAEPMDHNIJA NKNFDPOALOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FAA0", Offset = "0x5E5EEA0", VA = "0x185E5FAA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float3 DIBJJGKOEEN
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F9A0", Offset = "0x5E5EDA0", VA = "0x185E5F9A0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public quaternion APIJJLBKLLC
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F730", Offset = "0x5E5EB30", VA = "0x185E5F730")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public MLKCCEGIBBL GCDNJDNGJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F820", Offset = "0x5E5EC20", VA = "0x185E5F820")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F950", Offset = "0x5E5ED50", VA = "0x185E5F950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public DAICGNOLHEL(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
	public static IMDEFFNCIAA ILINJACDGKH(DAICGNOLHEL EOEKGHMNIDN)
	{
		return default(IMDEFFNCIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F630", Offset = "0x5E5EA30", VA = "0x185E5F630", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(DAICGNOLHEL CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface MJGOELHCAKJ
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action EHLBFCMKKCL;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action PLBCKHIAOLD;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action EBCLBCHJFMF;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface BGHGHILBACL
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string NGLGHKKJION
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	BGHGHILBACL GHALMPCEACP
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	IEnumerable<BGHGHILBACL> BHJOBJAOLAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
public struct AKEJCMHMCDK : IReadOnlyList<IMDEFFNCIAA>, IEnumerable<IMDEFFNCIAA>, IEnumerable, IReadOnlyCollection<IMDEFFNCIAA>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct HCFMBDBPKFK : IEnumerator<IMDEFFNCIAA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly KCNJCALDJDJ BJFNPHMFGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private NativeArray<LocalId>.Enumerator CJENBGBEBMN;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public IMDEFFNCIAA HHNCKLAAHCM
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5E66EE0", Offset = "0x5E662E0", VA = "0x185E66EE0", Slot = "4")]
			get
			{
				return default(IMDEFFNCIAA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5E66E00", Offset = "0x5E66200", VA = "0x185E66E00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2824180", Offset = "0x2823580", VA = "0x182824180")]
		public HCFMBDBPKFK(KCNJCALDJDJ BJFNPHMFGCG, NativeArray<LocalId>.Enumerator CJENBGBEBMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E66D40", Offset = "0x5E66140", VA = "0x185E66D40", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E66D80", Offset = "0x5E66180", VA = "0x185E66D80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E66DC0", Offset = "0x5E661C0", VA = "0x185E66DC0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly KCNJCALDJDJ BJFNPHMFGCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<LocalId> JFCLEPECFNA;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public IMDEFFNCIAA KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D650", Offset = "0x5E5CA50", VA = "0x185E5D650", Slot = "4")]
		get
		{
			return default(IMDEFFNCIAA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D140", Offset = "0x5E5C540", VA = "0x185E5D140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private int GDCPGIMJOIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int EAGEACLGNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x80EA60", Offset = "0x80DE60", VA = "0x18080EA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool BDLONBHMKDC
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D150", Offset = "0x5E5C550", VA = "0x185E5D150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NativeArray<LocalId> HINAGPGKJDM
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x2824AF0", Offset = "0x2823EF0", VA = "0x182824AF0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	internal NativeArray<Entity> MAJBEDNGAJG
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5D0E0", Offset = "0x5E5C4E0", VA = "0x185E5D0E0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D5C0", Offset = "0x5E5C9C0", VA = "0x185E5D5C0")]
	public AKEJCMHMCDK(int FJOEBJHKPLP, KCNJCALDJDJ BJFNPHMFGCG, Allocator NAFCEIMFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2823CD0", Offset = "0x28230D0", VA = "0x182823CD0")]
	public AKEJCMHMCDK(KCNJCALDJDJ BJFNPHMFGCG, NativeArray<LocalId> JFCLEPECFNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D400", Offset = "0x5E5C800", VA = "0x185E5D400")]
	internal AKEJCMHMCDK(KCNJCALDJDJ BJFNPHMFGCG, NativeArray<Entity> JEBIOEILLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D470", Offset = "0x5E5C870", VA = "0x185E5D470")]
	public AKEJCMHMCDK(KCNJCALDJDJ BJFNPHMFGCG, int JNPIFHIHMEO, Allocator NAFCEIMFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D510", Offset = "0x5E5C910", VA = "0x185E5D510")]
	public AKEJCMHMCDK(AKEJCMHMCDK KOBFOICLAOK, Allocator NAFCEIMFOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D0A0", Offset = "0x5E5C4A0", VA = "0x185E5D0A0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D190", Offset = "0x5E5C590", VA = "0x185E5D190")]
	public HCFMBDBPKFK KLBJEDHKGHJ()
	{
		return default(HCFMBDBPKFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D220", Offset = "0x5E5C620", VA = "0x185E5D220", Slot = "6")]
	private IEnumerator<IMDEFFNCIAA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D310", Offset = "0x5E5C710", VA = "0x185E5D310", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct EGAFANECNIE : IComparable<EGAFANECNIE>, IEquatable<EGAFANECNIE>, LIFDKPCHNND
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const uint NAKLPHAMKAM = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const uint NGJLGOIANAK = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly EGAFANECNIE AMDFEIFOGIH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const int CNJEHCDCLJG = 24;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const uint GJDLFIPMPJI = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const int AFNGMMOOGHF = 8;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const uint AOBFAPLNEGE = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly uint FDJAKBCCGFI;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public uint MDEHLILGJIE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1408310", Offset = "0x1407710", VA = "0x181408310")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public uint DEMEBAENMIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E61130", Offset = "0x5E60530", VA = "0x185E61130")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public uint HIANNDKGNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool APIKOGAJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x16BF7D0", Offset = "0x16BEBD0", VA = "0x1816BF7D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool KEGMMAHLFCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5E60F80", Offset = "0x5E60380", VA = "0x185E60F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xB46270", Offset = "0xB45670", VA = "0x180B46270")]
	public static EGAFANECNIE BNHALOPIGKO(uint FDJAKBCCGFI)
	{
		return default(EGAFANECNIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E61270", Offset = "0x5E60670", VA = "0x185E61270")]
	public EGAFANECNIE(int FIAIJEPBAMD, int PDFKCHKAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E61270", Offset = "0x5E60670", VA = "0x185E61270")]
	public EGAFANECNIE(uint FIAIJEPBAMD, int PDFKCHKAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E61270", Offset = "0x5E60670", VA = "0x185E61270")]
	public EGAFANECNIE(uint FIAIJEPBAMD, uint PDFKCHKAMKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460")]
	private EGAFANECNIE(uint FDJAKBCCGFI)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x578A9B0", Offset = "0x5789DB0", VA = "0x18578A9B0")]
	public static bool MHCPIEGNOBB(EGAFANECNIE ELMEJGEELII, EGAFANECNIE EOKEPOJIFJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x578A9C0", Offset = "0x5789DC0", VA = "0x18578A9C0")]
	public static bool BDKIFGPLPMB(EGAFANECNIE ELMEJGEELII, EGAFANECNIE EOKEPOJIFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E61000", Offset = "0x5E60400", VA = "0x185E61000", Slot = "5")]
	public bool Equals(EGAFANECNIE IDFOGLKIIHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E61060", Offset = "0x5E60460", VA = "0x185E61060", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x152B140", Offset = "0x152A540", VA = "0x18152B140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E611A0", Offset = "0x5E605A0", VA = "0x185E611A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E60F90", Offset = "0x5E60390", VA = "0x185E60F90", Slot = "6")]
	public void AKAHDAOKFEM(ref ABEOAGNMLCL NJDPCCBFDCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E61140", Offset = "0x5E60540", VA = "0x185E61140", Slot = "7")]
	public void INEKOHCFCOE(ref LLDKDABBJGA KHMLBMENKDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E60FF0", Offset = "0x5E603F0", VA = "0x185E60FF0", Slot = "4")]
	public int CompareTo(EGAFANECNIE CCJMBGJFGLH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface DMFDGDJCGND
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LNIHCBAEGKH(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DGNPOJOBIOF(Entity HHCOBCONNMJ, in float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 NEPFEKIICCO(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DNIEECILPMF(Entity HHCOBCONNMJ, in quaternion EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion DEGMBBJPOAB(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void MAGIAHEFJPE(Entity HHCOBCONNMJ, in float3 FLBOBIODIJO, in quaternion FKJONOBDEOA);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JMCLPIHOPEN(Entity HHCOBCONNMJ, out float3 FLBOBIODIJO, out quaternion FKJONOBDEOA);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DNMJKNDLLBC(Entity HHCOBCONNMJ, in float3 FLBOBIODIJO, in quaternion FKJONOBDEOA);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KJHNPPDKGGC(Entity HHCOBCONNMJ, out RigidTransform CJJFOBDNONI);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	float3 FAFGIDOMAME(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JOBHCHAIGEC(Entity HHCOBCONNMJ, in float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PDKNKLCAIJH(Entity HHCOBCONNMJ, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	float IDLKIHPGEIM(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void BOEAABPBMCG(Entity HHCOBCONNMJ, in float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	float3 EBNDHJEABFK(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void NDEDGKKJLHM(Entity HHCOBCONNMJ, in float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	float3 APNAHGNKPDL(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void JCGAHJPDOKC(Entity HHCOBCONNMJ, in quaternion EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	quaternion JFKCKFFJMIB(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LEHIMPDPOGB(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void IDLLJAJBIFP(Entity HHCOBCONNMJ, in float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OCBOBCAJCJP(Entity HHCOBCONNMJ, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float MCOEFEGCGNH(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void LKLIDOMLFOK(Entity HHCOBCONNMJ, in float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float3 GNILIHMMOCH(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MJFNFAELABI(Entity HHCOBCONNMJ, out float4x4 GFHIMHCOABH);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void ENMNACCGHOC(Entity HHCOBCONNMJ, in float4x4 GFHIMHCOABH);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void JHPGNKKFMCP(Entity HHCOBCONNMJ, out float4x4 GFHIMHCOABH);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool JJKICHPIFID(Entity HHCOBCONNMJ, out Transform MPLKBAJKIFD);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void LOJIOJKFFDN(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IOMOLEBPBFL(Entity HHCOBCONNMJ, Entity LPINEKOJLDF, Entity OFEIPHKKILF);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class LMJGGIEGBEB
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct FGOLBLJNLDD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IEnumerable<JPJMKEMBNIL> FNCLHKFMFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IReadOnlyList<GameObject> AFICPDFCPPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IReadOnlyList<int> PIGKDPHFELC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int CFGGCEGDDJA;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool APIKOGAJGJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E64C60", Offset = "0x5E64060", VA = "0x185E64C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int MNEFLINEKMD
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x856570", Offset = "0x855970", VA = "0x180856570")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IEnumerable<GameObject> NCGKLIPOEJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x949560", Offset = "0x948960", VA = "0x180949560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x1849F40", Offset = "0x1849340", VA = "0x181849F40")]
	public FGOLBLJNLDD(IEnumerable<JPJMKEMBNIL> FNCLHKFMFGG, IReadOnlyList<GameObject> AFICPDFCPPD, IReadOnlyList<int> PIGKDPHFELC, int CFGGCEGDDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5E64A30", Offset = "0x5E63E30", VA = "0x185E64A30")]
	public IEnumerable<(GameObject, int)> GJIHCBMBPJP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct FIDOKBMDCIB : IEquatable<FIDOKBMDCIB>
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly FIDOKBMDCIB GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private IAHGCMLPFIJ DHHJOLJLNKO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x5E65930", Offset = "0x5E64D30", VA = "0x185E65930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public AKEJCMHMCDK BDHIBBLNHEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5E64E00", Offset = "0x5E64200", VA = "0x185E64E00")]
		get
		{
			return default(AKEJCMHMCDK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<MLKCCEGIBBL> ANNJFKHLGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5E65770", Offset = "0x5E64B70", VA = "0x185E65770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<MLKCCEGIBBL> FIMHOEFCMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5E64CC0", Offset = "0x5E640C0", VA = "0x185E64CC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int KGBJBPLILIH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5E65A00", Offset = "0x5E64E00", VA = "0x185E65A00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int MILNIMMFNAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5E658E0", Offset = "0x5E64CE0", VA = "0x185E658E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string EKGMLAPMPFM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x5E65110", Offset = "0x5E64510", VA = "0x185E65110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ContainerCollisionLayerEnum JCIKHHJLOLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5E65520", Offset = "0x5E64920", VA = "0x185E65520")]
		get
		{
			return default(ContainerCollisionLayerEnum);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5E65700", Offset = "0x5E64B00", VA = "0x185E65700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CollisionMode CONBCEFDBBC
	{
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5E65B20", Offset = "0x5E64F20", VA = "0x185E65B20")]
		get
		{
			return default(CollisionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5E65650", Offset = "0x5E64A50", VA = "0x185E65650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool PDGCLNLLAMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5E656E0", Offset = "0x5E64AE0", VA = "0x185E656E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool OJJGGCNJCDB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5E65AE0", Offset = "0x5E64EE0", VA = "0x185E65AE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool FHEIGLFBLDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5E656C0", Offset = "0x5E64AC0", VA = "0x185E656C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool PHABPNOKIBF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5E65B00", Offset = "0x5E64F00", VA = "0x185E65B00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool KGGELNDHJIP
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5E65100", Offset = "0x5E64500", VA = "0x185E65100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5E65260", Offset = "0x5E64660", VA = "0x185E65260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool DIEDHEHPGDM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5E65640", Offset = "0x5E64A40", VA = "0x185E65640")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5E65B80", Offset = "0x5E64F80", VA = "0x185E65B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public FALPHDCACCD LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(FALPHDCACCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public CDFEABOOLLO ENBFKHIFKEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(CDFEABOOLLO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5E659B0", Offset = "0x5E64DB0", VA = "0x185E659B0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
	public static MLKCCEGIBBL ILINJACDGKH(FIDOKBMDCIB BFLCNPAPJDC)
	{
		return default(MLKCCEGIBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E65240", Offset = "0x5E64640", VA = "0x185E65240")]
	public bool BKIJINAMDAI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x5E65580", Offset = "0x5E64980", VA = "0x185E65580")]
	public bool GLLIPNOCCMC(ContainerEnumFlags GOKAGNCECMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E651C0", Offset = "0x5E645C0", VA = "0x185E651C0")]
	public void BJIPJELOHCI(ContainerEnumFlags GOKAGNCECMF, bool EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E64F00", Offset = "0x5E64300", VA = "0x185E64F00")]
	public AKEJCMHMCDK APNNIPNJMIM(Allocator NAFCEIMFOBK)
	{
		return default(AKEJCMHMCDK);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E65270", Offset = "0x5E64670", VA = "0x185E65270")]
	public void CPHINLJPOIF(FIDOKBMDCIB CCJMBGJFGLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public FIDOKBMDCIB(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5E60880", Offset = "0x5E5FC80", VA = "0x185E60880")]
	public static bool ILINJACDGKH(FIDOKBMDCIB EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5E65420", Offset = "0x5E64820", VA = "0x185E65420", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(FIDOKBMDCIB CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct HMFFKFFPPNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal readonly NMIOHBKPFPA BHNALBBIKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal readonly NMIOHBKPFPA DHLNIOOELBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal readonly uint APNMAIAPGDJ;

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x5E671C0", Offset = "0x5E665C0", VA = "0x185E671C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct MNIJICDFJGA
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly HMFFKFFPPNA ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FB60", Offset = "0x5E5EF60", VA = "0x185E5FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct DBDDDKCKLKM
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly NDPMEMNFALO OLHOJKMAKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly HMFFKFFPPNA ENOAFIICPMH;

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FB60", Offset = "0x5E5EF60", VA = "0x185E5FB60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct EFFKNCFNCKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly uint APNMAIAPGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly bool LFJMFCKHKPP;

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x5E60EE0", Offset = "0x5E602E0", VA = "0x185E60EE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface IIAPALOEFIB
{
	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HJJLAFBIPLC(IMDEFFNCIAA IEFFONDNDLL, LBFGBCDJPKN EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LBFGBCDJPKN EOABDAGBKNE(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CHLDIHBNOLG(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CCGGLNOKPGD(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OAAGOMCCKFP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IMDEFFNCIAA HIHJCGFMDFB(IMDEFFNCIAA IEFFONDNDLL, int CJOLACIBAJH);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DFIHGDLEHBD(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void KLIABCIIBBM(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA, IMDEFFNCIAA EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MHOFJCCJOFO(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BIOKKKPDPHI(IMDEFFNCIAA IEFFONDNDLL, out IMDEFFNCIAA EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FHIELMCEHBN(IMDEFFNCIAA IEFFONDNDLL, float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool JOBPOPFLFOH(IMDEFFNCIAA IEFFONDNDLL, out float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JKPKBNOJODO(IMDEFFNCIAA IEFFONDNDLL, float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool PPEPMFMCHEI(IMDEFFNCIAA IEFFONDNDLL, out float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void MBHPKEOPAGF(IMDEFFNCIAA IEFFONDNDLL, (Quaternion rot, Vector3 moments) IMLBEEHPEDB);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool ACOKHBFIBBF(IMDEFFNCIAA IEFFONDNDLL, out quaternion KIMDGOAILEF, out float3 CEOMALMFDKG);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void JJONEKGANGE(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BJLIKPNPFMN(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 ECJFPJJIDGJ(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LFHBLDCDKNB(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void EDKGHCKEJHI(IMDEFFNCIAA IEFFONDNDLL, float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool OOGMGIPEKCK(IMDEFFNCIAA IEFFONDNDLL, out float3 OKOAHEMPMHP);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IODBEDMOIMG(IMDEFFNCIAA IEFFONDNDLL, float3 EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KECFIILIJLB(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float DFEIPJDHPDE(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float CIFPMIALJEF(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GLKEKOMJGFL(IMDEFFNCIAA IEFFONDNDLL, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool ADJGEOEAPHG(IMDEFFNCIAA IEFFONDNDLL, out float KPNADFDDJOF);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OBLKDIKOLCB(IMDEFFNCIAA IEFFONDNDLL, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode GFOPKILGHFH(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IBDJBGEOIGN(IMDEFFNCIAA IEFFONDNDLL, CollisionDetectionMode EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "31")]
	POPMGKKDDGN NFIILBFHDFL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void EJDGILNHFDC(IMDEFFNCIAA IEFFONDNDLL, POPMGKKDDGN EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool PFNOPLGJMAJ(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LEMIDMDILDC(IMDEFFNCIAA IEFFONDNDLL, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "35")]
	IMDEFFNCIAA NAPLGMCPHCL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void PJHNJNGCBLL(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "37")]
	IMDEFFNCIAA HFLAOFHLDCL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PPONGLALHNF(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "39")]
	KGLFAPPIPIG JBHIFGAOMBK(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void FBCCEHLOGEB(IMDEFFNCIAA IEFFONDNDLL, KGLFAPPIPIG NINHMIPGMFC);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool LJGIILDAHCP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FLOIFODJGGD(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool DLBKGCMDPKO(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void BNHDMIAAGLA(IMDEFFNCIAA IEFFONDNDLL, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool OIDJNDMPLBD(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void BAFDEHNNMOK(IMDEFFNCIAA IEFFONDNDLL, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints FOKAFFNHBBL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void KDAMFIHDCLD(IMDEFFNCIAA IEFFONDNDLL, RigidbodyConstraints EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float PCIFEAHFDEP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void AEFNAKNEHGP(IMDEFFNCIAA IEFFONDNDLL, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float KAHAOHBBEMI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void DBJAABLDHHH(IMDEFFNCIAA IEFFONDNDLL, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool LIAIBGDGMBB(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void GDFMGAPHOHG(IMDEFFNCIAA IEFFONDNDLL, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool KNFKGEBDCAI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void KBFAMMJLJNA(IMDEFFNCIAA IEFFONDNDLL, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int PPOFEAEEPPG(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void EIICNOGGBPG(IMDEFFNCIAA IEFFONDNDLL, int EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object ADHFHDLAJHI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DIKPAEOOKIP(IMDEFFNCIAA IEFFONDNDLL, object EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object AJPHJNEDAKG(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void HLAHNJHHKCB(IMDEFFNCIAA IEFFONDNDLL, object EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float JEEFDJDLFOP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void JDJLJMCCMGF(IMDEFFNCIAA IEFFONDNDLL, float EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void MOIADCDLKAC(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void IGDIFBFHBAG(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JJNMBOJEMON(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void FJLPMFJFGHF(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void PELLAPCMIEJ(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool EDLANOGCMLI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool CKHOBGKCNPM(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void BFALHJOFGDI(IMDEFFNCIAA IEFFONDNDLL, bool EOEKGHMNIDN);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Rigidbody IKJKADMOGNL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void FGFDKNJNMEN(IMDEFFNCIAA IEFFONDNDLL, Rigidbody OHFFPKCPFLA);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void DFAGECHNENN(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void FOPJGGNMGEC(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool JMFLAOCCPNP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void MHFIEMIJDBH(IMDEFFNCIAA IEFFONDNDLL, float3 CCEKBJKHCEP);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void KGIPDGFOOCN(IMDEFFNCIAA IEFFONDNDLL, float3 IGPNCMNEFAG);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool IDMGBJEBMNL(IMDEFFNCIAA IEFFONDNDLL, out float3 CCEKBJKHCEP);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool IKNCIEFIDDC(IMDEFFNCIAA IEFFONDNDLL, out float3 IGPNCMNEFAG);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "82")]
	bool EGICHPNLMHF(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void AINFHHFLPAA(IMDEFFNCIAA IEFFONDNDLL, object IJNLJGNNJFA, bool HLALGAMPNBK);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void OBFIMFPJNJO(IMDEFFNCIAA IEFFONDNDLL, bool NGIJJBFOBHO);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void GHNKJHNHKME(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "86")]
	bool JKCPAHFBBFP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "87")]
	IEnumerable<object> FJLHLPCBBJN(IMDEFFNCIAA IEFFONDNDLL);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface HEFABNLFIEJ
{
	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MODHINJFPHI(Entity FAGCIJAEKEK);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HFNFGMGNEIP(Entity FAGCIJAEKEK);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct DFCAMNBDDHF : IEquatable<DFCAMNBDDHF>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly DFCAMNBDDHF GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string GIMPGDCDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x600026C")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FDB0", Offset = "0x5E5F1B0", VA = "0x185E5FDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string AFAGKDKIOFG
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5FD00", Offset = "0x5E5F100", VA = "0x185E5FD00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public DFCAMNBDDHF(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x5E5FC00", Offset = "0x5E5F000", VA = "0x185E5FC00", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(DFCAMNBDDHF CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct KMCPJEINPAB : IEquatable<KMCPJEINPAB>
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly KMCPJEINPAB GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000279")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x5E6A0C0", Offset = "0x5E694C0", VA = "0x185E6A0C0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(KMCPJEINPAB CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct EBPMNNHKLBO : IEquatable<EBPMNNHKLBO>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EBPMNNHKLBO GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private DPIAMAPHADI FNFFDCBHELM
	{
		[Cpp2IlInjected.Token(Token = "0x600027B")]
		[Cpp2IlInjected.Address(RVA = "0x5E60890", Offset = "0x5E5FC90", VA = "0x185E60890")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool BFIJPGMJHJP
	{
		[Cpp2IlInjected.Token(Token = "0x600027F")]
		[Cpp2IlInjected.Address(RVA = "0x5E600A0", Offset = "0x5E5F4A0", VA = "0x185E600A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool GHNBGMDFEGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5E60A20", Offset = "0x5E5FE20", VA = "0x185E60A20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool ILDNPDILDFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5E60810", Offset = "0x5E5FC10", VA = "0x185E60810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool OHACPOJFCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5E60840", Offset = "0x5E5FC40", VA = "0x185E60840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool AAKJNHOMEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5E60910", Offset = "0x5E5FD10", VA = "0x185E60910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool EFOGOGPEGEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5E60BB0", Offset = "0x5E5FFB0", VA = "0x185E60BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool EBDGPAJAJMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5E60370", Offset = "0x5E5F770", VA = "0x185E60370")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600028D")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5E60B60", Offset = "0x5E5FF60", VA = "0x185E60B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x5E60340", Offset = "0x5E5F740", VA = "0x185E60340")]
	public bool EHMBFIOKAGD()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5E606B0", Offset = "0x5E5FAB0", VA = "0x185E606B0")]
	public MLKCCEGIBBL HAIELKPPNBI(MLKCCEGIBBL ICMDHGDOHEC)
	{
		return default(MLKCCEGIBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5E60180", Offset = "0x5E5F580", VA = "0x185E60180")]
	public IMDEFFNCIAA DDEPOCLKFJN()
	{
		return default(IMDEFFNCIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public EBPMNNHKLBO(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x5E60880", Offset = "0x5E5FC80", VA = "0x185E60880")]
	public static bool ILINJACDGKH(EBPMNNHKLBO EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x5E605B0", Offset = "0x5E5F9B0", VA = "0x185E605B0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(EBPMNNHKLBO CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct CDCHAKEJFEI : IComparable<CDCHAKEJFEI>, IEquatable<CDCHAKEJFEI>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly CDCHAKEJFEI AMDFEIFOGIH;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly CDCHAKEJFEI KHLADIJPICC;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly CDCHAKEJFEI BNBPAOMGELD;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly CDCHAKEJFEI COEGINGAFPP;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly CDCHAKEJFEI BILGGKOFKAO;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly CDCHAKEJFEI DCLEOMLLADB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int BEOOPJIPEDJ;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool LNIAICJOBCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5E5E2B0", Offset = "0x5E5D6B0", VA = "0x185E5E2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460")]
	public CDCHAKEJFEI(int CJOLACIBAJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E350", Offset = "0x5E5D750", VA = "0x185E5E350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E2C0", Offset = "0x5E5D6C0", VA = "0x185E5E2C0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0xB446B0", Offset = "0xB43AB0", VA = "0x180B446B0", Slot = "5")]
	public bool Equals(CDCHAKEJFEI CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E2A0", Offset = "0x5E5D6A0", VA = "0x185E5E2A0", Slot = "4")]
	public int CompareTo(CDCHAKEJFEI CCJMBGJFGLH)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0xB46270", Offset = "0xB45670", VA = "0x180B46270")]
	public static CDCHAKEJFEI ILINJACDGKH(int CJOLACIBAJH)
	{
		return default(CDCHAKEJFEI);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xB46270", Offset = "0xB45670", VA = "0x180B46270")]
	public static int ILINJACDGKH(CDCHAKEJFEI GAEHKOIHPJO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5E5E3C0", Offset = "0x5E5D7C0", VA = "0x185E5E3C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
[DefaultMember("Item")]
public interface JIMGPGJIKKI : IEnumerable<IKNIHGGOHHI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	IKNIHGGOHHI KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IKNIHGGOHHI ACEIDCHGHEK(GPHNDJBMNHN CDJGAGCIMIF);

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CDCHAKEJFEI HLDEFGJINDN(GPHNDJBMNHN CDJGAGCIMIF);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AKJCMPIBKHP
{
	[Cpp2IlInjected.Token(Token = "0x600029F")]
	public static global::NNBPJAGAMEP<T> ACEIDCHGHEK<T>(this JIMGPGJIKKI PGJHKOKFEAD, GPHNDJBMNHN LMAOKJPAKEM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	[Cpp2IlInjected.Address(RVA = "0x1A50C80", Offset = "0x1A50080", VA = "0x181A50C80")]
	public static CDCHAKEJFEI HLDEFGJINDN<T>(this JIMGPGJIKKI PGJHKOKFEAD, global::BLOOENFJLDB<T> LMAOKJPAKEM) where T : struct
	{
		return default(CDCHAKEJFEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface CACOFJOFNOF
{
	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LIDACBKLHBC(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAHPBPNLIED(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IJGNJFECGDC(IMDEFFNCIAA IEFFONDNDLL, out Guid KCFOMBLHMHL);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid LGMFPBNHJHP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHOEBBJEFKO(IMDEFFNCIAA IEFFONDNDLL, Guid KCFOMBLHMHL);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KJDOGJMICFC(IMDEFFNCIAA IEFFONDNDLL, out Guid APJCGFNBKKN);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid HEJNKKMPJAA(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMLOECHMPOI(IMDEFFNCIAA IEFFONDNDLL, Guid APJCGFNBKKN);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPAGHMDLAOK(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FFAHDGLFCDC(IMDEFFNCIAA GJELBDOMMOA, IMDEFFNCIAA MOHMMJFCOKF);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface JIMNEJGOKKH
{
	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HCMNEFGJPDJ(IMDEFFNCIAA DPIBKMGPGEE, bool EOEKGHMNIDN);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct MKILFLIPNHF : IEquatable<MKILFLIPNHF>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly MKILFLIPNHF GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public JOKAONOMLCB LFDILJDLKED
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(JOKAONOMLCB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private PNGMFEOMAHL NJCKMMECMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B6E0", Offset = "0x5E6AAE0", VA = "0x185E6B6E0")]
		get
		{
			return default(PNGMFEOMAHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PrimitiveShapeType GCHIFKDINLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B740", Offset = "0x5E6AB40", VA = "0x185E6B740")]
		get
		{
			return default(PrimitiveShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public MKILFLIPNHF(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E60880", Offset = "0x5E5FC80", VA = "0x185E60880")]
	public static bool ILINJACDGKH(MKILFLIPNHF EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B5E0", Offset = "0x5E6A9E0", VA = "0x185E6B5E0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(MKILFLIPNHF CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface BLKFDEHNDMK
{
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCMPEHLLKNG(IMDEFFNCIAA IEFFONDNDLL, ContainerCollisionLayerEnum EPKIGGCEOCA, bool EFEAAJNAGCA, ContainerEnumFlags GJIHLNKDBBL);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DKCFGGNBPFD(IMDEFFNCIAA IEFFONDNDLL, ContainerCollisionLayerEnum EPKIGGCEOCA, bool EFEAAJNAGCA, bool HLNJKMGKDBB, bool BFEEMCCHMHM);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NDHJCHKBPCE LHIEBBMPANB(IMDEFFNCIAA PFMMNJCIGCA, List<IMDEFFNCIAA> EGGFBOFGIEM);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INCDLCMFJHK(GameObject PIIFIGKJLMN, GameObject APOHCJDGGAM);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNDCMIJMPOL(GameObject APOHCJDGGAM);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T GCBBGBLOAJE<T>(GameObject LAKPNPIGFKL) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DJKLLIEIMIG(Collider COMGKHGIKLH);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject AAJIFDHJPDC<T>(string LMAOKJPAKEM) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface JIBMGDNEHGM
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool GEKLMBBMKNK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface LGJIFBOLFHD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool HFEHLENHLPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool GNIHGJEPBJL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	DLMACKADCNB KJPDBBGGMIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JECEIGGHIBM(bool BAFIBBBAHIK);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task BHCFAJMLBAO(bool BAFIBBBAHIK);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GOKJBKPBAPI OONOAAHEPBO();

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GOKJBKPBAPI DJEIKAKFIEL(IEnumerable<IMDEFFNCIAA> JFCLEPECFNA, in FCFDDHHFPOK OAICODFJEFB);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HDJKKFAMPLG JBLCAFONMBE(ByteString LJAFCCNDGNM);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	KACLJEHKNGB NLCIECPJJOH(ByteString MPNODGMHCDM, IMDEFFNCIAA MOHMMJFCOKF, in FCFDDHHFPOK PCNJKIJLCGJ, JCIDMIDFHPP AEPKKPFINOL, bool JENNJMEDDGE = true);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DBFEJKCHOJF();

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void JOGMLJEKFIC(bool ICEFOBOBMED);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	FGOLBLJNLDD PLOFKKPHAPF(IEnumerable<JPJMKEMBNIL> FNCLHKFMFGG);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class KDKNHEDONLI
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface JEFIBNGGDMJ : HOPHCAFFENK, PNEBECAEHNN, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool LBFDKGPBIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	CHJCNLGFMDO NCGMBBJKFDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	KBCPAINDIMN FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface PNEBECAEHNN
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool BHHODJDPJBG
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface MAHMGHDEBJI
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool BMHKPNDDAGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface JBHJFOGGBKD
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Guid HFJGHCBIAJE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ELHDJLIILDB(Guid KCFOMBLHMHL, Guid APJCGFNBKKN, string LMAOKJPAKEM);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct NMIOHBKPFPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal int OKCABOJFCGG;

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(RVA = "0x5E6CA00", Offset = "0x5E6BE00", VA = "0x185E6CA00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class CFCFCPJJAJD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private struct HBKCIBIJHPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid LKDOBHNFOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DABOOGJAHEG NEKMHKNOJPK;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct DABOOGJAHEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int EOEKGHMNIDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int FDOJJNDLABD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int FAEOIJPFMKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int BDICMLCJPJI;

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F570", Offset = "0x5E5E970", VA = "0x185E5F570")]
		public bool INKGBLANPFI(out EGAFANECNIE JOJAINIHPBN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5F610", Offset = "0x5E5EA10", VA = "0x185E5F610")]
		public DABOOGJAHEG(EGAFANECNIE JOJAINIHPBN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F4A0", Offset = "0x5E5E8A0", VA = "0x185E5F4A0")]
	public static Guid CFLALBELOMN(this EGAFANECNIE JOJAINIHPBN)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5F550", Offset = "0x5E5E950", VA = "0x185E5F550")]
	public static bool CNAPCIEHNPE(this Guid LKDOBHNFOAM, out EGAFANECNIE JOJAINIHPBN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerTypeProxy(typeof(LGHFBHEEKGA))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct IMDEFFNCIAA : IComparable<IMDEFFNCIAA>, IEquatable<IMDEFFNCIAA>
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly IMDEFFNCIAA AMDFEIFOGIH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LocalId CJCHGPJPKIB
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x949560", Offset = "0x948960", VA = "0x180949560")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool JOIGBPFEMLO
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x5E67EC0", Offset = "0x5E672C0", VA = "0x185E67EC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool OJBMIFFBDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E67E40", Offset = "0x5E67240", VA = "0x185E67E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool GGHNPKGMAMB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E67E20", Offset = "0x5E67220", VA = "0x185E67E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E681A0", Offset = "0x5E675A0", VA = "0x185E681A0")]
	public IMDEFFNCIAA(KCNJCALDJDJ FOIAHNMFOHA, LocalId IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
	public MLKCCEGIBBL FIBMDMGBDHA()
	{
		return default(MLKCCEGIBBL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x949560", Offset = "0x948960", VA = "0x180949560")]
	public static LocalId ILINJACDGKH(IMDEFFNCIAA KOIBFOAPCGD)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E68040", Offset = "0x5E67440", VA = "0x185E68040")]
	public static Entity ILINJACDGKH(IMDEFFNCIAA KOIBFOAPCGD)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E68050", Offset = "0x5E67450", VA = "0x185E68050")]
	public static bool MHCPIEGNOBB(IMDEFFNCIAA ELMEJGEELII, IMDEFFNCIAA EOKEPOJIFJF)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E67D80", Offset = "0x5E67180", VA = "0x185E67D80")]
	public static bool BDKIFGPLPMB(IMDEFFNCIAA ELMEJGEELII, IMDEFFNCIAA EOKEPOJIFJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E680A0", Offset = "0x5E674A0", VA = "0x185E680A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E67F90", Offset = "0x5E67390", VA = "0x185E67F90", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E67E60", Offset = "0x5E67260", VA = "0x185E67E60", Slot = "4")]
	public int CompareTo(IMDEFFNCIAA CCJMBGJFGLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "5")]
	public bool Equals(IMDEFFNCIAA CCJMBGJFGLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class MLIFMNMCNAO
{
	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B7E0", Offset = "0x5E6ABE0", VA = "0x185E6B7E0")]
	public static EGAFANECNIE HIOMEAOIBKJ(this IMDEFFNCIAA GHHNOPFOGCC)
	{
		return default(EGAFANECNIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x27C64B0", Offset = "0x27C58B0", VA = "0x1827C64B0")]
	public static T HOLBKFCHBMO<T>(this IMDEFFNCIAA GHHNOPFOGCC) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class LGHFBHEEKGA
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface PEIOEFKNMMN
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool LBFDKGPBIJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PKPNLJEIMMF(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JLLAHAMEIHB(IMDEFFNCIAA IEFFONDNDLL, bool EFEAAJNAGCA, bool HLNJKMGKDBB, bool OJFCBHDINJE);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct JBNFHPJKMCE : IEquatable<JBNFHPJKMCE>
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly JBNFHPJKMCE GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x5E68FE0", Offset = "0x5E683E0", VA = "0x185E68FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(RVA = "0x5E68C50", Offset = "0x5E68050", VA = "0x185E68C50")]
	public void DOAEFKKEGEF(bool EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E68E90", Offset = "0x5E68290", VA = "0x185E68E90")]
	public void ICLMBMOHHNG(bool EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x20C52C0", Offset = "0x20C46C0", VA = "0x1820C52C0")]
	public T LLCGCGGJPHI<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public JBNFHPJKMCE(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5E68D90", Offset = "0x5E68190", VA = "0x185E68D90", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(JBNFHPJKMCE CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct BJPLDPEGIND : IEquatable<BJPLDPEGIND>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly BJPLDPEGIND GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FF")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D690", Offset = "0x5E5CA90", VA = "0x185E5D690", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(BJPLDPEGIND CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface PPNNLBBBMJL
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool CEHBGHHBKOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool BCNHKADOAJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool PDMEJADMONH
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool NCNMMBMGIFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool OIOOBBNLJKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool IGHIFOLFHEK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct FNMOJKCEPNM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float FNENONJMBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 IGOMHNAHGBN;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct JOKAONOMLCB : IEquatable<JOKAONOMLCB>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly JOKAONOMLCB GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private KPIDLDGAANP HHCHNECPFDD
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(RVA = "0x5E695E0", Offset = "0x5E689E0", VA = "0x185E695E0")]
		get
		{
			return default(KPIDLDGAANP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	public LGDNIGLMAOL CHFBGNPHJON
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(RVA = "0x5E69220", Offset = "0x5E68620", VA = "0x185E69220")]
		get
		{
			return default(LGDNIGLMAOL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public GFGOMGPAJLC KOGKDALDFFB
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5E69870", Offset = "0x5E68C70", VA = "0x185E69870")]
		get
		{
			return default(GFGOMGPAJLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public BNEPEKEABIC JALODABNENB
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5E698D0", Offset = "0x5E68CD0", VA = "0x185E698D0")]
		get
		{
			return default(BNEPEKEABIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public EShapeType PNNHPOOAJHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000311")]
		[Cpp2IlInjected.Address(RVA = "0x5E696A0", Offset = "0x5E68AA0", VA = "0x185E696A0")]
		get
		{
			return default(EShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public RenderableColor KGMDFLMACAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000312")]
		[Cpp2IlInjected.Address(RVA = "0x5E69930", Offset = "0x5E68D30", VA = "0x185E69930")]
		get
		{
			return default(RenderableColor);
		}
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5E69280", Offset = "0x5E68680", VA = "0x185E69280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public RenderableMaterial OHBMOMDKLCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5E69990", Offset = "0x5E68D90", VA = "0x185E69990")]
		get
		{
			return default(RenderableMaterial);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5E69800", Offset = "0x5E68C00", VA = "0x185E69800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public float IEHNLICOOLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5E69720", Offset = "0x5E68B20", VA = "0x185E69720")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5E692F0", Offset = "0x5E686F0", VA = "0x185E692F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public Vector3 JKJEHIDIIBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5E699F0", Offset = "0x5E68DF0", VA = "0x185E699F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5E69450", Offset = "0x5E68850", VA = "0x185E69450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public float BMCBDLJCGKH
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5E69780", Offset = "0x5E68B80", VA = "0x185E69780")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public ShapeConfigData.Flags JACKAFEHNJF
	{
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5E69640", Offset = "0x5E68A40", VA = "0x185E69640")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5E69370", Offset = "0x5E68770", VA = "0x185E69370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public FALPHDCACCD LIOPMIPOJEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(FALPHDCACCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5E691B0", Offset = "0x5E685B0", VA = "0x185E691B0")]
	public MKILFLIPNHF AFENOCCEKAD()
	{
		return default(MKILFLIPNHF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5E693E0", Offset = "0x5E687E0", VA = "0x185E693E0")]
	public GNGFCOEBOLO CKMOEJFECBD()
	{
		return default(GNGFCOEBOLO);
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public JOKAONOMLCB(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5E60880", Offset = "0x5E5FC80", VA = "0x185E60880")]
	public static bool ILINJACDGKH(JOKAONOMLCB EOEKGHMNIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E694E0", Offset = "0x5E688E0", VA = "0x185E694E0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(JOKAONOMLCB CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[GEDFJDPFIHC(FCAJHDGOHAJ.Application)]
public interface NIHLJNBPOFF
{
	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	INPLDICFFFN NCGMBBJKFDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	KBCPAINDIMN FOBFCLAHLJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	EODEEDFMDKF GGAMEKGGKNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	IAHGCMLPFIJ ENBFKHIFKEF
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	DMFDGDJCGND ANJKPDDLLIE
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	LGJIFBOLFHD EIKFLDHOEFO
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	MGHGCOLAIMC LPLJGGENDAP
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	BLHEHILJEDH CNIOEGNNEME
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	DPIAMAPHADI NFJCACLBGEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	EPPKDMGALCH OHKKCIMNHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	JIMNEJGOKKH FEGEGINNODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	IAJAHFHHDCD BMGEONFBJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	CACOFJOFNOF FGJOBIMOMBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	KAEPMDHNIJA IEPHPFJLPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	IIAPALOEFIB LNCMAHFCJAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	PPNNLBBBMJL PLABPDJCLOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface FKDLFLOJLOH
{
	[Cpp2IlInjected.Token(Token = "0x17000103")]
	object KEOKLNPMDJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000339")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PGFEABLNKNB(AKEJCMHMCDK JFCLEPECFNA);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface IAHGCMLPFIJ
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate void IBDLNCCKFEG(AKEJCMHMCDK BJFNPHMFGCG, AKEJCMHMCDK OAFDDOPKBIO, AKEJCMHMCDK IDKDADCHPHG);

	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMDEFFNCIAA NAPLGMCPHCL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMDEFFNCIAA HFLAOFHLDCL(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPONGLALHNF(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA MOHMMJFCOKF, bool NJBBGNGBLAC);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool CAOKOOMFGHB(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA MOHMMJFCOKF);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int OAAGOMCCKFP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	AKEJCMHMCDK GHBAIDJIINE(IMDEFFNCIAA DPIBKMGPGEE);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool ICMJJJHMCOL(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA NDPMGMCGNIH);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EMDDIIBDLLE(IMDEFFNCIAA IEFFONDNDLL, IMDEFFNCIAA DBLKGKBGOJF);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IMDEFFNCIAA ICOKPMOICHL(IMDEFFNCIAA NDPMGMCGNIH, IMDEFFNCIAA MNMMPGFCAEK);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EBHNHKDJPPO(IMDEFFNCIAA NDPMGMCGNIH, IMDEFFNCIAA MNMMPGFCAEK, out IMDEFFNCIAA CHCCNEOENLG);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class PBEIAIMKDPG
{
	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DEF0", Offset = "0x5E6D2F0", VA = "0x185E6DEF0")]
	public static bool AMFPPNFBIEG(this IAHGCMLPFIJ IFBHCJPNLOA, IMDEFFNCIAA IEFFONDNDLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum NGKKPEFBBLJ
{
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface MGHGCOLAIMC
{
	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<IMDEFFNCIAA> OIFJOJBCFDF(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IMDEFFNCIAA BELJMJPBNEB(IMDEFFNCIAA IEFFONDNDLL, int CJOLACIBAJH);

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OOKCBAOOIEN(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MCGAOALDPDP LHBJILHLGOM(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PKBMBMKDGMG(IMDEFFNCIAA IEFFONDNDLL, MCGAOALDPDP IHHAIAFPENO);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	IMDEFFNCIAA MCKDJKJOHDD(IMDEFFNCIAA IEFFONDNDLL, [Optional] float3? FLBOBIODIJO, [Optional] quaternion? FKJONOBDEOA, [Optional] float3? LECHMDFLPHK);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	IMDEFFNCIAA BIPABBAKKJH(IMDEFFNCIAA IEFFONDNDLL, int CJOLACIBAJH, [Optional] float3? FLBOBIODIJO, [Optional] quaternion? FKJONOBDEOA, [Optional] float3? LECHMDFLPHK);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void FELDKLAOICO(IMDEFFNCIAA IEFFONDNDLL, int CJOLACIBAJH);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EBGFEIPIHEP(IMDEFFNCIAA IEFFONDNDLL);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface LLKMNLCAEHD
{
	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AJPJHOMILOP(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LPFAJOEEDFA(IMDEFFNCIAA IEFFONDNDLL, Transform MPLKBAJKIFD);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface EDLMNAHJFMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	LocalId OJDGMBLEFEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	LocalId BJKCMILPOKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000357")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MCGEMJCLKEF(float3 GBCJGHOCJAP);

	[Cpp2IlInjected.Token(Token = "0x6000358")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOBNJKNKAOH(float3 GBCJGHOCJAP);

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KEOKIJOKPKA(out float3 BHNALBBIKPM, out float3 DHLNIOOELBF);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AHFLBBCFJCE(float3 BHNALBBIKPM, float3 DHLNIOOELBF);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EFKIGENHGJH(Color BHNALBBIKPM, Color DHLNIOOELBF);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EDLMNAHJFMA Instantiate(Transform MPLKBAJKIFD);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface EJOPMKGKJHF
{
	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OAGJEKOOFKN(Transform MPLKBAJKIFD, EDLMNAHJFMA IHHDONDPCCK);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EDLMNAHJFMA MAOHGNMMKKA();
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct IDKEPNNBCPI : IEquatable<IDKEPNNBCPI>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly IDKEPNNBCPI GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	private DFMHGDIOHEN KAPMEBGGGGL
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(RVA = "0x5E67CE0", Offset = "0x5E670E0", VA = "0x185E67CE0")]
		get
		{
			return default(DFMHGDIOHEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public PropType KIIBCJGGHCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(RVA = "0x5E67BD0", Offset = "0x5E66FD0", VA = "0x185E67BD0")]
		get
		{
			return default(PropType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(RVA = "0x5E67C30", Offset = "0x5E67030", VA = "0x185E67C30")]
	public CEFOIIOEBKM MMFCJHLDGHC()
	{
		return default(CEFOIIOEBKM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public IDKEPNNBCPI(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5E67AD0", Offset = "0x5E66ED0", VA = "0x185E67AD0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(IDKEPNNBCPI CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface HMMNCLKALAP
{
	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DFFAHOKEAIO();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class PMBEBKBEBBA
{
	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6E350", Offset = "0x5E6D750", VA = "0x185E6E350")]
	public static void DFFAHOKEAIO(this GameObject NPKKHNDMELE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct MHIMIELMDNN : IEquatable<MHIMIELMDNN>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly MHIMIELMDNN GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600036F")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B4A0", Offset = "0x5E6A8A0", VA = "0x185E6B4A0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(MHIMIELMDNN CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct HEBLJAAECEP : IEquatable<HEBLJAAECEP>
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly HEBLJAAECEP GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000376")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public HEBLJAAECEP(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x5E66F50", Offset = "0x5E66350", VA = "0x185E66F50", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(HEBLJAAECEP CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5E67050", Offset = "0x5E66450", VA = "0x185E67050")]
	public bool JEPMAFFIANP(out Collider COMGKHGIKLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct LKFMCPIAAHE : IEquatable<LKFMCPIAAHE>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly LKFMCPIAAHE GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public IMDEFFNCIAA JDLIOANHLPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(RVA = "0x116F930", Offset = "0x116ED30", VA = "0x18116F930")]
		get
		{
			return default(IMDEFFNCIAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x600037F")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public GNGFCOEBOLO ACNIEJMHLFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000380")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B210", Offset = "0x5E6A610", VA = "0x185E6B210")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public float3 EFLKGNHAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B060", Offset = "0x5E6A460", VA = "0x185E6B060")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5E6ADD0", Offset = "0x5E6A1D0", VA = "0x185E6ADD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public quaternion EPEMEPHGANB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AFE0", Offset = "0x5E6A3E0", VA = "0x185E6AFE0")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AE60", Offset = "0x5E6A260", VA = "0x185E6AE60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public float3 KNPDOCPLFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AD40", Offset = "0x5E6A140", VA = "0x185E6AD40")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5E6AC50", Offset = "0x5E6A050", VA = "0x185E6AC50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public HGGPENBFEMN FDPGEIBPEML
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B3F0", Offset = "0x5E6A7F0", VA = "0x185E6B3F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	private NDHIMEDKFCF EHDGLNGCKLK
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5E6ACE0", Offset = "0x5E6A0E0", VA = "0x185E6ACE0")]
		get
		{
			return default(NDHIMEDKFCF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private IOJIMKEGHJJ MMCFABONKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600038C")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B330", Offset = "0x5E6A730", VA = "0x185E6B330")]
		get
		{
			return default(IOJIMKEGHJJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private DFLCAELPGNE IDCFBCGJNBB
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B390", Offset = "0x5E6A790", VA = "0x185E6B390")]
		get
		{
			return default(DFLCAELPGNE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private CALJFDGBMMM KIOOLIFICOA
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B0F0", Offset = "0x5E6A4F0", VA = "0x185E6B0F0")]
		get
		{
			return default(CALJFDGBMMM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private PJEMCLLIIMD NIGMOILAMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5E6B2D0", Offset = "0x5E6A6D0", VA = "0x185E6B2D0")]
		get
		{
			return default(PJEMCLLIIMD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public LKFMCPIAAHE(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AEE0", Offset = "0x5E6A2E0", VA = "0x185E6AEE0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(LKFMCPIAAHE CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x5E6B150", Offset = "0x5E6A550", VA = "0x185E6B150")]
	public void KCIKJHOHLNO(GNGFCOEBOLO EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5E6ADD0", Offset = "0x5E6A1D0", VA = "0x185E6ADD0")]
	public void DGNPOJOBIOF(float3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5E6AE60", Offset = "0x5E6A260", VA = "0x185E6AE60")]
	public void DNIEECILPMF(quaternion EOEKGHMNIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct FALPHDCACCD : IEquatable<FALPHDCACCD>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly FALPHDCACCD GMBAJGNEMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly IMDEFFNCIAA DPIBKMGPGEE;

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public MLKCCEGIBBL BJGDLDLIDGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000396")]
		[Cpp2IlInjected.Address(RVA = "0x5E5CE60", Offset = "0x5E5C260", VA = "0x185E5CE60")]
		get
		{
			return default(MLKCCEGIBBL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	private KCNJCALDJDJ NPFPJDFDCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x854A20", Offset = "0x853E20", VA = "0x180854A20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private DMFDGDJCGND BFHFEBLPLGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5E61DB0", Offset = "0x5E611B0", VA = "0x185E61DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public bool LFNPMHIDNKO
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5E63A90", Offset = "0x5E62E90", VA = "0x185E63A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public Vector3 EFLKGNHAIEB
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5E62840", Offset = "0x5E61C40", VA = "0x185E62840")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5E648B0", Offset = "0x5E63CB0", VA = "0x185E648B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Quaternion EPEMEPHGANB
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5E62690", Offset = "0x5E61A90", VA = "0x185E62690")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5E631D0", Offset = "0x5E625D0", VA = "0x185E631D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Vector3 JFODMGHNGKD
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5E63F40", Offset = "0x5E63340", VA = "0x185E63F40")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5E61840", Offset = "0x5E60C40", VA = "0x185E61840")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Quaternion FIAPKFGJCNO
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5E613A0", Offset = "0x5E607A0", VA = "0x185E613A0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5E61AC0", Offset = "0x5E60EC0", VA = "0x185E61AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public float KNPPLOABHEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5E62480", Offset = "0x5E61880", VA = "0x185E62480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float NOHOOMPLHOL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5E62E90", Offset = "0x5E62290", VA = "0x185E62E90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public Vector3 KNPDOCPLFLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5E61C00", Offset = "0x5E61000", VA = "0x185E61C00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5E61550", Offset = "0x5E60950", VA = "0x185E61550")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Vector3 JIGLMAGCODI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5E62BA0", Offset = "0x5E61FA0", VA = "0x185E62BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Vector3 DPNJDNAMHPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5E629F0", Offset = "0x5E61DF0", VA = "0x185E629F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Matrix4x4 OGKOPLEKGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5E62110", Offset = "0x5E61510", VA = "0x185E62110")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x1C67400", Offset = "0x1C66800", VA = "0x181C67400")]
	public FALPHDCACCD(IMDEFFNCIAA IEFFONDNDLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x7F1710", Offset = "0x7F0B10", VA = "0x1807F1710", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x5E62590", Offset = "0x5E61990", VA = "0x185E62590", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x5E5CF80", Offset = "0x5E5C380", VA = "0x185E5CF80", Slot = "4")]
	public bool Equals(FALPHDCACCD CCJMBGJFGLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5E5D020", Offset = "0x5E5C420", VA = "0x185E5D020", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x5E64330", Offset = "0x5E63730", VA = "0x185E64330")]
	public IKNPDLBNFFO NAAGGEJJNOJ()
	{
		return default(IKNPDLBNFFO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5E63AE0", Offset = "0x5E62EE0", VA = "0x185E63AE0")]
	public void KEEKFFOEKDG(out Matrix4x4 GFHIMHCOABH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x5E63770", Offset = "0x5E62B70", VA = "0x185E63770")]
	public void JMCLPIHOPEN(out Vector3 PGBNNMPAOJB, out Quaternion MHHDEOGPAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5E63C80", Offset = "0x5E63080", VA = "0x185E63C80")]
	public void KJHNPPDKGGC(out RigidTransform DPDHAJBILNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5E63310", Offset = "0x5E62710", VA = "0x185E63310")]
	public FCFDDHHFPOK IPJJGLGPBLG()
	{
		return default(FCFDDHHFPOK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5E63360", Offset = "0x5E62760", VA = "0x185E63360")]
	public void IPJJGLGPBLG(out FCFDDHHFPOK GKNEBBJOMEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5E644E0", Offset = "0x5E638E0", VA = "0x185E644E0")]
	public Vector3 NEPFEKIICCO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E61FD0", Offset = "0x5E613D0", VA = "0x185E61FD0")]
	public void DGNPOJOBIOF(in Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E61690", Offset = "0x5E60A90", VA = "0x185E61690")]
	public Vector3 APNAHGNKPDL()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E643A0", Offset = "0x5E637A0", VA = "0x185E643A0")]
	public void NDEDGKKJLHM(in Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E61E20", Offset = "0x5E61220", VA = "0x185E61E20")]
	public Quaternion DEGMBBJPOAB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E62190", Offset = "0x5E61590", VA = "0x185E62190")]
	public void DNIEECILPMF(in Quaternion EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E635C0", Offset = "0x5E629C0", VA = "0x185E635C0")]
	public Quaternion JFKCKFFJMIB()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E63480", Offset = "0x5E62880", VA = "0x185E63480")]
	public void JCGAHJPDOKC(in Quaternion EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5E62F90", Offset = "0x5E62390", VA = "0x185E62F90")]
	public float IDLKIHPGEIM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E647A0", Offset = "0x5E63BA0", VA = "0x185E647A0")]
	public void PDKNKLCAIJH(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E64230", Offset = "0x5E63630", VA = "0x185E64230")]
	public float MCOEFEGCGNH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E64690", Offset = "0x5E63A90", VA = "0x185E64690")]
	public void OCBOBCAJCJP(float EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5E63950", Offset = "0x5E62D50", VA = "0x185E63950")]
	public void JOBHCHAIGEC(in Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5E63D90", Offset = "0x5E63190", VA = "0x185E63D90")]
	public Vector3 LEHIMPDPOGB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5E63090", Offset = "0x5E62490", VA = "0x185E63090")]
	public void IDLLJAJBIFP(in Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5E622D0", Offset = "0x5E616D0", VA = "0x185E622D0")]
	public Vector3 EBNDHJEABFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5E61980", Offset = "0x5E60D80", VA = "0x185E61980")]
	public void BOEAABPBMCG(in Vector3 EOEKGHMNIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5E62CE0", Offset = "0x5E620E0", VA = "0x185E62CE0")]
	public Vector3 GNILIHMMOCH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5E640F0", Offset = "0x5E634F0", VA = "0x185E640F0")]
	public void LKLIDOMLFOK(in Vector3 EOEKGHMNIDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface KCNJCALDJDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000125")]
	NIHLJNBPOFF MEMGJEELILM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ObjectType ELDADHCOOMN(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ObjectPrefabType KOHBAPCFJCH(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KJCLACJNMFM(EGAFANECNIE JOJAINIHPBN, HNAAHBOEIIB IOFJBEELAIO);

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	MLKCCEGIBBL LLNJIBPCBHK(IMDEFFNCIAA IEFFONDNDLL, [Optional] object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool GHIFNIOAHNJ(IMDEFFNCIAA IEFFONDNDLL, out HNAAHBOEIIB IOFJBEELAIO);

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MHEEMACCMEC(HNAAHBOEIIB IOFJBEELAIO);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool JJKICHPIFID(IMDEFFNCIAA IEFFONDNDLL, out Transform MPLKBAJKIFD);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool DPOLEJEBKLG(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool HKDFNCGFAEI(LocalId IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool FMHPNKKCIBG(LocalId IEFFONDNDLL, object IJNLJGNNJFA);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	IMDEFFNCIAA CCBLLOFEKLE(EGAFANECNIE JOJAINIHPBN);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	EGAFANECNIE HIOMEAOIBKJ(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "13")]
	AKEJCMHMCDK CCBLLOFEKLE(NativeArray<EGAFANECNIE> JOJAINIHPBN, Allocator NAFCEIMFOBK);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "14")]
	AKEJCMHMCDK HAHDFOJKJJH(NativeArray<EGAFANECNIE> JOJAINIHPBN, NativeArray<KHADDDPLFEJ> KLHOMNDPDHO, Allocator NAFCEIMFOBK);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "15")]
	MLKCCEGIBBL KHLADIJPICC(ObjectPrefabType MKAEEINGAAI, bool MKLAHIJCIOO);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MLKCCEGIBBL KHLADIJPICC(ObjectPrefabType MKAEEINGAAI);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MLKCCEGIBBL EALMMNOEIJI(ObjectPrefabType MKAEEINGAAI);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MLKCCEGIBBL HAHDFOJKJJH(EGAFANECNIE JOJAINIHPBN, ObjectPrefabType MKAEEINGAAI);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "19")]
	FIDOKBMDCIB APFHHINCIBL();

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "20")]
	GNGFCOEBOLO MFLBGAHFCHD();

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "21")]
	MKILFLIPNHF FCFOJLKKPIK(PrimitiveShapeType GOPHAIPNEFK);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void IPBBPFINOPG(AKEJCMHMCDK JFCLEPECFNA);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void BEBNHAAGHMI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ACCEIIFNBPI(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IPBBPFINOPG(IMDEFFNCIAA IEFFONDNDLL);

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "26")]
	AKEJCMHMCDK PKNABCIAKKO(AKEJCMHMCDK LOFDOPKPPHP, Allocator NAFCEIMFOBK);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool JOIGBPFEMLO(IMDEFFNCIAA IEFFONDNDLL);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class INFHOOAGEFE
{
	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5E68840", Offset = "0x5E67C40", VA = "0x185E68840")]
	public static MLKCCEGIBBL KKOJOBJHBPM(this KCNJCALDJDJ BJFNPHMFGCG, LocalId IEFFONDNDLL)
	{
		return default(MLKCCEGIBBL);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5E684A0", Offset = "0x5E678A0", VA = "0x185E684A0")]
	public static IMDEFFNCIAA CCBLLOFEKLE(this KCNJCALDJDJ BJFNPHMFGCG, LocalId IEFFONDNDLL)
	{
		return default(IMDEFFNCIAA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5E685D0", Offset = "0x5E679D0", VA = "0x185E685D0")]
	public static EGAFANECNIE HIOMEAOIBKJ(this KCNJCALDJDJ BJFNPHMFGCG, LocalId IEFFONDNDLL)
	{
		return default(EGAFANECNIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E686F0", Offset = "0x5E67AF0", VA = "0x185E686F0")]
	public static bool JOIGBPFEMLO(this KCNJCALDJDJ BJFNPHMFGCG, EGAFANECNIE JOJAINIHPBN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x2ED0060", Offset = "0x2ECF460", VA = "0x182ED0060")]
	public static T HOLBKFCHBMO<T>(this KCNJCALDJDJ BJFNPHMFGCG, LocalId IEFFONDNDLL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E68360", Offset = "0x5E67760", VA = "0x185E68360")]
	public static FIDOKBMDCIB BBJHGNGKHMC(this KCNJCALDJDJ BJFNPHMFGCG, RigidTransform GKNEBBJOMEJ, [Optional] object IJNLJGNNJFA)
	{
		return default(FIDOKBMDCIB);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E68B00", Offset = "0x5E67F00", VA = "0x185E68B00")]
	public static MKILFLIPNHF PKLECOMLEFG(this KCNJCALDJDJ BJFNPHMFGCG, PrimitiveShapeType ACLDDEDLFPO, RigidTransform GKNEBBJOMEJ, [Optional] object IJNLJGNNJFA)
	{
		return default(MKILFLIPNHF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E68220", Offset = "0x5E67620", VA = "0x185E68220")]
	public static GNGFCOEBOLO APDOGFFHCBJ(this KCNJCALDJDJ BJFNPHMFGCG, RigidTransform GKNEBBJOMEJ, [Optional] object IJNLJGNNJFA)
	{
		return default(GNGFCOEBOLO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E684C0", Offset = "0x5E678C0", VA = "0x185E684C0")]
	private static void GFJAGAFOBKF(MLKCCEGIBBL NANDINEDEHI, RigidTransform GKNEBBJOMEJ, [Optional] object IJNLJGNNJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E688F0", Offset = "0x5E67CF0", VA = "0x185E688F0")]
	internal static CEFOIIOEBKM MKBGBLKLJBO(this KCNJCALDJDJ BJFNPHMFGCG, KPIPIEGADJN FJAKJCMMOPF, [Optional] object IJNLJGNNJFA)
	{
		return default(CEFOIIOEBKM);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class EOHLGAIBEGO
{
	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E61330", Offset = "0x5E60730", VA = "0x185E61330")]
	public static EODEEDFMDKF GGAMEKGGKNL(this IMDEFFNCIAA IDFOGLKIIHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E61280", Offset = "0x5E60680", VA = "0x185E61280")]
	public static EntityManager CPFDJDFIGMC(this IMDEFFNCIAA IDFOGLKIIHM)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x32F3440", Offset = "0x32F2840", VA = "0x1832F3440")]
	public static T EJNKBGFGIOK<T>(this IMDEFFNCIAA IDFOGLKIIHM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x32F4870", Offset = "0x32F3C70", VA = "0x1832F4870")]
	public static bool LAGAJDALCHM<T>(this IMDEFFNCIAA IDFOGLKIIHM) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
internal interface CEEMACKBLBB
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event IAHGCMLPFIJ.IBDLNCCKFEG EMOFPMCCIJM;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[GEDFJDPFIHC(FCAJHDGOHAJ.LoadInstance)]
public interface DPIAMAPHADI
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	bool JFANNAKAECE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F1")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	IMDEFFNCIAA JKEKPGLOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F2")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F3")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	MLKCCEGIBBL OMNIJPALDPN
	{
		[Cpp2IlInjected.Token(Token = "0x60003F4")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F5")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	MLKCCEGIBBL PIMOALJCGEL
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PMHEOLOIOJE PCNPPGNIIDA;

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IMDEFFNCIAA ICOKPMOICHL(IMDEFFNCIAA NDPMGMCGNIH, IMDEFFNCIAA MNMMPGFCAEK);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EBHNHKDJPPO(IMDEFFNCIAA NDPMGMCGNIH, IMDEFFNCIAA MNMMPGFCAEK, out IMDEFFNCIAA CHCCNEOENLG);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CBNIPEINBEP();

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void OKMLAFPOOKF();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BFIJPGMJHJP(IMDEFFNCIAA ICMDHGDOHEC);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void PMHEOLOIOJE(MLKCCEGIBBL MKINKLKGMNF, MLKCCEGIBBL CKNGGLCEPIE);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class OOGNNGDBFLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D9B0", Offset = "0x5E6CDB0", VA = "0x185E6D9B0")]
	public static bool CDKMFKAGIOH(this DPIAMAPHADI JPAJEGEFMCL, MLKCCEGIBBL ICMDHGDOHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(RVA = "0x5E6DA40", Offset = "0x5E6CE40", VA = "0x185E6DA40")]
	public static bool DNOMIBILEFG(this DPIAMAPHADI JPAJEGEFMCL, IMDEFFNCIAA ICMDHGDOHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5E6D8B0", Offset = "0x5E6CCB0", VA = "0x185E6D8B0")]
	public static bool AAKJNHOMEKI(this DPIAMAPHADI JPAJEGEFMCL, IMDEFFNCIAA ICMDHGDOHEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface LGJPMHDMNKE : IEnumerable<FKGHEBGADOE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	int KLCJBBHGHFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000403")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	FKGHEBGADOE KPEHPIIHMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000404")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FKGHEBGADOE ACEIDCHGHEK(GPHNDJBMNHN CDJGAGCIMIF);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CDCHAKEJFEI HLDEFGJINDN(GPHNDJBMNHN CDJGAGCIMIF);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FANAINOAFEI
{
	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x29F7BF0", Offset = "0x29F6FF0", VA = "0x1829F7BF0")]
	public static global::OGDHIPMPCDN<T> ACEIDCHGHEK<T>(this LGJPMHDMNKE PGJHKOKFEAD, GPHNDJBMNHN LMAOKJPAKEM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x29F7D20", Offset = "0x29F7120", VA = "0x1829F7D20")]
	public static global::OGDHIPMPCDN<T> ACEIDCHGHEK<T>(this LGJPMHDMNKE PGJHKOKFEAD, global::BLOOENFJLDB<T> LMAOKJPAKEM) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x29F7E70", Offset = "0x29F7270", VA = "0x1829F7E70")]
	public static CDCHAKEJFEI HLDEFGJINDN<T>(this LGJPMHDMNKE PGJHKOKFEAD, global::BLOOENFJLDB<T> LMAOKJPAKEM) where T : struct
	{
		return default(CDCHAKEJFEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface HMOIJFLCHDM : PNDAGNLAKFB
{
	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MMDJEOKLOHM NLNHOIGNPPN(Entity HHCOBCONNMJ);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAECMOHABHD(NativeArray<MMDJEOKLOHM> CAMEJDCLNIH, NativeArray<AANEMHNBOAM> OFDGOIDMBAJ);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AIDFBANEAII(MMDJEOKLOHM KJJOLPFLKFF);

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool EKPIMDJIKLO(MMDJEOKLOHM KJJOLPFLKFF, out Collider COMGKHGIKLH);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct AANEMHNBOAM : ISystemStateComponentData, IComponentData, IEquatable<AANEMHNBOAM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 NFEOJEHGHBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 NFKHCKJBKAA;

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x17149A0", Offset = "0x1713DA0", VA = "0x1817149A0", Slot = "4")]
	public bool Equals(AANEMHNBOAM CCJMBGJFGLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JPJMKEMBNIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Guid LKDOBHNFOAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string EGCMLONOLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector3 FLBOBIODIJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Quaternion FKJONOBDEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector3 LECHMDFLPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int AEODNLEDAMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Dictionary<string, object> IHHAIAFPENO;

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5E69C50", Offset = "0x5E69050", VA = "0x185E69C50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5E69AC0", Offset = "0x5E68EC0", VA = "0x185E69AC0")]
	private static string BIMBBCFDNKJ(Dictionary<string, object> HEIAHJNMBMG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum MHIIMEBJALJ
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum HLBAANPFGCA
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class IOOKDLFMEOB
{
	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x484BEA0", Offset = "0x484B2A0", VA = "0x18484BEA0")]
	public static bool JMPJBBJCFGL(this HLBAANPFGCA ONBHBHIHHNE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface HDJKKFAMPLG : DLMACKADCNB, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[Flags]
public enum EDAHLHGICCK
{
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	NotifyEnabled = 2,
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	NotifyInstantiated = 0x20,
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	DisposeProtobuf = 0x40,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	NotifyCompleted = 0x80,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	WorldPhasesMaster = 0xFF,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	WorldPhasesClient = 0xF7,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	AdditivePhases = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
[Flags]
public enum CFAONEGLNIC
{
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	SetEnabledInRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	PostInstantiate = 0x30,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	LoadCompleted = 0xC0,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	All = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public interface KACLJEHKNGB : DLMACKADCNB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	JCIDMIDFHPP FJCBGMPFHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000415")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INDKPGEMFJE();

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ANCGOHHIONL();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface JCIDMIDFHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PBBLKCOOPIO(Guid PMOIDBEHJHP, out Guid ADPDPMGCAGF);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface GOKJBKPBAPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	DOFBAANOHKO KFALBLCEICL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString EJEONOACJJL();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface DLMACKADCNB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	IEnumerable<JPJMKEMBNIL> FPICKFHGNFC
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	FGOLBLJNLDD FNABKGOKJJA
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	LocalId GOLCLEJNFMI
	{
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	DOFBAANOHKO GOHMOJCJLOH
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	Task FCDCNDEKMOI
	{
		[Cpp2IlInjected.Token(Token = "0x600041F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NIJHMMDNNAP(EDAHLHGICCK DHJEGMLIGNE);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface HDBMIJPPAMP
{
	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NPPPHGADINB(EGAFANECNIE EJEGPKKKCNN, CDCHAKEJFEI GAEHKOIHPJO, ReadOnlySpan<byte> CMKIHEFHAGD, ReadOnlySpan<byte> PNAKPPLALMB);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CMJJBBBOBCD(EGAFANECNIE EJEGPKKKCNN, CDCHAKEJFEI GAEHKOIHPJO);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BFFDKGIHOIC(EGAFANECNIE EJEGPKKKCNN, CDCHAKEJFEI GAEHKOIHPJO, ReadOnlySpan<byte> PNAKPPLALMB);

	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DIOGFOKEDGP(EGAFANECNIE EJEGPKKKCNN, CDCHAKEJFEI GAEHKOIHPJO, Span<byte> CMKIHEFHAGD, Span<byte> PNAKPPLALMB);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class PDMOMECGEEN
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x24D73F0", Offset = "0x24D67F0", VA = "0x1824D73F0")]
	public static bool DIOGFOKEDGP<T>(this HDBMIJPPAMP ICENPBFBJDA, EGAFANECNIE EJEGPKKKCNN, CDCHAKEJFEI GAEHKOIHPJO, out T CMKIHEFHAGD, out T PNAKPPLALMB) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x24D72C0", Offset = "0x24D66C0", VA = "0x1824D72C0")]
	public static bool BFFDKGIHOIC<T>(this HDBMIJPPAMP ICENPBFBJDA, EGAFANECNIE EJEGPKKKCNN, CDCHAKEJFEI GAEHKOIHPJO, T PNAKPPLALMB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public enum OFDEKMHLEBD
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	End,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface JFACNAKHIDK : global::OJLGHNBMEEP<JFACNAKHIDK>
{
	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "0")]
	CDCHAKEJFEI HLDEFGJINDN(GPHNDJBMNHN LMAOKJPAKEM);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KJCLACJNMFM(CDCHAKEJFEI IDFOGLKIIHM, DIMDMNDBFAA KJDHELOCEAC);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool EPJAPKGCCDE(CDCHAKEJFEI IDFOGLKIIHM, out DIMDMNDBFAA KJDHELOCEAC);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class JKJLHGMMNGH
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x20D5D90", Offset = "0x20D5190", VA = "0x1820D5D90")]
	public static CDCHAKEJFEI HLDEFGJINDN<T>(this JFACNAKHIDK PGJHKOKFEAD, global::BLOOENFJLDB<T> LMAOKJPAKEM)
	{
		return default(CDCHAKEJFEI);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	public static CDCHAKEJFEI KJCLACJNMFM<T>(this JFACNAKHIDK PGJHKOKFEAD, global::BLOOENFJLDB<T> LMAOKJPAKEM, DIMDMNDBFAA KJDHELOCEAC) where T : struct
	{
		return default(CDCHAKEJFEI);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface FNMHMHJDDEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000133")]
	uint PDHANFMEBME
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct MJNBLKIGGLP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public GOPENNNMOAJ NNEEJCHOPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public ReadOnlyMemory<byte> PCDLJHELPEC;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface EABIBAMNEOA
{
	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DMNGMHPFCEL(GOPENNNMOAJ NNEEJCHOPPB, ReadOnlySpan<byte> PCDLJHELPEC);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public delegate bool BLMKLMGLAIA(HDBMIJPPAMP EBJEIKKNDFH, in GGCEFKOAKOD EOEKGHMNIDN);
[Cpp2IlInjected.Token(Token = "0x2000096")]
public delegate bool OLDNMBAHNOD<T>(HDBMIJPPAMP EBJEIKKNDFH, in T EOEKGHMNIDN);
[Cpp2IlInjected.Token(Token = "0x2000097")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface ACAFDBBGGGE
{
	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KJCLACJNMFM(CDCHAKEJFEI GAEHKOIHPJO, Type GCHOJLFKHAJ, BLMKLMGLAIA EMJGHIOBMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ANCDDDOJGBJ(CDCHAKEJFEI GAEHKOIHPJO, out BLMKLMGLAIA EMJGHIOBMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class ECDFGGJMEAD
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class MAFMMPDPDGB<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		public global::OLDNMBAHNOD<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600043A")]
		[Cpp2IlInjected.Address(RVA = "0x1939780", Offset = "0x1938B80", VA = "0x181939780")]
		public MAFMMPDPDGB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600043B")]
		[Cpp2IlInjected.Address(RVA = "0x4769900", Offset = "0x4768D00", VA = "0x184769900")]
		internal bool LBMGHMFAMFH(HDBMIJPPAMP pendingList, in GGCEFKOAKOD value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x32EE500", Offset = "0x32ED900", VA = "0x1832EE500")]
	public static void KJCLACJNMFM<T>(this ACAFDBBGGGE EHCALDODJBD, CDCHAKEJFEI GAEHKOIHPJO, global::OLDNMBAHNOD<T> EMJGHIOBMBJ) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000439")]
	[Cpp2IlInjected.Address(RVA = "0x5E60DE0", Offset = "0x5E601E0", VA = "0x185E60DE0")]
	public static bool AMFBJCEKDFE(this ACAFDBBGGGE EHCALDODJBD, HDBMIJPPAMP EBJEIKKNDFH, CDCHAKEJFEI GAEHKOIHPJO, in GGCEFKOAKOD EOEKGHMNIDN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct GOPENNNMOAJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public uint FIAIJEPBAMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public int IIDMPBCGJLN;

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x83CF20", Offset = "0x83C320", VA = "0x18083CF20")]
	public GOPENNNMOAJ(uint FIAIJEPBAMD, int IIDMPBCGJLN)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C80", Offset = "0x5E66080", VA = "0x185E66C80")]
	public static bool MHCPIEGNOBB(in GOPENNNMOAJ JMFOJDPECFB, in GOPENNNMOAJ PHAPIDHPFME)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5E66BC0", Offset = "0x5E65FC0", VA = "0x185E66BC0", Slot = "0")]
	public override bool Equals(object GHHNOPFOGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(RVA = "0x5E66C50", Offset = "0x5E66050", VA = "0x185E66C50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(RVA = "0x5E66CA0", Offset = "0x5E660A0", VA = "0x185E66CA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface DGOELAKPKOF
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GOPENNNMOAJ DFAGOKFOBFN(ReadOnlySpan<byte> PCDLJHELPEC);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface DIMDMNDBFAA
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	Type BCKJJBGMBAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void INEKOHCFCOE(ref LLDKDABBJGA KHMLBMENKDA, Span<byte> ICMDHGDOHEC);

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AKAHDAOKFEM(ref ABEOAGNMLCL NJDPCCBFDCA, ReadOnlySpan<byte> NNEEJCHOPPB);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class JIOBKJCDHJH
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public delegate void PJJMFONPAJK(GOPENNNMOAJ LOLIOKKJLEH, ReadOnlySpan<byte> PCDLJHELPEC);
[Cpp2IlInjected.Token(Token = "0x200009F")]
[GEDFJDPFIHC(FCAJHDGOHAJ.OMRoom)]
public interface APMBJAJECFF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PJEEADOEAED(GOPENNNMOAJ LOLIOKKJLEH, ReadOnlySpan<byte> PCDLJHELPEC);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class AOIEPJGNBNP
{
	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
	public AOIEPJGNBNP()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
	public class __BB_OBFUSCATOR_VERSION_3_9_9
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
