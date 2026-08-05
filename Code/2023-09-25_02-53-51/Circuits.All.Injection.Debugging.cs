using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AGNBCFJNANL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AGOBDAOOEIM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public EFCCEFGBMAN logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76DD90", Offset = "0x76D190", VA = "0x18076DD90")]
		public AGOBDAOOEIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB6A0", Offset = "0x1BFAAA0", VA = "0x181BFB6A0")]
		internal bool JLCJDDHMGOC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB5F0", Offset = "0x1BFA9F0", VA = "0x181BFB5F0")]
		internal void JFNJDKFAILP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB6F0", Offset = "0x1BFAAF0", VA = "0x181BFB6F0")]
		internal bool LHDPLEDNGCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB540", Offset = "0x1BFA940", VA = "0x181BFB540")]
		internal void JAGHMJFKIGA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB7B0", Offset = "0x1BFABB0", VA = "0x181BFB7B0")]
		internal bool MBFOEIKODBM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1BFB490", Offset = "0x1BFA890", VA = "0x181BFB490")]
		internal void BALBHHMDEIO(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FOKCCPKMBOJ OMCMBELJBID;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1BFAFE0", Offset = "0x1BFA3E0", VA = "0x181BFAFE0")]
	private static KCKNOPJBFCK HBCPBLNEHGG(EFCCEFGBMAN DCBLKKFGGKL)
	{
		return default(KCKNOPJBFCK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1BFA730", Offset = "0x1BF9B30", VA = "0x181BFA730")]
	private static FOKCCPKMBOJ FJDFMOOHHHC()
	{
		return default(FOKCCPKMBOJ);
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
