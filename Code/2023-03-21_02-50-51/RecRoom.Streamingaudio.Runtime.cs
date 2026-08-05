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
public interface DILEFLFBEGN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NMOBHBPMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GNCOFCJAHKF> AFGAJIMCGHA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GNCOFCJAHKF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BJMLKDGDDDK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool BFIPOHMMAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BMHPNHIAOAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MPMELIOBJPH ABANPGCMFHH(Action<ArraySegment<float>> MKOFIMIHGLL);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HAEKIIKPJGE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MPMELIOBJPH
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OHLNPPHGHIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x786E40", Offset = "0x785640", VA = "0x180786E40")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x786DB0", Offset = "0x7855B0", VA = "0x180786DB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int NMMBNAGMGFD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x89E550", Offset = "0x89CD50", VA = "0x18089E550")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xDD7530", Offset = "0xDD5D30", VA = "0x180DD7530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x65E3CB0", Offset = "0x65E24B0", VA = "0x1865E3CB0")]
	public MPMELIOBJPH(int FLEGKKMDDAG, int LCOOFFCNANA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ENIGLCMPBNN
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DILEFLFBEGN AMIHCJLNBMH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NMOBHBPMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65E3670", Offset = "0x65E1E70", VA = "0x1865E3670")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x65E36F0", Offset = "0x65E1EF0", VA = "0x1865E36F0")]
	static ENIGLCMPBNN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65E3570", Offset = "0x65E1D70", VA = "0x1865E3570")]
	public static IReadOnlyList<GNCOFCJAHKF> AFGAJIMCGHA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FFCAKILPIAL : DILEFLFBEGN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ONCKMGIIFMF : GNCOFCJAHKF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JFEFGIBFGKJ
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
			[Cpp2IlInjected.Address(RVA = "0x6D6B30", Offset = "0x6D5330", VA = "0x1806D6B30")]
			public JFEFGIBFGKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x65E3B20", Offset = "0x65E2320", VA = "0x1865E3B20")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice ICPOGMPAIEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture POCDIDPPFMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BFKPFPMPDFA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BJMLKDGDDDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x65E4110", Offset = "0x65E2910", VA = "0x1865E4110", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool BFIPOHMMAHE
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7C5FA0", Offset = "0x7C47A0", VA = "0x1807C5FA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x78F190", Offset = "0x78D990", VA = "0x18078F190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BMHPNHIAOAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x716CB0", Offset = "0x7154B0", VA = "0x180716CB0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x65E4060", Offset = "0x65E2860", VA = "0x1865E4060", Slot = "7")]
		public MPMELIOBJPH ABANPGCMFHH(Action<ArraySegment<float>> MKOFIMIHGLL)
		{
			return default(MPMELIOBJPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x65E3CC0", Offset = "0x65E24C0", VA = "0x1865E3CC0")]
		private MPMELIOBJPH ABANPGCMFHH(int FLEGKKMDDAG, int GINMCGHNKJK, int LCOOFFCNANA, Action<ArraySegment<float>> MKOFIMIHGLL)
		{
			return default(MPMELIOBJPH);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x65E4090", Offset = "0x65E2890", VA = "0x1865E4090", Slot = "8")]
		public void HAEKIIKPJGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x65E4130", Offset = "0x65E2930", VA = "0x1865E4130")]
		public ONCKMGIIFMF(MMDevice ICPOGMPAIEA, bool IMNMBJJFBPB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ONCKMGIIFMF> FAFFJBGKDMP;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NMOBHBPMMEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F6020", Offset = "0x6F4820", VA = "0x1806F6020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x65E37C0", Offset = "0x65E1FC0", VA = "0x1865E37C0", Slot = "5")]
	public IReadOnlyList<GNCOFCJAHKF> AFGAJIMCGHA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x65E3AA0", Offset = "0x65E22A0", VA = "0x1865E3AA0")]
	public FFCAKILPIAL()
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
