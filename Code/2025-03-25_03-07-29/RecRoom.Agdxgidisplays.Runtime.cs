using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class KEOJOKGAGBE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum AIMGPFPBHOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void FFNGGJENPAF(IntPtr INLHACAOAMD, int EOKAMHLPIFK, int DNKIDHOAAJB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int PLHFGMNPCCA
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x75A2BB0", Offset = "0x75A1FB0", VA = "0x1875A2BB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x75A2D10", Offset = "0x75A2110", VA = "0x1875A2D10")]
	private static extern void JMPJLKJDCII(FFNGGJENPAF FJLFOAFFGHE);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x75A2AB0", Offset = "0x75A1EB0", VA = "0x1875A2AB0")]
	[MonoPInvokeCallback(typeof(FFNGGJENPAF))]
	private static void AOPKFDNJJIE(IntPtr INLHACAOAMD, int EOKAMHLPIFK, int DNKIDHOAAJB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x75A2E20", Offset = "0x75A2220", VA = "0x1875A2E20")]
	private static extern void MBHBIOMKKEG();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x75A2C20", Offset = "0x75A2020", VA = "0x1875A2C20")]
	private static extern void DCPEBDMFIPI();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x75A2BB0", Offset = "0x75A1FB0", VA = "0x1875A2BB0")]
	private static extern int BKOCDIGMNPM();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x75A2F10", Offset = "0x75A2310", VA = "0x1875A2F10")]
	private static extern int MPENEBMCDCK(int IIKCEJDFBDH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x75A2C90", Offset = "0x75A2090", VA = "0x1875A2C90")]
	private static extern int GHLMNAJHPCE(int IIKCEJDFBDH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x75A2E90", Offset = "0x75A2290", VA = "0x1875A2E90")]
	private static extern int MBKEEHHMBDH(int IIKCEJDFBDH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x75A2DA0", Offset = "0x75A21A0", VA = "0x1875A2DA0")]
	private static extern int KACILMDLCLL(int IIKCEJDFBDH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x75A3180", Offset = "0x75A2580", VA = "0x1875A3180")]
	public KEOJOKGAGBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x75A2C20", Offset = "0x75A2020", VA = "0x1875A2C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x75A2F90", Offset = "0x75A2390", VA = "0x1875A2F90")]
	public Rect NFKFJMPMBNG(int JAGMMEFNCBD)
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
