using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LIMDPHCAFMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E98DF0", Offset = "0x5E97DF0", VA = "0x185E98DF0")]
	public static CJBHEDONNPP DGAMFOBEJMM(this in Color CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E98E70", Offset = "0x5E97E70", VA = "0x185E98E70")]
	public static Color HJFKJCGGCHL(this CJBHEDONNPP CFFPEBFKEAC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E98D30", Offset = "0x5E97D30", VA = "0x185E98D30")]
	public static Color? CIOEFFDCILH(this CJBHEDONNPP CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFPHNCEIBGC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E98A90", Offset = "0x5E97A90", VA = "0x185E98A90")]
	public static Quaternion DDJOKJLFGLJ(ACCIOCIJMEN JANIFNADDOP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E98C20", Offset = "0x5E97C20", VA = "0x185E98C20")]
	public static PHPIEJGAKBA DJCGEOOMOOD(Quaternion KFCPAHKGDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E98CC0", Offset = "0x5E97CC0", VA = "0x185E98CC0")]
	public static Quaternion LLALHJMHDHK(PHPIEJGAKBA JANIFNADDOP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ADMLLDKCCFK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E986E0", Offset = "0x5E976E0", VA = "0x185E986E0")]
	public static OOFAHOEMCBH DGAMFOBEJMM(this in Quaternion CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E98760", Offset = "0x5E97760", VA = "0x185E98760")]
	public static OOFAHOEMCBH HCNNJNCPMII(this in Quaternion? CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E98820", Offset = "0x5E97820", VA = "0x185E98820")]
	public static Quaternion HJFKJCGGCHL(this OOFAHOEMCBH CFFPEBFKEAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E98620", Offset = "0x5E97620", VA = "0x185E98620")]
	public static Quaternion? CIOEFFDCILH(this OOFAHOEMCBH CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPMOPLFGMMH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E98910", Offset = "0x5E97910", VA = "0x185E98910")]
	public static PHPIEJGAKBA DGAMFOBEJMM(this in Vector3 CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E98980", Offset = "0x5E97980", VA = "0x185E98980")]
	public static PHPIEJGAKBA HCNNJNCPMII(this in Vector3? CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E98A40", Offset = "0x5E97A40", VA = "0x185E98A40")]
	public static Vector3 HJFKJCGGCHL(this PHPIEJGAKBA CFFPEBFKEAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E98880", Offset = "0x5E97880", VA = "0x185E98880")]
	public static Vector3? CIOEFFDCILH(this PHPIEJGAKBA CFFPEBFKEAC)
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
