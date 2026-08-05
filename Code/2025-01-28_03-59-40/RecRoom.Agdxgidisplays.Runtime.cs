using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GHCGHBICJJP : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CEIGANIMOJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void JGDAHKFCDAE(IntPtr JLBJPEIMAMB, int AFLMMFDMNOE, int IBMPHPNHKAJ);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int INLFMGLALMN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7026DF0", Offset = "0x7025FF0", VA = "0x187026DF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7026F60", Offset = "0x7026160", VA = "0x187026F60")]
	private static extern void BNIHGCDCMLA(JGDAHKFCDAE FOCHKIPOIOG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7026E60", Offset = "0x7026060", VA = "0x187026E60")]
	[MonoPInvokeCallback(typeof(JGDAHKFCDAE))]
	private static void BIAMIIFLBCO(IntPtr JLBJPEIMAMB, int AFLMMFDMNOE, int IBMPHPNHKAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7027160", Offset = "0x7026360", VA = "0x187027160")]
	private static extern void GGPOBANFNOP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7027070", Offset = "0x7026270", VA = "0x187027070")]
	private static extern void MCMEKBBOOKD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7026DF0", Offset = "0x7025FF0", VA = "0x187026DF0")]
	private static extern int ENCLONIAMHC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7027250", Offset = "0x7026450", VA = "0x187027250")]
	private static extern int KLIFNNFDDOE(int BEHEHKFONGA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x70271D0", Offset = "0x70263D0", VA = "0x1870271D0")]
	private static extern int HNBDOKKHBIO(int BEHEHKFONGA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7026FF0", Offset = "0x70261F0", VA = "0x187026FF0")]
	private static extern int DBLKNBMKJGN(int BEHEHKFONGA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x70270E0", Offset = "0x70262E0", VA = "0x1870270E0")]
	private static extern int EEDAPNCIHNP(int BEHEHKFONGA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x70274C0", Offset = "0x70266C0", VA = "0x1870274C0")]
	public GHCGHBICJJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7027070", Offset = "0x7026270", VA = "0x187027070", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x70272D0", Offset = "0x70264D0", VA = "0x1870272D0")]
	public Rect MONHJDKDPBB(int OPGDJHEDJIC)
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
