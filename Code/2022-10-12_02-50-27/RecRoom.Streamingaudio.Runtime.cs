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
public interface HDLMOHLFNNH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AICNMEIEKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BBGAALFHKKH> ADMEOIIEGHN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BBGAALFHKKH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string AJBFLFGGFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MKNNBHLIDDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PKKBJLEACIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	GFCDKELAMAB NONICMACGJH(Action<ArraySegment<float>> FNAODFKKBJA);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAAPEGACDOK();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct GFCDKELAMAB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EGCEDDNNMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x79B630", Offset = "0x799E30", VA = "0x18079B630")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79CEA0", Offset = "0x79B6A0", VA = "0x18079CEA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KJJAPILMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7F76F0", Offset = "0x7F5EF0", VA = "0x1807F76F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x7F7700", Offset = "0x7F5F00", VA = "0x1807F7700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2E50", Offset = "0x1EC1650", VA = "0x181EC2E50")]
	public GFCDKELAMAB(int GEJONKEHDFO, int JPAAIJPKFJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BHHDJKNLCFO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HDLMOHLFNNH BCOHENJJPJH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AICNMEIEKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2810", Offset = "0x1EC1010", VA = "0x181EC2810")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2890", Offset = "0x1EC1090", VA = "0x181EC2890")]
	static BHHDJKNLCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2710", Offset = "0x1EC0F10", VA = "0x181EC2710")]
	public static IReadOnlyList<BBGAALFHKKH> ADMEOIIEGHN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EBEIMELDIMC : HDLMOHLFNNH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ABGPKILJIFI : BBGAALFHKKH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DAFBGGHFPJN
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
			[Cpp2IlInjected.Address(RVA = "0x64A350", Offset = "0x648B50", VA = "0x18064A350")]
			public DAFBGGHFPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1EC2960", Offset = "0x1EC1160", VA = "0x181EC2960")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NDHOFLGMPJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FENANKLFHEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource IBHIGOMNPHK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string AJBFLFGGFJL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1EC26A0", Offset = "0x1EC0EA0", VA = "0x181EC26A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MKNNBHLIDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6E3880", Offset = "0x6E2080", VA = "0x1806E3880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6E38B0", Offset = "0x6E20B0", VA = "0x1806E38B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PKKBJLEACIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9B6B20", Offset = "0x9B5320", VA = "0x1809B6B20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1EC22D0", Offset = "0x1EC0AD0", VA = "0x181EC22D0", Slot = "7")]
		public GFCDKELAMAB NONICMACGJH(Action<ArraySegment<float>> FNAODFKKBJA)
		{
			return default(GFCDKELAMAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2300", Offset = "0x1EC0B00", VA = "0x181EC2300")]
		private GFCDKELAMAB NONICMACGJH(int GEJONKEHDFO, int DBEFFMIPBML, int JPAAIJPKFJL, Action<ArraySegment<float>> FNAODFKKBJA)
		{
			return default(GFCDKELAMAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1EC2250", Offset = "0x1EC0A50", VA = "0x181EC2250", Slot = "8")]
		public void IAAPEGACDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1EC26C0", Offset = "0x1EC0EC0", VA = "0x181EC26C0")]
		public ABGPKILJIFI(MMDevice NDHOFLGMPJC, bool MMOOIEENGGE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ABGPKILJIFI> BKFBOEMHCOG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AICNMEIEKJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x76F270", Offset = "0x76DA70", VA = "0x18076F270", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2AF0", Offset = "0x1EC12F0", VA = "0x181EC2AF0", Slot = "5")]
	public IReadOnlyList<BBGAALFHKKH> ADMEOIIEGHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2DD0", Offset = "0x1EC15D0", VA = "0x181EC2DD0")]
	public EBEIMELDIMC()
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
