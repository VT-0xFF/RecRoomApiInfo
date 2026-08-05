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
[BBAJOPPGPEF]
public class AKKIJCLNHHO : EBAPCFGMFKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private readonly BNGGLPJBEEF HKOMEKNDPHN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21D9F10", Offset = "0x21D8D10", VA = "0x1821D9F10")]
	[Preserve]
	public AKKIJCLNHHO([NotNull][NOAEAKEJBMN(null)] BNGGLPJBEEF HKOMEKNDPHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4317380", Offset = "0x4316180", VA = "0x184317380", Slot = "4")]
	public bool MJBFBMHFOMF<TExperiment>(string MBCMPIMPJHN, out TExperiment AKFPALACKAO) where TExperiment : EOAJNCFAAKA, new()
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EOAJNCFAAKA
{
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface BNGGLPJBEEF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJBFBMHFOMF<TExperiment>(string MBCMPIMPJHN, out TExperiment AKFPALACKAO) where TExperiment : EOAJNCFAAKA, new();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void BGNCGBEGFOM();
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface EBAPCFGMFKI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool MJBFBMHFOMF<TExperiment>(string MBCMPIMPJHN, out TExperiment AKFPALACKAO) where TExperiment : EOAJNCFAAKA, new();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[AttributeUsage(AttributeTargets.Field)]
public class NNEKAIEDMCC : Attribute
{
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
internal readonly struct AILMKLPIIDP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private readonly MemberInfo HAEDECLGENH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public Type JMHPJEDLBJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21D9D40", Offset = "0x21D8B40", VA = "0x1821D9D40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x21D9E00", Offset = "0x21D8C00", VA = "0x1821D9E00")]
	public AILMKLPIIDP(MemberInfo HAEDECLGENH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x21D9C20", Offset = "0x21D8A20", VA = "0x1821D9C20")]
	public object JEIOEOGODCD(object LOPIEGGIDMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x21D9A80", Offset = "0x21D8880", VA = "0x1821D9A80")]
	public void HKGFAOHKACC(object LOPIEGGIDMF, object DPJGMDFEIDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x21D9830", Offset = "0x21D8630", VA = "0x1821D9830")]
	private static bool BHENIMELBMG(Type EOGKEMHBEFL, object DPJGMDFEIDL, out object OIPGECHMGGH)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public enum AOMBMEEOBJO
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	Experiment,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	Layer
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct)]
public class LPCMKBJHJEH : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	public readonly string JBOBPFKLKJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	public readonly bool LJNDNINNFBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public readonly AOMBMEEOBJO FCBCFKMJLMK;

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x21D9FA0", Offset = "0x21D8DA0", VA = "0x1821D9FA0")]
	public LPCMKBJHJEH([Optional] string CCEKFDNIAPD, AOMBMEEOBJO LAKBKKJKBPK = AOMBMEEOBJO.Experiment, bool LNFCAELAECO = true)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
public class PBBIGLEMNBF : Attribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	public readonly string JBOBPFKLKJA;

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F7FC0", Offset = "0x9F6DC0", VA = "0x1809F7FC0")]
	public PBBIGLEMNBF(string CCEKFDNIAPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
[BBAJOPPGPEF]
public class OLALPECHEPK : BNGGLPJBEEF
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class GKLOIALCPKP<TExperiment> where TExperiment : EOAJNCFAAKA, new()
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public bool useLayerDefaults;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public ACJEAEDKEIH statsigExperiment;

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x22E6440", Offset = "0x22E5240", VA = "0x1822E6440")]
		public GKLOIALCPKP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x421E840", Offset = "0x421D640", VA = "0x18421E840")]
		internal bool <TryGetExperiment>b__0(string parameterName)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly EFNPGJMKAFL GIFBFKKJDJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly Dictionary<string, EOAJNCFAAKA> LGLIDAGKBBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly Dictionary<Type, LPCMKBJHJEH> BDFEHODEHII;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21DA050", Offset = "0x21D8E50", VA = "0x1821DA050")]
	[Preserve]
	public OLALPECHEPK([NotNull][NOAEAKEJBMN(null)] EFNPGJMKAFL GIFBFKKJDJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x36885B0", Offset = "0x36873B0", VA = "0x1836885B0", Slot = "4")]
	public bool MJBFBMHFOMF<TExperiment>(string MBCMPIMPJHN, out TExperiment AKFPALACKAO) where TExperiment : EOAJNCFAAKA, new()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21DA000", Offset = "0x21D8E00", VA = "0x1821DA000", Slot = "5")]
	public void BGNCGBEGFOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x36884B0", Offset = "0x36872B0", VA = "0x1836884B0")]
	private bool GDGAIEAJDLE<TExperiment>(out LPCMKBJHJEH CDAKDMPCCAN) where TExperiment : EOAJNCFAAKA
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3688110", Offset = "0x3686F10", VA = "0x183688110")]
	private static void ABNILPKODGG<TExperiment>(TExperiment AKFPALACKAO, Func<string, object, object> AHFOAAOPJKK, Predicate<string> OJMKEDDBGNB) where TExperiment : EOAJNCFAAKA
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
