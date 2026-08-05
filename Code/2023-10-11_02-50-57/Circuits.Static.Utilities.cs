using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class JBHBHHDJDPC<TData> : HJEACDGALLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string PPDMEDDKMEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData LJDFDHJOOIG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x761640", Offset = "0x760440", VA = "0x180761640", Slot = "7")]
	public override string FIDCKDNNLBM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x38148F0", Offset = "0x38136F0", VA = "0x1838148F0")]
	internal JBHBHHDJDPC(string JIGBFCEILIK, [In] TData PFDMLBFKIAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class JODDKJEHKIO
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1C722A0", Offset = "0x1C710A0", VA = "0x181C722A0")]
	public static JBHBHHDJDPC<LIGKMPLCELA> NPAOPBPEFCO(string JIGBFCEILIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x216E360", Offset = "0x216D160", VA = "0x18216E360")]
	public static JBHBHHDJDPC<TData> NPAOPBPEFCO<TData>(string JIGBFCEILIK, [In] TData PFDMLBFKIAP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EKHDCMEHEJF
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2218040", Offset = "0x2216E40", VA = "0x182218040")]
	public static IHFDHMKEEAA<TOk, BENEMAACKKC> DNHGGMMPACE<TOk>([In] this IHFDHMKEEAA<TOk, BENEMAACKKC> LNKCIHFCLHG, string JIGBFCEILIK)
	{
		return default(IHFDHMKEEAA<TOk, BENEMAACKKC>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HJEACDGALLJ : EAGLHGKDHHG, BENEMAACKKC, IABAFDHJPAP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1C3E670", Offset = "0x1C3D470", VA = "0x181C3E670")]
	protected HJEACDGALLJ()
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
