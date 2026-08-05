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
public struct CJFCBBLPKGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct AJKNEADELBD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int IBLJOFJAEMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int IDFPBGJDJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int GFCAFMJGEJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int POEENPFCKBB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LBKDJOFPIOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int EBJDDABOIHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 IMBNMNHLHBC;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1B5A0A0", Offset = "0x1B588A0", VA = "0x181B5A0A0")]
		public AJKNEADELBD(int PGLMGNILPBP, int MOEMBMJIDMD, int CDBIMIAHMNA, int IBDHJIECJLP, int OKKGCCLAENF, int GGNMBOLJNBD, float3 PFPCKLEHGAC)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OIJHGNCDHBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int JGBLCLIAMOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int ICJFHCENHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float OJMDPLNENCF;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1B5EDB0", Offset = "0x1B5D5B0", VA = "0x181B5EDB0")]
		public OIJHGNCDHBH(int LLGHPHNDCPD, int CIDKNOKLNON, float DPBGGLEPNBP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct NIIIADMGGNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int ICJFHCENHPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int KKOEBCKIPII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int AKJIPAECEHI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, AJKNEADELBD> FJHAJALDJEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OIJHGNCDHBH> GOFLHNAKBNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> DODBILCLOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<NIIIADMGGNL> LBHBCMLEFOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> LFPCCPLDBIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int FFHBLKCMGMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int IKMAGJCEPPM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1B5A880", Offset = "0x1B59080", VA = "0x181B5A880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1B5B170", Offset = "0x1B59970", VA = "0x181B5B170")]
	public bool GCLLLDNLBNC(in NativeArray<float3> GAKGEGGOCGA, ref NativeList<float3> LIGIBJHFNEA, ref NativeList<int> IPBBAGNEJHK, Allocator MOKKEDCFMAC, CancellationToken PJGLOOAEHEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D5D0", Offset = "0x1B5BDD0", VA = "0x181B5D5D0")]
	private void PJKFEDAIHFG(in NativeArray<float3> GAKGEGGOCGA, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1B5B250", Offset = "0x1B59A50", VA = "0x181B5B250")]
	private void HAIBDPAIOMB(in NativeArray<float3> GAKGEGGOCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1B5A9F0", Offset = "0x1B591F0", VA = "0x181B5A9F0")]
	private void FAFKIJPPCKI(in NativeArray<float3> GAKGEGGOCGA, out int FCLMFGHMDDL, out int JACBIEPHHGJ, out int LNKGNLFFCEK, out int NKOGGFOKJJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C880", Offset = "0x1B5B080", VA = "0x181B5C880")]
	private void LLHPCJIHNEO(in NativeArray<float3> GAKGEGGOCGA, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1B5CC60", Offset = "0x1B5B460", VA = "0x181B5CC60")]
	private void OCLBBLFPHDN(in NativeArray<float3> GAKGEGGOCGA, float3 JMBNGJDJLPO, int AFKBCBNMMKG, AJKNEADELBD LKKOOJDNIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D1A0", Offset = "0x1B5B9A0", VA = "0x181B5D1A0")]
	private void OMONBBMFCNB(in NativeArray<float3> GAKGEGGOCGA, float3 JMBNGJDJLPO, int ELLGLBBBCHD, int IKMAGJCEPPM, AJKNEADELBD LKKOOJDNIHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1B5BDF0", Offset = "0x1B5A5F0", VA = "0x181B5BDF0")]
	private void HHPLFNINFHH(in NativeArray<float3> GAKGEGGOCGA, int MFHKINPEJMG, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1B5AE30", Offset = "0x1B59630", VA = "0x181B5AE30")]
	private void FOHALFALCLG(in NativeArray<float3> GAKGEGGOCGA, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C2C0", Offset = "0x1B5AAC0", VA = "0x181B5C2C0")]
	private void HNBJIHPOCNI(in NativeArray<float3> GAKGEGGOCGA, ref NativeList<float3> LIGIBJHFNEA, ref NativeList<int> IPBBAGNEJHK, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1B5A970", Offset = "0x1B59170", VA = "0x181B5A970")]
	private float EHKPCEHCFDM(float3 JMBNGJDJLPO, float3 IPPDPNGJGLA, AJKNEADELBD LKKOOJDNIHJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C6F0", Offset = "0x1B5AEF0", VA = "0x181B5C6F0")]
	private float3 IMBNMNHLHBC(float3 PGLMGNILPBP, float3 MOEMBMJIDMD, float3 CDBIMIAHMNA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1B5CAD0", Offset = "0x1B5B2D0", VA = "0x181B5CAD0")]
	private static float LNMJDBKEJGP(float3 LNIJHEMDGEF, float3 LANKPNEAHJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1B5C620", Offset = "0x1B5AE20", VA = "0x181B5C620")]
	private static float3 IAOKLDILFPJ(float3 LNIJHEMDGEF, float3 LANKPNEAHJA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D730", Offset = "0x1B5BF30", VA = "0x181B5D730")]
	private bool PPJMMGKGFGB(float3 LNIJHEMDGEF, float3 LANKPNEAHJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1B5CB20", Offset = "0x1B5B320", VA = "0x181B5CB20")]
	private bool MKAPJCDBGIP(float3 LNIJHEMDGEF, float3 LANKPNEAHJA, float3 DGNGOIEGJNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1B5A0E0", Offset = "0x1B588E0", VA = "0x181B5A0E0")]
	private bool BKFHLHPPMIH(float3 LNIJHEMDGEF, float3 LANKPNEAHJA, float3 DGNGOIEGJNG, float3 DPBGGLEPNBP)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct MKMJHPEKGFG : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NCIOHINPPDI
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
	private NativeList<float3> KAGJBPCBKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> CMEBJKEKFBK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OFBGIIBCJNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1B5E8E0", Offset = "0x1B5D0E0", VA = "0x181B5E8E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int COBEGFPHAIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1B5DCE0", Offset = "0x1B5C4E0", VA = "0x181B5DCE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool GLDPFKBJLPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1B5DC20", Offset = "0x1B5C420", VA = "0x181B5DC20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public OLLNIFIKDFD IIEBHLHBDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1B5DBA0", Offset = "0x1B5C3A0", VA = "0x181B5DBA0")]
		get
		{
			return default(OLLNIFIKDFD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E950", Offset = "0x1B5D150", VA = "0x181B5E950")]
	public MKMJHPEKGFG(int DGHLPJOODLF, int GEKOJFOGBEC, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E920", Offset = "0x1B5D120", VA = "0x181B5E920")]
	public MKMJHPEKGFG(OLLNIFIKDFD EJBDJIOIPCO, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EA00", Offset = "0x1B5D200", VA = "0x181B5EA00")]
	public MKMJHPEKGFG(Mesh NMCFIAPNHNL, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EB80", Offset = "0x1B5D380", VA = "0x181B5EB80")]
	public MKMJHPEKGFG(MKMJHPEKGFG IACPDDKLBCL, Allocator MOKKEDCFMAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1B5DC60", Offset = "0x1B5C460", VA = "0x181B5DC60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E1F0", Offset = "0x1B5C9F0", VA = "0x181B5E1F0")]
	public void MFDJFDLHFHG(in MKMJHPEKGFG KAEJCIIKOCK, float4x4 DCDMCGKLFGB, Transform OAHELJOADID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E720", Offset = "0x1B5CF20", VA = "0x181B5E720")]
	public void OACMFJNBFMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1B5DD20", Offset = "0x1B5C520", VA = "0x181B5DD20")]
	public void IECCIOLOOOH(float AOIKGELEGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1B5D7F0", Offset = "0x1B5BFF0", VA = "0x181B5D7F0")]
	public MKMJHPEKGFG ADANGGNNBNN(Allocator MOKKEDCFMAC, CancellationToken PJGLOOAEHEA)
	{
		return default(MKMJHPEKGFG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E5F0", Offset = "0x1B5CDF0", VA = "0x181B5E5F0")]
	public Mesh MOMNALONKDL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1B5DB50", Offset = "0x1B5C350", VA = "0x181B5DB50")]
	private unsafe static float3* AMCBCNKCJEI(NativeArray<float3> IKFPKGEHMKB)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1B5DB00", Offset = "0x1B5C300", VA = "0x181B5DB00")]
	private unsafe static int* AMCBCNKCJEI(NativeArray<int> IKFPKGEHMKB)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1B5E6F0", Offset = "0x1B5CEF0", VA = "0x181B5E6F0")]
	[CompilerGenerated]
	internal static void NMECGAMCNKB(int NNEDLEPGJFK, int LCDOJJGMLPI, ref NCIOHINPPDI P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OLLNIFIKDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int OFBGIIBCJNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int COBEGFPHAIL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CIGPGFNKADD
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1B5EE10", Offset = "0x1B5D610", VA = "0x181B5EE10")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1869410", Offset = "0x1867C10", VA = "0x181869410")]
	public static OLLNIFIKDFD AAELLMJBLNM(OLLNIFIKDFD LNIJHEMDGEF, OLLNIFIKDFD LANKPNEAHJA)
	{
		return default(OLLNIFIKDFD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EE70", Offset = "0x1B5D670", VA = "0x181B5EE70")]
	public static OLLNIFIKDFD HPKHMCKFGCP(OLLNIFIKDFD PIDAGAEKOCF, int CJEGHGAJKIK)
	{
		return default(OLLNIFIKDFD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EDC0", Offset = "0x1B5D5C0", VA = "0x181B5EDC0", Slot = "0")]
	public override bool Equals(object GHJJPGNNPNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EE20", Offset = "0x1B5D620", VA = "0x181B5EE20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1B5EE90", Offset = "0x1B5D690", VA = "0x181B5EE90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface CKHKEPOCDPI
{
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
