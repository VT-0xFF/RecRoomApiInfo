using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class IKHOHJDNPNI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BLLHNIOKGGF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CBGBGBMAELC(IntPtr FALAJMPCHDK, int PPOFLGDKIBE, int DCAEELEJDKO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OKAEMONFEGM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x681ECA0", Offset = "0x681D2A0", VA = "0x18681ECA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x681ED10", Offset = "0x681D310", VA = "0x18681ED10")]
	private static extern void MIJOGGAINEF(CBGBGBMAELC MAPPKFKPMBJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x681EE20", Offset = "0x681D420", VA = "0x18681EE20")]
	[MonoPInvokeCallback(typeof(CBGBGBMAELC))]
	private static void NDOFMEHBBJC(IntPtr FALAJMPCHDK, int PPOFLGDKIBE, int DCAEELEJDKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x681EC30", Offset = "0x681D230", VA = "0x18681EC30")]
	private static extern void HGDANEHJCNG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x681EB40", Offset = "0x681D140", VA = "0x18681EB40")]
	private static extern void EHGEMLAEOMA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x681ECA0", Offset = "0x681D2A0", VA = "0x18681ECA0")]
	private static extern int KLBLBLPKBJN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x681EAC0", Offset = "0x681D0C0", VA = "0x18681EAC0")]
	private static extern int CCIAOHJLMLG(int KAGKMEDPMHO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x681EDA0", Offset = "0x681D3A0", VA = "0x18681EDA0")]
	private static extern int NAAGMMKJKKL(int KAGKMEDPMHO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x681EBB0", Offset = "0x681D1B0", VA = "0x18681EBB0")]
	private static extern int FLEDMEDGECO(int KAGKMEDPMHO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x681EF20", Offset = "0x681D520", VA = "0x18681EF20")]
	private static extern int PICOCBECEMC(int KAGKMEDPMHO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x681EFA0", Offset = "0x681D5A0", VA = "0x18681EFA0")]
	public IKHOHJDNPNI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x681EB40", Offset = "0x681D140", VA = "0x18681EB40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x681E8D0", Offset = "0x681CED0", VA = "0x18681E8D0")]
	public Rect ABOJDHGJOBE(int IACOIKFPNKB)
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
