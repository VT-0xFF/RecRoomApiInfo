using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class IENDOJOLKJK<TData> : NNADKGMIMDE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string EBIHFAEPEMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData HCKHOAGNJJN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B62A0", Offset = "0x7B54A0", VA = "0x1807B62A0", Slot = "7")]
	public override string FIHEJJCABJP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3A3E240", Offset = "0x3A3D440", VA = "0x183A3E240")]
	internal IENDOJOLKJK(string JGNAJPMGGNE, [In] TData FODGEDCJIDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BDMEOGMKKOM
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E9E3C0", Offset = "0x1E9D5C0", VA = "0x181E9E3C0")]
	public static IENDOJOLKJK<LKEAICJEMFK> MIJABIECKKD(string JGNAJPMGGNE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x26A5E30", Offset = "0x26A5030", VA = "0x1826A5E30")]
	public static IENDOJOLKJK<TData> MIJABIECKKD<TData>(string JGNAJPMGGNE, [In] TData FODGEDCJIDC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class DCDGNOCJIPA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x274AE90", Offset = "0x274A090", VA = "0x18274AE90")]
	public static NFMFLMAOFMP<TOk, CEGADOEINOB> EMIGKEMEDBA<TOk>([In] this NFMFLMAOFMP<TOk, CEGADOEINOB> KNKOEEEKHDK, string JGNAJPMGGNE)
	{
		return default(NFMFLMAOFMP<TOk, CEGADOEINOB>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class NNADKGMIMDE : OMPNGPMCKPG, CEGADOEINOB, LNFCDOMCNGI
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E65730", Offset = "0x1E64930", VA = "0x181E65730")]
	protected NNADKGMIMDE()
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
