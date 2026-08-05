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
public interface PANOGLNHIKB
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NNFCBALDBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<NGKFODIGANN> CLGGHHLMFMB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface NGKFODIGANN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OFPJGOGNFDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FGBAEACKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool CPIGNOLMECP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HOKGDOGIEMM AKNCPHBCDDL(Action<ArraySegment<float>> MLFGBBGKHEO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BLJJAEPDKHI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HOKGDOGIEMM
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DALCLKIPMPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7608C0", Offset = "0x75F2C0", VA = "0x1807608C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x760940", Offset = "0x75F340", VA = "0x180760940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KOLIIBCLGLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x18486F0", Offset = "0x18470F0", VA = "0x1818486F0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1848730", Offset = "0x1847130", VA = "0x181848730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x605C0C0", Offset = "0x605AAC0", VA = "0x18605C0C0")]
	public HOKGDOGIEMM(int DALIBIIPGIJ, int DCJEIGAGFIM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EEAALIFPBCI
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static PANOGLNHIKB DEDOGJBGPNF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NNFCBALDBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x605BF70", Offset = "0x605A970", VA = "0x18605BF70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x605BFF0", Offset = "0x605A9F0", VA = "0x18605BFF0")]
	static EEAALIFPBCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x605BE70", Offset = "0x605A870", VA = "0x18605BE70")]
	public static IReadOnlyList<NGKFODIGANN> CLGGHHLMFMB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ICPDEGBFCNG : PANOGLNHIKB
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class JGAEBHDBJGJ : NGKFODIGANN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BANJFLHILPF
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
			[Cpp2IlInjected.Address(RVA = "0x69F240", Offset = "0x69DC40", VA = "0x18069F240")]
			public BANJFLHILPF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x605BCE0", Offset = "0x605A6E0", VA = "0x18605BCE0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice DAHBFCOKMHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DPPBPLNFCFJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource INMHPFFAGPN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OFPJGOGNFDA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x605C880", Offset = "0x605B280", VA = "0x18605C880", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FGBAEACKPMD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x799F80", Offset = "0x798980", VA = "0x180799F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x799F70", Offset = "0x798970", VA = "0x180799F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool CPIGNOLMECP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9AF530", Offset = "0x9ADF30", VA = "0x1809AF530", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x605C7D0", Offset = "0x605B1D0", VA = "0x18605C7D0", Slot = "7")]
		public HOKGDOGIEMM AKNCPHBCDDL(Action<ArraySegment<float>> MLFGBBGKHEO)
		{
			return default(HOKGDOGIEMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x605C430", Offset = "0x605AE30", VA = "0x18605C430")]
		private HOKGDOGIEMM AKNCPHBCDDL(int DALIBIIPGIJ, int LJIHDJLMPEK, int DCJEIGAGFIM, Action<ArraySegment<float>> MLFGBBGKHEO)
		{
			return default(HOKGDOGIEMM);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x605C800", Offset = "0x605B200", VA = "0x18605C800", Slot = "8")]
		public void BLJJAEPDKHI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x605C8A0", Offset = "0x605B2A0", VA = "0x18605C8A0")]
		public JGAEBHDBJGJ(MMDevice DAHBFCOKMHF, bool ICLPBCIFLNA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<JGAEBHDBJGJ> KKMOPDCNJKK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NNFCBALDBOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6A32E0", Offset = "0x6A1CE0", VA = "0x1806A32E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x605C0D0", Offset = "0x605AAD0", VA = "0x18605C0D0", Slot = "5")]
	public IReadOnlyList<NGKFODIGANN> CLGGHHLMFMB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x605C3B0", Offset = "0x605ADB0", VA = "0x18605C3B0")]
	public ICPDEGBFCNG()
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
