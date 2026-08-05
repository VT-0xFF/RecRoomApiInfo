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
public struct PKHAECALKAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct PPKPHHCCEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int JHGLCAAOPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int PEJABOPENNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int BCCFJOFEJND;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int GMMOPEPGMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int BLEDFIKFMHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int DIMBLNFKDMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 INPOALGOLAM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C57080", Offset = "0x7C56280", VA = "0x187C57080")]
		public PPKPHHCCEJL(int BGLJIPLMAAH, int MGPOHFGJFMJ, int CAOALFLCMLC, int NNDGMJNHGOE, int DBABANPGOGM, int NOMNGGDGFHA, float3 PLEIILPBIGD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct MGOKHPAHMLF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int IIGGBEDDJEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int NPFHGJBCPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float BELLKCFNMGK;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xCBA830", Offset = "0xCB9A30", VA = "0x180CBA830")]
		public MGOKHPAHMLF(int OJJILHCFMHP, int DPCIDCHIJJC, float BEJBCBEBEAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JDGLGGAHKDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int NPFHGJBCPHO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int AIFEODKEHEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int BLOOJJJJIMH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, PPKPHHCCEJL> OBNFOFJDLOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<MGOKHPAHMLF> NDJLHKCKGAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> LMLCFFCFAIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JDGLGGAHKDK> EGLLJODBBFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> HBGDFHOBMHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int NJMBLAGFNCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int GMLKMINKIIA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C54710", Offset = "0x7C53910", VA = "0x187C54710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7C55BE0", Offset = "0x7C54DE0", VA = "0x187C55BE0")]
	public bool MOFGGGAKOPK([In] NativeArray<float3> GOKOAAJCBBI, NativeList<float3> KGEEFFHEBBP, NativeList<int> LHKGABDCFKK, Allocator FOPENOLHBOM, CancellationToken HCELDNOKOAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7C54A50", Offset = "0x7C53C50", VA = "0x187C54A50")]
	private void ILLMBOBOELN([In] NativeArray<float3> GOKOAAJCBBI, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7C55D50", Offset = "0x7C54F50", VA = "0x187C55D50")]
	private void OJOLDPIGIDE([In] NativeArray<float3> GOKOAAJCBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7C54D40", Offset = "0x7C53F40", VA = "0x187C54D40")]
	private void JOGHHFNLHKD([In] NativeArray<float3> GOKOAAJCBBI, [Out] int IDBBPOAMKIO, [Out] int HHOBPODMHIL, [Out] int NGGMGACGNJH, [Out] int NHAIIPCFNEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7C54850", Offset = "0x7C53A50", VA = "0x187C54850")]
	private void EGEDJFBCFPH([In] NativeArray<float3> GOKOAAJCBBI, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C537E0", Offset = "0x7C529E0", VA = "0x187C537E0")]
	private void BFKAJLNMEPG([In] NativeArray<float3> GOKOAAJCBBI, float3 IBOHKJNFHBP, int HFJKKEOPKKH, PPKPHHCCEJL BKHKHOAABDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C53CC0", Offset = "0x7C52EC0", VA = "0x187C53CC0")]
	private void CMKJFIALECI([In] NativeArray<float3> GOKOAAJCBBI, float3 IBOHKJNFHBP, int OGELFLBENJO, int GMLKMINKIIA, PPKPHHCCEJL BKHKHOAABDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C54110", Offset = "0x7C53310", VA = "0x187C54110")]
	private void DPFEFLOOABB([In] NativeArray<float3> GOKOAAJCBBI, int CPPFDJBDPDK, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C55740", Offset = "0x7C54940", VA = "0x187C55740")]
	private void MEACIBBKMFE([In] NativeArray<float3> GOKOAAJCBBI, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C55200", Offset = "0x7C54400", VA = "0x187C55200")]
	private void KLPGOHMLCFJ([In] NativeArray<float3> GOKOAAJCBBI, NativeList<float3> KGEEFFHEBBP, NativeList<int> LHKGABDCFKK, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C540B0", Offset = "0x7C532B0", VA = "0x187C540B0")]
	private float DDJFPMENEDG(float3 IBOHKJNFHBP, float3 MBMIOGJDGIF, PPKPHHCCEJL BKHKHOAABDK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C54C30", Offset = "0x7C53E30", VA = "0x187C54C30")]
	private float3 INPOALGOLAM(float3 BGLJIPLMAAH, float3 MGPOHFGJFMJ, float3 CAOALFLCMLC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C55D20", Offset = "0x7C54F20", VA = "0x187C55D20")]
	private static float OCJKMKFPBNA(float3 FCKEKMKDGOB, float3 PMDPDEMGJJE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C556E0", Offset = "0x7C548E0", VA = "0x187C556E0")]
	private static float3 KPONNJEOEFP(float3 FCKEKMKDGOB, float3 PMDPDEMGJJE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C55AB0", Offset = "0x7C54CB0", VA = "0x187C55AB0")]
	private bool MKAJBEGJJPB(float3 FCKEKMKDGOB, float3 PMDPDEMGJJE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C55B10", Offset = "0x7C54D10", VA = "0x187C55B10")]
	private bool MNMHALHNMIG(float3 FCKEKMKDGOB, float3 PMDPDEMGJJE, float3 FLCLDMGPCKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C56D70", Offset = "0x7C55F70", VA = "0x187C56D70")]
	private bool PADOIAPOIIE(float3 FCKEKMKDGOB, float3 PMDPDEMGJJE, float3 FLCLDMGPCKH, float3 BEJBCBEBEAC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PJOLAFENMFG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct GILFGKDAMKF
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
	private NativeList<float3> BKNGNMFPFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> KDNNGOEBDMN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IIHJCLBFMIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7C52C60", Offset = "0x7C51E60", VA = "0x187C52C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DKMEIHDNIPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C52C20", Offset = "0x7C51E20", VA = "0x187C52C20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool CGPGHNNJOHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C52B60", Offset = "0x7C51D60", VA = "0x187C52B60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JLHKNLPDCOK CBFBOIDHFIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C52BA0", Offset = "0x7C51DA0", VA = "0x187C52BA0")]
		get
		{
			return default(JLHKNLPDCOK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C53720", Offset = "0x7C52920", VA = "0x187C53720")]
	public PJOLAFENMFG(int KLACLIDIDNP, int CPBAFNDHECP, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7C53580", Offset = "0x7C52780", VA = "0x187C53580")]
	public PJOLAFENMFG(JLHKNLPDCOK AEKHBAFNNKH, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C535B0", Offset = "0x7C527B0", VA = "0x187C535B0")]
	public PJOLAFENMFG(Mesh KHKMPBIDLPA, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C53220", Offset = "0x7C52420", VA = "0x187C53220")]
	public PJOLAFENMFG(PJOLAFENMFG DHAOEHNLNON, Allocator FOPENOLHBOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C52AD0", Offset = "0x7C51CD0", VA = "0x187C52AD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C52EA0", Offset = "0x7C520A0", VA = "0x187C52EA0")]
	public void OOLDDNFEGEK([In] PJOLAFENMFG LJMBANNFBIJ, float4x4 HBIIBPNLLIO, Transform CPKLBNLBGKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C522A0", Offset = "0x7C514A0", VA = "0x187C522A0")]
	public void AHDLCKJBHJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C52540", Offset = "0x7C51740", VA = "0x187C52540")]
	public void BEFIJJJOINA(float BMKHJPOEOBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7C52CA0", Offset = "0x7C51EA0", VA = "0x187C52CA0")]
	public PJOLAFENMFG MDIAGPCGPOH(Allocator FOPENOLHBOM, CancellationToken HCELDNOKOAM)
	{
		return default(PJOLAFENMFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7C52420", Offset = "0x7C51620", VA = "0x187C52420")]
	public Mesh AKHLHOBJLFF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7C52A80", Offset = "0x7C51C80", VA = "0x187C52A80")]
	private unsafe static float3* DMBDHEEEFPI(NativeArray<float3> CABEAFGDMFF)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7C52A30", Offset = "0x7C51C30", VA = "0x187C52A30")]
	private unsafe static int* DMBDHEEEFPI(NativeArray<int> CABEAFGDMFF)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7C523F0", Offset = "0x7C515F0", VA = "0x187C523F0")]
	[CompilerGenerated]
	internal static void AIALEDALEMC(int BNHPGHAOPMD, int FEGMMOBANPC, GILFGKDAMKF P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JLHKNLPDCOK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int IIHJCLBFMIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DKMEIHDNIPO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AEGCCDHFFMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C52180", Offset = "0x7C51380", VA = "0x187C52180")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x2695C70", Offset = "0x2694E70", VA = "0x182695C70")]
	public static JLHKNLPDCOK FCGKNANLNCA(JLHKNLPDCOK FCKEKMKDGOB, JLHKNLPDCOK PMDPDEMGJJE)
	{
		return default(JLHKNLPDCOK);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7C521E0", Offset = "0x7C513E0", VA = "0x187C521E0")]
	public static JLHKNLPDCOK LCBINPFOAKJ(JLHKNLPDCOK JCHFIBKBLIH, int EMNFBEIKLFD)
	{
		return default(JLHKNLPDCOK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7C52130", Offset = "0x7C51330", VA = "0x187C52130", Slot = "0")]
	public override bool Equals(object LDDIMOELJGE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7C52190", Offset = "0x7C51390", VA = "0x187C52190", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7C52200", Offset = "0x7C51400", VA = "0x187C52200", Slot = "3")]
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
