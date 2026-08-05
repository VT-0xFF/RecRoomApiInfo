using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct ELAAAIMGMOE
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8319230", Offset = "0x8317C30", VA = "0x188319230")]
	public static ELAAAIMGMOE LHJBCIIELME(MEBJEIOEDLD HJHMNJLNNBM)
	{
		return default(ELAAAIMGMOE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8319250", Offset = "0x8317C50", VA = "0x188319250")]
	public ELAAAIMGMOE(MEBJEIOEDLD HJHMNJLNNBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8319170", Offset = "0x8317B70", VA = "0x188319170")]
	public void IJNANOIGCCM([In] FixedString128Bytes OJCMLFFIJFF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LDNACAHPMDK
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8319230", Offset = "0x8317C30", VA = "0x188319230")]
	public static ELAAAIMGMOE NPJADFLPDOJ(this MEBJEIOEDLD HJHMNJLNNBM)
	{
		return default(ELAAAIMGMOE);
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
