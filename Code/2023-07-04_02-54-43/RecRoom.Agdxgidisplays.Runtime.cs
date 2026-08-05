using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class GOPFIGJBDJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum GCLFIGHEJHN
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void FMMEMONJOLG(IntPtr PKNENDONMCN, int BMEHIBKNEIE, int FEBFBIIMFCF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int HOGMIPPGPCO
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x7272090", Offset = "0x7270690", VA = "0x187272090")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x7271D90", Offset = "0x7270390", VA = "0x187271D90")]
	private static extern void AKLBPPPGGOM(FMMEMONJOLG OIBMDOLHJFJ);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x7272270", Offset = "0x7270870", VA = "0x187272270")]
	[MonoPInvokeCallback(typeof(FMMEMONJOLG))]
	private static void LIMCDPBJDEK(IntPtr PKNENDONMCN, int BMEHIBKNEIE, int FEBFBIIMFCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x7272200", Offset = "0x7270800", VA = "0x187272200")]
	private static extern void KGHKJOCLFMF();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x7271E20", Offset = "0x7270420", VA = "0x187271E20")]
	private static extern void BDLLKNIDNLB();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7272090", Offset = "0x7270690", VA = "0x187272090")]
	private static extern int DOFJHFPCIMG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7272180", Offset = "0x7270780", VA = "0x187272180")]
	private static extern int GHGOFOLIJHP(int LNHACNHDILG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x72723A0", Offset = "0x72709A0", VA = "0x1872723A0")]
	private static extern int ONKONBEIBKJ(int LNHACNHDILG);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7272420", Offset = "0x7270A20", VA = "0x187272420")]
	private static extern int PILMDGLNAIB(int LNHACNHDILG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7272100", Offset = "0x7270700", VA = "0x187272100")]
	private static extern int EPKHAELMJLM(int LNHACNHDILG);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x72724A0", Offset = "0x7270AA0", VA = "0x1872724A0")]
	public GOPFIGJBDJD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7271E20", Offset = "0x7270420", VA = "0x187271E20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7271E90", Offset = "0x7270490", VA = "0x187271E90")]
	public Rect COOGLMIFBOK(int KJLDHHFNPKJ)
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
