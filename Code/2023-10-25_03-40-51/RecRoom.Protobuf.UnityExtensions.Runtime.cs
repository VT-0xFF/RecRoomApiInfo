using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KOOJFJBBOHC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x61C0830", Offset = "0x61BF630", VA = "0x1861C0830")]
	public static MMPMNAJGBPF LJOKGFFEJKK([In] this Color PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x61C08B0", Offset = "0x61BF6B0", VA = "0x1861C08B0")]
	public static Color NLOFGFEMKNI(this MMPMNAJGBPF PECKHAMCEFO)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x61C07B0", Offset = "0x61BF5B0", VA = "0x1861C07B0")]
	public static Color? KHHICJHKHCK(this MMPMNAJGBPF PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LFKMELGEGFO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x61C08E0", Offset = "0x61BF6E0", VA = "0x1861C08E0")]
	public static Quaternion ABCLFMICLNF(BCJAKBKPFLP LMCJHCIOIIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x61C0BA0", Offset = "0x61BF9A0", VA = "0x1861C0BA0")]
	public static LOLIBLABPPK PGMBDNHDDAE(Quaternion DJKEPCBLCPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x61C0B00", Offset = "0x61BF900", VA = "0x1861C0B00")]
	public static Quaternion KPNEKLEKNIJ(LOLIBLABPPK LMCJHCIOIIP)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OJGFKOHFGCI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x61C0D30", Offset = "0x61BFB30", VA = "0x1861C0D30")]
	public static JAONGPLFLLM LJOKGFFEJKK([In] this Quaternion PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x61C0DB0", Offset = "0x61BFBB0", VA = "0x1861C0DB0")]
	public static Quaternion NLOFGFEMKNI(this JAONGPLFLLM PECKHAMCEFO)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x61C0C90", Offset = "0x61BFA90", VA = "0x1861C0C90")]
	public static Quaternion? KHHICJHKHCK(this JAONGPLFLLM PECKHAMCEFO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GKEHFJGPNFA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x61C0570", Offset = "0x61BF370", VA = "0x1861C0570")]
	public static JOCECCOMCPM LJOKGFFEJKK([In] this Vector2 PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x61C05E0", Offset = "0x61BF3E0", VA = "0x1861C05E0")]
	public static Vector2 NLOFGFEMKNI(this JOCECCOMCPM PECKHAMCEFO)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class IJIJDHFPJDK
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x61C06D0", Offset = "0x61BF4D0", VA = "0x1861C06D0")]
	public static LOLIBLABPPK LJOKGFFEJKK([In] this Vector3 PECKHAMCEFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x61C0740", Offset = "0x61BF540", VA = "0x1861C0740")]
	public static Vector3 NLOFGFEMKNI(this LOLIBLABPPK PECKHAMCEFO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x61C0640", Offset = "0x61BF440", VA = "0x1861C0640")]
	public static Vector3? KHHICJHKHCK(this LOLIBLABPPK PECKHAMCEFO)
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
