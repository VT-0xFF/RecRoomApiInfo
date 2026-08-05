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
public interface IPNIDAIMCPB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AFPIDPCJHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<MMEGGLJIKAF> FDIEOPDGFKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface MMEGGLJIKAF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HIJLGCGJAGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool PAKGMAIKMGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IAHAOEMPLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DEALJIMGCDL DGFCMOJJPMH(Action<ArraySegment<float>> MKGMOFPDGOO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KJJBKABNGCA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DEALJIMGCDL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int EAKGEHOEPJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7C6330", Offset = "0x7C4B30", VA = "0x1807C6330")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85ECB0", Offset = "0x85D4B0", VA = "0x18085ECB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EMCNAMFOIJO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6310", Offset = "0x7C4B10", VA = "0x1807C6310")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x838560", Offset = "0x836D60", VA = "0x180838560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B16FB0", Offset = "0x4B157B0", VA = "0x184B16FB0")]
	public DEALJIMGCDL(int IDIOBNOKLCP, int FEDIFKHODLP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NPMBFHDMFEO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static IPNIDAIMCPB CINMGCFDKGO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AFPIDPCJHDN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4B178B0", Offset = "0x4B160B0", VA = "0x184B178B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B17A10", Offset = "0x4B16210", VA = "0x184B17A10")]
	static NPMBFHDMFEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B17920", Offset = "0x4B16120", VA = "0x184B17920")]
	public static IReadOnlyList<MMEGGLJIKAF> FDIEOPDGFKJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KHLLIPPLNKK : IPNIDAIMCPB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NMAFALCKNON : MMEGGLJIKAF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LEPMALKOIHM
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
			[Cpp2IlInjected.Address(RVA = "0x523AB0", Offset = "0x5222B0", VA = "0x180523AB0")]
			public LEPMALKOIHM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4B172D0", Offset = "0x4B15AD0", VA = "0x184B172D0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice MCBELALIOKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DLIENJOGEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource GKIKOGOPKGL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HIJLGCGJAGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4B17840", Offset = "0x4B16040", VA = "0x184B17840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool PAKGMAIKMGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5A2990", Offset = "0x5A1190", VA = "0x1805A2990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6B6790", Offset = "0x6B4F90", VA = "0x1806B6790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IAHAOEMPLHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x63A2C0", Offset = "0x638AC0", VA = "0x18063A2C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4B17790", Offset = "0x4B15F90", VA = "0x184B17790", Slot = "7")]
		public DEALJIMGCDL DGFCMOJJPMH(Action<ArraySegment<float>> MKGMOFPDGOO)
		{
			return default(DEALJIMGCDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B17450", Offset = "0x4B15C50", VA = "0x184B17450")]
		private DEALJIMGCDL DGFCMOJJPMH(int IDIOBNOKLCP, int BLFBPABEJOC, int FEDIFKHODLP, Action<ArraySegment<float>> MKGMOFPDGOO)
		{
			return default(DEALJIMGCDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B177C0", Offset = "0x4B15FC0", VA = "0x184B177C0", Slot = "8")]
		public void KJJBKABNGCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B17860", Offset = "0x4B16060", VA = "0x184B17860")]
		public NMAFALCKNON(MMDevice MCBELALIOKO, bool LMDLNMANLBM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NMAFALCKNON> DKNKPAMBMJD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AFPIDPCJHDN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x521FE0", Offset = "0x5207E0", VA = "0x180521FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B16FC0", Offset = "0x4B157C0", VA = "0x184B16FC0", Slot = "5")]
	public IReadOnlyList<MMEGGLJIKAF> FDIEOPDGFKJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B17260", Offset = "0x4B15A60", VA = "0x184B17260")]
	public KHLLIPPLNKK()
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
