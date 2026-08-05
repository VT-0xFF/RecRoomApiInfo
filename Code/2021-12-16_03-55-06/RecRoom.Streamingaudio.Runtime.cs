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
public interface HGPENPJFCJA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PDACPHLGNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NKJKFMLDPLA> GDDJFIAAPAO();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NKJKFMLDPLA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FKHMHHAEPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EFFPHPNPJOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ONBGJOIPIAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KMPPAADNGLE DECHPOAJDFA(Action<ArraySegment<float>> KPMKLLFNKEH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PLFBBMJOAOG();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KMPPAADNGLE
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CFONMEMOAOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AD0", Offset = "0x6C4ED0", VA = "0x1806C5AD0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6ECA70", Offset = "0x6EBE70", VA = "0x1806ECA70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LHENDJIBDMO
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6C5AB0", Offset = "0x6C4EB0", VA = "0x1806C5AB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1DB23A0", Offset = "0x1DB17A0", VA = "0x181DB23A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x43EA960", Offset = "0x43E9D60", VA = "0x1843EA960")]
	public KMPPAADNGLE(int LFCDIACMNDM, int NLEPFIJEBMP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class DDEDCMIOFNC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HGPENPJFCJA FDJDGECPFBD;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PDACPHLGNON
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x43EA850", Offset = "0x43E9C50", VA = "0x1843EA850")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x43EA8C0", Offset = "0x43E9CC0", VA = "0x1843EA8C0")]
	static DDEDCMIOFNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x43EA760", Offset = "0x43E9B60", VA = "0x1843EA760")]
	public static IReadOnlyList<NKJKFMLDPLA> GDDJFIAAPAO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class AOEBBCJDDJO : HGPENPJFCJA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CAAKJJHJNEM : NKJKFMLDPLA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class LMAHHEKFBIG
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
			[Cpp2IlInjected.Address(RVA = "0x4C19D0", Offset = "0x4C0DD0", VA = "0x1804C19D0")]
			public LMAHHEKFBIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x43EA970", Offset = "0x43E9D70", VA = "0x1843EA970")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DPKPBLJLMOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture GCFCKMHGMDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource MHNGLLLIMLE;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FKHMHHAEPOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x43EA6A0", Offset = "0x43E9AA0", VA = "0x1843EA6A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EFFPHPNPJOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x582A20", Offset = "0x581E20", VA = "0x180582A20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x682620", Offset = "0x681A20", VA = "0x180682620")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ONBGJOIPIAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x918610", Offset = "0x917A10", VA = "0x180918610", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x43EA670", Offset = "0x43E9A70", VA = "0x1843EA670", Slot = "7")]
		public KMPPAADNGLE DECHPOAJDFA(Action<ArraySegment<float>> KPMKLLFNKEH)
		{
			return default(KMPPAADNGLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x43EA390", Offset = "0x43E9790", VA = "0x1843EA390")]
		private KMPPAADNGLE DECHPOAJDFA(int LFCDIACMNDM, int DGHFDLNKEDI, int NLEPFIJEBMP, Action<ArraySegment<float>> KPMKLLFNKEH)
		{
			return default(KMPPAADNGLE);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x43EA6C0", Offset = "0x43E9AC0", VA = "0x1843EA6C0", Slot = "8")]
		public void PLFBBMJOAOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43EA720", Offset = "0x43E9B20", VA = "0x1843EA720")]
		public CAAKJJHJNEM(MMDevice DPKPBLJLMOP, bool MAPCEOCBMEI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<CAAKJJHJNEM> NKNNILDDKMK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PDACPHLGNON
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x4BFF60", Offset = "0x4BF360", VA = "0x1804BFF60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x43EA090", Offset = "0x43E9490", VA = "0x1843EA090", Slot = "5")]
	public IReadOnlyList<NKJKFMLDPLA> GDDJFIAAPAO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x43EA330", Offset = "0x43E9730", VA = "0x1843EA330")]
	public AOEBBCJDDJO()
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
