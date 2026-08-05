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
public interface JJNPHLFIGAG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EAJGPMMNBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OHAJFLPNCFJ> KIJGOCBGHIC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OHAJFLPNCFJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string JBICACFIAKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JIOIDBBKEAF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool GKDEMMGKFPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MDEEJNPPFND ICEMHIHGKNL(Action<ArraySegment<float>> PKJIBFLDCKK);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBPGPDDCPCA();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MDEEJNPPFND
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NKBLOLEEGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xB50400", Offset = "0xB4F800", VA = "0x180B50400")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xB503C0", Offset = "0xB4F7C0", VA = "0x180B503C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GPKNPKMPCJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x258C120", Offset = "0x258B520", VA = "0x18258C120")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5CC1520", Offset = "0x5CC0920", VA = "0x185CC1520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7255DA0", Offset = "0x72551A0", VA = "0x187255DA0")]
	public MDEEJNPPFND(int IKAHLPFKMJJ, int LCCHFIEAEME)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class OBCMMBJDKOO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static JJNPHLFIGAG DEAKFCJIHCA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EAJGPMMNBIL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7255EA0", Offset = "0x72552A0", VA = "0x187255EA0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7255F20", Offset = "0x7255320", VA = "0x187255F20")]
	static OBCMMBJDKOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7255DB0", Offset = "0x72551B0", VA = "0x187255DB0")]
	public static IReadOnlyList<OHAJFLPNCFJ> KIJGOCBGHIC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BFDCAGBGOGN : JJNPHLFIGAG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KGLLMGBMNNI : OHAJFLPNCFJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BEFACGIKEHP
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
			[Cpp2IlInjected.Address(RVA = "0x84F5C0", Offset = "0x84E9C0", VA = "0x18084F5C0")]
			public BEFACGIKEHP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7255390", Offset = "0x7254790", VA = "0x187255390")]
			internal void MMNBDDENPLI(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BHBIBONBLGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture AMGGKDGMFCG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource KNEBDDONOJL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string JBICACFIAKA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7255D30", Offset = "0x7255130", VA = "0x187255D30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JIOIDBBKEAF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xB41E20", Offset = "0xB41220", VA = "0x180B41E20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC38310", Offset = "0xC37710", VA = "0x180C38310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool GKDEMMGKFPG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xF85590", Offset = "0xF84990", VA = "0x180F85590", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x72558C0", Offset = "0x7254CC0", VA = "0x1872558C0", Slot = "7")]
		public MDEEJNPPFND ICEMHIHGKNL(Action<ArraySegment<float>> PKJIBFLDCKK)
		{
			return default(MDEEJNPPFND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x72558F0", Offset = "0x7254CF0", VA = "0x1872558F0")]
		private MDEEJNPPFND ICEMHIHGKNL(int IKAHLPFKMJJ, int JOHKIFCLOBK, int LCCHFIEAEME, Action<ArraySegment<float>> PKJIBFLDCKK)
		{
			return default(MDEEJNPPFND);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7255CB0", Offset = "0x72550B0", VA = "0x187255CB0", Slot = "8")]
		public void KBPGPDDCPCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7255D50", Offset = "0x7255150", VA = "0x187255D50")]
		public KGLLMGBMNNI(MMDevice BHBIBONBLGA, bool FNFGFLGCMKN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KGLLMGBMNNI> APFIICKKNCN;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EAJGPMMNBIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8665B0", Offset = "0x8659B0", VA = "0x1808665B0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7255510", Offset = "0x7254910", VA = "0x187255510", Slot = "5")]
	public IReadOnlyList<OHAJFLPNCFJ> KIJGOCBGHIC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7255830", Offset = "0x7254C30", VA = "0x187255830")]
	public BFDCAGBGOGN()
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
