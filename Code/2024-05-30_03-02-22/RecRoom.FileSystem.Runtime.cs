using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GGOIEKMHNMK
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public static string FGFHIMPCBMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x1E64330", Offset = "0x1E63530", VA = "0x181E64330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public static string DKAJGPPJPMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x63F0170", Offset = "0x63EF370", VA = "0x1863F0170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x63F0200", Offset = "0x63EF400", VA = "0x1863F0200")]
	private static string LNBAOAEBBKF(string JGJLFCNOJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x63F0180", Offset = "0x63EF380", VA = "0x1863F0180")]
	public static void LHAPHEGPCBA(string JGJLFCNOJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x63F0260", Offset = "0x63EF460", VA = "0x1863F0260")]
	public static bool MBPPMFOMLCH(string JGJLFCNOJON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x63F00F0", Offset = "0x63EF2F0", VA = "0x1863F00F0")]
	public static void BKMGOKFAGDM(string JGJLFCNOJON, string JLJKEBMIIPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x63F02D0", Offset = "0x63EF4D0", VA = "0x1863F02D0")]
	public static string NMDMJOPPEHH(string JGJLFCNOJON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x63F0340", Offset = "0x63EF540", VA = "0x1863F0340")]
	public static void PAGNNFBFNNA(string JGJLFCNOJON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0")]
	private static void BCFDKKONKPF()
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
