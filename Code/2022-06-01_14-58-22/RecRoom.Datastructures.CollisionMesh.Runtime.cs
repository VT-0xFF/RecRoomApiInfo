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
public struct GFFFDMPOFLI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct BKPCAICGIEP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int CIPAHLKPKDD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int HLJKPGDLHHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int OEIOCNHHHCL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int PMNGNAENAMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int FFGGJEHEEKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int DHNFBEMGLGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 BPJMCNPGBMI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x18CE890", Offset = "0x18CD290", VA = "0x1818CE890")]
		public BKPCAICGIEP(int OGCENDBKHJC, int NDKELCMMBLC, int EEJLFKNOIHN, int DCHLJDOADHL, int MJEDAHKJAHL, int BPDDDJKPIBB, float3 LLAMJMGCFGO)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct ACAHLJBDKEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int AKEKDOACPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int CNBCJLGHMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float MEGNFNJEEDH;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x18CE720", Offset = "0x18CD120", VA = "0x1818CE720")]
		public ACAHLJBDKEC(int ONGPCLJCNFH, int LAHEDMIAMCM, float GMLDCHLEGOG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct LABLCAKEKMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int CNBCJLGHMNA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int MIJKMADKFHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int MIFENABNBDG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeHashMap<int, BKPCAICGIEP> FPMFHKAENKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<ACAHLJBDKEC> ICMBJCBFDIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeHashMap<int, int> ONDKBKDCCPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<LABLCAKEKMN> BNCPFBAGAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeHashMap<int, int> CEJDGLEFJIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int OLBDGGKKICG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int DCMFCACCMKJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x18D0420", Offset = "0x18CEE20", VA = "0x1818D0420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x18D0020", Offset = "0x18CEA20", VA = "0x1818D0020")]
	public bool CEGOLJNIFNO(in NativeArray<float3> EHBIAINDNCH, ref NativeList<float3> HJEKIKCIMCJ, ref NativeList<int> HIJHAILLOIP, Allocator KJLCBPLKDJD, CancellationToken PKFOPLIPJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x18D33F0", Offset = "0x18D1DF0", VA = "0x1818D33F0")]
	private void LPDEJFLNIEO(in NativeArray<float3> EHBIAINDNCH, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x18D20D0", Offset = "0x18D0AD0", VA = "0x1818D20D0")]
	private void LABDFEIHOHP(in NativeArray<float3> EHBIAINDNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x18D2C70", Offset = "0x18D1670", VA = "0x1818D2C70")]
	private void LGFFNBKJKFH(in NativeArray<float3> EHBIAINDNCH, out int NKCGILPCBAM, out int KPELIEKPNIB, out int KBFFFGGDELD, out int CPCBNFDAOHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x18D0100", Offset = "0x18CEB00", VA = "0x1818D0100")]
	private void DKBMCLNHBFG(in NativeArray<float3> EHBIAINDNCH, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x18D0650", Offset = "0x18CF050", VA = "0x1818D0650")]
	private void GPHFGNNIPNN(in NativeArray<float3> EHBIAINDNCH, float3 BAMBIPKOPOH, int IKHMGFIOIFB, BKPCAICGIEP CLHHCLMIJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x18D11A0", Offset = "0x18CFBA0", VA = "0x1818D11A0")]
	private void ILEOLGAAHOE(in NativeArray<float3> EHBIAINDNCH, float3 BAMBIPKOPOH, int NCCGMMDACNC, int DCMFCACCMKJ, BKPCAICGIEP CLHHCLMIJNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x18D0B90", Offset = "0x18CF590", VA = "0x1818D0B90")]
	private void HFFIHEBGHNE(in NativeArray<float3> EHBIAINDNCH, int GPMHGPHGOPA, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x18D30B0", Offset = "0x18D1AB0", VA = "0x1818D30B0")]
	private void LIMJOAEGHMH(in NativeArray<float3> EHBIAINDNCH, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x18D1D70", Offset = "0x18D0770", VA = "0x1818D1D70")]
	private void JNFKCCCEDNF(in NativeArray<float3> EHBIAINDNCH, ref NativeList<float3> HJEKIKCIMCJ, ref NativeList<int> HIJHAILLOIP, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x18D05D0", Offset = "0x18CEFD0", VA = "0x1818D05D0")]
	private float GJPDECDDOBO(float3 BAMBIPKOPOH, float3 HENAFGKNPGA, BKPCAICGIEP CLHHCLMIJNK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x18CFE90", Offset = "0x18CE890", VA = "0x1818CFE90")]
	private float3 BPJMCNPGBMI(float3 OGCENDBKHJC, float3 NDKELCMMBLC, float3 EEJLFKNOIHN)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x183BA10", Offset = "0x183A410", VA = "0x18183BA10")]
	private static float JHLPHLDKJHL(float3 MMADIBJKHHM, float3 ODMIEFIFOGP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x18D0350", Offset = "0x18CED50", VA = "0x1818D0350")]
	private static float3 DPFBLNNPMNC(float3 MMADIBJKHHM, float3 ODMIEFIFOGP)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x18D0510", Offset = "0x18CEF10", VA = "0x1818D0510")]
	private bool GJEDBLGMKAI(float3 MMADIBJKHHM, float3 ODMIEFIFOGP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x18D1060", Offset = "0x18CFA60", VA = "0x1818D1060")]
	private bool IHNEKEPJFHB(float3 MMADIBJKHHM, float3 ODMIEFIFOGP, float3 HJNCMGDJMJJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x18D15D0", Offset = "0x18CFFD0", VA = "0x1818D15D0")]
	private bool JMLNGMCAAAL(float3 MMADIBJKHHM, float3 ODMIEFIFOGP, float3 HJNCMGDJMJJ, float3 GMLDCHLEGOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct EELOKDJMOBL : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct CMFFEEMNNLM
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
	private NativeList<float3> GMNHDGFDMJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> KIJKMCMINNH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PAOMDMPGOGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x18CF760", Offset = "0x18CE160", VA = "0x1818CF760")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int LMGDGEFEIHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x18CF4E0", Offset = "0x18CDEE0", VA = "0x1818CF4E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool IMGCPAFLFBA
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x18CF720", Offset = "0x18CE120", VA = "0x1818CF720")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public AFLHDNHHNHE PHGNCAJCIBP
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x18CF5A0", Offset = "0x18CDFA0", VA = "0x1818CF5A0")]
		get
		{
			return default(AFLHDNHHNHE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x18CFDB0", Offset = "0x18CE7B0", VA = "0x1818CFDB0")]
	public EELOKDJMOBL(int HIFFGNNDLLF, int NFHCBCLHELA, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x18CFE60", Offset = "0x18CE860", VA = "0x1818CFE60")]
	public EELOKDJMOBL(AFLHDNHHNHE JOGGKNIPDHH, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x18CFC30", Offset = "0x18CE630", VA = "0x1818CFC30")]
	public EELOKDJMOBL(Mesh EALEDNNEEBC, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x18CFA00", Offset = "0x18CE400", VA = "0x1818CFA00")]
	public EELOKDJMOBL(EELOKDJMOBL CIBAGEDPOOH, Allocator KJLCBPLKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x18CF520", Offset = "0x18CDF20", VA = "0x1818CF520", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x18CEDD0", Offset = "0x18CD7D0", VA = "0x1818CEDD0")]
	public void CEGAKGBDODP(in EELOKDJMOBL EKMDJKANAME, float4x4 DHNHIMNMIOK, Transform NPJNJHOFJCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x18CF7A0", Offset = "0x18CE1A0", VA = "0x1818CF7A0")]
	public void MPKAGBHFLLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x18CE8D0", Offset = "0x18CD2D0", VA = "0x1818CE8D0")]
	public void ABLJCNMOGGC(float JJPDDGGNEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x18CF1D0", Offset = "0x18CDBD0", VA = "0x1818CF1D0")]
	public EELOKDJMOBL DDCEABADHAG(Allocator KJLCBPLKDJD, CancellationToken PKFOPLIPJOL)
	{
		return default(EELOKDJMOBL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x18CF620", Offset = "0x18CE020", VA = "0x1818CF620")]
	public Mesh GAJHNMDOICD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x18CF9B0", Offset = "0x18CE3B0", VA = "0x1818CF9B0")]
	private unsafe static float3* NEENEAEMHGG(NativeArray<float3> OBKDNKHGCJN)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x18CF960", Offset = "0x18CE360", VA = "0x1818CF960")]
	private unsafe static int* NEENEAEMHGG(NativeArray<int> OBKDNKHGCJN)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x18CEDA0", Offset = "0x18CD7A0", VA = "0x1818CEDA0")]
	[CompilerGenerated]
	internal static void AJBJKBFADFG(int INACBMGHLPM, int FJDEEOIBHOG, ref CMFFEEMNNLM P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct AFLHDNHHNHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int PAOMDMPGOGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int LMGDGEFEIHJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KBOECACHOEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x18CE7F0", Offset = "0x18CD1F0", VA = "0x1818CE7F0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x1560A00", Offset = "0x155F400", VA = "0x181560A00")]
	public static AFLHDNHHNHE EKHKEPKDEBI(AFLHDNHHNHE MMADIBJKHHM, AFLHDNHHNHE ODMIEFIFOGP)
	{
		return default(AFLHDNHHNHE);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x18CE730", Offset = "0x18CD130", VA = "0x1818CE730")]
	public static AFLHDNHHNHE CCOLGOPOJHI(AFLHDNHHNHE CBFJKEPFBND, int KNJNCOEKBIE)
	{
		return default(AFLHDNHHNHE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x18CE750", Offset = "0x18CD150", VA = "0x1818CE750", Slot = "0")]
	public override bool Equals(object LBCOBOKABJG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x18CE7A0", Offset = "0x18CD1A0", VA = "0x1818CE7A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x18CE800", Offset = "0x18CD200", VA = "0x1818CE800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface AIBNJEOCLGK
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
