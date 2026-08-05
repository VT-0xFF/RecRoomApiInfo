using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class ELEMOJKLAAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JBGGBKHFMIP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OGOMJOCPNPH(IntPtr LIPNPCINFLG, int BKLOHAHJLKP, int FAPMBPGLKBO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EODGIACFEJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7E8C900", Offset = "0x7E8B900", VA = "0x187E8C900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CBE0", Offset = "0x7E8BBE0", VA = "0x187E8CBE0")]
	private static extern void JPBFGCFPBJE(OGOMJOCPNPH HCEFPMMOBCM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CCF0", Offset = "0x7E8BCF0", VA = "0x187E8CCF0")]
	[MonoPInvokeCallback(typeof(OGOMJOCPNPH))]
	private static void MANHBMJNLMB(IntPtr LIPNPCINFLG, int BKLOHAHJLKP, int FAPMBPGLKBO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CDF0", Offset = "0x7E8BDF0", VA = "0x187E8CDF0")]
	private static extern void OCOPJMCPGIB();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C890", Offset = "0x7E8B890", VA = "0x187E8C890")]
	private static extern void ELFEOMJMDON();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C900", Offset = "0x7E8B900", VA = "0x187E8C900")]
	private static extern int FBLHFPEHIHB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CB60", Offset = "0x7E8BB60", VA = "0x187E8CB60")]
	private static extern int ICLKGIEHEIP(int PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CC70", Offset = "0x7E8BC70", VA = "0x187E8CC70")]
	private static extern int LAMACHGCIKC(int PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C810", Offset = "0x7E8B810", VA = "0x187E8C810")]
	private static extern int DJHIHMHPEPD(int PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CE60", Offset = "0x7E8BE60", VA = "0x187E8CE60")]
	private static extern int PJKBHGFPLKK(int PBJHGGBBAAF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E8CEE0", Offset = "0x7E8BEE0", VA = "0x187E8CEE0")]
	public ELEMOJKLAAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C890", Offset = "0x7E8B890", VA = "0x187E8C890", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E8C970", Offset = "0x7E8B970", VA = "0x187E8C970")]
	public Rect GBPPFILCNGN(int CLMIFCKOILP)
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
