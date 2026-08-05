using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KAMFIFLOEJL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum HKFCIEBCNCH
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
	public enum EAPKNPOIIJP
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool GOJFEOBDEHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x449E40", Offset = "0x449040", VA = "0x180449E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public static void EGBIGMHONAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x449E40", Offset = "0x449040", VA = "0x180449E40")]
	public static bool GBEGCAHBCJE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xDD2B30", Offset = "0xDD1D30", VA = "0x180DD2B30")]
	public static bool EIEMJKFPNHJ(Action<double> GNBMBBMEDOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x475960", Offset = "0x474B60", VA = "0x180475960")]
	public static HKFCIEBCNCH LDIIFHJHDHC()
	{
		return default(HKFCIEBCNCH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BEF40", Offset = "0x5BE140", VA = "0x1805BEF40")]
	public static int HLGEGEIONML()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xDD2B20", Offset = "0xDD1D20", VA = "0x180DD2B20")]
	public static int DODDOHMHCMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xDD2B20", Offset = "0xDD1D20", VA = "0x180DD2B20")]
	public static int DMEPOMJDIIN()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public static void LIBFGCJGLOA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public static void CKKPGDIHFHE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public static void EDONELIEAJD(bool NIENFMFJDMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public static void NNDJJHOFCKH(EAPKNPOIIJP HLIHBPKAINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x449E00", Offset = "0x449000", VA = "0x180449E00")]
	public static void PLHBAFIGPLP(bool PECPAEOMDFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD4E270", Offset = "0xD4D470", VA = "0x180D4E270")]
	public static float MBLKKJPLHLB()
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
