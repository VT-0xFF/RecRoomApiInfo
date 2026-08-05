using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LDLJKIJLNGI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IMLLJFGKLAN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void LABBBLAPHOH(IntPtr CLBGLGJCBEB, int AEOJMEBJNPD, int HCLKKONJAPP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ECKMODHILPF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6744CA0", Offset = "0x67438A0", VA = "0x186744CA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6744E90", Offset = "0x6743A90", VA = "0x186744E90")]
	private static extern void OKHLAFONLGE(LABBBLAPHOH LHMNAJJOJLL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6744D90", Offset = "0x6743990", VA = "0x186744D90")]
	[MonoPInvokeCallback(typeof(LABBBLAPHOH))]
	private static void LFIFBJJCEGN(IntPtr CLBGLGJCBEB, int AEOJMEBJNPD, int HCLKKONJAPP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6744BB0", Offset = "0x67437B0", VA = "0x186744BB0")]
	private static extern void EHHLDMLDHNI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6744B40", Offset = "0x6743740", VA = "0x186744B40")]
	private static extern void KJMIFBGBNMK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6744CA0", Offset = "0x67438A0", VA = "0x186744CA0")]
	private static extern int JEDKJNFCJPJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6744D10", Offset = "0x6743910", VA = "0x186744D10")]
	private static extern int KEKIJBPFFCK(int EPKGPGILADI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6744F20", Offset = "0x6743B20", VA = "0x186744F20")]
	private static extern int OLNHEFINHDP(int EPKGPGILADI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6744AC0", Offset = "0x67436C0", VA = "0x186744AC0")]
	private static extern int DGLJFGGDJEK(int EPKGPGILADI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6744C20", Offset = "0x6743820", VA = "0x186744C20")]
	private static extern int ELMBNCDEMFF(int EPKGPGILADI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6744FA0", Offset = "0x6743BA0", VA = "0x186744FA0")]
	public LDLJKIJLNGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6744B40", Offset = "0x6743740", VA = "0x186744B40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67448D0", Offset = "0x67434D0", VA = "0x1867448D0")]
	public Rect AAHENGIKFBI(int IECDPAGKLAC)
	{
		return default(Rect);
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
