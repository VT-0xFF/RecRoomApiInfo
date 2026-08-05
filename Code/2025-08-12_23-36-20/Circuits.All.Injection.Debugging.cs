using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class GCNALKBGNEO
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GMDELFHABFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LGHPLMCMDCB logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA9B480", Offset = "0xA9A280", VA = "0x180A9B480")]
		public GMDELFHABFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DF30", Offset = "0x2A3CD30", VA = "0x182A3DF30")]
		internal bool GIJAPCMDPMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DDD0", Offset = "0x2A3CBD0", VA = "0x182A3DDD0")]
		internal void DBIFDIEMGEC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DE80", Offset = "0x2A3CC80", VA = "0x182A3DE80")]
		internal bool FGFDDKBNBDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DD20", Offset = "0x2A3CB20", VA = "0x182A3DD20")]
		internal void AFDECOAPAFO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2A3DF80", Offset = "0x2A3CD80", VA = "0x182A3DF80")]
		internal bool OIGBNFNIKFN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2A3E030", Offset = "0x2A3CE30", VA = "0x182A3E030")]
		internal void PEMHFIONAMM(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IPCEFHMNADN MOIOIMEFPHA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2A3CFF0", Offset = "0x2A3BDF0", VA = "0x182A3CFF0")]
	private static ONFEIKMNNCB BDDIOILBLHK(LGHPLMCMDCB FAGNLJMPEEC)
	{
		return default(ONFEIKMNNCB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2A3D310", Offset = "0x2A3C110", VA = "0x182A3D310")]
	private static IPCEFHMNADN OOAILBBOCAM()
	{
		return default(IPCEFHMNADN);
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
