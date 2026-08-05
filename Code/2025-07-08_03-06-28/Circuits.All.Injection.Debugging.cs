using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NFFKKLFHHOJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class EDNMCBPJLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LJBOOAFCILM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA5DEF0", Offset = "0xA5CCF0", VA = "0x180A5DEF0")]
		public EDNMCBPJLME()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x293D2B0", Offset = "0x293C0B0", VA = "0x18293D2B0")]
		internal bool PIKDJECPFLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x293D0A0", Offset = "0x293BEA0", VA = "0x18293D0A0")]
		internal void EIBKJBBKBMN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x293D150", Offset = "0x293BF50", VA = "0x18293D150")]
		internal bool HJPICBHJHMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x293CFF0", Offset = "0x293BDF0", VA = "0x18293CFF0")]
		internal void BNDAGGFKBIP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x293CF40", Offset = "0x293BD40", VA = "0x18293CF40")]
		internal bool BDIAMOKCICD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x293D200", Offset = "0x293C000", VA = "0x18293D200")]
		internal void JKNPLABEMJP(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AFNIPBMPNFL ODAOEPEFKDK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x293D300", Offset = "0x293C100", VA = "0x18293D300")]
	private static AOMNGHJFFHH FFHLCLOCDMH(LJBOOAFCILM GPLNJHLKAMH)
	{
		return default(AOMNGHJFFHH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x293D630", Offset = "0x293C430", VA = "0x18293D630")]
	private static AFNIPBMPNFL INBIELOEJHH()
	{
		return default(AFNIPBMPNFL);
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
