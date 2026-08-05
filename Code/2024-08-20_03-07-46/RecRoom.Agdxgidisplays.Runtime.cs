using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NAPGPCEMIEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IKKDLPOCEEP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void PHJGOEKLEBK(IntPtr HHNBCLDGHCL, int GHACOABIHDA, int MFDAHPLFHKA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JGJIHBEPOBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x67E38F0", Offset = "0x67E28F0", VA = "0x1867E38F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67E3960", Offset = "0x67E2960", VA = "0x1867E3960")]
	private static extern void BMOEHJFELKD(PHJGOEKLEBK IPCEAEAAIHH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67E39F0", Offset = "0x67E29F0", VA = "0x1867E39F0")]
	[MonoPInvokeCallback(typeof(PHJGOEKLEBK))]
	private static void GIOFNJBOCHN(IntPtr HHNBCLDGHCL, int GHACOABIHDA, int MFDAHPLFHKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67E3C70", Offset = "0x67E2C70", VA = "0x1867E3C70")]
	private static extern void LFNNOPDGNGK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67E3880", Offset = "0x67E2880", VA = "0x1867E3880")]
	private static extern void BLJAHLHKAAO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67E38F0", Offset = "0x67E28F0", VA = "0x1867E38F0")]
	private static extern int BLMHMOMPGMD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67E3BF0", Offset = "0x67E2BF0", VA = "0x1867E3BF0")]
	private static extern int IENPECBJMOE(int KHLDDJPHOBA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67E3AF0", Offset = "0x67E2AF0", VA = "0x1867E3AF0")]
	private static extern int HGDPGOKGBPP(int KHLDDJPHOBA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x67E3B70", Offset = "0x67E2B70", VA = "0x1867E3B70")]
	private static extern int IDHFNJHLEMC(int KHLDDJPHOBA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x67E3ED0", Offset = "0x67E2ED0", VA = "0x1867E3ED0")]
	private static extern int PPDCPLJIPPG(int KHLDDJPHOBA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x67E3F50", Offset = "0x67E2F50", VA = "0x1867E3F50")]
	public NAPGPCEMIEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x67E3880", Offset = "0x67E2880", VA = "0x1867E3880", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x67E3CE0", Offset = "0x67E2CE0", VA = "0x1867E3CE0")]
	public Rect LNKDMJLCOJO(int GHCEJEAPAHE)
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
