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
public struct MMBHHPLPKPH : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public ProfilerMarker CJJKIFAHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	[WriteOnly]
	public NativeArray<int> MGMEOBFCKEM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80691D0", Offset = "0x80681D0", VA = "0x1880691D0", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[BurstCompile]
public struct BPDCJMLBMED : IJobParallelFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public ProfilerMarker CJJKIFAHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[ReadOnly]
	public NativeArray<float4> DNDKHKEHGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	[ReadOnly]
	public NativeArray<float4> FDCIAAMENKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	[ReadOnly]
	public NativeArray<float4> AOOAJEIEPMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnly]
	public NativeArray<float4> MKCEEKGACNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[WriteOnly]
	public NativeArray<float4> ACLDKKJAAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public LDABNOODCFP GDEFLLKOGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public float NFMGGHCFGLD;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8068880", Offset = "0x8067880", VA = "0x188068880", Slot = "4")]
	public void Execute(int GGLNBEGGDDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8067F40", Offset = "0x8066F40", VA = "0x188067F40")]
	private float4 GPJFLMAEGDH(float4 OFIAJCPDMDA, float4 ICLDPEOBIFM, float4 CEGEKHMDKKB, float4 ANAEBPGAIDG, float4 DBPANKFDBCK, float4 JLHMJMOCDPI)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x80680A0", Offset = "0x80670A0", VA = "0x1880680A0")]
	private float4 GPJFLMAEGDH(float4 OFIAJCPDMDA, float4 ICLDPEOBIFM, float4 CEGEKHMDKKB, float ANAEBPGAIDG, float DBPANKFDBCK, float JLHMJMOCDPI)
	{
		return default(float4);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[BurstCompile]
public struct ODFCHLKKEKF : IJobParallelForTransform
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public ProfilerMarker CJJKIFAHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	[WriteOnly]
	public NativeArray<float> LACGBKKDKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[WriteOnly]
	public NativeArray<float> HGDBACKBCBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[WriteOnly]
	public NativeArray<float> AAGACCHDJPP;

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8069290", Offset = "0x8068290", VA = "0x188069290", Slot = "4")]
	public void Execute(int GGLNBEGGDDO, TransformAccess PLPGMCABFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
[BurstCompile]
public struct BHAOJDONPLO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public ProfilerMarker CJJKIFAHPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public int JHCCKPLGFOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	[ReadOnly]
	public NativeArray<float> PGBMKJKHLJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	[ReadOnly]
	public NativeArray<int> MGMEOBFCKEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public NativeArray<bool> NKMDKOKJJED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[WriteOnly]
	public NativeArray<JGMCNAJFBKJ> KHJBFHPLGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public bool BOEBFDLMBJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x51")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public bool EPILNMDBEDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x52")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public bool BPBKANOHNLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public ChipVisibilityConfig EKKBIJHOJDB;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x80681B0", Offset = "0x80671B0", VA = "0x1880681B0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x80682F0", Offset = "0x80672F0", VA = "0x1880682F0")]
	private static JGMCNAJFBKJ NHDNIGKIHKL([In] ChipVisibilityConfig JMAMNPMFFKK, float OHEOHPEPBMC, int HLFNKBNKLJH, bool IPJAHHOMCBA, bool KEDKPCGLNDH, bool BNOOHLEDBJE, bool HOGNHCGFECM)
	{
		return default(JGMCNAJFBKJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[BurstCompile]
public struct BKBGCMBPMBP : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<int> FGNOGEEOKID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<int> IBDNFGELPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public ProfilerMarker DODPEGDIBFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public ProfilerMarker BDEDKGJEDNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public ProfilerMarker GNHPPJMAIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public ProfilerMarker HAEAKEGDBNK;

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80684E0", Offset = "0x80674E0", VA = "0x1880684E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8067F10", Offset = "0x8066F10", VA = "0x188067F10")]
	private static int ELFMAIMLPEJ(int JMJJABEKOFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8067F30", Offset = "0x8066F30", VA = "0x188067F30")]
	private static int LOGMFLMJOFA(int JMJJABEKOFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8067F20", Offset = "0x8066F20", VA = "0x188067F20")]
	private static int IPGLBJDKPDP(int JMJJABEKOFI)
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
