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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BAB50", Offset = "0x7B9F50", VA = "0x1807BAB50")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FCFPPJDEJFH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int NDHBNAIAHBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 EIOOHIIIMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion ILFJIEKDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 LLPEOMKHKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int AEACPPPKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int JPJAEGPCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int JHFGDOJMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float FOOJHBNJGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 LLBMOFOPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool LDOENABMFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public EHHJHCCOHIE ICKMEMGNALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 EAJIHNBJGOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float DAMDEHCBCIC;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FNBJHMOKFAD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static LMGDOMPFPAG GBPLJKDBLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<FCFPPJDEJFH> PGEMBDKMBOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<AMCGOOGDBIH> PFAMFOKFKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<EFFBKBOAFFE> ODPBCDIBAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<BDKBILEBILB> DGJGHOMMJPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<AMCGOOGDBIH> IPEEMGHLMIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<NEPCCLILJEM> PCJCCFAKPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<BDKBILEBILB>> GHOJOEBBNIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<CHPGFKDHDHI> OHIHOGJOJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> HNPMAEDGLAL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xBA52F0", Offset = "0xBA46F0", VA = "0x180BA52F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xBA4960", Offset = "0xBA3D60", VA = "0x180BA4960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HCAGCMKLGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBA5300", Offset = "0xBA4700", VA = "0x180BA5300")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBA3C00", Offset = "0xBA3000", VA = "0x180BA3C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60629D0", Offset = "0x6061DD0", VA = "0x1860629D0")]
	public FNBJHMOKFAD(int AGMOFDCGHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60613E0", Offset = "0x60607E0", VA = "0x1860613E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6061540", Offset = "0x6060940", VA = "0x186061540")]
	public void ILMOPHDNONE(JobHandle JCIHDGOOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6060E80", Offset = "0x6060280", VA = "0x186060E80")]
	public void BELDJPJAFIE(FCFPPJDEJFH GMLIPIALCHN, CHPGFKDHDHI AFNAPCNDNGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6061400", Offset = "0x6060800", VA = "0x186061400")]
	public void FIINCMFPPLC(EFFBKBOAFFE GMLIPIALCHN, NativeArray<BDKBILEBILB> LBCEDJBCKLG, int GGLNOCBEHJJ, int IDHFPPGCGPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6061710", Offset = "0x6060B10", VA = "0x186061710")]
	public JobHandle JLIKNLLLGHP(HLIKNHCLNCJ BMCJCIPEDIB, EPCMKMDFCOH AFENAJJCLNK, float3 CCFJCMLMKID, quaternion MONDAFNNBGH, float BAHPPHPFNIO, bool BNDNJNDFLOF, int PAHBMFIFLIK = 0, int BOHGEDMNBBI = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60610A0", Offset = "0x60604A0", VA = "0x1860610A0")]
	public static JobHandle CHABOLLEPLA(ONHHDAJLBEL KOBDFLDGMGH, HLIKNHCLNCJ BMCJCIPEDIB, FCFPPJDEJFH GMLIPIALCHN, JobHandle JCIHDGOOBEB)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6062720", Offset = "0x6061B20", VA = "0x186062720")]
	public static JobHandle LHNMHFPOJFL(PKFIHKBMHMJ KOBDFLDGMGH, HLIKNHCLNCJ BMCJCIPEDIB, EFFBKBOAFFE GMLIPIALCHN, NativeArray<BDKBILEBILB> LBCEDJBCKLG, int GGLNOCBEHJJ, int IDHFPPGCGPE, JobHandle JCIHDGOOBEB)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MLOLCILBKAL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 KOGNFLAHADF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 OJGIAAAKMFF;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class BFCPJNPAEDJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<MLOLCILBKAL> FEGLPMHEOJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> HNOLMEDJPDD;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78F1D0", Offset = "0x78E5D0", VA = "0x18078F1D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int HCAGCMKLGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x797290", Offset = "0x796690", VA = "0x180797290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x605CB40", Offset = "0x605BF40", VA = "0x18605CB40")]
	public BFCPJNPAEDJ(int CNCMNKLBLAL, int EJAGODJFIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x605CA00", Offset = "0x605BE00", VA = "0x18605CA00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x605CA60", Offset = "0x605BE60", VA = "0x18605CA60")]
	public void NKJIKCGDGFK(BFCPJNPAEDJ CLJEMCCCAOE, int DMHDIPANOKL, int PNHIOPPHDJO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class JBOMMLNADFI
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static BFCPJNPAEDJ FBMNCGGIOBB;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<AMCGOOGDBIH> CCBKMAHPKFA;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] MMBBCDPOEKM;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool KGOIFBPIJCE;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, BFCPJNPAEDJ> DMMNKMDFOJC;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, BFCPJNPAEDJ> MPBFLJDFGGK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool AEJMHLCBBKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6066BC0", Offset = "0x6065FC0", VA = "0x186066BC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<AMCGOOGDBIH> NFECGFKFLNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6067670", Offset = "0x6066A70", VA = "0x186067670")]
		get
		{
			return default(NativeList<AMCGOOGDBIH>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static BFCPJNPAEDJ NCHKHDICIFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6066500", Offset = "0x6065900", VA = "0x186066500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x60665B0", Offset = "0x60659B0", VA = "0x1860665B0")]
	private static void EIHJHPGIOPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6067150", Offset = "0x6066550", VA = "0x186067150")]
	public static int JCCCKGGCDAI(bool IBBLFODLOFA, int FCGCFNLNKJN, bool CGGIBMNMKOC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6067650", Offset = "0x6066A50", VA = "0x186067650")]
	private static int NHAINMPCIJK(int FCGCFNLNKJN, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x60665A0", Offset = "0x60659A0", VA = "0x1860665A0")]
	private static int DMBPKCKFOBA(int FCGCFNLNKJN, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6067730", Offset = "0x6066B30", VA = "0x186067730")]
	public static int OPHFGCGHPBD(int NBPAIKKEFCG, int FCGCFNLNKJN, int DBOIMIFOHOH, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6067180", Offset = "0x6066580", VA = "0x186067180")]
	public static int JMNHIBBNPKF(int NBPAIKKEFCG, int FCGCFNLNKJN, int DBOIMIFOHOH, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6067140", Offset = "0x6066540", VA = "0x186067140")]
	public static int IMAACMAFBDG(int DBOIMIFOHOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6066240", Offset = "0x6065640", VA = "0x186066240")]
	private static int AEFCMFIFMME(int FCGCFNLNKJN, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6067710", Offset = "0x6066B10", VA = "0x186067710")]
	private static int OONHIONOBDF(int FCGCFNLNKJN, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x60672A0", Offset = "0x60666A0", VA = "0x1860672A0")]
	public static int MHIJJPFFFAM(int NBPAIKKEFCG, int FCGCFNLNKJN, int DBOIMIFOHOH, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6067210", Offset = "0x6066610", VA = "0x186067210")]
	public static int KHBKANEEABP(int NBPAIKKEFCG, int FCGCFNLNKJN, int DBOIMIFOHOH, bool EEOLHPBJIJI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6066250", Offset = "0x6065650", VA = "0x186066250")]
	public static int CMLIBKKPGKD(int DBOIMIFOHOH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6066150", Offset = "0x6065550", VA = "0x186066150")]
	public static BFCPJNPAEDJ ACMHJICHCEE(int FCGCFNLNKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6066270", Offset = "0x6065670", VA = "0x186066270")]
	private static BFCPJNPAEDJ CMLKMKDNGFE(int FCGCFNLNKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6066C40", Offset = "0x6066040", VA = "0x186066C40")]
	public static BFCPJNPAEDJ HAMHJLMGMJP(int FCGCFNLNKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6067310", Offset = "0x6066710", VA = "0x186067310")]
	private static BFCPJNPAEDJ NCEBKOKDJGN(int FCGCFNLNKJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6066D30", Offset = "0x6066130", VA = "0x186066D30")]
	public static void HEPEJPFCJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct EFFBKBOAFFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int CDPGHLMCEBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 EIOOHIIIMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion ILFJIEKDFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float LLPEOMKHKGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float NAOPKFHABGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int AEACPPPKIAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int JPJAEGPCJKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int JHFGDOJMJDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool BHFMHKHPAKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool CNPOEBHBHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float FOOJHBNJGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 LLBMOFOPNAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool JKHPJCCKJCJ;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct NEPCCLILJEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int GAFLAIOCMDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int OBLJLIBGDDK;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct PKFIHKBMHMJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<EFFBKBOAFFE> GCHEDHJJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<BDKBILEBILB> JMJFJHHALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<AMCGOOGDBIH> ABIJDDGJDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<NEPCCLILJEM> PLNHIEMHKNG;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x60681E0", Offset = "0x60675E0", VA = "0x1860681E0")]
	public PKFIHKBMHMJ(NativeArray<BDKBILEBILB> JMJFJHHALCN, int KKEOKHMHDHC = 1, Allocator FHOLEANHCPH = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x60680F0", Offset = "0x60674F0", VA = "0x1860680F0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct AKHOJMFDPDB : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<MLOLCILBKAL> LLEHOFLJEGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> KMDDMIOLDJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<AMCGOOGDBIH> BPGAJEMPIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<EFFBKBOAFFE> GCHEDHJJENB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<BDKBILEBILB> JMJFJHHALCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<AMCGOOGDBIH> ABIJDDGJDOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<NEPCCLILJEM> PLNHIEMHKNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int PLHHCOLLBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int LLNADBCKBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 NIFELDCCKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion ENFALMAKIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 ANGCBGEDKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ANIPBNOBMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NCCJBLIICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IPHJOEHFLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> ENDIPMCHBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> AIEJILPKBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CMIMGILGCAI;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x605B150", Offset = "0x605A550", VA = "0x18605B150")]
	public AKHOJMFDPDB(FNBJHMOKFAD AAECOFILMGD, HLIKNHCLNCJ FBHOKGBMOJF, float3 EHABGGMPKPD, quaternion DLFCMGACPCI, float BDAELLGNOEK, int PAHBMFIFLIK = 0, int BOHGEDMNBBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x605B3E0", Offset = "0x605A7E0", VA = "0x18605B3E0")]
	public AKHOJMFDPDB(PKFIHKBMHMJ AAECOFILMGD, HLIKNHCLNCJ FBHOKGBMOJF, float3 EHABGGMPKPD, quaternion DLFCMGACPCI, float3 BDAELLGNOEK, int PAHBMFIFLIK = 0, int BOHGEDMNBBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x6059A10", Offset = "0x6058E10", VA = "0x186059A10")]
	private float3 AGOIBKOAPFK(float3 KCJGGHBEIKK, Matrix4x4 DJDADFLJCCJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x6059990", Offset = "0x6058D90", VA = "0x186059990")]
	private float3x3 AFEDNOFJIEM(float3x3 MCBNPBELLHI, float3x3 LBCBDJLAAGH)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x605B140", Offset = "0x605A540", VA = "0x18605B140")]
	private float OEDEFAAOLFN(float GLDPLANNJMB, float OOAFBNIJPNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x6059B40", Offset = "0x6058F40", VA = "0x186059B40", Slot = "4")]
	public void Execute(int AHCPHJCJKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x6059820", Offset = "0x6058C20", VA = "0x186059820")]
	private void AFBHKGCCOAA(int INBJGPJGMDJ, float3 BCGGHPIMKDA, float3 KELADLMJIOC, float3 HCIGGIBPMJE, float MJHNLFCGBDF, bool EFOMNMGBFBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x605ACE0", Offset = "0x605A0E0", VA = "0x18605ACE0")]
	private void NFAPIEDIGAJ(EFFBKBOAFFE EGLOKEBPJGL, float3 MFMADJENJBL, float3x3 LMGFHFMPEAE, float GLDPLANNJMB, int FDDIEBKDPPI, int PGKNNFDOBNF, int GENJAPNNGLE, float CEAKONIJLOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60591D0", Offset = "0x60585D0", VA = "0x1860591D0")]
	private void ACHIBFPFELF(int INBJGPJGMDJ, int ILCKDNOKKEI, EFFBKBOAFFE EGLOKEBPJGL, float3 MFMADJENJBL, float3x3 LMGFHFMPEAE, bool JIJFNKMADJO, float GLDPLANNJMB, int JNKKEALBEAA, int IBCDMLIGCCM, int GENJAPNNGLE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct ONHHDAJLBEL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<FCFPPJDEJFH> EMMINNMELHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<AMCGOOGDBIH> IELFEIKKJLB;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6068000", Offset = "0x6067400", VA = "0x186068000")]
	public ONHHDAJLBEL(int KKEOKHMHDHC, Allocator FHOLEANHCPH = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6067F60", Offset = "0x6067360", VA = "0x186067F60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct GALGNEJDJHG : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum MAMFCMGEPEP
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
	private NativeList<float3> HPJECADPJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> IOGOADPIMKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> LGJAILNAPJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> OGGMJABEDGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> EDKBOECPMCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> LKAFOEBODDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> OKPEPIOHEEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> ODCCMJKLFOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<AMCGOOGDBIH> AGDDJEHOCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<FCFPPJDEJFH> EMMINNMELHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<AMCGOOGDBIH> IELFEIKKJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int PLHHCOLLBAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int LLNADBCKBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ANIPBNOBMDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> NCCJBLIICEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> IPHJOEHFLHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> ENDIPMCHBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> AIEJILPKBND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> CMIMGILGCAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 ANGCBGEDKCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion ENFALMAKIGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 NIFELDCCKFI;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x60650F0", Offset = "0x60644F0", VA = "0x1860650F0")]
	public GALGNEJDJHG(FNBJHMOKFAD AAECOFILMGD, HLIKNHCLNCJ FBHOKGBMOJF, float3 EHABGGMPKPD, quaternion DLFCMGACPCI, float BDAELLGNOEK, int PAHBMFIFLIK = 0, int BOHGEDMNBBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6064F00", Offset = "0x6064300", VA = "0x186064F00")]
	public GALGNEJDJHG(ONHHDAJLBEL GMLIPIALCHN, HLIKNHCLNCJ FBHOKGBMOJF, float3 EHABGGMPKPD, quaternion DLFCMGACPCI, float3 BDAELLGNOEK, int PAHBMFIFLIK = 0, int BOHGEDMNBBI = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6063B60", Offset = "0x6062F60", VA = "0x186063B60", Slot = "4")]
	public void Execute(int AHCPHJCJKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x6064B50", Offset = "0x6063F50", VA = "0x186064B50")]
	private void GLECBLCDFCG(float4x4 NBGGKBNENAM, int AHCPHJCJKJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x6063AF0", Offset = "0x6062EF0", VA = "0x186063AF0")]
	private MAMFCMGEPEP BIDJPIINNHI(float3 KELADLMJIOC)
	{
		return default(MAMFCMGEPEP);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6064AC0", Offset = "0x6063EC0", VA = "0x186064AC0")]
	private float4 GBOBCIPGHFM(MAMFCMGEPEP OCLECDOMHPL, int FGBBDGJMFEH)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6064B10", Offset = "0x6063F10", VA = "0x186064B10")]
	private float2 GDEGFJCHIHJ(MAMFCMGEPEP OCLECDOMHPL, float3 BCGGHPIMKDA)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct CHPGFKDHDHI
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum EMKBJLHHGIH
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static CHPGFKDHDHI HNPOJGAPKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 CNEKGDKGHGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 LABHFJHFGGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 KKKENMPFNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public EMKBJLHHGIH IIJIPCLFFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 PCODCEPDPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 BMNJBGIAFHB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FOPNCONIKJO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x605F770", Offset = "0x605EB70", VA = "0x18605F770")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 EPFIPGFJLJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x605FEC0", Offset = "0x605F2C0", VA = "0x18605FEC0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6060010", Offset = "0x605F410", VA = "0x186060010")]
	public CHPGFKDHDHI(float3 BCGGHPIMKDA, quaternion GIJALKLADPN, float3 KKEOKHMHDHC, EMKBJLHHGIH KHENBEDBKDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x605F780", Offset = "0x605EB80", VA = "0x18605F780")]
	public float IAMPDOABAIN(float3 MFMADJENJBL, float MEFMAKLIHHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x605F680", Offset = "0x605EA80", VA = "0x18605F680")]
	public bool ADOEMAKMNNK(float3 KELADLMJIOC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x605FD10", Offset = "0x605F110", VA = "0x18605FD10")]
	public void MDAOJEICNEF(float3 DNPOKBBFMPE, float3x3 NNFKJFBMAEH, float BNKMIAKLDNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x605FC10", Offset = "0x605F010", VA = "0x18605FC10")]
	private void LNFJLLHCBPH(float3 OBBJCDANAFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x605F980", Offset = "0x605ED80", VA = "0x18605F980")]
	public void JDMHOOPNKDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct AJOKMKPALEM : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<CHPGFKDHDHI> GMLIPIALCHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> MHFBLEGLFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> AHKIIABHOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> HNPMAEDGLAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<AMCGOOGDBIH> IELFEIKKJLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int KJLECPDNMCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int PMOGGMNDKGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float MEFMAKLIHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float FMMDKBBGCKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> ILBFCDGCJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> EFMOJAHPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> FOMCPMEEGNA;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6059130", Offset = "0x6058530", VA = "0x186059130")]
	public AJOKMKPALEM(HLIKNHCLNCJ MOKLMJBIJAG, float GIIJMMBMAFC, int PNHIOPPHDJO, int FDDIEBKDPPI, NativeList<CHPGFKDHDHI> GMLIPIALCHN, NativeArray<int> HNPMAEDGLAL, NativeList<AMCGOOGDBIH> IELFEIKKJLB, EPCMKMDFCOH AFENAJJCLNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60589F0", Offset = "0x6057DF0", VA = "0x1860589F0", Slot = "4")]
	public void Execute(int MCPNMDJANEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6058690", Offset = "0x6057A90", VA = "0x186058690")]
	private bool AGDFGPMLNBC(CHPGFKDHDHI OJBODDLNJNK, CHPGFKDHDHI BLEBDLHLENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6058750", Offset = "0x6057B50", VA = "0x186058750")]
	private bool BHHLOCDKPPO(CHPGFKDHDHI EIGMBPEGGMD, int OKKKKEKCLPI, int DBKLJNCLCJH, int HOLCDLBLGMF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class EPCMKMDFCOH : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> CGBHNLGGBNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> CNBHMOPGDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> LNIMPEEKBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> HOGJFMEPGGF;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6060C90", Offset = "0x6060090", VA = "0x186060C90")]
	public void GHFIKOGEHPG(int CNCMNKLBLAL, int EJAGODJFIGN, Allocator FHOLEANHCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6060C70", Offset = "0x6060070", VA = "0x186060C70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6060D90", Offset = "0x6060190", VA = "0x186060D90")]
	public void ILMOPHDNONE(JobHandle JCIHDGOOBEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public EPCMKMDFCOH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct DJIGFOBIEIO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> MHFBLEGLFGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> ACFJFIFBHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> JMDJDDENHOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> KAOBFHIODNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> AHKIIABHOHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LMMLMMHNJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> HFOCNFKGMBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> ILBFCDGCJDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> EFMOJAHPGIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int PAHBMFIFLIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int BOHGEDMNBBI;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6060AA0", Offset = "0x605FEA0", VA = "0x186060AA0")]
	public DJIGFOBIEIO(HLIKNHCLNCJ MOKLMJBIJAG, EPCMKMDFCOH AFENAJJCLNK, int BOHGEDMNBBI = 0, int PAHBMFIFLIK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x60606C0", Offset = "0x605FAC0", VA = "0x1860606C0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6060660", Offset = "0x605FA60", VA = "0x186060660")]
	private void AMJOMHLLGLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class MCOLJBCNPDG
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x26D4560", Offset = "0x26D3960", VA = "0x1826D4560")]
	public static bool KPFOJKPBCOE<T>(NativeArray<T> CBCBEPHCJOP, int KKEOKHMHDHC, Allocator FHOLEANHCPH, NativeArrayOptions LOBGHAGLKMO = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x26D46A0", Offset = "0x26D3AA0", VA = "0x1826D46A0")]
	public static bool KPFOJKPBCOE<T>(NativeList<T> EPAFMCCJAFF, int KKEOKHMHDHC, Allocator FHOLEANHCPH) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PADABDJEGFJ
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
public interface AEOLHKOOJJO
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int GGBEKOEJNLI(PADABDJEGFJ NBPAIKKEFCG);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JKFHOEKMCHL(PADABDJEGFJ NBPAIKKEFCG);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void EIBEDLGGLPG(PADABDJEGFJ NBPAIKKEFCG, FNBJHMOKFAD ICCBDGBKMEI, int EOFCNJPPJAC = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class HLIKNHCLNCJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int EFBJNCAEPPA = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> HAMHNGEJJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> BNFMLHOOHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> PNBOFKENKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> JABDLDIMGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> FNBMEJHPGDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> ENOPGOJLNPL;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DCKNEPLMKNC
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6066110", Offset = "0x6065510", VA = "0x186066110")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x6065990", Offset = "0x6064D90", VA = "0x186065990")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int HCAGCMKLGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x60660D0", Offset = "0x60654D0", VA = "0x1860660D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool ELBMFDAHLKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x6066090", Offset = "0x6065490", VA = "0x186066090")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60659D0", Offset = "0x6064DD0", VA = "0x1860659D0", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6065AE0", Offset = "0x6064EE0", VA = "0x186065AE0")]
	public void GHFIKOGEHPG(int CNCMNKLBLAL, int EJAGODJFIGN, Allocator FHOLEANHCPH, bool IILCCPBGGAJ, bool CHKODKBNKKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6065910", Offset = "0x6064D10", VA = "0x186065910")]
	public void CABHCEFGNJM(int CNCMNKLBLAL, int EJAGODJFIGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6065CB0", Offset = "0x60650B0", VA = "0x186065CB0", Slot = "6")]
	public bool LCGKJBAIOBF(Mesh MOKLMJBIJAG, bool JBNPFBPGCDL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x60652E0", Offset = "0x60646E0", VA = "0x1860652E0")]
	public bool AOBNBCHMBKJ(Mesh MOKLMJBIJAG, HLIKNHCLNCJ PLDKCIGADFJ, bool JBNPFBPGCDL = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
	public HLIKNHCLNCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class EMNCLMAMLLI
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6060B20", Offset = "0x605FF20", VA = "0x186060B20")]
	public static void HEPEJPFCJHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BCEBLEGNMIJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> HAMHNGEJJKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> BNFMLHOOHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> BCLIKMIBLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> JMNFODHKJBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> EAMAFMHNAPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> BLAJOAIKKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> MIHPBONDBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> ENOPGOJLNPL;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x605B650", Offset = "0x605AA50", VA = "0x18605B650")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int HCAGCMKLGKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x605BD20", Offset = "0x605B120", VA = "0x18605BD20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int OJGAOLGLIPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x605B610", Offset = "0x605AA10", VA = "0x18605B610")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x605C7E0", Offset = "0x605BBE0", VA = "0x18605C7E0")]
	public BCEBLEGNMIJ(int CNCMNKLBLAL, int EJAGODJFIGN, int BEEECGEKGFH, Allocator FHOLEANHCPH = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x605C4F0", Offset = "0x605B8F0", VA = "0x18605C4F0")]
	public BCEBLEGNMIJ(Mesh MOKLMJBIJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x605B690", Offset = "0x605AA90", VA = "0x18605B690", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x605C1F0", Offset = "0x605B5F0", VA = "0x18605C1F0")]
	public void NKJIKCGDGFK(BCEBLEGNMIJ MOKLMJBIJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x605BD60", Offset = "0x605B160", VA = "0x18605BD60")]
	private void NBLAIEIMCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x605B7A0", Offset = "0x605ABA0", VA = "0x18605B7A0")]
	private void EIMCBKDAEFB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct AMCGOOGDBIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int NNEDDCGFLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int CKAKGLLKGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int GOFDFPGKLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int HCAGCMKLGKA;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x1177F70", Offset = "0x1177370", VA = "0x181177F70")]
	public AMCGOOGDBIH(int FDDIEBKDPPI, int GGLNOCBEHJJ, int PNHIOPPHDJO, int IDHFPPGCGPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LMGDOMPFPAG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<AMCGOOGDBIH> BDHGLMCAAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xB5FAF0", Offset = "0xB5EEF0", VA = "0x180B5FAF0")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<AMCGOOGDBIH>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1BC3F10", Offset = "0x1BC3310", VA = "0x181BC3F10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BCEBLEGNMIJ AIMIJFIKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x796850", Offset = "0x795C50", VA = "0x180796850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x792A40", Offset = "0x791E40", VA = "0x180792A40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x60679A0", Offset = "0x6066DA0", VA = "0x1860679A0")]
	public LMGDOMPFPAG(IEnumerable<BCEBLEGNMIJ> PGBMOBOFGNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6067930", Offset = "0x6066D30", VA = "0x186067930", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EHHJHCCOHIE
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CMBMIOGAEJP
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> KCKIOMIAFOE;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> AKMNJLNJLJB;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> ODCDPCOPAGM;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> LAFMAAMMOME;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6060320", Offset = "0x605F720", VA = "0x186060320")]
	public static void HEPEJPFCJHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6060550", Offset = "0x605F950", VA = "0x186060550")]
	public static NativeArray<float2> KEIELJLGPDF(NativeArray<float2> MJKFFNHBDKB, int BMJJCDJIGEJ, NativeArray<float2> FKCAPOFACMO, int LOIPDEGIHMJ)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6060100", Offset = "0x605F500", VA = "0x186060100")]
	public static NativeArray<float3> CFOPFIKJKLC(NativeArray<float3> MJKFFNHBDKB, int BMJJCDJIGEJ, NativeArray<float3> FKCAPOFACMO, int LOIPDEGIHMJ)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6060440", Offset = "0x605F840", VA = "0x186060440")]
	public static NativeArray<float4> JLKMINOIPDO(NativeArray<float4> MJKFFNHBDKB, int BMJJCDJIGEJ, NativeArray<float4> FKCAPOFACMO, int LOIPDEGIHMJ)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6060210", Offset = "0x605F610", VA = "0x186060210")]
	public static NativeArray<int> CLDEHAIEDAJ(NativeArray<int> MJKFFNHBDKB, int BMJJCDJIGEJ, NativeArray<int> FKCAPOFACMO, int LOIPDEGIHMJ)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2460780", Offset = "0x245FB80", VA = "0x182460780")]
	private static void IDLIAIMJHAH<T>(NativeArray<T> CBCBEPHCJOP, int MBGHKPGOBMA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2460980", Offset = "0x245FD80", VA = "0x182460980")]
	private static void KOJFNMMLPJK<T>(NativeArray<T> MJKFFNHBDKB, int BMJJCDJIGEJ, NativeArray<T> FKCAPOFACMO, int LOIPDEGIHMJ, NativeArray<T> MMNLDHCAKKJ) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FOHDKAHMNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<AEOLHKOOJJO> FIBPHGGLCDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly FNFBFDKENLK LBNLFGLICNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int GGLNOCBEHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int IDHFPPGCGPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool EIIDFEEFAGI;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh AIMIJFIKJKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7940D0", Offset = "0x7934D0", VA = "0x1807940D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x796870", Offset = "0x795C70", VA = "0x180796870")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer EMOCHLOOOGK
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x796860", Offset = "0x795C60", VA = "0x180796860")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int CKAKGLLKGMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60634D0", Offset = "0x60628D0", VA = "0x1860634D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2166B70", Offset = "0x2165F70", VA = "0x182166B70")]
	public void CPPJFHGKLFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x60639D0", Offset = "0x6062DD0", VA = "0x1860639D0")]
	public FOHDKAHMNEA(string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6063670", Offset = "0x6062A70", VA = "0x186063670")]
	public void ILMOPHDNONE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6063360", Offset = "0x6062760", VA = "0x186063360")]
	public void CKBDODGHLID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6063550", Offset = "0x6062950", VA = "0x186063550")]
	public void HAPNPDGECBJ(AEOLHKOOJJO GNOGBLIPBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x60636B0", Offset = "0x6062AB0", VA = "0x1860636B0")]
	private void MAOCJJBMCHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6063600", Offset = "0x6062A00", VA = "0x186063600")]
	public bool ILMGKEGDFOF(AEOLHKOOJJO GNOGBLIPBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x60634F0", Offset = "0x60628F0", VA = "0x1860634F0")]
	public bool GHNKANFLKPF(AEOLHKOOJJO GNOGBLIPBEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6063390", Offset = "0x6062790", VA = "0x186063390", Slot = "4")]
	public virtual void DIFJBKKCFJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6063400", Offset = "0x6062800", VA = "0x186063400")]
	public void DIOLDBFMBDN(Transform OFBICMIPCED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6062BE0", Offset = "0x6061FE0", VA = "0x186062BE0")]
	public bool AELFGBMINAD(Transform OFBICMIPCED, [Out] (HLIKNHCLNCJ destMesh, Mesh mesh, JobHandle job) GMLIPIALCHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6063920", Offset = "0x6062D20", VA = "0x186063920")]
	public void NEHOFHHKMFG([In] (HLIKNHCLNCJ destMesh, Mesh mesh, JobHandle job) GMLIPIALCHN)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker IDCFNKHPJMJ;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker KDNLEPBCIGA;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker OCBPOHIHAJE;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int JGBCMMEDCGG = 65000;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		private DEMHINFLCEG PDECMNJJJFE;

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
		private Dictionary<Material, List<FOHDKAHMNEA>> KALGLEMLPAE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<FOHDKAHMNEA> NBFBLIAFNMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<MeshRenderer> PKHMNDJIGDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private List<(FOHDKAHMNEA, (HLIKNHCLNCJ, Mesh, JobHandle))> GDJFEIOKBKN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private bool OGGJBHBFGIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, float> OBKKNEJNFKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Color> IDAFNLJDCII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Vector4> GIDMEMJPJFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private Dictionary<int, Matrix4x4> JHMHEFLLOFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private FOHDKAHMNEA EEHLGFMCGLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		private Material INEFBLHBHIG;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> HFLPLLFDODK
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x793ED0", Offset = "0x7932D0", VA = "0x180793ED0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x605E600", Offset = "0x605DA00", VA = "0x18605E600")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x605CE10", Offset = "0x605C210", VA = "0x18605CE10")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x605CC00", Offset = "0x605C000", VA = "0x18605CC00")]
		public FOHDKAHMNEA AddToBatchedMesh(AEOLHKOOJJO DBKGJKLLLGC, Material DELNJNDMHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x605E890", Offset = "0x605DC90", VA = "0x18605E890")]
		public void RemoveFromBatchedMesh(AEOLHKOOJJO MOKLMJBIJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x605CCE0", Offset = "0x605C0E0", VA = "0x18605CCE0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x605EA10", Offset = "0x605DE10", VA = "0x18605EA10")]
		public void SetMaterialProperty(int OBPHOMEOEEI, Color JKOGDMNIBNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x605EEA0", Offset = "0x605E2A0", VA = "0x18605EEA0")]
		public void SetMaterialProperty(int OBPHOMEOEEI, float PAHKKNONPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x605F0C0", Offset = "0x605E4C0", VA = "0x18605F0C0")]
		public void SetMaterialProperty(int OBPHOMEOEEI, Vector4 LDEANPBMOHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x605EC40", Offset = "0x605E040", VA = "0x18605EC40")]
		public void SetMaterialProperty(int OBPHOMEOEEI, Matrix4x4 FJBAMKBHLLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x605DE10", Offset = "0x605D210", VA = "0x18605DE10")]
		private void NPKFJNFGIEL(Renderer MADIDHJDPOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x605CFF0", Offset = "0x605C3F0", VA = "0x18605CFF0")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x605D000", Offset = "0x605C400", VA = "0x18605D000")]
		private void HIGMGGDAOEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x605E400", Offset = "0x605D800", VA = "0x18605E400")]
		private FOHDKAHMNEA OFEFCHKBOGC(AEOLHKOOJJO MOKLMJBIJAG, Material DELNJNDMHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x605DC40", Offset = "0x605D040", VA = "0x18605DC40")]
		private FOHDKAHMNEA NEMCALKHLCO(Material DELNJNDMHJJ, int KEFIBBAIAIN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x605D560", Offset = "0x605C960", VA = "0x18605D560")]
		private FOHDKAHMNEA JOIAGKGKKLD(Material DELNJNDMHJJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x605DA10", Offset = "0x605CE10", VA = "0x18605DA10")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x605DAB0", Offset = "0x605CEB0", VA = "0x18605DAB0")]
		public void MarkDirty(AEOLHKOOJJO MOKLMJBIJAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x605F3C0", Offset = "0x605E7C0", VA = "0x18605F3C0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class IOCNMJHNCHP<KeyType> : FOHDKAHMNEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private readonly Dictionary<KeyType, AEOLHKOOJJO> OANBPKKCFKN;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x391FE70", Offset = "0x391F270", VA = "0x18391FE70")]
	public IOCNMJHNCHP(string ADLKEGECLOG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x391FC80", Offset = "0x391F080", VA = "0x18391FC80")]
	public void HAPNPDGECBJ(KeyType CONEAMPCFEL, AEOLHKOOJJO GNOGBLIPBEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x391FCD0", Offset = "0x391F0D0", VA = "0x18391FCD0")]
	public bool NLAGACDHFDO(KeyType CONEAMPCFEL, AEOLHKOOJJO PDPENLHMGNK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x391FB40", Offset = "0x391EF40", VA = "0x18391FB40")]
	public void GIDLCLJNAGO(KeyType CONEAMPCFEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x391FB00", Offset = "0x391EF00", VA = "0x18391FB00", Slot = "4")]
	public override void DIFJBKKCFJL()
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
