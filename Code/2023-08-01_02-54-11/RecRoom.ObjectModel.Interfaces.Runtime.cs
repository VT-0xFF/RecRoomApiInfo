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
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface KOFHEPEJNKL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOLNHFIDPAC(in float3 DPJJEDGKGBN, in float3 HAMNFFBEFHD, float OLGGKIEPHEF, Allocator LEPNDEGMIDH, out NativeArray<Entity> OBBDNLKJJED);
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct EEMGHBBPPHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray BEFPGMBGCNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<IEHIEBBLKIE, int> MHBJAGMFFNK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MGEHPDCHGGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x5987010", Offset = "0x5986010", VA = "0x185987010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1716F60", Offset = "0x1715F60", VA = "0x181716F60")]
	public EEMGHBBPPHN(NativeBitArray BEFPGMBGCNH, NativeParallelHashMap<IEHIEBBLKIE, int> MHBJAGMFFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5987030", Offset = "0x5986030", VA = "0x185987030")]
	public bool FEMAFCMBHGO(IEHIEBBLKIE DELHFMHNJCM, GBJAHOLHFPP FJCNAJDOIIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface GDOMMKEOINN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid MIPPIHIMCBC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task DOHALIAECCF(Guid OFNGMEOLAEG, Guid PIBGFGLBNAA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task ECJKBMPLEGK(KBHBMCLJPDE MKBGCALKIKI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void CGEMIKIEOKP(KBHBMCLJPDE CJCAJMJJJKE, KBHBMCLJPDE AGFCJPGACCB, out Vector3 HONHANLIPPH, out Quaternion FIMLLHIBIOI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NIEGHOCHDJK(OBFEHBDPLHB PEMPFFGGGPN, Vector3 HONHANLIPPH, Quaternion FIMLLHIBIOI);
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface LJIGFJOKOBN : MPKLCNEHKHD<KBHBMCLJPDE>, FHDDOGHNDOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface PJKPFJLAKIO<T> : HHLAEAEOPLH<KBHBMCLJPDE, T>, MPKLCNEHKHD<KBHBMCLJPDE>, FHDDOGHNDOM, IDisposable, LJIGFJOKOBN where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DIDJJMKCLLF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2222DB0", Offset = "0x2221DB0", VA = "0x182222DB0")]
	public static T EAOPAIAIDNN<T>(this MPKLCNEHKHD<KBHBMCLJPDE> FJCNAJDOIIE, KBHBMCLJPDE AAGHLALAEIJ) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2222DE0", Offset = "0x2221DE0", VA = "0x182222DE0")]
	public static bool FNPACIDIMCD<T>(this MPKLCNEHKHD<KBHBMCLJPDE> FJCNAJDOIIE, KBHBMCLJPDE AAGHLALAEIJ, in T MNIFIBOADMC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface ABAPABOIFIO
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<EBGEBJGAJEB> GOOJGCHCEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<KBHBMCLJPDE, KBHBMCLJPDE> MDBMEHJDNPN;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<KBHBMCLJPDE, KBHBMCLJPDE> KAKGBCGAKAE;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<KBHBMCLJPDE, KBHBMCLJPDE, KBHBMCLJPDE> DEONAOIMMLD;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<KBHBMCLJPDE> IFHGIILHBAL;

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color ILFMCDDGLEA(KBHBMCLJPDE AAGHLALAEIJ, int IECKPFMJDPL);

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 BMIFLPNFCAP(KBHBMCLJPDE AAGHLALAEIJ, int IECKPFMJDPL);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool LJAHOPMKHDJ(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE LLOMNLBKDAB);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "13")]
	KBHBMCLJPDE BKIOAKHNAEL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<KBHBMCLJPDE> IJLDJBKNAPI(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "15")]
	KBHBMCLJPDE EHCPGGLONDG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DHAMGIIKEDF(KBHBMCLJPDE AAGHLALAEIJ, Vector3 NCLOLCNMLIP, Quaternion PHJJGJJDLIL);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void AJKFLMGHFGN(KBHBMCLJPDE AAGHLALAEIJ, float LJJLDLLDOBN);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool NLJFLOIJLCM(KBHBMCLJPDE AAGHLALAEIJ, out RigidTransform GAIPMMOFMJD);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool JECGFPAAGKA(KBHBMCLJPDE AAGHLALAEIJ, out float EIMBFCDNGKF);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 GNALGMHEEEA(DAGDFGLMHCJ FHJKEHICGLG);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion NMKNNIBHCCH(DAGDFGLMHCJ FHJKEHICGLG);
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class OELCFJLDCKF
{
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface NLIEAAINMAB
{
	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NOLNHFIDPAC(in NativeArray<Entity> OBBDNLKJJED, in float3 DPJJEDGKGBN, in float3 HAMNFFBEFHD, in NativeArray<DALHMOFBJNF> CIKDBDABPCO);
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface IABGNEKJFEK
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KGPHBDINNEF(KBHBMCLJPDE ABAAGAOADBF, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMEDIGOLNLP(KBHBMCLJPDE ABAAGAOADBF, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OPJNDDLEBFK(KBHBMCLJPDE ABAAGAOADBF, int CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[DefaultMember("Item")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface PGAEBPPBLKO : IEnumerable<PDHNEODNMGH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray NENCOIDJOJO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> GLBPJANBDPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	PDHNEODNMGH IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	PDHNEODNMGH IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(Slot = "5")]
	PDHNEODNMGH EFGFLBDCIBO(EOOMHOMHJOF HBOAIEOOPAF);

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(Slot = "6")]
	GBJAHOLHFPP OPLBINNFJPI(EOOMHOMHJOF HBOAIEOOPAF);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public static class JDGGGHPCCPE
{
	[Cpp2IlInjected.Token(Token = "0x600002D")]
	public static NGJFHDHNHOF<T> EFGFLBDCIBO<T>(this PGAEBPPBLKO KDNJIKBJJJJ, EOOMHOMHJOF OKONKHNEMOO) where T : struct
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public readonly struct MBJHCCIPOBP : IEquatable<MBJHCCIPOBP>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly MBJHCCIPOBP NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public MBJHCCIPOBP(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x598D720", Offset = "0x598C720", VA = "0x18598D720", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(MBJHCCIPOBP JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public readonly struct BPGOJLHGDNF : IEquatable<BPGOJLHGDNF>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly BPGOJLHGDNF NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x59856A0", Offset = "0x59846A0", VA = "0x1859856A0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(BPGOJLHGDNF JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface GOAMPGJCLHG
{
	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	EEMGHBBPPHN OOJHCIPPNKE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FEMAFCMBHGO(IEHIEBBLKIE DELHFMHNJCM, GBJAHOLHFPP FJCNAJDOIIE);

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FBCDJIFDDMB(IEHIEBBLKIE DELHFMHNJCM, Span<GBJAHOLHFPP> KDNJIKBJJJJ, bool LIPCDJOKOND);

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LEJPFHLPEMM(NativeArray<IEHIEBBLKIE> EJCCEJGOJNO);
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class BENMJOHEHAH
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5985470", Offset = "0x5984470", VA = "0x185985470")]
	public static void FBCDJIFDDMB(this GOAMPGJCLHG ODPMBDLFJPK, IEHIEBBLKIE DELHFMHNJCM, GBJAHOLHFPP FJCNAJDOIIE, bool LIPCDJOKOND)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct INJFODOHFLJ : GOKMJAEOJOF, IEquatable<INJFODOHFLJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly INJFODOHFLJ NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public GameObject IHNGPGNCBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x598B160", Offset = "0x598A160", VA = "0x18598B160")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public IEHIEBBLKIE NIKELGPLPDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x598B4F0", Offset = "0x598A4F0", VA = "0x18598B4F0")]
		get
		{
			return default(IEHIEBBLKIE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JDJIDODBAGJ LPJJNNIMPGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x598AAE0", Offset = "0x5989AE0", VA = "0x18598AAE0")]
		get
		{
			return default(JDJIDODBAGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public DGAJAJLJOIP FNAIHPKNAKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x598AE80", Offset = "0x5989E80", VA = "0x18598AE80")]
		get
		{
			return default(DGAJAJLJOIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public bool LDDOIJNFFPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x598ADF0", Offset = "0x5989DF0", VA = "0x18598ADF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool NMJMFKNEKNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x598B420", Offset = "0x598A420", VA = "0x18598B420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool BFGCANABELK
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x598B6B0", Offset = "0x598A6B0", VA = "0x18598B6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool ACNGDKOHLID
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x598B140", Offset = "0x598A140", VA = "0x18598B140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool PILEIMBCMEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x598AC10", Offset = "0x5989C10", VA = "0x18598AC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool NOEHCNNOOPK
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x598AFF0", Offset = "0x5989FF0", VA = "0x18598AFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool KDOFMCJDLJD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x598ABC0", Offset = "0x5989BC0", VA = "0x18598ABC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IIPEKDEBOIA
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x598ABA0", Offset = "0x5989BA0", VA = "0x18598ABA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public IJIODPDDOHH GHFDCDCFFNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(IJIODPDDOHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public PNNKJJIDCKL IAOALOCKDAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(PNNKJJIDCKL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MGMBOMDCJGJ DMMGJKAGHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MGMBOMDCJGJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public FJEGKAFPHEH AAKOLCPJCDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(FJEGKAFPHEH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GFPFEOADMOB ANJFOLFIJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(GFPFEOADMOB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public OEEKBAOFEGI PGABNLCCJKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(OEEKBAOFEGI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public OBFEHBDPLHB HHLMNBEHMDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(OBFEHBDPLHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool BMLNMMNHHDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x598AA10", Offset = "0x5989A10", VA = "0x18598AA10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public bool ACJINOBHFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x598ACA0", Offset = "0x5989CA0", VA = "0x18598ACA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private bool DEEBFJKHLOG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240", Slot = "5")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public MMLPFHHOIHM NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MMLPFHHOIHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public MEOAMGBKKIO AOPFCIHOLLN
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MEOAMGBKKIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
	public static INJFODOHFLJ DLCNBHCGPLK(KBHBMCLJPDE ABAAGAOADBF)
	{
		return default(INJFODOHFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x598B5B0", Offset = "0x598A5B0", VA = "0x18598B5B0")]
	public AKDCLPGGBEC OLEMPPNDIIH()
	{
		return default(AKDCLPGGBEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x598B640", Offset = "0x598A640", VA = "0x18598B640")]
	public OFOPFBNBGHA OLMJMOIJKGC()
	{
		return default(OFOPFBNBGHA);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x598AE10", Offset = "0x5989E10", VA = "0x18598AE10")]
	public MBJHCCIPOBP FKMIAHJFGGE()
	{
		return default(MBJHCCIPOBP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x598AC30", Offset = "0x5989C30", VA = "0x18598AC30")]
	public OFODDMEHLKO CKOAKKEEKIF()
	{
		return default(OFODDMEHLKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x598B0B0", Offset = "0x598A0B0", VA = "0x18598B0B0")]
	public DAGDFGLMHCJ KCCOBDIMDMM()
	{
		return default(DAGDFGLMHCJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x598B260", Offset = "0x598A260", VA = "0x18598B260")]
	public void LOPDGFLBPGI([Optional] object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x598AF40", Offset = "0x5989F40", VA = "0x18598AF40")]
	public bool GHKKKNFJOEO(object DMHDKAFNNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x598B440", Offset = "0x598A440", VA = "0x18598B440")]
	public bool ODBKNPBDPDK(object DMHDKAFNNAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x598B6D0", Offset = "0x598A6D0", VA = "0x18598B6D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public INJFODOHFLJ(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(INJFODOHFLJ CKMKMNKGMMC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
	public static KBHBMCLJPDE DLCNBHCGPLK(INJFODOHFLJ CKMKMNKGMMC)
	{
		return default(KBHBMCLJPDE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x598B010", Offset = "0x598A010", VA = "0x18598B010")]
	public static bool JFBEPFHBCDN(INJFODOHFLJ CDICEDNOPPN, INJFODOHFLJ ANCILJKDKHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x598B340", Offset = "0x598A340", VA = "0x18598B340")]
	public static bool NLNNLODOBLO(INJFODOHFLJ CDICEDNOPPN, INJFODOHFLJ ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x598ACF0", Offset = "0x5989CF0", VA = "0x18598ACF0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "6")]
	public bool Equals(INJFODOHFLJ JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public delegate void DCIOGKHOFLD(ECGLMGAMPCE NHGOEGMHHHH);
[Cpp2IlInjected.Token(Token = "0x2000014")]
[DefaultMember("Item")]
public struct PKCAGEGHLCP : IList<KBHBMCLJPDE>, ICollection<KBHBMCLJPDE>, IEnumerable<KBHBMCLJPDE>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct IPEOPEMDJDO : IEnumerator<KBHBMCLJPDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly GKHJEPNPMDA IEENNNLENFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator FOFFMOPCHNJ;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public KBHBMCLJPDE DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x598B9C0", Offset = "0x598A9C0", VA = "0x18598B9C0", Slot = "4")]
			get
			{
				return default(KBHBMCLJPDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x598B8E0", Offset = "0x598A8E0", VA = "0x18598B8E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x20DBD90", Offset = "0x20DAD90", VA = "0x1820DBD90")]
		public IPEOPEMDJDO(GKHJEPNPMDA IEENNNLENFN, NativeArray<LocalId>.Enumerator FOFFMOPCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x598B820", Offset = "0x598A820", VA = "0x18598B820", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x598B860", Offset = "0x598A860", VA = "0x18598B860", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x598B8A0", Offset = "0x598A8A0", VA = "0x18598B8A0", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly GKHJEPNPMDA IEENNNLENFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> NCHKOJCIMBJ;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public KBHBMCLJPDE IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x5995250", Offset = "0x5994250", VA = "0x185995250", Slot = "4")]
		get
		{
			return default(KBHBMCLJPDE);
		}
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x59952D0", Offset = "0x59942D0", VA = "0x1859952D0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x5994A20", Offset = "0x5993A20", VA = "0x185994A20", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public int MGNEPOBDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x5994A20", Offset = "0x5993A20", VA = "0x185994A20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public bool DKANIEEHJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x840160", Offset = "0x83F160", VA = "0x180840160", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x59951C0", Offset = "0x59941C0", VA = "0x1859951C0")]
	public PKCAGEGHLCP(GKHJEPNPMDA IEENNNLENFN, int GAKMECKICIG, Allocator LEPNDEGMIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x5994D60", Offset = "0x5993D60", VA = "0x185994D60")]
	public NAJEBGMNODC DMCNJDGPIDF()
	{
		return default(NAJEBGMNODC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x5994A60", Offset = "0x5993A60", VA = "0x185994A60", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x5994AA0", Offset = "0x5993AA0", VA = "0x185994AA0", Slot = "13")]
	public bool Contains(KBHBMCLJPDE GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x5994B00", Offset = "0x5993B00", VA = "0x185994B00", Slot = "14")]
	public void CopyTo(KBHBMCLJPDE[] OGEGDDKCPPH, int LDCAPAEBEMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x59949C0", Offset = "0x59939C0", VA = "0x1859949C0", Slot = "11")]
	public void Add(KBHBMCLJPDE GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5994E80", Offset = "0x5993E80", VA = "0x185994E80", Slot = "7")]
	public void Insert(int EJNMEMKEIOD, KBHBMCLJPDE GDMNFPEECEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5994F50", Offset = "0x5993F50", VA = "0x185994F50", Slot = "15")]
	public bool Remove(KBHBMCLJPDE GDMNFPEECEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5994E20", Offset = "0x5993E20", VA = "0x185994E20", Slot = "6")]
	public int IndexOf(KBHBMCLJPDE GDMNFPEECEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5994F00", Offset = "0x5993F00", VA = "0x185994F00", Slot = "8")]
	public void RemoveAt(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5994DE0", Offset = "0x5993DE0", VA = "0x185994DE0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5994CD0", Offset = "0x5993CD0", VA = "0x185994CD0")]
	public IPEOPEMDJDO DHFGGODEIOI()
	{
		return default(IPEOPEMDJDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5994FE0", Offset = "0x5993FE0", VA = "0x185994FE0", Slot = "16")]
	private IEnumerator<KBHBMCLJPDE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x59950D0", Offset = "0x59940D0", VA = "0x1859950D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface ENHJJEBPBOC
{
	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NOLNHFIDPAC(in float3 DPJJEDGKGBN, in float3 HAMNFFBEFHD, float OLGGKIEPHEF, out DALHMOFBJNF CPGIIPPFHBE, out KBHBMCLJPDE EJJDDGNCKAH);
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public readonly struct MABPMODAGDK : IEquatable<MABPMODAGDK>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly MABPMODAGDK NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	private KKMHMCHHIDF LEHFGBHKHIG
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x598CEA0", Offset = "0x598BEA0", VA = "0x18598CEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public OFOPFBNBGHA OOPGCGOHEMO
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(OFOPFBNBGHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public BCNKDDIOAKC GLHJGJJCECA
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x598D1A0", Offset = "0x598C1A0", VA = "0x18598D1A0")]
		get
		{
			return default(BCNKDDIOAKC);
		}
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x598D5F0", Offset = "0x598C5F0", VA = "0x18598D5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public IEnumerable<PCFFEFPAFNP> LJGOPMILMBI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x598D410", Offset = "0x598C410", VA = "0x18598D410")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public PCFFEFPAFNP IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x598CAC0", Offset = "0x598BAC0", VA = "0x18598CAC0")]
		get
		{
			return default(PCFFEFPAFNP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x598CBE0", Offset = "0x598BBE0", VA = "0x18598CBE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MMLPFHHOIHM NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MMLPFHHOIHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x598D150", Offset = "0x598C150", VA = "0x18598D150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x598C8A0", Offset = "0x598B8A0", VA = "0x18598C8A0")]
	public PCFFEFPAFNP BCHEDMPEANI(float3? EDEGPGKBEGA, [Optional] quaternion? DEANJFCCEBG, [Optional] Vector3? MCNELIBKDDB)
	{
		return default(PCFFEFPAFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x598CF20", Offset = "0x598BF20", VA = "0x18598CF20")]
	public PCFFEFPAFNP GPEMHCPBCGJ(int EJNMEMKEIOD, float3? EDEGPGKBEGA, [Optional] quaternion? DEANJFCCEBG, [Optional] Vector3? MCNELIBKDDB)
	{
		return default(PCFFEFPAFNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x598D290", Offset = "0x598C290", VA = "0x18598D290")]
	public void JDKMAIEIFCP(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x598CCC0", Offset = "0x598BCC0", VA = "0x18598CCC0")]
	public void EPCDHGCGJPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public MABPMODAGDK(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(MABPMODAGDK CKMKMNKGMMC)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x598D370", Offset = "0x598C370", VA = "0x18598D370")]
	public static bool JFBEPFHBCDN(MABPMODAGDK CDICEDNOPPN, MABPMODAGDK ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x598CDA0", Offset = "0x598BDA0", VA = "0x18598CDA0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(MABPMODAGDK JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface BBLPNKBKLNC
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	Type ANIILGCBCIA
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface DAAJPFIJADI
{
	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool BGLIDDAJHPA(KBHBMCLJPDE AAGHLALAEIJ, out Collider HJBJFCKNGEN);

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject MGCMMMBJMEA(KBHBMCLJPDE FIIEKBOLJAB, GameObject CNMMOEIHJMA, Vector3 NEABPKFFKMG, Quaternion FGLECLFCAGD);

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDAIEIJAEHL(GameObject HJBJFCKNGEN);

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider NLHLMFDOCAO<TCollider>(GameObject HNGBOFFGPMC) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGKGHGKCKIK(Collider HJBJFCKNGEN);

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject HBHGLHFEHFD<TCollider>(string OKONKHNEMOO) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public interface NEKCPPCFKIK : MPKLCNEHKHD<IEHIEBBLKIE>, FHDDOGHNDOM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface LHDMIDAMFOC<T> : HHLAEAEOPLH<IEHIEBBLKIE, T>, MPKLCNEHKHD<IEHIEBBLKIE>, FHDDOGHNDOM, IDisposable, NEKCPPCFKIK where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class JDAKPLNFJFP
{
	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x20A8E40", Offset = "0x20A7E40", VA = "0x1820A8E40")]
	public static bool PPJKMMAHKMD<T>(this MPKLCNEHKHD<IEHIEBBLKIE> FJCNAJDOIIE, IEHIEBBLKIE DELHFMHNJCM, out T CKMKMNKGMMC) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x20A8E30", Offset = "0x20A7E30", VA = "0x1820A8E30")]
	public static bool FNPACIDIMCD<T>(this MPKLCNEHKHD<IEHIEBBLKIE> FJCNAJDOIIE, IEHIEBBLKIE DELHFMHNJCM, in T MNIFIBOADMC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public readonly struct OBFEHBDPLHB : IEquatable<OBFEHBDPLHB>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly OBFEHBDPLHB NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	private IBBKFEOICPE LBPPNKOGIGE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x5992930", Offset = "0x5991930", VA = "0x185992930")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public bool OJEILHCJPNB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x59929B0", Offset = "0x59919B0", VA = "0x1859929B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public Guid OGKOHGGLCCJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x5992440", Offset = "0x5991440", VA = "0x185992440")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public bool OMIHADLKEII
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x5992B70", Offset = "0x5991B70", VA = "0x185992B70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public Guid HECBKNGNJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x5992350", Offset = "0x5991350", VA = "0x185992350")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x59928E0", Offset = "0x59918E0", VA = "0x1859928E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x5992630", Offset = "0x5991630", VA = "0x185992630")]
	public bool FAAJPEGIDLL(out Guid DIGKBLFDPPL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x5992710", Offset = "0x5991710", VA = "0x185992710")]
	public void FDAFODMOBJG(Guid PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x5992800", Offset = "0x5991800", VA = "0x185992800")]
	public bool HBKCPKBHABH(out Guid DHKAFFPFMFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x5992C50", Offset = "0x5991C50", VA = "0x185992C50")]
	public void PMDPKOJGOHC(Guid PCKJKBNEEPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x5992A90", Offset = "0x5991A90", VA = "0x185992A90")]
	public void OJKGKCFPHBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public OBFEHBDPLHB(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(OBFEHBDPLHB CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x5992530", Offset = "0x5991530", VA = "0x185992530", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(OBFEHBDPLHB JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public readonly struct PNNKJJIDCKL : IEquatable<PNNKJJIDCKL>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly PNNKJJIDCKL NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5995570", Offset = "0x5994570", VA = "0x185995570")]
	public void JJKMDDGGLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5995640", Offset = "0x5994640", VA = "0x185995640")]
	public void NJHLGCACLHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public PNNKJJIDCKL(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x5995470", Offset = "0x5994470", VA = "0x185995470", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(PNNKJJIDCKL JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface NKOOCAKBLNH : GOKMJAEOJOF
{
	[Cpp2IlInjected.Token(Token = "0x17000043")]
	INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	LBGPEGPAPPB KKKBDNNADKG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	bool MEHGAEEBFIH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	GameObject IHNGPGNCBCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<NKOOCAKBLNH> EKOICFPBELE;

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(ABOICCJCDEM JMDHEINCIFM, KBHBMCLJPDE APEPHOLHBEB);

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool LDLFDKGCKKP);

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class MEGNGKLGOFO
{
	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x598DA80", Offset = "0x598CA80", VA = "0x18598DA80")]
	public static bool BMLNMMNHHDM(this NKOOCAKBLNH GHAKJBHJDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x598DAD0", Offset = "0x598CAD0", VA = "0x18598DAD0")]
	public static bool JEJBNKEPFDA(this NKOOCAKBLNH GHAKJBHJDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x598DB20", Offset = "0x598CB20", VA = "0x18598DB20")]
	public static bool KNDHGMLIFMJ(this NKOOCAKBLNH GHAKJBHJDGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x598D9E0", Offset = "0x598C9E0", VA = "0x18598D9E0")]
	public static bool BLPCIPDEODE(this NKOOCAKBLNH GHAKJBHJDGO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public readonly struct HLMENMLHFFI : IEquatable<HLMENMLHFFI>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly HLMENMLHFFI NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x598A0C0", Offset = "0x59890C0", VA = "0x18598A0C0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(HLMENMLHFFI JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface BKOMEALDHLF
{
	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OGDNBDBKAPC(NativeListAsync<Entity> IHCPLMKEOAG);

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HKLEGEJHLPO(IEMDEGBAOIN JFGAGPPABII);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HGHLGOIIJIP(NativeListAsync<Entity> CFCHHHPLCFP, bool KGHAJMEEAJC);

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MHMGILEHKEL();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface PJJPKNGJDJG
{
	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FOHBNJIIAMM(KBHBMCLJPDE AAGHLALAEIJ, LJMGEKAHOAN CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface FOINKFDOOFN
{
	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void INANNECGIIC();

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LMFNLBILMLK();

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JICLFPJBAHI();

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LBKJIHNONHI();

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJOILOMIMNB();

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void OCIDGLHJEOG();

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void AMKMLOAHHKB();

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void ELPFBIMMJCM();

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HGBCLBIKHMJ();

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PPOJKLPBALL();

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void LHFCMPBKPHF();
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KKJHCJBCHLM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000048")]
	int CBFJAJEKMHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> CIALJHDNNLK
	{
		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "2")]
	KBHBMCLJPDE LJOKEIBGMNE(KBHBMCLJPDE NCHKOJCIMBJ);

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "3")]
	int LJOKEIBGMNE(int DPLIKMOLABI);
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public interface PODCNDBHMGB : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public readonly struct FJEGKAFPHEH : IEquatable<FJEGKAFPHEH>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public static readonly FJEGKAFPHEH NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	private CFIHHKFLGMB NILNFIEOBJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x5987880", Offset = "0x5986880", VA = "0x185987880")]
		get
		{
			return default(CFIHHKFLGMB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool NAHCBGBOGPN
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x59881B0", Offset = "0x59871B0", VA = "0x1859881B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool IOFDJJEDMAI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x5987630", Offset = "0x5986630", VA = "0x185987630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public bool BPCDAFCOBJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x5987C20", Offset = "0x5986C20", VA = "0x185987C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public bool GEAOMOPDAHM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x5987DF0", Offset = "0x5986DF0", VA = "0x185987DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public bool CENBPKFDDED
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5987EE0", Offset = "0x5986EE0", VA = "0x185987EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public bool OJHKJHHODFJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x5987710", Offset = "0x5986710", VA = "0x185987710")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public bool CNFLMNEKONN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x5988220", Offset = "0x5987220", VA = "0x185988220")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool LGBHNDFHJHK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x59876A0", Offset = "0x59866A0", VA = "0x1859876A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool ACNGFDAMDNF
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x59879A0", Offset = "0x59869A0", VA = "0x1859879A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool ANAAJHDBBFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x5987BB0", Offset = "0x5986BB0", VA = "0x185987BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool EPDFLFCPGJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x5987C90", Offset = "0x5986C90", VA = "0x185987C90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool OGGFGHKAAKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x5988070", Offset = "0x5987070", VA = "0x185988070")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool BDNGPEEHHMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x5987D80", Offset = "0x5986D80", VA = "0x185987D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool PPPANPMEAPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x5987620", Offset = "0x5986620", VA = "0x185987620")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool NHGPHNCMBIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x5987610", Offset = "0x5986610", VA = "0x185987610")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x5987ED0", Offset = "0x5986ED0", VA = "0x185987ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool JJGIIPOELPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5987E60", Offset = "0x5986E60", VA = "0x185987E60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector3 PEKDNNKLLHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x59880E0", Offset = "0x59870E0", VA = "0x1859880E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public Vector3 INHKNKNIDGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x59878E0", Offset = "0x59868E0", VA = "0x1859878E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool HLDGHPLMHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5987F50", Offset = "0x5986F50", VA = "0x185987F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5987B60", Offset = "0x5986B60", VA = "0x185987B60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5987AE0", Offset = "0x5986AE0", VA = "0x185987AE0")]
	public bool HDHGMMOHBOH(AAFBNOKFOKK MCOHAKACPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5987A10", Offset = "0x5986A10", VA = "0x185987A10")]
	public bool HCEIBMNELHD(DJOCDAEJDBB MCOHAKACPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5987D00", Offset = "0x5986D00", VA = "0x185987D00")]
	public void JNIOPIMHPHN(DJOCDAEJDBB MCOHAKACPKD, bool JGIOJFGLBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public FJEGKAFPHEH(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x5987780", Offset = "0x5986780", VA = "0x185987780", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(FJEGKAFPHEH JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum LCGFFEKNDGA
{
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public static class KIFDLDKHMCP
{
	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x1B748F0", Offset = "0x1B738F0", VA = "0x181B748F0")]
	public static bool LAGGLKABNHG(this LCGFFEKNDGA EGNHEHPGBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x1B74930", Offset = "0x1B73930", VA = "0x181B74930")]
	public static bool HPLDGIFOINK(this LCGFFEKNDGA EGNHEHPGBMN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x45A23B0", Offset = "0x45A13B0", VA = "0x1845A23B0")]
	public static bool NMMCPJFHPBP(this LCGFFEKNDGA EGNHEHPGBMN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface ABOICCJCDEM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000062")]
	World OLICHGCDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	World AEPGNCHMIBD
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	EntityManager DDMBMPJOHMF
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	bool BLPCIPDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase KGMCLDKIEAN(Type FLAJIGGIBOB);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public static class OFOPNCIFNEO
{
	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x5993D50", Offset = "0x5992D50", VA = "0x185993D50")]
	public static ComponentSystemBase NMGDGJPHMLM(this World JMDHEINCIFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x292B420", Offset = "0x292A420", VA = "0x18292B420")]
	public static T KGMCLDKIEAN<T>(this ABOICCJCDEM LLEMHDJOOAE) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct HFOKKNDJCPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly ECGLMGAMPCE HCKNMLENIIG;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public NAJEBGMNODC LOGBGMBOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x18599A0", Offset = "0x18589A0", VA = "0x1818599A0")]
		get
		{
			return default(NAJEBGMNODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x598A000", Offset = "0x5989000", VA = "0x18598A000")]
	public HFOKKNDJCPG(ECGLMGAMPCE HCKNMLENIIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x5989E60", Offset = "0x5988E60", VA = "0x185989E60")]
	public NAJEBGMNODC FNJMLMFOILC()
	{
		return default(NAJEBGMNODC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x5989F30", Offset = "0x5988F30", VA = "0x185989F30")]
	public NAJEBGMNODC PFDKBLJJJNI()
	{
		return default(NAJEBGMNODC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5989CD0", Offset = "0x5988CD0", VA = "0x185989CD0")]
	public (NAJEBGMNODC, NAJEBGMNODC, NAJEBGMNODC) EAOPAIAIDNN()
	{
		return default((NAJEBGMNODC, NAJEBGMNODC, NAJEBGMNODC));
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public readonly struct MEOAMGBKKIO : IEquatable<MEOAMGBKKIO>
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public static readonly MEOAMGBKKIO NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	private IALNCAKHEIO CECBFENHNKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x598DDB0", Offset = "0x598CDB0", VA = "0x18598DDB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public KBHBMCLJPDE IDBAAPPOINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x598DE30", Offset = "0x598CE30", VA = "0x18598DE30")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public INJFODOHFLJ PFNKNMFEFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x598E030", Offset = "0x598D030", VA = "0x18598E030")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public INJFODOHFLJ EDABIFLHHKC
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x598E130", Offset = "0x598D130", VA = "0x18598E130")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x598DD60", Offset = "0x598CD60", VA = "0x18598DD60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x598DF20", Offset = "0x598CF20", VA = "0x18598DF20")]
	public bool LMENPCDIGEL(INJFODOHFLJ AGFCJPGACCB, bool FKOOEMPCGOD = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x598DB70", Offset = "0x598CB70", VA = "0x18598DB70")]
	public bool BFNAAJCPEMG(INJFODOHFLJ BHNDMMJICPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public MEOAMGBKKIO(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x598DC60", Offset = "0x598CC60", VA = "0x18598DC60", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(MEOAMGBKKIO JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public readonly struct KALIFCEPONM : IEquatable<KALIFCEPONM>
{
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public static readonly KALIFCEPONM NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	private KODEKEAADNO KCAJDMLFDFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x598C0F0", Offset = "0x598B0F0", VA = "0x18598C0F0")]
		get
		{
			return default(KODEKEAADNO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public GCFCBJAFCBA DICMHJHLINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x598C150", Offset = "0x598B150", VA = "0x18598C150")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public KALIFCEPONM(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x598BFF0", Offset = "0x598AFF0", VA = "0x18598BFF0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(KALIFCEPONM JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface FICGPHKNKJB
{
	[Cpp2IlInjected.Token(Token = "0x17000072")]
	KKAMNNCNEEM IEFEKILHFPB
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
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface OGOJMJDLIMM
{
	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World EBGOLBJOLAI();

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World NEOPLOEGHKK();

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World LKBMIPDGMFB();

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World GDHODKNMBCC();
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public interface CIFOMPCPMNG
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int PKPLGJJFLJA(GameObject IHNGPGNCBCG);

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HEKAKNMLOKM(GameObject IHNGPGNCBCG);

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object JJJBEAIKPPA(KBHBMCLJPDE AAGHLALAEIJ, GameObject IHNGPGNCBCG, Action<KBHBMCLJPDE, int> PAFCNGJPIGM);

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GBJBPMKIOCI(GameObject IHNGPGNCBCG, object MDCMPBHMMMN);
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public interface LGMKEEEEJBO
{
	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OFHOEOBLBHA(NAJEBGMNODC NCHKOJCIMBJ);

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 BMIFLPNFCAP(GameObject IHNGPGNCBCG, int ONHINEDNFGN);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface JKPGNKFJHJA
{
	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IPDLMPNHNJP(GameObject IBODHKMNDBB, bool LEOEHJANNDA);

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void HGGMDNCMONN(GameObject IHNGPGNCBCG, bool EJJGNPJJBLH, bool PNHLEFMMAFG);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public interface BIOJBBGPLLF
{
	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JGKOHNABIBI(Action NPNCNABHINE, bool OJFJFNPMKKF);

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HCECPHPMCDM(string OKONKHNEMOO);
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public interface AIHMAHJHNHH
{
	[Cpp2IlInjected.Token(Token = "0x17000073")]
	string OLMHAMBGPPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] OEBCMMIJOHG(IEnumerable<GOAOJMCEMIL> KAOFJLCFHON);

	[Cpp2IlInjected.Token(Token = "0x6000152")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEHIEBBLKIE PHFDBJGAOPH(Guid NKOKAJPAGPJ);

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool LAOKBCFIFDL(GameObject IHNGPGNCBCG, out IEHIEBBLKIE DELHFMHNJCM);

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool ILAFIHGDJOA(GameObject IHNGPGNCBCG, out int ECFEDFKPCPJ, out DGAJAJLJOIP LAABEELPEOO);

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NKOOCAKBLNH FJJOADOLHAH(GOAOJMCEMIL NJAMEFJLMOC);

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NKOOCAKBLNH FJJOADOLHAH(string DMELMMAPFOE, IEHIEBBLKIE DELHFMHNJCM, Vector3 EDEGPGKBEGA, Quaternion DEANJFCCEBG, Vector3 MCNELIBKDDB);

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OHGFIPKGNNG(GameObject IHNGPGNCBCG);
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public interface FBLDELBGOLF
{
	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KBDLOGECPFI(bool PINBJOHBLIC);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public interface CPEIHCOLBEL
{
	[Cpp2IlInjected.Token(Token = "0x17000074")]
	bool OBBOHHELFDB
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	bool GEMCBBJEIFJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	int GALFKPKOALO
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	bool EOFAFLIBMON
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	bool KMNHJEFFAEC
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CDBFOKGMOFA(object KPMKPNDNMBB);

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void DHLMGLCMEGF(object EEMPMGBFHEC);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JCBECNJLCDP(object EEMPMGBFHEC);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "8")]
	int NOHOHPEEODD(GameObject IADMJGHOCPL);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NLMLOOIIMNH(NativeArray<int> JHLHAIAGHBM);
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public interface GCNPJOKMAMO
{
	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKPKKPEGBNI(GameObject IHNGPGNCBCG);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface MKGNLCLNEAI
{
	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FJKCFALFLHH(string FANKIHBOOPE);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface FOJGELLGJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MGJOKANDOMJ(GameObject IHNGPGNCBCG);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MCEMEJNMLAF(out Vector3 EDEGPGKBEGA);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task DOLCNMHFAKD();

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Task GKPMJAFKLAM();

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(Slot = "4")]
	Task JOJODGPDPKE();

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void BIICDAGJCPB();
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public interface IOFEKLKFICE
{
	[Cpp2IlInjected.Token(Token = "0x17000079")]
	GAHNJLMAFHI GNOEOHOOOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	HPJDNKFIOEH MGGKMKCDHKE
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LKOHGICMEPO(Transform CEKKPPPNLGM);

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DFAAMLNACND(Transform CEKKPPPNLGM, JOJGLDNKBNG MNCFLMOEFBM);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PBDGNFILLCI(Transform CEKKPPPNLGM, KKAMNNCNEEM AOGHJNLEEHB);
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface ELKFFMLEGJE
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Task HPNBHEBFBKF();

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LFGPOGINCGO();
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface KEFJJIKLBCB
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIFNIDEALJJ();
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public interface NPDLOENGOJA
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(Slot = "0")]
	DGAJAJLJOIP IMFHJGGEFMO(GameObject IADMJGHOCPL);

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DMGHAAHEGLG(GameObject IHNGPGNCBCG, DJOCDAEJDBB FOEJOBDNJBI);
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface AKFMFMINDIE
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	bool JHNHNKDJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface OOONJFBBMMC : IDisposable, CIFOMPCPMNG, LGMKEEEEJBO, JKPGNKFJHJA, BIOJBBGPLLF, AIHMAHJHNHH, FBLDELBGOLF, CPEIHCOLBEL, GCNPJOKMAMO, MKGNLCLNEAI, FOJGELLGJLJ, AKFMFMINDIE, IOFEKLKFICE, ELKFFMLEGJE, KEFJJIKLBCB, NPDLOENGOJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class COLOICIJAIG
{
	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x59859B0", Offset = "0x59849B0", VA = "0x1859859B0")]
	public static NKOOCAKBLNH FJJOADOLHAH(this AIHMAHJHNHH JJLHNLMGEOM, IEHIEBBLKIE DELHFMHNJCM, Vector3 EDEGPGKBEGA, Quaternion DEANJFCCEBG, Vector3 MCNELIBKDDB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface HNLAIAMJMEM
{
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public struct AAJBDLLIBEJ : CEKEPAAIMKF<AAJBDLLIBEJ>, CKPCDNGLPGP, IEquatable<AAJBDLLIBEJ>
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public int EHPNNEFNFPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public int AHEIGHJAOII
	{
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x59842A0", Offset = "0x59832A0", VA = "0x1859842A0", Slot = "8")]
	public bool Equals(AAJBDLLIBEJ JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x59842F0", Offset = "0x59832F0", VA = "0x1859842F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface FILNFIGODJA
{
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public struct GONEJMDDKKO : GDKPDOBOMBP, IEquatable<GONEJMDDKKO>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public DGAJAJLJOIP LAABEELPEOO;

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x5989A40", Offset = "0x5988A40", VA = "0x185989A40", Slot = "5")]
	public void BPADPDDPOEA(ref AFABOODPCMI NMOOAPLNEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5989A10", Offset = "0x5988A10", VA = "0x185989A10", Slot = "4")]
	public void BCEEACLIKPE(ref NLKPKBIFPPK EFACDLPILBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5989B00", Offset = "0x5988B00", VA = "0x185989B00", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3FED3C0", Offset = "0x3FEC3C0", VA = "0x183FED3C0", Slot = "6")]
	public bool Equals(GONEJMDDKKO JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x5989A70", Offset = "0x5988A70", VA = "0x185989A70", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface FKGJPPBFGFB
{
	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	bool JHNHNKDJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action KBNAMPMMMFH;

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JHBBNBGCLBH();

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IAEAJCFCKAH();

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KNDNGIGOPCM(bool PINBJOHBLIC);

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CAKBKBGAKND(ByteString AOBDCPLDMJI);

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	Task DOLCNMHFAKD();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	Task GKPMJAFKLAM();

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	Task JOJODGPDPKE();

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void GOHDHJFFAEB();
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface CPGBEGBDDKL
{
	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	HOJKPGCEPEN AIBBIEKLJLH
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	List<LJIGFJOKOBN> BAILDHJFPIM
	{
		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KEPHIBNHHLJ(LJIGFJOKOBN FJCNAJDOIIE, out HOJKPGCEPEN BPGGKPJGABF);

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJHMJAKPJGO(LJIGFJOKOBN FJCNAJDOIIE, DCIOGKHOFLD PBIKCDLNKDO);

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IPDIJNNDOCF(LJIGFJOKOBN FJCNAJDOIIE, DCIOGKHOFLD PBIKCDLNKDO);
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface EFLDEKJJOBJ
{
	[Cpp2IlInjected.Token(Token = "0x17000081")]
	HMFCJFOICEH HBILNBGDIKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public readonly struct DAGDFGLMHCJ : IEquatable<DAGDFGLMHCJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static readonly DAGDFGLMHCJ NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	private ABAPABOIFIO JJCPBHIIMID
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5985FE0", Offset = "0x5984FE0", VA = "0x185985FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public float3 PEJEECICAGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5985EF0", Offset = "0x5984EF0", VA = "0x185985EF0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	public quaternion JDIOJLHEKIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x5985E00", Offset = "0x5984E00", VA = "0x185985E00")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public INJFODOHFLJ AKLIHEHBMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x5985CD0", Offset = "0x5984CD0", VA = "0x185985CD0")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000087")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000088")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x5985C80", Offset = "0x5984C80", VA = "0x185985C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public DAGDFGLMHCJ(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
	public static KBHBMCLJPDE DLCNBHCGPLK(DAGDFGLMHCJ CKMKMNKGMMC)
	{
		return default(KBHBMCLJPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5985B80", Offset = "0x5984B80", VA = "0x185985B80", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(DAGDFGLMHCJ JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface JHLBHNCOIPG
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action GOHDHJFFAEB;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action MDJDJACCEDA;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action FNEPJEPHPPF;
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface HOJKPGCEPEN
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	string PMKAIECIAFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	HOJKPGCEPEN JEIFGCHBLFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	IEnumerable<HOJKPGCEPEN> DINIMAFLIHM
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
[DefaultMember("Item")]
public struct NAJEBGMNODC : IReadOnlyList<KBHBMCLJPDE>, IEnumerable<KBHBMCLJPDE>, IEnumerable, IReadOnlyCollection<KBHBMCLJPDE>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public struct EEGMLJKGLNE : IEnumerator<KBHBMCLJPDE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private readonly GKHJEPNPMDA IEENNNLENFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private NativeArray<LocalId>.Enumerator FOFFMOPCHNJ;

		[Cpp2IlInjected.Token(Token = "0x17000094")]
		public KBHBMCLJPDE DALPLHLAAAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001BF")]
			[Cpp2IlInjected.Address(RVA = "0x5986FA0", Offset = "0x5985FA0", VA = "0x185986FA0", Slot = "4")]
			get
			{
				return default(KBHBMCLJPDE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000095")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C0")]
			[Cpp2IlInjected.Address(RVA = "0x5986EC0", Offset = "0x5985EC0", VA = "0x185986EC0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x20DBD90", Offset = "0x20DAD90", VA = "0x1820DBD90")]
		public EEGMLJKGLNE(GKHJEPNPMDA IEENNNLENFN, NativeArray<LocalId>.Enumerator FOFFMOPCHNJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5986E00", Offset = "0x5985E00", VA = "0x185986E00", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x5986E40", Offset = "0x5985E40", VA = "0x185986E40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5986E80", Offset = "0x5985E80", VA = "0x185986E80", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly GKHJEPNPMDA IEENNNLENFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private NativeArray<LocalId> NCHKOJCIMBJ;

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public KBHBMCLJPDE IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x5992070", Offset = "0x5991070", VA = "0x185992070", Slot = "4")]
		get
		{
			return default(KBHBMCLJPDE);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5991AF0", Offset = "0x5990AF0", VA = "0x185991AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	private int EOGFPFHHPIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public int MGNEPOBDAFO
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x83A6E0", Offset = "0x8396E0", VA = "0x18083A6E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	public bool NGNLIOBNBBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5991BA0", Offset = "0x5990BA0", VA = "0x185991BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	public NativeArray<LocalId> AJFGAHKPFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x20DC5C0", Offset = "0x20DB5C0", VA = "0x1820DC5C0")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000093")]
	internal NativeArray<Entity> JPNADDDIDLC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x5991BE0", Offset = "0x5990BE0", VA = "0x185991BE0")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5991F40", Offset = "0x5990F40", VA = "0x185991F40")]
	public NAJEBGMNODC(int JEBBAFBPNEF, GKHJEPNPMDA IEENNNLENFN, Allocator LEPNDEGMIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x20DB790", Offset = "0x20DA790", VA = "0x1820DB790")]
	public NAJEBGMNODC(GKHJEPNPMDA IEENNNLENFN, NativeArray<LocalId> NCHKOJCIMBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5991ED0", Offset = "0x5990ED0", VA = "0x185991ED0")]
	internal NAJEBGMNODC(GKHJEPNPMDA IEENNNLENFN, NativeArray<Entity> OBBDNLKJJED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x5991FD0", Offset = "0x5990FD0", VA = "0x185991FD0")]
	public NAJEBGMNODC(GKHJEPNPMDA IEENNNLENFN, int GAKMECKICIG, Allocator LEPNDEGMIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x5991E20", Offset = "0x5990E20", VA = "0x185991E20")]
	public NAJEBGMNODC(NAJEBGMNODC LMHAGOOAPIJ, Allocator LEPNDEGMIDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5991B00", Offset = "0x5990B00", VA = "0x185991B00")]
	public NAJEBGMNODC ICJGLKHKIDI(Allocator LEPNDEGMIDH = Allocator.Temp)
	{
		return default(NAJEBGMNODC);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5991AB0", Offset = "0x5990AB0", VA = "0x185991AB0", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5991A20", Offset = "0x5990A20", VA = "0x185991A20")]
	public EEGMLJKGLNE DHFGGODEIOI()
	{
		return default(EEGMLJKGLNE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5991C40", Offset = "0x5990C40", VA = "0x185991C40", Slot = "6")]
	private IEnumerator<KBHBMCLJPDE> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x5991D30", Offset = "0x5990D30", VA = "0x185991D30", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public struct IEHIEBBLKIE : IComparable<IEHIEBBLKIE>, IEquatable<IEHIEBBLKIE>, GDKPDOBOMBP
{
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public const uint GDHNLNOGFGK = 0u;

	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public const uint LJCEPLCOKFK = 255u;

	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public static readonly IEHIEBBLKIE GGJAJAICBCN;

	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private const int KAEIKMDKHBB = 24;

	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private const uint FMBNOBMDAKJ = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private const int IBGHOBBFAOI = 8;

	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private const uint OIJKIJOOFID = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly uint OFGEHNEOBIB;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public uint OOECIIGIEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xB2D090", Offset = "0xB2C090", VA = "0x180B2D090")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	public uint MNHGIJMEOAH
	{
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x598A4E0", Offset = "0x59894E0", VA = "0x18598A4E0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public uint PIJGJIJNJNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x5478E20", Offset = "0x5477E20", VA = "0x185478E20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool DFDLDBBKBNN
	{
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x598A4F0", Offset = "0x59894F0", VA = "0x18598A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x1F26D30", Offset = "0x1F25D30", VA = "0x181F26D30")]
	public static IEHIEBBLKIE MKPLLIKLJNM(uint OFGEHNEOBIB)
	{
		return default(IEHIEBBLKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x598A5D0", Offset = "0x59895D0", VA = "0x18598A5D0")]
	public IEHIEBBLKIE(int MJMOHGGAAEE, int JJPPNPOPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x598A5D0", Offset = "0x59895D0", VA = "0x18598A5D0")]
	public IEHIEBBLKIE(uint MJMOHGGAAEE, int JJPPNPOPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x598A5D0", Offset = "0x59895D0", VA = "0x18598A5D0")]
	public IEHIEBBLKIE(uint MJMOHGGAAEE, uint JJPPNPOPKBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570")]
	private IEHIEBBLKIE(uint OFGEHNEOBIB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x525C1B0", Offset = "0x525B1B0", VA = "0x18525C1B0")]
	public static bool JFBEPFHBCDN(IEHIEBBLKIE CDICEDNOPPN, IEHIEBBLKIE ANCILJKDKHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x525C1C0", Offset = "0x525B1C0", VA = "0x18525C1C0")]
	public static bool NLNNLODOBLO(IEHIEBBLKIE CDICEDNOPPN, IEHIEBBLKIE ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x598A3B0", Offset = "0x59893B0", VA = "0x18598A3B0", Slot = "5")]
	public bool Equals(IEHIEBBLKIE OACHBLHDAOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x598A410", Offset = "0x5989410", VA = "0x18598A410", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x1F350E0", Offset = "0x1F340E0", VA = "0x181F350E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x598A500", Offset = "0x5989500", VA = "0x18598A500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x598A2E0", Offset = "0x59892E0", VA = "0x18598A2E0", Slot = "6")]
	public void BCEEACLIKPE(ref NLKPKBIFPPK EFACDLPILBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x598A340", Offset = "0x5989340", VA = "0x18598A340", Slot = "7")]
	public void BPADPDDPOEA(ref AFABOODPCMI NMOOAPLNEFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x598A3A0", Offset = "0x59893A0", VA = "0x18598A3A0", Slot = "4")]
	public int CompareTo(IEHIEBBLKIE JONIFABKCAI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface OBAGCOKNPCI
{
	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJCCOOFLIIE(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKFDLJBJOPP(Entity OIDNDCEGFCN, in float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 NDNODELJNJN(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void DAFIJFDJPPL(Entity OIDNDCEGFCN, in quaternion CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion ADKNAIHHGLC(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void DJIPMNPLCNE(Entity OIDNDCEGFCN, in float3 EDEGPGKBEGA, in quaternion DEANJFCCEBG);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HOFFHOKNJAI(Entity OIDNDCEGFCN, out float3 EDEGPGKBEGA, out quaternion DEANJFCCEBG);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void HOFFHOKNJAI(Entity OIDNDCEGFCN, out RigidTransform IFDCCOPBCIL);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void AEIDDJIBELH(Entity OIDNDCEGFCN, in float3 EDEGPGKBEGA, in quaternion DEANJFCCEBG);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void PODMKMCGJIJ(Entity OIDNDCEGFCN, out RigidTransform IFDCCOPBCIL);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	float3 KENGJPKJCLH(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void INLHEJMCEEO(Entity OIDNDCEGFCN, in float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KGAKGPPJMGN(Entity OIDNDCEGFCN, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float DMGNMNJGCEO(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void NJKLLGDGLGJ(Entity OIDNDCEGFCN, in float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BKMACODGIAB(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void EHPHOJIDLHH(Entity OIDNDCEGFCN, in float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	float3 CMGLNIJABJA(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	void FEHCLKJNEGA(Entity OIDNDCEGFCN, in quaternion CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	quaternion ILNNJLFPEDK(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 CJFACCEHLOF(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void GFMIOOMKKAM(Entity OIDNDCEGFCN, in float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void DCEFNFDNJPD(Entity OIDNDCEGFCN, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float FGLAEAOFAJO(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void LKNMDOAPBKK(Entity OIDNDCEGFCN, in float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float3 MEKPLDOEDBG(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void GNGADEAHLDH(Entity OIDNDCEGFCN, out float4x4 GCJFKHONGAM);

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void OGNLOEDCFEA(Entity OIDNDCEGFCN, in float4x4 GCJFKHONGAM);

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void OGAGDPFIFMP(Entity OIDNDCEGFCN, out float4x4 GCJFKHONGAM);

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(Slot = "29")]
	bool NMHNJFECBHC(Entity OIDNDCEGFCN, out Transform CEKKPPPNLGM);

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void NFDIHDHJEJF(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void NEBFHCNKDAA(Entity OIDNDCEGFCN, Entity EIEGFGAKPJF, Entity COLDPDBGEPD);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class NMHOADCMKJK
{
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct FGOILOCCGAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly IEnumerable<GOAOJMCEMIL> KAOFJLCFHON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private readonly IReadOnlyList<GameObject> JPEJCOLPFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly IReadOnlyList<int> ABCIAFICLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly IReadOnlyList<(IEHIEBBLKIE, IEHIEBBLKIE)> JBEEDADNGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly int PCDJAPLIOKH;

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public bool FHMCEOPEFNK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5987540", Offset = "0x5986540", VA = "0x185987540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	public int LNEDDNKINKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0xA74E00", Offset = "0xA73E00", VA = "0x180A74E00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009D")]
	public IEnumerable<GameObject> HJCMIGFHCOC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x9CAB70", Offset = "0x9C9B70", VA = "0x1809CAB70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009E")]
	public IEnumerable<(IEHIEBBLKIE src, IEHIEBBLKIE dst)> BHMGEAELDJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x59875A0", Offset = "0x59865A0", VA = "0x1859875A0")]
	public FGOILOCCGAF(IEnumerable<GOAOJMCEMIL> KAOFJLCFHON, IReadOnlyList<GameObject> JPEJCOLPFBB, IReadOnlyList<int> ABCIAFICLPA, IReadOnlyList<(IEHIEBBLKIE src, IEHIEBBLKIE dst)> JBEEDADNGAO, int PCDJAPLIOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x5987190", Offset = "0x5986190", VA = "0x185987190")]
	public (GameObject, int)[] EJPECNLOAIF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct AKDCLPGGBEC : IEquatable<AKDCLPGGBEC>
{
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly AKDCLPGGBEC NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	private IALNCAKHEIO CECBFENHNKB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x5984B30", Offset = "0x5983B30", VA = "0x185984B30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public NAJEBGMNODC NDBHDLMAAPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5984F40", Offset = "0x5983F40", VA = "0x185984F40")]
		get
		{
			return default(NAJEBGMNODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public IEnumerable<INJFODOHFLJ> JFOFPJFPFIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5985040", Offset = "0x5984040", VA = "0x185985040")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public IEnumerable<INJFODOHFLJ> BONBJMCLOOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x59851C0", Offset = "0x59841C0", VA = "0x1859851C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public int AKPHHHCJJCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5984810", Offset = "0x5983810", VA = "0x185984810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int AHFDMGADHEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5984CA0", Offset = "0x5983CA0", VA = "0x185984CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public string EDEDJHKMHBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5984A70", Offset = "0x5983A70", VA = "0x185984A70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public GBLIEAMGDBF MELDPMIFMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5984960", Offset = "0x5983960", VA = "0x185984960")]
		get
		{
			return default(GBLIEAMGDBF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5984600", Offset = "0x5983600", VA = "0x185984600")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	public PPGBMALCNDL NPPMHLLABLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x59849C0", Offset = "0x59839C0", VA = "0x1859849C0")]
		get
		{
			return default(PPGBMALCNDL);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x59848F0", Offset = "0x59838F0", VA = "0x1859848F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public bool KDECMOHGFOP
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5984F20", Offset = "0x5983F20", VA = "0x185984F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public bool JJOFKMNCMDD
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5984C80", Offset = "0x5983C80", VA = "0x185984C80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public bool CONFFDMMHBK
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x5984520", Offset = "0x5983520", VA = "0x185984520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public bool AGJIMIFFJIA
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x5984F00", Offset = "0x5983F00", VA = "0x185984F00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public bool OBNBCENILFC
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x5984C70", Offset = "0x5983C70", VA = "0x185984C70")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x59845F0", Offset = "0x59835F0", VA = "0x1859845F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public bool LJIGABBECKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x5984340", Offset = "0x5983340", VA = "0x185984340")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x59851B0", Offset = "0x59841B0", VA = "0x1859851B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021E")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public MMLPFHHOIHM NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MMLPFHHOIHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public MEOAMGBKKIO AOPFCIHOLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MEOAMGBKKIO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5984A20", Offset = "0x5983A20", VA = "0x185984A20")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
	public static INJFODOHFLJ DLCNBHCGPLK(AKDCLPGGBEC LADPAJPBFMP)
	{
		return default(INJFODOHFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x5984350", Offset = "0x5983350", VA = "0x185984350")]
	public bool BOAOMFCBMPE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x5984BB0", Offset = "0x5983BB0", VA = "0x185984BB0")]
	public bool JBEKOCHMGNH(CBGHKCPAMPK MCOHAKACPKD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x5984570", Offset = "0x5983570", VA = "0x185984570")]
	public void EALFGJOJEPM(CBGHKCPAMPK MCOHAKACPKD, bool CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5984CF0", Offset = "0x5983CF0", VA = "0x185984CF0")]
	public NAJEBGMNODC LAOMBMAFKED(Allocator LEPNDEGMIDH)
	{
		return default(NAJEBGMNODC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x5984370", Offset = "0x5983370", VA = "0x185984370")]
	public void CCLPEFMPOEC(AKDCLPGGBEC JONIFABKCAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public AKDCLPGGBEC(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(AKDCLPGGBEC CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x5984670", Offset = "0x5983670", VA = "0x185984670", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(AKDCLPGGBEC JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public readonly struct NFFAMJNDHLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	internal readonly ENBGBPNNKJB MAKGFFNPBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	internal readonly ENBGBPNNKJB HKJNHGFOJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	internal readonly uint HCJMLKAGPFA;

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x59920B0", Offset = "0x59910B0", VA = "0x1859920B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public readonly struct OHNOIIMDCBH
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	internal readonly NFFAMJNDHLN NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5985870", Offset = "0x5984870", VA = "0x185985870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public readonly struct CNDOJONIDMG
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static readonly FACALIAHOGE IHHCPPEACEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	internal readonly NFFAMJNDHLN NPNCNABHINE;

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x5985870", Offset = "0x5984870", VA = "0x185985870", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct JKAFDMONHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	internal readonly uint HCJMLKAGPFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	internal readonly bool MANKOACMIMI;

	[Cpp2IlInjected.Token(Token = "0x600022D")]
	[Cpp2IlInjected.Address(RVA = "0x598BA30", Offset = "0x598AA30", VA = "0x18598BA30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface GJAFPLOBCJA
{
	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HECJGEJMPLP(KBHBMCLJPDE AAGHLALAEIJ, PIJECNBFEGJ CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	PIJECNBFEGJ DLNNMNPJOMK(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void DCILHALKLLL(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PHHBPNCHAMJ(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LLADCDDCECO(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KBHBMCLJPDE IPKEMJPIPGO(KBHBMCLJPDE AAGHLALAEIJ, int EJNMEMKEIOD);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FKDENJCMMLE(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void JODIIHFNFHB(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC, KBHBMCLJPDE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HAHBEPNBPOI(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool MKPEIOEAHAI(KBHBMCLJPDE AAGHLALAEIJ, out KBHBMCLJPDE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void MIEMCIHFAMB(KBHBMCLJPDE AAGHLALAEIJ, float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool HONMNABDFOG(KBHBMCLJPDE AAGHLALAEIJ, out float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JHOOCJNGKNM(KBHBMCLJPDE AAGHLALAEIJ, float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool NAFFGHGJPCH(KBHBMCLJPDE AAGHLALAEIJ, out float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void DFDJCPBGCPC(KBHBMCLJPDE AAGHLALAEIJ, (Quaternion rot, Vector3 moments) DJHFDNAEBGF);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool JMNPAJIABAN(KBHBMCLJPDE AAGHLALAEIJ, out quaternion FIMLLHIBIOI, out float3 EPFGOOLLIDC);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DDHICILPDMB(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void ENPBGALNDLA(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 ELOLJNAONFH(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 PHKCKGJFIIP(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void BAIHNMBNODH(KBHBMCLJPDE AAGHLALAEIJ, float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "21")]
	bool IJMKJMJKCJN(KBHBMCLJPDE AAGHLALAEIJ, out float3 CLDFCFBJAIJ);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void FJBIEFODPGD(KBHBMCLJPDE AAGHLALAEIJ, float3 CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void KBPDJNJKOOD(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "24")]
	float FIPJMFGBLHD(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "25")]
	float NMDEIJGCCKA(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void AGNBCADBCOP(KBHBMCLJPDE AAGHLALAEIJ, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool LDNBHHJNCBC(KBHBMCLJPDE AAGHLALAEIJ, out float AJCOFMJAECD);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HIFJJBIFAIF(KBHBMCLJPDE AAGHLALAEIJ, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "29")]
	CollisionDetectionMode EEIOOHHDAOH(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void DGCCFJGKBMH(KBHBMCLJPDE AAGHLALAEIJ, CollisionDetectionMode CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "31")]
	OOPINJNCOHE NCGJCNNHEKO(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void AODDPMDBMIK(KBHBMCLJPDE AAGHLALAEIJ, OOPINJNCOHE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "33")]
	bool JCJJKAEFEPP(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "34")]
	void PLODLEMEAFH(KBHBMCLJPDE AAGHLALAEIJ, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "35")]
	KBHBMCLJPDE KFFGCBOPHHL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "36")]
	void NGDNACJDLLN(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "37")]
	KBHBMCLJPDE GPAHLJAOGGF(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "38")]
	void LMENPCDIGEL(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "39")]
	HLLHIAHOMMI GOOAFONPFPL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "40")]
	void GAJHPDOAMLM(KBHBMCLJPDE AAGHLALAEIJ, HLLHIAHOMMI DJKIFAPPBPA);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "41")]
	bool DPGEHOICCDB(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "42")]
	void LFFDLMNEMBC(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "43")]
	bool LLHHGKANKAI(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "44")]
	void GLMLCGBCFPH(KBHBMCLJPDE AAGHLALAEIJ, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "45")]
	bool JGJPEELEKFB(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "46")]
	void OKMDDELLPNO(KBHBMCLJPDE AAGHLALAEIJ, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "47")]
	RigidbodyConstraints HEJOHCKDLDG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "48")]
	void EMGILICGOAO(KBHBMCLJPDE AAGHLALAEIJ, RigidbodyConstraints CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "49")]
	float HEPAHDIPDJG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "50")]
	void OHHCEOLNLHL(KBHBMCLJPDE AAGHLALAEIJ, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "51")]
	float AKFIFHEAFFF(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "52")]
	void FCBOBCHMMPP(KBHBMCLJPDE AAGHLALAEIJ, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "53")]
	bool AJNIKDFEHHG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void CHHOOCIGOHC(KBHBMCLJPDE AAGHLALAEIJ, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "55")]
	bool EOJGIEFGBGL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void NMLBFAOPBNG(KBHBMCLJPDE AAGHLALAEIJ, bool CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "57")]
	int EHHLEJMEFPG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void GAEHMJIPOBI(KBHBMCLJPDE AAGHLALAEIJ, int CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "59")]
	object NEHNPACHOHA(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void IICNPANPJMC(KBHBMCLJPDE AAGHLALAEIJ, object CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "61")]
	object FKGLKCDPGBE(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void HKICFNGLDFC(KBHBMCLJPDE AAGHLALAEIJ, object CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "63")]
	float BKKPEHAAFIA(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void IOEAJNBGOAE(KBHBMCLJPDE AAGHLALAEIJ, float CKMKMNKGMMC);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void IBNAJKJOCPL(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "66")]
	void GCMAHPBBOAN(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool CLLGAELIEGF(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "68")]
	void OBLAFHPLIJF(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void LCGBGOBCAJA(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "70")]
	bool EKGPEOCINCA(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "71")]
	bool FNGHPHKABBL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "72")]
	Rigidbody HKEICJCNPHP(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void DFFFMJDABNE(KBHBMCLJPDE AAGHLALAEIJ, Rigidbody GMKHAHOBJGG);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void KHFFFCKDFKC(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "75")]
	void LEPHDJGCOHN(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool LONFDGPEECO(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "77")]
	void LNBLFEIDCIL(KBHBMCLJPDE AAGHLALAEIJ, float3 CBPBBILDPPH);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void LEONFIOCKLP(KBHBMCLJPDE AAGHLALAEIJ, float3 NJBJCPFKCBL);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "79")]
	bool AFLJNNAOPAN(KBHBMCLJPDE AAGHLALAEIJ, out float3 CBPBBILDPPH);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "80")]
	bool INNIGNGDBEN(KBHBMCLJPDE AAGHLALAEIJ, out float3 NJBJCPFKCBL);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool CKANPFJAFEF(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "82")]
	void IJFNIKCDCIK(KBHBMCLJPDE AAGHLALAEIJ, object DMHDKAFNNAC, bool CLCDDMLICOJ);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "83")]
	void CMDGNDMBDGM(KBHBMCLJPDE AAGHLALAEIJ, bool DDBPMHEJBMG);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "84")]
	void COJLDIPLEMJ(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "85")]
	bool CEJBCFHDKJB(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "86")]
	IEnumerable<object> AEMPKEAAPKM(KBHBMCLJPDE AAGHLALAEIJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface FFFBLJILCOH
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NELIMFLJOBF(Entity LJKGFDNAIFM);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void JNPEHLLBCKO(Entity LJKGFDNAIFM);
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct IJIODPDDOHH : IEquatable<IJIODPDDOHH>
{
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public static readonly IJIODPDDOHH NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public string CKPNJKGCAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x598A6E0", Offset = "0x59896E0", VA = "0x18598A6E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public string LFCKPENEAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x598A920", Offset = "0x5989920", VA = "0x18598A920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public IJIODPDDOHH(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x598A5E0", Offset = "0x59895E0", VA = "0x18598A5E0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(IJIODPDDOHH JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
public readonly struct PMFANDGGPOM : IEquatable<PMFANDGGPOM>
{
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public static readonly PMFANDGGPOM NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000294")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(RVA = "0x5995330", Offset = "0x5994330", VA = "0x185995330", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(PMFANDGGPOM JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public readonly struct GFPFEOADMOB : IEquatable<GFPFEOADMOB>
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public static readonly GFPFEOADMOB NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	private MFAKJFKEOLG BPAOIGPFBHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000296")]
		[Cpp2IlInjected.Address(RVA = "0x5988E70", Offset = "0x5987E70", VA = "0x185988E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public bool BCFJAPAPBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600029A")]
		[Cpp2IlInjected.Address(RVA = "0x5988D60", Offset = "0x5987D60", VA = "0x185988D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	public bool CBJFCMPMJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600029B")]
		[Cpp2IlInjected.Address(RVA = "0x59891D0", Offset = "0x59881D0", VA = "0x1859891D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	public bool KMMIPMPJJNM
	{
		[Cpp2IlInjected.Token(Token = "0x600029C")]
		[Cpp2IlInjected.Address(RVA = "0x5988E40", Offset = "0x5987E40", VA = "0x185988E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	public bool HPIOFCKDFKC
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x5988CD0", Offset = "0x5987CD0", VA = "0x185988CD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	public bool BCHPLECELKM
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x5988EF0", Offset = "0x5987EF0", VA = "0x185988EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	public bool OIEHHLGNGDH
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x5988FE0", Offset = "0x5987FE0", VA = "0x185988FE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	public bool AFLFLGBJMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x5988960", Offset = "0x5987960", VA = "0x185988960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x5988D10", Offset = "0x5987D10", VA = "0x185988D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000297")]
	[Cpp2IlInjected.Address(RVA = "0x5988BA0", Offset = "0x5987BA0", VA = "0x185988BA0")]
	public bool DKOKMODAGAH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000298")]
	[Cpp2IlInjected.Address(RVA = "0x5988800", Offset = "0x5987800", VA = "0x185988800")]
	public INJFODOHFLJ BHAKGPMACOG(INJFODOHFLJ EEMPMGBFHEC)
	{
		return default(INJFODOHFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000299")]
	[Cpp2IlInjected.Address(RVA = "0x5988640", Offset = "0x5987640", VA = "0x185988640")]
	public KBHBMCLJPDE BDENMDLBHFF()
	{
		return default(KBHBMCLJPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A1")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public GFPFEOADMOB(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(GFPFEOADMOB CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x5988BD0", Offset = "0x5987BD0", VA = "0x185988BD0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(GFPFEOADMOB JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public struct GBJAHOLHFPP : IComparable<GBJAHOLHFPP>, IEquatable<GBJAHOLHFPP>
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public static readonly GBJAHOLHFPP GGJAJAICBCN;

	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public static readonly GBJAHOLHFPP DHKACCHAELC;

	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public static readonly GBJAHOLHFPP EODIMOHGNEM;

	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public static readonly GBJAHOLHFPP MLBEHFANLPF;

	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly GBJAHOLHFPP HFEOBMEPMKI;

	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public static readonly GBJAHOLHFPP BMFMOPPHPPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public int EHPNNEFNFPF;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	public bool HOKNAJDJINH
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x59884A0", Offset = "0x59874A0", VA = "0x1859884A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public int BLDMFMDNIFL
	{
		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0x59884B0", Offset = "0x59874B0", VA = "0x1859884B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570")]
	public GBJAHOLHFPP(int EJNMEMKEIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(RVA = "0x5988430", Offset = "0x5987430", VA = "0x185988430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B0")]
	[Cpp2IlInjected.Address(RVA = "0x59883A0", Offset = "0x59873A0", VA = "0x1859883A0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B1")]
	[Cpp2IlInjected.Address(RVA = "0x3FED3C0", Offset = "0x3FEC3C0", VA = "0x183FED3C0", Slot = "5")]
	public bool Equals(GBJAHOLHFPP JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0x5988390", Offset = "0x5987390", VA = "0x185988390", Slot = "4")]
	public int CompareTo(GBJAHOLHFPP JONIFABKCAI)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x1F26D30", Offset = "0x1F25D30", VA = "0x181F26D30")]
	public static GBJAHOLHFPP DLCNBHCGPLK(int EJNMEMKEIOD)
	{
		return default(GBJAHOLHFPP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x1F26D30", Offset = "0x1F25D30", VA = "0x181F26D30")]
	public static int DLCNBHCGPLK(GBJAHOLHFPP LPLLLEEIELD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x59884C0", Offset = "0x59874C0", VA = "0x1859884C0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
[DefaultMember("Item")]
public interface OBMDHBIJGLJ : IEnumerable<NEKCPPCFKIK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	NEKCPPCFKIK IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	NEKCPPCFKIK EFGFLBDCIBO(EOOMHOMHJOF HBOAIEOOPAF);

	[Cpp2IlInjected.Token(Token = "0x60002BA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBJAHOLHFPP OPLBINNFJPI(EOOMHOMHJOF HBOAIEOOPAF);
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public static class MKHAHGHIMLH
{
	[Cpp2IlInjected.Token(Token = "0x60002BB")]
	public static LHDMIDAMFOC<T> EFGFLBDCIBO<T>(this OBMDHBIJGLJ KDNJIKBJJJJ, EOOMHOMHJOF OKONKHNEMOO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BC")]
	[Cpp2IlInjected.Address(RVA = "0x116A810", Offset = "0x1169810", VA = "0x18116A810")]
	public static GBJAHOLHFPP OPLBINNFJPI<T>(this OBMDHBIJGLJ KDNJIKBJJJJ, BNAHOABKGKK<T> OKONKHNEMOO) where T : struct
	{
		return default(GBJAHOLHFPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface IBBKFEOICPE
{
	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool OMIHADLKEII(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OJEILHCJPNB(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool FAAJPEGIDLL(KBHBMCLJPDE AAGHLALAEIJ, out Guid DIGKBLFDPPL);

	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CJOMHAIAELK(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FDAFODMOBJG(KBHBMCLJPDE AAGHLALAEIJ, Guid DIGKBLFDPPL);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool HBKCPKBHABH(KBHBMCLJPDE AAGHLALAEIJ, out Guid DHKAFFPFMFL);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid DJDFHIELKLO(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PMDPKOJGOHC(KBHBMCLJPDE AAGHLALAEIJ, Guid DHKAFFPFMFL);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OJKGKCFPHBD(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void DDGAAKJJOKJ(KBHBMCLJPDE CJCAJMJJJKE, KBHBMCLJPDE AGFCJPGACCB);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface LHCMCJOPDME
{
	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OOALHIENLFO(KBHBMCLJPDE ABAAGAOADBF, bool CKMKMNKGMMC);
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public readonly struct KBHFCCOOFEB : IEquatable<KBHFCCOOFEB>
{
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public static readonly KBHFCCOOFEB NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public OFOPFBNBGHA OOPGCGOHEMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(OFOPFBNBGHA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	private MIBNDKDIOFF KLGAANJOEJI
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0x598C7A0", Offset = "0x598B7A0", VA = "0x18598C7A0")]
		get
		{
			return default(MIBNDKDIOFF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public LCMPCAIJMDL GIAGOPFJACJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0x598C800", Offset = "0x598B800", VA = "0x18598C800")]
		get
		{
			return default(LCMPCAIJMDL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CB")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public KBHFCCOOFEB(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002CD")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(KBHFCCOOFEB CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002CF")]
	[Cpp2IlInjected.Address(RVA = "0x598C6A0", Offset = "0x598B6A0", VA = "0x18598C6A0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(KBHFCCOOFEB JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface GJNFIBBKHGJ
{
	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BFBJNLNCBLI(KBHBMCLJPDE AAGHLALAEIJ, GBLIEAMGDBF PPOIIGLEIPI, bool PFOBFJJHOLK, CBGHKCPAMPK JLMEMDBLEMK);

	[Cpp2IlInjected.Token(Token = "0x60002D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void LAGFAFCCFEC(KBHBMCLJPDE AAGHLALAEIJ, GBLIEAMGDBF PPOIIGLEIPI, bool PFOBFJJHOLK, bool KGOPIKFEEBM, bool CKLPFPFDHEA);

	[Cpp2IlInjected.Token(Token = "0x60002D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LGBMKNDKANC AGLCHNKMPJD(KBHBMCLJPDE FMNCHFNIOHH, List<KBHBMCLJPDE> GCIKFJHPIBE);

	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NCFPGDBEGNJ(GameObject IEHJLCCMNNP, GameObject CEHJMFJDBPG);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FCCJDOKLFJI(GameObject CEHJMFJDBPG);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T NLHLMFDOCAO<T>(GameObject HNGBOFFGPMC) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void HGKGHGKCKIK(Collider HJBJFCKNGEN);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject MGBBBPDGGOH<T>(string OKONKHNEMOO) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface LLABMBFFKBG
{
	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	IReadOnlyCollection<OLGNLABKOLK> EFALADHKMAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002DC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KIBHAJFGHBN(int BKAKEAMNOAC, out OLGNLABKOLK JEBLAHHKGAB);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "2")]
	OLGNLABKOLK FJDCPNCNMAM(Type FLAJIGGIBOB);
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public static class IGAKAACLPKP
{
	[Cpp2IlInjected.Token(Token = "0x60002DF")]
	[Cpp2IlInjected.Address(RVA = "0x1896930", Offset = "0x1895930", VA = "0x181896930")]
	public static T ILHKMIJEONN<T>(this LLABMBFFKBG KDAHCFIKGDL, Entity OIDNDCEGFCN) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(RVA = "0x1895D50", Offset = "0x1894D50", VA = "0x181895D50")]
	public static OLGNLABKOLK FJDCPNCNMAM<T>(this LLABMBFFKBG KDAHCFIKGDL) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface GOKMJAEOJOF
{
	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	bool HFIGPCOJDMM
	{
		[Cpp2IlInjected.Token(Token = "0x60002E1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x60002E2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface HMOIPICELDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	bool HKDOMOPGENP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	bool AHKCDEKBBMP
	{
		[Cpp2IlInjected.Token(Token = "0x60002E4")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	KIFNIJEONMJ CJACDDKKAFI
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	POJIKPFFFCH NLEIFCPOICN(bool PHMOJHNKBCF = false);

	[Cpp2IlInjected.Token(Token = "0x60002E8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	POJIKPFFFCH ACIHAKPOPGP(IEnumerable<KBHBMCLJPDE> NCHKOJCIMBJ, in EEELCFJDAIJ LBKNLFBBCGA);

	[Cpp2IlInjected.Token(Token = "0x60002E9")]
	[Cpp2IlInjected.Address(Slot = "6")]
	CPANGDPPGIH JMIFAHNGCDD(ByteString LJAOINODNKO);

	[Cpp2IlInjected.Token(Token = "0x60002EA")]
	[Cpp2IlInjected.Address(Slot = "7")]
	DEKCEGABIGO LDCEEFACHBH(ByteString AOBDCPLDMJI, KBHBMCLJPDE AGFCJPGACCB, in EEELCFJDAIJ OLGDKHDODNC, PBLOANBKGFN HABBODBJJJB, bool ECKBHMMDNLC = true);

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NHCPOILAINA();

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void FDEPOFDNNDP(bool CHPJMBDOCOE);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "10")]
	FGOILOCCGAF KEEFPINANDA(IEnumerable<GOAOJMCEMIL> KAOFJLCFHON);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class LLEGDHIAJIH
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface HCLKLIGCIOD : BIJHFKLONOM, IBIIHCPLHGH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	bool BLPCIPDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	OCMNDCMIJAL OAEIBKHDOED
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	OOONJFBBMMC FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	FKGJPPBFGFB HBMHFKHCOCP
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface IBIIHCPLHGH
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	bool MGEHPDCHGGK
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface IKLIOIFCPLL
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool NFBGLIHIEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface DBKOLCBICAP
{
	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	Guid MIPPIHIMCBC
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MPLAGGOPPDB(Guid DIGKBLFDPPL, Guid DHKAFFPFMFL, string OKONKHNEMOO);
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public struct ENBGBPNNKJB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	internal int OBKOEDDJOMJ;

	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(RVA = "0x5987130", Offset = "0x5986130", VA = "0x185987130", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public static class PEDLJIMFNLD
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	private struct GNLHNKLENNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public Guid AGKIPDJPNCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public FKIDIGCADIC DJFFIEBJLHM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct FKIDIGCADIC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public int CKMKMNKGMMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public int ACJHPEKLEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public int FGICKLPLBHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public int EJNBIHCJPJG;

		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(RVA = "0x59882D0", Offset = "0x59872D0", VA = "0x1859882D0")]
		public bool MIDNJIDJHHG(out IEHIEBBLKIE DELHFMHNJCM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002FB")]
		[Cpp2IlInjected.Address(RVA = "0x5988370", Offset = "0x5987370", VA = "0x185988370")]
		public FKIDIGCADIC(IEHIEBBLKIE DELHFMHNJCM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002F8")]
	[Cpp2IlInjected.Address(RVA = "0x5994880", Offset = "0x5993880", VA = "0x185994880")]
	public static Guid MHKKPFLPKEO(this IEHIEBBLKIE DELHFMHNJCM)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002F9")]
	[Cpp2IlInjected.Address(RVA = "0x5994860", Offset = "0x5993860", VA = "0x185994860")]
	public static bool ANAEHCANOEM(this Guid AGKIPDJPNCN, out IEHIEBBLKIE DELHFMHNJCM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
[DebuggerTypeProxy(typeof(NEDFKCHHGON))]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
public readonly struct KBHBMCLJPDE : IComparable<KBHBMCLJPDE>, IEquatable<KBHBMCLJPDE>
{
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public static readonly KBHBMCLJPDE GGJAJAICBCN;

	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	public GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60002FC")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	public LocalId GPJBHKAJAHP
	{
		[Cpp2IlInjected.Token(Token = "0x60002FD")]
		[Cpp2IlInjected.Address(RVA = "0x9CAB70", Offset = "0x9C9B70", VA = "0x1809CAB70")]
		[CompilerGenerated]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	public bool GDIDPFMABMA
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x598C200", Offset = "0x598B200", VA = "0x18598C200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	public bool KNPBFPKDMMO
	{
		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x598C500", Offset = "0x598B500", VA = "0x18598C500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	public bool DDJKLMEMPFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x598C330", Offset = "0x598B330", VA = "0x18598C330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000301")]
	[Cpp2IlInjected.Address(RVA = "0x598C620", Offset = "0x598B620", VA = "0x18598C620")]
	public KBHBMCLJPDE(GKHJEPNPMDA BDLCBEBBJAD, LocalId AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000302")]
	[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
	public INJFODOHFLJ OLLEFPGKBGG()
	{
		return default(INJFODOHFLJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000303")]
	[Cpp2IlInjected.Address(RVA = "0x9CAB70", Offset = "0x9C9B70", VA = "0x1809CAB70")]
	public static LocalId DLCNBHCGPLK(KBHBMCLJPDE KENPKKIPBLK)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000304")]
	[Cpp2IlInjected.Address(RVA = "0x598C350", Offset = "0x598B350", VA = "0x18598C350")]
	public static Entity DLCNBHCGPLK(KBHBMCLJPDE KENPKKIPBLK)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000305")]
	[Cpp2IlInjected.Address(RVA = "0x598C410", Offset = "0x598B410", VA = "0x18598C410")]
	public static bool JFBEPFHBCDN(KBHBMCLJPDE CDICEDNOPPN, KBHBMCLJPDE ANCILJKDKHM)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x598C460", Offset = "0x598B460", VA = "0x18598C460")]
	public static bool NLNNLODOBLO(KBHBMCLJPDE CDICEDNOPPN, KBHBMCLJPDE ANCILJKDKHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x598C520", Offset = "0x598B520", VA = "0x18598C520", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x598C360", Offset = "0x598B360", VA = "0x18598C360", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x598C2D0", Offset = "0x598B2D0", VA = "0x18598C2D0", Slot = "4")]
	public int CompareTo(KBHBMCLJPDE JONIFABKCAI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "5")]
	public bool Equals(KBHBMCLJPDE JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
public static class AMBNOCNBLGD
{
	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5985380", Offset = "0x5984380", VA = "0x185985380")]
	public static IEHIEBBLKIE HGGBEKODJDK(this KBHBMCLJPDE DCGPCJKHCOO)
	{
		return default(IEHIEBBLKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x1B3C700", Offset = "0x1B3B700", VA = "0x181B3C700")]
	public static T LOJMFOOEGIL<T>(this KBHBMCLJPDE DCGPCJKHCOO) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
internal sealed class NEDFKCHHGON
{
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface FLMCOMAFMDP
{
	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	bool BLPCIPDEODE
	{
		[Cpp2IlInjected.Token(Token = "0x600030F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FJOEOCBDDOD(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000311")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FKODKJCDMNN(KBHBMCLJPDE AAGHLALAEIJ, bool PFOBFJJHOLK, bool KGOPIKFEEBM, bool DGFAACNGHNI);
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public readonly struct ECGLMGAMPCE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly NAJEBGMNODC HHLBFMJDBAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly NativeArray<byte> LPGJFKDBDFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly NativeArray<byte> AHNDJFCGOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly GBJAHOLHFPP LPLLLEEIELD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly int OBKDFKHFEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly Type KLAELDCOIAD;

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	public NAJEBGMNODC LOGBGMBOCLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000313")]
		[Cpp2IlInjected.Address(RVA = "0x18599A0", Offset = "0x18589A0", VA = "0x1818599A0")]
		get
		{
			return default(NAJEBGMNODC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5986D90", Offset = "0x5985D90", VA = "0x185986D90")]
	public ECGLMGAMPCE(NAJEBGMNODC HHLBFMJDBAG, NativeArray<byte> LPGJFKDBDFN, NativeArray<byte> AHNDJFCGOOD, GBJAHOLHFPP LPLLLEEIELD, int OBKDFKHFEID, Type KLAELDCOIAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000314")]
	[Cpp2IlInjected.Address(RVA = "0x2576580", Offset = "0x2575580", VA = "0x182576580")]
	public NativeArray<T> FNJMLMFOILC<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(RVA = "0x25765C0", Offset = "0x25755C0", VA = "0x1825765C0")]
	public NativeArray<T> PFDKBLJJJNI<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(RVA = "0x2576460", Offset = "0x2575460", VA = "0x182576460")]
	public (NAJEBGMNODC, NativeArray<T>, NativeArray<T>) EAOPAIAIDNN<T>() where T : struct
	{
		return default((NAJEBGMNODC, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5986CF0", Offset = "0x5985CF0", VA = "0x185986CF0")]
	public HFOKKNDJCPG COLFCBAFAMO()
	{
		return default(HFOKKNDJCPG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct OEEKBAOFEGI : IEquatable<OEEKBAOFEGI>
{
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static readonly OEEKBAOFEGI NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600031C")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000322")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	private IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000323")]
		[Cpp2IlInjected.Address(RVA = "0x5992FC0", Offset = "0x5991FC0", VA = "0x185992FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000318")]
	[Cpp2IlInjected.Address(RVA = "0x5993010", Offset = "0x5992010", VA = "0x185993010")]
	public void KGPHBDINNEF(bool CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x5992D80", Offset = "0x5991D80", VA = "0x185992D80")]
	public void DMEDIGOLNLP(bool CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2927E00", Offset = "0x2926E00", VA = "0x182927E00")]
	public T EHGHEKKMIFK<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public OEEKBAOFEGI(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5992EC0", Offset = "0x5991EC0", VA = "0x185992EC0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(OEEKBAOFEGI JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct HDFGBLCMAAI : IEquatable<HDFGBLCMAAI>
{
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public static readonly HDFGBLCMAAI NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000329")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000326")]
	[Cpp2IlInjected.Address(RVA = "0x5989B90", Offset = "0x5988B90", VA = "0x185989B90", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000327")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(HDFGBLCMAAI JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000328")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface BHBAGGMELAE
{
	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	LCGFFEKNDGA PFFENKFACGE
	{
		[Cpp2IlInjected.Token(Token = "0x600032B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	LCGFFEKNDGA POEFMBBCCAO
	{
		[Cpp2IlInjected.Token(Token = "0x600032C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	LCGFFEKNDGA ICJGLKHKIDI
	{
		[Cpp2IlInjected.Token(Token = "0x600032D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	LCGFFEKNDGA GADPEMKDBNF
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	LCGFFEKNDGA MBECILMMIIA
	{
		[Cpp2IlInjected.Token(Token = "0x600032F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	LCGFFEKNDGA DMMGJKAGHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	LCGFFEKNDGA HNIJPGDFPNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public struct DALHMOFBJNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float KOCGFDLBEIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 MJKKHJFHAJH;
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public readonly struct OFOPFBNBGHA : IEquatable<OFOPFBNBGHA>
{
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public static readonly OFOPFBNBGHA NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	private IJIMBONFCGO OMJHCBNFKBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(RVA = "0x5993440", Offset = "0x5992440", VA = "0x185993440")]
		get
		{
			return default(IJIMBONFCGO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public AJOLFBKOACA OMKPDFHDHOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(RVA = "0x59935B0", Offset = "0x59925B0", VA = "0x1859935B0")]
		get
		{
			return default(AJOLFBKOACA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	public DCPBFKNCIAG GPGDIIAIDBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(RVA = "0x5993930", Offset = "0x5992930", VA = "0x185993930")]
		get
		{
			return default(DCPBFKNCIAG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	public MBBEKNLKNNA PLDAHOHNMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(RVA = "0x5993610", Offset = "0x5992610", VA = "0x185993610")]
		get
		{
			return default(MBBEKNLKNNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public GKLMLALBKLC LMAKNALJNMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(RVA = "0x5993A00", Offset = "0x5992A00", VA = "0x185993A00")]
		get
		{
			return default(GKLMLALBKLC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	public LACKHBHGPHL KNBPAEHNMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5993C20", Offset = "0x5992C20", VA = "0x185993C20")]
		get
		{
			return default(LACKHBHGPHL);
		}
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5993AF0", Offset = "0x5992AF0", VA = "0x185993AF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	public CLFDMPLLJFG DKPLEGBPFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x5993B60", Offset = "0x5992B60", VA = "0x185993B60")]
		get
		{
			return default(CLFDMPLLJFG);
		}
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x59936F0", Offset = "0x59926F0", VA = "0x1859936F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	public float JOKCJGNIJBM
	{
		[Cpp2IlInjected.Token(Token = "0x600033D")]
		[Cpp2IlInjected.Address(RVA = "0x59938D0", Offset = "0x59928D0", VA = "0x1859938D0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600033E")]
		[Cpp2IlInjected.Address(RVA = "0x59934A0", Offset = "0x59924A0", VA = "0x1859934A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	public Vector3 EHJBDKIIJGF
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5993C80", Offset = "0x5992C80", VA = "0x185993C80")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5993520", Offset = "0x5992520", VA = "0x185993520")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	public float LAJOENONCOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x5993670", Offset = "0x5992670", VA = "0x185993670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	public PJPKFOPIOPJ.LKCHLKGJNIB EBBBAHPJIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x5993BC0", Offset = "0x5992BC0", VA = "0x185993BC0")]
		get
		{
			return default(PJPKFOPIOPJ.LKCHLKGJNIB);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x5993860", Offset = "0x5992860", VA = "0x185993860")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034B")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	public MMLPFHHOIHM NLACIKINHKF
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(MMLPFHHOIHM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000336")]
	[Cpp2IlInjected.Address(RVA = "0x5993A80", Offset = "0x5992A80", VA = "0x185993A80")]
	public KBHFCCOOFEB MPBAJMJBEJB()
	{
		return default(KBHFCCOOFEB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000337")]
	[Cpp2IlInjected.Address(RVA = "0x5993990", Offset = "0x5992990", VA = "0x185993990")]
	public MABPMODAGDK KCGBNACPPOH()
	{
		return default(MABPMODAGDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000344")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public OFOPFBNBGHA(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000346")]
	[Cpp2IlInjected.Address(RVA = "0x5984560", Offset = "0x5983560", VA = "0x185984560")]
	public static bool DLCNBHCGPLK(OFOPFBNBGHA CKMKMNKGMMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000347")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000348")]
	[Cpp2IlInjected.Address(RVA = "0x5993760", Offset = "0x5992760", VA = "0x185993760", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000349")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(OFOPFBNBGHA JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034A")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface IOBABJCGBCL
{
	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	MPJBMBNDNGN OAEIBKHDOED
	{
		[Cpp2IlInjected.Token(Token = "0x600034E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	OOONJFBBMMC FOKDNNGEINJ
	{
		[Cpp2IlInjected.Token(Token = "0x600034F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	ABOICCJCDEM PJFLMMHEJAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000350")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000351")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	IALNCAKHEIO AOPFCIHOLLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	OBAGCOKNPCI ABKFELEHNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	HMOIPICELDJ IPJBINAMCMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000354")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	KKMHMCHHIDF LEHFGBHKHIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	ENHJJEBPBOC IKJFIJLLGOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	MFAKJFKEOLG ANJFOLFIJPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	DAAJPFIJADI DMMGJKAGHLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	LHCMCJOPDME JHDKNGPNJOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	IABGNEKJFEK NMIBFCDMNFK
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	IBBKFEOICPE EJJBKFGIIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	ABAPABOIFIO BNAFPIEEIIB
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	GJAFPLOBCJA OCIBOAOOGBB
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	BHBAGGMELAE EKNPBMIEFLL
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	LLABMBFFKBG LDOAKANKFIH
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface OIKOENDDLIG
{
	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	object IGBFGHICGFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000361")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OFHOEOBLBHA(NAJEBGMNODC NCHKOJCIMBJ);
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface IALNCAKHEIO
{
	[Cpp2IlInjected.Token(Token = "0x6000362")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KBHBMCLJPDE KFFGCBOPHHL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000363")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBHBMCLJPDE GPAHLJAOGGF(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000364")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool LMENPCDIGEL(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE AGFCJPGACCB, bool FKOOEMPCGOD);

	[Cpp2IlInjected.Token(Token = "0x6000365")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool OKJOJJIJMDO(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE AGFCJPGACCB);

	[Cpp2IlInjected.Token(Token = "0x6000366")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int LLADCDDCECO(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000367")]
	[Cpp2IlInjected.Address(Slot = "5")]
	NAJEBGMNODC CKNGJKIBGKB(KBHBMCLJPDE ABAAGAOADBF);

	[Cpp2IlInjected.Token(Token = "0x6000368")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool PJAHDFEADAB(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE PPDFGBCODMF);

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BFNAAJCPEMG(KBHBMCLJPDE AAGHLALAEIJ, KBHBMCLJPDE BHNDMMJICPG);

	[Cpp2IlInjected.Token(Token = "0x600036A")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KBHBMCLJPDE GBIPNFFEIMK(KBHBMCLJPDE PPDFGBCODMF, KBHBMCLJPDE HIBAGMKHLLK);

	[Cpp2IlInjected.Token(Token = "0x600036B")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PHKDAHMLLLL(KBHBMCLJPDE PPDFGBCODMF, KBHBMCLJPDE HIBAGMKHLLK, out KBHBMCLJPDE CHJMDDOBIDK);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public static class HPNGCFCHCIK
{
	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(RVA = "0x598A200", Offset = "0x5989200", VA = "0x18598A200")]
	public static bool MMMBPNNCCBD(this IALNCAKHEIO OBGGONOGPBF, KBHBMCLJPDE AAGHLALAEIJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public enum LBGPEGPAPPB
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
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface KKMHMCHHIDF
{
	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<KBHBMCLJPDE> OEHGCPGIPGG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	KBHBMCLJPDE LAPKILHCFPD(KBHBMCLJPDE AAGHLALAEIJ, int EJNMEMKEIOD);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int OGDBIACJPLE(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "3")]
	BCNKDDIOAKC POJHDENAOIG(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KMHFACHFCPB(KBHBMCLJPDE AAGHLALAEIJ, BCNKDDIOAKC OBPACCONAMD);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KBHBMCLJPDE DOBHPNJLJJI(KBHBMCLJPDE AAGHLALAEIJ, [Optional] float3? EDEGPGKBEGA, [Optional] quaternion? DEANJFCCEBG, [Optional] float3? MCNELIBKDDB);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KBHBMCLJPDE AOOFHAOJNGO(KBHBMCLJPDE AAGHLALAEIJ, int EJNMEMKEIOD, [Optional] float3? EDEGPGKBEGA, [Optional] quaternion? DEANJFCCEBG, [Optional] float3? MCNELIBKDDB);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void AABNBOKEGEN(KBHBMCLJPDE AAGHLALAEIJ, int EJNMEMKEIOD);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void JNMEPGMPKGD(KBHBMCLJPDE AAGHLALAEIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000082")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface NHIHKLOIBKC
{
	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GALHNKJNBAJ(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FDCGFLDAKAB(KBHBMCLJPDE AAGHLALAEIJ, Transform CEKKPPPNLGM);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
public interface EBGEBJGAJEB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	LocalId PKEEIOOIJDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000378")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	LocalId NEECONIKOFF
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
	void ENCFPIFKHPB(float3 HONHANLIPPH);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCFLOFAKKEE(float3 HONHANLIPPH);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void KHGDPELFJBK(out float3 MAKGFFNPBIJ, out float3 HKJNHGFOJEO);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void FHOIDEGJBEB(float3 MAKGFFNPBIJ, float3 HKJNHGFOJEO);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IOMBPONFPLI(Color MAKGFFNPBIJ, Color HKJNHGFOJEO);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "8")]
	EBGEBJGAJEB Instantiate(Transform CEKKPPPNLGM);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface CEKDEGOKEBL
{
	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JFGMJMMFADK(Transform CEKKPPPNLGM, EBGEBJGAJEB MJMOKEDNLGJ);

	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "1")]
	EBGEBJGAJEB GOOJGCHCEON();
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public readonly struct OFODDMEHLKO : IEquatable<OFODDMEHLKO>
{
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public static readonly OFODDMEHLKO NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	private GDEMDOGCFBF ONDNPEIIEIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000383")]
		[Cpp2IlInjected.Address(RVA = "0x59933A0", Offset = "0x59923A0", VA = "0x1859933A0")]
		get
		{
			return default(GDEMDOGCFBF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	public PLFMGANAONA KFNJMEFHPCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(RVA = "0x5993190", Offset = "0x5992190", VA = "0x185993190")]
		get
		{
			return default(PLFMGANAONA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600038B")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000385")]
	[Cpp2IlInjected.Address(RVA = "0x59932F0", Offset = "0x59922F0", VA = "0x1859932F0")]
	public KALIFCEPONM HADAJBCCMFF()
	{
		return default(KALIFCEPONM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000386")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public OFODDMEHLKO(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(RVA = "0x59931F0", Offset = "0x59921F0", VA = "0x1859931F0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(OFODDMEHLKO JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct GNOBAHDPFJD : IEquatable<GNOBAHDPFJD>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly GNOBAHDPFJD NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000391")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(RVA = "0x5989450", Offset = "0x5988450", VA = "0x185989450", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600038F")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(GNOBAHDPFJD JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000390")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct MGMBOMDCJGJ : IEquatable<MGMBOMDCJGJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public static readonly MGMBOMDCJGJ NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000398")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public MGMBOMDCJGJ(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x598E270", Offset = "0x598D270", VA = "0x18598E270", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(MGMBOMDCJGJ JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000397")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x598E370", Offset = "0x598D370", VA = "0x18598E370")]
	public bool HAAMCMPMAPM(out Collider HJBJFCKNGEN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct PCFFEFPAFNP : IEquatable<PCFFEFPAFNP>
{
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static readonly PCFFEFPAFNP NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	public KBHBMCLJPDE GBHCEBOJBGN
	{
		[Cpp2IlInjected.Token(Token = "0x600039C")]
		[Cpp2IlInjected.Address(RVA = "0x1033240", Offset = "0x1032240", VA = "0x181033240")]
		get
		{
			return default(KBHBMCLJPDE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A1")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	public MABPMODAGDK BBHJICFFOJC
	{
		[Cpp2IlInjected.Token(Token = "0x60003A2")]
		[Cpp2IlInjected.Address(RVA = "0x5994010", Offset = "0x5993010", VA = "0x185994010")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	public float3 FOEBOOGHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A3")]
		[Cpp2IlInjected.Address(RVA = "0x5994730", Offset = "0x5993730", VA = "0x185994730")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x59942F0", Offset = "0x59932F0", VA = "0x1859942F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	public quaternion IMGIAOBGANG
	{
		[Cpp2IlInjected.Token(Token = "0x60003A5")]
		[Cpp2IlInjected.Address(RVA = "0x5994400", Offset = "0x5993400", VA = "0x185994400")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A6")]
		[Cpp2IlInjected.Address(RVA = "0x5994380", Offset = "0x5993380", VA = "0x185994380")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	public float3 MNGIEBFBNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003A7")]
		[Cpp2IlInjected.Address(RVA = "0x5994580", Offset = "0x5993580", VA = "0x185994580")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x5994190", Offset = "0x5993190", VA = "0x185994190")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	public JMFBOJAMHDK JKKDMILMHLH
	{
		[Cpp2IlInjected.Token(Token = "0x60003A9")]
		[Cpp2IlInjected.Address(RVA = "0x5994220", Offset = "0x5993220", VA = "0x185994220")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	private AHEPJEGHNCA APFOCLKPLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x5994290", Offset = "0x5993290", VA = "0x185994290")]
		get
		{
			return default(AHEPJEGHNCA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	private JELHBAGLFOI MEHOFPAGEEN
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5994610", Offset = "0x5993610", VA = "0x185994610")]
		get
		{
			return default(JELHBAGLFOI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	private CDMGCPMPNPD IBKKMPIJOEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5994130", Offset = "0x5993130", VA = "0x185994130")]
		get
		{
			return default(CDMGCPMPNPD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private HJBFLFDPACD NKKHJEBBEHK
	{
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x59940D0", Offset = "0x59930D0", VA = "0x1859940D0")]
		get
		{
			return default(HJBFLFDPACD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	private LHBLAKFOBCE FMICPHCOBFE
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x59947C0", Offset = "0x59937C0", VA = "0x1859947C0")]
		get
		{
			return default(LHBLAKFOBCE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public PCFFEFPAFNP(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600039D")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039E")]
	[Cpp2IlInjected.Address(RVA = "0x5994480", Offset = "0x5993480", VA = "0x185994480", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(PCFFEFPAFNP JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5994670", Offset = "0x5993670", VA = "0x185994670")]
	public void OBMMACNOBAG(MABPMODAGDK CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x59942F0", Offset = "0x59932F0", VA = "0x1859942F0")]
	public void CKFDLJBJOPP(float3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x5994380", Offset = "0x5993380", VA = "0x185994380")]
	public void DAFIJFDJPPL(quaternion CKMKMNKGMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct MMLPFHHOIHM : IEquatable<MMLPFHHOIHM>
{
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public static readonly MMLPFHHOIHM NLKBFLKLEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private readonly KBHBMCLJPDE ABAAGAOADBF;

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public INJFODOHFLJ MFEKJONNBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5984540", Offset = "0x5983540", VA = "0x185984540")]
		get
		{
			return default(INJFODOHFLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	private GKHJEPNPMDA PNFBKFNPNEH
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x83A0A0", Offset = "0x8390A0", VA = "0x18083A0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	private OBAGCOKNPCI BNJNFKLOCHH
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x59915D0", Offset = "0x59905D0", VA = "0x1859915D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public bool BIBDNMKLHID
	{
		[Cpp2IlInjected.Token(Token = "0x60003BC")]
		[Cpp2IlInjected.Address(RVA = "0x5991430", Offset = "0x5990430", VA = "0x185991430")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public Vector3 FOEBOOGHHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60003BD")]
		[Cpp2IlInjected.Address(RVA = "0x5991480", Offset = "0x5990480", VA = "0x185991480")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003BE")]
		[Cpp2IlInjected.Address(RVA = "0x598F4D0", Offset = "0x598E4D0", VA = "0x18598F4D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public Quaternion IMGIAOBGANG
	{
		[Cpp2IlInjected.Token(Token = "0x60003BF")]
		[Cpp2IlInjected.Address(RVA = "0x598F330", Offset = "0x598E330", VA = "0x18598F330")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C0")]
		[Cpp2IlInjected.Address(RVA = "0x59911B0", Offset = "0x59901B0", VA = "0x1859911B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public Vector3 AONAJNGLCAI
	{
		[Cpp2IlInjected.Token(Token = "0x60003C1")]
		[Cpp2IlInjected.Address(RVA = "0x5991640", Offset = "0x5990640", VA = "0x185991640")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x59906C0", Offset = "0x598F6C0", VA = "0x1859906C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public Quaternion GIJEMHCFPBG
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x5990D70", Offset = "0x598FD70", VA = "0x185990D70")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5990800", Offset = "0x598F800", VA = "0x185990800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public float LKJEGOPOJPP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C5")]
		[Cpp2IlInjected.Address(RVA = "0x598F710", Offset = "0x598E710", VA = "0x18598F710")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x598EBF0", Offset = "0x598DBF0", VA = "0x18598EBF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public float KJPOFMHJMPL
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x598FAC0", Offset = "0x598EAC0", VA = "0x18598FAC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	public Vector3 MNGIEBFBNGK
	{
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5990570", Offset = "0x598F570", VA = "0x185990570")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x598E810", Offset = "0x598D810", VA = "0x18598E810")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	public Vector3 GKHNKHIKBGI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5991790", Offset = "0x5990790", VA = "0x185991790")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	public Vector3 HPFEHDBMFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x598EAA0", Offset = "0x598DAA0", VA = "0x18598EAA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	public Matrix4x4 LNPGHNOFOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x59904F0", Offset = "0x598F4F0", VA = "0x1859904F0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003B3")]
	[Cpp2IlInjected.Address(RVA = "0x1859EB0", Offset = "0x1858EB0", VA = "0x181859EB0")]
	public MMLPFHHOIHM(KBHBMCLJPDE AAGHLALAEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003B4")]
	[Cpp2IlInjected.Address(RVA = "0x1FAD2B0", Offset = "0x1FAC2B0", VA = "0x181FAD2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B5")]
	[Cpp2IlInjected.Address(RVA = "0x598FBC0", Offset = "0x598EBC0", VA = "0x18598FBC0", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5984770", Offset = "0x5983770", VA = "0x185984770", Slot = "4")]
	public bool Equals(MMLPFHHOIHM JONIFABKCAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003B7")]
	[Cpp2IlInjected.Address(RVA = "0x5985300", Offset = "0x5984300", VA = "0x185985300", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003BB")]
	[Cpp2IlInjected.Address(RVA = "0x5990A50", Offset = "0x598FA50", VA = "0x185990A50")]
	public ILAKCHBHFNG LCGACCIPOMN()
	{
		return default(ILAKCHBHFNG);
	}

	[Cpp2IlInjected.Token(Token = "0x60003CD")]
	[Cpp2IlInjected.Address(RVA = "0x598E4E0", Offset = "0x598D4E0", VA = "0x18598E4E0")]
	public void AAFAECAIABD(out Matrix4x4 GCJFKHONGAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CE")]
	[Cpp2IlInjected.Address(RVA = "0x5990040", Offset = "0x598F040", VA = "0x185990040")]
	public void HOFFHOKNJAI(out Vector3 BMBCNLOLKEP, out Quaternion LDDPMLADPLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003CF")]
	[Cpp2IlInjected.Address(RVA = "0x59918D0", Offset = "0x59908D0", VA = "0x1859918D0")]
	public void PODMKMCGJIJ(out RigidTransform FMMLNIBKGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D0")]
	[Cpp2IlInjected.Address(RVA = "0x5990AC0", Offset = "0x598FAC0", VA = "0x185990AC0")]
	public EEELCFJDAIJ LCNBFFOLOBM()
	{
		return default(EEELCFJDAIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D1")]
	[Cpp2IlInjected.Address(RVA = "0x5990B10", Offset = "0x598FB10", VA = "0x185990B10")]
	public void LCNBFFOLOBM(out EEELCFJDAIJ AIDKBNGBKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D2")]
	[Cpp2IlInjected.Address(RVA = "0x598F950", Offset = "0x598E950", VA = "0x18598F950")]
	public EEELCFJDAIJ EIPGIGNDFDA()
	{
		return default(EEELCFJDAIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D3")]
	[Cpp2IlInjected.Address(RVA = "0x598F9A0", Offset = "0x598E9A0", VA = "0x18598F9A0")]
	public void EIPGIGNDFDA(out EEELCFJDAIJ FMMLNIBKGGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D4")]
	[Cpp2IlInjected.Address(RVA = "0x5991060", Offset = "0x5990060", VA = "0x185991060")]
	public Vector3 NDNODELJNJN()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D5")]
	[Cpp2IlInjected.Address(RVA = "0x598EE50", Offset = "0x598DE50", VA = "0x18598EE50")]
	public void CKFDLJBJOPP(in Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D6")]
	[Cpp2IlInjected.Address(RVA = "0x598EF90", Offset = "0x598DF90", VA = "0x18598EF90")]
	public Vector3 CMGLNIJABJA()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x598F810", Offset = "0x598E810", VA = "0x18598F810")]
	public void EHPHOJIDLHH(in Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x598E670", Offset = "0x598D670", VA = "0x18598E670")]
	public Quaternion ADKNAIHHGLC()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x598F0E0", Offset = "0x598E0E0", VA = "0x18598F0E0")]
	public void DAFIJFDJPPL(in Quaternion CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5990210", Offset = "0x598F210", VA = "0x185990210")]
	public Quaternion ILNNJLFPEDK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x598FCC0", Offset = "0x598ECC0", VA = "0x18598FCC0")]
	public void FEHCLKJNEGA(in Quaternion CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x598F610", Offset = "0x598E610", VA = "0x18598F610")]
	public float DMGNMNJGCEO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5990940", Offset = "0x598F940", VA = "0x185990940")]
	public void KGAKGPPJMGN(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x598FE00", Offset = "0x598EE00", VA = "0x18598FE00")]
	public float FGLAEAOFAJO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x598F220", Offset = "0x598E220", VA = "0x18598F220")]
	public void DCEFNFDNJPD(float CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x59903B0", Offset = "0x598F3B0", VA = "0x1859903B0")]
	public void INLHEJMCEEO(in Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x598ED00", Offset = "0x598DD00", VA = "0x18598ED00")]
	public Vector3 CJFACCEHLOF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x598FF00", Offset = "0x598EF00", VA = "0x18598FF00")]
	public void GFMIOOMKKAM(in Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x598E950", Offset = "0x598D950", VA = "0x18598E950")]
	public Vector3 BKMACODGIAB()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x59912F0", Offset = "0x59902F0", VA = "0x1859912F0")]
	public void NJKLLGDGLGJ(in Vector3 CKMKMNKGMMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5990F10", Offset = "0x598FF10", VA = "0x185990F10")]
	public Vector3 MEKPLDOEDBG()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5990C30", Offset = "0x598FC30", VA = "0x185990C30")]
	public void LKNMDOAPBKK(in Vector3 CKMKMNKGMMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface GKHJEPNPMDA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000130")]
	IOBABJCGBCL MIAKGONENNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003E8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	JDJIDODBAGJ BFKHAHBFMPL(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	DGAJAJLJOIP NINBDODDJMD(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void BJHMJAKPJGO(IEHIEBBLKIE DELHFMHNJCM, NKOOCAKBLNH GHAKJBHJDGO);

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(Slot = "4")]
	INJFODOHFLJ LOPDGFLBPGI(KBHBMCLJPDE AAGHLALAEIJ, [Optional] object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool EEJHJHPCDKB(KBHBMCLJPDE AAGHLALAEIJ, out NKOOCAKBLNH GHAKJBHJDGO);

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool NMHNJFECBHC(KBHBMCLJPDE AAGHLALAEIJ, out Transform CEKKPPPNLGM);

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(Slot = "7")]
	bool BMLNMMNHHDM(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void ENJHLIMMOJN(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60003F1")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GHKKKNFJOEO(LocalId AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60003F2")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool ODBKNPBDPDK(LocalId AAGHLALAEIJ, object DMHDKAFNNAC);

	[Cpp2IlInjected.Token(Token = "0x60003F3")]
	[Cpp2IlInjected.Address(Slot = "11")]
	KBHBMCLJPDE APLMGILEEBI(IEHIEBBLKIE DELHFMHNJCM);

	[Cpp2IlInjected.Token(Token = "0x60003F4")]
	[Cpp2IlInjected.Address(Slot = "12")]
	IEHIEBBLKIE HGGBEKODJDK(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x60003F5")]
	[Cpp2IlInjected.Address(Slot = "13")]
	NAJEBGMNODC APLMGILEEBI(NativeArray<IEHIEBBLKIE> DELHFMHNJCM, Allocator LEPNDEGMIDH);

	[Cpp2IlInjected.Token(Token = "0x60003F6")]
	[Cpp2IlInjected.Address(Slot = "14")]
	NAJEBGMNODC GMFHODKNEGN(NativeArray<IEHIEBBLKIE> DELHFMHNJCM, NativeArray<GONEJMDDKKO> NPPPPMCPDFJ, Allocator LEPNDEGMIDH);

	[Cpp2IlInjected.Token(Token = "0x60003F7")]
	[Cpp2IlInjected.Address(Slot = "15")]
	INJFODOHFLJ DHKACCHAELC(DGAJAJLJOIP LAABEELPEOO, bool OEHNLOKMKJP);

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "16")]
	INJFODOHFLJ DHKACCHAELC(DGAJAJLJOIP LAABEELPEOO);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "17")]
	INJFODOHFLJ PNGAAIFALEP(DGAJAJLJOIP LAABEELPEOO);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "18")]
	INJFODOHFLJ GJEHEPODOOB(DGAJAJLJOIP LAABEELPEOO);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "19")]
	INJFODOHFLJ GMFHODKNEGN(IEHIEBBLKIE DELHFMHNJCM, DGAJAJLJOIP LAABEELPEOO);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "20")]
	AKDCLPGGBEC BCJOPNHENFB();

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "21")]
	MABPMODAGDK LADBHEKFKKH();

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "22")]
	KBHFCCOOFEB JOFFCELHCIC(LCMPCAIJMDL MKOJAEGKPDC);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "23")]
	void NJHLGCACLHC(NAJEBGMNODC NCHKOJCIMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JJKMDDGGLDB(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void DFPECMDKDHI(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void NJHLGCACLHC(KBHBMCLJPDE AAGHLALAEIJ);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "27")]
	NAJEBGMNODC FHGNGFPDMGF(NAJEBGMNODC IEMAIPJPHBC, Allocator LEPNDEGMIDH);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "28")]
	bool GDIDPFMABMA(KBHBMCLJPDE AAGHLALAEIJ);
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
public static class DMAIHJHNDCP
{
	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(RVA = "0x59862A0", Offset = "0x59852A0", VA = "0x1859862A0")]
	public static void ENJHLIMMOJN(this GKHJEPNPMDA IEENNNLENFN, NKOOCAKBLNH GHAKJBHJDGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(RVA = "0x5986A30", Offset = "0x5985A30", VA = "0x185986A30")]
	public static INJFODOHFLJ PGCLNCLIMMI(this GKHJEPNPMDA IEENNNLENFN, LocalId AAGHLALAEIJ)
	{
		return default(INJFODOHFLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(RVA = "0x5986130", Offset = "0x5985130", VA = "0x185986130")]
	public static KBHBMCLJPDE APLMGILEEBI(this GKHJEPNPMDA IEENNNLENFN, LocalId AAGHLALAEIJ)
	{
		return default(KBHBMCLJPDE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(RVA = "0x59866A0", Offset = "0x59856A0", VA = "0x1859866A0")]
	public static IEHIEBBLKIE HGGBEKODJDK(this GKHJEPNPMDA IEENNNLENFN, LocalId AAGHLALAEIJ)
	{
		return default(IEHIEBBLKIE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(RVA = "0x5986400", Offset = "0x5985400", VA = "0x185986400")]
	public static bool GDIDPFMABMA(this GKHJEPNPMDA IEENNNLENFN, IEHIEBBLKIE DELHFMHNJCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(RVA = "0x222A8D0", Offset = "0x22298D0", VA = "0x18222A8D0")]
	public static T LOJMFOOEGIL<T>(this GKHJEPNPMDA IEENNNLENFN, LocalId AAGHLALAEIJ) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(RVA = "0x5986150", Offset = "0x5985150", VA = "0x185986150")]
	public static AKDCLPGGBEC DBHCKBDAHNC(this GKHJEPNPMDA IEENNNLENFN, RigidTransform AIDKBNGBKEI, [Optional] object DMHDKAFNNAC)
	{
		return default(AKDCLPGGBEC);
	}

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(RVA = "0x59868E0", Offset = "0x59858E0", VA = "0x1859868E0")]
	public static KBHFCCOOFEB PBNGCBEFMNF(this GKHJEPNPMDA IEENNNLENFN, LCMPCAIJMDL PJKHAKNGNPI, RigidTransform AIDKBNGBKEI, [Optional] object DMHDKAFNNAC)
	{
		return default(KBHFCCOOFEB);
	}

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(RVA = "0x5986550", Offset = "0x5985550", VA = "0x185986550")]
	public static MABPMODAGDK HCAKDHOGLJI(this GKHJEPNPMDA IEENNNLENFN, RigidTransform AIDKBNGBKEI, [Optional] object DMHDKAFNNAC)
	{
		return default(MABPMODAGDK);
	}

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(RVA = "0x59867C0", Offset = "0x59857C0", VA = "0x1859867C0")]
	private static void NGFANBBNPKN(INJFODOHFLJ MCBFJAJNBGA, RigidTransform AIDKBNGBKEI, [Optional] object DMHDKAFNNAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(RVA = "0x5986AE0", Offset = "0x5985AE0", VA = "0x185986AE0")]
	internal static KALIFCEPONM PLJMOAKNPDP(this GKHJEPNPMDA IEENNNLENFN, GCFCBJAFCBA PHJAGLLABMO, [Optional] object DMHDKAFNNAC)
	{
		return default(KALIFCEPONM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
internal static class OOCLGEPELFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(RVA = "0x5993F30", Offset = "0x5992F30", VA = "0x185993F30")]
	public static IOBABJCGBCL MIAKGONENNH(this KBHBMCLJPDE OACHBLHDAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(RVA = "0x5993F80", Offset = "0x5992F80", VA = "0x185993F80")]
	public static ABOICCJCDEM PJFLMMHEJAI(this KBHBMCLJPDE OACHBLHDAOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(RVA = "0x5993E70", Offset = "0x5992E70", VA = "0x185993E70")]
	public static EntityManager DDMBMPJOHMF(this KBHBMCLJPDE OACHBLHDAOM)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(RVA = "0x292D6C0", Offset = "0x292C6C0", VA = "0x18292D6C0")]
	public static T FAEFMOGHDHA<T>(this KBHBMCLJPDE OACHBLHDAOM) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(RVA = "0x292E8D0", Offset = "0x292D8D0", VA = "0x18292E8D0")]
	public static bool GPCAHAHLAGK<T>(this KBHBMCLJPDE OACHBLHDAOM) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
internal interface MDKBCEKMAGM
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<HFOKKNDJCPG> IHAJAJJEJPI;
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
[FOHDECLCMPO(MNAOIHCEBLE.LoadInstance)]
public interface MFAKJFKEOLG
{
	[Cpp2IlInjected.Token(Token = "0x17000131")]
	bool KIHOCCDNCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000419")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	KBHBMCLJPDE IPLAIKDJJPD
	{
		[Cpp2IlInjected.Token(Token = "0x600041A")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041B")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	INJFODOHFLJ DKIAIFNKMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600041C")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600041D")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	INJFODOHFLJ IKNKAPPEGCO
	{
		[Cpp2IlInjected.Token(Token = "0x600041E")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event PFDEGHGNKFP KEPCPODMDGE;

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	KBHBMCLJPDE GBIPNFFEIMK(KBHBMCLJPDE PPDFGBCODMF, KBHBMCLJPDE HIBAGMKHLLK);

	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool PHKDAHMLLLL(KBHBMCLJPDE PPDFGBCODMF, KBHBMCLJPDE HIBAGMKHLLK, out KBHBMCLJPDE CHJMDDOBIDK);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void PDKICBCJDFG();

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "11")]
	void KBDEBPELBKC();

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool BCFJAPAPBHD(KBHBMCLJPDE EEMPMGBFHEC);
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
public delegate void PFDEGHGNKFP(INJFODOHFLJ HGHNKNGKGLF, INJFODOHFLJ BMOKPDGNBOJ);
[Cpp2IlInjected.Token(Token = "0x2000090")]
public static class KAFJDOMHDNL
{
	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x598BAD0", Offset = "0x598AAD0", VA = "0x18598BAD0")]
	public static bool AIOMMFHHAHE(this MFAKJFKEOLG DPCEHJAFNFD, INJFODOHFLJ EEMPMGBFHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000429")]
	[Cpp2IlInjected.Address(RVA = "0x598BC50", Offset = "0x598AC50", VA = "0x18598BC50")]
	public static bool CKBEECNLGDG(this MFAKJFKEOLG DPCEHJAFNFD, KBHBMCLJPDE EEMPMGBFHEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600042A")]
	[Cpp2IlInjected.Address(RVA = "0x598BB60", Offset = "0x598AB60", VA = "0x18598BB60")]
	public static bool BCHPLECELKM(this MFAKJFKEOLG DPCEHJAFNFD, KBHBMCLJPDE EEMPMGBFHEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
[DefaultMember("Item")]
public interface OMLBGBNFMBD : IEnumerable<LJIGFJOKOBN>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000135")]
	int EBKBMNDKLEN
	{
		[Cpp2IlInjected.Token(Token = "0x600042B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	LJIGFJOKOBN IPBJHMOANMK
	{
		[Cpp2IlInjected.Token(Token = "0x600042C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600042D")]
	[Cpp2IlInjected.Address(Slot = "2")]
	LJIGFJOKOBN EFGFLBDCIBO(EOOMHOMHJOF HBOAIEOOPAF);

	[Cpp2IlInjected.Token(Token = "0x600042E")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GBJAHOLHFPP OPLBINNFJPI(EOOMHOMHJOF HBOAIEOOPAF);
}
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class NKAEPBNLCLB
{
	[Cpp2IlInjected.Token(Token = "0x600042F")]
	[Cpp2IlInjected.Address(RVA = "0x3120F80", Offset = "0x311FF80", VA = "0x183120F80")]
	public static PJKPFJLAKIO<T> EFGFLBDCIBO<T>(this OMLBGBNFMBD KDNJIKBJJJJ, EOOMHOMHJOF OKONKHNEMOO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000430")]
	[Cpp2IlInjected.Address(RVA = "0x3120E30", Offset = "0x311FE30", VA = "0x183120E30")]
	public static PJKPFJLAKIO<T> EFGFLBDCIBO<T>(this OMLBGBNFMBD KDNJIKBJJJJ, BNAHOABKGKK<T> OKONKHNEMOO) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000431")]
	[Cpp2IlInjected.Address(RVA = "0x31210A0", Offset = "0x31200A0", VA = "0x1831210A0")]
	public static GBJAHOLHFPP OPLBINNFJPI<T>(this OMLBGBNFMBD KDNJIKBJJJJ, BNAHOABKGKK<T> OKONKHNEMOO) where T : struct
	{
		return default(GBJAHOLHFPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface CBBOIFAKOHF : KOFHEPEJNKL
{
	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "0")]
	AAJBDLLIBEJ JHCNACPAMMM(Entity OIDNDCEGFCN);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void KMAPHIFJNKB(NativeArray<AAJBDLLIBEJ> BNOMBNJKAMB, NativeArray<CEILPKGELLD> ADPLHOIKHIC);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void AHGMJKOJMDA(AAJBDLLIBEJ ELGBGLBKDOD);

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool DHBALIEMGAD(AAJBDLLIBEJ ELGBGLBKDOD, out Collider HJBJFCKNGEN);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public struct CEILPKGELLD : ISystemStateComponentData, IComponentData, IEquatable<CEILPKGELLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public float3 NJBOFGNNMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 GEAMHPCHAFO;

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(RVA = "0x59857E0", Offset = "0x59847E0", VA = "0x1859857E0", Slot = "4")]
	public bool Equals(CEILPKGELLD JONIFABKCAI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
public struct GOAOJMCEMIL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Guid AGKIPDJPNCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public string DMELMMAPFOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Vector3 EDEGPGKBEGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Quaternion DEANJFCCEBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public Vector3 MCNELIBKDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public int PFBJIOANFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public Dictionary<string, object> OBPACCONAMD;

	[Cpp2IlInjected.Token(Token = "0x6000437")]
	[Cpp2IlInjected.Address(RVA = "0x5989720", Offset = "0x5988720", VA = "0x185989720", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000438")]
	[Cpp2IlInjected.Address(RVA = "0x5989590", Offset = "0x5988590", VA = "0x185989590")]
	private static string JBFIJIKJOAE(Dictionary<string, object> LOAKNOKOKFD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public enum OIOFAMCKDCA
{
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x2000098")]
public enum PFLIHPIFAGB
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	World,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public static class ODEBGCAELKG
{
	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x435EAB0", Offset = "0x435DAB0", VA = "0x18435EAB0")]
	public static bool NAIPLKOEHDH(this PFLIHPIFAGB FLAJIGGIBOB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public interface CPANGDPPGIH : KIFNIJEONMJ, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
[Flags]
public enum EBDFLAODLBH
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
public enum ACPAHFPAGLB
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
public interface DEKCEGABIGO : KIFNIJEONMJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000137")]
	PBLOANBKGFN NIJMLJBAEJE
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ICIKLLEKAKC();

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PLLKIGIDNKJ();
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
public interface PBLOANBKGFN
{
	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HODDMOCIMJO(Guid GDILAPBOMGI, out Guid OPPNHDACHEH);
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface POJIKPFFFCH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000138")]
	KKJHCJBCHLM BCMLOIDEJGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000441")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString LMOGLGNNLBL();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface KIFNIJEONMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000139")]
	IEnumerable<GOAOJMCEMIL> PMHJLHANPEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000443")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	FGOILOCCGAF LKEAGBOMMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000444")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	LocalId IMDGOLBCMNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000445")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	KKJHCJBCHLM IBJFJKMCEOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000446")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	Task PMFIKMAIKLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000447")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool DOKLPJBHLIC(EBDFLAODLBH IACEECNBNCE);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface HBANEJBKHJK
{
	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int FMDCDKABMBO(int BKAKEAMNOAC);
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface BLIFMKMEONK
{
	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	IEnumerable<BDGAHMNGEHF> CIOIELPKDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600044A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600044B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool OEHEJBGCGNH(int BKAKEAMNOAC, out BDGAHMNGEHF JEBLAHHKGAB);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface FCAOLADODHM
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	List<(IEMODOCEPJO nameHash, EDOKPHPJEKP stableTypeHash, Type type)> PAJJFFCOJAG
	{
		[Cpp2IlInjected.Token(Token = "0x600044C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[FOHDECLCMPO(MNAOIHCEBLE.Application)]
public interface FIMPMHLEBIE
{
	[Cpp2IlInjected.Token(Token = "0x600044D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEMODOCEPJO FCABOHHELNN(int BKAKEAMNOAC);

	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int FLAKKCBMBKB(IEMODOCEPJO EGPHMONEGHD);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface JCKJNBIMCDK
{
	[Cpp2IlInjected.Token(Token = "0x600044F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OBLDFCLMMAJ(IEHIEBBLKIE EEGACOJHOCM, GBJAHOLHFPP LPLLLEEIELD, ReadOnlySpan<byte> DMALPNCOLDB, ReadOnlySpan<byte> GCECBPOMLJH);

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GMKEKDIOEKA(IEHIEBBLKIE EEGACOJHOCM, GBJAHOLHFPP LPLLLEEIELD);

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool OOIGHAJNGKD(IEHIEBBLKIE EEGACOJHOCM, GBJAHOLHFPP LPLLLEEIELD, ReadOnlySpan<byte> GCECBPOMLJH);

	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PKLEILPEOIH(IEHIEBBLKIE EEGACOJHOCM, GBJAHOLHFPP LPLLLEEIELD, Span<byte> DMALPNCOLDB, Span<byte> GCECBPOMLJH);
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
public static class MMNJBBAJIDP
{
	[Cpp2IlInjected.Token(Token = "0x6000453")]
	[Cpp2IlInjected.Address(RVA = "0x116B7E0", Offset = "0x116A7E0", VA = "0x18116B7E0")]
	public static bool PKLEILPEOIH<T>(this JCKJNBIMCDK JADGOEDAABI, IEHIEBBLKIE EEGACOJHOCM, GBJAHOLHFPP LPLLLEEIELD, out T DMALPNCOLDB, out T GCECBPOMLJH) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(RVA = "0x116B6C0", Offset = "0x116A6C0", VA = "0x18116B6C0")]
	public static bool OOIGHAJNGKD<T>(this JCKJNBIMCDK JADGOEDAABI, IEHIEBBLKIE EEGACOJHOCM, GBJAHOLHFPP LPLLLEEIELD, T GCECBPOMLJH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
public enum DBFDPKOOAFG
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
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface FINMJEMIAIN : BKOAIJIACKG<FINMJEMIAIN>
{
	[Cpp2IlInjected.Token(Token = "0x6000455")]
	[Cpp2IlInjected.Address(Slot = "0")]
	GBJAHOLHFPP OPLBINNFJPI(EOOMHOMHJOF OKONKHNEMOO);

	[Cpp2IlInjected.Token(Token = "0x6000456")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BJHMJAKPJGO(GBJAHOLHFPP OACHBLHDAOM, FGHFKCJNOLC JEBLAHHKGAB);

	[Cpp2IlInjected.Token(Token = "0x6000457")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool PPJKMMAHKMD(GBJAHOLHFPP OACHBLHDAOM, out FGHFKCJNOLC JEBLAHHKGAB);
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public static class BABOOADGBPI
{
	[Cpp2IlInjected.Token(Token = "0x6000458")]
	[Cpp2IlInjected.Address(RVA = "0x2C98100", Offset = "0x2C97100", VA = "0x182C98100")]
	public static GBJAHOLHFPP OPLBINNFJPI<T>(this FINMJEMIAIN KDNJIKBJJJJ, BNAHOABKGKK<T> OKONKHNEMOO)
	{
		return default(GBJAHOLHFPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000459")]
	public static GBJAHOLHFPP BJHMJAKPJGO<T>(this FINMJEMIAIN KDNJIKBJJJJ, BNAHOABKGKK<T> OKONKHNEMOO, FGHFKCJNOLC JEBLAHHKGAB) where T : struct
	{
		return default(GBJAHOLHFPP);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface BCPMFGLECMK
{
	[Cpp2IlInjected.Token(Token = "0x17000140")]
	uint OICDPKIKEML
	{
		[Cpp2IlInjected.Token(Token = "0x600045A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public struct LPNIGELLPIE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public MCNAMAECDCB PCALNIOABDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public ReadOnlyMemory<byte> KPMKPNDNMBB;
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface NPFDHJJHMHN
{
	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FKAJPCJBPIJ(MCNAMAECDCB PCALNIOABDP, ReadOnlySpan<byte> KPMKPNDNMBB);
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public delegate bool HIGBAKDDEHO(JCKJNBIMCDK OHHBPOOJKIN, in HJFPGFBDEEK CKMKMNKGMMC);
[Cpp2IlInjected.Token(Token = "0x20000AE")]
public delegate bool GMKLHPEDODD<T>(JCKJNBIMCDK OHHBPOOJKIN, in T CKMKMNKGMMC);
[Cpp2IlInjected.Token(Token = "0x20000AF")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface FHGPDLKNGPH
{
	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BJHMJAKPJGO(GBJAHOLHFPP LPLLLEEIELD, Type MEPKIBKLFOC, HIGBAKDDEHO FEHKBJFJGGA);

	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool MNEJEGDAIGP(GBJAHOLHFPP LPLLLEEIELD, out HIGBAKDDEHO FEHKBJFJGGA);
}
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public static class GKHCHGMBGPM
{
	[Cpp2IlInjected.Token(Token = "0x20000B1")]
	[CompilerGenerated]
	private sealed class MIHNJIPAHGF<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public GMKLHPEDODD<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(RVA = "0x9B1010", Offset = "0x9B0010", VA = "0x1809B1010")]
		public MIHNJIPAHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000469")]
		[Cpp2IlInjected.Address(RVA = "0x29EB830", Offset = "0x29EA830", VA = "0x1829EB830")]
		internal bool BKHAILHEBGP(JCKJNBIMCDK pendingList, in HJFPGFBDEEK value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2961630", Offset = "0x2960630", VA = "0x182961630")]
	public static void BJHMJAKPJGO<T>(this FHGPDLKNGPH LABDKOGKHJC, GBJAHOLHFPP LPLLLEEIELD, GMKLHPEDODD<T> FEHKBJFJGGA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(RVA = "0x5989350", Offset = "0x5988350", VA = "0x185989350")]
	public static bool LLNMPBGHGDO(this FHGPDLKNGPH LABDKOGKHJC, JCKJNBIMCDK OHHBPOOJKIN, GBJAHOLHFPP LPLLLEEIELD, in HJFPGFBDEEK CKMKMNKGMMC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public struct MCNAMAECDCB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public uint MJMOHGGAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public int GCILCOJLJHL;

	[Cpp2IlInjected.Token(Token = "0x600046A")]
	[Cpp2IlInjected.Address(RVA = "0xAEEDE0", Offset = "0xAEDDE0", VA = "0x180AEEDE0")]
	public MCNAMAECDCB(uint MJMOHGGAAEE, int GCILCOJLJHL)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600046B")]
	[Cpp2IlInjected.Address(RVA = "0x598D920", Offset = "0x598C920", VA = "0x18598D920")]
	public static bool JFBEPFHBCDN(in MCNAMAECDCB BEHCKOODGGG, in MCNAMAECDCB IOJJDIDNFKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046C")]
	[Cpp2IlInjected.Address(RVA = "0x598D860", Offset = "0x598C860", VA = "0x18598D860", Slot = "0")]
	public override bool Equals(object DCGPCJKHCOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600046D")]
	[Cpp2IlInjected.Address(RVA = "0x598D8F0", Offset = "0x598C8F0", VA = "0x18598D8F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600046E")]
	[Cpp2IlInjected.Address(RVA = "0x598D940", Offset = "0x598C940", VA = "0x18598D940", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B3")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface HCHKJMHFKIE
{
	[Cpp2IlInjected.Token(Token = "0x600046F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	MCNAMAECDCB AKMIKLOMJMO(ReadOnlySpan<byte> KPMKPNDNMBB);
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public interface FGHFKCJNOLC
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	Type HDKJFIJAEON
	{
		[Cpp2IlInjected.Token(Token = "0x6000470")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000471")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BPADPDDPOEA(ref AFABOODPCMI NMOOAPLNEFP, Span<byte> EEMPMGBFHEC);

	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BCEEACLIKPE(ref NLKPKBIFPPK EFACDLPILBI, ReadOnlySpan<byte> PCALNIOABDP);
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
public static class IEKDPCCDLBJ
{
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public delegate void CNOJHHODOIJ(MCNAMAECDCB CDBHHMNALJL, ReadOnlySpan<byte> KPMKPNDNMBB);
[Cpp2IlInjected.Token(Token = "0x20000B7")]
[FOHDECLCMPO(MNAOIHCEBLE.OMRoom)]
public interface HDEIGECFNCB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000477")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CDBFOKGMOFA(MCNAMAECDCB CDBHHMNALJL, ReadOnlySpan<byte> KPMKPNDNMBB);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B8")]
public class FDBBNKLFMFL
{
	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
	public FDBBNKLFMFL()
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
