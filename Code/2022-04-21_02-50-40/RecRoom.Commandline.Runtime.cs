using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KLJBIJDAGKM
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	private static string[] HDHPGKBMGJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x4BFFE10", Offset = "0x4BFEE10", VA = "0x184BFFE10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	private static string[] HIEDLOOBKLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x4BFFEF0", Offset = "0x4BFEEF0", VA = "0x184BFFEF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4BFFCD0", Offset = "0x4BFECD0", VA = "0x184BFFCD0")]
	public static string[] BEBPFALIBJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4BFFF50", Offset = "0x4BFEF50", VA = "0x184BFFF50")]
	public static string LLDMHKHGDAK(string ECLAHPAPGFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4BFFE20", Offset = "0x4BFEE20", VA = "0x184BFFE20")]
	public static bool JJMFALIJABL(string ECLAHPAPGFP)
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
