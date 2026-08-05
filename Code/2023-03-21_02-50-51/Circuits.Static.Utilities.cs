using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class AHCNBICPNOD<TData> : IOEHGADFNAP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LCDDHGNOMGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GDEADNDOKHO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D50C0", Offset = "0x6D38C0", VA = "0x1806D50C0", Slot = "5")]
	public override string NNBNGPPOEHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x33B1EC0", Offset = "0x33B06C0", VA = "0x1833B1EC0")]
	internal AHCNBICPNOD(string EPAIMCEIMPA, in TData LBEMEOBAAJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AKFMNMCDPDL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xEA2040", Offset = "0xEA0840", VA = "0x180EA2040")]
	public static global::AHCNBICPNOD<HKDLOMPDCOH> HHEHBEMBBBF(string EPAIMCEIMPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x17F2D90", Offset = "0x17F1590", VA = "0x1817F2D90")]
	public static global::AHCNBICPNOD<TData> HHEHBEMBBBF<TData>(string EPAIMCEIMPA, in TData LBEMEOBAAJI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class IOEHGADFNAP : JGDNADHAHMP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEA20B0", Offset = "0xEA08B0", VA = "0x180EA20B0")]
	protected IOEHGADFNAP()
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
