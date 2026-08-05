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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE5DB0", Offset = "0x6BE43B0", VA = "0x186BE5DB0", Slot = "4")]
		public override void JJJMHPMEAIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AF980", Offset = "0x8ADF80", VA = "0x1808AF980")]
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
		[Cpp2IlInjected.Address(RVA = "0x8841A0", Offset = "0x8827A0", VA = "0x1808841A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BD4190", Offset = "0x6BD2790", VA = "0x186BD4190")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CEFHDIFPAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6BD0640", Offset = "0x6BCEC40", VA = "0x186BD0640")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4BA0", Offset = "0x6BD31A0", VA = "0x186BD4BA0")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1E80", Offset = "0x6BD0480", VA = "0x186BD1E80")]
	public static CFLKOMOGAPG GMDNOGMNFLF(Allocator NPNPKHEIOHB, JOIDBGKONGK LIKPPJOMCFI)
	{
		return default(CFLKOMOGAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD18C0", Offset = "0x6BCFEC0", VA = "0x186BD18C0")]
	public static CFLKOMOGAPG GMDNOGMNFLF(Allocator NPNPKHEIOHB, NativeArray<float3> MPCMCCFINGC, NativeArray<float3> JMALHMJAHAD, NativeArray<float2> PPLHDGNCJBP, NativeArray<float4> DLHFCHEPLOH, bool EKNKGCBLBBE, NativeArray<float4> ONIEKFIGDDF, NativeArray<int> PONGLDBFKNH, int KNHJBDAHGAE, int IHFHJLPHIFK, int EHANMNGLAMC, int JJEEHICMMPC)
	{
		return default(CFLKOMOGAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2AF0", Offset = "0x6BD10F0", VA = "0x186BD2AF0")]
	public JOIDBGKONGK HGAGKNOIJAH(Allocator NPNPKHEIOHB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD39E0", Offset = "0x6BD1FE0", VA = "0x186BD39E0")]
	public void KBFNHGEPLCH(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7260", Offset = "0x6BD5860", VA = "0x186BD7260")]
	private void OMMJNOLINOB(Mesh CBNKKMIFMKD, NativeArray<ushort> HOEKGNMBAOO, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE610", Offset = "0x6BCCC10", VA = "0x186BCE610")]
	public void CGFLFOIBMEO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0840", Offset = "0x6BCEE40", VA = "0x186BD0840")]
	public void FNNDPFCCMFI(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5800", Offset = "0x6BD3E00", VA = "0x186BD5800")]
	public void MIMADDFEGCH(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6930", Offset = "0x6BD4F30", VA = "0x186BD6930")]
	public void OLADNJMPJFO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2150", Offset = "0x6BD0750", VA = "0x186BD2150")]
	public void HFHIGPECFKC(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6BD5050", Offset = "0x6BD3650", VA = "0x186BD5050")]
	public void LPCHLOOIKAH(Mesh CBNKKMIFMKD, JOIDBGKONGK.NGBKHNBLCFF OJCKNPDLJJF, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE390", Offset = "0x6BCC990", VA = "0x186BCE390")]
	public long AJMCHHNECGH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6BD07D0", Offset = "0x6BCEDD0", VA = "0x186BD07D0")]
	public long FJAOELNFMLO(JOIDBGKONGK.NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2E20", Offset = "0x6BD1420", VA = "0x186BD2E20")]
	private void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB, bool PNPKPDDLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF5D0", Offset = "0x6BCDBD0", VA = "0x186BCF5D0")]
	private void DLDHODBHDDG(NativeArray<float3> NFJEDNOAEPA, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCA30", Offset = "0x6BCB030", VA = "0x186BCCA30")]
	[BurstCompile]
	private unsafe static void DLDHODBHDDG([NoAlias] float3* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE450", Offset = "0x6BCCA50", VA = "0x186BCE450")]
	[BurstCompile]
	private unsafe static void BGOHKDPIIKP([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD63D0", Offset = "0x6BD49D0", VA = "0x186BD63D0")]
	[BurstCompile]
	private unsafe static void MOPCKPPDDFC([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD40D0", Offset = "0x6BD26D0", VA = "0x186BD40D0")]
	[BurstCompile]
	private unsafe static void NJMPEALMNKE([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD40D0", Offset = "0x6BD26D0", VA = "0x186BD40D0")]
	[BurstCompile]
	private unsafe static void KLDNIHJAMON([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6270", Offset = "0x6BD4870", VA = "0x186BD6270")]
	[BurstCompile]
	private unsafe static void MKODBKNNIEH([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] ushort* MPCMCCFINGC, int KNHJBDAHGAE, [In] float3 OKCFNICBICC, [In] float3 LIPKHMBFKNJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF6C0", Offset = "0x6BCDCC0", VA = "0x186BCF6C0")]
	private void DLNNNFKKICK(NativeArray<float3> MPCMCCFINGC, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6BCCC80", Offset = "0x6BCB280", VA = "0x186BCCC80")]
	[BurstCompile]
	private unsafe static void DLNNNFKKICK([NoAlias] ushort* NFJEDNOAEPA, [Out] float3 FHLBFPOLBBP, [Out] float3 LIPKHMBFKNJ, [In][NoAlias] float3* MPCMCCFINGC, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE2B0", Offset = "0x6BCC8B0", VA = "0x186BCE2B0")]
	private void AAHJAGABCNC(NativeArray<float3> JMALHMJAHAD, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6BCDFF0", Offset = "0x6BCC5F0", VA = "0x186BCDFF0")]
	[BurstCompile]
	private unsafe static void AAHJAGABCNC([NoAlias] ushort* HFKGOGOGEDG, [In][NoAlias] float3* JMALHMJAHAD, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6BD32D0", Offset = "0x6BD18D0", VA = "0x186BD32D0")]
	private void IFKJKOGLDDM(NativeArray<float3> CMKLLDJNKKJ, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3390", Offset = "0x6BD1990", VA = "0x186BD3390")]
	[BurstCompile]
	private unsafe static void IFKJKOGLDDM([NoAlias] float3* CMKLLDJNKKJ, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0410", Offset = "0x6BCEA10", VA = "0x186BD0410")]
	[BurstCompile]
	private unsafe static void FDPFOBBFEKF([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF020", Offset = "0x6BCD620", VA = "0x186BCF020")]
	[BurstCompile]
	private unsafe static void CMOGOILAIHK([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6BD44A0", Offset = "0x6BD2AA0", VA = "0x186BD44A0")]
	[BurstCompile]
	private unsafe static void LDNMKBPJKIP([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0680", Offset = "0x6BCEC80", VA = "0x186BD0680")]
	[BurstCompile]
	private unsafe static void FGFMAKBNICM([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD12B0", Offset = "0x6BCF8B0", VA = "0x186BD12B0")]
	[BurstCompile]
	private unsafe static void GGMMNIPNHEI([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] ushort* JMALHMJAHAD, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1410", Offset = "0x6BCFA10", VA = "0x186BD1410")]
	private void GJDNDAOJHNI(NativeArray<float2> PPLHDGNCJBP, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD1500", Offset = "0x6BCFB00", VA = "0x186BD1500")]
	[BurstCompile]
	private unsafe static void GJDNDAOJHNI([NoAlias] ushort* OIEEJLIGKIK, [Out] float2 GLEOKCNEDKE, [Out] float2 OAKBDDLJNNB, [In][NoAlias] float2* PPLHDGNCJBP, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF580", Offset = "0x6BCDB80", VA = "0x186BCF580")]
	[BurstCompile]
	private static void DCODEHHAHMI([Out] float2 ONBAMJHHIMH, ushort IFANMHCOFBE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD67C0", Offset = "0x6BD4DC0", VA = "0x186BD67C0")]
	private void NHOJOAMCFEM(NativeArray<float2> OIEEJLIGKIK, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6BD66E0", Offset = "0x6BD4CE0", VA = "0x186BD66E0")]
	[BurstCompile]
	private unsafe static void NHOJOAMCFEM([NoAlias] float2* OIEEJLIGKIK, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6BCFBE0", Offset = "0x6BCE1E0", VA = "0x186BCFBE0")]
	[BurstCompile]
	private unsafe static void EIMHECDNKPJ([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6BCE510", Offset = "0x6BCCB10", VA = "0x186BCE510")]
	[BurstCompile]
	private unsafe static void CEOPDCBCCFL([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF7B0", Offset = "0x6BCDDB0", VA = "0x186BCF7B0")]
	[BurstCompile]
	private unsafe static void EEHMCJMKDPB([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6BD17C0", Offset = "0x6BCFDC0", VA = "0x186BD17C0")]
	[BurstCompile]
	private unsafe static void GLIGGJJCILI([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF480", Offset = "0x6BCDA80", VA = "0x186BCF480")]
	[BurstCompile]
	private unsafe static void CPOMGAALKIB([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [NoAlias] ushort* PPLHDGNCJBP, int KNHJBDAHGAE, [In] float2 CBENGDPLFDG, [In] float2 OAKBDDLJNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6BD42F0", Offset = "0x6BD28F0", VA = "0x186BD42F0")]
	private void LBEBIIJLOFB(NativeArray<float4> ONIEKFIGDDF, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6BD41D0", Offset = "0x6BD27D0", VA = "0x186BD41D0")]
	[BurstCompile]
	private unsafe static void LBEBIIJLOFB([NoAlias] ushort* MIBECCNHLEI, [In][NoAlias] float4* HKNLPMPLGGN, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6490", Offset = "0x6BD4A90", VA = "0x186BD6490")]
	[BurstCompile]
	private static ushort MPLMPGPDDJN([In] float4 NENCLBBCLLF)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6BD2F50", Offset = "0x6BD1550", VA = "0x186BD2F50")]
	private void IAFOCMEFFKJ(NativeArray<float4> MIBECCNHLEI, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3080", Offset = "0x6BD1680", VA = "0x186BD3080")]
	[BurstCompile]
	private unsafe static void IAFOCMEFFKJ([NoAlias] float4* MIBECCNHLEI, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6BCFCE0", Offset = "0x6BCE2E0", VA = "0x186BCFCE0")]
	[BurstCompile]
	private unsafe static void FAFMLGDGAGL([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4E80", Offset = "0x6BD3480", VA = "0x186BD4E80")]
	[BurstCompile]
	private unsafe static void LNAGIEJMHCK([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD4CC0", Offset = "0x6BD32C0", VA = "0x186BD4CC0")]
	[BurstCompile]
	private unsafe static void LKPCIJFDDJO([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD55D0", Offset = "0x6BD3BD0", VA = "0x186BD55D0")]
	[BurstCompile]
	private unsafe static void MCJDDIGCHNO([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3EA0", Offset = "0x6BD24A0", VA = "0x186BD3EA0")]
	[BurstCompile]
	private unsafe static void KFMHHECDOIE([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] ushort* ONIEKFIGDDF, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEF60", Offset = "0x6BCD560", VA = "0x186BCEF60")]
	[BurstCompile]
	private static void CMCAHILCJIB([Out] float4 POBDLJBBBCI, ushort IFANMHCOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6BD45E0", Offset = "0x6BD2BE0", VA = "0x186BD45E0")]
	private void LFGHMNEKPGF(Allocator NPNPKHEIOHB, NativeArray<float4> DLHFCHEPLOH, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6BD49E0", Offset = "0x6BD2FE0", VA = "0x186BD49E0")]
	[BurstCompile]
	private unsafe static void LFGHMNEKPGF([NoAlias] float4* GJLANIGGKKP, [NoAlias] byte* NOHFEANHPIM, [Out] int MKDBGICGMGD, [Out] int HJEHCGEKGEF, [NoAlias] float4* DLHFCHEPLOH, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF160", Offset = "0x6BCD760", VA = "0x186BCF160")]
	private static void CPJNELLHNMM(NativeArray<float4> JAJAOCLDAHG, NativeArray<EOJKEPKKMBN> OPCJLEAJHPA, NativeArray<byte> LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF340", Offset = "0x6BCD940", VA = "0x186BCF340")]
	[BurstCompile]
	private unsafe static void CPJNELLHNMM([NoAlias] float4* JAJAOCLDAHG, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3CC0", Offset = "0x6BD22C0", VA = "0x186BD3CC0")]
	[BurstCompile]
	private unsafe static void KFHGGFICDGN([NoAlias] JOIDBGKONGK.KKBIMIHMFDM* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6BD0230", Offset = "0x6BCE830", VA = "0x186BD0230")]
	[BurstCompile]
	private unsafe static void FDMLMMJFOHF([NoAlias] JOIDBGKONGK.NMBPNIGIGML* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6BD74B0", Offset = "0x6BD5AB0", VA = "0x186BD74B0")]
	[BurstCompile]
	private unsafe static void PHFLCIKNHCK([NoAlias] JOIDBGKONGK.JHPCPCCNNCJ* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6BCFFF0", Offset = "0x6BCE5F0", VA = "0x186BCFFF0")]
	[BurstCompile]
	private unsafe static void FCHCAGGNBDA([NoAlias] JOIDBGKONGK.FKICJMLKGNH* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6BCF9A0", Offset = "0x6BCDFA0", VA = "0x186BCF9A0")]
	[BurstCompile]
	private unsafe static void EFAIHOGGOKI([NoAlias] JOIDBGKONGK.GOCKDHAAOKA* NFJEDNOAEPA, [In][NoAlias] EOJKEPKKMBN* OPCJLEAJHPA, [In][NoAlias] byte* LEBHCIADPCE, int KNHJBDAHGAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6BD31D0", Offset = "0x6BD17D0", VA = "0x186BD31D0")]
	private void IEFNNJKBNEK(Allocator NPNPKHEIOHB, NativeArray<int> PONGLDBFKNH, int JJEEHICMMPC, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6BD36B0", Offset = "0x6BD1CB0", VA = "0x186BD36B0")]
	private static NativeArray<byte> IMGNBHHEMLO(Allocator NPNPKHEIOHB, NativeArray<int> PONGLDBFKNH, int OEADKPEDKKG)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6BD35B0", Offset = "0x6BD1BB0", VA = "0x186BD35B0")]
	[BurstCompile]
	private unsafe static int IMGNBHHEMLO([NoAlias] byte* GPOKJHGAKOP, [In][NoAlias] int* PONGLDBFKNH, int OEADKPEDKKG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6520", Offset = "0x6BD4B20", VA = "0x186BD6520")]
	private static void NCPCBOALDCO(NativeArray<int> LDDJIABCDOA, NativeArray<byte> NJOLLHHEACM, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6BD6640", Offset = "0x6BD4C40", VA = "0x186BD6640")]
	[BurstCompile]
	private unsafe static void NCPCBOALDCO([NoAlias] int* LDDJIABCDOA, [In][NoAlias] byte* NJOLLHHEACM, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6BD61D0", Offset = "0x6BD47D0", VA = "0x186BD61D0")]
	[BurstCompile]
	private unsafe static void MJBOHDJOKEK([NoAlias] ushort* LDDJIABCDOA, [In][NoAlias] byte* NJOLLHHEACM, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6BCEE20", Offset = "0x6BCD420", VA = "0x186BCEE20")]
	[BurstCompile]
	private static void CJNACMBICAL([Out] float3 ONBAMJHHIMH, ushort IFANMHCOFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6BD3B00", Offset = "0x6BD2100", VA = "0x186BD3B00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE81A0", Offset = "0x6BE67A0", VA = "0x186BE81A0")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6BE82C0", Offset = "0x6BE68C0", VA = "0x186BE82C0")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7EA0", Offset = "0x6BE64A0", VA = "0x186BE7EA0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7F40", Offset = "0x6BE6540", VA = "0x186BE7F40")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BDA340", Offset = "0x6BD8940", VA = "0x186BDA340")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA460", Offset = "0x6BD8A60", VA = "0x186BDA460")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9F70", Offset = "0x6BD8570", VA = "0x186BD9F70")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6BDA010", Offset = "0x6BD8610", VA = "0x186BDA010")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BD82F0", Offset = "0x6BD68F0", VA = "0x186BD82F0")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8410", Offset = "0x6BD6A10", VA = "0x186BD8410")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7FE0", Offset = "0x6BD65E0", VA = "0x186BD7FE0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8080", Offset = "0x6BD6680", VA = "0x186BD8080")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE86E0", Offset = "0x6BE6CE0", VA = "0x186BE86E0")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8800", Offset = "0x6BE6E00", VA = "0x186BE8800")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6BE8410", Offset = "0x6BE6A10", VA = "0x186BE8410")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6BE84B0", Offset = "0x6BE6AB0", VA = "0x186BE84B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE7A80", Offset = "0x6BE6080", VA = "0x186BE7A80")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7BA0", Offset = "0x6BE61A0", VA = "0x186BE7BA0")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6BE77B0", Offset = "0x6BE5DB0", VA = "0x186BE77B0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6BE7850", Offset = "0x6BE5E50", VA = "0x186BE7850")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BD7D70", Offset = "0x6BD6370", VA = "0x186BD7D70")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7E90", Offset = "0x6BD6490", VA = "0x186BD7E90")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6BD78F0", Offset = "0x6BD5EF0", VA = "0x186BD78F0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6BD7990", Offset = "0x6BD5F90", VA = "0x186BD7990")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BDB1B0", Offset = "0x6BD97B0", VA = "0x186BDB1B0")]
		[BurstDiscard]
		private static void MJCKNKCHHOJ(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6BDB2D0", Offset = "0x6BD98D0", VA = "0x186BDB2D0")]
		private static IntPtr MKPNHPCPCDP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6BDABB0", Offset = "0x6BD91B0", VA = "0x186BDABB0")]
		public static void AGENGMFGODJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public static void AIFHKOLJDOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6BDAC50", Offset = "0x6BD9250", VA = "0x186BDAC50")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BE1880", Offset = "0x6BDFE80", VA = "0x186BE1880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1020", Offset = "0x6BDF620", VA = "0x186BE1020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6BE1DC0", Offset = "0x6BE03C0", VA = "0x186BE1DC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CEFHDIFPAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6BDF200", Offset = "0x6BDD800", VA = "0x186BDF200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3390", Offset = "0x6BE1990", VA = "0x186BE3390")]
	public static EDAKOILPHEO PEMDMDGHPMI(NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(EDAKOILPHEO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6BE12C0", Offset = "0x6BDF8C0", VA = "0x186BE12C0")]
	public static void JBJBDADGHNA(EDAKOILPHEO EPNEBBGJHCO, Material KFGOIEOLDHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF070", Offset = "0x6BDD670", VA = "0x186BDF070", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1060", Offset = "0x6BDF660", VA = "0x186BE1060")]
	public void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB, bool GFDHFENNGJJ, bool PNPKPDDLCPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1380", Offset = "0x6BDF980", VA = "0x186BE1380")]
	public void JHPNGECMFKN(int NPFPKLGDKMF, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1860", Offset = "0x6BDFE60", VA = "0x186BE1860", Slot = "6")]
	public bool KKELICPKAMA(Mesh CBNKKMIFMKD, bool DBPEHOBDCBF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1400", Offset = "0x6BDFA00", VA = "0x186BE1400")]
	public bool KBFNHGEPLCH(Mesh CBNKKMIFMKD, bool DBPEHOBDCBF, bool DPFFAIDNOKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE18C0", Offset = "0x6BDFEC0", VA = "0x186BE18C0")]
	public bool LHLEDMOLOBE(Mesh CBNKKMIFMKD, JOIDBGKONGK DMPDFDFIJMN, bool DBPEHOBDCBF = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDE310", Offset = "0x6BDC910", VA = "0x186BDE310")]
	public void CGFLFOIBMEO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF2E0", Offset = "0x6BDD8E0", VA = "0x186BDF2E0")]
	[BurstCompile]
	public static int FICFPIELMHG(float NCPIGLMANIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF290", Offset = "0x6BDD890", VA = "0x186BDF290")]
	[BurstCompile]
	public static uint FICFPIELMHG([In] float4 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF240", Offset = "0x6BDD840", VA = "0x186BDF240")]
	[BurstCompile]
	public static uint FICFPIELMHG([In] float3 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF490", Offset = "0x6BDDA90", VA = "0x186BDF490")]
	public void FNNDPFCCMFI(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2510", Offset = "0x6BE0B10", VA = "0x186BE2510")]
	[BurstCompile]
	private unsafe static void NHDLKDJDDHE([NoAlias] NMBPNIGIGML* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1E90", Offset = "0x6BE0490", VA = "0x186BE1E90")]
	public void MIMADDFEGCH(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2590", Offset = "0x6BE0B90", VA = "0x186BE2590")]
	[BurstCompile]
	private unsafe static void NHNECDBGKNE([NoAlias] JHPCPCCNNCJ* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2610", Offset = "0x6BE0C10", VA = "0x186BE2610")]
	public void OLADNJMPJFO(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF180", Offset = "0x6BDD780", VA = "0x186BDF180")]
	[BurstCompile]
	private unsafe static void EGNILGPGBCD([NoAlias] FKICJMLKGNH* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0490", Offset = "0x6BDEA90", VA = "0x186BE0490")]
	public void HFHIGPECFKC(Mesh CBNKKMIFMKD, bool DPFFAIDNOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0130", Offset = "0x6BDE730", VA = "0x186BE0130")]
	[BurstCompile]
	private unsafe static void GPIDDCMINJB([NoAlias] GOCKDHAAOKA* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH, [Out] float3 DAGAEBGDPPB, [Out] float3 FPPKCDLGHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1E00", Offset = "0x6BE0400", VA = "0x186BE1E00")]
	public void LPCHLOOIKAH(Mesh CBNKKMIFMKD, NGBKHNBLCFF OJCKNPDLJJF, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFB10", Offset = "0x6BDE110", VA = "0x186BDFB10")]
	public void GGKHFFLDDLC(JOIDBGKONGK CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDAB0", Offset = "0x6BDC0B0", VA = "0x186BDDAB0")]
	public void BBEOLJBOHLI(JOIDBGKONGK MKLJJBDOOGE, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD920", Offset = "0x6BDBF20", VA = "0x186BDD920")]
	public long AJMCHHNECGH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDA50", Offset = "0x6BDC050", VA = "0x186BDDA50")]
	public static long AJMCHHNECGH(int BKLOIIIOBOB, int FFFKHOKBJML)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF3F0", Offset = "0x6BDD9F0", VA = "0x186BDF3F0")]
	public static long FJAOELNFMLO(int BKLOIIIOBOB, int FFFKHOKBJML, NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6BDF330", Offset = "0x6BDD930", VA = "0x186BDF330")]
	public long FJAOELNFMLO(NGBKHNBLCFF OJCKNPDLJJF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1800", Offset = "0x6BDFE00", VA = "0x186BE1800")]
	public void KJFODJCDOBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2D60", Offset = "0x6BE1360", VA = "0x186BE2D60")]
	public static void PBAFEKGLPFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6BDDBB0", Offset = "0x6BDC1B0", VA = "0x186BDDBB0")]
	public NGBKHNBLCFF BLAFMLNDDFC()
	{
		return default(NGBKHNBLCFF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6BE2C90", Offset = "0x6BE1290", VA = "0x186BE2C90")]
	public static (int, int) OPMDPGEBJKF(Mesh CBNKKMIFMKD)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6BDEF90", Offset = "0x6BDD590", VA = "0x186BDEF90")]
	public static int DJBMOLKBIAB(VertexAttributeDescriptor[] LDMEANPAGHA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6BE1250", Offset = "0x6BDF850", VA = "0x186BE1250")]
	public static long IJGGHCBNOOK(Mesh CBNKKMIFMKD, int JACHNOPPJBB, int ELPEDJEIBKF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
	public JOIDBGKONGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6BE01B0", Offset = "0x6BDE7B0", VA = "0x186BE01B0")]
	[BurstCompile]
	public static int HADOCNIBBFG(float NCPIGLMANIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0250", Offset = "0x6BDE850", VA = "0x186BE0250")]
	[BurstCompile]
	public static uint HADOCNIBBFG([In] float4 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE03E0", Offset = "0x6BDE9E0", VA = "0x186BE03E0")]
	[BurstCompile]
	public static uint HADOCNIBBFG([In] float3 LEKEIHPCIEI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6BDFD80", Offset = "0x6BDE380", VA = "0x186BDFD80")]
	[BurstCompile]
	public unsafe static void GIILMEECDOP([NoAlias] NMBPNIGIGML* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6BE0BD0", Offset = "0x6BDF1D0", VA = "0x186BE0BD0")]
	[BurstCompile]
	public unsafe static void HFNKLFHFJAC([NoAlias] JHPCPCCNNCJ* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6BDED90", Offset = "0x6BDD390", VA = "0x186BDED90")]
	[BurstCompile]
	public unsafe static void CHLEFHBFNLF([NoAlias] FKICJMLKGNH* NFJEDNOAEPA, int KNHJBDAHGAE, [In][NoAlias] float3* CPPOKDBIIIP, [In][NoAlias] float3* JNHDPLLEKKI, [In][NoAlias] float4* KPEAPECEMNE, [In][NoAlias] float2* EOIJNLNANPA, [In][NoAlias] float4* NMFFJMEBPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3050", Offset = "0x6BE1650", VA = "0x186BE3050")]
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
		[Cpp2IlInjected.Address(RVA = "0xF76270", Offset = "0xF74870", VA = "0x180F76270")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0xF75100", Offset = "0xF73700", VA = "0x180F75100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0xF76280", Offset = "0xF74880", VA = "0x180F76280")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0xF75930", Offset = "0xF73F30", VA = "0x180F75930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD160", Offset = "0x6BDB760", VA = "0x186BDD160")]
	public HKJIDIEMGKL(int GCIALEFHHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB420", Offset = "0x6BD9A20", VA = "0x186BDB420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB920", Offset = "0x6BD9F20", VA = "0x186BDB920")]
	public void LKJDFILLICP(JobHandle GDNIAPJJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBC50", Offset = "0x6BDA250", VA = "0x186BDBC50")]
	public void NLDGECDOCNG(HEIMBPMPLCJ JGCMECODHDI, KINAFICGJBF EONBNDEHCOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBAF0", Offset = "0x6BDA0F0", VA = "0x186BDBAF0")]
	public void MDGNMILNPAJ(BDBIBPGNJFM JGCMECODHDI, NativeArray<NNEBOAEPEKN> HIIBIPNKFFO, int KNHJBDAHGAE, int EHANMNGLAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6BDC120", Offset = "0x6BDA720", VA = "0x186BDC120")]
	public JobHandle PNEFFJFBHFD(JOIDBGKONGK HLJACFHFCGB, FJFLFEFKGGD FCAPBHNHPIK, float3 PKNJKJDBLDK, quaternion JLCEFOIBMAA, float NKGMNFLOPDP, bool BNHAGKKILIO, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6BDB5E0", Offset = "0x6BD9BE0", VA = "0x186BDB5E0")]
	public static JobHandle KDAIDNOJOJI(DFJCJLEBMPC GNKLOBOOKMM, JOIDBGKONGK HLJACFHFCGB, HEIMBPMPLCJ JGCMECODHDI, JobHandle GDNIAPJJBPI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6BDBE70", Offset = "0x6BDA470", VA = "0x186BDBE70")]
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
		[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x886FD0", Offset = "0x8855D0", VA = "0x180886FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD5B0", Offset = "0x6BDBBB0", VA = "0x186BDD5B0")]
	public ILGMALKOKIC(int NPFPKLGDKMF, int DCLJAMBNIMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD470", Offset = "0x6BDBA70", VA = "0x186BDD470", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6BDD4D0", Offset = "0x6BDBAD0", VA = "0x186BDD4D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BD9670", Offset = "0x6BD7C70", VA = "0x186BD9670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<HCEPBIJKIFD> LAOGNPPPAFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6BD9980", Offset = "0x6BD7F80", VA = "0x186BD9980")]
		get
		{
			return default(NativeList<HCEPBIJKIFD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static ILGMALKOKIC DOPHIEJELDJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6BD8EF0", Offset = "0x6BD74F0", VA = "0x186BD8EF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6BD87E0", Offset = "0x6BD6DE0", VA = "0x186BD87E0")]
	private static void DJFHBIEHOMH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8720", Offset = "0x6BD6D20", VA = "0x186BD8720")]
	public static int DFMOHLCOFNK(bool CNLACMHGOKE, int LLBNOKCCKPO, bool DHDBELCHMDF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8700", Offset = "0x6BD6D00", VA = "0x186BD8700")]
	private static int ANPEDNCAMAH(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9E10", Offset = "0x6BD8410", VA = "0x186BD9E10")]
	private static int PNCBIPDCABJ(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9550", Offset = "0x6BD7B50", VA = "0x186BD9550")]
	public static int GMLMAFHOJEN(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8750", Offset = "0x6BD6D50", VA = "0x186BD8750")]
	public static int DHDDNCDCMEH(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9700", Offset = "0x6BD7D00", VA = "0x186BD9700")]
	public static int JIDDNJFDGND(int HAPEMOJEECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6BD96F0", Offset = "0x6BD7CF0", VA = "0x186BD96F0")]
	private static int IKOGHACBPJA(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6BD95E0", Offset = "0x6BD7BE0", VA = "0x186BD95E0")]
	private static int GPCGHPNLBAE(int LLBNOKCCKPO, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9600", Offset = "0x6BD7C00", VA = "0x186BD9600")]
	public static int HOIHDBPFIDA(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9800", Offset = "0x6BD7E00", VA = "0x186BD9800")]
	public static int KEDFPNFPMIO(int CLOHFODGPFM, int LLBNOKCCKPO, int HAPEMOJEECM, bool BLMPAAIELEB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8ED0", Offset = "0x6BD74D0", VA = "0x186BD8ED0")]
	public static int DOEOHPPBPGC(int HAPEMOJEECM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9710", Offset = "0x6BD7D10", VA = "0x186BD9710")]
	public static ILGMALKOKIC KDBFFHMFECM(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6BD8F80", Offset = "0x6BD7580", VA = "0x186BD8F80")]
	private static ILGMALKOKIC EPFBHCLOJIO(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9890", Offset = "0x6BD7E90", VA = "0x186BD9890")]
	public static ILGMALKOKIC MHDHDFFMHPB(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9210", Offset = "0x6BD7810", VA = "0x186BD9210")]
	private static ILGMALKOKIC GBPAALGOCPF(int LLBNOKCCKPO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6BD9A10", Offset = "0x6BD8010", VA = "0x186BD9A10")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BDA810", Offset = "0x6BD8E10", VA = "0x186BDA810")]
	public GIOMCMJJKIO(NativeArray<NNEBOAEPEKN> BPJECLBEBFJ, int BHEAFIOEIAD = 1, Allocator NPNPKHEIOHB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6BDA720", Offset = "0x6BD8D20", VA = "0x186BDA720", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BE5900", Offset = "0x6BE3F00", VA = "0x186BE5900")]
	public KKKMEJIDJAB(HKJIDIEMGKL DNNEPMFIFCF, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5B80", Offset = "0x6BE4180", VA = "0x186BE5B80")]
	public KKKMEJIDJAB(GIOMCMJJKIO DNNEPMFIFCF, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float3 JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6BE57C0", Offset = "0x6BE3DC0", VA = "0x186BE57C0")]
	private float3 OPNNGPEKMEG(float3 EEFJAKFDDOC, Matrix4x4 NJBKNGCMEEK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3980", Offset = "0x6BE1F80", VA = "0x186BE3980")]
	private float3x3 BHPJNBFNMNI(float3x3 BFBBAEAGMDK, float3x3 MLJMICDNHII)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6BE58F0", Offset = "0x6BE3EF0", VA = "0x186BE58F0")]
	private float PGAOCLIFFPD(float DKEHAFKGJAC, float LFBABNCDFHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3E60", Offset = "0x6BE2460", VA = "0x186BE3E60", Slot = "4")]
	public void Execute(int LBBGOBFOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5650", Offset = "0x6BE3C50", VA = "0x186BE5650")]
	private void NBDOFNOKAEN(int LJMGNCELFLB, float3 LEELMECKGCG, float3 DBBPPLLNKOD, float3 DNAJPPCEHOF, float PPAGJHCGANB, bool MOACEDKKPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6BE3A00", Offset = "0x6BE2000", VA = "0x186BE3A00")]
	private void CAIBMOFHBHL(BDBIBPGNJFM FGBPKJBGJOD, float3 NJELOECLOIL, float3x3 CNFFBLAHCCM, float DKEHAFKGJAC, int JFHFKBGBPFN, int HPFIAJBHPMP, int GBEOOHKHNLI, float DJIAOMHLDJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5000", Offset = "0x6BE3600", VA = "0x186BE5000")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BD7800", Offset = "0x6BD5E00", VA = "0x186BD7800")]
	public DFJCJLEBMPC(int BHEAFIOEIAD, Allocator NPNPKHEIOHB = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6BD7760", Offset = "0x6BD5D60", VA = "0x186BD7760", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BE75C0", Offset = "0x6BE5BC0", VA = "0x186BE75C0")]
	public MFDCHBILLPH(HKJIDIEMGKL DNNEPMFIFCF, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6BE73E0", Offset = "0x6BE59E0", VA = "0x186BE73E0")]
	public MFDCHBILLPH(DFJCJLEBMPC JGCMECODHDI, JOIDBGKONGK MJEKCAFIPFK, float3 CIIBEDCDMIP, quaternion LDMDDBNEGLJ, float3 JBMFAKGHHCK, int FFHCFMOHBOL = 0, int NJCHHJGMIKA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6BE5FD0", Offset = "0x6BE45D0", VA = "0x186BE5FD0", Slot = "4")]
	public void Execute(int LBBGOBFOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6FE0", Offset = "0x6BE55E0", VA = "0x186BE6FE0")]
	private void OCODCLEBADN(float4x4 DNJCIEHPMCF, int LBBGOBFOJMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6F30", Offset = "0x6BE5530", VA = "0x186BE6F30")]
	private PIHNGLKGBAM GPHFGHGJIGP(float3 DBBPPLLNKOD)
	{
		return default(PIHNGLKGBAM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6BE7390", Offset = "0x6BE5990", VA = "0x186BE7390")]
	private float4 PBPNDEGFIJL(PIHNGLKGBAM ONLKOIGBDGH, int HGFDMIDEFHN)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6BE6FA0", Offset = "0x6BE55A0", VA = "0x186BE6FA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF36D0", Offset = "0x6BF1CD0", VA = "0x186BF36D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 MPMIDEELHJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3C80", Offset = "0x6BF2280", VA = "0x186BF3C80")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4050", Offset = "0x6BF2650", VA = "0x186BF4050")]
	public KINAFICGJBF(float3 LEELMECKGCG, quaternion JOLHFCINNMA, float3 BHEAFIOEIAD, PJBMHIHFKLM JLAAKHANEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6BF36E0", Offset = "0x6BF1CE0", VA = "0x186BF36E0")]
	public float BDAMGHNDCEF(float3 NJELOECLOIL, float EOPIHKJHPGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6BF38E0", Offset = "0x6BF1EE0", VA = "0x186BF38E0")]
	public bool BOMLJKDDGHB(float3 DBBPPLLNKOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3AD0", Offset = "0x6BF20D0", VA = "0x186BF3AD0")]
	public void IIPFNPOJABB(float3 KKMPKNILPDG, float3x3 DBCDGJOMFJP, float HIIDBMEKJDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6BF39D0", Offset = "0x6BF1FD0", VA = "0x186BF39D0")]
	private void GDPKCAGAAAA(float3 IFDMLAIJAHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6BF3D60", Offset = "0x6BF2360", VA = "0x186BF3D60")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BF0550", Offset = "0x6BEEB50", VA = "0x186BF0550")]
	public CPJDBENBDOC(JOIDBGKONGK CBNKKMIFMKD, float AKPMEKOKALB, int NBPJLJIBBHP, int JFHFKBGBPFN, NativeList<KINAFICGJBF> JGCMECODHDI, NativeArray<int> PFHAGDEAOOH, NativeList<HCEPBIJKIFD> KHAAOJGJFID, FJFLFEFKGGD FCAPBHNHPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFD50", Offset = "0x6BEE350", VA = "0x186BEFD50", Slot = "4")]
	public void Execute(int IPPLKDLFFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0490", Offset = "0x6BEEA90", VA = "0x186BF0490")]
	private bool IBGJMPCMLGJ(KINAFICGJBF MOKDKAEJAPP, KINAFICGJBF MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6BEFAB0", Offset = "0x6BEE0B0", VA = "0x186BEFAB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BF19E0", Offset = "0x6BEFFE0", VA = "0x186BF19E0")]
	public void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6BF18D0", Offset = "0x6BEFED0", VA = "0x186BF18D0")]
	public static long DAOGLONLOLA(int NPFPKLGDKMF, int DCLJAMBNIMH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6BF18F0", Offset = "0x6BEFEF0", VA = "0x186BF18F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1B00", Offset = "0x6BF0100", VA = "0x186BF1B00")]
	public void LKJDFILLICP(JobHandle GDNIAPJJBPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8912C0", Offset = "0x88F8C0", VA = "0x1808912C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BE9180", Offset = "0x6BE7780", VA = "0x186BE9180")]
	public BBIBKNINNEB(JOIDBGKONGK CBNKKMIFMKD, FJFLFEFKGGD FCAPBHNHPIK, int NJCHHJGMIKA = 0, int FFHCFMOHBOL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6BE8D40", Offset = "0x6BE7340", VA = "0x186BE8D40", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6BE9120", Offset = "0x6BE7720", VA = "0x186BE9120")]
	private void GFGMMFGDKPP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class NGKHFMMGAOA
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2E12870", Offset = "0x2E10E70", VA = "0x182E12870")]
	public static bool HFCOLOLGBOC<T>(NativeArray<T> DKEEEGEFALD, int BHEAFIOEIAD, Allocator NPNPKHEIOHB, NativeArrayOptions CLJCAFMAPFP = NativeArrayOptions.ClearMemory, int LMHGHCMMMFI = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2E129F0", Offset = "0x2E10FF0", VA = "0x182E129F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BF1BF0", Offset = "0x6BF01F0", VA = "0x186BF1BF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF2BA0", Offset = "0x6BF11A0", VA = "0x186BF2BA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2BE0", Offset = "0x6BF11E0", VA = "0x186BF2BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int OKNDMJMENAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6BF2B60", Offset = "0x6BF1160", VA = "0x186BF2B60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2C20", Offset = "0x6BF1220", VA = "0x186BF2C20")]
	public GDJEGFEFPKO(int NPFPKLGDKMF, int DCLJAMBNIMH, int PMBGNFBEJME, Allocator NPNPKHEIOHB = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2EF0", Offset = "0x6BF14F0", VA = "0x186BF2EF0")]
	public GDJEGFEFPKO(Mesh CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1D40", Offset = "0x6BF0340", VA = "0x186BF1D40", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF2860", Offset = "0x6BF0E60", VA = "0x186BF2860")]
	public void GGKHFFLDDLC(GDJEGFEFPKO CBNKKMIFMKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1E50", Offset = "0x6BF0450", VA = "0x186BF1E50")]
	private void EHELKMKHOND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF22E0", Offset = "0x6BF08E0", VA = "0x186BF22E0")]
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
	[Cpp2IlInjected.Address(RVA = "0x1610D90", Offset = "0x160F390", VA = "0x181610D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x96B660", Offset = "0x969C60", VA = "0x18096B660")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<HCEPBIJKIFD>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x96B4B0", Offset = "0x969AB0", VA = "0x18096B4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GDJEGFEFPKO JPMOJDIJBBE
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x886FC0", Offset = "0x8855C0", VA = "0x180886FC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x887040", Offset = "0x885640", VA = "0x180887040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6BF6A40", Offset = "0x6BF5040", VA = "0x186BF6A40")]
	public MANEHJEPDED(IEnumerable<GDJEGFEFPKO> CBLAEIHFGND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6BF69D0", Offset = "0x6BF4FD0", VA = "0x186BF69D0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BEF9A0", Offset = "0x6BEDFA0", VA = "0x186BEF9A0")]
	public static void PEGLLNMGGIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF6A0", Offset = "0x6BEDCA0", VA = "0x186BEF6A0")]
	public static NativeArray<float2> HLKHFANFDPK(NativeArray<float2> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<float2> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF8A0", Offset = "0x6BEDEA0", VA = "0x186BEF8A0")]
	public static NativeArray<float3> NOAMLEKDLNJ(NativeArray<float3> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<float3> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF5A0", Offset = "0x6BEDBA0", VA = "0x186BEF5A0")]
	public static NativeArray<float4> BDAPEGAEEED(NativeArray<float4> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<float4> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6BEF7A0", Offset = "0x6BEDDA0", VA = "0x186BEF7A0")]
	public static NativeArray<int> LFLLFCANJCC(NativeArray<int> KAHMBAFPPFO, int GJGKBBPGMHA, NativeArray<int> IIIMPGGPGOP, int GGGPIINDLOG)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9BD0", Offset = "0x2AA81D0", VA = "0x182AA9BD0")]
	private static void PLAJKMJLKNI<T>(NativeArray<T> DKEEEGEFALD, int EGPBIJMNNCM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2AA9AF0", Offset = "0x2AA80F0", VA = "0x182AA9AF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BF0C50", Offset = "0x6BEF250", VA = "0x186BF0C50")]
	public static uint BCDKMHEHFJC(float LEKLHMHBODB)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1670", Offset = "0x6BEFC70", VA = "0x186BF1670")]
	public static void ODNEGKAENHP(float4 NMFFJMEBPIH, float LNHKHKPDKII, [Out] uint CEIEIOJLKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1780", Offset = "0x6BEFD80", VA = "0x186BF1780")]
	public static void ODNEGKAENHP(float4 NMFFJMEBPIH, uint IGHBPKJJOKM, [Out] uint CEIEIOJLKNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF11E0", Offset = "0x6BEF7E0", VA = "0x186BF11E0")]
	public static void MANLJFHICEC(float3 AJOOHEHOJLD, float3 FDNFIFCEGLL, float4 HCCFAJGMNFJ, float2 LKMGDFCFIJD, float4 NMFFJMEBPIH, [Out] JOIDBGKONGK.FKICJMLKGNH PGDOLFANKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0F80", Offset = "0x6BEF580", VA = "0x186BF0F80")]
	public static void MANLJFHICEC(float3 AJOOHEHOJLD, float3 FDNFIFCEGLL, float4 HCCFAJGMNFJ, float2 LKMGDFCFIJD, float4 NMFFJMEBPIH, [Out] JOIDBGKONGK.GOCKDHAAOKA PGDOLFANKPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1430", Offset = "0x6BEFA30", VA = "0x186BF1430")]
	public static byte NCJNDHBNKOM(float KLABJGGMBGH)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0C60", Offset = "0x6BEF260", VA = "0x186BF0C60")]
	public static ushort DIGFOJKEJEM(float KLABJGGMBGH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0CB0", Offset = "0x6BEF2B0", VA = "0x186BF0CB0")]
	public static uint FICJFNNDOLD(float KLABJGGMBGH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6BF15E0", Offset = "0x6BEFBE0", VA = "0x186BF15E0")]
	public static float2 NHDIIFFNCOA(float2 LEKEIHPCIEI)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0E30", Offset = "0x6BEF430", VA = "0x186BF0E30")]
	public static float2 IBAENFAFLNM(float3 ODPGHJEEHCK)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6BF0CE0", Offset = "0x6BEF2E0", VA = "0x186BF0CE0")]
	public static void IAPACIDLNGC(float3 KLABJGGMBGH, [Out] float3 FKOAIOJOGJE, [Out] uint3 JJFOOLJLHLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6BF1480", Offset = "0x6BEFA80", VA = "0x186BF1480")]
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
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void LCPOMJLKCOC(bool OKBPIGPIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF05F0", Offset = "0x6BEEBF0", VA = "0x186BF05F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF0BA0", Offset = "0x6BEF1A0", VA = "0x186BF0BA0")]
		public void AMLGEKNOMHA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6BF0BD0", Offset = "0x6BEF1D0", VA = "0x186BF0BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x887AF0", Offset = "0x8860F0", VA = "0x180887AF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x88B6B0", Offset = "0x889CB0", VA = "0x18088B6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter HJLHLKFABID
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x88B6A0", Offset = "0x889CA0", VA = "0x18088B6A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer IJAICPPPECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8879F0", Offset = "0x885FF0", VA = "0x1808879F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x887AB0", Offset = "0x8860B0", VA = "0x180887AB0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> KNLBEOACLNF
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x887AA0", Offset = "0x8860A0", VA = "0x180887AA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x887930", Offset = "0x885F30", VA = "0x180887930")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BHNGOALBONG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA0BF70", Offset = "0xA0A570", VA = "0x180A0BF70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int AILHMPDAPEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x11AE4E0", Offset = "0x11ACAE0", VA = "0x1811AE4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6BFDDA0", Offset = "0x6BFC3A0", VA = "0x186BFDDA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<AGHAKNFLOIH> CKADLLCFPEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8841B0", Offset = "0x8827B0", VA = "0x1808841B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDBA0", Offset = "0x6BFC1A0", VA = "0x186BFDBA0")]
	public void GKEGAAKCBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6C01090", Offset = "0x6BFF690", VA = "0x186C01090")]
	private void NDGBNNEFKHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6C01CB0", Offset = "0x6C002B0", VA = "0x186C01CB0")]
	public ONLNIONNPJP(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6C00860", Offset = "0x6BFEE60", VA = "0x186C00860")]
	public void LKJDFILLICP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6C016B0", Offset = "0x6BFFCB0", VA = "0x186C016B0")]
	private void NKIPIHCIDLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDA90", Offset = "0x6BFC090", VA = "0x186BFDA90")]
	private void FGCKLAKMLMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6C017F0", Offset = "0x6BFFDF0", VA = "0x186C017F0")]
	public Mesh ODGKIKBGKCI(MeshFilter CMLFCFJPLNC, Transform FLDLBOHKNDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7A30", Offset = "0x6BF6030", VA = "0x186BF7A30")]
	private void BIIOEOKKLIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCA50", Offset = "0x6BFB050", VA = "0x186BFCA50")]
	public void DPLAMNGCGIK(AGHAKNFLOIH AEEKBCOCEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8DC0", Offset = "0x6BF73C0", VA = "0x186BF8DC0")]
	public bool CIJCCCNJEHE(AGHAKNFLOIH AEEKBCOCEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDA30", Offset = "0x6BFC030", VA = "0x186BFDA30")]
	public bool FEAHPDAAGAE(AGHAKNFLOIH AEEKBCOCEIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8E40", Offset = "0x6BF7440", VA = "0x186BF8E40", Slot = "4")]
	public virtual void CPACCADECEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7CC0", Offset = "0x6BF62C0", VA = "0x186BF7CC0")]
	public void CCHDKKMCFLL(Transform FBHNHMNFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD970", Offset = "0x6BFBF70", VA = "0x186BFD970")]
	private long FBLLNONKODE()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6BF78D0", Offset = "0x6BF5ED0", VA = "0x186BF78D0")]
	private long BHDOHNACADH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6BFAF20", Offset = "0x6BF9520", VA = "0x186BFAF20")]
	public bool DNPLPCAFBEK(Transform FBHNHMNFBHE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7F00", Offset = "0x6BF6500", VA = "0x186BF7F00")]
	public bool CEAFLDGLMEA(bool KKDLFAPPJCK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7070", Offset = "0x6BF5670", VA = "0x186BF7070")]
	private void BFBAHKFODIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE260", Offset = "0x6BFC860", VA = "0x186BFE260")]
	public bool JKBGDMOAIOD(float4x4 LENANFGCBLG, BatchedMeshRenderer IGHOGDFOOAD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDBC0", Offset = "0x6BFC1C0", VA = "0x186BFDBC0")]
	public void HEMJNAMFDLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6C00990", Offset = "0x6BFEF90", VA = "0x186C00990")]
	public bool LLBODCODEHE(bool KKDLFAPPJCK = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDBB0", Offset = "0x6BFC1B0", VA = "0x186BFDBB0")]
	public void HCNPKOGJOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6BFE230", Offset = "0x6BFC830", VA = "0x186BFE230")]
	public void IOLCMKLLLMI(JOIDBGKONGK CBNKKMIFMKD, int JCNLPPBCHDA, int EDGAMNENPOO, float EHDCBBHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9BF0", Offset = "0x6BF81F0", VA = "0x186BF9BF0")]
	public void DIGOFKIGGBN(CFLKOMOGAPG CGLFIOBCNKK, int JCNLPPBCHDA, int EDGAMNENPOO, float EHDCBBHAOCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7000", Offset = "0x6BF5600", VA = "0x186BF7000")]
	public (long, long, long) AJMCHHNECGH()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x93DEE0", Offset = "0x93C4E0", VA = "0x18093DEE0")]
	public long CBPGLMNBMMK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCBB0", Offset = "0x6BFB1B0", VA = "0x186BFCBB0")]
	private void EEHBLCHMHLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFB30", Offset = "0x6BFE130", VA = "0x186BFFB30")]
	public (long, long) KLJDOOABGHJ(float FOABPIOOEIB, float4x4 LENANFGCBLG)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public void DHGNDOHMADL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6BFCFB0", Offset = "0x6BFB5B0", VA = "0x186BFCFB0")]
	internal void EJBDNJOJABP(DCKIKLKGELD DLNGFNBCANM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6BFD0D0", Offset = "0x6BFB6D0", VA = "0x186BFD0D0")]
	private (float, float, float, float) EOKMNCOMGBE(float BNBHLEAMMCJ, float4x4 LENANFGCBLG)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6BF7870", Offset = "0x6BF5E70", VA = "0x186BF7870")]
	private float BGJAOPGACFJ(float BNBHLEAMMCJ, float4x4 LENANFGCBLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6C00CC0", Offset = "0x6BFF2C0", VA = "0x186C00CC0")]
	private (int, int) MLMMKALAPJM(float JAIMOJOCOPG)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6BF9EA0", Offset = "0x6BF84A0", VA = "0x186BF9EA0")]
	public void DJLIMOCJDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFAE0", Offset = "0x6BFE0E0", VA = "0x186BFFAE0")]
	private void JOPCPOFHMAB(JOIDBGKONGK FCFPLPDEGNH, JOIDBGKONGK.NGBKHNBLCFF BBEOMILKJME, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6BFF9E0", Offset = "0x6BFDFE0", VA = "0x186BFF9E0")]
	private void JOPCPOFHMAB([In] CFLKOMOGAPG FCFPLPDEGNH, JOIDBGKONGK.NGBKHNBLCFF BBEOMILKJME, bool DPFFAIDNOKC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6C01750", Offset = "0x6BFFD50", VA = "0x186C01750")]
	private void NODBINDPBFJ(JOIDBGKONGK.NGBKHNBLCFF BBEOMILKJME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDB70", Offset = "0x6BFC170", VA = "0x186BFDB70")]
	private void GIHAMJIBMMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6C01390", Offset = "0x6BFF990", VA = "0x186C01390")]
	private void NJNNGOJHMIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6BFFEB0", Offset = "0x6BFE4B0", VA = "0x186BFFEB0")]
	public long KOENAPMPHIO(long FFDOIMOLFOC, int LJAMLPDKGKL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6BF8ED0", Offset = "0x6BF74D0", VA = "0x186BF8ED0")]
	private void DHJOBINHIEI(JOIDBGKONGK GJBCGDADODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6BFDDC0", Offset = "0x6BFC3C0", VA = "0x186BFDDC0")]
	private void IHCOCNJJLMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6C01000", Offset = "0x6BFF600", VA = "0x186C01000")]
	private float MPAIFEKJMPN(int IJEPMMBCLMN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6BFC040", Offset = "0x6BFA640", VA = "0x186BFC040")]
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
		[Cpp2IlInjected.Address(RVA = "0x6BF31E0", Offset = "0x6BF17E0", VA = "0x186BF31E0")]
		public void HOKPIHKGMOB(int NPFPKLGDKMF, int DCLJAMBNIMH, Allocator NPNPKHEIOHB, bool PNPKPDDLCPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6BF3480", Offset = "0x6BF1A80", VA = "0x186BF3480")]
		public static ILGMNNBIDKK LKNNLDLLIBG(JOIDBGKONGK MILPHOELICC)
		{
			return default(ILGMNNBIDKK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6BF33C0", Offset = "0x6BF19C0", VA = "0x186BF33C0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6BF6180", Offset = "0x6BF4780", VA = "0x186BF6180")]
	public LDAAIPMLPDJ([In] List<ONLNIONNPJP.ECIAADBJJCO> PLJEFGJPEIH, [In] JOIDBGKONGK IIDNMKCCFKG, [In] ONLNIONNPJP POOBLNGOLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6BF54F0", Offset = "0x6BF3AF0", VA = "0x186BF54F0", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5770", Offset = "0x6BF3D70", VA = "0x186BF5770")]
	public void PDCFENBOOJH(List<ONLNIONNPJP.ECIAADBJJCO> EKKIHGHNNLD, [In] ONLNIONNPJP POOBLNGOLOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6BF60D0", Offset = "0x6BF46D0", VA = "0x186BF60D0")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool PPANCJKFMFH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6BF5540", Offset = "0x6BF3B40", VA = "0x186BF5540")]
	private CFLKOMOGAPG FFMBDKLIENC(int JDGGDOKJMAM, Allocator NPNPKHEIOHB)
	{
		return default(CFLKOMOGAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4560", Offset = "0x6BF2B60", VA = "0x186BF4560")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private void DEANEPCMBHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4240", Offset = "0x6BF2840", VA = "0x186BF4240")]
	[IgnoreWarning(1371)]
	private MEPADBGELAF CHIBINDAHPD([In] MEPADBGELAF MEALBCMKKDA, int KFAFEAGOMKO, [In] NativeArray<int> HCMMOHLNFNH, [In] NativeArray<bool> LPDKENFEBLE, NativeArray<int> ODLGOLEIKLL)
	{
		return default(MEPADBGELAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6BF4140", Offset = "0x6BF2740", VA = "0x186BF4140")]
	[BurstCompile]
	[IgnoreWarning(1371)]
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
			[Cpp2IlInjected.Address(RVA = "0x8879A0", Offset = "0x885FA0", VA = "0x1808879A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int IIFHKHANCHO
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6BEF550", Offset = "0x6BEDB50", VA = "0x186BEF550")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		private static void KBPAHJMJOGF(bool OKBPIGPIOLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		private static void KBPAHJMJOGF(bool OKBPIGPIOLB, string KFAOBDLOMDC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBB90", Offset = "0x6BEA190", VA = "0x186BEBB90")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9200", Offset = "0x6BE7800", VA = "0x186BE9200")]
		public ONLNIONNPJP AddToBatchedMesh(AGHAKNFLOIH JAOFDEECFJH, Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE5B0", Offset = "0x6BECBB0", VA = "0x186BEE5B0")]
		public void RemoveFromBatchedMesh(AGHAKNFLOIH CBNKKMIFMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9300", Offset = "0x6BE7900", VA = "0x186BE9300")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEDF0", Offset = "0x6BED3F0", VA = "0x186BEEDF0")]
		public void SetMaterialProperty(int CFNKBOPELEO, Color FEHNKBJAMFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE9A0", Offset = "0x6BECFA0", VA = "0x186BEE9A0")]
		public void SetMaterialProperty(int CFNKBOPELEO, float KLABJGGMBGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6BEEBC0", Offset = "0x6BED1C0", VA = "0x186BEEBC0")]
		public void SetMaterialProperty(int CFNKBOPELEO, Vector4 OJJHMMDBAFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6BEE740", Offset = "0x6BECD40", VA = "0x186BEE740")]
		public void SetMaterialProperty(int CFNKBOPELEO, Matrix4x4 NEOIADOHDBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9430", Offset = "0x6BE7A30", VA = "0x186BE9430")]
		private void EADFNANPAPD(Renderer MGJKLBPNDCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9CD0", Offset = "0x6BE82D0", VA = "0x186BE9CD0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9CC0", Offset = "0x6BE82C0", VA = "0x186BE9CC0")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9D70", Offset = "0x6BE8370", VA = "0x186BE9D70")]
		private void GPCOHONBJOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAEF0", Offset = "0x6BE94F0", VA = "0x186BEAEF0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6BE9A20", Offset = "0x6BE8020", VA = "0x186BE9A20")]
		private ONLNIONNPJP EDNECKFIMPL(AGHAKNFLOIH CBNKKMIFMKD, Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA9F0", Offset = "0x6BE8FF0", VA = "0x186BEA9F0")]
		private ONLNIONNPJP LAPDFMOLOLC(Material KFGOIEOLDHF, int GMEKMMJCJAF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB520", Offset = "0x6BE9B20", VA = "0x186BEB520")]
		private ONLNIONNPJP ONODMEOOAPM(Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB420", Offset = "0x6BE9A20", VA = "0x186BEB420")]
		private float4x4 OLFKIIBKIIK()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA8D0", Offset = "0x6BE8ED0", VA = "0x186BEA8D0")]
		private List<Material> KEJFDFLJEOI(Material KFGOIEOLDHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0xB80E40", Offset = "0xB7F440", VA = "0x180B80E40")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6BEAD60", Offset = "0x6BE9360", VA = "0x186BEAD60")]
		public void MarkDirty(AGHAKNFLOIH CBNKKMIFMKD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6BEB060", Offset = "0x6BE9660", VA = "0x186BEB060")]
		public (long, long) MemorySizeInBytesForChosenDetail(float FOABPIOOEIB)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6BED320", Offset = "0x6BEB920", VA = "0x186BED320")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x6BEA360", Offset = "0x6BE8960", VA = "0x186BEA360")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0x6BEBDF0", Offset = "0x6BEA3F0", VA = "0x186BEBDF0")]
		public void RebatchOptimally(int FIHEKEJPLJK, int LLGONPIPOMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x6BEF2E0", Offset = "0x6BED8E0", VA = "0x186BEF2E0")]
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
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0xACA040", Offset = "0xAC8640", VA = "0x180ACA040", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x6C07C30", Offset = "0x6C06230", VA = "0x186C07C30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0xC1B510", Offset = "0xC19B10", VA = "0x180C1B510")]
		[DebuggerHidden]
		public PCIHODJINPA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6C07C80", Offset = "0x6C06280", VA = "0x186C07C80", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C6")]
		[Cpp2IlInjected.Address(RVA = "0x6C06EC0", Offset = "0x6C054C0", VA = "0x186C06EC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6C06E70", Offset = "0x6C05470", VA = "0x186C06E70")]
		private void LFOMCLLDDBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6C06E20", Offset = "0x6C05420", VA = "0x186C06E20")]
		private void IOFDBJCEJOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0x6C07BE0", Offset = "0x6C061E0", VA = "0x186C07BE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6C07B30", Offset = "0x6C06130", VA = "0x186C07B30", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x6C07B30", Offset = "0x6C06130", VA = "0x186C07B30", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C02A80", Offset = "0x6C01080", VA = "0x186C02A80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void KBPAHJMJOGF(bool OKBPIGPIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void LCPOMJLKCOC(bool OKBPIGPIOLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	private static void KBPAHJMJOGF(bool OKBPIGPIOLB, string KFAOBDLOMDC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x885350", Offset = "0x883950", VA = "0x180885350")]
	public static void AMLGEKNOMHA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6C06050", Offset = "0x6C04650", VA = "0x186C06050")]
	public static void NDKOMOFBAMN(BatchedMeshRenderer FHCMLCHAIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6C02720", Offset = "0x6C00D20", VA = "0x186C02720")]
	public static void EOBGINAOLIP(BatchedMeshRenderer FHCMLCHAIBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6C02610", Offset = "0x6C00C10", VA = "0x186C02610")]
	private static (long, long, long) DLGEAJIDBNF(long JCMDFLNPAEB)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6C02B10", Offset = "0x6C01110", VA = "0x186C02B10")]
	public static bool GAMAJFDICMF(float JCPDLJECLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6C02FD0", Offset = "0x6C015D0", VA = "0x186C02FD0")]
	public static void JIGGKJEEEKK(float JCPDLJECLAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6C05E00", Offset = "0x6C04400", VA = "0x186C05E00")]
	public static bool MFDEFNHGKNI(float JCPDLJECLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6C03040", Offset = "0x6C01640", VA = "0x186C03040")]
	public static void JKBGDMOAIOD(long JCMDFLNPAEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6C05A70", Offset = "0x6C04070", VA = "0x186C05A70")]
	public static long KOENAPMPHIO(long FFDOIMOLFOC)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6C02D40", Offset = "0x6C01340", VA = "0x186C02D40")]
	public static void IBACBGIAAEF(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6C02C10", Offset = "0x6C01210", VA = "0x186C02C10")]
	public static void GNCDOPOPJMF(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float JIJJLMNBKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6C024E0", Offset = "0x6C00AE0", VA = "0x186C024E0")]
	public static void CLGOFKDGCLO(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float JIJJLMNBKDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6C061B0", Offset = "0x6C047B0", VA = "0x186C061B0")]
	public static void NGCPGAMKCFK(ONLNIONNPJP CGOMNMPAANI, BatchedMeshRenderer CLBGDEFKKHA, long GLGHIPHDEFE, float OOICLFNNFML, bool DPCNEDEEHPH, float OCBNPLFNECE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6C06590", Offset = "0x6C04B90", VA = "0x186C06590")]
	public static float OLDENPMHIBA(long LLMOBNHALEO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6C058A0", Offset = "0x6C03EA0", VA = "0x186C058A0")]
	public static (long, long) KLJDOOABGHJ(float FOABPIOOEIB)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6C063E0", Offset = "0x6C049E0", VA = "0x186C063E0")]
	[IteratorStateMachine(typeof(PCIHODJINPA))]
	public static IEnumerable<bool> OJNNCKJDFLN(long OJMCFOKMJEG, bool ANABDEAOCGH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6C021C0", Offset = "0x6C007C0", VA = "0x186C021C0")]
	public static void CDBLIFBKDNH(long OJMCFOKMJEG, bool ANABDEAOCGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6C05F10", Offset = "0x6C04510", VA = "0x186C05F10")]
	public static int NBKNGNFLEHI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6C02E80", Offset = "0x6C01480", VA = "0x186C02E80")]
	internal static JOIDBGKONGK ICFAJKCOOPF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x6C06500", Offset = "0x6C04B00", VA = "0x186C06500")]
	internal static void OKKMPHOGAFP(JOIDBGKONGK FJPCMKGPIGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x6C02390", Offset = "0x6C00990", VA = "0x186C02390")]
	internal static FJFLFEFKGGD CDLIJLBBHDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x6C06470", Offset = "0x6C04A70", VA = "0x186C06470")]
	internal static void OKKMPHOGAFP(FJFLFEFKGGD FCAPBHNHPIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x6C02BC0", Offset = "0x6C011C0", VA = "0x186C02BC0")]
	[CompilerGenerated]
	internal static void GHKNHMLLDIF(UnityEngine.Object GHMNBJIOGAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class GGGNMKNBIOM<KeyType> : ONLNIONNPJP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001F1")]
	private readonly Dictionary<KeyType, AGHAKNFLOIH> MDBHGNINPMO;

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6F90", Offset = "0x3DE5590", VA = "0x183DE6F90")]
	public GGGNMKNBIOM(string KJPHMNNIMDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6A60", Offset = "0x3DE5060", VA = "0x183DE6A60")]
	public void DPLAMNGCGIK(KeyType LFOBGDLOPID, AGHAKNFLOIH AEEKBCOCEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6D90", Offset = "0x3DE5390", VA = "0x183DE6D90")]
	public bool FLOOMNMEAMM(KeyType LFOBGDLOPID, AGHAKNFLOIH ANJEMIKMEKC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6AD0", Offset = "0x3DE50D0", VA = "0x183DE6AD0")]
	public void FEKKBBKAHCD(KeyType LFOBGDLOPID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DE6A00", Offset = "0x3DE5000", VA = "0x183DE6A00", Slot = "4")]
	public override void CPACCADECEE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x6C07DA0", Offset = "0x6C063A0", VA = "0x186C07DA0")]
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
