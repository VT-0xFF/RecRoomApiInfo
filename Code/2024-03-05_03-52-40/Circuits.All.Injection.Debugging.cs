using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KJBLIPCIJFM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class ANDLPHDFNHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public NCCEAJJILAH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C83A0", Offset = "0x7C71A0", VA = "0x1807C83A0")]
		public ANDLPHDFNHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D702B0", Offset = "0x1D6F0B0", VA = "0x181D702B0")]
		internal bool GJOJNLHIPNH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D703C0", Offset = "0x1D6F1C0", VA = "0x181D703C0")]
		internal void PEBHMKFNJOL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D70090", Offset = "0x1D6EE90", VA = "0x181D70090")]
		internal bool DIGFHENKEMP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D70150", Offset = "0x1D6EF50", VA = "0x181D70150")]
		internal void GELDEIAFCBM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D70300", Offset = "0x1D6F100", VA = "0x181D70300")]
		internal bool KNKNGIOOBPA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D70200", Offset = "0x1D6F000", VA = "0x181D70200")]
		internal void GGBKKCMEICN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly HOHFMGJEHCH ACHMAPLCKNO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D70470", Offset = "0x1D6F270", VA = "0x181D70470")]
	private static BBAEOFJIABF LCCKEJDFBDM(NCCEAJJILAH KJDEHDOPAJP)
	{
		return default(BBAEOFJIABF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D707B0", Offset = "0x1D6F5B0", VA = "0x181D707B0")]
	private static HOHFMGJEHCH OMKALDJKAAC()
	{
		return default(HOHFMGJEHCH);
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
