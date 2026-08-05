using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class HENNCNPOLOK
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class MMILIAJCBOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public AGHGMAKBJLO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public MMILIAJCBOH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1F37030", Offset = "0x1F35C30", VA = "0x181F37030")]
		internal bool DOBFNAHHFMB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1F372A0", Offset = "0x1F35EA0", VA = "0x181F372A0")]
		internal void KBGLNDCHBEB(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F37080", Offset = "0x1F35C80", VA = "0x181F37080")]
		internal bool DPLFKACEKAG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1F37140", Offset = "0x1F35D40", VA = "0x181F37140")]
		internal void FHDGHLNHIBI(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1F37350", Offset = "0x1F35F50", VA = "0x181F37350")]
		internal bool NAFNPLNFADH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1F371F0", Offset = "0x1F35DF0", VA = "0x181F371F0")]
		internal void HCGPALODFIJ(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly KPNGCEJHMLI GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1F36B80", Offset = "0x1F35780", VA = "0x181F36B80")]
	private static ABBAOPDFBBD NLLMNBBPLEK(AGHGMAKBJLO BILBCDECAPD)
	{
		return default(ABBAOPDFBBD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1F362D0", Offset = "0x1F34ED0", VA = "0x181F362D0")]
	private static KPNGCEJHMLI MCOIDBBDBON()
	{
		return default(KPNGCEJHMLI);
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
