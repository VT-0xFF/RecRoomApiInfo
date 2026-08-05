using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JOHBGEJHGEO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2897DD0", Offset = "0x2896FD0", VA = "0x182897DD0")]
	public static PIFDBLIJDPH LIOPAMDCNLD(this in Color BJFNBIEJBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2897D60", Offset = "0x2896F60", VA = "0x182897D60")]
	public static Color LGPKACCHBHO(this PIFDBLIJDPH BJFNBIEJBCK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2897E50", Offset = "0x2897050", VA = "0x182897E50")]
	public static Color? OPOOJAAODPG(this PIFDBLIJDPH BJFNBIEJBCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class OCBFNBGFOKO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28980C0", Offset = "0x28972C0", VA = "0x1828980C0")]
	public static Quaternion LIGIHMHGBBG(NFJGNIBCMIC ADIGGFBANFM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2898020", Offset = "0x2897220", VA = "0x182898020")]
	public static MDGEHLFLKED KFLIBGGPLBK(Quaternion NOHIECHPBDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2897F20", Offset = "0x2897120", VA = "0x182897F20")]
	public static Quaternion DEJKMFMFCOL(MDGEHLFLKED ADIGGFBANFM)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BEDFIOCAGLB
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x2897980", Offset = "0x2896B80", VA = "0x182897980")]
	public static APBHABEPFJJ LIOPAMDCNLD(this in Quaternion BJFNBIEJBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2897810", Offset = "0x2896A10", VA = "0x182897810")]
	public static APBHABEPFJJ JKKKJCMNDIO(this in Quaternion? BJFNBIEJBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x28978C0", Offset = "0x2896AC0", VA = "0x1828978C0")]
	public static Quaternion LGPKACCHBHO(this APBHABEPFJJ BJFNBIEJBCK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x2897A00", Offset = "0x2896C00", VA = "0x182897A00")]
	public static Quaternion? OPOOJAAODPG(this APBHABEPFJJ BJFNBIEJBCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ENIIBCLKOGL
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2897C30", Offset = "0x2896E30", VA = "0x182897C30")]
	public static MDGEHLFLKED LIOPAMDCNLD(this in Vector3 BJFNBIEJBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2897AD0", Offset = "0x2896CD0", VA = "0x182897AD0")]
	public static MDGEHLFLKED JKKKJCMNDIO(this in Vector3? BJFNBIEJBCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2897B80", Offset = "0x2896D80", VA = "0x182897B80")]
	public static Vector3 LGPKACCHBHO(this MDGEHLFLKED BJFNBIEJBCK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x2897CA0", Offset = "0x2896EA0", VA = "0x182897CA0")]
	public static Vector3? OPOOJAAODPG(this MDGEHLFLKED BJFNBIEJBCK)
	{
		return null;
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
