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
public interface CCGFLNPFICH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MJBFBGKFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DNMBOKIIAMB> PBOHLLACAKN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DNMBOKIIAMB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string EHAAMAPBCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MEMFFJBINKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NHLKGLKGMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CPENIDHOFHN MGKJELGHJHB(Action<ArraySegment<float>> NLOLPKLGIBB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GKPLFHGPBGN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CPENIDHOFHN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int KLCGMIFADAP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8F7FF0", Offset = "0x8F6BF0", VA = "0x1808F7FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int DJNMBMGMBOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x22BBEE0", Offset = "0x22BAAE0", VA = "0x1822BBEE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x556DF40", Offset = "0x556CB40", VA = "0x18556DF40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x69CF760", Offset = "0x69CE360", VA = "0x1869CF760")]
	public CPENIDHOFHN(int HCPCBGMBMCD, int FEFBMFCEMDE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IHMJJLMHGCC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static CCGFLNPFICH EAFKGHPLPIP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MJBFBGKFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x69CFC10", Offset = "0x69CE810", VA = "0x1869CFC10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x69CFC90", Offset = "0x69CE890", VA = "0x1869CFC90")]
	static IHMJJLMHGCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x69CFB20", Offset = "0x69CE720", VA = "0x1869CFB20")]
	public static IReadOnlyList<DNMBOKIIAMB> PBOHLLACAKN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DBFBNMHKCII : CCGFLNPFICH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OBOPNJBGJLF : DNMBOKIIAMB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JCLGLHELCNF
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
			[Cpp2IlInjected.Address(RVA = "0x7BD130", Offset = "0x7BBD30", VA = "0x1807BD130")]
			public JCLGLHELCNF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x69CFD80", Offset = "0x69CE980", VA = "0x1869CFD80")]
			internal void FCLBLOGJFFI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NPMMGAMJFMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JPHAHBNHHMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource GDPKMJEEHDI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EHAAMAPBCCL
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x69CFF00", Offset = "0x69CEB00", VA = "0x1869CFF00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MEMFFJBINKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F8240", Offset = "0x8F6E40", VA = "0x1808F8240", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9EE7B0", Offset = "0x9ED3B0", VA = "0x1809EE7B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NHLKGLKGMHM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD141A0", Offset = "0xD12DA0", VA = "0x180D141A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69CFFA0", Offset = "0x69CEBA0", VA = "0x1869CFFA0", Slot = "7")]
		public CPENIDHOFHN MGKJELGHJHB(Action<ArraySegment<float>> NLOLPKLGIBB)
		{
			return default(CPENIDHOFHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x69CFFD0", Offset = "0x69CEBD0", VA = "0x1869CFFD0")]
		private CPENIDHOFHN MGKJELGHJHB(int HCPCBGMBMCD, int KIBCMKPHIOA, int FEFBMFCEMDE, Action<ArraySegment<float>> NLOLPKLGIBB)
		{
			return default(CPENIDHOFHN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x69CFF20", Offset = "0x69CEB20", VA = "0x1869CFF20", Slot = "8")]
		public void GKPLFHGPBGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69D0390", Offset = "0x69CEF90", VA = "0x1869D0390")]
		public OBOPNJBGJLF(MMDevice NPMMGAMJFMA, bool OLODABOKDKI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OBOPNJBGJLF> ICHEJLLMGGH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MJBFBGKFJKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CBA20", Offset = "0x7CA620", VA = "0x1807CBA20", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x69CF770", Offset = "0x69CE370", VA = "0x1869CF770", Slot = "5")]
	public IReadOnlyList<DNMBOKIIAMB> PBOHLLACAKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x69CFA90", Offset = "0x69CE690", VA = "0x1869CFA90")]
	public DBFBNMHKCII()
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
