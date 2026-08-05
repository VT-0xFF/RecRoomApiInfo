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
public interface DMLMIPBJKEN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EALMOOPKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HEKLGJFGDBB> NIMLABCDGBD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HEKLGJFGDBB
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FMBNCANNOLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LNIKLPDHGML
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool ALCBKDNIJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NMJFKDFKABI BLAKGDKFGPA(Action<ArraySegment<float>> KMEGFPKBBHD);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void POJGKKMCIGM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NMJFKDFKABI
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int BLJNIAOCLOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x647070", Offset = "0x646270", VA = "0x180647070")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66D9C0", Offset = "0x66CBC0", VA = "0x18066D9C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IEBLIMNGFNH
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x647080", Offset = "0x646280", VA = "0x180647080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6470C0", Offset = "0x6462C0", VA = "0x1806470C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4FED560", Offset = "0x4FEC760", VA = "0x184FED560")]
	public NMJFKDFKABI(int CHNPNJPANEK, int PBCPJFHNBKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HFJPEBBNHKF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DMLMIPBJKEN CIKPCNLONPP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EALMOOPKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4FED350", Offset = "0x4FEC550", VA = "0x184FED350")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4FED4B0", Offset = "0x4FEC6B0", VA = "0x184FED4B0")]
	static HFJPEBBNHKF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4FED3C0", Offset = "0x4FEC5C0", VA = "0x184FED3C0")]
	public static IReadOnlyList<HEKLGJFGDBB> NIMLABCDGBD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class GKDAJBOFDII : DMLMIPBJKEN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ENDJMBPBECO : HEKLGJFGDBB
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BEHOILKKENN
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
			[Cpp2IlInjected.Address(RVA = "0x579840", Offset = "0x578A40", VA = "0x180579840")]
			public BEHOILKKENN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4FECA60", Offset = "0x4FEBC60", VA = "0x184FECA60")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PJKCGCBEEHP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture OJJEPEDCDKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource DJGKOLBDDCN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FMBNCANNOLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4FECF50", Offset = "0x4FEC150", VA = "0x184FECF50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LNIKLPDHGML
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x6074A0", Offset = "0x6066A0", VA = "0x1806074A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6074B0", Offset = "0x6066B0", VA = "0x1806074B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool ALCBKDNIJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x7D4B40", Offset = "0x7D3D40", VA = "0x1807D4B40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4FECBE0", Offset = "0x4FEBDE0", VA = "0x184FECBE0", Slot = "7")]
		public NMJFKDFKABI BLAKGDKFGPA(Action<ArraySegment<float>> KMEGFPKBBHD)
		{
			return default(NMJFKDFKABI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4FECC10", Offset = "0x4FEBE10", VA = "0x184FECC10")]
		private NMJFKDFKABI BLAKGDKFGPA(int CHNPNJPANEK, int NMEAFAADIIG, int PBCPJFHNBKM, Action<ArraySegment<float>> KMEGFPKBBHD)
		{
			return default(NMJFKDFKABI);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4FECF70", Offset = "0x4FEC170", VA = "0x184FECF70", Slot = "8")]
		public void POJGKKMCIGM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4FECFF0", Offset = "0x4FEC1F0", VA = "0x184FECFF0")]
		public ENDJMBPBECO(MMDevice PJKCGCBEEHP, bool MMBLDNDNDCA)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ENDJMBPBECO> MKOKFNAKHBH;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EALMOOPKPMD
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x5749D0", Offset = "0x573BD0", VA = "0x1805749D0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4FED040", Offset = "0x4FEC240", VA = "0x184FED040", Slot = "5")]
	public IReadOnlyList<HEKLGJFGDBB> NIMLABCDGBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4FED2E0", Offset = "0x4FEC4E0", VA = "0x184FED2E0")]
	public GKDAJBOFDII()
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
