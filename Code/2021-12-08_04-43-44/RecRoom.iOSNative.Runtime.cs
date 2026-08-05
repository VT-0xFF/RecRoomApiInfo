using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FCJCKJIGJGP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum GHNJLFPLPIB
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
	public enum KOHJEHIKFDJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool ABGHILHLJFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static bool BGDPJGCGINL
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public static void OMAOFGMMBPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E40", Offset = "0x4C0240", VA = "0x1804C0E40")]
	public static bool HHNLPKOHKDM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43EC7C0", Offset = "0x43EBBC0", VA = "0x1843EC7C0")]
	public static bool JBIMBJINLFM(Action<double> HLHLIEALJPO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EC960", Offset = "0x4EBD60", VA = "0x1804EC960")]
	public static GHNJLFPLPIB OEDNLMOKHPJ()
	{
		return default(GHNJLFPLPIB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F3670", Offset = "0x5F2A70", VA = "0x1805F3670")]
	public static int ICCCKIKKJAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xEAF530", Offset = "0xEAE930", VA = "0x180EAF530")]
	public static int JOHONBEIFKH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xEAF530", Offset = "0xEAE930", VA = "0x180EAF530")]
	public static int GOKGBOOCJAK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public static void MNIEGEAGEEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public static void FGOENDIEEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public static void DKBIPEENPBO(bool LHKALEKCKKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public static void PLIJPOFPHGE(KOHJEHIKFDJ KBEEGDPIGDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4C0E00", Offset = "0x4C0200", VA = "0x1804C0E00")]
	public static void JOOEONDOCEJ(bool KAOLNEGIHGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xD27E50", Offset = "0xD27250", VA = "0x180D27E50")]
	public static float OOHFPFOFIJH()
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
