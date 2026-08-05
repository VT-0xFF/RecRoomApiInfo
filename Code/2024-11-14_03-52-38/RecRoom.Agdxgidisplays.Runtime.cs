using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ABKOPKFNHAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MKEHPFFGLMC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GADMOFLBIBP(IntPtr OPBNONPHAEF, int JKIIGJDNBMO, int GMHBODNJPPN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MLLFFAEGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6BA21E0", Offset = "0x6BA15E0", VA = "0x186BA21E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2730", Offset = "0x6BA1B30", VA = "0x186BA2730")]
	private static extern void JHBMGIIDAIC(GADMOFLBIBP NEDFJOJDIHF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2250", Offset = "0x6BA1650", VA = "0x186BA2250")]
	[MonoPInvokeCallback(typeof(GADMOFLBIBP))]
	private static void BPPGBOHLICH(IntPtr OPBNONPHAEF, int JKIIGJDNBMO, int GMHBODNJPPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6BA27C0", Offset = "0x6BA1BC0", VA = "0x186BA27C0")]
	private static extern void NOCOEJHJFAP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2350", Offset = "0x6BA1750", VA = "0x186BA2350")]
	private static extern void CJKMMIKBNJL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6BA21E0", Offset = "0x6BA15E0", VA = "0x186BA21E0")]
	private static extern int AFMFNOPGFBD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2830", Offset = "0x6BA1C30", VA = "0x186BA2830")]
	private static extern int PNNIDHJLFFF(int HDCHKIOFILD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6BA26B0", Offset = "0x6BA1AB0", VA = "0x186BA26B0")]
	private static extern int JFGGFONOOGP(int HDCHKIOFILD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2440", Offset = "0x6BA1840", VA = "0x186BA2440")]
	private static extern int GCJOFKGJNNN(int HDCHKIOFILD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6BA23C0", Offset = "0x6BA17C0", VA = "0x186BA23C0")]
	private static extern int CKOAIIDKEAN(int HDCHKIOFILD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6BA28B0", Offset = "0x6BA1CB0", VA = "0x186BA28B0")]
	public ABKOPKFNHAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6BA2350", Offset = "0x6BA1750", VA = "0x186BA2350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6BA24C0", Offset = "0x6BA18C0", VA = "0x186BA24C0")]
	public Rect HFBALNFMIKK(int NOMEIJBGOHH)
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
