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
public interface OFDNAHLDOAF
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool LLGDHJGNHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CGMIBOIKCDA> HMOMJFNHIDD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CGMIBOIKCDA
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DAHGILMMGEE
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MAJHOCMENPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LHEEKFKGMNJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FEGONEOJIEK LCBPLDPNILI(Action<ArraySegment<float>> LKHIOLGKDDF);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NDLDCKILLJD();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FEGONEOJIEK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ADHHOKGDHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xBD78B0", Offset = "0xBD60B0", VA = "0x180BD78B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x139F860", Offset = "0x139E060", VA = "0x18139F860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IILGLLMMGHI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2F364C0", Offset = "0x2F34CC0", VA = "0x182F364C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x71B2930", Offset = "0x71B1130", VA = "0x1871B2930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8003220", Offset = "0x8001A20", VA = "0x188003220")]
	public FEGONEOJIEK(int DAEJLIHGAIC, int LGMNONDEKAN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KICECCBKBJC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OFDNAHLDOAF MGAIHGMAGKO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool LLGDHJGNHAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8AC7F90", Offset = "0x8AC6790", VA = "0x188AC7F90")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8AC8000", Offset = "0x8AC6800", VA = "0x188AC8000")]
	static KICECCBKBJC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8AC7EA0", Offset = "0x8AC66A0", VA = "0x188AC7EA0")]
	public static IReadOnlyList<CGMIBOIKCDA> HMOMJFNHIDD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PHPMABFCMFP : OFDNAHLDOAF
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GPHFOBGBCPM : CGMIBOIKCDA
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class HLEAKPMLHJN
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
			[Cpp2IlInjected.Address(RVA = "0xA32430", Offset = "0xA30C30", VA = "0x180A32430")]
			public HLEAKPMLHJN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7D20", Offset = "0x8AC6520", VA = "0x188AC7D20")]
			internal void ILLGPNPOOCF(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EINNEHNHAKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture CMFJKHJHMHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource GDKCBJFLDAI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DAHGILMMGEE
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8AC7840", Offset = "0x8AC6040", VA = "0x188AC7840", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MAJHOCMENPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7E0", Offset = "0xA8CFE0", VA = "0x180A8E7E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA8E4F0", Offset = "0xA8CCF0", VA = "0x180A8E4F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LHEEKFKGMNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE20DE0", Offset = "0xE1F5E0", VA = "0x180E20DE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8AC7860", Offset = "0x8AC6060", VA = "0x188AC7860", Slot = "7")]
		public FEGONEOJIEK LCBPLDPNILI(Action<ArraySegment<float>> LKHIOLGKDDF)
		{
			return default(FEGONEOJIEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8AC7890", Offset = "0x8AC6090", VA = "0x188AC7890")]
		private FEGONEOJIEK LCBPLDPNILI(int DAEJLIHGAIC, int KHKFENJBOII, int LGMNONDEKAN, Action<ArraySegment<float>> LKHIOLGKDDF)
		{
			return default(FEGONEOJIEK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8AC7C50", Offset = "0x8AC6450", VA = "0x188AC7C50", Slot = "8")]
		public void NDLDCKILLJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8AC7CD0", Offset = "0x8AC64D0", VA = "0x188AC7CD0")]
		public GPHFOBGBCPM(MMDevice EINNEHNHAKK, bool PHEFOIPNIMF)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GPHFOBGBCPM> JHFKAHHHDOJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool LLGDHJGNHAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA43700", Offset = "0xA41F00", VA = "0x180A43700", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8AC80F0", Offset = "0x8AC68F0", VA = "0x188AC80F0", Slot = "5")]
	public IReadOnlyList<CGMIBOIKCDA> HMOMJFNHIDD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8AC8410", Offset = "0x8AC6C10", VA = "0x188AC8410")]
	public PHPMABFCMFP()
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
