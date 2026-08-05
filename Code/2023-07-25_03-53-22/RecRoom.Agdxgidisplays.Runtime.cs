using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ICIIMPJMFGO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DCHJJCOCGIC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void PENAPEGKMPF(IntPtr CFOFEENKFCN, int BKMCHKCIDOC, int MDPKAMGJLCA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MBJKBOCAICE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x730CB50", Offset = "0x730BB50", VA = "0x18730CB50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x730D0A0", Offset = "0x730C0A0", VA = "0x18730D0A0")]
	private static extern void ODJAGJGDKAK(PENAPEGKMPF ELHFOIEJAFO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x730D130", Offset = "0x730C130", VA = "0x18730D130")]
	[MonoPInvokeCallback(typeof(PENAPEGKMPF))]
	private static void PKJCBOKJKGB(IntPtr CFOFEENKFCN, int BKMCHKCIDOC, int MDPKAMGJLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x730CFB0", Offset = "0x730BFB0", VA = "0x18730CFB0")]
	private static extern void LLEBBJIFEDK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x730CDC0", Offset = "0x730BDC0", VA = "0x18730CDC0")]
	private static extern void FBFEOOMKEKE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x730CB50", Offset = "0x730BB50", VA = "0x18730CB50")]
	private static extern int NPHMPGLDIID();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x730CF30", Offset = "0x730BF30", VA = "0x18730CF30")]
	private static extern int HLBBBBJMMOO(int IACOMDKJFAL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x730CEB0", Offset = "0x730BEB0", VA = "0x18730CEB0")]
	private static extern int FCEHDKCNMMF(int IACOMDKJFAL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x730D020", Offset = "0x730C020", VA = "0x18730D020")]
	private static extern int MJJFBHOLFCK(int IACOMDKJFAL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x730CE30", Offset = "0x730BE30", VA = "0x18730CE30")]
	private static extern int FBELBIDENBG(int IACOMDKJFAL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x730D260", Offset = "0x730C260", VA = "0x18730D260")]
	public ICIIMPJMFGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x730CDC0", Offset = "0x730BDC0", VA = "0x18730CDC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x730CBC0", Offset = "0x730BBC0", VA = "0x18730CBC0")]
	public Rect DKHIOKFEEIP(int FLNLGMNFJIO)
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
