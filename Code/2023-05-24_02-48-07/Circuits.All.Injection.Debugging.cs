using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PAJNIPJLHLM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NPHMKMHNMGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public HDDCAHBLLEN logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7FA9C0", Offset = "0x7F95C0", VA = "0x1807FA9C0")]
		public NPHMKMHNMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x138BFA0", Offset = "0x138ABA0", VA = "0x18138BFA0")]
		internal bool HMIIFDNMBDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x138C000", Offset = "0x138AC00", VA = "0x18138C000")]
		internal void PEFHDMODFFJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x138BD70", Offset = "0x138A970", VA = "0x18138BD70")]
		internal bool FJFJDDMGFJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x138BE30", Offset = "0x138AA30", VA = "0x18138BE30")]
		internal void GOIGIJPLJIH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x138BEE0", Offset = "0x138AAE0", VA = "0x18138BEE0")]
		internal bool GONNJOMHMOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x138BCC0", Offset = "0x138A8C0", VA = "0x18138BCC0")]
		internal void CGPALEHBCCN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CAOOCJPLPJH EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x138C0B0", Offset = "0x138ACB0", VA = "0x18138C0B0")]
	private static KLJIFOKILDG AAMDLOBHMFJ(HDDCAHBLLEN ODPKAHOAPPJ)
	{
		return default(KLJIFOKILDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x138C3A0", Offset = "0x138AFA0", VA = "0x18138C3A0")]
	private static CAOOCJPLPJH CGBKGOFGHNP()
	{
		return default(CAOOCJPLPJH);
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
