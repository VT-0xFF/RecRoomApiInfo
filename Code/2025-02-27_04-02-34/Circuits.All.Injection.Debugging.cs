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
		[Cpp2IlInjected.Address(RVA = "0x9597B0", Offset = "0x958BB0", VA = "0x1809597B0")]
		public HBAHJCLPNOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24F8910", Offset = "0x24F7D10", VA = "0x1824F8910")]
		internal bool FFANCMHFCDG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24F8960", Offset = "0x24F7D60", VA = "0x1824F8960")]
		internal void GFEOOKPAKGF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24F8A10", Offset = "0x24F7E10", VA = "0x1824F8A10")]
		internal bool HEAMNGDHKBF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24F8B70", Offset = "0x24F7F70", VA = "0x1824F8B70")]
		internal void PDCOFPFKHOC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24F8AC0", Offset = "0x24F7EC0", VA = "0x1824F8AC0")]
		internal bool OLKCIGLAKAM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24F8C20", Offset = "0x24F8020", VA = "0x1824F8C20")]
		internal void PHLOIOJPENI(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly AKHCPLHBAHJ IMFIEPMCPDC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24F95D0", Offset = "0x24F89D0", VA = "0x1824F95D0")]
	private static EDNEPNABDLO NGJHDKECJAP(LOJJIFNAMJM PDPNMLGCFGG)
	{
		return default(EDNEPNABDLO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24F8CD0", Offset = "0x24F80D0", VA = "0x1824F8CD0")]
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
