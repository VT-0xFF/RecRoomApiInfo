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
		[Cpp2IlInjected.Address(RVA = "0x40C2920", Offset = "0x40C1B20", VA = "0x1840C2920")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x40C2810", Offset = "0x40C1A10", VA = "0x1840C2810")]
	private static extern void FBGLDELJHPI(JBCMKBPPFII JHEAOCMILMA);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x40C2680", Offset = "0x40C1880", VA = "0x1840C2680")]
	[MonoPInvokeCallback(typeof(JBCMKBPPFII))]
	private static void DPDIEGNLKOD(IntPtr NDCMNJFIHLG, int LMCPNDFGEGE, int KNPJABEEHLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x40C2590", Offset = "0x40C1790", VA = "0x1840C2590")]
	private static extern void AIGIAAOCGPC();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x40C27A0", Offset = "0x40C19A0", VA = "0x1840C27A0")]
	private static extern void MCCIKMKBPBD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x40C2920", Offset = "0x40C1B20", VA = "0x1840C2920")]
	private static extern int KNJAKJDKJPD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x40C2990", Offset = "0x40C1B90", VA = "0x1840C2990")]
	private static extern int JPNDFOECJOF(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x40C2C00", Offset = "0x40C1E00", VA = "0x1840C2C00")]
	private static extern int LGEHOGNBPDG(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40C28A0", Offset = "0x40C1AA0", VA = "0x1840C28A0")]
	private static extern int FOCCEKGPMGG(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x40C2600", Offset = "0x40C1800", VA = "0x1840C2600")]
	private static extern int CEDJAGKGIMF(int HNDJNNFIENP);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x40C2C80", Offset = "0x40C1E80", VA = "0x1840C2C80")]
	public DFKBKGAAGNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x40C27A0", Offset = "0x40C19A0", VA = "0x1840C27A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40C2A10", Offset = "0x40C1C10", VA = "0x1840C2A10")]
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
