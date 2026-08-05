using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[DebuggerDisplay("Class: {Class}, Bool: {Bool}, I32: {I32}, F32: {F32}")]
public struct FCBADKIDPPG : IEquatable<FCBADKIDPPG>, global::CEIPFJFHMPO<FCBADKIDPPG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public object LICAFJOANDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	public JNEOOAIDDCO CENOLBOLNLO;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool BPGDCJHHNHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xC3F850", Offset = "0xC3E450", VA = "0x180C3F850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public int CBLJDGLPHDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x71A020", Offset = "0x718C20", VA = "0x18071A020")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public float GNGKMJBOPOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6B2780", Offset = "0x6B1380", VA = "0x1806B2780")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x2703A10", Offset = "0x2702610", VA = "0x182703A10")]
	private FCBADKIDPPG(object LKGKDJFPFPD, JNEOOAIDDCO FHEJAHFIMFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x609EC70", Offset = "0x609D870", VA = "0x18609EC70")]
	public static FCBADKIDPPG IKLCEAHJEHM(object LKGKDJFPFPD)
	{
		return default(FCBADKIDPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x609ECA0", Offset = "0x609D8A0", VA = "0x18609ECA0")]
	public static FCBADKIDPPG KOBOCCOAKMG(JNEOOAIDDCO FHEJAHFIMFD)
	{
		return default(FCBADKIDPPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x609EAF0", Offset = "0x609D6F0", VA = "0x18609EAF0")]
	public static FCBADKIDPPG EFOCCLEOBAM(int LABOPAPJOAM)
	{
		return default(FCBADKIDPPG);
	}

	[SpecialName]
	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x609EA80", Offset = "0x609D680", VA = "0x18609EA80")]
	public static bool HIPCOIHOPDI(in FCBADKIDPPG NEDFKMIBIEI, in FCBADKIDPPG FMLJLFCAJGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x609EA80", Offset = "0x609D680", VA = "0x18609EA80", Slot = "4")]
	public bool Equals(FCBADKIDPPG GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x609EA80", Offset = "0x609D680", VA = "0x18609EA80")]
	public bool CMOINNMGOCM(in FCBADKIDPPG GHLMPEGFGCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x609EB40", Offset = "0x609D740", VA = "0x18609EB40", Slot = "0")]
	public override bool Equals(object AOEMDAGAALP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x609EC10", Offset = "0x609D810", VA = "0x18609EC10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x609ECD0", Offset = "0x609D8D0", VA = "0x18609ECD0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x609EA80", Offset = "0x609D680", VA = "0x18609EA80", Slot = "5")]
	private bool BKNOBBJIKEB(in FCBADKIDPPG GHLMPEGFGCH)
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
