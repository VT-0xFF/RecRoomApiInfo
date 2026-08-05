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
	[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "7")]
	public override string JJNMHFCAPPI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C46C30", Offset = "0x4C45230", VA = "0x184C46C30")]
	internal IPHGCHBBCBB(string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class APKFCIFIEPA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2802230", Offset = "0x2800830", VA = "0x182802230")]
	public static IPHGCHBBCBB<BONGKMFJEJA> ACADPGMDEBE(string NAAMEAFIHJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x37041B0", Offset = "0x37027B0", VA = "0x1837041B0")]
	public static IPHGCHBBCBB<TData> ACADPGMDEBE<TData>(string NAAMEAFIHJI, [In] TData APDBNIMCPID)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LLLPBNFCLMA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3917640", Offset = "0x3915C40", VA = "0x183917640")]
	public static HHHCCNLMPJL<TOk, DLKBDBKHJCC> JOCONHDFLPL<TOk>([In] this HHHCCNLMPJL<TOk, DLKBDBKHJCC> OCACDKEJIIB, string NAAMEAFIHJI)
	{
		return default(HHHCCNLMPJL<TOk, DLKBDBKHJCC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CNPJDFNBLHN : OGMCLKGLBPG, DLKBDBKHJCC, HIKDGBNCNDJ
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27BF0A0", Offset = "0x27BD6A0", VA = "0x1827BF0A0")]
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
