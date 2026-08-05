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
public interface MLLPLCCDJHL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool IOPBFDANJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<OKNGGMDCBPC> IICPIOGNGGG();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface OKNGGMDCBPC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DHAGHLNELLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool LOFNOJOLJLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool PPOHPPNJIOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	HAMACAHFMMC HGJDLKEPFLO(Action<ArraySegment<float>> BILBMIBDIIJ);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IADDHHINKFF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct HAMACAHFMMC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int CHMLJNHMIGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x646420", Offset = "0x645620", VA = "0x180646420")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x66D3D0", Offset = "0x66C5D0", VA = "0x18066D3D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int ADLLINFCEMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x646400", Offset = "0x645600", VA = "0x180646400")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1D9B5A0", Offset = "0x1D9A7A0", VA = "0x181D9B5A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x3F99E40", Offset = "0x3F99040", VA = "0x183F99E40")]
	public HAMACAHFMMC(int DAIAFPDEKHP, int HPACACAGGAJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class EPJKFPNIGFF
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MLLPLCCDJHL BAPMNDHFFGO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool IOPBFDANJME
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x3F99C40", Offset = "0x3F98E40", VA = "0x183F99C40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x3F99DA0", Offset = "0x3F98FA0", VA = "0x183F99DA0")]
	static EPJKFPNIGFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3F99CB0", Offset = "0x3F98EB0", VA = "0x183F99CB0")]
	public static IReadOnlyList<OKNGGMDCBPC> IICPIOGNGGG()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class DBCFBHEAHPO : MLLPLCCDJHL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class NAHJABMHEHP : OKNGGMDCBPC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class BOIELGEEBII
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
			[Cpp2IlInjected.Address(RVA = "0x4719D0", Offset = "0x470BD0", VA = "0x1804719D0")]
			public BOIELGEEBII()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x3F997C0", Offset = "0x3F989C0", VA = "0x183F997C0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice LJEBJMICPIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DLNPIHFNFHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BMEEFOKGIBC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DHAGHLNELLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x3F9A1C0", Offset = "0x3F993C0", VA = "0x183F9A1C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool LOFNOJOLJLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x52F760", Offset = "0x52E960", VA = "0x18052F760", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x602F70", Offset = "0x602170", VA = "0x180602F70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool PPOHPPNJIOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B1F00", Offset = "0x8B1100", VA = "0x1808B1F00", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A130", Offset = "0x3F99330", VA = "0x183F9A130", Slot = "7")]
		public HAMACAHFMMC HGJDLKEPFLO(Action<ArraySegment<float>> BILBMIBDIIJ)
		{
			return default(HAMACAHFMMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x3F99E50", Offset = "0x3F99050", VA = "0x183F99E50")]
		private HAMACAHFMMC HGJDLKEPFLO(int DAIAFPDEKHP, int LKONHBFBFCG, int HPACACAGGAJ, Action<ArraySegment<float>> BILBMIBDIIJ)
		{
			return default(HAMACAHFMMC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A160", Offset = "0x3F99360", VA = "0x183F9A160", Slot = "8")]
		public void IADDHHINKFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x3F9A1E0", Offset = "0x3F993E0", VA = "0x183F9A1E0")]
		public NAHJABMHEHP(MMDevice LJEBJMICPIJ, bool OLMMJGNLEOJ)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<NAHJABMHEHP> AEKLHHIJCEJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool IOPBFDANJME
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x46FF60", Offset = "0x46F160", VA = "0x18046FF60", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F99940", Offset = "0x3F98B40", VA = "0x183F99940", Slot = "5")]
	public IReadOnlyList<OKNGGMDCBPC> IICPIOGNGGG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F99BE0", Offset = "0x3F98DE0", VA = "0x183F99BE0")]
	public DBCFBHEAHPO()
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
