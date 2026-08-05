using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DLJGJGELCEF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LLKIDOMIGEM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void IPIBGJKJNBF(IntPtr BLIDGDGMCAP, int BGDDCGNLDBK, int JNPGGGONHIN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IIICKONBGPO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6E048D0", Offset = "0x6E03CD0", VA = "0x186E048D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6E04840", Offset = "0x6E03C40", VA = "0x186E04840")]
	private static extern void JDIJKIGFEGP(IPIBGJKJNBF CPIKECCHPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6E04A40", Offset = "0x6E03E40", VA = "0x186E04A40")]
	[MonoPInvokeCallback(typeof(IPIBGJKJNBF))]
	private static void NDCEHKFDEMD(IntPtr BLIDGDGMCAP, int BGDDCGNLDBK, int JNPGGGONHIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6E04D30", Offset = "0x6E04130", VA = "0x186E04D30")]
	private static extern void OOJJEJPOBFE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6E04750", Offset = "0x6E03B50", VA = "0x186E04750")]
	private static extern void KHDDIABJOJM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6E048D0", Offset = "0x6E03CD0", VA = "0x186E048D0")]
	private static extern int OKDLCLCCGOF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6E047C0", Offset = "0x6E03BC0", VA = "0x186E047C0")]
	private static extern int GOIIIDHJEKE(int LPMIIFILJPI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6E04940", Offset = "0x6E03D40", VA = "0x186E04940")]
	private static extern int MJOEJKCKKFI(int LPMIIFILJPI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6E046D0", Offset = "0x6E03AD0", VA = "0x186E046D0")]
	private static extern int BPNMGOLJEKC(int LPMIIFILJPI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6E049C0", Offset = "0x6E03DC0", VA = "0x186E049C0")]
	private static extern int MJOGONFANFM(int LPMIIFILJPI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6E04DA0", Offset = "0x6E041A0", VA = "0x186E04DA0")]
	public DLJGJGELCEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6E04750", Offset = "0x6E03B50", VA = "0x186E04750", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6E04B40", Offset = "0x6E03F40", VA = "0x186E04B40")]
	public Rect ONCPOCPEDNP(int KMEEFMEDDDB)
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
