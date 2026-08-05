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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
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
	public class LogRegistrationIndex : BGIOGCHCHCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6CCD040", Offset = "0x6CCBA40", VA = "0x186CCD040", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8C1980", Offset = "0x8C0380", VA = "0x1808C1980")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class JEMLCKEFMMF
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CMICIECANPG PNLNNKEAJLL;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly CMICIECANPG NEOMNBNIDOP;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly CMICIECANPG JDHLBKGEBMO;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class DOCKNNDOGKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public CFLKOMOGAPG NFDBNIDBLCF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KNHJBDAHGAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8961A0", Offset = "0x894BA0", VA = "0x1808961A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public DOCKNNDOGKM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct CFLKOMOGAPG
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct EOJKEPKKMBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half GIMMGMDPKGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort FJNOLCJHEJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte PGGABEJMFND;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker EPCLHEMLAOP;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker MHLONPOMHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KNHJBDAHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int EHANMNGLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> CPDNMEDJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> EOIJNLNANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<EOJKEPKKMBN> NMFFJMEBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> KGCCOGOONLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> HCMMOHLNFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 OKCFNICBICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 LIPKHMBFKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 CBENGDPLFDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 OAKBDDLJNNB;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long OGOBOHMEKJL;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long KINOJAJHMND;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float JBAFDLEIJLO;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool LMIOCCGHEAC;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6CBB420", Offset = "0x6CB9E20", VA = "0x186CBB420")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CEFHDIFPAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CB78D0", Offset = "0x6CB62D0", VA = "0x186CB78D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBE30", Offset = "0x6CBA830", VA = "0x186CBBE30")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9110", Offset = "0x6CB7B10", VA = "0x186CB9110")]
	public static CFLKOMOGAPG GMDNOGMNFLF(Allocator NPNPKHEIOHB, JOIDBGKONGK LIKPPJOMCFI)
	{
		return default(CFLKOMOGAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8B50", Offset = "0x6CB7550", VA = "0x186CB8B50")]
	public static CFLKOMOGAPG GMDNOGMNFLF(Allocator NPNPKHEIOHB, NativeArray<float3> MPCMCCFINGC, NativeArray<float3> JMALHMJAHAD, NativeArray<float2> PPLHDGNCJBP, NativeArray<float4> DLHFCHEPLOH, bool EKNKGCBLBBE, NativeArray<float4> ONIEKFIGDDF, NativeArray<int> PONGLDBFKNH, int KNHJBDAHGAE, int IHFHJLPHIFK, int EHANMNGLAMC, int JJEEHICMMPC)
	{
		return default(CFLKOMOGAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB9D80", Offset = "0x6CB8780", VA = "0x186CB9D80")]
	public JOIDBGKONGK HGAGKNOIJAH(Allocator NPNPKHEIOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAC70", Offset = "0x6CB9670", VA = "0x186CBAC70")]
	public void KBFNHGEPLCH(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE4F0", Offset = "0x6CBCEF0", VA = "0x186CBE4F0")]
	private void OMMJNOLINOB(Mesh CBNKKMIFMKD, NativeArray<ushort> HOEKGNMBAOO, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CB58A0", Offset = "0x6CB42A0", VA = "0x186CB58A0")]
	public void CGFLFOIBMEO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7AD0", Offset = "0x6CB64D0", VA = "0x186CB7AD0")]
	public void FNNDPFCCMFI(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6CBCA90", Offset = "0x6CBB490", VA = "0x186CBCA90")]
	public void MIMADDFEGCH(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDBC0", Offset = "0x6CBC5C0", VA = "0x186CBDBC0")]
	public void OLADNJMPJFO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CB93E0", Offset = "0x6CB7DE0", VA = "0x186CB93E0")]
	public void HFHIGPECFKC(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC2E0", Offset = "0x6CBACE0", VA = "0x186CBC2E0")]
	public void LPCHLOOIKAH(Mesh CBNKKMIFMKD, JOIDBGKONGK.NGBKHNBLCFF OJCKNPDLJJF, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5620", Offset = "0x6CB4020", VA = "0x186CB5620")]
	public long AJMCHHNECGH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7A60", Offset = "0x6CB6460", VA = "0x186CB7A60")]
	public long FJAOELNFMLO(JOIDBGKONGK.NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA0B0", Offset = "0x6CB8AB0", VA = "0x186CBA0B0")]
	private void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB, bool PNPKPDDLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6860", Offset = "0x6CB5260", VA = "0x186CB6860")]
	private void DLDHODBHDDG(NativeArray<float3> NFJEDNOAEPA, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3CC0", Offset = "0x6CB26C0", VA = "0x186CB3CC0")]
	[BurstCompile]
	private unsafe static void DLDHODBHDDG([NoAlias] float3* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB56E0", Offset = "0x6CB40E0", VA = "0x186CB56E0")]
	[BurstCompile]
	private unsafe static void BGOHKDPIIKP([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD660", Offset = "0x6CBC060", VA = "0x186CBD660")]
	[BurstCompile]
	private unsafe static void MOPCKPPDDFC([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB360", Offset = "0x6CB9D60", VA = "0x186CBB360")]
	[BurstCompile]
	private unsafe static void NJMPEALMNKE([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB360", Offset = "0x6CB9D60", VA = "0x186CBB360")]
	[BurstCompile]
	private unsafe static void KLDNIHJAMON([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD500", Offset = "0x6CBBF00", VA = "0x186CBD500")]
	[BurstCompile]
	private unsafe static void MKODBKNNIEH([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6950", Offset = "0x6CB5350", VA = "0x186CB6950")]
	private void DLNNNFKKICK(NativeArray<float3> MPCMCCFINGC, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CB3F10", Offset = "0x6CB2910", VA = "0x186CB3F10")]
	[BurstCompile]
	private unsafe static void DLNNNFKKICK([NoAlias] ushort* NFJEDNOAEPA, [Out] float3 FHLBFPOLBBP, [Out] float3 LIPKHMBFKNJ, [In][NoAlias] float3* MPCMCCFINGC, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5540", Offset = "0x6CB3F40", VA = "0x186CB5540")]
	private void AAHJAGABCNC(NativeArray<float3> JMALHMJAHAD, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CB5280", Offset = "0x6CB3C80", VA = "0x186CB5280")]
	[BurstCompile]
	private unsafe static void AAHJAGABCNC([NoAlias] ushort* HFKGOGOGEDG, [In][NoAlias] float3* JMALHMJAHAD, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA560", Offset = "0x6CB8F60", VA = "0x186CBA560")]
	private void IFKJKOGLDDM(NativeArray<float3> CMKLLDJNKKJ, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA620", Offset = "0x6CB9020", VA = "0x186CBA620")]
	[BurstCompile]
	private unsafe static void IFKJKOGLDDM([NoAlias] float3* CMKLLDJNKKJ, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CB76A0", Offset = "0x6CB60A0", VA = "0x186CB76A0")]
	[BurstCompile]
	private unsafe static void FDPFOBBFEKF([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CB62B0", Offset = "0x6CB4CB0", VA = "0x186CB62B0")]
	[BurstCompile]
	private unsafe static void CMOGOILAIHK([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB730", Offset = "0x6CBA130", VA = "0x186CBB730")]
	[BurstCompile]
	private unsafe static void LDNMKBPJKIP([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7910", Offset = "0x6CB6310", VA = "0x186CB7910")]
	[BurstCompile]
	private unsafe static void FGFMAKBNICM([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8540", Offset = "0x6CB6F40", VA = "0x186CB8540")]
	[BurstCompile]
	private unsafe static void GGMMNIPNHEI([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CB86A0", Offset = "0x6CB70A0", VA = "0x186CB86A0")]
	private void GJDNDAOJHNI(NativeArray<float2> PPLHDGNCJBP, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8790", Offset = "0x6CB7190", VA = "0x186CB8790")]
	[BurstCompile]
	private unsafe static void GJDNDAOJHNI([NoAlias] ushort* OIEEJLIGKIK, [Out] float2 GLEOKCNEDKE, [Out] float2 OAKBDDLJNNB, [In][NoAlias] float2* PPLHDGNCJBP, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6810", Offset = "0x6CB5210", VA = "0x186CB6810")]
	[BurstCompile]
	private static void DCODEHHAHMI([Out] float2 ONBAMJHHIMH, ushort IFANMHCOFBE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBDA50", Offset = "0x6CBC450", VA = "0x186CBDA50")]
	private void NHOJOAMCFEM(NativeArray<float2> OIEEJLIGKIK, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD970", Offset = "0x6CBC370", VA = "0x186CBD970")]
	[BurstCompile]
	private unsafe static void NHOJOAMCFEM([NoAlias] float2* OIEEJLIGKIK, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6E70", Offset = "0x6CB5870", VA = "0x186CB6E70")]
	[BurstCompile]
	private unsafe static void EIMHECDNKPJ([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6CB57A0", Offset = "0x6CB41A0", VA = "0x186CB57A0")]
	[BurstCompile]
	private unsafe static void CEOPDCBCCFL([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6A40", Offset = "0x6CB5440", VA = "0x186CB6A40")]
	[BurstCompile]
	private unsafe static void EEHMCJMKDPB([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6CB8A50", Offset = "0x6CB7450", VA = "0x186CB8A50")]
	[BurstCompile]
	private unsafe static void GLIGGJJCILI([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6710", Offset = "0x6CB5110", VA = "0x186CB6710")]
	[BurstCompile]
	private unsafe static void CPOMGAALKIB([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB580", Offset = "0x6CB9F80", VA = "0x186CBB580")]
	private void LBEBIIJLOFB(NativeArray<float4> ONIEKFIGDDF, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB460", Offset = "0x6CB9E60", VA = "0x186CBB460")]
	[BurstCompile]
	private unsafe static void LBEBIIJLOFB([NoAlias] ushort* MIBECCNHLEI, [In][NoAlias] float4* HKNLPMPLGGN, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD720", Offset = "0x6CBC120", VA = "0x186CBD720")]
	[BurstCompile]
	private static ushort MPLMPGPDDJN([In] float4 NENCLBBCLLF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA1E0", Offset = "0x6CB8BE0", VA = "0x186CBA1E0")]
	private void IAFOCMEFFKJ(NativeArray<float4> MIBECCNHLEI, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA310", Offset = "0x6CB8D10", VA = "0x186CBA310")]
	[BurstCompile]
	private unsafe static void IAFOCMEFFKJ([NoAlias] float4* MIBECCNHLEI, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6F70", Offset = "0x6CB5970", VA = "0x186CB6F70")]
	[BurstCompile]
	private unsafe static void FAFMLGDGAGL([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC110", Offset = "0x6CBAB10", VA = "0x186CBC110")]
	[BurstCompile]
	private unsafe static void LNAGIEJMHCK([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBF50", Offset = "0x6CBA950", VA = "0x186CBBF50")]
	[BurstCompile]
	private unsafe static void LKPCIJFDDJO([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBC860", Offset = "0x6CBB260", VA = "0x186CBC860")]
	[BurstCompile]
	private unsafe static void MCJDDIGCHNO([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB130", Offset = "0x6CB9B30", VA = "0x186CBB130")]
	[BurstCompile]
	private unsafe static void KFMHHECDOIE([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB61F0", Offset = "0x6CB4BF0", VA = "0x186CB61F0")]
	[BurstCompile]
	private static void CMCAHILCJIB([Out] float4 POBDLJBBBCI, ushort IFANMHCOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6CBB870", Offset = "0x6CBA270", VA = "0x186CBB870")]
	private void LFGHMNEKPGF(Allocator NPNPKHEIOHB, NativeArray<float4> DLHFCHEPLOH, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6CBBC70", Offset = "0x6CBA670", VA = "0x186CBBC70")]
	[BurstCompile]
	private unsafe static void LFGHMNEKPGF([NoAlias] float4* GJLANIGGKKP, [NoAlias] byte* NOHFEANHPIM, [Out] int MKDBGICGMGD, [Out] int HJEHCGEKGEF, [NoAlias] float4* DLHFCHEPLOH, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6CB63F0", Offset = "0x6CB4DF0", VA = "0x186CB63F0")]
	private static void CPJNELLHNMM(NativeArray<float4> JAJAOCLDAHG, NativeArray<EOJKEPKKMBN> OPCJLEAJHPA, NativeArray<byte> LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6CB65D0", Offset = "0x6CB4FD0", VA = "0x186CB65D0")]
	[BurstCompile]
	private unsafe static void CPJNELLHNMM([NoAlias] float4* JAJAOCLDAHG, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAF50", Offset = "0x6CB9950", VA = "0x186CBAF50")]
	[BurstCompile]
	private unsafe static void KFHGGFICDGN([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6CB74C0", Offset = "0x6CB5EC0", VA = "0x186CB74C0")]
	[BurstCompile]
	private unsafe static void FDMLMMJFOHF([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE740", Offset = "0x6CBD140", VA = "0x186CBE740")]
	[BurstCompile]
	private unsafe static void PHFLCIKNHCK([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6CB7280", Offset = "0x6CB5C80", VA = "0x186CB7280")]
	[BurstCompile]
	private unsafe static void FCHCAGGNBDA([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6CB6C30", Offset = "0x6CB5630", VA = "0x186CB6C30")]
	[BurstCompile]
	private unsafe static void EFAIHOGGOKI([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA460", Offset = "0x6CB8E60", VA = "0x186CBA460")]
	private void IEFNNJKBNEK(Allocator NPNPKHEIOHB, NativeArray<int> PONGLDBFKNH, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA940", Offset = "0x6CB9340", VA = "0x186CBA940")]
	private static NativeArray<byte> IMGNBHHEMLO(Allocator NPNPKHEIOHB, NativeArray<int> PONGLDBFKNH, int OEADKPEDKKG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6CBA840", Offset = "0x6CB9240", VA = "0x186CBA840")]
	[BurstCompile]
	private unsafe static int IMGNBHHEMLO([NoAlias] byte* GPOKJHGAKOP, [In][NoAlias] int* PONGLDBFKNH, int OEADKPEDKKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD7B0", Offset = "0x6CBC1B0", VA = "0x186CBD7B0")]
	private static void NCPCBOALDCO(NativeArray<int> LDDJIABCDOA, NativeArray<byte> NJOLLHHEACM, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD8D0", Offset = "0x6CBC2D0", VA = "0x186CBD8D0")]
	[BurstCompile]
	private unsafe static void NCPCBOALDCO([NoAlias] int* LDDJIABCDOA, [In][NoAlias] byte* NJOLLHHEACM, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CBD460", Offset = "0x6CBBE60", VA = "0x186CBD460")]
	[BurstCompile]
	private unsafe static void MJBOHDJOKEK([NoAlias] ushort* LDDJIABCDOA, [In][NoAlias] byte* NJOLLHHEACM, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CB60B0", Offset = "0x6CB4AB0", VA = "0x186CB60B0")]
	[BurstCompile]
	private static void CJNACMBICAL([Out] float3 ONBAMJHHIMH, ushort IFANMHCOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6CBAD90", Offset = "0x6CB9790", VA = "0x186CBAD90")]
	[BurstCompile]
	private static ushort KDEKPHKGEOK([In] float3 NENCLBBCLLF)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class JOIDBGKONGK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum NGBKHNBLCFF
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
	public enum EDAKOILPHEO
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
	public struct CCIHIMLGCOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public NGBKHNBLCFF OJCKNPDLJJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool PNCJNGDJBDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int MNDIOLEMKDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct EGFDNPKKGJH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 LEELMECKGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 DBBPPLLNKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 DNAJPPCEHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 OJBJKILMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 NMFFJMEBPIH;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct KKBIMIHMFDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 LEELMECKGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 DBBPPLLNKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 DNAJPPCEHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 OJBJKILMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NMFFJMEBPIH;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct NMBPNIGIGML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 LEELMECKGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint DBBPPLLNKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint DNAJPPCEHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 OJBJKILMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 NMFFJMEBPIH;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct JHPCPCCNNCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 LEELMECKGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint DBBPPLLNKOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint DNAJPPCEHOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 OJBJKILMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 NMFFJMEBPIH;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct FKICJMLKGNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 LEELMECKGCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint POEJMIDMFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 OJBJKILMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint CEIEIOJLKNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint PKGFFGFMKLK;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct GOCKDHAAOKA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public EJGGIAECJNN.IAFEFEFMLHA GMMBFMIFAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint POEJMIDMFDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 OJBJKILMOHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint CEIEIOJLKNP;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] CDNBOBFLMMN;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int MDINOHAIHMF(float NCPIGLMANIM);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class ODBOPGCCKLO
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF430", Offset = "0x6CCDE30", VA = "0x186CCF430")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF550", Offset = "0x6CCDF50", VA = "0x186CCF550")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF130", Offset = "0x6CCDB30", VA = "0x186CCF130")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF1D0", Offset = "0x6CCDBD0", VA = "0x186CCF1D0")]
		public static int FJEDBGMGJGG(float NCPIGLMANIM)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint LIOLMJEMMAK([In] float4 LEKEIHPCIEI);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class EMBJPJPJIJB
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6CC15D0", Offset = "0x6CBFFD0", VA = "0x186CC15D0")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6CC16F0", Offset = "0x6CC00F0", VA = "0x186CC16F0")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1200", Offset = "0x6CBFC00", VA = "0x186CC1200")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6CC12A0", Offset = "0x6CBFCA0", VA = "0x186CC12A0")]
		public static uint FJEDBGMGJGG([In] float4 LEKEIHPCIEI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint GMGOJMKGPJF([In] float3 LEKEIHPCIEI);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class DOBAGPFDGKK
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF580", Offset = "0x6CBDF80", VA = "0x186CBF580")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF6A0", Offset = "0x6CBE0A0", VA = "0x186CBF6A0")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF270", Offset = "0x6CBDC70", VA = "0x186CBF270")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF310", Offset = "0x6CBDD10", VA = "0x186CBF310")]
		public static uint FJEDBGMGJGG([In] float3 LEKEIHPCIEI)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void HOONBIKIEAP([NoAlias] NMBPNIGIGML* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class PLIBMMPIFIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF970", Offset = "0x6CCE370", VA = "0x186CCF970")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CCFA90", Offset = "0x6CCE490", VA = "0x186CCFA90")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF6A0", Offset = "0x6CCE0A0", VA = "0x186CCF6A0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CCF740", Offset = "0x6CCE140", VA = "0x186CCF740")]
		public unsafe static void FJEDBGMGJGG([NoAlias] NMBPNIGIGML* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void KKIFLHEIHEM([NoAlias] JHPCPCCNNCJ* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class MFPMEPDOKNH
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CCED10", Offset = "0x6CCD710", VA = "0x186CCED10")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CCEE30", Offset = "0x6CCD830", VA = "0x186CCEE30")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CCEA40", Offset = "0x6CCD440", VA = "0x186CCEA40")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6CCEAE0", Offset = "0x6CCD4E0", VA = "0x186CCEAE0")]
		public unsafe static void FJEDBGMGJGG([NoAlias] JHPCPCCNNCJ* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void OEPHIIEJIHL([NoAlias] FKICJMLKGNH* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class DJPBPGCNOJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF000", Offset = "0x6CBDA00", VA = "0x186CBF000")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CBF120", Offset = "0x6CBDB20", VA = "0x186CBF120")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEB80", Offset = "0x6CBD580", VA = "0x186CBEB80")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CBEC20", Offset = "0x6CBD620", VA = "0x186CBEC20")]
		public unsafe static void FJEDBGMGJGG([NoAlias] FKICJMLKGNH* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void GPGAGFGGIDL([NoAlias] GOCKDHAAOKA* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH, [Out] float3 DAGAEBGDPPB, [Out] float3 FPPKCDLGHKK);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class HBODDBFNFCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr HMFJLOKKNHP;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr JCFEIEOAGAD;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2440", Offset = "0x6CC0E40", VA = "0x186CC2440")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CC2560", Offset = "0x6CC0F60", VA = "0x186CC2560")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1E40", Offset = "0x6CC0840", VA = "0x186CC1E40")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CC1EE0", Offset = "0x6CC08E0", VA = "0x186CC1EE0")]
		public unsafe static void FJEDBGMGJGG([NoAlias] GOCKDHAAOKA* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH, [Out] float3 DAGAEBGDPPB, [Out] float3 FPPKCDLGHKK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int HCPGNEALPAK = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> PGFMCLELOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> GAMKHABFEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> CDOFDHEKMPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> NDGFFPHFKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> KBMEGIBEECL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> KOJFAOFOLCN;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] GDHPNDCFDLB;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool HHLINJGMEPK;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static CCIHIMLGCOA[] MLKIKAMJIOC;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool FKPHAIMPOJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CC8B10", Offset = "0x6CC7510", VA = "0x186CC8B10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CC82B0", Offset = "0x6CC6CB0", VA = "0x186CC82B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6CC9050", Offset = "0x6CC7A50", VA = "0x186CC9050")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CEFHDIFPAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6CC6490", Offset = "0x6CC4E90", VA = "0x186CC6490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA620", Offset = "0x6CC9020", VA = "0x186CCA620")]
	public static EDAKOILPHEO PEMDMDGHPMI(NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(EDAKOILPHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8550", Offset = "0x6CC6F50", VA = "0x186CC8550")]
	public static void JBJBDADGHNA(EDAKOILPHEO EPNEBBGJHCO, Material KFGOIEOLDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6300", Offset = "0x6CC4D00", VA = "0x186CC6300", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6CC82F0", Offset = "0x6CC6CF0", VA = "0x186CC82F0")]
	public void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB, bool GFDHFENNGJJ, bool PNPKPDDLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8610", Offset = "0x6CC7010", VA = "0x186CC8610")]
	public void JHPNGECMFKN(int NPFPKLGDKMF, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8AF0", Offset = "0x6CC74F0", VA = "0x186CC8AF0", Slot = "6")]
	public bool KKELICPKAMA(Mesh CBNKKMIFMKD, bool DBPEHOBDCBF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8690", Offset = "0x6CC7090", VA = "0x186CC8690")]
	public bool KBFNHGEPLCH(Mesh CBNKKMIFMKD, bool DBPEHOBDCBF, bool DPFFAIDNOKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8B50", Offset = "0x6CC7550", VA = "0x186CC8B50")]
	public bool LHLEDMOLOBE(Mesh CBNKKMIFMKD, JOIDBGKONGK DMPDFDFIJMN, bool DBPEHOBDCBF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC55A0", Offset = "0x6CC3FA0", VA = "0x186CC55A0")]
	public void CGFLFOIBMEO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6570", Offset = "0x6CC4F70", VA = "0x186CC6570")]
	[BurstCompile]
	public static int FICFPIELMHG(float NCPIGLMANIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6520", Offset = "0x6CC4F20", VA = "0x186CC6520")]
	[BurstCompile]
	public static uint FICFPIELMHG([In] float4 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6CC64D0", Offset = "0x6CC4ED0", VA = "0x186CC64D0")]
	[BurstCompile]
	public static uint FICFPIELMHG([In] float3 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6720", Offset = "0x6CC5120", VA = "0x186CC6720")]
	public void FNNDPFCCMFI(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6CC97A0", Offset = "0x6CC81A0", VA = "0x186CC97A0")]
	[BurstCompile]
	private unsafe static void NHDLKDJDDHE([NoAlias] NMBPNIGIGML* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9120", Offset = "0x6CC7B20", VA = "0x186CC9120")]
	public void MIMADDFEGCH(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9820", Offset = "0x6CC8220", VA = "0x186CC9820")]
	[BurstCompile]
	private unsafe static void NHNECDBGKNE([NoAlias] JHPCPCCNNCJ* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6CC98A0", Offset = "0x6CC82A0", VA = "0x186CC98A0")]
	public void OLADNJMPJFO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6410", Offset = "0x6CC4E10", VA = "0x186CC6410")]
	[BurstCompile]
	private unsafe static void EGNILGPGBCD([NoAlias] FKICJMLKGNH* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7720", Offset = "0x6CC6120", VA = "0x186CC7720")]
	public void HFHIGPECFKC(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6CC73C0", Offset = "0x6CC5DC0", VA = "0x186CC73C0")]
	[BurstCompile]
	private unsafe static void GPIDDCMINJB([NoAlias] GOCKDHAAOKA* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH, [Out] float3 DAGAEBGDPPB, [Out] float3 FPPKCDLGHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9090", Offset = "0x6CC7A90", VA = "0x186CC9090")]
	public void LPCHLOOIKAH(Mesh CBNKKMIFMKD, NGBKHNBLCFF OJCKNPDLJJF, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6DA0", Offset = "0x6CC57A0", VA = "0x186CC6DA0")]
	public void GGKHFFLDDLC(JOIDBGKONGK CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4D40", Offset = "0x6CC3740", VA = "0x186CC4D40")]
	public void BBEOLJBOHLI(JOIDBGKONGK MKLJJBDOOGE, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4BB0", Offset = "0x6CC35B0", VA = "0x186CC4BB0")]
	public long AJMCHHNECGH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4CE0", Offset = "0x6CC36E0", VA = "0x186CC4CE0")]
	public static long AJMCHHNECGH(int BKLOIIIOBOB, int FFFKHOKBJML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6680", Offset = "0x6CC5080", VA = "0x186CC6680")]
	public static long FJAOELNFMLO(int BKLOIIIOBOB, int FFFKHOKBJML, NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CC65C0", Offset = "0x6CC4FC0", VA = "0x186CC65C0")]
	public long FJAOELNFMLO(NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CC8A90", Offset = "0x6CC7490", VA = "0x186CC8A90")]
	public void KJFODJCDOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9FF0", Offset = "0x6CC89F0", VA = "0x186CC9FF0")]
	public static void PBAFEKGLPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4E40", Offset = "0x6CC3840", VA = "0x186CC4E40")]
	public NGBKHNBLCFF BLAFMLNDDFC()
	{
		return default(NGBKHNBLCFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CC9F20", Offset = "0x6CC8920", VA = "0x186CC9F20")]
	public static (int, int) OPMDPGEBJKF(Mesh CBNKKMIFMKD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6220", Offset = "0x6CC4C20", VA = "0x186CC6220")]
	public static int DJBMOLKBIAB(VertexAttributeDescriptor[] LDMEANPAGHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CC84E0", Offset = "0x6CC6EE0", VA = "0x186CC84E0")]
	public static long IJGGHCBNOOK(Mesh CBNKKMIFMKD, int JACHNOPPJBB, int ELPEDJEIBKF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public JOIDBGKONGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7440", Offset = "0x6CC5E40", VA = "0x186CC7440")]
	[BurstCompile]
	public static int HADOCNIBBFG(float NCPIGLMANIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CC74E0", Offset = "0x6CC5EE0", VA = "0x186CC74E0")]
	[BurstCompile]
	public static uint HADOCNIBBFG([In] float4 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7670", Offset = "0x6CC6070", VA = "0x186CC7670")]
	[BurstCompile]
	public static uint HADOCNIBBFG([In] float3 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7010", Offset = "0x6CC5A10", VA = "0x186CC7010")]
	[BurstCompile]
	public unsafe static void GIILMEECDOP([NoAlias] NMBPNIGIGML* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6CC7E60", Offset = "0x6CC6860", VA = "0x186CC7E60")]
	[BurstCompile]
	public unsafe static void HFNKLFHFJAC([NoAlias] JHPCPCCNNCJ* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6CC6020", Offset = "0x6CC4A20", VA = "0x186CC6020")]
	[BurstCompile]
	public unsafe static void CHLEFHBFNLF([NoAlias] FKICJMLKGNH* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6CCA2E0", Offset = "0x6CC8CE0", VA = "0x186CCA2E0")]
	[BurstCompile]
	public unsafe static void PDHNEHELCHO([NoAlias] GOCKDHAAOKA* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH, [Out] float3 DAGAEBGDPPB, [Out] float3 FPPKCDLGHKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct HEIMBPMPLCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int APNPLAPPFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 MIDAHKLONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion HDFJOAAMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 HDKFOJOFHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int EGMBGINKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int EILKCLJBOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float CABAFGDCJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 PLECNIBHCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool HFNPLIPBNGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public DFECJDBCKPF HFJHICDHGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 ICLANJFHEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float FFCHHBLJDPE;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HKJIDIEMGKL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static MANEHJEPDED PIAEHGLKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<HEIMBPMPLCJ> PMELDNMAHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<HCEPBIJKIFD> CIMDACLLGMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<BDBIBPGNJFM> NJPKDBPNOCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<NNEBOAEPEKN> ANANMMJHCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<HCEPBIJKIFD> NGJBICJOKCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<FFCFJLDFALD> DEBANLHDKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<NNEBOAEPEKN>> PGNCNIAHODC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<KINAFICGJBF> AMNONDKBCFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> PFHAGDEAOOH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x1046060", Offset = "0x1044A60", VA = "0x181046060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x1044EF0", Offset = "0x10438F0", VA = "0x181044EF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x1046070", Offset = "0x1044A70", VA = "0x181046070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x1045720", Offset = "0x1044120", VA = "0x181045720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC43F0", Offset = "0x6CC2DF0", VA = "0x186CC43F0")]
	public HKJIDIEMGKL(int GCIALEFHHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC26B0", Offset = "0x6CC10B0", VA = "0x186CC26B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2BB0", Offset = "0x6CC15B0", VA = "0x186CC2BB0")]
	public void LKJDFILLICP(JobHandle GDNIAPJJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2EE0", Offset = "0x6CC18E0", VA = "0x186CC2EE0")]
	public void NLDGECDOCNG(HEIMBPMPLCJ JGCMECODHDI, KINAFICGJBF EONBNDEHCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2D80", Offset = "0x6CC1780", VA = "0x186CC2D80")]
	public void MDGNMILNPAJ(BDBIBPGNJFM JGCMECODHDI, NativeArray<NNEBOAEPEKN> HIIBIPNKFFO, int KNHJBDAHGAE, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CC33B0", Offset = "0x6CC1DB0", VA = "0x186CC33B0")]
	public JobHandle PNEFFJFBHFD(JOIDBGKONGK HLJACFHFCGB, FJFLFEFKGGD FCAPBHNHPIK, float3 PKNJKJDBLDK, quaternion JLCEFOIBMAA, float NKGMNFLOPDP, bool BNHAGKKILIO, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6CC2870", Offset = "0x6CC1270", VA = "0x186CC2870")]
	public static JobHandle KDAIDNOJOJI(DFJCJLEBMPC GNKLOBOOKMM, JOIDBGKONGK HLJACFHFCGB, HEIMBPMPLCJ JGCMECODHDI, JobHandle GDNIAPJJBPI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6CC3100", Offset = "0x6CC1B00", VA = "0x186CC3100")]
	public static JobHandle PLPOGJIEPOA(GIOMCMJJKIO GNKLOBOOKMM, JOIDBGKONGK HLJACFHFCGB, BDBIBPGNJFM JGCMECODHDI, NativeArray<NNEBOAEPEKN> HIIBIPNKFFO, int KNHJBDAHGAE, int EHANMNGLAMC, JobHandle GDNIAPJJBPI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct OCDBOIJFELO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 FINIPIMGMHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 CNEDOCPBIID;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class ILGMALKOKIC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<OCDBOIJFELO> BOFPGPENFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> PLMNECJIKEF;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x89F660", Offset = "0x89E060", VA = "0x18089F660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x898FD0", Offset = "0x8979D0", VA = "0x180898FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4840", Offset = "0x6CC3240", VA = "0x186CC4840")]
	public ILGMALKOKIC(int NPFPKLGDKMF, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4700", Offset = "0x6CC3100", VA = "0x186CC4700", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC4760", Offset = "0x6CC3160", VA = "0x186CC4760")]
	public void GGKHFFLDDLC(ILGMALKOKIC LEEMNOHIIFO, int DIKCDEIMJCP, int NBPJLJIBBHP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class EIAMEDOOMOM
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static ILGMALKOKIC AKGBONHNHOI;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<HCEPBIJKIFD> KGPBDEKIOBG;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] IFLIHHIDAPN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool NOKAIHLEBKG;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, ILGMALKOKIC> KHLPKJADMKD;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, ILGMALKOKIC> AKBBEGJMDJI;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool GKOIFGBONGN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0900", Offset = "0x6CBF300", VA = "0x186CC0900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<HCEPBIJKIFD> LAOGNPPPAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0C10", Offset = "0x6CBF610", VA = "0x186CC0C10")]
		get
		{
			return default(NativeList<HCEPBIJKIFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ILGMALKOKIC DOPHIEJELDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CC0180", Offset = "0x6CBEB80", VA = "0x186CC0180")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CBFA70", Offset = "0x6CBE470", VA = "0x186CBFA70")]
	private static void DJFHBIEHOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF9B0", Offset = "0x6CBE3B0", VA = "0x186CBF9B0")]
	public static int DFMOHLCOFNK(bool CNLACMHGOKE, int LLBNOKCCKPO, bool DHDBELCHMDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF990", Offset = "0x6CBE390", VA = "0x186CBF990")]
	private static int ANPEDNCAMAH(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CC10A0", Offset = "0x6CBFAA0", VA = "0x186CC10A0")]
	private static int PNCBIPDCABJ(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CC07E0", Offset = "0x6CBF1E0", VA = "0x186CC07E0")]
	public static int GMLMAFHOJEN(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CBF9E0", Offset = "0x6CBE3E0", VA = "0x186CBF9E0")]
	public static int DHDDNCDCMEH(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0990", Offset = "0x6CBF390", VA = "0x186CC0990")]
	public static int JIDDNJFDGND(int HAPEMOJEECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0980", Offset = "0x6CBF380", VA = "0x186CC0980")]
	private static int IKOGHACBPJA(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0870", Offset = "0x6CBF270", VA = "0x186CC0870")]
	private static int GPCGHPNLBAE(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0890", Offset = "0x6CBF290", VA = "0x186CC0890")]
	public static int HOIHDBPFIDA(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0A90", Offset = "0x6CBF490", VA = "0x186CC0A90")]
	public static int KEDFPNFPMIO(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0160", Offset = "0x6CBEB60", VA = "0x186CC0160")]
	public static int DOEOHPPBPGC(int HAPEMOJEECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CC09A0", Offset = "0x6CBF3A0", VA = "0x186CC09A0")]
	public static ILGMALKOKIC KDBFFHMFECM(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0210", Offset = "0x6CBEC10", VA = "0x186CC0210")]
	private static ILGMALKOKIC EPFBHCLOJIO(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0B20", Offset = "0x6CBF520", VA = "0x186CC0B20")]
	public static ILGMALKOKIC MHDHDFFMHPB(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CC04A0", Offset = "0x6CBEEA0", VA = "0x186CC04A0")]
	private static ILGMALKOKIC GBPAALGOCPF(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CC0CA0", Offset = "0x6CBF6A0", VA = "0x186CC0CA0")]
	public static void PEGLLNMGGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BDBIBPGNJFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int IGCPLALMIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 MIDAHKLONNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion HDFJOAAMCHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float HDKFOJOFHAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float HDHKIIHMMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int NJBPHLKMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int EGMBGINKKJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int EILKCLJBOHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool BKGDHACIDON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool PLHNJJGFBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float CABAFGDCJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 PLECNIBHCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool PGPDNMFDPIM;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct FFCFJLDFALD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int CJECFNMBCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int FNOICDDKKKA;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct GIOMCMJJKIO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<BDBIBPGNJFM> PDNFAJAHMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<NNEBOAEPEKN> BPJECLBEBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<HCEPBIJKIFD> PICOIOLIIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<FFCFJLDFALD> LBGMPMOFIEH;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CC1AA0", Offset = "0x6CC04A0", VA = "0x186CC1AA0")]
	public GIOMCMJJKIO(NativeArray<NNEBOAEPEKN> BPJECLBEBFJ, int BHEAFIOEIAD = 1, Allocator NPNPKHEIOHB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6CC19B0", Offset = "0x6CC03B0", VA = "0x186CC19B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct KKKMEJIDJAB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<OCDBOIJFELO> MNBKJPOEEED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> JEMHFFEHEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<HCEPBIJKIFD> OHFIINICBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<BDBIBPGNJFM> PDNFAJAHMII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<NNEBOAEPEKN> BPJECLBEBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<HCEPBIJKIFD> PICOIOLIIBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<FFCFJLDFALD> LBGMPMOFIEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int MOGGDGCEIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int PPPBILGBBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 EPKABLDNCNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion AGDPHOFLACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 KNFALGDLJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BMEGLCCLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> POICKIIDPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AOEGMIGFICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CICIPOAGEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> OPJFLIAOJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BEKCHPEKJBD;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6CCCB90", Offset = "0x6CCB590", VA = "0x186CCCB90")]
	public KKKMEJIDJAB(HKJIDIEMGKL DNNEPMFIFCF, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CCCE10", Offset = "0x6CCB810", VA = "0x186CCCE10")]
	public KKKMEJIDJAB(GIOMCMJJKIO DNNEPMFIFCF, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float3 JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6CCCA50", Offset = "0x6CCB450", VA = "0x186CCCA50")]
	private float3 OPNNGPEKMEG(float3 EEFJAKFDDOC, Matrix4x4 NJBKNGCMEEK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6CCAC10", Offset = "0x6CC9610", VA = "0x186CCAC10")]
	private float3x3 BHPJNBFNMNI(float3x3 BFBBAEAGMDK, float3x3 MLJMICDNHII)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6CCCB80", Offset = "0x6CCB580", VA = "0x186CCCB80")]
	private float PGAOCLIFFPD(float DKEHAFKGJAC, float LFBABNCDFHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6CCB0F0", Offset = "0x6CC9AF0", VA = "0x186CCB0F0", Slot = "4")]
	public void Execute(int LBBGOBFOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC8E0", Offset = "0x6CCB2E0", VA = "0x186CCC8E0")]
	private void NBDOFNOKAEN(int LJMGNCELFLB, float3 LEELMECKGCG, float3 DBBPPLLNKOD, float3 DNAJPPCEHOF, float PPAGJHCGANB, bool MOACEDKKPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6CCAC90", Offset = "0x6CC9690", VA = "0x186CCAC90")]
	private void CAIBMOFHBHL(BDBIBPGNJFM FGBPKJBGJOD, float3 NJELOECLOIL, float3x3 CNFFBLAHCCM, float DKEHAFKGJAC, int JFHFKBGBPFN, int HPFIAJBHPMP, int GBEOOHKHNLI, float DJIAOMHLDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CCC290", Offset = "0x6CCAC90", VA = "0x186CCC290")]
	private void JNDFOBDGBAC(int LJMGNCELFLB, int PIFJBCKCFDP, BDBIBPGNJFM FGBPKJBGJOD, float3 NJELOECLOIL, float3x3 CNFFBLAHCCM, bool PDFMFLPOAKA, float DKEHAFKGJAC, int MKMACKGCMJK, int MLLEGKDJJOO, int GBEOOHKHNLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DFJCJLEBMPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<HEIMBPMPLCJ> AGAJCIEGOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<HCEPBIJKIFD> KHAAOJGJFID;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CBEA90", Offset = "0x6CBD490", VA = "0x186CBEA90")]
	public DFJCJLEBMPC(int BHEAFIOEIAD, Allocator NPNPKHEIOHB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6CBE9F0", Offset = "0x6CBD3F0", VA = "0x186CBE9F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct MFDCHBILLPH : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum PIHNGLKGBAM
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
	private NativeList<float3> ACODGDEGHKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> CHEBKOPONIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> ADKMCGCBLJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> DLAAAAMCEGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> OFECDKNKOIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> DOIJPKNILMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> PIIAHNJGGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> POMEKPHIJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<HCEPBIJKIFD> OHCLMMFLOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<HEIMBPMPLCJ> AGAJCIEGOMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<HCEPBIJKIFD> KHAAOJGJFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int MOGGDGCEIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int PPPBILGBBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> BMEGLCCLPFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> POICKIIDPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AOEGMIGFICH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CICIPOAGEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> OPJFLIAOJGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BEKCHPEKJBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 KNFALGDLJBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion AGDPHOFLACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 EPKABLDNCNA;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6CCE850", Offset = "0x6CCD250", VA = "0x186CCE850")]
	public MFDCHBILLPH(HKJIDIEMGKL DNNEPMFIFCF, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6CCE670", Offset = "0x6CCD070", VA = "0x186CCE670")]
	public MFDCHBILLPH(DFJCJLEBMPC JGCMECODHDI, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float3 JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CCD260", Offset = "0x6CCBC60", VA = "0x186CCD260", Slot = "4")]
	public void Execute(int LBBGOBFOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CCE270", Offset = "0x6CCCC70", VA = "0x186CCE270")]
	private void OCODCLEBADN(float4x4 DNJCIEHPMCF, int LBBGOBFOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CCE1C0", Offset = "0x6CCCBC0", VA = "0x186CCE1C0")]
	private PIHNGLKGBAM GPHFGHGJIGP(float3 DBBPPLLNKOD)
	{
		return default(PIHNGLKGBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CCE620", Offset = "0x6CCD020", VA = "0x186CCE620")]
	private float4 PBPNDEGFIJL(PIHNGLKGBAM ONLKOIGBDGH, int HGFDMIDEFHN)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6CCE230", Offset = "0x6CCCC30", VA = "0x186CCE230")]
	private float2 MGCIABBPEKJ(PIHNGLKGBAM ONLKOIGBDGH, float3 LEELMECKGCG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct KINAFICGJBF
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum PJBMHIHFKLM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static KINAFICGJBF PGEMABEMKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 EHFBMINIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 BHOIDFFDPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 KHAEIGABOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public PJBMHIHFKLM EMAFAACIGEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 DKAEDOBLKOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 AINGONDFDPE;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OGCLLAHCFGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA960", Offset = "0x6CD9360", VA = "0x186CDA960")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 MPMIDEELHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CDAF10", Offset = "0x6CD9910", VA = "0x186CDAF10")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB2E0", Offset = "0x6CD9CE0", VA = "0x186CDB2E0")]
	public KINAFICGJBF(float3 LEELMECKGCG, quaternion JOLHFCINNMA, float3 BHEAFIOEIAD, PJBMHIHFKLM JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA970", Offset = "0x6CD9370", VA = "0x186CDA970")]
	public float BDAMGHNDCEF(float3 NJELOECLOIL, float EOPIHKJHPGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAB70", Offset = "0x6CD9570", VA = "0x186CDAB70")]
	public bool BOMLJKDDGHB(float3 DBBPPLLNKOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAD60", Offset = "0x6CD9760", VA = "0x186CDAD60")]
	public void IIPFNPOJABB(float3 KKMPKNILPDG, float3x3 DBCDGJOMFJP, float HIIDBMEKJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAC60", Offset = "0x6CD9660", VA = "0x186CDAC60")]
	private void GDPKCAGAAAA(float3 IFDMLAIJAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAFF0", Offset = "0x6CD99F0", VA = "0x186CDAFF0")]
	public void NLIKHKJJAMA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct CPJDBENBDOC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<KINAFICGJBF> JGCMECODHDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> CPDNMEDJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> HCMMOHLNFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> PFHAGDEAOOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<HCEPBIJKIFD> KHAAOJGJFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int NCAHINHGHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int ELEGGNKCLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float EOPIHKJHPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float KBIDILNHNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MEJIOKGKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> LPDKENFEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> GEMJFNNHCFJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6CD77E0", Offset = "0x6CD61E0", VA = "0x186CD77E0")]
	public CPJDBENBDOC(JOIDBGKONGK CBNKKMIFMKD, float AKPMEKOKALB, int NBPJLJIBBHP, int JFHFKBGBPFN, NativeList<KINAFICGJBF> JGCMECODHDI, NativeArray<int> PFHAGDEAOOH, NativeList<HCEPBIJKIFD> KHAAOJGJFID, FJFLFEFKGGD FCAPBHNHPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6FE0", Offset = "0x6CD59E0", VA = "0x186CD6FE0", Slot = "4")]
	public void Execute(int IPPLKDLFFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7720", Offset = "0x6CD6120", VA = "0x186CD7720")]
	private bool IBGJMPCMLGJ(KINAFICGJBF MOKDKAEJAPP, KINAFICGJBF MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6D40", Offset = "0x6CD5740", VA = "0x186CD6D40")]
	private bool EMIBCNBBAIK(KINAFICGJBF MIBANGGGBCO, int GIJEDBJIMPO, int PBANHLBNFKJ, int OFMNIBOFEDG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class FJFLFEFKGGD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> KAJMOCBOOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> FOCFCDCLEKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> PAEGKIEDNPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> NHPMBDBEGJI;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8C70", Offset = "0x6CD7670", VA = "0x186CD8C70")]
	public void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8B60", Offset = "0x6CD7560", VA = "0x186CD8B60")]
	public static long DAOGLONLOLA(int NPFPKLGDKMF, int DCLJAMBNIMH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8B80", Offset = "0x6CD7580", VA = "0x186CD8B80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8D90", Offset = "0x6CD7790", VA = "0x186CD8D90")]
	public void LKJDFILLICP(JobHandle GDNIAPJJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8A32C0", Offset = "0x8A1CC0", VA = "0x1808A32C0")]
	public FJFLFEFKGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct BBIBKNINNEB : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> CPDNMEDJDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> JNHDPLLEKKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> NMFFJMEBPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> EOIJNLNANPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> HCMMOHLNFNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KPEAPECEMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> FLKFGIFIGPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> MEJIOKGKGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> LPDKENFEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int FFHCFMOHBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int NJCHHJGMIKA;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD0410", Offset = "0x6CCEE10", VA = "0x186CD0410")]
	public BBIBKNINNEB(JOIDBGKONGK CBNKKMIFMKD, FJFLFEFKGGD FCAPBHNHPIK, int NJCHHJGMIKA = 0, int FFHCFMOHBOL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6CCFFD0", Offset = "0x6CCE9D0", VA = "0x186CCFFD0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD03B0", Offset = "0x6CCEDB0", VA = "0x186CD03B0")]
	private void GFGMMFGDKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NGKHFMMGAOA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE0E0", Offset = "0x2EECAE0", VA = "0x182EEE0E0")]
	public static bool HFCOLOLGBOC<T>(NativeArray<T> DKEEEGEFALD, int BHEAFIOEIAD, Allocator NPNPKHEIOHB, NativeArrayOptions CLJCAFMAPFP = NativeArrayOptions.ClearMemory, int LMHGHCMMMFI = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2EEE260", Offset = "0x2EECC60", VA = "0x182EEE260")]
	public static bool HFCOLOLGBOC<T>(NativeList<T> OLAPNOFMNPM, int BHEAFIOEIAD, Allocator NPNPKHEIOHB) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum FDCBHIELGDB
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
public interface AGHAKNFLOIH
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GAFHMPPANPN(FDCBHIELGDB CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int EAAFKICFKMB(FDCBHIELGDB CLOHFODGPFM);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds FGDPBAGOBNJ();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float CJEHNCNPENI();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AEFKNEGFGJM(FDCBHIELGDB CLOHFODGPFM, HKJIDIEMGKL MLDLLLNAJIB, int CPMPGJMHJLF = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class FKLOPAEJGFB
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8E80", Offset = "0x6CD7880", VA = "0x186CD8E80")]
	public static void PEGLLNMGGIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class GDJEGFEFPKO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> PGFMCLELOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> GAMKHABFEKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> MIBFKMFIHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> DCABNOKMKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> OOCFFBKDDKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> KPIGDADOOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> IAIHGMGFOOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> KOJFAOFOLCN;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9E30", Offset = "0x6CD8830", VA = "0x186CD9E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9E70", Offset = "0x6CD8870", VA = "0x186CD9E70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int OKNDMJMENAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6CD9DF0", Offset = "0x6CD87F0", VA = "0x186CD9DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9EB0", Offset = "0x6CD88B0", VA = "0x186CD9EB0")]
	public GDJEGFEFPKO(int NPFPKLGDKMF, int DCLJAMBNIMH, int PMBGNFBEJME, Allocator NPNPKHEIOHB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA180", Offset = "0x6CD8B80", VA = "0x186CDA180")]
	public GDJEGFEFPKO(Mesh CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8FD0", Offset = "0x6CD79D0", VA = "0x186CD8FD0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9AF0", Offset = "0x6CD84F0", VA = "0x186CD9AF0")]
	public void GGKHFFLDDLC(GDJEGFEFPKO CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD90E0", Offset = "0x6CD7AE0", VA = "0x186CD90E0")]
	private void EHELKMKHOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9570", Offset = "0x6CD7F70", VA = "0x186CD9570")]
	private void GBPPEBFHIHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct HCEPBIJKIFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int PPEDIBHELHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int NODGOOMLBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int JJJAPLILJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int IFODHMFDNEL;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x17556E0", Offset = "0x17540E0", VA = "0x1817556E0")]
	public HCEPBIJKIFD(int JFHFKBGBPFN, int KNHJBDAHGAE, int NBPJLJIBBHP, int EHANMNGLAMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MANEHJEPDED : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<HCEPBIJKIFD> MCCJKKIOKCO
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA13B20", Offset = "0xA12520", VA = "0x180A13B20")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HCEPBIJKIFD>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA13970", Offset = "0xA12370", VA = "0x180A13970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GDJEGFEFPKO JPMOJDIJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x898FC0", Offset = "0x8979C0", VA = "0x180898FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x899040", Offset = "0x897A40", VA = "0x180899040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDCD0", Offset = "0x6CDC6D0", VA = "0x186CDDCD0")]
	public MANEHJEPDED(IEnumerable<GDJEGFEFPKO> CBLAEIHFGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDC60", Offset = "0x6CDC660", VA = "0x186CDDC60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum DFECJDBCKPF
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class CFPIBMLALBJ
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> HHEBKMHAPLM;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> CDEDAALHODF;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> CGPHLNKFBKA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> LGCMAJJPKBA;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6C30", Offset = "0x6CD5630", VA = "0x186CD6C30")]
	public static void PEGLLNMGGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6930", Offset = "0x6CD5330", VA = "0x186CD6930")]
	public static NativeArray<float2> HLKHFANFDPK(NativeArray<float2> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<float2> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6B30", Offset = "0x6CD5530", VA = "0x186CD6B30")]
	public static NativeArray<float3> NOAMLEKDLNJ(NativeArray<float3> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<float3> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6830", Offset = "0x6CD5230", VA = "0x186CD6830")]
	public static NativeArray<float4> BDAPEGAEEED(NativeArray<float4> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<float4> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6CD6A30", Offset = "0x6CD5430", VA = "0x186CD6A30")]
	public static NativeArray<int> LFLLFCANJCC(NativeArray<int> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<int> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2B638F0", Offset = "0x2B622F0", VA = "0x182B638F0")]
	private static void PLAJKMJLKNI<T>(NativeArray<T> DKEEEGEFALD, int EGPBIJMNNCM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2B63810", Offset = "0x2B62210", VA = "0x182B63810")]
	private static void BNCJMJJDGFK<T>(NativeArray<T> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<T> IIIMPGGPGOP, int GGGPIINDLOG, NativeArray<T> CPBGCOCBEEM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class EJGGIAECJNN
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct IAFEFEFMLHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort NCPIGLMANIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort DJBPOPBDKAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort EFFGNNIODIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort JJFOOLJLHLB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7EE0", Offset = "0x6CD68E0", VA = "0x186CD7EE0")]
	public static uint BCDKMHEHFJC(float LEKLHMHBODB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8900", Offset = "0x6CD7300", VA = "0x186CD8900")]
	public static void ODNEGKAENHP(float4 NMFFJMEBPIH, float LNHKHKPDKII, [Out] uint CEIEIOJLKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8A10", Offset = "0x6CD7410", VA = "0x186CD8A10")]
	public static void ODNEGKAENHP(float4 NMFFJMEBPIH, uint IGHBPKJJOKM, [Out] uint CEIEIOJLKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8470", Offset = "0x6CD6E70", VA = "0x186CD8470")]
	public static void MANLJFHICEC(float3 AJOOHEHOJLD, float3 FDNFIFCEGLL, float4 HCCFAJGMNFJ, float2 LKMGDFCFIJD, float4 NMFFJMEBPIH, [Out] JOIDBGKONGK.FKICJMLKGNH PGDOLFANKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8210", Offset = "0x6CD6C10", VA = "0x186CD8210")]
	public static void MANLJFHICEC(float3 AJOOHEHOJLD, float3 FDNFIFCEGLL, float4 HCCFAJGMNFJ, float2 LKMGDFCFIJD, float4 NMFFJMEBPIH, [Out] JOIDBGKONGK.GOCKDHAAOKA PGDOLFANKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6CD86C0", Offset = "0x6CD70C0", VA = "0x186CD86C0")]
	public static byte NCJNDHBNKOM(float KLABJGGMBGH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7EF0", Offset = "0x6CD68F0", VA = "0x186CD7EF0")]
	public static ushort DIGFOJKEJEM(float KLABJGGMBGH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7F40", Offset = "0x6CD6940", VA = "0x186CD7F40")]
	public static uint FICJFNNDOLD(float KLABJGGMBGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8870", Offset = "0x6CD7270", VA = "0x186CD8870")]
	public static float2 NHDIIFFNCOA(float2 LEKEIHPCIEI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6CD80C0", Offset = "0x6CD6AC0", VA = "0x186CD80C0")]
	public static float2 IBAENFAFLNM(float3 ODPGHJEEHCK)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7F70", Offset = "0x6CD6970", VA = "0x186CD7F70")]
	public static void IAPACIDLNGC(float3 KLABJGGMBGH, [Out] float3 FKOAIOJOGJE, [Out] uint3 JJFOOLJLHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8710", Offset = "0x6CD7110", VA = "0x186CD8710")]
	public static IAFEFEFMLHA NFKONCDMPOB(float3 LEELMECKGCG)
	{
		return default(IAFEFEFMLHA);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EBBDIAJOAIC
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker BFGKLDOCNFA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float PEMBFGODLBL;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void LCPOMJLKCOC(bool OKBPIGPIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7880", Offset = "0x6CD6280", VA = "0x186CD7880")]
	public static void JKBGDMOAIOD(float JIJJLMNBKDP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class ONLNIONNPJP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum DCKIKLKGELD
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
	public struct ECIAADBJJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public CFLKOMOGAPG CBNKKMIFMKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int EFOHIMELNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int OALHJJPFCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long LHILOGAODGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long KICICGPCNGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float HNOHKPHIBHK;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7E30", Offset = "0x6CD6830", VA = "0x186CD7E30")]
		public void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7E60", Offset = "0x6CD6860", VA = "0x186CD7E60")]
		public void LKJDFILLICP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string ELFGMDPFECJ;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string MAHAGFFCNBC;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker BFGKLDOCNFA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker DKKBHPKBLDF;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker AFHLDMACJNM;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker NJGOMLGNKHO;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker GFNOGKEDOGM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker FHGCJIMGACF;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker DIHABBCCNOK;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker PKANLHJAGFM;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker BABMGPAKOPP;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker FIFOAFMIOPF;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker EELGHEPNNEG;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker OGLGDMMBIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<AGHAKNFLOIH> EBKMDGFIIBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly OGMGECKBGAC PPEADJBLEAN;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool BAJFPGAAJMP = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int KNHJBDAHGAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int EHANMNGLAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EAJIDBIDFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool NEJBKIDJJJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool KFDIHHAMHAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal DCKIKLKGELD FDKAGJLJMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool IPLMICLBHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 LGADDKKFCJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 DHGLNFJKBKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float HFFEJEFHGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float KGNLGHKHCIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int LHNLHJJNCIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int GOBNJMMJGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int HMKOJBKGJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int GGEGEILMDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float NDIEBGNDLNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float LODPHCMKEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int KILNKDOMNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long CAOIGKBGLFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long OINJAOLLLPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long HFOPPGPNCBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int IHBLCECBFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int HEHDBMDODKJ = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] OMALGOJPFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] JFCCHFFOAGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] IOGJGLIDJFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<ECIAADBJJCO> APGNPHJAIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private JOIDBGKONGK KGLEBHLBBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long JDIOMINMLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long LLJDJOBNPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int NFDJCNIHELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float DEGBHFEKOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal JOIDBGKONGK.NGBKHNBLCFF FAPGGECELFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool AIGIBCAGCFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private LDAAIPMLPDJ JLCEBEACINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle MAMNPFMOKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> DANKDCPBFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool KMKOKNCLCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle CNHIAKGKAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private JOIDBGKONGK PLFCKABHENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private FJFLFEFKGGD MADFJJIMKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform IOCOPFFFAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private FDCBHIELGDB OPNFLBEALMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long ALCALMKFHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long LCOMELPHILI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long IGKKICLGIIM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh JPMOJDIJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x899AF0", Offset = "0x8984F0", VA = "0x180899AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x89D6B0", Offset = "0x89C0B0", VA = "0x18089D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter HJLHLKFABID
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x89D6A0", Offset = "0x89C0A0", VA = "0x18089D6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer IJAICPPPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8999F0", Offset = "0x8983F0", VA = "0x1808999F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x899AB0", Offset = "0x8984B0", VA = "0x180899AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> KNLBEOACLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x899AA0", Offset = "0x8984A0", VA = "0x180899AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x899930", Offset = "0x898330", VA = "0x180899930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BHNGOALBONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x93CA60", Offset = "0x93B460", VA = "0x18093CA60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AILHMPDAPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x125FE30", Offset = "0x125E830", VA = "0x18125FE30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6CE5030", Offset = "0x6CE3A30", VA = "0x186CE5030")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<AGHAKNFLOIH> CKADLLCFPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8961B0", Offset = "0x894BB0", VA = "0x1808961B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4E30", Offset = "0x6CE3830", VA = "0x186CE4E30")]
	public void GKEGAAKCBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8320", Offset = "0x6CE6D20", VA = "0x186CE8320")]
	private void NDGBNNEFKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8F40", Offset = "0x6CE7940", VA = "0x186CE8F40")]
	public ONLNIONNPJP(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7AF0", Offset = "0x6CE64F0", VA = "0x186CE7AF0")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8940", Offset = "0x6CE7340", VA = "0x186CE8940")]
	private void NKIPIHCIDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4D20", Offset = "0x6CE3720", VA = "0x186CE4D20")]
	private void FGCKLAKMLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8A80", Offset = "0x6CE7480", VA = "0x186CE8A80")]
	public Mesh ODGKIKBGKCI(MeshFilter CMLFCFJPLNC, Transform FLDLBOHKNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDECC0", Offset = "0x6CDD6C0", VA = "0x186CDECC0")]
	private void BIIOEOKKLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE3CE0", Offset = "0x6CE26E0", VA = "0x186CE3CE0")]
	public void DPLAMNGCGIK(AGHAKNFLOIH AEEKBCOCEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6CE0050", Offset = "0x6CDEA50", VA = "0x186CE0050")]
	public bool CIJCCCNJEHE(AGHAKNFLOIH AEEKBCOCEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4CC0", Offset = "0x6CE36C0", VA = "0x186CE4CC0")]
	public bool FEAHPDAAGAE(AGHAKNFLOIH AEEKBCOCEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6CE00D0", Offset = "0x6CDEAD0", VA = "0x186CE00D0", Slot = "4")]
	public virtual void CPACCADECEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6CDEF50", Offset = "0x6CDD950", VA = "0x186CDEF50")]
	public void CCHDKKMCFLL(Transform FBHNHMNFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4C00", Offset = "0x6CE3600", VA = "0x186CE4C00")]
	private long FBLLNONKODE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6CDEB60", Offset = "0x6CDD560", VA = "0x186CDEB60")]
	private long BHDOHNACADH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6CE21B0", Offset = "0x6CE0BB0", VA = "0x186CE21B0")]
	public bool DNPLPCAFBEK(Transform FBHNHMNFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF190", Offset = "0x6CDDB90", VA = "0x186CDF190")]
	public bool CEAFLDGLMEA(bool KKDLFAPPJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE300", Offset = "0x6CDCD00", VA = "0x186CDE300")]
	private void BFBAHKFODIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE54F0", Offset = "0x6CE3EF0", VA = "0x186CE54F0")]
	public bool JKBGDMOAIOD(float4x4 LENANFGCBLG, BatchedMeshRenderer IGHOGDFOOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4E50", Offset = "0x6CE3850", VA = "0x186CE4E50")]
	public void HEMJNAMFDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7C20", Offset = "0x6CE6620", VA = "0x186CE7C20")]
	public bool LLBODCODEHE(bool KKDLFAPPJCK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4E40", Offset = "0x6CE3840", VA = "0x186CE4E40")]
	public void HCNPKOGJOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE54C0", Offset = "0x6CE3EC0", VA = "0x186CE54C0")]
	public void IOLCMKLLLMI(JOIDBGKONGK CBNKKMIFMKD, int JCNLPPBCHDA, int EDGAMNENPOO, float EHDCBBHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE0E80", Offset = "0x6CDF880", VA = "0x186CE0E80")]
	public void DIGOFKIGGBN(CFLKOMOGAPG CGLFIOBCNKK, int JCNLPPBCHDA, int EDGAMNENPOO, float EHDCBBHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE290", Offset = "0x6CDCC90", VA = "0x186CDE290")]
	public (long, long, long) AJMCHHNECGH()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x949AA0", Offset = "0x9484A0", VA = "0x180949AA0")]
	public long CBPGLMNBMMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6CE3E40", Offset = "0x6CE2840", VA = "0x186CE3E40")]
	private void EEHBLCHMHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6CE6DC0", Offset = "0x6CE57C0", VA = "0x186CE6DC0")]
	public (long, long) KLJDOOABGHJ(float FOABPIOOEIB, float4x4 LENANFGCBLG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public void DHGNDOHMADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4240", Offset = "0x6CE2C40", VA = "0x186CE4240")]
	internal void EJBDNJOJABP(DCKIKLKGELD DLNGFNBCANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4360", Offset = "0x6CE2D60", VA = "0x186CE4360")]
	private (float, float, float, float) EOKMNCOMGBE(float BNBHLEAMMCJ, float4x4 LENANFGCBLG)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6CDEB00", Offset = "0x6CDD500", VA = "0x186CDEB00")]
	private float BGJAOPGACFJ(float BNBHLEAMMCJ, float4x4 LENANFGCBLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7F50", Offset = "0x6CE6950", VA = "0x186CE7F50")]
	private (int, int) MLMMKALAPJM(float JAIMOJOCOPG)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1130", Offset = "0x6CDFB30", VA = "0x186CE1130")]
	public void DJLIMOCJDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE6D70", Offset = "0x6CE5770", VA = "0x186CE6D70")]
	private void JOPCPOFHMAB(JOIDBGKONGK FCFPLPDEGNH, JOIDBGKONGK.NGBKHNBLCFF BBEOMILKJME, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE6C70", Offset = "0x6CE5670", VA = "0x186CE6C70")]
	private void JOPCPOFHMAB([In] CFLKOMOGAPG FCFPLPDEGNH, JOIDBGKONGK.NGBKHNBLCFF BBEOMILKJME, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE89E0", Offset = "0x6CE73E0", VA = "0x186CE89E0")]
	private void NODBINDPBFJ(JOIDBGKONGK.NGBKHNBLCFF BBEOMILKJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4E00", Offset = "0x6CE3800", VA = "0x186CE4E00")]
	private void GIHAMJIBMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8620", Offset = "0x6CE7020", VA = "0x186CE8620")]
	private void NJNNGOJHMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7140", Offset = "0x6CE5B40", VA = "0x186CE7140")]
	public long KOENAPMPHIO(long FFDOIMOLFOC, int LJAMLPDKGKL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6CE0160", Offset = "0x6CDEB60", VA = "0x186CE0160")]
	private void DHJOBINHIEI(JOIDBGKONGK GJBCGDADODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5050", Offset = "0x6CE3A50", VA = "0x186CE5050")]
	private void IHCOCNJJLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8290", Offset = "0x6CE6C90", VA = "0x186CE8290")]
	private float MPAIFEKJMPN(int IJEPMMBCLMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6CE32D0", Offset = "0x6CE1CD0", VA = "0x186CE32D0")]
	private void DPKELCBAHCG(JOIDBGKONGK CBNKKMIFMKD, DOCKNNDOGKM CGLFIOBCNKK, int JCNLPPBCHDA, int EDGAMNENPOO, float EHDCBBHAOCC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct LDAAIPMLPDJ : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct MEPADBGELAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int HLDCJBPECAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int JKKLGBDNBCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int EOCPIFKJBFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int AIBKNJPDGKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int HHNECALBDMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int JONDAEOJAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int EFOHIMELNKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int OALHJJPFCHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float HNOHKPHIBHK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct AIMPNNHNEKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public NLAECODBCON.MMHPGGMKCJA JKOGFOCDMOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float OHBMMFCEFIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float HDMEOJIDJNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float AFNDOJPDJII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float EHLDKNHFCJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float HDLOLMCNIHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float PGLLHPIBCAL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct ILGMNNBIDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> PGFMCLELOAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> GAMKHABFEKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> CDOFDHEKMPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> NDGFFPHFKML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> KBMEGIBEECL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> KOJFAOFOLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool EKNKGCBLBBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int NODGOOMLBAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int IFODHMFDNEL;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA470", Offset = "0x6CD8E70", VA = "0x186CDA470")]
		public void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB, bool PNPKPDDLCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA710", Offset = "0x6CD9110", VA = "0x186CDA710")]
		public static ILGMNNBIDKK LKNNLDLLIBG(JOIDBGKONGK MILPHOELICC)
		{
			return default(ILGMNNBIDKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6CDA650", Offset = "0x6CD9050", VA = "0x186CDA650")]
		public void LKJDFILLICP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker PDGPNDJDDNG;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker EHKHCPOIFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<MEPADBGELAF> JPABLPPONAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private ILGMNNBIDKK JPNLIPFLMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private ILGMNNBIDKK GJBCGDADODG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 AAAMJAKODMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 OMIEMCMJEFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private AIMPNNHNEKD LOAIEKAAGGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* INFLMKIFJME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> PFBKJPHHMBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> LPDKENFEBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> ODLGOLEIKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> JIBFDBLDEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> PNHIKCIDEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> EDAPAPBKIHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> NANONGICKEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> MKBEDMBIOGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> LNGIEEMEOBH;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD410", Offset = "0x6CDBE10", VA = "0x186CDD410")]
	public LDAAIPMLPDJ([In] List<ONLNIONNPJP.ECIAADBJJCO> PLJEFGJPEIH, [In] JOIDBGKONGK IIDNMKCCFKG, [In] ONLNIONNPJP POOBLNGOLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC780", Offset = "0x6CDB180", VA = "0x186CDC780", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6CDCA00", Offset = "0x6CDB400", VA = "0x186CDCA00")]
	public void PDCFENBOOJH(List<ONLNIONNPJP.ECIAADBJJCO> EKKIHGHNNLD, [In] ONLNIONNPJP POOBLNGOLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD360", Offset = "0x6CDBD60", VA = "0x186CDD360")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool PPANCJKFMFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC7D0", Offset = "0x6CDB1D0", VA = "0x186CDC7D0")]
	private CFLKOMOGAPG FFMBDKLIENC(int JDGGDOKJMAM, Allocator NPNPKHEIOHB)
	{
		return default(CFLKOMOGAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB7F0", Offset = "0x6CDA1F0", VA = "0x186CDB7F0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void DEANEPCMBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB4D0", Offset = "0x6CD9ED0", VA = "0x186CDB4D0")]
	[IgnoreWarning(1371)]
	private MEPADBGELAF CHIBINDAHPD([In] MEPADBGELAF MEALBCMKKDA, int KFAFEAGOMKO, [In] NativeArray<int> HCMMOHLNFNH, [In] NativeArray<bool> LPDKENFEBLE, NativeArray<int> ODLGOLEIKLL)
	{
		return default(MEPADBGELAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB3D0", Offset = "0x6CD9DD0", VA = "0x186CDB3D0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int AIEKCPLNJAI(NativeArray<int> HCMMOHLNFNH, int HFDPOPKMKPH, int HHGEKDLHPMG, int NJDIOAIGKDF)
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
		public static readonly CMICIECANPG log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker MKDNNPFIHFB;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker HDLCPIOELGI;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker AEACKADOIMJ;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker DMNOPBPMLDO;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker AELMIMNLEPF;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker GFNOGKEDOGM;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker MLJKDCOMDFL;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int KFGDDOIMDFG = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> OMIFEIPAGIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<ONLNIONNPJP>> MIECMFCBBDO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<ONLNIONNPJP> LNPOFKINNBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> KNFHPLMAPDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform DPKFLOAEHAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool KOFBADFGOIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool FGKOHHJPEHJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int EPJJKAAJKAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private Dictionary<int, float> FEEMMLCPJHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Dictionary<int, Color> MHCBEHBGIFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		private Dictionary<int, Vector4> NLDHLGNAGMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private Dictionary<int, Matrix4x4> MCFLMHAHHPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private ONLNIONNPJP ELIAEDLGOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private Material GPCJDCMIKHE;

		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private const int LAGFCFCOABB = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private static List<(long, Bounds, AGHAKNFLOIH)> NENDPNKNANG;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> LBMMJDDPIHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8999A0", Offset = "0x8983A0", VA = "0x1808999A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int IIFHKHANCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6CD67E0", Offset = "0x6CD51E0", VA = "0x186CD67E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		private static void KBPAHJMJOGF(bool OKBPIGPIOLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		private static void KBPAHJMJOGF(bool OKBPIGPIOLB, string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2E20", Offset = "0x6CD1820", VA = "0x186CD2E20")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0490", Offset = "0x6CCEE90", VA = "0x186CD0490")]
		public ONLNIONNPJP AddToBatchedMesh(AGHAKNFLOIH JAOFDEECFJH, Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5840", Offset = "0x6CD4240", VA = "0x186CD5840")]
		public void RemoveFromBatchedMesh(AGHAKNFLOIH CBNKKMIFMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0590", Offset = "0x6CCEF90", VA = "0x186CD0590")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6080", Offset = "0x6CD4A80", VA = "0x186CD6080")]
		public void SetMaterialProperty(int CFNKBOPELEO, Color FEHNKBJAMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5C30", Offset = "0x6CD4630", VA = "0x186CD5C30")]
		public void SetMaterialProperty(int CFNKBOPELEO, float KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD5E50", Offset = "0x6CD4850", VA = "0x186CD5E50")]
		public void SetMaterialProperty(int CFNKBOPELEO, Vector4 OJJHMMDBAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6CD59D0", Offset = "0x6CD43D0", VA = "0x186CD59D0")]
		public void SetMaterialProperty(int CFNKBOPELEO, Matrix4x4 NEOIADOHDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6CD06C0", Offset = "0x6CCF0C0", VA = "0x186CD06C0")]
		private void EADFNANPAPD(Renderer MGJKLBPNDCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0F60", Offset = "0x6CCF960", VA = "0x186CD0F60")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0F50", Offset = "0x6CCF950", VA = "0x186CD0F50")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1000", Offset = "0x6CCFA00", VA = "0x186CD1000")]
		private void GPCOHONBJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6CD2180", Offset = "0x6CD0B80", VA = "0x186CD2180")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6CD0CB0", Offset = "0x6CCF6B0", VA = "0x186CD0CB0")]
		private ONLNIONNPJP EDNECKFIMPL(AGHAKNFLOIH CBNKKMIFMKD, Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1C80", Offset = "0x6CD0680", VA = "0x186CD1C80")]
		private ONLNIONNPJP LAPDFMOLOLC(Material KFGOIEOLDHF, int GMEKMMJCJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6CD27B0", Offset = "0x6CD11B0", VA = "0x186CD27B0")]
		private ONLNIONNPJP ONODMEOOAPM(Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6CD26B0", Offset = "0x6CD10B0", VA = "0x186CD26B0")]
		private float4x4 OLFKIIBKIIK()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1B60", Offset = "0x6CD0560", VA = "0x186CD1B60")]
		private List<Material> KEJFDFLJEOI(Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xC4FD50", Offset = "0xC4E750", VA = "0x180C4FD50")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD1FF0", Offset = "0x6CD09F0", VA = "0x186CD1FF0")]
		public void MarkDirty(AGHAKNFLOIH CBNKKMIFMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6CD22F0", Offset = "0x6CD0CF0", VA = "0x186CD22F0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float FOABPIOOEIB)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6CD45B0", Offset = "0x6CD2FB0", VA = "0x186CD45B0")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6CD15F0", Offset = "0x6CCFFF0", VA = "0x186CD15F0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6CD3080", Offset = "0x6CD1A80", VA = "0x186CD3080")]
		public void RebatchOptimally(int FIHEKEJPLJK, int LLGONPIPOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6570", Offset = "0x6CD4F70", VA = "0x186CD6570")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OEBHLMCLCCE
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct JBNFOPBFCIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public float OCBNPLFNECE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public BatchedMeshRenderer CLBGDEFKKHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public ONLNIONNPJP CGOMNMPAANI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public long GLGHIPHDEFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public float KACDPPGKNEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E3")]
		public bool DPCNEDEEHPH;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class PCIHODJINPA : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		private bool <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		private long totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		public long <>3__totalAvailableBytesForScalability;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private bool forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x31")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		public bool <>3__forceMeshCreationImmediately;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private int <batchSizeNaughty>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EE")]
		private int <batchSizeNice>5__3;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private int <countdownBeforeYield>5__4;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001F0")]
		private List<BatchedMeshRenderer>.Enumerator <>7__wrap4;

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		bool IEnumerator<bool>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xB7DBB0", Offset = "0xB7C5B0", VA = "0x180B7DBB0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x6CEEEC0", Offset = "0x6CED8C0", VA = "0x186CEEEC0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0xCD3930", Offset = "0xCD2330", VA = "0x180CD3930")]
		[DebuggerHidden]
		public PCIHODJINPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x6CEEF10", Offset = "0x6CED910", VA = "0x186CEEF10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6CEE150", Offset = "0x6CECB50", VA = "0x186CEE150", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6CEE100", Offset = "0x6CECB00", VA = "0x186CEE100")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6CEE0B0", Offset = "0x6CECAB0", VA = "0x186CEE0B0")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x6CEEE70", Offset = "0x6CED870", VA = "0x186CEEE70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0x6CEEDC0", Offset = "0x6CED7C0", VA = "0x186CEEDC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6CEEDC0", Offset = "0x6CED7C0", VA = "0x186CEEDC0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	public static readonly CMICIECANPG FPPDOFKLJHI;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker GFNOGKEDOGM;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private static readonly ProfilerMarker MPLNBKJICJG;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private static readonly ProfilerMarker GIHLIDNCFPM;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private static readonly ProfilerMarker DCBDNMFFCHN;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static float3 OCOCONHINCL;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int GPEFAOPLFCJ;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int JEHMDFCDKEJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int PBMFFOEJJMN;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static int BKHCACKPCJL;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static int NBJMFJONMPN;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int OMOOAMICOCD;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static long NHIONLJGDLC;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static long JIEMKKOHPJC;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static int EAIFCFPMFEE;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static int MLGJNBLOPHK;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int ONADLGPJANL;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float EDANOCBIFPN;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static bool NNHCOCPGGEC;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static int GBALHPNAICM;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float OHPLFGFNNHG;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float ODKOKKCBDEP;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float KMMIABFKMPM;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float AGCBBPDIAEB;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float HMIHJJCKLKK;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static float DMGONHENLLP;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static float GGNACHNOLBN;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	public static float PDNAJHPIOFG;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	public static long HEHPDADMLAG;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	public static bool ADCNPPLNCHE;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static List<BatchedMeshRenderer> DEMKMBPDJIG;

	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private static List<JBNFOPBFCIG> HDNLDBAMNKI;

	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private static Stack<JOIDBGKONGK> ABGDBNEOBFM;

	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private static Stack<FJFLFEFKGGD> DDKFCCKMALN;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool HNJEIHPNOOM
	{
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CE9D60", Offset = "0x6CE8760", VA = "0x186CE9D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void KBPAHJMJOGF(bool OKBPIGPIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void LCPOMJLKCOC(bool OKBPIGPIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	private static void KBPAHJMJOGF(bool OKBPIGPIOLB, string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x897350", Offset = "0x895D50", VA = "0x180897350")]
	public static void AMLGEKNOMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6CED2E0", Offset = "0x6CEBCE0", VA = "0x186CED2E0")]
	public static void NDKOMOFBAMN(BatchedMeshRenderer FHCMLCHAIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6CE99B0", Offset = "0x6CE83B0", VA = "0x186CE99B0")]
	public static void EOBGINAOLIP(BatchedMeshRenderer FHCMLCHAIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6CE98A0", Offset = "0x6CE82A0", VA = "0x186CE98A0")]
	private static (long, long, long) DLGEAJIDBNF(long JCMDFLNPAEB)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9DF0", Offset = "0x6CE87F0", VA = "0x186CE9DF0")]
	public static bool GAMAJFDICMF(float JCPDLJECLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6CEA260", Offset = "0x6CE8C60", VA = "0x186CEA260")]
	public static void JIGGKJEEEKK(float JCPDLJECLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6CED090", Offset = "0x6CEBA90", VA = "0x186CED090")]
	public static bool MFDEFNHGKNI(float JCPDLJECLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6CEA2D0", Offset = "0x6CE8CD0", VA = "0x186CEA2D0")]
	public static void JKBGDMOAIOD(long JCMDFLNPAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6CECD00", Offset = "0x6CEB700", VA = "0x186CECD00")]
	public static long KOENAPMPHIO(long FFDOIMOLFOC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9FD0", Offset = "0x6CE89D0", VA = "0x186CE9FD0")]
	public static void IBACBGIAAEF(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9EA0", Offset = "0x6CE88A0", VA = "0x186CE9EA0")]
	public static void GNCDOPOPJMF(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float JIJJLMNBKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9770", Offset = "0x6CE8170", VA = "0x186CE9770")]
	public static void CLGOFKDGCLO(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float JIJJLMNBKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6CED440", Offset = "0x6CEBE40", VA = "0x186CED440")]
	public static void NGCPGAMKCFK(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float OOICLFNNFML, bool DPCNEDEEHPH, float OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6CED820", Offset = "0x6CEC220", VA = "0x186CED820")]
	public static float OLDENPMHIBA(long LLMOBNHALEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6CECB30", Offset = "0x6CEB530", VA = "0x186CECB30")]
	public static (long, long) KLJDOOABGHJ(float FOABPIOOEIB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6CED670", Offset = "0x6CEC070", VA = "0x186CED670")]
	[IteratorStateMachine(typeof(PCIHODJINPA))]
	public static IEnumerable<bool> OJNNCKJDFLN(long OJMCFOKMJEG, bool ANABDEAOCGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9450", Offset = "0x6CE7E50", VA = "0x186CE9450")]
	public static void CDBLIFBKDNH(long OJMCFOKMJEG, bool ANABDEAOCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6CED1A0", Offset = "0x6CEBBA0", VA = "0x186CED1A0")]
	public static int NBKNGNFLEHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6CEA110", Offset = "0x6CE8B10", VA = "0x186CEA110")]
	internal static JOIDBGKONGK ICFAJKCOOPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6CED790", Offset = "0x6CEC190", VA = "0x186CED790")]
	internal static void OKKMPHOGAFP(JOIDBGKONGK FJPCMKGPIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9620", Offset = "0x6CE8020", VA = "0x186CE9620")]
	internal static FJFLFEFKGGD CDLIJLBBHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CED700", Offset = "0x6CEC100", VA = "0x186CED700")]
	internal static void OKKMPHOGAFP(FJFLFEFKGGD FCAPBHNHPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class GGGNMKNBIOM<KeyType> : ONLNIONNPJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly Dictionary<KeyType, AGHAKNFLOIH> MDBHGNINPMO;

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3ED57A0", Offset = "0x3ED41A0", VA = "0x183ED57A0")]
	public GGGNMKNBIOM(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5270", Offset = "0x3ED3C70", VA = "0x183ED5270")]
	public void DPLAMNGCGIK(KeyType LFOBGDLOPID, AGHAKNFLOIH AEEKBCOCEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3ED55A0", Offset = "0x3ED3FA0", VA = "0x183ED55A0")]
	public bool FLOOMNMEAMM(KeyType LFOBGDLOPID, AGHAKNFLOIH ANJEMIKMEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3ED52E0", Offset = "0x3ED3CE0", VA = "0x183ED52E0")]
	public void FEKKBBKAHCD(KeyType LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3ED5210", Offset = "0x3ED3C10", VA = "0x183ED5210", Slot = "4")]
	public override void CPACCADECEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CEF030", Offset = "0x6CEDA30", VA = "0x186CEF030")]
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
