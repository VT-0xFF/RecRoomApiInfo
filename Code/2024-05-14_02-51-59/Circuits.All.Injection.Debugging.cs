using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JGPIOGKNNBO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AAJCOHIFKPO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GJELFAODKNL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7CBB60", Offset = "0x7CA560", VA = "0x1807CBB60")]
		public AAJCOHIFKPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E320D0", Offset = "0x1E30AD0", VA = "0x181E320D0")]
		internal bool EGLDMKDEFHA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E32290", Offset = "0x1E30C90", VA = "0x181E32290")]
		internal void KHJGIJFMIMP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E32340", Offset = "0x1E30D40", VA = "0x181E32340")]
		internal bool NJHDHHBBPCI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E321E0", Offset = "0x1E30BE0", VA = "0x181E321E0")]
		internal void KBPNJLMGKFP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E32120", Offset = "0x1E30B20", VA = "0x181E32120")]
		internal bool JCICKGKCHGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E32400", Offset = "0x1E30E00", VA = "0x181E32400")]
		internal void PAFMOLDLMPO(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly OLBGOILBDMD AINFBDJPIJL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E32D60", Offset = "0x1E31760", VA = "0x181E32D60")]
	private static GMGKGEPILHI FHGDLOGMHOE(GJELFAODKNL AJACGIPKNEP)
	{
		return default(GMGKGEPILHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E324B0", Offset = "0x1E30EB0", VA = "0x181E324B0")]
	private static OLBGOILBDMD DGMBOADJEML()
	{
		return default(OLBGOILBDMD);
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
