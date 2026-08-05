using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GBJDCCMAAHF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JCPEDOHHFGJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BOELPIBCAPH(IntPtr OALKBFHLHKE, int AJCINIIEJAJ, int NKOHLNIFHKK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FBMFCNHOGIE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7233EC0", Offset = "0x72332C0", VA = "0x187233EC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7233DB0", Offset = "0x72331B0", VA = "0x187233DB0")]
	private static extern void FDPCOBJNEAO(BOELPIBCAPH IPDGCBIIEII);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7234030", Offset = "0x7233430", VA = "0x187234030")]
	[MonoPInvokeCallback(typeof(BOELPIBCAPH))]
	private static void LPDDLPLJGNE(IntPtr OALKBFHLHKE, int AJCINIIEJAJ, int NKOHLNIFHKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7234160", Offset = "0x7233560", VA = "0x187234160")]
	private static extern void MHIDNOPDKCM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7233D40", Offset = "0x7233140", VA = "0x187233D40")]
	private static extern void BDFBMDIFKMK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7233EC0", Offset = "0x72332C0", VA = "0x187233EC0")]
	private static extern int JAHBKLNCNPD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7233CC0", Offset = "0x72330C0", VA = "0x187233CC0")]
	private static extern int ACDNAFMEMHF(int JNHCLKAAKHA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7233E40", Offset = "0x7233240", VA = "0x187233E40")]
	private static extern int HMANPKGGCJE(int JNHCLKAAKHA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7233FB0", Offset = "0x72333B0", VA = "0x187233FB0")]
	private static extern int LMFIGFAEEIC(int JNHCLKAAKHA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7233F30", Offset = "0x7233330", VA = "0x187233F30")]
	private static extern int LDEDBEFOIPL(int JNHCLKAAKHA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72343D0", Offset = "0x72337D0", VA = "0x1872343D0")]
	public GBJDCCMAAHF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7233D40", Offset = "0x7233140", VA = "0x187233D40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x72341D0", Offset = "0x72335D0", VA = "0x1872341D0")]
	public Rect OAOFMDDILDH(int HLMEIANBDEF)
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
