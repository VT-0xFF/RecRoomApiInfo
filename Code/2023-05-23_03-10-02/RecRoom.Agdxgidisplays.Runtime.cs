using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class NIKEEBEMMAA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum BGHJAEHELDO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void GMDEFPIJDJP(IntPtr OLCOAAKJEBF, int ABBKELIMEIN, int MDIODAHIHDO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int IMHAHKAEILI
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x1713170", Offset = "0x1712570", VA = "0x181713170")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x17133D0", Offset = "0x17127D0", VA = "0x1817133D0")]
	private static extern void LCHBEBPJIPJ(GMDEFPIJDJP JGHGBFJPJFD);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1713460", Offset = "0x1712860", VA = "0x181713460")]
	[MonoPInvokeCallback(typeof(GMDEFPIJDJP))]
	private static void NHLKDHACJPM(IntPtr OLCOAAKJEBF, int ABBKELIMEIN, int MDIODAHIHDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1713590", Offset = "0x1712990", VA = "0x181713590")]
	private static extern void OAGJEKOOFKN();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x17131E0", Offset = "0x17125E0", VA = "0x1817131E0")]
	private static extern void KDJPCPOKFGG();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1713170", Offset = "0x1712570", VA = "0x181713170")]
	private static extern int BAHDFKADMIK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x17132D0", Offset = "0x17126D0", VA = "0x1817132D0")]
	private static extern int GFBFDBJBJEI(int IDFOGLKIIHM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1713250", Offset = "0x1712650", VA = "0x181713250")]
	private static extern int EGGLLNPBILI(int IDFOGLKIIHM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x17130F0", Offset = "0x17124F0", VA = "0x1817130F0")]
	private static extern int ANPLBGPJCBB(int IDFOGLKIIHM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1713350", Offset = "0x1712750", VA = "0x181713350")]
	private static extern int JDFNGODNOGD(int IDFOGLKIIHM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1713600", Offset = "0x1712A00", VA = "0x181713600")]
	public NIKEEBEMMAA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x17131E0", Offset = "0x17125E0", VA = "0x1817131E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1712EF0", Offset = "0x17122F0", VA = "0x181712EF0")]
	public Rect ACJJOAJLEGD(int KAMANBAEELA)
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
