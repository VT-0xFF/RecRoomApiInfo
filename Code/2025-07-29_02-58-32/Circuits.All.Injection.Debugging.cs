using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class MEEADIHNDPA
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class CGACGKJOICP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AMEBIDIOCLJ logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA8D8C0", Offset = "0xA8C2C0", VA = "0x180A8D8C0")]
		public CGACGKJOICP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x29D46D0", Offset = "0x29D30D0", VA = "0x1829D46D0")]
		internal bool CJNDNHHHDBM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x29D4620", Offset = "0x29D3020", VA = "0x1829D4620")]
		internal void BDDBIHDCFNC(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x29D4880", Offset = "0x29D3280", VA = "0x1829D4880")]
		internal bool HKFNGNLKJHK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x29D4930", Offset = "0x29D3330", VA = "0x1829D4930")]
		internal void KMFFOFMFMFH(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x29D47D0", Offset = "0x29D31D0", VA = "0x1829D47D0")]
		internal bool EAKHPNAEOLL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x29D4720", Offset = "0x29D3120", VA = "0x1829D4720")]
		internal void DADFFNJPEKN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly IOKDJOPFKHM NDAIDGNOFDA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x29D49E0", Offset = "0x29D33E0", VA = "0x1829D49E0")]
	private static ICNNFMDNOFB PMLCHDLIFMN(AMEBIDIOCLJ MMHMOMBKKOA)
	{
		return default(ICNNFMDNOFB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x29D4D10", Offset = "0x29D3710", VA = "0x1829D4D10")]
	private static IOKDJOPFKHM PNMJIMJDHCB()
	{
		return default(IOKDJOPFKHM);
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
