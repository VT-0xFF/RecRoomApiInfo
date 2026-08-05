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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
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
	public class LogRegistrationIndex : HLBHPGBFEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6E519C0", Offset = "0x6E50DC0", VA = "0x186E519C0", Slot = "4")]
		public override void MHJHNBDIMHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D39D0", Offset = "0x8D2DD0", VA = "0x1808D39D0")]
		public LogRegistrationIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
internal static class NJPEKLODDMO
{
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FLILHMOBPPM EJMGICPONHI;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public static readonly FLILHMOBPPM JJEFLKCEPEK;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public static readonly FLILHMOBPPM EEDKJIMNMAD;
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public class OAGAEDLKIOE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public MCKOEJIOMLF CGPMIHKPHGA;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DIKHPMLIBDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A81A0", Offset = "0x8A75A0", VA = "0x1808A81A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public OAGAEDLKIOE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct MCKOEJIOMLF
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public struct MFFMPKPNCBK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public half DGBCEOLLAPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public ushort EIGIHCOCDAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public byte GBGGEKLFKBA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static readonly ProfilerMarker MEPDKALLKJI;

	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private static readonly ProfilerMarker KPOKLEKDHJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int DIKHPMLIBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public int FDJNCEIGIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public NativeArray<ushort> COIFJNIKDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public NativeArray<ushort> FIKIFPNLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NativeArray<ushort> EMINGACIBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public NativeArray<ushort> KPOAACHGKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public NativeArray<MFFMPKPNCBK> NOJOGFBGKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public NativeArray<byte> JEDJGNFDCGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeArray<byte> FJHCOGHKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public float3 HBCMHOLICEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public float3 MNMFIJLLOOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public float2 DJNLBCCKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public float2 MFEHENGDBCD;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public static long HNBEIPPELKD;

	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public static long ICJLJNMECNK;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public static float GAIOMLKPJBJ;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private static bool HGMNMFEMEBF;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6E522D0", Offset = "0x6E516D0", VA = "0x186E522D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool LDAIMNIBPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E57BC0", Offset = "0x6E56FC0", VA = "0x186E57BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E52EF0", Offset = "0x6E522F0", VA = "0x186E52EF0")]
	public void BMHCCLKIAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E56460", Offset = "0x6E55860", VA = "0x186E56460")]
	public static MCKOEJIOMLF JMOKCOIDHBC(Allocator HPLNAKONHEI, HOAELOKDIKP DPGBKBJFLMG)
	{
		return default(MCKOEJIOMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E56730", Offset = "0x6E55B30", VA = "0x186E56730")]
	public static MCKOEJIOMLF JMOKCOIDHBC(Allocator HPLNAKONHEI, NativeArray<float3> ODMIHEDGBHI, NativeArray<float3> MBDCCGBDJKG, NativeArray<float2> BPLPEFFAMNH, NativeArray<float4> BGCPGIGDLJN, bool OKADKKOBKLJ, NativeArray<float4> DGAAHLDCOEH, NativeArray<int> OMJHCDLMFBN, int DIKHPMLIBDL, int KOGNPHGNMNF, int FDJNCEIGIHC, int EAHCDOCLKAC)
	{
		return default(MCKOEJIOMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E54E10", Offset = "0x6E54210", VA = "0x186E54E10")]
	public HOAELOKDIKP HFHNBDDAKPF(Allocator HPLNAKONHEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6E55F20", Offset = "0x6E55320", VA = "0x186E55F20")]
	public void JAGLBGCHPDN(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6E53C80", Offset = "0x6E53080", VA = "0x186E53C80")]
	private void FDLGAFNNHMG(Mesh NJMNIJFLOJJ, NativeArray<ushort> HNBDGNELJGI, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A760", Offset = "0x6E59B60", VA = "0x186E5A760")]
	public void OGHBDJPHGKD(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6E59180", Offset = "0x6E58580", VA = "0x186E59180")]
	public void NBFOIJGGFMB(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6E540E0", Offset = "0x6E534E0", VA = "0x186E540E0")]
	public void GDGLEMBNFLF(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6E524D0", Offset = "0x6E518D0", VA = "0x186E524D0")]
	public void BDIFALIGCHB(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6E55580", Offset = "0x6E54980", VA = "0x186E55580")]
	public void IIOELPPICMP(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x6E51BE0", Offset = "0x6E50FE0", VA = "0x186E51BE0")]
	public void ADPMDPHFJKG(Mesh NJMNIJFLOJJ, HOAELOKDIKP.PELOIMAHOHP BIFHNMDIJFJ, bool CAEBHDFIHMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x6E53890", Offset = "0x6E52C90", VA = "0x186E53890")]
	public long DLDJKDIOJNP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E52260", Offset = "0x6E51660", VA = "0x186E52260")]
	public long ALOHPKHNCFH(HOAELOKDIKP.PELOIMAHOHP BIFHNMDIJFJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6E58080", Offset = "0x6E57480", VA = "0x186E58080")]
	private void MBNAHHEGHLM(int HHHNDFDGIGL, int FLNJBODOOEH, Allocator HPLNAKONHEI, bool LDALMOODDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6E52E00", Offset = "0x6E52200", VA = "0x186E52E00")]
	private void BDOIDGGAENG(NativeArray<float3> ELBAFGDCAMB, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6E40330", Offset = "0x6E3F730", VA = "0x186E40330")]
	[BurstCompile]
	private unsafe static void BDOIDGGAENG([NoAlias] float3* ELBAFGDCAMB, [In][NoAlias] ushort* ODMIHEDGBHI, int DIKHPMLIBDL, [In] float3 HBCMHOLICEA, [In] float3 MNMFIJLLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6E55140", Offset = "0x6E54540", VA = "0x186E55140")]
	[BurstCompile]
	private unsafe static void HFKBPPDPMON([NoAlias] HOAELOKDIKP.LGCBLINEOGM* ELBAFGDCAMB, [In][NoAlias] ushort* ODMIHEDGBHI, int DIKHPMLIBDL, [In] float3 HBCMHOLICEA, [In] float3 MNMFIJLLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5B1A0", Offset = "0x6E5A5A0", VA = "0x186E5B1A0")]
	[BurstCompile]
	private unsafe static void PNDOJJNFJMP([NoAlias] HOAELOKDIKP.NGAHNAOAPAH* ELBAFGDCAMB, [In][NoAlias] ushort* ODMIHEDGBHI, int DIKHPMLIBDL, [In] float3 HBCMHOLICEA, [In] float3 MNMFIJLLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6E57190", Offset = "0x6E56590", VA = "0x186E57190")]
	[BurstCompile]
	private unsafe static void NHCAHAHALAO([NoAlias] HOAELOKDIKP.PEPEJFEIGPG* ELBAFGDCAMB, [In][NoAlias] ushort* ODMIHEDGBHI, int DIKHPMLIBDL, [In] float3 HBCMHOLICEA, [In] float3 MNMFIJLLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6E57190", Offset = "0x6E56590", VA = "0x186E57190")]
	[BurstCompile]
	private unsafe static void KLFDHLDCJLM([NoAlias] HOAELOKDIKP.GEEOIDBAGFO* ELBAFGDCAMB, [In][NoAlias] ushort* ODMIHEDGBHI, int DIKHPMLIBDL, [In] float3 HBCMHOLICEA, [In] float3 MNMFIJLLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6E56200", Offset = "0x6E55600", VA = "0x186E56200")]
	[BurstCompile]
	private unsafe static void JLJLEPKHJKF([NoAlias] HOAELOKDIKP.GDGBAOLBLKK* ELBAFGDCAMB, [In][NoAlias] ushort* ODMIHEDGBHI, int DIKHPMLIBDL, [In] float3 HBCMHOLICEA, [In] float3 MNMFIJLLOOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6E532E0", Offset = "0x6E526E0", VA = "0x186E532E0")]
	private void DBCDEGEKFHD(NativeArray<float3> ODMIHEDGBHI, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6E40590", Offset = "0x6E3F990", VA = "0x186E40590")]
	[BurstCompile]
	private unsafe static void DBCDEGEKFHD([NoAlias] ushort* ELBAFGDCAMB, [Out] float3 NLBEHANJEPA, [Out] float3 MNMFIJLLOOD, [In][NoAlias] float3* ODMIHEDGBHI, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6E58A20", Offset = "0x6E57E20", VA = "0x186E58A20")]
	private void MLEHOOJKKPP(NativeArray<float3> MBDCCGBDJKG, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6E58B00", Offset = "0x6E57F00", VA = "0x186E58B00")]
	[BurstCompile]
	private unsafe static void MLEHOOJKKPP([NoAlias] ushort* AGHECFKEFOB, [In][NoAlias] float3* MBDCCGBDJKG, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6E570D0", Offset = "0x6E564D0", VA = "0x186E570D0")]
	private void KGIACEGPEHA(NativeArray<float3> ILOIFDFEGFK, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6E56ED0", Offset = "0x6E562D0", VA = "0x186E56ED0")]
	[BurstCompile]
	private unsafe static void KGIACEGPEHA([NoAlias] float3* ILOIFDFEGFK, [In][NoAlias] ushort* MBDCCGBDJKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6E59E50", Offset = "0x6E59250", VA = "0x186E59E50")]
	[BurstCompile]
	private unsafe static void NMBBICCMFBB([NoAlias] HOAELOKDIKP.LGCBLINEOGM* ELBAFGDCAMB, [In][NoAlias] ushort* MBDCCGBDJKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6E53B40", Offset = "0x6E52F40", VA = "0x186E53B40")]
	[BurstCompile]
	private unsafe static void ENBOHBHMNPC([NoAlias] HOAELOKDIKP.NGAHNAOAPAH* ELBAFGDCAMB, [In][NoAlias] ushort* MBDCCGBDJKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6E59040", Offset = "0x6E58440", VA = "0x186E59040")]
	[BurstCompile]
	private unsafe static void MNGKFMLFACJ([NoAlias] HOAELOKDIKP.PEPEJFEIGPG* ELBAFGDCAMB, [In][NoAlias] ushort* MBDCCGBDJKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A610", Offset = "0x6E59A10", VA = "0x186E5A610")]
	[BurstCompile]
	private unsafe static void OFLAAPHJBNM([NoAlias] HOAELOKDIKP.GEEOIDBAGFO* ELBAFGDCAMB, [In][NoAlias] ushort* MBDCCGBDJKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6E57DE0", Offset = "0x6E571E0", VA = "0x186E57DE0")]
	[BurstCompile]
	private unsafe static void LHJDDDDNHBL([NoAlias] HOAELOKDIKP.GDGBAOLBLKK* ELBAFGDCAMB, [In][NoAlias] ushort* MBDCCGBDJKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6E57AD0", Offset = "0x6E56ED0", VA = "0x186E57AD0")]
	private void LDMMMIALHNB(NativeArray<float2> BPLPEFFAMNH, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x6E57810", Offset = "0x6E56C10", VA = "0x186E57810")]
	[BurstCompile]
	private unsafe static void LDMMMIALHNB([NoAlias] ushort* BOKADEGDEME, [Out] float2 LEPEKFKABML, [Out] float2 MFEHENGDBCD, [In][NoAlias] float2* BPLPEFFAMNH, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6E54B70", Offset = "0x6E53F70", VA = "0x186E54B70")]
	[BurstCompile]
	private static void GPABPKAOHCD([Out] float2 LCDHJPNNGKK, ushort MALPEMOFDFE, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6E54BC0", Offset = "0x6E53FC0", VA = "0x186E54BC0")]
	private void HAJELHJJFAI(NativeArray<float2> BOKADEGDEME, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x6E54D30", Offset = "0x6E54130", VA = "0x186E54D30")]
	[BurstCompile]
	private unsafe static void HAJELHJJFAI([NoAlias] float2* BOKADEGDEME, [NoAlias] ushort* BPLPEFFAMNH, int DIKHPMLIBDL, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6E56360", Offset = "0x6E55760", VA = "0x186E56360")]
	[BurstCompile]
	private unsafe static void JMKKOHANCND([NoAlias] HOAELOKDIKP.LGCBLINEOGM* ELBAFGDCAMB, [NoAlias] ushort* BPLPEFFAMNH, int DIKHPMLIBDL, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A250", Offset = "0x6E59650", VA = "0x186E5A250")]
	[BurstCompile]
	private unsafe static void NPHGAIMIIBA([NoAlias] HOAELOKDIKP.NGAHNAOAPAH* ELBAFGDCAMB, [NoAlias] ushort* BPLPEFFAMNH, int DIKHPMLIBDL, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x6E53950", Offset = "0x6E52D50", VA = "0x186E53950")]
	[BurstCompile]
	private unsafe static void ECGKIAPDBKN([NoAlias] HOAELOKDIKP.PEPEJFEIGPG* ELBAFGDCAMB, [NoAlias] ushort* BPLPEFFAMNH, int DIKHPMLIBDL, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x6E55200", Offset = "0x6E54600", VA = "0x186E55200")]
	[BurstCompile]
	private unsafe static void HHGPMFODPPD([NoAlias] HOAELOKDIKP.GEEOIDBAGFO* ELBAFGDCAMB, [NoAlias] ushort* BPLPEFFAMNH, int DIKHPMLIBDL, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A510", Offset = "0x6E59910", VA = "0x186E5A510")]
	[BurstCompile]
	private unsafe static void OBDECFINIGD([NoAlias] HOAELOKDIKP.GDGBAOLBLKK* ELBAFGDCAMB, [NoAlias] ushort* BPLPEFFAMNH, int DIKHPMLIBDL, [In] float2 DJNLBCCKENN, [In] float2 MFEHENGDBCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6E53010", Offset = "0x6E52410", VA = "0x186E53010")]
	private void BMNPGOAOHJH(NativeArray<float4> DGAAHLDCOEH, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x6E531C0", Offset = "0x6E525C0", VA = "0x186E531C0")]
	[BurstCompile]
	private unsafe static void BMNPGOAOHJH([NoAlias] ushort* GNDADNHFKBI, [In][NoAlias] float4* LIFCHNKJHMI, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6E533D0", Offset = "0x6E527D0", VA = "0x186E533D0")]
	[BurstCompile]
	private static ushort DDJBLKNCLEE([In] float4 KFOHFHGBFOA)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6E58DC0", Offset = "0x6E581C0", VA = "0x186E58DC0")]
	private void MMNGJNEIOIK(NativeArray<float4> GNDADNHFKBI, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6E58EF0", Offset = "0x6E582F0", VA = "0x186E58EF0")]
	[BurstCompile]
	private unsafe static void MMNGJNEIOIK([NoAlias] float4* GNDADNHFKBI, [In][NoAlias] ushort* DGAAHLDCOEH, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6E583F0", Offset = "0x6E577F0", VA = "0x186E583F0")]
	[BurstCompile]
	private unsafe static void MFNNNFEIJPD([NoAlias] HOAELOKDIKP.LGCBLINEOGM* ELBAFGDCAMB, [In][NoAlias] ushort* DGAAHLDCOEH, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A080", Offset = "0x6E59480", VA = "0x186E5A080")]
	[BurstCompile]
	private unsafe static void NNNPOCJKAOC([NoAlias] HOAELOKDIKP.NGAHNAOAPAH* ELBAFGDCAMB, [In][NoAlias] ushort* DGAAHLDCOEH, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E56040", Offset = "0x6E55440", VA = "0x186E56040")]
	[BurstCompile]
	private unsafe static void JGHPGPCAEOB([NoAlias] HOAELOKDIKP.PEPEJFEIGPG* ELBAFGDCAMB, [In][NoAlias] ushort* DGAAHLDCOEH, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E53EB0", Offset = "0x6E532B0", VA = "0x186E53EB0")]
	[BurstCompile]
	private unsafe static void FEOCCEMPPNP([NoAlias] HOAELOKDIKP.GEEOIDBAGFO* ELBAFGDCAMB, [In][NoAlias] ushort* DGAAHLDCOEH, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E59C20", Offset = "0x6E59020", VA = "0x186E59C20")]
	[BurstCompile]
	private unsafe static void NKHNAIBAGGH([NoAlias] HOAELOKDIKP.GDGBAOLBLKK* ELBAFGDCAMB, [In][NoAlias] ushort* DGAAHLDCOEH, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E54AB0", Offset = "0x6E53EB0", VA = "0x186E54AB0")]
	[BurstCompile]
	private static void GEDNGGIPCJG([Out] float4 IPNDOKDOGDG, ushort MALPEMOFDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E57250", Offset = "0x6E56650", VA = "0x186E57250")]
	private void KLLLKFOLNJH(Allocator HPLNAKONHEI, NativeArray<float4> BGCPGIGDLJN, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E57650", Offset = "0x6E56A50", VA = "0x186E57650")]
	[BurstCompile]
	private unsafe static void KLLLKFOLNJH([NoAlias] float4* FGFOHMPNAHC, [NoAlias] byte* JBKMIIAGOIF, [Out] int EDMPBAOLBHJ, [Out] int PDLPEKINGGE, [NoAlias] float4* BGCPGIGDLJN, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E58700", Offset = "0x6E57B00", VA = "0x186E58700")]
	private static void MHHKHDLONLD(NativeArray<float4> NOGFNJOMPAN, NativeArray<MFFMPKPNCBK> EKEGLNNIFMJ, NativeArray<byte> JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E588E0", Offset = "0x6E57CE0", VA = "0x186E588E0")]
	[BurstCompile]
	private unsafe static void MHHKHDLONLD([NoAlias] float4* NOGFNJOMPAN, [In][NoAlias] MFFMPKPNCBK* EKEGLNNIFMJ, [In][NoAlias] byte* JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E56CF0", Offset = "0x6E560F0", VA = "0x186E56CF0")]
	[BurstCompile]
	private unsafe static void JNBGGLEKNOO([NoAlias] HOAELOKDIKP.LGCBLINEOGM* ELBAFGDCAMB, [In][NoAlias] MFFMPKPNCBK* EKEGLNNIFMJ, [In][NoAlias] byte* JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E57C00", Offset = "0x6E57000", VA = "0x186E57C00")]
	[BurstCompile]
	private unsafe static void LGBAKJMLGGG([NoAlias] HOAELOKDIKP.NGAHNAOAPAH* ELBAFGDCAMB, [In][NoAlias] MFFMPKPNCBK* EKEGLNNIFMJ, [In][NoAlias] byte* JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E553A0", Offset = "0x6E547A0", VA = "0x186E553A0")]
	[BurstCompile]
	private unsafe static void IENNFBBFCAH([NoAlias] HOAELOKDIKP.PEPEJFEIGPG* ELBAFGDCAMB, [In][NoAlias] MFFMPKPNCBK* EKEGLNNIFMJ, [In][NoAlias] byte* JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6E5AF60", Offset = "0x6E5A360", VA = "0x186E5AF60")]
	[BurstCompile]
	private unsafe static void PALIFHJDIPA([NoAlias] HOAELOKDIKP.GEEOIDBAGFO* ELBAFGDCAMB, [In][NoAlias] MFFMPKPNCBK* EKEGLNNIFMJ, [In][NoAlias] byte* JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6E581B0", Offset = "0x6E575B0", VA = "0x186E581B0")]
	[BurstCompile]
	private unsafe static void MDNMMDHNJLO([NoAlias] HOAELOKDIKP.GDGBAOLBLKK* ELBAFGDCAMB, [In][NoAlias] MFFMPKPNCBK* EKEGLNNIFMJ, [In][NoAlias] byte* JJMHKJLMDKG, int DIKHPMLIBDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6E52160", Offset = "0x6E51560", VA = "0x186E52160")]
	private void AKENNGBMPGB(Allocator HPLNAKONHEI, NativeArray<int> OMJHCDLMFBN, int EAHCDOCLKAC, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6E53460", Offset = "0x6E52860", VA = "0x186E53460")]
	private static NativeArray<byte> DGNLGOBOEDL(Allocator HPLNAKONHEI, NativeArray<int> OMJHCDLMFBN, int LENJFCMCKGN)
	{
		return default(NativeArray<byte>);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6E53790", Offset = "0x6E52B90", VA = "0x186E53790")]
	[BurstCompile]
	private unsafe static int DGNLGOBOEDL([NoAlias] byte* LIPLPOPJPMB, [In][NoAlias] int* OMJHCDLMFBN, int LENJFCMCKGN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6E52310", Offset = "0x6E51710", VA = "0x186E52310")]
	private static void BBIHHKKINKG(NativeArray<int> CABLFFIAIOA, NativeArray<byte> LGFAFKIJGNN, int FDJNCEIGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6E52430", Offset = "0x6E51830", VA = "0x186E52430")]
	[BurstCompile]
	private unsafe static void BBIHHKKINKG([NoAlias] int* CABLFFIAIOA, [In][NoAlias] byte* LGFAFKIJGNN, int FDJNCEIGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6E55300", Offset = "0x6E54700", VA = "0x186E55300")]
	[BurstCompile]
	private unsafe static void IBOMNPJHLIL([NoAlias] ushort* CABLFFIAIOA, [In][NoAlias] byte* LGFAFKIJGNN, int FDJNCEIGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6E57F40", Offset = "0x6E57340", VA = "0x186E57F40")]
	[BurstCompile]
	private static void LNICLBNFBNO([Out] float3 LCDHJPNNGKK, ushort MALPEMOFDFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6E5A350", Offset = "0x6E59750", VA = "0x186E5A350")]
	[BurstCompile]
	private static ushort NPOKFFKIHJD([In] float3 KFOHFHGBFOA)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[BurstCompile]
public class HOAELOKDIKP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public enum PELOIMAHOHP
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
	public enum OBDIOPMJONL
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
	public struct FIOGMMBEDGN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public PELOIMAHOHP BIFHNMDIJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public bool IBCFMFILONC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public int IOIDNCHGFLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[BurstCompile]
	public struct ENKNMKBFADF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public float3 CLHMEGFDOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public float3 KENGOPLODLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public float4 NEOICEEMOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public float2 NBEPHOOKCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public float4 NOJOGFBGKIP;

		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public static readonly VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[BurstCompile]
	public struct LGCBLINEOGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public float3 CLHMEGFDOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public half4 KENGOPLODLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public half4 NEOICEEMOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public float2 NBEPHOOKCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 NOJOGFBGKIP;

		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public static readonly VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[BurstCompile]
	public struct NGAHNAOAPAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float3 CLHMEGFDOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public uint KENGOPLODLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public uint NEOICEEMOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public float2 NBEPHOOKCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half4 NOJOGFBGKIP;

		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public static readonly VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	[BurstCompile]
	public struct PEPEJFEIGPG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public float3 CLHMEGFDOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public uint KENGOPLODLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public uint NEOICEEMOHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 NBEPHOOKCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half4 NOJOGFBGKIP;

		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public static readonly VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[BurstCompile]
	public struct GEEOIDBAGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float3 CLHMEGFDOKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public uint BGOEMOBEGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float2 NBEPHOOKCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public uint OIOGJJFCFLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public uint GECMBAOCBBN;

		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public static readonly VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[BurstCompile]
	public struct GDGBAOLBLKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public BHEIKFMJBOJ.IIGKACCEONN OJDMCMELNFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public uint BGOEMOBEGGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public float2 NBEPHOOKCCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public uint OIOGJJFCFLJ;

		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public static readonly VertexAttributeDescriptor[] PBNMLAFCLLM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public delegate int FBHPBMIMAGC(float LBEGFJJGJFP);

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal static class JANJBDCLACF
	{
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x400005B")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F030", Offset = "0x6E4E430", VA = "0x186E4F030")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EC80", Offset = "0x6E4E080", VA = "0x186E4EC80")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EBE0", Offset = "0x6E4DFE0", VA = "0x186E4EBE0")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6E4EDD0", Offset = "0x6E4E1D0", VA = "0x186E4EDD0")]
		public static int NCEDFJEFMFN(float LBEGFJJGJFP)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public delegate uint EFMFBLFKFFI([In] float4 IFLBFOHFIEP);

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	internal static class BENJFKGIBOC
	{
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x400005D")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6E41620", Offset = "0x6E40A20", VA = "0x186E41620")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x6E411A0", Offset = "0x6E405A0", VA = "0x186E411A0")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x6E41100", Offset = "0x6E40500", VA = "0x186E41100")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6E412F0", Offset = "0x6E406F0", VA = "0x186E412F0")]
		public static uint NCEDFJEFMFN([In] float4 IFLBFOHFIEP)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public delegate uint LLHFMHABHNA([In] float3 IFLBFOHFIEP);

	[Cpp2IlInjected.Token(Token = "0x2000018")]
	internal static class COAOJBNGPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x400005F")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6E41DA0", Offset = "0x6E411A0", VA = "0x186E41DA0")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6E419E0", Offset = "0x6E40DE0", VA = "0x186E419E0")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x6E41940", Offset = "0x6E40D40", VA = "0x186E41940")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6E41B30", Offset = "0x6E40F30", VA = "0x186E41B30")]
		public static uint NCEDFJEFMFN([In] float3 IFLBFOHFIEP)
		{
			return default(uint);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public unsafe delegate void GOAPDELHMDN([NoAlias] NGAHNAOAPAH* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP);

	[Cpp2IlInjected.Token(Token = "0x200001A")]
	internal static class LGJHHOIILAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6E518A0", Offset = "0x6E50CA0", VA = "0x186E518A0")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6E51520", Offset = "0x6E50920", VA = "0x186E51520")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6E51480", Offset = "0x6E50880", VA = "0x186E51480")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E51670", Offset = "0x6E50A70", VA = "0x186E51670")]
		public unsafe static void NCEDFJEFMFN([NoAlias] NGAHNAOAPAH* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public unsafe delegate void BPPJFPKEBLH([NoAlias] PEPEJFEIGPG* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP);

	[Cpp2IlInjected.Token(Token = "0x200001C")]
	internal static class ECDFFIGECEG
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x4000063")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x6E422E0", Offset = "0x6E416E0", VA = "0x186E422E0")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x6E41F60", Offset = "0x6E41360", VA = "0x186E41F60")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x6E41EC0", Offset = "0x6E412C0", VA = "0x186E41EC0")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x6E420B0", Offset = "0x6E414B0", VA = "0x186E420B0")]
		public unsafe static void NCEDFJEFMFN([NoAlias] PEPEJFEIGPG* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public unsafe delegate void HNLPHHNHKLG([NoAlias] GEEOIDBAGFO* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP);

	[Cpp2IlInjected.Token(Token = "0x200001E")]
	internal static class HBJKINEOHAG
	{
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x4000065")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x6E45400", Offset = "0x6E44800", VA = "0x186E45400")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x6E44ED0", Offset = "0x6E442D0", VA = "0x186E44ED0")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x6E44E30", Offset = "0x6E44230", VA = "0x186E44E30")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x6E45020", Offset = "0x6E44420", VA = "0x186E45020")]
		public unsafe static void NCEDFJEFMFN([NoAlias] GEEOIDBAGFO* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public unsafe delegate void CHCCBABPKKH([NoAlias] GDGBAOLBLKK* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP, [Out] float3 EPOIHEDIBDE, [Out] float3 JKIIJMIHMAC);

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	internal static class JLHEEFKHCIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private static IntPtr JDABNBBFOJL;

		[Cpp2IlInjected.Token(Token = "0x4000067")]
		private static IntPtr NNNLJJJMNGE;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6E4FA20", Offset = "0x6E4EE20", VA = "0x186E4FA20")]
		[BurstDiscard]
		private static void PBLHKMKKOGN(IntPtr P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F380", Offset = "0x6E4E780", VA = "0x186E4F380")]
		private static IntPtr NCBKMEMAKNH()
		{
			return default(IntPtr);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F2E0", Offset = "0x6E4E6E0", VA = "0x186E4F2E0")]
		public static void JCBDBOOMOJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public static void CGCFJDLGJFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6E4F4D0", Offset = "0x6E4E8D0", VA = "0x186E4F4D0")]
		public unsafe static void NCEDFJEFMFN([NoAlias] GDGBAOLBLKK* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP, [Out] float3 EPOIHEDIBDE, [Out] float3 JKIIJMIHMAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public const int HIANLEBCFDG = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeList<float3> AIBOCANIJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<float3> CDFAEEHGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<float4> OFCEPFMKAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<float4> HKKKHCPGEEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<float2> OCHGNCCPOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeList<int> JCINBGMKOGI;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public static readonly VertexAttributeDescriptor[][] INGNBENHOMM;

	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public static bool OJBOPJNJHDJ;

	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public static FIOGMMBEDGN[] KLAMIBFAOEK;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool HNBCNJGJEII
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x6E47390", Offset = "0x6E46790", VA = "0x186E47390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PGEADEKJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x6E46E30", Offset = "0x6E46230", VA = "0x186E46E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GLDBAFPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6E4AED0", Offset = "0x6E4A2D0", VA = "0x186E4AED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public bool LDAIMNIBPNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6E4AF10", Offset = "0x6E4A310", VA = "0x186E4AF10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E47E30", Offset = "0x6E47230", VA = "0x186E47E30")]
	public static OBDIOPMJONL CGCDIFOMPFH(PELOIMAHOHP BIFHNMDIJFJ)
	{
		return default(OBDIOPMJONL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AE10", Offset = "0x6E4A210", VA = "0x186E4AE10")]
	public static void JCFFHGAFMPA(OBDIOPMJONL DLJGECPCKFO, Material PBHLFFKCLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E485B0", Offset = "0x6E479B0", VA = "0x186E485B0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AFD0", Offset = "0x6E4A3D0", VA = "0x186E4AFD0")]
	public void MBNAHHEGHLM(int HHHNDFDGIGL, int FLNJBODOOEH, Allocator HPLNAKONHEI, bool OGNJIJHEFML, bool LDALMOODDLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E48530", Offset = "0x6E47930", VA = "0x186E48530")]
	public void DMKKMKENIML(int HHHNDFDGIGL, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C860", Offset = "0x6E4BC60", VA = "0x186E4C860", Slot = "6")]
	public bool POMMLDFOOFH(Mesh NJMNIJFLOJJ, bool OGLJPOEEPOP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AA10", Offset = "0x6E49E10", VA = "0x186E4AA10")]
	public bool JAGLBGCHPDN(Mesh NJMNIJFLOJJ, bool OGLJPOEEPOP, bool CAEBHDFIHMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6E47E80", Offset = "0x6E47280", VA = "0x186E47E80")]
	public bool CIKCKDNMBDC(Mesh NJMNIJFLOJJ, HOAELOKDIKP GDJOPBMPGKK, bool OGLJPOEEPOP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4BAB0", Offset = "0x6E4AEB0", VA = "0x186E4BAB0")]
	public void OGHBDJPHGKD(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A0B0", Offset = "0x6E494B0", VA = "0x186E4A0B0")]
	[BurstCompile]
	public static int GILLPJEBFOO(float LBEGFJJGJFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A100", Offset = "0x6E49500", VA = "0x186E4A100")]
	[BurstCompile]
	public static uint GILLPJEBFOO([In] float4 IFLBFOHFIEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A060", Offset = "0x6E49460", VA = "0x186E4A060")]
	[BurstCompile]
	public static uint GILLPJEBFOO([In] float3 IFLBFOHFIEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B420", Offset = "0x6E4A820", VA = "0x186E4B420")]
	public void NBFOIJGGFMB(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A150", Offset = "0x6E49550", VA = "0x186E4A150")]
	[BurstCompile]
	private unsafe static void GKACIHIILEJ([NoAlias] NGAHNAOAPAH* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6E499D0", Offset = "0x6E48DD0", VA = "0x186E499D0")]
	public void GDGLEMBNFLF(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C7E0", Offset = "0x6E4BBE0", VA = "0x186E4C7E0")]
	[BurstCompile]
	private unsafe static void PAGFEKPPCPP([NoAlias] PEPEJFEIGPG* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6E47450", Offset = "0x6E46850", VA = "0x186E47450")]
	public void BDIFALIGCHB(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6E473D0", Offset = "0x6E467D0", VA = "0x186E473D0")]
	[BurstCompile]
	private unsafe static void APGONBKADJI([NoAlias] GEEOIDBAGFO* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A2D0", Offset = "0x6E496D0", VA = "0x186E4A2D0")]
	public void IIOELPPICMP(Mesh NJMNIJFLOJJ, bool CAEBHDFIHMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6E4AF50", Offset = "0x6E4A350", VA = "0x186E4AF50")]
	[BurstCompile]
	private unsafe static void LHHMDJFLDKO([NoAlias] GDGBAOLBLKK* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP, [Out] float3 EPOIHEDIBDE, [Out] float3 JKIIJMIHMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6E46DA0", Offset = "0x6E461A0", VA = "0x186E46DA0")]
	public void ADPMDPHFJKG(Mesh NJMNIJFLOJJ, PELOIMAHOHP BIFHNMDIJFJ, bool CAEBHDFIHMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6E486C0", Offset = "0x6E47AC0", VA = "0x186E486C0")]
	public void EBIPGPONPOF(HOAELOKDIKP NJMNIJFLOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6E4A1D0", Offset = "0x6E495D0", VA = "0x186E4A1D0")]
	public void IDBABDEDPCH(HOAELOKDIKP GHEAAGKLGOO, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6E483E0", Offset = "0x6E477E0", VA = "0x186E483E0")]
	public long DLDJKDIOJNP()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6E48380", Offset = "0x6E47780", VA = "0x186E48380")]
	public static long DLDJKDIOJNP(int KDAKNMFPLHI, int KPNIICCHPCO)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6E46F30", Offset = "0x6E46330", VA = "0x186E46F30")]
	public static long ALOHPKHNCFH(int KDAKNMFPLHI, int KPNIICCHPCO, PELOIMAHOHP BIFHNMDIJFJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6E46E70", Offset = "0x6E46270", VA = "0x186E46E70")]
	public long ALOHPKHNCFH(PELOIMAHOHP BIFHNMDIJFJ)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B3C0", Offset = "0x6E4A7C0", VA = "0x186E4B3C0")]
	public void MEFEMDLIFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6E4C4F0", Offset = "0x6E4B8F0", VA = "0x186E4C4F0")]
	public static void OHBONDKLIIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6E48E20", Offset = "0x6E48220", VA = "0x186E48E20")]
	public PELOIMAHOHP EPJEKOINMDK()
	{
		return default(PELOIMAHOHP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6E48D50", Offset = "0x6E48150", VA = "0x186E48D50")]
	public static (int, int) EMCNEMBNGGB(Mesh NJMNIJFLOJJ)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6E48930", Offset = "0x6E47D30", VA = "0x186E48930")]
	public static int EDNKJHMIPGP(VertexAttributeDescriptor[] FIJKMGPPLLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6E47DC0", Offset = "0x6E471C0", VA = "0x186E47DC0")]
	public static long CBIDFKKKLBJ(Mesh NJMNIJFLOJJ, int AEJILLHPHHM, int PPFKOGLHHAB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public HOAELOKDIKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6E47AE0", Offset = "0x6E46EE0", VA = "0x186E47AE0")]
	[BurstCompile]
	public static int BHOBAHFDKNP(float LBEGFJJGJFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6E47B80", Offset = "0x6E46F80", VA = "0x186E47B80")]
	[BurstCompile]
	public static uint BHOBAHFDKNP([In] float4 IFLBFOHFIEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6E47D10", Offset = "0x6E47110", VA = "0x186E47D10")]
	[BurstCompile]
	public static uint BHOBAHFDKNP([In] float3 IFLBFOHFIEP)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6E46FD0", Offset = "0x6E463D0", VA = "0x186E46FD0")]
	[BurstCompile]
	public unsafe static void AODFOKFMKED([NoAlias] NGAHNAOAPAH* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6E49580", Offset = "0x6E48980", VA = "0x186E49580")]
	[BurstCompile]
	public unsafe static void GBNFIDLAENK([NoAlias] PEPEJFEIGPG* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E4B1C0", Offset = "0x6E4A5C0", VA = "0x186E4B1C0")]
	[BurstCompile]
	public unsafe static void MDHBKKCEMPC([NoAlias] GEEOIDBAGFO* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E48A10", Offset = "0x6E47E10", VA = "0x186E48A10")]
	[BurstCompile]
	public unsafe static void EIBGHAONDGH([NoAlias] GDGBAOLBLKK* ELBAFGDCAMB, int DIKHPMLIBDL, [In][NoAlias] float3* FPNBFOHEABF, [In][NoAlias] float3* FIKIFPNLGLK, [In][NoAlias] float4* EMINGACIBCD, [In][NoAlias] float2* KPOAACHGKIN, [In][NoAlias] float4* NOJOGFBGKIP, [Out] float3 EPOIHEDIBDE, [Out] float3 JKIIJMIHMAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public struct MNKJNMPLCFI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int KIEBJIPBGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float3 LNMKOFMEHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public quaternion FLIKJNFCKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 AIFPPCJAJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public int DLKIFPPKHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public int BFHKACAHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public int DOGIBNBPLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float DKAEELFIOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float3 JMPDJDHFDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public bool JPLFFHEHIHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public FIKCFAFLPCD NPOKOGMOPEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float3 JGKCJDFDGMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public float BPHECKPDMFB;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class IMJFEHAJONF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static MMHFPENHENA FIOMEKABEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public NativeList<MNKJNMPLCFI> GILJIGHBMJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public NativeList<KDNPDBIBLNA> EGLKOCOOMAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public NativeList<BAFHLNDKAKO> CDGGHNFCOJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public NativeArray<JCEELACLMMK> KCNDLJOJOJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeList<KDNPDBIBLNA> MINDJKDGONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeList<IDCCPCKEDFG> EIFKNIFLOEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<NativeArray<JCEELACLMMK>> HLHMHOGGBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private NativeList<OHBJCBBCLMA> NOKJNCDMDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	private NativeArray<int> OPONCAGOPIH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int PGEADEKJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x925AA0", Offset = "0x924EA0", VA = "0x180925AA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x923BE0", Offset = "0x922FE0", VA = "0x180923BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int GLDBAFPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x925A90", Offset = "0x924E90", VA = "0x180925A90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x924580", Offset = "0x923980", VA = "0x180924580")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E9C0", Offset = "0x6E4DDC0", VA = "0x186E4E9C0")]
	public IMJFEHAJONF(int MHPAAFFBBJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E3F0", Offset = "0x6E4D7F0", VA = "0x186E4E3F0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DCC0", Offset = "0x6E4D0C0", VA = "0x186E4DCC0")]
	public void BMHCCLKIAAD(JobHandle NCGFNEJFFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E1D0", Offset = "0x6E4D5D0", VA = "0x186E4E1D0")]
	public void CLIIMFEJEAC(MNKJNMPLCFI AIKOCCMKKAE, OHBJCBBCLMA ACEPIOFDFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E860", Offset = "0x6E4DC60", VA = "0x186E4E860")]
	public void OKBIINMDCKA(BAFHLNDKAKO AIKOCCMKKAE, NativeArray<JCEELACLMMK> KGCAJMOOAPJ, int DIKHPMLIBDL, int FDJNCEIGIHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x6E4CC80", Offset = "0x6E4C080", VA = "0x186E4CC80")]
	public JobHandle BLGJLNHMNNG(HOAELOKDIKP HCFFHJGGNIP, MDICCDCIAIG BMJFLBCENLE, float3 AFFHGFMIGJH, quaternion NBLFEAOOFAD, float CBPIEFCEDIP, bool KILEFFOOHHA, int DAAONLOIDHP = 0, int CMAFENGAFID = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x6E4DE90", Offset = "0x6E4D290", VA = "0x186E4DE90")]
	public static JobHandle CGPEPDBNOHE(JJOPIKICBJA ICLFCLOFNOL, HOAELOKDIKP HCFFHJGGNIP, MNKJNMPLCFI AIKOCCMKKAE, JobHandle NCGFNEJFFED)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6E4E5B0", Offset = "0x6E4D9B0", VA = "0x186E4E5B0")]
	public static JobHandle IJBJMNNDNBK(ELLEPCBIJEM ICLFCLOFNOL, HOAELOKDIKP HCFFHJGGNIP, BAFHLNDKAKO AIKOCCMKKAE, NativeArray<JCEELACLMMK> KGCAJMOOAPJ, int DIKHPMLIBDL, int FDJNCEIGIHC, JobHandle NCGFNEJFFED)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public struct EDNPLAGOGPK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public float2 NLMHBLNBBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public float2 DIGEKGMGGBK;
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public class OALIBAAPNBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public NativeArray<EDNPLAGOGPK> KIPLLOHMBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public NativeArray<int> FFHNBODKMLN;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int PGEADEKJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x8AACD0", Offset = "0x8AA0D0", VA = "0x1808AACD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int GLDBAFPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A30", Offset = "0x8A7E30", VA = "0x1808A8A30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6E5B740", Offset = "0x6E5AB40", VA = "0x186E5B740")]
	public OALIBAAPNBB(int HHHNDFDGIGL, int FLNJBODOOEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x6E5B600", Offset = "0x6E5AA00", VA = "0x186E5B600", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E5B660", Offset = "0x6E5AA60", VA = "0x186E5B660")]
	public void EBIPGPONPOF(OALIBAAPNBB PJDHAMFKCCF, int NBFACAKIJKG, int PGAHHGFJKBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class HLCIJABBGCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private static OALIBAAPNBB DMFIABDCOBN;

	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private static NativeList<KDNPDBIBLNA> GOCBEBBHBPH;

	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private static int[] BCNPHFPLHJL;

	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private static bool LCDMMCLIJCI;

	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private static Dictionary<int, OALIBAAPNBB> BHAJLNKPBME;

	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private static Dictionary<int, OALIBAAPNBB> CJPKCDINDMC;

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public static bool MEJECCEIEEN
	{
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6E45BB0", Offset = "0x6E44FB0", VA = "0x186E45BB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public static NativeList<KDNPDBIBLNA> NGFELCDAGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6E46BC0", Offset = "0x6E45FC0", VA = "0x186E46BC0")]
		get
		{
			return default(NativeList<KDNPDBIBLNA>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public static OALIBAAPNBB JGKMBKKAPPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6E45B20", Offset = "0x6E44F20", VA = "0x186E45B20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x6E464B0", Offset = "0x6E458B0", VA = "0x186E464B0")]
	private static void MJBMFDNLPCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x6E45F80", Offset = "0x6E45380", VA = "0x186E45F80")]
	public static int KCMGCEGGEAM(bool FKLJGJAELOH, int ENGJKHDBMJA, bool OJKKDMEDHFO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x6E45CC0", Offset = "0x6E450C0", VA = "0x186E45CC0")]
	private static int FKMDLPHJIBD(int ENGJKHDBMJA, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x6E45DD0", Offset = "0x6E451D0", VA = "0x186E45DD0")]
	private static int HDLNLDAFMAO(int ENGJKHDBMJA, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6E45FB0", Offset = "0x6E453B0", VA = "0x186E45FB0")]
	public static int KICCPGEJPGE(int LBPCGMGCBGG, int ENGJKHDBMJA, int HMPPNJLMFOG, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x6E45C30", Offset = "0x6E45030", VA = "0x186E45C30")]
	public static int FEDALIFIPCL(int LBPCGMGCBGG, int ENGJKHDBMJA, int HMPPNJLMFOG, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6E45860", Offset = "0x6E44C60", VA = "0x186E45860")]
	public static int CODECCHHJCA(int HMPPNJLMFOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6E46BB0", Offset = "0x6E45FB0", VA = "0x186E46BB0")]
	private static int NPIINPNBPEB(int ENGJKHDBMJA, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6E45F60", Offset = "0x6E45360", VA = "0x186E45F60")]
	private static int JKGFHNNHDOH(int ENGJKHDBMJA, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6E46440", Offset = "0x6E45840", VA = "0x186E46440")]
	public static int KOIIAPPGLBE(int LBPCGMGCBGG, int ENGJKHDBMJA, int HMPPNJLMFOG, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x6E45ED0", Offset = "0x6E452D0", VA = "0x186E45ED0")]
	public static int IIIIEEPAKMD(int LBPCGMGCBGG, int ENGJKHDBMJA, int HMPPNJLMFOG, bool CCHFBOBGAKL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x6E45B00", Offset = "0x6E44F00", VA = "0x186E45B00")]
	public static int DBCJOCIFLFD(int HMPPNJLMFOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6E45DE0", Offset = "0x6E451E0", VA = "0x186E45DE0")]
	public static OALIBAAPNBB IEAAFNDLMME(int ENGJKHDBMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x6E45870", Offset = "0x6E44C70", VA = "0x186E45870")]
	private static OALIBAAPNBB DAPNFEEHJIL(int ENGJKHDBMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x6E45CE0", Offset = "0x6E450E0", VA = "0x186E45CE0")]
	public static OALIBAAPNBB GCJONHLAHMF(int ENGJKHDBMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x6E45520", Offset = "0x6E44920", VA = "0x186E45520")]
	private static OALIBAAPNBB AFMNAAAHGNC(int ENGJKHDBMJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x6E46040", Offset = "0x6E45440", VA = "0x186E46040")]
	public static void KIHOFGDHGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct BAFHLNDKAKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public int DLEDEKMDMKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public float3 LNMKOFMEHLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public quaternion FLIKJNFCKDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public float AIFPPCJAJHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public float DMDEBINKOCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public int DLKIFPPKHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public int BFHKACAHKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public int DOGIBNBPLFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public bool KHNFKGOIANL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public bool GLOANCOBBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public float DKAEELFIOAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public float3 JMPDJDHFDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public bool BJACGFKLMEF;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IDCCPCKEDFG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public int OHDIEGDNAPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int FJHOMAGJPAP;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public struct ELLEPCBIJEM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeList<BAFHLNDKAKO> CHIGGJOEKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<JCEELACLMMK> NIBBILKOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<KDNPDBIBLNA> ADIOAOJNHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeArray<IDCCPCKEDFG> NOAAOCODJFI;

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x6E424F0", Offset = "0x6E418F0", VA = "0x186E424F0")]
	public ELLEPCBIJEM(NativeArray<JCEELACLMMK> NIBBILKOOIF, int IKJKAFPPDBP = 1, Allocator HPLNAKONHEI = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x6E42400", Offset = "0x6E41800", VA = "0x186E42400", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[BurstCompile]
public struct FHMMJGFKCGD : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	[ReadOnly]
	private NativeArray<EDNPLAGOGPK> FIKAHIPBAJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	[ReadOnly]
	private NativeArray<int> NDGHHGMGLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	[ReadOnly]
	private NativeList<KDNPDBIBLNA> MPDDLONHDFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	[ReadOnly]
	private NativeList<BAFHLNDKAKO> CHIGGJOEKKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[ReadOnly]
	private NativeArray<JCEELACLMMK> NIBBILKOOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	[ReadOnly]
	private NativeArray<KDNPDBIBLNA> ADIOAOJNHDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	[ReadOnly]
	public NativeArray<IDCCPCKEDFG> NOAAOCODJFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	[ReadOnly]
	private int NAPBJMBFBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	[ReadOnly]
	private int CBJHLFDJCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	[ReadOnly]
	private float3 EFGKKLMFKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	[ReadOnly]
	private quaternion HLJPKLMMCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	[ReadOnly]
	private float3 KABDGLHKHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MDCGGFMLHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PLGGEOFGNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KMJCJFICAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NIHGNMHBEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KLCMEKEMILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KNGJNPIMOIF;

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x6E44680", Offset = "0x6E43A80", VA = "0x186E44680")]
	public FHMMJGFKCGD(IMJFEHAJONF BJPKNGAOINK, HOAELOKDIKP OECCHEOFIJM, float3 IAADDMIACII, quaternion EGLBDDEBHBO, float BHEMNHMHLNF, int DAAONLOIDHP = 0, int CMAFENGAFID = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6E44900", Offset = "0x6E43D00", VA = "0x186E44900")]
	public FHMMJGFKCGD(ELLEPCBIJEM BJPKNGAOINK, HOAELOKDIKP OECCHEOFIJM, float3 IAADDMIACII, quaternion EGLBDDEBHBO, float3 BHEMNHMHLNF, int DAAONLOIDHP = 0, int CMAFENGAFID = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E8")]
	[Cpp2IlInjected.Address(RVA = "0x6E43990", Offset = "0x6E42D90", VA = "0x186E43990")]
	private float3 FBGJOOHEAOB(float3 OHKGHAIFCBF, Matrix4x4 COOHEEBPOIF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x6E44600", Offset = "0x6E43A00", VA = "0x186E44600")]
	private float3x3 KKILMOLLJIN(float3x3 DHBCEIFMGJB, float3x3 ECFANEANHKA)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x6E427E0", Offset = "0x6E41BE0", VA = "0x186E427E0")]
	private float DHGAKOELICL(float KFNOLBCIBOH, float IJIMDHHPBGL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x6E427F0", Offset = "0x6E41BF0", VA = "0x186E427F0", Slot = "4")]
	public void Execute(int JJOEPDKNLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x6E44490", Offset = "0x6E43890", VA = "0x186E44490")]
	private void JHBJBCGBKOK(int IEODHNKLHFF, float3 CLHMEGFDOKF, float3 KENGOPLODLD, float3 NEOICEEMOHM, float CBOFEOAGGML, bool FLNKDBINMJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x6E43AD0", Offset = "0x6E42ED0", VA = "0x186E43AD0")]
	private void GOFMLEFEINJ(BAFHLNDKAKO JOBAEGPBMJA, float3 GOGKCFACHGD, float3x3 JKEFKNOEELB, float KFNOLBCIBOH, int FNHFPKFMABG, int EHADJEOBMDJ, int OLEACJKFFEB, float CHDNPGFKAOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x6E43F10", Offset = "0x6E43310", VA = "0x186E43F10")]
	private void HCPIAPPDHAG(int IEODHNKLHFF, int JNGIJMGCMPF, BAFHLNDKAKO JOBAEGPBMJA, float3 GOGKCFACHGD, float3x3 JKEFKNOEELB, bool HOCIMKDAEMF, float KFNOLBCIBOH, int CCIMKOGJDON, int NDGBLDBGJJL, int OLEACJKFFEB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public struct JJOPIKICBJA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	public NativeList<MNKJNMPLCFI> LBAADDMFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	public NativeList<KDNPDBIBLNA> DINJPAOPOAO;

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F1F0", Offset = "0x6E4E5F0", VA = "0x186E4F1F0")]
	public JJOPIKICBJA(int IKJKAFPPDBP, Allocator HPLNAKONHEI = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F0")]
	[Cpp2IlInjected.Address(RVA = "0x6E4F150", Offset = "0x6E4E550", VA = "0x186E4F150", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
[BurstCompile]
public struct LGHOHBJEFGD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	private enum MNIOJIKFNEE
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
	private NativeList<float3> PJGGONFJNBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	[ReadOnly]
	private NativeArray<float3> IDKGLGIBKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	[ReadOnly]
	private NativeList<int> HMHHDPLGNJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	[ReadOnly]
	private NativeArray<int> LLLODPFGAEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	[ReadOnly]
	private NativeArray<float4> GLONBNJAEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	[ReadOnly]
	private NativeArray<float4> HKADENPPKML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	[ReadOnly]
	private NativeArray<float4> JNAADKBEBFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	[ReadOnly]
	private NativeList<float3> FCKPIFCKKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	[ReadOnly]
	private NativeList<KDNPDBIBLNA> AEPLNDPNHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	[ReadOnly]
	private NativeList<MNKJNMPLCFI> LBAADDMFMED;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	[ReadOnly]
	private NativeList<KDNPDBIBLNA> DINJPAOPOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	[ReadOnly]
	private int NAPBJMBFBBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	[ReadOnly]
	private int CBJHLFDJCMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> MDCGGFMLHML;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> PLGGEOFGNLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> KMJCJFICAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> NIHGNMHBEIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> KLCMEKEMILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KNGJNPIMOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	[ReadOnly]
	private float3 KABDGLHKHIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	[ReadOnly]
	private quaternion HLJPKLMMCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	[ReadOnly]
	private float3 EFGKKLMFKDF;

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x6E51290", Offset = "0x6E50690", VA = "0x186E51290")]
	public LGHOHBJEFGD(IMJFEHAJONF BJPKNGAOINK, HOAELOKDIKP OECCHEOFIJM, float3 IAADDMIACII, quaternion EGLBDDEBHBO, float BHEMNHMHLNF, int DAAONLOIDHP = 0, int CMAFENGAFID = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x6E510B0", Offset = "0x6E504B0", VA = "0x186E510B0")]
	public LGHOHBJEFGD(JJOPIKICBJA AIKOCCMKKAE, HOAELOKDIKP OECCHEOFIJM, float3 IAADDMIACII, quaternion EGLBDDEBHBO, float3 BHEMNHMHLNF, int DAAONLOIDHP = 0, int CMAFENGAFID = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x6E50120", Offset = "0x6E4F520", VA = "0x186E50120", Slot = "4")]
	public void Execute(int JJOEPDKNLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FD70", Offset = "0x6E4F170", VA = "0x186E4FD70")]
	private void DLMMDIIAAPP(float4x4 ILPMLNHKIIF, int JJOEPDKNLJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x6E4FD00", Offset = "0x6E4F100", VA = "0x186E4FD00")]
	private MNIOJIKFNEE CIJJFADMLBB(float3 KENGOPLODLD)
	{
		return default(MNIOJIKFNEE);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F6")]
	[Cpp2IlInjected.Address(RVA = "0x6E51060", Offset = "0x6E50460", VA = "0x186E51060")]
	private float4 KBHGKINEKBC(MNIOJIKFNEE IFOHBPMBAIN, int HAJICDLBEKC)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x60000F7")]
	[Cpp2IlInjected.Address(RVA = "0x6E51020", Offset = "0x6E50420", VA = "0x186E51020")]
	private float2 FLCNDCIODOE(MNIOJIKFNEE IFOHBPMBAIN, float3 CLHMEGFDOKF)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public struct OHBJCBBCLMA
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum BELPPPHLAAI
	{
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		None,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public static OHBJCBBCLMA JFFGEEEAJID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public float3 DPFKDMMBOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public float3x3 HOGDMCNOLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	public float3 GDNEEEAIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	public BELPPPHLAAI NKDPEDOOFIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public float3 MNCDMCDIHNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	public float3 MEGNIGMIJNN;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public bool CPKPPJFCLGP
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6E73470", Offset = "0x6E72870", VA = "0x186E73470")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public float3 MCBKCBKCLHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x6E732A0", Offset = "0x6E726A0", VA = "0x186E732A0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F8")]
	[Cpp2IlInjected.Address(RVA = "0x6E734E0", Offset = "0x6E728E0", VA = "0x186E734E0")]
	public OHBJCBBCLMA(float3 CLHMEGFDOKF, quaternion MDJOMEFJFHD, float3 IKJKAFPPDBP, BELPPPHLAAI DPOLEDLIAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FA")]
	[Cpp2IlInjected.Address(RVA = "0x6E72E10", Offset = "0x6E72210", VA = "0x186E72E10")]
	public float HEGOGJBKIMN(float3 GOGKCFACHGD, float BPIDJENEBBE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FB")]
	[Cpp2IlInjected.Address(RVA = "0x6E72D20", Offset = "0x6E72120", VA = "0x186E72D20")]
	public bool GJOMEEMBHLD(float3 KENGOPLODLD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x6E72B70", Offset = "0x6E71F70", VA = "0x186E72B70")]
	public void EEBNGBIOMPG(float3 IPGCNGDPIPC, float3x3 DODOKNOMBLI, float PLMDAAJFPPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x6E73380", Offset = "0x6E72780", VA = "0x186E73380")]
	private void OPHEAHCCBBF(float3 DFIPADAPDJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6E73010", Offset = "0x6E72410", VA = "0x186E73010")]
	public void IIPLAMIOEEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[BurstCompile]
public struct PFBLDFLADFG : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	[ReadOnly]
	private NativeList<OHBJCBBCLMA> AIKOCCMKKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	[ReadOnly]
	private NativeList<float3> COIFJNIKDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	[ReadOnly]
	private NativeList<int> FJHCOGHKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> OPONCAGOPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	[ReadOnly]
	private NativeList<KDNPDBIBLNA> DINJPAOPOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	[ReadOnly]
	private int IIHIPEPABND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	[ReadOnly]
	private int IIGNJKHEDLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	[ReadOnly]
	private float BPIDJENEBBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	[ReadOnly]
	private float FOOANMNCMNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FGLDANFAMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> PDEPFIHIFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> AOOMBCFPJOJ;

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6E74060", Offset = "0x6E73460", VA = "0x186E74060")]
	public PFBLDFLADFG(HOAELOKDIKP NJMNIJFLOJJ, float AAICJOOBKNJ, int PGAHHGFJKBL, int FNHFPKFMABG, NativeList<OHBJCBBCLMA> AIKOCCMKKAE, NativeArray<int> OPONCAGOPIH, NativeList<KDNPDBIBLNA> DINJPAOPOAO, MDICCDCIAIG BMJFLBCENLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6E73860", Offset = "0x6E72C60", VA = "0x186E73860", Slot = "4")]
	public void Execute(int MNHAHGPFEJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6E73FA0", Offset = "0x6E733A0", VA = "0x186E73FA0")]
	private bool JFJBMDELMKN(OHBJCBBCLMA NIPIGODEADI, OHBJCBBCLMA BCMPBHCEGGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6E735D0", Offset = "0x6E729D0", VA = "0x186E735D0")]
	private bool BGIFLIPBLGN(OHBJCBBCLMA ODLHKDJMEOI, int LKLANEOKCKF, int EKOFJPONEPD, int JKMFHOMPNML)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class MDICCDCIAIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	public NativeArray<bool> ENFKMHJIIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	public NativeArray<int> DNAOIEDCOGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	public NativeArray<bool> OEDMGAPHILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	public NativeArray<float> BIFHBNIEJMF;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F650", Offset = "0x6E6EA50", VA = "0x186E6F650")]
	public void MBNAHHEGHLM(int HHHNDFDGIGL, int FLNJBODOOEH, Allocator HPLNAKONHEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F770", Offset = "0x6E6EB70", VA = "0x186E6F770")]
	public static long MPFAKDELBPM(int HHHNDFDGIGL, int FLNJBODOOEH)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F560", Offset = "0x6E6E960", VA = "0x186E6F560", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F470", Offset = "0x6E6E870", VA = "0x186E6F470")]
	public void BMHCCLKIAAD(JobHandle NCGFNEJFFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
	public MDICCDCIAIG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
[BurstCompile]
public struct DDGHAHNOCLF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private NativeList<float3> COIFJNIKDLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private NativeArray<float3> FIKIFPNLGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private NativeArray<float4> NOJOGFBGKIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private NativeArray<float2> KPOAACHGKIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NativeList<int> FJHCOGHKDDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> EMINGACIBCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private NativeArray<int> HNOGHAHDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	[ReadOnly]
	private NativeArray<bool> FGLDANFAMKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	[ReadOnly]
	private NativeArray<bool> PDEPFIHIFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	[ReadOnly]
	private int DAAONLOIDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	[ReadOnly]
	private int CMAFENGAFID;

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x6E63E90", Offset = "0x6E63290", VA = "0x186E63E90")]
	public DDGHAHNOCLF(HOAELOKDIKP NJMNIJFLOJJ, MDICCDCIAIG BMJFLBCENLE, int CMAFENGAFID = 0, int DAAONLOIDHP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6E63A50", Offset = "0x6E62E50", VA = "0x186E63A50", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6E63E30", Offset = "0x6E63230", VA = "0x186E63E30")]
	private void JHCALNJMJCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class KBCBGBFOIKM
{
	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x2EE1020", Offset = "0x2EE0420", VA = "0x182EE1020")]
	public static bool NNBMBBGNHJA<T>(NativeArray<T> IGGIDMIPNHL, int IKJKAFPPDBP, Allocator HPLNAKONHEI, NativeArrayOptions ALOJIDNACGI = NativeArrayOptions.ClearMemory, int BIEFOHMNLCG = 3) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x2EE10E0", Offset = "0x2EE04E0", VA = "0x182EE10E0")]
	public static bool NNBMBBGNHJA<T>(NativeList<T> KDBAFFDDPME, int IKJKAFPPDBP, Allocator HPLNAKONHEI) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public enum NNPOOOODFLC
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
public interface KANOEICIOLH
{
	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int IJJGMNCFDOH(NNPOOOODFLC LBPCGMGCBGG);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AGMDOFNGFGJ(NNPOOOODFLC LBPCGMGCBGG);

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(Slot = "2")]
	Bounds LNNPBKIABMN();

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(Slot = "3")]
	float OLBFKFMHNEE();

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void INGLBLIPMCM(NNPOOOODFLC LBPCGMGCBGG, IMJFEHAJONF MCCHFEJLAAJ, int IHPDIDJAADL = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public static class CMPMCALKGAI
{
	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x6E63900", Offset = "0x6E62D00", VA = "0x186E63900")]
	public static void KIHOFGDHGPK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public class BBBGGNENOOG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public NativeList<float3> AIBOCANIJAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public NativeArray<float3> CDFAEEHGFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public NativeArray<int> GOJELDEANML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public NativeArray<float4> OGHFEGFLMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public NativeArray<float4> KNLMJAHEIAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public NativeArray<float4> MNHPEAKMOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public NativeList<float3> DDKBJCMPANP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public NativeList<int> JCINBGMKOGI;

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int PGEADEKJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6E5C360", Offset = "0x6E5B760", VA = "0x186E5C360")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public int GLDBAFPOMDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6E5C7F0", Offset = "0x6E5BBF0", VA = "0x186E5C7F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public int APHPFKNJMBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6E5C7B0", Offset = "0x6E5BBB0", VA = "0x186E5C7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D230", Offset = "0x6E5C630", VA = "0x186E5D230")]
	public BBBGGNENOOG(int HHHNDFDGIGL, int FLNJBODOOEH, int KLMCGAANDBN, Allocator HPLNAKONHEI = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D500", Offset = "0x6E5C900", VA = "0x186E5D500")]
	public BBBGGNENOOG(Mesh NJMNIJFLOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0x6E5C3A0", Offset = "0x6E5B7A0", VA = "0x186E5C3A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x6E5C4B0", Offset = "0x6E5B8B0", VA = "0x186E5C4B0")]
	public void EBIPGPONPOF(BBBGGNENOOG NJMNIJFLOJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5CDA0", Offset = "0x6E5C1A0", VA = "0x186E5CDA0")]
	private void PFCAHGLJNEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5C830", Offset = "0x6E5BC30", VA = "0x186E5C830")]
	private void LIFLDLFHGKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public struct KDNPDBIBLNA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public int PPECAIOEJJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public int PGEADEKJMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public int MJNPEIJOFJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public int GLDBAFPOMDF;

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x188AAC0", Offset = "0x1889EC0", VA = "0x18188AAC0")]
	public KDNPDBIBLNA(int FNHFPKFMABG, int DIKHPMLIBDL, int PGAHHGFJKBL, int FDJNCEIGIHC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class MMHFPENHENA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public NativeList<KDNPDBIBLNA> GKMDKOGMBMM
	{
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0xA9B260", Offset = "0xA9A660", VA = "0x180A9B260")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<KDNPDBIBLNA>);
		}
		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0xA9B470", Offset = "0xA9A870", VA = "0x180A9B470")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public BBBGGNENOOG NPGCFLNBACA
	{
		[Cpp2IlInjected.Token(Token = "0x6000121")]
		[Cpp2IlInjected.Address(RVA = "0x8A89D0", Offset = "0x8A7DD0", VA = "0x1808A89D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8A8A00", Offset = "0x8A7E00", VA = "0x1808A8A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6E6FD10", Offset = "0x6E6F110", VA = "0x186E6FD10")]
	public MMHFPENHENA(IEnumerable<BBBGGNENOOG> JFBAIOKGEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6E6FCA0", Offset = "0x6E6F0A0", VA = "0x186E6FCA0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public enum FIKCFAFLPCD
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public static class MKKKDOCHCOJ
{
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static NativeArray<float2> DOMHHIJIPDM;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static NativeArray<float3> HPCBIEIAOJK;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static NativeArray<float4> NBBGGNGIPHD;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static NativeArray<int> GGFDAAPMBID;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F990", Offset = "0x6E6ED90", VA = "0x186E6F990")]
	public static void KIHOFGDHGPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F890", Offset = "0x6E6EC90", VA = "0x186E6F890")]
	public static NativeArray<float2> GAACOABFOLB(NativeArray<float2> NBCOBANFFJA, int KPIKPFPHKDK, NativeArray<float2> AMKDMIPKIJC, int HCMBEELJKDP)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6E6FBA0", Offset = "0x6E6EFA0", VA = "0x186E6FBA0")]
	public static NativeArray<float3> PLLAINELCJI(NativeArray<float3> NBCOBANFFJA, int KPIKPFPHKDK, NativeArray<float3> AMKDMIPKIJC, int HCMBEELJKDP)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6E6F790", Offset = "0x6E6EB90", VA = "0x186E6F790")]
	public static NativeArray<float4> BDKHOIANEJM(NativeArray<float4> NBCOBANFFJA, int KPIKPFPHKDK, NativeArray<float4> AMKDMIPKIJC, int HCMBEELJKDP)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6E6FAA0", Offset = "0x6E6EEA0", VA = "0x186E6FAA0")]
	public static NativeArray<int> PGJFNKJCHNJ(NativeArray<int> NBCOBANFFJA, int KPIKPFPHKDK, NativeArray<int> AMKDMIPKIJC, int HCMBEELJKDP)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x2F39810", Offset = "0x2F38C10", VA = "0x182F39810")]
	private static void ECEEMPBJCPA<T>(NativeArray<T> IGGIDMIPNHL, int FFMHPBMNMBH) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x2F39730", Offset = "0x2F38B30", VA = "0x182F39730")]
	private static void CECBCBDHFOO<T>(NativeArray<T> NBCOBANFFJA, int KPIKPFPHKDK, NativeArray<T> AMKDMIPKIJC, int HCMBEELJKDP, NativeArray<T> PHOJDDFPDNH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
[BurstCompile]
public class BHEIKFMJBOJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public struct IIGKACCEONN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public ushort LBEGFJJGJFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public ushort GAMIAAAKNPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public ushort PPLPGLGEGKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public ushort GEHIGLIINFO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E390", Offset = "0x6E5D790", VA = "0x186E5E390")]
	public static uint IANKAPJINCD(float NJCFLGAHLKH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E130", Offset = "0x6E5D530", VA = "0x186E5E130")]
	public static void FJPHNCEKAJB(float4 NOJOGFBGKIP, float DBLMJEABJCI, [Out] uint OIOGJJFCFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E060", Offset = "0x6E5D460", VA = "0x186E5E060")]
	public static void FJPHNCEKAJB(float4 NOJOGFBGKIP, uint MPANOHOCEBJ, [Out] uint OIOGJJFCFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x6E5D800", Offset = "0x6E5CC00", VA = "0x186E5D800")]
	public static void ACBOJKKANAM(float3 PHDGJFFONJL, float3 AEGIFMDICNJ, float4 LAAGIODBKMC, float2 LACNJIMIAGA, float4 NOJOGFBGKIP, [Out] HOAELOKDIKP.GEEOIDBAGFO CJEGEOGLADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DA50", Offset = "0x6E5CE50", VA = "0x186E5DA50")]
	public static void ACBOJKKANAM(float3 PHDGJFFONJL, float3 AEGIFMDICNJ, float4 LAAGIODBKMC, float2 LACNJIMIAGA, float4 NOJOGFBGKIP, [Out] HOAELOKDIKP.GDGBAOLBLKK CJEGEOGLADB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DEC0", Offset = "0x6E5D2C0", VA = "0x186E5DEC0")]
	public static byte DFDGBKPHDJN(float EEPLCHCGAIN)
	{
		return default(byte);
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E3A0", Offset = "0x6E5D7A0", VA = "0x186E5E3A0")]
	public static ushort LMNJGNLJDHO(float EEPLCHCGAIN)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DCB0", Offset = "0x6E5D0B0", VA = "0x186E5DCB0")]
	public static uint BDEFAJFPJOJ(float EEPLCHCGAIN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DCE0", Offset = "0x6E5D0E0", VA = "0x186E5DCE0")]
	public static float2 CEMDOJEHABG(float2 IFLBFOHFIEP)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0x6E5E240", Offset = "0x6E5D640", VA = "0x186E5E240")]
	public static float2 HLGDJDDPDIF(float3 AFMDDDNOHPC)
	{
		return default(float2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DF10", Offset = "0x6E5D310", VA = "0x186E5DF10")]
	public static void DKIGBCNOFFN(float3 EEPLCHCGAIN, [Out] float3 JKIMENNHFIN, [Out] uint3 GEHIGLIINFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6E5DD60", Offset = "0x6E5D160", VA = "0x186E5DD60")]
	public static IIGKACCEONN DBCCKPKBFHG(float3 CLHMEGFDOKF)
	{
		return default(IIGKACCEONN);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public static class ADLKNBOIMBF
{
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private static readonly ProfilerMarker IPFBFPFGMIH;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public static float IGPKFPPBJID;

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void KJKECNGPPOG(bool MGDKJCBEABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6E5BDB0", Offset = "0x6E5B1B0", VA = "0x186E5BDB0")]
	public static void KKIDDLBMOAM(float FCLENJMKLIA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public class DOGPHDKDAHJ
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	internal enum FFCMJHJFGIM
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
	public struct ELKFGLPDNPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public MCKOEJIOMLF NJMNIJFLOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public int NHEKPKHCCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public int KHNHAGDFDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public long FHPCKCCNFBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public long BMIGOCKMCLE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public float APPMIFILDBC;

		[Cpp2IlInjected.Token(Token = "0x6000175")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EF50", Offset = "0x6E6E350", VA = "0x186E6EF50")]
		public void IPNPHEKPPLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EED0", Offset = "0x6E6E2D0", VA = "0x186E6EED0")]
		public void BMHCCLKIAAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly string BNNGOJPIFEP;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly string LNMJBHGAJOL;

	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private static readonly ProfilerMarker IPFBFPFGMIH;

	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private static readonly ProfilerMarker KDKCHGKCBDA;

	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private static readonly ProfilerMarker HEDNGLNNNOC;

	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private static readonly ProfilerMarker HHIOCEHEBKH;

	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private static readonly ProfilerMarker ECJHCGPOLIE;

	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private static readonly ProfilerMarker GJLGOGGBIDI;

	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private static readonly ProfilerMarker IDMOJCEJIPC;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly ProfilerMarker JINCDKFGDHE;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly ProfilerMarker JFPMNPPMIMM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly ProfilerMarker ACPEFJDIPJK;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly ProfilerMarker PJHKBEIPABI;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private static readonly ProfilerMarker LOGBPLNDMOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly List<KANOEICIOLH> MCOPGCLGFGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private readonly BMHLGBBDJOD KPDJAPDLAHP;

	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public const bool MBNKCPHHHAP = true;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int DIKHPMLIBDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private int FDJNCEIGIHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private bool EPDOFIDPLED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	internal bool DHMIBAOFGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool NBCLAGFNCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	internal FFCMJHJFGIM NMAIGNOENJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	internal bool HJPIIEPDOLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	internal float3 HDCLOODHJCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	internal float3 IBLDCEMDPLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	internal float FDJEIGMKLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	internal float EOGCIAAFINM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	internal int PBMJABHAAAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	internal int FONPCAKHHHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private int CLCIKMPMJBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x7C")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private int AFMMAHKIOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private float IIKPJPHKGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private float BHKDKEBJBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private int OCCKAHLIOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private long CFMBFNPIMNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private long BDPFMPCGPKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private long HNGPJMMOPAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	public int BKJMFLCGLHK;

	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private const int HKKLGKMNMKG = 3;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private float[] HAONBNEEIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private int[] KDPNAOMAIEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private long[] MKFPEHBKHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private List<ELKFGLPDNPJ> BIFPLPINHPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000149")]
	private HOAELOKDIKP INFDCMKAKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	private long OJBINNBAGCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	private long ACCDHBLMLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	private int PLEOEFLCJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	internal float BGODIOLELDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	internal HOAELOKDIKP.PELOIMAHOHP PKIOGGPHNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF4")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	private bool ALCLPJIKDII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	private NGEJMCCDHEL EFBIGNLCAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	private JobHandle GOPDEMEMKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	internal NativeArray<long> AFGINOAAMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	private bool EBHGEKNFHPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	private JobHandle BAFBFFNIGFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	private HOAELOKDIKP PJIMMEJIAGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private MDICCDCIAIG KHBEIMJJPFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	private Transform KPAJJPJPOGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	private NNPOOOODFLC BGDDAJJLEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	private long PBGEJJDOANG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private long FJEJIAHLNPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private long LOFJOJBLCMB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	internal Mesh NPGCFLNBACA
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x8AD890", Offset = "0x8ACC90", VA = "0x1808AD890")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4B0", Offset = "0x8AC8B0", VA = "0x1808AD4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public MeshFilter LEIIBBPODLE
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x8AAD00", Offset = "0x8AA100", VA = "0x1808AAD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public MeshRenderer GFMICOOFDBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x8AD870", Offset = "0x8ACC70", VA = "0x1808AD870")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8B2C20", Offset = "0x8B2020", VA = "0x1808B2C20")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public List<Material> PGJAPJHHFMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x8AD4C0", Offset = "0x8AC8C0", VA = "0x1808AD4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x8ADA40", Offset = "0x8ACE40", VA = "0x1808ADA40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int DJNLFIHEKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x99C190", Offset = "0x99B590", VA = "0x18099C190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public int ICOJMLHIJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x1304600", Offset = "0x1303A00", VA = "0x181304600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public int PGEADEKJMKC
	{
		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x6E64E90", Offset = "0x6E64290", VA = "0x186E64E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public List<KANOEICIOLH> IAMELLHJOGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x8AACF0", Offset = "0x8AA0F0", VA = "0x1808AACF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6E68DF0", Offset = "0x6E681F0", VA = "0x186E68DF0")]
	public void KDBGDFGMGNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6E68140", Offset = "0x6E67540", VA = "0x186E68140")]
	private void JFOHPBBLJBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6E6EBF0", Offset = "0x6E6DFF0", VA = "0x186E6EBF0")]
	public DOGPHDKDAHJ(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6E66100", Offset = "0x6E65500", VA = "0x186E66100")]
	public void BMHCCLKIAAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6E6E020", Offset = "0x6E6D420", VA = "0x186E6E020")]
	private void OMIMAAPHFEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6E68060", Offset = "0x6E67460", VA = "0x186E68060")]
	private void IMGHDHGCHBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B380", Offset = "0x6E6A780", VA = "0x186E6B380")]
	public Mesh LJMOAGHOMHM(MeshFilter NIAIJCOALNM, Transform HGENDDPKHHK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6E67600", Offset = "0x6E66A00", VA = "0x186E67600")]
	private void DLIDDBMNBHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6E66560", Offset = "0x6E65960", VA = "0x186E66560")]
	public void DFIKDMNGJDM(KANOEICIOLH NPHFNBBBAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C5B0", Offset = "0x6E6B9B0", VA = "0x186E6C5B0")]
	public bool MFAACKHCKML(KANOEICIOLH NPHFNBBBAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6E67A70", Offset = "0x6E66E70", VA = "0x186E67A70")]
	public bool FLEJEGPKCKH(KANOEICIOLH NPHFNBBBAMB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x6E6AF60", Offset = "0x6E6A360", VA = "0x186E6AF60", Slot = "4")]
	public virtual void KODBDDJLLNP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6E6AFF0", Offset = "0x6E6A3F0", VA = "0x186E6AFF0")]
	public void LAMNONKPEOC(Transform LEBCEFANKLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B2C0", Offset = "0x6E6A6C0", VA = "0x186E6B2C0")]
	private long LJAPFDNGPGJ()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CE40", Offset = "0x6E6C240", VA = "0x186E6CE40")]
	private long OLDBLAJBKDH()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B490", Offset = "0x6E6A890", VA = "0x186E6B490")]
	public bool LLOGLDKAKAG(Transform LEBCEFANKLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x6E666C0", Offset = "0x6E65AC0", VA = "0x186E666C0")]
	public bool DKCGHFPOMLK(bool BFACDDNJDLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C640", Offset = "0x6E6BA40", VA = "0x186E6C640")]
	private void OJDFDKPCECH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6E697E0", Offset = "0x6E68BE0", VA = "0x186E697E0")]
	public bool KKIDDLBMOAM(float4x4 DGLIIEKJOKL, BatchedMeshRenderer PGCLDJLEKKP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x6E65C00", Offset = "0x6E65000", VA = "0x186E65C00")]
	public void BEBNNPFHBNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6E66230", Offset = "0x6E65630", VA = "0x186E66230")]
	public bool CDGFLEOLNAO(bool BFACDDNJDLP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6E6C630", Offset = "0x6E6BA30", VA = "0x186E6C630")]
	public void NNFOGPAHPEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x6E679E0", Offset = "0x6E66DE0", VA = "0x186E679E0")]
	public void ENIHKOHNFIH(HOAELOKDIKP NJMNIJFLOJJ, int EILHJELPNDH, int NMNAOGEFCHP, float IKHPLPFCLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6E6E0C0", Offset = "0x6E6D4C0", VA = "0x186E6E0C0")]
	public void PAFLDFFONJH(MCKOEJIOMLF NDLHGPOHHDF, int EILHJELPNDH, int NMNAOGEFCHP, float IKHPLPFCLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6E67590", Offset = "0x6E66990", VA = "0x186E67590")]
	public (long, long, long) DLDJKDIOJNP()
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x9B5880", Offset = "0x9B4C80", VA = "0x1809B5880")]
	public long MFLELEFLGCL()
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6E6E410", Offset = "0x6E6D810", VA = "0x186E6E410")]
	private void PGIIOJBDMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x6E63F10", Offset = "0x6E63310", VA = "0x186E63F10")]
	public (long, long) AAIJOCHKBHL(float DGMNBOCOBEE, float4x4 DGLIIEKJOKL)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public void LOFELKMCMLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6E67AD0", Offset = "0x6E66ED0", VA = "0x186E67AD0")]
	internal void GACNAKGIODK(FFCMJHJFGIM DNHBNDCDNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6E642A0", Offset = "0x6E636A0", VA = "0x186E642A0")]
	private (float, float, float, float) ABLDIKCBCCB(float KOMOOMPEGEK, float4x4 DGLIIEKJOKL)
	{
		return default((float, float, float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6E67A10", Offset = "0x6E66E10", VA = "0x186E67A10")]
	private float FFCJKBEEOPE(float KOMOOMPEGEK, float4x4 DGLIIEKJOKL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6E64B50", Offset = "0x6E63F50", VA = "0x186E64B50")]
	private (int, int) AGCPPIODADI(float LKKCJAPGLDH)
	{
		return default((int, int));
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6E6CFA0", Offset = "0x6E6C3A0", VA = "0x186E6CFA0")]
	public void OLIEMHDOMFI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6E67890", Offset = "0x6E66C90", VA = "0x186E67890")]
	private void EBNALIJFIBM(HOAELOKDIKP JFEMEJDFCAC, HOAELOKDIKP.PELOIMAHOHP GDIFNIBGHDM, bool CAEBHDFIHMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6E678E0", Offset = "0x6E66CE0", VA = "0x186E678E0")]
	private void EBNALIJFIBM([In] MCKOEJIOMLF JFEMEJDFCAC, HOAELOKDIKP.PELOIMAHOHP GDIFNIBGHDM, bool CAEBHDFIHMD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6E6E370", Offset = "0x6E6D770", VA = "0x186E6E370")]
	private void PBBKHDCGBPK(HOAELOKDIKP.PELOIMAHOHP GDIFNIBGHDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6E65BD0", Offset = "0x6E64FD0", VA = "0x186E65BD0")]
	private void BCEEGMEAKII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6E65DE0", Offset = "0x6E651E0", VA = "0x186E65DE0")]
	private void BHODLALJBHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6E68440", Offset = "0x6E67840", VA = "0x186E68440")]
	public long JKJHCBGKHLM(long FBPJGFLGBIL, int PONAIKMGKDB)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6E64EB0", Offset = "0x6E642B0", VA = "0x186E64EB0")]
	private void BAKDDCGIEDD(HOAELOKDIKP HOHGDPEHNKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6E67BF0", Offset = "0x6E66FF0", VA = "0x186E67BF0")]
	private void ICOPDPABAAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6E6B230", Offset = "0x6E6A630", VA = "0x186E6B230")]
	private float LBHLKOFOEPI(int PKEEPFNILBG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6E68E00", Offset = "0x6E68200", VA = "0x186E68E00")]
	private void KGBGDHLHBFC(HOAELOKDIKP NJMNIJFLOJJ, OAGAEDLKIOE NDLHGPOHHDF, int EILHJELPNDH, int NMNAOGEFCHP, float IKHPLPFCLBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
[BurstCompile]
internal struct NGEJMCCDHEL : IJob
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private struct GNHCEPHGPBA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public int KILNCDGICOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public int EMKHMEMFMMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public int KMAGIIDEGNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public int JMCNKODKDMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		public int LANEICMOFGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		public int HKNIJBNFIFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int NHEKPKHCCML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public int KHNHAGDFDFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public float APPMIFILDBC;
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private struct PEAFDHBKMOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public HCMHKBDBCKO.BCHJPDNOHKN MAOOAJPICNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public float BMDKEIFMNJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public float LIGICCEKDGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public float BMJMPPGGFGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float BIMMNNIJNFE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public float OMJKPLHCCLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public float GLLEDKJNBIH;
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private struct EMEDMOEBHAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public NativeArray<float3> AIBOCANIJAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public NativeArray<float3> CDFAEEHGFPG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public NativeArray<float4> OFCEPFMKAMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public NativeArray<float4> HKKKHCPGEEO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public NativeArray<float2> OCHGNCCPOBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public NativeArray<int> JCINBGMKOGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public bool OKADKKOBKLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400019D")]
		public int PGEADEKJMKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400019E")]
		public int GLDBAFPOMDF;

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F290", Offset = "0x6E6E690", VA = "0x186E6F290")]
		public void MBNAHHEGHLM(int HHHNDFDGIGL, int FLNJBODOOEH, Allocator HPLNAKONHEI, bool LDALMOODDLC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000181")]
		[Cpp2IlInjected.Address(RVA = "0x6E6F040", Offset = "0x6E6E440", VA = "0x186E6F040")]
		public static EMEDMOEBHAD JGAJGEOKGLN(HOAELOKDIKP CEMFCPJEKHI)
		{
			return default(EMEDMOEBHAD);
		}

		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(RVA = "0x6E6EF80", Offset = "0x6E6E380", VA = "0x186E6EF80")]
		public void BMHCCLKIAAD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private static readonly ProfilerMarker CFHHJPOEECD;

	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private static readonly ProfilerMarker NCFECMJDGPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<GNHCEPHGPBA> LKHGIJKDJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	private EMEDMOEBHAD NCLDIBLGCMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	private EMEDMOEBHAD HOHGDPEHNKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private float3 DBAHFOJNDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xFC")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private float3 LLMPHJEJNNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400017B")]
	private PEAFDHBKMOK NIKLPNACIDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe readonly long* HIPJKOOPEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	private NativeArray<int> IEOFGIHKBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	private NativeArray<bool> PDEPFIHIFEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	private NativeArray<int> COIFCKJFCME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	private NativeArray<int> PELGPHKHJPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private NativeArray<float> HJHAIFAHGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	private NativeArray<int> CKGNHIIEIIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private NativeArray<float> BADOODLFNMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	private NativeArray<float> DANNAKBANJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	private NativeArray<int> FJDMFNLAOJH;

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x6E72310", Offset = "0x6E71710", VA = "0x186E72310")]
	public NGEJMCCDHEL([In] List<DOGPHDKDAHJ.ELKFGLPDNPJ> OOGPCPBMNKH, [In] HOAELOKDIKP IMEFFDGAFOL, [In] DOGPHDKDAHJ GFBNCOJKADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6E70D20", Offset = "0x6E70120", VA = "0x186E70D20", Slot = "4")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6E703C0", Offset = "0x6E6F7C0", VA = "0x186E703C0")]
	public void BAMHHCFMPPE(List<DOGPHDKDAHJ.ELKFGLPDNPJ> GAHHCIGOACK, [In] DOGPHDKDAHJ GFBNCOJKADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6E72250", Offset = "0x6E71650", VA = "0x186E72250")]
	[BurstCompile]
	[IgnoreWarning(1371)]
	private bool NFHKNGLCMKB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6E71D00", Offset = "0x6E71100", VA = "0x186E71D00")]
	private MCKOEJIOMLF INCCCIMFPKN(int CHMMFPIMGKI, Allocator HPLNAKONHEI)
	{
		return default(MCKOEJIOMLF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6E70D70", Offset = "0x6E70170", VA = "0x186E70D70")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	private void FNLAFHFBIFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x6E71F30", Offset = "0x6E71330", VA = "0x186E71F30")]
	[IgnoreWarning(1371)]
	private GNHCEPHGPBA JMPMOJPBJLH([In] GNHCEPHGPBA OCLJJCLBAAN, int PHCKBKNGCMB, [In] NativeArray<int> FJHCOGHKDDO, [In] NativeArray<bool> PDEPFIHIFEI, NativeArray<int> COIFCKJFCME)
	{
		return default(GNHCEPHGPBA);
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6E702C0", Offset = "0x6E6F6C0", VA = "0x186E702C0")]
	[IgnoreWarning(1371)]
	[BurstCompile]
	public int AMFOCLDFKLD(NativeArray<int> FJHCOGHKDDO, int GHFNBLMOIBG, int DPGFJLBOLGE, int KHIPJIMNOBN)
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
		public static readonly FLILHMOBPPM log;

		[Cpp2IlInjected.Token(Token = "0x40001A0")]
		private static readonly ProfilerMarker OEONIFHIGPG;

		[Cpp2IlInjected.Token(Token = "0x40001A1")]
		private static readonly ProfilerMarker LCJIAALFGJL;

		[Cpp2IlInjected.Token(Token = "0x40001A2")]
		private static readonly ProfilerMarker FMNPLDHDAED;

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		private static readonly ProfilerMarker CJOMBNMHOOP;

		[Cpp2IlInjected.Token(Token = "0x40001A4")]
		private static readonly ProfilerMarker JHFMHDEIGAD;

		[Cpp2IlInjected.Token(Token = "0x40001A5")]
		private static readonly ProfilerMarker ECJHCGPOLIE;

		[Cpp2IlInjected.Token(Token = "0x40001A6")]
		private static readonly ProfilerMarker NGFENHDOIEG;

		[Cpp2IlInjected.Token(Token = "0x40001A7")]
		internal const int AFOPOOLGILO = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001A8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		internal static Dictionary<Material, List<Material>> MFHEHFKLEKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		private Dictionary<Material, List<DOGPHDKDAHJ>> EJIKNKHDLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		internal List<DOGPHDKDAHJ> BKFAJBDPPOC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001AD")]
		private List<MeshRenderer> OKJGMAMFJNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001AE")]
		private Transform MPAFCNCLOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001AF")]
		private bool IEKCICGHNDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x41")]
		[Cpp2IlInjected.Token(Token = "0x40001B0")]
		private bool ELFKIIBEHMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		private int ABEDCBMBLCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		private DOGPHDKDAHJ FPFOEMPMJKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B3")]
		private Material BAJCOIOLGAH;

		[Cpp2IlInjected.Token(Token = "0x40001B4")]
		public static bool enableSRPBatcher;

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private const int OMAKACKDOMI = 1024;

		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private static List<(long, Bounds, KANOEICIOLH)> EEBNODOLHNL;

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public IReadOnlyList<MeshRenderer> GPBKDCEJEED
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x8AAD10", Offset = "0x8AA110", VA = "0x1808AAD10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public int MGJCMCAMINB
		{
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0x6E638B0", Offset = "0x6E62CB0", VA = "0x186E638B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		private static void OCPCDMPODLN(bool MGDKJCBEABF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		private static void OCPCDMPODLN(bool MGDKJCBEABF, string MOKGCFCFCPE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6E608F0", Offset = "0x6E5FCF0", VA = "0x186E608F0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E470", Offset = "0x6E5D870", VA = "0x186E5E470")]
		public DOGPHDKDAHJ AddToBatchedMesh(KANOEICIOLH CNCNDEBLOHN, Material PBHLFFKCLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6E63310", Offset = "0x6E62710", VA = "0x186E63310")]
		public void RemoveFromBatchedMesh(KANOEICIOLH NJMNIJFLOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E570", Offset = "0x6E5D970", VA = "0x186E5E570")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F010", Offset = "0x6E5E410", VA = "0x186E5F010")]
		private void FFBLHBNHFIP(Renderer OMALFJOLMMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F1A0", Offset = "0x6E5E5A0", VA = "0x186E5F1A0")]
		public void ForceUpdateBatchedMeshOnGPUIfNotLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F190", Offset = "0x6E5E590", VA = "0x186E5F190")]
		public void ForceUpdateBatchedMeshOnGPUEvenIfLoading()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6E601E0", Offset = "0x6E5F5E0", VA = "0x186E601E0")]
		private void OOHHKCLONPK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FCB0", Offset = "0x6E5F0B0", VA = "0x186E5FCB0")]
		public void MarkTemporarilyFrozen()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E6A0", Offset = "0x6E5DAA0", VA = "0x186E5E6A0")]
		private DOGPHDKDAHJ DIAGPDPPPNK(KANOEICIOLH NJMNIJFLOJJ, Material PBHLFFKCLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000191")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F7B0", Offset = "0x6E5EBB0", VA = "0x186E5F7B0")]
		private DOGPHDKDAHJ HHDOLGKIJKF(Material PBHLFFKCLKK, int NDPHLIBLJFD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x6E5E940", Offset = "0x6E5DD40", VA = "0x186E5E940")]
		private DOGPHDKDAHJ ELPHLBCOHAA(Material PBHLFFKCLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000193")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F090", Offset = "0x6E5E490", VA = "0x186E5F090")]
		private float4x4 FLPHJPBOCKB()
		{
			return default(float4x4);
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x6E607D0", Offset = "0x6E5FBD0", VA = "0x186E607D0")]
		private List<Material> OPLLKHCIOEM(Material PBHLFFKCLKK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0xCD5740", Offset = "0xCD4B40", VA = "0x180CD5740")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FB20", Offset = "0x6E5EF20", VA = "0x186E5FB20")]
		public void MarkDirty(KANOEICIOLH NJMNIJFLOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x6E5FE20", Offset = "0x6E5F220", VA = "0x186E5FE20")]
		public (long, long) MemorySizeInBytesForChosenDetail(float DGMNBOCOBEE)
		{
			return default((long, long));
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x6E62080", Offset = "0x6E61480", VA = "0x186E62080")]
		public void RedoScalabilityThinking()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
		public void HandleDirtyStateNow()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x6E5F240", Offset = "0x6E5E640", VA = "0x186E5F240")]
		public (int, int) GetVertexCounts()
		{
			return default((int, int));
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x6E60B50", Offset = "0x6E5FF50", VA = "0x186E60B50")]
		public void RebatchOptimally(int NMGBKCOLBNC, int HAMLLCPIPPM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x6E63780", Offset = "0x6E62B80", VA = "0x186E63780")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class JKJNMIIMBFH
{
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private struct EPFMNPJEECM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public float ALEEOPFLOLJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		public BatchedMeshRenderer LPOEJMOAKNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		public DOGPHDKDAHJ NENDMJBBKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		public long EMEDILBGCEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		public float LGBPEODBGED;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public bool IGJJMKHKINB;
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	[CompilerGenerated]
	private sealed class AKOFDBDOGMD : IEnumerable<bool>, IEnumerable, IEnumerator<bool>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0xBE3D50", Offset = "0xBE3150", VA = "0x180BE3D50", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E75140", Offset = "0x6E74540", VA = "0x186E75140", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0xD3D620", Offset = "0xD3CA20", VA = "0x180D3D620")]
		[DebuggerHidden]
		public AKOFDBDOGMD(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x6E75190", Offset = "0x6E74590", VA = "0x186E75190", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x6E743D0", Offset = "0x6E737D0", VA = "0x186E743D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C2")]
		[Cpp2IlInjected.Address(RVA = "0x6E74330", Offset = "0x6E73730", VA = "0x186E74330")]
		private void CPDIPGODGJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C3")]
		[Cpp2IlInjected.Address(RVA = "0x6E74380", Offset = "0x6E73780", VA = "0x186E74380")]
		private void FKMGMNDEOBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x6E750F0", Offset = "0x6E744F0", VA = "0x186E750F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x6E75040", Offset = "0x6E74440", VA = "0x186E75040", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<bool> IEnumerable<bool>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x6E75040", Offset = "0x6E74440", VA = "0x186E75040", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	public static readonly FLILHMOBPPM APPINHJJCPL;

	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private static readonly ProfilerMarker ECJHCGPOLIE;

	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private static readonly ProfilerMarker BNNDEGJFGLL;

	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private static readonly ProfilerMarker IOJLFNBMEOG;

	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private static readonly ProfilerMarker ECBHCKJKKKN;

	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	public static float3 ACDPGAPNHPN;

	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	public static int LIPIIDCLNEL;

	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	public static int EKBGNAECGPL;

	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	public static int LMDHJECKFMG;

	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	public static int PALJPKLPFKO;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	public static int JALPHPEIBGJ;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	public static int LHEGNOKOLML;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	public static long KEIAENKBOKG;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	public static long JJPLIACGEAN;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	public static int NJPFKMFGGFB;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	public static int BFNFGGADLDM;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	public static int MPMKOONIJBF;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	public static float IBDPCILBBLP;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	public static bool JDBBNIDFOBO;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	public static int EDFPPKLBHJG;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	public static float PENIKCJMHKM;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	public static float NDOGEHHGHAA;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	public static float LMJMKLMANDE;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	public static float EGHBIMFMHMI;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	public static float BHALAGKGCOJ;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	public static float ENPELJKEJPD;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	public static float IMGLOLOCMMJ;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	public static float KKJFFDCJEFP;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	public static long KELEEPKEKCE;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	public static bool OCGBLJONCMO;

	[Cpp2IlInjected.Token(Token = "0x40001D7")]
	private static List<BatchedMeshRenderer> CFHHAHFCLCL;

	[Cpp2IlInjected.Token(Token = "0x40001D8")]
	private static List<EPFMNPJEECM> BDDAMEIGGHK;

	[Cpp2IlInjected.Token(Token = "0x40001D9")]
	private static Stack<HOAELOKDIKP> KNCBAJLIFDA;

	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private static Stack<MDICCDCIAIG> MFIMANLIAGA;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public static bool DICHFCFFNCA
	{
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x6E75650", Offset = "0x6E74A50", VA = "0x186E75650")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void OCPCDMPODLN(bool MGDKJCBEABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void KJKECNGPPOG(bool MGDKJCBEABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	private static void OCPCDMPODLN(bool MGDKJCBEABF, string MOKGCFCFCPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x8AA270", Offset = "0x8A9670", VA = "0x1808AA270")]
	public static void IPNPHEKPPLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A6")]
	[Cpp2IlInjected.Address(RVA = "0x6E79530", Offset = "0x6E78930", VA = "0x186E79530")]
	public static void OJMFHNGNLMN(BatchedMeshRenderer LGBHOGIBOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x6E79690", Offset = "0x6E78A90", VA = "0x186E79690")]
	public static void PGLKHMGEDHK(BatchedMeshRenderer LGBHOGIBOFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x6E757F0", Offset = "0x6E74BF0", VA = "0x186E757F0")]
	private static (long, long, long) FFDJIOJEPMG(long NBNACEMEGIJ)
	{
		return default((long, long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x6E792C0", Offset = "0x6E786C0", VA = "0x186E792C0")]
	public static bool NCKIACHENCE(float JGNGEMHJDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x6E768B0", Offset = "0x6E75CB0", VA = "0x186E768B0")]
	public static void KDCDMKMCCNJ(float JGNGEMHJDGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x6E756E0", Offset = "0x6E74AE0", VA = "0x186E756E0")]
	public static bool FCNOENHFEBB(float JGNGEMHJDGL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6E76A70", Offset = "0x6E75E70", VA = "0x186E76A70")]
	public static void KKIDDLBMOAM(long NBNACEMEGIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6E76400", Offset = "0x6E75800", VA = "0x186E76400")]
	public static long JKJHCBGKHLM(long FBPJGFLGBIL)
	{
		return default(long);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6E75510", Offset = "0x6E74910", VA = "0x186E75510")]
	public static void DMBKKCDBHEM(DOGPHDKDAHJ NENDMJBBKDD, BatchedMeshRenderer LPOEJMOAKNI, long EMEDILBGCEH, float ALEEOPFLOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x6E762D0", Offset = "0x6E756D0", VA = "0x186E762D0")]
	public static void JJMJFBFJGIA(DOGPHDKDAHJ NENDMJBBKDD, BatchedMeshRenderer LPOEJMOAKNI, long EMEDILBGCEH, float FCLENJMKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x6E76060", Offset = "0x6E75460", VA = "0x186E76060")]
	public static void HCKDMBBEKJB(DOGPHDKDAHJ NENDMJBBKDD, BatchedMeshRenderer LPOEJMOAKNI, long EMEDILBGCEH, float FCLENJMKLIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6E75900", Offset = "0x6E74D00", VA = "0x186E75900")]
	public static void FLMHLJGAEDF(DOGPHDKDAHJ NENDMJBBKDD, BatchedMeshRenderer LPOEJMOAKNI, long EMEDILBGCEH, float EAGOOFIEGAA, bool IGJJMKHKINB, float ALEEOPFLOLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x6E75C80", Offset = "0x6E75080", VA = "0x186E75C80")]
	public static float HCJMMMCLPJO(long PBFLNMPOOMK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x6E752B0", Offset = "0x6E746B0", VA = "0x186E752B0")]
	public static (long, long) AAIJOCHKBHL(float DGMNBOCOBEE)
	{
		return default((long, long));
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x6E75480", Offset = "0x6E74880", VA = "0x186E75480")]
	[IteratorStateMachine(typeof(AKOFDBDOGMD))]
	public static IEnumerable<bool> AMCDGBENKFC(long DOEPKPIAJOB, bool DNEPDDJHCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6E79370", Offset = "0x6E78770", VA = "0x186E79370")]
	public static void NDGJMBODJJL(long DOEPKPIAJOB, bool DNEPDDJHCBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6E76190", Offset = "0x6E75590", VA = "0x186E76190")]
	public static int IBJPNJGAEOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6E75B30", Offset = "0x6E74F30", VA = "0x186E75B30")]
	internal static HOAELOKDIKP FOHCPOFJFEL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6E76820", Offset = "0x6E75C20", VA = "0x186E76820")]
	internal static void JNHLIGPJFOG(HOAELOKDIKP FCJOKKNLEAL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6E76920", Offset = "0x6E75D20", VA = "0x186E76920")]
	internal static MDICCDCIAIG KJDEAFOLBAI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x6E76790", Offset = "0x6E75B90", VA = "0x186E76790")]
	internal static void JNHLIGPJFOG(MDICCDCIAIG BMJFLBCENLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public class ICJOEONGNFH<KeyType> : DOGPHDKDAHJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private readonly Dictionary<KeyType, KANOEICIOLH> PHBCBIFMNAM;

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x4233CD0", Offset = "0x42330D0", VA = "0x184233CD0")]
	public ICJOEONGNFH(string DDDHPCNFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x4233840", Offset = "0x4232C40", VA = "0x184233840")]
	public void DFIKDMNGJDM(KeyType OEOMDKHBDFI, KANOEICIOLH NPHFNBBBAMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x42338B0", Offset = "0x4232CB0", VA = "0x1842338B0")]
	public bool EAAPFLEAPFG(KeyType OEOMDKHBDFI, KANOEICIOLH FFNDJHEKEHM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x4233B90", Offset = "0x4232F90", VA = "0x184233B90")]
	public void EKOOBNFDIDP(KeyType OEOMDKHBDFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x4233C70", Offset = "0x4233070", VA = "0x184233C70", Slot = "4")]
	public override void KODBDDJLLNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
internal static class $BurstDirectCallInitializer
{
	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x6E79EF0", Offset = "0x6E792F0", VA = "0x186E79EF0")]
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
