using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BGFOFMCEMJM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class EOBOFLLDOHD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public ANDMNHBOFDI logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		public EOBOFLLDOHD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x22CE780", Offset = "0x22CDB80", VA = "0x1822CE780")]
		internal bool GLBOGJLAGEM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x22CE620", Offset = "0x22CDA20", VA = "0x1822CE620")]
		internal void AGCHKKFALJD(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x22CE6D0", Offset = "0x22CDAD0", VA = "0x1822CE6D0")]
		internal bool BFJGOCJMFFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x22CE570", Offset = "0x22CD970", VA = "0x1822CE570")]
		internal void AAJAJMEKFAG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x22CE880", Offset = "0x22CDC80", VA = "0x1822CE880")]
		internal bool IMPKFPIBCOF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22CE7D0", Offset = "0x22CDBD0", VA = "0x1822CE7D0")]
		internal void HFIIKKKADIJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GFHANDICMFD ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x22CE100", Offset = "0x22CD500", VA = "0x1822CE100")]
	private static DOCLOKBDNIJ LBMIMOKNJEG(ANDMNHBOFDI PFLNNLCIDME)
	{
		return default(DOCLOKBDNIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x22CD840", Offset = "0x22CCC40", VA = "0x1822CD840")]
	private static GFHANDICMFD HFOEKBDEILH()
	{
		return default(GFHANDICMFD);
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
