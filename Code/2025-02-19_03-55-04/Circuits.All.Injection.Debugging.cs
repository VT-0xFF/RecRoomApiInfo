using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BIABNEOGEGI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class BHFPFBAKOBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PDJEPPMAHDP logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x960580", Offset = "0x95F180", VA = "0x180960580")]
		public BHFPFBAKOBI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x24DBD60", Offset = "0x24DA960", VA = "0x1824DBD60")]
		internal bool FGIAIKFBOKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x24DBB50", Offset = "0x24DA750", VA = "0x1824DBB50")]
		internal void BIOPJKELJKK(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24DBDB0", Offset = "0x24DA9B0", VA = "0x1824DBDB0")]
		internal bool GGCDJJDCONA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x24DBCB0", Offset = "0x24DA8B0", VA = "0x1824DBCB0")]
		internal void FAKBNFJIBNI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x24DBE60", Offset = "0x24DAA60", VA = "0x1824DBE60")]
		internal bool HLNPMBBEAHJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x24DBC00", Offset = "0x24DA800", VA = "0x1824DBC00")]
		internal void BMFLLLCJJIF(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly DNNEHDMODOA FFLNCJPMHOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x24DC7D0", Offset = "0x24DB3D0", VA = "0x1824DC7D0")]
	private static KLGOFGIBFIA OALOMIBJKAC(PDJEPPMAHDP DNMNKAOFACJ)
	{
		return default(KLGOFGIBFIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x24DBF10", Offset = "0x24DAB10", VA = "0x1824DBF10")]
	private static DNNEHDMODOA ACOCADLEHMC()
	{
		return default(DNNEHDMODOA);
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
