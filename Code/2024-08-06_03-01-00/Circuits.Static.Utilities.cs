using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BODCHNKHIEI<TData> : LPFOGJHKMBP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string BILHBHGOAAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LFHGEGNPGJE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x85F4F0", Offset = "0x85DAF0", VA = "0x18085F4F0", Slot = "7")]
	public override string DLMCGACMBKO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4F371B0", Offset = "0x4F357B0", VA = "0x184F371B0")]
	internal BODCHNKHIEI(string DICMABMCPKO, [In] TData JHLEMCFOEMF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DEAOLLDIOPE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2048AB0", Offset = "0x20470B0", VA = "0x182048AB0")]
	public static BODCHNKHIEI<DHABIOOJNOJ> NKOJKFHACJH(string DICMABMCPKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2972330", Offset = "0x2970930", VA = "0x182972330")]
	public static BODCHNKHIEI<TData> NKOJKFHACJH<TData>(string DICMABMCPKO, [In] TData JHLEMCFOEMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BELIDKPPHFM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x28F95B0", Offset = "0x28F7BB0", VA = "0x1828F95B0")]
	public static HHANDHIMCMH<TOk, LOIFPCPCONK> KCKJJNAIKIK<TOk>([In] this HHANDHIMCMH<TOk, LOIFPCPCONK> ELMHNMGFNPC, string DICMABMCPKO)
	{
		return default(HHANDHIMCMH<TOk, LOIFPCPCONK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LPFOGJHKMBP : EKHHLAEJNGE, LOIFPCPCONK, PFOLFPHIKGH
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20096C0", Offset = "0x2007CC0", VA = "0x1820096C0")]
	protected LPFOGJHKMBP()
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
