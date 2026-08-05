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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
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
	public class LogRegistrationIndex : AGBKNAFJGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69F3CB0", Offset = "0x69F2CB0", VA = "0x1869F3CB0", Slot = "4")]
		public override void GGLLICMBJNI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x87BDE0", Offset = "0x87ADE0", VA = "0x18087BDE0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class NBIGJKLEIFP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly PHLKHBEJKKB HJHCNGCLEBI;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly PHLKHBEJKKB CGKGCOEPBGD;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly PHLKHBEJKKB HHHLNNEBKJN;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class MAFLKBJMMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEDOEEPMPLA BPGDPHKFJHM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LLEMLEJAAAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8511A0", Offset = "0x8501A0", VA = "0x1808511A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public MAFLKBJMMBN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct IEDOEEPMPLA
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct NDLOBOMABCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half ABCOPICICMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort IFDABEFNHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte FEKMMCIFICO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker AFJMMBLOOHM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker DMMGFJEFLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int LLEMLEJAAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int DKMKGMBDOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> CBPAKFMMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> CKLECABJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> HLMADOJIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> NLOPPFAEFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<NDLOBOMABCL> CJFJMKOLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> DMCBFMEPGEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> FIEKLFJCNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 APEHGNKPDCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 IJNOOBHAMMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 KFNOMNBIAAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 MKLAMMDOMAL;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long BKCPCPIAPJN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long DHFEGOELHJG;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float LBKBEHDFKHB;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool DPNHDOLPPFD;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x69EEC50", Offset = "0x69EDC50", VA = "0x1869EEC50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DKEFABGIEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69E7940", Offset = "0x69E6940", VA = "0x1869E7940")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69EF6E0", Offset = "0x69EE6E0", VA = "0x1869EF6E0")]
	public void NNJJIJJFMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x69E9E20", Offset = "0x69E8E20", VA = "0x1869E9E20")]
	public static IEDOEEPMPLA EAPGIKBOING(Allocator OOMMBGGEBLM, CMNEIJMNCCM AMCHGCPCCKA)
	{
		return default(IEDOEEPMPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69EA0F0", Offset = "0x69E90F0", VA = "0x1869EA0F0")]
	public static IEDOEEPMPLA EAPGIKBOING(Allocator OOMMBGGEBLM, NativeArray<float3> AFGCMDDMJIH, NativeArray<float3> FNHHJCBMMLF, NativeArray<float2> HNLIKHPCBEM, NativeArray<float4> AIDMFEAADPL, bool IKKBFMNNJKJ, NativeArray<float4> ILBCHPCDBLN, NativeArray<int> FLHNFMOECFH, int LLEMLEJAAAD, int AODLFKPNEIM, int DKMKGMBDOFG, int LIJFEPLBIFD)
	{
		return default(IEDOEEPMPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69ED040", Offset = "0x69EC040", VA = "0x1869ED040")]
	public CMNEIJMNCCM JBFAHINAPHG(Allocator OOMMBGGEBLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x69EFA50", Offset = "0x69EEA50", VA = "0x1869EFA50")]
	public void OIAIEFDOICF(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69EF800", Offset = "0x69EE800", VA = "0x1869EF800")]
	private void OAFJHBLNDLB(Mesh EIOKGMMIDKC, NativeArray<ushort> JMBFKFKHCPB, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x69EFB70", Offset = "0x69EEB70", VA = "0x1869EFB70")]
	public void PDIMFODLKIB(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69EB600", Offset = "0x69EA600", VA = "0x1869EB600")]
	public void HAGMADHPLJI(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69E8770", Offset = "0x69E7770", VA = "0x1869E8770")]
	public void CKAPDIDABNE(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x69EE310", Offset = "0x69ED310", VA = "0x1869EE310")]
	public void MCAEOLFIFOC(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x69EAC60", Offset = "0x69E9C60", VA = "0x1869EAC60")]
	public void GDMMOEOCDIC(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x69E9A40", Offset = "0x69E8A40", VA = "0x1869E9A40")]
	public void DNNELNCMEFP(Mesh EIOKGMMIDKC, CMNEIJMNCCM.BJCIBLNPBFK CGMALBKGCGL, bool IMIIKJIDGII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x69EF560", Offset = "0x69EE560", VA = "0x1869EF560")]
	public long NCEPJFDMJEM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x69ECFD0", Offset = "0x69EBFD0", VA = "0x1869ECFD0")]
	public long IPCIFLHDLLD(CMNEIJMNCCM.BJCIBLNPBFK CGMALBKGCGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69E7D40", Offset = "0x69E6D40", VA = "0x1869E7D40")]
	private void BDBFLFOLMOK(int ADJOHKACAAE, int DKOMKGMJOOP, Allocator OOMMBGGEBLM, bool KHFMCGMFJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69EC3B0", Offset = "0x69EB3B0", VA = "0x1869EC3B0")]
	private void HHCGPJNJBKB(NativeArray<float3> NMNEMFCHKBL, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x69DBB60", Offset = "0x69DAB60", VA = "0x1869DBB60")]
	[BurstCompile]
	private unsafe static void HHCGPJNJBKB([NoAlias] float3* NMNEMFCHKBL, [In][NoAlias] ushort* AFGCMDDMJIH, int LLEMLEJAAAD, [In] float3 APEHGNKPDCN, [In] float3 IJNOOBHAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69EF620", Offset = "0x69EE620", VA = "0x1869EF620")]
	[BurstCompile]
	private unsafe static void NILLDKBDGNL([NoAlias] CMNEIJMNCCM.DONDPKBCMGF* NMNEMFCHKBL, [In][NoAlias] ushort* AFGCMDDMJIH, int LLEMLEJAAAD, [In] float3 APEHGNKPDCN, [In] float3 IJNOOBHAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69EC070", Offset = "0x69EB070", VA = "0x1869EC070")]
	[BurstCompile]
	private unsafe static void HDIPEEGBJMP([NoAlias] CMNEIJMNCCM.DENMGOAJGOF* NMNEMFCHKBL, [In][NoAlias] ushort* AFGCMDDMJIH, int LLEMLEJAAAD, [In] float3 APEHGNKPDCN, [In] float3 IJNOOBHAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69E8240", Offset = "0x69E7240", VA = "0x1869E8240")]
	[BurstCompile]
	private unsafe static void GFJLFLEHJNN([NoAlias] CMNEIJMNCCM.IDNMHIGAJFA* NMNEMFCHKBL, [In][NoAlias] ushort* AFGCMDDMJIH, int LLEMLEJAAAD, [In] float3 APEHGNKPDCN, [In] float3 IJNOOBHAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69E8240", Offset = "0x69E7240", VA = "0x1869E8240")]
	[BurstCompile]
	private unsafe static void CAEKPJPHMHB([NoAlias] CMNEIJMNCCM.OIPIEAINKDK* NMNEMFCHKBL, [In][NoAlias] ushort* AFGCMDDMJIH, int LLEMLEJAAAD, [In] float3 APEHGNKPDCN, [In] float3 IJNOOBHAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69E8300", Offset = "0x69E7300", VA = "0x1869E8300")]
	[BurstCompile]
	private unsafe static void CCJIIAIHDEE([NoAlias] CMNEIJMNCCM.DBGPDFEPPJJ* NMNEMFCHKBL, [In][NoAlias] ushort* AFGCMDDMJIH, int LLEMLEJAAAD, [In] float3 APEHGNKPDCN, [In] float3 IJNOOBHAMMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69E7980", Offset = "0x69E6980", VA = "0x1869E7980")]
	private void AOKGGNOCDKO(NativeArray<float3> AFGCMDDMJIH, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x69DB780", Offset = "0x69DA780", VA = "0x1869DB780")]
	[BurstCompile]
	private unsafe static void AOKGGNOCDKO([NoAlias] ushort* NMNEMFCHKBL, [Out] float3 BJPMACMDCHA, [Out] float3 IJNOOBHAMMI, [In][NoAlias] float3* AFGCMDDMJIH, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x69E74B0", Offset = "0x69E64B0", VA = "0x1869E74B0")]
	private void AJGPOBOPJCH(NativeArray<float3> FNHHJCBMMLF, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x69E71F0", Offset = "0x69E61F0", VA = "0x1869E71F0")]
	[BurstCompile]
	private unsafe static void AJGPOBOPJCH([NoAlias] ushort* ANAHDHDHOMN, [In][NoAlias] float3* FNHHJCBMMLF, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69EF410", Offset = "0x69EE410", VA = "0x1869EF410")]
	private void MNCJJFNCPEC(NativeArray<float3> NCLMADHCAHM, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69EF1F0", Offset = "0x69EE1F0", VA = "0x1869EF1F0")]
	[BurstCompile]
	private unsafe static void MNCJJFNCPEC([NoAlias] float3* NCLMADHCAHM, [In][NoAlias] ushort* FNHHJCBMMLF, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x69EC6E0", Offset = "0x69EB6E0", VA = "0x1869EC6E0")]
	[BurstCompile]
	private unsafe static void IAMAPNMJMIP([NoAlias] CMNEIJMNCCM.DONDPKBCMGF* NMNEMFCHKBL, [In][NoAlias] ushort* FNHHJCBMMLF, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x69ECD90", Offset = "0x69EBD90", VA = "0x1869ECD90")]
	[BurstCompile]
	private unsafe static void IJCBHKBOFOD([NoAlias] CMNEIJMNCCM.DENMGOAJGOF* NMNEMFCHKBL, [In][NoAlias] ushort* FNHHJCBMMLF, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69E7E70", Offset = "0x69E6E70", VA = "0x1869E7E70")]
	[BurstCompile]
	private unsafe static void BHDJGGMGIMG([NoAlias] CMNEIJMNCCM.IDNMHIGAJFA* NMNEMFCHKBL, [In][NoAlias] ushort* FNHHJCBMMLF, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x69EF0A0", Offset = "0x69EE0A0", VA = "0x1869EF0A0")]
	[BurstCompile]
	private unsafe static void MKLHBPBCGPL([NoAlias] CMNEIJMNCCM.OIPIEAINKDK* NMNEMFCHKBL, [In][NoAlias] ushort* FNHHJCBMMLF, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x69E98E0", Offset = "0x69E88E0", VA = "0x1869E98E0")]
	[BurstCompile]
	private unsafe static void DJHFHADMHNJ([NoAlias] CMNEIJMNCCM.DBGPDFEPPJJ* NMNEMFCHKBL, [In][NoAlias] ushort* FNHHJCBMMLF, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69E7850", Offset = "0x69E6850", VA = "0x1869E7850")]
	private void ANJDEJGMPGC(NativeArray<float2> HNLIKHPCBEM, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x69E7590", Offset = "0x69E6590", VA = "0x1869E7590")]
	[BurstCompile]
	private unsafe static void ANJDEJGMPGC([NoAlias] ushort* KMACEIEHOFB, [Out] float2 LDMGLFIFBOJ, [Out] float2 MKLAMMDOMAL, [In][NoAlias] float2* HNLIKHPCBEM, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x69F0380", Offset = "0x69EF380", VA = "0x1869F0380")]
	[BurstCompile]
	private static void PLCONPIFLII([Out] float2 CIMHNEKKJFH, ushort GHKHHKCJAGD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x69E9540", Offset = "0x69E8540", VA = "0x1869E9540")]
	private void CNKAPIFCPIJ(NativeArray<float2> KMACEIEHOFB, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x69E9460", Offset = "0x69E8460", VA = "0x1869E9460")]
	[BurstCompile]
	private unsafe static void CNKAPIFCPIJ([NoAlias] float2* KMACEIEHOFB, [NoAlias] ushort* HNLIKHPCBEM, int LLEMLEJAAAD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x69EE050", Offset = "0x69ED050", VA = "0x1869EE050")]
	[BurstCompile]
	private unsafe static void JOBFJJIAEOJ([NoAlias] CMNEIJMNCCM.DONDPKBCMGF* NMNEMFCHKBL, [NoAlias] ushort* HNLIKHPCBEM, int LLEMLEJAAAD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x69ECC90", Offset = "0x69EBC90", VA = "0x1869ECC90")]
	[BurstCompile]
	private unsafe static void IHAAGFCOLAM([NoAlias] CMNEIJMNCCM.DENMGOAJGOF* NMNEMFCHKBL, [NoAlias] ushort* HNLIKHPCBEM, int LLEMLEJAAAD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x69EAA70", Offset = "0x69E9A70", VA = "0x1869EAA70")]
	[BurstCompile]
	private unsafe static void GBBHGLHHEFP([NoAlias] CMNEIJMNCCM.IDNMHIGAJFA* NMNEMFCHKBL, [NoAlias] ushort* HNLIKHPCBEM, int LLEMLEJAAAD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x69ECED0", Offset = "0x69EBED0", VA = "0x1869ECED0")]
	[BurstCompile]
	private unsafe static void IKEKCMFKDBD([NoAlias] CMNEIJMNCCM.OIPIEAINKDK* NMNEMFCHKBL, [NoAlias] ushort* HNLIKHPCBEM, int LLEMLEJAAAD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x69EDF50", Offset = "0x69ECF50", VA = "0x1869EDF50")]
	[BurstCompile]
	private unsafe static void JIGJHKIAALB([NoAlias] CMNEIJMNCCM.DBGPDFEPPJJ* NMNEMFCHKBL, [NoAlias] ushort* HNLIKHPCBEM, int LLEMLEJAAAD, [In] float2 KFNOMNBIAAF, [In] float2 MKLAMMDOMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x69E7A70", Offset = "0x69E6A70", VA = "0x1869E7A70")]
	private void APJNNMIBJDC(NativeArray<float4> ILBCHPCDBLN, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69E7C20", Offset = "0x69E6C20", VA = "0x1869E7C20")]
	[BurstCompile]
	private unsafe static void APJNNMIBJDC([NoAlias] ushort* KFJJJJNDNLC, [In][NoAlias] float4* FOOBOOLEGBG, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x69EF4D0", Offset = "0x69EE4D0", VA = "0x1869EF4D0")]
	[BurstCompile]
	private static ushort MOIDBOLOGOC([In] float4 JJNEANKCHKA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69EC130", Offset = "0x69EB130", VA = "0x1869EC130")]
	private void HGEPEFKABAC(NativeArray<float4> KFJJJJNDNLC, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x69EC260", Offset = "0x69EB260", VA = "0x1869EC260")]
	[BurstCompile]
	private unsafe static void HGEPEFKABAC([NoAlias] float4* KFJJJJNDNLC, [In][NoAlias] ushort* ILBCHPCDBLN, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69E8460", Offset = "0x69E7460", VA = "0x1869E8460")]
	[BurstCompile]
	private unsafe static void CFOLFNGMBBN([NoAlias] CMNEIJMNCCM.DONDPKBCMGF* NMNEMFCHKBL, [In][NoAlias] ushort* ILBCHPCDBLN, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x69E7FB0", Offset = "0x69E6FB0", VA = "0x1869E7FB0")]
	[BurstCompile]
	private unsafe static void BIMFLPKHPGG([NoAlias] CMNEIJMNCCM.DENMGOAJGOF* NMNEMFCHKBL, [In][NoAlias] ushort* ILBCHPCDBLN, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69ECAD0", Offset = "0x69EBAD0", VA = "0x1869ECAD0")]
	[BurstCompile]
	private unsafe static void IEFEPCMJGCO([NoAlias] CMNEIJMNCCM.IDNMHIGAJFA* NMNEMFCHKBL, [In][NoAlias] ushort* ILBCHPCDBLN, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69E96B0", Offset = "0x69E86B0", VA = "0x1869E96B0")]
	[BurstCompile]
	private unsafe static void CONHMFFJOIE([NoAlias] CMNEIJMNCCM.OIPIEAINKDK* NMNEMFCHKBL, [In][NoAlias] ushort* ILBCHPCDBLN, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69EEC90", Offset = "0x69EDC90", VA = "0x1869EEC90")]
	[BurstCompile]
	private unsafe static void MENFMNLHKKO([NoAlias] CMNEIJMNCCM.DBGPDFEPPJJ* NMNEMFCHKBL, [In][NoAlias] ushort* ILBCHPCDBLN, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x69E8180", Offset = "0x69E7180", VA = "0x1869E8180")]
	[BurstCompile]
	private static void BMGAKFDOPGK([Out] float4 KNFGDDANCCK, ushort GHKHHKCJAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69ED550", Offset = "0x69EC550", VA = "0x1869ED550")]
	private void JENMDAEHFNG(Allocator OOMMBGGEBLM, NativeArray<float4> AIDMFEAADPL, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x69ED950", Offset = "0x69EC950", VA = "0x1869ED950")]
	[BurstCompile]
	private unsafe static void JENMDAEHFNG([NoAlias] float4* FDLOCIJLIEF, [NoAlias] byte* JCIDKPKBKHH, [Out] int DPJDCAECBOD, [Out] int PDDNGJJNBEE, [NoAlias] float4* AIDMFEAADPL, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69E9140", Offset = "0x69E8140", VA = "0x1869E9140")]
	private static void CNEMIGHKKMN(NativeArray<float4> ANGKANGPPNF, NativeArray<NDLOBOMABCL> NJFAGOGEHPH, NativeArray<byte> BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x69E9320", Offset = "0x69E8320", VA = "0x1869E9320")]
	[BurstCompile]
	private unsafe static void CNEMIGHKKMN([NoAlias] float4* ANGKANGPPNF, [In][NoAlias] NDLOBOMABCL* NJFAGOGEHPH, [In][NoAlias] byte* BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69E7010", Offset = "0x69E6010", VA = "0x1869E7010")]
	[BurstCompile]
	private unsafe static void AHNOONMOELD([NoAlias] CMNEIJMNCCM.DONDPKBCMGF* NMNEMFCHKBL, [In][NoAlias] NDLOBOMABCL* NJFAGOGEHPH, [In][NoAlias] byte* BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69ED370", Offset = "0x69EC370", VA = "0x1869ED370")]
	[BurstCompile]
	private unsafe static void JBGPEFLDENC([NoAlias] CMNEIJMNCCM.DENMGOAJGOF* NMNEMFCHKBL, [In][NoAlias] NDLOBOMABCL* NJFAGOGEHPH, [In][NoAlias] byte* BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69EEEC0", Offset = "0x69EDEC0", VA = "0x1869EEEC0")]
	[BurstCompile]
	private unsafe static void MHBMJONCMJN([NoAlias] CMNEIJMNCCM.IDNMHIGAJFA* NMNEMFCHKBL, [In][NoAlias] NDLOBOMABCL* NJFAGOGEHPH, [In][NoAlias] byte* BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x69EC4A0", Offset = "0x69EB4A0", VA = "0x1869EC4A0")]
	[BurstCompile]
	private unsafe static void HLFLEEAFMEK([NoAlias] CMNEIJMNCCM.OIPIEAINKDK* NMNEMFCHKBL, [In][NoAlias] NDLOBOMABCL* NJFAGOGEHPH, [In][NoAlias] byte* BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69EA830", Offset = "0x69E9830", VA = "0x1869EA830")]
	[BurstCompile]
	private unsafe static void FPAMMFMKDFH([NoAlias] CMNEIJMNCCM.DBGPDFEPPJJ* NMNEMFCHKBL, [In][NoAlias] NDLOBOMABCL* NJFAGOGEHPH, [In][NoAlias] byte* BKLIBNNJBCI, int LLEMLEJAAAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x69F03D0", Offset = "0x69EF3D0", VA = "0x1869F03D0")]
	private void POANFMKCALN(Allocator OOMMBGGEBLM, NativeArray<int> FLHNFMOECFH, int LIJFEPLBIFD, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69EDB10", Offset = "0x69ECB10", VA = "0x1869EDB10")]
	private static NativeArray<byte> JFHAPNJOKAP(Allocator OOMMBGGEBLM, NativeArray<int> FLHNFMOECFH, int PKNACIEOKIA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x69EDE50", Offset = "0x69ECE50", VA = "0x1869EDE50")]
	[BurstCompile]
	private unsafe static int JFHAPNJOKAP([NoAlias] byte* GJMJJGJFGOD, [In][NoAlias] int* FLHNFMOECFH, int PKNACIEOKIA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69EE1F0", Offset = "0x69ED1F0", VA = "0x1869EE1F0")]
	private static void KPAKHOEINHL(NativeArray<int> DINOOMBAFCD, NativeArray<byte> PJBCINAIFFL, int DKMKGMBDOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x69EE150", Offset = "0x69ED150", VA = "0x1869EE150")]
	[BurstCompile]
	private unsafe static void KPAKHOEINHL([NoAlias] int* DINOOMBAFCD, [In][NoAlias] byte* PJBCINAIFFL, int DKMKGMBDOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x69EA790", Offset = "0x69E9790", VA = "0x1869EA790")]
	[BurstCompile]
	private unsafe static void FKNDCBJMCPA([NoAlias] ushort* DINOOMBAFCD, [In][NoAlias] byte* PJBCINAIFFL, int DKMKGMBDOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x69EA650", Offset = "0x69E9650", VA = "0x1869EA650")]
	[BurstCompile]
	private static void EEDNOLHAMEP([Out] float3 CIMHNEKKJFH, ushort GHKHHKCJAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x69EC910", Offset = "0x69EB910", VA = "0x1869EC910")]
	[BurstCompile]
	private static ushort IBHEAFJLOBP([In] float3 JJNEANKCHKA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class CMNEIJMNCCM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum BJCIBLNPBFK
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
	public enum IMKFOCGILJG
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
	public struct AMFLGEIJGIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public BJCIBLNPBFK CGMALBKGCGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool GPKIEGGJAIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int LDADCHBDMGC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct IAMPPAHBIEL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 LLLHNMGEKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 NJOPFIOMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 KGIJHOHKCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 GLCPPHPPDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 CJFJMKOLFKB;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct DONDPKBCMGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 LLLHNMGEKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 NJOPFIOMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 KGIJHOHKCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 GLCPPHPPDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 CJFJMKOLFKB;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct DENMGOAJGOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 LLLHNMGEKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint NJOPFIOMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint KGIJHOHKCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 GLCPPHPPDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 CJFJMKOLFKB;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct IDNMHIGAJFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 LLLHNMGEKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint NJOPFIOMLFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint KGIJHOHKCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 GLCPPHPPDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 CJFJMKOLFKB;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct OIPIEAINKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 LLLHNMGEKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint PBENKBNKCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 GLCPPHPPDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint CCADKMBDAGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint CBHBBLDHHIH;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct DBGPDFEPPJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public KDCMKJCFNDB.NINJIIDPBNM KOBMKAIHFIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint PBENKBNKCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 GLCPPHPPDHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint CCADKMBDAGG;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] IHJFGPKCCKN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int PLHGCIPBKGB(float PONGAOGJLMF);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class MPNCGKCIJOK
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x69F4350", Offset = "0x69F3350", VA = "0x1869F4350")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x69F3ED0", Offset = "0x69F2ED0", VA = "0x1869F3ED0")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x69F42A0", Offset = "0x69F32A0", VA = "0x1869F42A0")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x69F4030", Offset = "0x69F3030", VA = "0x1869F4030")]
		public static int GHKHNOGELCE(float PONGAOGJLMF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint IHMNNLBMJNB([In] float4 CKOKPBDJPNC);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class ODNJCMOPPAD
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x69F4AE0", Offset = "0x69F3AE0", VA = "0x1869F4AE0")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x69F4590", Offset = "0x69F3590", VA = "0x1869F4590")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x69F4A30", Offset = "0x69F3A30", VA = "0x1869F4A30")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x69F46F0", Offset = "0x69F36F0", VA = "0x1869F46F0")]
		public static uint GHKHNOGELCE([In] float4 CKOKPBDJPNC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint CBOCPDBCNFB([In] float3 CKOKPBDJPNC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class ILNMFNJJIJK
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x69F0B40", Offset = "0x69EFB40", VA = "0x1869F0B40")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x69F06B0", Offset = "0x69EF6B0", VA = "0x1869F06B0")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x69F0A90", Offset = "0x69EFA90", VA = "0x1869F0A90")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x69F0810", Offset = "0x69EF810", VA = "0x1869F0810")]
		public static uint GHKHNOGELCE([In] float3 CKOKPBDJPNC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void MNEIKBOHFOD([NoAlias] DENMGOAJGOF* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class LPPCOOCKMEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x69F3B80", Offset = "0x69F2B80", VA = "0x1869F3B80")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x69F3730", Offset = "0x69F2730", VA = "0x1869F3730")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x69F3AD0", Offset = "0x69F2AD0", VA = "0x1869F3AD0")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x69F3890", Offset = "0x69F2890", VA = "0x1869F3890")]
		public unsafe static void GHKHNOGELCE([NoAlias] DENMGOAJGOF* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void MMOIEJOOLCL([NoAlias] IDNMHIGAJFA* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class JCBLGKJHFMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x69F3500", Offset = "0x69F2500", VA = "0x1869F3500")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x69F30B0", Offset = "0x69F20B0", VA = "0x1869F30B0")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x69F3450", Offset = "0x69F2450", VA = "0x1869F3450")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x69F3210", Offset = "0x69F2210", VA = "0x1869F3210")]
		public unsafe static void GHKHNOGELCE([NoAlias] IDNMHIGAJFA* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void LKGOKHBENGC([NoAlias] OIPIEAINKDK* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class CCDGFKMBLAP
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x69DD3F0", Offset = "0x69DC3F0", VA = "0x1869DD3F0")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x69DCDF0", Offset = "0x69DBDF0", VA = "0x1869DCDF0")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x69DD340", Offset = "0x69DC340", VA = "0x1869DD340")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x69DCF50", Offset = "0x69DBF50", VA = "0x1869DCF50")]
		public unsafe static void GHKHNOGELCE([NoAlias] OIPIEAINKDK* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void IIFDKHDLAFN([NoAlias] DBGPDFEPPJJ* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB, [Out] float3 HKKIIHLDHNC, [Out] float3 OIGJLIFIAKH);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class AHCKDFFBEHD
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr JKMMCDPBMKH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr CAKNDIGGNAE;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x69DCCC0", Offset = "0x69DBCC0", VA = "0x1869DCCC0")]
		[BurstDiscard]
		private static void NJLEKDJIPPF(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x69DC540", Offset = "0x69DB540", VA = "0x1869DC540")]
		private static IntPtr FAHDBDGKAOB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x69DCC10", Offset = "0x69DBC10", VA = "0x1869DCC10")]
		public static void MMBBKFAIPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public static void LFNNOPDGNGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x69DC6A0", Offset = "0x69DB6A0", VA = "0x1869DC6A0")]
		public unsafe static void GHKHNOGELCE([NoAlias] DBGPDFEPPJJ* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB, [Out] float3 HKKIIHLDHNC, [Out] float3 OIGJLIFIAKH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int JJGJCBEPKEN = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> CCAJPNAKLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> DEOEDIKAGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> CDABJBJKPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> LPNHBEFOIAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> AMLJIHKJAKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> EPBOACLNBDC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] FDDBHAIFMBN;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool MPIDNLONIIB;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static AMFLGEIJGIL[] IBDLKBOGJBI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KFCLKKNDODJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x69E1950", Offset = "0x69E0950", VA = "0x1869E1950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x69DD740", Offset = "0x69DC740", VA = "0x1869DD740")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GLOPGFJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x69E1ED0", Offset = "0x69E0ED0", VA = "0x1869E1ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool DKEFABGIEEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x69DD780", Offset = "0x69DC780", VA = "0x1869DD780")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x69DE250", Offset = "0x69DD250", VA = "0x1869DE250")]
	public static IMKFOCGILJG ECDKBLFBJEF(BJCIBLNPBFK CGMALBKGCGL)
	{
		return default(IMKFOCGILJG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x69E1990", Offset = "0x69E0990", VA = "0x1869E1990")]
	public static void MCMAJKIPEJD(IMKFOCGILJG PNIJEKAIFPP, Material JNFDDANGPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x69DE140", Offset = "0x69DD140", VA = "0x1869DE140", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x69DD7C0", Offset = "0x69DC7C0", VA = "0x1869DD7C0")]
	public void BDBFLFOLMOK(int ADJOHKACAAE, int DKOMKGMJOOP, Allocator OOMMBGGEBLM, bool GNDAMAKKDNG, bool KHFMCGMFJNM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x69DE030", Offset = "0x69DD030", VA = "0x1869DE030")]
	public void DNDDEPEKLBA(int ADJOHKACAAE, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69E1F10", Offset = "0x69E0F10", VA = "0x1869E1F10", Slot = "6")]
	public bool OHMLLLDPHDB(Mesh EIOKGMMIDKC, bool MHIOOHIDKFB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69E1F30", Offset = "0x69E0F30", VA = "0x1869E1F30")]
	public bool OIAIEFDOICF(Mesh EIOKGMMIDKC, bool MHIOOHIDKFB, bool IMIIKJIDGII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69DE310", Offset = "0x69DD310", VA = "0x1869DE310")]
	public bool ENAEPEKDAKC(Mesh EIOKGMMIDKC, CMNEIJMNCCM FFPGCFCLJNN, bool MHIOOHIDKFB = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69E2330", Offset = "0x69E1330", VA = "0x1869E2330")]
	public void PDIMFODLKIB(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x69E03E0", Offset = "0x69DF3E0", VA = "0x1869E03E0")]
	[BurstCompile]
	public static int JLCCBPLKKAA(float PONGAOGJLMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x69E0480", Offset = "0x69DF480", VA = "0x1869E0480")]
	[BurstCompile]
	public static uint JLCCBPLKKAA([In] float4 CKOKPBDJPNC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x69E0430", Offset = "0x69DF430", VA = "0x1869E0430")]
	[BurstCompile]
	public static uint JLCCBPLKKAA([In] float3 CKOKPBDJPNC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x69DF4A0", Offset = "0x69DE4A0", VA = "0x1869DF4A0")]
	public void HAGMADHPLJI(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x69E1BE0", Offset = "0x69E0BE0", VA = "0x1869E1BE0")]
	[BurstCompile]
	private unsafe static void NCNMFECJKAA([NoAlias] DENMGOAJGOF* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x69DD9B0", Offset = "0x69DC9B0", VA = "0x1869DD9B0")]
	public void CKAPDIDABNE(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x69E30B0", Offset = "0x69E20B0", VA = "0x1869E30B0")]
	[BurstCompile]
	private unsafe static void POFPBNNOBPK([NoAlias] IDNMHIGAJFA* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x69E12D0", Offset = "0x69E02D0", VA = "0x1869E12D0")]
	public void MCAEOLFIFOC(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x69E1250", Offset = "0x69E0250", VA = "0x1869E1250")]
	[BurstCompile]
	private unsafe static void MBAMIHAICPJ([NoAlias] OIPIEAINKDK* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x69DE810", Offset = "0x69DD810", VA = "0x1869DE810")]
	public void GDMMOEOCDIC(Mesh EIOKGMMIDKC, bool IMIIKJIDGII)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x69E0F70", Offset = "0x69DFF70", VA = "0x1869E0F70")]
	[BurstCompile]
	private unsafe static void LCMMAHMEDDF([NoAlias] DBGPDFEPPJJ* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB, [Out] float3 HKKIIHLDHNC, [Out] float3 OIGJLIFIAKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x69DE0B0", Offset = "0x69DD0B0", VA = "0x1869DE0B0")]
	public void DNNELNCMEFP(Mesh EIOKGMMIDKC, BJCIBLNPBFK CGMALBKGCGL, bool IMIIKJIDGII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x69E1C60", Offset = "0x69E0C60", VA = "0x1869E1C60")]
	public void NGJBLAFJBEA(CMNEIJMNCCM EIOKGMMIDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x69DEF50", Offset = "0x69DDF50", VA = "0x1869DEF50")]
	public void GGJEAMHMOID(CMNEIJMNCCM IEJOAHLDAPK, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x69E1AB0", Offset = "0x69E0AB0", VA = "0x1869E1AB0")]
	public long NCEPJFDMJEM()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x69E1A50", Offset = "0x69E0A50", VA = "0x1869E1A50")]
	public static long NCEPJFDMJEM(int EJCELJLAGNM, int JFDEFIOJCLD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x69E0280", Offset = "0x69DF280", VA = "0x1869E0280")]
	public static long IPCIFLHDLLD(int EJCELJLAGNM, int JFDEFIOJCLD, BJCIBLNPBFK CGMALBKGCGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x69E0320", Offset = "0x69DF320", VA = "0x1869E0320")]
	public long IPCIFLHDLLD(BJCIBLNPBFK CGMALBKGCGL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x69E11F0", Offset = "0x69E01F0", VA = "0x1869E11F0")]
	public void LKDBPMEOPMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x69E2DB0", Offset = "0x69E1DB0", VA = "0x1869E2DB0")]
	public static void PFAIBAFEPMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x69E04D0", Offset = "0x69DF4D0", VA = "0x1869E04D0")]
	public BJCIBLNPBFK JPFCHHJJIGK()
	{
		return default(BJCIBLNPBFK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69DFB20", Offset = "0x69DEB20", VA = "0x1869DFB20")]
	public static (int, int) HHEKIDLNKOE(Mesh EIOKGMMIDKC)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69E3130", Offset = "0x69E2130", VA = "0x1869E3130")]
	public static int PPHGBMHGPAE(VertexAttributeDescriptor[] DDLCFAGFNGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x69DE2A0", Offset = "0x69DD2A0", VA = "0x1869DE2A0")]
	public static long ECLLKGMHNMB(Mesh EIOKGMMIDKC, int LABOGKPMMAO, int FOLBEGHJKJC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public CMNEIJMNCCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69E01E0", Offset = "0x69DF1E0", VA = "0x1869E01E0")]
	[BurstCompile]
	public static int IGOHLIJFKDC(float PONGAOGJLMF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69DFFA0", Offset = "0x69DEFA0", VA = "0x1869DFFA0")]
	[BurstCompile]
	public static uint IGOHLIJFKDC([In] float4 CKOKPBDJPNC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x69E0130", Offset = "0x69DF130", VA = "0x1869E0130")]
	[BurstCompile]
	public static uint IGOHLIJFKDC([In] float3 CKOKPBDJPNC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x69DFBF0", Offset = "0x69DEBF0", VA = "0x1869DFBF0")]
	[BurstCompile]
	public unsafe static void IEOKKMNPJBJ([NoAlias] DENMGOAJGOF* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x69DF050", Offset = "0x69DE050", VA = "0x1869DF050")]
	[BurstCompile]
	public unsafe static void GJIHBCGGANH([NoAlias] IDNMHIGAJFA* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x69E0FF0", Offset = "0x69DFFF0", VA = "0x1869E0FF0")]
	[BurstCompile]
	public unsafe static void LIGFFFPNOBH([NoAlias] OIPIEAINKDK* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x69E0C30", Offset = "0x69DFC30", VA = "0x1869E0C30")]
	[BurstCompile]
	public unsafe static void KABFHBFAIJC([NoAlias] DBGPDFEPPJJ* NMNEMFCHKBL, int LLEMLEJAAAD, [In][NoAlias] float3* LEBPBJGJDOD, [In][NoAlias] float3* CKLECABJJBF, [In][NoAlias] float4* HLMADOJIIPN, [In][NoAlias] float2* NLOPPFAEFMB, [In][NoAlias] float4* CJFJMKOLFKB, [Out] float3 HKKIIHLDHNC, [Out] float3 OIGJLIFIAKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct LNOKEKHCDKH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int PKEJBCBJCHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 KLLHIPALAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion LEJLKNKGLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 AOKPEOPMCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int DKEDIIKAFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int JCCNEGPADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int OGLLBELALLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float JALCCPOJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 ONKJGLPLJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool LHDHJDJBGCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public HODKMJPODPC ACKDLHCFNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 MGKMBBCFPLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float PKDJGDOBCPC;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OKBKOLMLABP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static JPPIMJMICNO KDEFBIGGHHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<LNOKEKHCDKH> DGECOBFNLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<LCKIKCODBJD> ONBOAHNHPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<MMACAKIAGAC> NABNBDHHKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<LIICCIDLFKB> AHENKIIABMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<LCKIKCODBJD> KNGFBAPNJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<BDNNLHEHNGA> MGCOOMOBLGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<LIICCIDLFKB>> ICHKABFNJOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<NNIBPMAKIDL> MJPENDHJCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> LLNMIGHHLPC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0xEE80A0", Offset = "0xEE70A0", VA = "0x180EE80A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xEE77C0", Offset = "0xEE67C0", VA = "0x180EE77C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GLOPGFJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xEE80B0", Offset = "0xEE70B0", VA = "0x180EE80B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xEE6DE0", Offset = "0xEE5DE0", VA = "0x180EE6DE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x69F6AC0", Offset = "0x69F5AC0", VA = "0x1869F6AC0")]
	public OKBKOLMLABP(int JMHKCKOMKMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x69F50C0", Offset = "0x69F40C0", VA = "0x1869F50C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x69F6640", Offset = "0x69F5640", VA = "0x1869F6640")]
	public void NNJJIJJFMLO(JobHandle JKLBGOBBIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x69F62C0", Offset = "0x69F52C0", VA = "0x1869F62C0")]
	public void JNPHKEODGAB(LNOKEKHCDKH AHGAPHMJDIB, NNIBPMAKIDL NCJOEJFJPMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x69F64F0", Offset = "0x69F54F0", VA = "0x1869F64F0")]
	public void LGGFFEPBADF(MMACAKIAGAC AHGAPHMJDIB, NativeArray<LIICCIDLFKB> BKIHIAJEEJJ, int LLEMLEJAAAD, int DKMKGMBDOFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x69F5280", Offset = "0x69F4280", VA = "0x1869F5280")]
	public JobHandle GEBPGOPLKPA(CMNEIJMNCCM ADFICGFKOJD, JCGKLBNACIG AFGOGLLKHMF, float3 NBEEPHINNNM, quaternion IMBEMBKMEKB, float EKHMPIIOPBG, bool EIDHDAEDBOH, int BDJEPMLMBNC = 0, int GIMEBLGBDNA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x69F4D80", Offset = "0x69F3D80", VA = "0x1869F4D80")]
	public static JobHandle DIPGHEOGJAP(FIEMKMFBNNI AGBIAAMKLPI, CMNEIJMNCCM ADFICGFKOJD, LNOKEKHCDKH AHGAPHMJDIB, JobHandle JKLBGOBBIDA)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x69F6810", Offset = "0x69F5810", VA = "0x1869F6810")]
	public static JobHandle OHOPEHOMMOG(CHFPFFOEFPC AGBIAAMKLPI, CMNEIJMNCCM ADFICGFKOJD, MMACAKIAGAC AHGAPHMJDIB, NativeArray<LIICCIDLFKB> BKIHIAJEEJJ, int LLEMLEJAAAD, int DKMKGMBDOFG, JobHandle JKLBGOBBIDA)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct LNNPJLHKLGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 IEOGBNCKHJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 IAPOJLIJOAH;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class PIJGOKFGEBP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<LNNPJLHKLGP> HJCIAMLHGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> FCMEANHOHKJ;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x85BDB0", Offset = "0x85ADB0", VA = "0x18085BDB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GLOPGFJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x854630", Offset = "0x853630", VA = "0x180854630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x69F6E10", Offset = "0x69F5E10", VA = "0x1869F6E10")]
	public PIJGOKFGEBP(int ADJOHKACAAE, int DKOMKGMJOOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x69F6CD0", Offset = "0x69F5CD0", VA = "0x1869F6CD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x69F6D30", Offset = "0x69F5D30", VA = "0x1869F6D30")]
	public void NGJBLAFJBEA(PIJGOKFGEBP OCAGJCFOOBK, int IEOMEAFKOML, int EFHNBALPFBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class GMBEDNPPEFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static PIJGOKFGEBP OMOLJBBOEFE;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<LCKIKCODBJD> GOKDGGMEMBF;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] OPPCIJCKJLJ;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool CCFOANOGCGO;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, PIJGOKFGEBP> AKNFKPJFIHM;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, PIJGOKFGEBP> CONEFPEAJFN;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool BDOHECBMLKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x69E52D0", Offset = "0x69E42D0", VA = "0x1869E52D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<LCKIKCODBJD> JNOLJACCKCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x69E3EF0", Offset = "0x69E2EF0", VA = "0x1869E3EF0")]
		get
		{
			return default(NativeList<LCKIKCODBJD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static PIJGOKFGEBP DMPMEHIOFLD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x69E4250", Offset = "0x69E3250", VA = "0x1869E4250")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x69E4910", Offset = "0x69E3910", VA = "0x1869E4910")]
	private static void JIGADFLNPBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x69E3D30", Offset = "0x69E2D30", VA = "0x1869E3D30")]
	public static int BEOOCMJGEAI(bool DCGDCHJIOGO, int OAFHMLNEOEH, bool MGBBECGCLJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x69E4F60", Offset = "0x69E3F60", VA = "0x1869E4F60")]
	private static int KEJDCPAPKIB(int OAFHMLNEOEH, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x69E3FB0", Offset = "0x69E2FB0", VA = "0x1869E3FB0")]
	private static int GCCAGCBNIAM(int OAFHMLNEOEH, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x69E3E60", Offset = "0x69E2E60", VA = "0x1869E3E60")]
	public static int DJNGCNAGDBP(int HCJLPFCODLH, int OAFHMLNEOEH, int LAKDDFDPBKC, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x69E4380", Offset = "0x69E3380", VA = "0x1869E4380")]
	public static int IOKAKODCKAK(int HCJLPFCODLH, int OAFHMLNEOEH, int LAKDDFDPBKC, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x69E52C0", Offset = "0x69E42C0", VA = "0x1869E52C0")]
	public static int OHGKCOFJLLH(int LAKDDFDPBKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x69E3D60", Offset = "0x69E2D60", VA = "0x1869E3D60")]
	private static int BJFLGHFJKAA(int OAFHMLNEOEH, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x69E4360", Offset = "0x69E3360", VA = "0x1869E4360")]
	private static int IMFCHMOPDPI(int OAFHMLNEOEH, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x69E42F0", Offset = "0x69E32F0", VA = "0x1869E42F0")]
	public static int IBJPLHCOJIH(int HCJLPFCODLH, int OAFHMLNEOEH, int LAKDDFDPBKC, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x69E3CA0", Offset = "0x69E2CA0", VA = "0x1869E3CA0")]
	public static int AFHFGNFANBO(int HCJLPFCODLH, int OAFHMLNEOEH, int LAKDDFDPBKC, bool MGFKIODJAEA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x69E3F90", Offset = "0x69E2F90", VA = "0x1869E3F90")]
	public static int EJCHDDIMPFN(int LAKDDFDPBKC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69E3D70", Offset = "0x69E2D70", VA = "0x1869E3D70")]
	public static PIJGOKFGEBP BPBKPPKIMAF(int OAFHMLNEOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x69E3FC0", Offset = "0x69E2FC0", VA = "0x1869E3FC0")]
	private static PIJGOKFGEBP HNDOBAKGHBN(int OAFHMLNEOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x69E4410", Offset = "0x69E3410", VA = "0x1869E4410")]
	public static PIJGOKFGEBP JAFGAECBCKN(int OAFHMLNEOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x69E4F80", Offset = "0x69E3F80", VA = "0x1869E4F80")]
	private static PIJGOKFGEBP LBOEPKPMBOL(int OAFHMLNEOEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x69E4500", Offset = "0x69E3500", VA = "0x1869E4500")]
	public static void JGHMEEMECOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MMACAKIAGAC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int GDIDEDJAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 KLLHIPALAKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion LEJLKNKGLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float AOKPEOPMCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float FIKMLMGJALI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int DKEDIIKAFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int JCCNEGPADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int OGLLBELALLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool FLEHGCPJPOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool KMDHPDMJKNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float JALCCPOJFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 ONKJGLPLJOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool GGGOEBNDIAG;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct BDNNLHEHNGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int BFLPLHJEGHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int EOLELOKMMLL;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct CHFPFFOEFPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<MMACAKIAGAC> JOIFMICJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<LIICCIDLFKB> MOKOACIJLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<LCKIKCODBJD> GFKCNEFLGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<BDNNLHEHNGA> AGBBBLEBAMC;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x69DD610", Offset = "0x69DC610", VA = "0x1869DD610")]
	public CHFPFFOEFPC(NativeArray<LIICCIDLFKB> MOKOACIJLJL, int GHACOABIHDA = 1, Allocator OOMMBGGEBLM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x69DD520", Offset = "0x69DC520", VA = "0x1869DD520", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct IPGDHBHBCKP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<LNNPJLHKLGP> GCDBKAMLLMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> BEJIOGMEKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<LCKIKCODBJD> NOPFLHLIFIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<MMACAKIAGAC> JOIFMICJFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<LIICCIDLFKB> MOKOACIJLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<LCKIKCODBJD> GFKCNEFLGJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<BDNNLHEHNGA> AGBBBLEBAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int KLDMGGHJJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int JJCDMOJDIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 POPMPMBLCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion GJDLCLEFOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 CPEAGDMFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DONDPODEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CHLEMPDAGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KJOOBKMPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AJKAGPKMOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EOPJPJCHCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FACGPEGJEHM;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x69F2E20", Offset = "0x69F1E20", VA = "0x1869F2E20")]
	public IPGDHBHBCKP(OKBKOLMLABP FLOGHDKBAEO, CMNEIJMNCCM PFCJLCNDPCB, float3 BCBCNOBNGBM, quaternion KOAOGECOGGB, float JFMFIPJPAOB, int BDJEPMLMBNC = 0, int GIMEBLGBDNA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x69F2BF0", Offset = "0x69F1BF0", VA = "0x1869F2BF0")]
	public IPGDHBHBCKP(CHFPFFOEFPC FLOGHDKBAEO, CMNEIJMNCCM PFCJLCNDPCB, float3 BCBCNOBNGBM, quaternion KOAOGECOGGB, float3 JFMFIPJPAOB, int BDJEPMLMBNC = 0, int GIMEBLGBDNA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x69F2AC0", Offset = "0x69F1AC0", VA = "0x1869F2AC0")]
	private float3 OODJMJLGOBP(float3 KFKCOGHKNDN, Matrix4x4 JPONLMNGANP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x69F25E0", Offset = "0x69F15E0", VA = "0x1869F25E0")]
	private float3x3 KDMCPMKPOGF(float3x3 BDIGIMOKHAG, float3x3 PMBJKFKLBPA)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x69F12C0", Offset = "0x69F02C0", VA = "0x1869F12C0")]
	private float DPDHDBLKKOK(float FHBDGLOPEKN, float BOJKEFIMIOG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x69F12D0", Offset = "0x69F02D0", VA = "0x1869F12D0", Slot = "4")]
	public void Execute(int NHKHFGOJKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x69F2470", Offset = "0x69F1470", VA = "0x1869F2470")]
	private void FMNMIOHBKBB(int JGJGLBINEOL, float3 LLLHNMGEKPM, float3 NJOPFIOMLFB, float3 KGIJHOHKCND, float EGNBICILIGE, bool PJGEPOFAEBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x69F2660", Offset = "0x69F1660", VA = "0x1869F2660")]
	private void OOAPPHNBHFC(MMACAKIAGAC FBBNBINCBCL, float3 NPKPBDEJFNH, float3x3 BDNMFDAFNND, float FHBDGLOPEKN, int JHNKCEHHENO, int BAOAEPMJLPL, int BANDEDCPJOE, float FCEMFAMODEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x69F0C70", Offset = "0x69EFC70", VA = "0x1869F0C70")]
	private void COBMBAANAHP(int JGJGLBINEOL, int IGFDPEBDNIO, MMACAKIAGAC FBBNBINCBCL, float3 NPKPBDEJFNH, float3x3 BDNMFDAFNND, bool EMKMNGPGEAO, float FHBDGLOPEKN, int OPHKACPMGIP, int GIBPDBKBBCO, int BANDEDCPJOE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct FIEMKMFBNNI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<LNOKEKHCDKH> CFFIIAMPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<LCKIKCODBJD> NBPEHHDPHAI;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x69E3BB0", Offset = "0x69E2BB0", VA = "0x1869E3BB0")]
	public FIEMKMFBNNI(int GHACOABIHDA, Allocator OOMMBGGEBLM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x69E3B10", Offset = "0x69E2B10", VA = "0x1869E3B10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct HOGJLHNANEO : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum DGAMAKHDLFE
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
	private NativeList<float3> AJMLAGCKFIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> FCBHOLOIKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> NMDAKPFEGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> PEECMOFFKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> EIDKAPHFCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> AIKGAJAPPCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> JJANDPCOLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> GGMINKCJBMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<LCKIKCODBJD> ANIJCHAAFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<LNOKEKHCDKH> CFFIIAMPHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<LCKIKCODBJD> NBPEHHDPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int KLDMGGHJJFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int JJCDMOJDIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DONDPODEENP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CHLEMPDAGJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KJOOBKMPJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AJKAGPKMOHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> EOPJPJCHCNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> FACGPEGJEHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 CPEAGDMFKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion GJDLCLEFOGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 POPMPMBLCOO;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x69E6AC0", Offset = "0x69E5AC0", VA = "0x1869E6AC0")]
	public HOGJLHNANEO(OKBKOLMLABP FLOGHDKBAEO, CMNEIJMNCCM PFCJLCNDPCB, float3 BCBCNOBNGBM, quaternion KOAOGECOGGB, float JFMFIPJPAOB, int BDJEPMLMBNC = 0, int GIMEBLGBDNA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x69E68D0", Offset = "0x69E58D0", VA = "0x1869E68D0")]
	public HOGJLHNANEO(FIEMKMFBNNI AHGAPHMJDIB, CMNEIJMNCCM PFCJLCNDPCB, float3 BCBCNOBNGBM, quaternion KOAOGECOGGB, float3 JFMFIPJPAOB, int BDJEPMLMBNC = 0, int GIMEBLGBDNA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x69E58B0", Offset = "0x69E48B0", VA = "0x1869E58B0", Slot = "4")]
	public void Execute(int NHKHFGOJKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x69E54C0", Offset = "0x69E44C0", VA = "0x1869E54C0")]
	private void CGAEINHLMFE(float4x4 PKNJHGJGMIC, int NHKHFGOJKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x69E6860", Offset = "0x69E5860", VA = "0x1869E6860")]
	private DGAMAKHDLFE OCAIBKNPKMC(float3 NJOPFIOMLFB)
	{
		return default(DGAMAKHDLFE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x69E6810", Offset = "0x69E5810", VA = "0x1869E6810")]
	private float4 LBHJCIGGPEE(DGAMAKHDLFE LGHBAPMPPGG, int HCALFJOJKJO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x69E5870", Offset = "0x69E4870", VA = "0x1869E5870")]
	private float2 EEOILKMEFHJ(DGAMAKHDLFE LGHBAPMPPGG, float3 LLLHNMGEKPM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NNIBPMAKIDL
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum EIBPMKJOJMM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static NNIBPMAKIDL MEMMBNOMLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 ANCEDMGEKMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 MBJIPAAIHDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 ODOBBFBPIEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public EIBPMKJOJMM PNINAMLCHFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 MFHPLMEMAKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 PEAJEIOIGBK;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool KJINILEJGLO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F890", Offset = "0x6A0E890", VA = "0x186A0F890")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 HOCBALNJMAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6A0F080", Offset = "0x6A0E080", VA = "0x186A0F080")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FA10", Offset = "0x6A0EA10", VA = "0x186A0FA10")]
	public NNIBPMAKIDL(float3 LLLHNMGEKPM, quaternion BCKIPOGEHOJ, float3 GHACOABIHDA, EIBPMKJOJMM HNGLFCFOHLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F160", Offset = "0x6A0E160", VA = "0x186A0F160")]
	public float EBPOMHFMEGD(float3 NPKPBDEJFNH, float FDCMIJDLJMG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F7A0", Offset = "0x6A0E7A0", VA = "0x186A0F7A0")]
	public bool IBKNONGHHPJ(float3 NJOPFIOMLFB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F360", Offset = "0x6A0E360", VA = "0x186A0F360")]
	public void EHDDNNLAEAM(float3 DHIGNEDKIEE, float3x3 JBJGPLBLHDH, float AKCMPKGFFJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F8A0", Offset = "0x6A0E8A0", VA = "0x186A0F8A0")]
	private void PANENDHJLOJ(float3 GMKCAOILOEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6A0F510", Offset = "0x6A0E510", VA = "0x186A0F510")]
	public void EIHJBNBNDBL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct LLIIAGIOLLJ : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<NNIBPMAKIDL> AHGAPHMJDIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> CBPAKFMMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> FIEKLFJCNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> LLNMIGHHLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<LCKIKCODBJD> NBPEHHDPHAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int JLNKCIJGMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int KHFNFBBHJCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float FDCMIJDLJMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float MJPBPPHOOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> OPIPGFFOMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> HBBHGNPJAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> AFLFICBEHKF;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A0EFE0", Offset = "0x6A0DFE0", VA = "0x186A0EFE0")]
	public LLIIAGIOLLJ(CMNEIJMNCCM EIOKGMMIDKC, float HOJHCJIOPPD, int EFHNBALPFBO, int JHNKCEHHENO, NativeList<NNIBPMAKIDL> AHGAPHMJDIB, NativeArray<int> LLNMIGHHLPC, NativeList<LCKIKCODBJD> NBPEHHDPHAI, JCGKLBNACIG AFGOGLLKHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E8A0", Offset = "0x6A0D8A0", VA = "0x186A0E8A0", Slot = "4")]
	public void Execute(int KKKOBCEKNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E7E0", Offset = "0x6A0D7E0", VA = "0x186A0E7E0")]
	private bool DFGDFIKKKFM(NNIBPMAKIDL MHGINKKGGNL, NNIBPMAKIDL JCHFDOINNOA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E540", Offset = "0x6A0D540", VA = "0x186A0E540")]
	private bool CEHJKOEMLFO(NNIBPMAKIDL DJLAMFBMAEO, int LANNOLHKKEG, int LAGPAIIEOLB, int NHLNENAGILI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class JCGKLBNACIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> PHFHJINLJIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> GLPNBKNBJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> IPJLJPLAAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> JKELAPCMJGI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CE20", Offset = "0x6A0BE20", VA = "0x186A0CE20")]
	public void BDBFLFOLMOK(int ADJOHKACAAE, int DKOMKGMJOOP, Allocator OOMMBGGEBLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D120", Offset = "0x6A0C120", VA = "0x186A0D120")]
	public static long ODLDEEOEKIF(int ADJOHKACAAE, int DKOMKGMJOOP)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A0CF40", Offset = "0x6A0BF40", VA = "0x186A0CF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D030", Offset = "0x6A0C030", VA = "0x186A0D030")]
	public void NNJJIJJFMLO(JobHandle JKLBGOBBIDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x85EB60", Offset = "0x85DB60", VA = "0x18085EB60")]
	public JCGKLBNACIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct EFNCHIJIPHP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> CBPAKFMMJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> CKLECABJJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> CJFJMKOLFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> NLOPPFAEFMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> FIEKLFJCNCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HLMADOJIIPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> NKNEBAMHDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> OPIPGFFOMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> HBBHGNPJAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int BDJEPMLMBNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int GIMEBLGBDNA;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6A020B0", Offset = "0x6A010B0", VA = "0x186A020B0")]
	public EFNCHIJIPHP(CMNEIJMNCCM EIOKGMMIDKC, JCGKLBNACIG AFGOGLLKHMF, int GIMEBLGBDNA = 0, int BDJEPMLMBNC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A01C70", Offset = "0x6A00C70", VA = "0x186A01C70", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A02050", Offset = "0x6A01050", VA = "0x186A02050")]
	private void HAEIPDHEIMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class EBOKOBFIIEK
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2A30EC0", Offset = "0x2A2FEC0", VA = "0x182A30EC0")]
	public static bool EHOHMGFMCMP<T>(NativeArray<T> IKONNGGNFPH, int GHACOABIHDA, Allocator OOMMBGGEBLM, NativeArrayOptions OLBNLJKBNFE = NativeArrayOptions.ClearMemory, int JDFHLIDBAOH = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2A31020", Offset = "0x2A30020", VA = "0x182A31020")]
	public static bool EHOHMGFMCMP<T>(NativeList<T> IEKJOJONGFC, int GHACOABIHDA, Allocator OOMMBGGEBLM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum MOICOBIJLEG
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
public interface FOONFJIICKF
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GNAEAJDILIG(MOICOBIJLEG HCJLPFCODLH);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AHGFONLBAOF(MOICOBIJLEG HCJLPFCODLH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds JCBKEGEJPJB();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float FKKKMEBIBDG();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LMCPCEBEJKN(MOICOBIJLEG HCJLPFCODLH, OKBKOLMLABP PPIFNKIDFOO, int DEEGLJPAHEF = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class JOJFBPMKODH
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D140", Offset = "0x6A0C140", VA = "0x186A0D140")]
	public static void JGHMEEMECOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class DLMKKOOFOHP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> CCAJPNAKLNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> DEOEDIKAGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> NBPDDKGIKAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> AAHEKHDALLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> AGNDILHPJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> DMDBDIOGFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> IHMLEPNJEGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> EPBOACLNBDC;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6A007D0", Offset = "0x69FF7D0", VA = "0x186A007D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GLOPGFJKDNE
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6A00C60", Offset = "0x69FFC60", VA = "0x186A00C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int COCFEDKGEAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6A00920", Offset = "0x69FF920", VA = "0x186A00920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6A019A0", Offset = "0x6A009A0", VA = "0x186A019A0")]
	public DLMKKOOFOHP(int ADJOHKACAAE, int DKOMKGMJOOP, int ACAACJJEEDP, Allocator OOMMBGGEBLM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6A016B0", Offset = "0x6A006B0", VA = "0x186A016B0")]
	public DLMKKOOFOHP(Mesh EIOKGMMIDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6A00810", Offset = "0x69FF810", VA = "0x186A00810", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6A00960", Offset = "0x69FF960", VA = "0x186A00960")]
	public void NGJBLAFJBEA(DLMKKOOFOHP EIOKGMMIDKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6A01220", Offset = "0x6A00220", VA = "0x186A01220")]
	private void NNLMCJLAJCM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A00CA0", Offset = "0x69FFCA0", VA = "0x186A00CA0")]
	private void NJMEKFPOECP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct LCKIKCODBJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int KFAPLBKFCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int ILCNKKELGNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int PDGADJNEFLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int GLOPGFJKDNE;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x14EE520", Offset = "0x14ED520", VA = "0x1814EE520")]
	public LCKIKCODBJD(int JHNKCEHHENO, int LLEMLEJAAAD, int EFHNBALPFBO, int DKMKGMBDOFG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class JPPIMJMICNO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<LCKIKCODBJD> DFNBGNCLBCH
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x9A27D0", Offset = "0x9A17D0", VA = "0x1809A27D0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<LCKIKCODBJD>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA892A0", Offset = "0xA882A0", VA = "0x180A892A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public DLMKKOOFOHP HKLIHKIIEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x854640", Offset = "0x853640", VA = "0x180854640")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x854650", Offset = "0x853650", VA = "0x180854650")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D300", Offset = "0x6A0C300", VA = "0x186A0D300")]
	public JPPIMJMICNO(IEnumerable<DLMKKOOFOHP> GLGPDGOKHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D290", Offset = "0x6A0C290", VA = "0x186A0D290", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum HODKMJPODPC
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class DHLLMADHABF
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> ENKIICIHDBD;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> BGCCMKLJPLO;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> ECJLCIDNFJG;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> PLNCCBKKGHM;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A00490", Offset = "0x69FF490", VA = "0x186A00490")]
	public static void JGHMEEMECOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A005B0", Offset = "0x69FF5B0", VA = "0x186A005B0")]
	public static NativeArray<float2> LAPIOENJPOH(NativeArray<float2> GPCHLPNOGHJ, int OAOKHHFAFIF, NativeArray<float2> FBLDJDEDNNB, int ANHOHLOFPND)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A006C0", Offset = "0x69FF6C0", VA = "0x186A006C0")]
	public static NativeArray<float3> MCAIMHCGFLH(NativeArray<float3> GPCHLPNOGHJ, int OAOKHHFAFIF, NativeArray<float3> FBLDJDEDNNB, int ANHOHLOFPND)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A00270", Offset = "0x69FF270", VA = "0x186A00270")]
	public static NativeArray<float4> ANGHLCPGOCC(NativeArray<float4> GPCHLPNOGHJ, int OAOKHHFAFIF, NativeArray<float4> FBLDJDEDNNB, int ANHOHLOFPND)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A00380", Offset = "0x69FF380", VA = "0x186A00380")]
	public static NativeArray<int> BCELOGDEFEL(NativeArray<int> GPCHLPNOGHJ, int OAOKHHFAFIF, NativeArray<int> FBLDJDEDNNB, int ANHOHLOFPND)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2A0E810", Offset = "0x2A0D810", VA = "0x182A0E810")]
	private static void BOMJOLMMKHN<T>(NativeArray<T> IKONNGGNFPH, int PNHMBBDLKBL) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2A0EA10", Offset = "0x2A0DA10", VA = "0x182A0EA10")]
	private static void EBEIPPNMOOD<T>(NativeArray<T> GPCHLPNOGHJ, int OAOKHHFAFIF, NativeArray<T> FBLDJDEDNNB, int ANHOHLOFPND, NativeArray<T> PHGLIKIPPKF) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class KDCMKJCFNDB
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct NINJIIDPBNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort PONGAOGJLMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort FOJLHADHAPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort PFLPHJPEKJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort DPCHMONPNJD;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E4A0", Offset = "0x6A0D4A0", VA = "0x186A0E4A0")]
	public static uint OAJPBNJLIHJ(float MNEDFKLCMJL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DF90", Offset = "0x6A0CF90", VA = "0x186A0DF90")]
	public static void EKJDCOPLKFI(float4 CJFJMKOLFKB, float MDKGPJGDEGB, [Out] uint CCADKMBDAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DEC0", Offset = "0x6A0CEC0", VA = "0x186A0DEC0")]
	public static void EKJDCOPLKFI(float4 CJFJMKOLFKB, uint GGLLECIDAOF, [Out] uint CCADKMBDAGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DC70", Offset = "0x6A0CC70", VA = "0x186A0DC70")]
	public static void EBBKFNELOMI(float3 OPAKFDIMEDP, float3 KAHDKPNLEKA, float4 CGOMPOGBPNJ, float2 OGJAPNIOAMF, float4 CJFJMKOLFKB, [Out] CMNEIJMNCCM.OIPIEAINKDK HIOEEEEBDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6A0DA10", Offset = "0x6A0CA10", VA = "0x186A0DA10")]
	public static void EBBKFNELOMI(float3 OPAKFDIMEDP, float3 KAHDKPNLEKA, float4 CGOMPOGBPNJ, float2 OGJAPNIOAMF, float4 CJFJMKOLFKB, [Out] CMNEIJMNCCM.DBGPDFEPPJJ HIOEEEEBDOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D930", Offset = "0x6A0C930", VA = "0x186A0D930")]
	public static byte CNEHIBBJNHO(float JJCEIJMGOAB)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D8E0", Offset = "0x6A0C8E0", VA = "0x186A0D8E0")]
	public static ushort CADLGPOBNOP(float JJCEIJMGOAB)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D8B0", Offset = "0x6A0C8B0", VA = "0x186A0D8B0")]
	public static uint BPLNOMNFPGK(float JJCEIJMGOAB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6A0D980", Offset = "0x6A0C980", VA = "0x186A0D980")]
	public static float2 DNHEPHLBPDB(float2 CKOKPBDJPNC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E200", Offset = "0x6A0D200", VA = "0x186A0E200")]
	public static float2 NFBFMBIHMKF(float3 BBIKELPGJLE)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E350", Offset = "0x6A0D350", VA = "0x186A0E350")]
	public static void NKNBNAJCPIJ(float3 JJCEIJMGOAB, [Out] float3 JIFGONINOJP, [Out] uint3 DPCHMONPNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6A0E0A0", Offset = "0x6A0D0A0", VA = "0x186A0E0A0")]
	public static NINJIIDPBNM IJLCEFCIONH(float3 LLLHNMGEKPM)
	{
		return default(NINJIIDPBNM);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BGOLFLPCOAK
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker KOMNOKPKCBO;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float LFDKMGKLNID;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void NGLKKFEILBD(bool BGGKDJEPLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x69F9C90", Offset = "0x69F8C90", VA = "0x1869F9C90")]
	public static void OCBHCNNMADP(float IGIIFGFPAFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class GBGBOPPOMJG
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum NGHKJAOHCAL
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
	public struct AKBEDNDCMIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public IEDOEEPMPLA EIOKGMMIDKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int MFAEDLLLGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int GNLFNNPGCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long CDBIGCBJKHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long EGGNKBKIDHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float BBDGDHBPCKJ;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x69F7370", Offset = "0x69F6370", VA = "0x1869F7370")]
		public void BEDHOPCKIAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x69F73A0", Offset = "0x69F63A0", VA = "0x1869F73A0")]
		public void NNJJIJJFMLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string HDLODOHDLCM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string MFDNKMLLCIA;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker KOMNOKPKCBO;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker OEJJECBKNNG;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker MICJKFOEAFM;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker CBFHFKOHDPL;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker PPFLLBBONNE;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker NOBHIIAFJFI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker FKCMBIOKLGI;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker JJGIAAAPDGG;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker CJFJFJPAANM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker BJBJMKNBPPN;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker DICMLMLHANB;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker MHBGNPGMEKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<FOONFJIICKF> HBBBNEHNIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly DIIOFOPNEPI COJJKBCGFMJ;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool IECOAFNKHJM = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int LLEMLEJAAAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int DKMKGMBDOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool KPONKLNJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool IAFJNLKCJFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool BKPADJOOKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal NGHKJAOHCAL JKKAFCBPEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool ILHCNKIOBLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 MNDJDNLCBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 LOJLPCBFNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float CMFMPEKCGNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float DPDBILDGBIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int JKGFNGBOPFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int JLPHIDCOCBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int KLKHKCDLPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int CJJGCCHLBLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float LKHNFDGEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float BPJOPLENLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int ABADHAFIMNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long FKEJGEJMADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long NCOGDCGPLIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long NCFAFOAHMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int NNGABIPDJHE;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int KIGAMHPODKD = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] DMJNCBJHAAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] BKGHDILELFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] JECCCJHCFNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<AKBEDNDCMIA> OIFCEKAJLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private CMNEIJMNCCM OPAGDGAHCPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long EKHJDKNJJLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long PEHMHJGEAJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int AKOHDGGKMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float FEECOAKFECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal CMNEIJMNCCM.BJCIBLNPBFK OBKFIBPFLNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool JGHJDCFJALG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private BGAMIHMKNPM NHEOEMBPGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle NIBCJEANKLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> NJBBLLNHNBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool IDOGMGHIJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle AIMOMNBFBBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private CMNEIJMNCCM AEHIOOGBIIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private JCGKLBNACIG NOPMLBDJHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform HLLDKHMPFPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private MOICOBIJLEG MALMKKIDFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long CIAGKKFAGIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long LKEEAPDIMGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long KLMNNPEGPKM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh HKLIHKIIEDI
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8515D0", Offset = "0x8505D0", VA = "0x1808515D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x855820", Offset = "0x854820", VA = "0x180855820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter MHHHHKJNNAB
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x855810", Offset = "0x854810", VA = "0x180855810")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer NCFOPKGBDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x851840", Offset = "0x850840", VA = "0x180851840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x851620", Offset = "0x850620", VA = "0x180851620")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> FLFLFOGNOFA
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8517B0", Offset = "0x8507B0", VA = "0x1808517B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8518E0", Offset = "0x8508E0", VA = "0x1808518E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int HJHGHILHMAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9739D0", Offset = "0x9729D0", VA = "0x1809739D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int POBOHGNOJCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x10F37D0", Offset = "0x10F27D0", VA = "0x1810F37D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int ILCNKKELGNG
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6A02130", Offset = "0x6A01130", VA = "0x186A02130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<FOONFJIICKF> PIMBLKBJCLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8518C0", Offset = "0x8508C0", VA = "0x1808518C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6A028E0", Offset = "0x6A018E0", VA = "0x186A028E0")]
	public void BHIEMBPNMAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6A07DB0", Offset = "0x6A06DB0", VA = "0x186A07DB0")]
	private void LAKEBEDFLPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C650", Offset = "0x6A0B650", VA = "0x186A0C650")]
	public GBGBOPPOMJG(string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A09C10", Offset = "0x6A08C10", VA = "0x186A09C10")]
	public void NNJJIJJFMLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6A02840", Offset = "0x6A01840", VA = "0x186A02840")]
	private void AOHFNCICAAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6A05AD0", Offset = "0x6A04AD0", VA = "0x186A05AD0")]
	private void EEJIDPDMNIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A080C0", Offset = "0x6A070C0", VA = "0x186A080C0")]
	public Mesh LFAJODEKMFK(MeshFilter HNDHIDBAEJB, Transform DBCCBLKNBHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A05F40", Offset = "0x6A04F40", VA = "0x186A05F40")]
	private void GDHJAKPDMHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A05570", Offset = "0x6A04570", VA = "0x186A05570")]
	public void CLDNNFBGPCO(FOONFJIICKF HGHCNCBMMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A05D00", Offset = "0x6A04D00", VA = "0x186A05D00")]
	public bool FHHAKPAHAGN(FOONFJIICKF HGHCNCBMMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A061D0", Offset = "0x6A051D0", VA = "0x186A061D0")]
	public bool HODGCICEPOA(FOONFJIICKF HGHCNCBMMIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6A0C1C0", Offset = "0x6A0B1C0", VA = "0x186A0C1C0", Slot = "4")]
	public virtual void OPJHIBBCFEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6A06230", Offset = "0x6A05230", VA = "0x186A06230")]
	public void IAHPLMIAOBD(Transform JJHJHNBEMKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A06440", Offset = "0x6A05440", VA = "0x186A06440")]
	private long IHGOEBNIEJD()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6A05DE0", Offset = "0x6A04DE0", VA = "0x186A05DE0")]
	private long FNGEFNDBIED()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6A044A0", Offset = "0x6A034A0", VA = "0x186A044A0")]
	public bool CKOMOILJDFN(Transform JJHJHNBEMKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6A03250", Offset = "0x6A02250", VA = "0x186A03250")]
	public bool CDFOLFOBBON(bool IIJCJGFFAJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6A09230", Offset = "0x6A08230", VA = "0x186A09230")]
	private void MENLCBJFMOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6A09D40", Offset = "0x6A08D40", VA = "0x186A09D40")]
	public bool OCBHCNNMADP(float4x4 NKKKCLCLIIH, BatchedMeshRenderer AEHKAGHAIDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6A099C0", Offset = "0x6A089C0", VA = "0x186A099C0")]
	public void MLNNGPKALAL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6A02150", Offset = "0x6A01150", VA = "0x186A02150")]
	public bool ALFDJCDCIFN(bool IIJCJGFFAJE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6A08530", Offset = "0x6A07530", VA = "0x186A08530")]
	public void LLMONJHPNKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6A07D80", Offset = "0x6A06D80", VA = "0x186A07D80")]
	public void KBHLIJNLMNA(CMNEIJMNCCM EIOKGMMIDKC, int HODGKIAKFIL, int LBKCIDDBLJC, float KLEPCLDILFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6A07070", Offset = "0x6A06070", VA = "0x186A07070")]
	public void JKMLMMBFAOC(IEDOEEPMPLA AIIGNGFBDPO, int HODGKIAKFIL, int LBKCIDDBLJC, float KLEPCLDILFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A09BA0", Offset = "0x6A08BA0", VA = "0x186A09BA0")]
	public (long, long, long) NCEPJFDMJEM()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0xB266F0", Offset = "0xB256F0", VA = "0x180B266F0")]
	public long NCGHENEHNIE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A056D0", Offset = "0x6A046D0", VA = "0x186A056D0")]
	private void EDAEPHMGFAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6A081B0", Offset = "0x6A071B0", VA = "0x186A081B0")]
	public (long, long) LJHIAHMOLAE(float PADADPJLPGI, float4x4 NKKKCLCLIIH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public void HFMOJEPINDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6A02720", Offset = "0x6A01720", VA = "0x186A02720")]
	internal void AOFAMAPNLFD(NGHKJAOHCAL CJMCBEHMGGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6A068B0", Offset = "0x6A058B0", VA = "0x186A068B0")]
	private (float, float, float, float) JFJOKCIKBJE(float KAFABPDIFFA, float4x4 NKKKCLCLIIH)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6A05D80", Offset = "0x6A04D80", VA = "0x186A05D80")]
	private float FNEENIADDGP(float KAFABPDIFFA, float4x4 NKKKCLCLIIH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6A023E0", Offset = "0x6A013E0", VA = "0x186A023E0")]
	private (int, int) ANBJJOLJMHM(float DECDDCGNBNO)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6A0B210", Offset = "0x6A0A210", VA = "0x186A0B210")]
	public void OJJAODOLGGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6A05BB0", Offset = "0x6A04BB0", VA = "0x186A05BB0")]
	private void FBBDGIMAJGA(CMNEIJMNCCM DBMOLFCOOKN, CMNEIJMNCCM.BJCIBLNPBFK BJGJALGFOFB, bool IMIIKJIDGII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A05C00", Offset = "0x6A04C00", VA = "0x186A05C00")]
	private void FBBDGIMAJGA([In] IEDOEEPMPLA DBMOLFCOOKN, CMNEIJMNCCM.BJCIBLNPBFK BJGJALGFOFB, bool IMIIKJIDGII = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A07320", Offset = "0x6A06320", VA = "0x186A07320")]
	private void JMIDJDCHNBJ(CMNEIJMNCCM.BJCIBLNPBFK BJGJALGFOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A07040", Offset = "0x6A06040", VA = "0x186A07040")]
	private void JIBCOIACFFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A06500", Offset = "0x6A05500", VA = "0x186A06500")]
	private void JAHLKFHOEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6A073C0", Offset = "0x6A063C0", VA = "0x186A073C0")]
	public long JNDPMNALDGB(long JPBEBJJPDMA, int BNNKJEGMJGD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6A08540", Offset = "0x6A07540", VA = "0x186A08540")]
	private void MDIFHJMIKDI(CMNEIJMNCCM FLNLKCDGDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6A040C0", Offset = "0x6A030C0", VA = "0x186A040C0")]
	private void CKDNDOBDMBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6A06820", Offset = "0x6A05820", VA = "0x186A06820")]
	private float JFGPKEBPFEN(int FJNHJICCFJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6A028F0", Offset = "0x6A018F0", VA = "0x186A028F0")]
	private void BKHGEFGDCOH(CMNEIJMNCCM EIOKGMMIDKC, MAFLKBJMMBN AIIGNGFBDPO, int HODGKIAKFIL, int LBKCIDDBLJC, float KLEPCLDILFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct BGAMIHMKNPM : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct OHJOCHKBGKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int APMKNCENMEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int LBLPOJLKKBL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int KPGCPBCGJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int GFHOGCPJION;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int JBIFAGCAEEN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int BGLDDFMAOCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int MFAEDLLLGAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int GNLFNNPGCND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float BBDGDHBPCKJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct OOKOFPGFMKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public JALIAMGFNHF.OPCAKNMLDHE JPDNGKCKMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float CFCJHKDJOBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float OPEKLDDJDEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float DECLCOPIJFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float KLAKHKIEDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float MHMBPAOMLLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float ILGEBOLLPAB;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct IBHLNMFPCPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> CCAJPNAKLNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> DEOEDIKAGLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> CDABJBJKPFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> LPNHBEFOIAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> AMLJIHKJAKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> EPBOACLNBDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool IKKBFMNNJKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int ILCNKKELGNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int GLOPGFJKDNE;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6A0C930", Offset = "0x6A0B930", VA = "0x186A0C930")]
		public void BDBFLFOLMOK(int ADJOHKACAAE, int DKOMKGMJOOP, Allocator OOMMBGGEBLM, bool KHFMCGMFJNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6A0CB10", Offset = "0x6A0BB10", VA = "0x186A0CB10")]
		public static IBHLNMFPCPN IOCPCPCKPKO(CMNEIJMNCCM ABGFGEMBNMN)
		{
			return default(IBHLNMFPCPN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6A0CD60", Offset = "0x6A0BD60", VA = "0x186A0CD60")]
		public void NNJJIJJFMLO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker EJHMLABBMDE;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker LDHPGADLKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<OHJOCHKBGKP> AEBCOICJIAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private IBHLNMFPCPN EPGLBGMBFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private IBHLNMFPCPN FLNLKCDGDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 GLDNJICNPMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 HIPEOMMDKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private OOKOFPGFMKM ONBOAGLCLEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* JHGAEPMKINP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> PCMOMKBMAFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> HBBHGNPJAGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> EAGJKJCAGPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> PGFENPPEGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> OHBCDOFAKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> NMPOBIBFIHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> HLKMJCJPFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> NNOFJMLFMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> APHJPGJIKAM;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x69F9430", Offset = "0x69F8430", VA = "0x1869F9430")]
	public BGAMIHMKNPM([In] List<GBGBOPPOMJG.AKBEDNDCMIA> ICBPBOAMJKA, [In] CMNEIJMNCCM CDJKHHLHJHA, [In] GBGBOPPOMJG JOEJGIACACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x69F7A70", Offset = "0x69F6A70", VA = "0x1869F7A70", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x69F8A70", Offset = "0x69F7A70", VA = "0x1869F8A70")]
	public void NIAHPGLJLOP(List<GBGBOPPOMJG.AKBEDNDCMIA> DONDNFKKCJK, [In] GBGBOPPOMJG JOEJGIACACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69F8A50", Offset = "0x69F7A50", VA = "0x1869F8A50")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool MCELCINELFL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x69F7520", Offset = "0x69F6520", VA = "0x1869F7520")]
	private IEDOEEPMPLA DEINOFCEBFJ(int INDHPNDNDCP, Allocator OOMMBGGEBLM)
	{
		return default(IEDOEEPMPLA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x69F7AC0", Offset = "0x69F6AC0", VA = "0x1869F7AC0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void KPNPKBHFICD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x69F7750", Offset = "0x69F6750", VA = "0x1869F7750")]
	[IgnoreWarning(1371)]
	private OHJOCHKBGKP DIKHEBLKABA([In] OHJOCHKBGKP OHPCDGMPJGH, int OKLNBKNMLEM, [In] NativeArray<int> FIEKLFJCNCA, [In] NativeArray<bool> HBBHGNPJAGF, NativeArray<int> EAGJKJCAGPO)
	{
		return default(OHJOCHKBGKP);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x69F7420", Offset = "0x69F6420", VA = "0x1869F7420")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public int BNHFOLOEEAB(NativeArray<int> FIEKLFJCNCA, int JPOPLEHNFEI, int LLNCLGHCCCL, int PMHCCOKLEFN)
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
		public static readonly PHLKHBEJKKB log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker ALHGEOGMLDE;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker JBODNAELKHE;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker OKOPMACNEBI;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker ONNPJGAEMKO;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker EPOHIKEKKGC;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker PPFLLBBONNE;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker GBMCDPKMICP;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int IOMFFHKIJKF = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> LHHAKLCABDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<GBGBOPPOMJG>> ONFHNBJDNLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<GBGBOPPOMJG> BPLJJACLIAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> KIMDMFPLMHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private bool EEAODLFHKND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x39")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool ENCNONCICGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private int DBPNECIHPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private Dictionary<int, float> EGKACLDBELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Dictionary<int, Color> NCDAAGNCFIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Dictionary<int, Vector4> OCKFBJCJJIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Dictionary<int, Matrix4x4> AKBHNNNDKOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private GBGBOPPOMJG HPJCBDJEJJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private Material JJIMDIMAMAL;

		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private const int LEILAHEIJGF = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private static List<(long, Bounds, FOONFJIICKF)> POPLHEOGHIN;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> DFAAEFOPJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x851920", Offset = "0x850920", VA = "0x180851920")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int CPCLDOAIKKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6A00220", Offset = "0x69FF220", VA = "0x186A00220")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		private static void FENHPMLEIGK(bool BGGKDJEPLFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		private static void FENHPMLEIGK(bool BGGKDJEPLFN, string KKHEHGHPOAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x69FC1A0", Offset = "0x69FB1A0", VA = "0x1869FC1A0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x69FA290", Offset = "0x69F9290", VA = "0x1869FA290")]
		public GBGBOPPOMJG AddToBatchedMesh(FOONFJIICKF AIMBGKJIGKK, Material JNFDDANGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x69FF270", Offset = "0x69FE270", VA = "0x1869FF270")]
		public void RemoveFromBatchedMesh(FOONFJIICKF EIOKGMMIDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x69FAF40", Offset = "0x69F9F40", VA = "0x1869FAF40")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x69FFAA0", Offset = "0x69FEAA0", VA = "0x1869FFAA0")]
		public void SetMaterialProperty(int ILCJHJBBALD, Color NHCEIDKGILJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x69FF660", Offset = "0x69FE660", VA = "0x1869FF660")]
		public void SetMaterialProperty(int ILCJHJBBALD, float JJCEIJMGOAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x69FF880", Offset = "0x69FE880", VA = "0x1869FF880")]
		public void SetMaterialProperty(int ILCJHJBBALD, Vector4 DGKHLBNHMGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x69FF400", Offset = "0x69FE400", VA = "0x1869FF400")]
		public void SetMaterialProperty(int ILCJHJBBALD, Matrix4x4 PPOLMMJLLAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x69FA390", Offset = "0x69F9390", VA = "0x1869FA390")]
		private void BMHGOIIGBAG(Renderer EIOJIOLKBHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x69FB080", Offset = "0x69FA080", VA = "0x1869FB080")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x69FB070", Offset = "0x69FA070", VA = "0x1869FB070")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x69FA980", Offset = "0x69F9980", VA = "0x1869FA980")]
		private void CPDMILMIGPH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x69FBF80", Offset = "0x69FAF80", VA = "0x1869FBF80")]
		private GBGBOPPOMJG OHGMOFLJENM(FOONFJIICKF EIOKGMMIDKC, Material JNFDDANGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x69FB780", Offset = "0x69FA780", VA = "0x1869FB780")]
		private GBGBOPPOMJG KABEEPCPJLJ(Material JNFDDANGPCP, int KCBJOLEFBNK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x69FC400", Offset = "0x69FB400", VA = "0x1869FC400")]
		private GBGBOPPOMJG PHFLCOGBJAE(Material JNFDDANGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x69FB660", Offset = "0x69FA660", VA = "0x1869FB660")]
		private List<Material> JBKODFMFDAL(Material JNFDDANGPCP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x1995340", Offset = "0x1994340", VA = "0x181995340")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x69FBA70", Offset = "0x69FAA70", VA = "0x1869FBA70")]
		public void MarkDirty(FOONFJIICKF EIOKGMMIDKC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x69FBC00", Offset = "0x69FAC00", VA = "0x1869FBC00")]
		public (long, long) MemorySizeInBytesForChosenDetail(float PADADPJLPGI)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x69FDF40", Offset = "0x69FCF40", VA = "0x1869FDF40")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x69FB120", Offset = "0x69FA120", VA = "0x1869FB120")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x69FCA40", Offset = "0x69FBA40", VA = "0x1869FCA40")]
		public void RebatchOptimally(int OFMGJCPCMBF, int PACBOAAJKPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x69FFFB0", Offset = "0x69FEFB0", VA = "0x1869FFFB0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class GHNECNLOHAI
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct BNCMDBHIBAK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public float NGLFEFNBMMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public BatchedMeshRenderer FNONKAAODGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public GBGBOPPOMJG GNIKGDEKOEC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public long DCIAGHFBOIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public float DEHMHDAJHCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public bool IGJPIFNIBIA;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class GLGJIENAPIE : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x9F2A60", Offset = "0x9F1A60", VA = "0x1809F2A60", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x6A15980", Offset = "0x6A14980", VA = "0x186A15980", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0xB5C8B0", Offset = "0xB5B8B0", VA = "0x180B5C8B0")]
		[DebuggerHidden]
		public GLGJIENAPIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A159D0", Offset = "0x6A149D0", VA = "0x186A159D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A14BE0", Offset = "0x6A13BE0", VA = "0x186A14BE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A14B90", Offset = "0x6A13B90", VA = "0x186A14B90")]
		private void IKLMFKCBKPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6A15830", Offset = "0x6A14830", VA = "0x186A15830")]
		private void POOBBHLNDCF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6A15930", Offset = "0x6A14930", VA = "0x186A15930", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6A15880", Offset = "0x6A14880", VA = "0x186A15880", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6A15880", Offset = "0x6A14880", VA = "0x186A15880", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	public static readonly PHLKHBEJKKB IGEICKLFDBC;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker PPFLLBBONNE;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker GMGIFHLINNF;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker IFKLPHHCOIE;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker LNNOILPBBOO;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static float3 JEBJPAILBCE;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static int IHNLBMEFAFA;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int BCEEJAGGABO;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int LEPMAEBPKHJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int BLMDOBMDKID;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int HEPPHCGMDFD;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int FJJCJPHEKKH;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static long LGGGEFNAPAP;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long DKODLKDIBHH;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int IHCMJKIMLPA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static int ADHEDIDEAGC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static int OEKOFNCOFFH;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static float KNOBKAEGEJL;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static bool CAGEDLEHEAA;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static int HGANPAEDEDP;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static float AAHKLELKPLE;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float LLOKBMEMGLL;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float LDKAMCBMIDM;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float LBBFBJDDOOM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float OLNOFLOAPGH;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float OLBJKKCMAJA;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static float JDOIBMPEBGD;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float KCCOKBHFDDN;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static long KAGDKMAEOIL;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static bool MDPHEEIENAD;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static List<BatchedMeshRenderer> PLLCOFAFPDF;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static List<BNCMDBHIBAK> MBGENAKFCIN;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static Stack<CMNEIJMNCCM> MHENGHDIFGP;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static Stack<JCGKLBNACIG> MPCOMKJFNHN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool FGHPNIKIOLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6A10DB0", Offset = "0x6A0FDB0", VA = "0x186A10DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void FENHPMLEIGK(bool BGGKDJEPLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void NGLKKFEILBD(bool BGGKDJEPLFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	private static void FENHPMLEIGK(bool BGGKDJEPLFN, string KKHEHGHPOAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x853950", Offset = "0x852950", VA = "0x180853950")]
	public static void BEDHOPCKIAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A10320", Offset = "0x6A0F320", VA = "0x186A10320")]
	public static void ECOMMFKJNEE(BatchedMeshRenderer LNGCNMAMNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A10920", Offset = "0x6A0F920", VA = "0x186A10920")]
	public static void HPLNGDJJHDE(BatchedMeshRenderer LNGCNMAMNEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A118A0", Offset = "0x6A108A0", VA = "0x186A118A0")]
	private static (long, long, long) NHEPPPNCDOP(long IIAIHJAFIIE)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FDA0", Offset = "0x6A0EDA0", VA = "0x186A0FDA0")]
	public static bool AFBJPDINEIH(float BCBEMKEKDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A108A0", Offset = "0x6A0F8A0", VA = "0x186A108A0")]
	public static void HNGFGGCIJKJ(float BCBEMKEKDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A11790", Offset = "0x6A10790", VA = "0x186A11790")]
	public static bool MDJHOBLMJBL(float BCBEMKEKDGG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A11AF0", Offset = "0x6A10AF0", VA = "0x186A11AF0")]
	public static void OCBHCNNMADP(long IIAIHJAFIIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A10E40", Offset = "0x6A0FE40", VA = "0x186A10E40")]
	public static long JNDPMNALDGB(long JPBEBJJPDMA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6A144A0", Offset = "0x6A134A0", VA = "0x186A144A0")]
	public static void ODHNDJMBAJC(GBGBOPPOMJG GNIKGDEKOEC, BatchedMeshRenderer FNONKAAODGH, long DCIAGHFBOIB, float NGLFEFNBMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6A10480", Offset = "0x6A0F480", VA = "0x186A10480")]
	public static void GAALCOFEIPE(GBGBOPPOMJG GNIKGDEKOEC, BatchedMeshRenderer FNONKAAODGH, long DCIAGHFBOIB, float IGIIFGFPAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6A105B0", Offset = "0x6A0F5B0", VA = "0x186A105B0")]
	public static void GDOONJLMMKJ(GBGBOPPOMJG GNIKGDEKOEC, BatchedMeshRenderer FNONKAAODGH, long DCIAGHFBOIB, float IGIIFGFPAFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6A111E0", Offset = "0x6A101E0", VA = "0x186A111E0")]
	public static void KHJKJIGCAJG(GBGBOPPOMJG GNIKGDEKOEC, BatchedMeshRenderer FNONKAAODGH, long DCIAGHFBOIB, float BFKLNOELBNK, bool IGJPIFNIBIA, float NGLFEFNBMMA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FFC0", Offset = "0x6A0EFC0", VA = "0x186A0FFC0")]
	public static float DJFDMHIDCAF(long NNBLDJFFLLP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6A11400", Offset = "0x6A10400", VA = "0x186A11400")]
	public static (long, long) LJHIAHMOLAE(float PADADPJLPGI)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6A145E0", Offset = "0x6A135E0", VA = "0x186A145E0")]
	[IteratorStateMachine(typeof(GLGJIENAPIE))]
	public static IEnumerable<bool> PPCNHNICAOG(long PHNPCENNAFD, bool IPFHBLJGBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6A115D0", Offset = "0x6A105D0", VA = "0x186A115D0")]
	public static void MCIBPPACHBP(long PHNPCENNAFD, bool IPFHBLJGBGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6A119B0", Offset = "0x6A109B0", VA = "0x186A119B0")]
	public static int NJIGCOMPGHN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6A10740", Offset = "0x6A0F740", VA = "0x186A10740")]
	internal static CMNEIJMNCCM HBMBCJBJFKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6A10C90", Offset = "0x6A0FC90", VA = "0x186A10C90")]
	internal static void ICPDMGHCHGD(CMNEIJMNCCM NDGEAJNBIAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6A0FE60", Offset = "0x6A0EE60", VA = "0x186A0FE60")]
	internal static JCGKLBNACIG CAHCBPNKCNG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6A10D20", Offset = "0x6A0FD20", VA = "0x186A10D20")]
	internal static void ICPDMGHCHGD(JCGKLBNACIG AFGOGLLKHMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6A106F0", Offset = "0x6A0F6F0", VA = "0x186A106F0")]
	[CompilerGenerated]
	internal static void GMMJBGLJIGA(UnityEngine.Object NOPFNIKINJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class LJJHKIHANMP<KeyType> : GBGBOPPOMJG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F0")]
	private readonly Dictionary<KeyType, FOONFJIICKF> HAMCHFOGIMA;

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x42FB130", Offset = "0x42FA130", VA = "0x1842FB130")]
	public LJJHKIHANMP(string CKEJJGPNKGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x42FACE0", Offset = "0x42F9CE0", VA = "0x1842FACE0")]
	public void CLDNNFBGPCO(KeyType GMFCIHEFPPO, FOONFJIICKF HGHCNCBMMIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x42FAEF0", Offset = "0x42F9EF0", VA = "0x1842FAEF0")]
	public bool DLLPJODOBMN(KeyType GMFCIHEFPPO, FOONFJIICKF IPDIJFMALFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x42FAD50", Offset = "0x42F9D50", VA = "0x1842FAD50")]
	public void DHIBMHNPGCJ(KeyType GMFCIHEFPPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x42FB0D0", Offset = "0x42FA0D0", VA = "0x1842FB0D0", Slot = "4")]
	public override void OPJHIBBCFEP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x6A15AF0", Offset = "0x6A14AF0", VA = "0x186A15AF0")]
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
