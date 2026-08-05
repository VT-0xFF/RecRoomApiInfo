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
		[Cpp2IlInjected.Address(RVA = "0x778E20", Offset = "0x778020", VA = "0x180778E20")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x778D90", Offset = "0x777F90", VA = "0x180778D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int PGIMKBFNLOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x890590", Offset = "0x88F790", VA = "0x180890590")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xEABC90", Offset = "0xEAAE90", VA = "0x180EABC90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6499DC0", Offset = "0x6498FC0", VA = "0x186499DC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6499C70", Offset = "0x6498E70", VA = "0x186499C70")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6499CF0", Offset = "0x6498EF0", VA = "0x186499CF0")]
	static BPBDIDGMDKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6499B70", Offset = "0x6498D70", VA = "0x186499B70")]
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
			[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
			public MEOJCGIOELO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x649A130", Offset = "0x6499330", VA = "0x18649A130")]
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
			[Cpp2IlInjected.Address(RVA = "0x6499B00", Offset = "0x6498D00", VA = "0x186499B00", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DMLHMBKOCHJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x7B7F80", Offset = "0x7B7180", VA = "0x1807B7F80", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x781170", Offset = "0x780370", VA = "0x180781170")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DHFNHNEMPMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x708C60", Offset = "0x707E60", VA = "0x180708C60", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x64996B0", Offset = "0x64988B0", VA = "0x1864996B0", Slot = "7")]
		public DOLBBLBNJJK NHHMMOCACLB(Action<ArraySegment<float>> IGAMPECHIKO)
		{
			return default(DOLBBLBNJJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x64996E0", Offset = "0x64988E0", VA = "0x1864996E0")]
		private DOLBBLBNJJK NHHMMOCACLB(int OANDPKHFOFK, int FFOOLEPKCGE, int PGDEFGJFMKE, Action<ArraySegment<float>> IGAMPECHIKO)
		{
			return default(DOLBBLBNJJK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6499A80", Offset = "0x6498C80", VA = "0x186499A80", Slot = "8")]
		public void OCLIMCEJLJI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6499B20", Offset = "0x6498D20", VA = "0x186499B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x6E8020", Offset = "0x6E7220", VA = "0x1806E8020", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6499DD0", Offset = "0x6498FD0", VA = "0x186499DD0", Slot = "5")]
	public IReadOnlyList<GCFDDGOJGJP> NFBBGKGMLLE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x649A0B0", Offset = "0x64992B0", VA = "0x18649A0B0")]
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
