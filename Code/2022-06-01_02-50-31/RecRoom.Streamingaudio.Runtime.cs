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
		[Cpp2IlInjected.Address(RVA = "0x6043F0", Offset = "0x602DF0", VA = "0x1806043F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EAB80", Offset = "0x6E9580", VA = "0x1806EAB80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HNKJJEFKOMP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x960AE0", Offset = "0x95F4E0", VA = "0x180960AE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA6C290", Offset = "0xA6AC90", VA = "0x180A6C290")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4D83120", Offset = "0x4D81B20", VA = "0x184D83120")]
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
		[Cpp2IlInjected.Address(RVA = "0x4D82BA0", Offset = "0x4D815A0", VA = "0x184D82BA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4D82C10", Offset = "0x4D81610", VA = "0x184D82C10")]
	static CIHFDNDOAMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4D82AB0", Offset = "0x4D814B0", VA = "0x184D82AB0")]
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
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DA00", VA = "0x18054F000")]
			public OADJIPJOMCC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4D83130", Offset = "0x4D81B30", VA = "0x184D83130")]
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
			[Cpp2IlInjected.Address(RVA = "0x4D830B0", Offset = "0x4D81AB0", VA = "0x184D830B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FCNHKLGMFKK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x649680", Offset = "0x648080", VA = "0x180649680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x834870", Offset = "0x833270", VA = "0x180834870")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IEDEDOLJKGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x774270", Offset = "0x772C70", VA = "0x180774270", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4D82CC0", Offset = "0x4D816C0", VA = "0x184D82CC0", Slot = "7")]
		public LKGDOFMIPEN IFODNHHLFLD(Action<ArraySegment<float>> JJBCELLHKLO)
		{
			return default(LKGDOFMIPEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4D82CF0", Offset = "0x4D816F0", VA = "0x184D82CF0")]
		private LKGDOFMIPEN IFODNHHLFLD(int CFMAAGHIEOE, int ONIAHCDGBLF, int FDPGFALHHAM, Action<ArraySegment<float>> JJBCELLHKLO)
		{
			return default(LKGDOFMIPEN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4D83030", Offset = "0x4D81A30", VA = "0x184D83030", Slot = "8")]
		public void JOCCNIJHCDN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4D830D0", Offset = "0x4D81AD0", VA = "0x184D830D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5766A0", VA = "0x180577CA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4D832B0", Offset = "0x4D81CB0", VA = "0x184D832B0", Slot = "5")]
	public IReadOnlyList<BJCCGKKOGFD> GDBCEAECLED()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4D83550", Offset = "0x4D81F50", VA = "0x184D83550")]
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
