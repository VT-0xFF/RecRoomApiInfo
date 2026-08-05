using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class JDILFOGBEOG<TData> : BPKDACEDAGC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DGGOMFECFGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CEKPCFBCLAM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x773850", Offset = "0x772C50", VA = "0x180773850", Slot = "7")]
	public override string KHDKMLPELIF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38E8870", Offset = "0x38E7C70", VA = "0x1838E8870")]
	internal JDILFOGBEOG(string KCFFPPIEBHH, [In] TData KKOACPFFAML)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class LMHNBPLOAAF
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D10950", Offset = "0x1D0FD50", VA = "0x181D10950")]
	public static JDILFOGBEOG<CPIOBHNHOJN> PBDMNAJCIOP(string KCFFPPIEBHH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2332170", Offset = "0x2331570", VA = "0x182332170")]
	public static JDILFOGBEOG<TData> PBDMNAJCIOP<TData>(string KCFFPPIEBHH, [In] TData KKOACPFFAML)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KKKCCGNDJPF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x257A2B0", Offset = "0x25796B0", VA = "0x18257A2B0")]
	public static EFPDAHOJLMO<TOk, CKBHJGGJPMD> ACKFAGMDKBI<TOk>([In] this EFPDAHOJLMO<TOk, CKBHJGGJPMD> EAODMOEAJOC, string KCFFPPIEBHH)
	{
		return default(EFPDAHOJLMO<TOk, CKBHJGGJPMD>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class BPKDACEDAGC : CKLCFGGMCDD, CKBHJGGJPMD, MLDPNJCMKGI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CDBE60", Offset = "0x1CDB260", VA = "0x181CDBE60")]
	protected BPKDACEDAGC()
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
