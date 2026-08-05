using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class JOCGACOJCCC
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HMLCBCLAIGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public IFMAOBOCIBO logFlags;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public HMLCBCLAIGF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x1E680E0", Offset = "0x1E672E0", VA = "0x181E680E0")]
		internal bool NPLLPFNKBDJ()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E67EC0", Offset = "0x1E670C0", VA = "0x181E67EC0")]
		internal void EHHKECDOGAL(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1E67F70", Offset = "0x1E67170", VA = "0x181E67F70")]
		internal bool HLEKJKNOJFD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x1E68030", Offset = "0x1E67230", VA = "0x181E68030")]
		internal void KILHJOGAKPE(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1E67E00", Offset = "0x1E67000", VA = "0x181E67E00")]
		internal bool ANPECGONLPG()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1E67D50", Offset = "0x1E66F50", VA = "0x181E67D50")]
		internal void AAFEPLEMDPL(string message)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public static readonly EHFFDJCJDCL LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1E689E0", Offset = "0x1E67BE0", VA = "0x181E689E0")]
	private static EHMBFJJMDKE OBOGEGAGIEJ(IFMAOBOCIBO LEGMGFABCPI)
	{
		return default(EHMBFJJMDKE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1E68130", Offset = "0x1E67330", VA = "0x181E68130")]
	private static EHFFDJCJDCL DHEDIDBKHCA()
	{
		return default(EHFFDJCJDCL);
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
