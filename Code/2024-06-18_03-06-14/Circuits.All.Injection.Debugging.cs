using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BPGIPFLONMH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GNADEONEOFJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OOEDGEBHONN logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84D150", Offset = "0x84BB50", VA = "0x18084D150")]
		public GNADEONEOFJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F483D0", Offset = "0x1F46DD0", VA = "0x181F483D0")]
		internal bool HCLHFMLPGJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F48260", Offset = "0x1F46C60", VA = "0x181F48260")]
		internal void GMGDPOHDBBK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F48420", Offset = "0x1F46E20", VA = "0x181F48420")]
		internal bool HJOMPIOHFFG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F48590", Offset = "0x1F46F90", VA = "0x181F48590")]
		internal void JFLFHLLLACC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F48310", Offset = "0x1F46D10", VA = "0x181F48310")]
		internal bool GMOOIEHKEIG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F484E0", Offset = "0x1F46EE0", VA = "0x181F484E0")]
		internal void INCCIOPFOLM(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AEIDIJBLIEL OHJMENPNAKB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F47500", Offset = "0x1F45F00", VA = "0x181F47500")]
	private static IDGPEECGKMK AAIDBOOPBPI(OOEDGEBHONN EEMGFMDBGDI)
	{
		return default(IDGPEECGKMK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F47840", Offset = "0x1F46240", VA = "0x181F47840")]
	private static AEIDIJBLIEL GFGLAHIPEDH()
	{
		return default(AEIDIJBLIEL);
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
