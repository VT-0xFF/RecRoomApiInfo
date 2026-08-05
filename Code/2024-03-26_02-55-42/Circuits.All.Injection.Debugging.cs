using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ONOLBFIBCML
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DBGLKCJPKAH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IIKDMCIPNEF logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C0A30", Offset = "0x7BFE30", VA = "0x1807C0A30")]
		public DBGLKCJPKAH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FD40", Offset = "0x1D9F140", VA = "0x181D9FD40")]
		internal bool PHNEBBLGALO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FA60", Offset = "0x1D9EE60", VA = "0x181D9FA60")]
		internal void HFPOOKLHLJL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FC80", Offset = "0x1D9F080", VA = "0x181D9FC80")]
		internal bool NENIKFDKHKJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FBD0", Offset = "0x1D9EFD0", VA = "0x181D9FBD0")]
		internal void LLMJELILHIN(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D9FB10", Offset = "0x1D9EF10", VA = "0x181D9FB10")]
		internal bool ICPBILECHLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D9F9B0", Offset = "0x1D9EDB0", VA = "0x181D9F9B0")]
		internal void BELGONKGMEF(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GAPNANHGFHD GDCHCCJBKDM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D9FD90", Offset = "0x1D9F190", VA = "0x181D9FD90")]
	private static NNFCNHCPPDH GDCNHLNEHLI(IIKDMCIPNEF HPEAIKHKAFP)
	{
		return default(NNFCNHCPPDH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DA00D0", Offset = "0x1D9F4D0", VA = "0x181DA00D0")]
	private static GAPNANHGFHD GNNODICEDDJ()
	{
		return default(GAPNANHGFHD);
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
