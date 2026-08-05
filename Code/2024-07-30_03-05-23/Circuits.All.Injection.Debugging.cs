using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NADOOOMBIHI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class DPDICIPNICB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MMPIADBJIHO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x86C4B0", Offset = "0x86AAB0", VA = "0x18086C4B0")]
		public DPDICIPNICB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E690", Offset = "0x1F9CC90", VA = "0x181F9E690")]
		internal bool IGMEKODDIAD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E6E0", Offset = "0x1F9CCE0", VA = "0x181F9E6E0")]
		internal void KHAJLPHIDGO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E520", Offset = "0x1F9CB20", VA = "0x181F9E520")]
		internal bool EEKJMFDKIPA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E5E0", Offset = "0x1F9CBE0", VA = "0x181F9E5E0")]
		internal void IDEBHGJAINE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E790", Offset = "0x1F9CD90", VA = "0x181F9E790")]
		internal bool PNOKGNEAOEH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F9E470", Offset = "0x1F9CA70", VA = "0x181F9E470")]
		internal void BGAMMGDHNDC(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FBKAHDELPEJ CFNNMJAMDBB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F9F100", Offset = "0x1F9D700", VA = "0x181F9F100")]
	private static DPEKPLFEBPK GAPIHIDCJBN(MMPIADBJIHO COBIHLMBOLK)
	{
		return default(DPEKPLFEBPK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F9E850", Offset = "0x1F9CE50", VA = "0x181F9E850")]
	private static FBKAHDELPEJ FFBKMBJKELG()
	{
		return default(FBKAHDELPEJ);
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
