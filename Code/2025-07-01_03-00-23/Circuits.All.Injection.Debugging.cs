using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HLFCJGEGILC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HDGNFLOCBOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KOJMLKHMICP logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public HDGNFLOCBOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x28FACB0", Offset = "0x28F92B0", VA = "0x1828FACB0")]
		internal bool HKDOPAPNMFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x28FAC00", Offset = "0x28F9200", VA = "0x1828FAC00")]
		internal void GJCJLMFBJIC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x28FAB50", Offset = "0x28F9150", VA = "0x1828FAB50")]
		internal bool BLLHIHFBCBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x28FAE60", Offset = "0x28F9460", VA = "0x1828FAE60")]
		internal void OEIMBOHIODA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x28FADB0", Offset = "0x28F93B0", VA = "0x1828FADB0")]
		internal bool KPCLKEOLGCG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x28FAD00", Offset = "0x28F9300", VA = "0x1828FAD00")]
		internal void IGBAGCKOOLK(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CKOHNGLOMDF FNIBPMLJKFE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x28FAF10", Offset = "0x28F9510", VA = "0x1828FAF10")]
	private static IMEPHGPNJIJ IFLKBKNNMNG(KOJMLKHMICP BIENKGKCNGM)
	{
		return default(IMEPHGPNJIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x28FB240", Offset = "0x28F9840", VA = "0x1828FB240")]
	private static CKOHNGLOMDF IGGKDENFBHJ()
	{
		return default(CKOHNGLOMDF);
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
