using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IMIKEFIHABH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB5E0", Offset = "0x5EBA3E0", VA = "0x185EBB5E0")]
	public static JEBGMDMBLIL CLPGJOCDFOA(this in Color DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB720", Offset = "0x5EBA520", VA = "0x185EBB720")]
	public static Color MNOLKCHHLIP(this JEBGMDMBLIL DLIFLKHFBMM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB660", Offset = "0x5EBA460", VA = "0x185EBB660")]
	public static Color? COJACFFNLON(this JEBGMDMBLIL DLIFLKHFBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HOKJHKFDIFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB180", Offset = "0x5EB9F80", VA = "0x185EBB180")]
	public static Quaternion KODECILJIAM(CLKPHKBGCMO JLFCOOGLPMP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB0E0", Offset = "0x5EB9EE0", VA = "0x185EBB0E0")]
	public static GJMJFBLHLBO DNILDPMDLIE(Quaternion CCCFLPBKAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB310", Offset = "0x5EBA110", VA = "0x185EBB310")]
	public static Quaternion PAEBHIOKPFD(GJMJFBLHLBO JLFCOOGLPMP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ICAKECBCCMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB440", Offset = "0x5EBA240", VA = "0x185EBB440")]
	public static AIKEHLJLODC CLPGJOCDFOA(this in Quaternion DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB380", Offset = "0x5EBA180", VA = "0x185EBB380")]
	public static AIKEHLJLODC AHAPLBEJLCG(this in Quaternion? DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB580", Offset = "0x5EBA380", VA = "0x185EBB580")]
	public static Quaternion MNOLKCHHLIP(this AIKEHLJLODC DLIFLKHFBMM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB4C0", Offset = "0x5EBA2C0", VA = "0x185EBB4C0")]
	public static Quaternion? COJACFFNLON(this AIKEHLJLODC DLIFLKHFBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CDAIBFIMLAG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAF90", Offset = "0x5EB9D90", VA = "0x185EBAF90")]
	public static GJMJFBLHLBO CLPGJOCDFOA(this in Vector3 DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EBAED0", Offset = "0x5EB9CD0", VA = "0x185EBAED0")]
	public static GJMJFBLHLBO AHAPLBEJLCG(this in Vector3? DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB090", Offset = "0x5EB9E90", VA = "0x185EBB090")]
	public static Vector3 MNOLKCHHLIP(this GJMJFBLHLBO DLIFLKHFBMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EBB000", Offset = "0x5EB9E00", VA = "0x185EBB000")]
	public static Vector3? COJACFFNLON(this GJMJFBLHLBO DLIFLKHFBMM)
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
