using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KLIFPNHMDFC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x827DE80", Offset = "0x827C680", VA = "0x18827DE80")]
	public static AEBBLFKMOCN LIJGMGKAKKG([In] this Color NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x827DF00", Offset = "0x827C700", VA = "0x18827DF00")]
	public static Color MPBEICGIKAG(this AEBBLFKMOCN NFOGFJOGLPE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x827DE00", Offset = "0x827C600", VA = "0x18827DE00")]
	public static Color? JCCFFBNDBEC(this AEBBLFKMOCN NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IOGPBGOKOFC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x827D830", Offset = "0x827C030", VA = "0x18827D830")]
	public static Quaternion FCLIMLFIPDP(HLOAEMBECML NFNBKNAJBPN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x827DA40", Offset = "0x827C240", VA = "0x18827DA40")]
	public static HABMDKDGKDC HPDKDBKLBKE(Quaternion GJHLLDBJLDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x827DB30", Offset = "0x827C330", VA = "0x18827DB30")]
	public static Quaternion NFNLLLEPCNG(HABMDKDGKDC NFNBKNAJBPN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FFFBGLNNAMJ
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x827D670", Offset = "0x827BE70", VA = "0x18827D670")]
	public static HNDPGGLLPHO LIJGMGKAKKG([In] this Quaternion NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x827D6F0", Offset = "0x827BEF0", VA = "0x18827D6F0")]
	public static Quaternion MPBEICGIKAG(this HNDPGGLLPHO NFOGFJOGLPE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x827D5D0", Offset = "0x827BDD0", VA = "0x18827D5D0")]
	public static Quaternion? JCCFFBNDBEC(this HNDPGGLLPHO NFOGFJOGLPE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GPANDAOEBAK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x827D760", Offset = "0x827BF60", VA = "0x18827D760")]
	public static BLDANHJAEOK LIJGMGKAKKG([In] this Vector2 NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x827D7D0", Offset = "0x827BFD0", VA = "0x18827D7D0")]
	public static Vector2 MPBEICGIKAG(this BLDANHJAEOK NFOGFJOGLPE)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class JICGOLIGIBA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x827DD20", Offset = "0x827C520", VA = "0x18827DD20")]
	public static HABMDKDGKDC LIJGMGKAKKG([In] this Vector3 NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x827DBD0", Offset = "0x827C3D0", VA = "0x18827DBD0")]
	public static HABMDKDGKDC AELOAHDOILA([In] this Vector3? NFOGFJOGLPE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x827DD90", Offset = "0x827C590", VA = "0x18827DD90")]
	public static Vector3 MPBEICGIKAG(this HABMDKDGKDC NFOGFJOGLPE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x827DC90", Offset = "0x827C490", VA = "0x18827DC90")]
	public static Vector3? JCCFFBNDBEC(this HABMDKDGKDC NFOGFJOGLPE)
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
