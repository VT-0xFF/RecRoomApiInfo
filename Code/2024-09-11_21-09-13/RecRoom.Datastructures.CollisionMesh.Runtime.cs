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
public struct PDGLJFDDMMP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct BPFGBLDOFDJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int HFEDAOBIMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int PABENKHKODH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int CIIOAGFMOBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int HIOEDBIDDKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int GHIFBIDNCFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int AGDCDPDAIJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 CNEDOCPBIID;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B335D0", Offset = "0x6B31BD0", VA = "0x186B335D0")]
		public BPFGBLDOFDJ(int KJDKNBIDOFP, int DPFCBDOOEDH, int DIGKPNKCJLP, int NLMDIPALBND, int IOECFHJJJGA, int CJPCCANEHND, float3 DBBPPLLNKOD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HIFMPKPJIII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int GLEHEIPFKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int OEDPIAPBGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float NHPMBDBEGJI;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x13706C0", Offset = "0x136ECC0", VA = "0x1813706C0")]
		public HIFMPKPJIII(int FDIIPKGGJGJ, int MAGDOPDGOBL, float MIBANGGGBCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct OFCNCBEIHDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int OEDPIAPBGKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int NAEIFGLMMJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int KCFLOEIOALP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, BPFGBLDOFDJ> PLLKCINLGIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HIFMPKPJIII> AOMDBOCKEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> MOKJOHKDECO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<OFCNCBEIHDC> DPECFPEMCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> PIEIOHMDELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int GGIDGECJFOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int AGDOCEMMJDD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B353A0", Offset = "0x6B339A0", VA = "0x186B353A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B37310", Offset = "0x6B35910", VA = "0x186B37310")]
	public bool LEBEKIJPPNE([In] NativeArray<float3> IHLFELKGCHB, NativeList<float3> DJGDLHMNPBH, NativeList<int> HCMMOHLNFNH, Allocator NPNPKHEIOHB, CancellationToken IONNNJNKLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B35050", Offset = "0x6B33650", VA = "0x186B35050")]
	private void AIFHKOLJDOL([In] NativeArray<float3> IHLFELKGCHB, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B35F90", Offset = "0x6B34590", VA = "0x186B35F90")]
	private void KMNEDOKOHLG([In] NativeArray<float3> IHLFELKGCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B34B90", Offset = "0x6B33190", VA = "0x186B34B90")]
	private void AHHFGPNKLNG([In] NativeArray<float3> IHLFELKGCHB, [Out] int DNACHCPEEIA, [Out] int MCNLHMPHPGA, [Out] int AIMBGKHPAHC, [Out] int IAABONOIDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B35D90", Offset = "0x6B34390", VA = "0x186B35D90")]
	private void JACEAOHMIGB([In] NativeArray<float3> IHLFELKGCHB, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B37BE0", Offset = "0x6B361E0", VA = "0x186B37BE0")]
	private void PNBCNGOGJHA([In] NativeArray<float3> IHLFELKGCHB, float3 IFDMLAIJAHF, int GOKBCLBIPOG, BPFGBLDOFDJ HJBOOCNHEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B354E0", Offset = "0x6B33AE0", VA = "0x186B354E0")]
	private void GCKDFINFLBC([In] NativeArray<float3> IHLFELKGCHB, float3 IFDMLAIJAHF, int LKBIKDNJHFE, int AGDOCEMMJDD, BPFGBLDOFDJ HJBOOCNHEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B37580", Offset = "0x6B35B80", VA = "0x186B37580")]
	private void OINHOLPBMDJ([In] NativeArray<float3> IHLFELKGCHB, int FJPLBNAKKBN, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B36FA0", Offset = "0x6B355A0", VA = "0x186B36FA0")]
	private void LBIMPMILANP([In] NativeArray<float3> IHLFELKGCHB, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B358B0", Offset = "0x6B33EB0", VA = "0x186B358B0")]
	private void IJGGLBLHKIC([In] NativeArray<float3> IHLFELKGCHB, NativeList<float3> DJGDLHMNPBH, NativeList<int> HCMMOHLNFNH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6B35230", Offset = "0x6B33830", VA = "0x186B35230")]
	private float CCBHELIKMDI(float3 IFDMLAIJAHF, float3 HLNLMLCBHFL, BPFGBLDOFDJ HJBOOCNHEDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B35290", Offset = "0x6B33890", VA = "0x186B35290")]
	private float3 CNEDOCPBIID(float3 KJDKNBIDOFP, float3 DPFCBDOOEDH, float3 DIGKPNKCJLP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6B34B60", Offset = "0x6B33160", VA = "0x186B34B60")]
	private static float ABBOKONIKLO(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B37B80", Offset = "0x6B36180", VA = "0x186B37B80")]
	private static float3 PBLDNGPMEPF(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6B37450", Offset = "0x6B35A50", VA = "0x186B37450")]
	private bool LGKCMHNLJKL(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6B374B0", Offset = "0x6B35AB0", VA = "0x186B374B0")]
	private bool NBPDEGIIMDL(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC, float3 DMIBFACOBBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6B38040", Offset = "0x6B36640", VA = "0x186B38040")]
	private bool PNEPHPBKHDI(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC, float3 DMIBFACOBBP, float3 MIBANGGGBCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GJABIMDECDD : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct OLHFFAKMJCB
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
	private NativeList<float3> KCJPKGCFHDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> KOJFAOFOLCN;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NODGOOMLBAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6B34220", Offset = "0x6B32820", VA = "0x186B34220")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B344E0", Offset = "0x6B32AE0", VA = "0x186B344E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B34550", Offset = "0x6B32B50", VA = "0x186B34550")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ABKFKKIGGEM FDCNKADBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6B34260", Offset = "0x6B32860", VA = "0x186B34260")]
		get
		{
			return default(ABKFKKIGGEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B34930", Offset = "0x6B32F30", VA = "0x186B34930")]
	public GJABIMDECDD(int KNHJBDAHGAE, int EHANMNGLAMC, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6B34900", Offset = "0x6B32F00", VA = "0x186B34900")]
	public GJABIMDECDD(ABKFKKIGGEM GCOBBKJLDDH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B349F0", Offset = "0x6B32FF0", VA = "0x186B349F0")]
	public GJABIMDECDD(Mesh CBNKKMIFMKD, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B34590", Offset = "0x6B32B90", VA = "0x186B34590")]
	public GJABIMDECDD(GJABIMDECDD JGCMECODHDI, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B33CF0", Offset = "0x6B322F0", VA = "0x186B33CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B33EA0", Offset = "0x6B324A0", VA = "0x186B33EA0")]
	public void FABNFHGMHGJ([In] GJABIMDECDD MKLJJBDOOGE, float4x4 GBJHAIHLBJE, Transform FBHNHMNFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B33B00", Offset = "0x6B32100", VA = "0x186B33B00")]
	public void BAGKAJFMDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B33610", Offset = "0x6B31C10", VA = "0x186B33610")]
	public void AIDHGLPGPPB(float KEEIEBHGPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6B342E0", Offset = "0x6B328E0", VA = "0x186B342E0")]
	public GJABIMDECDD KDJBCDMJGEO(Allocator NPNPKHEIOHB, CancellationToken IONNNJNKLMJ)
	{
		return default(GJABIMDECDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6B33D80", Offset = "0x6B32380", VA = "0x186B33D80")]
	public Mesh EIMJPKFOAMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6B33C50", Offset = "0x6B32250", VA = "0x186B33C50")]
	private unsafe static float3* CIKHJJMFCLH(NativeArray<float3> DKEEEGEFALD)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6B33CA0", Offset = "0x6B322A0", VA = "0x186B33CA0")]
	private unsafe static int* CIKHJJMFCLH(NativeArray<int> DKEEEGEFALD)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6B34520", Offset = "0x6B32B20", VA = "0x186B34520")]
	[CompilerGenerated]
	internal static void MFHCJPAJDFF(int LNHHDDBOIPO, int FOLCOMIEJOA, OLHFFAKMJCB P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct ABKFKKIGGEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int NODGOOMLBAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int IFODHMFDNEL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ELIJNMLLLMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6B33520", Offset = "0x6B31B20", VA = "0x186B33520")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1FAE100", Offset = "0x1FAC700", VA = "0x181FAE100")]
	public static ABKFKKIGGEM PAFCMDDLEJB(ABKFKKIGGEM MOKDKAEJAPP, ABKFKKIGGEM MKGNFMMEFHC)
	{
		return default(ABKFKKIGGEM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6B33460", Offset = "0x6B31A60", VA = "0x186B33460")]
	public static ABKFKKIGGEM DBFLBJOGOLJ(ABKFKKIGGEM OJJKGCDDONI, int ODPGHJEEHCK)
	{
		return default(ABKFKKIGGEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6B33480", Offset = "0x6B31A80", VA = "0x186B33480", Slot = "0")]
	public override bool Equals(object FCBEMCFODFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6B334D0", Offset = "0x6B31AD0", VA = "0x186B334D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6B33530", Offset = "0x6B31B30", VA = "0x186B33530", Slot = "3")]
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
