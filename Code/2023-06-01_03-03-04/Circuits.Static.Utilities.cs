using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class EJGLEHOMCMJ : CMPFHAIKIAN, HECNFFAEBGF, NKLELKIHOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3939710", Offset = "0x3938310", VA = "0x183939710")]
	protected EJGLEHOMCMJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class HKKGCGLBBBM<TData> : EJGLEHOMCMJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LPOICJAAKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PFNMBPHLPKL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7F5DB0", Offset = "0x7F49B0", VA = "0x1807F5DB0", Slot = "7")]
	public override string AFLBGGMHEAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2E77810", Offset = "0x2E76410", VA = "0x182E77810")]
	internal HKKGCGLBBBM(string DKIECHCHJFL, in TData PHBHEFAPHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KDLLFLDGMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FFA850", Offset = "0x6FF9450", VA = "0x186FFA850")]
	public static HKKGCGLBBBM<DPIJIKFEAOC> DOBPLOGGNLM(string DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1E0EFE0", Offset = "0x1E0DBE0", VA = "0x181E0EFE0")]
	public static HKKGCGLBBBM<TData> DOBPLOGGNLM<TData>(string DKIECHCHJFL, in TData PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HNNGMBNHCPE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x291D3B0", Offset = "0x291BFB0", VA = "0x18291D3B0")]
	public static PKJAENHCLMN<TOk, HECNFFAEBGF> ADJBJGGGIDL<TOk>(this in PKJAENHCLMN<TOk, HECNFFAEBGF> GPOCLJBKMHA, string DKIECHCHJFL)
	{
		return default(PKJAENHCLMN<TOk, HECNFFAEBGF>);
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
