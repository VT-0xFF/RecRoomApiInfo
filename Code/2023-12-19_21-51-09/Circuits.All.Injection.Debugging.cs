using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JLCNNKHADPH
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HMJPHMNJIJB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public PHIOOLOPDKA logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7731E0", Offset = "0x771DE0", VA = "0x1807731E0")]
		public HMJPHMNJIJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C9BA50", Offset = "0x1C9A650", VA = "0x181C9BA50")]
		internal bool LHEHFNKEFED()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C9B8E0", Offset = "0x1C9A4E0", VA = "0x181C9B8E0")]
		internal void EEKKDPKGOKP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C9BAA0", Offset = "0x1C9A6A0", VA = "0x181C9BAA0")]
		internal bool OMPEILIEGEP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C9B830", Offset = "0x1C9A430", VA = "0x181C9B830")]
		internal void AMPODEMLGGG(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C9B990", Offset = "0x1C9A590", VA = "0x181C9B990")]
		internal bool IIMCCOKKNMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9BB60", Offset = "0x1C9A760", VA = "0x181C9BB60")]
		internal void POAILKDFFPJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly OEPHOALKHOL IDAIJJLMAFB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C4C0", Offset = "0x1C9B0C0", VA = "0x181C9C4C0")]
	private static KJILBECOEKE JGFDNDIIPMK(PHIOOLOPDKA EKMFKEDMBMJ)
	{
		return default(KJILBECOEKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C9BC10", Offset = "0x1C9A810", VA = "0x181C9BC10")]
	private static OEPHOALKHOL DBENOIKBPCM()
	{
		return default(OEPHOALKHOL);
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
