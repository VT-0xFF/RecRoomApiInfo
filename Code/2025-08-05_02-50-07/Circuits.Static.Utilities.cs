using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KJGMBEBNIJE<TData> : HHKNPNNAIPG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PBICDNNDDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData NMPPAMCHJMA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xA6D1F0", Offset = "0xA6C5F0", VA = "0x180A6D1F0", Slot = "7")]
	public override string HFHAJICOHIA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5452750", Offset = "0x5451B50", VA = "0x185452750")]
	internal KJGMBEBNIJE(string AFDNIPHJHMO, [In] TData NGIAGNLBILI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KAKGNJBNMJF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2AF7A90", Offset = "0x2AF6E90", VA = "0x182AF7A90")]
	public static KJGMBEBNIJE<EPILOLMBDMK> EJOLKNBPCJB(string AFDNIPHJHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3A9F370", Offset = "0x3A9E770", VA = "0x183A9F370")]
	public static KJGMBEBNIJE<TData> EJOLKNBPCJB<TData>(string AFDNIPHJHMO, [In] TData NGIAGNLBILI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MOGHKPPDBEA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x3DF81A0", Offset = "0x3DF75A0", VA = "0x183DF81A0")]
	public static DGHPMJAIBNO<TOk, NKJBEJMGDBL> CKHMLLJFHJI<TOk>([In] this DGHPMJAIBNO<TOk, NKJBEJMGDBL> DMFKPMONDPO, string AFDNIPHJHMO)
	{
		return default(DGHPMJAIBNO<TOk, NKJBEJMGDBL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HHKNPNNAIPG : KIBOPIAKFMB, NKJBEJMGDBL, HJLGPDLCPGE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2AAFE40", Offset = "0x2AAF240", VA = "0x182AAFE40")]
	protected HHKNPNNAIPG()
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
