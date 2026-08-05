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
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface OJNFEIACNDC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEOHHDALEJM(in float3 FEEJKCLONBL, in float3 DMABJFINPCN, float HLNABDEKNDG, Allocator FIPHDKMNFDJ, out NativeArray<Entity> KHPJJPHILOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface PHFMPNDCPCM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	Guid NCJJKPCOEPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AGFAIPKNDEA(Guid OEMLDONMOOC, Guid NFGLNLMMHHC);

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DOMDILBIGND(EGCGFMJAHFA ICAGNMPCOIF);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface EHMBLNLEMLJ : GKPDPGNIGKB<EGCGFMJAHFA>, DCMKKBFMJKI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OMOMEIBPMLA<T> : PBPDJLMHCMH<EGCGFMJAHFA, T>, GKPDPGNIGKB<EGCGFMJAHFA>, DCMKKBFMJKI, IDisposable, EHMBLNLEMLJ where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class CLMGLEAEIKN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E882D0", Offset = "0x2E870D0", VA = "0x182E882D0")]
	public static T KOLGIMOOKDG<T>(this GKPDPGNIGKB<EGCGFMJAHFA> ICNBGPBCJEH, EGCGFMJAHFA OEJOEELBGEB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2E88300", Offset = "0x2E87100", VA = "0x182E88300")]
	public static bool MDELLMLPPIN<T>(this GKPDPGNIGKB<EGCGFMJAHFA> ICNBGPBCJEH, EGCGFMJAHFA OEJOEELBGEB, in T ALOICDECJNJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface MBLNLHCNOCK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Func<PFJNNBEFCFI> KGLCPGPOBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<EGCGFMJAHFA, EGCGFMJAHFA> ICOIFMIIDPO;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<EGCGFMJAHFA, EGCGFMJAHFA> FCEDKIKAIDL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<EGCGFMJAHFA, EGCGFMJAHFA, EGCGFMJAHFA> ELFPHODILPM;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<EGCGFMJAHFA> AGEPHCDOIKA;

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color NPJLJPFIPLG(EGCGFMJAHFA OEJOEELBGEB, int JMCPKAAPFCJ);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 HKFPPJCIKCA(EGCGFMJAHFA OEJOEELBGEB, int JMCPKAAPFCJ);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool HPNCDJANHPE(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA DFIKILGOIKP);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "13")]
	EGCGFMJAHFA GLKKHIBLIFO(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<EGCGFMJAHFA> AMHIKKOCADN(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "15")]
	EGCGFMJAHFA DPACHOKFHIC(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void AOBNGCJHLHP(EGCGFMJAHFA OEJOEELBGEB, Vector3 EFFKJLOEHMK, Quaternion EGKEAMANCEN);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void COGFIEEGMJN(EGCGFMJAHFA OEJOEELBGEB, float KHGEHKDLIDI);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool FOKBNEFGGBE(EGCGFMJAHFA OEJOEELBGEB, out RigidTransform CBGLLJEDBAF);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool EMPNGGFPEIN(EGCGFMJAHFA OEJOEELBGEB, out float OGIJBIJKDMI);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 GFFMEGADEBI(AMAAAIKKHJC HMNFOOCKJED);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion JNHDOGEJCGC(AMAAAIKKHJC HMNFOOCKJED);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CBEBKPDANKH
{
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface KICKHFBOBCH
{
	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CEOHHDALEJM(in NativeArray<Entity> KHPJJPHILOJ, in float3 FEEJKCLONBL, in float3 DMABJFINPCN, in NativeArray<GGHGDNIFHLN> MKCKBHCLGNH);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface LDHHHBGOMGM
{
	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FHFELKAFFJP(EGCGFMJAHFA BBBLGPNEOJP, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KDMJFOLIMKH(EGCGFMJAHFA BBBLGPNEOJP, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void KDJMFNBBJKG(EGCGFMJAHFA BBBLGPNEOJP, int KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
[DefaultMember("Item")]
public interface PNBGPAOKCJJ : IEnumerable<CPBOEHNKFNO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	NativeBitArray EGBGNNCPFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeArray<int> OFDECLIOMCP
	{
		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	CPBOEHNKFNO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	CPBOEHNKFNO MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CPBOEHNKFNO AKDLJNBFGMH(KDKGBCPHDHM LNCLBGGHDHA);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GPEHGPANNHP HIGAAKNJNFP(KDKGBCPHDHM LNCLBGGHDHA);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class KLCDIGEAPHP
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	public static NACGDLPFDKA<T> AKDLJNBFGMH<T>(this PNBGPAOKCJJ FMCLAGCEHFA, KDKGBCPHDHM PPPOJKMOIGD) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public readonly struct CEFALCKKLFO : IEquatable<CEFALCKKLFO>
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CEFALCKKLFO EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public CEFALCKKLFO(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D300", Offset = "0x5E9C100", VA = "0x185E9D300", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(CEFALCKKLFO FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct DJMDNAAIBEF : IEquatable<DJMDNAAIBEF>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly DJMDNAAIBEF EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E3D0", Offset = "0x5E9D1D0", VA = "0x185E9E3D0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(DJMDNAAIBEF FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface DNLMHELBKBF
{
	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	HDCBLGDDJBM EOLAFOBPBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool KAFLNADKNPH(PPDNOHKLMNC NNKJCELFGML, GPEHGPANNHP ICNBGPBCJEH);

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ILMPLJKLDCF(PPDNOHKLMNC NNKJCELFGML, Span<GPEHGPANNHP> FMCLAGCEHFA, bool EKCFONGLGMD);

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NAAGPGMBEJE(NativeArray<PPDNOHKLMNC> NNCDHPNBPLI);
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public readonly struct HDCBLGDDJBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly NativeBitArray LGLFGMIJLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly NativeHashMap<PPDNOHKLMNC, int> HECMCAKIKDF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool LELEOIAOIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5130", Offset = "0x5EA3F30", VA = "0x185EA5130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x866BB0", Offset = "0x8659B0", VA = "0x180866BB0")]
	public HDCBLGDDJBM(NativeBitArray LGLFGMIJLIH, NativeHashMap<PPDNOHKLMNC, int> HECMCAKIKDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5150", Offset = "0x5EA3F50", VA = "0x185EA5150")]
	public bool KAFLNADKNPH(PPDNOHKLMNC NNKJCELFGML, GPEHGPANNHP ICNBGPBCJEH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PJMAEMDPCFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JDCDHMJMEPN : GJPHEECHBKC, IEquatable<JDCDHMJMEPN>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly JDCDHMJMEPN EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject KKHNMHOFPEF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA78A0", Offset = "0x5EA66A0", VA = "0x185EA78A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public PPDNOHKLMNC JGBKBENHJGK
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7A80", Offset = "0x5EA6880", VA = "0x185EA7A80")]
		get
		{
			return default(PPDNOHKLMNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public ObjectType HNANODGHDHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x5EA75C0", Offset = "0x5EA63C0", VA = "0x185EA75C0")]
		get
		{
			return default(ObjectType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ObjectPrefabType BJDJOGKNJJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7690", Offset = "0x5EA6490", VA = "0x185EA7690")]
		get
		{
			return default(ObjectPrefabType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AFKOHLOPMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5EA72F0", Offset = "0x5EA60F0", VA = "0x185EA72F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BKMGILGOBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6EA0", Offset = "0x5EA5CA0", VA = "0x185EA6EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool CJEOBILJLKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6E80", Offset = "0x5EA5C80", VA = "0x185EA6E80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool CLEHHJIONLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7B50", Offset = "0x5EA6950", VA = "0x185EA7B50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PMFNANCJOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7A60", Offset = "0x5EA6860", VA = "0x185EA7A60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool FAGIICAKLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7880", Offset = "0x5EA6680", VA = "0x185EA7880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool JNBFJLIKPJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5EA72A0", Offset = "0x5EA60A0", VA = "0x185EA72A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool CMONDFCIGCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7310", Offset = "0x5EA6110", VA = "0x185EA7310")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public FPPAKLLCHDB MHCFENJMBEE
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(FPPAKLLCHDB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public IKEIDIOICAA JIKNKMEPIAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(IKEIDIOICAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public OJIBEGMBHLE GLFPNGNJCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(OJIBEGMBHLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PFAKNPABKNC JMFNGDMGBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(PFAKNPABKNC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public JGNPEOBNBIM FADCHLOJMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JGNPEOBNBIM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public DAPGHFKBGOH FPJMEHOGFCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(DAPGHFKBGOH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public DOANLHAAJKI AAJGBHPMBPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(DOANLHAAJKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool NFHLHGHAJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7410", Offset = "0x5EA6210", VA = "0x185EA7410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LHKAFGONMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5EA79A0", Offset = "0x5EA67A0", VA = "0x185EA79A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool JJDPHCPGBAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x83B660", Offset = "0x83A460", VA = "0x18083B660", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0", Slot = "5")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public FKEFBLGGPHP IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(FKEFBLGGPHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public KIJGNLIGAMO HMGBIMLLIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(KIJGNLIGAMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
	public static JDCDHMJMEPN HAJGNNHEPJI(EGCGFMJAHFA BBBLGPNEOJP)
	{
		return default(JDCDHMJMEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6F50", Offset = "0x5EA5D50", VA = "0x185EA6F50")]
	public IFHGODGECMD DALCIJOJEDL()
	{
		return default(IFHGODGECMD);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA79F0", Offset = "0x5EA67F0", VA = "0x185EA79F0")]
	public GCGKCAKBOCM NOBCNCGANDI()
	{
		return default(GCGKCAKBOCM);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7760", Offset = "0x5EA6560", VA = "0x185EA7760")]
	public CEFALCKKLFO JGBFBDNKPPH()
	{
		return default(CEFALCKKLFO);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7080", Offset = "0x5EA5E80", VA = "0x185EA7080")]
	public MOGDFBPMCIK DMJJHBDGNAC()
	{
		return default(MOGDFBPMCIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6EC0", Offset = "0x5EA5CC0", VA = "0x185EA6EC0")]
	public AMAAAIKKHJC BPDKEKKABHF()
	{
		return default(AMAAAIKKHJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5EA74E0", Offset = "0x5EA62E0", VA = "0x185EA74E0")]
	public void HMJAFGNACLP([Optional] object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5EA71F0", Offset = "0x5EA5FF0", VA = "0x185EA71F0")]
	public bool FNBJOGDEBIO(object GKNJCIECGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA77D0", Offset = "0x5EA65D0", VA = "0x185EA77D0")]
	public bool KFGPKNPHNIL(object GKNJCIECGND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7B70", Offset = "0x5EA6970", VA = "0x185EA7B70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public JDCDHMJMEPN(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3B0", Offset = "0x5E9A1B0", VA = "0x185E9B3B0")]
	public static bool HAJGNNHEPJI(JDCDHMJMEPN KKLNCEHOHED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
	public static EGCGFMJAHFA HAJGNNHEPJI(JDCDHMJMEPN KKLNCEHOHED)
	{
		return default(EGCGFMJAHFA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6FE0", Offset = "0x5EA5DE0", VA = "0x185EA6FE0")]
	public static bool DDONPFMGGHF(JDCDHMJMEPN IKGMJGNOMBA, JDCDHMJMEPN GOEPIJCAGGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7330", Offset = "0x5EA6130", VA = "0x185EA7330")]
	public static bool HDFILCNJOKD(JDCDHMJMEPN IKGMJGNOMBA, JDCDHMJMEPN GOEPIJCAGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5EA70F0", Offset = "0x5EA5EF0", VA = "0x185EA70F0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "6")]
	public bool Equals(JDCDHMJMEPN FGBEDAPNDEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void EHJKOOJALKD(EGCGFMJAHFA OEJOEELBGEB, GPEHGPANNHP BOKNODKDNKE, BIABKMPNANG PMPNCLBDLNA, BIABKMPNANG ECOPHBMBIHG);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct CBHADPABMOJ : IList<EGCGFMJAHFA>, ICollection<EGCGFMJAHFA>, IEnumerable<EGCGFMJAHFA>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct EKFMFAKMAMA : IEnumerator<EGCGFMJAHFA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly CDNFKKBDBMA FMGNJAHHCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator HBEBKLDONPL;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public EGCGFMJAHFA CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FD60", Offset = "0x5E9EB60", VA = "0x185E9FD60", Slot = "4")]
			get
			{
				return default(EGCGFMJAHFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5E9FC80", Offset = "0x5E9EA80", VA = "0x185E9FC80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x2643940", Offset = "0x2642740", VA = "0x182643940")]
		public EKFMFAKMAMA(CDNFKKBDBMA FMGNJAHHCOF, NativeArray<LocalId>.Enumerator HBEBKLDONPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FBC0", Offset = "0x5E9E9C0", VA = "0x185E9FBC0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FC00", Offset = "0x5E9EA00", VA = "0x185E9FC00", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5E9FC40", Offset = "0x5E9EA40", VA = "0x185E9FC40", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly CDNFKKBDBMA FMGNJAHHCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> HMMLJFMHHMO;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public EGCGFMJAHFA MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CC30", Offset = "0x5E9BA30", VA = "0x185E9CC30", Slot = "4")]
		get
		{
			return default(EGCGFMJAHFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CCB0", Offset = "0x5E9BAB0", VA = "0x185E9CCB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C8A0", Offset = "0x5E9B6A0", VA = "0x185E9C8A0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int BBPCGKEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5E9C8A0", Offset = "0x5E9B6A0", VA = "0x185E9C8A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool CKPLHALPLKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x831840", Offset = "0x830640", VA = "0x180831840", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CBA0", Offset = "0x5E9B9A0", VA = "0x185E9CBA0")]
	public CBHADPABMOJ(CDNFKKBDBMA FMGNJAHHCOF, int CNKKOGIEKAD, Allocator FIPHDKMNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C400", Offset = "0x5E9B200", VA = "0x185E9C400")]
	public CDOABBFCKIF CCKPJDIPPOK()
	{
		return default(CDOABBFCKIF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C480", Offset = "0x5E9B280", VA = "0x185E9C480", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C4C0", Offset = "0x5E9B2C0", VA = "0x185E9C4C0", Slot = "13")]
	public bool Contains(EGCGFMJAHFA IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C520", Offset = "0x5E9B320", VA = "0x185E9C520", Slot = "14")]
	public void CopyTo(EGCGFMJAHFA[] PKPHLPFOPGM, int GIDMKIFNOAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C3A0", Offset = "0x5E9B1A0", VA = "0x185E9C3A0", Slot = "11")]
	public void Add(EGCGFMJAHFA IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C790", Offset = "0x5E9B590", VA = "0x185E9C790", Slot = "7")]
	public void Insert(int FHOMILACEHB, EGCGFMJAHFA IGAFFKCMBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C930", Offset = "0x5E9B730", VA = "0x185E9C930", Slot = "15")]
	public bool Remove(EGCGFMJAHFA IGAFFKCMBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C730", Offset = "0x5E9B530", VA = "0x185E9C730", Slot = "6")]
	public int IndexOf(EGCGFMJAHFA IGAFFKCMBEK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C8E0", Offset = "0x5E9B6E0", VA = "0x185E9C8E0", Slot = "8")]
	public void RemoveAt(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C6F0", Offset = "0x5E9B4F0", VA = "0x185E9C6F0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C810", Offset = "0x5E9B610", VA = "0x185E9C810")]
	public EKFMFAKMAMA JOJADCJMMBH()
	{
		return default(EKFMFAKMAMA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9C9C0", Offset = "0x5E9B7C0", VA = "0x185E9C9C0", Slot = "16")]
	private IEnumerator<EGCGFMJAHFA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CAB0", Offset = "0x5E9B8B0", VA = "0x185E9CAB0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface HJOIEGBCDDK
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CEOHHDALEJM(in float3 FEEJKCLONBL, in float3 DMABJFINPCN, float HLNABDEKNDG, out GGHGDNIFHLN ELJAAMIKOKG, out EGCGFMJAHFA PHFCPLFJKGF);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct BNPEKHGFBMJ : IEquatable<BNPEKHGFBMJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly BNPEKHGFBMJ EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private HPJHHHKBOLM JBPIMCMKPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B330", Offset = "0x5E9A130", VA = "0x185E9B330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public GCGKCAKBOCM CGFILMELHOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(GCGKCAKBOCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public HINIBFNNAPD EJOIMLGLFBP
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BBF0", Offset = "0x5E9A9F0", VA = "0x185E9BBF0")]
		get
		{
			return default(HINIBFNNAPD);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9BAF0", Offset = "0x5E9A8F0", VA = "0x185E9BAF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<IMCADCANEEI> MPOPJHCLAOE
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B910", Offset = "0x5E9A710", VA = "0x185E9B910")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public IMCADCANEEI MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B6C0", Offset = "0x5E9A4C0", VA = "0x185E9B6C0")]
		get
		{
			return default(IMCADCANEEI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B3C0", Offset = "0x5E9A1C0", VA = "0x185E9B3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public FKEFBLGGPHP IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(FKEFBLGGPHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9B8C0", Offset = "0x5E9A6C0", VA = "0x185E9B8C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B4A0", Offset = "0x5E9A2A0", VA = "0x185E9B4A0")]
	public IMCADCANEEI IKKKAIAJCBJ(float3? IHHJAKDKGPC, [Optional] quaternion? EMNOFGLPALH, [Optional] Vector3? OLFLAEBOOJB)
	{
		return default(IMCADCANEEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AF10", Offset = "0x5E99D10", VA = "0x185E9AF10")]
	public IMCADCANEEI EBEEDMALMKL(int FHOMILACEHB, float3? IHHJAKDKGPC, [Optional] quaternion? EMNOFGLPALH, [Optional] Vector3? OLFLAEBOOJB)
	{
		return default(IMCADCANEEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B240", Offset = "0x5E9A040", VA = "0x185E9B240")]
	public void FOPGPDPHJCG(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B7E0", Offset = "0x5E9A5E0", VA = "0x185E9B7E0")]
	public void LEKENBMMMEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public BNPEKHGFBMJ(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3B0", Offset = "0x5E9A1B0", VA = "0x185E9B3B0")]
	public static bool HAJGNNHEPJI(BNPEKHGFBMJ KKLNCEHOHED)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x5E9AE70", Offset = "0x5E99C70", VA = "0x185E9AE70")]
	public static bool DDONPFMGGHF(BNPEKHGFBMJ IKGMJGNOMBA, BNPEKHGFBMJ GOEPIJCAGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B140", Offset = "0x5E99F40", VA = "0x185E9B140", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(BNPEKHGFBMJ FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface KHJOHKIKAGA
{
	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EJAKNKAPPBM(EGCGFMJAHFA OEJOEELBGEB, out Collider DMENEKHAENG);

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject OLBBGFEBOIK(EGCGFMJAHFA EILJLCIDHPI, GameObject NDMDIDJLLII, Vector3 HCAOBCCCBLG, Quaternion FEODNHIOGPN);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MNBKFOGKHFB(GameObject DMENEKHAENG);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider AGPPKIMDEKD<TCollider>(GameObject EEONCGBBGIE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NFDNALJMMFA(Collider DMENEKHAENG);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject AOBNMJANOJH<TCollider>(string PPPOJKMOIGD) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public interface KIIABIGJHJE : GKPDPGNIGKB<PPDNOHKLMNC>, DCMKKBFMJKI, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CKCBAJPMJCE<T> : PBPDJLMHCMH<PPDNOHKLMNC, T>, GKPDPGNIGKB<PPDNOHKLMNC>, DCMKKBFMJKI, IDisposable, KIIABIGJHJE where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public static class GIJOGBBKKBP
{
	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x346E790", Offset = "0x346D590", VA = "0x18346E790")]
	public static bool BBJAFPAMNLG<T>(this GKPDPGNIGKB<PPDNOHKLMNC> ICNBGPBCJEH, PPDNOHKLMNC NNKJCELFGML, out T KKLNCEHOHED) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x346C850", Offset = "0x346B650", VA = "0x18346C850")]
	public static bool MDELLMLPPIN<T>(this GKPDPGNIGKB<PPDNOHKLMNC> ICNBGPBCJEH, PPDNOHKLMNC NNKJCELFGML, in T ALOICDECJNJ) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public readonly struct DOANLHAAJKI : IEquatable<DOANLHAAJKI>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly DOANLHAAJKI EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	private HDIJNAIPGLJ NKMDKLKODCH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EEA0", Offset = "0x5E9DCA0", VA = "0x185E9EEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public bool AMJMJNEPNOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EB90", Offset = "0x5E9D990", VA = "0x185E9EB90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public Guid JCDIBPGNDMO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E9C0", Offset = "0x5E9D7C0", VA = "0x185E9E9C0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public bool JKONOFLGGPP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EAB0", Offset = "0x5E9D8B0", VA = "0x185E9EAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public Guid LMPHODKODND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5E9E700", Offset = "0x5E9D500", VA = "0x185E9E700")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5E9EC70", Offset = "0x5E9DA70", VA = "0x185E9EC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x5E9ECC0", Offset = "0x5E9DAC0", VA = "0x185E9ECC0")]
	public bool MNDFFPIMLPI(out Guid MMKFOAANGLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EDB0", Offset = "0x5E9DBB0", VA = "0x185E9EDB0")]
	public void OIMPFOIJIFF(Guid IEGGAJNPOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E7F0", Offset = "0x5E9D5F0", VA = "0x185E9E7F0")]
	public bool FCEIPIMJCBG(out Guid IAHLLEDDMDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E510", Offset = "0x5E9D310", VA = "0x185E9E510")]
	public void AKGDEPJOLFJ(Guid IEGGAJNPOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E8E0", Offset = "0x5E9D6E0", VA = "0x185E9E8E0")]
	public void GEEDKAEGDCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public DOANLHAAJKI(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E600", Offset = "0x5E9D400", VA = "0x185E9E600", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(DOANLHAAJKI FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct IKEIDIOICAA : IEquatable<IKEIDIOICAA>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly IKEIDIOICAA EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6520", Offset = "0x5EA5320", VA = "0x185EA6520")]
	public void MBKJDOLMADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6350", Offset = "0x5EA5150", VA = "0x185EA6350")]
	public void EOKLDLIBOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public IKEIDIOICAA(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6420", Offset = "0x5EA5220", VA = "0x185EA6420", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(IKEIDIOICAA FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DLFCAAPBCNB : GJPHEECHBKC
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	KKFCHOEILIG HIPGIFPPDHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	bool BKHAEAHAMGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	GameObject KKHNMHOFPEF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<DLFCAAPBCNB> OKDOLLENOBO;

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(HOLKDEPHBHG JNDJAEGBBCD, EGCGFMJAHFA HANCCDEDHHF);

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool HHBHBAMIPBA);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NFELOCLBHCG
{
	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAA50", Offset = "0x5EA9850", VA = "0x185EAAA50")]
	public static bool NFHLHGHAJCK(this DLFCAAPBCNB NKMFCGHJDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAAA0", Offset = "0x5EA98A0", VA = "0x185EAAAA0")]
	public static bool NPAJFGDFLCK(this DLFCAAPBCNB NKMFCGHJDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAA00", Offset = "0x5EA9800", VA = "0x185EAAA00")]
	public static bool MENCLECKDCG(this DLFCAAPBCNB NKMFCGHJDIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA960", Offset = "0x5EA9760", VA = "0x185EAA960")]
	public static bool CGHLOCINKNH(this DLFCAAPBCNB NKMFCGHJDIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public readonly struct JOPHAPLHHKH : IEquatable<JOPHAPLHHKH>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly JOPHAPLHHKH EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9060", Offset = "0x5EA7E60", VA = "0x185EA9060", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(JOPHAPLHHKH FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface DAFMNOPLPJC
{
	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JPJPIGEOFGI(NativeListAsync<Entity> HFBJBKAIBKB);

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIMEPPCCBBF(DIJIPMHBBCA BPHAAKLHCEH);

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FPHIHKGPDCB(NativeListAsync<Entity> FHDAPJJNPMA, bool EEBOLMIFLLI);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OAIJDKCJMEB();
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface HHCGMPDNFCD
{
	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LPHHAKCMBAL(EGCGFMJAHFA OEJOEELBGEB, MKDNGEDKNED KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface OCLFIPMHNPC
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FMHMPLKPLPK();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AECPPBFAHPG();

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEBHLLCDEGP();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JIBMBMKNJBJ();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MBBOBANIMMK();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GGIAJCKIJAM();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BKBNNIIPKGC();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LIDOBADIMMA();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FGNELGNBLJP();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void MNDEKIJLAAL();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PDDILGOBJIF();
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public interface INNGAKKGOIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000047")]
	int MBEFAFBFDHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> EAALFEOGFIN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EGCGFMJAHFA KPKLNADAEIJ(EGCGFMJAHFA HMMLJFMHHMO);

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int KPKLNADAEIJ(int GBBIMGMFFJF);
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface FNEIDODPOJD : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public readonly struct PFAKNPABKNC : IEquatable<PFAKNPABKNC>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly PFAKNPABKNC EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	private DEECDNIJIFE OBNDALGHPLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB850", Offset = "0x5EAA650", VA = "0x185EAB850")]
		get
		{
			return default(DEECDNIJIFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public bool AOCJMLBCOGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB7E0", Offset = "0x5EAA5E0", VA = "0x185EAB7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NEAAIGCLOHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB990", Offset = "0x5EAA790", VA = "0x185EAB990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool CMINABADAFE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB070", Offset = "0x5EA9E70", VA = "0x185EAB070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool LDIPCIFKFLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB5C0", Offset = "0x5EAA3C0", VA = "0x185EAB5C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool EBEIPBKCBGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EABA00", Offset = "0x5EAA800", VA = "0x185EABA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool MOHDGJLBJDM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB6A0", Offset = "0x5EAA4A0", VA = "0x185EAB6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool ECPMANJAMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB550", Offset = "0x5EAA350", VA = "0x185EAB550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool AOHIAHAKBJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB230", Offset = "0x5EAA030", VA = "0x185EAB230")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool JPINHLIFHHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB150", Offset = "0x5EA9F50", VA = "0x185EAB150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool EEPEFKOOMAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB0E0", Offset = "0x5EA9EE0", VA = "0x185EAB0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool NNNNBPFCPJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB4E0", Offset = "0x5EAA2E0", VA = "0x185EAB4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool POMBHLHBCML
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB8B0", Offset = "0x5EAA6B0", VA = "0x185EAB8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool EKEBFKJHCDE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB630", Offset = "0x5EAA430", VA = "0x185EAB630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool EBBKKOKCHJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB980", Offset = "0x5EAA780", VA = "0x185EAB980")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool OONFHCCACPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB060", Offset = "0x5EA9E60", VA = "0x185EAB060")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB920", Offset = "0x5EAA720", VA = "0x185EAB920")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool HNJIEEGHHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB1C0", Offset = "0x5EA9FC0", VA = "0x185EAB1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public Vector3 OJGPEDLFALK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB710", Offset = "0x5EAA510", VA = "0x185EAB710")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 NBBPGEAPDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB420", Offset = "0x5EAA220", VA = "0x185EAB420")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool BBCFMFIKBIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5EAAF40", Offset = "0x5EA9D40", VA = "0x185EAAF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5EAB930", Offset = "0x5EAA730", VA = "0x185EAB930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB3A0", Offset = "0x5EAA1A0", VA = "0x185EAB3A0")]
	public bool FELOJGPILMM(MCNDCMCKKKP CDMJMAILEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5EABAF0", Offset = "0x5EAA8F0", VA = "0x185EABAF0")]
	public bool PNDBLENLAFJ(ObjectPolicyUserConfigurableFlags CDMJMAILEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5EABA70", Offset = "0x5EAA870", VA = "0x185EABA70")]
	public void OPOBHJMEGPK(ObjectPolicyUserConfigurableFlags CDMJMAILEKC, bool IIOKBCMDCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public PFAKNPABKNC(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5EAB2A0", Offset = "0x5EAA0A0", VA = "0x185EAB2A0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(PFAKNPABKNC FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface HOLKDEPHBHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000061")]
	DLNFDGOHKLI ABKBCFGBHIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	ENBGCIGLEDL FJKAOBGGDPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	EntityManager FOKKLIPOJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	bool CGHLOCINKNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase NDJEFFOMBNE(Type LKLFHGBOOLP);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class BJLGKGLMEFE
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x5E9ADA0", Offset = "0x5E99BA0", VA = "0x185E9ADA0")]
	public static World EILCGBHDCCB(this HOLKDEPHBHG KCGIPKEABCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x4512BB0", Offset = "0x45119B0", VA = "0x184512BB0")]
	public static T NDJEFFOMBNE<T>(this HOLKDEPHBHG KCGIPKEABCH) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public readonly struct KIJGNLIGAMO : IEquatable<KIJGNLIGAMO>
{
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public static readonly KIJGNLIGAMO EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	private GAMJOBMBKDF JKDMIKKHIBO
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9AE0", Offset = "0x5EA88E0", VA = "0x185EA9AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public EGCGFMJAHFA DPGJHECPFGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9490", Offset = "0x5EA8290", VA = "0x185EA9490")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JDCDHMJMEPN ELDFLCOHEBO
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA99D0", Offset = "0x5EA87D0", VA = "0x185EA99D0")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public JDCDHMJMEPN EDOHGCDFIHH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9770", Offset = "0x5EA8570", VA = "0x185EA9770")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9980", Offset = "0x5EA8780", VA = "0x185EA9980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9870", Offset = "0x5EA8670", VA = "0x185EA9870")]
	public bool KPFIAOMFCDP(JDCDHMJMEPN GMBPOBACJJI, bool EKFONMIOIIG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9580", Offset = "0x5EA8380", VA = "0x185EA9580")]
	public bool EDPIPGNIGHF(JDCDHMJMEPN KMPLFHBLGCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public KIJGNLIGAMO(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9670", Offset = "0x5EA8470", VA = "0x185EA9670", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(KIJGNLIGAMO FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public readonly struct MOBBDFCAHDJ : IEquatable<MOBBDFCAHDJ>
{
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly MOBBDFCAHDJ EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private CFBGBLHAAHA HHJCPDKELCD
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA5A0", Offset = "0x5EA93A0", VA = "0x185EAA5A0")]
		get
		{
			return default(CFBGBLHAAHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public GJANPBGBPGA NJKFDJKBGPG
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA600", Offset = "0x5EA9400", VA = "0x185EAA600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public MOBBDFCAHDJ(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA4A0", Offset = "0x5EA92A0", VA = "0x185EAA4A0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(MOBBDFCAHDJ FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface EKGFBCJLMKP
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	HJNMAIFKPEK INJBLOENDBN
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
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface KGKLOPPOEBG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000071")]
	bool OFEJANCBKHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	bool NDDFJCNKGMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	int IJBNENGLEDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool JOBIFOKLEJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	DFDMNPNGDBP KBBHFBCDLJH
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	FKDMEDAGIAF FGINIPMECMF
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool NMBINLBEKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool MLJKLEDLEEA
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	string FPGNEGHCGKA
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int KHHBJLFHGHO(GameObject KKHNMHOFPEF);

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "10")]
	GameObject[] FEOJHGMAOJN(IEnumerable<JJCFDHHONOD> FJHKAMEFPLO);

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "11")]
	PPDNOHKLMNC AOKJCFPCBBP(Guid OIFJJOJHELM);

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "12")]
	DLFCAAPBCNB EMKOFDNGGGD(JJCFDHHONOD IDLLMGEFFMF);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "13")]
	DLFCAAPBCNB EMKOFDNGGGD(string FDDFNICFOOO, PPDNOHKLMNC NNKJCELFGML, Vector3 IHHJAKDKGPC, Quaternion EMNOFGLPALH, Vector3 OLFLAEBOOJB);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void INMOKMILBAD(bool HECCKGMOGMB);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "15")]
	void LFHAKINILEF();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "16")]
	bool EALBFKOOOBH(GameObject KKHNMHOFPEF, out PPDNOHKLMNC NNKJCELFGML);

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool JKOPEDAEFCE(GameObject KKHNMHOFPEF, out int BLPNONGEFCH, out ObjectPrefabType HPLFBDKKOIF);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void LOHBIAGDGJC(GameObject KKHNMHOFPEF, bool LBGGBALGMPM, bool AOKEJHPNBCL);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void IDNLMEIOBPH(GameObject KKHNMHOFPEF);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "20")]
	Task JKGJDPOLNNC();

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "21")]
	Task PGIJCJGFKJD();

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void NFCBMNDLHNM(object LMBGOHINBAF);

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void ELPLGHBLNPG(object LMBGOHINBAF);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void ILFMHBACDHA(object GNCDGJDGENH);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void GIKAFBNHMMA(Transform NCDMMOPONFH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AJFBBKIFCCB(Transform NCDMMOPONFH, AIOMGFAEFNO LONDKBEEJHN);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void ILFOMBDPKHN(Transform NCDMMOPONFH, HJNMAIFKPEK ONIEAMHCLDE);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IHLAHEEGHPH(GameObject KKHNMHOFPEF, ObjectPolicyUserConfigurableFlags KKGHFAAFEEK);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "29")]
	Vector3 HKFPPJCIKCA(GameObject KKHNMHOFPEF, int PDOHEIMKMPD);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool CLNBGGIHBID(out Vector3 IHHJAKDKGPC);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void DLNGOAKDOLL();

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void GMPJMCPFCBL(GameObject JIGHNKPFBAP, bool EOJJCIJDILM);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "33")]
	ObjectPrefabType MKNCMACDDDJ(GameObject CJDEFKBLNIP);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "34")]
	int POABIJACKNI(GameObject KKHNMHOFPEF);

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "35")]
	object MCMJNMLLDGM(EGCGFMJAHFA OEJOEELBGEB, GameObject KKHNMHOFPEF, Action<EGCGFMJAHFA, int> IIPKIDOCHMK);

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void GHBKGEOGOME(GameObject KKHNMHOFPEF, object LMKGCNJBDEA);

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void JJHIJACDGGC(GameObject KKHNMHOFPEF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LLADKEJLEBH(CDOABBFCKIF HMMLJFMHHMO);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void NCCBEGKGALF(GameObject KKHNMHOFPEF);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void JCGGHOCNAFC(string CAJMIGKHKEC);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "41")]
	int EFPJGCIEMMB(GameObject CJDEFKBLNIP);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FMPNNOKMPIM(NativeArray<int> BFDBILFDKND);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void KDHOFLLBLNK(Action EHPEOJCHKEM, bool BAEMOIIILKP);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "44")]
	bool KPMONKGDNLE(string PPPOJKMOIGD);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public static class GFEKDBNINJF
{
	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4BD0", Offset = "0x5EA39D0", VA = "0x185EA4BD0")]
	public static DLFCAAPBCNB EMKOFDNGGGD(this KGKLOPPOEBG KMPEFKMHNGP, PPDNOHKLMNC NNKJCELFGML, Vector3 IHHJAKDKGPC, Quaternion EMNOFGLPALH, Vector3 OLFLAEBOOJB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface LPMPOBBMDFC
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public struct ALOHGLGNMHD : LLEEHKNOMNP<ALOHGLGNMHD>, IDGNIPDDEJI, IEquatable<ALOHGLGNMHD>
{
	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public int PGIEFBHCKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public int MKCLCLCLGPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000165")]
		[Cpp2IlInjected.Address(RVA = "0xD1D510", Offset = "0xD1C310", VA = "0x180D1D510", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000166")]
		[Cpp2IlInjected.Address(RVA = "0x19316E0", Offset = "0x19304E0", VA = "0x1819316E0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A7D0", Offset = "0x5E995D0", VA = "0x185E9A7D0", Slot = "8")]
	public bool Equals(ALOHGLGNMHD FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A820", Offset = "0x5E99620", VA = "0x185E9A820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public struct EBEDPNDMCJC : NBCOBFFPIIB, IEquatable<EBEDPNDMCJC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public ObjectPrefabType HPLFBDKKOIF;

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EFF0", Offset = "0x5E9DDF0", VA = "0x185E9EFF0", Slot = "5")]
	public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F020", Offset = "0x5E9DE20", VA = "0x185E9F020", Slot = "4")]
	public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F050", Offset = "0x5E9DE50", VA = "0x185E9F050", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0xCB11A0", Offset = "0xCAFFA0", VA = "0x180CB11A0", Slot = "6")]
	public bool Equals(EBEDPNDMCJC FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9EF60", Offset = "0x5E9DD60", VA = "0x185E9EF60", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface AJHENPNODPN
{
	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action PLENCHAFCNH;

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ILGAOHILMLF();

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EPKCNEKCHCB();
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface BLCBOAINGPP
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	GIPGPAOLFJG FEHFNILLGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	List<EHMBLNLEMLJ> LGEECDINNFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MGDFMMEBNLM(EHMBLNLEMLJ ICNBGPBCJEH, out GIPGPAOLFJG LMNBADHDHAF);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAHHBIDHLIK(EHMBLNLEMLJ ICNBGPBCJEH, EHJKOOJALKD IGIDMODFOEM);

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OBPDIOPICFK(EHMBLNLEMLJ ICNBGPBCJEH, EHJKOOJALKD IGIDMODFOEM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface OPDAHLMDBPM
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	DGHKKDHPPNC LIOKJLCEAHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct AMAAAIKKHJC : IEquatable<AMAAAIKKHJC>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly AMAAAIKKHJC EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	private MBLNLHCNOCK ODCMIOOBDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AA60", Offset = "0x5E99860", VA = "0x185E9AA60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public float3 HPCILOEOHIK
	{
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC60", Offset = "0x5E99A60", VA = "0x185E9AC60")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public quaternion OMBCEELIHEA
	{
		[Cpp2IlInjected.Token(Token = "0x600017B")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A870", Offset = "0x5E99670", VA = "0x185E9A870")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public JDCDHMJMEPN GPBNEFCNEOH
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AAE0", Offset = "0x5E998E0", VA = "0x185E9AAE0")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000185")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x5E9AC10", Offset = "0x5E99A10", VA = "0x185E9AC10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public AMAAAIKKHJC(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
	public static EGCGFMJAHFA HAJGNNHEPJI(AMAAAIKKHJC KKLNCEHOHED)
	{
		return default(EGCGFMJAHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A960", Offset = "0x5E99760", VA = "0x185E9A960", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(AMAAAIKKHJC FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface HDHHONMOKPD
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JAPDPMIBLDO;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action AAPDINNOPKA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action AGELODBDHHI;
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface GIPGPAOLFJG
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	string OILBDGCJBEO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	GIPGPAOLFJG GKJBJLAJMFK
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	IEnumerable<GIPGPAOLFJG> EJKKBBIDFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
[DefaultMember("Item")]
public struct CDOABBFCKIF : IReadOnlyList<EGCGFMJAHFA>, IEnumerable<EGCGFMJAHFA>, IEnumerable, IReadOnlyCollection<EGCGFMJAHFA>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public struct KFNHOLDKEKI : IEnumerator<EGCGFMJAHFA>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private readonly CDNFKKBDBMA FMGNJAHHCOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private NativeArray<LocalId>.Enumerator HBEBKLDONPL;

		[Cpp2IlInjected.Token(Token = "0x17000090")]
		public EGCGFMJAHFA CFKFFOLONBC
		{
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9340", Offset = "0x5EA8140", VA = "0x185EA9340", Slot = "4")]
			get
			{
				return default(EGCGFMJAHFA);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000091")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0x5EA9260", Offset = "0x5EA8060", VA = "0x185EA9260", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x2643940", Offset = "0x2642740", VA = "0x182643940")]
		public KFNHOLDKEKI(CDNFKKBDBMA FMGNJAHHCOF, NativeArray<LocalId>.Enumerator HBEBKLDONPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA91A0", Offset = "0x5EA7FA0", VA = "0x185EA91A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA91E0", Offset = "0x5EA7FE0", VA = "0x185EA91E0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA9220", Offset = "0x5EA8020", VA = "0x185EA9220", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly CDNFKKBDBMA FMGNJAHHCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private NativeArray<LocalId> HMMLJFMHHMO;

	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	public EGCGFMJAHFA MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D2C0", Offset = "0x5E9C0C0", VA = "0x185E9D2C0", Slot = "4")]
		get
		{
			return default(EGCGFMJAHFA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CD90", Offset = "0x5E9BB90", VA = "0x185E9CD90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private int DOMAIIDKLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public int BBPCGKEHJPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x7F1060", Offset = "0x7EFE60", VA = "0x1807F1060")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public bool JKEFCNHAJAB
	{
		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CD50", Offset = "0x5E9BB50", VA = "0x185E9CD50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public NativeArray<LocalId> MGAHOJJJGDP
	{
		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x26445E0", Offset = "0x26433E0", VA = "0x1826445E0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	internal NativeArray<Entity> GNHIFOMHIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x5E9CE30", Offset = "0x5E9BC30", VA = "0x185E9CE30")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D230", Offset = "0x5E9C030", VA = "0x185E9D230")]
	public CDOABBFCKIF(int OFPPAGPDNCI, CDNFKKBDBMA FMGNJAHHCOF, Allocator FIPHDKMNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x2643470", Offset = "0x2642270", VA = "0x182643470")]
	public CDOABBFCKIF(CDNFKKBDBMA FMGNJAHHCOF, NativeArray<LocalId> HMMLJFMHHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D070", Offset = "0x5E9BE70", VA = "0x185E9D070")]
	internal CDOABBFCKIF(CDNFKKBDBMA FMGNJAHHCOF, NativeArray<Entity> KHPJJPHILOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D0E0", Offset = "0x5E9BEE0", VA = "0x185E9D0E0")]
	public CDOABBFCKIF(CDNFKKBDBMA FMGNJAHHCOF, int CNKKOGIEKAD, Allocator FIPHDKMNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D180", Offset = "0x5E9BF80", VA = "0x185E9D180")]
	public CDOABBFCKIF(CDOABBFCKIF FPEDMMEMCHN, Allocator FIPHDKMNFDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CD10", Offset = "0x5E9BB10", VA = "0x185E9CD10", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CDA0", Offset = "0x5E9BBA0", VA = "0x185E9CDA0")]
	public KFNHOLDKEKI JOJADCJMMBH()
	{
		return default(KFNHOLDKEKI);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CE90", Offset = "0x5E9BC90", VA = "0x185E9CE90", Slot = "6")]
	private IEnumerator<EGCGFMJAHFA> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x5E9CF80", Offset = "0x5E9BD80", VA = "0x185E9CF80", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public struct PPDNOHKLMNC : IComparable<PPDNOHKLMNC>, IEquatable<PPDNOHKLMNC>, NBCOBFFPIIB
{
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public const uint KFOAAPEBLHC = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public const uint GFGLJMBLAID = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly PPDNOHKLMNC IOPEGLNHBHH;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private const int MJMKCIKGMBO = 24;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private const uint DCGJIKNKIPB = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private const int MJJHEGKELIA = 8;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private const uint PGBDDJCDIJP = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly uint KIIAPAPHICG;

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public uint OJFCFDMEOFE
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x1655E10", Offset = "0x1654C10", VA = "0x181655E10")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	public uint ODIKHJJHMMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5EAC000", Offset = "0x5EAAE00", VA = "0x185EAC000")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	public uint EMKKEODJHHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xA2A950", Offset = "0xA29750", VA = "0x180A2A950")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	public bool BNHJEBEMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x18F51B0", Offset = "0x18F3FB0", VA = "0x1818F51B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public bool JCFEBLHACPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5EABF30", Offset = "0x5EAAD30", VA = "0x185EABF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0xCB2D60", Offset = "0xCB1B60", VA = "0x180CB2D60")]
	public static PPDNOHKLMNC OAELNKLPGMK(uint KIIAPAPHICG)
	{
		return default(PPDNOHKLMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC0E0", Offset = "0x5EAAEE0", VA = "0x185EAC0E0")]
	public PPDNOHKLMNC(int NALNBAEKHHJ, int PIHKOOEHAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC0E0", Offset = "0x5EAAEE0", VA = "0x185EAC0E0")]
	public PPDNOHKLMNC(uint NALNBAEKHHJ, int PIHKOOEHAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC0E0", Offset = "0x5EAAEE0", VA = "0x185EAC0E0")]
	public PPDNOHKLMNC(uint NALNBAEKHHJ, uint PIHKOOEHAHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400")]
	private PPDNOHKLMNC(uint KIIAPAPHICG)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x57E2000", Offset = "0x57E0E00", VA = "0x1857E2000")]
	public static bool DDONPFMGGHF(PPDNOHKLMNC IKGMJGNOMBA, PPDNOHKLMNC GOEPIJCAGGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x57E2010", Offset = "0x57E0E10", VA = "0x1857E2010")]
	public static bool HDFILCNJOKD(PPDNOHKLMNC IKGMJGNOMBA, PPDNOHKLMNC GOEPIJCAGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EABED0", Offset = "0x5EAACD0", VA = "0x185EABED0", Slot = "5")]
	public bool Equals(PPDNOHKLMNC PJCEAFJNLLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EABE00", Offset = "0x5EAAC00", VA = "0x185EABE00", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x1797830", Offset = "0x1796630", VA = "0x181797830", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EAC010", Offset = "0x5EAAE10", VA = "0x185EAC010", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EABFA0", Offset = "0x5EAADA0", VA = "0x185EABFA0", Slot = "6")]
	public void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EABF40", Offset = "0x5EAAD40", VA = "0x185EABF40", Slot = "7")]
	public void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EABDF0", Offset = "0x5EAABF0", VA = "0x185EABDF0", Slot = "4")]
	public int CompareTo(PPDNOHKLMNC FGBEDAPNDEP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface BMMKBCLGEDD
{
	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CBNKDEALJKG(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FPCDFCHKMIG(Entity FPIIEOBJDDB, in float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 EHAAHHDBHAP(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HKJCCFPDNDG(Entity FPIIEOBJDDB, in quaternion KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion DIFNNBFCANC(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FEPOFBGKABI(Entity FPIIEOBJDDB, in float3 IHHJAKDKGPC, in quaternion EMNOFGLPALH);

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AFLFKACNPJI(Entity FPIIEOBJDDB, out float3 IHHJAKDKGPC, out quaternion EMNOFGLPALH);

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AFLFKACNPJI(Entity FPIIEOBJDDB, out RigidTransform GNKPKJEDDIC);

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void DMPIAGDLNLJ(Entity FPIIEOBJDDB, in float3 IHHJAKDKGPC, in quaternion EMNOFGLPALH);

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void POLHMLBNOOH(Entity FPIIEOBJDDB, out RigidTransform GNKPKJEDDIC);

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 DBKIJAMGFLE(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void GGHJMELDFIH(Entity FPIIEOBJDDB, in float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void CCCLNDOOOIF(Entity FPIIEOBJDDB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float NEHHGIANKPM(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void HACFEBJDCOM(Entity FPIIEOBJDDB, in float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BAGJDJDLFGC(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void BNFMKAFFIAJ(Entity FPIIEOBJDDB, in float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 NHIOHCODODI(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void INHPKBPADCA(Entity FPIIEOBJDDB, in quaternion KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion DFOONNBMMGG(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 DJBHIHODNDB(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void IJGLKEGDJCP(Entity FPIIEOBJDDB, in float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MJDMGADAOMI(Entity FPIIEOBJDDB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float OOJAGOGKBBP(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IGALDPIAIFN(Entity FPIIEOBJDDB, in float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 APGCCJILNJE(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void HKECNPGIAEK(Entity FPIIEOBJDDB, out float4x4 BJJJIKJJEPE);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void EBCEADAGHJE(Entity FPIIEOBJDDB, in float4x4 BJJJIKJJEPE);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OGOCCMPLELE(Entity FPIIEOBJDDB, out float4x4 BJJJIKJJEPE);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool KGLGHDGLOLB(Entity FPIIEOBJDDB, out Transform NCDMMOPONFH);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void OGPJMHGNBNN(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NELBEGAHMFI(Entity FPIIEOBJDDB, Entity KFFMAAJLHLC, Entity DOJCGKKDJND);
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class GMHJKOJNKBM
{
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public readonly struct LOHOBBBFGHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private readonly IEnumerable<JJCFDHHONOD> FJHKAMEFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly IReadOnlyList<GameObject> ONLLMJGJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly IReadOnlyList<int> GPKJNHBPNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly int LOEGGGMCANG;

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public bool BNHJEBEMNGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA0F0", Offset = "0x5EA8EF0", VA = "0x185EAA0F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public int MPGDLGCMGLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x86DAD0", Offset = "0x86C8D0", VA = "0x18086DAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public IEnumerable<GameObject> LODMDHONJJP
	{
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x1AB83B0", Offset = "0x1AB71B0", VA = "0x181AB83B0")]
	public LOHOBBBFGHK(IEnumerable<JJCFDHHONOD> FJHKAMEFPLO, IReadOnlyList<GameObject> ONLLMJGJDLI, IReadOnlyList<int> GPKJNHBPNBK, int LOEGGGMCANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA150", Offset = "0x5EA8F50", VA = "0x185EAA150")]
	public IEnumerable<(GameObject, int)> KKPPLMKBAOM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public readonly struct IFHGODGECMD : IEquatable<IFHGODGECMD>
{
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static readonly IFHGODGECMD EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	private GAMJOBMBKDF JKDMIKKHIBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6240", Offset = "0x5EA5040", VA = "0x185EA6240")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public CDOABBFCKIF GDLIIODPBNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5830", Offset = "0x5EA4630", VA = "0x185EA5830")]
		get
		{
			return default(CDOABBFCKIF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<JDCDHMJMEPN> JPOCNGPAMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F80", Offset = "0x5EA4D80", VA = "0x185EA5F80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<JDCDHMJMEPN> BLJLJMAPHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5B10", Offset = "0x5EA4910", VA = "0x185EA5B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public int IFPBOLFFCEN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5970", Offset = "0x5EA4770", VA = "0x185EA5970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public int IIBDCJCHHBN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x5EA62C0", Offset = "0x5EA50C0", VA = "0x185EA62C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public string KGBBPCBIOMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5610", Offset = "0x5EA4410", VA = "0x185EA5610")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public ContainerCollisionLayerEnum CCDFDCKGCLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5E50", Offset = "0x5EA4C50", VA = "0x185EA5E50")]
		get
		{
			return default(ContainerCollisionLayerEnum);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F10", Offset = "0x5EA4D10", VA = "0x185EA5F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public CollisionMode DPBMJPFDAHA
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x5EA57C0", Offset = "0x5EA45C0", VA = "0x185EA57C0")]
		get
		{
			return default(CollisionMode);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x5EA61D0", Offset = "0x5EA4FD0", VA = "0x185EA61D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool MJMBPLGJGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA61A0", Offset = "0x5EA4FA0", VA = "0x185EA61A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public bool BGNIICHAFOH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5930", Offset = "0x5EA4730", VA = "0x185EA5930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public bool JILHGKOCABO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA55F0", Offset = "0x5EA43F0", VA = "0x185EA55F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public bool OPIJKHOIDNG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5950", Offset = "0x5EA4750", VA = "0x185EA5950")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool JLAGJLPOMOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5820", Offset = "0x5EA4620", VA = "0x185EA5820")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA60F0", Offset = "0x5EA4EF0", VA = "0x185EA60F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool NGICEFECKOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5F00", Offset = "0x5EA4D00", VA = "0x185EA5F00")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA61C0", Offset = "0x5EA4FC0", VA = "0x185EA61C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public FKEFBLGGPHP IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(FKEFBLGGPHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public KIJGNLIGAMO HMGBIMLLIDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(KIJGNLIGAMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5EB0", Offset = "0x5EA4CB0", VA = "0x185EA5EB0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
	public static JDCDHMJMEPN HAJGNNHEPJI(IFHGODGECMD PIOBINFNKKO)
	{
		return default(JDCDHMJMEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6100", Offset = "0x5EA4F00", VA = "0x185EA6100")]
	public bool NADLNNMFCEH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5A50", Offset = "0x5EA4850", VA = "0x185EA5A50")]
	public bool IBOELJAPNLA(ContainerEnumFlags CDMJMAILEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6120", Offset = "0x5EA4F20", VA = "0x185EA6120")]
	public void NJDLGFFLFJG(ContainerEnumFlags CDMJMAILEKC, bool KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5C50", Offset = "0x5EA4A50", VA = "0x185EA5C50")]
	public CDOABBFCKIF IFCNIADNMPB(Allocator FIPHDKMNFDJ)
	{
		return default(CDOABBFCKIF);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5440", Offset = "0x5EA4240", VA = "0x185EA5440")]
	public void AOHFEHCEOIH(IFHGODGECMD FGBEDAPNDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public IFHGODGECMD(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3B0", Offset = "0x5E9A1B0", VA = "0x185E9B3B0")]
	public static bool HAJGNNHEPJI(IFHGODGECMD KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x5EA56C0", Offset = "0x5EA44C0", VA = "0x185EA56C0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(IFHGODGECMD FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public readonly struct LAJANENPNBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	internal readonly ONLLLANPENF IOEACHBFFDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	internal readonly ONLLLANPENF IJAHGCHCONN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	internal readonly uint LHMEOCCOGKE;

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9D10", Offset = "0x5EA8B10", VA = "0x185EA9D10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public readonly struct KLPAHAPLKEO
{
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly LAJANENPNBK EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9BA0", Offset = "0x5EA89A0", VA = "0x185EA9BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public readonly struct PKNDECPIFED
{
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static readonly IBKLHAEEEEI EKFPDHJKIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly LAJANENPNBK EHPEOJCHKEM;

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9BA0", Offset = "0x5EA89A0", VA = "0x185EA9BA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public readonly struct PKBMLKBMLNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	internal readonly uint LHMEOCCOGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly bool EBCFOHNLMJN;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x5EABCC0", Offset = "0x5EAAAC0", VA = "0x185EABCC0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface AAOBMHINIMM
{
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDAFAIDHBOB(EGCGFMJAHFA OEJOEELBGEB, NNCIKKMHHAL KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(Slot = "1")]
	NNCIKKMHHAL FDHGMNCJJPK(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JGLPKFEFEPD(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOMFGDNBOAA(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GDINJAGHMJC(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EGCGFMJAHFA FMILLJONLLD(EGCGFMJAHFA OEJOEELBGEB, int FHOMILACEHB);

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CGEGGOKFDJO(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MKDMHAHJLPD(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND, EGCGFMJAHFA KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void IAJCFMBIJPK(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FKACCGJHHEL(EGCGFMJAHFA OEJOEELBGEB, out EGCGFMJAHFA KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DHOEEHCBAFO(EGCGFMJAHFA OEJOEELBGEB, float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool OLCJGNFLMJL(EGCGFMJAHFA OEJOEELBGEB, out float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void HEEEKCAIHCN(EGCGFMJAHFA OEJOEELBGEB, float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool FLAHLKCGPAD(EGCGFMJAHFA OEJOEELBGEB, out float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void JHPOBNPENKN(EGCGFMJAHFA OEJOEELBGEB, (Quaternion rot, Vector3 moments) INIANJPOEAC);

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool PLFIABFDNIL(EGCGFMJAHFA OEJOEELBGEB, out quaternion KLAGOODAGBI, out float3 ACGIIGIJNBC);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void OBLENPKJMMP(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GDAIINBJKMO(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 CFMHEJCEFKA(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 POKGCHDJGKN(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void FDGBFGPOMGK(EGCGFMJAHFA OEJOEELBGEB, float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool GHNNHNCBBDP(EGCGFMJAHFA OEJOEELBGEB, out float3 GFOMDDJMDMO);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DMJALEONKOA(EGCGFMJAHFA OEJOEELBGEB, float3 KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void GLELFJPDFCP(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float EJPNKKBKJIB(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float FOLNFGDLMAD(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void MKNJOIAJOIO(EGCGFMJAHFA OEJOEELBGEB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool AAHBIACKMOC(EGCGFMJAHFA OEJOEELBGEB, out float BPAIDGPANCI);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HPOLAIODGHH(EGCGFMJAHFA OEJOEELBGEB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode CBPGAOJOAKE(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void GAFHKIBNHPH(EGCGFMJAHFA OEJOEELBGEB, CollisionDetectionMode KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MNKJPBHDJIH LJJBLGKNHPF(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void LJFMNLMHFOM(EGCGFMJAHFA OEJOEELBGEB, MNKJPBHDJIH KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool GJLIDBPIHDI(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void OLLFHIIPJNP(EGCGFMJAHFA OEJOEELBGEB, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "35")]
	EGCGFMJAHFA ACALPEOJJIH(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ACLLGKLKLID(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "37")]
	EGCGFMJAHFA CKKAENBKGMB(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void KPFIAOMFCDP(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	ALFCLIHOIFK BOKJIADHMPO(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void KIIIGHCNGKJ(EGCGFMJAHFA OEJOEELBGEB, ALFCLIHOIFK NOABEHCLBOM);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool BKEPELMLCEN(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void IBCGPHPOJBN(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool LNKEJEILCDD(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void CCKIMGOGPLE(EGCGFMJAHFA OEJOEELBGEB, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool GOMGLCJAPNN(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void MBKHAEOKPNI(EGCGFMJAHFA OEJOEELBGEB, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints IKPKKMENNIG(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void DEGIIOBPIDL(EGCGFMJAHFA OEJOEELBGEB, RigidbodyConstraints KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float KKOLIJFILIG(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void GPCGKOIDHHN(EGCGFMJAHFA OEJOEELBGEB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float IOJLFLGEJBF(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void AMEACOIJGBD(EGCGFMJAHFA OEJOEELBGEB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool ONKOIGPMPBF(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AGCBDKOCJCH(EGCGFMJAHFA OEJOEELBGEB, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool INHFBILDHGE(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void GFIGMNLJKLM(EGCGFMJAHFA OEJOEELBGEB, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int GLFPFPADLAK(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void MLICAEAHJHB(EGCGFMJAHFA OEJOEELBGEB, int KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object PIMOMEPKKPE(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void CAFPGCECOHC(EGCGFMJAHFA OEJOEELBGEB, object KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object FFBCDJHDNMJ(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void GKELBPJMFGH(EGCGFMJAHFA OEJOEELBGEB, object KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float MJENGJCNKFG(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void BMDEFPEJBON(EGCGFMJAHFA OEJOEELBGEB, float KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void EGIGGODIMHE(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void LFEHDHMENEJ(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool JKBLOPPBFPG(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void EIMFBEBFACI(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void MJPHLAHBCFB(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool ADFMENFODGI(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool HJLKKGAKAAI(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "72")]
	void PMMIICGBONK(EGCGFMJAHFA OEJOEELBGEB, bool KKLNCEHOHED);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "73")]
	Rigidbody KNLLAGHJJDD(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void MHGFIMPLCMC(EGCGFMJAHFA OEJOEELBGEB, Rigidbody MFDMLFENPMD);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void KPECEJGALAC(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "76")]
	void EKFGHHIJGFL(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool BIELMHMAKJI(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void EOOCDAPIOLO(EGCGFMJAHFA OEJOEELBGEB, float3 LDCHPECNIMD);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void GEEAMEADPNK(EGCGFMJAHFA OEJOEELBGEB, float3 OFMHBIEBPJA);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool IFEMOOFOBAO(EGCGFMJAHFA OEJOEELBGEB, out float3 LDCHPECNIMD);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool NHOPPMGLEOP(EGCGFMJAHFA OEJOEELBGEB, out float3 OFMHBIEBPJA);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "82")]
	bool MOGBHMOHBGN(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void IPFAPBICOKI(EGCGFMJAHFA OEJOEELBGEB, object GKNJCIECGND, bool FDNLKPOOHMJ);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void BPFJLLHMNII(EGCGFMJAHFA OEJOEELBGEB, bool IOIEMEEHFPP);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "85")]
	void OFDBLNEIDNA(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "86")]
	bool GGBJKJCKJJE(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "87")]
	IEnumerable<object> GIOOBODCAOF(EGCGFMJAHFA OEJOEELBGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface LKAGDJJKNAE
{
	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMDOCBOAAIC(Entity NMBDBMMOPNC);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PDIMCOEHJMC(Entity NMBDBMMOPNC);
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public readonly struct FPPAKLLCHDB : IEquatable<FPPAKLLCHDB>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly FPPAKLLCHDB EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public string EKLOELJJDOP
	{
		[Cpp2IlInjected.Token(Token = "0x600026D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3F20", Offset = "0x5EA2D20", VA = "0x185EA3F20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public string OBBOIPALJFI
	{
		[Cpp2IlInjected.Token(Token = "0x600026E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA41D0", Offset = "0x5EA2FD0", VA = "0x185EA41D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public FPPAKLLCHDB(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3E20", Offset = "0x5EA2C20", VA = "0x185EA3E20", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(FPPAKLLCHDB FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public readonly struct DICBGPNBPBA : IEquatable<DICBGPNBPBA>
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly DICBGPNBPBA EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600027A")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E290", Offset = "0x5E9D090", VA = "0x185E9E290", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(DICBGPNBPBA FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public readonly struct JGNPEOBNBIM : IEquatable<JGNPEOBNBIM>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly JGNPEOBNBIM EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private DEFFONLDLEO DELDAECNIDD
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8800", Offset = "0x5EA7600", VA = "0x185EA8800")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool LGOPCAJHEDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000280")]
		[Cpp2IlInjected.Address(RVA = "0x5EA86F0", Offset = "0x5EA74F0", VA = "0x185EA86F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool OIFPFHMKFNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000281")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7F20", Offset = "0x5EA6D20", VA = "0x185EA7F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public bool BGPHIBIMFFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000282")]
		[Cpp2IlInjected.Address(RVA = "0x5EA87D0", Offset = "0x5EA75D0", VA = "0x185EA87D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public bool HCGPNPCDDIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8AC0", Offset = "0x5EA78C0", VA = "0x185EA8AC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool CNAOCLNOFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000284")]
		[Cpp2IlInjected.Address(RVA = "0x5EA7E10", Offset = "0x5EA6C10", VA = "0x185EA7E10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool GBKMEKLOGED
	{
		[Cpp2IlInjected.Token(Token = "0x6000285")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8880", Offset = "0x5EA7680", VA = "0x185EA8880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool OHMOEJCDDFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000286")]
		[Cpp2IlInjected.Address(RVA = "0x5EA84B0", Offset = "0x5EA72B0", VA = "0x185EA84B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x5EA8A70", Offset = "0x5EA7870", VA = "0x185EA8A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(RVA = "0x5EA82C0", Offset = "0x5EA70C0", VA = "0x185EA82C0")]
	public bool FJJMGCHMNCL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8060", Offset = "0x5EA6E60", VA = "0x185EA8060")]
	public JDCDHMJMEPN EKECMNIEMMB(JDCDHMJMEPN LMBGOHINBAF)
	{
		return default(JDCDHMJMEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x5EA82F0", Offset = "0x5EA70F0", VA = "0x185EA82F0")]
	public EGCGFMJAHFA GBJIDADEAFD()
	{
		return default(EGCGFMJAHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public JGNPEOBNBIM(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3B0", Offset = "0x5E9A1B0", VA = "0x185E9B3B0")]
	public static bool HAJGNNHEPJI(JGNPEOBNBIM KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA81C0", Offset = "0x5EA6FC0", VA = "0x185EA81C0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(JGNPEOBNBIM FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct GPEHGPANNHP : IComparable<GPEHGPANNHP>, IEquatable<GPEHGPANNHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GPEHGPANNHP IOPEGLNHBHH;

	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public static readonly GPEHGPANNHP KONCHCMPDBG;

	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GPEHGPANNHP NIAJNDIAHCA;

	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public static readonly GPEHGPANNHP IIKDKFMIIHA;

	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly GPEHGPANNHP PGAMNFHCNCD;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly GPEHGPANNHP EHEFPOFJGJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public int PGIEFBHCKJD;

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool IAOFNFNCAAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4EA0", Offset = "0x5EA3CA0", VA = "0x185EA4EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0xAFF400", Offset = "0xAFE200", VA = "0x180AFF400")]
	public GPEHGPANNHP(int FHOMILACEHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4E30", Offset = "0x5EA3C30", VA = "0x185EA4E30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4DA0", Offset = "0x5EA3BA0", VA = "0x185EA4DA0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0xCB11A0", Offset = "0xCAFFA0", VA = "0x180CB11A0", Slot = "5")]
	public bool Equals(GPEHGPANNHP FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4D90", Offset = "0x5EA3B90", VA = "0x185EA4D90", Slot = "4")]
	public int CompareTo(GPEHGPANNHP FGBEDAPNDEP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0xCB2D60", Offset = "0xCB1B60", VA = "0x180CB2D60")]
	public static GPEHGPANNHP HAJGNNHEPJI(int FHOMILACEHB)
	{
		return default(GPEHGPANNHP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0xCB2D60", Offset = "0xCB1B60", VA = "0x180CB2D60")]
	public static int HAJGNNHEPJI(GPEHGPANNHP BOKNODKDNKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4EB0", Offset = "0x5EA3CB0", VA = "0x185EA4EB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[DefaultMember("Item")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface DEJFMJEDBPN : IEnumerable<KIIABIGJHJE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	KIIABIGJHJE MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600029E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KIIABIGJHJE AKDLJNBFGMH(KDKGBCPHDHM LNCLBGGHDHA);

	[Cpp2IlInjected.Token(Token = "0x600029F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GPEHGPANNHP HIGAAKNJNFP(KDKGBCPHDHM LNCLBGGHDHA);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class BHPOOHEJLHJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A0")]
	public static CKCBAJPMJCE<T> AKDLJNBFGMH<T>(this DEJFMJEDBPN FMCLAGCEHFA, KDKGBCPHDHM PPPOJKMOIGD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x450D440", Offset = "0x450C240", VA = "0x18450D440")]
	public static GPEHGPANNHP HIGAAKNJNFP<T>(this DEJFMJEDBPN FMCLAGCEHFA, NIBEAOLLINL<T> PPPOJKMOIGD) where T : struct
	{
		return default(GPEHGPANNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface HDIJNAIPGLJ
{
	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool JKONOFLGGPP(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AMJMJNEPNOH(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool MNDFFPIMLPI(EGCGFMJAHFA OEJOEELBGEB, out Guid MMKFOAANGLN);

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid OFMCDDNLJOP(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIMPFOIJIFF(EGCGFMJAHFA OEJOEELBGEB, Guid MMKFOAANGLN);

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FCEIPIMJCBG(EGCGFMJAHFA OEJOEELBGEB, out Guid IAHLLEDDMDA);

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid FJNBBPNMAHF(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AKGDEPJOLFJ(EGCGFMJAHFA OEJOEELBGEB, Guid IAHLLEDDMDA);

	[Cpp2IlInjected.Token(Token = "0x60002AA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void GEEDKAEGDCF(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60002AB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void CDBMJGJKIPP(EGCGFMJAHFA IBGFFODDGJN, EGCGFMJAHFA GMBPOBACJJI);
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface EGJODGEMJGD
{
	[Cpp2IlInjected.Token(Token = "0x60002AC")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKJILHILFNP(EGCGFMJAHFA BBBLGPNEOJP, bool KKLNCEHOHED);
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public readonly struct ICLEMBLIKFF : IEquatable<ICLEMBLIKFF>
{
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly ICLEMBLIKFF EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public GCGKCAKBOCM CGFILMELHOH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(GCGKCAKBOCM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private NLKEAENAICN GBAFDEDKJAO
	{
		[Cpp2IlInjected.Token(Token = "0x60002AE")]
		[Cpp2IlInjected.Address(RVA = "0x5EA53A0", Offset = "0x5EA41A0", VA = "0x185EA53A0")]
		get
		{
			return default(NLKEAENAICN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public PrimitiveShapeType EHJOAEBBDHD
	{
		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0x5EA5240", Offset = "0x5EA4040", VA = "0x185EA5240")]
		get
		{
			return default(PrimitiveShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public ICLEMBLIKFF(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3B0", Offset = "0x5E9A1B0", VA = "0x185E9B3B0")]
	public static bool HAJGNNHEPJI(ICLEMBLIKFF KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA52A0", Offset = "0x5EA40A0", VA = "0x185EA52A0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(ICLEMBLIKFF FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface MDFFCCNGIIJ
{
	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KKCDMPADCDC(EGCGFMJAHFA OEJOEELBGEB, ContainerCollisionLayerEnum FPBLDICMIIN, bool HDOHPPEDCPA, ContainerEnumFlags EPLPPMIHEGC);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNEAAKOGGOI(EGCGFMJAHFA OEJOEELBGEB, ContainerCollisionLayerEnum FPBLDICMIIN, bool HDOHPPEDCPA, bool KPLCIBPDIJA, bool GKHCPDJGNBA);

	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JKDFEICGLLI PANLAHHOLPP(EGCGFMJAHFA BHODGDEIEBD, List<EGCGFMJAHFA> LOJCJONKHNJ);

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NPHACEMENKG(GameObject OBHKEMFNFMO, GameObject FNJALABNAKD);

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJAOCHGAPLG(GameObject FNJALABNAKD);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T AGPPKIMDEKD<T>(GameObject EEONCGBBGIE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFDNALJMMFA(Collider DMENEKHAENG);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject LPICJKEGIIP<T>(string PPPOJKMOIGD) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface GJPHEECHBKC
{
	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	bool PDHBIJBGJPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002C2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface FNHNJDOHGDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	bool KGBJAHMBCJM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	bool GPHEHBJBIFC
	{
		[Cpp2IlInjected.Token(Token = "0x60002C4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	LKIFCOCAPLM LKMJBIOMILM
	{
		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPKJAINMPJP(bool HECCKGMOGMB);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	Task IDDDFILLBLI(bool HECCKGMOGMB);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NNIOLKIOJDO PHDEBBPOPOO();

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NNIOLKIOJDO KLEBBNNIKKA(IEnumerable<EGCGFMJAHFA> HMMLJFMHHMO, in ODNKLLDKFAN EJGKPEEKGAP);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HENGGCJCHBF JBJOANGCBJI(ByteString PJNGDEEPICH);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	EFPBMMGJJNJ BEGOHNFKPGH(ByteString NCMINFKEPHO, EGCGFMJAHFA GMBPOBACJJI, in ODNKLLDKFAN ONNLMMBAJJD, EECBOFEPKOA COGFCPDHECD, bool OMBCCNACKEH = true);

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JIHKHKDNEMA();

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void DPPIHHEMFMC(bool EGKCDLFCJOD);

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(Slot = "12")]
	LOHOBBBFGHK CPLJBADNAEG(IEnumerable<JJCFDHHONOD> FJHKAMEFPLO);
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class GPGHEKKLBGF
{
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface HMNLDCKGKOJ : DHGPCIFNMIN, OFOPFPOKLCG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool CGHLOCINKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	INOKHALMKHF MMOACKEICIN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	KGKLOPPOEBG KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface OFOPFPOKLCG
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool LELEOIAOIIC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface JMLOMKJHAHL
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool JEFPNBPEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface IJMOBOOEKHC
{
	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	Guid NCJJKPCOEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JPFFJINGJKA(Guid MMKFOAANGLN, Guid IAHLLEDDMDA, string PPPOJKMOIGD);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public struct ONLLLANPENF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	internal int FHMAJLHBFAD;

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAEE0", Offset = "0x5EA9CE0", VA = "0x185EAAEE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public static class KPKMGIHBILP
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	private struct EDNNGEFMHBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public Guid LOOGPKNLJEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public PHBHKKGIEBE ECBJGHPPIGB;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	private struct PHBHKKGIEBE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int KKLNCEHOHED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int DEOCDKKAALM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int KIODOEEPPFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public int JLEIHIHLLPM;

		[Cpp2IlInjected.Token(Token = "0x60002DB")]
		[Cpp2IlInjected.Address(RVA = "0x5EABC00", Offset = "0x5EAAA00", VA = "0x185EABC00")]
		public bool OFFEDPHOGBM(out PPDNOHKLMNC NNKJCELFGML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(RVA = "0x5EABCA0", Offset = "0x5EAAAA0", VA = "0x185EABCA0")]
		public PHBHKKGIEBE(PPDNOHKLMNC NNKJCELFGML)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C60", Offset = "0x5EA8A60", VA = "0x185EA9C60")]
	public static Guid HCAIEMPDCIP(this PPDNOHKLMNC NNKJCELFGML)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9C40", Offset = "0x5EA8A40", VA = "0x185EA9C40")]
	public static bool FNADJJMCLBO(this Guid LOOGPKNLJEM, out PPDNOHKLMNC NNKJCELFGML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(GBHCPIKMIBP))]
public readonly struct EGCGFMJAHFA : IComparable<EGCGFMJAHFA>, IEquatable<EGCGFMJAHFA>
{
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly EGCGFMJAHFA IOPEGLNHBHH;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002DD")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	public LocalId PKEOOPEGNMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002DE")]
		[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public bool MIGIONPGLDD
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F260", Offset = "0x5E9E060", VA = "0x185E9F260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public bool AGKGJCHEPIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002E0")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F0E0", Offset = "0x5E9DEE0", VA = "0x185E9F0E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public bool NCHEHEGLPAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(RVA = "0x5E9F3E0", Offset = "0x5E9E1E0", VA = "0x185E9F3E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F500", Offset = "0x5E9E300", VA = "0x185E9F500")]
	public EGCGFMJAHFA(CDNFKKBDBMA GPEMFEPGICP, LocalId OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
	public JDCDHMJMEPN IDNGMNNPANE()
	{
		return default(JDCDHMJMEPN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(RVA = "0x989080", Offset = "0x987E80", VA = "0x180989080")]
	public static LocalId HAJGNNHEPJI(EGCGFMJAHFA AAPJBIAEHBO)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F330", Offset = "0x5E9E130", VA = "0x185E9F330")]
	public static Entity HAJGNNHEPJI(EGCGFMJAHFA AAPJBIAEHBO)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F160", Offset = "0x5E9DF60", VA = "0x185E9F160")]
	public static bool DDONPFMGGHF(EGCGFMJAHFA IKGMJGNOMBA, EGCGFMJAHFA GOEPIJCAGGA)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F340", Offset = "0x5E9E140", VA = "0x185E9F340")]
	public static bool HDFILCNJOKD(EGCGFMJAHFA IKGMJGNOMBA, EGCGFMJAHFA GOEPIJCAGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F400", Offset = "0x5E9E200", VA = "0x185E9F400", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F1B0", Offset = "0x5E9DFB0", VA = "0x185E9F1B0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9F100", Offset = "0x5E9DF00", VA = "0x185E9F100", Slot = "4")]
	public int CompareTo(EGCGFMJAHFA FGBEDAPNDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "5")]
	public bool Equals(EGCGFMJAHFA FGBEDAPNDEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public static class NHMDOAGLFKC
{
	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAAF0", Offset = "0x5EA98F0", VA = "0x185EAAAF0")]
	public static PPDNOHKLMNC LKAFDOMHKHO(this EGCGFMJAHFA GNOEFMFMEOO)
	{
		return default(PPDNOHKLMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(RVA = "0x340A050", Offset = "0x3408E50", VA = "0x18340A050")]
	public static T DGLKIMDNLGJ<T>(this EGCGFMJAHFA GNOEFMFMEOO) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
internal sealed class GBHCPIKMIBP
{
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface OFNDOOEFNOF
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool CGHLOCINKNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void APBNGMGGMEG(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60002F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CFILBMCKDIO(EGCGFMJAHFA OEJOEELBGEB, bool HDOHPPEDCPA, bool KPLCIBPDIJA, bool KMNIGCGNOCD);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public readonly struct DAPGHFKBGOH : IEquatable<DAPGHFKBGOH>
{
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly DAPGHFKBGOH EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	private IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x5E9D7D0", Offset = "0x5E9C5D0", VA = "0x185E9D7D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F3")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D540", Offset = "0x5E9C340", VA = "0x185E9D540")]
	public void FHFELKAFFJP(bool KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D680", Offset = "0x5E9C480", VA = "0x185E9D680")]
	public void KDMJFOLIMKH(bool KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x2EE5140", Offset = "0x2EE3F40", VA = "0x182EE5140")]
	public T MINGPBOLJHG<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public DAPGHFKBGOH(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D440", Offset = "0x5E9C240", VA = "0x185E9D440", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(DAPGHFKBGOH FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public readonly struct LODIOIHKCAM : IEquatable<LODIOIHKCAM>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly LODIOIHKCAM EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x5EA9FB0", Offset = "0x5EA8DB0", VA = "0x185EA9FB0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(LODIOIHKCAM FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface NGDGEEKNEHK
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool IBMLGOIGNAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	bool JACJBGLJJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000307")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool NIJIGGCMNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000308")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	bool FIMCEINEHEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000309")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	bool GKJGDMGNKPK
	{
		[Cpp2IlInjected.Token(Token = "0x600030A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool DCFANPDICKB
	{
		[Cpp2IlInjected.Token(Token = "0x600030B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool LDCPCFKGALI
	{
		[Cpp2IlInjected.Token(Token = "0x600030C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public struct GGHGDNIFHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float ANELFAJAIBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public float3 AEKDOICBOKF;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public readonly struct GCGKCAKBOCM : IEquatable<GCGKCAKBOCM>
{
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public static readonly GCGKCAKBOCM EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private MCAIDCPBDEA MHMCBIEMFMM
	{
		[Cpp2IlInjected.Token(Token = "0x600030D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4AB0", Offset = "0x5EA38B0", VA = "0x185EA4AB0")]
		get
		{
			return default(MCAIDCPBDEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public ICMJGOAJEAL AFCICKOPBFK
	{
		[Cpp2IlInjected.Token(Token = "0x600030E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4950", Offset = "0x5EA3750", VA = "0x185EA4950")]
		get
		{
			return default(ICMJGOAJEAL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public LBALCBPLGDJ AJDONAOKLKN
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4470", Offset = "0x5EA3270", VA = "0x185EA4470")]
		get
		{
			return default(LBALCBPLGDJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public KHAHNKKFMAD MDIIABIIJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000310")]
		[Cpp2IlInjected.Address(RVA = "0x5EA43A0", Offset = "0x5EA31A0", VA = "0x185EA43A0")]
		get
		{
			return default(KHAHNKKFMAD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public EShapeType DKCBJGEFDIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x5EA47F0", Offset = "0x5EA35F0", VA = "0x185EA47F0")]
		get
		{
			return default(EShapeType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public RenderableColor PMLMMLIFOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4340", Offset = "0x5EA3140", VA = "0x185EA4340")]
		get
		{
			return default(RenderableColor);
		}
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x5EA49B0", Offset = "0x5EA37B0", VA = "0x185EA49B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public RenderableMaterial JECIEOCHDJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4790", Offset = "0x5EA3590", VA = "0x185EA4790")]
		get
		{
			return default(RenderableMaterial);
		}
		[Cpp2IlInjected.Token(Token = "0x6000317")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4720", Offset = "0x5EA3520", VA = "0x185EA4720")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	public float GJMEMCHAOCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4630", Offset = "0x5EA3430", VA = "0x185EA4630")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000319")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4B10", Offset = "0x5EA3910", VA = "0x185EA4B10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public Vector3 NCKDNHNOMKN
	{
		[Cpp2IlInjected.Token(Token = "0x600031A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4690", Offset = "0x5EA3490", VA = "0x185EA4690")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600031B")]
		[Cpp2IlInjected.Address(RVA = "0x5EA4A20", Offset = "0x5EA3820", VA = "0x185EA4A20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public float DMHCAACEEGH
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA42C0", Offset = "0x5EA30C0", VA = "0x185EA42C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public ShapeConfigData.Flags OJALKNBPDNM
	{
		[Cpp2IlInjected.Token(Token = "0x600031D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA44D0", Offset = "0x5EA32D0", VA = "0x185EA44D0")]
		get
		{
			return default(ShapeConfigData.Flags);
		}
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA48E0", Offset = "0x5EA36E0", VA = "0x185EA48E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public FKEFBLGGPHP IKKLJOKNNAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(FKEFBLGGPHP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4400", Offset = "0x5EA3200", VA = "0x185EA4400")]
	public ICLEMBLIKFF DKFMIEEPIDE()
	{
		return default(ICLEMBLIKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4870", Offset = "0x5EA3670", VA = "0x185EA4870")]
	public BNPEKHGFBMJ KNDNGLNABBG()
	{
		return default(BNPEKHGFBMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public GCGKCAKBOCM(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000321")]
	[Cpp2IlInjected.Address(RVA = "0x5E9B3B0", Offset = "0x5E9A1B0", VA = "0x185E9B3B0")]
	public static bool HAJGNNHEPJI(GCGKCAKBOCM KKLNCEHOHED)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5EA4530", Offset = "0x5EA3330", VA = "0x185EA4530", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(GCGKCAKBOCM FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[PPDINNBPCDB(NFMGCFGBFLP.Application)]
public interface IAGPNKHNJAG
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	JNPNBLMGJNE MMOACKEICIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	KGKLOPPOEBG KBFCANGCPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	HOLKDEPHBHG ABKBCFGBHIP
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	GAMJOBMBKDF HMGBIMLLIDC
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	BMMKBCLGEDD BOOMKPADGLL
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	FNHNJDOHGDF LEHEFCPCFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	HPJHHHKBOLM JBPIMCMKPGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	HJOIEGBCDDK GNALOHFFOPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	DEFFONLDLEO FADCHLOJMFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	KHJOHKIKAGA GLFPNGNJCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	EGJODGEMJGD IDJICFGNOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	LDHHHBGOMGM KINPIAJFGJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	HDIJNAIPGLJ EPHLMBIPBJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	MBLNLHCNOCK LODOLHLKCHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	AAOBMHINIMM GDPPCFHFBLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	NGDGEEKNEHK BDHMLJIPDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface GMELLNOFCIA
{
	[Cpp2IlInjected.Token(Token = "0x17000104")]
	object NBNCEBBCFIA
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLADKEJLEBH(CDOABBFCKIF HMMLJFMHHMO);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface GAMJOBMBKDF
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public delegate void BOIAAKKHABP(CDOABBFCKIF FMGNJAHHCOF, CDOABBFCKIF HIPOLAHDLFA, CDOABBFCKIF AHCGDJIGIJB);

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EGCGFMJAHFA ACALPEOJJIH(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGCGFMJAHFA CKKAENBKGMB(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KPFIAOMFCDP(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA GMBPOBACJJI, bool EKFONMIOIIG);

	[Cpp2IlInjected.Token(Token = "0x600033F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DLPINOKCEKM(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA GMBPOBACJJI);

	[Cpp2IlInjected.Token(Token = "0x6000340")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int GDINJAGHMJC(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000341")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CDOABBFCKIF KLJDMEJPGKB(EGCGFMJAHFA BBBLGPNEOJP);

	[Cpp2IlInjected.Token(Token = "0x6000342")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DHDIPLBHNLJ(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA OLLEKHLPKMA);

	[Cpp2IlInjected.Token(Token = "0x6000343")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool EDPIPGNIGHF(EGCGFMJAHFA OEJOEELBGEB, EGCGFMJAHFA KMPLFHBLGCG);

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EGCGFMJAHFA HDKHBJKMLAM(EGCGFMJAHFA OLLEKHLPKMA, EGCGFMJAHFA DLMHFCCJCIF);

	[Cpp2IlInjected.Token(Token = "0x6000345")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FNAKPAOKEEO(EGCGFMJAHFA OLLEKHLPKMA, EGCGFMJAHFA DLMHFCCJCIF, out EGCGFMJAHFA JFMCOBGBKLO);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class KGIKMDGFJEA
{
	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA93B0", Offset = "0x5EA81B0", VA = "0x185EA93B0")]
	public static bool KCGKKPBCEJL(this GAMJOBMBKDF LJIJHMFKHEN, EGCGFMJAHFA OEJOEELBGEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public enum KKFCHOEILIG
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
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface HPJHHHKBOLM
{
	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<EGCGFMJAHFA> HNKOPKJDFEF(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600034C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EGCGFMJAHFA LLIPPNBNPHA(EGCGFMJAHFA OEJOEELBGEB, int FHOMILACEHB);

	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FHDOGDBPFNJ(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HINIBFNNAPD CFEGCFNDGFH(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOOBKJHGHML(EGCGFMJAHFA OEJOEELBGEB, HINIBFNNAPD FBDHILNJDOE);

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(Slot = "5")]
	EGCGFMJAHFA LJHDDMLBHPE(EGCGFMJAHFA OEJOEELBGEB, [Optional] float3? IHHJAKDKGPC, [Optional] quaternion? EMNOFGLPALH, [Optional] float3? OLFLAEBOOJB);

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(Slot = "6")]
	EGCGFMJAHFA IJEDPJGEGFJ(EGCGFMJAHFA OEJOEELBGEB, int FHOMILACEHB, [Optional] float3? IHHJAKDKGPC, [Optional] quaternion? EMNOFGLPALH, [Optional] float3? OLFLAEBOOJB);

	[Cpp2IlInjected.Token(Token = "0x6000352")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PFJLOHDONJH(EGCGFMJAHFA OEJOEELBGEB, int FHOMILACEHB);

	[Cpp2IlInjected.Token(Token = "0x6000353")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KEGIDHHBLOD(EGCGFMJAHFA OEJOEELBGEB);
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface NMLJPPMIMAI
{
	[Cpp2IlInjected.Token(Token = "0x6000354")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GBALJNCDLBO(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x6000355")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OKKIAKFJKJL(EGCGFMJAHFA OEJOEELBGEB, Transform NCDMMOPONFH);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public interface PFJNNBEFCFI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000105")]
	LocalId OCBIDCIBHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	LocalId FADHLMFGCPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EEKDPHCHPJC(float3 IHBDKLJGANO);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EJNGEOBGCBD(float3 IHBDKLJGANO);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void AAMIAMKEHJO(out float3 IOEACHBFFDL, out float3 IJAHGCHCONN);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MANGNCBPLBG(float3 IOEACHBFFDL, float3 IJAHGCHCONN);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HIFFPEECLPA(Color IOEACHBFFDL, Color IJAHGCHCONN);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	PFJNNBEFCFI Instantiate(Transform NCDMMOPONFH);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public interface MLPGAENPCHF
{
	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HFKECJNCAPE(Transform NCDMMOPONFH, PFJNNBEFCFI KMAKBEIENOG);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PFJNNBEFCFI KGLCPGPOBCE();
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public readonly struct MOGDFBPMCIK : IEquatable<MOGDFBPMCIK>
{
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public static readonly MOGDFBPMCIK EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	private GIJGGOCAAGH LENDJCHHAPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA860", Offset = "0x5EA9660", VA = "0x185EAA860")]
		get
		{
			return default(GIJGGOCAAGH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public PropType ALHAKFIOJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(RVA = "0x5EAA8C0", Offset = "0x5EA96C0", VA = "0x185EAA8C0")]
		get
		{
			return default(PropType);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000369")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA6B0", Offset = "0x5EA94B0", VA = "0x185EAA6B0")]
	public MOBBDFCAHDJ CNOFOJOEKAA()
	{
		return default(MOBBDFCAHDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public MOGDFBPMCIK(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA760", Offset = "0x5EA9560", VA = "0x185EAA760", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(MOGDFBPMCIK FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public interface HOCKBJCDGGC
{
	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JBDBKKABEHP();
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public static class JEBLAJPFCIB
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA7CC0", Offset = "0x5EA6AC0", VA = "0x185EA7CC0")]
	public static void JBDBKKABEHP(this GameObject CJDEFKBLNIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public readonly struct AEALHANJMEB : IEquatable<AEALHANJMEB>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly AEALHANJMEB EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A5B0", Offset = "0x5E993B0", VA = "0x185E9A5B0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(AEALHANJMEB FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public readonly struct OJIBEGMBHLE : IEquatable<OJIBEGMBHLE>
{
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public static readonly OJIBEGMBHLE EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public OJIBEGMBHLE(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(RVA = "0x5EAADA0", Offset = "0x5EA9BA0", VA = "0x185EAADA0", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(OJIBEGMBHLE FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(RVA = "0x5EAAC70", Offset = "0x5EA9A70", VA = "0x185EAAC70")]
	public bool DCEPDHKJHCL(out Collider DMENEKHAENG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public readonly struct IMCADCANEEI : IEquatable<IMCADCANEEI>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly IMCADCANEEI EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	public EGCGFMJAHFA EJJMACKJOJB
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x13278A0", Offset = "0x13266A0", VA = "0x1813278A0")]
		get
		{
			return default(EGCGFMJAHFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000381")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	public BNPEKHGFBMJ LPKJHOGDGCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000382")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6CF0", Offset = "0x5EA5AF0", VA = "0x185EA6CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	public float3 KBGIFGGDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6DB0", Offset = "0x5EA5BB0", VA = "0x185EA6DB0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5EA67E0", Offset = "0x5EA55E0", VA = "0x185EA67E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	public quaternion LGFANIGDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6970", Offset = "0x5EA5770", VA = "0x185EA6970")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6A60", Offset = "0x5EA5860", VA = "0x185EA6A60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	public float3 IAHOPOOBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000387")]
		[Cpp2IlInjected.Address(RVA = "0x5EA66F0", Offset = "0x5EA54F0", VA = "0x185EA66F0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000388")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6BA0", Offset = "0x5EA59A0", VA = "0x185EA6BA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public MGGFHICFICB BKHKNAKODKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000389")]
		[Cpp2IlInjected.Address(RVA = "0x5EA69F0", Offset = "0x5EA57F0", VA = "0x185EA69F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	private OALNNEAPKJG JKCFANPNPLJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6B40", Offset = "0x5EA5940", VA = "0x185EA6B40")]
		get
		{
			return default(OALNNEAPKJG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	private CDCHGCFMMCH EFDNJDJBPOI
	{
		[Cpp2IlInjected.Token(Token = "0x600038E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6780", Offset = "0x5EA5580", VA = "0x185EA6780")]
		get
		{
			return default(CDCHGCFMMCH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	private PHOOAFNEFIP ALEHOODAGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6C30", Offset = "0x5EA5A30", VA = "0x185EA6C30")]
		get
		{
			return default(PHOOAFNEFIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	private NIGCACGEJIH AKAEHFEFAPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6AE0", Offset = "0x5EA58E0", VA = "0x185EA6AE0")]
		get
		{
			return default(NIGCACGEJIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	private LFFHFBKGHAF BAMKIGNJEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5EA6C90", Offset = "0x5EA5A90", VA = "0x185EA6C90")]
		get
		{
			return default(LFFHFBKGHAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public IMCADCANEEI(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6870", Offset = "0x5EA5670", VA = "0x185EA6870", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(IMCADCANEEI FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6630", Offset = "0x5EA5430", VA = "0x185EA6630")]
	public void BDDGBKOIGFG(BNPEKHGFBMJ KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA67E0", Offset = "0x5EA55E0", VA = "0x185EA67E0")]
	public void FPCDFCHKMIG(float3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x5EA6A60", Offset = "0x5EA5860", VA = "0x185EA6A60")]
	public void HKJCCFPDNDG(quaternion KKLNCEHOHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
public readonly struct FKEFBLGGPHP : IEquatable<FKEFBLGGPHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly FKEFBLGGPHP EFLECOJHDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly EGCGFMJAHFA BBBLGPNEOJP;

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public JDCDHMJMEPN NNNKAJFAJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5E9A590", Offset = "0x5E99390", VA = "0x185E9A590")]
		get
		{
			return default(JDCDHMJMEPN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	private CDNFKKBDBMA IOPJFELLEEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000399")]
		[Cpp2IlInjected.Address(RVA = "0x91A1D0", Offset = "0x918FD0", VA = "0x18091A1D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	private BMMKBCLGEDD FEMBKOKPEFL
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3200", Offset = "0x5EA2000", VA = "0x185EA3200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public bool MELHHIDEAPB
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1340", Offset = "0x5EA0140", VA = "0x185EA1340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public Vector3 KBGIFGGDLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3920", Offset = "0x5EA2720", VA = "0x185EA3920")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5EA18A0", Offset = "0x5EA06A0", VA = "0x185EA18A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	public Quaternion LGFANIGDMEB
	{
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1F40", Offset = "0x5EA0D40", VA = "0x185EA1F40")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x5EA22A0", Offset = "0x5EA10A0", VA = "0x185EA22A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	public Vector3 BGOHBKDCLPD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2C90", Offset = "0x5EA1A90", VA = "0x185EA2C90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1050", Offset = "0x5E9FE50", VA = "0x185EA1050")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	public Quaternion NFHCBBLAFHD
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5EA16F0", Offset = "0x5EA04F0", VA = "0x185EA16F0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3270", Offset = "0x5EA2070", VA = "0x185EA3270")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	public float JEAFPGEMHME
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2520", Offset = "0x5EA1320", VA = "0x185EA2520")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2760", Offset = "0x5EA1560", VA = "0x185EA2760")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public float EBNLFIFLFJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5EA3BD0", Offset = "0x5EA29D0", VA = "0x185EA3BD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public Vector3 IAHOPOOBAKM
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0EA0", Offset = "0x5E9FCA0", VA = "0x185EA0EA0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5EA2B50", Offset = "0x5EA1950", VA = "0x185EA2B50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public Vector3 GBBPPJFLAIN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5EA1E00", Offset = "0x5EA0C00", VA = "0x185EA1E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public Vector3 CLFGGCJMJGM
	{
		[Cpp2IlInjected.Token(Token = "0x60003AB")]
		[Cpp2IlInjected.Address(RVA = "0x5EA33B0", Offset = "0x5EA21B0", VA = "0x185EA33B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public Matrix4x4 ILCHBAOBPBB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AC")]
		[Cpp2IlInjected.Address(RVA = "0x5EA0D10", Offset = "0x5E9FB10", VA = "0x185EA0D10")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x27DDD30", Offset = "0x27DCB30", VA = "0x1827DDD30")]
	public FKEFBLGGPHP(EGCGFMJAHFA OEJOEELBGEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x81C5F0", Offset = "0x81B3F0", VA = "0x18081C5F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1D00", Offset = "0x5EA0B00", VA = "0x185EA1D00", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A6B0", Offset = "0x5E994B0", VA = "0x185E9A6B0", Slot = "4")]
	public bool Equals(FKEFBLGGPHP FGBEDAPNDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5E9A750", Offset = "0x5E99550", VA = "0x185E9A750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x5EA20F0", Offset = "0x5EA0EF0", VA = "0x185EA20F0")]
	public OKJPIDOHDOO FLMNNEJJPKN()
	{
		return default(OKJPIDOHDOO);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA29B0", Offset = "0x5EA17B0", VA = "0x185EA29B0")]
	public void HLOOKBJLEBD(out Matrix4x4 BJJJIKJJEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0520", Offset = "0x5E9F320", VA = "0x185EA0520")]
	public void AFLFKACNPJI(out Vector3 KBBHCINHHIJ, out Quaternion FEDGNKCMFLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3CD0", Offset = "0x5EA2AD0", VA = "0x185EA3CD0")]
	public void POLHMLBNOOH(out RigidTransform LKHKNDNOGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0A60", Offset = "0x5E9F860", VA = "0x185EA0A60")]
	public ODNKLLDKFAN BAOICEIGCAP()
	{
		return default(ODNKLLDKFAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B1")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0AB0", Offset = "0x5E9F8B0", VA = "0x185EA0AB0")]
	public void BAOICEIGCAP(out ODNKLLDKFAN NGAPJKPAILJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1B90", Offset = "0x5EA0990", VA = "0x185EA1B90")]
	public ODNKLLDKFAN EHHFOJBKNCD()
	{
		return default(ODNKLLDKFAN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1BE0", Offset = "0x5EA09E0", VA = "0x185EA1BE0")]
	public void EHHFOJBKNCD(out ODNKLLDKFAN LKHKNDNOGKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA19E0", Offset = "0x5EA07E0", VA = "0x185EA19E0")]
	public Vector3 EHAAHHDBHAP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2160", Offset = "0x5EA0F60", VA = "0x185EA2160")]
	public void FPCDFCHKMIG(in Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3770", Offset = "0x5EA2570", VA = "0x185EA3770")]
	public Vector3 NHIOHCODODI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0BD0", Offset = "0x5E9F9D0", VA = "0x185EA0BD0")]
	public void BNFMKAFFIAJ(in Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B8")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1390", Offset = "0x5EA0190", VA = "0x185EA1390")]
	public Quaternion DIFNNBFCANC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B9")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2870", Offset = "0x5EA1670", VA = "0x185EA2870")]
	public void HKJCCFPDNDG(in Quaternion KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BA")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1190", Offset = "0x5E9FF90", VA = "0x185EA1190")]
	public Quaternion DFOONNBMMGG()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5EA30C0", Offset = "0x5EA1EC0", VA = "0x185EA30C0")]
	public void INHPKBPADCA(in Quaternion KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BC")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3670", Offset = "0x5EA2470", VA = "0x185EA3670")]
	public float NEHHGIANKPM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0D90", Offset = "0x5E9FB90", VA = "0x185EA0D90")]
	public void CCCLNDOOOIF(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3AD0", Offset = "0x5EA28D0", VA = "0x185EA3AD0")]
	public float OOJAGOGKBBP()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5EA3560", Offset = "0x5EA2360", VA = "0x185EA3560")]
	public void MJDMGADAOMI(float KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x5EA23E0", Offset = "0x5EA11E0", VA = "0x185EA23E0")]
	public void GGHJMELDFIH(in Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x5EA1540", Offset = "0x5EA0340", VA = "0x185EA1540")]
	public Vector3 DJBHIHODNDB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C2")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2F80", Offset = "0x5EA1D80", VA = "0x185EA2F80")]
	public void IJGLKEGDJCP(in Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C3")]
	[Cpp2IlInjected.Address(RVA = "0x5EA08B0", Offset = "0x5E9F6B0", VA = "0x185EA08B0")]
	public Vector3 BAGJDJDLFGC()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C4")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2620", Offset = "0x5EA1420", VA = "0x185EA2620")]
	public void HACFEBJDCOM(in Vector3 KKLNCEHOHED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0700", Offset = "0x5E9F500", VA = "0x185EA0700")]
	public Vector3 APGCCJILNJE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x5EA2E40", Offset = "0x5EA1C40", VA = "0x185EA2E40")]
	public void IGALDPIAIFN(in Vector3 KKLNCEHOHED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface CDNFKKBDBMA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000126")]
	IAGPNKHNJAG JNLGKDEJPLF
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ObjectType BNDFCJCKGAJ(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ObjectPrefabType FGMNFKBHEPH(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MAHHBIDHLIK(PPDNOHKLMNC NNKJCELFGML, DLFCAAPBCNB NKMFCGHJDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	JDCDHMJMEPN HMJAFGNACLP(EGCGFMJAHFA OEJOEELBGEB, [Optional] object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DBDOPLPECKC(EGCGFMJAHFA OEJOEELBGEB, out DLFCAAPBCNB NKMFCGHJDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JLPNJECPOMC(DLFCAAPBCNB NKMFCGHJDIJ);

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool KGLGHDGLOLB(EGCGFMJAHFA OEJOEELBGEB, out Transform NCDMMOPONFH);

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool NFHLHGHAJCK(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FNBJOGDEBIO(LocalId OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool KFGPKNPHNIL(LocalId OEJOEELBGEB, object GKNJCIECGND);

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	EGCGFMJAHFA JIAJNBBCGOD(PPDNOHKLMNC NNKJCELFGML);

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	PPDNOHKLMNC LKAFDOMHKHO(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	CDOABBFCKIF JIAJNBBCGOD(NativeArray<PPDNOHKLMNC> NNKJCELFGML, Allocator FIPHDKMNFDJ);

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	CDOABBFCKIF HKDOJHPMFAG(NativeArray<PPDNOHKLMNC> NNKJCELFGML, NativeArray<EBEDPNDMCJC> DILLCDMPONC, Allocator FIPHDKMNFDJ);

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	JDCDHMJMEPN KONCHCMPDBG(ObjectPrefabType HPLFBDKKOIF, bool IPPPEEEGCKG);

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	JDCDHMJMEPN KONCHCMPDBG(ObjectPrefabType HPLFBDKKOIF);

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	JDCDHMJMEPN FAOABBAOPIH(ObjectPrefabType HPLFBDKKOIF);

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JDCDHMJMEPN HKDOJHPMFAG(PPDNOHKLMNC NNKJCELFGML, ObjectPrefabType HPLFBDKKOIF);

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IFHGODGECMD BCPJCINMMOF();

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	BNPEKHGFBMJ FFPFIIJLNBE();

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	ICLEMBLIKFF HNEMCFDDJMA(PrimitiveShapeType BPDBGKDLGDK);

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void EOKLDLIBOGD(CDOABBFCKIF HMMLJFMHHMO);

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MBKJDOLMADL(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void GDFDAAJIGMM(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void EOKLDLIBOGD(EGCGFMJAHFA OEJOEELBGEB);

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CDOABBFCKIF LEJEJGLKGHG(CDOABBFCKIF LNCIIPGMOGH, Allocator FIPHDKMNFDJ);

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool MIGIONPGLDD(EGCGFMJAHFA OEJOEELBGEB);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public static class DDLIBLMOGJP
{
	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5E9DD40", Offset = "0x5E9CB40", VA = "0x185E9DD40")]
	public static JDCDHMJMEPN GNKBBLAMAOK(this CDNFKKBDBMA FMGNJAHHCOF, LocalId OEJOEELBGEB)
	{
		return default(JDCDHMJMEPN);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E000", Offset = "0x5E9CE00", VA = "0x185E9E000")]
	public static EGCGFMJAHFA JIAJNBBCGOD(this CDNFKKBDBMA FMGNJAHHCOF, LocalId OEJOEELBGEB)
	{
		return default(EGCGFMJAHFA);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E020", Offset = "0x5E9CE20", VA = "0x185E9E020")]
	public static PPDNOHKLMNC LKAFDOMHKHO(this CDNFKKBDBMA FMGNJAHHCOF, LocalId OEJOEELBGEB)
	{
		return default(PPDNOHKLMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5E9E140", Offset = "0x5E9CF40", VA = "0x185E9E140")]
	public static bool MIGIONPGLDD(this CDNFKKBDBMA FMGNJAHHCOF, PPDNOHKLMNC NNKJCELFGML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x2EE5DF0", Offset = "0x2EE4BF0", VA = "0x182EE5DF0")]
	public static T DGLKIMDNLGJ<T>(this CDNFKKBDBMA FMGNJAHHCOF, LocalId OEJOEELBGEB) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D860", Offset = "0x5E9C660", VA = "0x185E9D860")]
	public static IFHGODGECMD ACNIMHADONI(this CDNFKKBDBMA FMGNJAHHCOF, RigidTransform NGAPJKPAILJ, [Optional] object GKNJCIECGND)
	{
		return default(IFHGODGECMD);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5E9DBF0", Offset = "0x5E9C9F0", VA = "0x185E9DBF0")]
	public static ICLEMBLIKFF DMNJKIFOBHJ(this CDNFKKBDBMA FMGNJAHHCOF, PrimitiveShapeType EBICKLHNAED, RigidTransform NGAPJKPAILJ, [Optional] object GKNJCIECGND)
	{
		return default(ICLEMBLIKFF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5E9DAB0", Offset = "0x5E9C8B0", VA = "0x185E9DAB0")]
	public static BNPEKHGFBMJ DJAPADNCJEO(this CDNFKKBDBMA FMGNJAHHCOF, RigidTransform NGAPJKPAILJ, [Optional] object GKNJCIECGND)
	{
		return default(BNPEKHGFBMJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5E9D9A0", Offset = "0x5E9C7A0", VA = "0x185E9D9A0")]
	private static void DDIMPLMHPAO(JDCDHMJMEPN KOLHGNCFJEF, RigidTransform NGAPJKPAILJ, [Optional] object GKNJCIECGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5E9DDF0", Offset = "0x5E9CBF0", VA = "0x185E9DDF0")]
	internal static MOBBDFCAHDJ IBAKDGPPPAM(this CDNFKKBDBMA FMGNJAHHCOF, GJANPBGBPGA NNEJIIMJAGJ, [Optional] object GKNJCIECGND)
	{
		return default(MOBBDFCAHDJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
internal static class MDECPAHIJIL
{
	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA380", Offset = "0x5EA9180", VA = "0x185EAA380")]
	public static HOLKDEPHBHG ABKBCFGBHIP(this EGCGFMJAHFA PJCEAFJNLLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5EAA3F0", Offset = "0x5EA91F0", VA = "0x185EAA3F0")]
	public static EntityManager FOKKLIPOJAA(this EGCGFMJAHFA PJCEAFJNLLG)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x302F0C0", Offset = "0x302DEC0", VA = "0x18302F0C0")]
	public static T JMJIKDOFAHD<T>(this EGCGFMJAHFA PJCEAFJNLLG) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(RVA = "0x302F050", Offset = "0x302DE50", VA = "0x18302F050")]
	public static bool DIEIJJAHGDE<T>(this EGCGFMJAHFA PJCEAFJNLLG) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
internal interface DMFAINFPHCM
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event GAMJOBMBKDF.BOIAAKKHABP DICLIACCIOE;
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[PPDINNBPCDB(NFMGCFGBFLP.LoadInstance)]
public interface DEFFONLDLEO
{
	[Cpp2IlInjected.Token(Token = "0x17000127")]
	bool JMELHKPHGEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	EGCGFMJAHFA CFPOOAFMEPM
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003F8")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	JDCDHMJMEPN IHIJAOFPHMC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F9")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60003FA")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	JDCDHMJMEPN ECBCIBEMELF
	{
		[Cpp2IlInjected.Token(Token = "0x60003FB")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event FAHNIKHOLJO IHMKBLDAENM;

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EGCGFMJAHFA HDKHBJKMLAM(EGCGFMJAHFA OLLEKHLPKMA, EGCGFMJAHFA DLMHFCCJCIF);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FNAKPAOKEEO(EGCGFMJAHFA OLLEKHLPKMA, EGCGFMJAHFA DLMHFCCJCIF, out EGCGFMJAHFA JFMCOBGBKLO);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PHFACGBBKOD();

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PPLPDMJHDPF();

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LGOPCAJHEDF(EGCGFMJAHFA LMBGOHINBAF);
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public delegate void FAHNIKHOLJO(JDCDHMJMEPN PCDDBCJLBIM, JDCDHMJMEPN IDLNLDCNHGD);
[Cpp2IlInjected.Token(Token = "0x200007C")]
public static class ELIGGICCMEO
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0270", Offset = "0x5E9F070", VA = "0x185EA0270")]
	public static bool KLILBBGIHPH(this DEFFONLDLEO PLAFHEKALID, JDCDHMJMEPN LMBGOHINBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FED0", Offset = "0x5E9ECD0", VA = "0x185E9FED0")]
	public static bool HGGGDBFHHOG(this DEFFONLDLEO PLAFHEKALID, EGCGFMJAHFA LMBGOHINBAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5E9FDD0", Offset = "0x5E9EBD0", VA = "0x185E9FDD0")]
	public static bool CNAOCLNOFKP(this DEFFONLDLEO PLAFHEKALID, EGCGFMJAHFA LMBGOHINBAF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[DefaultMember("Item")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface IDFILDCBEOJ : IEnumerable<EHMBLNLEMLJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	int EFAPJKDFNLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000408")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	EHMBLNLEMLJ MBJPBAGAKFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000409")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	EHMBLNLEMLJ AKDLJNBFGMH(KDKGBCPHDHM LNCLBGGHDHA);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GPEHGPANNHP HIGAAKNJNFP(KDKGBCPHDHM LNCLBGGHDHA);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public static class FKPMPGFKGHC
{
	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x233A960", Offset = "0x2339760", VA = "0x18233A960")]
	public static OMOMEIBPMLA<T> AKDLJNBFGMH<T>(this IDFILDCBEOJ FMCLAGCEHFA, KDKGBCPHDHM PPPOJKMOIGD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x233AA90", Offset = "0x2339890", VA = "0x18233AA90")]
	public static OMOMEIBPMLA<T> AKDLJNBFGMH<T>(this IDFILDCBEOJ FMCLAGCEHFA, NIBEAOLLINL<T> PPPOJKMOIGD) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x233ABE0", Offset = "0x23399E0", VA = "0x18233ABE0")]
	public static GPEHGPANNHP HIGAAKNJNFP<T>(this IDFILDCBEOJ FMCLAGCEHFA, NIBEAOLLINL<T> PPPOJKMOIGD) where T : struct
	{
		return default(GPEHGPANNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface BNIOGIGEIDG : OJNFEIACNDC
{
	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ALOHGLGNMHD DFIBBFDDCCC(Entity FPIIEOBJDDB);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOHMOIOGMMK(NativeArray<ALOHGLGNMHD> LCNCFLFAFML, NativeArray<ODDPDHOJCLL> INLPHPEDOPO);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NNCJNFAHADM(ALOHGLGNMHD PDHOEHKDKMC);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PCCDGHIOBDD(ALOHGLGNMHD PDHOEHKDKMC, out Collider DMENEKHAENG);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public struct ODDPDHOJCLL : ISystemStateComponentData, IComponentData, IEquatable<ODDPDHOJCLL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 AIGMHLBKCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 ICBBPMPBDDG;

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1943940", Offset = "0x1942740", VA = "0x181943940", Slot = "4")]
	public bool Equals(ODDPDHOJCLL FGBEDAPNDEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public struct JJCFDHHONOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Guid LOOGPKNLJEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public string FDDFNICFOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Vector3 IHHJAKDKGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Quaternion EMNOFGLPALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector3 OLFLAEBOOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public int KGGFCEGIFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Dictionary<string, object> FBDHILNJDOE;

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8D70", Offset = "0x5EA7B70", VA = "0x185EA8D70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x5EA8BE0", Offset = "0x5EA79E0", VA = "0x185EA8BE0")]
	private static string FKLFHCLOLKD(Dictionary<string, object> FIJKCKMMGEF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public enum EHGEPHMBMPE
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public enum BMKGIIKACFN
{
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public static class CNPPPAFHLHK
{
	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0xBE5150", Offset = "0xBE3F50", VA = "0x180BE5150")]
	public static bool HKCGGCFLHCB(this BMKGIIKACFN LKLFHGBOOLP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public interface HENGGCJCHBF : LKIFCOCAPLM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
[Flags]
public enum ELGMNGGACKF
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
public enum HEGMHDBFOMG
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
public interface EFPBMMGJJNJ : LKIFCOCAPLM, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	EECBOFEPKOA BKKMKEACIAO
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BMIEELPIDAI();

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IMNAAHOBAFD();
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public interface EECBOFEPKOA
{
	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FFOOICFPLEK(Guid PEJGDDHHDBH, out Guid FCAKJLDDKGP);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public interface NNIOLKIOJDO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	INNGAKKGOIO JKMMMACIEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString HGKGAMDPANG();
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public interface LKIFCOCAPLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	IEnumerable<JJCFDHHONOD> CADFEAMNFNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000420")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	LOHOBBBFGHK DKLJGLNEBLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000421")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	LocalId HGGAGKKCHGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000422")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	INNGAKKGOIO FBPCNNJGNCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000423")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	Task NAIJAAMKLJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000424")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool FLEJJGKPECP(ELGMNGGACKF OBALAOIHJBE);
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface MKLFNFALJGG
{
	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGNPKFDBPIO(PPDNOHKLMNC JBIOGBNKLBD, GPEHGPANNHP BOKNODKDNKE, ReadOnlySpan<byte> LHAPGLOAOIN, ReadOnlySpan<byte> HDMOJKBCEBH);

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NNFJLBHDEJN(PPDNOHKLMNC JBIOGBNKLBD, GPEHGPANNHP BOKNODKDNKE);

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGHHEDDAPKA(PPDNOHKLMNC JBIOGBNKLBD, GPEHGPANNHP BOKNODKDNKE, ReadOnlySpan<byte> HDMOJKBCEBH);

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NDNPLDOPFMA(PPDNOHKLMNC JBIOGBNKLBD, GPEHGPANNHP BOKNODKDNKE, Span<byte> LHAPGLOAOIN, Span<byte> HDMOJKBCEBH);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
public static class BOAGLENPHGO
{
	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x4514480", Offset = "0x4513280", VA = "0x184514480")]
	public static bool NDNPLDOPFMA<T>(this MKLFNFALJGG BLMHPFHFHJL, PPDNOHKLMNC JBIOGBNKLBD, GPEHGPANNHP BOKNODKDNKE, out T LHAPGLOAOIN, out T HDMOJKBCEBH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x4514350", Offset = "0x4513150", VA = "0x184514350")]
	public static bool IGHHEDDAPKA<T>(this MKLFNFALJGG BLMHPFHFHJL, PPDNOHKLMNC JBIOGBNKLBD, GPEHGPANNHP BOKNODKDNKE, T HDMOJKBCEBH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public enum IGAHGOJFCPK
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
	Event,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface HNEIHKMDBGC : NHAHMOBLMFE<HNEIHKMDBGC>
{
	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GPEHGPANNHP HIGAAKNJNFP(KDKGBCPHDHM PPPOJKMOIGD);

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MAHHBIDHLIK(GPEHGPANNHP PJCEAFJNLLG, IEAMJPDDHNJ PGCOFMAGKKE);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BBJAFPAMNLG(GPEHGPANNHP PJCEAFJNLLG, out IEAMJPDDHNJ PGCOFMAGKKE);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public static class PKJFADDOPMH
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC0CF0", Offset = "0x3FBFAF0", VA = "0x183FC0CF0")]
	public static GPEHGPANNHP HIGAAKNJNFP<T>(this HNEIHKMDBGC FMCLAGCEHFA, NIBEAOLLINL<T> PPPOJKMOIGD)
	{
		return default(GPEHGPANNHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	public static GPEHGPANNHP MAHHBIDHLIK<T>(this HNEIHKMDBGC FMCLAGCEHFA, NIBEAOLLINL<T> PPPOJKMOIGD, IEAMJPDDHNJ PGCOFMAGKKE) where T : struct
	{
		return default(GPEHGPANNHP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface DMLBOAJBPMH
{
	[Cpp2IlInjected.Token(Token = "0x17000134")]
	uint HJMAAJEPBOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
public struct CIOHFCEDIEE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public EMIFNLIEJNA KGDHPOJLMNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public ReadOnlyMemory<byte> GNCDGJDGENH;
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface DOOJMHFJHEK
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMGGOCMPOEB(EMIFNLIEJNA KGDHPOJLMNA, ReadOnlySpan<byte> GNCDGJDGENH);
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public delegate bool NNFCNIJBAHO(MKLFNFALJGG DJMEJODCBFO, in BIABKMPNANG KKLNCEHOHED);
[Cpp2IlInjected.Token(Token = "0x2000096")]
public delegate bool HICOJIBPABK<T>(MKLFNFALJGG DJMEJODCBFO, in T KKLNCEHOHED);
[Cpp2IlInjected.Token(Token = "0x2000097")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface ANFPJELCJLL
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MAHHBIDHLIK(GPEHGPANNHP BOKNODKDNKE, Type MOODCCFJDOA, NNFCNIJBAHO ELOLEOCOCJM);

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CAJHIPGMNEA(GPEHGPANNHP BOKNODKDNKE, out NNFCNIJBAHO ELOLEOCOCJM);
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public static class HAFBJDLLIGD
{
	[Cpp2IlInjected.Token(Token = "0x2000099")]
	[CompilerGenerated]
	private sealed class AGHJMOGOKKE<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		public HICOJIBPABK<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(RVA = "0x1C1AAB0", Offset = "0x1C198B0", VA = "0x181C1AAB0")]
		public AGHJMOGOKKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(RVA = "0x3C387E0", Offset = "0x3C375E0", VA = "0x183C387E0")]
		internal bool EGNKPAFEHBD(MKLFNFALJGG pendingList, in BIABKMPNANG value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600043D")]
	[Cpp2IlInjected.Address(RVA = "0x3474150", Offset = "0x3472F50", VA = "0x183474150")]
	public static void MAHHBIDHLIK<T>(this ANFPJELCJLL DNLLCPMDAID, GPEHGPANNHP BOKNODKDNKE, HICOJIBPABK<T> ELOLEOCOCJM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(RVA = "0x5EA5030", Offset = "0x5EA3E30", VA = "0x185EA5030")]
	public static bool KLDKDONMGNO(this ANFPJELCJLL DNLLCPMDAID, MKLFNFALJGG DJMEJODCBFO, GPEHGPANNHP BOKNODKDNKE, in BIABKMPNANG KKLNCEHOHED)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public struct EMIFNLIEJNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public uint NALNBAEKHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public int NDIPKNMAJDF;

	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x866E30", Offset = "0x865C30", VA = "0x180866E30")]
	public EMIFNLIEJNA(uint NALNBAEKHHJ, int NDIPKNMAJDF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0300", Offset = "0x5E9F100", VA = "0x185EA0300")]
	public static bool DDONPFMGGHF(in EMIFNLIEJNA AEFFKJDEELO, in EMIFNLIEJNA CPGPPMFIMKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x5EA0320", Offset = "0x5E9F120", VA = "0x185EA0320", Slot = "0")]
	public override bool Equals(object GNOEFMFMEOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(RVA = "0x5EA03B0", Offset = "0x5E9F1B0", VA = "0x185EA03B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(RVA = "0x5EA03E0", Offset = "0x5E9F1E0", VA = "0x185EA03E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface NEHHKGAFDBF
{
	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMIFNLIEJNA HMBKDDNDGDC(ReadOnlySpan<byte> GNCDGJDGENH);
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface IEAMJPDDHNJ
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	Type EGDMNOANDAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMIKNNFPDOG(ref MKGGFOJJCNM NILJFJKCFNJ, Span<byte> LMBGOHINBAF);

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LKKGLINHIKF(ref NCJBBMAAODO BAJNDLOCJJI, ReadOnlySpan<byte> KGDHPOJLMNA);
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public static class LMMEGGHICDI
{
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public delegate void JIENAHMMFNK(EMIFNLIEJNA LGKPJAJAOLI, ReadOnlySpan<byte> GNCDGJDGENH);
[Cpp2IlInjected.Token(Token = "0x200009F")]
[PPDINNBPCDB(NFMGCFGBFLP.OMRoom)]
public interface KNEEAEGCEBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ILFMHBACDHA(EMIFNLIEJNA LGKPJAJAOLI, ReadOnlySpan<byte> GNCDGJDGENH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public class HGBHIGOCPLJ
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
	public HGBHIGOCPLJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000A1")]
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
