using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LJKKPPCDKBG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x876AB10", Offset = "0x8769310", VA = "0x18876AB10")]
	public static PBKPNMBLOAN GJCNJFECIPF([In] this Color DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x876AB90", Offset = "0x8769390", VA = "0x18876AB90")]
	public static Color OLFGCACBCKJ(this PBKPNMBLOAN DKBBJFIDEGB)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x876ABC0", Offset = "0x87693C0", VA = "0x18876ABC0")]
	public static Color? ONJJFHLHKEB(this PBKPNMBLOAN DKBBJFIDEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NIDHCNJIPIC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x876ADD0", Offset = "0x87695D0", VA = "0x18876ADD0")]
	public static Quaternion JFFMGPNAJPC(GCJIPDKJBFE IMINNNCPCJF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x876AC40", Offset = "0x8769440", VA = "0x18876AC40")]
	public static EKLIJIGKCFE BBAMHBEDPNE(Quaternion BPHCLPGEKAG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x876AD30", Offset = "0x8769530", VA = "0x18876AD30")]
	public static Quaternion BFKEGOICFEN(EKLIJIGKCFE IMINNNCPCJF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class JACNGGAAHPP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x876A8B0", Offset = "0x87690B0", VA = "0x18876A8B0")]
	public static GABMJBKGBHH GJCNJFECIPF([In] this Quaternion DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x876A930", Offset = "0x8769130", VA = "0x18876A930")]
	public static Quaternion OLFGCACBCKJ(this GABMJBKGBHH DKBBJFIDEGB)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x876A9A0", Offset = "0x87691A0", VA = "0x18876A9A0")]
	public static Quaternion? ONJJFHLHKEB(this GABMJBKGBHH DKBBJFIDEGB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LBLMLOFAEEB
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x876AA40", Offset = "0x8769240", VA = "0x18876AA40")]
	public static FBAOCJPJOBG GJCNJFECIPF([In] this Vector2 DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x876AAB0", Offset = "0x87692B0", VA = "0x18876AAB0")]
	public static Vector2 OLFGCACBCKJ(this FBAOCJPJOBG DKBBJFIDEGB)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DPKMNENADJO
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x876A740", Offset = "0x8768F40", VA = "0x18876A740")]
	public static EKLIJIGKCFE GJCNJFECIPF([In] this Vector3 DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x876A680", Offset = "0x8768E80", VA = "0x18876A680")]
	public static EKLIJIGKCFE AHCDNDIHKJL([In] this Vector3? DKBBJFIDEGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x876A7B0", Offset = "0x8768FB0", VA = "0x18876A7B0")]
	public static Vector3 OLFGCACBCKJ(this EKLIJIGKCFE DKBBJFIDEGB)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x876A820", Offset = "0x8769020", VA = "0x18876A820")]
	public static Vector3? ONJJFHLHKEB(this EKLIJIGKCFE DKBBJFIDEGB)
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
