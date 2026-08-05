using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class HCGGKOEMGBM : OMNBHFGADPA, NADLJLPONBH, FJCGAAAECJI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3380B10", Offset = "0x337FF10", VA = "0x183380B10")]
	protected HCGGKOEMGBM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DIGBFABFJIO<TData> : HCGGKOEMGBM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GDLOACHAOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData MLLMENDGMLJ;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x823C00", Offset = "0x823000", VA = "0x180823C00", Slot = "7")]
	public override string NBKNGDNHDKI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21E0430", Offset = "0x21DF830", VA = "0x1821E0430")]
	internal DIGBFABFJIO(string FHDJIGKOLJM, in TData CLCAIFLMLCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HNMLFKEDJBB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x72373F0", Offset = "0x72367F0", VA = "0x1872373F0")]
	public static DIGBFABFJIO<PNGLJAGHHDL> NAILOIKCJEC(string FHDJIGKOLJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x164DD50", Offset = "0x164D150", VA = "0x18164DD50")]
	public static DIGBFABFJIO<TData> NAILOIKCJEC<TData>(string FHDJIGKOLJM, in TData CLCAIFLMLCJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PGIJPEKHEHC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x322FE30", Offset = "0x322F230", VA = "0x18322FE30")]
	public static ADOGIEMPLPD<TOk, NADLJLPONBH> GCHIJKDOLCJ<TOk>(this in ADOGIEMPLPD<TOk, NADLJLPONBH> ODBHDBFBMOB, string FHDJIGKOLJM)
	{
		return default(ADOGIEMPLPD<TOk, NADLJLPONBH>);
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
