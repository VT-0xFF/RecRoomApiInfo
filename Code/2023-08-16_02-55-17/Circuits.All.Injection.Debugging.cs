using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MFAEMKGKLKH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GJJBEJCPHEI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LNKLKDIODGL logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7E6300", Offset = "0x7E5500", VA = "0x1807E6300")]
		public GJJBEJCPHEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DD50", Offset = "0x6F4CF50", VA = "0x186F4DD50")]
		internal bool CEOOFCMDBBH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DE60", Offset = "0x6F4D060", VA = "0x186F4DE60")]
		internal void FDIFGADBPEP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DC80", Offset = "0x6F4CE80", VA = "0x186F4DC80")]
		internal bool APBMOAGPGPB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DDB0", Offset = "0x6F4CFB0", VA = "0x186F4DDB0")]
		internal void DFPOGICKDLD(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DF10", Offset = "0x6F4D110", VA = "0x186F4DF10")]
		internal bool FNGCKGGFBJO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6F4DFE0", Offset = "0x6F4D1E0", VA = "0x186F4DFE0")]
		internal void NMIODICKPMK(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KBIEABHDILD JHOAALADPKE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E090", Offset = "0x6F4D290", VA = "0x186F4E090")]
	private static FAOLDENDMNC IAIHLKHBPNG(LNKLKDIODGL IHCPAJLPIKL)
	{
		return default(FAOLDENDMNC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F4E390", Offset = "0x6F4D590", VA = "0x186F4E390")]
	private static KBIEABHDILD MEIHJBECKAO()
	{
		return default(KBIEABHDILD);
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
