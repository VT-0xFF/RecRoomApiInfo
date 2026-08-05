using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CPGHIMNJAIC<TData> : BKLKNEGKHFP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LPKINLJAGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData NCHGGNHAEAG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x761890", Offset = "0x760690", VA = "0x180761890", Slot = "7")]
	public override string KJDIEKJIOOI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4A3AEC0", Offset = "0x4A39CC0", VA = "0x184A3AEC0")]
	internal CPGHIMNJAIC(string BLAOEBOMGGP, [In] TData LMCJHCIOIIP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class CGBIDMDJDLP
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1CAA5B0", Offset = "0x1CA93B0", VA = "0x181CAA5B0")]
	public static CPGHIMNJAIC<NENNLMOAGAP> IGHHFGMBDIH(string BLAOEBOMGGP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x21EDE40", Offset = "0x21ECC40", VA = "0x1821EDE40")]
	public static CPGHIMNJAIC<TData> IGHHFGMBDIH<TData>(string BLAOEBOMGGP, [In] TData LMCJHCIOIIP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GGKCNLGCINC
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x239B460", Offset = "0x239A260", VA = "0x18239B460")]
	public static FEBPNEDDNDE<TOk, KBBJHNEEOGJ> BDBLDIEJEHB<TOk>([In] this FEBPNEDDNDE<TOk, KBBJHNEEOGJ> PECKHAMCEFO, string BLAOEBOMGGP)
	{
		return default(FEBPNEDDNDE<TOk, KBBJHNEEOGJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BKLKNEGKHFP : DBMNCLOBEEI, KBBJHNEEOGJ, NEBNMHPBDBO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C75390", Offset = "0x1C74190", VA = "0x181C75390")]
	protected BKLKNEGKHFP()
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
