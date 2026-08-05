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
public interface DJJJPHPEOPA
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool JLDJBEGHFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<IKMLKDJBPDJ> KFHMEPJIBCJ();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface IKMLKDJBPDJ
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string FEHKHNOKCIP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool DPJPBFBOHBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool BOKEOLIBEPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	CMLBOBLOOLN JCDCLPKEKCM(Action<ArraySegment<float>> CGFIJPDBLBH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void CJALDDMANLJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct CMLBOBLOOLN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int JAFJBIAGNAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x727DA0", Offset = "0x7263A0", VA = "0x180727DA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x79DA20", Offset = "0x79C020", VA = "0x18079DA20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HFCMHALGFPL
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8558C0", Offset = "0x853EC0", VA = "0x1808558C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0xFFD990", Offset = "0xFFBF90", VA = "0x180FFD990")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x2078D30", Offset = "0x2077330", VA = "0x182078D30")]
	public CMLBOBLOOLN(int IAGEBAFJFFC, int ONPOHLALKNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class BIIGALAJNBL
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static DJJJPHPEOPA LPEGFKHLMKO;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool JLDJBEGHFDP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x2078C10", Offset = "0x2077210", VA = "0x182078C10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x2078C80", Offset = "0x2077280", VA = "0x182078C80")]
	static BIIGALAJNBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2078B20", Offset = "0x2077120", VA = "0x182078B20")]
	public static IReadOnlyList<IKMLKDJBPDJ> KFHMEPJIBCJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class EKBGOEEMKJM : DJJJPHPEOPA
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class ANCCHNPJOLH : IKMLKDJBPDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class GPCJJHGIDOM
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
			[Cpp2IlInjected.Address(RVA = "0x513010", Offset = "0x511610", VA = "0x180513010")]
			public GPCJJHGIDOM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x2079050", Offset = "0x2077650", VA = "0x182079050")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NNAAFKIDALJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture ABNLBCHBOHG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource AOEACJAPEKA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string FEHKHNOKCIP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x2078740", Offset = "0x2076D40", VA = "0x182078740", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool DPJPBFBOHBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x706230", Offset = "0x704830", VA = "0x180706230", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x706250", Offset = "0x704850", VA = "0x180706250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool BOKEOLIBEPL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x93AFD0", Offset = "0x9395D0", VA = "0x18093AFD0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x2078760", Offset = "0x2076D60", VA = "0x182078760", Slot = "7")]
		public CMLBOBLOOLN JCDCLPKEKCM(Action<ArraySegment<float>> CGFIJPDBLBH)
		{
			return default(CMLBOBLOOLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x2078790", Offset = "0x2076D90", VA = "0x182078790")]
		private CMLBOBLOOLN JCDCLPKEKCM(int IAGEBAFJFFC, int MHCOAOKKOCO, int ONPOHLALKNH, Action<ArraySegment<float>> CGFIJPDBLBH)
		{
			return default(CMLBOBLOOLN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x20786C0", Offset = "0x2076CC0", VA = "0x1820786C0", Slot = "8")]
		public void CJALDDMANLJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x2078AD0", Offset = "0x20770D0", VA = "0x182078AD0")]
		public ANCCHNPJOLH(MMDevice NNAAFKIDALJ, bool POOHCKCIFHD)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<ANCCHNPJOLH> MHJLABFFPND;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool JLDJBEGHFDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x514340", Offset = "0x512940", VA = "0x180514340", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2078D40", Offset = "0x2077340", VA = "0x182078D40", Slot = "5")]
	public IReadOnlyList<IKMLKDJBPDJ> KFHMEPJIBCJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x2078FE0", Offset = "0x20775E0", VA = "0x182078FE0")]
	public EKBGOEEMKJM()
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
