using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class EGDDMBFCJOG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GCCPLAPLPLM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PJGFAHKMJGL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
		public GCCPLAPLPLM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x16E8F00", Offset = "0x16E8300", VA = "0x1816E8F00")]
		internal bool FAGMMMOCEPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x16E90D0", Offset = "0x16E84D0", VA = "0x1816E90D0")]
		internal void MEPKDNHCOJG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x16E8E40", Offset = "0x16E8240", VA = "0x1816E8E40")]
		internal bool DCFJKOBHOJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x16E9180", Offset = "0x16E8580", VA = "0x1816E9180")]
		internal void NDEAGPKCGOP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x16E8F60", Offset = "0x16E8360", VA = "0x1816E8F60")]
		internal bool FPNKDCAKCFH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x16E9020", Offset = "0x16E8420", VA = "0x1816E9020")]
		internal void KMJINKJMELA(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly BBPJMCFPBHN BGHJOACDLLH;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x16E89E0", Offset = "0x16E7DE0", VA = "0x1816E89E0")]
	private static PPMGOFKHNAI JIGFBIKKBJJ(PJGFAHKMJGL BDIHMMPNNCO)
	{
		return default(PPMGOFKHNAI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x16E8370", Offset = "0x16E7770", VA = "0x1816E8370")]
	private static BBPJMCFPBHN CCFMCKICFFJ()
	{
		return default(BBPJMCFPBHN);
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
