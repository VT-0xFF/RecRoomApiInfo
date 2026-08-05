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
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface PODFANACJFD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODBDJACGIND(in float3 MGENAOADJOF, in float3 HCEFOMOBPKF, float FJDPGBJBEDI, Allocator HFHMLIPGBBB, out NativeArray<Entity> GLEBEEEMOOC);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct MEKCIJAEMLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray DFOMJCJNFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<MFPJNGLDGLN, int> HKNDCECPMDH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool OAEPAJFJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x59348E0", Offset = "0x59338E0", VA = "0x1859348E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x12EB4C0", Offset = "0x12EA4C0", VA = "0x1812EB4C0")]
	public MEKCIJAEMLD(NativeBitArray DFOMJCJNFPG, NativeParallelHashMap<MFPJNGLDGLN, int> HKNDCECPMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5934900", Offset = "0x5933900", VA = "0x185934900")]
	public bool PCNCIHDFEDD(MFPJNGLDGLN KHIMPMGAFHG, BIAGKPENIJP LDJJMGJLECK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface JOFGKFBKIJF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid IHPBKDBPOCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DEFCBCIMHFJ(Guid IELELGDGFFC, Guid FACFIDECFDA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task KGDEBCIFHGL(HKCCJJBDGFK MJHIGMBNAAE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MDLHBMKKLCJ(HKCCJJBDGFK IGJGLIJGINK, HKCCJJBDGFK DJAGPEDCGHG, out Vector3 EHELKFGJCKP, out Quaternion MKMPGEPCIPH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CLFHKAOKDCA(LBHFNDBEPPC OLDNOAOLCPO, Vector3 EHELKFGJCKP, Quaternion MKMPGEPCIPH);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface JMDPFBBINKM : FMCBBGDPEBD<HKCCJJBDGFK>, KPLINJJFGJD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface MKEFLIMHPIP<T> : EHNJFEOCJHK<HKCCJJBDGFK, T>, FMCBBGDPEBD<HKCCJJBDGFK>, KPLINJJFGJD, IDisposable, JMDPFBBINKM where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DMGLGHBINAO
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x24B8900", Offset = "0x24B7900", VA = "0x1824B8900")]
	public static T FLFDNJDANPO<T>(this FMCBBGDPEBD<HKCCJJBDGFK> LDJJMGJLECK, HKCCJJBDGFK GCCJEBKFANJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24B88D0", Offset = "0x24B78D0", VA = "0x1824B88D0")]
	public static bool DGLJBNFHKAF<T>(this FMCBBGDPEBD<HKCCJJBDGFK> LDJJMGJLECK, HKCCJJBDGFK GCCJEBKFANJ, in T LEBBAONJLBL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface FBHDDOLDKFD
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<AGIFDGDMJIF> BKLDGLKOJNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HKCCJJBDGFK, HKCCJJBDGFK> MBAHAJMAIJD;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HKCCJJBDGFK, HKCCJJBDGFK> KLAFNDPJGLM;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HKCCJJBDGFK, HKCCJJBDGFK, HKCCJJBDGFK> PFOCFEJHJKA;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HKCCJJBDGFK> MNMOJBMIHEC;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color HINOOFHEHLG(HKCCJJBDGFK GCCJEBKFANJ, int AEDABLCDDHH);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 CHOOOHPEOFK(HKCCJJBDGFK GCCJEBKFANJ, int AEDABLCDDHH);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CBPGKBNAFDO(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK DEMBPJHNCPE);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HKCCJJBDGFK HDGJNICIIFN(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<HKCCJJBDGFK> EPKFMNJAALE(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HKCCJJBDGFK DMPABIGLKIL(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void MNDCNMCMIJL(HKCCJJBDGFK GCCJEBKFANJ, Vector3 PCBFLGGKJDM, Quaternion GHHNIALPDLP);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void EOMCMPPODGO(HKCCJJBDGFK GCCJEBKFANJ, float CDHAPBHGNKC);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool PJNIAENCJMC(HKCCJJBDGFK GCCJEBKFANJ, out RigidTransform CNKCMHLLDGN);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool AHNHEPIDCBN(HKCCJJBDGFK GCCJEBKFANJ, out float HJCFOPCNBFE);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 NHKDCFBBHCG(DIANEFCAIOF CDAFHOLNKPG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion MHIMGBDDAAC(DIANEFCAIOF CDAFHOLNKPG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EJIPHIJJAOO
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface JHMCJDLIGMD
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ODBDJACGIND(in NativeArray<Entity> GLEBEEEMOOC, in float3 MGENAOADJOF, in float3 HCEFOMOBPKF, in NativeArray<KJHMLBOAHKA> HBEDEGJMLHA);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface FENIICLKHIC
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GJKCBEKDPGB(HKCCJJBDGFK IFPLGBGLLJH, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KABMPMFBHGB(HKCCJJBDGFK IFPLGBGLLJH, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OMCICPKNCOP(HKCCJJBDGFK IFPLGBGLLJH, int CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface OFLDOMFNGLF : IEnumerable<HOCJLCNHINC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray NOFAAAFBADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> APFMMGAPFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	HOCJLCNHINC CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	HOCJLCNHINC CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HOCJLCNHINC PMEBAGCJFNJ(NOJOLKBLHAF GOOBHDEKEHB);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	BIAGKPENIJP FNODLIPJFPF(NOJOLKBLHAF GOOBHDEKEHB);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class LPINKIIJPCM
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	public static JGEGAEAAJPO<T> PMEBAGCJFNJ<T>(this OFLDOMFNGLF GHDMEKEFFPC, NOJOLKBLHAF OALFIBFPPAC) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct ABCCPOKAMOO : IEquatable<ABCCPOKAMOO>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly ABCCPOKAMOO CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public ABCCPOKAMOO(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x59268A0", Offset = "0x59258A0", VA = "0x1859268A0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(ABCCPOKAMOO BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct GBAPNDMLLLG : IEquatable<GBAPNDMLLLG>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly GBAPNDMLLLG CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x592E330", Offset = "0x592D330", VA = "0x18592E330", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(GBAPNDMLLLG BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface NCJMHKAOOKH
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	MEKCIJAEMLD FPADLIAJHPE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PCNCIHDFEDD(MFPJNGLDGLN KHIMPMGAFHG, BIAGKPENIJP LDJJMGJLECK);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CBLILKAMLBF(MFPJNGLDGLN KHIMPMGAFHG, Span<BIAGKPENIJP> GHDMEKEFFPC, bool LGIPPDDEDME);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DBEOLCILGOM(NativeArray<MFPJNGLDGLN> JDPGBKCBLGP);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class PKMMPCKGLBD
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5937B20", Offset = "0x5936B20", VA = "0x185937B20")]
	public static void CBLILKAMLBF(this NCJMHKAOOKH PFNJNANOBHN, MFPJNGLDGLN KHIMPMGAFHG, BIAGKPENIJP LDJJMGJLECK, bool LGIPPDDEDME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct PJGCHGOPADA : JBMJFCDEJPH, IEquatable<PJGCHGOPADA>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly PJGCHGOPADA CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject LAPEIFCGFLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5937740", Offset = "0x5936740", VA = "0x185937740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public MFPJNGLDGLN KAIGOPHOMCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x5937510", Offset = "0x5936510", VA = "0x185937510")]
		get
		{
			return default(MFPJNGLDGLN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public HCLMPDLDNOB KJGMDBEBLIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x5937450", Offset = "0x5936450", VA = "0x185937450")]
		get
		{
			return default(HCLMPDLDNOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public ELIGIOKOANN DFNFNBFJCFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x5936DC0", Offset = "0x5935DC0", VA = "0x185936DC0")]
		get
		{
			return default(ELIGIOKOANN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool AFPINDJLBMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x5936D10", Offset = "0x5935D10", VA = "0x185936D10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool DOKBPEOMPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5937330", Offset = "0x5936330", VA = "0x185937330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool LIMBHNLEACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5937280", Offset = "0x5936280", VA = "0x185937280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool MONDDMNGKKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5937430", Offset = "0x5936430", VA = "0x185937430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool JAHLGEIDNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5937120", Offset = "0x5936120", VA = "0x185937120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool OHBHJPLLNJL
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5937260", Offset = "0x5936260", VA = "0x185937260")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool NOHJPDPEFCE
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5936FF0", Offset = "0x5935FF0", VA = "0x185936FF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool NPBAFBNDMKE
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5937840", Offset = "0x5936840", VA = "0x185937840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LKFJEDJKILN AGDEGJHKFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(LKFJEDJKILN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public KLIJNBJNGML LEAAOFFKJAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(KLIJNBJNGML);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JLEAJPBEDFA KOPEHOHKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(JLEAJPBEDFA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DKBMNLCADGF IPKIGIFLHAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(DKBMNLCADGF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GIPHCKBICHE JIAKFCGKKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(GIPHCKBICHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public NAPHIDDMJED CKMJIPDKJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(NAPHIDDMJED);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public LBHFNDBEPPC MFIAILKPHID
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(LBHFNDBEPPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool MKBEIHJJDHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x59375D0", Offset = "0x59365D0", VA = "0x1859375D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool IMMNEPHLKLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x5937860", Offset = "0x5936860", VA = "0x185937860")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool DFGPCBCGGND
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x85F430", Offset = "0x85E430", VA = "0x18085F430", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200", Slot = "5")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public ALEALLIJCOB CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(ALEALLIJCOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public AENNHECMCNB NJDJFHLCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(AENNHECMCNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
	public static PJGCHGOPADA MGOLCJODLKK(HKCCJJBDGFK IFPLGBGLLJH)
	{
		return default(PJGCHGOPADA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x59372A0", Offset = "0x59362A0", VA = "0x1859372A0")]
	public LALPDCJDIII ILDCLFEBABI()
	{
		return default(LALPDCJDIII);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5937960", Offset = "0x5936960", VA = "0x185937960")]
	public KAMOJIBKOIC PIFLDMIOOOH()
	{
		return default(KAMOJIBKOIC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5936E80", Offset = "0x5935E80", VA = "0x185936E80")]
	public ABCCPOKAMOO ECDDAGEDJAG()
	{
		return default(ABCCPOKAMOO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5937140", Offset = "0x5936140", VA = "0x185937140")]
	public CFECOGPFOFC FPFDOBOEGLB()
	{
		return default(CFECOGPFOFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5936D30", Offset = "0x5935D30", VA = "0x185936D30")]
	public DIANEFCAIOF CFOHPMDFENA()
	{
		return default(DIANEFCAIOF);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5937040", Offset = "0x5936040", VA = "0x185937040")]
	public void FIEMAJLPALC([Optional] object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x59371B0", Offset = "0x59361B0", VA = "0x1859371B0")]
	public bool GDPDOIMGHGL(object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x59378B0", Offset = "0x59368B0", VA = "0x1859378B0")]
	public bool NGEIMFGILDK(object FFKJLIDBALM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x59379D0", Offset = "0x59369D0", VA = "0x1859379D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public PJGCHGOPADA(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(PJGCHGOPADA CKDFGEALFAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
	public static HKCCJJBDGFK MGOLCJODLKK(PJGCHGOPADA CKDFGEALFAK)
	{
		return default(HKCCJJBDGFK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x59376A0", Offset = "0x59366A0", VA = "0x1859376A0")]
	public static bool LFCPNLBCIDE(PJGCHGOPADA LFEMLKHNBHE, PJGCHGOPADA CNOAFMMFDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5937350", Offset = "0x5936350", VA = "0x185937350")]
	public static bool JIPCNIGMDBL(PJGCHGOPADA LFEMLKHNBHE, PJGCHGOPADA CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5936EF0", Offset = "0x5935EF0", VA = "0x185936EF0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "6")]
	public bool Equals(PJGCHGOPADA BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void JKJJPGMNNED(EGBHOCHMGFB JLGLAPLPKAO);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct JKFEHKNKIEM : IList<HKCCJJBDGFK>, ICollection<HKCCJJBDGFK>, IEnumerable<HKCCJJBDGFK>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct HEOCIBEEMBJ : IEnumerator<HKCCJJBDGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly ALIKBOGGKHP PKKDNOEMCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator GMJKLGDIAIG;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public HKCCJJBDGFK LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x592F3C0", Offset = "0x592E3C0", VA = "0x18592F3C0", Slot = "4")]
			get
			{
				return default(HKCCJJBDGFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x592F2E0", Offset = "0x592E2E0", VA = "0x18592F2E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x12EB5D0", Offset = "0x12EA5D0", VA = "0x1812EB5D0")]
		public HEOCIBEEMBJ(ALIKBOGGKHP PKKDNOEMCLN, NativeArray<LocalId>.Enumerator GMJKLGDIAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x592F220", Offset = "0x592E220", VA = "0x18592F220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x592F260", Offset = "0x592E260", VA = "0x18592F260", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x592F2A0", Offset = "0x592E2A0", VA = "0x18592F2A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly ALIKBOGGKHP PKKDNOEMCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> GNDGEICPCIH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public HKCCJJBDGFK CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5931570", Offset = "0x5930570", VA = "0x185931570", Slot = "4")]
		get
		{
			return default(HKCCJJBDGFK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x59315F0", Offset = "0x59305F0", VA = "0x1859315F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x59311E0", Offset = "0x59301E0", VA = "0x1859311E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int NKLAFIEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x59311E0", Offset = "0x59301E0", VA = "0x1859311E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DFLKEFAELDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x867480", Offset = "0x866480", VA = "0x180867480", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x59314E0", Offset = "0x59304E0", VA = "0x1859314E0")]
	public JKFEHKNKIEM(ALIKBOGGKHP PKKDNOEMCLN, int PKGBKHCIKEH, Allocator HFHMLIPGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5931160", Offset = "0x5930160", VA = "0x185931160")]
	public FNOEBANGBJI JODEHCGFLEK()
	{
		return default(FNOEBANGBJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5930D40", Offset = "0x592FD40", VA = "0x185930D40", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5930D80", Offset = "0x592FD80", VA = "0x185930D80", Slot = "13")]
	public bool Contains(HKCCJJBDGFK JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5930DE0", Offset = "0x592FDE0", VA = "0x185930DE0", Slot = "14")]
	public void CopyTo(HKCCJJBDGFK[] GJAKHOONFBO, int JGFMCOEDOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x5930CE0", Offset = "0x592FCE0", VA = "0x185930CE0", Slot = "11")]
	public void Add(HKCCJJBDGFK JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x59310E0", Offset = "0x59300E0", VA = "0x1859310E0", Slot = "7")]
	public void Insert(int CCELBNKPBGB, HKCCJJBDGFK JFJFAONKKJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5931270", Offset = "0x5930270", VA = "0x185931270", Slot = "15")]
	public bool Remove(HKCCJJBDGFK JFJFAONKKJC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5931080", Offset = "0x5930080", VA = "0x185931080", Slot = "6")]
	public int IndexOf(HKCCJJBDGFK JFJFAONKKJC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5931220", Offset = "0x5930220", VA = "0x185931220", Slot = "8")]
	public void RemoveAt(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5930FB0", Offset = "0x592FFB0", VA = "0x185930FB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5930FF0", Offset = "0x592FFF0", VA = "0x185930FF0")]
	public HEOCIBEEMBJ EFCEFGGNIIL()
	{
		return default(HEOCIBEEMBJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5931300", Offset = "0x5930300", VA = "0x185931300", Slot = "16")]
	private IEnumerator<HKCCJJBDGFK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x59313F0", Offset = "0x59303F0", VA = "0x1859313F0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface LEADLEEBGNN
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool ODBDJACGIND(in float3 MGENAOADJOF, in float3 HCEFOMOBPKF, float FJDPGBJBEDI, out KJHMLBOAHKA NMKBGNJNBDB, out HKCCJJBDGFK HECCPMEMKKM);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct HIBJKCBPJNI : IEquatable<HIBJKCBPJNI>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly HIBJKCBPJNI CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private IIHCMGCOJKE GAGOECCDCLM
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x592FC80", Offset = "0x592EC80", VA = "0x18592FC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public KAMOJIBKOIC KOFNGFFEECL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(KAMOJIBKOIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public JONKBLJBIMD IHIDONDLAEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x592F430", Offset = "0x592E430", VA = "0x18592F430")]
		get
		{
			return default(JONKBLJBIMD);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x59300A0", Offset = "0x592F0A0", VA = "0x1859300A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<PDLJFDBJILI> DADBEMIOGFM
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x592F600", Offset = "0x592E600", VA = "0x18592F600")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public PDLJFDBJILI CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x592FB60", Offset = "0x592EB60", VA = "0x18592FB60")]
		get
		{
			return default(PDLJFDBJILI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x592F520", Offset = "0x592E520", VA = "0x18592F520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public ALEALLIJCOB CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(ALEALLIJCOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x592FB10", Offset = "0x592EB10", VA = "0x18592FB10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x592FD00", Offset = "0x592ED00", VA = "0x18592FD00")]
	public PDLJFDBJILI KKKACIOLAIO(float3? NKMKMKDMOMJ, [Optional] quaternion? NMKLOHCPMNL, [Optional] Vector3? KFEAJPAHNFK)
	{
		return default(PDLJFDBJILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x592F8E0", Offset = "0x592E8E0", VA = "0x18592F8E0")]
	public PDLJFDBJILI FLPIEKKCHOC(int CCELBNKPBGB, float3? NKMKMKDMOMJ, [Optional] quaternion? NMKLOHCPMNL, [Optional] Vector3? KFEAJPAHNFK)
	{
		return default(PDLJFDBJILI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x592FF20", Offset = "0x592EF20", VA = "0x18592FF20")]
	public void KPMKGKJAOFN(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x5930190", Offset = "0x592F190", VA = "0x185930190")]
	public void PPNJFNMKMCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public HIBJKCBPJNI(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(HIBJKCBPJNI CKDFGEALFAK)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x5930000", Offset = "0x592F000", VA = "0x185930000")]
	public static bool LFCPNLBCIDE(HIBJKCBPJNI LFEMLKHNBHE, HIBJKCBPJNI CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x592F7E0", Offset = "0x592E7E0", VA = "0x18592F7E0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(HIBJKCBPJNI BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface AKCMMPDJKJM
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Type OFGKNCACHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface NKMOKJNBEPM
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool CKCHEMINOPN(HKCCJJBDGFK GCCJEBKFANJ, out Collider NLCHDIPHMDC);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject IDOMEBBMKHF(HKCCJJBDGFK IDHBHKPCJAO, GameObject HPPLDHGJPNF, Vector3 KOFDECELOKC, Quaternion IHOLFEDLPLF);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OLOIGLBGOAD(GameObject NLCHDIPHMDC);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider GHEHJAAPBOD<TCollider>(GameObject OIDMMAFNAAP) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJKLBAMNKOC(Collider NLCHDIPHMDC);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject IMADOEFBJLJ<TCollider>(string OALFIBFPPAC) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface CHIMAECAGEC : FMCBBGDPEBD<MFPJNGLDGLN>, KPLINJJFGJD, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface PBDFKCOAAOA<T> : EHNJFEOCJHK<MFPJNGLDGLN, T>, FMCBBGDPEBD<MFPJNGLDGLN>, KPLINJJFGJD, IDisposable, CHIMAECAGEC where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class NKNNHEIKPEG
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x16E8C50", Offset = "0x16E7C50", VA = "0x1816E8C50")]
	public static bool OLPFKLCKDPK<T>(this FMCBBGDPEBD<MFPJNGLDGLN> LDJJMGJLECK, MFPJNGLDGLN KHIMPMGAFHG, out T CKDFGEALFAK) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x2525340", Offset = "0x2524340", VA = "0x182525340")]
	public static bool DGLJBNFHKAF<T>(this FMCBBGDPEBD<MFPJNGLDGLN> LDJJMGJLECK, MFPJNGLDGLN KHIMPMGAFHG, in T LEBBAONJLBL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct LBHFNDBEPPC : IEquatable<LBHFNDBEPPC>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly LBHFNDBEPPC CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private FKNGADMNJMN NAHKCNBIADD
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x59337C0", Offset = "0x59327C0", VA = "0x1859337C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool DCMGEHINAJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x5933F10", Offset = "0x5932F10", VA = "0x185933F10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid IPHECHHJFJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5933C40", Offset = "0x5932C40", VA = "0x185933C40")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool EMPJNAHHFBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x59336E0", Offset = "0x59326E0", VA = "0x1859336E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Guid BKPOAEJBANG
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5933E20", Offset = "0x5932E20", VA = "0x185933E20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x5933940", Offset = "0x5932940", VA = "0x185933940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5933A80", Offset = "0x5932A80", VA = "0x185933A80")]
	public bool IGEAJJCAIBK(out Guid CIPOMGPCAOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5933D30", Offset = "0x5932D30", VA = "0x185933D30")]
	public void JECLOOIFCOE(Guid HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5933B60", Offset = "0x5932B60", VA = "0x185933B60")]
	public bool IKMHCOOJAID(out Guid LILJFFJEADL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5933990", Offset = "0x5932990", VA = "0x185933990")]
	public void GOBFMFHDBKF(Guid HLLJGNGJMBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5933600", Offset = "0x5932600", VA = "0x185933600")]
	public void AFHJMPFDMEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public LBHFNDBEPPC(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(LBHFNDBEPPC CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5933840", Offset = "0x5932840", VA = "0x185933840", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(LBHFNDBEPPC BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct KLIJNBJNGML : IEquatable<KLIJNBJNGML>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly KLIJNBJNGML CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x59325C0", Offset = "0x59315C0", VA = "0x1859325C0")]
	public void PCLJFJKFDHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x59323F0", Offset = "0x59313F0", VA = "0x1859323F0")]
	public void EIKHLJNEHLB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public KLIJNBJNGML(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x59324C0", Offset = "0x59314C0", VA = "0x1859324C0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(KLIJNBJNGML BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface FOMCNCIAHBP : JBMJFCDEJPH
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	AIMMDJHMCMP ABIKHNPDFAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MHAALKJNCIC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GameObject LAPEIFCGFLM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<FOMCNCIAHBP> GMEPFAEABID;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(MEMGGFMPMAP FJHHKGBBABB, HKCCJJBDGFK ACGEKOMBLDC);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool NFNAEEBJMIL);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class JHAPMMNNLGN
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x5930BF0", Offset = "0x592FBF0", VA = "0x185930BF0")]
	public static bool MKBEIHJJDHK(this FOMCNCIAHBP ENJMODLBMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x5930C90", Offset = "0x592FC90", VA = "0x185930C90")]
	public static bool NPKDKHIDMOJ(this FOMCNCIAHBP ENJMODLBMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x5930C40", Offset = "0x592FC40", VA = "0x185930C40")]
	public static bool MMGKGDDOEKK(this FOMCNCIAHBP ENJMODLBMLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x5930B50", Offset = "0x592FB50", VA = "0x185930B50")]
	public static bool EDGMLIFNIMM(this FOMCNCIAHBP ENJMODLBMLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct NPHGLHOPJDG : IEquatable<NPHGLHOPJDG>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly NPHGLHOPJDG CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x5935B60", Offset = "0x5934B60", VA = "0x185935B60", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(NPHGLHOPJDG BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface ANEOJPMIGAK
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CALFDBGMCCN(NativeListAsync<Entity> HAGHHDIOMMO);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MLJPNHGPKIE(GAOLJCEMJHJ IFFBPHFIAFK);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LLDPPCMDCFH(NativeListAsync<Entity> KHOPJKMOMLI, bool KCPIIOLCOIK);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BMELBLJGONA();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface ECGGIEIINKJ
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HNGIMMNDONH(HKCCJJBDGFK GCCJEBKFANJ, AEOEDAMJAAA CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface OAPKLKFODDG
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFGCLPFHLIL();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MDMOJIOCGNE();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GEMPPIEJBAL();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CIDKJLEBMLC();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGBPDJFPGJG();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DDAEKCEHAFG();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GOKHPHHAOJN();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BBPGBDJHJMC();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HIMHKOJODBL();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void HGHDKILEOMD();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void HBCMAFEGKKB();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface AHGPLJPFOHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int FECOCCPFECL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> AMJLFELJELK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HKCCJJBDGFK PIDPDOICJCG(HKCCJJBDGFK GNDGEICPCIH);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int PIDPDOICJCG(int PJBBMPDGEKG);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PHOICFFACDI : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct DKBMNLCADGF : IEquatable<DKBMNLCADGF>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly DKBMNLCADGF CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private ACJFNIIEFJO FFEBDBCIIJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x592CD80", Offset = "0x592BD80", VA = "0x18592CD80")]
		get
		{
			return default(ACJFNIIEFJO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool KPKNMGJGJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x592CA00", Offset = "0x592BA00", VA = "0x18592CA00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool FOKKLGCPAHG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x592D2D0", Offset = "0x592C2D0", VA = "0x18592D2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool HBPHFAELMBB
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x592CA70", Offset = "0x592BA70", VA = "0x18592CA70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool CACEANLCPJP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x592CF50", Offset = "0x592BF50", VA = "0x18592CF50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool OPIDMFGMIME
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x592D340", Offset = "0x592C340", VA = "0x18592D340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool LJCLNKMMEBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x592CDE0", Offset = "0x592BDE0", VA = "0x18592CDE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool GMBPBMHKGFF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x592D3B0", Offset = "0x592C3B0", VA = "0x18592D3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool PJAHIDBEMIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x592CC00", Offset = "0x592BC00", VA = "0x18592CC00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool OGIMHGBLNHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x592D100", Offset = "0x592C100", VA = "0x18592D100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool CFNKJFLJIJF
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x592D090", Offset = "0x592C090", VA = "0x18592D090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool ECDPBJDJGGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x592CEE0", Offset = "0x592BEE0", VA = "0x18592CEE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool GHBDANBHOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x592D1E0", Offset = "0x592C1E0", VA = "0x18592D1E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool IIJDDFACJOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x592D170", Offset = "0x592C170", VA = "0x18592D170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool HODDCLODIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x592CBE0", Offset = "0x592BBE0", VA = "0x18592CBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool KIHOPEDJBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x592CBF0", Offset = "0x592BBF0", VA = "0x18592CBF0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x592CED0", Offset = "0x592BED0", VA = "0x18592CED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool GICNFLCIDCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x592C870", Offset = "0x592B870", VA = "0x18592C870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 CEDBNLFFLOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x592C7A0", Offset = "0x592B7A0", VA = "0x18592C7A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 KNLLMHHKKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x592CCC0", Offset = "0x592BCC0", VA = "0x18592CCC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool EPNMAKOGLGO
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x592C8E0", Offset = "0x592B8E0", VA = "0x18592C8E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x592CC70", Offset = "0x592BC70", VA = "0x18592CC70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x592D250", Offset = "0x592C250", VA = "0x18592D250")]
	public bool OEILHNLKNCM(DNHKKKPKOHF PMEFJLJOGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x592CFC0", Offset = "0x592BFC0", VA = "0x18592CFC0")]
	public bool KCLMPAIAIBP(LBBFKIAKIDM PMEFJLJOGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x592CE50", Offset = "0x592BE50", VA = "0x18592CE50")]
	public void IGBPGBODKNB(LBBFKIAKIDM PMEFJLJOGPP, bool LJGOKJPEPHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public DKBMNLCADGF(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x592CAE0", Offset = "0x592BAE0", VA = "0x18592CAE0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(DKBMNLCADGF BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum CEJACMPBFFI
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class DOMPOENJBCM
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0xC32990", Offset = "0xC31990", VA = "0x180C32990")]
	public static bool HHGHNOHKFEF(this CEJACMPBFFI CILNOBBJOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0xC32730", Offset = "0xC31730", VA = "0x180C32730")]
	public static bool BJGBLLCIGIF(this CEJACMPBFFI CILNOBBJOLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x44DA460", Offset = "0x44D9460", VA = "0x1844DA460")]
	public static bool KEFABKPGIFC(this CEJACMPBFFI CILNOBBJOLD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface MEMGGFMPMAP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	World LCFEAMOKBNM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	World EHFDILBAJPM
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	EntityManager KLDHCJDHBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool EDGMLIFNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase KOFGMAHJAGI(Type DPPJBLOOGOO);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class CGPFKLIFJCD
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x592BE10", Offset = "0x592AE10", VA = "0x18592BE10")]
	public static ComponentSystemBase OLBBPLHBBJH(this World FJHHKGBBABB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x2C8C8F0", Offset = "0x2C8B8F0", VA = "0x182C8C8F0")]
	public static T KOFGMAHJAGI<T>(this MEMGGFMPMAP ELALBHAFFOK) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct AHCCAGDEAPD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly EGBHOCHMGFB HHCEHFFEAKN;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public FNOEBANGBJI AHPIIDKPELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x12EC1E0", Offset = "0x12EB1E0", VA = "0x1812EC1E0")]
		get
		{
			return default(FNOEBANGBJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x5927510", Offset = "0x5926510", VA = "0x185927510")]
	public AHCCAGDEAPD(EGBHOCHMGFB HHCEHFFEAKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x59271E0", Offset = "0x59261E0", VA = "0x1859271E0")]
	public FNOEBANGBJI BFFOAPANHHJ()
	{
		return default(FNOEBANGBJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x59272B0", Offset = "0x59262B0", VA = "0x1859272B0")]
	public FNOEBANGBJI EKAIDHHBOEE()
	{
		return default(FNOEBANGBJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5927380", Offset = "0x5926380", VA = "0x185927380")]
	public (FNOEBANGBJI, FNOEBANGBJI, FNOEBANGBJI) FLFDNJDANPO()
	{
		return default((FNOEBANGBJI, FNOEBANGBJI, FNOEBANGBJI));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct AENNHECMCNB : IEquatable<AENNHECMCNB>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly AENNHECMCNB CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private CKOPNBJHGFM GFLJHDINOHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5926AE0", Offset = "0x5925AE0", VA = "0x185926AE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public HKCCJJBDGFK KFBIIMCMKJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x5926B60", Offset = "0x5925B60", VA = "0x185926B60")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public PJGCHGOPADA HHNIJBILDJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x5926DA0", Offset = "0x5925DA0", VA = "0x185926DA0")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public PJGCHGOPADA LGIBJPCGOGH
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x5926F90", Offset = "0x5925F90", VA = "0x185926F90")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x5926D50", Offset = "0x5925D50", VA = "0x185926D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5927090", Offset = "0x5926090", VA = "0x185927090")]
	public bool PELENMOAPPI(PJGCHGOPADA DJAGPEDCGHG, bool MPGELPMHFGK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x5926EA0", Offset = "0x5925EA0", VA = "0x185926EA0")]
	public bool MBDAIJNGFEJ(PJGCHGOPADA MCABOIDDKCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public AENNHECMCNB(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x5926C50", Offset = "0x5925C50", VA = "0x185926C50", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(AENNHECMCNB BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct EJBOBFBHFDI : IEquatable<EJBOBFBHFDI>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly EJBOBFBHFDI CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private FHNIJPJPDBG HGDDOABFJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x592D9F0", Offset = "0x592C9F0", VA = "0x18592D9F0")]
		get
		{
			return default(FHNIJPJPDBG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public AIMPNEMJPJO FGOBDKGLKHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x592DA50", Offset = "0x592CA50", VA = "0x18592DA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public EJBOBFBHFDI(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x592DAC0", Offset = "0x592CAC0", VA = "0x18592DAC0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(EJBOBFBHFDI BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface NCFKALCDJNH
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	PIHMDDPJOEG KCPCBDLAFLF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface HNEBHPEJIOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World LJINIFJDALC();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World ILABHPOLOPN();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World MNJFOCIBMIK();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World KHLOKLADGJJ();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface BIOKGBJIPEL
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GLMFBFLLBME(GameObject LAPEIFCGFLM);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFEANOODNKL(GameObject LAPEIFCGFLM);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object AJKFNOIAIKP(HKCCJJBDGFK GCCJEBKFANJ, GameObject LAPEIFCGFLM, Action<HKCCJJBDGFK, int> ELHFOIEJAFO);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FCIEAGAIOKP(GameObject LAPEIFCGFLM, object BNPGOKIPGFF);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface EAAGEJFAJED
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CKIEHKEEAMK(FNOEBANGBJI GNDGEICPCIH);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 CHOOOHPEOFK(GameObject LAPEIFCGFLM, int JMAMEMLOMMM);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JGGELJBBNNF
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHFANCLDDLN(GameObject EEKECJOFAAL, bool MHCBMAAPDGB);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LJMCLOEPLCP(GameObject LAPEIFCGFLM, bool NEBEDKKMFEC, bool GPLGOFEKHFC);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface CNIFFGLDEKI
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEODDIAKPPP(Action OKCPFPFJOFL, bool EILJPFGBGMG);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GFHLLGFBADP(string OALFIBFPPAC);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface MMHLPBGDGCK
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	string KCCDJFGNIIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] JBFKPNFGGIF(IEnumerable<DOLKOKMDPNJ> NLMKNHGINNB);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MFPJNGLDGLN COCEOOKODNG(Guid KINBHKBANKL);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool JPDDGPNILHO(GameObject LAPEIFCGFLM, out MFPJNGLDGLN KHIMPMGAFHG);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool IABIGLBOGJN(GameObject LAPEIFCGFLM, out int OLBPEAOOADL, out ELIGIOKOANN LNODCOPPJNC);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FOMCNCIAHBP HLHNEBGHJBF(DOLKOKMDPNJ CFOFEENKFCN);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FOMCNCIAHBP HLHNEBGHJBF(string LIOPPJMKGHC, MFPJNGLDGLN KHIMPMGAFHG, Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL, Vector3 KFEAJPAHNFK);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ODKNPLANEIH(GameObject LAPEIFCGFLM);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface LMLJPNBPNBE
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ELNPAFLBBHN(bool DDHDBPLDGLB);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface NNAMHLCILEG
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OMEKLNKADHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool ALFIIDEKEPD
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int LPFOEJDEJDN
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool CJEGPOANDLF
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool BKDBCMKGPNK
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void LGHMBCIBEAB(object EMBONFDCNJA);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void MJJENGOONMP(object FBOMMBLFPCD);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IJMONOJNIJH(object FBOMMBLFPCD);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int FALKLMPBMNK(GameObject AMMCILJDEFM);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void OMGLBNPFKLI(NativeArray<int> MFOEDGGLDDO);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface BPNOLKDJLHN
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GOJBPIIKOMI(GameObject LAPEIFCGFLM);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface LBONDDOIHIA
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IDMJLKOGAGC(string HJJLMCEMDKN);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FLPLIKKACKF
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int HJMGBEDNNGJ(GameObject LAPEIFCGFLM);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HHCPPLKNIKB(out Vector3 NKMKMKDMOMJ);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ABDKJNIDKAG();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task EHIJKGNHBFK();

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task CBAFHMONHNJ();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PCOMONEEAFC();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface AHAOLBJJBPL
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	LIILGGONCFG CKKIJNPBBBA
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	GCDOOFPGHGD FPNEBFNJINM
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ICCEEFKECIF(Transform IJKOODCAMMG);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CCDAGHKPNGP(Transform IJKOODCAMMG, PIMHGPGHACE JAFLEDFHJND);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NHAALPFOEAC(Transform IJKOODCAMMG, PIHMDDPJOEG OCBHNJLEKLG);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface JEJBHBLEANN
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task ACIDMEEHHII();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LLHGPLJPDBK();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface IPJDLLMCBNN
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IIGAHECDMOI();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface ALOIJCLJBHB
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ELIGIOKOANN ANCPJOMEDOH(GameObject AMMCILJDEFM);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NABLLKJNOKN(GameObject LAPEIFCGFLM, LBBFKIAKIDM CAODEIMPGBC);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface OMLKFOBDHJK
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool EAHIPLFEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface BJACPPDDPHJ : IDisposable, BIOKGBJIPEL, EAAGEJFAJED, JGGELJBBNNF, CNIFFGLDEKI, MMHLPBGDGCK, LMLJPNBPNBE, NNAMHLCILEG, BPNOLKDJLHN, LBONDDOIHIA, FLPLIKKACKF, OMLKFOBDHJK, AHAOLBJJBPL, JEJBHBLEANN, IPJDLLMCBNN, ALOIJCLJBHB
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class NIFFDBLHFMN
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x59352F0", Offset = "0x59342F0", VA = "0x1859352F0")]
	public static FOMCNCIAHBP HLHNEBGHJBF(this MMHLPBGDGCK IFMMICNCAOG, MFPJNGLDGLN KHIMPMGAFHG, Vector3 NKMKMKDMOMJ, Quaternion NMKLOHCPMNL, Vector3 KFEAJPAHNFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface ADFDNKFPCKF
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct IPFMOBLPPJK : KCABKHEOOAI<IPFMOBLPPJK>, BCBJEENMDEC, IEquatable<IPFMOBLPPJK>
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int EODOJNLPHFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int EBOJEELKNEK
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x12EC400", Offset = "0x12EB400", VA = "0x1812EC400", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x1874F20", Offset = "0x1873F20", VA = "0x181874F20", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x59309F0", Offset = "0x592F9F0", VA = "0x1859309F0", Slot = "8")]
	public bool Equals(IPFMOBLPPJK BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x5930A40", Offset = "0x592FA40", VA = "0x185930A40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface AJHACBAPNID
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct DGDJKIAJCJB : ELNEJMMFHHF, IEquatable<DGDJKIAJCJB>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public ELIGIOKOANN LNODCOPPJNC;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x592C100", Offset = "0x592B100", VA = "0x18592C100", Slot = "5")]
	public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x592C1C0", Offset = "0x592B1C0", VA = "0x18592C1C0", Slot = "4")]
	public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x592C1F0", Offset = "0x592B1F0", VA = "0x18592C1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3F235E0", Offset = "0x3F225E0", VA = "0x183F235E0", Slot = "6")]
	public bool Equals(DGDJKIAJCJB BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x592C130", Offset = "0x592B130", VA = "0x18592C130", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface LBPGENCFGGJ
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool EAHIPLFEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action IBOKAHLIMLJ;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MBLKKIDMLDN();

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FBPMPGNHHON();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJEGOGAEFAH(bool DDHDBPLDGLB);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NCGJNEGOMCH(ByteString PDFBAGGMCIA);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task ABDKJNIDKAG();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task EHIJKGNHBFK();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task CBAFHMONHNJ();

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void JKGMCANGEKK();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface OMMOOGKHFGK
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	KNOFKBKFPEC FBJFMKBBBNC
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	List<JMDPFBBINKM> OIEAHLPECJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool GIFMKHFKDDP(JMDPFBBINKM LDJJMGJLECK, out KNOFKBKFPEC LEKGDNFBAFN);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NONEBCMHGNB(JMDPFBBINKM LDJJMGJLECK, JKJJPGMNNED FEAEMKBJJKG);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LLDOHMCEDEA(JMDPFBBINKM LDJJMGJLECK, JKJJPGMNNED FEAEMKBJJKG);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface FGEHAALBGFN
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	EGDIBEGFLEF EPGIODJIKIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct DIANEFCAIOF : IEquatable<DIANEFCAIOF>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly DIANEFCAIOF CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private FBHDDOLDKFD KGJNPCCJJHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x592C6E0", Offset = "0x592B6E0", VA = "0x18592C6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public float3 LDLJJLAIDPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x592C280", Offset = "0x592B280", VA = "0x18592C280")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public quaternion NOLLFKONLFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x592C370", Offset = "0x592B370", VA = "0x18592C370")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public PJGCHGOPADA BEEHOFEKJMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x592C5B0", Offset = "0x592B5B0", VA = "0x18592C5B0")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x592C560", Offset = "0x592B560", VA = "0x18592C560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public DIANEFCAIOF(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
	public static HKCCJJBDGFK MGOLCJODLKK(DIANEFCAIOF CKDFGEALFAK)
	{
		return default(HKCCJJBDGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x592C460", Offset = "0x592B460", VA = "0x18592C460", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(DIANEFCAIOF BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface IDBGBPOCCGH
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action JKGMCANGEKK;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action AINMFPLLACA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action HPBAFGJJAMD;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KNOFKBKFPEC
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string JKEFCMADMPP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	KNOFKBKFPEC ILMNDEFFDDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	IEnumerable<KNOFKBKFPEC> HPIPPFANPPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public struct FNOEBANGBJI : IReadOnlyList<HKCCJJBDGFK>, IEnumerable<HKCCJJBDGFK>, IEnumerable, IReadOnlyCollection<HKCCJJBDGFK>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct BOBFPBCFJPH : IEnumerator<HKCCJJBDGFK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly ALIKBOGGKHP PKKDNOEMCLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeArray<LocalId>.Enumerator GMJKLGDIAIG;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public HKCCJJBDGFK LMEBIHANEPB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x592BA90", Offset = "0x592AA90", VA = "0x18592BA90", Slot = "4")]
			get
			{
				return default(HKCCJJBDGFK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x592B9B0", Offset = "0x592A9B0", VA = "0x18592B9B0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x12EB5D0", Offset = "0x12EA5D0", VA = "0x1812EB5D0")]
		public BOBFPBCFJPH(ALIKBOGGKHP PKKDNOEMCLN, NativeArray<LocalId>.Enumerator GMJKLGDIAIG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x592B8F0", Offset = "0x592A8F0", VA = "0x18592B8F0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x592B930", Offset = "0x592A930", VA = "0x18592B930", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x592B970", Offset = "0x592A970", VA = "0x18592B970", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly ALIKBOGGKHP PKKDNOEMCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<LocalId> GNDGEICPCIH;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public HKCCJJBDGFK CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x592E2F0", Offset = "0x592D2F0", VA = "0x18592E2F0", Slot = "4")]
		get
		{
			return default(HKCCJJBDGFK);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x592DCA0", Offset = "0x592CCA0", VA = "0x18592DCA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private int IHMNBHIKAPD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int NKLAFIEKONA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x85E1A0", Offset = "0x85D1A0", VA = "0x18085E1A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool PHDAMLHGKHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x592DE20", Offset = "0x592CE20", VA = "0x18592DE20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public NativeArray<LocalId> DIEGHBNCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x12EC390", Offset = "0x12EB390", VA = "0x1812EC390")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal NativeArray<Entity> MCAHOJGFAHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x592DE60", Offset = "0x592CE60", VA = "0x18592DE60")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x592E260", Offset = "0x592D260", VA = "0x18592E260")]
	public FNOEBANGBJI(int OENKBEGLEDJ, ALIKBOGGKHP PKKDNOEMCLN, Allocator HFHMLIPGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x12EADF0", Offset = "0x12E9DF0", VA = "0x1812EADF0")]
	public FNOEBANGBJI(ALIKBOGGKHP PKKDNOEMCLN, NativeArray<LocalId> GNDGEICPCIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x592E0A0", Offset = "0x592D0A0", VA = "0x18592E0A0")]
	internal FNOEBANGBJI(ALIKBOGGKHP PKKDNOEMCLN, NativeArray<Entity> GLEBEEEMOOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x592E1C0", Offset = "0x592D1C0", VA = "0x18592E1C0")]
	public FNOEBANGBJI(ALIKBOGGKHP PKKDNOEMCLN, int PKGBKHCIKEH, Allocator HFHMLIPGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x592E110", Offset = "0x592D110", VA = "0x18592E110")]
	public FNOEBANGBJI(FNOEBANGBJI KLBHAOKPBDN, Allocator HFHMLIPGBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x592DD80", Offset = "0x592CD80", VA = "0x18592DD80")]
	public FNOEBANGBJI ENIJEBFJHBA(Allocator HFHMLIPGBBB = Allocator.Temp)
	{
		return default(FNOEBANGBJI);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x592DCB0", Offset = "0x592CCB0", VA = "0x18592DCB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x592DCF0", Offset = "0x592CCF0", VA = "0x18592DCF0")]
	public BOBFPBCFJPH EFCEFGGNIIL()
	{
		return default(BOBFPBCFJPH);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x592DEC0", Offset = "0x592CEC0", VA = "0x18592DEC0", Slot = "6")]
	private IEnumerator<HKCCJJBDGFK> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x592DFB0", Offset = "0x592CFB0", VA = "0x18592DFB0", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct MFPJNGLDGLN : IComparable<MFPJNGLDGLN>, IEquatable<MFPJNGLDGLN>, ELNEJMMFHHF
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const uint GGOCIPBDDNI = 0u;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const uint CKIPDKKKDID = 255u;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly MFPJNGLDGLN JJICOGFFINC;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int KCFOMJDJKJO = 24;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const uint ONHGKFGCIAB = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int BFDLLINEJMG = 8;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const uint APFHHFPBDIC = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly uint KMJIEGIBFLJ;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public uint MOGAFNIOBLD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA8B070", Offset = "0xA8A070", VA = "0x180A8B070")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public uint FNCIDNAOCJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x5934A00", Offset = "0x5933A00", VA = "0x185934A00")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public uint IAEELPCEIAD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xCACED0", Offset = "0xCABED0", VA = "0x180CACED0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x53E2720", Offset = "0x53E1720", VA = "0x1853E2720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool LBFPABGBLLG
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x5934C10", Offset = "0x5933C10", VA = "0x185934C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x16A7940", Offset = "0x16A6940", VA = "0x1816A7940")]
	public static MFPJNGLDGLN HEBHKBCOIDE(uint KMJIEGIBFLJ)
	{
		return default(MFPJNGLDGLN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5934CF0", Offset = "0x5933CF0", VA = "0x185934CF0")]
	public MFPJNGLDGLN(int AMJEHKBDONP, int GGDDIJKFAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5934CF0", Offset = "0x5933CF0", VA = "0x185934CF0")]
	public MFPJNGLDGLN(uint AMJEHKBDONP, int GGDDIJKFAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x5934CF0", Offset = "0x5933CF0", VA = "0x185934CF0")]
	public MFPJNGLDGLN(uint AMJEHKBDONP, uint GGDDIJKFAAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20")]
	private MFPJNGLDGLN(uint KMJIEGIBFLJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5262120", Offset = "0x5261120", VA = "0x185262120")]
	public static bool LFCPNLBCIDE(MFPJNGLDGLN LFEMLKHNBHE, MFPJNGLDGLN CNOAFMMFDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5262130", Offset = "0x5261130", VA = "0x185262130")]
	public static bool JIPCNIGMDBL(MFPJNGLDGLN LFEMLKHNBHE, MFPJNGLDGLN CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5934A80", Offset = "0x5933A80", VA = "0x185934A80", Slot = "5")]
	public bool Equals(MFPJNGLDGLN IACOMDKJFAL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5934AE0", Offset = "0x5933AE0", VA = "0x185934AE0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x30E24F0", Offset = "0x30E14F0", VA = "0x1830E24F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x5934C20", Offset = "0x5933C20", VA = "0x185934C20", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5934BB0", Offset = "0x5933BB0", VA = "0x185934BB0", Slot = "6")]
	public void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x5934A20", Offset = "0x5933A20", VA = "0x185934A20", Slot = "7")]
	public void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5934A10", Offset = "0x5933A10", VA = "0x185934A10", Slot = "4")]
	public int CompareTo(MFPJNGLDGLN BKLMLPFOMCO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface MDBBGNDLFDI
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLLAPHNFMAF(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PMGOPHBLPKK(Entity NNCCHIHKALO, in float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 BCLCJPKFLDD(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NDEIAIEFPAK(Entity NNCCHIHKALO, in quaternion CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion PDHEIHEDEAC(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLHPLFEBAGO(Entity NNCCHIHKALO, in float3 NKMKMKDMOMJ, in quaternion NMKLOHCPMNL);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GLFKGHMIGDL(Entity NNCCHIHKALO, out float3 NKMKMKDMOMJ, out quaternion NMKLOHCPMNL);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GLFKGHMIGDL(Entity NNCCHIHKALO, out RigidTransform EAODIPHLAKJ);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KGDMDBMPJPH(Entity NNCCHIHKALO, in float3 NKMKMKDMOMJ, in quaternion NMKLOHCPMNL);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void JLOOCHMKJAO(Entity NNCCHIHKALO, out RigidTransform EAODIPHLAKJ);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 LMFEHLIHHOA(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void CPAFOMHNJHC(Entity NNCCHIHKALO, in float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void ADIFOJBBEMO(Entity NNCCHIHKALO, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float AFBEFKLDCLJ(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void BMFIBCEDILE(Entity NNCCHIHKALO, in float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 AJCBELKGCOF(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EPNKLEHOOHN(Entity NNCCHIHKALO, in float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 DHNOOPJGMAH(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void MOGJLPLPBMK(Entity NNCCHIHKALO, in quaternion CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion IHIGOGKPPGM(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 KEDPKKJFEDK(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void DMFHJCEEAAI(Entity NNCCHIHKALO, in float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void AEDGDIKBDHB(Entity NNCCHIHKALO, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float MCLHLDBNEAI(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BBHGBDIAKJH(Entity NNCCHIHKALO, in float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 ILMHCBNNHHH(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void JDECBOLKKDK(Entity NNCCHIHKALO, out float4x4 APCKKDGJBIG);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KMFEBGJLFIL(Entity NNCCHIHKALO, in float4x4 APCKKDGJBIG);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void FKJAHHMJBMB(Entity NNCCHIHKALO, out float4x4 APCKKDGJBIG);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool EIEALANIFEO(Entity NNCCHIHKALO, out Transform IJKOODCAMMG);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NNLPGIGDDGA(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void HDFDJPLDGEK(Entity NNCCHIHKALO, Entity FDGDMGDEEPP, Entity GFJHNOHABFL);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class EPJGAFLKAPC
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct NOIBFAALGKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IEnumerable<DOLKOKMDPNJ> NLMKNHGINNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IReadOnlyList<GameObject> IAGDIKALPMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IReadOnlyList<int> PPIDHBKMDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IReadOnlyList<(MFPJNGLDGLN, MFPJNGLDGLN)> OGKLCOOENKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int PMJJMAHMACG;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool MFPCNNNAAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5935A90", Offset = "0x5934A90", VA = "0x185935A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int KJMGLBBIDJL
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xBB0410", Offset = "0xBAF410", VA = "0x180BB0410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<GameObject> DHMJIFKHDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0xABC950", Offset = "0xABB950", VA = "0x180ABC950")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IEnumerable<(MFPJNGLDGLN src, MFPJNGLDGLN dst)> BIODMMIJBOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x5935AF0", Offset = "0x5934AF0", VA = "0x185935AF0")]
	public NOIBFAALGKM(IEnumerable<DOLKOKMDPNJ> NLMKNHGINNB, IReadOnlyList<GameObject> IAGDIKALPMJ, IReadOnlyList<int> PPIDHBKMDFM, IReadOnlyList<(MFPJNGLDGLN src, MFPJNGLDGLN dst)> OGKLCOOENKK, int PMJJMAHMACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x59356E0", Offset = "0x59346E0", VA = "0x1859356E0")]
	public (GameObject, int)[] IPPBOELCEJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct LALPDCJDIII : IEquatable<LALPDCJDIII>
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly LALPDCJDIII CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private CKOPNBJHGFM GFLJHDINOHI
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5932C80", Offset = "0x5931C80", VA = "0x185932C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public FNOEBANGBJI NCGCGMDHHJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5933180", Offset = "0x5932180", VA = "0x185933180")]
		get
		{
			return default(FNOEBANGBJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IEnumerable<PJGCHGOPADA> LJMGCPOELKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x59326D0", Offset = "0x59316D0", VA = "0x1859326D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public IEnumerable<PJGCHGOPADA> KMEHGILNIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x59328A0", Offset = "0x59318A0", VA = "0x1859328A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int NKIIMAEEAKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5932BA0", Offset = "0x5931BA0", VA = "0x185932BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int JGFBIIEHKAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5932840", Offset = "0x5931840", VA = "0x185932840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string CJABCEFOIIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5933330", Offset = "0x5932330", VA = "0x185933330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public KPHJIOHBDJC FPDGGCCGKFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x59329E0", Offset = "0x59319E0", VA = "0x1859329E0")]
		get
		{
			return default(KPHJIOHBDJC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5932AB0", Offset = "0x5931AB0", VA = "0x185932AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public JJJDPOHJEHD IOHHNPGKGBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x59332A0", Offset = "0x59322A0", VA = "0x1859332A0")]
		get
		{
			return default(JJJDPOHJEHD);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5932A40", Offset = "0x5931A40", VA = "0x185932A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool MMDJKFGDHGP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5932D00", Offset = "0x5931D00", VA = "0x185932D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool PIHKDHFKKLC
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5932F40", Offset = "0x5931F40", VA = "0x185932F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool BANOEEFLLIB
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5933310", Offset = "0x5932310", VA = "0x185933310")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool PEMJHBGKGGC
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5933280", Offset = "0x5932280", VA = "0x185933280")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool IEPKCMAPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5932890", Offset = "0x5931890", VA = "0x185932890")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x5933300", Offset = "0x5932300", VA = "0x185933300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool OMBEGELHOPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5932F30", Offset = "0x5931F30", VA = "0x185932F30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x5933170", Offset = "0x5932170", VA = "0x185933170")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public ALEALLIJCOB CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(ALEALLIJCOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public AENNHECMCNB NJDJFHLCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(AENNHECMCNB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5932E20", Offset = "0x5931E20", VA = "0x185932E20")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
	public static PJGCHGOPADA MGOLCJODLKK(LALPDCJDIII DBGHBAHCJKO)
	{
		return default(PJGCHGOPADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x59333F0", Offset = "0x59323F0", VA = "0x1859333F0")]
	public bool PEPCCJDMFDL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5932E70", Offset = "0x5931E70", VA = "0x185932E70")]
	public bool HMGICFFNFHD(DPJFBCAIHMI PMEFJLJOGPP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5932B20", Offset = "0x5931B20", VA = "0x185932B20")]
	public void DMHPPIODFJD(DPJFBCAIHMI PMEFJLJOGPP, bool CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5932F60", Offset = "0x5931F60", VA = "0x185932F60")]
	public FNOEBANGBJI KJGAGCONCOC(Allocator HFHMLIPGBBB)
	{
		return default(FNOEBANGBJI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5933410", Offset = "0x5932410", VA = "0x185933410")]
	public void PGMDONEDOJF(LALPDCJDIII BKLMLPFOMCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public LALPDCJDIII(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(LALPDCJDIII CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5932D20", Offset = "0x5931D20", VA = "0x185932D20", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(LALPDCJDIII BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct IEHOHMAKKKE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly BOEJDHDNDLH NKCNADFHDPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly BOEJDHDNDLH AOJGCGDGNAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly uint ALKLBPEDKPE;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x5930750", Offset = "0x592F750", VA = "0x185930750", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct FKADMGKNBHG
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly IEHOHMAKKKE OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x592DC00", Offset = "0x592CC00", VA = "0x18592DC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct GFCOOCALHCN
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly HPPHLHFLMDP CGJPMMKJEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly IEHOHMAKKKE OKCPFPFJOFL;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x592DC00", Offset = "0x592CC00", VA = "0x18592DC00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct MPPFDCGADBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly uint ALKLBPEDKPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly bool IKMCBCECBOD;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x5934D00", Offset = "0x5933D00", VA = "0x185934D00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface HIOAPONHMCI
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ONAOFIDNJCD(HKCCJJBDGFK GCCJEBKFANJ, KEDINEBOMHC CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KEDINEBOMHC MKEPPCPONBF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDHEGCDPHGI(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void HIJNKPPMGLM(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DMPPJJGMJFB(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HKCCJJBDGFK BNCLIJAIILH(HKCCJJBDGFK GCCJEBKFANJ, int CCELBNKPBGB);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AOPDEDCCPPD(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void BPOOKBGGLAJ(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM, HKCCJJBDGFK CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void MGKMFJELNJL(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool IIOPHKKHGMH(HKCCJJBDGFK GCCJEBKFANJ, out HKCCJJBDGFK CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void BNFBHCILJCF(HKCCJJBDGFK GCCJEBKFANJ, float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool MLCKCFKOCNB(HKCCJJBDGFK GCCJEBKFANJ, out float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void GGHIDNBKIDB(HKCCJJBDGFK GCCJEBKFANJ, float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool BJDHGNNLIHH(HKCCJJBDGFK GCCJEBKFANJ, out float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DMHCNALJAIJ(HKCCJJBDGFK GCCJEBKFANJ, (Quaternion rot, Vector3 moments) DKHOIHPOENC);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool CIFHCDACPMN(HKCCJJBDGFK GCCJEBKFANJ, out quaternion MKMPGEPCIPH, out float3 JFIICGHAOJA);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void LMNALDABNGF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void CJFNGNHFFIM(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 HEHBDFHCPHN(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 LENIBLLKNMP(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void CCMDHONJIPP(HKCCJJBDGFK GCCJEBKFANJ, float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool ONCFJOJJPGO(HKCCJJBDGFK GCCJEBKFANJ, out float3 ODAJEPEMELA);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void MCBIEFNFMGM(HKCCJJBDGFK GCCJEBKFANJ, float3 CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void MPEBAFLLPBC(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float JENGHDHLJCF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float AMCKMILMLCN(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NCAEEIONACK(HKCCJJBDGFK GCCJEBKFANJ, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool HAFIHHHOFEN(HKCCJJBDGFK GCCJEBKFANJ, out float LJJHDOLPJOB);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void LLGPAMCLCMF(HKCCJJBDGFK GCCJEBKFANJ, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode FKDLPCIHICB(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EAKFIKNNNAN(HKCCJJBDGFK GCCJEBKFANJ, CollisionDetectionMode CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	FMOMJHKLCHF BKOEPHAKLPB(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FONKEEKBKDN(HKCCJJBDGFK GCCJEBKFANJ, FMOMJHKLCHF CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool OFPLNKINOID(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void LCLEIHCFPMD(HKCCJJBDGFK GCCJEBKFANJ, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "35")]
	HKCCJJBDGFK GCMNHECACAG(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void ANGOBBCBGEI(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "37")]
	HKCCJJBDGFK FGBAEAHBLGF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void PELENMOAPPI(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "39")]
	FLACBGLBMKA LLLBBKKPGCN(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void EFGPAAOGBPA(HKCCJJBDGFK GCCJEBKFANJ, FLACBGLBMKA ACKBLPKDHMI);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool LPHPNBLADPP(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void FHDAPAFIHAF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool DDDKPCNCCGG(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void BAJGMKOJHGM(HKCCJJBDGFK GCCJEBKFANJ, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool NIGMNNCLHBC(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void IBNHLCPADKO(HKCCJJBDGFK GCCJEBKFANJ, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints IABHMKLOJEP(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EGMAGKDNLIM(HKCCJJBDGFK GCCJEBKFANJ, RigidbodyConstraints CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float NFABDIKBCCO(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void POJCLJNMAFH(HKCCJJBDGFK GCCJEBKFANJ, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float PFEMHAIBMEI(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void MBMPBDBHEJK(HKCCJJBDGFK GCCJEBKFANJ, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool JNKKOGBOGIC(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void JANCPFMPOLL(HKCCJJBDGFK GCCJEBKFANJ, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool KNABIJFHPEP(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void DMFGKMJLBLD(HKCCJJBDGFK GCCJEBKFANJ, bool CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int HBHEDKNACPI(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void KFJMABPKCGC(HKCCJJBDGFK GCCJEBKFANJ, int CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object GBHCEALELGO(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void DFFBKOEKMFN(HKCCJJBDGFK GCCJEBKFANJ, object CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object GCBKAKCDOND(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void PMHFINHAGFD(HKCCJJBDGFK GCCJEBKFANJ, object CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float KHGCAKGPNNO(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IPOMEKCHAEE(HKCCJJBDGFK GCCJEBKFANJ, float CKDFGEALFAK);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void GOJCMMJFHKI(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void JMGCFJMAHDN(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool OCFMKDFOMFF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void GCAJFLPPGOM(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void BBIABNBAKFI(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool DPPNCCHPPPM(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool FLDICHCKLOE(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Rigidbody NMFOAAKJFMK(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void CAFOFIKLINA(HKCCJJBDGFK GCCJEBKFANJ, Rigidbody CIEJBNMPJKE);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void PKCJDHEHHKF(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void MNPDLAIMCKF(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool NAONGGHPIME(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void FCHIOGBJDOK(HKCCJJBDGFK GCCJEBKFANJ, float3 DIGLJLOIALF);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void FCKDIPIMHKE(HKCCJJBDGFK GCCJEBKFANJ, float3 BFOCKHBKDDG);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "79")]
	bool NFLAGEKHNNL(HKCCJJBDGFK GCCJEBKFANJ, out float3 DIGLJLOIALF);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool HPCAACJGFFA(HKCCJJBDGFK GCCJEBKFANJ, out float3 BFOCKHBKDDG);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool HBNNMGOPLDN(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void GBLELKIIBMG(HKCCJJBDGFK GCCJEBKFANJ, object FFKJLIDBALM, bool JODHJMHBHKG);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void AKCAADCCFNN(HKCCJJBDGFK GCCJEBKFANJ, bool CEHOGFBNEEA);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void EPDMJEDNADM(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "85")]
	bool OOFHHBPJKBN(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "86")]
	IEnumerable<object> OLJJDHOJIDK(HKCCJJBDGFK GCCJEBKFANJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface GMHKDFACCNG
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KCABCDFKPFI(Entity FOJBJELKLPO);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void AJMGNCJFOKI(Entity FOJBJELKLPO);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct LKFJEDJKILN : IEquatable<LKFJEDJKILN>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly LKFJEDJKILN CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string NLMFJPMHDOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5934370", Offset = "0x5933370", VA = "0x185934370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string ODCIDJFBJED
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x59346B0", Offset = "0x59336B0", VA = "0x1859346B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public LKFJEDJKILN(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x59345B0", Offset = "0x59335B0", VA = "0x1859345B0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(LKFJEDJKILN BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct LLHDMDGNGGM : IEquatable<LLHDMDGNGGM>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly LLHDMDGNGGM CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x59347A0", Offset = "0x59337A0", VA = "0x1859347A0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(LLHDMDGNGGM BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct GIPHCKBICHE : IEquatable<GIPHCKBICHE>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GIPHCKBICHE CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private KHKFHCKLIFN KIFFNAOPFIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x592EF10", Offset = "0x592DF10", VA = "0x18592EF10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool JDNKNHCAMJM
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x592F100", Offset = "0x592E100", VA = "0x18592F100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool DMEPLOLFJJD
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x592E500", Offset = "0x592D500", VA = "0x18592E500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool DBMMMOHEINN
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x592E8B0", Offset = "0x592D8B0", VA = "0x18592E8B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool NBPKPHLMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x592EAA0", Offset = "0x592DAA0", VA = "0x18592EAA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool BCMEBCEFOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x592E7C0", Offset = "0x592D7C0", VA = "0x18592E7C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool MGGDKILBLAD
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x592EAE0", Offset = "0x592DAE0", VA = "0x18592EAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool MJBJHAPDBMD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x592ECD0", Offset = "0x592DCD0", VA = "0x18592ECD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x592E770", Offset = "0x592D770", VA = "0x18592E770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x592E740", Offset = "0x592D740", VA = "0x18592E740")]
	public bool FHDPLNEEDFG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x592EFA0", Offset = "0x592DFA0", VA = "0x18592EFA0")]
	public PJGCHGOPADA NINHPINPCLP(PJGCHGOPADA FBOMMBLFPCD)
	{
		return default(PJGCHGOPADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x592E8E0", Offset = "0x592D8E0", VA = "0x18592E8E0")]
	public HKCCJJBDGFK IKBANGEOKBH()
	{
		return default(HKCCJJBDGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public GIPHCKBICHE(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(GIPHCKBICHE CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x592E640", Offset = "0x592D640", VA = "0x18592E640", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(GIPHCKBICHE BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct BIAGKPENIJP : IComparable<BIAGKPENIJP>, IEquatable<BIAGKPENIJP>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly BIAGKPENIJP JJICOGFFINC;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly BIAGKPENIJP ADIANJJFIHF;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly BIAGKPENIJP HNLNIKHBGLH;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly BIAGKPENIJP NKNKFJOAEEC;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly BIAGKPENIJP EMPOIFKMPDN;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly BIAGKPENIJP PLCELMOLJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int EODOJNLPHFB;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool CHHDAFBHLDA
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x592B760", Offset = "0x592A760", VA = "0x18592B760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int AFGKFFKLLIE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x592B750", Offset = "0x592A750", VA = "0x18592B750")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0x86DD20", Offset = "0x86CD20", VA = "0x18086DD20")]
	public BIAGKPENIJP(int CCELBNKPBGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x592B6E0", Offset = "0x592A6E0", VA = "0x18592B6E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x592B650", Offset = "0x592A650", VA = "0x18592B650", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3F235E0", Offset = "0x3F225E0", VA = "0x183F235E0", Slot = "5")]
	public bool Equals(BIAGKPENIJP BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x592B640", Offset = "0x592A640", VA = "0x18592B640", Slot = "4")]
	public int CompareTo(BIAGKPENIJP BKLMLPFOMCO)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x16A7940", Offset = "0x16A6940", VA = "0x1816A7940")]
	public static BIAGKPENIJP MGOLCJODLKK(int CCELBNKPBGB)
	{
		return default(BIAGKPENIJP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x16A7940", Offset = "0x16A6940", VA = "0x1816A7940")]
	public static int MGOLCJODLKK(BIAGKPENIJP FLPMFIPOIDE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x592B770", Offset = "0x592A770", VA = "0x18592B770", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
[DefaultMember("Item")]
public interface EPEJBPGEENE : IEnumerable<CHIMAECAGEC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	CHIMAECAGEC CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CHIMAECAGEC PMEBAGCJFNJ(NOJOLKBLHAF GOOBHDEKEHB);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BIAGKPENIJP FNODLIPJFPF(NOJOLKBLHAF GOOBHDEKEHB);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class HCEKECJMILK
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	public static PBDFKCOAAOA<T> PMEBAGCJFNJ<T>(this EPEJBPGEENE GHDMEKEFFPC, NOJOLKBLHAF OALFIBFPPAC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x26E3690", Offset = "0x26E2690", VA = "0x1826E3690")]
	public static BIAGKPENIJP FNODLIPJFPF<T>(this EPEJBPGEENE GHDMEKEFFPC, MOHEIECGODL<T> OALFIBFPPAC) where T : struct
	{
		return default(BIAGKPENIJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface FKNGADMNJMN
{
	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EMPJNAHHFBL(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool DCMGEHINAJO(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IGEAJJCAIBK(HKCCJJBDGFK GCCJEBKFANJ, out Guid CIPOMGPCAOA);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid HIMPOILBNJL(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JECLOOIFCOE(HKCCJJBDGFK GCCJEBKFANJ, Guid CIPOMGPCAOA);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool IKMHCOOJAID(HKCCJJBDGFK GCCJEBKFANJ, out Guid LILJFFJEADL);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid CLFEKGPHGNA(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void GOBFMFHDBKF(HKCCJJBDGFK GCCJEBKFANJ, Guid LILJFFJEADL);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AFHJMPFDMEF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LIHKPJFGDAA(HKCCJJBDGFK IGJGLIJGINK, HKCCJJBDGFK DJAGPEDCGHG);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface FDFEJBJJBEF
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DDFHNIGCPDD(HKCCJJBDGFK IFPLGBGLLJH, bool CKDFGEALFAK);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct LIIHIMDMKKD : IEquatable<LIIHIMDMKKD>
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly LIIHIMDMKKD CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public KAMOJIBKOIC KOFNGFFEECL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(KAMOJIBKOIC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private GBOKOPFIKHH AHFHEEBJBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x5934270", Offset = "0x5933270", VA = "0x185934270")]
		get
		{
			return default(GBOKOPFIKHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public LAHOJAAPJMH GDJODEIMNPF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x59342D0", Offset = "0x59332D0", VA = "0x1859342D0")]
		get
		{
			return default(LAHOJAAPJMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public LIIHIMDMKKD(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(LIIHIMDMKKD CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x5934170", Offset = "0x5933170", VA = "0x185934170", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(LIIHIMDMKKD BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface EELAENKBJHK
{
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CMLIKPGGHLO(HKCCJJBDGFK GCCJEBKFANJ, KPHJIOHBDJC HODOGKAIIHL, bool CEKHLGEIGKA, DPJFBCAIHMI OOHDBINLHDP);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PCKJOHNCDAJ(HKCCJJBDGFK GCCJEBKFANJ, KPHJIOHBDJC HODOGKAIIHL, bool CEKHLGEIGKA, bool ICPAGGGLIAI, bool POMOICCLOBF);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BDNMGKIBAPH PMPPANJODOE(HKCCJJBDGFK EMIPEAKIENF, List<HKCCJJBDGFK> HPIILNJPPGH);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GALIFDCAMHI(GameObject OJBBABHEMEF, GameObject NLHFONMFNKI);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FEPEAKIAHEH(GameObject NLHFONMFNKI);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T GHEHJAAPBOD<T>(GameObject OIDMMAFNAAP) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OJKLBAMNKOC(Collider NLCHDIPHMDC);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject IPDPNLGNMJG<T>(string OALFIBFPPAC) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface ACPFCEKOGLG
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	IReadOnlyCollection<BGPBFEOPJNE> KGEEPIBBLLP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HFLIOFKCOEF(int EELINDLPCIF, out BGPBFEOPJNE APPNACOIPAC);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	BGPBFEOPJNE EOKGPEJJIHF(Type DPPJBLOOGOO);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class NEFFOGCNNPA
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x251BF40", Offset = "0x251AF40", VA = "0x18251BF40")]
	public static T BPACPINDECF<T>(this ACPFCEKOGLG GBNDFPOOELE, Entity NNCCHIHKALO) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x251BFE0", Offset = "0x251AFE0", VA = "0x18251BFE0")]
	public static BGPBFEOPJNE EOKGPEJJIHF<T>(this ACPFCEKOGLG GBNDFPOOELE) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface JBMJFCDEJPH
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	bool IHDFKNGPKBE
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface GKPMODDJLEC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool GMAHKGJPGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool OOBIHFIABAN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	IOPNMHJANJP PNMHLHGHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CKMMILDFOAB IMNNKPKBHDF(bool MBKJGALNPLM = false);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CKMMILDFOAB OHGCEBNJJNI(IEnumerable<HKCCJJBDGFK> GNDGEICPCIH, in IGBEKJAGCDH EEFAFMBEIEH);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	OOKMDMHNPCJ OAFPNNOPDDK(ByteString PEDIDIDGLGD);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GDNFJPNKCHJ AKHCJJNMFHM(ByteString PDFBAGGMCIA, HKCCJJBDGFK DJAGPEDCGHG, in IGBEKJAGCDH MPOMEDNAFHC, LDIKHHIMIKG LMLBPFKNNMP, bool CHIOJNILGCA = true);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JHBFNHFIAOP();

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KMKFNCIPMCD(bool GKLELIAODHF);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	NOIBFAALGKM JBNLKJAJLPC(IEnumerable<DOLKOKMDPNJ> NLMKNHGINNB);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class OOJABAPLINC
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface EOPNAJANINM : JIHCIGODEBM, CMKCAGGCPGO, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	bool EDGMLIFNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	CKMDELMCLGG KHHBGBCKNAF
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	BJACPPDDPHJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	LBPGENCFGGJ DFHGODNKMPK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface CMKCAGGCPGO
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool OAEPAJFJIBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface PKBDEOIKGBM
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool EEBEPOEOKAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface CDOAKKJKHLJ
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	Guid IHPBKDBPOCE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLJFELLKLFG(Guid CIPOMGPCAOA, Guid LILJFFJEADL, string OALFIBFPPAC);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct BOEJDHDNDLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal int FCCAKNLHEPE;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x592BB00", Offset = "0x592AB00", VA = "0x18592BB00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class DFKIKNEENMI
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private struct ELFNEBJGKCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Guid PLBICILNGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public JDGABNJMCHP HFDIFIKDLDC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct JDGABNJMCHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CKDFGEALFAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int CNAINFCHKJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int NLEKNGHNLHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int EPJPOPHDBBP;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x5930A90", Offset = "0x592FA90", VA = "0x185930A90")]
		public bool KOEAGEDEFPM(out MFPJNGLDGLN KHIMPMGAFHG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5930B30", Offset = "0x592FB30", VA = "0x185930B30")]
		public JDGABNJMCHP(MFPJNGLDGLN KHIMPMGAFHG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x592C040", Offset = "0x592B040", VA = "0x18592C040")]
	public static Guid CNGGBNNIHHC(this MFPJNGLDGLN KHIMPMGAFHG)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x592C0E0", Offset = "0x592B0E0", VA = "0x18592C0E0")]
	public static bool GFKDNMOHBCN(this Guid PLBICILNGEB, out MFPJNGLDGLN KHIMPMGAFHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DebuggerTypeProxy(typeof(CIHJPJOHCKK))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct HKCCJJBDGFK : IComparable<HKCCJJBDGFK>, IEquatable<HKCCJJBDGFK>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly HKCCJJBDGFK JJICOGFFINC;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public LocalId CPAMJAPPNLN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0xABC950", Offset = "0xABB950", VA = "0x180ABC950")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool EKIJMHGPMDN
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x59303E0", Offset = "0x592F3E0", VA = "0x1859303E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool BHCAHHHFBIA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x59305B0", Offset = "0x592F5B0", VA = "0x1859305B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool NOOBMLCFLDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x59302B0", Offset = "0x592F2B0", VA = "0x1859302B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x59306D0", Offset = "0x592F6D0", VA = "0x1859306D0")]
	public HKCCJJBDGFK(ALIKBOGGKHP IBKCENLLOOD, LocalId GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
	public PJGCHGOPADA KEIHNOGALDC()
	{
		return default(PJGCHGOPADA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0xABC950", Offset = "0xABB950", VA = "0x180ABC950")]
	public static LocalId MGOLCJODLKK(HKCCJJBDGFK ICBIKNJGOGL)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x59305A0", Offset = "0x592F5A0", VA = "0x1859305A0")]
	public static Entity MGOLCJODLKK(HKCCJJBDGFK ICBIKNJGOGL)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x5930550", Offset = "0x592F550", VA = "0x185930550")]
	public static bool LFCPNLBCIDE(HKCCJJBDGFK LFEMLKHNBHE, HKCCJJBDGFK CNOAFMMFDKH)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x59304B0", Offset = "0x592F4B0", VA = "0x1859304B0")]
	public static bool JIPCNIGMDBL(HKCCJJBDGFK LFEMLKHNBHE, HKCCJJBDGFK CNOAFMMFDKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x59305D0", Offset = "0x592F5D0", VA = "0x1859305D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x5930330", Offset = "0x592F330", VA = "0x185930330", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x59302D0", Offset = "0x592F2D0", VA = "0x1859302D0", Slot = "4")]
	public int CompareTo(HKCCJJBDGFK BKLMLPFOMCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "5")]
	public bool Equals(HKCCJJBDGFK BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class PAPFJELIFIG
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5936250", Offset = "0x5935250", VA = "0x185936250")]
	public static MFPJNGLDGLN BGCEIBFDHDK(this HKCCJJBDGFK EOHGDDIECBJ)
	{
		return default(MFPJNGLDGLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x2922BF0", Offset = "0x2921BF0", VA = "0x182922BF0")]
	public static T FADIFIFAMIO<T>(this HKCCJJBDGFK EOHGDDIECBJ) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class CIHJPJOHCKK
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface JLFGDFIPKNO
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool EDGMLIFNIMM
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OLCKFEJDPHL(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void NLOLDIMNGNF(HKCCJJBDGFK GCCJEBKFANJ, bool CEKHLGEIGKA, bool ICPAGGGLIAI, bool PKBHDOPFEGO);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct EGBHOCHMGFB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly FNOEBANGBJI JPPJEDHGAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NativeArray<byte> BEKGPJHMFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NativeArray<byte> HEIIEHCMKIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly BIAGKPENIJP FLPMFIPOIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly int BOALECIMDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Type EANPKMOFBHH;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public FNOEBANGBJI AHPIIDKPELP
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x12EC1E0", Offset = "0x12EB1E0", VA = "0x1812EC1E0")]
		get
		{
			return default(FNOEBANGBJI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x592D980", Offset = "0x592C980", VA = "0x18592D980")]
	public EGBHOCHMGFB(FNOEBANGBJI JPPJEDHGAOJ, NativeArray<byte> BEKGPJHMFFJ, NativeArray<byte> HEIIEHCMKIE, BIAGKPENIJP FLPMFIPOIDE, int BOALECIMDHP, Type EANPKMOFBHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAEA0", Offset = "0x1FF9EA0", VA = "0x181FFAEA0")]
	public NativeArray<T> BFFOAPANHHJ<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAEE0", Offset = "0x1FF9EE0", VA = "0x181FFAEE0")]
	public NativeArray<T> EKAIDHHBOEE<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x1FFAF20", Offset = "0x1FF9F20", VA = "0x181FFAF20")]
	public (FNOEBANGBJI, NativeArray<T>, NativeArray<T>) FLFDNJDANPO<T>() where T : struct
	{
		return default((FNOEBANGBJI, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x592D8E0", Offset = "0x592C8E0", VA = "0x18592D8E0")]
	public AHCCAGDEAPD EEGLBJAOPBK()
	{
		return default(AHCCAGDEAPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct NAPHIDDMJED : IEquatable<NAPHIDDMJED>
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly NAPHIDDMJED CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5934F40", Offset = "0x5933F40", VA = "0x185934F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5934F90", Offset = "0x5933F90", VA = "0x185934F90")]
	public void GJKCBEKDPGB(bool CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x59350D0", Offset = "0x59340D0", VA = "0x1859350D0")]
	public void KABMPMFBHGB(bool CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2D5DB40", Offset = "0x2D5CB40", VA = "0x182D5DB40")]
	public T EOOKPBMFIPE<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public NAPHIDDMJED(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5934E40", Offset = "0x5933E40", VA = "0x185934E40", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(NAPHIDDMJED BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct NLPECFEBJBH : IEquatable<NLPECFEBJBH>
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly NLPECFEBJBH CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x59354C0", Offset = "0x59344C0", VA = "0x1859354C0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(NLPECFEBJBH BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface KHKFNAPOFIH
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	CEJACMPBFFI DIACNBBBCHF
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	CEJACMPBFFI KMMGPKAIJCE
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	CEJACMPBFFI ENIJEBFJHBA
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	CEJACMPBFFI MGOGGFOLABG
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	CEJACMPBFFI OKGJLEEBFAD
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	CEJACMPBFFI KOPEHOHKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	CEJACMPBFFI NMBDAKKOBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct KJHMLBOAHKA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float JCGCOMMMLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 CHHELNLAGNA;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct KAMOJIBKOIC : IEquatable<KAMOJIBKOIC>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly KAMOJIBKOIC CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private IDKKBNHMKMH GMENPHEIOEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x59321F0", Offset = "0x59311F0", VA = "0x1859321F0")]
		get
		{
			return default(IDKKBNHMKMH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public FHCBGMMJAEN MDHNKNCKIID
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x5932250", Offset = "0x5931250", VA = "0x185932250")]
		get
		{
			return default(FHCBGMMJAEN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public OLFLAJLOHDM GMOGDDPGLHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5932190", Offset = "0x5931190", VA = "0x185932190")]
		get
		{
			return default(OLFLAJLOHDM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public IMMOLEJGBBK CFBAOKEEDMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5931FC0", Offset = "0x5930FC0", VA = "0x185931FC0")]
		get
		{
			return default(IMMOLEJGBBK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public FMAGCHDBGLG HPLAFMKOGEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x5931DF0", Offset = "0x5930DF0", VA = "0x185931DF0")]
		get
		{
			return default(FMAGCHDBGLG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public PKFAMLPGILK MKGELMCJLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5931C20", Offset = "0x5930C20", VA = "0x185931C20")]
		get
		{
			return default(PKFAMLPGILK);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5931AB0", Offset = "0x5930AB0", VA = "0x185931AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public OLLMGFCLHHL AHDGBCJMKCL
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x59319E0", Offset = "0x59309E0", VA = "0x1859319E0")]
		get
		{
			return default(OLLMGFCLHHL);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x5931E70", Offset = "0x5930E70", VA = "0x185931E70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float KOHJKJGAAFO
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x5931C80", Offset = "0x5930C80", VA = "0x185931C80")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x5931EE0", Offset = "0x5930EE0", VA = "0x185931EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 BMIBEPLBFNC
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5932100", Offset = "0x5931100", VA = "0x185932100")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5931D60", Offset = "0x5930D60", VA = "0x185931D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float DPKGDGDIKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x5931CE0", Offset = "0x5930CE0", VA = "0x185931CE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public KAGIPCJHPEK.OGKPIGAAIFB BPDPAACLEKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x5931F60", Offset = "0x5930F60", VA = "0x185931F60")]
		get
		{
			return default(KAGIPCJHPEK.OGKPIGAAIFB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x5931A40", Offset = "0x5930A40", VA = "0x185931A40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public ALEALLIJCOB CBKKOJLNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(ALEALLIJCOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5932020", Offset = "0x5931020", VA = "0x185932020")]
	public LIIHIMDMKKD MLGOGELHOON()
	{
		return default(LIIHIMDMKKD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5932090", Offset = "0x5931090", VA = "0x185932090")]
	public HIBJKCBPJNI MOLHCMCIEGG()
	{
		return default(HIBJKCBPJNI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public KAMOJIBKOIC(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x592EF90", Offset = "0x592DF90", VA = "0x18592EF90")]
	public static bool MGOLCJODLKK(KAMOJIBKOIC CKDFGEALFAK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5931B20", Offset = "0x5930B20", VA = "0x185931B20", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(KAMOJIBKOIC BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface IBEOMPOCGOE
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	CNIJJDNAGNG KHHBGBCKNAF
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	BJACPPDDPHJ EEJDILCKJBP
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	MEMGGFMPMAP GGCAKJHLHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	CKOPNBJHGFM NJDJFHLCGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	MDBBGNDLFDI PCLIEKMANOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	GKPMODDJLEC NDLBJJOBPDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	IIHCMGCOJKE GAGOECCDCLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	LEADLEEBGNN KIFPOLKMNNN
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	KHKFHCKLIFN JIAKFCGKKBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	NKMOKJNBEPM KOPEHOHKIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	FDFEJBJJBEF DFJJDLBPADH
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	FENIICLKHIC LLEFOLAKBLD
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	FKNGADMNJMN LLHECMLPEON
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	FBHDDOLDKFD CGHOPPKNKKO
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	HIOAPONHMCI FADMHIJMBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	KHKFNAPOFIH NANLANDCCBA
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	ACPFCEKOGLG AJOJOOFFBEM
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface IMCDACJEDHF
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	object KGNBHOOGABN
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKIEHKEEAMK(FNOEBANGBJI GNDGEICPCIH);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface CKOPNBJHGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HKCCJJBDGFK GCMNHECACAG(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKCCJJBDGFK FGBAEAHBLGF(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PELENMOAPPI(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK DJAGPEDCGHG, bool MPGELPMHFGK);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool HFOCGGAAKPH(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK DJAGPEDCGHG);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int DMPPJJGMJFB(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "5")]
	FNOEBANGBJI LMBBFOFNAED(HKCCJJBDGFK IFPLGBGLLJH);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool MADLPBFCAEH(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK PHBIIOKBBDE);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MBDAIJNGFEJ(HKCCJJBDGFK GCCJEBKFANJ, HKCCJJBDGFK MCABOIDDKCM);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HKCCJJBDGFK FNPCAGNCLND(HKCCJJBDGFK PHBIIOKBBDE, HKCCJJBDGFK PMDBMIDOLEP);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AHFGMJPIGDF(HKCCJJBDGFK PHBIIOKBBDE, HKCCJJBDGFK PMDBMIDOLEP, out HKCCJJBDGFK BIDJJIMHMGM);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class NNIDMEEPCFN
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x5935600", Offset = "0x5934600", VA = "0x185935600")]
	public static bool KHGGKLLFNPE(this CKOPNBJHGFM HCFNBNNCCMB, HKCCJJBDGFK GCCJEBKFANJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum AIMMDJHMCMP
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
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface IIHCMGCOJKE
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<HKCCJJBDGFK> DOOFEDKFNAM(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HKCCJJBDGFK MGFONBJKFPP(HKCCJJBDGFK GCCJEBKFANJ, int CCELBNKPBGB);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int HFINDFGKHCC(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JONKBLJBIMD BBOJKBFHDJO(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PNJMJGHOEHC(HKCCJJBDGFK GCCJEBKFANJ, JONKBLJBIMD BPFIFAEKGCN);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HKCCJJBDGFK HAAMKHCJFHI(HKCCJJBDGFK GCCJEBKFANJ, [Optional] float3? NKMKMKDMOMJ, [Optional] quaternion? NMKLOHCPMNL, [Optional] float3? KFEAJPAHNFK);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HKCCJJBDGFK AGABHGEDGBB(HKCCJJBDGFK GCCJEBKFANJ, int CCELBNKPBGB, [Optional] float3? NKMKMKDMOMJ, [Optional] quaternion? NMKLOHCPMNL, [Optional] float3? KFEAJPAHNFK);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NADGAMGPNOM(HKCCJJBDGFK GCCJEBKFANJ, int CCELBNKPBGB);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OPAHIOGFHOK(HKCCJJBDGFK GCCJEBKFANJ);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface DKJKIFABJEK
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOOCGMPOKEO(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OANDAHALPCA(HKCCJJBDGFK GCCJEBKFANJ, Transform IJKOODCAMMG);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface AGIFDGDMJIF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	LocalId BGOJCKNLFIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	LocalId ODCEKFBFMEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000379")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600037A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FGKLJDHAKFM(float3 EHELKFGJCKP);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CMGLBMOGOBG(float3 EHELKFGJCKP);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PANOADCHHHG(out float3 NKCNADFHDPD, out float3 AOJGCGDGNAM);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void NFDFEHDPJAA(float3 NKCNADFHDPD, float3 AOJGCGDGNAM);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void NNBDHKEENIE(Color NKCNADFHDPD, Color AOJGCGDGNAM);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	AGIFDGDMJIF Instantiate(Transform IJKOODCAMMG);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface JGIONPFHOHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LLEBBJIFEDK(Transform IJKOODCAMMG, AGIFDGDMJIF BMCMLBLJFDF);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AGIFDGDMJIF BKLDGLKOJNG();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct CFECOGPFOFC : IEquatable<CFECOGPFOFC>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly CFECOGPFOFC CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private GNENPHMDELO NNMHLMEHBAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x592BCC0", Offset = "0x592ACC0", VA = "0x18592BCC0")]
		get
		{
			return default(GNENPHMDELO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public GDAKNOMINHC LCPIIKINGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x592BC60", Offset = "0x592AC60", VA = "0x18592BC60")]
		get
		{
			return default(GDAKNOMINHC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x592BD20", Offset = "0x592AD20", VA = "0x18592BD20")]
	public EJBOBFBHFDI JMMDGBGPHNP()
	{
		return default(EJBOBFBHFDI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public CFECOGPFOFC(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x592BB60", Offset = "0x592AB60", VA = "0x18592BB60", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(CFECOGPFOFC BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct LFGCHIGKMCE : IEquatable<LFGCHIGKMCE>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly LFGCHIGKMCE CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5934030", Offset = "0x5933030", VA = "0x185934030", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(LFGCHIGKMCE BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct JLEAJPBEDFA : IEquatable<JLEAJPBEDFA>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly JLEAJPBEDFA CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public JLEAJPBEDFA(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x5931770", Offset = "0x5930770", VA = "0x185931770", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(JLEAJPBEDFA BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x5931870", Offset = "0x5930870", VA = "0x185931870")]
	public bool GMOINLDOJIJ(out Collider NLCHDIPHMDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct PDLJFDBJILI : IEquatable<PDLJFDBJILI>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly PDLJFDBJILI CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public HKCCJJBDGFK OKJPNNBMBFD
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0xE5A200", Offset = "0xE59200", VA = "0x180E5A200")]
		get
		{
			return default(HKCCJJBDGFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public HIBJKCBPJNI NLAODDMLHFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5936860", Offset = "0x5935860", VA = "0x185936860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public float3 MHKFHAGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5936340", Offset = "0x5935340", VA = "0x185936340")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x59367D0", Offset = "0x59357D0", VA = "0x1859367D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public quaternion PPGNDJFMMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5936980", Offset = "0x5935980", VA = "0x185936980")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5936660", Offset = "0x5935660", VA = "0x185936660")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float3 EOIFGDPDAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5936740", Offset = "0x5935740", VA = "0x185936740")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5936AC0", Offset = "0x5935AC0", VA = "0x185936AC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public EFOFPEOLGLH FNFKNDKFNEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5936590", Offset = "0x5935590", VA = "0x185936590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private JJCACPKAMCP MGNIALFMMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x5936A00", Offset = "0x5935A00", VA = "0x185936A00")]
		get
		{
			return default(JJCACPKAMCP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private NAFKENECKHA NPFGEAIBLLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x59366E0", Offset = "0x59356E0", VA = "0x1859366E0")]
		get
		{
			return default(NAFKENECKHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private KOELOIJLBKP AJGMHNDIJMD
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5936920", Offset = "0x5935920", VA = "0x185936920")]
		get
		{
			return default(KOELOIJLBKP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private DNPOOLGNELC OHEPPAFECKA
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5936A60", Offset = "0x5935A60", VA = "0x185936A60")]
		get
		{
			return default(DNPOOLGNELC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private GMGEEOABDBB LEJKFCDGBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5936600", Offset = "0x5935600", VA = "0x185936600")]
		get
		{
			return default(GMGEEOABDBB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public PDLJFDBJILI(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x59363D0", Offset = "0x59353D0", VA = "0x1859363D0", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(PDLJFDBJILI BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x59364D0", Offset = "0x59354D0", VA = "0x1859364D0")]
	public void FBHLIJNJHEG(HIBJKCBPJNI CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x59367D0", Offset = "0x59357D0", VA = "0x1859367D0")]
	public void PMGOPHBLPKK(float3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5936660", Offset = "0x5935660", VA = "0x185936660")]
	public void NDEIAIEFPAK(quaternion CKDFGEALFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct ALEALLIJCOB : IEquatable<ALEALLIJCOB>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly ALEALLIJCOB CLLNJPDPMPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly HKCCJJBDGFK IFPLGBGLLJH;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public PJGCHGOPADA LBOKNIDGHAB
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5926A40", Offset = "0x5925A40", VA = "0x185926A40")]
		get
		{
			return default(PJGCHGOPADA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private ALIKBOGGKHP EOLACNDBEMN
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x85E000", Offset = "0x85D000", VA = "0x18085E000")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private MDBBGNDLFDI CPOMIFCLMDP
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x59298D0", Offset = "0x59288D0", VA = "0x1859298D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool JCCDLOAGKLA
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x59284D0", Offset = "0x59274D0", VA = "0x1859284D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 MHKFHAGBNLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x59287F0", Offset = "0x59277F0", VA = "0x1859287F0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x59292C0", Offset = "0x59282C0", VA = "0x1859292C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Quaternion PPGNDJFMMIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x5929FB0", Offset = "0x5928FB0", VA = "0x185929FB0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x5928CC0", Offset = "0x5927CC0", VA = "0x185928CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Vector3 OKHAADJKIKP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5927FB0", Offset = "0x5926FB0", VA = "0x185927FB0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x5928520", Offset = "0x5927520", VA = "0x185928520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion IEIHNFGKHEA
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5929940", Offset = "0x5928940", VA = "0x185929940")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5927CB0", Offset = "0x5926CB0", VA = "0x185927CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public float NODLEALDIEG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x59297D0", Offset = "0x59287D0", VA = "0x1859297D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5929DA0", Offset = "0x5928DA0", VA = "0x185929DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public float EOEDBEBJIAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x592A520", Offset = "0x5929520", VA = "0x18592A520")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Vector3 EOIFGDPDAIB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5928FD0", Offset = "0x5927FD0", VA = "0x185928FD0")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x592A900", Offset = "0x5929900", VA = "0x18592A900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Vector3 EADCFCGPOFO
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5928B80", Offset = "0x5927B80", VA = "0x185928B80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Vector3 PBKGFABPLJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x592A3D0", Offset = "0x59293D0", VA = "0x18592A3D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Matrix4x4 MOFOLNHNBKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5927DF0", Offset = "0x5926DF0", VA = "0x185927DF0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0xBFDC30", Offset = "0xBFCC30", VA = "0x180BFDC30")]
	public ALEALLIJCOB(HKCCJJBDGFK GCCJEBKFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x1E766E0", Offset = "0x1E756E0", VA = "0x181E766E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x5928A80", Offset = "0x5927A80", VA = "0x185928A80", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x59269A0", Offset = "0x59259A0", VA = "0x1859269A0", Slot = "4")]
	public bool Equals(ALEALLIJCOB BKLMLPFOMCO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5926A60", Offset = "0x5925A60", VA = "0x185926A60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5927860", Offset = "0x5926860", VA = "0x185927860")]
	public ACILLLOIMMI AGGGPCACHOD()
	{
		return default(ACILLLOIMMI);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x5928660", Offset = "0x5927660", VA = "0x185928660")]
	public void ELDKCJILJLO(out Matrix4x4 APCKKDGJBIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5928E00", Offset = "0x5927E00", VA = "0x185928E00")]
	public void GLFKGHMIGDL(out Vector3 PNLIFGHANBA, out Quaternion KOGAOAEOKAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x59296C0", Offset = "0x59286C0", VA = "0x1859296C0")]
	public void JLOOCHMKJAO(out RigidTransform MNHEIFKMCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5929D50", Offset = "0x5928D50", VA = "0x185929D50")]
	public IGBEKJAGCDH KMNLIDKBDPD()
	{
		return default(IGBEKJAGCDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5929C30", Offset = "0x5928C30", VA = "0x185929C30")]
	public void KMNLIDKBDPD(out IGBEKJAGCDH NGOIKLLIBBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x5929670", Offset = "0x5928670", VA = "0x185929670")]
	public IGBEKJAGCDH JAEMFFOPIGD()
	{
		return default(IGBEKJAGCDH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x5929550", Offset = "0x5928550", VA = "0x185929550")]
	public void JAEMFFOPIGD(out IGBEKJAGCDH MNHEIFKMCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5927B60", Offset = "0x5926B60", VA = "0x185927B60")]
	public Vector3 BCLCJPKFLDD()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x592A7C0", Offset = "0x59297C0", VA = "0x18592A7C0")]
	public void PMGOPHBLPKK(in Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x5928240", Offset = "0x5927240", VA = "0x185928240")]
	public Vector3 DHNOOPJGMAH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5928940", Offset = "0x5927940", VA = "0x185928940")]
	public void EPNKLEHOOHN(in Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x592A620", Offset = "0x5929620", VA = "0x18592A620")]
	public Quaternion PDHEIHEDEAC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x592A290", Offset = "0x5929290", VA = "0x18592A290")]
	public void NDEIAIEFPAK(in Quaternion CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5929120", Offset = "0x5928120", VA = "0x185929120")]
	public Quaternion IHIGOGKPPGM()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x592A150", Offset = "0x5929150", VA = "0x18592A150")]
	public void MOGJLPLPBMK(in Quaternion CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5927760", Offset = "0x5926760", VA = "0x185927760")]
	public float AFBEFKLDCLJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5927540", Offset = "0x5926540", VA = "0x185927540")]
	public void ADIFOJBBEMO(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5929EB0", Offset = "0x5928EB0", VA = "0x185929EB0")]
	public float MCLHLDBNEAI()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5927650", Offset = "0x5926650", VA = "0x185927650")]
	public void AEDGDIKBDHB(float CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5928100", Offset = "0x5927100", VA = "0x185928100")]
	public void CPAFOMHNJHC(in Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5929AE0", Offset = "0x5928AE0", VA = "0x185929AE0")]
	public Vector3 KEDPKKJFEDK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5928390", Offset = "0x5927390", VA = "0x185928390")]
	public void DMFHJCEEAAI(in Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x59278D0", Offset = "0x59268D0", VA = "0x1859278D0")]
	public Vector3 AJCBELKGCOF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5927E70", Offset = "0x5926E70", VA = "0x185927E70")]
	public void BMFIBCEDILE(in Vector3 CKDFGEALFAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5929400", Offset = "0x5928400", VA = "0x185929400")]
	public Vector3 ILMHCBNNHHH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5927A20", Offset = "0x5926A20", VA = "0x185927A20")]
	public void BBHGBDIAKJH(in Vector3 CKDFGEALFAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface ALIKBOGGKHP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	IBEOMPOCGOE LMEHKEFPBJG
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HCLMPDLDNOB JBMFNDPLPDD(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	ELIGIOKOANN IJENJLIFGCP(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NONEBCMHGNB(MFPJNGLDGLN KHIMPMGAFHG, FOMCNCIAHBP ENJMODLBMLD);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	PJGCHGOPADA FIEMAJLPALC(HKCCJJBDGFK GCCJEBKFANJ, [Optional] object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool PPHOIHCAMKI(HKCCJJBDGFK GCCJEBKFANJ, out FOMCNCIAHBP ENJMODLBMLD);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool EIEALANIFEO(HKCCJJBDGFK GCCJEBKFANJ, out Transform IJKOODCAMMG);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool MKBEIHJJDHK(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OKEGFLMHBJE(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GDPDOIMGHGL(LocalId GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool NGEIMFGILDK(LocalId GCCJEBKFANJ, object FFKJLIDBALM);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HKCCJJBDGFK OCMKLKCLNDH(MFPJNGLDGLN KHIMPMGAFHG);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	MFPJNGLDGLN BGCEIBFDHDK(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	FNOEBANGBJI OCMKLKCLNDH(NativeArray<MFPJNGLDGLN> KHIMPMGAFHG, Allocator HFHMLIPGBBB);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	FNOEBANGBJI KCBNFMBMAIM(NativeArray<MFPJNGLDGLN> KHIMPMGAFHG, NativeArray<DGDJKIAJCJB> IDMNAMLFPII, Allocator HFHMLIPGBBB);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	PJGCHGOPADA ADIANJJFIHF(ELIGIOKOANN LNODCOPPJNC, bool OBIHNKHNEDK);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	PJGCHGOPADA ADIANJJFIHF(ELIGIOKOANN LNODCOPPJNC);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	PJGCHGOPADA CLBCIFPKHBB(ELIGIOKOANN LNODCOPPJNC);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	PJGCHGOPADA LHOAGINAFIG(ELIGIOKOANN LNODCOPPJNC);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	PJGCHGOPADA KCBNFMBMAIM(MFPJNGLDGLN KHIMPMGAFHG, ELIGIOKOANN LNODCOPPJNC);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	LALPDCJDIII LJCEPAKBLLL();

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	HIBJKCBPJNI HGAAFLOCABN();

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	LIIHIMDMKKD JPJFEOKPPON(LAHOJAAPJMH ADILOCMJMIJ);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void EIKHLJNEHLB(FNOEBANGBJI GNDGEICPCIH);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void PCLJFJKFDHP(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void MPPHGIIJCML(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void EIKHLJNEHLB(HKCCJJBDGFK GCCJEBKFANJ);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "27")]
	FNOEBANGBJI JNFMJJDJJJD(FNOEBANGBJI JAADLOCCDHP, Allocator HFHMLIPGBBB);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool EKIJMHGPMDN(HKCCJJBDGFK GCCJEBKFANJ);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class BEEJIPOIHMD
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x592B4E0", Offset = "0x592A4E0", VA = "0x18592B4E0")]
	public static void OKEGFLMHBJE(this ALIKBOGGKHP PKKDNOEMCLN, FOMCNCIAHBP ENJMODLBMLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x592AE40", Offset = "0x5929E40", VA = "0x18592AE40")]
	public static PJGCHGOPADA GIEGJKPILNN(this ALIKBOGGKHP PKKDNOEMCLN, LocalId GCCJEBKFANJ)
	{
		return default(PJGCHGOPADA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x592B4C0", Offset = "0x592A4C0", VA = "0x18592B4C0")]
	public static HKCCJJBDGFK OCMKLKCLNDH(this ALIKBOGGKHP PKKDNOEMCLN, LocalId GCCJEBKFANJ)
	{
		return default(HKCCJJBDGFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x592AA80", Offset = "0x5929A80", VA = "0x18592AA80")]
	public static MFPJNGLDGLN BGCEIBFDHDK(this ALIKBOGGKHP PKKDNOEMCLN, LocalId GCCJEBKFANJ)
	{
		return default(MFPJNGLDGLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x592ABA0", Offset = "0x5929BA0", VA = "0x18592ABA0")]
	public static bool EKIJMHGPMDN(this ALIKBOGGKHP PKKDNOEMCLN, MFPJNGLDGLN KHIMPMGAFHG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x24EAFE0", Offset = "0x24E9FE0", VA = "0x1824EAFE0")]
	public static T FADIFIFAMIO<T>(this ALIKBOGGKHP PKKDNOEMCLN, LocalId GCCJEBKFANJ) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x592B160", Offset = "0x592A160", VA = "0x18592B160")]
	public static LALPDCJDIII LGGNDHFDPEP(this ALIKBOGGKHP PKKDNOEMCLN, RigidTransform NGOIKLLIBBB, [Optional] object FFKJLIDBALM)
	{
		return default(LALPDCJDIII);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x592ACF0", Offset = "0x5929CF0", VA = "0x18592ACF0")]
	public static LIIHIMDMKKD GGOCLGJJFHL(this ALIKBOGGKHP PKKDNOEMCLN, LAHOJAAPJMH KKBIBOEIAMO, RigidTransform NGOIKLLIBBB, [Optional] object FFKJLIDBALM)
	{
		return default(LIIHIMDMKKD);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x592B010", Offset = "0x592A010", VA = "0x18592B010")]
	public static HIBJKCBPJNI LFGPNAPNFBG(this ALIKBOGGKHP PKKDNOEMCLN, RigidTransform NGOIKLLIBBB, [Optional] object FFKJLIDBALM)
	{
		return default(HIBJKCBPJNI);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x592AEF0", Offset = "0x5929EF0", VA = "0x18592AEF0")]
	private static void JCONCDLMBJP(PJGCHGOPADA CBEFFJHOBBJ, RigidTransform NGOIKLLIBBB, [Optional] object FFKJLIDBALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x592B2B0", Offset = "0x592A2B0", VA = "0x18592B2B0")]
	internal static EJBOBFBHFDI NLDMDEPBEOO(this ALIKBOGGKHP PKKDNOEMCLN, AIMPNEMJPJO GBMFMFPFBAA, [Optional] object FFKJLIDBALM)
	{
		return default(EJBOBFBHFDI);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal static class CPEIEHPJCFP
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x592BFF0", Offset = "0x592AFF0", VA = "0x18592BFF0")]
	public static IBEOMPOCGOE LMEHKEFPBJG(this HKCCJJBDGFK IACOMDKJFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x592BEA0", Offset = "0x592AEA0", VA = "0x18592BEA0")]
	public static MEMGGFMPMAP GGCAKJHLHBL(this HKCCJJBDGFK IACOMDKJFAL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x592BF30", Offset = "0x592AF30", VA = "0x18592BF30")]
	public static EntityManager KLDHCJDHBCH(this HKCCJJBDGFK IACOMDKJFAL)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x1BC8320", Offset = "0x1BC7320", VA = "0x181BC8320")]
	public static T EDPGOMNLFPH<T>(this HKCCJJBDGFK IACOMDKJFAL) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x1BC82B0", Offset = "0x1BC72B0", VA = "0x181BC82B0")]
	public static bool COGAOGJHHHB<T>(this HKCCJJBDGFK IACOMDKJFAL) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
internal interface PLNBBOKDMCK
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<AHCCAGDEAPD> MDCAFBGOLHN;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[IFKFPJHCLGF(DLPCPGFNDBP.LoadInstance)]
public interface KHKFHCKLIFN
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	bool MPBGFJAEEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	HKCCJJBDGFK DGBBIJCLPDB
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	PJGCHGOPADA IIAOLPMAIAA
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	PJGCHGOPADA DBOEHGBBJFN
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event NAIIDFGGKGF OPFPOPAGCBL;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	HKCCJJBDGFK FNPCAGNCLND(HKCCJJBDGFK PHBIIOKBBDE, HKCCJJBDGFK PMDBMIDOLEP);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool AHFGMJPIGDF(HKCCJJBDGFK PHBIIOKBBDE, HKCCJJBDGFK PMDBMIDOLEP, out HKCCJJBDGFK BIDJJIMHMGM);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void EIMHCOIFMKO();

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void NBEJAALCMFI();

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool JDNKNHCAMJM(HKCCJJBDGFK FBOMMBLFPCD);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public delegate void NAIIDFGGKGF(PJGCHGOPADA HDGNDEEGOKF, PJGCHGOPADA BNLFJMOFKHD);
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class ONCKGGLKLBF
{
	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x59361C0", Offset = "0x59351C0", VA = "0x1859361C0")]
	public static bool KBMBIBOOGDH(this KHKFHCKLIFN KBFJMLEPDDN, PJGCHGOPADA FBOMMBLFPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x5935E20", Offset = "0x5934E20", VA = "0x185935E20")]
	public static bool FPFKENCGJOB(this KHKFHCKLIFN KBFJMLEPDDN, HKCCJJBDGFK FBOMMBLFPCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x5935D30", Offset = "0x5934D30", VA = "0x185935D30")]
	public static bool BCMEBCEFOLE(this KHKFHCKLIFN KBFJMLEPDDN, HKCCJJBDGFK FBOMMBLFPCD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
[DefaultMember("Item")]
public interface GJCFHGCFPIM : IEnumerable<JMDPFBBINKM>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int NMOEOEAONON
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	JMDPFBBINKM CLDBOBAGHND
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JMDPFBBINKM PMEBAGCJFNJ(NOJOLKBLHAF GOOBHDEKEHB);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BIAGKPENIJP FNODLIPJFPF(NOJOLKBLHAF GOOBHDEKEHB);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class BGALNDOGHKD
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x24EB610", Offset = "0x24EA610", VA = "0x1824EB610")]
	public static MKEFLIMHPIP<T> PMEBAGCJFNJ<T>(this GJCFHGCFPIM GHDMEKEFFPC, NOJOLKBLHAF OALFIBFPPAC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x24EB4C0", Offset = "0x24EA4C0", VA = "0x1824EB4C0")]
	public static MKEFLIMHPIP<T> PMEBAGCJFNJ<T>(this GJCFHGCFPIM GHDMEKEFFPC, MOHEIECGODL<T> OALFIBFPPAC) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x24EB3D0", Offset = "0x24EA3D0", VA = "0x1824EB3D0")]
	public static BIAGKPENIJP FNODLIPJFPF<T>(this GJCFHGCFPIM GHDMEKEFFPC, MOHEIECGODL<T> OALFIBFPPAC) where T : struct
	{
		return default(BIAGKPENIJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface JOCMKOAFBDB : PODFANACJFD
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IPFMOBLPPJK CIKNEAGAOBF(Entity NNCCHIHKALO);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KOJDDJKNCJP(NativeArray<IPFMOBLPPJK> HFNELJFMKHD, NativeArray<OFOJJNONDPF> EFLBJLIBMOH);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GGMGMFLHNON(IPFMOBLPPJK DLOGIKEFHAN);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool KHLFLPOBICJ(IPFMOBLPPJK DLOGIKEFHAN, out Collider NLCHDIPHMDC);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct OFOJJNONDPF : ISystemStateComponentData, IComponentData, IEquatable<OFOJJNONDPF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 EONLMELEKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 PPJDCKANEAI;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x5935CA0", Offset = "0x5934CA0", VA = "0x185935CA0", Slot = "4")]
	public bool Equals(OFOJJNONDPF BKLMLPFOMCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct DOLKOKMDPNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Guid PLBICILNGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public string LIOPPJMKGHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Vector3 NKMKMKDMOMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Quaternion NMKLOHCPMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 KFEAJPAHNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int NPMHJLPKDHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Dictionary<string, object> BPFIFAEKGCN;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x592D5F0", Offset = "0x592C5F0", VA = "0x18592D5F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x592D460", Offset = "0x592C460", VA = "0x18592D460")]
	private static string FONHACDELPF(Dictionary<string, object> CAMKFIDILHM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum IJDEOEHNLFD
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum OEEIPNJKGGK
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class EMEHPAOIHCE
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x3E8A6B0", Offset = "0x3E896B0", VA = "0x183E8A6B0")]
	public static bool AIENJHMOOHC(this OEEIPNJKGGK DPPJBLOOGOO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface OOKMDMHNPCJ : IOPNMHJANJP, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Flags]
public enum DHCLKHENCLL
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
public enum BKDKGKGECMN
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
public interface GDNFJPNKCHJ : IOPNMHJANJP, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	LDIKHHIMIKG AGCJCJNOPHP
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void PLLHAMBOEGA();

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HKOPCHBPMAI();
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface LDIKHHIMIKG
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPAOEMKJCPH(Guid NCAAFEBNDOO, out Guid OOMAONFBFID);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface CKMMILDFOAB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	AHGPLJPFOHI ABPGCCHBDMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString PPKHGPBAOJH();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface IOPNMHJANJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	IEnumerable<DOLKOKMDPNJ> FOLBNLLABNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	NOIBFAALGKM CAALNFBENJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	LocalId BLEIKOCHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	AHGPLJPFOHI AKAMCONIBID
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	Task DLAFAGFCDCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool BCJGKBEDJFF(DHCLKHENCLL DPOGCNGLCPP);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface GJNFBLIOHAB
{
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LEGAONDFFFG(int EELINDLPCIF);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface DDIMHPBCAHL
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	IEnumerable<BDBABGBIICN> FKILFOHNNKA
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool CEKEAMKBIKP(int EELINDLPCIF, out BDBABGBIICN APPNACOIPAC);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface JGLAINNILLA
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	List<(BIJCDGEHGBM nameHash, LAOLEEKHBHH stableTypeHash, Type type)> EPGMNJGPEBK
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[IFKFPJHCLGF(DLPCPGFNDBP.Application)]
public interface PLPPIJNIGIJ
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIJCDGEHGBM DFHCMNMAPGE(int EELINDLPCIF);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AMILACANINO(BIJCDGEHGBM IGKIAIDFLPE);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface AGPGDBBOIBI
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BPJHNBMJAPJ(MFPJNGLDGLN BGIDMNHNIEN, BIAGKPENIJP FLPMFIPOIDE, ReadOnlySpan<byte> BCDHLGODFFO, ReadOnlySpan<byte> DPHGEMPEHHD);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MNJBNALCPOP(MFPJNGLDGLN BGIDMNHNIEN, BIAGKPENIJP FLPMFIPOIDE);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DOJFCPMDEJK(MFPJNGLDGLN BGIDMNHNIEN, BIAGKPENIJP FLPMFIPOIDE, ReadOnlySpan<byte> DPHGEMPEHHD);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BEOEMEJJBMN(MFPJNGLDGLN BGIDMNHNIEN, BIAGKPENIJP FLPMFIPOIDE, Span<byte> BCDHLGODFFO, Span<byte> DPHGEMPEHHD);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class IGPBKJHOFJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x1081F00", Offset = "0x1080F00", VA = "0x181081F00")]
	public static bool BEOEMEJJBMN<T>(this AGPGDBBOIBI KJEHJMEJPGJ, MFPJNGLDGLN BGIDMNHNIEN, BIAGKPENIJP FLPMFIPOIDE, out T BCDHLGODFFO, out T DPHGEMPEHHD) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x10820C0", Offset = "0x10810C0", VA = "0x1810820C0")]
	public static bool DOJFCPMDEJK<T>(this AGPGDBBOIBI KJEHJMEJPGJ, MFPJNGLDGLN BGIDMNHNIEN, BIAGKPENIJP FLPMFIPOIDE, T DPHGEMPEHHD) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public enum NAPFPHBPKFD
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
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface NLCMGDOLLFG : GIGEFNBLEJK<NLCMGDOLLFG>
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	BIAGKPENIJP FNODLIPJFPF(NOJOLKBLHAF OALFIBFPPAC);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NONEBCMHGNB(BIAGKPENIJP IACOMDKJFAL, ENMFMBAEEHL APPNACOIPAC);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OLPFKLCKDPK(BIAGKPENIJP IACOMDKJFAL, out ENMFMBAEEHL APPNACOIPAC);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class EFBIOCPFLEL
{
	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x1FF99A0", Offset = "0x1FF89A0", VA = "0x181FF99A0")]
	public static BIAGKPENIJP FNODLIPJFPF<T>(this NLCMGDOLLFG GHDMEKEFFPC, MOHEIECGODL<T> OALFIBFPPAC)
	{
		return default(BIAGKPENIJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	public static BIAGKPENIJP NONEBCMHGNB<T>(this NLCMGDOLLFG GHDMEKEFFPC, MOHEIECGODL<T> OALFIBFPPAC, ENMFMBAEEHL APPNACOIPAC) where T : struct
	{
		return default(BIAGKPENIJP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface ONCCFFLHMPI
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	uint MNJPMLHEMEH
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct HEEBFDMHGFL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public PGGJKFLCBDA LPNPMOOMCIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public ReadOnlyMemory<byte> EMBONFDCNJA;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface MLDEEKJFNPF
{
	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GGDCOLFHBHJ(PGGJKFLCBDA LPNPMOOMCIB, ReadOnlySpan<byte> EMBONFDCNJA);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate bool JKICKGHBCHO(AGPGDBBOIBI PDOOJIKDKEG, in LEMHKMBLBBH CKDFGEALFAK);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate bool EPGGNLLNEBE<T>(AGPGDBBOIBI PDOOJIKDKEG, in T CKDFGEALFAK);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface MNAPBIKGELI
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NONEBCMHGNB(BIAGKPENIJP FLPMFIPOIDE, Type JMFICAJGDJC, JKICKGHBCHO JKEGALFGPCF);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool AGIAGJDOBBF(BIAGKPENIJP FLPMFIPOIDE, out JKICKGHBCHO JKEGALFGPCF);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class KIONHFINLHH
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class GALFJLNEBLH<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public EPGGNLLNEBE<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0xBDEB80", Offset = "0xBDDB80", VA = "0x180BDEB80")]
		public GALFJLNEBLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x3A83000", Offset = "0x3A82000", VA = "0x183A83000")]
		internal bool BHHNBOKBMBD(AGPGDBBOIBI pendingList, in LEMHKMBLBBH value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2124AE0", Offset = "0x2123AE0", VA = "0x182124AE0")]
	public static void NONEBCMHGNB<T>(this MNAPBIKGELI KNEFBFDLNNH, BIAGKPENIJP FLPMFIPOIDE, EPGGNLLNEBE<T> JKEGALFGPCF) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x59322F0", Offset = "0x59312F0", VA = "0x1859322F0")]
	public static bool EANOCECOOBD(this MNAPBIKGELI KNEFBFDLNNH, AGPGDBBOIBI PDOOJIKDKEG, BIAGKPENIJP FLPMFIPOIDE, in LEMHKMBLBBH CKDFGEALFAK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct PGGJKFLCBDA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public uint AMJEHKBDONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int FECNHHCJFHO;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xB93FA0", Offset = "0xB92FA0", VA = "0x180B93FA0")]
	public PGGJKFLCBDA(uint AMJEHKBDONP, int FECNHHCJFHO)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x5936C50", Offset = "0x5935C50", VA = "0x185936C50")]
	public static bool LFCPNLBCIDE(in PGGJKFLCBDA JMKFPOOBMEL, in PGGJKFLCBDA OIMIHNAHPGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x5936B90", Offset = "0x5935B90", VA = "0x185936B90", Slot = "0")]
	public override bool Equals(object EOHGDDIECBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x5936C20", Offset = "0x5935C20", VA = "0x185936C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x5936C70", Offset = "0x5935C70", VA = "0x185936C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface IDHPGIEDNIA
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PGGJKFLCBDA PBKJJKDDFID(ReadOnlySpan<byte> EMBONFDCNJA);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface ENMFMBAEEHL
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	Type OLNMMLMKONM
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EILKNJCKJNI(ref PCJAAFAAPHB ICOPDHHFIOA, Span<byte> FBOMMBLFPCD);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IKBIGFALLCH(ref POJLLGALFIB JAMIAPJOGMC, ReadOnlySpan<byte> LPNPMOOMCIB);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class EIMOIKBLGOF
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public delegate void NGDJJDCELLH(PGGJKFLCBDA LOHIKDGDMPP, ReadOnlySpan<byte> EMBONFDCNJA);
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[IFKFPJHCLGF(DLPCPGFNDBP.OMRoom)]
public interface OPJFMJMCGDN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LGHMBCIBEAB(PGGJKFLCBDA LOHIKDGDMPP, ReadOnlySpan<byte> EMBONFDCNJA);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class MHGFMJKAFPI
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8B8280", Offset = "0x8B7280", VA = "0x1808B8280")]
	public MHGFMJKAFPI()
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
