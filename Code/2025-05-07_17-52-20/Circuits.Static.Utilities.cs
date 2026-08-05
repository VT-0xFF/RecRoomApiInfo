using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IPHGCHBBCBB<TData> : CNPJDFNBLHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LNILHMKIEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData HCNIDPKECHH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C12770", Offset = "0x4C11770", VA = "0x184C12770")]
	internal IPHGCHBBCBB(string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class APKFCIFIEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2803B40", Offset = "0x2802B40", VA = "0x182803B40")]
	public static IPHGCHBBCBB<BONGKMFJEJA> ACADPGMDEBE(string NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36E6230", Offset = "0x36E5230", VA = "0x1836E6230")]
	public static IPHGCHBBCBB<TData> ACADPGMDEBE<TData>(string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LLLPBNFCLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x38F9430", Offset = "0x38F8430", VA = "0x1838F9430")]
	public static HHHCCNLMPJL<TOk, DLKBDBKHJCC> JOCONHDFLPL<TOk>([In] this HHHCCNLMPJL<TOk, DLKBDBKHJCC> OCACDKEJIIB, string NAAMEAFIHJI)
	{
		return default(HHHCCNLMPJL<TOk, DLKBDBKHJCC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CNPJDFNBLHN : OGMCLKGLBPG, DLKBDBKHJCC, HIKDGBNCNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27BE9F0", Offset = "0x27BD9F0", VA = "0x1827BE9F0")]
	protected CNPJDFNBLHN()
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
