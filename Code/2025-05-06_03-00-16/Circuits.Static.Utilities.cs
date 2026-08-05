using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CCGPALLNNIF<TData> : FHIEBGLCLNJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LOFKFCJKLII;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData BADLMALNNLF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x9DF760", Offset = "0x9DDF60", VA = "0x1809DF760", Slot = "7")]
	public override string KCDPOCMBOHI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x630BA80", Offset = "0x630A280", VA = "0x18630BA80")]
	internal CCGPALLNNIF(string NJAAPDELBNN, [In] TData NFNBKNAJBPN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BKLBBOFADNK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x27CE940", Offset = "0x27CD140", VA = "0x1827CE940")]
	public static CCGPALLNNIF<OLONILFLODF> CJOJELENPLJ(string NJAAPDELBNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x3530660", Offset = "0x352EE60", VA = "0x183530660")]
	public static CCGPALLNNIF<TData> CJOJELENPLJ<TData>(string NJAAPDELBNN, [In] TData NFNBKNAJBPN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class BBKBADJBBCD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34FE680", Offset = "0x34FCE80", VA = "0x1834FE680")]
	public static HCGBMJDNFKJ<TOk, CPMHOEMAGED> BDGGKPHCCBN<TOk>([In] this HCGBMJDNFKJ<TOk, CPMHOEMAGED> NFOGFJOGLPE, string NJAAPDELBNN)
	{
		return default(HCGBMJDNFKJ<TOk, CPMHOEMAGED>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FHIEBGLCLNJ : PLLAIPNOLPG, CPMHOEMAGED, IGEMMGEDLOA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x278BB30", Offset = "0x278A330", VA = "0x18278BB30")]
	protected FHIEBGLCLNJ()
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
