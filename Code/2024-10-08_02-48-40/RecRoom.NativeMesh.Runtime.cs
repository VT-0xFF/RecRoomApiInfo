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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
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
	public class LogRegistrationIndex : MPFOBEHAELD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6CEB190", Offset = "0x6CEA390", VA = "0x186CEB190", Slot = "4")]
		public override void ALGAFMBJNNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8BF5C0", Offset = "0x8BE7C0", VA = "0x1808BF5C0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class KFLAAKCDINP
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GAFGFHIJEHD CBEOKKGHJNH;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly GAFGFHIJEHD MOFKFDDFBJL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly GAFGFHIJEHD DIBGAMLEIGB;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class EICCLDHMPFA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public FDPDJBEOJJC GOCHEDLKNPG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KLJHAFCJJBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8941A0", Offset = "0x8933A0", VA = "0x1808941A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public EICCLDHMPFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct FDPDJBEOJJC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct CMIFHGFDCDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half FMJDMIMACCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort CFAAGBMGOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte ILGMJHKDLPO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker OGICJBMNPFC;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker JFCEEMBHCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int KLJHAFCJJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int AJAHOAGDDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> AJAEKNELACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> CLFKJKOBKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> EIFDCOABAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> LLFNNEIPPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<CMIFHGFDCDO> ENEMCHKAMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> KOMMKKHJBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> KMPPNLIKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 DMPJDKAALMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 JHAJMKJHBAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 CLJHJNPACBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 GNEAKHLPHMG;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long AMDKFDDKKLN;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long PADIIDINAII;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float EHOJCNBCPLF;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool CACJKNAKBII;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6CDCE90", Offset = "0x6CDC090", VA = "0x186CDCE90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CLDJGBJLBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6CE0D90", Offset = "0x6CDFF90", VA = "0x186CE0D90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE02A0", Offset = "0x6CDF4A0", VA = "0x186CE02A0")]
	public void OAFCGGBDEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD630", Offset = "0x6CDC830", VA = "0x186CDD630")]
	public static FDPDJBEOJJC LGJIMIKIEOH(Allocator PKPCACFEGCG, GBHEDBODDJM NLKLAHKPMMC)
	{
		return default(FDPDJBEOJJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD900", Offset = "0x6CDCB00", VA = "0x186CDD900")]
	public static FDPDJBEOJJC LGJIMIKIEOH(Allocator PKPCACFEGCG, NativeArray<float3> BCGNMFFCHNI, NativeArray<float3> MGFBNLMKELP, NativeArray<float2> FBEBHOGFPIM, NativeArray<float4> PNANLJABEKN, bool KCANNCDKMLC, NativeArray<float4> JHPOACAGBOE, NativeArray<int> NGHIEICILNM, int KLJHAFCJJBJ, int BOMAOOLCFNM, int AJAHOAGDDDF, int FLPOPJGPBJH)
	{
		return default(FDPDJBEOJJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDCA00", Offset = "0x6CDBC00", VA = "0x186CDCA00")]
	public GBHEDBODDJM JAGLDNGJHDE(Allocator PKPCACFEGCG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1640", Offset = "0x6CE0840", VA = "0x186CE1640")]
	public void PHCOCGFELEJ(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE0DD0", Offset = "0x6CDFFD0", VA = "0x186CE0DD0")]
	private void OIBBANDHALC(Mesh PGLODJCEFNN, NativeArray<ushort> KOABHCJLKEI, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8EC0", Offset = "0x6CD80C0", VA = "0x186CD8EC0")]
	public void BJECLKLCBLO(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE770", Offset = "0x6CDD970", VA = "0x186CDE770")]
	public void MHPBEBFCCIP(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6CE03C0", Offset = "0x6CDF5C0", VA = "0x186CE03C0")]
	public void OAFOKMPJKEB(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA5E0", Offset = "0x6CD97E0", VA = "0x186CDA5E0")]
	public void FJKKDCBKAFB(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBFF0", Offset = "0x6CDB1F0", VA = "0x186CDBFF0")]
	public void HPEPFMDLIND(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9C50", Offset = "0x6CD8E50", VA = "0x186CD9C50")]
	public void EHEPJGMNLFL(Mesh PGLODJCEFNN, GBHEDBODDJM.HBAKEAAINDK EAJPHFGLPOO, bool BHGKEEDDAMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9800", Offset = "0x6CD8A00", VA = "0x186CD9800")]
	public long BNHGHEIDIPN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6CDC990", Offset = "0x6CDBB90", VA = "0x186CDC990")]
	public long IOKIMCAIBGK(GBHEDBODDJM.HBAKEAAINDK EAJPHFGLPOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF210", Offset = "0x6CDE410", VA = "0x186CDF210")]
	private void MIMLEIDKJAM(int CHBDNMLMGCH, int KDCGIDBHDIF, Allocator PKPCACFEGCG, bool OBEAPIICIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF340", Offset = "0x6CDE540", VA = "0x186CDF340")]
	private void MLPINAJKOBI(NativeArray<float3> FCJJPFOOPMP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6CD37A0", Offset = "0x6CD29A0", VA = "0x186CD37A0")]
	[BurstCompile]
	private unsafe static void MLPINAJKOBI([NoAlias] float3* FCJJPFOOPMP, [In][NoAlias] ushort* BCGNMFFCHNI, int KLJHAFCJJBJ, [In] float3 DMPJDKAALMF, [In] float3 JHAJMKJHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB6B0", Offset = "0x6CDA8B0", VA = "0x186CDB6B0")]
	[BurstCompile]
	private unsafe static void HDMBEGPKFDN([NoAlias] GBHEDBODDJM.LNONKHIMKPK* FCJJPFOOPMP, [In][NoAlias] ushort* BCGNMFFCHNI, int KLJHAFCJJBJ, [In] float3 DMPJDKAALMF, [In] float3 JHAJMKJHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6CD83C0", Offset = "0x6CD75C0", VA = "0x186CD83C0")]
	[BurstCompile]
	private unsafe static void AJOOMBOAGNK([NoAlias] GBHEDBODDJM.INHCLBPDGDE* FCJJPFOOPMP, [In][NoAlias] ushort* BCGNMFFCHNI, int KLJHAFCJJBJ, [In] float3 DMPJDKAALMF, [In] float3 JHAJMKJHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8580", Offset = "0x6CD7780", VA = "0x186CD8580")]
	[BurstCompile]
	private unsafe static void BDKDCIMBOJH([NoAlias] GBHEDBODDJM.PPCEIGMAIOP* FCJJPFOOPMP, [In][NoAlias] ushort* BCGNMFFCHNI, int KLJHAFCJJBJ, [In] float3 DMPJDKAALMF, [In] float3 JHAJMKJHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8580", Offset = "0x6CD7780", VA = "0x186CD8580")]
	[BurstCompile]
	private unsafe static void JCMDLIAKOCA([NoAlias] GBHEDBODDJM.IOMAIGGJDHE* FCJJPFOOPMP, [In][NoAlias] ushort* BCGNMFFCHNI, int KLJHAFCJJBJ, [In] float3 DMPJDKAALMF, [In] float3 JHAJMKJHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6CDCD30", Offset = "0x6CDBF30", VA = "0x186CDCD30")]
	[BurstCompile]
	private unsafe static void KDHOBHECDGO([NoAlias] GBHEDBODDJM.PACGNHMLLIP* FCJJPFOOPMP, [In][NoAlias] ushort* BCGNMFFCHNI, int KLJHAFCJJBJ, [In] float3 DMPJDKAALMF, [In] float3 JHAJMKJHBAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1320", Offset = "0x6CE0520", VA = "0x186CE1320")]
	private void PDHFAHGJMHC(NativeArray<float3> BCGNMFFCHNI, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6CD3A00", Offset = "0x6CD2C00", VA = "0x186CD3A00")]
	[BurstCompile]
	private unsafe static void PDHFAHGJMHC([NoAlias] ushort* FCJJPFOOPMP, [Out] float3 ONLAOEFNHBN, [Out] float3 JHAJMKJHBAO, [In][NoAlias] float3* BCGNMFFCHNI, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8DE0", Offset = "0x6CD7FE0", VA = "0x186CD8DE0")]
	private void BHILAGCGIKK(NativeArray<float3> MGFBNLMKELP, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8B20", Offset = "0x6CD7D20", VA = "0x186CD8B20")]
	[BurstCompile]
	private unsafe static void BHILAGCGIKK([NoAlias] ushort* AIPOJPFHAJL, [In][NoAlias] float3* MGFBNLMKELP, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6CE01E0", Offset = "0x6CDF3E0", VA = "0x186CE01E0")]
	private void NNLNONKHOOD(NativeArray<float3> GHJIHLLOLED, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6CDFFE0", Offset = "0x6CDF1E0", VA = "0x186CDFFE0")]
	[BurstCompile]
	private unsafe static void NNLNONKHOOD([NoAlias] float3* GHJIHLLOLED, [In][NoAlias] ushort* MGFBNLMKELP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA3B0", Offset = "0x6CD95B0", VA = "0x186CDA3B0")]
	[BurstCompile]
	private unsafe static void FGDAPEMGKOO([NoAlias] GBHEDBODDJM.LNONKHIMKPK* FCJJPFOOPMP, [In][NoAlias] ushort* MGFBNLMKELP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6CDDEC0", Offset = "0x6CDD0C0", VA = "0x186CDDEC0")]
	[BurstCompile]
	private unsafe static void LKBBEOFEDCB([NoAlias] GBHEDBODDJM.INHCLBPDGDE* FCJJPFOOPMP, [In][NoAlias] ushort* MGFBNLMKELP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE1F0", Offset = "0x6CDD3F0", VA = "0x186CDE1F0")]
	[BurstCompile]
	private unsafe static void LOHOHPAEOLI([NoAlias] GBHEDBODDJM.PPCEIGMAIOP* FCJJPFOOPMP, [In][NoAlias] ushort* MGFBNLMKELP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1000", Offset = "0x6CE0200", VA = "0x186CE1000")]
	[BurstCompile]
	private unsafe static void PBJFDINFHDB([NoAlias] GBHEDBODDJM.IOMAIGGJDHE* FCJJPFOOPMP, [In][NoAlias] ushort* MGFBNLMKELP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE610", Offset = "0x6CDD810", VA = "0x186CDE610")]
	[BurstCompile]
	private unsafe static void MBFJFEINGNA([NoAlias] GBHEDBODDJM.PACGNHMLLIP* FCJJPFOOPMP, [In][NoAlias] ushort* MGFBNLMKELP, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB770", Offset = "0x6CDA970", VA = "0x186CDB770")]
	private void HFDOALFEOAJ(NativeArray<float2> FBEBHOGFPIM, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB860", Offset = "0x6CDAA60", VA = "0x186CDB860")]
	[BurstCompile]
	private unsafe static void HFDOALFEOAJ([NoAlias] ushort* FAGEFFHOCFE, [Out] float2 DELBLCHDGHE, [Out] float2 GNEAKHLPHMG, [In][NoAlias] float2* FBEBHOGFPIM, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9C00", Offset = "0x6CD8E00", VA = "0x186CD9C00")]
	[BurstCompile]
	private static void EEBOOBHFBHP([Out] float2 CBGIKIOKEAB, ushort AGFBEHHJAIO, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE410", Offset = "0x6CDD610", VA = "0x186CDE410")]
	private void LPINBDOAFFA(NativeArray<float2> FAGEFFHOCFE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE330", Offset = "0x6CDD530", VA = "0x186CDE330")]
	[BurstCompile]
	private unsafe static void LPINBDOAFFA([NoAlias] float2* FAGEFFHOCFE, [NoAlias] ushort* FBEBHOGFPIM, int KLJHAFCJJBJ, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8480", Offset = "0x6CD7680", VA = "0x186CD8480")]
	[BurstCompile]
	private unsafe static void BAEDLFLBMIC([NoAlias] GBHEDBODDJM.LNONKHIMKPK* FCJJPFOOPMP, [NoAlias] ushort* FBEBHOGFPIM, int KLJHAFCJJBJ, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6CD9B00", Offset = "0x6CD8D00", VA = "0x186CD9B00")]
	[BurstCompile]
	private unsafe static void DHGCNMOBKKI([NoAlias] GBHEDBODDJM.INHCLBPDGDE* FCJJPFOOPMP, [NoAlias] ushort* FBEBHOGFPIM, int KLJHAFCJJBJ, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE000", Offset = "0x6CDD200", VA = "0x186CDE000")]
	[BurstCompile]
	private unsafe static void LLELLHIFFBJ([NoAlias] GBHEDBODDJM.PPCEIGMAIOP* FCJJPFOOPMP, [NoAlias] ushort* FBEBHOGFPIM, int KLJHAFCJJBJ, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1760", Offset = "0x6CE0960", VA = "0x186CE1760")]
	[BurstCompile]
	private unsafe static void PINNKPFOJIM([NoAlias] GBHEDBODDJM.IOMAIGGJDHE* FCJJPFOOPMP, [NoAlias] ushort* FBEBHOGFPIM, int KLJHAFCJJBJ, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6CDAF10", Offset = "0x6CDA110", VA = "0x186CDAF10")]
	[BurstCompile]
	private unsafe static void FPBHCBFICFJ([NoAlias] GBHEDBODDJM.PACGNHMLLIP* FCJJPFOOPMP, [NoAlias] ushort* FBEBHOGFPIM, int KLJHAFCJJBJ, [In] float2 CLJHJNPACBL, [In] float2 GNEAKHLPHMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6CDFD10", Offset = "0x6CDEF10", VA = "0x186CDFD10")]
	private void NLGOKNGLPJP(NativeArray<float4> JHPOACAGBOE, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6CDFEC0", Offset = "0x6CDF0C0", VA = "0x186CDFEC0")]
	[BurstCompile]
	private unsafe static void NLGOKNGLPJP([NoAlias] ushort* DFOBMLFBMKL, [In][NoAlias] float4* FGCLBKAHIFO, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6CDE580", Offset = "0x6CDD780", VA = "0x186CDE580")]
	[BurstCompile]
	private static ushort MAPAPNMLJFH([In] float4 KBNNJOCBJFK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF9B0", Offset = "0x6CDEBB0", VA = "0x186CDF9B0")]
	private void NEGHPPHJBHJ(NativeArray<float4> DFOBMLFBMKL, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF860", Offset = "0x6CDEA60", VA = "0x186CDF860")]
	[BurstCompile]
	private unsafe static void NEGHPPHJBHJ([NoAlias] float4* DFOBMLFBMKL, [In][NoAlias] ushort* JHPOACAGBOE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBCE0", Offset = "0x6CDAEE0", VA = "0x186CDBCE0")]
	[BurstCompile]
	private unsafe static void HNHHLKJPJNG([NoAlias] GBHEDBODDJM.LNONKHIMKPK* FCJJPFOOPMP, [In][NoAlias] ushort* JHPOACAGBOE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1150", Offset = "0x6CE0350", VA = "0x186CE1150")]
	[BurstCompile]
	private unsafe static void PCAHNFLPEJN([NoAlias] GBHEDBODDJM.INHCLBPDGDE* FCJJPFOOPMP, [In][NoAlias] ushort* JHPOACAGBOE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDBB20", Offset = "0x6CDAD20", VA = "0x186CDBB20")]
	[BurstCompile]
	private unsafe static void HHMKKHKADPE([NoAlias] GBHEDBODDJM.PPCEIGMAIOP* FCJJPFOOPMP, [In][NoAlias] ushort* JHPOACAGBOE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1410", Offset = "0x6CE0610", VA = "0x186CE1410")]
	[BurstCompile]
	private unsafe static void PFNKFMIMOLD([NoAlias] GBHEDBODDJM.IOMAIGGJDHE* FCJJPFOOPMP, [In][NoAlias] ushort* JHPOACAGBOE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6CDFAE0", Offset = "0x6CDECE0", VA = "0x186CDFAE0")]
	[BurstCompile]
	private unsafe static void NJJHIKKJFNC([NoAlias] GBHEDBODDJM.PACGNHMLLIP* FCJJPFOOPMP, [In][NoAlias] ushort* JHPOACAGBOE, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB3B0", Offset = "0x6CDA5B0", VA = "0x186CDB3B0")]
	[BurstCompile]
	private static void GLFIBNKPGBB([Out] float4 KHPJAGHLNBM, ushort AGFBEHHJAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD070", Offset = "0x6CDC270", VA = "0x186CDD070")]
	private void LGCBDBBPCCD(Allocator PKPCACFEGCG, NativeArray<float4> PNANLJABEKN, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD470", Offset = "0x6CDC670", VA = "0x186CDD470")]
	[BurstCompile]
	private unsafe static void LGCBDBBPCCD([NoAlias] float4* NMKIMNCENNF, [NoAlias] byte* PIENAAPFDFC, [Out] int FGHMIHACJDD, [Out] int IKOGIHFBOOC, [NoAlias] float4* PNANLJABEKN, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8800", Offset = "0x6CD7A00", VA = "0x186CD8800")]
	private static void BFJPBBDAFPF(NativeArray<float4> CNLBCFNJBPL, NativeArray<CMIFHGFDCDO> JKDPIAPOCMC, NativeArray<byte> MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6CD89E0", Offset = "0x6CD7BE0", VA = "0x186CD89E0")]
	[BurstCompile]
	private unsafe static void BFJPBBDAFPF([NoAlias] float4* CNLBCFNJBPL, [In][NoAlias] CMIFHGFDCDO* JKDPIAPOCMC, [In][NoAlias] byte* MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6CD81E0", Offset = "0x6CD73E0", VA = "0x186CD81E0")]
	[BurstCompile]
	private unsafe static void AJJKNJGLHMF([NoAlias] GBHEDBODDJM.LNONKHIMKPK* FCJJPFOOPMP, [In][NoAlias] CMIFHGFDCDO* JKDPIAPOCMC, [In][NoAlias] byte* MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB1D0", Offset = "0x6CDA3D0", VA = "0x186CDB1D0")]
	[BurstCompile]
	private unsafe static void GHMHKIPMJCM([NoAlias] GBHEDBODDJM.INHCLBPDGDE* FCJJPFOOPMP, [In][NoAlias] CMIFHGFDCDO* JKDPIAPOCMC, [In][NoAlias] byte* MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6CDA1D0", Offset = "0x6CD93D0", VA = "0x186CDA1D0")]
	[BurstCompile]
	private unsafe static void EJPLDNGHLJM([NoAlias] GBHEDBODDJM.PPCEIGMAIOP* FCJJPFOOPMP, [In][NoAlias] CMIFHGFDCDO* JKDPIAPOCMC, [In][NoAlias] byte* MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB470", Offset = "0x6CDA670", VA = "0x186CDB470")]
	[BurstCompile]
	private unsafe static void GMDMIFNGODO([NoAlias] GBHEDBODDJM.IOMAIGGJDHE* FCJJPFOOPMP, [In][NoAlias] CMIFHGFDCDO* JKDPIAPOCMC, [In][NoAlias] byte* MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6CD98C0", Offset = "0x6CD8AC0", VA = "0x186CD98C0")]
	[BurstCompile]
	private unsafe static void DFGDKECCIFH([NoAlias] GBHEDBODDJM.PACGNHMLLIP* FCJJPFOOPMP, [In][NoAlias] CMIFHGFDCDO* JKDPIAPOCMC, [In][NoAlias] byte* MKDHCJENEOM, int KLJHAFCJJBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6CDCF70", Offset = "0x6CDC170", VA = "0x186CDCF70")]
	private void LFKHHODMFOH(Allocator PKPCACFEGCG, NativeArray<int> NGHIEICILNM, int FLPOPJGPBJH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF530", Offset = "0x6CDE730", VA = "0x186CDF530")]
	private static NativeArray<byte> NACAAEHBFAC(Allocator PKPCACFEGCG, NativeArray<int> NGHIEICILNM, int PDIEMOFAHOL)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6CDF430", Offset = "0x6CDE630", VA = "0x186CDF430")]
	[BurstCompile]
	private unsafe static int NACAAEHBFAC([NoAlias] byte* HODGCCEFJKN, [In][NoAlias] int* NGHIEICILNM, int PDIEMOFAHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB010", Offset = "0x6CDA210", VA = "0x186CDB010")]
	private static void GBCAFFIODKC(NativeArray<int> LNKOLAKFODF, NativeArray<byte> JMBBHGMCPOM, int AJAHOAGDDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6CDB130", Offset = "0x6CDA330", VA = "0x186CDB130")]
	[BurstCompile]
	private unsafe static void GBCAFFIODKC([NoAlias] int* LNKOLAKFODF, [In][NoAlias] byte* JMBBHGMCPOM, int AJAHOAGDDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6CDCED0", Offset = "0x6CDC0D0", VA = "0x186CDCED0")]
	[BurstCompile]
	private unsafe static void KMCMBBOMCIJ([NoAlias] ushort* LNKOLAKFODF, [In][NoAlias] byte* JMBBHGMCPOM, int AJAHOAGDDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6CD96C0", Offset = "0x6CD88C0", VA = "0x186CD96C0")]
	[BurstCompile]
	private static void BKNKNIEAHGO([Out] float3 CBGIKIOKEAB, ushort AGFBEHHJAIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6CD8640", Offset = "0x6CD7840", VA = "0x186CD8640")]
	[BurstCompile]
	private static ushort BDOEOGKDCJN([In] float3 KBNNJOCBJFK)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class GBHEDBODDJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum HBAKEAAINDK
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
	public enum JGKAFLIMFDG
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
	public struct IFIEIJNFNPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public HBAKEAAINDK EAJPHFGLPOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool BPCHDPGMEIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int IOINCIBCDLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct AEPODOMMMAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 FJFKFIAGEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 DJCLDHHAKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 ANKNPCHEJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 IDNBAAJMDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 ENEMCHKAMAL;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct LNONKHIMKPK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 FJFKFIAGEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 DJCLDHHAKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 ANKNPCHEJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 IDNBAAJMDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 ENEMCHKAMAL;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct INHCLBPDGDE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 FJFKFIAGEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint DJCLDHHAKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint ANKNPCHEJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 IDNBAAJMDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 ENEMCHKAMAL;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct PPCEIGMAIOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 FJFKFIAGEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint DJCLDHHAKMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint ANKNPCHEJPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 IDNBAAJMDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 ENEMCHKAMAL;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct IOMAIGGJDHE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 FJFKFIAGEPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint PLIBMHKCFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 IDNBAAJMDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint JDGOFPGCIFN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint ONFNABMLFON;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct PACGNHMLLIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public FHEIMJELIPA.GPCIKKCPGMF EECPBKFKKIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint PLIBMHKCFOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 IDNBAAJMDEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint JDGOFPGCIFN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] GBKNFLLMPDK;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int GMIHKGOKJHP(float AKHPALIKFFK);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class CHGODEKLGHP
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6C10", Offset = "0x6CD5E10", VA = "0x186CD6C10")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6A20", Offset = "0x6CD5C20", VA = "0x186CD6A20")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6B70", Offset = "0x6CD5D70", VA = "0x186CD6B70")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD67C0", Offset = "0x6CD59C0", VA = "0x186CD67C0")]
		public static int BAPLBLGGGFM(float AKHPALIKFFK)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint AICIBHMPPEK([In] float4 IGDCKHODAOC);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class GHCPFAFHLBP
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA870", Offset = "0x6CE9A70", VA = "0x186CEA870")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA680", Offset = "0x6CE9880", VA = "0x186CEA680")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA7D0", Offset = "0x6CE99D0", VA = "0x186CEA7D0")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6CEA350", Offset = "0x6CE9550", VA = "0x186CEA350")]
		public static uint BAPLBLGGGFM([In] float4 IGDCKHODAOC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint POKAOMCJFPO([In] float3 IGDCKHODAOC);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class EMNLHKNHJBD
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7860", Offset = "0x6CD6A60", VA = "0x186CD7860")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7670", Offset = "0x6CD6870", VA = "0x186CD7670")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6CD77C0", Offset = "0x6CD69C0", VA = "0x186CD77C0")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7400", Offset = "0x6CD6600", VA = "0x186CD7400")]
		public static uint BAPLBLGGGFM([In] float3 IGDCKHODAOC)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void JDDCHMIGHBM([NoAlias] INHCLBPDGDE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class DHEIOGPAKDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7150", Offset = "0x6CD6350", VA = "0x186CD7150")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6F60", Offset = "0x6CD6160", VA = "0x186CD6F60")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6CD70B0", Offset = "0x6CD62B0", VA = "0x186CD70B0")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6CD6D30", Offset = "0x6CD5F30", VA = "0x186CD6D30")]
		public unsafe static void BAPLBLGGGFM([NoAlias] INHCLBPDGDE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void GBJEHKDLPDF([NoAlias] PPCEIGMAIOP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class MCGGNKMBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6CEB7D0", Offset = "0x6CEA9D0", VA = "0x186CEB7D0")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6CEB5E0", Offset = "0x6CEA7E0", VA = "0x186CEB5E0")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6CEB730", Offset = "0x6CEA930", VA = "0x186CEB730")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6CEB3B0", Offset = "0x6CEA5B0", VA = "0x186CEB3B0")]
		public unsafe static void BAPLBLGGGFM([NoAlias] PPCEIGMAIOP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void NPGGGPLGIDE([NoAlias] IOMAIGGJDHE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class GBBHCBMBNPC
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6CE4260", Offset = "0x6CE3460", VA = "0x186CE4260")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6CE4070", Offset = "0x6CE3270", VA = "0x186CE4070")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6CE41C0", Offset = "0x6CE33C0", VA = "0x186CE41C0")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6CE3C90", Offset = "0x6CE2E90", VA = "0x186CE3C90")]
		public unsafe static void BAPLBLGGGFM([NoAlias] IOMAIGGJDHE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void BPNAJIEHKGH([NoAlias] PACGNHMLLIP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL, [Out] float3 NHBPCFFBFKB, [Out] float3 AGAIJOPAABO);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class EPIOBBKOEMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr IGJDCNCBBOH;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr HPEGMPJFIPM;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6CD80C0", Offset = "0x6CD72C0", VA = "0x186CD80C0")]
		[BurstDiscard]
		private static void LFNDJDCCONL(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7ED0", Offset = "0x6CD70D0", VA = "0x186CD7ED0")]
		private static IntPtr BOPOOGEIJOP()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6CD8020", Offset = "0x6CD7220", VA = "0x186CD8020")]
		public static void JILACFCGDJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public static void DDNLIMMJHCH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6CD7980", Offset = "0x6CD6B80", VA = "0x186CD7980")]
		public unsafe static void BAPLBLGGGFM([NoAlias] PACGNHMLLIP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL, [Out] float3 NHBPCFFBFKB, [Out] float3 AGAIJOPAABO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int GHPIIEDCJOI = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> NEBAHGOBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> IAAODIFPJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> IPJOFMAJMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> BKJPCIENLPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> BGNCKLOKLGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> BHJOIFFLEPD;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] DJFGDCBNLAG;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool GMHPGKFNKOL;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static IFIEIJNFNPJ[] IBJGJJHOIMH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool IDJFCBEKMDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7EA0", Offset = "0x6CE70A0", VA = "0x186CE7EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BCMOHEPODGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6CE99A0", Offset = "0x6CE8BA0", VA = "0x186CE99A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JHCDKDJOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6CE7430", Offset = "0x6CE6630", VA = "0x186CE7430")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool CLDJGBJLBPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6CE98E0", Offset = "0x6CE8AE0", VA = "0x186CE98E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7E50", Offset = "0x6CE7050", VA = "0x186CE7E50")]
	public static JGKAFLIMFDG JHNHDAJILJF(HBAKEAAINDK EAJPHFGLPOO)
	{
		return default(JGKAFLIMFDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6CE58F0", Offset = "0x6CE4AF0", VA = "0x186CE58F0")]
	public static void DFIDNBOFJFJ(JGKAFLIMFDG LJMHGJPPAGA, Material JEDKLDMCCCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5D70", Offset = "0x6CE4F70", VA = "0x186CE5D70", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8C10", Offset = "0x6CE7E10", VA = "0x186CE8C10")]
	public void MIMLEIDKJAM(int CHBDNMLMGCH, int KDCGIDBHDIF, Allocator PKPCACFEGCG, bool EEFEGHJAFND, bool OBEAPIICIKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9920", Offset = "0x6CE8B20", VA = "0x186CE9920")]
	public void OGOGJIEIHHF(int CHBDNMLMGCH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4380", Offset = "0x6CE3580", VA = "0x186CE4380", Slot = "6")]
	public bool BHIOBIOAGHK(Mesh PGLODJCEFNN, bool AOOKMAGOBFJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE99E0", Offset = "0x6CE8BE0", VA = "0x186CE99E0")]
	public bool PHCOCGFELEJ(Mesh PGLODJCEFNN, bool AOOKMAGOBFJ, bool BHGKEEDDAMC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE6720", Offset = "0x6CE5920", VA = "0x186CE6720")]
	public bool GMLEMBHPAPG(Mesh PGLODJCEFNN, GBHEDBODDJM CKOMBEHBBMM, bool AOOKMAGOBFJ = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE43A0", Offset = "0x6CE35A0", VA = "0x186CE43A0")]
	public void BJECLKLCBLO(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8530", Offset = "0x6CE7730", VA = "0x186CE8530")]
	[BurstCompile]
	public static int LOHNCMAKNNG(float AKHPALIKFFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8490", Offset = "0x6CE7690", VA = "0x186CE8490")]
	[BurstCompile]
	public static uint LOHNCMAKNNG([In] float4 IGDCKHODAOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6CE84E0", Offset = "0x6CE76E0", VA = "0x186CE84E0")]
	[BurstCompile]
	public static uint LOHNCMAKNNG([In] float3 IGDCKHODAOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8580", Offset = "0x6CE7780", VA = "0x186CE8580")]
	public void MHPBEBFCCIP(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9DE0", Offset = "0x6CE8FE0", VA = "0x186CE9DE0")]
	[BurstCompile]
	private unsafe static void PLNIGBFOLAB([NoAlias] INHCLBPDGDE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6CE91F0", Offset = "0x6CE83F0", VA = "0x186CE91F0")]
	public void OAFOKMPJKEB(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8E80", Offset = "0x6CE8080", VA = "0x186CE8E80")]
	[BurstCompile]
	private unsafe static void NJFDHFABKIL([NoAlias] PPCEIGMAIOP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6CE6010", Offset = "0x6CE5210", VA = "0x186CE6010")]
	public void FJKKDCBKAFB(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6CE66A0", Offset = "0x6CE58A0", VA = "0x186CE66A0")]
	[BurstCompile]
	private unsafe static void FKPKJDCJPEE([NoAlias] IOMAIGGJDHE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7470", Offset = "0x6CE6670", VA = "0x186CE7470")]
	public void HPEPFMDLIND(Mesh PGLODJCEFNN, bool BHGKEEDDAMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8E00", Offset = "0x6CE8000", VA = "0x186CE8E00")]
	[BurstCompile]
	private unsafe static void NCLJEBKFJDI([NoAlias] PACGNHMLLIP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL, [Out] float3 NHBPCFFBFKB, [Out] float3 AGAIJOPAABO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5F80", Offset = "0x6CE5180", VA = "0x186CE5F80")]
	public void EHEPJGMNLFL(Mesh PGLODJCEFNN, HBAKEAAINDK EAJPHFGLPOO, bool BHGKEEDDAMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7EE0", Offset = "0x6CE70E0", VA = "0x186CE7EE0")]
	public void KKPEAPDMHAN(GBHEDBODDJM PGLODJCEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5E80", Offset = "0x6CE5080", VA = "0x186CE5E80")]
	public void EDOMKIFDBNF(GBHEDBODDJM KLCFDAPKGEC, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4E40", Offset = "0x6CE4040", VA = "0x186CE4E40")]
	public long BNHGHEIDIPN()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4DE0", Offset = "0x6CE3FE0", VA = "0x186CE4DE0")]
	public static long BNHGHEIDIPN(int GLBCKFEFPEJ, int LANGKEFENJG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7C80", Offset = "0x6CE6E80", VA = "0x186CE7C80")]
	public static long IOKIMCAIBGK(int GLBCKFEFPEJ, int LANGKEFENJG, HBAKEAAINDK EAJPHFGLPOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7D20", Offset = "0x6CE6F20", VA = "0x186CE7D20")]
	public long IOKIMCAIBGK(HBAKEAAINDK EAJPHFGLPOO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6CE9880", Offset = "0x6CE8A80", VA = "0x186CE9880")]
	public void OAIFJICGMOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8F00", Offset = "0x6CE8100", VA = "0x186CE8F00")]
	public static void NNGNFCPIDMC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5190", Offset = "0x6CE4390", VA = "0x186CE5190")]
	public HBAKEAAINDK CKLEMAKOBFL()
	{
		return default(HBAKEAAINDK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7BB0", Offset = "0x6CE6DB0", VA = "0x186CE7BB0")]
	public static (int, int) IFIAGGNABMC(Mesh PGLODJCEFNN)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6CE59B0", Offset = "0x6CE4BB0", VA = "0x186CE59B0")]
	public static int DJDFKLMPIHE(VertexAttributeDescriptor[] JCILFHOOHHJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7DE0", Offset = "0x6CE6FE0", VA = "0x186CE7DE0")]
	public static long JDEBOGHFEIJ(Mesh PGLODJCEFNN, int JAOLGBGLDBD, int PEOJGECAJPD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public GBHEDBODDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5C20", Offset = "0x6CE4E20", VA = "0x186CE5C20")]
	[BurstCompile]
	public static int DKBHFKHNCAH(float AKHPALIKFFK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5A90", Offset = "0x6CE4C90", VA = "0x186CE5A90")]
	[BurstCompile]
	public static uint DKBHFKHNCAH([In] float4 IGDCKHODAOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6CE5CC0", Offset = "0x6CE4EC0", VA = "0x186CE5CC0")]
	[BurstCompile]
	public static uint DKBHFKHNCAH([In] float3 IGDCKHODAOC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6CE7070", Offset = "0x6CE6270", VA = "0x186CE7070")]
	[BurstCompile]
	public unsafe static void HDNMFFNLBBE([NoAlias] INHCLBPDGDE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6CE6C20", Offset = "0x6CE5E20", VA = "0x186CE6C20")]
	[BurstCompile]
	public unsafe static void HBMHPOGPEOJ([NoAlias] PPCEIGMAIOP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6CE4F90", Offset = "0x6CE4190", VA = "0x186CE4F90")]
	[BurstCompile]
	public unsafe static void CKDNKCHOCPE([NoAlias] IOMAIGGJDHE* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6CE8150", Offset = "0x6CE7350", VA = "0x186CE8150")]
	[BurstCompile]
	public unsafe static void LBAIHGKMENP([NoAlias] PACGNHMLLIP* FCJJPFOOPMP, int KLJHAFCJJBJ, [In][NoAlias] float3* AHDJKPEJNLH, [In][NoAlias] float3* CLFKJKOBKDF, [In][NoAlias] float4* EIFDCOABAFB, [In][NoAlias] float2* LLFNNEIPPJH, [In][NoAlias] float4* ENEMCHKAMAL, [Out] float3 NHBPCFFBFKB, [Out] float3 AGAIJOPAABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct DCGJIPKNPKM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int FICGIPBOOKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 JEAPKMAGJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion CCAKPJGKLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 KOHOKMJMHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int FJOLPIAIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int NGHCCCHGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int GNGAPLJKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float AMNJEHPCAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 BKCIOBONEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool AOIEMIDKOCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public LMMLNLGIKBO EJBGJNGDLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 OHHKHBACNAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float GLPECBOIKOH;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class POAFFFIKCOC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static BNOHAKLACAM HNINJGFEIOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<DCGJIPKNPKM> AAAFMKACBOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<KOOHKEIPECB> EIBMENIKGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<CKHJIHCDHIA> JHIHALPPNMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<LINEJHJGLFA> OIHMMIKKCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<KOOHKEIPECB> JIMDDNIMMIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<MLCBNKEIAHL> LGELGHIHICK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<LINEJHJGLFA>> BFNEEPMODBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<LDBGPHIHGKA> HDJKEPCJADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> HDMEHGOAFMP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int BCMOHEPODGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x90F9E0", Offset = "0x90EBE0", VA = "0x18090F9E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x90E310", Offset = "0x90D510", VA = "0x18090E310")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JHCDKDJOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x90F9D0", Offset = "0x90EBD0", VA = "0x18090F9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x90E300", Offset = "0x90D500", VA = "0x18090E300")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6CEF250", Offset = "0x6CEE450", VA = "0x186CEF250")]
	public POAFFFIKCOC(int GANFELHJBHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6CED510", Offset = "0x6CEC710", VA = "0x186CED510", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6CEEE60", Offset = "0x6CEE060", VA = "0x186CEEE60")]
	public void OAFCGGBDEDH(JobHandle PLDBJICEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6CEF030", Offset = "0x6CEE230", VA = "0x186CEF030")]
	public void PPFPJJBHLJO(DCGJIPKNPKM LJIEGDEDOHM, LDBGPHIHGKA HKHGCJGEGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6CEED00", Offset = "0x6CEDF00", VA = "0x186CEED00")]
	public void MCJBNECGFGL(CKHJIHCDHIA LJIEGDEDOHM, NativeArray<LINEJHJGLFA> BGMAIIMBDAI, int KLJHAFCJJBJ, int AJAHOAGDDDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6CED6D0", Offset = "0x6CEC8D0", VA = "0x186CED6D0")]
	public JobHandle EGKLGHDCLMD(GBHEDBODDJM HOCCOJDGAMA, KNEEGJKHLFG FFEOMKKKGMH, float3 FEKOPBDFHGD, quaternion ILNPKDCELNM, float PDGACCCGNGP, bool NNBHJMNFOBI, int IHCNMODHHDN = 0, int MPAKEGAOILO = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6CEE9C0", Offset = "0x6CEDBC0", VA = "0x186CEE9C0")]
	public static JobHandle FLAPNGBMEDL(DPBPKLMPLKJ PHGMEBDJFAM, GBHEDBODDJM HOCCOJDGAMA, DCGJIPKNPKM LJIEGDEDOHM, JobHandle PLDBJICEKIC)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6CEE710", Offset = "0x6CED910", VA = "0x186CEE710")]
	public static JobHandle EJDNELBAFNK(OEKHMCBMMIK PHGMEBDJFAM, GBHEDBODDJM HOCCOJDGAMA, CKHJIHCDHIA LJIEGDEDOHM, NativeArray<LINEJHJGLFA> BGMAIIMBDAI, int KLJHAFCJJBJ, int AJAHOAGDDDF, JobHandle PLDBJICEKIC)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct KHAOKCHGKBB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 AMCDMMKKGLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 CNJLAAFJLHJ;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class KPOLDODMGKK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<KHAOKCHGKBB> KCIJCLIBIMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> BOCMBJMGKCB;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int BCMOHEPODGA
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x89A5B0", Offset = "0x8997B0", VA = "0x18089A5B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JHCDKDJOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x897BF0", Offset = "0x896DF0", VA = "0x180897BF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6CEAF10", Offset = "0x6CEA110", VA = "0x186CEAF10")]
	public KPOLDODMGKK(int CHBDNMLMGCH, int KDCGIDBHDIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6CEADD0", Offset = "0x6CE9FD0", VA = "0x186CEADD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6CEAE30", Offset = "0x6CEA030", VA = "0x186CEAE30")]
	public void KKPEAPDMHAN(KPOLDODMGKK JCDPLMMMBPB, int DCBDFHCGLCO, int GFHPFKLIAOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class NCOLFEOMHBN
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static KPOLDODMGKK NGJCLONHAIO;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<KOOHKEIPECB> FKNICKEHAON;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] EDNNDCLLONK;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool GFMMALALAEF;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, KPOLDODMGKK> DDKIFBGLIFN;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, KPOLDODMGKK> BIJAONPNKGB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool NFOPOAAEHAK
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6CEC620", Offset = "0x6CEB820", VA = "0x186CEC620")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<KOOHKEIPECB> EHEEPKDHMEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6CEC6A0", Offset = "0x6CEB8A0", VA = "0x186CEC6A0")]
		get
		{
			return default(NativeList<KOOHKEIPECB>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static KPOLDODMGKK HIGGEMHHFJI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6CEC750", Offset = "0x6CEB950", VA = "0x186CEC750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6CEBB00", Offset = "0x6CEAD00", VA = "0x186CEBB00")]
	private static void DGLGBHLAAFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC5D0", Offset = "0x6CEB7D0", VA = "0x186CEC5D0")]
	public static int IEPGKMLGOCC(bool CEDLPHANJJK, int BIIPHDAINOK, bool MMMODEDHNGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC600", Offset = "0x6CEB800", VA = "0x186CEC600")]
	private static int IOLPIHOOHFD(int BIIPHDAINOK, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC5C0", Offset = "0x6CEB7C0", VA = "0x186CEC5C0")]
	private static int ICLHFEAPNDB(int BIIPHDAINOK, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6CEBA70", Offset = "0x6CEAC70", VA = "0x186CEBA70")]
	public static int BJGFKEIBFII(int PMKKOINIJGG, int BIIPHDAINOK, int HGDDOPJPLHB, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6CEB9E0", Offset = "0x6CEABE0", VA = "0x186CEB9E0")]
	public static int AEOKAJJIJKK(int PMKKOINIJGG, int BIIPHDAINOK, int HGDDOPJPLHB, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC200", Offset = "0x6CEB400", VA = "0x186CEC200")]
	public static int EGHOAALHIGH(int HGDDOPJPLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC4A0", Offset = "0x6CEB6A0", VA = "0x186CEC4A0")]
	private static int GHHIECGDGGI(int BIIPHDAINOK, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC5A0", Offset = "0x6CEB7A0", VA = "0x186CEC5A0")]
	private static int HNGHKNNJMND(int BIIPHDAINOK, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6CECFB0", Offset = "0x6CEC1B0", VA = "0x186CECFB0")]
	public static int PCCEGJALIGJ(int PMKKOINIJGG, int BIIPHDAINOK, int HGDDOPJPLHB, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6CECF20", Offset = "0x6CEC120", VA = "0x186CECF20")]
	public static int NLJMCEGFPLD(int PMKKOINIJGG, int BIIPHDAINOK, int HGDDOPJPLHB, bool IJNDBIDPAFJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC730", Offset = "0x6CEB930", VA = "0x186CEC730")]
	public static int KDDPIOICBED(int HGDDOPJPLHB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6CEB8F0", Offset = "0x6CEAAF0", VA = "0x186CEB8F0")]
	public static KPOLDODMGKK ABAMEEEGEIM(int BIIPHDAINOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC210", Offset = "0x6CEB410", VA = "0x186CEC210")]
	private static KPOLDODMGKK GCGABOLFNBI(int BIIPHDAINOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC4B0", Offset = "0x6CEB6B0", VA = "0x186CEC4B0")]
	public static KPOLDODMGKK HGCOOKLOFPO(int BIIPHDAINOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6CECBE0", Offset = "0x6CEBDE0", VA = "0x186CECBE0")]
	private static KPOLDODMGKK MALPAFBBICD(int BIIPHDAINOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6CEC7E0", Offset = "0x6CEB9E0", VA = "0x186CEC7E0")]
	public static void KFOKHHPOFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct CKHJIHCDHIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int JGONMBICFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 JEAPKMAGJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion CCAKPJGKLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float KOHOKMJMHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float DENINJIPGLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int FJOLPIAIAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int NGHCCCHGLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int GNGAPLJKKKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool PAOLOBNPMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool MAEBAHLDKDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float AMNJEHPCAHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 BKCIOBONEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool GBGBNDLNNAL;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct MLCBNKEIAHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int AIKNDIECPJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int DINBCGJHJPH;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct OEKHMCBMMIK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<CKHJIHCDHIA> PGFNMHJCIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<LINEJHJGLFA> FNDKFKFBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<KOOHKEIPECB> POEDLFBPMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<MLCBNKEIAHL> MPIFKLKPILP;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6CED260", Offset = "0x6CEC460", VA = "0x186CED260")]
	public OEKHMCBMMIK(NativeArray<LINEJHJGLFA> FNDKFKFBENM, int JAICOMOJIGD = 1, Allocator PKPCACFEGCG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6CED170", Offset = "0x6CEC370", VA = "0x186CED170", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct FNFCBEOMJCM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<KHAOKCHGKBB> OJBMIPBGNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> PGCPIPNAHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<KOOHKEIPECB> HPCOKOGDLNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<CKHJIHCDHIA> PGFNMHJCIIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<LINEJHJGLFA> FNDKFKFBENM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<KOOHKEIPECB> POEDLFBPMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<MLCBNKEIAHL> MPIFKLKPILP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int GPKHEMOBIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int IJIPFHOMLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 APKNHPNGIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion ENAINKGKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 CBEKDLLKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JCGGIFDAFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DMFHHILCMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JADFAKGCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FNJLFPGDGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> GDBBJPMFKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NGOAAABANDI;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6CE37E0", Offset = "0x6CE29E0", VA = "0x186CE37E0")]
	public FNFCBEOMJCM(POAFFFIKCOC NBFIPPCHCHJ, GBHEDBODDJM BBJEJJMILOD, float3 MHEAJPMJEPK, quaternion LPIHECNMHFJ, float DJICEDLOKHH, int IHCNMODHHDN = 0, int MPAKEGAOILO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6CE3A60", Offset = "0x6CE2C60", VA = "0x186CE3A60")]
	public FNFCBEOMJCM(OEKHMCBMMIK NBFIPPCHCHJ, GBHEDBODDJM BBJEJJMILOD, float3 MHEAJPMJEPK, quaternion LPIHECNMHFJ, float3 DJICEDLOKHH, int IHCNMODHHDN = 0, int MPAKEGAOILO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6CE3260", Offset = "0x6CE2460", VA = "0x186CE3260")]
	private float3 LHLNHADKJOF(float3 BNOHGPGBOCH, Matrix4x4 AALOBDCCNNO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1950", Offset = "0x6CE0B50", VA = "0x186CE1950")]
	private float3x3 DHNECGNHLJO(float3x3 OLHJMAFFFLI, float3x3 FMIDNEFNEHN)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1940", Offset = "0x6CE0B40", VA = "0x186CE1940")]
	private float AMJFPJDADII(float DKGNMCFDBJD, float JAGPBJFEMFB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6CE1F50", Offset = "0x6CE1150", VA = "0x186CE1F50", Slot = "4")]
	public void Execute(int JJIKJNIEJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6CE30F0", Offset = "0x6CE22F0", VA = "0x186CE30F0")]
	private void KAEJBMOMFAK(int ENDGHNCGJDI, float3 FJFKFIAGEPM, float3 DJCLDHHAKMM, float3 ANKNPCHEJPN, float DLNPAPKJAEH, bool MAGEEJFJKKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6CE33A0", Offset = "0x6CE25A0", VA = "0x186CE33A0")]
	private void PECJAFLHHNP(CKHJIHCDHIA JGOCFBCMKKO, float3 GGLFFACIDJM, float3x3 CMACADCFGJN, float DKGNMCFDBJD, int OFPOHPLCAFI, int FDKNLELGNHD, int HBKAPPNJKLO, float PMDFOFEPBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6CE19D0", Offset = "0x6CE0BD0", VA = "0x186CE19D0")]
	private void EFIILEFKKHG(int ENDGHNCGJDI, int OPDCICANMMO, CKHJIHCDHIA JGOCFBCMKKO, float3 GGLFFACIDJM, float3x3 CMACADCFGJN, bool NGJFMOIEKIG, float DKGNMCFDBJD, int BFMHJFBOEAI, int FEEBBMEBJIP, int HBKAPPNJKLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct DPBPKLMPLKJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<DCGJIPKNPKM> NDEBNLCJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<KOOHKEIPECB> KDDNFKOEINN;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7310", Offset = "0x6CD6510", VA = "0x186CD7310")]
	public DPBPKLMPLKJ(int JAICOMOJIGD, Allocator PKPCACFEGCG = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6CD7270", Offset = "0x6CD6470", VA = "0x186CD7270", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct BGMMFJNBKNG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum KAPLGDLOBCE
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
	private NativeList<float3> PHJGJFEECAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> CJBMPODOABL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> PFIHIHPGMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> EOBEJIPNBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> HMBMHMFPICO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> CCJJMPHFEOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> GANLLONPFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> ABLFPLGJNNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<KOOHKEIPECB> HDCDKPONDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<DCGJIPKNPKM> NDEBNLCJLPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<KOOHKEIPECB> KDDNFKOEINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int GPKHEMOBIBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int IJIPFHOMLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> JCGGIFDAFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DMFHHILCMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> JADFAKGCFKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> FNJLFPGDGFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> GDBBJPMFKBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NGOAAABANDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 CBEKDLLKEDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion ENAINKGKALB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 APKNHPNGIHE;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6CD64D0", Offset = "0x6CD56D0", VA = "0x186CD64D0")]
	public BGMMFJNBKNG(POAFFFIKCOC NBFIPPCHCHJ, GBHEDBODDJM BBJEJJMILOD, float3 MHEAJPMJEPK, quaternion LPIHECNMHFJ, float DJICEDLOKHH, int IHCNMODHHDN = 0, int MPAKEGAOILO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6CD62F0", Offset = "0x6CD54F0", VA = "0x186CD62F0")]
	public BGMMFJNBKNG(DPBPKLMPLKJ LJIEGDEDOHM, GBHEDBODDJM BBJEJJMILOD, float3 MHEAJPMJEPK, quaternion LPIHECNMHFJ, float3 DJICEDLOKHH, int IHCNMODHHDN = 0, int MPAKEGAOILO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6CD4F40", Offset = "0x6CD4140", VA = "0x186CD4F40", Slot = "4")]
	public void Execute(int JJIKJNIEJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5F40", Offset = "0x6CD5140", VA = "0x186CD5F40")]
	private void LPCDDMDNBIJ(float4x4 EKFFNKAOHPJ, int JJIKJNIEJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5E40", Offset = "0x6CD5040", VA = "0x186CD5E40")]
	private KAPLGDLOBCE GEPBOAGIPND(float3 DJCLDHHAKMM)
	{
		return default(KAPLGDLOBCE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5EB0", Offset = "0x6CD50B0", VA = "0x186CD5EB0")]
	private float4 JAJDEPPGBNA(KAPLGDLOBCE LDOMCHPGFDH, int KINMHNEMPOD)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6CD5F00", Offset = "0x6CD5100", VA = "0x186CD5F00")]
	private float2 LDGFEDLGBHF(KAPLGDLOBCE LDOMCHPGFDH, float3 FJFKFIAGEPM)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct LDBGPHIHGKA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum DIAFEGPICGM
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static LDBGPHIHGKA NPJAAMJGCPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 LFHLHOFOIJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 DLHDCPPAMJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 NCANLJNAAPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public DIAFEGPICGM DGMPJMIJKHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 FABNLPNFEDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 GPLJCLJDNHF;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool LHNMCLPFALC
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6CFA3A0", Offset = "0x6CF95A0", VA = "0x186CFA3A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 LJLJADGJPEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6CF9AA0", Offset = "0x6CF8CA0", VA = "0x186CF9AA0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6CFA410", Offset = "0x6CF9610", VA = "0x186CFA410")]
	public LDBGPHIHGKA(float3 FJFKFIAGEPM, quaternion MBMKLLFOFFL, float3 JAICOMOJIGD, DIAFEGPICGM EIHDAHDDDEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6CFA1A0", Offset = "0x6CF93A0", VA = "0x186CFA1A0")]
	public float NDOGHONBHOC(float3 GGLFFACIDJM, float JHADDCNCKFI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6CFA0B0", Offset = "0x6CF92B0", VA = "0x186CFA0B0")]
	public bool LJAAEAILKLC(float3 DJCLDHHAKMM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9F00", Offset = "0x6CF9100", VA = "0x186CF9F00")]
	public void LHLHCNPOFJF(float3 PKHGLILKCHL, float3x3 MDPIPNJEFHJ, float INFIHCBMHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9E10", Offset = "0x6CF9010", VA = "0x186CF9E10")]
	private void KGLBKNBAHPH(float3 IBDHOCLCOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9B80", Offset = "0x6CF8D80", VA = "0x186CF9B80")]
	public void JLNAANOOHAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct AEHGHOKOGKJ : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<LDBGPHIHGKA> LJIEGDEDOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> AJAEKNELACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> KMPPNLIKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HDMEHGOAFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<KOOHKEIPECB> KDDNFKOEINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int CMPBKJGCKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int EDEOLBKNOIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float JHADDCNCKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float JAOKGBPPECF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MOMLKGACEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> JKAPDCIAHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> CGIBKDGBJOD;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6CF04B0", Offset = "0x6CEF6B0", VA = "0x186CF04B0")]
	public AEHGHOKOGKJ(GBHEDBODDJM PGLODJCEFNN, float INBDLEJAELA, int GFHPFKLIAOK, int OFPOHPLCAFI, NativeList<LDBGPHIHGKA> LJIEGDEDOHM, NativeArray<int> HDMEHGOAFMP, NativeList<KOOHKEIPECB> KDDNFKOEINN, KNEEGJKHLFG FFEOMKKKGMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6CEFD70", Offset = "0x6CEEF70", VA = "0x186CEFD70", Slot = "4")]
	public void Execute(int HCHOEGGIPPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6CEFCB0", Offset = "0x6CEEEB0", VA = "0x186CEFCB0")]
	private bool DJOABPLNIJB(LDBGPHIHGKA APIBENHOAOO, LDBGPHIHGKA EGCFJOLCAMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6CEFA20", Offset = "0x6CEEC20", VA = "0x186CEFA20")]
	private bool CMJEMHFGGBE(LDBGPHIHGKA JOBDJKNFOIH, int AFOFAAAHONK, int INNBNKBFJKO, int LELCPMCJLFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class KNEEGJKHLFG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> LAFOOJJNJPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> KBHFMMJDADG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> MEDLMIFNPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> PCOPGIOJIOB;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9870", Offset = "0x6CF8A70", VA = "0x186CF9870")]
	public void MIMLEIDKJAM(int CHBDNMLMGCH, int KDCGIDBHDIF, Allocator PKPCACFEGCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9990", Offset = "0x6CF8B90", VA = "0x186CF9990")]
	public static long NIMPCEBLLCL(int CHBDNMLMGCH, int KDCGIDBHDIF)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9780", Offset = "0x6CF8980", VA = "0x186CF9780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6CF99B0", Offset = "0x6CF8BB0", VA = "0x186CF99B0")]
	public void OAFCGGBDEDH(JobHandle PLDBJICEKIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
	public KNEEGJKHLFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct GGDKPAKNBBK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> AJAEKNELACL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> CLFKJKOBKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> ENEMCHKAMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> LLFNNEIPPJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> KMPPNLIKOCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EIFDCOABAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> OFINHFCDFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> MOMLKGACEDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> JKAPDCIAHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int IHCNMODHHDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int MPAKEGAOILO;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7B50", Offset = "0x6CF6D50", VA = "0x186CF7B50")]
	public GGDKPAKNBBK(GBHEDBODDJM PGLODJCEFNN, KNEEGJKHLFG FFEOMKKKGMH, int MPAKEGAOILO = 0, int IHCNMODHHDN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7710", Offset = "0x6CF6910", VA = "0x186CF7710", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7AF0", Offset = "0x6CF6CF0", VA = "0x186CF7AF0")]
	private void OIAONNNONMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class MBJICBGOMJM
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2F079D0", Offset = "0x2F06BD0", VA = "0x182F079D0")]
	public static bool CDKDLGLKGJH<T>(NativeArray<T> IEIBCNCHGJN, int JAICOMOJIGD, Allocator PKPCACFEGCG, NativeArrayOptions PCHCKDDGLBA = NativeArrayOptions.ClearMemory, int IFOBJBDLJFO = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2F07A90", Offset = "0x2F06C90", VA = "0x182F07A90")]
	public static bool CDKDLGLKGJH<T>(NativeList<T> NAGHBLHDGIK, int JAICOMOJIGD, Allocator PKPCACFEGCG) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum DFOKKJFFFLP
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
public interface KFAAIFBEMNJ
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int AEOKCFMNLIH(DFOKKJFFFLP PMKKOINIJGG);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int IDEJAFFMLCA(DFOKKJFFFLP PMKKOINIJGG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds AMDEMEHOFBD();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float IOHGAKIKHBL();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void FOGPJHGCBFO(DFOKKJFFFLP PMKKOINIJGG, POAFFFIKCOC HOMIDKLJPCI, int GEBBHBIKFGO = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class GPBLHCKIAHA
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7BD0", Offset = "0x6CF6DD0", VA = "0x186CF7BD0")]
	public static void KFOKHHPOFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class JBDONIOELJK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> NEBAHGOBCLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> IAAODIFPJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> GLIFFFNGBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> CHFJPFKICOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> PNPFIIENGNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> MJKGKHJJEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> MBDDNKJFHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> BHJOIFFLEPD;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int BCMOHEPODGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8C20", Offset = "0x6CF7E20", VA = "0x186CF8C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int JHCDKDJOHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8450", Offset = "0x6CF7650", VA = "0x186CF8450")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int HMBFLABBCOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6CF8C60", Offset = "0x6CF7E60", VA = "0x186CF8C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6CF8FA0", Offset = "0x6CF81A0", VA = "0x186CF8FA0")]
	public JBDONIOELJK(int CHBDNMLMGCH, int KDCGIDBHDIF, int NLINCBHACGL, Allocator PKPCACFEGCG = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6CF8CA0", Offset = "0x6CF7EA0", VA = "0x186CF8CA0")]
	public JBDONIOELJK(Mesh PGLODJCEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7DD0", Offset = "0x6CF6FD0", VA = "0x186CF7DD0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6CF8490", Offset = "0x6CF7690", VA = "0x186CF8490")]
	public void KKPEAPDMHAN(JBDONIOELJK PGLODJCEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6CF8790", Offset = "0x6CF7990", VA = "0x186CF8790")]
	private void NGOMCIOBCEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7EE0", Offset = "0x6CF70E0", VA = "0x186CF7EE0")]
	private void EFLKGNKJELD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KOOHKEIPECB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int EGEMMBLBAIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int BCMOHEPODGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int EAFMHBFBFCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int JHCDKDJOHKB;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x185EDD0", Offset = "0x185DFD0", VA = "0x18185EDD0")]
	public KOOHKEIPECB(int OFPOHPLCAFI, int KLJHAFCJJBJ, int GFHPFKLIAOK, int AJAHOAGDDDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class BNOHAKLACAM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<KOOHKEIPECB> KIEGJOCEJJF
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA7FAC0", Offset = "0xA7ECC0", VA = "0x180A7FAC0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KOOHKEIPECB>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA7FDF0", Offset = "0xA7EFF0", VA = "0x180A7FDF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public JBDONIOELJK NPLNMNOGMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x897B70", Offset = "0x896D70", VA = "0x180897B70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x897BB0", Offset = "0x896DB0", VA = "0x180897BB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6CF05C0", Offset = "0x6CEF7C0", VA = "0x186CF05C0")]
	public BNOHAKLACAM(IEnumerable<JBDONIOELJK> NKJNDOINOGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6CF0550", Offset = "0x6CEF750", VA = "0x186CF0550", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LMMLNLGIKBO
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class JEOHEONJMEK
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> PEDPMDECGJA;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> GFILIJPKOEA;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> GHJLHCOOFDM;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> PEGMOEBFLNJ;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9570", Offset = "0x6CF8770", VA = "0x186CF9570")]
	public static void KFOKHHPOFOL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9680", Offset = "0x6CF8880", VA = "0x186CF9680")]
	public static NativeArray<float2> LJJIGJFBMNP(NativeArray<float2> HBOIEEDJBIP, int FFEGCLEIKPB, NativeArray<float2> AJDACMICMJF, int AFHIFAOPLGH)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9370", Offset = "0x6CF8570", VA = "0x186CF9370")]
	public static NativeArray<float3> GHGBCPHKJAD(NativeArray<float3> HBOIEEDJBIP, int FFEGCLEIKPB, NativeArray<float3> AJDACMICMJF, int AFHIFAOPLGH)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9270", Offset = "0x6CF8470", VA = "0x186CF9270")]
	public static NativeArray<float4> CKDGJOLMDKD(NativeArray<float4> HBOIEEDJBIP, int FFEGCLEIKPB, NativeArray<float4> AJDACMICMJF, int AFHIFAOPLGH)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6CF9470", Offset = "0x6CF8670", VA = "0x186CF9470")]
	public static NativeArray<int> JLBOKIFKBEH(NativeArray<int> HBOIEEDJBIP, int FFEGCLEIKPB, NativeArray<int> AJDACMICMJF, int AFHIFAOPLGH)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2E71B20", Offset = "0x2E70D20", VA = "0x182E71B20")]
	private static void DBLOOHFIDNF<T>(NativeArray<T> IEIBCNCHGJN, int IFMIADNLAOK) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2E71D20", Offset = "0x2E70F20", VA = "0x182E71D20")]
	private static void GOIDDJNFLEJ<T>(NativeArray<T> HBOIEEDJBIP, int FFEGCLEIKPB, NativeArray<T> AJDACMICMJF, int AFHIFAOPLGH, NativeArray<T> HPIABKGFBDI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class FHEIMJELIPA
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct GPCIKKCPGMF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort AKHPALIKFFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort PGLPHKNNCEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort HMKOFHHFHNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort AADMCCOFAGB;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6D50", Offset = "0x6CF5F50", VA = "0x186CF6D50")]
	public static uint BNOBNCJDOBM(float AHKDIOAOCON)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6AF0", Offset = "0x6CF5CF0", VA = "0x186CF6AF0")]
	public static void BGFKGOALMFF(float4 ENEMCHKAMAL, float JPDFEHKHEPB, [Out] uint JDGOFPGCIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6C00", Offset = "0x6CF5E00", VA = "0x186CF6C00")]
	public static void BGFKGOALMFF(float4 ENEMCHKAMAL, uint ENCDBAHHCBD, [Out] uint JDGOFPGCIFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7110", Offset = "0x6CF6310", VA = "0x186CF7110")]
	public static void GDGADGMDPMJ(float3 LPHAIALIJGA, float3 FANOMONDOID, float4 LIAKALMFLDK, float2 LIFBPCGFCAO, float4 ENEMCHKAMAL, [Out] GBHEDBODDJM.IOMAIGGJDHE KAKBJLBBLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6EB0", Offset = "0x6CF60B0", VA = "0x186CF6EB0")]
	public static void GDGADGMDPMJ(float3 LPHAIALIJGA, float3 FANOMONDOID, float4 LIAKALMFLDK, float2 LIFBPCGFCAO, float4 ENEMCHKAMAL, [Out] GBHEDBODDJM.PACGNHMLLIP KAKBJLBBLKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6CF74F0", Offset = "0x6CF66F0", VA = "0x186CF74F0")]
	public static byte KBMDEEBDMLG(float JECHHBGMFLN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6AA0", Offset = "0x6CF5CA0", VA = "0x186CF6AA0")]
	public static ushort APMAJBPFIJN(float JECHHBGMFLN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6CF74C0", Offset = "0x6CF66C0", VA = "0x186CF74C0")]
	public static uint HHFAFHHHEPL(float JECHHBGMFLN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6CD0", Offset = "0x6CF5ED0", VA = "0x186CF6CD0")]
	public static float2 BMLKOEOOLCH(float2 IGDCKHODAOC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7540", Offset = "0x6CF6740", VA = "0x186CF7540")]
	public static float2 KEFECLFIAJG(float3 PICIPNDFLHH)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6CF6D60", Offset = "0x6CF5F60", VA = "0x186CF6D60")]
	public static void CBPLGCLKKNF(float3 JECHHBGMFLN, [Out] float3 HAEJNGLOAKG, [Out] uint3 AADMCCOFAGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6CF7360", Offset = "0x6CF6560", VA = "0x186CF7360")]
	public static GPCIKKCPGMF HAKAPHDMNED(float3 FJFKFIAGEPM)
	{
		return default(GPCIKKCPGMF);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class EMACKCLHFAM
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker ACFFOOIIDBC;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float INLKKCANIBD;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void CHMEAGECLGO(bool CFKPMMHDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6CF64F0", Offset = "0x6CF56F0", VA = "0x186CF64F0")]
	public static void LBKPPFJNOIA(float DIHLPKLDDFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class PGPCOPIDIEC
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum EMKOMCMCEHH
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
	public struct HAPAKEBODJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public FDPDJBEOJJC PGLODJCEFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int FDFDBIGDIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int FPNKCPIBFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long IJPNINMOIPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long CACBFBFGFPA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float HJJNBLKADCP;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6CF7D20", Offset = "0x6CF6F20", VA = "0x186CF7D20")]
		public void BPKFIOLMIPE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6CF7D50", Offset = "0x6CF6F50", VA = "0x186CF7D50")]
		public void OAFCGGBDEDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string JHBKADJPECO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string CFBFCJPLHIN;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker ACFFOOIIDBC;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker MNCKAKBIHDP;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker KMPEAANDHLG;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker AFBCKDPIPNN;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker PBGOIBMADFM;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker BMNIGDCGIAF;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker PEFGJEMGOGB;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker DKBCKCBEFAD;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker NEFOFGDCOMF;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker KKKLPDJMDID;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker JHHHBAOLBPF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker DAEGMGKIJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<KFAAIFBEMNJ> EEGPNJAIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly HMNHFOHBAHD DPCGIAALCEA;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool HMLHGEGCPMM = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int KLJHAFCJJBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int AJAHOAGDDDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EPHLMNFAPBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool OEMNMCKAINB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool FCFJGFBIJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal EMKOMCMCEHH NHDPLCKEAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool FKCCFFOIDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 CICEDKLGONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 OLDDAEIDEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float HELIEIEJKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float KOKAHKAKJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int DLLIHNHCAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int IFIEMMBLIMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int CIGMJMBGAOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int PPHNFNPNHPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float COINGEMHOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float ANIBCHPLIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int JFPLDOHIOKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long FKJEPCAOMHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long AHOJMMKCGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long PMFFIJCKBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int BBNHNBKHOKD;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int CPILHCFDGLJ = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] GEPOEALABLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] HJBAJPJBCOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] GBNKPOKOCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<HAPAKEBODJM> GAIPNBNIFGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private GBHEDBODDJM ECECONAHALE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long PJBLOOPOHLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long NGJIMLCNOBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int CACMHCFNFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float FAIBPEBHFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal GBHEDBODDJM.HBAKEAAINDK AHLNKEHNLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool DFKHIFCHBKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private MFKCNEJBGED JHOJACNPLJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle JJDLCAHOLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> FKLPBJPLADC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool FLMDDMMKKAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle IODAJBOHNML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private GBHEDBODDJM LOHLEGAJMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private KNEEGJKHLFG GBOKGBAHPAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform KJLDDCDHMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private DFOKKJFFFLP NIIBBFDLCAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long ELGBBDCNLLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long EONAPCCGJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long GBMHJCNFFFD;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh NPLNMNOGMDF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x894500", Offset = "0x893700", VA = "0x180894500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x89F8C0", Offset = "0x89EAC0", VA = "0x18089F8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter PCEMKJFKHBC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x89AD00", Offset = "0x899F00", VA = "0x18089AD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer ILNNMFKKFAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8942D0", Offset = "0x8934D0", VA = "0x1808942D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x894320", Offset = "0x893520", VA = "0x180894320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> NPNHLPKKHJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8942E0", Offset = "0x8934E0", VA = "0x1808942E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8941E0", Offset = "0x8933E0", VA = "0x1808941E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int NHMHCPJMIIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9873C0", Offset = "0x9865C0", VA = "0x1809873C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int MKIJGPNGKNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x12E4580", Offset = "0x12E3780", VA = "0x1812E4580")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int BCMOHEPODGA
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6D05F90", Offset = "0x6D05190", VA = "0x186D05F90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<KFAAIFBEMNJ> IMOIJEMFKMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x894460", Offset = "0x893660", VA = "0x180894460")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6D045B0", Offset = "0x6D037B0", VA = "0x186D045B0")]
	public void MNLJEJMHOCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6CFCDB0", Offset = "0x6CFBFB0", VA = "0x186CFCDB0")]
	private void ABGFNBBFHAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6D07A90", Offset = "0x6D06C90", VA = "0x186D07A90")]
	public PGPCOPIDIEC(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6D05D50", Offset = "0x6D04F50", VA = "0x186D05D50")]
	public void OAFCGGBDEDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6D01610", Offset = "0x6D00810", VA = "0x186D01610")]
	private void GGJLPICJICB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEF00", Offset = "0x6CFE100", VA = "0x186CFEF00")]
	private void CBMNANJNOBN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6D05E80", Offset = "0x6D05080", VA = "0x186D05E80")]
	public Mesh OAKICPKOKFP(MeshFilter PGOMJLCPOHN, Transform PKBNMONECNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6D017A0", Offset = "0x6D009A0", VA = "0x186D017A0")]
	private void IMMIJGGBIBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6CFE8C0", Offset = "0x6CFDAC0", VA = "0x186CFE8C0")]
	public void BGCIHOCIMCJ(KFAAIFBEMNJ INEKHEILENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6D00CD0", Offset = "0x6CFFED0", VA = "0x186D00CD0")]
	public bool FCHJHMPEKJK(KFAAIFBEMNJ INEKHEILENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6D01740", Offset = "0x6D00940", VA = "0x186D01740")]
	public bool IMBCHPJELFP(KFAAIFBEMNJ INEKHEILENE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6D03280", Offset = "0x6D02480", VA = "0x186D03280", Slot = "4")]
	public virtual void LGGAGHBMEOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6D00770", Offset = "0x6CFF970", VA = "0x186D00770")]
	public void FABKHOEAPCE(Transform EIIAHDPLMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6D04DC0", Offset = "0x6D03FC0", VA = "0x186D04DC0")]
	private long NACMPDAFPHK()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEA20", Offset = "0x6CFDC20", VA = "0x186CFEA20")]
	private long BJOMJDIEFBJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6D03460", Offset = "0x6D02660", VA = "0x186D03460")]
	public bool MHDNOEKPHNG(Transform EIIAHDPLMGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6D04E80", Offset = "0x6D04080", VA = "0x186D04E80")]
	public bool NPAJLOJKANA(bool ECBBJAOBBCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6D045C0", Offset = "0x6D037C0", VA = "0x186D045C0")]
	private void MPFEFAFFFHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6D01B00", Offset = "0x6D00D00", VA = "0x186D01B00")]
	public bool LBKPPFJNOIA(float4x4 NLAOJIDIKLE, BatchedMeshRenderer ELPDKNJFMHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6D00590", Offset = "0x6CFF790", VA = "0x186D00590")]
	public void DLEMDFICKON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6CFFCD0", Offset = "0x6CFEED0", VA = "0x186CFFCD0")]
	public bool DHIGNMCMCOM(bool ECBBJAOBBCJ = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6D00D50", Offset = "0x6CFFF50", VA = "0x186D00D50")]
	public void FJOAIAHHHBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6D04580", Offset = "0x6D03780", VA = "0x186D04580")]
	public void MNADNMPCICM(GBHEDBODDJM PGLODJCEFNN, int PDFIAKMFMCM, int HNNBFMFNMJK, float LCBAEHFMLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEC50", Offset = "0x6CFDE50", VA = "0x186CFEC50")]
	public void CACEDJEDKHA(FDPDJBEOJJC JODFIMANIII, int PDFIAKMFMCM, int HNNBFMFNMJK, float LCBAEHFMLHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEBE0", Offset = "0x6CFDDE0", VA = "0x186CFEBE0")]
	public (long, long, long) BNHGHEIDIPN()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x99C970", Offset = "0x99BB70", VA = "0x18099C970")]
	public long KFCLHEPOLGJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD440", Offset = "0x6CFC640", VA = "0x186CFD440")]
	private void ACMKKNBGIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD0B0", Offset = "0x6CFC2B0", VA = "0x186CFD0B0")]
	public (long, long) ACFGFGBIAEG(float OKOINPILBEH, float4x4 NLAOJIDIKLE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public void BBLPIBLBDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6D00470", Offset = "0x6CFF670", VA = "0x186D00470")]
	internal void DJMNHMDGNFF(EMKOMCMCEHH HLIOONMEBNC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6D00D60", Offset = "0x6CFFF60", VA = "0x186D00D60")]
	private (float, float, float, float) GFOPMPIBLFE(float OFAINMAEJKK, float4x4 NLAOJIDIKLE)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEB80", Offset = "0x6CFDD80", VA = "0x186CFEB80")]
	private float BKEBKBAIOBN(float OFAINMAEJKK, float4x4 NLAOJIDIKLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6CFF990", Offset = "0x6CFEB90", VA = "0x186CFF990")]
	private (int, int) CHJEBHBCKJK(float OANOHLHDCGG)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6CFD840", Offset = "0x6CFCA40", VA = "0x186CFD840")]
	public void BDJBOMDDIAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6D03310", Offset = "0x6D02510", VA = "0x186D03310")]
	private void LPIEOIJIFFB(GBHEDBODDJM MPJDIPFEIKG, GBHEDBODDJM.HBAKEAAINDK CEFBOKJKLGJ, bool BHGKEEDDAMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6D03360", Offset = "0x6D02560", VA = "0x186D03360")]
	private void LPIEOIJIFFB([In] FDPDJBEOJJC MPJDIPFEIKG, GBHEDBODDJM.HBAKEAAINDK CEFBOKJKLGJ, bool BHGKEEDDAMC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6D01A60", Offset = "0x6D00C60", VA = "0x186D01A60")]
	private void KGBOLDCDAIC(GBHEDBODDJM.HBAKEAAINDK CEFBOKJKLGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6D01A30", Offset = "0x6D00C30", VA = "0x186D01A30")]
	private void JPEPBCFFHIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6D009B0", Offset = "0x6CFFBB0", VA = "0x186D009B0")]
	private void FBBPCEOPLJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6CFEFE0", Offset = "0x6CFE1E0", VA = "0x186CFEFE0")]
	public long CGEHMDAJKHI(long EOBOPEGEJHO, int MMNACGNALLA)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6D05FB0", Offset = "0x6D051B0", VA = "0x186D05FB0")]
	private void PCONFEDFNON(GBHEDBODDJM LFFNIFPIDAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6D00000", Offset = "0x6CFF200", VA = "0x186D00000")]
	private void DJAPMPADJPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6D016B0", Offset = "0x6D008B0", VA = "0x186D016B0")]
	private float HBBDINFMNEP(int ICMCAHBPGDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6D06CD0", Offset = "0x6D05ED0", VA = "0x186D06CD0")]
	private void PFPBDEHDHFI(GBHEDBODDJM PGLODJCEFNN, EICCLDHMPFA JODFIMANIII, int PDFIAKMFMCM, int HNNBFMFNMJK, float LCBAEHFMLHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct MFKCNEJBGED : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct KEABEHKPCML
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int IPGNMMMPKBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int CINHOLGLCEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int ECDNJFNBCIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int CJFAEOJIFDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int MKLMCDIGJBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int KHENCCHDPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int FDFDBIGDIKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int FPNKCPIBFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float HJJNBLKADCP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct ONDODHBEOKD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public FJEKGNIOILF.JOODPJFEDFL BEIPBADHEEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float JMFFDFMBMAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float NHJGHELIKEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float IBPJAIKHELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float PPMJLDAEKNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float KLEPIMPPAAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float LIILECIGPGH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct EFNPGPIPMKC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> NEBAHGOBCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> IAAODIFPJBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> IPJOFMAJMGD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> BKJPCIENLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> BGNCKLOKLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> BHJOIFFLEPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool KCANNCDKMLC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int BCMOHEPODGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int JHCDKDJOHKB;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6CF6250", Offset = "0x6CF5450", VA = "0x186CF6250")]
		public void MIMLEIDKJAM(int CHBDNMLMGCH, int KDCGIDBHDIF, Allocator PKPCACFEGCG, bool OBEAPIICIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6CF6000", Offset = "0x6CF5200", VA = "0x186CF6000")]
		public static EFNPGPIPMKC GGIPNDJCAHC(GBHEDBODDJM MMPBCCIBPMB)
		{
			return default(EFNPGPIPMKC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6CF6430", Offset = "0x6CF5630", VA = "0x186CF6430")]
		public void OAFCGGBDEDH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker ACHJGBEIDJM;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker MOEJIOIPMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<KEABEHKPCML> LGNOBFBNHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private EFNPGPIPMKC MDPLIKKOAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private EFNPGPIPMKC LFFNIFPIDAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 AOPPBNHKIDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 KOIBGGLHNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private ONDODHBEOKD NGDGMBLJGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* DIOLNACLFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> HLBIFDLPLKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> JKAPDCIAHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> ODMLKLMFJKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> APIOCMABEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> BFLGJONBEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> BFGIPBHGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> MDPMGIJCFKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> IEMGDPHLBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> KOMPJJCOPGD;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC550", Offset = "0x6CFB750", VA = "0x186CFC550")]
	public MFKCNEJBGED([In] List<PGPCOPIDIEC.HAPAKEBODJM> OPFFMAIBJEA, [In] GBHEDBODDJM LMBJGGCGBOG, [In] PGPCOPIDIEC AJDCHCJCIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC020", Offset = "0x6CFB220", VA = "0x186CFC020", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6CFA500", Offset = "0x6CF9700", VA = "0x186CFA500")]
	public void AJALMHCIKOG(List<PGPCOPIDIEC.HAPAKEBODJM> DDOOPADDKDI, [In] PGPCOPIDIEC AJDCHCJCIGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC070", Offset = "0x6CFB270", VA = "0x186CFC070")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool FMGGCLHGCAN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6CFBDF0", Offset = "0x6CFAFF0", VA = "0x186CFBDF0")]
	private FDPDJBEOJJC CEKGKBIDEHF(int MKLHLECCBJB, Allocator PKPCACFEGCG)
	{
		return default(FDPDJBEOJJC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6CFAE60", Offset = "0x6CFA060", VA = "0x186CFAE60")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void BPIDJJJEAHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC090", Offset = "0x6CFB290", VA = "0x186CFC090")]
	[IgnoreWarning(1371)]
	private KEABEHKPCML GFLMIJGLHBH([In] KEABEHKPCML JILECCNEGLJ, int FKAGJLBKGJO, [In] NativeArray<int> KMPPNLIKOCN, [In] NativeArray<bool> JKAPDCIAHCI, NativeArray<int> ODMLKLMFJKJ)
	{
		return default(KEABEHKPCML);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6CFC3B0", Offset = "0x6CFB5B0", VA = "0x186CFC3B0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int JBGKOGJJIJE(NativeArray<int> KMPPNLIKOCN, int NOOGGLHAGPH, int JOMPOAKFFOP, int PNMAJEGPGJI)
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
		public static readonly GAFGFHIJEHD log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker GKLMGOONHIL;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker GLJPGLBLFGA;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker OPFPCFLMJFM;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker OIGIFHOAFJC;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker ICPEPNNNHPL;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker PBGOIBMADFM;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker MEBIMPJLGCN;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int DJNPCDAIMLA = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> AIHEDAKNODB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<PGPCOPIDIEC>> CLPDJLJHMBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<PGPCOPIDIEC> MEFCLHMMGPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> FEGOBENLICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform BFCCLPKMGLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool INAGJFLLLAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool OLPGENJOJPB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int OKPJFPDDDDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private PGPCOPIDIEC LJEGEMAJMDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material NOGMPAADMKC;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const int OLEAMDEMOOP = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static List<(long, Bounds, KFAAIFBEMNJ)> AKPFDCPDBDB;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> NEPANNMIMLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8944C0", Offset = "0x8936C0", VA = "0x1808944C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int HKFJHDFMLNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6CF5FB0", Offset = "0x6CF51B0", VA = "0x186CF5FB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		private static void HCONAJGLIMP(bool CFKPMMHDIGO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		private static void HCONAJGLIMP(bool CFKPMMHDIGO, string ADNFLGLLNKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6CF2FF0", Offset = "0x6CF21F0", VA = "0x186CF2FF0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0B70", Offset = "0x6CEFD70", VA = "0x186CF0B70")]
		public PGPCOPIDIEC AddToBatchedMesh(KFAAIFBEMNJ LIGBLCMKHGG, Material JEDKLDMCCCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6CF5A10", Offset = "0x6CF4C10", VA = "0x186CF5A10")]
		public void RemoveFromBatchedMesh(KFAAIFBEMNJ PGLODJCEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0FE0", Offset = "0x6CF01E0", VA = "0x186CF0FE0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6CF28B0", Offset = "0x6CF1AB0", VA = "0x186CF28B0")]
		private void LJBLCCMJEMK(Renderer IDGAFEEHOAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1810", Offset = "0x6CF0A10", VA = "0x186CF1810")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1800", Offset = "0x6CF0A00", VA = "0x186CF1800")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1110", Offset = "0x6CF0310", VA = "0x186CF1110")]
		private void FBNJKCHNKMH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6CF2AC0", Offset = "0x6CF1CC0", VA = "0x186CF2AC0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6CF2610", Offset = "0x6CF1810", VA = "0x186CF2610")]
		private PGPCOPIDIEC LIFPKOCAPCG(KFAAIFBEMNJ PGLODJCEFNN, Material JEDKLDMCCCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6CF0C70", Offset = "0x6CEFE70", VA = "0x186CF0C70")]
		private PGPCOPIDIEC CADDHINIKPI(Material JEDKLDMCCCG, int IMIINKOMGEB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1E20", Offset = "0x6CF1020", VA = "0x186CF1E20")]
		private PGPCOPIDIEC HDGKNLBGIGK(Material JEDKLDMCCCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6CF1700", Offset = "0x6CF0900", VA = "0x186CF1700")]
		private float4x4 FMEIEAJIMGB()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6CF24F0", Offset = "0x6CF16F0", VA = "0x186CF24F0")]
		private List<Material> JDLOMOALKBI(Material JEDKLDMCCCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xCC3080", Offset = "0xCC2280", VA = "0x180CC3080")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6CF2930", Offset = "0x6CF1B30", VA = "0x186CF2930")]
		public void MarkDirty(KFAAIFBEMNJ PGLODJCEFNN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6CF2C30", Offset = "0x6CF1E30", VA = "0x186CF2C30")]
		public (long, long) MemorySizeInBytesForChosenDetail(float OKOINPILBEH)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6CF4780", Offset = "0x6CF3980", VA = "0x186CF4780")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6CF18B0", Offset = "0x6CF0AB0", VA = "0x186CF18B0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6CF3250", Offset = "0x6CF2450", VA = "0x186CF3250")]
		public void RebatchOptimally(int EKMJOIAOBFA, int OGMHACFDHPB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6CF5E80", Offset = "0x6CF5080", VA = "0x186CF5E80")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class DOGKNICFIFH
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct NGDCMDHOCKM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float PFDDBFPHACL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public BatchedMeshRenderer FLANKLJCMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public PGPCOPIDIEC NFPHPNHHHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public long IJOPBJILIMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float BBBMJKKMCAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public bool MLPLNAEOKNG;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class IIGNPPBPELM : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xBCB400", Offset = "0xBCA600", VA = "0x180BCB400", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6D0D9E0", Offset = "0x6D0CBE0", VA = "0x186D0D9E0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xD348E0", Offset = "0xD33AE0", VA = "0x180D348E0")]
		[DebuggerHidden]
		public IIGNPPBPELM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6D0DA30", Offset = "0x6D0CC30", VA = "0x186D0DA30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CC20", Offset = "0x6D0BE20", VA = "0x186D0CC20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D890", Offset = "0x6D0CA90", VA = "0x186D0D890")]
		private void ODPIAJHKBMD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6D0CBD0", Offset = "0x6D0BDD0", VA = "0x186D0CBD0")]
		private void FNDCHHHCBCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D990", Offset = "0x6D0CB90", VA = "0x186D0D990", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D8E0", Offset = "0x6D0CAE0", VA = "0x186D0D8E0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6D0D8E0", Offset = "0x6D0CAE0", VA = "0x186D0D8E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly GAFGFHIJEHD ACKGBNDHEHM;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker PBGOIBMADFM;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker DKIPJOKAAOK;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker DAMHHNJNHIL;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker EIGONJOGICA;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static float3 NCAJJFOLEAL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static int OAOPDMCFCPE;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static int IGNCEIBDKAO;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static int MAPNEILFPFM;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int OMHCALBKAEJ;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int BPAOFGHDLBJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int EHIKKLFOFEI;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static long BGEMMBOLCKK;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static long LKOLIILGGPP;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int MLDJJPIEFPK;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static int JBEKCMPMDPG;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int CKADFHJMHGA;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static float IHGPBKHGOFF;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static bool ANKGJHJJFKB;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int LGCJMHMLENB;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float AKHNAFMHKEO;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static float MNNNNBLDNDE;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static float JHBDDILBNBJ;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float FHIEBBADBIN;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float KMPNAHEEJBE;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float NOPBBHKGCCG;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float DOFJOBFFAIJ;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float BBGPJKCFMHA;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static long AGHCLACHCEG;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static bool MFBAOGAHJLH;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static List<BatchedMeshRenderer> DNLDKBAFADI;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static List<NGDCMDHOCKM> HKHIIHJJKHG;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static Stack<GBHEDBODDJM> LLAKCOFFLAD;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static Stack<KNEEGJKHLFG> GEOBPOFJOAA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool OIGCKLIBKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6D08D80", Offset = "0x6D07F80", VA = "0x186D08D80")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void HCONAJGLIMP(bool CFKPMMHDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void CHMEAGECLGO(bool CFKPMMHDIGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	private static void HCONAJGLIMP(bool CFKPMMHDIGO, string ADNFLGLLNKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8966B0", Offset = "0x8958B0", VA = "0x1808966B0")]
	public static void BPKFIOLMIPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6D08C20", Offset = "0x6D07E20", VA = "0x186D08C20")]
	public static void EBENOAALFCF(BatchedMeshRenderer ICLKBJMGCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6D09440", Offset = "0x6D08640", VA = "0x186D09440")]
	public static void HNILKFCGIJO(BatchedMeshRenderer ICLKBJMGCIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C180", Offset = "0x6D0B380", VA = "0x186D0C180")]
	private static (long, long, long) MGELIKJAOAP(long CCPAOFNFGPJ)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6D08450", Offset = "0x6D07650", VA = "0x186D08450")]
	public static bool BDGACHHFIOE(float MHANIOAAIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6D08EA0", Offset = "0x6D080A0", VA = "0x186D08EA0")]
	public static void GCFNHBFNLHL(float MHANIOAAIGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6D089E0", Offset = "0x6D07BE0", VA = "0x186D089E0")]
	public static bool DFKHOJDEHIE(float MHANIOAAIGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6D09930", Offset = "0x6D08B30", VA = "0x186D09930")]
	public static void LBKPPFJNOIA(long CCPAOFNFGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6D08650", Offset = "0x6D07850", VA = "0x186D08650")]
	public static long CGEHMDAJKHI(long EOBOPEGEJHO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C290", Offset = "0x6D0B490", VA = "0x186D0C290")]
	public static void OKNDIINDIFD(PGPCOPIDIEC NFPHPNHHHMP, BatchedMeshRenderer FLANKLJCMHF, long IJOPBJILIMI, float PFDDBFPHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C5F0", Offset = "0x6D0B7F0", VA = "0x186D0C5F0")]
	public static void PHJHDIAIOFN(PGPCOPIDIEC NFPHPNHHHMP, BatchedMeshRenderer FLANKLJCMHF, long IJOPBJILIMI, float DIHLPKLDDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6D08AF0", Offset = "0x6D07CF0", VA = "0x186D08AF0")]
	public static void DOIOGCDCEHH(PGPCOPIDIEC NFPHPNHHHMP, BatchedMeshRenderer FLANKLJCMHF, long IJOPBJILIMI, float DIHLPKLDDFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6D0C3D0", Offset = "0x6D0B5D0", VA = "0x186D0C3D0")]
	public static void PEFLAENGCNK(PGPCOPIDIEC NFPHPNHHHMP, BatchedMeshRenderer FLANKLJCMHF, long IJOPBJILIMI, float FJBKCIAGPIH, bool MLPLNAEOKNG, float PFDDBFPHACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6D09060", Offset = "0x6D08260", VA = "0x186D09060")]
	public static float GNEPINAILMD(long LBAGOMBCPBJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6D080C0", Offset = "0x6D072C0", VA = "0x186D080C0")]
	public static (long, long) ACFGFGBIAEG(float OKOINPILBEH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6D08E10", Offset = "0x6D08010", VA = "0x186D08E10")]
	[IteratorStateMachine(typeof(IIGNPPBPELM))]
	public static IEnumerable<bool> FEDKEKEHAAL(long GPAFPLENPBL, bool DPCJBEMFIDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6D08290", Offset = "0x6D07490", VA = "0x186D08290")]
	public static void AODLNPANLHF(long GPAFPLENPBL, bool DPCJBEMFIDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6D097F0", Offset = "0x6D089F0", VA = "0x186D097F0")]
	public static int JFAMEDADMIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6D08500", Offset = "0x6D07700", VA = "0x186D08500")]
	internal static GBHEDBODDJM CAKCKPJOMBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6D07FA0", Offset = "0x6D071A0", VA = "0x186D07FA0")]
	internal static void AAANOENFOHI(GBHEDBODDJM GHCKILFLDAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6D08F10", Offset = "0x6D08110", VA = "0x186D08F10")]
	internal static KNEEGJKHLFG GCIPMLHKIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6D08030", Offset = "0x6D07230", VA = "0x186D08030")]
	internal static void AAANOENFOHI(KNEEGJKHLFG FFEOMKKKGMH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class OINKMALCKIL<KeyType> : PGPCOPIDIEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Dictionary<KeyType, KFAAIFBEMNJ> BBIEMIAGBBJ;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x49703D0", Offset = "0x496F5D0", VA = "0x1849703D0")]
	public OINKMALCKIL(string EPPPGDEIJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x496FE80", Offset = "0x496F080", VA = "0x18496FE80")]
	public void BGCIHOCIMCJ(KeyType CPBLLDDDHEE, KFAAIFBEMNJ INEKHEILENE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x4970090", Offset = "0x496F290", VA = "0x184970090")]
	public bool KFBAGIAPPOF(KeyType CPBLLDDDHEE, KFAAIFBEMNJ KOCNKNPELLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x496FFC0", Offset = "0x496F1C0", VA = "0x18496FFC0")]
	public void CMIBKOJIEHL(KeyType CPBLLDDDHEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4970270", Offset = "0x496F470", VA = "0x184970270", Slot = "4")]
	public override void LGGAGHBMEOG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6D0DB50", Offset = "0x6D0CD50", VA = "0x186D0DB50")]
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
