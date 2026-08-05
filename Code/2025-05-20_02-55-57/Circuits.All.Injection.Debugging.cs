using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NPEFKGNMJIC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BPIHHLHDAHF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public JIHHPFPGGDH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BPIHHLHDAHF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x27426A0", Offset = "0x27418A0", VA = "0x1827426A0")]
		internal bool OBPGKEEAFIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x27423E0", Offset = "0x27415E0", VA = "0x1827423E0")]
		internal void FJKOPFFCLMA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2742540", Offset = "0x2741740", VA = "0x182742540")]
		internal bool IPPPONFCCMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x27425F0", Offset = "0x27417F0", VA = "0x1827425F0")]
		internal void KBEAHJKBBCG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2742330", Offset = "0x2741530", VA = "0x182742330")]
		internal bool CPDLEMEIFNO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2742490", Offset = "0x2741690", VA = "0x182742490")]
		internal void INMEKHBHGII(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly CLGHAHCHDOA NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2742FB0", Offset = "0x27421B0", VA = "0x182742FB0")]
	private static ANBCIFAPNOB OFCPBLCNLCG(JIHHPFPGGDH CNKDJBCPCPE)
	{
		return default(ANBCIFAPNOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x27426F0", Offset = "0x27418F0", VA = "0x1827426F0")]
	private static CLGHAHCHDOA IBAEPNNPNIA()
	{
		return default(CLGHAHCHDOA);
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
