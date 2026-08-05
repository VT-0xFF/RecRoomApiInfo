using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OFGANMLGCMN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HMEALOMCMEC
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void EGAGHNMPKAL(IntPtr PLGCCHMKBMF, int DAIAAPJIJOF, int GKFFDIMKACE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int JLOHBOKPKNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x5B7CEB0", Offset = "0x5B7C2B0", VA = "0x185B7CEB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D120", Offset = "0x5B7C520", VA = "0x185B7D120")]
	private static extern void PDCENAIBKHE(EGAGHNMPKAL IOKENELNCLP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CFA0", Offset = "0x5B7C3A0", VA = "0x185B7CFA0")]
	[MonoPInvokeCallback(typeof(EGAGHNMPKAL))]
	private static void JOCIEGKNBIO(IntPtr PLGCCHMKBMF, int DAIAAPJIJOF, int GKFFDIMKACE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CE40", Offset = "0x5B7C240", VA = "0x185B7CE40")]
	private static extern void FGBNJEBGKMH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CDD0", Offset = "0x5B7C1D0", VA = "0x185B7CDD0")]
	private static extern void DABDKDALJJM();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CEB0", Offset = "0x5B7C2B0", VA = "0x185B7CEB0")]
	private static extern int INCAGGNBLAD();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D0A0", Offset = "0x5B7C4A0", VA = "0x185B7D0A0")]
	private static extern int NEHNBIHEOBJ(int PIKCMFPLBNL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CD50", Offset = "0x5B7C150", VA = "0x185B7CD50")]
	private static extern int AOEDECELKIB(int PIKCMFPLBNL);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CF20", Offset = "0x5B7C320", VA = "0x185B7CF20")]
	private static extern int IMMOHEAFHEF(int PIKCMFPLBNL);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D1B0", Offset = "0x5B7C5B0", VA = "0x185B7D1B0")]
	private static extern int PKMPBOLEPNN(int PIKCMFPLBNL);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D420", Offset = "0x5B7C820", VA = "0x185B7D420")]
	public OFGANMLGCMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5B7CDD0", Offset = "0x5B7C1D0", VA = "0x185B7CDD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5B7D230", Offset = "0x5B7C630", VA = "0x185B7D230")]
	public Rect PPALPFOKDMK(int JFCEIILMHEC)
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
