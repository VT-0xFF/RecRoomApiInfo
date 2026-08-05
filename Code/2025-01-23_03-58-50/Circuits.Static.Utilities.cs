using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class MOBDANPIAFI<TData> : DBICEFMNJAI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NCOGKFNMLFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData OPIJNNAEPFH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8B51D0", Offset = "0x8B39D0", VA = "0x1808B51D0", Slot = "7")]
	public override string DHOBPLNCIMP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x49EC990", Offset = "0x49EB190", VA = "0x1849EC990")]
	internal MOBDANPIAFI(string PJFOMDHJLBF, [In] TData EBNFOODJNOB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GOCMMGNLFKI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2390270", Offset = "0x238EA70", VA = "0x182390270")]
	public static MOBDANPIAFI<DOPPLCFNMND> DFLBOLBHLFN(string PJFOMDHJLBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2DE93A0", Offset = "0x2DE7BA0", VA = "0x182DE93A0")]
	public static MOBDANPIAFI<TData> DFLBOLBHLFN<TData>(string PJFOMDHJLBF, [In] TData EBNFOODJNOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OIDMKPBMOKD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x31FFFB0", Offset = "0x31FE7B0", VA = "0x1831FFFB0")]
	public static DNFCNMKAMCE<TOk, OOJAGAFOLJL> BCMFLNCPGOK<TOk>([In] this DNFCNMKAMCE<TOk, OOJAGAFOLJL> EGGDEECAALI, string PJFOMDHJLBF)
	{
		return default(DNFCNMKAMCE<TOk, OOJAGAFOLJL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class DBICEFMNJAI : LHIOHJOJEEI, OOJAGAFOLJL, EPICLACHOCO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x234F090", Offset = "0x234D890", VA = "0x18234F090")]
	protected DBICEFMNJAI()
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
