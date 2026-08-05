using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class PMJGOLCJBFG
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class PJBCHAGNMMN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public MNJJCMIAPGO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x76A320", Offset = "0x768B20", VA = "0x18076A320")]
		public PJBCHAGNMMN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A290", Offset = "0x1C08A90", VA = "0x181C0A290")]
		internal bool HFHJHDENBNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A120", Offset = "0x1C08920", VA = "0x181C0A120")]
		internal void EDEHGPJBCKL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A1D0", Offset = "0x1C089D0", VA = "0x181C0A1D0")]
		internal bool GBGGCLPMKLH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A070", Offset = "0x1C08870", VA = "0x181C0A070")]
		internal void BEGAOGHKCBG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A2E0", Offset = "0x1C08AE0", VA = "0x181C0A2E0")]
		internal bool IABNLJLINDN()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C0A3A0", Offset = "0x1C08BA0", VA = "0x181C0A3A0")]
		internal void JAOBBBDIFIO(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly MBLDGGNOFHG LNAOMADBHGP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A450", Offset = "0x1C08C50", VA = "0x181C0A450")]
	private static MHLICHMDAOB DLMOGJJNPAP(MNJJCMIAPGO CLBOMIAMGMO)
	{
		return default(MHLICHMDAOB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C0A790", Offset = "0x1C08F90", VA = "0x181C0A790")]
	private static MBLDGGNOFHG MGOJPFDILOA()
	{
		return default(MBLDGGNOFHG);
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
