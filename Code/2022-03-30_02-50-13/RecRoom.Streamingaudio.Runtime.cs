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
public interface ADJNBLPBBDD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool BOPMAFMCCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<KPOONDJJMIE> KDKCLBCGKAN();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface KPOONDJJMIE
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string GPOGLIMEIBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool ADENFLMJEKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LONIMBCBNAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	JCILLEADMDN EEEEBEEBKNO(Action<ArraySegment<float>> MCONDHIGJPI);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void NGJLIGOCIDO();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct JCILLEADMDN
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int NMFDDOLLKLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D20", Offset = "0x6B5320", VA = "0x1806B6D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x71A8B0", Offset = "0x718EB0", VA = "0x18071A8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int EJOCBCFBOLF
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6B6D00", Offset = "0x6B5300", VA = "0x1806B6D00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x70AB90", Offset = "0x709190", VA = "0x18070AB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x4B400A0", Offset = "0x4B3E6A0", VA = "0x184B400A0")]
	public JCILLEADMDN(int LFFIGKINJKB, int ODCOPLCHNNH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class CAKIMHNABIO
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static ADJNBLPBBDD EJGHMPACKOA;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool BOPMAFMCCPC
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x4B3FA30", Offset = "0x4B3E030", VA = "0x184B3FA30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FB90", Offset = "0x4B3E190", VA = "0x184B3FB90")]
	static CAKIMHNABIO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x4B3FAA0", Offset = "0x4B3E0A0", VA = "0x184B3FAA0")]
	public static IReadOnlyList<KPOONDJJMIE> KDKCLBCGKAN()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class MCPIGJFILLF : ADJNBLPBBDD
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class GEOGPNFIOCL : KPOONDJJMIE
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class ACGGFMIBEIE
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
			[Cpp2IlInjected.Address(RVA = "0x522AB0", Offset = "0x5210B0", VA = "0x180522AB0")]
			public ACGGFMIBEIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x4B3F8B0", Offset = "0x4B3DEB0", VA = "0x184B3F8B0")]
			internal void <StartListening>b__0(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NLNBAICOLNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture HLLKHOALKKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource GHIBKBKDGAO;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string GPOGLIMEIBG
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x4B3FFB0", Offset = "0x4B3E5B0", VA = "0x184B3FFB0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool ADENFLMJEKH
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x54C310", Offset = "0x54A910", VA = "0x18054C310", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x974E20", Offset = "0x973420", VA = "0x180974E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool LONIMBCBNAL
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x6426B0", Offset = "0x640CB0", VA = "0x1806426B0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x4B3FC40", Offset = "0x4B3E240", VA = "0x184B3FC40", Slot = "7")]
		public JCILLEADMDN EEEEBEEBKNO(Action<ArraySegment<float>> MCONDHIGJPI)
		{
			return default(JCILLEADMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4B3FC70", Offset = "0x4B3E270", VA = "0x184B3FC70")]
		private JCILLEADMDN EEEEBEEBKNO(int LFFIGKINJKB, int ECKEEEJCJMF, int ODCOPLCHNNH, Action<ArraySegment<float>> MCONDHIGJPI)
		{
			return default(JCILLEADMDN);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x4B3FFD0", Offset = "0x4B3E5D0", VA = "0x184B3FFD0", Slot = "8")]
		public void NGJLIGOCIDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4B40050", Offset = "0x4B3E650", VA = "0x184B40050")]
		public GEOGPNFIOCL(MMDevice NLNBAICOLNN, bool IKANNHKAPCK)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<GEOGPNFIOCL> CIALJKJLAAL;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool BOPMAFMCCPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x520FE0", Offset = "0x51F5E0", VA = "0x180520FE0", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x4B400B0", Offset = "0x4B3E6B0", VA = "0x184B400B0", Slot = "5")]
	public IReadOnlyList<KPOONDJJMIE> KDKCLBCGKAN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x4B40350", Offset = "0x4B3E950", VA = "0x184B40350")]
	public MCPIGJFILLF()
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
