using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class GLEEEDHDJNO<TData> : FMIGMFBOJEI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string OEIBPMLCGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LBOALCIJNPP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
	public override string LFKJGAHPPDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x370E460", Offset = "0x370D260", VA = "0x18370E460")]
	internal GLEEEDHDJNO(string LJCDGDONMLD, [In] TData EEDANCJJEPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class AKJOICMFFNJ
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E01B90", Offset = "0x1E00990", VA = "0x181E01B90")]
	public static GLEEEDHDJNO<CFLPFJJKMFI> IKCDCJJCDKO(string LJCDGDONMLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2732F10", Offset = "0x2731D10", VA = "0x182732F10")]
	public static GLEEEDHDJNO<TData> IKCDCJJCDKO<TData>(string LJCDGDONMLD, [In] TData EEDANCJJEPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FAJCIFPMCPM
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2727500", Offset = "0x2726300", VA = "0x182727500")]
	public static BOHHCOEKANF<TOk, NOBEHEHNHMO> GAOBOBKMMKL<TOk>([In] this BOHHCOEKANF<TOk, NOBEHEHNHMO> OELHNDCFEMO, string LJCDGDONMLD)
	{
		return default(BOHHCOEKANF<TOk, NOBEHEHNHMO>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class FMIGMFBOJEI : NLLFNEOCDJB, NOBEHEHNHMO, NCKLHJJKDCC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9890", Offset = "0x1DC8690", VA = "0x181DC9890")]
	protected FMIGMFBOJEI()
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
