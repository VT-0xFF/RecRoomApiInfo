using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PGALFGBLOKC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MJIJDPNMCPI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PNAMPHHGBEO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F10", Offset = "0x7C5110", VA = "0x1807C5F10")]
		public MJIJDPNMCPI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D822E0", Offset = "0x1D814E0", VA = "0x181D822E0")]
		internal bool CPLFJHCNNDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D82610", Offset = "0x1D81810", VA = "0x181D82610")]
		internal void NNPADBBFLCA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D82490", Offset = "0x1D81690", VA = "0x181D82490")]
		internal bool MDGPLNPHEDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D823E0", Offset = "0x1D815E0", VA = "0x181D823E0")]
		internal void LJCILDGILHB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D82550", Offset = "0x1D81750", VA = "0x181D82550")]
		internal bool MJOEGPLNENM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D82330", Offset = "0x1D81530", VA = "0x181D82330")]
		internal void HPJOCCPFNJJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ILFCPDPKOIE MJANIPKLNPJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D82F70", Offset = "0x1D82170", VA = "0x181D82F70")]
	private static FDOGGMPFLCF PANJNGLOILD(PNAMPHHGBEO EPNIELENNJB)
	{
		return default(FDOGGMPFLCF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D826C0", Offset = "0x1D818C0", VA = "0x181D826C0")]
	private static ILFCPDPKOIE FDGDBEOEPDE()
	{
		return default(ILFCPDPKOIE);
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
