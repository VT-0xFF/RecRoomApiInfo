using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JBLOKOCCOAE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum JGJIHGIOMKL
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DICIGDGDBNA(IntPtr EPDDNPCGMCI, int LPKLLJKOBNO, int GHHDFMLPCJB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NJIEEJGENKH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x68707C0", Offset = "0x686EDC0", VA = "0x1868707C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6870830", Offset = "0x686EE30", VA = "0x186870830")]
	private static extern void JLPJIHLFILA(DICIGDGDBNA JMMEJHGHOEF);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6870B30", Offset = "0x686F130", VA = "0x186870B30")]
	[MonoPInvokeCallback(typeof(DICIGDGDBNA))]
	private static void MHMAGNGOLIP(IntPtr EPDDNPCGMCI, int LPKLLJKOBNO, int GHHDFMLPCJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6870C30", Offset = "0x686F230", VA = "0x186870C30")]
	private static extern void PNLKNBIHCGI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x68706D0", Offset = "0x686ECD0", VA = "0x1868706D0")]
	private static extern void BIJFBOGAKLC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x68707C0", Offset = "0x686EDC0", VA = "0x1868707C0")]
	private static extern int IIOMLPDOLHK();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6870CA0", Offset = "0x686F2A0", VA = "0x186870CA0")]
	private static extern int PPFBCAGAEKH(int DAIJJLLIENA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6870AB0", Offset = "0x686F0B0", VA = "0x186870AB0")]
	private static extern int MBADGDJPMDP(int DAIJJLLIENA);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6870740", Offset = "0x686ED40", VA = "0x186870740")]
	private static extern int EONMOAPLEGK(int DAIJJLLIENA);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6870650", Offset = "0x686EC50", VA = "0x186870650")]
	private static extern int AAPGGIDPOKH(int DAIJJLLIENA);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6870D20", Offset = "0x686F320", VA = "0x186870D20")]
	public JBLOKOCCOAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x68706D0", Offset = "0x686ECD0", VA = "0x1868706D0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x68708C0", Offset = "0x686EEC0", VA = "0x1868708C0")]
	public Rect KMGGGGOHJEM(int KKPLBKBIOJF)
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
