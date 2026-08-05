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
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface HEJFCJDGGFG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGANDJJHEIC(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, Allocator HMGEFCKKBID, out NativeArray<Entity> KFLBCCAJFMN);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct IKAONOBBNND
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray FANFGKCMBKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<MHGAJIKGEGE, int> KCOEPFNBNHE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5699870", Offset = "0x5698070", VA = "0x185699870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x13203F0", Offset = "0x131EBF0", VA = "0x1813203F0")]
	public IKAONOBBNND(NativeBitArray FANFGKCMBKI, NativeParallelHashMap<MHGAJIKGEGE, int> KCOEPFNBNHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5699890", Offset = "0x5698090", VA = "0x185699890")]
	public bool PDPJBEINDAM(MHGAJIKGEGE ECBAIECDCID, LLNAAGHGEOA OPCEAOKDBMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface JBFFPLGIMGI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid MIJFGGLIKIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DOLMMOBGDDI(Guid EMFDDGNEAHN, Guid CODKFOCBHLO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task FDJKGBOFMCF(LPLJHAHPEEF DMGBFGPMNAH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JMMLOMAFBDN(LPLJHAHPEEF CICDHHEGIAO, LPLJHAHPEEF GJPBCFJDGCH, out Vector3 FLLINCEBFIA, out Quaternion DMNMOPAJMNP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EFLJHHONIFL(BCHCOEAJMAO GNBGAJAFIJG, Vector3 FLLINCEBFIA, Quaternion DMNMOPAJMNP);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface KGGCPADPPEB : KCHKLIOOFLC<LPLJHAHPEEF>, MNKCCJJMJKH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JPAJHNEFJFD<T> : ALJIFOIANLF<LPLJHAHPEEF, T>, KCHKLIOOFLC<LPLJHAHPEEF>, MNKCCJJMJKH, IDisposable, KGGCPADPPEB where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BHLEHKDHDLB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1E65DD0", Offset = "0x1E645D0", VA = "0x181E65DD0")]
	public static T LPKBLHIFLLL<T>(this KCHKLIOOFLC<LPLJHAHPEEF> OPCEAOKDBMJ, LPLJHAHPEEF BBNGIDIFEAM) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E65E00", Offset = "0x1E64600", VA = "0x181E65E00")]
	public static bool OLFLGMGEIBD<T>(this KCHKLIOOFLC<LPLJHAHPEEF> OPCEAOKDBMJ, LPLJHAHPEEF BBNGIDIFEAM, in T PCKLDBCFAAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface BHNAPIGDOEG
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<EOOBMMBDNHM> OHAMELLGPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<LPLJHAHPEEF, LPLJHAHPEEF> GMNGANBOANE;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<LPLJHAHPEEF, LPLJHAHPEEF> EFCCNEFLDFL;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<LPLJHAHPEEF, LPLJHAHPEEF, LPLJHAHPEEF> EKOCPHCNMKI;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<LPLJHAHPEEF> NGEDFCJNKIL;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color OEMHAKKNHFI(LPLJHAHPEEF BBNGIDIFEAM, int AHANFINHMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 IBBONFMMKAF(LPLJHAHPEEF BBNGIDIFEAM, int AHANFINHMMJ);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool KCKHGMFBPJG(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF AFHPIAFJGIH);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "13")]
	LPLJHAHPEEF DDLLEEBFHAB(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<LPLJHAHPEEF> FEGNNPHKFEI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LPLJHAHPEEF INMNOCAJKEE(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void GMLPEAEFLPM(LPLJHAHPEEF BBNGIDIFEAM, Vector3 LBJMPAACJOH, Quaternion GPOLFPEKAAL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void LMNPMFGIHOE(LPLJHAHPEEF BBNGIDIFEAM, float HHDKGMDEOLP);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool CFMFJGCLCHD(LPLJHAHPEEF BBNGIDIFEAM, out RigidTransform CAJNEOLGFIO);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool MBKEKOILBNL(LPLJHAHPEEF BBNGIDIFEAM, out float EIPEGPIGDND);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 NPLENDLFLDN(FEINEMHDLHP MIKBIDEDGCC);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion ICKKCCDIPED(FEINEMHDLHP MIKBIDEDGCC);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OEFLCFPKIHK
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface NFCEEAILPLD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EGANDJJHEIC(in NativeArray<Entity> KFLBCCAJFMN, in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, in NativeArray<BCHHHLKLMCP> PPAKGEKLAHI);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface HMLONANDNGP
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EEGACNDDJLF(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PIKMHCOAEFM(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LMIAFLCIBPJ(LPLJHAHPEEF PMFGMJJBADH, int MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface NHLFCCPGHPO : IEnumerable<BLECIIOHDPI>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray JICDPEBNNJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> LKJCOIIECHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	BLECIIOHDPI ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	BLECIIOHDPI ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	BLECIIOHDPI HPADBCECEJC(FKFIIEPBNGA ELAAPFMOMBJ);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LLNAAGHGEOA LNDPHGGBMPP(FKFIIEPBNGA ELAAPFMOMBJ);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class FLDLNICOJBP
{
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct OEIMPAGFFBI : IEquatable<OEIMPAGFFBI>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly OEIMPAGFFBI BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x569CEF0", Offset = "0x569B6F0", VA = "0x18569CEF0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(OEIMPAGFFBI OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct FHIBIPMNDEN : IEquatable<FHIBIPMNDEN>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly FHIBIPMNDEN BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5694610", Offset = "0x5692E10", VA = "0x185694610", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(FHIBIPMNDEN OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface MKFKBEBMKHL
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	IKAONOBBNND NFEEKPKECEK
	{
		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PDPJBEINDAM(MHGAJIKGEGE ECBAIECDCID, LLNAAGHGEOA OPCEAOKDBMJ);

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FLJJGDAKGID(MHGAJIKGEGE ECBAIECDCID, Span<LLNAAGHGEOA> LAEPKFGACAO, bool INNOONKMDEA);

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDBPDDHEDHP(NativeArray<MHGAJIKGEGE> LJNBIMMNBCJ);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class ABBPFPOHCEM
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x568C920", Offset = "0x568B120", VA = "0x18568C920")]
	public static void FLJJGDAKGID(this MKFKBEBMKHL NBFLEJAKAJK, MHGAJIKGEGE ECBAIECDCID, LLNAAGHGEOA OPCEAOKDBMJ, bool INNOONKMDEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct IFDBCDKGAKP : INNKBFIJCKK, IEquatable<IFDBCDKGAKP>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly IFDBCDKGAKP BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject OAOEKKJFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x56990D0", Offset = "0x56978D0", VA = "0x1856990D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MHGAJIKGEGE PFLCDOJAPAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x56991D0", Offset = "0x56979D0", VA = "0x1856991D0")]
		get
		{
			return default(MHGAJIKGEGE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public APFIBDNJBME FENJHEOGLEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5699410", Offset = "0x5697C10", VA = "0x185699410")]
		get
		{
			return default(APFIBDNJBME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public KECBEHOHBCN LIEOLJGAKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5698D40", Offset = "0x5697540", VA = "0x185698D40")]
		get
		{
			return default(KECBEHOHBCN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool EILHOFHLOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5699600", Offset = "0x5697E00", VA = "0x185699600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool KPAGFLFGBIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5698EB0", Offset = "0x56976B0", VA = "0x185698EB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LKBHNKFGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5698E90", Offset = "0x5697690", VA = "0x185698E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool BPKMFJHMFKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5699700", Offset = "0x5697F00", VA = "0x185699700")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool DJELIHKCHNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5698E70", Offset = "0x5697670", VA = "0x185698E70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool DNHJPIOFBHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x56990B0", Offset = "0x56978B0", VA = "0x1856990B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool LLPOHHPCFOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5698BB0", Offset = "0x56973B0", VA = "0x185698BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool EOKJBDGAMLO
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5699570", Offset = "0x5697D70", VA = "0x185699570")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public EHBMGPLCIKI LEJAENOLDPH
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(EHBMGPLCIKI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JPJANPCFDHF ICCPKGIPPLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(JPJANPCFDHF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MEPLGIHMMLJ HKPJDPLPPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(MEPLGIHMMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public HDODHOAMGFN LHBJCGNDMDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(HDODHOAMGFN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public BJBHKCCDDOI FCPJBKLDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(BJBHKCCDDOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public HNHAAMLAAOG NCCMMNBBADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(HNHAAMLAAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public BCHCOEAJMAO BFADEJDNJDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(BCHCOEAJMAO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IGAMJDGIHFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5699340", Offset = "0x5697B40", VA = "0x185699340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool LJIBNJANKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5698FD0", Offset = "0x56977D0", VA = "0x185698FD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool HCBPLJDCKPF
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7EE860", Offset = "0x7ED060", VA = "0x1807EE860", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0", Slot = "5")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ABGHFGJOMJP HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(ABGHFGJOMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public GKOOCGGAJPI EAFOKJKFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(GKOOCGGAJPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
	public static IFDBCDKGAKP HFMFJLJFEMO(LPLJHAHPEEF PMFGMJJBADH)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5699020", Offset = "0x5697820", VA = "0x185699020")]
	public HBILLJPEKGG GJGJCGFFBAB()
	{
		return default(HBILLJPEKGG);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5698E00", Offset = "0x5697600", VA = "0x185698E00")]
	public AKKEBNNJKAF DICGOPMNPGI()
	{
		return default(AKKEBNNJKAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5699590", Offset = "0x5697D90", VA = "0x185699590")]
	public JMMLILPLDFA NBIKPMNACKO()
	{
		return default(JMMLILPLDFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5698C00", Offset = "0x5697400", VA = "0x185698C00")]
	public FEINEMHDLHP CJKKMLAACLF()
	{
		return default(FEINEMHDLHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5699620", Offset = "0x5697E20", VA = "0x185699620")]
	public void OMDNJAEMAPA([Optional] object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5699290", Offset = "0x5697A90", VA = "0x185699290")]
	public bool KPMJLLFPDAO(object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5698C90", Offset = "0x5697490", VA = "0x185698C90")]
	public bool DCBHKHFJOGA(object AMCDGOPKAOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5699720", Offset = "0x5697F20", VA = "0x185699720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public IFDBCDKGAKP(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(IFDBCDKGAKP MENBIMCLIOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
	public static LPLJHAHPEEF HFMFJLJFEMO(IFDBCDKGAKP MENBIMCLIOI)
	{
		return default(LPLJHAHPEEF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x56994D0", Offset = "0x5697CD0", VA = "0x1856994D0")]
	public static bool MJNLEMCBPOF(IFDBCDKGAKP MBLAPCMEEGI, IFDBCDKGAKP NBEGIGNBOIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5698AD0", Offset = "0x56972D0", VA = "0x185698AD0")]
	public static bool ACJEIIDJLOL(IFDBCDKGAKP MBLAPCMEEGI, IFDBCDKGAKP NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5698ED0", Offset = "0x56976D0", VA = "0x185698ED0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "6")]
	public bool Equals(IFDBCDKGAKP OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void JEPLFFFAMKN(HDEKHHMMCPI NGEHKOAMEBG);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct IAICMGOMFMM : IList<LPLJHAHPEEF>, ICollection<LPLJHAHPEEF>, IEnumerable<LPLJHAHPEEF>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct INLGKKCIODH : IEnumerator<LPLJHAHPEEF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly HMBELPNBOEG LNJHNPCFKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator EAIMLCNINDI;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public LPLJHAHPEEF PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0x5699B30", Offset = "0x5698330", VA = "0x185699B30", Slot = "4")]
			get
			{
				return default(LPLJHAHPEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0x5699A50", Offset = "0x5698250", VA = "0x185699A50", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x1AAFD60", Offset = "0x1AAE560", VA = "0x181AAFD60")]
		public INLGKKCIODH(HMBELPNBOEG LNJHNPCFKIL, NativeArray<LocalId>.Enumerator EAIMLCNINDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x5699990", Offset = "0x5698190", VA = "0x185699990", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x56999D0", Offset = "0x56981D0", VA = "0x1856999D0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x5699A10", Offset = "0x5698210", VA = "0x185699A10", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> ADGNPKODABN;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LPLJHAHPEEF ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x5698760", Offset = "0x5696F60", VA = "0x185698760", Slot = "4")]
		get
		{
			return default(LPLJHAHPEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x56987E0", Offset = "0x5696FE0", VA = "0x1856987E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x56982F0", Offset = "0x5696AF0", VA = "0x1856982F0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x56982F0", Offset = "0x5696AF0", VA = "0x1856982F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool OAJKOPLILBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x7EE870", Offset = "0x7ED070", VA = "0x1807EE870", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x56986D0", Offset = "0x5696ED0", VA = "0x1856986D0")]
	public IAICMGOMFMM(HMBELPNBOEG LNJHNPCFKIL, int AKLMFDJHPFM, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5697F30", Offset = "0x5696730", VA = "0x185697F30")]
	public MDHHOEPMEJH BKKOHPCEGEB()
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5697FB0", Offset = "0x56967B0", VA = "0x185697FB0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5697FF0", Offset = "0x56967F0", VA = "0x185697FF0", Slot = "13")]
	public bool Contains(LPLJHAHPEEF AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5698050", Offset = "0x5696850", VA = "0x185698050", Slot = "14")]
	public void CopyTo(LPLJHAHPEEF[] DLLMPOAIBGN, int NIPJDFBICLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5697ED0", Offset = "0x56966D0", VA = "0x185697ED0", Slot = "11")]
	public void Add(LPLJHAHPEEF AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5698390", Offset = "0x5696B90", VA = "0x185698390", Slot = "7")]
	public void Insert(int AMOEKOMGDLG, LPLJHAHPEEF AMBKJGJJFNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5698460", Offset = "0x5696C60", VA = "0x185698460", Slot = "15")]
	public bool Remove(LPLJHAHPEEF AMBKJGJJFNP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5698330", Offset = "0x5696B30", VA = "0x185698330", Slot = "6")]
	public int IndexOf(LPLJHAHPEEF AMBKJGJJFNP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5698410", Offset = "0x5696C10", VA = "0x185698410", Slot = "8")]
	public void RemoveAt(int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5698220", Offset = "0x5696A20", VA = "0x185698220", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5698260", Offset = "0x5696A60", VA = "0x185698260")]
	public INLGKKCIODH GAACJCPNEFN()
	{
		return default(INLGKKCIODH);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x56984F0", Offset = "0x5696CF0", VA = "0x1856984F0", Slot = "16")]
	private IEnumerator<LPLJHAHPEEF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56985E0", Offset = "0x5696DE0", VA = "0x1856985E0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface FKAJABEJDAD
{
	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EGANDJJHEIC(in float3 HPBBFNNBAFE, in float3 JJEDPBPHNPK, float BJICICOAOBE, out BCHHHLKLMCP AFJOMCLLIJA, out LPLJHAHPEEF BENEHBIADLM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct KNBBFGODFFJ : IEquatable<KNBBFGODFFJ>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly KNBBFGODFFJ BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private NNHDHBPFLOE GHMDJOGEELA
	{
		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x569A990", Offset = "0x5699190", VA = "0x18569A990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public AKKEBNNJKAF GFDENFDDALM
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(AKKEBNNJKAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public CLPCIHAOJOM HEAFDJEOGIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x569AEA0", Offset = "0x56996A0", VA = "0x18569AEA0")]
		get
		{
			return default(CLPCIHAOJOM);
		}
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x569ADB0", Offset = "0x56995B0", VA = "0x18569ADB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<FONHLENHBMG> BNMMPGNFKBG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x569A7B0", Offset = "0x5698FB0", VA = "0x18569A7B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public FONHLENHBMG ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x569A470", Offset = "0x5698C70", VA = "0x18569A470")]
		get
		{
			return default(FONHLENHBMG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x569ACD0", Offset = "0x56994D0", VA = "0x18569ACD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ABGHFGJOMJP HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(ABGHFGJOMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x569AF90", Offset = "0x5699790", VA = "0x18569AF90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x569A590", Offset = "0x5698D90", VA = "0x18569A590")]
	public FONHLENHBMG BFBELPBJEIA(float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] Vector3? FJJHHNAFAEK)
	{
		return default(FONHLENHBMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x569B080", Offset = "0x5699880", VA = "0x18569B080")]
	public FONHLENHBMG PAHBEPKNIKA(int AMOEKOMGDLG, float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] Vector3? FJJHHNAFAEK)
	{
		return default(FONHLENHBMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x569AA10", Offset = "0x5699210", VA = "0x18569AA10")]
	public void EDJJLOJGDBA(int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x569AAF0", Offset = "0x56992F0", VA = "0x18569AAF0")]
	public void EEMEPIGIECC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public KNBBFGODFFJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(KNBBFGODFFJ MENBIMCLIOI)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x569AFE0", Offset = "0x56997E0", VA = "0x18569AFE0")]
	public static bool MJNLEMCBPOF(KNBBFGODFFJ MBLAPCMEEGI, KNBBFGODFFJ NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x569ABD0", Offset = "0x56993D0", VA = "0x18569ABD0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(KNBBFGODFFJ OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface NIKEKFGBDPH
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Type KBADELDBGBH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface OJMMJKOMFGB
{
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EPPDCAAMLKG(LPLJHAHPEEF BBNGIDIFEAM, out Collider PINIOELHAHC);

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject AIMGMPANBJF(LPLJHAHPEEF JIPCMNGIJDB, GameObject ALNJPMNLFGF, Vector3 GGKJMICDBEF, Quaternion CCIFDEOEEEF);

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EGHICKFKCCP(GameObject PINIOELHAHC);

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider BCLLCNDBFHG<TCollider>(GameObject BBPEBGOHEKI) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AOHLPONKKAO(Collider PINIOELHAHC);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject FJLNOOKHOPM<TCollider>(string MDOAADHDBMA) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface ILFNLPAIJLJ : KCHKLIOOFLC<MHGAJIKGEGE>, MNKCCJJMJKH, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface GHMKFKAMLJJ<T> : ALJIFOIANLF<MHGAJIKGEGE, T>, KCHKLIOOFLC<MHGAJIKGEGE>, MNKCCJJMJKH, IDisposable, ILFNLPAIJLJ where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class LCGOKGGKJHF
{
	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x111C110", Offset = "0x111A910", VA = "0x18111C110")]
	public static bool NOPGAJGAFLG<T>(this KCHKLIOOFLC<MHGAJIKGEGE> OPCEAOKDBMJ, MHGAJIKGEGE ECBAIECDCID, out T MENBIMCLIOI) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x1DA2920", Offset = "0x1DA1120", VA = "0x181DA2920")]
	public static bool OLFLGMGEIBD<T>(this KCHKLIOOFLC<MHGAJIKGEGE> OPCEAOKDBMJ, MHGAJIKGEGE ECBAIECDCID, in T PCKLDBCFAAB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct BCHCOEAJMAO : IEquatable<BCHCOEAJMAO>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly BCHCOEAJMAO BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private GHENGDIBFHP EKMCBOFFMCD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x5691250", Offset = "0x568FA50", VA = "0x185691250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool NHBENKJGECB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5691400", Offset = "0x568FC00", VA = "0x185691400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid NACHHCKGAFA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x5690DA0", Offset = "0x568F5A0", VA = "0x185690DA0")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EOAAKMENOIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5690F80", Offset = "0x568F780", VA = "0x185690F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Guid CHECEAIAHJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5691160", Offset = "0x568F960", VA = "0x185691160")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x56913B0", Offset = "0x568FBB0", VA = "0x1856913B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x56912D0", Offset = "0x568FAD0", VA = "0x1856912D0")]
	public bool LAIOKBGNPEL(out Guid IBOAMBHJEOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x5690E90", Offset = "0x568F690", VA = "0x185690E90")]
	public void DNCHPFCOGDB(Guid BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x56916B0", Offset = "0x568FEB0", VA = "0x1856916B0")]
	public bool PJEEDHFNHJN(out Guid KJOHEJEFBGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x56915C0", Offset = "0x568FDC0", VA = "0x1856915C0")]
	public void PCEFKKCGOIO(Guid BNMGNDJJNJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x56914E0", Offset = "0x568FCE0", VA = "0x1856914E0")]
	public void LPDMPILCFCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public BCHCOEAJMAO(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(BCHCOEAJMAO MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x5691060", Offset = "0x568F860", VA = "0x185691060", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(BCHCOEAJMAO OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct JPJANPCFDHF : IEquatable<JPJANPCFDHF>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly JPJANPCFDHF BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5699F80", Offset = "0x5698780", VA = "0x185699F80")]
	public void CLOOKKNDFON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x569A150", Offset = "0x5698950", VA = "0x18569A150")]
	public void IKDLJOMDIEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public JPJANPCFDHF(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x569A050", Offset = "0x5698850", VA = "0x18569A050", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(JPJANPCFDHF OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FKKNGLCNOFO : INNKBFIJCKK
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	FOFNGPEFGJJ MLCPFJLJEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool JONDFIGHAHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GameObject OAOEKKJFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<FKKNGLCNOFO> IHOIIAANPFI;

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(ILBBGIPPPPJ EJLFIBCCMHH, LPLJHAHPEEF HDIMJNMJOGM);

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool KMABEKKILJN);

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class EEOGCHNFBEE
{
	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5693A90", Offset = "0x5692290", VA = "0x185693A90")]
	public static bool IGAMJDGIHFK(this FKKNGLCNOFO CKMMOGKGLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x5693B30", Offset = "0x5692330", VA = "0x185693B30")]
	public static bool MHOIDNIGEON(this FKKNGLCNOFO CKMMOGKGLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x5693AE0", Offset = "0x56922E0", VA = "0x185693AE0")]
	public static bool LKPPAMKOALN(this FKKNGLCNOFO CKMMOGKGLFH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x56939F0", Offset = "0x56921F0", VA = "0x1856939F0")]
	public static bool GKHBBLGCCAM(this FKKNGLCNOFO CKMMOGKGLFH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct ICPAKKEJCIB : IEquatable<ICPAKKEJCIB>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly ICPAKKEJCIB BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5698840", Offset = "0x5697040", VA = "0x185698840", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(ICPAKKEJCIB OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface PHBCFKHMBHC
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GHCHPDNLLNJ(NativeListAsync<Entity> AHBAJGGJOGH);

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBPDFGBFKHC(ODEOGNCDGLA FHFICEBIOIM);

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJIIBGJOPKF(NativeListAsync<Entity> HLBNHMIFCPI, bool JCHLPADGMOF);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KPICKKJPMJP();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface OIDNCMDGBGG
{
	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HOELOGNCCOC(LPLJHAHPEEF BBNGIDIFEAM, KOAODCFHIDH MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface LBOJFNDAHOB
{
	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GONCOPMMAPC();

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HCEHPONDPGL();

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GNIOEOAMOPE();

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMDIKPAKGKC();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NILEGKHIDGJ();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OIIDANPGMAG();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JNFJGBLBKGL();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void CDLJBNFGNHF();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void CHOPHDFCICE();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BCPNPCJJOCF();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JGAAFLNNEIA();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface HIJMGKLGPJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int IBDOOLKCJIF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> IBAAAHEDHNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPLJHAHPEEF LIOKLEGJMOA(LPLJHAHPEEF ADGNPKODABN);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface KJABHOFELOP : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct HDODHOAMGFN : IEquatable<HDODHOAMGFN>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly HDODHOAMGFN BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private BINILIONIJC GILEPHIBPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5696E80", Offset = "0x5695680", VA = "0x185696E80")]
		get
		{
			return default(BINILIONIJC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool EAGECPAADNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5697100", Offset = "0x5695900", VA = "0x185697100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool AKOMCEKHFJD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5697170", Offset = "0x5695970", VA = "0x185697170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool JINCKDAANML
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5696A30", Offset = "0x5695230", VA = "0x185696A30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GFDLNCMLLEI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5696F50", Offset = "0x5695750", VA = "0x185696F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool AOHDBGCPIKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5697330", Offset = "0x5695B30", VA = "0x185697330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool LANGECACMNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x56973A0", Offset = "0x5695BA0", VA = "0x1856973A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool NIIMKFEHCNL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x56971F0", Offset = "0x56959F0", VA = "0x1856971F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool IIFMAHFOKDB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5697490", Offset = "0x5695C90", VA = "0x185697490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool OPJEEOLKFBF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5696FC0", Offset = "0x56957C0", VA = "0x185696FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool NECGDCGMKOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5696EE0", Offset = "0x56956E0", VA = "0x185696EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool AIBMHMDCFCK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5697260", Offset = "0x5695A60", VA = "0x185697260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool OLLPFDAGJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x56969C0", Offset = "0x56951C0", VA = "0x1856969C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool JHLIHJNFPDK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x5697410", Offset = "0x5695C10", VA = "0x185697410")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool FKJJMDDDBBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5697480", Offset = "0x5695C80", VA = "0x185697480")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool HCHDNBHNEAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5697320", Offset = "0x5695B20", VA = "0x185697320")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x56971E0", Offset = "0x56959E0", VA = "0x1856971E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool NGAFNCEJONP
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5697500", Offset = "0x5695D00", VA = "0x185697500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 ABMOMIGLIGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5697030", Offset = "0x5695830", VA = "0x185697030")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 CPLMCLJINKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5696B20", Offset = "0x5695320", VA = "0x185696B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool MNPAAKMHADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5696BE0", Offset = "0x56953E0", VA = "0x185696BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x56972D0", Offset = "0x5695AD0", VA = "0x1856972D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5696D00", Offset = "0x5695500", VA = "0x185696D00")]
	public bool DLKIFNMEEKA(LEGGLPPFJFK KMIJNFGJKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5697570", Offset = "0x5695D70", VA = "0x185697570")]
	public bool PEPHLKNOGBO(EAAJLBIKIMH KMIJNFGJKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5696AA0", Offset = "0x56952A0", VA = "0x185696AA0")]
	public void DCBOAIMKIEM(EAAJLBIKIMH KMIJNFGJKHN, bool JEABKFCMDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public HDODHOAMGFN(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5696D80", Offset = "0x5695580", VA = "0x185696D80", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(HDODHOAMGFN OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum KCIFFDLJEIC
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class HGBLNCOPDLC
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x14E6A30", Offset = "0x14E5230", VA = "0x1814E6A30")]
	public static bool DBNLAGLJAAB(this KCIFFDLJEIC COOBJCJFHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x14E6A10", Offset = "0x14E5210", VA = "0x1814E6A10")]
	public static bool JBCDMILCFDI(this KCIFFDLJEIC COOBJCJFHEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x41ACA70", Offset = "0x41AB270", VA = "0x1841ACA70")]
	public static bool OABILPCLPCO(this KCIFFDLJEIC COOBJCJFHEP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface ILBBGIPPPPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	World IHPDJPJEIBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	World IGCHJBGNJEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	EntityManager EOOAJAELBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase LNFLHCLCDLG(Type EIOLDDJPDLH);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class DOMIMINHAGH
{
	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5693960", Offset = "0x5692160", VA = "0x185693960")]
	public static ComponentSystemBase PIEHMMOGEML(this World EJLFIBCCMHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x308B6A0", Offset = "0x3089EA0", VA = "0x18308B6A0")]
	public static T LNFLHCLCDLG<T>(this ILBBGIPPPPJ KFELNFLBJDM) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct POJLFICOPEH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly HDEKHHMMCPI NFBDMLCENEN;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public MDHHOEPMEJH IOJCJDFGGBF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x1AB06F0", Offset = "0x1AAEEF0", VA = "0x181AB06F0")]
		get
		{
			return default(MDHHOEPMEJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x569D870", Offset = "0x569C070", VA = "0x18569D870")]
	public POJLFICOPEH(HDEKHHMMCPI NFBDMLCENEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x569D540", Offset = "0x569BD40", VA = "0x18569D540")]
	public MDHHOEPMEJH EIGHKFPGDCO()
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x569D610", Offset = "0x569BE10", VA = "0x18569D610")]
	public MDHHOEPMEJH HAJEECEOBPD()
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x569D6E0", Offset = "0x569BEE0", VA = "0x18569D6E0")]
	public (MDHHOEPMEJH, MDHHOEPMEJH, MDHHOEPMEJH) LPKBLHIFLLL()
	{
		return default((MDHHOEPMEJH, MDHHOEPMEJH, MDHHOEPMEJH));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct GKOOCGGAJPI : IEquatable<GKOOCGGAJPI>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly GKOOCGGAJPI BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private AEDKFOCGAIL HNOHIDEKGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5695500", Offset = "0x5693D00", VA = "0x185695500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public LPLJHAHPEEF CCFKDBKBIEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x56955D0", Offset = "0x5693DD0", VA = "0x1856955D0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public IFDBCDKGAKP PCBLKPOAMHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5695100", Offset = "0x5693900", VA = "0x185695100")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public IFDBCDKGAKP AELGKCJPGAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5695000", Offset = "0x5693800", VA = "0x185695000")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x5695580", Offset = "0x5693D80", VA = "0x185695580")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5695200", Offset = "0x5693A00", VA = "0x185695200")]
	public bool EALODDMPHDN(IFDBCDKGAKP GJPBCFJDGCH, bool ECCMKOMFCJG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5695410", Offset = "0x5693C10", VA = "0x185695410")]
	public bool IBBKINNCCLP(IFDBCDKGAKP IKDGFEDODNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public GKOOCGGAJPI(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5695310", Offset = "0x5693B10", VA = "0x185695310", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(GKOOCGGAJPI OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct CEMBDKOPINH : IEquatable<CEMBDKOPINH>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly CEMBDKOPINH BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private AEDHHMOIEME LBJFAKGCLDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5692D00", Offset = "0x5691500", VA = "0x185692D00")]
		get
		{
			return default(AEDHHMOIEME);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GGEPJACPGID GBINJPHEEKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x5692C90", Offset = "0x5691490", VA = "0x185692C90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public CEMBDKOPINH(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x5692B90", Offset = "0x5691390", VA = "0x185692B90", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(CEMBDKOPINH OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface CECMNEMBLPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	FMCIPOPBHDP OAHEIILMPDM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface DCAINADNFLE
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World DANJPMBMOOA();

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World FBFNIJOECHJ();

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World AFLENEOBKJJ();

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World DJMDEBFPBND();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface DNDLOCLACIG
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BLBNKAHIGPI(GameObject OAOEKKJFJKH);

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFEDCCGLBAK(GameObject OAOEKKJFJKH);

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object LDCNNEBCCBA(LPLJHAHPEEF BBNGIDIFEAM, GameObject OAOEKKJFJKH, Action<LPLJHAHPEEF, int> JJFOLBCEJBD);

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LCDLMNOBDNN(GameObject OAOEKKJFJKH, object GLMCFNDLCNK);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface HJNIAEDPMLO
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFOEKHCJJMM(MDHHOEPMEJH ADGNPKODABN);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 IBBONFMMKAF(GameObject OAOEKKJFJKH, int PLOHGLPHJLM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JFKMNELHNML
{
	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KFPDLFMGKFL(GameObject KPCIINELJDK, bool LLMANHIAOLE);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DOEIEPHJJJF(GameObject OAOEKKJFJKH, bool JEGBPJLCFNL, bool KPEHBICCEJJ);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface HBKCJDBJEAL
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DHBIJJFHMKB(Action COPPLLLOGLG, bool POJCDCHHLFF);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GGFPCINKJPA(string MDOAADHDBMA);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface KJJFNFOPJKA
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	string MKNHLBBDBIE
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] CLDAMFLBIIB(IEnumerable<PMMFFJMLFOG> DBOJPELNHKC);

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MHGAJIKGEGE LAAAJBOOAMB(Guid FFNMKKGMCHH);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEJILMBJMKA(GameObject OAOEKKJFJKH, out MHGAJIKGEGE ECBAIECDCID);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DKACNNBAGNI(GameObject OAOEKKJFJKH, out int IJMNINKJNBO, out KECBEHOHBCN MCBNACIDAGA);

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FKKNGLCNOFO BGOJACEFFLH(PMMFFJMLFOG AJNIDCPPJGC);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FKKNGLCNOFO BGOJACEFFLH(string NECMDMMFDDJ, MHGAJIKGEGE ECBAIECDCID, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, Vector3 FJJHHNAFAEK);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void DAAPCCCMGEH(GameObject OAOEKKJFJKH);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface KFHGNHNKIJE
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PFFIGBHEFKB(bool HLEJICMEJHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface HJDNHEJJGDB
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool FFPHKCCBGHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool EGPOIODDEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int APOKPGPLJLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool POBDMDIHGFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool AFNFHPEECOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CMNDNMNBHAD(object BKHMACKFNNF);

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void APOKGCKLLEF(object BEELAINJGPH);

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ONKAEEPJONP(object BEELAINJGPH);

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int ENIGNNGNJPL(GameObject HBPFJCNENNP);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PKGMCCIFCBD(NativeArray<int> HMALFFOKAHM);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface HNFLLCBEHFB
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BCOIKAAJDKP(GameObject OAOEKKJFJKH);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface IJACPPBENPC
{
	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AIOENIBCNKL(string AKADEFDGONP);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface AFGKCDAOMMN
{
	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OJPJJCEGIMB(GameObject OAOEKKJFJKH);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool PFHMGFNHNEI(out Vector3 PAOMABBDKAH);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KMOEBOKJHAO();

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task OILLINLDEFD();

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task HPJEFGLFLEE();

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DHNJOADDKNH();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface LJKAPIKCKDG
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	IENGMMMKEAP OAKKIPNJFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600016A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	FCPCEKOLEJP PCPIOIKOOCD
	{
		[Cpp2IlInjected.Token(Token = "0x600016B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CILHGNMHKFP(Transform LAMNAOAMKPM);

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NHMEKAHFDCB(Transform LAMNAOAMKPM, KJCKPCKEGIG GKFBFPHHLOH);

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void ABJCBBEBBLO(Transform LAMNAOAMKPM, FMCIPOPBHDP FPMLPGBBOFE);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface MKDMNFECKHI
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ICNIEJACKBA();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JHEIOALEKJO();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface HENMNPANIIL
{
	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PDGHIAJJCJE();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface GKLKNFMJKII
{
	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KECBEHOHBCN JCLNJLFPPEO(GameObject HBPFJCNENNP);

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FKLKOIKAPGH(GameObject OAOEKKJFJKH, EAAJLBIKIMH KMJCMLEBCBN);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface GCEAHPOJKPP
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool FMNPNMOJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface NAHGLKOIEAI : IDisposable, DNDLOCLACIG, HJNIAEDPMLO, JFKMNELHNML, HBKCJDBJEAL, KJJFNFOPJKA, KFHGNHNKIJE, HJDNHEJJGDB, HNFLLCBEHFB, IJACPPBENPC, AFGKCDAOMMN, GCEAHPOJKPP, LJKAPIKCKDG, MKDMNFECKHI, HENMNPANIIL, GKLKNFMJKII
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class LIKPBGHBAJN
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x569B770", Offset = "0x5699F70", VA = "0x18569B770")]
	public static FKKNGLCNOFO BGOJACEFFLH(this KJJFNFOPJKA BOBHLPNKBHC, MHGAJIKGEGE ECBAIECDCID, Vector3 PAOMABBDKAH, Quaternion APAHFEOKBOD, Vector3 FJJHHNAFAEK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface BPCIPLEJFHF
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct ADLDIGGBGPP : IAJADHNJCKN, IEquatable<ADLDIGGBGPP>
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int JNDMMPHMODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int IHOKMDEGNLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x1AB09C0", Offset = "0x1AAF1C0", VA = "0x181AB09C0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x24EBED0", Offset = "0x24EA6D0", VA = "0x1824EBED0", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x56903E0", Offset = "0x568EBE0", VA = "0x1856903E0", Slot = "8")]
	public bool Equals(ADLDIGGBGPP OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x5690430", Offset = "0x568EC30", VA = "0x185690430", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface MEGBGGHIJBE
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JACMNDDEBJP(FKFIIEPBNGA OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ);

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GCELDLHNPGC(FKFIIEPBNGA OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct CBGNFPNAGKM : MIIOPAJPNBD, IEquatable<CBGNFPNAGKM>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public KECBEHOHBCN MCBNACIDAGA;

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5692AD0", Offset = "0x56912D0", VA = "0x185692AD0", Slot = "5")]
	public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5692A10", Offset = "0x5691210", VA = "0x185692A10", Slot = "4")]
	public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5692B00", Offset = "0x5691300", VA = "0x185692B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3B90590", Offset = "0x3B8ED90", VA = "0x183B90590", Slot = "6")]
	public bool Equals(CBGNFPNAGKM OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5692A40", Offset = "0x5691240", VA = "0x185692A40", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface LDDLEDJLLMH
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool FMNPNMOJKKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action AABCIHAEHFP;

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IJDDMDKBAJE();

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HFDEGCECNCA();

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKABLNLPGLL(bool HLEJICMEJHJ);

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DLMAIHLOBIE(ByteString BLAINNBNMDK);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task KMOEBOKJHAO();

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task OILLINLDEFD();

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task HPJEFGLFLEE();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void OAAAMLDFDLA();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface HOPNNAKMIDH
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	FIJBLGANFNJ GCNHOFIBKKC
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	List<KGGCPADPPEB> IPOLKGKKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PCCNPEFMLBP(KGGCPADPPEB OPCEAOKDBMJ, out FIJBLGANFNJ PBBIBKAILDH);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JACMNDDEBJP(KGGCPADPPEB OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GCELDLHNPGC(KGGCPADPPEB OPCEAOKDBMJ, JEPLFFFAMKN LKAHNEAJLHJ);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface AOINIFGFCKO
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	GJJLPLMIGNE DPLEDJPNLKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct FEINEMHDLHP : IEquatable<FEINEMHDLHP>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly FEINEMHDLHP BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private BHNAPIGDOEG FAODBMMJCLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5694460", Offset = "0x5692C60", VA = "0x185694460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public float3 GHDLNNLNOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x56944E0", Offset = "0x5692CE0", VA = "0x1856944E0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public quaternion HPIMGFIDBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x56941F0", Offset = "0x56929F0", VA = "0x1856941F0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public IFDBCDKGAKP AHDONBKEKIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x56942E0", Offset = "0x5692AE0", VA = "0x1856942E0")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5694410", Offset = "0x5692C10", VA = "0x185694410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public FEINEMHDLHP(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
	public static LPLJHAHPEEF HFMFJLJFEMO(FEINEMHDLHP MENBIMCLIOI)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x56940F0", Offset = "0x56928F0", VA = "0x1856940F0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(FEINEMHDLHP OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface NBKDCPLNNHB
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action OAAAMLDFDLA;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action EJDGIIEFOAC;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action CKPGHLPBGOL;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface FIJBLGANFNJ
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string MOCKNNDLFAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	FIJBLGANFNJ NBCMFIEABFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	IEnumerable<FIJBLGANFNJ> NCAFMHPOECD
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public struct MDHHOEPMEJH : IReadOnlyList<LPLJHAHPEEF>, IEnumerable<LPLJHAHPEEF>, IEnumerable, IReadOnlyCollection<LPLJHAHPEEF>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct KADAPKHFBAD : IEnumerator<LPLJHAHPEEF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly HMBELPNBOEG LNJHNPCFKIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeArray<LocalId>.Enumerator EAIMLCNINDI;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public LPLJHAHPEEF PDEEINOIIEF
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x569A400", Offset = "0x5698C00", VA = "0x18569A400", Slot = "4")]
			get
			{
				return default(LPLJHAHPEEF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x569A320", Offset = "0x5698B20", VA = "0x18569A320", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x1AAFD60", Offset = "0x1AAE560", VA = "0x181AAFD60")]
		public KADAPKHFBAD(HMBELPNBOEG LNJHNPCFKIL, NativeArray<LocalId>.Enumerator EAIMLCNINDI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x569A260", Offset = "0x5698A60", VA = "0x18569A260", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x569A2A0", Offset = "0x5698AA0", VA = "0x18569A2A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x569A2E0", Offset = "0x5698AE0", VA = "0x18569A2E0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly HMBELPNBOEG LNJHNPCFKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<LocalId> ADGNPKODABN;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public LPLJHAHPEEF ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x569C6E0", Offset = "0x569AEE0", VA = "0x18569C6E0", Slot = "4")]
		get
		{
			return default(LPLJHAHPEEF);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x569C2A0", Offset = "0x569AAA0", VA = "0x18569C2A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private int NOPOJPDKGPC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int EGAMNLBINDF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x7DF240", Offset = "0x7DDA40", VA = "0x1807DF240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool KHGFECIPALO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x569C260", Offset = "0x569AA60", VA = "0x18569C260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public NativeArray<LocalId> FCLFBIFIMEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x1AB0880", Offset = "0x1AAF080", VA = "0x181AB0880")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal NativeArray<Entity> LEHLEJFFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x569C200", Offset = "0x569AA00", VA = "0x18569C200")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x569C5B0", Offset = "0x569ADB0", VA = "0x18569C5B0")]
	public MDHHOEPMEJH(int LNKEFEELODK, HMBELPNBOEG LNJHNPCFKIL, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x1AAF6E0", Offset = "0x1AADEE0", VA = "0x181AAF6E0")]
	public MDHHOEPMEJH(HMBELPNBOEG LNJHNPCFKIL, NativeArray<LocalId> ADGNPKODABN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x569C540", Offset = "0x569AD40", VA = "0x18569C540")]
	internal MDHHOEPMEJH(HMBELPNBOEG LNJHNPCFKIL, NativeArray<Entity> KFLBCCAJFMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x569C640", Offset = "0x569AE40", VA = "0x18569C640")]
	public MDHHOEPMEJH(HMBELPNBOEG LNJHNPCFKIL, int AKLMFDJHPFM, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x569C490", Offset = "0x569AC90", VA = "0x18569C490")]
	public MDHHOEPMEJH(MDHHOEPMEJH IBBEBPKCHKF, Allocator HMGEFCKKBID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x569C090", Offset = "0x569A890", VA = "0x18569C090")]
	public MDHHOEPMEJH BBGJPJPLCPO(Allocator HMGEFCKKBID = Allocator.Temp)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x569C130", Offset = "0x569A930", VA = "0x18569C130", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x569C170", Offset = "0x569A970", VA = "0x18569C170")]
	public KADAPKHFBAD GAACJCPNEFN()
	{
		return default(KADAPKHFBAD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x569C2B0", Offset = "0x569AAB0", VA = "0x18569C2B0", Slot = "6")]
	private IEnumerator<LPLJHAHPEEF> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x569C3A0", Offset = "0x569ABA0", VA = "0x18569C3A0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MHGAJIKGEGE : IComparable<MHGAJIKGEGE>, IEquatable<MHGAJIKGEGE>, MIIOPAJPNBD
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const uint BKCHMPCOCLI = 0u;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const uint BKCOHHIKNIH = 255u;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MHGAJIKGEGE HCMFGAEBPME;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int CAMFJJGCJAN = 24;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const uint LKFEOCALOHC = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int OLKGBKIAIID = 8;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const uint FPIPGNMKJNH = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly uint IFGPPACGKDK;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public uint DALCFKNDNAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xB7D570", Offset = "0xB7BD70", VA = "0x180B7D570")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public uint PGHJLABHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x569C990", Offset = "0x569B190", VA = "0x18569C990")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public uint DBNNMIKMELN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xB1A680", Offset = "0xB18E80", VA = "0x180B1A680")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool JHEOEEGHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x524B250", Offset = "0x5249A50", VA = "0x18524B250")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1560180", Offset = "0x155E980", VA = "0x181560180")]
	public static MHGAJIKGEGE OEPMBOEBKPN(uint IFGPPACGKDK)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x569CC70", Offset = "0x569B470", VA = "0x18569CC70")]
	public MHGAJIKGEGE(int HJIMKOGCLIO, int FMDOPBPMPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x569CC70", Offset = "0x569B470", VA = "0x18569CC70")]
	public MHGAJIKGEGE(uint HJIMKOGCLIO, int FMDOPBPMPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x569CC70", Offset = "0x569B470", VA = "0x18569CC70")]
	public MHGAJIKGEGE(uint HJIMKOGCLIO, uint FMDOPBPMPFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0")]
	private MHGAJIKGEGE(uint IFGPPACGKDK)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x524B2E0", Offset = "0x5249AE0", VA = "0x18524B2E0")]
	public static bool MJNLEMCBPOF(MHGAJIKGEGE MBLAPCMEEGI, MHGAJIKGEGE NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x569CA10", Offset = "0x569B210", VA = "0x18569CA10", Slot = "5")]
	public bool Equals(MHGAJIKGEGE BMKPPKKOMAH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x569CA70", Offset = "0x569B270", VA = "0x18569CA70", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x2C53E80", Offset = "0x2C52680", VA = "0x182C53E80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x569CBA0", Offset = "0x569B3A0", VA = "0x18569CBA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x569C9A0", Offset = "0x569B1A0", VA = "0x18569C9A0", Slot = "6")]
	public void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x569CB40", Offset = "0x569B340", VA = "0x18569CB40", Slot = "7")]
	public void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x569CA00", Offset = "0x569B200", VA = "0x18569CA00", Slot = "4")]
	public int CompareTo(MHGAJIKGEGE OALEAAIPGBP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface IKCMADHPPKE
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLPIKCHKOGG(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KFDLIJACOBF(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 AFHOMGAJMLH(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KBGOAGBBAAK(Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion CCLAJFGECPI(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void ADONEMEIFIN(Entity AJDEFAPHMKF, out float3 PAOMABBDKAH, out quaternion APAHFEOKBOD);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ADONEMEIFIN(Entity AJDEFAPHMKF, out RigidTransform FGPBBIHDJMM);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HNGCHLOFNEH(Entity AJDEFAPHMKF, out RigidTransform FGPBBIHDJMM);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 CLAGLONHNJJ(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void BBAPEDLDGHL(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void FPFILMBFBCA(Entity AJDEFAPHMKF, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float IBKKBCCLKMB(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KPFKAIIOHPG(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 GANHJMFFNFJ(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void OFPFKNFIPHK(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BGNBGEJHCHN(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void PHPLCBBHGNF(Entity AJDEFAPHMKF, in quaternion MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion GBMIBJMJHCF(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 GIJOOKNKPIK(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void HGBCENPALNG(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KFNMBFMCJEL(Entity AJDEFAPHMKF, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float LEMICPDPBOH(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void HOIKNANDLMA(Entity AJDEFAPHMKF, in float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 CBFHIEGPLEE(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LLOMMEHAPFI(Entity AJDEFAPHMKF, out float4x4 ILDEBNONBOL);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void PBCGBABMIAD(Entity AJDEFAPHMKF, in float4x4 ILDEBNONBOL);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void BKBHJGJHGAI(Entity AJDEFAPHMKF, out float4x4 ILDEBNONBOL);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LOMNBKALOHK(Entity AJDEFAPHMKF, out Transform LAMNAOAMKPM);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void IHDEDMGCIDL(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void ABFEBEGFHKC(Entity AJDEFAPHMKF, Entity FNFODDOPDHK, Entity ILLDOGNGNOD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class PJJEPJAOLFM
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct LIIAPEIGDIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IEnumerable<PMMFFJMLFOG> DBOJPELNHKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IReadOnlyList<GameObject> PNIIEKIBDLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IReadOnlyList<int> EJKLGJBIOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IReadOnlyList<(MHGAJIKGEGE, MHGAJIKGEGE)> KMJEDIMAHDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int MCKAGHCOFLA;

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool JHEOEEGHFGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x569B2F0", Offset = "0x5699AF0", VA = "0x18569B2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public int IDNMJCGNLPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD10", Offset = "0x7DE510", VA = "0x1807DFD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public IEnumerable<GameObject> LMICLICBDLA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5B0", Offset = "0xB18DB0", VA = "0x180B1A5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<(MHGAJIKGEGE src, MHGAJIKGEGE dst)> NNHJEEAPDEG
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x569B700", Offset = "0x5699F00", VA = "0x18569B700")]
	public LIIAPEIGDIL(IEnumerable<PMMFFJMLFOG> DBOJPELNHKC, IReadOnlyList<GameObject> PNIIEKIBDLE, IReadOnlyList<int> EJKLGJBIOMA, IReadOnlyList<(MHGAJIKGEGE src, MHGAJIKGEGE dst)> KMJEDIMAHDJ, int MCKAGHCOFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x569B350", Offset = "0x5699B50", VA = "0x18569B350")]
	public (GameObject, int)[] KEMOHDEHNMP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct HBILLJPEKGG : IEquatable<HBILLJPEKGG>
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly HBILLJPEKGG BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	private AEDKFOCGAIL HNOHIDEKGEE
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5696030", Offset = "0x5694830", VA = "0x185696030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public MDHHOEPMEJH EIMLOBHMOKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x56966B0", Offset = "0x5694EB0", VA = "0x1856966B0")]
		get
		{
			return default(MDHHOEPMEJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public IEnumerable<IFDBCDKGAKP> LIHHNICJHIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5696390", Offset = "0x5694B90", VA = "0x185696390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IEnumerable<IFDBCDKGAKP> CIHHFHHLBPM
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5695D50", Offset = "0x5694550", VA = "0x185695D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public int FEMJFAPHKOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x56959C0", Offset = "0x56941C0", VA = "0x1856959C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int DMPDAGIELKP
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5695950", Offset = "0x5694150", VA = "0x185695950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public string EHNKIECOKGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5695E90", Offset = "0x5694690", VA = "0x185695E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public GKNLHHGAJBJ MPEEHMCPNPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5695C80", Offset = "0x5694480", VA = "0x185695C80")]
		get
		{
			return default(GKNLHHGAJBJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5695CE0", Offset = "0x56944E0", VA = "0x185695CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KOBJCHCIPDK LGKHDDBDILL
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x56962D0", Offset = "0x5694AD0", VA = "0x1856962D0")]
		get
		{
			return default(KOBJCHCIPDK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x56958E0", Offset = "0x56940E0", VA = "0x1856958E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public bool IMDOGHMJBCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5695C60", Offset = "0x5694460", VA = "0x185695C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool OJEONBJBIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5695AA0", Offset = "0x56942A0", VA = "0x185695AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool IAHGAMMMOJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5695F50", Offset = "0x5694750", VA = "0x185695F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool EKEJNKNNNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x56959A0", Offset = "0x56941A0", VA = "0x1856959A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool PKDOPKPBDAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5695B40", Offset = "0x5694340", VA = "0x185695B40")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5696380", Offset = "0x5694B80", VA = "0x185696380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool EDHJHDOKJEE
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5695C50", Offset = "0x5694450", VA = "0x185695C50")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x56962C0", Offset = "0x5694AC0", VA = "0x1856962C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public ABGHFGJOMJP HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(ABGHFGJOMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public GKOOCGGAJPI EAFOKJKFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(GKOOCGGAJPI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5696330", Offset = "0x5694B30", VA = "0x185696330")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
	public static IFDBCDKGAKP HFMFJLJFEMO(HBILLJPEKGG KEMGJJIKGPJ)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x56967B0", Offset = "0x5694FB0", VA = "0x1856967B0")]
	public bool PNACCJCFLHC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5695F70", Offset = "0x5694770", VA = "0x185695F70")]
	public bool INCDCJLCMLF(MHBLFBCIOOJ KMIJNFGJKHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5695AC0", Offset = "0x56942C0", VA = "0x185695AC0")]
	public void DOOENMCEEBI(MHBLFBCIOOJ KMIJNFGJKHN, bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x56960B0", Offset = "0x56948B0", VA = "0x1856960B0")]
	public MDHHOEPMEJH KFLDGKMGPIJ(Allocator HMGEFCKKBID)
	{
		return default(MDHHOEPMEJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5696500", Offset = "0x5694D00", VA = "0x185696500")]
	public void MMKKOLGBOJM(HBILLJPEKGG OALEAAIPGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public HBILLJPEKGG(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(HBILLJPEKGG MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5695B50", Offset = "0x5694350", VA = "0x185695B50", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(HBILLJPEKGG OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct HIFCPKCBLJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly GIHIGCCECKO HKIGKJAPFHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly GIHIGCCECKO IODGGLFACBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly uint ODBGJIGBDBI;

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x5697820", Offset = "0x5696020", VA = "0x185697820", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct OCNKCELHKJK
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly HIFCPKCBLJN COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x569CE50", Offset = "0x569B650", VA = "0x18569CE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct OPJLPLBHDCO
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly JNGNMMOLKFF MBNJNNGOKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly HIFCPKCBLJN COPPLLLOGLG;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x569CE50", Offset = "0x569B650", VA = "0x18569CE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct GOIAEDCIPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly uint ODBGJIGBDBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly bool NELCNHPEING;

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5695840", Offset = "0x5694040", VA = "0x185695840", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface HCOBHGJLPEC
{
	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HBCAGCEHILN(LPLJHAHPEEF BBNGIDIFEAM, KBFDDENCLAP MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBFDDENCLAP EOLDLHMFPPA(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IFGNKHDPNPM(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KNCIMBFFAPF(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600022C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int JIDHEKFPBDJ(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LPLJHAHPEEF DALAHDEPMGB(LPLJHAHPEEF BBNGIDIFEAM, int AMOEKOMGDLG);

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JBLGNHMDAPL(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void MHOIOHDEBGB(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE, LPLJHAHPEEF MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MIBNGBOOHIA(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool BBAECJEMDLB(LPLJHAHPEEF BBNGIDIFEAM, out LPLJHAHPEEF MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void NCIJEEANNDH(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool APGHNMMDKBH(LPLJHAHPEEF BBNGIDIFEAM, out float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void IFNBNNACJOG(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool LOANDJHLFAI(LPLJHAHPEEF BBNGIDIFEAM, out float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DKMAAEMKGOB(LPLJHAHPEEF BBNGIDIFEAM, (Quaternion rot, Vector3 moments) CLIBLALIAOK);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool MODBDLLOPDD(LPLJHAHPEEF BBNGIDIFEAM, out quaternion DMNMOPAJMNP, out float3 JOJNFBPIFKO);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void FMPPOCGGNFC(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void GGBFIJIFPHG(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 KOGHJGGGEMA(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 CNGECPPJPHI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void DOILEHPKOHH(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void LEEBNNKCKHE(LPLJHAHPEEF BBNGIDIFEAM, float3 MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float HJHFNOIPKII(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float BHMOCKBJDPO(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void IJDFPPHCBKN(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LIPDAPHEECE(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode JCECFPAKJHL(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void FHIFEAIICMD(LPLJHAHPEEF BBNGIDIFEAM, CollisionDetectionMode MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JOKBKMCLMIE PBEFMJPBFFH(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KDBOHLJLONN(LPLJHAHPEEF BBNGIDIFEAM, JOKBKMCLMIE MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool DNAHEOKDHGH(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void BBNEPNCCNNG(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "32")]
	LPLJHAHPEEF MAPBPOGNGKF(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CHOBMOLMBHF(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "34")]
	LPLJHAHPEEF DFDIEMMHEBB(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void EALODDMPHDN(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "36")]
	NNAEKKHECGM HOPMKNFJLHE(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void CKIDEBMELDH(LPLJHAHPEEF BBNGIDIFEAM, NNAEKKHECGM IBCDMIPMGAK);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool MEHMPKDJBDP(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void OIBHKIADBLM(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool BOLJANMLGBK(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void GJOBDMFJJOA(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool IDMDAIIDMJN(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void GLJJFJKNOGO(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints NAGDEBKFEHK(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void NPCGDOPBECA(LPLJHAHPEEF BBNGIDIFEAM, RigidbodyConstraints MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float DJJMAFIGMJI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void MBONBHFBAAB(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float NBECAMMDPCJ(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void NDIJHBNNIHO(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool JDNGHPIHPKP(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void NNCPNKBNABL(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool BLAKDEJJOGI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void GHCCKMLCBCC(LPLJHAHPEEF BBNGIDIFEAM, bool MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void CLFGOHGNNHE(LPLJHAHPEEF BBNGIDIFEAM, int MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object GKKNNDHOCAM(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void PKKMGBIEBJD(LPLJHAHPEEF BBNGIDIFEAM, object MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object LMGDLPDINGP(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void JIPAKHDJLAC(LPLJHAHPEEF BBNGIDIFEAM, object MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float NOPHEEGLMFC(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void FHCNDHPPAAH(LPLJHAHPEEF BBNGIDIFEAM, float MENBIMCLIOI);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void FIJFLKEJJJH(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void BOLLGHEGOHG(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool MGFDHGAOOGI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void OHEOOLIKMOI(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void BAMMBNKCJHF(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool AIIJIFICJHJ(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool BMHHJAJLMPF(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody NCKOJKBACMA(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void IONILNJBNDH(LPLJHAHPEEF BBNGIDIFEAM, Rigidbody JICGNHIFHFC);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void FNHMFKFJJBB(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void EFFIDBKNFJH(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool MIIPAPHJJMM(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void ECNLGOMEKBO(LPLJHAHPEEF BBNGIDIFEAM, float3 KFENDEDNACE);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void OPMKNCFCKJJ(LPLJHAHPEEF BBNGIDIFEAM, float3 ODPEGCEAOBB);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool KCBCPJPKHLK(LPLJHAHPEEF BBNGIDIFEAM, out float3 KFENDEDNACE);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool BKOIHPALNFO(LPLJHAHPEEF BBNGIDIFEAM, out float3 ODPEGCEAOBB);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool JFPOCPBHJDN(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void FABLDMDCGON(LPLJHAHPEEF BBNGIDIFEAM, object AMCDGOPKAOE, bool KOHKILNBHGA);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void LFIMFKHCIBN(LPLJHAHPEEF BBNGIDIFEAM, bool MBNLNJHDMAK);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void PCOCJDNBDCE(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool DHPPJLKDPKC(LPLJHAHPEEF BBNGIDIFEAM);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface ALFHDLJDEIN
{
	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OKAEPNPENJP(Entity PNLGFGIAADP);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LBFHMOAJDMD(Entity PNLGFGIAADP);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct EHBMGPLCIKI : IEquatable<EHBMGPLCIKI>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly EHBMGPLCIKI BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public string FNCHNPJAGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600027C")]
		[Cpp2IlInjected.Address(RVA = "0x5693B80", Offset = "0x5692380", VA = "0x185693B80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string FHHBNBFONDI
	{
		[Cpp2IlInjected.Token(Token = "0x600027D")]
		[Cpp2IlInjected.Address(RVA = "0x5693EC0", Offset = "0x56926C0", VA = "0x185693EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000283")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public EHBMGPLCIKI(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(RVA = "0x5693DC0", Offset = "0x56925C0", VA = "0x185693DC0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(EHBMGPLCIKI OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct GOEPIMCKACB : IEquatable<GOEPIMCKACB>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly GOEPIMCKACB BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000289")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(RVA = "0x5695700", Offset = "0x5693F00", VA = "0x185695700", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000287")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(GOEPIMCKACB OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000288")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct BJBHKCCDDOI : IEquatable<BJBHKCCDDOI>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly BJBHKCCDDOI BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	private JGHGFLIKNJI HLKONLMEBLK
	{
		[Cpp2IlInjected.Token(Token = "0x600028B")]
		[Cpp2IlInjected.Address(RVA = "0x5691F10", Offset = "0x5690710", VA = "0x185691F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public bool NBEGJHJNAKK
	{
		[Cpp2IlInjected.Token(Token = "0x600028F")]
		[Cpp2IlInjected.Address(RVA = "0x5691E30", Offset = "0x5690630", VA = "0x185691E30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool GEMBAHMAPCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000290")]
		[Cpp2IlInjected.Address(RVA = "0x56921A0", Offset = "0x56909A0", VA = "0x1856921A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool PEPBNMEINEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000291")]
		[Cpp2IlInjected.Address(RVA = "0x5691A80", Offset = "0x5690280", VA = "0x185691A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool FDAKIMJNKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000292")]
		[Cpp2IlInjected.Address(RVA = "0x5691990", Offset = "0x5690190", VA = "0x185691990")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool MLIPHBOLJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000293")]
		[Cpp2IlInjected.Address(RVA = "0x5691AE0", Offset = "0x56902E0", VA = "0x185691AE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool HOCGBLLCCKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x56922E0", Offset = "0x5690AE0", VA = "0x1856922E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5691F90", Offset = "0x5690790", VA = "0x185691F90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5691AB0", Offset = "0x56902B0", VA = "0x185691AB0")]
	public bool INJBDGIMLII()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5691CD0", Offset = "0x56904D0", VA = "0x185691CD0")]
	public IFDBCDKGAKP JDDKOHMLMML(IFDBCDKGAKP BEELAINJGPH)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600028E")]
	[Cpp2IlInjected.Address(RVA = "0x5691FE0", Offset = "0x56907E0", VA = "0x185691FE0")]
	public LPLJHAHPEEF LKFJEOKJMCG()
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public BJBHKCCDDOI(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(BJBHKCCDDOI MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5691890", Offset = "0x5690090", VA = "0x185691890", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(BJBHKCCDDOI OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct LLNAAGHGEOA : IComparable<LLNAAGHGEOA>, IEquatable<LLNAAGHGEOA>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly LLNAAGHGEOA HCMFGAEBPME;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly LLNAAGHGEOA KIDGLIGMFOC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly LLNAAGHGEOA OBBJPCGENNB;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly LLNAAGHGEOA OJNLGFONEFB;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly LLNAAGHGEOA DACOEJJMABL;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly LLNAAGHGEOA HEFOCJIEACF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int JNDMMPHMODJ;

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public bool CFFFCGANABL
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x569BA60", Offset = "0x569A260", VA = "0x18569BA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public int HPFHGJHJNAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x569BA50", Offset = "0x569A250", VA = "0x18569BA50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002A2")]
	[Cpp2IlInjected.Address(RVA = "0xB1A5C0", Offset = "0xB18DC0", VA = "0x180B1A5C0")]
	public LLNAAGHGEOA(int AMOEKOMGDLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x569B9E0", Offset = "0x569A1E0", VA = "0x18569B9E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x569B950", Offset = "0x569A150", VA = "0x18569B950", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x3B90590", Offset = "0x3B8ED90", VA = "0x183B90590", Slot = "5")]
	public bool Equals(LLNAAGHGEOA OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x569B940", Offset = "0x569A140", VA = "0x18569B940", Slot = "4")]
	public int CompareTo(LLNAAGHGEOA OALEAAIPGBP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x1560180", Offset = "0x155E980", VA = "0x181560180")]
	public static LLNAAGHGEOA HFMFJLJFEMO(int AMOEKOMGDLG)
	{
		return default(LLNAAGHGEOA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x1560180", Offset = "0x155E980", VA = "0x181560180")]
	public static int HFMFJLJFEMO(LLNAAGHGEOA BAAPPBDHEJN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x569BA70", Offset = "0x569A270", VA = "0x18569BA70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[DefaultMember("Item")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface OABILJFHBBI : IEnumerable<ILFNLPAIJLJ>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	ILFNLPAIJLJ ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002AD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ILFNLPAIJLJ HPADBCECEJC(FKFIIEPBNGA ELAAPFMOMBJ);

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LLNAAGHGEOA LNDPHGGBMPP(FKFIIEPBNGA ELAAPFMOMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class PBDKPOHEPFF
{
	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x22F3CC0", Offset = "0x22F24C0", VA = "0x1822F3CC0")]
	public static LLNAAGHGEOA LNDPHGGBMPP<T>(this OABILJFHBBI LAEPKFGACAO, KNCFGIDDJIE<T> MDOAADHDBMA) where T : struct
	{
		return default(LLNAAGHGEOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface GHENGDIBFHP
{
	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EOAAKMENOIA(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NHBENKJGECB(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LAIOKBGNPEL(LPLJHAHPEEF BBNGIDIFEAM, out Guid IBOAMBHJEOF);

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid ABGCNLBBDGB(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DNCHPFCOGDB(LPLJHAHPEEF BBNGIDIFEAM, Guid IBOAMBHJEOF);

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PJEEDHFNHJN(LPLJHAHPEEF BBNGIDIFEAM, out Guid KJOHEJEFBGI);

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid CKNCLDAALNH(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PCEFKKCGOIO(LPLJHAHPEEF BBNGIDIFEAM, Guid KJOHEJEFBGI);

	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LPDMPILCFCM(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JECKGKLBAGL(LPLJHAHPEEF CICDHHEGIAO, LPLJHAHPEEF GJPBCFJDGCH);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface BEGAPFFEIJA
{
	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HHKBNMMEIAK(LPLJHAHPEEF PMFGMJJBADH, bool MENBIMCLIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct BMAEGOEOJJA : IEquatable<BMAEGOEOJJA>
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly BMAEGOEOJJA BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public AKKEBNNJKAF GFDENFDDALM
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(AKKEBNNJKAF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	private FMEELEIDPMO KKACDPPCMDG
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0x5692650", Offset = "0x5690E50", VA = "0x185692650")]
		get
		{
			return default(FMEELEIDPMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public JBOEKGNECFI AHEMEHDKMHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x56926B0", Offset = "0x5690EB0", VA = "0x1856926B0")]
		get
		{
			return default(JBOEKGNECFI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002BF")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public BMAEGOEOJJA(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(BMAEGOEOJJA MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(RVA = "0x5692550", Offset = "0x5690D50", VA = "0x185692550", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(BMAEGOEOJJA OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface MDFAPHDDPNI
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JEKGJDFCBCL(LPLJHAHPEEF BBNGIDIFEAM, GKNLHHGAJBJ PDONLOAMCIM, bool MODLCEHPNLL, MHBLFBCIOOJ GLMFGFBMGDL);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JFENPLKHOJI(LPLJHAHPEEF BBNGIDIFEAM, GKNLHHGAJBJ PDONLOAMCIM, bool MODLCEHPNLL, bool FIPHPGDDBJE, bool AKEHOCJFCOF);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AFNIAKIMNEA FKHGMCIEMLE(LPLJHAHPEEF CEABICNIABB, List<LPLJHAHPEEF> IMNFBCKBCMB);

	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CPFDALCIJKF(GameObject LDFDCIEMAFL, GameObject MACCMMJHDPC);

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DLNMPAIABKP(GameObject MACCMMJHDPC);

	[Cpp2IlInjected.Token(Token = "0x60002CC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T BCLLCNDBFHG<T>(GameObject BBPEBGOHEKI) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AOHLPONKKAO(Collider PINIOELHAHC);

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject ONLIOHCMOCC<T>(string MDOAADHDBMA) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface LGNMGLONHCC
{
	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	IReadOnlyCollection<ADGLENNGCHF> EFMMGHNDFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EIKFILDIBOC(int KFGBCCEFCMB, out ADGLENNGCHF PPCAJPBKNLP);

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ADGLENNGCHF HFFOKKPLPBC(Type EIOLDDJPDLH);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class MDPIAJMHKDF
{
	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x2B66C30", Offset = "0x2B65430", VA = "0x182B66C30")]
	public static T GHONLIMLIHJ<T>(this LGNMGLONHCC FMICHEFGCMM, Entity AJDEFAPHMKF) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x2B66CD0", Offset = "0x2B654D0", VA = "0x182B66CD0")]
	public static ADGLENNGCHF HFFOKKPLPBC<T>(this LGNMGLONHCC FMICHEFGCMM) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface INNKBFIJCKK
{
	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	bool CENAPLLCNNC
	{
		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface ILGLLPNDOPK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	bool MFOOGNNDIAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	bool EPHICNGJANM
	{
		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	KFBLILCDCFC AAMNPMAJFHE
	{
		[Cpp2IlInjected.Token(Token = "0x60002D9")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CANOBKDKPKE BHBEILODPMK(bool KIMBDGBPCDE = false);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CANOBKDKPKE OEIFJLJHGAF(IEnumerable<LPLJHAHPEEF> ADGNPKODABN, in JBNGNAKFECF ACCIBJJKHBD);

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LKLBFCMBGLM PJAKHLOHDBO(ByteString OAJGCLKKKCC);

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "7")]
	JHDIDEHGHHN HNCAPJKGLCH(ByteString BLAINNBNMDK, LPLJHAHPEEF GJPBCFJDGCH, in JBNGNAKFECF KPBEHAGEDNH, IMKNGLHILIB PCBJOBHPHLP, bool GKKIHDGELJK = true);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EBPLINDPDIC();

	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HMHDKPNECEP(bool FBODNDKNFPF);

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "10")]
	LIIAPEIGDIL AMOMLNLOMHC(IEnumerable<PMMFFJMLFOG> DBOJPELNHKC);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class ELCEMMGJBGF
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface ABMIKBNFCBA : IIIIOJEFCCI, KANIKAONFJI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	NDJLNOJIHMB NGDMEGOLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	NAHGLKOIEAI BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	LDDLEDJLLMH KFFJIACNNGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface KANIKAONFJI
{
	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	bool JLFBNHADDGL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface DEHMGEGCJGP
{
	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	bool LONOKHLOKFA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface JKPMGMPNGAH
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	Guid MIJFGGLIKIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NBOMEHICHNL(Guid IBOAMBHJEOF, Guid KJOHEJEFBGI, string MDOAADHDBMA);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct GIHIGCCECKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal int CNJDAMBDKMB;

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(RVA = "0x5694FA0", Offset = "0x56937A0", VA = "0x185694FA0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class BFBFFOCLBLL
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private struct CIKJALKKEFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Guid IBLFHKFALNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public IFADFPDAEIP NOFDJGBLNBE;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct IFADFPDAEIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int MENBIMCLIOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int AMGPHJMEDHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int LLCPAKMPKCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int IGPHBCLELCK;

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0x5698A10", Offset = "0x5697210", VA = "0x185698A10")]
		public bool HJDMPAFCNFC(out MHGAJIKGEGE ECBAIECDCID)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x5698AB0", Offset = "0x56972B0", VA = "0x185698AB0")]
		public IFADFPDAEIP(MHGAJIKGEGE ECBAIECDCID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(RVA = "0x56917D0", Offset = "0x568FFD0", VA = "0x1856917D0")]
	public static Guid DHOCOFMJLPH(this MHGAJIKGEGE ECBAIECDCID)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(RVA = "0x5691870", Offset = "0x5690070", VA = "0x185691870")]
	public static bool GHKFMKJFICH(this Guid IBLFHKFALNL, out MHGAJIKGEGE ECBAIECDCID)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DebuggerTypeProxy(typeof(OBFJEOEMPPC))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct LPLJHAHPEEF : IComparable<LPLJHAHPEEF>, IEquatable<LPLJHAHPEEF>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly LPLJHAHPEEF HCMFGAEBPME;

	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	public HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	public LocalId CAHOAMPFNHK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xB1A5B0", Offset = "0xB18DB0", VA = "0x180B1A5B0")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public bool PINCLHPNEDE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0x569BE40", Offset = "0x569A640", VA = "0x18569BE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public bool JDIAINLDKCG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0x569BD10", Offset = "0x569A510", VA = "0x18569BD10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool NDKFCBCIJLG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0x569BC90", Offset = "0x569A490", VA = "0x18569BC90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F4")]
	[Cpp2IlInjected.Address(RVA = "0x569C010", Offset = "0x569A810", VA = "0x18569C010")]
	public LPLJHAHPEEF(HMBELPNBOEG PIPAMJGKALL, LocalId BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002F5")]
	[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
	public IFDBCDKGAKP NGCCLOJNEBB()
	{
		return default(IFDBCDKGAKP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(RVA = "0xB1A5B0", Offset = "0xB18DB0", VA = "0x180B1A5B0")]
	public static LocalId HFMFJLJFEMO(LPLJHAHPEEF FPPGGAHPGNP)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x569BDE0", Offset = "0x569A5E0", VA = "0x18569BDE0")]
	public static Entity HFMFJLJFEMO(LPLJHAHPEEF FPPGGAHPGNP)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x569BDF0", Offset = "0x569A5F0", VA = "0x18569BDF0")]
	public static bool MJNLEMCBPOF(LPLJHAHPEEF MBLAPCMEEGI, LPLJHAHPEEF NBEGIGNBOIE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x569BBF0", Offset = "0x569A3F0", VA = "0x18569BBF0")]
	public static bool ACJEIIDJLOL(LPLJHAHPEEF MBLAPCMEEGI, LPLJHAHPEEF NBEGIGNBOIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FA")]
	[Cpp2IlInjected.Address(RVA = "0x569BF10", Offset = "0x569A710", VA = "0x18569BF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(RVA = "0x569BD30", Offset = "0x569A530", VA = "0x18569BD30", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x569BCB0", Offset = "0x569A4B0", VA = "0x18569BCB0", Slot = "4")]
	public int CompareTo(LPLJHAHPEEF OALEAAIPGBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "5")]
	public bool Equals(LPLJHAHPEEF OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class CAKHDNEMPPA
{
	[Cpp2IlInjected.Token(Token = "0x6000300")]
	[Cpp2IlInjected.Address(RVA = "0x5692920", Offset = "0x5691120", VA = "0x185692920")]
	public static MHGAJIKGEGE OMHDNNDLEHC(this LPLJHAHPEEF CEPDEAHBHLF)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x2D88AB0", Offset = "0x2D872B0", VA = "0x182D88AB0")]
	public static T HLGOHEKFAMC<T>(this LPLJHAHPEEF CEPDEAHBHLF) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class OBFJEOEMPPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface OBIIMMCNMNC
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool GKHBBLGCCAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JKAIIPECNDE(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LGGJMHBFDJB(LPLJHAHPEEF BBNGIDIFEAM, bool MODLCEHPNLL, bool FIPHPGDDBJE, bool PLNJLKFIAEF);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct HDEKHHMMCPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly MDHHOEPMEJH NJCFCNKMPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NativeArray<byte> MMOFNBHFDNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NativeArray<byte> MAIOOLBIJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly LLNAAGHGEOA BAAPPBDHEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly int FKCGGOALIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Type ADKCCCMIKMM;

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public MDHHOEPMEJH IOJCJDFGGBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000306")]
		[Cpp2IlInjected.Address(RVA = "0x1AB06F0", Offset = "0x1AAEEF0", VA = "0x181AB06F0")]
		get
		{
			return default(MDHHOEPMEJH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x56968B0", Offset = "0x56950B0", VA = "0x1856968B0")]
	public HDEKHHMMCPI(MDHHOEPMEJH NJCFCNKMPKG, NativeArray<byte> MMOFNBHFDNB, NativeArray<byte> MAIOOLBIJID, LLNAAGHGEOA BAAPPBDHEJN, int FKCGGOALIOM, Type ADKCCCMIKMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x1CB0240", Offset = "0x1CAEA40", VA = "0x181CB0240")]
	public NativeArray<T> EIGHKFPGDCO<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x1CB0280", Offset = "0x1CAEA80", VA = "0x181CB0280")]
	public NativeArray<T> HAJEECEOBPD<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1CB02C0", Offset = "0x1CAEAC0", VA = "0x181CB02C0")]
	public (MDHHOEPMEJH, NativeArray<T>, NativeArray<T>) LPKBLHIFLLL<T>() where T : struct
	{
		return default((MDHHOEPMEJH, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5696810", Offset = "0x5695010", VA = "0x185696810")]
	public POJLFICOPEH JOFJLHCLNHL()
	{
		return default(POJLFICOPEH);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct HNHAAMLAAOG : IEquatable<HNHAAMLAAOG>
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly HNHAAMLAAOG BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000315")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	private NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000316")]
		[Cpp2IlInjected.Address(RVA = "0x5697D00", Offset = "0x5696500", VA = "0x185697D00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5697AC0", Offset = "0x56962C0", VA = "0x185697AC0")]
	public void EEGACNDDJLF(bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5697D50", Offset = "0x5696550", VA = "0x185697D50")]
	public void PIKMHCOAEFM(bool MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x2A1FBA0", Offset = "0x2A1E3A0", VA = "0x182A1FBA0")]
	public T OAEOKPJPFFF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public HNHAAMLAAOG(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(RVA = "0x5697C00", Offset = "0x5696400", VA = "0x185697C00", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(HNHAAMLAAOG OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct NKDBLLOLLAM : IEquatable<NKDBLLOLLAM>
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly NKDBLLOLLAM BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x569CD10", Offset = "0x569B510", VA = "0x18569CD10", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(NKDBLLOLLAM OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface FNKAOJGCPPO
{
	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	KCIFFDLJEIC BMCOEBHBIOA
	{
		[Cpp2IlInjected.Token(Token = "0x600031E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	KCIFFDLJEIC IFFNPFCMKEB
	{
		[Cpp2IlInjected.Token(Token = "0x600031F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	KCIFFDLJEIC BBGJPJPLCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000320")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	KCIFFDLJEIC LIFMNDKANBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	KCIFFDLJEIC GFIDAKODEAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	KCIFFDLJEIC HKPJDPLPPEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	KCIFFDLJEIC OBIJHCNJMGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000324")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	KCIFFDLJEIC CFLOJLHMGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000325")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct BCHHHLKLMCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float AEEIFGNFLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 LKJKFPNAKOC;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct AKKEBNNJKAF : IEquatable<AKKEBNNJKAF>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly AKKEBNNJKAF BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	private AHHHPIJFDPM AKDJBHBBFHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x5690840", Offset = "0x568F040", VA = "0x185690840")]
		get
		{
			return default(AHHHPIJFDPM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public GMFFNDBCIJE FADAMOKALLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x5690900", Offset = "0x568F100", VA = "0x185690900")]
		get
		{
			return default(GMFFNDBCIJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public KGMOFLDMIKF IKNFNEIIJHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5690C90", Offset = "0x568F490", VA = "0x185690C90")]
		get
		{
			return default(KGMOFLDMIKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public EAMPFGHELBN OOPJOGPHGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x5690750", Offset = "0x568EF50", VA = "0x185690750")]
		get
		{
			return default(EAMPFGHELBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public GCHPCFMMMFK FEPMBMHCHPI
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(RVA = "0x5690BA0", Offset = "0x568F3A0", VA = "0x185690BA0")]
		get
		{
			return default(GCHPCFMMMFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public EKMBBDEMLDN NJNDBMKLJIN
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(RVA = "0x5690560", Offset = "0x568ED60", VA = "0x185690560")]
		get
		{
			return default(EKMBBDEMLDN);
		}
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x5690CF0", Offset = "0x568F4F0", VA = "0x185690CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public KFMLNKEHNMN NKFPLPJIMGO
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(RVA = "0x5690500", Offset = "0x568ED00", VA = "0x185690500")]
		get
		{
			return default(KFMLNKEHNMN);
		}
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(RVA = "0x5690960", Offset = "0x568F160", VA = "0x185690960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public float NNLLCMDHBKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(RVA = "0x5690A50", Offset = "0x568F250", VA = "0x185690A50")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x5690AB0", Offset = "0x568F2B0", VA = "0x185690AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public Vector3 LMIPLMGPCEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x56905C0", Offset = "0x568EDC0", VA = "0x1856905C0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x56907B0", Offset = "0x568EFB0", VA = "0x1856907B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public float FLIGAIMEIPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5690480", Offset = "0x568EC80", VA = "0x185690480")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public AHKFOICDACF.FENFDOMFCLG BIPGDBNJHCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(RVA = "0x56908A0", Offset = "0x568F0A0", VA = "0x1856908A0")]
		get
		{
			return default(AHKFOICDACF.FENFDOMFCLG);
		}
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(RVA = "0x5690C20", Offset = "0x568F420", VA = "0x185690C20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public ABGHFGJOMJP HNEEPLJLHAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(ABGHFGJOMJP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x5690B30", Offset = "0x568F330", VA = "0x185690B30")]
	public BMAEGOEOJJA KPFBPACBOAA()
	{
		return default(BMAEGOEOJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x56909E0", Offset = "0x568F1E0", VA = "0x1856909E0")]
	public KNBBFGODFFJ HLHLHIEODKH()
	{
		return default(KNBBFGODFFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000338")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public AKKEBNNJKAF(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600033A")]
	[Cpp2IlInjected.Address(RVA = "0x56909D0", Offset = "0x568F1D0", VA = "0x1856909D0")]
	public static bool HFMFJLJFEMO(AKKEBNNJKAF MENBIMCLIOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033B")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600033C")]
	[Cpp2IlInjected.Address(RVA = "0x5690650", Offset = "0x568EE50", VA = "0x185690650", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(AKKEBNNJKAF OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface NHHFEIDPNIC
{
	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	NCFCHDEHMHC NGDMEGOLFHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	NAHGLKOIEAI BKEEIANIHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	ILBBGIPPPPJ FINDODONFAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	AEDKFOCGAIL EAFOKJKFLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	IKCMADHPPKE PNGKBDHOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	ILGLLPNDOPK GENBLHALMFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	MEGBGGHIJBE CBFCGAFOEKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	NNHDHBPFLOE GHMDJOGEELA
	{
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	FKAJABEJDAD DGGJMABKKIK
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	JGHGFLIKNJI FCPJBKLDKIE
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	OJMMJKOMFGB HKPJDPLPPEG
	{
		[Cpp2IlInjected.Token(Token = "0x600034D")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	BEGAPFFEIJA NCMCCDOKGMM
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	HMLONANDNGP KOBGPAMELOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	GHENGDIBFHP OHHBPAEGGHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	BHNAPIGDOEG FJDBDHFEDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	HCOBHGJLPEC GCLFBEPNJDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	FNKAOJGCPPO AILIOFHMAPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	LGNMGLONHCC OJBBAPDGNDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface IBFEILDIMEI
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	object GMLOHACNMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000356")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFOEKHCJJMM(MDHHOEPMEJH ADGNPKODABN);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface AEDKFOCGAIL
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<POJLFICOPEH> MMGBNMECLCP;

	[Cpp2IlInjected.Token(Token = "0x6000359")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LPLJHAHPEEF MAPBPOGNGKF(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600035A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DFJCHFPPGHC(ref List<LPLJHAHPEEF> BDNDLOBMJJM);

	[Cpp2IlInjected.Token(Token = "0x600035B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	LPLJHAHPEEF DFDIEMMHEBB(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600035C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EALODDMPHDN(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF GJPBCFJDGCH, bool ECCMKOMFCJG);

	[Cpp2IlInjected.Token(Token = "0x600035D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool DMMEGNFOAHA(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF GJPBCFJDGCH);

	[Cpp2IlInjected.Token(Token = "0x600035E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int JIDHEKFPBDJ(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600035F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MDHHOEPMEJH AJPDFKPLCLJ(LPLJHAHPEEF PMFGMJJBADH);

	[Cpp2IlInjected.Token(Token = "0x6000360")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PGFPMKJEAKM(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF MPGGAHNCHOK);

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool IBBKINNCCLP(LPLJHAHPEEF BBNGIDIFEAM, LPLJHAHPEEF IKDGFEDODNH);

	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "11")]
	LPLJHAHPEEF MFGAAMGNJKL(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool FOCFAPBPKCF(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK, out LPLJHAHPEEF PLFDJFKPNCP);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class CAALMIHNJJG
{
	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(RVA = "0x5692750", Offset = "0x5690F50", VA = "0x185692750")]
	public static List<LPLJHAHPEEF> DFJCHFPPGHC(this AEDKFOCGAIL AAOAOHHKNIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(RVA = "0x5692840", Offset = "0x5691040", VA = "0x185692840")]
	public static bool FEKKIFEGAIM(this AEDKFOCGAIL AAOAOHHKNIM, LPLJHAHPEEF BBNGIDIFEAM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum FOFNGPEFGJJ
{
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	Uninitialized,
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	Legacy,
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	Embodied,
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	Disembodying,
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	Disembodied
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface NNHDHBPFLOE
{
	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<LPLJHAHPEEF> APFFHKPGKIK(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "1")]
	LPLJHAHPEEF KOPKNHHCEDF(LPLJHAHPEEF BBNGIDIFEAM, int AMOEKOMGDLG);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int LMJPKCHPFDI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CLPCIHAOJOM NCGJPMEIIBJ(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void EKOGHAFLLCD(LPLJHAHPEEF BBNGIDIFEAM, CLPCIHAOJOM LGKGBPHHHBD);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	LPLJHAHPEEF KLJAFGCLOOF(LPLJHAHPEEF BBNGIDIFEAM, [Optional] float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] float3? FJJHHNAFAEK);

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	LPLJHAHPEEF GOKBPNBGHBJ(LPLJHAHPEEF BBNGIDIFEAM, int AMOEKOMGDLG, [Optional] float3? PAOMABBDKAH, [Optional] quaternion? APAHFEOKBOD, [Optional] float3? FJJHHNAFAEK);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NDMOLDIAMKP(LPLJHAHPEEF BBNGIDIFEAM, int AMOEKOMGDLG);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void BFBENNIJCMB(LPLJHAHPEEF BBNGIDIFEAM);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface ICLGKIICAFG
{
	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PEPEEONGLMF(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CNKDIEMBMOE(LPLJHAHPEEF BBNGIDIFEAM, Transform LAMNAOAMKPM);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface EOOBMMBDNHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	LocalId IJOEAPEPGDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000371")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	LocalId BLMMPLPOHDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000372")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000373")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KFCFKAJHONB(float3 FLLINCEBFIA);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JDEAGJGPLNL(float3 FLLINCEBFIA);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GEOOKIKCABA(out float3 HKIGKJAPFHM, out float3 IODGGLFACBF);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DDEKIMNMOLC(float3 HKIGKJAPFHM, float3 IODGGLFACBF);

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NMBKNDACMPF(Color HKIGKJAPFHM, Color IODGGLFACBF);

	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EOOBMMBDNHM Instantiate(Transform LAMNAOAMKPM);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface PMMHNLLCGCB
{
	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDCEDMLOOPD(Transform LAMNAOAMKPM, EOOBMMBDNHM GEJLHMDPOIP);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EOOBMMBDNHM OHAMELLGPNJ();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct JMMLILPLDFA : IEquatable<JMMLILPLDFA>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly JMMLILPLDFA BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private LMMBFBALAEH BEINACLHHIB
	{
		[Cpp2IlInjected.Token(Token = "0x600037C")]
		[Cpp2IlInjected.Address(RVA = "0x5699CD0", Offset = "0x56984D0", VA = "0x185699CD0")]
		get
		{
			return default(LMMBFBALAEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public NNDFHEKCGKG NONHDCLPNIL
	{
		[Cpp2IlInjected.Token(Token = "0x600037D")]
		[Cpp2IlInjected.Address(RVA = "0x5699E30", Offset = "0x5698630", VA = "0x185699E30")]
		get
		{
			return default(NNDFHEKCGKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(RVA = "0x5699E90", Offset = "0x5698690", VA = "0x185699E90")]
	public CEMBDKOPINH PEKMBMNHJKL()
	{
		return default(CEMBDKOPINH);
	}

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public JMMLILPLDFA(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(RVA = "0x5699D30", Offset = "0x5698530", VA = "0x185699D30", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(JMMLILPLDFA OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct ENAIDKMPOMD : IEquatable<ENAIDKMPOMD>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly ENAIDKMPOMD BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600038A")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x5693FB0", Offset = "0x56927B0", VA = "0x185693FB0", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(ENAIDKMPOMD OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct MEPLGIHMMLJ : IEquatable<MEPLGIHMMLJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly MEPLGIHMMLJ BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public MEPLGIHMMLJ(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x569C850", Offset = "0x569B050", VA = "0x18569C850", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(MEPLGIHMMLJ OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x569C720", Offset = "0x569AF20", VA = "0x18569C720")]
	public bool CHEDPCPIPGG(out Collider PINIOELHAHC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct FONHLENHBMG : IEquatable<FONHLENHBMG>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly FONHLENHBMG BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public LPLJHAHPEEF OKNLLHGKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000395")]
		[Cpp2IlInjected.Address(RVA = "0x13203E0", Offset = "0x131EBE0", VA = "0x1813203E0")]
		get
		{
			return default(LPLJHAHPEEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x600039A")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public KNBBFGODFFJ GAPMCJGBHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600039B")]
		[Cpp2IlInjected.Address(RVA = "0x5694EA0", Offset = "0x56936A0", VA = "0x185694EA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public float3 NKFGMFOLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x56949C0", Offset = "0x56931C0", VA = "0x1856949C0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x5694B30", Offset = "0x5693330", VA = "0x185694B30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public quaternion FBEABAEGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x600039E")]
		[Cpp2IlInjected.Address(RVA = "0x5694750", Offset = "0x5692F50", VA = "0x185694750")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x600039F")]
		[Cpp2IlInjected.Address(RVA = "0x5694A50", Offset = "0x5693250", VA = "0x185694A50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float3 IIHODDIJPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003A0")]
		[Cpp2IlInjected.Address(RVA = "0x56947D0", Offset = "0x5692FD0", VA = "0x1856947D0")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5694CF0", Offset = "0x56934F0", VA = "0x185694CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public IHDIMGJIFBM FELJKAKPEON
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5694BC0", Offset = "0x56933C0", VA = "0x185694BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private ELFJDKOOCOK KNCOHPFCJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5694DE0", Offset = "0x56935E0", VA = "0x185694DE0")]
		get
		{
			return default(ELFJDKOOCOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private OFKFCGLBLIH BIJABMNGGJP
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5694960", Offset = "0x5693160", VA = "0x185694960")]
		get
		{
			return default(OFKFCGLBLIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private OENHHELNIDC HDJNBLBFJMB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5694AD0", Offset = "0x56932D0", VA = "0x185694AD0")]
		get
		{
			return default(OENHHELNIDC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private MIEHPEANHGD CGNBGKHBCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5694E40", Offset = "0x5693640", VA = "0x185694E40")]
		get
		{
			return default(MIEHPEANHGD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private IJANENNDCFB DNANMKKEDPC
	{
		[Cpp2IlInjected.Token(Token = "0x60003AA")]
		[Cpp2IlInjected.Address(RVA = "0x5694D80", Offset = "0x5693580", VA = "0x185694D80")]
		get
		{
			return default(IJANENNDCFB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public FONHLENHBMG(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5694860", Offset = "0x5693060", VA = "0x185694860", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000398")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(FONHLENHBMG OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x5694C30", Offset = "0x5693430", VA = "0x185694C30")]
	public void KPKOONLDJNJ(KNBBFGODFFJ MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A4")]
	[Cpp2IlInjected.Address(RVA = "0x5694B30", Offset = "0x5693330", VA = "0x185694B30")]
	public void KFDLIJACOBF(float3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5694A50", Offset = "0x5693250", VA = "0x185694A50")]
	public void KBGOAGBBAAK(quaternion MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct ABGHFGJOMJP : IEquatable<ABGHFGJOMJP>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly ABGHFGJOMJP BLGELENGKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly LPLJHAHPEEF PMFGMJJBADH;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public IFDBCDKGAKP JCLOAFMPDNI
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x568FF40", Offset = "0x568E740", VA = "0x18568FF40")]
		get
		{
			return default(IFDBCDKGAKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private HMBELPNBOEG AFLOIHDEPAG
	{
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x7DF100", Offset = "0x7DD900", VA = "0x1807DF100")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private IKCMADHPPKE MANGFDHCFCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x568F9F0", Offset = "0x568E1F0", VA = "0x18568F9F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool AACMIHKKKCO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x568EC80", Offset = "0x568D480", VA = "0x18568EC80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 NKFGMFOLDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B6")]
		[Cpp2IlInjected.Address(RVA = "0x568E500", Offset = "0x568CD00", VA = "0x18568E500")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x56900A0", Offset = "0x568E8A0", VA = "0x1856900A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Quaternion FBEABAEGHCD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x568D860", Offset = "0x568C060", VA = "0x18568D860")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x568ECD0", Offset = "0x568D4D0", VA = "0x18568ECD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Vector3 PFJCFHCNFEB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x568EE90", Offset = "0x568D690", VA = "0x18568EE90")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x568CB50", Offset = "0x568B350", VA = "0x18568CB50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion GILONKGEPGA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x568F4C0", Offset = "0x568DCC0", VA = "0x18568F4C0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x568EFF0", Offset = "0x568D7F0", VA = "0x18568EFF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public float KOOJKGHAFCB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x568FD00", Offset = "0x568E500", VA = "0x18568FD00")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x568CFC0", Offset = "0x568B7C0", VA = "0x18568CFC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public float DINGNFIDHMK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x568DD10", Offset = "0x568C510", VA = "0x18568DD10")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Vector3 IIHODDIJPJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x568DA10", Offset = "0x568C210", VA = "0x18568DA10")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x568F8B0", Offset = "0x568E0B0", VA = "0x18568F8B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Vector3 PKOBJAEMOMA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x568FA60", Offset = "0x568E260", VA = "0x18568FA60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Vector3 KMKIGBCIDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x568FBA0", Offset = "0x568E3A0", VA = "0x18568FBA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Matrix4x4 KNODJOICCIM
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x568EE10", Offset = "0x568D610", VA = "0x18568EE10")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x2017D10", Offset = "0x2016510", VA = "0x182017D10")]
	public ABGHFGJOMJP(LPLJHAHPEEF BBNGIDIFEAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AD")]
	[Cpp2IlInjected.Address(RVA = "0x1EA4040", Offset = "0x1EA2840", VA = "0x181EA4040", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AE")]
	[Cpp2IlInjected.Address(RVA = "0x568DB70", Offset = "0x568C370", VA = "0x18568DB70", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AF")]
	[Cpp2IlInjected.Address(RVA = "0x568DC70", Offset = "0x568C470", VA = "0x18568DC70", Slot = "4")]
	public bool Equals(ABGHFGJOMJP OALEAAIPGBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B0")]
	[Cpp2IlInjected.Address(RVA = "0x56901E0", Offset = "0x568E9E0", VA = "0x1856901E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x568D680", Offset = "0x568BE80", VA = "0x18568D680")]
	public FCGLJAMFFMC DMBABJAEGNF()
	{
		return default(FCGLJAMFFMC);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C6")]
	[Cpp2IlInjected.Address(RVA = "0x568EAF0", Offset = "0x568D2F0", VA = "0x18568EAF0")]
	public void ICFHNOGCJJE(out Matrix4x4 ILDEBNONBOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C7")]
	[Cpp2IlInjected.Address(RVA = "0x568CC90", Offset = "0x568B490", VA = "0x18568CC90")]
	public void ADONEMEIFIN(out Vector3 BPPHLBOBHIP, out Quaternion CDPAFIABEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C8")]
	[Cpp2IlInjected.Address(RVA = "0x568E7A0", Offset = "0x568CFA0", VA = "0x18568E7A0")]
	public void HNGCHLOFNEH(out RigidTransform FEILPNOBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003C9")]
	[Cpp2IlInjected.Address(RVA = "0x568D6F0", Offset = "0x568BEF0", VA = "0x18568D6F0")]
	public JBNGNAKFECF EAICJLAMINP()
	{
		return default(JBNGNAKFECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CA")]
	[Cpp2IlInjected.Address(RVA = "0x568D740", Offset = "0x568BF40", VA = "0x18568D740")]
	public void EAICJLAMINP(out JBNGNAKFECF EFACIDLJAMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CB")]
	[Cpp2IlInjected.Address(RVA = "0x568DE10", Offset = "0x568C610", VA = "0x18568DE10")]
	public JBNGNAKFECF FNOGGFNJENE()
	{
		return default(JBNGNAKFECF);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CC")]
	[Cpp2IlInjected.Address(RVA = "0x568DE60", Offset = "0x568C660", VA = "0x18568DE60")]
	public void FNOGGFNJENE(out JBNGNAKFECF FEILPNOBNOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x568CE60", Offset = "0x568B660", VA = "0x18568CE60")]
	public Vector3 AFHOMGAJMLH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x568F270", Offset = "0x568DA70", VA = "0x18568F270")]
	public void KFDLIJACOBF(in Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x568D210", Offset = "0x568BA10", VA = "0x18568D210")]
	public Vector3 BGNBGEJHCHN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x568FE00", Offset = "0x568E600", VA = "0x18568FE00")]
	public void OFPFKNFIPHK(in Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x568D4D0", Offset = "0x568BCD0", VA = "0x18568D4D0")]
	public Quaternion CCLAJFGECPI()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x568F130", Offset = "0x568D930", VA = "0x18568F130")]
	public void KBGOAGBBAAK(in Quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x568E1F0", Offset = "0x568C9F0", VA = "0x18568E1F0")]
	public Quaternion GBMIBJMJHCF()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x568FF60", Offset = "0x568E760", VA = "0x18568FF60")]
	public void PHPLCBBHGNF(in Quaternion MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x568E9F0", Offset = "0x568D1F0", VA = "0x18568E9F0")]
	public float IBKKBCCLKMB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x568DF80", Offset = "0x568C780", VA = "0x18568DF80")]
	public void FPFILMBFBCA(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x568F7B0", Offset = "0x568DFB0", VA = "0x18568F7B0")]
	public float LEMICPDPBOH()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x568F3B0", Offset = "0x568DBB0", VA = "0x18568F3B0")]
	public void KFNMBFMCJEL(float MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x568D0D0", Offset = "0x568B8D0", VA = "0x18568D0D0")]
	public void BBAPEDLDGHL(in Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x568E3A0", Offset = "0x568CBA0", VA = "0x18568E3A0")]
	public Vector3 GIJOOKNKPIK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x568E660", Offset = "0x568CE60", VA = "0x18568E660")]
	public void HGBCENPALNG(in Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x568E090", Offset = "0x568C890", VA = "0x18568E090")]
	public Vector3 GANHJMFFNFJ()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x568F670", Offset = "0x568DE70", VA = "0x18568F670")]
	public void KPFKAIIOHPG(in Vector3 MENBIMCLIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x568D370", Offset = "0x568BB70", VA = "0x18568D370")]
	public Vector3 CBFHIEGPLEE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x568E8B0", Offset = "0x568D0B0", VA = "0x18568E8B0")]
	public void HOIKNANDLMA(in Vector3 MENBIMCLIOI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface HMBELPNBOEG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	NHHFEIDPNIC BNFKDIONJJI
	{
		[Cpp2IlInjected.Token(Token = "0x60003E5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<MDHHOEPMEJH, NativeArray<KECBEHOHBCN>> NMCOOHJJDEP;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<MDHHOEPMEJH> POBNPMAMCEI;

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(Slot = "5")]
	APFIBDNJBME JPCHGEPHIEH(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KECBEHOHBCN HDEFOGKKFEG(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JACMNDDEBJP(MHGAJIKGEGE ECBAIECDCID, FKKNGLCNOFO CKMMOGKGLFH);

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "8")]
	IFDBCDKGAKP OMDNJAEMAPA(LPLJHAHPEEF BBNGIDIFEAM, [Optional] object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool JLOABAPGJKJ(LPLJHAHPEEF BBNGIDIFEAM, out FKKNGLCNOFO CKMMOGKGLFH);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LOMNBKALOHK(LPLJHAHPEEF BBNGIDIFEAM, out Transform LAMNAOAMKPM);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool IGAMJDGIHFK(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void LALMNDMOKEI(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool KPMJLLFPDAO(LocalId BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool DCBHKHFJOGA(LocalId BBNGIDIFEAM, object AMCDGOPKAOE);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "15")]
	LPLJHAHPEEF JIFMDGFNNCE(MHGAJIKGEGE ECBAIECDCID);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "16")]
	MHGAJIKGEGE OMHDNNDLEHC(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "17")]
	MDHHOEPMEJH JIFMDGFNNCE(NativeArray<MHGAJIKGEGE> ECBAIECDCID, Allocator HMGEFCKKBID);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "18")]
	MDHHOEPMEJH IMDNOOLOJIB(NativeArray<MHGAJIKGEGE> ECBAIECDCID, NativeArray<CBGNFPNAGKM> NHOIGPDOBNB, Allocator HMGEFCKKBID);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "19")]
	IFDBCDKGAKP KIDGLIGMFOC(KECBEHOHBCN MCBNACIDAGA, bool NICMHNKPPOK);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "20")]
	IFDBCDKGAKP KIDGLIGMFOC(KECBEHOHBCN MCBNACIDAGA);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "21")]
	IFDBCDKGAKP OBIOJJIDPBA(KECBEHOHBCN MCBNACIDAGA);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "22")]
	IFDBCDKGAKP CNPFDBKPHFC(KECBEHOHBCN MCBNACIDAGA);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "23")]
	IFDBCDKGAKP IMDNOOLOJIB(MHGAJIKGEGE ECBAIECDCID, KECBEHOHBCN MCBNACIDAGA);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "24")]
	HBILLJPEKGG JJOKELHAGFN();

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "25")]
	KNBBFGODFFJ GGBAPGAFNOF();

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "26")]
	BMAEGOEOJJA NEIMIMJEBHI(JBOEKGNECFI CNKAKBKBEGM);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void IKDLJOMDIEB(MDHHOEPMEJH ADGNPKODABN);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void CLOOKKNDFON(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void JBIKODGILBE(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void IKDLJOMDIEB(LPLJHAHPEEF BBNGIDIFEAM);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "31")]
	MDHHOEPMEJH MMCNJDCOMKI(MDHHOEPMEJH FGPFEGPDAHM, Allocator HMGEFCKKBID);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "32")]
	bool PINCLHPNEDE(LPLJHAHPEEF BBNGIDIFEAM);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class DIBKOPHEANM
{
	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(RVA = "0x5693440", Offset = "0x5691C40", VA = "0x185693440")]
	public static void LALMNDMOKEI(this HMBELPNBOEG LNJHNPCFKIL, FKKNGLCNOFO CKMMOGKGLFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(RVA = "0x5693390", Offset = "0x5691B90", VA = "0x185693390")]
	public static IFDBCDKGAKP KMHFICCGFIM(this HMBELPNBOEG LNJHNPCFKIL, LocalId BBNGIDIFEAM)
	{
		return default(IFDBCDKGAKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(RVA = "0x5693370", Offset = "0x5691B70", VA = "0x185693370")]
	public static LPLJHAHPEEF JIFMDGFNNCE(this HMBELPNBOEG LNJHNPCFKIL, LocalId BBNGIDIFEAM)
	{
		return default(LPLJHAHPEEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x56935A0", Offset = "0x5691DA0", VA = "0x1856935A0")]
	public static MHGAJIKGEGE OMHDNNDLEHC(this HMBELPNBOEG LNJHNPCFKIL, LocalId BBNGIDIFEAM)
	{
		return default(MHGAJIKGEGE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5693810", Offset = "0x5692010", VA = "0x185693810")]
	public static bool PINCLHPNEDE(this HMBELPNBOEG LNJHNPCFKIL, MHGAJIKGEGE ECBAIECDCID)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x3075270", Offset = "0x3073A70", VA = "0x183075270")]
	public static T HLGOHEKFAMC<T>(this HMBELPNBOEG LNJHNPCFKIL, LocalId BBNGIDIFEAM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x5693220", Offset = "0x5691A20", VA = "0x185693220")]
	public static HBILLJPEKGG HNCIFLJKCOA(this HMBELPNBOEG LNJHNPCFKIL, RigidTransform EFACIDLJAMI, [Optional] object AMCDGOPKAOE)
	{
		return default(HBILLJPEKGG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5692FB0", Offset = "0x56917B0", VA = "0x185692FB0")]
	public static BMAEGOEOJJA CLMPAEKDPIO(this HMBELPNBOEG LNJHNPCFKIL, JBOEKGNECFI CAABOGKJFNK, RigidTransform EFACIDLJAMI, [Optional] object AMCDGOPKAOE)
	{
		return default(BMAEGOEOJJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x56936C0", Offset = "0x5691EC0", VA = "0x1856936C0")]
	public static KNBBFGODFFJ PCHPBIFGCFP(this HMBELPNBOEG LNJHNPCFKIL, RigidTransform EFACIDLJAMI, [Optional] object AMCDGOPKAOE)
	{
		return default(KNBBFGODFFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5693100", Offset = "0x5691900", VA = "0x185693100")]
	private static void FGJIFNHBCBM(IFDBCDKGAKP DPDMMPFILHG, RigidTransform EFACIDLJAMI, [Optional] object AMCDGOPKAOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x5692DA0", Offset = "0x56915A0", VA = "0x185692DA0")]
	internal static CEMBDKOPINH BOFMECAJKBD(this HMBELPNBOEG LNJHNPCFKIL, GGEPJACPGID BFIAIKKIHBG, [Optional] object AMCDGOPKAOE)
	{
		return default(CEMBDKOPINH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal static class HDPAAKNFDMI
{
	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5697680", Offset = "0x5695E80", VA = "0x185697680")]
	public static NHHFEIDPNIC BNFKDIONJJI(this LPLJHAHPEEF BMKPPKKOMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x5697790", Offset = "0x5695F90", VA = "0x185697790")]
	public static ILBBGIPPPPJ FINDODONFAN(this LPLJHAHPEEF BMKPPKKOMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x56976D0", Offset = "0x5695ED0", VA = "0x1856976D0")]
	public static EntityManager EOOAJAELBGN(this LPLJHAHPEEF BMKPPKKOMAH)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x1CB03E0", Offset = "0x1CAEBE0", VA = "0x181CB03E0")]
	public static T IDJPJOBGJOA<T>(this LPLJHAHPEEF BMKPPKKOMAH) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x1CB15F0", Offset = "0x1CAFDF0", VA = "0x181CB15F0")]
	public static bool NNLANJMIANJ<T>(this LPLJHAHPEEF BMKPPKKOMAH) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
internal interface DGOGKMGLHNE
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<POJLFICOPEH> MMGBNMECLCP;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[HHKHACIGOAG(JLEAEANKKDG.LoadInstance)]
public interface JGHGFLIKNJI
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	bool BLNAFLEBMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000416")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	LPLJHAHPEEF NNFHGAOKNEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000417")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000418")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	IFDBCDKGAKP GMHKNDAAOMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	IFDBCDKGAKP NPDMMDFOPDC
	{
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event IPKOFMACBNG IGCNDNBCPAD;

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	LPLJHAHPEEF MFGAAMGNJKL(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK);

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool FOCFAPBPKCF(LPLJHAHPEEF MPGGAHNCHOK, LPLJHAHPEEF PGMGJHKACLK, out LPLJHAHPEEF PLFDJFKPNCP);

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void DLDFGGEEMKA();

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void PGCLHELOFMI();

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool NBEGJHJNAKK(LPLJHAHPEEF BEELAINJGPH);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public delegate void IPKOFMACBNG(IFDBCDKGAKP FGEBPGEFBJD, IFDBCDKGAKP HGEMMEGKHMI);
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class PPNAGBANBPF
{
	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x569DA90", Offset = "0x569C290", VA = "0x18569DA90")]
	public static bool FHHHCGBFAEF(this JGHGFLIKNJI PHFMBPBGGLO, LPLJHAHPEEF BEELAINJGPH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x569D9A0", Offset = "0x569C1A0", VA = "0x18569D9A0")]
	public static bool FDAKIMJNKBI(this JGHGFLIKNJI PHFMBPBGGLO, LPLJHAHPEEF BEELAINJGPH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
[DefaultMember("Item")]
public interface FCNMLNBCAFD : IEnumerable<KGGCPADPPEB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int GKGAEPJBJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000427")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	KGGCPADPPEB ODGMKJGOOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000428")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KGGCPADPPEB HPADBCECEJC(FKFIIEPBNGA ELAAPFMOMBJ);

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LLNAAGHGEOA LNDPHGGBMPP(FKFIIEPBNGA ELAAPFMOMBJ);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class JDNNGFMFIDP
{
	[Cpp2IlInjected.Token(Token = "0x600042B")]
	[Cpp2IlInjected.Address(RVA = "0x111D3D0", Offset = "0x111BBD0", VA = "0x18111D3D0")]
	public static JPAJHNEFJFD<T> HPADBCECEJC<T>(this FCNMLNBCAFD LAEPKFGACAO, FKFIIEPBNGA MDOAADHDBMA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042C")]
	[Cpp2IlInjected.Address(RVA = "0x111D280", Offset = "0x111BA80", VA = "0x18111D280")]
	public static JPAJHNEFJFD<T> HPADBCECEJC<T>(this FCNMLNBCAFD LAEPKFGACAO, KNCFGIDDJIE<T> MDOAADHDBMA) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(RVA = "0x111D4F0", Offset = "0x111BCF0", VA = "0x18111D4F0")]
	public static LLNAAGHGEOA LNDPHGGBMPP<T>(this FCNMLNBCAFD LAEPKFGACAO, KNCFGIDDJIE<T> MDOAADHDBMA) where T : struct
	{
		return default(LLNAAGHGEOA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface PCMJCEALPLG : HEJFCJDGGFG
{
	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADLDIGGBGPP IJJGMIPANCG(Entity AJDEFAPHMKF);

	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DEDIDDMDOOG(NativeArray<ADLDIGGBGPP> HDLMIMGKPDN, NativeArray<NHHNAEGJEIL> LMFHKKKEDAC);

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHPDLEMLLNE(ADLDIGGBGPP BJJHADPHPJP);

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KLOOEHPPIMP(ADLDIGGBGPP BJJHADPHPJP, out Collider PINIOELHAHC);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct NHHNAEGJEIL : ISystemStateComponentData, IComponentData, IEquatable<NHHNAEGJEIL>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 PLPDBIDLEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 OODNMIMGGPM;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(RVA = "0x569CC80", Offset = "0x569B480", VA = "0x18569CC80", Slot = "4")]
	public bool Equals(NHHNAEGJEIL OALEAAIPGBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct PMMFFJMLFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Guid IBLFHKFALNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public string NECMDMMFDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Vector3 PAOMABBDKAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Quaternion APAHFEOKBOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 FJJHHNAFAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int JAGBHLPCMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Dictionary<string, object> LGKGBPHHHBD;

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(RVA = "0x569D250", Offset = "0x569BA50", VA = "0x18569D250", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(RVA = "0x569D0C0", Offset = "0x569B8C0", VA = "0x18569D0C0")]
	private static string KCLLBAENDHM(Dictionary<string, object> OJICEFMMHOH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum EJOPMBPGGHJ
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum ACCHBEBMBDA
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class OKBGLPPJGEM
{
	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x34D3420", Offset = "0x34D1C20", VA = "0x1834D3420")]
	public static bool MBNECJBFDDF(this ACCHBEBMBDA EIOLDDJPDLH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface LKLBFCMBGLM : KFBLILCDCFC, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Flags]
public enum MPAKIJEEIFP
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	NotifyEnabledState = 2,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	PostInstantiate = 0x10,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	NotifyInstantiated = 0x20,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	DisposeProtobuf = 0x40,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	NotifyCompleted = 0x80,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	WorldPhasesMaster = 0xFF,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	WorldPhasesClient = 0xF7,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	AdditivePhases = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
[Flags]
public enum PJJHNJMGJHG
{
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	SetEnabledInRoom = 2,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	PreInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	BulkInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	PostInstantiate = 0x30,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	LoadCompleted = 0xC0,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	All = 0xFF
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
public interface JHDIDEHGHHN : KFBLILCDCFC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	IMKNGLHILIB KICFICJJDEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000439")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JELDACCCIFL();

	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JCEGMOCDGHI();
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface IMKNGLHILIB
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MOALHDNCFBO(Guid EMGBKAPJLEO, out Guid KLLNOLIEMOA);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface CANOBKDKPKE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	HIJMGKLGPJD BHNPCKKBFBL
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString OHMEEAJBIJH();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface KFBLILCDCFC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	IEnumerable<PMMFFJMLFOG> GOFBMLPNGIO
	{
		[Cpp2IlInjected.Token(Token = "0x600043F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	LIIAPEIGDIL MEOGKPPDLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000440")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	LocalId PDHEKOKAFFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	HIJMGKLGPJD KJOEGIKHDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000442")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	Task HIEHBJMEMDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool LCEFAGCAIBN(MPAKIJEEIFP PODDIAOEGNA);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface JDNCKFIKKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HOJAFNDLCOI(int KFGBCCEFCMB);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface CHEMKFODHFN
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	IEnumerable<MGDMPJGJKNM> CHEOJKMDPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool ONLMHPAKKHH(int KFGBCCEFCMB, out MGDMPJGJKNM PPCAJPBKNLP);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface ABEFDFBINIG
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	List<(JFKJFANPLHM nameHash, FGAIDOMHKBP stableTypeHash, Type type)> JMNMOKDKDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000448")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[HHKHACIGOAG(JLEAEANKKDG.Application)]
public interface LMFAIJHLJOL
{
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JFKJFANPLHM AEDLPELAGEF(int KFGBCCEFCMB);

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int HICMHLBAJKB(JFKJFANPLHM NCCLPGLKOFD);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface NMHGLGPLAKN
{
	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DIPAGPDLGIJ(MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA BAAPPBDHEJN, ReadOnlySpan<byte> CNBLIGIGBNA, ReadOnlySpan<byte> OBDIMDDAHMH);

	[Cpp2IlInjected.Token(Token = "0x600044C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool LEEFMGEANJH(MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA BAAPPBDHEJN);

	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CKONMIBIIIM(MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA BAAPPBDHEJN, ReadOnlySpan<byte> OBDIMDDAHMH);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool NBKFNAPJLJO(MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA BAAPPBDHEJN, Span<byte> CNBLIGIGBNA, Span<byte> OBDIMDDAHMH);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class NFOCNNLKEIE
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(RVA = "0x2ACADF0", Offset = "0x2AC95F0", VA = "0x182ACADF0")]
	public static bool NBKFNAPJLJO<T>(this NMHGLGPLAKN JOFADFCEDHM, MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA BAAPPBDHEJN, out T CNBLIGIGBNA, out T OBDIMDDAHMH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(RVA = "0x2ACACD0", Offset = "0x2AC94D0", VA = "0x182ACACD0")]
	public static bool CKONMIBIIIM<T>(this NMHGLGPLAKN JOFADFCEDHM, MHGAJIKGEGE ALMGAKBKBMK, LLNAAGHGEOA BAAPPBDHEJN, T OBDIMDDAHMH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public enum AFGFBBBEOIA
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface LMIJBIFPCCA : IGGLPBJEPAJ<LMIJBIFPCCA>
{
	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOPGAJGAFLG(LLNAAGHGEOA BMKPPKKOMAH, out EOAAFILKOHP PPCAJPBKNLP);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class PJJNOAENJGA
{
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface DLJKMJDECEO
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	uint GICKBLNLCIN
	{
		[Cpp2IlInjected.Token(Token = "0x6000452")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct POJGIADOGAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public ADKFIICEFJC ODHKMJMLAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public ReadOnlyMemory<byte> BKHMACKFNNF;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface JDLNPAGPGDM
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IAKGAPOOEEK(ADKFIICEFJC ODHKMJMLAIP, ReadOnlySpan<byte> BKHMACKFNNF);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate bool IDBBJEODNJK(NMHGLGPLAKN FOICHJCKABO, in DMEBMKFMGNA MENBIMCLIOI);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate bool OLKALHKHKIE<T>(NMHGLGPLAKN FOICHJCKABO, in T MENBIMCLIOI);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface KOBNMPMOEEH
{
	[Cpp2IlInjected.Token(Token = "0x600045C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JACMNDDEBJP(LLNAAGHGEOA BAAPPBDHEJN, Type KCMKPFGLECK, IDBBJEODNJK DBEDOFAPJFA);

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool BBDHLKEJMII(LLNAAGHGEOA BAAPPBDHEJN, out IDBBJEODNJK DBEDOFAPJFA);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class PPLJMHNIKEB
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class BFLIEFALKFF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public OLKALHKHKIE<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000460")]
		[Cpp2IlInjected.Address(RVA = "0xC2D400", Offset = "0xC2BC00", VA = "0x180C2D400")]
		public BFLIEFALKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000461")]
		[Cpp2IlInjected.Address(RVA = "0x2195470", Offset = "0x2193C70", VA = "0x182195470")]
		internal bool EKLHNKJJGKI(NMHGLGPLAKN pendingList, in DMEBMKFMGNA value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600045E")]
	[Cpp2IlInjected.Address(RVA = "0x2301BA0", Offset = "0x23003A0", VA = "0x182301BA0")]
	public static void JACMNDDEBJP<T>(this KOBNMPMOEEH DBAHNFPKFPM, LLNAAGHGEOA BAAPPBDHEJN, OLKALHKHKIE<T> DBEDOFAPJFA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(RVA = "0x569D8A0", Offset = "0x569C0A0", VA = "0x18569D8A0")]
	public static bool LFKLGMPCKED(this KOBNMPMOEEH DBAHNFPKFPM, NMHGLGPLAKN FOICHJCKABO, LLNAAGHGEOA BAAPPBDHEJN, in DMEBMKFMGNA MENBIMCLIOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct ADKFIICEFJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public uint HJIMKOGCLIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int MNBIMOCGJHC;

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(RVA = "0xAB38B0", Offset = "0xAB20B0", VA = "0x180AB38B0")]
	public ADKFIICEFJC(uint HJIMKOGCLIO, int MNBIMOCGJHC)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(RVA = "0x5690320", Offset = "0x568EB20", VA = "0x185690320")]
	public static bool MJNLEMCBPOF(in ADKFIICEFJC BENALFHNIOG, in ADKFIICEFJC EMAOEIAIOHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(RVA = "0x5690260", Offset = "0x568EA60", VA = "0x185690260", Slot = "0")]
	public override bool Equals(object CEPDEAHBHLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x56902F0", Offset = "0x568EAF0", VA = "0x1856902F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x5690340", Offset = "0x568EB40", VA = "0x185690340", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface KAABEMEKKIO
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ADKFIICEFJC AEDABDKLHHF(ReadOnlySpan<byte> BKHMACKFNNF);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface EOAAFILKOHP
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	Type KPBEFGAMNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KLHPMPNNHAA(ref LHEPNLFFJBK ENOKLPPGOAM, Span<byte> BEELAINJGPH);

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CLIBMONIMNB(ref MHIICIMPJBH HAOHDNKGKPC, ReadOnlySpan<byte> ODHKMJMLAIP);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class PIKADGBHIFK
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public delegate void HDMANPBCGPD(ADKFIICEFJC EECINICJCLK, ReadOnlySpan<byte> BKHMACKFNNF);
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[HHKHACIGOAG(JLEAEANKKDG.OMRoom)]
public interface INFEKLPHEGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMNDNMNBHAD(ADKFIICEFJC EECINICJCLK, ReadOnlySpan<byte> BKHMACKFNNF);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class PGBKCKFKJGL
{
	[Cpp2IlInjected.Token(Token = "0x6000470")]
	[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
	public PGBKCKFKJGL()
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
