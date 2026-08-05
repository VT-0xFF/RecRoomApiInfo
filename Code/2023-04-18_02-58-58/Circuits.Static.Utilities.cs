using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EHHFDMDIKBI<TData> : HODHNINHENI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string AJGKDMIDAJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData OOJPBADIODK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "5")]
	public override string HMHKJMAEDDK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27DBCB0", Offset = "0x27DAEB0", VA = "0x1827DBCB0")]
	internal EHHFDMDIKBI(string OFCFPGACNJB, in TData PCPEJHIMHJJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OLDBIIPDMNM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x681ADF0", Offset = "0x6819FF0", VA = "0x18681ADF0")]
	public static global::EHHFDMDIKBI<MFEHAEMCKCJ> ELCFDEFNBDD(string OFCFPGACNJB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x11514E0", Offset = "0x11506E0", VA = "0x1811514E0")]
	public static global::EHHFDMDIKBI<TData> ELCFDEFNBDD<TData>(string OFCFPGACNJB, in TData PCPEJHIMHJJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class HODHNINHENI : BBMENPGBPEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B50AE0", Offset = "0x2B4FCE0", VA = "0x182B50AE0")]
	protected HODHNINHENI()
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
