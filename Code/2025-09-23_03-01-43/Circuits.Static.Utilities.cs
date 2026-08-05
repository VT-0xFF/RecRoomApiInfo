using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class GAOMCLNPMBC<TData> : MMOOADNOMBF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string ADPDLDMDHJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData BJOBNNFAMFI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xAA5390", Offset = "0xAA3990", VA = "0x180AA5390", Slot = "7")]
	public override string GAEFJPMCOGL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x50AC1C0", Offset = "0x50AA7C0", VA = "0x1850AC1C0")]
	internal GAOMCLNPMBC(string GKNICJPCIJJ, [In] TData CDDIADBJAOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MGMHLKHJLMN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2BBED40", Offset = "0x2BBD340", VA = "0x182BBED40")]
	public static GAOMCLNPMBC<IHJGGHCFJKD> CPNHECDILPK(string GKNICJPCIJJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x330B660", Offset = "0x3309C60", VA = "0x18330B660")]
	public static GAOMCLNPMBC<TData> CPNHECDILPK<TData>(string GKNICJPCIJJ, [In] TData CDDIADBJAOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BFJGIIELHAI
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3B601E0", Offset = "0x3B5E7E0", VA = "0x183B601E0")]
	public static CKPAOGHIJHA<TOk, HCKLGFJODKO> LJCOAEBNGND<TOk>([In] this CKPAOGHIJHA<TOk, HCKLGFJODKO> JNMMMBJNOND, string GKNICJPCIJJ)
	{
		return default(CKPAOGHIJHA<TOk, HCKLGFJODKO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MMOOADNOMBF : OJGPKPIMJAI, HCKLGFJODKO, EHNKGHFFBGH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B85CC0", Offset = "0x2B842C0", VA = "0x182B85CC0")]
	protected MMOOADNOMBF()
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
