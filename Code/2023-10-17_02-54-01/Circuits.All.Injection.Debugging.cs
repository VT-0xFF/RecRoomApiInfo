using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NEJFNLMOJKA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class NOOCPOCBJBO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public ABLOGMIMFGM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76E470", Offset = "0x76CC70", VA = "0x18076E470")]
		public NOOCPOCBJBO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C02200", Offset = "0x1C00A00", VA = "0x181C02200")]
		internal bool FANIOLMACFE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C02310", Offset = "0x1C00B10", VA = "0x181C02310")]
		internal void IJOMMBLKPII(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C02250", Offset = "0x1C00A50", VA = "0x181C02250")]
		internal bool GDAPAJFANMI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C02150", Offset = "0x1C00950", VA = "0x181C02150")]
		internal void DFHGHOPNPEA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C023C0", Offset = "0x1C00BC0", VA = "0x181C023C0")]
		internal bool NNIDIIINPEB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C020A0", Offset = "0x1C008A0", VA = "0x181C020A0")]
		internal void CMFCLPBBFOE(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NDFAOMIBIEH FLMPJFHFLHM;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C01340", Offset = "0x1BFFB40", VA = "0x181C01340")]
	private static LFIBKPIGLOG ALFELCBFMCE(ABLOGMIMFGM ODOCLNNBLCN)
	{
		return default(LFIBKPIGLOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C01680", Offset = "0x1BFFE80", VA = "0x181C01680")]
	private static NDFAOMIBIEH EJNNPAPLCHC()
	{
		return default(NDFAOMIBIEH);
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
