using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PMGKICPCENI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string PBHOHNDLFMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x69F9FF0", Offset = "0x69F85F0", VA = "0x1869F9FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string COPANHBHENH
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x69FA0F0", Offset = "0x69F86F0", VA = "0x1869FA0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public static string IKDABKHOFDM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x69FA0F0", Offset = "0x69F86F0", VA = "0x1869FA0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static string COGGJPBBANK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x69F9FF0", Offset = "0x69F85F0", VA = "0x1869F9FF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69F9F10", Offset = "0x69F8510", VA = "0x1869F9F10")]
	private static string BDBCNIDDGAC(string ILDIFEDDEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69F9F70", Offset = "0x69F8570", VA = "0x1869F9F70")]
	public static void CLILBPCBPDJ(string ILDIFEDDEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69FA000", Offset = "0x69F8600", VA = "0x1869FA000")]
	public static bool FPHGEPCNGKB(string ILDIFEDDEBK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x69FA070", Offset = "0x69F8670", VA = "0x1869FA070")]
	public static void GDMOGIPADMP(string ILDIFEDDEBK, string MMDLBEBNCGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x69FA170", Offset = "0x69F8770", VA = "0x1869FA170")]
	public static string KHHGABIPCIG(string ILDIFEDDEBK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x69FA100", Offset = "0x69F8700", VA = "0x1869FA100")]
	public static void JIBDHGADJKB(string ILDIFEDDEBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x867790", Offset = "0x865D90", VA = "0x180867790")]
	private static void KKMJAHPLEAN()
	{
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
