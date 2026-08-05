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
public interface HMOCDDLCKEI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool FFHJFPNNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<BABJNMMLAOP> NMJDIDOKBDH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface BABJNMMLAOP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PLIMLAHDBOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HPNDLDAOCPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool HMPENJOIKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	PMFIEOIJKLM NMGJGNCFALD(Action<ArraySegment<float>> DMDJELFGCKJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void COOABHEDJBP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct PMFIEOIJKLM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DBEMAKKODLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBB5930", Offset = "0xBB4330", VA = "0x180BB5930")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x13EB010", Offset = "0x13E9A10", VA = "0x1813EB010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BLKEPPOFOPM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2FA2F60", Offset = "0x2FA1960", VA = "0x182FA2F60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6F27F80", Offset = "0x6F26980", VA = "0x186F27F80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7DA7700", Offset = "0x7DA6100", VA = "0x187DA7700")]
	public PMFIEOIJKLM(int NHELEEECFIB, int BMGCDDKKJEH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class FCADJECKADH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HMOCDDLCKEI OIADCONCFNI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool FFHJFPNNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x88881B0", Offset = "0x8886BB0", VA = "0x1888881B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8888310", Offset = "0x8886D10", VA = "0x188888310")]
	static FCADJECKADH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8888220", Offset = "0x8886C20", VA = "0x188888220")]
	public static IReadOnlyList<BABJNMMLAOP> NMJDIDOKBDH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LDIHNGCKFJE : HMOCDDLCKEI
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BOIEDBMPGAC : BABJNMMLAOP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BHHFCCPJCHG
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
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
			public BHHFCCPJCHG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8887B50", Offset = "0x8886550", VA = "0x188887B50")]
			internal void HHBIBLACMCE(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice KFKGLCNNLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FIOBJDJBHPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource EDOEEBHBBNO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PLIMLAHDBOC
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8887D50", Offset = "0x8886750", VA = "0x188887D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HPNDLDAOCPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA6EB70", Offset = "0xA6D570", VA = "0x180A6EB70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA6E7D0", Offset = "0xA6D1D0", VA = "0x180A6E7D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool HMPENJOIKAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE1DD80", Offset = "0xE1C780", VA = "0x180E1DD80", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8887D70", Offset = "0x8886770", VA = "0x188887D70", Slot = "7")]
		public PMFIEOIJKLM NMGJGNCFALD(Action<ArraySegment<float>> DMDJELFGCKJ)
		{
			return default(PMFIEOIJKLM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8887DA0", Offset = "0x88867A0", VA = "0x188887DA0")]
		private PMFIEOIJKLM NMGJGNCFALD(int NHELEEECFIB, int ILEIOIBAEDF, int BMGCDDKKJEH, Action<ArraySegment<float>> DMDJELFGCKJ)
		{
			return default(PMFIEOIJKLM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8887CD0", Offset = "0x88866D0", VA = "0x188887CD0", Slot = "8")]
		public void COOABHEDJBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8888160", Offset = "0x8886B60", VA = "0x188888160")]
		public BOIEDBMPGAC(MMDevice KFKGLCNNLCN, bool MNJOBHLPNEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<BOIEDBMPGAC> IEFLMEKKKBD;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool FFHJFPNNJBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA256B0", Offset = "0xA240B0", VA = "0x180A256B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8888400", Offset = "0x8886E00", VA = "0x188888400", Slot = "5")]
	public IReadOnlyList<BABJNMMLAOP> NMJDIDOKBDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8888710", Offset = "0x8887110", VA = "0x188888710")]
	public LDIHNGCKFJE()
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
