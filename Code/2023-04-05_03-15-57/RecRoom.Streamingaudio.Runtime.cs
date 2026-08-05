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
public interface MGDMNAOPCFP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LGHJHANHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OJOOGHNNINA> MANPKGDPACH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OJOOGHNNINA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ACGAIIDMAKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JMOCDCDBNJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BPKHEFCENIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IDJLGNDEDPK KEFPFOANJJD(Action<ArraySegment<float>> PEPHBHFBJFE);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDEKDKHPOJI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IDJLGNDEDPK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LCLINDDIIGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x790E40", Offset = "0x78FE40", VA = "0x180790E40")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x790DB0", Offset = "0x78FDB0", VA = "0x180790DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OOPCPIBLCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A8550", Offset = "0x8A7550", VA = "0x1808A8550")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE96F30", Offset = "0xE95F30", VA = "0x180E96F30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x66A2210", Offset = "0x66A1210", VA = "0x1866A2210")]
	public IDJLGNDEDPK(int MMHBLDHDAIK, int ADGOCJPBDPK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class GBLOFEHNAPC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MGDMNAOPCFP PKHJCMCBPFF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LGHJHANHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x66A1FC0", Offset = "0x66A0FC0", VA = "0x1866A1FC0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x66A2140", Offset = "0x66A1140", VA = "0x1866A2140")]
	static GBLOFEHNAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x66A2040", Offset = "0x66A1040", VA = "0x1866A2040")]
	public static IReadOnlyList<OJOOGHNNINA> MANPKGDPACH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LDAAEDOKKEK : MGDMNAOPCFP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MOACDDONPBM : OJOOGHNNINA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JLMGBMFIENA
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
			[Cpp2IlInjected.Address(RVA = "0x6E0B30", Offset = "0x6DFB30", VA = "0x1806E0B30")]
			public JLMGBMFIENA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x66A2220", Offset = "0x66A1220", VA = "0x1866A2220")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice INBKJMCMOMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture NEDAPIPGHKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LPMGNMBHNBC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ACGAIIDMAKM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x66A2790", Offset = "0x66A1790", VA = "0x1866A2790", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JMOCDCDBNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7CFFA0", Offset = "0x7CEFA0", VA = "0x1807CFFA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x799190", Offset = "0x798190", VA = "0x180799190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BPKHEFCENIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x720CB0", Offset = "0x71FCB0", VA = "0x180720CB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x66A27B0", Offset = "0x66A17B0", VA = "0x1866A27B0", Slot = "7")]
		public IDJLGNDEDPK KEFPFOANJJD(Action<ArraySegment<float>> PEPHBHFBJFE)
		{
			return default(IDJLGNDEDPK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x66A27E0", Offset = "0x66A17E0", VA = "0x1866A27E0")]
		private IDJLGNDEDPK KEFPFOANJJD(int MMHBLDHDAIK, int BBMIPEDKIHJ, int ADGOCJPBDPK, Action<ArraySegment<float>> PEPHBHFBJFE)
		{
			return default(IDJLGNDEDPK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x66A2710", Offset = "0x66A1710", VA = "0x1866A2710", Slot = "8")]
		public void DDEKDKHPOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x66A2B80", Offset = "0x66A1B80", VA = "0x1866A2B80")]
		public MOACDDONPBM(MMDevice INBKJMCMOMM, bool PFHKEDMPDDG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MOACDDONPBM> GGELFBEAJPC;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LGHJHANHMHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x700020", Offset = "0x6FF020", VA = "0x180700020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x66A23B0", Offset = "0x66A13B0", VA = "0x1866A23B0", Slot = "5")]
	public IReadOnlyList<OJOOGHNNINA> MANPKGDPACH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x66A2690", Offset = "0x66A1690", VA = "0x1866A2690")]
	public LDAAEDOKKEK()
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
