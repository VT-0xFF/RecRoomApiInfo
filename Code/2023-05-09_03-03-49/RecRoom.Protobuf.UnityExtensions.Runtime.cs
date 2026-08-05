using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EIELLKBLJOD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E754E0", Offset = "0x1E73EE0", VA = "0x181E754E0")]
	public static KELNIJLFDLO HGLHKADDNFF(this in Color IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E75480", Offset = "0x1E73E80", VA = "0x181E75480")]
	public static Color AIBDMMJCKEC(this KELNIJLFDLO IKHBPJOEIEB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E75560", Offset = "0x1E73F60", VA = "0x181E75560")]
	public static Color? KECNFAGGOKI(this KELNIJLFDLO IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HLHAFBCLFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E75860", Offset = "0x1E74260", VA = "0x181E75860")]
	public static Quaternion JCJDHAAPNFE(KKPMAKELFAE MNILNHMNKJK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E757C0", Offset = "0x1E741C0", VA = "0x181E757C0")]
	public static ODJAEGCHGFE DOAJFFBFCGK(Quaternion CHBFJKGJEOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E759F0", Offset = "0x1E743F0", VA = "0x181E759F0")]
	public static Quaternion MOHHJLJFDNM(ODJAEGCHGFE MNILNHMNKJK)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FHPEBPNPECP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1E75680", Offset = "0x1E74080", VA = "0x181E75680")]
	public static CINOCHJLEMO HGLHKADDNFF(this in Quaternion IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1E75620", Offset = "0x1E74020", VA = "0x181E75620")]
	public static Quaternion AIBDMMJCKEC(this CINOCHJLEMO IKHBPJOEIEB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1E75700", Offset = "0x1E74100", VA = "0x181E75700")]
	public static Quaternion? KECNFAGGOKI(this CINOCHJLEMO IKHBPJOEIEB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NCICFGHKHPI
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1E75AB0", Offset = "0x1E744B0", VA = "0x181E75AB0")]
	public static ODJAEGCHGFE HGLHKADDNFF(this in Vector3 IKHBPJOEIEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1E75A60", Offset = "0x1E74460", VA = "0x181E75A60")]
	public static Vector3 AIBDMMJCKEC(this ODJAEGCHGFE IKHBPJOEIEB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1E75B20", Offset = "0x1E74520", VA = "0x181E75B20")]
	public static Vector3? KECNFAGGOKI(this ODJAEGCHGFE IKHBPJOEIEB)
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
