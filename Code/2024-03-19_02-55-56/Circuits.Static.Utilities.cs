using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class KBNGHFNBEIH<TData> : PHBMKBALCLH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string FBJBIEBEAHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GCOMEMFCJKB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7BC1C0", Offset = "0x7BB1C0", VA = "0x1807BC1C0", Slot = "7")]
	public override string OJGKBMCMILI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9550", Offset = "0x3BE8550", VA = "0x183BE9550")]
	internal KBNGHFNBEIH(string DFJKCKBFLAD, [In] TData ELANMAGHLLI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class APKNHEFEGAD
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E2DBC0", Offset = "0x1E2CBC0", VA = "0x181E2DBC0")]
	public static KBNGHFNBEIH<EMBFKEMHPML> NAJBLLJFKKI(string DFJKCKBFLAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2635A30", Offset = "0x2634A30", VA = "0x182635A30")]
	public static KBNGHFNBEIH<TData> NAJBLLJFKKI<TData>(string DFJKCKBFLAD, [In] TData ELANMAGHLLI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class GCOPNCDEMBP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2796B40", Offset = "0x2795B40", VA = "0x182796B40")]
	public static PBAOJGOHCMJ<TOk, OAAMPDEOGNE> JECINPPMLCN<TOk>([In] this PBAOJGOHCMJ<TOk, OAAMPDEOGNE> AOFEPADBPDL, string DFJKCKBFLAD)
	{
		return default(PBAOJGOHCMJ<TOk, OAAMPDEOGNE>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class PHBMKBALCLH : HMMHOLFLIGF, OAAMPDEOGNE, BOFJPOKAPAE
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1DF3ED0", Offset = "0x1DF2ED0", VA = "0x181DF3ED0")]
	protected PHBMKBALCLH()
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
