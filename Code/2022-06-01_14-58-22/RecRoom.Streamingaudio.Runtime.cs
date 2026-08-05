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
public interface ALPKAMPIMIF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PJMAKJMIBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BJCCGKKOGFD> GDBCEAECLED();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BJCCGKKOGFD
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string MLDJHAFDNCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FCNHKLGMFKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IEDEDOLJKGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LKGDOFMIPEN IFODNHHLFLD(Action<ArraySegment<float>> JJBCELLHKLO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JOCCNIJHCDN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LKGDOFMIPEN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MNDKDACPMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x631210", Offset = "0x62FC10", VA = "0x180631210")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x736C30", Offset = "0x735630", VA = "0x180736C30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HNKJJEFKOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xA9C150", Offset = "0xA9AB50", VA = "0x180A9C150")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBC1570", Offset = "0xBBFF70", VA = "0x180BC1570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1929AE0", Offset = "0x19284E0", VA = "0x181929AE0")]
	public LKGDOFMIPEN(int CFMAAGHIEOE, int FDPGFALHHAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CIHFDNDOAMI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ALPKAMPIMIF AALEIOCINKD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PJMAKJMIBBN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1929560", Offset = "0x1927F60", VA = "0x181929560")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x19295D0", Offset = "0x1927FD0", VA = "0x1819295D0")]
	static CIHFDNDOAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1929470", Offset = "0x1927E70", VA = "0x181929470")]
	public static IReadOnlyList<BJCCGKKOGFD> GDBCEAECLED()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PICKMACBIBL : ALPKAMPIMIF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FEAMPFHNFFM : BJCCGKKOGFD
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OADJIPJOMCC
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
			[Cpp2IlInjected.Address(RVA = "0x560000", Offset = "0x55EA00", VA = "0x180560000")]
			public OADJIPJOMCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1929AF0", Offset = "0x19284F0", VA = "0x181929AF0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HNLMKPBBELH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EDHKNHDBNHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BJGHOMEALAH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string MLDJHAFDNCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1929A70", Offset = "0x1928470", VA = "0x181929A70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FCNHKLGMFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x697420", Offset = "0x695E20", VA = "0x180697420", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x92F010", Offset = "0x92DA10", VA = "0x18092F010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IEDEDOLJKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5ED5E0", Offset = "0x5EBFE0", VA = "0x1805ED5E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1929680", Offset = "0x1928080", VA = "0x181929680", Slot = "7")]
		public LKGDOFMIPEN IFODNHHLFLD(Action<ArraySegment<float>> JJBCELLHKLO)
		{
			return default(LKGDOFMIPEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x19296B0", Offset = "0x19280B0", VA = "0x1819296B0")]
		private LKGDOFMIPEN IFODNHHLFLD(int CFMAAGHIEOE, int ONIAHCDGBLF, int FDPGFALHHAM, Action<ArraySegment<float>> JJBCELLHKLO)
		{
			return default(LKGDOFMIPEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x19299F0", Offset = "0x19283F0", VA = "0x1819299F0", Slot = "8")]
		public void JOCCNIJHCDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1929A90", Offset = "0x1928490", VA = "0x181929A90")]
		public FEAMPFHNFFM(MMDevice HNLMKPBBELH, bool DBMDPLGAKNH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FEAMPFHNFFM> HNBKCCGKMEB;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PJMAKJMIBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x588CA0", Offset = "0x5876A0", VA = "0x180588CA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1929C70", Offset = "0x1928670", VA = "0x181929C70", Slot = "5")]
	public IReadOnlyList<BJCCGKKOGFD> GDBCEAECLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1929F10", Offset = "0x1928910", VA = "0x181929F10")]
	public PICKMACBIBL()
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
