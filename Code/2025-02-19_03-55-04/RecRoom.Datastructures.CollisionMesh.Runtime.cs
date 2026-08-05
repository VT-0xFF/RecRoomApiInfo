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
public struct MGCOCDMPLNP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MDOGGOPJHEA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int MCFIPIHAHNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int BOGIPEJIOBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int NICPALCCPGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int OGPPMNKOHMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int FEFOAKJPHNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int MCJCOABPDII;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 PPMOPOJLBMI;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7469F60", Offset = "0x7468B60", VA = "0x187469F60")]
		public MDOGGOPJHEA(int MCJILLNBGCI, int ELFDNANPLHA, int GLPIBHAKNBF, int HCDEFKDJHIF, int CELPOEEAOOP, int IOJOJIPFHGC, float3 HKFKAONALCJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct FBLFLMMEGCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int NFMPBNMALGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int JGFCLFEJPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float OGEKFOMFAJO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB6C910", Offset = "0xB6B510", VA = "0x180B6C910")]
		public FBLFLMMEGCO(int NKBNDBLIKOB, int MMGBMBGODOJ, float AACKLMAHFCG)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct OFNHCFOELPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int JGFCLFEJPNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int ELMNKFBJLBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int LFOHPNODKCK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, MDOGGOPJHEA> ANMADJBJHPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<FBLFLMMEGCO> EOLOHADHANE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> LDPBCFDPLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<OFNHCFOELPM> CKDKPKLLDMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> KONLFELAGOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int PANCEEFBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int HLONICKPBOB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x746A910", Offset = "0x7469510", VA = "0x18746A910", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x746C520", Offset = "0x746B120", VA = "0x18746C520")]
	public bool JBONLOGFJLP([In] NativeArray<float3> FFJMDHKDEEO, NativeList<float3> JMNBHJDFIGC, NativeList<int> LDOJKNAIJDP, Allocator LNBNGBBFCIG, CancellationToken NAOIMKEDKEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7469FA0", Offset = "0x7468BA0", VA = "0x187469FA0")]
	private void AIMKJDEKJHN([In] NativeArray<float3> FFJMDHKDEEO, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x746ADC0", Offset = "0x74699C0", VA = "0x18746ADC0")]
	private void FPDJHEACHJE([In] NativeArray<float3> FFJMDHKDEEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x746CD90", Offset = "0x746B990", VA = "0x18746CD90")]
	private void KMKOPKPNIMN([In] NativeArray<float3> FFJMDHKDEEO, [Out] int NKGGNKLKJPO, [Out] int HOJGAGAFAEC, [Out] int FIFMGFBIJLP, [Out] int MLFLCJCPFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x746BDE0", Offset = "0x746A9E0", VA = "0x18746BDE0")]
	private void GNDDBAIGFEP([In] NativeArray<float3> FFJMDHKDEEO, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x746C040", Offset = "0x746AC40", VA = "0x18746C040")]
	private void IBNOBLLOIOJ([In] NativeArray<float3> FFJMDHKDEEO, float3 LMLKPPMEPBH, int OCMIJOEIOGC, MDOGGOPJHEA CIKGFDFJKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x746A520", Offset = "0x7469120", VA = "0x18746A520")]
	private void DDBEHDMAKOA([In] NativeArray<float3> FFJMDHKDEEO, float3 LMLKPPMEPBH, int GAFCMLCOOML, int HLONICKPBOB, MDOGGOPJHEA CIKGFDFJKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x746C660", Offset = "0x746B260", VA = "0x18746C660")]
	private void KBBDFNPPMOH([In] NativeArray<float3> FFJMDHKDEEO, int MODKDJIEEJL, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x746AA50", Offset = "0x7469650", VA = "0x18746AA50")]
	private void FDHLMFNLPMK([In] NativeArray<float3> FFJMDHKDEEO, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x746D250", Offset = "0x746BE50", VA = "0x18746D250")]
	private void PDCCMFACLNO([In] NativeArray<float3> FFJMDHKDEEO, NativeList<float3> JMNBHJDFIGC, NativeList<int> LDOJKNAIJDP, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x746A180", Offset = "0x7468D80", VA = "0x18746A180")]
	private float APPDPAKEMFP(float3 LMLKPPMEPBH, float3 EFMEGBCEINK, MDOGGOPJHEA CIKGFDFJKIK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x746D730", Offset = "0x746C330", VA = "0x18746D730")]
	private float3 PPMOPOJLBMI(float3 MCJILLNBGCI, float3 ELFDNANPLHA, float3 GLPIBHAKNBF)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x746A4F0", Offset = "0x74690F0", VA = "0x18746A4F0")]
	private static float DCHFFLIEOGN(float3 CEDOOEEEDCO, float3 LJEHMGANCNG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x746BFE0", Offset = "0x746ABE0", VA = "0x18746BFE0")]
	private static float3 HPAMJAHANHN(float3 CEDOOEEEDCO, float3 LJEHMGANCNG)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x746CD30", Offset = "0x746B930", VA = "0x18746CD30")]
	private bool KILJPFAGJAK(float3 CEDOOEEEDCO, float3 LJEHMGANCNG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x746CC60", Offset = "0x746B860", VA = "0x18746CC60")]
	private bool KHMJNNJMCBN(float3 CEDOOEEEDCO, float3 LJEHMGANCNG, float3 NFEBCHCLBIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x746A1E0", Offset = "0x7468DE0", VA = "0x18746A1E0")]
	private bool CIFBAHHBEKF(float3 CEDOOEEEDCO, float3 LJEHMGANCNG, float3 NFEBCHCLBIA, float3 AACKLMAHFCG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct COJECNBEAJP : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KAJFIKNLHHA
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
	private NativeList<float3> COEIHBBLEGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> GICMADNDFEK;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JCNFNBFILJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x7468920", Offset = "0x7467520", VA = "0x187468920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int JECCJKMHPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x74697E0", Offset = "0x74683E0", VA = "0x1874697E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool NHPIKHBJFOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x74697A0", Offset = "0x74683A0", VA = "0x1874697A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public JEAAPHCAMBD IOADHHHJBLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x74688A0", Offset = "0x74674A0", VA = "0x1874688A0")]
		get
		{
			return default(JEAAPHCAMBD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7469B90", Offset = "0x7468790", VA = "0x187469B90")]
	public COJECNBEAJP(int FMJGJMIJBHM, int EOBBLLBGIJG, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7469C50", Offset = "0x7468850", VA = "0x187469C50")]
	public COJECNBEAJP(JEAAPHCAMBD FBODEDABEDK, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7469C80", Offset = "0x7468880", VA = "0x187469C80")]
	public COJECNBEAJP(Mesh LDLKDBPEDDB, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7469820", Offset = "0x7468420", VA = "0x187469820")]
	public COJECNBEAJP(COJECNBEAJP LLDJIJICLJF, Allocator LNBNGBBFCIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7468D20", Offset = "0x7467920", VA = "0x187468D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7468DB0", Offset = "0x74679B0", VA = "0x187468DB0")]
	public void GFCJDEIJPEO([In] COJECNBEAJP BIKFHOMEEFN, float4x4 BMBNADKCDGO, Transform GKCIGODLLEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7469160", Offset = "0x7467D60", VA = "0x187469160")]
	public void GJGMIGKDFPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x74692B0", Offset = "0x7467EB0", VA = "0x1874692B0")]
	public void LOAFJEJDCBL(float JOBEKHJDCMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7468A00", Offset = "0x7467600", VA = "0x187468A00")]
	public COJECNBEAJP CPLAGGJKBMF(Allocator LNBNGBBFCIG, CancellationToken NAOIMKEDKEJ)
	{
		return default(COJECNBEAJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7468C00", Offset = "0x7467800", VA = "0x187468C00")]
	public Mesh DEPIMNPHGKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x74689B0", Offset = "0x74675B0", VA = "0x1874689B0")]
	private unsafe static float3* BNCKCJJGPAJ(NativeArray<float3> CPOMPIIIEGC)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x7468960", Offset = "0x7467560", VA = "0x187468960")]
	private unsafe static int* BNCKCJJGPAJ(NativeArray<int> CPOMPIIIEGC)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x7469130", Offset = "0x7467D30", VA = "0x187469130")]
	[CompilerGenerated]
	internal static void GJDLBHLPPKO(int KDKCIJEGNMD, int KMHFEMCINFF, KAJFIKNLHHA P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct JEAAPHCAMBD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int JCNFNBFILJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int JECCJKMHPLK;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KKFNPHOKNPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7469EB0", Offset = "0x7468AB0", VA = "0x187469EB0")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x242F0C0", Offset = "0x242DCC0", VA = "0x18242F0C0")]
	public static JEAAPHCAMBD OMKCABOBHEN(JEAAPHCAMBD CEDOOEEEDCO, JEAAPHCAMBD LJEHMGANCNG)
	{
		return default(JEAAPHCAMBD);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x7469E90", Offset = "0x7468A90", VA = "0x187469E90")]
	public static JEAAPHCAMBD JNFBHIBAEBC(JEAAPHCAMBD EGNFAFCAMGM, int MHDGHBLPNDO)
	{
		return default(JEAAPHCAMBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7469DF0", Offset = "0x74689F0", VA = "0x187469DF0", Slot = "0")]
	public override bool Equals(object CCKCAOGHMPG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7469E40", Offset = "0x7468A40", VA = "0x187469E40", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7469EC0", Offset = "0x7468AC0", VA = "0x187469EC0", Slot = "3")]
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
