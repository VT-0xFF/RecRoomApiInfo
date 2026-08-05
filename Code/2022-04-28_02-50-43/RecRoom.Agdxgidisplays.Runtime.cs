using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JEGABINMGAI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MOIBFCHHENG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void LELKHEFHCED(IntPtr HIMFANHOMLL, int AADFONHDDBM, int OJMPEBGHLGN);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FHFMPCBDPKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4C2C330", Offset = "0x4C2B530", VA = "0x184C2C330")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C890", Offset = "0x4C2BA90", VA = "0x184C2C890")]
	private static extern void LIOANEKEGOO(LELKHEFHCED AGNPCLIMAAG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C580", Offset = "0x4C2B780", VA = "0x184C2C580")]
	[MonoPInvokeCallback(typeof(LELKHEFHCED))]
	private static void JMCJOCNLKDJ(IntPtr HIMFANHOMLL, int AADFONHDDBM, int OJMPEBGHLGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C3A0", Offset = "0x4C2B5A0", VA = "0x184C2C3A0")]
	private static extern void DMAPEOFMGGD();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C410", Offset = "0x4C2B610", VA = "0x184C2C410")]
	private static extern void OMEKAGFFNOL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C330", Offset = "0x4C2B530", VA = "0x184C2C330")]
	private static extern int KMMFKLLEBEB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C480", Offset = "0x4C2B680", VA = "0x184C2C480")]
	private static extern int GKFKLABJAHA(int LLDODNFBFON);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C500", Offset = "0x4C2B700", VA = "0x184C2C500")]
	private static extern int JGAOOMENHIK(int LLDODNFBFON);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C920", Offset = "0x4C2BB20", VA = "0x184C2C920")]
	private static extern int LNCALKDINKD(int LLDODNFBFON);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C9A0", Offset = "0x4C2BBA0", VA = "0x184C2C9A0")]
	private static extern int MBDEIKDLDKF(int LLDODNFBFON);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4C2CA20", Offset = "0x4C2BC20", VA = "0x184C2CA20")]
	public JEGABINMGAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C410", Offset = "0x4C2B610", VA = "0x184C2C410", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4C2C6A0", Offset = "0x4C2B8A0", VA = "0x184C2C6A0")]
	public Rect LBMAMFOONPC(int NMPJGBFHMIG)
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
