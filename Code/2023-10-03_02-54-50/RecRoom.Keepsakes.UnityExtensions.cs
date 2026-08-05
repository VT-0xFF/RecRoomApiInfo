using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GCJBOCIAMNA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5A00", Offset = "0x5CC4200", VA = "0x185CC5A00")]
	public static KeepsakeTheme BEPBDLAKAPH(this ADFHGHMLBHI FMEPDACEHFM, Guid KNBGMNMIJEJ)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5950", Offset = "0x5CC4150", VA = "0x185CC5950")]
	public static KeepsakeTheme BEPBDLAKAPH(this ADFHGHMLBHI FMEPDACEHFM, NJFKBBPNNAP HBLMAAAEOLN)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5890", Offset = "0x5CC4090", VA = "0x185CC5890")]
	public static List<KeepsakeTheme> AGMGLPCDLPH(this ADFHGHMLBHI FMEPDACEHFM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5AF0", Offset = "0x5CC42F0", VA = "0x185CC5AF0")]
	public static NJFKBBPNNAP LJIPNLPCAGH(this ADFHGHMLBHI FMEPDACEHFM, Guid KNBGMNMIJEJ)
	{
		return default(NJFKBBPNNAP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5CC5B80", Offset = "0x5CC4380", VA = "0x185CC5B80")]
	public static int OPGHFMHBDDD(this ADFHGHMLBHI FMEPDACEHFM, NJFKBBPNNAP DJPOOJOPCCK)
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
