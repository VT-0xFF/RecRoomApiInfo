using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MBNBAJOHDKJ
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x193DE10", Offset = "0x193CC10", VA = "0x18193DE10")]
	public static DFCBJFIGOCD LKKGLINHIKF(this in Color FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x193DD40", Offset = "0x193CB40", VA = "0x18193DD40")]
	public static Color KMIKNNFPDOG(this DFCBJFIGOCD FEEMIHFJMDK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x193DEB0", Offset = "0x193CCB0", VA = "0x18193DEB0")]
	public static Color? ONGNIJNCDBD(this DFCBJFIGOCD FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LDOIIOAIFNL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x193DB80", Offset = "0x193C980", VA = "0x18193DB80")]
	public static LBEDPEBMDIC LKKGLINHIKF(this in Quaternion FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x193DAB0", Offset = "0x193C8B0", VA = "0x18193DAB0")]
	public static Quaternion KMIKNNFPDOG(this LBEDPEBMDIC FEEMIHFJMDK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x193DC20", Offset = "0x193CA20", VA = "0x18193DC20")]
	public static Quaternion? ONGNIJNCDBD(this LBEDPEBMDIC FEEMIHFJMDK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AGCMGEAGEGE
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x193D6A0", Offset = "0x193C4A0", VA = "0x18193D6A0")]
	public static Quaternion NIJPALJCJKI(AGIJOOAGMFI FAJCHBCCGOJ)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x193D5F0", Offset = "0x193C3F0", VA = "0x18193D5F0")]
	public static DCOLFGJBGLJ EBHGGGDBNKC(Quaternion DEAFFPFOHIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x193D550", Offset = "0x193C350", VA = "0x18193D550")]
	public static Quaternion AAPDIOAIDDC(DCOLFGJBGLJ FAJCHBCCGOJ)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JCHOEJBCCHD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x193D960", Offset = "0x193C760", VA = "0x18193D960")]
	public static DCOLFGJBGLJ LKKGLINHIKF(this in Vector3 FEEMIHFJMDK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x193D8C0", Offset = "0x193C6C0", VA = "0x18193D8C0")]
	public static Vector3 KMIKNNFPDOG(this DCOLFGJBGLJ FEEMIHFJMDK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x193D9F0", Offset = "0x193C7F0", VA = "0x18193D9F0")]
	public static Vector3? ONGNIJNCDBD(this DCOLFGJBGLJ FEEMIHFJMDK)
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
