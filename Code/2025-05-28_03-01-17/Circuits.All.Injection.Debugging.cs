using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class LCAPGKCLECK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OKIALCLDCNH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HBKLMMOCKFE logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA112F0", Offset = "0xA100F0", VA = "0x180A112F0")]
		public OKIALCLDCNH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27A3660", Offset = "0x27A2460", VA = "0x1827A3660")]
		internal bool KCKPLPLLJPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27A35B0", Offset = "0x27A23B0", VA = "0x1827A35B0")]
		internal void HMAJADDKALH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x27A32F0", Offset = "0x27A20F0", VA = "0x1827A32F0")]
		internal bool ABNNOKACIHM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27A3450", Offset = "0x27A2250", VA = "0x1827A3450")]
		internal void DCAKBDLHEAH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x27A3500", Offset = "0x27A2300", VA = "0x1827A3500")]
		internal bool EILAKCMLKPD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27A33A0", Offset = "0x27A21A0", VA = "0x1827A33A0")]
		internal void AEKPBGGHIIH(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly BFFJAMKDLAJ ICOFMPPJNFC;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x27A2E60", Offset = "0x27A1C60", VA = "0x1827A2E60")]
	private static CGNBGOCAAPG KBCJIMNCAJC(HBKLMMOCKFE OHFLKOCBNNO)
	{
		return default(CGNBGOCAAPG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27A2560", Offset = "0x27A1360", VA = "0x1827A2560")]
	private static BFFJAMKDLAJ GJBHPENFANG()
	{
		return default(BFFJAMKDLAJ);
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
