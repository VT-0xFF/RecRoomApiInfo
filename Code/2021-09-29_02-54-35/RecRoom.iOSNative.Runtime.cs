using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MHPIKDFNJDO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum JAJBNAECNHB
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
	public enum OOALIHFLJDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool LHENCLJABLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x41FE40", Offset = "0x41EC40", VA = "0x18041FE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public static void HMKOBDFNCPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41FE40", Offset = "0x41EC40", VA = "0x18041FE40")]
	public static bool MMPBIDLDGOM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3CFD060", Offset = "0x3CFBE60", VA = "0x183CFD060")]
	public static bool KPCEHCHPNJN(Action<double> NNDAIJGAPPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x44B960", Offset = "0x44A760", VA = "0x18044B960")]
	public static JAJBNAECNHB IEHHDDEMBGD()
	{
		return default(JAJBNAECNHB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x50E180", Offset = "0x50CF80", VA = "0x18050E180")]
	public static int JIBKPJCEACI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xE08240", Offset = "0xE07040", VA = "0x180E08240")]
	public static int CDMICKONKGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xE08240", Offset = "0xE07040", VA = "0x180E08240")]
	public static int HMJDHFNFFLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public static void NOAONNEMKBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public static void EEKKLCBEOJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public static void BJCBMEPFEMN(bool EJHELNEAODN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public static void HDCALPMMNEF(OOALIHFLJDB CLMIKKLGEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x41FE00", Offset = "0x41EC00", VA = "0x18041FE00")]
	public static void FFNBOMFMHAC(bool NPPBBGMDANN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xE06740", Offset = "0xE05540", VA = "0x180E06740")]
	public static float JEIGCNFOKGF()
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
