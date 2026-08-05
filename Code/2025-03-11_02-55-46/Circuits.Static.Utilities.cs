using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class EKPNIMPDABB<TData> : MJOPIANFEAH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string KONAMMIBLOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData IDIBBHDGOOI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x968330", Offset = "0x967730", VA = "0x180968330", Slot = "7")]
	public override string CMLLJBLPAFB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41284A0", Offset = "0x41278A0", VA = "0x1841284A0")]
	internal EKPNIMPDABB(string LPIFIOEEOGF, [In] TData MJFOKKFMONL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class KEDCIDLJBJC
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x262B600", Offset = "0x262AA00", VA = "0x18262B600")]
	public static EKPNIMPDABB<AOFFOIKPJDJ> KMDIICJFNJF(string LPIFIOEEOGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x31FD100", Offset = "0x31FC500", VA = "0x1831FD100")]
	public static EKPNIMPDABB<TData> KMDIICJFNJF<TData>(string LPIFIOEEOGF, [In] TData MJFOKKFMONL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GPPJJOABKKF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x34C5760", Offset = "0x34C4B60", VA = "0x1834C5760")]
	public static PHLGGJNOBDN<TOk, MEENKFHCKIP> PGMAOLMDKCD<TOk>([In] this PHLGGJNOBDN<TOk, MEENKFHCKIP> IIICNLIAPBJ, string LPIFIOEEOGF)
	{
		return default(PHLGGJNOBDN<TOk, MEENKFHCKIP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class MJOPIANFEAH : OGPHAGHJAIC, MEENKFHCKIP, MOCCGNOLGDK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x25EAEE0", Offset = "0x25EA2E0", VA = "0x1825EAEE0")]
	protected MJOPIANFEAH()
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
