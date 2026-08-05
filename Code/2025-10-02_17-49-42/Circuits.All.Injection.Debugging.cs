using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GLDHANNBOHE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HNCEEAOOOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CFCAHAGIHFI logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public HNCEEAOOOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB9B0", Offset = "0x2ACA3B0", VA = "0x182ACB9B0")]
		internal bool LAGELPLEDKK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB7A0", Offset = "0x2ACA1A0", VA = "0x182ACB7A0")]
		internal void BOFBNCCJOGG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBAB0", Offset = "0x2ACA4B0", VA = "0x182ACBAB0")]
		internal bool MOLKFNNEIKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB900", Offset = "0x2ACA300", VA = "0x182ACB900")]
		internal void EPNJCPGCHJE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2ACB850", Offset = "0x2ACA250", VA = "0x182ACB850")]
		internal bool ELBNKLELPHI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2ACBA00", Offset = "0x2ACA400", VA = "0x182ACBA00")]
		internal void LDILMPLFEAO(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly JHEGMKAPEKD FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2ACB310", Offset = "0x2AC9D10", VA = "0x182ACB310")]
	private static NLGCGKDKPPP PKGPOIDOBNC(CFCAHAGIHFI BPHDOIMOPAB)
	{
		return default(NLGCGKDKPPP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2ACAA10", Offset = "0x2AC9410", VA = "0x182ACAA10")]
	private static JHEGMKAPEKD FIAIFGADKML()
	{
		return default(JHEGMKAPEKD);
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
