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
public interface INJLNANHNCE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool GIOHJJCMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DLAMGEDPFJO> JGFAIBLJGKB();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DLAMGEDPFJO
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string IEGAFNEHLJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool JANDJMLCBHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DEHIOFGJDHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JIELBKJILBN BMOMGKMOMJA(Action<ArraySegment<float>> BNNBDLHMCLC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void DFKIOGBABGI();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JIELBKJILBN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AEINEPBHKHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x952F60", Offset = "0x952360", VA = "0x180952F60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xC76E40", Offset = "0xC76240", VA = "0x180C76E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EMJJBBIPCGB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x27EC6E0", Offset = "0x27EBAE0", VA = "0x1827EC6E0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x6196640", Offset = "0x6195A40", VA = "0x186196640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6E34480", Offset = "0x6E33880", VA = "0x186E34480")]
	public JIELBKJILBN(int BKALKKICPPN, int IEEOOOKNOGA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class AHFJDNFBMFE
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static INJLNANHNCE IKJCOPNBHKP;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool GIOHJJCMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x777F280", Offset = "0x777E680", VA = "0x18777F280")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x777F2F0", Offset = "0x777E6F0", VA = "0x18777F2F0")]
	static AHFJDNFBMFE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x777F190", Offset = "0x777E590", VA = "0x18777F190")]
	public static IReadOnlyList<DLAMGEDPFJO> JGFAIBLJGKB()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ONEAAODBLPA : INJLNANHNCE
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class KAGJMDLKIFB : DLAMGEDPFJO
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IGICJJJPGDO
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
			[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
			public IGICJJJPGDO()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x777F3E0", Offset = "0x777E7E0", VA = "0x18777F3E0")]
			internal void OOGMFLMMJGH(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice EHOKAAOPIKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture DCNFJBHNPDA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource PPNAPNJGIGG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IEGAFNEHLJP
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x777F950", Offset = "0x777ED50", VA = "0x18777F950", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool JANDJMLCBHG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x982980", Offset = "0x981D80", VA = "0x180982980", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x982840", Offset = "0x981C40", VA = "0x180982840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DEHIOFGJDHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x91EAA0", Offset = "0x91DEA0", VA = "0x18091EAA0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x777F560", Offset = "0x777E960", VA = "0x18777F560", Slot = "7")]
		public JIELBKJILBN BMOMGKMOMJA(Action<ArraySegment<float>> BNNBDLHMCLC)
		{
			return default(JIELBKJILBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x777F590", Offset = "0x777E990", VA = "0x18777F590")]
		private JIELBKJILBN BMOMGKMOMJA(int BKALKKICPPN, int JPDKNFGPJEE, int IEEOOOKNOGA, Action<ArraySegment<float>> BNNBDLHMCLC)
		{
			return default(JIELBKJILBN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x777F970", Offset = "0x777ED70", VA = "0x18777F970", Slot = "8")]
		public void DFKIOGBABGI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x777F9F0", Offset = "0x777EDF0", VA = "0x18777F9F0")]
		public KAGJMDLKIFB(MMDevice EHOKAAOPIKL, bool PDNDIDAJLDL)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<KAGJMDLKIFB> AEKAHNIDPEE;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool GIOHJJCMHHL
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x8C5960", Offset = "0x8C4D60", VA = "0x1808C5960", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x777FA40", Offset = "0x777EE40", VA = "0x18777FA40", Slot = "5")]
	public IReadOnlyList<DLAMGEDPFJO> JGFAIBLJGKB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x777FD60", Offset = "0x777F160", VA = "0x18777FD60")]
	public ONEAAODBLPA()
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
