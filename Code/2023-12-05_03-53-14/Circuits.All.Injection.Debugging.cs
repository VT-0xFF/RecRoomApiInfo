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
		[Cpp2IlInjected.Address(RVA = "0x1C9C380", Offset = "0x1C9B780", VA = "0x181C9C380")]
		internal bool NBOLLAEPDKD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C170", Offset = "0x1C9B570", VA = "0x181C9C170")]
		internal void ECHJDCEAKDA(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C0B0", Offset = "0x1C9B4B0", VA = "0x181C9C0B0")]
		internal bool CCKJGFGANGA()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C2D0", Offset = "0x1C9B6D0", VA = "0x181C9C2D0")]
		internal void HICDJFACPMP(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C3D0", Offset = "0x1C9B7D0", VA = "0x181C9C3D0")]
		internal bool PCEKELBMPDI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9C220", Offset = "0x1C9B620", VA = "0x181C9C220")]
		internal void FBDFMJJPGJJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EEGHDAIELAE NMGLFNHIICP;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C9B350", Offset = "0x1C9A750", VA = "0x181C9B350")]
	private static PHNOPFPKEJK LEHNBNPIGKM(EAOPBFIIMOF ADOKOCAGAKH)
	{
		return default(PHNOPFPKEJK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C9B690", Offset = "0x1C9AA90", VA = "0x181C9B690")]
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
