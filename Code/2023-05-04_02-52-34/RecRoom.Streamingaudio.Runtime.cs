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
public interface HOEFIOOHBNA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JLOCGOJELAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PAFDPGDCCHN> JPMNIFLGBOD();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PAFDPGDCCHN
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string EFBIABFPECB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EPHPDJIILJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AIIDEDEHNPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DCFJNGGDGFL KNAEAFPEIMN(Action<ArraySegment<float>> MIKGEIBIMCG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MEBCIJLAKGN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DCFJNGGDGFL
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MFACJJGHGGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x877ED0", Offset = "0x8772D0", VA = "0x180877ED0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xBF6690", Offset = "0xBF5A90", VA = "0x180BF6690")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EFNALDLFIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x899ED0", Offset = "0x8992D0", VA = "0x180899ED0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xBF66A0", Offset = "0xBF5AA0", VA = "0x180BF66A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A39440", Offset = "0x6A38840", VA = "0x186A39440")]
	public DCFJNGGDGFL(int MJPEOFADNMJ, int GJACDCBIEIJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KBCMDPHMOBK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HOEFIOOHBNA DEJCFCAINJG;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool JLOCGOJELAO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6A398B0", Offset = "0x6A38CB0", VA = "0x186A398B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A39930", Offset = "0x6A38D30", VA = "0x186A39930")]
	static KBCMDPHMOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A397B0", Offset = "0x6A38BB0", VA = "0x186A397B0")]
	public static IReadOnlyList<PAFDPGDCCHN> JPMNIFLGBOD()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DGJKJAJMDCK : HOEFIOOHBNA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NHMNFNHNPIO : PAFDPGDCCHN
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MDPLLGDKBJF
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
			[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
			public MDPLLGDKBJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A39A00", Offset = "0x6A38E00", VA = "0x186A39A00")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice PIHLJIKHHMH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LJJADKLKEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BLGOAEMFHGG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string EFBIABFPECB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6A39B90", Offset = "0x6A38F90", VA = "0x186A39B90", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EPHPDJIILJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x754680", Offset = "0x753A80", VA = "0x180754680", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x754690", Offset = "0x753A90", VA = "0x180754690")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AIIDEDEHNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8A2FD0", Offset = "0x8A23D0", VA = "0x1808A2FD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A39F50", Offset = "0x6A39350", VA = "0x186A39F50", Slot = "7")]
		public DCFJNGGDGFL KNAEAFPEIMN(Action<ArraySegment<float>> MIKGEIBIMCG)
		{
			return default(DCFJNGGDGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A39BB0", Offset = "0x6A38FB0", VA = "0x186A39BB0")]
		private DCFJNGGDGFL KNAEAFPEIMN(int MJPEOFADNMJ, int JMOLMFFIBKN, int GJACDCBIEIJ, Action<ArraySegment<float>> MIKGEIBIMCG)
		{
			return default(DCFJNGGDGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A39F80", Offset = "0x6A39380", VA = "0x186A39F80", Slot = "8")]
		public void MEBCIJLAKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A000", Offset = "0x6A39400", VA = "0x186A3A000")]
		public NHMNFNHNPIO(MMDevice PIHLJIKHHMH, bool GAILPEPBEOI)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NHMNFNHNPIO> FAEINNHHCLJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JLOCGOJELAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7359E0", Offset = "0x734DE0", VA = "0x1807359E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A39450", Offset = "0x6A38850", VA = "0x186A39450", Slot = "5")]
	public IReadOnlyList<PAFDPGDCCHN> JPMNIFLGBOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A39730", Offset = "0x6A38B30", VA = "0x186A39730")]
	public DGJKJAJMDCK()
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
