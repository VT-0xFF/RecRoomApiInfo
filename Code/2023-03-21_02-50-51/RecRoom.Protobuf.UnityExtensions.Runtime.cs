using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GAMHDLLBKKE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x65EED10", Offset = "0x65ED510", VA = "0x1865EED10")]
	public static BLHBCHGHBOE ODHIHDMAPDF(this in Color DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65EEBF0", Offset = "0x65ED3F0", VA = "0x1865EEBF0")]
	public static Color JFCMHHFNDFE(this BLHBCHGHBOE DCJNPPINKOA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x65EEC50", Offset = "0x65ED450", VA = "0x1865EEC50")]
	public static Color? LKEBMKJGHOP(this BLHBCHGHBOE DCJNPPINKOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JDGEGDDKJKI
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x65EEEA0", Offset = "0x65ED6A0", VA = "0x1865EEEA0")]
	public static Quaternion MGFPKJKFMLL(KHGGNOALIPL LBEMEOBAAJI)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65EED90", Offset = "0x65ED590", VA = "0x1865EED90")]
	public static AIMELNGGEAN BHLEBLIHECK(Quaternion JIKHBCNCDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x65EEE30", Offset = "0x65ED630", VA = "0x1865EEE30")]
	public static Quaternion KIFDNABHCPG(AIMELNGGEAN LBEMEOBAAJI)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LDADJGBBJCL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x65EF150", Offset = "0x65ED950", VA = "0x1865EF150")]
	public static CFAKNJIJLOB ODHIHDMAPDF(this in Quaternion DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x65EF030", Offset = "0x65ED830", VA = "0x1865EF030")]
	public static Quaternion JFCMHHFNDFE(this CFAKNJIJLOB DCJNPPINKOA)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x65EF090", Offset = "0x65ED890", VA = "0x1865EF090")]
	public static Quaternion? LKEBMKJGHOP(this CFAKNJIJLOB DCJNPPINKOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NLFDNFDANJH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x65EF2B0", Offset = "0x65EDAB0", VA = "0x1865EF2B0")]
	public static AIMELNGGEAN ODHIHDMAPDF(this in Vector3 DCJNPPINKOA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x65EF1D0", Offset = "0x65ED9D0", VA = "0x1865EF1D0")]
	public static Vector3 JFCMHHFNDFE(this AIMELNGGEAN DCJNPPINKOA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65EF220", Offset = "0x65EDA20", VA = "0x1865EF220")]
	public static Vector3? LKEBMKJGHOP(this AIMELNGGEAN DCJNPPINKOA)
	{
		return null;
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
