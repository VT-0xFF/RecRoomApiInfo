using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GALFMCKEKBC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BIEBMFIGICE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void FAPHMLIMPGJ(IntPtr PJJLMKEBMEE, int OLGJFEONMLB, int BJPDNIPMIDD);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BKCHHDKABAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1A6CBF0", Offset = "0x1A6BFF0", VA = "0x181A6CBF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C8C0", Offset = "0x1A6BCC0", VA = "0x181A6C8C0")]
	private static extern void CPPIBIHHADA(FAPHMLIMPGJ KCKLDKHBENC);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CA40", Offset = "0x1A6BE40", VA = "0x181A6CA40")]
	[MonoPInvokeCallback(typeof(FAPHMLIMPGJ))]
	private static void EBHBHBPGOGJ(IntPtr PJJLMKEBMEE, int OLGJFEONMLB, int BJPDNIPMIDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CE50", Offset = "0x1A6C250", VA = "0x181A6CE50")]
	private static extern void NPFGFFCDMGH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C9D0", Offset = "0x1A6BDD0", VA = "0x181A6C9D0")]
	private static extern void FHCKJJIMOPJ();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CBF0", Offset = "0x1A6BFF0", VA = "0x181A6CBF0")]
	private static extern int FHPKLFCCHCO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C950", Offset = "0x1A6BD50", VA = "0x181A6C950")]
	private static extern int DODCPKNLMEC(int BJKMNBIBKCI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C840", Offset = "0x1A6BC40", VA = "0x181A6C840")]
	private static extern int BNICEGDJKOJ(int BJKMNBIBKCI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CEC0", Offset = "0x1A6C2C0", VA = "0x181A6CEC0")]
	private static extern int PDOLPMCGOFA(int BJKMNBIBKCI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CB70", Offset = "0x1A6BF70", VA = "0x181A6CB70")]
	private static extern int EEAIDEJACED(int BJKMNBIBKCI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CF40", Offset = "0x1A6C340", VA = "0x181A6CF40")]
	public GALFMCKEKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1A6C9D0", Offset = "0x1A6BDD0", VA = "0x181A6C9D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1A6CC60", Offset = "0x1A6C060", VA = "0x181A6CC60")]
	public Rect JOIFPNLDCAL(int CPHCBLFLCBK)
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
