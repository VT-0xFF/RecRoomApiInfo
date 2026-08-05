using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MAMJLMDFDJE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum EABPKKONEIO
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
	public enum PFEPEBAEOCK
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool EEKFHEEJPNH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x428E40", Offset = "0x427E40", VA = "0x180428E40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public static void EABAMNKIOJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x428E40", Offset = "0x427E40", VA = "0x180428E40")]
	public static bool BMGCHJLOEGJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3DA0370", Offset = "0x3D9F370", VA = "0x183DA0370")]
	public static bool BHDNDOJKOPC(Action<double> CHNDAMANCDA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x454960", Offset = "0x453960", VA = "0x180454960")]
	public static EABPKKONEIO JIDDPNGEOEG()
	{
		return default(EABPKKONEIO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x56BA80", Offset = "0x56AA80", VA = "0x18056BA80")]
	public static int GGCKCNHCCKP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1128A60", Offset = "0x1127A60", VA = "0x181128A60")]
	public static int GLDHHGFOLMG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1128A60", Offset = "0x1127A60", VA = "0x181128A60")]
	public static int GDCAKJMOCLG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public static void HKDOBKNKIGC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public static void GCLEOEMEILD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public static void FGLBAPGLIHD(bool JOOBEGECCDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public static void PGEMDIBIMAD(PFEPEBAEOCK LDIGFKFPFNH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x428E00", Offset = "0x427E00", VA = "0x180428E00")]
	public static void ALKPBADNPBC(bool OJDBJAMMDJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xC06C70", Offset = "0xC05C70", VA = "0x180C06C70")]
	public static float EEKOIGPMFCF()
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
