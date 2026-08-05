using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LEDKIPMICOC
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7478E90", Offset = "0x7477890", VA = "0x187478E90")]
	public static IHAIEOGIPCH HLGBFIEHJDG([In] this Color PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7478E60", Offset = "0x7477860", VA = "0x187478E60")]
	public static Color DLDAMIHNNNK(this IHAIEOGIPCH PCBICLOONMH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7478DE0", Offset = "0x74777E0", VA = "0x187478DE0")]
	public static Color? BCGFIMCHEKD(this IHAIEOGIPCH PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AJIELCDMMMF
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7478740", Offset = "0x7477140", VA = "0x187478740")]
	public static Quaternion KEEEKKNPHEL(KCMDLGBCHDF GGEMPJLCHFC)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x74785B0", Offset = "0x7476FB0", VA = "0x1874785B0")]
	public static GIADMFMGJPA FEOOJLLFPHH(Quaternion NHMKAMHDKLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x74786A0", Offset = "0x74770A0", VA = "0x1874786A0")]
	public static Quaternion FHHDJLPJOMI(GIADMFMGJPA GGEMPJLCHFC)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HKHPLEFPPCN
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7478C90", Offset = "0x7477690", VA = "0x187478C90")]
	public static JHONMBMIGAH HLGBFIEHJDG([In] this Quaternion PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7478C20", Offset = "0x7477620", VA = "0x187478C20")]
	public static Quaternion DLDAMIHNNNK(this JHONMBMIGAH PCBICLOONMH)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7478B80", Offset = "0x7477580", VA = "0x187478B80")]
	public static Quaternion? BCGFIMCHEKD(this JHONMBMIGAH PCBICLOONMH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JPJCIBDIHKH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7478D70", Offset = "0x7477770", VA = "0x187478D70")]
	public static BCMLJMDENLH HLGBFIEHJDG([In] this Vector2 PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7478D10", Offset = "0x7477710", VA = "0x187478D10")]
	public static Vector2 DLDAMIHNNNK(this BCMLJMDENLH PCBICLOONMH)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class EOJDDIGPCPF
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7478A50", Offset = "0x7477450", VA = "0x187478A50")]
	public static GIADMFMGJPA HLGBFIEHJDG([In] this Vector3 PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7478AC0", Offset = "0x74774C0", VA = "0x187478AC0")]
	public static GIADMFMGJPA JKNCGHFLMBJ([In] this Vector3? PCBICLOONMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x74789E0", Offset = "0x74773E0", VA = "0x1874789E0")]
	public static Vector3 DLDAMIHNNNK(this GIADMFMGJPA PCBICLOONMH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7478950", Offset = "0x7477350", VA = "0x187478950")]
	public static Vector3? BCGFIMCHEKD(this GIADMFMGJPA PCBICLOONMH)
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
