using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MACFLBBFIBP
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class IFNFONOBLOM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GOGFDPHPOKA logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B0ED0", Offset = "0x7AFCD0", VA = "0x1807B0ED0")]
		public IFNFONOBLOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BF10", Offset = "0x1D4AD10", VA = "0x181D4BF10")]
		internal bool IJCAHKGDCEL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BE60", Offset = "0x1D4AC60", VA = "0x181D4BE60")]
		internal void IIHHAOGLAHL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BC30", Offset = "0x1D4AA30", VA = "0x181D4BC30")]
		internal bool EINMOCDECHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BF60", Offset = "0x1D4AD60", VA = "0x181D4BF60")]
		internal void KNCFHBDHPHE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BCF0", Offset = "0x1D4AAF0", VA = "0x181D4BCF0")]
		internal bool FANEAMKODEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D4BDB0", Offset = "0x1D4ABB0", VA = "0x181D4BDB0")]
		internal void HFOGKELHCPN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MECJLELGLMG AHFNEPHAKHC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C010", Offset = "0x1D4AE10", VA = "0x181D4C010")]
	private static AGLINAPBIGO MLIHJMEBPEH(GOGFDPHPOKA OHFFEFBMLCP)
	{
		return default(AGLINAPBIGO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D4C350", Offset = "0x1D4B150", VA = "0x181D4C350")]
	private static MECJLELGLMG NHDJJFMEOEO()
	{
		return default(MECJLELGLMG);
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
