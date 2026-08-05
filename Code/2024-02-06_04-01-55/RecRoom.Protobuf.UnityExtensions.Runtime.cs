using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LMJJDFAKKNE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x662EF50", Offset = "0x662E350", VA = "0x18662EF50")]
	public static GKPJJHHHJKE ILCGODJBNBA([In] this Color LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x662EFD0", Offset = "0x662E3D0", VA = "0x18662EFD0")]
	public static Color JCEFODEMOAF(this GKPJJHHHJKE LOMPFKEACIP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x662F000", Offset = "0x662E400", VA = "0x18662F000")]
	public static Color? MIEABOJMPEO(this GKPJJHHHJKE LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GGLDKPDEJBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x662EA30", Offset = "0x662DE30", VA = "0x18662EA30")]
	public static Quaternion CIEGNIAODKK(JMFLIPOPODC ALPLHOOHPEL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x662ECF0", Offset = "0x662E0F0", VA = "0x18662ECF0")]
	public static PJIIOKNBPNE PCDBNIBEHCG(Quaternion ANIADOHOIIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x662EC50", Offset = "0x662E050", VA = "0x18662EC50")]
	public static Quaternion GGMGBEAHFIL(PJIIOKNBPNE ALPLHOOHPEL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGANMCPPCNN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x662F150", Offset = "0x662E550", VA = "0x18662F150")]
	public static OHNNELMPCNF ILCGODJBNBA([In] this Quaternion LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x662F1D0", Offset = "0x662E5D0", VA = "0x18662F1D0")]
	public static Quaternion JCEFODEMOAF(this OHNNELMPCNF LOMPFKEACIP)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x662F240", Offset = "0x662E640", VA = "0x18662F240")]
	public static Quaternion? MIEABOJMPEO(this OHNNELMPCNF LOMPFKEACIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LPKFMFJHAPA
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x662F080", Offset = "0x662E480", VA = "0x18662F080")]
	public static GKGCKMMNKEB ILCGODJBNBA([In] this Vector2 LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x662F0F0", Offset = "0x662E4F0", VA = "0x18662F0F0")]
	public static Vector2 JCEFODEMOAF(this GKGCKMMNKEB LOMPFKEACIP)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class KCAKDBJDDMD
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x662EDE0", Offset = "0x662E1E0", VA = "0x18662EDE0")]
	public static PJIIOKNBPNE ILCGODJBNBA([In] this Vector3 LOMPFKEACIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x662EE50", Offset = "0x662E250", VA = "0x18662EE50")]
	public static Vector3 JCEFODEMOAF(this PJIIOKNBPNE LOMPFKEACIP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x662EEC0", Offset = "0x662E2C0", VA = "0x18662EEC0")]
	public static Vector3? MIEABOJMPEO(this PJIIOKNBPNE LOMPFKEACIP)
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
