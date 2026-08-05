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
public interface GBDEIPJOAPL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GMBMIJAJIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DLOMAOINMNH> DOLKFIBPOAE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DLOMAOINMNH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LFMNMFIFPDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JOPGHOCAFEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MMLEEBHGHEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OCMGMFPENFB DLBABMENOBG(Action<ArraySegment<float>> FNJEPDKDNHM);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CNAFPOKPMAE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OCMGMFPENFB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BHFBIHGNOHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5C1BA0", Offset = "0x5C0BA0", VA = "0x1805C1BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x685A90", Offset = "0x684A90", VA = "0x180685A90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NCILAAMEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x934320", Offset = "0x933320", VA = "0x180934320")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA13430", Offset = "0xA12430", VA = "0x180A13430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x49F2B20", Offset = "0x49F1B20", VA = "0x1849F2B20")]
	public OCMGMFPENFB(int JEJGMKNGIMJ, int MEAFIDKGAGB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OBPIGGHFJKA
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GBDEIPJOAPL PKOLFCCMBBP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GMBMIJAJIKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x49F2A00", Offset = "0x49F1A00", VA = "0x1849F2A00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x49F2A70", Offset = "0x49F1A70", VA = "0x1849F2A70")]
	static OBPIGGHFJKA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x49F2910", Offset = "0x49F1910", VA = "0x1849F2910")]
	public static IReadOnlyList<DLOMAOINMNH> DOLKFIBPOAE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EFMHGBOLHLJ : GBDEIPJOAPL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DFBDJPMCMDL : DLOMAOINMNH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IJKHCKPJDCI
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
			[Cpp2IlInjected.Address(RVA = "0x50D000", Offset = "0x50C000", VA = "0x18050D000")]
			public IJKHCKPJDCI()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x49F2790", Offset = "0x49F1790", VA = "0x1849F2790")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice INBLKLKGDNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ALHBHFBIACJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ICIMCBLDPHF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LFMNMFIFPDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x49F2020", Offset = "0x49F1020", VA = "0x1849F2020", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JOPGHOCAFEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x606E40", Offset = "0x605E40", VA = "0x180606E40", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7DF5A0", Offset = "0x7DE5A0", VA = "0x1807DF5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MMLEEBHGHEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x730DE0", Offset = "0x72FDE0", VA = "0x180730DE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x49F20C0", Offset = "0x49F10C0", VA = "0x1849F20C0", Slot = "7")]
		public OCMGMFPENFB DLBABMENOBG(Action<ArraySegment<float>> FNJEPDKDNHM)
		{
			return default(OCMGMFPENFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x49F20F0", Offset = "0x49F10F0", VA = "0x1849F20F0")]
		private OCMGMFPENFB DLBABMENOBG(int JEJGMKNGIMJ, int EMDEBIFBHJJ, int MEAFIDKGAGB, Action<ArraySegment<float>> FNJEPDKDNHM)
		{
			return default(OCMGMFPENFB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x49F2040", Offset = "0x49F1040", VA = "0x1849F2040", Slot = "8")]
		public void CNAFPOKPMAE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x49F2430", Offset = "0x49F1430", VA = "0x1849F2430")]
		public DFBDJPMCMDL(MMDevice INBLKLKGDNB, bool CLPFHOCDMFP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<DFBDJPMCMDL> HGHKPECLGEI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GMBMIJAJIKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5359B0", Offset = "0x5349B0", VA = "0x1805359B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x49F2480", Offset = "0x49F1480", VA = "0x1849F2480", Slot = "5")]
	public IReadOnlyList<DLOMAOINMNH> DOLKFIBPOAE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x49F2720", Offset = "0x49F1720", VA = "0x1849F2720")]
	public EFMHGBOLHLJ()
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
