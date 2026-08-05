using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum AJCGOMPPHMI
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	MobileHome
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HKEMOEEFHKD
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private static string[] GMADCCGHLGM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static string[] IHKNDIPOLIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6643880", Offset = "0x6642680", VA = "0x186643880")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static string[] OKPDALGNGPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6643220", Offset = "0x6642020", VA = "0x186643220")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string[] BABIPPABEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66435F0", Offset = "0x66423F0", VA = "0x1866435F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6643280", Offset = "0x6642080", VA = "0x186643280")]
	public static string CFICDIDFEPC(string BECIDBICGOJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6643470", Offset = "0x6642270", VA = "0x186643470")]
	public static bool FFNEJDOJEMA(string BECIDBICGOJ)
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
