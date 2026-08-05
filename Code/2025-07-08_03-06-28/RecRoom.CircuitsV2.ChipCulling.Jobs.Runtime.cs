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
public struct BACFNHJHAPI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerMarker PKIAPAEAKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[WriteOnly]
	public NativeArray<int> LOHJEHIDOBH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB190", Offset = "0x7FB9F90", VA = "0x187FBB190", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BurstCompile]
public struct KBFMEMFKIAB : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ProfilerMarker PKIAPAEAKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ReadOnly]
	public NativeArray<float4> FEJAKAAABOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[ReadOnly]
	public NativeArray<float4> NJAHDJILONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[ReadOnly]
	public NativeArray<float4> EEHOIPJINDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnly]
	public NativeArray<float4> AOLGAIAIPFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[WriteOnly]
	public NativeArray<float4> EBOEELKKJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public MJAIIHLLLBM HOFBGHHGFGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float FNJPMBAJFJM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB5F0", Offset = "0x7FBA3F0", VA = "0x187FBB5F0", Slot = "4")]
	public void Execute(int BOECAAOIBHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAF20", Offset = "0x7FB9D20", VA = "0x187FBAF20")]
	private float4 NALEOBJDNDL(float4 MOFEJNPFCAO, float4 OHNAEGJPJJB, float4 MMIFMOAHNCG, float4 FEOCGJNJGGC, float4 OCLGADMPDLC, float4 DPCFDIABDKB)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB080", Offset = "0x7FB9E80", VA = "0x187FBB080")]
	private float4 NALEOBJDNDL(float4 MOFEJNPFCAO, float4 OHNAEGJPJJB, float4 MMIFMOAHNCG, float FEOCGJNJGGC, float OCLGADMPDLC, float DPCFDIABDKB)
	{
		return default(float4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BurstCompile]
public struct MKJOOHHPKDK : IJobParallelForTransform
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ProfilerMarker PKIAPAEAKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[WriteOnly]
	public NativeArray<float> IKMMHHBOIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[WriteOnly]
	public NativeArray<float> AICHMOJCKJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[WriteOnly]
	public NativeArray<float> FFLLGJMMDDB;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBF40", Offset = "0x7FBAD40", VA = "0x187FBBF40", Slot = "4")]
	public void Execute(int BOECAAOIBHO, TransformAccess OLPMPAIMKPI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BurstCompile]
public struct PEFHPMLAMBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ProfilerMarker PKIAPAEAKGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int OOJPJFMJCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<float> PNHBLBEEIKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<int> LOHJEHIDOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<bool> HCKPMIFLFLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[WriteOnly]
	public NativeArray<CIFLIGJJNDC> DLMFLBANMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool JJKBFCLJAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool NFCGILGEONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool HJJEIMMEEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public ChipVisibilityConfig GFIBGLICFLN;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC190", Offset = "0x7FBAF90", VA = "0x187FBC190", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FBBFA0", Offset = "0x7FBADA0", VA = "0x187FBBFA0")]
	private static CIFLIGJJNDC EDJOIGCGJBH([In] ChipVisibilityConfig AKNOMFNEFAO, float BDHGJFJOOFM, int LEPKFDJOPNO, bool GKMNBKPMCHG, bool HHECOEPBIIA, bool LGGNIAHOMKJ, bool NBBMHPHKJPL)
	{
		return default(CIFLIGJJNDC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct BAEAALCPADG : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<int> HBHDBEHHINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> BJJHFEJKNPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ProfilerMarker GMBHHNMCCLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public ProfilerMarker ILOPKHNHHKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ProfilerMarker CCHGBEBGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ProfilerMarker BAFKHFKLDOA;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7FBB250", Offset = "0x7FBA050", VA = "0x187FBB250", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAEF0", Offset = "0x7FB9CF0", VA = "0x187FBAEF0")]
	private static int FKGLGOGAIFA(int PADDIEKMDDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAF00", Offset = "0x7FB9D00", VA = "0x187FBAF00")]
	private static int IKOGLKPLJGK(int PADDIEKMDDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBAF10", Offset = "0x7FB9D10", VA = "0x187FBAF10")]
	private static int LCKBFJEMKMO(int PADDIEKMDDH)
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
