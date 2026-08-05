using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MDBHLONMHEN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GOMGDHHMFPF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DPHPBJFGNHH(IntPtr BPCGMGBPPCA, int BOOADEANLJB, int HICKGBJDDHB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GAJBBLAALEO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6D57FD0", Offset = "0x6D567D0", VA = "0x186D57FD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6D58040", Offset = "0x6D56840", VA = "0x186D58040")]
	private static extern void GNNLNADKDGB(DPHPBJFGNHH KNMHMBJIFMM);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6D58150", Offset = "0x6D56950", VA = "0x186D58150")]
	[MonoPInvokeCallback(typeof(DPHPBJFGNHH))]
	private static void NBKGDOBMPMH(IntPtr BPCGMGBPPCA, int BOOADEANLJB, int HICKGBJDDHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6D57EE0", Offset = "0x6D566E0", VA = "0x186D57EE0")]
	private static extern void EHFCOOMFLME();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6D57E70", Offset = "0x6D56670", VA = "0x186D57E70")]
	private static extern void HAIBIPOGFCE();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6D57FD0", Offset = "0x6D567D0", VA = "0x186D57FD0")]
	private static extern int GGONPPJHFGI();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6D582D0", Offset = "0x6D56AD0", VA = "0x186D582D0")]
	private static extern int OMKLNDIAGED(int DOBPKLNCBDO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6D580D0", Offset = "0x6D568D0", VA = "0x186D580D0")]
	private static extern int HALENDCOAGA(int DOBPKLNCBDO);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6D58250", Offset = "0x6D56A50", VA = "0x186D58250")]
	private static extern int NKGHFFBIGCI(int DOBPKLNCBDO);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6D57F50", Offset = "0x6D56750", VA = "0x186D57F50")]
	private static extern int FFDIHDFEOHI(int DOBPKLNCBDO);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6D58540", Offset = "0x6D56D40", VA = "0x186D58540")]
	public MDBHLONMHEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6D57E70", Offset = "0x6D56670", VA = "0x186D57E70", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6D58350", Offset = "0x6D56B50", VA = "0x186D58350")]
	public Rect PDCPNGDPNKI(int KHKOLENFJOE)
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
