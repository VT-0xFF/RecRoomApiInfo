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
public interface HNPOPCFMBFB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool HEEIJKAACMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ANJEHGICJHI> OHFLOKIOKJB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ANJEHGICJHI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HCDIFBBJJCM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EGNNDKHNIEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EHKLODHEADO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HABFPCOGCFI GIBIEEIOHDL(Action<ArraySegment<float>> JAKHBAJPHJL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GIGHJGMIMED();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HABFPCOGCFI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BKHOFDENOPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x804EE0", Offset = "0x803CE0", VA = "0x180804EE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6EFA40", Offset = "0x6EE840", VA = "0x1806EFA40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IMPGFCGNBHM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D90", Offset = "0x8D1B90", VA = "0x1808D2D90")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8D2D30", Offset = "0x8D1B30", VA = "0x1808D2D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x21D2B20", Offset = "0x21D1920", VA = "0x1821D2B20")]
	public HABFPCOGCFI(int CAJFEPJNKJF, int OGJIEEBGAIO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AALBNOJKPJE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HNPOPCFMBFB EEEOKEEMKHM;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool HEEIJKAACMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x21D2280", Offset = "0x21D1080", VA = "0x1821D2280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x21D2400", Offset = "0x21D1200", VA = "0x1821D2400")]
	static AALBNOJKPJE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x21D2300", Offset = "0x21D1100", VA = "0x1821D2300")]
	public static IReadOnlyList<ANJEHGICJHI> OHFLOKIOKJB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LLHODHGPGFM : HNPOPCFMBFB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class BGJMLLBCINC : ANJEHGICJHI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BCOJBHKIKCF
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
			[Cpp2IlInjected.Address(RVA = "0x6D2360", Offset = "0x6D1160", VA = "0x1806D2360")]
			public BCOJBHKIKCF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x21D24D0", Offset = "0x21D12D0", VA = "0x1821D24D0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LLIICOCGNKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ODJFCJOMBJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource CILELONHGLL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HCDIFBBJJCM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x21D2AB0", Offset = "0x21D18B0", VA = "0x1821D2AB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EGNNDKHNIEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x701080", Offset = "0x6FFE80", VA = "0x180701080", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x701090", Offset = "0x6FFE90", VA = "0x180701090")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EHKLODHEADO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB24BF0", Offset = "0xB239F0", VA = "0x180B24BF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x21D2A00", Offset = "0x21D1800", VA = "0x1821D2A00", Slot = "7")]
		public HABFPCOGCFI GIBIEEIOHDL(Action<ArraySegment<float>> JAKHBAJPHJL)
		{
			return default(HABFPCOGCFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x21D2660", Offset = "0x21D1460", VA = "0x1821D2660")]
		private HABFPCOGCFI GIBIEEIOHDL(int CAJFEPJNKJF, int DNGHGCALCHL, int OGJIEEBGAIO, Action<ArraySegment<float>> JAKHBAJPHJL)
		{
			return default(HABFPCOGCFI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x21D2A30", Offset = "0x21D1830", VA = "0x1821D2A30", Slot = "8")]
		public void GIGHJGMIMED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x21D2AD0", Offset = "0x21D18D0", VA = "0x1821D2AD0")]
		public BGJMLLBCINC(MMDevice LLIICOCGNKB, bool DGALCJCJAIF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<BGJMLLBCINC> KCFNKOEPCAI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool HEEIJKAACMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6C8080", Offset = "0x6C6E80", VA = "0x1806C8080", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x21D2B30", Offset = "0x21D1930", VA = "0x1821D2B30", Slot = "5")]
	public IReadOnlyList<ANJEHGICJHI> OHFLOKIOKJB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21D2E10", Offset = "0x21D1C10", VA = "0x1821D2E10")]
	public LLHODHGPGFM()
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
