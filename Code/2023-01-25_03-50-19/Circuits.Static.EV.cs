using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Class: {Class}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
public struct ENAJOPGILKN : IEquatable<ENAJOPGILKN>, global::JPJCEIEIHHO<ENAJOPGILKN>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public object FHADJFFAPHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public IBDOAHJDBEN FMGPHBIDJOG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool FIIDCEEEJFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x841D20", Offset = "0x840D20", VA = "0x180841D20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int HBFGICIFAKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x77D5E0", Offset = "0x77C5E0", VA = "0x18077D5E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HOPBABHIODK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2078C90", Offset = "0x2077C90", VA = "0x182078C90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2078300", Offset = "0x2077300", VA = "0x182078300")]
	private ENAJOPGILKN(object BBMJGHEEPHK, IBDOAHJDBEN BKMIIMFKDDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6122BF0", Offset = "0x6121BF0", VA = "0x186122BF0")]
	public static ENAJOPGILKN IMIHAOLMAIN(object BBMJGHEEPHK)
	{
		return default(ENAJOPGILKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6122BC0", Offset = "0x6121BC0", VA = "0x186122BC0")]
	public static ENAJOPGILKN ILIJMCGHDDB(IBDOAHJDBEN BKMIIMFKDDL)
	{
		return default(ENAJOPGILKN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6122C20", Offset = "0x6121C20", VA = "0x186122C20")]
	public static ENAJOPGILKN LNOKEPAHIAE(int OJGJNEOMMEO)
	{
		return default(ENAJOPGILKN);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6122A20", Offset = "0x6121A20", VA = "0x186122A20")]
	public static bool FHCNBCDBOFI(in ENAJOPGILKN JCHPGJLCOCJ, in ENAJOPGILKN GHMOJHOMMOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6122A20", Offset = "0x6121A20", VA = "0x186122A20", Slot = "4")]
	public bool Equals(ENAJOPGILKN KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6122A20", Offset = "0x6121A20", VA = "0x186122A20")]
	public bool AFCKBDHDODL(in ENAJOPGILKN KICLNADFIEK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6122A90", Offset = "0x6121A90", VA = "0x186122A90", Slot = "0")]
	public override bool Equals(object GKCPJCKCENH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6122B60", Offset = "0x6121B60", VA = "0x186122B60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6122C70", Offset = "0x6121C70", VA = "0x186122C70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6122A20", Offset = "0x6121A20", VA = "0x186122A20", Slot = "5")]
	private bool HGJGKPHMGAP(in ENAJOPGILKN KICLNADFIEK)
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
