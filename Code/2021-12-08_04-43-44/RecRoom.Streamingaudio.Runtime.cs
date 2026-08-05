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
public interface BCONAJODGDF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KEOICGCCHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KKLLIEHPGBK> MMBEPGLBIPK();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KKLLIEHPGBK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string KBDACHKIJOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MLANLKBDDBF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KJGFJKNNFFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KMMLLJKAFMK DKOLJFBEHPH(Action<ArraySegment<float>> KENEHOJCGJI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JMAKNMADBHG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KMMLLJKAFMK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MABODMEMOJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x702D40", Offset = "0x702140", VA = "0x180702D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7634E0", Offset = "0x7628E0", VA = "0x1807634E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LLDOIGKGDCD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x702D20", Offset = "0x702120", VA = "0x180702D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1E373E0", Offset = "0x1E367E0", VA = "0x181E373E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x43E69A0", Offset = "0x43E5DA0", VA = "0x1843E69A0")]
	public KMMLLJKAFMK(int CNNGEJJCDHH, int KGFLKLABLGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NBCADCOCCPC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BCONAJODGDF ONFKDFGBDOF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KEOICGCCHJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x43E69B0", Offset = "0x43E5DB0", VA = "0x1843E69B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43E6B10", Offset = "0x43E5F10", VA = "0x1843E6B10")]
	static NBCADCOCCPC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x43E6A20", Offset = "0x43E5E20", VA = "0x1843E6A20")]
	public static IReadOnlyList<KKLLIEHPGBK> MMBEPGLBIPK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DPFCLDEOMJC : BCONAJODGDF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HAPGGDEJILO : KKLLIEHPGBK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GKFLGBDJJOA
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
			[Cpp2IlInjected.Address(RVA = "0x4C29D0", Offset = "0x4C1DD0", VA = "0x1804C29D0")]
			public GKFLGBDJJOA()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x43E6450", Offset = "0x43E5850", VA = "0x1843E6450")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice ENMCPBGBOEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LFCDIPHCDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource CHPLEDMAJKH;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string KBDACHKIJOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x43E6940", Offset = "0x43E5D40", VA = "0x1843E6940", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MLANLKBDDBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x561E90", Offset = "0x561290", VA = "0x180561E90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6A70C0", Offset = "0x6A64C0", VA = "0x1806A70C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KJGFJKNNFFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x678010", Offset = "0x677410", VA = "0x180678010", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43E68B0", Offset = "0x43E5CB0", VA = "0x1843E68B0", Slot = "7")]
		public KMMLLJKAFMK DKOLJFBEHPH(Action<ArraySegment<float>> KENEHOJCGJI)
		{
			return default(KMMLLJKAFMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43E65D0", Offset = "0x43E59D0", VA = "0x1843E65D0")]
		private KMMLLJKAFMK DKOLJFBEHPH(int CNNGEJJCDHH, int JCGHIFCDOBG, int KGFLKLABLGA, Action<ArraySegment<float>> KENEHOJCGJI)
		{
			return default(KMMLLJKAFMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43E68E0", Offset = "0x43E5CE0", VA = "0x1843E68E0", Slot = "8")]
		public void JMAKNMADBHG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43E6960", Offset = "0x43E5D60", VA = "0x1843E6960")]
		public HAPGGDEJILO(MMDevice ENMCPBGBOEI, bool MKHIIOLDLJM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HAPGGDEJILO> NFMHFADAAGN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KEOICGCCHJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4C0F60", Offset = "0x4C0360", VA = "0x1804C0F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43E6150", Offset = "0x43E5550", VA = "0x1843E6150", Slot = "5")]
	public IReadOnlyList<KKLLIEHPGBK> MMBEPGLBIPK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x43E63F0", Offset = "0x43E57F0", VA = "0x1843E63F0")]
	public DPFCLDEOMJC()
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
