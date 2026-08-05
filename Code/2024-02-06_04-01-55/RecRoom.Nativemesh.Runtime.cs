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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C9520", Offset = "0x7C8920", VA = "0x1807C9520")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JJPINICKCHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GNGPAJEOIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 JNKAJCAADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion DGGNNEHGMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 DADMHJEFKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int EGILJJMFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int BLNABIPFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int DEPBGELMHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float GPHAEKCFHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 PDBIFGAGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool PCCKBFKHOKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public NOAKNDBOBFM CLPKOLLCION;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 GOIKPLHICMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float GKCMJHABCFL;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class KILMAMMLMFP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static JFHLEFPFCKO KODNLBIDBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<JJPINICKCHM> LEHHGKHOOCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<AJNAJPOHIPM> DPOAEGBNEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<AACBHEOMCEA> LFAMEIJFIOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<PMALCMJHLBP> NNPNOHEGIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<AJNAJPOHIPM> AIECEEJEIFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NNDCKOJOFOG> JONFCDFACJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<PMALCMJHLBP>> PJBIENNNMOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<JGLEGABGFEJ> KJBFLHKFFMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> NCECHNNCCCB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBA27D0", Offset = "0xBA1BD0", VA = "0x180BA27D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBA1080", Offset = "0xBA0480", VA = "0x180BA1080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LHJJKLGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBA27E0", Offset = "0xBA1BE0", VA = "0x180BA27E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBA1090", Offset = "0xBA0490", VA = "0x180BA1090")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60DB3C0", Offset = "0x60DA7C0", VA = "0x1860DB3C0")]
	public KILMAMMLMFP(int OEMGMMKPGNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60D9FA0", Offset = "0x60D93A0", VA = "0x1860D9FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60D9FC0", Offset = "0x60D93C0", VA = "0x1860D9FC0")]
	public void IEJPDCFHNJM(JobHandle POBBNOHNBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60DA190", Offset = "0x60D9590", VA = "0x1860DA190")]
	public void IHLMPPBAHGJ(JJPINICKCHM ALPLHOOHPEL, JGLEGABGFEJ ALGAMKCOHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60D9B20", Offset = "0x60D8F20", VA = "0x1860D9B20")]
	public void DLOAFDDBHKD(AACBHEOMCEA ALPLHOOHPEL, NativeArray<PMALCMJHLBP> OBHJDGEICCH, int LCIPOMAKBKD, int EDDFJNNBDBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60DA3B0", Offset = "0x60D97B0", VA = "0x1860DA3B0")]
	public JobHandle OINOMNDHKJE(IIBGMLIJNCJ DJEMOMOFHOK, AICJNBLGCFE ICHPLEOLKIE, float3 BKJBJJANPJC, quaternion NKEDGOFGLHN, float COPLIAFDPFM, bool OLIODAKFHFD, int GAMENJPMCFP = 0, int OICHGKAFPOC = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60D9C60", Offset = "0x60D9060", VA = "0x1860D9C60")]
	public static JobHandle DMLGDICMFID(EPHOBMLGKGO LJCFIHJLGIK, IIBGMLIJNCJ DJEMOMOFHOK, JJPINICKCHM ALPLHOOHPEL, JobHandle POBBNOHNBCI)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60D9870", Offset = "0x60D8C70", VA = "0x1860D9870")]
	public static JobHandle BEGEKJOAODG(FLJAOEMFLMF LJCFIHJLGIK, IIBGMLIJNCJ DJEMOMOFHOK, AACBHEOMCEA ALPLHOOHPEL, NativeArray<PMALCMJHLBP> OBHJDGEICCH, int LCIPOMAKBKD, int EDDFJNNBDBG, JobHandle POBBNOHNBCI)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MMIEADONBDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 NEINPBOIFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 CDMAJCLKHAC;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class PBHIDHBAMBB : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<MMIEADONBDI> EHIJFEPMABN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> ICKFDLBJLLN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x79E7B0", Offset = "0x79DBB0", VA = "0x18079E7B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int LHJJKLGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7A9520", Offset = "0x7A8920", VA = "0x1807A9520")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60DD050", Offset = "0x60DC450", VA = "0x1860DD050")]
	public PBHIDHBAMBB(int EJHKCNMMALE, int DIEKCCMMDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60DCF10", Offset = "0x60DC310", VA = "0x1860DCF10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x60DCF70", Offset = "0x60DC370", VA = "0x1860DCF70")]
	public void LKBFLCPJNNK(PBHIDHBAMBB JDFBDBHJNMC, int EEHJDKHGNEL, int ACGCEBPHGCG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class HIAMMHENAHE
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static PBHIDHBAMBB CJDPKGJAFFL;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<AJNAJPOHIPM> GPGLEFGBHHE;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] PHCNCJEMKJB;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool KEBCAJHBNCJ;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, PBHIDHBAMBB> NFNEBOCEKJF;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, PBHIDHBAMBB> FLNMMACEHHM;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool GPCGCJHBMPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x60D6BF0", Offset = "0x60D5FF0", VA = "0x1860D6BF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<AJNAJPOHIPM> PCKLLEDHJOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x60D7130", Offset = "0x60D6530", VA = "0x1860D7130")]
		get
		{
			return default(NativeList<AJNAJPOHIPM>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static PBHIDHBAMBB CBBIOBNPAEM
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x60D7030", Offset = "0x60D6430", VA = "0x1860D7030")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60D6170", Offset = "0x60D5570", VA = "0x1860D6170")]
	private static void ALCPLPBBIDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x60D70D0", Offset = "0x60D64D0", VA = "0x1860D70D0")]
	public static int JLCFLGINGGH(bool HBFJFEBBFEL, int JOGLCFPFJII, bool IMBEECHGCFH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x60D7110", Offset = "0x60D6510", VA = "0x1860D7110")]
	private static int JOJHEICCDPC(int JOGLCFPFJII, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60D7100", Offset = "0x60D6500", VA = "0x1860D7100")]
	private static int JNAHODCJDDC(int JOGLCFPFJII, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x60D6B60", Offset = "0x60D5F60", VA = "0x1860D6B60")]
	public static int DMHKOGCIPFM(int DBHMHAHLCPM, int JOGLCFPFJII, int EJMKGKBLIMG, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x60D6FA0", Offset = "0x60D63A0", VA = "0x1860D6FA0")]
	public static int IIHANMJPJDA(int DBHMHAHLCPM, int JOGLCFPFJII, int EJMKGKBLIMG, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x60D6F90", Offset = "0x60D6390", VA = "0x1860D6F90")]
	public static int HDLICCAOGJN(int EJMKGKBLIMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x60D6780", Offset = "0x60D5B80", VA = "0x1860D6780")]
	private static int BFOMJOKPJGK(int JOGLCFPFJII, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x60D72C0", Offset = "0x60D66C0", VA = "0x1860D72C0")]
	private static int OJODLCNJEDH(int JOGLCFPFJII, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60D6C90", Offset = "0x60D6090", VA = "0x1860D6C90")]
	public static int FENEEHBAGBN(int DBHMHAHLCPM, int JOGLCFPFJII, int EJMKGKBLIMG, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x60D6AD0", Offset = "0x60D5ED0", VA = "0x1860D6AD0")]
	public static int DCOGLJNGLDD(int DBHMHAHLCPM, int JOGLCFPFJII, int EJMKGKBLIMG, bool NNOIIFLOOIM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x60D6C70", Offset = "0x60D6070", VA = "0x1860D6C70")]
	public static int ELAMMDJBMNM(int EJMKGKBLIMG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x60D76F0", Offset = "0x60D6AF0", VA = "0x1860D76F0")]
	public static PBHIDHBAMBB PEGHMJCLNAK(int JOGLCFPFJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x60D6D00", Offset = "0x60D6100", VA = "0x1860D6D00")]
	private static PBHIDHBAMBB GNIEBDNKIIO(int JOGLCFPFJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x60D71D0", Offset = "0x60D65D0", VA = "0x1860D71D0")]
	public static PBHIDHBAMBB NJBNAKICHMK(int JOGLCFPFJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x60D6790", Offset = "0x60D5B90", VA = "0x1860D6790")]
	private static PBHIDHBAMBB BIALEJHALPL(int JOGLCFPFJII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x60D72E0", Offset = "0x60D66E0", VA = "0x1860D72E0")]
	public static void OKEODJJHIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct AACBHEOMCEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int LIHBCHBAAJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 JNKAJCAADMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion DGGNNEHGMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float DADMHJEFKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float DGEBLKFKOEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int EGILJJMFIGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int BLNABIPFJBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int DEPBGELMHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool PPFEFLEKHKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool KOBHLONOGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float GPHAEKCFHJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 PDBIFGAGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool ICDMEJJKDGL;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NNDCKOJOFOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int OIBODGAHKDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int DBIIDEIEABH;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct FLJAOEMFLMF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<AACBHEOMCEA> ELJJCKKNJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<PMALCMJHLBP> EEMKGLCFPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<AJNAJPOHIPM> DBKBDJGJIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<NNDCKOJOFOG> LNLCMBLBHFM;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60D2810", Offset = "0x60D1C10", VA = "0x1860D2810")]
	public FLJAOEMFLMF(NativeArray<PMALCMJHLBP> EEMKGLCFPEA, int HFPFBPPBALK = 1, Allocator OLAJGHFDGHM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60D2720", Offset = "0x60D1B20", VA = "0x1860D2720", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct HBLCDLFJKJA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<MMIEADONBDI> DAHHLEBBJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> HFDLDACBIDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<AJNAJPOHIPM> MPJIEIFONJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<AACBHEOMCEA> ELJJCKKNJPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<PMALCMJHLBP> EEMKGLCFPEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<AJNAJPOHIPM> DBKBDJGJIMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<NNDCKOJOFOG> LNLCMBLBHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int IJPFIJGCKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int FPOLLKPFACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 CCBJLHLCELL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion MKHPNFDHOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 OPNCEOBAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CLIJHAKPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EIIECCFDGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IHEKBBAAOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LGHLHGNKNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MKLJJBMNILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HDDMBNKBJFD;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x60D5CB0", Offset = "0x60D50B0", VA = "0x1860D5CB0")]
	public HBLCDLFJKJA(KILMAMMLMFP KLFDMMNLGMM, IIBGMLIJNCJ POHIKFIJCLO, float3 DMNMHHOEGCJ, quaternion GDMALDBBOAO, float FBHMFDGBCLC, int GAMENJPMCFP = 0, int OICHGKAFPOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x60D5F40", Offset = "0x60D5340", VA = "0x1860D5F40")]
	public HBLCDLFJKJA(FLJAOEMFLMF KLFDMMNLGMM, IIBGMLIJNCJ POHIKFIJCLO, float3 DMNMHHOEGCJ, quaternion GDMALDBBOAO, float3 FBHMFDGBCLC, int GAMENJPMCFP = 0, int OICHGKAFPOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x60D5B80", Offset = "0x60D4F80", VA = "0x1860D5B80")]
	private float3 NMHAMEOPMCG(float3 AGPEIBFAHHJ, Matrix4x4 GBADPJEKGCD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x60D5B00", Offset = "0x60D4F00", VA = "0x1860D5B00")]
	private float3x3 NBIAMPDCNFK(float3x3 BMFCGJFEALD, float3x3 BBMONPPPHAF)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x60D5980", Offset = "0x60D4D80", VA = "0x1860D5980")]
	private float JCJJCPJJICI(float LFBOEHOBPJC, float JBBGBEBPHCI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60D4190", Offset = "0x60D3590", VA = "0x1860D4190", Slot = "4")]
	public void Execute(int NGKFFMDAGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60D5990", Offset = "0x60D4D90", VA = "0x1860D5990")]
	private void LJMBGLLCGAL(int FHMNPMJCOBC, float3 BEBKKMFGLCG, float3 PKPPJECMOIC, float3 FNLHDMNBHFE, float CABLJKKDANE, bool HLGACBMMNMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60D3D30", Offset = "0x60D3130", VA = "0x1860D3D30")]
	private void CCNKONIAMMN(AACBHEOMCEA KIHNKJGKPOO, float3 KGGMKBFJBJC, float3x3 PDMDMCJFOIG, float LFBOEHOBPJC, int FMPGEDJHDKB, int DJOBJLAEGIP, int PNNGIJFCDKD, float KJJKOEACLDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60D5330", Offset = "0x60D4730", VA = "0x1860D5330")]
	private void GKDLHBPNJLH(int FHMNPMJCOBC, int CINFHKFPIHP, AACBHEOMCEA KIHNKJGKPOO, float3 KGGMKBFJBJC, float3x3 PDMDMCJFOIG, bool BMKFPJBBOCD, float LFBOEHOBPJC, int OFMKOKIDBJJ, int HAACADEAINM, int PNNGIJFCDKD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct EPHOBMLGKGO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<JJPINICKCHM> MINLLFDEFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<AJNAJPOHIPM> ONJLJBGMMCC;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60D2630", Offset = "0x60D1A30", VA = "0x1860D2630")]
	public EPHOBMLGKGO(int HFPFBPPBALK, Allocator OLAJGHFDGHM = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x60D2590", Offset = "0x60D1990", VA = "0x1860D2590", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct MCCKCKAOINH : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum FFKHLMHHEFJ
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
	private NativeList<float3> HPGOGLPAKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> OJJNBLFLFPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> PAJILMDOMHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> PBBDOMPKKDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> JOBDCFJFOFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> KKGKNLJGJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> LBJAGPFNGJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> JNIMJCEGIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<AJNAJPOHIPM> HLNAGLNFBJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<JJPINICKCHM> MINLLFDEFPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<AJNAJPOHIPM> ONJLJBGMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int IJPFIJGCKLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int FPOLLKPFACB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> CLIJHAKPAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EIIECCFDGJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IHEKBBAAOIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LGHLHGNKNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> MKLJJBMNILM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HDDMBNKBJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 OPNCEOBAHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion MKHPNFDHOMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 CCBJLHLCELL;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60DCB30", Offset = "0x60DBF30", VA = "0x1860DCB30")]
	public MCCKCKAOINH(KILMAMMLMFP KLFDMMNLGMM, IIBGMLIJNCJ POHIKFIJCLO, float3 DMNMHHOEGCJ, quaternion GDMALDBBOAO, float FBHMFDGBCLC, int GAMENJPMCFP = 0, int OICHGKAFPOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x60DCD20", Offset = "0x60DC120", VA = "0x1860DCD20")]
	public MCCKCKAOINH(EPHOBMLGKGO ALPLHOOHPEL, IIBGMLIJNCJ POHIKFIJCLO, float3 DMNMHHOEGCJ, quaternion GDMALDBBOAO, float3 FBHMFDGBCLC, int GAMENJPMCFP = 0, int OICHGKAFPOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x60DB760", Offset = "0x60DAB60", VA = "0x1860DB760", Slot = "4")]
	public void Execute(int NGKFFMDAGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x60DC710", Offset = "0x60DBB10", VA = "0x1860DC710")]
	private void GEPHNIJNEAO(float4x4 FFDIMAKEMJI, int NGKFFMDAGOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x60DCAC0", Offset = "0x60DBEC0", VA = "0x1860DCAC0")]
	private FFKHLMHHEFJ GFOOBHHEBIE(float3 PKPPJECMOIC)
	{
		return default(FFKHLMHHEFJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x60DC6C0", Offset = "0x60DBAC0", VA = "0x1860DC6C0")]
	private float4 FEFPPOIHBKG(FFKHLMHHEFJ DDHKKPPIILC, int AHDNEIKOMIB)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x60DB720", Offset = "0x60DAB20", VA = "0x1860DB720")]
	private float2 EEEIKMEGBLN(FFKHLMHHEFJ DDHKKPPIILC, float3 BEBKKMFGLCG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct JGLEGABGFEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum NIODCACIDHA
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static JGLEGABGFEJ IEOIBINPDHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 EAICKOBNBAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 DDBFLIHMHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 COAOMNLBCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public NIODCACIDHA KEFOPLEGHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 MINECLIMFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 GJAAKFDGMFE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OPNBALCMBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60D8EE0", Offset = "0x60D82E0", VA = "0x1860D8EE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 OOKHHOCIIJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60D9630", Offset = "0x60D8A30", VA = "0x1860D9630")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x60D9780", Offset = "0x60D8B80", VA = "0x1860D9780")]
	public JGLEGABGFEJ(float3 BEBKKMFGLCG, quaternion IKFFGJBHBIC, float3 HFPFBPPBALK, NIODCACIDHA FICJMFBEBIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x60D91A0", Offset = "0x60D85A0", VA = "0x1860D91A0")]
	public float IOLLCBJPPKI(float3 KGGMKBFJBJC, float BCDDIDACMCF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x60D8DF0", Offset = "0x60D81F0", VA = "0x1860D8DF0")]
	public bool DKEKEGAMJHO(float3 PKPPJECMOIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60D8FF0", Offset = "0x60D83F0", VA = "0x1860D8FF0")]
	public void IIKHMBGEAPM(float3 IKEHFDAOBJC, float3x3 IFKFBGMKEAG, float LNICJDFDOJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60D8EF0", Offset = "0x60D82F0", VA = "0x1860D8EF0")]
	private void HFMPJMHMHMH(float3 GODCLMMKACL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x60D93A0", Offset = "0x60D87A0", VA = "0x1860D93A0")]
	public void PEMENPBJGCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct DCINOOEDPOA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<JGLEGABGFEJ> ALPLHOOHPEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> HDAGLFHKKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> BGEBJBDEGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> NCECHNNCCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<AJNAJPOHIPM> ONJLJBGMMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int AAAAIIOEHLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int BBGABCDMHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float BCDDIDACMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float JIDKKCKHNMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> APMBELHFFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> BEFPKCEJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> ECGFGADGAHH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x60D24F0", Offset = "0x60D18F0", VA = "0x1860D24F0")]
	public DCINOOEDPOA(IIBGMLIJNCJ FEBNKEJJFPJ, float CANJHPDIOIH, int ACGCEBPHGCG, int FMPGEDJHDKB, NativeList<JGLEGABGFEJ> ALPLHOOHPEL, NativeArray<int> NCECHNNCCCB, NativeList<AJNAJPOHIPM> ONJLJBGMMCC, AICJNBLGCFE ICHPLEOLKIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60D1B10", Offset = "0x60D0F10", VA = "0x1860D1B10", Slot = "4")]
	public void Execute(int NHLEBJGNKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60D1A50", Offset = "0x60D0E50", VA = "0x1860D1A50")]
	private bool AMAODKJMEDI(JGLEGABGFEJ KHCOFGFJDMP, JGLEGABGFEJ NFAPJGNODPK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x60D2250", Offset = "0x60D1650", VA = "0x1860D2250")]
	private bool IBJGCCEFGHP(JGLEGABGFEJ LFKLKICGBJN, int GNGAKMOKFLI, int HKNFLBOFOOO, int AJNPHGDNHDL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class AICJNBLGCFE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> IFAPOANCJLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> FDCJOHJJCLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> MINFNNGCLKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> CEBPMPMEDMA;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60CDED0", Offset = "0x60CD2D0", VA = "0x1860CDED0")]
	public void GKILOBOBKLP(int EJHKCNMMALE, int DIEKCCMMDCD, Allocator OLAJGHFDGHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60CDEB0", Offset = "0x60CD2B0", VA = "0x1860CDEB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60CDFD0", Offset = "0x60CD3D0", VA = "0x1860CDFD0")]
	public void IEJPDCFHNJM(JobHandle POBBNOHNBCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public AICJNBLGCFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct ABAJHNBCCNK : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> HDAGLFHKKJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> OPIIKILHMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> BFNLJKMKENN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> BNBIFLBFCOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> BGEBJBDEGJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> CEEMEFDHFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> HOCIHMNLKIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> APMBELHFFIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> BEFPKCEJLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int GAMENJPMCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int OICHGKAFPOC;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60CDE30", Offset = "0x60CD230", VA = "0x1860CDE30")]
	public ABAJHNBCCNK(IIBGMLIJNCJ FEBNKEJJFPJ, AICJNBLGCFE ICHPLEOLKIE, int OICHGKAFPOC = 0, int GAMENJPMCFP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60CD9F0", Offset = "0x60CCDF0", VA = "0x1860CD9F0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x60CDDD0", Offset = "0x60CD1D0", VA = "0x1860CDDD0")]
	private void OADJHJDOCGN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BGFDAHBMMMI
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x245DD70", Offset = "0x245D170", VA = "0x18245DD70")]
	public static bool GHBEJCHNAPG<T>(NativeArray<T> MGNOJHKHDPK, int HFPFBPPBALK, Allocator OLAJGHFDGHM, NativeArrayOptions GGBINCNBHKJ = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x245DE10", Offset = "0x245D210", VA = "0x18245DE10")]
	public static bool GHBEJCHNAPG<T>(NativeList<T> PHHAAPDMADG, int HFPFBPPBALK, Allocator OLAJGHFDGHM) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum ECCMJPDPIEF
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
public interface KEHANMPPLDL
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int JJMFNCOHHKE(ECCMJPDPIEF DBHMHAHLCPM);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int PDDLFMJFEBJ(ECCMJPDPIEF DBHMHAHLCPM);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MEMHJIINJJC(ECCMJPDPIEF DBHMHAHLCPM, KILMAMMLMFP POCCMIKDLPB, int DHOIJHBLAFE = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class IIBGMLIJNCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int IMIKDMIIACH = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> JPLOAPGMHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> MOIJFNMLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> KPHLMBFKKKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> JMFIJHCMDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> IMDJLPEHBFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> BMIAGIDNGIG;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool PFEHLHJGPIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60D8090", Offset = "0x60D7490", VA = "0x1860D8090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x60D8780", Offset = "0x60D7B80", VA = "0x1860D8780")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int LHJJKLGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60D7990", Offset = "0x60D6D90", VA = "0x1860D7990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ENIOKIMHPNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x60D7950", Offset = "0x60D6D50", VA = "0x1860D7950")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60D7DB0", Offset = "0x60D71B0", VA = "0x1860D7DB0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60D7EC0", Offset = "0x60D72C0", VA = "0x1860D7EC0")]
	public void GKILOBOBKLP(int EJHKCNMMALE, int DIEKCCMMDCD, Allocator OLAJGHFDGHM, bool EAGEFPNLPBJ, bool CPHFGIENLOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60D8700", Offset = "0x60D7B00", VA = "0x1860D8700")]
	public void JHKFNAAACNF(int EJHKCNMMALE, int DIEKCCMMDCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x60D79D0", Offset = "0x60D6DD0", VA = "0x1860D79D0", Slot = "6")]
	public bool DJMLCGODPFM(Mesh FEBNKEJJFPJ, bool ACAMJOIPBCP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60D80D0", Offset = "0x60D74D0", VA = "0x1860D80D0")]
	public bool IOFAKOMDDBI(Mesh FEBNKEJJFPJ, IIBGMLIJNCJ INJMEBGDELL, bool ACAMJOIPBCP = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
	public IIBGMLIJNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class LFPMPCLKDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x60DB5D0", Offset = "0x60DA9D0", VA = "0x1860DB5D0")]
	public static void OKEODJJHIKA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class FPNDIDHEHDF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> JPLOAPGMHAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> MOIJFNMLKNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> DFLGBDBPEHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> ODBHJIGNLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> OCBJPEBPEOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> IELNLNICBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> EAJHMLDDHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> BMIAGIDNGIG;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60D37E0", Offset = "0x60D2BE0", VA = "0x1860D37E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int LHJJKLGJPIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60D2EC0", Offset = "0x60D22C0", VA = "0x1860D2EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int NANHHFHFNOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60D34A0", Offset = "0x60D28A0", VA = "0x1860D34A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x60D3820", Offset = "0x60D2C20", VA = "0x1860D3820")]
	public FPNDIDHEHDF(int EJHKCNMMALE, int DIEKCCMMDCD, int JEHKPAEMLLN, Allocator OLAJGHFDGHM = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x60D3A40", Offset = "0x60D2E40", VA = "0x1860D3A40")]
	public FPNDIDHEHDF(Mesh FEBNKEJJFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x60D2F00", Offset = "0x60D2300", VA = "0x1860D2F00", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x60D34E0", Offset = "0x60D28E0", VA = "0x1860D34E0")]
	public void LKBFLCPJNNK(FPNDIDHEHDF FEBNKEJJFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x60D3010", Offset = "0x60D2410", VA = "0x1860D3010")]
	private void ELJJNAGOCDE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60D2940", Offset = "0x60D1D40", VA = "0x1860D2940")]
	private void BLIAACGDMNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AJNAJPOHIPM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int HEDJOODPKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int JIPENEKAMNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int LIGDHPGPDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int LHJJKLGJPIP;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x11697B0", Offset = "0x1168BB0", VA = "0x1811697B0")]
	public AJNAJPOHIPM(int FMPGEDJHDKB, int LCIPOMAKBKD, int ACGCEBPHGCG, int EDDFJNNBDBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class JFHLEFPFCKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<AJNAJPOHIPM> FKCIFHPLAEM
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB51610", Offset = "0xB50A10", VA = "0x180B51610")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<AJNAJPOHIPM>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1BCBFB0", Offset = "0x1BCB3B0", VA = "0x181BCBFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public FPNDIDHEHDF FGOOIBKPIIC
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7A2680", Offset = "0x7A1A80", VA = "0x1807A2680")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7A2710", Offset = "0x7A1B10", VA = "0x1807A2710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60D8830", Offset = "0x60D7C30", VA = "0x1860D8830")]
	public JFHLEFPFCKO(IEnumerable<FPNDIDHEHDF> AOPBLIMBHCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x60D87C0", Offset = "0x60D7BC0", VA = "0x1860D87C0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum NOAKNDBOBFM
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PPIENJGAFNO
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> MKFJIIBLCOM;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> FMLKKBEOCEF;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> AHJNECOMKNL;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> BOHAAHPLABL;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x60DD440", Offset = "0x60DC840", VA = "0x1860DD440")]
	public static void OKEODJJHIKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x60DD330", Offset = "0x60DC730", VA = "0x1860DD330")]
	public static NativeArray<float2> OCACMFOEKNA(NativeArray<float2> DEDGKEFKAGE, int BEIFHMHKHAJ, NativeArray<float2> GJOMIFJPBBE, int AHKCGPKKKJB)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x60DD560", Offset = "0x60DC960", VA = "0x1860DD560")]
	public static NativeArray<float3> PMDELGBNGKD(NativeArray<float3> DEDGKEFKAGE, int BEIFHMHKHAJ, NativeArray<float3> GJOMIFJPBBE, int AHKCGPKKKJB)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x60DD110", Offset = "0x60DC510", VA = "0x1860DD110")]
	public static NativeArray<float4> JFGKJMIIIPL(NativeArray<float4> DEDGKEFKAGE, int BEIFHMHKHAJ, NativeArray<float4> GJOMIFJPBBE, int AHKCGPKKKJB)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x60DD220", Offset = "0x60DC620", VA = "0x1860DD220")]
	public static NativeArray<int> LKOLIDHDFIJ(NativeArray<int> DEDGKEFKAGE, int BEIFHMHKHAJ, NativeArray<int> GJOMIFJPBBE, int AHKCGPKKKJB)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x282AB70", Offset = "0x2829F70", VA = "0x18282AB70")]
	private static void ABDDENIKCOD<T>(NativeArray<T> MGNOJHKHDPK, int ILHKALFJNND) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x282AD70", Offset = "0x282A170", VA = "0x18282AD70")]
	private static void NGDCBFOCMMB<T>(NativeArray<T> DEDGKEFKAGE, int BEIFHMHKHAJ, NativeArray<T> GJOMIFJPBBE, int AHKCGPKKKJB, NativeArray<T> DIALPIJPJNK) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class BFBNKDKOHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<KEHANMPPLDL> DBBLFAFCFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LKOBEBLODOA DHGPJBABLLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int LCIPOMAKBKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int EDDFJNNBDBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool HLHIGKGMPJL;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh FGOOIBKPIIC
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7A26F0", Offset = "0x7A1AF0", VA = "0x1807A26F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x7A26A0", Offset = "0x7A1AA0", VA = "0x1807A26A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer NKCBOALNLDE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7A26B0", Offset = "0x7A1AB0", VA = "0x1807A26B0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JIPENEKAMNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60CEE20", Offset = "0x60CE220", VA = "0x1860CEE20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x21B82A0", Offset = "0x21B76A0", VA = "0x1821B82A0")]
	public void MCDKAPLJNAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60CEEB0", Offset = "0x60CE2B0", VA = "0x1860CEEB0")]
	public BFBNKDKOHAL(string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x60CED50", Offset = "0x60CE150", VA = "0x1860CED50")]
	public void IEJPDCFHNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x60CEDF0", Offset = "0x60CE1F0", VA = "0x1860CEDF0")]
	public void KBJPFIBPBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x60CECA0", Offset = "0x60CE0A0", VA = "0x1860CECA0")]
	public void IDHFFALEPIO(KEHANMPPLDL HBDKHONMHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60CE8B0", Offset = "0x60CDCB0", VA = "0x1860CE8B0")]
	private void BBCFCLFDHPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x60CE840", Offset = "0x60CDC40", VA = "0x1860CE840")]
	public bool AMBNAFLCDEN(KEHANMPPLDL HBDKHONMHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60CED90", Offset = "0x60CE190", VA = "0x1860CED90")]
	public bool JKHAEKACGLL(KEHANMPPLDL HBDKHONMHAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x60CEE40", Offset = "0x60CE240", VA = "0x1860CEE40", Slot = "4")]
	public virtual void ODDLKAJDCGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x60CEBD0", Offset = "0x60CDFD0", VA = "0x1860CEBD0")]
	public void FEANCGLIFKK(Transform EAIDDIJMLKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60CE0C0", Offset = "0x60CD4C0", VA = "0x1860CE0C0")]
	public bool ABDBMHPBELF(Transform EAIDDIJMLKJ, [Out] (IIBGMLIJNCJ destMesh, Mesh mesh, JobHandle job) ALPLHOOHPEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60CEB20", Offset = "0x60CDF20", VA = "0x1860CEB20")]
	public void COAHMMDLFCM([In] (IIBGMLIJNCJ destMesh, Mesh mesh, JobHandle job) ALPLHOOHPEL)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker FCGJENEJOLE;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker LGNHDOIOBNL;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker IPKPFMMLBMM;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int JDBPBCALLMN = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private ICANAFEODIJ NKKKCAGNADN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[SerializeField]
		private bool receiveShadows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[SerializeField]
		private ShadowCastingMode shadowCastingMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private Dictionary<Material, List<BFBNKDKOHAL>> EDBJACFFMPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<BFBNKDKOHAL> IDHBANANBAN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<MeshRenderer> GPJPLHJKDME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private List<(BFBNKDKOHAL, (IIBGMLIJNCJ, Mesh, JobHandle))> BJBHJJMHFDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private bool GPJIKJNMLBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, float> EMEKFDAGDKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Color> FCGDLFAMCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Vector4> PPPMCCMKJMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private Dictionary<int, Matrix4x4> CAJDACEHBHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private BFBNKDKOHAL POAFKDLKKOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private Material JNIBAOCHHDI;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> HFJLCDFDLCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x7A4970", Offset = "0x7A3D70", VA = "0x1807A4970")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x60D09D0", Offset = "0x60CFDD0", VA = "0x1860D09D0")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x60CF690", Offset = "0x60CEA90", VA = "0x1860CF690")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x60CEFD0", Offset = "0x60CE3D0", VA = "0x1860CEFD0")]
		public BFBNKDKOHAL AddToBatchedMesh(KEHANMPPLDL DPDLIEGEJLP, Material LNKFECCMIIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x60D0C60", Offset = "0x60D0060", VA = "0x1860D0C60")]
		public void RemoveFromBatchedMesh(KEHANMPPLDL FEBNKEJJFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x60CF0B0", Offset = "0x60CE4B0", VA = "0x1860CF0B0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x60D0DE0", Offset = "0x60D01E0", VA = "0x1860D0DE0")]
		public void SetMaterialProperty(int BLGMLDLMDIJ, Color MNHFMCFPMMK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x60D1270", Offset = "0x60D0670", VA = "0x1860D1270")]
		public void SetMaterialProperty(int BLGMLDLMDIJ, float ANJCCKHBJJO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x60D1490", Offset = "0x60D0890", VA = "0x1860D1490")]
		public void SetMaterialProperty(int BLGMLDLMDIJ, Vector4 ILHNKDNBFLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x60D1010", Offset = "0x60D0410", VA = "0x1860D1010")]
		public void SetMaterialProperty(int BLGMLDLMDIJ, Matrix4x4 NLLKEIABAFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x60CFDE0", Offset = "0x60CF1E0", VA = "0x1860CFDE0")]
		private void INOCKKODAAF(Renderer PFFFLMMGJDB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x60CFDD0", Offset = "0x60CF1D0", VA = "0x1860CFDD0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60CF870", Offset = "0x60CEC70", VA = "0x1860CF870")]
		private void FJGEDENNHGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60D03D0", Offset = "0x60CF7D0", VA = "0x1860D03D0")]
		private BFBNKDKOHAL KCCNIIDGMGJ(KEHANMPPLDL FEBNKEJJFPJ, Material LNKFECCMIIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x60D05D0", Offset = "0x60CF9D0", VA = "0x1860D05D0")]
		private BFBNKDKOHAL LMADLMGDJBO(Material LNKFECCMIIP, int JFCPJFKEELK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x60CF1E0", Offset = "0x60CE5E0", VA = "0x1860CF1E0")]
		private BFBNKDKOHAL DFCBLODDCPF(Material LNKFECCMIIP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x60D07A0", Offset = "0x60CFBA0", VA = "0x1860D07A0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x60D0840", Offset = "0x60CFC40", VA = "0x1860D0840")]
		public void MarkDirty(KEHANMPPLDL FEBNKEJJFPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60D1790", Offset = "0x60D0B90", VA = "0x1860D1790")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class CELOOHMGOGA<KeyType> : BFBNKDKOHAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly Dictionary<KeyType, KEHANMPPLDL> PLHFDMGBOOP;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x492B840", Offset = "0x492AC40", VA = "0x18492B840")]
	public CELOOHMGOGA(string GFBABMFGHOJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x492B4D0", Offset = "0x492A8D0", VA = "0x18492B4D0")]
	public void IDHFFALEPIO(KeyType GPGELODKPOB, KEHANMPPLDL HBDKHONMHAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x492B730", Offset = "0x492AB30", VA = "0x18492B730")]
	public bool NACJHAHJFHH(KeyType GPGELODKPOB, KEHANMPPLDL HGGLCGCHEHL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x492B5C0", Offset = "0x492A9C0", VA = "0x18492B5C0")]
	public void LFOEAPFNJMN(KeyType GPGELODKPOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x492B800", Offset = "0x492AC00", VA = "0x18492B800", Slot = "4")]
	public override void ODDLKAJDCGJ()
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
