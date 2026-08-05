using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FHLOPHJOONM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum KHAOGHDPJNL
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MLBNIECCALA(IntPtr KOFJNFGLAFK, int NKCDHJPJBIF, int JGKBONPHKPH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IAKMCJPHMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5D0BAB0", Offset = "0x5D0A2B0", VA = "0x185D0BAB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B9A0", Offset = "0x5D0A1A0", VA = "0x185D0B9A0")]
	private static extern void GGGBHGCBJKI(MLBNIECCALA CGEKFPDGHCG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BE10", Offset = "0x5D0A610", VA = "0x185D0BE10")]
	[MonoPInvokeCallback(typeof(MLBNIECCALA))]
	private static void NICFAIFFEKA(IntPtr KOFJNFGLAFK, int NKCDHJPJBIF, int JGKBONPHKPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B930", Offset = "0x5D0A130", VA = "0x185D0B930")]
	private static extern void EBEAKPIECKB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B8C0", Offset = "0x5D0A0C0", VA = "0x185D0B8C0")]
	private static extern void JIBJCAGFJDK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BAB0", Offset = "0x5D0A2B0", VA = "0x185D0BAB0")]
	private static extern int HOGADEIENIN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BBA0", Offset = "0x5D0A3A0", VA = "0x185D0BBA0")]
	private static extern int KFJDLLLCHAC(int MBMFHFDDILC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BF10", Offset = "0x5D0A710", VA = "0x185D0BF10")]
	private static extern int POFBBOMFOFJ(int MBMFHFDDILC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BB20", Offset = "0x5D0A320", VA = "0x185D0BB20")]
	private static extern int HPCELPOLIAM(int MBMFHFDDILC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BA30", Offset = "0x5D0A230", VA = "0x185D0BA30")]
	private static extern int GMGJFIODHCB(int MBMFHFDDILC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BF90", Offset = "0x5D0A790", VA = "0x185D0BF90")]
	public FHLOPHJOONM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5D0B8C0", Offset = "0x5D0A0C0", VA = "0x185D0B8C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5D0BC20", Offset = "0x5D0A420", VA = "0x185D0BC20")]
	public Rect MCIJMMAHEKM(int LNMIMDMOJKO)
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
