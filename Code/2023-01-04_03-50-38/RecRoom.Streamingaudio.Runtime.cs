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
public interface DEPDIEODFDP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IAOPPCMFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GAIJPEOBMKG> OAEHHHCEHHM();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GAIJPEOBMKG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HBNDJAAONPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BAFCEHPPEHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NLAJPLFAEBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IHINCBDNKNH JFHKAAOELEM(Action<ArraySegment<float>> MCFINHLOBAO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HHLBBNAJGIF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IHINCBDNKNH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MALMLMLIFEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x729E20", Offset = "0x729220", VA = "0x180729E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x729D90", Offset = "0x729190", VA = "0x180729D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DBNGHCONKEH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8B6B60", Offset = "0x8B5F60", VA = "0x1808B6B60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEAA170", Offset = "0xEA9570", VA = "0x180EAA170")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x60A1790", Offset = "0x60A0B90", VA = "0x1860A1790")]
	public IHINCBDNKNH(int MPBBAILALAG, int FFHMLHBONDN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PHJELIEHOEP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DEPDIEODFDP NLFKHOCCBFP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IAOPPCMFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x60A1DF0", Offset = "0x60A11F0", VA = "0x1860A1DF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x60A1F70", Offset = "0x60A1370", VA = "0x1860A1F70")]
	static PHJELIEHOEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x60A1E70", Offset = "0x60A1270", VA = "0x1860A1E70")]
	public static IReadOnlyList<GAIJPEOBMKG> OAEHHHCEHHM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class HDCFAIHFBOB : DEPDIEODFDP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ODAFPGDPIBG : GAIJPEOBMKG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PAIHJLEIFAE
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
			[Cpp2IlInjected.Address(RVA = "0x679B30", Offset = "0x678F30", VA = "0x180679B30")]
			public PAIHJLEIFAE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x60A1C60", Offset = "0x60A1060", VA = "0x1860A1C60")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HDBIIMIIBKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture PDANAMMOHIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LPFALDJBIOK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HBNDJAAONPA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x60A1BF0", Offset = "0x60A0FF0", VA = "0x1860A1BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BAFCEHPPEHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x768F80", Offset = "0x768380", VA = "0x180768F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x732170", Offset = "0x731570", VA = "0x180732170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NLAJPLFAEBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6B9C60", Offset = "0x6B9060", VA = "0x1806B9C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x60A1BC0", Offset = "0x60A0FC0", VA = "0x1860A1BC0", Slot = "7")]
		public IHINCBDNKNH JFHKAAOELEM(Action<ArraySegment<float>> MCFINHLOBAO)
		{
			return default(IHINCBDNKNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x60A1820", Offset = "0x60A0C20", VA = "0x1860A1820")]
		private IHINCBDNKNH JFHKAAOELEM(int MPBBAILALAG, int KGPAJJLCPCP, int FFHMLHBONDN, Action<ArraySegment<float>> MCFINHLOBAO)
		{
			return default(IHINCBDNKNH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x60A17A0", Offset = "0x60A0BA0", VA = "0x1860A17A0", Slot = "8")]
		public void HHLBBNAJGIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x60A1C10", Offset = "0x60A1010", VA = "0x1860A1C10")]
		public ODAFPGDPIBG(MMDevice HDBIIMIIBKL, bool DAGFFEMKALF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ODAFPGDPIBG> KJEKHKMALPJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IAOPPCMFDEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x699020", Offset = "0x698420", VA = "0x180699020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x60A1430", Offset = "0x60A0830", VA = "0x1860A1430", Slot = "5")]
	public IReadOnlyList<GAIJPEOBMKG> OAEHHHCEHHM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x60A1710", Offset = "0x60A0B10", VA = "0x1860A1710")]
	public HDCFAIHFBOB()
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
