using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AEPCAJMHHKM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CBLGNIJEOLN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LLFNHNCNGDD logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CBLGNIJEOLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x20E44B0", Offset = "0x20E2EB0", VA = "0x1820E44B0")]
		internal bool BDMLGIBHLMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x20E4710", Offset = "0x20E3110", VA = "0x1820E4710")]
		internal void OPCAOKIGKOM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x20E47C0", Offset = "0x20E31C0", VA = "0x1820E47C0")]
		internal bool PAOCAMKLOCO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x20E45B0", Offset = "0x20E2FB0", VA = "0x1820E45B0")]
		internal void DGBCPDCJIAP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x20E4500", Offset = "0x20E2F00", VA = "0x1820E4500")]
		internal bool BFIDFJHHNHF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20E4660", Offset = "0x20E3060", VA = "0x1820E4660")]
		internal void EKAHNHOOHOD(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NLAHJACCIBP GHBFIIGNNDE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x20E4010", Offset = "0x20E2A10", VA = "0x1820E4010")]
	private static BFIAAFJLAAA OOMOHGIKDJB(LLFNHNCNGDD HBBLDLCENIL)
	{
		return default(BFIAAFJLAAA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x20E37A0", Offset = "0x20E21A0", VA = "0x1820E37A0")]
	private static NLAHJACCIBP ILIAEEEPFPL()
	{
		return default(NLAHJACCIBP);
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
