using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Keepsakes;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EABKLGGIIBN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65EE460", Offset = "0x65ECC60", VA = "0x1865EE460")]
	public static KeepsakeTheme LBJFDPJKOAO(this HNDFNMJHEPM IBNCKKOJDLP, Guid ELLBCGLMDAA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65EE3C0", Offset = "0x65ECBC0", VA = "0x1865EE3C0")]
	public static KeepsakeTheme LBJFDPJKOAO(this HNDFNMJHEPM IBNCKKOJDLP, HMECHOKOCBB GJGBNMGJOOA)
	{
		return default(KeepsakeTheme);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65EE550", Offset = "0x65ECD50", VA = "0x1865EE550")]
	public static List<KeepsakeTheme> MAHIAECLMGE(this HNDFNMJHEPM IBNCKKOJDLP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65EE330", Offset = "0x65ECB30", VA = "0x1865EE330")]
	public static HMECHOKOCBB GLLMMLIANGK(this HNDFNMJHEPM IBNCKKOJDLP, Guid ELLBCGLMDAA)
	{
		return default(HMECHOKOCBB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65EE2B0", Offset = "0x65ECAB0", VA = "0x1865EE2B0")]
	public static int GFPJJGHMOOP(this HNDFNMJHEPM IBNCKKOJDLP, HMECHOKOCBB CFMKHCBGOII)
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
