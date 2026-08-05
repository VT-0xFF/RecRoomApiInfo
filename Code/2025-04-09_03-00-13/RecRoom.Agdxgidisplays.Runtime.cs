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
		[Cpp2IlInjected.Address(RVA = "0x7649240", Offset = "0x7648640", VA = "0x187649240")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x76493A0", Offset = "0x76487A0", VA = "0x1876493A0")]
	private static extern void HLCPAHHDBFE(BHPCGEDEBOH ADLKPPBLCIG);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7648EE0", Offset = "0x76482E0", VA = "0x187648EE0")]
	[MonoPInvokeCallback(typeof(BHPCGEDEBOH))]
	private static void CFLCMKENFDM(IntPtr ANMDEHLLLBJ, int MNDMOIHIBEI, int OAOJNPCFANK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7649330", Offset = "0x7648730", VA = "0x187649330")]
	private static extern void GDCNGOALEGL();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7648FE0", Offset = "0x76483E0", VA = "0x187648FE0")]
	private static extern void CKIGLHBNGGP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7649240", Offset = "0x7648640", VA = "0x187649240")]
	private static extern int JENJKBJFMLJ();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7649430", Offset = "0x7648830", VA = "0x187649430")]
	private static extern int NJBHBHLOFME(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x76494B0", Offset = "0x76488B0", VA = "0x1876494B0")]
	private static extern int OFFPBGOKOIO(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x76492B0", Offset = "0x76486B0", VA = "0x1876492B0")]
	private static extern int FEFBJABJIAJ(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7648E60", Offset = "0x7648260", VA = "0x187648E60")]
	private static extern int AMBPNKMKLAG(int NCJKGMLAKGH);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7649530", Offset = "0x7648930", VA = "0x187649530")]
	public FIDJGGCNPOI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7648FE0", Offset = "0x76483E0", VA = "0x187648FE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7649050", Offset = "0x7648450", VA = "0x187649050")]
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
