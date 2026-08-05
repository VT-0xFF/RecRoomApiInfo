using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class AOOAFBEODID
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GHJGFKJEMFD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IJGKALGHODN logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
		public GHJGFKJEMFD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F955E0", Offset = "0x1F949E0", VA = "0x181F955E0")]
		internal bool IJPCNOFBJNI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F95480", Offset = "0x1F94880", VA = "0x181F95480")]
		internal void APFDFJMKHEE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F95630", Offset = "0x1F94A30", VA = "0x181F95630")]
		internal bool IPAJIKBLJEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F95530", Offset = "0x1F94930", VA = "0x181F95530")]
		internal void GGMOAEEPKIF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F957A0", Offset = "0x1F94BA0", VA = "0x181F957A0")]
		internal bool NLALMMLOPEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F956F0", Offset = "0x1F94AF0", VA = "0x181F956F0")]
		internal void KIPMPMBABJD(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GMNJACBHNOM CLHFPJDPLGI;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F94FD0", Offset = "0x1F943D0", VA = "0x181F94FD0")]
	private static ELEGJCKPBKB IHHDCGOCFEO(IJGKALGHODN JGPAJODLILA)
	{
		return default(ELEGJCKPBKB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F94720", Offset = "0x1F93B20", VA = "0x181F94720")]
	private static GMNJACBHNOM FMJDGCCNPAE()
	{
		return default(GMNJACBHNOM);
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
