using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BCDKKPJABKO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IMEANMKGDFJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void LKNBLNCKODP(IntPtr JIPCGJECFKL, int HMOCDAEHBDK, int IIICHNPJFPE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JFBEEECLCIC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x45117E0", Offset = "0x450FFE0", VA = "0x1845117E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4511430", Offset = "0x450FC30", VA = "0x184511430")]
	private static extern void DLNOMHAPOBH(LKNBLNCKODP DAGCGBINJLM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4511640", Offset = "0x450FE40", VA = "0x184511640")]
	[MonoPInvokeCallback(typeof(LKNBLNCKODP))]
	private static void GJEFEMCBOPN(IntPtr JIPCGJECFKL, int HMOCDAEHBDK, int IIICHNPJFPE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4511850", Offset = "0x4510050", VA = "0x184511850")]
	private static extern void PFFHEPFDHJF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x45113C0", Offset = "0x450FBC0", VA = "0x1845113C0")]
	private static extern void BECFFIMJMIB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x45117E0", Offset = "0x450FFE0", VA = "0x1845117E0")]
	private static extern int JFIICHCBMAE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4511540", Offset = "0x450FD40", VA = "0x184511540")]
	private static extern int FIHKLOJMAOK(int POBBJHJOENB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4511760", Offset = "0x450FF60", VA = "0x184511760")]
	private static extern int HFMAAHLPLME(int POBBJHJOENB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x45115C0", Offset = "0x450FDC0", VA = "0x1845115C0")]
	private static extern int FNOEHCGFMNB(int POBBJHJOENB);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x45114C0", Offset = "0x450FCC0", VA = "0x1845114C0")]
	private static extern int FHHCFIAMDNC(int POBBJHJOENB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x45118C0", Offset = "0x45100C0", VA = "0x1845118C0")]
	public BCDKKPJABKO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x45113C0", Offset = "0x450FBC0", VA = "0x1845113C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x45111D0", Offset = "0x450F9D0", VA = "0x1845111D0")]
	public Rect AKLGBBAGADD(int AKJGMKMDAHK)
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
