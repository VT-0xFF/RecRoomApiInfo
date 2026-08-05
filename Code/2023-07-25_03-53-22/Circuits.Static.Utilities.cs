using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class FNPAPHHOPJD : JINHIJEHMKF, BINCKAOMJCF, FAFNPLJEJLD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x332E080", Offset = "0x332D080", VA = "0x18332E080")]
	protected FNPAPHHOPJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class FOCBGMBFGPB<TData> : FNPAPHHOPJD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KNGLFOPMCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData ILJIPNHLBGB;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x913300", Offset = "0x912300", VA = "0x180913300", Slot = "7")]
	public override string PHAGEMDPKEM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3550D80", Offset = "0x354FD80", VA = "0x183550D80")]
	internal FOCBGMBFGPB(string HJJLMCEMDKN, in TData HHCEHFFEAKN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HCDFHHPNFIO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x730FD50", Offset = "0x730ED50", VA = "0x18730FD50")]
	public static FOCBGMBFGPB<MPPFCKMNLHP> DAABCIFNKOF(string HJJLMCEMDKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1073F90", Offset = "0x1072F90", VA = "0x181073F90")]
	public static FOCBGMBFGPB<TData> DAABCIFNKOF<TData>(string HJJLMCEMDKN, in TData HHCEHFFEAKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MNKOEEPKHGI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x16EBE70", Offset = "0x16EAE70", VA = "0x1816EBE70")]
	public static EEONHCOMEMH<TOk, BINCKAOMJCF> CNBMHOAHAII<TOk>(this in EEONHCOMEMH<TOk, BINCKAOMJCF> FKGCCPKFEDE, string HJJLMCEMDKN)
	{
		return default(EEONHCOMEMH<TOk, BINCKAOMJCF>);
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
