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
		[Cpp2IlInjected.Address(RVA = "0x791E40", Offset = "0x791240", VA = "0x180791E40")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x791DB0", Offset = "0x7911B0", VA = "0x180791DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OOPCPIBLCEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8A9550", Offset = "0x8A8950", VA = "0x1808A9550")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE9C130", Offset = "0xE9B530", VA = "0x180E9C130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x671EE00", Offset = "0x671E200", VA = "0x18671EE00")]
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
		[Cpp2IlInjected.Address(RVA = "0x671EBB0", Offset = "0x671DFB0", VA = "0x18671EBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x671ED30", Offset = "0x671E130", VA = "0x18671ED30")]
	static GBLOFEHNAPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x671EC30", Offset = "0x671E030", VA = "0x18671EC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x6E1B30", Offset = "0x6E0F30", VA = "0x1806E1B30")]
			public JLMGBMFIENA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x671EE10", Offset = "0x671E210", VA = "0x18671EE10")]
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
			[Cpp2IlInjected.Address(RVA = "0x671F380", Offset = "0x671E780", VA = "0x18671F380", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JMOCDCDBNJB
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7D0FA0", Offset = "0x7D03A0", VA = "0x1807D0FA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x79A190", Offset = "0x799590", VA = "0x18079A190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BPKHEFCENIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x721CB0", Offset = "0x7210B0", VA = "0x180721CB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x671F3A0", Offset = "0x671E7A0", VA = "0x18671F3A0", Slot = "7")]
		public IDJLGNDEDPK KEFPFOANJJD(Action<ArraySegment<float>> PEPHBHFBJFE)
		{
			return default(IDJLGNDEDPK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x671F3D0", Offset = "0x671E7D0", VA = "0x18671F3D0")]
		private IDJLGNDEDPK KEFPFOANJJD(int MMHBLDHDAIK, int BBMIPEDKIHJ, int ADGOCJPBDPK, Action<ArraySegment<float>> PEPHBHFBJFE)
		{
			return default(IDJLGNDEDPK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x671F300", Offset = "0x671E700", VA = "0x18671F300", Slot = "8")]
		public void DDEKDKHPOJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x671F770", Offset = "0x671EB70", VA = "0x18671F770")]
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
		[Cpp2IlInjected.Address(RVA = "0x701020", Offset = "0x700420", VA = "0x180701020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x671EFA0", Offset = "0x671E3A0", VA = "0x18671EFA0", Slot = "5")]
	public IReadOnlyList<OJOOGHNNINA> MANPKGDPACH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x671F280", Offset = "0x671E680", VA = "0x18671F280")]
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
