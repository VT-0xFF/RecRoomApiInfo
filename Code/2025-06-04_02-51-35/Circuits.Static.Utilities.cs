using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class HANBCIMFOPK<TData> : CNLJJPMFMBN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IGFPALBFAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData KFMKJLCMCLK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA2B650", Offset = "0xA29E50", VA = "0x180A2B650", Slot = "7")]
	public override string JKBFHJHLJNK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4CEEA00", Offset = "0x4CED200", VA = "0x184CEEA00")]
	internal HANBCIMFOPK(string ILBALOOKKCP, [In] TData IMINNNCPCJF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CCFBNLDKFIB
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28F7B90", Offset = "0x28F6390", VA = "0x1828F7B90")]
	public static HANBCIMFOPK<KCHLBHAFJKA> CCPKJDCALBG(string ILBALOOKKCP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x372D440", Offset = "0x372BC40", VA = "0x18372D440")]
	public static HANBCIMFOPK<TData> CCPKJDCALBG<TData>(string ILBALOOKKCP, [In] TData IMINNNCPCJF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KLAJFKHMNHH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3A97320", Offset = "0x3A95B20", VA = "0x183A97320")]
	public static AOGODOAGAAO<TOk, DLBBNMCGCPF> MOJGJHGJMKE<TOk>([In] this AOGODOAGAAO<TOk, DLBBNMCGCPF> DKBBJFIDEGB, string ILBALOOKKCP)
	{
		return default(AOGODOAGAAO<TOk, DLBBNMCGCPF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CNLJJPMFMBN : EMOGOMODAJG, DLBBNMCGCPF, GCGCHICJANP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28B4180", Offset = "0x28B2980", VA = "0x1828B4180")]
	protected CNLJJPMFMBN()
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
