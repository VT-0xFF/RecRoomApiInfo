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
public struct HAMLBLIIPKF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerMarker COJIBOGAFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[WriteOnly]
	public NativeArray<int> KOLGKFIDHHJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A2EB50", Offset = "0x7A2D350", VA = "0x187A2EB50", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BurstCompile]
public struct FLDHJGBDLIJ : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ProfilerMarker COJIBOGAFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ReadOnly]
	public NativeArray<float4> FIFNOGCLIGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[ReadOnly]
	public NativeArray<float4> CNDAMBOEDNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[ReadOnly]
	public NativeArray<float4> NECPONPPJGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnly]
	public NativeArray<float4> IGFELJJNCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[WriteOnly]
	public NativeArray<float4> CLGLHCKFIHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public ADDIOACPGKI KLLJOGOKJHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float GOMOBINMNEB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E200", Offset = "0x7A2CA00", VA = "0x187A2E200", Slot = "4")]
	public void Execute(int JEGIFICJAGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A2DF60", Offset = "0x7A2C760", VA = "0x187A2DF60")]
	private float4 LIOMFAEDKOF(float4 NFLHPHICALP, float4 CCFBJEHMAAF, float4 APDEEGPOANL, float4 MDLEENGMPIA, float4 EOAPJOODELM, float4 MLLDEMEFIGA)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E0C0", Offset = "0x7A2C8C0", VA = "0x187A2E0C0")]
	private float4 LIOMFAEDKOF(float4 NFLHPHICALP, float4 CCFBJEHMAAF, float4 APDEEGPOANL, float MDLEENGMPIA, float EOAPJOODELM, float MLLDEMEFIGA)
	{
		return default(float4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BurstCompile]
public struct IEEFGMJIOCG : IJobParallelForTransform
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ProfilerMarker COJIBOGAFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[WriteOnly]
	public NativeArray<float> JKCMNFIAAPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[WriteOnly]
	public NativeArray<float> AOBAGGFDJAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[WriteOnly]
	public NativeArray<float> KBJAIEOHLNO;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A2EC50", Offset = "0x7A2D450", VA = "0x187A2EC50", Slot = "4")]
	public void Execute(int JEGIFICJAGL, TransformAccess POFBAOBKAGL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BurstCompile]
public struct MIDIDEFJDHH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ProfilerMarker COJIBOGAFHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int FCHJPHAGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<float> HLDIIJDIKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<int> KOLGKFIDHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<bool> LFAOPMLBHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[WriteOnly]
	public NativeArray<GENCGNLFIMO> DHFFFJJEGMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool OFLCCFHKJBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool JCBGPJGJJNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool DKDJJIPJHMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public ChipVisibilityConfig CLGGCFNLNMK;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F050", Offset = "0x7A2D850", VA = "0x187A2F050", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A2F1D0", Offset = "0x7A2D9D0", VA = "0x187A2F1D0")]
	private static GENCGNLFIMO PFGGHLJFIJA([In] ChipVisibilityConfig CNALDGOMHPM, float DLEALMAIPHE, int OEGOFNILEDK, bool GJENEIHGMMA, bool PMOOADNDKNE, bool EEFFEKGCBLA, bool HHFAPDHLLCP)
	{
		return default(GENCGNLFIMO);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct LDMNBBGBLHI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<int> BADLMALNNLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> CAINCJAHEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ProfilerMarker CAOHJGHJFKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public ProfilerMarker HAFAMEEFEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ProfilerMarker JCOFBBKAMFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ProfilerMarker JOFIJIAKILB;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A2ECB0", Offset = "0x7A2D4B0", VA = "0x187A2ECB0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E1E0", Offset = "0x7A2C9E0", VA = "0x187A2E1E0")]
	private static int JLIPAIDECFH(int JEOEDPICHHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E1F0", Offset = "0x7A2C9F0", VA = "0x187A2E1F0")]
	private static int NHHBKPBOLCI(int JEOEDPICHHI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A2E1D0", Offset = "0x7A2C9D0", VA = "0x187A2E1D0")]
	private static int CFIBHNMGKFH(int JEOEDPICHHI)
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
