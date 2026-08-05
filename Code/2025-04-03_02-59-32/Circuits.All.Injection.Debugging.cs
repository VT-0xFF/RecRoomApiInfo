using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MHBEMFBBJNH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class EGGONDMPHLD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AEHPAJILBPF logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9A2500", Offset = "0x9A1900", VA = "0x1809A2500")]
		public EGGONDMPHLD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x261C1D0", Offset = "0x261B5D0", VA = "0x18261C1D0")]
		internal bool IOEKPDOAOBO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x261C120", Offset = "0x261B520", VA = "0x18261C120")]
		internal void HHKPCMDLJJB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x261C070", Offset = "0x261B470", VA = "0x18261C070")]
		internal bool DDPCCCCEFMJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x261BFC0", Offset = "0x261B3C0", VA = "0x18261BFC0")]
		internal void ABAJBBEJAEO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x261C2D0", Offset = "0x261B6D0", VA = "0x18261C2D0")]
		internal bool JIPNNJIONDE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x261C220", Offset = "0x261B620", VA = "0x18261C220")]
		internal void JHMCAJCMPEA(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly LKJBNOFKNGL DNEPPKLGBFA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x261CC80", Offset = "0x261C080", VA = "0x18261CC80")]
	private static LAAPMGPPMJD KDKAKGIOABO(AEHPAJILBPF LLNLMEMOHHF)
	{
		return default(LAAPMGPPMJD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x261C380", Offset = "0x261B780", VA = "0x18261C380")]
	private static LKJBNOFKNGL IECAPJLAAOD()
	{
		return default(LKJBNOFKNGL);
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
