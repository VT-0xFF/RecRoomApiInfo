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
		[Cpp2IlInjected.Address(RVA = "0x6C1A7C0", Offset = "0x6C191C0", VA = "0x186C1A7C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x141BD30", Offset = "0x141A730", VA = "0x18141BD30")]
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
	[Cpp2IlInjected.Address(RVA = "0x6C1C590", Offset = "0x6C1AF90", VA = "0x186C1C590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E500", Offset = "0x6C1CF00", VA = "0x186C1E500")]
	public bool LEBEKIJPPNE([In] NativeArray<float3> IHLFELKGCHB, NativeList<float3> DJGDLHMNPBH, NativeList<int> HCMMOHLNFNH, Allocator NPNPKHEIOHB, CancellationToken IONNNJNKLMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C240", Offset = "0x6C1AC40", VA = "0x186C1C240")]
	private void AIFHKOLJDOL([In] NativeArray<float3> IHLFELKGCHB, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C1D180", Offset = "0x6C1BB80", VA = "0x186C1D180")]
	private void KMNEDOKOHLG([In] NativeArray<float3> IHLFELKGCHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BD80", Offset = "0x6C1A780", VA = "0x186C1BD80")]
	private void AHHFGPNKLNG([In] NativeArray<float3> IHLFELKGCHB, [Out] int DNACHCPEEIA, [Out] int MCNLHMPHPGA, [Out] int AIMBGKHPAHC, [Out] int IAABONOIDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CF80", Offset = "0x6C1B980", VA = "0x186C1CF80")]
	private void JACEAOHMIGB([In] NativeArray<float3> IHLFELKGCHB, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C1EDD0", Offset = "0x6C1D7D0", VA = "0x186C1EDD0")]
	private void PNBCNGOGJHA([In] NativeArray<float3> IHLFELKGCHB, float3 IFDMLAIJAHF, int GOKBCLBIPOG, BPFGBLDOFDJ HJBOOCNHEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C6D0", Offset = "0x6C1B0D0", VA = "0x186C1C6D0")]
	private void GCKDFINFLBC([In] NativeArray<float3> IHLFELKGCHB, float3 IFDMLAIJAHF, int LKBIKDNJHFE, int AGDOCEMMJDD, BPFGBLDOFDJ HJBOOCNHEDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E770", Offset = "0x6C1D170", VA = "0x186C1E770")]
	private void OINHOLPBMDJ([In] NativeArray<float3> IHLFELKGCHB, int FJPLBNAKKBN, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E190", Offset = "0x6C1CB90", VA = "0x186C1E190")]
	private void LBIMPMILANP([In] NativeArray<float3> IHLFELKGCHB, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1CAA0", Offset = "0x6C1B4A0", VA = "0x186C1CAA0")]
	private void IJGGLBLHKIC([In] NativeArray<float3> IHLFELKGCHB, NativeList<float3> DJGDLHMNPBH, NativeList<int> HCMMOHLNFNH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C420", Offset = "0x6C1AE20", VA = "0x186C1C420")]
	private float CCBHELIKMDI(float3 IFDMLAIJAHF, float3 HLNLMLCBHFL, BPFGBLDOFDJ HJBOOCNHEDL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1C480", Offset = "0x6C1AE80", VA = "0x186C1C480")]
	private float3 CNEDOCPBIID(float3 KJDKNBIDOFP, float3 DPFCBDOOEDH, float3 DIGKPNKCJLP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BD50", Offset = "0x6C1A750", VA = "0x186C1BD50")]
	private static float ABBOKONIKLO(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1ED70", Offset = "0x6C1D770", VA = "0x186C1ED70")]
	private static float3 PBLDNGPMEPF(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E640", Offset = "0x6C1D040", VA = "0x186C1E640")]
	private bool LGKCMHNLJKL(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6C1E6A0", Offset = "0x6C1D0A0", VA = "0x186C1E6A0")]
	private bool NBPDEGIIMDL(float3 MOKDKAEJAPP, float3 MKGNFMMEFHC, float3 DMIBFACOBBP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6C1F230", Offset = "0x6C1DC30", VA = "0x186C1F230")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C1B410", Offset = "0x6C19E10", VA = "0x186C1B410")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int IFODHMFDNEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B6D0", Offset = "0x6C1A0D0", VA = "0x186C1B6D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool OADKJCMIIMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B740", Offset = "0x6C1A140", VA = "0x186C1B740")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public ABKFKKIGGEM FDCNKADBBCN
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6C1B450", Offset = "0x6C19E50", VA = "0x186C1B450")]
		get
		{
			return default(ABKFKKIGGEM);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BB20", Offset = "0x6C1A520", VA = "0x186C1BB20")]
	public GJABIMDECDD(int KNHJBDAHGAE, int EHANMNGLAMC, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BAF0", Offset = "0x6C1A4F0", VA = "0x186C1BAF0")]
	public GJABIMDECDD(ABKFKKIGGEM GCOBBKJLDDH, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1BBE0", Offset = "0x6C1A5E0", VA = "0x186C1BBE0")]
	public GJABIMDECDD(Mesh CBNKKMIFMKD, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B780", Offset = "0x6C1A180", VA = "0x186C1B780")]
	public GJABIMDECDD(GJABIMDECDD JGCMECODHDI, Allocator NPNPKHEIOHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AEE0", Offset = "0x6C198E0", VA = "0x186C1AEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B090", Offset = "0x6C19A90", VA = "0x186C1B090")]
	public void FABNFHGMHGJ([In] GJABIMDECDD MKLJJBDOOGE, float4x4 GBJHAIHLBJE, Transform FBHNHMNFBHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6C1ACF0", Offset = "0x6C196F0", VA = "0x186C1ACF0")]
	public void BAGKAJFMDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A800", Offset = "0x6C19200", VA = "0x186C1A800")]
	public void AIDHGLPGPPB(float KEEIEBHGPIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B4D0", Offset = "0x6C19ED0", VA = "0x186C1B4D0")]
	public GJABIMDECDD KDJBCDMJGEO(Allocator NPNPKHEIOHB, CancellationToken IONNNJNKLMJ)
	{
		return default(GJABIMDECDD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AF70", Offset = "0x6C19970", VA = "0x186C1AF70")]
	public Mesh EIMJPKFOAMG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AE40", Offset = "0x6C19840", VA = "0x186C1AE40")]
	private unsafe static float3* CIKHJJMFCLH(NativeArray<float3> DKEEEGEFALD)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6C1AE90", Offset = "0x6C19890", VA = "0x186C1AE90")]
	private unsafe static int* CIKHJJMFCLH(NativeArray<int> DKEEEGEFALD)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6C1B710", Offset = "0x6C1A110", VA = "0x186C1B710")]
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
		[Cpp2IlInjected.Address(RVA = "0x6C1A710", Offset = "0x6C19110", VA = "0x186C1A710")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x204EFD0", Offset = "0x204D9D0", VA = "0x18204EFD0")]
	public static ABKFKKIGGEM PAFCMDDLEJB(ABKFKKIGGEM MOKDKAEJAPP, ABKFKKIGGEM MKGNFMMEFHC)
	{
		return default(ABKFKKIGGEM);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A650", Offset = "0x6C19050", VA = "0x186C1A650")]
	public static ABKFKKIGGEM DBFLBJOGOLJ(ABKFKKIGGEM OJJKGCDDONI, int ODPGHJEEHCK)
	{
		return default(ABKFKKIGGEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A670", Offset = "0x6C19070", VA = "0x186C1A670", Slot = "0")]
	public override bool Equals(object FCBEMCFODFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A6C0", Offset = "0x6C190C0", VA = "0x186C1A6C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6C1A720", Offset = "0x6C19120", VA = "0x186C1A720", Slot = "3")]
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
