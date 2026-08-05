using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ONIAFJBCFJM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PBBJJDCLLGK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MBPNBFDACPD logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84C440", Offset = "0x84B640", VA = "0x18084C440")]
		public PBBJJDCLLGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1585BC0", Offset = "0x1584DC0", VA = "0x181585BC0")]
		internal bool KNCPDNEIJBC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x15858F0", Offset = "0x1584AF0", VA = "0x1815858F0")]
		internal void AMEEFAAAIPL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1585B00", Offset = "0x1584D00", VA = "0x181585B00")]
		internal bool KEAGELFKBOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1585A50", Offset = "0x1584C50", VA = "0x181585A50")]
		internal void IHPKEBMDPMH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1585C20", Offset = "0x1584E20", VA = "0x181585C20")]
		internal bool POOABJBLKEC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x15859A0", Offset = "0x1584BA0", VA = "0x1815859A0")]
		internal void BJJEGFCAGDI(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly BBDIDIOIMKB EBEPLDELFOG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1585490", Offset = "0x1584690", VA = "0x181585490")]
	private static LHBFBBLAEKP LCHAHBOLAJP(MBPNBFDACPD ALHJKEONHDO)
	{
		return default(LHBFBBLAEKP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1584C90", Offset = "0x1583E90", VA = "0x181584C90")]
	private static BBDIDIOIMKB JLGOPJHGBDA()
	{
		return default(BBDIDIOIMKB);
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
