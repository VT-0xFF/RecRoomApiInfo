using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CGBELHFLMMH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BGDNGKMAGFO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public CHPALBDOOEK logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public BGDNGKMAGFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2864780", Offset = "0x2863180", VA = "0x182864780")]
		internal bool FFDPAEGIJEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2864620", Offset = "0x2863020", VA = "0x182864620")]
		internal void AAJMGDGBNHK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28647D0", Offset = "0x28631D0", VA = "0x1828647D0")]
		internal bool KKLBNOIDCBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2864930", Offset = "0x2863330", VA = "0x182864930")]
		internal void OBFJPKDHOMC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28646D0", Offset = "0x28630D0", VA = "0x1828646D0")]
		internal bool ALMHGLOKGAK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2864880", Offset = "0x2863280", VA = "0x182864880")]
		internal void LDCCLAPNAJG(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly OAINEBBAGGD FDCAMNOGINK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28652A0", Offset = "0x2863CA0", VA = "0x1828652A0")]
	private static APAOLKMJPMG EJGFOEICJMJ(CHPALBDOOEK KCFPIAEHDMH)
	{
		return default(APAOLKMJPMG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28649E0", Offset = "0x28633E0", VA = "0x1828649E0")]
	private static OAINEBBAGGD AJLJNPDEANH()
	{
		return default(OAINEBBAGGD);
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
