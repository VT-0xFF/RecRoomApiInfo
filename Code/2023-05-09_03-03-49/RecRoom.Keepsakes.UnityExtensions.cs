using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NPBAOKDHGKM
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E74980", Offset = "0x1E73380", VA = "0x181E74980")]
	public static KeepsakeTheme MNOLGMFDJCI(this FCFLAHCLCOE KONLJOKGCCN, Guid EBLAFADKOLC)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E748E0", Offset = "0x1E732E0", VA = "0x181E748E0")]
	public static KeepsakeTheme MNOLGMFDJCI(this FCFLAHCLCOE KONLJOKGCCN, CJFKFPHLBGA JGADLJIJDED)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E74720", Offset = "0x1E73120", VA = "0x181E74720")]
	public static List<KeepsakeTheme> AEBPABNAIPA(this FCFLAHCLCOE KONLJOKGCCN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E747D0", Offset = "0x1E731D0", VA = "0x181E747D0")]
	public static CJFKFPHLBGA DBGHLDMLACJ(this FCFLAHCLCOE KONLJOKGCCN, Guid EBLAFADKOLC)
	{
		return default(CJFKFPHLBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E74860", Offset = "0x1E73260", VA = "0x181E74860")]
	public static int EFFIFDAKCOF(this FCFLAHCLCOE KONLJOKGCCN, CJFKFPHLBGA KLPICBBCBEB)
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
