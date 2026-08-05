using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NCPCMGFDHIC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HBAHJCLPNOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LOJJIFNAMJM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
		public HBAHJCLPNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x252B690", Offset = "0x2529C90", VA = "0x18252B690")]
		internal bool FFANCMHFCDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x252B6E0", Offset = "0x2529CE0", VA = "0x18252B6E0")]
		internal void GFEOOKPAKGF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x252B790", Offset = "0x2529D90", VA = "0x18252B790")]
		internal bool HEAMNGDHKBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x252B8F0", Offset = "0x2529EF0", VA = "0x18252B8F0")]
		internal void PDCOFPFKHOC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x252B840", Offset = "0x2529E40", VA = "0x18252B840")]
		internal bool OLKCIGLAKAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x252B9A0", Offset = "0x2529FA0", VA = "0x18252B9A0")]
		internal void PHLOIOJPENI(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AKHCPLHBAHJ IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x252C350", Offset = "0x252A950", VA = "0x18252C350")]
	private static EDNEPNABDLO NGJHDKECJAP(LOJJIFNAMJM PDPNMLGCFGG)
	{
		return default(EDNEPNABDLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x252BA50", Offset = "0x252A050", VA = "0x18252BA50")]
	private static AKHCPLHBAHJ DLAGCBFCIOL()
	{
		return default(AKHCPLHBAHJ);
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
