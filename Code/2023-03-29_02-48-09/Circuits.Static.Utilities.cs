using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class JBAJPIEIOKG<TData> : ILGFEOBJLPI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PILDBBJGCAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData JAJACAKHBFD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140", Slot = "5")]
	public override string NKEBKNLNMDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B5DAE0", Offset = "0x3B5C8E0", VA = "0x183B5DAE0")]
	internal JBAJPIEIOKG(string GNDOGDAIOKH, in TData PHAPMEHMHAK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IOPAHJLKFNO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6644910", Offset = "0x6643710", VA = "0x186644910")]
	public static global::JBAJPIEIOKG<BCGDFNNBADB> LBKFKMLCCNN(string GNDOGDAIOKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2289A30", Offset = "0x2288830", VA = "0x182289A30")]
	public static global::JBAJPIEIOKG<TData> LBKFKMLCCNN<TData>(string GNDOGDAIOKH, in TData PHAPMEHMHAK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class ILGFEOBJLPI : CKKOAAAACEJ
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38D4270", Offset = "0x38D3070", VA = "0x1838D4270")]
	protected ILGFEOBJLPI()
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
