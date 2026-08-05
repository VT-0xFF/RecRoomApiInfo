using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NNMMNONFICJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AGKKAOMGBLK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MFJGOFHJODI logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAA49D0", Offset = "0xAA2FD0", VA = "0x180AA49D0")]
		public AGKKAOMGBLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D4E0", Offset = "0x2A5BAE0", VA = "0x182A5D4E0")]
		internal bool JCNPHHCAKIK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D2D0", Offset = "0x2A5B8D0", VA = "0x182A5D2D0")]
		internal void CLKLLBEGELH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D5E0", Offset = "0x2A5BBE0", VA = "0x182A5D5E0")]
		internal bool JPLELGACEJB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D380", Offset = "0x2A5B980", VA = "0x182A5D380")]
		internal void DLEJLKOFOMK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D430", Offset = "0x2A5BA30", VA = "0x182A5D430")]
		internal bool FPONOEANHKN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A5D530", Offset = "0x2A5BB30", VA = "0x182A5D530")]
		internal void JNMODDBMPIL(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KNKDMCGHFAE DOBPPELCKJD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D690", Offset = "0x2A5BC90", VA = "0x182A5D690")]
	private static JKOPPOLJOEJ DOIHPLELPPM(MFJGOFHJODI GPLLAFPDBLP)
	{
		return default(JKOPPOLJOEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A5D9C0", Offset = "0x2A5BFC0", VA = "0x182A5D9C0")]
	private static KNKDMCGHFAE IDBNLOAMHIN()
	{
		return default(KNKDMCGHFAE);
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
