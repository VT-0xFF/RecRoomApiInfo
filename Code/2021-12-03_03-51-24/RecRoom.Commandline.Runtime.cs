using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OJOMJMHGDEE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static string[] PFPOIANIFLP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x3FA0A50", Offset = "0x3F9FC50", VA = "0x183FA0A50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0A50", Offset = "0x3F9FC50", VA = "0x183FA0A50")]
	public static string[] KICCLCOGGLH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0A60", Offset = "0x3F9FC60", VA = "0x183FA0A60")]
	public static string LEALGJBKPPK(string NHGMJCIJHCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3FA0B20", Offset = "0x3F9FD20", VA = "0x183FA0B20")]
	public static bool OBKGJGBHKDB(string NHGMJCIJHCF)
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
