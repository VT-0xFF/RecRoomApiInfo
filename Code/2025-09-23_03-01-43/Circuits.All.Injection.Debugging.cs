using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HGOLFPKOACC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class LKACHBBPNAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public ELLGHJMHOJG logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAACE80", Offset = "0xAAB480", VA = "0x180AACE80")]
		public LKACHBBPNAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8E60", Offset = "0x2AC7460", VA = "0x182AC8E60")]
		internal bool FEMCCDJCGFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8C50", Offset = "0x2AC7250", VA = "0x182AC8C50")]
		internal void CEBKEKDFNEP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8DB0", Offset = "0x2AC73B0", VA = "0x182AC8DB0")]
		internal bool FEFLGCJKNIB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8EB0", Offset = "0x2AC74B0", VA = "0x182AC8EB0")]
		internal void MNHLGOCOIFJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8D00", Offset = "0x2AC7300", VA = "0x182AC8D00")]
		internal bool EBDAGACFNIC()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2AC8F60", Offset = "0x2AC7560", VA = "0x182AC8F60")]
		internal void POJLKPGMPFN(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KKDGFGPIEDD EHBCEBDHHPE;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2AC7EC0", Offset = "0x2AC64C0", VA = "0x182AC7EC0")]
	private static LCOECJGAHHI ELMGEAPCGBI(ELLGHJMHOJG CODGLKEIFPE)
	{
		return default(LCOECJGAHHI);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2AC81F0", Offset = "0x2AC67F0", VA = "0x182AC81F0")]
	private static KKDGFGPIEDD IMKLEDMDING()
	{
		return default(KKDGFGPIEDD);
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
