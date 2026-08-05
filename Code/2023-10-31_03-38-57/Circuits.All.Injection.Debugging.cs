using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MHJGEMKOBHI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GAOKIIBHDEO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DBGIFPEAPEB logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76C4B0", Offset = "0x76B8B0", VA = "0x18076C4B0")]
		public GAOKIIBHDEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C350B0", Offset = "0x1C344B0", VA = "0x181C350B0")]
		internal bool OOHMEEBOLAB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C34F40", Offset = "0x1C34340", VA = "0x181C34F40")]
		internal void MLNBLFIKGOP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C34FF0", Offset = "0x1C343F0", VA = "0x181C34FF0")]
		internal bool OLBKJIHILBN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C34DD0", Offset = "0x1C341D0", VA = "0x181C34DD0")]
		internal void HHFDLNOMJOM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C34E80", Offset = "0x1C34280", VA = "0x181C34E80")]
		internal bool JCPICECJJDP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C34D20", Offset = "0x1C34120", VA = "0x181C34D20")]
		internal void DJMCFPJGNOM(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IIEKODIDFNH PFONNHJIIHO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C359B0", Offset = "0x1C34DB0", VA = "0x181C359B0")]
	private static GOAJHHEFIJP OPKOCIMHNAK(DBGIFPEAPEB JMHCCEGBKFI)
	{
		return default(GOAJHHEFIJP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C35100", Offset = "0x1C34500", VA = "0x181C35100")]
	private static IIEKODIDFNH MPEIIJNEIIE()
	{
		return default(IIEKODIDFNH);
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
