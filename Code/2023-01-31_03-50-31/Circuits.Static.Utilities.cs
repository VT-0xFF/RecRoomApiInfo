using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DNPNIDOHOKI<TData> : LEGBELBGIHF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string ONMBFCNACCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData BJEGJENJPJG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B2570", Offset = "0x6B1370", VA = "0x1806B2570", Slot = "5")]
	public override string HDMGCOABJMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3ABAD60", Offset = "0x3AB9B60", VA = "0x183ABAD60")]
	internal DNPNIDOHOKI(string LMLMHJKGDCH, in TData FILAKGLBGGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PCPMAJDNFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2276F90", Offset = "0x2275D90", VA = "0x182276F90")]
	public static global::DNPNIDOHOKI<PEFLLNEDEOA> DHGKFEMNGCO(string LMLMHJKGDCH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class LEGBELBGIHF : AAHLPJGCFPM
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8DFD80", Offset = "0x8DEB80", VA = "0x1808DFD80")]
	protected LEGBELBGIHF()
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
