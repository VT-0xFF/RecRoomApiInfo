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
public struct MBLKFDLLDOP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct GCFPOAFJBOD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int HMBIACECINJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int NBGMCDLODMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int LHOLCOEEIJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int COIBACPGAMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int KMJPJOJHGAI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int INCLNNGFNDG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 DPCBAHGNEDF;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6CE0", Offset = "0x5DD60E0", VA = "0x185DD6CE0")]
		public GCFPOAFJBOD(int HPJEIKHOELI, int NBLDHKIPOGL, int CKJGCAIDIBP, int IJEHDOGHLPB, int NDBACNCAMLK, int EOPHFGLHLPG, float3 CEGMEAOIEDE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct CCIJBOBAKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int KALNPAJKIMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JFFFADANMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float FNDMCPIJLIK;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xF3D890", Offset = "0xF3CC90", VA = "0x180F3D890")]
		public CCIJBOBAKHJ(int ENFHPFLKGCP, int FJJLEFEGIGL, float IIPNDJEHBDD)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct ODMCLBIBAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JFFFADANMIG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int FJENNGILEGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int INOMMJBCBLJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, GCFPOAFJBOD> FLADAKJLMAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<CCIJBOBAKHJ> LEMMDKCLEFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> ACMOJEJDBIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<ODMCLBIBAIM> MIEICDAKHED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> AMCCIHPCLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int GHDECCNFKLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int AICMGKDFPBB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA330", Offset = "0x5DD9730", VA = "0x185DDA330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAC00", Offset = "0x5DDA000", VA = "0x185DDAC00")]
	public bool HANNMMBLJKJ([In] NativeArray<float3> IJNMLMKCEJD, NativeList<float3> DFAJGHGKMPB, NativeList<int> HEOECKOHDPD, Allocator LJHPECEMAME, CancellationToken EANFAKGANNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAA20", Offset = "0x5DD9E20", VA = "0x185DDAA20")]
	private void GJHPIDDJMKM([In] NativeArray<float3> IJNMLMKCEJD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DD83D0", Offset = "0x5DD77D0", VA = "0x185DD83D0")]
	private void CFGMBICCDFC([In] NativeArray<float3> IJNMLMKCEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAE10", Offset = "0x5DDA210", VA = "0x185DDAE10")]
	private void LJCFGFGCOJE([In] NativeArray<float3> IJNMLMKCEJD, [Out] int KNAEHNGHNDK, [Out] int PFKJENHJMHD, [Out] int LGNFDPFANNE, [Out] int PEHBIEMOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA820", Offset = "0x5DD9C20", VA = "0x185DDA820")]
	private void GIIFCOKJCGJ([In] NativeArray<float3> IJNMLMKCEJD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB730", Offset = "0x5DDAB30", VA = "0x185DDB730")]
	private void PLCEPCOLCEJ([In] NativeArray<float3> IJNMLMKCEJD, float3 GGCAPAPOAOA, int PIAPFLDELHN, GCFPOAFJBOD BLHCCKMPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB2D0", Offset = "0x5DDA6D0", VA = "0x185DDB2D0")]
	private void NCHKFCJOEJD([In] NativeArray<float3> IJNMLMKCEJD, float3 GGCAPAPOAOA, int NNBODGJJOBO, int AICMGKDFPBB, GCFPOAFJBOD BLHCCKMPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9C20", Offset = "0x5DD9020", VA = "0x185DD9C20")]
	private void DMFGKOJDGEB([In] NativeArray<float3> IJNMLMKCEJD, int DPLNFDGFFLO, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD93E0", Offset = "0x5DD87E0", VA = "0x185DD93E0")]
	private void DBCGJEMKJBF([In] NativeArray<float3> IJNMLMKCEJD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9750", Offset = "0x5DD8B50", VA = "0x185DD9750")]
	private void DCFIIFAKMPD([In] NativeArray<float3> IJNMLMKCEJD, NativeList<float3> DFAJGHGKMPB, NativeList<int> HEOECKOHDPD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA7C0", Offset = "0x5DD9BC0", VA = "0x185DDA7C0")]
	private float GHDGJIJCBGN(float3 GGCAPAPOAOA, float3 KBFJDNLNNLH, GCFPOAFJBOD BLHCCKMPBJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA220", Offset = "0x5DD9620", VA = "0x185DDA220")]
	private float3 DPCBAHGNEDF(float3 HPJEIKHOELI, float3 NBLDHKIPOGL, float3 CKJGCAIDIBP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB700", Offset = "0x5DDAB00", VA = "0x185DDB700")]
	private static float OIJKMPPCBOJ(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB6A0", Offset = "0x5DDAAA0", VA = "0x185DDB6A0")]
	private static float3 NJHLPGAENJG(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA760", Offset = "0x5DD9B60", VA = "0x185DDA760")]
	private bool FAJGCMFHEBL(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAD40", Offset = "0x5DDA140", VA = "0x185DDAD40")]
	private bool HJPFEKEEEOA(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI, float3 CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA470", Offset = "0x5DD9870", VA = "0x185DDA470")]
	private bool ECAODJPPNDC(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI, float3 CPHKPECCMOM, float3 IIPNDJEHBDD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct KBHOAEHPOFH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DKJLBDNFODH
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
	private NativeList<float3> PGFPNAHJDJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> MIEGOKHBMOO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GNOHGDFLCIA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7840", Offset = "0x5DD6C40", VA = "0x185DD7840")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7250", Offset = "0x5DD6650", VA = "0x185DD7250")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HNAOJEOBKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6E90", Offset = "0x5DD6290", VA = "0x185DD6E90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HDEMIHJNAOG CGMNIKAABBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7670", Offset = "0x5DD6A70", VA = "0x185DD7670")]
		get
		{
			return default(HDEMIHJNAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8310", Offset = "0x5DD7710", VA = "0x185DD8310")]
	public KBHOAEHPOFH(int OHMLLCELOAI, int MPIKDMCFKKF, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD82E0", Offset = "0x5DD76E0", VA = "0x185DD82E0")]
	public KBHOAEHPOFH(HDEMIHJNAOG KNFBGFBLKAK, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7E10", Offset = "0x5DD7210", VA = "0x185DD7E10")]
	public KBHOAEHPOFH(Mesh OFPOBDLGBHI, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7F80", Offset = "0x5DD7380", VA = "0x185DD7F80")]
	public KBHOAEHPOFH(KBHOAEHPOFH KKOACPFFAML, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7290", Offset = "0x5DD6690", VA = "0x185DD7290", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6ED0", Offset = "0x5DD62D0", VA = "0x185DD6ED0")]
	public void BKKEPFPDOJH([In] KBHOAEHPOFH HFLNDIDMJFD, float4x4 KIKGIFIBGIN, Transform EPGHFEOAKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7320", Offset = "0x5DD6720", VA = "0x185DD7320")]
	public void FPPIKLCOECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7880", Offset = "0x5DD6C80", VA = "0x185DD7880")]
	public void OBAEPFHNLKL(float MEOGMCFNILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7470", Offset = "0x5DD6870", VA = "0x185DD7470")]
	public KBHOAEHPOFH HEDOAOLCCPP(Allocator LJHPECEMAME, CancellationToken EANFAKGANNH)
	{
		return default(KBHOAEHPOFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DD76F0", Offset = "0x5DD6AF0", VA = "0x185DD76F0")]
	public Mesh JDHMNDMOHMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7DC0", Offset = "0x5DD71C0", VA = "0x185DD7DC0")]
	private unsafe static float3* OFDOKHNKKFP(NativeArray<float3> NCABOBFFNFK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7D70", Offset = "0x5DD7170", VA = "0x185DD7D70")]
	private unsafe static int* OFDOKHNKKFP(NativeArray<int> NCABOBFFNFK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7810", Offset = "0x5DD6C10", VA = "0x185DD7810")]
	[CompilerGenerated]
	internal static void JGJCPCKJPAK(int KONMHAPMBJO, int HFKOPDAKCKF, DKJLBDNFODH P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HDEMIHJNAOG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int GNOHGDFLCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int DALMIIANPBP;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MIMFLMAEPOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6DE0", Offset = "0x5DD61E0", VA = "0x185DD6DE0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1BEE510", Offset = "0x1BED910", VA = "0x181BEE510")]
	public static HDEMIHJNAOG EHMNDHCEEPM(HDEMIHJNAOG JMHOJIPAIMC, HDEMIHJNAOG MLKGDIFPGGI)
	{
		return default(HDEMIHJNAOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6D70", Offset = "0x5DD6170", VA = "0x185DD6D70")]
	public static HDEMIHJNAOG GOHIFGEDMEN(HDEMIHJNAOG CCIJIHALHGA, int JPEBMNHCEFF)
	{
		return default(HDEMIHJNAOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6D20", Offset = "0x5DD6120", VA = "0x185DD6D20", Slot = "0")]
	public override bool Equals(object PPCIJNHPNML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6D90", Offset = "0x5DD6190", VA = "0x185DD6D90", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6DF0", Offset = "0x5DD61F0", VA = "0x185DD6DF0", Slot = "3")]
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
