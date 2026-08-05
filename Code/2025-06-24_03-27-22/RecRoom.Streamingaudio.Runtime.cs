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
public interface NBEGMPGHONN
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool KMCEJPAPDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IEBPOMCDJKI> DAKKIIINIKH();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IEBPOMCDJKI
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string DLMLBBCIDKB
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FHBEPENMKCO
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BLCKHEEBBDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	FOFIGOALBJN PGHGEKJMGJA(Action<ArraySegment<float>> LKGGIMHKLEG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void IKINPOGANOM();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct FOFIGOALBJN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int OEIPEPCFGOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD41C90", Offset = "0xD40890", VA = "0x180D41C90")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x140F560", Offset = "0x140E160", VA = "0x18140F560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int IBEOGIKPLME
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2FF6F80", Offset = "0x2FF5B80", VA = "0x182FF6F80")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6FA4900", Offset = "0x6FA3500", VA = "0x186FA4900")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E2A650", Offset = "0x7E29250", VA = "0x187E2A650")]
	public FOFIGOALBJN(int NHBLDIHHBIG, int CGIKOAMACJK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class HBMNLGDGGFH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static NBEGMPGHONN DKNLNFGOMHB;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool KMCEJPAPDGC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x890AF30", Offset = "0x8909B30", VA = "0x18890AF30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x890B090", Offset = "0x8909C90", VA = "0x18890B090")]
	static HBMNLGDGGFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x890AFA0", Offset = "0x8909BA0", VA = "0x18890AFA0")]
	public static IReadOnlyList<IEBPOMCDJKI> DAKKIIINIKH()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KEBPHMIDKBL : NBEGMPGHONN
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class HJIDBDOCGJN : IEBPOMCDJKI
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class JBPGPKJFKGG
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
			[Cpp2IlInjected.Address(RVA = "0xA27AD0", Offset = "0xA266D0", VA = "0x180A27AD0")]
			public JBPGPKJFKGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x890B660", Offset = "0x890A260", VA = "0x18890B660")]
			internal void PHIADFAPFGO(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EKCLMFELBML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture FFJMAJNLIMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource CPMMPBFDPOO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string DLMLBBCIDKB
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x890B180", Offset = "0x8909D80", VA = "0x18890B180", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool FHBEPENMKCO
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xBDFF70", Offset = "0xBDEB70", VA = "0x180BDFF70", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB3BA30", Offset = "0xB3A630", VA = "0x180B3BA30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BLCKHEEBBDP
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xE36EA0", Offset = "0xE35AA0", VA = "0x180E36EA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x890B220", Offset = "0x8909E20", VA = "0x18890B220", Slot = "7")]
		public FOFIGOALBJN PGHGEKJMGJA(Action<ArraySegment<float>> LKGGIMHKLEG)
		{
			return default(FOFIGOALBJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x890B250", Offset = "0x8909E50", VA = "0x18890B250")]
		private FOFIGOALBJN PGHGEKJMGJA(int NHBLDIHHBIG, int DBEJEEGPBCB, int CGIKOAMACJK, Action<ArraySegment<float>> LKGGIMHKLEG)
		{
			return default(FOFIGOALBJN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x890B1A0", Offset = "0x8909DA0", VA = "0x18890B1A0", Slot = "8")]
		public void IKINPOGANOM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x890B610", Offset = "0x890A210", VA = "0x18890B610")]
		public HJIDBDOCGJN(MMDevice EKCLMFELBML, bool GKCOENEPOGD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<HJIDBDOCGJN> IMJPBIOGKOG;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool KMCEJPAPDGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA38390", Offset = "0xA36F90", VA = "0x180A38390", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x890B7E0", Offset = "0x890A3E0", VA = "0x18890B7E0", Slot = "5")]
	public IReadOnlyList<IEBPOMCDJKI> DAKKIIINIKH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x890BAF0", Offset = "0x890A6F0", VA = "0x18890BAF0")]
	public KEBPHMIDKBL()
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
