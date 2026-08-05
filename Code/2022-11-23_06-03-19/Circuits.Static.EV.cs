using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Class: {Class}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
public struct LKNIEKGCOME : IEquatable<LKNIEKGCOME>, global::GMAJGPJLILE<LKNIEKGCOME>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public object AHHOPFPBLIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public AKGIFENBIBF HAFBKJIDPNL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool EFGIIBFPGPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xB2C210", Offset = "0xB2B010", VA = "0x180B2C210")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CEGNBJDLNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6D4910", Offset = "0x6D3710", VA = "0x1806D4910")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HPBLFJMILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x66D060", Offset = "0x66BE60", VA = "0x18066D060")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2521AD0", Offset = "0x25208D0", VA = "0x182521AD0")]
	private LKNIEKGCOME(object FLMGGABBAGH, AKGIFENBIBF MLNBAHCMFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5EC04D0", Offset = "0x5EBF2D0", VA = "0x185EC04D0")]
	public static LKNIEKGCOME HOGGDFGLNIC(object FLMGGABBAGH)
	{
		return default(LKNIEKGCOME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0500", Offset = "0x5EBF300", VA = "0x185EC0500")]
	public static LKNIEKGCOME KGANLMBAEOL(AKGIFENBIBF MLNBAHCMFJK)
	{
		return default(LKNIEKGCOME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0420", Offset = "0x5EBF220", VA = "0x185EC0420")]
	public static LKNIEKGCOME FMGEJCKHPFM(int PBMHFAHOFPD)
	{
		return default(LKNIEKGCOME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03B0", Offset = "0x5EBF1B0", VA = "0x185EC03B0")]
	public static bool IKJLJMIELNH(in LKNIEKGCOME MGIINGKDNDK, in LKNIEKGCOME GNLBKLBDKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03B0", Offset = "0x5EBF1B0", VA = "0x185EC03B0", Slot = "4")]
	public bool Equals(LKNIEKGCOME MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03B0", Offset = "0x5EBF1B0", VA = "0x185EC03B0")]
	public bool NBEBPGLOHAK(in LKNIEKGCOME MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x5EC02E0", Offset = "0x5EBF0E0", VA = "0x185EC02E0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0470", Offset = "0x5EBF270", VA = "0x185EC0470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5EC0530", Offset = "0x5EBF330", VA = "0x185EC0530", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x5EC03B0", Offset = "0x5EBF1B0", VA = "0x185EC03B0", Slot = "5")]
	private bool KENNKLPBHKA(in LKNIEKGCOME MCLIMJFDMCF)
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
