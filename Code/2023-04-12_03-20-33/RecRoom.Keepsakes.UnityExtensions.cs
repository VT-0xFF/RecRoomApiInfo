using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DHLJPHJDOOM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6729060", Offset = "0x6728460", VA = "0x186729060")]
	public static KeepsakeTheme OLEPLMIOBPB(this FDNDICKDGCJ CBBILOOJOAK, Guid HJMKLGECFPL)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6728FC0", Offset = "0x67283C0", VA = "0x186728FC0")]
	public static KeepsakeTheme OLEPLMIOBPB(this FDNDICKDGCJ CBBILOOJOAK, FBNLAPOEIEP OLLINLFPDIK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6728E00", Offset = "0x6728200", VA = "0x186728E00")]
	public static List<KeepsakeTheme> ACHDIPOIGEE(this FDNDICKDGCJ CBBILOOJOAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6728EB0", Offset = "0x67282B0", VA = "0x186728EB0")]
	public static FBNLAPOEIEP BDIODBDEKNH(this FDNDICKDGCJ CBBILOOJOAK, Guid HJMKLGECFPL)
	{
		return default(FBNLAPOEIEP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6728F40", Offset = "0x6728340", VA = "0x186728F40")]
	public static int FAEIFIIHGLD(this FDNDICKDGCJ CBBILOOJOAK, FBNLAPOEIEP PDABEOHHMMM)
	{
		return default(int);
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
