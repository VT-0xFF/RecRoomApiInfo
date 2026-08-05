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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
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
	public class LogRegistrationIndex : OACCHOKJOKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E69260", Offset = "0x6E68660", VA = "0x186E69260", Slot = "4")]
		public override void PFLPBBOAAPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class HOMJFDMIPJB
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EGGMDNJPOBA BDHOBIBILHC;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly EGGMDNJPOBA PJFKHBHJOIA;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly EGGMDNJPOBA IKFMEEPILKK;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class OJCELEIOPMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public APAGAKOJBPC NDBHBGLFMGJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FOKPONIAEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public OJCELEIOPMP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct APAGAKOJBPC
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct DEFDACMHMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half AFAAAHCJEFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort PEGJGDMCHLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte BIBFINEEBDN;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker OPHLEBBJNHM;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker KBELFIFFAFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int FOKPONIAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int DBMNEEKDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> NAIFNFGFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> AGJLIMCEKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<DEFDACMHMMB> AAILBGHDKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> CNMAJGJGMAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> FPDKGNJGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 GHIBMDLMKJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 MHIGAPPGFEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 OHEKICMKFBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 EJHEHHMHEOP;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long FMOLCKADCGA;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long BNMKPPCDAEE;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float NBNCCOFDCLJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool MINLJIFAEPL;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E57880", Offset = "0x6E56C80", VA = "0x186E57880")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AKHNHMEHOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E553F0", Offset = "0x6E547F0", VA = "0x186E553F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E593B0", Offset = "0x6E587B0", VA = "0x186E593B0")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A0F0", Offset = "0x6E594F0", VA = "0x186E5A0F0")]
	public static APAGAKOJBPC LIDOGEGODKP(Allocator MGFIHPDNFPH, JHEIAOJDPDC KLGIKHJFFBM)
	{
		return default(APAGAKOJBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E59B30", Offset = "0x6E58F30", VA = "0x186E59B30")]
	public static APAGAKOJBPC LIDOGEGODKP(Allocator MGFIHPDNFPH, NativeArray<float3> ADDNBBIKMEC, NativeArray<float3> ODKKGMPBJKC, NativeArray<float2> PLODBJAKOIN, NativeArray<float4> MKCAELLEOAB, bool COPGEAPBBOO, NativeArray<float4> BEDPOOLGKDB, NativeArray<int> ABBOFLBDEEI, int FOKPONIAEFG, int BFFPEPKNHPA, int DBMNEEKDOAB, int AGCNLBKNKHD)
	{
		return default(APAGAKOJBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E55AD0", Offset = "0x6E54ED0", VA = "0x186E55AD0")]
	public JHEIAOJDPDC EPLOKHOFIJA(Allocator MGFIHPDNFPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E55940", Offset = "0x6E54D40", VA = "0x186E55940")]
	public void EOAOEFFDOGH(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E57470", Offset = "0x6E56870", VA = "0x186E57470")]
	private void IMDPHJFMFHP(Mesh JIPKNCLPFGJ, NativeArray<ushort> BDBKCBFCDKK, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E5AC70", Offset = "0x6E5A070", VA = "0x186E5AC70")]
	public void NGIBIFHCNMG(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E586F0", Offset = "0x6E57AF0", VA = "0x186E586F0")]
	public void KCIDIDHGJFA(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E5B470", Offset = "0x6E5A870", VA = "0x186E5B470")]
	public void NINFPBDKPLJ(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E5C290", Offset = "0x6E5B690", VA = "0x186E5C290")]
	public void PABCDBHOFJC(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E57D50", Offset = "0x6E57150", VA = "0x186E57D50")]
	public void KBOOAFLAJCB(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E54230", Offset = "0x6E53630", VA = "0x186E54230")]
	public void AMJMOLBEKDE(Mesh JIPKNCLPFGJ, JHEIAOJDPDC.ICAHJJLBECK BJFFNJGHPDD, bool CHKEGFPBJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E59190", Offset = "0x6E58590", VA = "0x186E59190")]
	public long KCINKEJLBDO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E55A60", Offset = "0x6E54E60", VA = "0x186E55A60")]
	public long EOIBKJHEKFC(JHEIAOJDPDC.ICAHJJLBECK BJFFNJGHPDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E54990", Offset = "0x6E53D90", VA = "0x186E54990")]
	private void ANPNPPGAEBN(int EFLJOEAENFI, int IHOGEOAGCLG, Allocator MGFIHPDNFPH, bool HBPKNMMKIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E57C60", Offset = "0x6E57060", VA = "0x186E57C60")]
	private void JLKDPEFONMN(NativeArray<float3> DCKHCPKNHCG, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E50300", Offset = "0x6E4F700", VA = "0x186E50300")]
	[BurstCompile]
	private unsafe static void JLKDPEFONMN([NoAlias] float3* DCKHCPKNHCG, [In][NoAlias] ushort* ADDNBBIKMEC, int FOKPONIAEFG, [In] float3 GHIBMDLMKJM, [In] float3 MHIGAPPGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D470", Offset = "0x6E5C870", VA = "0x186E5D470")]
	[BurstCompile]
	private unsafe static void PNPMJLLAJDI([NoAlias] JHEIAOJDPDC.HKBEOFBHDGH* DCKHCPKNHCG, [In][NoAlias] ushort* ADDNBBIKMEC, int FOKPONIAEFG, [In] float3 GHIBMDLMKJM, [In] float3 MHIGAPPGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E55330", Offset = "0x6E54730", VA = "0x186E55330")]
	[BurstCompile]
	private unsafe static void CLCDDLGDKIP([NoAlias] JHEIAOJDPDC.DAOPGDBDEPE* DCKHCPKNHCG, [In][NoAlias] ushort* ADDNBBIKMEC, int FOKPONIAEFG, [In] float3 GHIBMDLMKJM, [In] float3 MHIGAPPGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A3C0", Offset = "0x6E597C0", VA = "0x186E5A3C0")]
	[BurstCompile]
	private unsafe static void LLFABOAFGNL([NoAlias] JHEIAOJDPDC.BMJADKPPJCL* DCKHCPKNHCG, [In][NoAlias] ushort* ADDNBBIKMEC, int FOKPONIAEFG, [In] float3 GHIBMDLMKJM, [In] float3 MHIGAPPGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A3C0", Offset = "0x6E597C0", VA = "0x186E5A3C0")]
	[BurstCompile]
	private unsafe static void NOGDBMJJJKD([NoAlias] JHEIAOJDPDC.OLAICILOCBA* DCKHCPKNHCG, [In][NoAlias] ushort* ADDNBBIKMEC, int FOKPONIAEFG, [In] float3 GHIBMDLMKJM, [In] float3 MHIGAPPGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E59250", Offset = "0x6E58650", VA = "0x186E59250")]
	[BurstCompile]
	private unsafe static void KIOBKNMODOD([NoAlias] JHEIAOJDPDC.AGJCGDPCNPJ* DCKHCPKNHCG, [In][NoAlias] ushort* ADDNBBIKMEC, int FOKPONIAEFG, [In] float3 GHIBMDLMKJM, [In] float3 MHIGAPPGFEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E596C0", Offset = "0x6E58AC0", VA = "0x186E596C0")]
	private void KNEONCDJHMD(NativeArray<float3> ADDNBBIKMEC, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E50560", Offset = "0x6E4F960", VA = "0x186E50560")]
	[BurstCompile]
	private unsafe static void KNEONCDJHMD([NoAlias] ushort* DCKHCPKNHCG, [Out] float3 JGCJFPIINJE, [Out] float3 MHIGAPPGFEO, [In][NoAlias] float3* ADDNBBIKMEC, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E54AC0", Offset = "0x6E53EC0", VA = "0x186E54AC0")]
	private void BIHACDBODJI(NativeArray<float3> ODKKGMPBJKC, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E54BA0", Offset = "0x6E53FA0", VA = "0x186E54BA0")]
	[BurstCompile]
	private unsafe static void BIHACDBODJI([NoAlias] ushort* MDCALHKDANF, [In][NoAlias] float3* ODKKGMPBJKC, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E567E0", Offset = "0x6E55BE0", VA = "0x186E567E0")]
	private void GEEANOPIKIK(NativeArray<float3> KKGEEEGALLI, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E565E0", Offset = "0x6E559E0", VA = "0x186E565E0")]
	[BurstCompile]
	private unsafe static void GEEANOPIKIK([NoAlias] float3* KKGEEEGALLI, [In][NoAlias] ushort* ODKKGMPBJKC, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E5AA40", Offset = "0x6E59E40", VA = "0x186E5AA40")]
	[BurstCompile]
	private unsafe static void MHFPOKEHCDG([NoAlias] JHEIAOJDPDC.HKBEOFBHDGH* DCKHCPKNHCG, [In][NoAlias] ushort* ODKKGMPBJKC, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E56180", Offset = "0x6E55580", VA = "0x186E56180")]
	[BurstCompile]
	private unsafe static void FODONMCBKIJ([NoAlias] JHEIAOJDPDC.DAOPGDBDEPE* DCKHCPKNHCG, [In][NoAlias] ushort* ODKKGMPBJKC, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E54850", Offset = "0x6E53C50", VA = "0x186E54850")]
	[BurstCompile]
	private unsafe static void ANOMPKMNMFN([NoAlias] JHEIAOJDPDC.BMJADKPPJCL* DCKHCPKNHCG, [In][NoAlias] ushort* ODKKGMPBJKC, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E56030", Offset = "0x6E55430", VA = "0x186E56030")]
	[BurstCompile]
	private unsafe static void FDDIMGBNEFP([NoAlias] JHEIAOJDPDC.OLAICILOCBA* DCKHCPKNHCG, [In][NoAlias] ushort* ODKKGMPBJKC, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E54FA0", Offset = "0x6E543A0", VA = "0x186E54FA0")]
	[BurstCompile]
	private unsafe static void CGJCMAFJMLL([NoAlias] JHEIAOJDPDC.AGJCGDPCNPJ* DCKHCPKNHCG, [In][NoAlias] ushort* ODKKGMPBJKC, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CE00", Offset = "0x6E5C200", VA = "0x186E5CE00")]
	private void PHMCANMBGBL(NativeArray<float2> PLODBJAKOIN, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CEF0", Offset = "0x6E5C2F0", VA = "0x186E5CEF0")]
	[BurstCompile]
	private unsafe static void PHMCANMBGBL([NoAlias] ushort* OIEDEHHCAMP, [Out] float2 BGFDAKOKHHP, [Out] float2 EJHEHHMHEOP, [In][NoAlias] float2* PLODBJAKOIN, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D420", Offset = "0x6E5C820", VA = "0x186E5D420")]
	[BurstCompile]
	private static void PLMLDDAGOGC([Out] float2 ABOABOOHKAO, ushort MBGBBKOFIDB, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5C040", Offset = "0x6E5B440", VA = "0x186E5C040")]
	private void ODPKDCGKBOD(NativeArray<float2> OIEDEHHCAMP, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5C1B0", Offset = "0x6E5B5B0", VA = "0x186E5C1B0")]
	[BurstCompile]
	private unsafe static void ODPKDCGKBOD([NoAlias] float2* OIEDEHHCAMP, [NoAlias] ushort* PLODBJAKOIN, int FOKPONIAEFG, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E57370", Offset = "0x6E56770", VA = "0x186E57370")]
	[BurstCompile]
	private unsafe static void IDENCHLKBEP([NoAlias] JHEIAOJDPDC.HKBEOFBHDGH* DCKHCPKNHCG, [NoAlias] ushort* PLODBJAKOIN, int FOKPONIAEFG, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E56C70", Offset = "0x6E56070", VA = "0x186E56C70")]
	[BurstCompile]
	private unsafe static void GJPOJEAHPCC([NoAlias] JHEIAOJDPDC.DAOPGDBDEPE* DCKHCPKNHCG, [NoAlias] ushort* PLODBJAKOIN, int FOKPONIAEFG, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E594D0", Offset = "0x6E588D0", VA = "0x186E594D0")]
	[BurstCompile]
	private unsafe static void KMGHALDBLJF([NoAlias] JHEIAOJDPDC.BMJADKPPJCL* DCKHCPKNHCG, [NoAlias] ushort* PLODBJAKOIN, int FOKPONIAEFG, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BF40", Offset = "0x6E5B340", VA = "0x186E5BF40")]
	[BurstCompile]
	private unsafe static void NMIDJLLNGMC([NoAlias] JHEIAOJDPDC.OLAICILOCBA* DCKHCPKNHCG, [NoAlias] ushort* PLODBJAKOIN, int FOKPONIAEFG, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E597B0", Offset = "0x6E58BB0", VA = "0x186E597B0")]
	[BurstCompile]
	private unsafe static void LDNDNNNMJBN([NoAlias] JHEIAOJDPDC.AGJCGDPCNPJ* DCKHCPKNHCG, [NoAlias] ushort* PLODBJAKOIN, int FOKPONIAEFG, [In] float2 OHEKICMKFBC, [In] float2 EJHEHHMHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E55790", Offset = "0x6E54B90", VA = "0x186E55790")]
	private void EKGHEHKBBNL(NativeArray<float4> BEDPOOLGKDB, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E55670", Offset = "0x6E54A70", VA = "0x186E55670")]
	[BurstCompile]
	private unsafe static void EKGHEHKBBNL([NoAlias] ushort* ALNBOPLDCNB, [In][NoAlias] float4* PMMIEKHFGAB, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D390", Offset = "0x6E5C790", VA = "0x186E5D390")]
	[BurstCompile]
	private static ushort PKKKFBFCPNL([In] float4 GIIFDBNFBDJ)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E598B0", Offset = "0x6E58CB0", VA = "0x186E598B0")]
	private void LFFKOKOFOAM(NativeArray<float4> ALNBOPLDCNB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E599E0", Offset = "0x6E58DE0", VA = "0x186E599E0")]
	[BurstCompile]
	private unsafe static void LFFKOKOFOAM([NoAlias] float4* ALNBOPLDCNB, [In][NoAlias] ushort* BEDPOOLGKDB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E56960", Offset = "0x6E55D60", VA = "0x186E56960")]
	[BurstCompile]
	private unsafe static void GJPDDFIJNHA([NoAlias] JHEIAOJDPDC.HKBEOFBHDGH* DCKHCPKNHCG, [In][NoAlias] ushort* BEDPOOLGKDB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E56D70", Offset = "0x6E56170", VA = "0x186E56D70")]
	[BurstCompile]
	private unsafe static void HCMDCKIPPKF([NoAlias] JHEIAOJDPDC.DAOPGDBDEPE* DCKHCPKNHCG, [In][NoAlias] ushort* BEDPOOLGKDB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E53EB0", Offset = "0x6E532B0", VA = "0x186E53EB0")]
	[BurstCompile]
	private unsafe static void AEDDELFAKEL([NoAlias] JHEIAOJDPDC.BMJADKPPJCL* DCKHCPKNHCG, [In][NoAlias] ushort* BEDPOOLGKDB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E55100", Offset = "0x6E54500", VA = "0x186E55100")]
	[BurstCompile]
	private unsafe static void CJHNDNBAHPO([NoAlias] JHEIAOJDPDC.OLAICILOCBA* DCKHCPKNHCG, [In][NoAlias] ushort* BEDPOOLGKDB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E55E00", Offset = "0x6E55200", VA = "0x186E55E00")]
	[BurstCompile]
	private unsafe static void FBMAPBMFHJG([NoAlias] JHEIAOJDPDC.AGJCGDPCNPJ* DCKHCPKNHCG, [In][NoAlias] ushort* BEDPOOLGKDB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E568A0", Offset = "0x6E55CA0", VA = "0x186E568A0")]
	[BurstCompile]
	private static void GFHLDDNKMBL([Out] float4 CIFMGKBFCHA, ushort MBGBBKOFIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A640", Offset = "0x6E59A40", VA = "0x186E5A640")]
	private void MFIKMICHMKF(Allocator MGFIHPDNFPH, NativeArray<float4> MKCAELLEOAB, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A480", Offset = "0x6E59880", VA = "0x186E5A480")]
	[BurstCompile]
	private unsafe static void MFIKMICHMKF([NoAlias] float4* DFLBNLEBAFP, [NoAlias] byte* PIIEHFDJAAE, [Out] int BAKICDOHFEI, [Out] int PMMNPPADHNJ, [NoAlias] float4* MKCAELLEOAB, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E56400", Offset = "0x6E55800", VA = "0x186E56400")]
	private static void GADIMKPKNOC(NativeArray<float4> JDAFNOMJNBG, NativeArray<DEFDACMHMMB> EGILEHGMHCM, NativeArray<byte> KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E562C0", Offset = "0x6E556C0", VA = "0x186E562C0")]
	[BurstCompile]
	private unsafe static void GADIMKPKNOC([NoAlias] float4* JDAFNOMJNBG, [In][NoAlias] DEFDACMHMMB* EGILEHGMHCM, [In][NoAlias] byte* KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E57A80", Offset = "0x6E56E80", VA = "0x186E57A80")]
	[BurstCompile]
	private unsafe static void JGONAFNJPHJ([NoAlias] JHEIAOJDPDC.HKBEOFBHDGH* DCKHCPKNHCG, [In][NoAlias] DEFDACMHMMB* EGILEHGMHCM, [In][NoAlias] byte* KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D1B0", Offset = "0x6E5C5B0", VA = "0x186E5D1B0")]
	[BurstCompile]
	private unsafe static void PJOMECFIMCI([NoAlias] JHEIAOJDPDC.DAOPGDBDEPE* DCKHCPKNHCG, [In][NoAlias] DEFDACMHMMB* EGILEHGMHCM, [In][NoAlias] byte* KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E576A0", Offset = "0x6E56AA0", VA = "0x186E576A0")]
	[BurstCompile]
	private unsafe static void IMHAJPKCJNN([NoAlias] JHEIAOJDPDC.BMJADKPPJCL* DCKHCPKNHCG, [In][NoAlias] DEFDACMHMMB* EGILEHGMHCM, [In][NoAlias] byte* KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CBC0", Offset = "0x6E5BFC0", VA = "0x186E5CBC0")]
	[BurstCompile]
	private unsafe static void PCFMJIEJDBH([NoAlias] JHEIAOJDPDC.OLAICILOCBA* DCKHCPKNHCG, [In][NoAlias] DEFDACMHMMB* EGILEHGMHCM, [In][NoAlias] byte* KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E55430", Offset = "0x6E54830", VA = "0x186E55430")]
	[BurstCompile]
	private unsafe static void EHJMKCNHCAA([NoAlias] JHEIAOJDPDC.AGJCGDPCNPJ* DCKHCPKNHCG, [In][NoAlias] DEFDACMHMMB* EGILEHGMHCM, [In][NoAlias] byte* KJAGIDIHODB, int FOKPONIAEFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BE40", Offset = "0x6E5B240", VA = "0x186E5BE40")]
	private void NJAHKHCNNDO(Allocator MGFIHPDNFPH, NativeArray<int> ABBOFLBDEEI, int AGCNLBKNKHD, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E56F40", Offset = "0x6E56340", VA = "0x186E56F40")]
	private static NativeArray<byte> HEKGCMIPBHG(Allocator MGFIHPDNFPH, NativeArray<int> ABBOFLBDEEI, int EMINMAJKJBA)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E57270", Offset = "0x6E56670", VA = "0x186E57270")]
	[BurstCompile]
	private unsafe static int HEKGCMIPBHG([NoAlias] byte* OMPODBABHHE, [In][NoAlias] int* ABBOFLBDEEI, int EMINMAJKJBA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E54110", Offset = "0x6E53510", VA = "0x186E54110")]
	private static void AEEKAPMEAHF(NativeArray<int> PMFFMBIGBDF, NativeArray<byte> JGJJBFOOENC, int DBMNEEKDOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E54070", Offset = "0x6E53470", VA = "0x186E54070")]
	[BurstCompile]
	private unsafe static void AEEKAPMEAHF([NoAlias] int* PMFFMBIGBDF, [In][NoAlias] byte* JGJJBFOOENC, int DBMNEEKDOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E547B0", Offset = "0x6E53BB0", VA = "0x186E547B0")]
	[BurstCompile]
	private unsafe static void ANCKMAENNAK([NoAlias] ushort* PMFFMBIGBDF, [In][NoAlias] byte* JGJJBFOOENC, int DBMNEEKDOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E54E60", Offset = "0x6E54260", VA = "0x186E54E60")]
	[BurstCompile]
	private static void CDCHNLGNEAN([Out] float3 ABOABOOHKAO, ushort MBGBBKOFIDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E578C0", Offset = "0x6E56CC0", VA = "0x186E578C0")]
	[BurstCompile]
	private static ushort JFHNDCOHCEG([In] float3 GIIFDBNFBDJ)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class JHEIAOJDPDC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum ICAHJJLBECK
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
	public enum JBACGDNBMMK
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
	public struct CBLMGIFKMCJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public ICAHJJLBECK BJFFNJGHPDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool LIPEKAKJDGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int IKGDPNGKGGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct IHKFLBLHCGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 MBJNFCDOKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 JNKEFPKOLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 DELILHLDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 GCLMMBPCLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 AAILBGHDKBJ;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct HKBEOFBHDGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 MBJNFCDOKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 JNKEFPKOLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 DELILHLDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 GCLMMBPCLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 AAILBGHDKBJ;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct DAOPGDBDEPE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 MBJNFCDOKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint JNKEFPKOLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint DELILHLDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 GCLMMBPCLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 AAILBGHDKBJ;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct BMJADKPPJCL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 MBJNFCDOKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint JNKEFPKOLCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint DELILHLDNMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 GCLMMBPCLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 AAILBGHDKBJ;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct OLAICILOCBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 MBJNFCDOKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint GHHLBGOFICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 GCLMMBPCLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint CAABOPBANIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint EINABLJOMPM;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct AGJCGDPCNPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public GMGAMLELKCD.KJOMJGGFAOH GLKGEFEOAHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint GHHLBGOFICD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 GCLMMBPCLNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint CAABOPBANIN;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] PCKKNAGJKBJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int JJKGFDAOHBN(float CFANGCOBGCF);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class GDPOFOLMOCK
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E6D0", Offset = "0x6E5DAD0", VA = "0x186E5E6D0")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E280", Offset = "0x6E5D680", VA = "0x186E5E280")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E3D0", Offset = "0x6E5D7D0", VA = "0x186E5E3D0")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E470", Offset = "0x6E5D870", VA = "0x186E5E470")]
		public static int JNFLGGLMFJH(float CFANGCOBGCF)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint AFDNBNEFHNP([In] float4 IDIHIILANOF);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class OPOPNMBFDHC
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E6BB00", Offset = "0x6E6AF00", VA = "0x186E6BB00")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E6B5E0", Offset = "0x6E6A9E0", VA = "0x186E6B5E0")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E6B730", Offset = "0x6E6AB30", VA = "0x186E6B730")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E6B7D0", Offset = "0x6E6ABD0", VA = "0x186E6B7D0")]
		public static uint JNFLGGLMFJH([In] float4 IDIHIILANOF)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint GHEFODBGECK([In] float3 IDIHIILANOF);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class PCKHPMIFEBP
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E6C080", Offset = "0x6E6B480", VA = "0x186E6C080")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E6BC20", Offset = "0x6E6B020", VA = "0x186E6BC20")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6BD70", Offset = "0x6E6B170", VA = "0x186E6BD70")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E6BE10", Offset = "0x6E6B210", VA = "0x186E6BE10")]
		public static uint JNFLGGLMFJH([In] float3 IDIHIILANOF)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void FNHJGGIBMLP([NoAlias] DAOPGDBDEPE* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class JBJGAACJEIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E62870", Offset = "0x6E61C70", VA = "0x186E62870")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E62450", Offset = "0x6E61850", VA = "0x186E62450")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E625A0", Offset = "0x6E619A0", VA = "0x186E625A0")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E62640", Offset = "0x6E61A40", VA = "0x186E62640")]
		public unsafe static void JNFLGGLMFJH([NoAlias] DAOPGDBDEPE* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void AONLPMADEEP([NoAlias] BMJADKPPJCL* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class NGDLLNPBOHJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E69AC0", Offset = "0x6E68EC0", VA = "0x186E69AC0")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E696A0", Offset = "0x6E68AA0", VA = "0x186E696A0")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E697F0", Offset = "0x6E68BF0", VA = "0x186E697F0")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E69890", Offset = "0x6E68C90", VA = "0x186E69890")]
		public unsafe static void JNFLGGLMFJH([NoAlias] BMJADKPPJCL* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void GKGEDKHGFAE([NoAlias] OLAICILOCBA* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class FPCACBNOMFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E160", Offset = "0x6E5D560", VA = "0x186E5E160")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E5DB90", Offset = "0x6E5CF90", VA = "0x186E5DB90")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E5DCE0", Offset = "0x6E5D0E0", VA = "0x186E5DCE0")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E5DD80", Offset = "0x6E5D180", VA = "0x186E5DD80")]
		public unsafe static void JNFLGGLMFJH([NoAlias] OLAICILOCBA* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void IJENBFGGGNI([NoAlias] AGJCGDPCNPJ* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ, [Out] float3 DENNKMKBKHK, [Out] float3 OBCMFGALJKP);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class KHIOBJBNBNG
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr MDGBPJKGNLB;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr CLPPNIBHLPM;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E68FB0", Offset = "0x6E683B0", VA = "0x186E68FB0")]
		[BurstDiscard]
		private static void PHMHMKAFIHH(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E68870", Offset = "0x6E67C70", VA = "0x186E68870")]
		private static IntPtr HMECCPKMOKB()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E689C0", Offset = "0x6E67DC0", VA = "0x186E689C0")]
		public static void JJHHMDEHGHL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public static void JLABJFAHLGH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E68A60", Offset = "0x6E67E60", VA = "0x186E68A60")]
		public unsafe static void JNFLGGLMFJH([NoAlias] AGJCGDPCNPJ* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ, [Out] float3 DENNKMKBKHK, [Out] float3 OBCMFGALJKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int EJPBNIBNCEE = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> LLMKFLNHOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> POJOLGFGADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> IAGMCOAKCCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> EKHLBGKEDDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> KOBOIFIKHCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> FIJADABDIKJ;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] IMPCDLFKACP;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool IKBBFDHDKIJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static CBLMGIFKMCJ[] IPIJDMIFBDB;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool KGFOOIOHGJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E64ED0", Offset = "0x6E642D0", VA = "0x186E64ED0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E64840", Offset = "0x6E63C40", VA = "0x186E64840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PKCENLFOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E641C0", Offset = "0x6E635C0", VA = "0x186E641C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool AKHNHMEHOAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E64120", Offset = "0x6E63520", VA = "0x186E64120")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E62F70", Offset = "0x6E62370", VA = "0x186E62F70")]
	public static JBACGDNBMMK BOCBFIBOOJN(ICAHJJLBECK BJFFNJGHPDD)
	{
		return default(JBACGDNBMMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E64FE0", Offset = "0x6E643E0", VA = "0x186E64FE0")]
	public static void JGGBOABEKII(JBACGDNBMMK MFLLKJPHNJJ, Material LBOPCEJDNFN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E64010", Offset = "0x6E63410", VA = "0x186E64010", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E62D10", Offset = "0x6E62110", VA = "0x186E62D10")]
	public void ANPNPPGAEBN(int EFLJOEAENFI, int IHOGEOAGCLG, Allocator MGFIHPDNFPH, bool KHFNCBCGHLL, bool HBPKNMMKIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E650A0", Offset = "0x6E644A0", VA = "0x186E650A0")]
	public void KAEEBLKLDLB(int EFLJOEAENFI, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E64EB0", Offset = "0x6E642B0", VA = "0x186E64EB0", Slot = "6")]
	public bool GJMJKMABKML(Mesh JIPKNCLPFGJ, bool OBDPFOEADCH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E64200", Offset = "0x6E63600", VA = "0x186E64200")]
	public bool EOAOEFFDOGH(Mesh JIPKNCLPFGJ, bool OBDPFOEADCH, bool CHKEGFPBJIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E62FC0", Offset = "0x6E623C0", VA = "0x186E62FC0")]
	public bool CKCIHMLHIDL(Mesh JIPKNCLPFGJ, JHEIAOJDPDC CEJICKOMFFD, bool OBDPFOEADCH = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E66930", Offset = "0x6E65D30", VA = "0x186E66930")]
	public void NGIBIFHCNMG(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E62BE0", Offset = "0x6E61FE0", VA = "0x186E62BE0")]
	[BurstCompile]
	public static int AGHMHFFJAHN(float CFANGCOBGCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C30", Offset = "0x6E62030", VA = "0x186E62C30")]
	[BurstCompile]
	public static uint AGHMHFFJAHN([In] float4 IDIHIILANOF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E62B90", Offset = "0x6E61F90", VA = "0x186E62B90")]
	[BurstCompile]
	public static uint AGHMHFFJAHN([In] float3 IDIHIILANOF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E65860", Offset = "0x6E64C60", VA = "0x186E65860")]
	public void KCIDIDHGJFA(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E64880", Offset = "0x6E63C80", VA = "0x186E64880")]
	[BurstCompile]
	private unsafe static void GDPOHFJPLIJ([NoAlias] DAOPGDBDEPE* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E67370", Offset = "0x6E66770", VA = "0x186E67370")]
	public void NINFPBDKPLJ(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E683F0", Offset = "0x6E677F0", VA = "0x186E683F0")]
	[BurstCompile]
	private unsafe static void POCCKODNLNA([NoAlias] BMJADKPPJCL* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E67D60", Offset = "0x6E67160", VA = "0x186E67D60")]
	public void PABCDBHOFJC(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E67A00", Offset = "0x6E66E00", VA = "0x186E67A00")]
	[BurstCompile]
	private unsafe static void ODIKPJPFAEK([NoAlias] OLAICILOCBA* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E65120", Offset = "0x6E64520", VA = "0x186E65120")]
	public void KBOOAFLAJCB(Mesh JIPKNCLPFGJ, bool CHKEGFPBJIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E660A0", Offset = "0x6E654A0", VA = "0x186E660A0")]
	[BurstCompile]
	private unsafe static void KODKACNAJDF([NoAlias] AGJCGDPCNPJ* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ, [Out] float3 DENNKMKBKHK, [Out] float3 OBCMFGALJKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E62C80", Offset = "0x6E62080", VA = "0x186E62C80")]
	public void AMJMOLBEKDE(Mesh JIPKNCLPFGJ, ICAHJJLBECK BJFFNJGHPDD, bool CHKEGFPBJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E64C40", Offset = "0x6E64040", VA = "0x186E64C40")]
	public void GIEFCFNIIEO(JHEIAOJDPDC JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E634C0", Offset = "0x6E628C0", VA = "0x186E634C0")]
	public void DDHLLOKIKHA(JHEIAOJDPDC PPIMIKDHEBO, Allocator MGFIHPDNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E65F50", Offset = "0x6E65350", VA = "0x186E65F50")]
	public long KCINKEJLBDO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E65EF0", Offset = "0x6E652F0", VA = "0x186E65EF0")]
	public static long KCINKEJLBDO(int PMKBMAGDEAF, int PNGICABKGAO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E646C0", Offset = "0x6E63AC0", VA = "0x186E646C0")]
	public static long EOIBKJHEKFC(int PMKBMAGDEAF, int PNGICABKGAO, ICAHJJLBECK BJFFNJGHPDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E64600", Offset = "0x6E63A00", VA = "0x186E64600")]
	public long EOIBKJHEKFC(ICAHJJLBECK BJFFNJGHPDD)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E64160", Offset = "0x6E63560", VA = "0x186E64160")]
	public void EIJCGLDANIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E63D20", Offset = "0x6E63120", VA = "0x186E63D20")]
	public static void DNDAHFHBOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E635C0", Offset = "0x6E629C0", VA = "0x186E635C0")]
	public ICAHJJLBECK DEGAIDJEDLM()
	{
		return default(ICAHJJLBECK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E64F10", Offset = "0x6E64310", VA = "0x186E64F10")]
	public static (int, int) JGDKIEODLAD(Mesh JIPKNCLPFGJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E64760", Offset = "0x6E63B60", VA = "0x186E64760")]
	public static int FOANDCCODNK(VertexAttributeDescriptor[] BBMCPCBJFCN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E62F00", Offset = "0x6E62300", VA = "0x186E62F00")]
	public static long BLLDMECNHAI(Mesh JIPKNCLPFGJ, int CHEJBAMPNAH, int BHIJLNBCEOB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public JHEIAOJDPDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E67A80", Offset = "0x6E66E80", VA = "0x186E67A80")]
	[BurstCompile]
	public static int OGEMNODLEPI(float CFANGCOBGCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E67BD0", Offset = "0x6E66FD0", VA = "0x186E67BD0")]
	[BurstCompile]
	public static uint OGEMNODLEPI([In] float4 IDIHIILANOF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E67B20", Offset = "0x6E66F20", VA = "0x186E67B20")]
	[BurstCompile]
	public static uint OGEMNODLEPI([In] float3 IDIHIILANOF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E66120", Offset = "0x6E65520", VA = "0x186E66120")]
	[BurstCompile]
	public unsafe static void LBNCDCPKCKL([NoAlias] DAOPGDBDEPE* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E664E0", Offset = "0x6E658E0", VA = "0x186E664E0")]
	[BurstCompile]
	public unsafe static void MOJLCEDOODP([NoAlias] BMJADKPPJCL* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E62990", Offset = "0x6E61D90", VA = "0x186E62990")]
	[BurstCompile]
	public unsafe static void AFBACMCOGPD([NoAlias] OLAICILOCBA* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E64900", Offset = "0x6E63D00", VA = "0x186E64900")]
	[BurstCompile]
	public unsafe static void GEKLMPAOHEP([NoAlias] AGJCGDPCNPJ* DCKHCPKNHCG, int FOKPONIAEFG, [In][NoAlias] float3* MPCMBJJFAMG, [In][NoAlias] float3* GNELJAACCHK, [In][NoAlias] float4* PFPBCCHMFMG, [In][NoAlias] float2* AGJLIMCEKNH, [In][NoAlias] float4* AAILBGHDKBJ, [Out] float3 DENNKMKBKHK, [Out] float3 OBCMFGALJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct ECEIKPEAFAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int CNCBAOKBNIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 HFINFJBADAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion DJJGAKMOIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 BGDOMABLBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int OHHFCMHKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int LCIPJNBIBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int MOAAHFAJDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float HAMDPIMKFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 OMCHIDKECOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool MIAAIGBGKCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public LMGKIBLKANC OKFMLNBFFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 BICFCHHMKBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float MCDIPCHGHCK;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IGMDHOIMGAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static KBGPMHOBMPJ GJPNPGHADEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<ECEIKPEAFAB> LLDPOOMICOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<MDDMDCBCANL> CIDIECMIOMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<MEMHHIFIDAB> BAOHBECHKLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<HIKPHCIMFOK> EBMOAIAPNJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<MDDMDCBCANL> DNNKNBKNPGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<JBLIMDNCFAM> OFPONOLKLAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<HIKPHCIMFOK>> MOFIBHBHKEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<NOLMEEDJECJ> IJALDJDCBAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> DKOKJDDONLG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x964010", Offset = "0x963410", VA = "0x180964010")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x9621C0", Offset = "0x9615C0", VA = "0x1809621C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int PKCENLFOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x964000", Offset = "0x963400", VA = "0x180964000")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x9621D0", Offset = "0x9615D0", VA = "0x1809621D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E61F70", Offset = "0x6E61370", VA = "0x186E61F70")]
	public IGMDHOIMGAD(int FJOLINMKNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E60230", Offset = "0x6E5F630", VA = "0x186E60230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E61DA0", Offset = "0x6E611A0", VA = "0x186E61DA0")]
	public void KMANLEPJEHF(JobHandle LGCKIPFOBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E606A0", Offset = "0x6E5FAA0", VA = "0x186E606A0")]
	public void FANNAPMNPPE(ECEIKPEAFAB MPMEGOKIEPF, NOLMEEDJECJ LJPLNGKDFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E61900", Offset = "0x6E60D00", VA = "0x186E61900")]
	public void FGGPCCBHCCE(MEMHHIFIDAB MPMEGOKIEPF, NativeArray<HIKPHCIMFOK> BJKJMDAIGPD, int FOKPONIAEFG, int DBMNEEKDOAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E608C0", Offset = "0x6E5FCC0", VA = "0x186E608C0")]
	public JobHandle FECOMGEAJKN(JHEIAOJDPDC NNADINDOFED, AJMMIHNBKJG ONIPMGKKBCJ, float3 BBPNINBEHGA, quaternion PEEAGMCEPNH, float IJHHGICIOIF, bool OBNILMGOOFM, int KHCLHLMMJDM = 0, int PIKFGNGGDBG = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E61A60", Offset = "0x6E60E60", VA = "0x186E61A60")]
	public static JobHandle GACEDBNCECJ(LKFGHDMELOC CBDNNDEHCDP, JHEIAOJDPDC NNADINDOFED, ECEIKPEAFAB MPMEGOKIEPF, JobHandle LGCKIPFOBAH)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E603F0", Offset = "0x6E5F7F0", VA = "0x186E603F0")]
	public static JobHandle ELKKJCHLPGF(MJIMMGLKGDN CBDNNDEHCDP, JHEIAOJDPDC NNADINDOFED, MEMHHIFIDAB MPMEGOKIEPF, NativeArray<HIKPHCIMFOK> BJKJMDAIGPD, int FOKPONIAEFG, int DBMNEEKDOAB, JobHandle LGCKIPFOBAH)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct DKFDABPLLAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 BLOODECNJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 FMOFMIPIDFE;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class BCMPEEPFMGG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<DKFDABPLLAO> ABLBNGNEEEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> AMMCOBJJAAE;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AE510", Offset = "0x8AD910", VA = "0x1808AE510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int PKCENLFOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8AEC60", Offset = "0x8AE060", VA = "0x1808AEC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D750", Offset = "0x6E5CB50", VA = "0x186E5D750")]
	public BCMPEEPFMGG(int EFLJOEAENFI, int IHOGEOAGCLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D610", Offset = "0x6E5CA10", VA = "0x186E5D610", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D670", Offset = "0x6E5CA70", VA = "0x186E5D670")]
	public void GIEFCFNIIEO(BCMPEEPFMGG EPJIEJLEKCH, int CGBJOJMADKG, int IHLILPEDKCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class OOOCJAEBEHH
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static BCMPEEPFMGG PKBPAIJEMFH;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<MDDMDCBCANL> JAJAOCEEKHK;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] BKBOHBJGIDN;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool NAIOPKEDICA;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, BCMPEEPFMGG> BEIAMOHOPJF;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, BCMPEEPFMGG> DNOHLBBMIFB;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool FCMOEFPAOIO
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A8C0", Offset = "0x6E69CC0", VA = "0x186E6A8C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<MDDMDCBCANL> HOGHBLIIFAD
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E6A7C0", Offset = "0x6E69BC0", VA = "0x186E6A7C0")]
		get
		{
			return default(NativeList<MDDMDCBCANL>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static BCMPEEPFMGG NAFFMMGPMNN
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E69FC0", Offset = "0x6E693C0", VA = "0x186E69FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E6ABD0", Offset = "0x6E69FD0", VA = "0x186E6ABD0")]
	private static void KAPKGAOMPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A790", Offset = "0x6E69B90", VA = "0x186E6A790")]
	public static int INPFKDOFFKM(bool OLAIHMGMIHK, int CIJAMKNOMBN, bool HLAALHJAIFG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B370", Offset = "0x6E6A770", VA = "0x186E6B370")]
	private static int LHEDJNOPLLO(int CIJAMKNOMBN, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E69DF0", Offset = "0x6E691F0", VA = "0x186E69DF0")]
	private static int AOCPOJMNNFN(int CIJAMKNOMBN, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E69D60", Offset = "0x6E69160", VA = "0x186E69D60")]
	public static int ALPLEAMPMHC(int KFELJFNOKBH, int CIJAMKNOMBN, int ENPKNLOOKHG, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B2D0", Offset = "0x6E6A6D0", VA = "0x186E6B2D0")]
	public static int KMKNFLBEBMM(int KFELJFNOKBH, int CIJAMKNOMBN, int ENPKNLOOKHG, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B480", Offset = "0x6E6A880", VA = "0x186E6B480")]
	public static int PDHFMHKMNMP(int ENPKNLOOKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B360", Offset = "0x6E6A760", VA = "0x186E6B360")]
	private static int LGKGKOEEMHO(int CIJAMKNOMBN, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E69E00", Offset = "0x6E69200", VA = "0x186E69E00")]
	private static int CINBJFPIJMM(int CIJAMKNOMBN, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A850", Offset = "0x6E69C50", VA = "0x186E6A850")]
	public static int JGNMGBODPKL(int KFELJFNOKBH, int CIJAMKNOMBN, int ENPKNLOOKHG, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E69E20", Offset = "0x6E69220", VA = "0x186E69E20")]
	public static int CJADHHFPNEH(int KFELJFNOKBH, int CIJAMKNOMBN, int ENPKNLOOKHG, bool AABFCCODJLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E69EB0", Offset = "0x6E692B0", VA = "0x186E69EB0")]
	public static int EAFMAEFBHFA(int ENPKNLOOKHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B390", Offset = "0x6E6A790", VA = "0x186E6B390")]
	public static BCMPEEPFMGG NBCOCMEDAMC(int CIJAMKNOMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A940", Offset = "0x6E69D40", VA = "0x186E6A940")]
	private static BCMPEEPFMGG JPFJCFJHDEI(int CIJAMKNOMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E69ED0", Offset = "0x6E692D0", VA = "0x186E69ED0")]
	public static BCMPEEPFMGG ELACDANGCFC(int CIJAMKNOMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A050", Offset = "0x6E69450", VA = "0x186E6A050")]
	private static BCMPEEPFMGG HCFNCJBPKBG(int CIJAMKNOMBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E6A390", Offset = "0x6E69790", VA = "0x186E6A390")]
	public static void IMGLILPEJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct MEMHHIFIDAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int CGOEKEKMJNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 HFINFJBADAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion DJJGAKMOIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float BGDOMABLBDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float CJKJGPOHNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int OHHFCMHKMGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int LCIPJNBIBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int MOAAHFAJDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool EGADNIJCCMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool ICADOFEIDKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float HAMDPIMKFDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 OMCHIDKECOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool PPOHGPDLLMH;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct JBLIMDNCFAM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int JFGAALNPGPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int JBIJOBCDCPP;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct MJIMMGLKGDN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<MEMHHIFIDAB> HIJDKBAEBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<HIKPHCIMFOK> KIHOOCODGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<MDDMDCBCANL> JEHFHPNMOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<JBLIMDNCFAM> AAFEDHKHLBB;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E69570", Offset = "0x6E68970", VA = "0x186E69570")]
	public MJIMMGLKGDN(NativeArray<HIKPHCIMFOK> KIHOOCODGEN, int MFKKELONDCC = 1, Allocator MGFIHPDNFPH = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6E69480", Offset = "0x6E68880", VA = "0x186E69480", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct ALENGOFBLAO : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<DKFDABPLLAO> PJFKJODKLNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> NDAPFGJGHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<MDDMDCBCANL> FHDLFDPHDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<MEMHHIFIDAB> HIJDKBAEBEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<HIKPHCIMFOK> KIHOOCODGEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<MDDMDCBCANL> JEHFHPNMOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<JBLIMDNCFAM> AAFEDHKHLBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int FMNAIJPFNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int JOFFANFDFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 LONLLKBDFMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion LNBDAMKAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 DJKNCGFJJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PKLFBBALAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OCICDFBJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DKBLNDJINLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HKKBPLKBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MPJNMJEFFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BEDMNBODGCE;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6E53900", Offset = "0x6E52D00", VA = "0x186E53900")]
	public ALENGOFBLAO(IGMDHOIMGAD GAPMGEJJLAP, JHEIAOJDPDC CCFOBKCAPBC, float3 KEPGMBLKCJP, quaternion DMNDCBJONGM, float OFGKLDPPEFK, int KHCLHLMMJDM = 0, int PIKFGNGGDBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E53B80", Offset = "0x6E52F80", VA = "0x186E53B80")]
	public ALENGOFBLAO(MJIMMGLKGDN GAPMGEJJLAP, JHEIAOJDPDC CCFOBKCAPBC, float3 KEPGMBLKCJP, quaternion DMNDCBJONGM, float3 OFGKLDPPEFK, int KHCLHLMMJDM = 0, int PIKFGNGGDBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E537C0", Offset = "0x6E52BC0", VA = "0x186E537C0")]
	private float3 OJOCNNKPHJK(float3 PHDMCBAHHEF, Matrix4x4 MIJFGNNDDIB)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6E51EB0", Offset = "0x6E512B0", VA = "0x186E51EB0")]
	private float3x3 BDDCEGCGBEJ(float3x3 PKPCNBPNKJE, float3x3 OEKNKONLMJG)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E51EA0", Offset = "0x6E512A0", VA = "0x186E51EA0")]
	private float BCAAFLJJCIM(float BJGGPAGHNPO, float MPIJAPBAJBC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E51F30", Offset = "0x6E51330", VA = "0x186E51F30", Slot = "4")]
	public void Execute(int HOEIKPCADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E530D0", Offset = "0x6E524D0", VA = "0x186E530D0")]
	private void HNGPOIKJGKC(int MAGACBBIHAN, float3 MBJNFCDOKCE, float3 JNKEFPKOLCG, float3 DELILHLDNMB, float MINBCCGNENH, bool BEAJNPHMNNB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E51A60", Offset = "0x6E50E60", VA = "0x186E51A60")]
	private void ALJBOONCLFL(MEMHHIFIDAB ONPOPNDPDKI, float3 JMOAHJJIPDJ, float3x3 NDIDLOHFNJO, float BJGGPAGHNPO, int DCEHMIPCKJH, int DCADGBFOJDP, int IOJBMKMPFKB, float JLPPICDFEJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E53240", Offset = "0x6E52640", VA = "0x186E53240")]
	private void NONJEKEBPFL(int MAGACBBIHAN, int FCKIEPPFJFA, MEMHHIFIDAB ONPOPNDPDKI, float3 JMOAHJJIPDJ, float3x3 NDIDLOHFNJO, bool AICEDJPOHBL, float BJGGPAGHNPO, int CAAOPCEOAHF, int INPPFEOFMMP, int IOJBMKMPFKB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct LKFGHDMELOC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<ECEIKPEAFAB> KHADBAEAOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<MDDMDCBCANL> EBLGCKNHECN;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E69170", Offset = "0x6E68570", VA = "0x186E69170")]
	public LKFGHDMELOC(int MFKKELONDCC, Allocator MGFIHPDNFPH = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6E690D0", Offset = "0x6E684D0", VA = "0x186E690D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct HFNDECNDJBP : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum JDHKLKFECBG
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
	private NativeList<float3> EDOGHHCBEBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> AFOLNFGILPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> EODPICMDCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> MFLBDIPFJCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> OGNHGGDHOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> LPAMNDJJGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> KEEKCPEIPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> FPBLBODGGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<MDDMDCBCANL> LGCDODHEOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<ECEIKPEAFAB> KHADBAEAOBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<MDDMDCBCANL> EBLGCKNHECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int FMNAIJPFNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int JOFFANFDFDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PKLFBBALAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> OCICDFBJCEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DKBLNDJINLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HKKBPLKBFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MPJNMJEFFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BEDMNBODGCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 DJKNCGFJJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion LNBDAMKAFKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 LONLLKBDFMI;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FBA0", Offset = "0x6E5EFA0", VA = "0x186E5FBA0")]
	public HFNDECNDJBP(IGMDHOIMGAD GAPMGEJJLAP, JHEIAOJDPDC CCFOBKCAPBC, float3 KEPGMBLKCJP, quaternion DMNDCBJONGM, float OFGKLDPPEFK, int KHCLHLMMJDM = 0, int PIKFGNGGDBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FD90", Offset = "0x6E5F190", VA = "0x186E5FD90")]
	public HFNDECNDJBP(LKFGHDMELOC MPMEGOKIEPF, JHEIAOJDPDC CCFOBKCAPBC, float3 KEPGMBLKCJP, quaternion DMNDCBJONGM, float3 OFGKLDPPEFK, int KHCLHLMMJDM = 0, int PIKFGNGGDBG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E860", Offset = "0x6E5DC60", VA = "0x186E5E860", Slot = "4")]
	public void Execute(int HOEIKPCADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F7A0", Offset = "0x6E5EBA0", VA = "0x186E5F7A0")]
	private void IEEAKIGGOPH(float4x4 NNMPNJNEAKE, int HOEIKPCADHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E7F0", Offset = "0x6E5DBF0", VA = "0x186E5E7F0")]
	private JDHKLKFECBG AIAKAHLOMEE(float3 JNKEFPKOLCG)
	{
		return default(JDHKLKFECBG);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E5FB50", Offset = "0x6E5EF50", VA = "0x186E5FB50")]
	private float4 MCHIBEGEAML(JDHKLKFECBG HOADLKPPEMG, int AEAHMAMPNLO)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E5F760", Offset = "0x6E5EB60", VA = "0x186E5F760")]
	private float2 GLGLPEDFIGP(JDHKLKFECBG HOADLKPPEMG, float3 MBJNFCDOKCE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct NOLMEEDJECJ
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum KAFACJABBFJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static NOLMEEDJECJ NHLFLGLAPGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 KHBHMHPABCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 MFIGJIBFNPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 NDEEOPEAONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public KAFACJABBFJ MKIIDBFDPBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 PEKPAEJBKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 HDGJIJEMMHI;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool OOLCMFGMABL
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E83F70", Offset = "0x6E83370", VA = "0x186E83F70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 OIBFFBMBJGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E844B0", Offset = "0x6E838B0", VA = "0x186E844B0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E847F0", Offset = "0x6E83BF0", VA = "0x186E847F0")]
	public NOLMEEDJECJ(float3 MBJNFCDOKCE, quaternion EFFHGIJAIIE, float3 MFKKELONDCC, KAFACJABBFJ LGJDMOCCBDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E84590", Offset = "0x6E83990", VA = "0x186E84590")]
	public float LNLGOBOHLPJ(float3 JMOAHJJIPDJ, float JJNGAOPCPFO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E84210", Offset = "0x6E83610", VA = "0x186E84210")]
	public bool HBEEHFCACML(float3 JNKEFPKOLCG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E84300", Offset = "0x6E83700", VA = "0x186E84300")]
	public void KDHOJGHGANP(float3 OPLCFCBPFAE, float3x3 AEMIPHGJCEM, float BOMOBGMOBPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E83E80", Offset = "0x6E83280", VA = "0x186E83E80")]
	private void BLDIKNCMKCL(float3 HDGFJIGDDLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E83F80", Offset = "0x6E83380", VA = "0x186E83F80")]
	public void DOPPFOLAGCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct IKJIHEFAFFC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<NOLMEEDJECJ> MPMEGOKIEPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> NAIFNFGFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> FPDKGNJGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> DKOKJDDONLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<MDDMDCBCANL> EBLGCKNHECN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int KHOINKNCMBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int PMBKMFFCGHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float JJNGAOPCPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float NLBKCPDOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> AGMDJHEHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> LPPJBPGAEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> EDLJJAHNKDN;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E78310", Offset = "0x6E77710", VA = "0x186E78310")]
	public IKJIHEFAFFC(JHEIAOJDPDC JIPKNCLPFGJ, float APCICELMCJB, int IHLILPEDKCL, int DCEHMIPCKJH, NativeList<NOLMEEDJECJ> MPMEGOKIEPF, NativeArray<int> DKOKJDDONLG, NativeList<MDDMDCBCANL> EBLGCKNHECN, AJMMIHNBKJG ONIPMGKKBCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E77B10", Offset = "0x6E76F10", VA = "0x186E77B10", Slot = "4")]
	public void Execute(int JFFGEFENIFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E78250", Offset = "0x6E77650", VA = "0x186E78250")]
	private bool JMOFDKIACDE(NOLMEEDJECJ NOPDIJFELMF, NOLMEEDJECJ PMGMHFIMGOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E77880", Offset = "0x6E76C80", VA = "0x186E77880")]
	private bool AHMOGJCHMDC(NOLMEEDJECJ BIDCODMHODA, int LHKPJGHMDDN, int FJCHBPIGGBJ, int HAEEDCMNINH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class AJMMIHNBKJG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> MJPCOEFNHHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> MAEGLKDOFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> BKDNJEFACCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> ICMGODBACGD;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C590", Offset = "0x6E6B990", VA = "0x186E6C590")]
	public void ANPNPPGAEBN(int EFLJOEAENFI, int IHOGEOAGCLG, Allocator MGFIHPDNFPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C6B0", Offset = "0x6E6BAB0", VA = "0x186E6C6B0")]
	public static long BDKELLPDFDM(int EFLJOEAENFI, int IHOGEOAGCLG)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C6D0", Offset = "0x6E6BAD0", VA = "0x186E6C6D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C7C0", Offset = "0x6E6BBC0", VA = "0x186E6C7C0")]
	public void KMANLEPJEHF(JobHandle LGCKIPFOBAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public AJMMIHNBKJG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct DFDADHAGNOP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> NAIFNFGFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> GNELJAACCHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> AAILBGHDKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> AGJLIMCEKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> FPDKGNJGAIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> PFPBCCHMFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> IFMBFKJPLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> AGMDJHEHIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> LPPJBPGAEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int KHCLHLMMJDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int PIKFGNGGDBG;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E72C40", Offset = "0x6E72040", VA = "0x186E72C40")]
	public DFDADHAGNOP(JHEIAOJDPDC JIPKNCLPFGJ, AJMMIHNBKJG ONIPMGKKBCJ, int PIKFGNGGDBG = 0, int KHCLHLMMJDM = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E72800", Offset = "0x6E71C00", VA = "0x186E72800", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E72BE0", Offset = "0x6E71FE0", VA = "0x186E72BE0")]
	private void IPJPOMAANPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class BNDNJMGDKCL
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0D00", Offset = "0x2BF0100", VA = "0x182BF0D00")]
	public static bool LLGMPIKDEEJ<T>(NativeArray<T> AFBDFGIDJPF, int MFKKELONDCC, Allocator MGFIHPDNFPH, NativeArrayOptions AHOANCKGKEN = NativeArrayOptions.ClearMemory, int JMIJDGLDCKG = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2BF0E80", Offset = "0x2BF0280", VA = "0x182BF0E80")]
	public static bool LLGMPIKDEEJ<T>(NativeList<T> HGMKHDHJCFJ, int MFKKELONDCC, Allocator MGFIHPDNFPH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum HOEGHAPJAGH
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
public interface OFBHAEBDFJC
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int MBFIPOJCFMC(HOEGHAPJAGH KFELJFNOKBH);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int OHDBIHJBDOO(HOEGHAPJAGH KFELJFNOKBH);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds APEDAPPHIEK();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float OPCPKLLHPLM();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPPKBJBKJNK(HOEGHAPJAGH KFELJFNOKBH, IGMDHOIMGAD NFMPKGPMOHC, int BICFOPHJEGF = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class HDABIFAANLB
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E77730", Offset = "0x6E76B30", VA = "0x186E77730")]
	public static void IMGLILPEJIB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class GLNJNDHBHFA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> LLMKFLNHOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> POJOLGFGADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> LJJFCKNFJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> ELDDKOBKDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> JONACNNEPPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> KNOGIBNDKEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> BMAHDMOPKOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> FIJADABDIKJ;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E75770", Offset = "0x6E74B70", VA = "0x186E75770")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int PKCENLFOFAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E75730", Offset = "0x6E74B30", VA = "0x186E75730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int OAPCAPDKIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6E764B0", Offset = "0x6E758B0", VA = "0x186E764B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E764F0", Offset = "0x6E758F0", VA = "0x186E764F0")]
	public GLNJNDHBHFA(int EFLJOEAENFI, int IHOGEOAGCLG, int CLCBDGFCCPH, Allocator MGFIHPDNFPH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E767C0", Offset = "0x6E75BC0", VA = "0x186E767C0")]
	public GLNJNDHBHFA(Mesh JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E75620", Offset = "0x6E74A20", VA = "0x186E75620", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E757B0", Offset = "0x6E74BB0", VA = "0x186E757B0")]
	public void GIEFCFNIIEO(GLNJNDHBHFA JIPKNCLPFGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E75AB0", Offset = "0x6E74EB0", VA = "0x186E75AB0")]
	private void LFCLICBILEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E75F40", Offset = "0x6E75340", VA = "0x186E75F40")]
	private void MILAIFNIENL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct MDDMDCBCANL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int DDPNBMCNPKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int CDMPNIIABON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int INCNCBFJJAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int PKCENLFOFAJ;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x18B1E20", Offset = "0x18B1220", VA = "0x1818B1E20")]
	public MDDMDCBCANL(int DCEHMIPCKJH, int FOKPONIAEFG, int IHLILPEDKCL, int DBMNEEKDOAB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KBGPMHOBMPJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<MDDMDCBCANL> ICDEEKPPKGM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xACF380", Offset = "0xACE780", VA = "0x180ACF380")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<MDDMDCBCANL>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xACF2A0", Offset = "0xACE6A0", VA = "0x180ACF2A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public GLNJNDHBHFA ADBEBIMNGOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E833E0", Offset = "0x6E827E0", VA = "0x186E833E0")]
	public KBGPMHOBMPJ(IEnumerable<GLNJNDHBHFA> HIHJMBIFPKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E83370", Offset = "0x6E82770", VA = "0x186E83370", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum LMGKIBLKANC
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class AKPFKGFCJAO
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> HBANAHJANFJ;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> AEBKAJJPLBE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> EGMJMHEOGJP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> MOMHDFHLGKH;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C9B0", Offset = "0x6E6BDB0", VA = "0x186E6C9B0")]
	public static void IMGLILPEJIB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CAC0", Offset = "0x6E6BEC0", VA = "0x186E6CAC0")]
	public static NativeArray<float2> OFCKIHMCKDF(NativeArray<float2> LIEPFJAHCDB, int NJDDKBAAIBA, NativeArray<float2> BKFKACADBIB, int AANIFECIAGA)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CCC0", Offset = "0x6E6C0C0", VA = "0x186E6CCC0")]
	public static NativeArray<float3> PLKHGLCNBHB(NativeArray<float3> LIEPFJAHCDB, int NJDDKBAAIBA, NativeArray<float3> BKFKACADBIB, int AANIFECIAGA)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CBC0", Offset = "0x6E6BFC0", VA = "0x186E6CBC0")]
	public static NativeArray<float4> PCCHBFJMEJK(NativeArray<float4> LIEPFJAHCDB, int NJDDKBAAIBA, NativeArray<float4> BKFKACADBIB, int AANIFECIAGA)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C8B0", Offset = "0x6E6BCB0", VA = "0x186E6C8B0")]
	public static NativeArray<int> BICELMFJNDB(NativeArray<int> LIEPFJAHCDB, int NJDDKBAAIBA, NativeArray<int> BKFKACADBIB, int AANIFECIAGA)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3574490", Offset = "0x3573890", VA = "0x183574490")]
	private static void KHPMHKGGDMB<T>(NativeArray<T> AFBDFGIDJPF, int JOLILOHPEPH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x35743B0", Offset = "0x35737B0", VA = "0x1835743B0")]
	private static void DKOABHABGFF<T>(NativeArray<T> LIEPFJAHCDB, int NJDDKBAAIBA, NativeArray<T> BKFKACADBIB, int AANIFECIAGA, NativeArray<T> CHNBKECOOOM) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class GMGAMLELKCD
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct KJOMJGGFAOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort CFANGCOBGCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort HHLCHNICLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort CLBJBMGHOBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort HDLOAEMGDND;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E76AC0", Offset = "0x6E75EC0", VA = "0x186E76AC0")]
	public static uint AKGHCGCIDEG(float EBGIBNKOKFG)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E76CA0", Offset = "0x6E760A0", VA = "0x186E76CA0")]
	public static void EPAAMDFOOGA(float4 AAILBGHDKBJ, float OEEKMHHBLGE, [Out] uint CAABOPBANIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E76DB0", Offset = "0x6E761B0", VA = "0x186E76DB0")]
	public static void EPAAMDFOOGA(float4 AAILBGHDKBJ, uint LHEENMPHIHL, [Out] uint CAABOPBANIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E77460", Offset = "0x6E76860", VA = "0x186E77460")]
	public static void PMEPEPIKMDB(float3 IBOLFOJHNII, float3 DLDIKGGPFBN, float4 FNHDCCIHJIF, float2 JJBOHCPEBCA, float4 AAILBGHDKBJ, [Out] JHEIAOJDPDC.OLAICILOCBA CPOCLOFOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6E77200", Offset = "0x6E76600", VA = "0x186E77200")]
	public static void PMEPEPIKMDB(float3 IBOLFOJHNII, float3 DLDIKGGPFBN, float4 FNHDCCIHJIF, float2 JJBOHCPEBCA, float4 AAILBGHDKBJ, [Out] JHEIAOJDPDC.AGJCGDPCNPJ CPOCLOFOKDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6E77020", Offset = "0x6E76420", VA = "0x186E77020")]
	public static byte MAKGPIBKFMD(float LIHHDPOHLDK)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E76E80", Offset = "0x6E76280", VA = "0x186E76E80")]
	public static ushort HNOBHHODIAN(float LIHHDPOHLDK)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E77070", Offset = "0x6E76470", VA = "0x186E77070")]
	public static uint OMFAGHJIMMH(float LIHHDPOHLDK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E76C20", Offset = "0x6E76020", VA = "0x186E76C20")]
	public static float2 ENGIKHKNMJA(float2 IDIHIILANOF)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E76AD0", Offset = "0x6E75ED0", VA = "0x186E76AD0")]
	public static float2 DJJDHCFNAPE(float3 DNDOEPAKCMB)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E76ED0", Offset = "0x6E762D0", VA = "0x186E76ED0")]
	public static void IEOMAGHFAFM(float3 LIHHDPOHLDK, [Out] float3 CFNJLDMEBMM, [Out] uint3 HDLOAEMGDND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E770A0", Offset = "0x6E764A0", VA = "0x186E770A0")]
	public static KJOMJGGFAOH ONENAFKDEKG(float3 MBJNFCDOKCE)
	{
		return default(KJOMJGGFAOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class BMKAJIDAHGF
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker EBCJCKJGBCA;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float GMMPIAPAEMP;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void GGLDCGNIGDL(bool IGGMIJKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CDC0", Offset = "0x6E6C1C0", VA = "0x186E6CDC0")]
	public static void DDEIOAOMENI(float OCIHHPEBNHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class JDNHJILOBHP
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum AOECKKHCICF
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
	public struct EODHINCOPDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public APAGAKOJBPC JIPKNCLPFGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int ICEFGLNHBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int HOJGNEGAFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long DCEBGJJPAHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long HNNDHHHDDPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float DMLILHEANOL;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6E72D40", Offset = "0x6E72140", VA = "0x186E72D40")]
		public void LHMGAKDCLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6E72CC0", Offset = "0x6E720C0", VA = "0x186E72CC0")]
		public void KMANLEPJEHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string JCGNEJEKBPB;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string HPGHLCLPCEJ;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker EBCJCKJGBCA;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker JNDDDAKPOEJ;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker PFFMJHKFEDK;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker AEKKEJIEBBH;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker LDBLHKKKMLF;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker KHNJGHJPBDI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker GFCOEAPDFOE;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker BPDGBNBLKMJ;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker EIEEEGHINPL;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker GCLBNJNFANH;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker LNNNLAMGIHB;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker FCOEMGCKMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<OFBHAEBDFJC> IGBJMHCINDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly ALFOLKGPCLL ICFLEFMOEKC;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool OFNEIIDDEDP = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int FOKPONIAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int DBMNEEKDOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool FHJNPFJPCKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool DIDBHFIJNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool AKLGHKNOLBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal AOECKKHCICF NOGEMBGGBHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool KFMDLMEHIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 OPEBNNONNDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 GHLBMMPJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float HOCPPEFNBGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float IHALEFJEANK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int GOGPJHFDFDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int DHHLFLCMKII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int AMIPLPDJNCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int OBBLONDOPGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float MNJKDONFJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float ICCKKFIBFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int LNDPOAEECJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long AMBDHMGAFFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long CIDGNAPJGLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long HNINLJHDGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int KLBFGIGEMAF;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int FHKFIJFAEAO = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] NJGKJKCFAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] KIPGLJHDDDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] OMIMMDNEGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<EODHINCOPDM> ILKLPDCDBGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private JHEIAOJDPDC DMJLBKHNOOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long IIBINMAGKHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long CJDOPHLIFND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int CHEAGFMNLMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float LBFKAAOMIGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal JHEIAOJDPDC.ICAHJJLBECK EJCMDBLHCDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool KOMAOBJHACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private FPLFNLFDJEF LFALOLIOMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle CFENPGFEHBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> FJNCFGCKFGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool BMHOLMNFOEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle CGLGBEICJEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private JHEIAOJDPDC EDPAAFCNMKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private AJMMIHNBKJG ACMAGHJGCFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform BDMENMBLEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private HOEGHAPJAGH NCDCPNNJIII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long IJOCKPJKOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long PAFOONDGDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long LOCMFHBEONM;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh ADBEBIMNGOF
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F60", Offset = "0x8A9360", VA = "0x1808A9F60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter ODJGBBDBINN
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer OAEHPNMNNGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B81A0", Offset = "0x8B75A0", VA = "0x1808B81A0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> POJIAOJFPNK
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8A9EF0", Offset = "0x8A92F0", VA = "0x1808A9EF0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int BKFLIFKPJMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x9D8020", Offset = "0x9D7420", VA = "0x1809D8020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int LHIEPOMCACD
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1337120", Offset = "0x1336520", VA = "0x181337120")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int CDMPNIIABON
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E7E610", Offset = "0x6E7DA10", VA = "0x186E7E610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<OFBHAEBDFJC> OBPNKLJHCGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D0E0", Offset = "0x6E7C4E0", VA = "0x186E7D0E0")]
	public void EOLGMGCMOAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E310", Offset = "0x6E7D710", VA = "0x186E7E310")]
	private void FFHLEOLBIGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E83090", Offset = "0x6E82490", VA = "0x186E83090")]
	public JDNHJILOBHP(string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E80650", Offset = "0x6E7FA50", VA = "0x186E80650")]
	public void KMANLEPJEHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E783B0", Offset = "0x6E777B0", VA = "0x186E783B0")]
	private void ABHCMFHJOPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F940", Offset = "0x6E7ED40", VA = "0x186E7F940")]
	private void JHJIDJDHODG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C7D0", Offset = "0x6E7BBD0", VA = "0x186E7C7D0")]
	public Mesh DODEIEALLNJ(MeshFilter PPKLOOIAMIA, Transform ADJOLMKPBJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E79D20", Offset = "0x6E79120", VA = "0x186E79D20")]
	private void DALPHPAACOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E80DD0", Offset = "0x6E801D0", VA = "0x186E80DD0")]
	public void NFAIFEDKEOB(OFBHAEBDFJC BDOLJDDNPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E6D0", Offset = "0x6E7DAD0", VA = "0x186E7E6D0")]
	public bool HDNNPNLNLHO(OFBHAEBDFJC BDOLJDDNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E2B0", Offset = "0x6E7D6B0", VA = "0x186E7E2B0")]
	public bool FCCKHINNPHJ(OFBHAEBDFJC BDOLJDDNPDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E78450", Offset = "0x6E77850", VA = "0x186E78450", Slot = "4")]
	public virtual void ALOILPCPMGH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6E784E0", Offset = "0x6E778E0", VA = "0x186E784E0")]
	public void BJCDAANMOCA(Transform LHMGKIHIEIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E80400", Offset = "0x6E7F800", VA = "0x186E80400")]
	private long JNLKODKJLGC()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E82B20", Offset = "0x6E81F20", VA = "0x186E82B20")]
	private long ODLDCMACOBJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E78BF0", Offset = "0x6E77FF0", VA = "0x186E78BF0")]
	public bool CMOIIFOFLMB(Transform LHMGKIHIEIJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E80F30", Offset = "0x6E80330", VA = "0x186E80F30")]
	public bool NIMMEELMLAO(bool NFOOGKJADGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E7C8E0", Offset = "0x6E7BCE0", VA = "0x186E7C8E0")]
	private void EECMIFOHKBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E79FB0", Offset = "0x6E793B0", VA = "0x186E79FB0")]
	public bool DDEIOAOMENI(float4x4 GPIAIHBJNID, BatchedMeshRenderer BBELENNNKND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D420", Offset = "0x6E7C820", VA = "0x186E7D420")]
	public void EPMCPIFDBJN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D0F0", Offset = "0x6E7C4F0", VA = "0x186E7D0F0")]
	public bool EOOLMIGGODF(bool NFOOGKJADGI = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E80780", Offset = "0x6E7FB80", VA = "0x186E80780")]
	public void MDBGNHJMMFJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E82C80", Offset = "0x6E82080", VA = "0x186E82C80")]
	public void PDFDEFJDFHB(JHEIAOJDPDC JIPKNCLPFGJ, int JLJKNOPMMPI, int CHFACHHFIJD, float NBOLKKOCKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E80790", Offset = "0x6E7FB90", VA = "0x186E80790")]
	public void MJFHOENMPFJ(APAGAKOJBPC DFEBEOBBIME, int JLJKNOPMMPI, int CHFACHHFIJD, float NBOLKKOCKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E805E0", Offset = "0x6E7F9E0", VA = "0x186E805E0")]
	public (long, long, long) KCINKEJLBDO()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x9EA8E0", Offset = "0x9E9CE0", VA = "0x1809EA8E0")]
	public long BPOAALNKFIO()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E7D600", Offset = "0x6E7CA00", VA = "0x186E7D600")]
	private void FABFMMJDFDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E80A40", Offset = "0x6E7FE40", VA = "0x186E80A40")]
	public (long, long) NDFKJFIHHPJ(float CFGNKBAGCEH, float4x4 GPIAIHBJNID)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public void JPCIALLJEIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E804C0", Offset = "0x6E7F8C0", VA = "0x186E804C0")]
	internal void JNMEKEPMOLE(AOECKKHCICF BNOBGOMONKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E7DA00", Offset = "0x6E7CE00", VA = "0x186E7DA00")]
	private (float, float, float, float) FBAGFIALDJL(float OEDHDMFMLGF, float4x4 GPIAIHBJNID)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6E78720", Offset = "0x6E77B20", VA = "0x186E78720")]
	private float CAPDFLBMPEI(float OEDHDMFMLGF, float4x4 GPIAIHBJNID)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E750", Offset = "0x6E7DB50", VA = "0x186E7E750")]
	private (int, int) IBHBFAGGBOE(float HBHIFPMFIAM)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E7B760", Offset = "0x6E7AB60", VA = "0x186E7B760")]
	public void DINKNAPHEGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F5D0", Offset = "0x6E7E9D0", VA = "0x186E7F5D0")]
	private void JCBMHDDGKBM(JHEIAOJDPDC MIHKIBMDBFH, JHEIAOJDPDC.ICAHJJLBECK LDFCHBCLACD, bool CHKEGFPBJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F4D0", Offset = "0x6E7E8D0", VA = "0x186E7F4D0")]
	private void JCBMHDDGKBM([In] APAGAKOJBPC MIHKIBMDBFH, JHEIAOJDPDC.ICAHJJLBECK LDFCHBCLACD, bool CHKEGFPBJIP = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6E7E630", Offset = "0x6E7DA30", VA = "0x186E7E630")]
	private void HCBAACEIMJK(JHEIAOJDPDC.ICAHJJLBECK LDFCHBCLACD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6E7B730", Offset = "0x6E7AB30", VA = "0x186E7B730")]
	private void DGFIHGEJMAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F620", Offset = "0x6E7EA20", VA = "0x186E7F620")]
	private void JEOFMIIFELC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6E7EA90", Offset = "0x6E7DE90", VA = "0x186E7EA90")]
	public long ILIGIGKPHPH(long DJBDEICNBEL, int PCJNJOBJKJH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6E81E00", Offset = "0x6E81200", VA = "0x186E81E00")]
	private void NLFHINILCJG(JHEIAOJDPDC LHMINLKELMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6E78780", Offset = "0x6E77B80", VA = "0x186E78780")]
	private void CEDCNIGAGOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F440", Offset = "0x6E7E840", VA = "0x186E7F440")]
	private float INFNJJOHAOE(int MAJILDNHLPK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E7FA20", Offset = "0x6E7EE20", VA = "0x186E7FA20")]
	private void JIONDEPNJDA(JHEIAOJDPDC JIPKNCLPFGJ, OJCELEIOPMP DFEBEOBBIME, int JLJKNOPMMPI, int CHFACHHFIJD, float NBOLKKOCKIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct FPLFNLFDJEF : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct MCBJDKABIAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int CPMNALMHMKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int OGPHPFOGIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int FKKOEGDMHPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int FGHGKHMDFBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int MMOHJOMJPFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int DKJHKMNBOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int ICEFGLNHBLP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int HOJGNEGAFPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float DMLILHEANOL;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct AHODGEILLGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public KCBIAKAIJGH.MNPJMDKJBCM HEGHMGEMKJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float OICDDMNACOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float MCBCAEKGCMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float JKKPFIPAMHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float OLLAMJFJOAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float ODEHJIJLMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float MIPLFHOGHID;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct NFOHOEGKPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> LLMKFLNHOIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> POJOLGFGADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> IAGMCOAKCCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> EKHLBGKEDDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> KOBOIFIKHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> FIJADABDIKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool COPGEAPBBOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int CDMPNIIABON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int PKCENLFOFAJ;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6E83990", Offset = "0x6E82D90", VA = "0x186E83990")]
		public void ANPNPPGAEBN(int EFLJOEAENFI, int IHOGEOAGCLG, Allocator MGFIHPDNFPH, bool HBPKNMMKIBA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6E83C30", Offset = "0x6E83030", VA = "0x186E83C30")]
		public static NFOHOEGKPAH MMAAMBLELOM(JHEIAOJDPDC CAAJFPBAGHE)
		{
			return default(NFOHOEGKPAH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6E83B70", Offset = "0x6E82F70", VA = "0x186E83B70")]
		public void KMANLEPJEHF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker LPLHGDAOCOE;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker ONPIKEBEIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<MCBJDKABIAF> FJCGHNAIGAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private NFOHOEGKPAH ENDBMECJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private NFOHOEGKPAH LHMINLKELMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 IMHGBNDJICA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 PLCAPHBDEFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private AHODGEILLGP HNAAIGAHLJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* KDJFPHEAMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> JFLDNONFAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> LPPJBPGAEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> IJBDNGDMLHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> POFPKFAKACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> ENHOAAGEINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> LGPCIOGHHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> DCFJDJOPFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> IKPEPCNOEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> PLIHLJLKGAF;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6E74DC0", Offset = "0x6E741C0", VA = "0x186E74DC0")]
	public FPLFNLFDJEF([In] List<JDNHJILOBHP.EODHINCOPDM> ICKLBDHGDLH, [In] JHEIAOJDPDC AAMEBCLOABN, [In] JDNHJILOBHP HOAGBOPKHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6E730B0", Offset = "0x6E724B0", VA = "0x186E730B0", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E73100", Offset = "0x6E72500", VA = "0x186E73100")]
	public void IOHEJELBONI(List<JDNHJILOBHP.EODHINCOPDM> LKCBALJCMMK, [In] JDNHJILOBHP HOAGBOPKHIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E73090", Offset = "0x6E72490", VA = "0x186E73090")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool CGLDOPHCCMF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6E73A60", Offset = "0x6E72E60", VA = "0x186E73A60")]
	private APAGAKOJBPC JJEIOPJMHKF(int MHEJANIFOGN, Allocator MGFIHPDNFPH)
	{
		return default(APAGAKOJBPC);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E73D90", Offset = "0x6E73190", VA = "0x186E73D90")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void KFBCEKONDMG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6E72D70", Offset = "0x6E72170", VA = "0x186E72D70")]
	[IgnoreWarning(1371)]
	private MCBJDKABIAF BLDLMPLGKOI([In] MCBJDKABIAF BJHJNJDCHML, int CEBNMDJPFKK, [In] NativeArray<int> FPDKGNJGAIL, [In] NativeArray<bool> LPPJBPGAEJL, NativeArray<int> IJBDNGDMLHJ)
	{
		return default(MCBJDKABIAF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6E73C90", Offset = "0x6E73090", VA = "0x186E73C90")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int JKDCFFCEGBC(NativeArray<int> FPDKGNJGAIL, int LFCNHLNDFBL, int NHOIHHBOJBM, int FMLEAKFKLBK)
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
		public static readonly EGGMDNJPOBA log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker DEIAAKPHPNA;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker MABPPLGJBIG;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker DHGHCINKFOJ;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker HKCPINJCBEB;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker GIDKJMFHLFC;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker LDBLHKKKMLF;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker ODAPEKJKEIB;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int PBFPCENKJAE = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> NHBOILHKIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<JDNHJILOBHP>> AHBMDIJIEDI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<JDNHJILOBHP> CKMKFECHLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> GCJJLMKEMAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform ANEOIPMCDGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool FOHGHFENHFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool ELDAMDBHEBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int ONABBMIHMLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private JDNHJILOBHP IJHPPPPMJED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material DLIHJHFAEBB;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const int JBBJOCAICLB = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static List<(long, Bounds, OFBHAEBDFJC)> FAFBALICFOC;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> IHPLFDDIDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int KOPJOMCGKCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6E727B0", Offset = "0x6E71BB0", VA = "0x186E727B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		private static void GHBIDAOOCPD(bool IGGMIJKNBKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		private static void GHBIDAOOCPD(bool IGGMIJKNBKH, string ADPAIBGIHMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F480", Offset = "0x6E6E880", VA = "0x186E6F480")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D370", Offset = "0x6E6C770", VA = "0x186E6D370")]
		public JDNHJILOBHP AddToBatchedMesh(OFBHAEBDFJC HJDHNHFCHFC, Material LBOPCEJDNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6E72210", Offset = "0x6E71610", VA = "0x186E72210")]
		public void RemoveFromBatchedMesh(OFBHAEBDFJC JIPKNCLPFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D470", Offset = "0x6E6C870", VA = "0x186E6D470")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6ED40", Offset = "0x6E6E140", VA = "0x186E6ED40")]
		private void MOCDNJIHLMF(Renderer OEGINKHKPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D850", Offset = "0x6E6CC50", VA = "0x186E6D850")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D840", Offset = "0x6E6CC40", VA = "0x186E6D840")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D8F0", Offset = "0x6E6CCF0", VA = "0x186E6D8F0")]
		private void GCEANCIBJFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EF50", Offset = "0x6E6E350", VA = "0x186E6EF50")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6E6D5A0", Offset = "0x6E6C9A0", VA = "0x186E6D5A0")]
		private JDNHJILOBHP DOAJOKMFLHC(OFBHAEBDFJC JIPKNCLPFGJ, Material LBOPCEJDNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F6E0", Offset = "0x6E6EAE0", VA = "0x186E6F6E0")]
		private JDNHJILOBHP POMFBHADAGM(Material LBOPCEJDNFN, int MABAHPHHIEA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E670", Offset = "0x6E6DA70", VA = "0x186E6E670")]
		private JDNHJILOBHP KOAIMBNKCCN(Material LBOPCEJDNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6E6DEE0", Offset = "0x6E6D2E0", VA = "0x186E6DEE0")]
		private float4x4 GNPAJLPOJCP()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6E6E550", Offset = "0x6E6D950", VA = "0x186E6E550")]
		private List<Material> HMCOPFKOGGC(Material LBOPCEJDNFN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xD0DDB0", Offset = "0xD0D1B0", VA = "0x180D0DDB0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EDC0", Offset = "0x6E6E1C0", VA = "0x186E6EDC0")]
		public void MarkDirty(OFBHAEBDFJC JIPKNCLPFGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F0C0", Offset = "0x6E6E4C0", VA = "0x186E6F0C0")]
		public (long, long) MemorySizeInBytesForChosenDetail(float CFGNKBAGCEH)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6E70F80", Offset = "0x6E70380", VA = "0x186E70F80")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6E6DFE0", Offset = "0x6E6D3E0", VA = "0x186E6DFE0")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6E6FA50", Offset = "0x6E6EE50", VA = "0x186E6FA50")]
		public void RebatchOptimally(int GAHAGAJNODN, int JMKJGPDPOFP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6E72680", Offset = "0x6E71A80", VA = "0x186E72680")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class LPPCAJMFBNJ
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct GMCIHEFGLMA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float EKKNGGKNJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public BatchedMeshRenderer ACELLKEAOAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public JDNHJILOBHP NFGDAOLIMAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public long BNKEFOEIPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float CNDJCMGJCKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public bool LFNCHECFDHD;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class DLPJPOLAOLE : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xC21260", Offset = "0xC20660", VA = "0x180C21260", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E85920", Offset = "0x6E84D20", VA = "0x186E85920", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xD77C80", Offset = "0xD77080", VA = "0x180D77C80")]
		[DebuggerHidden]
		public DLPJPOLAOLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E85970", Offset = "0x6E84D70", VA = "0x186E85970", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E84B60", Offset = "0x6E83F60", VA = "0x186E84B60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E857D0", Offset = "0x6E84BD0", VA = "0x186E857D0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E84B10", Offset = "0x6E83F10", VA = "0x186E84B10")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E858D0", Offset = "0x6E84CD0", VA = "0x186E858D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E85820", Offset = "0x6E84C20", VA = "0x186E85820", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E85820", Offset = "0x6E84C20", VA = "0x186E85820", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker LDBLHKKKMLF;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker LDHGPMDAENE;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker BAJLMKDNEGB;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker GBOBHNKHPGC;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static float3 JOIHHMCOMLL;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static int MMDENCHFLEP;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static int IFGJABMJOLE;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static int PNDHLBDGEHN;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int FCHANDEAKAC;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int NNLHFDOGKNG;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int LJCIOJFDIME;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static long ABCKCBJAHON;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static long LBIEHNKOMPO;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int LMBGDLOBHFA;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static int DPJGANFADKM;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int DINACDJJFFB;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static float KKOBBEGNGFK;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static bool HGMDPFBGAKI;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int FMEFDDGJEMK;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float COOFDMHBLJN;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static float ALLNJBGGGJE;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static float HEOBOKHOHDE;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float NLNDJCGEICG;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float BCLDLMJENHJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float AJPGEHOPOBD;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float CBHHCCKBNMI;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float OGIOEBPFLBJ;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static long BGPPEPJDCNF;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static bool KFAPOEPDLCF;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static List<BatchedMeshRenderer> NGNAOHPMELG;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static List<GMCIHEFGLMA> BJOPOPKAPIL;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static Stack<JHEIAOJDPDC> MHGMDMFHMHE;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static Stack<AJMMIHNBKJG> NKJJGDMMAAD;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool CGNHBPLDJDI
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E86450", Offset = "0x6E85850", VA = "0x186E86450")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void GHBIDAOOCPD(bool IGGMIJKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void GGLDCGNIGDL(bool IGGMIJKNBKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	private static void GHBIDAOOCPD(bool IGGMIJKNBKH, string ADPAIBGIHMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public static void LHMGAKDCLGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E85F70", Offset = "0x6E85370", VA = "0x186E85F70")]
	public static void BABKGBKODGI(BatchedMeshRenderer HNNGONNOLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E85BC0", Offset = "0x6E84FC0", VA = "0x186E85BC0")]
	public static void AJIHPEANNKI(BatchedMeshRenderer HNNGONNOLOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E89E90", Offset = "0x6E89290", VA = "0x186E89E90")]
	private static (long, long, long) NCIGBFCMPGF(long JENDGJIOAJK)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A170", Offset = "0x6E89570", VA = "0x186E8A170")]
	public static bool OAPALDIILBC(float DPPJMHAAEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E89C70", Offset = "0x6E89070", VA = "0x186E89C70")]
	public static void KJDBBFHBNJP(float DPPJMHAAEIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E89020", Offset = "0x6E88420", VA = "0x186E89020")]
	public static bool DGPJKJFHCNI(float DPPJMHAAEIL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E864E0", Offset = "0x6E858E0", VA = "0x186E864E0")]
	public static void DDEIOAOMENI(long JENDGJIOAJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E89790", Offset = "0x6E88B90", VA = "0x186E89790")]
	public static long ILIGIGKPHPH(long DJBDEICNBEL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E89130", Offset = "0x6E88530", VA = "0x186E89130")]
	public static void GDHNAAOIICI(JDNHJILOBHP NFGDAOLIMAL, BatchedMeshRenderer ACELLKEAOAL, long BNKEFOEIPIA, float EKKNGGKNJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E88D30", Offset = "0x6E88130", VA = "0x186E88D30")]
	public static void DDGOPHNEJPP(JDNHJILOBHP NFGDAOLIMAL, BatchedMeshRenderer ACELLKEAOAL, long BNKEFOEIPIA, float OCIHHPEBNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E85A90", Offset = "0x6E84E90", VA = "0x186E85A90")]
	public static void AEGHAFJDMMB(JDNHJILOBHP NFGDAOLIMAL, BatchedMeshRenderer ACELLKEAOAL, long BNKEFOEIPIA, float OCIHHPEBNHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E860D0", Offset = "0x6E854D0", VA = "0x186E860D0")]
	public static void BAMNNHOCPEN(JDNHJILOBHP NFGDAOLIMAL, BatchedMeshRenderer ACELLKEAOAL, long BNKEFOEIPIA, float LPDHFJDFMEP, bool LFNCHECFDHD, float EKKNGGKNJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E89270", Offset = "0x6E88670", VA = "0x186E89270")]
	public static float GMCHMOMPLGM(long MBJIPILEGLB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E89FA0", Offset = "0x6E893A0", VA = "0x186E89FA0")]
	public static (long, long) NDFKJFIHHPJ(float CFGNKBAGCEH)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E89E00", Offset = "0x6E89200", VA = "0x186E89E00")]
	[IteratorStateMachine(typeof(DLPJPOLAOLE))]
	public static IEnumerable<bool> MGCILIMPFJK(long DOMPEBFIBDF, bool MFOJKFEGPIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E88E60", Offset = "0x6E88260", VA = "0x186E88E60")]
	public static void DFCBDNCAOCK(long DOMPEBFIBDF, bool MFOJKFEGPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E89650", Offset = "0x6E88A50", VA = "0x186E89650")]
	public static int HFGFKLKCHNI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E86300", Offset = "0x6E85700", VA = "0x186E86300")]
	internal static JHEIAOJDPDC BBHAMJKKKCM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E89D70", Offset = "0x6E89170", VA = "0x186E89D70")]
	internal static void LPMBBJHOJEL(JHEIAOJDPDC MHIMCACEIPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E89B20", Offset = "0x6E88F20", VA = "0x186E89B20")]
	internal static AJMMIHNBKJG JCAHFIEEOAD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E89CE0", Offset = "0x6E890E0", VA = "0x186E89CE0")]
	internal static void LPMBBJHOJEL(AJMMIHNBKJG ONIPMGKKBCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class HPGEKDOFCMJ<KeyType> : JDNHJILOBHP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Dictionary<KeyType, OFBHAEBDFJC> ECIDGEMMGIN;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x40C0F30", Offset = "0x40C0330", VA = "0x1840C0F30")]
	public HPGEKDOFCMJ(string ADANIHOIEKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x40C0DC0", Offset = "0x40C01C0", VA = "0x1840C0DC0")]
	public void NFAIFEDKEOB(KeyType GMJINMLEEAC, OFBHAEBDFJC BDOLJDDNPDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x40C0BC0", Offset = "0x40BFFC0", VA = "0x1840C0BC0")]
	public bool DPHPFOOGIFL(KeyType GMJINMLEEAC, OFBHAEBDFJC OLMECILBNJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x40C0AE0", Offset = "0x40BFEE0", VA = "0x1840C0AE0")]
	public void BKIMMNBBNDK(KeyType GMJINMLEEAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x40C09A0", Offset = "0x40BFDA0", VA = "0x1840C09A0", Slot = "4")]
	public override void ALOILPCPMGH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E8A6D0", Offset = "0x6E89AD0", VA = "0x186E8A6D0")]
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
