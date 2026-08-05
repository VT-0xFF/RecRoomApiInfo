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
public interface PEMJNOOJMIE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool DCHCLNLAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<LJKJAALADMF> IHGDEDHCLEJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface LJKJAALADMF
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PBKEDGJNNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool GAEDCMDAODA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KHMEGDKKNBB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NNCAJICBNDI LNHKPNONDFE(Action<ArraySegment<float>> NIBAGIPBILN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void JJLCKPDEOEI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NNCAJICBNDI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MNPHKJCADGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5DA2D0", Offset = "0x5D90D0", VA = "0x1805DA2D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x732890", Offset = "0x731690", VA = "0x180732890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int GFPJMDGLGIM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xBCF590", Offset = "0xBCE390", VA = "0x180BCF590")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xCD7630", Offset = "0xCD6430", VA = "0x180CD7630")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1ABCF40", Offset = "0x1ABBD40", VA = "0x181ABCF40")]
	public NNCAJICBNDI(int BBJIAOJJNME, int FIBMGDACDMG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class JFIAEGNNGEJ
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static PEMJNOOJMIE GJPFNMLJMDA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool DCHCLNLAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1ABCD30", Offset = "0x1ABBB30", VA = "0x181ABCD30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1ABCE90", Offset = "0x1ABBC90", VA = "0x181ABCE90")]
	static JFIAEGNNGEJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1ABCDA0", Offset = "0x1ABBBA0", VA = "0x181ABCDA0")]
	public static IReadOnlyList<LJKJAALADMF> IHGDEDHCLEJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ONEAKHKMJFI : PEMJNOOJMIE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class FIDGLJNHIEH : LJKJAALADMF
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BGBDEBDOCMH
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
			[Cpp2IlInjected.Address(RVA = "0x523000", Offset = "0x521E00", VA = "0x180523000")]
			public BGBDEBDOCMH()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1ABC750", Offset = "0x1ABB550", VA = "0x181ABC750")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice CBOBBPBIGAO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BIDAOFNPAPM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource FHNBLBADGFI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PBKEDGJNNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1ABCCC0", Offset = "0x1ABBAC0", VA = "0x181ABCCC0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool GAEDCMDAODA
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x556EC0", Offset = "0x555CC0", VA = "0x180556EC0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x556DF0", Offset = "0x555BF0", VA = "0x180556DF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KHMEGDKKNBB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x776A10", Offset = "0x775810", VA = "0x180776A10", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC950", Offset = "0x1ABB750", VA = "0x181ABC950", Slot = "7")]
		public NNCAJICBNDI LNHKPNONDFE(Action<ArraySegment<float>> NIBAGIPBILN)
		{
			return default(NNCAJICBNDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC980", Offset = "0x1ABB780", VA = "0x181ABC980")]
		private NNCAJICBNDI LNHKPNONDFE(int BBJIAOJJNME, int LOMKHENJMIL, int FIBMGDACDMG, Action<ArraySegment<float>> NIBAGIPBILN)
		{
			return default(NNCAJICBNDI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1ABC8D0", Offset = "0x1ABB6D0", VA = "0x181ABC8D0", Slot = "8")]
		public void JJLCKPDEOEI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1ABCCE0", Offset = "0x1ABBAE0", VA = "0x181ABCCE0")]
		public FIDGLJNHIEH(MMDevice CBOBBPBIGAO, bool FJPCCPLACOG)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<FIDGLJNHIEH> BGBMIELPAEM;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool DCHCLNLAFDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x56D180", Offset = "0x56BF80", VA = "0x18056D180", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1ABCF50", Offset = "0x1ABBD50", VA = "0x181ABCF50", Slot = "5")]
	public IReadOnlyList<LJKJAALADMF> IHGDEDHCLEJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1ABD1F0", Offset = "0x1ABBFF0", VA = "0x181ABD1F0")]
	public ONEAKHKMJFI()
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
