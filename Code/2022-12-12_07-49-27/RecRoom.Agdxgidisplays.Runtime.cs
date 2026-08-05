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
		[Cpp2IlInjected.Address(RVA = "0x1D44C60", Offset = "0x1D43260", VA = "0x181D44C60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D45260", Offset = "0x1D43860", VA = "0x181D45260")]
	private static extern void NPOIPIHJOIN(NPPALLGEAHF ONHFNOPIIKL);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D450B0", Offset = "0x1D436B0", VA = "0x181D450B0")]
	[MonoPInvokeCallback(typeof(NPPALLGEAHF))]
	private static void FLANGPCLBIO(IntPtr GHNJJOLFHLE, int JLMAIAGOBFJ, int KHGKLIGFHLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1D452F0", Offset = "0x1D438F0", VA = "0x181D452F0")]
	private static extern void OIEJOMHJJDA();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1D44F40", Offset = "0x1D43540", VA = "0x181D44F40")]
	private static extern void INAHFMIHBJK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1D44C60", Offset = "0x1D43260", VA = "0x181D44C60")]
	private static extern int AFJDFGFFKKA();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1D44CD0", Offset = "0x1D432D0", VA = "0x181D44CD0")]
	private static extern int CFLJIBGPCCG(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x1D44FB0", Offset = "0x1D435B0", VA = "0x181D44FB0")]
	private static extern int EALDIEGLDIB(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x1D451E0", Offset = "0x1D437E0", VA = "0x181D451E0")]
	private static extern int LLBGLLKLCID(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x1D45030", Offset = "0x1D43630", VA = "0x181D45030")]
	private static extern int EIHGFEAPGBE(int CBBOJGIJLHN);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x1D45360", Offset = "0x1D43960", VA = "0x181D45360")]
	public FHCDNGLMHFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x1D44F40", Offset = "0x1D43540", VA = "0x181D44F40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1D44D50", Offset = "0x1D43350", VA = "0x181D44D50")]
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
