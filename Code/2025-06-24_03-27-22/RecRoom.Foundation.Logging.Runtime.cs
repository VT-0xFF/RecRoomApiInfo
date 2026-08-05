using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Unity.Collections;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct DEJMFKCDBKG
{
	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE310", Offset = "0x7DDCF10", VA = "0x187DDE310")]
	public static DEJMFKCDBKG GHOKLFELACP(JPIBGNDAFKP FAOMHPPHFKM)
	{
		return default(DEJMFKCDBKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE330", Offset = "0x7DDCF30", VA = "0x187DDE330")]
	public DEJMFKCDBKG(JPIBGNDAFKP FAOMHPPHFKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE250", Offset = "0x7DDCE50", VA = "0x187DDE250")]
	public void BOJGMFDJNPA([In] FixedString128Bytes KMCLKBGAPBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PHANKMOMPEB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7DDE310", Offset = "0x7DDCF10", VA = "0x187DDE310")]
	public static DEJMFKCDBKG NHJIMFHDKMO(this JPIBGNDAFKP FAOMHPPHFKM)
	{
		return default(DEJMFKCDBKG);
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
