using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class IMIKEFIHABH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60931E0", Offset = "0x6091DE0", VA = "0x1860931E0")]
	public static JEBGMDMBLIL CLPGJOCDFOA(this in Color DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6093320", Offset = "0x6091F20", VA = "0x186093320")]
	public static Color MNOLKCHHLIP(this JEBGMDMBLIL DLIFLKHFBMM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6093260", Offset = "0x6091E60", VA = "0x186093260")]
	public static Color? COJACFFNLON(this JEBGMDMBLIL DLIFLKHFBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HOKJHKFDIFJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6092D80", Offset = "0x6091980", VA = "0x186092D80")]
	public static Quaternion KODECILJIAM(CLKPHKBGCMO JLFCOOGLPMP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6092CE0", Offset = "0x60918E0", VA = "0x186092CE0")]
	public static GJMJFBLHLBO DNILDPMDLIE(Quaternion CCCFLPBKAJD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6092F10", Offset = "0x6091B10", VA = "0x186092F10")]
	public static Quaternion PAEBHIOKPFD(GJMJFBLHLBO JLFCOOGLPMP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ICAKECBCCMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6093040", Offset = "0x6091C40", VA = "0x186093040")]
	public static AIKEHLJLODC CLPGJOCDFOA(this in Quaternion DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6092F80", Offset = "0x6091B80", VA = "0x186092F80")]
	public static AIKEHLJLODC AHAPLBEJLCG(this in Quaternion? DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6093180", Offset = "0x6091D80", VA = "0x186093180")]
	public static Quaternion MNOLKCHHLIP(this AIKEHLJLODC DLIFLKHFBMM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60930C0", Offset = "0x6091CC0", VA = "0x1860930C0")]
	public static Quaternion? COJACFFNLON(this AIKEHLJLODC DLIFLKHFBMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CDAIBFIMLAG
{
	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6092B90", Offset = "0x6091790", VA = "0x186092B90")]
	public static GJMJFBLHLBO CLPGJOCDFOA(this in Vector3 DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6092AD0", Offset = "0x60916D0", VA = "0x186092AD0")]
	public static GJMJFBLHLBO AHAPLBEJLCG(this in Vector3? DLIFLKHFBMM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6092C90", Offset = "0x6091890", VA = "0x186092C90")]
	public static Vector3 MNOLKCHHLIP(this GJMJFBLHLBO DLIFLKHFBMM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6092C00", Offset = "0x6091800", VA = "0x186092C00")]
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
