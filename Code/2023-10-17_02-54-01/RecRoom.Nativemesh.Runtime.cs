using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Unity.Burst;
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
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class IsUnmanagedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x78CB70", Offset = "0x78B370", VA = "0x18078CB70")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct BFGAGBGCMED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int MJKJPMOGGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 JELPCPDEMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion KJJBHLJCIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 MHBLHEFJOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int LBHOMMLGFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int LMLJLPKFPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int GHIPAMKIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float OELKDJNOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 HDEOGFPDMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool AFHMNHPMJLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public JGILFCFGDLO OLAMACFAHID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 KGGHHHPACLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float PFOHKINNCFH;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MBOGPMMPFMJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static OCNHFKDFPPP OKBDAIICLHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<BFGAGBGCMED> NFPPNCFFINC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<BIMDHOAHBHO> HHINBMINAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<BGJHMCHBAHC> MGLOHKCJMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<AJMDOMAJGKF> ADIFIEBOCNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<BIMDHOAHBHO> GBDJLLANMCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<GEABMLMFCJJ> HJJOLMNJPDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<AJMDOMAJGKF>> ACIEELGDLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<LLBEIELLHPH> KDKPNDGMIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> BFPNCCNHNGF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE2200", Offset = "0xAE0A00", VA = "0x180AE2200")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAE1B30", Offset = "0xAE0330", VA = "0x180AE1B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAE2210", Offset = "0xAE0A10", VA = "0x180AE2210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE1320", Offset = "0xADFB20", VA = "0x180AE1320")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D298A0", Offset = "0x5D280A0", VA = "0x185D298A0")]
	public MBOGPMMPFMJ(int FJONHKPEELC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D28F80", Offset = "0x5D27780", VA = "0x185D28F80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D290E0", Offset = "0x5D278E0", VA = "0x185D290E0")]
	public void FILLLFKPAJA(JobHandle EKJLKMKCKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D27D50", Offset = "0x5D26550", VA = "0x185D27D50")]
	public void AGGGPANEMIM(BFGAGBGCMED AELCABDCBDD, LLBEIELLHPH MJBHIMEEGDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D28FA0", Offset = "0x5D277A0", VA = "0x185D28FA0")]
	public void FBKDAMLAPLO(BGJHMCHBAHC AELCABDCBDD, NativeArray<AJMDOMAJGKF> AOHCNEBGJEO, int MCKDCMEAPDD, int NBCEJGCLIFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5D27F70", Offset = "0x5D26770", VA = "0x185D27F70")]
	public JobHandle AIMHOMJNGOI(KKLKCKNAHFG EDHNBBGPIJJ, GANOCGFNNAP FBNIDNFFAML, float3 FJGMCCJEGFO, quaternion FLNLGFLBBBF, float MOIACHKHJHD, bool GFBDKPDLMGL, int HHKPMNDOIPB = 0, int KOMHJIBOLEK = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D29560", Offset = "0x5D27D60", VA = "0x185D29560")]
	public static JobHandle OAJFAGPKPKH(JAPLAAHDOCJ IAHBPMNCGJK, KKLKCKNAHFG EDHNBBGPIJJ, BFGAGBGCMED AELCABDCBDD, JobHandle EKJLKMKCKOI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5D292B0", Offset = "0x5D27AB0", VA = "0x185D292B0")]
	public static JobHandle LFFHNAJBCLH(CODGBNKGEBM IAHBPMNCGJK, KKLKCKNAHFG EDHNBBGPIJJ, BGJHMCHBAHC AELCABDCBDD, NativeArray<AJMDOMAJGKF> AOHCNEBGJEO, int MCKDCMEAPDD, int NBCEJGCLIFB, JobHandle EKJLKMKCKOI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KOLEJEPLNLC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 DICPGLIBNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 PPHPDGDNNDB;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MNGANIKIMDH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<KOLEJEPLNLC> BEEEAOIPODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> PBAHDKPDKNP;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x768D90", Offset = "0x767590", VA = "0x180768D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x76A240", Offset = "0x768A40", VA = "0x18076A240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5D29BF0", Offset = "0x5D283F0", VA = "0x185D29BF0")]
	public MNGANIKIMDH(int ODACBGOPAOP, int EAODGDLNNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5D29AB0", Offset = "0x5D282B0", VA = "0x185D29AB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5D29B10", Offset = "0x5D28310", VA = "0x185D29B10")]
	public void FEJBCIFCIOL(MNGANIKIMDH IDGKJNNLMJO, int EPDMCMDPJPH, int AIINMNHNKBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NMDCJMOMFDL
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static MNGANIKIMDH KALHMPGCIAG;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<BIMDHOAHBHO> AEDGNAKCDJI;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] LBGAIFHOCMP;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool INPELCGDOBE;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, MNGANIKIMDH> MHLHBNEKOED;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, MNGANIKIMDH> BEFDECMOPAE;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool KEGBOPAGAJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B120", Offset = "0x5D29920", VA = "0x185D2B120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<BIMDHOAHBHO> JDGFGAONMGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5D2A410", Offset = "0x5D28C10", VA = "0x185D2A410")]
		get
		{
			return default(NativeList<BIMDHOAHBHO>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static MNGANIKIMDH NLAPIJIHDKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5D2B080", Offset = "0x5D29880", VA = "0x185D2B080")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5D29CB0", Offset = "0x5D284B0", VA = "0x185D29CB0")]
	private static void AIPMAPEIOGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A350", Offset = "0x5D28B50", VA = "0x185D2A350")]
	public static int CGMFFOJHAIP(bool FGEOMGJKOFD, int LIDEBGHNFAO, bool IJLEKIBKGPP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B050", Offset = "0x5D29850", VA = "0x185D2B050")]
	private static int MMMAOCKPIMH(int LIDEBGHNFAO, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B070", Offset = "0x5D29870", VA = "0x185D2B070")]
	private static int NLGFMDJLADC(int LIDEBGHNFAO, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A380", Offset = "0x5D28B80", VA = "0x185D2A380")]
	public static int DDHDKKKCGIM(int IPDIEBPGLHC, int LIDEBGHNFAO, int AGKJMDDPEMD, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B290", Offset = "0x5D29A90", VA = "0x185D2B290")]
	public static int OHAKPKJGHFP(int IPDIEBPGLHC, int LIDEBGHNFAO, int AGKJMDDPEMD, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AC30", Offset = "0x5D29430", VA = "0x185D2AC30")]
	public static int KADMDMMMLCC(int AGKJMDDPEMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AC20", Offset = "0x5D29420", VA = "0x185D2AC20")]
	private static int HPCNHCLNIDN(int LIDEBGHNFAO, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A7F0", Offset = "0x5D28FF0", VA = "0x185D2A7F0")]
	private static int HGBDCEKFAAM(int LIDEBGHNFAO, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AFE0", Offset = "0x5D297E0", VA = "0x185D2AFE0")]
	public static int MAIHMGBCFLF(int IPDIEBPGLHC, int LIDEBGHNFAO, int AGKJMDDPEMD, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A2C0", Offset = "0x5D28AC0", VA = "0x185D2A2C0")]
	public static int BCLGDIOKAJJ(int IPDIEBPGLHC, int LIDEBGHNFAO, int AGKJMDDPEMD, bool IONMDBLBNDD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AFC0", Offset = "0x5D297C0", VA = "0x185D2AFC0")]
	public static int LOIDBPDBGID(int AGKJMDDPEMD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B1A0", Offset = "0x5D299A0", VA = "0x185D2B1A0")]
	public static MNGANIKIMDH ODEMKAFPJDO(int LIDEBGHNFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AC40", Offset = "0x5D29440", VA = "0x185D2AC40")]
	private static MNGANIKIMDH KBKGJFJCHAH(int LIDEBGHNFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5D2AED0", Offset = "0x5D296D0", VA = "0x185D2AED0")]
	public static MNGANIKIMDH KMBKLALFCNL(int LIDEBGHNFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A4B0", Offset = "0x5D28CB0", VA = "0x185D2A4B0")]
	private static MNGANIKIMDH HEPMEJEMAEL(int LIDEBGHNFAO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5D2A810", Offset = "0x5D29010", VA = "0x185D2A810")]
	public static void HJDKKOHGCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct BGJHMCHBAHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int MGPELEFMMBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 JELPCPDEMPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion KJJBHLJCIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float MHBLHEFJOIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float ODLHALGMNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int LBHOMMLGFDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int LMLJLPKFPPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int GHIPAMKIEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool AJKLFJMGNFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool BCFKIIOHGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float OELKDJNOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 HDEOGFPDMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool NOEJLMELOLG;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct GEABMLMFCJJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int NAEPHFEGFDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int MDOHGEDEIJD;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct CODGBNKGEBM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<BGJHMCHBAHC> HIOPCPFEMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<AJMDOMAJGKF> PHFEDKGOIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<BIMDHOAHBHO> EPJGBKAMDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<GEABMLMFCJJ> KCJAACDFGIM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5D20450", Offset = "0x5D1EC50", VA = "0x185D20450")]
	public CODGBNKGEBM(NativeArray<AJMDOMAJGKF> PHFEDKGOIBP, int ALCHALOFNIJ = 1, Allocator JONICLHJBEP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5D20360", Offset = "0x5D1EB60", VA = "0x185D20360", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct EEPDFOBPEBD : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<KOLEJEPLNLC> GJEBDJDHILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> DBHLFNDDJDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<BIMDHOAHBHO> ADFKKGLJIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<BGJHMCHBAHC> HIOPCPFEMLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<AJMDOMAJGKF> PHFEDKGOIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<BIMDHOAHBHO> EPJGBKAMDJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<GEABMLMFCJJ> KCJAACDFGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int KFBNPELGJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int LIHNBJOJJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 FCLFFLFMIFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion EDLPKDDOKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 KPGKONEGPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EKPPNJBDONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LFLJKAPGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HHDELGNKKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CLBBPCFMJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NCLBOKAILDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MCDJJNOEIPB;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5D243E0", Offset = "0x5D22BE0", VA = "0x185D243E0")]
	public EEPDFOBPEBD(MBOGPMMPFMJ ECGOKBHDPHL, KKLKCKNAHFG GBDPDEOGMDA, float3 PPGKOFIEBLG, quaternion HHMGGEKGOGN, float GAFPHNLMGAD, int HHKPMNDOIPB = 0, int KOMHJIBOLEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5D241B0", Offset = "0x5D229B0", VA = "0x185D241B0")]
	public EEPDFOBPEBD(CODGBNKGEBM ECGOKBHDPHL, KKLKCKNAHFG GBDPDEOGMDA, float3 PPGKOFIEBLG, quaternion HHMGGEKGOGN, float3 GAFPHNLMGAD, int HHKPMNDOIPB = 0, int KOMHJIBOLEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5D24080", Offset = "0x5D22880", VA = "0x185D24080")]
	private float3 PBBGLEBILKD(float3 LFALCABHJFD, Matrix4x4 JJIEFGECKOC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5D239B0", Offset = "0x5D221B0", VA = "0x185D239B0")]
	private float3x3 LGPNEPADHKE(float3x3 GLFAACNJBFD, float3x3 DCIEFMOEFBL)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5D239A0", Offset = "0x5D221A0", VA = "0x185D239A0")]
	private float KIOCFFBBOPK(float DCPNEEKOHBH, float NJOINGBGDDA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5D22230", Offset = "0x5D20A30", VA = "0x185D22230", Slot = "4")]
	public void Execute(int KDCEEOJBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5D233D0", Offset = "0x5D21BD0", VA = "0x185D233D0")]
	private void IAMBGOJFILK(int NPEBAMPKMGA, float3 MCLBBPPAHAP, float3 LOKKODLNJFI, float3 EKKEIADEAFO, float PNEBFNHCLKM, bool HMGHBBFGFAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5D23540", Offset = "0x5D21D40", VA = "0x185D23540")]
	private void JNFKJMHEGFK(BGJHMCHBAHC HIAFOMJJEGH, float3 KNCGMEGNFJL, float3x3 MCLAOGPNEMN, float DCPNEEKOHBH, int FCBOBGNGLJF, int CHPHHJOBKJA, int CKOCAENHDBO, float LOHBBMECPKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5D23A30", Offset = "0x5D22230", VA = "0x185D23A30")]
	private void MLIALFPEPAO(int NPEBAMPKMGA, int AIMMGECOHJJ, BGJHMCHBAHC HIAFOMJJEGH, float3 KNCGMEGNFJL, float3x3 MCLAOGPNEMN, bool CEJLGEFCGPK, float DCPNEEKOHBH, int JFNODBJMCGB, int CBKCLDKMBOG, int CKOCAENHDBO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct JAPLAAHDOCJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<BFGAGBGCMED> DAGDCCFFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<BIMDHOAHBHO> IIFNMCMCCPI;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5D25830", Offset = "0x5D24030", VA = "0x185D25830")]
	public JAPLAAHDOCJ(int ALCHALOFNIJ, Allocator JONICLHJBEP = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5D25790", Offset = "0x5D23F90", VA = "0x185D25790", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct DLOEFOEIHGD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum BOIJEHCOAKN
	{
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		X,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Y,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Z
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	[ReadOnly]
	private NativeList<float3> OMHJFFGJHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> IKNJDLDAKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> KJHEACFMDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> OPBDBEMLKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> FHEADANFJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> MEBOLNADDDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> OOKLHCOPEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> DLONDKOOHDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<BIMDHOAHBHO> BEMLBDFJAAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<BFGAGBGCMED> DAGDCCFFPOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<BIMDHOAHBHO> IIFNMCMCCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int KFBNPELGJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int LIHNBJOJJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EKPPNJBDONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> LFLJKAPGKDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HHDELGNKKAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CLBBPCFMJKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> NCLBOKAILDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MCDJJNOEIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 KPGKONEGPGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion EDLPKDDOKKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 FCLFFLFMIFI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5D21E50", Offset = "0x5D20650", VA = "0x185D21E50")]
	public DLOEFOEIHGD(MBOGPMMPFMJ ECGOKBHDPHL, KKLKCKNAHFG GBDPDEOGMDA, float3 PPGKOFIEBLG, quaternion HHMGGEKGOGN, float GAFPHNLMGAD, int HHKPMNDOIPB = 0, int KOMHJIBOLEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5D22040", Offset = "0x5D20840", VA = "0x185D22040")]
	public DLOEFOEIHGD(JAPLAAHDOCJ AELCABDCBDD, KKLKCKNAHFG GBDPDEOGMDA, float3 PPGKOFIEBLG, quaternion HHMGGEKGOGN, float3 GAFPHNLMGAD, int HHKPMNDOIPB = 0, int KOMHJIBOLEK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5D20DF0", Offset = "0x5D1F5F0", VA = "0x185D20DF0", Slot = "4")]
	public void Execute(int KDCEEOJBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5D20A40", Offset = "0x5D1F240", VA = "0x185D20A40")]
	private void BNCBPJENIJK(float4x4 NCALCHHIFBL, int KDCEEOJBIDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5D21DE0", Offset = "0x5D205E0", VA = "0x185D21DE0")]
	private BOIJEHCOAKN PAIKDPNMALA(float3 LOKKODLNJFI)
	{
		return default(BOIJEHCOAKN);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5D21D90", Offset = "0x5D20590", VA = "0x185D21D90")]
	private float4 IFMALFGABMH(BOIJEHCOAKN FIKBJHGIJHB, int LFEFGCGCIAG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5D21D50", Offset = "0x5D20550", VA = "0x185D21D50")]
	private float2 HDJMPFHGOOB(BOIJEHCOAKN FIKBJHGIJHB, float3 MCLBBPPAHAP)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LLBEIELLHPH
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum EGCAOGCBPKC
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static LLBEIELLHPH AACEAOMGOAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 PFHBDAPBAPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 NJONFLGOLCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 JFBFKJBMEGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public EGCAOGCBPKC DAKFPFPAGLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 CPBKFNEDKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 NBFOCCENAJO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ODGHFELEPIL
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5D27740", Offset = "0x5D25F40", VA = "0x185D27740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 MMJNAKEJIJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5D272D0", Offset = "0x5D25AD0", VA = "0x185D272D0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5D27C60", Offset = "0x5D26460", VA = "0x185D27C60")]
	public LLBEIELLHPH(float3 MCLBBPPAHAP, quaternion OHMBDAJNEIJ, float3 ALCHALOFNIJ, EGCAOGCBPKC GFGNPBCFEMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5D27750", Offset = "0x5D25F50", VA = "0x185D27750")]
	public float JNDBCDLPLIK(float3 KNCGMEGNFJL, float HCELMDCFIGF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5D27B00", Offset = "0x5D26300", VA = "0x185D27B00")]
	public bool MNJAGAIMPHK(float3 LOKKODLNJFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5D27950", Offset = "0x5D26150", VA = "0x185D27950")]
	public void MNGPIJJPGBM(float3 HNCEGMJPHOO, float3x3 LKLBLGIFOEG, float JHPJNHAFOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5D27640", Offset = "0x5D25E40", VA = "0x185D27640")]
	private void GDHMHOKJAKL(float3 ELJFMFLOMJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5D273B0", Offset = "0x5D25BB0", VA = "0x185D273B0")]
	public void EEFAJDIMFHB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct KBIBMIOJICK : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<LLBEIELLHPH> AELCABDCBDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> CHEGBICLENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> GPEAFMNEBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> BFPNCCNHNGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<BIMDHOAHBHO> IIFNMCMCCPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int GEMGLACFKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int ELKBLIABCKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float HCELMDCFIGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float HIFAABPBPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> KMDDALINFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> MCLIAIDEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> NCJGILHFPIC;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5D263C0", Offset = "0x5D24BC0", VA = "0x185D263C0")]
	public KBIBMIOJICK(KKLKCKNAHFG LFKHDLANNJG, float IJJIAHHMLPK, int AIINMNHNKBO, int FCBOBGNGLJF, NativeList<LLBEIELLHPH> AELCABDCBDD, NativeArray<int> BFPNCCNHNGF, NativeList<BIMDHOAHBHO> IIFNMCMCCPI, GANOCGFNNAP FBNIDNFFAML)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5D25920", Offset = "0x5D24120", VA = "0x185D25920", Slot = "4")]
	public void Execute(int GLABAFMPIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5D26300", Offset = "0x5D24B00", VA = "0x185D26300")]
	private bool KGPHANPFKHG(LLBEIELLHPH EOFAJFKEBLN, LLBEIELLHPH DNOEGKBPKDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5D26060", Offset = "0x5D24860", VA = "0x185D26060")]
	private bool IOIEHOLNDAF(LLBEIELLHPH CLPHKIKLHHF, int GPEGBONABIP, int JCCHMDNNLHP, int NLGIJALJOOD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GANOCGFNNAP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> BHIKCAAJIKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> AIIJFCILPJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> JEIHDALBFHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> DLDAAALJHIB;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5D24670", Offset = "0x5D22E70", VA = "0x185D24670")]
	public void BMJEBKKJIJI(int ODACBGOPAOP, int EAODGDLNNLI, Allocator JONICLHJBEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5D24770", Offset = "0x5D22F70", VA = "0x185D24770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5D24790", Offset = "0x5D22F90", VA = "0x185D24790")]
	public void FILLLFKPAJA(JobHandle EKJLKMKCKOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public GANOCGFNNAP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct COMAHJGBOAL : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> CHEGBICLENI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> HNENMLLKDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> INHLJFKADOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> OAAECACCBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> GPEAFMNEBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LNNKKOMNILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> LPAFCFCGMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> KMDDALINFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> MCLIAIDEBHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int HHKPMNDOIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int KOMHJIBOLEK;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5D209C0", Offset = "0x5D1F1C0", VA = "0x185D209C0")]
	public COMAHJGBOAL(KKLKCKNAHFG LFKHDLANNJG, GANOCGFNNAP FBNIDNFFAML, int KOMHJIBOLEK = 0, int HHKPMNDOIPB = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5D205E0", Offset = "0x5D1EDE0", VA = "0x185D205E0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5D20580", Offset = "0x5D1ED80", VA = "0x185D20580")]
	private void DNNIIEKJKCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class KEGFNJALLPN
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x23FB6E0", Offset = "0x23F9EE0", VA = "0x1823FB6E0")]
	public static bool NACPKKDFBPB<T>(NativeArray<T> INLAJDDNHAO, int ALCHALOFNIJ, Allocator JONICLHJBEP, NativeArrayOptions KFCJCCKINNH = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x23FB820", Offset = "0x23FA020", VA = "0x1823FB820")]
	public static bool NACPKKDFBPB<T>(NativeList<T> HBKECNHANOP, int ALCHALOFNIJ, Allocator JONICLHJBEP) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum CGDEOGEIDJN
{
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	Near,
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	Far,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	Dynamic,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	None
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public interface LEHAEAFDDGC
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JMNELNIIDHC(CGDEOGEIDJN IPDIEBPGLHC);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JIMOENLIPGG(CGDEOGEIDJN IPDIEBPGLHC);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EEMLDMLFKKH(CGDEOGEIDJN IPDIEBPGLHC, MBOGPMMPFMJ NHLFCMKCDNB, int LEAGLNALKKH = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class KKLKCKNAHFG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int PMNICADHGKI = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> AEHPOCDPCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> HDKAOENFEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> JMLBIPBMHGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> EICOPHNKBPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> OOEHGCNGLKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> HAKPFGEOMPI;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool NJJJJBFIMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5D267C0", Offset = "0x5D24FC0", VA = "0x185D267C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5D27210", Offset = "0x5D25A10", VA = "0x185D27210")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5D27250", Offset = "0x5D25A50", VA = "0x185D27250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool DPKDDJMFOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5D27290", Offset = "0x5D25A90", VA = "0x185D27290")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5D266B0", Offset = "0x5D24EB0", VA = "0x185D266B0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5D26460", Offset = "0x5D24C60", VA = "0x185D26460")]
	public void BMJEBKKJIJI(int ODACBGOPAOP, int EAODGDLNNLI, Allocator JONICLHJBEP, bool KNMMNMOJDIE, bool CANOKGHKCAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5D26630", Offset = "0x5D24E30", VA = "0x185D26630")]
	public void CKFKECLOAGE(int ODACBGOPAOP, int EAODGDLNNLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5D26E30", Offset = "0x5D25630", VA = "0x185D26E30", Slot = "6")]
	public bool GAFLGDJKJGL(Mesh LFKHDLANNJG, bool PAHBIGNPNBM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5D26800", Offset = "0x5D25000", VA = "0x185D26800")]
	public bool FMKGJGCCFEF(Mesh LFKHDLANNJG, KKLKCKNAHFG LPOAOHHIBLF, bool PAHBIGNPNBM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
	public KKLKCKNAHFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class CNGOENCBMFI
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5D20210", Offset = "0x5D1EA10", VA = "0x185D20210")]
	public static void HJDKKOHGCCP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class CKOMLMBLOHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> AEHPOCDPCHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> HDKAOENFEPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> HEGOPEKICMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> FAJEFONBOHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> AEMHHAMLKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> HLDPNBHGKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> IMPKJJFNLDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> HAKPFGEOMPI;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FC40", Offset = "0x5D1E440", VA = "0x185D1FC40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int KBCHBEHIDMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FC80", Offset = "0x5D1E480", VA = "0x185D1FC80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int ANHOCFNNOHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5D1FCC0", Offset = "0x5D1E4C0", VA = "0x185D1FCC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FD00", Offset = "0x5D1E500", VA = "0x185D1FD00")]
	public CKOMLMBLOHJ(int ODACBGOPAOP, int EAODGDLNNLI, int IBPFJLFIENA, Allocator JONICLHJBEP = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5D1FF20", Offset = "0x5D1E720", VA = "0x185D1FF20")]
	public CKOMLMBLOHJ(Mesh LFKHDLANNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F3A0", Offset = "0x5D1DBA0", VA = "0x185D1F3A0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F4B0", Offset = "0x5D1DCB0", VA = "0x185D1F4B0")]
	public void FEJBCIFCIOL(CKOMLMBLOHJ LFKHDLANNJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5D1F7B0", Offset = "0x5D1DFB0", VA = "0x185D1F7B0")]
	private void ILLNJDFADDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5D1EE20", Offset = "0x5D1D620", VA = "0x185D1EE20")]
	private void BDPCAJMCOBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BIMDHOAHBHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int GKPGJELHNBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int OJAEFINFDLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int MNPMBALNOGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int KBCHBEHIDMM;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x106F8A0", Offset = "0x106E0A0", VA = "0x18106F8A0")]
	public BIMDHOAHBHO(int FCBOBGNGLJF, int MCKDCMEAPDD, int AIINMNHNKBO, int NBCEJGCLIFB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class OCNHFKDFPPP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<BIMDHOAHBHO> DDCDBHKJLBI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA8BA40", Offset = "0xA8A240", VA = "0x180A8BA40")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<BIMDHOAHBHO>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A61020", Offset = "0x1A5F820", VA = "0x181A61020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public CKOMLMBLOHJ LBHOJOKJOJD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x766110", Offset = "0x764910", VA = "0x180766110")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7662F0", Offset = "0x764AF0", VA = "0x1807662F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B500", Offset = "0x5D29D00", VA = "0x185D2B500")]
	public OCNHFKDFPPP(IEnumerable<CKOMLMBLOHJ> JAOGLHIIJJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5D2B490", Offset = "0x5D29C90", VA = "0x185D2B490", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum JGILFCFGDLO
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class APAOIFPNCEL
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> LCGMABLHDGF;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> PDDNLJMDIAL;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> AAEDGMPJFBJ;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> LGFKOLENFDC;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C020", Offset = "0x5D1A820", VA = "0x185D1C020")]
	public static void HJDKKOHGCCP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C250", Offset = "0x5D1AA50", VA = "0x185D1C250")]
	public static NativeArray<float2> NGDPMFJEOIF(NativeArray<float2> ALGMAOJAHFC, int JBLJGIOJDAH, NativeArray<float2> OOBLLOGBNAJ, int IJIAKEODFEE)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5D1C140", Offset = "0x5D1A940", VA = "0x185D1C140")]
	public static NativeArray<float3> NFPEPNKCNAH(NativeArray<float3> ALGMAOJAHFC, int JBLJGIOJDAH, NativeArray<float3> OOBLLOGBNAJ, int IJIAKEODFEE)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BF10", Offset = "0x5D1A710", VA = "0x185D1BF10")]
	public static NativeArray<float4> DMELFPHCPNG(NativeArray<float4> ALGMAOJAHFC, int JBLJGIOJDAH, NativeArray<float4> OOBLLOGBNAJ, int IJIAKEODFEE)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5D1BE00", Offset = "0x5D1A600", VA = "0x185D1BE00")]
	public static NativeArray<int> CBOBOFGDDLD(NativeArray<int> ALGMAOJAHFC, int JBLJGIOJDAH, NativeArray<int> OOBLLOGBNAJ, int IJIAKEODFEE)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x29BEDD0", Offset = "0x29BD5D0", VA = "0x1829BEDD0")]
	private static void NINCHLHOEED<T>(NativeArray<T> INLAJDDNHAO, int LGNKDFCJPJI) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x29BED20", Offset = "0x29BD520", VA = "0x1829BED20")]
	private static void LDCPPEHFOBB<T>(NativeArray<T> ALGMAOJAHFC, int JBLJGIOJDAH, NativeArray<T> OOBLLOGBNAJ, int IJIAKEODFEE, NativeArray<T> CJHKLKIJPPH) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class IICHIPHLBOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<LEHAEAFDDGC> MPKCABPHAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly DONEPLDDCIP GJDFMBBAOFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int MCKDCMEAPDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int NBCEJGCLIFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool ILKCGFONBLM;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh LBHOJOKJOJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x765D00", Offset = "0x764500", VA = "0x180765D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x766120", Offset = "0x764920", VA = "0x180766120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer HKEGLCEGPHI
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x76BD00", Offset = "0x76A500", VA = "0x18076BD00")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int OJAEFINFDLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5D252D0", Offset = "0x5D23AD0", VA = "0x185D252D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x1FC6C30", Offset = "0x1FC5430", VA = "0x181FC6C30")]
	public void CFJFPKAMJKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5D25670", Offset = "0x5D23E70", VA = "0x185D25670")]
	public IICHIPHLBOK(string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5D251C0", Offset = "0x5D239C0", VA = "0x185D251C0")]
	public void FILLLFKPAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5D25360", Offset = "0x5D23B60", VA = "0x185D25360")]
	public void MKNLLKIPCLO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5D24880", Offset = "0x5D23080", VA = "0x185D24880")]
	public void EAMFCEINFLN(LEHAEAFDDGC GIHFCHFNKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5D25390", Offset = "0x5D23B90", VA = "0x185D25390")]
	private void OEFHGMKBMJF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5D252F0", Offset = "0x5D23AF0", VA = "0x185D252F0")]
	public bool JPAKDDNKIIL(LEHAEAFDDGC GIHFCHFNKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5D25160", Offset = "0x5D23960", VA = "0x185D25160")]
	public bool FGLNMIBCGML(LEHAEAFDDGC GIHFCHFNKCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5D25600", Offset = "0x5D23E00", VA = "0x185D25600", Slot = "4")]
	public virtual void PJHKNDMCFNM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5D25200", Offset = "0x5D23A00", VA = "0x185D25200")]
	public void IPAPHJDHOEA(Transform CADMEIGIELD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5D24930", Offset = "0x5D23130", VA = "0x185D24930")]
	public bool FDOKOOBJAGL(Transform CADMEIGIELD, [Out] (KKLKCKNAHFG destMesh, Mesh mesh, JobHandle job) AELCABDCBDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5D250B0", Offset = "0x5D238B0", VA = "0x185D250B0")]
	public void FEDBNEFOGNK([In] (KKLKCKNAHFG destMesh, Mesh mesh, JobHandle job) AELCABDCBDD)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker DPDKCAMBHDJ;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker DIHLFDDOHOK;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker LNHOMPCNFBH;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int DFHFFBJLKKB = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		private Dictionary<Material, List<IICHIPHLBOK>> MEBHMOFCMDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<IICHIPHLBOK> DGFMIIJNPCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> ACIOPPANCMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(IICHIPHLBOK, (KKLKCKNAHFG, Mesh, JobHandle))> KOBEFIEBHDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool MMDOCKFPMCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> BKIGMLNCEJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> BPHHALLAFBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> COOJMFHLFOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> BFAEGDFFHOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private IICHIPHLBOK PEBAHPGLKHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material GLNPBKPIHFL;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> GNFKAJFIKJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x76B5B0", Offset = "0x769DB0", VA = "0x18076B5B0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DDC0", Offset = "0x5D1C5C0", VA = "0x185D1DDC0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D7E0", Offset = "0x5D1BFE0", VA = "0x185D1D7E0")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D0B0", Offset = "0x5D1B8B0", VA = "0x185D1D0B0")]
		public IICHIPHLBOK AddToBatchedMesh(LEHAEAFDDGC KFELPHPOGHI, Material JGLFCCBLACF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E030", Offset = "0x5D1C830", VA = "0x185D1E030")]
		public void RemoveFromBatchedMesh(LEHAEAFDDGC LFKHDLANNJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D640", Offset = "0x5D1BE40", VA = "0x185D1D640")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E1B0", Offset = "0x5D1C9B0", VA = "0x185D1E1B0")]
		public void SetMaterialProperty(int OJNPMCODCBJ, Color MOJKBHCPNEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E640", Offset = "0x5D1CE40", VA = "0x185D1E640")]
		public void SetMaterialProperty(int OJNPMCODCBJ, float FKKGMPDEPMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E860", Offset = "0x5D1D060", VA = "0x185D1E860")]
		public void SetMaterialProperty(int OJNPMCODCBJ, Vector4 FPINIDNLHMD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5D1E3E0", Offset = "0x5D1CBE0", VA = "0x185D1E3E0")]
		public void SetMaterialProperty(int OJNPMCODCBJ, Matrix4x4 EEBJABCLBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C360", Offset = "0x5D1AB60", VA = "0x185D1C360")]
		private void AKMNNPOFKEL(Renderer DKCPICJJNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D9C0", Offset = "0x5D1C1C0", VA = "0x185D1D9C0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5D1CB50", Offset = "0x5D1B350", VA = "0x185D1CB50")]
		private void ANEKIGFKNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5D1C950", Offset = "0x5D1B150", VA = "0x185D1C950")]
		private IICHIPHLBOK AMMJCJOFJGO(LEHAEAFDDGC LFKHDLANNJG, Material JGLFCCBLACF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DBF0", Offset = "0x5D1C3F0", VA = "0x185D1DBF0")]
		private IICHIPHLBOK OGFNHMGNONP(Material JGLFCCBLACF, int HKACNNHBEED)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D190", Offset = "0x5D1B990", VA = "0x185D1D190")]
		private IICHIPHLBOK BDIDKAGIIAO(Material JGLFCCBLACF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5D1D9D0", Offset = "0x5D1C1D0", VA = "0x185D1D9D0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5D1DA60", Offset = "0x5D1C260", VA = "0x185D1DA60")]
		public void MarkDirty(LEHAEAFDDGC LFKHDLANNJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5D1EB60", Offset = "0x5D1D360", VA = "0x185D1EB60")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class PODCMFHIOAN<KeyType> : IICHIPHLBOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, LEHAEAFDDGC> MMICKPJGCKC;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2CC0", Offset = "0x3DD14C0", VA = "0x183DD2CC0")]
	public PODCMFHIOAN(string HNHMJGCODBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2950", Offset = "0x3DD1150", VA = "0x183DD2950")]
	public void EAMFCEINFLN(KeyType OHPCNPKOLBJ, LEHAEAFDDGC GIHFCHFNKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3DD29A0", Offset = "0x3DD11A0", VA = "0x183DD29A0")]
	public bool FABAJAHCCOM(KeyType OHPCNPKOLBJ, LEHAEAFDDGC EEJKEAKMCOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2BE0", Offset = "0x3DD13E0", VA = "0x183DD2BE0")]
	public void ILEIKHMKHHL(KeyType OHPCNPKOLBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3DD2C80", Offset = "0x3DD1480", VA = "0x183DD2C80", Slot = "4")]
	public override void PJHKNDMCFNM()
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
