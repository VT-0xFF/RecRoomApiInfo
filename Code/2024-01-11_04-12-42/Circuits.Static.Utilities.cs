using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class CKFDHDBLDLJ<TData> : IKLHIPCKMCK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LBHIFPJKNJE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData KGACILCCGND;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7938F0", Offset = "0x7922F0", VA = "0x1807938F0", Slot = "7")]
	public override string IIILAEFIJID()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4D83F10", Offset = "0x4D82910", VA = "0x184D83F10")]
	internal CKFDHDBLDLJ(string BKNCBJIACBJ, [In] TData OBAHLGOPPIK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MJCOINBDNDE
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D5EDD0", Offset = "0x1D5D7D0", VA = "0x181D5EDD0")]
	public static CKFDHDBLDLJ<NBACEGLOLCA> KBFODEGLBLG(string BKNCBJIACBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x244FEB0", Offset = "0x244E8B0", VA = "0x18244FEB0")]
	public static CKFDHDBLDLJ<TData> KBFODEGLBLG<TData>(string BKNCBJIACBJ, [In] TData OBAHLGOPPIK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NFBGJMGPDMD
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x27426C0", Offset = "0x27410C0", VA = "0x1827426C0")]
	public static GAFDMEJHKLE<TOk, HJEDPJFAAAL> MJGNGMONMPJ<TOk>([In] this GAFDMEJHKLE<TOk, HJEDPJFAAAL> JFFAAHPEFOB, string BKNCBJIACBJ)
	{
		return default(GAFDMEJHKLE<TOk, HJEDPJFAAAL>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class IKLHIPCKMCK : FPFCLMBFIMG, HJEDPJFAAAL, AJOFEFECHPF
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D27530", Offset = "0x1D25F30", VA = "0x181D27530")]
	protected IKLHIPCKMCK()
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
