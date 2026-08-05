using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class FIDJGGCNPOI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum CEOFEPIACIF
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void BHPCGEDEBOH(IntPtr ANMDEHLLLBJ, int MNDMOIHIBEI, int OAOJNPCFANK);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int GBLANEJBBBF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x76049D0", Offset = "0x7603DD0", VA = "0x1876049D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7604B30", Offset = "0x7603F30", VA = "0x187604B30")]
	private static extern void HLCPAHHDBFE(BHPCGEDEBOH ADLKPPBLCIG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7604670", Offset = "0x7603A70", VA = "0x187604670")]
	[MonoPInvokeCallback(typeof(BHPCGEDEBOH))]
	private static void CFLCMKENFDM(IntPtr ANMDEHLLLBJ, int MNDMOIHIBEI, int OAOJNPCFANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7604AC0", Offset = "0x7603EC0", VA = "0x187604AC0")]
	private static extern void GDCNGOALEGL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7604770", Offset = "0x7603B70", VA = "0x187604770")]
	private static extern void CKIGLHBNGGP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x76049D0", Offset = "0x7603DD0", VA = "0x1876049D0")]
	private static extern int JENJKBJFMLJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7604BC0", Offset = "0x7603FC0", VA = "0x187604BC0")]
	private static extern int NJBHBHLOFME(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7604C40", Offset = "0x7604040", VA = "0x187604C40")]
	private static extern int OFFPBGOKOIO(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7604A40", Offset = "0x7603E40", VA = "0x187604A40")]
	private static extern int FEFBJABJIAJ(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x76045F0", Offset = "0x76039F0", VA = "0x1876045F0")]
	private static extern int AMBPNKMKLAG(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7604CC0", Offset = "0x76040C0", VA = "0x187604CC0")]
	public FIDJGGCNPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7604770", Offset = "0x7603B70", VA = "0x187604770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x76047E0", Offset = "0x7603BE0", VA = "0x1876047E0")]
	public Rect EBKLMIFOGBO(int OPBPFEGIOGD)
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
