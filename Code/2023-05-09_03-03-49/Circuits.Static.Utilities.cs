using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OEOCIPEBPFO<TData> : NNOGOJMPBNO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PDFPEKEFLFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LAEHDPABEIH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750", Slot = "7")]
	public override string ODHCPOFFIEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2CC0", Offset = "0x3ED16C0", VA = "0x183ED2CC0")]
	internal OEOCIPEBPFO(string MDEEJIBNIAD, in TData MNILNHMNKJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NBMGIPEBBBD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E7C720", Offset = "0x1E7B120", VA = "0x181E7C720")]
	public static global::OEOCIPEBPFO<LEKKGHCNCEK> IDLIIDOEAFG(string MDEEJIBNIAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x30CB000", Offset = "0x30C9A00", VA = "0x1830CB000")]
	public static global::OEOCIPEBPFO<TData> IDLIIDOEAFG<TData>(string MDEEJIBNIAD, in TData MNILNHMNKJK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PFMHDFKHGDG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x393BF00", Offset = "0x393A900", VA = "0x18393BF00")]
	public static global::DAOEJNFJJPJ<TOk, PCIJMHLMKIF> NNEHKIFNDCD<TOk>(this in global::DAOEJNFJJPJ<TOk, PCIJMHLMKIF> IKHBPJOEIEB, string MDEEJIBNIAD)
	{
		return default(global::DAOEJNFJJPJ<TOk, PCIJMHLMKIF>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NNOGOJMPBNO : MIKMJPNAIIO, PCIJMHLMKIF, GEPHFINPONA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E50930", Offset = "0x1E4F330", VA = "0x181E50930")]
	protected NNOGOJMPBNO()
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
