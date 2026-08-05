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
[PAAFOJGLPBB]
public class MIJCFEMOMIK : BNECAANEPHE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly IIOAKOJKONM NLDLABCIIJC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x611E160", Offset = "0x611D360", VA = "0x18611E160")]
	[Preserve]
	public MIJCFEMOMIK([MINIJLJAKNC(null)][NotNull] IIOAKOJKONM NLDLABCIIJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x293C690", Offset = "0x293B890", VA = "0x18293C690", Slot = "4")]
	public bool FGLMHHPMJAE<TExperiment>([Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x293C5C0", Offset = "0x293B7C0", VA = "0x18293C5C0", Slot = "5")]
	public bool FGLMHHPMJAE<TExperiment>(string GNAEFGDJFCN, [Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GOONCBHIEII
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface IIOAKOJKONM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGLMHHPMJAE<TExperiment>([Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGLMHHPMJAE<TExperiment>(string GNAEFGDJFCN, [Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void IHCECJIMICI();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface BNECAANEPHE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool FGLMHHPMJAE<TExperiment>([Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool FGLMHHPMJAE<TExperiment>(string GNAEFGDJFCN, [Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class ACBGMEFNPMK : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct HLDDJILDIMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo JIIDKKAJMJP;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type EKFNMEIEPNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x611DA20", Offset = "0x611CC20", VA = "0x18611DA20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x611E010", Offset = "0x611D210", VA = "0x18611E010")]
	public HLDDJILDIMF(MemberInfo JIIDKKAJMJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x611DAE0", Offset = "0x611CCE0", VA = "0x18611DAE0")]
	public object DEFCJDJADPC(object GLMGCMELGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x611DE60", Offset = "0x611D060", VA = "0x18611DE60")]
	public void MPDNNEIICMH(object GLMGCMELGFD, object EKDDCPALANJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x611DC00", Offset = "0x611CE00", VA = "0x18611DC00")]
	private static bool EGAMLPLFBDF(Type BFCDKHCBOIF, object EKDDCPALANJ, [Out] object JLAKLKGFLMJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum BNNBOGKIBAJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class HLAAHLKMEPI : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string FLDBLPHJNKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool MHMGDNBBBKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly BNNBOGKIBAJ MEBDELDBDDE;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x611D9C0", Offset = "0x611CBC0", VA = "0x18611D9C0")]
	public HLAAHLKMEPI([Optional] string MPENHPFDCDK, BNNBOGKIBAJ MJMAEGDPBNJ = BNNBOGKIBAJ.Experiment, bool FJGKMLKIJFI = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class LMCEHICIDAP : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string FLDBLPHJNKM;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x611E120", Offset = "0x611D320", VA = "0x18611E120")]
	public LMCEHICIDAP(string MPENHPFDCDK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[PAAFOJGLPBB]
public class DEJMJIJFEMD : IIOAKOJKONM
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class IGPEHKEMIII<TExperiment> where TExperiment : GOONCBHIEII, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public DCLDDFNAFDD statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public IGPEHKEMIII()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3A38F30", Offset = "0x3A38130", VA = "0x183A38F30")]
		internal bool PFDAHNLDNDG(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly GJGMEPPNEHB EPLOBGGOJAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, GOONCBHIEII> MNNAKDCNBEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, HLAAHLKMEPI> OBDJODILGFM;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x611D870", Offset = "0x611CA70", VA = "0x18611D870")]
	[Preserve]
	public DEJMJIJFEMD([NotNull][MINIJLJAKNC(null)] GJGMEPPNEHB EPLOBGGOJAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x271E090", Offset = "0x271D290", VA = "0x18271E090", Slot = "4")]
	public bool FGLMHHPMJAE<TExperiment>([Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x271DC10", Offset = "0x271CE10", VA = "0x18271DC10", Slot = "5")]
	public bool FGLMHHPMJAE<TExperiment>(string GNAEFGDJFCN, [Out] TExperiment CLNGPGAHPDE) where TExperiment : GOONCBHIEII, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x611D820", Offset = "0x611CA20", VA = "0x18611D820", Slot = "6")]
	public void IHCECJIMICI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x271DB20", Offset = "0x271CD20", VA = "0x18271DB20")]
	private bool CPNCGGABCHO<TExperiment>([Out] HLAAHLKMEPI KJFMIPENKMO) where TExperiment : GOONCBHIEII
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x271E120", Offset = "0x271D320", VA = "0x18271E120")]
	private static void LKPCPEMEGGE<TExperiment>(TExperiment CLNGPGAHPDE, AEOJOEOHBIC AHDGFNOBCGJ, Predicate<string> FPKJGDPPNGK) where TExperiment : GOONCBHIEII
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
