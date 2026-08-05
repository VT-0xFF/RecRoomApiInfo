using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class EJGLEHOMCMJ : CMPFHAIKIAN, HECNFFAEBGF, NKLELKIHOJN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x3B34650", Offset = "0x3B33250", VA = "0x183B34650")]
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
	[Cpp2IlInjected.Address(RVA = "0x7F2DB0", Offset = "0x7F19B0", VA = "0x1807F2DB0", Slot = "7")]
	public override string AFLBGGMHEAF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2EC2BE0", Offset = "0x2EC17E0", VA = "0x182EC2BE0")]
	internal HKKGCGLBBBM(string DKIECHCHJFL, in TData PHBHEFAPHDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KDLLFLDGMKB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FDC6C0", Offset = "0x6FDB2C0", VA = "0x186FDC6C0")]
	public static global::HKKGCGLBBBM<DPIJIKFEAOC> DOBPLOGGNLM(string DKIECHCHJFL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x202C230", Offset = "0x202AE30", VA = "0x18202C230")]
	public static global::HKKGCGLBBBM<TData> DOBPLOGGNLM<TData>(string DKIECHCHJFL, in TData PHBHEFAPHDL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HNNGMBNHCPE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2B7DAA0", Offset = "0x2B7C6A0", VA = "0x182B7DAA0")]
	public static global::PKJAENHCLMN<TOk, HECNFFAEBGF> ADJBJGGGIDL<TOk>(this in global::PKJAENHCLMN<TOk, HECNFFAEBGF> GPOCLJBKMHA, string DKIECHCHJFL)
	{
		return default(global::PKJAENHCLMN<TOk, HECNFFAEBGF>);
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
