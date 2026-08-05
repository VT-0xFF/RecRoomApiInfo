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
		[Cpp2IlInjected.Address(RVA = "0xF8C490", Offset = "0xF8AA90", VA = "0x180F8C490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int AFCLECPKMKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x677CF0", Offset = "0x6762F0", VA = "0x180677CF0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GGHAKKJJEJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x74C030", Offset = "0x74A630", VA = "0x18074C030")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2C14660", Offset = "0x2C12C60", VA = "0x182C14660")]
	private HAKMNOKBDLC(object EFDMPOJKKIB, INCGDFAGALM BJKLODCHKGL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x60A3990", Offset = "0x60A1F90", VA = "0x1860A3990")]
	public static HAKMNOKBDLC AMCACNOGKJP(object EFDMPOJKKIB)
	{
		return default(HAKMNOKBDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x60A3BB0", Offset = "0x60A21B0", VA = "0x1860A3BB0")]
	public static HAKMNOKBDLC MFCLEOAFKOM(INCGDFAGALM BJKLODCHKGL)
	{
		return default(HAKMNOKBDLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B60", Offset = "0x60A2160", VA = "0x1860A3B60")]
	public static HAKMNOKBDLC JMLFBNDLCCM(int NBFLOLMEHLE)
	{
		return default(HAKMNOKBDLC);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x60A39C0", Offset = "0x60A1FC0", VA = "0x1860A39C0")]
	public static bool GBIPOJBPNDJ(in HAKMNOKBDLC OLACFPEGPAG, in HAKMNOKBDLC GLLCOOLKDAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x60A39C0", Offset = "0x60A1FC0", VA = "0x1860A39C0", Slot = "4")]
	public bool Equals(HAKMNOKBDLC OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x60A39C0", Offset = "0x60A1FC0", VA = "0x1860A39C0")]
	public bool CMHNKMMFGLG(in HAKMNOKBDLC OANENNOJEBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x60A3A30", Offset = "0x60A2030", VA = "0x1860A3A30", Slot = "0")]
	public override bool Equals(object LGKNNMGLNIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60A3B00", Offset = "0x60A2100", VA = "0x1860A3B00", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60A3BE0", Offset = "0x60A21E0", VA = "0x1860A3BE0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x60A39C0", Offset = "0x60A1FC0", VA = "0x1860A39C0", Slot = "5")]
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
