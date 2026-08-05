using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JGLMGPHBKDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HFDKJNKCCMD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HHIKPBDNEOI(IntPtr JFILJIAPEEP, int KOIBEABAMCA, int IIFLCFPEBMK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AILFPACJFJL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x15ACDE0", Offset = "0x15ABFE0", VA = "0x1815ACDE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x15AD1F0", Offset = "0x15AC3F0", VA = "0x1815AD1F0")]
	private static extern void JAIPHPIGHFO(HHIKPBDNEOI NMCNKNBHPHF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x15AD0C0", Offset = "0x15AC2C0", VA = "0x1815AD0C0")]
	[MonoPInvokeCallback(typeof(HHIKPBDNEOI))]
	private static void EGHJPEMBGNK(IntPtr JFILJIAPEEP, int KOIBEABAMCA, int IIFLCFPEBMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x15AD400", Offset = "0x15AC600", VA = "0x1815AD400")]
	private static extern void OHLMLHJNBAL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x15ACE50", Offset = "0x15AC050", VA = "0x1815ACE50")]
	private static extern void DGANBHELGEK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x15ACDE0", Offset = "0x15ABFE0", VA = "0x1815ACDE0")]
	private static extern int FKJJLGFBJIB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x15AD280", Offset = "0x15AC480", VA = "0x1815AD280")]
	private static extern int JKBEDGPLHFH(int OOLLEDEIDOE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x15ACD60", Offset = "0x15ABF60", VA = "0x1815ACD60")]
	private static extern int AEIOMMIFIBH(int OOLLEDEIDOE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x15AD380", Offset = "0x15AC580", VA = "0x1815AD380")]
	private static extern int MCJPLOJFHLJ(int OOLLEDEIDOE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x15AD300", Offset = "0x15AC500", VA = "0x1815AD300")]
	private static extern int KOABOJPCIJL(int OOLLEDEIDOE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x15AD470", Offset = "0x15AC670", VA = "0x1815AD470")]
	public JGLMGPHBKDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x15ACE50", Offset = "0x15AC050", VA = "0x1815ACE50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x15ACEC0", Offset = "0x15AC0C0", VA = "0x1815ACEC0")]
	public Rect DHMJGMCMPDN(int JPANOEAHOPI)
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
