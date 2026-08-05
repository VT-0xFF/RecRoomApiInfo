using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DIBKCMKPDHH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FCDDFHAMGOJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DBIJANCFFOE(IntPtr KGHMNJMLIBE, int BCAJFCGHDKI, int EKGBGFKMLBB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GNNCNGPJOPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x81EEE40", Offset = "0x81ED840", VA = "0x1881EEE40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x81EEEB0", Offset = "0x81ED8B0", VA = "0x1881EEEB0")]
	private static extern void CFGFKIMLCKB(DBIJANCFFOE AEPCPKCINPI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x81EF120", Offset = "0x81EDB20", VA = "0x1881EF120")]
	[MonoPInvokeCallback(typeof(DBIJANCFFOE))]
	private static void KAPJCPKONPG(IntPtr KGHMNJMLIBE, int BCAJFCGHDKI, int EKGBGFKMLBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x81EF0B0", Offset = "0x81EDAB0", VA = "0x1881EF0B0")]
	private static extern void GFALNPPLGKO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x81EEF40", Offset = "0x81ED940", VA = "0x1881EEF40")]
	private static extern void JHBONPGAEAE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81EEE40", Offset = "0x81ED840", VA = "0x1881EEE40")]
	private static extern int CDMNKCHJNIN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81EEFB0", Offset = "0x81ED9B0", VA = "0x1881EEFB0")]
	private static extern int FDIPOBFNDKD(int NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81EF030", Offset = "0x81EDA30", VA = "0x1881EF030")]
	private static extern int FFGDOPANAFA(int NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x81EF410", Offset = "0x81EDE10", VA = "0x1881EF410")]
	private static extern int PNPPHNMHDKI(int NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x81EEDC0", Offset = "0x81ED7C0", VA = "0x1881EEDC0")]
	private static extern int AOPIOBLJOPL(int NMAIBBDGPCD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x81EF490", Offset = "0x81EDE90", VA = "0x1881EF490")]
	public DIBKCMKPDHH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81EEF40", Offset = "0x81ED940", VA = "0x1881EEF40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81EF220", Offset = "0x81EDC20", VA = "0x1881EF220")]
	public Rect OFHBNIIPFEH(int LFKFJBPNCDL)
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
