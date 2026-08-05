using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LIFEDGABPAE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class IDDBMLKLOOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BCNJPGKAJGJ logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CE160", Offset = "0x7CD160", VA = "0x1807CE160")]
		public IDDBMLKLOOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE3C0", Offset = "0x1DFD3C0", VA = "0x181DFE3C0")]
		internal bool EOOKCKKNMNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE0F0", Offset = "0x1DFD0F0", VA = "0x181DFE0F0")]
		internal void ACDIKHILLGG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE410", Offset = "0x1DFD410", VA = "0x181DFE410")]
		internal bool LKMIEMEIBHN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE250", Offset = "0x1DFD250", VA = "0x181DFE250")]
		internal void CKLCCKHBDOC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE300", Offset = "0x1DFD300", VA = "0x181DFE300")]
		internal bool EICJKPFKGOG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DFE1A0", Offset = "0x1DFD1A0", VA = "0x181DFE1A0")]
		internal void BBHHEDEABKE(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CPFLAJCCPOO AFPJCELPLKK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DFED80", Offset = "0x1DFDD80", VA = "0x181DFED80")]
	private static HDMNFPGFPFC IDNMODJELDK(BCNJPGKAJGJ CBAAFJKIAAJ)
	{
		return default(HDMNFPGFPFC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DFE4D0", Offset = "0x1DFD4D0", VA = "0x181DFE4D0")]
	private static CPFLAJCCPOO EHEGAHINFHJ()
	{
		return default(CPFLAJCCPOO);
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
