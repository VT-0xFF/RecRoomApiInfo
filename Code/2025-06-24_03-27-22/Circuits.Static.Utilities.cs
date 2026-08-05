using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MBEJEKJEAIG<TData> : AJHEICOHAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MEEMMPNFCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PBCJADGOGBF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0", Slot = "7")]
	public override string NEEGIDJCGEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x549B140", Offset = "0x5499D40", VA = "0x18549B140")]
	internal MBEJEKJEAIG(string FNFIPKNHEOF, [In] TData PEDMEJIDLNB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FKAEFMMPBOE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2998600", Offset = "0x2997200", VA = "0x182998600")]
	public static MBEJEKJEAIG<BOFEABKGBFC> JHMOIFLKJAD(string FNFIPKNHEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3834080", Offset = "0x3832C80", VA = "0x183834080")]
	public static MBEJEKJEAIG<TData> JHMOIFLKJAD<TData>(string FNFIPKNHEOF, [In] TData PEDMEJIDLNB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JJBEPBDBEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B25EE0", Offset = "0x3B24AE0", VA = "0x183B25EE0")]
	public static MDDPJNIIBBI<TOk, JHFNBJHGPJG> CCGBNHLCGPM<TOk>([In] this MDDPJNIIBBI<TOk, JHFNBJHGPJG> LAAPKLDJLPE, string FNFIPKNHEOF)
	{
		return default(MDDPJNIIBBI<TOk, JHFNBJHGPJG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class AJHEICOHAGC : OGEAAGEPEFJ, JHFNBJHGPJG, EFKBKOGFPPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29543D0", Offset = "0x2952FD0", VA = "0x1829543D0")]
	protected AJHEICOHAGC()
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
