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
	[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "7")]
	public override string MKLJNMAODHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4E90F80", Offset = "0x4E8F580", VA = "0x184E90F80")]
	internal BPDMNAHBPIJ(string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MBHDLIGGOIE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x201FE00", Offset = "0x201E400", VA = "0x18201FE00")]
	public static BPDMNAHBPIJ<HNKFFDNJINI> HCLFOFEHDJP(string NFOHONOFFAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x29248C0", Offset = "0x2922EC0", VA = "0x1829248C0")]
	public static BPDMNAHBPIJ<TData> HCLFOFEHDJP<TData>(string NFOHONOFFAP, [In] TData FHNKDHIILBL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FMPBLNOJBEN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2AF5060", Offset = "0x2AF3660", VA = "0x182AF5060")]
	public static PIJKHLBEMKP<TOk, NJADGKCOIIE> AOCKBJIKKAE<TOk>([In] this PIJKHLBEMKP<TOk, NJADGKCOIIE> OLDDCPCBGIL, string NFOHONOFFAP)
	{
		return default(PIJKHLBEMKP<TOk, NJADGKCOIIE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class JPAMHBNAPMB : FNFMNGCMHCP, NJADGKCOIIE, PFPHCNGMPPA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FE0BE0", Offset = "0x1FDF1E0", VA = "0x181FE0BE0")]
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
