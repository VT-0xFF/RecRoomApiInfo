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
public class CONMGOBHOFN : IHBLLPEDAPL
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class GKNFJAAPODH : LEBPEEEPHJI
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class PAGBINLPJNB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public Action<ArraySegment<float>> callback;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public float[] buffer;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public int length;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000009")]
			public ISampleSource sampleSource;

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x8459F0", Offset = "0x8449F0", VA = "0x1808459F0")]
			public PAGBINLPJNB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x72BC2C0", Offset = "0x72BB2C0", VA = "0x1872BC2C0")]
			internal void BHJDLNBNMFP(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice FOGBNHAHLFM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture NFDOMFBEPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource GLJKANAAOMJ;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string CKPNJKGCAOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x72BBF80", Offset = "0x72BAF80", VA = "0x1872BBF80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool AIBOJDJODAD
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x944220", Offset = "0x943220", VA = "0x180944220", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x944420", Offset = "0x943420", VA = "0x180944420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool ECGOKLGMPJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x945FD0", Offset = "0x944FD0", VA = "0x180945FD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x72BBBB0", Offset = "0x72BABB0", VA = "0x1872BBBB0", Slot = "7")]
		public LOLFGDOHDMN FKNINLIGCDC(Action<ArraySegment<float>> PAFCNGJPIGM)
		{
			return default(LOLFGDOHDMN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x72BBBE0", Offset = "0x72BABE0", VA = "0x1872BBBE0")]
		private LOLFGDOHDMN FKNINLIGCDC(int IHPJOHBJLGL, int CFPPAMOPAEL, int BDKIBKEJHDF, Action<ArraySegment<float>> PAFCNGJPIGM)
		{
			return default(LOLFGDOHDMN);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x72BBFA0", Offset = "0x72BAFA0", VA = "0x1872BBFA0", Slot = "8")]
		public void NJEPMCBADGO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x72BC020", Offset = "0x72BB020", VA = "0x1872BC020")]
		public GKNFJAAPODH(MMDevice FOGBNHAHLFM, bool DPCPFCCABOC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<GKNFJAAPODH> HALDDFNIFKG;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool PHAPAEBEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8401F0", Offset = "0x83F1F0", VA = "0x1808401F0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x72BB860", Offset = "0x72BA860", VA = "0x1872BB860", Slot = "5")]
	public IReadOnlyList<LEBPEEEPHJI> DGFIHJFBIDG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x72BBB30", Offset = "0x72BAB30", VA = "0x1872BBB30")]
	public CONMGOBHOFN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface IHBLLPEDAPL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool PHAPAEBEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LEBPEEEPHJI> DGFIHJFBIDG();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface LEBPEEEPHJI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string CKPNJKGCAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool AIBOJDJODAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool ECGOKLGMPJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LOLFGDOHDMN FKNINLIGCDC(Action<ArraySegment<float>> PAFCNGJPIGM);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NJEPMCBADGO();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct LOLFGDOHDMN
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int HEDGBDFDJEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xC07E90", Offset = "0xC06E90", VA = "0x180C07E90")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA79570", Offset = "0xA78570", VA = "0x180A79570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int LHLJMPCHCEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1E2C3F0", Offset = "0x1E2B3F0", VA = "0x181E2C3F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x11BC270", Offset = "0x11BB270", VA = "0x1811BC270")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x72BC070", Offset = "0x72BB070", VA = "0x1872BC070")]
	public LOLFGDOHDMN(int IHPJOHBJLGL, int BDKIBKEJHDF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class NMGEGNECOBG
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static IHBLLPEDAPL KPPPNKNDMGK;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool PHAPAEBEEFG
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x72BC170", Offset = "0x72BB170", VA = "0x1872BC170")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x72BC1F0", Offset = "0x72BB1F0", VA = "0x1872BC1F0")]
	static NMGEGNECOBG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x72BC080", Offset = "0x72BB080", VA = "0x1872BC080")]
	public static IReadOnlyList<LEBPEEEPHJI> DGFIHJFBIDG()
	{
		return null;
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
