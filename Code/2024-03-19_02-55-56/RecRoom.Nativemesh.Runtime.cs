using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.Rendering;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7E5660", Offset = "0x7E4660", VA = "0x1807E5660")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KCBLNHIPIKP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int BAIDHEKFIME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 GPLEANGFGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion OBPBIIGKHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 ONMPGGAGINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int LEOHDFJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LFFGDKFENIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int BHBLHJDODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float PNNPMJEJCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 CHKKKJAFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool FPIKCDDDKFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public PINBIKOBMLI ANHLIOPLENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 CKMHBNDMPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float BDCNDDNJGJI;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EBBKGFJOELG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static BEHDPGHDLBC OLBGPOKIGBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<KCBLNHIPIKP> DNCHFENGBNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<NMHMPAHCGIO> EFMPIHMPGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<MFJBDEBGKPA> KKAKANNICKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<JNHEEHKCAPD> CFLIPFEKKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<NMHMPAHCGIO> DGKAEIGHCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<MOCNMJJAIHB> CHOEGMKLBIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<JNHEEHKCAPD>> FCGFICBKGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<JGLFBGCNCJM> DDPMDKNCOJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> MKEADLJOAOM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ADFEHFHJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xC6F930", Offset = "0xC6E930", VA = "0x180C6F930")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xC6E0A0", Offset = "0xC6D0A0", VA = "0x180C6E0A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OOGFDFNGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC6F940", Offset = "0xC6E940", VA = "0x180C6F940")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC6E090", Offset = "0xC6D090", VA = "0x180C6E090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61ED790", Offset = "0x61EC790", VA = "0x1861ED790")]
	public EBBKGFJOELG(int MKPGEPKANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61EBD80", Offset = "0x61EAD80", VA = "0x1861EBD80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61ED3A0", Offset = "0x61EC3A0", VA = "0x1861ED3A0")]
	public void LKNIIEHHNJO(JobHandle LBMFCHLMCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61ED570", Offset = "0x61EC570", VA = "0x1861ED570")]
	public void NDEPADDJIGI(KCBLNHIPIKP ELANMAGHLLI, JGLFBGCNCJM DOIMDHMDPJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61EBC40", Offset = "0x61EAC40", VA = "0x1861EBC40")]
	public void BOANPGAJDFK(MFJBDEBGKPA ELANMAGHLLI, NativeArray<JNHEEHKCAPD> MABJIOIJIKH, int GHLJKICKIPG, int DAMLJNJLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61EC050", Offset = "0x61EB050", VA = "0x1861EC050")]
	public JobHandle HMICJLBFJPI(ILLGHIEDDJL FDHJJOKCCLG, KADAFFIFJBM EFCBCDDPPEK, float3 MILPPHFDDAP, quaternion CEKJPHKNIKM, float IOFKIIGOOGC, bool FCMCFIOIPJP, int ILEKHLHDBNI = 0, int GMFMFIHOFCC = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61ED060", Offset = "0x61EC060", VA = "0x1861ED060")]
	public static JobHandle LANFGIDPOLO(OOJIBMEEMGJ KNFDEFJELMN, ILLGHIEDDJL FDHJJOKCCLG, KCBLNHIPIKP ELANMAGHLLI, JobHandle LBMFCHLMCNM)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61EBDA0", Offset = "0x61EADA0", VA = "0x1861EBDA0")]
	public static JobHandle HFOPLKIBLFF(HKJBMNMPNFI KNFDEFJELMN, ILLGHIEDDJL FDHJJOKCCLG, MFJBDEBGKPA ELANMAGHLLI, NativeArray<JNHEEHKCAPD> MABJIOIJIKH, int GHLJKICKIPG, int DAMLJNJLIIO, JobHandle LBMFCHLMCNM)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DBPKKLOFMEL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public struct JFLDODHBCEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public half ABCCILJHFLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public ushort DPCJJKLFJNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public byte MJEFONLKMBF;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int GHLJKICKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public int DAMLJNJLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<ushort> KOJLGFPPMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<ushort> BLGGIMHPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<ushort> CAFFOCBNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<ushort> PDLDLBFEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<JFLDODHBCEG> KNKGHCILLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<byte> AOPHJGPKBCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<byte> OGOAEKOLFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float3 BOEACAHJABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float3 FJFDDLJKALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float2 NNAPFLAACKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float2 DNFBEOILIMJ;

	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public static long AFCNEBJNEEL;

	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static long OICEOLBEIMP;

	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public static float NNJMGEKLPEA;

	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private static bool PLKAJGMAAHE;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool EJICKBJHOPH
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61E8A90", Offset = "0x61E7A90", VA = "0x1861E8A90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61E94A0", Offset = "0x61E84A0", VA = "0x1861E94A0")]
	public void LKNIIEHHNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61EA3E0", Offset = "0x61E93E0", VA = "0x1861EA3E0")]
	public static DBPKKLOFMEL OOGKEDOOOJC(Allocator NHBLMPKODCH, ILLGHIEDDJL EDDEBFFFHAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x61EA010", Offset = "0x61E9010", VA = "0x1861EA010")]
	public static DBPKKLOFMEL OOGKEDOOOJC(Allocator NHBLMPKODCH, NativeArray<float3> NDOONONLGAD, NativeArray<float3> LNBEEHFODFB, NativeArray<float2> EPGMNDDKLNM, NativeArray<float4> MJHKNNDPDCP, bool KOOHEMNNBAB, NativeArray<float4> FLOKECBGICM, NativeArray<int> IEIEAGNKPEF, int GHLJKICKIPG, int ECKDGDDDJHP, int DAMLJNJLIIO, int BAGPFMFEIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x61E97B0", Offset = "0x61E87B0", VA = "0x1861E97B0")]
	public ILLGHIEDDJL MEOBNPBKPNL(Allocator NHBLMPKODCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x61E8490", Offset = "0x61E7490", VA = "0x1861E8490")]
	public void ELFNDBDDMJA(Mesh KNFCOBLCFKE, bool LBODGJFMOMO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x61E8400", Offset = "0x61E7400", VA = "0x1861E8400")]
	public long EEJIJJGPFII()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x61EA620", Offset = "0x61E9620", VA = "0x1861EA620")]
	private void PIPLOEBEJCF(int MEPPIAGMJGL, int GGOOFHBGFCD, Allocator NHBLMPKODCH, bool MGJKJBGADLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x61E81B0", Offset = "0x61E71B0", VA = "0x1861E81B0")]
	private float3 BCHBLFKAGDN(int MOFOCMDFDOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61E95A0", Offset = "0x61E85A0", VA = "0x1861E95A0")]
	private void LNAPMNCGMDF(int MOFOCMDFDOO, float3 JBNPMHAKLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61E8A50", Offset = "0x61E7A50", VA = "0x1861E8A50")]
	private float3 GGBCHKHIMCN(int MOFOCMDFDOO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x61E9450", Offset = "0x61E8450", VA = "0x1861E9450")]
	private void LJBOMIPMFPA(int MOFOCMDFDOO, float3 JBNPMHAKLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61E9FA0", Offset = "0x61E8FA0", VA = "0x1861E9FA0")]
	private float4 OLLJGBCFPDG(int MOFOCMDFDOO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61EA7D0", Offset = "0x61E97D0", VA = "0x1861EA7D0")]
	private void PPEHGKHPHAN(int MOFOCMDFDOO, float4 JBNPMHAKLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61E9750", Offset = "0x61E8750", VA = "0x1861E9750")]
	private float2 MAENJEFPIGE(int MOFOCMDFDOO)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61E8EA0", Offset = "0x61E7EA0", VA = "0x1861E8EA0")]
	private void IEKKDFHBAMK(int MOFOCMDFDOO, float2 JBNPMHAKLEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61E8C10", Offset = "0x61E7C10", VA = "0x1861E8C10")]
	private void IDHNJFBJEGM(NativeArray<float3> NDOONONLGAD, int BAGPFMFEIEM, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61E8130", Offset = "0x61E7130", VA = "0x1861E8130")]
	private void APHJBAJGPHG(NativeArray<float3> LNBEEHFODFB, int BAGPFMFEIEM, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x61E9080", Offset = "0x61E8080", VA = "0x1861E9080")]
	private void JOCBFHKAEEG(NativeArray<float2> EPGMNDDKLNM, int BAGPFMFEIEM, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x61E8FB0", Offset = "0x61E7FB0", VA = "0x1861E8FB0")]
	private void IGKGLALCCDP(NativeArray<float4> MMGBPGDOCNF, int BAGPFMFEIEM, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x61E8570", Offset = "0x61E7570", VA = "0x1861E8570")]
	private void FPMINCJHMGF(Allocator NHBLMPKODCH, NativeArray<float4> MJHKNNDPDCP, int BAGPFMFEIEM, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x61E8AD0", Offset = "0x61E7AD0", VA = "0x1861E8AD0")]
	private static void HMHIFCPMAKC(NativeArray<float4> FBOPLMPHMKA, NativeArray<JFLDODHBCEG> BDMIPBFNHJB, NativeArray<byte> IKDAACHMEKE, int GHLJKICKIPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x61E8050", Offset = "0x61E7050", VA = "0x1861E8050")]
	private void AADHPHDODNF(Allocator NHBLMPKODCH, NativeArray<int> IEIEAGNKPEF, int BAGPFMFEIEM, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x61E9CD0", Offset = "0x61E8CD0", VA = "0x1861E9CD0")]
	private static NativeArray<byte> OIDBEEPFEAO(Allocator NHBLMPKODCH, NativeArray<int> IEIEAGNKPEF, int HMBKHIICMBE)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x61EA730", Offset = "0x61E9730", VA = "0x1861EA730")]
	private static void PMIFKPFHDPN(NativeArray<int> IOFNLPBMJBE, NativeArray<byte> POJGAAAJHLD, int DAMLJNJLIIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x61E9300", Offset = "0x61E8300", VA = "0x1861E9300")]
	private static float3 KAIHELOPBLP(ushort FBHELOENOAL)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x61E8240", Offset = "0x61E7240", VA = "0x1861E8240")]
	private static ushort CLKBOPGBAJM(float3 JBNPMHAKLEG)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public DBPKKLOFMEL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NJFICNENNHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float2 GGCHNCJELKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float2 KKFGCCACIAL;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public class MHGFKPEKIGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public NativeArray<NJFICNENNHF> EBCKKCHMIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public NativeArray<int> CHEIIIPIIBB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int ADFEHFHJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1E0", Offset = "0x7BC1E0", VA = "0x1807BD1E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OOGFDFNGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BD950", Offset = "0x7BC950", VA = "0x1807BD950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x61F3930", Offset = "0x61F2930", VA = "0x1861F3930")]
	public MHGFKPEKIGO(int MEPPIAGMJGL, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x61F38D0", Offset = "0x61F28D0", VA = "0x1861F38D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x61F37F0", Offset = "0x61F27F0", VA = "0x1861F37F0")]
	public void ABKCFCOLBOF(MHGFKPEKIGO HKPHINCIDHI, int GPNHHPICOLN, int BMGBMMPKFAO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class OBDLJPCFCAN
{
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private static MHGFKPEKIGO LMOMDKNGLCD;

	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private static NativeList<NMHMPAHCGIO> NGJFMHGDDME;

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private static int[] OJCKDDHDKPL;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private static bool CODHMBCIFDL;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private static Dictionary<int, MHGFKPEKIGO> PAPDJLKCFDH;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private static Dictionary<int, MHGFKPEKIGO> AAMNJLGNBNE;

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static bool BJIEKPBDKGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x61F58E0", Offset = "0x61F48E0", VA = "0x1861F58E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NativeList<NMHMPAHCGIO> EIFHHIMIMMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x61F5400", Offset = "0x61F4400", VA = "0x1861F5400")]
		get
		{
			return default(NativeList<NMHMPAHCGIO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public static MHGFKPEKIGO NEDNMCPMMMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x61F5770", Offset = "0x61F4770", VA = "0x1861F5770")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x61F5A00", Offset = "0x61F4A00", VA = "0x1861F5A00")]
	private static void OICGNKKHHML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x61F5730", Offset = "0x61F4730", VA = "0x1861F5730")]
	public static int LEHGLGFBFLH(bool LMGBLJOLJJJ, int EICMBIELINJ, bool HLHJCAKPGHH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x61F5810", Offset = "0x61F4810", VA = "0x1861F5810")]
	private static int LPAOBCENDMI(int EICMBIELINJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x61F5960", Offset = "0x61F4960", VA = "0x1861F5960")]
	private static int NFFLGPIMKAH(int EICMBIELINJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x61F5830", Offset = "0x61F4830", VA = "0x1861F5830")]
	public static int LPCIDFBADOF(int KGJOIPMBPNF, int EICMBIELINJ, int CMCDIPIKBOJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x61F5970", Offset = "0x61F4970", VA = "0x1861F5970")]
	public static int NMHMNPFHDBI(int KGJOIPMBPNF, int EICMBIELINJ, int CMCDIPIKBOJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x61F5760", Offset = "0x61F4760", VA = "0x1861F5760")]
	public static int LEKDCFNFCMJ(int CMCDIPIKBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x61F5380", Offset = "0x61F4380", VA = "0x1861F5380")]
	private static int IGJOKMCMFOH(int EICMBIELINJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x61F4EC0", Offset = "0x61F3EC0", VA = "0x1861F4EC0")]
	private static int DADMGJLLJMK(int EICMBIELINJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x61F5390", Offset = "0x61F4390", VA = "0x1861F5390")]
	public static int ILJDMIAPFBD(int KGJOIPMBPNF, int EICMBIELINJ, int CMCDIPIKBOJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x61F52F0", Offset = "0x61F42F0", VA = "0x1861F52F0")]
	public static int HKHBINOBAED(int KGJOIPMBPNF, int EICMBIELINJ, int CMCDIPIKBOJ, bool DMBJMHCKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x61F58C0", Offset = "0x61F48C0", VA = "0x1861F58C0")]
	public static int MICGAJIGPGJ(int CMCDIPIKBOJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x61F6010", Offset = "0x61F5010", VA = "0x1861F6010")]
	public static MHGFKPEKIGO OOPKKFCMGBP(int EICMBIELINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x61F54A0", Offset = "0x61F44A0", VA = "0x1861F54A0")]
	private static MHGFKPEKIGO JCPPBLPBKCG(int EICMBIELINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x61F4A90", Offset = "0x61F3A90", VA = "0x1861F4A90")]
	public static MHGFKPEKIGO CHILODNMIIG(int EICMBIELINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x61F4B80", Offset = "0x61F3B80", VA = "0x1861F4B80")]
	private static MHGFKPEKIGO CMHBCIIJBDK(int EICMBIELINJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x61F4EE0", Offset = "0x61F3EE0", VA = "0x1861F4EE0")]
	public static void DAKOGHLMLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct MFJBDEBGKPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public int DJONOLALJPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public float3 GPLEANGFGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public quaternion OBPBIIGKHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	public float ONMPGGAGINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	public float MPGNFKLMBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	public int LEOHDFJHIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	public int LFFGDKFENIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	public int BHBLHJDODBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public bool BFMECEEMOAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public bool NBGJLBEDJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public float PNNPMJEJCOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public float3 CHKKKJAFDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public bool POKKMDLOOPH;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct MOCNMJJAIHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public int GDKMAIIFLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public int APKKPCKBLID;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HKJBMNMPNFI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public NativeList<MFJBDEBGKPA> EHGKBGNLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public NativeArray<JNHEEHKCAPD> POGLEKKGAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeArray<NMHMPAHCGIO> MLLOHADEAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeArray<MOCNMJJAIHB> FHEODCFEFLH;

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x61EF300", Offset = "0x61EE300", VA = "0x1861EF300")]
	public HKJBMNMPNFI(NativeArray<JNHEEHKCAPD> POGLEKKGAME, int BEELDCKKFJL = 1, Allocator NHBLMPKODCH = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x61EF210", Offset = "0x61EE210", VA = "0x1861EF210", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct PMMMKCHJMHC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeArray<NJFICNENNHF> JJHBCGIAEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<int> JPGKIAIMFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<NMHMPAHCGIO> EHBIGKHNBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeList<MFJBDEBGKPA> EHGKBGNLBCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<JNHEEHKCAPD> POGLEKKGAME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<NMHMPAHCGIO> MLLOHADEAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	public NativeArray<MOCNMJJAIHB> FHEODCFEFLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private int DMCJLIBDMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private int EMEELDFJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private float3 JOEEMPNDCHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private quaternion JNPJPGFDNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private float3 DAINBPGNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PGMGCJCPDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BAGLKJNAFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DNIKEIGFMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LMHAJBAAPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EBNOAFOBHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NAOLKCFDBDD;

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x61FD0D0", Offset = "0x61FC0D0", VA = "0x1861FD0D0")]
	public PMMMKCHJMHC(EBBKGFJOELG DPCJFDCBIDB, ILLGHIEDDJL IIKPDDLOOOA, float3 FBJLIAKAGOJ, quaternion FIKHPLEOLLC, float MBIAABHCHPE, int ILEKHLHDBNI = 0, int GMFMFIHOFCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x61FD360", Offset = "0x61FC360", VA = "0x1861FD360")]
	public PMMMKCHJMHC(HKJBMNMPNFI DPCJFDCBIDB, ILLGHIEDDJL IIKPDDLOOOA, float3 FBJLIAKAGOJ, quaternion FIKHPLEOLLC, float3 MBIAABHCHPE, int ILEKHLHDBNI = 0, int GMFMFIHOFCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x61FCB30", Offset = "0x61FBB30", VA = "0x1861FCB30")]
	private float3 NPJBEELOMDC(float3 FNMOIJJBBLD, Matrix4x4 ONJEFCINJLP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x61FCAB0", Offset = "0x61FBAB0", VA = "0x1861FCAB0")]
	private float3x3 MMLBMEGENKB(float3x3 HBNDLJIGPCB, float3x3 INEAGIHHNPG)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x61FCC60", Offset = "0x61FBC60", VA = "0x1861FCC60")]
	private float OHPJDOKLJKJ(float LIDGFFGHMOF, float JDGIOKOINIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x61FB910", Offset = "0x61FA910", VA = "0x1861FB910", Slot = "4")]
	public void Execute(int HCGAIOKHKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x61FB7A0", Offset = "0x61FA7A0", VA = "0x1861FB7A0")]
	private void BKFIKCPGACP(int DGPNFAHNDHJ, float3 PKDBIHBDKOO, float3 JEPJKJIDLAI, float3 EOJHOKHGBAN, float ELLOHCJLFKF, bool MKDCFNNBPGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x61FCC70", Offset = "0x61FBC70", VA = "0x1861FCC70")]
	private void POBAFHKJKPM(MFJBDEBGKPA KAABIBGEHNP, float3 HOOKHPGOOGE, float3x3 HKHEOOJKFBI, float LIDGFFGHMOF, int LNBMMDGCMIL, int GMJLDAKEBLD, int HJAGPFNPBMG, float FIMAJCHHEIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x61FB150", Offset = "0x61FA150", VA = "0x1861FB150")]
	private void AKPABDHJGCI(int DGPNFAHNDHJ, int DCJNJNMIAME, MFJBDEBGKPA KAABIBGEHNP, float3 HOOKHPGOOGE, float3x3 HKHEOOJKFBI, bool EJMOGKIONMA, float LIDGFFGHMOF, int GAAOGGLDLFI, int EOMHKFJDPMK, int HJAGPFNPBMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct OOJIBMEEMGJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public NativeList<KCBLNHIPIKP> CHPMPMFDPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public NativeList<NMHMPAHCGIO> MHGLDFKBCLN;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x61F6310", Offset = "0x61F5310", VA = "0x1861F6310")]
	public OOJIBMEEMGJ(int BEELDCKKFJL, Allocator NHBLMPKODCH = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x61F6270", Offset = "0x61F5270", VA = "0x1861F6270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
[BurstCompile]
public struct HEJOIPLFHMH : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private enum EALLFBENBFG
	{
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private NativeList<float3> LCBGFENNLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private NativeArray<float3> IPNJCDKIOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	[ReadOnly]
	private NativeList<int> HOFPGMFNGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	[ReadOnly]
	private NativeArray<int> ACCIHLIEAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	[ReadOnly]
	private NativeArray<float4> EIOKNDGOGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	[ReadOnly]
	private NativeArray<float4> IOJLGMDLPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	[ReadOnly]
	private NativeArray<float4> EGCLEOKAMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	[ReadOnly]
	private NativeList<float3> NHDFEODNIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	[ReadOnly]
	private NativeList<NMHMPAHCGIO> JEABAKBGODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	[ReadOnly]
	private NativeList<KCBLNHIPIKP> CHPMPMFDPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	[ReadOnly]
	private NativeList<NMHMPAHCGIO> MHGLDFKBCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	[ReadOnly]
	private int DMCJLIBDMDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	[ReadOnly]
	private int EMEELDFJONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PGMGCJCPDNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BAGLKJNAFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DNIKEIGFMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LMHAJBAAPBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EBNOAFOBHDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NAOLKCFDBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private float3 DAINBPGNJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[ReadOnly]
	private quaternion JNPJPGFDNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private float3 JOEEMPNDCHO;

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x61EEE30", Offset = "0x61EDE30", VA = "0x1861EEE30")]
	public HEJOIPLFHMH(EBBKGFJOELG DPCJFDCBIDB, ILLGHIEDDJL IIKPDDLOOOA, float3 FBJLIAKAGOJ, quaternion FIKHPLEOLLC, float MBIAABHCHPE, int ILEKHLHDBNI = 0, int GMFMFIHOFCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x61EF020", Offset = "0x61EE020", VA = "0x1861EF020")]
	public HEJOIPLFHMH(OOJIBMEEMGJ ELANMAGHLLI, ILLGHIEDDJL IIKPDDLOOOA, float3 FBJLIAKAGOJ, quaternion FIKHPLEOLLC, float3 MBIAABHCHPE, int ILEKHLHDBNI = 0, int GMFMFIHOFCC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x61EDA60", Offset = "0x61ECA60", VA = "0x1861EDA60", Slot = "4")]
	public void Execute(int HCGAIOKHKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x61EEA80", Offset = "0x61EDA80", VA = "0x1861EEA80")]
	private void MABPPFJBAPK(float4x4 JBOIFBACHCP, int HCGAIOKHKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x61EEA10", Offset = "0x61EDA10", VA = "0x1861EEA10")]
	private EALLFBENBFG LIENLGMNHFF(float3 JEPJKJIDLAI)
	{
		return default(EALLFBENBFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x61EE9C0", Offset = "0x61ED9C0", VA = "0x1861EE9C0")]
	private float4 IEIHLCGCMOE(EALLFBENBFG PLGCNBGBGOE, int GCDIELAOHNA)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x61EDA20", Offset = "0x61ECA20", VA = "0x1861EDA20")]
	private float2 ACCOGKMDGJK(EALLFBENBFG PLGCNBGBGOE, float3 PKDBIHBDKOO)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct JGLFBGCNCJM
{
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public enum AIKLILPIMCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		None,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public static JGLFBGCNCJM ECAIHANDNCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public float3 CIKPOOKMMOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public float3x3 KGONPCAJEAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public float3 DAPBPFEGNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public AIKLILPIMCM MJIJAFEKHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public float3 JPOPGOFOOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public float3 CPMJLPIDBIM;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public bool CJEPHDFADJG
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x61F26A0", Offset = "0x61F16A0", VA = "0x1861F26A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float3 NFAKLOBMPGH
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x61F2DE0", Offset = "0x61F1DE0", VA = "0x1861F2DE0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x61F3030", Offset = "0x61F2030", VA = "0x1861F3030")]
	public JGLFBGCNCJM(float3 PKDBIHBDKOO, quaternion GOAHENPPMCD, float3 BEELDCKKFJL, AIKLILPIMCM IKHOLAJCJOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61F2AF0", Offset = "0x61F1AF0", VA = "0x1861F2AF0")]
	public float LGIMJDJGAPN(float3 HOOKHPGOOGE, float KBCDEIIINLH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61F2CF0", Offset = "0x61F1CF0", VA = "0x1861F2CF0")]
	public bool LOPEFEIMGPA(float3 JEPJKJIDLAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61F2940", Offset = "0x61F1940", VA = "0x1861F2940")]
	public void ENFKPNKHNGB(float3 INJHGDLNPDK, float3x3 GHPFFJCHAND, float AENPPJLJBKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x61F2EC0", Offset = "0x61F1EC0", VA = "0x1861F2EC0")]
	private void PMIGPFMNPNI(float3 HLCDMCNCOBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x61F26B0", Offset = "0x61F16B0", VA = "0x1861F26B0")]
	public void DMOIIBKCKPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct NOLEIMGBONF : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	[ReadOnly]
	private NativeList<JGLFBGCNCJM> ELANMAGHLLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[ReadOnly]
	private NativeList<float3> KOJLGFPPMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	[ReadOnly]
	private NativeList<int> OGOAEKOLFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MKEADLJOAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeList<NMHMPAHCGIO> MHGLDFKBCLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int EOBDMFJEPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int IOBHJBNCMIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	[ReadOnly]
	private float KBCDEIIINLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	[ReadOnly]
	private float CCAAIPGHIMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JGHACOMCMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> EGANGDIHAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> CGCBLMKGFKF;

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x61F4490", Offset = "0x61F3490", VA = "0x1861F4490")]
	public NOLEIMGBONF(ILLGHIEDDJL KNFCOBLCFKE, float OHKAFFBGDLL, int BMGBMMPKFAO, int LNBMMDGCMIL, NativeList<JGLFBGCNCJM> ELANMAGHLLI, NativeArray<int> MKEADLJOAOM, NativeList<NMHMPAHCGIO> MHGLDFKBCLN, KADAFFIFJBM EFCBCDDPPEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x61F3AB0", Offset = "0x61F2AB0", VA = "0x1861F3AB0", Slot = "4")]
	public void Execute(int OIJDPFCFCOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x61F39F0", Offset = "0x61F29F0", VA = "0x1861F39F0")]
	private bool DAMKGMGFHAK(JGLFBGCNCJM ABLMDKMDGNE, JGLFBGCNCJM AMHEHNHOGFM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x61F41F0", Offset = "0x61F31F0", VA = "0x1861F41F0")]
	private bool LGKJKDPNDLJ(JGLFBGCNCJM MCPFEGADMJJ, int GJJMBHAMBED, int AFBHHBLGBHJ, int CBEDKENCKLN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KADAFFIFJBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public NativeArray<bool> DNPLFKIHPLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeArray<int> DAMKPMDMHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<bool> OFEOAGDBCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float> GPMMHLFDMIK;

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x61F36F0", Offset = "0x61F26F0", VA = "0x1861F36F0")]
	public void PIPLOEBEJCF(int MEPPIAGMJGL, int GGOOFHBGFCD, Allocator NHBLMPKODCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x61F35E0", Offset = "0x61F25E0", VA = "0x1861F35E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61F3600", Offset = "0x61F2600", VA = "0x1861F3600")]
	public void LKNIIEHHNJO(JobHandle LBMFCHLMCNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public KADAFFIFJBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
[BurstCompile]
public struct JHOBLNCAHJB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private NativeList<float3> KOJLGFPPMEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private NativeArray<float3> BLGGIMHPMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private NativeArray<float4> KNKGHCILLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private NativeArray<float2> PDLDLBFEGHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private NativeList<int> OGOAEKOLFBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CAFFOCBNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private NativeArray<int> IOOPBGKKDMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	[ReadOnly]
	private NativeArray<bool> JGHACOMCMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	[ReadOnly]
	private NativeArray<bool> EGANGDIHAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	[ReadOnly]
	private int ILEKHLHDBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private int GMFMFIHOFCC;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x61F3560", Offset = "0x61F2560", VA = "0x1861F3560")]
	public JHOBLNCAHJB(ILLGHIEDDJL KNFCOBLCFKE, KADAFFIFJBM EFCBCDDPPEK, int GMFMFIHOFCC = 0, int ILEKHLHDBNI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x61F3180", Offset = "0x61F2180", VA = "0x1861F3180", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x61F3120", Offset = "0x61F2120", VA = "0x1861F3120")]
	private void AOGFOGLGMMN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HBLNEBCOPDG
{
	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x279E590", Offset = "0x279D590", VA = "0x18279E590")]
	public static bool BNNFEDKOBCB<T>(NativeArray<T> IJPOMPNGBEF, int BEELDCKKFJL, Allocator NHBLMPKODCH, NativeArrayOptions KJMCMIAJLKH = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x279E6D0", Offset = "0x279D6D0", VA = "0x18279E6D0")]
	public static bool BNNFEDKOBCB<T>(NativeList<T> JOAHCODCDPO, int BEELDCKKFJL, Allocator NHBLMPKODCH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum EMADKOPKDJC
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public interface OOFECPDBKGN
{
	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int LHEDBDMIEBM(EMADKOPKDJC KGJOIPMBPNF);

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int NBOHJFNDKAK(EMADKOPKDJC KGJOIPMBPNF);

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FEPAFKKMDBM();

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INGEMEJCEJO(EMADKOPKDJC KGJOIPMBPNF, EBBKGFJOELG FBNFGJHAPHO, int IHAHJPNIMKF = -1);
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ILLGHIEDDJL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public const int ACIPCCCIKAN = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public NativeList<float3> ODNFEMHJNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	public NativeArray<float3> PHPFBPKLHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	public NativeArray<float4> LIOFCPHCGKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	public NativeArray<float4> CKAJKHPPLEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	public NativeArray<float2> EABEKEAANMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	public NativeList<int> MNDCADAHKBF;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public bool EKAOBJEABNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x61F0010", Offset = "0x61EF010", VA = "0x1861F0010")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int ADFEHFHJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x61EFF90", Offset = "0x61EEF90", VA = "0x1861EFF90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int OOGFDFNGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x61F00B0", Offset = "0x61EF0B0", VA = "0x1861F00B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public bool EJICKBJHOPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x61EFFD0", Offset = "0x61EEFD0", VA = "0x1861EFFD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61EFD90", Offset = "0x61EED90", VA = "0x1861EFD90", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61F0720", Offset = "0x61EF720", VA = "0x1861F0720")]
	public void PIPLOEBEJCF(int MEPPIAGMJGL, int GGOOFHBGFCD, Allocator NHBLMPKODCH, bool PODIOOOCCFP, bool MGJKJBGADLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61EF930", Offset = "0x61EE930", VA = "0x1861EF930")]
	public void CHLNFPCMIHE(int MEPPIAGMJGL, int GGOOFHBGFCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61EF9B0", Offset = "0x61EE9B0", VA = "0x1861EF9B0", Slot = "6")]
	public bool DPDHEFFCKNE(Mesh KNFCOBLCFKE, bool LBODGJFMOMO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61F00F0", Offset = "0x61EF0F0", VA = "0x1861F00F0")]
	public bool OPCDANJIPCO(Mesh KNFCOBLCFKE, ILLGHIEDDJL ODGKPEGOKGN, bool LBODGJFMOMO = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x61EF580", Offset = "0x61EE580", VA = "0x1861EF580")]
	public void ABKCFCOLBOF(ILLGHIEDDJL KNFCOBLCFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x61EF7F0", Offset = "0x61EE7F0", VA = "0x1861EF7F0")]
	public ILLGHIEDDJL BIOIGMPKCPM(Allocator NHBLMPKODCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x61EFEA0", Offset = "0x61EEEA0", VA = "0x1861EFEA0")]
	public long EEJIJJGPFII()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x61F0050", Offset = "0x61EF050", VA = "0x1861F0050")]
	public void KJDDAMPIKLC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
	public ILLGHIEDDJL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public static class IKIEFLPMOKB
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x61EF430", Offset = "0x61EE430", VA = "0x1861EF430")]
	public static void DAKOGHLMLGP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class DKAFNDHEAFO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	public NativeList<float3> ODNFEMHJNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	public NativeArray<float3> PHPFBPKLHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeArray<int> EIEJKMCKPPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeArray<float4> DEHMCLCNPAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	public NativeArray<float4> PJDOOLLPLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	public NativeArray<float4> IOEDLOGJLLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	public NativeList<float3> AKPDFCIGCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	public NativeList<int> MNDCADAHKBF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int ADFEHFHJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x61EAC60", Offset = "0x61E9C60", VA = "0x1861EAC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OOGFDFNGHHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x61EB6F0", Offset = "0x61EA6F0", VA = "0x1861EB6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int AANDAAOOJOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x61EB130", Offset = "0x61EA130", VA = "0x1861EB130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x61EBA20", Offset = "0x61EAA20", VA = "0x1861EBA20")]
	public DKAFNDHEAFO(int MEPPIAGMJGL, int GGOOFHBGFCD, int OHLIHKBHBJC, Allocator NHBLMPKODCH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x61EB730", Offset = "0x61EA730", VA = "0x1861EB730")]
	public DKAFNDHEAFO(Mesh KNFCOBLCFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x61EAB50", Offset = "0x61E9B50", VA = "0x1861EAB50", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x61EA850", Offset = "0x61E9850", VA = "0x1861EA850")]
	public void ABKCFCOLBOF(DKAFNDHEAFO KNFCOBLCFKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x61EACA0", Offset = "0x61E9CA0", VA = "0x1861EACA0")]
	private void IFFOBAAHHCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x61EB170", Offset = "0x61EA170", VA = "0x1861EB170")]
	private void NBNBICLAAIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct NMHMPAHCGIO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	public int KKIDMGADBPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	public int ADFEHFHJPPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	public int MJCJNBMIKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	public int OOGFDFNGHHK;

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x122F7F0", Offset = "0x122E7F0", VA = "0x18122F7F0")]
	public NMHMPAHCGIO(int LNBMMDGCMIL, int GHLJKICKIPG, int BMGBMMPKFAO, int DAMLJNJLIIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class BEHDPGHDLBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public NativeList<NMHMPAHCGIO> MNKKALPHAAL
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x844EC0", Offset = "0x843EC0", VA = "0x180844EC0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<NMHMPAHCGIO>);
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x844ED0", Offset = "0x843ED0", VA = "0x180844ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public DKAFNDHEAFO OFHHAKHOFJD
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1F0", Offset = "0x7BC1F0", VA = "0x1807BD1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x7BD1D0", Offset = "0x7BC1D0", VA = "0x1807BD1D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x61E7A90", Offset = "0x61E6A90", VA = "0x1861E7A90")]
	public BEHDPGHDLBC(IEnumerable<DKAFNDHEAFO> DNOJBLACOPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x61E7A20", Offset = "0x61E6A20", VA = "0x1861E7A20", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum PINBIKOBMLI
{
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class NOMIKLNHJHF
{
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static NativeArray<float2> IMIDPLMLNPH;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static NativeArray<float3> KCEJJBHDDCI;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static NativeArray<float4> BLJGOOMNOMF;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static NativeArray<int> MCLMBFKKNGN;

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x61F4640", Offset = "0x61F3640", VA = "0x1861F4640")]
	public static void DAKOGHLMLGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x61F4760", Offset = "0x61F3760", VA = "0x1861F4760")]
	public static NativeArray<float2> EMBLBLDBCJK(NativeArray<float2> FCJLODDBGHB, int FNMIBNHICMC, NativeArray<float2> HJAOBALEIHB, int CCMLPOLCAGM)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x61F4980", Offset = "0x61F3980", VA = "0x1861F4980")]
	public static NativeArray<float3> NENOKCHGIMM(NativeArray<float3> FCJLODDBGHB, int FNMIBNHICMC, NativeArray<float3> HJAOBALEIHB, int CCMLPOLCAGM)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x61F4870", Offset = "0x61F3870", VA = "0x1861F4870")]
	public static NativeArray<float4> LALHFGPKPCO(NativeArray<float4> FCJLODDBGHB, int FNMIBNHICMC, NativeArray<float4> HJAOBALEIHB, int CCMLPOLCAGM)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x61F4530", Offset = "0x61F3530", VA = "0x1861F4530")]
	public static NativeArray<int> AFIACDFIBOA(NativeArray<int> FCJLODDBGHB, int FNMIBNHICMC, NativeArray<int> HJAOBALEIHB, int CCMLPOLCAGM)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x28FACF0", Offset = "0x28F9CF0", VA = "0x1828FACF0")]
	private static void DBOFMFHCIAO<T>(NativeArray<T> IJPOMPNGBEF, int OIFCNKEDPHE) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x28FAEF0", Offset = "0x28F9EF0", VA = "0x1828FAEF0")]
	private static void NELLJDODGEJ<T>(NativeArray<T> FCJLODDBGHB, int FNMIBNHICMC, NativeArray<T> HJAOBALEIHB, int CCMLPOLCAGM, NativeArray<T> PHLGJHIIFOO) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class OPFNEINBFJA
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	internal enum EONEEHMMBFG
	{
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		Uninitialised,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		ExcludedNoLodNoMesh,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		ExcludedNoLodMeshData,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		ExcludedNoLodMeshDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		NoMesh,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		MeshLod0,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		MeshLod0WantsLod0Refresh,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		MeshLod0WantsRefresh,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		MeshLod0AllLodsInJob,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		MeshAllLods,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		MeshAllLodsWantsLod0Refresh,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		MeshAllLodsWantsRefresh
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class GDPPGOGALJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public DBPKKLOFMEL KNFCOBLCFKE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public int AEHGDOIMNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public int COIBFPLNANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public float BPIGDCCHDEI;

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x61ED9E0", Offset = "0x61EC9E0", VA = "0x1861ED9E0")]
		public GDPPGOGALJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x61ED9A0", Offset = "0x61EC9A0", VA = "0x1861ED9A0")]
		public void LKNIIEHHNJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private readonly List<OOFECPDBKGN> NNECKNPBAIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly CNDMELHGHNJ GEHHCDEBIDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private int GHLJKICKIPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private int DAMLJNJLIIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private bool OIDLGOBEDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	internal bool IDADGBFBIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	internal bool FBECHCLJOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal EONEEHMMBFG NLJIDPFGNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal float3 MCMPFMPOMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	internal float3 PAOCCEAFBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal float FKDKBLAMAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal int JCDIKLELIAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	internal int IMHHDIPHHEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int CALNIPDHCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private float GBGOPMAJDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private float GHGLFMCEDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private int HKPNHFEELJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private long NELFNEEOGED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private long NIKOOOHAEKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private long GDLLHJAIBJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private int MHPNKLNJGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private ILLGHIEDDJL OBDFDCPMIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private int NEMJFILNJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private List<GDPPGOGALJP> DIHABMDBEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	internal float IAIFOHJMLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool ELLEOCENIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private IPHECPCCECM BIPFPFFPAHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private JobHandle FDHEJCEEGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	internal NativeArray<long> APKEFJKCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool LFAAMMGFONE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private JobHandle CIGPMHBBCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private ILLGHIEDDJL BGAHALIJIJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private Transform GJOBHGMGALN;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public Mesh OFHHAKHOFJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7BC220", Offset = "0x7BB220", VA = "0x1807BC220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x7C21C0", Offset = "0x7C11C0", VA = "0x1807C21C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MeshRenderer HIDKOCJGPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x7BD940", Offset = "0x7BC940", VA = "0x1807BD940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int DIOEDCGEHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xA2EDB0", Offset = "0xA2DDB0", VA = "0x180A2EDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public int BJICGEMHBCE
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x7F1BC0", Offset = "0x7F0BC0", VA = "0x1807F1BC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int ADFEHFHJPPB
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x61F7880", Offset = "0x61F6880", VA = "0x1861F7880")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<OOFECPDBKGN> IFOMBAHKACE
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x7BC450", Offset = "0x7BB450", VA = "0x1807BC450")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x61F9770", Offset = "0x61F8770", VA = "0x1861F9770")]
	public void MBLNDNLFDFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x61F6E00", Offset = "0x61F5E00", VA = "0x1861F6E00")]
	public void BHNAIALILGF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x61FAE80", Offset = "0x61F9E80", VA = "0x1861FAE80")]
	public void PDKGJHFBNDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x61FAF60", Offset = "0x61F9F60", VA = "0x1861FAF60")]
	public OPFNEINBFJA(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x61F8E40", Offset = "0x61F7E40", VA = "0x1861F8E40")]
	public void LKNIIEHHNJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x61F7600", Offset = "0x61F6600", VA = "0x1861F7600")]
	public void EPKDFJHEJPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x61F70E0", Offset = "0x61F60E0", VA = "0x1861F70E0")]
	public void DGHBOGHGMNM(OOFECPDBKGN LIKPMCELFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x61FA740", Offset = "0x61F9740", VA = "0x1861FA740")]
	private void OEDGCFEGKLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x61F6EE0", Offset = "0x61F5EE0", VA = "0x1861F6EE0")]
	public bool CFOJONIGDEN(OOFECPDBKGN LIKPMCELFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x61FA6E0", Offset = "0x61F96E0", VA = "0x1861FA6E0")]
	public bool NNJMGGGBMOM(OOFECPDBKGN LIKPMCELFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x61F8310", Offset = "0x61F7310", VA = "0x1861F8310", Slot = "4")]
	public virtual void GNIGODFIGFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x61F6CE0", Offset = "0x61F5CE0", VA = "0x1861F6CE0")]
	public void AOCFNODOGKK(Transform BMMHPEJKFOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x61F6400", Offset = "0x61F5400", VA = "0x1861F6400")]
	public bool AFGCBNDHKNE(Transform BMMHPEJKFOM, [Out] bool NNLJLILPKIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x61F9780", Offset = "0x61F8780", VA = "0x1861F9780")]
	public bool MGGJDBAFBNF(bool NAKKHEJJJFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x61F8470", Offset = "0x61F7470", VA = "0x1861F8470")]
	public void HHIDOHAEEAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x61F6D50", Offset = "0x61F5D50", VA = "0x1861F6D50")]
	public bool APCAGDNCGGG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x61F8F10", Offset = "0x61F7F10", VA = "0x1861F8F10")]
	public bool LLFACLKALIM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x61F82D0", Offset = "0x61F72D0", VA = "0x1861F82D0")]
	public bool GNIEJPGDCFN(Transform NJKBLELAEGN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x61F6C30", Offset = "0x61F5C30", VA = "0x1861F6C30")]
	public void AGLHOLNJMFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x61FA630", Offset = "0x61F9630", VA = "0x1861FA630")]
	public bool NJOAHIEMEFD(bool NAKKHEJJJFJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x61F8DC0", Offset = "0x61F7DC0", VA = "0x1861F8DC0")]
	public void LFGECHEANLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x61F80C0", Offset = "0x61F70C0", VA = "0x1861F80C0")]
	public void GHDJPBOJNEF(ILLGHIEDDJL KNFCOBLCFKE, int NODPBIBHBHK, float KIBFCFOPGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x61F8090", Offset = "0x61F7090", VA = "0x1861F8090")]
	public void FNCPFGGCAHJ(DBPKKLOFMEL AOGFIDPKLIN, int NODPBIBHBHK, float KIBFCFOPGPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x61F75F0", Offset = "0x61F65F0", VA = "0x1861F75F0")]
	public long EEJIJJGPFII()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7C0010", Offset = "0x7BF010", VA = "0x1807C0010")]
	public long NANMPHGIBCL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x61F8500", Offset = "0x61F7500", VA = "0x1861F8500")]
	public void HMLJCEMGADA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0xA887F0", Offset = "0xA877F0", VA = "0x180A887F0")]
	internal void OOGOMMIPMGP(EONEEHMMBFG LNHCJLJLFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x61F6F90", Offset = "0x61F5F90", VA = "0x1861F6F90")]
	private void CFPIBOANDNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x61F8800", Offset = "0x61F7800", VA = "0x1861F8800")]
	private float LALOEAJFOIO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x61FA9B0", Offset = "0x61F99B0", VA = "0x1861FA9B0")]
	public void OKKAILBAFAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x61F8440", Offset = "0x61F7440", VA = "0x1861F8440")]
	private void HAPPCJBJIOJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x61F80F0", Offset = "0x61F70F0", VA = "0x1861F80F0")]
	private void GMPKOKNJPBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x61F71C0", Offset = "0x61F61C0", VA = "0x1861F71C0")]
	private void EBAOHBEAHMC(ILLGHIEDDJL BFOGNACKFOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x61F7650", Offset = "0x61F6650", VA = "0x1861F7650")]
	private void EPMLIGBFHPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x61F78A0", Offset = "0x61F68A0", VA = "0x1861F78A0")]
	private void FGJNMMLOKLN(ILLGHIEDDJL KNFCOBLCFKE, DBPKKLOFMEL AOGFIDPKLIN, int NODPBIBHBHK, float KIBFCFOPGPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal struct IPHECPCCECM : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private struct ONBMJIJMGCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public int MAHAKNPCDGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		public int IINLPABJHFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		public int NEJEJLFEOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public int MDCHBKEGKCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public int KDCLPCACONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int CMLHKNOBLBG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int AEHGDOIMNBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public int COIBFPLNANN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float BPIGDCCHDEI;
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private struct KIHACOMOJDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public NativeArray<float3> ODNFEMHJNOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public NativeArray<float3> PHPFBPKLHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public NativeArray<float4> LIOFCPHCGKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public NativeArray<float4> CKAJKHPPLEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public NativeArray<float2> EABEKEAANMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public NativeArray<int> MNDCADAHKBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public bool KOOHEMNNBAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public int ADFEHFHJPPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public int OOGFDFNGHHK;

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x62030A0", Offset = "0x62020A0", VA = "0x1862030A0")]
		public void PIPLOEBEJCF(int MEPPIAGMJGL, int GGOOFHBGFCD, Allocator NHBLMPKODCH, bool MGJKJBGADLH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6202E50", Offset = "0x6201E50", VA = "0x186202E50")]
		public static KIHACOMOJDC MGFHNKIOOLB(ILLGHIEDDJL KDCCNGJCKFD)
		{
			return default(KIHACOMOJDC);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6202D90", Offset = "0x6201D90", VA = "0x186202D90")]
		public void LKNIIEHHNJO()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private NativeArray<ONBMJIJMGCG> CECBONLJMPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private KIHACOMOJDC EHICFAHHIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private KIHACOMOJDC BFOGNACKFOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private float3 KNPNFKBMCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private float3 PNELJHPMDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* NMMOMCPNNBI;

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x61F2350", Offset = "0x61F1350", VA = "0x1861F2350")]
	public IPHECPCCECM([In] List<OPFNEINBFJA.GDPPGOGALJP> CPHABKJLNDA, [In] ILLGHIEDDJL IBDAEAMOALO, [In] OPFNEINBFJA DLNPPMFADEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x61F2020", Offset = "0x61F1020", VA = "0x1861F2020", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x61F08F0", Offset = "0x61EF8F0", VA = "0x1861F08F0")]
	public void BDNGJFBKPAP(List<OPFNEINBFJA.GDPPGOGALJP> KJKKHJINGLL, [In] OPFNEINBFJA DLNPPMFADEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x61F0D40", Offset = "0x61EFD40", VA = "0x1861F0D40")]
	private bool ECHLGAIOBDI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x61F0BB0", Offset = "0x61EFBB0", VA = "0x1861F0BB0")]
	private DBPKKLOFMEL BOICIGGCGKH(int DNIKPGOLIOM, Allocator NHBLMPKODCH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x61F0D60", Offset = "0x61EFD60", VA = "0x1861F0D60")]
	private void EKGIFENCKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x61F2030", Offset = "0x61F1030", VA = "0x1861F2030")]
	private ONBMJIJMGCG KOLGCBODPNP([In] ONBMJIJMGCG NNPCPJLOPFF, int BACOJHCKCNK, [In] NativeArray<int> OGOAEKOLFBI, [In] NativeArray<bool> EGANGDIHAGG, NativeArray<int> LEGLBFPCDON)
	{
		return default(ONBMJIJMGCG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x61F0C80", Offset = "0x61EFC80", VA = "0x1861F0C80")]
	private static int CKMEHLIMEJG(NativeArray<int> OGOAEKOLFBI, int LEGIBAAJOHC, int CLOGHCPDPGJ, int BJOBMPAILME)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static readonly ProfilerMarker BEPAKCOENDP;

		[Cpp2IlInjected.Token(Token = "0x4000111")]
		private static readonly ProfilerMarker DOFJGNFHPIP;

		[Cpp2IlInjected.Token(Token = "0x4000112")]
		private static readonly ProfilerMarker DFKONNMPGBL;

		[Cpp2IlInjected.Token(Token = "0x4000113")]
		internal const int GFBMMKBHCPO = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		private Dictionary<Material, List<OPFNEINBFJA>> GONGMNNGKJO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		internal List<OPFNEINBFJA> KFMADMNGBFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		private List<MeshRenderer> LKLAAHBPFCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		private bool OFJIIJIINGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private int EHNNHLAAMNL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		private Dictionary<int, float> MOLIFKBMJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		private Dictionary<int, Color> PJPGFKCCHHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<int, Vector4> PADFEDFAIGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<int, Matrix4x4> MMPLNJAFNEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		private OPFNEINBFJA IDAJJLHOIPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private Material DDPAMENPNBK;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public IReadOnlyList<MeshRenderer> FNMJADFIKLH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x7BC1F0", Offset = "0x7BB1F0", VA = "0x1807BC1F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public int BPHOKNIKJKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000D2")]
			[Cpp2IlInjected.Address(RVA = "0x6201790", Offset = "0x6200790", VA = "0x186201790")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x61FED90", Offset = "0x61FDD90", VA = "0x1861FED90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61FDE40", Offset = "0x61FCE40", VA = "0x1861FDE40")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61FD680", Offset = "0x61FC680", VA = "0x1861FD680")]
		public OPFNEINBFJA AddToBatchedMesh(OOFECPDBKGN CHNBNAKGFBO, Material BKIIKPMMAIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6200A30", Offset = "0x61FFA30", VA = "0x186200A30")]
		public void RemoveFromBatchedMesh(OOFECPDBKGN KNFCOBLCFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x61FD720", Offset = "0x61FC720", VA = "0x1861FD720")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6200B70", Offset = "0x61FFB70", VA = "0x186200B70")]
		public void SetMaterialProperty(int FBNIAHAGJBM, Color DDCPEHLFHPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6201000", Offset = "0x6200000", VA = "0x186201000")]
		public void SetMaterialProperty(int FBNIAHAGJBM, float CFJDHAGGAJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6201220", Offset = "0x6200220", VA = "0x186201220")]
		public void SetMaterialProperty(int FBNIAHAGJBM, Vector4 GLCNHOPAEMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6200DA0", Offset = "0x61FFDA0", VA = "0x186200DA0")]
		public void SetMaterialProperty(int FBNIAHAGJBM, Matrix4x4 BCGINAMEBLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61FD850", Offset = "0x61FC850", VA = "0x1861FD850")]
		private void DAGLHFBDFKE(Renderer JFDOOADJAOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61FE400", Offset = "0x61FD400", VA = "0x1861FE400")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x61FED80", Offset = "0x61FDD80", VA = "0x1861FED80")]
		private void NMLKONHMCOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x61FE640", Offset = "0x61FD640", VA = "0x1861FE640")]
		private void MBKONFAHGMD(bool KLPILKHNNHJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x61FE430", Offset = "0x61FD430", VA = "0x1861FE430")]
		private OPFNEINBFJA KFOIFAAIKHE(OOFECPDBKGN KNFCOBLCFKE, Material BKIIKPMMAIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x61FEA40", Offset = "0x61FDA40", VA = "0x1861FEA40")]
		private OPFNEINBFJA MCFNPFFFAFL(Material BKIIKPMMAIB, int OPMNLFFEMFJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x61FE000", Offset = "0x61FD000", VA = "0x1861FE000")]
		private OPFNEINBFJA EMJPFPHHLHH(Material BKIIKPMMAIB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x171F7A0", Offset = "0x171E7A0", VA = "0x18171F7A0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x61FEC20", Offset = "0x61FDC20", VA = "0x1861FEC20")]
		public void MarkDirty(OOFECPDBKGN KNFCOBLCFKE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6200250", Offset = "0x61FF250", VA = "0x186200250")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x61FE410", Offset = "0x61FD410", VA = "0x1861FE410")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x61FF080", Offset = "0x61FE080", VA = "0x1861FF080")]
		public void RebatchOptimally()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6201520", Offset = "0x6200520", VA = "0x186201520")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class HEFEHJKENHF
{
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public static bool NDKMJKJOHGI;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public static Vector3 OBNEHGNJGJA;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static int HAMOFCBNAHJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static int FGLLFHLGIOE;

	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public static int OCPKBDMCICJ;

	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public static int IBKHEAHHKAM;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private static List<BatchedMeshRenderer> OOEDLKNFBDC;

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public static bool EJBDMONJBJF
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6201880", Offset = "0x6200880", VA = "0x186201880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6201A30", Offset = "0x6200A30", VA = "0x186201A30")]
	public static void IPDECBGGCGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x62027E0", Offset = "0x62017E0", VA = "0x1862027E0")]
	public static void MEGILPOJKEF(BatchedMeshRenderer HMMKFHINIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x62017E0", Offset = "0x62007E0", VA = "0x1862017E0")]
	public static void DALFFOIIDKM(BatchedMeshRenderer HMMKFHINIHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6201BC0", Offset = "0x6200BC0", VA = "0x186201BC0")]
	public static void LLFACLKALIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6202A30", Offset = "0x6201A30", VA = "0x186202A30")]
	public static void NKMCMILGKJG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6201940", Offset = "0x6200940", VA = "0x186201940")]
	public static int IBHOKBGPENC()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public class KNIKDDHIOOP<KeyType> : OPFNEINBFJA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private readonly Dictionary<KeyType, OOFECPDBKGN> JBOHJHKDFBD;

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F990", Offset = "0x3C3E990", VA = "0x183C3F990")]
	public KNIKDDHIOOP(string GCMHJLFFDHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F5E0", Offset = "0x3C3E5E0", VA = "0x183C3F5E0")]
	public void DGHBOGHGMNM(KeyType IPAJBJLLPIJ, OOFECPDBKGN LIKPMCELFFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F7D0", Offset = "0x3C3E7D0", VA = "0x183C3F7D0")]
	public bool IDHNLGJGBPK(KeyType IPAJBJLLPIJ, OOFECPDBKGN IFMIDABEEEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F6E0", Offset = "0x3C3E6E0", VA = "0x183C3F6E0")]
	public void FEIJLCNIEDO(KeyType IPAJBJLLPIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F9")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F790", Offset = "0x3C3E790", VA = "0x183C3F790", Slot = "4")]
	public override void GNIGODFIGFB()
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
