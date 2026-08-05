using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JKIEMLBNGEK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x636F230", Offset = "0x636E230", VA = "0x18636F230")]
	public static OLICENHAEAB KJONJHMMAMK([In] this Color IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x636F200", Offset = "0x636E200", VA = "0x18636F200")]
	public static Color AJBPOCIDFHA(this OLICENHAEAB IEOMMHOPOKN)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x636F2B0", Offset = "0x636E2B0", VA = "0x18636F2B0")]
	public static Color? NKDHBNGFCKA(this OLICENHAEAB IEOMMHOPOKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HMHLIGLJDPG
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x636EE50", Offset = "0x636DE50", VA = "0x18636EE50")]
	public static Quaternion BIEFFCIBMCO(DEPBDNGIAHM FCLEEDACIMH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x636F070", Offset = "0x636E070", VA = "0x18636F070")]
	public static EDKCPEMEICI EJLEECOIMPC(Quaternion OMEEHFMHMFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x636F160", Offset = "0x636E160", VA = "0x18636F160")]
	public static Quaternion OFMEFNPFCLF(EDKCPEMEICI FCLEEDACIMH)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HDJOMNIAHIO
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x636ED30", Offset = "0x636DD30", VA = "0x18636ED30")]
	public static JADOEBIMANM KJONJHMMAMK([In] this Quaternion IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x636ECC0", Offset = "0x636DCC0", VA = "0x18636ECC0")]
	public static Quaternion AJBPOCIDFHA(this JADOEBIMANM IEOMMHOPOKN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x636EDB0", Offset = "0x636DDB0", VA = "0x18636EDB0")]
	public static Quaternion? NKDHBNGFCKA(this JADOEBIMANM IEOMMHOPOKN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MMJGDEEGLKK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x636F500", Offset = "0x636E500", VA = "0x18636F500")]
	public static CHHOGJCODAI KJONJHMMAMK([In] this Vector2 IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x636F4A0", Offset = "0x636E4A0", VA = "0x18636F4A0")]
	public static Vector2 AJBPOCIDFHA(this CHHOGJCODAI IEOMMHOPOKN)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LIFCGCGNOOB
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x636F3A0", Offset = "0x636E3A0", VA = "0x18636F3A0")]
	public static EDKCPEMEICI KJONJHMMAMK([In] this Vector3 IEOMMHOPOKN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x636F330", Offset = "0x636E330", VA = "0x18636F330")]
	public static Vector3 AJBPOCIDFHA(this EDKCPEMEICI IEOMMHOPOKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x636F410", Offset = "0x636E410", VA = "0x18636F410")]
	public static Vector3? NKDHBNGFCKA(this EDKCPEMEICI IEOMMHOPOKN)
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
