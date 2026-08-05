using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class BFBLDJJPBDD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class KHGCIOOEMDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public EAOPBFIIMOF logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
		public KHGCIOOEMDC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C190", Offset = "0x1C9B590", VA = "0x181C9C190")]
		internal bool NBOLLAEPDKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C9BF80", Offset = "0x1C9B380", VA = "0x181C9BF80")]
		internal void ECHJDCEAKDA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C9BEC0", Offset = "0x1C9B2C0", VA = "0x181C9BEC0")]
		internal bool CCKJGFGANGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C0E0", Offset = "0x1C9B4E0", VA = "0x181C9C0E0")]
		internal void HICDJFACPMP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C1E0", Offset = "0x1C9B5E0", VA = "0x181C9C1E0")]
		internal bool PCEKELBMPDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C030", Offset = "0x1C9B430", VA = "0x181C9C030")]
		internal void FBDFMJJPGJJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EEGHDAIELAE NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C9B160", Offset = "0x1C9A560", VA = "0x181C9B160")]
	private static PHNOPFPKEJK LEHNBNPIGKM(EAOPBFIIMOF ADOKOCAGAKH)
	{
		return default(PHNOPFPKEJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C9B4A0", Offset = "0x1C9A8A0", VA = "0x181C9B4A0")]
	private static EEGHDAIELAE PEJINDFCFAN()
	{
		return default(EEGHDAIELAE);
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
