using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using RecRoom.CircuitsV2.ChipCulling.Data;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine.Jobs;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[BurstCompile]
public struct NMFHMMOEHMM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerMarker AKLOBICAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[WriteOnly]
	public NativeArray<int> JGDDAOPPIBE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7373320", Offset = "0x7372720", VA = "0x187373320", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BurstCompile]
public struct DPMFIEIFGIG : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ProfilerMarker AKLOBICAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ReadOnly]
	public NativeArray<float4> LFFENHFHMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[ReadOnly]
	public NativeArray<float4> JDOPGOCJIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[ReadOnly]
	public NativeArray<float4> FCIHNEDIIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnly]
	public NativeArray<float4> NDNNOOOBALF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[WriteOnly]
	public NativeArray<float4> MHIMGKMJNBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public LDEMCMIALEB AGHJBMDFMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float KAJDAFKCJCL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7372640", Offset = "0x7371A40", VA = "0x187372640", Slot = "4")]
	public void Execute(int BKHEBBAMMAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7372030", Offset = "0x7371430", VA = "0x187372030")]
	private float4 DNJOKFNILHP(float4 NLGHOPBFLJF, float4 PJEOLLCBAFM, float4 GJHHAPMDEID, float4 NLGEJNMPCBB, float4 LGLGCBDJNJB, float4 LMMIPMIKEED)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7372190", Offset = "0x7371590", VA = "0x187372190")]
	private float4 DNJOKFNILHP(float4 NLGHOPBFLJF, float4 PJEOLLCBAFM, float4 GJHHAPMDEID, float NLGEJNMPCBB, float LGLGCBDJNJB, float LMMIPMIKEED)
	{
		return default(float4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BurstCompile]
public struct JOEHINBODJK : IJobParallelForTransform
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ProfilerMarker AKLOBICAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[WriteOnly]
	public NativeArray<float> NLJAKFBICBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[WriteOnly]
	public NativeArray<float> FNPDBHGFFNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[WriteOnly]
	public NativeArray<float> AFGDGBKLBNI;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7372F90", Offset = "0x7372390", VA = "0x187372F90", Slot = "4")]
	public void Execute(int BKHEBBAMMAK, TransformAccess EJNLPEDOMDD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BurstCompile]
public struct NJAKHBGKHKL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ProfilerMarker AKLOBICAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int AGHLCEGEAOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<float> APCEIAHCPFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<int> JGDDAOPPIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<bool> HPBMOAHLDAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[WriteOnly]
	public NativeArray<PPFNBFPBHAN> KBLKLOLKEJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool EKGGMCOKAEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool KBDBJLOKCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool BPGBLGCAOBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public ChipVisibilityConfig AIBDEPGJLMN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7372FF0", Offset = "0x73723F0", VA = "0x187372FF0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7373130", Offset = "0x7372530", VA = "0x187373130")]
	private static PPFNBFPBHAN FMEMIKJHGFF([In] ChipVisibilityConfig HNGEBELLBGC, float NMGOPKGDGPL, int BPPPJPHJIEH, bool ACNECPIIDKB, bool JCBDIBLIOFH, bool LHJIOHCEGEO, bool BIIMNNINKPC)
	{
		return default(PPFNBFPBHAN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct CCBMOGHHEEE : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<int> FENODPMPHEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> BMBDKKIJGOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ProfilerMarker MKEEMEMLECE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public ProfilerMarker NPNKGCAAAOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ProfilerMarker NOKHCLGLCPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ProfilerMarker GHEAODDFFDP;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x73722A0", Offset = "0x73716A0", VA = "0x1873722A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7372020", Offset = "0x7371420", VA = "0x187372020")]
	private static int KCGGBAGDHIL(int IOJLNNHDMIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7372000", Offset = "0x7371400", VA = "0x187372000")]
	private static int FDKLJHBHKOL(int IOJLNNHDMIE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7372010", Offset = "0x7371410", VA = "0x187372010")]
	private static int FKKEMEBCLOF(int IOJLNNHDMIE)
	{
		return default(int);
	}
}
namespace Cpp2IlInjected;

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
