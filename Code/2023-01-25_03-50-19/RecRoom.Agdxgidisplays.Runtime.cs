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
		[Cpp2IlInjected.Address(RVA = "0x6124E10", Offset = "0x6123E10", VA = "0x186124E10")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6124F00", Offset = "0x6123F00", VA = "0x186124F00")]
	private static extern void HHBKKOPCPFM(JANGIKBDBAC KDDLOKAHKOL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6124C70", Offset = "0x6123C70", VA = "0x186124C70")]
	[MonoPInvokeCallback(typeof(JANGIKBDBAC))]
	private static void DBNJAPMONEH(IntPtr KJACHHOOFKC, int BDHBBDMMOKG, int FEMCFMFAIMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6125010", Offset = "0x6124010", VA = "0x186125010")]
	private static extern void NAGCBALDEME();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6124DA0", Offset = "0x6123DA0", VA = "0x186124DA0")]
	private static extern void KFOMHJBNEEC();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6124E10", Offset = "0x6123E10", VA = "0x186124E10")]
	private static extern int ENKNDLALCGO();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6124F90", Offset = "0x6123F90", VA = "0x186124F90")]
	private static extern int MALKODHCGKL(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6125080", Offset = "0x6124080", VA = "0x186125080")]
	private static extern int NMMNJLMPAND(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6125100", Offset = "0x6124100", VA = "0x186125100")]
	private static extern int NNEFNBMAJPP(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6124E80", Offset = "0x6123E80", VA = "0x186124E80")]
	private static extern int FPGHBEDLIJE(int KCHLIHHPAKF);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6125180", Offset = "0x6124180", VA = "0x186125180")]
	public BGFLIKMDPDF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6124DA0", Offset = "0x6123DA0", VA = "0x186124DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6124A80", Offset = "0x6123A80", VA = "0x186124A80")]
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
