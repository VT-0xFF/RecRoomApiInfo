using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DLAAIHDFCCP<TData> : BIDCBADFDJH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string JODIMDLOCOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PGHMPBDPLMA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x773420", Offset = "0x772020", VA = "0x180773420", Slot = "7")]
	public override string KDELHCHBOAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E4C740", Offset = "0x4E4B340", VA = "0x184E4C740")]
	internal DLAAIHDFCCP(string EOOPGFAEMIH, [In] TData IGJLGPELHOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GFBBFCJGHKH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D10E30", Offset = "0x1D0FA30", VA = "0x181D10E30")]
	public static DLAAIHDFCCP<JNKPKLDONNF> OOMHMBNJBCG(string EOOPGFAEMIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23810C0", Offset = "0x237FCC0", VA = "0x1823810C0")]
	public static DLAAIHDFCCP<TData> OOMHMBNJBCG<TData>(string EOOPGFAEMIH, [In] TData IGJLGPELHOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FMDKMJJDMFN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24E1B20", Offset = "0x24E0720", VA = "0x1824E1B20")]
	public static MEPDFJNPAPE<TOk, HEHIEEOHMHH> LDECHBFFAOF<TOk>([In] this MEPDFJNPAPE<TOk, HEHIEEOHMHH> HHHLENOMLMP, string EOOPGFAEMIH)
	{
		return default(MEPDFJNPAPE<TOk, HEHIEEOHMHH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BIDCBADFDJH : LGEMOLNFJEJ, HEHIEEOHMHH, KGBAABPCOOC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CDBA40", Offset = "0x1CDA640", VA = "0x181CDBA40")]
	protected BIDCBADFDJH()
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
