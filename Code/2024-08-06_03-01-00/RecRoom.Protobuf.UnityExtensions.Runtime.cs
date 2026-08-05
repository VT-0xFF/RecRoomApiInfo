using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JGHOKAHDOOO
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FE94B0", Offset = "0x6FE7AB0", VA = "0x186FE94B0")]
	public static ELLGADBMFPC ALGEABNCNAB([In] this Color ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9530", Offset = "0x6FE7B30", VA = "0x186FE9530")]
	public static Color DIPBOAAMMJI(this ELLGADBMFPC ELMHNMGFNPC)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9560", Offset = "0x6FE7B60", VA = "0x186FE9560")]
	public static Color? HKJAHKEHJBB(this ELLGADBMFPC ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PBFNBADLGPP
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9680", Offset = "0x6FE7C80", VA = "0x186FE9680")]
	public static Quaternion JHIILKACNOK(MFIEKCAPAIA JHLEMCFOEMF)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9890", Offset = "0x6FE7E90", VA = "0x186FE9890")]
	public static OMACIFGAGCF KCPJDKECMPI(Quaternion OMMOHJCNJBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FE95E0", Offset = "0x6FE7BE0", VA = "0x186FE95E0")]
	public static Quaternion DAILDMFNODA(OMACIFGAGCF JHLEMCFOEMF)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ALNGPGAAGNM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FE90E0", Offset = "0x6FE76E0", VA = "0x186FE90E0")]
	public static HJLOPPGAHKM ALGEABNCNAB([In] this Quaternion ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9160", Offset = "0x6FE7760", VA = "0x186FE9160")]
	public static Quaternion DIPBOAAMMJI(this HJLOPPGAHKM ELMHNMGFNPC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FE91D0", Offset = "0x6FE77D0", VA = "0x186FE91D0")]
	public static Quaternion? HKJAHKEHJBB(this HJLOPPGAHKM ELMHNMGFNPC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FBOEFCBGMIE
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9270", Offset = "0x6FE7870", VA = "0x186FE9270")]
	public static NFIDMOKFGHM ALGEABNCNAB([In] this Vector2 ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FE92E0", Offset = "0x6FE78E0", VA = "0x186FE92E0")]
	public static Vector2 DIPBOAAMMJI(this NFIDMOKFGHM ELMHNMGFNPC)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class GGNEKCIAPHA
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9340", Offset = "0x6FE7940", VA = "0x186FE9340")]
	public static OMACIFGAGCF ALGEABNCNAB([In] this Vector3 ELMHNMGFNPC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FE93B0", Offset = "0x6FE79B0", VA = "0x186FE93B0")]
	public static Vector3 DIPBOAAMMJI(this OMACIFGAGCF ELMHNMGFNPC)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6FE9420", Offset = "0x6FE7A20", VA = "0x186FE9420")]
	public static Vector3? HKJAHKEHJBB(this OMACIFGAGCF ELMHNMGFNPC)
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
