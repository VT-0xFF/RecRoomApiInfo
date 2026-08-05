using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BOMANNLJDHN<TData> : CPLGHNODHNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OMMMEOELCAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LHCDIJPGOMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x78DFF0", Offset = "0x78CDF0", VA = "0x18078DFF0", Slot = "7")]
	public override string EFDGLBEJKDO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x46B9BF0", Offset = "0x46B89F0", VA = "0x1846B9BF0")]
	internal BOMANNLJDHN(string EKPMNNKLPFJ, [In] TData HKPHNGEBIED)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AEOBKBAMMEL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EF80", Offset = "0x1D5DD80", VA = "0x181D5EF80")]
	public static BOMANNLJDHN<BCBPFABBCDG> DCPHPAHCOGO(string EKPMNNKLPFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x24082C0", Offset = "0x24070C0", VA = "0x1824082C0")]
	public static BOMANNLJDHN<TData> DCPHPAHCOGO<TData>(string EKPMNNKLPFJ, [In] TData HKPHNGEBIED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MPAMLKBBBEB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x26A6080", Offset = "0x26A4E80", VA = "0x1826A6080")]
	public static CGKJAMMICEF<TOk, EPHFBGIJLJH> MCKPONJCPCP<TOk>([In] this CGKJAMMICEF<TOk, EPHFBGIJLJH> OJFDNDCDDBK, string EKPMNNKLPFJ)
	{
		return default(CGKJAMMICEF<TOk, EPHFBGIJLJH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class CPLGHNODHNJ : HFGDJMMINEP, EPHFBGIJLJH, KPPOPJKBMGO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D27DE0", Offset = "0x1D26BE0", VA = "0x181D27DE0")]
	protected CPLGHNODHNJ()
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
