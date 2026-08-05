using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class BFDCFEOHGCC<TData> : HINLGFGENCJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string NMCIIMABILJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData FHDMPGOGOOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7B4160", Offset = "0x7B3360", VA = "0x1807B4160", Slot = "7")]
	public override string OFOGPFNLIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x47BB1B0", Offset = "0x47BA3B0", VA = "0x1847BB1B0")]
	internal BFDCFEOHGCC(string FFDOAJJEAOK, [In] TData MJGHOBDIDHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MIAGAJJBEHL
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1E61410", Offset = "0x1E60610", VA = "0x181E61410")]
	public static BFDCFEOHGCC<NFDBFOHCHGK> DHBNKMCPKNO(string FFDOAJJEAOK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2750150", Offset = "0x274F350", VA = "0x182750150")]
	public static BFDCFEOHGCC<TData> DHBNKMCPKNO<TData>(string FFDOAJJEAOK, [In] TData MJGHOBDIDHD)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class FOAMJMCKPBL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x287E8D0", Offset = "0x287DAD0", VA = "0x18287E8D0")]
	public static OAAHAKNOJDO<TOk, AHFOEFCGOPM> OIOPLFNDALP<TOk>([In] this OAAHAKNOJDO<TOk, AHFOEFCGOPM> AOFIGDLFNLH, string FFDOAJJEAOK)
	{
		return default(OAAHAKNOJDO<TOk, AHFOEFCGOPM>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class HINLGFGENCJ : EPJKOMMHEAH, AHFOEFCGOPM, GJOBCCNBLIC
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1E2A070", Offset = "0x1E29270", VA = "0x181E2A070")]
	protected HINLGFGENCJ()
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
