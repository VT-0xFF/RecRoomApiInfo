using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BNNJDKAHNMH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class KJMNCHIJMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GODOOEICKML logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7A2570", Offset = "0x7A1970", VA = "0x1807A2570")]
		public KJMNCHIJMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D0AFA0", Offset = "0x1D0A3A0", VA = "0x181D0AFA0")]
		internal bool DFCONDEFIMA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B210", Offset = "0x1D0A610", VA = "0x181D0B210")]
		internal void OGKAHPIPNJM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B150", Offset = "0x1D0A550", VA = "0x181D0B150")]
		internal bool NPBLMAMNIME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D0B0A0", Offset = "0x1D0A4A0", VA = "0x181D0B0A0")]
		internal void MFKDGFGGLMD(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D0AEE0", Offset = "0x1D0A2E0", VA = "0x181D0AEE0")]
		internal bool BGJBFKLNIAE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D0AFF0", Offset = "0x1D0A3F0", VA = "0x181D0AFF0")]
		internal void GBPOFKACPKB(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MJIBBANGACN GHDJCOLHINO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A180", Offset = "0x1D09580", VA = "0x181D0A180")]
	private static BFDHGHDNPEF CBDCANJIJAM(GODOOEICKML ENFACDFKECK)
	{
		return default(BFDHGHDNPEF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D0A4C0", Offset = "0x1D098C0", VA = "0x181D0A4C0")]
	private static MJIBBANGACN MBILNLCIBLI()
	{
		return default(MJIBBANGACN);
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
