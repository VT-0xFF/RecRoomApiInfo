using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cpp2IlInjected;
using Unity.Collections;
using Unity.Mathematics;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public struct KLJBPNDBEKJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MCBCOKPBBMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int DNCFAFMOCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int DAHFOAMCPNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int DKMMKGJLHNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int BALIPBIAPIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LLDJNHPBDHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int APLNGOINJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 FBMEEAHHOKI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EB61B0", Offset = "0x6EB53B0", VA = "0x186EB61B0")]
		public MCBCOKPBBMJ(int AELMEJPBPCD, int NFAIIAFAFFI, int EOBECBOMIBO, int KAFKEGONBOK, int CCJHGJAKPEK, int LABGDHHHELG, float3 AHEOGBFEFAD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct EAAHALDOFGI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int KHDFINMADEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int HDKCAOOHAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float KMPPJHCKGHG;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x20617B0", Offset = "0x20609B0", VA = "0x1820617B0")]
		public EAAHALDOFGI(int DJFHFDKDHMO, int APODEFIALKC, float ANIFGLPKOMK)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct PLJHPOCPLLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int HDKCAOOHAJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int OAIJBELJDOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int IOFIFGLIIPC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, MCBCOKPBBMJ> DCIFKLPGDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<EAAHALDOFGI> OFHBOGJPEJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> IPBPGBEGOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<PLJHPOCPLLK> PCOOOEIHNHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> MHEFNPFNFJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int GCKFKJENDGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int CJKDLAJFNGN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EB34B0", Offset = "0x6EB26B0", VA = "0x186EB34B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5790", Offset = "0x6EB4990", VA = "0x186EB5790")]
	public bool MJGBNEIDNFO(in NativeArray<float3> ECOOEILKAHH, ref NativeList<float3> AECAEKHGKFL, ref NativeList<int> FGPMAMJJHFD, Allocator KPFKDHLBOGB, CancellationToken MELLLMEKJLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EB39B0", Offset = "0x6EB2BB0", VA = "0x186EB39B0")]
	private void KCEHONPEIFO(in NativeArray<float3> ECOOEILKAHH, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3FF0", Offset = "0x6EB31F0", VA = "0x186EB3FF0")]
	private void LBONBGAGHCD(in NativeArray<float3> ECOOEILKAHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3B90", Offset = "0x6EB2D90", VA = "0x186EB3B90")]
	private void KGMFKLAGENE(in NativeArray<float3> ECOOEILKAHH, out int KJCLDMBKIGD, out int AOEHFHEOBAD, out int BLPFCBPNIJA, out int JOGELFFFGHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3260", Offset = "0x6EB2460", VA = "0x186EB3260")]
	private void CNCAPLHOICC(in NativeArray<float3> ECOOEILKAHH, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5240", Offset = "0x6EB4440", VA = "0x186EB5240")]
	private void MFHDKPMCFKH(in NativeArray<float3> ECOOEILKAHH, float3 GKENIDGAHNF, int CLLHLOKODNF, MCBCOKPBBMJ BDDPKBILOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2E50", Offset = "0x6EB2050", VA = "0x186EB2E50")]
	private void CBHNLEILLPF(in NativeArray<float3> ECOOEILKAHH, float3 GKENIDGAHNF, int ECCGNBOAHDB, int CJKDLAJFNGN, MCBCOKPBBMJ BDDPKBILOGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5880", Offset = "0x6EB4A80", VA = "0x186EB5880")]
	private void MMOJHJGEDMP(in NativeArray<float3> ECOOEILKAHH, int MCINJMMKJKA, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5E30", Offset = "0x6EB5030", VA = "0x186EB5E30")]
	private void OKKGAJMCJDI(in NativeArray<float3> ECOOEILKAHH, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB35F0", Offset = "0x6EB27F0", VA = "0x186EB35F0")]
	private void FJGNIGHILCI(in NativeArray<float3> ECOOEILKAHH, ref NativeList<float3> AECAEKHGKFL, ref NativeList<int> FGPMAMJJHFD, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5720", Offset = "0x6EB4920", VA = "0x186EB5720")]
	private float MIBDIIPOANN(float3 GKENIDGAHNF, float3 HHANLDGCELL, MCBCOKPBBMJ BDDPKBILOGC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1540", Offset = "0x6EB0740", VA = "0x186EB1540")]
	private float3 FBMEEAHHOKI(float3 AELMEJPBPCD, float3 NFAIIAFAFFI, float3 EOBECBOMIBO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4437320", Offset = "0x4436520", VA = "0x184437320")]
	private static float JLFMFNGAHJH(float3 GGFLAOCNMAP, float3 PIINDHALINJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x44371B0", Offset = "0x44363B0", VA = "0x1844371B0")]
	private static float3 NFJPDMHNIKM(float3 GGFLAOCNMAP, float3 PIINDHALINJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EB3450", Offset = "0x6EB2650", VA = "0x186EB3450")]
	private bool DGHEBMJHKPH(float3 GGFLAOCNMAP, float3 PIINDHALINJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EB5160", Offset = "0x6EB4360", VA = "0x186EB5160")]
	private bool MBPJADGMKLN(float3 GGFLAOCNMAP, float3 PIINDHALINJ, float3 MGJAHLJBKFN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EB4E40", Offset = "0x6EB4040", VA = "0x186EB4E40")]
	private bool LFACBCBNPGA(float3 GGFLAOCNMAP, float3 PIINDHALINJ, float3 MGJAHLJBKFN, float3 ANIFGLPKOMK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EEMBOBBLMNH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KHMMHHJPLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public unsafe int* indices;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public int indexCount;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private NativeList<float3> CIPJKPODOID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> JNHGMBOCEHP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PLFLELIAPFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EB2670", Offset = "0x6EB1870", VA = "0x186EB2670")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CNCJEBOCBHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EB2380", Offset = "0x6EB1580", VA = "0x186EB2380")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BNBLLGADOKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EB26B0", Offset = "0x6EB18B0", VA = "0x186EB26B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public PNMPBCAMODD FHPKOPKEBNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EB25C0", Offset = "0x6EB17C0", VA = "0x186EB25C0")]
		get
		{
			return default(PNMPBCAMODD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2D60", Offset = "0x6EB1F60", VA = "0x186EB2D60")]
	public EEMBOBBLMNH(int IBNACECIPOO, int OECNGAMPOOD, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2E20", Offset = "0x6EB2020", VA = "0x186EB2E20")]
	public EEMBOBBLMNH(PNMPBCAMODD CFOPFEPDHHL, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2970", Offset = "0x6EB1B70", VA = "0x186EB2970")]
	public EEMBOBBLMNH(Mesh BNHDDEIBJPG, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2B00", Offset = "0x6EB1D00", VA = "0x186EB2B00")]
	public EEMBOBBLMNH(EEMBOBBLMNH JFGIPFOFKHL, Allocator KPFKDHLBOGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB23C0", Offset = "0x6EB15C0", VA = "0x186EB23C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB1E60", Offset = "0x6EB1060", VA = "0x186EB1E60")]
	public void CKPKOIJGHLD(in EEMBOBBLMNH FGIADOJFAEB, float4x4 CELAMPCHIFA, Transform LNECKLBPJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2450", Offset = "0x6EB1650", VA = "0x186EB2450")]
	public void GBDNHLBNELE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EB19A0", Offset = "0x6EB0BA0", VA = "0x186EB19A0")]
	public void ALAJMELBDFJ(float EKIBGBMDOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EB26F0", Offset = "0x6EB18F0", VA = "0x186EB26F0")]
	public EEMBOBBLMNH NMDFKNOPEBM(Allocator KPFKDHLBOGB, CancellationToken MELLLMEKJLC)
	{
		return default(EEMBOBBLMNH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EB21C0", Offset = "0x6EB13C0", VA = "0x186EB21C0")]
	public Mesh CLFNFPIHFLI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EB22E0", Offset = "0x6EB14E0", VA = "0x186EB22E0")]
	private unsafe static float3* DDODHLIJPBA(NativeArray<float3> LMFDNLBGHBA)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2330", Offset = "0x6EB1530", VA = "0x186EB2330")]
	private unsafe static int* DDODHLIJPBA(NativeArray<int> LMFDNLBGHBA)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EB2640", Offset = "0x6EB1840", VA = "0x186EB2640")]
	[CompilerGenerated]
	internal static void HIFMHKGHCEG(int MFCPKEIBGLL, int AECIJILOILJ, ref KHMMHHJPLHC P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct PNMPBCAMODD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int PLFLELIAPFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int CNCJEBOCBHI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OBBMFCAFDME
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EB62B0", Offset = "0x6EB54B0", VA = "0x186EB62B0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6290", Offset = "0x6EB5490", VA = "0x186EB6290")]
	public static PNMPBCAMODD IHPBIBCICGK(PNMPBCAMODD GGFLAOCNMAP, PNMPBCAMODD PIINDHALINJ)
	{
		return default(PNMPBCAMODD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EB61F0", Offset = "0x6EB53F0", VA = "0x186EB61F0")]
	public static PNMPBCAMODD CIOEGNONFJP(PNMPBCAMODD PNGMEMLGCGB, int HHDIDFKPEKO)
	{
		return default(PNMPBCAMODD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6210", Offset = "0x6EB5410", VA = "0x186EB6210", Slot = "0")]
	public override bool Equals(object KKIMPLLANEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB6250", Offset = "0x6EB5450", VA = "0x186EB6250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB62C0", Offset = "0x6EB54C0", VA = "0x186EB62C0", Slot = "3")]
	public override string ToString()
	{
		return null;
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
