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
public interface KKGOPGBPAHE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AOAAPGICHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<GCFDDGOJGJP> NFBBGKGMLLE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface GCFDDGOJGJP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string HEOCCDCMFEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DMLHMBKOCHJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DHFNHNEMPMG
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	DOLBBLBNJJK NHHMMOCACLB(Action<ArraySegment<float>> IGAMPECHIKO);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void OCLIMCEJLJI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct DOLBBLBNJJK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AOJEGONFEOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x725CB0", Offset = "0x7250B0", VA = "0x180725CB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x727530", Offset = "0x726930", VA = "0x180727530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PGIMKBFNLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x761000", Offset = "0x760400", VA = "0x180761000")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x761010", Offset = "0x760410", VA = "0x180761010")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6499590", Offset = "0x6498990", VA = "0x186499590")]
	public DOLBBLBNJJK(int OANDPKHFOFK, int PGDEFGJFMKE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BPBDIDGMDKH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static KKGOPGBPAHE MNPBGJJKLND;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AOAAPGICHFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6499440", Offset = "0x6498840", VA = "0x186499440")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x64994C0", Offset = "0x64988C0", VA = "0x1864994C0")]
	static BPBDIDGMDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6499340", Offset = "0x6498740", VA = "0x186499340")]
	public static IReadOnlyList<GCFDDGOJGJP> NFBBGKGMLLE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class IFDPNNNECJE : KKGOPGBPAHE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class AKALMCMDMME : GCFDDGOJGJP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class MEOJCGIOELO
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
			[Cpp2IlInjected.Address(RVA = "0x6D6CD0", Offset = "0x6D60D0", VA = "0x1806D6CD0")]
			public MEOJCGIOELO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6499900", Offset = "0x6498D00", VA = "0x186499900")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EAADJJGAMGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LJEPPILHEGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PKFGGDPEPOM;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string HEOCCDCMFEI
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x64992D0", Offset = "0x64986D0", VA = "0x1864992D0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DMLHMBKOCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x810280", Offset = "0x80F680", VA = "0x180810280", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x810300", Offset = "0x80F700", VA = "0x180810300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DHFNHNEMPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x81DD20", Offset = "0x81D120", VA = "0x18081DD20", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6498E80", Offset = "0x6498280", VA = "0x186498E80", Slot = "7")]
		public DOLBBLBNJJK NHHMMOCACLB(Action<ArraySegment<float>> IGAMPECHIKO)
		{
			return default(DOLBBLBNJJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6498EB0", Offset = "0x64982B0", VA = "0x186498EB0")]
		private DOLBBLBNJJK NHHMMOCACLB(int OANDPKHFOFK, int FFOOLEPKCGE, int PGDEFGJFMKE, Action<ArraySegment<float>> IGAMPECHIKO)
		{
			return default(DOLBBLBNJJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6499250", Offset = "0x6498650", VA = "0x186499250", Slot = "8")]
		public void OCLIMCEJLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x64992F0", Offset = "0x64986F0", VA = "0x1864992F0")]
		public AKALMCMDMME(MMDevice EAADJJGAMGM, bool NKCLPCKFFLN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<AKALMCMDMME> MAKMPECKEIA;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AOAAPGICHFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6F9850", Offset = "0x6F8C50", VA = "0x1806F9850", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x64995A0", Offset = "0x64989A0", VA = "0x1864995A0", Slot = "5")]
	public IReadOnlyList<GCFDDGOJGJP> NFBBGKGMLLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6499880", Offset = "0x6498C80", VA = "0x186499880")]
	public IFDPNNNECJE()
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
