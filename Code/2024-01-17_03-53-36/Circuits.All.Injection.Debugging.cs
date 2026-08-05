using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ONDAKKKGNHL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class LNLHEAFMIDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KEFAEGNACHO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
		public LNLHEAFMIDL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2870", Offset = "0x1CE1670", VA = "0x181CE2870")]
		internal bool DGKDJHHLIMN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1CE28C0", Offset = "0x1CE16C0", VA = "0x181CE28C0")]
		internal void GHNIMHMDNLB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2970", Offset = "0x1CE1770", VA = "0x181CE2970")]
		internal bool KMMEDPMFPBJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2710", Offset = "0x1CE1510", VA = "0x181CE2710")]
		internal void ANMCHFAKNGG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1CE2A30", Offset = "0x1CE1830", VA = "0x181CE2A30")]
		internal bool OHNNMABBOOI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1CE27C0", Offset = "0x1CE15C0", VA = "0x181CE27C0")]
		internal void CINEJCPGHJM(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MOOLIHDPJHD CEIKCOHBGGB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2AF0", Offset = "0x1CE18F0", VA = "0x181CE2AF0")]
	private static MFBOJDFOGLC FGINBLAPBKJ(KEFAEGNACHO CJNBOOFGMFC)
	{
		return default(MFBOJDFOGLC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1CE2E30", Offset = "0x1CE1C30", VA = "0x181CE2E30")]
	private static MOOLIHDPJHD MINFHIJLNGL()
	{
		return default(MOOLIHDPJHD);
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
