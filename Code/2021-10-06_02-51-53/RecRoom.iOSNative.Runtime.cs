using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EDNGKHCLAJK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum LNOFMLHINFH
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
	public enum FPBGKMGGLMF
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool ABNMHHALCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x446F50", Offset = "0x445F50", VA = "0x180446F50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public static void CPFMAAEECJK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x446F50", Offset = "0x445F50", VA = "0x180446F50")]
	public static bool PMCHHKDPFMH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3D0DEA0", Offset = "0x3D0CEA0", VA = "0x183D0DEA0")]
	public static bool EIJKAMJOBNE(Action<double> KPLCONOAAFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x42F1F0", Offset = "0x42E1F0", VA = "0x18042F1F0")]
	public static LNOFMLHINFH ONLANHNDGCN()
	{
		return default(LNOFMLHINFH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x653230", Offset = "0x652230", VA = "0x180653230")]
	public static int PIKPJPEGPOP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x186E0D0", Offset = "0x186D0D0", VA = "0x18186E0D0")]
	public static int OEFCFBJPDCM()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x186E0D0", Offset = "0x186D0D0", VA = "0x18186E0D0")]
	public static int NNJDGMPHDHL()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public static void DLADKCNIFEB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public static void JLHNCCCDOPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public static void BOFEMEOAEDJ(bool PEFNOPOBLOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public static void PKPMLFODLID(FPBGKMGGLMF KHHMOIAFEKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x41FB10", Offset = "0x41EB10", VA = "0x18041FB10")]
	public static void FNDCIDJJMFM(bool HHBBCKDAHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5621D0", Offset = "0x5611D0", VA = "0x1805621D0")]
	public static float EMJMLJMBOGO()
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
