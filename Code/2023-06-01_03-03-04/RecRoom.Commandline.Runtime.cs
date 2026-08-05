using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum IMNHIJEJNHL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MFHKJJGPNBN
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] EKAPEMNFOBF;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static string[] HNGBACNAPOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6FF9620", Offset = "0x6FF8220", VA = "0x186FF9620")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static string[] FMELGFKJEHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6FF95C0", Offset = "0x6FF81C0", VA = "0x186FF95C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string[] DGMEGLFIBNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6FF91B0", Offset = "0x6FF7DB0", VA = "0x186FF91B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9630", Offset = "0x6FF8230", VA = "0x186FF9630")]
	public static string MFMJIPEJAII(string ECGMNPFIIPH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FF9440", Offset = "0x6FF8040", VA = "0x186FF9440")]
	public static bool CLGNCDNNEKE(string ECGMNPFIIPH)
	{
		return default(bool);
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
