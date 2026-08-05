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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
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
		[Cpp2IlInjected.Address(RVA = "0x788D90", Offset = "0x787B90", VA = "0x180788D90")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OPGAJJNOECB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int FEKEBAEDCGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 LGKEBEDBNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion KPEEKDOFHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 PPNACBMPOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int OAPOMEHPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int OJAODFKIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int HOFLCLMGDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float LGGMNNCGFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 LDGDICMBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool MEHGPKLFCAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public IIGICJHNNKA LMGCBEEDBPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 CFOALOAJKOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float FCINPLJCFNO;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FFDCHNKCGLC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static BPPGJJAGOIM IEBFJECMDJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<OPGAJJNOECB> EBAGDKNEGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<GBFHKENFLNK> CAFCAMPCPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<ICLLKJKGFMI> LGOBACDDIDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<PCPIDJFGIAP> ADLGBMDKJGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<GBFHKENFLNK> KDMMECLAEFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<BCPCMJBFCNB> ILGMMLOKEFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<PCPIDJFGIAP>> APKKADIDHOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<IHLFNILNKGA> AMGBCBAPFNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> EMGECACKBDJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JPMFIFJILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE7C70", Offset = "0xAE6A70", VA = "0x180AE7C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAE7420", Offset = "0xAE6220", VA = "0x180AE7420")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JFECIOGOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAE7C80", Offset = "0xAE6A80", VA = "0x180AE7C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE67D0", Offset = "0xAE55D0", VA = "0x180AE67D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDB60", Offset = "0x5CCC960", VA = "0x185CCDB60")]
	public FFDCHNKCGLC(int NJBGKBKMNAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC010", Offset = "0x5CCAE10", VA = "0x185CCC010", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD990", Offset = "0x5CCC790", VA = "0x185CCD990")]
	public void OGJJNAJKDPN(JobHandle GIFCONDMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD770", Offset = "0x5CCC570", VA = "0x185CCD770")]
	public void OCONEKLKEEP(OPGAJJNOECB LMCJHCIOIIP, IHLFNILNKGA ILBHBIIMGAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD630", Offset = "0x5CCC430", VA = "0x185CCD630")]
	public void IGHECHOCHHK(ICLLKJKGFMI LMCJHCIOIIP, NativeArray<PCPIDJFGIAP> DJCMKLCLOEK, int KMIEJOGGBHG, int GPJPFNCPHIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC2E0", Offset = "0x5CCB0E0", VA = "0x185CCC2E0")]
	public JobHandle FFGPONJAGKI(LADLLAMMHKG BEGNBAMJFII, GCMHEKNJGFN MHFJEOABGNO, float3 GLCPKABCPIG, quaternion PJBIPACOMMJ, float DOGPJBCAGIN, bool HGHHEPLMBGL, int KIABDJBNNLL = 0, int JCJOMNKFAME = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD2F0", Offset = "0x5CCC0F0", VA = "0x185CCD2F0")]
	public static JobHandle GLOCHCLCLHE(AKPNHCGAOPM CFABAMMGEDM, LADLLAMMHKG BEGNBAMJFII, OPGAJJNOECB LMCJHCIOIIP, JobHandle GIFCONDMHLL)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC030", Offset = "0x5CCAE30", VA = "0x185CCC030")]
	public static JobHandle EAPPEPEELPG(GGPBOADKLPC CFABAMMGEDM, LADLLAMMHKG BEGNBAMJFII, ICLLKJKGFMI LMCJHCIOIIP, NativeArray<PCPIDJFGIAP> DJCMKLCLOEK, int KMIEJOGGBHG, int GPJPFNCPHIK, JobHandle GIFCONDMHLL)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OBMHNJMKHIH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 IKKFEAHBANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 INBDJNHAONI;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class IIDFFGPEMHI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<OBMHNJMKHIH> KCCJANOMJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> LIJKCMMHBIC;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int JPMFIFJILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7638A0", Offset = "0x7626A0", VA = "0x1807638A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int JFECIOGOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x763850", Offset = "0x762650", VA = "0x180763850")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCED60", Offset = "0x5CCDB60", VA = "0x185CCED60")]
	public IIDFFGPEMHI(int HJGBDOLCBOL, int DAEFPILNIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEC20", Offset = "0x5CCDA20", VA = "0x185CCEC20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEC80", Offset = "0x5CCDA80", VA = "0x185CCEC80")]
	public void PAHJLAEOIEH(IIDFFGPEMHI EFAMNJOCCIF, int NDNHDNBHOJJ, int IJBCLDGENAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LKAIKAFGLCI
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static IIDFFGPEMHI OCADPGABCNF;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<GBFHKENFLNK> GFMMIMNHOKP;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] HMMIMGKOFHJ;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool JKFPOBOGKGL;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, IIDFFGPEMHI> CBCJGEAEEIG;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, IIDFFGPEMHI> JDLJBDDHPLB;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool OKONLDFPODO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0940", Offset = "0x5CCF740", VA = "0x185CD0940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<GBFHKENFLNK> FIHGIBHEOOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1EC0", Offset = "0x5CD0CC0", VA = "0x185CD1EC0")]
		get
		{
			return default(NativeList<GBFHKENFLNK>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static IIDFFGPEMHI HPINGAOLBFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CD1D30", Offset = "0x5CD0B30", VA = "0x185CD1D30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CD09C0", Offset = "0x5CCF7C0", VA = "0x185CD09C0")]
	private static void ANICEOJJIDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1F60", Offset = "0x5CD0D60", VA = "0x185CD1F60")]
	public static int PMCIMAAEKFL(bool EDLKGPLGOJJ, int LCBJNHLLHGI, bool CKGNLPOBCEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CD12D0", Offset = "0x5CD00D0", VA = "0x185CD12D0")]
	private static int CKFMIMIIICF(int LCBJNHLLHGI, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1C60", Offset = "0x5CD0A60", VA = "0x185CD1C60")]
	private static int GECNAKCCMEC(int LCBJNHLLHGI, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1C70", Offset = "0x5CD0A70", VA = "0x185CD1C70")]
	public static int JEFHJGEMAJI(int NHLPANAJLNK, int LCBJNHLLHGI, int DBAPMMIIAHE, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD17F0", Offset = "0x5CD05F0", VA = "0x185CD17F0")]
	public static int FGGIIIMAEOP(int NHLPANAJLNK, int LCBJNHLLHGI, int DBAPMMIIAHE, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1880", Offset = "0x5CD0680", VA = "0x185CD1880")]
	public static int FJBCEFMGHFC(int DBAPMMIIAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1D00", Offset = "0x5CD0B00", VA = "0x185CD1D00")]
	private static int MFILBOPIPKI(int LCBJNHLLHGI, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1D10", Offset = "0x5CD0B10", VA = "0x185CD1D10")]
	private static int MFMIMLPJJFC(int LCBJNHLLHGI, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0FD0", Offset = "0x5CCFDD0", VA = "0x185CD0FD0")]
	public static int BCIHAAIBGLC(int NHLPANAJLNK, int LCBJNHLLHGI, int DBAPMMIIAHE, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1890", Offset = "0x5CD0690", VA = "0x185CD1890")]
	public static int FKOAEDLPKOA(int NHLPANAJLNK, int LCBJNHLLHGI, int DBAPMMIIAHE, bool MJMMIFEINOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0920", Offset = "0x5CCF720", VA = "0x185CD0920")]
	public static int ACBHNNOFNMB(int DBAPMMIIAHE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1DD0", Offset = "0x5CD0BD0", VA = "0x185CD1DD0")]
	public static IIDFFGPEMHI NDHAOFKEDPJ(int LCBJNHLLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1040", Offset = "0x5CCFE40", VA = "0x185CD1040")]
	private static IIDFFGPEMHI BKAELHGCCOD(int LCBJNHLLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1700", Offset = "0x5CD0500", VA = "0x185CD1700")]
	public static IIDFFGPEMHI DFLHGHKPOEC(int LCBJNHLLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1920", Offset = "0x5CD0720", VA = "0x185CD1920")]
	private static IIDFFGPEMHI GBFIIHDJKPI(int LCBJNHLLHGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CD12F0", Offset = "0x5CD00F0", VA = "0x185CD12F0")]
	public static void CLFBHAOODBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct ICLLKJKGFMI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int FOBHIJEODCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 LGKEBEDBNNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion KPEEKDOFHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float PPNACBMPOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float PLPJDEALMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int OAPOMEHPDKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int OJAODFKIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int HOFLCLMGDFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool JANGMOLIMJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool KJJOGNKHEID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float LGGMNNCGFOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 LDGDICMBOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool ABNDAJILMLM;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct BCPCMJBFCNB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int GIHOLMICKPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int NFCAHLGJPCN;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct GGPBOADKLPC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<ICLLKJKGFMI> HGODKOOEFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<PCPIDJFGIAP> CHILDAKJLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<GBFHKENFLNK> PHCOKHMOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<BCPCMJBFCNB> ALALNFHGMCL;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE070", Offset = "0x5CCCE70", VA = "0x185CCE070")]
	public GGPBOADKLPC(NativeArray<PCPIDJFGIAP> CHILDAKJLBJ, int GINFBCJKIJI = 1, Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDF80", Offset = "0x5CCCD80", VA = "0x185CCDF80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct CPCMDKNNFEN : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<OBMHNJMKHIH> ONBACIHFMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> NHNIPJMJFEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<GBFHKENFLNK> PDFDMOJIGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<ICLLKJKGFMI> HGODKOOEFJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<PCPIDJFGIAP> CHILDAKJLBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<GBFHKENFLNK> PHCOKHMOHNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<BCPCMJBFCNB> ALALNFHGMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int KNAOJHNFFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int PCBILJEPEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 NHJFPNDDILH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion DKPDIPNOMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 NLDEHHOAPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GLGAIJJBIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ICPGCAGLMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LINMBLCKNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GBKLACJGPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JIGNAJINIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IOMGNKANCLC;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9850", Offset = "0x5CC8650", VA = "0x185CC9850")]
	public CPCMDKNNFEN(FFDCHNKCGLC LHHHGNBCECH, LADLLAMMHKG HIAKDOIMONA, float3 EAPDMNDFDJG, quaternion HFPBPNKHBCL, float KCFDNHEEKHA, int KIABDJBNNLL = 0, int JCJOMNKFAME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9AE0", Offset = "0x5CC88E0", VA = "0x185CC9AE0")]
	public CPCMDKNNFEN(GGPBOADKLPC LHHHGNBCECH, LADLLAMMHKG HIAKDOIMONA, float3 EAPDMNDFDJG, quaternion HFPBPNKHBCL, float3 KCFDNHEEKHA, int KIABDJBNNLL = 0, int JCJOMNKFAME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC92C0", Offset = "0x5CC80C0", VA = "0x185CC92C0")]
	private float3 JGKNAEIJKCC(float3 MEMMLOBFCGK, Matrix4x4 EKMOHNIAKMD)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9240", Offset = "0x5CC8040", VA = "0x185CC9240")]
	private float3x3 FFFDGJJOKLE(float3x3 DIPOAJHDNPD, float3x3 KEMFGHHFJMP)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9230", Offset = "0x5CC8030", VA = "0x185CC9230")]
	private float FBOOHBDDLJE(float KLPLLOPDNNO, float JBNPDCPBLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8090", Offset = "0x5CC6E90", VA = "0x185CC8090", Slot = "4")]
	public void Execute(int BMDADOLNDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7F20", Offset = "0x5CC6D20", VA = "0x185CC7F20")]
	private void CBMECDNGLEE(int GDEFLIFKHEB, float3 CMKBDFOJBFE, float3 ABLMGKFECDN, float3 JOCFGNDKJAN, float HMBCCKMGEBH, bool GEKMEHHDEAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CC93F0", Offset = "0x5CC81F0", VA = "0x185CC93F0")]
	private void LPGENEHJPDE(ICLLKJKGFMI KMIOHPFCMDC, float3 GMNHMHBGHKM, float3x3 IGIKFKIIFKN, float KLPLLOPDNNO, int DNKDAGAHJHM, int HLKEEKNKIAF, int LIGOKDLKBAH, float NBENGMJKPEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CC78D0", Offset = "0x5CC66D0", VA = "0x185CC78D0")]
	private void CABBCMAGMKB(int GDEFLIFKHEB, int ONLIPBLDFDF, ICLLKJKGFMI KMIOHPFCMDC, float3 GMNHMHBGHKM, float3x3 IGIKFKIIFKN, bool ACJFGFFGGAN, float KLPLLOPDNNO, int EPMIHGIOMEN, int KPFBAIKIJNG, int LIGOKDLKBAH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AKPNHCGAOPM : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<OPGAJJNOECB> IOLGKLGMKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<GBFHKENFLNK> PNAPMMOALFN;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3CD0", Offset = "0x5CC2AD0", VA = "0x185CC3CD0")]
	public AKPNHCGAOPM(int GINFBCJKIJI, Allocator MBGJLDPPIJN = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3C30", Offset = "0x5CC2A30", VA = "0x185CC3C30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct LMPCKDMHEGI : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum IGJLBKLGEJA
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
	private NativeList<float3> AKPHGDIDGKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> ODAKDBMJKCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> ALCFLOGDGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> HKPGALJINAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> IMICHIGJJKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> JFJJMFMBELG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> OJAAKFCNHAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> OCBHLLKPDNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<GBFHKENFLNK> NBJONPCNMBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<OPGAJJNOECB> IOLGKLGMKBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<GBFHKENFLNK> PNAPMMOALFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int KNAOJHNFFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int PCBILJEPEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> GLGAIJJBIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> ICPGCAGLMID;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LINMBLCKNNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> GBKLACJGPEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> JIGNAJINIGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> IOMGNKANCLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 NLDEHHOAPKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion DKPDIPNOMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 NHJFPNDDILH;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3700", Offset = "0x5CD2500", VA = "0x185CD3700")]
	public LMPCKDMHEGI(FFDCHNKCGLC LHHHGNBCECH, LADLLAMMHKG HIAKDOIMONA, float3 EAPDMNDFDJG, quaternion HFPBPNKHBCL, float KCFDNHEEKHA, int KIABDJBNNLL = 0, int JCJOMNKFAME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CD3510", Offset = "0x5CD2310", VA = "0x185CD3510")]
	public LMPCKDMHEGI(AKPNHCGAOPM LMCJHCIOIIP, LADLLAMMHKG HIAKDOIMONA, float3 EAPDMNDFDJG, quaternion HFPBPNKHBCL, float3 KCFDNHEEKHA, int KIABDJBNNLL = 0, int JCJOMNKFAME = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2540", Offset = "0x5CD1340", VA = "0x185CD2540", Slot = "4")]
	public void Execute(int BMDADOLNDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2100", Offset = "0x5CD0F00", VA = "0x185CD2100")]
	private void AIKKHFFNLKH(float4x4 AMDILOIFCLE, int BMDADOLNDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD34A0", Offset = "0x5CD22A0", VA = "0x185CD34A0")]
	private IGJLBKLGEJA JKEGBEAENCL(float3 ABLMGKFECDN)
	{
		return default(IGJLBKLGEJA);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD24B0", Offset = "0x5CD12B0", VA = "0x185CD24B0")]
	private float4 AJFADDKENBJ(IGJLBKLGEJA IPBCEEIEEBJ, int OCMJNDDMDAL)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD2500", Offset = "0x5CD1300", VA = "0x185CD2500")]
	private float2 DIFFIDMMBBO(IGJLBKLGEJA IPBCEEIEEBJ, float3 CMKBDFOJBFE)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct IHLFNILNKGA
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum MKFGGPEDLJI
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static IHLFNILNKGA HGIJALJPANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 OJIMPAELBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 NDJDDGGIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 MGLJLKOIJDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public MKFGGPEDLJI HHINMKNAKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 IFLHKKKAECM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 GDAHGKJMNLO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool ELICBKNLKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCE1A0", Offset = "0x5CCCFA0", VA = "0x185CCE1A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 BLNEFBKKEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5CCE9E0", Offset = "0x5CCD7E0", VA = "0x185CCE9E0")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEB30", Offset = "0x5CCD930", VA = "0x185CCEB30")]
	public IHLFNILNKGA(float3 CMKBDFOJBFE, quaternion ALADLBOMNEP, float3 GINFBCJKIJI, MKFGGPEDLJI FLHOFPAHPKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE440", Offset = "0x5CCD240", VA = "0x185CCE440")]
	public float DLCOBDGHFIG(float3 GMNHMHBGHKM, float DKAFNKOPFGD)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE8F0", Offset = "0x5CCD6F0", VA = "0x185CCE8F0")]
	public bool LAEAMOOOBDM(float3 ABLMGKFECDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE640", Offset = "0x5CCD440", VA = "0x185CCE640")]
	public void JMMIONCCJMC(float3 DLOIDNOHLAK, float3x3 IEEPAJLFJME, float IOGIBBIMBLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE7F0", Offset = "0x5CCD5F0", VA = "0x185CCE7F0")]
	private void KGDGMPGPEDC(float3 HPBLMHBHKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE1B0", Offset = "0x5CCCFB0", VA = "0x185CCE1B0")]
	public void DGLKIGLJNCO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct ILJAOOGPFFP : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<IHLFNILNKGA> LMCJHCIOIIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> IFIFAFNFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> FEIMIFBBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> EMGECACKBDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<GBFHKENFLNK> PNAPMMOALFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int IMPMHEABAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int FEGCAGAJLEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float DKAFNKOPFGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float DOFDNFNBEEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> LKCJIAIMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FIKCGDGEHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> IPBAIIHEFMJ;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF8C0", Offset = "0x5CCE6C0", VA = "0x185CCF8C0")]
	public ILJAOOGPFFP(LADLLAMMHKG GIOOFAEFEGJ, float NECEBCKLEFN, int IJBCLDGENAJ, int DNKDAGAHJHM, NativeList<IHLFNILNKGA> LMCJHCIOIIP, NativeArray<int> EMGECACKBDJ, NativeList<GBFHKENFLNK> PNAPMMOALFN, GCMHEKNJGFN MHFJEOABGNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEE20", Offset = "0x5CCDC20", VA = "0x185CCEE20", Slot = "4")]
	public void Execute(int IKBEJOFKFAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF560", Offset = "0x5CCE360", VA = "0x185CCF560")]
	private bool JPBNKMEODNL(IHLFNILNKGA APOJANFJHJO, IHLFNILNKGA DFBIFCHBAHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF620", Offset = "0x5CCE420", VA = "0x185CCF620")]
	private bool MGOLPOEBKAK(IHLFNILNKGA GBNHGJEMKMH, int CJDFMKPCBBL, int CLDGHACEFHC, int AMPDLHAEAND)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GCMHEKNJGFN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> PNAHCBHNEMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> KHFHAMANIMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> FCHECNDBJII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> IAAHKEJOHLO;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDD70", Offset = "0x5CCCB70", VA = "0x185CCDD70")]
	public void DAFBIINNNHF(int HJGBDOLCBOL, int DAEFPILNIAA, Allocator MBGJLDPPIJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDE70", Offset = "0x5CCCC70", VA = "0x185CCDE70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDE90", Offset = "0x5CCCC90", VA = "0x185CCDE90")]
	public void OGJJNAJKDPN(JobHandle GIFCONDMHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public GCMHEKNJGFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct BILAANJDIBO : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> IFIFAFNFAHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> KLDDNBDONNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> FMDCGMEOMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> PNNJHHODCIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> FEIMIFBBIKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> AJFBFIKBLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> EFLEDDHIEAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> LKCJIAIMIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> FIKCGDGEHIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int KIABDJBNNLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int JCJOMNKFAME;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4200", Offset = "0x5CC3000", VA = "0x185CC4200")]
	public BILAANJDIBO(LADLLAMMHKG GIOOFAEFEGJ, GCMHEKNJGFN MHFJEOABGNO, int JCJOMNKFAME = 0, int KIABDJBNNLL = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3DC0", Offset = "0x5CC2BC0", VA = "0x185CC3DC0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CC41A0", Offset = "0x5CC2FA0", VA = "0x185CC41A0")]
	private void GGIJBOJEBLM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class LFDHOGOEAEO
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x244EE10", Offset = "0x244DC10", VA = "0x18244EE10")]
	public static bool NEMJJEDMAGF<T>(NativeArray<T> OBEMKDLNKLE, int GINFBCJKIJI, Allocator MBGJLDPPIJN, NativeArrayOptions IPHFHMOKOMP = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x244EF50", Offset = "0x244DD50", VA = "0x18244EF50")]
	public static bool NEMJJEDMAGF<T>(NativeList<T> MJLHCFFNENL, int GINFBCJKIJI, Allocator MBGJLDPPIJN) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum FJDBGHECAMO
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
public interface GNDIBBLLDJJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int NJMGKPBEOLP(FJDBGHECAMO NHLPANAJLNK);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int JLNJLNEIFLH(FJDBGHECAMO NHLPANAJLNK);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void MDLLBJHOECC(FJDBGHECAMO NHLPANAJLNK, FFDCHNKCGLC IPADJPEKANK, int JMCHNDOFGAC = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class LADLLAMMHKG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int MGEFHGKIDJA = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> BEMFHHNHGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> BCEBGJPPIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> OAAAACMKGIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> HFGAFCOKMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> KHBLKPGIINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> OPIAENPEFPK;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool LOJCLMPHFKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFCC0", Offset = "0x5CCEAC0", VA = "0x185CCFCC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int JPMFIFJILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFE10", Offset = "0x5CCEC10", VA = "0x185CCFE10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int JFECIOGOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5CD0860", Offset = "0x5CCF660", VA = "0x185CD0860")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool NHFJBPPIBCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CCFAB0", Offset = "0x5CCE8B0", VA = "0x185CCFAB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFD00", Offset = "0x5CCEB00", VA = "0x185CCFD00", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFAF0", Offset = "0x5CCE8F0", VA = "0x185CCFAF0")]
	public void DAFBIINNNHF(int HJGBDOLCBOL, int DAEFPILNIAA, Allocator MBGJLDPPIJN, bool BLPHFHPGKGP, bool CLKAOAGKJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD08A0", Offset = "0x5CCF6A0", VA = "0x185CD08A0")]
	public void MEBFLDGKHKF(int HJGBDOLCBOL, int DAEFPILNIAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFE50", Offset = "0x5CCEC50", VA = "0x185CCFE50", Slot = "6")]
	public bool HCFCJHOHBFJ(Mesh GIOOFAEFEGJ, bool CMALOEHDPIM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0230", Offset = "0x5CCF030", VA = "0x185CD0230")]
	public bool HMHAMKJNEJI(Mesh GIOOFAEFEGJ, LADLLAMMHKG DOIMCLNBBCC, bool CMALOEHDPIM = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
	public LADLLAMMHKG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class KJBHKJDJHBG
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF960", Offset = "0x5CCE760", VA = "0x185CCF960")]
	public static void CLFBHAOODBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DLJLKAJCCIG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> BEMFHHNHGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> BCEBGJPPIKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> DECCIGJFGFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> BPHDCDEHCLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> FMJMDKEPNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> MFMBCKBHCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> MJEIAJGCFLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> OPIAENPEFPK;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int JPMFIFJILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA830", Offset = "0x5CC9630", VA = "0x185CCA830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int JFECIOGOHOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA8B0", Offset = "0x5CC96B0", VA = "0x185CCA8B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int HOILBLGNEPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CCA870", Offset = "0x5CC9670", VA = "0x185CCA870")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CCABF0", Offset = "0x5CC99F0", VA = "0x185CCABF0")]
	public DLJLKAJCCIG(int HJGBDOLCBOL, int DAEFPILNIAA, int EEGDCLJMMGG, Allocator MBGJLDPPIJN = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAE10", Offset = "0x5CC9C10", VA = "0x185CCAE10")]
	public DLJLKAJCCIG(Mesh GIOOFAEFEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA720", Offset = "0x5CC9520", VA = "0x185CCA720", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA8F0", Offset = "0x5CC96F0", VA = "0x185CCA8F0")]
	public void PAHJLAEOIEH(DLJLKAJCCIG GIOOFAEFEGJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA290", Offset = "0x5CC9090", VA = "0x185CCA290")]
	private void DMHPLNEKBGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9D10", Offset = "0x5CC8B10", VA = "0x185CC9D10")]
	private void CKDBJGCCDHN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct GBFHKENFLNK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int AJFFLPPAHGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int JPMFIFJILOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int NGJJFAIACGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int JFECIOGOHOK;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x108F4A0", Offset = "0x108E2A0", VA = "0x18108F4A0")]
	public GBFHKENFLNK(int DNKDAGAHJHM, int KMIEJOGGBHG, int IJBCLDGENAJ, int GPJPFNCPHIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class BPPGJJAGOIM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<GBFHKENFLNK> HLHBAMFNMHO
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA9AB90", Offset = "0xA99990", VA = "0x180A9AB90")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<GBFHKENFLNK>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1AA45A0", Offset = "0x1AA33A0", VA = "0x181AA45A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public DLJLKAJCCIG FMEEDFPOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x763880", Offset = "0x762680", VA = "0x180763880")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x760C70", Offset = "0x75FA70", VA = "0x180760C70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC42F0", Offset = "0x5CC30F0", VA = "0x185CC42F0")]
	public BPPGJJAGOIM(IEnumerable<DLJLKAJCCIG> BHGIIJGOJBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CC4280", Offset = "0x5CC3080", VA = "0x185CC4280", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum IIGICJHNNKA
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class CBADDMIHGKB
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> PHFPHBEDHOB;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> KNGJJNMBANA;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> HPEDHJIDOOE;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> DCNADMLHJCJ;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7370", Offset = "0x5CC6170", VA = "0x185CC7370")]
	public static void CLFBHAOODBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7490", Offset = "0x5CC6290", VA = "0x185CC7490")]
	public static NativeArray<float2> FNLIKGLANPM(NativeArray<float2> GDNDOLIDKMD, int NJJJBDIJPDF, NativeArray<float2> FLCMGPHKNKI, int AIBONPGNBNH)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CC75A0", Offset = "0x5CC63A0", VA = "0x185CC75A0")]
	public static NativeArray<float3> ICFNLIHJEJH(NativeArray<float3> GDNDOLIDKMD, int NJJJBDIJPDF, NativeArray<float3> FLCMGPHKNKI, int AIBONPGNBNH)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CC77C0", Offset = "0x5CC65C0", VA = "0x185CC77C0")]
	public static NativeArray<float4> NPLHLLNGFNC(NativeArray<float4> GDNDOLIDKMD, int NJJJBDIJPDF, NativeArray<float4> FLCMGPHKNKI, int AIBONPGNBNH)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CC76B0", Offset = "0x5CC64B0", VA = "0x185CC76B0")]
	public static NativeArray<int> MHIEDPDFOLP(NativeArray<int> GDNDOLIDKMD, int NJJJBDIJPDF, NativeArray<int> FLCMGPHKNKI, int AIBONPGNBNH)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x21E5860", Offset = "0x21E4660", VA = "0x1821E5860")]
	private static void FBPCFKDBHHB<T>(NativeArray<T> OBEMKDLNKLE, int PMOJGMGFBAA) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x21E57B0", Offset = "0x21E45B0", VA = "0x1821E57B0")]
	private static void BMHEEGPOHMN<T>(NativeArray<T> GDNDOLIDKMD, int NJJJBDIJPDF, NativeArray<T> FLCMGPHKNKI, int AIBONPGNBNH, NativeArray<T> MBOLBBFCKCD) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class ENIFLMNHMGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<GNDIBBLLDJJ> FHKOMJCFLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly LPGEKCDAPHC OAOEFIJHJGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int KMIEJOGGBHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int GPJPFNCPHIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool ADHGGKEHOBO;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh FMEEDFPOPPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x7654C0", Offset = "0x7642C0", VA = "0x1807654C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x766E40", Offset = "0x765C40", VA = "0x180766E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer HFDMDOJFNDC
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x763890", Offset = "0x762690", VA = "0x180763890")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int JPMFIFJILOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBAB0", Offset = "0x5CCA8B0", VA = "0x185CCBAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x200FB60", Offset = "0x200E960", VA = "0x18200FB60")]
	public void NBIGIJCONHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBEF0", Offset = "0x5CCACF0", VA = "0x185CCBEF0")]
	public ENIFLMNHMGI(string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBE50", Offset = "0x5CCAC50", VA = "0x185CCBE50")]
	public void OGJJNAJKDPN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBDB0", Offset = "0x5CCABB0", VA = "0x185CCBDB0")]
	public void ENMOCGKNGEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB950", Offset = "0x5CCA750", VA = "0x185CCB950")]
	public void DHDLPOHPCOD(GNDIBBLLDJJ PPAFJDKBICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBAD0", Offset = "0x5CCA8D0", VA = "0x185CCBAD0")]
	private void EHMICNDHGDL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBD40", Offset = "0x5CCAB40", VA = "0x185CCBD40")]
	public bool ELFODLHNLJN(GNDIBBLLDJJ PPAFJDKBICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBE90", Offset = "0x5CCAC90", VA = "0x185CCBE90")]
	public bool PEOEIPDBFBN(GNDIBBLLDJJ PPAFJDKBICB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBDE0", Offset = "0x5CCABE0", VA = "0x185CCBDE0", Slot = "4")]
	public virtual void ILIPOCGONJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB100", Offset = "0x5CC9F00", VA = "0x185CCB100")]
	public void ACOKLCAGOIN(Transform JKKGDAMPLLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB1D0", Offset = "0x5CC9FD0", VA = "0x185CCB1D0")]
	public bool AODMOCGLDPE(Transform JKKGDAMPLLP, [Out] (LADLLAMMHKG destMesh, Mesh mesh, JobHandle job) LMCJHCIOIIP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBA00", Offset = "0x5CCA800", VA = "0x185CCBA00")]
	public void EAFAOACPCFP([In] (LADLLAMMHKG destMesh, Mesh mesh, JobHandle job) LMCJHCIOIIP)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker EGEOOHHALNP;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker KKLKIGHJPGD;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker OLELDHOKIDG;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int EIJBCOEFONE = 65000;

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
		private Dictionary<Material, List<ENIFLMNHMGI>> DDPHAOFIKFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<ENIFLMNHMGI> ODDAOPCEICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> KAHCEEHIJOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(ENIFLMNHMGI, (LADLLAMMHKG, Mesh, JobHandle))> CIDGMJIHFJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool NHMJGMNOIAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> NMAHPPAFGHM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> AKNKBEBCKAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> JPFPOHPMNJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> CCPDNDLGCBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private ENIFLMNHMGI DKMDDDPEJMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material JNEOFCCAPAA;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> BKBMEIPEMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x763870", Offset = "0x762670", VA = "0x180763870")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6310", Offset = "0x5CC5110", VA = "0x185CC6310")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5090", Offset = "0x5CC3E90", VA = "0x185CC5090")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC48B0", Offset = "0x5CC36B0", VA = "0x185CC48B0")]
		public ENIFLMNHMGI AddToBatchedMesh(GNDIBBLLDJJ MCKIEIGMLDA, Material PMPKGHHPFNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6580", Offset = "0x5CC5380", VA = "0x185CC6580")]
		public void RemoveFromBatchedMesh(GNDIBBLLDJJ GIOOFAEFEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4990", Offset = "0x5CC3790", VA = "0x185CC4990")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6700", Offset = "0x5CC5500", VA = "0x185CC6700")]
		public void SetMaterialProperty(int OGIJMJFMMHK, Color CEPDKAIKDOH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6B90", Offset = "0x5CC5990", VA = "0x185CC6B90")]
		public void SetMaterialProperty(int OGIJMJFMMHK, float POACLGOFKAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6DB0", Offset = "0x5CC5BB0", VA = "0x185CC6DB0")]
		public void SetMaterialProperty(int OGIJMJFMMHK, Vector4 HEHABFBDEGK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6930", Offset = "0x5CC5730", VA = "0x185CC6930")]
		public void SetMaterialProperty(int OGIJMJFMMHK, Matrix4x4 CEACNHMKNFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5270", Offset = "0x5CC4070", VA = "0x185CC5270")]
		private void FEIKIFLADCJ(Renderer GAJAAIMEALJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5860", Offset = "0x5CC4660", VA = "0x185CC5860")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4B30", Offset = "0x5CC3930", VA = "0x185CC4B30")]
		private void DCNBECAFAKK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5EF0", Offset = "0x5CC4CF0", VA = "0x185CC5EF0")]
		private ENIFLMNHMGI KOHJMOAOGJP(GNDIBBLLDJJ GIOOFAEFEGJ, Material PMPKGHHPFNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5D20", Offset = "0x5CC4B20", VA = "0x185CC5D20")]
		private ENIFLMNHMGI JHKAEIAONMM(Material PMPKGHHPFNJ, int IFAGGBKGOEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5870", Offset = "0x5CC4670", VA = "0x185CC5870")]
		private ENIFLMNHMGI HIABFACLBDK(Material PMPKGHHPFNJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CC60F0", Offset = "0x5CC4EF0", VA = "0x185CC60F0")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6180", Offset = "0x5CC4F80", VA = "0x185CC6180")]
		public void MarkDirty(GNDIBBLLDJJ GIOOFAEFEGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC70B0", Offset = "0x5CC5EB0", VA = "0x185CC70B0")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class JMFBDCNABGC<KeyType> : ENIFLMNHMGI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, GNDIBBLLDJJ> FFNIHPGPAGH;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3860520", Offset = "0x385F320", VA = "0x183860520")]
	public JMFBDCNABGC(string MEBBBIMBIJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x38602F0", Offset = "0x385F0F0", VA = "0x1838602F0")]
	public void DHDLPOHPCOD(KeyType GMOPMNAPKBE, GNDIBBLLDJJ PPAFJDKBICB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x3860450", Offset = "0x385F250", VA = "0x183860450")]
	public bool MBEDMNNKEBP(KeyType GMOPMNAPKBE, GNDIBBLLDJJ JFJEPKHIGCD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3860250", Offset = "0x385F050", VA = "0x183860250")]
	public void BIMJNABLIGJ(KeyType GMOPMNAPKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3860340", Offset = "0x385F140", VA = "0x183860340", Slot = "4")]
	public override void ILIPOCGONJJ()
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
