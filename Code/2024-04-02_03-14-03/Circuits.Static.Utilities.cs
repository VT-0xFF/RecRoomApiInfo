using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class ALBLJGIPNCM<TData> : PGJMJGCIBHB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NAFGJKMOKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData EIIIJBECKHI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B2D70", Offset = "0x7B1970", VA = "0x1807B2D70", Slot = "7")]
	public override string HJJFPLKFILC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38D9680", Offset = "0x38D8280", VA = "0x1838D9680")]
	internal ALBLJGIPNCM(string COECLHOAJJF, [In] TData KOMCCCIEHEA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MANOCOFCCJG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E4EFA0", Offset = "0x1E4DBA0", VA = "0x181E4EFA0")]
	public static ALBLJGIPNCM<BABPIFEMKHH> CIGBOGDFGOD(string COECLHOAJJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x27C7530", Offset = "0x27C6130", VA = "0x1827C7530")]
	public static ALBLJGIPNCM<TData> CIGBOGDFGOD<TData>(string COECLHOAJJF, [In] TData KOMCCCIEHEA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HGNAGMCFLBE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27F4700", Offset = "0x27F3300", VA = "0x1827F4700")]
	public static DGKNLHNBBJB<TOk, BNLEFJJKIPP> FCNBKBNDGPL<TOk>([In] this DGKNLHNBBJB<TOk, BNLEFJJKIPP> NOLNJDLEMAA, string COECLHOAJJF)
	{
		return default(DGKNLHNBBJB<TOk, BNLEFJJKIPP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PGJMJGCIBHB : PHFFNBEEJOM, BNLEFJJKIPP, JIEDJHBPKDD
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E14650", Offset = "0x1E13250", VA = "0x181E14650")]
	protected PGJMJGCIBHB()
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
