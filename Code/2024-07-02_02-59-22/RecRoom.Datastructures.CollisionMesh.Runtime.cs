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
		[Cpp2IlInjected.Address(RVA = "0x6939370", Offset = "0x6938370", VA = "0x186939370")]
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
		[Cpp2IlInjected.Address(RVA = "0x11CCEB0", Offset = "0x11CBEB0", VA = "0x1811CCEB0")]
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
	[Cpp2IlInjected.Address(RVA = "0x6939D90", Offset = "0x6938D90", VA = "0x186939D90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x693AF10", Offset = "0x6939F10", VA = "0x18693AF10")]
	public bool KDDHKOEAKDJ([In] NativeArray<float3> AKCOCNLDJPM, NativeList<float3> JAEKADPDMHC, NativeList<int> DGLAKPCPOIA, Allocator IDMGOAKOEDG, CancellationToken DADBOHKBJNO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6939A40", Offset = "0x6938A40", VA = "0x186939A40")]
	private void BGGINNGCCML([In] NativeArray<float3> AKCOCNLDJPM, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x693BB10", Offset = "0x693AB10", VA = "0x18693BB10")]
	private void NOOBKELDILF([In] NativeArray<float3> AKCOCNLDJPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x693A0D0", Offset = "0x69390D0", VA = "0x18693A0D0")]
	private void ENMJFLDFCPF([In] NativeArray<float3> AKCOCNLDJPM, [Out] int PKBHBHAEPNO, [Out] int PJIKIBCJIJN, [Out] int IMPIGJLGFIJ, [Out] int JFLCAOCEDAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6939ED0", Offset = "0x6938ED0", VA = "0x186939ED0")]
	private void EHPHPKBEAHH([In] NativeArray<float3> AKCOCNLDJPM, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x693B340", Offset = "0x693A340", VA = "0x18693B340")]
	private void NCLCPKBJDML([In] NativeArray<float3> AKCOCNLDJPM, float3 BJEINPMOICP, int ONPDCJBPLKP, FCAHPPEKGDO CDFMLHOICGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x693A590", Offset = "0x6939590", VA = "0x18693A590")]
	private void FGBANDBEACJ([In] NativeArray<float3> AKCOCNLDJPM, float3 BJEINPMOICP, int MCOBMHKFHPO, int ELNEJFKGIKO, FCAHPPEKGDO CDFMLHOICGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69393B0", Offset = "0x69383B0", VA = "0x1869393B0")]
	private void AEEBDMIBKEO([In] NativeArray<float3> AKCOCNLDJPM, int AJEPKMDDDNE, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x693B7A0", Offset = "0x693A7A0", VA = "0x18693B7A0")]
	private void NMGGIACGKDB([In] NativeArray<float3> AKCOCNLDJPM, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x693A960", Offset = "0x6939960", VA = "0x18693A960")]
	private void GGMIHAPNCAA([In] NativeArray<float3> AKCOCNLDJPM, NativeList<float3> JAEKADPDMHC, NativeList<int> DGLAKPCPOIA, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6939D30", Offset = "0x6938D30", VA = "0x186939D30")]
	private float COFCBNEDDPH(float3 BJEINPMOICP, float3 PEGDONJOIDG, FCAHPPEKGDO CDFMLHOICGE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6939C20", Offset = "0x6938C20", VA = "0x186939C20")]
	private float3 CGIMAKCEEKH(float3 AJIMMDNMCDL, float3 DMILAJJMCNH, float3 MHJHDBCPMIG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6939A10", Offset = "0x6938A10", VA = "0x186939A10")]
	private static float APMFHPLFKLA(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69399B0", Offset = "0x69389B0", VA = "0x1869399B0")]
	private static float3 ANIIEICCOIK(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x693CB20", Offset = "0x693BB20", VA = "0x18693CB20")]
	private bool PNFBGMBKFMJ(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x693AE40", Offset = "0x6939E40", VA = "0x18693AE40")]
	private bool ICELKBCJBBE(float3 FAGKOOGCGBH, float3 HEOHCJKCOLM, float3 DDKEAFEIAAJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x693B050", Offset = "0x693A050", VA = "0x18693B050")]
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
		[Cpp2IlInjected.Address(RVA = "0x6938600", Offset = "0x6937600", VA = "0x186938600")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JPOJGPBPILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69389C0", Offset = "0x69379C0", VA = "0x1869389C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NEIPGPKBIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69380D0", Offset = "0x69370D0", VA = "0x1869380D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CIFJNAKOGFP IMDHAMKAIMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6937CB0", Offset = "0x6936CB0", VA = "0x186937CB0")]
		get
		{
			return default(CIFJNAKOGFP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6938DA0", Offset = "0x6937DA0", VA = "0x186938DA0")]
	public BMNPCAMLNFA(int PKIBPAHFPLK, int OPOFHOEKKOD, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6938E60", Offset = "0x6937E60", VA = "0x186938E60")]
	public BMNPCAMLNFA(CIFJNAKOGFP CDOFLBPOMEH, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6938C30", Offset = "0x6937C30", VA = "0x186938C30")]
	public BMNPCAMLNFA(Mesh NKIMIKOLCFE, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6938E90", Offset = "0x6937E90", VA = "0x186938E90")]
	public BMNPCAMLNFA(BMNPCAMLNFA FHNKDHIILBL, Allocator IDMGOAKOEDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6937D30", Offset = "0x6936D30", VA = "0x186937D30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6938640", Offset = "0x6937640", VA = "0x186938640")]
	public void MJFEDCBJOBF([In] BMNPCAMLNFA CHNGFEKJHON, float4x4 NBMFEBPFDJH, Transform DAOJLEMLDIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6937F80", Offset = "0x6936F80", VA = "0x186937F80")]
	public void ILPFKEENPJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6938110", Offset = "0x6937110", VA = "0x186938110")]
	public void KOMIOIDAHEJ(float PNEKGHHAGPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6938A30", Offset = "0x6937A30", VA = "0x186938A30")]
	public BMNPCAMLNFA NGOCGJIMHFA(Allocator IDMGOAKOEDG, CancellationToken DADBOHKBJNO)
	{
		return default(BMNPCAMLNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6937E60", Offset = "0x6936E60", VA = "0x186937E60")]
	public Mesh FLDAOIJMJNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6937E10", Offset = "0x6936E10", VA = "0x186937E10")]
	private unsafe static float3* EAHEPEOEMOH(NativeArray<float3> GGEMIJICFPG)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6937DC0", Offset = "0x6936DC0", VA = "0x186937DC0")]
	private unsafe static int* EAHEPEOEMOH(NativeArray<int> GGEMIJICFPG)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6938A00", Offset = "0x6937A00", VA = "0x186938A00")]
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
		[Cpp2IlInjected.Address(RVA = "0x6939200", Offset = "0x6938200", VA = "0x186939200")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1EBBD20", Offset = "0x1EBAD20", VA = "0x181EBBD20")]
	public static CIFJNAKOGFP DABBFBOOFEB(CIFJNAKOGFP FAGKOOGCGBH, CIFJNAKOGFP HEOHCJKCOLM)
	{
		return default(CIFJNAKOGFP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x69392B0", Offset = "0x69382B0", VA = "0x1869392B0")]
	public static CIFJNAKOGFP OLANHAAJLGG(CIFJNAKOGFP IJGMIMHJGIO, int HPNFCDLKBEK)
	{
		return default(CIFJNAKOGFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6939210", Offset = "0x6938210", VA = "0x186939210", Slot = "0")]
	public override bool Equals(object CNLIJOOKGOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6939260", Offset = "0x6938260", VA = "0x186939260", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x69392D0", Offset = "0x69382D0", VA = "0x1869392D0", Slot = "3")]
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
