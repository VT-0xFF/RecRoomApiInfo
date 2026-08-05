using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DFKBKGAAGNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JANBPEBGCON
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void JBCMKBPPFII(IntPtr NDCMNJFIHLG, int LMCPNDFGEGE, int KNPJABEEHLL);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int MJOEDLPBOIB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xDD1900", Offset = "0xDD0B00", VA = "0x180DD1900")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xDD17F0", Offset = "0xDD09F0", VA = "0x180DD17F0")]
	private static extern void FBGLDELJHPI(JBCMKBPPFII JHEAOCMILMA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xDD1660", Offset = "0xDD0860", VA = "0x180DD1660")]
	[MonoPInvokeCallback(typeof(JBCMKBPPFII))]
	private static void DPDIEGNLKOD(IntPtr NDCMNJFIHLG, int LMCPNDFGEGE, int KNPJABEEHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0xDD1570", Offset = "0xDD0770", VA = "0x180DD1570")]
	private static extern void AIGIAAOCGPC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0xDD1780", Offset = "0xDD0980", VA = "0x180DD1780")]
	private static extern void MCCIKMKBPBD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0xDD1900", Offset = "0xDD0B00", VA = "0x180DD1900")]
	private static extern int KNJAKJDKJPD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0xDD1970", Offset = "0xDD0B70", VA = "0x180DD1970")]
	private static extern int JPNDFOECJOF(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0xDD1BE0", Offset = "0xDD0DE0", VA = "0x180DD1BE0")]
	private static extern int LGEHOGNBPDG(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xDD1880", Offset = "0xDD0A80", VA = "0x180DD1880")]
	private static extern int FOCCEKGPMGG(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0xDD15E0", Offset = "0xDD07E0", VA = "0x180DD15E0")]
	private static extern int CEDJAGKGIMF(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0xDD1C60", Offset = "0xDD0E60", VA = "0x180DD1C60")]
	public DFKBKGAAGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0xDD1780", Offset = "0xDD0980", VA = "0x180DD1780", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xDD19F0", Offset = "0xDD0BF0", VA = "0x180DD19F0")]
	public Rect KFHKAAHOAPC(int HIANENDODLG)
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
