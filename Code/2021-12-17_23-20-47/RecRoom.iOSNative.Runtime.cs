using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KBABPJIDBGC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum PINKLKFKLLD
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
	public enum JGACFPEAKJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool HKGNJLCCCLC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static bool BEPHIBAKCOM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public static void JLAIMMHFEGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4BFA40", VA = "0x1804C0E40")]
	public static bool CCMHDMMACAC()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43F50D0", Offset = "0x43F3CD0", VA = "0x1843F50D0")]
	public static bool BEHNCNOGKBF(Action<double> MDJECPPPMJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EC960", Offset = "0x4EB560", VA = "0x1804EC960")]
	public static PINKLKFKLLD LCEMAEPPFLA()
	{
		return default(PINKLKFKLLD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F3670", Offset = "0x5F2270", VA = "0x1805F3670")]
	public static int MAMLEKIFFHJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xC3ED10", Offset = "0xC3D910", VA = "0x180C3ED10")]
	public static int JBIBCIDMAPP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xC3ED10", Offset = "0xC3D910", VA = "0x180C3ED10")]
	public static int GMMLEHGKOOH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public static void BHLLLAIJJDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public static void KDBFABLCIPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public static void PNNMGCJLPEI(bool FFNEMFNIOHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public static void MDLKGMDPDHL(JGACFPEAKJO KLELMLEEPBA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4BFA00", VA = "0x1804C0E00")]
	public static void FKKPBOIGAOE(bool EELFCIDPJMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xC3D0B0", Offset = "0xC3BCB0", VA = "0x180C3D0B0")]
	public static float JHANKLJDNAD()
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
