using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LIMDPHCAFMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E97AD0", Offset = "0x5E968D0", VA = "0x185E97AD0")]
	public static CJBHEDONNPP DGAMFOBEJMM(this in Color CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E97B50", Offset = "0x5E96950", VA = "0x185E97B50")]
	public static Color HJFKJCGGCHL(this CJBHEDONNPP CFFPEBFKEAC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E97A10", Offset = "0x5E96810", VA = "0x185E97A10")]
	public static Color? CIOEFFDCILH(this CJBHEDONNPP CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFPHNCEIBGC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E97770", Offset = "0x5E96570", VA = "0x185E97770")]
	public static Quaternion DDJOKJLFGLJ(ACCIOCIJMEN JANIFNADDOP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E97900", Offset = "0x5E96700", VA = "0x185E97900")]
	public static PHPIEJGAKBA DJCGEOOMOOD(Quaternion KFCPAHKGDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E979A0", Offset = "0x5E967A0", VA = "0x185E979A0")]
	public static Quaternion LLALHJMHDHK(PHPIEJGAKBA JANIFNADDOP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ADMLLDKCCFK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E973C0", Offset = "0x5E961C0", VA = "0x185E973C0")]
	public static OOFAHOEMCBH DGAMFOBEJMM(this in Quaternion CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E97440", Offset = "0x5E96240", VA = "0x185E97440")]
	public static OOFAHOEMCBH HCNNJNCPMII(this in Quaternion? CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E97500", Offset = "0x5E96300", VA = "0x185E97500")]
	public static Quaternion HJFKJCGGCHL(this OOFAHOEMCBH CFFPEBFKEAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E97300", Offset = "0x5E96100", VA = "0x185E97300")]
	public static Quaternion? CIOEFFDCILH(this OOFAHOEMCBH CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPMOPLFGMMH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E975F0", Offset = "0x5E963F0", VA = "0x185E975F0")]
	public static PHPIEJGAKBA DGAMFOBEJMM(this in Vector3 CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E97660", Offset = "0x5E96460", VA = "0x185E97660")]
	public static PHPIEJGAKBA HCNNJNCPMII(this in Vector3? CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E97720", Offset = "0x5E96520", VA = "0x185E97720")]
	public static Vector3 HJFKJCGGCHL(this PHPIEJGAKBA CFFPEBFKEAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E97560", Offset = "0x5E96360", VA = "0x185E97560")]
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
