using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KAFKCBLJMPB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HJAENNFHCIF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OLOEHHOEAGL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA6E050", Offset = "0xA6D050", VA = "0x180A6E050")]
		public HJAENNFHCIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29A7FE0", Offset = "0x29A6FE0", VA = "0x1829A7FE0")]
		internal bool MDIHNNMMBND()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29A7C70", Offset = "0x29A6C70", VA = "0x1829A7C70")]
		internal void AFNJLBCBOGO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29A7DD0", Offset = "0x29A6DD0", VA = "0x1829A7DD0")]
		internal bool GIADOKDCGDH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29A7D20", Offset = "0x29A6D20", VA = "0x1829A7D20")]
		internal void EKBDEBDPKEH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29A7F30", Offset = "0x29A6F30", VA = "0x1829A7F30")]
		internal bool KGPANIFEHLC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x29A7E80", Offset = "0x29A6E80", VA = "0x1829A7E80")]
		internal void JJNDHHMIJCI(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MNNNJEDKMOL KONBGMLOLPI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29A8930", Offset = "0x29A7930", VA = "0x1829A8930")]
	private static GMIFOMPDPFI KAEPCEGFNAM(OLOEHHOEAGL FBJCFOKAMBJ)
	{
		return default(GMIFOMPDPFI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29A8030", Offset = "0x29A7030", VA = "0x1829A8030")]
	private static MNNNJEDKMOL ENGGEJDOANA()
	{
		return default(MNNNJEDKMOL);
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
