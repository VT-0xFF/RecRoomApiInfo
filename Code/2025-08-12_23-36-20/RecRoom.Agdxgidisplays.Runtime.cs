using System;
using System.Reflection;
using AOT;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class OGFENMBLAHG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private enum HDAHKDPNKMB
	{
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		Warning,
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		Error
	}

	[Cpp2IlInjected.Token(Token = "0x2000004")]
	private delegate void CFOLCPHPKLL(IntPtr FGKGCIHOGKN, int BCMFMCHGEKF, int BKMCHKAPMNF);

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public int CIMHBCKBOHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x809D970", Offset = "0x809C770", VA = "0x18809D970")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x809D7E0", Offset = "0x809C5E0", VA = "0x18809D7E0")]
	private static extern void EBFALNMLPKP(CFOLCPHPKLL LBJMJKFNAPH);

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x809DA50", Offset = "0x809C850", VA = "0x18809DA50")]
	[MonoPInvokeCallback(typeof(CFOLCPHPKLL))]
	private static void NAIEPLEAOCF(IntPtr FGKGCIHOGKN, int BCMFMCHGEKF, int BKMCHKAPMNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x809D9E0", Offset = "0x809C7E0", VA = "0x18809D9E0")]
	private static extern void IEHCJBEIMLK();

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x809D770", Offset = "0x809C570", VA = "0x18809D770")]
	private static extern void LAAIJBFIFHH();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x809D970", Offset = "0x809C770", VA = "0x18809D970")]
	private static extern int GEJLNPJLODC();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x809D6F0", Offset = "0x809C4F0", VA = "0x18809D6F0")]
	private static extern int CBMGILEGMDG(int FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x809D870", Offset = "0x809C670", VA = "0x18809D870")]
	private static extern int EFHBLCKKJEI(int FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x809D8F0", Offset = "0x809C6F0", VA = "0x18809D8F0")]
	private static extern int GEFDDBLNNLD(int FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x809D670", Offset = "0x809C470", VA = "0x18809D670")]
	private static extern int AMJLBPOBIMB(int FMFDAFLDAAK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x809DB50", Offset = "0x809C950", VA = "0x18809DB50")]
	public OGFENMBLAHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x809D770", Offset = "0x809C570", VA = "0x18809D770", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x809D480", Offset = "0x809C280", VA = "0x18809D480")]
	public Rect ACJAGEIHJON(int NPHCELEJLKB)
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
