using System;
using System.Reflection;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class DLCHKDEOFEA : CFJKAHNEDBL, KCPGGCLIGHK, BBDACGBJONE
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x32D98C0", Offset = "0x32D80C0", VA = "0x1832D98C0")]
	protected DLCHKDEOFEA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public sealed class DBLBHAOPNDL<TData> : DLCHKDEOFEA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string LLPPEEKFHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData AHNOMKDBOML;

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7DFD30", Offset = "0x7DE530", VA = "0x1807DFD30", Slot = "7")]
	public override string MOHEBAOGHEG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2405C70", Offset = "0x2404470", VA = "0x182405C70")]
	internal DBLBHAOPNDL(string AKADEFDGONP, in TData NFBDMLCENEN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class EMIGOFLDFOB
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6F31C50", Offset = "0x6F30450", VA = "0x186F31C50")]
	public static DBLBHAOPNDL<GADODCKGMOI> NKAIHPJAMOL(string AKADEFDGONP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x111BDE0", Offset = "0x111A5E0", VA = "0x18111BDE0")]
	public static DBLBHAOPNDL<TData> NKAIHPJAMOL<TData>(string AKADEFDGONP, in TData NFBDMLCENEN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CONLOHOPBAP
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1CFCA10", Offset = "0x1CFB210", VA = "0x181CFCA10")]
	public static DLDMCIANGML<TOk, KCPGGCLIGHK> PBJFOEBANPO<TOk>(this in DLDMCIANGML<TOk, KCPGGCLIGHK> PECDBPPMOJP, string AKADEFDGONP)
	{
		return default(DLDMCIANGML<TOk, KCPGGCLIGHK>);
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
