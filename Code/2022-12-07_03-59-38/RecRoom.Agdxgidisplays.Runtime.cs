using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MBMONGACEJE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum IKNIDJMLAAI
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void AFNEGDEGODJ(IntPtr PJCBPMCBLEN, int PJGFFECCBBF, int AHLOOLCKJCE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int DLDIBMAIBHG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x609FD10", Offset = "0x609E910", VA = "0x18609FD10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x609FE00", Offset = "0x609EA00", VA = "0x18609FE00")]
	private static extern void CFJFLHJAIMH(AFNEGDEGODJ JGLIBPMCCNL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A0260", Offset = "0x609EE60", VA = "0x1860A0260")]
	[MonoPInvokeCallback(typeof(AFNEGDEGODJ))]
	private static void LEDJLDODDAD(IntPtr PJCBPMCBLEN, int PJGFFECCBBF, int AHLOOLCKJCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x609FE90", Offset = "0x609EA90", VA = "0x18609FE90")]
	private static extern void CKNDJHJGHOM();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60A0170", Offset = "0x609ED70", VA = "0x1860A0170")]
	private static extern void LCBMAJFKHIP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x609FD10", Offset = "0x609E910", VA = "0x18609FD10")]
	private static extern int HMBBPENCPPN();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A0390", Offset = "0x609EF90", VA = "0x1860A0390")]
	private static extern int PHHPAKAPJDN(int BEAOEMMHBNI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x609FF00", Offset = "0x609EB00", VA = "0x18609FF00")]
	private static extern int DBBNMPIAPDG(int BEAOEMMHBNI);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A01E0", Offset = "0x609EDE0", VA = "0x1860A01E0")]
	private static extern int JGDPFFBHCPE(int BEAOEMMHBNI);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x609FD80", Offset = "0x609E980", VA = "0x18609FD80")]
	private static extern int BOJDHLLMNND(int BEAOEMMHBNI);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60A0410", Offset = "0x609F010", VA = "0x1860A0410")]
	public MBMONGACEJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60A0170", Offset = "0x609ED70", VA = "0x1860A0170", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x609FF80", Offset = "0x609EB80", VA = "0x18609FF80")]
	public Rect DOLEJBDNCJP(int KHKPMNHDBAH)
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
