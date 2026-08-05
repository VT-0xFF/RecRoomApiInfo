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
public interface DJLGHMMIAEH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DICLPMJPJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CBJHMBJKEDO> NEDMKKNOADG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CBJHMBJKEDO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string NDCPPBLCLJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IBKFFGDDCPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool MGOFBIEIHMC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	ODHNDIJKGOM GOBPECGIODK(Action<ArraySegment<float>> OPOGBFLEIMD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MINODMGFMCM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct ODHNDIJKGOM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int PHOFJELDNMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x66A490", Offset = "0x668E90", VA = "0x18066A490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66A5B0", Offset = "0x668FB0", VA = "0x18066A5B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int AGDMHFGCBGG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7C6BA0", Offset = "0x7C55A0", VA = "0x1807C6BA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xA3CBC0", Offset = "0xA3B5C0", VA = "0x180A3CBC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x10F97B0", Offset = "0x10F81B0", VA = "0x1810F97B0")]
	public ODHNDIJKGOM(int IKEHOPCDOLF, int FDFOFPHBLBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class ADMCGOAHEGK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DJLGHMMIAEH MNGFNADBFNA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DICLPMJPJJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x10F8D60", Offset = "0x10F7760", VA = "0x1810F8D60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x10F8EC0", Offset = "0x10F78C0", VA = "0x1810F8EC0")]
	static ADMCGOAHEGK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x10F8DD0", Offset = "0x10F77D0", VA = "0x1810F8DD0")]
	public static IReadOnlyList<CBJHMBJKEDO> NEDMKKNOADG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DLMDNHAIDKI : DJLGHMMIAEH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KJDCBOFPFBM : CBJHMBJKEDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JAPJGCINGCB
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
			[Cpp2IlInjected.Address(RVA = "0x4299D0", Offset = "0x4283D0", VA = "0x1804299D0")]
			public JAPJGCINGCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x10F9260", Offset = "0x10F7C60", VA = "0x1810F9260")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice IMJKHKAHPMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JKMNCBBAEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NGPANAIMMCP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string NDCPPBLCLJN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x10F96F0", Offset = "0x10F80F0", VA = "0x1810F96F0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IBKFFGDDCPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x487ED0", Offset = "0x4868D0", VA = "0x180487ED0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x487F40", Offset = "0x486940", VA = "0x180487F40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool MGOFBIEIHMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x56DE10", Offset = "0x56C810", VA = "0x18056DE10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x10F96C0", Offset = "0x10F80C0", VA = "0x1810F96C0", Slot = "7")]
		public ODHNDIJKGOM GOBPECGIODK(Action<ArraySegment<float>> OPOGBFLEIMD)
		{
			return default(ODHNDIJKGOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x10F93E0", Offset = "0x10F7DE0", VA = "0x1810F93E0")]
		private ODHNDIJKGOM GOBPECGIODK(int IKEHOPCDOLF, int MAKEIFJCHEJ, int FDFOFPHBLBD, Action<ArraySegment<float>> OPOGBFLEIMD)
		{
			return default(ODHNDIJKGOM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x10F9710", Offset = "0x10F8110", VA = "0x1810F9710", Slot = "8")]
		public void MINODMGFMCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x10F9770", Offset = "0x10F8170", VA = "0x1810F9770")]
		public KJDCBOFPFBM(MMDevice IMJKHKAHPMD, bool GNDKDKFLJGA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KJDCBOFPFBM> LBLLMOGIPNK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DICLPMJPJJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x427F60", Offset = "0x426960", VA = "0x180427F60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x10F8F60", Offset = "0x10F7960", VA = "0x1810F8F60", Slot = "5")]
	public IReadOnlyList<CBJHMBJKEDO> NEDMKKNOADG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x10F9200", Offset = "0x10F7C00", VA = "0x1810F9200")]
	public DLMDNHAIDKI()
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
