using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BFKAFHFPFBB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum ONDHKKHKENK
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void DCEMCPIADHJ(IntPtr LGIKLBJKNEM, int JAICOMOJIGD, int HFLMAAIFGEH);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int BMIPACNJDDH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6AC0000", Offset = "0x6ABF200", VA = "0x186AC0000")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFE70", Offset = "0x6ABF070", VA = "0x186ABFE70")]
	private static extern void BEIHMJPLHAG(DCEMCPIADHJ FKNFKAHALGJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFF00", Offset = "0x6ABF100", VA = "0x186ABFF00")]
	[MonoPInvokeCallback(typeof(DCEMCPIADHJ))]
	private static void BKLOHKPBGJA(IntPtr LGIKLBJKNEM, int JAICOMOJIGD, int HFLMAAIFGEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0070", Offset = "0x6ABF270", VA = "0x186AC0070")]
	private static extern void DDNLIMMJHCH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6AC00E0", Offset = "0x6ABF2E0", VA = "0x186AC00E0")]
	private static extern void NFCBPMGPDMB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0000", Offset = "0x6ABF200", VA = "0x186AC0000")]
	private static extern int IMBFCFGIIEE();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0250", Offset = "0x6ABF450", VA = "0x186AC0250")]
	private static extern int KKDDEAFDKBF(int MHMAFIBKDFF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0150", Offset = "0x6ABF350", VA = "0x186AC0150")]
	private static extern int FGHMLDGDPOL(int MHMAFIBKDFF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6AC02D0", Offset = "0x6ABF4D0", VA = "0x186AC02D0")]
	private static extern int NKHPEMKEICL(int MHMAFIBKDFF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6AC01D0", Offset = "0x6ABF3D0", VA = "0x186AC01D0")]
	private static extern int GMHDOJGCBIA(int MHMAFIBKDFF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6AC0350", Offset = "0x6ABF550", VA = "0x186AC0350")]
	public BFKAFHFPFBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6AC00E0", Offset = "0x6ABF2E0", VA = "0x186AC00E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABFC80", Offset = "0x6ABEE80", VA = "0x186ABFC80")]
	public Rect BAEIJECPHIP(int NJEKDEJBPMG)
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
