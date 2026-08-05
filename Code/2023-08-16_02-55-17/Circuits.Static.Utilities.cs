using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class IFCPLEGMLKF : EAICBCFAACM, OKKDIBLBODL, NKHHFMGDFFF
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2870DC0", Offset = "0x286FFC0", VA = "0x182870DC0")]
	protected IFCPLEGMLKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class BODHAMNCFMD<TData> : IFCPLEGMLKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GCEJMFHMPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LEHIJMHIJLJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7EBAF0", Offset = "0x7EACF0", VA = "0x1807EBAF0", Slot = "7")]
	public override string MJGKCLCNGHP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E63690", Offset = "0x2E62890", VA = "0x182E63690")]
	internal BODHAMNCFMD(string JPOEHOENKPI, in TData JFGIPFOFKHL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KGKBDNHADLM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F84010", Offset = "0x6F83210", VA = "0x186F84010")]
	public static BODHAMNCFMD<CKDLGNFJNCJ> HBHNAKPOBBF(string JPOEHOENKPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x124A090", Offset = "0x1249290", VA = "0x18124A090")]
	public static BODHAMNCFMD<TData> HBHNAKPOBBF<TData>(string JPOEHOENKPI, in TData JFGIPFOFKHL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IKNBGBBCOCL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D13F60", Offset = "0x1D13160", VA = "0x181D13F60")]
	public static PINPMIPFEPJ<TOk, OKKDIBLBODL> DGFMDOMCDIB<TOk>(this in PINPMIPFEPJ<TOk, OKKDIBLBODL> KPIHKJNPOFH, string JPOEHOENKPI)
	{
		return default(PINPMIPFEPJ<TOk, OKKDIBLBODL>);
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
