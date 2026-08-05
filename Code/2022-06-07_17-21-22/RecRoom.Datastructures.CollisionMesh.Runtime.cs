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
		[Cpp2IlInjected.Address(RVA = "0x4EBB370", Offset = "0x4EB9B70", VA = "0x184EBB370")]
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
		[Cpp2IlInjected.Address(RVA = "0x148D7B0", Offset = "0x148BFB0", VA = "0x18148D7B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4EBB860", Offset = "0x4EBA060", VA = "0x184EBB860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC0B0", Offset = "0x4EBA8B0", VA = "0x184EBC0B0")]
	public bool GILGNJGEBCB(in NativeArray<float3> DCEGIOIIFBE, ref NativeList<float3> CJKCMACFGBJ, ref NativeList<int> OKFGMHECAEO, Allocator NAFOEFCFEGC, CancellationToken LFOGICEEHBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBA10", Offset = "0x4EBA210", VA = "0x184EBBA10")]
	private void EMFGCIHFDBD(in NativeArray<float3> DCEGIOIIFBE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4EBCF90", Offset = "0x4EBB790", VA = "0x184EBCF90")]
	private void MACBGBGGIOB(in NativeArray<float3> DCEGIOIIFBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC190", Offset = "0x4EBA990", VA = "0x184EBC190")]
	private void HHFKNAPJHKJ(in NativeArray<float3> DCEGIOIIFBE, out int DDGINNEHLCD, out int LGHJEBHJJFG, out int PEKNCDLFJJA, out int GGIFOBOFDFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4EBCD40", Offset = "0x4EBB540", VA = "0x184EBCD40")]
	private void LJFIDCHFADH(in NativeArray<float3> DCEGIOIIFBE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4EBBB70", Offset = "0x4EBA370", VA = "0x184EBBB70")]
	private void FAKMBODJGJL(in NativeArray<float3> DCEGIOIIFBE, float3 DICGPBMCFJD, int JOLGLACIAOI, KPLPPEECIMB OMPDIHMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB3B0", Offset = "0x4EB9BB0", VA = "0x184EBB3B0")]
	private void AHECDHKDLNK(in NativeArray<float3> DCEGIOIIFBE, float3 DICGPBMCFJD, int DBGAEJACHJD, int PMOGHGCHCFD, KPLPPEECIMB OMPDIHMFPPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE460", Offset = "0x4EBCC60", VA = "0x184EBE460")]
	private void PLPNBKACPPC(in NativeArray<float3> DCEGIOIIFBE, int BNFIHODFHOI, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC5D0", Offset = "0x4EBADD0", VA = "0x184EBC5D0")]
	private void IDGNFKMGFCE(in NativeArray<float3> DCEGIOIIFBE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC9E0", Offset = "0x4EBB1E0", VA = "0x184EBC9E0")]
	private void KLJLHNKHEDD(in NativeArray<float3> DCEGIOIIFBE, ref NativeList<float3> CJKCMACFGBJ, ref NativeList<int> OKFGMHECAEO, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB7E0", Offset = "0x4EB9FE0", VA = "0x184EBB7E0")]
	private float BJDOHANPIEB(float3 DICGPBMCFJD, float3 MKAHAAOEFIC, KPLPPEECIMB OMPDIHMFPPH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE2D0", Offset = "0x4EBCAD0", VA = "0x184EBE2D0")]
	private float3 OPEEOBPEAFB(float3 NNDMCPAKKKK, float3 BILKJLAKKDD, float3 CCLLGLHPCKK)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4E5AB20", Offset = "0x4E59320", VA = "0x184E5AB20")]
	private static float MMGMLEAKKDJ(float3 OOKPIHBNHGF, float3 FMMAACMCILJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4EBC910", Offset = "0x4EBB110", VA = "0x184EBC910")]
	private static float3 JDGDDFOBAPN(float3 OOKPIHBNHGF, float3 FMMAACMCILJ)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x4EBB950", Offset = "0x4EBA150", VA = "0x184EBB950")]
	private bool EFMBBPPHCIL(float3 OOKPIHBNHGF, float3 FMMAACMCILJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4EBE930", Offset = "0x4EBD130", VA = "0x184EBE930")]
	private bool PNLNBNHFINM(float3 OOKPIHBNHGF, float3 FMMAACMCILJ, float3 MCODHPOGBPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4EBDB30", Offset = "0x4EBC330", VA = "0x184EBDB30")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EBED10", Offset = "0x4EBD510", VA = "0x184EBED10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CJELAEEGFDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x4EBEBD0", Offset = "0x4EBD3D0", VA = "0x184EBEBD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool ONMBOJMDGLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF750", Offset = "0x4EBDF50", VA = "0x184EBF750")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public NFBPMPHNBOD CBFMKMBHOIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4EBF200", Offset = "0x4EBDA00", VA = "0x184EBF200")]
		get
		{
			return default(NFBPMPHNBOD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFF30", Offset = "0x4EBE730", VA = "0x184EBFF30")]
	public PIFMNPPHMHH(int OGEIIPHGPPF, int GMNEOPJLKEJ, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFFE0", Offset = "0x4EBE7E0", VA = "0x184EBFFE0")]
	public PIFMNPPHMHH(NFBPMPHNBOD DEHMCIGHFDE, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4EC0010", Offset = "0x4EBE810", VA = "0x184EC0010")]
	public PIFMNPPHMHH(Mesh ACEMLDCDLCF, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFD00", Offset = "0x4EBE500", VA = "0x184EBFD00")]
	public PIFMNPPHMHH(PIFMNPPHMHH JIJMHNDPFCA, Allocator NAFOEFCFEGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x4EBED50", Offset = "0x4EBD550", VA = "0x184EBED50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEE00", Offset = "0x4EBD600", VA = "0x184EBEE00")]
	public void IONNJMGFDPB(in PIFMNPPHMHH PEJIHPGBPAG, float4x4 AGLJKIJPDMN, Transform OOKCBIBCJCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFB40", Offset = "0x4EBE340", VA = "0x184EBFB40")]
	public void OMAJFKGCCDG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x4EBF280", Offset = "0x4EBDA80", VA = "0x184EBF280")]
	public void LAFJJMKMDNN(float GNKOKACBJGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x4EBF790", Offset = "0x4EBDF90", VA = "0x184EBF790")]
	public PIFMNPPHMHH MCDDAOPPBHK(Allocator NAFOEFCFEGC, CancellationToken LFOGICEEHBE)
	{
		return default(PIFMNPPHMHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEC10", Offset = "0x4EBD410", VA = "0x184EBEC10")]
	public Mesh COHMMDJFHHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFAF0", Offset = "0x4EBE2F0", VA = "0x184EBFAF0")]
	private unsafe static float3* NEJBLPCMOOI(NativeArray<float3> ECGFLNEOIIM)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x4EBFAA0", Offset = "0x4EBE2A0", VA = "0x184EBFAA0")]
	private unsafe static int* NEJBLPCMOOI(NativeArray<int> ECGFLNEOIIM)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEDD0", Offset = "0x4EBD5D0", VA = "0x184EBEDD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x4EBEA70", Offset = "0x4EBD270", VA = "0x184EBEA70")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x40A86A0", Offset = "0x40A6EA0", VA = "0x1840A86A0")]
	public static NFBPMPHNBOD GCJLOHFJPJA(NFBPMPHNBOD OOKPIHBNHGF, NFBPMPHNBOD FMMAACMCILJ)
	{
		return default(NFBPMPHNBOD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEB20", Offset = "0x4EBD320", VA = "0x184EBEB20")]
	public static NFBPMPHNBOD OBNIOOMOKNM(NFBPMPHNBOD CIOOEDEFNIA, int LEHCEKBDEKA)
	{
		return default(NFBPMPHNBOD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEA80", Offset = "0x4EBD280", VA = "0x184EBEA80", Slot = "0")]
	public override bool Equals(object IGJIOFHFJCJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEAD0", Offset = "0x4EBD2D0", VA = "0x184EBEAD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x4EBEB40", Offset = "0x4EBD340", VA = "0x184EBEB40", Slot = "3")]
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
