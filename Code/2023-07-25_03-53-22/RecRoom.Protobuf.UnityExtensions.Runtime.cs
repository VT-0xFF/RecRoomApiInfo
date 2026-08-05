using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ANIKJHGLPIH
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7307190", Offset = "0x7306190", VA = "0x187307190")]
	public static JGKCNGMBNFG IKBIGFALLCH(this in Color FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x73070C0", Offset = "0x73060C0", VA = "0x1873070C0")]
	public static Color EILKNJCKJNI(this JGKCNGMBNFG FKGCCPKFEDE)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7307230", Offset = "0x7306230", VA = "0x187307230")]
	public static Color? JJGLKEDOHDG(this JGKCNGMBNFG FKGCCPKFEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GMINHDAHEKH
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7307420", Offset = "0x7306420", VA = "0x187307420")]
	public static MJNKBABECHI IKBIGFALLCH(this in Quaternion FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7307350", Offset = "0x7306350", VA = "0x187307350")]
	public static Quaternion EILKNJCKJNI(this MJNKBABECHI FKGCCPKFEDE)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x73074C0", Offset = "0x73064C0", VA = "0x1873074C0")]
	public static Quaternion? JJGLKEDOHDG(this MJNKBABECHI FKGCCPKFEDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KAEMDELCFDG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x73077D0", Offset = "0x73067D0", VA = "0x1873077D0")]
	public static Quaternion AJCHIMMMEFP(KNELPBEGIJL HHCEHFFEAKN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7307A80", Offset = "0x7306A80", VA = "0x187307A80")]
	public static FNBBBDLKJPG NOCIHFCPBBN(Quaternion EILOOLDIMGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x73079E0", Offset = "0x73069E0", VA = "0x1873079E0")]
	public static Quaternion HJADCAFEIOC(FNBBBDLKJPG HHCEHFFEAKN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JKELLGPPADH
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7307680", Offset = "0x7306680", VA = "0x187307680")]
	public static FNBBBDLKJPG IKBIGFALLCH(this in Vector3 FKGCCPKFEDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x73075E0", Offset = "0x73065E0", VA = "0x1873075E0")]
	public static Vector3 EILKNJCKJNI(this FNBBBDLKJPG FKGCCPKFEDE)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7307710", Offset = "0x7306710", VA = "0x187307710")]
	public static Vector3? JJGLKEDOHDG(this FNBBBDLKJPG FKGCCPKFEDE)
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
