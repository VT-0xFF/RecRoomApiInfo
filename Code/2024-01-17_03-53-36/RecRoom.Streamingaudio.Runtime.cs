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
public interface LGHPGDLEJPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool NOCHMJIJPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KEPCPPCKPKJ> FHHBLJFMDJL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KEPCPPCKPKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string LOGCOHNAJHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GBMGOMGEHBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool JOCBHKFHJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CFLBELCCNKF ABLAEFJHJIK(Action<ArraySegment<float>> EAGOMMNFHFH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JGDCKANKLFM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CFLBELCCNKF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MLJFMCONINH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x885810", Offset = "0x884610", VA = "0x180885810")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x885850", Offset = "0x884650", VA = "0x180885850")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LJNGEOPMMPE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2152A80", Offset = "0x2151880", VA = "0x182152A80")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x545E620", Offset = "0x545D420", VA = "0x18545E620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x67100C0", Offset = "0x670EEC0", VA = "0x1867100C0")]
	public CFLBELCCNKF(int JFHLLBNFCBH, int CNIJNKHOKNF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LAKEPPBFNHB
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static LGHPGDLEJPJ HCGJLIGBHPF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool NOCHMJIJPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6710A50", Offset = "0x670F850", VA = "0x186710A50")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6710AD0", Offset = "0x670F8D0", VA = "0x186710AD0")]
	static LAKEPPBFNHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6710960", Offset = "0x670F760", VA = "0x186710960")]
	public static IReadOnlyList<KEPCPPCKPKJ> FHHBLJFMDJL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KNMPINLGPPL : LGHPGDLEJPJ
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class DJFPLKGGMOK : KEPCPPCKPKJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BANEENHGJKM
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
			[Cpp2IlInjected.Address(RVA = "0x792DA0", Offset = "0x791BA0", VA = "0x180792DA0")]
			public BANEENHGJKM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x670FF40", Offset = "0x670ED40", VA = "0x18670FF40")]
			internal void LCIHJJKCEMB(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice ILLDHBJOJCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OKJGPFMIICB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource LLKLINIEFND;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string LOGCOHNAJHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x67104C0", Offset = "0x670F2C0", VA = "0x1867104C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GBMGOMGEHBO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x87DEA0", Offset = "0x87CCA0", VA = "0x18087DEA0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x960BA0", Offset = "0x95F9A0", VA = "0x180960BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool JOCBHKFHJEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC74D50", Offset = "0xC73B50", VA = "0x180C74D50", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x67100D0", Offset = "0x670EED0", VA = "0x1867100D0", Slot = "7")]
		public CFLBELCCNKF ABLAEFJHJIK(Action<ArraySegment<float>> EAGOMMNFHFH)
		{
			return default(CFLBELCCNKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6710100", Offset = "0x670EF00", VA = "0x186710100")]
		private CFLBELCCNKF ABLAEFJHJIK(int JFHLLBNFCBH, int IDPGBAFNCHM, int CNIJNKHOKNF, Action<ArraySegment<float>> EAGOMMNFHFH)
		{
			return default(CFLBELCCNKF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x67104E0", Offset = "0x670F2E0", VA = "0x1867104E0", Slot = "8")]
		public void JGDCKANKLFM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6710560", Offset = "0x670F360", VA = "0x186710560")]
		public DJFPLKGGMOK(MMDevice ILLDHBJOJCI, bool OGDMOPMHDLM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<DJFPLKGGMOK> KDBKLIGGLGO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool NOCHMJIJPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7A9270", Offset = "0x7A8070", VA = "0x1807A9270", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x67105B0", Offset = "0x670F3B0", VA = "0x1867105B0", Slot = "5")]
	public IReadOnlyList<KEPCPPCKPKJ> FHHBLJFMDJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x67108D0", Offset = "0x670F6D0", VA = "0x1867108D0")]
	public KNMPINLGPPL()
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
