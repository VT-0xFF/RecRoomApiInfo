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
public interface LCGMFFLHNJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMFKEKONIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EBIBBCEOJGF> GFCLIEKALHC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EBIBBCEOJGF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FDGJBBJLPGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DKNGJMDKCDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MICEIBFGLBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LDJNPFLGNAO LNFPOOCDLIB(Action<ArraySegment<float>> HKFANNEFPNB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HMPLCMIPHFN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LDJNPFLGNAO
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MIDEMMNFFJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7DF2B0", Offset = "0x7DE0B0", VA = "0x1807DF2B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x877BF0", Offset = "0x8769F0", VA = "0x180877BF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HBONHKHHLMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7DF290", Offset = "0x7DE090", VA = "0x1807DF290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8514A0", Offset = "0x8502A0", VA = "0x1808514A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2170", Offset = "0x4AE0F70", VA = "0x184AE2170")]
	public LDJNPFLGNAO(int DNLICHMHPAC, int KPODHAMECNC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CIJAGOJLAID
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LCGMFFLHNJP CDGMHILKPAA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NMFKEKONIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4AE1D40", Offset = "0x4AE0B40", VA = "0x184AE1D40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1DB0", Offset = "0x4AE0BB0", VA = "0x184AE1DB0")]
	static CIJAGOJLAID()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1C50", Offset = "0x4AE0A50", VA = "0x184AE1C50")]
	public static IReadOnlyList<EBIBBCEOJGF> GFCLIEKALHC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ICJFGGDNLGI : LCGMFFLHNJP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OPHMADJLHCH : EBIBBCEOJGF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AIFAJBHBAIN
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
			[Cpp2IlInjected.Address(RVA = "0x51EAB0", Offset = "0x51D8B0", VA = "0x18051EAB0")]
			public AIFAJBHBAIN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4AE1AD0", Offset = "0x4AE08D0", VA = "0x184AE1AD0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LGIGDCPONEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture PCNPAEGIENC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HPBNBNMLBGC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FDGJBBJLPGA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4AE2200", Offset = "0x4AE1000", VA = "0x184AE2200", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DKNGJMDKCDO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x59D990", Offset = "0x59C790", VA = "0x18059D990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6B1790", Offset = "0x6B0590", VA = "0x1806B1790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MICEIBFGLBL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6352C0", Offset = "0x6340C0", VA = "0x1806352C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4AE2220", Offset = "0x4AE1020", VA = "0x184AE2220", Slot = "7")]
		public LDJNPFLGNAO LNFPOOCDLIB(Action<ArraySegment<float>> HKFANNEFPNB)
		{
			return default(LDJNPFLGNAO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4AE2250", Offset = "0x4AE1050", VA = "0x184AE2250")]
		private LDJNPFLGNAO LNFPOOCDLIB(int DNLICHMHPAC, int DEGOHOMJMEM, int KPODHAMECNC, Action<ArraySegment<float>> HKFANNEFPNB)
		{
			return default(LDJNPFLGNAO);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4AE2180", Offset = "0x4AE0F80", VA = "0x184AE2180", Slot = "8")]
		public void HMPLCMIPHFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4AE2590", Offset = "0x4AE1390", VA = "0x184AE2590")]
		public OPHMADJLHCH(MMDevice LGIGDCPONEG, bool OOGHOLEEFBK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OPHMADJLHCH> DCBMJGFOIPG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NMFKEKONIMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x51CFE0", Offset = "0x51BDE0", VA = "0x18051CFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4AE1E60", Offset = "0x4AE0C60", VA = "0x184AE1E60", Slot = "5")]
	public IReadOnlyList<EBIBBCEOJGF> GFCLIEKALHC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4AE2100", Offset = "0x4AE0F00", VA = "0x184AE2100")]
	public ICJFGGDNLGI()
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
