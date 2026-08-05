using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class PDACHNFKFNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FAJBDPIOIGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void FINPCMJGLHP(IntPtr EFADACBHMKC, int PCAHMJECHKC, int NIPJJMPKKAK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MAAOLPJCINI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64A7D10", Offset = "0x64A6F10", VA = "0x1864A7D10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64A7E80", Offset = "0x64A7080", VA = "0x1864A7E80")]
	private static extern void LHBANCPLPKD(FINPCMJGLHP IGAMPECHIKO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64A7B70", Offset = "0x64A6D70", VA = "0x1864A7B70")]
	[MonoPInvokeCallback(typeof(FINPCMJGLHP))]
	private static void DMBDKONPONJ(IntPtr EFADACBHMKC, int PCAHMJECHKC, int NIPJJMPKKAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64A7A80", Offset = "0x64A6C80", VA = "0x1864A7A80")]
	private static extern void BNACPANAOEJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64A7CA0", Offset = "0x64A6EA0", VA = "0x1864A7CA0")]
	private static extern void MNEHHBEPHAB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64A7D10", Offset = "0x64A6F10", VA = "0x1864A7D10")]
	private static extern int EGOBMHAGDPM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64A7D80", Offset = "0x64A6F80", VA = "0x1864A7D80")]
	private static extern int IELKODOLMJG(int LIKFEBDBPON);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64A8100", Offset = "0x64A7300", VA = "0x1864A8100")]
	private static extern int PGMKLDJMPFD(int LIKFEBDBPON);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64A7E00", Offset = "0x64A7000", VA = "0x1864A7E00")]
	private static extern int IJMKLCGDKMG(int LIKFEBDBPON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64A7AF0", Offset = "0x64A6CF0", VA = "0x1864A7AF0")]
	private static extern int DHIIKCDBKGD(int LIKFEBDBPON);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64A8180", Offset = "0x64A7380", VA = "0x1864A8180")]
	public PDACHNFKFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64A7CA0", Offset = "0x64A6EA0", VA = "0x1864A7CA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64A7F10", Offset = "0x64A7110", VA = "0x1864A7F10")]
	public Rect OJDCGGJHJAN(int APCIMGPJIKL)
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
