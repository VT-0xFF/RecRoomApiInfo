using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NBADJEGDFCG<TData> : DMCEODOALNN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LDKJFCNOLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData OCEAHOAJAAG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA00BA0", Offset = "0x9FFDA0", VA = "0x180A00BA0", Slot = "7")]
	public override string AHCNILBBCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x54709C0", Offset = "0x546FBC0", VA = "0x1854709C0")]
	internal NBADJEGDFCG(string NPEJLHCJPAI, [In] TData CAIGHLKIDBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JIGOIFJJGEG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2912FE0", Offset = "0x29121E0", VA = "0x182912FE0")]
	public static NBADJEGDFCG<LMEKHMKKIDI> FAHGDJGLLGD(string NPEJLHCJPAI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2FADC80", Offset = "0x2FACE80", VA = "0x182FADC80")]
	public static NBADJEGDFCG<TData> FAHGDJGLLGD<TData>(string NPEJLHCJPAI, [In] TData CAIGHLKIDBF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OEOBCNONNJM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3BA01B0", Offset = "0x3B9F3B0", VA = "0x183BA01B0")]
	public static DJNAMIFBMIO<TOk, FMHHFFBAGLO> JIMCAGAEBFG<TOk>([In] this DJNAMIFBMIO<TOk, FMHHFFBAGLO> IPOCHJJJBCM, string NPEJLHCJPAI)
	{
		return default(DJNAMIFBMIO<TOk, FMHHFFBAGLO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DMCEODOALNN : DCJPFEGHGPF, FMHHFFBAGLO, JNEBIKAJDEN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x28CEDD0", Offset = "0x28CDFD0", VA = "0x1828CEDD0")]
	protected DMCEODOALNN()
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
