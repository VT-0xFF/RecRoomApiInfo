using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class AJAGFLDNNFO<TData> : JLMPFOOAOBO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GOIENPJADHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AEDKPPANMLD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x772C20", Offset = "0x771A20", VA = "0x180772C20", Slot = "7")]
	public override string BCJNMAHEGJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x37B21A0", Offset = "0x37B0FA0", VA = "0x1837B21A0")]
	internal AJAGFLDNNFO(string KHIFMDJDLEG, [In] TData KNAIEKIJLBC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BELHDMNNAJO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CFE320", Offset = "0x1CFD120", VA = "0x181CFE320")]
	public static AJAGFLDNNFO<CJPHMHJPNKO> FMIHPEHEFKO(string KHIFMDJDLEG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x22A0BB0", Offset = "0x229F9B0", VA = "0x1822A0BB0")]
	public static AJAGFLDNNFO<TData> FMIHPEHEFKO<TData>(string KHIFMDJDLEG, [In] TData KNAIEKIJLBC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LGEEILIBHFI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x255F360", Offset = "0x255E160", VA = "0x18255F360")]
	public static EFFPFBGFCJB<TOk, FCBFPODNPBP> CPMMAMGIGNF<TOk>([In] this EFFPFBGFCJB<TOk, FCBFPODNPBP> HLCOOGAGOEK, string KHIFMDJDLEG)
	{
		return default(EFFPFBGFCJB<TOk, FCBFPODNPBP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JLMPFOOAOBO : MEPLDCOBOII, FCBFPODNPBP, PILBJIJHFMF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CC9610", Offset = "0x1CC8410", VA = "0x181CC9610")]
	protected JLMPFOOAOBO()
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
