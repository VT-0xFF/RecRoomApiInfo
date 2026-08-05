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
public interface GNOLKDMCMKE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool MNDILBDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<FKONAJIFMAM> MNKEOKHLKCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface FKONAJIFMAM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string ABEKIOKGBBN
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IHLGCEDADOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool KDPHHGJMJPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	LPFPGLPGMKJ IHFMEDHEMFJ(Action<ArraySegment<float>> CPIKECCHPBJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AIAJOJOHPMO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct LPFPGLPGMKJ
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JKOMJPPMJGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F3D10", Offset = "0x9F3110", VA = "0x1809F3D10")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xD2A260", Offset = "0xD29660", VA = "0x180D2A260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int MFJBFJNFMDC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x293B520", Offset = "0x293A920", VA = "0x18293B520")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x634DE50", Offset = "0x634D250", VA = "0x18634DE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7048FC0", Offset = "0x70483C0", VA = "0x187048FC0")]
	public LPFPGLPGMKJ(int BFKDOBHBEFE, int MPGANOCKFJD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AFKFOKKLBDC
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static GNOLKDMCMKE OFIBFBAADNE;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool MNDILBDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x79E10C0", Offset = "0x79E04C0", VA = "0x1879E10C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x79E1130", Offset = "0x79E0530", VA = "0x1879E1130")]
	static AFKFOKKLBDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x79E0FD0", Offset = "0x79E03D0", VA = "0x1879E0FD0")]
	public static IReadOnlyList<FKONAJIFMAM> MNKEOKHLKCJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KNHNOOMIIOM : GNOLKDMCMKE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class APNMIAHDCJG : FKONAJIFMAM
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DBEBDGMCPIG
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
			[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
			public DBEBDGMCPIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x79E1700", Offset = "0x79E0B00", VA = "0x1879E1700")]
			internal void FDLLLMAHJNL(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice OIINAFPPIKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DEBEBMDNNNI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource HCGCKHDDCDJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string ABEKIOKGBBN
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x79E1690", Offset = "0x79E0A90", VA = "0x1879E1690", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IHLGCEDADOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xA02880", Offset = "0xA01C80", VA = "0x180A02880", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA02750", Offset = "0xA01B50", VA = "0x180A02750")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool KDPHHGJMJPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A2F70", Offset = "0x9A2370", VA = "0x1809A2F70", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x79E1660", Offset = "0x79E0A60", VA = "0x1879E1660", Slot = "7")]
		public LPFPGLPGMKJ IHFMEDHEMFJ(Action<ArraySegment<float>> CPIKECCHPBJ)
		{
			return default(LPFPGLPGMKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x79E12A0", Offset = "0x79E06A0", VA = "0x1879E12A0")]
		private LPFPGLPGMKJ IHFMEDHEMFJ(int BFKDOBHBEFE, int BMFIKPPKBKP, int MPGANOCKFJD, Action<ArraySegment<float>> CPIKECCHPBJ)
		{
			return default(LPFPGLPGMKJ);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x79E1220", Offset = "0x79E0620", VA = "0x1879E1220", Slot = "8")]
		public void AIAJOJOHPMO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x79E16B0", Offset = "0x79E0AB0", VA = "0x1879E16B0")]
		public APNMIAHDCJG(MMDevice OIINAFPPIKH, bool HGNDIDJPAPO)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<APNMIAHDCJG> JCFCKEPFADF;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool MNDILBDNIJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8E1B40", Offset = "0x8E0F40", VA = "0x1808E1B40", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x79E1880", Offset = "0x79E0C80", VA = "0x1879E1880", Slot = "5")]
	public IReadOnlyList<FKONAJIFMAM> MNKEOKHLKCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x79E1BA0", Offset = "0x79E0FA0", VA = "0x1879E1BA0")]
	public KNHNOOMIIOM()
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
