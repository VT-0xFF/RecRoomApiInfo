using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EILCCPDIMMN<TData> : MCNPHLHCLED
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string BGIMHHCKDPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData NOKLNLDMACL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA0EBC0", Offset = "0xA0D9C0", VA = "0x180A0EBC0", Slot = "7")]
	public override string EEHOEKHGKPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x460B680", Offset = "0x460A480", VA = "0x18460B680")]
	internal EILCCPDIMMN(string NJJDPBHNDPA, [In] TData FFEMKICJPKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class DKAOGFDHCMI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28988A0", Offset = "0x28976A0", VA = "0x1828988A0")]
	public static EILCCPDIMMN<NICNPLCGCEF> NBEICDCLFEE(string NJJDPBHNDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x371BB90", Offset = "0x371A990", VA = "0x18371BB90")]
	public static EILCCPDIMMN<TData> NBEICDCLFEE<TData>(string NJJDPBHNDPA, [In] TData FFEMKICJPKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KKAKHCOFCOH
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x39D79B0", Offset = "0x39D67B0", VA = "0x1839D79B0")]
	public static JKEBLLKKBOM<TOk, CHEIGOJMDOJ> NAMLJKFKLNF<TOk>([In] this JKEBLLKKBOM<TOk, CHEIGOJMDOJ> FPFHIDBMBMI, string NJJDPBHNDPA)
	{
		return default(JKEBLLKKBOM<TOk, CHEIGOJMDOJ>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MCNPHLHCLED : DDPPOHMMKFK, CHEIGOJMDOJ, LPPJEHMJDEA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2853280", Offset = "0x2852080", VA = "0x182853280")]
	protected MCNPHLHCLED()
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
