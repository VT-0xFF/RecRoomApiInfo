using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HBECDDMFGAN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GGJAJNFAAND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public GNGEALOEHNM logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public GGJAJNFAAND()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC080", Offset = "0x1DEAE80", VA = "0x181DEC080")]
		internal bool ICHFLGDBHEI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBFD0", Offset = "0x1DEADD0", VA = "0x181DEBFD0")]
		internal void IAPFLGAODIJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBE70", Offset = "0x1DEAC70", VA = "0x181DEBE70")]
		internal bool CJNKFDDDMEJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBF20", Offset = "0x1DEAD20", VA = "0x181DEBF20")]
		internal void CMBFMDDBPJF(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DEBDC0", Offset = "0x1DEABC0", VA = "0x181DEBDC0")]
		internal bool BJKEDEGPJGK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DEC0D0", Offset = "0x1DEAED0", VA = "0x181DEC0D0")]
		internal void LHILIOLDPAL(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly JONIHGFEAGO LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC180", Offset = "0x1DEAF80", VA = "0x181DEC180")]
	private static HDFPOPBANHO FPMLOEHCMFB(GNGEALOEHNM KNIOPJPKAIG)
	{
		return default(HDFPOPBANHO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DEC4B0", Offset = "0x1DEB2B0", VA = "0x181DEC4B0")]
	private static JONIHGFEAGO NLDKIIAFMAP()
	{
		return default(JONIHGFEAGO);
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
