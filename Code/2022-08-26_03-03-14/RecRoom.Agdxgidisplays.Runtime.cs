using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JONJNNNNPEJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PBPPOJELAEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void IHJFINNNDKG(IntPtr IMIDEOCLBEC, int OEBMILJLIAL, int JMDGIINHLGA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GDOJJNGOEGE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x58B3710", Offset = "0x58B2310", VA = "0x1858B3710")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x58B3780", Offset = "0x58B2380", VA = "0x1858B3780")]
	private static extern void DIOBBPJKMLI(IHJFINNNDKG KCGMNIDCJMF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x58B3900", Offset = "0x58B2500", VA = "0x1858B3900")]
	[MonoPInvokeCallback(typeof(IHJFINNNDKG))]
	private static void FNALPKCAOKI(IntPtr IMIDEOCLBEC, int OEBMILJLIAL, int JMDGIINHLGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x58B3D90", Offset = "0x58B2990", VA = "0x1858B3D90")]
	private static extern void NEDKCOBOAHP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x58B3810", Offset = "0x58B2410", VA = "0x1858B3810")]
	private static extern void JANKJHCNDPM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x58B3710", Offset = "0x58B2310", VA = "0x1858B3710")]
	private static extern int CLPNEDGMCOL();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x58B3AA0", Offset = "0x58B26A0", VA = "0x1858B3AA0")]
	private static extern int HJPODJPCNKM(int DJHPMDEHJMK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x58B3D10", Offset = "0x58B2910", VA = "0x1858B3D10")]
	private static extern int JCMKNOGPENF(int DJHPMDEHJMK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x58B3A20", Offset = "0x58B2620", VA = "0x1858B3A20")]
	private static extern int GGLFFJPIBMH(int DJHPMDEHJMK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x58B3880", Offset = "0x58B2480", VA = "0x1858B3880")]
	private static extern int EAIJHMFJPCP(int DJHPMDEHJMK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x58B3E00", Offset = "0x58B2A00", VA = "0x1858B3E00")]
	public JONJNNNNPEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x58B3810", Offset = "0x58B2410", VA = "0x1858B3810", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x58B3B20", Offset = "0x58B2720", VA = "0x1858B3B20")]
	public Rect IOBEKJKHLLF(int DJJBCNKDMDJ)
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
