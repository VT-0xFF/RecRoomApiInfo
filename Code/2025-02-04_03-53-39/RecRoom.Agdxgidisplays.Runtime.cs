using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JEHAGFDEPHO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum ABLECGCPDPO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DDCNDHIINHP(IntPtr HJFGAIAKKLJ, int IECADCKMGOP, int FDPEIDCJCCH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PNGPMEBGEBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7084290", Offset = "0x7083090", VA = "0x187084290")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7084470", Offset = "0x7083270", VA = "0x187084470")]
	private static extern void LBLCJEFJKDF(DDCNDHIINHP JMGOMJNPFIN);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7084370", Offset = "0x7083170", VA = "0x187084370")]
	[MonoPInvokeCallback(typeof(DDCNDHIINHP))]
	private static void KIJMDOABJJF(IntPtr HJFGAIAKKLJ, int IECADCKMGOP, int FDPEIDCJCCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7084300", Offset = "0x7083100", VA = "0x187084300")]
	private static extern void JEELJGCJJCO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7084220", Offset = "0x7083020", VA = "0x187084220")]
	private static extern void OKEFADLOOGN();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7084290", Offset = "0x7083090", VA = "0x187084290")]
	private static extern int EINPPJBLOLJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7084500", Offset = "0x7083300", VA = "0x187084500")]
	private static extern int MAPLNCCFPIK(int MIFPCBFGGLI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7084120", Offset = "0x7082F20", VA = "0x187084120")]
	private static extern int BJMNAJLIENK(int MIFPCBFGGLI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x70841A0", Offset = "0x7082FA0", VA = "0x1870841A0")]
	private static extern int DNLNIHAGNHM(int MIFPCBFGGLI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7084580", Offset = "0x7083380", VA = "0x187084580")]
	private static extern int NHLCAEPPLON(int MIFPCBFGGLI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70847F0", Offset = "0x70835F0", VA = "0x1870847F0")]
	public JEHAGFDEPHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7084220", Offset = "0x7083020", VA = "0x187084220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7084600", Offset = "0x7083400", VA = "0x187084600")]
	public Rect PKPDFBMCBFE(int MPJIKKFAHCD)
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
