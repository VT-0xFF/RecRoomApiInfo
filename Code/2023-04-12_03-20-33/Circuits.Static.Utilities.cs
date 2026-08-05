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
	[Cpp2IlInjected.Address(RVA = "0x6E00C0", Offset = "0x6DF4C0", VA = "0x1806E00C0", Slot = "5")]
	public override string IGONAKBOEBA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26B16F0", Offset = "0x26B0AF0", VA = "0x1826B16F0")]
	internal LBIOBBOHLNG(string GOMILMNIGIC, in TData FNIHENPLJHK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class EDNPJJEPKNN
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xEA5840", Offset = "0xEA4C40", VA = "0x180EA5840")]
	public static global::LBIOBBOHLNG<ADEHAJBPFKB> CCFMECMIHDM(string GOMILMNIGIC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E69290", Offset = "0x1E68690", VA = "0x181E69290")]
	public static global::LBIOBBOHLNG<TData> CCFMECMIHDM<TData>(string GOMILMNIGIC, in TData FNIHENPLJHK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public abstract class AFKOMGPKGOP : NAHHJACPAFG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xEA5830", Offset = "0xEA4C30", VA = "0x180EA5830")]
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
