using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using RecRoom.Core.Creation.Shapes;
using RecRoom.Logging.Attributes;
using Unity.Burst;
using Unity.Burst.CompilerServices;
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
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
namespace _LogRegistration.RecRoom_NativeMesh_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Preserve]
	[CompilerGenerated]
	public class LogRegistrationIndex : FEPIOKBKKKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6F30AC0", Offset = "0x6F2FAC0", VA = "0x186F30AC0", Slot = "4")]
		public override void EPIGOBOFFNL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8DF890", Offset = "0x8DE890", VA = "0x1808DF890")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class MEBFAMDHEFO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CDBONJBDMGH EDPEHICMPOJ;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly CDBONJBDMGH KOBGFMKEEKI;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly CDBONJBDMGH DJHMJPGFPLA;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class DKHBLCEKHGJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public BPMDFEDMLLG BJCHJIOGDBL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JEFGJPLLPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8B41A0", Offset = "0x8B31A0", VA = "0x1808B41A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public DKHBLCEKHGJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct BPMDFEDMLLG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct EMGDNHCHPMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half CDFGNIFMPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort MJFFBOOOLKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte PLDOEIKFEII;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker GNEAIHIMMEB;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker GEEIFKLKONA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int JEFGJPLLPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int BGPCLMCBMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> CPACEEMNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> HNMDBMDBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> JEAFFHOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> BFACKGMIIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<EMGDNHCHPMP> BGMCNPGNMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> BLMCHLILPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> PKEHEAPGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 GAHPMJGCKOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 PNONNMOLPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 COCJBGNOENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 DJEANKPEOMM;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long CLCGKCKOCIB;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long GKBAFLFLOCN;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float GPBBFBPOILC;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool GLEDDONMGBB;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F19920", Offset = "0x6F18920", VA = "0x186F19920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool KBBIJDPGDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DAE0", Offset = "0x6F1CAE0", VA = "0x186F1DAE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C640", Offset = "0x6F1B640", VA = "0x186F1C640")]
	public void HHBFEMLFOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F18B80", Offset = "0x6F17B80", VA = "0x186F18B80")]
	public static BPMDFEDMLLG AIOPMLNOOEO(Allocator HHJAFJNPHLL, CBBOFCDCFKM GKDGHFCGIBF)
	{
		return default(BPMDFEDMLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F18E50", Offset = "0x6F17E50", VA = "0x186F18E50")]
	public static BPMDFEDMLLG AIOPMLNOOEO(Allocator HHJAFJNPHLL, NativeArray<float3> CODOCLDAHEP, NativeArray<float3> DOMEJMNJCDH, NativeArray<float2> BMIOIHPCHAA, NativeArray<float4> LNGCLGMCBDP, bool KMMBLGPDOCE, NativeArray<float4> CNMLJIHBLKP, NativeArray<int> BFNHMBMNGJB, int JEFGJPLLPLK, int PMIKDNIKHNC, int BGPCLMCBMPG, int MPIIENFKEPL)
	{
		return default(BPMDFEDMLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C310", Offset = "0x6F1B310", VA = "0x186F1C310")]
	public CBBOFCDCFKM HBKJHFKAOCG(Allocator HHJAFJNPHLL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F19960", Offset = "0x6F18960", VA = "0x186F19960")]
	public void APJDMCOLCDJ(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D510", Offset = "0x6F1C510", VA = "0x186F1D510")]
	private void ILGOKHGCMMC(Mesh BKGAJHNMIBN, NativeArray<ushort> OBHKGPFIIMD, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C820", Offset = "0x6F1B820", VA = "0x186F1C820")]
	public void ICIIBJJIJKP(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F21600", Offset = "0x6F20600", VA = "0x186F21600")]
	public void PHLAGHIBFMF(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E8F0", Offset = "0x6F1D8F0", VA = "0x186F1E8F0")]
	public void LJJKLDFEGMA(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F203D0", Offset = "0x6F1F3D0", VA = "0x186F203D0")]
	public void MLLOHACMCMJ(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F900", Offset = "0x6F1E900", VA = "0x186F1F900")]
	public void MDOFCMDEJOJ(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F2C0", Offset = "0x6F1E2C0", VA = "0x186F1F2C0")]
	public void MDLAFBABJKL(Mesh BKGAJHNMIBN, CBBOFCDCFKM.GCMEKIIHHME PKNNBLNOLJP, bool IFGPMIKNBHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6F211A0", Offset = "0x6F201A0", VA = "0x186F211A0")]
	public long PAKBJPIGAGE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E880", Offset = "0x6F1D880", VA = "0x186F1E880")]
	public long LINIOANNODL(CBBOFCDCFKM.GCMEKIIHHME PKNNBLNOLJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6F202A0", Offset = "0x6F1F2A0", VA = "0x186F202A0")]
	private void MHPNOLCFFPN(int PLIBIFGPBLB, int EAANJJKLLEP, Allocator HHJAFJNPHLL, bool JJHIAIDKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6F19B80", Offset = "0x6F18B80", VA = "0x186F19B80")]
	private void BKCFDHCDFPG(NativeArray<float3> OGPHACCKLGC, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6F17240", Offset = "0x6F16240", VA = "0x186F17240")]
	[BurstCompile]
	private unsafe static void BKCFDHCDFPG([NoAlias] float3* OGPHACCKLGC, [In][NoAlias] ushort* CODOCLDAHEP, int JEFGJPLLPLK, [In] float3 GAHPMJGCKOA, [In] float3 PNONNMOLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1F840", Offset = "0x6F1E840", VA = "0x186F1F840")]
	[BurstCompile]
	private unsafe static void MDNKMLJHIJD([NoAlias] CBBOFCDCFKM.GGHPONBJCJP* OGPHACCKLGC, [In][NoAlias] ushort* CODOCLDAHEP, int JEFGJPLLPLK, [In] float3 GAHPMJGCKOA, [In] float3 PNONNMOLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C760", Offset = "0x6F1B760", VA = "0x186F1C760")]
	[BurstCompile]
	private unsafe static void IAKJEOIPLNI([NoAlias] CBBOFCDCFKM.MMJJGJOEMOG* OGPHACCKLGC, [In][NoAlias] ushort* CODOCLDAHEP, int JEFGJPLLPLK, [In] float3 GAHPMJGCKOA, [In] float3 PNONNMOLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A920", Offset = "0x6F19920", VA = "0x186F1A920")]
	[BurstCompile]
	private unsafe static void HOPNBJECOEN([NoAlias] CBBOFCDCFKM.KJBKPAPBEGN* OGPHACCKLGC, [In][NoAlias] ushort* CODOCLDAHEP, int JEFGJPLLPLK, [In] float3 GAHPMJGCKOA, [In] float3 PNONNMOLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A920", Offset = "0x6F19920", VA = "0x186F1A920")]
	[BurstCompile]
	private unsafe static void CFNDJADLOCK([NoAlias] CBBOFCDCFKM.PNACAHPAEEN* OGPHACCKLGC, [In][NoAlias] ushort* CODOCLDAHEP, int JEFGJPLLPLK, [In] float3 GAHPMJGCKOA, [In] float3 PNONNMOLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6F18A20", Offset = "0x6F17A20", VA = "0x186F18A20")]
	[BurstCompile]
	private unsafe static void ABADDGBINFA([NoAlias] CBBOFCDCFKM.EGINBHMMGLG* OGPHACCKLGC, [In][NoAlias] ushort* CODOCLDAHEP, int JEFGJPLLPLK, [In] float3 GAHPMJGCKOA, [In] float3 PNONNMOLPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A9E0", Offset = "0x6F199E0", VA = "0x186F1A9E0")]
	private void CHJFCMLLDLJ(NativeArray<float3> CODOCLDAHEP, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6F174A0", Offset = "0x6F164A0", VA = "0x186F174A0")]
	[BurstCompile]
	private unsafe static void CHJFCMLLDLJ([NoAlias] ushort* OGPHACCKLGC, [Out] float3 ACGMFEJMAEM, [Out] float3 PNONNMOLPBA, [In][NoAlias] float3* CODOCLDAHEP, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6F21260", Offset = "0x6F20260", VA = "0x186F21260")]
	private void PGGGIFLEIPG(NativeArray<float3> DOMEJMNJCDH, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6F21340", Offset = "0x6F20340", VA = "0x186F21340")]
	[BurstCompile]
	private unsafe static void PGGGIFLEIPG([NoAlias] ushort* EPLOCJEOHND, [In][NoAlias] float3* DOMEJMNJCDH, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BAE0", Offset = "0x6F1AAE0", VA = "0x186F1BAE0")]
	private void EOIJOLAMHEJ(NativeArray<float3> FHOBIHHDCKD, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BBA0", Offset = "0x6F1ABA0", VA = "0x186F1BBA0")]
	[BurstCompile]
	private unsafe static void EOIJOLAMHEJ([NoAlias] float3* FHOBIHHDCKD, [In][NoAlias] ushort* DOMEJMNJCDH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E650", Offset = "0x6F1D650", VA = "0x186F1E650")]
	[BurstCompile]
	private unsafe static void KOPPCPINGLI([NoAlias] CBBOFCDCFKM.GGHPONBJCJP* OGPHACCKLGC, [In][NoAlias] ushort* DOMEJMNJCDH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B7E0", Offset = "0x6F1A7E0", VA = "0x186F1B7E0")]
	[BurstCompile]
	private unsafe static void DELDDBEAMBN([NoAlias] CBBOFCDCFKM.MMJJGJOEMOG* OGPHACCKLGC, [In][NoAlias] ushort* DOMEJMNJCDH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B270", Offset = "0x6F1A270", VA = "0x186F1B270")]
	[BurstCompile]
	private unsafe static void COJGMEFJFPO([NoAlias] CBBOFCDCFKM.KJBKPAPBEGN* OGPHACCKLGC, [In][NoAlias] ushort* DOMEJMNJCDH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DCE0", Offset = "0x6F1CCE0", VA = "0x186F1DCE0")]
	[BurstCompile]
	private unsafe static void JJIADINMPDP([NoAlias] CBBOFCDCFKM.PNACAHPAEEN* OGPHACCKLGC, [In][NoAlias] ushort* DOMEJMNJCDH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D740", Offset = "0x6F1C740", VA = "0x186F1D740")]
	[BurstCompile]
	private unsafe static void INGOELCOLMJ([NoAlias] CBBOFCDCFKM.EGINBHMMGLG* OGPHACCKLGC, [In][NoAlias] ushort* DOMEJMNJCDH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DE30", Offset = "0x6F1CE30", VA = "0x186F1DE30")]
	private void JLDMAGDIPMO(NativeArray<float2> BMIOIHPCHAA, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DF20", Offset = "0x6F1CF20", VA = "0x186F1DF20")]
	[BurstCompile]
	private unsafe static void JLDMAGDIPMO([NoAlias] ushort* LGKHAPNOBIH, [Out] float2 EKOBDIHLNJN, [Out] float2 DJEANKPEOMM, [In][NoAlias] float2* BMIOIHPCHAA, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BDA0", Offset = "0x6F1ADA0", VA = "0x186F1BDA0")]
	[BurstCompile]
	private static void FCMNBNFPKON([Out] float2 CNNDANBJNOM, ushort OCLDAFMPLCM, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6F19FD0", Offset = "0x6F18FD0", VA = "0x186F19FD0")]
	private void BOMLDPHCDCL(NativeArray<float2> LGKHAPNOBIH, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6F19EF0", Offset = "0x6F18EF0", VA = "0x186F19EF0")]
	[BurstCompile]
	private unsafe static void BOMLDPHCDCL([NoAlias] float2* LGKHAPNOBIH, [NoAlias] ushort* BMIOIHPCHAA, int JEFGJPLLPLK, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C210", Offset = "0x6F1B210", VA = "0x186F1C210")]
	[BurstCompile]
	private unsafe static void GKOCNFDJGAL([NoAlias] CBBOFCDCFKM.GGHPONBJCJP* OGPHACCKLGC, [NoAlias] ushort* BMIOIHPCHAA, int JEFGJPLLPLK, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6F19A80", Offset = "0x6F18A80", VA = "0x186F19A80")]
	[BurstCompile]
	private unsafe static void BAFNOGJDGIA([NoAlias] CBBOFCDCFKM.MMJJGJOEMOG* OGPHACCKLGC, [NoAlias] ushort* BMIOIHPCHAA, int JEFGJPLLPLK, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A240", Offset = "0x6F19240", VA = "0x186F1A240")]
	[BurstCompile]
	private unsafe static void CDAHMBKJLGK([NoAlias] CBBOFCDCFKM.KJBKPAPBEGN* OGPHACCKLGC, [NoAlias] ushort* BMIOIHPCHAA, int JEFGJPLLPLK, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E550", Offset = "0x6F1D550", VA = "0x186F1E550")]
	[BurstCompile]
	private unsafe static void KLDADPNMJEF([NoAlias] CBBOFCDCFKM.PNACAHPAEEN* OGPHACCKLGC, [NoAlias] ushort* BMIOIHPCHAA, int JEFGJPLLPLK, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A140", Offset = "0x6F19140", VA = "0x186F1A140")]
	[BurstCompile]
	private unsafe static void CAHEPHBEFOC([NoAlias] CBBOFCDCFKM.EGINBHMMGLG* OGPHACCKLGC, [NoAlias] ushort* BMIOIHPCHAA, int JEFGJPLLPLK, [In] float2 COCJBGNOENF, [In] float2 DJEANKPEOMM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6F19770", Offset = "0x6F18770", VA = "0x186F19770")]
	private void ANOKOCJGJCL(NativeArray<float4> CNMLJIHBLKP, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6F19650", Offset = "0x6F18650", VA = "0x186F19650")]
	[BurstCompile]
	private unsafe static void ANOKOCJGJCL([NoAlias] ushort* HCNKNJLGLLE, [In][NoAlias] float4* HALFBJIECOF, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6F20F30", Offset = "0x6F1FF30", VA = "0x186F20F30")]
	[BurstCompile]
	private static ushort OICPGDNLHKC([In] float4 LJOMDOEMJCC)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6F19DC0", Offset = "0x6F18DC0", VA = "0x186F19DC0")]
	private void BLFDPCCJHEO(NativeArray<float4> HCNKNJLGLLE, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6F19C70", Offset = "0x6F18C70", VA = "0x186F19C70")]
	[BurstCompile]
	private unsafe static void BLFDPCCJHEO([NoAlias] float4* HCNKNJLGLLE, [In][NoAlias] ushort* CNMLJIHBLKP, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A610", Offset = "0x6F19610", VA = "0x186F1A610")]
	[BurstCompile]
	private unsafe static void CFLEELPCOCJ([NoAlias] CBBOFCDCFKM.GGHPONBJCJP* OGPHACCKLGC, [In][NoAlias] ushort* CNMLJIHBLKP, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D020", Offset = "0x6F1C020", VA = "0x186F1D020")]
	[BurstCompile]
	private unsafe static void IGBMNEMHPDN([NoAlias] CBBOFCDCFKM.MMJJGJOEMOG* OGPHACCKLGC, [In][NoAlias] ushort* CNMLJIHBLKP, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BFB0", Offset = "0x6F1AFB0", VA = "0x186F1BFB0")]
	[BurstCompile]
	private unsafe static void GAEPHEPPJBH([NoAlias] CBBOFCDCFKM.KJBKPAPBEGN* OGPHACCKLGC, [In][NoAlias] ushort* CNMLJIHBLKP, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E1E0", Offset = "0x6F1D1E0", VA = "0x186F1E1E0")]
	[BurstCompile]
	private unsafe static void JMPFMCMFLEO([NoAlias] CBBOFCDCFKM.PNACAHPAEEN* OGPHACCKLGC, [In][NoAlias] ushort* CNMLJIHBLKP, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6F20D00", Offset = "0x6F1FD00", VA = "0x186F20D00")]
	[BurstCompile]
	private unsafe static void NIBOLJMAKMF([NoAlias] CBBOFCDCFKM.EGINBHMMGLG* OGPHACCKLGC, [In][NoAlias] ushort* CNMLJIHBLKP, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BDF0", Offset = "0x6F1ADF0", VA = "0x186F1BDF0")]
	[BurstCompile]
	private static void FGDLDKBAFFC([Out] float4 POCKBMKNJHC, ushort OCLDAFMPLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AAD0", Offset = "0x6F19AD0", VA = "0x186F1AAD0")]
	private void CMBGACGLHMF(Allocator HHJAFJNPHLL, NativeArray<float4> LNGCLGMCBDP, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6F1AED0", Offset = "0x6F19ED0", VA = "0x186F1AED0")]
	[BurstCompile]
	private unsafe static void CMBGACGLHMF([NoAlias] float4* IMLPPJFILJJ, [NoAlias] byte* OIKOPPBNHPF, [Out] int BNHOCDHOCHH, [Out] int FFAMJICHNCK, [NoAlias] float4* LNGCLGMCBDP, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D330", Offset = "0x6F1C330", VA = "0x186F1D330")]
	private static void IIAPNOJCKKH(NativeArray<float4> MMHBHBKEFJI, NativeArray<EMGDNHCHPMP> EHBFCNMJGLO, NativeArray<byte> NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D1F0", Offset = "0x6F1C1F0", VA = "0x186F1D1F0")]
	[BurstCompile]
	private unsafe static void IIAPNOJCKKH([NoAlias] float4* MMHBHBKEFJI, [In][NoAlias] EMGDNHCHPMP* EHBFCNMJGLO, [In][NoAlias] byte* NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B090", Offset = "0x6F1A090", VA = "0x186F1B090")]
	[BurstCompile]
	private unsafe static void CNMJDJAMPOI([NoAlias] CBBOFCDCFKM.GGHPONBJCJP* OGPHACCKLGC, [In][NoAlias] EMGDNHCHPMP* EHBFCNMJGLO, [In][NoAlias] byte* NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6F20FC0", Offset = "0x6F1FFC0", VA = "0x186F20FC0")]
	[BurstCompile]
	private unsafe static void OMOIALCAFGA([NoAlias] CBBOFCDCFKM.MMJJGJOEMOG* OGPHACCKLGC, [In][NoAlias] EMGDNHCHPMP* EHBFCNMJGLO, [In][NoAlias] byte* NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6F1A430", Offset = "0x6F19430", VA = "0x186F1A430")]
	[BurstCompile]
	private unsafe static void CECHLNBGJEK([NoAlias] CBBOFCDCFKM.KJBKPAPBEGN* OGPHACCKLGC, [In][NoAlias] EMGDNHCHPMP* EHBFCNMJGLO, [In][NoAlias] byte* NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6F19410", Offset = "0x6F18410", VA = "0x186F19410")]
	[BurstCompile]
	private unsafe static void AMDCNILOGMF([NoAlias] CBBOFCDCFKM.PNACAHPAEEN* OGPHACCKLGC, [In][NoAlias] EMGDNHCHPMP* EHBFCNMJGLO, [In][NoAlias] byte* NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6F1D8A0", Offset = "0x6F1C8A0", VA = "0x186F1D8A0")]
	[BurstCompile]
	private unsafe static void IPHHBFOLPME([NoAlias] CBBOFCDCFKM.EGINBHMMGLG* OGPHACCKLGC, [In][NoAlias] EMGDNHCHPMP* EHBFCNMJGLO, [In][NoAlias] byte* NLMMINBGBOA, int JEFGJPLLPLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6F1BEB0", Offset = "0x6F1AEB0", VA = "0x186F1BEB0")]
	private void FNCOIOLMMJL(Allocator HHJAFJNPHLL, NativeArray<int> BFNHMBMNGJB, int MPIIENFKEPL, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B3B0", Offset = "0x6F1A3B0", VA = "0x186F1B3B0")]
	private static NativeArray<byte> CPMKEGIAGDK(Allocator HHJAFJNPHLL, NativeArray<int> BFNHMBMNGJB, int HDHBFCBPHCA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B6E0", Offset = "0x6F1A6E0", VA = "0x186F1B6E0")]
	[BurstCompile]
	private unsafe static int CPMKEGIAGDK([NoAlias] byte* CJPOKDBLKMN, [In][NoAlias] int* BFNHMBMNGJB, int HDHBFCBPHCA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B9C0", Offset = "0x6F1A9C0", VA = "0x186F1B9C0")]
	private static void EMHHNAPAGJN(NativeArray<int> HEMPNFFHMHH, NativeArray<byte> FCKFIAKEGJI, int BGPCLMCBMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6F1B920", Offset = "0x6F1A920", VA = "0x186F1B920")]
	[BurstCompile]
	private unsafe static void EMHHNAPAGJN([NoAlias] int* HEMPNFFHMHH, [In][NoAlias] byte* FCKFIAKEGJI, int BGPCLMCBMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C170", Offset = "0x6F1B170", VA = "0x186F1C170")]
	[BurstCompile]
	private unsafe static void GINJAEBGKIF([NoAlias] ushort* HEMPNFFHMHH, [In][NoAlias] byte* FCKFIAKEGJI, int BGPCLMCBMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1E410", Offset = "0x6F1D410", VA = "0x186F1E410")]
	[BurstCompile]
	private static void KHPCJMCNEEJ([Out] float3 CNNDANBJNOM, ushort OCLDAFMPLCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6F1DB20", Offset = "0x6F1CB20", VA = "0x186F1DB20")]
	[BurstCompile]
	private static ushort JJBPGNOHPJP([In] float3 LJOMDOEMJCC)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class CBBOFCDCFKM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum GCMEKIIHHME
	{
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		FullFloat32,
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		NormTanMatF16,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		NormTanSn8MatF16,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		NormTanSn8UvMatF16,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		PosFixedPoint16NormTanOct8MatUi,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum NAJNJBHCIMF
	{
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		_,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		_VERTEX_FORMAT_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		_VERTEX_FORMAT_POSFIXED16_NORMTANOCT8_MATUINT,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		LAST
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct FDNPMIBKDHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public GCMEKIIHHME PKNNBLNOLJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool LHAGOGBEKAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int LOEFHLHJNAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct OJAGBLOLDMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 PAMMLHPIJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 LCMGGHKGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 JMKLKMFGJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 DJFLFDKIPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 BGMCNPGNMLM;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct GGHPONBJCJP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 PAMMLHPIJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 LCMGGHKGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 JMKLKMFGJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 DJFLFDKIPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 BGMCNPGNMLM;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct MMJJGJOEMOG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 PAMMLHPIJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint LCMGGHKGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint JMKLKMFGJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 DJFLFDKIPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 BGMCNPGNMLM;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct KJBKPAPBEGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 PAMMLHPIJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint LCMGGHKGECO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint JMKLKMFGJMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 DJFLFDKIPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 BGMCNPGNMLM;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct PNACAHPAEEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 PAMMLHPIJIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint PFMFIOIPBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 DJFLFDKIPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint MFFNALKEMBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint OOKLPDDOBLH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct EGINBHMMGLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public DAEEPHJNJLL.KCNOOACFDNA NIJGEHGEMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint PFMFIOIPBFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 DJFLFDKIPOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint MFFNALKEMBI;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] DPANDAGNINF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int GJMDGMCFHJN(float GOCMFEAMGHO);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class PINJECBHBII
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6F31160", Offset = "0x6F30160", VA = "0x186F31160")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6F31580", Offset = "0x6F30580", VA = "0x186F31580")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6F31280", Offset = "0x6F30280", VA = "0x186F31280")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6F31320", Offset = "0x6F30320", VA = "0x186F31320")]
		public static int IJNFOBHJKBL(float GOCMFEAMGHO)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint PKEMLLEEECD([In] float4 DEGBNBIJGGI);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class LOEAJNJKADA
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F30480", Offset = "0x6F2F480", VA = "0x186F30480")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6F30970", Offset = "0x6F2F970", VA = "0x186F30970")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6F305A0", Offset = "0x6F2F5A0", VA = "0x186F305A0")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6F30640", Offset = "0x6F2F640", VA = "0x186F30640")]
		public static uint IJNFOBHJKBL([In] float4 DEGBNBIJGGI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint NOMAOIHPCIA([In] float3 DEGBNBIJGGI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class HNFFMAEPDEC
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C880", Offset = "0x6F2B880", VA = "0x186F2C880")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CCB0", Offset = "0x6F2BCB0", VA = "0x186F2CCB0")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6F2C9A0", Offset = "0x6F2B9A0", VA = "0x186F2C9A0")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CA40", Offset = "0x6F2BA40", VA = "0x186F2CA40")]
		public static uint IJNFOBHJKBL([In] float3 DEGBNBIJGGI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void NFHLKONHFCD([NoAlias] MMJJGJOEMOG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class FBLNODBNLIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6F28810", Offset = "0x6F27810", VA = "0x186F28810")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6F28C00", Offset = "0x6F27C00", VA = "0x186F28C00")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6F28930", Offset = "0x6F27930", VA = "0x186F28930")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F289D0", Offset = "0x6F279D0", VA = "0x186F289D0")]
		public unsafe static void IJNFOBHJKBL([NoAlias] MMJJGJOEMOG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void PKECCKAGOCK([NoAlias] KJBKPAPBEGN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class DHGGMPPGCIJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6F28150", Offset = "0x6F27150", VA = "0x186F28150")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6F28540", Offset = "0x6F27540", VA = "0x186F28540")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6F28270", Offset = "0x6F27270", VA = "0x186F28270")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6F28310", Offset = "0x6F27310", VA = "0x186F28310")]
		public unsafe static void IJNFOBHJKBL([NoAlias] KJBKPAPBEGN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void HEKLLOLMBCP([NoAlias] PNACAHPAEEN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class IDMNCBMNGEL
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CE00", Offset = "0x6F2BE00", VA = "0x186F2CE00")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6F2D3A0", Offset = "0x6F2C3A0", VA = "0x186F2D3A0")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CF20", Offset = "0x6F2BF20", VA = "0x186F2CF20")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6F2CFC0", Offset = "0x6F2BFC0", VA = "0x186F2CFC0")]
		public unsafe static void IJNFOBHJKBL([NoAlias] PNACAHPAEEN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void CAJEIMLIFGL([NoAlias] EGINBHMMGLG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM, [Out] float3 DBGHMHFIPCF, [Out] float3 GPLEDOFNPHB);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class LCAIHGOOEHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr HMIHEFFCNAI;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr IAOJLAOANBN;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6F2FC20", Offset = "0x6F2EC20", VA = "0x186F2FC20")]
		[BurstDiscard]
		private static void ALOCOBLMJKB(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6F30330", Offset = "0x6F2F330", VA = "0x186F30330")]
		private static IntPtr JMPGOBIKLGB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6F2FD40", Offset = "0x6F2ED40", VA = "0x186F2FD40")]
		public static void GAJBMPPEHFL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public static void CPDDJGLEDNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6F2FDE0", Offset = "0x6F2EDE0", VA = "0x186F2FDE0")]
		public unsafe static void IJNFOBHJKBL([NoAlias] EGINBHMMGLG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM, [Out] float3 DBGHMHFIPCF, [Out] float3 GPLEDOFNPHB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int DKMJCJOFCEH = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> GEIPPJCAJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> KEECCJACAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> OCGMBCNBLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> DDJBNFELIDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> KPBBNHCKHNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> ONFLEMEPGMC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] CKCOEDMLNFE;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool PFDOCBGKKAJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static FDNPMIBKDHG[] IJBPHPDIDCC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool DCLLIFLPMLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6F22540", Offset = "0x6F21540", VA = "0x186F22540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IFGEJJCLEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6F240F0", Offset = "0x6F230F0", VA = "0x186F240F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FKEHJJBKFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6F23950", Offset = "0x6F22950", VA = "0x186F23950")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool KBBIJDPGDKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6F25280", Offset = "0x6F24280", VA = "0x186F25280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6F25600", Offset = "0x6F24600", VA = "0x186F25600")]
	public static NAJNJBHCIMF LDCECDGCNLN(GCMEKIIHHME PKNNBLNOLJP)
	{
		return default(NAJNJBHCIMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6F22280", Offset = "0x6F21280", VA = "0x186F22280")]
	public static void AADJNIEKNHK(NAJNJBHCIMF CCHHDNCDELH, Material BIDMCIBAHOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6F237C0", Offset = "0x6F227C0", VA = "0x186F237C0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6F26610", Offset = "0x6F25610", VA = "0x186F26610")]
	public void MHPNOLCFFPN(int PLIBIFGPBLB, int EAANJJKLLEP, Allocator HHJAFJNPHLL, bool AAIANIMLAKM, bool JJHIAIDKKHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6F238D0", Offset = "0x6F228D0", VA = "0x186F238D0")]
	public void EEGCNMNHHIJ(int PLIBIFGPBLB, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6F26800", Offset = "0x6F25800", VA = "0x186F26800", Slot = "6")]
	public bool MJBPKAIKODE(Mesh BKGAJHNMIBN, bool NCGJBDCEOHK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6F22580", Offset = "0x6F21580", VA = "0x186F22580")]
	public bool APJDMCOLCDJ(Mesh BKGAJHNMIBN, bool NCGJBDCEOHK, bool IFGPMIKNBHB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6F27860", Offset = "0x6F26860", VA = "0x186F27860")]
	public bool PNANOEGDKMA(Mesh BKGAJHNMIBN, CBBOFCDCFKM KALLCPCACME, bool NCGJBDCEOHK = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6F24770", Offset = "0x6F23770", VA = "0x186F24770")]
	public void ICIIBJJIJKP(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6F27790", Offset = "0x6F26790", VA = "0x186F27790")]
	[BurstCompile]
	public static int PKEILNBJPKK(float GOCMFEAMGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6F27740", Offset = "0x6F26740", VA = "0x186F27740")]
	[BurstCompile]
	public static uint PKEILNBJPKK([In] float4 DEGBNBIJGGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6F276F0", Offset = "0x6F266F0", VA = "0x186F276F0")]
	[BurstCompile]
	public static uint PKEILNBJPKK([In] float3 DEGBNBIJGGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6F27060", Offset = "0x6F26060", VA = "0x186F27060")]
	public void PHLAGHIBFMF(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6F22EB0", Offset = "0x6F21EB0", VA = "0x186F22EB0")]
	[BurstCompile]
	private unsafe static void CIBIJJLEPHM([NoAlias] MMJJGJOEMOG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6F257B0", Offset = "0x6F247B0", VA = "0x186F257B0")]
	public void LJJKLDFEGMA(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6F277E0", Offset = "0x6F267E0", VA = "0x186F277E0")]
	[BurstCompile]
	private unsafe static void PLJLJLPJFJK([NoAlias] KJBKPAPBEGN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6F26820", Offset = "0x6F25820", VA = "0x186F26820")]
	public void MLLOHACMCMJ(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6F232F0", Offset = "0x6F222F0", VA = "0x186F232F0")]
	[BurstCompile]
	private unsafe static void DBDHNCGGKKE([NoAlias] PNACAHPAEEN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6F25ED0", Offset = "0x6F24ED0", VA = "0x186F25ED0")]
	public void MDOFCMDEJOJ(Mesh BKGAJHNMIBN, bool IFGPMIKNBHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6F24130", Offset = "0x6F23130", VA = "0x186F24130")]
	[BurstCompile]
	private unsafe static void GPOANAILIDL([NoAlias] EGINBHMMGLG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM, [Out] float3 DBGHMHFIPCF, [Out] float3 GPLEDOFNPHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6F25E40", Offset = "0x6F24E40", VA = "0x186F25E40")]
	public void MDLAFBABJKL(Mesh BKGAJHNMIBN, GCMEKIIHHME PKNNBLNOLJP, bool IFGPMIKNBHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6F241B0", Offset = "0x6F231B0", VA = "0x186F241B0")]
	public void HAOGEBCKFIP(CBBOFCDCFKM BKGAJHNMIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6F229F0", Offset = "0x6F219F0", VA = "0x186F229F0")]
	public void BHFMBPKIHCH(CBBOFCDCFKM LNLOCMMGLOB, Allocator HHJAFJNPHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6F26EB0", Offset = "0x6F25EB0", VA = "0x186F26EB0")]
	public long PAKBJPIGAGE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6F27000", Offset = "0x6F26000", VA = "0x186F27000")]
	public static long PAKBJPIGAGE(int NLHMCBIIMOI, int DPDBNAHBJDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6F25710", Offset = "0x6F24710", VA = "0x186F25710")]
	public static long LINIOANNODL(int NLHMCBIIMOI, int DPDBNAHBJDD, GCMEKIIHHME PKNNBLNOLJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6F25650", Offset = "0x6F24650", VA = "0x186F25650")]
	public long LINIOANNODL(GCMEKIIHHME PKNNBLNOLJP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6F24420", Offset = "0x6F23420", VA = "0x186F24420")]
	public void HIKEFGELFJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6F24480", Offset = "0x6F23480", VA = "0x186F24480")]
	public static void IBEKCBCOBGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6F23990", Offset = "0x6F22990", VA = "0x186F23990")]
	public GCMEKIIHHME EPPFMFKJFEE()
	{
		return default(GCMEKIIHHME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6F251B0", Offset = "0x6F241B0", VA = "0x186F251B0")]
	public static (int, int) JAEAMGIJAGK(Mesh BKGAJHNMIBN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6F22AF0", Offset = "0x6F21AF0", VA = "0x186F22AF0")]
	public static int BIHGJKNIEKA(VertexAttributeDescriptor[] NCHJGPFFIHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6F22980", Offset = "0x6F21980", VA = "0x186F22980")]
	public static long BGEPLDBMMDL(Mesh BKGAJHNMIBN, int DCOKMJHMJBP, int ELILJCNCOLD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public CBBOFCDCFKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6F22BD0", Offset = "0x6F21BD0", VA = "0x186F22BD0")]
	[BurstCompile]
	public static int CCMFDFNELGM(float GOCMFEAMGHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6F22C70", Offset = "0x6F21C70", VA = "0x186F22C70")]
	[BurstCompile]
	public static uint CCMFDFNELGM([In] float4 DEGBNBIJGGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6F22E00", Offset = "0x6F21E00", VA = "0x186F22E00")]
	[BurstCompile]
	public static uint CCMFDFNELGM([In] float3 DEGBNBIJGGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6F22F30", Offset = "0x6F21F30", VA = "0x186F22F30")]
	[BurstCompile]
	public unsafe static void CLLAALCEFIE([NoAlias] MMJJGJOEMOG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6F23370", Offset = "0x6F22370", VA = "0x186F23370")]
	[BurstCompile]
	public unsafe static void DLGAACBMHFB([NoAlias] KJBKPAPBEGN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6F22340", Offset = "0x6F21340", VA = "0x186F22340")]
	[BurstCompile]
	public unsafe static void AIDHMGFDANH([NoAlias] PNACAHPAEEN* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6F252C0", Offset = "0x6F242C0", VA = "0x186F252C0")]
	[BurstCompile]
	public unsafe static void LBJMELFFEAB([NoAlias] EGINBHMMGLG* OGPHACCKLGC, int JEFGJPLLPLK, [In][NoAlias] float3* EJBCGLMBPJB, [In][NoAlias] float3* HNMDBMDBKII, [In][NoAlias] float4* JEAFFHOBMJP, [In][NoAlias] float2* BFACKGMIIGP, [In][NoAlias] float4* BGMCNPGNMLM, [Out] float3 DBGHMHFIPCF, [Out] float3 GPLEDOFNPHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct CEGBCMPFNED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int LPONOHJIDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 DCDDCPIOHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion FKIBHLJOAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 BHLHHPCOIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int DBFEFIMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int EBJKJODGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int FHHJNJJLKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float HINBNGILIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 AJFNDBDIEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool JOFHOHHBEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public ANKBGMJMHBE PPHLNOEIDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 AFOLMOICLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float FCILMGEMJIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class FEBLINHAPNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static BFJJPELCOJH AJAFHPPAACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<CEGBCMPFNED> MINIPHDAOLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<MCKOJCONJAL> FHKOJJMIKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<DEDMBFLMLLM> NPMHNEPJDEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<JIGGBHLJOJK> HMFBKKMOOLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<MCKOJCONJAL> ICODEGMGMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<NFCDHDBIIKH> HDHOCDEAKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<JIGGBHLJOJK>> DMNGPEEPMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<MFNMFNDCFHD> OIPAIOCBNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> AOHBNBCAEBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int IFGEJJCLEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC50", Offset = "0xA19C50", VA = "0x180A1AC50")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xA190D0", Offset = "0xA180D0", VA = "0x180A190D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int FKEHJJBKFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xA1AC40", Offset = "0xA19C40", VA = "0x180A1AC40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xA19CC0", Offset = "0xA18CC0", VA = "0x180A19CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AA90", Offset = "0x6F29A90", VA = "0x186F2AA90")]
	public FEBLINHAPNG(int CFEPHKOLFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6F28F70", Offset = "0x6F27F70", VA = "0x186F28F70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6F29130", Offset = "0x6F28130", VA = "0x186F29130")]
	public void HHBFEMLFOFF(JobHandle CGOCMLLNHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6F28D50", Offset = "0x6F27D50", VA = "0x186F28D50")]
	public void AMNCIMKFGBN(CEGBCMPFNED CONAFKKIHKL, MFNMFNDCFHD DCMEFOGMHKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A930", Offset = "0x6F29930", VA = "0x186F2A930")]
	public void OPLCHGGNOAA(DEDMBFLMLLM CONAFKKIHKL, NativeArray<JIGGBHLJOJK> FCJHCFBFEMN, int JEFGJPLLPLK, int BGPCLMCBMPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6F295B0", Offset = "0x6F285B0", VA = "0x186F295B0")]
	public JobHandle NNNKCOJMGJF(CBBOFCDCFKM DJLLFDOGHOH, OIKFHLHECEP KPDDBKCMCAJ, float3 DKCFJCDJLLG, quaternion EDJEGDMKJEA, float AMDNAAJPKIO, bool GPEEAJCGKKL, int BBKJHILFPOI = 0, int HEPPENHFOCE = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6F2A5F0", Offset = "0x6F295F0", VA = "0x186F2A5F0")]
	public static JobHandle OAAALHBGJBL(HGGKAMHMKCH IBIKIBDEGOJ, CBBOFCDCFKM DJLLFDOGHOH, CEGBCMPFNED CONAFKKIHKL, JobHandle CGOCMLLNHDP)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6F29300", Offset = "0x6F28300", VA = "0x186F29300")]
	public static JobHandle KPCHJMADGEN(JADBPNBIHPK IBIKIBDEGOJ, CBBOFCDCFKM DJLLFDOGHOH, DEDMBFLMLLM CONAFKKIHKL, NativeArray<JIGGBHLJOJK> FCJHCFBFEMN, int JEFGJPLLPLK, int BGPCLMCBMPG, JobHandle CGOCMLLNHDP)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EFBLNEIPJGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 NDBPJGICJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 KNMPFOHLFEC;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class AIFHNJOALHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<EFBLNEIPJGN> HEFKEMMMKFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> NAMAJANJANF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int IFGEJJCLEGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8B8390", Offset = "0x8B7390", VA = "0x1808B8390")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int FKEHJJBKFLA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8B6660", Offset = "0x8B5660", VA = "0x1808B6660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6F18960", Offset = "0x6F17960", VA = "0x186F18960")]
	public AIFHNJOALHJ(int PLIBIFGPBLB, int EAANJJKLLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6F18820", Offset = "0x6F17820", VA = "0x186F18820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F18880", Offset = "0x6F17880", VA = "0x186F18880")]
	public void HAOGEBCKFIP(AIFHNJOALHJ JBEGKGNKFNE, int JEHFLHHKIAC, int KECPKLHBJEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class PMBFIBAPMNB
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static AIFHNJOALHJ MGPPFOKMHGH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<MCKOJCONJAL> DFJAPHEIAJO;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] IKBBBBAEPLO;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool JGIIBMHEBEI;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, AIFHNJOALHJ> COHHILDJJHE;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, AIFHNJOALHJ> JINALCGMFBM;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool KMBMGMOFDPK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6F32D60", Offset = "0x6F31D60", VA = "0x186F32D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<MCKOJCONJAL> NKLNHPEMBJO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6F31B30", Offset = "0x6F30B30", VA = "0x186F31B30")]
		get
		{
			return default(NativeList<MCKOJCONJAL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static AIFHNJOALHJ MIDNNCAKODM
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6F31CB0", Offset = "0x6F30CB0", VA = "0x186F31CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6F32260", Offset = "0x6F31260", VA = "0x186F32260")]
	private static void MBKBGOBKIBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6F320F0", Offset = "0x6F310F0", VA = "0x186F320F0")]
	public static int KKGJJIPHJEM(bool ALGCCHNDHGJ, int IBFJKGNEFIN, bool ONMPCOOJMGJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6F32240", Offset = "0x6F31240", VA = "0x186F32240")]
	private static int LJFJGNBAKFO(int IBFJKGNEFIN, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6F32050", Offset = "0x6F31050", VA = "0x186F32050")]
	private static int JILDJBGIBAB(int IBFJKGNEFIN, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6F32060", Offset = "0x6F31060", VA = "0x186F32060")]
	public static int KJGIHHMGBON(int ADNNLIGBFLK, int IBFJKGNEFIN, int PCCEPPMNGNM, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6F321B0", Offset = "0x6F311B0", VA = "0x186F321B0")]
	public static int LHBBCLACJDC(int ADNNLIGBFLK, int IBFJKGNEFIN, int PCCEPPMNGNM, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6F32040", Offset = "0x6F31040", VA = "0x186F32040")]
	public static int ICHOEDNHMEE(int PCCEPPMNGNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6F31B20", Offset = "0x6F30B20", VA = "0x186F31B20")]
	private static int CAEONPMOBAB(int IBFJKGNEFIN, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6F32DE0", Offset = "0x6F31DE0", VA = "0x186F32DE0")]
	private static int PKEIGMFAEAK(int IBFJKGNEFIN, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6F31FD0", Offset = "0x6F30FD0", VA = "0x186F31FD0")]
	public static int HKCGPLAPLEB(int ADNNLIGBFLK, int IBFJKGNEFIN, int PCCEPPMNGNM, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6F32120", Offset = "0x6F31120", VA = "0x186F32120")]
	public static int KNHCGJPKFNC(int ADNNLIGBFLK, int IBFJKGNEFIN, int PCCEPPMNGNM, bool APEEMDIOCHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6F31B00", Offset = "0x6F30B00", VA = "0x186F31B00")]
	public static int BNAMLIEENGH(int PCCEPPMNGNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6F31BC0", Offset = "0x6F30BC0", VA = "0x186F31BC0")]
	public static AIFHNJOALHJ EMICMKIFKPO(int IBFJKGNEFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6F31D40", Offset = "0x6F30D40", VA = "0x186F31D40")]
	private static AIFHNJOALHJ GJPKNINAIBN(int IBFJKGNEFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6F31A10", Offset = "0x6F30A10", VA = "0x186F31A10")]
	public static AIFHNJOALHJ ADILMOOMAKA(int IBFJKGNEFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6F316D0", Offset = "0x6F306D0", VA = "0x186F316D0")]
	private static AIFHNJOALHJ ADFGMOJHNPJ(int IBFJKGNEFIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6F32960", Offset = "0x6F31960", VA = "0x186F32960")]
	public static void NCKFFNLBFPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct DEDMBFLMLLM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int MNAJBBHJOBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 DCDDCPIOHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion FKIBHLJOAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float BHLHHPCOIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float FKMIEGGEKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int DBFEFIMCDNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int EBJKJODGGDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int FHHJNJJLKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool MCJPEEMGALL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool DJIECBHCKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float HINBNGILIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 AJFNDBDIEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool BLBDLJFEHCL;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct NFCDHDBIIKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int DLDKCBIFNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int GFNHECIACGM;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct JADBPNBIHPK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<DEDMBFLMLLM> OMMLDHAGPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<JIGGBHLJOJK> FIKHBDOEMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<MCKOJCONJAL> JPLFKLDDFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<NFCDHDBIIKH> OACBFOLDPIL;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D5E0", Offset = "0x6F2C5E0", VA = "0x186F2D5E0")]
	public JADBPNBIHPK(NativeArray<JIGGBHLJOJK> FIKHBDOEMPO, int MLDINGBBEHA = 1, Allocator HHJAFJNPHLL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D4F0", Offset = "0x6F2C4F0", VA = "0x186F2D4F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct KPHCEHGMEPC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<EFBLNEIPJGN> JIEFPJFLEFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> OFCLKFJALPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<MCKOJCONJAL> PCIADELBOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<DEDMBFLMLLM> OMMLDHAGPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<JIGGBHLJOJK> FIKHBDOEMPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<MCKOJCONJAL> JPLFKLDDFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<NFCDHDBIIKH> OACBFOLDPIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int PBFJALHJAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int GNDMHDELGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 BKBHBIMDNOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion FJNCICPAINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 EHACGOMDHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MBPIFIOIJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OLGKDAPFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HFHAFKNFDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HJKEGCJKFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> AHJLHNPBMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MPGHIIIJOGI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F9A0", Offset = "0x6F2E9A0", VA = "0x186F2F9A0")]
	public KPHCEHGMEPC(FEBLINHAPNG NHJOFLGBLJB, CBBOFCDCFKM LDHBLLKKIFE, float3 GKPPLDBJKCE, quaternion DAGKPHPAEGE, float JCOBGOHLCNA, int BBKJHILFPOI = 0, int HEPPENHFOCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F770", Offset = "0x6F2E770", VA = "0x186F2F770")]
	public KPHCEHGMEPC(JADBPNBIHPK NHJOFLGBLJB, CBBOFCDCFKM LDHBLLKKIFE, float3 GKPPLDBJKCE, quaternion DAGKPHPAEGE, float3 JCOBGOHLCNA, int BBKJHILFPOI = 0, int HEPPENHFOCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6F2D8D0", Offset = "0x6F2C8D0", VA = "0x186F2D8D0")]
	private float3 DMPNCJNAGDD(float3 GMGPAKPNHPO, Matrix4x4 PPLGOCAJBJA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F160", Offset = "0x6F2E160", VA = "0x186F2F160")]
	private float3x3 JEEMKJNCEPO(float3x3 FJFBDAMEGLO, float3x3 DPFOMHCENPB)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F1E0", Offset = "0x6F2E1E0", VA = "0x186F2F1E0")]
	private float LLAOJBKAFEJ(float KBGFEDJHNAE, float LOOJLMAOKEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DB80", Offset = "0x6F2CB80", VA = "0x186F2DB80", Slot = "4")]
	public void Execute(int GGBBONMHPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6F2DA10", Offset = "0x6F2CA10", VA = "0x186F2DA10")]
	private void EOABEHFAAJF(int DKMJHCHKKKD, float3 PAMMLHPIJIB, float3 LCMGGHKGECO, float3 JMKLKMFGJMB, float PEGACPFCNHH, bool NMIBBBJANEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6F2ED20", Offset = "0x6F2DD20", VA = "0x186F2ED20")]
	private void FBJIJPKEKJI(DEDMBFLMLLM DCMOBMBGADG, float3 JADOFHDDGIG, float3x3 APDKCFMECLC, float KBGFEDJHNAE, int IBJAHLOAIIM, int OIDADGFNDMO, int EPDMOLDDCOG, float OABKFLJNDAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6F2F1F0", Offset = "0x6F2E1F0", VA = "0x186F2F1F0")]
	private void MILBONPEAHC(int DKMJHCHKKKD, int DBHBCMIEDOJ, DEDMBFLMLLM DCMOBMBGADG, float3 JADOFHDDGIG, float3x3 APDKCFMECLC, bool NOADCDKLBDH, float KBGFEDJHNAE, int KKFABBLEHPH, int NAAHCGJCACN, int EPDMOLDDCOG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct HGGKAMHMKCH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<CEGBCMPFNED> JBHNLJDLJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<MCKOJCONJAL> CCKEBLPOLFL;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C790", Offset = "0x6F2B790", VA = "0x186F2C790")]
	public HGGKAMHMKCH(int MLDINGBBEHA, Allocator HHJAFJNPHLL = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C6F0", Offset = "0x6F2B6F0", VA = "0x186F2C6F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct GMNNEALALNK : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum KOBHDLANLNI
	{
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		X,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	[ReadOnly]
	private NativeList<float3> FPFCGCAAIGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> OPJAACJMLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> KJAEEFJHPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> FPEFPOPLGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> JFFGCBHMHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> BICKPBCDOIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> HNGKLCAPBJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> LBBGCKJEBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<MCKOJCONJAL> EHLOGFLMEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<CEGBCMPFNED> JBHNLJDLJIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<MCKOJCONJAL> CCKEBLPOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int PBFJALHJAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int GNDMHDELGOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MBPIFIOIJCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OLGKDAPFODJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HFHAFKNFDLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HJKEGCJKFGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> AHJLHNPBMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MPGHIIIJOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 EHACGOMDHCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion FJNCICPAINK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 BKBHBIMDNOO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C220", Offset = "0x6F2B220", VA = "0x186F2C220")]
	public GMNNEALALNK(FEBLINHAPNG NHJOFLGBLJB, CBBOFCDCFKM LDHBLLKKIFE, float3 GKPPLDBJKCE, quaternion DAGKPHPAEGE, float JCOBGOHLCNA, int BBKJHILFPOI = 0, int HEPPENHFOCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C410", Offset = "0x6F2B410", VA = "0x186F2C410")]
	public GMNNEALALNK(HGGKAMHMKCH CONAFKKIHKL, CBBOFCDCFKM LDHBLLKKIFE, float3 GKPPLDBJKCE, quaternion DAGKPHPAEGE, float3 JCOBGOHLCNA, int BBKJHILFPOI = 0, int HEPPENHFOCE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B2E0", Offset = "0x6F2A2E0", VA = "0x186F2B2E0", Slot = "4")]
	public void Execute(int GGBBONMHPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AEC0", Offset = "0x6F29EC0", VA = "0x186F2AEC0")]
	private void CAALHCADMPK(float4x4 GIMDIIGMEDO, int GGBBONMHPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6F2B270", Offset = "0x6F2A270", VA = "0x186F2B270")]
	private KOBHDLANLNI CEFCAPGOAFA(float3 LCMGGHKGECO)
	{
		return default(KOBHDLANLNI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6F2AE70", Offset = "0x6F29E70", VA = "0x186F2AE70")]
	private float4 ADCMFNAHDJD(KOBHDLANLNI DKFKOGKJNKG, int KHAIDMGPIED)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6F2C1E0", Offset = "0x6F2B1E0", VA = "0x186F2C1E0")]
	private float2 FPKDBPKOADK(KOBHDLANLNI DKFKOGKJNKG, float3 PAMMLHPIJIB)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct MFNMFNDCFHD
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum JPIOGIDDJOD
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static MFNMFNDCFHD BOAMOHHEBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 BFENJPJIDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 ILMJFGHLIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 IIJOJMFBBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public JPIOGIDDJOD BFKMCKBKOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 BAJGMANBJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 OFGJMFNBOON;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool MNCIMEONHOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F3B0", Offset = "0x6F3E3B0", VA = "0x186F3F3B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 FAMPJPKNBNK
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6F3F950", Offset = "0x6F3E950", VA = "0x186F3F950")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6F3FA90", Offset = "0x6F3EA90", VA = "0x186F3FA90")]
	public MFNMFNDCFHD(float3 PAMMLHPIJIB, quaternion JKJHCABJJIO, float3 MLDINGBBEHA, JPIOGIDDJOD PFCMGBLCCPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F750", Offset = "0x6F3E750", VA = "0x186F3F750")]
	public float MHALHCPDBLH(float3 JADOFHDDGIG, float PKNKOBLMOGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F3C0", Offset = "0x6F3E3C0", VA = "0x186F3F3C0")]
	public bool HIDGLJPJIAG(float3 LCMGGHKGECO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F5A0", Offset = "0x6F3E5A0", VA = "0x186F3F5A0")]
	public void INCDPLNDMNG(float3 LEGJNAGHDAE, float3x3 IEINLDBMLEH, float JMPAOCMHANI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F4B0", Offset = "0x6F3E4B0", VA = "0x186F3F4B0")]
	private void IBNJOJNLOBA(float3 DCLNJEJCMFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6F3F120", Offset = "0x6F3E120", VA = "0x186F3F120")]
	public void CLOGDBOBOIL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct EMIOAIHBPAE : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<MFNMFNDCFHD> CONAFKKIHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> CPACEEMNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> PKEHEAPGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> AOHBNBCAEBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<MCKOJCONJAL> CCKEBLPOLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int FGMCHLJFLJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int GOLNEIMKANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float PKNKOBLMOGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float HBBPPCACJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MOHPJNEDMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CJGGEOMHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> DIIBDIFNMFG;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D630", Offset = "0x6F3C630", VA = "0x186F3D630")]
	public EMIOAIHBPAE(CBBOFCDCFKM BKGAJHNMIBN, float APDKPHIMOHD, int KECPKLHBJEB, int IBJAHLOAIIM, NativeList<MFNMFNDCFHD> CONAFKKIHKL, NativeArray<int> AOHBNBCAEBH, NativeList<MCKOJCONJAL> CCKEBLPOLFL, OIKFHLHECEP KPDDBKCMCAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CC60", Offset = "0x6F3BC60", VA = "0x186F3CC60", Slot = "4")]
	public void Execute(int HNFGCAHMIMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6F3CBA0", Offset = "0x6F3BBA0", VA = "0x186F3CBA0")]
	private bool DMOECBMANAN(MFNMFNDCFHD LGLGFADDDNK, MFNMFNDCFHD GMGEKOBCPAI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D3A0", Offset = "0x6F3C3A0", VA = "0x186F3D3A0")]
	private bool IDEECNPJECL(MFNMFNDCFHD IGIPDPNPIIO, int FHLCBNIPMKL, int FHKPBEPEDKH, int JCOFOCAJCDJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OIKFHLHECEP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> GGIJBPAJIAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> KFIPALLEMEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> LGKLGNEJHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> IOCEGHEJMIM;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6F40250", Offset = "0x6F3F250", VA = "0x186F40250")]
	public void MHPNOLCFFPN(int PLIBIFGPBLB, int EAANJJKLLEP, Allocator HHJAFJNPHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6F40370", Offset = "0x6F3F370", VA = "0x186F40370")]
	public static long ODKIMKGFNEJ(int PLIBIFGPBLB, int EAANJJKLLEP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6F40070", Offset = "0x6F3F070", VA = "0x186F40070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6F40160", Offset = "0x6F3F160", VA = "0x186F40160")]
	public void HHBFEMLFOFF(JobHandle CGOCMLLNHDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8C2F40", Offset = "0x8C1F40", VA = "0x1808C2F40")]
	public OIKFHLHECEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct PFGFNNJBDFH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> CPACEEMNHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> HNMDBMDBKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> BGMCNPGNMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> BFACKGMIIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> PKEHEAPGHMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JEAFFHOBMJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> ELIDPGMDMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> MOHPJNEDMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> CJGGEOMHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int BBKJHILFPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int HEPPENHFOCE;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6F407D0", Offset = "0x6F3F7D0", VA = "0x186F407D0")]
	public PFGFNNJBDFH(CBBOFCDCFKM BKGAJHNMIBN, OIKFHLHECEP KPDDBKCMCAJ, int HEPPENHFOCE = 0, int BBKJHILFPOI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6F403F0", Offset = "0x6F3F3F0", VA = "0x186F403F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6F40390", Offset = "0x6F3F390", VA = "0x186F40390")]
	private void AACCLMABKMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EBFOJOCBCCB
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2DD4850", Offset = "0x2DD3850", VA = "0x182DD4850")]
	public static bool GLEFAKACDAH<T>(NativeArray<T> CHPMBGHOEJI, int MLDINGBBEHA, Allocator HHJAFJNPHLL, NativeArrayOptions HKFJGLOCDGD = NativeArrayOptions.ClearMemory, int JMAPEKKFECN = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2DD49D0", Offset = "0x2DD39D0", VA = "0x182DD49D0")]
	public static bool GLEFAKACDAH<T>(NativeList<T> AKKGGCHEPCI, int MLDINGBBEHA, Allocator HHJAFJNPHLL) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum DGDJKJOFHLA
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	Force0,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	Force1,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	Force2
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public interface OMIMDAIBEJM
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JDKLENPIPKF(DGDJKJOFHLA ADNNLIGBFLK);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int LHCKAKIPCDA(DGDJKJOFHLA ADNNLIGBFLK);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FBIGAJKHMLB();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float ODNJFCFMFGL();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OPOEMGOKBCI(DGDJKJOFHLA ADNNLIGBFLK, FEBLINHAPNG POCEOANFAHJ, int GPCNCPNJMHG = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class AOOEIDBHHJH
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6F35D70", Offset = "0x6F34D70", VA = "0x186F35D70")]
	public static void NCKFFNLBFPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class MDELDHGFMGC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> GEIPPJCAJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> KEECCJACAHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> LPNHLLFAAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> NALGGMJBOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> GFPKPKACNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> EOIOGBGCGIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> OGELEAJEGMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> ONFLEMEPGMC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int IFGEJJCLEGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E810", Offset = "0x6F3D810", VA = "0x186F3E810")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int FKEHJJBKFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6F3E340", Offset = "0x6F3D340", VA = "0x186F3E340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int FLICODJOBML
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6F3DC80", Offset = "0x6F3CC80", VA = "0x186F3DC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EE50", Offset = "0x6F3DE50", VA = "0x186F3EE50")]
	public MDELDHGFMGC(int PLIBIFGPBLB, int EAANJJKLLEP, int MKOKPEKPKME, Allocator HHJAFJNPHLL = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6F3EB50", Offset = "0x6F3DB50", VA = "0x186F3EB50")]
	public MDELDHGFMGC(Mesh BKGAJHNMIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E230", Offset = "0x6F3D230", VA = "0x186F3E230", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E850", Offset = "0x6F3D850", VA = "0x186F3E850")]
	public void HAOGEBCKFIP(MDELDHGFMGC BKGAJHNMIBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3E380", Offset = "0x6F3D380", VA = "0x186F3E380")]
	private void ENLKPEHODMO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3DCC0", Offset = "0x6F3CCC0", VA = "0x186F3DCC0")]
	private void CPHIICCIGEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct MCKOJCONJAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int ELPJNFPHDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int IFGEJJCLEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int NPFDLEOAFAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int FKEHJJBKFLA;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x198F9E0", Offset = "0x198E9E0", VA = "0x18198F9E0")]
	public MCKOJCONJAL(int IBJAHLOAIIM, int JEFGJPLLPLK, int KECPKLHBJEB, int BGPCLMCBMPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BFJJPELCOJH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<MCKOJCONJAL> CCJLIGINHBF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xB885E0", Offset = "0xB875E0", VA = "0x180B885E0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<MCKOJCONJAL>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xB885D0", Offset = "0xB875D0", VA = "0x180B885D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public MDELDHGFMGC HGCBFKPEGGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8B6620", Offset = "0x8B5620", VA = "0x1808B6620")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8B6670", Offset = "0x8B5670", VA = "0x1808B6670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6F35F30", Offset = "0x6F34F30", VA = "0x186F35F30")]
	public BFJJPELCOJH(IEnumerable<MDELDHGFMGC> JCAENAFKFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6F35EC0", Offset = "0x6F34EC0", VA = "0x186F35EC0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum ANKBGMJMHBE
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class BINDAAOPKKN
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> JLIDNHEFBKO;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> PMJBOEJFMKH;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> ABPANLLOHKP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> NFIGHLOMNFG;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6F367E0", Offset = "0x6F357E0", VA = "0x186F367E0")]
	public static void NCKFFNLBFPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6F364E0", Offset = "0x6F354E0", VA = "0x186F364E0")]
	public static NativeArray<float2> AGDGEOLKHJB(NativeArray<float2> DAAJCIDLCND, int BBANKEKGFFM, NativeArray<float2> JAACIEMODGK, int DLMELEOBCNL)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6F368F0", Offset = "0x6F358F0", VA = "0x186F368F0")]
	public static NativeArray<float3> PCBCKOMKCND(NativeArray<float3> DAAJCIDLCND, int BBANKEKGFFM, NativeArray<float3> JAACIEMODGK, int DLMELEOBCNL)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6F366E0", Offset = "0x6F356E0", VA = "0x186F366E0")]
	public static NativeArray<float4> KMKEEJFKJEO(NativeArray<float4> DAAJCIDLCND, int BBANKEKGFFM, NativeArray<float4> JAACIEMODGK, int DLMELEOBCNL)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6F365E0", Offset = "0x6F355E0", VA = "0x186F365E0")]
	public static NativeArray<int> IEICENBCNGA(NativeArray<int> DAAJCIDLCND, int BBANKEKGFFM, NativeArray<int> JAACIEMODGK, int DLMELEOBCNL)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2D012D0", Offset = "0x2D002D0", VA = "0x182D012D0")]
	private static void ODEJPGNLHHL<T>(NativeArray<T> CHPMBGHOEJI, int HFHBDOJGDIA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2D011F0", Offset = "0x2D001F0", VA = "0x182D011F0")]
	private static void IOJLEEEBDFI<T>(NativeArray<T> DAAJCIDLCND, int BBANKEKGFFM, NativeArray<T> JAACIEMODGK, int DLMELEOBCNL, NativeArray<T> AGBBPPFMHMP) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class DAEEPHJNJLL
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct KCNOOACFDNA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort GOCMFEAMGHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort AEFHGLLPABH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort CCKBGLJDEOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort ADINCPIPEFD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C5C0", Offset = "0x6F3B5C0", VA = "0x186F3C5C0")]
	public static uint FEGBMHIBKPM(float CKNHFFBGHMA)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C5D0", Offset = "0x6F3B5D0", VA = "0x186F3C5D0")]
	public static void JBFAJIDHIDF(float4 BGMCNPGNMLM, float JOFOIFOGOPO, [Out] uint MFFNALKEMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C6E0", Offset = "0x6F3B6E0", VA = "0x186F3C6E0")]
	public static void JBFAJIDHIDF(float4 BGMCNPGNMLM, uint FAENHGJJAAC, [Out] uint MFFNALKEMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C090", Offset = "0x6F3B090", VA = "0x186F3C090")]
	public static void COPHNIEBFHF(float3 LGPCONBDFOB, float3 GNHIFNGIFPE, float4 JNJPEFCIJJG, float2 JEFINEIINOK, float4 BGMCNPGNMLM, [Out] CBBOFCDCFKM.PNACAHPAEEN BDAJCCHLJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C2E0", Offset = "0x6F3B2E0", VA = "0x186F3C2E0")]
	public static void COPHNIEBFHF(float3 LGPCONBDFOB, float3 GNHIFNGIFPE, float4 JNJPEFCIJJG, float2 JEFINEIINOK, float4 BGMCNPGNMLM, [Out] CBBOFCDCFKM.EGINBHMMGLG BDAJCCHLJLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C930", Offset = "0x6F3B930", VA = "0x186F3C930")]
	public static byte KLBDGEIIAIJ(float BJDKOHEGDOK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C980", Offset = "0x6F3B980", VA = "0x186F3C980")]
	public static ushort LGKPOCGOIBM(float BJDKOHEGDOK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C7B0", Offset = "0x6F3B7B0", VA = "0x186F3C7B0")]
	public static uint KBBCKMBANOC(float BJDKOHEGDOK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C540", Offset = "0x6F3B540", VA = "0x186F3C540")]
	public static float2 FCHOPOKIIFM(float2 DEGBNBIJGGI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C7E0", Offset = "0x6F3B7E0", VA = "0x186F3C7E0")]
	public static float2 KCIKECLDCPH(float3 INDEACBIFHB)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6F3C9D0", Offset = "0x6F3B9D0", VA = "0x186F3C9D0")]
	public static void OGEGLIHPOJK(float3 BJDKOHEGDOK, [Out] float3 JBDBNPNLLNM, [Out] uint3 ADINCPIPEFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6F3BF30", Offset = "0x6F3AF30", VA = "0x186F3BF30")]
	public static KCNOOACFDNA CCCBJLCILBI(float3 PAMMLHPIJIB)
	{
		return default(KCNOOACFDNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class MCPMJMGGKAG
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker BODDGBBDODH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float AFGIBIDANII;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void LGKOINLOKNE(bool IEKCCIHMFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6F3D6D0", Offset = "0x6F3C6D0", VA = "0x186F3D6D0")]
	public static void JFFNAIJKKNL(float FJBNPHLKMOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PLOHHPLEFIF
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum GECPLEMDEKC
	{
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		UninitImmediate,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		UninitImmediateInJob,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		UninitAsync,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		NoMeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		NoMeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		MeshNoData,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		MeshNoDataFrozen,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		MeshNoDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		MeshLodData,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		MeshLodDataNaughty,
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		MeshLodDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		MeshLodDataInJob,
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		MeshAllData,
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		MeshAllDataRefresh,
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		MeshAllDataInJob,
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		MeshAllDataInJob2,
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		LAST_VALUE
	}

	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public struct COGEOLCADOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public BPMDFEDMLLG BKGAJHNMIBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int HKPNGOOIJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int KPDNJDMIIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long NEKKBCDEPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long NHOPEFMLGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float HFKCEFIGIIK;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BE80", Offset = "0x6F3AE80", VA = "0x186F3BE80")]
		public void BCCFFCEEHAG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BEB0", Offset = "0x6F3AEB0", VA = "0x186F3BEB0")]
		public void HHBFEMLFOFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string JNMNHKJOAJI;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string EGLLELICNGE;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker BODDGBBDODH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker DCEALIPFBGC;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker PELBHFOEFFF;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker HEJFFHOAOBE;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker NLJLCDDIMGJ;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker BPMEPAHIKCI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker CBIPKEMNLMH;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker LIIAKEBICBI;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker GOKKPCENCBD;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker DGOOOEBHNBF;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker HPJGBEBLKNJ;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker NGDLOJKLPHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<OMIMDAIBEJM> HOHLANLKFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly PEIKIFBHNLD GBLFLHGAHIF;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool FPMPCMMMLFE = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int JEFGJPLLPLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int BGPCLMCBMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool MAFAJKFIAFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool EEGOCLHBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool DPEBFNIMMAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal GECPLEMDEKC LNHGKEAKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool BCCHFFNGEBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 GFJEGGMOKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 DAFELKMFIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float FPGNEKOMHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float JANJNOAJHCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int FKFGHGKLABI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int KNIIIFOFEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int JCMNIHJEJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int EIBHJOIICOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float NOLMHPPLBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float GJNDAOBGHDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int FCECDCACGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long FGGAICLILJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long KGIGBMIIINJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long CGJJLNKLFCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int FEHMEFDALGE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int IPJLCDGDIMD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] MGBLNEEJHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] POMEAEPEDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] KGCGIBKNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<COGEOLCADOD> HCDCFKGMGHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private CBBOFCDCFKM IDEFOLNJACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long JHGPOOMMNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long EMPKFIOJFFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int PIFCDIHODMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float JEGJPAAIDFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal CBBOFCDCFKM.GCMEKIIHHME EIBAFLCBAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool FFAIHPJGBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private ALFFILMAKJC ELAAKHOEGIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle LOHKJFOHBNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> BNCEGJHBJFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool IFFNKDICFDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle FPKFCFCJAGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private CBBOFCDCFKM GAIFHLGNIBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private OIKFHLHECEP KIPEHOHJAJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform ALIJNPEOBDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private DGDJKJOFHLA DFPMHKGEJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long CELLDCLCPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long ENACHIIBAII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long OBPOCGBJJDA;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh HGCBFKPEGGP
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E60", Offset = "0x8B8E60", VA = "0x1808B9E60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8BB020", Offset = "0x8BA020", VA = "0x1808BB020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter LIPFPLEKIHB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8BB030", Offset = "0x8BA030", VA = "0x1808BB030")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer CJFFNDPEMPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E90", Offset = "0x8B8E90", VA = "0x1808B9E90")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B9ED0", Offset = "0x8B8ED0", VA = "0x1808B9ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> ALOILLHLOHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8B9EA0", Offset = "0x8B8EA0", VA = "0x1808B9EA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8B9E20", Offset = "0x8B8E20", VA = "0x1808B9E20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int LJFJGINHHKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xAAB590", Offset = "0xAAA590", VA = "0x180AAB590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int IJEAHDOEFJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1404B50", Offset = "0x1403B50", VA = "0x181404B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int IFGEJJCLEGD
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6F43340", Offset = "0x6F42340", VA = "0x186F43340")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<OMIMDAIBEJM> CHNLKAOKDFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8B9BC0", Offset = "0x8B8BC0", VA = "0x1808B9BC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6F42B10", Offset = "0x6F41B10", VA = "0x186F42B10")]
	public void EAEGJDDJIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6F497F0", Offset = "0x6F487F0", VA = "0x186F497F0")]
	private void NEKDGFBANOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B530", Offset = "0x6F4A530", VA = "0x186F4B530")]
	public PLOHHPLEFIF(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6F43C70", Offset = "0x6F42C70", VA = "0x186F43C70")]
	public void HHBFEMLFOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A760", Offset = "0x6F49760", VA = "0x186F4A760")]
	private void OMBFAJJDILM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6F42F30", Offset = "0x6F41F30", VA = "0x186F42F30")]
	private void FFLLMPGPCEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4B040", Offset = "0x6F4A040", VA = "0x186F4B040")]
	public Mesh PJPJLMKOPBI(MeshFilter MJMPFCNBEKN, Transform IMCFIOFNLHP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6F448E0", Offset = "0x6F438E0", VA = "0x186F448E0")]
	private void IHHPIINIKNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6F42DD0", Offset = "0x6F41DD0", VA = "0x186F42DD0")]
	public void EMNFJLCHEAG(OMIMDAIBEJM EJAOCFLDAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6F49370", Offset = "0x6F48370", VA = "0x186F49370")]
	public bool MMINLHILKEO(OMIMDAIBEJM EJAOCFLDAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6F48F50", Offset = "0x6F47F50", VA = "0x186F48F50")]
	public bool KOLCIDGNCMK(OMIMDAIBEJM EJAOCFLDAKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6F492E0", Offset = "0x6F482E0", VA = "0x186F492E0", Slot = "4")]
	public virtual void MLDFLJCGDCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A870", Offset = "0x6F49870", VA = "0x186F4A870")]
	public void PCKAJDBCCLG(Transform KNPJEDGMHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6F42A50", Offset = "0x6F41A50", VA = "0x186F42A50")]
	private long CNPHNJGOOOP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6F44780", Offset = "0x6F43780", VA = "0x186F44780")]
	private long HKAGDDKKEJB()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6F415D0", Offset = "0x6F405D0", VA = "0x186F415D0")]
	public bool CEAPAKOLFLO(Transform KNPJEDGMHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6F48080", Offset = "0x6F47080", VA = "0x186F48080")]
	public bool KEJPNBGICAA(bool LKAEGPOEKGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6F49B80", Offset = "0x6F48B80", VA = "0x186F49B80")]
	private void NHEHGAPPBLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6F45890", Offset = "0x6F44890", VA = "0x186F45890")]
	public bool JFFNAIJKKNL(float4x4 KEJDPGNGNMF, BatchedMeshRenderer NAIHNOFDNLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6F48FB0", Offset = "0x6F47FB0", VA = "0x186F48FB0")]
	public void LDJCOJKDLMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6F43010", Offset = "0x6F42010", VA = "0x186F43010")]
	public bool GBOHHEPBKCL(bool LKAEGPOEKGM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6F415C0", Offset = "0x6F405C0", VA = "0x186F415C0")]
	public void BNMGFKPDMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6F41200", Offset = "0x6F40200", VA = "0x186F41200")]
	public void AKNBGODPCAE(CBBOFCDCFKM BKGAJHNMIBN, int JLDAINMNBEM, int IDPIJJGCLMD, float JKNJEJKOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6F42B20", Offset = "0x6F41B20", VA = "0x186F42B20")]
	public void EGPKKDIIBDH(BPMDFEDMLLG MNDHBHPIEFG, int JLDAINMNBEM, int IDPIJJGCLMD, float JKNJEJKOMCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A800", Offset = "0x6F49800", VA = "0x186F4A800")]
	public (long, long, long) PAKBJPIGAGE()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xAC53E0", Offset = "0xAC43E0", VA = "0x180AC53E0")]
	public long OFEPAJOJPPE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6F493F0", Offset = "0x6F483F0", VA = "0x186F493F0")]
	private void MMPECNCPNPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6F41230", Offset = "0x6F40230", VA = "0x186F41230")]
	public (long, long) BAMMADGFHBP(float JIDKAPBJIKP, float4x4 KEJDPGNGNMF)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public void HKFPGODNMIN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6F4AAB0", Offset = "0x6F49AB0", VA = "0x186F4AAB0")]
	internal void PGDDMKCPEBC(GECPLEMDEKC IBKAGABFHDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6F43360", Offset = "0x6F42360", VA = "0x186F43360")]
	private (float, float, float, float) GLEOGLJPLCB(float OJBPGBEMAGO, float4x4 KEJDPGNGNMF)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6F43C10", Offset = "0x6F42C10", VA = "0x186F43C10")]
	private float GLFPOPJODHA(float OJBPGBEMAGO, float4x4 KEJDPGNGNMF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A380", Offset = "0x6F49380", VA = "0x186F4A380")]
	private (int, int) OHAFEEGFOON(float PEADPAFBMHF)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6F47010", Offset = "0x6F46010", VA = "0x186F47010")]
	public void JJOAEAIIOFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6F49190", Offset = "0x6F48190", VA = "0x186F49190")]
	private void LENCMOFKFNN(CBBOFCDCFKM EKFFOEIILBL, CBBOFCDCFKM.GCMEKIIHHME BDDEGIADJKJ, bool IFGPMIKNBHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6F491E0", Offset = "0x6F481E0", VA = "0x186F491E0")]
	private void LENCMOFKFNN([In] BPMDFEDMLLG EKFFOEIILBL, CBBOFCDCFKM.GCMEKIIHHME BDDEGIADJKJ, bool IFGPMIKNBHB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6F4A6C0", Offset = "0x6F496C0", VA = "0x186F4A6C0")]
	private void OHFNDOKEMPA(CBBOFCDCFKM.GCMEKIIHHME BDDEGIADJKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6F42A20", Offset = "0x6F41A20", VA = "0x186F42A20")]
	private void CNHJGOHOHOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6F42700", Offset = "0x6F41700", VA = "0x186F42700")]
	private void CLFJAKLDPDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6F40850", Offset = "0x6F3F850", VA = "0x186F40850")]
	public long AKDJKPCFJMM(long LMCAPAAPNLJ, int LAAFICNDBFI)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6F44B70", Offset = "0x6F43B70", VA = "0x186F44B70")]
	private void JBHPNDIPKNK(CBBOFCDCFKM BDGDEHLCEJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6F4ABD0", Offset = "0x6F49BD0", VA = "0x186F4ABD0")]
	private void PIIOHBHOBBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6F49AF0", Offset = "0x6F48AF0", VA = "0x186F49AF0")]
	private float NGKCEDHMIML(int FKCFPBAMAMG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6F43DA0", Offset = "0x6F42DA0", VA = "0x186F43DA0")]
	private void HIDPCGKHOOB(CBBOFCDCFKM BKGAJHNMIBN, DKHBLCEKHGJ MNDHBHPIEFG, int JLDAINMNBEM, int IDPIJJGCLMD, float JKNJEJKOMCE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct ALFFILMAKJC : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct NHLAFNBEMJG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int NIJCHEEIDIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int IOCNHPANMNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int FFICNHLLEED;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int MMMLKAOHNNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int IJNFGJHIADB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int GLJBINHMOIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int HKPNGOOIJIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int KPDNJDMIIKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float HFKCEFIGIIK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct ELGBGKPKFGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public PGDNNEPNODJ.MIDEFNAEOJF ADHOCMNFDPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float OOCEKJAHGNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float PBDCKFDGHCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float CMGAFAHGHEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float FAEKMMILLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float CPOEEJNANKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float LPLBBLMMEGD;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct MGCDPKINKFC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> GEIPPJCAJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> KEECCJACAHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> OCGMBCNBLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> DDJBNFELIDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> KPBBNHCKHNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> ONFLEMEPGMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool KMMBLGPDOCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int IFGEJJCLEGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int FKEHJJBKFLA;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FE90", Offset = "0x6F3EE90", VA = "0x186F3FE90")]
		public void MHPNOLCFFPN(int PLIBIFGPBLB, int EAANJJKLLEP, Allocator HHJAFJNPHLL, bool JJHIAIDKKHM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FC40", Offset = "0x6F3EC40", VA = "0x186F3FC40")]
		public static MGCDPKINKFC MGBPGGFNEGL(CBBOFCDCFKM KBCCBGCMCIL)
		{
			return default(MGCDPKINKFC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6F3FB80", Offset = "0x6F3EB80", VA = "0x186F3FB80")]
		public void HHBFEMLFOFF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker AANIOLLNKKL;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker CHPMNNBJMGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<NHLAFNBEMJG> HKNDMOHCGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private MGCDPKINKFC DJHFFJEFAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private MGCDPKINKFC BDGDEHLCEJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 FHALIAABBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 DCBGPIPJENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private ELGBGKPKFGC CIEMHEKAHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* BEFDDNCEDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> NEOGBNMBBBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> CJGGEOMHCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> MAGKJNKNGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> GGMNFHHHBFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> LOFGPIKLNOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> FBFFHBPNHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> IKLCLFIOOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> AFNLLBFPCMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> BBEOLDLBNJL;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6F35510", Offset = "0x6F34510", VA = "0x186F35510")]
	public ALFFILMAKJC([In] List<PLOHHPLEFIF.COGEOLCADOD> DMFHGPGKDEP, [In] CBBOFCDCFKM MGFLDOAFCOC, [In] PLOHHPLEFIF CEKBHPBFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6F334C0", Offset = "0x6F324C0", VA = "0x186F334C0", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6F33610", Offset = "0x6F32610", VA = "0x186F33610")]
	public void HDFFALCALPO(List<PLOHHPLEFIF.COGEOLCADOD> GLOCJEDCEIK, [In] PLOHHPLEFIF CEKBHPBFPKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6F341A0", Offset = "0x6F331A0", VA = "0x186F341A0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool KKJEIKLLJJN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6F33F70", Offset = "0x6F32F70", VA = "0x186F33F70")]
	private BPMDFEDMLLG KFLEIOCCILE(int PILDIADAJNA, Allocator HHJAFJNPHLL)
	{
		return default(BPMDFEDMLLG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6F344E0", Offset = "0x6F334E0", VA = "0x186F344E0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void PJOEJFDJANC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6F341C0", Offset = "0x6F331C0", VA = "0x186F341C0")]
	[IgnoreWarning(1371)]
	private NHLAFNBEMJG NNCDOAEDDDI([In] NHLAFNBEMJG HEENFOCCJPE, int CEBCAJHHKKO, [In] NativeArray<int> PKEHEAPGHMP, [In] NativeArray<bool> CJGGEOMHCLC, NativeArray<int> MAGKJNKNGIM)
	{
		return default(NHLAFNBEMJG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6F33510", Offset = "0x6F32510", VA = "0x186F33510")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int GAJOCEGGFBF(NativeArray<int> PKEHEAPGHMP, int AEOIIECLCPJ, int JJJDPNCNKHB, int HIAILLJACAA)
	{
		return default(int);
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public static readonly CDBONJBDMGH log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker GOHNEIKGMMJ;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker BBCIPJCFGAH;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker IJBIDPIAEBH;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker EEPDABFIIPA;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker OEKFNCKBHLF;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker NLJLCDDIMGJ;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker DKNGKKJLIEI;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int EJPEFBEFJGG = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> CDALPJJNLMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<PLOHHPLEFIF>> ECCDPKGOODI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<PLOHHPLEFIF> GAJGMENNALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> KBMBHOPGCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform GAFNBJBNDPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool ACJAKJKJOND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool PEKMLILIEPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int HEHOLMKLCAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private PLOHHPLEFIF EHFONIKHIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material OIILBCOIFJD;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const int KPNDOAJFCMO = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static List<(long, Bounds, OMIMDAIBEJM)> APPALLMCOME;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> IFOFNLFDCCE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8BA030", Offset = "0x8B9030", VA = "0x1808BA030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HAOJODAACOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6F3BE30", Offset = "0x6F3AE30", VA = "0x186F3BE30")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		private static void BODLMCLLEKH(bool IEKCCIHMFBC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		private static void BODLMCLLEKH(bool IEKCCIHMFBC, string ABHPFCOODAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6F38E70", Offset = "0x6F37E70", VA = "0x186F38E70")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6F37350", Offset = "0x6F36350", VA = "0x186F37350")]
		public PLOHHPLEFIF AddToBatchedMesh(OMIMDAIBEJM CNMCONFCMGE, Material BIDMCIBAHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6F3B890", Offset = "0x6F3A890", VA = "0x186F3B890")]
		public void RemoveFromBatchedMesh(OMIMDAIBEJM BKGAJHNMIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6F37450", Offset = "0x6F36450", VA = "0x186F37450")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6F37BA0", Offset = "0x6F36BA0", VA = "0x186F37BA0")]
		private void JAEKNADCCAE(Renderer CONCMEKGEHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6F37590", Offset = "0x6F36590", VA = "0x186F37590")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6F37580", Offset = "0x6F36580", VA = "0x186F37580")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6F36D60", Offset = "0x6F35D60", VA = "0x186F36D60")]
		private void AOGHPBIMBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6F37EB0", Offset = "0x6F36EB0", VA = "0x186F37EB0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6F383E0", Offset = "0x6F373E0", VA = "0x186F383E0")]
		private PLOHHPLEFIF NBKPINMBKIC(OMIMDAIBEJM BKGAJHNMIBN, Material BIDMCIBAHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6F369F0", Offset = "0x6F359F0", VA = "0x186F369F0")]
		private PLOHHPLEFIF AKENBIGPNGH(Material BIDMCIBAHOL, int MBGOFKDCGKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6F387A0", Offset = "0x6F377A0", VA = "0x186F387A0")]
		private PLOHHPLEFIF OKDCFDINGAH(Material BIDMCIBAHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6F37C20", Offset = "0x6F36C20", VA = "0x186F37C20")]
		private float4x4 LIGBGOIFECD()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6F38680", Offset = "0x6F37680", VA = "0x186F38680")]
		private List<Material> OAHDIMADGME(Material BIDMCIBAHOL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xDEB6A0", Offset = "0xDEA6A0", VA = "0x180DEB6A0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6F37D20", Offset = "0x6F36D20", VA = "0x186F37D20")]
		public void MarkDirty(OMIMDAIBEJM BKGAJHNMIBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6F38020", Offset = "0x6F37020", VA = "0x186F38020")]
		public (long, long) MemorySizeInBytesForChosenDetail(float JIDKAPBJIKP)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6F3A600", Offset = "0x6F39600", VA = "0x186F3A600")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6F37630", Offset = "0x6F36630", VA = "0x186F37630")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6F390D0", Offset = "0x6F380D0", VA = "0x186F390D0")]
		public void RebatchOptimally(int JGKAPKFCGHG, int NKEAJFNKBGE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6F3BD00", Offset = "0x6F3AD00", VA = "0x186F3BD00")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class CHDJDAOFIBD
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct BPNFGNNPKEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float IPAOJGBKAGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public BatchedMeshRenderer BAFKJHDNDJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public PLOHHPLEFIF NOCPGAEDKMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public long FIAOOKKKPNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float IKHPOKKPLFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public bool MGPMBKGPBLH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class MPKOOOKJDBD : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E4")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xCF5360", Offset = "0xCF4360", VA = "0x180CF5360", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x6F51490", Offset = "0x6F50490", VA = "0x186F51490", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xE5C6A0", Offset = "0xE5B6A0", VA = "0x180E5C6A0")]
		[DebuggerHidden]
		public MPKOOOKJDBD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6F514E0", Offset = "0x6F504E0", VA = "0x186F514E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6F50720", Offset = "0x6F4F720", VA = "0x186F50720", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6F506D0", Offset = "0x6F4F6D0", VA = "0x186F506D0")]
		private void CLDKBJALKHK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6F50680", Offset = "0x6F4F680", VA = "0x186F50680")]
		private void AFDHGAJFOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6F51440", Offset = "0x6F50440", VA = "0x186F51440", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6F51390", Offset = "0x6F50390", VA = "0x186F51390", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6F51390", Offset = "0x6F50390", VA = "0x186F51390", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly CDBONJBDMGH IKKEHAGICFD;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker NLJLCDDIMGJ;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker LCLGPMNIDDM;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker HAJFHBLMJGK;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker OIOLEIFFGOG;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static float3 IJMKLFCAFCH;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static int OIMLIKADFLB;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static int FBGKOHEMJEM;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static int FPEJEEJIGED;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int OKGCEEMGOOO;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int AKOJEEGELCP;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int ECHBMHFLHFA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static long ABDDJBDJDND;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static long OAMPAMOKBBB;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int AGEOKPLBGFP;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static int EKGOMMDHBBA;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int GIFPLAAHLCE;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static float HLPLDKEEMJM;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static bool DJFJKLOPBBA;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int IHPCLNBEDDM;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float KCJNKPBKAMO;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static float LANOKBPKKKJ;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static float HJBIBJBAHNM;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float KLAFLBKMADK;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float MGJPIONOLGK;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float IIPIBFLFBLB;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float OFMNAIHPCIA;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float OPDBKAJBHIN;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static long JPLHCLMDPLF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static bool CDFFPKLKEDO;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static List<BatchedMeshRenderer> JDODEDBFOMC;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static List<BPNFGNNPKEG> FCJKNAAHHIL;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static Stack<CBBOFCDCFKM> APCDHCCMOKG;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static Stack<OIKFHLHECEP> HHNPOFBALIL;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool IPLLDINEALJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6F4C0C0", Offset = "0x6F4B0C0", VA = "0x186F4C0C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void BODLMCLLEKH(bool IEKCCIHMFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void LGKOINLOKNE(bool IEKCCIHMFBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	private static void BODLMCLLEKH(bool IEKCCIHMFBC, string ABHPFCOODAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8B5BA0", Offset = "0x8B4BA0", VA = "0x1808B5BA0")]
	public static void BCCFFCEEHAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F910", Offset = "0x6F4E910", VA = "0x186F4F910")]
	public static void MJPEEHIGLPG(BatchedMeshRenderer DOEAAHOJGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C8F0", Offset = "0x6F4B8F0", VA = "0x186F4C8F0")]
	public static void GHCJHPFGBLD(BatchedMeshRenderer DOEAAHOJGOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CCA0", Offset = "0x6F4BCA0", VA = "0x186F4CCA0")]
	private static (long, long, long) HHEMFGIAIFP(long IOGFLNBCNFF)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F750", Offset = "0x6F4E750", VA = "0x186F4F750")]
	public static bool KHEELNIHOKG(float AAHEGPBHFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C7F0", Offset = "0x6F4B7F0", VA = "0x186F4C7F0")]
	public static void FKNPHBBKIFE(float AAHEGPBHFNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6F4F800", Offset = "0x6F4E800", VA = "0x186F4F800")]
	public static bool MGLBHIOCDDH(float AAHEGPBHFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CF00", Offset = "0x6F4BF00", VA = "0x186F4CF00")]
	public static void JFFNAIJKKNL(long IOGFLNBCNFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BA40", Offset = "0x6F4AA40", VA = "0x186F4BA40")]
	public static long AKDJKPCFJMM(long LMCAPAAPNLJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C580", Offset = "0x6F4B580", VA = "0x186F4C580")]
	public static void EHJHKBEKLJK(PLOHHPLEFIF NOCPGAEDKMC, BatchedMeshRenderer BAFKJHDNDJF, long FIAOOKKKPNE, float IPAOJGBKAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C6C0", Offset = "0x6F4B6C0", VA = "0x186F4C6C0")]
	public static void EPDMOIJJBFL(PLOHHPLEFIF NOCPGAEDKMC, BatchedMeshRenderer BAFKJHDNDJF, long FIAOOKKKPNE, float FJBNPHLKMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C310", Offset = "0x6F4B310", VA = "0x186F4C310")]
	public static void DANPOHGJJLL(PLOHHPLEFIF NOCPGAEDKMC, BatchedMeshRenderer BAFKJHDNDJF, long FIAOOKKKPNE, float FJBNPHLKMOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FA70", Offset = "0x6F4EA70", VA = "0x186F4FA70")]
	public static void OBEMJGGLBIF(PLOHHPLEFIF NOCPGAEDKMC, BatchedMeshRenderer BAFKJHDNDJF, long FIAOOKKKPNE, float IFADLBKDJIG, bool MGPMBKGPBLH, float IPAOJGBKAGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FDF0", Offset = "0x6F4EDF0", VA = "0x186F4FDF0")]
	public static float PJBDDHBFFCL(long AKHFLDFFCEB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BDD0", Offset = "0x6F4ADD0", VA = "0x186F4BDD0")]
	public static (long, long) BAMMADGFHBP(float JIDKAPBJIKP)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C860", Offset = "0x6F4B860", VA = "0x186F4C860")]
	[IteratorStateMachine(typeof(MPKOOOKJDBD))]
	public static IEnumerable<bool> GCCODKAAMDL(long MLCKAHLPEEC, bool JJEODOPKHJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C150", Offset = "0x6F4B150", VA = "0x186F4C150")]
	public static void CLMMHGJCGIO(long MLCKAHLPEEC, bool JJEODOPKHJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C440", Offset = "0x6F4B440", VA = "0x186F4C440")]
	public static int EELEJBHHEOJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6F4FCA0", Offset = "0x6F4ECA0", VA = "0x186F4FCA0")]
	internal static CBBOFCDCFKM PGFIBFCFNHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6F4BFA0", Offset = "0x6F4AFA0", VA = "0x186F4BFA0")]
	internal static void BDDAOECCMDA(CBBOFCDCFKM GIDAELMFKAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6F4CDB0", Offset = "0x6F4BDB0", VA = "0x186F4CDB0")]
	internal static OIKFHLHECEP IHPDHHBBNLL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6F4C030", Offset = "0x6F4B030", VA = "0x186F4C030")]
	internal static void BDDAOECCMDA(OIKFHLHECEP KPDDBKCMCAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class ECGNBBBCNNA<KeyType> : PLOHHPLEFIF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Dictionary<KeyType, OMIMDAIBEJM> PPKNMLNLOEC;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C45360", Offset = "0x3C44360", VA = "0x183C45360")]
	public ECGNBBBCNNA(string DMCFPOLFNCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C45090", Offset = "0x3C44090", VA = "0x183C45090")]
	public void EMNFJLCHEAG(KeyType MLAECOMLIEC, OMIMDAIBEJM EJAOCFLDAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C45100", Offset = "0x3C44100", VA = "0x183C45100")]
	public bool KMLHENFNANI(KeyType MLAECOMLIEC, OMIMDAIBEJM EGNNOOHGMJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3C44FB0", Offset = "0x3C43FB0", VA = "0x183C44FB0")]
	public void ABIEFOPACDE(KeyType MLAECOMLIEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3C45300", Offset = "0x3C44300", VA = "0x183C45300", Slot = "4")]
	public override void MLDFLJCGDCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6F51600", Offset = "0x6F50600", VA = "0x186F51600")]
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
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
