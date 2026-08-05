using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BHEEKGOENLD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D93D10", Offset = "0x6D93110", VA = "0x186D93D10")]
	public static KeepsakeTheme OALKGDACFDK(this ODEEFHDECLP EGAKDMHOMDJ, Guid PLOIFBAPGKK)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D93C60", Offset = "0x6D93060", VA = "0x186D93C60")]
	public static KeepsakeTheme OALKGDACFDK(this ODEEFHDECLP EGAKDMHOMDJ, MKNCOJELGGF AJPKGDJDBIE)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D93AF0", Offset = "0x6D92EF0", VA = "0x186D93AF0")]
	public static List<KeepsakeTheme> CGEGEPDENDD(this ODEEFHDECLP EGAKDMHOMDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D93BC0", Offset = "0x6D92FC0", VA = "0x186D93BC0")]
	public static MKNCOJELGGF NDLNMKFJCII(this ODEEFHDECLP EGAKDMHOMDJ, Guid PLOIFBAPGKK)
	{
		return default(MKNCOJELGGF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D93A60", Offset = "0x6D92E60", VA = "0x186D93A60")]
	public static int ALGKLFDAHMN(this ODEEFHDECLP EGAKDMHOMDJ, MKNCOJELGGF BLPMHNAODAE)
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
