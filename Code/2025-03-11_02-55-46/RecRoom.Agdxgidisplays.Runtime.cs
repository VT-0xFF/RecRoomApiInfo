using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GFGLHKOGLEH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JAMFDEOPAJB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CIBPDNPGLHE(IntPtr NKKKCKHLGCJ, int NBPEDBIONNC, int POEFPKLCNEF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OFKGPIHDENM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x739D590", Offset = "0x739C990", VA = "0x18739D590")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x739D970", Offset = "0x739CD70", VA = "0x18739D970")]
	private static extern void MMLEOMCGMCO(CIBPDNPGLHE LOGLEICCEGM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x739D490", Offset = "0x739C890", VA = "0x18739D490")]
	[MonoPInvokeCallback(typeof(CIBPDNPGLHE))]
	private static void EKDAOCPMIKA(IntPtr NKKKCKHLGCJ, int NBPEDBIONNC, int POEFPKLCNEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x739DA00", Offset = "0x739CE00", VA = "0x18739DA00")]
	private static extern void OBBALIPJEND();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x739D420", Offset = "0x739C820", VA = "0x18739D420")]
	private static extern void NLHOOAKEJDL();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x739D590", Offset = "0x739C990", VA = "0x18739D590")]
	private static extern int GCPLAIFFIIP();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x739D700", Offset = "0x739CB00", VA = "0x18739D700")]
	private static extern int LFMAKJOFNKI(int NNKBGKICBEC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x739D600", Offset = "0x739CA00", VA = "0x18739D600")]
	private static extern int GKALEDGAOEJ(int NNKBGKICBEC);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x739D3A0", Offset = "0x739C7A0", VA = "0x18739D3A0")]
	private static extern int CJLOINDHGJP(int NNKBGKICBEC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x739D680", Offset = "0x739CA80", VA = "0x18739D680")]
	private static extern int ILMKPIFODCB(int NNKBGKICBEC);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x739DA70", Offset = "0x739CE70", VA = "0x18739DA70")]
	public GFGLHKOGLEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x739D420", Offset = "0x739C820", VA = "0x18739D420", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x739D780", Offset = "0x739CB80", VA = "0x18739D780")]
	public Rect LPCBGMKDIAA(int JINLGHFCKNF)
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
