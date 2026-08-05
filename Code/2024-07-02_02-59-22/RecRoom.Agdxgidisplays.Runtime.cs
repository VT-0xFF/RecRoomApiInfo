using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KOKAOCHKJGG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BAEMMCKIPHE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void JIHDJILDJPH(IntPtr BDMHFDNBPPE, int ENCFHCJIMBE, int CBGNPJAODJM);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GGBNEMPOGCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67E27B0", Offset = "0x67E17B0", VA = "0x1867E27B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67E2720", Offset = "0x67E1720", VA = "0x1867E2720")]
	private static extern void HNFJIAEEHFJ(JIHDJILDJPH AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67E25A0", Offset = "0x67E15A0", VA = "0x1867E25A0")]
	[MonoPInvokeCallback(typeof(JIHDJILDJPH))]
	private static void DMOGCGFAOEH(IntPtr BDMHFDNBPPE, int ENCFHCJIMBE, int CBGNPJAODJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67E24C0", Offset = "0x67E14C0", VA = "0x1867E24C0")]
	private static extern void BGGINNGCCML();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67E2530", Offset = "0x67E1530", VA = "0x1867E2530")]
	private static extern void BHNPIGAFLIA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67E27B0", Offset = "0x67E17B0", VA = "0x1867E27B0")]
	private static extern int IHOLCKHODIE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67E2250", Offset = "0x67E1250", VA = "0x1867E2250")]
	private static extern int AEGFINOMBCN(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67E28A0", Offset = "0x67E18A0", VA = "0x1867E28A0")]
	private static extern int PPDDMMDNGEH(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67E26A0", Offset = "0x67E16A0", VA = "0x1867E26A0")]
	private static extern int FPPOJCNGJBJ(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67E2820", Offset = "0x67E1820", VA = "0x1867E2820")]
	private static extern int KGBBMLDEAFF(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67E2920", Offset = "0x67E1920", VA = "0x1867E2920")]
	public KOKAOCHKJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67E2530", Offset = "0x67E1530", VA = "0x1867E2530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67E22D0", Offset = "0x67E12D0", VA = "0x1867E22D0")]
	public Rect AGOPFOOFBBA(int NANDKMGENIC)
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
