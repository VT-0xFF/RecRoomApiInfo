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
		[Cpp2IlInjected.Address(RVA = "0x7C2AC0", Offset = "0x7C14C0", VA = "0x1807C2AC0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7C2A30", Offset = "0x7C1430", VA = "0x1807C2A30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EFNALDLFIJI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8C40C0", Offset = "0x8C2AC0", VA = "0x1808C40C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xE340B0", Offset = "0xE32AB0", VA = "0x180E340B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A11FD0", Offset = "0x6A109D0", VA = "0x186A11FD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6A12440", Offset = "0x6A10E40", VA = "0x186A12440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A124C0", Offset = "0x6A10EC0", VA = "0x186A124C0")]
	static KBCMDPHMOBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6A12340", Offset = "0x6A10D40", VA = "0x186A12340")]
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
			[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
			public MDPLLGDKBJF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6A12590", Offset = "0x6A10F90", VA = "0x186A12590")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A12720", Offset = "0x6A11120", VA = "0x186A12720", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool EPHPDJIILJH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x802050", Offset = "0x800A50", VA = "0x180802050", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x7CAE50", Offset = "0x7C9850", VA = "0x1807CAE50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool AIIDEDEHNPD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x752790", Offset = "0x751190", VA = "0x180752790", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A12AE0", Offset = "0x6A114E0", VA = "0x186A12AE0", Slot = "7")]
		public DCFJNGGDGFL KNAEAFPEIMN(Action<ArraySegment<float>> MIKGEIBIMCG)
		{
			return default(DCFJNGGDGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A12740", Offset = "0x6A11140", VA = "0x186A12740")]
		private DCFJNGGDGFL KNAEAFPEIMN(int MJPEOFADNMJ, int JMOLMFFIBKN, int GJACDCBIEIJ, Action<ArraySegment<float>> MIKGEIBIMCG)
		{
			return default(DCFJNGGDGFL);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B10", Offset = "0x6A11510", VA = "0x186A12B10", Slot = "8")]
		public void MEBCIJLAKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A12B90", Offset = "0x6A11590", VA = "0x186A12B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x7319E0", Offset = "0x7303E0", VA = "0x1807319E0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A11FE0", Offset = "0x6A109E0", VA = "0x186A11FE0", Slot = "5")]
	public IReadOnlyList<PAFDPGDCCHN> JPMNIFLGBOD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A122C0", Offset = "0x6A10CC0", VA = "0x186A122C0")]
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
