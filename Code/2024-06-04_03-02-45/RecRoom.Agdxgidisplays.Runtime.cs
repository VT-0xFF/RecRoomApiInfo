using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class LGFGJBAGPDJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum NMFFHOMBOLB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OAGHEFBGIBK(IntPtr LOGLBHMJLPF, int GGKCGCGFHKJ, int NLKHFLBBOBK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KDPKNGLKDMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x66D1DF0", Offset = "0x66D05F0", VA = "0x1866D1DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x66D2040", Offset = "0x66D0840", VA = "0x1866D2040")]
	private static extern void IAAOOJPDNGE(OAGHEFBGIBK GLJPAFELCNE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x66D2150", Offset = "0x66D0950", VA = "0x1866D2150")]
	[MonoPInvokeCallback(typeof(OAGHEFBGIBK))]
	private static void MPLMOBDFFGK(IntPtr LOGLBHMJLPF, int GGKCGCGFHKJ, int NLKHFLBBOBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x66D1EE0", Offset = "0x66D06E0", VA = "0x1866D1EE0")]
	private static extern void DIHNAABPOCM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x66D1F50", Offset = "0x66D0750", VA = "0x1866D1F50")]
	private static extern void GIKLILNBKHF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x66D1DF0", Offset = "0x66D05F0", VA = "0x1866D1DF0")]
	private static extern int CDIELKCFPJI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x66D20D0", Offset = "0x66D08D0", VA = "0x1866D20D0")]
	private static extern int KLNGDOFDABJ(int EGNLNANJFMI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x66D1D70", Offset = "0x66D0570", VA = "0x1866D1D70")]
	private static extern int CBMMLICOADA(int EGNLNANJFMI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x66D1E60", Offset = "0x66D0660", VA = "0x1866D1E60")]
	private static extern int DFLIBGCPDAM(int EGNLNANJFMI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x66D1FC0", Offset = "0x66D07C0", VA = "0x1866D1FC0")]
	private static extern int FAECMJHLJOH(int EGNLNANJFMI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x66D2440", Offset = "0x66D0C40", VA = "0x1866D2440")]
	public LGFGJBAGPDJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x66D1F50", Offset = "0x66D0750", VA = "0x1866D1F50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66D2250", Offset = "0x66D0A50", VA = "0x1866D2250")]
	public Rect NDMPGKHOHAE(int LDDOBDPAHNI)
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
