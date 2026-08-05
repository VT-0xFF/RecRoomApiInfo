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
public struct MOIBIMGLILK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct KPLPPEECIMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int OJLFNCNLHKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int OBFKNGMJAAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int PGJEOICJFBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int BEPINONJCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int OKJFKLKHGDM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int BGADPGBGCLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 OPEEOBPEAFB;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x4D29A20", Offset = "0x4D28A20", VA = "0x184D29A20")]
		public KPLPPEECIMB(int NNDMCPAKKKK, int BILKJLAKKDD, int CCLLGLHPCKK, int ODJHLHIPHEK, int FBOCLFFJFNF, int ODLPCLODCDG, float3 GMGKIHODKLB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct LCDAGIIDDPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int DKMIHBFCPIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int DCDNLJDLNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float KPHDAFLFKPG;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x12E3940", Offset = "0x12E2940", VA = "0x1812E3940")]
		public LCDAGIIDDPI(int PAEJAEBLJPP, int JEOJALDAEDE, float HFCLJHDBBCO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct NFKOMMMDMPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int DCDNLJDLNGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int NFGODNPKPML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int OOPMOGLPOOJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, KPLPPEECIMB> EBKCKKFKOPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<LCDAGIIDDPI> MAGFIIKNJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> LOFOLHKCJEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<NFKOMMMDMPA> ILAAKKEMGLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> MEOPFODAOOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int LPNMKHEKJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int PMOGHGCHCFD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4D29F10", Offset = "0x4D28F10", VA = "0x184D29F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D2A760", Offset = "0x4D29760", VA = "0x184D2A760")]
	public bool GILGNJGEBCB(in NativeArray<float3> DCEGIOIIFBE, ref NativeList<float3> CJKCMACFGBJ, ref NativeList<int> OKFGMHECAEO, Allocator NAFOEFCFEGC, CancellationToken LFOGICEEHBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4D2A0C0", Offset = "0x4D290C0", VA = "0x184D2A0C0")]
	private void EMFGCIHFDBD(in NativeArray<float3> DCEGIOIIFBE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4D2B640", Offset = "0x4D2A640", VA = "0x184D2B640")]
	private void MACBGBGGIOB(in NativeArray<float3> DCEGIOIIFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4D2A840", Offset = "0x4D29840", VA = "0x184D2A840")]
	private void HHFKNAPJHKJ(in NativeArray<float3> DCEGIOIIFBE, out int DDGINNEHLCD, out int LGHJEBHJJFG, out int PEKNCDLFJJA, out int GGIFOBOFDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4D2B3F0", Offset = "0x4D2A3F0", VA = "0x184D2B3F0")]
	private void LJFIDCHFADH(in NativeArray<float3> DCEGIOIIFBE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4D2A220", Offset = "0x4D29220", VA = "0x184D2A220")]
	private void FAKMBODJGJL(in NativeArray<float3> DCEGIOIIFBE, float3 DICGPBMCFJD, int JOLGLACIAOI, KPLPPEECIMB OMPDIHMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4D29A60", Offset = "0x4D28A60", VA = "0x184D29A60")]
	private void AHECDHKDLNK(in NativeArray<float3> DCEGIOIIFBE, float3 DICGPBMCFJD, int DBGAEJACHJD, int PMOGHGCHCFD, KPLPPEECIMB OMPDIHMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4D2CB10", Offset = "0x4D2BB10", VA = "0x184D2CB10")]
	private void PLPNBKACPPC(in NativeArray<float3> DCEGIOIIFBE, int BNFIHODFHOI, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4D2AC80", Offset = "0x4D29C80", VA = "0x184D2AC80")]
	private void IDGNFKMGFCE(in NativeArray<float3> DCEGIOIIFBE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4D2B090", Offset = "0x4D2A090", VA = "0x184D2B090")]
	private void KLJLHNKHEDD(in NativeArray<float3> DCEGIOIIFBE, ref NativeList<float3> CJKCMACFGBJ, ref NativeList<int> OKFGMHECAEO, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D29E90", Offset = "0x4D28E90", VA = "0x184D29E90")]
	private float BJDOHANPIEB(float3 DICGPBMCFJD, float3 MKAHAAOEFIC, KPLPPEECIMB OMPDIHMFPPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D2C980", Offset = "0x4D2B980", VA = "0x184D2C980")]
	private float3 OPEEOBPEAFB(float3 NNDMCPAKKKK, float3 BILKJLAKKDD, float3 CCLLGLHPCKK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C645D0", Offset = "0x4C635D0", VA = "0x184C645D0")]
	private static float MMGMLEAKKDJ(float3 OOKPIHBNHGF, float3 FMMAACMCILJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D2AFC0", Offset = "0x4D29FC0", VA = "0x184D2AFC0")]
	private static float3 JDGDDFOBAPN(float3 OOKPIHBNHGF, float3 FMMAACMCILJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4D2A000", Offset = "0x4D29000", VA = "0x184D2A000")]
	private bool EFMBBPPHCIL(float3 OOKPIHBNHGF, float3 FMMAACMCILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D2CFE0", Offset = "0x4D2BFE0", VA = "0x184D2CFE0")]
	private bool PNLNBNHFINM(float3 OOKPIHBNHGF, float3 FMMAACMCILJ, float3 MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D2C1E0", Offset = "0x4D2B1E0", VA = "0x184D2C1E0")]
	private bool MHKJEMMPCAF(float3 OOKPIHBNHGF, float3 FMMAACMCILJ, float3 MCODHPOGBPN, float3 HFCLJHDBBCO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct PIFMNPPHMHH : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct LCIPCMMFAKB
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
	private NativeList<float3> NJFHAILJOFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> DEFKHCNMDHJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DKNAPJEHCKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x4D2D3C0", Offset = "0x4D2C3C0", VA = "0x184D2D3C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CJELAEEGFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4D2D280", Offset = "0x4D2C280", VA = "0x184D2D280")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ONMBOJMDGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4D2DE00", Offset = "0x4D2CE00", VA = "0x184D2DE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NFBPMPHNBOD CBFMKMBHOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D2D8B0", Offset = "0x4D2C8B0", VA = "0x184D2D8B0")]
		get
		{
			return default(NFBPMPHNBOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E5E0", Offset = "0x4D2D5E0", VA = "0x184D2E5E0")]
	public PIFMNPPHMHH(int OGEIIPHGPPF, int GMNEOPJLKEJ, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E690", Offset = "0x4D2D690", VA = "0x184D2E690")]
	public PIFMNPPHMHH(NFBPMPHNBOD DEHMCIGHFDE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E6C0", Offset = "0x4D2D6C0", VA = "0x184D2E6C0")]
	public PIFMNPPHMHH(Mesh ACEMLDCDLCF, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E3B0", Offset = "0x4D2D3B0", VA = "0x184D2E3B0")]
	public PIFMNPPHMHH(PIFMNPPHMHH JIJMHNDPFCA, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D400", Offset = "0x4D2C400", VA = "0x184D2D400", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D4B0", Offset = "0x4D2C4B0", VA = "0x184D2D4B0")]
	public void IONNJMGFDPB(in PIFMNPPHMHH PEJIHPGBPAG, float4x4 AGLJKIJPDMN, Transform OOKCBIBCJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E1F0", Offset = "0x4D2D1F0", VA = "0x184D2E1F0")]
	public void OMAJFKGCCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D930", Offset = "0x4D2C930", VA = "0x184D2D930")]
	public void LAFJJMKMDNN(float GNKOKACBJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4D2DE40", Offset = "0x4D2CE40", VA = "0x184D2DE40")]
	public PIFMNPPHMHH MCDDAOPPBHK(Allocator NAFOEFCFEGC, CancellationToken LFOGICEEHBE)
	{
		return default(PIFMNPPHMHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D2C0", Offset = "0x4D2C2C0", VA = "0x184D2D2C0")]
	public Mesh COHMMDJFHHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E1A0", Offset = "0x4D2D1A0", VA = "0x184D2E1A0")]
	private unsafe static float3* NEJBLPCMOOI(NativeArray<float3> ECGFLNEOIIM)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4D2E150", Offset = "0x4D2D150", VA = "0x184D2E150")]
	private unsafe static int* NEJBLPCMOOI(NativeArray<int> ECGFLNEOIIM)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D480", Offset = "0x4D2C480", VA = "0x184D2D480")]
	[CompilerGenerated]
	internal static void GBCFPPLLBMJ(int EHJOPFDKDDB, int CIENGIBBKGC, ref LCIPCMMFAKB P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct NFBPMPHNBOD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int DKNAPJEHCKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int CJELAEEGFDL;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KADHGBNAPGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x4D2D120", Offset = "0x4D2C120", VA = "0x184D2D120")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x3DB0B60", Offset = "0x3DAFB60", VA = "0x183DB0B60")]
	public static NFBPMPHNBOD GCJLOHFJPJA(NFBPMPHNBOD OOKPIHBNHGF, NFBPMPHNBOD FMMAACMCILJ)
	{
		return default(NFBPMPHNBOD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D1D0", Offset = "0x4D2C1D0", VA = "0x184D2D1D0")]
	public static NFBPMPHNBOD OBNIOOMOKNM(NFBPMPHNBOD CIOOEDEFNIA, int LEHCEKBDEKA)
	{
		return default(NFBPMPHNBOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D130", Offset = "0x4D2C130", VA = "0x184D2D130", Slot = "0")]
	public override bool Equals(object IGJIOFHFJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D180", Offset = "0x4D2C180", VA = "0x184D2D180", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4D2D1F0", Offset = "0x4D2C1F0", VA = "0x184D2D1F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface JFNALNOHMPA
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
