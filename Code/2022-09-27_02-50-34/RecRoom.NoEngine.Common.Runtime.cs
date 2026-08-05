using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[StructLayout((LayoutKind)0, Size = 1)]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public readonly struct JMNHLBPPELC : IEquatable<JMNHLBPPELC>
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x601070", Offset = "0x600270", VA = "0x180601070", Slot = "4")]
	public bool Equals(JMNHLBPPELC GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28A40F0", Offset = "0x28A32F0", VA = "0x1828A40F0", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x28A4140", Offset = "0x28A3340", VA = "0x1828A4140", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x28A4150", Offset = "0x28A3350", VA = "0x1828A4150", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public readonly struct CMBKIHGPMOG<T> : IEquatable<global::CMBKIHGPMOG<T>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public readonly T MDDADGNJOKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public readonly bool COKPGBMFGNM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool HKBCPCDEANE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x435C130", Offset = "0x435B330", VA = "0x18435C130")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x435C950", Offset = "0x435BB50", VA = "0x18435C950")]
	public CMBKIHGPMOG(in T ADBNEBBHMOP, bool NAHCKHOKPKF)
	{
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x435C4C0", Offset = "0x435B6C0", VA = "0x18435C4C0")]
	public static bool OBFGCGKAGJG(in global::CMBKIHGPMOG<T> IPOFNDCGNHE, in global::CMBKIHGPMOG<T> GOIECGKCDOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3AAEFF0", Offset = "0x3AAE1F0", VA = "0x183AAEFF0", Slot = "4")]
	public bool Equals(global::CMBKIHGPMOG<T> GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x435BBE0", Offset = "0x435ADE0", VA = "0x18435BBE0", Slot = "0")]
	public override bool Equals(object GHOINNFPLDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x435C1E0", Offset = "0x435B3E0", VA = "0x18435C1E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x435C780", Offset = "0x435B980", VA = "0x18435C780", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class AOHCHDFDINM
{
	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3A05910", Offset = "0x3A04B10", VA = "0x183A05910")]
	public static global::CMBKIHGPMOG<T> GHPBDIAPNPO<T>(in T ADBNEBBHMOP)
	{
		return default(global::CMBKIHGPMOG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3A05A20", Offset = "0x3A04C20", VA = "0x183A05A20")]
	public static global::CMBKIHGPMOG<T> NPIGMHPGFKC<T>()
	{
		return default(global::CMBKIHGPMOG<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x46975D0", Offset = "0x46967D0", VA = "0x1846975D0")]
	public static bool HNIJFJOBNMJ<T>(this in global::CMBKIHGPMOG<T> OKMDMICBNGD, out T ADBNEBBHMOP)
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
