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
public interface MIIAAGHCFJA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OJAGHMJHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PIGMMJCIBMK> EKDGPFIDAGN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PIGMMJCIBMK
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string CKOJFIPAENM
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CKGIAAAENHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool NNNNKHNDGGI
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EHIIBDJIBMK KCAFEPOIDEN(Action<ArraySegment<float>> JMGOMJNPFIN);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IAHLODCCIID();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EHIIBDJIBMK
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int DEHIKFINNNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xC71390", Offset = "0xC70190", VA = "0x180C71390")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xFBB960", Offset = "0xFBA760", VA = "0x180FBB960")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int LOJJDGNLKIP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2B506C0", Offset = "0x2B4F4C0", VA = "0x182B506C0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x65B1030", Offset = "0x65AFE30", VA = "0x1865B1030")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x72CE500", Offset = "0x72CD300", VA = "0x1872CE500")]
	public EHIIBDJIBMK(int DPGFPNEFGIM, int GAKFBKJDFBL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class LEPPGNBOGAH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MIIAAGHCFJA LFBJPHIJGCF;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OJAGHMJHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x7C962B0", Offset = "0x7C950B0", VA = "0x187C962B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C96420", Offset = "0x7C95220", VA = "0x187C96420")]
	static LEPPGNBOGAH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7C96330", Offset = "0x7C95130", VA = "0x187C96330")]
	public static IReadOnlyList<PIGMMJCIBMK> EKDGPFIDAGN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BPECCDNKPCL : MIIAAGHCFJA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class LIJHDABJCMJ : PIGMMJCIBMK
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ECAAAAELPPO
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
			[Cpp2IlInjected.Address(RVA = "0x8FE490", Offset = "0x8FD290", VA = "0x1808FE490")]
			public ECAAAAELPPO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C96130", Offset = "0x7C94F30", VA = "0x187C96130")]
			internal void FEIINIPOCGD(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice JIHJNPJMDDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture LHPOAOCDHGO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NKMNGIIAMNP;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string CKOJFIPAENM
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x7C96980", Offset = "0x7C95780", VA = "0x187C96980", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CKGIAAAENHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xCA2000", Offset = "0xCA0E00", VA = "0x180CA2000", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xCA1EC0", Offset = "0xCA0CC0", VA = "0x180CA1EC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool NNNNKHNDGGI
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC65210", Offset = "0xC64010", VA = "0x180C65210", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C96950", Offset = "0x7C95750", VA = "0x187C96950", Slot = "7")]
		public EHIIBDJIBMK KCAFEPOIDEN(Action<ArraySegment<float>> JMGOMJNPFIN)
		{
			return default(EHIIBDJIBMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x7C96590", Offset = "0x7C95390", VA = "0x187C96590")]
		private EHIIBDJIBMK KCAFEPOIDEN(int DPGFPNEFGIM, int OGJOHOHMGKA, int GAKFBKJDFBL, Action<ArraySegment<float>> JMGOMJNPFIN)
		{
			return default(EHIIBDJIBMK);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x7C96510", Offset = "0x7C95310", VA = "0x187C96510", Slot = "8")]
		public void IAHLODCCIID()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x7C969A0", Offset = "0x7C957A0", VA = "0x187C969A0")]
		public LIJHDABJCMJ(MMDevice JIHJNPJMDDE, bool HHJDCJAFCGM)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<LIJHDABJCMJ> IEECGOPLAID;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OJAGHMJHFOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x910AD0", Offset = "0x90F8D0", VA = "0x180910AD0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C95D80", Offset = "0x7C94B80", VA = "0x187C95D80", Slot = "5")]
	public IReadOnlyList<PIGMMJCIBMK> EKDGPFIDAGN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7C960A0", Offset = "0x7C94EA0", VA = "0x187C960A0")]
	public BPECCDNKPCL()
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
