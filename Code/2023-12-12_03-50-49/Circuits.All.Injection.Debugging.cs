using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class ACLDGHFABGM
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class GKCFNIOJPPN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public KPGKPEANGAD logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x77B730", Offset = "0x779F30", VA = "0x18077B730")]
		public GKCFNIOJPPN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D170", Offset = "0x1C9B970", VA = "0x181C9D170")]
		internal bool IDGHJGADKFJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D1C0", Offset = "0x1C9B9C0", VA = "0x181C9D1C0")]
		internal void IPILLJIHJAJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D0B0", Offset = "0x1C9B8B0", VA = "0x181C9D0B0")]
		internal bool FOPKBCEGABE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D320", Offset = "0x1C9BB20", VA = "0x181C9D320")]
		internal void LEALDJKIOIJ(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D3D0", Offset = "0x1C9BBD0", VA = "0x181C9D3D0")]
		internal bool LHOKEMMMFJM()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1C9D270", Offset = "0x1C9BA70", VA = "0x181C9D270")]
		internal void JBFMPIFHCPG(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly NFOFPEGGIKK ODCBNHJKAMO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1C9CC00", Offset = "0x1C9B400", VA = "0x181C9CC00")]
	private static DJNFALAFNKL OODJGDNBMNC(KPGKPEANGAD CPEFINNEPFH)
	{
		return default(DJNFALAFNKL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1C9C350", Offset = "0x1C9AB50", VA = "0x181C9C350")]
	private static NFOFPEGGIKK MACCKOBHLMK()
	{
		return default(NFOFPEGGIKK);
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
