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
public struct HJIEFPFFDOA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FIFKKDCLNHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int MLBOGDMBIHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int FLMFOCJNLAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int GMEIFCLNHOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int JBPGMDLGCGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int MBGJBLMBADK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int GDIFDOEBGEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 FLOOKCHBPLG;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x833CED0", Offset = "0x833BCD0", VA = "0x18833CED0")]
		public FIFKKDCLNHD(int LBOKDDCAPCG, int KNFFIEOCHJM, int FHFOBDIAEPO, int CFIMINGMIOJ, int JGGJBJEJLPK, int CMIHLAGKFEJ, float3 INIBGDOOLID)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct BELBENNKNHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int MHAACPOFGCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int PMKBEPBOFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float DEGFHNHGPBO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xE3D620", Offset = "0xE3C420", VA = "0x180E3D620")]
		public BELBENNKNHJ(int EFDFIDCNFKB, int CHBKHJDCLGJ, float DKAEMMPPGGA)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JDGKAMCGCDF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int PMKBEPBOFBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int LBBBLINDBAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int MBKIGNBJHFG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FIFKKDCLNHD> AJKFKMFDMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<BELBENNKNHJ> CNDKFEOCDOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> CIEPMCOCAJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JDGKAMCGCDF> NJFLHDCJFBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> CADBKPBJMGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int BEAEMEKEFEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int ABLDJPMKEGE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x833E4B0", Offset = "0x833D2B0", VA = "0x18833E4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x833E5F0", Offset = "0x833D3F0", VA = "0x18833E5F0")]
	public bool EMJIDBIKEPL([In] NativeArray<float3> HEIEEOGLLBL, NativeList<float3> OLCDGMKBEOG, NativeList<int> NCGAAPLMBDI, Allocator GIEDOJCOPKP, CancellationToken BKHGNHANFKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x833F050", Offset = "0x833DE50", VA = "0x18833F050")]
	private void IEHCJBEIMLK([In] NativeArray<float3> HEIEEOGLLBL, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x833F820", Offset = "0x833E620", VA = "0x18833F820")]
	private void JIDJAHFKPPJ([In] NativeArray<float3> HEIEEOGLLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8340870", Offset = "0x833F670", VA = "0x188340870")]
	private void KPGOAFDGFLK([In] NativeArray<float3> HEIEEOGLLBL, [Out] int PNLIAFCOEEG, [Out] int AHLFOMDINAF, [Out] int CMLOHCAILIG, [Out] int CJHBPINKGEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x833F230", Offset = "0x833E030", VA = "0x18833F230")]
	private void IJCAGIACBAO([In] NativeArray<float3> HEIEEOGLLBL, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8341200", Offset = "0x8340000", VA = "0x188341200")]
	private void LEPOEADJLEN([In] NativeArray<float3> HEIEEOGLLBL, float3 FABONEEKFMK, int CCPPDMNMNJC, FIFKKDCLNHD AJIIMKMIPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x833F430", Offset = "0x833E230", VA = "0x18833F430")]
	private void JHIOBKPADDD([In] NativeArray<float3> HEIEEOGLLBL, float3 FABONEEKFMK, int NAPHCIAJLAA, int ABLDJPMKEGE, FIFKKDCLNHD AJIIMKMIPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x83416E0", Offset = "0x83404E0", VA = "0x1883416E0")]
	private void MFFKIBMCKKE([In] NativeArray<float3> HEIEEOGLLBL, int KACIEBMCJMB, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x833EC80", Offset = "0x833DA80", VA = "0x18833EC80")]
	private void HMNGMOBPBJN([In] NativeArray<float3> HEIEEOGLLBL, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8340D30", Offset = "0x833FB30", VA = "0x188340D30")]
	private void LDOLHGHPEPL([In] NativeArray<float3> HEIEEOGLLBL, NativeList<float3> OLCDGMKBEOG, NativeList<int> NCGAAPLMBDI, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x833E840", Offset = "0x833D640", VA = "0x18833E840")]
	private float GHFALKNOGJO(float3 FABONEEKFMK, float3 OBGFAFGEMFM, FIFKKDCLNHD AJIIMKMIPPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x833E730", Offset = "0x833D530", VA = "0x18833E730")]
	private float3 FLOOKCHBPLG(float3 LBOKDDCAPCG, float3 KNFFIEOCHJM, float3 FHFOBDIAEPO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8340840", Offset = "0x833F640", VA = "0x188340840")]
	private static float JMIDJKJPAOB(float3 GENJGFGGINA, float3 KMNEIBIPMKI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x833EFF0", Offset = "0x833DDF0", VA = "0x18833EFF0")]
	private static float3 HNBDJEILBKH(float3 GENJGFGGINA, float3 KMNEIBIPMKI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x833E450", Offset = "0x833D250", VA = "0x18833E450")]
	private bool DFNFPANBIFN(float3 GENJGFGGINA, float3 KMNEIBIPMKI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x833E8A0", Offset = "0x833D6A0", VA = "0x18833E8A0")]
	private bool GJFMMFNAANO(float3 GENJGFGGINA, float3 KMNEIBIPMKI, float3 JMOOEAFLFLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x833E970", Offset = "0x833D770", VA = "0x18833E970")]
	private bool GJHPNKPLPJA(float3 GENJGFGGINA, float3 KMNEIBIPMKI, float3 JMOOEAFLFLP, float3 DKAEMMPPGGA)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct HEDLPKBFIDJ : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JHGAONGJFPJ
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
	private NativeList<float3> NIMEAJMKHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> OGGADOMBNAO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FCGFHPMOEEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x833D7A0", Offset = "0x833C5A0", VA = "0x18833D7A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DMNOHOHGALO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x833CF10", Offset = "0x833BD10", VA = "0x18833CF10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool BHENCPOLICP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x833D2A0", Offset = "0x833C0A0", VA = "0x18833D2A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DOFLGJFGIIP BELEMEGKDAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x833D6F0", Offset = "0x833C4F0", VA = "0x18833D6F0")]
		get
		{
			return default(DOFLGJFGIIP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x833E000", Offset = "0x833CE00", VA = "0x18833E000")]
	public HEDLPKBFIDJ(int MFMOEPOBJKN, int PCAFCCDIJAD, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x833E420", Offset = "0x833D220", VA = "0x18833E420")]
	public HEDLPKBFIDJ(DOFLGJFGIIP JCLKNBDMPEL, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x833DE90", Offset = "0x833CC90", VA = "0x18833DE90")]
	public HEDLPKBFIDJ(Mesh PKBJPDPONKJ, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x833E0C0", Offset = "0x833CEC0", VA = "0x18833E0C0")]
	public HEDLPKBFIDJ(HEDLPKBFIDJ KANAIIDGHCH, Allocator GIEDOJCOPKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x833D660", Offset = "0x833C460", VA = "0x18833D660", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x833D2E0", Offset = "0x833C0E0", VA = "0x18833D2E0")]
	public void DPHJBDIDPOG([In] HEDLPKBFIDJ MKPEOGPFEFH, float4x4 GJAHLELDHFH, Transform EBMIKMPNPCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x833D150", Offset = "0x833BF50", VA = "0x18833D150")]
	public void CGHMDNBFGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x833D9A0", Offset = "0x833C7A0", VA = "0x18833D9A0")]
	public void PPJJJKFBGBP(float AGKOFMHMOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x833CF50", Offset = "0x833BD50", VA = "0x18833CF50")]
	public HEDLPKBFIDJ BLPKDPIIDDD(Allocator GIEDOJCOPKP, CancellationToken BKHGNHANFKK)
	{
		return default(HEDLPKBFIDJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x833D880", Offset = "0x833C680", VA = "0x18833D880")]
	public Mesh PALJIPCNJPO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x833D7E0", Offset = "0x833C5E0", VA = "0x18833D7E0")]
	private unsafe static float3* NHOALFHAONO(NativeArray<float3> ELLFIONNNHC)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x833D830", Offset = "0x833C630", VA = "0x18833D830")]
	private unsafe static int* NHOALFHAONO(NativeArray<int> ELLFIONNNHC)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x833D770", Offset = "0x833C570", VA = "0x18833D770")]
	[CompilerGenerated]
	internal static void KDEEGJJLBNE(int KJCMINHOBDI, int IAEPEAGINPA, JHGAONGJFPJ P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DOFLGJFGIIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int FCGFHPMOEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DMNOHOHGALO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MMDAMNOMLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x833CD60", Offset = "0x833BB60", VA = "0x18833CD60")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2961640", Offset = "0x2960440", VA = "0x182961640")]
	public static DOFLGJFGIIP BONCLONNKDN(DOFLGJFGIIP GENJGFGGINA, DOFLGJFGIIP KMNEIBIPMKI)
	{
		return default(DOFLGJFGIIP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x833CE10", Offset = "0x833BC10", VA = "0x18833CE10")]
	public static DOFLGJFGIIP HJCBAOHGCNN(DOFLGJFGIIP EKLIICOPDPH, int DPBDKFEONOK)
	{
		return default(DOFLGJFGIIP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x833CD70", Offset = "0x833BB70", VA = "0x18833CD70", Slot = "0")]
	public override bool Equals(object JMDPFCIMIIE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x833CDC0", Offset = "0x833BBC0", VA = "0x18833CDC0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x833CE30", Offset = "0x833BC30", VA = "0x18833CE30", Slot = "3")]
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
