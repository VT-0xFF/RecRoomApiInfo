using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BKCMKFDPAHA<TData> : DCAIIPHPGFM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string IGNKIAJJGLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AKBOOJDMDHH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA864F0", Offset = "0xA84EF0", VA = "0x180A864F0", Slot = "7")]
	public override string GIDIGOEEAJA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x65A1E60", Offset = "0x65A0860", VA = "0x1865A1E60")]
	internal BKCMKFDPAHA(string ONGDPODJNBL, [In] TData GPCDCFCPGFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GJHEKNGCKNK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2ADC590", Offset = "0x2ADAF90", VA = "0x182ADC590")]
	public static BKCMKFDPAHA<FAIGCFGAAKD> MDDJOGPLAFO(string ONGDPODJNBL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3AD8CA0", Offset = "0x3AD76A0", VA = "0x183AD8CA0")]
	public static BKCMKFDPAHA<TData> MDDJOGPLAFO<TData>(string ONGDPODJNBL, [In] TData GPCDCFCPGFK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AHCPFIGFPJP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31C9DA0", Offset = "0x31C87A0", VA = "0x1831C9DA0")]
	public static DOHEMIFBILP<TOk, EFLLFLJPHFD> FOPNKELAFFP<TOk>([In] this DOHEMIFBILP<TOk, EFLLFLJPHFD> NLDLHIJAJBO, string ONGDPODJNBL)
	{
		return default(DOHEMIFBILP<TOk, EFLLFLJPHFD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DCAIIPHPGFM : OGOHDADDIPM, EFLLFLJPHFD, NHMKHEEENDM
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2A94B90", Offset = "0x2A93590", VA = "0x182A94B90")]
	protected DCAIIPHPGFM()
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
