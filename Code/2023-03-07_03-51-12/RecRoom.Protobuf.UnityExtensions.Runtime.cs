using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GJJDNPANILE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A66CF0", Offset = "0x1A660F0", VA = "0x181A66CF0")]
	public static EGDJIKNCCKI DGECGJPLFOM(this in Color COBPFFJEBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A66C90", Offset = "0x1A66090", VA = "0x181A66C90")]
	public static Color AHLFMBEKFNG(this EGDJIKNCCKI COBPFFJEBON)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A66D70", Offset = "0x1A66170", VA = "0x181A66D70")]
	public static Color? NJINKCAHECP(this EGDJIKNCCKI COBPFFJEBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GCNBPPAMNIL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A66B00", Offset = "0x1A65F00", VA = "0x181A66B00")]
	public static Quaternion MFFILMFKMIC(CBPBELAMAJJ MPEBBGJJODN)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A66A60", Offset = "0x1A65E60", VA = "0x181A66A60")]
	public static DKGFEGFJHIJ KKGBIBAGNNH(Quaternion LMIGPMLHAJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1A669F0", Offset = "0x1A65DF0", VA = "0x181A669F0")]
	public static Quaternion KIDMNHPAPGH(DKGFEGFJHIJ MPEBBGJJODN)
	{
		return default(Quaternion);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PMECABHJLAG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1A66FE0", Offset = "0x1A663E0", VA = "0x181A66FE0")]
	public static PJPHDBCKKDE DGECGJPLFOM(this in Quaternion COBPFFJEBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1A66F80", Offset = "0x1A66380", VA = "0x181A66F80")]
	public static Quaternion AHLFMBEKFNG(this PJPHDBCKKDE COBPFFJEBON)
	{
		return default(Quaternion);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1A67060", Offset = "0x1A66460", VA = "0x181A67060")]
	public static Quaternion? NJINKCAHECP(this PJPHDBCKKDE COBPFFJEBON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MHGFFEONBBL
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1A66E80", Offset = "0x1A66280", VA = "0x181A66E80")]
	public static DKGFEGFJHIJ DGECGJPLFOM(this in Vector3 COBPFFJEBON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1A66E30", Offset = "0x1A66230", VA = "0x181A66E30")]
	public static Vector3 AHLFMBEKFNG(this DKGFEGFJHIJ COBPFFJEBON)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1A66EF0", Offset = "0x1A662F0", VA = "0x181A66EF0")]
	public static Vector3? NJINKCAHECP(this DKGFEGFJHIJ COBPFFJEBON)
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
