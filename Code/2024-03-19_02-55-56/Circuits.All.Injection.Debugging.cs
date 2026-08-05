using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HDPFBCOLIJE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HLCKKLNLGJM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AHDMNBDNGKC logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7C54F0", Offset = "0x7C44F0", VA = "0x1807C54F0")]
		public HLCKKLNLGJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1D98CF0", Offset = "0x1D97CF0", VA = "0x181D98CF0")]
		internal bool MIKBGIIBBOE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1D98AD0", Offset = "0x1D97AD0", VA = "0x181D98AD0")]
		internal void FKFKNGAPOGJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1D98B80", Offset = "0x1D97B80", VA = "0x181D98B80")]
		internal bool HHEIJDPBPOB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1D98A20", Offset = "0x1D97A20", VA = "0x181D98A20")]
		internal void EAAOEGFFAOJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1D98D40", Offset = "0x1D97D40", VA = "0x181D98D40")]
		internal bool MMHLIHMGCOL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1D98C40", Offset = "0x1D97C40", VA = "0x181D98C40")]
		internal void LPFIOFEEFKL(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly GKNODIMKEMO GDAKEGIGEFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1D97CC0", Offset = "0x1D96CC0", VA = "0x181D97CC0")]
	private static GIMLHPBOLKG ANDIHNBPCCN(AHDMNBDNGKC CCKGNABMKNA)
	{
		return default(GIMLHPBOLKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1D98000", Offset = "0x1D97000", VA = "0x181D98000")]
	private static GKNODIMKEMO OOEBADJMJEM()
	{
		return default(GKNODIMKEMO);
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
