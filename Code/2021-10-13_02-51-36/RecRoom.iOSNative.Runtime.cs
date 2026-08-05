using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EDGODDDKAFB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum OILFKNNLHGK
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
	public enum NMHECIKOBHA
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool NEIOEGPPLLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x456CA0", Offset = "0x4560A0", VA = "0x180456CA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public static void DOFLAAEEHLD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x456CA0", Offset = "0x4560A0", VA = "0x180456CA0")]
	public static bool JLPHHLEBNNJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x40921C0", Offset = "0x40915C0", VA = "0x1840921C0")]
	public static bool JPJAOPEGHEG(Action<double> NFPIEMCJCEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x45BC80", Offset = "0x45B080", VA = "0x18045BC80")]
	public static OILFKNNLHGK KFBILCCJCAP()
	{
		return default(OILFKNNLHGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D5C70", Offset = "0x6D5070", VA = "0x1806D5C70")]
	public static int CELKPANOJEP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x45DD20", Offset = "0x45D120", VA = "0x18045DD20")]
	public static int LKKGMJJBMNH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x45DD20", Offset = "0x45D120", VA = "0x18045DD20")]
	public static int CEFHDOHIEIH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public static void AIODLNIBPCK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public static void BIEEGEHFGDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public static void HFJNFOPGBEA(bool KOLJGDKMIHE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public static void MJBLILBPNFB(NMHECIKOBHA APMPFCPCFIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x448110", Offset = "0x447510", VA = "0x180448110")]
	public static void FKCDMINFDAK(bool HJOAKJAEFHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x45BC70", Offset = "0x45B070", VA = "0x18045BC70")]
	public static float IKHANIOELPJ()
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
