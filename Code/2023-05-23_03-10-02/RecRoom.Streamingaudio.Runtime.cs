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
public class LOJBGJKEAMG : AILIDDKBEPD
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private class PJFDOCGMOBM : JHECLMPHGFI
	{
		[Cpp2IlInjected.Token(Token = "0x2000004")]
		[CompilerGenerated]
		private sealed class MJGGANMJCNO
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
			[Cpp2IlInjected.Address(RVA = "0x8193F0", Offset = "0x8187F0", VA = "0x1808193F0")]
			public MJGGANMJCNO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(RVA = "0x1704220", Offset = "0x1703620", VA = "0x181704220")]
			internal void FHMPNNPIIPD(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		private MMDevice HJBJLNEJOBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private WasapiLoopbackCapture BGJGHEDFKPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private SoundInSource KDAGDMIEBBB;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public string GIMPGDCDJIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x1704800", Offset = "0x1703C00", VA = "0x181704800", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool KFIKNKFPIJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA5F540", Offset = "0xA5E940", VA = "0x180A5F540", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA287D0", Offset = "0xA27BD0", VA = "0x180A287D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool GFODAKPGLKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x934A00", Offset = "0x933E00", VA = "0x180934A00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x17043B0", Offset = "0x17037B0", VA = "0x1817043B0", Slot = "7")]
		public KBPDGMDKMPJ KLCHFKIBHAO(Action<ArraySegment<float>> JGHGBFJPJFD)
		{
			return default(KBPDGMDKMPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x17043E0", Offset = "0x17037E0", VA = "0x1817043E0")]
		private KBPDGMDKMPJ KLCHFKIBHAO(int FDMNKIGKENP, int POBNMCPFKJC, int GOAOMOGFBEL, Action<ArraySegment<float>> JGHGBFJPJFD)
		{
			return default(KBPDGMDKMPJ);
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1704780", Offset = "0x1703B80", VA = "0x181704780", Slot = "8")]
		public void OIHOPFKMDHM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1704820", Offset = "0x1703C20", VA = "0x181704820")]
		public PJFDOCGMOBM(MMDevice HJBJLNEJOBM, bool KEHMNMCLLCE)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	private List<PJFDOCGMOBM> BJOKOHEPHBB;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public bool MKFAAJKKINA
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x811730", Offset = "0x810B30", VA = "0x180811730", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1703EC0", Offset = "0x17032C0", VA = "0x181703EC0", Slot = "5")]
	public IReadOnlyList<JHECLMPHGFI> IGHADPGLHGA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x17041A0", Offset = "0x17035A0", VA = "0x1817041A0")]
	public LOJBGJKEAMG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public interface AILIDDKBEPD
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool MKFAAJKKINA
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<JHECLMPHGFI> IGHADPGLHGA();
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public interface JHECLMPHGFI
{
	[Cpp2IlInjected.Token(Token = "0x17000006")]
	string GIMPGDCDJIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool KFIKNKFPIJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool GFODAKPGLKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KBPDGMDKMPJ KLCHFKIBHAO(Action<ArraySegment<float>> JGHGBFJPJFD);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OIHOPFKMDHM();
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public struct KBPDGMDKMPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int LBAMEKCHCCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9A0690", Offset = "0x99FA90", VA = "0x1809A0690")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0xA20460", Offset = "0xA1F860", VA = "0x180A20460")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int JHNEKAHNDNI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0xB820F0", Offset = "0xB814F0", VA = "0x180B820F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1115560", Offset = "0x1114960", VA = "0x181115560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x1703EB0", Offset = "0x17032B0", VA = "0x181703EB0")]
	public KBPDGMDKMPJ(int FDMNKIGKENP, int GOAOMOGFBEL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class BOHEINPDBCH
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private static AILIDDKBEPD PKLMJOFPOJA;

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public static bool MKFAAJKKINA
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x1703C60", Offset = "0x1703060", VA = "0x181703C60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1703DE0", Offset = "0x17031E0", VA = "0x181703DE0")]
	static BOHEINPDBCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x1703CE0", Offset = "0x17030E0", VA = "0x181703CE0")]
	public static IReadOnlyList<JHECLMPHGFI> IGHADPGLHGA()
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
