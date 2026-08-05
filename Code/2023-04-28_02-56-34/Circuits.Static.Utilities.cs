using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LFKLGPEJPNI<TData> : GGEPPPFEGHD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KKGDNEGJOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CNDFKFGJPCE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "5")]
	public override string GMMLNCMCCAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x39CF310", Offset = "0x39CDD10", VA = "0x1839CF310")]
	internal LFKLGPEJPNI(string BALNMHDNCIN, in TData HIDEHJGLNHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KJOBPHLJJLJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A21E60", Offset = "0x6A20860", VA = "0x186A21E60")]
	public static global::LFKLGPEJPNI<JAPIHNFIDBB> GILBACJLDCL(string BALNMHDNCIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x10F6530", Offset = "0x10F4F30", VA = "0x1810F6530")]
	public static global::LFKLGPEJPNI<TData> GILBACJLDCL<TData>(string BALNMHDNCIN, in TData HIDEHJGLNHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class GGEPPPFEGHD : KFANFMGGLGP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C77BB0", Offset = "0x2C765B0", VA = "0x182C77BB0")]
	protected GGEPPPFEGHD()
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
