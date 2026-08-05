using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PJGIGJIBIKI
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69E96B0", Offset = "0x69E7CB0", VA = "0x1869E96B0")]
	public static KeepsakeTheme HIPDMAIKJLL(this CAKIKEFMFMA FHLJNPENEDC, Guid DPJDOABDAKB)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69E97A0", Offset = "0x69E7DA0", VA = "0x1869E97A0")]
	public static KeepsakeTheme HIPDMAIKJLL(this CAKIKEFMFMA FHLJNPENEDC, BBJPDOGAMDO NDDCHLNNLLP)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69E94E0", Offset = "0x69E7AE0", VA = "0x1869E94E0")]
	public static List<KeepsakeTheme> DGFLGGFFHFI(this CAKIKEFMFMA FHLJNPENEDC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69E9620", Offset = "0x69E7C20", VA = "0x1869E9620")]
	public static BBJPDOGAMDO FAGNJNOJLNN(this CAKIKEFMFMA FHLJNPENEDC, Guid DPJDOABDAKB)
	{
		return default(BBJPDOGAMDO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69E95A0", Offset = "0x69E7BA0", VA = "0x1869E95A0")]
	public static int FACBDNMBKNJ(this CAKIKEFMFMA FHLJNPENEDC, BBJPDOGAMDO OJABMPIOEIM)
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
