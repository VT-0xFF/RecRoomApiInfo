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
public interface JPMFBOOGLBD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool PBIGCIGLHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CJNIFLJJEJO> LGJOIMFPFOD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CJNIFLJJEJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HMHLPEAAEHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GBHMHCNPIPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MHPBEEIEIDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOEPMLFFEHA OGPNBBAKDMO(Action<ArraySegment<float>> COPFOFGFOAL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DDMMAAPBHPM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DOEPMLFFEHA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PPBOEGLIDID
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x890610", Offset = "0x88FA10", VA = "0x180890610")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x890600", Offset = "0x88FA00", VA = "0x180890600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int FLGINJKNBFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2167AC0", Offset = "0x2166EC0", VA = "0x182167AC0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x549B270", Offset = "0x549A670", VA = "0x18549B270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x674DE50", Offset = "0x674D250", VA = "0x18674DE50")]
	public DOEPMLFFEHA(int AFOAGLGFACA, int FAIHDHBFOBN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AKKOGCAINHM
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JPMFBOOGLBD DNAKHBPNFJF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool PBIGCIGLHKB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x674D840", Offset = "0x674CC40", VA = "0x18674D840")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x674D9B0", Offset = "0x674CDB0", VA = "0x18674D9B0")]
	static AKKOGCAINHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x674D8C0", Offset = "0x674CCC0", VA = "0x18674D8C0")]
	public static IReadOnlyList<CJNIFLJJEJO> LGJOIMFPFOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class CDLNEIJAAJP : JPMFBOOGLBD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HHGJNMOJGAP : CJNIFLJJEJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NHOCNPPPHNN
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
			[Cpp2IlInjected.Address(RVA = "0x79F4B0", Offset = "0x79E8B0", VA = "0x18079F4B0")]
			public NHOCNPPPHNN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x674E340", Offset = "0x674D740", VA = "0x18674E340")]
			internal void KFLOLCFNAIH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice POLCGCJKMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MBBFFOGILHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BEAKINOLPPM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HMHLPEAAEHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x674DEE0", Offset = "0x674D2E0", VA = "0x18674DEE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GBHMHCNPIPM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87FB90", Offset = "0x87EF90", VA = "0x18087FB90", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x960E20", Offset = "0x960220", VA = "0x180960E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MHPBEEIEIDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC71E10", Offset = "0xC71210", VA = "0x180C71E10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x674E2C0", Offset = "0x674D6C0", VA = "0x18674E2C0", Slot = "7")]
		public DOEPMLFFEHA OGPNBBAKDMO(Action<ArraySegment<float>> COPFOFGFOAL)
		{
			return default(DOEPMLFFEHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x674DF00", Offset = "0x674D300", VA = "0x18674DF00")]
		private DOEPMLFFEHA OGPNBBAKDMO(int AFOAGLGFACA, int NMHJCDADKLL, int FAIHDHBFOBN, Action<ArraySegment<float>> COPFOFGFOAL)
		{
			return default(DOEPMLFFEHA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x674DE60", Offset = "0x674D260", VA = "0x18674DE60", Slot = "8")]
		public void DDMMAAPBHPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x674E2F0", Offset = "0x674D6F0", VA = "0x18674E2F0")]
		public HHGJNMOJGAP(MMDevice POLCGCJKMHF, bool IGIPFIECEEK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HHGJNMOJGAP> NFNLPFJMIPO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool PBIGCIGLHKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7AB880", Offset = "0x7AAC80", VA = "0x1807AB880", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x674DAA0", Offset = "0x674CEA0", VA = "0x18674DAA0", Slot = "5")]
	public IReadOnlyList<CJNIFLJJEJO> LGJOIMFPFOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x674DDC0", Offset = "0x674D1C0", VA = "0x18674DDC0")]
	public CDLNEIJAAJP()
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
