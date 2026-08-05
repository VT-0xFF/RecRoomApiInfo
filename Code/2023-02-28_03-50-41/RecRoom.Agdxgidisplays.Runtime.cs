using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class JPPPDGPLBPL : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum FICEAPJMKKD
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void OOGBLCEADDB(IntPtr NONPDGFJDAK, int HGBOOPNCHBL, int FPEKPFGIDNA);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int FLIJHBJDGKF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x64B1FF0", Offset = "0x64B09F0", VA = "0x1864B1FF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64B2060", Offset = "0x64B0A60", VA = "0x1864B2060")]
	private static extern void EFJAKBDKIDL(OOGBLCEADDB JOIALDGLEAK);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x64B2450", Offset = "0x64B0E50", VA = "0x1864B2450")]
	[MonoPInvokeCallback(typeof(OOGBLCEADDB))]
	private static void PEDNEIMPMGM(IntPtr NONPDGFJDAK, int HGBOOPNCHBL, int FPEKPFGIDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x64B21F0", Offset = "0x64B0BF0", VA = "0x1864B21F0")]
	private static extern void JGKFDHOAMGH();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x64B1F00", Offset = "0x64B0900", VA = "0x1864B1F00")]
	private static extern void AJEHBHOKJOK();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x64B1FF0", Offset = "0x64B09F0", VA = "0x1864B1FF0")]
	private static extern int HAGEAIGMEPF();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x64B20F0", Offset = "0x64B0AF0", VA = "0x1864B20F0")]
	private static extern int FLJAPCCBFAP(int OGGLMCNMCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x64B2170", Offset = "0x64B0B70", VA = "0x1864B2170")]
	private static extern int FOJMNJALDLB(int OGGLMCNMCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x64B1F70", Offset = "0x64B0970", VA = "0x1864B1F70")]
	private static extern int ALBBNIIFEKP(int OGGLMCNMCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x64B2580", Offset = "0x64B0F80", VA = "0x1864B2580")]
	private static extern int PIEJNMBKNKF(int OGGLMCNMCLJ);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x64B2600", Offset = "0x64B1000", VA = "0x1864B2600")]
	public JPPPDGPLBPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x64B1F00", Offset = "0x64B0900", VA = "0x1864B1F00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64B2260", Offset = "0x64B0C60", VA = "0x1864B2260")]
	public Rect KAKKPIAPBCJ(int NBMFPBAJHOK)
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
