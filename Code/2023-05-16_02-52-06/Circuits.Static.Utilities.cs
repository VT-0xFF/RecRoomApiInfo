using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MMOGBDECHDI<TData> : LGBLFKJLIPF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GNOMDKEMEAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData BPHPMBBMNOF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7400C0", Offset = "0x73EEC0", VA = "0x1807400C0", Slot = "7")]
	public override string HKMFFLPHOOE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x30D8C70", Offset = "0x30D7A70", VA = "0x1830D8C70")]
	internal MMOGBDECHDI(string GPAOLHFLBHD, in TData MMJOHADFCHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GOGHOMILKGC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xF0C990", Offset = "0xF0B790", VA = "0x180F0C990")]
	public static global::MMOGBDECHDI<JCKJOPOBLHO> AIJMFKKLHCC(string GPAOLHFLBHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x16423D0", Offset = "0x16411D0", VA = "0x1816423D0")]
	public static global::MMOGBDECHDI<TData> AIJMFKKLHCC<TData>(string GPAOLHFLBHD, in TData MMJOHADFCHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GHBPBOJBKBK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x208F160", Offset = "0x208DF60", VA = "0x18208F160")]
	public static global::AEGPCPFJGKN<TOk, MKFDOIHNKMJ> LEDNNOGCGGN<TOk>(this in global::AEGPCPFJGKN<TOk, MKFDOIHNKMJ> LCNEHOGIJPK, string GPAOLHFLBHD)
	{
		return default(global::AEGPCPFJGKN<TOk, MKFDOIHNKMJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LGBLFKJLIPF : MDPLBPNGKPK, MKFDOIHNKMJ, CBJABNKIELI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xF0CA00", Offset = "0xF0B800", VA = "0x180F0CA00")]
	protected LGBLFKJLIPF()
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
