using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GDDECOKJGFE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FCHMLGKDBGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GOONAGOOAPG(IntPtr FFCKKLMEDCM, int JKPCFCCBIBE, int CJHLLHGGMDE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PCHOEHPNOIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4090FD0", Offset = "0x40903D0", VA = "0x184090FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x40915B0", Offset = "0x40909B0", VA = "0x1840915B0")]
	private static extern void PPIJIGEONFM(GOONAGOOAPG MCNIGODLGGL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x40910B0", Offset = "0x40904B0", VA = "0x1840910B0")]
	[MonoPInvokeCallback(typeof(GOONAGOOAPG))]
	private static void EAMPOEOIFPN(IntPtr FFCKKLMEDCM, int JKPCFCCBIBE, int CJHLLHGGMDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x40913C0", Offset = "0x40907C0", VA = "0x1840913C0")]
	private static extern void FGDCIMBBOLJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4091040", Offset = "0x4090440", VA = "0x184091040")]
	private static extern void JCHLBMEDEKG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4090FD0", Offset = "0x40903D0", VA = "0x184090FD0")]
	private static extern int JICACNAHHOP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4091530", Offset = "0x4090930", VA = "0x184091530")]
	private static extern int MNMJECLLEKK(int GLOEJNOCKGC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4091430", Offset = "0x4090830", VA = "0x184091430")]
	private static extern int FLFLBBEFLGP(int GLOEJNOCKGC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x40914B0", Offset = "0x40908B0", VA = "0x1840914B0")]
	private static extern int JDDMKDHFOMF(int GLOEJNOCKGC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4090F50", Offset = "0x4090350", VA = "0x184090F50")]
	private static extern int CNPBKBDMOBP(int GLOEJNOCKGC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4091640", Offset = "0x4090A40", VA = "0x184091640")]
	public GDDECOKJGFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4091040", Offset = "0x4090440", VA = "0x184091040", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x40911D0", Offset = "0x40905D0", VA = "0x1840911D0")]
	public Rect FDCGGCMHLHE(int GNBDOPBNJGE)
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
