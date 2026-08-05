using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FGHOCNKJDNA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84B7820", Offset = "0x84B5E20", VA = "0x1884B7820")]
	public static KeepsakeTheme PNNLFIJOLAJ(this PDHFEEGOKIK BIAJFLEJGFD, Guid HMLPHLNLMFM)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x84B7760", Offset = "0x84B5D60", VA = "0x1884B7760")]
	public static KeepsakeTheme PNNLFIJOLAJ(this PDHFEEGOKIK BIAJFLEJGFD, FHPPEAFCOMD HDPLGPAMIDO)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x84B7690", Offset = "0x84B5C90", VA = "0x1884B7690")]
	public static List<KeepsakeTheme> PFMNGMJBHGC(this PDHFEEGOKIK BIAJFLEJGFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x84B7560", Offset = "0x84B5B60", VA = "0x1884B7560")]
	public static FHPPEAFCOMD BBKILCMACIE(this PDHFEEGOKIK BIAJFLEJGFD, Guid HMLPHLNLMFM)
	{
		return default(FHPPEAFCOMD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x84B7600", Offset = "0x84B5C00", VA = "0x1884B7600")]
	public static int LJHFICFEBOE(this PDHFEEGOKIK BIAJFLEJGFD, FHPPEAFCOMD HMJOAIAPIPB)
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
