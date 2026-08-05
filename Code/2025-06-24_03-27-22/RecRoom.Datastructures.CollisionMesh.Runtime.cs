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
public struct CMKLCOBPBGE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct FIELGGEBHGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int LNLEPMFECNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int LHBPOOEMKPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int NIBAODBCCIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int AGCEPEGEHOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LBDACELIEBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int NPEFBHAIHPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 PJNJOMDHHBB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7D84B60", Offset = "0x7D83760", VA = "0x187D84B60")]
		public FIELGGEBHGM(int BLPOCDFNOIL, int PKEEOKNPGCB, int IMLECBKHOCG, int IFKPBPIAAFI, int ENJHEBAKKEL, int PPBNKBIJHDO, float3 AKLPJIPJBIP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct PIEPFKACJDI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int FLKLHBLEILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int NDKMDEJEALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float GIPEHEBCDJE;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xD67F70", Offset = "0xD66B70", VA = "0x180D67F70")]
		public PIEPFKACJDI(int MBEDIGACNGC, int AIKFECNONDF, float AGJAGGFLJFN)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct CBMBGNGHMAI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int NDKMDEJEALE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int BEMAGLGIILL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int NLKHOMCNABA;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, FIELGGEBHGM> PEKPODAADPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<PIEPFKACJDI> DONEKBGPEAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> EPKOJMBCADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<CBMBGNGHMAI> LAADHCPMPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> FMNEICONJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int NDGOAEIEIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int GEGEKHBIDFL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7D81360", Offset = "0x7D7FF60", VA = "0x187D81360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7D81890", Offset = "0x7D80490", VA = "0x187D81890")]
	public bool HFCFNJNILAO([In] NativeArray<float3> BNAMFAKNLBI, NativeList<float3> MKENBMIHMDD, NativeList<int> AOGBBJDELEI, Allocator CMJGNOOCEGA, CancellationToken DKKNFNCKCEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7D825E0", Offset = "0x7D811E0", VA = "0x187D825E0")]
	private void LEIJOMGLGOC([In] NativeArray<float3> BNAMFAKNLBI, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7D83460", Offset = "0x7D82060", VA = "0x187D83460")]
	private void NNLIKBGIHFN([In] NativeArray<float3> BNAMFAKNLBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7D82FA0", Offset = "0x7D81BA0", VA = "0x187D82FA0")]
	private void NLIPECFEJOL([In] NativeArray<float3> BNAMFAKNLBI, [Out] int DKHNELOHMNA, [Out] int HCIAFHLEINC, [Out] int PDMDDGDBNPC, [Out] int EKEEKOOLBBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7D84960", Offset = "0x7D83560", VA = "0x187D84960")]
	private void PMFGALPGAFG([In] NativeArray<float3> BNAMFAKNLBI, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7D820A0", Offset = "0x7D80CA0", VA = "0x187D820A0")]
	private void IIELDIEJJDM([In] NativeArray<float3> BNAMFAKNLBI, float3 DKPBHLCONCP, int NEFJCEGHDGB, FIELGGEBHGM BIEGEMILBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7D814A0", Offset = "0x7D800A0", VA = "0x187D814A0")]
	private void FMBMNLFHPKC([In] NativeArray<float3> BNAMFAKNLBI, float3 DKPBHLCONCP, int OKIKLDJAEGD, int GEGEKHBIDFL, FIELGGEBHGM BIEGEMILBJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7D81A30", Offset = "0x7D80630", VA = "0x187D81A30")]
	private void IHOFPHGDNII([In] NativeArray<float3> BNAMFAKNLBI, int IDPKEKEIFNO, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7D844E0", Offset = "0x7D830E0", VA = "0x187D844E0")]
	private void PCBEONMOFGF([In] NativeArray<float3> BNAMFAKNLBI, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7D827C0", Offset = "0x7D813C0", VA = "0x187D827C0")]
	private void MLPAOMKPDOO([In] NativeArray<float3> BNAMFAKNLBI, NativeList<float3> MKENBMIHMDD, NativeList<int> AOGBBJDELEI, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7D819D0", Offset = "0x7D805D0", VA = "0x187D819D0")]
	private float HKKLJGNKBDN(float3 DKPBHLCONCP, float3 EHEDCAJLJEP, FIELGGEBHGM BIEGEMILBJL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7D84850", Offset = "0x7D83450", VA = "0x187D84850")]
	private float3 PJNJOMDHHBB(float3 BLPOCDFNOIL, float3 PKEEOKNPGCB, float3 IMLECBKHOCG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7D81330", Offset = "0x7D7FF30", VA = "0x187D81330")]
	private static float BHGMAMOCHAN(float3 ABBBJFPFEKP, float3 KLKIJPOLHDE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7D84480", Offset = "0x7D83080", VA = "0x187D84480")]
	private static float3 OHIMMKLICPE(float3 ABBBJFPFEKP, float3 KLKIJPOLHDE)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7D82580", Offset = "0x7D81180", VA = "0x187D82580")]
	private bool JKIANAFKAFN(float3 ABBBJFPFEKP, float3 KLKIJPOLHDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7D81260", Offset = "0x7D7FE60", VA = "0x187D81260")]
	private bool AFBKIGHGKJO(float3 ABBBJFPFEKP, float3 KLKIJPOLHDE, float3 OFHHGNENJGM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7D82C90", Offset = "0x7D81890", VA = "0x187D82C90")]
	private bool MOMOPBOGAIP(float3 ABBBJFPFEKP, float3 KLKIJPOLHDE, float3 OFHHGNENJGM, float3 AGJAGGFLJFN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct LCOHJIIMMCI : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct HJIIDMKECLG
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
	private NativeList<float3> FAPOMMCOBBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> EPADMDMCIHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NLHDEGLOJPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7D853F0", Offset = "0x7D83FF0", VA = "0x187D853F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BOIFLPBFMOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7D84D10", Offset = "0x7D83910", VA = "0x187D84D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool HLKMBCEEOBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7D85C20", Offset = "0x7D84820", VA = "0x187D85C20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public GBOOCAAGOMF KALGHJJEJAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7D84D50", Offset = "0x7D83950", VA = "0x187D84D50")]
		get
		{
			return default(GBOOCAAGOMF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7D85E30", Offset = "0x7D84A30", VA = "0x187D85E30")]
	public LCOHJIIMMCI(int GKGFHINNECN, int DOEJCKPBDOF, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C90", Offset = "0x7D84890", VA = "0x187D85C90")]
	public LCOHJIIMMCI(GBOOCAAGOMF KILPGNGNIOJ, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7D85CC0", Offset = "0x7D848C0", VA = "0x187D85CC0")]
	public LCOHJIIMMCI(Mesh BFDKALDCPEN, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7D85EF0", Offset = "0x7D84AF0", VA = "0x187D85EF0")]
	public LCOHJIIMMCI(LCOHJIIMMCI PEDMEJIDLNB, Allocator CMJGNOOCEGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7D85360", Offset = "0x7D83F60", VA = "0x187D85360", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7D858A0", Offset = "0x7D844A0", VA = "0x187D858A0")]
	public void NKAMMCABBBC([In] LCOHJIIMMCI GBEGHJIHKEG, float4x4 HHGKCBBJJPO, Transform NPLLEDAFPNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7D85750", Offset = "0x7D84350", VA = "0x187D85750")]
	public void NCMDOKADGEI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7D84E70", Offset = "0x7D83A70", VA = "0x187D84E70")]
	public void DJDDBFMDBOD(float KNLGCBPGFKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7D85550", Offset = "0x7D84150", VA = "0x187D85550")]
	public LCOHJIIMMCI MDFAMMJFBAF(Allocator CMJGNOOCEGA, CancellationToken DKKNFNCKCEB)
	{
		return default(LCOHJIIMMCI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7D85430", Offset = "0x7D84030", VA = "0x187D85430")]
	public Mesh IJBOLOALJCL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x7D84E20", Offset = "0x7D83A20", VA = "0x187D84E20")]
	private unsafe static float3* CNDBDHPFBEL(NativeArray<float3> IKALPCJBCLK)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7D84DD0", Offset = "0x7D839D0", VA = "0x187D84DD0")]
	private unsafe static int* CNDBDHPFBEL(NativeArray<int> IKALPCJBCLK)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7D85C60", Offset = "0x7D84860", VA = "0x187D85C60")]
	[CompilerGenerated]
	internal static void PPGCNKOIAIG(int NKHIFABCDPF, int LGOAIGPFOHO, HJIIDMKECLG P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct GBOOCAAGOMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int NLHDEGLOJPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int BOIFLPBFMOI;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OPFLLIEAANC
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7D84BA0", Offset = "0x7D837A0", VA = "0x187D84BA0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x27EEB70", Offset = "0x27ED770", VA = "0x1827EEB70")]
	public static GBOOCAAGOMF EEHLCDOICDL(GBOOCAAGOMF ABBBJFPFEKP, GBOOCAAGOMF KLKIJPOLHDE)
	{
		return default(GBOOCAAGOMF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7D84C00", Offset = "0x7D83800", VA = "0x187D84C00")]
	public static GBOOCAAGOMF FIHBNDOJAEG(GBOOCAAGOMF FEEKLFKPHPD, int IJDADKHAHCN)
	{
		return default(GBOOCAAGOMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7D84BB0", Offset = "0x7D837B0", VA = "0x187D84BB0", Slot = "0")]
	public override bool Equals(object EKJMBPAGJBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7D84C20", Offset = "0x7D83820", VA = "0x187D84C20", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7D84C70", Offset = "0x7D83870", VA = "0x187D84C70", Slot = "3")]
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
