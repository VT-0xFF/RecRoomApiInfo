using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OGCAGLCLHCN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GABDNNNFGAD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GOIDDPLPKBP(IntPtr FBMMFNLPKGA, int IFBIFKFKIDI, int HPGCIEAHHIA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JCBMKIOEKGA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4B46330", Offset = "0x4B44930", VA = "0x184B46330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4B46630", Offset = "0x4B44C30", VA = "0x184B46630")]
	private static extern void JKLJFGJBCFA(GOIDDPLPKBP MCONDHIGJPI);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4B46410", Offset = "0x4B44A10", VA = "0x184B46410")]
	[MonoPInvokeCallback(typeof(GOIDDPLPKBP))]
	private static void GBOCBHLPOEN(IntPtr FBMMFNLPKGA, int IFBIFKFKIDI, int HPGCIEAHHIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4B466C0", Offset = "0x4B44CC0", VA = "0x184B466C0")]
	private static extern void LBKBKLEKILK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4B463A0", Offset = "0x4B449A0", VA = "0x184B463A0")]
	private static extern void JBGNBAOLDPH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4B46330", Offset = "0x4B44930", VA = "0x184B46330")]
	private static extern int HBLJPGOCPHP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4B462B0", Offset = "0x4B448B0", VA = "0x184B462B0")]
	private static extern int CILNNDKHLMF(int LLIGDOJCLHG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4B46530", Offset = "0x4B44B30", VA = "0x184B46530")]
	private static extern int JKFDLNDHLPK(int LLIGDOJCLHG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4B465B0", Offset = "0x4B44BB0", VA = "0x184B465B0")]
	private static extern int JKGMIFKFAIC(int LLIGDOJCLHG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4B46230", Offset = "0x4B44830", VA = "0x184B46230")]
	private static extern int CIDPKFCMEGA(int LLIGDOJCLHG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4B46730", Offset = "0x4B44D30", VA = "0x184B46730")]
	public OGCAGLCLHCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4B463A0", Offset = "0x4B449A0", VA = "0x184B463A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B46040", Offset = "0x4B44640", VA = "0x184B46040")]
	public Rect BDNGDDDPCMD(int JLAGOIKMHDN)
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
