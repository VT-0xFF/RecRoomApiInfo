using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HCCKHLHMODJ
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class AEHMLLFHFON
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public OCKFDPEAIDI logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7B40D0", Offset = "0x7B32D0", VA = "0x1807B40D0")]
		public AEHMLLFHFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9940", Offset = "0x1DC8B40", VA = "0x181DC9940")]
		internal bool CNGKGKHMOOM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9890", Offset = "0x1DC8A90", VA = "0x181DC9890")]
		internal void CDAEABGNFDE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9990", Offset = "0x1DC8B90", VA = "0x181DC9990")]
		internal bool EONALNNHDDM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9AF0", Offset = "0x1DC8CF0", VA = "0x181DC9AF0")]
		internal void KBHLAMEOLID(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9BA0", Offset = "0x1DC8DA0", VA = "0x181DC9BA0")]
		internal bool PIGOPCIBPOD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1DC9A40", Offset = "0x1DC8C40", VA = "0x181DC9A40")]
		internal void IHOKGCKJHOE(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EGPPIJMOAAH EELHBDDPCDG;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1DCA4C0", Offset = "0x1DC96C0", VA = "0x181DCA4C0")]
	private static LIBJGILCPOJ DBANBNNLAFC(OCKFDPEAIDI GOPJIGPDCMD)
	{
		return default(LIBJGILCPOJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1DC9C50", Offset = "0x1DC8E50", VA = "0x181DC9C50")]
	private static EGPPIJMOAAH ADBCMKPFJHP()
	{
		return default(EGPPIJMOAAH);
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
