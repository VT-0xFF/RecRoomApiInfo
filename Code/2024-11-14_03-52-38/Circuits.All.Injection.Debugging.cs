using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GIDOJHACLAD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OHNABEPKGKH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PGEIHLGFGAL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8A9820", Offset = "0x8A8C20", VA = "0x1808A9820")]
		public OHNABEPKGKH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2219E40", Offset = "0x2219240", VA = "0x182219E40")]
		internal bool FPNKNBKILPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2219D90", Offset = "0x2219190", VA = "0x182219D90")]
		internal void EKOMDOGLOFA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2219E90", Offset = "0x2219290", VA = "0x182219E90")]
		internal bool KJFJPAEFMJK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x221A0A0", Offset = "0x22194A0", VA = "0x18221A0A0")]
		internal void PINCJGAIABC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2219F40", Offset = "0x2219340", VA = "0x182219F40")]
		internal bool LBMLDGKPJFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2219FF0", Offset = "0x22193F0", VA = "0x182219FF0")]
		internal void MFDIMKBCAFE(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ANHLKDBFCFB GHDNHBBFDEB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2219900", Offset = "0x2218D00", VA = "0x182219900")]
	private static IOMAAPBMLCO ELDHNCHPMOA(PGEIHLGFGAL HKNEPOEOALI)
	{
		return default(IOMAAPBMLCO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2219000", Offset = "0x2218400", VA = "0x182219000")]
	private static ANHLKDBFCFB DKAPOJOAMIJ()
	{
		return default(ANHLKDBFCFB);
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
