using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using JetBrains.Annotations;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CEOCIAMIFJE]
public class MBLGELEIJBG : ADNPJLABBAO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly AHDNLDFPFMB CPHNEDMPENG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FE40", Offset = "0x6F2E640", VA = "0x186F2FE40")]
	[Preserve]
	public MBLGELEIJBG([NDCFMLCHJCI(null)][NotNull] AHDNLDFPFMB CPHNEDMPENG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3135BD0", Offset = "0x31343D0", VA = "0x183135BD0", Slot = "4")]
	public bool NJAGLPFHMKN<TExperiment>([Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3135CA0", Offset = "0x31344A0", VA = "0x183135CA0", Slot = "5")]
	public bool NJAGLPFHMKN<TExperiment>(string EOHAHOLHAFK, [Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IIKNJMHHOOA
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface AHDNLDFPFMB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJAGLPFHMKN<TExperiment>([Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJAGLPFHMKN<TExperiment>(string EOHAHOLHAFK, [Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void CAGIIJGFEEK();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface ADNPJLABBAO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NJAGLPFHMKN<TExperiment>([Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NJAGLPFHMKN<TExperiment>(string EOHAHOLHAFK, [Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class JPLLMAADCHN : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct PCCICMILKGL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo FNIGJLNMBNP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type GDPFGIAHEJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F306A0", Offset = "0x6F2EEA0", VA = "0x186F306A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6F30790", Offset = "0x6F2EF90", VA = "0x186F30790")]
	public PCCICMILKGL(MemberInfo FNIGJLNMBNP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6F30120", Offset = "0x6F2E920", VA = "0x186F30120")]
	public object AHMKMPCDJJL(object INCBEIDOHDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6F304D0", Offset = "0x6F2ECD0", VA = "0x186F304D0")]
	public void NNIJFPFCHML(object INCBEIDOHDO, object INDENPJBLHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6F30270", Offset = "0x6F2EA70", VA = "0x186F30270")]
	private static bool GIEICPKIIMM(Type MBPNHBINGNC, object INDENPJBLHO, [Out] object IGPGKJMAPIC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum NGNDHONMNIO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MDEAIBAFJGN : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string AEHPFKGBHAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool LPIJOAGEBFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly NGNDHONMNIO JDHDLBDLIBL;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FEE0", Offset = "0x6F2E6E0", VA = "0x186F2FEE0")]
	public MDEAIBAFJGN([Optional] string IKMKCMDHFDC, NGNDHONMNIO OCLAPBNMMGE = NGNDHONMNIO.Experiment, bool DFNOFJHPEEJ = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class PBNNFCHJJCM : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string AEHPFKGBHAA;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F300E0", Offset = "0x6F2E8E0", VA = "0x186F300E0")]
	public PBNNFCHJJCM(string IKMKCMDHFDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[CEOCIAMIFJE]
public class NPJGNPJFIBK : AHDNLDFPFMB
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class JJDABEEEGIA<TExperiment> where TExperiment : IIKNJMHHOOA, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JFLMKPADPMF statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		public JJDABEEEGIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x453A830", Offset = "0x4539030", VA = "0x18453A830")]
		internal bool MLHIANANGLH(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly KHOLIEJJFCA PDNGGKANKHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, IIKNJMHHOOA> IBHOHLKMPJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, MDEAIBAFJGN> LKLFEFNMKAF;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FF90", Offset = "0x6F2E790", VA = "0x186F2FF90")]
	[Preserve]
	public NPJGNPJFIBK([NotNull][NDCFMLCHJCI(null)] KHOLIEJJFCA PDNGGKANKHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x31D9870", Offset = "0x31D8070", VA = "0x1831D9870", Slot = "4")]
	public bool NJAGLPFHMKN<TExperiment>([Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x31D9310", Offset = "0x31D7B10", VA = "0x1831D9310", Slot = "5")]
	public bool NJAGLPFHMKN<TExperiment>(string EOHAHOLHAFK, [Out] TExperiment HLHHKMCKAPN) where TExperiment : IIKNJMHHOOA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6F2FF40", Offset = "0x6F2E740", VA = "0x186F2FF40", Slot = "6")]
	public void CAGIIJGFEEK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x31D8E80", Offset = "0x31D7680", VA = "0x1831D8E80")]
	private bool FHDGDIPMADG<TExperiment>([Out] MDEAIBAFJGN PHODLBMAJDL) where TExperiment : IIKNJMHHOOA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x31D8F70", Offset = "0x31D7770", VA = "0x1831D8F70")]
	private static void LGJOIFPIMBG<TExperiment>(TExperiment HLHHKMCKAPN, PBCBPMGNLGP MLNELDFOJAL, Predicate<string> GHNCBJOLOGI) where TExperiment : IIKNJMHHOOA
	{
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
