using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LEHLKCMOHEL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66A0580", Offset = "0x669F780", VA = "0x1866A0580")]
	public static HLKIHNAOCAH CJMGAEMJONM([In] this Color KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66A0550", Offset = "0x669F750", VA = "0x1866A0550")]
	public static Color APPDJDLGIOH(this HLKIHNAOCAH KPBGCHDNDLM)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66A0600", Offset = "0x669F800", VA = "0x1866A0600")]
	public static Color? PCECJJLIEMK(this HLKIHNAOCAH KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DDELKNPCIKL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x669FEA0", Offset = "0x669F0A0", VA = "0x18669FEA0")]
	public static Quaternion BPKDCIHDENL(OIHJEIONENF GKNJGNIHLDH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66A00C0", Offset = "0x669F2C0", VA = "0x1866A00C0")]
	public static JMMPIKLJJKH KKPHHHBOGGN(Quaternion BDIEEGIMDAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66A01B0", Offset = "0x669F3B0", VA = "0x1866A01B0")]
	public static Quaternion NOAJIJOLBNO(JMMPIKLJJKH GKNJGNIHLDH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ECFIPBCMEDK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66A0430", Offset = "0x669F630", VA = "0x1866A0430")]
	public static MCJJPEPIPEO CJMGAEMJONM([In] this Quaternion KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66A03C0", Offset = "0x669F5C0", VA = "0x1866A03C0")]
	public static Quaternion APPDJDLGIOH(this MCJJPEPIPEO KPBGCHDNDLM)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66A04B0", Offset = "0x669F6B0", VA = "0x1866A04B0")]
	public static Quaternion? PCECJJLIEMK(this MCJJPEPIPEO KPBGCHDNDLM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ABCIFBPCDHF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x669FE30", Offset = "0x669F030", VA = "0x18669FE30")]
	public static PBBGLLHPBIO CJMGAEMJONM([In] this Vector2 KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x669FDD0", Offset = "0x669EFD0", VA = "0x18669FDD0")]
	public static Vector2 APPDJDLGIOH(this PBBGLLHPBIO KPBGCHDNDLM)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class ECBIKIAEPKC
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66A02C0", Offset = "0x669F4C0", VA = "0x1866A02C0")]
	public static JMMPIKLJJKH CJMGAEMJONM([In] this Vector3 KPBGCHDNDLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66A0250", Offset = "0x669F450", VA = "0x1866A0250")]
	public static Vector3 APPDJDLGIOH(this JMMPIKLJJKH KPBGCHDNDLM)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x66A0330", Offset = "0x669F530", VA = "0x1866A0330")]
	public static Vector3? PCECJJLIEMK(this JMMPIKLJJKH KPBGCHDNDLM)
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
