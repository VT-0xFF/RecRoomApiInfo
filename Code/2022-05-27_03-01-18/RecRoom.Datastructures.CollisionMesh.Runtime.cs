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
public struct JLOGMEHPPGC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct AEDBMDAPEGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int HDEPDNHKBPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int MEPNCGHAAKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int JBCGDFKIIJB;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int CJHABBPNAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int PGDMEECNHPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int CPMLPHPOFEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 BGIJCBPLNEA;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA130", Offset = "0x1DC9130", VA = "0x181DCA130")]
		public AEDBMDAPEGF(int LNKDKNHFMHE, int BDHLHFEJENM, int ADAOKPMLFCG, int NEOICCKFOGG, int NCKMJANBLDF, int BHILBECHKNA, float3 EPFFFFCNKLI)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct HHFJECAFCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int JCGMIMCEFLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JOCBBGMKDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float CGKDBALCGFI;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA2D0", Offset = "0x1DC92D0", VA = "0x181DCA2D0")]
		public HHFJECAFCCO(int ODINNAEBCEA, int DAFIBMCLHDM, float CGNILIACKIE)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct EGNHBBJKMKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JOCBBGMKDBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int NBCMFCDPMDC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int MAPLMEBOLNO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, AEDBMDAPEGF> FJPGBOBBCDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<HHFJECAFCCO> HAADOOIFDBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> HCJOACPJCIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<EGNHBBJKMKN> LOKEIAOOFCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> HFBNHPEANDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int MOCOAEANCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int NLGKGOKPDFF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBA10", Offset = "0x1DCAA10", VA = "0x181DCBA10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC3D0", Offset = "0x1DCB3D0", VA = "0x181DCC3D0")]
	public bool IJFOHCFJGBN(in NativeArray<float3> GCFAKGFJIBA, ref NativeList<float3> IBHDOJOBHPC, ref NativeList<int> PBAMPFKDJCA, Allocator IJPEBFBKMDH, CancellationToken CMOIBOJIACL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBB00", Offset = "0x1DCAB00", VA = "0x181DCBB00")]
	private void EDEIJCODOEL(in NativeArray<float3> GCFAKGFJIBA, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1DCADF0", Offset = "0x1DC9DF0", VA = "0x181DCADF0")]
	private void CHIEOFMONGM(in NativeArray<float3> GCFAKGFJIBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA2E0", Offset = "0x1DC92E0", VA = "0x181DCA2E0")]
	private void AMICGJEENHO(in NativeArray<float3> GCFAKGFJIBA, out int PCJELCGMNKB, out int NNLHPDAHJLG, out int HMPEJCDFFLO, out int ONFJNIBKMID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD750", Offset = "0x1DCC750", VA = "0x181DCD750")]
	private void NENJJMIMFPH(in NativeArray<float3> GCFAKGFJIBA, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA8B0", Offset = "0x1DC98B0", VA = "0x181DCA8B0")]
	private void BMABCLNHMIF(in NativeArray<float3> GCFAKGFJIBA, float3 ECAKKCJGNHD, int JGLJDHEPLJA, AEDBMDAPEGF DHMMOOGMOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1DCBC60", Offset = "0x1DCAC60", VA = "0x181DCBC60")]
	private void EGKGDOPACIM(in NativeArray<float3> GCFAKGFJIBA, float3 ECAKKCJGNHD, int OIDOIFIBABC, int NLGKGOKPDFF, AEDBMDAPEGF DHMMOOGMOJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD1B0", Offset = "0x1DCC1B0", VA = "0x181DCD1B0")]
	private void MCGNHIAGCOG(in NativeArray<float3> GCFAKGFJIBA, int CLCMMMPCOPL, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC090", Offset = "0x1DCB090", VA = "0x181DCC090")]
	private void FKAOANLAHOA(in NativeArray<float3> GCFAKGFJIBA, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCC50", Offset = "0x1DCBC50", VA = "0x181DCCC50")]
	private void JNLICOEDINF(in NativeArray<float3> GCFAKGFJIBA, ref NativeList<float3> IBHDOJOBHPC, ref NativeList<int> PBAMPFKDJCA, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1DCB990", Offset = "0x1DCA990", VA = "0x181DCB990")]
	private float DODKPFECDHA(float3 ECAKKCJGNHD, float3 PLBPAPPALNJ, AEDBMDAPEGF DHMMOOGMOJM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA720", Offset = "0x1DC9720", VA = "0x181DCA720")]
	private float3 BGIJCBPLNEA(float3 LNKDKNHFMHE, float3 BDHLHFEJENM, float3 ADAOKPMLFCG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x1D2FED0", Offset = "0x1D2EED0", VA = "0x181D2FED0")]
	private static float JCKKJKMCJJG(float3 NCGEKBENJBA, float3 IIFMPDAMAIA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD680", Offset = "0x1DCC680", VA = "0x181DCD680")]
	private static float3 MNLPEPKNHCH(float3 NCGEKBENJBA, float3 IIFMPDAMAIA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1DCD0F0", Offset = "0x1DCC0F0", VA = "0x181DCD0F0")]
	private bool LIFJAEEIOCN(float3 NCGEKBENJBA, float3 IIFMPDAMAIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1DCCFB0", Offset = "0x1DCBFB0", VA = "0x181DCCFB0")]
	private bool KJADOICLAGC(float3 NCGEKBENJBA, float3 IIFMPDAMAIA, float3 AHENHIDOBEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1DCC4B0", Offset = "0x1DCB4B0", VA = "0x181DCC4B0")]
	private bool IJKMEDHBFIN(float3 NCGEKBENJBA, float3 IIFMPDAMAIA, float3 AHENHIDOBEA, float3 CGNILIACKIE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct ABLCIPKGLIL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct AFEAMLLBGOJ
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
	private NativeList<float3> ILMIABPIODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> NCGEHEEAFBM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LKBEPKDJHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x1DC91F0", Offset = "0x1DC81F0", VA = "0x181DC91F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int APGLOKGNLKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x1DC90C0", Offset = "0x1DC80C0", VA = "0x181DC90C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool AHJJPJDNFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9100", Offset = "0x1DC8100", VA = "0x181DC9100")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public DHGAILNFCFE AIMBINBKJID
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1DC8B70", Offset = "0x1DC7B70", VA = "0x181DC8B70")]
		get
		{
			return default(DHGAILNFCFE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9CA0", Offset = "0x1DC8CA0", VA = "0x181DC9CA0")]
	public ABLCIPKGLIL(int MHDCFAJEMPJ, int ENLELCDJLGN, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA100", Offset = "0x1DC9100", VA = "0x181DCA100")]
	public ABLCIPKGLIL(DHGAILNFCFE EMCEDBGCNOD, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9F80", Offset = "0x1DC8F80", VA = "0x181DC9F80")]
	public ABLCIPKGLIL(Mesh FCHIEFHJLOJ, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9D50", Offset = "0x1DC8D50", VA = "0x181DC9D50")]
	public ABLCIPKGLIL(ABLCIPKGLIL OGNHKENMEGF, Allocator IJPEBFBKMDH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9140", Offset = "0x1DC8140", VA = "0x181DC9140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x1DC97A0", Offset = "0x1DC87A0", VA = "0x181DC97A0")]
	public void NENJMCKJAJO(in ABLCIPKGLIL KEIJPKNBGAA, float4x4 CGJJNAIALJA, Transform OIJAJOJNFJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9540", Offset = "0x1DC8540", VA = "0x181DC9540")]
	public void LGBELCNPLKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x1DC8BF0", Offset = "0x1DC7BF0", VA = "0x181DC8BF0")]
	public void BPFJKFLGLPL(float NFELGDCJCGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9230", Offset = "0x1DC8230", VA = "0x181DC9230")]
	public ABLCIPKGLIL HJLLPDKKGIM(Allocator IJPEBFBKMDH, CancellationToken CMOIBOJIACL)
	{
		return default(ABLCIPKGLIL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9BA0", Offset = "0x1DC8BA0", VA = "0x181DC9BA0")]
	public Mesh PKJNDLCCABK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9700", Offset = "0x1DC8700", VA = "0x181DC9700")]
	private unsafe static float3* LLBAJFPPEGH(NativeArray<float3> BEGPAFGBCJM)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9750", Offset = "0x1DC8750", VA = "0x181DC9750")]
	private unsafe static int* LLBAJFPPEGH(NativeArray<int> BEGPAFGBCJM)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x1DC91C0", Offset = "0x1DC81C0", VA = "0x181DC91C0")]
	[CompilerGenerated]
	internal static void GCAIKMMFPOH(int FLPCJOIIMJK, int JHIPDGOLJDM, ref AFEAMLLBGOJ P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct DHGAILNFCFE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int LKBEPKDJHAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int APGLOKGNLKA;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KPJEJCIOJEO
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x1DCA210", Offset = "0x1DC9210", VA = "0x181DCA210")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1AAF310", Offset = "0x1AAE310", VA = "0x181AAF310")]
	public static DHGAILNFCFE BNJHJDGNPLG(DHGAILNFCFE NCGEKBENJBA, DHGAILNFCFE IIFMPDAMAIA)
	{
		return default(DHGAILNFCFE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA220", Offset = "0x1DC9220", VA = "0x181DCA220")]
	public static DHGAILNFCFE LJJBDLDIFIA(DHGAILNFCFE DJMPNAJEJHD, int KGHBJMEOBNM)
	{
		return default(DHGAILNFCFE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA170", Offset = "0x1DC9170", VA = "0x181DCA170", Slot = "0")]
	public override bool Equals(object AFMIMCLOCLP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA1C0", Offset = "0x1DC91C0", VA = "0x181DCA1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA240", Offset = "0x1DC9240", VA = "0x181DCA240", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface LECLEKMDCIB
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
