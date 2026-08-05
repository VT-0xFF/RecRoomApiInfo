using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public sealed class NENGEIKEOAH<TData> : GCHIODKACBE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly string AALAONDECAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly TData GICDCDBMPKH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510", Slot = "7")]
	public override string HDHLJKIJNJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x41A9980", Offset = "0x41A8B80", VA = "0x1841A9980")]
	internal NENGEIKEOAH(string PPGBBBOBJLN, [In] TData JLJKEBMIIPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BEMLFHJOFPH
{
	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1F19CA0", Offset = "0x1F18EA0", VA = "0x181F19CA0")]
	public static NENGEIKEOAH<PJGNGDCIDLA> EPPBEPCPNMI(string PPGBBBOBJLN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2773AD0", Offset = "0x2772CD0", VA = "0x182773AD0")]
	public static NENGEIKEOAH<TData> EPPBEPCPNMI<TData>(string PPGBBBOBJLN, [In] TData JLJKEBMIIPF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class ELKBEEKLEGG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x282AD00", Offset = "0x2829F00", VA = "0x18282AD00")]
	public static GDHFNIGIAEI<TOk, HHLFGPMDGJA> BOBIJOEBMOG<TOk>([In] this GDHFNIGIAEI<TOk, HHLFGPMDGJA> CJKIBFNGPNM, string PPGBBBOBJLN)
	{
		return default(GDHFNIGIAEI<TOk, HHLFGPMDGJA>);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public abstract class GCHIODKACBE : GCNNAKAAMEK, HHLFGPMDGJA, NFEBAOOCHCK
{
	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1EDEDA0", Offset = "0x1EDDFA0", VA = "0x181EDEDA0")]
	protected GCHIODKACBE()
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
