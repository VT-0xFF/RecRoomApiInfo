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
public interface DFNJAGKILOG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool COLBMNLABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<EENOHDDDELO> KABKEHPNGDC();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface EENOHDDDELO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string EMIKMDCGJCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool HALEDKKFJGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LHCJFHHLKHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LFLOIJPLCCK EKGJDLGBILH(Action<ArraySegment<float>> KPIAINDMMOB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KBAJBBLMEIP();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LFLOIJPLCCK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int HEIAMCHJPCD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x905FC0", Offset = "0x904DC0", VA = "0x180905FC0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x905FF0", Offset = "0x904DF0", VA = "0x180905FF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int CCEJGJLBDKM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2373060", Offset = "0x2371E60", VA = "0x182373060")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x56467A0", Offset = "0x56455A0", VA = "0x1856467A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6AE61C0", Offset = "0x6AE4FC0", VA = "0x186AE61C0")]
	public LFLOIJPLCCK(int PKAGAMBJIFI, int LPNMCIEFDLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MFDIMIHJLEP
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DFNJAGKILOG PAJLDBCANGI;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool COLBMNLABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6AE61D0", Offset = "0x6AE4FD0", VA = "0x186AE61D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6330", Offset = "0x6AE5130", VA = "0x186AE6330")]
	static MFDIMIHJLEP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6240", Offset = "0x6AE5040", VA = "0x186AE6240")]
	public static IReadOnlyList<EENOHDDDELO> KABKEHPNGDC()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KKCHNNKCILO : DFNJAGKILOG
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class CCNOBHGMECM : EENOHDDDELO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JINANJPEELK
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
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public JINANJPEELK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6AE5CA0", Offset = "0x6AE4AA0", VA = "0x186AE5CA0")]
			internal void JCHIAGAEFJG(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HDMALIHKEPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture EGIAJCEMBAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource IKJELJJELOJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EMIKMDCGJCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6AE5C30", Offset = "0x6AE4A30", VA = "0x186AE5C30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool HALEDKKFJGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8F8610", Offset = "0x8F7410", VA = "0x1808F8610", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9E9A40", Offset = "0x9E8840", VA = "0x1809E9A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LHCJFHHLKHL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCFD9E0", Offset = "0xCFC7E0", VA = "0x180CFD9E0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5B80", Offset = "0x6AE4980", VA = "0x186AE5B80", Slot = "7")]
		public LFLOIJPLCCK EKGJDLGBILH(Action<ArraySegment<float>> KPIAINDMMOB)
		{
			return default(LFLOIJPLCCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6AE57C0", Offset = "0x6AE45C0", VA = "0x186AE57C0")]
		private LFLOIJPLCCK EKGJDLGBILH(int PKAGAMBJIFI, int KAEEBNNABCF, int LPNMCIEFDLC, Action<ArraySegment<float>> KPIAINDMMOB)
		{
			return default(LFLOIJPLCCK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5BB0", Offset = "0x6AE49B0", VA = "0x186AE5BB0", Slot = "8")]
		public void KBAJBBLMEIP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6AE5C50", Offset = "0x6AE4A50", VA = "0x186AE5C50")]
		public CCNOBHGMECM(MMDevice HDMALIHKEPJ, bool OALEFLFLFNB)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<CCNOBHGMECM> BOPNBJFACEE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool COLBMNLABHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CA590", Offset = "0x7C9390", VA = "0x1807CA590", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6AE5E20", Offset = "0x6AE4C20", VA = "0x186AE5E20", Slot = "5")]
	public IReadOnlyList<EENOHDDDELO> KABKEHPNGDC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6AE6130", Offset = "0x6AE4F30", VA = "0x186AE6130")]
	public KKCHNNKCILO()
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
