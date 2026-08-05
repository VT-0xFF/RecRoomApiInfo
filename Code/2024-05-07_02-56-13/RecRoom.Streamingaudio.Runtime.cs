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
public interface MLJBJLAHOGP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool AKOHBJDOOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<CDHKFJGPNOC> CMJCJJIKEHF();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface CDHKFJGPNOC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string IOJNOHEFDDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool CLGFBCBICPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EGLLLPOOPNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	NBCBDMEGLIP JBBLFKAMIEA(Action<ArraySegment<float>> IAPBAMILEGB);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void PJMFLFIKEHN();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct NBCBDMEGLIP
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int MFOGPKKJIAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x91AD60", Offset = "0x919F60", VA = "0x18091AD60")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x91AD70", Offset = "0x919F70", VA = "0x18091AD70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int HJDGODGPAHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x238FDE0", Offset = "0x238EFE0", VA = "0x18238FDE0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x561FD50", Offset = "0x561EF50", VA = "0x18561FD50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB150", Offset = "0x6ABA350", VA = "0x186ABB150")]
	public NBCBDMEGLIP(int CHHJPKKIKAO, int IEKFAFMIKHB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class MBNBMEBHBLH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static MLJBJLAHOGP BIJCGHDLGKC;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool AKOHBJDOOLE
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6ABAFF0", Offset = "0x6ABA1F0", VA = "0x186ABAFF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB060", Offset = "0x6ABA260", VA = "0x186ABB060")]
	static MBNBMEBHBLH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6ABAF00", Offset = "0x6ABA100", VA = "0x186ABAF00")]
	public static IReadOnlyList<CDHKFJGPNOC> CMJCJJIKEHF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class PGJPPDKCHGF : MLJBJLAHOGP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class PINLHCFPAPC : CDHKFJGPNOC
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class PFBEIODHBDP
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
			[Cpp2IlInjected.Address(RVA = "0x7B5FF0", Offset = "0x7B51F0", VA = "0x1807B5FF0")]
			public PFBEIODHBDP()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6ABB160", Offset = "0x6ABA360", VA = "0x186ABB160")]
			internal void FJOODGMNODB(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice HHJMEIEFJNC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture CJELLFMHLMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource NNHNFGJBFGG;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string IOJNOHEFDDD
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6ABBA70", Offset = "0x6ABAC70", VA = "0x186ABBA70", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool CLGFBCBICPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x90D2F0", Offset = "0x90C4F0", VA = "0x18090D2F0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9FB770", Offset = "0x9FA970", VA = "0x1809FB770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EGLLLPOOPNB
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD1CFE0", Offset = "0xD1C1E0", VA = "0x180D1CFE0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB680", Offset = "0x6ABA880", VA = "0x186ABB680", Slot = "7")]
		public NBCBDMEGLIP JBBLFKAMIEA(Action<ArraySegment<float>> IAPBAMILEGB)
		{
			return default(NBCBDMEGLIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6ABB6B0", Offset = "0x6ABA8B0", VA = "0x186ABB6B0")]
		private NBCBDMEGLIP JBBLFKAMIEA(int CHHJPKKIKAO, int FNANHLIHJBO, int IEKFAFMIKHB, Action<ArraySegment<float>> IAPBAMILEGB)
		{
			return default(NBCBDMEGLIP);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBA90", Offset = "0x6ABAC90", VA = "0x186ABBA90", Slot = "8")]
		public void PJMFLFIKEHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6ABBB10", Offset = "0x6ABAD10", VA = "0x186ABBB10")]
		public PINLHCFPAPC(MMDevice HHJMEIEFJNC, bool MHDIKPHFKEN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<PINLHCFPAPC> JNHMHJICPKJ;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool AKOHBJDOOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7CF850", Offset = "0x7CEA50", VA = "0x1807CF850", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB2E0", Offset = "0x6ABA4E0", VA = "0x186ABB2E0", Slot = "5")]
	public IReadOnlyList<CDHKFJGPNOC> CMJCJJIKEHF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6ABB5F0", Offset = "0x6ABA7F0", VA = "0x186ABB5F0")]
	public PGJPPDKCHGF()
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
