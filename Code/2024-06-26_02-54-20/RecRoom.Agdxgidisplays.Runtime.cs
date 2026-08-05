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
		[Cpp2IlInjected.Address(RVA = "0x67B2B50", Offset = "0x67B1150", VA = "0x1867B2B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67B2AC0", Offset = "0x67B10C0", VA = "0x1867B2AC0")]
	private static extern void HNFJIAEEHFJ(JIHDJILDJPH AHJILKLLLDE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67B2940", Offset = "0x67B0F40", VA = "0x1867B2940")]
	[MonoPInvokeCallback(typeof(JIHDJILDJPH))]
	private static void DMOGCGFAOEH(IntPtr BDMHFDNBPPE, int ENCFHCJIMBE, int CBGNPJAODJM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67B2860", Offset = "0x67B0E60", VA = "0x1867B2860")]
	private static extern void BGGINNGCCML();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67B28D0", Offset = "0x67B0ED0", VA = "0x1867B28D0")]
	private static extern void BHNPIGAFLIA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67B2B50", Offset = "0x67B1150", VA = "0x1867B2B50")]
	private static extern int IHOLCKHODIE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67B25F0", Offset = "0x67B0BF0", VA = "0x1867B25F0")]
	private static extern int AEGFINOMBCN(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67B2C40", Offset = "0x67B1240", VA = "0x1867B2C40")]
	private static extern int PPDDMMDNGEH(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67B2A40", Offset = "0x67B1040", VA = "0x1867B2A40")]
	private static extern int FPPOJCNGJBJ(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67B2BC0", Offset = "0x67B11C0", VA = "0x1867B2BC0")]
	private static extern int KGBBMLDEAFF(int BLCJLIJFBDL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67B2CC0", Offset = "0x67B12C0", VA = "0x1867B2CC0")]
	public KOKAOCHKJGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67B28D0", Offset = "0x67B0ED0", VA = "0x1867B28D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67B2670", Offset = "0x67B0C70", VA = "0x1867B2670")]
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
