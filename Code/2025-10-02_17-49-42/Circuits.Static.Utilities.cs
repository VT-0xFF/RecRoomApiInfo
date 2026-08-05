using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class AAMPAIONJMD<TData> : ICFOIJPFHAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LBGIPDADNFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AMLFHELBNMB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "7")]
	public override string NGBNCIGPFCK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52FE620", Offset = "0x52FD020", VA = "0x1852FE620")]
	internal AAMPAIONJMD(string JEBOHIALEMJ, [In] TData BLPDDGCLNPE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EJCINDLCCBA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BC0DA0", Offset = "0x2BBF7A0", VA = "0x182BC0DA0")]
	public static AAMPAIONJMD<LJBIGLJNMFO> KDBDJPAJKDJ(string JEBOHIALEMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E30", Offset = "0x32D0830", VA = "0x1832D1E30")]
	public static AAMPAIONJMD<TData> KDBDJPAJKDJ<TData>(string JEBOHIALEMJ, [In] TData BLPDDGCLNPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HPBLMPBOPJD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DDAF70", Offset = "0x3DD9970", VA = "0x183DDAF70")]
	public static FEENKEDBOAD<TOk, DDLDMBFFDDA> FNONCBAONEP<TOk>([In] this FEENKEDBOAD<TOk, DDLDMBFFDDA> DKGBCFDLMOI, string JEBOHIALEMJ)
	{
		return default(FEENKEDBOAD<TOk, DDLDMBFFDDA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ICFOIJPFHAE : EFLAGBIEFMN, DDLDMBFFDDA, NKNFPHMKKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B87EB0", Offset = "0x2B868B0", VA = "0x182B87EB0")]
	protected ICFOIJPFHAE()
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
