using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DNOKKPOGJNP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HDPBAIBGGDK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BLAPDLNLEPM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		public HDPBAIBGGDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x26E0570", Offset = "0x26DED70", VA = "0x1826E0570")]
		internal bool IIJPKLGCDMG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x26E0670", Offset = "0x26DEE70", VA = "0x1826E0670")]
		internal void KHHIPIIFGBP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x26E04C0", Offset = "0x26DECC0", VA = "0x1826E04C0")]
		internal bool DJGEGOHAKBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x26E0410", Offset = "0x26DEC10", VA = "0x1826E0410")]
		internal void BMDKEGFDAGM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x26E0720", Offset = "0x26DEF20", VA = "0x1826E0720")]
		internal bool KLIOAHIGICB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x26E05C0", Offset = "0x26DEDC0", VA = "0x1826E05C0")]
		internal void KAHABDJFOCC(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NFCOFGADCAF DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x26DF6E0", Offset = "0x26DDEE0", VA = "0x1826DF6E0")]
	private static IGODEECKAHO CDKDJHFCPIB(BLAPDLNLEPM BBGCCMDAKAG)
	{
		return default(IGODEECKAHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x26DFA00", Offset = "0x26DE200", VA = "0x1826DFA00")]
	private static NFCOFGADCAF HPCHIPHHABP()
	{
		return default(NFCOFGADCAF);
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
