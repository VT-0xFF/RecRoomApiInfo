using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CMIBPMILMGB
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CNEJAJMDNCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JJLLFFCPCMI logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8AF6E0", Offset = "0x8AEAE0", VA = "0x1808AF6E0")]
		public CNEJAJMDNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x21CBD00", Offset = "0x21CB100", VA = "0x1821CBD00")]
		internal bool MCHNDOKMDKC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x21CBE00", Offset = "0x21CB200", VA = "0x1821CBE00")]
		internal void PIIFGJFIFEL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x21CBD50", Offset = "0x21CB150", VA = "0x1821CBD50")]
		internal bool MJAIIKNBDGM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x21CBBA0", Offset = "0x21CAFA0", VA = "0x1821CBBA0")]
		internal void HGKKFIJGNCA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x21CBC50", Offset = "0x21CB050", VA = "0x1821CBC50")]
		internal bool HPGLOLODFNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x21CBAF0", Offset = "0x21CAEF0", VA = "0x1821CBAF0")]
		internal void EJKKOAPNBPA(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IGFMIHENANL GJPJBBHLIHD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x21CADC0", Offset = "0x21CA1C0", VA = "0x1821CADC0")]
	private static GKLJAAGFCCM GELNCPMIGGI(JJLLFFCPCMI PMLGFLJEGIL)
	{
		return default(GKLJAAGFCCM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x21CB0E0", Offset = "0x21CA4E0", VA = "0x1821CB0E0")]
	private static IGFMIHENANL OACLLCNGFPC()
	{
		return default(IGFMIHENANL);
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
