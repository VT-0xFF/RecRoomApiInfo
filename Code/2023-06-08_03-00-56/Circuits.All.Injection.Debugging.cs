using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class CJMKHMOJMFF
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class OJKMDGONOID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AHGNOKHGMIH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7F1FD0", Offset = "0x7F0DD0", VA = "0x1807F1FD0")]
		public OJKMDGONOID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x191CF80", Offset = "0x191BD80", VA = "0x18191CF80")]
		internal bool AEAEJAFAOMH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x191D200", Offset = "0x191C000", VA = "0x18191D200")]
		internal void NABMBGMNCJI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x191D090", Offset = "0x191BE90", VA = "0x18191D090")]
		internal bool IPBFNIHFKED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x191CFE0", Offset = "0x191BDE0", VA = "0x18191CFE0")]
		internal void EJFNEPENFBE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x191D2B0", Offset = "0x191C0B0", VA = "0x18191D2B0")]
		internal bool PLBHDIENLLF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x191D150", Offset = "0x191BF50", VA = "0x18191D150")]
		internal void MJBENHMKDNI(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly ENAHCFHKDDH LNABDBHCENK;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x191CB20", Offset = "0x191B920", VA = "0x18191CB20")]
	private static FNCMOHGMAEG HAAKDEFLBBO(AHGNOKHGMIH HPFHHEGOOLF)
	{
		return default(FNCMOHGMAEG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x191C4B0", Offset = "0x191B2B0", VA = "0x18191C4B0")]
	private static ENAHCFHKDDH FMFBOPDPABF()
	{
		return default(ENAHCFHKDDH);
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
