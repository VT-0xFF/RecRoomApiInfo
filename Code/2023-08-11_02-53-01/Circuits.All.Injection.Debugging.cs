using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GEADALFHHCD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AMCEJOKAIAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IAADJKKLEKO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x83E600", Offset = "0x83CE00", VA = "0x18083E600")]
		public AMCEJOKAIAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6EFCA50", Offset = "0x6EFB250", VA = "0x186EFCA50")]
		internal bool MJNKPIGHGEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC820", Offset = "0x6EFB020", VA = "0x186EFC820")]
		internal void LHECFONJCAG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC8D0", Offset = "0x6EFB0D0", VA = "0x186EFC8D0")]
		internal bool LOJNHBBGDLK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC9A0", Offset = "0x6EFB1A0", VA = "0x186EFC9A0")]
		internal void MIILGOPIOEF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC6A0", Offset = "0x6EFAEA0", VA = "0x186EFC6A0")]
		internal bool BGFFAGDKLLB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6EFC770", Offset = "0x6EFAF70", VA = "0x186EFC770")]
		internal void IEKKPLLLIKF(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MENKOHACEDJ OEFAOPMNMGM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCAB0", Offset = "0x6EFB2B0", VA = "0x186EFCAB0")]
	private static GAENKJKIEPM BOEDECGNIDB(IAADJKKLEKO GHLLLGFGFMD)
	{
		return default(GAENKJKIEPM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6EFCDB0", Offset = "0x6EFB5B0", VA = "0x186EFCDB0")]
	private static MENKOHACEDJ OOOCCJKBJHJ()
	{
		return default(MENKOHACEDJ);
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
