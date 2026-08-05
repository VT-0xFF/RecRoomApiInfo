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
public interface GPBEEMMKBIL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NDDPNHCBBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GCIOFGGGPLF> MKAFIBEPMIB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GCIOFGGGPLF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NGOJJLKAPCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FNCPMDFPELG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ENIEOLOECOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KDLMFKLHOKM MOJJAPAHGAG(Action<ArraySegment<float>> OMCIJDNLADG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void LDKBBCJBIFP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KDLMFKLHOKM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LCIGHJDDGAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x60B9D0", Offset = "0x60A5D0", VA = "0x18060B9D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6E4120", Offset = "0x6E2D20", VA = "0x1806E4120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OLGEHJHEKLB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9976D0", Offset = "0x9962D0", VA = "0x1809976D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9ECA60", Offset = "0x9EB660", VA = "0x1809ECA60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x17E1B30", Offset = "0x17E0730", VA = "0x1817E1B30")]
	public KDLMFKLHOKM(int DAINDPLNHBE, int EMMLELPIDFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CABJLNANPFB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GPBEEMMKBIL PKLJENCKONH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NDDPNHCBBJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x17E1920", Offset = "0x17E0520", VA = "0x1817E1920")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x17E1A80", Offset = "0x17E0680", VA = "0x1817E1A80")]
	static CABJLNANPFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x17E1990", Offset = "0x17E0590", VA = "0x1817E1990")]
	public static IReadOnlyList<GCIOFGGGPLF> MKAFIBEPMIB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ODMALIJHIHH : GPBEEMMKBIL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KJGKOBAIHAF : GCIOFGGGPLF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class OJOOAAHOJFO
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
			[Cpp2IlInjected.Address(RVA = "0x54F000", Offset = "0x54DC00", VA = "0x18054F000")]
			public OJOOAAHOJFO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x17E22B0", Offset = "0x17E0EB0", VA = "0x1817E22B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice AGDNMEKODKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LDAGJDIBJEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource JBLEMNILGDN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NGOJJLKAPCB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x17E1BC0", Offset = "0x17E07C0", VA = "0x1817E1BC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FNCPMDFPELG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x62A050", Offset = "0x628C50", VA = "0x18062A050", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x881FC0", Offset = "0x880BC0", VA = "0x180881FC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ENIEOLOECOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x5C7DB0", Offset = "0x5C69B0", VA = "0x1805C7DB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x17E1BE0", Offset = "0x17E07E0", VA = "0x1817E1BE0", Slot = "7")]
		public KDLMFKLHOKM MOJJAPAHGAG(Action<ArraySegment<float>> OMCIJDNLADG)
		{
			return default(KDLMFKLHOKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x17E1C10", Offset = "0x17E0810", VA = "0x1817E1C10")]
		private KDLMFKLHOKM MOJJAPAHGAG(int DAINDPLNHBE, int ILIPOJIAMOD, int EMMLELPIDFE, Action<ArraySegment<float>> OMCIJDNLADG)
		{
			return default(KDLMFKLHOKM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x17E1B40", Offset = "0x17E0740", VA = "0x1817E1B40", Slot = "8")]
		public void LDKBBCJBIFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x17E1F50", Offset = "0x17E0B50", VA = "0x1817E1F50")]
		public KJGKOBAIHAF(MMDevice AGDNMEKODKJ, bool PIBPPOKNLAC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KJGKOBAIHAF> IDCAPEBIALN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NDDPNHCBBJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x577CA0", Offset = "0x5768A0", VA = "0x180577CA0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x17E1FA0", Offset = "0x17E0BA0", VA = "0x1817E1FA0", Slot = "5")]
	public IReadOnlyList<GCIOFGGGPLF> MKAFIBEPMIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x17E2240", Offset = "0x17E0E40", VA = "0x1817E2240")]
	public ODMALIJHIHH()
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
