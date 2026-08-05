using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class KDEHLNIIGBM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CMNJHCHDPIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JDBIDOOACAJ logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A4800", Offset = "0x7A3C00", VA = "0x1807A4800")]
		public CMNJHCHDPIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BB20", Offset = "0x1D1AF20", VA = "0x181D1BB20")]
		internal bool NLJMFMLKLGB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BB70", Offset = "0x1D1AF70", VA = "0x181D1BB70")]
		internal void OGAOPNKDDHH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B900", Offset = "0x1D1AD00", VA = "0x181D1B900")]
		internal bool CNKACMANBCC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D1BA70", Offset = "0x1D1AE70", VA = "0x181D1BA70")]
		internal void MPHDFIILNKM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B840", Offset = "0x1D1AC40", VA = "0x181D1B840")]
		internal bool BIBIKCFBFLG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D1B9C0", Offset = "0x1D1ADC0", VA = "0x181D1B9C0")]
		internal void LKAKJAKHCOF(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GICNBGJLMEA MEGHANKAOBP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BC20", Offset = "0x1D1B020", VA = "0x181D1BC20")]
	private static CMLABEFMCPO HDKNPGAKKGD(JDBIDOOACAJ DJKHIMLNCJE)
	{
		return default(CMLABEFMCPO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D1BF60", Offset = "0x1D1B360", VA = "0x181D1BF60")]
	private static GICNBGJLMEA ODMKLBPKBKI()
	{
		return default(GICNBGJLMEA);
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
