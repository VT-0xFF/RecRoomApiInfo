using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CDLJOFLMDKM<TData> : GOLJEOBBMJE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string ICOADANDNDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LGDPHHJAFJI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x793EC0", Offset = "0x7932C0", VA = "0x180793EC0", Slot = "7")]
	public override string GPDEFFKCMGK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49C6FA0", Offset = "0x49C63A0", VA = "0x1849C6FA0")]
	internal CDLJOFLMDKM(string AGOKDCAFCLN, [In] TData GMLIPIALCHN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AAGHAFCAODM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D678F0", Offset = "0x1D66CF0", VA = "0x181D678F0")]
	public static CDLJOFLMDKM<JDDDAABNCFI> PIJMMFMEPKL(string AGOKDCAFCLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x23E9D40", Offset = "0x23E9140", VA = "0x1823E9D40")]
	public static CDLJOFLMDKM<TData> PIJMMFMEPKL<TData>(string AGOKDCAFCLN, [In] TData GMLIPIALCHN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DGGHFHLHPMF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x24AC4C0", Offset = "0x24AB8C0", VA = "0x1824AC4C0")]
	public static EGECKPFNJNE<TOk, APEAMGBOOBA> EJLGOHICKFJ<TOk>([In] this EGECKPFNJNE<TOk, APEAMGBOOBA> LHCHBOKBAPK, string AGOKDCAFCLN)
	{
		return default(EGECKPFNJNE<TOk, APEAMGBOOBA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GOLJEOBBMJE : JIBPJLBDKCG, APEAMGBOOBA, IGBINOOJKPE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D2F9B0", Offset = "0x1D2EDB0", VA = "0x181D2F9B0")]
	protected GOLJEOBBMJE()
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
