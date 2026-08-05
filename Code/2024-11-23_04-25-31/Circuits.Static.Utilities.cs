using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class PGACAJGCNHO<TData> : GEKPLBFPNLN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DGDPHPLNONC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData DKIFFIMODLG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x8AD540", Offset = "0x8ABF40", VA = "0x1808AD540", Slot = "7")]
	public override string BGELNEMCJAG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B6AE00", Offset = "0x4B69800", VA = "0x184B6AE00")]
	internal PGACAJGCNHO(string FCMDIEEAPHD, [In] TData GGEMPJLCHFC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class IAIGPKPIFHO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x22FA5A0", Offset = "0x22F8FA0", VA = "0x1822FA5A0")]
	public static PGACAJGCNHO<NEDLODCHJKB> AELHPDENENI(string FCMDIEEAPHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2CE98F0", Offset = "0x2CE82F0", VA = "0x182CE98F0")]
	public static PGACAJGCNHO<TData> AELHPDENENI<TData>(string FCMDIEEAPHD, [In] TData GGEMPJLCHFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class MHDHPCKNEKB
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2FDC590", Offset = "0x2FDAF90", VA = "0x182FDC590")]
	public static OKPKCEBGDLD<TOk, NJDGKLFLKEH> DGAFAEMIMPH<TOk>([In] this OKPKCEBGDLD<TOk, NJDGKLFLKEH> PCBICLOONMH, string FCMDIEEAPHD)
	{
		return default(OKPKCEBGDLD<TOk, NJDGKLFLKEH>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GEKPLBFPNLN : JMDMKJMGBCA, NJDGKLFLKEH, FMGMBNHPFJE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x22BBC90", Offset = "0x22BA690", VA = "0x1822BBC90")]
	protected GEKPLBFPNLN()
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
