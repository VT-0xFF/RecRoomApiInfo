using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BHOBMEAADJO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum FNLMECCNNJH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Off,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		SwitchBetweenCurrentToolAndEraser,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		SwitchBetweenCurrentToolAndLastUsed,
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		ShowColorPalette
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public enum GFCCJJPJGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool DGEEFNMGKCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x427E40", Offset = "0x426840", VA = "0x180427E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public static void IKAOOMNKADM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x427E40", Offset = "0x426840", VA = "0x180427E40")]
	public static bool IINLCCAKAEC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D98A90", Offset = "0x3D97490", VA = "0x183D98A90")]
	public static bool GIGLDDFHBNN(Action<double> NIEFFDNOMKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x453960", Offset = "0x452360", VA = "0x180453960")]
	public static FNLMECCNNJH CBPKDDLONOH()
	{
		return default(FNLMECCNNJH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BA030", Offset = "0x6B8A30", VA = "0x1806BA030")]
	public static int NEFENPJDGAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x11A3530", Offset = "0x11A1F30", VA = "0x1811A3530")]
	public static int ENCMHNGJOKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x11A3530", Offset = "0x11A1F30", VA = "0x1811A3530")]
	public static int CFMLEFIKLLK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public static void POEBNFCLLEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public static void CEGJEOIJIJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public static void IFKOIBMKKCH(bool FGGIODPAALM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public static void APNGFMHPJJD(GFCCJJPJGAJ PMGNPGHMMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x427E00", Offset = "0x426800", VA = "0x180427E00")]
	public static void MBFLHJGIEKE(bool MNBJNLBPPFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA973A0", Offset = "0xA95DA0", VA = "0x180A973A0")]
	public static float JIAKNDJOHBN()
	{
		return default(float);
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
