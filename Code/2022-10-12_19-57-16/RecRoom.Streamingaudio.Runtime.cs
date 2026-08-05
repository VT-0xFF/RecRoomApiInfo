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
		[Cpp2IlInjected.Address(RVA = "0x6FBE20", Offset = "0x6FAE20", VA = "0x1806FBE20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6FBD90", Offset = "0x6FAD90", VA = "0x1806FBD90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KJJAPILMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A3600", Offset = "0x8A2600", VA = "0x1808A3600")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE9D080", Offset = "0xE9C080", VA = "0x180E9D080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D970", Offset = "0x5E3C970", VA = "0x185E3D970")]
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
		[Cpp2IlInjected.Address(RVA = "0x5E3D330", Offset = "0x5E3C330", VA = "0x185E3D330")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D3B0", Offset = "0x5E3C3B0", VA = "0x185E3D3B0")]
	static BHHDJKNLCFO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D230", Offset = "0x5E3C230", VA = "0x185E3D230")]
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
			[Cpp2IlInjected.Address(RVA = "0x64BB30", Offset = "0x64AB30", VA = "0x18064BB30")]
			public DAFBGGHFPJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x5E3D480", Offset = "0x5E3C480", VA = "0x185E3D480")]
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
			[Cpp2IlInjected.Address(RVA = "0x5E3D1C0", Offset = "0x5E3C1C0", VA = "0x185E3D1C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MKNNBHLIDDL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x755B40", Offset = "0x754B40", VA = "0x180755B40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x704170", Offset = "0x703170", VA = "0x180704170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PKKBJLEACIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x68BC60", Offset = "0x68AC60", VA = "0x18068BC60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CDF0", Offset = "0x5E3BDF0", VA = "0x185E3CDF0", Slot = "7")]
		public GFCDKELAMAB NONICMACGJH(Action<ArraySegment<float>> FNAODFKKBJA)
		{
			return default(GFCDKELAMAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CE20", Offset = "0x5E3BE20", VA = "0x185E3CE20")]
		private GFCDKELAMAB NONICMACGJH(int GEJONKEHDFO, int DBEFFMIPBML, int JPAAIJPKFJL, Action<ArraySegment<float>> FNAODFKKBJA)
		{
			return default(GFCDKELAMAB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5E3CD70", Offset = "0x5E3BD70", VA = "0x185E3CD70", Slot = "8")]
		public void IAAPEGACDOK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x5E3D1E0", Offset = "0x5E3C1E0", VA = "0x185E3D1E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x66B020", Offset = "0x66A020", VA = "0x18066B020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D610", Offset = "0x5E3C610", VA = "0x185E3D610", Slot = "5")]
	public IReadOnlyList<BBGAALFHKKH> ADMEOIIEGHN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x5E3D8F0", Offset = "0x5E3C8F0", VA = "0x185E3D8F0")]
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
