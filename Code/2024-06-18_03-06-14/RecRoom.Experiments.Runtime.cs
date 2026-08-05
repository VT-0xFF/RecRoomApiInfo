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
[FABAIOIDLJO]
public class GFJFGIIBFDD : OBHIENNDDMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly GGAINDLHEDD CNPDKPLDIJM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x68B56D0", Offset = "0x68B40D0", VA = "0x1868B56D0")]
	[Preserve]
	public GFJFGIIBFDD([OHLKLPAILPF(null)][NotNull] GGAINDLHEDD CNPDKPLDIJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D3C0", Offset = "0x2B1BDC0", VA = "0x182B1D3C0", Slot = "4")]
	public bool NGKGPFBPILN<TExperiment>([Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2B1D490", Offset = "0x2B1BE90", VA = "0x182B1D490", Slot = "5")]
	public bool NGKGPFBPILN<TExperiment>(string PMKDJHCKFAG, [Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MMBGHGNLNOB
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface GGAINDLHEDD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGKGPFBPILN<TExperiment>([Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGKGPFBPILN<TExperiment>(string PMKDJHCKFAG, [Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void JEIGNDNNDCL();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OBHIENNDDMB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NGKGPFBPILN<TExperiment>([Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NGKGPFBPILN<TExperiment>(string PMKDJHCKFAG, [Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class EADMHIJPBOL : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct JDKFMJHANHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo KKPCGENIFNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type HLPIMAIIGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x68B59D0", Offset = "0x68B43D0", VA = "0x1868B59D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68B5D60", Offset = "0x68B4760", VA = "0x1868B5D60")]
	public JDKFMJHANHL(MemberInfo KKPCGENIFNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68B5C40", Offset = "0x68B4640", VA = "0x1868B5C40")]
	public object OGMPHPCIBNO(object GKHPLGCJCPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x68B5A90", Offset = "0x68B4490", VA = "0x1868B5A90")]
	public void JGAEDOBGECC(object GKHPLGCJCPF, object DBOBEHLEAAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68B5770", Offset = "0x68B4170", VA = "0x1868B5770")]
	private static bool CGLCLENNNIK(Type PEFHIGPIGHN, object DBOBEHLEAAE, [Out] object BDOLKKGKHLF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum CHCFELFIIIC
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class MBJIOGFGFIF : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string JGFOABOCNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool HEGLNMGEILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly CHCFELFIIIC PNFBJLDEHGB;

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x68B6010", Offset = "0x68B4A10", VA = "0x1868B6010")]
	public MBJIOGFGFIF([Optional] string CCMEKJGADHN, CHCFELFIIIC ADDOHDGDFOD = CHCFELFIIIC.Experiment, bool OEBCHCCHLKH = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class PGNFCBDEMOO : PreserveAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string JGFOABOCNPB;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x68B6070", Offset = "0x68B4A70", VA = "0x1868B6070")]
	public PGNFCBDEMOO(string CCMEKJGADHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[FABAIOIDLJO]
public class LKMCEJAKKFA : GGAINDLHEDD
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class MADGBDPIHIO<TExperiment> where TExperiment : MMBGHGNLNOB, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public NLIJFOGGGGC statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public MADGBDPIHIO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4459D80", Offset = "0x4458780", VA = "0x184459D80")]
		internal bool PMNPJLLIDGK(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly BACKHJNLNPC ENPFHCCDEDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, MMBGHGNLNOB> LBJEBDECFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, MBJIOGFGFIF> PFKBNLGELNE;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x68B5EC0", Offset = "0x68B48C0", VA = "0x1868B5EC0")]
	[Preserve]
	public LKMCEJAKKFA([NotNull][OHLKLPAILPF(null)] BACKHJNLNPC ENPFHCCDEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4690", Offset = "0x2BD3090", VA = "0x182BD4690", Slot = "4")]
	public bool NGKGPFBPILN<TExperiment>([Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4740", Offset = "0x2BD3140", VA = "0x182BD4740", Slot = "5")]
	public bool NGKGPFBPILN<TExperiment>(string PMKDJHCKFAG, [Out] TExperiment JANEHAACEMB) where TExperiment : MMBGHGNLNOB, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x68B5E70", Offset = "0x68B4870", VA = "0x1868B5E70", Slot = "6")]
	public void JEIGNDNNDCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x2BD41B0", Offset = "0x2BD2BB0", VA = "0x182BD41B0")]
	private bool LDMHILNNLFL<TExperiment>([Out] MBJIOGFGFIF LBNBAFKNFBC) where TExperiment : MMBGHGNLNOB
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x2BD42A0", Offset = "0x2BD2CA0", VA = "0x182BD42A0")]
	private static void LHDFIBKONKM<TExperiment>(TExperiment JANEHAACEMB, KHPAJCGCDDO FJAKFNLMDBM, Predicate<string> NOEGNPNKHBM) where TExperiment : MMBGHGNLNOB
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
