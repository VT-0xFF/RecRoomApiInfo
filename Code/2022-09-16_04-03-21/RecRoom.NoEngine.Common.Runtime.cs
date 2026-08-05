using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct OKGJCEGJEIG : IEquatable<OKGJCEGJEIG>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6120B0", Offset = "0x6108B0", VA = "0x1806120B0", Slot = "4")]
	public bool Equals(OKGJCEGJEIG ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x421DD10", Offset = "0x421C510", VA = "0x18421DD10", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x421DD60", Offset = "0x421C560", VA = "0x18421DD60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x421DD70", Offset = "0x421C570", VA = "0x18421DD70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct LMIAMFMFOHF<T> : IEquatable<global::LMIAMFMFOHF<T>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly T EJFMLMNCFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly bool KLGFNIHNIOJ;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool LLOMGNFGIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x55B46F0", Offset = "0x55B2EF0", VA = "0x1855B46F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x55B49B0", Offset = "0x55B31B0", VA = "0x1855B49B0")]
	public LMIAMFMFOHF(in T CJMMBFLIBMO, bool ACKBDCBKFDH)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x55B4550", Offset = "0x55B2D50", VA = "0x1855B4550")]
	public static bool LLPKNBIICCC(in global::LMIAMFMFOHF<T> EFFMHOCDHAK, in global::LMIAMFMFOHF<T> AOHBHKCKGOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0xE2D1F0", Offset = "0xE2B9F0", VA = "0x180E2D1F0", Slot = "4")]
	public bool Equals(global::LMIAMFMFOHF<T> ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x55B40C0", Offset = "0x55B28C0", VA = "0x1855B40C0", Slot = "0")]
	public override bool Equals(object ALBOAABJIJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x55B4280", Offset = "0x55B2A80", VA = "0x1855B4280", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x55B4800", Offset = "0x55B3000", VA = "0x1855B4800", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IBAFGDIMJAE
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xDA52A0", Offset = "0xDA3AA0", VA = "0x180DA52A0")]
	public static global::LMIAMFMFOHF<T> HANDPDIDBIM<T>(in T CJMMBFLIBMO)
	{
		return default(global::LMIAMFMFOHF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xDA5150", Offset = "0xDA3950", VA = "0x180DA5150")]
	public static global::LMIAMFMFOHF<T> FIEHNBABKNE<T>()
	{
		return default(global::LMIAMFMFOHF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x178D140", Offset = "0x178B940", VA = "0x18178D140")]
	public static bool PJOHNGKNBEM<T>(this in global::LMIAMFMFOHF<T> ENHHFGJHICK, out T CJMMBFLIBMO)
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
