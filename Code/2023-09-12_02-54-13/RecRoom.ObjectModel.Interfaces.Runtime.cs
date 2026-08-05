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
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface FKKAJAEPALJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIHCCPEAJIE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface MBDFLOLPEII
{
	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMAPLLCJFCD(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, Allocator DGGNDNPDKKD, out NativeArray<Entity> NOEOKDNGNCK);
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public readonly struct KMAJJBPLHDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly NativeBitArray LJPEMGIEKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly NativeParallelHashMap<JDPNCHCMAIA, int> NFBADENCLEA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5A09DD0", Offset = "0x5A091D0", VA = "0x185A09DD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1727190", Offset = "0x1726590", VA = "0x181727190")]
	public KMAJJBPLHDC(NativeBitArray LJPEMGIEKOJ, NativeParallelHashMap<JDPNCHCMAIA, int> NFBADENCLEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5A09DF0", Offset = "0x5A091F0", VA = "0x185A09DF0")]
	public bool LHHCCJOLOHI(JDPNCHCMAIA DDCHJBPICDC, FDOJMOENJAL LEMJCNJPDLJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface PNJKCGEKCHD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	Guid OIEDMOIMACL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Task PBFOOAKMKJC(Guid BHGEFIFFHNL, Guid MOKCLHIJHEN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Task OHIHPPJJKHA(HEKFLAGDMLJ ECOPDGGJCON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OOFNHNJNGOJ(HEKFLAGDMLJ KEGFIDMGBNO, HEKFLAGDMLJ OJBGDMNECON, out Vector3 PMKGPHOGHCN, out Quaternion LMJFLEPCKIJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OJEEJAFIAOD(GDCONIFJKEF JDNEEKPLMMI, Vector3 PMKGPHOGHCN, Quaternion LMJFLEPCKIJ);
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface FLJMOFPACJP : IEPDOHHLJHK<HEKFLAGDMLJ>, LKKBEGLFKGM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface LKPHPGGEFLH<T> : FIPEENHHKAO<HEKFLAGDMLJ, T>, IEPDOHHLJHK<HEKFLAGDMLJ>, LKKBEGLFKGM, IDisposable, FLJMOFPACJP where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NEKEHLOPHAL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x24022B0", Offset = "0x24016B0", VA = "0x1824022B0")]
	public static T PHGLOPEHIMO<T>(this IEPDOHHLJHK<HEKFLAGDMLJ> LEMJCNJPDLJ, HEKFLAGDMLJ LEMCMBEMOCB) where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2402280", Offset = "0x2401680", VA = "0x182402280")]
	public static bool AFLFAPDAOKF<T>(this IEPDOHHLJHK<HEKFLAGDMLJ> LEMJCNJPDLJ, HEKFLAGDMLJ LEMCMBEMOCB, in T PINJDLEFOFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface HKJFJAJNFAP
{
	[Cpp2IlInjected.Token(Token = "0x17000003")]
	Func<MPFACGKGBND> IHMIAOAOIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "9")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	event Action<HEKFLAGDMLJ, HEKFLAGDMLJ> BJOHDIAEMPC;

	[Cpp2IlInjected.Token(Token = "0x14000002")]
	event Action<HEKFLAGDMLJ, HEKFLAGDMLJ> IPHHDBHFCJO;

	[Cpp2IlInjected.Token(Token = "0x14000003")]
	event Action<HEKFLAGDMLJ, HEKFLAGDMLJ, HEKFLAGDMLJ> HNMEBPEEKOO;

	[Cpp2IlInjected.Token(Token = "0x14000004")]
	event Action<HEKFLAGDMLJ> MLIDBNANFLI;

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(Slot = "10")]
	Color JCOMMEPAIEL(HEKFLAGDMLJ LEMCMBEMOCB, int AKDCODMMCOP);

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float3 LNLADOOOFAA(HEKFLAGDMLJ LEMCMBEMOCB, int AKDCODMMCOP);

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool ILCNJPOOKDE(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ OOJNBAAADPL);

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(Slot = "13")]
	HEKFLAGDMLJ FJOAILPKGJI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(Slot = "14")]
	IEnumerable<HEKFLAGDMLJ> OHCOKMJMLPG(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(Slot = "15")]
	HEKFLAGDMLJ MBOBKDBNHKI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void DBAKOAAEPOK(HEKFLAGDMLJ LEMCMBEMOCB, Vector3 IENBCOJMMMC, Quaternion OEHFJJBIAOI);

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void NAPIGNIBENE(HEKFLAGDMLJ LEMCMBEMOCB, float DHHEBBKINNJ);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "18")]
	bool JANMMNONCHL(HEKFLAGDMLJ LEMCMBEMOCB, out RigidTransform IHDDGLAPAKA);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "19")]
	bool JDCINEHHBAP(HEKFLAGDMLJ LEMCMBEMOCB, out float IFHCLNEOMAM);

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "20")]
	float3 DHKCGKEJKJD(KBEIKKHCOLG AOGEOLMJAOJ);

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(Slot = "21")]
	quaternion EFFJFOCKPJD(KBEIKKHCOLG AOGEOLMJAOJ);
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class MELLFJIOMCH
{
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface DCIHBGMKNDA
{
	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GLJJMNKKNIH(Action NDPBOAHDPLI, bool ELFHEFKGIBD);

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool IMJNAMCACOJ(string GDKOBCHHFLB);
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface CHLGHCACLPB
{
	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NMAPLLCJFCD(in NativeArray<Entity> NOEOKDNGNCK, in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, in NativeArray<EIPPCECOLNJ> BGNIPJHMELG);
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface EHDBBIHDADI
{
	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ADJPGHMCOKF(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GEKPKMIHAHB(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CGKJOCACEPG(HEKFLAGDMLJ JBFCCDGDFOM, int AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[DefaultMember("Item")]
public interface IJGPMAMDKLF : IEnumerable<KEJDGFDNFFK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000004")]
	NativeBitArray JLNKKAAIDEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	NativeArray<int> HIKFECLFIEH
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	KEJDGFDNFFK ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	KEJDGFDNFFK ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KEJDGFDNFFK DNDGKGKJHCH(LOHCJILDMLL OCFGMKDOPDP);

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	FDOJMOENJAL LEEAMPOIODD(LOHCJILDMLL OCFGMKDOPDP);
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public static class COFLJEJKNEG
{
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface LEHIKHOEAMN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	int EHPBPFCKPIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NNCLECIDMKE(GameObject NNAKJIJAOJG);

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool ADNAFKCBOFF(out Vector3 FGLOAKJBDBO);

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void LMMNFHGFNAK();
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public readonly struct BFJCIMAJPPG : IEquatable<BFJCIMAJPPG>
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly BFJCIMAJPPG BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A00720", Offset = "0x59FFB20", VA = "0x185A00720", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(BFJCIMAJPPG ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public readonly struct JBFOOKBHPIP : IEquatable<JBFOOKBHPIP>
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public static readonly JBFOOKBHPIP BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A07F60", Offset = "0x5A07360", VA = "0x185A07F60", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(JBFOOKBHPIP ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface NDDKNGFIEKO
{
	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	KMAJJBPLHDC OEKFNEAMGNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LHHCCJOLOHI(JDPNCHCMAIA DDCHJBPICDC, FDOJMOENJAL LEMJCNJPDLJ);

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFBFKFPPNNC(JDPNCHCMAIA DDCHJBPICDC, Span<FDOJMOENJAL> OEGNIABGFIK, bool IDLJEEILMNA);

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void OEDANOEGNMN(NativeArray<JDPNCHCMAIA> JJHDBMCJEFK);
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class LHFEFHIBEEA
{
	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5A0B080", Offset = "0x5A0A480", VA = "0x185A0B080")]
	public static void BFBFKFPPNNC(this NDDKNGFIEKO PCEDMCPKNAN, JDPNCHCMAIA DDCHJBPICDC, FDOJMOENJAL LEMJCNJPDLJ, bool IDLJEEILMNA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public readonly struct MDECDPGCMCD : GLHHELGFOCN, IEquatable<MDECDPGCMCD>
{
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public static readonly MDECDPGCMCD BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public GameObject NNAKJIJAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BFB0", Offset = "0x5A0B3B0", VA = "0x185A0BFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public JDPNCHCMAIA JLICPHPOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C670", Offset = "0x5A0BA70", VA = "0x185A0C670")]
		get
		{
			return default(JDPNCHCMAIA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public NILIGAKBOAA GJKMLPAEFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C1D0", Offset = "0x5A0B5D0", VA = "0x185A0C1D0")]
		get
		{
			return default(NILIGAKBOAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IMPAOGMALJN MPMLIPJAKFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CA60", Offset = "0x5A0BE60", VA = "0x185A0CA60")]
		get
		{
			return default(IMPAOGMALJN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public bool BHCKGGKPOPC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C2D0", Offset = "0x5A0B6D0", VA = "0x185A0C2D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool PGINDIHEEMD
	{
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C650", Offset = "0x5A0BA50", VA = "0x185A0C650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public bool OKIGMPOMPBL
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CA40", Offset = "0x5A0BE40", VA = "0x185A0CA40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public bool FKNDIMNEJFH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C2B0", Offset = "0x5A0B6B0", VA = "0x185A0C2B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public bool CHFBNGIGHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C2F0", Offset = "0x5A0B6F0", VA = "0x185A0C2F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public bool AHBLKBFDBJO
	{
		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C870", Offset = "0x5A0BC70", VA = "0x185A0C870")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public bool IDBILBIGDOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C630", Offset = "0x5A0BA30", VA = "0x185A0C630")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public bool HNBDDPEEACE
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BF60", Offset = "0x5A0B360", VA = "0x185A0BF60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool NICJDLFECMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CBA0", Offset = "0x5A0BFA0", VA = "0x185A0CBA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public MDACGIHIOLL ELKAPPPGOAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDACGIHIOLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public DPKHOKFPPKG BCJDOCHGNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(DPKHOKFPPKG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public GIFCCIBMBHL IKOFANNLAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(GIFCCIBMBHL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public LDCGBEAMPBC MLDGKIJFLOO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(LDCGBEAMPBC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public ACIBJGLLNOC JIOBCDMNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(ACIBJGLLNOC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public DNDKNBNCPPL PCIFCNMMDEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(DNDKNBNCPPL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public GDCONIFJKEF ODBJFCLPEAK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(GDCONIFJKEF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public bool CNIFBOMIGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C3A0", Offset = "0x5A0B7A0", VA = "0x185A0C3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public bool CHCHGAJNEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x5A0C5E0", Offset = "0x5A0B9E0", VA = "0x185A0C5E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool HELEBBENLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x823C20", Offset = "0x823020", VA = "0x180823C20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850", Slot = "5")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public GNBHPPAICCJ BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(GNBHPPAICCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public LFLEGGHCHLE LJHMBDPCDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(LFLEGGHCHLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public static MDECDPGCMCD LFFBPOODCDC(HEKFLAGDMLJ JBFCCDGDFOM)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C310", Offset = "0x5A0B710", VA = "0x185A0C310")]
	public IGCAMFAHCMC DKCGKPIOGPC()
	{
		return default(IGCAMFAHCMC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5A0CB40", Offset = "0x5A0BF40", VA = "0x185A0CB40")]
	public LMAAIPGHEAK NLADCFLIDHA()
	{
		return default(LMAAIPGHEAK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C750", Offset = "0x5A0BB50", VA = "0x185A0C750")]
	public CPKDMKEIOOA HNECACJCAPG()
	{
		return default(CPKDMKEIOOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C4B0", Offset = "0x5A0B8B0", VA = "0x185A0C4B0")]
	public KBEIKKHCOLG ELPBIEMBEJO()
	{
		return default(KBEIKKHCOLG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C950", Offset = "0x5A0BD50", VA = "0x185A0C950")]
	public void LPGPBDHIJGJ([Optional] object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C890", Offset = "0x5A0BC90", VA = "0x185A0C890")]
	public bool KLHFNHDCKBB(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C7B0", Offset = "0x5A0BBB0", VA = "0x185A0C7B0")]
	public bool IBFCLOIPLKD(object AEMEEHLIDCM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A0CC80", Offset = "0x5A0C080", VA = "0x185A0CC80", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public MDECDPGCMCD(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(MDECDPGCMCD AGLCIEKHLEE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public static HEKFLAGDMLJ LFFBPOODCDC(MDECDPGCMCD AGLCIEKHLEE)
	{
		return default(HEKFLAGDMLJ);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5A0CBC0", Offset = "0x5A0BFC0", VA = "0x185A0CBC0")]
	public static bool PHJEMBLBEDF(MDECDPGCMCD NPBBJPKPNCJ, MDECDPGCMCD KBAEKPMBMFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C0D0", Offset = "0x5A0B4D0", VA = "0x185A0C0D0")]
	public static bool AHGPMPLECPJ(MDECDPGCMCD NPBBJPKPNCJ, MDECDPGCMCD KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x5A0C540", Offset = "0x5A0B940", VA = "0x185A0C540", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "6")]
	public bool Equals(MDECDPGCMCD ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public delegate void AFNDKOFPEDG(CNKGMANFGNC MLIKEDEPLPO);
[Cpp2IlInjected.Token(Token = "0x2000017")]
[DefaultMember("Item")]
public struct EJEPEEGCAKM : IList<HEKFLAGDMLJ>, ICollection<HEKFLAGDMLJ>, IEnumerable<HEKFLAGDMLJ>, IEnumerable, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public struct KAOCOBBFPOA : IEnumerator<HEKFLAGDMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private readonly IMBCAHJKJCI CNNBPGGDJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private NativeArray<LocalId>.Enumerator OMJENHBNMFI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public HEKFLAGDMLJ AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x600008A")]
			[Cpp2IlInjected.Address(RVA = "0x5A09520", Offset = "0x5A08920", VA = "0x185A09520", Slot = "4")]
			get
			{
				return default(HEKFLAGDMLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600008B")]
			[Cpp2IlInjected.Address(RVA = "0x5A09470", Offset = "0x5A08870", VA = "0x185A09470", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x176A550", Offset = "0x1769950", VA = "0x18176A550")]
		public KAOCOBBFPOA(IMBCAHJKJCI CNNBPGGDJCA, NativeArray<LocalId>.Enumerator OMJENHBNMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5A093B0", Offset = "0x5A087B0", VA = "0x185A093B0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5A093F0", Offset = "0x5A087F0", VA = "0x185A093F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5A09430", Offset = "0x5A08830", VA = "0x185A09430", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private NativeList<LocalId> GAOJFDPACED;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public HEKFLAGDMLJ ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x5A02070", Offset = "0x5A01470", VA = "0x185A02070", Slot = "4")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x5A020F0", Offset = "0x5A014F0", VA = "0x185A020F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x5A01AF0", Offset = "0x5A00EF0", VA = "0x185A01AF0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x5A01AF0", Offset = "0x5A00EF0", VA = "0x185A01AF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public bool BAJNPCIAOLM
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x822D60", Offset = "0x822160", VA = "0x180822D60", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x5A01FE0", Offset = "0x5A013E0", VA = "0x185A01FE0")]
	public EJEPEEGCAKM(IMBCAHJKJCI CNNBPGGDJCA, int HBBGBOONHJE, Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5A01C10", Offset = "0x5A01010", VA = "0x185A01C10")]
	public FDJPAKEFOJE JOPIGDJALMC()
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5A017D0", Offset = "0x5A00BD0", VA = "0x185A017D0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5A01810", Offset = "0x5A00C10", VA = "0x185A01810", Slot = "13")]
	public bool Contains(HEKFLAGDMLJ CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5A01870", Offset = "0x5A00C70", VA = "0x185A01870", Slot = "14")]
	public void CopyTo(HEKFLAGDMLJ[] EACKPMFPNLH, int LKNMOMDDHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5A01770", Offset = "0x5A00B70", VA = "0x185A01770", Slot = "11")]
	public void Add(HEKFLAGDMLJ CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x5A01B90", Offset = "0x5A00F90", VA = "0x185A01B90", Slot = "7")]
	public void Insert(int BNOAGGNAMKG, HEKFLAGDMLJ CFHFBNLLHPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5A01D70", Offset = "0x5A01170", VA = "0x185A01D70", Slot = "15")]
	public bool Remove(HEKFLAGDMLJ CFHFBNLLHPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5A01B30", Offset = "0x5A00F30", VA = "0x185A01B30", Slot = "6")]
	public int IndexOf(HEKFLAGDMLJ CFHFBNLLHPN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5A01D20", Offset = "0x5A01120", VA = "0x185A01D20", Slot = "8")]
	public void RemoveAt(int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5A01AB0", Offset = "0x5A00EB0", VA = "0x185A01AB0", Slot = "18")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5A01C90", Offset = "0x5A01090", VA = "0x185A01C90")]
	public KAOCOBBFPOA MHIEAIINAGJ()
	{
		return default(KAOCOBBFPOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5A01E00", Offset = "0x5A01200", VA = "0x185A01E00", Slot = "16")]
	private IEnumerator<HEKFLAGDMLJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5A01EF0", Offset = "0x5A012F0", VA = "0x185A01EF0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface HEGBKEOPNPO
{
	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	bool JDNLFCKFPLB
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	bool CEOFMCJKBEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface PNJMMCGHBPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000030")]
	MADGLDNBLBE GICNPGEAMLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	IHJJJPNMOBB CHPEGAACEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LBMFIGDMGJJ(Transform DKKDEHMFAEC);

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void JKMEMMKHMPJ(Transform DKKDEHMFAEC, FBALIINALIE FPMJOKBNFCF);

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJABFMIODAC(Transform DKKDEHMFAEC, KKFFAKHFGOF EFDJMBALOBC);
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface EKDKPLKGAMN
{
	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMAPLLCJFCD(in float3 CNCAEFCOEJK, in float3 GCNKNLGIDOA, float AKODDLNKMDE, out EIPPCECOLNJ MGALLJFBEGH, out HEKFLAGDMLJ EFDPMAIOLJO);
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
[DefaultMember("Item")]
public readonly struct MKIIJMKIKEO : IEquatable<MKIIJMKIKEO>
{
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public static readonly MKIIJMKIKEO BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private EPICOOKCMFM CNENFCIOLAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5A0CFB0", Offset = "0x5A0C3B0", VA = "0x185A0CFB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public LMAAIPGHEAK PKCKGAEHHFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(LMAAIPGHEAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public MGFBLKCEIKC NEPJAFFIHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5A0DD10", Offset = "0x5A0D110", VA = "0x185A0DD10")]
		get
		{
			return default(MGFBLKCEIKC);
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D040", Offset = "0x5A0C440", VA = "0x185A0D040")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	public IEnumerable<JNJDEHCDHNA> HDIJNLNMPLN
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D760", Offset = "0x5A0CB60", VA = "0x185A0D760")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000036")]
	public JNJDEHCDHNA ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D560", Offset = "0x5A0C960", VA = "0x185A0D560")]
		get
		{
			return default(JNJDEHCDHNA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D680", Offset = "0x5A0CA80", VA = "0x185A0D680")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public GNBHPPAICCJ BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(GNBHPPAICCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x5A0D460", Offset = "0x5A0C860", VA = "0x185A0D460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x5A0D240", Offset = "0x5A0C640", VA = "0x185A0D240")]
	public JNJDEHCDHNA DINKMEMLJBL(float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] Vector3? ECOCGLBAPIP)
	{
		return default(JNJDEHCDHNA);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x5A0D940", Offset = "0x5A0CD40", VA = "0x185A0D940")]
	public JNJDEHCDHNA ONBMGKENJDO(int BNOAGGNAMKG, float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] Vector3? ECOCGLBAPIP)
	{
		return default(JNJDEHCDHNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x5A0D150", Offset = "0x5A0C550", VA = "0x185A0D150")]
	public void CBBHEGILAAP(int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x5A0DB70", Offset = "0x5A0CF70", VA = "0x185A0DB70")]
	public void PDPMCCCKLBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public MKIIJMKIKEO(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(MKIIJMKIKEO AGLCIEKHLEE)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x5A0DC50", Offset = "0x5A0D050", VA = "0x185A0DC50")]
	public static bool PHJEMBLBEDF(MKIIJMKIKEO NPBBJPKPNCJ, MKIIJMKIKEO KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x5A0D4C0", Offset = "0x5A0C8C0", VA = "0x185A0D4C0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(MKIIJMKIKEO ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface NKIFCJBAGBF
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	Type PFIICEHAGHI
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface ONIGLBMFNHJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NPIIJNENMJN(HEKFLAGDMLJ LEMCMBEMOCB, out Collider MPDBOOOIMLM);

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject GBGGIADKNGG(HEKFLAGDMLJ NPELOIPPNLL, GameObject OGOBDKNMJKA, Vector3 IEGBDEAOAGE, Quaternion IKMDCPAAKBK);

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void PJPDOOGDNJI(GameObject MPDBOOOIMLM);

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(Slot = "3")]
	TCollider EOKACEMHNHK<TCollider>(GameObject MFGCADNGCJE) where TCollider : Collider;

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJPCMLGELKH(Collider MPDBOOOIMLM);

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(Slot = "5")]
	GameObject DLIFOBLKBKC<TCollider>(string GDKOBCHHFLB) where TCollider : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface GPKGHEJLJCL : IEPDOHHLJHK<JDPNCHCMAIA>, LKKBEGLFKGM, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface MBMDIHFFGKJ<T> : FIPEENHHKAO<JDPNCHCMAIA, T>, IEPDOHHLJHK<JDPNCHCMAIA>, LKKBEGLFKGM, IDisposable, GPKGHEJLJCL where T : struct
{
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class ALDAHOMJGGD
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x10244D0", Offset = "0x10238D0", VA = "0x1810244D0")]
	public static bool HBBLEOHJDFE<T>(this IEPDOHHLJHK<JDPNCHCMAIA> LEMJCNJPDLJ, JDPNCHCMAIA DDCHJBPICDC, out T AGLCIEKHLEE) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x21962C0", Offset = "0x21956C0", VA = "0x1821962C0")]
	public static bool AFLFAPDAOKF<T>(this IEPDOHHLJHK<JDPNCHCMAIA> LEMJCNJPDLJ, JDPNCHCMAIA DDCHJBPICDC, in T PINJDLEFOFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface GBFIINBNALL
{
	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DAGEPHNCAOH();
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public readonly struct GDCONIFJKEF : IEquatable<GDCONIFJKEF>
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public static readonly GDCONIFJKEF BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	private LJNPGILBMKJ BPIFKBINNLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x5A032A0", Offset = "0x5A026A0", VA = "0x185A032A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public bool GLEDIKEEJGK
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x5A030C0", Offset = "0x5A024C0", VA = "0x185A030C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public Guid INBHDLKLECA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5A02F20", Offset = "0x5A02320", VA = "0x185A02F20")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public bool PIDCGHFEMCA
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5A02CE0", Offset = "0x5A020E0", VA = "0x185A02CE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public Guid GLMAJHDOAKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5A03610", Offset = "0x5A02A10", VA = "0x185A03610")]
		get
		{
			return default(Guid);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A02DC0", Offset = "0x5A021C0", VA = "0x185A02DC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5A03510", Offset = "0x5A02910", VA = "0x185A03510")]
	public bool NHHLJEGKOGI(out Guid AANELEBBHAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5A031A0", Offset = "0x5A025A0", VA = "0x185A031A0")]
	public void IHKEJEODIPF(Guid GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5A03330", Offset = "0x5A02730", VA = "0x185A03330")]
	public bool KCFEBCKBICI(out Guid MNLPDHHHFIF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x5A02E20", Offset = "0x5A02220", VA = "0x185A02E20")]
	public void EEPLPMNOMOL(Guid GBFJPNOAMDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x5A03430", Offset = "0x5A02830", VA = "0x185A03430")]
	public void LEPGKOCONPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public GDCONIFJKEF(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(GDCONIFJKEF AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5A03020", Offset = "0x5A02420", VA = "0x185A03020", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(GDCONIFJKEF ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public readonly struct DPKHOKFPPKG : IEquatable<DPKHOKFPPKG>
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public static readonly DPKHOKFPPKG BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x5A014D0", Offset = "0x5A008D0", VA = "0x185A014D0")]
	public void EHKLIGBABLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A01650", Offset = "0x5A00A50", VA = "0x185A01650")]
	public void FCGGIDBOLFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public DPKHOKFPPKG(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x5A015B0", Offset = "0x5A009B0", VA = "0x185A015B0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(DPKHOKFPPKG ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public interface KINEJENHFEI : GLHHELGFOCN
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	DBDEKGOAMDF GAIBMIMMKDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	bool JPMGNMKAIOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	GameObject NNAKJIJAOJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000005")]
	event Action<KINEJENHFEI> FCOPPBGBHAA;

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OnEmbody(ICCLAPFHPJL GLBDCLCAOJH, HEKFLAGDMLJ MPCCMHGJCME);

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OnPreDisembody();

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OnDisembody(bool MAALBIDADJA);

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void NotifyInitialized();
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class JDIBFLIAFNF
{
	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A080E0", Offset = "0x5A074E0", VA = "0x185A080E0")]
	public static bool CNIFBOMIGIC(this KINEJENHFEI LGIGGJMIOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5A08040", Offset = "0x5A07440", VA = "0x185A08040")]
	public static bool BCOMEHPKHMF(this KINEJENHFEI LGIGGJMIOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x5A08090", Offset = "0x5A07490", VA = "0x185A08090")]
	public static bool BFMEKLKINKF(this KINEJENHFEI LGIGGJMIOOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x5A08130", Offset = "0x5A07530", VA = "0x185A08130")]
	public static bool JJHNMLEHLGB(this KINEJENHFEI LGIGGJMIOOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface IPHFEDLNEOL
{
	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HKLEILGELBL(GameObject NNAKJIJAOJG);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public readonly struct JMKCCCNOCPC : IEquatable<JMKCCCNOCPC>
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static readonly JMKCCCNOCPC BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A086E0", Offset = "0x5A07AE0", VA = "0x185A086E0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(JMKCCCNOCPC ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface GLKFEKFDENH
{
	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void CJDBNDMLJCH(NativeListAsync<Entity> PDEHPAFDMCJ);

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFEPMJBOFDP(AOOJDPMKIIA PNICBAANHHH);

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EENCMLEMDJN(NativeListAsync<Entity> JNOIEAACCBL, bool GJHNOJOPHID);

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void NOFIGPOBCNP();
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface PJGBPHCHLPE
{
	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool LJCCGKMCMAM(HEKFLAGDMLJ LEMCMBEMOCB, KKEKCMELKKJ AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface EHLKKIDPCHN
{
	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GKGKJPMACBL();

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void NIABPELNNHE();

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MJJHEMGMNJK();

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void OGBCMCOINPK();

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FHFAJAIMJNH();

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GKGOBDGENHK();

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void OFEBKDILOCB();

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IEMLMDBJMMD();

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OONBANEIOCL();

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void LLJGJHNOFKO();

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void IMONOOFMJKL();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public readonly struct OMJPGCFKPLM : IEquatable<OMJPGCFKPLM>
{
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	internal const int HFBEFHEPJND = 1;

	[Cpp2IlInjected.Token(Token = "0x4000018")]
	internal const int MABGIDFBMNE = 4;

	[Cpp2IlInjected.Token(Token = "0x4000019")]
	internal const int OJLPLIIABHE = 8;

	[Cpp2IlInjected.Token(Token = "0x400001A")]
	internal const int OHNBPDIMPCA = 24;

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	internal const uint KHCDBMEDDAB = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	internal const uint GKHDCMDCLFN = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private readonly uint PAHMPOAEKCN;

	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static uint[] KCIHKMODENE;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static IMBCAHJKJCI[] CEMAJLICLCP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static uint OCEOKEJKDIA;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public IMBCAHJKJCI AOIELPCNGFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x5A0EAF0", Offset = "0x5A0DEF0", VA = "0x185A0EAF0")]
	static OMJPGCFKPLM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
	internal OMJPGCFKPLM(uint AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x3DA53C0", Offset = "0x3DA47C0", VA = "0x183DA53C0", Slot = "4")]
	public bool Equals(OMJPGCFKPLM ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E2E0", Offset = "0x5A0D6E0", VA = "0x185A0E2E0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E9F0", Offset = "0x5A0DDF0", VA = "0x185A0E9F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E370", Offset = "0x5A0D770", VA = "0x185A0E370")]
	private IMBCAHJKJCI GLDNMHADPDE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E590", Offset = "0x5A0D990", VA = "0x185A0E590")]
	private static uint LENCHPICOIF(uint PAHMPOAEKCN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E530", Offset = "0x5A0D930", VA = "0x185A0E530")]
	private static (uint, uint) IAHBPEJAMMN(uint PAHMPOAEKCN)
	{
		return default((uint, uint));
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E9E0", Offset = "0x5A0DDE0", VA = "0x185A0E9E0")]
	private static uint OBALKDMKIDD(uint LJJHJABONIO, uint BNOAGGNAMKG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E0E0", Offset = "0x5A0D4E0", VA = "0x185A0E0E0")]
	internal static OMJPGCFKPLM EHBDNPLCIKI(IMBCAHJKJCI DEMMAINGNBB)
	{
		return default(OMJPGCFKPLM);
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E830", Offset = "0x5A0DC30", VA = "0x185A0E830")]
	internal static void OAPBCJNJKMP(OMJPGCFKPLM PAHMPOAEKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5A0E5A0", Offset = "0x5A0D9A0", VA = "0x185A0E5A0")]
	private static void LHANLKMMABF(int GLDHDJHPIPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public interface JGECFECPNBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	int FDMDKOOPHNL
	{
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	NativeArray<EntityRemapUtility.EntityRemapInfo> NLAOAIANNAM
	{
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HEKFLAGDMLJ FCOJNMGNAII(HEKFLAGDMLJ GAOJFDPACED);
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public interface OIKHNPIFCIP : IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public readonly struct LDCGBEAMPBC : IEquatable<LDCGBEAMPBC>
{
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public static readonly LDCGBEAMPBC BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	private APNDFEBFPEA GHHJIGKHNEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A3D0", Offset = "0x5A097D0", VA = "0x185A0A3D0")]
		get
		{
			return default(APNDFEBFPEA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public bool CCMPBLCJOBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A680", Offset = "0x5A09A80", VA = "0x185A0A680")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public bool FBMHFPKDKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A4D0", Offset = "0x5A098D0", VA = "0x185A0A4D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool IIJNPGACING
	{
		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A900", Offset = "0x5A09D00", VA = "0x185A0A900")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool OEIHLNPFMGM
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A510", Offset = "0x5A09910", VA = "0x185A0A510")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public bool IIELIDGLJAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A4F0", Offset = "0x5A098F0", VA = "0x185A0A4F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public bool MFHOADEKJAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A010", Offset = "0x5A09410", VA = "0x185A0A010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public bool FGIGEHGFFBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A500", Offset = "0x5A09900", VA = "0x185A0A500")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public bool KIEFHPFBJMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x5A09F90", Offset = "0x5A09390", VA = "0x185A09F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public bool OEEPBGEPGLC
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A6E0", Offset = "0x5A09AE0", VA = "0x185A0A6E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public bool DKNIIPOHOAO
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A4E0", Offset = "0x5A098E0", VA = "0x185A0A4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public bool BOPDIFLEKGI
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A090", Offset = "0x5A09490", VA = "0x185A0A090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public bool DOEHEDLKPOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A6F0", Offset = "0x5A09AF0", VA = "0x185A0A6F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public bool MLLGJDNHKAD
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A150", Offset = "0x5A09550", VA = "0x185A0A150")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public bool IFKOBBPPCOA
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x5A09F80", Offset = "0x5A09380", VA = "0x185A09F80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool PGFJHDLOHOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A0A0", Offset = "0x5A094A0", VA = "0x185A0A0A0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A080", Offset = "0x5A09480", VA = "0x185A0A080")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool PPCNJENLBMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A7E0", Offset = "0x5A09BE0", VA = "0x185A0A7E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public BCPJINOKPFK KICAICKBKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x5A09FA0", Offset = "0x5A093A0", VA = "0x185A09FA0")]
		get
		{
			return default(BCPJINOKPFK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public bool ICDDAIJBPKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A290", Offset = "0x5A09690", VA = "0x185A0A290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public Vector3 CNDPEGIOLKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A520", Offset = "0x5A09920", VA = "0x185A0A520")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public Vector3 LEAKNOHGEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A310", Offset = "0x5A09710", VA = "0x185A0A310")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public bool KHNNDCNKBKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A160", Offset = "0x5A09560", VA = "0x185A0A160")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x5A0A020", Offset = "0x5A09420", VA = "0x185A0A020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A600", Offset = "0x5A09A00", VA = "0x185A0A600")]
	public bool LOGKPCNHLDO(DEGFEGGODAD BEAPEKCODAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A700", Offset = "0x5A09B00", VA = "0x185A0A700")]
	public bool PDBACICCBOK(JAGLKDCKPOP BEAPEKCODAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A440", Offset = "0x5A09840", VA = "0x185A0A440")]
	public void IAFPFNJOEOG(JAGLKDCKPOP BEAPEKCODAF, bool MOLHIOPHPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public LDCGBEAMPBC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A0B0", Offset = "0x5A094B0", VA = "0x185A0A0B0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(LDCGBEAMPBC ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public enum KPBHHFJCLAD
{
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	Disabled,
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	Enabled,
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	Indeterminate
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BAGFHKOKEKL
{
	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x11D09C0", Offset = "0x11CFDC0", VA = "0x1811D09C0")]
	public static bool LMEPDIEHCCC(this KPBHHFJCLAD HEAMCFPFNOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x11D09A0", Offset = "0x11CFDA0", VA = "0x1811D09A0")]
	public static bool INKNBDJDOPK(this KPBHHFJCLAD HEAMCFPFNOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4333B40", Offset = "0x4332F40", VA = "0x184333B40")]
	public static bool KLIDGKJCEBJ(this KPBHHFJCLAD HEAMCFPFNOL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface ICCLAPFHPJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	World HBDGJGALOFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	World GLGFHNDCHEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	EntityManager NAPOFGNIKAG
	{
		[Cpp2IlInjected.Token(Token = "0x600013A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(Slot = "4")]
	ComponentSystemBase DGLBDIOIPBK(Type GANFKPHKNKH);
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public static class KGDFGIICLIE
{
	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x5A09AA0", Offset = "0x5A08EA0", VA = "0x185A09AA0")]
	public static ComponentSystemBase PMEODIGDPJI(this World GLBDCLCAOJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x1D928D0", Offset = "0x1D91CD0", VA = "0x181D928D0")]
	public static T DGLBDIOIPBK<T>(this ICCLAPFHPJL JPBBMKJHAGN) where T : ComponentSystemBase
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public readonly struct JPKFBBKCAIK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	private readonly CNKGMANFGNC CLCAIFLMLCJ;

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public FDJPAKEFOJE OPJBEJIEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x176B800", Offset = "0x176AC00", VA = "0x18176B800")]
		get
		{
			return default(FDJPAKEFOJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x5A09380", Offset = "0x5A08780", VA = "0x185A09380")]
	public JPKFBBKCAIK(CNKGMANFGNC CLCAIFLMLCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x5A09050", Offset = "0x5A08450", VA = "0x185A09050")]
	public FDJPAKEFOJE DHKAEJJGOKM()
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x5A09120", Offset = "0x5A08520", VA = "0x185A09120")]
	public FDJPAKEFOJE INEIGIHCJAA()
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x5A091F0", Offset = "0x5A085F0", VA = "0x185A091F0")]
	public (FDJPAKEFOJE, FDJPAKEFOJE, FDJPAKEFOJE) PHGLOPEHIMO()
	{
		return default((FDJPAKEFOJE, FDJPAKEFOJE, FDJPAKEFOJE));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public readonly struct LFLEGGHCHLE : IEquatable<LFLEGGHCHLE>
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly LFLEGGHCHLE BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	private OHAMPNBKDLP JMGGHFJACJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5A0AEA0", Offset = "0x5A0A2A0", VA = "0x185A0AEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public HEKFLAGDMLJ GNPLPKJOMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x5A0AC80", Offset = "0x5A0A080", VA = "0x185A0AC80")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	public MDECDPGCMCD BDHKOBIGIFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x5A0AA70", Offset = "0x5A09E70", VA = "0x185A0AA70")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public MDECDPGCMCD LECOLGFBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0x5A0AD90", Offset = "0x5A0A190", VA = "0x185A0AD90")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000150")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5A0AB80", Offset = "0x5A09F80", VA = "0x185A0AB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x5A0A950", Offset = "0x5A09D50", VA = "0x185A0A950")]
	public bool CILNNMACHKK(MDECDPGCMCD OJBGDMNECON, bool KJNJDCMKFAL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x5A0AF30", Offset = "0x5A0A330", VA = "0x185A0AF30")]
	public bool LOJMEIIDDGG(MDECDPGCMCD BGACBDKLDPA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public LFLEGGHCHLE(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x5A0ABE0", Offset = "0x5A09FE0", VA = "0x185A0ABE0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(LFLEGGHCHLE ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface LBENECEAHJK
{
	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void GDADIPMHFAD(string FHDJIGKOLJM);
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public readonly struct DCMGEEAECJC : IEquatable<DCMGEEAECJC>
{
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public static readonly DCMGEEAECJC BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	private FEFNCNFEEIH LOCKEPPJINO
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5A00F90", Offset = "0x5A00390", VA = "0x185A00F90")]
		get
		{
			return default(FEFNCNFEEIH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public LDPBHDEACKL OODNICOBGKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5A00F10", Offset = "0x5A00310", VA = "0x185A00F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public DCMGEEAECJC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x5A01000", Offset = "0x5A00400", VA = "0x185A01000", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(DCMGEEAECJC ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface KFDENICELLH
{
	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	string ENMLMGPDGCC
	{
		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	GameObject[] IJJEHLFDDHG(IEnumerable<GGLLEGPCFPG> COINOLJIGKE);

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "2")]
	JDPNCHCMAIA PKFNONNOICJ(Guid ACBMOMJONAM);

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool BHJDFEFEPOL(GameObject NNAKJIJAOJG, out JDPNCHCMAIA DDCHJBPICDC);

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(Slot = "4")]
	bool DEPFIGPJDNI(GameObject NNAKJIJAOJG, out int KJFKNKIKHHN, out IMPAOGMALJN JBGKOICMKNG);

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(Slot = "5")]
	KINEJENHFEI NJOEOHENBPH(GGLLEGPCFPG OALKBFHLHKE);

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(Slot = "6")]
	KINEJENHFEI NJOEOHENBPH(string KNPFDHANMOI, JDPNCHCMAIA DDCHJBPICDC, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, Vector3 ECOCGLBAPIP);

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void PBPDINCCFCM(GameObject CLKBFEDCOHF, bool BHEFCHPMIBI);

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void FDLIGKBCAIN(GameObject NNAKJIJAOJG, bool EHIFCDLNGIN, bool CNCFOGPJCKI);
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MJFMILPJLLC
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x5A0CDE0", Offset = "0x5A0C1E0", VA = "0x185A0CDE0")]
	public static KINEJENHFEI NJOEOHENBPH(this KFDENICELLH EOPIGBOAJOB, JDPNCHCMAIA DDCHJBPICDC, Vector3 FGLOAKJBDBO, Quaternion OCEJJKMFIJB, Vector3 ECOCGLBAPIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface CCGILDPDHKO
{
	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	KKFFAKHFGOF FCHLICPLNCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(Slot = "1")]
		set;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface NNFPBHEJLKI
{
	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	World ALGDIKEMKBL();

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	World PFJDPFFMNHJ();

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	World BJODIHFMCOA();

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	World EBGHHEMKOED();
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface EEKNAEJEFGF
{
	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	GOACFOHKEAA HBHMJOBMNKC
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	KFDENICELLH OFHGLFHAELL
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	FHJJAMLGNLD HKNCEJNPJII
	{
		[Cpp2IlInjected.Token(Token = "0x6000170")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	IFPFMOBMMJJ JGFNMBKDLFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000171")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	IPHFEDLNEOL FLKENKPMODI
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	LEHIKHOEAMN PFLFOFIHPDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	HEGBKEOPNPO AEHHKDKCOIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000084")]
	FKKAJAEPALJ GNDJHGHKFLI
	{
		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface JNNIICEICBE
{
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public struct PAAEECCICPH : LDJIGAKAEPB, IEquatable<PAAEECCICPH>
{
	[Cpp2IlInjected.Token(Token = "0x17000085")]
	public int FKHPMLNOHLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "4")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350", Slot = "5")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000086")]
	public int BLBNLGCJCGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x176BAF0", Offset = "0x176AEF0", VA = "0x18176BAF0", Slot = "6")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x2954C40", Offset = "0x2954040", VA = "0x182954C40", Slot = "7")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x5A0EB00", Offset = "0x5A0DF00", VA = "0x185A0EB00", Slot = "8")]
	public bool Equals(PAAEECCICPH ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x5A0EB50", Offset = "0x5A0DF50", VA = "0x185A0EB50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface HPKBHAJJNGO
{
	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHBDNPLCIKI(LOHCJILDMLL LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL);

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void OAPBCJNJKMP(LOHCJILDMLL LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL);
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public struct BACOLBMJCKD : AKHJKCAIBOP, IEquatable<BACOLBMJCKD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public IMPAOGMALJN JBGKOICMKNG;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x5A005D0", Offset = "0x59FF9D0", VA = "0x185A005D0", Slot = "5")]
	public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5A005A0", Offset = "0x59FF9A0", VA = "0x185A005A0", Slot = "4")]
	public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5A00690", Offset = "0x59FFA90", VA = "0x185A00690", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3DA53C0", Offset = "0x3DA47C0", VA = "0x183DA53C0", Slot = "6")]
	public bool Equals(BACOLBMJCKD ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x5A00600", Offset = "0x59FFA00", VA = "0x185A00600", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface POKOBOIBHEN
{
	[Cpp2IlInjected.Token(Token = "0x17000087")]
	bool JDNLFCKFPLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x14000006")]
	event Action PBLAFGAPNDF;

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FJDLLGFKIPL(bool OMIGIJBCKAP);

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool PPDPHLPNKOF(ByteString DCBJJADOEJL);

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FCDBHEJBCCB();

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void ICPOGOKNJNE();

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void LBDHAKIGGON();
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface APLOJNPIIKE
{
	[Cpp2IlInjected.Token(Token = "0x17000088")]
	FIPBNNCGAFF BGCEJHPHLAB
	{
		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000089")]
	List<FLJMOFPACJP> BEAJLOOMGJG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool KOHBPKJMHDI(FLJMOFPACJP LEMJCNJPDLJ, out FIPBNNCGAFF BBMDLCNKBEA);

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EHBDNPLCIKI(FLJMOFPACJP LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL);

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OAPBCJNJKMP(FLJMOFPACJP LEMJCNJPDLJ, AFNDKOFPEDG NMBCGMHEDGL);
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface CCJFAELPJMH
{
	[Cpp2IlInjected.Token(Token = "0x1700008A")]
	MJDIGAKBJCH BLHBBOIDGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public readonly struct KBEIKKHCOLG : IEquatable<KBEIKKHCOLG>
{
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public static readonly KBEIKKHCOLG BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x1700008B")]
	private HKJFJAJNFAP KCOBCOGNIFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x5A099D0", Offset = "0x5A08DD0", VA = "0x185A099D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008C")]
	public float3 JDJLLBFNHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x5A098C0", Offset = "0x5A08CC0", VA = "0x185A098C0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008D")]
	public quaternion CPECFJDFLAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x5A097C0", Offset = "0x5A08BC0", VA = "0x185A097C0")]
		get
		{
			return default(quaternion);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008E")]
	public MDECDPGCMCD FDKEGNKIDJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x5A09690", Offset = "0x5A08A90", VA = "0x185A09690")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700008F")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000090")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000091")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000092")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x5A09590", Offset = "0x5A08990", VA = "0x185A09590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public KBEIKKHCOLG(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public static HEKFLAGDMLJ LFFBPOODCDC(KBEIKKHCOLG AGLCIEKHLEE)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5A095F0", Offset = "0x5A089F0", VA = "0x185A095F0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(KBEIKKHCOLG ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface LANNINJFJNI
{
	[Cpp2IlInjected.Token(Token = "0x14000007")]
	event Action ICPOGOKNJNE;

	[Cpp2IlInjected.Token(Token = "0x14000008")]
	event Action OPOMLBLJGOE;

	[Cpp2IlInjected.Token(Token = "0x14000009")]
	event Action HFGAACOJJFK;
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public interface FIPBNNCGAFF
{
	[Cpp2IlInjected.Token(Token = "0x17000093")]
	string OHELEMNJIDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000094")]
	FIPBNNCGAFF NFIKKLEFHMH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000095")]
	IEnumerable<FIPBNNCGAFF> FEDNICELKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
[DefaultMember("Item")]
public struct FDJPAKEFOJE : IReadOnlyList<HEKFLAGDMLJ>, IEnumerable<HEKFLAGDMLJ>, IEnumerable, IReadOnlyCollection<HEKFLAGDMLJ>, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public struct IAEBGBFLJKN : IEnumerator<HEKFLAGDMLJ>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private readonly IMBCAHJKJCI CNNBPGGDJCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private NativeArray<LocalId>.Enumerator OMJENHBNMFI;

		[Cpp2IlInjected.Token(Token = "0x1700009D")]
		public HEKFLAGDMLJ AOPJILKHAOB
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x5A06FF0", Offset = "0x5A063F0", VA = "0x185A06FF0", Slot = "4")]
			get
			{
				return default(HEKFLAGDMLJ);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700009E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(RVA = "0x5A06F40", Offset = "0x5A06340", VA = "0x185A06F40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BC")]
		[Cpp2IlInjected.Address(RVA = "0x176A550", Offset = "0x1769950", VA = "0x18176A550")]
		public IAEBGBFLJKN(IMBCAHJKJCI CNNBPGGDJCA, NativeArray<LocalId>.Enumerator OMJENHBNMFI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x5A06E80", Offset = "0x5A06280", VA = "0x185A06E80", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x5A06EC0", Offset = "0x5A062C0", VA = "0x185A06EC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x5A06F00", Offset = "0x5A06300", VA = "0x185A06F00", Slot = "8")]
		public void Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private readonly IMBCAHJKJCI CNNBPGGDJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private NativeArray<LocalId> GAOJFDPACED;

	[Cpp2IlInjected.Token(Token = "0x17000096")]
	public HEKFLAGDMLJ ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A02880", Offset = "0x5A01C80", VA = "0x185A02880", Slot = "4")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5A02370", Offset = "0x5A01770", VA = "0x185A02370")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000097")]
	private int NKAFLAFLHGJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000098")]
	public IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x81F0A0", Offset = "0x81E4A0", VA = "0x18081F0A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000099")]
	public int NMCJNDHCAJI
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x81F160", Offset = "0x81E560", VA = "0x18081F160")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009A")]
	public bool NDGDBIMBJKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x5A02380", Offset = "0x5A01780", VA = "0x185A02380")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009B")]
	public NativeArray<LocalId> NGMMIOECKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x176BA60", Offset = "0x176AE60", VA = "0x18176BA60")]
		get
		{
			return default(NativeArray<LocalId>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700009C")]
	internal NativeArray<Entity> FFECOAFANCF
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x5A02230", Offset = "0x5A01630", VA = "0x185A02230")]
		get
		{
			return default(NativeArray<Entity>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A02630", Offset = "0x5A01A30", VA = "0x185A02630")]
	public FDJPAKEFOJE(int GLDHDJHPIPL, IMBCAHJKJCI CNNBPGGDJCA, Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x176A680", Offset = "0x1769A80", VA = "0x18176A680")]
	public FDJPAKEFOJE(IMBCAHJKJCI CNNBPGGDJCA, NativeArray<LocalId> GAOJFDPACED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x5A02810", Offset = "0x5A01C10", VA = "0x185A02810")]
	internal FDJPAKEFOJE(IMBCAHJKJCI CNNBPGGDJCA, NativeArray<Entity> NOEOKDNGNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x5A02770", Offset = "0x5A01B70", VA = "0x185A02770")]
	public FDJPAKEFOJE(IMBCAHJKJCI CNNBPGGDJCA, int HBBGBOONHJE, Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x5A026C0", Offset = "0x5A01AC0", VA = "0x185A026C0")]
	public FDJPAKEFOJE(FDJPAKEFOJE POIIEEMMHGD, Allocator DGGNDNPDKKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5A022D0", Offset = "0x5A016D0", VA = "0x185A022D0")]
	public FDJPAKEFOJE EMCLIHJFPMF(Allocator DGGNDNPDKKD = Allocator.Temp)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x5A02290", Offset = "0x5A01690", VA = "0x185A02290", Slot = "8")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A023C0", Offset = "0x5A017C0", VA = "0x185A023C0")]
	public IAEBGBFLJKN MHIEAIINAGJ()
	{
		return default(IAEBGBFLJKN);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x5A02450", Offset = "0x5A01850", VA = "0x185A02450", Slot = "6")]
	private IEnumerator<HEKFLAGDMLJ> System.Collections.Generic.IEnumerable<RecRoom.ObjectModel.ObjectLocalId>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x5A02540", Offset = "0x5A01940", VA = "0x185A02540", Slot = "7")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public struct JDPNCHCMAIA : IComparable<JDPNCHCMAIA>, IEquatable<JDPNCHCMAIA>, AKHJKCAIBOP
{
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public const uint JAPEGLKHOOM = 0u;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public const uint NKGIMJFPKHH = 255u;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly JDPNCHCMAIA ENEHFIHPPLN;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private const int OHNBPDIMPCA = 24;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private const uint KHCDBMEDDAB = 16777215u;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private const int JPKPEDFOFAI = 8;

	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private const uint EGDLMDLJACI = 4278190080u;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly uint GIJGKJOCENH;

	[Cpp2IlInjected.Token(Token = "0x1700009F")]
	public uint CPIIACDDPBO
	{
		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x17F5F30", Offset = "0x17F5330", VA = "0x1817F5F30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A0")]
	public uint EKGBCCDIAJC
	{
		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x5A083D0", Offset = "0x5A077D0", VA = "0x185A083D0")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A1")]
	public uint GFEECOFBPMP
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xA88D30", Offset = "0xA88130", VA = "0x180A88D30")]
		get
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A2")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x542D9A0", Offset = "0x542CDA0", VA = "0x18542D9A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
	public static JDPNCHCMAIA JKBKBBOAOOB(uint GIJGKJOCENH)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5A084B0", Offset = "0x5A078B0", VA = "0x185A084B0")]
	public JDPNCHCMAIA(int OAHDHLNKBLF, int DJFCIHLPCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5A084B0", Offset = "0x5A078B0", VA = "0x185A084B0")]
	public JDPNCHCMAIA(uint OAHDHLNKBLF, int DJFCIHLPCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x5A084B0", Offset = "0x5A078B0", VA = "0x185A084B0")]
	public JDPNCHCMAIA(uint OAHDHLNKBLF, uint DJFCIHLPCEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
	private JDPNCHCMAIA(uint GIJGKJOCENH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x542DA30", Offset = "0x542CE30", VA = "0x18542DA30")]
	public static bool PHJEMBLBEDF(JDPNCHCMAIA NPBBJPKPNCJ, JDPNCHCMAIA KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x5A082A0", Offset = "0x5A076A0", VA = "0x185A082A0", Slot = "5")]
	public bool Equals(JDPNCHCMAIA JNHCLKAAKHA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5A08300", Offset = "0x5A07700", VA = "0x185A08300", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x1D405C0", Offset = "0x1D3F9C0", VA = "0x181D405C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5A083E0", Offset = "0x5A077E0", VA = "0x185A083E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5A081D0", Offset = "0x5A075D0", VA = "0x185A081D0", Slot = "6")]
	public void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x5A08240", Offset = "0x5A07640", VA = "0x185A08240", Slot = "7")]
	public void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A08230", Offset = "0x5A07630", VA = "0x185A08230", Slot = "4")]
	public int CompareTo(JDPNCHCMAIA ICELKIGIKKP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface GGNFHIGGHPN
{
	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void LFDJFBMMDIA(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BOAKGFBBALM(Entity GKMECPLEALF, in float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(Slot = "2")]
	float3 LEGOMAEJGKP(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void PEJHJFHKCAB(Entity GKMECPLEALF, in quaternion AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(Slot = "4")]
	quaternion KAJNNNFBNMK(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void JHNJPPBMDFI(Entity GKMECPLEALF, out float3 FGLOAKJBDBO, out quaternion OCEJJKMFIJB);

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void JHNJPPBMDFI(Entity GKMECPLEALF, out RigidTransform IGFAAHIBKML);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IJHLFCJJJOP(Entity GKMECPLEALF, out RigidTransform IGFAAHIBKML);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(Slot = "8")]
	float3 OLGJOKILPEF(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KKIOCJEEKAD(Entity GKMECPLEALF, in float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void CLJCMNEALKH(Entity GKMECPLEALF, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(Slot = "11")]
	float LENHBKBDNOC(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void KLLOPNBMNLN(Entity GKMECPLEALF, in float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(Slot = "13")]
	float3 FPECNNNPDIO(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void IKHKFNJOIDD(Entity GKMECPLEALF, in float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(Slot = "15")]
	float3 BIBFBOKINNF(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HNDHIGLEAHI(Entity GKMECPLEALF, in quaternion AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(Slot = "17")]
	quaternion CKDDLMCPCBJ(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(Slot = "18")]
	float3 LDLMKAEFKOI(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(Slot = "19")]
	void FHKAOGFALKK(Entity GKMECPLEALF, in float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void KJGIBFOKIBF(Entity GKMECPLEALF, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(Slot = "21")]
	float FKKMKADPJLM(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(Slot = "22")]
	void LDEMGJAMPIP(Entity GKMECPLEALF, in float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float3 MLKKLKNFHGF(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void JAPGEPGMPCE(Entity GKMECPLEALF, out float4x4 KANIJOBCBKN);

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void IOCOEGNBODE(Entity GKMECPLEALF, in float4x4 KANIJOBCBKN);

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(Slot = "26")]
	void PJHLMELAEHD(Entity GKMECPLEALF, out float4x4 KANIJOBCBKN);

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(Slot = "27")]
	bool DAJCKLBFICP(Entity GKMECPLEALF, out Transform DKKDEHMFAEC);

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(Slot = "28")]
	void HIFNJJPAOGJ(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void GLBMEPBJMGF(Entity GKMECPLEALF, Entity PCAHPLBOKJA, Entity ICPFLJENDFI);
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public static class AHIAHLLFIPJ
{
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public readonly struct ALNGHMJNFBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly IEnumerable<GGLLEGPCFPG> COINOLJIGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly IReadOnlyList<GameObject> EFIIMJEDCML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly IReadOnlyList<int> HKJMOPHHLAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly IReadOnlyList<(JDPNCHCMAIA, JDPNCHCMAIA)> HGJGNAMNIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly int KCDHNOPNHOA;

	[Cpp2IlInjected.Token(Token = "0x170000A3")]
	public bool NNGOFJDJNOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x5A00390", Offset = "0x59FF790", VA = "0x185A00390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A4")]
	public int IAJOOMKAFHB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xA0C050", Offset = "0xA0B450", VA = "0x180A0C050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A5")]
	public IEnumerable<GameObject> ICFMJNJFGGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0xBC5870", Offset = "0xBC4C70", VA = "0x180BC5870")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A6")]
	public IEnumerable<(JDPNCHCMAIA src, JDPNCHCMAIA dst)> CDGCGKOAPKF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x5A003F0", Offset = "0x59FF7F0", VA = "0x185A003F0")]
	public ALNGHMJNFBH(IEnumerable<GGLLEGPCFPG> COINOLJIGKE, IReadOnlyList<GameObject> EFIIMJEDCML, IReadOnlyList<int> HKJMOPHHLAM, IReadOnlyList<(JDPNCHCMAIA src, JDPNCHCMAIA dst)> HGJGNAMNIMO, int KCDHNOPNHOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x59FFFE0", Offset = "0x59FF3E0", VA = "0x1859FFFE0")]
	public (GameObject, int)[] IKBGEBPEBLM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public readonly struct IGCAMFAHCMC : IEquatable<IGCAMFAHCMC>
{
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public static readonly IGCAMFAHCMC BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000A7")]
	private OHAMPNBKDLP JMGGHFJACJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x5A07810", Offset = "0x5A06C10", VA = "0x185A07810")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A8")]
	public FDJPAKEFOJE EDCHGFFLHEF
	{
		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x5A07670", Offset = "0x5A06A70", VA = "0x185A07670")]
		get
		{
			return default(FDJPAKEFOJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000A9")]
	public IEnumerable<MDECDPGCMCD> DDHIFCMPLOK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x5A07AC0", Offset = "0x5A06EC0", VA = "0x185A07AC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AA")]
	public IEnumerable<MDECDPGCMCD> MCDLLBHCCAK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x5A07290", Offset = "0x5A06690", VA = "0x185A07290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AB")]
	public int EHLNALMBLOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x5A07440", Offset = "0x5A06840", VA = "0x185A07440")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AC")]
	public int OACFFKHEKPH
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x5A07CC0", Offset = "0x5A070C0", VA = "0x185A07CC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AD")]
	public string ANHHJLAHIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5A07E40", Offset = "0x5A07240", VA = "0x185A07E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AE")]
	public HCMODPLKBON OIJMGHJPHAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5A07220", Offset = "0x5A06620", VA = "0x185A07220")]
		get
		{
			return default(HCMODPLKBON);
		}
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x5A07060", Offset = "0x5A06460", VA = "0x185A07060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000AF")]
	public EHCJCADIMGK ADECGDBDCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5A07780", Offset = "0x5A06B80", VA = "0x185A07780")]
		get
		{
			return default(EHCJCADIMGK);
		}
		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5A07C40", Offset = "0x5A07040", VA = "0x185A07C40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B0")]
	public bool AJLJIOMCJHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x5A077F0", Offset = "0x5A06BF0", VA = "0x185A077F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B1")]
	public bool LFDPLBPAGEC
	{
		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x5A070E0", Offset = "0x5A064E0", VA = "0x185A070E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B2")]
	public bool OFBFFKNEAHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x5A071E0", Offset = "0x5A065E0", VA = "0x185A071E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B3")]
	public bool PAPMBIGOHNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x5A07650", Offset = "0x5A06A50", VA = "0x185A07650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B4")]
	public bool PCLJHMJKDPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x5A07C30", Offset = "0x5A07030", VA = "0x185A07C30")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x5A07F10", Offset = "0x5A07310", VA = "0x185A07F10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B5")]
	public bool IJJBLECOCCM
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x5A07100", Offset = "0x5A06500", VA = "0x185A07100")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x5A073D0", Offset = "0x5A067D0", VA = "0x185A073D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B6")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B7")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B8")]
	public GNBHPPAICCJ BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(GNBHPPAICCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000B9")]
	public LFLEGGHCHLE LJHMBDPCDOC
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(LFLEGGHCHLE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BA")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000BB")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x5A073E0", Offset = "0x5A067E0", VA = "0x185A073E0")]
		get
		{
			return null;
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public static MDECDPGCMCD LFFBPOODCDC(IGCAMFAHCMC DOJDGHDKCLO)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x5A07200", Offset = "0x5A06600", VA = "0x185A07200")]
	public bool BMACJLCPBPI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x5A07110", Offset = "0x5A06510", VA = "0x185A07110")]
	public bool ALFFCNOJBIC(CAIENIPDHPC BEAPEKCODAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x5A075C0", Offset = "0x5A069C0", VA = "0x185A075C0")]
	public void FDNMBIPJPEG(CAIENIPDHPC BEAPEKCODAF, bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x5A078A0", Offset = "0x5A06CA0", VA = "0x185A078A0")]
	public FDJPAKEFOJE KKHDIMPIAHH(Allocator DGGNDNPDKKD)
	{
		return default(FDJPAKEFOJE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x5A07D10", Offset = "0x5A07110", VA = "0x185A07D10")]
	public void MBLEANBFMGK(IGCAMFAHCMC ICELKIGIKKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public IGCAMFAHCMC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(IGCAMFAHCMC AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x5A07520", Offset = "0x5A06920", VA = "0x185A07520", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(IGCAMFAHCMC ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface ODHMMPJEMFO
{
	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BDPOEBCAPPO(FDJPAKEFOJE GAOJFDPACED);

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(Slot = "1")]
	Vector3 LNLADOOOFAA(GameObject NNAKJIJAOJG, int KAPMHLBIPJM);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public readonly struct KIEIPIANMBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	internal readonly CJPDAFFDJMC OANIJIEMEHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	internal readonly CJPDAFFDJMC ELBJBJNOEIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	internal readonly uint LKAGEPKFLPL;

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x5A09B30", Offset = "0x5A08F30", VA = "0x185A09B30", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public readonly struct AOKIKEDMEMK
{
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	internal readonly KIEIPIANMBP NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5A00500", Offset = "0x59FF900", VA = "0x185A00500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public readonly struct LADLOPOEHHO
{
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	private static readonly EHKEPJIBENP IGCLICKKCHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	internal readonly KIEIPIANMBP NDPBOAHDPLI;

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x5A00500", Offset = "0x59FF900", VA = "0x185A00500", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public readonly struct AOBFCBJMENB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	internal readonly uint LKAGEPKFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	internal readonly bool DKJPHNANDCL;

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5A00460", Offset = "0x59FF860", VA = "0x185A00460", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface IFPFMOBMMJJ
{
	[Cpp2IlInjected.Token(Token = "0x170000BC")]
	bool OKLBKPGFPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BD")]
	bool PPIMJLMJCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BE")]
	bool FEFKMOJJKIB
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000BF")]
	bool LLLJNOBFINK
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(Slot = "3")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x600022E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JHBODONMFDH(object HOJNLEBJGLH);

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void CLEMKLJKHGL(object JNHEGOFDJBP);

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void IBGBPKHOLCD(object JNHEGOFDJBP);

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int NFEGHBEFLFC(GameObject OEHOBCLILGI);

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void HBLIGJFMGKJ(NativeArray<int> KMLKGAGAIBC);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface FIOENEMHNNB
{
	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void BEBJLEMGPFA(HEKFLAGDMLJ LEMCMBEMOCB, COBFMFPIDNL AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(Slot = "1")]
	COBFMFPIDNL FFCDGIAACKB(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000235")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GKKELJKGEHE(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000236")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EFGKFCOBOBC(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000237")]
	[Cpp2IlInjected.Address(Slot = "4")]
	int ONPGMOCNIHI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000238")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HEKFLAGDMLJ MPHOKIEHNNB(HEKFLAGDMLJ LEMCMBEMOCB, int BNOAGGNAMKG);

	[Cpp2IlInjected.Token(Token = "0x6000239")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CMHPBHFEGGF(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600023A")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EAFBNGGMBCD(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM, HEKFLAGDMLJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600023B")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void NOHIONLFOAF(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600023C")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool EBGGKBECIAA(HEKFLAGDMLJ LEMCMBEMOCB, out HEKFLAGDMLJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600023D")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void KPOCBEJCLKH(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool FOAJNNOLAGH(HEKFLAGDMLJ LEMCMBEMOCB, out float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(Slot = "12")]
	void JICAFHDOGBC(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(Slot = "13")]
	bool MKOPMMFIGLN(HEKFLAGDMLJ LEMCMBEMOCB, out float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(Slot = "14")]
	void KCIEPOKLJPH(HEKFLAGDMLJ LEMCMBEMOCB, (Quaternion rot, Vector3 moments) GHDEIKNJGJI);

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool APOEPBKOINO(HEKFLAGDMLJ LEMCMBEMOCB, out quaternion LMJFLEPCKIJ, out float3 HAIJAOPFIEB);

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(Slot = "16")]
	void HFGMNBJGNPF(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(Slot = "17")]
	void BIOMAMDGLOH(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(Slot = "18")]
	[Obsolete]
	float3 LGLAHBBDGCK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(Slot = "19")]
	float3 CAPHDHAOJLK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(Slot = "20")]
	void JJNBFKNAFII(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(Slot = "21")]
	void OPJPANPHJDP(HEKFLAGDMLJ LEMCMBEMOCB, float3 AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(Slot = "22")]
	float BBNMNDBCIBL(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(Slot = "23")]
	float MOHFNKIDGBP(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(Slot = "24")]
	void BMIKFCMBODE(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(Slot = "25")]
	void LAMPCKKILIB(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(Slot = "26")]
	CollisionDetectionMode IJPMPCMJBOP(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(Slot = "27")]
	void KGNCMCNGCOH(HEKFLAGDMLJ LEMCMBEMOCB, CollisionDetectionMode AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(Slot = "28")]
	JDKBOLPCEHA LCOILKEDMPH(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void KCNFJNJCNBH(HEKFLAGDMLJ LEMCMBEMOCB, JDKBOLPCEHA AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(Slot = "30")]
	bool JNFEKFHHMJL(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void EHOIIBCPCCF(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(Slot = "32")]
	HEKFLAGDMLJ LAAKJDOAPFC(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(Slot = "33")]
	void CKNPMPBKFGC(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(Slot = "34")]
	HEKFLAGDMLJ OPCIHBBNLKJ(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(Slot = "35")]
	void CILNNMACHKK(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000257")]
	[Cpp2IlInjected.Address(Slot = "36")]
	HIECNPEDPHM CDJDNFPECBP(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000258")]
	[Cpp2IlInjected.Address(Slot = "37")]
	void FOIEKCNPJHA(HEKFLAGDMLJ LEMCMBEMOCB, HIECNPEDPHM IAEICMCBOLA);

	[Cpp2IlInjected.Token(Token = "0x6000259")]
	[Cpp2IlInjected.Address(Slot = "38")]
	bool FDPGMNHONNB(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600025A")]
	[Cpp2IlInjected.Address(Slot = "39")]
	void NINOALKMLKM(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600025B")]
	[Cpp2IlInjected.Address(Slot = "40")]
	bool GCNEHEHJLNN(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(Slot = "41")]
	void IHLENMBMMFL(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(Slot = "42")]
	bool JOFJKDEEGHL(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(Slot = "43")]
	void HOGPJNGMLBM(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(Slot = "44")]
	RigidbodyConstraints EMIJPPKJIKL(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(Slot = "45")]
	void MHKBPNKIDJN(HEKFLAGDMLJ LEMCMBEMOCB, RigidbodyConstraints AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(Slot = "46")]
	float KPGFGLGKMBM(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000262")]
	[Cpp2IlInjected.Address(Slot = "47")]
	void MJDJBNMOHKP(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000263")]
	[Cpp2IlInjected.Address(Slot = "48")]
	float HBGOGJFCNDI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000264")]
	[Cpp2IlInjected.Address(Slot = "49")]
	void HKEDGCCBNLP(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000265")]
	[Cpp2IlInjected.Address(Slot = "50")]
	bool FMBGIDFJOLB(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000266")]
	[Cpp2IlInjected.Address(Slot = "51")]
	void DDCMFAHNJFG(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000267")]
	[Cpp2IlInjected.Address(Slot = "52")]
	bool GHGLJPCAHJB(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000268")]
	[Cpp2IlInjected.Address(Slot = "53")]
	void BHNLOMFHFNO(HEKFLAGDMLJ LEMCMBEMOCB, bool AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000269")]
	[Cpp2IlInjected.Address(Slot = "54")]
	void AAPCMIEGFJJ(HEKFLAGDMLJ LEMCMBEMOCB, int AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600026A")]
	[Cpp2IlInjected.Address(Slot = "55")]
	object EAAHBADNNND(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(Slot = "56")]
	void IGKDEJOENAK(HEKFLAGDMLJ LEMCMBEMOCB, object AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(Slot = "57")]
	object EJHGCFNPNOP(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(Slot = "58")]
	void EEONKCLCHFD(HEKFLAGDMLJ LEMCMBEMOCB, object AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(Slot = "59")]
	float EHJDBHIOPKE(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(Slot = "60")]
	void ODDDHNCAMHO(HEKFLAGDMLJ LEMCMBEMOCB, float AGLCIEKHLEE);

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(Slot = "61")]
	void HKAJABCMKOP(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(Slot = "62")]
	void KKGKDMMDENC(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000272")]
	[Cpp2IlInjected.Address(Slot = "63")]
	bool JCDHDPIFIGN(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000273")]
	[Cpp2IlInjected.Address(Slot = "64")]
	void MKAJPLONEFN(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000274")]
	[Cpp2IlInjected.Address(Slot = "65")]
	void JFPLMBLHPHO(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000275")]
	[Cpp2IlInjected.Address(Slot = "66")]
	bool CCIFHFANONG(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000276")]
	[Cpp2IlInjected.Address(Slot = "67")]
	bool KFDFPJELOPB(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(Slot = "68")]
	Rigidbody JLMFAOHPOAK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(Slot = "69")]
	void KPOMNKGLPLL(HEKFLAGDMLJ LEMCMBEMOCB, Rigidbody MOJFAKMKAFL);

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(Slot = "70")]
	void JOKNGAABFDH(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(Slot = "71")]
	void NLHAGIMAHMP(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(Slot = "72")]
	bool GPMJIKAHCBO(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(Slot = "73")]
	void EENACCBAAKO(HEKFLAGDMLJ LEMCMBEMOCB, float3 EDAEDABCFDL);

	[Cpp2IlInjected.Token(Token = "0x600027D")]
	[Cpp2IlInjected.Address(Slot = "74")]
	void GBACCJEBBAD(HEKFLAGDMLJ LEMCMBEMOCB, float3 HLKCHKIFBCP);

	[Cpp2IlInjected.Token(Token = "0x600027E")]
	[Cpp2IlInjected.Address(Slot = "75")]
	bool PMHJJBKPJPB(HEKFLAGDMLJ LEMCMBEMOCB, out float3 EDAEDABCFDL);

	[Cpp2IlInjected.Token(Token = "0x600027F")]
	[Cpp2IlInjected.Address(Slot = "76")]
	bool FJNDIDONLLC(HEKFLAGDMLJ LEMCMBEMOCB, out float3 HLKCHKIFBCP);

	[Cpp2IlInjected.Token(Token = "0x6000280")]
	[Cpp2IlInjected.Address(Slot = "77")]
	bool IOPFDHGCIEA(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000281")]
	[Cpp2IlInjected.Address(Slot = "78")]
	void ODDGBDMMCPA(HEKFLAGDMLJ LEMCMBEMOCB, object AEMEEHLIDCM, bool PILGGODJCBO);

	[Cpp2IlInjected.Token(Token = "0x6000282")]
	[Cpp2IlInjected.Address(Slot = "79")]
	void ODPIHLBPGID(HEKFLAGDMLJ LEMCMBEMOCB, bool CFIMAAICCLD);

	[Cpp2IlInjected.Token(Token = "0x6000283")]
	[Cpp2IlInjected.Address(Slot = "80")]
	void MKMKJDNOACK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000284")]
	[Cpp2IlInjected.Address(Slot = "81")]
	bool MJBBEAEKFCB(HEKFLAGDMLJ LEMCMBEMOCB);
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface BMHCJDBMOMA
{
	[Cpp2IlInjected.Token(Token = "0x6000285")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void HLOAHCBDBCB(Entity NPLCKCLGNFA);

	[Cpp2IlInjected.Token(Token = "0x6000286")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void CKBOEGKFNCF(Entity NPLCKCLGNFA);
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public readonly struct MDACGIHIOLL : IEquatable<MDACGIHIOLL>
{
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public static readonly MDACGIHIOLL BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000C0")]
	public string MODHFGFBPKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000287")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BC90", Offset = "0x5A0B090", VA = "0x185A0BC90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C1")]
	public string FFCGLOPHGAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000288")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BE80", Offset = "0x5A0B280", VA = "0x185A0BE80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C2")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600028E")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000289")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public MDACGIHIOLL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600028A")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600028B")]
	[Cpp2IlInjected.Address(RVA = "0x5A0BBF0", Offset = "0x5A0AFF0", VA = "0x185A0BBF0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028C")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(MDACGIHIOLL ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600028D")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface GOACFOHKEAA
{
	[Cpp2IlInjected.Token(Token = "0x6000290")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OIBDEICAJAM();

	[Cpp2IlInjected.Token(Token = "0x6000291")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EGECELFFKOG(bool JDKAOANGNME);

	[Cpp2IlInjected.Token(Token = "0x6000292")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CPHFNGEJCIA(GameObject NNAKJIJAOJG);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public readonly struct PAOKNCFCNMH : IEquatable<PAOKNCFCNMH>
{
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public static readonly PAOKNCFCNMH BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000C3")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000297")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000293")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000294")]
	[Cpp2IlInjected.Address(RVA = "0x5A0EBA0", Offset = "0x5A0DFA0", VA = "0x185A0EBA0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000295")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(PAOKNCFCNMH ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000296")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public readonly struct ACIBJGLLNOC : IEquatable<ACIBJGLLNOC>
{
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public static readonly ACIBJGLLNOC BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000C4")]
	private FEEKAOBEJNL IMONCPNGFGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000299")]
		[Cpp2IlInjected.Address(RVA = "0x59FEEA0", Offset = "0x59FE2A0", VA = "0x1859FEEA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C5")]
	public bool EKHOIKIJAFN
	{
		[Cpp2IlInjected.Token(Token = "0x600029D")]
		[Cpp2IlInjected.Address(RVA = "0x59FEA60", Offset = "0x59FDE60", VA = "0x1859FEA60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C6")]
	public bool PENIPKMEKHC
	{
		[Cpp2IlInjected.Token(Token = "0x600029E")]
		[Cpp2IlInjected.Address(RVA = "0x59FE400", Offset = "0x59FD800", VA = "0x1859FE400")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C7")]
	public bool ANELHPGMDHO
	{
		[Cpp2IlInjected.Token(Token = "0x600029F")]
		[Cpp2IlInjected.Address(RVA = "0x59FE600", Offset = "0x59FDA00", VA = "0x1859FE600")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C8")]
	public bool MHCIINKCAKA
	{
		[Cpp2IlInjected.Token(Token = "0x60002A0")]
		[Cpp2IlInjected.Address(RVA = "0x59FED80", Offset = "0x59FE180", VA = "0x1859FED80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000C9")]
	public bool CNIDPMDCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60002A1")]
		[Cpp2IlInjected.Address(RVA = "0x59FE1C0", Offset = "0x59FD5C0", VA = "0x1859FE1C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CA")]
	public bool MDMHCJPCGIG
	{
		[Cpp2IlInjected.Token(Token = "0x60002A2")]
		[Cpp2IlInjected.Address(RVA = "0x59FEB40", Offset = "0x59FDF40", VA = "0x1859FEB40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CB")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CC")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CD")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000CE")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0x59FE5A0", Offset = "0x59FD9A0", VA = "0x1859FE5A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600029A")]
	[Cpp2IlInjected.Address(RVA = "0x59FED30", Offset = "0x59FE130", VA = "0x1859FED30")]
	public bool LAABFFGAHJA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600029B")]
	[Cpp2IlInjected.Address(RVA = "0x59FE8D0", Offset = "0x59FDCD0", VA = "0x1859FE8D0")]
	public MDECDPGCMCD FKIHHHCGKDD(MDECDPGCMCD JNHEGOFDJBP)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x600029C")]
	[Cpp2IlInjected.Address(RVA = "0x59FE700", Offset = "0x59FDB00", VA = "0x1859FE700")]
	public HEKFLAGDMLJ FILFBJAFJGL()
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A3")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public ACIBJGLLNOC(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002A5")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(ACIBJGLLNOC AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A6")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A7")]
	[Cpp2IlInjected.Address(RVA = "0x59FE630", Offset = "0x59FDA30", VA = "0x1859FE630", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A8")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(ACIBJGLLNOC ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002A9")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005C")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface PINCEFFEDIB
{
	[Cpp2IlInjected.Token(Token = "0x60002AE")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IMPAOGMALJN IHFOPMHLFKE(GameObject OEHOBCLILGI);

	[Cpp2IlInjected.Token(Token = "0x60002AF")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void GKHGKPJPBPF(GameObject NNAKJIJAOJG, JAGLKDCKPOP OJDOCOKPJFG, BCPJINOKPFK PEPHLLLJFKE);
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public struct FDOJMOENJAL : IComparable<FDOJMOENJAL>, IEquatable<FDOJMOENJAL>
{
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public static readonly FDOJMOENJAL ENEHFIHPPLN;

	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public static readonly FDOJMOENJAL MAHAICGFPFA;

	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public static readonly FDOJMOENJAL IOPGGPHGPLC;

	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public static readonly FDOJMOENJAL JFAALACDNFF;

	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public static readonly FDOJMOENJAL GMNLIGHENPN;

	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public static readonly FDOJMOENJAL OPAHFJEPKDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int FKHPMLNOHLM;

	[Cpp2IlInjected.Token(Token = "0x170000CF")]
	public bool BCILJDPLDDH
	{
		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0x5A028C0", Offset = "0x5A01CC0", VA = "0x185A028C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D0")]
	public int NCBJMNBMILO
	{
		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0x5A029E0", Offset = "0x5A01DE0", VA = "0x185A029E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002B2")]
	[Cpp2IlInjected.Address(RVA = "0xA23350", Offset = "0xA22750", VA = "0x180A23350")]
	public FDOJMOENJAL(int BNOAGGNAMKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60002B3")]
	[Cpp2IlInjected.Address(RVA = "0x5A02970", Offset = "0x5A01D70", VA = "0x185A02970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B4")]
	[Cpp2IlInjected.Address(RVA = "0x5A028E0", Offset = "0x5A01CE0", VA = "0x185A028E0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DA53C0", Offset = "0x3DA47C0", VA = "0x183DA53C0", Slot = "5")]
	public bool Equals(FDOJMOENJAL ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B6")]
	[Cpp2IlInjected.Address(RVA = "0x5A028D0", Offset = "0x5A01CD0", VA = "0x185A028D0", Slot = "4")]
	public int CompareTo(FDOJMOENJAL ICELKIGIKKP)
	{
		return default(int);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B7")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
	public static FDOJMOENJAL LFFBPOODCDC(int BNOAGGNAMKG)
	{
		return default(FDOJMOENJAL);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002B8")]
	[Cpp2IlInjected.Address(RVA = "0x1FACE80", Offset = "0x1FAC280", VA = "0x181FACE80")]
	public static int LFFBPOODCDC(FDOJMOENJAL IOPMEPNDGKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002B9")]
	[Cpp2IlInjected.Address(RVA = "0x5A029F0", Offset = "0x5A01DF0", VA = "0x185A029F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[DefaultMember("Item")]
public interface KCPMLDAAPLA : IEnumerable<GPKGHEJLJCL>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x170000D1")]
	int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000D2")]
	GPKGHEJLJCL ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002BD")]
	[Cpp2IlInjected.Address(Slot = "2")]
	GPKGHEJLJCL DNDGKGKJHCH(LOHCJILDMLL OCFGMKDOPDP);

	[Cpp2IlInjected.Token(Token = "0x60002BE")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDOJMOENJAL LEEAMPOIODD(LOHCJILDMLL OCFGMKDOPDP);
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public static class FGFBGJGMLEK
{
	[Cpp2IlInjected.Token(Token = "0x60002BF")]
	[Cpp2IlInjected.Address(RVA = "0x17AF2B0", Offset = "0x17AE6B0", VA = "0x1817AF2B0")]
	public static FDOJMOENJAL LEEAMPOIODD<T>(this KCPMLDAAPLA OEGNIABGFIK, ENIPADEGOMD<T> GDKOBCHHFLB) where T : struct
	{
		return default(FDOJMOENJAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface LJNPGILBMKJ
{
	[Cpp2IlInjected.Token(Token = "0x60002C0")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool PIDCGHFEMCA(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60002C1")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GLEDIKEEJGK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60002C2")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool NHHLJEGKOGI(HEKFLAGDMLJ LEMCMBEMOCB, out Guid AANELEBBHAJ);

	[Cpp2IlInjected.Token(Token = "0x60002C3")]
	[Cpp2IlInjected.Address(Slot = "3")]
	Guid CNHCPHPAEPD(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60002C4")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IHKEJEODIPF(HEKFLAGDMLJ LEMCMBEMOCB, Guid AANELEBBHAJ);

	[Cpp2IlInjected.Token(Token = "0x60002C5")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool KCFEBCKBICI(HEKFLAGDMLJ LEMCMBEMOCB, out Guid MNLPDHHHFIF);

	[Cpp2IlInjected.Token(Token = "0x60002C6")]
	[Cpp2IlInjected.Address(Slot = "6")]
	Guid EGOPOHCLDNE(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60002C7")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void EEPLPMNOMOL(HEKFLAGDMLJ LEMCMBEMOCB, Guid MNLPDHHHFIF);

	[Cpp2IlInjected.Token(Token = "0x60002C8")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void LEPGKOCONPI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60002C9")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void KJHACINJHPO(HEKFLAGDMLJ KEGFIDMGBNO, HEKFLAGDMLJ OJBGDMNECON);
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface EMGCNKHPFCN
{
	[Cpp2IlInjected.Token(Token = "0x60002CA")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void KIPFBJDDMNG(HEKFLAGDMLJ JBFCCDGDFOM, bool AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public readonly struct OAGDIDHKOIF : IEquatable<OAGDIDHKOIF>
{
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public static readonly OAGDIDHKOIF BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000D3")]
	public LMAAIPGHEAK PKCKGAEHHFM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(LMAAIPGHEAK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D4")]
	private ABCNGANMAMC DPADMEHKNLA
	{
		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0x5A0DFC0", Offset = "0x5A0D3C0", VA = "0x185A0DFC0")]
		get
		{
			return default(ABCNGANMAMC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D5")]
	public DJOJBOPMMAC KMDBBLELFAM
	{
		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A0E030", Offset = "0x5A0D430", VA = "0x185A0E030")]
		get
		{
			return default(DJOJBOPMMAC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D6")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000D7")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002CE")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public OAGDIDHKOIF(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x60002D0")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(OAGDIDHKOIF AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D1")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D2")]
	[Cpp2IlInjected.Address(RVA = "0x5A0DF20", Offset = "0x5A0D320", VA = "0x185A0DF20", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D3")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(OAGDIDHKOIF ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60002D4")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface BEAMFJPLEGH
{
	[Cpp2IlInjected.Token(Token = "0x60002D7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void DOLBPNCDHMN(HEKFLAGDMLJ LEMCMBEMOCB, HCMODPLKBON ADBMAPOIAEC, bool GCLLIHABBOD, CAIENIPDHPC JGECBGFNFDI);

	[Cpp2IlInjected.Token(Token = "0x60002D8")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BFJHOIMJFCM(HEKFLAGDMLJ LEMCMBEMOCB, HCMODPLKBON ADBMAPOIAEC, bool GCLLIHABBOD, bool AHIGJLPFING, bool AMNOLEHFBOD);

	[Cpp2IlInjected.Token(Token = "0x60002D9")]
	[Cpp2IlInjected.Address(Slot = "2")]
	MKGELIIKCMD AEHJJMLJJAA(HEKFLAGDMLJ AOCBEEBNJPK, List<HEKFLAGDMLJ> HDPCJHHGDKF);

	[Cpp2IlInjected.Token(Token = "0x60002DA")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void GEPOFDCBPKN(GameObject CCFOBKBNDBF, GameObject FLHOBGILMEI);

	[Cpp2IlInjected.Token(Token = "0x60002DB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DPFAJDMPAOL(GameObject FLHOBGILMEI);

	[Cpp2IlInjected.Token(Token = "0x60002DC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	T EOKACEMHNHK<T>(GameObject MFGCADNGCJE) where T : Collider;

	[Cpp2IlInjected.Token(Token = "0x60002DD")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void CJPCMLGELKH(Collider MPDBOOOIMLM);

	[Cpp2IlInjected.Token(Token = "0x60002DE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	GameObject CLJMEOMOPKP<T>(string GDKOBCHHFLB) where T : Collider;
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface DOKFAOCNIFN
{
	[Cpp2IlInjected.Token(Token = "0x170000D8")]
	IReadOnlyCollection<CMCADLOKOGK> AELEPOEPMJP
	{
		[Cpp2IlInjected.Token(Token = "0x60002DF")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E0")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKODLFANPKN(int DCJNJIADGPK, out CMCADLOKOGK BIMCFGLAOAL);

	[Cpp2IlInjected.Token(Token = "0x60002E1")]
	[Cpp2IlInjected.Address(Slot = "2")]
	CMCADLOKOGK KEHPFDBPLPI(Type GANFKPHKNKH);
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public static class DKOEMDDFGEB
{
	[Cpp2IlInjected.Token(Token = "0x60002E2")]
	[Cpp2IlInjected.Address(RVA = "0x2C80A90", Offset = "0x2C7FE90", VA = "0x182C80A90")]
	public static T MDMDMEMIHOB<T>(this DOKFAOCNIFN POHDPKBODCF, Entity GKMECPLEALF) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60002E3")]
	[Cpp2IlInjected.Address(RVA = "0x2C7FEB0", Offset = "0x2C7F2B0", VA = "0x182C7FEB0")]
	public static CMCADLOKOGK KEHPFDBPLPI<T>(this DOKFAOCNIFN POHDPKBODCF) where T : struct, IComponent
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface FHJJAMLGNLD
{
	[Cpp2IlInjected.Token(Token = "0x60002E4")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EMBCAAOOGPO(bool OMIGIJBCKAP);
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public interface GLHHELGFOCN
{
	[Cpp2IlInjected.Token(Token = "0x170000D9")]
	bool HPOMJOMGINK
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DA")]
	HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface HMHHFNDBEKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DB")]
	bool IBNACHJKIBL
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DC")]
	bool IIDCPPLGBMF
	{
		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DD")]
	MPCJLDHBHBF JEGJLHEAILC
	{
		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002EB")]
	[Cpp2IlInjected.Address(Slot = "4")]
	CEGKNKGECDI DCPFAFGEGGG();

	[Cpp2IlInjected.Token(Token = "0x60002EC")]
	[Cpp2IlInjected.Address(Slot = "5")]
	CEGKNKGECDI GMCGBJGGAOO(IEnumerable<HEKFLAGDMLJ> GAOJFDPACED, in IJEMHFEELIK LALJEPDPLMD);

	[Cpp2IlInjected.Token(Token = "0x60002ED")]
	[Cpp2IlInjected.Address(Slot = "6")]
	MHBNDALDLMC CFMILAHIEDD(ByteString HFALKIEIPAA);

	[Cpp2IlInjected.Token(Token = "0x60002EE")]
	[Cpp2IlInjected.Address(Slot = "7")]
	NDHMEAKEDNA OINMJBEDGCK(ByteString DCBJJADOEJL, HEKFLAGDMLJ OJBGDMNECON, in IJEMHFEELIK CEBAGGBJPNN, MFMOHGACDCK COFIPIBFCKH, bool EDLLHCLBOMD = true);

	[Cpp2IlInjected.Token(Token = "0x60002EF")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void KPCDGHPLLFO();

	[Cpp2IlInjected.Token(Token = "0x60002F0")]
	[Cpp2IlInjected.Address(Slot = "9")]
	ALNGHMJNFBH MDJOMPBEPAG(IEnumerable<GGLLEGPCFPG> COINOLJIGKE);
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public static class JBGBGGANAIH
{
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface FEGFINCBOCB : FFLHMNCCPBG, OEGCJPFACKE, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x170000DE")]
	bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000DF")]
	DOFBPGFFJDE DANEBHHOICE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E0")]
	EEKNAEJEFGF GHGAMEAKNOD
	{
		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E1")]
	FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E2")]
	POKOBOIBHEN CKBGDPGPGCO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface OEGCJPFACKE
{
	[Cpp2IlInjected.Token(Token = "0x170000E3")]
	bool GKODBKCLOCN
	{
		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface JNOKJGPGAHI
{
	[Cpp2IlInjected.Token(Token = "0x60002F7")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void PKHBEMIICDL(bool AGLCIEKHLEE);
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface BEJBBGIEBIB
{
	[Cpp2IlInjected.Token(Token = "0x170000E4")]
	bool BCGCPDAKGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000E5")]
	bool BCIALNCGJFO
	{
		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface MAIOFFPLJPO
{
	[Cpp2IlInjected.Token(Token = "0x170000E6")]
	Guid OIEDMOIMACL
	{
		[Cpp2IlInjected.Token(Token = "0x60002FA")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60002FB")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MIHNLMHCPBJ(Guid AANELEBBHAJ, Guid MNLPDHHHFIF, string GDKOBCHHFLB);
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public struct CJPDAFFDJMC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	internal int AEHKIMOEIJL;

	[Cpp2IlInjected.Token(Token = "0x60002FC")]
	[Cpp2IlInjected.Address(RVA = "0x5A00950", Offset = "0x59FFD50", VA = "0x185A00950", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public static class NHMAKIGBOPC
{
	[StructLayout((LayoutKind)2)]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct FJHBEDCFFBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Guid DDJMKPCJBFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public BFNHHHDKGIN HGJGMFLGDEM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000072")]
	private struct BFNHHHDKGIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public int AGLCIEKHLEE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public int KLGPLJENHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public int BNGDNIPCFJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public int LJNMLABFGBH;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x5A00800", Offset = "0x59FFC00", VA = "0x185A00800")]
		public bool NGKCHDEKEDE(out JDPNCHCMAIA DDCHJBPICDC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0x5A008A0", Offset = "0x59FFCA0", VA = "0x185A008A0")]
		public BFNHHHDKGIN(JDPNCHCMAIA DDCHJBPICDC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60002FD")]
	[Cpp2IlInjected.Address(RVA = "0x5A0DE80", Offset = "0x5A0D280", VA = "0x185A0DE80")]
	public static Guid KIPCNMELOPF(this JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(Guid);
	}

	[Cpp2IlInjected.Token(Token = "0x60002FE")]
	[Cpp2IlInjected.Address(RVA = "0x5A0DE60", Offset = "0x5A0D260", VA = "0x185A0DE60")]
	public static bool DCIPCNFIHAP(this Guid DDJMKPCJBFO, out JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000073")]
[DebuggerDisplay("{ObjectLocalIdDebugView.GetDebugName(Objects, LocalId)}")]
[DebuggerTypeProxy(typeof(FEEGJHOIIIG))]
public readonly struct HEKFLAGDMLJ : IComparable<HEKFLAGDMLJ>, IEquatable<HEKFLAGDMLJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public static readonly HEKFLAGDMLJ ENEHFIHPPLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private readonly OMJPGCFKPLM PAHMPOAEKCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly LocalId LEMCMBEMOCB;

	[Cpp2IlInjected.Token(Token = "0x170000E7")]
	public IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E8")]
	public LocalId PAHAMFDGKHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x176BB10", Offset = "0x176AF10", VA = "0x18176BB10")]
		get
		{
			return default(LocalId);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000E9")]
	public bool HFDNCCJGOAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000303")]
		[Cpp2IlInjected.Address(RVA = "0x5A068F0", Offset = "0x5A05CF0", VA = "0x185A068F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EA")]
	public bool HKCJMGFCIAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000304")]
		[Cpp2IlInjected.Address(RVA = "0x5A06BE0", Offset = "0x5A05FE0", VA = "0x185A06BE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EB")]
	public bool BEGBCLDNFDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000305")]
		[Cpp2IlInjected.Address(RVA = "0x5A06C00", Offset = "0x5A06000", VA = "0x185A06C00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000306")]
	[Cpp2IlInjected.Address(RVA = "0x5A06D90", Offset = "0x5A06190", VA = "0x185A06D90")]
	public HEKFLAGDMLJ(IMBCAHJKJCI DCAFKACGPOO, LocalId LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000307")]
	[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
	public MDECDPGCMCD ABHNIKOKGEF()
	{
		return default(MDECDPGCMCD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000308")]
	[Cpp2IlInjected.Address(RVA = "0x176BB10", Offset = "0x176AF10", VA = "0x18176BB10")]
	public static LocalId LFFBPOODCDC(HEKFLAGDMLJ GNGAANOFOFJ)
	{
		return default(LocalId);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000309")]
	[Cpp2IlInjected.Address(RVA = "0x5A06C20", Offset = "0x5A06020", VA = "0x185A06C20")]
	public static Entity LFFBPOODCDC(HEKFLAGDMLJ GNGAANOFOFJ)
	{
		return default(Entity);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030A")]
	[Cpp2IlInjected.Address(RVA = "0x5A06C30", Offset = "0x5A06030", VA = "0x185A06C30")]
	public static bool PHJEMBLBEDF(HEKFLAGDMLJ NPBBJPKPNCJ, HEKFLAGDMLJ KBAEKPMBMFG)
	{
		return default(bool);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600030B")]
	[Cpp2IlInjected.Address(RVA = "0x5A06830", Offset = "0x5A05C30", VA = "0x185A06830")]
	public static bool AHGPMPLECPJ(HEKFLAGDMLJ NPBBJPKPNCJ, HEKFLAGDMLJ KBAEKPMBMFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030C")]
	[Cpp2IlInjected.Address(RVA = "0x5A06C90", Offset = "0x5A06090", VA = "0x185A06C90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600030D")]
	[Cpp2IlInjected.Address(RVA = "0x5A06B10", Offset = "0x5A05F10", VA = "0x185A06B10", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600030E")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600030F")]
	[Cpp2IlInjected.Address(RVA = "0x5A069D0", Offset = "0x5A05DD0", VA = "0x185A069D0", Slot = "4")]
	public int CompareTo(HEKFLAGDMLJ ICELKIGIKKP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000310")]
	[Cpp2IlInjected.Address(RVA = "0x5A06A30", Offset = "0x5A05E30", VA = "0x185A06A30", Slot = "5")]
	public bool Equals(HEKFLAGDMLJ ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000074")]
public static class GIEPKOBDCON
{
	[Cpp2IlInjected.Token(Token = "0x6000312")]
	[Cpp2IlInjected.Address(RVA = "0x5A03BD0", Offset = "0x5A02FD0", VA = "0x185A03BD0")]
	public static JDPNCHCMAIA NLIKCLIKHPF(this HEKFLAGDMLJ HFAGBIOODHL)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000313")]
	[Cpp2IlInjected.Address(RVA = "0x16DBE90", Offset = "0x16DB290", VA = "0x1816DBE90")]
	public static T IJPAGMLGBCG<T>(this HEKFLAGDMLJ HFAGBIOODHL) where T : struct, IComponent
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000075")]
internal sealed class FEEGJHOIIIG
{
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface JJLJCDMIEAB
{
	[Cpp2IlInjected.Token(Token = "0x170000EC")]
	bool JJHNMLEHLGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000314")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000315")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void MABINJOIHNC(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000316")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void FOHJFGDONLI(HEKFLAGDMLJ LEMCMBEMOCB, bool GCLLIHABBOD, bool AHIGJLPFING, bool KPKEDBFMAEL);
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public readonly struct CNKGMANFGNC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private readonly FDJPAKEFOJE JCKPFMCHBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly NativeArray<byte> CBNEMGEKLOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly NativeArray<byte> BGDHKJDGOAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly FDOJMOENJAL IOPMEPNDGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly int MEOMIGAHALN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly Type JPLIPFGICKD;

	[Cpp2IlInjected.Token(Token = "0x170000ED")]
	public FDJPAKEFOJE OPJBEJIEKPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000318")]
		[Cpp2IlInjected.Address(RVA = "0x176B800", Offset = "0x176AC00", VA = "0x18176B800")]
		get
		{
			return default(FDJPAKEFOJE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000317")]
	[Cpp2IlInjected.Address(RVA = "0x5A00A50", Offset = "0x59FFE50", VA = "0x185A00A50")]
	public CNKGMANFGNC(FDJPAKEFOJE JCKPFMCHBED, NativeArray<byte> CBNEMGEKLOD, NativeArray<byte> BGDHKJDGOAL, FDOJMOENJAL IOPMEPNDGKE, int MEOMIGAHALN, Type JPLIPFGICKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000319")]
	[Cpp2IlInjected.Address(RVA = "0x21875C0", Offset = "0x21869C0", VA = "0x1821875C0")]
	public NativeArray<T> DHKAEJJGOKM<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031A")]
	[Cpp2IlInjected.Address(RVA = "0x2187600", Offset = "0x2186A00", VA = "0x182187600")]
	public NativeArray<T> INEIGIHCJAA<T>() where T : struct
	{
		return default(NativeArray<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600031B")]
	[Cpp2IlInjected.Address(RVA = "0x2187640", Offset = "0x2186A40", VA = "0x182187640")]
	public (FDJPAKEFOJE, NativeArray<T>, NativeArray<T>) PHGLOPEHIMO<T>() where T : struct
	{
		return default((FDJPAKEFOJE, NativeArray<T>, NativeArray<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600031C")]
	[Cpp2IlInjected.Address(RVA = "0x5A009B0", Offset = "0x59FFDB0", VA = "0x185A009B0")]
	public JPKFBBKCAIK CLODELAKOCK()
	{
		return default(JPKFBBKCAIK);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000078")]
public readonly struct DNDKNBNCPPL : IEquatable<DNDKNBNCPPL>
{
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public static readonly DNDKNBNCPPL BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000EE")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000321")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000EF")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000326")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F0")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000327")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000F1")]
	private FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000328")]
		[Cpp2IlInjected.Address(RVA = "0x5A01230", Offset = "0x5A00630", VA = "0x185A01230")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600031D")]
	[Cpp2IlInjected.Address(RVA = "0x5A010E0", Offset = "0x5A004E0", VA = "0x185A010E0")]
	public void ADJPGHMCOKF(bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031E")]
	[Cpp2IlInjected.Address(RVA = "0x5A01330", Offset = "0x5A00730", VA = "0x185A01330")]
	public void GEKPKMIHAHB(bool AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600031F")]
	[Cpp2IlInjected.Address(RVA = "0x2C84400", Offset = "0x2C83800", VA = "0x182C84400")]
	public T ENECJPJABPF<T>() where T : struct
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000320")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public DNDKNBNCPPL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000322")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000323")]
	[Cpp2IlInjected.Address(RVA = "0x5A01290", Offset = "0x5A00690", VA = "0x185A01290", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000324")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(DNDKNBNCPPL ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000325")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000079")]
public readonly struct EJJLJNBOKAO : IEquatable<EJJLJNBOKAO>
{
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public static readonly EJJLJNBOKAO BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000F2")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600032E")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600032A")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600032B")]
	[Cpp2IlInjected.Address(RVA = "0x5A02150", Offset = "0x5A01550", VA = "0x185A02150", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032C")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(EJJLJNBOKAO ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600032D")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface MAFOFLPIDLK
{
	[Cpp2IlInjected.Token(Token = "0x170000F3")]
	KPBHHFJCLAD KCCKMALAJIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000330")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F4")]
	KPBHHFJCLAD IKJHLMNHPPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000331")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F5")]
	KPBHHFJCLAD EENMJALKMEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000332")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F6")]
	KPBHHFJCLAD EMCLIHJFPMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000333")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F7")]
	KPBHHFJCLAD CJPAEEBHBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000334")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F8")]
	KPBHHFJCLAD IEPBIKJEDAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000335")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000F9")]
	KPBHHFJCLAD IKOFANNLAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000336")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FA")]
	KPBHHFJCLAD JALHPAIJBDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000337")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x170000FB")]
	KPBHHFJCLAD BACCOFFHAFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000338")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public struct EIPPCECOLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float OHGLDDGFBJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float3 PKGGKJEKINO;
}
[Cpp2IlInjected.Token(Token = "0x200007C")]
public readonly struct LMAAIPGHEAK : IEquatable<LMAAIPGHEAK>
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly LMAAIPGHEAK BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x170000FC")]
	private JNCCAJLCOCK HENNIIOFFLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000339")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BB40", Offset = "0x5A0AF40", VA = "0x185A0BB40")]
		get
		{
			return default(JNCCAJLCOCK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FD")]
	public IHHNBILPKLB NOPPMCJJDCI
	{
		[Cpp2IlInjected.Token(Token = "0x600033A")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B770", Offset = "0x5A0AB70", VA = "0x185A0B770")]
		get
		{
			return default(IHHNBILPKLB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FE")]
	public BGPNGCIJHLL BPFNIJPHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600033B")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B5E0", Offset = "0x5A0A9E0", VA = "0x185A0B5E0")]
		get
		{
			return default(BGPNGCIJHLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x170000FF")]
	public OHECJJDOPHB HLEIGDHNGDN
	{
		[Cpp2IlInjected.Token(Token = "0x600033C")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B8F0", Offset = "0x5A0ACF0", VA = "0x185A0B8F0")]
		get
		{
			return default(OHECJJDOPHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000100")]
	public MEFJBIKHGAA JNCNLMNJMBG
	{
		[Cpp2IlInjected.Token(Token = "0x600033F")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B3F0", Offset = "0x5A0A7F0", VA = "0x185A0B3F0")]
		get
		{
			return default(MEFJBIKHGAA);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000101")]
	public CDPEKNFNMNM ELOLHJCDFKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000340")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B310", Offset = "0x5A0A710", VA = "0x185A0B310")]
		get
		{
			return default(CDPEKNFNMNM);
		}
		[Cpp2IlInjected.Token(Token = "0x6000341")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BA50", Offset = "0x5A0AE50", VA = "0x185A0BA50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000102")]
	public NLEMDAHFKEP OIOBCPEPEAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000342")]
		[Cpp2IlInjected.Address(RVA = "0x5A0BAD0", Offset = "0x5A0AED0", VA = "0x185A0BAD0")]
		get
		{
			return default(NLEMDAHFKEP);
		}
		[Cpp2IlInjected.Token(Token = "0x6000343")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B7E0", Offset = "0x5A0ABE0", VA = "0x185A0B7E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000103")]
	public float BOJCCGIAFGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000344")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B4F0", Offset = "0x5A0A8F0", VA = "0x185A0B4F0")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000345")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B470", Offset = "0x5A0A870", VA = "0x185A0B470")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000104")]
	public Vector3 OJJMAOAJAKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000346")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B860", Offset = "0x5A0AC60", VA = "0x185A0B860")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000347")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B960", Offset = "0x5A0AD60", VA = "0x185A0B960")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000105")]
	public float BMHHINCJJKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000348")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B650", Offset = "0x5A0AA50", VA = "0x185A0B650")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000106")]
	public DECAIEJILIK.ECDHKGGDKCM HIAPJBLPDNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000349")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B380", Offset = "0x5A0A780", VA = "0x185A0B380")]
		get
		{
			return default(DECAIEJILIK.ECDHKGGDKCM);
		}
		[Cpp2IlInjected.Token(Token = "0x600034A")]
		[Cpp2IlInjected.Address(RVA = "0x5A0B560", Offset = "0x5A0A960", VA = "0x185A0B560")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000107")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x600034C")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000108")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000352")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000109")]
	public GNBHPPAICCJ BHDFDFBFOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000353")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(GNBHPPAICCJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600033D")]
	[Cpp2IlInjected.Address(RVA = "0x5A0B9F0", Offset = "0x5A0ADF0", VA = "0x185A0B9F0")]
	public OAGDIDHKOIF MAPLOOHJEDH()
	{
		return default(OAGDIDHKOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600033E")]
	[Cpp2IlInjected.Address(RVA = "0x5A0B2B0", Offset = "0x5A0A6B0", VA = "0x185A0B2B0")]
	public MKIIJMKIKEO AJOMMGBJLHJ()
	{
		return default(MKIIJMKIKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600034B")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public LMAAIPGHEAK(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600034D")]
	[Cpp2IlInjected.Address(RVA = "0x59FED70", Offset = "0x59FE170", VA = "0x1859FED70")]
	public static bool LFFBPOODCDC(LMAAIPGHEAK AGLCIEKHLEE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600034E")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600034F")]
	[Cpp2IlInjected.Address(RVA = "0x5A0B6D0", Offset = "0x5A0AAD0", VA = "0x185A0B6D0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000350")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(LMAAIPGHEAK ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000351")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007D")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface FFCBJDNAPKG
{
	[Cpp2IlInjected.Token(Token = "0x1700010A")]
	IABLIMOJJBC DANEBHHOICE
	{
		[Cpp2IlInjected.Token(Token = "0x6000355")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010B")]
	EEKNAEJEFGF GHGAMEAKNOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000356")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010C")]
	ICCLAPFHPJL GMBOJNPAEGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000357")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010D")]
	IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000358")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010E")]
	OHAMPNBKDLP LJHMBDPCDOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000359")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700010F")]
	GGNFHIGGHPN PLNCJGGLGBA
	{
		[Cpp2IlInjected.Token(Token = "0x600035A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000110")]
	HMHHFNDBEKM HNPEOGNDDDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600035B")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000111")]
	HPKBHAJJNGO NKFNOHKFIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600035C")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000112")]
	EPICOOKCMFM CNENFCIOLAM
	{
		[Cpp2IlInjected.Token(Token = "0x600035D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000113")]
	EKDKPLKGAMN GCNBKHCAMFG
	{
		[Cpp2IlInjected.Token(Token = "0x600035E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000114")]
	FEEKAOBEJNL JIOBCDMNGIC
	{
		[Cpp2IlInjected.Token(Token = "0x600035F")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000115")]
	ONIGLBMFNHJ IKOFANNLAHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000360")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000116")]
	EMGCNKHPFCN HDMPHJDALFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000361")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000117")]
	EHDBBIHDADI KNGCKNHANNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000362")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000118")]
	LJNPGILBMKJ AOJKPFHOGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000363")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000119")]
	HKJFJAJNFAP IHIAGHCJPDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000364")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011A")]
	FIOENEMHNNB MEJOIGEJGMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000365")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011B")]
	MAFOFLPIDLK OLAINEOHBGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000366")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011C")]
	DOKFAOCNIFN OJLAHIBKJDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000367")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface CKMPIFKEGBJ
{
	[Cpp2IlInjected.Token(Token = "0x1700011D")]
	object OKFKIGKIHHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000368")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000369")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BDPOEBCAPPO(FDJPAKEFOJE GAOJFDPACED);
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface OHAMPNBKDLP
{
	[Cpp2IlInjected.Token(Token = "0x1400000A")]
	event Action<JPKFBBKCAIK> PMHLBEAPEMG;

	[Cpp2IlInjected.Token(Token = "0x600036C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	HEKFLAGDMLJ LAAKJDOAPFC(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600036D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void IJBFDPMGIJM(ref List<HEKFLAGDMLJ> LEIIMBCJOOL);

	[Cpp2IlInjected.Token(Token = "0x600036E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	HEKFLAGDMLJ OPCIHBBNLKJ(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600036F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool CILNNMACHKK(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ OJBGDMNECON, bool KJNJDCMKFAL);

	[Cpp2IlInjected.Token(Token = "0x6000370")]
	[Cpp2IlInjected.Address(Slot = "6")]
	bool IHIEJEAIEMM(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ OJBGDMNECON);

	[Cpp2IlInjected.Token(Token = "0x6000371")]
	[Cpp2IlInjected.Address(Slot = "7")]
	int ONPGMOCNIHI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000372")]
	[Cpp2IlInjected.Address(Slot = "8")]
	FDJPAKEFOJE AMLMJHKBLMG(HEKFLAGDMLJ JBFCCDGDFOM);

	[Cpp2IlInjected.Token(Token = "0x6000373")]
	[Cpp2IlInjected.Address(Slot = "9")]
	bool GNBOGMACBNL(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ BPLKOFNPIGA);

	[Cpp2IlInjected.Token(Token = "0x6000374")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool LOJMEIIDDGG(HEKFLAGDMLJ LEMCMBEMOCB, HEKFLAGDMLJ BGACBDKLDPA);

	[Cpp2IlInjected.Token(Token = "0x6000375")]
	[Cpp2IlInjected.Address(Slot = "11")]
	HEKFLAGDMLJ OKDEEBIDGEN(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME);

	[Cpp2IlInjected.Token(Token = "0x6000376")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool MPHFLBOJAHA(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME, out HEKFLAGDMLJ MCDGHNFJPKK);
}
[Cpp2IlInjected.Token(Token = "0x2000080")]
public static class DBBGLGBJFEC
{
	[Cpp2IlInjected.Token(Token = "0x6000377")]
	[Cpp2IlInjected.Address(RVA = "0x5A00E20", Offset = "0x5A00220", VA = "0x185A00E20")]
	public static List<HEKFLAGDMLJ> IJBFDPMGIJM(this OHAMPNBKDLP LJNICDIKKOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000378")]
	[Cpp2IlInjected.Address(RVA = "0x5A00D30", Offset = "0x5A00130", VA = "0x185A00D30")]
	public static bool AADCIPIJFEF(this OHAMPNBKDLP LJNICDIKKOK, HEKFLAGDMLJ LEMCMBEMOCB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000081")]
public enum DBDEKGOAMDF
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
[Cpp2IlInjected.Token(Token = "0x2000082")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface EPICOOKCMFM
{
	[Cpp2IlInjected.Token(Token = "0x6000379")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<HEKFLAGDMLJ> NFAKONJLIID(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600037A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	HEKFLAGDMLJ BPOEDPNLICI(HEKFLAGDMLJ LEMCMBEMOCB, int BNOAGGNAMKG);

	[Cpp2IlInjected.Token(Token = "0x600037B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	int FIBJAKKEOHC(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600037C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MGFBLKCEIKC PPDECOCGBPD(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x600037D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DJFCEKBBKAL(HEKFLAGDMLJ LEMCMBEMOCB, MGFBLKCEIKC NPOLKGPPPJC);

	[Cpp2IlInjected.Token(Token = "0x600037E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	HEKFLAGDMLJ LBCACPHOJKL(HEKFLAGDMLJ LEMCMBEMOCB, [Optional] float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] float3? ECOCGLBAPIP);

	[Cpp2IlInjected.Token(Token = "0x600037F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	HEKFLAGDMLJ CNLNBFIICKK(HEKFLAGDMLJ LEMCMBEMOCB, int BNOAGGNAMKG, [Optional] float3? FGLOAKJBDBO, [Optional] quaternion? OCEJJKMFIJB, [Optional] float3? ECOCGLBAPIP);

	[Cpp2IlInjected.Token(Token = "0x6000380")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void IFHJGGIJKAH(HEKFLAGDMLJ LEMCMBEMOCB, int BNOAGGNAMKG);

	[Cpp2IlInjected.Token(Token = "0x6000381")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void OCJFGDHJIOC(HEKFLAGDMLJ LEMCMBEMOCB);
}
[Cpp2IlInjected.Token(Token = "0x2000083")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface OAAFNCLLJOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000382")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void FPFNENGHAPJ(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000383")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FKDEAJCIHBO(HEKFLAGDMLJ LEMCMBEMOCB, Transform DKKDEHMFAEC);
}
[Cpp2IlInjected.Token(Token = "0x2000084")]
public interface MPFACGKGBND : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700011E")]
	LocalId MOAENFMFIHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000384")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1700011F")]
	LocalId LHDLIINOKBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000385")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000386")]
		[Cpp2IlInjected.Address(Slot = "2")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x6000387")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void KKJIODNCNFN(float3 PMKGPHOGHCN);

	[Cpp2IlInjected.Token(Token = "0x6000388")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GNDDCKJDBJH(float3 PMKGPHOGHCN);

	[Cpp2IlInjected.Token(Token = "0x6000389")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void FELNFOAPHIA(out float3 OANIJIEMEHN, out float3 ELBJBJNOEIJ);

	[Cpp2IlInjected.Token(Token = "0x600038A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void KIAOHIEPKBA(float3 OANIJIEMEHN, float3 ELBJBJNOEIJ);

	[Cpp2IlInjected.Token(Token = "0x600038B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	void OMKHOEMJFKC(Color OANIJIEMEHN, Color ELBJBJNOEIJ);

	[Cpp2IlInjected.Token(Token = "0x600038C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	MPFACGKGBND Instantiate(Transform DKKDEHMFAEC);
}
[Cpp2IlInjected.Token(Token = "0x2000085")]
public interface MJODJCBLLBG
{
	[Cpp2IlInjected.Token(Token = "0x600038D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MHIDNOPDKCM(Transform DKKDEHMFAEC, MPFACGKGBND POJLBDBDEDN);

	[Cpp2IlInjected.Token(Token = "0x600038E")]
	[Cpp2IlInjected.Address(Slot = "1")]
	MPFACGKGBND IHMIAOAOIBG();
}
[Cpp2IlInjected.Token(Token = "0x2000086")]
public readonly struct CPKDMKEIOOA : IEquatable<CPKDMKEIOOA>
{
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public static readonly CPKDMKEIOOA BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000120")]
	private CGIILOGBKDF DNJPDCDBKNL
	{
		[Cpp2IlInjected.Token(Token = "0x600038F")]
		[Cpp2IlInjected.Address(RVA = "0x5A00C10", Offset = "0x5A00010", VA = "0x185A00C10")]
		get
		{
			return default(CGIILOGBKDF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000121")]
	public BAINPBEIELK KNNHKIKPEKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000390")]
		[Cpp2IlInjected.Address(RVA = "0x5A00C80", Offset = "0x5A00080", VA = "0x185A00C80")]
		get
		{
			return default(BAINPBEIELK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000122")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000397")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000391")]
	[Cpp2IlInjected.Address(RVA = "0x5A00AC0", Offset = "0x59FFEC0", VA = "0x185A00AC0")]
	public DCMGEEAECJC CCJEOHICMCE()
	{
		return default(DCMGEEAECJC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000392")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public CPKDMKEIOOA(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000393")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000394")]
	[Cpp2IlInjected.Address(RVA = "0x5A00B70", Offset = "0x59FFF70", VA = "0x185A00B70", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000395")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(CPKDMKEIOOA ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000396")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000087")]
public readonly struct FFINEIFOCPA : IEquatable<FFINEIFOCPA>
{
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public static readonly FFINEIFOCPA BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000123")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600039D")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000399")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600039A")]
	[Cpp2IlInjected.Address(RVA = "0x5A02B70", Offset = "0x5A01F70", VA = "0x185A02B70", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039B")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(FFINEIFOCPA ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600039C")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000088")]
public readonly struct GIFCCIBMBHL : IEquatable<GIFCCIBMBHL>
{
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public static readonly GIFCCIBMBHL BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000124")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003A4")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600039F")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public GIFCCIBMBHL(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A0")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A1")]
	[Cpp2IlInjected.Address(RVA = "0x5A03CD0", Offset = "0x5A030D0", VA = "0x185A03CD0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A2")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(GIFCCIBMBHL ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003A3")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003A5")]
	[Cpp2IlInjected.Address(RVA = "0x5A03D70", Offset = "0x5A03170", VA = "0x185A03D70")]
	public bool FKPBMCAJPFF(out Collider MPDBOOOIMLM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000089")]
public readonly struct JNJDEHCDHNA : IEquatable<JNJDEHCDHNA>
{
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public static readonly JNJDEHCDHNA BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000125")]
	public HEKFLAGDMLJ MIHFCEGNEMF
	{
		[Cpp2IlInjected.Token(Token = "0x60003A8")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(HEKFLAGDMLJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000126")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003AD")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000127")]
	public MKIIJMKIKEO DLDIADEHBNH
	{
		[Cpp2IlInjected.Token(Token = "0x60003AE")]
		[Cpp2IlInjected.Address(RVA = "0x5A08C50", Offset = "0x5A08050", VA = "0x185A08C50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000128")]
	public float3 NEGNDNNABPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003AF")]
		[Cpp2IlInjected.Address(RVA = "0x5A08B50", Offset = "0x5A07F50", VA = "0x185A08B50")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B0")]
		[Cpp2IlInjected.Address(RVA = "0x5A087C0", Offset = "0x5A07BC0", VA = "0x185A087C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000129")]
	public quaternion DOIAKOGFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003B1")]
		[Cpp2IlInjected.Address(RVA = "0x5A08E40", Offset = "0x5A08240", VA = "0x185A08E40")]
		get
		{
			return default(quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B2")]
		[Cpp2IlInjected.Address(RVA = "0x5A08D20", Offset = "0x5A08120", VA = "0x185A08D20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012A")]
	public float3 HLDBDAEHOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B3")]
		[Cpp2IlInjected.Address(RVA = "0x5A08A20", Offset = "0x5A07E20", VA = "0x185A08A20")]
		get
		{
			return default(float3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003B4")]
		[Cpp2IlInjected.Address(RVA = "0x5A08DB0", Offset = "0x5A081B0", VA = "0x185A08DB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012B")]
	public EEICHPGJODP GOOGKJOALFC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B5")]
		[Cpp2IlInjected.Address(RVA = "0x5A08930", Offset = "0x5A07D30", VA = "0x185A08930")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012C")]
	private LPPGNAMJLHH DPEAPCJACNL
	{
		[Cpp2IlInjected.Token(Token = "0x60003B7")]
		[Cpp2IlInjected.Address(RVA = "0x5A08BE0", Offset = "0x5A07FE0", VA = "0x185A08BE0")]
		get
		{
			return default(LPPGNAMJLHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012D")]
	private GBIFAKMIBHB DCGCPJMJABF
	{
		[Cpp2IlInjected.Token(Token = "0x60003B8")]
		[Cpp2IlInjected.Address(RVA = "0x5A08FA0", Offset = "0x5A083A0", VA = "0x185A08FA0")]
		get
		{
			return default(GBIFAKMIBHB);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012E")]
	private KINPEKKAGMO BGHFEINEFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003B9")]
		[Cpp2IlInjected.Address(RVA = "0x5A088C0", Offset = "0x5A07CC0", VA = "0x185A088C0")]
		get
		{
			return default(KINPEKKAGMO);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700012F")]
	private HCALDHAPBAE HDGHEOPFKPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003BA")]
		[Cpp2IlInjected.Address(RVA = "0x5A08850", Offset = "0x5A07C50", VA = "0x185A08850")]
		get
		{
			return default(HCALDHAPBAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000130")]
	private JOAOHAGLCAE FPKPLJBHNBF
	{
		[Cpp2IlInjected.Token(Token = "0x60003BB")]
		[Cpp2IlInjected.Address(RVA = "0x5A089B0", Offset = "0x5A07DB0", VA = "0x185A089B0")]
		get
		{
			return default(JOAOHAGLCAE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003A7")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public JNJDEHCDHNA(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003A9")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AA")]
	[Cpp2IlInjected.Address(RVA = "0x5A08AB0", Offset = "0x5A07EB0", VA = "0x185A08AB0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AB")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(JNJDEHCDHNA ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003AC")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003B6")]
	[Cpp2IlInjected.Address(RVA = "0x5A08ED0", Offset = "0x5A082D0", VA = "0x185A08ED0")]
	public void ONMDEKNDDEE(MKIIJMKIKEO AGLCIEKHLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008A")]
public readonly struct GNBHPPAICCJ : IEquatable<GNBHPPAICCJ>
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public static readonly GNBHPPAICCJ BIKIIJCJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private readonly HEKFLAGDMLJ JBFCCDGDFOM;

	[Cpp2IlInjected.Token(Token = "0x17000131")]
	public MDECDPGCMCD ICGJOIEICNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60003C2")]
		[Cpp2IlInjected.Address(RVA = "0x176B850", Offset = "0x176AC50", VA = "0x18176B850")]
		get
		{
			return default(MDECDPGCMCD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000132")]
	private IMBCAHJKJCI CLDDIHPGFHC
	{
		[Cpp2IlInjected.Token(Token = "0x60003C3")]
		[Cpp2IlInjected.Address(RVA = "0x59FEF30", Offset = "0x59FE330", VA = "0x1859FEF30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000133")]
	private GGNFHIGGHPN EEGDJDIJBOP
	{
		[Cpp2IlInjected.Token(Token = "0x60003C4")]
		[Cpp2IlInjected.Address(RVA = "0x5A05FE0", Offset = "0x5A053E0", VA = "0x185A05FE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000134")]
	public bool NEJJKPBGMGE
	{
		[Cpp2IlInjected.Token(Token = "0x60003C6")]
		[Cpp2IlInjected.Address(RVA = "0x5A03EF0", Offset = "0x5A032F0", VA = "0x185A03EF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000135")]
	public Vector3 NEGNDNNABPB
	{
		[Cpp2IlInjected.Token(Token = "0x60003C7")]
		[Cpp2IlInjected.Address(RVA = "0x5A04F00", Offset = "0x5A04300", VA = "0x185A04F00")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003C8")]
		[Cpp2IlInjected.Address(RVA = "0x5A03F40", Offset = "0x5A03340", VA = "0x185A03F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000136")]
	public Quaternion DOIAKOGFGJO
	{
		[Cpp2IlInjected.Token(Token = "0x60003C9")]
		[Cpp2IlInjected.Address(RVA = "0x5A064C0", Offset = "0x5A058C0", VA = "0x185A064C0")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CA")]
		[Cpp2IlInjected.Address(RVA = "0x5A055F0", Offset = "0x5A049F0", VA = "0x185A055F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000137")]
	public Vector3 OHEFFLBIFAC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CB")]
		[Cpp2IlInjected.Address(RVA = "0x5A04610", Offset = "0x5A03A10", VA = "0x185A04610")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CC")]
		[Cpp2IlInjected.Address(RVA = "0x5A06260", Offset = "0x5A05660", VA = "0x185A06260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000138")]
	public Quaternion KIDKMOGDJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60003CD")]
		[Cpp2IlInjected.Address(RVA = "0x5A05830", Offset = "0x5A04C30", VA = "0x185A05830")]
		get
		{
			return default(Quaternion);
		}
		[Cpp2IlInjected.Token(Token = "0x60003CE")]
		[Cpp2IlInjected.Address(RVA = "0x5A06060", Offset = "0x5A05460", VA = "0x185A06060")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000139")]
	public float KLDCIHBBDFN
	{
		[Cpp2IlInjected.Token(Token = "0x60003CF")]
		[Cpp2IlInjected.Address(RVA = "0x5A05360", Offset = "0x5A04760", VA = "0x185A05360")]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D0")]
		[Cpp2IlInjected.Address(RVA = "0x5A04030", Offset = "0x5A03430", VA = "0x185A04030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013A")]
	public float NJDFPHEEKBI
	{
		[Cpp2IlInjected.Token(Token = "0x60003D1")]
		[Cpp2IlInjected.Address(RVA = "0x5A05010", Offset = "0x5A04410", VA = "0x185A05010")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013B")]
	public Vector3 HLDBDAEHOAL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D2")]
		[Cpp2IlInjected.Address(RVA = "0x5A04980", Offset = "0x5A03D80", VA = "0x185A04980")]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x60003D3")]
		[Cpp2IlInjected.Address(RVA = "0x5A063D0", Offset = "0x5A057D0", VA = "0x185A063D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013C")]
	public Vector3 JGLBKLGPCOE
	{
		[Cpp2IlInjected.Token(Token = "0x60003D4")]
		[Cpp2IlInjected.Address(RVA = "0x5A06610", Offset = "0x5A05A10", VA = "0x185A06610")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013D")]
	public Vector3 OAJPGEKGHJL
	{
		[Cpp2IlInjected.Token(Token = "0x60003D5")]
		[Cpp2IlInjected.Address(RVA = "0x5A042F0", Offset = "0x5A036F0", VA = "0x185A042F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700013E")]
	public Matrix4x4 NDJHNLODGAK
	{
		[Cpp2IlInjected.Token(Token = "0x60003D6")]
		[Cpp2IlInjected.Address(RVA = "0x5A06350", Offset = "0x5A05750", VA = "0x185A06350")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60003BD")]
	[Cpp2IlInjected.Address(RVA = "0x21E5F30", Offset = "0x21E5330", VA = "0x1821E5F30")]
	public GNBHPPAICCJ(HEKFLAGDMLJ LEMCMBEMOCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003BE")]
	[Cpp2IlInjected.Address(RVA = "0x59FEA40", Offset = "0x59FDE40", VA = "0x1859FEA40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60003BF")]
	[Cpp2IlInjected.Address(RVA = "0x5A04A90", Offset = "0x5A03E90", VA = "0x185A04A90", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C0")]
	[Cpp2IlInjected.Address(RVA = "0x59FE6D0", Offset = "0x59FDAD0", VA = "0x1859FE6D0", Slot = "4")]
	public bool Equals(GNBHPPAICCJ ICELKIGIKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60003C1")]
	[Cpp2IlInjected.Address(RVA = "0x59FEF40", Offset = "0x59FE340", VA = "0x1859FEF40", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60003C5")]
	[Cpp2IlInjected.Address(RVA = "0x5A05590", Offset = "0x5A04990", VA = "0x185A05590")]
	public JANGGNCGNFH JLHGMOBDGPB()
	{
		return default(JANGGNCGNFH);
	}

	[Cpp2IlInjected.Token(Token = "0x60003D7")]
	[Cpp2IlInjected.Address(RVA = "0x5A04840", Offset = "0x5A03C40", VA = "0x185A04840")]
	public void DLHHEFMJPDN(out Matrix4x4 KANIJOBCBKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D8")]
	[Cpp2IlInjected.Address(RVA = "0x5A05410", Offset = "0x5A04810", VA = "0x185A05410")]
	public void JHNJPPBMDFI(out Vector3 JCHICGJDACK, out Quaternion JKEDCLPKFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003D9")]
	[Cpp2IlInjected.Address(RVA = "0x5A051B0", Offset = "0x5A045B0", VA = "0x185A051B0")]
	public void IJHLFCJJJOP(out RigidTransform MLDAHPKMLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DA")]
	[Cpp2IlInjected.Address(RVA = "0x5A04720", Offset = "0x5A03B20", VA = "0x185A04720")]
	public IJEMHFEELIK DGMIHMMNFKA()
	{
		return default(IJEMHFEELIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DB")]
	[Cpp2IlInjected.Address(RVA = "0x5A04770", Offset = "0x5A03B70", VA = "0x185A04770")]
	public void DGMIHMMNFKA(out IJEMHFEELIK JDFCJELKELM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DC")]
	[Cpp2IlInjected.Address(RVA = "0x5A04DA0", Offset = "0x5A041A0", VA = "0x185A04DA0")]
	public IJEMHFEELIK FOEDGMBPNDM()
	{
		return default(IJEMHFEELIK);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DD")]
	[Cpp2IlInjected.Address(RVA = "0x5A04CD0", Offset = "0x5A040D0", VA = "0x185A04CD0")]
	public void FOEDGMBPNDM(out IJEMHFEELIK MLDAHPKMLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003DE")]
	[Cpp2IlInjected.Address(RVA = "0x5A05E20", Offset = "0x5A05220", VA = "0x185A05E20")]
	public Vector3 LEGOMAEJGKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003DF")]
	[Cpp2IlInjected.Address(RVA = "0x5A04200", Offset = "0x5A03600", VA = "0x185A04200")]
	public void BOAKGFBBALM(in Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E0")]
	[Cpp2IlInjected.Address(RVA = "0x5A040F0", Offset = "0x5A034F0", VA = "0x185A040F0")]
	public Vector3 BIBFBOKINNF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E1")]
	[Cpp2IlInjected.Address(RVA = "0x5A05270", Offset = "0x5A04670", VA = "0x185A05270")]
	public void IKHKFNJOIDD(in Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E2")]
	[Cpp2IlInjected.Address(RVA = "0x5A056E0", Offset = "0x5A04AE0", VA = "0x185A056E0")]
	public Quaternion KAJNNNFBNMK()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E3")]
	[Cpp2IlInjected.Address(RVA = "0x5A06700", Offset = "0x5A05B00", VA = "0x185A06700")]
	public void PEJHJFHKCAB(in Quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E4")]
	[Cpp2IlInjected.Address(RVA = "0x5A04400", Offset = "0x5A03800", VA = "0x185A04400")]
	public Quaternion CKDDLMCPCBJ()
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E5")]
	[Cpp2IlInjected.Address(RVA = "0x5A050C0", Offset = "0x5A044C0", VA = "0x185A050C0")]
	public void HNDHIGLEAHI(in Quaternion AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E6")]
	[Cpp2IlInjected.Address(RVA = "0x5A05F30", Offset = "0x5A05330", VA = "0x185A05F30")]
	public float LENHBKBDNOC()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E7")]
	[Cpp2IlInjected.Address(RVA = "0x5A04550", Offset = "0x5A03950", VA = "0x185A04550")]
	public void CLJCMNEALKH(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003E8")]
	[Cpp2IlInjected.Address(RVA = "0x5A04C20", Offset = "0x5A04020", VA = "0x185A04C20")]
	public float FKKMKADPJLM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60003E9")]
	[Cpp2IlInjected.Address(RVA = "0x5A05980", Offset = "0x5A04D80", VA = "0x185A05980")]
	public void KJGIBFOKIBF(float AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EA")]
	[Cpp2IlInjected.Address(RVA = "0x5A05A40", Offset = "0x5A04E40", VA = "0x185A05A40")]
	public void KKIOCJEEKAD(in Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EB")]
	[Cpp2IlInjected.Address(RVA = "0x5A05D10", Offset = "0x5A05110", VA = "0x185A05D10")]
	public Vector3 LDLMKAEFKOI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EC")]
	[Cpp2IlInjected.Address(RVA = "0x5A04B30", Offset = "0x5A03F30", VA = "0x185A04B30")]
	public void FHKAOGFALKK(in Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003ED")]
	[Cpp2IlInjected.Address(RVA = "0x5A04DF0", Offset = "0x5A041F0", VA = "0x185A04DF0")]
	public Vector3 FPECNNNPDIO()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003EE")]
	[Cpp2IlInjected.Address(RVA = "0x5A05B30", Offset = "0x5A04F30", VA = "0x185A05B30")]
	public void KLLOPNBMNLN(in Vector3 AGLCIEKHLEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60003EF")]
	[Cpp2IlInjected.Address(RVA = "0x5A06150", Offset = "0x5A05550", VA = "0x185A06150")]
	public Vector3 MLKKLKNFHGF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60003F0")]
	[Cpp2IlInjected.Address(RVA = "0x5A05C20", Offset = "0x5A05020", VA = "0x185A05C20")]
	public void LDEMGJAMPIP(in Vector3 AGLCIEKHLEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200008B")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface IMBCAHJKJCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700013F")]
	FFCBJDNAPKG MBFMJLDEOAE
	{
		[Cpp2IlInjected.Token(Token = "0x60003F6")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000140")]
	OMJPGCFKPLM JHAIGONPOKC
	{
		[Cpp2IlInjected.Token(Token = "0x60003F7")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000B")]
	event Action<FDJPAKEFOJE, NativeArray<IMPAOGMALJN>> OJINPMLFCEI;

	[Cpp2IlInjected.Token(Token = "0x1400000C")]
	event Action<FDJPAKEFOJE> BKENOIEFKLO;

	[Cpp2IlInjected.Token(Token = "0x60003F8")]
	[Cpp2IlInjected.Address(Slot = "6")]
	NILIGAKBOAA BOPDAANMFBE(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60003F9")]
	[Cpp2IlInjected.Address(Slot = "7")]
	IMPAOGMALJN LOONLFGPLMG(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60003FA")]
	[Cpp2IlInjected.Address(Slot = "8")]
	void EHBDNPLCIKI(JDPNCHCMAIA DDCHJBPICDC, KINEJENHFEI LGIGGJMIOOL);

	[Cpp2IlInjected.Token(Token = "0x60003FB")]
	[Cpp2IlInjected.Address(Slot = "9")]
	MDECDPGCMCD LPGPBDHIJGJ(HEKFLAGDMLJ LEMCMBEMOCB, [Optional] object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x60003FC")]
	[Cpp2IlInjected.Address(Slot = "10")]
	bool DFFNJGBMJCN(HEKFLAGDMLJ LEMCMBEMOCB, out KINEJENHFEI LGIGGJMIOOL);

	[Cpp2IlInjected.Token(Token = "0x60003FD")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool DAJCKLBFICP(HEKFLAGDMLJ LEMCMBEMOCB, out Transform DKKDEHMFAEC);

	[Cpp2IlInjected.Token(Token = "0x60003FE")]
	[Cpp2IlInjected.Address(Slot = "12")]
	bool CNIFBOMIGIC(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x60003FF")]
	[Cpp2IlInjected.Address(Slot = "13")]
	void FDENDKGBGMI(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000400")]
	[Cpp2IlInjected.Address(Slot = "14")]
	bool KLHFNHDCKBB(LocalId LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000401")]
	[Cpp2IlInjected.Address(Slot = "15")]
	bool IBFCLOIPLKD(LocalId LEMCMBEMOCB, object AEMEEHLIDCM);

	[Cpp2IlInjected.Token(Token = "0x6000402")]
	[Cpp2IlInjected.Address(Slot = "16")]
	HEKFLAGDMLJ FLILGDFALDL(JDPNCHCMAIA DDCHJBPICDC);

	[Cpp2IlInjected.Token(Token = "0x6000403")]
	[Cpp2IlInjected.Address(Slot = "17")]
	bool EHDJALGIOME(JDPNCHCMAIA DDCHJBPICDC, out HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000404")]
	[Cpp2IlInjected.Address(Slot = "18")]
	JDPNCHCMAIA NLIKCLIKHPF(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000405")]
	[Cpp2IlInjected.Address(Slot = "19")]
	FDJPAKEFOJE FLILGDFALDL(NativeArray<JDPNCHCMAIA> DDCHJBPICDC, Allocator DGGNDNPDKKD);

	[Cpp2IlInjected.Token(Token = "0x6000406")]
	[Cpp2IlInjected.Address(Slot = "20")]
	FDJPAKEFOJE BEGKLCGFGLD(NativeArray<JDPNCHCMAIA> DDCHJBPICDC, NativeArray<BACOLBMJCKD> LHMBGJCLFKL, Allocator DGGNDNPDKKD);

	[Cpp2IlInjected.Token(Token = "0x6000407")]
	[Cpp2IlInjected.Address(Slot = "21")]
	MDECDPGCMCD MAHAICGFPFA(IMPAOGMALJN JBGKOICMKNG, bool MBDCIOFDMHF);

	[Cpp2IlInjected.Token(Token = "0x6000408")]
	[Cpp2IlInjected.Address(Slot = "22")]
	MDECDPGCMCD MAHAICGFPFA(IMPAOGMALJN JBGKOICMKNG);

	[Cpp2IlInjected.Token(Token = "0x6000409")]
	[Cpp2IlInjected.Address(Slot = "23")]
	MDECDPGCMCD JAGJFGHADMB(IMPAOGMALJN JBGKOICMKNG);

	[Cpp2IlInjected.Token(Token = "0x600040A")]
	[Cpp2IlInjected.Address(Slot = "24")]
	MDECDPGCMCD NLOADONOICP(IMPAOGMALJN JBGKOICMKNG);

	[Cpp2IlInjected.Token(Token = "0x600040B")]
	[Cpp2IlInjected.Address(Slot = "25")]
	MDECDPGCMCD BEGKLCGFGLD(JDPNCHCMAIA DDCHJBPICDC, IMPAOGMALJN JBGKOICMKNG);

	[Cpp2IlInjected.Token(Token = "0x600040C")]
	[Cpp2IlInjected.Address(Slot = "26")]
	IGCAMFAHCMC IKLJBOFADML();

	[Cpp2IlInjected.Token(Token = "0x600040D")]
	[Cpp2IlInjected.Address(Slot = "27")]
	MKIIJMKIKEO GIOEOGPFLEP();

	[Cpp2IlInjected.Token(Token = "0x600040E")]
	[Cpp2IlInjected.Address(Slot = "28")]
	OAGDIDHKOIF LEPFNPDPKPM(DJOJBOPMMAC OOPMJBFCIOJ);

	[Cpp2IlInjected.Token(Token = "0x600040F")]
	[Cpp2IlInjected.Address(Slot = "29")]
	void FCGGIDBOLFJ(FDJPAKEFOJE GAOJFDPACED);

	[Cpp2IlInjected.Token(Token = "0x6000410")]
	[Cpp2IlInjected.Address(Slot = "30")]
	void EHKLIGBABLK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000411")]
	[Cpp2IlInjected.Address(Slot = "31")]
	void ADLMBBDHIJK(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000412")]
	[Cpp2IlInjected.Address(Slot = "32")]
	void FCGGIDBOLFJ(HEKFLAGDMLJ LEMCMBEMOCB);

	[Cpp2IlInjected.Token(Token = "0x6000413")]
	[Cpp2IlInjected.Address(Slot = "33")]
	FDJPAKEFOJE OHHBKCKEINJ(FDJPAKEFOJE HAMAKNIIOKD, Allocator DGGNDNPDKKD);

	[Cpp2IlInjected.Token(Token = "0x6000414")]
	[Cpp2IlInjected.Address(Slot = "34")]
	bool HFDNCCJGOAI(HEKFLAGDMLJ LEMCMBEMOCB);
}
[Cpp2IlInjected.Token(Token = "0x200008C")]
public static class AIADKFPIJPB
{
	[Cpp2IlInjected.Token(Token = "0x6000415")]
	[Cpp2IlInjected.Address(RVA = "0x59FF910", Offset = "0x59FED10", VA = "0x1859FF910")]
	public static void FDENDKGBGMI(this IMBCAHJKJCI CNNBPGGDJCA, KINEJENHFEI LGIGGJMIOOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000416")]
	[Cpp2IlInjected.Address(RVA = "0x59FFDD0", Offset = "0x59FF1D0", VA = "0x1859FFDD0")]
	public static MDECDPGCMCD ODHJCPPNPBP(this IMBCAHJKJCI CNNBPGGDJCA, LocalId LEMCMBEMOCB)
	{
		return default(MDECDPGCMCD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000417")]
	[Cpp2IlInjected.Address(RVA = "0x59FFA10", Offset = "0x59FEE10", VA = "0x1859FFA10")]
	public static HEKFLAGDMLJ FLILGDFALDL(this IMBCAHJKJCI CNNBPGGDJCA, LocalId LEMCMBEMOCB)
	{
		return default(HEKFLAGDMLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000418")]
	[Cpp2IlInjected.Address(RVA = "0x59FFCE0", Offset = "0x59FF0E0", VA = "0x1859FFCE0")]
	public static JDPNCHCMAIA NLIKCLIKHPF(this IMBCAHJKJCI CNNBPGGDJCA, LocalId LEMCMBEMOCB)
	{
		return default(JDPNCHCMAIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000419")]
	[Cpp2IlInjected.Address(RVA = "0x59FFA40", Offset = "0x59FEE40", VA = "0x1859FFA40")]
	public static bool HFDNCCJGOAI(this IMBCAHJKJCI CNNBPGGDJCA, JDPNCHCMAIA DDCHJBPICDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600041A")]
	[Cpp2IlInjected.Address(RVA = "0x15E0FB0", Offset = "0x15E03B0", VA = "0x1815E0FB0")]
	public static T IJPAGMLGBCG<T>(this IMBCAHJKJCI CNNBPGGDJCA, LocalId LEMCMBEMOCB) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600041B")]
	[Cpp2IlInjected.Address(RVA = "0x59FF7D0", Offset = "0x59FEBD0", VA = "0x1859FF7D0")]
	public static IGCAMFAHCMC FAGNLCGNLDH(this IMBCAHJKJCI CNNBPGGDJCA, RigidTransform JDFCJELKELM, [Optional] object AEMEEHLIDCM)
	{
		return default(IGCAMFAHCMC);
	}

	[Cpp2IlInjected.Token(Token = "0x600041C")]
	[Cpp2IlInjected.Address(RVA = "0x59FFBA0", Offset = "0x59FEFA0", VA = "0x1859FFBA0")]
	public static OAGDIDHKOIF JALKKPMDICM(this IMBCAHJKJCI CNNBPGGDJCA, DJOJBOPMMAC AEOICJBAKHI, RigidTransform JDFCJELKELM, [Optional] object AEMEEHLIDCM)
	{
		return default(OAGDIDHKOIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600041D")]
	[Cpp2IlInjected.Address(RVA = "0x59FF690", Offset = "0x59FEA90", VA = "0x1859FF690")]
	public static MKIIJMKIKEO EJAKPLIEJNG(this IMBCAHJKJCI CNNBPGGDJCA, RigidTransform JDFCJELKELM, [Optional] object AEMEEHLIDCM)
	{
		return default(MKIIJMKIKEO);
	}

	[Cpp2IlInjected.Token(Token = "0x600041E")]
	[Cpp2IlInjected.Address(RVA = "0x59FF140", Offset = "0x59FE540", VA = "0x1859FF140")]
	private static void ACBOEILAFMB(MDECDPGCMCD ELEBJABEOKF, RigidTransform JDFCJELKELM, [Optional] object AEMEEHLIDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600041F")]
	[Cpp2IlInjected.Address(RVA = "0x59FF490", Offset = "0x59FE890", VA = "0x1859FF490")]
	internal static DCMGEEAECJC DNNGIMFAEGL(this IMBCAHJKJCI CNNBPGGDJCA, LDPBHDEACKL PICAEEIAFAJ, [Optional] object AEMEEHLIDCM)
	{
		return default(DCMGEEAECJC);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008D")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface HKKLACDDFPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000420")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int BLHLMIMPDNB(GameObject NNAKJIJAOJG);

	[Cpp2IlInjected.Token(Token = "0x6000421")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void ODHMJKHLDEP(GameObject NNAKJIJAOJG);

	[Cpp2IlInjected.Token(Token = "0x6000422")]
	[Cpp2IlInjected.Address(Slot = "2")]
	object IPHABDKDCMM(HEKFLAGDMLJ LEMCMBEMOCB, GameObject NNAKJIJAOJG, Action<HEKFLAGDMLJ, int> IPDGCBIIEII);

	[Cpp2IlInjected.Token(Token = "0x6000423")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void MGPCHJEFCOM(GameObject NNAKJIJAOJG, object DGLFKNPPKPF);
}
[Cpp2IlInjected.Token(Token = "0x200008E")]
internal static class AKIHFBLCCKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000424")]
	[Cpp2IlInjected.Address(RVA = "0x59FFEB0", Offset = "0x59FF2B0", VA = "0x1859FFEB0")]
	public static FFCBJDNAPKG MBFMJLDEOAE(this HEKFLAGDMLJ JNHCLKAAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000425")]
	[Cpp2IlInjected.Address(RVA = "0x59FFE10", Offset = "0x59FF210", VA = "0x1859FFE10")]
	public static ICCLAPFHPJL GMBOJNPAEGG(this HEKFLAGDMLJ JNHCLKAAKHA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000426")]
	[Cpp2IlInjected.Address(RVA = "0x59FFF10", Offset = "0x59FF310", VA = "0x1859FFF10")]
	public static EntityManager NAPOFGNIKAG(this HEKFLAGDMLJ JNHCLKAAKHA)
	{
		return default(EntityManager);
	}

	[Cpp2IlInjected.Token(Token = "0x6000427")]
	[Cpp2IlInjected.Address(RVA = "0x15E76A0", Offset = "0x15E6AA0", VA = "0x1815E76A0")]
	public static T EJIHMNGFFPB<T>(this HEKFLAGDMLJ JNHCLKAAKHA) where T : struct, IComponent
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000428")]
	[Cpp2IlInjected.Address(RVA = "0x15E8AD0", Offset = "0x15E7ED0", VA = "0x1815E8AD0")]
	public static bool MCHECBNAGBA<T>(this HEKFLAGDMLJ JNHCLKAAKHA) where T : struct, IComponentData
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200008F")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
internal interface HDHFLPILNPM
{
	[Cpp2IlInjected.Token(Token = "0x1400000D")]
	event Action<JPKFBBKCAIK> PMHLBEAPEMG;
}
[Cpp2IlInjected.Token(Token = "0x2000090")]
[HIFHEPGGLJB(FGCKLJIPPNH.LoadInstance)]
public interface FEEKAOBEJNL
{
	[Cpp2IlInjected.Token(Token = "0x17000141")]
	bool PFHIAFAGPFO
	{
		[Cpp2IlInjected.Token(Token = "0x600042D")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000142")]
	HEKFLAGDMLJ HGAPDNGDCGI
	{
		[Cpp2IlInjected.Token(Token = "0x600042E")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
		[Cpp2IlInjected.Token(Token = "0x600042F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000143")]
	MDECDPGCMCD IAGEFKLKOLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000430")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
		[Cpp2IlInjected.Token(Token = "0x6000431")]
		[Cpp2IlInjected.Address(Slot = "6")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x1400000E")]
	event JKFKEKENGGE FBBGMFMCEJA;

	[Cpp2IlInjected.Token(Token = "0x6000432")]
	[Cpp2IlInjected.Address(Slot = "7")]
	HEKFLAGDMLJ OKDEEBIDGEN(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME);

	[Cpp2IlInjected.Token(Token = "0x6000433")]
	[Cpp2IlInjected.Address(Slot = "8")]
	bool MPHFLBOJAHA(HEKFLAGDMLJ JNHEGOFDJBP, HEKFLAGDMLJ JBNLIGHJDME, out HEKFLAGDMLJ MCDGHNFJPKK);

	[Cpp2IlInjected.Token(Token = "0x6000434")]
	[Cpp2IlInjected.Address(Slot = "9")]
	void EHGPIGIEBGB();

	[Cpp2IlInjected.Token(Token = "0x6000435")]
	[Cpp2IlInjected.Address(Slot = "10")]
	void ADGPAGFGHPF();

	[Cpp2IlInjected.Token(Token = "0x6000436")]
	[Cpp2IlInjected.Address(Slot = "11")]
	bool EKHOIKIJAFN(HEKFLAGDMLJ JNHEGOFDJBP);
}
[Cpp2IlInjected.Token(Token = "0x2000091")]
public delegate void JKFKEKENGGE(MDECDPGCMCD HGCGKEDHLOA, MDECDPGCMCD OKDNBCPJIIC);
[Cpp2IlInjected.Token(Token = "0x2000092")]
public static class PLFFKJPHBBC
{
	[Cpp2IlInjected.Token(Token = "0x600043B")]
	[Cpp2IlInjected.Address(RVA = "0x5A0EC80", Offset = "0x5A0E080", VA = "0x185A0EC80")]
	public static bool CNEPNIBOHLN(this FEEKAOBEJNL FLFEOLIKEEG, HEKFLAGDMLJ JNHEGOFDJBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600043C")]
	[Cpp2IlInjected.Address(RVA = "0x5A0F090", Offset = "0x5A0E490", VA = "0x185A0F090")]
	public static bool MHCIINKCAKA(this FEEKAOBEJNL FLFEOLIKEEG, HEKFLAGDMLJ JNHEGOFDJBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000093")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
[DefaultMember("Item")]
public interface OENENEPEABD : IEnumerable<FLJMOFPACJP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x17000144")]
	int HIBMACOFNKK
	{
		[Cpp2IlInjected.Token(Token = "0x600043D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000145")]
	FLJMOFPACJP ONEIGHFFEDC
	{
		[Cpp2IlInjected.Token(Token = "0x600043E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600043F")]
	[Cpp2IlInjected.Address(Slot = "2")]
	FLJMOFPACJP DNDGKGKJHCH(LOHCJILDMLL OCFGMKDOPDP);

	[Cpp2IlInjected.Token(Token = "0x6000440")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FDOJMOENJAL LEEAMPOIODD(LOHCJILDMLL OCFGMKDOPDP);
}
[Cpp2IlInjected.Token(Token = "0x2000094")]
public static class PKJCCOMLJAM
{
	[Cpp2IlInjected.Token(Token = "0x6000441")]
	[Cpp2IlInjected.Address(RVA = "0x3237680", Offset = "0x3236A80", VA = "0x183237680")]
	public static LKPHPGGEFLH<T> DNDGKGKJHCH<T>(this OENENEPEABD OEGNIABGFIK, LOHCJILDMLL GDKOBCHHFLB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000442")]
	[Cpp2IlInjected.Address(RVA = "0x32377A0", Offset = "0x3236BA0", VA = "0x1832377A0")]
	public static LKPHPGGEFLH<T> DNDGKGKJHCH<T>(this OENENEPEABD OEGNIABGFIK, ENIPADEGOMD<T> GDKOBCHHFLB) where T : struct
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000443")]
	[Cpp2IlInjected.Address(RVA = "0x32378F0", Offset = "0x3236CF0", VA = "0x1832378F0")]
	public static FDOJMOENJAL LEEAMPOIODD<T>(this OENENEPEABD OEGNIABGFIK, ENIPADEGOMD<T> GDKOBCHHFLB) where T : struct
	{
		return default(FDOJMOENJAL);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000095")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface FOODIHPHGKA : MBDFLOLPEII
{
	[Cpp2IlInjected.Token(Token = "0x6000444")]
	[Cpp2IlInjected.Address(Slot = "0")]
	PAAEECCICPH FBDDCJHOFOO(Entity GKMECPLEALF);

	[Cpp2IlInjected.Token(Token = "0x6000445")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void DPILJEDEJAJ(NativeArray<PAAEECCICPH> KCIHKMODENE, NativeArray<BFOKBMJCBHG> CHMGFONJEKM);

	[Cpp2IlInjected.Token(Token = "0x6000446")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CEAHOIPMOHF(PAAEECCICPH PAHMPOAEKCN);

	[Cpp2IlInjected.Token(Token = "0x6000447")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool GFFOILJFPCP(PAAEECCICPH PAHMPOAEKCN, out Collider MPDBOOOIMLM);
}
[Cpp2IlInjected.Token(Token = "0x2000096")]
public struct BFOKBMJCBHG : ISystemStateComponentData, IComponentData, IEquatable<BFOKBMJCBHG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public float3 CONPCENHMHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public float3 LCGACJPCLFK;

	[Cpp2IlInjected.Token(Token = "0x6000448")]
	[Cpp2IlInjected.Address(RVA = "0x5A008C0", Offset = "0x59FFCC0", VA = "0x185A008C0", Slot = "4")]
	public bool Equals(BFOKBMJCBHG ICELKIGIKKP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000097")]
public struct GGLLEGPCFPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public Guid DDJMKPCJBFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public string KNPFDHANMOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Vector3 FGLOAKJBDBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Quaternion OCEJJKMFIJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Vector3 ECOCGLBAPIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public int HIIGKPDBJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Dictionary<string, object> NPOLKGPPPJC;

	[Cpp2IlInjected.Token(Token = "0x6000449")]
	[Cpp2IlInjected.Address(RVA = "0x5A038E0", Offset = "0x5A02CE0", VA = "0x185A038E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600044A")]
	[Cpp2IlInjected.Address(RVA = "0x5A03750", Offset = "0x5A02B50", VA = "0x185A03750")]
	private static string DOGMAACMJCE(Dictionary<string, object> HMHINJBEENE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000099")]
public enum JPBAIPNMNMH
{
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	Subgraph
}
[Cpp2IlInjected.Token(Token = "0x200009A")]
public enum ALGIECDKBAP
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	World,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	SubGraphAdditive,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	SubGraphReplace
}
[Cpp2IlInjected.Token(Token = "0x200009B")]
public static class ALHKBFHLIDK
{
	[Cpp2IlInjected.Token(Token = "0x600044E")]
	[Cpp2IlInjected.Address(RVA = "0x451C860", Offset = "0x451BC60", VA = "0x18451C860")]
	public static bool IGMPNMNHBMG(this ALGIECDKBAP GANFKPHKNKH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200009C")]
public interface MHBNDALDLMC : MPCJLDHBHBF, IDisposable
{
}
[Cpp2IlInjected.Token(Token = "0x200009D")]
[Flags]
public enum BDDDPJDFJGN
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ParseProtobuf = 1,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	PostInstantiate = 8,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	NotifyInstantiated = 0x10,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DisposeProtobuf = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	NotifyCompleted = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	WorldPhasesMaster = 0x7F,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	WorldPhasesClient = 0x7B,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	AdditivePhases = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009E")]
[Flags]
public enum FAOBGNBFBJI
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Parse = 1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	PreInstantiate = 2,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	BulkInstantiate = 4,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	PostInstantiate = 0x18,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	LoadCompleted = 0x60,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	All = 0x7F
}
[Cpp2IlInjected.Token(Token = "0x200009F")]
public interface NDHMEAKEDNA : MPCJLDHBHBF, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000146")]
	MFMOHGACDCK JIGOFCBPEGO
	{
		[Cpp2IlInjected.Token(Token = "0x600044F")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000450")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FOLFCGOHDPG();

	[Cpp2IlInjected.Token(Token = "0x6000451")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void GDPMMJCECMN();
}
[Cpp2IlInjected.Token(Token = "0x20000A0")]
public interface MFMOHGACDCK
{
	[Cpp2IlInjected.Token(Token = "0x6000452")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NMOFIEHHJBP(Guid CIDBOBPIINF, out Guid NBCAFBHOFIE);
}
[Cpp2IlInjected.Token(Token = "0x20000A1")]
public interface CEGKNKGECDI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000147")]
	JGECFECPNBB OGCDKDFJJHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000453")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000454")]
	[Cpp2IlInjected.Address(Slot = "1")]
	ByteString CIBKNCFFHFO();
}
[Cpp2IlInjected.Token(Token = "0x20000A2")]
public interface MPCJLDHBHBF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000148")]
	IEnumerable<GGLLEGPCFPG> OOJFKOEJFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000455")]
		[Cpp2IlInjected.Address(Slot = "0")]
		set;
	}

	[Cpp2IlInjected.Token(Token = "0x17000149")]
	ALNGHMJNFBH KFJOBECICAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000456")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014A")]
	LocalId ELGHMFCLLPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000457")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014B")]
	JGECFECPNBB APOELKPGKHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000458")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700014C")]
	Task GJOOGKJBEPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000459")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	bool NBOCHEIPFNJ(BDDDPJDFJGN GMAFCCAHJCD);
}
[Cpp2IlInjected.Token(Token = "0x20000A3")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface FCPFIHPBBHN
{
	[Cpp2IlInjected.Token(Token = "0x600045B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LENCHPICOIF(int DCJNJIADGPK);
}
[Cpp2IlInjected.Token(Token = "0x20000A4")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface GAGBBBEFGOD
{
	[Cpp2IlInjected.Token(Token = "0x1700014D")]
	IEnumerable<GKINOCIEEIK> NHGIAHBMLDO
	{
		[Cpp2IlInjected.Token(Token = "0x600045C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600045D")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool KFICFAEICON(int DCJNJIADGPK, out GKINOCIEEIK BIMCFGLAOAL);
}
[Cpp2IlInjected.Token(Token = "0x20000A5")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface HKFIEKHFLEE
{
	[Cpp2IlInjected.Token(Token = "0x1700014E")]
	List<(ICBIKEFGDEP nameHash, MAFKLBIHIJI stableTypeHash, Type type)> PNGBDEBEDEA
	{
		[Cpp2IlInjected.Token(Token = "0x600045E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A6")]
[HIFHEPGGLJB(FGCKLJIPPNH.Application)]
public interface DLIMMLKNEFD
{
	[Cpp2IlInjected.Token(Token = "0x600045F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	ICBIKEFGDEP ICBJJDAHMJA(int DCJNJIADGPK);

	[Cpp2IlInjected.Token(Token = "0x6000460")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int MALFOLDDHMP(ICBIKEFGDEP GBANGIMAALB);
}
[Cpp2IlInjected.Token(Token = "0x20000A7")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface JPKPMPALKHK
{
	[Cpp2IlInjected.Token(Token = "0x6000461")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void OEELPNPOLFP(JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL IOPMEPNDGKE, ReadOnlySpan<byte> KPDLBKBOMOO, ReadOnlySpan<byte> CDDMJOBFBFM);

	[Cpp2IlInjected.Token(Token = "0x6000462")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EMHKIBFHLAN(JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL IOPMEPNDGKE);

	[Cpp2IlInjected.Token(Token = "0x6000463")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool IALPDIIHFKB(JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL IOPMEPNDGKE, ReadOnlySpan<byte> CDDMJOBFBFM);

	[Cpp2IlInjected.Token(Token = "0x6000464")]
	[Cpp2IlInjected.Address(Slot = "3")]
	bool FGJCNEMODHE(JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL IOPMEPNDGKE, Span<byte> KPDLBKBOMOO, Span<byte> CDDMJOBFBFM);
}
[Cpp2IlInjected.Token(Token = "0x20000A8")]
public static class DLCFNBDGLEN
{
	[Cpp2IlInjected.Token(Token = "0x6000465")]
	[Cpp2IlInjected.Address(RVA = "0x2C823F0", Offset = "0x2C817F0", VA = "0x182C823F0")]
	public static bool FGJCNEMODHE<T>(this JPKPMPALKHK AJLIICGFPPA, JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL IOPMEPNDGKE, out T KPDLBKBOMOO, out T CDDMJOBFBFM) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000466")]
	[Cpp2IlInjected.Address(RVA = "0x2C825B0", Offset = "0x2C819B0", VA = "0x182C825B0")]
	public static bool IALPDIIHFKB<T>(this JPKPMPALKHK AJLIICGFPPA, JDPNCHCMAIA LPDFIBCDEJA, FDOJMOENJAL IOPMEPNDGKE, T CDDMJOBFBFM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000A9")]
public enum BKDEBJLKFDM
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	End,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Create,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Destroy,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	SetProp,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Event,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	COUNT
}
[Cpp2IlInjected.Token(Token = "0x20000AA")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface DDCOJKKDDIF : CBPAPHMCJAC<DDCOJKKDDIF>
{
	[Cpp2IlInjected.Token(Token = "0x6000467")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool HBBLEOHJDFE(FDOJMOENJAL JNHCLKAAKHA, out DHFCPGFDHFO BIMCFGLAOAL);
}
[Cpp2IlInjected.Token(Token = "0x20000AB")]
public static class BPBIMEBGKHI
{
}
[Cpp2IlInjected.Token(Token = "0x20000AC")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface JIDPKPDHEOA
{
	[Cpp2IlInjected.Token(Token = "0x1700014F")]
	uint OBDPDBHGEBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000468")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000AD")]
public struct MGFKHIIALBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public JGELFBOFGKF OIEACLJHHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public ReadOnlyMemory<byte> HOJNLEBJGLH;
}
[Cpp2IlInjected.Token(Token = "0x20000AE")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface OLPNFLMELII
{
	[Cpp2IlInjected.Token(Token = "0x6000469")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AKDMLHDMGHC(JGELFBOFGKF OIEACLJHHPB, ReadOnlySpan<byte> HOJNLEBJGLH);
}
[Cpp2IlInjected.Token(Token = "0x20000AF")]
public delegate bool GAIEDAHOCAL(JPKPMPALKHK LICBMLMJHDB, in CIMGDHMJEHM AGLCIEKHLEE);
[Cpp2IlInjected.Token(Token = "0x20000B0")]
public delegate bool CPDIEPGIKAH<T>(JPKPMPALKHK LICBMLMJHDB, in T AGLCIEKHLEE);
[Cpp2IlInjected.Token(Token = "0x20000B1")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface DEPDBGLFLFP
{
	[Cpp2IlInjected.Token(Token = "0x6000472")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void EHBDNPLCIKI(FDOJMOENJAL IOPMEPNDGKE, Type FELELGOJAHG, GAIEDAHOCAL PKJKDKKAEHL);

	[Cpp2IlInjected.Token(Token = "0x6000473")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool EGAIBILKDBJ(FDOJMOENJAL IOPMEPNDGKE, out GAIEDAHOCAL PKJKDKKAEHL);
}
[Cpp2IlInjected.Token(Token = "0x20000B2")]
public static class ADBKALFDGMI
{
	[Cpp2IlInjected.Token(Token = "0x20000B3")]
	[CompilerGenerated]
	private sealed class FDKABCFMHCC<T> where T : struct
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public CPDIEPGIKAH<T> conflictResolver;

		[Cpp2IlInjected.Token(Token = "0x6000476")]
		[Cpp2IlInjected.Address(RVA = "0x92E880", Offset = "0x92DC80", VA = "0x18092E880")]
		public FDKABCFMHCC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000477")]
		[Cpp2IlInjected.Address(RVA = "0x30E7E10", Offset = "0x30E7210", VA = "0x1830E7E10")]
		internal bool MMKDBOONLMN(JPKPMPALKHK pendingList, in CIMGDHMJEHM value)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000474")]
	[Cpp2IlInjected.Address(RVA = "0x15DC740", Offset = "0x15DBB40", VA = "0x1815DC740")]
	public static void EHBDNPLCIKI<T>(this DEPDBGLFLFP DEMMAINGNBB, FDOJMOENJAL IOPMEPNDGKE, CPDIEPGIKAH<T> PKJKDKKAEHL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000475")]
	[Cpp2IlInjected.Address(RVA = "0x59FEFB0", Offset = "0x59FE3B0", VA = "0x1859FEFB0")]
	public static bool BEGFOCIEPFA(this DEPDBGLFLFP DEMMAINGNBB, JPKPMPALKHK LICBMLMJHDB, FDOJMOENJAL IOPMEPNDGKE, in CIMGDHMJEHM AGLCIEKHLEE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B4")]
public struct JGELFBOFGKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public uint OAHDHLNKBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int JJHHDFLDBHF;

	[Cpp2IlInjected.Token(Token = "0x6000478")]
	[Cpp2IlInjected.Address(RVA = "0xAEEC80", Offset = "0xAEE080", VA = "0x180AEEC80")]
	public JGELFBOFGKF(uint OAHDHLNKBLF, int JJHHDFLDBHF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000479")]
	[Cpp2IlInjected.Address(RVA = "0x5A08580", Offset = "0x5A07980", VA = "0x185A08580")]
	public static bool PHJEMBLBEDF(in JGELFBOFGKF CAOIKBDHEDK, in JGELFBOFGKF ELHFHDBGEMK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047A")]
	[Cpp2IlInjected.Address(RVA = "0x5A084C0", Offset = "0x5A078C0", VA = "0x185A084C0", Slot = "0")]
	public override bool Equals(object HFAGBIOODHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600047B")]
	[Cpp2IlInjected.Address(RVA = "0x5A08550", Offset = "0x5A07950", VA = "0x185A08550", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600047C")]
	[Cpp2IlInjected.Address(RVA = "0x5A085A0", Offset = "0x5A079A0", VA = "0x185A085A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x20000B5")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface HOFAHHJLGEA
{
	[Cpp2IlInjected.Token(Token = "0x600047D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	JGELFBOFGKF FLAAFOIJKBF(ReadOnlySpan<byte> HOJNLEBJGLH);
}
[Cpp2IlInjected.Token(Token = "0x20000B6")]
public interface DHFCPGFDHFO
{
	[Cpp2IlInjected.Token(Token = "0x17000150")]
	Type KHBMFPOLFGC
	{
		[Cpp2IlInjected.Token(Token = "0x600047E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600047F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EFFJDOFDOEN(ref PPDNPLENLDL BFNPCLOLNAF, Span<byte> JNHEGOFDJBP);

	[Cpp2IlInjected.Token(Token = "0x6000480")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CJMDONJKOCN(ref KJIMKGCGBFG OMPJFFNAHDO, ReadOnlySpan<byte> OIEACLJHHPB);
}
[Cpp2IlInjected.Token(Token = "0x20000B7")]
public static class DIAAIIAJPBP
{
}
[Cpp2IlInjected.Token(Token = "0x20000B8")]
[HIFHEPGGLJB(FGCKLJIPPNH.OMRoom)]
public interface KBGKFCEPELG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x6000481")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void JHBODONMFDH(JGELFBOFGKF PMMAAICOJOP, ReadOnlySpan<byte> HOJNLEBJGLH);
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x20000B9")]
public class MGDDIBLAEHJ
{
	[Cpp2IlInjected.Token(Token = "0x6000482")]
	[Cpp2IlInjected.Address(RVA = "0x821B80", Offset = "0x820F80", VA = "0x180821B80")]
	public MGDDIBLAEHJ()
	{
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x20000BA")]
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
