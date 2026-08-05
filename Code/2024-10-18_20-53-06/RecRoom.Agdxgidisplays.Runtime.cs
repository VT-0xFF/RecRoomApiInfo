using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class MFEPHDJCECG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum PPCAKMINPFO
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void INBJAHONJFD(IntPtr BCGNIJHEBIO, int IKJKAFPPDBP, int BBFKKNNMDMB);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int OCNJMLLPBIO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6C2BB20", Offset = "0x6C2AF20", VA = "0x186C2BB20")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BF70", Offset = "0x6C2B370", VA = "0x186C2BF70")]
	private static extern void MNLLFMKIMPB(INBJAHONJFD JMKLCPOKHHP);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BE70", Offset = "0x6C2B270", VA = "0x186C2BE70")]
	[MonoPInvokeCallback(typeof(INBJAHONJFD))]
	private static void KIFHJGBPJNF(IntPtr BCGNIJHEBIO, int IKJKAFPPDBP, int BBFKKNNMDMB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BAB0", Offset = "0x6C2AEB0", VA = "0x186C2BAB0")]
	private static extern void CGCFJDLGJFP();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BB90", Offset = "0x6C2AF90", VA = "0x186C2BB90")]
	private static extern void NCBEKLBCEEF();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BB20", Offset = "0x6C2AF20", VA = "0x186C2BB20")]
	private static extern int CONINADDIGB();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B9B0", Offset = "0x6C2ADB0", VA = "0x186C2B9B0")]
	private static extern int ABBANNGOFFH(int NKPCGMJMEIE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C000", Offset = "0x6C2B400", VA = "0x186C2C000")]
	private static extern int PMCLAPLDDKL(int NKPCGMJMEIE);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BA30", Offset = "0x6C2AE30", VA = "0x186C2BA30")]
	private static extern int CAALAJBKBCN(int NKPCGMJMEIE);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BDF0", Offset = "0x6C2B1F0", VA = "0x186C2BDF0")]
	private static extern int JKMJMEMEMED(int NKPCGMJMEIE);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6C2C080", Offset = "0x6C2B480", VA = "0x186C2C080")]
	public MFEPHDJCECG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BB90", Offset = "0x6C2AF90", VA = "0x186C2BB90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6C2BC00", Offset = "0x6C2B000", VA = "0x186C2BC00")]
	public Rect FPEPPONJDAN(int MALAONHHHIA)
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
