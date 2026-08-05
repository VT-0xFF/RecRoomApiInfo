using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HDPCOBNINGB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum LNCMHDMDMJF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GILNBKKENME(IntPtr BEODCPFFPCC, int CAPKFCHDLFA, int HGAILLGBPCD);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PADBLOCOBJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6818550", Offset = "0x6817750", VA = "0x186818550")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6818640", Offset = "0x6817840", VA = "0x186818640")]
	private static extern void POKLALCNIID(GILNBKKENME ONAFALABHKI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x68180C0", Offset = "0x68172C0", VA = "0x1868180C0")]
	[MonoPInvokeCallback(typeof(GILNBKKENME))]
	private static void FFFJAEGALDN(IntPtr BEODCPFFPCC, int CAPKFCHDLFA, int HGAILLGBPCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x68181F0", Offset = "0x68173F0", VA = "0x1868181F0")]
	private static extern void IHEKMEOIBOI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6817FD0", Offset = "0x68171D0", VA = "0x186817FD0")]
	private static extern void BIDFMKLILIM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6818550", Offset = "0x6817750", VA = "0x186818550")]
	private static extern int LGECMOLGPLD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6818040", Offset = "0x6817240", VA = "0x186818040")]
	private static extern int DJHAPLDJENN(int IKHNIJKGJFD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x68185C0", Offset = "0x68177C0", VA = "0x1868185C0")]
	private static extern int NKIIGHGHEMG(int IKHNIJKGJFD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x68184D0", Offset = "0x68176D0", VA = "0x1868184D0")]
	private static extern int LEAICJJMBJC(int IKHNIJKGJFD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6818260", Offset = "0x6817460", VA = "0x186818260")]
	private static extern int JOCENKHDHLE(int IKHNIJKGJFD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x68186D0", Offset = "0x68178D0", VA = "0x1868186D0")]
	public HDPCOBNINGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6817FD0", Offset = "0x68171D0", VA = "0x186817FD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68182E0", Offset = "0x68174E0", VA = "0x1868182E0")]
	public Rect LBBECNNHNCO(int IPOGNOECGHL)
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
