using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JDJNICMNKBM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public enum KGODHBFLPEI
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
	public enum JPGOKKBBDJO
	{
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		LightContent
	}

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static bool AHHNHAJKJNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static bool GJBEEJENJBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public static void FNJEJIJPHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE40", Offset = "0x4BF240", VA = "0x1804BFE40")]
	public static bool AFGEBBLJKCK()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43F1BA0", Offset = "0x43F0FA0", VA = "0x1843F1BA0")]
	public static bool KPJLAGNCFCH(Action<double> PBIEDKAHJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4EB960", Offset = "0x4EAD60", VA = "0x1804EB960")]
	public static KGODHBFLPEI BELJEFHMLPH()
	{
		return default(KGODHBFLPEI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x602A70", Offset = "0x601E70", VA = "0x180602A70")]
	public static int GIPELFKMHIE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xBDE780", Offset = "0xBDDB80", VA = "0x180BDE780")]
	public static int ABCCODPOKIC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xBDE780", Offset = "0xBDDB80", VA = "0x180BDE780")]
	public static int FCPDLOLDBMI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public static void HGLMIFMDDON()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public static void PEFKMFDDKKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public static void IICKIHKDKPL(bool CNHHKOHEDCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public static void LABHACCFDJM(JPGOKKBBDJO LKGLIDFIDGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x4BFE00", Offset = "0x4BF200", VA = "0x1804BFE00")]
	public static void PDGMOLIFFMH(bool OIENEPIEDOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0xD18720", Offset = "0xD17B20", VA = "0x180D18720")]
	public static float MHIOIEBILPH()
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
