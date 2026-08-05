using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EMMMIOGLHCE<TData> : BHGOBKJBFOA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FIKKCGNKHHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData ALBEJFPMKJB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "7")]
	public override string JOOGKGIFDEP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4540400", Offset = "0x453F600", VA = "0x184540400")]
	internal EMMMIOGLHCE(string BDAAPBJEHGD, [In] TData DHAOEHNLNON)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KCFCNANMNPE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2833CC0", Offset = "0x2832EC0", VA = "0x182833CC0")]
	public static EMMMIOGLHCE<GKPOGNMPJHG> OIKMHICCLEP(string BDAAPBJEHGD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x36A0B10", Offset = "0x369FD10", VA = "0x1836A0B10")]
	public static EMMMIOGLHCE<TData> OIKMHICCLEP<TData>(string BDAAPBJEHGD, [In] TData DHAOEHNLNON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FFNFIFNCGCG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x37F69C0", Offset = "0x37F5BC0", VA = "0x1837F69C0")]
	public static LOAMJJJEMNF<TOk, PLLHOMFPAAM> MBPEDHGPHMM<TOk>([In] this LOAMJJJEMNF<TOk, PLLHOMFPAAM> CEENCLMGJAM, string BDAAPBJEHGD)
	{
		return default(LOAMJJJEMNF<TOk, PLLHOMFPAAM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BHGOBKJBFOA : DKPIACPJNCE, PLLHOMFPAAM, GEFBDEPLDON
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x27F13B0", Offset = "0x27F05B0", VA = "0x1827F13B0")]
	protected BHGOBKJBFOA()
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
