using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class EJGLEHOMCMJ : CMPFHAIKIAN, HECNFFAEBGF, NKLELKIHOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x118FE10", Offset = "0x118E610", VA = "0x18118FE10")]
	protected EJGLEHOMCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class HKKGCGLBBBM<TData> : EJGLEHOMCMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LPOICJAAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PFNMBPHLPKL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8117F0", Offset = "0x80FFF0", VA = "0x1808117F0", Slot = "7")]
	public override string AFLBGGMHEAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3585FD0", Offset = "0x35847D0", VA = "0x183585FD0")]
	internal HKKGCGLBBBM(string DKIECHCHJFL, in TData PHBHEFAPHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KDLLFLDGMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1694540", Offset = "0x1692D40", VA = "0x181694540")]
	public static global::HKKGCGLBBBM<DPIJIKFEAOC> DOBPLOGGNLM(string DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x240F350", Offset = "0x240DB50", VA = "0x18240F350")]
	public static global::HKKGCGLBBBM<TData> DOBPLOGGNLM<TData>(string DKIECHCHJFL, in TData PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HNNGMBNHCPE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2DDD4C0", Offset = "0x2DDBCC0", VA = "0x182DDD4C0")]
	public static global::PKJAENHCLMN<TOk, HECNFFAEBGF> ADJBJGGGIDL<TOk>(this in global::PKJAENHCLMN<TOk, HECNFFAEBGF> GPOCLJBKMHA, string DKIECHCHJFL)
	{
		return default(global::PKJAENHCLMN<TOk, HECNFFAEBGF>);
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
