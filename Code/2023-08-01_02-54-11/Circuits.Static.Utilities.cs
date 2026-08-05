using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class FBIODNBOINH : NEMFMBIHPEH, OODLLKGHJOL, DKBPBKPNJPD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3395AC0", Offset = "0x3394AC0", VA = "0x183395AC0")]
	protected FBIODNBOINH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class LMNIPPJMHLL<TData> : FBIODNBOINH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PMGHLPAOJEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData KBOOCNEMIKC;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x927DF0", Offset = "0x926DF0", VA = "0x180927DF0", Slot = "7")]
	public override string OCMKCNKAONG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x24BAF80", Offset = "0x24B9F80", VA = "0x1824BAF80")]
	internal LMNIPPJMHLL(string FANKIHBOOPE, in TData HCKNMLENIIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MKCBGADIIHD
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72D17F0", Offset = "0x72D07F0", VA = "0x1872D17F0")]
	public static LMNIPPJMHLL<OKHGFHBPFAA> CECGBIGMPDN(string FANKIHBOOPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1169240", Offset = "0x1168240", VA = "0x181169240")]
	public static LMNIPPJMHLL<TData> CECGBIGMPDN<TData>(string FANKIHBOOPE, in TData HCKNMLENIIG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IAJACLEJALA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1893050", Offset = "0x1892050", VA = "0x181893050")]
	public static ADCOJCAAGFK<TOk, OODLLKGHJOL> LLIDHDELFMN<TOk>(this in ADCOJCAAGFK<TOk, OODLLKGHJOL> DPHICODLGJD, string FANKIHBOOPE)
	{
		return default(ADCOJCAAGFK<TOk, OODLLKGHJOL>);
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
