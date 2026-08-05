using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class BGFLIKMDPDF : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HGIJHHOFMCP
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void JANGIKBDBAC(IntPtr KJACHHOOFKC, int BDHBBDMMOKG, int FEMCFMFAIMO);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int KGOFPKCPCJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x2274F80", Offset = "0x2273D80", VA = "0x182274F80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2275070", Offset = "0x2273E70", VA = "0x182275070")]
	private static extern void HHBKKOPCPFM(JANGIKBDBAC KDDLOKAHKOL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2274DE0", Offset = "0x2273BE0", VA = "0x182274DE0")]
	[MonoPInvokeCallback(typeof(JANGIKBDBAC))]
	private static void DBNJAPMONEH(IntPtr KJACHHOOFKC, int BDHBBDMMOKG, int FEMCFMFAIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x2275180", Offset = "0x2273F80", VA = "0x182275180")]
	private static extern void NAGCBALDEME();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2274F10", Offset = "0x2273D10", VA = "0x182274F10")]
	private static extern void KFOMHJBNEEC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2274F80", Offset = "0x2273D80", VA = "0x182274F80")]
	private static extern int ENKNDLALCGO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x2275100", Offset = "0x2273F00", VA = "0x182275100")]
	private static extern int MALKODHCGKL(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x22751F0", Offset = "0x2273FF0", VA = "0x1822751F0")]
	private static extern int NMMNJLMPAND(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x2275270", Offset = "0x2274070", VA = "0x182275270")]
	private static extern int NNEFNBMAJPP(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x2274FF0", Offset = "0x2273DF0", VA = "0x182274FF0")]
	private static extern int FPGHBEDLIJE(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x22752F0", Offset = "0x22740F0", VA = "0x1822752F0")]
	public BGFLIKMDPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x2274F10", Offset = "0x2273D10", VA = "0x182274F10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2274BF0", Offset = "0x22739F0", VA = "0x182274BF0")]
	public Rect AKENAPCPCIH(int PNGMHDANJAI)
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
