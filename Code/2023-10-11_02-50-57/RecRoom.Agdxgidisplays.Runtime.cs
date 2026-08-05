using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GBMGDIEBNHB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum EIIBAPFIPIN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OHFICKHKFGG(IntPtr GDHOLDPNHCL, int MEDHPDICIDE, int OIBDLICDOPI);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HEHAKCEDGNO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5BDBB70", Offset = "0x5BDA970", VA = "0x185BDBB70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBCE0", Offset = "0x5BDAAE0", VA = "0x185BDBCE0")]
	private static extern void ICDCJOKPJDL(OHFICKHKFGG MEKLMIFMFCO);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBFE0", Offset = "0x5BDADE0", VA = "0x185BDBFE0")]
	[MonoPInvokeCallback(typeof(OHFICKHKFGG))]
	private static void LBMHHOKBLPP(IntPtr GDHOLDPNHCL, int MEDHPDICIDE, int OIBDLICDOPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC0E0", Offset = "0x5BDAEE0", VA = "0x185BDC0E0")]
	private static extern void OOCIGOIJKNJ();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBB00", Offset = "0x5BDA900", VA = "0x185BDBB00")]
	private static extern void LNBFNPLGODA();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBB70", Offset = "0x5BDA970", VA = "0x185BDBB70")]
	private static extern int GBAKFBHJMCG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBC60", Offset = "0x5BDAA60", VA = "0x185BDBC60")]
	private static extern int HJNONHADKHO(int NBHCOBHPFBM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBD70", Offset = "0x5BDAB70", VA = "0x185BDBD70")]
	private static extern int ICNNBOBJAKK(int NBHCOBHPFBM);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBBE0", Offset = "0x5BDA9E0", VA = "0x185BDBBE0")]
	private static extern int HACCGJOJEOP(int NBHCOBHPFBM);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBA80", Offset = "0x5BDA880", VA = "0x185BDBA80")]
	private static extern int AJEPDDLPIHJ(int NBHCOBHPFBM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5BDC150", Offset = "0x5BDAF50", VA = "0x185BDC150")]
	public GBMGDIEBNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBB00", Offset = "0x5BDA900", VA = "0x185BDBB00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5BDBDF0", Offset = "0x5BDABF0", VA = "0x185BDBDF0")]
	public Rect JEHCGIBJCKG(int ICMBPOPOPMJ)
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
