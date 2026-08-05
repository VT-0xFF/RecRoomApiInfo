using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EIOIGMJHGJL<TData> : JLINDJLDKOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LIEABGFDIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LMIMGNACAMD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8A89C0", Offset = "0x8A7DC0", VA = "0x1808A89C0", Slot = "7")]
	public override string AHEFLPEKLMA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3B7D290", Offset = "0x3B7C690", VA = "0x183B7D290")]
	internal EIOIGMJHGJL(string MOKGCFCFCPE, [In] TData AIKOCCMKKAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class ICAMPLKCKPE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22904D0", Offset = "0x228F8D0", VA = "0x1822904D0")]
	public static EIOIGMJHGJL<IOADHBFKJOJ> AHLALEPNKFA(string MOKGCFCFCPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C63150", Offset = "0x2C62550", VA = "0x182C63150")]
	public static EIOIGMJHGJL<TData> AHLALEPNKFA<TData>(string MOKGCFCFCPE, [In] TData AIKOCCMKKAE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IIIMBLDEGCD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E94100", Offset = "0x2E93500", VA = "0x182E94100")]
	public static LMFFMMPMNDB<TOk, FOPCNMINEGF> KKNPDKBJKON<TOk>([In] this LMFFMMPMNDB<TOk, FOPCNMINEGF> MCPMOAEEEOJ, string MOKGCFCFCPE)
	{
		return default(LMFFMMPMNDB<TOk, FOPCNMINEGF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JLINDJLDKOH : CIIOJBGFHGE, FOPCNMINEGF, HGFLKMEKLGL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22515F0", Offset = "0x22509F0", VA = "0x1822515F0")]
	protected JLINDJLDKOH()
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
