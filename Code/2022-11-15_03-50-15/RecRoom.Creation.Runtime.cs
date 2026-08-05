using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Microsoft.CodeAnalysis;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A5920", Offset = "0x6A4320", VA = "0x1806A5920")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x5A5A860", Offset = "0x5A59260", VA = "0x185A5A860")]
		public NullableAttribute(byte P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x37D25F0", Offset = "0x37D0FF0", VA = "0x1837D25F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LFLKDBDKAME
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5A55BB0", Offset = "0x5A545B0", VA = "0x185A55BB0")]
	public static bool JDGAENOOIJF(BCAOPAAKAMG FAMCEIMIPMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5A55830", Offset = "0x5A54230", VA = "0x185A55830")]
	private static bool JDGAENOOIJF(KMJLLKLNMEP PGAEIMKMJEI, ref BCAOPAAKAMG FAMCEIMIPMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public struct OGEMAFAHIHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	public List<OBKAEKFOLCN> GFPCNAJMFDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	public IEnumerable<IHNOIHLDFIH> AMHKKMAIAIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	public ENAFDFNKJFJ IFODLBAHNAA;
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface PFHCDGAPONN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void InitializeNewGraph(KCLLODHHBLH PJIINDGLAPJ, out Dictionary<int, int> LNGGDPNFGKM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void RunPreInitializationMigration(JHGFMLFBIGH PKNLCGKJEEC, GKFGACPHEMF INGBFPDIIKM);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public interface CJMJCBDDOIM
{
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IEnumerable<ByteString> GetValidRoomKeyReplicationIds();

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<ByteString> GetValidRoomCurrencies();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "2")]
	IEnumerable<ByteString> GetValidRoomConsumables();
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public sealed class KGLPEMOGHLK : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private readonly Dictionary<Guid, Guid> BIPCPJBBBAB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Dictionary<Guid, Guid> OPMICKGJOGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6EE0", Offset = "0x6B58E0", VA = "0x1806B6EE0")]
	public KGLPEMOGHLK(Dictionary<Guid, Guid> BIPCPJBBBAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5A54E30", Offset = "0x5A53830", VA = "0x185A54E30", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class NJAEFDEOEJL
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private sealed class IDPPBMJHAIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AGGELDDIPOE destinationGraph;

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public IDPPBMJHAIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5A54BD0", Offset = "0x5A535D0", VA = "0x185A54BD0")]
		internal bool <InitializeCircuitsV2Remapping>b__0(HCOMAIHFICB n)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class APINJMELCPA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public int mpif;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
		public APINJMELCPA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5A52DB0", Offset = "0x5A517B0", VA = "0x185A52DB0")]
		internal void <InitializeCircuitsV2Remapping>b__1(HCOMAIHFICB n)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000007")]
	private static readonly Dictionary<Guid, KMJLLKLNMEP> GEDDHKCOAIF;

	[Cpp2IlInjected.Token(Token = "0x4000008")]
	private static readonly Dictionary<Guid, Guid> GEAOMDPOAGK;

	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static readonly HashSet<IHNOIHLDFIH> GCFEGILOELE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static readonly HashSet<AGGELDDIPOE> CENIPCFOLLG;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static readonly List<CFMCDCBKKOG> ONGKBCDBKHH;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5A56000", Offset = "0x5A54A00", VA = "0x185A56000")]
	public static LEDHFCLAPEG AFGDJPOHNFI(OGEMAFAHIHH PGHMOHHKAPN, out DGNPGAGEIOB OPEGMPNJNLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5A577B0", Offset = "0x5A561B0", VA = "0x185A577B0")]
	private static void GBHPEICOKGE(LEDHFCLAPEG KNHFCOCAMDI, out DGNPGAGEIOB OPEGMPNJNLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5A57620", Offset = "0x5A56020", VA = "0x185A57620")]
	private static void EGDGAIHLHMN(OBKAEKFOLCN CBEPJFBNHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5A59140", Offset = "0x5A57B40", VA = "0x185A59140")]
	private static void KMKHBALMGEF(LEDHFCLAPEG KNHFCOCAMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A490", Offset = "0x5A58E90", VA = "0x185A5A490")]
	private static void PGFFMADNHOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x5A58DA0", Offset = "0x5A577A0", VA = "0x185A58DA0")]
	private static void ICNPDMDOFBM(ref OGEMAFAHIHH FDCJDHIPJPK, OBKAEKFOLCN CBEPJFBNHPL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x5A58420", Offset = "0x5A56E20", VA = "0x185A58420")]
	public static bool HILGCKGELBK(LEDHFCLAPEG KNHFCOCAMDI, HBHOJAJAFLF IDLLHBNDBHL, out KGLPEMOGHLK? DAPDKOMDLHF, out string? HENMPJPHDDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5A58CA0", Offset = "0x5A576A0", VA = "0x185A58CA0")]
	private static void IBLCOGBIGFL(LEDHFCLAPEG KNHFCOCAMDI, ref HBHOJAJAFLF IDLLHBNDBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5A590B0", Offset = "0x5A57AB0", VA = "0x185A590B0")]
	private static void IMACHGDLOLH(LEDHFCLAPEG KNHFCOCAMDI, ref HBHOJAJAFLF IDLLHBNDBHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x5A59E70", Offset = "0x5A58870", VA = "0x185A59E70")]
	private static bool PFPANBJIGBH(LEDHFCLAPEG KNHFCOCAMDI, JHGFMLFBIGH PKNLCGKJEEC, ref HBHOJAJAFLF IDLLHBNDBHL, out string HENMPJPHDDP, out Dictionary<int, int> LNGGDPNFGKM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x5A595B0", Offset = "0x5A57FB0", VA = "0x185A595B0")]
	private static Dictionary<Guid, KMJLLKLNMEP> LNGIODFCCMC(LEDHFCLAPEG KNHFCOCAMDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x5A564E0", Offset = "0x5A54EE0", VA = "0x185A564E0")]
	private static void AFOABDJMGPH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x5A56560", Offset = "0x5A54F60", VA = "0x185A56560")]
	private static bool APDLGLBHNFF(LEDHFCLAPEG KNHFCOCAMDI, ref HBHOJAJAFLF IDLLHBNDBHL, out string? HENMPJPHDDP, out JIACGDHICPD? MLLPFJPPKFK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x5A59430", Offset = "0x5A57E30", VA = "0x185A59430")]
	private static void KPHPNAEGFCN(bool LMNEMEPPIMC, OBKAEKFOLCN PNJAPIAHNFG, Dictionary<Guid, Guid> HFPMNEJPDBF, JIACGDHICPD KKFJDLPOJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x5A571F0", Offset = "0x5A55BF0", VA = "0x185A571F0")]
	private static void DIKAKBDOLIK(bool LMNEMEPPIMC, OBKAEKFOLCN PNJAPIAHNFG, JIACGDHICPD MLLPFJPPKFK, Guid HJDGLFLDGCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x5A56F50", Offset = "0x5A55950", VA = "0x185A56F50")]
	private static void BBEFJDEDPEC(OBKAEKFOLCN PNJAPIAHNFG, Guid IJCLADKNGEE, KNBCGJNHHMP? NJBDPHIICEH, Dictionary<Guid, KMJLLKLNMEP> FHCGANFFANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x5A594C0", Offset = "0x5A57EC0", VA = "0x185A594C0")]
	private static void LKHJHLFDKNK(OBKAEKFOLCN PNJAPIAHNFG, Dictionary<Guid, Guid> HFPMNEJPDBF, Dictionary<int, int> BIJCLDGIONI, JHGFMLFBIGH FGGDMAPIHEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x5A59830", Offset = "0x5A58230", VA = "0x185A59830")]
	public static void NJOOJOAAIOP(RepeatedField<OBKAEKFOLCN> JPHJJMFADKC, IJDMBBPDAKM JFLGLPJIFPO, IEnumerable<ByteString> CFLLJFEIGMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x5A578E0", Offset = "0x5A562E0", VA = "0x185A578E0")]
	private static void HDCMIKDHOJL(RepeatedField<OBKAEKFOLCN> JPHJJMFADKC, EILFDOJFOAP MBHJCNFINCL, CJMJCBDDOIM KAAPHADCIJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HBHOJAJAFLF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	public bool LMNEMEPPIMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	public bool LMGKKMJNACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public KNBCGJNHHMP? NJBDPHIICEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public KNBCGJNHHMP? DNNPKNGPAPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	public GNLCOKBOLEH KLHFNCFEINN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public CJMJCBDDOIM KAAPHADCIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public PFHCDGAPONN OBFINHFIGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public Guid HJDGLFLDGCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public ENAFDFNKJFJ IFODLBAHNAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public List<OBKAEKFOLCN> PLHFCKDJBHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public Dictionary<string, object> AHPIFDJBFJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public GMGIOFJPCKI JBIDHPMGKIP;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KNBCGJNHHMP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public Vector3 NHDHEIIIBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public Quaternion IOCIEOJKCCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float MMFEMDOMCCJ;

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public Matrix4x4 GEPFJGLBJAN
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5A54FA0", Offset = "0x5A539A0", VA = "0x185A54FA0")]
		get
		{
			return default(Matrix4x4);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static KNBCGJNHHMP OICOOKNGBOD
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5A54F40", Offset = "0x5A53940", VA = "0x185A54F40")]
		get
		{
			return default(KNBCGJNHHMP);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public bool BADPEPONJHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5A551F0", Offset = "0x5A53BF0", VA = "0x185A551F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0xB18860", Offset = "0xB17260", VA = "0x180B18860")]
	public KNBCGJNHHMP(Vector3 NHDHEIIIBBI, Quaternion IOCIEOJKCCH, float MMFEMDOMCCJ = 1f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000027")]
	[Cpp2IlInjected.Address(RVA = "0x5A556B0", Offset = "0x5A540B0", VA = "0x185A556B0")]
	public KNBCGJNHHMP(EJDFFKCEMPE GGJLDHLDAOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(RVA = "0x5A557D0", Offset = "0x5A541D0", VA = "0x185A557D0")]
	private KNBCGJNHHMP(KEHOJOMMMED JJDPCNJJLEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x5A54F70", Offset = "0x5A53970", VA = "0x185A54F70")]
	public static KNBCGJNHHMP EAHIBNPLNHA(IHNOIHLDFIH PBKJGMNNBOP)
	{
		return default(KNBCGJNHHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x5A550A0", Offset = "0x5A53AA0", VA = "0x185A550A0")]
	public static KNBCGJNHHMP FACHDNKCOHC(KNBCGJNHHMP EGNCPOLPGCD, KNBCGJNHHMP EPJJKJHAEOB)
	{
		return default(KNBCGJNHHMP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x5A553D0", Offset = "0x5A53DD0", VA = "0x185A553D0")]
	public static KNBCGJNHHMP MFJMDPBHOLK((Vector3, Quaternion, float) PJIINDGLAPJ)
	{
		return default(KNBCGJNHHMP);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5A55420", Offset = "0x5A53E20", VA = "0x185A55420")]
	public static KNBCGJNHHMP MFJMDPBHOLK(Matrix4x4 EGAAJDFFKGN)
	{
		return default(KNBCGJNHHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5A55520", Offset = "0x5A53F20", VA = "0x185A55520")]
	public KNBCGJNHHMP NENMGIEPKHL(Matrix4x4 MLMJNFGMBPE)
	{
		return default(KNBCGJNHHMP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x5A55200", Offset = "0x5A53C00", VA = "0x185A55200")]
	[CompilerGenerated]
	internal static KNBCGJNHHMP IBMNJNLADPM(IHNOIHLDFIH CPEGANFPGPI)
	{
		return default(KNBCGJNHHMP);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public sealed class CGBHJLJNKFF : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x5A535B0", Offset = "0x5A51FB0", VA = "0x185A535B0", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x5A53020", Offset = "0x5A51A20", VA = "0x185A53020")]
	private void KENCMADMFHJ(Dictionary<Guid, Guid> FEKJIAAAIKC, FOBKIIGLLIG MIMPJIMBFED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x5A53550", Offset = "0x5A51F50", VA = "0x185A53550")]
	private void KENCMADMFHJ(Dictionary<Guid, Guid> FEKJIAAAIKC, HJPCODHHBPP NPIDAAGLPPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x5A52DD0", Offset = "0x5A517D0", VA = "0x185A52DD0")]
	private void KENCMADMFHJ(Dictionary<Guid, Guid> FEKJIAAAIKC, IKPDCNNAFDF BFBCIEFMABF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public CGBHJLJNKFF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public sealed class KKIMIBPKBND : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x5A54E80", Offset = "0x5A53880", VA = "0x185A54E80", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public KKIMIBPKBND()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public sealed class HKMEAHJHNBM : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x5A54A60", Offset = "0x5A53460", VA = "0x185A54A60", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public HKMEAHJHNBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public sealed class LNANKKKIHCH : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x5A55BF0", Offset = "0x5A545F0", VA = "0x185A55BF0", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public LNANKKKIHCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public sealed class IMABGLCPFHD : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x5A54C20", Offset = "0x5A53620", VA = "0x185A54C20", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public IMABGLCPFHD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public sealed class GOFGIBKKHOA : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x5A53B40", Offset = "0x5A52540", VA = "0x185A53B40", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GOFGIBKKHOA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public sealed class NGDJOGEFBEH : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x5A55E10", Offset = "0x5A54810", VA = "0x185A55E10", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public NGDJOGEFBEH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public sealed class OBMNNGLDMHL : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5A5BC40", Offset = "0x5A5A640", VA = "0x185A5BC40", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public OBMNNGLDMHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public sealed class GJBBCKKKDEC : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5A53830", Offset = "0x5A52230", VA = "0x185A53830", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GJBBCKKKDEC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public sealed class DIEBMHCFPPM : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x5A53660", Offset = "0x5A52060", VA = "0x185A53660", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public DIEBMHCFPPM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public sealed class NPPKDJGHBIJ : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A740", Offset = "0x5A59140", VA = "0x185A5A740", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public NPPKDJGHBIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public sealed class GKBDAONPJJO : MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public static readonly System.Random GAAPBLBINAB;

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x5A53A00", Offset = "0x5A52400", VA = "0x185A53A00", Slot = "4")]
	public void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
	public GKBDAONPJJO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public struct BCAOPAAKAMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public JHGFMLFBIGH FDLOHCDDBIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public BKGAHBFKJIL NIAPFHGNAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public Dictionary<int, int> BIJCLDGIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public Dictionary<Guid, Guid> CPAMCDKONOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public GMGIOFJPCKI JBIDHPMGKIP;
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public interface MMKONNHHDGO
{
	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void MJFBKLEHDJP(MAHCLNLNLNJ ILKDMOFMCCD);
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public interface GMGIOFJPCKI
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool TryGetPersistenceViewId(int DNABGAHFEMO, out Guid ECJOJECEIAC);
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class HIOELEBCLKF
{
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private static readonly MMKONNHHDGO[] CGODJANCEOD;

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5A53CC0", Offset = "0x5A526C0", VA = "0x185A53CC0")]
	public static void AODCNCPJHBA(OBKAEKFOLCN PJIINDGLAPJ, Dictionary<Guid, Guid> MBGCKKFGMLK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5A53ED0", Offset = "0x5A528D0", VA = "0x185A53ED0")]
	public static void BMENIGGELNO(OBKAEKFOLCN? PJIINDGLAPJ, JIACGDHICPD KKFJDLPOJKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5A540C0", Offset = "0x5A52AC0", VA = "0x185A540C0")]
	public static void JDGAENOOIJF(MAHCLNLNLNJ ILKDMOFMCCD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public struct MAHCLNLNLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public JHGFMLFBIGH EKCJIDKACHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public OBKAEKFOLCN PNJAPIAHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Dictionary<int, int> BIJCLDGIONI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public Dictionary<Guid, Guid> CPAMCDKONOA;

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5A55D40", Offset = "0x5A54740", VA = "0x185A55D40")]
	public Guid DAADPGCJFDF(Guid CAPPBFKKCMA)
	{
		return default(Guid);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public sealed class OAMPLEJKNPA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	private readonly HashSet<string> PAIFJILMMGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<long, int> OGKKLJLPADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private readonly HashSet<Guid> KGICMFNDEFJ;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public IReadOnlyCollection<string> OHDAHMMHGGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB0", Offset = "0x6A38B0", VA = "0x1806A4EB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IReadOnlyDictionary<long, int> CNJIMLBLFPH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x6A4F10", Offset = "0x6A3910", VA = "0x1806A4F10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A8F0", Offset = "0x5A592F0", VA = "0x185A5A8F0")]
	public static OAMPLEJKNPA DIGEEEEPFJE(CDANCKEKNJL ELDHAGPPPNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x5A5B9B0", Offset = "0x5A5A3B0", VA = "0x185A5B9B0")]
	public static OAMPLEJKNPA NJENDAPDPLK(LEDHFCLAPEG PEDGALFILIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x5A5A960", Offset = "0x5A59360", VA = "0x185A5A960")]
	public static OAMPLEJKNPA GBOGMKNGBOP(IEnumerable<string> PAIFJILMMGN, IDictionary<long, int> JKODPLGBOIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x5A5BA20", Offset = "0x5A5A420", VA = "0x185A5BA20")]
	private OAMPLEJKNPA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x5A5BB20", Offset = "0x5A5A520", VA = "0x185A5BB20")]
	private OAMPLEJKNPA(IEnumerable<string> PAIFJILMMGN, IDictionary<long, int> JKODPLGBOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x5A5B110", Offset = "0x5A59B10", VA = "0x185A5B110")]
	private void LJNJEMCHDPL(CDANCKEKNJL ELDHAGPPPNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5A5B2D0", Offset = "0x5A59CD0", VA = "0x185A5B2D0")]
	private void LJNJEMCHDPL(LEDHFCLAPEG PEDGALFILIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5A5ACF0", Offset = "0x5A596F0", VA = "0x185A5ACF0")]
	private void LJNJEMCHDPL(IJDMBBPDAKM JBBMOMLGMKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5A5B840", Offset = "0x5A5A240", VA = "0x185A5B840")]
	private void LJNJEMCHDPL(HCOMAIHFICB CPEGANFPGPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5A5B490", Offset = "0x5A59E90", VA = "0x185A5B490")]
	private void LJNJEMCHDPL(OBKAEKFOLCN PNJAPIAHNFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5A5AAB0", Offset = "0x5A594B0", VA = "0x185A5AAB0")]
	private void KHEBMFNOGGF(string BGEJFNEAOPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5A5AB20", Offset = "0x5A59520", VA = "0x185A5AB20")]
	private void LCGLAIOCODO(IJPHIIMMFEA DBLKABLCLBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x5A5AC00", Offset = "0x5A59600", VA = "0x185A5AC00")]
	private void LCGLAIOCODO(HGOFLKOILHJ DBLKABLCLBK)
	{
	}
}
namespace Cpp2IlInjected
{
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
}
