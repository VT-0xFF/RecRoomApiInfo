using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LPEFPDPLCKK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class LKAFBDCJCAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public EGIBMFDMBLP logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7793D0", Offset = "0x7781D0", VA = "0x1807793D0")]
		public LKAFBDCJCAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C88F40", Offset = "0x1C87D40", VA = "0x181C88F40")]
		internal bool OJKKMODHKDJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C89050", Offset = "0x1C87E50", VA = "0x181C89050")]
		internal void PKHFMKBKOJK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C88F90", Offset = "0x1C87D90", VA = "0x181C88F90")]
		internal bool OLNNALKFBMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C88E90", Offset = "0x1C87C90", VA = "0x181C88E90")]
		internal void MFKGMDJMAIP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C88D20", Offset = "0x1C87B20", VA = "0x181C88D20")]
		internal bool BJEGNNBLHHB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C88DE0", Offset = "0x1C87BE0", VA = "0x181C88DE0")]
		internal void KOAJNDMJEDH(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly DFMHMGPJKAJ ANGIAPALHML;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C89100", Offset = "0x1C87F00", VA = "0x181C89100")]
	private static NIOCDPPHCNG IJHHKNBFICE(EGIBMFDMBLP MOJLPNDEAML)
	{
		return default(NIOCDPPHCNG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C89440", Offset = "0x1C88240", VA = "0x181C89440")]
	private static DFMHMGPJKAJ MBOFMLPNLEM()
	{
		return default(DFMHMGPJKAJ);
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
