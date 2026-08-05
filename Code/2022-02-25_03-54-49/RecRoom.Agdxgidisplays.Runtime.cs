using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class HPLBGBDHHEL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FPIBDLOKDAO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void ONHKMBOFECA(IntPtr OOMGMCFGDFM, int OGHBEIMLJPA, int LIPOOCPIFOB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int EJGDJJNJJKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x323EC60", Offset = "0x323D260", VA = "0x18323EC60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x323EDD0", Offset = "0x323D3D0", VA = "0x18323EDD0")]
	private static extern void LOANKOLHAMD(ONHKMBOFECA POJIJEGMINL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x323EEE0", Offset = "0x323D4E0", VA = "0x18323EEE0")]
	[MonoPInvokeCallback(typeof(ONHKMBOFECA))]
	private static void NKJJLOFAOGE(IntPtr OOMGMCFGDFM, int OGHBEIMLJPA, int LIPOOCPIFOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x323E990", Offset = "0x323CF90", VA = "0x18323E990")]
	private static extern void BMGFGFNKNCO();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x323EA00", Offset = "0x323D000", VA = "0x18323EA00")]
	private static extern void CMIHBMGKNJB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x323EC60", Offset = "0x323D260", VA = "0x18323EC60")]
	private static extern int IKDHKBEFGMC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x323ECD0", Offset = "0x323D2D0", VA = "0x18323ECD0")]
	private static extern int EBDJKNGJPFE(int CLEEBEFEDCL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x323F000", Offset = "0x323D600", VA = "0x18323F000")]
	private static extern int PAMHAJJPLLJ(int CLEEBEFEDCL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x323ED50", Offset = "0x323D350", VA = "0x18323ED50")]
	private static extern int EPGNLOGEEEC(int CLEEBEFEDCL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x323EE60", Offset = "0x323D460", VA = "0x18323EE60")]
	private static extern int NJDKFOGGKCD(int CLEEBEFEDCL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x323F080", Offset = "0x323D680", VA = "0x18323F080")]
	public HPLBGBDHHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x323EA00", Offset = "0x323D000", VA = "0x18323EA00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x323EA70", Offset = "0x323D070", VA = "0x18323EA70")]
	public Rect CPEEFCADNAP(int OPDHHFOBPBE)
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
