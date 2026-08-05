using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class OOGPBIDHAPP<TData> : LPMKDKJGPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LNMJBEBMHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData CIKHIKEBPOF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A40", Offset = "0x7BFE40", VA = "0x1807C0A40", Slot = "7")]
	public override string PEMDIIHBGJG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4100F20", Offset = "0x4100320", VA = "0x184100F20")]
	internal OOGPBIDHAPP(string JEBCFBFPEMG, [In] TData FLKOGFDGJDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class GGCBNPDGHBI
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E386D0", Offset = "0x1E37AD0", VA = "0x181E386D0")]
	public static OOGPBIDHAPP<GLCFOAMDFIN> HGJFOBLHCKL(string JEBCFBFPEMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2662B80", Offset = "0x2661F80", VA = "0x182662B80")]
	public static OOGPBIDHAPP<TData> HGJFOBLHCKL<TData>(string JEBCFBFPEMG, [In] TData FLKOGFDGJDF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HGLNAHMMHFN
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27FC400", Offset = "0x27FB800", VA = "0x1827FC400")]
	public static OJIJNKCPBAD<TOk, DMJBJKNNALA> GLLOCCHNNAH<TOk>([In] this OJIJNKCPBAD<TOk, DMJBJKNNALA> MEEBIDIALDO, string JEBCFBFPEMG)
	{
		return default(OJIJNKCPBAD<TOk, DMJBJKNNALA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class LPMKDKJGPIA : FEBGENKADMF, DMJBJKNNALA, BJDMIMOJLDG
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DFE610", Offset = "0x1DFDA10", VA = "0x181DFE610")]
	protected LPMKDKJGPIA()
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
