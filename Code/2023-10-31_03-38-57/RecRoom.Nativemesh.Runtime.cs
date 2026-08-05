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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
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
		[Cpp2IlInjected.Address(RVA = "0x787870", Offset = "0x786C70", VA = "0x180787870")]
		public IsUnmanagedAttribute()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FHFANGEBIEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public int GKJEIHOEDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public float3 ILDHLCCBLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public quaternion EKEIOHBKLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public float3 NOMHINJHILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public int FLCAGAFJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public int FEPKEELHEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public int CCFGMLDMHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public float NHCABGOEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public float3 HOOIEIBBLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	public bool EJLFMAPPJOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	public KIJMAKHIOHJ KJGLHFNDKCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	public float3 BDGCPODMCEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	public float DDHEDOJCHDG;
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EODACAPOJNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public static LOBOADJMABL OHKPEBJJAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public NativeList<FHFANGEBIEK> PACJEHJAKBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public NativeList<FHLAMDKOHBD> GLHLOMGCHCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public NativeList<IDDPNEFOFCP> NBFCLMFOFEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public NativeArray<KDICHAPIBED> BDLOLFHJLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public NativeList<FHLAMDKOHBD> KIENGEJKAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public NativeList<AELDAEGNNLE> CMDOJMADNHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<NativeArray<KDICHAPIBED>> KDNFDOLJBIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<LNJHKKKNMOM> MGENEDNOGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private NativeArray<int> MNLLAHMCIIE;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xAE6C70", Offset = "0xAE6070", VA = "0x180AE6C70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAE61E0", Offset = "0xAE55E0", VA = "0x180AE61E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAE6C80", Offset = "0xAE6080", VA = "0x180AE6C80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAE61D0", Offset = "0xAE55D0", VA = "0x180AE61D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDCD0", Offset = "0x5CCD0D0", VA = "0x185CCDCD0")]
	public EODACAPOJNC(int AGDKOJMODKF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC740", Offset = "0x5CCBB40", VA = "0x185CCC740", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC180", Offset = "0x5CCB580", VA = "0x185CCC180")]
	public void DGELADFNLFA(JobHandle IJAGDFPAFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC760", Offset = "0x5CCBB60", VA = "0x185CCC760")]
	public void EAEOCEMGLLM(FHFANGEBIEK GHFAAPNAFDE, LNJHKKKNMOM EBCDNFEJMEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC600", Offset = "0x5CCBA00", VA = "0x185CCC600")]
	public void DJJFECGAKNM(IDDPNEFOFCP GHFAAPNAFDE, NativeArray<KDICHAPIBED> FGBMOMPIENM, int FKEMHPOHBOG, int IIACCFFIKCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC980", Offset = "0x5CCBD80", VA = "0x185CCC980")]
	public JobHandle NKEECFGKGDI(EMENJBKKDBD EIBENLEOENB, BIJPKAJFOFK NJJFBBFPMGG, float3 NDMMMFCJAGO, quaternion CAMBIMEAOML, float POCNONBOHJD, bool PEIALIALDAI, int MDCAIJJBJPA = 0, int MGIOLNHLGNO = 0)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCD990", Offset = "0x5CCCD90", VA = "0x185CCD990")]
	public static JobHandle PLPKMBGNMMJ(AGKFDCKEPLG BPNCKNBAOHM, EMENJBKKDBD EIBENLEOENB, FHFANGEBIEK GHFAAPNAFDE, JobHandle IJAGDFPAFEE)
	{
		return default(JobHandle);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCC350", Offset = "0x5CCB750", VA = "0x185CCC350")]
	public static JobHandle DGLIMENFDLJ(KBKBNMIPOPE BPNCKNBAOHM, EMENJBKKDBD EIBENLEOENB, IDDPNEFOFCP GHFAAPNAFDE, NativeArray<KDICHAPIBED> FGBMOMPIENM, int FKEMHPOHBOG, int IIACCFFIKCA, JobHandle IJAGDFPAFEE)
	{
		return default(JobHandle);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct IJAJGLDMFMH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float2 DHODODFJCCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float2 NFCBNHOGKDC;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class NCPEOHHKOPL : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<IJAJGLDMFMH> HPNCLPGOAOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<int> NMCMEMFLJPK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x75F130", Offset = "0x75E530", VA = "0x18075F130")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x766ED0", Offset = "0x7662D0", VA = "0x180766ED0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0390", Offset = "0x5CCF790", VA = "0x185CD0390")]
	public NCPEOHHKOPL(int IOKKGKBBAKO, int KMMCBOJJKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0250", Offset = "0x5CCF650", VA = "0x185CD0250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5CD02B0", Offset = "0x5CCF6B0", VA = "0x185CD02B0")]
	public void PFCEOOPOAEA(NCPEOHHKOPL AEKLIHIFGNE, int HCOPLLOPJNG, int IDGHKCPGHHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class EIOADCAKPJG
{
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private static NCPEOHHKOPL DCDOEHGEDOG;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private static NativeList<FHLAMDKOHBD> DLIHCCABLFJ;

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static int[] EDOKMPDDKNP;

	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private static bool DHBLOIALPIO;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private static Dictionary<int, NCPEOHHKOPL> LLPKJLDBGHI;

	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static Dictionary<int, NCPEOHHKOPL> HJGELDODIKD;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool CEPFBPLKKAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB120", Offset = "0x5CCA520", VA = "0x185CCB120")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public static NativeList<FHLAMDKOHBD> AOMPMJLOAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5CC9ED0", Offset = "0x5CC92D0", VA = "0x185CC9ED0")]
		get
		{
			return default(NativeList<FHLAMDKOHBD>);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static NCPEOHHKOPL MBFLONCFMPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5CCAF80", Offset = "0x5CCA380", VA = "0x185CCAF80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA090", Offset = "0x5CC9490", VA = "0x185CCA090")]
	private static void EOOAFCHHPCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAEA0", Offset = "0x5CCA2A0", VA = "0x185CCAEA0")]
	public static int GKPCMFELAFD(bool AMAEHPCDENO, int MPMIEANFNNF, bool IKIHNEMGMGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAF60", Offset = "0x5CCA360", VA = "0x185CCAF60")]
	private static int KCIAMBCMOEB(int MPMIEANFNNF, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA060", Offset = "0x5CC9460", VA = "0x185CCA060")]
	private static int EGPPGCGELMP(int MPMIEANFNNF, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAED0", Offset = "0x5CCA2D0", VA = "0x185CCAED0")]
	public static int HDFKONEKLDE(int FJPBEGOLMMB, int MPMIEANFNNF, int LJJIALICEBC, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAE10", Offset = "0x5CCA210", VA = "0x185CCAE10")]
	public static int GHBDKBDMCEM(int FJPBEGOLMMB, int MPMIEANFNNF, int LJJIALICEBC, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB020", Offset = "0x5CCA420", VA = "0x185CCB020")]
	public static int MFDBEOKJJOE(int LJJIALICEBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9E30", Offset = "0x5CC9230", VA = "0x185CC9E30")]
	private static int BADHJKAIFKD(int MPMIEANFNNF, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA070", Offset = "0x5CC9470", VA = "0x185CCA070")]
	private static int ELPAPPBCLJC(int MPMIEANFNNF, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9DC0", Offset = "0x5CC91C0", VA = "0x185CC9DC0")]
	public static int APMNCKBHIPA(int FJPBEGOLMMB, int MPMIEANFNNF, int LJJIALICEBC, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9E40", Offset = "0x5CC9240", VA = "0x185CC9E40")]
	public static int CIIKFFGAHGM(int FJPBEGOLMMB, int MPMIEANFNNF, int LJJIALICEBC, bool MHNGLCMCGLG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5CCADF0", Offset = "0x5CCA1F0", VA = "0x185CCADF0")]
	public static int GCPCLKBCEHB(int LJJIALICEBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9F70", Offset = "0x5CC9370", VA = "0x185CC9F70")]
	public static NCPEOHHKOPL ECFPDIGFEPK(int MPMIEANFNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9B30", Offset = "0x5CC8F30", VA = "0x185CC9B30")]
	private static NCPEOHHKOPL AKHOPNBPCMP(int MPMIEANFNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB030", Offset = "0x5CCA430", VA = "0x185CCB030")]
	public static NCPEOHHKOPL MJPHCJKGCBI(int MPMIEANFNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x5CCAAB0", Offset = "0x5CC9EB0", VA = "0x185CCAAB0")]
	private static NCPEOHHKOPL GAFECGGDFDP(int MPMIEANFNNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5CCA6A0", Offset = "0x5CC9AA0", VA = "0x185CCA6A0")]
	public static void FBEOMFNFJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct IDDPNEFOFCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public int BMABNNLEKKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float3 ILDHLCCBLIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public quaternion EKEIOHBKLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public float NOMHINJHILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public float DDHGLFFNHHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public int FLCAGAFJEAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public int FEPKEELHEIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public int CCFGMLDMHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	public bool AECOLKCHMGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x35")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	public bool HLMPGGLJNEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public float NHCABGOEKOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	public float3 HOOIEIBBLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	public bool MAANAHEJLPN;
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public struct AELDAEGNNLE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public int DABHMNAOGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	public int KBPNCAHLOPJ;
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct KBKBNMIPOPE : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	public NativeList<IDDPNEFOFCP> AAMHGOMKAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public NativeArray<KDICHAPIBED> FPNNNMODEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public NativeArray<FHLAMDKOHBD> JGIIDKFBLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public NativeArray<AELDAEGNNLE> LICMCJGHBAJ;

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDFD0", Offset = "0x5CCD3D0", VA = "0x185CCDFD0")]
	public KBKBNMIPOPE(NativeArray<KDICHAPIBED> FPNNNMODEDL, int DAIAAPJIJOF = 1, Allocator KIKFOGPECEC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCDEE0", Offset = "0x5CCD2E0", VA = "0x185CCDEE0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
[BurstCompile]
public struct CGCJFCDCDKC : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	[ReadOnly]
	private NativeArray<IJAJGLDMFMH> OKLKAAAMICC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	[ReadOnly]
	private NativeArray<int> HIHEHAOKAIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	[ReadOnly]
	private NativeList<FHLAMDKOHBD> PMCJLDANJKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	[ReadOnly]
	private NativeList<IDDPNEFOFCP> AAMHGOMKAGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	[ReadOnly]
	private NativeArray<KDICHAPIBED> FPNNNMODEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	[ReadOnly]
	private NativeArray<FHLAMDKOHBD> JGIIDKFBLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	[ReadOnly]
	public NativeArray<AELDAEGNNLE> LICMCJGHBAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	[ReadOnly]
	private int LEKLJKKIIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	[ReadOnly]
	private int JMFHDMFLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	[ReadOnly]
	private float3 MDFFGAEKBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	[ReadOnly]
	private quaternion PIJGOJJGNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	[ReadOnly]
	private float3 IPMHMFIJDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EDILIEEGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DHFDBGHGACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HJDLDFDFKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LIIGOBAELCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> PFHFOEEBDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KAJDJDNOCNF;

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8760", Offset = "0x5CC7B60", VA = "0x185CC8760")]
	public CGCJFCDCDKC(EODACAPOJNC CIDPNLAINGA, EMENJBKKDBD BDCJILGHICJ, float3 MAFEFMPEPEI, quaternion LCFPKDOLEAJ, float LMDEPLGLKHH, int MDCAIJJBJPA = 0, int MGIOLNHLGNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC89F0", Offset = "0x5CC7DF0", VA = "0x185CC89F0")]
	public CGCJFCDCDKC(KBKBNMIPOPE CIDPNLAINGA, EMENJBKKDBD BDCJILGHICJ, float3 MAFEFMPEPEI, quaternion LCFPKDOLEAJ, float3 LMDEPLGLKHH, int MDCAIJJBJPA = 0, int MGIOLNHLGNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC67E0", Offset = "0x5CC5BE0", VA = "0x185CC67E0")]
	private float3 CLAHNLIMKLK(float3 ONPDIFIIJGF, Matrix4x4 CIOKJFGBEDM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC86E0", Offset = "0x5CC7AE0", VA = "0x185CC86E0")]
	private float3x3 PGHAELBGEPN(float3x3 DIGCEPPMPJA, float3x3 CBJHJONBMDM)
	{
		return default(float3x3);
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7C20", Offset = "0x5CC7020", VA = "0x185CC7C20")]
	private float GDOMIIIEBOC(float NMGPAHAPPCF, float HLDGKJNEEHK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x5CC6910", Offset = "0x5CC5D10", VA = "0x185CC6910", Slot = "4")]
	public void Execute(int FPPGKNBCDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7AB0", Offset = "0x5CC6EB0", VA = "0x185CC7AB0")]
	private void FAGPECEGEPD(int CHKLJDNACEN, float3 LPAPEIIOLFG, float3 MBCOBAGMLHO, float3 IKDCMIMDMLO, float NOEHIDPEPEC, bool KOKKIKAACEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5CC7C30", Offset = "0x5CC7030", VA = "0x185CC7C30")]
	private void LDNPACOMMHB(IDDPNEFOFCP LPPEFGLDELC, float3 HLENKEBAKND, float3x3 OCCLANFLOLP, float NMGPAHAPPCF, int EFMBDPDEGHH, int ADIDPPGBIKE, int IBCGOAGMNLG, float MPBHGBNDKDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8090", Offset = "0x5CC7490", VA = "0x185CC8090")]
	private void MCGKPAKOCMC(int CHKLJDNACEN, int KEEHGKHJCMK, IDDPNEFOFCP LPPEFGLDELC, float3 HLENKEBAKND, float3x3 OCCLANFLOLP, bool IMLJGIGOPEK, float NMGPAHAPPCF, int JIGNLFMHEBH, int HICEPLLKDBI, int IBCGOAGMNLG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct AGKFDCKEPLG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public NativeList<FHFANGEBIEK> PLPMLMIGHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public NativeList<FHLAMDKOHBD> JAELNCLGICG;

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2170", Offset = "0x5CC1570", VA = "0x185CC2170")]
	public AGKFDCKEPLG(int DAIAAPJIJOF, Allocator KIKFOGPECEC = Allocator.TempJob)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5CC20D0", Offset = "0x5CC14D0", VA = "0x185CC20D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
[BurstCompile]
public struct OKMHJOLPLCD : IJobFor
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private enum EBBPCGJOJND
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
	private NativeList<float3> NBOCDJKDEEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	[ReadOnly]
	private NativeArray<float3> ADOEGGANFHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	[ReadOnly]
	private NativeList<int> BLHMKAHCIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	[ReadOnly]
	private NativeArray<int> HFIFPLJHHKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	[ReadOnly]
	private NativeArray<float4> ALECMNHKBLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	[ReadOnly]
	private NativeArray<float4> HIOKBDAGPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	[ReadOnly]
	private NativeArray<float4> NPODKPEBGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	[ReadOnly]
	private NativeList<float3> LOMOPAOOKPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	[ReadOnly]
	private NativeList<FHLAMDKOHBD> OJNDHJKPJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	[ReadOnly]
	private NativeList<FHFANGEBIEK> PLPMLMIGHAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	[ReadOnly]
	private NativeList<FHLAMDKOHBD> JAELNCLGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	[ReadOnly]
	private int LEKLJKKIIDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	[ReadOnly]
	private int JMFHDMFLGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> EDILIEEGJOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float3> DHFDBGHGACO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> HJDLDFDFKAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> LIIGOBAELCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float2> PFHFOEEBDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> KAJDJDNOCNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	[ReadOnly]
	private float3 IPMHMFIJDOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x124")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	[ReadOnly]
	private quaternion PIJGOJJGNDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x134")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	[ReadOnly]
	private float3 MDFFGAEKBEE;

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1A50", Offset = "0x5CD0E50", VA = "0x185CD1A50")]
	public OKMHJOLPLCD(EODACAPOJNC CIDPNLAINGA, EMENJBKKDBD BDCJILGHICJ, float3 MAFEFMPEPEI, quaternion LCFPKDOLEAJ, float LMDEPLGLKHH, int MDCAIJJBJPA = 0, int MGIOLNHLGNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1860", Offset = "0x5CD0C60", VA = "0x185CD1860")]
	public OKMHJOLPLCD(AGKFDCKEPLG GHFAAPNAFDE, EMENJBKKDBD BDCJILGHICJ, float3 MAFEFMPEPEI, quaternion LCFPKDOLEAJ, float3 LMDEPLGLKHH, int MDCAIJJBJPA = 0, int MGIOLNHLGNO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0850", Offset = "0x5CCFC50", VA = "0x185CD0850", Slot = "4")]
	public void Execute(int FPPGKNBCDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5CD04A0", Offset = "0x5CCF8A0", VA = "0x185CD04A0")]
	private void CEKECJAJIEM(float4x4 KIJFOJEHAKL, int FPPGKNBCDNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x5CD17B0", Offset = "0x5CD0BB0", VA = "0x185CD17B0")]
	private EBBPCGJOJND GOEECAHHAOA(float3 MBCOBAGMLHO)
	{
		return default(EBBPCGJOJND);
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0450", Offset = "0x5CCF850", VA = "0x185CD0450")]
	private float4 CECFCFGAMDG(EBBPCGJOJND ELCBGFEFFOK, int APOENOPNHBG)
	{
		return default(float4);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1820", Offset = "0x5CD0C20", VA = "0x185CD1820")]
	private float2 MHPPPHPNMPA(EBBPCGJOJND ELCBGFEFFOK, float3 LPAPEIIOLFG)
	{
		return default(float2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct LNJHKKKNMOM
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum KHJCEEIGNIO
	{
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		None,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Box,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Sphere
	}

	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public static LNJHKKKNMOM OAIDPCAHLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float3 AFLOHMGJCHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float3x3 LLPNDHMIBDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float3 LMJBHMFNAOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public KHJCEEIGNIO EANPJBEPKCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float3 LKGBPPJBBGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public float3 HADDIGBPIHI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AAMDFDDBPGE
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x5CCE4E0", Offset = "0x5CCD8E0", VA = "0x185CCE4E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float3 PMDAKMBFFBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x5CCE300", Offset = "0x5CCD700", VA = "0x185CCE300")]
		get
		{
			return default(float3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEA90", Offset = "0x5CCDE90", VA = "0x185CCEA90")]
	public LNJHKKKNMOM(float3 LPAPEIIOLFG, quaternion KBKHJHIFKGI, float3 DAIAAPJIJOF, KHJCEEIGNIO IJFAMCPOKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE100", Offset = "0x5CCD500", VA = "0x185CCE100")]
	public float ACGHCHIOAEG(float3 HLENKEBAKND, float LAODELGAABA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE4F0", Offset = "0x5CCD8F0", VA = "0x185CCE4F0")]
	public bool IJMPAOLFOMH(float3 MBCOBAGMLHO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE5E0", Offset = "0x5CCD9E0", VA = "0x185CCE5E0")]
	public void KDAGFHMAMKC(float3 MIKILGPFFMN, float3x3 GLJPFNCNNJD, float HFAJCKOFBCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE3E0", Offset = "0x5CCD7E0", VA = "0x185CCE3E0")]
	private void HIDEFBCKION(float3 GKDNLKGKKGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5CCE790", Offset = "0x5CCDB90", VA = "0x185CCE790")]
	public void NHOHHNPKMLP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
[BurstCompile]
public struct MFMLAIIFGIA : IJobFor
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	[ReadOnly]
	private NativeList<LNJHKKKNMOM> GHFAAPNAFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	[ReadOnly]
	private NativeList<float3> LLGHLOCGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	[ReadOnly]
	private NativeList<int> PIHPAKAJMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<int> MNLLAHMCIIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	[ReadOnly]
	private NativeList<FHLAMDKOHBD> JAELNCLGICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	[ReadOnly]
	private int HBGLDMDDCJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	[ReadOnly]
	private int GLPDOAKDNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	[ReadOnly]
	private float LAODELGAABA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	[ReadOnly]
	private float CNABPLNOFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> FABKDNIOAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<bool> CFHBEIADGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float> IEHLHGBKKKH;

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFC50", Offset = "0x5CCF050", VA = "0x185CCFC50")]
	public MFMLAIIFGIA(EMENJBKKDBD PACIGNFPLIB, float LCPIFCKEECE, int IDGHKCPGHHK, int EFMBDPDEGHH, NativeList<LNJHKKKNMOM> GHFAAPNAFDE, NativeArray<int> MNLLAHMCIIE, NativeList<FHLAMDKOHBD> JAELNCLGICG, BIJPKAJFOFK NJJFBBFPMGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF270", Offset = "0x5CCE670", VA = "0x185CCF270", Slot = "4")]
	public void Execute(int BPMFGFFJPEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF1B0", Offset = "0x5CCE5B0", VA = "0x185CCF1B0")]
	private bool DFBNENJCEPN(LNJHKKKNMOM IFAOGMEBPFN, LNJHKKKNMOM DNPBOPMFFFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5CCF9B0", Offset = "0x5CCEDB0", VA = "0x185CCF9B0")]
	private bool KLGGBBFCECF(LNJHKKKNMOM EGKDMEOOPIK, int OCDODEKJFHL, int JKCLKJHLJJM, int GFKFNODIEAL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BIJPKAJFOFK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public NativeArray<bool> IMAIILIJPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public NativeArray<int> BKGMABLDOJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public NativeArray<bool> DIKLDNDBNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeArray<float> EABMIMOPGCH;

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2370", Offset = "0x5CC1770", VA = "0x185CC2370")]
	public void MJJNKIBPEID(int IOKKGKBBAKO, int KMMCBOJJKJH, Allocator KIKFOGPECEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2350", Offset = "0x5CC1750", VA = "0x185CC2350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2260", Offset = "0x5CC1660", VA = "0x185CC2260")]
	public void DGELADFNLFA(JobHandle IJAGDFPAFEE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public BIJPKAJFOFK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
[BurstCompile]
public struct BKBBLHLHGGF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	private NativeList<float3> LLGHLOCGCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private NativeArray<float3> ONEEJLLNOHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private NativeArray<float4> BMJAEALDEEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private NativeArray<float2> KKAAAFHNGGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private NativeList<int> PIHPAKAJMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	[NativeDisableContainerSafetyRestriction]
	private NativeArray<float4> DEIIIKFJMJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private NativeArray<int> BKGJDMOKJAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	[ReadOnly]
	private NativeArray<bool> FABKDNIOAHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	[ReadOnly]
	private NativeArray<bool> CFHBEIADGKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	[ReadOnly]
	private int MDCAIJJBJPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	[ReadOnly]
	private int MGIOLNHLGNO;

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC28B0", Offset = "0x5CC1CB0", VA = "0x185CC28B0")]
	public BKBBLHLHGGF(EMENJBKKDBD PACIGNFPLIB, BIJPKAJFOFK NJJFBBFPMGG, int MGIOLNHLGNO = 0, int MDCAIJJBJPA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC24D0", Offset = "0x5CC18D0", VA = "0x185CC24D0", Slot = "4")]
	public void Execute()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2470", Offset = "0x5CC1870", VA = "0x185CC2470")]
	private void EJAFCAFFEML()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public static class BPDCEGNFFKE
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x21A8150", Offset = "0x21A7550", VA = "0x1821A8150")]
	public static bool KFNCODKKLFD<T>(NativeArray<T> FFAHMFOPGLA, int DAIAAPJIJOF, Allocator KIKFOGPECEC, NativeArrayOptions PHAIIGMLKHM = NativeArrayOptions.ClearMemory) where T : struct
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x21A81F0", Offset = "0x21A75F0", VA = "0x1821A81F0")]
	public static bool KFNCODKKLFD<T>(NativeList<T> KEKPLKHNJAG, int DAIAAPJIJOF, Allocator KIKFOGPECEC) where T : struct
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum GBBHIBKCDKO
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
public interface PPACOLCALOJ
{
	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(Slot = "0")]
	int OECBLBHDECI(GBBHIBKCDKO FJPBEGOLMMB);

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(Slot = "1")]
	int AMCDLEILJKD(GBBHIBKCDKO FJPBEGOLMMB);

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void BMFGJAIAMNM(GBBHIBKCDKO FJPBEGOLMMB, EODACAPOJNC FBJEAONNLEB, int CLCLDKHEDEI = -1);
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class EMENJBKKDBD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public const int FMGBDJIBIKD = 2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public NativeList<float3> NOJMGGPIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public NativeArray<float3> EEKDCJDLODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public NativeArray<float4> KHNJHAPCAPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public NativeArray<float4> FLOKFGFNOHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public NativeArray<float2> GDDOHHJGMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public NativeList<int> IIABFCMCPIO;

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public bool DDHCPHLKOFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBB10", Offset = "0x5CCAF10", VA = "0x185CCBB10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x5CCB310", Offset = "0x5CCA710", VA = "0x185CCB310")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBAD0", Offset = "0x5CCAED0", VA = "0x185CCBAD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public bool MBFFGGDHLLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x5CCBA90", Offset = "0x5CCAE90", VA = "0x185CCBA90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB980", Offset = "0x5CCAD80", VA = "0x185CCB980", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBFB0", Offset = "0x5CCB3B0", VA = "0x185CCBFB0")]
	public void MJJNKIBPEID(int IOKKGKBBAKO, int KMMCBOJJKJH, Allocator KIKFOGPECEC, bool INGLOPOPCKL, bool IICHLMAMKDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBB50", Offset = "0x5CCAF50", VA = "0x185CCBB50")]
	public void JEKEAMBAHNO(int IOKKGKBBAKO, int KMMCBOJJKJH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5CCBBD0", Offset = "0x5CCAFD0", VA = "0x185CCBBD0", Slot = "6")]
	public bool JGCKMEDLPAA(Mesh PACIGNFPLIB, bool CAKNFDKLAMG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5CCB350", Offset = "0x5CCA750", VA = "0x185CCB350")]
	public bool BNAJIGPHEDC(Mesh PACIGNFPLIB, EMENJBKKDBD OBOEACKKFHN, bool CAKNFDKLAMG = true)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
	public EMENJBKKDBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public static class PONILPPEPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5CD1C40", Offset = "0x5CD1040", VA = "0x185CD1C40")]
	public static void FBEOMFNFJIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class BOPPKLGCGNC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public NativeList<float3> NOJMGGPIGGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public NativeArray<float3> EEKDCJDLODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public NativeArray<int> OAELJOMHGFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public NativeArray<float4> HFDEPLOGGAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public NativeArray<float4> OGHCMNJOLHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public NativeArray<float4> PCNJBFAKPMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public NativeList<float3> IGFLIONLKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public NativeList<int> IIABFCMCPIO;

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2930", Offset = "0x5CC1D30", VA = "0x185CC2930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public int OHBANGANJKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x5CC2A80", Offset = "0x5CC1E80", VA = "0x185CC2A80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public int AODJPAALEPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x5CC37D0", Offset = "0x5CC2BD0", VA = "0x185CC37D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3B00", Offset = "0x5CC2F00", VA = "0x185CC3B00")]
	public BOPPKLGCGNC(int IOKKGKBBAKO, int KMMCBOJJKJH, int IJHKBEEKFAN, Allocator KIKFOGPECEC = Allocator.Persistent)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x5CC3810", Offset = "0x5CC2C10", VA = "0x185CC3810")]
	public BOPPKLGCGNC(Mesh PACIGNFPLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2970", Offset = "0x5CC1D70", VA = "0x185CC2970", Slot = "5")]
	public virtual void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x5CC34D0", Offset = "0x5CC28D0", VA = "0x185CC34D0")]
	public void PFCEOOPOAEA(BOPPKLGCGNC PACIGNFPLIB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2AC0", Offset = "0x5CC1EC0", VA = "0x185CC2AC0")]
	private void NJGNHAJNANL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5CC2F50", Offset = "0x5CC2350", VA = "0x185CC2F50")]
	private void OFPOKIEMCMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct FHLAMDKOHBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public int FMILPBDELGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public int DLKNAEBHFAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public int CPFMGONMJCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public int OHBANGANJKE;

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x10902F0", Offset = "0x108F6F0", VA = "0x1810902F0")]
	public FHLAMDKOHBD(int EFMBDPDEGHH, int FKEMHPOHBOG, int IDGHKCPGHHK, int IIACCFFIKCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class LOBOADJMABL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public NativeList<FHLAMDKOHBD> DIHFIHAPEOI
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0xA9D400", Offset = "0xA9C800", VA = "0x180A9D400")]
		[CompilerGenerated]
		get
		{
			return default(NativeList<FHLAMDKOHBD>);
		}
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x1A94150", Offset = "0x1A93550", VA = "0x181A94150")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public BOPPKLGCGNC LIOODODBCOK
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x764960", Offset = "0x763D60", VA = "0x180764960")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x760A90", Offset = "0x75FE90", VA = "0x180760A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEBF0", Offset = "0x5CCDFF0", VA = "0x185CCEBF0")]
	public LOBOADJMABL(IEnumerable<BOPPKLGCGNC> AMONFBOJEIM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x5CCEB80", Offset = "0x5CCDF80", VA = "0x185CCEB80", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum KIJMAKHIOHJ
{
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Normal,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	Pyramid
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class MHIGKOEHNKH
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private static NativeArray<float2> KPCLHMLJFPO;

	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private static NativeArray<float3> MDJGAHHAFPF;

	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private static NativeArray<float4> JGNMELMNKND;

	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private static NativeArray<int> IHCLLMJKNIE;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFE00", Offset = "0x5CCF200", VA = "0x185CCFE00")]
	public static void FBEOMFNFJIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0140", Offset = "0x5CCF540", VA = "0x185CD0140")]
	public static NativeArray<float2> OLLONAGHNIC(NativeArray<float2> HGNLAHEDMKI, int KGIHGGFOAKH, NativeArray<float2> KMNHGACBLEK, int HFMMFNKGGLL)
	{
		return default(NativeArray<float2>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x5CD0030", Offset = "0x5CCF430", VA = "0x185CD0030")]
	public static NativeArray<float3> NGABCAKMDAJ(NativeArray<float3> HGNLAHEDMKI, int KGIHGGFOAKH, NativeArray<float3> KMNHGACBLEK, int HFMMFNKGGLL)
	{
		return default(NativeArray<float3>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFF20", Offset = "0x5CCF320", VA = "0x185CCFF20")]
	public static NativeArray<float4> NFLJHGBAMAE(NativeArray<float4> HGNLAHEDMKI, int KGIHGGFOAKH, NativeArray<float4> KMNHGACBLEK, int HFMMFNKGGLL)
	{
		return default(NativeArray<float4>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x5CCFCF0", Offset = "0x5CCF0F0", VA = "0x185CCFCF0")]
	public static NativeArray<int> DIALIFHGMEL(NativeArray<int> HGNLAHEDMKI, int KGIHGGFOAKH, NativeArray<int> KMNHGACBLEK, int HFMMFNKGGLL)
	{
		return default(NativeArray<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x2477A60", Offset = "0x2476E60", VA = "0x182477A60")]
	private static void BGMGHLGOIAO<T>(NativeArray<T> FFAHMFOPGLA, int HHKDGCMFDDM) where T : struct
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x2477C60", Offset = "0x2477060", VA = "0x182477C60")]
	private static void IDNGOFBCFOE<T>(NativeArray<T> HGNLAHEDMKI, int KGIHGGFOAKH, NativeArray<T> KMNHGACBLEK, int HFMMFNKGGLL, NativeArray<T> DHMDAGGDFLI) where T : struct
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class DCCHFNDGNJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private readonly List<PPACOLCALOJ> GMPPMJJPOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private readonly BLCHKNJPCEA FNGOMCOHKPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private int FKEMHPOHBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private int IIACCFFIKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private bool GPNOODNEKKK;

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	public Mesh LIOODODBCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x75C780", Offset = "0x75BB80", VA = "0x18075C780")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x764970", Offset = "0x763D70", VA = "0x180764970")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public MeshRenderer DIAEBNPLIPE
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7681F0", Offset = "0x7675F0", VA = "0x1807681F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public int DLKNAEBHFAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5CC8C20", Offset = "0x5CC8020", VA = "0x185CC8C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x200D3F0", Offset = "0x200C7F0", VA = "0x18200D3F0")]
	public void BHHOELJGEMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9A10", Offset = "0x5CC8E10", VA = "0x185CC9A10")]
	public DCCHFNDGNJL(string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8D20", Offset = "0x5CC8120", VA = "0x185CC8D20")]
	public void DGELADFNLFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8C40", Offset = "0x5CC8040", VA = "0x185CC8C40")]
	public void ALAJJJACJKC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8C70", Offset = "0x5CC8070", VA = "0x185CC8C70")]
	public void AMJAAPCJACA(PPACOLCALOJ HJADFIDBLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8DD0", Offset = "0x5CC81D0", VA = "0x185CC8DD0")]
	private void GFPCBJGOFAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9170", Offset = "0x5CC8570", VA = "0x185CC9170")]
	public bool HGOJIHAHKCI(PPACOLCALOJ HJADFIDBLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9110", Offset = "0x5CC8510", VA = "0x185CC9110")]
	public bool GPJELEPHCCH(PPACOLCALOJ HJADFIDBLHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x5CC8D60", Offset = "0x5CC8160", VA = "0x185CC8D60", Slot = "4")]
	public virtual void DHKBBHHCBCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9040", Offset = "0x5CC8440", VA = "0x185CC9040")]
	public void GJBBMKPIING(Transform BDIPMCHFJLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x5CC91E0", Offset = "0x5CC85E0", VA = "0x185CC91E0")]
	public bool NBMPDADDIKJ(Transform BDIPMCHFJLP, [Out] (EMENJBKKDBD destMesh, Mesh mesh, JobHandle job) GHFAAPNAFDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x5CC9960", Offset = "0x5CC8D60", VA = "0x185CC9960")]
	public void NOCNONEGLOO([In] (EMENJBKKDBD destMesh, Mesh mesh, JobHandle job) GHFAAPNAFDE)
	{
	}
}
namespace RecRoom.Core.Creation.Shapes
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class BatchedMeshRenderer : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		private static readonly ProfilerMarker CBCKKHNCGKH;

		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private static readonly ProfilerMarker OPNHBACPJCD;

		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		private static readonly ProfilerMarker NGPAKDIEHBK;

		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		private const int JCEFHFCOKFM = 65000;

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
		private Dictionary<Material, List<DCCHFNDGNJL>> DPNMOLCOGDF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		private List<DCCHFNDGNJL> OBJHJGHJOJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		private List<MeshRenderer> ABGEIGHELOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		private List<(DCCHFNDGNJL, (EMENJBKKDBD, Mesh, JobHandle))> PAPHDCINHAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private bool FCHFOAADGFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		private Dictionary<int, float> LBNCBKEPPDB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		private Dictionary<int, Color> FHJOMIKOGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		private Dictionary<int, Vector4> HMIHJECJKHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		private Dictionary<int, Matrix4x4> CPLPLKKOBDL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		private DCCHFNDGNJL NBOKCCLLKGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		private Material OCOLLLAABLL;

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public IReadOnlyList<MeshRenderer> MFLNOHMKHDI
		{
			[Cpp2IlInjected.Token(Token = "0x6000088")]
			[Cpp2IlInjected.Address(RVA = "0x75C7D0", Offset = "0x75BBD0", VA = "0x18075C7D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5780", Offset = "0x5CC4B80", VA = "0x185CC5780")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4450", Offset = "0x5CC3850", VA = "0x185CC4450")]
		public MeshRenderer[] DetachMeshesAndRenderers()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3D20", Offset = "0x5CC3120", VA = "0x185CC3D20")]
		public DCCHFNDGNJL AddToBatchedMesh(PPACOLCALOJ FCGODNKMJBH, Material JGKNCBCEPPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5CC59F0", Offset = "0x5CC4DF0", VA = "0x185CC59F0")]
		public void RemoveFromBatchedMesh(PPACOLCALOJ PACIGNFPLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x5CC42B0", Offset = "0x5CC36B0", VA = "0x185CC42B0")]
		public void ClearAllBatchedMeshes()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5B70", Offset = "0x5CC4F70", VA = "0x185CC5B70")]
		public void SetMaterialProperty(int KMKGEGCGMGD, Color DJDNAMFLFCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6000", Offset = "0x5CC5400", VA = "0x185CC6000")]
		public void SetMaterialProperty(int KMKGEGCGMGD, float EOHMJBFGDPD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6220", Offset = "0x5CC5620", VA = "0x185CC6220")]
		public void SetMaterialProperty(int KMKGEGCGMGD, Vector4 NCJNPFGDEGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5DA0", Offset = "0x5CC51A0", VA = "0x185CC5DA0")]
		public void SetMaterialProperty(int KMKGEGCGMGD, Matrix4x4 IADDOCEOKGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4640", Offset = "0x5CC3A40", VA = "0x185CC4640")]
		private void GHPBPLNPGKD(Renderer AOGGKMLJCIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4630", Offset = "0x5CC3A30", VA = "0x185CC4630")]
		public void ForceUpdateBatchedMeshOnGPU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4E00", Offset = "0x5CC4200", VA = "0x185CC4E00")]
		private void IFOOOJNGAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5580", Offset = "0x5CC4980", VA = "0x185CC5580")]
		private DCCHFNDGNJL OAILJBCMGLK(PPACOLCALOJ PACIGNFPLIB, Material JGKNCBCEPPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x5CC4C30", Offset = "0x5CC4030", VA = "0x185CC4C30")]
		private DCCHFNDGNJL IFHFPKJCCFC(Material JGKNCBCEPPI, int AMHLLNPBKLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x5CC3E00", Offset = "0x5CC3200", VA = "0x185CC3E00")]
		private DCCHFNDGNJL CJAAHCOJGNA(Material JGKNCBCEPPI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x5CC5360", Offset = "0x5CC4760", VA = "0x185CC5360")]
		public void MarkDirty()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x5CC53F0", Offset = "0x5CC47F0", VA = "0x185CC53F0")]
		public void MarkDirty(PPACOLCALOJ PACIGNFPLIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x5CC6520", Offset = "0x5CC5920", VA = "0x185CC6520")]
		public BatchedMeshRenderer()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DDKHJDJJNBK<KeyType> : DCCHFNDGNJL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private readonly Dictionary<KeyType, PPACOLCALOJ> BGFMMMAKEEN;

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x4C7F650", Offset = "0x4C7EA50", VA = "0x184C7F650")]
	public DDKHJDJJNBK(string LFAIHEECJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x4C7F2E0", Offset = "0x4C7E6E0", VA = "0x184C7F2E0")]
	public void AMJAAPCJACA(KeyType DGCJCBHPPBD, PPACOLCALOJ HJADFIDBLHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x4C7F330", Offset = "0x4C7E730", VA = "0x184C7F330")]
	public bool CJHJBPCCNEN(KeyType DGCJCBHPPBD, PPACOLCALOJ HLMFMNKBIMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4C7F510", Offset = "0x4C7E910", VA = "0x184C7F510")]
	public void FDDHPLLAFCA(KeyType DGCJCBHPPBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x4C7F4D0", Offset = "0x4C7E8D0", VA = "0x184C7F4D0", Slot = "4")]
	public override void DHKBBHHCBCE()
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
