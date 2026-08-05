using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BPDMNAHBPIJ<TData> : JPAMHBNAPMB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string CANNEAPCBEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData MEEFJAOGPIF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4EBA990", Offset = "0x4EB9990", VA = "0x184EBA990")]
	internal BPDMNAHBPIJ(string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MBHDLIGGOIE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x202D9B0", Offset = "0x202C9B0", VA = "0x18202D9B0")]
	public static BPDMNAHBPIJ<HNKFFDNJINI> HCLFOFEHDJP(string NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29351C0", Offset = "0x29341C0", VA = "0x1829351C0")]
	public static BPDMNAHBPIJ<TData> HCLFOFEHDJP<TData>(string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FMPBLNOJBEN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2B0D9B0", Offset = "0x2B0C9B0", VA = "0x182B0D9B0")]
	public static PIJKHLBEMKP<TOk, NJADGKCOIIE> AOCKBJIKKAE<TOk>([In] this PIJKHLBEMKP<TOk, NJADGKCOIIE> OLDDCPCBGIL, string NFOHONOFFAP)
	{
		return default(PIJKHLBEMKP<TOk, NJADGKCOIIE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JPAMHBNAPMB : FNFMNGCMHCP, NJADGKCOIIE, PFPHCNGMPPA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FEE5C0", Offset = "0x1FED5C0", VA = "0x181FEE5C0")]
	protected JPAMHBNAPMB()
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
