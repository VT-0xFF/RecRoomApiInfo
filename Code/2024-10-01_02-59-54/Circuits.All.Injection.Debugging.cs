using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class COHKNOICHCB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PPGDEECICIG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OJEODDGKLBF logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public PPGDEECICIG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21D3060", Offset = "0x21D2460", VA = "0x1821D3060")]
		internal bool OIGGFFHOMGP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21D2F00", Offset = "0x21D2300", VA = "0x1821D2F00")]
		internal void IIKNDLAENHO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21D2E50", Offset = "0x21D2250", VA = "0x1821D2E50")]
		internal bool GJOGIJGGMHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21D2DA0", Offset = "0x21D21A0", VA = "0x1821D2DA0")]
		internal void GGOPKIJKIFJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21D2FB0", Offset = "0x21D23B0", VA = "0x1821D2FB0")]
		internal bool NPKLLELHMNC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21D2CF0", Offset = "0x21D20F0", VA = "0x1821D2CF0")]
		internal void GEJMHIHLDKN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FFPAAJINDEC FKMJLLKHOAH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21D2850", Offset = "0x21D1C50", VA = "0x1821D2850")]
	private static NPADFMEMAMN LCOJAKEFPJB(OJEODDGKLBF HHNECAAHMAP)
	{
		return default(NPADFMEMAMN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21D1FE0", Offset = "0x21D13E0", VA = "0x1821D1FE0")]
	private static FFPAAJINDEC GMABDCJCCNK()
	{
		return default(FFPAAJINDEC);
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
