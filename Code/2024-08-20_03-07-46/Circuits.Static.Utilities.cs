using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EHEKBAAPBKG<TData> : LPIPGCLHAKC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LOFJHBNFKMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData KHBLMBBNMIA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8517C0", Offset = "0x8507C0", VA = "0x1808517C0", Slot = "7")]
	public override string DODDKOCHLNI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3899D00", Offset = "0x3898D00", VA = "0x183899D00")]
	internal EHEKBAAPBKG(string KKHEHGHPOAA, [In] TData AHGAPHMJDIB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GKKNEDAFLFC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x206FBB0", Offset = "0x206EBB0", VA = "0x18206FBB0")]
	public static EHEKBAAPBKG<OKOMLKNINNF> GAKCNKPJGEK(string KKHEHGHPOAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2995270", Offset = "0x2994270", VA = "0x182995270")]
	public static EHEKBAAPBKG<TData> GAKCNKPJGEK<TData>(string KKHEHGHPOAA, [In] TData AHGAPHMJDIB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MMMPNAEMNNL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2CA8A20", Offset = "0x2CA7A20", VA = "0x182CA8A20")]
	public static DFAHBLOKBPH<TOk, CKBHMJGLAPL> FFAECNBPNOD<TOk>([In] this DFAHBLOKBPH<TOk, CKBHMJGLAPL> KALCJEIICGB, string KKHEHGHPOAA)
	{
		return default(DFAHBLOKBPH<TOk, CKBHMJGLAPL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LPIPGCLHAKC : DNBIAPHIKOM, CKBHMJGLAPL, GFEHMFEELCO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x202F950", Offset = "0x202E950", VA = "0x18202F950")]
	protected LPIPGCLHAKC()
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
