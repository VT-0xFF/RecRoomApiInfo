using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class EFMPBCAAJAD : BNAKFCOEFAL, EKJAOIMOODA, BONKIFBLCIE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2E34350", Offset = "0x2E32950", VA = "0x182E34350")]
	protected EFMPBCAAJAD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class EDEFJGPFMCH<TData> : EFMPBCAAJAD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string APNBCBOBIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData JEFFIAODLOM;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7ED620", Offset = "0x7EBC20", VA = "0x1807ED620", Slot = "7")]
	public override string KDCKINHCHKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x23DC730", Offset = "0x23DAD30", VA = "0x1823DC730")]
	internal EDEFJGPFMCH(string DPAJDIEBNKM, in TData JAIGDBINGHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AFJKGKNKJBL
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FFE5A0", Offset = "0x6FFCBA0", VA = "0x186FFE5A0")]
	public static EDEFJGPFMCH<CMCGOMMIJLE> OGNDBCBGIDA(string DPAJDIEBNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xE17E60", Offset = "0xE16460", VA = "0x180E17E60")]
	public static EDEFJGPFMCH<TData> OGNDBCBGIDA<TData>(string DPAJDIEBNKM, in TData JAIGDBINGHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IGFLAFIKFKM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x11D57A0", Offset = "0x11D3DA0", VA = "0x1811D57A0")]
	public static GLOEKJIOMHK<TOk, EKJAOIMOODA> NIKLLKNIMDM<TOk>(this in GLOEKJIOMHK<TOk, EKJAOIMOODA> CDBMADFDGCE, string DPAJDIEBNKM)
	{
		return default(GLOEKJIOMHK<TOk, EKJAOIMOODA>);
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
