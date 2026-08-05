using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FDJCOPBKBCA : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FGOKAPIOBJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void MMGLBFCCLCK(IntPtr NIBLEOGJBJF, int CGAAPEOHPIP, int DCEAOLCIOHK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int NPLJJJHDFPD
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x8020DA0", Offset = "0x801F7A0", VA = "0x188020DA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x80211F0", Offset = "0x801FBF0", VA = "0x1880211F0")]
	private static extern void OAGMKLPDFFI(MMGLBFCCLCK EMBEDGKMMHB);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x8020F80", Offset = "0x801F980", VA = "0x188020F80")]
	[MonoPInvokeCallback(typeof(MMGLBFCCLCK))]
	private static void FHLCLPNKNPJ(IntPtr NIBLEOGJBJF, int CGAAPEOHPIP, int DCEAOLCIOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x8021080", Offset = "0x801FA80", VA = "0x188021080")]
	private static extern void ICNIAFDKEKI();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x8020F10", Offset = "0x801F910", VA = "0x188020F10")]
	private static extern void INLECGMBFAD();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x8020DA0", Offset = "0x801F7A0", VA = "0x188020DA0")]
	private static extern int KEDANNCNFDH();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x8020E90", Offset = "0x801F890", VA = "0x188020E90")]
	private static extern int DLEIPDCHFIN(int EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x8020E10", Offset = "0x801F810", VA = "0x188020E10")]
	private static extern int DIFKJCCNKNG(int EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x80210F0", Offset = "0x801FAF0", VA = "0x1880210F0")]
	private static extern int KCLLGIPCPJG(int EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x8021170", Offset = "0x801FB70", VA = "0x188021170")]
	private static extern int MFPBMCGGGGE(int EGJGKBPPPFG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x8021470", Offset = "0x801FE70", VA = "0x188021470")]
	public FDJCOPBKBCA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x8020F10", Offset = "0x801F910", VA = "0x188020F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8021280", Offset = "0x801FC80", VA = "0x188021280")]
	public Rect PDFOMNJJBDE(int FEDJOKAFCNC)
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
