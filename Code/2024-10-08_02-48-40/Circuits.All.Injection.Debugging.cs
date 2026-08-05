using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CPKOAELBDMO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ANGKMAMPNFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IHEECFAHMJC logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x89F8B0", Offset = "0x89EAB0", VA = "0x18089F8B0")]
		public ANGKMAMPNFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21A0430", Offset = "0x219F630", VA = "0x1821A0430")]
		internal bool HDIPMFBHEFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21A0690", Offset = "0x219F890", VA = "0x1821A0690")]
		internal void PHFNCAKBNNI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21A0380", Offset = "0x219F580", VA = "0x1821A0380")]
		internal bool AOHMLOIPHNA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21A05E0", Offset = "0x219F7E0", VA = "0x1821A05E0")]
		internal void OGMOGNJOLIM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21A0480", Offset = "0x219F680", VA = "0x1821A0480")]
		internal bool MPCCOGPPKFK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21A0530", Offset = "0x219F730", VA = "0x1821A0530")]
		internal void NAOLMMPABOF(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CJGLKLPHCEA FAKOKDPOOAM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21A0FB0", Offset = "0x21A01B0", VA = "0x1821A0FB0")]
	private static HKKDANEFDJO GCNCGACPOOG(IHEECFAHMJC AEJOEJBAJPK)
	{
		return default(HKKDANEFDJO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21A0740", Offset = "0x219F940", VA = "0x1821A0740")]
	private static CJGLKLPHCEA DHJBKACJKCA()
	{
		return default(CJGLKLPHCEA);
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
