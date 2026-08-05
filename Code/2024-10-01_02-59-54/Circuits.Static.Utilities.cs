using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class HIGDOHCMFEB<TData> : FLDDNKNCPHH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string APMJJEAFGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData BAFNFCIODAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "7")]
	public override string KIGPPELGDEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x408E950", Offset = "0x408DD50", VA = "0x18408E950")]
	internal HIGDOHCMFEB(string ADPAIBGIHMB, [In] TData MPMEGOKIEPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HHEMJACLLIJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22974A0", Offset = "0x22968A0", VA = "0x1822974A0")]
	public static HIGDOHCMFEB<OKFEIOHLOGM> AALKPJMFIHM(string ADPAIBGIHMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDC10", Offset = "0x2BED010", VA = "0x182BEDC10")]
	public static HIGDOHCMFEB<TData> AALKPJMFIHM<TData>(string ADPAIBGIHMB, [In] TData MPMEGOKIEPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FBGONKLFMEE
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2E378F0", Offset = "0x2E36CF0", VA = "0x182E378F0")]
	public static MLIDCCDLMIE<TOk, FNDOAGAGANG> ACIBNHDKBNJ<TOk>([In] this MLIDCCDLMIE<TOk, FNDOAGAGANG> MBGHIKEGJAA, string ADPAIBGIHMB)
	{
		return default(MLIDCCDLMIE<TOk, FNDOAGAGANG>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FLDDNKNCPHH : IDBHBLPOJHF, FNDOAGAGANG, JPHFAKFKMJL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2257ED0", Offset = "0x22572D0", VA = "0x182257ED0")]
	protected FLDDNKNCPHH()
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
