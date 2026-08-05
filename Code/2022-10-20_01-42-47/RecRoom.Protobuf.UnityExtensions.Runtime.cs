using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LIMDPHCAFMD
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E98B70", Offset = "0x5E97970", VA = "0x185E98B70")]
	public static CJBHEDONNPP DGAMFOBEJMM(this in Color CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E98BF0", Offset = "0x5E979F0", VA = "0x185E98BF0")]
	public static Color HJFKJCGGCHL(this CJBHEDONNPP CFFPEBFKEAC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E98AB0", Offset = "0x5E978B0", VA = "0x185E98AB0")]
	public static Color? CIOEFFDCILH(this CJBHEDONNPP CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFPHNCEIBGC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E98810", Offset = "0x5E97610", VA = "0x185E98810")]
	public static Quaternion DDJOKJLFGLJ(ACCIOCIJMEN JANIFNADDOP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5E989A0", Offset = "0x5E977A0", VA = "0x185E989A0")]
	public static PHPIEJGAKBA DJCGEOOMOOD(Quaternion KFCPAHKGDLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E98A40", Offset = "0x5E97840", VA = "0x185E98A40")]
	public static Quaternion LLALHJMHDHK(PHPIEJGAKBA JANIFNADDOP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ADMLLDKCCFK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5E98460", Offset = "0x5E97260", VA = "0x185E98460")]
	public static OOFAHOEMCBH DGAMFOBEJMM(this in Quaternion CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5E984E0", Offset = "0x5E972E0", VA = "0x185E984E0")]
	public static OOFAHOEMCBH HCNNJNCPMII(this in Quaternion? CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5E985A0", Offset = "0x5E973A0", VA = "0x185E985A0")]
	public static Quaternion HJFKJCGGCHL(this OOFAHOEMCBH CFFPEBFKEAC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5E983A0", Offset = "0x5E971A0", VA = "0x185E983A0")]
	public static Quaternion? CIOEFFDCILH(this OOFAHOEMCBH CFFPEBFKEAC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DPMOPLFGMMH
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5E98690", Offset = "0x5E97490", VA = "0x185E98690")]
	public static PHPIEJGAKBA DGAMFOBEJMM(this in Vector3 CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E98700", Offset = "0x5E97500", VA = "0x185E98700")]
	public static PHPIEJGAKBA HCNNJNCPMII(this in Vector3? CFFPEBFKEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E987C0", Offset = "0x5E975C0", VA = "0x185E987C0")]
	public static Vector3 HJFKJCGGCHL(this PHPIEJGAKBA CFFPEBFKEAC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5E98600", Offset = "0x5E97400", VA = "0x185E98600")]
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
