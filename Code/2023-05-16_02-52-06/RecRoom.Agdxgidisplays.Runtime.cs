using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JGLDNGGGAPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EPMBDKIMNFF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AOILOKANAAN(IntPtr CCNKPMLIOPA, int MKGODNJCKOC, int JCBHKNNLMCJ);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FIJOBAGDHCE
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6B372C0", Offset = "0x6B360C0", VA = "0x186B372C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6B373A0", Offset = "0x6B361A0", VA = "0x186B373A0")]
	private static extern void HIMJFCLCJEJ(AOILOKANAAN FNIOCOFMFAB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6B37190", Offset = "0x6B35F90", VA = "0x186B37190")]
	[MonoPInvokeCallback(typeof(AOILOKANAAN))]
	private static void AGDLANKDIIG(IntPtr CCNKPMLIOPA, int MKGODNJCKOC, int JCBHKNNLMCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6B37820", Offset = "0x6B36620", VA = "0x186B37820")]
	private static extern void PGIHAENGDGO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6B37330", Offset = "0x6B36130", VA = "0x186B37330")]
	private static extern void EODLEBIIKOC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6B372C0", Offset = "0x6B360C0", VA = "0x186B372C0")]
	private static extern int DOKONIHKHAF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6B375B0", Offset = "0x6B363B0", VA = "0x186B375B0")]
	private static extern int MEOJAALDKGA(int LNJCEIMJDGG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6B374B0", Offset = "0x6B362B0", VA = "0x186B374B0")]
	private static extern int JCHPBCKNFJO(int LNJCEIMJDGG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6B37530", Offset = "0x6B36330", VA = "0x186B37530")]
	private static extern int LALHMOLGLOG(int LNJCEIMJDGG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6B37430", Offset = "0x6B36230", VA = "0x186B37430")]
	private static extern int HPIPDPFCHGG(int LNJCEIMJDGG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6B37890", Offset = "0x6B36690", VA = "0x186B37890")]
	public JGLDNGGGAPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6B37330", Offset = "0x6B36130", VA = "0x186B37330", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6B37630", Offset = "0x6B36430", VA = "0x186B37630")]
	public Rect NBIEDKAJBMJ(int CGDLANGBIDK)
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
