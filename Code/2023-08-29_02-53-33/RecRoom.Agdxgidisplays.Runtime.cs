using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HGOMHKKCEEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HAMEEAADECK
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AJPOBPPOICI(IntPtr IPCJOMPDMMM, int JECAINLJFKC, int PLIHAAIKLBL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HPIODINGMOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6FAE240", Offset = "0x6FAD640", VA = "0x186FAE240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE520", Offset = "0x6FAD920", VA = "0x186FAE520")]
	private static extern void INKLGPJIFCP(AJPOBPPOICI GBCKPIBLKJM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE6B0", Offset = "0x6FADAB0", VA = "0x186FAE6B0")]
	[MonoPInvokeCallback(typeof(AJPOBPPOICI))]
	private static void OAGOBHBKDFM(IntPtr IPCJOMPDMMM, int JECAINLJFKC, int PLIHAAIKLBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE1D0", Offset = "0x6FAD5D0", VA = "0x186FAE1D0")]
	private static extern void BEFDPLAELIH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE4B0", Offset = "0x6FAD8B0", VA = "0x186FAE4B0")]
	private static extern void ODDCICBIJFK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE240", Offset = "0x6FAD640", VA = "0x186FAE240")]
	private static extern int JOJNBNHKBDG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE0D0", Offset = "0x6FAD4D0", VA = "0x186FAE0D0")]
	private static extern int AGGKMGFFNMI(int MLGAFKBKMCE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE5B0", Offset = "0x6FAD9B0", VA = "0x186FAE5B0")]
	private static extern int MCAOEBIJIFJ(int MLGAFKBKMCE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE150", Offset = "0x6FAD550", VA = "0x186FAE150")]
	private static extern int AOIIKBCLBEH(int MLGAFKBKMCE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE630", Offset = "0x6FADA30", VA = "0x186FAE630")]
	private static extern int NOAPJCAPPKO(int MLGAFKBKMCE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE7E0", Offset = "0x6FADBE0", VA = "0x186FAE7E0")]
	public HGOMHKKCEEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE4B0", Offset = "0x6FAD8B0", VA = "0x186FAE4B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6FAE2B0", Offset = "0x6FAD6B0", VA = "0x186FAE2B0")]
	public Rect CODBDMOLIIP(int DOCFIPGJGBH)
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
