using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ECAEPEMNCAA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x879D560", Offset = "0x879BB60", VA = "0x18879D560")]
	public static PNFDOINDCLH LGGJGPOGIBH([In] this Color PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x879D4B0", Offset = "0x879BAB0", VA = "0x18879D4B0")]
	public static Color FJJOMODMCLM(this PNFDOINDCLH PIKMBNLEPPK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x879D4E0", Offset = "0x879BAE0", VA = "0x18879D4E0")]
	public static Color? IIOAMAALLKA(this PNFDOINDCLH PIKMBNLEPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BHELNAMODKO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x879D1B0", Offset = "0x879B7B0", VA = "0x18879D1B0")]
	public static Quaternion GOMNJGBCHPC(FFDHOGGGOOM ACJFHCNBBBO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x879D3C0", Offset = "0x879B9C0", VA = "0x18879D3C0")]
	public static GJAEJAEHICB JEKNCBJJIPD(Quaternion KCNLFIGKEFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x879D110", Offset = "0x879B710", VA = "0x18879D110")]
	public static Quaternion EHPALPKPFBM(GJAEJAEHICB ACJFHCNBBBO)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ENGEOOOOGFD
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x879D6F0", Offset = "0x879BCF0", VA = "0x18879D6F0")]
	public static FMBJDFEGOEG LGGJGPOGIBH([In] this Quaternion PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x879D5E0", Offset = "0x879BBE0", VA = "0x18879D5E0")]
	public static Quaternion FJJOMODMCLM(this FMBJDFEGOEG PIKMBNLEPPK)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x879D650", Offset = "0x879BC50", VA = "0x18879D650")]
	public static Quaternion? IIOAMAALLKA(this FMBJDFEGOEG PIKMBNLEPPK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAHKEBCGACN
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x879DA00", Offset = "0x879C000", VA = "0x18879DA00")]
	public static FCCAMKIAKJB LGGJGPOGIBH([In] this Vector2 PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x879D9A0", Offset = "0x879BFA0", VA = "0x18879D9A0")]
	public static Vector2 FJJOMODMCLM(this FCCAMKIAKJB PIKMBNLEPPK)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class HMAJPHEOCND
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x879D870", Offset = "0x879BE70", VA = "0x18879D870")]
	public static GJAEJAEHICB LGGJGPOGIBH([In] this Vector3 PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x879D8E0", Offset = "0x879BEE0", VA = "0x18879D8E0")]
	public static GJAEJAEHICB NCIHIOACIJG([In] this Vector3? PIKMBNLEPPK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x879D770", Offset = "0x879BD70", VA = "0x18879D770")]
	public static Vector3 FJJOMODMCLM(this GJAEJAEHICB PIKMBNLEPPK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x879D7E0", Offset = "0x879BDE0", VA = "0x18879D7E0")]
	public static Vector3? IIOAMAALLKA(this GJAEJAEHICB PIKMBNLEPPK)
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
