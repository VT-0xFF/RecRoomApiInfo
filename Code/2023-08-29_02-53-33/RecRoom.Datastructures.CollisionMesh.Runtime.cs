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
public struct OCNCDAEOFIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct NNMEBONIJIL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public int CPKPOAHGLFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public int FPOCOOLADAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public int JJLLCKJCHCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int EJMLIIHNLPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public int LKPIODHLODF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int HLBMKLLMKLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float3 CNPJDFDCCBM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6EDF100", Offset = "0x6EDE500", VA = "0x186EDF100")]
		public NNMEBONIJIL(int CKFDGGLJHBF, int PKNCDGDGJHL, int GHJMKMBIIAO, int BEFDFOLFFII, int AGDOJNGBNAH, int FJGMCAEIEGA, float3 LHLKLIEJLPJ)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private struct OLMFDCNMKFN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public int KGEFOILJABA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public int NKGIAJABGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float BHDMJMCECPO;

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x1ACCCB0", Offset = "0x1ACC0B0", VA = "0x181ACCCB0")]
		public OLMFDCNMKFN(int FJMJPHIILFN, int PIHOECLOCCD, float GOFPOLBMIKB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000005")]
	private struct JGBKJLMMDNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public int NKGIAJABGJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public int PEPIAKOPHBI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public int BLGJHCGDNGN;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private NativeParallelHashMap<int, NNMEBONIJIL> KFKCONIOLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private NativeList<OLMFDCNMKFN> DJPPOKGJHBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private NativeParallelHashMap<int, int> MKMJDAKADCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private NativeList<JGBKJLMMDNH> NPDMHJAFEMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private NativeParallelHashMap<int, int> JONCDIPBIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private int CLAFNLIOKDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private int PLHNLMIOOMO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFBF0", Offset = "0x6EDEFF0", VA = "0x186EDFBF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFB00", Offset = "0x6EDEF00", VA = "0x186EDFB00")]
	public bool CNNFIFGAOKL(in NativeArray<float3> IMMGKJBDMOE, ref NativeList<float3> NIBEKBCNIPB, ref NativeList<int> NLMDNELOIKN, Allocator GMMIODGPFPJ, CancellationToken DNKHCCGNODC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF140", Offset = "0x6EDE540", VA = "0x186EDF140")]
	private void BEFDPLAELIH(in NativeArray<float3> IMMGKJBDMOE, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1650", Offset = "0x6EE0A50", VA = "0x186EE1650")]
	private void PMCDOFKLEJH(in NativeArray<float3> IMMGKJBDMOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF6A0", Offset = "0x6EDEAA0", VA = "0x186EDF6A0")]
	private void CNIMOHKEIFG(in NativeArray<float3> IMMGKJBDMOE, out int IKHMELJJCCP, out int MDMLNAICADH, out int MCKLLFPMJFL, out int MGJKHFCPKJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0820", Offset = "0x6EDFC20", VA = "0x186EE0820")]
	private void HFBFEBPHEIL(in NativeArray<float3> IMMGKJBDMOE, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0340", Offset = "0x6EDF740", VA = "0x186EE0340")]
	private void HEGLJMDBCFK(in NativeArray<float3> IMMGKJBDMOE, float3 GAKPKGDNIKB, int CFPNHKPMOMK, NNMEBONIJIL OJFCDHJIMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6EE1240", Offset = "0x6EE0640", VA = "0x186EE1240")]
	private void OFCCGMNNLGG(in NativeArray<float3> IMMGKJBDMOE, float3 GAKPKGDNIKB, int OLFMMCIDOKP, int PLHNLMIOOMO, NNMEBONIJIL OJFCDHJIMPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFD90", Offset = "0x6EDF190", VA = "0x186EDFD90")]
	private void GAPMLDFOPHD(in NativeArray<float3> IMMGKJBDMOE, int MKEHAGELBFD, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF320", Offset = "0x6EDE720", VA = "0x186EDF320")]
	private void CMLLHAJDKAJ(in NativeArray<float3> IMMGKJBDMOE, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0B60", Offset = "0x6EDFF60", VA = "0x186EE0B60")]
	private void LKHLDPEEOBA(in NativeArray<float3> IMMGKJBDMOE, ref NativeList<float3> NIBEKBCNIPB, ref NativeList<int> NLMDNELOIKN, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0A10", Offset = "0x6EDFE10", VA = "0x186EE0A10")]
	private float HJDDODEIAMK(float3 GAKPKGDNIKB, float3 OMCFFJCHBEN, NNMEBONIJIL OJFCDHJIMPF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDD680", Offset = "0x6EDCA80", VA = "0x186EDD680")]
	private float3 CNPJDFDCCBM(float3 CKFDGGLJHBF, float3 PKNCDGDGJHL, float3 GHJMKMBIIAO)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45FD6C0", Offset = "0x45FCAC0", VA = "0x1845FD6C0")]
	private static float MKBDLCBGIAI(float3 EJOFMGLMADH, float3 CMACFBOCONA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x45FD550", Offset = "0x45FC950", VA = "0x1845FD550")]
	private static float3 KGBKFEMNBDN(float3 EJOFMGLMADH, float3 CMACFBOCONA)
	{
		return default(float3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6EDFD30", Offset = "0x6EDF130", VA = "0x186EDFD30")]
	private bool FAKAFHBJIMH(float3 EJOFMGLMADH, float3 CMACFBOCONA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0A80", Offset = "0x6EDFE80", VA = "0x186EE0A80")]
	private bool JJFGJEAFDFB(float3 EJOFMGLMADH, float3 CMACFBOCONA, float3 NCIBDKIMCKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6EE0F20", Offset = "0x6EE0320", VA = "0x186EE0F20")]
	private bool MGOKEABOLEL(float3 EJOFMGLMADH, float3 CMACFBOCONA, float3 NCIBDKIMCKG, float3 GOFPOLBMIKB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct GNFNODAFMGM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct DDOHLIACFAD
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
	private NativeList<float3> EDOMOOHDNOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private NativeList<int> PFPEIEJGCOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OGOLAABKALA
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6EDE9F0", Offset = "0x6EDDDF0", VA = "0x186EDE9F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int BIHFGIOJCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6EDDAE0", Offset = "0x6EDCEE0", VA = "0x186EDDAE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public bool DDCIGFMHKIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6EDDFE0", Offset = "0x6EDD3E0", VA = "0x186EDDFE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public HODIDBJJLKF BOAGDAPAAND
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEA30", Offset = "0x6EDDE30", VA = "0x186EDEA30")]
		get
		{
			return default(HODIDBJJLKF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEAE0", Offset = "0x6EDDEE0", VA = "0x186EDEAE0")]
	public GNFNODAFMGM(int MIIAPIAHMMC, int KNHEKPGEDCF, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEAB0", Offset = "0x6EDDEB0", VA = "0x186EDEAB0")]
	public GNFNODAFMGM(HODIDBJJLKF ACADOFCCFML, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEBA0", Offset = "0x6EDDFA0", VA = "0x186EDEBA0")]
	public GNFNODAFMGM(Mesh JDDLDLKOEPJ, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6EDED30", Offset = "0x6EDE130", VA = "0x186EDED30")]
	public GNFNODAFMGM(GNFNODAFMGM KJFNAECAHBA, Allocator GMMIODGPFPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE0C0", Offset = "0x6EDD4C0", VA = "0x186EDE0C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE2C0", Offset = "0x6EDD6C0", VA = "0x186EDE2C0")]
	public void EBOHBLNDMAL(in GNFNODAFMGM CANIEFMHGCA, float4x4 EDPPOHIOEHO, Transform HEONFDMDLPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE150", Offset = "0x6EDD550", VA = "0x186EDE150")]
	public void EAENINKEOEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6EDDB20", Offset = "0x6EDCF20", VA = "0x186EDDB20")]
	public void ANFFMPLOHGH(float AMDMMLBNHAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE650", Offset = "0x6EDDA50", VA = "0x186EDE650")]
	public GNFNODAFMGM IHFGFMINNNF(Allocator GMMIODGPFPJ, CancellationToken DNKHCCGNODC)
	{
		return default(GNFNODAFMGM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE8D0", Offset = "0x6EDDCD0", VA = "0x186EDE8D0")]
	public Mesh MHPOAIMAMLB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE070", Offset = "0x6EDD470", VA = "0x186EDE070")]
	private unsafe static float3* DMMOIFNBFBN(NativeArray<float3> KGHLGBOMEFA)
	{
		//IL_0002: Expected I, but got O
		return (float3*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE020", Offset = "0x6EDD420", VA = "0x186EDE020")]
	private unsafe static int* DMMOIFNBFBN(NativeArray<int> KGHLGBOMEFA)
	{
		//IL_0002: Expected I, but got O
		return (int*)unchecked((nint)null);
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6EDE620", Offset = "0x6EDDA20", VA = "0x186EDE620")]
	[CompilerGenerated]
	internal static void GDCGIOLJOCG(int MNFHGJLFJDE, int BAAJBNOKGAF, ref DDOHLIACFAD P_2)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct HODIDBJJLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public int OGOLAABKALA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public int BIHFGIOJCMJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NEEPKDOHEBK
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6EDEF90", Offset = "0x6EDE390", VA = "0x186EDEF90")]
		get
		{
			return default(int);
		}
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF040", Offset = "0x6EDE440", VA = "0x186EDF040")]
	public static HODIDBJJLKF PPNKFAMNDAO(HODIDBJJLKF EJOFMGLMADH, HODIDBJJLKF CMACFBOCONA)
	{
		return default(HODIDBJJLKF);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF020", Offset = "0x6EDE420", VA = "0x186EDF020")]
	public static HODIDBJJLKF KEMICHDMNGL(HODIDBJJLKF IOPDIGKHGJO, int ALOJIBNKIDG)
	{
		return default(HODIDBJJLKF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEFA0", Offset = "0x6EDE3A0", VA = "0x186EDEFA0", Slot = "0")]
	public override bool Equals(object KKAPANHPGCC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x6EDEFE0", Offset = "0x6EDE3E0", VA = "0x186EDEFE0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x6EDF060", Offset = "0x6EDE460", VA = "0x186EDF060", Slot = "3")]
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
