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
public interface FCBCJFPBHGH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool OBMMLFJFDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<DJBCMMLGPHP> NAAEGAJODBL();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface DJBCMMLGPHP
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string OPFNAEKCLPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool KJGACAHAKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool DPBHHGJPDHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	EPPDICPBOAF NPJLIGOLECP(Action<ArraySegment<float>> BFDLNHAHOHH);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void BACIPBOFEJB();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct EPPDICPBOAF
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int IJJDJLLHCNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xD71620", Offset = "0xD70A20", VA = "0x180D71620")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1530B00", Offset = "0x152FF00", VA = "0x181530B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int JLFHFEANHLD
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBB0", Offset = "0x2FBAFB0", VA = "0x182FBBBB0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x2FBBBA0", Offset = "0x2FBAFA0", VA = "0x182FBBBA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x830C8C0", Offset = "0x830BCC0", VA = "0x18830C8C0")]
	public EPPDICPBOAF(int FCFHMBNBOIH, int MBLOEPMGFGN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class KBOACKMMMJH
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static FCBCJFPBHGH JFFCMECAKDN;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool OBMMLFJFDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x8E33340", Offset = "0x8E32740", VA = "0x188E33340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8E333C0", Offset = "0x8E327C0", VA = "0x188E333C0")]
	static KBOACKMMMJH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x8E33250", Offset = "0x8E32650", VA = "0x188E33250")]
	public static IReadOnlyList<DJBCMMLGPHP> NAAEGAJODBL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class BLEFDHIGLHD : FCBCJFPBHGH
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OKKMMKIHHFK : DJBCMMLGPHP
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AEHAINBEAAL
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
			[Cpp2IlInjected.Address(RVA = "0xA788F0", Offset = "0xA77CF0", VA = "0x180A788F0")]
			public AEHAINBEAAL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x8E32D30", Offset = "0x8E32130", VA = "0x188E32D30")]
			internal void JMCKCLKGFFC(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice BHCBFMACMBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture JBNLDEOKIJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource ACOMGDEBIHC;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string OPFNAEKCLPK
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8E33530", Offset = "0x8E32930", VA = "0x188E33530", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool KJGACAHAKEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0xC1A7E0", Offset = "0xC19BE0", VA = "0x180C1A7E0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xBC1BC0", Offset = "0xBC0FC0", VA = "0x180BC1BC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool DPBHHGJPDHF
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEECBF0", Offset = "0xEEBFF0", VA = "0x180EECBF0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x8E33910", Offset = "0x8E32D10", VA = "0x188E33910", Slot = "7")]
		public EPPDICPBOAF NPJLIGOLECP(Action<ArraySegment<float>> BFDLNHAHOHH)
		{
			return default(EPPDICPBOAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x8E33550", Offset = "0x8E32950", VA = "0x188E33550")]
		private EPPDICPBOAF NPJLIGOLECP(int FCFHMBNBOIH, int OCCKJPCNFLB, int MBLOEPMGFGN, Action<ArraySegment<float>> BFDLNHAHOHH)
		{
			return default(EPPDICPBOAF);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x8E334B0", Offset = "0x8E328B0", VA = "0x188E334B0", Slot = "8")]
		public void BACIPBOFEJB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8E33940", Offset = "0x8E32D40", VA = "0x188E33940")]
		public OKKMMKIHHFK(MMDevice BHCBFMACMBD, bool AOJLHGJBMMN)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OKKMMKIHHFK> HBHFONGJIPI;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool OBMMLFJFDOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0xA89690", Offset = "0xA88A90", VA = "0x180A89690", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x8E32EB0", Offset = "0x8E322B0", VA = "0x188E32EB0", Slot = "5")]
	public IReadOnlyList<DJBCMMLGPHP> NAAEGAJODBL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x8E331C0", Offset = "0x8E325C0", VA = "0x188E331C0")]
	public BLEFDHIGLHD()
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
