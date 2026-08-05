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
public interface AINDPEEGCDL
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool EDHOFAJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<HIEAPJLOJCH> CLEKDCDAEDN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface HIEAPJLOJCH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GHBCCHGNIIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IFHDANOGOJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool IJDBCHLDCFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	MHGDNMLJBPA HBJDLIJBDGC(Action<ArraySegment<float>> CAEGDBPOJIB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BPJDIPIFAKF();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct MHGDNMLJBPA
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int ILIFIKPINLB
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x82BE10", Offset = "0x82AE10", VA = "0x18082BE10")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x82BE50", Offset = "0x82AE50", VA = "0x18082BE50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int BJEECHMHCBB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x208F330", Offset = "0x208E330", VA = "0x18208F330")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x52EBC80", Offset = "0x52EAC80", VA = "0x1852EBC80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6509910", Offset = "0x6508910", VA = "0x186509910")]
	public MHGDNMLJBPA(int BAKJACPHKMF, int GKOIGDNGOCA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class IHMEJCLHPND
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static AINDPEEGCDL JPFFIECPLOL;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool EDHOFAJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x65097A0", Offset = "0x65087A0", VA = "0x1865097A0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6509820", Offset = "0x6508820", VA = "0x186509820")]
	static IHMEJCLHPND()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x65096B0", Offset = "0x65086B0", VA = "0x1865096B0")]
	public static IReadOnlyList<HIEAPJLOJCH> CLEKDCDAEDN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class NHJLNHPEOOF : AINDPEEGCDL
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PELNKKCMOAP : HIEAPJLOJCH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IGPOEDHALNK
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
			[Cpp2IlInjected.Address(RVA = "0x7734B0", Offset = "0x7724B0", VA = "0x1807734B0")]
			public IGPOEDHALNK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6509530", Offset = "0x6508530", VA = "0x186509530")]
			internal void MMNDAEFPMLM(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HJPNELOMJMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture KFJHOBIKIFA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource GLFIBMMIDBK;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GHBCCHGNIIG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6509D50", Offset = "0x6508D50", VA = "0x186509D50", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IFHDANOGOJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x81F7E0", Offset = "0x81E7E0", VA = "0x18081F7E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8D7190", Offset = "0x8D6190", VA = "0x1808D7190")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool IJDBCHLDCFM
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC131B0", Offset = "0xC121B0", VA = "0x180C131B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6509D70", Offset = "0x6508D70", VA = "0x186509D70", Slot = "7")]
		public MHGDNMLJBPA HBJDLIJBDGC(Action<ArraySegment<float>> CAEGDBPOJIB)
		{
			return default(MHGDNMLJBPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6509DA0", Offset = "0x6508DA0", VA = "0x186509DA0")]
		private MHGDNMLJBPA HBJDLIJBDGC(int BAKJACPHKMF, int KHDBBNEBPGL, int GKOIGDNGOCA, Action<ArraySegment<float>> CAEGDBPOJIB)
		{
			return default(MHGDNMLJBPA);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6509CD0", Offset = "0x6508CD0", VA = "0x186509CD0", Slot = "8")]
		public void BPJDIPIFAKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x650A160", Offset = "0x6509160", VA = "0x18650A160")]
		public PELNKKCMOAP(MMDevice HJPNELOMJMN, bool KMJPBPAFHDP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PELNKKCMOAP> LNLADMILLOK;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool EDHOFAJAFEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78B130", Offset = "0x78A130", VA = "0x18078B130", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6509920", Offset = "0x6508920", VA = "0x186509920", Slot = "5")]
	public IReadOnlyList<HIEAPJLOJCH> CLEKDCDAEDN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6509C40", Offset = "0x6508C40", VA = "0x186509C40")]
	public NHJLNHPEOOF()
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
