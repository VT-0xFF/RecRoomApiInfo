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
		[Cpp2IlInjected.Address(RVA = "0x5DD6C00", Offset = "0x5DD6000", VA = "0x185DD6C00")]
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
		[Cpp2IlInjected.Address(RVA = "0xF3D940", Offset = "0xF3CD40", VA = "0x180F3D940")]
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
	[Cpp2IlInjected.Address(RVA = "0x5DDA250", Offset = "0x5DD9650", VA = "0x185DDA250", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAB20", Offset = "0x5DD9F20", VA = "0x185DDAB20")]
	public bool HANNMMBLJKJ([In] NativeArray<float3> IJNMLMKCEJD, NativeList<float3> DFAJGHGKMPB, NativeList<int> HEOECKOHDPD, Allocator LJHPECEMAME, CancellationToken EANFAKGANNH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA940", Offset = "0x5DD9D40", VA = "0x185DDA940")]
	private void GJHPIDDJMKM([In] NativeArray<float3> IJNMLMKCEJD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5DD82F0", Offset = "0x5DD76F0", VA = "0x185DD82F0")]
	private void CFGMBICCDFC([In] NativeArray<float3> IJNMLMKCEJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAD30", Offset = "0x5DDA130", VA = "0x185DDAD30")]
	private void LJCFGFGCOJE([In] NativeArray<float3> IJNMLMKCEJD, [Out] int KNAEHNGHNDK, [Out] int PFKJENHJMHD, [Out] int LGNFDPFANNE, [Out] int PEHBIEMOHMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA740", Offset = "0x5DD9B40", VA = "0x185DDA740")]
	private void GIIFCOKJCGJ([In] NativeArray<float3> IJNMLMKCEJD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB650", Offset = "0x5DDAA50", VA = "0x185DDB650")]
	private void PLCEPCOLCEJ([In] NativeArray<float3> IJNMLMKCEJD, float3 GGCAPAPOAOA, int PIAPFLDELHN, GCFPOAFJBOD BLHCCKMPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB1F0", Offset = "0x5DDA5F0", VA = "0x185DDB1F0")]
	private void NCHKFCJOEJD([In] NativeArray<float3> IJNMLMKCEJD, float3 GGCAPAPOAOA, int NNBODGJJOBO, int AICMGKDFPBB, GCFPOAFJBOD BLHCCKMPBJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9B40", Offset = "0x5DD8F40", VA = "0x185DD9B40")]
	private void DMFGKOJDGEB([In] NativeArray<float3> IJNMLMKCEJD, int DPLNFDGFFLO, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9300", Offset = "0x5DD8700", VA = "0x185DD9300")]
	private void DBCGJEMKJBF([In] NativeArray<float3> IJNMLMKCEJD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD9670", Offset = "0x5DD8A70", VA = "0x185DD9670")]
	private void DCFIIFAKMPD([In] NativeArray<float3> IJNMLMKCEJD, NativeList<float3> DFAJGHGKMPB, NativeList<int> HEOECKOHDPD, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA6E0", Offset = "0x5DD9AE0", VA = "0x185DDA6E0")]
	private float GHDGJIJCBGN(float3 GGCAPAPOAOA, float3 KBFJDNLNNLH, GCFPOAFJBOD BLHCCKMPBJB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA140", Offset = "0x5DD9540", VA = "0x185DDA140")]
	private float3 DPCBAHGNEDF(float3 HPJEIKHOELI, float3 NBLDHKIPOGL, float3 CKJGCAIDIBP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB620", Offset = "0x5DDAA20", VA = "0x185DDB620")]
	private static float OIJKMPPCBOJ(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5DDB5C0", Offset = "0x5DDA9C0", VA = "0x185DDB5C0")]
	private static float3 NJHLPGAENJG(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA680", Offset = "0x5DD9A80", VA = "0x185DDA680")]
	private bool FAJGCMFHEBL(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5DDAC60", Offset = "0x5DDA060", VA = "0x185DDAC60")]
	private bool HJPFEKEEEOA(float3 JMHOJIPAIMC, float3 MLKGDIFPGGI, float3 CPHKPECCMOM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5DDA390", Offset = "0x5DD9790", VA = "0x185DDA390")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DD7760", Offset = "0x5DD6B60", VA = "0x185DD7760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int DALMIIANPBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7170", Offset = "0x5DD6570", VA = "0x185DD7170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HNAOJEOBKMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5DD6DB0", Offset = "0x5DD61B0", VA = "0x185DD6DB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HDEMIHJNAOG CGMNIKAABBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5DD7590", Offset = "0x5DD6990", VA = "0x185DD7590")]
		get
		{
			return default(HDEMIHJNAOG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8230", Offset = "0x5DD7630", VA = "0x185DD8230")]
	public KBHOAEHPOFH(int OHMLLCELOAI, int MPIKDMCFKKF, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD8200", Offset = "0x5DD7600", VA = "0x185DD8200")]
	public KBHOAEHPOFH(HDEMIHJNAOG KNFBGFBLKAK, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7D30", Offset = "0x5DD7130", VA = "0x185DD7D30")]
	public KBHOAEHPOFH(Mesh OFPOBDLGBHI, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7EA0", Offset = "0x5DD72A0", VA = "0x185DD7EA0")]
	public KBHOAEHPOFH(KBHOAEHPOFH KKOACPFFAML, Allocator LJHPECEMAME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5DD71B0", Offset = "0x5DD65B0", VA = "0x185DD71B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6DF0", Offset = "0x5DD61F0", VA = "0x185DD6DF0")]
	public void BKKEPFPDOJH([In] KBHOAEHPOFH HFLNDIDMJFD, float4x4 KIKGIFIBGIN, Transform EPGHFEOAKCG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7240", Offset = "0x5DD6640", VA = "0x185DD7240")]
	public void FPPIKLCOECB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5DD77A0", Offset = "0x5DD6BA0", VA = "0x185DD77A0")]
	public void OBAEPFHNLKL(float MEOGMCFNILK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7390", Offset = "0x5DD6790", VA = "0x185DD7390")]
	public KBHOAEHPOFH HEDOAOLCCPP(Allocator LJHPECEMAME, CancellationToken EANFAKGANNH)
	{
		return default(KBHOAEHPOFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7610", Offset = "0x5DD6A10", VA = "0x185DD7610")]
	public Mesh JDHMNDMOHMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7CE0", Offset = "0x5DD70E0", VA = "0x185DD7CE0")]
	private unsafe static float3* OFDOKHNKKFP(NativeArray<float3> NCABOBFFNFK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7C90", Offset = "0x5DD7090", VA = "0x185DD7C90")]
	private unsafe static int* OFDOKHNKKFP(NativeArray<int> NCABOBFFNFK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x5DD7730", Offset = "0x5DD6B30", VA = "0x185DD7730")]
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
		[Cpp2IlInjected.Address(RVA = "0x5DD6D00", Offset = "0x5DD6100", VA = "0x185DD6D00")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1BEE700", Offset = "0x1BEDB00", VA = "0x181BEE700")]
	public static HDEMIHJNAOG EHMNDHCEEPM(HDEMIHJNAOG JMHOJIPAIMC, HDEMIHJNAOG MLKGDIFPGGI)
	{
		return default(HDEMIHJNAOG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6C90", Offset = "0x5DD6090", VA = "0x185DD6C90")]
	public static HDEMIHJNAOG GOHIFGEDMEN(HDEMIHJNAOG CCIJIHALHGA, int JPEBMNHCEFF)
	{
		return default(HDEMIHJNAOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6C40", Offset = "0x5DD6040", VA = "0x185DD6C40", Slot = "0")]
	public override bool Equals(object PPCIJNHPNML)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6CB0", Offset = "0x5DD60B0", VA = "0x185DD6CB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5DD6D10", Offset = "0x5DD6110", VA = "0x185DD6D10", Slot = "3")]
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
