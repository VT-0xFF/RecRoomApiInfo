using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LLILMDCILDM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MDMBKFPDNPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public EAJIBKCHNNC logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
		public MDMBKFPDNPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24D7960", Offset = "0x24D6760", VA = "0x1824D7960")]
		internal bool CHMEFMPODJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24D78B0", Offset = "0x24D66B0", VA = "0x1824D78B0")]
		internal void BAAPGCMHEDN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24D7B10", Offset = "0x24D6910", VA = "0x1824D7B10")]
		internal bool KCMACJKNGJE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24D7A60", Offset = "0x24D6860", VA = "0x1824D7A60")]
		internal void JLJDJIFPKEB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24D79B0", Offset = "0x24D67B0", VA = "0x1824D79B0")]
		internal bool DLAEPGEONCH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24D7BC0", Offset = "0x24D69C0", VA = "0x1824D7BC0")]
		internal void PGEHOAKAMGL(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NPBCBDLGHAP GGJCMHODIEM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24D6B20", Offset = "0x24D5920", VA = "0x1824D6B20")]
	private static GCFHHJINGND HOPIBFCNEON(EAJIBKCHNNC HGGECPHADJG)
	{
		return default(GCFHHJINGND);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24D6E50", Offset = "0x24D5C50", VA = "0x1824D6E50")]
	private static NPBCBDLGHAP IKGGBFHLHIA()
	{
		return default(NPBCBDLGHAP);
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
