using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class EOPGPABPDLG : PIHDIMJPEHH, IDFBCILOOIB, IAPKFGPHFCN
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x119D620", Offset = "0x119C820", VA = "0x18119D620")]
	protected EOPGPABPDLG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class EFGAOBHBFLG<TData> : EOPGPABPDLG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string CNMCNPHNHNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData PEFMNDEAOIL;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x844820", Offset = "0x843A20", VA = "0x180844820", Slot = "7")]
	public override string OFGOCDOINLM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x447DD20", Offset = "0x447CF20", VA = "0x18447DD20")]
	internal EFGAOBHBFLG(string CEOMJLPEFPB, in TData JCEJEOAKGOJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HFGIPGKPILJ
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15AEA10", Offset = "0x15ADC10", VA = "0x1815AEA10")]
	public static EFGAOBHBFLG<HHFDPGOJPDI> NMBJFIHLDEO(string CEOMJLPEFPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2579790", Offset = "0x2578990", VA = "0x182579790")]
	public static EFGAOBHBFLG<TData> NMBJFIHLDEO<TData>(string CEOMJLPEFPB, in TData JCEJEOAKGOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HCBFPAIAOEL
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2861360", Offset = "0x2860560", VA = "0x182861360")]
	public static CLFKONEBOLH<TOk, IDFBCILOOIB> OIPKLFDOFBH<TOk>(this in CLFKONEBOLH<TOk, IDFBCILOOIB> DCMHODHEGEC, string CEOMJLPEFPB)
	{
		return default(CLFKONEBOLH<TOk, IDFBCILOOIB>);
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
