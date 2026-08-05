using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class PHGMOCBOLHL<TData> : GCLPBJOMDAE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LFPIMPJLAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData JLODENNJHEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0", Slot = "7")]
	public override string BKHNKMBHNFM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47026E0", Offset = "0x47012E0", VA = "0x1847026E0")]
	internal PHGMOCBOLHL(string JIMAFLGJGFB, [In] TData IMCLGJBJJKP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IJLOLNPFHHI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1FF3A20", Offset = "0x1FF2620", VA = "0x181FF3A20")]
	public static PHGMOCBOLHL<LOGIJBPEHJN> PPOPBMPFEOP(string JIMAFLGJGFB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x288AB30", Offset = "0x2889730", VA = "0x18288AB30")]
	public static PHGMOCBOLHL<TData> PPOPBMPFEOP<TData>(string JIMAFLGJGFB, [In] TData IMCLGJBJJKP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NFJKNELLAML
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C9EC30", Offset = "0x2C9D830", VA = "0x182C9EC30")]
	public static GFFELLBKJIA<TOk, DCMKOJFPDPC> JFCKDKINLON<TOk>([In] this GFFELLBKJIA<TOk, DCMKOJFPDPC> HNFMOHFACKF, string JIMAFLGJGFB)
	{
		return default(GFFELLBKJIA<TOk, DCMKOJFPDPC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GCLPBJOMDAE : DICIKJENGEG, DCMKOJFPDPC, NKGCJHELBDN
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FB2E70", Offset = "0x1FB1A70", VA = "0x181FB2E70")]
	protected GCLPBJOMDAE()
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
