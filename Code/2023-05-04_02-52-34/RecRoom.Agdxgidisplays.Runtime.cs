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
		[Cpp2IlInjected.Address(RVA = "0x6A46370", Offset = "0x6A45770", VA = "0x186A46370")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6A46460", Offset = "0x6A45860", VA = "0x186A46460")]
	private static extern void FHMLCPANHLC(HPFOCINGCAB MIKGEIBIMCG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6A46570", Offset = "0x6A45970", VA = "0x186A46570")]
	[MonoPInvokeCallback(typeof(HPFOCINGCAB))]
	private static void HPOHFLPJABH(IntPtr FLDKBCEOGMK, int GBNBGNMHGLO, int GDNJDGCPNNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6A46720", Offset = "0x6A45B20", VA = "0x186A46720")]
	private static extern void KADCCJJCHBP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6A46300", Offset = "0x6A45700", VA = "0x186A46300")]
	private static extern void LJDBPFPEKIO();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6A46370", Offset = "0x6A45770", VA = "0x186A46370")]
	private static extern int EBHEKLKOFAK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6A46280", Offset = "0x6A45680", VA = "0x186A46280")]
	private static extern int DBLABMMIAKA(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6A463E0", Offset = "0x6A457E0", VA = "0x186A463E0")]
	private static extern int FBNMIOFCEHN(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6A466A0", Offset = "0x6A45AA0", VA = "0x186A466A0")]
	private static extern int JPGDPMBJHEB(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6A464F0", Offset = "0x6A458F0", VA = "0x186A464F0")]
	private static extern int FJOAONMPKKJ(int PKNOIGMENLD);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6A46980", Offset = "0x6A45D80", VA = "0x186A46980")]
	public MHFHPGIKLPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A46300", Offset = "0x6A45700", VA = "0x186A46300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A46790", Offset = "0x6A45B90", VA = "0x186A46790")]
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
