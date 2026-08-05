using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GFEFCKODGBA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EMLNPJNPCAH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DBGJOFLIMPP(IntPtr BHMKONDNBED, int GINFBCJKIJI, int GFAOABJFEOP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NMJLEFNOKJF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7EB20", Offset = "0x5B7D920", VA = "0x185B7EB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EEF0", Offset = "0x5B7DCF0", VA = "0x185B7EEF0")]
	private static extern void NPOHCLDDIME(DBGJOFLIMPP PMOMGAGBHKB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E8B0", Offset = "0x5B7D6B0", VA = "0x185B7E8B0")]
	[MonoPInvokeCallback(typeof(DBGJOFLIMPP))]
	private static void ADOEIKABPFL(IntPtr BHMKONDNBED, int GINFBCJKIJI, int GFAOABJFEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EB90", Offset = "0x5B7D990", VA = "0x185B7EB90")]
	private static extern void HCKCHEHGBKI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E9B0", Offset = "0x5B7D7B0", VA = "0x185B7E9B0")]
	private static extern void CFJNAIGHLJC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EB20", Offset = "0x5B7D920", VA = "0x185B7EB20")]
	private static extern int GOIDMOGPNMD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EAA0", Offset = "0x5B7D8A0", VA = "0x185B7EAA0")]
	private static extern int GCJOHONDFPH(int KKIIDNMAMKF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EA20", Offset = "0x5B7D820", VA = "0x185B7EA20")]
	private static extern int DIIPLMBDKKN(int KKIIDNMAMKF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EC00", Offset = "0x5B7DA00", VA = "0x185B7EC00")]
	private static extern int JEOMPBONGDD(int KKIIDNMAMKF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EE70", Offset = "0x5B7DC70", VA = "0x185B7EE70")]
	private static extern int NEODKHPHPNK(int KKIIDNMAMKF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EF80", Offset = "0x5B7DD80", VA = "0x185B7EF80")]
	public GFEFCKODGBA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7E9B0", Offset = "0x5B7D7B0", VA = "0x185B7E9B0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B7EC80", Offset = "0x5B7DA80", VA = "0x185B7EC80")]
	public Rect MFABPIJPKAN(int PAHDMFPPHDB)
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
