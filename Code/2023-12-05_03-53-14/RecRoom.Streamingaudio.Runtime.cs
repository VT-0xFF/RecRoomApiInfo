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
public interface OFKLDNIJFJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	bool INKENINLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IReadOnlyList<PHNLCFACHBH> OIAFIFOPIGE();
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public interface PHNLCFACHBH
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	string PBLHAHKJEEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool IJICKIMCCAJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool EMGHMGNHMKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "3")]
	OIJCIJJDLPB ODJMCKFLDMG(Action<ArraySegment<float>> PDECDCHNHMC);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void KAALCMDJKKJ();
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public struct OIJCIJJDLPB
{
	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int AEBBGKMOCJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86A0B0", Offset = "0x8694B0", VA = "0x18086A0B0")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x869FC0", Offset = "0x8693C0", VA = "0x180869FC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int KAIINFAFBOB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x20A0880", Offset = "0x209FC80", VA = "0x1820A0880")]
		[CompilerGenerated]
		readonly get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5303FA0", Offset = "0x53033A0", VA = "0x185303FA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x652DDF0", Offset = "0x652D1F0", VA = "0x18652DDF0")]
	public OIJCIJJDLPB(int LEMOLEBOFBD, int IDHPMFCMABO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class NAJFMILPDMK
{
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static OFKLDNIJFJP CJKMCELIAHH;

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public static bool INKENINLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x652D6B0", Offset = "0x652CAB0", VA = "0x18652D6B0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x652D820", Offset = "0x652CC20", VA = "0x18652D820")]
	static NAJFMILPDMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x652D730", Offset = "0x652CB30", VA = "0x18652D730")]
	public static IReadOnlyList<PHNLCFACHBH> OIAFIFOPIGE()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class KFAFDMBPFCH : OFKLDNIJFJP
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	private class OGJLEJKMBPG : PHNLCFACHBH
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class IAHBGNOKLIF
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
			[Cpp2IlInjected.Address(RVA = "0x778200", Offset = "0x777600", VA = "0x180778200")]
			public IAHBGNOKLIF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x652D180", Offset = "0x652C580", VA = "0x18652D180")]
			internal void CHFMHLKHMMK(object s, DataAvailableEventArgs ea)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private MMDevice NDEHNPGLDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private WasapiLoopbackCapture MJANIEAPNHB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private SoundInSource BDAJFJCALHA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public string PBLHAHKJEEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x652DD80", Offset = "0x652D180", VA = "0x18652DD80", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public bool IJICKIMCCAJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x857250", Offset = "0x856650", VA = "0x180857250", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x90CC90", Offset = "0x90C090", VA = "0x18090CC90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public bool EMGHMGNHMKD
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xC472C0", Offset = "0xC466C0", VA = "0x180C472C0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x652D990", Offset = "0x652CD90", VA = "0x18652D990", Slot = "7")]
		public OIJCIJJDLPB ODJMCKFLDMG(Action<ArraySegment<float>> PDECDCHNHMC)
		{
			return default(OIJCIJJDLPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x652D9C0", Offset = "0x652CDC0", VA = "0x18652D9C0")]
		private OIJCIJJDLPB ODJMCKFLDMG(int LEMOLEBOFBD, int PCNCBONBEOO, int IDHPMFCMABO, Action<ArraySegment<float>> PDECDCHNHMC)
		{
			return default(OIJCIJJDLPB);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x652D910", Offset = "0x652CD10", VA = "0x18652D910", Slot = "8")]
		public void KAALCMDJKKJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x652DDA0", Offset = "0x652D1A0", VA = "0x18652DDA0")]
		public OGJLEJKMBPG(MMDevice NDEHNPGLDKG, bool BGPCOHMIPJP)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private List<OGJLEJKMBPG> EKPFHFKMDLO;

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public bool INKENINLDLG
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x78C310", Offset = "0x78B710", VA = "0x18078C310", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x652D300", Offset = "0x652C700", VA = "0x18652D300", Slot = "5")]
	public IReadOnlyList<PHNLCFACHBH> OIAFIFOPIGE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x652D620", Offset = "0x652CA20", VA = "0x18652D620")]
	public KFAFDMBPFCH()
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
