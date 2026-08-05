using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class LCAJDDJBNMC<TData> : CIPPKAIIPLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GMFKOEIGBMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData HBHDBEHHINN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA59870", Offset = "0xA58670", VA = "0x180A59870", Slot = "7")]
	public override string KMHKNGKODJN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5406610", Offset = "0x5405410", VA = "0x185406610")]
	internal LCAJDDJBNMC(string IIHOFBLPONF, [In] TData BOIPFNOKGBJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AKODKNLMPOG
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2A3E310", Offset = "0x2A3D110", VA = "0x182A3E310")]
	public static LCAJDDJBNMC<CIEOHCAKAMM> OGAKBGHEIKK(string IIHOFBLPONF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x311BE10", Offset = "0x311AC10", VA = "0x18311BE10")]
	public static LCAJDDJBNMC<TData> OGAKBGHEIKK<TData>(string IIHOFBLPONF, [In] TData BOIPFNOKGBJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NHPDAJMIIDB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3D0AE40", Offset = "0x3D09C40", VA = "0x183D0AE40")]
	public static CKPFCFEHEPP<TOk, FCJOMJLBDOM> MIICPLDBIIM<TOk>([In] this CKPFCFEHEPP<TOk, FCJOMJLBDOM> FEOFEEGOGIO, string IIHOFBLPONF)
	{
		return default(CKPFCFEHEPP<TOk, FCJOMJLBDOM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CIPPKAIIPLL : BHGDKCCPEDL, FCJOMJLBDOM, LJGAAONCGFM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x29F5EF0", Offset = "0x29F4CF0", VA = "0x1829F5EF0")]
	protected CIPPKAIIPLL()
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
