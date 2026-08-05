using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HNAPMKHKBKD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JGCCDMGJBKP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KIMBMHKMAKP(IntPtr BDAAOBFBLIB, int HIAJHKACHMC, int HMJKOHCGOCN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PGFFANHEIFK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60597D0", Offset = "0x6058BD0", VA = "0x1860597D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6059AA0", Offset = "0x6058EA0", VA = "0x186059AA0")]
	private static extern void LOGHJGOCOLM(KIMBMHKMAKP KCNCNEMPBGA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6059B30", Offset = "0x6058F30", VA = "0x186059B30")]
	[MonoPInvokeCallback(typeof(KIMBMHKMAKP))]
	private static void MEFHNEFJKNJ(IntPtr BDAAOBFBLIB, int HIAJHKACHMC, int HMJKOHCGOCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60599B0", Offset = "0x6058DB0", VA = "0x1860599B0")]
	private static extern void EOPEJCOCBHD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6059940", Offset = "0x6058D40", VA = "0x186059940")]
	private static extern void PAJJIOLCBFG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60597D0", Offset = "0x6058BD0", VA = "0x1860597D0")]
	private static extern int CKIEAKJDPDK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6059A20", Offset = "0x6058E20", VA = "0x186059A20")]
	private static extern int GPJALLHGBDL(int BFMGPLIBCKL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6059840", Offset = "0x6058C40", VA = "0x186059840")]
	private static extern int BPOKDKEAACH(int BFMGPLIBCKL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6059750", Offset = "0x6058B50", VA = "0x186059750")]
	private static extern int BHKLKDDLGDH(int BFMGPLIBCKL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60598C0", Offset = "0x6058CC0", VA = "0x1860598C0")]
	private static extern int COMHKIMPHOD(int BFMGPLIBCKL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6059E20", Offset = "0x6059220", VA = "0x186059E20")]
	public HNAPMKHKBKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6059940", Offset = "0x6058D40", VA = "0x186059940", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6059C30", Offset = "0x6059030", VA = "0x186059C30")]
	public Rect NFHMMDDCJEB(int CCJGIFJJHMJ)
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
