using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KBOCKAEFGPI<TData> : LAEJIKKOMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LKAAOFNIBML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CNPFJDANIOD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
	public override string PDDPMMJGDDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x430C220", Offset = "0x430AC20", VA = "0x18430C220")]
	internal KBOCKAEFGPI(string MEBLNPKEJMN, [In] TData OIGMDCDEKEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class HCMMOEKLHMA
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x21192C0", Offset = "0x2117CC0", VA = "0x1821192C0")]
	public static KBOCKAEFGPI<IEPJDCHMGFO> MMKGNMBHOIH(string MEBLNPKEJMN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2A101B0", Offset = "0x2A0EBB0", VA = "0x182A101B0")]
	public static KBOCKAEFGPI<TData> MMKGNMBHOIH<TData>(string MEBLNPKEJMN, [In] TData OIGMDCDEKEG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FHBPEJHDMLF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C61DC0", Offset = "0x2C607C0", VA = "0x182C61DC0")]
	public static MOKFKOEPKDB<TOk, JNDPMGELPNI> BKILBGIDALA<TOk>([In] this MOKFKOEPKDB<TOk, JNDPMGELPNI> PECHDAFMNOO, string MEBLNPKEJMN)
	{
		return default(MOKFKOEPKDB<TOk, JNDPMGELPNI>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LAEJIKKOMKB : IPGCPDAOJFL, JNDPMGELPNI, NLHAIFJDFEL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x20D9880", Offset = "0x20D8280", VA = "0x1820D9880")]
	protected LAEJIKKOMKB()
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
