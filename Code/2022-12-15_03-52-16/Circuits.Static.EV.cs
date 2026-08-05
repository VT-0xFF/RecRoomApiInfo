using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Class: {Class}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
public struct HAKMNOKBDLC : IEquatable<HAKMNOKBDLC>, global::HHEBNBIKHFO<HAKMNOKBDLC>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public object AFNNNMPOELP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public INCGDFAGALM JAECPGDLFKD;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PBLELJELMGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8B36A0", Offset = "0x8B20A0", VA = "0x1808B36A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AFCLECPKMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x774FE0", VA = "0x1807765E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GGHAKKJJEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x1E24CC0", Offset = "0x1E236C0", VA = "0x181E24CC0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1E24720", Offset = "0x1E23120", VA = "0x181E24720")]
	private HAKMNOKBDLC(object EFDMPOJKKIB, INCGDFAGALM BJKLODCHKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A1280", Offset = "0x609FC80", VA = "0x1860A1280")]
	public static HAKMNOKBDLC AMCACNOGKJP(object EFDMPOJKKIB)
	{
		return default(HAKMNOKBDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A14A0", Offset = "0x609FEA0", VA = "0x1860A14A0")]
	public static HAKMNOKBDLC MFCLEOAFKOM(INCGDFAGALM BJKLODCHKGL)
	{
		return default(HAKMNOKBDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60A1450", Offset = "0x609FE50", VA = "0x1860A1450")]
	public static HAKMNOKBDLC JMLFBNDLCCM(int NBFLOLMEHLE)
	{
		return default(HAKMNOKBDLC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A12B0", Offset = "0x609FCB0", VA = "0x1860A12B0")]
	public static bool GBIPOJBPNDJ(in HAKMNOKBDLC OLACFPEGPAG, in HAKMNOKBDLC GLLCOOLKDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60A12B0", Offset = "0x609FCB0", VA = "0x1860A12B0", Slot = "4")]
	public bool Equals(HAKMNOKBDLC OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60A12B0", Offset = "0x609FCB0", VA = "0x1860A12B0")]
	public bool CMHNKMMFGLG(in HAKMNOKBDLC OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60A1320", Offset = "0x609FD20", VA = "0x1860A1320", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60A13F0", Offset = "0x609FDF0", VA = "0x1860A13F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60A14D0", Offset = "0x609FED0", VA = "0x1860A14D0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60A12B0", Offset = "0x609FCB0", VA = "0x1860A12B0", Slot = "5")]
	private bool MKFKJKJHKLO(in HAKMNOKBDLC OANENNOJEBB)
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
