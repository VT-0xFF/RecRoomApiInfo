using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JKPBPEKOKFO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class FEDIFDODBGE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public FPKONPAFMLP logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x75E150", Offset = "0x75CF50", VA = "0x18075E150")]
		public FEDIFDODBGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C35C90", Offset = "0x1C34A90", VA = "0x181C35C90")]
		internal bool ADLKEPEMGBP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C35D90", Offset = "0x1C34B90", VA = "0x181C35D90")]
		internal void CNEPCDOGPJO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C35E40", Offset = "0x1C34C40", VA = "0x181C35E40")]
		internal bool LOCBAICDFHD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C35F00", Offset = "0x1C34D00", VA = "0x181C35F00")]
		internal void MGNKNPIKEJO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C35FB0", Offset = "0x1C34DB0", VA = "0x181C35FB0")]
		internal bool NFFHMCLKNJP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C35CE0", Offset = "0x1C34AE0", VA = "0x181C35CE0")]
		internal void BEDDCKFFNBP(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly FDENCOOAONN IFFGEIGBEEG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C36920", Offset = "0x1C35720", VA = "0x181C36920")]
	private static KBBDNOBKBGA NHCBLAGEMJG(FPKONPAFMLP DNFDHIJOCBH)
	{
		return default(KBBDNOBKBGA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C36070", Offset = "0x1C34E70", VA = "0x181C36070")]
	private static FDENCOOAONN MKOPBBMLFKN()
	{
		return default(FDENCOOAONN);
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
