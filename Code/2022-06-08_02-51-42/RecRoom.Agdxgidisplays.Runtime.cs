using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HJIHAELMLCI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CFLNHKBBPGL
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AIPMAAAKEOM(IntPtr ANHMAOHNMJC, int DDMFGCPNLGN, int PINBJPPFECI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PKPHANGNLCF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4DA71C0", Offset = "0x4DA61C0", VA = "0x184DA71C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6F50", Offset = "0x4DA5F50", VA = "0x184DA6F50")]
	private static extern void APACECMACEP(AIPMAAAKEOM IJOJDDBGAPC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7520", Offset = "0x4DA6520", VA = "0x184DA7520")]
	[MonoPInvokeCallback(typeof(AIPMAAAKEOM))]
	private static void PJJHBEINLCH(IntPtr ANHMAOHNMJC, int DDMFGCPNLGN, int PINBJPPFECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7150", Offset = "0x4DA6150", VA = "0x184DA7150")]
	private static extern void EMFGCIHFDBD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7060", Offset = "0x4DA6060", VA = "0x184DA7060")]
	private static extern void JOCOGJJNCAL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4DA71C0", Offset = "0x4DA61C0", VA = "0x184DA71C0")]
	private static extern int OLPNOHHMPDN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7230", Offset = "0x4DA6230", VA = "0x184DA7230")]
	private static extern int GHNIDOKIGIN(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4DA72B0", Offset = "0x4DA62B0", VA = "0x184DA72B0")]
	private static extern int GJIBANGCKDL(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4DA6FE0", Offset = "0x4DA5FE0", VA = "0x184DA6FE0")]
	private static extern int DHBBILEMNHJ(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4DA70D0", Offset = "0x4DA60D0", VA = "0x184DA70D0")]
	private static extern int EGEGKNENNEB(int DDEJHPOCOHL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7640", Offset = "0x4DA6640", VA = "0x184DA7640")]
	public HJIHAELMLCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7060", Offset = "0x4DA6060", VA = "0x184DA7060", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4DA7330", Offset = "0x4DA6330", VA = "0x184DA7330")]
	public Rect OIEDFOICELF(int BPFGLODNGKJ)
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
