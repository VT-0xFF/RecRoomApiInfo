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
		[Cpp2IlInjected.Address(RVA = "0x7FD9C0", Offset = "0x7FC5C0", VA = "0x1807FD9C0")]
		public NPHMKMHNMGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5390", Offset = "0x6FD3F90", VA = "0x186FD5390")]
		internal bool HMIIFDNMBDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6FD53F0", Offset = "0x6FD3FF0", VA = "0x186FD53F0")]
		internal void PEFHDMODFFJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5160", Offset = "0x6FD3D60", VA = "0x186FD5160")]
		internal bool FJFJDDMGFJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6FD5220", Offset = "0x6FD3E20", VA = "0x186FD5220")]
		internal void GOIGIJPLJIH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FD52D0", Offset = "0x6FD3ED0", VA = "0x186FD52D0")]
		internal bool GONNJOMHMOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6FD50B0", Offset = "0x6FD3CB0", VA = "0x186FD50B0")]
		internal void CGPALEHBCCN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CAOOCJPLPJH EABDDJEADPB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6FD54A0", Offset = "0x6FD40A0", VA = "0x186FD54A0")]
	private static KLJIFOKILDG AAMDLOBHMFJ(HDDCAHBLLEN ODPKAHOAPPJ)
	{
		return default(KLJIFOKILDG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6FD5790", Offset = "0x6FD4390", VA = "0x186FD5790")]
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
