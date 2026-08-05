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
public interface IOIOAELKJKP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LKFOPDCMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LGPLDBNPCBE> AFMEGIIMLAB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LGPLDBNPCBE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OEOKJNDFNOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MBGJAFPOGGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EOFGIHLJGAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LJCDAFAAPBF JLAKLBDMMLA(Action<ArraySegment<float>> FOCHKIPOIOG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PFFBLAHHAFO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LJCDAFAAPBF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int GOJHPPPHACJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC4F0E0", Offset = "0xC4E2E0", VA = "0x180C4F0E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xF9C790", Offset = "0xF9B990", VA = "0x180F9C790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DNLOCCGCDKE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B3B3F0", Offset = "0x2B3A5F0", VA = "0x182B3B3F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x655CDD0", Offset = "0x655BFD0", VA = "0x18655CDD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7271AD0", Offset = "0x7270CD0", VA = "0x187271AD0")]
	public LJCDAFAAPBF(int DDHJDLDMALO, int CEGPKKEFOMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DJBLGLMNIMI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static IOIOAELKJKP IJOKMENMKFK;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LKFOPDCMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C2E920", Offset = "0x7C2DB20", VA = "0x187C2E920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E9A0", Offset = "0x7C2DBA0", VA = "0x187C2E9A0")]
	static DJBLGLMNIMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E830", Offset = "0x7C2DA30", VA = "0x187C2E830")]
	public static IReadOnlyList<LGPLDBNPCBE> AFMEGIIMLAB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BMCJJLBMBIM : IOIOAELKJKP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NJGBCJPBLOP : LGPLDBNPCBE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class KKGJPHGKDIG
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
			[Cpp2IlInjected.Address(RVA = "0x901140", Offset = "0x900340", VA = "0x180901140")]
			public KKGJPHGKDIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C2EA90", Offset = "0x7C2DC90", VA = "0x187C2EA90")]
			internal void EFOPIKBAKOJ(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NGBAIAHNEGG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HODBLLBPLPH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NKDALLPDHOF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OEOKJNDFNOG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7C2EC10", Offset = "0x7C2DE10", VA = "0x187C2EC10", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MBGJAFPOGGE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC897D0", Offset = "0xC889D0", VA = "0x180C897D0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC896C0", Offset = "0xC888C0", VA = "0x180C896C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EOFGIHLJGAA
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC25830", Offset = "0xC24A30", VA = "0x180C25830", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EC30", Offset = "0x7C2DE30", VA = "0x187C2EC30", Slot = "7")]
		public LJCDAFAAPBF JLAKLBDMMLA(Action<ArraySegment<float>> FOCHKIPOIOG)
		{
			return default(LJCDAFAAPBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C2EC60", Offset = "0x7C2DE60", VA = "0x187C2EC60")]
		private LJCDAFAAPBF JLAKLBDMMLA(int DDHJDLDMALO, int GENBILICFAK, int CEGPKKEFOMG, Action<ArraySegment<float>> FOCHKIPOIOG)
		{
			return default(LJCDAFAAPBF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F020", Offset = "0x7C2E220", VA = "0x187C2F020", Slot = "8")]
		public void PFFBLAHHAFO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2F0A0", Offset = "0x7C2E2A0", VA = "0x187C2F0A0")]
		public NJGBCJPBLOP(MMDevice NGBAIAHNEGG, bool CIJBILHKBPF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NJGBCJPBLOP> LCBNGPKHBJK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LKFOPDCMGNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x90E330", Offset = "0x90D530", VA = "0x18090E330", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E480", Offset = "0x7C2D680", VA = "0x187C2E480", Slot = "5")]
	public IReadOnlyList<LGPLDBNPCBE> AFMEGIIMLAB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C2E7A0", Offset = "0x7C2D9A0", VA = "0x187C2E7A0")]
	public BMCJJLBMBIM()
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
