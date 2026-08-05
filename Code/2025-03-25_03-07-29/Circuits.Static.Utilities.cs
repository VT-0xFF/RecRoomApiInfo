using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class PLFEFEHCGMA<TData> : ABNNHKJOOMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string DCKEPMDAMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CBNHMBHNHHG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x993370", Offset = "0x992770", VA = "0x180993370", Slot = "7")]
	public override string CHDHFHDBOKA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x52E82B0", Offset = "0x52E76B0", VA = "0x1852E82B0")]
	internal PLFEFEHCGMA(string EIGJGBPHOMK, [In] TData AMHCLKHIFKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class PDIMACEJDIK
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x26BA650", Offset = "0x26B9A50", VA = "0x1826BA650")]
	public static PLFEFEHCGMA<DKANDHFOMPH> AFLKMMODJAC(string EIGJGBPHOMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x364C040", Offset = "0x364B440", VA = "0x18364C040")]
	public static PLFEFEHCGMA<TData> AFLKMMODJAC<TData>(string EIGJGBPHOMK, [In] TData AMHCLKHIFKH)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HAFKKOIGFGK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x35CC560", Offset = "0x35CB960", VA = "0x1835CC560")]
	public static AEAAIINGJNL<TOk, GJDNFLPCNNP> CEANKMBBIBM<TOk>([In] this AEAAIINGJNL<TOk, GJDNFLPCNNP> CAMFIHKHJNG, string EIGJGBPHOMK)
	{
		return default(AEAAIINGJNL<TOk, GJDNFLPCNNP>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class ABNNHKJOOMD : BPMPLDFNAFC, GJDNFLPCNNP, EPFFDEGDAEO
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2678600", Offset = "0x2677A00", VA = "0x182678600")]
	protected ABNNHKJOOMD()
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
