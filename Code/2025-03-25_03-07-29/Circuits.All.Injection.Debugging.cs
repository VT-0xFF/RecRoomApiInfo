using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class NKBBKIGBIHN
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GDFPNGKGFNE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public DGNCBDKCJKH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x996740", Offset = "0x995B40", VA = "0x180996740")]
		public GDFPNGKGFNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x25EC700", Offset = "0x25EBB00", VA = "0x1825EC700")]
		internal bool LHDIMFCLDNL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x25EC750", Offset = "0x25EBB50", VA = "0x1825EC750")]
		internal void ODGPKFABMEO(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x25EC5A0", Offset = "0x25EB9A0", VA = "0x1825EC5A0")]
		internal bool GGNAFKAIEGE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x25EC440", Offset = "0x25EB840", VA = "0x1825EC440")]
		internal void CJDHHLBGAMM(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x25EC650", Offset = "0x25EBA50", VA = "0x1825EC650")]
		internal bool IJAHOGHFOFB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x25EC4F0", Offset = "0x25EB8F0", VA = "0x1825EC4F0")]
		internal void COMAGJHNJIE(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KGKAGNIPHHN DMADMDPHOOL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x25ED0C0", Offset = "0x25EC4C0", VA = "0x1825ED0C0")]
	private static EJLACCJGNKG JCFFKPJNADJ(DGNCBDKCJKH FBLFPBHMGID)
	{
		return default(EJLACCJGNKG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x25EC800", Offset = "0x25EBC00", VA = "0x1825EC800")]
	private static KGKAGNIPHHN ICDBLCIBGJD()
	{
		return default(KGKAGNIPHHN);
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
