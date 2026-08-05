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
[BCNMPBBOPDG]
public class GLDBFECIGMF : OJAPLOICPNL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BDBIOHGAGEF DFIJPIGBCHL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B30570", Offset = "0x6B2F370", VA = "0x186B30570")]
	[Preserve]
	public GLDBFECIGMF([NotNull][HDMGOABMPFL(null)] BDBIOHGAGEF DFIJPIGBCHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2AE2430", Offset = "0x2AE1230", VA = "0x182AE2430", Slot = "4")]
	public bool EAKHKPOIGPA<TExperiment>(string FIJENMMLADA, out TExperiment BHIPAEPKKHP) where TExperiment : ANODELHAJHP, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ANODELHAJHP
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BDBIOHGAGEF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAKHKPOIGPA<TExperiment>(string FIJENMMLADA, out TExperiment BHIPAEPKKHP) where TExperiment : ANODELHAJHP, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void EEOGKEPJNHG();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface OJAPLOICPNL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool EAKHKPOIGPA<TExperiment>(string FIJENMMLADA, out TExperiment BHIPAEPKKHP) where TExperiment : ANODELHAJHP, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class KPFPFNBABNB : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct AHABOPLODCP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo OHLFMGDOEEF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type PMAKLIEDFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6B30340", Offset = "0x6B2F140", VA = "0x186B30340")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B30400", Offset = "0x6B2F200", VA = "0x186B30400")]
	public AHABOPLODCP(MemberInfo OHLFMGDOEEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FE30", Offset = "0x6B2EC30", VA = "0x186B2FE30")]
	public object IHLCJELLMHC(object OJGAEOFIMPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B2FF50", Offset = "0x6B2ED50", VA = "0x186B2FF50")]
	public void KFMNCDLPMGL(object OJGAEOFIMPK, object MGFMONLLLPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B300F0", Offset = "0x6B2EEF0", VA = "0x186B300F0")]
	private static bool MEPOKEFFKEJ(Type LCBPDLMNJMD, object MGFMONLLLPD, out object HIEKIDFINFG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum HOBMMCEIAAD
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class BCMKABDKJHP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string JAGOKEMFLBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool BLMLBJNPGOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly HOBMMCEIAAD FKLLKDBMLDL;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B30510", Offset = "0x6B2F310", VA = "0x186B30510")]
	public BCMKABDKJHP([Optional] string ICIEGOLHGJN, HOBMMCEIAAD LEDIIMFEFLP = HOBMMCEIAAD.Experiment, bool AAKIDACJJCF = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class CHMOLJBFLOP : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string JAGOKEMFLBL;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x75C880", Offset = "0x75B680", VA = "0x18075C880")]
	public CHMOLJBFLOP(string ICIEGOLHGJN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BCNMPBBOPDG]
public class MAIHPJPELOB : BDBIOHGAGEF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class KJFNGHPDMOI<TExperiment> where TExperiment : ANODELHAJHP, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public AEOKPAIOCGM statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x1050C80", Offset = "0x104FA80", VA = "0x181050C80")]
		public KJFNGHPDMOI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3009F20", Offset = "0x3008D20", VA = "0x183009F20")]
		internal bool <TryGetExperiment>b__0(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EGOMPDAPKMJ MFDBACLIEPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, ANODELHAJHP> BPMPJKBGIAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, BCMKABDKJHP> IADKGEPKHGG;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B30650", Offset = "0x6B2F450", VA = "0x186B30650")]
	[Preserve]
	public MAIHPJPELOB([NotNull][HDMGOABMPFL(null)] EGOMPDAPKMJ MFDBACLIEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2B34900", Offset = "0x2B33700", VA = "0x182B34900", Slot = "4")]
	public bool EAKHKPOIGPA<TExperiment>(string FIJENMMLADA, out TExperiment BHIPAEPKKHP) where TExperiment : ANODELHAJHP, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6B30600", Offset = "0x6B2F400", VA = "0x186B30600", Slot = "5")]
	public void EEOGKEPJNHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x2B34800", Offset = "0x2B33600", VA = "0x182B34800")]
	private bool EAENOMLKBIA<TExperiment>(out BCMKABDKJHP PGLBDHMCIAL) where TExperiment : ANODELHAJHP
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2B34EE0", Offset = "0x2B33CE0", VA = "0x182B34EE0")]
	private static void IKFKDABDIBE<TExperiment>(TExperiment BHIPAEPKKHP, Func<string, object, object> FMEPEDJFHHB, Predicate<string> JAKICKBPKFI) where TExperiment : ANODELHAJHP
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
