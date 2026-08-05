using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class LCEIFOGDJKI : EHBJJIMENLO, EACFJIDFNJL, DELOHBKGNFD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x11ECDE0", Offset = "0x11EC1E0", VA = "0x1811ECDE0")]
	protected LCEIFOGDJKI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DLGOIOGLNBD<TData> : LCEIFOGDJKI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string BEPGAKMEDEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AHCBKPNFDAA;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8117E0", Offset = "0x810BE0", VA = "0x1808117E0", Slot = "7")]
	public override string FGDMEHNLDAL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3C0C8D0", Offset = "0x3C0BCD0", VA = "0x183C0C8D0")]
	internal DLGOIOGLNBD(string HGJOENLBDNH, in TData KOCKBILIHNN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KCPBPIIHLBL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1714A30", Offset = "0x1713E30", VA = "0x181714A30")]
	public static global::DLGOIOGLNBD<CPKDLGGKAMN> FHHJOGLDILM(string HGJOENLBDNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A4C7C0", Offset = "0x1A4BBC0", VA = "0x181A4C7C0")]
	public static global::DLGOIOGLNBD<TData> FHHJOGLDILM<TData>(string HGJOENLBDNH, in TData KOCKBILIHNN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCLMACJHHEF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2CEB890", Offset = "0x2CEAC90", VA = "0x182CEB890")]
	public static global::EJIEKPGJGCC<TOk, EACFJIDFNJL> BFNICOEEFLK<TOk>(this in global::EJIEKPGJGCC<TOk, EACFJIDFNJL> LGKAJJKAMAG, string HGJOENLBDNH)
	{
		return default(global::EJIEKPGJGCC<TOk, EACFJIDFNJL>);
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
