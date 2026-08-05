using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OPDEBGGHCIB<TData> : ECGJNMBGCNE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NBDGJJBCMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AABHDJGOCAI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75C540", Offset = "0x75B940", VA = "0x18075C540", Slot = "7")]
	public override string NKDBAIBOPIJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3D0A3B0", Offset = "0x3D097B0", VA = "0x183D0A3B0")]
	internal OPDEBGGHCIB(string NJKPBIBMIJE, [In] TData GHFAAPNAFDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DDAKOKJMKCO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CA9640", Offset = "0x1CA8A40", VA = "0x181CA9640")]
	public static OPDEBGGHCIB<OGKMPBOGKAG> LJCGEPFBFCG(string NJKPBIBMIJE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21A45B0", Offset = "0x21A39B0", VA = "0x1821A45B0")]
	public static OPDEBGGHCIB<TData> LJCGEPFBFCG<TData>(string NJKPBIBMIJE, [In] TData GHFAAPNAFDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HJOJCJBCHHH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x23A89C0", Offset = "0x23A7DC0", VA = "0x1823A89C0")]
	public static KJFLOMPEKGD<TOk, FILGPPIJBDI> BLDJFPHEGFB<TOk>([In] this KJFLOMPEKGD<TOk, FILGPPIJBDI> LDMHFMNLDHG, string NJKPBIBMIJE)
	{
		return default(KJFLOMPEKGD<TOk, FILGPPIJBDI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ECGJNMBGCNE : ILAPNMDMBPF, FILGPPIJBDI, LPKMENFOOAC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C744D0", Offset = "0x1C738D0", VA = "0x181C744D0")]
	protected ECGJNMBGCNE()
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
