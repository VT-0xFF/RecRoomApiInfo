using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HPKFBBGFIPH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class IACALDAELGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public LLFKNJNFIGE logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
		public IACALDAELGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x289CB80", Offset = "0x289B780", VA = "0x18289CB80")]
		internal bool DONHBIIFBHP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x289CBD0", Offset = "0x289B7D0", VA = "0x18289CBD0")]
		internal void HDDJIJABGFI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x289CC80", Offset = "0x289B880", VA = "0x18289CC80")]
		internal bool LKNHCKKGOJH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x289CD30", Offset = "0x289B930", VA = "0x18289CD30")]
		internal void PAIFNBPCAND(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x289CAD0", Offset = "0x289B6D0", VA = "0x18289CAD0")]
		internal bool BMFGIMCOIHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x289CDE0", Offset = "0x289B9E0", VA = "0x18289CDE0")]
		internal void PJOJAHMOGHM(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly OADMBBILKFN LBPNLDGACAA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x289BDA0", Offset = "0x289A9A0", VA = "0x18289BDA0")]
	private static NAMBDIICIDA JHBABIHMCLG(LLFKNJNFIGE FBJDCENFLPO)
	{
		return default(NAMBDIICIDA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x289C0C0", Offset = "0x289ACC0", VA = "0x18289C0C0")]
	private static OADMBBILKFN LLIJAGNEDAJ()
	{
		return default(OADMBBILKFN);
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
