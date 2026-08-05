using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using CSCore;
using CSCore.CoreAudioAPI;
using CSCore.SoundIn;
using CSCore.Streams;
using Cpp2IlInjected;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BHLBCOFEILH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NFLOEONLEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HGMFNKBHOFD> NMBGEGFNCMF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HGMFNKBHOFD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DDMJIJIMJLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JLCLJEGMEDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HPGEJCNEGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NJJNBMHBMAM BNAKLCIPMOI(Action<ArraySegment<float>> IJCKFHFIADK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CGMAAAIMJON();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NJJNBMHBMAM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MGNNPLKNEHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99D850", Offset = "0x99BE50", VA = "0x18099D850")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x10AD620", Offset = "0x10ABC20", VA = "0x1810AD620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JDDDBJJPCJA
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2BBB1F0", Offset = "0x2BB97F0", VA = "0x182BBB1F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x67C36C0", Offset = "0x67C1CC0", VA = "0x1867C36C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7559100", Offset = "0x7557700", VA = "0x187559100")]
	public NJJNBMHBMAM(int EFCJBGBKNBH, int MEEBADFJJMC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AFMOICKCMMK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BHLBCOFEILH DGAEKIFLAPH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NFLOEONLEKD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7F87DA0", Offset = "0x7F863A0", VA = "0x187F87DA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7F87E20", Offset = "0x7F86420", VA = "0x187F87E20")]
	static AFMOICKCMMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7F87CB0", Offset = "0x7F862B0", VA = "0x187F87CB0")]
	public static IReadOnlyList<HGMFNKBHOFD> NMBGEGFNCMF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LBOFIPKIBMC : BHLBCOFEILH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BFHADJDMCGJ : HGMFNKBHOFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IBCMMJPOEMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000A")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000B")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400000C")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9607B0", Offset = "0x95EDB0", VA = "0x1809607B0")]
			public IBCMMJPOEMP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7F883F0", Offset = "0x7F869F0", VA = "0x187F883F0")]
			internal void JFONAJJCCGJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DKLNJKBPHAL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JPBKMINDIKD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EFICFPHKBJN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DDMJIJIMJLE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7F88380", Offset = "0x7F86980", VA = "0x187F88380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JLCLJEGMEDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC9DDE0", Offset = "0xC9C3E0", VA = "0x180C9DDE0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC9DCD0", Offset = "0xC9C2D0", VA = "0x180C9DCD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HPGEJCNEGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC22B80", Offset = "0xC21180", VA = "0x180C22B80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7F87F10", Offset = "0x7F86510", VA = "0x187F87F10", Slot = "7")]
		public NJJNBMHBMAM BNAKLCIPMOI(Action<ArraySegment<float>> IJCKFHFIADK)
		{
			return default(NJJNBMHBMAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7F87F40", Offset = "0x7F86540", VA = "0x187F87F40")]
		private NJJNBMHBMAM BNAKLCIPMOI(int EFCJBGBKNBH, int AFBNKIHDDLD, int MEEBADFJJMC, Action<ArraySegment<float>> IJCKFHFIADK)
		{
			return default(NJJNBMHBMAM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7F88300", Offset = "0x7F86900", VA = "0x187F88300", Slot = "8")]
		public void CGMAAAIMJON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7F883A0", Offset = "0x7F869A0", VA = "0x187F883A0")]
		public BFHADJDMCGJ(MMDevice DKLNJKBPHAL, bool JOAGKDBNICI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<BFHADJDMCGJ> NEDHGNFLEAA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NFLOEONLEKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x96C540", Offset = "0x96AB40", VA = "0x18096C540", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7F88570", Offset = "0x7F86B70", VA = "0x187F88570", Slot = "5")]
	public IReadOnlyList<HGMFNKBHOFD> NMBGEGFNCMF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7F88890", Offset = "0x7F86E90", VA = "0x187F88890")]
	public LBOFIPKIBMC()
	{
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
