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
public struct EAFKBJFBCGP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerMarker FEEDOCNMFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[WriteOnly]
	public NativeArray<int> BGLKCICGNLN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81FA6E0", Offset = "0x81F90E0", VA = "0x1881FA6E0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BurstCompile]
public struct BIIONPMICMA : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ProfilerMarker FEEDOCNMFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ReadOnly]
	public NativeArray<float4> JLFDOKGADAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[ReadOnly]
	public NativeArray<float4> EJKELHCEIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[ReadOnly]
	public NativeArray<float4> JNDMHDHGPON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnly]
	public NativeArray<float4> KPHNHPBDDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[WriteOnly]
	public NativeArray<float4> FIOOKKKKPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public GIGKHFDOKJN JBPHFFGGIGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float GOACHFFKJIO;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81F9A60", Offset = "0x81F8460", VA = "0x1881F9A60", Slot = "4")]
	public void Execute(int BAMENPFPKND)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81F9760", Offset = "0x81F8160", VA = "0x1881F9760")]
	private float4 FNMLCANIEAA(float4 HPJFKLIKDBB, float4 IIKCPOHEKJA, float4 OJHJKNMPEKC, float4 DPABGMANDOD, float4 CGAPNODMBKM, float4 MINCIJCAHBJ)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81F98C0", Offset = "0x81F82C0", VA = "0x1881F98C0")]
	private float4 FNMLCANIEAA(float4 HPJFKLIKDBB, float4 IIKCPOHEKJA, float4 OJHJKNMPEKC, float DPABGMANDOD, float CGAPNODMBKM, float MINCIJCAHBJ)
	{
		return default(float4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BurstCompile]
public struct BDIAFENDHCH : IJobParallelForTransform
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ProfilerMarker FEEDOCNMFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[WriteOnly]
	public NativeArray<float> AOOICKAEFPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[WriteOnly]
	public NativeArray<float> MCCNFOJJIMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[WriteOnly]
	public NativeArray<float> ONCLGIFLBIC;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81F9A00", Offset = "0x81F8400", VA = "0x1881F9A00", Slot = "4")]
	public void Execute(int BAMENPFPKND, TransformAccess EOBBLENOIHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BurstCompile]
public struct CKCNCDOBGGM : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ProfilerMarker FEEDOCNMFGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int NEOIHEKIHEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<float> LPODNHEDJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<int> BGLKCICGNLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<bool> FHFHAHKHDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[WriteOnly]
	public NativeArray<MNIBKGNCCNA> HJFGPBAAHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool CAIDGHIJFIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool CBKIMDIGMCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool KCJKODEGIBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public ChipVisibilityConfig KKPEKMJBPNA;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81FA3B0", Offset = "0x81F8DB0", VA = "0x1881FA3B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81FA4F0", Offset = "0x81F8EF0", VA = "0x1881FA4F0")]
	private static MNIBKGNCCNA LLOLMHFDCKH([In] ChipVisibilityConfig IIAJEKDJMMB, float DCAJFENJDOB, int DOFDDKIECFL, bool FEPKJKFNCGD, bool FHOKOOHDNKD, bool FADKJJEMLDO, bool KNJDDBMCPFO)
	{
		return default(MNIBKGNCCNA);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct HEFIJMFCOII : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<int> AKBOOJDMDHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> KJFEDBCFOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ProfilerMarker NJCGEAFNDHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public ProfilerMarker BFCNGJIJEKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ProfilerMarker AMGCLDOHHBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ProfilerMarker FEBACHGHIOF;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81FA7A0", Offset = "0x81F91A0", VA = "0x1881FA7A0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81F99F0", Offset = "0x81F83F0", VA = "0x1881F99F0")]
	private static int IBCLFCIOJAH(int GMLILPJAKBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81F99D0", Offset = "0x81F83D0", VA = "0x1881F99D0")]
	private static int CAODEAGPEEF(int GMLILPJAKBM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81F99E0", Offset = "0x81F83E0", VA = "0x1881F99E0")]
	private static int GNKAAEJNOBG(int GMLILPJAKBM)
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
