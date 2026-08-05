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
public interface BNCPBFGOCMD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BMNMFEPAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<ENNFCDAMKAP> KFHJBBHJDMH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface ENNFCDAMKAP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string BPMBBFLJLGH
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool MHIDFJJBKLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool FLHPNMFJHFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	IEIBPHEGANC GFNLNNJFNDI(Action<ArraySegment<float>> KCKLDKHBENC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void MDOABJKHMKE();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct IEIBPHEGANC
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MBHBDFHGDDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B9660", Offset = "0x7B8A60", VA = "0x1807B9660")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B9CB0", Offset = "0x7B90B0", VA = "0x1807B9CB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OMIGDMMINJE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x829550", Offset = "0x828950", VA = "0x180829550")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x829560", Offset = "0x828960", VA = "0x180829560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x1A5B2A0", Offset = "0x1A5A6A0", VA = "0x181A5B2A0")]
	public IEIBPHEGANC(int BJDGGDAMOEM, int BFBNKHIOMCJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BJNNMPFCPDK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static BNCPBFGOCMD FFOFGJKMODA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BMNMFEPAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x1A5A6A0", Offset = "0x1A59AA0", VA = "0x181A5A6A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x1A5A820", Offset = "0x1A59C20", VA = "0x181A5A820")]
	static BJNNMPFCPDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x1A5A720", Offset = "0x1A59B20", VA = "0x181A5A720")]
	public static IReadOnlyList<ENNFCDAMKAP> KFHJBBHJDMH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EIJEEFPNIIN : BNCPBFGOCMD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GBHIJEJCCEP : ENNFCDAMKAP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class DAOGJONBMIM
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
			[Cpp2IlInjected.Address(RVA = "0x6F73F0", Offset = "0x6F67F0", VA = "0x1806F73F0")]
			public DAOGJONBMIM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x1A5A8F0", Offset = "0x1A59CF0", VA = "0x181A5A8F0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice MGEFIFAGBFG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture BDPNIMJCFGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource AHFJENGKIKD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string BPMBBFLJLGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x1A5B1B0", Offset = "0x1A5A5B0", VA = "0x181A5B1B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool MHIDFJJBKLK
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8A81C0", Offset = "0x8A75C0", VA = "0x1808A81C0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8A8250", Offset = "0x8A7650", VA = "0x1808A8250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool FLHPNMFJHFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x872670", Offset = "0x871A70", VA = "0x180872670", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B180", Offset = "0x1A5A580", VA = "0x181A5B180", Slot = "7")]
		public IEIBPHEGANC GFNLNNJFNDI(Action<ArraySegment<float>> KCKLDKHBENC)
		{
			return default(IEIBPHEGANC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x1A5ADE0", Offset = "0x1A5A1E0", VA = "0x181A5ADE0")]
		private IEIBPHEGANC GFNLNNJFNDI(int BJDGGDAMOEM, int NLOMBEPEFEF, int BFBNKHIOMCJ, Action<ArraySegment<float>> KCKLDKHBENC)
		{
			return default(IEIBPHEGANC);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B1D0", Offset = "0x1A5A5D0", VA = "0x181A5B1D0", Slot = "8")]
		public void MDOABJKHMKE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x1A5B250", Offset = "0x1A5A650", VA = "0x181A5B250")]
		public GBHIJEJCCEP(MMDevice MGEFIFAGBFG, bool ODCCNLIFGAH)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GBHIJEJCCEP> HBNAKFNOKGK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BMNMFEPAKJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x798260", Offset = "0x797660", VA = "0x180798260", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x1A5AA80", Offset = "0x1A59E80", VA = "0x181A5AA80", Slot = "5")]
	public IReadOnlyList<ENNFCDAMKAP> KFHJBBHJDMH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x1A5AD60", Offset = "0x1A5A160", VA = "0x181A5AD60")]
	public EIJEEFPNIIN()
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
