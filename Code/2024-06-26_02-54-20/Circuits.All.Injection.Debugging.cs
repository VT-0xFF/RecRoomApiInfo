using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CALMCHGPMAL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BKLKFLPCJLI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GOEEOAIPPMA logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BKLKFLPCJLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B9B0", Offset = "0x1F59FB0", VA = "0x181F5B9B0")]
		internal bool IBCHHFIFALA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B620", Offset = "0x1F59C20", VA = "0x181F5B620")]
		internal void APMEDFFBFIG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B6D0", Offset = "0x1F59CD0", VA = "0x181F5B6D0")]
		internal bool BOFBDPLGGPM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B850", Offset = "0x1F59E50", VA = "0x181F5B850")]
		internal void GEALMEEAEOD(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B790", Offset = "0x1F59D90", VA = "0x181F5B790")]
		internal bool FFLLMGGFKEF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F5B900", Offset = "0x1F59F00", VA = "0x181F5B900")]
		internal void GNJCOPAHDKC(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NOLLLLMHKCO IBMHAACFGKI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F5BA00", Offset = "0x1F5A000", VA = "0x181F5BA00")]
	private static LCPBKNBGEPG AGLJOMMELMG(GOEEOAIPPMA AKFBMBJPLAN)
	{
		return default(LCPBKNBGEPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F5BD40", Offset = "0x1F5A340", VA = "0x181F5BD40")]
	private static NOLLLLMHKCO KOCDAFIFPDK()
	{
		return default(NOLLLLMHKCO);
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
