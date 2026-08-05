using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HLCJIBOCLMO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NCJFMJMOGOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public BBMBLGJIAIE logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public NCJFMJMOGOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1EE02A0", Offset = "0x1EDEAA0", VA = "0x181EE02A0")]
		internal bool OFFCGGAJNIN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1EE0140", Offset = "0x1EDE940", VA = "0x181EE0140")]
		internal void LNEKFMPNGLF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1EDFF30", Offset = "0x1EDE730", VA = "0x181EDFF30")]
		internal bool BOPHNGKGDFF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1EE01F0", Offset = "0x1EDE9F0", VA = "0x181EE01F0")]
		internal void MIADPCOKANI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1EE0090", Offset = "0x1EDE890", VA = "0x181EE0090")]
		internal bool KHOOKHGCKPO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1EDFFE0", Offset = "0x1EDE7E0", VA = "0x181EDFFE0")]
		internal void GDFDKPFIHFJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FLPGDJAADHM DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1EDF220", Offset = "0x1EDDA20", VA = "0x181EDF220")]
	private static MDAGCJDHKLK EPLAMACFGGN(BBMBLGJIAIE CCCCABGDEBH)
	{
		return default(MDAGCJDHKLK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1EDF550", Offset = "0x1EDDD50", VA = "0x181EDF550")]
	private static FLPGDJAADHM LDPFBLPIAID()
	{
		return default(FLPGDJAADHM);
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
