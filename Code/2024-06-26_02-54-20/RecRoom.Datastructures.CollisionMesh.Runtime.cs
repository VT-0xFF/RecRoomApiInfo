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
public struct KJNPCNCKHOF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FCAHPPEKGDO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int JNDFLKDBLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int OJEPIDINOBF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int EGIFPBMFKAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int FNPIIPKLMHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int PDMEIJAKPKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int KNMCFAKLDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 CGIMAKCEEKH;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6906E60", Offset = "0x6905460", VA = "0x186906E60")]
		public FCAHPPEKGDO(int AJIMMDNMCDL, int DMILAJJMCNH, int MHJHDBCPMIG, int NKJIFLIOJCA, int NMNAPHDACMB, int DDMMOCMMOOI, float3 FFJHDFACBIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct AIPEAJIKHHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int PDDAFFCJCDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int ABIKBGFAMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float GEFDGKAOFOG;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x11C4D40", Offset = "0x11C3340", VA = "0x1811C4D40")]
		public AIPEAJIKHHH(int EBPGHIDCOCJ, int FCMADGIPCIC, float EDKCHBPCEOI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct PNMMFLOCJEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int ABIKBGFAMFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int JOGAEIMDADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int IFNBGLOGMBE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FCAHPPEKGDO> BGJFHALNPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<AIPEAJIKHHH> MPJBJBGDDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> KADCIEFDLCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<PNMMFLOCJEG> EGNBLBBENCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> JDDCKELNCGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int HBIDHFAEMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int ELNEJFKGIKO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6907880", Offset = "0x6905E80", VA = "0x186907880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6908A00", Offset = "0x6907000", VA = "0x186908A00")]
	public bool KDDHKOEAKDJ([In] NativeArray<float3> AKCOCNLDJPM, NativeList<float3> JAEKADPDMHC, NativeList<int> DGLAKPCPOIA, Allocator IDMGOAKOEDG, CancellationToken DADBOHKBJNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6907530", Offset = "0x6905B30", VA = "0x186907530")]
	private void BGGINNGCCML([In] NativeArray<float3> AKCOCNLDJPM, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6909600", Offset = "0x6907C00", VA = "0x186909600")]
	private void NOOBKELDILF([In] NativeArray<float3> AKCOCNLDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6907BC0", Offset = "0x69061C0", VA = "0x186907BC0")]
	private void ENMJFLDFCPF([In] NativeArray<float3> AKCOCNLDJPM, [Out] int PKBHBHAEPNO, [Out] int PJIKIBCJIJN, [Out] int IMPIGJLGFIJ, [Out] int JFLCAOCEDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69079C0", Offset = "0x6905FC0", VA = "0x1869079C0")]
	private void EHPHPKBEAHH([In] NativeArray<float3> AKCOCNLDJPM, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6908E30", Offset = "0x6907430", VA = "0x186908E30")]
	private void NCLCPKBJDML([In] NativeArray<float3> AKCOCNLDJPM, float3 BJEINPMOICP, int ONPDCJBPLKP, FCAHPPEKGDO CDFMLHOICGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6908080", Offset = "0x6906680", VA = "0x186908080")]
	private void FGBANDBEACJ([In] NativeArray<float3> AKCOCNLDJPM, float3 BJEINPMOICP, int MCOBMHKFHPO, int ELNEJFKGIKO, FCAHPPEKGDO CDFMLHOICGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6906EA0", Offset = "0x69054A0", VA = "0x186906EA0")]
	private void AEEBDMIBKEO([In] NativeArray<float3> AKCOCNLDJPM, int AJEPKMDDDNE, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6909290", Offset = "0x6907890", VA = "0x186909290")]
	private void NMGGIACGKDB([In] NativeArray<float3> AKCOCNLDJPM, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6908450", Offset = "0x6906A50", VA = "0x186908450")]
	private void GGMIHAPNCAA([In] NativeArray<float3> AKCOCNLDJPM, NativeList<float3> JAEKADPDMHC, NativeList<int> DGLAKPCPOIA, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6907820", Offset = "0x6905E20", VA = "0x186907820")]
	private float COFCBNEDDPH(float3 BJEINPMOICP, float3 PEGDONJOIDG, FCAHPPEKGDO CDFMLHOICGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6907710", Offset = "0x6905D10", VA = "0x186907710")]
	private float3 CGIMAKCEEKH(float3 AJIMMDNMCDL, float3 DMILAJJMCNH, float3 MHJHDBCPMIG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6907500", Offset = "0x6905B00", VA = "0x186907500")]
	private static float APMFHPLFKLA(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69074A0", Offset = "0x6905AA0", VA = "0x1869074A0")]
	private static float3 ANIIEICCOIK(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x690A610", Offset = "0x6908C10", VA = "0x18690A610")]
	private bool PNFBGMBKFMJ(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6908930", Offset = "0x6906F30", VA = "0x186908930")]
	private bool ICELKBCJBBE(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM, float3 DDKEAFEIAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6908B40", Offset = "0x6907140", VA = "0x186908B40")]
	private bool KOHAIIPDNMM(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM, float3 DDKEAFEIAAJ, float3 EDKCHBPCEOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct BMNPCAMLNFA : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct JLCDAMNNJEL
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
	private NativeList<float3> EHLBKBNMLJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> PHCKJPMBIJH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GHEDKGOGFCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x69060F0", Offset = "0x69046F0", VA = "0x1869060F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69064B0", Offset = "0x6904AB0", VA = "0x1869064B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6905BC0", Offset = "0x69041C0", VA = "0x186905BC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CIFJNAKOGFP IMDHAMKAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69057A0", Offset = "0x6903DA0", VA = "0x1869057A0")]
		get
		{
			return default(CIFJNAKOGFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6906890", Offset = "0x6904E90", VA = "0x186906890")]
	public BMNPCAMLNFA(int PKIBPAHFPLK, int OPOFHOEKKOD, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6906950", Offset = "0x6904F50", VA = "0x186906950")]
	public BMNPCAMLNFA(CIFJNAKOGFP CDOFLBPOMEH, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6906720", Offset = "0x6904D20", VA = "0x186906720")]
	public BMNPCAMLNFA(Mesh NKIMIKOLCFE, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6906980", Offset = "0x6904F80", VA = "0x186906980")]
	public BMNPCAMLNFA(BMNPCAMLNFA FHNKDHIILBL, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6905820", Offset = "0x6903E20", VA = "0x186905820", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6906130", Offset = "0x6904730", VA = "0x186906130")]
	public void MJFEDCBJOBF([In] BMNPCAMLNFA CHNGFEKJHON, float4x4 NBMFEBPFDJH, Transform DAOJLEMLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6905A70", Offset = "0x6904070", VA = "0x186905A70")]
	public void ILPFKEENPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6905C00", Offset = "0x6904200", VA = "0x186905C00")]
	public void KOMIOIDAHEJ(float PNEKGHHAGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6906520", Offset = "0x6904B20", VA = "0x186906520")]
	public BMNPCAMLNFA NGOCGJIMHFA(Allocator IDMGOAKOEDG, CancellationToken DADBOHKBJNO)
	{
		return default(BMNPCAMLNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6905950", Offset = "0x6903F50", VA = "0x186905950")]
	public Mesh FLDAOIJMJNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6905900", Offset = "0x6903F00", VA = "0x186905900")]
	private unsafe static float3* EAHEPEOEMOH(NativeArray<float3> GGEMIJICFPG)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x69058B0", Offset = "0x6903EB0", VA = "0x1869058B0")]
	private unsafe static int* EAHEPEOEMOH(NativeArray<int> GGEMIJICFPG)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x69064F0", Offset = "0x6904AF0", VA = "0x1869064F0")]
	[CompilerGenerated]
	internal static void NGBKJKNLKHD(int OCBFEHOJGEN, int LCPFIHNFBNL, JLCDAMNNJEL P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct CIFJNAKOGFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int GHEDKGOGFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JPOJGPBPILN;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GENFODLGNKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6906CF0", Offset = "0x69052F0", VA = "0x186906CF0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1EAE340", Offset = "0x1EAC940", VA = "0x181EAE340")]
	public static CIFJNAKOGFP DABBFBOOFEB(CIFJNAKOGFP FAGKOOGCGBH, CIFJNAKOGFP HEOHCJKCOLM)
	{
		return default(CIFJNAKOGFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6906DA0", Offset = "0x69053A0", VA = "0x186906DA0")]
	public static CIFJNAKOGFP OLANHAAJLGG(CIFJNAKOGFP IJGMIMHJGIO, int HPNFCDLKBEK)
	{
		return default(CIFJNAKOGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6906D00", Offset = "0x6905300", VA = "0x186906D00", Slot = "0")]
	public override bool Equals(object CNLIJOOKGOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6906D50", Offset = "0x6905350", VA = "0x186906D50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6906DC0", Offset = "0x69053C0", VA = "0x186906DC0", Slot = "3")]
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
