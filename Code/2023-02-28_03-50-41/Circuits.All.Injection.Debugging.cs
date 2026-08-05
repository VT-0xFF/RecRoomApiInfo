using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class FHHBMGMMDFI
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HGJAEBKCMFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PLAMFHPFEGH logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
		public HGJAEBKCMFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xE9E2C0", Offset = "0xE9CCC0", VA = "0x180E9E2C0")]
		internal bool <MakeLogDelegates>b__0()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xE9E320", Offset = "0xE9CD20", VA = "0x180E9E320")]
		internal void <MakeLogDelegates>b__1(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xE9E3D0", Offset = "0xE9CDD0", VA = "0x180E9E3D0")]
		internal bool <MakeLogDelegates>b__2()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xE9E490", Offset = "0xE9CE90", VA = "0x180E9E490")]
		internal void <MakeLogDelegates>b__3(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xE9E540", Offset = "0xE9CF40", VA = "0x180E9E540")]
		internal bool <MakeLogDelegates>b__4()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE9E600", Offset = "0xE9D000", VA = "0x180E9E600")]
		internal void <MakeLogDelegates>b__5(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KLJMAHGKDJO FMAHKEPPCOJ;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xE9DE50", Offset = "0xE9C850", VA = "0x180E9DE50")]
	private static GFMOHCLGCJM ILODKNNLFNI(PLAMFHPFEGH PMIMLGGAICF)
	{
		return default(GFMOHCLGCJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0xE9D730", Offset = "0xE9C130", VA = "0x180E9D730")]
	private static KLJMAHGKDJO CPAECMGBMEE()
	{
		return default(KLJMAHGKDJO);
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
