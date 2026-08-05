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
		[Cpp2IlInjected.Address(RVA = "0x8B36A0", Offset = "0x8B22A0", VA = "0x1808B36A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CEGNBJDLNEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7765E0", Offset = "0x7751E0", VA = "0x1807765E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float HPBLFJMILKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x2011C90", Offset = "0x2010890", VA = "0x182011C90")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x20115A0", Offset = "0x20101A0", VA = "0x1820115A0")]
	private LKNIEKGCOME(object FLMGGABBAGH, AKGIFENBIBF MLNBAHCMFJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6097EB0", Offset = "0x6096AB0", VA = "0x186097EB0")]
	public static LKNIEKGCOME HOGGDFGLNIC(object FLMGGABBAGH)
	{
		return default(LKNIEKGCOME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x6097EE0", Offset = "0x6096AE0", VA = "0x186097EE0")]
	public static LKNIEKGCOME KGANLMBAEOL(AKGIFENBIBF MLNBAHCMFJK)
	{
		return default(LKNIEKGCOME);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x6097E00", Offset = "0x6096A00", VA = "0x186097E00")]
	public static LKNIEKGCOME FMGEJCKHPFM(int PBMHFAHOFPD)
	{
		return default(LKNIEKGCOME);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x6097D90", Offset = "0x6096990", VA = "0x186097D90")]
	public static bool IKJLJMIELNH(in LKNIEKGCOME MGIINGKDNDK, in LKNIEKGCOME GNLBKLBDKBA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x6097D90", Offset = "0x6096990", VA = "0x186097D90", Slot = "4")]
	public bool Equals(LKNIEKGCOME MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6097D90", Offset = "0x6096990", VA = "0x186097D90")]
	public bool NBEBPGLOHAK(in LKNIEKGCOME MCLIMJFDMCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6097CC0", Offset = "0x60968C0", VA = "0x186097CC0", Slot = "0")]
	public override bool Equals(object KMFLGGMLFJA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6097E50", Offset = "0x6096A50", VA = "0x186097E50", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6097F10", Offset = "0x6096B10", VA = "0x186097F10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x6097D90", Offset = "0x6096990", VA = "0x186097D90", Slot = "5")]
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
