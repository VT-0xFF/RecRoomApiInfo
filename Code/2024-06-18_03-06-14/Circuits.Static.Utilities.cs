using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DNPMKEIOPPP<TData> : GACFHBDKGHN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IEFKBAHKOLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData MAOHOGCCNAD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x84EC60", Offset = "0x84D660", VA = "0x18084EC60", Slot = "7")]
	public override string BMFLCAMIMMJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x57D1E10", Offset = "0x57D0810", VA = "0x1857D1E10")]
	internal DNPMKEIOPPP(string BDCMABOIIFF, [In] TData EEOBDBMOHPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AOIJEOMJMKF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x200C290", Offset = "0x200AC90", VA = "0x18200C290")]
	public static DNPMKEIOPPP<LMMCANLFCCL> KHKANEAPNIK(string BDCMABOIIFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28BF6B0", Offset = "0x28BE0B0", VA = "0x1828BF6B0")]
	public static DNPMKEIOPPP<TData> KHKANEAPNIK<TData>(string BDCMABOIIFF, [In] TData EEOBDBMOHPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MLKPANONNPK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C0EB40", Offset = "0x2C0D540", VA = "0x182C0EB40")]
	public static FNBKHJCMJJM<TOk, AEFDHDNANIN> DJCJBDDNJJC<TOk>([In] this FNBKHJCMJJM<TOk, AEFDHDNANIN> BBCPNLGGBMJ, string BDCMABOIIFF)
	{
		return default(FNBKHJCMJJM<TOk, AEFDHDNANIN>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GACFHBDKGHN : DNHFHLFKGGH, AEFDHDNANIN, LHAJNHDLEEF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FCCF70", Offset = "0x1FCB970", VA = "0x181FCCF70")]
	protected GACFHBDKGHN()
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
