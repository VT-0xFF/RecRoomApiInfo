using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FHCDNGLMHFH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum MFCIONLNFOO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void NPPALLGEAHF(IntPtr GHNJJOLFHLE, int JLMAIAGOBFJ, int KHGKLIGFHLE);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FJFACBHCHNK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x60A28F0", Offset = "0x60A12F0", VA = "0x1860A28F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x60A2EF0", Offset = "0x60A18F0", VA = "0x1860A2EF0")]
	private static extern void NPOIPIHJOIN(NPPALLGEAHF ONHFNOPIIKL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x60A2D40", Offset = "0x60A1740", VA = "0x1860A2D40")]
	[MonoPInvokeCallback(typeof(NPPALLGEAHF))]
	private static void FLANGPCLBIO(IntPtr GHNJJOLFHLE, int JLMAIAGOBFJ, int KHGKLIGFHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x60A2F80", Offset = "0x60A1980", VA = "0x1860A2F80")]
	private static extern void OIEJOMHJJDA();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x60A2BD0", Offset = "0x60A15D0", VA = "0x1860A2BD0")]
	private static extern void INAHFMIHBJK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A28F0", Offset = "0x60A12F0", VA = "0x1860A28F0")]
	private static extern int AFJDFGFFKKA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A2960", Offset = "0x60A1360", VA = "0x1860A2960")]
	private static extern int CFLJIBGPCCG(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60A2C40", Offset = "0x60A1640", VA = "0x1860A2C40")]
	private static extern int EALDIEGLDIB(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A2E70", Offset = "0x60A1870", VA = "0x1860A2E70")]
	private static extern int LLBGLLKLCID(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60A2CC0", Offset = "0x60A16C0", VA = "0x1860A2CC0")]
	private static extern int EIHGFEAPGBE(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60A2FF0", Offset = "0x60A19F0", VA = "0x1860A2FF0")]
	public FHCDNGLMHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60A2BD0", Offset = "0x60A15D0", VA = "0x1860A2BD0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60A29E0", Offset = "0x60A13E0", VA = "0x1860A29E0")]
	public Rect DEKGNEONHKA(int BNPBHJHPEAF)
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
