using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MHFHPGIKLPF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum DADNANNBJFP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void HPFOCINGCAB(IntPtr FLDKBCEOGMK, int GBNBGNMHGLO, int GDNJDGCPNNI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int LAJJAMKIOIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6A1F500", Offset = "0x6A1DF00", VA = "0x186A1F500")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F5F0", Offset = "0x6A1DFF0", VA = "0x186A1F5F0")]
	private static extern void FHMLCPANHLC(HPFOCINGCAB MIKGEIBIMCG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F700", Offset = "0x6A1E100", VA = "0x186A1F700")]
	[MonoPInvokeCallback(typeof(HPFOCINGCAB))]
	private static void HPOHFLPJABH(IntPtr FLDKBCEOGMK, int GBNBGNMHGLO, int GDNJDGCPNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F8B0", Offset = "0x6A1E2B0", VA = "0x186A1F8B0")]
	private static extern void KADCCJJCHBP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F490", Offset = "0x6A1DE90", VA = "0x186A1F490")]
	private static extern void LJDBPFPEKIO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F500", Offset = "0x6A1DF00", VA = "0x186A1F500")]
	private static extern int EBHEKLKOFAK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F410", Offset = "0x6A1DE10", VA = "0x186A1F410")]
	private static extern int DBLABMMIAKA(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F570", Offset = "0x6A1DF70", VA = "0x186A1F570")]
	private static extern int FBNMIOFCEHN(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F830", Offset = "0x6A1E230", VA = "0x186A1F830")]
	private static extern int JPGDPMBJHEB(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F680", Offset = "0x6A1E080", VA = "0x186A1F680")]
	private static extern int FJOAONMPKKJ(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A1FB10", Offset = "0x6A1E510", VA = "0x186A1FB10")]
	public MHFHPGIKLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F490", Offset = "0x6A1DE90", VA = "0x186A1F490", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A1F920", Offset = "0x6A1E320", VA = "0x186A1F920")]
	public Rect NNNOONFAPNK(int OOCGCLMKIMH)
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
