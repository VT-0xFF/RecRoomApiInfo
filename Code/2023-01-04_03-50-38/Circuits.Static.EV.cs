using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Class: {Class}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
public struct AJCCOAGGDOA : IEquatable<AJCCOAGGDOA>, global::ABCEMJGLGHA<AJCCOAGGDOA>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public object OBINJOHPGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public DBBHLOFGPKM PELAHJMNLGG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool AIMMEFPBAJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B46A0", Offset = "0x8B3AA0", VA = "0x1808B46A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int PDICKKBEHNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7775E0", Offset = "0x7769E0", VA = "0x1807775E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float NIIEJCGMPKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1D58D70", Offset = "0x1D58170", VA = "0x181D58D70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1D587F0", Offset = "0x1D57BF0", VA = "0x181D587F0")]
	private AJCCOAGGDOA(object MGFOKJNILLC, DBBHLOFGPKM CKGFPPHOKHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60AD090", Offset = "0x60AC490", VA = "0x1860AD090")]
	public static AJCCOAGGDOA BGKAABHEJDB(object MGFOKJNILLC)
	{
		return default(AJCCOAGGDOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60AD2B0", Offset = "0x60AC6B0", VA = "0x1860AD2B0")]
	public static AJCCOAGGDOA PBBFCGLIBFB(DBBHLOFGPKM CKGFPPHOKHO)
	{
		return default(AJCCOAGGDOA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60AD0C0", Offset = "0x60AC4C0", VA = "0x1860AD0C0")]
	public static AJCCOAGGDOA CNHHLDJFPMC(int FMOPHDNLNHI)
	{
		return default(AJCCOAGGDOA);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60AD1E0", Offset = "0x60AC5E0", VA = "0x1860AD1E0")]
	public static bool LPAHFDMKICD(in AJCCOAGGDOA LBABLKMFGKM, in AJCCOAGGDOA MGCAIGBBIIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60AD1E0", Offset = "0x60AC5E0", VA = "0x1860AD1E0", Slot = "4")]
	public bool Equals(AJCCOAGGDOA EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60AD1E0", Offset = "0x60AC5E0", VA = "0x1860AD1E0")]
	public bool OPIKPALMMII(in AJCCOAGGDOA EPJIAIAEMFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60AD110", Offset = "0x60AC510", VA = "0x1860AD110", Slot = "0")]
	public override bool Equals(object JLBINKLPHKJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60AD250", Offset = "0x60AC650", VA = "0x1860AD250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60AD2E0", Offset = "0x60AC6E0", VA = "0x1860AD2E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60AD1E0", Offset = "0x60AC5E0", VA = "0x1860AD1E0", Slot = "5")]
	private bool KLJHDFLMICF(in AJCCOAGGDOA EPJIAIAEMFF)
	{
		return default(bool);
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
