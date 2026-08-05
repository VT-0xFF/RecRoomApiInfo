using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NKJLOFBEJGN<TData> : PEOIGJADBLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string MIMBNBKAENG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData NABFHNKLBGG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C5D40", Offset = "0x6C4B40", VA = "0x1806C5D40", Slot = "5")]
	public override string CFFNHDCOJGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x395DEB0", Offset = "0x395CCB0", VA = "0x18395DEB0")]
	internal NKJLOFBEJGN(string IACFBMPPCKF, in TData CPLKBCGCHAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EPKJCIMLKKN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21E7420", Offset = "0x21E6220", VA = "0x1821E7420")]
	public static global::NKJLOFBEJGN<PDIIEEBMKOH> PKGIDMHJGMJ(string IACFBMPPCKF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class PEOIGJADBLL : GCOFNEOKNEG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21B8D30", Offset = "0x21B7B30", VA = "0x1821B8D30")]
	protected PEOIGJADBLL()
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
