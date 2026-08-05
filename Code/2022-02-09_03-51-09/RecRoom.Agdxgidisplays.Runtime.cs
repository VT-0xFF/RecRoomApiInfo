using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GOHKCDCIKLA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum AIDFAFMLJAM
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void KJHHFBIJHBE(IntPtr HBKGKDEOCFD, int AHCNLPEMKEN, int HKKOCGDOPEO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HPLJNLFPFIN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x4711E90", Offset = "0x4710C90", VA = "0x184711E90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x4712300", Offset = "0x4711100", VA = "0x184712300")]
	private static extern void NFELLKBFPGJ(KJHHFBIJHBE GMDMDOLDPBH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x4711F70", Offset = "0x4710D70", VA = "0x184711F70")]
	[MonoPInvokeCallback(typeof(KJHHFBIJHBE))]
	private static void IPKBDLJDBEA(IntPtr HBKGKDEOCFD, int AHCNLPEMKEN, int HKKOCGDOPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x4711E20", Offset = "0x4710C20", VA = "0x184711E20")]
	private static extern void BDHCIKJGEKI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x4711F00", Offset = "0x4710D00", VA = "0x184711F00")]
	private static extern void LLEFFOAOHKC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x4711E90", Offset = "0x4710C90", VA = "0x184711E90")]
	private static extern int IKMDFGFBMHO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x4712410", Offset = "0x4711210", VA = "0x184712410")]
	private static extern int PLMKPJOECCH(int JODGPNEIOOF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x4711DA0", Offset = "0x4710BA0", VA = "0x184711DA0")]
	private static extern int ACCEGLHFDED(int JODGPNEIOOF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x4712280", Offset = "0x4711080", VA = "0x184712280")]
	private static extern int LNAOCHFMPDO(int JODGPNEIOOF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x4712390", Offset = "0x4711190", VA = "0x184712390")]
	private static extern int OBNNIENOCKA(int JODGPNEIOOF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x4712490", Offset = "0x4711290", VA = "0x184712490")]
	public GOHKCDCIKLA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x4711F00", Offset = "0x4710D00", VA = "0x184711F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4712090", Offset = "0x4710E90", VA = "0x184712090")]
	public Rect KEMIGFJNACI(int PFBDLHMAJHL)
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
