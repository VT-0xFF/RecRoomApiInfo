using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KLPKIHGAJLM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PIOAALEFCIP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LBMIHNICFPI logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
		public PIOAALEFCIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27FF580", Offset = "0x27FDD80", VA = "0x1827FF580")]
		internal bool OKBCICIDONG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27FF370", Offset = "0x27FDB70", VA = "0x1827FF370")]
		internal void FDOOAJDNINK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27FF4D0", Offset = "0x27FDCD0", VA = "0x1827FF4D0")]
		internal bool NAOFKHHBFDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27FF420", Offset = "0x27FDC20", VA = "0x1827FF420")]
		internal void GPEFJNINIOL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27FF210", Offset = "0x27FDA10", VA = "0x1827FF210")]
		internal bool AAGPJKHOELJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27FF2C0", Offset = "0x27FDAC0", VA = "0x1827FF2C0")]
		internal void FACGENGKIJE(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FANLCMLPJNJ HPECEAELCLK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27FE4E0", Offset = "0x27FCCE0", VA = "0x1827FE4E0")]
	private static HBPMIAHEKPK IFLEIKENIEN(LBMIHNICFPI LLHEGEEGDPP)
	{
		return default(HBPMIAHEKPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27FE800", Offset = "0x27FD000", VA = "0x1827FE800")]
	private static FANLCMLPJNJ INIKCGKMFJF()
	{
		return default(FANLCMLPJNJ);
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
