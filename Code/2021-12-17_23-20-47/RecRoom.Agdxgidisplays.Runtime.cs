using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class DGPDJCIGEIO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum OKJGKJENLGO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void PAELBCHIDPN(IntPtr CFDPIBAMHCJ, int JAOGIBPIKCP, int LGBNPELNHBI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EMMPMELAHBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x43F46D0", Offset = "0x43F32D0", VA = "0x1843F46D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x43F4A40", Offset = "0x43F3640", VA = "0x1843F4A40")]
	private static extern void MMCMKFGNKAK(PAELBCHIDPN HOOMNAEGALB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43F4830", Offset = "0x43F3430", VA = "0x1843F4830")]
	[MonoPInvokeCallback(typeof(PAELBCHIDPN))]
	private static void CNBAGLFBKML(IntPtr CFDPIBAMHCJ, int JAOGIBPIKCP, int LGBNPELNHBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43F4740", Offset = "0x43F3340", VA = "0x1843F4740")]
	private static extern void BCIINOHGNDF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x43F4950", Offset = "0x43F3550", VA = "0x1843F4950")]
	private static extern void JAHILOHEIIG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43F46D0", Offset = "0x43F32D0", VA = "0x1843F46D0")]
	private static extern int APIFEGHJGCN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43F49C0", Offset = "0x43F35C0", VA = "0x1843F49C0")]
	private static extern int KJLHHDADEGJ(int EKFMAMHCIBC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43F43E0", Offset = "0x43F2FE0", VA = "0x1843F43E0")]
	private static extern int AIFILJLIEOL(int EKFMAMHCIBC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43F47B0", Offset = "0x43F33B0", VA = "0x1843F47B0")]
	private static extern int CCHLHAAONFG(int EKFMAMHCIBC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43F4460", Offset = "0x43F3060", VA = "0x1843F4460")]
	private static extern int AKDINBCDDOG(int EKFMAMHCIBC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43F4AD0", Offset = "0x43F36D0", VA = "0x1843F4AD0")]
	public DGPDJCIGEIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43F4950", Offset = "0x43F3550", VA = "0x1843F4950", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43F44E0", Offset = "0x43F30E0", VA = "0x1843F44E0")]
	public Rect AMGCPFIMCFO(int KGFHMACKKCG)
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
