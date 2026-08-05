using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OMJAAGOMBGP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FBDPKJGJFPJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CJIPBKJHPII(IntPtr OHOKHLNBDDB, int OPKPFANIILK, int JBFAICFLPCP);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int AIOIAEEJEFM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7A89E90", Offset = "0x7A88890", VA = "0x187A89E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7A89B20", Offset = "0x7A88520", VA = "0x187A89B20")]
	private static extern void BCFOCKGBKIP(CJIPBKJHPII DMDJELFGCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7A89C90", Offset = "0x7A88690", VA = "0x187A89C90")]
	[MonoPInvokeCallback(typeof(CJIPBKJHPII))]
	private static void EOFGEONDLHF(IntPtr OHOKHLNBDDB, int OPKPFANIILK, int JBFAICFLPCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7A89BB0", Offset = "0x7A885B0", VA = "0x187A89BB0")]
	private static extern void DBILOAODCDE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7A89C20", Offset = "0x7A88620", VA = "0x187A89C20")]
	private static extern void NGBPLEIOOKD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7A89E90", Offset = "0x7A88890", VA = "0x187A89E90")]
	private static extern int HOEEFLPGEMM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7A89E10", Offset = "0x7A88810", VA = "0x187A89E10")]
	private static extern int GHGFAIALOIH(int KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7A89D90", Offset = "0x7A88790", VA = "0x187A89D90")]
	private static extern int GANEBKNMFEM(int KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A170", Offset = "0x7A88B70", VA = "0x187A8A170")]
	private static extern int PANODDJMNOM(int KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A0F0", Offset = "0x7A88AF0", VA = "0x187A8A0F0")]
	private static extern int NPIHCKINNAK(int KHNIMGKFPOO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7A8A1F0", Offset = "0x7A88BF0", VA = "0x187A8A1F0")]
	public OMJAAGOMBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7A89C20", Offset = "0x7A88620", VA = "0x187A89C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7A89F00", Offset = "0x7A88900", VA = "0x187A89F00")]
	public Rect MJHMPMLJCPM(int HKNCAPMGBCM)
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
