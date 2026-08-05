using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NCFAGIECEJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BFJNEKGHBMH
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AEBHNJMPPNE(IntPtr PGCEOMNLPAE, int LEGDMNLNDAK, int CAFHDHHPDFD);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NOOEDDEFAIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C29D80", Offset = "0x6C28780", VA = "0x186C29D80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C29BF0", Offset = "0x6C285F0", VA = "0x186C29BF0")]
	private static extern void AEICIMLIJPE(AEBHNJMPPNE HFJNADOBPEL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A140", Offset = "0x6C28B40", VA = "0x186C2A140")]
	[MonoPInvokeCallback(typeof(AEBHNJMPPNE))]
	private static void PKGBEGHIHLA(IntPtr PGCEOMNLPAE, int LEGDMNLNDAK, int CAFHDHHPDFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A050", Offset = "0x6C28A50", VA = "0x186C2A050")]
	private static extern void GCHKJEOLKFE();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C29DF0", Offset = "0x6C287F0", VA = "0x186C29DF0")]
	private static extern void MCDKPFDLKAE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C29D80", Offset = "0x6C28780", VA = "0x186C29D80")]
	private static extern int DPHEBAEINIE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C29C80", Offset = "0x6C28680", VA = "0x186C29C80")]
	private static extern int ALKAIHEIIIO(int CMEADPACGME);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C29D00", Offset = "0x6C28700", VA = "0x186C29D00")]
	private static extern int CDGEJCGLIIC(int CMEADPACGME);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A0C0", Offset = "0x6C28AC0", VA = "0x186C2A0C0")]
	private static extern int PEHBHAMBFCN(int CMEADPACGME);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A240", Offset = "0x6C28C40", VA = "0x186C2A240")]
	private static extern int PMOMIBMBDOI(int CMEADPACGME);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2A2C0", Offset = "0x6C28CC0", VA = "0x186C2A2C0")]
	public NCFAGIECEJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C29DF0", Offset = "0x6C287F0", VA = "0x186C29DF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C29E60", Offset = "0x6C28860", VA = "0x186C29E60")]
	public Rect FOBILEBOBHG(int JKBJHIHNLPD)
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
