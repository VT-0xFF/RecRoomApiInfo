using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KAJALEFGJPE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JEBJJFCEJFH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BMFBBCANEBM(IntPtr EPBMFNKJBDG, int BLFDIIPJAOG, int BCHNNIICGFO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int ODMEAGBABAM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x43F0DB0", Offset = "0x43F01B0", VA = "0x1843F0DB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x43F0EA0", Offset = "0x43F02A0", VA = "0x1843F0EA0")]
	private static extern void LEEHDDMPMNO(BMFBBCANEBM KPMKLLFNKEH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x43F0F30", Offset = "0x43F0330", VA = "0x1843F0F30")]
	[MonoPInvokeCallback(typeof(BMFBBCANEBM))]
	private static void LHMNFBCBBBJ(IntPtr EPBMFNKJBDG, int BLFDIIPJAOG, int BCHNNIICGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x43F0BD0", Offset = "0x43EFFD0", VA = "0x1843F0BD0")]
	private static extern void CKCBJFDIGHG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x43F0C40", Offset = "0x43F0040", VA = "0x1843F0C40")]
	private static extern void FJFFOKODPGL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x43F0DB0", Offset = "0x43F01B0", VA = "0x1843F0DB0")]
	private static extern int JAONPBANACI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x43F0CB0", Offset = "0x43F00B0", VA = "0x1843F0CB0")]
	private static extern int EJBMGMBDMGA(int GABNOGEDINC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x43F1050", Offset = "0x43F0450", VA = "0x1843F1050")]
	private static extern int NBNOHGAFPPC(int GABNOGEDINC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x43F0D30", Offset = "0x43F0130", VA = "0x1843F0D30")]
	private static extern int HNNKBDHILED(int GABNOGEDINC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x43F0E20", Offset = "0x43F0220", VA = "0x1843F0E20")]
	private static extern int KOOBGDAGDLI(int GABNOGEDINC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x43F12C0", Offset = "0x43F06C0", VA = "0x1843F12C0")]
	public KAJALEFGJPE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x43F0C40", Offset = "0x43F0040", VA = "0x1843F0C40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43F10D0", Offset = "0x43F04D0", VA = "0x1843F10D0")]
	public Rect NKEECBKBGBP(int OKDGHMLLCBL)
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
