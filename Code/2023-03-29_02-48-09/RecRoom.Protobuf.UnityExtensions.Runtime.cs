using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BEGOGMNLNHC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x663ED30", Offset = "0x663DB30", VA = "0x18663ED30")]
	public static IILGPOGJGJP APDPBGNCGIO(this in Color CNBAEMLJEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x663EDB0", Offset = "0x663DBB0", VA = "0x18663EDB0")]
	public static Color DHABJCANOEO(this IILGPOGJGJP CNBAEMLJEBG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x663EE10", Offset = "0x663DC10", VA = "0x18663EE10")]
	public static Color? JLHMCLMOFCL(this IILGPOGJGJP CNBAEMLJEBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MLOCCKOKIAO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x663F1C0", Offset = "0x663DFC0", VA = "0x18663F1C0")]
	public static Quaternion IEBIAOIOFAK(GHMECCKKEGE PHAPMEHMHAK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x663F3C0", Offset = "0x663E1C0", VA = "0x18663F3C0")]
	public static BGENGKEAMDH NFFKHEDGBIP(Quaternion HKJJCIHIAFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x663F350", Offset = "0x663E150", VA = "0x18663F350")]
	public static Quaternion LHCHPPDJIHD(BGENGKEAMDH PHAPMEHMHAK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DPPKLBDIJOG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x663EED0", Offset = "0x663DCD0", VA = "0x18663EED0")]
	public static ILLJLFHPEPK APDPBGNCGIO(this in Quaternion CNBAEMLJEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x663EF50", Offset = "0x663DD50", VA = "0x18663EF50")]
	public static Quaternion DHABJCANOEO(this ILLJLFHPEPK CNBAEMLJEBG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x663EFB0", Offset = "0x663DDB0", VA = "0x18663EFB0")]
	public static Quaternion? JLHMCLMOFCL(this ILLJLFHPEPK CNBAEMLJEBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EPEOJHJJOPN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x663F070", Offset = "0x663DE70", VA = "0x18663F070")]
	public static BGENGKEAMDH APDPBGNCGIO(this in Vector3 CNBAEMLJEBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x663F0E0", Offset = "0x663DEE0", VA = "0x18663F0E0")]
	public static Vector3 DHABJCANOEO(this BGENGKEAMDH CNBAEMLJEBG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x663F130", Offset = "0x663DF30", VA = "0x18663F130")]
	public static Vector3? JLHMCLMOFCL(this BGENGKEAMDH CNBAEMLJEBG)
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
