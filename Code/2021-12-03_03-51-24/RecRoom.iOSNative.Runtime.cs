using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MIAPMHPBFBB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum DNGKFHBIIOJ
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
	public enum FLPAALGHOJK
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool OGJFLILJFCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static bool MBODADBHDBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public static void ADAIPCDILBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46FE40", Offset = "0x46F040", VA = "0x18046FE40")]
	public static bool BJBJPHBOJOA()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0A00", Offset = "0x3F9FC00", VA = "0x183FA0A00")]
	public static bool LBFKIHJLBNC(Action<double> PFLGFGDMOJB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x49B960", Offset = "0x49AB60", VA = "0x18049B960")]
	public static DNGKFHBIIOJ AONBILGGGEF()
	{
		return default(DNGKFHBIIOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x583370", Offset = "0x582570", VA = "0x180583370")]
	public static int IMHHJINOEAE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xBFD890", Offset = "0xBFCA90", VA = "0x180BFD890")]
	public static int DPFAACHKBOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xBFD890", Offset = "0xBFCA90", VA = "0x180BFD890")]
	public static int FFHONKIIIGB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public static void NPIBFOFCJKJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public static void OKHMAEELLDB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public static void CNJCIAEBCMC(bool ECJIKBMPEIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public static void GEFDENCHJMD(FLPAALGHOJK IHDLNFNEFKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46FE00", Offset = "0x46F000", VA = "0x18046FE00")]
	public static void EMOPIEMELHH(bool IGEIFKFPIOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xDDB660", Offset = "0xDDA860", VA = "0x180DDB660")]
	public static float OBKHLDCLFKG()
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
