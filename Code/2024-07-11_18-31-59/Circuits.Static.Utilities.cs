using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class DHIMHCIJFDH<TData> : DOBPMPCGNAB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string GKHLDHJLOCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CPPCAMCFLFP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x852900", Offset = "0x851300", VA = "0x180852900", Slot = "7")]
	public override string AGNLMABPEGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x574AF40", Offset = "0x5749940", VA = "0x18574AF40")]
	internal DHIMHCIJFDH(string JNNDBFGKHHD, [In] TData LINJEFIAFHO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PDKDDIGNEMH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x202A260", Offset = "0x2028C60", VA = "0x18202A260")]
	public static DHIMHCIJFDH<MOOMEEOMEEK> FJAAFKPDAIA(string JNNDBFGKHHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28C7450", Offset = "0x28C5E50", VA = "0x1828C7450")]
	public static DHIMHCIJFDH<TData> FJAAFKPDAIA<TData>(string JNNDBFGKHHD, [In] TData LINJEFIAFHO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class LNOAILIICDG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2C0C140", Offset = "0x2C0AB40", VA = "0x182C0C140")]
	public static CIKECDEKJAI<TOk, JPLAIBFIFBK> MGFHJDKCJLP<TOk>([In] this CIKECDEKJAI<TOk, JPLAIBFIFBK> HIKEOGPAJAF, string JNNDBFGKHHD)
	{
		return default(CIKECDEKJAI<TOk, JPLAIBFIFBK>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DOBPMPCGNAB : EGADAFAJMEN, JPLAIBFIFBK, IKKDIOOIDLA
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1FEA250", Offset = "0x1FE8C50", VA = "0x181FEA250")]
	protected DOBPMPCGNAB()
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
