using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LBIOBBOHLNG<TData> : AFKOMGPKGOP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PBNAJPAMGFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData NALKPJHJPDB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6DF0C0", Offset = "0x6DE0C0", VA = "0x1806DF0C0", Slot = "5")]
	public override string IGONAKBOEBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x20A8650", Offset = "0x20A7650", VA = "0x1820A8650")]
	internal LBIOBBOHLNG(string GOMILMNIGIC, in TData FNIHENPLJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EDNPJJEPKNN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xEA05E0", Offset = "0xE9F5E0", VA = "0x180EA05E0")]
	public static global::LBIOBBOHLNG<ADEHAJBPFKB> CCFMECMIHDM(string GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x17645B0", Offset = "0x17635B0", VA = "0x1817645B0")]
	public static global::LBIOBBOHLNG<TData> CCFMECMIHDM<TData>(string GOMILMNIGIC, in TData FNIHENPLJHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class AFKOMGPKGOP : NAHHJACPAFG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEA05D0", Offset = "0xE9F5D0", VA = "0x180EA05D0")]
	protected AFKOMGPKGOP()
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
