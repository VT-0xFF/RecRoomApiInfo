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
public interface LONMCPGGOEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AHKOEFFALDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PNNFNJDOHDG> BGMAKFFEAAA();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PNNFNJDOHDG
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OIOLMCDGAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GHMNPIDJKAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CKHHKNIJPDE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	KDELNGODPDL ENFAPFIACOL(Action<ArraySegment<float>> KCGMNIDCJMF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IFHNKFHLKBP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct KDELNGODPDL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int LPMMEHGAEIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AB500", Offset = "0x8AA100", VA = "0x1808AB500")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x925AC0", Offset = "0x9246C0", VA = "0x180925AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BHJPEJEJPHF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8AB4E0", Offset = "0x8AA0E0", VA = "0x1808AB4E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8FF2D0", Offset = "0x8FDED0", VA = "0x1808FF2D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x58ABCD0", Offset = "0x58AA8D0", VA = "0x1858ABCD0")]
	public KDELNGODPDL(int OBGNNGLDFIH, int GGHEBFMIEGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IICNADDLOCI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LONMCPGGOEJ BNLJPBAEINL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AHKOEFFALDG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x58ABBB0", Offset = "0x58AA7B0", VA = "0x1858ABBB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x58ABC20", Offset = "0x58AA820", VA = "0x1858ABC20")]
	static IICNADDLOCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x58ABAC0", Offset = "0x58AA6C0", VA = "0x1858ABAC0")]
	public static IReadOnlyList<PNNFNJDOHDG> BGMAKFFEAAA()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DJLKIMPKFOO : LONMCPGGOEJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class MANAFNJOJHK : PNNFNJDOHDG
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class NIHAHGMIJPM
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
			[Cpp2IlInjected.Address(RVA = "0x5EEAB0", Offset = "0x5ED6B0", VA = "0x1805EEAB0")]
			public NIHAHGMIJPM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x58AC140", Offset = "0x58AAD40", VA = "0x1858AC140")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NDPNAAHEJDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture IIKFGDDKOPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource IKOJNCGAIGF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OIOLMCDGAFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x58ABCE0", Offset = "0x58AA8E0", VA = "0x1858ABCE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GHMNPIDJKAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x66D990", Offset = "0x66C590", VA = "0x18066D990", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA3B180", Offset = "0xA39D80", VA = "0x180A3B180")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CKHHKNIJPDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x705C70", Offset = "0x704870", VA = "0x180705C70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x58AC040", Offset = "0x58AAC40", VA = "0x1858AC040", Slot = "7")]
		public KDELNGODPDL ENFAPFIACOL(Action<ArraySegment<float>> KCGMNIDCJMF)
		{
			return default(KDELNGODPDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x58ABD00", Offset = "0x58AA900", VA = "0x1858ABD00")]
		private KDELNGODPDL ENFAPFIACOL(int OBGNNGLDFIH, int EGJHEPHPDOG, int GGHEBFMIEGA, Action<ArraySegment<float>> KCGMNIDCJMF)
		{
			return default(KDELNGODPDL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x58AC070", Offset = "0x58AAC70", VA = "0x1858AC070", Slot = "8")]
		public void IFHNKFHLKBP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x58AC0F0", Offset = "0x58AACF0", VA = "0x1858AC0F0")]
		public MANAFNJOJHK(MMDevice NDPNAAHEJDP, bool KNJMEPGDCAC)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<MANAFNJOJHK> GAGMGDPOKNL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AHKOEFFALDG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5ECFE0", Offset = "0x5EBBE0", VA = "0x1805ECFE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x58AB7B0", Offset = "0x58AA3B0", VA = "0x1858AB7B0", Slot = "5")]
	public IReadOnlyList<PNNFNJDOHDG> BGMAKFFEAAA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x58ABA50", Offset = "0x58AA650", VA = "0x1858ABA50")]
	public DJLKIMPKFOO()
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
