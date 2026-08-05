using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LGAKHNMIDJA
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x751AE10", Offset = "0x7519E10", VA = "0x18751AE10")]
	public static DDOEECMBGGE EKFEJLFJOKC([In] this Color GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x751AE90", Offset = "0x7519E90", VA = "0x18751AE90")]
	public static Color OGCNNFLPKKP(this DDOEECMBGGE GFJPFDOHONG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x751AD90", Offset = "0x7519D90", VA = "0x18751AD90")]
	public static Color? DOMBPFJCLPI(this DDOEECMBGGE GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class FBFLDKNELDE
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x751A9F0", Offset = "0x75199F0", VA = "0x18751A9F0")]
	public static Quaternion BFEODLJDDKB(CHNKLKAIBCG CONAFKKIHKL)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x751AC00", Offset = "0x7519C00", VA = "0x18751AC00")]
	public static CBCOEAIHLIM DNPNKOKKJEM(Quaternion FLFIIKKIKBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x751ACF0", Offset = "0x7519CF0", VA = "0x18751ACF0")]
	public static Quaternion OLGDAFAGJPI(CBCOEAIHLIM CONAFKKIHKL)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NFPJBGCGAOG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x751B190", Offset = "0x751A190", VA = "0x18751B190")]
	public static AJGCLHOCMLP EKFEJLFJOKC([In] this Quaternion GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x751B210", Offset = "0x751A210", VA = "0x18751B210")]
	public static Quaternion OGCNNFLPKKP(this AJGCLHOCMLP GFJPFDOHONG)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x751B0F0", Offset = "0x751A0F0", VA = "0x18751B0F0")]
	public static Quaternion? DOMBPFJCLPI(this AJGCLHOCMLP GFJPFDOHONG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AAAMMBAPBMC
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x751A920", Offset = "0x7519920", VA = "0x18751A920")]
	public static FNIIAKMNMJF EKFEJLFJOKC([In] this Vector2 GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x751A990", Offset = "0x7519990", VA = "0x18751A990")]
	public static Vector2 OGCNNFLPKKP(this FNIIAKMNMJF GFJPFDOHONG)
	{
		return default(Vector2);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class LLKFOKBDNKH
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x751AF50", Offset = "0x7519F50", VA = "0x18751AF50")]
	public static CBCOEAIHLIM EKFEJLFJOKC([In] this Vector3 GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x751AFC0", Offset = "0x7519FC0", VA = "0x18751AFC0")]
	public static CBCOEAIHLIM GFFMEJJOPBJ([In] this Vector3? GFJPFDOHONG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x751B080", Offset = "0x751A080", VA = "0x18751B080")]
	public static Vector3 OGCNNFLPKKP(this CBCOEAIHLIM GFJPFDOHONG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x751AEC0", Offset = "0x7519EC0", VA = "0x18751AEC0")]
	public static Vector3? DOMBPFJCLPI(this CBCOEAIHLIM GFJPFDOHONG)
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
